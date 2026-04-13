Imports MySqlConnector

Public Class Form1
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
        dgvData.Columns(0).Visible = False
        dgvData.Columns(1).HeaderText = "Nama Depan"
        dgvData.Columns(2).HeaderText = "Nama Belakang"
        dgvData.Columns(3).HeaderText = "Umur"
        dgvData.Columns(4).HeaderText = "Sekolah"
        dgvData.Columns(5).HeaderText = "Tahun Ajaran"
        dgvData.Columns(6).HeaderText = "Jenis Kelamin"
        dgvData.Columns(7).HeaderText = "Tgl Lahir"
        dgvData.Columns(8).HeaderText = "Hobi"

        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Sub TampilData()
        Try
            Koneksi()
            da = New MySqlDataAdapter("SELECT * FROM murid", conn)
            dt = New DataTable()
            da.Fill(dt)
            dgvData.DataSource = dt
            AturDGV()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    Sub Bersihkan()
        txtNamaDepan.Clear()
        txtNamaBelakang.Clear()
        txtUmur.Clear()
        cmbSekolah.SelectedIndex = -1
        cmbTahunAjaran.SelectedIndex = -1
        rbLaki.Checked = False
        rbPerempuan.Checked = False
        dtpTanggalLahir.Value = DateTime.Now
        txtHobi1.Clear()
        txtHobi2.Clear()
        txtHobi3.Clear()
        txtHobi4.Clear()
        cbHobi2.Checked = False
        cbHobi3.Checked = False
        cbHobi4.Checked = False
        txtCari.Clear()
        idTerpilih = ""
        ErrorProvider1.Clear()
        txtNamaDepan.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaDepan.KeyPress, txtNamaBelakang.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Function ValidasiData() As Boolean
        ErrorProvider1.Clear()
        Dim valid As Boolean = True

        If txtNamaDepan.Text.Trim() = "" Then : ErrorProvider1.SetError(txtNamaDepan, "Inputan tidak boleh kosong") : valid = False : End If
        If txtNamaBelakang.Text.Trim() = "" Then : ErrorProvider1.SetError(txtNamaBelakang, "Inputan tidak boleh kosong") : valid = False : End If
        If txtUmur.Text.Trim() = "" Then : ErrorProvider1.SetError(txtUmur, "Inputan tidak boleh kosong") : valid = False : End If
        If cmbSekolah.Text = "" Then : ErrorProvider1.SetError(cmbSekolah, "Inputan tidak boleh kosong") : valid = False : End If
        If cmbTahunAjaran.Text = "" Then : ErrorProvider1.SetError(cmbTahunAjaran, "Inputan tidak boleh kosong") : valid = False : End If
        If Not rbLaki.Checked And Not rbPerempuan.Checked Then : ErrorProvider1.SetError(gbGender, "Inputan tidak boleh kosong") : valid = False : End If
        If txtHobi1.Text.Trim() = "" Then : ErrorProvider1.SetError(txtHobi1, "Inputan tidak boleh kosong") : valid = False : End If

        Return valid
    End Function

    Function GabungHobi() As String
        Dim hobi As New List(Of String)
        hobi.Add(txtHobi1.Text.Trim())
        If cbHobi2.Checked Then hobi.Add(txtHobi2.Text.Trim())
        If cbHobi3.Checked Then hobi.Add(txtHobi3.Text.Trim())
        If cbHobi4.Checked Then hobi.Add(txtHobi4.Text.Trim())
        Return String.Join(", ", hobi)
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidasiData() Then
            Try
                Koneksi()
                Dim gender As String = If(rbLaki.Checked, "Laki-Laki", "Perempuan")
                Dim sql As String = "INSERT INTO murid (nama_depan, nama_belakang, umur, sekolah, tahun_ajaran, jenis_kelamin, tanggal_lahir, hobi) VALUES (@nd, @nb, @umr, @skl, @ta, @jk, @tgl, @hb)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nd", txtNamaDepan.Text)
                cmd.Parameters.AddWithValue("@nb", txtNamaBelakang.Text)
                cmd.Parameters.AddWithValue("@umr", txtUmur.Text)
                cmd.Parameters.AddWithValue("@skl", cmbSekolah.Text)
                cmd.Parameters.AddWithValue("@ta", cmbTahunAjaran.Text)
                cmd.Parameters.AddWithValue("@jk", gender)
                cmd.Parameters.AddWithValue("@tgl", dtpTanggalLahir.Value.ToString("dd MMMM"))
                cmd.Parameters.AddWithValue("@hb", GabungHobi())
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil ditambahkan!")
                Bersihkan()
                TampilData()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idTerpilih = "" Then Return
        If ValidasiData() Then
            Try
                Koneksi()
                Dim gender As String = If(rbLaki.Checked, "Laki-Laki", "Perempuan")
                Dim sql As String = "UPDATE murid SET nama_depan=@nd, nama_belakang=@nb, umur=@umr, sekolah=@skl, tahun_ajaran=@ta, jenis_kelamin=@jk, tanggal_lahir=@tgl, hobi=@hb WHERE id=@id"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nd", txtNamaDepan.Text)
                cmd.Parameters.AddWithValue("@nb", txtNamaBelakang.Text)
                cmd.Parameters.AddWithValue("@umr", txtUmur.Text)
                cmd.Parameters.AddWithValue("@skl", cmbSekolah.Text)
                cmd.Parameters.AddWithValue("@ta", cmbTahunAjaran.Text)
                cmd.Parameters.AddWithValue("@jk", gender)
                cmd.Parameters.AddWithValue("@tgl", dtpTanggalLahir.Value.ToString("dd MMMM"))
                cmd.Parameters.AddWithValue("@hb", GabungHobi())
                cmd.Parameters.AddWithValue("@id", idTerpilih)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil diperbarui!")
                Bersihkan()
                TampilData()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idTerpilih = "" Then Return
        If MessageBox.Show("Hapus murid ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Koneksi()
                cmd = New MySqlCommand("DELETE FROM murid WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", idTerpilih)
                cmd.ExecuteNonQuery()
                Bersihkan()
                TampilData()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        If e.RowIndex >= 0 Then
            Dim r As DataGridViewRow = dgvData.Rows(e.RowIndex)
            idTerpilih = r.Cells(0).Value.ToString()
            txtNamaDepan.Text = r.Cells(1).Value.ToString()
            txtNamaBelakang.Text = r.Cells(2).Value.ToString()
            txtUmur.Text = r.Cells(3).Value.ToString()
            cmbSekolah.Text = r.Cells(4).Value.ToString()
            cmbTahunAjaran.Text = r.Cells(5).Value.ToString()
            If r.Cells(6).Value.ToString() = "Laki-Laki" Then rbLaki.Checked = True Else rbPerempuan.Checked = True

            Try
                Dim tglStr As String = r.Cells(7).Value.ToString()

                tglStr = tglStr.Replace("Januari", "January").Replace("Februari", "February")
                tglStr = tglStr.Replace("Maret", "March").Replace("Mei", "May").Replace("Juni", "June")
                tglStr = tglStr.Replace("Juli", "July").Replace("Agustus", "August")
                tglStr = tglStr.Replace("Oktober", "October").Replace("Desember", "December")

                dtpTanggalLahir.Value = DateTime.Parse(tglStr & " " & Now.Year.ToString())
            Catch
                dtpTanggalLahir.Value = DateTime.Now
            End Try

            Dim hobiArray As String() = r.Cells(8).Value.ToString().Split({", "}, StringSplitOptions.None)
            cbHobi2.Checked = False : cbHobi3.Checked = False : cbHobi4.Checked = False
            If hobiArray.Length >= 1 Then txtHobi1.Text = hobiArray(0)
            If hobiArray.Length >= 2 Then : cbHobi2.Checked = True : txtHobi2.Text = hobiArray(1) : End If
            If hobiArray.Length >= 3 Then : cbHobi3.Checked = True : txtHobi3.Text = hobiArray(2) : End If
            If hobiArray.Length >= 4 Then : cbHobi4.Checked = True : txtHobi4.Text = hobiArray(3) : End If
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Try
            Koneksi()
            da = New MySqlDataAdapter("SELECT * FROM murid WHERE nama_depan LIKE @c OR nama_belakang LIKE @c", conn)
            da.SelectCommand.Parameters.AddWithValue("@c", "%" & txtCari.Text & "%")
            dt = New DataTable()
            da.Fill(dt)
            dgvData.DataSource = dt
        Catch : End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersihkan()
    End Sub

    Private Sub cbHobi_CheckedChanged(sender As Object, e As EventArgs) Handles cbHobi2.CheckedChanged, cbHobi3.CheckedChanged, cbHobi4.CheckedChanged
        txtHobi2.Enabled = cbHobi2.Checked
        txtHobi3.Enabled = cbHobi3.Checked
        txtHobi4.Enabled = cbHobi4.Checked
    End Sub
End Class