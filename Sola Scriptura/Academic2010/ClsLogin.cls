VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ClsLogin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False


Private Sub Class_Initialize()
    ConnectNow
End Sub

Public Function LoginNow(UserName As String, UserPassword As String) As String
 Dim LoginRecordset As ADODB.Recordset
    Set LoginRecordset = New ADODB.Recordset
    
    strSQL = "SELECT * From Mylogin Where UserName = '" & Trim(UserName) & "' and UserPassword = '" & Trim(UserPassword) & "'"
    LoginRecordset.Open strSQL, cn, adOpenDynamic, adLockOptimistic ' open the table
    
    If Not LoginRecordset.EOF Then
        LoginNow = Trim(LoginRecordset.Fields("UserAuthority").Value)
    Else
        LoginNow = "False"
    End If
End Function
Public Function ChangePassword(UserName As String, UserPassword As String) As Boolean
    Dim LoginRecordset As ADODB.Recordset
    Set LoginRecordset = New ADODB.Recordset
    
    strSQL = "SELECT * From Mylogin Where UserName = '" & Trim(UserName) & "' "
    LoginRecordset.Open strSQL, cn, adOpenDynamic, adLockOptimistic ' open the table
    If Not LoginRecordset.EOF Then
        LoginRecordset.Fields(2) = Trim(UserPassword)
        LoginRecordset.Update
        ChangePassword = True
    Else
        ChangePassword = False
    End If
End Function
