Attribute VB_Name = "Module1"
Public Declare Function ExitWindowsEx Lib "user32" (ByVal dwOption As Long, ByVal dwReserved As Long) As Long
Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Public Const SW_MAXIMIZE = 3
Public Const EWX_LOGOFF = 0
Public cn As Connection
Public Periode As String
Public strperiode As String
Public strperiode2 As String
Public SearchMahasiswa As Mahasiswa
Public SearchMahasiswaBuffer As Mahasiswa_Buffer
Public CurrentMahasiswa As Mahasiswa
Public CurrentMahasiswaBuffer As Mahasiswa_Buffer
Public Lite As String
Public strMatakuliahPerSemNo As String
Public UpdateUser As String
Public PasswordUser As String
Public UserName As String
Public UserPassword As String
Public UserAuthority As String


Public Sub ConnectNow()
    
    Set cn = New Connection
    cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + App.Path + "\AcademicDb.mdb;Persist Security Info=False"
    cn.Mode = adModeReadWrite
    cn.Open

End Sub

Public Sub ShutDownWindows()
    ExitWindowsEx EWX_LOGOFF, 0
End Sub
Public Sub CenterChildForm(ByRef frmIn As Form)
    On Error Resume Next
    frmIn.Top = (MDIfrmMenu.ScaleHeight - frmIn.Height) \ 2 + 300
    frmIn.Left = (MDIfrmMenu.ScaleWidth - frmIn.Width) \ 2
End Sub
Public Sub CenterChildForm2(ByRef frmIn As Form)
    On Error Resume Next
    frmIn.Top = (MDIfrmMenu.ScaleHeight - frmIn.Height) \ 2
    frmIn.Left = (MDIfrmMenu.ScaleWidth - frmIn.Width) \ 2
End Sub
Public Sub CenterChildForm3(ByRef frmIn As Form, ByRef frmBackGround As Form)
    On Error Resume Next
    frmIn.Top = (frmBackGround.ScaleHeight - frmIn.Height) \ 2
    frmIn.Left = (frmBackGround.ScaleWidth - frmIn.Width) \ 2
End Sub
Public Sub CenterChildForm4(ByRef frmIn As Form)
    On Error Resume Next
    frmIn.Top = (MDIfrmMenu.ScaleHeight - frmIn.Height) \ 2 + 1000
    frmIn.Left = (MDIfrmMenu.ScaleWidth - frmIn.Width) \ 2
End Sub
Public Sub CloseAllForm()
        Dim frm As Form
        For Each frm In Forms
            If Val(frm.Tag) = 100 Then
                Unload frm
            End If
        Next frm
End Sub


