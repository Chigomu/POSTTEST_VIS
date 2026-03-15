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
        pbFoto = New PictureBox()
        btnBrowse = New Button()
        Label1 = New Label()
        txtNama = New TextBox()
        Label2 = New Label()
        txtUmur = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        Label3 = New Label()
        txtAlamat = New TextBox()
        txtNoTelp = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        gbJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
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
        btnCetak = New Button()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbJenisKelamin.SuspendLayout()
        gbHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbFoto
        ' 
        pbFoto.Location = New Point(12, 12)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(199, 305)
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(31, 322)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(157, 23)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Telusuri Gambar"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(218, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 17)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(332, 12)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(278, 24)
        txtNama.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(218, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 17)
        Label2.TabIndex = 4
        Label2.Text = "Umur"
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(332, 42)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(278, 24)
        txtUmur.TabIndex = 5
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(332, 72)
        dtpTanggalLahir.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        dtpTanggalLahir.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(278, 24)
        dtpTanggalLahir.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(218, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 17)
        Label3.TabIndex = 7
        Label3.Text = "Tanggal Lahir"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(332, 102)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(278, 24)
        txtAlamat.TabIndex = 8
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(332, 132)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(278, 24)
        txtNoTelp.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(218, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 17)
        Label4.TabIndex = 10
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(218, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 17)
        Label5.TabIndex = 11
        Label5.Text = "No. Telepon"
        ' 
        ' gbJenisKelamin
        ' 
        gbJenisKelamin.Controls.Add(rbPerempuan)
        gbJenisKelamin.Controls.Add(rbLaki)
        gbJenisKelamin.Location = New Point(218, 162)
        gbJenisKelamin.Name = "gbJenisKelamin"
        gbJenisKelamin.Size = New Size(186, 155)
        gbJenisKelamin.TabIndex = 12
        gbJenisKelamin.TabStop = False
        gbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(24, 50)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(89, 21)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(24, 23)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(89, 21)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
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
        gbHobby.Location = New Point(410, 162)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(200, 155)
        gbHobby.TabIndex = 13
        gbHobby.TabStop = False
        gbHobby.Text = "Hobi"
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(102, 126)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(69, 21)
        CheckBox10.TabIndex = 9
        CheckBox10.Text = "Menari"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(102, 99)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(83, 21)
        CheckBox9.TabIndex = 8
        CheckBox9.Text = "Menyanyi"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(102, 75)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(83, 21)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Olahraga"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(102, 48)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(76, 21)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Membaca"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(102, 24)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(90, 21)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Memancing"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(6, 126)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(76, 21)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Menulis"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(6, 99)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(97, 21)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Menggambar"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(6, 72)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(97, 21)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Menjelajah"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(6, 48)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(69, 21)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Coding"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 24)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(69, 21)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Gaming"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(218, 323)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(392, 23)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(618, 355)
        Controls.Add(btnCetak)
        Controls.Add(gbHobby)
        Controls.Add(gbJenisKelamin)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtNoTelp)
        Controls.Add(txtAlamat)
        Controls.Add(Label3)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(txtUmur)
        Controls.Add(Label2)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(pbFoto)
        Font = New Font("VL Gothic", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Form Cetak - 2409106033  - Febrian Pratama Saputra"
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        gbJenisKelamin.ResumeLayout(False)
        gbJenisKelamin.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents btnCetak As Button

End Class
