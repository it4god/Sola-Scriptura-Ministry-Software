VERSION 5.00
Object = "{AD224A25-CA55-11D2-8C26-444553540001}#2.1#0"; "SWBGRADIENT.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form FrmDetail 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Detail"
   ClientHeight    =   6465
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7155
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   6465
   ScaleWidth      =   7155
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   375
      Left            =   5520
      TabIndex        =   4
      Top             =   5880
      Visible         =   0   'False
      Width           =   1095
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "FrmDetail.frx":0000
      Height          =   4935
      Left            =   240
      TabIndex        =   3
      Top             =   720
      Width           =   6735
      _ExtentX        =   11880
      _ExtentY        =   8705
      _Version        =   393216
      AllowUpdate     =   0   'False
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
   Begin VB.TextBox ID 
      Height          =   375
      Left            =   2880
      TabIndex        =   1
      Top             =   5880
      Width           =   2295
   End
   Begin VB.CommandButton CmdIDFind 
      Caption         =   "Find ID"
      Height          =   375
      Left            =   1560
      TabIndex        =   0
      Top             =   5880
      Width           =   1095
   End
   Begin SWBGradientCtl.SWBGradient SWBGradient1 
      Left            =   0
      Top             =   0
      _ExtentX        =   423
      _ExtentY        =   423
      StartColor      =   12632256
      EndColor        =   16777215
      Orientation     =   2
   End
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   495
      Left            =   1560
      Top             =   3600
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   873
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
      RecordSource    =   "SELECT * From Books Order By ItemNo"
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
      Height          =   495
      Left            =   120
      Top             =   5760
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   873
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\Detail.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\Detail.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "SELECT * From Status"
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
   Begin MSAdodcLib.Adodc Adodc4 
      Height          =   495
      Left            =   5520
      Top             =   2640
      Visible         =   0   'False
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   873
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
      RecordSource    =   "SELECT * From Books"
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
   Begin MSAdodcLib.Adodc Adodc3 
      Height          =   375
      Left            =   5760
      Top             =   3720
      Visible         =   0   'False
      Width           =   1200
      _ExtentX        =   2117
      _ExtentY        =   661
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\Detail.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\Detail.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "SELECT * From BookCategory"
      Caption         =   "Adodc3"
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
   Begin VB.Image Image1 
      Height          =   6450
      Left            =   0
      Picture         =   "FrmDetail.frx":0015
      Stretch         =   -1  'True
      Top             =   0
      Width           =   7455
   End
   Begin VB.Label Label3 
      Caption         =   "Label3"
      DataField       =   "ItemNo"
      DataSource      =   "Adodc4"
      Height          =   495
      Left            =   6720
      TabIndex        =   6
      Top             =   1680
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.Label Label2 
      Caption         =   "Label2"
      DataField       =   "CategoryID"
      DataSource      =   "Adodc3"
      Height          =   375
      Left            =   6840
      TabIndex        =   5
      Top             =   3000
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Label Label1 
      BackColor       =   &H80000009&
      Caption         =   "Adodc2"
      DataField       =   "Title"
      DataSource      =   "Adodc2"
      Height          =   255
      Left            =   3000
      TabIndex        =   2
      Top             =   3720
      Width           =   1575
   End
End
Attribute VB_Name = "FrmDetail"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Code As String
Dim remain As String
Dim resultcode As String
Dim found As Boolean
Dim check As Boolean
Dim count123 As Integer



Private Sub CmdIDFind_Click()
    If itemitem = 1 Then
        Call BookIDFind
    ElseIf itemitem = 2 Then
        Call CassetteIDFind
    ElseIf itemitem = 3 Then
        Call CDIDFind
    ElseIf itemitem = 4 Then
        Call VideoIDFind
    End If
    
End Sub


Private Sub BookIDFind()
  Code = DataGrid1.Columns(2).Value
  count123 = 0
  found = False
  While found = False
       count123 = count123 + 1
       remain = CodeFinder(count123)
       If remain = "Error" Then
            MsgBox "Book Data full", vbInformation, "Error !"
            Exit Sub
       End If
       resultcode = Code + remain
       found = False
       check = True
       Adodc2.RecordSource = "SELECT * From Books WHERE ItemNo LIKE '%" & resultcode & "%' ORDER By ItemNo"
       Adodc2.Refresh
       If Not Adodc2.Recordset.EOF Then
            found = False
       Else
            found = True
       End If

  Wend
  ID.Text = resultcode
  
End Sub

Private Sub CassetteIDFind()
  Code = DataGrid1.Columns(2).Value
  count123 = 0

  found = False
  While found = False
       count123 = count123 + 1
       remain = CodeFinder(count123)
       If remain = "Error" Then
            MsgBox "Book Data full", vbInformation, "Error !"
            Exit Sub
       End If
       resultcode = Code + remain
       found = False
       check = True
       Adodc2.RecordSource = "SELECT * From Cassettes WHERE ItemNo LIKE '%" & resultcode & "%' ORDER By ItemNo"
       Adodc2.Refresh

       
         If Not Adodc2.Recordset.EOF Then
            found = False
       Else
            found = True
       End If
  Wend
  ID.Text = resultcode
  
End Sub

Private Sub CDIDFind()
  Code = DataGrid1.Columns(2).Value
  count123 = 0

  found = False
  While found = False
       count123 = count123 + 1
       remain = CodeFinder(count123)
       If remain = "Error" Then
            MsgBox "Book Data full", vbInformation, "Error !"
            Exit Sub
       End If
       resultcode = Code + remain
       found = False
       check = True
       Adodc2.RecordSource = "SELECT * From CDs WHERE ItemNo LIKE '%" & resultcode & "%' ORDER By ItemNo"
       Adodc2.Refresh
              If Not Adodc2.Recordset.EOF Then
            found = False
       Else
            found = True
       End If
     
  Wend
  ID.Text = resultcode
  
End Sub

Private Sub VideoIDFind()
  Code = DataGrid1.Columns(2).Value
  count123 = 0

  found = False
  While found = False
       count123 = count123 + 1
       remain = CodeFinder(count123)
       If remain = "Error" Then
            MsgBox "Book Data full", vbInformation, "Error !"
            Exit Sub
       End If
       resultcode = Code + remain
       found = False
       check = True
       
       Adodc2.RecordSource = "SELECT * From Videos WHERE ItemNo LIKE '%" & resultcode & "%' ORDER By ItemNo"
       Adodc2.Refresh
       If Not Adodc2.Recordset.EOF Then
            found = False
       Else
            found = True
       End If
  Wend
  ID.Text = resultcode
  
End Sub

Public Function CodeFinder(count123 As Integer) As String
    If count123 / 100 > 9 Then
        CodeFinder = "Error"
    ElseIf count123 / 100 >= 1 Then
        CodeFinder = Trim(count123)
    ElseIf count123 / 10 >= 1 Then
        CodeFinder = "0" + Trim(count123)
    Else
        CodeFinder = "00" + Trim(count123)
    End If
End Function

Private Sub Command1_Click()
  Adodc4.RecordSource = "SELECT * From Books WHERE ItemNo LIKE '%BRI-%' ORDER By ItemNo"
  Adodc4.Refresh
  
  While Not Adodc4.Recordset.EOF
        If Adodc4.Recordset.Fields(6) = "Th" Then
             Adodc3.RecordSource = "SELECT * From BookCategory WHERE CategoryID = '" & Adodc4.Recordset.Fields(7) & "'"
        Else
             Adodc3.RecordSource = "SELECT * From BookCategory WHERE CategoryID = '" & Adodc4.Recordset.Fields(6) & "'"
        End If
        Adodc3.Refresh
        Code = Trim(IAdodc4.Recordset.Fields(2))
        
        count123 = 0
        Adodc2.RecordSource = "SELECT * From Books WHERE ItemNo LIKE '%" & Trim(Code) & "%' ORDER By ItemNo"
        Adodc2.Refresh
        found = False
        While found = False
             count123 = count123 + 1
             remain = CodeFinder(count123)
             If remain = "Error" Then
                MsgBox "Book Data full", vbInformation, "Error !"
                Exit Sub
             End If
             resultcode = Code + remain
             found = False
             check = True
       
             Adodc2.Refresh
             While check = True
             If Not Adodc2.Recordset.EOF Then
                If Adodc2.Recordset.Fields(0) = resultcode Then check = False
                  If check = True Then Adodc2.Recordset.MoveNext
             End If
             If Adodc2.Recordset.EOF Then
                check = False
                found = True
                End If
             Wend
       Wend
       
        Adodc4.Recordset.Fields(0) = resultcode
        Adodc4.Recordset.Update
        Adodc4.Recordset.MoveNext
  Wend
 
End Sub

Private Sub Form_Load()
    If itemitem = 0 Then
        CmdIDFind.Enabled = False
    Else
        CmdIDFind.Enabled = True
    End If
End Sub

Public Sub MenuExecute(count12345 As Integer)
Select Case count12345
Case 0
    Adodc1.RecordSource = "SELECT * From Status Order By ItemStatus"
    Adodc1.Refresh
Case 1
    Adodc1.RecordSource = "SELECT * From BookCategory Order By CategoryID"
    Adodc1.Refresh

    DataGrid1.Columns(2).Width = 1000
    DataGrid1.Columns(3).Width = 3000
Case 2
    itemitem = 1
    Adodc1.RecordSource = "SELECT * From DetailCategory Order By CategoryID"
    Adodc1.Refresh
    DataGrid1.Columns(2).Width = 1000
    DataGrid1.Columns(3).Width = 3000
Case 3
    itemitem = 0
    Adodc1.RecordSource = "SELECT * From  BestCategory Order By BestCategoryID"
    Adodc1.Refresh
Case 4
    itemitem = 0
    Adodc1.RecordSource = "SELECT * From Available Order By AvailableID"
    Adodc1.Refresh

Case 5
    itemitem = 1

    Adodc1.RecordSource = "SELECT * From BookCategory ORDER By CategoryID UNION SELECT * From DetailCategory ORDER By CategoryID"
    Adodc1.Refresh
    DataGrid1.Refresh
    DataGrid1.Columns(2).Width = 1000
    DataGrid1.Columns(3).Width = 3000
Case 6
    
    Adodc1.RecordSource = "SELECT * From CassetteCategory Order By CategoryID"
    Adodc1.Refresh
    DataGrid1.Columns(2).Width = 1000
    DataGrid1.Columns(3).Width = 3000
Case 7
    Adodc1.RecordSource = "SELECT * From CDCategory Order By CategoryID"
    Adodc1.Refresh
    DataGrid1.Columns(2).Width = 1000
    DataGrid1.Columns(3).Width = 3000
Case 8
    Adodc1.RecordSource = "SELECT * From VideoCategory Order By CategoryID"
    Adodc1.Refresh
    DataGrid1.Columns(2).Width = 1000
    DataGrid1.Columns(3).Width = 3000
End Select
    DataGrid1.Columns(0).Width = 500
    DataGrid1.Columns(1).Width = 3000
    


End Sub
