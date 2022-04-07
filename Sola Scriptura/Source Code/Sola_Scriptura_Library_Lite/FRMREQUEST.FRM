VERSION 5.00
Object = "{AD224A25-CA55-11D2-8C26-444553540001}#2.1#0"; "SWBGradient.ocx"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{20C62CAE-15DA-101B-B9A8-444553540000}#1.1#0"; "MSMAPI32.OCX"
Begin VB.Form FrmRequest 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Send Request of Review Books"
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
   Begin VB.CommandButton CmdCompose 
      Caption         =   "Send Request Email"
      Height          =   375
      Left            =   7080
      TabIndex        =   0
      Top             =   6240
      Width           =   1695
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
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "FrmRequest.frx":0000
      Height          =   5535
      Left            =   0
      TabIndex        =   1
      Top             =   480
      Width           =   8895
      _ExtentX        =   15690
      _ExtentY        =   9763
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
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   510
      Left            =   2760
      Top             =   4920
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   $"FrmRequest.frx":0015
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
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   510
      Left            =   0
      Top             =   4920
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ipclibrary\ipc.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   $"FrmRequest.frx":002F
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
   Begin MSMAPI.MAPIMessages MAPIMessages1 
      Left            =   1320
      Top             =   4800
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      AddressEditFieldCount=   1
      AddressModifiable=   0   'False
      AddressResolveUI=   0   'False
      FetchSorted     =   0   'False
      FetchUnreadOnly =   0   'False
   End
   Begin MSMAPI.MAPISession MAPISession1 
      Left            =   2040
      Top             =   4800
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      DownloadMail    =   -1  'True
      LogonUI         =   -1  'True
      NewSession      =   0   'False
   End
   Begin VB.Label LblList 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "List of people to be requested :"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2400
      TabIndex        =   2
      Top             =   120
      Width           =   3255
   End
   Begin VB.Label LblAdodc2 
      BackColor       =   &H80000009&
      Caption         =   "Adodc2"
      DataField       =   "Title"
      DataSource      =   "Adodc2"
      Height          =   255
      Left            =   4080
      TabIndex        =   3
      Top             =   5040
      Visible         =   0   'False
      Width           =   1215
   End
End
Attribute VB_Name = "FrmRequest"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim themessage1 As String
Dim themessage2 As String
Dim thetotalmessage As String
Dim thesubject As String
Dim iresponse As Integer
Dim saskuser As String
Dim strSQL As String
Dim strSQL2 As String
Dim automatic As Boolean
Dim strSQL3 As String



Private Sub Form_Load()
strSQL = "SELECT Lending_Books.BookID as ID, Title, Lending_Books.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,ReturnDate,Fine,Lending_Books.StatusID,StatusName From Lending_Books,Books,Borrowers,Status WHERE Borrowers.BorrowerID = Lending_Books.BorrowerID and Lending_Books.BookID = Books.BookID and Lending_Books.StatusID = 'R' and Lending_Books.StatusID = Status.StatusID and Lending_Books.SendEmail = false ORDER By ReturnDate"
Adodc1.RecordSource = strSQL
Adodc1.Refresh
ArrangeGrid
strSQL2 = "SELECT Lending_Books.BookID as ID, Title, Lending_Books.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,ReturnDate,Fine,Lending_Books.StatusID,StatusName From Lending_Books,Books,Borrowers,Status WHERE Borrowers.BorrowerID = Lending_Books.BorrowerID and Lending_Books.BookID = Books.BookID and Lending_Books.StatusID = 'R' and Lending_Books.StatusID = Status.StatusID and Lending_Books.SendEmail = false ORDER By ReturnDate"
Adodc2.RecordSource = strSQL
Adodc2.Refresh
End Sub
Private Sub ArrangeGrid()
DataGrid1.Columns(0).Width = 700
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
Private Sub CmdCompose_Click()
automatic = False
saskuser = "Do you want send automatically ?"
iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Send Type")
If iresponse = vbYes Then
    automatic = True
Else
    automatic = False
End If

If Not Adodc2.Recordset.EOF Then
    Adodc2.Recordset.MoveFirst
    While Not Adodc2.Recordset.EOF
            themessage1 = ""
            thetotalmessage = ""
            themessage1 = "Dear " & Adodc2.Recordset.Fields(1) & "," & vbCrLf & vbCrLf
            themessage1 = themessage1 & "      We would like to thank you for your participation with IPCYF Library" & vbCrLf
            themessage1 = themessage1 & "in Borrowing books, cassettes, CD 's, and videos." & vbCrLf
            themessage1 = themessage1 & "      We thank you for reading : " & Adodc2.Recordset.Fields(1) & vbCrLf
            themessage1 = themessage1 & "Having reading that book, we ask your participation to give the comment " & vbCrLf
            themessage1 = themessage1 & "about that book ( if you please to do that ) in our homepage" & vbCrLf
            themessage1 = themessage1 & "Our homepage is www20.brinkster/ipcyf_library" & vbCrLf & vbCrLf
            themessage2 = "If you have any queries regarding our service, you can contact us via email." & vbCrLf
            themessage2 = themessage2 & "      We are looking forward that you will continue your participation with" & vbCrLf
            themessage2 = themessage2 & "IPCYF Library as a frequent participant." & vbCrLf & vbCrLf
            themessage2 = themessage2 & "May God bless you," & vbCrLf & "IPCYF Library Staffs"
            thetotalmessage = thetotalmessage & themessage1
            
            
            thetotalmessage = thetotalmessage & themessage2
            thesubject = "Request - Review " & Adodc2.Recordset.Fields(1)
            
            If automatic = False Then
                If Not IsNull(Adodc2.Recordset.Fields(2)) Then
                    Call SendMessage2(Adodc2.Recordset.Fields(2), Adodc2.Recordset.Fields(2), thesubject, thetotalmessage)
                    saskuser = "Send Successful, Are you sure want to continue to send emails ?"
                Else
                    saskuser = "Email Data Not found, Do you want to send others emails ?"
                End If
                    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Continue")
                If (iresponse = vbYes) Then
                    
                Else
                    MsgBox "Stop sending email", vbInformation, "Information"
                    Exit Sub
                End If
            ElseIf automatic = True Then
                If Not IsNull(Adodc2.Recordset.Fields(2)) Then
                    Call SendMessage(Adodc2.Recordset.Fields(2), Adodc2.Recordset.Fields(2), thesubject, thetotalmessage)
                End If
            End If
            Adodc2.Recordset.Fields(8) = True
            Adodc2.Recordset.Update
            Adodc2.Recordset.MoveNext
    Wend
Else
    MsgBox "No List being sent / already sent!", vbInformation, "Information"
End If
Adodc2.Refresh
Adodc1.Refresh
End Sub

Public Sub SendMessage(RecipName As String, RecipAddress As String, thesubject As String, theMessage As String)
    MAPISession1.SignOn
    MAPIMessages1.SessionID = MAPISession1.SessionID
    MAPIMessages1.Compose
    MAPIMessages1.RecipDisplayName = RecipName
    MAPIMessages1.RecipAddress = RecipAddress
    MAPIMessages1.MsgSubject = thesubject
    MAPIMessages1.MsgNoteText = theMessage
    MAPIMessages1.Send
    MAPISession1.SignOff
End Sub


Public Sub SendMessage2(RecipName As String, RecipAddress As String, thesubject As String, theMessage As String)
    MAPISession1.SignOn
    MAPIMessages1.SessionID = MAPISession1.SessionID
    MAPIMessages1.Compose
    MAPIMessages1.RecipDisplayName = RecipName
    MAPIMessages1.RecipAddress = RecipAddress
    MAPIMessages1.MsgSubject = thesubject
    MAPIMessages1.MsgNoteText = theMessage
    MAPIMessages1.Send True
    MAPISession1.SignOff
End Sub

