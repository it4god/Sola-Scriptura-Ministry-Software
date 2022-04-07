VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{38911DA0-E448-11D0-84A3-00DD01104159}#1.1#0"; "COMCT332.OCX"
Begin VB.MDIForm MDIFrmMain 
   BackColor       =   &H00808000&
   Caption         =   "Sola_Scriptura Library Lite ver 1.0 - Charity Edition"
   ClientHeight    =   11190
   ClientLeft      =   60
   ClientTop       =   -2175
   ClientWidth     =   15210
   LinkTopic       =   "MDIForm1"
   Moveable        =   0   'False
   Picture         =   "MDIFrmMain.frx":0000
   ScrollBars      =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin ComCtl3.CoolBar CoolBar1 
      Align           =   1  'Align Top
      Height          =   630
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   15210
      _ExtentX        =   26829
      _ExtentY        =   1111
      BandCount       =   2
      _CBWidth        =   15210
      _CBHeight       =   630
      _Version        =   "6.0.8169"
      Child1          =   "Toolbar1"
      MinWidth1       =   705
      MinHeight1      =   570
      Width1          =   7995
      NewRow1         =   0   'False
      Child2          =   "Picture2"
      MinHeight2      =   495
      NewRow2         =   0   'False
      BandStyle2      =   1
      Begin VB.PictureBox Picture2 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         ForeColor       =   &H80000008&
         Height          =   495
         Left            =   15180
         ScaleHeight     =   465
         ScaleWidth      =   0
         TabIndex        =   2
         Top             =   60
         Width           =   15
      End
      Begin MSComctlLib.Toolbar Toolbar1 
         Height          =   570
         Left            =   165
         TabIndex        =   1
         Top             =   30
         Width           =   14925
         _ExtentX        =   26326
         _ExtentY        =   1005
         ButtonWidth     =   1032
         ButtonHeight    =   1005
         Style           =   1
         ImageList       =   "ImageList1"
         _Version        =   393216
         BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
            NumButtons      =   16
            BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Object.ToolTipText     =   "Add / Update Borrowers"
               ImageIndex      =   2
            EndProperty
            BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Object.ToolTipText     =   "List Borrowers"
               ImageIndex      =   3
            EndProperty
            BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Object.ToolTipText     =   "Add / Update Books"
               ImageIndex      =   4
            EndProperty
            BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Object.ToolTipText     =   "Add / Update Cassettes"
               ImageIndex      =   5
            EndProperty
            BeginProperty Button7 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Object.ToolTipText     =   "Add / Update CDs"
               ImageIndex      =   6
            EndProperty
            BeginProperty Button8 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Object.ToolTipText     =   "Add / Update Videos"
               ImageIndex      =   7
            EndProperty
            BeginProperty Button9 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button10 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               ImageIndex      =   4
            EndProperty
            BeginProperty Button11 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               ImageIndex      =   5
            EndProperty
            BeginProperty Button12 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               ImageIndex      =   6
            EndProperty
            BeginProperty Button13 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               ImageIndex      =   7
            EndProperty
            BeginProperty Button14 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button15 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Object.ToolTipText     =   "Send Overdue Emails"
               ImageIndex      =   10
            EndProperty
            BeginProperty Button16 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Object.ToolTipText     =   "Send Message"
               ImageIndex      =   12
            EndProperty
         EndProperty
      End
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   240
      Top             =   9600
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   32
      ImageHeight     =   32
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   14
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":25070
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":254C2
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":25914
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":25D66
            Key             =   ""
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":261B8
            Key             =   ""
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":265BD
            Key             =   ""
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":26A0F
            Key             =   ""
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":26E6B
            Key             =   ""
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":27185
            Key             =   ""
         EndProperty
         BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":2749F
            Key             =   ""
         EndProperty
         BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":278F1
            Key             =   ""
         EndProperty
         BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":27D43
            Key             =   ""
         EndProperty
         BeginProperty ListImage13 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":28195
            Key             =   ""
         EndProperty
         BeginProperty ListImage14 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIFrmMain.frx":285E7
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Menu Borrowers 
      Caption         =   "&Borrowers"
      Begin VB.Menu AddOrModifyBorrowers 
         Caption         =   "Add/Modify"
      End
      Begin VB.Menu BorrowerList 
         Caption         =   "&List"
      End
   End
   Begin VB.Menu AddOrModifyDatabase 
      Caption         =   "&Add/Modify Catalogue"
      Begin VB.Menu AddOrModifyBooks 
         Caption         =   "&Books"
      End
      Begin VB.Menu AddOrModifyCassettes 
         Caption         =   "&Cassettes"
      End
      Begin VB.Menu AddOrModifyCDs 
         Caption         =   "&CDs"
      End
      Begin VB.Menu AddOrModifyVideos 
         Caption         =   "&Videos"
      End
   End
   Begin VB.Menu Catalogue 
      Caption         =   "Catalogue"
      Begin VB.Menu ViewBooks 
         Caption         =   "&Books"
      End
      Begin VB.Menu ViewCassettes 
         Caption         =   "&Cassettes"
      End
      Begin VB.Menu ViewCDs 
         Caption         =   "&CDs"
      End
      Begin VB.Menu ViewVideos 
         Caption         =   "&Videos"
      End
   End
   Begin VB.Menu Unreturned 
      Caption         =   "&Unreturned"
      Begin VB.Menu UnreturnedAll 
         Caption         =   "&All"
      End
      Begin VB.Menu TheLine4 
         Caption         =   "-"
      End
      Begin VB.Menu UnreturnedBooks 
         Caption         =   "&Books"
      End
      Begin VB.Menu UnreturnedCassettes 
         Caption         =   "&Cassettes"
      End
      Begin VB.Menu UnreturnedCDs 
         Caption         =   "&CDs"
      End
      Begin VB.Menu UnreturnedVideos 
         Caption         =   "&Videos"
      End
   End
   Begin VB.Menu Staff 
      Caption         =   "&Staff"
      Begin VB.Menu BorHistory 
         Caption         =   "Borrowing History"
         Begin VB.Menu BookHistory 
            Caption         =   "Books History"
         End
         Begin VB.Menu CassetteHistory 
            Caption         =   "Cassettes History"
         End
      End
      Begin VB.Menu The_Line5 
         Caption         =   "-"
      End
      Begin VB.Menu SendEmail 
         Caption         =   "Email"
         Begin VB.Menu Email 
            Caption         =   "Send OverDue Email"
         End
         Begin VB.Menu Message 
            Caption         =   "Send Message"
         End
      End
   End
   Begin VB.Menu About 
      Caption         =   "&About"
      Begin VB.Menu AboutMe 
         Caption         =   "About"
      End
      Begin VB.Menu Website 
         Caption         =   "Website"
      End
   End
End
Attribute VB_Name = "MDIFrmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim x As Integer
Dim strSQL As String
Dim BorrowerID As Integer
Dim n As String
Dim l As Integer


Private Sub AboutMe_Click()
FrmAbout.Show
FrmAbout.Tag = 1

End Sub

Private Sub AddOrModifyBooks_Click()
FrmAddOrModifyBooks.Show
FrmAddOrModifyBooks.Tag = 1
End Sub
Private Sub AddOrModifyBorrowers_Click()
FrmAddOrModifyBorrowers.Show
FrmAddOrModifyBorrowers.Tag = 1
End Sub
Private Sub AddOrModifyCassettes_Click()
FrmAddOrModifyCassettes.Show
FrmAddOrModifyCassettes.Tag = 1
End Sub
Private Sub AddOrModifyCDs_Click()
FrmAddOrModifyCDs.Show
FrmAddOrModifyCDs.Tag = 1
End Sub
Private Sub AddOrModifyVideos_Click()
FrmAddOrModifyVideos.Show
FrmAddOrModifyVideos.Tag = 1
End Sub
Private Sub BookedAll_Click()
FrmViewBookedAll.Show
FrmViewBookedAll.Tag = 1
End Sub
Private Sub BookedBooks_Click()
FrmViewBookedBooks.Show
FrmViewBookedBooks.Tag = 1
End Sub
Private Sub BookedCassettes_Click()
FrmViewBookedCassettes.Show
FrmViewBookedCassettes.Tag = 1
End Sub
Private Sub BookedCDs_Click()
FrmViewBookedCDs.Show
FrmViewBookedCDs.Tag = 1
End Sub
Private Sub BookedVideos_Click()
FrmViewBookedVideos.Show
FrmViewBookedVideos.Tag = 1
End Sub

Private Sub BookHistory_Click()
FrmViewBookHistory.Show
FrmViewBookHistory.Tag = 1

End Sub

Private Sub BorrowerList_Click()
FrmViewBorrowers.Show
FrmViewBorrowers.Tag = 1
End Sub
Private Sub BorrowersHistory_Click()
BorrowerID = Val(InputBox("Please Enter BorrowerID"))
strSQL = "SELECT * From Borrowers WHERE BorrowerID = " & BorrowerID
BorrowerData.Open strSQL, cnDatabase
If BorrowerData.EOF Then
    MsgBox "Please Enter the right BorrowerID", vbCritical, "Requirement"
Else
    CurrentBorrower.ID = BorrowerData.Fields(0)
    CurrentBorrower.FName = BorrowerData.Fields(1)
    CurrentBorrower.LName = BorrowerData.Fields(2)
    CurrentBorrower.Valid = True
    FrmViewHistory.Show
    FrmViewHistory.Tag = 1
End If
BorrowerData.Close
End Sub





Private Sub CmdAbout_Click()
MsgBox "Sola Scriptura Library Ver 2.5", vbOKOnly, "About"
End Sub

Private Sub CassetteHistory_Click()
FrmViewCassetteHistory.Show
FrmViewCassetteHistory.Tag = 1
End Sub

Private Sub Email_Click()
FrmSendEmails.Show
FrmSendEmails.Tag = 1
End Sub





Private Sub MDIForm_Load()
Start
x = 0
Set BorrowerData = New Recordset
Set CurrentBorrower = New Borrower
End Sub

Private Sub Message_Click()
FrmMessage.Show
FrmMessage.Tag = 1
End Sub

Private Sub Request_Click()
FrmRequest.Show
FrmRequest.Tag = 1
End Sub

Private Sub Statistics_Click()
FrmStatistics.Show
FrmStatistics.Tag = 1
End Sub

Private Sub Timer1_Timer()
x = x + 1
If x Mod 5 = 1 Then
    MDIFrmMain.Picture = LoadPicture("c:\Sola_Scriptura_Library_Lite\christ.jpg")
    MDIFrmMain.Hide
ElseIf x Mod 5 = 2 Then
    MDIFrmMain.Picture = LoadPicture("c:\Sola_Scriptura_Library_Lite\ascension.jpg")
    MDIFrmMain.Hide
ElseIf x Mod 5 = 3 Then
    MDIFrmMain.Picture = LoadPicture("c:\Sola_Scriptura_Library_Lite\taufan.jpg")
    MDIFrmMain.Hide
ElseIf x Mod 5 = 4 Then
    MDIFrmMain.Picture = LoadPicture("c:\Sola_Scriptura_Library_Lite\prodigalson.jpg")
    MDIFrmMain.Hide
ElseIf x Mod 5 = 0 Then
    MDIFrmMain.Picture = LoadPicture("c:\Sola_Scriptura_Library_Lite\whoami.jpg")
    MDIFrmMain.Hide
Else
End If
MDIFrmMain.Show
End Sub

Private Sub Timer2_Timer()

     n = Left(Right(n, l), l) + Left(n, l)
     MDIFrmMain.Caption = n
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)
If Button.Index = 0 Then
ElseIf Button.Index = 2 Then
    FrmAddOrModifyBorrowers.Show
    FrmAddOrModifyBorrowers.Tag = 1
ElseIf Button.Index = 3 Then
    FrmViewBorrowers.Show
    FrmViewBorrowers.Tag = 1
   

ElseIf Button.Index = 5 Then
    FrmAddOrModifyBooks.Show
    FrmAddOrModifyBooks.Tag = 1
ElseIf Button.Index = 6 Then
    FrmAddOrModifyCassettes.Show
    FrmAddOrModifyCassettes.Tag = 1
ElseIf Button.Index = 7 Then
    FrmAddOrModifyCDs.Show
    FrmAddOrModifyCDs.Tag = 1
ElseIf Button.Index = 8 Then
    FrmAddOrModifyVideos.Show
    FrmAddOrModifyVideos.Tag = 1
ElseIf Button.Index = 9 Then

ElseIf Button.Index = 10 Then
    FrmViewBooks.Show
    FrmViewBooks.Tag = 1
ElseIf Button.Index = 11 Then
    FrmViewCassettes.Show
    FrmViewCassettes.Tag = 1
ElseIf Button.Index = 12 Then
    FrmViewCDs.Show
    FrmViewCDs.Tag = 1
ElseIf Button.Index = 13 Then
    FrmViewVideos.Show
    FrmViewVideos.Tag = 1
ElseIf Button.Index = 15 Then
    FrmSendEmails.Show
    FrmSendEmails.Tag = 1
ElseIf Button.Index = 16 Then
    FrmMessage.Show
    FrmMessage.Tag = 1
ElseIf Button.Index = 16 Then

End If
End Sub
Private Sub UnreturnedAll_Click()
FrmViewUnreturnAll.Show
FrmViewUnreturnAll.Tag = 1
End Sub
Private Sub UnreturnedBooks_Click()
FrmViewUnreturnBooks.Show
FrmViewUnreturnBooks.Tag = 1
End Sub
Private Sub UnreturnedCassettes_Click()
FrmViewUnreturnCassettes.Show
FrmViewUnreturnCassettes.Tag = 1
End Sub
Private Sub UnreturnedCDs_Click()
FrmViewUnreturnCDs.Show
FrmViewUnreturnCDs.Tag = 1
End Sub
Private Sub UnreturnedVideos_Click()
FrmViewUnreturnVideos.Show
FrmViewUnreturnVideos.Tag = 1
End Sub

Private Sub View_Click()

End Sub

Private Sub ViewBooks_Click()
FrmViewBooks.Show
FrmViewBooks.Tag = 1
End Sub
Private Sub ViewCassettes_Click()
FrmViewCassettes.Show
FrmViewCassettes.Tag = 1
End Sub
Private Sub ViewCDs_Click()
FrmViewCDs.Show
FrmViewCDs.Tag = 1
End Sub
Private Sub ViewVideos_Click()
FrmViewVideos.Show
FrmViewVideos.Tag = 1
End Sub

Private Sub Website_Click()
FrmWebsite.Show
FrmWebsite.Tag = 1

End Sub
