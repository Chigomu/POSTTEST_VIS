Imports MySqlConnector
Imports System.Globalization
Imports System.Threading

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

    Sub MuatSekolah()
        Try
            Koneksi()
            Dim daSekolah As New MySqlDataAdapter("SELECT id, nama_lengkap FROM sekolah", conn)
            Dim dtSekolah As New DataTable()
            daSekolah.Fill(dtSekolah)

            cmbSekolah.DataSource = dtSekolah
            cmbSekolah.DisplayMember = "nama_lengkap"
            cmbSekolah.ValueMember = "id"
            cmbSekolah.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Sub AturDGV()
        dgvData.Columns(0).Visible = False
        dgvData.Columns(1).HeaderText = "Nama Depan"
        dgvData.Columns(2).HeaderText = "Nama Belakang"
        dgvData.Columns(3).HeaderText = "Umur"
        dgvData.Columns(4).Visible = False
        dgvData.Columns(5).HeaderText = "Sekolah"
        dgvData.Columns(6).HeaderText = "Tahun Ajaran"
        dgvData.Columns(7).HeaderText = "Jenis Kelamin"
        dgvData.Columns(8).HeaderText = "Tgl Lahir"
        dgvData.Columns(9).HeaderText = "Hobi"

        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Sub TampilData()
        Try
            Koneksi()
            Dim query As String = "SELECT murid.id, murid.nama_depan, murid.nama_belakang, murid.umur, murid.id_sekolah, sekolah.nama_lengkap AS sekolah, murid.tahun_ajaran, murid.jenis_kelamin, murid.tgl_lahir, murid.hobi FROM murid INNER JOIN sekolah ON murid.id_sekolah = sekolah.id"
            da = New MySqlDataAdapter(query, conn)
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
        Thread.CurrentThread.CurrentCulture = New CultureInfo("id-ID")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("id-ID")
        MuatSekolah()
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

        If txtNamaDepan.Text.Trim() = "" Then : ErrorProvider1.SetError(txtNamaDepan, "Wajib diisi") : valid = False : End If
        If txtNamaBelakang.Text.Trim() = "" Then : ErrorProvider1.SetError(txtNamaBelakang, "Wajib diisi") : valid = False : End If
        If txtUmur.Text.Trim() = "" Then : ErrorProvider1.SetError(txtUmur, "Wajib diisi") : valid = False : End If
        If cmbSekolah.SelectedIndex = -1 Then : ErrorProvider1.SetError(cmbSekolah, "Pilih sekolah dari daftar") : valid = False : End If
        If cmbTahunAjaran.Text = "" Then : ErrorProvider1.SetError(cmbTahunAjaran, "Wajib diisi") : valid = False : End If
        If Not rbLaki.Checked And Not rbPerempuan.Checked Then : ErrorProvider1.SetError(gbGender, "Wajib diisi") : valid = False : End If
        If txtHobi1.Text.Trim() = "" Then : ErrorProvider1.SetError(txtHobi1, "Wajib diisi minimal 1 hobi") : valid = False : End If

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
                Dim sql As String = "INSERT INTO murid (nama_depan, nama_belakang, umur, id_sekolah, tahun_ajaran, jenis_kelamin, tgl_lahir, hobi) VALUES (@nd, @nb, @umr, @idskl, @ta, @jk, @tgl, @hb)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nd", txtNamaDepan.Text)
                cmd.Parameters.AddWithValue("@nb", txtNamaBelakang.Text)
                cmd.Parameters.AddWithValue("@umr", txtUmur.Text)
                cmd.Parameters.AddWithValue("@idskl", cmbSekolah.SelectedValue)
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
                Dim sql As String = "UPDATE murid SET nama_depan=@nd, nama_belakang=@nb, umur=@umr, id_sekolah=@idskl, tahun_ajaran=@ta, jenis_kelamin=@jk, tgl_lahir=@tgl, hobi=@hb WHERE id=@id"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nd", txtNamaDepan.Text)
                cmd.Parameters.AddWithValue("@nb", txtNamaBelakang.Text)
                cmd.Parameters.AddWithValue("@umr", txtUmur.Text)
                cmd.Parameters.AddWithValue("@idskl", cmbSekolah.SelectedValue)
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

            cmbSekolah.SelectedValue = r.Cells(4).Value

            cmbTahunAjaran.Text = r.Cells(6).Value.ToString()
            If r.Cells(7).Value.ToString() = "Laki-Laki" Then rbLaki.Checked = True Else rbPerempuan.Checked = True

            Try
                Dim tglStr As String = r.Cells(8).Value.ToString()
                dtpTanggalLahir.Value = DateTime.Parse(tglStr & " " & Now.Year.ToString())
            Catch
                dtpTanggalLahir.Value = DateTime.Now
            End Try

            Dim hobiArray As String() = r.Cells(9).Value.ToString().Split({", "}, StringSplitOptions.None)
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
            Dim query As String = "SELECT murid.id, murid.nama_depan, murid.nama_belakang, murid.umur, murid.id_sekolah, sekolah.nama_lengkap AS sekolah, murid.tahun_ajaran, murid.jenis_kelamin, murid.tgl_lahir, murid.hobi FROM murid INNER JOIN sekolah ON murid.id_sekolah = sekolah.id WHERE murid.nama_depan LIKE @c OR murid.nama_belakang LIKE @c"
            da = New MySqlDataAdapter(query, conn)
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

    Private Sub btnKelolaSekolah_Click(sender As Object, e As EventArgs) Handles btnKelolaSekolah.Click
        Dim frmSekolah As New Form2()
        frmSekolah.ShowDialog()
        MuatSekolah()
    End Sub

End Class