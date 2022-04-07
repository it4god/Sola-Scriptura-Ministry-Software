VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmListMataKuliah 
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
      TabIndex        =   2
      Top             =   360
      Width           =   7987
   End
   Begin MSDataGridLib.DataGrid DataGridMataKuliah 
      Height          =   6135
      Left            =   3360
      TabIndex        =   3
      Top             =   1200
      Width           =   10215
      _ExtentX        =   18018
      _ExtentY        =   10821
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
      Left            =   720
      Picture         =   "FrmListMataKuliah.frx":0000
      Stretch         =   -1  'True
      Top             =   6480
      Width           =   1755
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
      TabIndex        =   5
      Top             =   1320
      Width           =   1965
   End
   Begin VB.Label lblTitleListMataKuliah 
      BackStyle       =   0  'Transparent
      Caption         =   "List Mata Kuliah"
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
      TabIndex        =   4
      Top             =   600
      Width           =   2685
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
      Visible         =   0   'False
      Width           =   1965
   End
   Begin VB.Image ImgEdit 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmListMataKuliah.frx":11E5
      Top             =   7560
      Visible         =   0   'False
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmListMataKuliah.frx":1CD9
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11880
      Picture         =   "FrmListMataKuliah.frx":27F5
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
      Picture         =   "FrmListMataKuliah.frx":32DF
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmListMataKuliah.frx":3C3D
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmListMataKuliah.frx":467E
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image Image6 
      Height          =   495
      Left            =   11640
      Picture         =   "FrmListMataKuliah.frx":65888
      Top             =   1200
      Width           =   1980
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmListMataKuliah.frx":6637C
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmListMataKuliah"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Dim myitem As ClsItemServer
Dim rs As ADODB.Recordset


Private Sub Text1_Click()
Lite = "MasukNilaiPerMK"
FrmAddMatakuliahPerSem.Show
End Sub

Private Sub Form_Load()

    CenterChildForm Me

  
   TxtIndentity.Text = "Periode : " & Trim(strperiode)
    Set myitem = New ClsItemServer
    Set rs = New ADODB.Recordset
    Set rs = myitem.GetListMKPerSem(Periode)
    Set DataGridMatakuliah.DataSource = rs
    
DataGridMatakuliah.Columns(0).Width = 1000
DataGridMatakuliah.Columns(1).Width = 3000
DataGridMatakuliah.Columns(2).Width = 800
DataGridMatakuliah.Columns(3).Width = 800
DataGridMatakuliah.Columns(4).Width = 800
DataGridMatakuliah.Columns(5).Width = 1000
DataGridMatakuliah.Columns(6).Width = 1000
If rs.RecordCount > 0 Then
    rs.MoveFirst
End If
End Sub

Private Sub imgQuit_Click()
Unload Me
End Sub
