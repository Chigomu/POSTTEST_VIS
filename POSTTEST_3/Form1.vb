Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If ofd.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(ofd.FileName)
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtNoTelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim validasiHobby As Boolean = False
        Dim listHobby As New List(Of String)

        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then
                    validasiHobby = True
                    listHobby.Add(cb.Text)
                End If
            End If
        Next

        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtUmur.Text) OrElse
           String.IsNullOrWhiteSpace(txtNoTelp.Text) OrElse
           String.IsNullOrWhiteSpace(txtAlamat.Text) OrElse
           pbFoto.Image Is Nothing OrElse
           (Not rbLaki.Checked AndAlso Not rbPerempuan.Checked) OrElse
           Not validasiHobby Then

            MessageBox.Show("Inputan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim frm2 As New Form2()
        frm2.lblNama.Text = txtNama.Text
        frm2.lblUmur.Text = txtUmur.Text
        frm2.lblTanggalLahir.Text = dtpTanggalLahir.Value.ToString("dd/MM/yyyy")
        frm2.lblNoTelp.Text = txtNoTelp.Text
        frm2.lblAlamat.Text = txtAlamat.Text
        frm2.pbFotoHasil.Image = pbFoto.Image

        If rbLaki.Checked Then
            frm2.lblTanggalLahir.Text = rbLaki.Text
        Else
            frm2.lblTanggalLahir.Text = rbPerempuan.Text
        End If

        frm2.lblHobby.Text = String.Join(", ", listHobby)

        frm2.Show()
    End Sub

End Class