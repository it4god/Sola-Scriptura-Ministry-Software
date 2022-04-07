VERSION 5.00
Begin VB.Form frmMasukData 
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
      Left            =   4920
      Picture         =   "FrmMasukData.frx":0000
      Stretch         =   -1  'True
      Top             =   840
      Width           =   8835
   End
   Begin VB.Label lblAddDosen 
      BackStyle       =   0  'Transparent
      Caption         =   "Add Dosen"
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
      Left            =   2400
      TabIndex        =   1
      Top             =   2700
      Width           =   1845
   End
   Begin VB.Image Image2 
      Height          =   870
      Left            =   1200
      Picture         =   "FrmMasukData.frx":19567
      Top             =   2400
      Width           =   3360
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   13800
      Picture         =   "FrmMasukData.frx":1ABE6
      Top             =   1920
      Width           =   645
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   13800
      Picture         =   "FrmMasukData.frx":1B627
      Top             =   1080
      Width           =   645
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   12000
      Picture         =   "FrmMasukData.frx":1BF85
      Top             =   360
      Width           =   2805
   End
   Begin VB.Image Image4 
      Height          =   2310
      Left            =   4320
      Picture         =   "FrmMasukData.frx":1CA6F
      Top             =   5280
      Width           =   435
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   480
      Picture         =   "FrmMasukData.frx":1D58B
      Top             =   2160
      Width           =   435
   End
   Begin VB.Label lblAddMahasiswa 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Add Mahasiswa"
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
      Left            =   2160
      TabIndex        =   0
      Top             =   1590
      Width           =   1965
   End
   Begin VB.Image ImgAddNewBioData 
      Height          =   870
      Left            =   1200
      Picture         =   "FrmMasukData.frx":1E0A7
      Top             =   1320
      Width           =   3360
   End
   Begin VB.Image Image1 
      Height          =   7695
      Left            =   240
      Picture         =   "FrmMasukData.frx":1F726
      Stretch         =   -1  'True
      Top             =   120
      Width           =   14775
   End
End
Attribute VB_Name = "frmMasukData"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

CenterChildForm Me

End Sub

Private Sub imgQuit_Click()
Unload Me

End Sub

Private Sub lblAddDosen_Click()
FrmAddDosen.Show
End Sub

Private Sub lblAddMahasiswa_Click()
    frmAddMahasiswa.Show
End Sub
