VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form FrmSearchPeople 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00DC7F59&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "SearchPeople"
   ClientHeight    =   7860
   ClientLeft      =   -135
   ClientTop       =   330
   ClientWidth     =   12045
   FillColor       =   &H00808080&
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   7860
   ScaleWidth      =   12045
   Tag             =   "100"
   Begin VB.ComboBox CboTanggalLahirBaru_Year 
      Height          =   315
      Left            =   7080
      Style           =   2  'Dropdown List
      TabIndex        =   41
      Top             =   3840
      Width           =   3000
   End
   Begin VB.ComboBox CboStatusNonAktif 
      Height          =   315
      ItemData        =   "FrmSeachMahasiswa.frx":0000
      Left            =   7080
      List            =   "FrmSeachMahasiswa.frx":0013
      Style           =   2  'Dropdown List
      TabIndex        =   40
      Top             =   4320
      Width           =   3000
   End
   Begin VB.ComboBox CboLahirBaru 
      Height          =   315
      ItemData        =   "FrmSeachMahasiswa.frx":005E
      Left            =   7080
      List            =   "FrmSeachMahasiswa.frx":006B
      Style           =   2  'Dropdown List
      TabIndex        =   39
      Top             =   3360
      Width           =   3000
   End
   Begin VB.ComboBox CboJenisKelamin 
      Height          =   315
      ItemData        =   "FrmSeachMahasiswa.frx":0077
      Left            =   2280
      List            =   "FrmSeachMahasiswa.frx":0079
      Style           =   2  'Dropdown List
      TabIndex        =   3
      Top             =   1920
      Width           =   1815
   End
   Begin VB.ComboBox CboGolonganDarah 
      Height          =   315
      ItemData        =   "FrmSeachMahasiswa.frx":007B
      Left            =   7080
      List            =   "FrmSeachMahasiswa.frx":007D
      Style           =   2  'Dropdown List
      TabIndex        =   4
      Top             =   1920
      Width           =   975
   End
   Begin VB.TextBox TxtHP 
      Height          =   285
      Left            =   7080
      TabIndex        =   27
      Top             =   3420
      Width           =   3000
   End
   Begin MSDataGridLib.DataGrid DataGridSearchPeople 
      Height          =   2895
      Left            =   720
      TabIndex        =   17
      Top             =   4920
      Width           =   9855
      _ExtentX        =   17383
      _ExtentY        =   5106
      _Version        =   393216
      HeadLines       =   1
      RowHeight       =   15
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ColumnCount     =   2
      BeginProperty Column00 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   1
            Format          =   "dd/MM/yy"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1057
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column01 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1057
            SubFormatType   =   0
         EndProperty
      EndProperty
      SplitCount      =   1
      BeginProperty Split0 
         BeginProperty Column00 
         EndProperty
         BeginProperty Column01 
         EndProperty
      EndProperty
   End
   Begin VB.TextBox TxtPersonID 
      Height          =   285
      Left            =   2160
      TabIndex        =   1
      Top             =   240
      Width           =   2895
   End
   Begin VB.TextBox TxtNamaLengkap 
      Height          =   285
      Left            =   2160
      TabIndex        =   11
      Top             =   720
      Width           =   2895
   End
   Begin VB.TextBox TxtNamaMandarin 
      Height          =   285
      Left            =   6960
      TabIndex        =   2
      Top             =   240
      Width           =   3255
   End
   Begin VB.TextBox TxtNamaPanggilan 
      Height          =   285
      Left            =   6960
      TabIndex        =   12
      Top             =   720
      Width           =   3255
   End
   Begin VB.TextBox TxtGereja 
      Height          =   285
      Left            =   2280
      TabIndex        =   10
      Top             =   1920
      Visible         =   0   'False
      Width           =   3000
   End
   Begin VB.ComboBox CboStatusKeanggotaan 
      Height          =   315
      ItemData        =   "FrmSeachMahasiswa.frx":007F
      Left            =   2280
      List            =   "FrmSeachMahasiswa.frx":008C
      Style           =   2  'Dropdown List
      TabIndex        =   45
      Top             =   4320
      Width           =   3000
   End
   Begin VB.ComboBox CboWilayahID 
      Height          =   315
      Left            =   2280
      Style           =   2  'Dropdown List
      TabIndex        =   80
      Top             =   3840
      Visible         =   0   'False
      Width           =   3000
   End
   Begin VB.TextBox TxtKebaktianNo 
      Height          =   285
      Left            =   2280
      TabIndex        =   47
      Top             =   3360
      Width           =   3000
   End
   Begin VB.TextBox TxtEmail 
      BackColor       =   &H00FFFFFF&
      Height          =   285
      Left            =   2280
      TabIndex        =   28
      Top             =   3420
      Width           =   3000
   End
   Begin VB.ComboBox CboAgama 
      Height          =   315
      ItemData        =   "FrmSeachMahasiswa.frx":00A3
      Left            =   2280
      List            =   "FrmSeachMahasiswa.frx":00B9
      Style           =   2  'Dropdown List
      TabIndex        =   9
      Top             =   2880
      Width           =   3000
   End
   Begin VB.TextBox TxtKodePos 
      Height          =   285
      Left            =   2280
      TabIndex        =   64
      Top             =   2880
      Width           =   3000
   End
   Begin VB.TextBox TxtTelp 
      Height          =   285
      Left            =   2280
      TabIndex        =   65
      Top             =   3360
      Width           =   3000
   End
   Begin VB.TextBox TxtKota 
      Height          =   285
      Left            =   7080
      TabIndex        =   68
      Top             =   2880
      Width           =   3000
   End
   Begin VB.ComboBox CboTanggalLahir_Year 
      Height          =   315
      Left            =   9000
      Style           =   2  'Dropdown List
      TabIndex        =   8
      Top             =   2400
      Width           =   1335
   End
   Begin VB.ComboBox CboTanggalLahir_Month 
      Height          =   315
      Left            =   8040
      Style           =   2  'Dropdown List
      TabIndex        =   7
      Top             =   2400
      Width           =   855
   End
   Begin VB.ComboBox CboTanggalLahir_Day 
      Height          =   315
      Left            =   7080
      Style           =   2  'Dropdown List
      TabIndex        =   6
      Top             =   2400
      Width           =   855
   End
   Begin VB.TextBox TxtRW 
      Height          =   285
      Left            =   7080
      TabIndex        =   63
      Top             =   2400
      Width           =   3000
   End
   Begin VB.TextBox TxtNoAnggota 
      Height          =   285
      Left            =   7080
      TabIndex        =   48
      Top             =   2400
      Width           =   3000
   End
   Begin VB.TextBox TxtTempatLahir 
      Height          =   285
      Left            =   2280
      TabIndex        =   5
      Top             =   2400
      Width           =   3000
   End
   Begin VB.TextBox TxtAlamat 
      Height          =   285
      Left            =   2280
      TabIndex        =   61
      Top             =   1920
      Width           =   7815
   End
   Begin VB.TextBox TxtNoAnggota2 
      Height          =   285
      Left            =   7080
      TabIndex        =   82
      Top             =   4320
      Width           =   3000
   End
   Begin VB.TextBox TxtDilayaniOleh 
      Height          =   285
      Left            =   2280
      TabIndex        =   46
      Top             =   3840
      Width           =   3000
   End
   Begin VB.TextBox TxtFax 
      BackColor       =   &H00FFFFFF&
      Height          =   285
      Left            =   2280
      TabIndex        =   26
      Top             =   3900
      Width           =   3000
   End
   Begin VB.TextBox TxtNoRemaja 
      Height          =   285
      Left            =   7080
      TabIndex        =   43
      Top             =   2880
      Width           =   3000
   End
   Begin VB.TextBox TxtWarganegara 
      Height          =   285
      Left            =   7080
      TabIndex        =   29
      Top             =   2940
      Width           =   3000
   End
   Begin VB.TextBox TxtNoKAA 
      Height          =   285
      Left            =   2280
      TabIndex        =   44
      Top             =   2880
      Width           =   3000
   End
   Begin VB.TextBox TxtRT 
      Height          =   285
      Left            =   2280
      TabIndex        =   62
      Top             =   2400
      Width           =   3000
   End
   Begin VB.TextBox TxtNoSimpatisan 
      Height          =   285
      Left            =   2280
      TabIndex        =   42
      Top             =   2400
      Width           =   3000
   End
   Begin VB.ComboBox CboStatusAlamat 
      Height          =   315
      Left            =   7080
      Style           =   2  'Dropdown List
      TabIndex        =   66
      Top             =   3360
      Width           =   3000
   End
   Begin VB.TextBox TxtNoAnggotaTamu 
      Height          =   285
      Left            =   7080
      TabIndex        =   49
      Top             =   1920
      Width           =   3000
   End
   Begin VB.ComboBox CboDaerahID 
      Height          =   315
      Left            =   7080
      TabIndex        =   67
      Top             =   3840
      Width           =   3000
   End
   Begin VB.Label LblNoAnggota2 
      BackStyle       =   0  'Transparent
      Caption         =   "No. Anggota"
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
      Left            =   5400
      TabIndex        =   83
      Top             =   4320
      Width           =   1935
   End
   Begin VB.Label lblAddBioData 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Add BIO Data"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   435
      Left            =   11040
      TabIndex        =   81
      Top             =   5520
      Width           =   645
   End
   Begin VB.Label lblGereja 
      BackStyle       =   0  'Transparent
      Caption         =   "Gereja"
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
      Left            =   480
      TabIndex        =   78
      Top             =   1920
      Visible         =   0   'False
      Width           =   1935
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   11040
      Picture         =   "FrmSeachMahasiswa.frx":00E9
      Top             =   960
      Width           =   645
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   11040
      Picture         =   "FrmSeachMahasiswa.frx":0B2A
      Top             =   120
      Width           =   645
   End
   Begin VB.Label LblKota 
      BackStyle       =   0  'Transparent
      Caption         =   "Kota"
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
      Left            =   5400
      TabIndex        =   77
      Top             =   2880
      Width           =   1935
   End
   Begin VB.Label LblDaerahID 
      BackStyle       =   0  'Transparent
      Caption         =   "Daerah ID"
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
      Left            =   5400
      TabIndex        =   76
      Top             =   3840
      Width           =   1935
   End
   Begin VB.Label LblWilayahID 
      BackStyle       =   0  'Transparent
      Caption         =   "Wilayah ID"
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
      Left            =   480
      TabIndex        =   75
      Top             =   3840
      Width           =   1935
   End
   Begin VB.Label LblStatusAlamat 
      BackStyle       =   0  'Transparent
      Caption         =   "Status Alamat"
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
      Left            =   5400
      TabIndex        =   74
      Top             =   3360
      Width           =   1935
   End
   Begin VB.Label LblTelp 
      BackStyle       =   0  'Transparent
      Caption         =   "Telp"
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
      Left            =   480
      TabIndex        =   73
      Top             =   3360
      Width           =   1935
   End
   Begin VB.Label LblKodePos 
      BackStyle       =   0  'Transparent
      Caption         =   "Kode Pos"
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
      Left            =   480
      TabIndex        =   72
      Top             =   2880
      Width           =   1935
   End
   Begin VB.Label LblRT 
      BackStyle       =   0  'Transparent
      Caption         =   "RT"
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
      Left            =   480
      TabIndex        =   70
      Top             =   2400
      Width           =   1935
   End
   Begin VB.Label lblNoAnggotaTamu 
      BackStyle       =   0  'Transparent
      Caption         =   "No Anggota tamu"
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
      Left            =   5400
      TabIndex        =   60
      Top             =   1920
      Width           =   1935
   End
   Begin VB.Label LblKebaktianNo 
      BackStyle       =   0  'Transparent
      Caption         =   "Kebaktian No"
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
      Left            =   480
      TabIndex        =   59
      Top             =   3360
      Width           =   1935
   End
   Begin VB.Label LblLahirBaru 
      BackStyle       =   0  'Transparent
      Caption         =   "Lahir Baru"
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
      Left            =   5400
      TabIndex        =   58
      Top             =   3360
      Width           =   1935
   End
   Begin VB.Label LblTanggalLahirBaru 
      BackStyle       =   0  'Transparent
      Caption         =   "Tahun Lahir Baru"
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
      Left            =   5400
      TabIndex        =   57
      Top             =   3840
      Width           =   1935
   End
   Begin VB.Label LblDilayaniOleh 
      BackStyle       =   0  'Transparent
      Caption         =   "Dilayani Oleh"
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
      Left            =   480
      TabIndex        =   56
      Top             =   3840
      Width           =   1935
   End
   Begin VB.Label LblStatusNonAktif 
      BackStyle       =   0  'Transparent
      Caption         =   "Status Non Aktif"
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
      Left            =   5400
      TabIndex        =   55
      Top             =   4320
      Width           =   1935
   End
   Begin VB.Label LblStatusKeanggotaan 
      BackStyle       =   0  'Transparent
      Caption         =   "Status Keanggotaan"
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
      Left            =   480
      TabIndex        =   54
      Top             =   4320
      Width           =   1935
   End
   Begin VB.Label LblNoRemaja 
      BackStyle       =   0  'Transparent
      Caption         =   "No.Remaja"
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
      Left            =   5400
      TabIndex        =   53
      Top             =   2880
      Width           =   1935
   End
   Begin VB.Label LblNoKAA 
      BackStyle       =   0  'Transparent
      Caption         =   "No.KAA"
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
      Left            =   480
      TabIndex        =   52
      Top             =   2880
      Width           =   1935
   End
   Begin VB.Label LblNoSimpatisan 
      BackStyle       =   0  'Transparent
      Caption         =   "No.Simpatisan"
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
      Left            =   480
      TabIndex        =   51
      Top             =   2400
      Width           =   1935
   End
   Begin VB.Label LblNoAnggota 
      BackStyle       =   0  'Transparent
      Caption         =   "No. Anggota"
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
      Left            =   5400
      TabIndex        =   50
      Top             =   2400
      Width           =   1935
   End
   Begin VB.Label LblJenisKelamin 
      BackStyle       =   0  'Transparent
      Caption         =   "Jenis Kelamin"
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
      Left            =   480
      TabIndex        =   38
      Top             =   1920
      Width           =   1935
   End
   Begin VB.Label LblTempatLahir 
      BackStyle       =   0  'Transparent
      Caption         =   "Tempat Lahir"
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
      Left            =   480
      TabIndex        =   37
      Top             =   2400
      Width           =   1935
   End
   Begin VB.Label LblTanggalLahir 
      BackStyle       =   0  'Transparent
      Caption         =   "Tanggal Lahir"
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
      Left            =   5400
      TabIndex        =   36
      Top             =   2400
      Width           =   1935
   End
   Begin VB.Label LblGolonganDarah 
      BackStyle       =   0  'Transparent
      Caption         =   "Golongan Darah"
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
      Left            =   5400
      TabIndex        =   35
      Top             =   1920
      Width           =   1935
   End
   Begin VB.Label LblWarganegara 
      BackStyle       =   0  'Transparent
      Caption         =   "Warganegara"
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
      Left            =   5400
      TabIndex        =   34
      Top             =   2940
      Width           =   1935
   End
   Begin VB.Label LblEmail 
      BackStyle       =   0  'Transparent
      Caption         =   "Email"
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
      Left            =   480
      TabIndex        =   33
      Top             =   3420
      Width           =   1935
   End
   Begin VB.Label LblHP 
      BackStyle       =   0  'Transparent
      Caption         =   "HP"
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
      Left            =   5400
      TabIndex        =   32
      Top             =   3420
      Width           =   1935
   End
   Begin VB.Label LblFax 
      BackStyle       =   0  'Transparent
      Caption         =   "Fax"
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
      Left            =   480
      TabIndex        =   31
      Top             =   3900
      Width           =   1935
   End
   Begin VB.Label LblAgama 
      BackStyle       =   0  'Transparent
      Caption         =   "Agama"
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
      Left            =   480
      TabIndex        =   30
      Top             =   2880
      Width           =   1935
   End
   Begin VB.Label lblSearchBioData2 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Search by Bio Data 2"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   225
      Left            =   4680
      TabIndex        =   25
      Top             =   1400
      Width           =   1845
   End
   Begin VB.Label lblSearchByAddress 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Search by Address"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   225
      Left            =   7920
      TabIndex        =   24
      Top             =   1400
      Width           =   1845
   End
   Begin VB.Label lblSearchBiodata1 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Search by Bio Data"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   225
      Left            =   1440
      TabIndex        =   23
      Top             =   1400
      Width           =   1845
   End
   Begin VB.Label lblGetData 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "<<"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   315
      Left            =   240
      TabIndex        =   22
      Top             =   6000
      Width           =   285
   End
   Begin VB.Image Image1 
      Height          =   495
      Left            =   120
      Picture         =   "FrmSeachMahasiswa.frx":1488
      Stretch         =   -1  'True
      Top             =   5880
      Width           =   495
   End
   Begin VB.Label lblBioData 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "BIO Data"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   435
      Left            =   11040
      TabIndex        =   21
      Top             =   6240
      Width           =   645
   End
   Begin VB.Label lblChurchData 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Church Data"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   435
      Left            =   11040
      TabIndex        =   20
      Top             =   6960
      Width           =   645
   End
   Begin VB.Label lblClear 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Clear"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   315
      Left            =   11040
      TabIndex        =   19
      Top             =   4320
      Width           =   645
   End
   Begin VB.Image ImgBioData 
      Height          =   735
      Left            =   10800
      Picture         =   "FrmSeachMahasiswa.frx":1D59
      Stretch         =   -1  'True
      Top             =   6120
      Width           =   1065
   End
   Begin VB.Image ImgClear 
      Height          =   510
      Left            =   10800
      Picture         =   "FrmSeachMahasiswa.frx":262A
      Top             =   4200
      Width           =   1065
   End
   Begin VB.Image ImgChurchData 
      Height          =   735
      Left            =   10800
      Picture         =   "FrmSeachMahasiswa.frx":2EFB
      Stretch         =   -1  'True
      Top             =   6840
      Width           =   1065
   End
   Begin VB.Label lblSearch 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Search"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   315
      Left            =   10920
      TabIndex        =   18
      Top             =   3720
      Width           =   765
   End
   Begin VB.Image ImgSearch 
      Height          =   510
      Left            =   10800
      Picture         =   "FrmSeachMahasiswa.frx":37CC
      Top             =   3600
      Width           =   1065
   End
   Begin VB.Label NamaLengkap 
      BackStyle       =   0  'Transparent
      Caption         =   "Nama Lengkap"
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
      Left            =   240
      TabIndex        =   16
      Top             =   720
      Width           =   1935
   End
   Begin VB.Label LblNamaMandarin2 
      BackStyle       =   0  'Transparent
      Caption         =   "Nama Mandarin"
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
      Left            =   5280
      TabIndex        =   15
      Top             =   240
      Width           =   1935
   End
   Begin VB.Label LblNamaPanggilan 
      BackStyle       =   0  'Transparent
      Caption         =   "Nama Panggilan"
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
      Left            =   5280
      TabIndex        =   14
      Top             =   720
      Width           =   1935
   End
   Begin VB.Label LblNPanggilan 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   9600
      TabIndex        =   13
      Top             =   120
      Width           =   2295
   End
   Begin VB.Label LblPersonID 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "PersonID"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   1215
   End
   Begin VB.Image Image3 
      Height          =   3495
      Left            =   10680
      Picture         =   "FrmSeachMahasiswa.frx":409D
      Stretch         =   -1  'True
      Top             =   0
      Width           =   1335
   End
   Begin VB.Image Image2 
      Height          =   2895
      Left            =   -120
      Picture         =   "FrmSeachMahasiswa.frx":4BB9
      Stretch         =   -1  'True
      Top             =   4920
      Width           =   855
   End
   Begin VB.Label LblAlamat 
      BackStyle       =   0  'Transparent
      Caption         =   "Alamat"
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
      Left            =   480
      TabIndex        =   69
      Top             =   1920
      Width           =   1935
   End
   Begin VB.Image ImgAddress 
      Height          =   3495
      Left            =   120
      Picture         =   "FrmSeachMahasiswa.frx":56D5
      Stretch         =   -1  'True
      Top             =   1320
      Width           =   10455
   End
   Begin VB.Label lblAddLite 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Add Lite"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   315
      Left            =   10920
      TabIndex        =   79
      Top             =   4920
      Width           =   885
   End
   Begin VB.Image ImgAddNew 
      Height          =   510
      Left            =   10800
      Picture         =   "FrmSeachMahasiswa.frx":70BD
      Top             =   4800
      Width           =   1065
   End
   Begin VB.Image ImgAddBioData 
      Height          =   735
      Left            =   10800
      Picture         =   "FrmSeachMahasiswa.frx":798E
      Stretch         =   -1  'True
      Top             =   5400
      Width           =   1065
   End
   Begin VB.Image Image4 
      Height          =   4695
      Left            =   10680
      Picture         =   "FrmSeachMahasiswa.frx":825F
      Stretch         =   -1  'True
      Top             =   3240
      Width           =   1335
   End
   Begin VB.Label LblRW 
      BackStyle       =   0  'Transparent
      Caption         =   "RW"
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
      Left            =   5400
      TabIndex        =   71
      Top             =   2400
      Width           =   1935
   End
End
Attribute VB_Name = "FrmSearchPeople"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim MyBioData As Person
Dim myBIODataBuffer As Person_Buffer
Dim myaddress As alamat
Dim myaddressbuffer As Alamat_Buffer
Dim tabform As Long
Dim WithEvents SearchBioData As ClsItems
Attribute SearchBioData.VB_VarHelpID = -1
Dim WithEvents myitems As ClsItems
Attribute myitems.VB_VarHelpID = -1

Private Sub CboAgama_Click()
    MyBioData.Agama = CboAgama.Text
End Sub

Private Sub CboDaerahID_Click()
    myaddress.DaerahID = CboDaerahID.Text
End Sub

Private Sub CboGolonganDarah_click()
    MyBioData.Golongan_Darah = CboGolonganDarah.Text

End Sub



Private Sub CboJenisKelamin_Click()
    MyBioData.Jenis_Kelamin = CboJenisKelamin.Text
End Sub

Private Sub CboLahirBaru_Click()
    MyBioData.Lahir_Baru = CboLahirBaru.Text
End Sub

Private Sub CboStatusAlamat_Click()
    myaddress.Status_Alamat = CboStatusAlamat.Text
End Sub

Private Sub CboStatusKeanggotaan_click()
    MyBioData.StatusKeanggotaan = CboStatusKeanggotaan.Text

End Sub

Private Sub CboStatusNonAktif_Click()
    MyBioData.StatusNonaktif = CboStatusNonAktif.Text
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
        MyBioData.Tanggal_Lahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        MyBioData.Tanggal_Lahir = ""
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
        MyBioData.Tanggal_Lahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        MyBioData.Tanggal_Lahir = ""
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
        MyBioData.Tanggal_Lahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        MyBioData.Tanggal_Lahir = ""
    End If

End Sub



Private Sub CboTanggalLahirBaru_Year_Click()
    
    MyBioData.Tahun_lahir_baru = CboTanggalLahirBaru_Year.Text
End Sub




Private Sub lbladdnew_Click()

End Sub

Private Sub CboWilayahID_Click()
    myaddress.WilayahID = Trim(CboWilayahID.Text)
    Set myitems = New ClsItems
    Dim rs As ADODB.Recordset
    Set rs = myitems.Getdaerah(Trim(CboWilayahID.Text), MyClient)
    
    CboDaerahID.Clear
    If rs.RecordCount > 0 Then rs.MoveFirst
    While Not rs.EOF
        
        CboDaerahID.AddItem (rs.Fields("DaerahID"))
        rs.MoveNext
    Wend
End Sub

Private Sub Form_Unload(Cancel As Integer)
  Dim xxcounter As Long
  Dim i As Long
  xxcounter = Me.Height
'Collapse Form
  Do: DoEvents
    If xxcounter > 700 Then
        xxcounter = xxcounter - 700
    Else
        xxcounter = xxcounter - 70
    End If
    Me.Height = Abs(xxcounter)
    Me.Top = (Screen.Height - Me.Height) / 2
  Loop Until xxcounter <= 10
  i = 15
  xxcounter = Me.Width
'Strech form to edges
  Do: DoEvents
    xxcounter = xxcounter + i
    Me.Width = Abs(xxcounter)
    Me.Left = (Screen.Width - Me.Width) / 2
    i = i + 40
  Loop Until xxcounter >= Screen.Width
End Sub

Private Sub imgQuit_Click()
Unload Me
myAyat.ResetCounter
End Sub

Private Sub lblAddBioData_Click()
    Unload Me
    frmAddBioData.Show
End Sub

Private Sub lblAddLite_Click()
    Unload Me
    FrmAddLite.Show
End Sub

Private Sub lblClear_Click()
    MyBioData.PersonID = ""
          MyBioData.Dilayani_Oleh = ""
    MyBioData.Email = ""
    MyBioData.Fax = ""
    MyBioData.Golongan_Darah = ""
    MyBioData.HP = ""
    MyBioData.Jenis_Kelamin = ""
    MyBioData.KebaktianNo = ""
    MyBioData.Lahir_Baru = ""
    MyBioData.Nama_Lengkap = ""
    MyBioData.Nama_Mandarin = ""
    MyBioData.Nama_Panggilan = ""
    MyBioData.No_Anggota_tamu = ""
    MyBioData.No_Simpatisan = ""
    MyBioData.No_Anggota = ""
    MyBioData.No_KAA = ""
    MyBioData.No_Remaja = ""
    MyBioData.PersonID = ""
    MyBioData.Tanggal_Lahir = ""
    MyBioData.Tempat_lahir = ""
    MyBioData.warganegara = ""
    MyBioData.Umur = ""
    MyBioData.Agama = ""
    MyBioData.Tahun_lahir_baru = ""
    MyBioData.StatusKeanggotaan = ""
    MyBioData.StatusNonaktif = ""
    MyBioData.Gereja = ""
    
    TxtPersonID.Text = ""
    TxtNamaLengkap.Text = ""
    TxtNamaMandarin.Text = ""
    TxtNamaPanggilan.Text = ""
    TxtNoAnggotaTamu.Text = ""
    TxtNoSimpatisan.Text = ""
    TxtNoAnggota.Text = ""
    TxtNoKAA.Text = ""
    TxtNoRemaja.Text = ""
'    CboTanggalLahir_Day.Text = ""
'    CboTanggalLahir_Month.Text = ""
'    CboTanggalLahir_Year.Text = ""
'    CboTanggalLahirBaru_Year.Text = ""
    TxtTempatLahir.Text = ""
    TxtWarganegara.Text = ""
'    '     CboJenisKelamin.Text = ""
    TxtKebaktianNo.Text = ""
    TxtHP.Text = ""
    TxtGereja.Text = ""
    TxtEmail.Text = ""
    TxtFax.Text = ""
'    '     CboGolonganDarah.Text = ""
    TxtDilayaniOleh.Text = ""
'    CboAgama.Text = ""
'    CboStatusKeanggotaan.Text = ""
'    '     CboStatusNonAktif.Text = ""
    TxtNoKAA.Text = ""
    TxtNoRemaja.Text = ""

    TxtAlamat.Text = ""
    TxtRT.Text = ""
    TxtRW.Text = ""
    TxtKodePos.Text = ""
    TxtTelp.Text = ""
'    CboStatusAlamat.Text = ""
    TxtKota.Text = ""
    CboDaerahID.Text = ""
'    CboWilayahID.Text = ""
    
    myaddress.AddressID = ""
    myaddress.alamat = ""
    myaddress.DaerahID = ""
    myaddress.Kode_pos = ""
    myaddress.rt = ""
    myaddress.rw = ""
    myaddress.Status_Alamat = ""
    myaddress.Telp = ""
    myaddress.WilayahID = ""
    myaddress.Kota = ""
    TxtNoAnggota2.Text = ""
    Unload Me
    FrmSearchPeople.Show
End Sub

Private Sub lblBIOData_Click()
    Set myitems = New ClsItems
    Dim biodatarecordset As ADODB.Recordset
    currentpersonid = Trim(DataGridSearchPeople.Columns(0).Value)
    Set biodatarecordset = myitems.getbiodatarecordset(CStr(DataGridSearchPeople.Columns(0).Value), MyClient)
    Dim datarecordcount As Long
    datarecordcount = myitems.GetTotalNumberofData
    'currentpersonid = biodatarecordset.Fields("PersonID")
    currentpersonname = biodatarecordset.Fields("Nama_lengkap")
    currentpersonWarganegara = biodatarecordset.Fields("Warganegara")
    currentpersonnamapanggilan = biodatarecordset.Fields("Nama_Panggilan")
    currentpersonJenisKelamin = biodatarecordset.Fields("Jenis_Kelamin")
   
    
    Dim mytanggallahir As Date

    If Not IsNull(biodatarecordset.Fields("tanggal_lahir")) Then
        mytanggallahir = CDate(biodatarecordset.Fields("Tanggal_Lahir"))
    
          If (Month(mytanggallahir) = 1) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Januari" + " " + Trim(Year(mytanggallahir)))
        
        ElseIf (Month(mytanggallahir) = 2) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Februari" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 3) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Maret" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 4) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "April" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 5) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Mei" + " " + Trim(Year(mytanggallahir)))
        
        ElseIf (Month(mytanggallahir) = 6) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Juni" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 7) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Juli" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 8) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Agustus" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 9) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "September" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 10) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Oktober" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 11) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "November" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 12) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Desember" + " " + Trim(Year(mytanggallahir)))
        End If
    Else
        currentpersonTanggalLahir = ""
    
    End If
    currentpersonTempatLahir = Trim(biodatarecordset.Fields("Tempat_Lahir"))
    JenisKelaminPersonID = Trim(biodatarecordset.Fields("Jenis_KElamin"))
    
    myFullBiodata = ""
    myFullBiodata = myFullBiodata & "Person ID     : " & Trim(biodatarecordset.Fields("PersonID")) & "     "
    myFullBiodata = myFullBiodata & "Nama Lengkap  : " & Trim(biodatarecordset.Fields("Nama_Lengkap")) & "     "
    If Trim(biodatarecordset.Fields("Nama_Mandarin")) <> "" Then
    myFullBiodata = myFullBiodata & "Nama Mandarin : " & Trim(biodatarecordset.Fields("Nama_Mandarin")) & vbCrLf
    Else
    myFullBiodata = myFullBiodata & vbCrLf
    End If
    If Trim(biodatarecordset.Fields("No_Anggota")) <> "" Then
    myFullBiodata = myFullBiodata & "No Anggota    : " & Trim(biodatarecordset.Fields("No_Anggota")) & vbCrLf
    currentpersonnoanggota = Trim(biodatarecordset.Fields("No_Anggota"))
    Else
    currentpersonnoanggota = ""
    End If
    If Trim(biodatarecordset.Fields("No_Simpatisan")) <> "" Then
    myFullBiodata = myFullBiodata & "No Simpatisan    : " & Trim(biodatarecordset.Fields("No_Simpatisan")) & vbCrLf
    End If
    If Trim(biodatarecordset.Fields("No_Anggota_Tamu")) <> "" Then
    myFullBiodata = myFullBiodata & "No Anggota Tamu  : " & Trim(biodatarecordset.Fields("No_Anggota_Tamu")) & vbCrLf
    End If
    If Trim(biodatarecordset.Fields("No_Remaja")) <> "" Then
    myFullBiodata = myFullBiodata & "No Remaja        : " & Trim(biodatarecordset.Fields("No_Remaja")) & vbCrLf
    End If
    If Trim(biodatarecordset.Fields("No_KAA")) <> "" Then
    myFullBiodata = myFullBiodata & "No KAA           : " & Trim(biodatarecordset.Fields("No_KAA")) & vbCrLf
    End If

    Set biodatarecordset = myitems.SearchBioData2(CStr(DataGridSearchPeople.Columns(0).Value), MyClient)
    If biodatarecordset.RecordCount > 0 Then
        currentpersonaddress = biodatarecordset.Fields("Alamat")
    Else
        currentpersonaddress = ""
    End If
    myFullBiodata = myFullBiodata & vbCrLf
    If currentpersonTanggalLahir <> "" Then
        myFullBiodata = myFullBiodata & "Tanggal Lahir : " & currentpersonTanggalLahir
    End If
    Unload Me
    Call CloseAllForm
    Unload frmEditBioData
    frmEditBioData.Show
End Sub

Private Sub lblchurchdata_Click()

   Set myitems = New ClsItems
    Dim biodatarecordset As ADODB.Recordset
    
    Set biodatarecordset = myitems.getbiodatarecordset(CStr(DataGridSearchPeople.Columns(0).Value), MyClient)
    Dim datarecordcount As Long
    datarecordcount = myitems.GetTotalNumberofData
    currentpersonid = biodatarecordset.Fields("PersonID")
    currentpersonname = biodatarecordset.Fields("Nama_lengkap")
    currentpersonWarganegara = biodatarecordset.Fields("Warganegara")
    currentpersonnamapanggilan = biodatarecordset.Fields("Nama_Panggilan")
    currentpersonJenisKelamin = biodatarecordset.Fields("Jenis_Kelamin")
    Dim mytanggallahir As Date
    
    If Not IsNull(biodatarecordset.Fields("tanggal_lahir")) Then
        mytanggallahir = CDate(biodatarecordset.Fields("Tanggal_Lahir"))
    
          If (Month(mytanggallahir) = 1) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Januari" + " " + Trim(Year(mytanggallahir)))
        
        ElseIf (Month(mytanggallahir) = 2) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Februari" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 3) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Maret" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 4) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "April" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 5) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Mei" + " " + Trim(Year(mytanggallahir)))
        
        ElseIf (Month(mytanggallahir) = 6) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Juni" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 7) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Juli" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 8) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Agustus" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 9) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "September" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 10) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Oktober" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 11) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "November" + " " + Trim(Year(mytanggallahir)))
        ElseIf (Month(mytanggallahir) = 12) Then
             currentpersonTanggalLahir = Trim(Trim(Day(mytanggallahir)) + " " + "Desember" + " " + Trim(Year(mytanggallahir)))
        End If
    Else
        currentpersonTanggalLahir = ""
        
    End If
    currentpersonTempatLahir = Trim(biodatarecordset.Fields("Tempat_Lahir"))
    JenisKelaminPersonID = Trim(biodatarecordset.Fields("Jenis_KElamin"))

    myFullBiodata = ""
        
    myFullBiodata = myFullBiodata & "Person ID     : " & Trim(biodatarecordset.Fields("PersonID")) & "     "
    myFullBiodata = myFullBiodata & "Nama Lengkap  : " & Trim(biodatarecordset.Fields("Nama_Lengkap")) & "     "
    If Trim(biodatarecordset.Fields("Nama_Mandarin")) <> "" Then
    myFullBiodata = myFullBiodata & "Nama Mandarin : " & Trim(biodatarecordset.Fields("Nama_Mandarin")) & vbCrLf
    Else
    myFullBiodata = myFullBiodata & vbCrLf
    End If
    If Trim(biodatarecordset.Fields("No_Anggota")) <> "" Then
    myFullBiodata = myFullBiodata & "No Anggota    : " & Trim(biodatarecordset.Fields("No_Anggota")) & vbCrLf
    currentpersonnoanggota = Trim(biodatarecordset.Fields("No_Anggota"))
    Else
    currentpersonnoanggota = ""
    End If
    If Trim(biodatarecordset.Fields("No_Simpatisan")) <> "" Then
    myFullBiodata = myFullBiodata & "No Simpatisan    : " & Trim(biodatarecordset.Fields("No_Simpatisan")) & vbCrLf
    End If
    If Trim(biodatarecordset.Fields("No_Anggota_Tamu")) <> "" Then
    myFullBiodata = myFullBiodata & "No Anggota Tamu  : " & Trim(biodatarecordset.Fields("No_Anggota_Tamu")) & vbCrLf
    End If
    If Trim(biodatarecordset.Fields("No_Remaja")) <> "" Then
    myFullBiodata = myFullBiodata & "No Remaja        : " & Trim(biodatarecordset.Fields("No_Remaja")) & vbCrLf
    End If
    If Trim(biodatarecordset.Fields("No_KAA")) <> "" Then
    myFullBiodata = myFullBiodata & "No KAA           : " & Trim(biodatarecordset.Fields("No_KAA")) & vbCrLf
    End If
    
    Set biodatarecordset = myitems.SearchBioData2(CStr(DataGridSearchPeople.Columns(0).Value), MyClient)
    If biodatarecordset.RecordCount > 0 Then
        currentpersonaddress = biodatarecordset.Fields("Alamat")
    Else
        currentpersonaddress = ""
    End If
    myFullBiodata = myFullBiodata & vbCrLf
    If currentpersonTanggalLahir <> "" Then
        myFullBiodata = myFullBiodata & "Tanggal Lahir : " & currentpersonTanggalLahir
    End If
    Unload Me
    Call CloseAllForm
    If Trim(Trim(MyAuthority.AuthorityID)) = "INPUTUSER" Then
        Unload FrmBaptisan
        FrmBaptisan.Show
        Unload Me
    ElseIf Trim(MyAuthority.AuthorityID) = "A3" Then
        Unload FrmEE
        FrmEE.Show
        Unload Me
    ElseIf Trim(MyAuthority.AuthorityID) = "C4" Then
        Unload FrmKK
        FrmKK.Show
        Unload Me
        
    ElseIf Trim(MyAuthority.AuthorityID) = "D1" Then
        Unload FrmKAA
        FrmKAA.Show
        Unload Me
    ElseIf Trim(MyAuthority.AuthorityID) = "D2" Then
        Unload FrmRemaja
        FrmRemaja.Show
        Unload Me
    ElseIf Trim(MyAuthority.AuthorityID) = "E1" Then
        Unload FrmBaptisan
        FrmBaptisan.Show
        Unload Me
    ElseIf Trim(MyAuthority.AuthorityID) = "E5" Then
        Unload FrmPembinaan
        FrmPembinaan.Show
        Unload Me
    ElseIf Trim(MyAuthority.AuthorityID) = "N" Then
        Unload FrmPM
        FrmPM.Show
        Unload Me
    ElseIf Trim(MyAuthority.AuthorityID) = "C3" Then
        
    Else
        Unload FrmPelayanan
        FrmPelayanan.Show
        Unload Me
    End If
End Sub

Private Sub Cmdfunction3_Click()

End Sub

Private Sub lblgetdata_Click()
   
   If mytabform = 2 Then

        frmOrangTua.SetFocus

        frmOrangTua.TxtOrangTuaID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 3 Then
       frmAnak.SetFocus
        frmAnak.TxtAnakID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    
    ElseIf mytabform = 4 Then
        frmSuamiIstri.SetFocus
        frmSuamiIstri.TxtSuamiIstriID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    
    ElseIf mytabform = 5 Then
         frmAdikKakak.SetFocus
        frmAdikKakak.TxtAdikKakakID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
     ElseIf mytabform = 6 Then '106 Sejarah pendidikan
               FrmFunction1.Show
   
    
    ElseIf mytabform = 50 Then
        frmAddNewOJT.SetFocus
        frmAddNewOJT.TxtPersonIDOJT.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    
    ElseIf mytabform = 51 Then
         frmAddNewOJT.SetFocus
         frmAddNewOJT.TxtPelatihPenyajiID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
      ElseIf mytabform = 52 Then
        frmAddNewOJT.SetFocus
        frmAddNewOJT.txtAnggota1ID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    
    ElseIf mytabform = 53 Then
         frmAddNewOJT.SetFocus
         frmAddNewOJT.TxtAnggota2ID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
      ElseIf mytabform = 54 Then
        frmAddNewOJT.SetFocus
        frmAddNewOJT.TxtAnggota3ID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    
    ElseIf mytabform = 55 Then
         frmAddNewOJT.SetFocus
         frmAddNewOJT.TxtAnggota4ID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    
    ElseIf mytabform = 60 Then
        FrmKesukaan.SetFocus

        FrmKesukaan.TxtSpouseID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 61 Then
        FrmKesukaan.SetFocus

        FrmKesukaan.TxtPelayanKesukaan.Text = Trim(DataGridSearchPeople.Columns(0).Value)
      ElseIf mytabform = 70 Then

        FrmDiakonia.TxtPemberiRekomendasiID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    
    
    
    
    ElseIf mytabform = 100 Then
          frmAddBioData.SetFocus
          frmAddBioData.TxtDilayaniOleh.Text = Trim(DataGridSearchPeople.Columns(0).Value)
      
    ElseIf mytabform = 110 Then
          frmEditBioData.SetFocus
          frmEditBioData.TxtDilayaniOleh.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    
   
    ElseIf mytabform = 201 Then
        FrmBaptisan.SetFocus
       FrmBaptisan.TxtpelayanID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 203 Then
        FrmPelawatan.SetFocus
        FrmPelawatan.TxtPelawatID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 300 Then
        FrmSearchWilayah.SetFocus
        FrmSearchWilayah.TxtKepalaWilayah.Text = Trim(DataGridSearchPeople.Columns(1).Value)
    ElseIf mytabform = 301 Then
        FrmSearchWilayah.SetFocus

        FrmSearchWilayah.TxtWakilKepalaWilayah.Text = Trim(DataGridSearchPeople.Columns(1).Value)
    ElseIf mytabform = 302 Then
        FrmSearchWilayah.SetFocus

        FrmSearchWilayah.TxtPembinaRohani.Text = Trim(DataGridSearchPeople.Columns(1).Value)
    ElseIf mytabform = 303 Then
        FrmSearchPembinaan.SetFocus
        FrmSearchPembinaan.TxtPembinaID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
        
    ElseIf mytabform = 304 Then
        FrmAddEditPembinaan.SetFocus
        FrmAddEditPembinaan.TxtPembinaID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
     ElseIf mytabform = 305 Then
        FrmAddEditPembinaan.SetFocus
        FrmAddEditPembinaan.TxtPembina2ID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 306 Then
        FrmSearchPembinaan.SetFocus
        FrmSearchPembinaan.TxtPembina2ID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 307 Then
        FrmQueryPeople11.SetFocus
        FrmQueryPeople11.TxtPembinaID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 308 Then
           FrmQueryPeople11.SetFocus
        FrmQueryPeople11.TxtPembina2ID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
      
     ElseIf mytabform = 310 Then
        FrmSearchDaerah.SetFocus

        FrmSearchDaerah.TxtKepalaDaerah.Text = Trim(DataGridSearchPeople.Columns(1).Value)
    ElseIf mytabform = 311 Then
        FrmSearchDaerah.SetFocus

        FrmSearchDaerah.TxtAsistenKepalaDaerah.Text = Trim(DataGridSearchPeople.Columns(1).Value)
    
    
    
    ElseIf mytabform = 430 Then
        FrmSearchKelompokKecil.SetFocus

        FrmSearchKelompokKecil.TxtPemimpinKKID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 431 Then
        FrmAddEditKelompokKecil.SetFocus

        FrmAddEditKelompokKecil.TxtPemimpinKKID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
   
    ElseIf mytabform = 501 Then
        FrmAddKedukaan.SetFocus
        FrmAddKedukaan.TxtJitbokPelayanID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 502 Then
        FrmAddKedukaan.SetFocus
        FrmAddKedukaan.TxtMCJitbok.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 503 Then
        FrmAddKedukaan.SetFocus
        FrmAddKedukaan.TxtPenghiburanPelayanID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
       
    ElseIf mytabform = 504 Then
        FrmAddKedukaan.SetFocus
        FrmAddKedukaan.TxtMCPenghiburan.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 505 Then
        FrmAddKedukaan.SetFocus
        FrmAddKedukaan.TxtPelepasanJenasahPelayanID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 506 Then
        FrmAddKedukaan.SetFocus
        FrmAddKedukaan.TxtMCPelepasanJenasah.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 530 Then
        FrmQueryPeople17.SetFocus
        FrmQueryPeople17.TxtPersonID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    
    ElseIf mytabform = 550 Then
        FrmKAA.SetFocus
        FrmKAA.TxtGuruSekolahMingguID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 551 Then
        FrmKAA.SetFocus
        FrmKAA.TxtAsistenGuruSM.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 560 Then
        FrmRemaja.SetFocus
        FrmRemaja.TxtPembimbingID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 561 Then
        FrmRemaja.SetFocus
        FrmRemaja.TxtAsistenID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 600 Then
        FrmQueryPeople8.SetFocus
        FrmQueryPeople8.TxtGuruSekolahMingguID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 601 Then
        FrmQueryPeople8.SetFocus
        FrmQueryPeople8.TxtAsistenGuruSM.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 610 Then
        FrmQueryPeople9.SetFocus
        FrmQueryPeople9.TxtPembimbingID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 611 Then
        FrmQueryPeople9.SetFocus
        FrmQueryPeople9.TxtAsistenID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 650 Then
        frmSetPassword.SetFocus
        frmSetPassword.TxtPersonID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    ElseIf mytabform = 700 Then
        FrmSearchKomputer.SetFocus
        FrmSearchKomputer.TxtPersonID.Text = Trim(DataGridSearchPeople.Columns(0).Value)
    End If
    
    Unload Me
    
End Sub



Private Sub lblSearch_Click()
On Error GoTo servererror:
    Set SearchBioData = New ClsItems
    
    LSet myBIODataBuffer = MyBioData
    LSet myaddressbuffer = myaddress
    
    Dim searchrecordset As ADODB.Recordset

    If Trim(MyBioData.PersonID) = "" And Trim(MyBioData.No_Anggota) = "" And Trim(MyBioData.Nama_Lengkap) = "" And Trim(MyBioData.Nama_Mandarin) = "" And Trim(MyBioData.Nama_Panggilan) = "" And Trim(MyBioData.No_Anggota_tamu) = "" And Trim(MyBioData.No_KAA) = "" And Trim(MyBioData.No_Remaja) = "" And Trim(MyBioData.No_Simpatisan) = "" And Trim(myaddress.alamat) = "" Then
        MsgBox "Please input the criterias for searching at least PersonID or 'Name' ( Nama_Lengkap / Nama_Panggilan, etc) or 'No' ( No_Anggota / No_Simpatisan , etc ) or Alamat ", vbInformation, "Required"
    Else

    
    Set searchrecordset = SearchBioData.SearchBioData(myBIODataBuffer.Buffer, myaddressbuffer.Buffer, MyClient)
    If Not searchrecordset.EOF Then searchrecordset.MoveFirst
    Set DataGridSearchPeople.DataSource = searchrecordset
        
    
    
    
    Dim a As Long
    a = SearchBioData.GetTotalNumberofBIOData
    If a > 0 Then
        LblBioData.Enabled = True
         LblChurchData.Enabled = True
        lblGetData.Enabled = True
    Else
        LblBioData.Enabled = False
         LblChurchData.Enabled = True
        lblGetData.Enabled = False
    End If
    End If
    DataGridSearchPeople.Columns(0).Width = 800
    DataGridSearchPeople.Columns(1).Width = 2500
    DataGridSearchPeople.Columns(2).Width = 2500
    DataGridSearchPeople.Columns(3).Width = 500
    DataGridSearchPeople.Columns(4).Width = 500
    DataGridSearchPeople.Columns(5).Width = 1000
    DataGridSearchPeople.Columns(6).Width = 1000
    DataGridSearchPeople.Columns(7).Width = 1000
    DataGridSearchPeople.Columns(8).Width = 1500
    DataGridSearchPeople.Columns(9).Width = 1500
    DataGridSearchPeople.Columns(10).Width = 600
    DataGridSearchPeople.Columns(11).Width = 1000
    DataGridSearchPeople.Columns(12).Width = 700
    DataGridSearchPeople.Columns(13).Width = 700
    
    DataGridSearchPeople.Columns(14).Width = 700
    DataGridSearchPeople.Columns(15).Width = 700
    DataGridSearchPeople.Columns(16).Width = 2500
    DataGridSearchPeople.Columns(17).Width = 500
    DataGridSearchPeople.Columns(18).Width = 500
    DataGridSearchPeople.Columns(19).Width = 700
    DataGridSearchPeople.Columns(20).Width = 800
    DataGridSearchPeople.Columns(21).Width = 800
    DataGridSearchPeople.Columns(22).Width = 500
    DataGridSearchPeople.Columns(23).Width = 500
    DataGridSearchPeople.Columns(24).Width = 500
    DataGridSearchPeople.Columns(25).Width = 200
    DataGridSearchPeople.Columns(26).Width = 500
    DataGridSearchPeople.Columns(27).Width = 500
    DataGridSearchPeople.Columns(28).Width = 1000
    DataGridSearchPeople.Columns(29).Width = 1000
Exit Sub
servererror:
    'err.Raise err.Number
End Sub








Private Sub Form_Load()
On Error GoTo servererror:
    MyClientComputer
    Dim counter As Long
    For counter = 1 To 31
        CboTanggalLahir_Day.AddItem (counter)
    Next counter
    For counter = 1 To 12
        CboTanggalLahir_Month.AddItem (counter)
    Next counter
    For counter = 1900 To 2200
        CboTanggalLahir_Year.AddItem (counter)
    Next counter
    CboGolonganDarah.AddItem ("  ")
    CboGolonganDarah.AddItem (" O")
    CboGolonganDarah.AddItem (" A")
    CboGolonganDarah.AddItem (" B")
    CboGolonganDarah.AddItem ("AB")
    
    CboJenisKelamin.AddItem ("  ")
    CboJenisKelamin.AddItem ("L")
    CboJenisKelamin.AddItem ("P")

    For counter = 1900 To 2200
        CboTanggalLahirBaru_Year.AddItem (counter)
    Next counter
    
    Set myitems = New ClsItems
    Dim rs As ADODB.Recordset
    Set rs = myitems.GetWilayah(MyClient)
    
    CboWilayahID.Clear
    CboWilayahID.AddItem ("")
    If rs.RecordCount > 0 Then rs.MoveFirst
    While Not rs.EOF
        
        CboWilayahID.AddItem (rs.Fields("WilayahID"))
        rs.MoveNext
    Wend
    
    MyBioData.Dilayani_Oleh = ""
    MyBioData.Email = ""
    MyBioData.Fax = ""
    MyBioData.Golongan_Darah = ""
    MyBioData.HP = ""
    MyBioData.Jenis_Kelamin = ""
    MyBioData.KebaktianNo = ""
    MyBioData.Lahir_Baru = ""
    MyBioData.Nama_Lengkap = ""
    MyBioData.Nama_Mandarin = ""
    MyBioData.Nama_Panggilan = ""
    MyBioData.No_Anggota_tamu = ""
    MyBioData.No_Simpatisan = ""
    MyBioData.No_Anggota = ""
    MyBioData.No_KAA = ""
    MyBioData.No_Remaja = ""
    MyBioData.PersonID = ""
    MyBioData.Tanggal_Lahir = ""
    MyBioData.Tempat_lahir = ""
    MyBioData.warganegara = ""
    MyBioData.Umur = ""
    MyBioData.Agama = ""
    MyBioData.Tahun_lahir_baru = ""
    MyBioData.StatusKeanggotaan = ""
    MyBioData.StatusNonaktif = ""
    MyBioData.Gereja = ""
    
    TxtNamaLengkap.Text = ""
    TxtNamaMandarin.Text = ""
    TxtNamaPanggilan.Text = ""
    TxtNoAnggotaTamu.Text = ""
    
    TxtNoSimpatisan.Text = ""
    TxtNoAnggota.Text = ""
    TxtNoKAA.Text = ""
    TxtNoRemaja.Text = ""
'    CboTanggalLahir_Day.Text = ""
'    CboTanggalLahir_Month.Text = ""
'    CboTanggalLahir_Year.Text = ""
'    CboTanggalLahirBaru_Year.Text = ""
    TxtTempatLahir.Text = ""
    TxtWarganegara.Text = ""
'    '     CboJenisKelamin.Text = ""
    TxtKebaktianNo.Text = ""
    TxtHP.Text = ""

    TxtEmail.Text = ""
    TxtFax.Text = ""
'    '     CboGolonganDarah.Text = ""
    TxtDilayaniOleh.Text = ""
'    CboAgama.Text = ""
'    CboStatusKeanggotaan.Text = ""
'    '     CboStatusNonAktif.Text = ""
    TxtNoKAA.Text = ""
    TxtNoRemaja.Text = ""

    TxtAlamat.Text = ""
    TxtRT.Text = ""
    TxtRW.Text = ""
    TxtKodePos.Text = ""
    TxtTelp.Text = ""
'    CboStatusAlamat.Text = ""

    CboDaerahID.Text = ""
    
    myaddress.AddressID = ""
    myaddress.alamat = ""
    myaddress.DaerahID = ""
    myaddress.Kode_pos = ""
    myaddress.rt = ""
    myaddress.rw = ""
    myaddress.Status_Alamat = ""
    myaddress.Telp = ""
    myaddress.WilayahID = ""
    myaddress.Kota = ""
    myaddress.PersonID = ""


    CenterChildForm2 Me
        lblSearchBioData2.Visible = True
    lblSearchByAddress.Visible = True
    ImgAddress.Visible = True
    
    lblSearchBiodata1.Visible = True

    
    LblJenisKelamin.Visible = True
    CboJenisKelamin.Visible = True
    LblGolonganDarah.Visible = True
    CboGolonganDarah.Visible = True
    LblTempatLahir.Visible = True
    TxtTempatLahir.Visible = True
    LblTanggalLahir.Visible = True
    CboTanggalLahir_Day.Visible = True
    CboTanggalLahir_Month.Visible = True
    CboTanggalLahir_Year.Visible = True
    LblAgama.Visible = True
    CboAgama.Visible = True
    LblWarganegara.Visible = True
    TxtWarganegara.Visible = True
    LblEmail.Visible = True
    TxtEmail.Visible = True
    LblHP.Visible = True
    TxtHP.Visible = True
    LblFax.Visible = True
    TxtFax.Visible = True
    
    lblNoAnggotaTamu.Visible = False
    LblNoSimpatisan.Visible = False
    LblNoKAA.Visible = False
    LblKebaktianNo.Visible = False
    LblDilayaniOleh.Visible = False
    LblStatusKeanggotaan.Visible = False
    TxtNoAnggotaTamu.Visible = False
    TxtNoSimpatisan.Visible = False
    TxtNoKAA.Visible = False
    TxtKebaktianNo.Visible = False
    TxtDilayaniOleh.Visible = False
    CboStatusKeanggotaan.Visible = False
    LblNoAnggota.Visible = False
    LblNoRemaja.Visible = False
    LblLahirBaru.Visible = False
    LblTanggalLahirBaru.Visible = False
    LblStatusNonAktif.Visible = False
    TxtNoAnggota.Visible = False
    TxtNoRemaja.Visible = False
    CboLahirBaru.Visible = False
    CboTanggalLahirBaru_Year.Visible = False
    CboStatusNonAktif.Visible = False
    
    lblAlamat.Visible = False
    LblRT.Visible = False
    LblRW.Visible = False
    LblKodePos.Visible = False
    LblKota.Visible = False

    LblTelp.Visible = False
    LblStatusAlamat.Visible = False
    LblWilayahID.Visible = False
    LblDaerahID.Visible = False
    TxtAlamat.Visible = False
    TxtRT.Visible = False
    TxtRW.Visible = False
    TxtKodePos.Visible = False
    TxtKota.Visible = False

    TxtTelp.Visible = False
    CboStatusAlamat.Visible = False

    CboDaerahID.Visible = False
    

    
Exit Sub
servererror:
    MsgBox "Error.... The possibility is that you haven't run the program in the Server", vbInformation, "Can not access Server !"
    
    
End Sub



Private Sub Label1_Click()

End Sub

Private Sub lblSearchBiodata1_Click()
    lblSearchBioData2.Visible = True
    lblSearchByAddress.Visible = True

    ImgAddress.Visible = True
    
    lblSearchBiodata1.Visible = True

    
    LblJenisKelamin.Visible = True
    CboJenisKelamin.Visible = True
    LblGolonganDarah.Visible = True
    CboGolonganDarah.Visible = True
    LblTempatLahir.Visible = True
    TxtTempatLahir.Visible = True
    LblTanggalLahir.Visible = True
    CboTanggalLahir_Day.Visible = True
    CboTanggalLahir_Month.Visible = True
    CboTanggalLahir_Year.Visible = True
    LblAgama.Visible = True
    CboAgama.Visible = True
    LblWarganegara.Visible = True
    TxtWarganegara.Visible = True
    LblEmail.Visible = True
    TxtEmail.Visible = True
    LblHP.Visible = True
    TxtHP.Visible = True
    LblFax.Visible = True
    TxtFax.Visible = True
    
    lblNoAnggotaTamu.Visible = False
    LblNoSimpatisan.Visible = False
    LblNoKAA.Visible = False
    LblKebaktianNo.Visible = False
    LblDilayaniOleh.Visible = False
    LblStatusKeanggotaan.Visible = False
    TxtNoAnggotaTamu.Visible = False
    TxtNoSimpatisan.Visible = False
    TxtNoKAA.Visible = False
    TxtKebaktianNo.Visible = False
    TxtDilayaniOleh.Visible = False
    CboStatusKeanggotaan.Visible = False
    LblNoAnggota.Visible = False
    LblNoRemaja.Visible = False
    LblLahirBaru.Visible = False
    LblTanggalLahirBaru.Visible = False
    LblStatusNonAktif.Visible = False
    TxtNoAnggota.Visible = False
    TxtNoRemaja.Visible = False
    CboLahirBaru.Visible = False
    CboTanggalLahirBaru_Year.Visible = False
    CboStatusNonAktif.Visible = False
    TxtGereja.Visible = False
    
    lblGereja.Visible = False
    lblAlamat.Visible = False
    LblRT.Visible = False
    LblRW.Visible = False
    LblKodePos.Visible = False
    LblKota.Visible = False

    LblTelp.Visible = False
    LblStatusAlamat.Visible = False
    LblWilayahID.Visible = False
    LblDaerahID.Visible = False
    TxtAlamat.Visible = False
    TxtRT.Visible = False
    TxtRW.Visible = False
    TxtKodePos.Visible = False
    TxtKota.Visible = False

    TxtTelp.Visible = False
    CboStatusAlamat.Visible = False
    CboWilayahID.Visible = False
    CboDaerahID.Visible = False
    LblNoAnggota2.Visible = True
    TxtNoAnggota2.Visible = True
End Sub

Private Sub lblSearchBioData2_Click()
  lblSearchBioData2.Visible = True
    lblSearchByAddress.Visible = True

    ImgAddress.Visible = True
    
    lblSearchBiodata1.Visible = True

    
    LblJenisKelamin.Visible = False
    CboJenisKelamin.Visible = False
    LblGolonganDarah.Visible = False
    CboGolonganDarah.Visible = False
    LblTempatLahir.Visible = False
    TxtTempatLahir.Visible = False
    LblTanggalLahir.Visible = False
    CboTanggalLahir_Day.Visible = False
    CboTanggalLahir_Month.Visible = False
    CboTanggalLahir_Year.Visible = False
    LblAgama.Visible = False
    CboAgama.Visible = False
    LblWarganegara.Visible = False
    TxtWarganegara.Visible = False
    LblEmail.Visible = False
    TxtEmail.Visible = False
    LblHP.Visible = False
    TxtHP.Visible = False
    LblFax.Visible = False
    TxtFax.Visible = False
    
    lblNoAnggotaTamu.Visible = True
    LblNoSimpatisan.Visible = True
    LblNoKAA.Visible = True
    LblKebaktianNo.Visible = True
    LblDilayaniOleh.Visible = True
    LblStatusKeanggotaan.Visible = True
    TxtNoAnggotaTamu.Visible = True
    TxtNoSimpatisan.Visible = True
    TxtNoKAA.Visible = True
    TxtKebaktianNo.Visible = True
    TxtDilayaniOleh.Visible = True
    CboStatusKeanggotaan.Visible = True
    LblNoAnggota.Visible = True
    LblNoRemaja.Visible = True
    LblLahirBaru.Visible = True
    LblTanggalLahirBaru.Visible = True
    LblStatusNonAktif.Visible = True
    TxtNoAnggota.Visible = True
    TxtNoRemaja.Visible = True
    CboLahirBaru.Visible = True
    CboTanggalLahirBaru_Year.Visible = True
    CboStatusNonAktif.Visible = True
    TxtGereja.Visible = True
    
    lblGereja.Visible = True
    lblAlamat.Visible = False
    LblRT.Visible = False
    LblRW.Visible = False
    LblKodePos.Visible = False
    LblKota.Visible = False

    LblTelp.Visible = False
    LblStatusAlamat.Visible = False
    LblWilayahID.Visible = False
    LblDaerahID.Visible = False
    TxtAlamat.Visible = False
    TxtRT.Visible = False
    TxtRW.Visible = False
    TxtKodePos.Visible = False
    TxtKota.Visible = False

    TxtTelp.Visible = False
    CboStatusAlamat.Visible = False
    CboWilayahID.Visible = False
    CboDaerahID.Visible = False
        LblNoAnggota2.Visible = False
    TxtNoAnggota2.Visible = False
End Sub

Private Sub lblSearchByAddress_Click()
    lblSearchBioData2.Visible = True
    lblSearchByAddress.Visible = True

    ImgAddress.Visible = True
    
    lblSearchBiodata1.Visible = True

    
    LblJenisKelamin.Visible = False
    CboJenisKelamin.Visible = False
    LblGolonganDarah.Visible = False
    CboGolonganDarah.Visible = False
    LblTempatLahir.Visible = False
    TxtTempatLahir.Visible = False
    LblTanggalLahir.Visible = False
    CboTanggalLahir_Day.Visible = False
    CboTanggalLahir_Month.Visible = False
    CboTanggalLahir_Year.Visible = False
    LblAgama.Visible = False
    CboAgama.Visible = False
    LblWarganegara.Visible = False
    TxtWarganegara.Visible = False
    LblEmail.Visible = False
    TxtEmail.Visible = False
    LblHP.Visible = False
    TxtHP.Visible = False
    LblFax.Visible = False
    TxtFax.Visible = False

    lblNoAnggotaTamu.Visible = False
    LblNoSimpatisan.Visible = False
    LblNoKAA.Visible = False
    LblKebaktianNo.Visible = False
    LblDilayaniOleh.Visible = False
    LblStatusKeanggotaan.Visible = False
    TxtNoAnggotaTamu.Visible = False
    TxtNoSimpatisan.Visible = False
    TxtNoKAA.Visible = False
    TxtKebaktianNo.Visible = False
    TxtDilayaniOleh.Visible = False
    CboStatusKeanggotaan.Visible = False
    LblNoAnggota.Visible = False
    LblNoRemaja.Visible = False
    LblLahirBaru.Visible = False
    LblTanggalLahirBaru.Visible = False
    LblStatusNonAktif.Visible = False
    TxtNoAnggota.Visible = False
    TxtNoRemaja.Visible = False
    CboLahirBaru.Visible = False
    CboTanggalLahirBaru_Year.Visible = False
    CboStatusNonAktif.Visible = False
    TxtGereja.Visible = False
    
    lblGereja.Visible = False
    
    lblAlamat.Visible = True
    LblRT.Visible = True
    LblRW.Visible = True
    LblKodePos.Visible = True
    LblKota.Visible = True

    LblTelp.Visible = True
    LblStatusAlamat.Visible = True
    LblWilayahID.Visible = True
    LblDaerahID.Visible = True
    TxtAlamat.Visible = True
    TxtRT.Visible = True
    TxtRW.Visible = True
    TxtKodePos.Visible = True
    TxtKota.Visible = True

    TxtTelp.Visible = True
    CboStatusAlamat.Visible = True
        CboWilayahID.Visible = True
    CboDaerahID.Visible = True
        LblNoAnggota2.Visible = False
    TxtNoAnggota2.Visible = False
End Sub

Private Sub myitems_AuthorityFail()
    MsgBox "Authority Fail", vbInformation, "You need to login first"
End Sub

Private Sub SearchBioData_AuthorityFail()
    MsgBox "Authority Fail", vbInformation, "You need to login first"
End Sub

Private Sub TxtAlamat_Change()
    myaddress.alamat = TxtAlamat.Text
End Sub

Private Sub TxtDilayaniOleh_Change()
    MyBioData.Dilayani_Oleh = TxtDilayaniOleh.Text
End Sub



Private Sub TxtEmail_Change()
    MyBioData.Email = TxtEmail.Text
End Sub

Private Sub TxtFax_Change()
    MyBioData.Fax = TxtFax.Text
End Sub




Private Sub TxtGereja_Change()
    MyBioData.Gereja = TxtGereja.Text
End Sub

Private Sub TxtHP_Change()
    MyBioData.HP = TxtHP.Text
End Sub

Private Sub TxtKebaktianNo_Change()
    MyBioData.KebaktianNo = TxtKebaktianNo.Text
End Sub

Private Sub TxtKebaktianNo_Click()
    mytabform = 1
    Unload FrmSearchKebaktian
    FrmSearchKebaktian.Show
    FrmSearchKebaktian.SetFocus
End Sub

Private Sub TxtKodePos_Change()
    myaddress.Kode_pos = TxtKodePos.Text
End Sub

Private Sub TxtNamaLengkap_Change()
    MyBioData.Nama_Lengkap = TxtNamaLengkap.Text
    If Left((UCase(TxtNamaLengkap.Text)), 3) = "PDT" Then
        MsgBox "Please do not use Pdt. Title", vbInformation, "Use Name only without Title"
    ElseIf Left((UCase(TxtNamaLengkap.Text)), 3) = "EV." And Len(TxtNamaLengkap.Text) = 3 Then
        MsgBox "Please do not use Ev. Title", vbInformation, "Use Name only without Title"
    ElseIf Left((UCase(TxtNamaLengkap.Text)), 2) = "EV" And Len(TxtNamaLengkap.Text) = 2 Then
        MsgBox "Make sure not use Ev. Title but name only", vbInformation, "Use Name only without Title"
    End If
    
End Sub

Private Sub TxtNamaMandarin_Change()
    MyBioData.Nama_Mandarin = TxtNamaMandarin.Text
End Sub

Private Sub TxtNamaPanggilan_Change()
    MyBioData.Nama_Panggilan = TxtNamaPanggilan.Text
End Sub



Private Sub TxtNoAnggota_Change()
    MyBioData.No_Anggota = TxtNoAnggota.Text
End Sub

Private Sub TxtNoAnggota2_Change()
    MyBioData.No_Anggota = TxtNoAnggota2.Text
End Sub

Private Sub TxtNoKAA_Change()
    MyBioData.No_KAA = TxtNoKAA.Text
    
End Sub

Private Sub TxtNoRemaja_Change()
    MyBioData.No_Remaja = TxtNoRemaja.Text
End Sub

Private Sub TxtNoSimpatisan_Change()
    MyBioData.No_Simpatisan = TxtNoSimpatisan.Text
End Sub

Private Sub Txtkota_Change()
    myaddress.Kota = TxtKota.Text
End Sub


Private Sub TxtRT_Change()
    myaddress.rt = TxtRT.Text
End Sub

Private Sub TxtRW_Change()
    myaddress.rw = TxtRW.Text
End Sub

Private Sub TxtTelp_Change()
    myaddress.Telp = TxtTelp.Text
End Sub

Private Sub TxtTempatLahir_Change()
    MyBioData.Tempat_lahir = TxtTempatLahir.Text
End Sub


Private Sub TxtWarganegara_Change()
    MyBioData.warganegara = TxtWarganegara.Text
End Sub

Private Sub TxtPersonID_Change()
    MyBioData.PersonID = TxtPersonID.Text
    myaddress.PersonID = TxtPersonID.Text
End Sub

Private Sub TxtUmur_Change()
    MyBioData.Umur = TxtUmur.Text
End Sub


