VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{20C62CAE-15DA-101B-B9A8-444553540000}#1.1#0"; "MSMAPI32.OCX"
Begin VB.Form FrmMessage 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Send Message"
   ClientHeight    =   7245
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9855
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   7245
   ScaleWidth      =   9855
   Begin VB.CheckBox Check1 
      BackColor       =   &H80000009&
      Caption         =   "To All Borrowers"
      Height          =   255
      Left            =   360
      TabIndex        =   8
      Top             =   6720
      Width           =   1815
   End
   Begin VB.OptionButton Option2 
      BackColor       =   &H8000000E&
      Caption         =   "Order by FirstName"
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
      Index           =   3
      Left            =   2400
      TabIndex        =   6
      Top             =   3840
      Width           =   2175
   End
   Begin VB.OptionButton Option2 
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
      Index           =   2
      Left            =   480
      TabIndex        =   5
      Top             =   3840
      Value           =   -1  'True
      Width           =   1815
   End
   Begin VB.TextBox TxtSubject 
      Appearance      =   0  'Flat
      Height          =   375
      Left            =   2640
      TabIndex        =   1
      Top             =   4320
      Width           =   5175
   End
   Begin VB.TextBox TxtMessage 
      Appearance      =   0  'Flat
      Height          =   1695
      Left            =   1320
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   2
      Top             =   4800
      Width           =   7455
   End
   Begin VB.CommandButton CmdSendMessage 
      Caption         =   "Send Message"
      Height          =   375
      Left            =   7200
      TabIndex        =   3
      Top             =   6600
      Width           =   1575
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "FrmMessage.frx":0000
      Height          =   2895
      Left            =   240
      TabIndex        =   0
      Top             =   840
      Width           =   9375
      _ExtentX        =   16536
      _ExtentY        =   5106
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
   Begin MSMAPI.MAPIMessages MAPIMessages1 
      Left            =   360
      Top             =   2520
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
      Left            =   1080
      Top             =   2520
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      DownloadMail    =   -1  'True
      LogonUI         =   -1  'True
      NewSession      =   0   'False
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   510
      Left            =   240
      Top             =   2640
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
      RecordSource    =   $"FrmMessage.frx":0015
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
      Left            =   3840
      Top             =   2640
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
      RecordSource    =   $"FrmMessage.frx":0048
      Caption         =   "Adodc2"
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
   Begin VB.Label LblAdodc2 
      Caption         =   "Adodc2"
      DataField       =   "BorrowerID"
      DataSource      =   "Adodc2"
      Height          =   375
      Left            =   5520
      TabIndex        =   7
      Top             =   2640
      Width           =   1695
   End
   Begin VB.Label LblMessage 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Subject :"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   1560
      TabIndex        =   4
      Top             =   4320
      Width           =   975
   End
   Begin VB.Image Image1 
      Height          =   7170
      Left            =   0
      Picture         =   "FrmMessage.frx":007B
      Stretch         =   -1  'True
      Top             =   0
      Width           =   9855
   End
End
Attribute VB_Name = "FrmMessage"
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

Private Sub CmdSendMessage_Click()
If Adodc1.Recordset.RecordCount > 0 Then
Adodc2.RecordSource = "SELECT BorrowerID, FirstName, Email From Borrowers WHERE BorrowerID =" & Val(DataGrid1.Columns(0).Value)
Adodc2.Refresh
automatic = False
If Check1.Value = 1 Then
    saskuser = "Do you want to send message to all Borrowers ?"
Else
    saskuser = "Do you want to send message to the clicked Borrowers ?"
End If
iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Send To")
If iresponse = vbYes Then
    
Else
    Exit Sub
End If
saskuser = "Do you want send automatically ?"
iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Send Type")
If iresponse = vbYes Then
    automatic = True
Else
    automatic = False
End If
If Check1.Value = 1 Then
    SendToAllBorrower (automatic)
Else
    SendToSpecificBorrower (automatic)
End If
End If
End Sub

Private Sub SendToAllBorrower(automatic As Boolean)
    If Not Adodc1.Recordset.EOF Then
    Adodc1.Recordset.MoveFirst
    While Not Adodc1.Recordset.EOF
            themessage1 = ""
            thetotalmessage = ""
            themessage1 = "Dear " & Adodc1.Recordset.Fields(1) & "," & vbCrLf & vbCrLf
            themessage1 = themessage1 & "      We would like to thank you for your participation with Sola Scriptura Library" & vbCrLf
            themessage1 = themessage1 & "in Borrowing books, cassettes, CD 's, and videos." & vbCrLf
            themessage1 = themessage1 & vbCrLf & TxtMessage.Text & vbCrLf & vbCrLf
            themessage2 = "If you have any queries regarding our service, you can contact us via email." & vbCrLf
            themessage2 = themessage2 & "      We are looking forward that you will continue your participation with" & vbCrLf
            themessage2 = themessage2 & "Sola Scriptura Library as a frequent participant." & vbCrLf & vbCrLf
            themessage2 = themessage2 & "May God bless you," & vbCrLf & "Sola Scriptura Library Staffs" & vbCrLf & vbCrLf
            themessage2 = themessage2 & "Sola Scriptura Email Address   : Sola_Scriptura_library@hotmail.com"
            thetotalmessage = thetotalmessage & themessage1
            thetotalmessage = thetotalmessage & themessage2
            thesubject = TxtSubject.Text
                        
            If automatic = False Then
                If Not IsNull(Adodc1.Recordset.Fields(8)) Then
                    Call SendMessage2(Adodc1.Recordset.Fields(8), Adodc1.Recordset.Fields(8), thesubject, thetotalmessage)
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
                If Not IsNull(Adodc1.Recordset.Fields(8)) Then
                    Call SendMessage(Adodc1.Recordset.Fields(8), Adodc1.Recordset.Fields(8), thesubject, thetotalmessage)
                End If
            End If
            Adodc1.Recordset.MoveNext
    Wend
Else
    MsgBox "No Borrower Data!", vbInformation, "Information"
End If
End Sub

Private Sub SendToSpecificBorrower(automatic As Boolean)

            themessage1 = ""
            thetotalmessage = ""
            themessage1 = "Dear " & Adodc2.Recordset.Fields(1) & "," & vbCrLf & vbCrLf
            themessage1 = themessage1 & "      We would like to thank you for your participation with Sola Scriptura Library" & vbCrLf
            themessage1 = themessage1 & "in Borrowing books, cassettes, CD 's, and videos." & vbCrLf
            themessage1 = themessage1 & vbCrLf & TxtMessage.Text & vbCrLf & vbCrLf
            themessage2 = "If you have any queries regarding our service, you can contact us via email." & vbCrLf
            themessage2 = themessage2 & "      We are looking forward that you will continue your participation with" & vbCrLf
            themessage2 = themessage2 & "Sola Scriptura Library as a frequent participant." & vbCrLf & vbCrLf
            themessage2 = themessage2 & "May God bless you," & vbCrLf & "Sola Scriptura Library Staffs" & vbCrLf & vbCrLf
            themessage2 = themessage2 & "Sola Scriptura Email Address   : Sola_Scriptura_library@hotmail.com"
            thetotalmessage = thetotalmessage & themessage1
            thetotalmessage = thetotalmessage & themessage2
            thesubject = TxtSubject.Text
                        
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

End Sub
Private Sub Option2_Click(Index As Integer)
Select Case Index
Case 2
    Adodc1.RecordSource = "Select * from Borrowers order by BorrowerID"

Case 3
    Adodc1.RecordSource = "Select * from Borrowers order by FirstName"

End Select
Adodc1.Refresh
Adodc2.RecordSource = "SELECT BorrowerID, FirstName, Email From Borrowers WHERE BorrowerID =" & Val(DataGrid1.Columns(0).Value)
Adodc2.Refresh
ArrangeGrid
End Sub
Private Sub Form_Load()

ArrangeGrid
End Sub

Private Sub Option1_Click(Index As Integer)
Select Case Index
    Case 0
        
    Case 1
        MsgBox "Please click the borrower data, fill the subject & message and click Send Message!", vbInformation, "Information"
End Select
End Sub
Private Sub ArrangeGrid()
DataGrid1.Columns(0).Width = 500
DataGrid1.Columns(1).Width = 1000
DataGrid1.Columns(2).Width = 1000
DataGrid1.Columns(3).Width = 2500
DataGrid1.Columns(4).Width = 1000
DataGrid1.Columns(5).Width = 700
DataGrid1.Columns(6).Width = 800
DataGrid1.Columns(7).Width = 1000
DataGrid1.Columns(8).Width = 2500
End Sub
