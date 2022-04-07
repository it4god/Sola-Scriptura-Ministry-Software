VERSION 5.00
Begin VB.Form frmAspek 
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
   Begin VB.Image Image3 
      Height          =   1725
      Left            =   720
      Picture         =   "FrmAspek.frx":0000
      Top             =   1560
      Width           =   3735
   End
   Begin VB.Label LblBiaya 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Biaya"
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
      Left            =   10080
      TabIndex        =   7
      Top             =   2955
      Width           =   2205
   End
   Begin VB.Label lblAbsensi 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Absensi"
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
      Left            =   6120
      TabIndex        =   6
      Top             =   6195
      Width           =   2265
   End
   Begin VB.Label lblDaftarNilai 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Daftar Nilai"
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
      Left            =   10080
      TabIndex        =   5
      Top             =   1875
      Width           =   2565
   End
   Begin VB.Label lbllistMatakuliah 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "List Matakuliah"
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
      Left            =   6240
      TabIndex        =   4
      Top             =   5115
      Width           =   2265
   End
   Begin VB.Label lblMasukanNilai 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Masukan Nilai"
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
      Left            =   6000
      TabIndex        =   3
      Top             =   4050
      Width           =   2565
   End
   Begin VB.Label lblMatakuliahPerSem 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Mata kuliah Per Sem"
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
      Left            =   6240
      TabIndex        =   2
      Top             =   2955
      Width           =   2205
   End
   Begin VB.Label lblTitleAspek 
      BackStyle       =   0  'Transparent
      Caption         =   "Aspek"
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
      Picture         =   "FrmAspek.frx":2092
      Top             =   1920
      Width           =   645
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   13800
      Picture         =   "FrmAspek.frx":2AD3
      Top             =   1080
      Width           =   645
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   12000
      Picture         =   "FrmAspek.frx":3431
      Top             =   360
      Width           =   2805
   End
   Begin VB.Image Image4 
      Height          =   2310
      Left            =   4320
      Picture         =   "FrmAspek.frx":3F1B
      Top             =   5280
      Width           =   435
   End
   Begin VB.Label lblMatakuliah 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Mata kuliah"
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
      Left            =   6240
      TabIndex        =   1
      Top             =   1875
      Width           =   1965
   End
   Begin VB.Image ImgMataKuliah 
      Height          =   870
      Left            =   5160
      Picture         =   "FrmAspek.frx":4A37
      Top             =   1560
      Width           =   3360
   End
   Begin VB.Image ImgMataKuliahPerSem 
      Height          =   870
      Left            =   5160
      Picture         =   "FrmAspek.frx":6071
      Top             =   2640
      Width           =   3360
   End
   Begin VB.Image ImgMasukNilai 
      Height          =   870
      Left            =   5160
      Picture         =   "FrmAspek.frx":76AB
      Top             =   3720
      Width           =   3360
   End
   Begin VB.Image ImgListMataKuliah 
      Height          =   870
      Left            =   5160
      Picture         =   "FrmAspek.frx":8CE5
      Top             =   4800
      Width           =   3360
   End
   Begin VB.Image ImgDaftarNilai 
      Height          =   870
      Left            =   9240
      Picture         =   "FrmAspek.frx":A31F
      Top             =   1560
      Width           =   3360
   End
   Begin VB.Image ImgAbsensi 
      Height          =   870
      Left            =   5160
      Picture         =   "FrmAspek.frx":B959
      Top             =   5880
      Width           =   3360
   End
   Begin VB.Image ImgBiaya 
      Height          =   870
      Left            =   9240
      Picture         =   "FrmAspek.frx":CF93
      Top             =   2640
      Width           =   3360
   End
   Begin VB.Image Image1 
      Height          =   7695
      Left            =   360
      Picture         =   "FrmAspek.frx":E5CD
      Stretch         =   -1  'True
      Top             =   120
      Width           =   14775
   End
End
Attribute VB_Name = "frmAspek"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

CenterChildForm Me

End Sub

Private Sub ImgAbsensi_Click()
frmAbsensi.Show
End Sub

Private Sub ImgBiaya_Click()
frmBiaya.Show
End Sub

Private Sub ImgDaftarNilai_Click()
frmDaftarNilai.Show
End Sub

Private Sub ImgListMataKuliah_Click()
frmListMataKuliah.Show
End Sub

Private Sub ImgMasukNilai_Click()
frmMasukNilaiPerMK.Show
End Sub

Private Sub ImgMataKuliah_Click()
frmMataKuliah.Show
End Sub

Private Sub ImgMataKuliahPerSem_Click()
frmMataKuliahPerSem.Show
End Sub

Private Sub imgQuit_Click()
Unload Me

End Sub



Private Sub lblAbsensi_Click()
frmAbsensi.Show
End Sub

Private Sub LblBiaya_Click()
frmBiaya.Show
End Sub

Private Sub lblDaftarNilai_Click()
frmDaftarNilai.Show
End Sub

Private Sub lbllistMatakuliah_Click()
frmListMataKuliah.Show
End Sub

Private Sub lblMasukanNilai_Click()
frmMasukNilaiPerMK.Show
End Sub

Private Sub lblMatakuliah_Click()
frmMataKuliah.Show
End Sub

Private Sub lblMatakuliahPeriode_Click()
frmMataKuliahPerSem.Show
End Sub

Private Sub lblMatakuliahPerSem_Click()
frmMataKuliahPerSem.Show
End Sub
