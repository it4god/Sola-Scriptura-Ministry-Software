VERSION 5.00
Object = "{AD224A25-CA55-11D2-8C26-444553540001}#2.1#0"; "SWBGRADIENT.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form FrmViewHistory 
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
      Bindings        =   "FrmViewHistory.frx":0000
      Height          =   135
      Left            =   480
      TabIndex        =   7
      Top             =   2040
      Width           =   7935
      _ExtentX        =   13996
      _ExtentY        =   238
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
   Begin SWBGradientCtl.SWBGradient SWBGradient1 
      Left            =   0
      Top             =   0
      _ExtentX        =   423
      _ExtentY        =   423
      StartColor      =   12632256
      EndColor        =   16777215
      Orientation     =   2
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   495
      Left            =   840
      Top             =   5400
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
      TabIndex        =   6
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
      TabIndex        =   5
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
      TabIndex        =   4
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
      TabIndex        =   3
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
      TabIndex        =   2
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
      TabIndex        =   1
      Top             =   480
      Width           =   1215
   End
   Begin VB.Label LblLendingDetails 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "History of borrowing :"
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
End
Attribute VB_Name = "FrmViewHistory"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim strSQL As String

Private Sub Form_Load()
    
    LblID.Caption = CurrentBorrower.ID
    LblFirstName.Caption = CurrentBorrower.FName
    LblLastName.Caption = CurrentBorrower.LName
    strSQL = "SELECT Lending_Books.BookID as ID, Title, LendingDate,ReturnDate,Fine,Lending_Books.StatusID,StatusName From Lending_Books,Books,Borrowers,Status WHERE Borrowers.BorrowerID = Lending_Books.BorrowerID and Lending_Books.BookID = Books.BookID and Lending_Books.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Books.StatusID = Status.StatusID"
    strSQL = strSQL & " UNION " & "SELECT Lending_Cassettes.CassetteID as ID, Title,  LendingDate,ReturnDate,Fine,Lending_Cassettes.StatusID,StatusName From Lending_Cassettes,Cassettes,Borrowers,Status WHERE Borrowers.BorrowerID = Lending_Cassettes.BorrowerID and Lending_Cassettes.CassetteID = Cassettes.CassetteID and  Lending_Cassettes.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Cassettes.StatusID = Status.statusID"
    strSQL = strSQL & " UNION " & "SELECT Lending_CDs.CDID as ID, Title, LendingDate,ReturnDate,Fine,Lending_CDs.StatusID,StatusName From Lending_CDs,CDs,Borrowers,Status WHERE Borrowers.BorrowerID = Lending_CDs.BorrowerID and Lending_CDs.CDID = CDs.CDID and Lending_CDs.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_CDs.StatusID = Status.StatusID"
    strSQL = strSQL & " UNION " & "SELECT Lending_Videos.VideoID as ID, Title, LendingDate,ReturnDate,Fine,Lending_Videos.StatusID,StatusName From Lending_Videos,Videos,Borrowers,Status WHERE Borrowers.BorrowerID = Lending_Videos.BorrowerID and Lending_Videos.VideoID = Videos.VideoID and Lending_Videos.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Videos.StatusID = Status.StatusID"
    Adodc1.RecordSource = strSQL
    Adodc1.Refresh
    ArrangeGrid
End Sub

Private Sub ArrangeGrid()

DataGrid1.Columns(0).Width = 700
DataGrid1.Columns(1).Width = 3000
DataGrid1.Columns(2).Width = 1000
DataGrid1.Columns(3).Width = 1000
DataGrid1.Columns(4).Width = 500
DataGrid1.Columns(5).Width = 500
End Sub
