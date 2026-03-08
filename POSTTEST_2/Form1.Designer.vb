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
        grbHapus = New GroupBox()
        txtJudulHapus = New TextBox()
        Label3 = New Label()
        btnHapus = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtJudulTambah = New TextBox()
        txtGenre = New TextBox()
        btnTambah = New Button()
        grbTambah = New GroupBox()
        lstBuku = New ListBox()
        grbHapus.SuspendLayout()
        grbTambah.SuspendLayout()
        SuspendLayout()
        ' 
        ' grbHapus
        ' 
        grbHapus.Controls.Add(txtJudulHapus)
        grbHapus.Controls.Add(Label3)
        grbHapus.Controls.Add(btnHapus)
        grbHapus.Location = New Point(286, 12)
        grbHapus.Name = "grbHapus"
        grbHapus.Size = New Size(254, 145)
        grbHapus.TabIndex = 1
        grbHapus.TabStop = False
        grbHapus.Text = "Hapus Buku"
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(80, 35)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(168, 23)
        txtJudulHapus.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 1
        Label3.Text = "Judul Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(173, 108)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 0
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Location = New Point(94, 27)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(168, 23)
        txtJudulTambah.TabIndex = 2
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(94, 68)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(168, 23)
        txtGenre.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(187, 108)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' grbTambah
        ' 
        grbTambah.BackColor = SystemColors.Control
        grbTambah.Controls.Add(btnTambah)
        grbTambah.Controls.Add(txtGenre)
        grbTambah.Controls.Add(txtJudulTambah)
        grbTambah.Controls.Add(Label2)
        grbTambah.Controls.Add(Label1)
        grbTambah.Location = New Point(12, 12)
        grbTambah.Name = "grbTambah"
        grbTambah.Size = New Size(268, 145)
        grbTambah.TabIndex = 0
        grbTambah.TabStop = False
        grbTambah.Text = "Tambah Buku"
        ' 
        ' lstBuku
        ' 
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(12, 174)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(528, 124)
        lstBuku.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(552, 317)
        Controls.Add(lstBuku)
        Controls.Add(grbHapus)
        Controls.Add(grbTambah)
        Font = New Font("Segoe UI", 9F)
        Name = "Form1"
        Text = "2409106033 - Febrian Pratama Saputra - Posttest 2"
        grbHapus.ResumeLayout(False)
        grbHapus.PerformLayout()
        grbTambah.ResumeLayout(False)
        grbTambah.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents grbHapus As GroupBox
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents grbTambah As GroupBox
    Friend WithEvents lstBuku As ListBox

End Class
