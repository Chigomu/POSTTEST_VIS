Module Module1
    Public daftarBuku(-1) As String

    Public Sub TambahDataBuku(ByVal judul As String, ByVal genre As String)
        ReDim Preserve daftarBuku(daftarBuku.Length)
        daftarBuku(daftarBuku.Length - 1) = judul & " (" & genre & ")"
    End Sub

    Public Function CariIndeksBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To daftarBuku.Length - 1
            Dim elemen() As String = Split(daftarBuku(i), " (")
            If elemen(0).ToLower() = judul.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module