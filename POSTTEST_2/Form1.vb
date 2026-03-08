Public Class Form1

    Private Sub TampilkanData(ByVal lst As ListBox)
        lst.Items.Clear()
        For i As Integer = 0 To daftarBuku.Length - 1
            lst.Items.Add(daftarBuku(i))
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJudulTambah.Text.Trim() <> "" And txtGenre.Text.Trim() <> "" Then
            TambahDataBuku(txtJudulTambah.Text.Trim(), txtGenre.Text.Trim())
            TampilkanData(ListView1)

            txtJudulTambah.Clear()
            txtGenre.Clear()
            txtJudulTambah.Focus()
        Else
            MessageBox.Show("Judul buku dan Genre harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulHapus As String = txtJudulHapus.Text.Trim()

        If judulHapus = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim indeks As Integer = CariIndeksBuku(judulHapus)

        If indeks <> -1 Then
            For i As Integer = indeks To daftarBuku.Length - 2
                daftarBuku(i) = daftarBuku(i + 1)
            Next

            ReDim Preserve daftarBuku(daftarBuku.Length - 2)
            TampilkanData(ListView1)

            txtJudulHapus.Clear()
            txtJudulHapus.Focus()
        Else
            MessageBox.Show("Buku tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData(ListView1)
    End Sub

    Private Sub grbTambah_Enter(sender As Object, e As EventArgs)

    End Sub
End Class