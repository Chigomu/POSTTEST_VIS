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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pbFotoHasil = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobby = New Label()
        Panel1 = New Panel()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbFotoHasil
        ' 
        pbFotoHasil.BorderStyle = BorderStyle.FixedSingle
        pbFotoHasil.Location = New Point(375, 14)
        pbFotoHasil.Name = "pbFotoHasil"
        pbFotoHasil.Size = New Size(138, 245)
        pbFotoHasil.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoHasil.TabIndex = 1
        pbFotoHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Location = New Point(18, 17)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(36, 17)
        lblNama.TabIndex = 6
        lblNama.Text = "NAMA"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.Location = New Point(18, 45)
        lblID.Name = "lblID"
        lblID.Size = New Size(22, 17)
        lblID.TabIndex = 7
        lblID.Text = "ID"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.BackColor = Color.Transparent
        lblKomunitas.Location = New Point(18, 77)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(71, 17)
        lblKomunitas.TabIndex = 8
        lblKomunitas.Text = "KOMUNITAS"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.BackColor = Color.Transparent
        lblKontak.Location = New Point(18, 109)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(99, 17)
        lblKontak.TabIndex = 9
        lblKontak.Text = "JENIS KELAMIN"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.BackColor = Color.Transparent
        lblHobby.Location = New Point(18, 156)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(36, 17)
        lblHobby.TabIndex = 10
        lblHobby.Text = "HOBI"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255), CByte(255))
        Panel1.Controls.Add(lblHobby)
        Panel1.Controls.Add(lblKontak)
        Panel1.Controls.Add(lblKomunitas)
        Panel1.Controls.Add(lblID)
        Panel1.Controls.Add(lblNama)
        Panel1.Location = New Point(12, 14)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(345, 245)
        Panel1.TabIndex = 0
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(535, 271)
        Controls.Add(pbFotoHasil)
        Controls.Add(Panel1)
        Font = New Font("VL Gothic", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form2"
        Text = "Hasil Kartu"
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pbFotoHasil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents Panel1 As Panel
End Class
