Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web



Public Class FrmPQHelper
    Inherits Form

    Private pqFiles As List(Of String)

    Private Async Sub FrmPQHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadPQFilesAsync()
        Await LoadModules()

    End Sub


    Private Async Function LoadPQFilesAsync() As Task
        Dim repoUrl As String = "https://api.github.com/repos/cbaragao/PQ-Shared-Library/git/trees/main?recursive=1"
        Dim client As New HttpClient()
        client.DefaultRequestHeaders.UserAgent.ParseAdd("request") ' GitHub API requires a User-Agent header

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync(repoUrl)
            response.EnsureSuccessStatusCode()

            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            Dim files As JObject = JsonConvert.DeserializeObject(Of JObject)(responseBody)

            pqFiles = files("tree").Where(Function(f) f("path").ToString().EndsWith(".pq")).Select(Function(f) f("path").ToString()).ToList()

            lbLibrary.Items.AddRange(pqFiles.ToArray())
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Function

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.ToLower()
        Dim filteredFiles = pqFiles.Where(Function(f) f.ToLower().Contains(searchText)).ToList()

        lbLibrary.Items.Clear()
        lbLibrary.Items.AddRange(filteredFiles.ToArray())
    End Sub

    Private Async Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        Dim code As String = txtFormat.Text
        Dim resultType As String = "text" ' Adjust as needed

        Dim formattedCode As String = Await FormatPQAsync(code, resultType)

        If chkFormatSteps.Checked Then
            formattedCode = System.Text.RegularExpressions.Regex.Replace(formattedCode, "#""([^""]+)""", Function(m) m.Groups(1).Value.Replace(" ", "_"))
        End If

        txtFormat.Text = formattedCode

        If Not String.IsNullOrEmpty(formattedCode) Then
            MessageBox.Show("Code formatted successfully.")
        End If
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Try
            Dim formattedCode As String = txtFormat.Text
            Clipboard.SetText(formattedCode)
            MessageBox.Show("Formatted code copied to clipboard.")
        Catch ex As Exception
            MessageBox.Show("An error occurred while copying the formatted code.")
        End Try
    End Sub

    Private Async Function FormatPQAsync(
        code As String,
        resultType As String,
        Optional lineWidth As Integer = 80,
        Optional indentationLength As Integer = 2,
        Optional includeComments As Boolean = True,
        Optional surroundBracesWithWs As Boolean = False,
        Optional indentSectionMembers As Boolean = True,
        Optional alignLineCommentsToPosition As Integer = 0,
        Optional alignPairedLetExpressionsByEqual As String = "never",
        Optional alignPairedRecordExpressionsByEqual As String = "never",
        Optional indentation As String = "spaces",
        Optional ws As String = " ",
        Optional lineEnd As String = vbLf) As Task(Of String)

        Dim body = New With {
            .code = code,
            .resultType = resultType,
            .lineWidth = lineWidth,
            .indentationLength = indentationLength,
            .includeComments = includeComments,
            .surroundBracesWithWs = surroundBracesWithWs,
            .indentSectionMembers = indentSectionMembers,
            .alignLineCommentsToPosition = alignLineCommentsToPosition,
            .alignPairedLetExpressionsByEqual = alignPairedLetExpressionsByEqual,
            .alignPairedRecordExpressionsByEqual = alignPairedRecordExpressionsByEqual,
            .indentation = indentation,
            .ws = ws,
            .lineEnd = lineEnd
        }

        Dim jsonBody = JsonConvert.SerializeObject(body)
        Dim content = New StringContent(jsonBody, Encoding.UTF8, "application/json")
        Dim url = "https://m-formatter.azurewebsites.net/api/v2"
        Dim client As New HttpClient()

        ' Ensure headers are set correctly
        content.Headers.ContentType = New MediaTypeHeaderValue("application/json")
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
        Try
            Dim response = Await client.PostAsync(url, content)
            Dim responseBody = Await response.Content.ReadAsStringAsync()

            If Not response.IsSuccessStatusCode Then
                MessageBox.Show($"HTTP Request Error: {response.StatusCode} - {response.ReasonPhrase}{vbCrLf}Response Body: {responseBody}")
                Return Nothing
            End If

            Dim result = JsonConvert.DeserializeObject(Of JObject)(responseBody)
            Dim formattedQuery As String = result("result").ToString().Replace("\r\n", vbCrLf)
            Return formattedQuery
        Catch ex As HttpRequestException
            MessageBox.Show($"HTTP Request Error: {ex.Message}")
            Return Nothing
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
            Return Nothing
        End Try
    End Function




    Private Async Function LoadModules() As Task
        Try
            ' Calculate the date 60 days in the past
            Dim pastDate As DateTime = DateTime.UtcNow.AddDays(-60)
            Dim formattedDate As String = pastDate.ToString("yyyy-MM-dd")

            ' API endpoint with dynamic date
            Dim apiUrl As String = $"https://learn.microsoft.com/api/catalog/?product=power-bi&type=modules&last_modified=gte%20{formattedDate}"

            Using client As New HttpClient()
                Dim jsonResponse As String = Await client.GetStringAsync(apiUrl)
                Dim root As Root = JsonConvert.DeserializeObject(Of Root)(jsonResponse)

                If root?.Modules IsNot Nothing Then
                    If lbMLearn IsNot Nothing Then
                        lbMLearn.DataSource = root.Modules
                        lbMLearn.DisplayMember = "Url"
                    Else
                        ' Handle the case where lbLearn is Nothing
                        MessageBox.Show("lbLearn control is not initialized.")
                    End If

                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading modules: {ex.Message}")
        End Try



    End Function

    Private Sub lbMLearn_SelectedIndexChanged(sender As Object, e As EventArgs)
        If TypeOf lbMLearn.SelectedItem Is [Module] Then
            Dim selectedModule = CType(lbMLearn.SelectedItem, [Module])
            Process.Start(New ProcessStartInfo With {
                .FileName = selectedModule.Url,
                .UseShellExecute = True
            })
        End If
    End Sub

    Private Sub btnLearn_Click(sender As Object, e As EventArgs) Handles btnLearn.Click
        If lbMLearn.SelectedItem IsNot Nothing Then
            Dim selectedModule = CType(lbMLearn.SelectedItem, [Module])
            Process.Start(New ProcessStartInfo With {
                .FileName = selectedModule.Url,
                .UseShellExecute = True
            })
        End If
    End Sub

    Private Sub btnOpenPQHow_Click(sender As Object, e As EventArgs) Handles btnOpenPQHow.Click
        Dim searchText As String = txtSearchPQHow.Text.Trim()
        Dim url As String

        If String.IsNullOrEmpty(searchText) Then
            url = "https://powerquery.how"
        Else
            url = "https://powerquery.how/?s=" & HttpUtility.UrlEncode(searchText)
        End If

        Dim psi As New ProcessStartInfo(url) With {
        .UseShellExecute = True
    }
        Process.Start(psi)

    End Sub

    Private Sub btnCopyPQ_Click(sender As Object, e As EventArgs) Handles btnCopyPQ.Click
        If lbLibrary.SelectedItem IsNot Nothing Then
            Try
                Dim selectedItem As String = lbLibrary.SelectedItem.ToString()
                Dim fileUrl As String = $"https://raw.githubusercontent.com/cbaragao/PQ-Shared-Library/main/{selectedItem}"
                Dim client As New HttpClient()
                Dim fileContent As String = client.GetStringAsync(fileUrl).Result

                Dim parsedValue As String = selectedItem.Split("/"c)(selectedItem.Split("/"c).Length - 1).Replace(".pq", "")
                fileContent = "// " & parsedValue & vbCrLf & fileContent

                Clipboard.SetText(fileContent)
                MessageBox.Show("File content copied to clipboard.")
            Catch ex As Exception
                MessageBox.Show("An error occurred while copying the file content.")
            End Try
        Else
            MessageBox.Show("Please select a file from the list.")
        End If
    End Sub

    Private Sub btnGetParams_Click(sender As Object, e As EventArgs) Handles btnGetParams.Click
        Dim code As String = txtParamCode.Text
        Dim pattern As String = """(http[^""]+|[a-zA-Z]:\\[^""]+)"""
        Dim matches As MatchCollection = Regex.Matches(code, pattern)

        If matches.Count > 0 Then
            lbParams.Items.Clear()
            For Each match As Match In matches
                Dim paramString As String = $"=""{match.Groups(1).Value}"" meta [IsParameterQuery=true, Type=""Text"", IsParameterQueryRequired=true]"
                lbParams.Items.Add(paramString)
            Next
        Else
            MessageBox.Show("No matches found.")
        End If
    End Sub

    Private Sub btnClearParams_Click(sender As Object, e As EventArgs) Handles btnClearParams.Click
        txtParamCode.Clear()
        lbParams.Items.Clear()
    End Sub

    Private Sub btnCopyParam_Click(sender As Object, e As EventArgs) Handles btnCopyParam.Click
        If lbParams.SelectedItem IsNot Nothing Then
            Dim selectedItem As String = lbParams.SelectedItem.ToString()
            Clipboard.SetText(selectedItem)
            MessageBox.Show("Selected item copied to clipboard.")
        Else
            MessageBox.Show("Please select an item.")
        End If
    End Sub

    Private Sub btnClearFormat_Click(sender As Object, e As EventArgs) Handles btnClearFormat.Click
        txtFormat.Clear()
    End Sub

    Private Sub btnClearPQ_Click(sender As Object, e As EventArgs) Handles btnClearPQ.Click
        txtSearchPQHow.Clear()
    End Sub
End Class

Public Class Root
    <JsonProperty("modules")>
    Public Property Modules As List(Of [Module])
End Class

Public Class [Module]
    <JsonProperty("title")>
    Public Property Title As String

    <JsonProperty("last_modified")>
    Public Property LastModified As String

    <JsonProperty("url")>
    Public Property Url As String
End Class