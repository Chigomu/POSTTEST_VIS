<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        lblPredikat = New Label()
        txtIPSemester = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        txtIPKumulatif = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(89, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(89, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 1
        Label2.Text = "IP Kumulatif:"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(181, 234)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(12, 15)
        lblPredikat.TabIndex = 2
        lblPredikat.Text = "-"
        lblPredikat.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(181, 132)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(165, 23)
        txtIPSemester.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(181, 161)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(271, 161)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtIPKumulatif
        ' 
        txtIPKumulatif.Location = New Point(181, 195)
        txtIPKumulatif.Name = "txtIPKumulatif"
        txtIPKumulatif.ReadOnly = True
        txtIPKumulatif.Size = New Size(165, 23)
        txtIPKumulatif.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(452, 360)
        Controls.Add(txtIPKumulatif)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPSemester)
        Controls.Add(lblPredikat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPKumulatif As TextBox

End Class
