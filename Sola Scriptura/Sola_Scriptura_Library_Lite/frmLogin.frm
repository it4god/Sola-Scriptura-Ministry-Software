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
   Begin VB.TextBox txtUserName 
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
      Width           =   2000
   End
   Begin VB.TextBox txtPassword 
      Appearance      =   0  'Flat
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
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Charity Edition"
      ForeColor       =   &H8000000E&
      Height          =   240
      Left            =   5640
      TabIndex        =   3
      Top             =   6240
      Width           =   1440
   End
   Begin VB.Image imgWelcome 
      Height          =   3255
      Left            =   360
      Picture         =   "frmLogin.frx":0000
      Top             =   4080
      Width           =   7035
   End
   Begin VB.Image imgLogo 
      Height          =   1050
      Left            =   12000
      Picture         =   "frmLogin.frx":4A82
      Top             =   120
      Width           =   3105
   End
   Begin VB.Image imgLine 
      Height          =   8745
      Left            =   7680
      Picture         =   "frmLogin.frx":5FD6
      Top             =   1440
      Width           =   150
   End
   Begin VB.Image imgTop 
      Height          =   1290
      Left            =   0
      Picture         =   "frmLogin.frx":67C5
      Top             =   0
      Width           =   15360
   End
   Begin VB.Image imgShutDown 
      Height          =   480
      Left            =   120
      Picture         =   "frmLogin.frx":70FD
      Top             =   10560
      Width           =   495
   End
   Begin VB.Image imgLogin 
      Height          =   495
      Left            =   12360
      Picture         =   "frmLogin.frx":7843
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
      Picture         =   "frmLogin.frx":7F9F
      Top             =   10320
      Width           =   15360
   End
   Begin VB.Image imgUserPass 
      Height          =   2115
      Left            =   8040
      Picture         =   "frmLogin.frx":8AAE
      Top             =   4680
      Width           =   7035
   End
End
Attribute VB_Name = "frmLogin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
' Declaring the variables used
Dim user As Recordset
Dim found As Boolean
Dim frm As Form
 


Private Sub cmdClear_Click()
      ' Call function in the module
    txtUserName.SetFocus
End Sub

Private Sub imgHelp_Click()
    MsgBox "Please refer to User Manual provided"
End Sub

Private Sub Form_Load()
txtUserName.Text = "charity"
txtPassword.Text = ""
End Sub

Private Sub imgLogin_Click()
Dim Valid As Boolean
    
      'put the return value from class module to variable
    
    If txtUserName.Text = "charity" And txtPassword.Text = "charity" Then        ' writting the log file to for the logged user
        Open "logfile.txt" For Append As #1
            Print #1, txtUserName.Text & " has logged in on " & Now()
        Close #1
       ' sessionUser = txtUserName.Text
        MDIFrmMain.Show
        Me.Hide
    End If
End Sub

Private Sub imgShutDown_Click()
    Dim ans As String
    ' creating confirmation to the user
    ans = MsgBox("Are you sure you want to quit?", vbQuestion + vbYesNo, "Confirmation")
    If ans = vbYes Then
        For Each frm In Forms
            If frm.Name <> "frmLogin" Then
                Unload frm
            End If
        Next frm
        Unload Me
    End If
End Sub


Private Sub txtPassword_KeyPress(KeyAscii As Integer)
    ' Code for press Enter on the keyboard to login
    If KeyAscii = 13 Then
        imgLogin_Click
    End If
End Sub


