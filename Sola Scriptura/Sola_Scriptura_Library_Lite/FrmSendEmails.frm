VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{20C62CAE-15DA-101B-B9A8-444553540000}#1.1#0"; "MSMAPI32.OCX"
Object = "{AD224A25-CA55-11D2-8C26-444553540001}#2.1#0"; "SWBGRADIENT.OCX"
Begin VB.Form FrmSendEmails 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Send Emails"
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
      Caption         =   "Send Emails"
      Height          =   375
      Left            =   7560
      TabIndex        =   0
      Top             =   6000
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
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "FrmSendEmails.frx":0000
      Height          =   5055
      Left            =   240
      TabIndex        =   1
      Top             =   840
      Width           =   8415
      _ExtentX        =   14843
      _ExtentY        =   8916
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
   Begin MSAdodcLib.Adodc Adodc3 
      Height          =   510
      Left            =   4680
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   $"FrmSendEmails.frx":0015
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   $"FrmSendEmails.frx":002D
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
      Left            =   600
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   $"FrmSendEmails.frx":0047
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
   Begin VB.Image Image1 
      Height          =   6570
      Left            =   0
      Picture         =   "FrmSendEmails.frx":007A
      Stretch         =   -1  'True
      Top             =   0
      Width           =   8895
   End
   Begin VB.Label LblList 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "List of Over Due Borrowing : "
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
      Width           =   2175
   End
   Begin VB.Label Lbladodc3 
      BackColor       =   &H80000009&
      Caption         =   "Adodc3"
      DataField       =   "Title"
      DataSource      =   "Adodc3"
      Height          =   255
      Left            =   5880
      TabIndex        =   4
      Top             =   5040
      Visible         =   0   'False
      Width           =   1215
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
Attribute VB_Name = "FrmSendEmails"
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

strSQL = "SELECT Lending_Books.ItemNo as ID, Title, Lending_Books.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,ReturnDate,Fine,Lending_Books.AvailID,AvailName From Lending_Books,Books,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Books.BorrowerID and Lending_Books.ItemNo = Books.ItemNo and (Lending_Books.AvailID = 'B' or lending_books.AvailID = 'E') and Lending_Books.AvailID = Availability.AvailID and fine > 0 ORDER By ReturnDate"
strSQL = strSQL & " UNION " & "SELECT Lending_Cassettes.ItemNo as ID, Title, Lending_Cassettes.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,ReturnDate,Fine,Lending_Cassettes.AvailID,AvailName From Lending_Cassettes,Cassettes,Borrowers,Availability  WHERE Borrowers.BorrowerID = Lending_Cassettes.BorrowerID and Lending_Cassettes.ItemNo = Cassettes.ItemNo and (Lending_Cassettes.AvailID = 'B' or lending_cassettes.AvailID = 'E') and Lending_Cassettes.AvailID = Availability.AvailID  and fine > 0 ORDER By ReturnDate"
strSQL = strSQL & " UNION " & "SELECT Lending_CDs.ItemNo as ID, Title, Lending_CDs.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,ReturnDate,Fine,Lending_CDs.AvailID,AvailName From Lending_CDs,CDs,Borrowers,Availability  WHERE Borrowers.BorrowerID = Lending_CDs.BorrowerID and Lending_CDs.ItemNo = CDs.ItemNo and (Lending_CDs.AvailID = 'B' or Lending_CDs.AvailID = 'E') and Lending_CDs.AvailID = Availability.AvailID  and fine>0 ORDER By ReturnDate"
strSQL = strSQL & " UNION " & "SELECT Lending_Videos.ItemNo as ID, Title, Lending_Videos.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,ReturnDate,Fine,Lending_Videos.AvailID,AvailName From Lending_Videos,Videos,Borrowers,Availability  WHERE Borrowers.BorrowerID = Lending_Videos.BorrowerID and Lending_Videos.ItemNo = Videos.ItemNo and (Lending_Videos.AvailID = 'B' or Lending_Videos.AvailID = 'E') and Lending_Videos.AvailID = Availability.AvailID and fine>0 ORDER By ReturnDate"
Adodc1.RecordSource = strSQL
Adodc1.Refresh
strSQL2 = "SELECT DISTINCT Lending_Books.BorrowerID,FirstName, Email  From Lending_Books,Books,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Books.BorrowerID and Lending_Books.ItemNo = Books.ItemNo and (Lending_Books.AvailID = 'B' or lending_books.AvailID = 'E') and Lending_Books.AvailID = Availability.AvailID and fine > 0"
strSQL2 = strSQL2 & " UNION " & "SELECT DISTINCT Lending_Cassettes.BorrowerID,FirstName, Email From Lending_Cassettes,Cassettes,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Cassettes.BorrowerID and Lending_Cassettes.ItemNo = Cassettes.ItemNo and (Lending_Cassettes.AvailID = 'B' or lending_cassettes.AvailID = 'E') and Lending_Cassettes.AvailID = Availability.AvailID  and fine > 0 "
strSQL2 = strSQL2 & " UNION " & "SELECT DISTINCT Lending_CDs.BorrowerID,FirstName, Email From Lending_CDs,CDs,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_CDs.BorrowerID and Lending_CDs.ItemNo = CDs.ItemNo and (Lending_CDs.AvailID = 'B' or Lending_CDs.AvailID = 'E') and Lending_CDs.AvailID = Availability.AvailID  and fine>0 "
strSQL2 = strSQL2 & " UNION " & "SELECT DISTINCT Lending_Videos.BorrowerID,FirstName, Email From Lending_Videos,Videos,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Videos.BorrowerID and Lending_Videos.ItemNo = Videos.ItemNo and (Lending_Videos.AvailID = 'B' or Lending_Videos.AvailID = 'E') and Lending_Videos.AvailID = Availability.AvailID and fine>0 "
Adodc2.RecordSource = strSQL2
Adodc2.Refresh

ArrangeGrid
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
            themessage1 = themessage1 & "      We would like to thank you for your participation with Sola Scriptura Library" & vbCrLf
            themessage1 = themessage1 & "in Borrowing books, cassettes, CD 's, and videos." & vbCrLf
            themessage1 = themessage1 & "To assist you in continuing to enjoy our service, we would like to" & vbCrLf
            themessage1 = themessage1 & "remind you that your borrowing is overdue." & vbCrLf & vbCrLf
            themessage1 = themessage1 & "Your current borrowings recorded in our system is(are):" & vbCrLf
            strSQL3 = "SELECT Lending_Books.ItemNo as ID, Title, Lending_Books.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,DueDate,Fine,Lending_Books.AvailID,AvailName From Lending_Books,Books,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Books.BorrowerID and Lending_Books.ItemNo = Books.ItemNo and (Lending_Books.AvailID = 'B' or lending_books.AvailID = 'E') and Lending_Books.AvailID = Availability.AvailID and fine > 0 and Lending_Books.BorrowerID =" & Val(Adodc2.Recordset.Fields(0)) & " ORDER By DueDate"
            strSQL3 = strSQL3 & " UNION " & "SELECT Lending_Cassettes.ItemNo as ID, Title, Lending_Cassettes.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,DueDate,Fine,Lending_Cassettes.AvailID,AvailName From Lending_Cassettes,Cassettes,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Cassettes.BorrowerID and Lending_Cassettes.ItemNo = Cassettes.ItemNo and (Lending_Cassettes.AvailID = 'B' or lending_cassettes.AvailID = 'E') and Lending_Cassettes.AvailID = Availability.AvailID  and fine > 0 and Lending_Cassettes.BorrowerID =" & Val(Adodc2.Recordset.Fields(0)) & " ORDER By DueDate"
            strSQL3 = strSQL3 & " UNION " & "SELECT Lending_CDs.ItemNo as ID, Title, Lending_CDs.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,DueDate,Fine,Lending_CDs.AvailID,AvailName From Lending_CDs,CDs,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_CDs.BorrowerID and Lending_CDs.ItemNo = CDs.ItemNo and (Lending_CDs.AvailID = 'B' or Lending_CDs.AvailID = 'E') and Lending_CDs.AvailID = Availability.AvailID  and fine>0 and Lending_CDs.BorrowerID =" & Val(Adodc2.Recordset.Fields(0)) & " ORDER By DueDate"
            strSQL3 = strSQL3 & " UNION " & "SELECT Lending_Videos.ItemNo as ID, Title, Lending_Videos.BorrowerID, FirstName,LastName, Phone, MobilePhone,Email,LendingDate,DueDate,Fine,Lending_Videos.AvailID,AvailName From Lending_Videos,Videos,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Videos.BorrowerID and Lending_Videos.ItemNo = Videos.ItemNo and (Lending_Videos.AvailID = 'B' or Lending_Videos.AvailID = 'E') and Lending_Videos.AvailID = Availability.AvailID and fine>0 and Lending_Videos.BorrowerID =" & Val(Adodc2.Recordset.Fields(0)) & " ORDER By DueDate"
            Adodc3.RecordSource = strSQL3
            Adodc3.Refresh
            Adodc3.Recordset.MoveFirst
            While Not Adodc3.Recordset.EOF
                themessage1 = themessage1 & " - " & Adodc3.Recordset.Fields(0) & " " & Adodc3.Recordset.Fields(1) & vbCrLf
                themessage1 = themessage1 & "    The date of due is :" & Adodc3.Recordset.Fields(9) & vbCrLf & vbCrLf
                Adodc3.Recordset.MoveNext
            Wend
            themessage2 = "If you have any queries regarding our service, you can contact us via email." & vbCrLf
            themessage2 = themessage2 & "      We are looking forward that you will continue your participation with" & vbCrLf
            themessage2 = themessage2 & "Sola Scriptura Library as a frequent participant." & vbCrLf & vbCrLf
            themessage2 = themessage2 & "May God bless you," & vbCrLf & "Sola Scriptura Library Staffs" & vbCrLf & vbCrLf & vbCrLf
            themessage2 = themessage2 & "Sola Scriptura Library website : http://solascript.brinkster.net" & vbCrLf
            themessage2 = themessage2 & "The ID = " & Adodc2.Recordset.Fields(0) & "   The password = " & Adodc2.Recordset.Fields(2) & vbCrLf
            themessage2 = themessage2 & "Sola Scriptura Email Address   : limpingen@gmail.com"
            thetotalmessage = thetotalmessage & themessage1
            
            
            thetotalmessage = thetotalmessage & themessage2
            thesubject = "Notification - Your borrowing is over due"
            
            If automatic = False Then
                If Adodc2.Recordset.Fields(2) <> "no" And Not IsNull(Adodc2.Recordset.Fields(2)) Then
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
               If Adodc2.Recordset.Fields(2) <> "no" And Not IsNull(Adodc2.Recordset.Fields(2)) Then
                    Call SendMessage(Adodc2.Recordset.Fields(2), Adodc2.Recordset.Fields(2), thesubject, thetotalmessage)
                End If
            End If
            Adodc2.Recordset.MoveNext
    Wend
Else
    MsgBox "No Overdue borrowing or Data already send!", vbInformation, "Information"
End If
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

