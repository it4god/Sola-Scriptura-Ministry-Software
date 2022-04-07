VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "User"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Private StaffName As String
Private StaffPassword As String
Private ValidUser As Boolean
Private Sub Class_Initialize()
ValidUser = False
End Sub

Public Property Get UserName() As String
    UserName = StaffName
End Property

Public Property Let UserName(ByVal vNewValue As String)
   StaffName = vNewValue
End Property

Public Property Get UserPassword() As String
    UserPassword = StaffPassword
End Property

Public Property Let UserPassword(ByVal vNewValue As String)
    StaffPassword = vNewValue
End Property

Public Property Get UserValid() As Boolean
    UserValid = ValidUser
End Property

Public Property Let UserValid(ByVal vNewValue As Boolean)
    ValidUser = vNewValue
End Property
