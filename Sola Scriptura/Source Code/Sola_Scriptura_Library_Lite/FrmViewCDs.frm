VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form FrmViewCDs 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "View CDs"
   ClientHeight    =   7185
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9120
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   7185
   ScaleWidth      =   9120
   Begin VB.CommandButton CmdEdit 
      Caption         =   "Edit"
      Height          =   375
      Left            =   8040
      TabIndex        =   3
      Top             =   6600
      Width           =   855
   End
   Begin VB.TextBox Text1 
      Appearance      =   0  'Flat
      Height          =   375
      Left            =   4440
      TabIndex        =   2
      Top             =   6600
      Width           =   3375
   End
   Begin VB.OptionButton Option1 
      BackColor       =   &H8000000E&
      Caption         =   "Order by ID"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   1
      Top             =   6600
      Value           =   -1  'True
      Width           =   1815
   End
   Begin VB.OptionButton Option1 
      BackColor       =   &H8000000E&
      Caption         =   "Order by Title"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   2160
      TabIndex        =   0
      Top             =   6600
      Width           =   1935
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "FrmViewCDs.frx":0000
      Height          =   5655
      Left            =   120
      TabIndex        =   4
      Top             =   840
      Width           =   8895
      _ExtentX        =   15690
      _ExtentY        =   9975
      _Version        =   393216
      HeadLines       =   1
      RowHeight       =   19
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
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
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   510
      Left            =   120
      Top             =   5640
      Visible         =   0   'False
      Width           =   1200
      _ExtentX        =   2117
      _ExtentY        =   900
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   $"FrmViewCDs.frx":0015
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.Image Image1 
      Height          =   7170
      Left            =   0
      Picture         =   "FrmViewCDs.frx":003E
      Stretch         =   -1  'True
      Top             =   0
      Width           =   9135
   End
End
Attribute VB_Name = "FrmViewCDs"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub CmdEdit_Click()
FrmAddOrModifyCDs.Hide
FrmAddOrModifyCDs.Show
If FrmAddOrModifyCDs.Adodc1.Recordset.RecordCount > 0 Then
    With FrmAddOrModifyCDs.Adodc1.Recordset
        .MoveFirst
        While Not .EOF
            If .Fields(0) = DataGrid1.Columns(0).Value Then
                Me.Hide
                Exit Sub
            End If
        .MoveNext
        Wend
    End With
End If
End Sub

Private Sub Option1_Click(Index As Integer)
Select Case Index
Case 0
    Adodc1.RecordSource = "Select * from CDs order by ItemNo"
    Text1.Visible = True
Case 1
    Adodc1.RecordSource = "Select * from CDs order by title"
    Text1.Visible = True
End Select
Adodc1.Refresh
ArrangeGrid
End Sub

Private Sub Text1_Change()
If Option1(0).Value = True Then
        Adodc1.RecordSource = "Select * from CDs where  ItemNo >= '" & Text1.Text & "' order by ItemNo"
Else
Adodc1.RecordSource = "Select * from CDs where title >= '" & Text1.Text & "' order by title"
End If



Adodc1.Refresh
ArrangeGrid
End Sub
Private Sub ArrangeGrid()
DataGrid1.Columns(0).Width = 1000
DataGrid1.Columns(1).Width = 3000
DataGrid1.Columns(2).Width = 2000
DataGrid1.Columns(3).Width = 2000
DataGrid1.Columns(4).Width = 700
DataGrid1.Columns(5).Width = 400
DataGrid1.Columns(6).Width = 400
DataGrid1.Columns(7).Width = 400
DataGrid1.Columns(8).Width = 400
DataGrid1.Columns(9).Width = 400
End Sub

Private Sub Form_Load()

ArrangeGrid
End Sub
