Imports System.IO

Public Class Form1

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Function ValidasiData() As Boolean
        Dim statusValid As Boolean = True
        ErrorProvider1.Clear()

        Dim daftarTextBox As TextBox() = {txtNama, txtID, txtUmur, txtEmail, txtAlamat}
        For Each txt In daftarTextBox
            If String.IsNullOrWhiteSpace(txt.Text) Then
                ErrorProvider1.SetError(txt, "Inputan tidak boleh kosong")
                statusValid = False
            End If
        Next

        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon, "Format nomor telepon tidak lengkap")
            statusValid = False
        End If

        Dim adaHobby As Boolean = False
        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                adaHobby = True
                Exit For
            End If
        Next

        If Not adaHobby Then
            ErrorProvider1.SetError(gbHobby, "Inputan tidak boleh kosong (Pilih minimal 1)")
            statusValid = False
        End If

        If pbFoto.Image Is Nothing Then
            ErrorProvider1.SetError(pbFoto, "Inputan tidak boleh kosong (Pilih Foto)")
            statusValid = False
        End If

        Return statusValid
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If ValidasiData() Then
            Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mencetak kartu ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If konfirmasi = DialogResult.Yes Then
                Dim listHobby As New List(Of String)
                For Each ctrl As Control In gbHobby.Controls
                    If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                        listHobby.Add(ctrl.Text)
                    End If
                Next

                Dim frmHasil As New Form2()
                frmHasil.lblNama.Text = "Nama: " & txtNama.Text
                frmHasil.lblID.Text = "ID: " & txtID.Text
                frmHasil.lblKomunitas.Text = "Divisi: " & cmbDivisi.Text
                frmHasil.lblKontak.Text = "Telp: " & mtbTelepon.Text & vbCrLf & "Email: " & txtEmail.Text
                frmHasil.lblHobby.Text = "Hobby: " & String.Join(", ", listHobby)
                frmHasil.pbFotoHasil.Image = pbFoto.Image

                frmHasil.Show()
            End If
        End If
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Dim tutup As DialogResult = MessageBox.Show("Yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If tutup = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub mnuInput_Click(sender As Object, e As EventArgs) Handles mnuInput.Click
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub

    Private Sub mnuLihat_Click(sender As Object, e As EventArgs) Handles mnuLihat.Click
        btnCetak.PerformClick()
    End Sub

    Private Sub mnuSimpan_Click(sender As Object, e As EventArgs) Handles mnuSimpan.Click
        If ValidasiData() Then
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim dataSimpan As String = $"Nama: {txtNama.Text}, ID: {txtID.Text}, Telp: {mtbTelepon.Text}"
                File.WriteAllText(SaveFileDialog1.FileName, dataSimpan)
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub mnuBuka_Click(sender As Object, e As EventArgs) Handles mnuBuka.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            Dim isiFile As String = File.ReadAllText(OpenFileDialog2.FileName)
            MessageBox.Show("Isi Data Tersimpan:" & vbCrLf & isiFile, "Buka Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class