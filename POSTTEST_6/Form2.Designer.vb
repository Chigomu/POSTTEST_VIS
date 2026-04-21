<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtCari = New TextBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1 = New Panel()
        Label4 = New Label()
        btnHapus = New Button()
        dgvSekolah = New DataGridView()
        btnUbah = New Button()
        btnSimpan = New Button()
        btnBatal = New Button()
        txtMoto = New TextBox()
        Label2 = New Label()
        txtDistrik = New TextBox()
        Label5 = New Label()
        txtNamaLengkap = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dgvSekolah, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(80, 209)
        txtCari.Margin = New Padding(4, 2, 4, 2)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(533, 23)
        txtCari.TabIndex = 50
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Noto Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(74, 19)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(541, 41)
        Label6.TabIndex = 1
        Label6.Text = "SISTEM PENDATAAN SEKOLAH KIVOTOS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(4, 2)
        PictureBox1.Margin = New Padding(4, 2, 4, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 212)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 51
        Label1.Text = "Pencarian:"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(249), CByte(147), CByte(164))
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-2, -1)
        Panel1.Margin = New Padding(4, 2, 4, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(740, 77)
        Panel1.TabIndex = 43
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(6, 144)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 44
        Label4.Text = "Moto:"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(74), CByte(138), CByte(198))
        btnHapus.FlatAppearance.BorderColor = Color.Black
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(320, 172)
        btnHapus.Margin = New Padding(4, 2, 4, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(145, 29)
        btnHapus.TabIndex = 36
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' dgvSekolah
        ' 
        dgvSekolah.BackgroundColor = SystemColors.WindowFrame
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Noto Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(249), CByte(147), CByte(164))
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgvSekolah.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgvSekolah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Noto Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.Black
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(251), CByte(143), CByte(162))
        DataGridViewCellStyle8.SelectionForeColor = Color.White
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgvSekolah.DefaultCellStyle = DataGridViewCellStyle8
        dgvSekolah.Location = New Point(6, 238)
        dgvSekolah.Margin = New Padding(4, 2, 4, 2)
        dgvSekolah.Name = "dgvSekolah"
        dgvSekolah.ReadOnly = True
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = SystemColors.Control
        DataGridViewCellStyle9.Font = New Font("Noto Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(249), CByte(147), CByte(164))
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        dgvSekolah.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        dgvSekolah.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSekolah.Size = New Size(607, 149)
        dgvSekolah.TabIndex = 40
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(74), CByte(138), CByte(198))
        btnUbah.FlatAppearance.BorderColor = Color.Black
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(167, 172)
        btnUbah.Margin = New Padding(4, 2, 4, 2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(145, 29)
        btnUbah.TabIndex = 39
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(74), CByte(138), CByte(198))
        btnSimpan.FlatAppearance.BorderColor = Color.Black
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(6, 172)
        btnSimpan.Margin = New Padding(4, 2, 4, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(153, 29)
        btnSimpan.TabIndex = 38
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(74), CByte(138), CByte(198))
        btnBatal.FlatAppearance.BorderColor = Color.Black
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(473, 172)
        btnBatal.Margin = New Padding(4, 2, 4, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(140, 29)
        btnBatal.TabIndex = 37
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' txtMoto
        ' 
        txtMoto.Location = New Point(147, 141)
        txtMoto.Margin = New Padding(4, 2, 4, 2)
        txtMoto.Name = "txtMoto"
        txtMoto.Size = New Size(445, 23)
        txtMoto.TabIndex = 35
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(6, 117)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 53
        Label2.Text = "Distrik:"
        ' 
        ' txtDistrik
        ' 
        txtDistrik.Location = New Point(147, 114)
        txtDistrik.Margin = New Padding(4, 2, 4, 2)
        txtDistrik.Name = "txtDistrik"
        txtDistrik.Size = New Size(445, 23)
        txtDistrik.TabIndex = 52
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(5, 89)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 15)
        Label5.TabIndex = 57
        Label5.Text = "Nama Lengkap Sekolah:"
        ' 
        ' txtNamaLengkap
        ' 
        txtNamaLengkap.Location = New Point(147, 86)
        txtNamaLengkap.Margin = New Padding(4, 2, 4, 2)
        txtNamaLengkap.Name = "txtNamaLengkap"
        txtNamaLengkap.Size = New Size(445, 23)
        txtNamaLengkap.TabIndex = 56
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(75), CByte(90), CByte(111))
        ClientSize = New Size(621, 396)
        Controls.Add(Label5)
        Controls.Add(txtNamaLengkap)
        Controls.Add(Label2)
        Controls.Add(txtDistrik)
        Controls.Add(txtCari)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(btnHapus)
        Controls.Add(dgvSekolah)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(btnBatal)
        Controls.Add(txtMoto)
        Name = "Form2"
        Text = "Sistem Pendataan Sekolah Kivotos - 2409106033 - Febrian Pratama Saputra"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvSekolah, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvSekolah As DataGridView
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtMoto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDistrik As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNamaLengkap As TextBox
End Class
