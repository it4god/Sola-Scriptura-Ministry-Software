VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form FrmViewUnreturnVideos 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "View Unreturned Videos"
   ClientHeight    =   7170
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9150
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   7170
   ScaleWidth      =   9150
   Begin VB.CommandButton CmdFunction 
      Caption         =   "Function"
      Height          =   375
      Left            =   120
      TabIndex        =   5
      Top             =   6600
      Width           =   1215
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "FrmViewUnreturnVideos.frx":0000
      Height          =   5655
      Left            =   120
      TabIndex        =   0
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
   Begin MSAdodcLib.Adodc Adodc3 
      Height          =   510
      Left            =   2400
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
      RecordSource    =   $"FrmViewUnreturnVideos.frx":0015
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
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   510
      Left            =   1200
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
      RecordSource    =   $"FrmViewUnreturnVideos.frx":0040
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
   Begin VB.CommandButton CmdExtend 
      Caption         =   "Extend"
      Height          =   375
      Left            =   7680
      TabIndex        =   2
      Top             =   6600
      Width           =   1215
   End
   Begin VB.CommandButton CmdReturn 
      Caption         =   "Return"
      Height          =   375
      Left            =   6240
      TabIndex        =   1
      Top             =   6600
      Width           =   1215
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   510
      Left            =   240
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
      RecordSource    =   $"FrmViewUnreturnVideos.frx":0069
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
      Picture         =   "FrmViewUnreturnVideos.frx":0094
      Stretch         =   -1  'True
      Top             =   0
      Width           =   9135
   End
   Begin VB.Label LblAdodc3 
      BackColor       =   &H80000009&
      Caption         =   "Adodc3"
      DataField       =   "Title"
      DataSource      =   "Adodc3"
      Height          =   255
      Left            =   5040
      TabIndex        =   4
      Top             =   5760
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Label LblAdodc2 
      BackColor       =   &H80000009&
      Caption         =   "Adodc2"
      DataField       =   "Title"
      DataSource      =   "Adodc2"
      Height          =   255
      Left            =   3960
      TabIndex        =   3
      Top             =   5760
      Visible         =   0   'False
      Width           =   615
   End
End
Attribute VB_Name = "FrmViewUnreturnVideos"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim strSQL As String
Dim saskuser As String
Dim iresponse As Integer
Private Sub CmdExtend_Click()
If DataGrid1.Columns(11).Value = "E" Then
    MsgBox DataGrid1.Columns(3).Value & " have already extended the borrowing, so can not extend anymore !", vbInformation, "Information"
    Exit Sub
ElseIf Val(DataGrid1.Columns(10).Value) > 0 Then
    MsgBox DataGrid1.Columns(3).Value & " must pay " & DataGrid1.Columns(10).Value & " and return the borrowing", vbInformation, "Information"
    Exit Sub
Else
        saskuser = "Do " & CurrentBorrower.FName & " want to extend " & DataGrid1.Columns(1).Value & " ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Extend")
    If iresponse = vbYes Then
    
    Else
        MsgBox "Extend Canceled", vbInformation, "Information"
        Exit Sub
    End If
    
    
    
    If Mid(DataGrid1.Columns(0).Value, 2, 1) = "B" Then
         Adodc2.RecordSource = "SELECT * From Lending_Books WHERE BorrowerID = " & Val(DataGrid1.Columns(2).Value) & " and ItemNo = '" & DataGrid1.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Returndate = #" & DataGrid1.Columns(9).Value & "#"
         Adodc3.RecordSource = "SELECT * From Books Where ItemNo = '" & DataGrid1.Columns(0).Value & "'"
    ElseIf Mid(DataGrid1.Columns(0).Value, 2, 1) = "K" Then
        Adodc2.RecordSource = "SELECT * From Lending_Cassettes WHERE BorrowerID = " & Val(DataGrid1.Columns(2).Value) & " and ItemNo = '" & DataGrid1.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Returndate = #" & DataGrid1.Columns(9).Value & "#"
        Adodc3.RecordSource = "SELECT * From Cassettes Where ItemNo = '" & DataGrid1.Columns(0).Value & "'"
    ElseIf Mid(DataGrid1.Columns(0).Value, 2, 1) = "C" Then
        Adodc2.RecordSource = "SELECT * From Lending_CDs WHERE BorrowerID = " & Val(DataGrid1.Columns(2).Value) & " and ItemNo = '" & DataGrid1.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Returndate = #" & DataGrid1.Columns(9).Value & "#"
        Adodc3.RecordSource = "SELECT * From CDs Where ItemNo = '" & DataGrid1.Columns(0).Value & "'"
    ElseIf Mid(DataGrid1.Columns(0).Value, 2, 1) = "V" Then
        Adodc2.RecordSource = "SELECT * From Lending_Videos WHERE BorrowerID = " & Val(DataGrid1.Columns(2).Value) & " and ItemNo = '" & DataGrid1.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Returndate = #" & DataGrid1.Columns(9).Value & "#"
        Adodc3.RecordSource = "SELECT * From Videos Where ItemNo = '" & DataGrid1.Columns(0).Value & "'"
    Else
        MsgBox "The ID is not valid ID", vbInformation, "Error"
        Exit Sub
    End If
    Adodc2.Refresh
    Adodc2.Recordset.Fields(3) = "E"
    Adodc2.Recordset.Fields(5) = Adodc2.Recordset.Fields(5) + 14
    Adodc2.Recordset.Update
    Adodc3.Recordset.Fields(5) = "E"
    Adodc3.Recordset.Update
    Adodc2.Refresh
    Adodc1.Refresh
    ArrangeGrid
    IsDataAvailable
     MsgBox "Extend Successful", vbInformation, "Information"
End If
End Sub
Private Sub CmdReturn_Click()
saskuser = "Do " & DataGrid1.Columns(3).Value & " want to return " & DataGrid1.Columns(1).Value & " ?"
iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Return")
If iresponse = vbYes Then
    
Else
        MsgBox "Return Canceled", vbInformation, "Information"
        Exit Sub
End If


If Mid(DataGrid1.Columns(0).Value, 2, 1) = "B" Then
    Adodc2.RecordSource = "SELECT * From Lending_Books WHERE BorrowerID = " & Val(DataGrid1.Columns(2).Value) & " and ItemNo = '" & DataGrid1.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Returndate = #" & DataGrid1.Columns(9).Value & "#"
    Adodc3.RecordSource = "SELECT * From Books Where ItemNo = '" & DataGrid1.Columns(0).Value & "'"
ElseIf Mid(DataGrid1.Columns(0).Value, 2, 1) = "K" Then
    Adodc2.RecordSource = "SELECT * From Lending_Cassettes WHERE BorrowerID = " & Val(DataGrid1.Columns(2).Value) & " and ItemNo = '" & DataGrid1.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Returndate = #" & DataGrid1.Columns(9).Value & "#"
    Adodc3.RecordSource = "SELECT * From Cassettes Where ItemNo = '" & DataGrid1.Columns(0).Value & "'"
ElseIf Mid(DataGrid1.Columns(0).Value, 2, 1) = "C" Then
    Adodc2.RecordSource = "SELECT * From Lending_CDs WHERE BorrowerID = " & Val(DataGrid1.Columns(2).Value) & " and ItemNo = '" & DataGrid1.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Returndate = #" & DataGrid1.Columns(9).Value & "#"
    Adodc3.RecordSource = "SELECT * From CDs Where ItemNo = '" & DataGrid1.Columns(0).Value & "'"
ElseIf Mid(DataGrid1.Columns(0).Value, 2, 1) = "V" Then
    Adodc2.RecordSource = "SELECT * From Lending_Videos WHERE BorrowerID = " & Val(DataGrid1.Columns(2).Value) & " and ItemNo = '" & DataGrid1.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Returndate = #" & DataGrid1.Columns(9).Value & "#"
    Adodc3.RecordSource = "SELECT * From Videos Where ItemNo = '" & DataGrid1.Columns(0).Value & "'"
Else
    MsgBox "The ID is not valid ID", vbInformation, "Error"
    Exit Sub
End If
    Adodc2.Refresh
    Adodc3.Refresh
If Val(DataGrid1.Columns(10).Value) > 0 Then
    saskuser = DataGrid1.Columns(3).Value & " need to pay " & DataGrid1.Columns(10).Value & " because of overdue"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Fine")
    If iresponse = vbYes Then
          Adodc2.Recordset.Fields(7) = True
    Else
        MsgBox DataGrid1.Columns(3).Value & " need to pay first !", vbInformation, "Information"
        Exit Sub
    End If
End If

    Adodc2.Recordset.Fields(3) = "R"
    Adodc2.Recordset.Update
    Adodc3.Recordset.Fields(5) = "A"
    Adodc3.Recordset.Update
    Adodc3.Refresh
    Adodc2.Refresh
    Adodc1.Refresh
    ArrangeGrid
    IsDataAvailable
  MsgBox "Return Successful", vbInformation, "Information"
  
End Sub

Private Sub CmdFunction_Click()
BorrowerID = Val(DataGrid1.Columns(2).Value)
If IsNull(BorrowerID) Then BorrowerID = 0
strSQL = "SELECT * From Borrowers WHERE BorrowerID = " & BorrowerID
BorrowerData.Open strSQL, cnDatabase, adOpenDynamic, adLockOptimistic
If BorrowerData.EOF Then
    MsgBox "Please Click the Borrower and then click Function", vbCritical, "Requirement"
Else
    CurrentBorrower.FName = ""
    CurrentBorrower.LName = ""
    CurrentBorrower.ID = BorrowerData.Fields(0)
    CurrentBorrower.FName = BorrowerData.Fields(1)
    If IsNull(BorrowerData.Fields(8)) = True Then
        BorrowerData.Fields(8) = InputBox$("Email Address incomplete, Please Enter the Email Address")
        BorrowerData.Update
    End If
    If Not IsNull(BorrowerData.Fields(2)) Then CurrentBorrower.LName = BorrowerData.Fields(2)
    CurrentBorrower.Valid = True
    Unload FrmFunction
    FrmFunction.Show
    FrmFunction.Refresh
    FrmFunction.Tag = 1
End If
BorrowerData.Close
End Sub

Private Sub Form_Load()

strSQL = "SELECT Lending_Videos.ItemNo as ID, Title, Lending_Videos.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,ReturnDate,Fine,Lending_Videos.AvailID,AvailName From Lending_Videos,Videos,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Videos.BorrowerID and Lending_Videos.ItemNo = Videos.ItemNo and (Lending_Videos.AvailID = 'B' or Lending_Videos.AvailID = 'E') and Lending_Videos.AvailID = Availability.AvailID  ORDER By Lending_Videos.ItemNo"
Adodc1.RecordSource = strSQL
Adodc1.Refresh
ArrangeGrid
IsDataAvailable
End Sub

Private Sub ArrangeGrid()
DataGrid1.Columns(0).Width = 1000
DataGrid1.Columns(1).Width = 3000
DataGrid1.Columns(2).Width = 400
DataGrid1.Columns(3).Width = 1400
DataGrid1.Columns(4).Width = 1400
DataGrid1.Columns(5).Width = 800
DataGrid1.Columns(6).Width = 1000
DataGrid1.Columns(7).Width = 2400
DataGrid1.Columns(8).Width = 1000
DataGrid1.Columns(9).Width = 1000
DataGrid1.Columns(10).Width = 700
DataGrid1.Columns(11).Width = 500
DataGrid1.Columns(12).Width = 1000
End Sub

Private Sub IsDataAvailable()
    If Adodc1.Recordset.EOF Then
        CmdExtend.Enabled = False
        CmdReturn.Enabled = False
    Else
        CmdExtend.Enabled = True
        CmdReturn.Enabled = True
    End If
End Sub
