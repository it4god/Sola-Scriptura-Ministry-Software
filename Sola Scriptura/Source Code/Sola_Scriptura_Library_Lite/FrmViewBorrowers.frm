VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{20C62CAE-15DA-101B-B9A8-444553540000}#1.1#0"; "MSMAPI32.OCX"
Begin VB.Form FrmViewBorrowers 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "View Borrowers"
   ClientHeight    =   8130
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   10905
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   8130
   ScaleWidth      =   10905
   Begin VB.TextBox TxtBorrowers 
      Height          =   375
      Left            =   240
      TabIndex        =   9
      Top             =   7440
      Width           =   3495
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H80000009&
      Height          =   855
      Left            =   6120
      TabIndex        =   5
      Top             =   7080
      Width           =   2175
      Begin VB.CommandButton CmdEdit 
         Caption         =   "Edit"
         Height          =   375
         Left            =   1080
         TabIndex        =   7
         Top             =   240
         Width           =   855
      End
      Begin VB.CommandButton CmdFunction 
         Caption         =   "Function"
         Height          =   375
         Left            =   120
         TabIndex        =   6
         Top             =   240
         Width           =   855
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H80000009&
      Height          =   855
      Left            =   8520
      TabIndex        =   3
      Top             =   7080
      Width           =   2295
      Begin VB.CommandButton CmdSendEmail 
         Caption         =   "Send Data Completion"
         Height          =   375
         Left            =   240
         TabIndex        =   4
         Top             =   240
         Width           =   1815
      End
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
      TabIndex        =   2
      Top             =   6960
      Width           =   1575
   End
   Begin VB.OptionButton Option1 
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
      Index           =   1
      Left            =   1920
      TabIndex        =   1
      Top             =   6960
      Value           =   -1  'True
      Width           =   2055
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "FrmViewBorrowers.frx":0000
      Height          =   5895
      Left            =   240
      TabIndex        =   0
      Top             =   960
      Width           =   10455
      _ExtentX        =   18441
      _ExtentY        =   10398
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
      Left            =   240
      Top             =   5280
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
      Left            =   960
      Top             =   5280
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
      Top             =   5160
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
      RecordSource    =   $"FrmViewBorrowers.frx":0015
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
      Left            =   3000
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
      RecordSource    =   $"FrmViewBorrowers.frx":0048
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
      Height          =   8130
      Left            =   0
      Picture         =   "FrmViewBorrowers.frx":007B
      Stretch         =   -1  'True
      Top             =   0
      Width           =   10935
   End
   Begin VB.Label LblAdodc2 
      Caption         =   "Adodc2"
      DataField       =   "BorrowerID"
      DataSource      =   "Adodc2"
      Height          =   495
      Left            =   4680
      TabIndex        =   8
      Top             =   4920
      Width           =   2055
   End
End
Attribute VB_Name = "FrmViewBorrowers"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Dim BorrowerID As Integer
Dim thetotalmessage As String
Dim themessage1 As String
Dim thesubject As String
Dim sakuser As String
Dim iresponse As Integer


Private Sub CmdEdit_Click()
FrmAddOrModifyBorrowers.Hide
FrmAddOrModifyBorrowers.Show
    With FrmAddOrModifyBorrowers.Adodc1.Recordset
        .MoveFirst
        While Not .EOF
            If .Fields(0) = Val(DataGrid1.Columns(0).Value) Then
                Me.Hide
                Exit Sub
            End If
        .MoveNext
        Wend
    End With
End Sub

Private Sub CmdFunction_Click()
BorrowerID = Val(DataGrid1.Columns(0).Value)
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


Private Sub CmdSendEmail_Click()
           saskuser = "Will send email automatically about Borrower's incomplete data ?"
           iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Continue")
                If iresponse = vbYes Then
                
                Else
                   MsgBox "Stop sending Email", vbInformation, "Information"
                    Exit Sub
                End If
    If Not Adodc1.Recordset.EOF Then
        With Adodc1.Recordset
         .MoveFirst
         
         While Not .EOF
                
         If (IsNull(.Fields(3)) = True Or IsNull(.Fields(4)) = True) Or (Val(.Fields(5)) = 0) Or (IsNull(.Fields(6)) = True) And Val(.Fields(7)) = 0 Then
                If IsNull(.Fields(8)) Or .Fields(8) = "no" Or .Fields(8) = "NO" Then
                    saskuser = "Email Data Not found, Do you want to send others emails ?"
                Else
                    thetotalmessage = ""
                    thesubject = ""
                    themessage1 = ""
                    thesubject = "Notification - Your Data in our system is incomplete"
                    thetotalmessage = "Dear " & .Fields(2) & "," & vbCrLf & vbCrLf
                    themessage1 = themessage1 & "      We would like to thank you for your participation with Sola Scriptura Library" & vbCrLf
                    themessage1 = themessage1 & "in Borrowing books, cassettes, CD 's, and videos." & vbCrLf
                    themessage1 = themessage1 & "      To help our service in computer system, we would like to" & vbCrLf
                    themessage1 = themessage1 & "remind you that your data in our system is incomplete" & vbCrLf
                    themessage1 = themessage1 & "The incomplete data needed is as follow : " & vbCrLf
                    themessage1 = themessage1 & "Address : _____________________" & vbCrLf
                    themessage1 = themessage1 & "Suburb  : _____________________" & vbCrLf
                    themessage1 = themessage1 & "Postcode : ____________ " & vbCrLf
                    themessage1 = themessage1 & "Telephone : ___________  " & vbCrLf
                    themessage1 = themessage1 & "MobilePhone : __________  " & vbCrLf & vbCrLf
                    themessage1 = themessage1 & "       Please send your complete data via email " & vbCrLf
                    themessage1 = themessage1 & "to Sola Scriptura_library@hotmail.com" & vbCrLf & vbCrLf
                    themessage1 = themessage1 & "       If you have any queries regarding our service, you can contact us via email." & vbCrLf
                    themessage1 = themessage1 & "      We are looking forward that you will continue your participation with" & vbCrLf
                    themessage1 = themessage1 & "Sola Scriptura Library as a frequent participant." & vbCrLf & vbCrLf
                    themessage1 = themessage1 & "May God bless you," & vbCrLf & "Sola Scriptura Library Staffs" & vbCrLf & vbCrLf
                    themessage1 = themessage1 & "Sola Scriptura Library website : http://go.to/Sola_Scriptura_Library_Lite or http://run.to/Sola_Scriptura_Library_Lite" & vbCrLf
                    themessage1 = themessage1 & "The ID = " & Adodc1.Recordset.Fields(0) & "   The password = " & Adodc1.Recordset.Fields(8) & vbCrLf
                    themessage1 = themessage1 & "Sola Scriptura Email Address   : Sola Scriptura_library@hotmail.com"
                    thetotalmessage = thetotalmessage & themessage1
                    Call SendMessage(.Fields(8), .Fields(8), thesubject, thetotalmessage)
                    'saskuser = "Send Successful, Are you sure want to continue to send emails ?"
                End If
                'iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Continue")
                'If iresponse = vbYes Then
                
                'Else
                 '   MsgBox "Stop sending Email", vbInformation, "Information"
                '    Exit Sub
                'End If
         End If
         .MoveNext
         Wend
         End With
    Else
        MsgBox "Please Enter the Borrower Data first", vbInformation, "Information"
    End If
End Sub

Private Sub CmdSendID_Click()


saskuser = "Will send email about ID and password ?"
iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Continue")
If iresponse = vbYes Then
       
Else
     MsgBox "Stop sending Email", vbInformation, "Information"
     Exit Sub
End If

saskuser = "Will send email about ID and password automatically?"
iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Continue")
If iresponse = vbYes Then
      If Not Adodc2.Recordset.EOF Then Adodc2.Recordset.MoveFirst
    If Not Adodc2.Recordset.EOF Then
    With Adodc2.Recordset
         .MoveFirst
         While Not .EOF
             If .Fields(9) = False Then
                    If IsNull(.Fields(8)) Or .Fields(8) = "no" Then
                        saskuser = "Email Data Not found, Do you want to send others emails ?"
                    Else
                        thetotalmessage = ""
                        thesubject = ""
                        themessage1 = ""
                        thesubject = "Sola Scriptura Library Homepage - id & password given"
                        thetotalmessage = "Dear " & .Fields(2) & "," & vbCrLf & vbCrLf
                        themessage1 = themessage1 & "      We would like to thank you for your participation with Sola Scriptura Library" & vbCrLf
                        themessage1 = themessage1 & "in Borrowing books, cassettes, CD 's, and videos." & vbCrLf
                        themessage1 = themessage1 & "      To improve our service, we have designed a homepage for Sola Scriptura Library" & vbCrLf
                        themessage1 = themessage1 & "In our homepage, you can do :" & vbCrLf
                        themessage1 = themessage1 & "> See Catalogue, Book's Description including image of book" & vbCrLf
                        themessage1 = themessage1 & "> Order book(s)" & vbCrLf
                        themessage1 = themessage1 & "> Links to bookstore, theological seminary" & vbCrLf
                        themessage1 = themessage1 & "> Etc" & vbCrLf & vbCrLf
                        themessage1 = themessage1 & "       Our homepage is http://go.to/Sola_Scriptura_Library_Lite or http://run.to/Sola_Scriptura_Library_Lite" & vbCrLf
                        themessage1 = themessage1 & "To access our home page, we will give you a ID" & vbCrLf
                        themessage1 = themessage1 & "The BorrowerID = " & .Fields(0) & vbCrLf
                        themessage1 = themessage1 & "The Email Address as password = " & .Fields(8) & vbCrLf & vbCrLf
                        themessage1 = themessage1 & "      If you have any queries regarding our service, you can contact us via email." & vbCrLf
                        themessage1 = themessage1 & "      We are looking forward that you will continue your participation with" & vbCrLf
                        themessage1 = themessage1 & "Sola Scriptura Library as a frequent participant." & vbCrLf & vbCrLf
                        themessage1 = themessage1 & "May God bless you," & vbCrLf & "Sola Scriptura Library Staffs"
                        themessage1 = themessage1 & "Sola Scriptura Library website : http://go.to/Sola_Scriptura_Library_Lite or http://run.to/Sola_Scriptura_Library_Lite" & vbCrLf
                        thetotalmessage = thetotalmessage & themessage1
                        Call SendMessage(.Fields(8), .Fields(8), thesubject, thetotalmessage)
                        saskuser = "Send Successful, Are you sure want to continue to send emails ?"
                   End If
               
                   Adodc2.Recordset.Fields(9) = True
                   Adodc2.Recordset.Update
             End If
             .MoveNext
         Wend
    End With
    Else
        MsgBox "Please Enter the Borrower Data first", vbInformation, "Information"
    End If
Else
    If Not Adodc2.Recordset.EOF Then Adodc2.Recordset.MoveFirst
    If Not Adodc2.Recordset.EOF Then
    With Adodc2.Recordset
         .MoveFirst
         While Not .EOF
             If .Fields(9) = False Then
                    If IsNull(.Fields(8)) Or .Fields(8) = "no" Then
                        saskuser = "Email Data Not found, Do you want to send others emails ?"
                    Else
        thetotalmessage = ""
                        thesubject = ""
                        themessage1 = ""
                        thesubject = "Sola Scriptura Library Homepage - id & password given"
                        thetotalmessage = "Dear " & .Fields(2) & "," & vbCrLf & vbCrLf
                        themessage1 = themessage1 & "      We would like to thank you for your participation with Sola Scriptura Library" & vbCrLf
                        themessage1 = themessage1 & "in Borrowing books, cassettes, CD 's, and videos." & vbCrLf
                        themessage1 = themessage1 & "      To improve our service, we have designed a homepage for Sola Scriptura Library" & vbCrLf
                        themessage1 = themessage1 & "In our homepage, you can do :" & vbCrLf
                    
                        themessage1 = themessage1 & "> See Catalogue, Book's Description including image of book" & vbCrLf
                        themessage1 = themessage1 & "> Order book(s)" & vbCrLf
                        themessage1 = themessage1 & "> Links to bookstore, theological seminary" & vbCrLf
                        themessage1 = themessage1 & "> Etc" & vbCrLf & vbCrLf
                        themessage1 = themessage1 & "       Our homepage is http://go.to/Sola_Scriptura_Library_Lite or http://run.to/Sola_Scriptura_Library_Lite" & vbCrLf
                        themessage1 = themessage1 & "To access our home page, we will give you a ID" & vbCrLf
                        themessage1 = themessage1 & "The BorrowerID = " & .Fields(0) & vbCrLf
                        themessage1 = themessage1 & "The Email Address as password = " & .Fields(8) & vbCrLf & vbCrLf
                        themessage1 = themessage1 & "      If you have any queries regarding our service, you can contact us via email." & vbCrLf
                        themessage1 = themessage1 & "      We are looking forward that you will continue your participation with" & vbCrLf
                        themessage1 = themessage1 & "Sola Scriptura Library as a frequent participant." & vbCrLf & vbCrLf
                        themessage1 = themessage1 & "May God bless you," & vbCrLf & "Sola Scriptura Library Staffs"
                        thetotalmessage = thetotalmessage & themessage1
                        Call SendMessage2(.Fields(8), .Fields(8), thesubject, thetotalmessage)
                        saskuser = "Send Successful, Are you sure want to continue to send emails ?"
                   End If
                        iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Continue")
                   If iresponse = vbYes Then
            
                      Else
                       MsgBox "Stop sending Email", vbInformation, "Information"
                       Exit Sub
                   End If
                   Adodc2.Recordset.Fields(9) = True
                   Adodc2.Recordset.Update
             End If
             .MoveNext
         Wend
    End With
    Else
        MsgBox "Please Enter the Borrower Data first", vbInformation, "Information"
    End If

End If
End Sub

Private Sub Form_Load()

    Adodc1.RecordSource = "Select * from Borrowers order by FirstName"
    Adodc2.RecordSource = "Select * from Borrowers order by BorrowerID"
    
Adodc1.Refresh
Adodc2.Refresh
ArrangeGrid

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

Private Sub TxtBorrowers_Change()
    If Option1(0).Value = True Then
        Adodc1.RecordSource = "SELECT * From Borrowers WHERE FirstName >= '" & TxtBorrowers.Text & "' ORDER By BorrowerID"
    Else
        Adodc1.RecordSource = "SELECT * From Borrowers WHERE FirstName >= '" & TxtBorrowers.Text & "' ORDER By FirstName"
    End If
    Adodc1.Refresh
ArrangeGrid
End Sub
Private Sub Option1_Click(Index As Integer)
Select Case Index
Case 0
    Adodc1.RecordSource = "Select * from Borrowers order by BorrowerID"

Case 1
    Adodc1.RecordSource = "Select * from Borrowers order by FirstName"

End Select
Adodc1.Refresh
ArrangeGrid
End Sub
