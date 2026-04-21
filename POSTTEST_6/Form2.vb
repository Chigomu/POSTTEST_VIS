Imports MySqlConnector

Public Class Form2
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable

    Dim idTerpilih As String = ""

    Sub Koneksi()
        Dim strConn As String = "server=localhost;user=root;password=;database=db_bluearchive"
        conn = New MySqlConnection(strConn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub AturDGV()
        If dgvSekolah.Columns.Count >= 4 Then
            dgvSekolah.Columns(0).Visible = False

            dgvSekolah.Columns(1).HeaderText = "Nama Lengkap Sekolah"
            dgvSekolah.Columns(2).HeaderText = "Distrik / Lokasi"
            dgvSekolah.Columns(3).HeaderText = "Moto Akademi"
            dgvSekolah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Sub TampilData(Optional ByVal keyword As String = "")
        Try
            Koneksi()
            Dim query As String

            If keyword = "" Then
                query = "SELECT id, nama_lengkap, distrik, moto FROM sekolah"
            Else
                query = "SELECT id, nama_lengkap, distrik, moto FROM sekolah WHERE nama_lengkap LIKE '%" & keyword & "%'"
            End If

            da = New MySqlDataAdapter(query, conn)
            dt = New DataTable()
            da.Fill(dt)
            dgvSekolah.DataSource = dt
            AturDGV()
        Catch ex As Exception
        End Try
    End Sub

    Sub Bersihkan()
        txtNamaLengkap.Clear()
        txtDistrik.Clear()
        txtMoto.Clear()
        txtCari.Clear()
        idTerpilih = ""
        ErrorProvider1.Clear()
        txtNamaLengkap.Focus()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TampilData(txtCari.Text.Trim())
    End Sub

    Function ValidasiData() As Boolean
        ErrorProvider1.Clear()
        Dim valid As Boolean = True
        If txtNamaLengkap.Text.Trim() = "" Then : ErrorProvider1.SetError(txtNamaLengkap, "Nama Lengkap wajib diisi") : valid = False : End If
        Return valid
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidasiData() Then
            Try
                Koneksi()
                Dim sql As String = "INSERT INTO sekolah (nama_lengkap, distrik, moto) VALUES (@nama, @distrik, @moto)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text.Trim())
                cmd.Parameters.AddWithValue("@distrik", txtDistrik.Text.Trim())
                cmd.Parameters.AddWithValue("@moto", txtMoto.Text.Trim())
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Akademi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Bersihkan()
                TampilData()
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dgvSekolah_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSekolah.CellClick
        If e.RowIndex >= 0 Then
            Dim r As DataGridViewRow = dgvSekolah.Rows(e.RowIndex)
            idTerpilih = r.Cells(0).Value.ToString()
            txtNamaLengkap.Text = r.Cells(1).Value.ToString()
            txtDistrik.Text = r.Cells(2).Value.ToString()
            txtMoto.Text = r.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idTerpilih = "" Then
            MessageBox.Show("Pilih data akademi di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidasiData() Then
            Try
                Koneksi()
                Dim sql As String = "UPDATE sekolah SET nama_lengkap=@nama, distrik=@distrik, moto=@moto WHERE id=@id"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text.Trim())
                cmd.Parameters.AddWithValue("@distrik", txtDistrik.Text.Trim())
                cmd.Parameters.AddWithValue("@moto", txtMoto.Text.Trim())
                cmd.Parameters.AddWithValue("@id", idTerpilih)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Akademi berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Bersihkan()
                TampilData()
            Catch ex As Exception
                MessageBox.Show("Gagal mengubah: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idTerpilih = "" Then
            MessageBox.Show("Pilih data akademi di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Hapus akademi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Koneksi()
                cmd = New MySqlCommand("DELETE FROM sekolah WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", idTerpilih)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Akademi berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Bersihkan()
                TampilData()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersihkan()
    End Sub
End Class