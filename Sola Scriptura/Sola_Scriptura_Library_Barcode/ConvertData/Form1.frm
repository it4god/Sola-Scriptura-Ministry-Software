VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   4830
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7095
   LinkTopic       =   "Form1"
   ScaleHeight     =   4830
   ScaleWidth      =   7095
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command2 
      Caption         =   "Get Publish Year"
      Height          =   855
      Left            =   2040
      TabIndex        =   1
      Top             =   2280
      Width           =   2415
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Get Publish Year"
      Height          =   855
      Left            =   2040
      TabIndex        =   0
      Top             =   1080
      Width           =   2415
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim myrecordset As ADODB.Recordset
Dim myrecordset2 As ADODB.Recordset

Private Sub Command1_Click()
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT BookCode From Book WHERE BookCode NOT IN (SELECT BookCode From BookExemplar)"
    rs.Open strSQL, cn
    If Not rs.EOF Then rs.MoveFirst
    Dim publishername As String
    Dim publishercode As String
    Dim i As Long
    Dim x As Long
    i = 0
    Dim authorcode As String
    While Not rs.EOF
    Dim rs2 As ADODB.Recordset
    Set rs2 = New ADODB.Recordset

    Set rs2 = New ADODB.Recordset
    strSQL = "SELECT * From BookExemplar WHERE BookCode = 'AA'"
    rs2.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    
    rs2.AddNew
    rs2.Fields("CopyNo") = 1
    rs2.Fields("BookCode") = CStr(Trim(rs.Fields(0).Value))
    rs2.Update
    rs.MoveNext
    Wend
End Sub

Private Sub Command2_Click()
    Dim rs As ADODB.Recordset
    Set rs = New ADODB.Recordset
    Dim strSQL As String
    strSQL = "SELECT FirstName From Author WHERE FirstName LIKE '%''''%'"
    rs.Open strSQL, cn, adOpenDynamic, adLockOptimistic
    If Not rs.EOF Then rs.MoveFirst
    
    While Not rs.EOF
    rs.Fields(0) = Replace(Trim(rs.Fields(0).Value), "''", "'")
    rs.Update
        rs.MoveNext
    Wend
End Sub

Private Sub Form_Load()
ConnectNow
End Sub
