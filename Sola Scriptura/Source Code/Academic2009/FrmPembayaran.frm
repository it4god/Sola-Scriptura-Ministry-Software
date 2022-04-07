VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmPembayaran 
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
   Begin VB.ComboBox CboTanggal_Day 
      Height          =   315
      Left            =   5280
      Style           =   2  'Dropdown List
      TabIndex        =   2
      Top             =   6480
      Width           =   855
   End
   Begin VB.ComboBox CboTanggal_Month 
      Height          =   315
      Left            =   6240
      Style           =   2  'Dropdown List
      TabIndex        =   3
      Top             =   6480
      Width           =   855
   End
   Begin VB.ComboBox CboTanggal_Year 
      Height          =   315
      Left            =   7200
      Style           =   2  'Dropdown List
      TabIndex        =   4
      Top             =   6480
      Width           =   1275
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
      TabIndex        =   18
      Top             =   360
      Width           =   7987
   End
   Begin VB.ComboBox CboKeterangan 
      Height          =   315
      ItemData        =   "FrmPembayaran.frx":0000
      Left            =   5280
      List            =   "FrmPembayaran.frx":0010
      Locked          =   -1  'True
      TabIndex        =   6
      Top             =   6960
      Width           =   3195
   End
   Begin VB.TextBox TxtJumlah 
      BackColor       =   &H00FFFFFF&
      Height          =   285
      Left            =   10560
      Locked          =   -1  'True
      TabIndex        =   5
      Top             =   6480
      Width           =   3195
   End
   Begin VB.TextBox TxtDeskripsi 
      Height          =   285
      Left            =   5280
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   6000
      Width           =   8475
   End
   Begin MSDataGridLib.DataGrid DataGridPembayaran 
      Height          =   3975
      Left            =   3360
      TabIndex        =   0
      Top             =   1320
      Width           =   10335
      _ExtentX        =   18230
      _ExtentY        =   7011
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
            Type            =   0
            Format          =   ""
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
   Begin VB.Image Image2 
      Height          =   1575
      Left            =   600
      Picture         =   "FrmPembayaran.frx":003C
      Stretch         =   -1  'True
      Top             =   5640
      Width           =   1755
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Yang harus dibayar : "
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
      Left            =   5520
      TabIndex        =   30
      Top             =   5400
      Width           =   1935
   End
   Begin VB.Label lblBiaya 
      BackStyle       =   0  'Transparent
      Caption         =   "0"
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
      Left            =   7560
      TabIndex        =   29
      Top             =   5400
      Width           =   1095
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
      TabIndex        =   28
      Top             =   3840
      Width           =   1605
   End
   Begin VB.Label lblTotal 
      BackStyle       =   0  'Transparent
      Caption         =   "0"
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
      Left            =   12240
      TabIndex        =   27
      Top             =   5400
      Width           =   1455
   End
   Begin VB.Line Line1 
      BorderColor     =   &H8000000E&
      X1              =   3267.901
      X2              =   13071.61
      Y1              =   4058.48
      Y2              =   4058.48
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Total :"
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
      Left            =   11640
      TabIndex        =   26
      Top             =   5400
      Width           =   615
   End
   Begin VB.Label LblTanggal 
      BackStyle       =   0  'Transparent
      Caption         =   "Tanggal"
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
      Left            =   3480
      TabIndex        =   25
      Top             =   6480
      Width           =   1935
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
      Left            =   5640
      TabIndex        =   24
      Top             =   7560
      Width           =   1965
   End
   Begin VB.Label lblDelete 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Delete"
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
      Left            =   7920
      TabIndex        =   23
      Top             =   7560
      Width           =   1965
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
      TabIndex        =   22
      Top             =   7560
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
      TabIndex        =   21
      Top             =   7560
      Width           =   1965
   End
   Begin VB.Label lblAddNew 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Add New"
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
      TabIndex        =   20
      Top             =   7560
      Width           =   1965
   End
   Begin VB.Label lblTitlePembayaran 
      BackStyle       =   0  'Transparent
      Caption         =   "Pembayaran"
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
      Left            =   12120
      TabIndex        =   19
      Top             =   600
      Width           =   2685
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
      TabIndex        =   17
      Top             =   3120
      Width           =   1605
   End
   Begin VB.Label LblKeterangan 
      BackStyle       =   0  'Transparent
      Caption         =   "Keterangan"
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
      Left            =   3480
      TabIndex        =   16
      Top             =   6960
      Width           =   1935
   End
   Begin VB.Label LblNamaMataKuliah 
      BackStyle       =   0  'Transparent
      Caption         =   "Jumlah"
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
      Left            =   8760
      TabIndex        =   15
      Top             =   6480
      Width           =   1935
   End
   Begin VB.Label LblDeskripsi 
      BackStyle       =   0  'Transparent
      Caption         =   "Deskripsi"
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
      Left            =   3480
      TabIndex        =   14
      Top             =   6000
      Width           =   1935
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
      TabIndex        =   13
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
      TabIndex        =   12
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
      TabIndex        =   11
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
      TabIndex        =   10
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
      TabIndex        =   9
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
      TabIndex        =   8
      Top             =   2040
      Width           =   1605
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmPembayaran.frx":1221
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11880
      Picture         =   "FrmPembayaran.frx":1D3D
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
      TabIndex        =   7
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmPembayaran.frx":2827
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmPembayaran.frx":3185
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image ImgSuamiIstri 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPembayaran.frx":3BC6
      Stretch         =   -1  'True
      Top             =   3000
      Width           =   2250
   End
   Begin VB.Image ImgAdikKakak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPembayaran.frx":4963
      Stretch         =   -1  'True
      Top             =   2640
      Width           =   2250
   End
   Begin VB.Image ImgPendidikan 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPembayaran.frx":5700
      Stretch         =   -1  'True
      Top             =   3720
      Width           =   2250
   End
   Begin VB.Image ImgPrestasi 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPembayaran.frx":649D
      Stretch         =   -1  'True
      Top             =   3360
      Width           =   2250
   End
   Begin VB.Image ImgAnak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPembayaran.frx":723A
      Stretch         =   -1  'True
      Top             =   2280
      Width           =   2250
   End
   Begin VB.Image ImgOrangtua 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPembayaran.frx":7FD7
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   2250
   End
   Begin VB.Image ImgBioData 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPembayaran.frx":8D74
      Stretch         =   -1  'True
      Top             =   1200
      Width           =   2250
   End
   Begin VB.Image ImgAlamat 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPembayaran.frx":9B11
      Stretch         =   -1  'True
      Top             =   1560
      Width           =   2250
   End
   Begin VB.Image ImgChurchData 
      Height          =   495
      Left            =   360
      Picture         =   "FrmPembayaran.frx":A8AE
      Stretch         =   -1  'True
      Top             =   7320
      Width           =   2250
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmPembayaran.frx":B64B
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image Image5 
      Height          =   495
      Left            =   10920
      Picture         =   "FrmPembayaran.frx":6C855
      Top             =   7440
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   13080
      Picture         =   "FrmPembayaran.frx":6D349
      Top             =   7440
      Width           =   1980
   End
   Begin VB.Image ImgAddNew 
      Height          =   495
      Left            =   3360
      Picture         =   "FrmPembayaran.frx":6DE3D
      Top             =   7440
      Width           =   1980
   End
   Begin VB.Image Image3 
      Height          =   495
      Left            =   7920
      Picture         =   "FrmPembayaran.frx":6E931
      Top             =   7440
      Width           =   1980
   End
   Begin VB.Image Image6 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmPembayaran.frx":6F425
      Top             =   7440
      Width           =   1980
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmPembayaran.frx":6FF19
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmPembayaran"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim myPembayaran As Pembayaran
Dim myPembayaranBuffer As Pembayaran_Buffer
Dim myitem As ClsItemServer
Dim rsPembayaran As ADODB.Recordset
Dim TotalPembayaran As Double
Dim TotalBiaya As Double
Dim BiayaPerSKS As Double
Dim JumlahSKS As Double
Dim rsBiayaPerSKS As ADODB.Recordset
Private Sub CboKeterangan_Change()
    myPembayaran.Keterangan = CboKeterangan.Text
    
End Sub

Private Sub CboKeterangan_Click()
     myPembayaran.Keterangan = CboKeterangan.Text
End Sub

Private Sub CboTanggal_Day_Click()
       Dim tanggal_day As String
    Dim tanggal_month As String
    If Len(CboTanggal_Day.Text) = 1 Then
        tanggal_day = "0" + CboTanggal_Day.Text
    Else
        tanggal_day = CboTanggal_Day.Text
    End If
    If Len(CboTanggal_Month.Text) = 1 Then
        tanggal_month = "0" + CboTanggal_Month.Text
    Else
        tanggal_month = CboTanggal_Month.Text
        
    End If
    If CboTanggal_Day.Text <> "" And CboTanggal_Month.Text <> "" And CboTanggal_Year.Text <> "" Then
       myPembayaran.Tanggal = tanggal_day + "/" + tanggal_month + "/" + CboTanggal_Year.Text
    Else
        myPembayaran.Tanggal = ""
    End If
    
    
End Sub

Private Sub CboTanggal_Month_Click()
        Dim tanggal_day As String
    Dim tanggal_month As String
    If Len(CboTanggal_Day.Text) = 1 Then
        tanggal_day = "0" + CboTanggal_Day.Text
    Else
        tanggal_day = CboTanggal_Day.Text
    End If
    If Len(CboTanggal_Month.Text) = 1 Then
        tanggal_month = "0" + CboTanggal_Month.Text
    Else
        tanggal_month = CboTanggal_Month.Text
        
    End If
        If CboTanggal_Day.Text <> "" And CboTanggal_Month.Text <> "" And CboTanggal_Year.Text <> "" Then
       myPembayaran.Tanggal = tanggal_day + "/" + tanggal_month + "/" + CboTanggal_Year.Text
    Else
        myPembayaran.Tanggal = ""
    End If
End Sub

Private Sub CboTanggal_Year_Click()
       Dim tanggal_day As String
    Dim tanggal_month As String
    If Len(CboTanggal_Day.Text) = 1 Then
        tanggal_day = "0" + CboTanggal_Day.Text
    Else
        tanggal_day = CboTanggal_Day.Text
    End If
    If Len(CboTanggal_Month.Text) = 1 Then
        tanggal_month = "0" + CboTanggal_Month.Text
    Else
        tanggal_month = CboTanggal_Month.Text
        
    End If
    If CboTanggal_Day.Text <> "" And CboTanggal_Month.Text <> "" And CboTanggal_Year.Text <> "" Then
       myPembayaran.Tanggal = tanggal_day + "/" + tanggal_month + "/" + CboTanggal_Year.Text
    Else
        myPembayaran.Tanggal = ""
    End If
End Sub

Private Sub Form_Load()
    CenterChildForm Me

  
    TxtIndentity.Text = "NIM = " & Trim(CurrentMahasiswa.NIM) & " , " & Trim(CurrentMahasiswa.Nama_Awal) & " " & Trim(CurrentMahasiswa.Nama_Akhir) & vbCrLf & "Periode : " & strperiode
    Set myitem = New ClsItemServer
    Set rsPembayaran = myitem.GetPembayaran(Periode, Trim(CurrentMahasiswa.NIM))
    Set DataGridPembayaran.DataSource = rsPembayaran
    DataGridPembayaran.Columns(0).Width = 1000
    DataGridPembayaran.Columns(1).Width = 3000
    DataGridPembayaran.Columns(2).Width = 1200
    DataGridPembayaran.Columns(3).Width = 1500
    DataGridPembayaran.Columns(4).Width = 1500
    If rsPembayaran.RecordCount > 0 Then
        lblEdit.Enabled = True
        lblDelete.Enabled = True
    Else
        lblEdit.Enabled = False
        lblDelete.Enabled = False
    End If
    Dim counter As Long
    For counter = 1 To 31
        CboTanggal_Day.AddItem (counter)
    Next counter
    For counter = 1 To 12
        CboTanggal_Month.AddItem (counter)
    Next counter
    For counter = 1998 To 2200
        CboTanggal_Year.AddItem (counter)
    Next counter
    TotalPembayaran = 0
    If rsPembayaran.RecordCount > 0 Then
        rsPembayaran.MoveFirst
        TotalPembayaran = 0
        While Not rsPembayaran.EOF
            If IsNumeric(Trim(rsPembayaran.Fields("Jumlah"))) Then
                TotalPembayaran = TotalPembayaran + CDbl(Trim(rsPembayaran.Fields("Jumlah")))
                
            End If
            rsPembayaran.MoveNext
        Wend
        rsPembayaran.MoveFirst
    End If
    
    Call DotKoma((Trim(TotalPembayaran)))
    
    Set myitem = New ClsItemServer
    Set rsBiayaPerSKS = myitem.GetTotalBiaya(Trim(CurrentMahasiswa.Program))
    If rsBiayaPerSKS.EOF Then
        BiayaPerSKS = 75000
    Else
        BiayaPerSKS = CDbl(Trim(rsBiayaPerSKS.Fields(0).Value))
    End If
    
    Dim myTotalSKS As ADODB.Recordset
    Set myitem = New ClsItemServer
    Set myTotalSKS = myitem.GetTotalSKS(Periode, Trim(CurrentMahasiswa.NIM))
    
    JumlahSKS = 0
    If myTotalSKS.RecordCount > 0 Then
        myTotalSKS.MoveFirst
        While Not myTotalSKS.EOF
               JumlahSKS = JumlahSKS + CDbl(myTotalSKS.Fields("SKS"))
              
                
            myTotalSKS.MoveNext
            
        Wend

    End If
    Call DotKoma2(Trim(BiayaPerSKS * JumlahSKS))
    
    
End Sub





Private Sub imgQuit_Click()
Unload Me
End Sub



Private Sub lblAddNew_Click()
    lblAddNew.Enabled = False
    lblEdit.Enabled = False
    lblDelete.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    TxtDeskripsi.Text = ""
    TxtDeskripsi.Locked = False
    TxtDeskripsi.BackColor = vbYellow
    TxtJumlah.Text = ""
    TxtJumlah.Locked = False
    TxtJumlah.BackColor = vbYellow
    CboKeterangan.Text = ""
    CboKeterangan.Locked = False
    CboKeterangan.BackColor = vbYellow
    CboTanggal_Day.Text = Trim(Day(Date))
    CboTanggal_Day.Locked = False
    CboTanggal_Day.BackColor = vbYellow
    CboTanggal_Month.Text = Trim(Month(Date))
    CboTanggal_Month.Locked = False
    CboTanggal_Month.BackColor = vbYellow
    CboTanggal_Year.Text = Trim(Year(Date))
    CboTanggal_Year.Locked = False
    CboTanggal_Year.BackColor = vbYellow
    
    Dim tanggal_day As String
    Dim tanggal_month As String
    If Len(CboTanggal_Day.Text) = 1 Then
        tanggal_day = "0" + CboTanggal_Day.Text
    Else
        tanggal_day = CboTanggal_Day.Text
    End If
    If Len(CboTanggal_Month.Text) = 1 Then
        tanggal_month = "0" + CboTanggal_Month.Text
    Else
        tanggal_month = CboTanggal_Month.Text
        
    End If
    If CboTanggal_Day.Text <> "" And CboTanggal_Month.Text <> "" And CboTanggal_Year.Text <> "" Then
       myPembayaran.Tanggal = tanggal_day + "/" + tanggal_month + "/" + CboTanggal_Year.Text
    Else
        myPembayaran.Tanggal = ""
    End If

    
    
    myPembayaran.Deskripsi = ""
    myPembayaran.PembayaranNo = ""
    myPembayaran.Jumlah = ""
    myPembayaran.NIM = Trim(CurrentMahasiswa.NIM)
    myPembayaran.Periode = Trim(Periode)
    myPembayaran.Keterangan = ""
End Sub

Private Sub lblCancel_Click()
    lblAddNew.Enabled = True
    lblSave.Enabled = False
    lblCancel.Enabled = False
    Set myitem = New ClsItemServer
    Set rsPembayaran = myitem.GetPembayaran(Periode, Trim(CurrentMahasiswa.NIM))
    Set DataGridPembayaran.DataSource = rsPembayaran
    DataGridPembayaran.Columns(0).Width = 1000
    DataGridPembayaran.Columns(1).Width = 3000
    DataGridPembayaran.Columns(2).Width = 1200
    DataGridPembayaran.Columns(3).Width = 1500
    DataGridPembayaran.Columns(4).Width = 1500
    If rsPembayaran.RecordCount > 0 Then
        lblEdit.Enabled = True
        lblDelete.Enabled = True
    Else
        lblEdit.Enabled = False
        lblDelete.Enabled = False
    End If
    
    TotalPembayaran = 0
    If rsPembayaran.RecordCount > 0 Then
        rsPembayaran.MoveFirst
        TotalPembayaran = 0
        While Not rsPembayaran.EOF
            If IsNumeric(Trim(rsPembayaran.Fields("Jumlah"))) Then
                TotalPembayaran = TotalPembayaran + CDbl(Trim(rsPembayaran.Fields("Jumlah")))
                
            End If
           rsPembayaran.MoveNext
        Wend
        rsPembayaran.MoveFirst
    End If
    
     Call DotKoma((Trim(TotalPembayaran)))
    
    TxtDeskripsi.Text = ""
    TxtDeskripsi.Locked = True
    TxtDeskripsi.BackColor = vbWhite
    TxtJumlah.Text = ""
    TxtJumlah.Locked = True
    TxtJumlah.BackColor = vbWhite
    CboKeterangan.Text = ""
    CboKeterangan.Locked = True
    CboKeterangan.BackColor = vbWhite
    CboTanggal_Day.Locked = True
    CboTanggal_Day.BackColor = vbWhite
    CboTanggal_Month.Locked = True
    CboTanggal_Month.BackColor = vbWhite
    CboTanggal_Year.Locked = True
    CboTanggal_Year.BackColor = vbWhite
End Sub

Private Sub LblDelete_Click()
On Error GoTo deleteerror:
        Set myitem = New ClsItemServer
        
     Dim iresponse As Long
        Dim saskUSER As String
        saskUSER = "Are you sure want to delete Pembayaran Data with Deskripsi  = " & Trim(DataGridPembayaran.Columns(1).Value) & " ?"
        iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Delete Pembayaran")
        Dim deleteok As Boolean
        deleteok = False
        If (iresponse = vbYes) Then
            deleteok = myitem.DeletePembayaran(Trim(DataGridPembayaran.Columns(0).Value))
        End If
        If deleteok = True Then
           
            MsgBox "Pembayaran Data deleted !", vbInformation, "Data Deleted !"
            Set myitem = New ClsItemServer
            Set rsPembayaran = myitem.GetPembayaran(Periode, Trim(CurrentMahasiswa.NIM))
            Set DataGridPembayaran.DataSource = rsPembayaran
            DataGridPembayaran.Columns(0).Width = 1000
            DataGridPembayaran.Columns(1).Width = 3000
            DataGridPembayaran.Columns(2).Width = 1200
            DataGridPembayaran.Columns(3).Width = 1500
            DataGridPembayaran.Columns(4).Width = 1500
            If rsPembayaran.RecordCount > 0 Then
                lblEdit.Enabled = True
                lblDelete.Enabled = True
            Else
                lblEdit.Enabled = False
                lblDelete.Enabled = False
            End If
            TotalPembayaran = 0
            If rsPembayaran.RecordCount > 0 Then
                rsPembayaran.MoveFirst
                TotalPembayaran = 0
                While Not rsPembayaran.EOF
                    If IsNumeric(Trim(rsPembayaran.Fields("Jumlah"))) Then
                        TotalPembayaran = TotalPembayaran + CDbl(Trim(rsPembayaran.Fields("Jumlah")))
                        
                    End If
                      rsPembayaran.MoveNext
                Wend
                rsPembayaran.MoveFirst
            End If
            
                Call DotKoma((Trim(TotalPembayaran)))
            
        End If
        Exit Sub
deleteerror:
    MsgBox "Please Delete All Data linked to this person before you delete", vbInformation, "Error !"
End Sub

Private Sub lblEdit_Click()
    lblEdit.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    lblDelete.Enabled = False
    lblAddNew.Enabled = False
    myPembayaran.PembayaranNo = Trim(DataGridPembayaran.Columns(0).Value)
    myPembayaran.Deskripsi = Trim(DataGridPembayaran.Columns(1).Value)
    myPembayaran.Tanggal = Trim(DataGridPembayaran.Columns(2).Value)
    myPembayaran.Jumlah = Trim(DataGridPembayaran.Columns(3).Value)
    myPembayaran.Keterangan = Trim(DataGridPembayaran.Columns(4).Value)
    myPembayaran.NIM = Trim(CurrentMahasiswa.NIM)
    myPembayaran.Periode = Trim(Periode)
    
    
        Dim tgl_day As String
        Dim tgl_month As String
        Dim tgl_year As String
        Dim tgl As String
        tgl = myPembayaran.Tanggal
        If IsDate((Trim(myPembayaran.Tanggal))) = True Then
            If Left(Mid(Trim(tgl), 1, 2), 1) = "0" Then
                tgl_day = Mid(Trim(tgl), 2, 1)
                
            Else
                tgl_day = Mid(Trim(tgl), 1, 2)
            End If
            tgl = myPembayaran.Tanggal
            If Left(Mid(Trim(tgl), 4, 2), 1) = "0" Then
                 tgl_month = Mid(Trim(tgl), 5, 1)
            Else
                 tgl_month = Mid(Trim(tgl), 4, 2)
            End If
            tgl = myPembayaran.Tanggal
            tgl_year = Mid(Trim(myPembayaran.Tanggal), 7, 4)
            CboTanggal_Day.Text = tgl_day
            CboTanggal_Month.Text = tgl_month
            CboTanggal_Year.Text = tgl_year
            
        End If
    
    
    TxtDeskripsi.Text = Trim(DataGridPembayaran.Columns(1).Value)
    TxtJumlah.Text = Trim(DataGridPembayaran.Columns(3).Value)
    CboKeterangan.Text = Trim(DataGridPembayaran.Columns(4).Value)
    
    
    TxtDeskripsi.Locked = False
    TxtDeskripsi.BackColor = vbYellow
    TxtJumlah.Locked = False
    TxtJumlah.BackColor = vbYellow
    CboKeterangan.Locked = False
    CboKeterangan.BackColor = vbYellow
    CboTanggal_Day.Locked = False
    CboTanggal_Day.BackColor = vbYellow
    CboTanggal_Month.Locked = False
    CboTanggal_Month.BackColor = vbYellow
    CboTanggal_Year.Locked = False
    CboTanggal_Year.BackColor = vbYellow
End Sub






Private Sub lblSave_Click()
If IsNumeric(Trim(myPembayaran.Jumlah)) Then

    Dim saveok As Boolean
    saveok = False
    LSet myPembayaranBuffer = myPembayaran
    Set myitem = New ClsItemServer
    
    saveok = myitem.savePembayaran(myPembayaranBuffer.Buffer, UpdateUser)
    If saveok = True Then
        
        MsgBox "Save Pembayaran successfully !", vbInformation, "Information"
        lblAddNew.Enabled = True
        lblSave.Enabled = False
        lblCancel.Enabled = False
    
        Set myitem = New ClsItemServer
        Set rsPembayaran = myitem.GetPembayaran(Periode, Trim(CurrentMahasiswa.NIM))
        Set DataGridPembayaran.DataSource = rsPembayaran
        DataGridPembayaran.Columns(0).Width = 1000
        DataGridPembayaran.Columns(1).Width = 3000
        DataGridPembayaran.Columns(2).Width = 1200
        DataGridPembayaran.Columns(3).Width = 1500
        DataGridPembayaran.Columns(4).Width = 1500
        TxtDeskripsi.Locked = True
        TxtDeskripsi.BackColor = vbWhite
        TxtJumlah.Locked = True
        TxtJumlah.BackColor = vbWhite
        CboKeterangan.Locked = True
        CboKeterangan.BackColor = vbWhite
        CboTanggal_Day.Locked = True
        CboTanggal_Day.BackColor = vbWhite
        CboTanggal_Month.Locked = True
        CboTanggal_Month.BackColor = vbWhite
        CboTanggal_Year.Locked = True
        CboTanggal_Year.BackColor = vbWhite
        lblAddNew.Enabled = True
        lblSave.Enabled = False
        lblCancel.Enabled = False
            If rsPembayaran.RecordCount > 0 Then
                lblEdit.Enabled = True
                lblDelete.Enabled = True
            Else
                lblEdit.Enabled = False
                lblDelete.Enabled = False
            End If
        TotalPembayaran = 0
            If rsPembayaran.RecordCount > 0 Then
                rsPembayaran.MoveFirst
                TotalPembayaran = 0
                While Not rsPembayaran.EOF
                    If IsNumeric(Trim(rsPembayaran.Fields("Jumlah"))) Then
                        TotalPembayaran = TotalPembayaran + CDbl(Trim(rsPembayaran.Fields("Jumlah")))
                        
                    End If
                      rsPembayaran.MoveNext
                Wend
                rsPembayaran.MoveFirst
            End If
            
                Call DotKoma((Trim(TotalPembayaran)))
    Else
        MsgBox "Save Pembayaran unsuccessfully !", vbInformation, "Information"
    
    End If
Else
        MsgBox "Please fill the 'Jumlah' with Numeric Value !", vbInformation, "Information"
End If
End Sub


Private Sub TxtDeskripsi_Change()
    myPembayaran.Deskripsi = Trim(TxtDeskripsi.Text)
End Sub

Private Sub Txtjumlah_Change()
    myPembayaran.Jumlah = Trim(TxtJumlah.Text)
End Sub

Private Sub DotKoma(JumlahTotal As String)

        If Len(JumlahTotal) >= 4 And Len(JumlahTotal) < 7 Then
            
            lblTotal.Caption = Mid(JumlahTotal, 1, Len(JumlahTotal) - 3) & "." & Right(JumlahTotal, 3)
        ElseIf Len(JumlahTotal) >= 7 And Len(JumlahTotal) < 10 Then
            lblTotal.Caption = Mid(JumlahTotal, 1, Len(JumlahTotal) - 6) & "." & Mid(Right(JumlahTotal, 6), 1, 3) & "." & Right(JumlahTotal, 3)
        ElseIf Len(JumlahTotal) >= 10 And Len(JumlahTotal) < 13 Then
            lblTotal.Caption = Mid(JumlahTotal, 1, Len(JumlahTotal) - 9) & "." & Mid(Right(JumlahTotal, 9), 1, 3) & "." & Mid(Right(JumlahTotal, 6), 1, 3) & "." & Right(JumlahTotal, 3)
        ElseIf Len(JumlahTotal) >= 13 And Len(JumlahTotal) < 16 Then
            lblTotal.Caption = Mid(JumlahTotal, 1, Len(JumlahTotal) - 12) & "." & Mid(Right(JumlahTotal, 12), 1, 3) & "." & Mid(Right(JumlahTotal, 9), 1, 3) & "." & Mid(Right(JumlahTotal, 6), 1, 3) & "." & Right(JumlahTotal, 3)
        ElseIf Len(JumlahTotal) > 15 Then
            MsgBox "Number is too big !", vbInformation, "Please enter smaller number"
        Else
        
        End If
End Sub
Private Sub DotKoma2(JumlahTotal As String)

        If Len(JumlahTotal) >= 4 And Len(JumlahTotal) < 7 Then
            
            LblBiaya.Caption = Mid(JumlahTotal, 1, Len(JumlahTotal) - 3) & "." & Right(JumlahTotal, 3)
        ElseIf Len(JumlahTotal) >= 7 And Len(JumlahTotal) < 10 Then
            LblBiaya.Caption = Mid(JumlahTotal, 1, Len(JumlahTotal) - 6) & "." & Mid(Right(JumlahTotal, 6), 1, 3) & "." & Right(JumlahTotal, 3)
        ElseIf Len(JumlahTotal) >= 10 And Len(JumlahTotal) < 13 Then
            LblBiaya.Caption = Mid(JumlahTotal, 1, Len(JumlahTotal) - 9) & "." & Mid(Right(JumlahTotal, 9), 1, 3) & "." & Mid(Right(JumlahTotal, 6), 1, 3) & "." & Right(JumlahTotal, 3)
        ElseIf Len(JumlahTotal) >= 13 And Len(JumlahTotal) < 16 Then
            LblBiaya.Caption = Mid(JumlahTotal, 1, Len(JumlahTotal) - 12) & "." & Mid(Right(JumlahTotal, 12), 1, 3) & "." & Mid(Right(JumlahTotal, 9), 1, 3) & "." & Mid(Right(JumlahTotal, 6), 1, 3) & "." & Right(JumlahTotal, 3)
        ElseIf Len(JumlahTotal) > 15 Then
            MsgBox "Number is too big !", vbInformation, "Please enter smaller number"
        Else
        
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

