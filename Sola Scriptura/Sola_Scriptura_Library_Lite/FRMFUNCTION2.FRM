VERSION 5.00
Object = "{AD224A25-CA55-11D2-8C26-444553540001}#2.1#0"; "SWBGRADIENT.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form FrmFunction 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
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
   Tag             =   "0"
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "FrmFunction2.frx":0000
      Height          =   3135
      Left            =   480
      TabIndex        =   12
      Top             =   2040
      Width           =   7935
      _ExtentX        =   13996
      _ExtentY        =   5530
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
            LCID            =   1033
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
            LCID            =   1033
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
   Begin VB.CommandButton CmdReturn 
      Caption         =   "&Return"
      Height          =   375
      Left            =   6240
      TabIndex        =   5
      Top             =   5640
      Width           =   735
   End
   Begin VB.CommandButton CmdExtend 
      Caption         =   "&Extend"
      Height          =   375
      Left            =   5160
      TabIndex        =   4
      Top             =   5640
      Width           =   735
   End
   Begin VB.CommandButton CmdCancel 
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   4080
      TabIndex        =   3
      Top             =   5640
      Width           =   735
   End
   Begin VB.CommandButton CmdConfirm 
      Caption         =   "&Confirm"
      Height          =   375
      Left            =   3000
      TabIndex        =   2
      Top             =   5640
      Width           =   735
   End
   Begin VB.CommandButton CmdAdd 
      Caption         =   "&Add"
      Height          =   375
      Left            =   1920
      TabIndex        =   1
      Top             =   5640
      Width           =   735
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
   Begin MSAdodcLib.Adodc Adodc3 
      Height          =   495
      Left            =   3600
      Top             =   3000
      Visible         =   0   'False
      Width           =   1200
      _ExtentX        =   2117
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Select * From Books"
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
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   495
      Left            =   2400
      Top             =   3000
      Visible         =   0   'False
      Width           =   1200
      _ExtentX        =   2117
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Select * From Books"
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
      Left            =   1200
      Top             =   3000
      Visible         =   0   'False
      Width           =   1200
      _ExtentX        =   2117
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Select * From Books"
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
   Begin VB.Label LblLastName 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   5160
      TabIndex        =   11
      Top             =   960
      Width           =   1215
   End
   Begin VB.Label LblFirstName 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2040
      TabIndex        =   10
      Top             =   960
      Width           =   1215
   End
   Begin VB.Label LblBorrowerID 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "BorrowerID"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   600
      TabIndex        =   9
      Top             =   480
      Width           =   1215
   End
   Begin VB.Label LblFName 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "FirstName"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   600
      TabIndex        =   8
      Top             =   960
      Width           =   1215
   End
   Begin VB.Label LblLName 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "LastName"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   4080
      TabIndex        =   7
      Top             =   960
      Width           =   1215
   End
   Begin VB.Label LblID 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      DataField       =   "BorrowerID"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1920
      TabIndex        =   6
      Top             =   480
      Width           =   1215
   End
   Begin VB.Label LblLendingDetails 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "List of borrowing :"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3120
      TabIndex        =   0
      Top             =   1680
      Width           =   2295
   End
   Begin VB.Line Line2 
      X1              =   360
      X2              =   8400
      Y1              =   1560
      Y2              =   1560
   End
   Begin VB.Label LblAdodc3 
      BackColor       =   &H80000009&
      Caption         =   "Adodc3"
      DataField       =   "Title"
      DataSource      =   "Adodc3"
      Height          =   375
      Left            =   6600
      TabIndex        =   14
      Top             =   3120
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.Label LblAdodc2 
      BackColor       =   &H80000009&
      Caption         =   "Adodc2"
      DataField       =   "Title"
      DataSource      =   "Adodc2"
      Height          =   375
      Left            =   5040
      TabIndex        =   13
      Top             =   3120
      Visible         =   0   'False
      Width           =   1455
   End
End
Attribute VB_Name = "FrmFunction"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim strSQL As String
Dim saskuser As String
Dim iresponse As Integer
Dim BorrowingID As String
Private Sub CmdAdd_Click()
BorrowingID = InputBox$("Please Enter the borrowing ID")
If Mid(BorrowingID, 2, 1) = "B" Then
    Adodc2.RecordSource = "SELECT * From Books WHERE BookID = '" & BorrowingID & "'"
    Adodc2.Refresh
    If Adodc2.Recordset.EOF Then
        MsgBox "Borrow not successful", vbInformation, "BookID not found"
        Exit Sub
    Else
        Call CheckData(BorrowingID, 1, Adodc2.Recordset.Fields(5))
    End If
ElseIf Mid(BorrowingID, 2, 1) = "K" Then
       
    Adodc2.RecordSource = "SELECT * From Cassettes WHERE CassetteID = '" & BorrowingID & "'"
    Adodc2.Refresh
    If Adodc2.Recordset.EOF Then
        MsgBox "Borrow not successful", vbInformation, "Cassette not found"
        Exit Sub
    Else
        Call CheckData(BorrowingID, 2, Adodc2.Recordset.Fields(5))
    End If
   
ElseIf Mid(BorrowingID, 2, 1) = "C" Then
    Adodc2.RecordSource = "SELECT * From CDs WHERE CDID = '" & BorrowingID & "'"
    Adodc2.Refresh
    If Adodc2.Recordset.EOF Then
        MsgBox "Borrow not successful", vbInformation, "CDID not found"
        Exit Sub
    Else
        Call CheckData(BorrowingID, 3, Adodc2.Recordset.Fields(5))
    End If
    
ElseIf Mid(BorrowingID, 2, 1) = "V" Then
    Adodc2.RecordSource = "SELECT * From Videos WHERE VideoID = '" & BorrowingID & "'"
    Adodc2.Refresh
    If Adodc2.Recordset.EOF Then
        MsgBox "Borrow not successful", vbInformation, "BookID not found"
        Exit Sub
    Else
        Call CheckData(BorrowingID, 4, Adodc2.Recordset.Fields(5))
    End If
Else
    MsgBox "The BorrowingID is not valid ID", vbInformation, "Error"
    Exit Sub
End If
IsDataAvailable
End Sub

Private Sub CmdCancel_Click()
If CStr(DataGrid1.Columns(5).value) = "O" Then
    saskuser = "Do " & CurrentBorrower.FName & " want to cancel " & DataGrid1.Columns(1).value & " ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Cancel")
    If iresponse = vbYes Then
    
    Else
        MsgBox "Confirm Canceled", vbInformation, "Information"
        Exit Sub
    End If
    If Mid(DataGrid1.Columns(0).value, 2, 1) = "B" Then
        Adodc2.RecordSource = "SELECT * From Lending_Books WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and BookID = '" & DataGrid1.Columns(0).value & "' and statusid = 'O'"
        Adodc3.RecordSource = "SELECT * From Books Where BookID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "K" Then
        Adodc2.RecordSource = "SELECT * From Lending_Cassettes WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and CassetteID = '" & DataGrid1.Columns(0).value & "' and statusid = 'O'"
        Adodc3.RecordSource = "SELECT * From Cassettes Where CassetteID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "C" Then
        Adodc2.RecordSource = "SELECT * From Lending_CDs WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and CDID = '" & (DataGrid1.Columns(0).value) & "' and statusid = 'O' "
        Adodc3.RecordSource = "SELECT * From CDs Where CDID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "V" Then
        Adodc2.RecordSource = "SELECT * From Lending_Videos WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and VideoID = '" & DataGrid1.Columns(0).value & "' and statusid = 'O' "
        Adodc3.RecordSource = "SELECT * From Videos Where VideoID = '" & DataGrid1.Columns(0).value & "'"
    Else
        MsgBox "The ID is not valid ID", vbInformation, "Error"
        Exit Sub
    End If
    Adodc2.Refresh
    Adodc3.Refresh
    Adodc2.Recordset.Fields(3) = "C"
    Adodc2.Recordset.Update
    Adodc3.Recordset.Fields(5) = "A"
    Adodc3.Recordset.Update
    Adodc3.Refresh
    Adodc2.Refresh
    Adodc1.Refresh
    ArrangeGrid
    IsDataAvailable
    MsgBox "Cancel Successful", vbInformation, "Information"
Else
    MsgBox "Please click the Borrow status one and click the Cancel Button", vbInformation, "Information"
End If
End Sub

Private Sub CmdConfirm_Click()
If CStr(DataGrid1.Columns(5).value) = "O" Then
    saskuser = "Do " & CurrentBorrower.FName & " want to confirm " & DataGrid1.Columns(1).value & " ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Confirm")
    If iresponse = vbYes Then
    
    Else
            MsgBox "Confirm Canceled", vbInformation, "Information"
            Exit Sub
    End If

    If Mid(DataGrid1.Columns(0).value, 2, 1) = "B" Then
        Adodc2.RecordSource = "SELECT * From Lending_Books WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and BookID = '" & DataGrid1.Columns(0).value & "' and statusid = 'O'"
        Adodc3.RecordSource = "SELECT * From Books Where BookID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "K" Then
        Adodc2.RecordSource = "SELECT * From Lending_Cassettes WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and CassetteID = '" & DataGrid1.Columns(0).value & "' and statusid = 'O'"
        Adodc3.RecordSource = "SELECT * From Cassettes Where CassetteID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "C" Then
        Adodc2.RecordSource = "SELECT * From Lending_CDs WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and CDID = '" & (DataGrid1.Columns(0).value) & "' and statusid = 'O' "
        Adodc3.RecordSource = "SELECT * From CDs Where CDID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "V" Then
        Adodc2.RecordSource = "SELECT * From Lending_Videos WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and VideoID = '" & DataGrid1.Columns(0).value & "' and statusid = 'O' "
        Adodc3.RecordSource = "SELECT * From Videos Where VideoID = '" & DataGrid1.Columns(0).value & "'"
    Else
        MsgBox "The ID is not valid ID", vbInformation, "Error"
        Exit Sub
    End If
    Adodc2.Refresh
    Adodc3.Refresh
    Adodc2.Recordset.Fields(3) = "B"
    Adodc2.Recordset.Fields(4) = Date
    Adodc2.Recordset.Fields(5) = Date + 14
    Adodc2.Recordset.Update
    Adodc3.Recordset.Fields(5) = "B"
    Adodc3.Recordset.Update
    Adodc3.Refresh
    Adodc2.Refresh
    Adodc1.Refresh
    ArrangeGrid
    IsDataAvailable
    MsgBox "Confirm Successful", vbInformation, "Information"
Else
    MsgBox "Please select the booking one then click the Confirm", vbInformation, "Information"
End If
End Sub

Private Sub CmdExtend_Click()
If DataGrid1.Columns(5).value = "B" Or DataGrid1.Columns(5).value = "E" Then
If DataGrid1.Columns(5).value = "E" Then
    MsgBox CurrentBorrower.FName & " have already extended the borrowing, so can not extend anymore !", vbInformation, "Information"
    Exit Sub
ElseIf Val(DataGrid1.Columns(4).value) > 0 Then
    MsgBox CurrentBorrower.FName & " must pay " & DataGrid1.Columns(4).value & " and return the borrowing", vbInformation, "Information"
    Exit Sub
Else
    saskuser = "Do " & CurrentBorrower.FName & " want to extend " & DataGrid1.Columns(1).value & " ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Extend")
    If iresponse = vbYes Then
    
    Else
        MsgBox "Extend Canceled", vbInformation, "Information"
        Exit Sub
    End If
    
    
    If Mid(DataGrid1.Columns(0).value, 2, 1) = "B" Then
         Adodc2.RecordSource = "SELECT * From Lending_Books WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and BookID = '" & DataGrid1.Columns(0).value & "' and (statusid = 'B' or statusid = 'E') and Returndate = #" & DataGrid1.Columns(3).value & "#"
         Adodc3.RecordSource = "SELECT * From Books Where BookID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "K" Then
        Adodc2.RecordSource = "SELECT * From Lending_Cassettes WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and CassetteID = '" & DataGrid1.Columns(0).value & "' and (statusid = 'B' or statusid = 'E') and Returndate = #" & DataGrid1.Columns(3).value & "#"
        Adodc3.RecordSource = "SELECT * From Cassettes Where CassetteID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "C" Then
        Adodc2.RecordSource = "SELECT * From Lending_CDs WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and CDID = '" & DataGrid1.Columns(0).value & "' and (statusid = 'B' or statusid = 'E') and Returndate = #" & DataGrid1.Columns(3).value & "#"
        Adodc3.RecordSource = "SELECT * From CDs Where CDID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "V" Then
        Adodc2.RecordSource = "SELECT * From Lending_Videos WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and VideoID = '" & DataGrid1.Columns(0).value & "' and (statusid = 'B' or statusid = 'E') and Returndate = #" & DataGrid1.Columns(3).value & "#"
        Adodc3.RecordSource = "SELECT * From Videos Where VideoID = '" & DataGrid1.Columns(0).value & "'"
    Else
        MsgBox "The ID is not valid ID", vbInformation, "Error"
        Exit Sub
    End If
    Adodc2.Refresh
    Adodc3.Refresh
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
Else
    MsgBox "Please click the borrowing with status 'B' and click Extend", vbInformation, "Information"
End If
End Sub

Private Sub CmdReturn_Click()
If DataGrid1.Columns(5).value = "B" Or DataGrid1.Columns(5) = "E" Then
    saskuser = "Do " & CurrentBorrower.FName & " want to return " & DataGrid1.Columns(1).value & " ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Return")
    If iresponse = vbYes Then
    
    Else
        MsgBox "Return Canceled", vbInformation, "Information"
        Exit Sub
    End If

   

    If Mid(DataGrid1.Columns(0).value, 2, 1) = "B" Then
        Adodc2.RecordSource = "SELECT * From Lending_Books WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and BookID = '" & DataGrid1.Columns(0).value & "' and (statusid = 'B' or statusid = 'E') and Returndate = #" & CDate(DataGrid1.Columns(3).value) & "#"
        Adodc3.RecordSource = "SELECT * From Books Where BookID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "K" Then
        Adodc2.RecordSource = "SELECT * From Lending_Cassettes WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and CassetteID = '" & DataGrid1.Columns(0).value & "' and (statusid = 'B' or statusid = 'E') and Returndate = #" & CDate(DataGrid1.Columns(3).value) & "#"
        Adodc3.RecordSource = "SELECT * From Cassettes Where CassetteID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "C" Then
        Adodc2.RecordSource = "SELECT * From Lending_CDs WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and CDID = '" & DataGrid1.Columns(0).value & "' and (statusid = 'B' or statusid = 'E') and Returndate = #" & CDate(DataGrid1.Columns(3).value) & "#"
        Adodc3.RecordSource = "SELECT * From CDs Where CDID = '" & DataGrid1.Columns(0).value & "'"
    ElseIf Mid(DataGrid1.Columns(0).value, 2, 1) = "V" Then
        Adodc2.RecordSource = "SELECT * From Lending_Videos WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and VideoID = '" & DataGrid1.Columns(0).value & "' and (statusid = 'B' or statusid = 'E') and Returndate = #" & CDate(DataGrid1.Columns(3).value) & "#"
        Adodc3.RecordSource = "SELECT * From Videos Where VideoID = '" & DataGrid1.Columns(0).value & "'"
    Else
        MsgBox "The ID is not valid ID", vbInformation, "Error"
        Exit Sub
    End If
    Adodc2.Refresh
    Adodc3.Refresh
    If Val(DataGrid1.Columns(4).value) > 0 Then
    saskuser = CurrentBorrower.FName & " need to pay " & DataGrid1.Columns(4).value & " because of overdue"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Fine")
        If iresponse = vbYes Then
            Adodc2.Recordset.Fields(7) = True
         Else
            MsgBox CurrentBorrower.FName & " need to pay first !", vbInformation, "Information"
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
Else
    MsgBox "Please click the borrowing with status 'B' or 'E' and click Return", vbInformation, "Information"
End If
End Sub

Private Sub Form_Load()
    LblID.Caption = CurrentBorrower.ID
    LblFirstName.Caption = CurrentBorrower.FName
    LblLastName.Caption = CurrentBorrower.LName
    strSQL = "SELECT Lending_Books.BookID as ID, Title, LendingDate,ReturnDate,Fine,Lending_Books.StatusID,StatusName From Lending_Books,Books,Borrowers,Status WHERE Borrowers.BorrowerID = Lending_Books.BorrowerID and Lending_Books.BookID = Books.BookID and (Lending_Books.StatusID = 'B' or lending_books.statusid = 'E' or lending_books.statusid = 'O') and Lending_Books.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Books.StatusID = Status.StatusID"
    strSQL = strSQL & " UNION " & "SELECT Lending_Cassettes.CassetteID as ID, Title,LendingDate, ReturnDate,Fine,Lending_Cassettes.StatusID,StatusName From Lending_Cassettes,Cassettes,Borrowers,Status WHERE Borrowers.BorrowerID = Lending_Cassettes.BorrowerID and Lending_Cassettes.CassetteID = Cassettes.CassetteID and (Lending_Cassettes.StatusID = 'B' or lending_cassettes.statusid = 'E' or lending_cassettes.statusid = 'O') and Lending_Cassettes.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Cassettes.StatusID = Status.StatusID"
    strSQL = strSQL & " UNION " & "SELECT Lending_CDs.CDID as ID, Title, LendingDate,ReturnDate,Fine,Lending_CDs.StatusID,StatusName From Lending_CDs,CDs,Borrowers,Status WHERE Borrowers.BorrowerID = Lending_CDs.BorrowerID and Lending_CDs.CDID = CDs.CDID and (Lending_CDs.StatusID = 'B' or Lending_CDs.statusid = 'E' or Lending_CDs.statusid = 'O') and Lending_CDs.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_CDs.StatusID = Status.StatusID "
    strSQL = strSQL & " UNION " & "SELECT Lending_Videos.VideoID as ID, Title, LendingDate,ReturnDate,Fine,Lending_Videos.StatusID,StatusName From Lending_Videos,Videos,Borrowers, Status WHERE Borrowers.BorrowerID = Lending_Videos.BorrowerID and Lending_Videos.VideoID = Videos.VideoID and (Lending_Videos.StatusID = 'B' or Lending_Videos.StatusID = 'E' or Lending_Videos.StatusID = 'O') and Lending_Videos.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Videos.StatusID = Status.StatusID"
    Adodc1.RecordSource = strSQL
    Adodc1.Refresh
    ArrangeGrid
    IsDataAvailable
End Sub
Private Sub CheckData(BorrowingID As String, BorrowingName As Integer, StatusID As String)
If StatusID = "0" Then
    saskuser = "Status Item is under Borrowing" & Chr(13) & "Do you want to force ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Confirm")
    If iresponse = vbYes Then
         Call SaveData(BorrowingID, BorrowingName)
    Else
        MsgBox "Borrow not successful", vbInformation, "Information"
    End If
ElseIf StatusID = "B" Or StatusID = "E" Then
     saskuser = "Status Item is not available" & Chr(13) & "Do you want to force ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Confirm")
    If iresponse = vbYes Then
         Call SaveData(BorrowingID, BorrowingName)
    Else
        MsgBox "Borrow not successful", vbInformation, "Information"
    End If
ElseIf StatusID = "A" Then
    Call SaveData(BorrowingID, BorrowingName)
Else
    MsgBox "Status Borrowing Unknown", vbCritical, "Error"
End If
End Sub

Private Sub SaveData(BorrowingID As String, BorrowingName As Integer)
Select Case BorrowingName
Case 1
Adodc3.RecordSource = "SELECT * From Lending_Books"
Case 2
Adodc3.RecordSource = "SELECT * From Lending_Cassettes"
Case 3
Adodc3.RecordSource = "SELECT * From Lending_CDs"
Case 4
Adodc3.RecordSource = "SELECT * From Lending_Videos"
End Select
Adodc3.Refresh
Adodc3.Recordset.AddNew
Adodc3.Recordset.Fields(1) = BorrowingID
Adodc3.Recordset.Fields(2) = CurrentBorrower.ID
Adodc3.Recordset.Fields(3) = "B"
Adodc3.Recordset.Fields(4) = Date
Adodc3.Recordset.Fields(5) = Date + 14
Adodc3.Recordset.Fields(6) = 0
Adodc3.Recordset.Update
Adodc2.Recordset.Fields(5) = "B"
Adodc2.Recordset.Update
Adodc3.Refresh
Adodc2.Refresh
Adodc1.Refresh
ArrangeGrid
IsDataAvailable
MsgBox "Borrow Successful ", vbInformation, "Information"

End Sub
Private Sub ArrangeGrid()

DataGrid1.Columns(0).Width = 700
DataGrid1.Columns(1).Width = 3000
DataGrid1.Columns(2).Width = 1000
DataGrid1.Columns(3).Width = 1000
DataGrid1.Columns(4).Width = 500
DataGrid1.Columns(5).Width = 500
DataGrid1.Columns(6).Width = 1000
End Sub
Private Sub IsDataAvailable()
    If Adodc1.Recordset.EOF Then
        CmdConfirm.Enabled = False
        CmdExtend.Enabled = False
        CmdCancel.Enabled = False
        CmdReturn.Enabled = False
    Else
        CmdConfirm.Enabled = True
        CmdExtend.Enabled = True
        CmdCancel.Enabled = True
        CmdReturn.Enabled = True
    
    End If
End Sub
