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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ErrorProvider1 = New ErrorProvider(components)
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip1 = New MenuStrip()
        mnuInput = New ToolStripMenuItem()
        mnuLihat = New ToolStripMenuItem()
        mnuSimpan = New ToolStripMenuItem()
        mnuBuka = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label12 = New Label()
        txtUmur = New TextBox()
        Label5 = New Label()
        cmbDivisi = New ComboBox()
        rbPerempuan = New RadioButton()
        Label4 = New Label()
        rbLaki = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        Label3 = New Label()
        txtID = New TextBox()
        Label2 = New Label()
        txtNama = New TextBox()
        Label1 = New Label()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        Label8 = New Label()
        txtEmail = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        mtbTelepon = New MaskedTextBox()
        TabPage3 = New TabPage()
        btnBrowse = New Button()
        btnCetak = New Button()
        gbHobby = New GroupBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        gbPeran = New GroupBox()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        pbFoto = New PictureBox()
        Panel1 = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        OpenFileDialog2 = New OpenFileDialog()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbHobby.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
        ErrorProvider1.ContainerControl = Me
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.Filter = "Text Files|*.txt"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.DimGray
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuInput, mnuLihat, mnuSimpan, mnuBuka, mnuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(470, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuInput
        ' 
        mnuInput.ForeColor = Color.White
        mnuInput.Name = "mnuInput"
        mnuInput.Size = New Size(74, 20)
        mnuInput.Text = "Input Data"
        ' 
        ' mnuLihat
        ' 
        mnuLihat.ForeColor = Color.White
        mnuLihat.Name = "mnuLihat"
        mnuLihat.Size = New Size(76, 20)
        mnuLihat.Text = "Lihat Kartu"
        ' 
        ' mnuSimpan
        ' 
        mnuSimpan.ForeColor = Color.WhiteSmoke
        mnuSimpan.Name = "mnuSimpan"
        mnuSimpan.Size = New Size(86, 20)
        mnuSimpan.Text = "Simpan Data"
        ' 
        ' mnuBuka
        ' 
        mnuBuka.ForeColor = Color.White
        mnuBuka.Name = "mnuBuka"
        mnuBuka.Size = New Size(72, 20)
        mnuBuka.Text = "Buka Data"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.ForeColor = Color.White
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(52, 20)
        mnuKeluar.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 150)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(446, 271)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Teal
        TabPage1.Controls.Add(Label12)
        TabPage1.Controls.Add(txtUmur)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(cmbDivisi)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(dtpTanggalLahir)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(Label1)
        TabPage1.ForeColor = Color.White
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(438, 243)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Location = New Point(19, 79)
        Label12.Name = "Label12"
        Label12.Size = New Size(37, 15)
        Label12.TabIndex = 12
        Label12.Text = "Umur"
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(138, 76)
        txtUmur.Name = "txtUmur"
        txtUmur.PlaceholderText = "20"
        txtUmur.Size = New Size(249, 23)
        txtUmur.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 10
        Label5.Text = "Divisi/Komunitas"
        ' 
        ' cmbDivisi
        ' 
        cmbDivisi.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDivisi.FormattingEnabled = True
        cmbDivisi.Items.AddRange(New Object() {"Badan Eksekutif Mahasiswa (BEM)", "Himpunan Mahasiswa Jurusan (HMJ)", "Dewan Perwakilan Mahasiswa (DPM)", "Unit Kegiatan Mahasiswa (UKM)", "Divisi Pengabdian Masyarakat", "Divisi Minat dan Bakat"})
        cmbDivisi.Location = New Point(138, 159)
        cmbDivisi.Name = "cmbDivisi"
        cmbDivisi.Size = New Size(249, 23)
        cmbDivisi.TabIndex = 9
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(216, 134)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 8
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 7
        Label4.Text = "Jenis Kelamin"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(138, 134)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(72, 19)
        rbLaki.TabIndex = 6
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(138, 105)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(249, 23)
        dtpTanggalLahir.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 15)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Lahir"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(138, 47)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "2409106033"
        txtID.Size = New Size(249, 23)
        txtID.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 2
        Label2.Text = "ID Anggota"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(138, 18)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Febrian Pratama Saputra"
        txtNama.Size = New Size(249, 23)
        txtNama.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Teal
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(438, 243)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak dan Info"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(113, 82)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Jl. Contoh, Kel Contoh, Kec Contoh"
        txtAlamat.Size = New Size(194, 67)
        txtAlamat.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(19, 85)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 15)
        Label8.TabIndex = 4
        Label8.Text = "Alamat"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(113, 50)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "contoh@site.com"
        txtEmail.Size = New Size(194, 23)
        txtEmail.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 53)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 2
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(19, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 15)
        Label6.TabIndex = 1
        Label6.Text = "No. Telepon"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(114, 18)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(99, 23)
        mtbTelepon.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.DarkCyan
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(gbHobby)
        TabPage3.Controls.Add(gbPeran)
        TabPage3.Controls.Add(pbFoto)
        TabPage3.ForeColor = Color.White
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(438, 243)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil dan Aktivitas"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DimGray
        btnBrowse.Location = New Point(6, 210)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(158, 23)
        btnBrowse.TabIndex = 5
        btnBrowse.Text = "Telusuri Gambar"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.DimGray
        btnCetak.Location = New Point(170, 210)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(262, 23)
        btnCetak.TabIndex = 4
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(CheckBox10)
        gbHobby.Controls.Add(CheckBox9)
        gbHobby.Controls.Add(CheckBox8)
        gbHobby.Controls.Add(CheckBox7)
        gbHobby.Controls.Add(CheckBox6)
        gbHobby.Controls.Add(CheckBox5)
        gbHobby.Controls.Add(CheckBox4)
        gbHobby.Controls.Add(CheckBox3)
        gbHobby.Controls.Add(CheckBox2)
        gbHobby.Controls.Add(CheckBox1)
        gbHobby.ForeColor = Color.White
        gbHobby.Location = New Point(173, 65)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(209, 139)
        gbHobby.TabIndex = 3
        gbHobby.TabStop = False
        gbHobby.Text = "Hobi"
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(110, 118)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(63, 19)
        CheckBox10.TabIndex = 19
        CheckBox10.Text = "Menari"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(110, 91)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(78, 19)
        CheckBox9.TabIndex = 18
        CheckBox9.Text = "Menyanyi"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(110, 67)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(74, 19)
        CheckBox8.TabIndex = 17
        CheckBox8.Text = "Olahraga"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(110, 40)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(79, 19)
        CheckBox7.TabIndex = 16
        CheckBox7.Text = "Membaca"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(110, 16)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(90, 19)
        CheckBox6.TabIndex = 15
        CheckBox6.Text = "Memancing"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(6, 118)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(68, 19)
        CheckBox5.TabIndex = 14
        CheckBox5.Text = "Menulis"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(6, 91)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(98, 19)
        CheckBox4.TabIndex = 13
        CheckBox4.Text = "Menggambar"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(6, 64)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(84, 19)
        CheckBox3.TabIndex = 12
        CheckBox3.Text = "Menjelajah"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(6, 40)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(65, 19)
        CheckBox2.TabIndex = 11
        CheckBox2.Text = "Coding"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 16)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(68, 19)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Gaming"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.ForeColor = Color.White
        gbPeran.Location = New Point(170, 6)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(212, 53)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(113, 22)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(71, 19)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(6, 22)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(55, 19)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' pbFoto
        ' 
        pbFoto.BackColor = Color.DarkSlateGray
        pbFoto.Location = New Point(6, 6)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(158, 198)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(0, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(509, 120)
        Panel1.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label11.Location = New Point(147, 42)
        Label11.Name = "Label11"
        Label11.Size = New Size(319, 21)
        Label11.TabIndex = 5
        Label11.Text = "2026"
        Label11.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label10.Location = New Point(147, 21)
        Label10.Name = "Label10"
        Label10.Size = New Size(319, 21)
        Label10.TabIndex = 4
        Label10.Text = "Dewan Kemahasiswaan Umum"
        Label10.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label9.Location = New Point(110, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(360, 21)
        Label9.TabIndex = 3
        Label9.Text = "Form Pembuatan Kartu Komunitas Mahasiswa"
        Label9.TextAlign = ContentAlignment.TopRight
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(141, 118)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog2"
        OpenFileDialog2.Filter = "Text Files|*.txt"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(470, 429)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        ForeColor = Color.White
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Pembuatan Kartu Komunitas"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuInput As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents mnuLihat As ToolStripMenuItem
    Friend WithEvents mnuSimpan As ToolStripMenuItem
    Friend WithEvents mnuBuka As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbPerempuan.CheckedChanged

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cmbDivisi As ComboBox
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents Label6 As Label

    Private Sub mtbTelepon_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbTelepon.MaskInputRejected

    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents pbFoto As PictureBox

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbFoto.Click

    End Sub
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents gbHobby As GroupBox

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbPeran.Enter

    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
