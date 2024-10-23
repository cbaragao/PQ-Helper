<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPQHelper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPQHelper))
        tcMain = New TabControl()
        tpLibrary = New TabPage()
        btnCopyPQ = New Button()
        lbLibrary = New ListBox()
        Label1 = New Label()
        txtSearch = New TextBox()
        tpFormat = New TabPage()
        Label5 = New Label()
        btnClearFormat = New Button()
        btnCopy = New Button()
        btnFormat = New Button()
        chkFormatSteps = New CheckBox()
        txtFormat = New TextBox()
        tpLearn = New TabPage()
        btnClearPQ = New Button()
        btnOpenPQHow = New Button()
        Label3 = New Label()
        txtSearchPQHow = New TextBox()
        Label2 = New Label()
        btnLearn = New Button()
        lbMLearn = New ListBox()
        tpParams = New TabPage()
        btnCopyParam = New Button()
        btnClearParams = New Button()
        lblParameters = New Label()
        btnGetParams = New Button()
        lbParams = New ListBox()
        Label4 = New Label()
        txtParamCode = New TextBox()
        tcMain.SuspendLayout()
        tpLibrary.SuspendLayout()
        tpFormat.SuspendLayout()
        tpLearn.SuspendLayout()
        tpParams.SuspendLayout()
        SuspendLayout()
        ' 
        ' tcMain
        ' 
        tcMain.Controls.Add(tpLibrary)
        tcMain.Controls.Add(tpFormat)
        tcMain.Controls.Add(tpLearn)
        tcMain.Controls.Add(tpParams)
        tcMain.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tcMain.Location = New Point(8, 12)
        tcMain.Name = "tcMain"
        tcMain.SelectedIndex = 0
        tcMain.Size = New Size(764, 537)
        tcMain.TabIndex = 0
        ' 
        ' tpLibrary
        ' 
        tpLibrary.BackColor = Color.White
        tpLibrary.Controls.Add(btnCopyPQ)
        tpLibrary.Controls.Add(lbLibrary)
        tpLibrary.Controls.Add(Label1)
        tpLibrary.Controls.Add(txtSearch)
        tpLibrary.Location = New Point(4, 29)
        tpLibrary.Name = "tpLibrary"
        tpLibrary.Padding = New Padding(3)
        tpLibrary.Size = New Size(756, 504)
        tpLibrary.TabIndex = 0
        tpLibrary.Text = "Library"
        ' 
        ' btnCopyPQ
        ' 
        btnCopyPQ.BackColor = Color.ForestGreen
        btnCopyPQ.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCopyPQ.ForeColor = Color.White
        btnCopyPQ.Location = New Point(20, 450)
        btnCopyPQ.Name = "btnCopyPQ"
        btnCopyPQ.Size = New Size(120, 30)
        btnCopyPQ.TabIndex = 3
        btnCopyPQ.Text = "Copy Code"
        btnCopyPQ.UseVisualStyleBackColor = False
        ' 
        ' lbLibrary
        ' 
        lbLibrary.BackColor = Color.White
        lbLibrary.BorderStyle = BorderStyle.FixedSingle
        lbLibrary.FormattingEnabled = True
        lbLibrary.ItemHeight = 20
        lbLibrary.Location = New Point(20, 80)
        lbLibrary.Name = "lbLibrary"
        lbLibrary.Size = New Size(700, 362)
        lbLibrary.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(20, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 21)
        Label1.TabIndex = 1
        Label1.Text = "Search the Library"
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Location = New Point(20, 40)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(292, 27)
        txtSearch.TabIndex = 0
        ' 
        ' tpFormat
        ' 
        tpFormat.BackColor = Color.White
        tpFormat.Controls.Add(Label5)
        tpFormat.Controls.Add(btnClearFormat)
        tpFormat.Controls.Add(btnCopy)
        tpFormat.Controls.Add(btnFormat)
        tpFormat.Controls.Add(chkFormatSteps)
        tpFormat.Controls.Add(txtFormat)
        tpFormat.Location = New Point(4, 29)
        tpFormat.Name = "tpFormat"
        tpFormat.Padding = New Padding(3)
        tpFormat.Size = New Size(756, 504)
        tpFormat.TabIndex = 1
        tpFormat.Text = "Format"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(20, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 21)
        Label5.TabIndex = 7
        Label5.Text = "Paste M Code"
        ' 
        ' btnClearFormat
        ' 
        btnClearFormat.BackColor = Color.DimGray
        btnClearFormat.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearFormat.ForeColor = Color.White
        btnClearFormat.Location = New Point(280, 450)
        btnClearFormat.Name = "btnClearFormat"
        btnClearFormat.Size = New Size(120, 30)
        btnClearFormat.TabIndex = 6
        btnClearFormat.Text = "Clear"
        btnClearFormat.UseVisualStyleBackColor = False
        ' 
        ' btnCopy
        ' 
        btnCopy.BackColor = Color.ForestGreen
        btnCopy.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCopy.ForeColor = Color.White
        btnCopy.Location = New Point(150, 450)
        btnCopy.Name = "btnCopy"
        btnCopy.Size = New Size(120, 30)
        btnCopy.TabIndex = 3
        btnCopy.TabStop = False
        btnCopy.Text = "Copy"
        btnCopy.UseVisualStyleBackColor = False
        ' 
        ' btnFormat
        ' 
        btnFormat.BackColor = Color.ForestGreen
        btnFormat.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFormat.ForeColor = Color.White
        btnFormat.Location = New Point(20, 450)
        btnFormat.Name = "btnFormat"
        btnFormat.Size = New Size(120, 30)
        btnFormat.TabIndex = 2
        btnFormat.Text = "Format"
        btnFormat.UseVisualStyleBackColor = False
        ' 
        ' chkFormatSteps
        ' 
        chkFormatSteps.AutoSize = True
        chkFormatSteps.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkFormatSteps.Location = New Point(20, 420)
        chkFormatSteps.Name = "chkFormatSteps"
        chkFormatSteps.Size = New Size(135, 25)
        chkFormatSteps.TabIndex = 1
        chkFormatSteps.Text = "Reformat Steps"
        chkFormatSteps.UseVisualStyleBackColor = True
        ' 
        ' txtFormat
        ' 
        txtFormat.BorderStyle = BorderStyle.FixedSingle
        txtFormat.Location = New Point(20, 40)
        txtFormat.Multiline = True
        txtFormat.Name = "txtFormat"
        txtFormat.Size = New Size(710, 376)
        txtFormat.TabIndex = 0
        ' 
        ' tpLearn
        ' 
        tpLearn.BackColor = Color.White
        tpLearn.Controls.Add(btnClearPQ)
        tpLearn.Controls.Add(btnOpenPQHow)
        tpLearn.Controls.Add(Label3)
        tpLearn.Controls.Add(txtSearchPQHow)
        tpLearn.Controls.Add(Label2)
        tpLearn.Controls.Add(btnLearn)
        tpLearn.Controls.Add(lbMLearn)
        tpLearn.Location = New Point(4, 29)
        tpLearn.Name = "tpLearn"
        tpLearn.Size = New Size(756, 504)
        tpLearn.TabIndex = 2
        tpLearn.Text = "Learn"
        ' 
        ' btnClearPQ
        ' 
        btnClearPQ.BackColor = Color.DimGray
        btnClearPQ.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearPQ.ForeColor = Color.White
        btnClearPQ.Location = New Point(190, 70)
        btnClearPQ.Name = "btnClearPQ"
        btnClearPQ.Size = New Size(120, 30)
        btnClearPQ.TabIndex = 7
        btnClearPQ.Text = "Clear"
        btnClearPQ.UseVisualStyleBackColor = False
        ' 
        ' btnOpenPQHow
        ' 
        btnOpenPQHow.BackColor = Color.ForestGreen
        btnOpenPQHow.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOpenPQHow.ForeColor = Color.White
        btnOpenPQHow.Location = New Point(20, 70)
        btnOpenPQHow.Name = "btnOpenPQHow"
        btnOpenPQHow.Size = New Size(120, 30)
        btnOpenPQHow.TabIndex = 5
        btnOpenPQHow.Text = "Open PowerQuery.How"
        btnOpenPQHow.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(20, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(256, 21)
        Label3.TabIndex = 4
        Label3.Text = "Search PowerQuery.How (Optional)"
        ' 
        ' txtSearchPQHow
        ' 
        txtSearchPQHow.BorderStyle = BorderStyle.FixedSingle
        txtSearchPQHow.Location = New Point(20, 40)
        txtSearchPQHow.Name = "txtSearchPQHow"
        txtSearchPQHow.Size = New Size(289, 27)
        txtSearchPQHow.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(448, 21)
        Label2.TabIndex = 2
        Label2.Text = "New/Updated Microsoft Learn Power BI Modules (Last 60 days)"
        ' 
        ' btnLearn
        ' 
        btnLearn.BackColor = Color.ForestGreen
        btnLearn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLearn.ForeColor = Color.White
        btnLearn.Location = New Point(20, 420)
        btnLearn.Name = "btnLearn"
        btnLearn.Size = New Size(120, 30)
        btnLearn.TabIndex = 1
        btnLearn.Text = "View Module"
        btnLearn.UseVisualStyleBackColor = False
        ' 
        ' lbMLearn
        ' 
        lbMLearn.BorderStyle = BorderStyle.FixedSingle
        lbMLearn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbMLearn.FormattingEnabled = True
        lbMLearn.ItemHeight = 21
        lbMLearn.Location = New Point(20, 180)
        lbMLearn.Name = "lbMLearn"
        lbMLearn.Size = New Size(619, 233)
        lbMLearn.TabIndex = 0
        ' 
        ' tpParams
        ' 
        tpParams.BackColor = Color.White
        tpParams.Controls.Add(btnCopyParam)
        tpParams.Controls.Add(btnClearParams)
        tpParams.Controls.Add(lblParameters)
        tpParams.Controls.Add(btnGetParams)
        tpParams.Controls.Add(lbParams)
        tpParams.Controls.Add(Label4)
        tpParams.Controls.Add(txtParamCode)
        tpParams.Location = New Point(4, 29)
        tpParams.Name = "tpParams"
        tpParams.Size = New Size(756, 504)
        tpParams.TabIndex = 3
        tpParams.Text = "Params"
        ' 
        ' btnCopyParam
        ' 
        btnCopyParam.BackColor = Color.ForestGreen
        btnCopyParam.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCopyParam.ForeColor = Color.White
        btnCopyParam.Location = New Point(20, 440)
        btnCopyParam.Name = "btnCopyParam"
        btnCopyParam.Size = New Size(120, 30)
        btnCopyParam.TabIndex = 6
        btnCopyParam.Text = "Copy Param"
        btnCopyParam.UseVisualStyleBackColor = False
        ' 
        ' btnClearParams
        ' 
        btnClearParams.BackColor = Color.DimGray
        btnClearParams.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearParams.ForeColor = Color.White
        btnClearParams.Location = New Point(150, 230)
        btnClearParams.Name = "btnClearParams"
        btnClearParams.Size = New Size(120, 30)
        btnClearParams.TabIndex = 5
        btnClearParams.Text = "Clear"
        btnClearParams.UseVisualStyleBackColor = False
        ' 
        ' lblParameters
        ' 
        lblParameters.AutoSize = True
        lblParameters.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblParameters.Location = New Point(20, 280)
        lblParameters.Name = "lblParameters"
        lblParameters.Size = New Size(88, 21)
        lblParameters.TabIndex = 4
        lblParameters.Text = "Parameters"
        ' 
        ' btnGetParams
        ' 
        btnGetParams.BackColor = Color.ForestGreen
        btnGetParams.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGetParams.ForeColor = Color.White
        btnGetParams.Location = New Point(20, 230)
        btnGetParams.Name = "btnGetParams"
        btnGetParams.Size = New Size(120, 30)
        btnGetParams.TabIndex = 3
        btnGetParams.Text = "Get Params"
        btnGetParams.UseVisualStyleBackColor = False
        ' 
        ' lbParams
        ' 
        lbParams.FormattingEnabled = True
        lbParams.ItemHeight = 20
        lbParams.Location = New Point(20, 310)
        lbParams.Name = "lbParams"
        lbParams.Size = New Size(709, 124)
        lbParams.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 20)
        Label4.TabIndex = 1
        Label4.Text = "Paste M Code"
        ' 
        ' txtParamCode
        ' 
        txtParamCode.Location = New Point(20, 40)
        txtParamCode.Multiline = True
        txtParamCode.Name = "txtParamCode"
        txtParamCode.Size = New Size(709, 179)
        txtParamCode.TabIndex = 0
        ' 
        ' FrmPQHelper
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.ForestGreen
        ClientSize = New Size(784, 561)
        Controls.Add(tcMain)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmPQHelper"
        Text = "Power Query Helper"
        tcMain.ResumeLayout(False)
        tpLibrary.ResumeLayout(False)
        tpLibrary.PerformLayout()
        tpFormat.ResumeLayout(False)
        tpFormat.PerformLayout()
        tpLearn.ResumeLayout(False)
        tpLearn.PerformLayout()
        tpParams.ResumeLayout(False)
        tpParams.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpLibrary As TabPage
    Friend WithEvents tpFormat As TabPage
    Friend WithEvents tpLearn As TabPage
    Friend WithEvents tpParams As TabPage
    Friend WithEvents lbLibrary As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnFormat As Button
    Friend WithEvents chkFormatSteps As CheckBox
    Friend WithEvents txtFormat As TextBox
    Friend WithEvents lbMLearn As ListBox
    Friend WithEvents btnLearn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearchPQHow As TextBox
    Friend WithEvents btnOpenPQHow As Button
    Friend WithEvents btnCopyPQ As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtParamCode As TextBox
    Friend WithEvents lblParameters As Label
    Friend WithEvents btnGetParams As Button
    Friend WithEvents lbParams As ListBox
    Friend WithEvents btnClearParams As Button
    Friend WithEvents btnCopyParam As Button
    Friend WithEvents btnClearFormat As Button
    Friend WithEvents btnClearPQ As Button
    Friend WithEvents Label5 As Label

End Class
