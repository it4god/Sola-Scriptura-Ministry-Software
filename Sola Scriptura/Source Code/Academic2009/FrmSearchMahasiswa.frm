VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form FrmSearchMahasiswa 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00DC7F59&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Cari Mahasiswa"
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
   Begin VB.TextBox TxtIndentity 
      Alignment       =   2  'Center
      BackColor       =   &H80000006&
      ForeColor       =   &H80000005&
      Height          =   495
      Left            =   360
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   9
      Text            =   "FrmSearchMahasiswa.frx":0000
      Top             =   3480
      Width           =   9420
   End
   Begin MSDataGridLib.DataGrid DataGridSearchMahasiswa 
      Height          =   3375
      Left            =   720
      TabIndex        =   6
      Top             =   4440
      Width           =   9735
      _ExtentX        =   17171
      _ExtentY        =   5953
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
   Begin VB.TextBox TxtNIM 
      Height          =   285
      Left            =   1800
      TabIndex        =   1
      Top             =   240
      Width           =   3255
   End
   Begin VB.TextBox TxtNamaAwal 
      Height          =   285
      Left            =   1800
      TabIndex        =   2
      Top             =   720
      Width           =   3255
   End
   Begin VB.TextBox TxtNamaAkhir 
      Height          =   285
      Left            =   6960
      TabIndex        =   3
      Top             =   720
      Width           =   3255
   End
   Begin VB.Image Image8 
      Height          =   1215
      Left            =   8040
      Picture         =   "FrmSearchMahasiswa.frx":0037
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   1695
   End
   Begin VB.Image Image7 
      Height          =   1215
      Left            =   6120
      Picture         =   "FrmSearchMahasiswa.frx":1589
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   1695
   End
   Begin VB.Image Image6 
      Height          =   1215
      Left            =   4200
      Picture         =   "FrmSearchMahasiswa.frx":2104
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   1695
   End
   Begin VB.Image Image5 
      Height          =   1215
      Left            =   2280
      Picture         =   "FrmSearchMahasiswa.frx":1B66B
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   1695
   End
   Begin VB.Image Image1 
      Height          =   1215
      Left            =   360
      Picture         =   "FrmSearchMahasiswa.frx":1EA4B
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   1695
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   11040
      Picture         =   "FrmSearchMahasiswa.frx":1FC30
      Top             =   960
      Width           =   645
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   11040
      Picture         =   "FrmSearchMahasiswa.frx":20671
      Top             =   120
      Width           =   645
   End
   Begin VB.Label lblDataMahasiswa 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Data Mahasiswa"
      Enabled         =   0   'False
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
      Height          =   435
      Left            =   10920
      TabIndex        =   7
      Top             =   5160
      Width           =   885
   End
   Begin VB.Image ImgMahasiswaData 
      Height          =   735
      Left            =   10680
      Picture         =   "FrmSearchMahasiswa.frx":20FCF
      Stretch         =   -1  'True
      Top             =   5040
      Width           =   1305
   End
   Begin VB.Label lblNamaAwal 
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
      Left            =   240
      TabIndex        =   5
      Top             =   720
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
      Left            =   5400
      TabIndex        =   4
      Top             =   720
      Width           =   1935
   End
   Begin VB.Label LblNIM 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "NIM"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9.75
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
      Height          =   4215
      Left            =   10560
      Picture         =   "FrmSearchMahasiswa.frx":218A0
      Stretch         =   -1  'True
      Top             =   0
      Width           =   1455
   End
   Begin VB.Image Image2 
      Height          =   3375
      Left            =   -120
      Picture         =   "FrmSearchMahasiswa.frx":223BC
      Stretch         =   -1  'True
      Top             =   4440
      Width           =   855
   End
   Begin VB.Label lblCari 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Cari"
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
      Height          =   315
      Left            =   10800
      TabIndex        =   8
      Top             =   4560
      Width           =   885
   End
   Begin VB.Image ImgSearch 
      Height          =   510
      Left            =   10680
      Picture         =   "FrmSearchMahasiswa.frx":22ED8
      Stretch         =   -1  'True
      Top             =   4440
      Width           =   1305
   End
   Begin VB.Image Image4 
      Height          =   3735
      Left            =   10560
      Picture         =   "FrmSearchMahasiswa.frx":237A9
      Stretch         =   -1  'True
      Top             =   4200
      Width           =   1455
   End
   Begin VB.Image ImgAddress 
      Height          =   3015
      Left            =   0
      Picture         =   "FrmSearchMahasiswa.frx":23F50
      Stretch         =   -1  'True
      Top             =   1320
      Width           =   10455
   End
End
Attribute VB_Name = "FrmSearchMahasiswa"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim myitem As ClsItemServer
Dim rs As ADODB.Recordset
Private Sub Form_Load()
CenterChildForm2 Me
End Sub

Private Sub imgQuit_Click()
Unload Me
End Sub
Private Sub Form_Unload(Cancel As Integer)
  Dim xxcounter As Long
  Dim i As Long
  xxcounter = Me.Height
'Collapse Form
  Do: DoEvents
    If xxcounter > 500 Then
        xxcounter = xxcounter - 400
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
    i = i + 15
  Loop Until xxcounter >= Screen.Width
End Sub

Private Sub lblCari_Click()
    Set myitem = New ClsItemServer
    LSet SearchMahasiswaBuffer = SearchMahasiswa
    Set rs = myitem.SearchMahasiswa(SearchMahasiswaBuffer.Buffer)
    Set DataGridSearchMahasiswa.DataSource = rs
    DataGridSearchMahasiswa.Columns(14).Visible = False
    
    If myitem.SearchMahasiswa(SearchMahasiswaBuffer.Buffer).RecordCount > 0 Then
        lblDataMahasiswa.Enabled = True
        rs.MoveFirst
    Else
        lblDataMahasiswa.Enabled = False
    End If
    
End Sub

Private Sub lblDataMahasiswa_Click()
    CurrentMahasiswa.NIM = DataGridSearchMahasiswa.Columns(0).Value
    CurrentMahasiswa.Nama_Awal = DataGridSearchMahasiswa.Columns(1).Value
    CurrentMahasiswa.Nama_Akhir = DataGridSearchMahasiswa.Columns(2).Value
    CurrentMahasiswa.Alamat = DataGridSearchMahasiswa.Columns(3).Value
    CurrentMahasiswa.Telepon = DataGridSearchMahasiswa.Columns(4).Value
    CurrentMahasiswa.HP = DataGridSearchMahasiswa.Columns(5).Value
    CurrentMahasiswa.Email = DataGridSearchMahasiswa.Columns(6).Value
    CurrentMahasiswa.TempatLahir = DataGridSearchMahasiswa.Columns(7).Value
    CurrentMahasiswa.TanggalLahir = DataGridSearchMahasiswa.Columns(8).Value
    CurrentMahasiswa.Program = DataGridSearchMahasiswa.Columns(9).Value
    CurrentMahasiswa.PeriodeMasuk = DataGridSearchMahasiswa.Columns(10).Value
    CurrentMahasiswa.Status = DataGridSearchMahasiswa.Columns(11).Value
    CurrentMahasiswa.Password = DataGridSearchMahasiswa.Columns(14).Value
    frmBioData.Show
    Unload Me
End Sub

Private Sub TxtNamaAkhir_Change()
    SearchMahasiswa.Nama_Akhir = TxtNamaAkhir.Text
End Sub

Private Sub TxtNamaAwal_Change()
    SearchMahasiswa.Nama_Awal = TxtNamaAwal.Text
End Sub

Private Sub TxtNIM_Change()
    SearchMahasiswa.NIM = TxtNIM.Text
    
End Sub
