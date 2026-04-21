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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtNamaDepan = New TextBox()
        txtNamaBelakang = New TextBox()
        cmbSekolah = New ComboBox()
        cmbTahunAjaran = New ComboBox()
        txtHobi4 = New TextBox()
        txtUmur = New TextBox()
        txtHobi1 = New TextBox()
        txtHobi3 = New TextBox()
        cbHobi2 = New CheckBox()
        cbHobi4 = New CheckBox()
        cbHobi3 = New CheckBox()
        btnHapus = New Button()
        btnBatal = New Button()
        btnSimpan = New Button()
        btnUbah = New Button()
        dgvData = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        gbGender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtHobi2 = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        GroupBox1 = New GroupBox()
        Label9 = New Label()
        txtCari = New TextBox()
        Label1 = New Label()
        btnKelolaSekolah = New Button()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        gbGender.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNamaDepan
        ' 
        txtNamaDepan.Location = New Point(130, 20)
        txtNamaDepan.Margin = New Padding(4, 2, 4, 2)
        txtNamaDepan.Name = "txtNamaDepan"
        txtNamaDepan.Size = New Size(238, 24)
        txtNamaDepan.TabIndex = 3
        ' 
        ' txtNamaBelakang
        ' 
        txtNamaBelakang.Location = New Point(130, 50)
        txtNamaBelakang.Margin = New Padding(4, 2, 4, 2)
        txtNamaBelakang.Name = "txtNamaBelakang"
        txtNamaBelakang.Size = New Size(238, 24)
        txtNamaBelakang.TabIndex = 4
        ' 
        ' cmbSekolah
        ' 
        cmbSekolah.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSekolah.FormattingEnabled = True
        cmbSekolah.Items.AddRange(New Object() {"Abydos", "Gehenna", "Millennium", "Trinity", "Hyakkiyako", "Shanhaijing", "Red Winter", "Valkyrie", "SRT", "Arius"})
        cmbSekolah.Location = New Point(168, 228)
        cmbSekolah.Margin = New Padding(4, 2, 4, 2)
        cmbSekolah.Name = "cmbSekolah"
        cmbSekolah.Size = New Size(214, 26)
        cmbSekolah.TabIndex = 5
        ' 
        ' cmbTahunAjaran
        ' 
        cmbTahunAjaran.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTahunAjaran.FormattingEnabled = True
        cmbTahunAjaran.Items.AddRange(New Object() {"Tahun Pertama", "Tahun Kedua", "Tahun Ketiga", "Diskors", "Putus Sekolah"})
        cmbTahunAjaran.Location = New Point(168, 258)
        cmbTahunAjaran.Margin = New Padding(4, 2, 4, 2)
        cmbTahunAjaran.Name = "cmbTahunAjaran"
        cmbTahunAjaran.Size = New Size(214, 26)
        cmbTahunAjaran.TabIndex = 6
        ' 
        ' txtHobi4
        ' 
        txtHobi4.Enabled = False
        txtHobi4.Location = New Point(75, 104)
        txtHobi4.Margin = New Padding(4, 2, 4, 2)
        txtHobi4.Name = "txtHobi4"
        txtHobi4.Size = New Size(192, 24)
        txtHobi4.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(264, 187)
        txtUmur.Margin = New Padding(4, 2, 4, 2)
        txtUmur.MaxLength = 2
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(134, 24)
        txtUmur.TabIndex = 8
        ' 
        ' txtHobi1
        ' 
        txtHobi1.Location = New Point(75, 20)
        txtHobi1.Margin = New Padding(4, 2, 4, 2)
        txtHobi1.Name = "txtHobi1"
        txtHobi1.Size = New Size(192, 24)
        txtHobi1.TabIndex = 9
        ' 
        ' txtHobi3
        ' 
        txtHobi3.Enabled = False
        txtHobi3.Location = New Point(75, 76)
        txtHobi3.Margin = New Padding(4, 2, 4, 2)
        txtHobi3.Name = "txtHobi3"
        txtHobi3.Size = New Size(192, 24)
        txtHobi3.TabIndex = 10
        ' 
        ' cbHobi2
        ' 
        cbHobi2.AutoSize = True
        cbHobi2.Location = New Point(8, 50)
        cbHobi2.Margin = New Padding(4, 2, 4, 2)
        cbHobi2.Name = "cbHobi2"
        cbHobi2.Size = New Size(66, 22)
        cbHobi2.TabIndex = 11
        cbHobi2.Text = "Hobi 2:"
        cbHobi2.UseVisualStyleBackColor = True
        ' 
        ' cbHobi4
        ' 
        cbHobi4.AutoSize = True
        cbHobi4.Location = New Point(8, 106)
        cbHobi4.Margin = New Padding(4, 2, 4, 2)
        cbHobi4.Name = "cbHobi4"
        cbHobi4.Size = New Size(66, 22)
        cbHobi4.TabIndex = 12
        cbHobi4.Text = "Hobi 4:"
        cbHobi4.UseVisualStyleBackColor = True
        ' 
        ' cbHobi3
        ' 
        cbHobi3.AutoSize = True
        cbHobi3.Location = New Point(8, 78)
        cbHobi3.Margin = New Padding(4, 2, 4, 2)
        cbHobi3.Name = "cbHobi3"
        cbHobi3.Size = New Size(66, 22)
        cbHobi3.TabIndex = 13
        cbHobi3.Text = "Hobi 3:"
        cbHobi3.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(74), CByte(138), CByte(198))
        btnHapus.FlatAppearance.BorderColor = Color.Black
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(369, 321)
        btnHapus.Margin = New Padding(4, 2, 4, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(172, 29)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(74), CByte(138), CByte(198))
        btnBatal.FlatAppearance.BorderColor = Color.Black
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(547, 321)
        btnBatal.Margin = New Padding(4, 2, 4, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(172, 29)
        btnBatal.TabIndex = 15
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(74), CByte(138), CByte(198))
        btnSimpan.FlatAppearance.BorderColor = Color.Black
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(13, 321)
        btnSimpan.Margin = New Padding(4, 2, 4, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(172, 29)
        btnSimpan.TabIndex = 16
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(74), CByte(138), CByte(198))
        btnUbah.FlatAppearance.BorderColor = Color.Black
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(191, 321)
        btnUbah.Margin = New Padding(4, 2, 4, 2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(172, 29)
        btnUbah.TabIndex = 17
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' dgvData
        ' 
        dgvData.BackgroundColor = SystemColors.WindowFrame
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Noto Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(249), CByte(147), CByte(164))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Noto Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(251), CByte(143), CByte(162))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvData.DefaultCellStyle = DataGridViewCellStyle5
        dgvData.Location = New Point(14, 388)
        dgvData.Margin = New Padding(4, 2, 4, 2)
        dgvData.Name = "dgvData"
        dgvData.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Noto Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(249), CByte(147), CByte(164))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvData.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.Size = New Size(704, 149)
        dgvData.TabIndex = 18
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' gbGender
        ' 
        gbGender.Controls.Add(rbPerempuan)
        gbGender.Controls.Add(rbLaki)
        gbGender.ForeColor = Color.White
        gbGender.Location = New Point(13, 168)
        gbGender.Margin = New Padding(4, 2, 4, 2)
        gbGender.Name = "gbGender"
        gbGender.Padding = New Padding(4, 2, 4, 2)
        gbGender.Size = New Size(180, 53)
        gbGender.TabIndex = 19
        gbGender.TabStop = False
        gbGender.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(83, 23)
        rbPerempuan.Margin = New Padding(4, 2, 4, 2)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(91, 22)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(6, 23)
        rbLaki.Margin = New Padding(4, 2, 4, 2)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(71, 22)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtNamaDepan)
        GroupBox2.Controls.Add(txtNamaBelakang)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(13, 76)
        GroupBox2.Margin = New Padding(4, 2, 4, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 2, 4, 2)
        GroupBox2.Size = New Size(398, 85)
        GroupBox2.TabIndex = 20
        GroupBox2.TabStop = False
        GroupBox2.Text = "Nama Lengkap"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 54)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 18)
        Label3.TabIndex = 1
        Label3.Text = "Nama Belakang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 24)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 18)
        Label2.TabIndex = 0
        Label2.Text = "Nama Depan"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(249), CByte(147), CByte(164))
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-2, -5)
        Panel1.Margin = New Padding(4, 2, 4, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(740, 77)
        Panel1.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Noto Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(85, 17)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(635, 41)
        Label6.TabIndex = 1
        Label6.Text = "SISTEM PENDATAAN KARAKTER BLUE ARCHIVE"
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(215, 190)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 18)
        Label4.TabIndex = 22
        Label4.Text = "Umur:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(14, 231)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 18)
        Label5.TabIndex = 23
        Label5.Text = "Sekolah:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.White
        Label7.Location = New Point(14, 261)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 18)
        Label7.TabIndex = 25
        Label7.Text = "Tahun Ajaran:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(13, 295)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(145, 18)
        Label8.TabIndex = 26
        Label8.Text = "Bulan dan Tanggal Lahir:"
        ' 
        ' txtHobi2
        ' 
        txtHobi2.Enabled = False
        txtHobi2.Location = New Point(75, 48)
        txtHobi2.Margin = New Padding(4, 2, 4, 2)
        txtHobi2.Name = "txtHobi2"
        txtHobi2.Size = New Size(192, 24)
        txtHobi2.TabIndex = 27
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.CustomFormat = "dd MMMM"
        dtpTanggalLahir.Format = DateTimePickerFormat.Custom
        dtpTanggalLahir.Location = New Point(169, 290)
        dtpTanggalLahir.Margin = New Padding(4, 2, 4, 2)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(213, 24)
        dtpTanggalLahir.TabIndex = 28
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtHobi1)
        GroupBox1.Controls.Add(txtHobi2)
        GroupBox1.Controls.Add(cbHobi2)
        GroupBox1.Controls.Add(cbHobi3)
        GroupBox1.Controls.Add(cbHobi4)
        GroupBox1.Controls.Add(txtHobi3)
        GroupBox1.Controls.Add(txtHobi4)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(421, 76)
        GroupBox1.Margin = New Padding(4, 2, 4, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 2, 4, 2)
        GroupBox1.Size = New Size(298, 144)
        GroupBox1.TabIndex = 29
        GroupBox1.TabStop = False
        GroupBox1.Text = "Hobi"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(23, 23)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 18)
        Label9.TabIndex = 10
        Label9.Text = "Hobi 1:"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(91, 357)
        txtCari.Margin = New Padding(4, 2, 4, 2)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(627, 24)
        txtCari.TabIndex = 30
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(18, 361)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 18)
        Label1.TabIndex = 31
        Label1.Text = "Pencarian:"
        ' 
        ' btnKelolaSekolah
        ' 
        btnKelolaSekolah.BackColor = Color.FromArgb(CByte(74), CByte(138), CByte(198))
        btnKelolaSekolah.FlatAppearance.BorderColor = Color.Black
        btnKelolaSekolah.FlatStyle = FlatStyle.Flat
        btnKelolaSekolah.ForeColor = Color.White
        btnKelolaSekolah.Location = New Point(421, 231)
        btnKelolaSekolah.Margin = New Padding(4, 2, 4, 2)
        btnKelolaSekolah.Name = "btnKelolaSekolah"
        btnKelolaSekolah.Size = New Size(298, 29)
        btnKelolaSekolah.TabIndex = 32
        btnKelolaSekolah.Text = "Kelola Data Sekolah"
        btnKelolaSekolah.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(75), CByte(90), CByte(111))
        ClientSize = New Size(725, 546)
        Controls.Add(btnKelolaSekolah)
        Controls.Add(Label1)
        Controls.Add(txtCari)
        Controls.Add(GroupBox1)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(GroupBox2)
        Controls.Add(gbGender)
        Controls.Add(dgvData)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(txtUmur)
        Controls.Add(cmbTahunAjaran)
        Controls.Add(cmbSekolah)
        Font = New Font("Noto Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Black
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Sistem Pendataan Karakter Blue Archive - 2409106033 - Febrian Pratama Saputra"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        gbGender.ResumeLayout(False)
        gbGender.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtNamaDepan As TextBox
    Friend WithEvents txtNamaBelakang As TextBox
    Friend WithEvents cmbSekolah As ComboBox
    Friend WithEvents cmbTahunAjaran As ComboBox
    Friend WithEvents txtHobi4 As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtHobi1 As TextBox
    Friend WithEvents txtHobi3 As TextBox
    Friend WithEvents cbHobi2 As CheckBox
    Friend WithEvents cbHobi4 As CheckBox
    Friend WithEvents cbHobi3 As CheckBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtHobi2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnKelolaSekolah As Button

End Class
