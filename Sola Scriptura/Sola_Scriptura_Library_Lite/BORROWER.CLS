VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Borrower"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Private BorrowerID As Integer
Private FirstName As String
Private LastName As String
Private BorrowerValid As Boolean
Public Property Get ID() As Integer
    ID = BorrowerID
End Property

Public Property Let ID(ByVal vNewValue As Integer)
    BorrowerID = vNewValue
End Property

Public Property Get FName() As String
    FName = FirstName
End Property

Public Property Let FName(ByVal vNewValue As String)
    FirstName = vNewValue
End Property
Public Property Get LName() As String
    LName = LastName
End Property

Public Property Let LName(ByVal vNewValue As String)
    LastName = vNewValue
End Property

Private Sub Class_Initialize()
    BorrowerValid = False
End Sub

Public Property Get Valid() As Boolean
    Valid = BorrowerValid
End Property

Public Property Let Valid(ByVal vNewValue As Boolean)
    BorrowerValid = vNewValue
End Property
