VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmTranskrip 
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
   Begin VB.TextBox TxtIndentity 
      Alignment       =   2  'Center
      BackColor       =   &H80000006&
      ForeColor       =   &H80000005&
      Height          =   495
      Left            =   2880
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   9
      Top             =   360
      Width           =   7987
   End
   Begin MSDataGridLib.DataGrid DataGridTranskrip 
      Height          =   6015
      Left            =   3360
      TabIndex        =   10
      Top             =   1320
      Width           =   10335
      _ExtentX        =   18230
      _ExtentY        =   10610
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
      Picture         =   "FrmTranskrip.frx":0000
      Stretch         =   -1  'True
      Top             =   5640
      Width           =   1755
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
      TabIndex        =   12
      Top             =   3840
      Width           =   1605
   End
   Begin VB.Label lblTitleTranskrip 
      BackStyle       =   0  'Transparent
      Caption         =   "Transkrip"
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
      TabIndex        =   11
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
      TabIndex        =   8
      Top             =   3120
      Width           =   1605
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
      TabIndex        =   7
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
      TabIndex        =   6
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
      TabIndex        =   5
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
      TabIndex        =   4
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
      TabIndex        =   3
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
      TabIndex        =   2
      Top             =   2040
      Width           =   1605
   End
   Begin VB.Label lblPrint 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Print"
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
      TabIndex        =   0
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Image ImgEdit 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmTranskrip.frx":11E5
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmTranskrip.frx":1CD9
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11880
      Picture         =   "FrmTranskrip.frx":27F5
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
      TabIndex        =   1
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmTranskrip.frx":32DF
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmTranskrip.frx":3C3D
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image ImgSuamiIstri 
      Height          =   375
      Left            =   360
      Picture         =   "FrmTranskrip.frx":467E
      Stretch         =   -1  'True
      Top             =   3000
      Width           =   2250
   End
   Begin VB.Image ImgAdikKakak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmTranskrip.frx":541B
      Stretch         =   -1  'True
      Top             =   2640
      Width           =   2250
   End
   Begin VB.Image ImgPendidikan 
      Height          =   375
      Left            =   360
      Picture         =   "FrmTranskrip.frx":61B8
      Stretch         =   -1  'True
      Top             =   3720
      Width           =   2250
   End
   Begin VB.Image ImgPrestasi 
      Height          =   375
      Left            =   360
      Picture         =   "FrmTranskrip.frx":6F55
      Stretch         =   -1  'True
      Top             =   3360
      Width           =   2250
   End
   Begin VB.Image ImgAnak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmTranskrip.frx":7CF2
      Stretch         =   -1  'True
      Top             =   2280
      Width           =   2250
   End
   Begin VB.Image ImgOrangtua 
      Height          =   375
      Left            =   360
      Picture         =   "FrmTranskrip.frx":8A8F
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   2250
   End
   Begin VB.Image ImgBioData 
      Height          =   375
      Left            =   360
      Picture         =   "FrmTranskrip.frx":982C
      Stretch         =   -1  'True
      Top             =   1200
      Width           =   2250
   End
   Begin VB.Image ImgAlamat 
      Height          =   375
      Left            =   360
      Picture         =   "FrmTranskrip.frx":A5C9
      Stretch         =   -1  'True
      Top             =   1560
      Width           =   2250
   End
   Begin VB.Image ImgChurchData 
      Height          =   495
      Left            =   360
      Picture         =   "FrmTranskrip.frx":B366
      Stretch         =   -1  'True
      Top             =   7320
      Width           =   2250
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmTranskrip.frx":C103
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmTranskrip.frx":6D30D
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmTranskrip"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim MyMataKuliahMahasiswa As MataKuliahMahasiswa
Dim MyMataKuliahMahasiswaBuffer As MataKuliahMahasiswa_Buffer
Dim myitem As ClsItemServer
Dim rsTranskrip As ADODB.Recordset




Private Sub Form_Load()
    CenterChildForm Me

  
    TxtIndentity.Text = "NIM = " & Trim(CurrentMahasiswa.NIM) & " , " & Trim(CurrentMahasiswa.Nama_Awal) & " " & Trim(CurrentMahasiswa.Nama_Akhir) & vbCrLf & "Periode : " & strperiode
    Set myitem = New ClsItemServer
    Set rsTranskrip = myitem.GetTranskrip(Trim(CurrentMahasiswa.NIM))
    Set DataGridTranskrip.DataSource = rsTranskrip
    DataGridTranskrip.Columns(0).Width = 1000
    DataGridTranskrip.Columns(1).Width = 3000
    DataGridTranskrip.Columns(2).Width = 800
    DataGridTranskrip.Columns(3).Width = 800
    DataGridTranskrip.Columns(4).Width = 800
    DataGridTranskrip.Columns(5).Width = 800
    DataGridTranskrip.Columns(6).Width = 1000
    
    
End Sub

Private Sub imgQuit_Click()
Unload Me
End Sub










Private Sub lblPrint_Click()
Dim TranskripReport As DataReportTranskrip
Set TranskripReport = New DataReportTranskrip
Set TranskripReport.DataSource = rsTranskrip

Dim myreportlabel(1 To 9) As RptLabel
    Dim x As Integer
    For x = 1 To 9
        Set myreportlabel(x) = TranskripReport.Sections(1).Controls.Item(x)
    Next x
'myreportlabel(1).Caption = "1"
myreportlabel(2).Caption = Trim(CurrentMahasiswa.NIM)
myreportlabel(3).Caption = Trim(CurrentMahasiswa.Nama_Awal) & " " & Trim(CurrentMahasiswa.Nama_Akhir)
myreportlabel(4).Caption = Trim(CurrentMahasiswa.Program)
myreportlabel(5).Caption = Trim(CurrentMahasiswa.PeriodeMasuk)
'myreportlabel(6).Caption = "6"
'myreportlabel(7).Caption = "7"
'myreportlabel(8).Caption = "8"
'myreportlabel(9).Caption = "9"

Dim myreportlabel_2(1 To 12) As RptLabel
    For x = 1 To 12
        Set myreportlabel_2(x) = TranskripReport.Sections(5).Controls.Item(x)
    Next x



Dim SKSKumulatif As Double
Dim NilaiKumulatif As Double
Dim IPKumulatif As Double

Dim myTranskrip As ADODB.Recordset
Set myitem = New ClsItemServer

Dim myTranskripKumulatif As ADODB.Recordset
Set myitem = New ClsItemServer
Set myTranskripKumulatif = myitem.GetTranskripKumulatif(Trim(CurrentMahasiswa.NIM))

SKSKumulatif = 0
NilaiKumulatif = 0
IPKumulatif = 0

If myTranskripKumulatif.RecordCount > 0 Then
    myTranskripKumulatif.MoveFirst
    While Not myTranskripKumulatif.EOF
        If Trim(myTranskripKumulatif.Fields("Grade")) <> "Pd" Then
            SKSKumulatif = SKSKumulatif + CDbl(myTranskripKumulatif.Fields("SKS"))
            NilaiKumulatif = NilaiKumulatif + CDbl(myTranskripKumulatif.Fields("Nilai"))
            
        End If
        myTranskripKumulatif.MoveNext
        
    Wend
    If SKSKumulatif = 0 Then
        IPKumulatif = 0
    Else
        IPKumulatif = NilaiKumulatif / SKSKumulatif
    End If
End If

Dim myIPkumulatif As String

Dim a As Integer

a = InStr(1, CStr(IPKumulatif), ",", vbTextCompare)
If a = 0 Then
    myIPkumulatif = CStr(IPKumulatif) & ",0"
Else
    myIPkumulatif = Mid(CStr(IPKumulatif), 1, a + 2)
    
End If

myreportlabel_2(1).Caption = Trim(SKSKumulatif)
myreportlabel_2(2).Caption = Trim(NilaiKumulatif)
myreportlabel_2(3).Caption = Trim(myIPkumulatif)
'myreportlabel_2(4).Caption = "4"
'myreportlabel_2(5).Caption = "5"
'myreportlabel_2(6).Caption = "6"
'myreportlabel_2(7).Caption = Trim(JumlahSKS)
'myreportlabel_2(8).Caption = Trim(JumlahNilai)
'myreportlabel_2(9).Caption = Trim(IP)
'myreportlabel_2(10).Caption = "10"
'myreportlabel_2(11).Caption = "11"
'myreportlabel_2(12).Caption = "12"


TranskripReport.Show


End Sub

Private Sub lblMnuBIOData_Click()
    Unload Me
    frmBioData.Show
End Sub

Private Sub lblMnuTranskrip_Click()
    Unload Me
    frmTranskrip.Show
End Sub

Private Sub lblMnuKRS_Click()
    Unload Me
    frmKRS.Show
End Sub
Private Sub lblMnuMasukNilai_Click()
    Unload Me
    frmMasukNilai.Show
End Sub
Private Sub lblMnuKHS_Click()
    Unload Me
    frmKHS.Show
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
