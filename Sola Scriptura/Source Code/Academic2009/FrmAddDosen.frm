VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form FrmAddDosen 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00DC7F59&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Add Dosen"
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
      Left            =   120
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   0
      Top             =   240
      Width           =   7620
   End
   Begin MSDataGridLib.DataGrid DataGridDosen 
      Height          =   6495
      Left            =   840
      TabIndex        =   3
      Top             =   1080
      Width           =   10695
      _ExtentX        =   18865
      _ExtentY        =   11456
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
   Begin VB.Label lblGetData 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "<<"
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
      Left            =   360
      TabIndex        =   2
      Top             =   2640
      Width           =   285
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   240
      Picture         =   "FrmAddDosen.frx":0000
      Top             =   5160
      Width           =   435
   End
   Begin VB.Label lblTitleAddDosen 
      BackStyle       =   0  'Transparent
      Caption         =   "Add Dosen"
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
      Left            =   8880
      TabIndex        =   1
      Top             =   480
      Width           =   2685
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   8760
      Picture         =   "FrmAddDosen.frx":0B1C
      Top             =   360
      Width           =   2805
   End
   Begin VB.Image Image2 
      Height          =   495
      Left            =   240
      Picture         =   "FrmAddDosen.frx":1606
      Stretch         =   -1  'True
      Top             =   2520
      Width           =   495
   End
   Begin VB.Image imgBg 
      Height          =   7695
      Left            =   0
      Picture         =   "FrmAddDosen.frx":1ED7
      Stretch         =   -1  'True
      Top             =   120
      Width           =   11880
   End
End
Attribute VB_Name = "FrmAddDosen"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim myitem As ClsItemServer
Dim rsDosen As ADODB.Recordset

Private Sub Form_Load()
CenterChildForm2 Me
Set myitem = New ClsItemServer
Set rsDosen = myitem.GetDosen
Set DataGridDosen.DataSource = rsDosen
DataGridDosen.Columns(0).Width = 1000
DataGridDosen.Columns(1).Width = 3000
DataGridDosen.Columns(2).Width = 3000
If rsDosen.RecordCount > 0 Then
    rsDosen.MoveFirst
End If
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

Private Sub lblGetData_Click()
    If Lite = "MKPerSem" Then
        frmMataKuliahPerSem.TxtDosenID.Text = Trim(DataGridDosen.Columns(0).Value)
    ElseIf Lite = "" Then
    
    End If
    Unload Me
End Sub
