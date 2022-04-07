VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ClsItemServer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Dim rsitem As ADODB.Recordset
Dim MyMahasiswa As Mahasiswa
Dim MyMahasiswaBuffer As Mahasiswa_Buffer
Dim MyDosen As Dosen
Dim MyDosenBuffer As Dosen_Buffer
Dim MyMatakuliah As MataKuliah
Dim MyMatakuliahBuffer As MataKuliah_Buffer
Dim MyMataKuliahPerSem As MataKuliahPerSem
Dim MyMataKuliahPerSemBuffer As MataKuliahPerSem_Buffer
Dim MyMataKuliahMahasiswa As MataKuliahMahasiswa
Dim MyMataKuliahMahasiswaBuffer As MataKuliahMahasiswa_Buffer
Dim myFile As FileMahasiswa
Dim myFileBuffer As FileMahasiswa_Buffer
Dim myPembayaran As Pembayaran
Dim myPembayaranBuffer As Pembayaran_Buffer
Dim myPelayanan As Pelayanan
Dim myPelayananBuffer As Pelayanan_Buffer
Dim MyBiaya As Biaya
Dim MyBiayaBuffer As Biaya_Buffer
Dim MyUser As User
Dim MyUserBuffer As User_Buffer


Public Function GetDosen() As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Dosen"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetDosen = rsitem
    
    
End Function

Public Function GetMK() As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT MK_No, Nama_MK, Tipe_MK, Jenis_MK, UpdateUser, UpdateDate From Mata_Kuliah, Mata_Kuliah_ID WHERE Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID ORDER BY Mata_Kuliah.MK_ID, MK_No"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetMK = rsitem
    
    
End Function
Public Function GetMKPerSem(Periode As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah.MK_No, Nama_MK, Tipe_MK, Jenis_MK, DosenID, SKS, Tipe_Kuliah, Keterangan, Periode, MKP_No, Mata_Kuliah_PerSem.UpdateUser, Mata_Kuliah_PerSem.UpdateDate From Mata_Kuliah, Mata_Kuliah_PerSem, Mata_Kuliah_ID WHERE  Mata_Kuliah.MK_No = Mata_Kuliah_PerSem.MK_No and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID and Periode = " & (Periode) & " ORDER BY Mata_Kuliah.MK_ID, Mata_Kuliah.MK_No"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetMKPerSem = rsitem
    
    
End Function
Public Function GetListMKPerSem(Periode As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim rs2 As ADODB.Recordset
    Dim TotalMahasiswa As Long
    Dim TotalPendengar As Long

    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, MKP_No  From Mata_Kuliah, Mata_Kuliah_PerSem, Mata_Kuliah_ID  WHERE Mata_Kuliah.MK_No = Mata_Kuliah_PerSem.MK_No and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID and  Periode = " & (Periode) & " ORDER BY Mata_Kuliah.MK_ID, Mata_Kuliah.MK_No"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Fields.Append "Mahasiswa", adVarChar, 255
    rsitem.Fields.Append "Pendengar", adVarChar, 255
    
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        
        TotalMahasiswa = 0
        TotalPendengar = 0
        
        Set rs2 = New ADODB.Recordset
        rs2.Open "SELECT * From Mata_kuliah_Mahasiswa, Mata_Kuliah_PerSem WHERE Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No and Periode = " & (Periode) & " and Grade <> 'Pd' and Mata_Kuliah_Mahasiswa.MKP_No = " & CDbl(rs.Fields(4).Value) & " ", cn
        While Not rs2.EOF
            
            TotalMahasiswa = TotalMahasiswa + 1
            rs2.MoveNext
        Wend
        
        
        Set rs2 = New ADODB.Recordset
        rs2.Open "SELECT * From Mata_kuliah_Mahasiswa, Mata_Kuliah_PerSem WHERE Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No and Periode = " & (Periode) & " and Grade = 'Pd' and Mata_Kuliah_Mahasiswa.MKP_No = " & CDbl(rs.Fields(4).Value) & " ", cn
        
        While Not rs2.EOF
            TotalPendengar = TotalPendengar + 1
            rs2.MoveNext
        Wend
        
        
        rsitem.Fields("Mahasiswa") = Trim(TotalMahasiswa)
        rsitem.Fields("Pendengar") = Trim(TotalPendengar)
        
        
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetListMKPerSem = rsitem
    
    
End Function
Public Function GetKRS(Periode As String, NIM As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, Grade, Nilai, Mata_Kuliah_PerSem.Keterangan, Tipe_MK, Jenis_MK, Tipe_Kuliah, Periode, MKM_No, Mata_Kuliah_Mahasiswa.UpdateUser, Mata_Kuliah_Mahasiswa.UpdateDate From Mata_Kuliah_Mahasiswa, Mata_Kuliah_PerSem, Mata_Kuliah, Mata_Kuliah_ID WHERE Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No and Mata_Kuliah_PerSem.MK_No = Mata_Kuliah.MK_No and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID and Periode = " & (Periode) & " and NIM = '" & Trim(NIM) & "' ORDER BY Mata_Kuliah.MK_ID, Mata_Kuliah.MK_No"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetKRS = rsitem
    
    
End Function
Public Function GetKHS(Periode As String, NIM As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, Grade, Nilai, Mata_Kuliah_PerSem.Keterangan, Tipe_MK, Jenis_MK, Tipe_Kuliah, Periode, MKM_No, Mata_Kuliah_Mahasiswa.UpdateUser, Mata_Kuliah_Mahasiswa.UpdateDate From Mata_Kuliah_Mahasiswa, Mata_Kuliah_PerSem, Mata_Kuliah,Mata_Kuliah_ID WHERE   Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No and  Mata_Kuliah_PerSem.MK_No = Mata_Kuliah.MK_No and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID and  Periode = " & (Periode) & " and NIM = '" & Trim(NIM) & "' and Grade <> 'ZZ' ORDER BY Mata_Kuliah.MK_ID, Mata_Kuliah.MK_No"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetKHS = rsitem
    
    
End Function
Public Function GetTotalSKS(Periode As String, NIM As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, Grade, Nilai, Mata_Kuliah_PerSem.Keterangan, Tipe_MK, Jenis_MK, Tipe_Kuliah, Periode, MKM_No, Mata_Kuliah_Mahasiswa.UpdateUser, Mata_Kuliah_Mahasiswa.UpdateDate From Mata_Kuliah_Mahasiswa, Mata_Kuliah_PerSem, Mata_Kuliah, Mata_Kuliah_ID  WHERE Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No and  Mata_Kuliah_PerSem.MK_No = Mata_Kuliah.MK_No  and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID  and  Periode = " & (Periode) & " and NIM = '" & Trim(NIM) & "' ORDER BY Mata_Kuliah.MK_ID, Mata_Kuliah.MK_No"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetTotalSKS = rsitem
    
    
End Function
Public Function GetKHSKumulatif(Periode As String, NIM As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, Grade, Nilai, Mata_Kuliah_PerSem.Keterangan, Tipe_MK, Jenis_MK, Tipe_Kuliah, Periode, MKM_No, Mata_Kuliah_Mahasiswa.UpdateUser, Mata_Kuliah_Mahasiswa.UpdateDate From Mata_Kuliah_Mahasiswa, Mata_Kuliah_PerSem, Mata_Kuliah, Mata_Kuliah_ID  WHERE Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No and Mata_Kuliah_PerSem.MK_No = Mata_Kuliah.MK_No  and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID and  Periode <= " & (Periode) & " and NIM = '" & Trim(NIM) & "' and Grade <> 'ZZ' ORDER BY Mata_Kuliah.MK_ID, Mata_Kuliah.MK_No"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetKHSKumulatif = rsitem
    
    
End Function
Public Function GetMasukNilai(Periode As String, NIM As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, Grade, Nilai, Mata_Kuliah_PerSem.Keterangan, Tipe_MK, Jenis_MK, Tipe_Kuliah, Periode, MKM_No, Mata_Kuliah_Mahasiswa.UpdateUser, Mata_Kuliah_Mahasiswa.UpdateDate From Mata_Kuliah_Mahasiswa,  Mata_Kuliah_PerSem, Mata_Kuliah, Mata_Kuliah_ID WHERE Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No and Mata_Kuliah_PerSem.MK_No = Mata_Kuliah.MK_No and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID and Periode = " & (Periode) & " and NIM = '" & Trim(NIM) & "' and Grade = 'ZZ' and Grade <> 'Pd' ORDER BY Mata_Kuliah.MK_ID, Mata_Kuliah.MK_No"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetMasukNilai = rsitem
    
    
End Function
Public Function GetMasukNilaiPerMK(Periode As String, MKNo As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah_Mahasiswa.NIM, Nama_Awal, Nama_Akhir, Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, Grade, Nilai, Mata_Kuliah_PerSem.Keterangan, Tipe_MK, Jenis_MK, Tipe_Kuliah, Periode, MKM_No, Mata_Kuliah_Mahasiswa.UpdateUser, Mata_Kuliah_Mahasiswa.UpdateDate From Mata_Kuliah_Mahasiswa, Mahasiswa, Mata_Kuliah_PerSem, Mata_Kuliah, Mata_Kuliah_ID WHERE Mata_Kuliah_PerSem.MK_No = Mata_Kuliah.MK_No and Mata_Kuliah_Mahasiswa.NIM = Mahasiswa.NIM and Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID and Periode = " & (Periode) & " and Mata_Kuliah_PerSem.MK_No = '" & Trim(MKNo) & "' and Grade = 'ZZ' and Grade <> 'Pd' ORDER BY Mata_Kuliah_Mahasiswa.NIM"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        If rs.Fields(i).Name = "Nama_Awal" Then
            rsitem.Fields.Append "Nama", adVarChar, 255
        ElseIf rs.Fields(i).Name = "Nama_Akhir" Then
            
        Else
            rsitem.Fields.Append rs(i).Name, adVarChar, 255
        End If
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                If rs.Fields(j).Name = "NIM" Then
                     rsitem.Fields(j) = Trim(rs.Fields(j))
                ElseIf rs.Fields(j).Name = "Nama_Awal" Then
                     rsitem.Fields(j) = Trim(rs.Fields(j)) + " " + Trim(rs.Fields(j + 1))
                ElseIf rs.Fields(j).Name = "Nama_Akhir" Then
                
                Else
                     rsitem.Fields(j - 1) = Trim(rs.Fields(j))
                End If
                
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetMasukNilaiPerMK = rsitem
    
    
End Function
Public Function GetDaftarNilai(Periode As String, MKNo As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah_Mahasiswa.NIM, Nama_Awal, Nama_Akhir, Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, Grade, Nilai, Keterangan, Tipe_MK, Jenis_MK, Tipe_Kuliah, Periode, MKM_No, Mata_Kuliah_Mahasiswa.UpdateUser, Mata_Kuliah_Mahasiswa.UpdateDate From Mata_Kuliah_Mahasiswa, Mahasiswa, Mata_Kuliah_PerSem, Mata_Kuliah, Mata_Kuliah_ID WHERE Mata_Kuliah_Mahasiswa.NIM = Mahasiswa.NIM  and Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No  and Mata_Kuliah_PerSem.MK_No = Mata_Kuliah.MK_No  and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID and  Periode = " & (Periode) & " and Mata_Kuliah_PerSem.MK_No = '" & Trim(MKNo) & "' and Grade <> 'ZZ' and Grade <> 'Pd' ORDER BY Mata_Kuliah_Mahasiswa.NIM"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        If rs.Fields(i).Name = "Nama_Awal" Then
            rsitem.Fields.Append "Nama", adVarChar, 255
        ElseIf rs.Fields(i).Name = "Nama_Akhir" Then
            
        Else
            rsitem.Fields.Append rs(i).Name, adVarChar, 255
        End If
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                If rs.Fields(j).Name = "NIM" Then
                     rsitem.Fields(j) = Trim(rs.Fields(j))
                ElseIf rs.Fields(j).Name = "Nama_Awal" Then
                     rsitem.Fields(j) = Trim(rs.Fields(j)) + " " + Trim(rs.Fields(j + 1))
                ElseIf rs.Fields(j).Name = "Nama_Akhir" Then
                
                Else
                     rsitem.Fields(j - 1) = Trim(rs.Fields(j))
                End If
                
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetDaftarNilai = rsitem
    
    
End Function
Public Function GetAbsensi(MKPNo As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim NoUrut As Long
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah_Mahasiswa.NIM, Nama_Awal, Nama_Akhir, Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, Keterangan, Tipe_MK, Jenis_MK, Tipe_Kuliah, Periode, MKM_No From Mata_Kuliah_Mahasiswa, Mahasiswa, Mata_Kuliah_PerSem, Mata_Kuliah, Mata_Kuliah_ID WHERE Mata_Kuliah_Mahasiswa.NIM = Mahasiswa.NIM  and Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No  and Mata_Kuliah_PerSem.MK_No = Mata_Kuliah.MK_No  and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID AND Periode = " & (Periode) & " and Mata_Kuliah_PerSem.MKP_No = '" & Trim(MKPNo) & "' ORDER BY Mata_Kuliah_Mahasiswa.NIM"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        If rs.Fields(i).Name = "Nama_Awal" Then
            rsitem.Fields.Append "Nama", adVarChar, 255
        ElseIf rs.Fields(i).Name = "Nama_Akhir" Then
            
        Else
            rsitem.Fields.Append rs(i).Name, adVarChar, 255
        End If
    Next i
    rsitem.Fields.Append "No_Urut", adVarChar, 255
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                If rs.Fields(j).Name = "NIM" Then
                     rsitem.Fields(j) = Trim(rs.Fields(j))
                ElseIf rs.Fields(j).Name = "Nama_Awal" Then
                     rsitem.Fields(j) = Trim(rs.Fields(j)) + " " + Trim(rs.Fields(j + 1))
                ElseIf rs.Fields(j).Name = "Nama_Akhir" Then
                
                Else
                     rsitem.Fields(j - 1) = Trim(rs.Fields(j))
                End If
                
            End If
            
        Next j
        NoUrut = NoUrut + 1
        rsitem.Fields("No_Urut") = Trim(NoUrut)
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetAbsensi = rsitem
    
    
End Function
Public Function GetTranskrip(NIM As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, Grade, Nilai, Mata_Kuliah_PerSem.Keterangan, Tipe_MK, Jenis_MK, Tipe_Kuliah, Periode, MKM_No, Mata_Kuliah_Mahasiswa.UpdateUser, Mata_Kuliah_Mahasiswa.UpdateDate From Mata_Kuliah_Mahasiswa, Mata_Kuliah_PerSem, Mata_Kuliah, Mata_Kuliah_ID   WHERE Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No and  Mata_Kuliah_PerSem.MK_No = Mata_Kuliah.MK_No and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID and  NIM = '" & Trim(NIM) & "' and Grade <> 'ZZ' ORDER BY Mata_Kuliah.MK_ID, Mata_Kuliah.MK_No"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetTranskrip = rsitem
    
    
End Function
Public Function GetTranskripKumulatif(NIM As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Mata_Kuliah.MK_No, Nama_MK, DosenID, SKS, Grade, Nilai, Mata_Kuliah_PerSem.Keterangan, Tipe_MK, Jenis_MK, Tipe_Kuliah, Periode, MKM_No, Mata_Kuliah_Mahasiswa.UpdateUser, Mata_Kuliah_Mahasiswa.UpdateDate From Mata_Kuliah_Mahasiswa, Mata_Kuliah_PerSem, Mata_Kuliah, Mata_Kuliah_ID WHERE  Mata_Kuliah_Mahasiswa.MKP_No = Mata_Kuliah_PerSem.MKP_No and Mata_Kuliah_PerSem.MK_No = Mata_Kuliah.MK_No  and Mata_Kuliah.MK_ID = Mata_Kuliah_ID.MK_ID and NIM = '" & Trim(NIM) & "' and Grade <> 'ZZ' ORDER BY Mata_Kuliah.MK_ID, Mata_Kuliah.MK_No"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetTranskripKumulatif = rsitem
    
    
End Function
Public Function GetFile(NIM As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From FileMahasiswa WHERE NIM = '" & Trim(NIM) & "' "
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetFile = rsitem
    
    
End Function
Public Function GetPembayaran(Periode As String, NIM As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT PembayaranNo, Deskripsi, Tanggal, Jumlah, Keterangan, UpdateUser, UpdateDate From Pembayaran WHERE NIM = '" & Trim(NIM) & "' and Periode = " & (Trim(Periode))
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetPembayaran = rsitem
    
    
End Function
Public Function GetPelayanan(NIM As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT PelayananNo, Periode, Pelayanan, UpdateUser, UpdateDate From Pelayanan WHERE NIM = '" & Trim(NIM) & "' "
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetPelayanan = rsitem
    
    
End Function
Public Function GetBiaya() As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Program, Biaya From Biaya"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetBiaya = rsitem
    
    
End Function
Public Function GetTotalBiaya(Program As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT Biaya From Biaya WHERE Program = '" & Trim(Program) & "' "
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetTotalBiaya = rsitem
    
    
End Function
Public Function GetUser() As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT LoginID, UserName From MyLogin"
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set GetUser = rsitem
    
    
End Function
Public Function SearchMahasiswa(Buffer As String) As ADODB.Recordset

    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    
    strSQL = "SELECT NIM, Nama_Awal, Nama_Akhir, Alamat, Telepon, HP, Email, TempatLahir, TanggalLahir, Program, PeriodeMasuk, Status, UpdateUser, UpdateDate, Password From Mahasiswa "
    
    MyMahasiswaBuffer.Buffer = Buffer
    LSet MyMahasiswa = MyMahasiswaBuffer
    
    If Not Trim(MyMahasiswa.NIM) = "" Then
        strSQL = strSQL & " WHERE NIM = '" & Trim(MyMahasiswa.NIM) & "' "
    Else
        strSQL = strSQL & " WHERE NIM <> 'ZZZ' "
    End If
    
    If Not Trim(MyMahasiswa.Nama_Awal) = "" Then
        strSQL = strSQL & " and Nama_Awal LIKE '%" & Trim(MyMahasiswa.Nama_Awal) & "%' "
    End If
    
    If Not Trim(MyMahasiswa.Nama_Akhir) = "" Then
        strSQL = strSQL & " and Nama_Akhir LIKE '%" & Trim(MyMahasiswa.Nama_Akhir) & "%' "
    End If
    
    'if not trim
    rs.Open strSQL, cn
    
        
    Set rsitem = New ADODB.Recordset
    rsitem.CursorLocation = adUseClient
    rsitem.CursorType = adOpenStatic
    For i = 0 To rs.Fields.Count - 1
        rsitem.Fields.Append rs(i).Name, adVarChar, 255
    Next i
    rsitem.Open
    While Not rs.EOF
        rsitem.AddNew
        For j = 0 To rs.Fields.Count - 1
            If Not IsNull(rs(j).Value) Then ' if it TroubleDatat null
                rsitem.Fields(j) = Trim(rs.Fields(j))
            End If
        Next j
        rsitem.Update
        rs.MoveNext
    Wend
    
    Set SearchMahasiswa = rsitem
End Function
Public Function DoubleNIM(NIM As String) As Boolean
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Mahasiswa WHERE NIM = '" & Trim(NIM) & "' "
    rs.Open strSQL, cn
    If rs.EOF Then
        DoubleNIM = False
    Else
        DoubleNIM = True
    End If

End Function

Public Function DoubleDosenID(DosenID As String) As Boolean
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Dosen WHERE DosenID = '" & Trim(DosenID) & "' "
    rs.Open strSQL, cn
    If rs.EOF Then
        DoubleDosenID = False
    Else
        DoubleDosenID = True
    End If

End Function
Public Function DoubleMKNo(MKNo As String) As Boolean
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Mata_Kuliah WHERE MK_No = '" & Trim(MKNo) & "' "
    rs.Open strSQL, cn
    If rs.EOF Then
        DoubleMKNo = False
    Else
        DoubleMKNo = True
    End If

End Function

Public Function AddMahasiswa(Buffer As String, UpdateUser As String) As Boolean
    
    MyMahasiswaBuffer.Buffer = Buffer
    LSet MyMahasiswa = MyMahasiswaBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Mahasiswa"
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    
    rs.AddNew
    rs.Fields("NIM") = Trim(MyMahasiswa.NIM)
    rs.Fields("Nama_Awal") = Trim(MyMahasiswa.Nama_Awal)
    rs.Fields("Nama_Akhir") = Trim(MyMahasiswa.Nama_Akhir)
    rs.Fields("Alamat") = Trim(MyMahasiswa.Alamat)
    rs.Fields("Telepon") = Trim(MyMahasiswa.Telepon)
    rs.Fields("HP") = Trim(MyMahasiswa.HP)
    rs.Fields("Email") = Trim(MyMahasiswa.Email)
    rs.Fields("TempatLahir") = Trim(MyMahasiswa.TempatLahir)
    If Trim(MyMahasiswa.TanggalLahir) <> "" And IsDate(Trim(MyMahasiswa.TanggalLahir)) Then rs.Fields("Tanggallahir") = CDate(Trim(MyMahasiswa.TanggalLahir))
    rs.Fields("Program") = Trim(MyMahasiswa.Program)
    rs.Fields("PeriodeMasuk") = Trim(MyMahasiswa.PeriodeMasuk)
    rs.Fields("Status") = Trim(MyMahasiswa.Status)
    rs.Fields("UpdateUser") = Trim(UpdateUser)
    rs.Fields("UpdateDate") = Date
    rs.Fields("Password") = ""
    rs.Update
    AddMahasiswa = True

End Function

Public Function AddDosen(Buffer As String, UpdateUser As String) As Boolean
    
    MyDosenBuffer.Buffer = Buffer
    LSet MyDosen = MyDosenBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Dosen"
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    
    rs.AddNew
    rs.Fields("DosenID") = Trim(MyDosen.DosenID)
    rs.Fields("Nama_Awal") = Trim(MyDosen.Nama_Awal)
    rs.Fields("Nama_Akhir") = Trim(MyDosen.Nama_Akhir)
    rs.Fields("Alamat") = Trim(MyDosen.Alamat)
    rs.Fields("Telepon") = Trim(MyDosen.Telepon)
    rs.Fields("HP") = Trim(MyDosen.HP)
    rs.Fields("Email") = Trim(MyDosen.Email)
    rs.Fields("TempatLahir") = Trim(MyDosen.TempatLahir)
    If Trim(MyDosen.TanggalLahir) <> "" And IsDate(Trim(MyDosen.TanggalLahir)) Then rs.Fields("Tanggallahir") = CDate(Trim(MyDosen.TanggalLahir))
    rs.Fields("UpdateUser") = Trim(UpdateUser)
    rs.Fields("UpdateDate") = Date
    rs.Update
    AddDosen = True

End Function

Public Function UpdateDosen(Buffer As String, UpdateUser As String) As Boolean
    
    MyDosenBuffer.Buffer = Buffer
    LSet MyDosen = MyDosenBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Dosen WHERE DosenID = '" & Trim(MyDosen.DosenID) & "' "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    

    rs.Fields("Nama_Awal") = Trim(MyDosen.Nama_Awal)
    rs.Fields("Nama_Akhir") = Trim(MyDosen.Nama_Akhir)
    rs.Fields("Alamat") = Trim(MyDosen.Alamat)
    rs.Fields("Telepon") = Trim(MyDosen.Telepon)
    rs.Fields("HP") = Trim(MyDosen.HP)
    rs.Fields("Email") = Trim(MyDosen.Email)
    rs.Fields("TempatLahir") = Trim(MyDosen.TempatLahir)
    If Trim(MyDosen.TanggalLahir) <> "" And IsDate(Trim(MyDosen.TanggalLahir)) Then rs.Fields("Tanggallahir") = CDate(Trim(MyDosen.TanggalLahir))
    rs.Fields("UpdateUser") = Trim(UpdateUser)
    rs.Fields("UpdateDate") = Date
    rs.Update
    UpdateDosen = True

End Function

Public Function saveMK(Buffer As String, UpdateUser As String) As Boolean
    
    MyMatakuliahBuffer.Buffer = Buffer
    LSet MyMatakuliah = MyMatakuliahBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim rs2 As ADODB.Recordset
    Dim strSQL As String
    Dim strSQL2 As String
    strSQL = "SELECT * From Mata_Kuliah WHERE MK_No = '" & Trim(MyMatakuliah.MK_No) & "' "
    

    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    
    If rs.EOF Then
        strSQL2 = "SELECT * From Mata_Kuliah"
        Set rs2 = New ADODB.Recordset
        rs2.Open strSQL2, cn, adOpenDynamic, adLockOptimistic
        rs2.AddNew
        rs2.Fields("MK_No") = Trim(MyMatakuliah.MK_No)
        rs2.Fields("Nama_MK") = Trim(MyMatakuliah.Nama_MK)
        rs2.Fields("Tipe_MK") = Trim(MyMatakuliah.Tipe_MK)
        rs2.Fields("MK_ID") = CInt(Trim(MyMatakuliah.MK_ID))
        rs2.Fields("UpdateUser") = Trim(UpdateUser)
        rs2.Fields("UpdateDate") = Date
        rs2.Update
    Else
        rs.Fields("Nama_MK") = Trim(MyMatakuliah.Nama_MK)
        rs.Fields("Tipe_MK") = Trim(MyMatakuliah.Tipe_MK)
        rs.Fields("MK_ID") = CInt(Trim(MyMatakuliah.MK_ID))
        rs.Fields("UpdateUser") = Trim(UpdateUser)
        rs.Fields("UpdateDate") = Date
        rs.Update
    End If
    saveMK = True

End Function
Public Function saveMKPerSem(Buffer As String, UpdateUser As String) As Boolean
    
    MyMataKuliahPerSemBuffer.Buffer = Buffer
    LSet MyMataKuliahPerSem = MyMataKuliahPerSemBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim rs2 As ADODB.Recordset
    Dim strSQL As String
    Dim strSQL2 As String
    strSQL = "SELECT * From Mata_Kuliah_PerSem WHERE MKP_No = " & CLng(Trim(MyMataKuliahPerSem.MKP_No))
    

    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    
    If rs.EOF Then
        strSQL2 = "SELECT * From Mata_Kuliah_PerSem"
        Set rs2 = New ADODB.Recordset
        rs2.Open strSQL2, cn, adOpenDynamic, adLockOptimistic
        rs2.AddNew
        rs2.Fields("MK_No") = Trim(MyMataKuliahPerSem.MK_No)
        MyMataKuliahPerSem.Periode = Replace(MyMataKuliahPerSem.Periode, ".", ",")
        rs2.Fields("Periode") = (Trim(MyMataKuliahPerSem.Periode))
        rs2.Fields("DosenID") = Trim(MyMataKuliahPerSem.DosenID)
        rs2.Fields("SKS") = CInt(Trim(MyMataKuliahPerSem.SKS))
        rs2.Fields("Tipe_Kuliah") = Trim(MyMataKuliahPerSem.TipeKuliah)
        rs2.Fields("Keterangan") = Trim(MyMataKuliahPerSem.Keterangan)
        rs2.Fields("UpdateUser") = Trim(UpdateUser)
        rs2.Fields("UpdateDate") = Date
         rs2.Update
    Else
        rs.Fields("MK_No") = Trim(MyMataKuliahPerSem.MK_No)
                MyMataKuliahPerSem.Periode = Replace(MyMataKuliahPerSem.Periode, ".", ",")
        rs.Fields("Periode") = (Trim(MyMataKuliahPerSem.Periode))
        rs.Fields("DosenID") = Trim(MyMataKuliahPerSem.DosenID)
        rs.Fields("SKS") = CInt(Trim(MyMataKuliahPerSem.SKS))
        rs.Fields("Tipe_Kuliah") = Trim(MyMataKuliahPerSem.TipeKuliah)
        rs.Fields("Keterangan") = Trim(MyMataKuliahPerSem.Keterangan)
        rs.Fields("UpdateUser") = Trim(UpdateUser)
        rs.Fields("UpdateDate") = Date
    rs.Update
    End If
    saveMKPerSem = True

End Function
Public Function saveKRS(Buffer As String, UpdateUser As String) As Boolean
    
    MyMataKuliahMahasiswaBuffer.Buffer = Buffer
    LSet MyMataKuliahMahasiswa = MyMataKuliahMahasiswaBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset

    Dim strSQL As String

    strSQL = "SELECT * From Mata_Kuliah_Mahasiswa"
    

    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.AddNew
        rs.Fields("MKP_No") = Trim(MyMataKuliahMahasiswa.MKP_No)
        rs.Fields("NIM") = Trim(MyMataKuliahMahasiswa.NIM)
        rs.Fields("Grade") = Trim(MyMataKuliahMahasiswa.Grade)
        rs.Fields("Nilai") = CDbl(0)
        rs.Fields("UpdateUser") = Trim(UpdateUser)
        rs.Fields("UpdateDate") = Date
        
    
    rs.Update
    
    saveKRS = True

End Function
Public Function saveFile(Buffer As String, UpdateUser As String) As Boolean
    
    myFileBuffer.Buffer = Buffer
    LSet myFile = myFileBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset

    Dim strSQL As String
    If Trim(myFile.FileID) = "" Then
        strSQL = "SELECT * From FileMahasiswa "
        rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
        rs.AddNew
            rs.Fields("Deskripsi") = Trim(myFile.Deskripsi)
            rs.Fields("NamaFile") = Trim(myFile.NamaFile)
            rs.Fields("NIM") = Trim(myFile.NIM)
            rs.Fields("UpdateUser") = Trim(UpdateUser)
             rs.Fields("UpdateDate") = Date
        rs.Update
    
    Else
        strSQL = "SELECT * From FileMahasiswa WHERE FileMahasiswaID = " & CLng(Trim(myFile.FileID))
        rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic

            rs.Fields("Deskripsi") = Trim(myFile.Deskripsi)
            rs.Fields("NamaFile") = Trim(myFile.NamaFile)
            rs.Fields("NIM") = Trim(myFile.NIM)
            rs.Fields("UpdateUser") = Trim(UpdateUser)
            rs.Fields("UpdateDate") = Date
        rs.Update
    
    End If
    saveFile = True

End Function
Public Function savePembayaran(Buffer As String, UpdateUser As String) As Boolean
    
    myPembayaranBuffer.Buffer = Buffer
    LSet myPembayaran = myPembayaranBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset

    Dim strSQL As String
    If Trim(myPembayaran.PembayaranNo) = "" Then
        strSQL = "SELECT * From Pembayaran "
        rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
        rs.AddNew
            
            rs.Fields("NIM") = Trim(myPembayaran.NIM)
            myPembayaran.Periode = Replace(myPembayaran.Periode, ".", ",")
            rs.Fields("Periode") = (Trim(myPembayaran.Periode))
            rs.Fields("Deskripsi") = Trim(myPembayaran.Deskripsi)
            If Trim(myPembayaran.Tanggal) <> "" And IsDate(Trim(myPembayaran.Tanggal)) Then rs.Fields("Tanggal") = CDate(Trim(myPembayaran.Tanggal))
            rs.Fields("Jumlah") = CDbl(Trim(myPembayaran.Jumlah))
            rs.Fields("Keterangan") = Trim(myPembayaran.Keterangan)
            rs.Fields("UpdateUser") = Trim(UpdateUser)
            rs.Fields("UpdateDate") = Date
        rs.Update
    
    Else
        strSQL = "SELECT * From Pembayaran WHERE PembayaranNo = " & CLng(Trim(myPembayaran.PembayaranNo))
        rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic

            rs.Fields("NIM") = Trim(myPembayaran.NIM)
            myPembayaran.Periode = Replace(myPembayaran.Periode, ".", ",")
            rs.Fields("Periode") = (Trim(myPembayaran.Periode))
            rs.Fields("Deskripsi") = Trim(myPembayaran.Deskripsi)
            If Trim(myPembayaran.Tanggal) <> "" And IsDate(Trim(myPembayaran.Tanggal)) Then rs.Fields("Tanggal") = CDate(Trim(myPembayaran.Tanggal))
            rs.Fields("Jumlah") = CDbl(Trim(myPembayaran.Jumlah))
            rs.Fields("Keterangan") = Trim(myPembayaran.Keterangan)
            rs.Fields("UpdateUser") = Trim(UpdateUser)
            rs.Fields("UpdateDate") = Date
        rs.Update
    
    End If
    savePembayaran = True

End Function
Public Function savePelayanan(Buffer As String, UpdateUser As String) As Boolean
    
    myPelayananBuffer.Buffer = Buffer
    LSet myPelayanan = myPelayananBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset

    Dim strSQL As String
    If Trim(myPelayanan.PelayananNo) = "" Then
        strSQL = "SELECT * From Pelayanan "
        rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
        rs.AddNew
            
            rs.Fields("NIM") = Trim(myPelayanan.NIM)
            rs.Fields("Periode") = Trim(myPelayanan.Periode)
            rs.Fields("Pelayanan") = Trim(myPelayanan.Pelayanan)
            rs.Fields("UpdateUser") = Trim(UpdateUser)
            rs.Fields("UpdateDate") = Date
        rs.Update
    
    Else
        strSQL = "SELECT * From Pelayanan WHERE PelayananNo = " & CLng(Trim(myPelayanan.PelayananNo))
        rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic

            rs.Fields("NIM") = Trim(myPelayanan.NIM)
            rs.Fields("Periode") = Trim(myPelayanan.Periode)
            rs.Fields("Pelayanan") = Trim(myPelayanan.Pelayanan)
            rs.Fields("UpdateUser") = Trim(UpdateUser)
        rs.Fields("UpdateDate") = Date
        rs.Update
    
    End If
    savePelayanan = True

End Function
Public Function saveBiaya(Buffer As String) As Boolean
    
    MyBiayaBuffer.Buffer = Buffer
    LSet MyBiaya = MyBiayaBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim rs2 As ADODB.Recordset
    Set rs2 = New ADODB.Recordset
    
    Dim strSQL As String
    strSQL = "SELECT * From Biaya WHERE Program = '" & Trim(MyBiaya.Program) & "' "
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    
    If rs.EOF Then
        strSQL = "SELECT * From Biaya"
        rs2.Open strSQL, cn, adOpenDynamic, adLockOptimistic
        rs2.AddNew
        rs2.Fields("Program") = Trim(MyBiaya.Program)
        rs2.Fields("Biaya") = CCur(MyBiaya.Biaya)
        rs2.Update
    Else
        strSQL = "SELECT * From Biaya WHERE Program = '" & Trim(MyBiaya.Program) & "' "
        rs2.Open strSQL, cn, adOpenDynamic, adLockOptimistic
        rs2.Fields("Program") = Trim(MyBiaya.Program)
        rs2.Fields("Biaya") = CCur(MyBiaya.Biaya)
        rs2.Update
    

    
    End If
    saveBiaya = True

End Function
Public Function saveUser(Buffer As String) As Boolean
    MyUserBuffer.Buffer = Buffer
    LSet MyUser = MyUserBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    
    Dim strSQL As String
    strSQL = "SELECT * From MyLogin"
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.AddNew
    rs.Fields("UserName") = Trim(MyUser.UserName)
    rs.Fields("UserPassword") = Trim(MyUser.UserPassword)
    rs.Fields("UserAuthority") = Trim(MyUser.UserAuthority)
    rs.Update
    saveUser = True
End Function
Public Function updatemahasiswa(Buffer As String, UpdateUser As String) As Boolean
    
    MyMahasiswaBuffer.Buffer = Buffer
    LSet MyMahasiswa = MyMahasiswaBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Mahasiswa WHERE NIM = '" & Trim(MyMahasiswa.NIM) & "' "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    
    rs.Fields("NIM") = Trim(MyMahasiswa.NIM)
    rs.Fields("Nama_Awal") = Trim(MyMahasiswa.Nama_Awal)
    rs.Fields("Nama_Akhir") = Trim(MyMahasiswa.Nama_Akhir)
    rs.Fields("Alamat") = Trim(MyMahasiswa.Alamat)
    rs.Fields("Telepon") = Trim(MyMahasiswa.Telepon)
    rs.Fields("HP") = Trim(MyMahasiswa.HP)
    rs.Fields("Email") = Trim(MyMahasiswa.Email)
    rs.Fields("TempatLahir") = Trim(MyMahasiswa.TempatLahir)
    If Trim(MyMahasiswa.TanggalLahir) <> "" And IsDate(Trim(MyMahasiswa.TanggalLahir)) Then rs.Fields("Tanggallahir") = CDate(Trim(MyMahasiswa.TanggalLahir))
    rs.Fields("Program") = Trim(MyMahasiswa.Program)
    rs.Fields("PeriodeMasuk") = Trim(MyMahasiswa.PeriodeMasuk)
    rs.Fields("Status") = Trim(MyMahasiswa.Status)
    rs.Fields("UpdateUser") = Trim(UpdateUser)
    rs.Fields("UpdateDate") = Date
    rs.Fields("Password") = Trim(MyMahasiswa.Password)
    rs.Update
    updatemahasiswa = True

End Function
Public Function putNilai(Buffer As String, UpdateUser As String) As Boolean
      MyMataKuliahMahasiswaBuffer.Buffer = Buffer
    LSet MyMataKuliahMahasiswa = MyMataKuliahMahasiswaBuffer
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    rs.Open "SELECT * From Mata_Kuliah_Mahasiswa WHERE Grade = 'ZZ' and MKM_No = " & CLng(Trim(MyMataKuliahMahasiswa.MKM_No)) & " ", cn, adOpenDynamic, adLockOptimistic


        rs.Fields("Grade") = Trim(MyMataKuliahMahasiswa.Grade)
        rs.Fields("Nilai") = Trim(MyMataKuliahMahasiswa.Nilai)
        rs.Fields("UpdateUser") = Trim(UpdateUser)
        rs.Fields("UpdateDate") = Date
    rs.Update
    
    putgrade = True
End Function
Public Function DeleteMahasiswa(NIM As String) As Boolean
    
 
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Mahasiswa WHERE NIM = '" & Trim(NIM) & "' "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.Delete
    DeleteMahasiswa = True
End Function
Public Function DeleteDosen(DosenID As String) As Boolean
    
 
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Dosen WHERE DosenID = '" & Trim(DosenID) & "' "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.Delete
    DeleteDosen = True
End Function
Public Function DeleteMataKuliah(MKNo As String) As Boolean
    
 
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Mata_Kuliah WHERE MK_No = '" & Trim(MKNo) & "' "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.Delete
    DeleteMataKuliah = True
End Function
Public Function DeleteMataKuliahPerSem(MKPNo As String) As Boolean
    
 
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Mata_Kuliah_PerSem WHERE MKP_No = '" & Trim(MKPNo) & "' "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.Delete
    DeleteMataKuliahPerSem = True
End Function
Public Function DeleteKRS(MKMNo As String) As Boolean
    
 
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Mata_Kuliah_Mahasiswa WHERE MKM_No = " & CLng(Trim(MKMNo)) & " "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.Delete
    DeleteKRS = True
End Function
Public Function DeleteFile(FileID As String) As Boolean
    
 
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From FileMahasiswa WHERE FileMahasiswaID =  " & CLng(Trim(FileID)) & " "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.Delete
    DeleteFile = True
End Function
Public Function DeletePembayaran(PembayaranNo As String) As Boolean
    
 
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Pembayaran WHERE PembayaranNo =  " & CLng(Trim(PembayaranNo)) & " "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.Delete
    DeletePembayaran = True
End Function
Public Function DeletePelayanan(PelayananNo As String) As Boolean
    
 
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Pelayanan WHERE PelayananNo =  " & CLng(Trim(PelayananNo)) & " "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.Delete
    DeletePelayanan = True
End Function
Public Function DeleteBiaya(Program As String) As Boolean
    
 
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From Biaya WHERE Program =  '" & Program & "' "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.Delete
    DeleteBiaya = True
End Function
Public Function DeleteUser(LoginID As String) As Boolean
    
 
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT * From MyLogin WHERE LoginID =  " & CInt(LoginID) & " "
    
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    rs.Delete
    DeleteUser = True
End Function
Private Sub Class_Initialize()
    ConnectNow
End Sub
