VERSION 5.00
Begin VB.Form frmAdmin 
   Appearance      =   0  'Flat
   AutoRedraw      =   -1  'True
   BackColor       =   &H00DC7F59&
   BorderStyle     =   0  'None
   Caption         =   "AddData"
   ClientHeight    =   9375
   ClientLeft      =   2295
   ClientTop       =   1605
   ClientWidth     =   15360
   ClipControls    =   0   'False
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   6470.791
   ScaleMode       =   0  'User
   ScaleWidth      =   14423.84
   ShowInTaskbar   =   0   'False
   Tag             =   "100"
   Begin VB.Image Image5 
      BorderStyle     =   1  'Fixed Single
      Height          =   6615
      Left            =   5040
      Picture         =   "FrmAdmin.frx":0000
      Stretch         =   -1  'True
      Top             =   840
      Width           =   8655
   End
   Begin VB.Label lblAddUser 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Add / Delete User"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   360
      Left            =   1920
      TabIndex        =   2
      Top             =   2835
      Width           =   1965
   End
   Begin VB.Label lblTitleAspek 
      BackStyle       =   0  'Transparent
      Caption         =   "Admin"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   360
      Left            =   12240
      TabIndex        =   0
      Top             =   480
      Width           =   1845
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   13800
      Picture         =   "FrmAdmin.frx":19567
      Top             =   1920
      Width           =   645
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   13800
      Picture         =   "FrmAdmin.frx":19FA8
      Top             =   1080
      Width           =   645
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   12000
      Picture         =   "FrmAdmin.frx":1A906
      Top             =   360
      Width           =   2805
   End
   Begin VB.Image Image4 
      Height          =   2310
      Left            =   4320
      Picture         =   "FrmAdmin.frx":1B3F0
      Top             =   5280
      Width           =   435
   End
   Begin VB.Label lblChangePassword 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Change Password"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   360
      Left            =   1920
      TabIndex        =   1
      Top             =   1635
      Width           =   1965
   End
   Begin VB.Image ImgChangePassword 
      Height          =   870
      Left            =   840
      Picture         =   "FrmAdmin.frx":1BF0C
      Top             =   1320
      Width           =   3360
   End
   Begin VB.Image Image2 
      Height          =   870
      Left            =   840
      Picture         =   "FrmAdmin.frx":1D546
      Top             =   2520
      Width           =   3360
   End
   Begin VB.Image Image1 
      Height          =   7695
      Left            =   240
      Picture         =   "FrmAdmin.frx":1EB80
      Stretch         =   -1  'True
      Top             =   120
      Width           =   14775
   End
End
Attribute VB_Name = "frmAdmin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

CenterChildForm Me

End Sub


Private Sub ImgChangePassword_Click()
FrmChangePassword.Show
End Sub

Private Sub imgQuit_Click()
Unload Me

End Sub



Private Sub lblAddUser_Click()
If Trim(UserAuthority) = "1" Then
    FrmAddUser.Show
Else
    MsgBox "You are not authorized to use this function !", vbInformation, "Information"
End If
End Sub

Private Sub lblChangePassword_Click()
FrmChangePassword.Show
End Sub
