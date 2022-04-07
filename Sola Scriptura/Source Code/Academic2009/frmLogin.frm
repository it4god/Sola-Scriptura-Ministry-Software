VERSION 5.00
Begin VB.Form frmLogin 
   BackColor       =   &H00DC7F59&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Login Form"
   ClientHeight    =   11520
   ClientLeft      =   105
   ClientTop       =   780
   ClientWidth     =   15240
   BeginProperty Font 
      Name            =   "Verdana"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   11520
   ScaleWidth      =   15240
   StartUpPosition =   2  'CenterScreen
   Tag             =   "100"
   Begin VB.TextBox txtName 
      Appearance      =   0  'Flat
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      IMEMode         =   3  'DISABLE
      Left            =   9720
      TabIndex        =   2
      Top             =   5880
      Width           =   2115
   End
   Begin VB.TextBox txtPassword 
      Appearance      =   0  'Flat
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      IMEMode         =   3  'DISABLE
      Left            =   9720
      PasswordChar    =   "*"
      TabIndex        =   1
      Top             =   6360
      Width           =   2175
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Academic"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   270
      Left            =   5040
      TabIndex        =   4
      Top             =   6000
      Width           =   1170
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Charity Edition"
      ForeColor       =   &H8000000E&
      Height          =   240
      Left            =   5880
      TabIndex        =   3
      Top             =   6240
      Width           =   1440
   End
   Begin VB.Image Image2 
      Appearance      =   0  'Flat
      Height          =   3255
      Left            =   480
      Picture         =   "frmLogin.frx":0000
      Top             =   4080
      Width           =   7035
   End
   Begin VB.Image imgLine 
      Height          =   8745
      Left            =   7680
      Picture         =   "frmLogin.frx":47C0
      Top             =   1440
      Width           =   150
   End
   Begin VB.Image imgTop 
      Height          =   1290
      Left            =   0
      Picture         =   "frmLogin.frx":4FAF
      Top             =   0
      Width           =   15360
   End
   Begin VB.Image imgShutDown 
      Height          =   480
      Left            =   120
      Picture         =   "frmLogin.frx":58E7
      Top             =   10560
      Width           =   495
   End
   Begin VB.Image imgLogin 
      Height          =   495
      Left            =   12360
      Picture         =   "frmLogin.frx":602D
      Top             =   6120
      Width           =   465
   End
   Begin VB.Label lblInstruction 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Type your username and password"
      ForeColor       =   &H8000000E&
      Height          =   240
      Left            =   9600
      TabIndex        =   0
      Top             =   5280
      Width           =   3465
   End
   Begin VB.Image imgBottom 
      Height          =   1275
      Left            =   0
      Picture         =   "frmLogin.frx":6789
      Top             =   10320
      Width           =   15360
   End
   Begin VB.Image imgUserPass 
      Height          =   2115
      Left            =   8040
      Picture         =   "frmLogin.frx":7298
      Top             =   4680
      Width           =   7035
   End
End
Attribute VB_Name = "frmLogin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim mylogin As ClsLogin

Dim strSQL As String
Dim errorCounter As Long
Private Declare Function GetShortPathName Lib "kernel32" Alias "GetShortPathNameA" (ByVal lpszLongPath As String, ByVal lpszShortPath As String, ByVal cchBuffer As Long) As Long
'Declaration for the winmm dll
Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long
    Dim FileName As String
    Dim Paused As Boolean

Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Long, ByVal uParam As Long, lpvParam As Any, ByVal fuWinIni As Long) As Long
Private Declare Function FindWindow Lib _
                "user32" Alias "FindWindowA" _
                (ByVal lpClassName As String, _
                ByVal lpWindowName As String) As Long

Private Declare Function SetWindowPos Lib "user32" _
                (ByVal hwnd As Long, _
                ByVal hWndInsertAfter As Long, _
                ByVal x As Long, ByVal y As Long, _
                ByVal cx As Long, ByVal cy As Long, _
                ByVal wFlags As Long) As Long





Private Sub Form_Load()
    ConnectNow
     Stop_Click
     Play_Click

txtName.Text = "charity"

    errorCounter = 0
Dim lReturn  As Long
Dim lBool As Long
End Sub

Private Sub imgLogin_Click()
On Error GoTo loginerror:


If txtName.Text = "charity" And TxtPassword.Text = "charity" Then
    MsgBox "Welcome to Sola Scriptura Academic Program Charity Edition Version 1.0 ", vbOKOnly, "User Identified"
    frmLogin.Hide
    loginOK = True
    UpdateUser = Trim(UserName)
    PasswordUser = UserPassword
    MDIfrmMenu.Show
    Stop_Click

Else
    MsgBox "Wrong UserName and Password !", vbExclamation, "User not Identified"
    errorCounter = errorCounter + 1
    If errorCounter = 3 Then
        MsgBox "Three times Login Error !", vbExclamation, "End Program"
        ShutDownWindows
    End If
End If
Exit Sub
loginerror:

End Sub

Private Sub imgShutDown_Click()
    Dim ans As String
    ans = MsgBox("Are you sure you want to quit?", vbQuestion + vbYesNo, "Confirmation")
    If ans = vbYes Then
        For Each frm In Forms
            If frm.Name <> "frmLogin" Then
                Unload frm
            End If
        Next frm
        Unload Me
        Stop_Click
    End If
End Sub

Private Sub TxtName_Change()
UserName = txtName
End Sub
Private Sub TxtPassword_Change()
UserPassword = TxtPassword
End Sub
Private Sub txtPassword_KeyPress(KeyAscii As Integer)
    If KeyAscii = 13 Then
        imgLogin_Click
    End If
End Sub
Private Function Play_MM()

    mciSendString "Close MM", 0, 0, 0
    mciSendString "Open " & FileName & " Alias MM", 0, 0, 0
    mciSendString "Play MM", 0, 0, 0
End Function


Private Function Pause_MM()


    If Paused = False Then
        mciSendString "Pause MM", 0, 0, 0
        Paused = True
    Else
        mciSendString "Play MM", 0, 0, 0
        Paused = False
    End If
End Function


Private Function Stop_MM()
    mciSendString "Stop MM", 0, 0, 0
    mciSendString "Close MM", 0, 0, 0
End Function

Private Sub Next_Click()
    On Error Resume Next
    Stop_MM
    If Text2.Text <> "" Then Name List1.List(0) As Text2.Text & "\" & GetFileName(List1.List(0))
    List1.RemoveItem (0)
    Play_Click
End Sub

Private Sub Play_Click()
    
    'FileName = "C:\GIIHokImTongCOM\Music\Choral.wma"
    If InStr(1, FileName, " ") > 0 Then FileName = Short_Name(FileName)
    'Play_MM
End Sub

Private Sub Stop_Click()
    Stop_MM
End Sub

Private Function GetFileName(File As String) As String
    Dim temp
    temp = File
    temp = StrReverse(temp)
    temp = Left(temp, InStr(1, temp, "\") - 1)
    temp = StrReverse(temp)
    GetFileName = temp

End Function

Public Function Short_Name(Long_Path As String) As String
    'Returns short pathname of the passed lo
    '     ng pathname
    Dim Short_Path As String
    Dim PathLength As Long
    Short_Path = Space(250)
    PathLength = GetShortPathName(Long_Path, Short_Path, Len(Short_Path))


    If PathLength Then
        Short_Name = Left$(Short_Path, PathLength)
        
    End If
End Function



