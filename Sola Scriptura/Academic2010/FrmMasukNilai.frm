VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmMasukNilai 
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
      TabIndex        =   19
      Top             =   360
      Width           =   7987
   End
   Begin VB.ComboBox CboGrade 
      Height          =   315
      ItemData        =   "FrmMasukNilai.frx":0000
      Left            =   5280
      List            =   "FrmMasukNilai.frx":0028
      Locked          =   -1  'True
      TabIndex        =   2
      Top             =   6480
      Width           =   3195
   End
   Begin VB.TextBox TxtNilai 
      Height          =   285
      Left            =   5280
      Locked          =   -1  'True
      TabIndex        =   3
      Top             =   6960
      Width           =   3195
   End
   Begin VB.TextBox TxtNamaMataKuliah 
      BackColor       =   &H00FFFFFF&
      Height          =   285
      Left            =   5280
      Locked          =   -1  'True
      TabIndex        =   0
      Top             =   6000
      Width           =   8475
   End
   Begin VB.TextBox TxtMKNo 
      Height          =   285
      Left            =   5280
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   5520
      Width           =   3195
   End
   Begin MSDataGridLib.DataGrid DataGridMasukNilai 
      Height          =   3975
      Left            =   3360
      TabIndex        =   20
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
      Picture         =   "FrmMasukNilai.frx":0057
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
      TabIndex        =   22
      Top             =   3840
      Width           =   1605
   End
   Begin VB.Label lblTitleMasukNilai 
      BackStyle       =   0  'Transparent
      Caption         =   "Masuk Nilai"
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
      TabIndex        =   21
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
      TabIndex        =   18
      Top             =   3120
      Width           =   1605
   End
   Begin VB.Label LblGrade 
      BackStyle       =   0  'Transparent
      Caption         =   "Grade"
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
      TabIndex        =   17
      Top             =   6480
      Width           =   1935
   End
   Begin VB.Label LblNilai 
      BackStyle       =   0  'Transparent
      Caption         =   "Nilai"
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
      Caption         =   "Nama Mata Kuliah"
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
      TabIndex        =   15
      Top             =   6000
      Width           =   1935
   End
   Begin VB.Label LblMK 
      BackStyle       =   0  'Transparent
      Caption         =   "Mata Kuliah No"
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
      Top             =   5520
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
      Left            =   9960
      TabIndex        =   6
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
      Left            =   7800
      TabIndex        =   5
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Label lblEdit 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Edit"
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
      Left            =   5640
      TabIndex        =   4
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Image Image5 
      Height          =   495
      Left            =   7800
      Picture         =   "FrmMasukNilai.frx":123C
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   9960
      Picture         =   "FrmMasukNilai.frx":1D30
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image ImgEdit 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmMasukNilai.frx":2824
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmMasukNilai.frx":3318
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11880
      Picture         =   "FrmMasukNilai.frx":3E34
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
      Picture         =   "FrmMasukNilai.frx":491E
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmMasukNilai.frx":527C
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image ImgSuamiIstri 
      Height          =   375
      Left            =   360
      Picture         =   "FrmMasukNilai.frx":5CBD
      Stretch         =   -1  'True
      Top             =   3000
      Width           =   2250
   End
   Begin VB.Image ImgAdikKakak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmMasukNilai.frx":6A5A
      Stretch         =   -1  'True
      Top             =   2640
      Width           =   2250
   End
   Begin VB.Image ImgPendidikan 
      Height          =   375
      Left            =   360
      Picture         =   "FrmMasukNilai.frx":77F7
      Stretch         =   -1  'True
      Top             =   3720
      Width           =   2250
   End
   Begin VB.Image ImgPrestasi 
      Height          =   375
      Left            =   360
      Picture         =   "FrmMasukNilai.frx":8594
      Stretch         =   -1  'True
      Top             =   3360
      Width           =   2250
   End
   Begin VB.Image ImgAnak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmMasukNilai.frx":9331
      Stretch         =   -1  'True
      Top             =   2280
      Width           =   2250
   End
   Begin VB.Image ImgOrangtua 
      Height          =   375
      Left            =   360
      Picture         =   "FrmMasukNilai.frx":A0CE
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   2250
   End
   Begin VB.Image ImgBioData 
      Height          =   375
      Left            =   360
      Picture         =   "FrmMasukNilai.frx":AE6B
      Stretch         =   -1  'True
      Top             =   1200
      Width           =   2250
   End
   Begin VB.Image ImgAlamat 
      Height          =   375
      Left            =   360
      Picture         =   "FrmMasukNilai.frx":BC08
      Stretch         =   -1  'True
      Top             =   1560
      Width           =   2250
   End
   Begin VB.Image ImgChurchData 
      Height          =   495
      Left            =   360
      Picture         =   "FrmMasukNilai.frx":C9A5
      Stretch         =   -1  'True
      Top             =   7320
      Width           =   2250
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmMasukNilai.frx":D742
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmMasukNilai.frx":6E94C
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmMasukNilai"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim MyMataKuliahMahasiswa As MataKuliahMahasiswa
Dim MyMataKuliahMahasiswaBuffer As MataKuliahMahasiswa_Buffer
Dim myitem As ClsItemServer
Dim myNilai As Double
Dim rsMataKuliahMahasiswa As ADODB.Recordset

Private Sub CboGrade_Click()
    If CboGrade.Text = "A" Then
        myNilai = CDbl(4#)
    ElseIf CboGrade.Text = "A-" Then
        myNilai = CDbl(3.7)
    ElseIf CboGrade.Text = "B+" Then
        myNilai = CDbl(3.3)
    ElseIf CboGrade.Text = "B" Then
        myNilai = CDbl(3#)
    ElseIf CboGrade.Text = "B-" Then
        myNilai = CDbl(2.7)
    ElseIf CboGrade.Text = "C+" Then
        myNilai = CDbl(2.3)
    ElseIf CboGrade.Text = "C" Then
        myNilai = CDbl(2#)
    ElseIf CboGrade.Text = "C-" Then
        myNilai = CDbl(1.7)
    ElseIf CboGrade.Text = "D+" Then
        myNilai = CDbl(1.3)
    ElseIf CboGrade.Text = "D" Then
        myNilai = CDbl(1#)
    ElseIf CboGrade.Text = "D-" Then
        myNilai = CDbl(0.7)
    ElseIf CboGrade.Text = "F" Then
        myNilai = CDbl(0#)
    End If
    
    TxtNilai.Text = CStr(myNilai * CDbl(Trim(DataGridMasukNilai.Columns(3).Value)))
    MyMataKuliahMahasiswa.Grade = Trim(CboGrade.Text)
    MyMataKuliahMahasiswa.Nilai = CStr(myNilai * CDbl(Trim(DataGridMasukNilai.Columns(3).Value)))
End Sub

Private Sub Form_Load()
    CenterChildForm Me

  
    TxtIndentity.Text = "NIM = " & Trim(CurrentMahasiswa.NIM) & " , " & Trim(CurrentMahasiswa.Nama_Awal) & " " & Trim(CurrentMahasiswa.Nama_Akhir) & vbCrLf & "Periode : " & strperiode
    Set myitem = New ClsItemServer
    Set rsMataKuliahMahasiswa = myitem.GetMasukNilai(Periode, Trim(CurrentMahasiswa.NIM))
    Set DataGridMasukNilai.DataSource = rsMataKuliahMahasiswa
    DataGridMasukNilai.Columns(0).Width = 1000
    DataGridMasukNilai.Columns(1).Width = 3000
    DataGridMasukNilai.Columns(2).Width = 800
    DataGridMasukNilai.Columns(3).Width = 800
    DataGridMasukNilai.Columns(4).Width = 800
    DataGridMasukNilai.Columns(5).Width = 800
    DataGridMasukNilai.Columns(6).Width = 1000
    TxtMKNo.Text = ""
    TxtNamaMataKuliah.Text = ""
    CboGrade.Text = ""
    TxtNilai.Text = ""
    If rsMataKuliahMahasiswa.RecordCount > 0 Then

        lblEdit.Enabled = True
    Else
        lblEdit.Enabled = False
    End If
End Sub

Private Sub imgQuit_Click()
Unload Me
End Sub



Private Sub lblCancel_Click()
    lblEdit.Enabled = True
    lblSave.Enabled = False
    lblCancel.Enabled = False
    CboGrade.BackColor = vbWhite
    CboGrade.Locked = True
    Set myitem = New ClsItemServer
    Set rsMataKuliahMahasiswa = myitem.GetMasukNilai(Periode, Trim(CurrentMahasiswa.NIM))
    Set DataGridMasukNilai.DataSource = rsMataKuliahMahasiswa
    DataGridMasukNilai.Columns(0).Width = 1000
    DataGridMasukNilai.Columns(1).Width = 3000
    DataGridMasukNilai.Columns(2).Width = 800
    DataGridMasukNilai.Columns(3).Width = 800
    DataGridMasukNilai.Columns(4).Width = 800
    DataGridMasukNilai.Columns(5).Width = 800
    DataGridMasukNilai.Columns(6).Width = 1000
    If rsMataKuliahMahasiswa.RecordCount > 0 Then

        lblEdit.Enabled = True
    Else
        lblEdit.Enabled = False
    End If
    TxtMKNo.Text = ""
    TxtNamaMataKuliah.Text = ""
    CboGrade.Text = ""
    TxtNilai.Text = ""
End Sub

Private Sub lblEdit_Click()
    lblEdit.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    MyMataKuliahMahasiswa.NIM = Trim(CurrentMahasiswa.NIM)
    MyMataKuliahMahasiswa.MKM_No = Trim(DataGridMasukNilai.Columns(11).Value)
    TxtMKNo.Text = Trim(DataGridMasukNilai.Columns(0).Value)
    TxtNamaMataKuliah.Text = Trim(DataGridMasukNilai.Columns(1).Value)
    MyMataKuliahMahasiswa.Grade = ""
    MyMataKuliahMahasiswa.Nilai = ""
    CboGrade.Text = ""
    CboGrade.BackColor = vbYellow
    CboGrade.Locked = False
    CboGrade.SetFocus
End Sub






Private Sub lblSave_Click()
If Trim(MyMataKuliahMahasiswa.Grade) = "" Then
    MsgBox "Please fill the Grade !", vbInformationm, "Information"
Else
    lblEdit.Enabled = True
    lblSave.Enabled = False
    lblCancel.Enabled = False
    CboGrade.BackColor = vbWhite
    CboGrade.Locked = True
    Set myitem = New ClsItemServer
    Dim saveok As Boolean
    
    LSet MyMataKuliahMahasiswaBuffer = MyMataKuliahMahasiswa

    saveok = myitem.putNilai(MyMataKuliahMahasiswaBuffer.Buffer, UpdateUser)
    

    Set myitem = New ClsItemServer
    Set rsMataKuliahMahasiswa = myitem.GetMasukNilai(Periode, Trim(CurrentMahasiswa.NIM))
    Set DataGridMasukNilai.DataSource = rsMataKuliahMahasiswa
    DataGridMasukNilai.Columns(0).Width = 1000
    DataGridMasukNilai.Columns(1).Width = 3000
    DataGridMasukNilai.Columns(2).Width = 800
    DataGridMasukNilai.Columns(3).Width = 800
    DataGridMasukNilai.Columns(4).Width = 800
    DataGridMasukNilai.Columns(5).Width = 800
    DataGridMasukNilai.Columns(6).Width = 1000
    If rsMataKuliahMahasiswa.RecordCount > 0 Then

        lblEdit.Enabled = True
    Else
        lblEdit.Enabled = False
    End If
    TxtMKNo.Text = ""
    TxtNamaMataKuliah.Text = ""
    CboGrade.Text = ""
    TxtNilai.Text = ""
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
