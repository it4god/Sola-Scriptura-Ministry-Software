VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmMasukNilaiPerMK 
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
   Begin VB.TextBox TxtNama 
      Height          =   285
      Left            =   10560
      Locked          =   -1  'True
      TabIndex        =   18
      Top             =   5520
      Width           =   3180
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   9720
      Locked          =   -1  'True
      TabIndex        =   2
      Top             =   1320
      Width           =   1860
   End
   Begin VB.TextBox TxtIndentity 
      Alignment       =   2  'Center
      BackColor       =   &H80000006&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000005&
      Height          =   495
      Left            =   2880
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   13
      Top             =   360
      Width           =   7987
   End
   Begin VB.ComboBox CboGrade 
      Height          =   315
      ItemData        =   "FrmMasukNilaiPerMK.frx":0000
      Left            =   5280
      List            =   "FrmMasukNilaiPerMK.frx":0028
      Locked          =   -1  'True
      TabIndex        =   1
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
      TabIndex        =   12
      Top             =   5520
      Width           =   3195
   End
   Begin MSDataGridLib.DataGrid DataGridMasukNilai 
      Height          =   3495
      Left            =   3360
      TabIndex        =   14
      Top             =   1800
      Width           =   10335
      _ExtentX        =   18230
      _ExtentY        =   6165
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
      Picture         =   "FrmMasukNilaiPerMK.frx":0057
      Stretch         =   -1  'True
      Top             =   6360
      Width           =   1755
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Nama"
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
      Left            =   8880
      TabIndex        =   19
      Top             =   5520
      Width           =   1935
   End
   Begin VB.Label lblMKNo 
      BackStyle       =   0  'Transparent
      Caption         =   "Mata Kuliah No"
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
      Left            =   8040
      TabIndex        =   17
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Label lblEnterCode 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Enter MK No"
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
      Left            =   11760
      TabIndex        =   16
      Top             =   1320
      Width           =   1965
   End
   Begin VB.Label lblTitleMasukNilaiPerMK 
      BackStyle       =   0  'Transparent
      Caption         =   "Masuk Nilai Per MK"
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
      TabIndex        =   15
      Top             =   600
      Width           =   2685
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
      TabIndex        =   11
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
      TabIndex        =   10
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
      TabIndex        =   9
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
      TabIndex        =   8
      Top             =   5520
      Width           =   1935
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
      Picture         =   "FrmMasukNilaiPerMK.frx":123C
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   9960
      Picture         =   "FrmMasukNilaiPerMK.frx":1D30
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image ImgEdit 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmMasukNilaiPerMK.frx":2824
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmMasukNilaiPerMK.frx":3318
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11880
      Picture         =   "FrmMasukNilaiPerMK.frx":3E34
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
      Picture         =   "FrmMasukNilaiPerMK.frx":491E
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmMasukNilaiPerMK.frx":527C
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmMasukNilaiPerMK.frx":5CBD
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image Image6 
      Height          =   495
      Left            =   11760
      Picture         =   "FrmMasukNilaiPerMK.frx":66EC7
      Top             =   1200
      Width           =   1980
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmMasukNilaiPerMK.frx":679BB
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmMasukNilaiPerMK"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim MyMataKuliahMahasiswa As MataKuliahMahasiswa
Dim MyMataKuliahMahasiswaBuffer As MataKuliahMahasiswa_Buffer
Dim myitem As ClsItemServer
Dim myNilai As Double
Dim rs As ADODB.Recordset
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
    
    TxtNilai.Text = CStr(myNilai * CDbl(Trim(DataGridMasukNilai.Columns(5).Value)))
    MyMataKuliahMahasiswa.Grade = Trim(CboGrade.Text)
    MyMataKuliahMahasiswa.Nilai = CStr(myNilai * CDbl(Trim(DataGridMasukNilai.Columns(5).Value)))
End Sub

Private Sub Form_Load()
    CenterChildForm Me

  
   TxtIndentity.Text = "Periode : " & Trim(strperiode)
    Set myitem = New ClsItemServer
    Set rs = myitem.GetMasukNilaiPerMK(Periode, Trim(Text1.Text))
   If rs.RecordCount > 0 Then
    rs.MoveFirst
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
Set rs = myitem.GetMasukNilaiPerMK(Periode, Trim(Text1.Text))
Set DataGridMasukNilai.DataSource = rs
DataGridMasukNilai.Columns(0).Width = 1000
DataGridMasukNilai.Columns(1).Width = 1800
DataGridMasukNilai.Columns(2).Width = 800
DataGridMasukNilai.Columns(3).Width = 2900
DataGridMasukNilai.Columns(4).Width = 800
DataGridMasukNilai.Columns(5).Width = 500
DataGridMasukNilai.Columns(6).Width = 800
DataGridMasukNilai.Columns(7).Width = 800
If rs.RecordCount > 0 Then
    rs.MoveFirst
End If
End Sub

Private Sub lblEdit_Click()
If rs.RecordCount > 0 Then
    lblEdit.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    TxtNama.Text = Trim(DataGridMasukNilai.Columns(1).Value)
    MyMataKuliahMahasiswa.NIM = Trim(CurrentMahasiswa.NIM)
    MyMataKuliahMahasiswa.MKM_No = Trim(DataGridMasukNilai.Columns(13).Value)
    TxtMKNo.Text = Trim(DataGridMasukNilai.Columns(3).Value)
    TxtNamaMataKuliah.Text = Trim(DataGridMasukNilai.Columns(4).Value)
    MyMataKuliahMahasiswa.Grade = ""
    MyMataKuliahMahasiswa.Nilai = ""
    CboGrade.Text = ""
    CboGrade.BackColor = vbYellow
    CboGrade.Locked = False
    CboGrade.SetFocus
Else

End If
End Sub






Private Sub lblEnterCode_Click()
   If Text1.Text = "" Then
        MsgBox "Please enter the Kode_MK", vbInformation, "Warning"
    Else
        
    End If
   Set myitem = New ClsItemServer
Set rs = myitem.GetMasukNilaiPerMK(Periode, Trim(Text1.Text))
Set DataGridMasukNilai.DataSource = rs
DataGridMasukNilai.Columns(0).Width = 1000
DataGridMasukNilai.Columns(1).Width = 1800
DataGridMasukNilai.Columns(2).Width = 800
DataGridMasukNilai.Columns(3).Width = 2900
DataGridMasukNilai.Columns(4).Width = 800
DataGridMasukNilai.Columns(5).Width = 500
DataGridMasukNilai.Columns(6).Width = 800
DataGridMasukNilai.Columns(7).Width = 800
If rs.RecordCount > 0 Then
    rs.MoveFirst
End If
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

Set rs = myitem.GetMasukNilaiPerMK(Periode, Trim(Text1.Text))
Set DataGridMasukNilai.DataSource = rs
DataGridMasukNilai.Columns(0).Width = 1000
DataGridMasukNilai.Columns(1).Width = 1800
DataGridMasukNilai.Columns(2).Width = 800
DataGridMasukNilai.Columns(3).Width = 2900
DataGridMasukNilai.Columns(4).Width = 800
DataGridMasukNilai.Columns(5).Width = 500
DataGridMasukNilai.Columns(6).Width = 800
DataGridMasukNilai.Columns(7).Width = 800
If rs.RecordCount > 0 Then
    rs.MoveFirst
End If
End If
End Sub
Private Sub lblMnuBIOData_Click()
    Unload Me
    frmBioData.Show
End Sub
Private Sub lblMnuKRS_Click()
    Unload Me
    frmKRS.Show
End Sub
Private Sub lblMnuMasukNilai_Click()
    Unload Me
    frmMasukNilai.Show
End Sub

Private Sub Text1_Click()
Lite = "MasukNilaiPerMK"
FrmAddMatakuliahPerSem.Show
End Sub
