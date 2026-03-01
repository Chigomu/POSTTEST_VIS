Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipSemester As Double

        If Double.TryParse(txtIPSemester.Text, ipSemester) Then
            If ipSemester >= 0 And ipSemester <= 4 Then
                totalIP += ipSemester
                jumlahSemester += 1

                Dim ipk As Double = totalIP / jumlahSemester
                txtIPKumulatif.Text = Math.Round(ipk, 2).ToString()

                If ipk >= 2.0 And ipk <= 2.75 Then
                    lblPredikat.Text = "Cukup"
                ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                    lblPredikat.Text = "Memuaskan"
                ElseIf ipk >= 3.01 Then
                    lblPredikat.Text = "Sangat Memuaskan"
                Else
                    lblPredikat.Text = "Kurang"
                End If

                txtIPSemester.Clear()
                txtIPSemester.Focus()
            Else
                MessageBox.Show("Masukkan nilai IP antara 0 sampai 4.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Harap masukkan angka yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0

        txtIPSemester.Clear()
        txtIPKumulatif.Clear()
        lblPredikat.Text = ""

        txtIPSemester.Focus()
    End Sub
End Class