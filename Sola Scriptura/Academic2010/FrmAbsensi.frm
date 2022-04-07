VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmAbsensi 
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
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   9600
      Locked          =   -1  'True
      TabIndex        =   0
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
      TabIndex        =   3
      Top             =   360
      Width           =   7987
   End
   Begin MSDataGridLib.DataGrid DataGridAbsensi 
      Height          =   5655
      Left            =   3360
      TabIndex        =   4
      Top             =   1800
      Width           =   10215
      _ExtentX        =   18018
      _ExtentY        =   9975
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
      Picture         =   "FrmAbsensi.frx":0000
      Stretch         =   -1  'True
      Top             =   6480
      Width           =   1755
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
      Left            =   7920
      TabIndex        =   7
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
      Left            =   11640
      TabIndex        =   6
      Top             =   1320
      Width           =   1965
   End
   Begin VB.Label lblTitleAbsensi 
      BackStyle       =   0  'Transparent
      Caption         =   "Absensi"
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
      Height          =   465
      Left            =   12000
      TabIndex        =   5
      Top             =   600
      Width           =   2685
   End
   Begin VB.Label lblPrint 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Print"
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
      TabIndex        =   1
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Image ImgEdit 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmAbsensi.frx":11E5
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmAbsensi.frx":1CD9
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11880
      Picture         =   "FrmAbsensi.frx":27F5
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
      TabIndex        =   2
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmAbsensi.frx":32DF
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmAbsensi.frx":3C3D
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmAbsensi.frx":467E
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image Image6 
      Height          =   495
      Left            =   11640
      Picture         =   "FrmAbsensi.frx":65888
      Top             =   1200
      Width           =   1980
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmAbsensi.frx":6637C
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmAbsensi"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Dim myitem As ClsItemServer
Dim myNilai As Double
Dim rs As ADODB.Recordset


Private Sub Form_Load()
    CenterChildForm Me

  
   TxtIndentity.Text = "Periode : " & Trim(strperiode)
    Set myitem = New ClsItemServer
    Set rs = New ADODB.Recordset
    
End Sub

Private Sub imgQuit_Click()
Unload Me
End Sub



Private Sub lblEnterCode_Click()
   If Text1.Text = "" Then
        MsgBox "Please enter the Kode_MK", vbInformation, "Warning"
    Else
        
    End If
   Set myitem = New ClsItemServer
Set rs = myitem.GetAbsensi(Trim(strMatakuliahPerSemNo))
Set DataGridAbsensi.DataSource = rs
DataGridAbsensi.Columns(0).Width = 1000
DataGridAbsensi.Columns(1).Width = 1800
DataGridAbsensi.Columns(2).Width = 800
DataGridAbsensi.Columns(3).Width = 2900
DataGridAbsensi.Columns(4).Width = 800
DataGridAbsensi.Columns(5).Width = 500
DataGridAbsensi.Columns(6).Width = 800
DataGridAbsensi.Columns(7).Width = 800
If rs.RecordCount > 0 Then
    lblPrint.Enabled = True
Else
    lblPrint.Enabled = False
End If
End Sub




Private Sub lblPrint_Click()
Set myitem = New ClsItemServer
Set rs = myitem.GetAbsensi(Trim(strMatakuliahPerSemNo))
Dim AbsensiReport As DataReportAbsensi
Set AbsensiReport = New DataReportAbsensi
Set AbsensiReport.DataSource = rs
AbsensiReport.Orientation = rptOrientLandscape
Dim mylabel(1 To 5) As RptLabel
Dim x As Integer

For x = 1 To 5
    Set mylabel(x) = AbsensiReport.Sections(1).Controls.Item(x)

Next

mylabel(1).Caption = "Absensi"
mylabel(2).Caption = Trim(rs.Fields("Nama_MK").Value)
mylabel(3).Caption = "Dosen : " & Trim(rs.Fields("DosenID").Value)
mylabel(4).Caption = Trim(rs.Fields("MK_No").Value)
mylabel(5).Caption = "Periode : " & Trim(strperiode)
AbsensiReport.Show


End Sub

Private Sub Text1_Click()
Lite = "Absensi"
FrmAddMatakuliahPerSem.Show
End Sub
