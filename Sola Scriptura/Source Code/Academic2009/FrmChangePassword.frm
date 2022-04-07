VERSION 5.00
Begin VB.Form FrmChangePassword 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00DC7F59&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Change Password"
   ClientHeight    =   3570
   ClientLeft      =   -135
   ClientTop       =   330
   ClientWidth     =   7710
   FillColor       =   &H00808080&
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   3570
   ScaleWidth      =   7710
   Tag             =   "100"
   Begin VB.TextBox TxtUserName 
      Height          =   285
      Left            =   3120
      TabIndex        =   1
      Top             =   840
      Width           =   3195
   End
   Begin VB.TextBox TxtConfirmPassword 
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   3120
      PasswordChar    =   "*"
      TabIndex        =   4
      Top             =   2280
      Width           =   3195
   End
   Begin VB.TextBox TxtOldPassword 
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   3120
      PasswordChar    =   "*"
      TabIndex        =   2
      Top             =   1320
      Width           =   3195
   End
   Begin VB.TextBox TxtNewPassword 
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   3120
      PasswordChar    =   "*"
      TabIndex        =   3
      Top             =   1800
      Width           =   3195
   End
   Begin VB.Label lblChange 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Change"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   360
      Left            =   3240
      TabIndex        =   8
      Top             =   2880
      Width           =   1965
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "User Name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1320
      TabIndex        =   0
      Top             =   840
      Width           =   1935
   End
   Begin VB.Label lblTelepon 
      BackStyle       =   0  'Transparent
      Caption         =   "Confirm Password"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1320
      TabIndex        =   7
      Top             =   2280
      Width           =   1935
   End
   Begin VB.Label LblNamaAwal 
      BackStyle       =   0  'Transparent
      Caption         =   "Old Password"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1320
      TabIndex        =   6
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Label LblAlamat 
      BackStyle       =   0  'Transparent
      Caption         =   "New Password"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1320
      TabIndex        =   5
      Top             =   1800
      Width           =   1935
   End
   Begin VB.Image Image1 
      Height          =   3540
      Left            =   120
      Picture         =   "FrmChangePassword.frx":0000
      Stretch         =   -1  'True
      Top             =   0
      Width           =   840
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   6720
      Picture         =   "FrmChangePassword.frx":6120A
      Top             =   1320
      Width           =   645
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   6720
      Picture         =   "FrmChangePassword.frx":61C4B
      Top             =   600
      Width           =   645
   End
   Begin VB.Image ImgEdit 
      Height          =   495
      Left            =   3240
      Picture         =   "FrmChangePassword.frx":625A9
      Top             =   2760
      Width           =   1980
   End
   Begin VB.Image Img1 
      Height          =   3540
      Left            =   960
      Picture         =   "FrmChangePassword.frx":6309D
      Stretch         =   -1  'True
      Top             =   0
      Width           =   6720
   End
End
Attribute VB_Name = "FrmChangePassword"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim mylogin As ClsLogin


Private Sub Form_Load()
CenterChildForm2 Me
End Sub


Private Sub imgQuit_Click()
Unload Me
End Sub

Private Sub lblChange_Click()
If TxtUserName.Text <> UpdateUser Then
    MsgBox "Please enter the correct User Name !", vbInformation, "Information"
ElseIf TxtOldPassword.Text <> PasswordUser Then
    MsgBox "The Old Password is not correct !", vbInformation, "Information"
ElseIf TxtNewPassword.Text <> TxtConfirmPassword.Text Then
    MsgBox "The New Password do not match with the Confirm Password !", vbInformation, "Information"
ElseIf Len(TxtNewPassword.Text) > 10 Then
    MsgBox "Password is too long !", vbInformation, "Information"
ElseIf Len(TxtNewPassword.Text) < 4 Then
    MsgBox "Password is too short !", vbInformation, "Information"
Else
    Set mylogin = New ClsLogin
    Dim saveok As Boolean
    saveok = mylogin.ChangePassword(TxtUserName.Text, TxtNewPassword.Text)
    If saveok = True Then
        MsgBox "Password Changed !", vbInformation, "Information"
        PasswordUser = TxtNewPassword.Text
        Unload Me
    Else
        MsgBox "Save failed !", vbInformation, "Information"
    End If
End If

End Sub
