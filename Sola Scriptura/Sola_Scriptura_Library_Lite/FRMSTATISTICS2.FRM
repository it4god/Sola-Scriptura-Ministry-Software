VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{65E121D4-0C60-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCHRT20.OCX"
Begin VB.Form FrmStatistics 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "View Statistics"
   ClientHeight    =   6630
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8910
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   6630
   ScaleWidth      =   8910
   Begin MSChart20Lib.MSChart MSChart1 
      Bindings        =   "FrmStatistics2.frx":0000
      Height          =   5055
      Left            =   240
      OleObjectBlob   =   "FrmStatistics2.frx":0015
      TabIndex        =   11
      Top             =   120
      Visible         =   0   'False
      Width           =   7935
   End
   Begin VB.CommandButton CmdShow 
      Caption         =   "Show"
      Enabled         =   0   'False
      Height          =   375
      Left            =   6240
      TabIndex        =   10
      Top             =   6000
      Width           =   855
   End
   Begin VB.CommandButton CmdShowAll 
      Caption         =   "Show All"
      Height          =   375
      Left            =   6240
      TabIndex        =   4
      Top             =   5280
      Width           =   855
   End
   Begin VB.ComboBox CboYear2 
      Height          =   315
      Left            =   4560
      TabIndex        =   3
      Text            =   "Year"
      Top             =   6120
      Width           =   1335
   End
   Begin VB.ComboBox CboMonth2 
      Height          =   315
      Left            =   3600
      TabIndex        =   2
      Text            =   "Month"
      Top             =   6120
      Width           =   855
   End
   Begin VB.ComboBox CboMonth1 
      Height          =   315
      ItemData        =   "FrmStatistics2.frx":253A
      Left            =   480
      List            =   "FrmStatistics2.frx":253C
      TabIndex        =   1
      Text            =   "Month"
      Top             =   6120
      Width           =   855
   End
   Begin VB.ComboBox CboYear1 
      Height          =   315
      Left            =   1440
      TabIndex        =   0
      Text            =   "Year"
      Top             =   6120
      Width           =   1335
   End
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   450
      Left            =   2160
      Top             =   3720
      Visible         =   0   'False
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   794
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   1
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "SELECT * From Statistics"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   450
      Left            =   720
      Top             =   3720
      Visible         =   0   'False
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   794
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   2
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Statistics"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.Label LblYear2 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Year"
      Height          =   375
      Left            =   4560
      TabIndex        =   8
      Top             =   5760
      Width           =   735
   End
   Begin VB.Label LblYear1 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Year"
      Height          =   375
      Left            =   1440
      TabIndex        =   7
      Top             =   5760
      Width           =   735
   End
   Begin VB.Label LblMonth2 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Month"
      Height          =   375
      Left            =   3600
      TabIndex        =   6
      Top             =   5760
      Width           =   735
   End
   Begin VB.Label LblMonth1 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Month"
      Height          =   375
      Left            =   480
      TabIndex        =   5
      Top             =   5760
      Width           =   735
   End
   Begin VB.Line Line1 
      X1              =   2880
      X2              =   3360
      Y1              =   6240
      Y2              =   6240
   End
   Begin VB.Label LblAdodc2 
      BackColor       =   &H80000009&
      Caption         =   "Adodc2"
      DataField       =   "TheDate"
      DataSource      =   "Adodc2"
      Height          =   375
      Left            =   3840
      TabIndex        =   9
      Top             =   3720
      Visible         =   0   'False
      Width           =   2415
   End
End
Attribute VB_Name = "FrmStatistics"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim x As Integer
Dim Y As Integer
Dim counter As Integer
Dim value() As String

Dim thelabel() As String
Dim themindate As Date
Dim themaxdate As Date



Private Sub CboMonth1_Click()
If Not (CboMonth1.Text = "Month" Or CboMonth2.Text = "Month" Or CboYear1.Text = "Year" Or CboYear2.Text = "Year") Then
    CmdShow.Enabled = True
Else
    CmdShow.Enabled = False
End If
End Sub

Private Sub CboMonth2_Click()
If Not (CboMonth1.Text = "Month" Or CboMonth2.Text = "Month" Or CboYear1.Text = "Year" Or CboYear2.Text = "Year") Then
    CmdShow.Enabled = True
Else
    CmdShow.Enabled = False
End If
End Sub

Private Sub CboYear1_Click()
If Not (CboMonth1.Text = "Month" Or CboMonth2.Text = "Month" Or CboYear1.Text = "Year" Or CboYear2.Text = "Year") Then
    CmdShow.Enabled = True
Else
    CmdShow.Enabled = False
End If
End Sub

Private Sub CboYear2_Click()
If Not (CboMonth1.Text = "Month" Or CboMonth2.Text = "Month" Or CboYear1.Text = "Year" Or CboYear2.Text = "Year") Then
    CmdShow.Enabled = True
Else
    CmdShow.Enabled = False
End If
End Sub

Private Sub CmdShow_Click()
    themindate = DateValue(CboMonth1.Text & "," & CboYear1.Text)
    themaxdate = DateValue(CboMonth2.Text & "," & CboYear2.Text)
    themaxdate = themaxdate + 31
    Adodc2.RecordSource = "SELECT * From Statistics WHERE thedate > #" & CStr(themindate) & "# and thedate < #" & CStr(themaxdate) & "# Order By theDate"
    Adodc2.Refresh
      MSChart1.ToDefaults
    MSChart1.ShowLegend = True
    MSChart1.Visible = True
    MSChart1.chartType = VtChChartType2dLine
    If Not Adodc2.Recordset.EOF Then
              ReDim value(1 To Adodc1.Recordset.RecordCount, 1 To 5)
        ReDim thelabel(1 To Adodc1.Recordset.RecordCount)
        Adodc1.Recordset.MoveFirst
        For counter = 1 To Adodc1.Recordset.RecordCount
 
            value(counter, 1) = Adodc1.Recordset.Fields(1)
            value(counter, 2) = Adodc1.Recordset.Fields(2)
            value(counter, 3) = Adodc1.Recordset.Fields(3)
            value(counter, 4) = Adodc1.Recordset.Fields(4)
            value(counter, 5) = Adodc1.Recordset.Fields(5)

            Adodc2.Recordset.MoveNext
        Next counter
        Adodc2.Recordset.MoveFirst
        For counter = 1 To 4
        MSChart1.Plot.SeriesCollection(counter).LegendText = Adodc2.Recordset.Fields(counter + 1).Name
        Next counter
    Else
        MsgBox "Please enter the right date", vbInformation, "Requirement"
    End If
    'MSChart1.ColumnLabel = thelabel
    MSChart1.ChartData = value
End Sub

Private Sub CmdShowAll_Click()
    MSChart1.ToDefaults
    MSChart1.ShowLegend = True
    MSChart1.Visible = True
    MSChart1.chartType = VtChChartType2dLine
    If Adodc1.Recordset.RecordCount > 0 Then
        ReDim value(1 To Adodc1.Recordset.RecordCount, 1 To 5)
        ReDim thelabel(1 To Adodc1.Recordset.RecordCount)
        Adodc1.Recordset.MoveFirst
        For counter = 1 To Adodc1.Recordset.RecordCount
 
            value(counter, 1) = Adodc1.Recordset.Fields(1)
            value(counter, 2) = Adodc1.Recordset.Fields(2)
            value(counter, 3) = Adodc1.Recordset.Fields(3)
            value(counter, 4) = Adodc1.Recordset.Fields(4)
            value(counter, 5) = Adodc1.Recordset.Fields(5)

            Adodc1.Recordset.MoveNext
        Next counter
        Adodc1.Recordset.MoveFirst
        For counter = 1 To 4
            MSChart1.Plot.SeriesCollection(counter).LegendText = Adodc1.Recordset.Fields(counter + 1).Name
        Next counter
    Else
    
    End If
    MSChart1.ChartData = value
End Sub

Private Sub Form_Load()
    
    For x = 1 To 12
        CboMonth1.List(x - 1) = themonth(x)
        CboMonth2.List(x - 1) = themonth(x)
    Next x
    CboMonth1.Text = "Month"
    CboMonth2.Text = "Month"
    For Y = 1 To 150
        CboYear1.List(Y - 1) = 2000 + Y
        CboYear2.List(Y - 1) = 2000 + Y
    Next Y
    CboYear1.Text = "Year"
    CboYear2.Text = "Year"
End Sub
