VERSION 5.00
Begin VB.Form frmBioData 
   Appearance      =   0  'Flat
   AutoRedraw      =   -1  'True
   BackColor       =   &H00DC7F59&
   BorderStyle     =   0  'None
   Caption         =   "About MyApp"
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
   Begin VB.TextBox TxtPassword 
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   5160
      Locked          =   -1  'True
      PasswordChar    =   "*"
      TabIndex        =   14
      Top             =   6000
      Width           =   3195
   End
   Begin VB.ComboBox CboStatus 
      Height          =   315
      ItemData        =   "FrmBioData.frx":0000
      Left            =   10440
      List            =   "FrmBioData.frx":0010
      Locked          =   -1  'True
      TabIndex        =   13
      Top             =   5520
      Width           =   3195
   End
   Begin VB.TextBox TxtIndentity 
      Alignment       =   2  'Center
      BackColor       =   &H80000006&
      ForeColor       =   &H80000005&
      Height          =   495
      Left            =   2880
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   39
      Top             =   360
      Width           =   7987
   End
   Begin VB.ComboBox CboProgram 
      Height          =   315
      ItemData        =   "FrmBioData.frx":0030
      Left            =   5160
      List            =   "FrmBioData.frx":003D
      Locked          =   -1  'True
      TabIndex        =   11
      Top             =   5040
      Width           =   3195
   End
   Begin VB.TextBox TxtPeriode 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   12
      Top             =   5520
      Width           =   3195
   End
   Begin VB.TextBox TxtHP 
      Height          =   285
      Left            =   10440
      Locked          =   -1  'True
      TabIndex        =   5
      Top             =   3600
      Width           =   3195
   End
   Begin VB.TextBox TxtEmail 
      BackColor       =   &H00FFFFFF&
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   6
      Top             =   4080
      Width           =   8475
   End
   Begin VB.TextBox TxtAlamat 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   3
      Top             =   3120
      Width           =   8475
   End
   Begin VB.TextBox TxtNamaAkhir 
      Height          =   285
      Left            =   10440
      Locked          =   -1  'True
      TabIndex        =   2
      Top             =   2640
      Width           =   3195
   End
   Begin VB.TextBox TxtNamaAwal 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   2640
      Width           =   3195
   End
   Begin VB.TextBox TxtNIM 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   0
      Top             =   1800
      Width           =   3195
   End
   Begin VB.TextBox TxtTelepon 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   4
      Top             =   3600
      Width           =   3195
   End
   Begin VB.TextBox TxtTempatLahir 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   7
      Top             =   4560
      Width           =   3195
   End
   Begin VB.ComboBox CboTanggalLahir_Day 
      Height          =   315
      Left            =   10440
      Style           =   2  'Dropdown List
      TabIndex        =   8
      Top             =   4560
      Width           =   855
   End
   Begin VB.ComboBox CboTanggalLahir_Month 
      Height          =   315
      Left            =   11400
      Style           =   2  'Dropdown List
      TabIndex        =   9
      Top             =   4560
      Width           =   855
   End
   Begin VB.ComboBox CboTanggalLahir_Year 
      Height          =   315
      Left            =   12360
      Style           =   2  'Dropdown List
      TabIndex        =   10
      Top             =   4560
      Width           =   1275
   End
   Begin VB.Image Image2 
      Height          =   1575
      Left            =   600
      Picture         =   "FrmBioData.frx":005C
      Stretch         =   -1  'True
      Top             =   5640
      Width           =   1755
   End
   Begin VB.Label lblPassword 
      BackStyle       =   0  'Transparent
      Caption         =   "Password"
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
      Left            =   3360
      TabIndex        =   42
      Top             =   6000
      Width           =   1935
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Status"
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
      Left            =   8640
      TabIndex        =   41
      Top             =   5520
      Width           =   1935
   End
   Begin VB.Label lblPelayanan 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "PELAYANAN"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   40
      Top             =   3840
      Width           =   1605
   End
   Begin VB.Label lblMnuFile 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "FILE"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   38
      Top             =   3120
      Width           =   1605
   End
   Begin VB.Label LblProgram 
      BackStyle       =   0  'Transparent
      Caption         =   "Program"
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
      Left            =   3360
      TabIndex        =   37
      Top             =   5040
      Width           =   1935
   End
   Begin VB.Label LblPeriode 
      BackStyle       =   0  'Transparent
      Caption         =   "Periode Masuk"
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
      Left            =   3360
      TabIndex        =   36
      Top             =   5520
      Width           =   1935
   End
   Begin VB.Label LblHP 
      BackStyle       =   0  'Transparent
      Caption         =   "HP"
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
      Left            =   8640
      TabIndex        =   35
      Top             =   3600
      Width           =   1935
   End
   Begin VB.Label LblEmail 
      BackStyle       =   0  'Transparent
      Caption         =   "Email"
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
      Left            =   3360
      TabIndex        =   34
      Top             =   4080
      Width           =   1935
   End
   Begin VB.Label LblAlamat 
      BackStyle       =   0  'Transparent
      Caption         =   "Alamat"
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
      Left            =   3360
      TabIndex        =   33
      Top             =   3120
      Width           =   1935
   End
   Begin VB.Label LblNamaAkhir 
      BackStyle       =   0  'Transparent
      Caption         =   "Nama Akhir"
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
      Left            =   8640
      TabIndex        =   32
      Top             =   2640
      Width           =   1935
   End
   Begin VB.Label LblNamaAwal 
      BackStyle       =   0  'Transparent
      Caption         =   "Nama Awal"
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
      Left            =   3360
      TabIndex        =   31
      Top             =   2640
      Width           =   1935
   End
   Begin VB.Label lblNIM 
      BackStyle       =   0  'Transparent
      Caption         =   "NIM"
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
      Left            =   3360
      TabIndex        =   30
      Top             =   1800
      Width           =   1935
   End
   Begin VB.Label lblTelepon 
      BackStyle       =   0  'Transparent
      Caption         =   "Telepon"
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
      Left            =   3360
      TabIndex        =   29
      Top             =   3600
      Width           =   1935
   End
   Begin VB.Label LblTempatLahir 
      BackStyle       =   0  'Transparent
      Caption         =   "Tempat Lahir"
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
      Left            =   3360
      TabIndex        =   28
      Top             =   4560
      Width           =   1935
   End
   Begin VB.Label LblTanggalLahir 
      BackStyle       =   0  'Transparent
      Caption         =   "Tanggal Lahir"
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
      Left            =   8640
      TabIndex        =   27
      Top             =   4560
      Width           =   1935
   End
   Begin VB.Line Line1 
      BorderColor     =   &H8000000E&
      X1              =   3042.529
      X2              =   12846.23
      Y1              =   1656.523
      Y2              =   1656.523
   End
   Begin VB.Label lblTitleBioData 
      BackStyle       =   0  'Transparent
      Caption         =   "Bio Data"
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
      Height          =   465
      Left            =   12000
      TabIndex        =   26
      Top             =   600
      Width           =   2685
   End
   Begin VB.Label lblMnuBIOData 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "BIO DATA"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   25
      Top             =   1320
      Width           =   1605
   End
   Begin VB.Label lblMnuKRS 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "KRS"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   24
      Top             =   1680
      Width           =   1605
   End
   Begin VB.Label lblMnuKHS 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "KHS"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   23
      Top             =   2400
      Width           =   1605
   End
   Begin VB.Label lblMnuTrankrip 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "TRANSKRIP"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   22
      Top             =   2760
      Width           =   1605
   End
   Begin VB.Label lblMnuPembayaran 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "PEMBAYARAN"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   21
      Top             =   3480
      Width           =   1605
   End
   Begin VB.Label lblMnuMasukNilai 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "MASUK NILAI"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   20
      Top             =   2040
      Width           =   1605
   End
   Begin VB.Label lblCancel 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Cancel"
      Enabled         =   0   'False
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
      Left            =   13080
      TabIndex        =   18
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Label lblSave 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Save"
      Enabled         =   0   'False
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
      Left            =   10920
      TabIndex        =   17
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Label LblDelete 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Delete"
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
      Left            =   5520
      TabIndex        =   16
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Label lblEdit 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Edit"
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
      Left            =   3360
      TabIndex        =   15
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Image Image5 
      Height          =   495
      Left            =   10920
      Picture         =   "FrmBioData.frx":1241
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   13080
      Picture         =   "FrmBioData.frx":1D35
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image ImgDelete 
      Height          =   495
      Left            =   5520
      Picture         =   "FrmBioData.frx":2829
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image ImgEdit 
      Height          =   495
      Left            =   3360
      Picture         =   "FrmBioData.frx":331D
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmBioData.frx":3E11
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11880
      Picture         =   "FrmBioData.frx":492D
      Top             =   480
      Width           =   2805
   End
   Begin VB.Label LblMyPersonID 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   5160
      TabIndex        =   19
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmBioData.frx":5417
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmBioData.frx":5D75
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmBioData.frx":67B6
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
   Begin VB.Image ImgSuamiIstri 
      Height          =   375
      Left            =   360
      Picture         =   "FrmBioData.frx":679C0
      Stretch         =   -1  'True
      Top             =   3000
      Width           =   2250
   End
   Begin VB.Image ImgAdikKakak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmBioData.frx":6875D
      Stretch         =   -1  'True
      Top             =   2640
      Width           =   2250
   End
   Begin VB.Image ImgPendidikan 
      Height          =   375
      Left            =   360
      Picture         =   "FrmBioData.frx":694FA
      Stretch         =   -1  'True
      Top             =   3720
      Width           =   2250
   End
   Begin VB.Image ImgPrestasi 
      Height          =   375
      Left            =   360
      Picture         =   "FrmBioData.frx":6A297
      Stretch         =   -1  'True
      Top             =   3360
      Width           =   2250
   End
   Begin VB.Image ImgAnak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmBioData.frx":6B034
      Stretch         =   -1  'True
      Top             =   2280
      Width           =   2250
   End
   Begin VB.Image ImgOrangtua 
      Height          =   375
      Left            =   360
      Picture         =   "FrmBioData.frx":6BDD1
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   2250
   End
   Begin VB.Image ImgBioData 
      Height          =   375
      Left            =   360
      Picture         =   "FrmBioData.frx":6CB6E
      Stretch         =   -1  'True
      Top             =   1200
      Width           =   2250
   End
   Begin VB.Image ImgAlamat 
      Height          =   375
      Left            =   360
      Picture         =   "FrmBioData.frx":6D90B
      Stretch         =   -1  'True
      Top             =   1560
      Width           =   2250
   End
   Begin VB.Image ImgChurchData 
      Height          =   495
      Left            =   360
      Picture         =   "FrmBioData.frx":6E6A8
      Stretch         =   -1  'True
      Top             =   7320
      Width           =   2250
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmBioData.frx":6F445
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
End
Attribute VB_Name = "frmBioData"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Dim myitem As ClsItemServer


Private Sub Form_Load()
    CenterChildForm Me
    Dim counter As Long
    For counter = 1 To 31
        CboTanggalLahir_Day.AddItem (counter)
    Next counter
    For counter = 1 To 12
        CboTanggalLahir_Month.AddItem (counter)
    Next counter
    For counter = 1940 To 2200
        CboTanggalLahir_Year.AddItem (counter)
    Next counter
    TxtNIM.Text = Trim(CurrentMahasiswa.NIM)
    TxtNamaAwal.Text = Trim(CurrentMahasiswa.Nama_Awal)
    TxtNamaAkhir.Text = Trim(CurrentMahasiswa.Nama_Akhir)
    TxtAlamat.Text = Trim(CurrentMahasiswa.Alamat)
    TxtTelepon.Text = Trim(CurrentMahasiswa.Telepon)
    TxtHP.Text = Trim(CurrentMahasiswa.HP)
    TxtEmail.Text = Trim(CurrentMahasiswa.Email)
    TxtTempatLahir.Text = Trim(CurrentMahasiswa.TempatLahir)
    CboStatus.Text = Trim(CurrentMahasiswa.Status)
        Dim tgllahir_day As String
        Dim tgllahir_month As String
        Dim tgllahir_year As String
        Dim tgllahir As String
        tgllahir = CurrentMahasiswa.TanggalLahir
        If IsDate((Trim(CurrentMahasiswa.TanggalLahir))) = True Then
            If Left(Mid(Trim(tgllahir), 1, 2), 1) = "0" Then
                tgllahir_day = Mid(Trim(tgllahir), 2, 1)
                
            Else
                tgllahir_day = Mid(Trim(tgllahir), 1, 2)
            End If
            tgllahir = CurrentMahasiswa.TanggalLahir
            If Left(Mid(Trim(tgllahir), 4, 2), 1) = "0" Then
                 tgllahir_month = Mid(Trim(tgllahir), 5, 1)
            Else
                 tgllahir_month = Mid(Trim(tgllahir), 4, 2)
            End If
            tgllahir = CurrentMahasiswa.TanggalLahir
            tgllahir_year = Mid(Trim(CurrentMahasiswa.TanggalLahir), 7, 4)
On Error GoTo a:

            CboTanggalLahir_Day.Text = tgllahir_day
            CboTanggalLahir_Month.Text = tgllahir_month
            CboTanggalLahir_Year.Text = tgllahir_year
a:
    MsgBox "Please change the datetime setting to the Indonesian setting !", vbExclamation, "Warning"
    
    
    
    
    
    
    
    
    
    
b:
        
        End If
        
        CboProgram.Text = Trim(CurrentMahasiswa.Program)
    
    TxtPeriode.Text = Trim(CurrentMahasiswa.PeriodeMasuk)
    TxtPassword.Text = Trim(CurrentMahasiswa.Password)
    DoLock
    TxtIndentity.Text = "NIM = " & Trim(CurrentMahasiswa.NIM) & " , " & Trim(CurrentMahasiswa.Nama_Awal) & " " & Trim(CurrentMahasiswa.Nama_Akhir) & vbCrLf & "Periode : " & strperiode
    
End Sub


Private Sub imgQuit_Click()
Unload Me
End Sub
Private Sub DoLock()
    TxtNIM.Locked = True
    TxtNIM.BackColor = vbWhite
    TxtNamaAwal.Locked = True
    TxtNamaAwal.BackColor = vbWhite
    TxtNamaAkhir.Locked = True
    TxtNamaAkhir.BackColor = vbWhite
    TxtAlamat.Locked = True
    TxtAlamat.BackColor = vbWhite
    TxtTelepon.Locked = True
    TxtTelepon.BackColor = vbWhite
    TxtHP.Locked = True
    TxtHP.BackColor = vbWhite
    TxtEmail.Locked = True
    TxtEmail.BackColor = vbWhite
    TxtTempatLahir.Locked = True
    TxtTempatLahir.BackColor = vbWhite
    CboTanggalLahir_Day.Locked = True
    CboTanggalLahir_Day.BackColor = vbWhite
    CboTanggalLahir_Month.Locked = True
    CboTanggalLahir_Month.BackColor = vbWhite
    CboTanggalLahir_Year.Locked = True
    CboTanggalLahir_Year.BackColor = vbWhite
    CboProgram.Locked = True
    CboProgram.BackColor = vbWhite
    TxtPeriode.Locked = True
    TxtPeriode.BackColor = vbWhite
    CboStatus.Locked = True
    CboStatus.BackColor = vbWhite
    TxtPassword.Locked = True
    TxtPassword.BackColor = vbWhite
End Sub

Private Sub DoUnlock()

    TxtNamaAwal.Locked = False
    TxtNamaAwal.BackColor = vbYellow
    TxtNamaAkhir.Locked = False
    TxtNamaAkhir.BackColor = vbYellow
    TxtAlamat.Locked = False
    TxtAlamat.BackColor = vbYellow
    TxtTelepon.Locked = False
    TxtTelepon.BackColor = vbYellow
    TxtHP.Locked = False
    TxtHP.BackColor = vbYellow
    TxtEmail.Locked = False
    TxtEmail.BackColor = vbYellow
    TxtTempatLahir.Locked = False
    TxtTempatLahir.BackColor = vbYellow
    CboTanggalLahir_Day.Locked = False
    CboTanggalLahir_Day.BackColor = vbYellow
    CboTanggalLahir_Month.Locked = False
    CboTanggalLahir_Month.BackColor = vbYellow
    CboTanggalLahir_Year.Locked = False
    CboTanggalLahir_Year.BackColor = vbYellow
    CboProgram.Locked = False
    CboProgram.BackColor = vbYellow
    TxtPeriode.Locked = False
    TxtPeriode.BackColor = vbYellow
    CboStatus.Locked = False
    CboStatus.BackColor = vbYellow
    TxtPassword.Locked = False
    TxtPassword.BackColor = vbYellow
End Sub

Private Sub lblCancel_Click()
    lblEdit.Enabled = True
    lblDelete.Enabled = True
    lblSave.Enabled = False
    lblCancel.Enabled = False
    DoLock
End Sub

Private Sub lblEdit_Click()
    lblEdit.Enabled = False
    lblDelete.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    DoUnlock
End Sub







Private Sub lblSave_Click()
    lblEdit.Enabled = True
    lblDelete.Enabled = True
    lblSave.Enabled = False
    lblCancel.Enabled = False
    Set myitem = New ClsItemServer
    Dim saveok As Boolean
    LSet CurrentMahasiswaBuffer = CurrentMahasiswa
    saveok = myitem.updatemahasiswa(CurrentMahasiswaBuffer.Buffer, UpdateUser)
    If saveok = True Then
        MsgBox "Update Mahasiswa Data Successfully !", vbInformation, "Data is recorded"
    DoLock
    Else
        MsgBox "Update Mahasiswa Data Unsuccessfully !", vbInformation, "Data is not recorded"
    End If
    
    
End Sub
Private Sub LblDelete_Click()
On Error GoTo deleteerror:
        Set myitem = New ClsItemServer
        
     Dim iresponse As Long
        Dim saskUSER As String
        saskUSER = "Are you sure want to delete Mahasiswa Data with NIM  = " & TxtNIM.Text & " ?"
        iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Delete Mahasiswa Data")
        Dim deleteok As Boolean
        deleteok = False
        If (iresponse = vbYes) Then
            deleteok = myitem.DeleteMahasiswa(Trim(CurrentMahasiswa.NIM))
        End If
        If deleteok = True Then
            Unload Me
            MsgBox "Mahasiswa Data deleted !", vbInformation, "Data Deleted !"
        End If
        Exit Sub
deleteerror:
    MsgBox "Please Delete All Data linked to this person before you delete", vbInformation, "Error !"
End Sub

Private Sub CboProgram_Change()
    CurrentMahasiswa.Program = CboProgram.Text
End Sub
Private Sub CboProgram_Click()
    CurrentMahasiswa.Program = CboProgram.Text
End Sub

Private Sub TxtAlamat_Change()
    CurrentMahasiswa.Alamat = TxtAlamat.Text
End Sub

Private Sub TxtEmail_Change()
    CurrentMahasiswa.Email = TxtEmail.Text
End Sub

Private Sub TxtHP_Change()
    CurrentMahasiswa.HP = TxtHP.Text
End Sub

Private Sub TxtNamaAkhir_Change()
    CurrentMahasiswa.Nama_Akhir = TxtNamaAkhir.Text
End Sub

Private Sub TxtNamaAwal_Change()
    CurrentMahasiswa.Nama_Awal = TxtNamaAwal.Text
End Sub


Private Sub TxtPassword_Change()
    CurrentMahasiswa.Password = TxtPassword.Text
End Sub

Private Sub txtperiode_Change()
    CurrentMahasiswa.PeriodeMasuk = TxtPeriode.Text
End Sub

Private Sub TxtTelepon_Change()
    CurrentMahasiswa.Telepon = TxtTelepon.Text
End Sub

Private Sub TxtTempatLahir_Change()
    CurrentMahasiswa.TempatLahir = TxtTempatLahir.Text
End Sub
Private Sub CboStatus_Change()
CurrentMahasiswa.Status = CboStatus.Text
End Sub

Private Sub CboStatus_Click()
CurrentMahasiswa.Status = CboStatus.Text
End Sub

Private Sub CboTanggalLahir_Day_Click()
       Dim tanggallahir_day As String
    Dim tanggallahir_month As String
    If Len(CboTanggalLahir_Day.Text) = 1 Then
        tanggallahir_day = "0" + CboTanggalLahir_Day.Text
    Else
        tanggallahir_day = CboTanggalLahir_Day.Text
    End If
    If Len(CboTanggalLahir_Month.Text) = 1 Then
        tanggallahir_month = "0" + CboTanggalLahir_Month.Text
    Else
        tanggallahir_month = CboTanggalLahir_Month.Text
        
    End If
    If CboTanggalLahir_Day.Text <> "" And CboTanggalLahir_Month.Text <> "" And CboTanggalLahir_Year.Text <> "" Then
       CurrentMahasiswa.TanggalLahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        CurrentMahasiswa.TanggalLahir = ""
    End If
    
    
End Sub

Private Sub CboTanggalLahir_Month_Click()
        Dim tanggallahir_day As String
    Dim tanggallahir_month As String
    If Len(CboTanggalLahir_Day.Text) = 1 Then
        tanggallahir_day = "0" + CboTanggalLahir_Day.Text
    Else
        tanggallahir_day = CboTanggalLahir_Day.Text
    End If
    If Len(CboTanggalLahir_Month.Text) = 1 Then
        tanggallahir_month = "0" + CboTanggalLahir_Month.Text
    Else
        tanggallahir_month = CboTanggalLahir_Month.Text
        
    End If
        If CboTanggalLahir_Day.Text <> "" And CboTanggalLahir_Month.Text <> "" And CboTanggalLahir_Year.Text <> "" Then
       CurrentMahasiswa.TanggalLahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        CurrentMahasiswa.TanggalLahir = ""
    End If
End Sub

Private Sub CboTanggalLahir_Year_Click()
       Dim tanggallahir_day As String
    Dim tanggallahir_month As String
    If Len(CboTanggalLahir_Day.Text) = 1 Then
        tanggallahir_day = "0" + CboTanggalLahir_Day.Text
    Else
        tanggallahir_day = CboTanggalLahir_Day.Text
    End If
    If Len(CboTanggalLahir_Month.Text) = 1 Then
        tanggallahir_month = "0" + CboTanggalLahir_Month.Text
    Else
        tanggallahir_month = CboTanggalLahir_Month.Text
        
    End If
        If CboTanggalLahir_Day.Text <> "" And CboTanggalLahir_Month.Text <> "" And CboTanggalLahir_Year.Text <> "" Then
       CurrentMahasiswa.TanggalLahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        CurrentMahasiswa.TanggalLahir = ""
    End If
End Sub


Private Sub lblMnuBIOData_Click()
    Unload Me
    frmBioData.Show
End Sub

Private Sub lblMnuKHS_Click()
    Unload Me
    frmKHS.Show
End Sub

Private Sub lblMnuKRS_Click()
    Unload Me
    frmKRS.Show
End Sub
Private Sub lblMnuMasukNilai_Click()
    Unload Me
    frmMasukNilai.Show
End Sub
Private Sub lblMnuTrankrip_Click()
    Unload Me
    frmTranskrip.Show
End Sub
Private Sub lblMnuFile_Click()
    Unload Me
    frmFile.Show
End Sub
Private Sub lblMnuPembayaran_Click()
    Unload Me
    frmPembayaran.Show
End Sub
Private Sub lblPelayanan_Click()
    Unload Me
    frmPelayanan.Show
End Sub
