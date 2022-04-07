VERSION 5.00
Object = "{AD224A25-CA55-11D2-8C26-444553540001}#2.1#0"; "SWBGRADIENT.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form FrmAddOrModifyBooks 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Add/Modify Books"
   ClientHeight    =   5625
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7410
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   5625
   ScaleWidth      =   7410
   Begin VB.CommandButton CmdHelp 
      Caption         =   "?"
      Height          =   255
      Index           =   5
      Left            =   3840
      TabIndex        =   32
      Top             =   720
      Width           =   495
   End
   Begin VB.CommandButton CmdHelp 
      Caption         =   "?"
      Height          =   255
      Index           =   4
      Left            =   3240
      TabIndex        =   31
      Top             =   4080
      Width           =   495
   End
   Begin VB.CommandButton CmdHelp 
      Caption         =   "?"
      Height          =   255
      Index           =   3
      Left            =   6600
      TabIndex        =   30
      Top             =   3600
      Width           =   495
   End
   Begin VB.CommandButton CmdHelp 
      Caption         =   "?"
      Height          =   255
      Index           =   2
      Left            =   3240
      TabIndex        =   29
      Top             =   3600
      Width           =   495
   End
   Begin VB.CommandButton CmdHelp 
      Caption         =   "?"
      Height          =   255
      Index           =   1
      Left            =   3240
      TabIndex        =   28
      Top             =   3120
      Width           =   495
   End
   Begin VB.CommandButton CmdHelp 
      Caption         =   "?"
      Height          =   255
      Index           =   0
      Left            =   6600
      TabIndex        =   27
      Top             =   2640
      Width           =   495
   End
   Begin VB.ComboBox CboAvailable 
      DataField       =   "Available"
      DataSource      =   "Adodc1"
      Height          =   315
      ItemData        =   "FrmAddOrModifyBooks.frx":0000
      Left            =   1560
      List            =   "FrmAddOrModifyBooks.frx":0010
      TabIndex        =   10
      Text            =   "A"
      Top             =   4080
      Width           =   1575
   End
   Begin VB.ComboBox CboBestCategory 
      DataField       =   "BestCategory"
      DataSource      =   "Adodc1"
      Height          =   315
      ItemData        =   "FrmAddOrModifyBooks.frx":0021
      Left            =   4920
      List            =   "FrmAddOrModifyBooks.frx":002B
      TabIndex        =   9
      Text            =   "N"
      Top             =   3600
      Width           =   1575
   End
   Begin VB.ComboBox CboDetailCategory 
      DataField       =   "DetailCategoryID"
      DataSource      =   "Adodc1"
      Height          =   315
      ItemData        =   "FrmAddOrModifyBooks.frx":0035
      Left            =   1560
      List            =   "FrmAddOrModifyBooks.frx":0063
      TabIndex        =   8
      Top             =   3600
      Width           =   1575
   End
   Begin VB.ComboBox CboCategory 
      DataField       =   "CategoryID"
      DataSource      =   "Adodc1"
      Height          =   315
      ItemData        =   "FrmAddOrModifyBooks.frx":00A2
      Left            =   1560
      List            =   "FrmAddOrModifyBooks.frx":00FD
      TabIndex        =   7
      Text            =   "CL"
      Top             =   3120
      Width           =   1575
   End
   Begin VB.ComboBox CboItemStatus 
      DataField       =   "ItemStatus"
      DataSource      =   "Adodc1"
      Height          =   315
      ItemData        =   "FrmAddOrModifyBooks.frx":017B
      Left            =   4920
      List            =   "FrmAddOrModifyBooks.frx":0188
      TabIndex        =   6
      Text            =   "B"
      Top             =   2640
      Width           =   1575
   End
   Begin VB.TextBox TxtPrice 
      Appearance      =   0  'Flat
      DataField       =   "Price"
      DataSource      =   "Adodc1"
      Height          =   405
      Left            =   1560
      Locked          =   -1  'True
      TabIndex        =   5
      Top             =   2640
      Width           =   2175
   End
   Begin VB.TextBox TxtItemNo 
      Appearance      =   0  'Flat
      DataField       =   "ItemNo"
      DataSource      =   "Adodc1"
      Height          =   405
      Left            =   1560
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   720
      Width           =   2175
   End
   Begin VB.TextBox TxtAuthor 
      Appearance      =   0  'Flat
      DataField       =   "Author"
      DataSource      =   "Adodc1"
      Height          =   405
      Left            =   1560
      Locked          =   -1  'True
      TabIndex        =   3
      Top             =   1680
      Width           =   5535
   End
   Begin VB.TextBox TxtPublisher 
      Appearance      =   0  'Flat
      DataField       =   "Publisher"
      DataSource      =   "Adodc1"
      Height          =   405
      Left            =   1560
      Locked          =   -1  'True
      TabIndex        =   4
      Top             =   2160
      Width           =   5535
   End
   Begin VB.TextBox TxtTitle 
      Appearance      =   0  'Flat
      DataField       =   "Title"
      DataSource      =   "Adodc1"
      Height          =   405
      Left            =   1560
      Locked          =   -1  'True
      TabIndex        =   2
      Top             =   1200
      Width           =   5535
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   120
      Top             =   4440
      Width           =   1215
      _ExtentX        =   2143
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "SELECT * From Books ORDER By ItemNo"
      Caption         =   "Books"
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
   Begin VB.CommandButton CmdAdd 
      Caption         =   "&Add"
      Height          =   495
      Left            =   120
      TabIndex        =   11
      Top             =   4920
      Width           =   735
   End
   Begin VB.CommandButton CmdDelete 
      Caption         =   "&Delete"
      Height          =   495
      Left            =   1080
      TabIndex        =   12
      Top             =   4920
      Width           =   735
   End
   Begin VB.CommandButton CmdEdit 
      Caption         =   "&Edit"
      Height          =   495
      Left            =   2040
      TabIndex        =   13
      Top             =   4920
      Width           =   735
   End
   Begin VB.CommandButton CmdFind 
      Caption         =   "&Find"
      Height          =   495
      Left            =   3000
      TabIndex        =   14
      Top             =   4920
      Width           =   735
   End
   Begin VB.CommandButton CmdSave 
      Caption         =   "&Save"
      Enabled         =   0   'False
      Height          =   495
      Left            =   5040
      TabIndex        =   15
      Top             =   4920
      Width           =   735
   End
   Begin VB.CommandButton CmdCancel 
      Caption         =   "&Cancel"
      Enabled         =   0   'False
      Height          =   495
      Left            =   6000
      TabIndex        =   16
      Top             =   4920
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
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   375
      Left            =   4080
      Top             =   4440
      Visible         =   0   'False
      Width           =   1215
      _ExtentX        =   2143
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "SELECT * From Books"
      Caption         =   "Books"
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
   Begin VB.Label Label4 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Available"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   495
      Left            =   360
      TabIndex        =   26
      Top             =   4080
      Width           =   1095
   End
   Begin VB.Label Label3 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Best Category"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   495
      Left            =   3840
      TabIndex        =   25
      Top             =   3480
      Width           =   1095
   End
   Begin VB.Label Label1 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Detail Category"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   495
      Left            =   360
      TabIndex        =   24
      Top             =   3480
      Width           =   1215
   End
   Begin VB.Label Label2 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Status"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   3840
      TabIndex        =   23
      Top             =   2640
      Width           =   1215
   End
   Begin VB.Label LblCategory 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Category"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   360
      TabIndex        =   22
      Top             =   3120
      Width           =   1215
   End
   Begin VB.Label LblPrice 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Price"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   360
      TabIndex        =   21
      Top             =   2640
      Width           =   1215
   End
   Begin VB.Label LblAdodc2 
      BackColor       =   &H80000009&
      Caption         =   "Adodc2"
      DataField       =   "Title"
      DataSource      =   "Adodc2"
      Height          =   375
      Left            =   5400
      TabIndex        =   20
      Top             =   4440
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.Label LblAuthor 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Author"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   360
      TabIndex        =   19
      Top             =   1680
      Width           =   1215
   End
   Begin VB.Label LblPublisher 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Publisher"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   360
      TabIndex        =   18
      Top             =   2160
      Width           =   1215
   End
   Begin VB.Label LblTitle 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Title"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   360
      TabIndex        =   17
      Top             =   1200
      Width           =   1215
   End
   Begin VB.Label LblID 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Book ID"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   360
      TabIndex        =   0
      Top             =   720
      Width           =   1215
   End
   Begin VB.Image Image1 
      Height          =   5610
      Left            =   0
      Picture         =   "FrmAddOrModifyBooks.frx":0196
      Stretch         =   -1  'True
      Top             =   0
      Width           =   7455
   End
End
Attribute VB_Name = "FrmAddOrModifyBooks"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim edit As Boolean

Private Sub TextLock()
TxtItemNo.Locked = True
TxtTitle.Locked = True
TxtAuthor.Locked = True
TxtPublisher.Locked = True
TxtPrice.Locked = True
CboItemStatus.Locked = True
CboCategory.Locked = True
CboDetailCategory.Locked = True
CboBestCategory.Locked = True
CboAvailable.Locked = True

TxtItemNo.BackColor = vbWhite
TxtTitle.BackColor = vbWhite
TxtAuthor.BackColor = vbWhite
TxtPublisher.BackColor = vbWhite
TxtPrice.BackColor = vbWhite
CboItemStatus.BackColor = vbWhite
CboCategory.BackColor = vbWhite
CboDetailCategory.BackColor = vbWhite
CboBestCategory.BackColor = vbWhite
CboAvailable.BackColor = vbWhite

End Sub
Private Sub TextUnlock()
TxtItemNo.Locked = False
TxtTitle.Locked = False
TxtAuthor.Locked = False
TxtPublisher.Locked = False
TxtPrice.Locked = False
CboItemStatus.Locked = False
CboCategory.Locked = False
CboDetailCategory.Locked = False
CboBestCategory.Locked = False
CboAvailable.Locked = False

TxtItemNo.BackColor = vbYellow
TxtTitle.BackColor = vbYellow
TxtAuthor.BackColor = vbYellow
TxtPublisher.BackColor = vbYellow
TxtPrice.BackColor = vbYellow
CboItemStatus.BackColor = vbYellow
CboCategory.BackColor = vbYellow
CboDetailCategory.BackColor = vbYellow
CboBestCategory.BackColor = vbYellow
CboAvailable.BackColor = vbYellow

End Sub
Private Sub CommandLock()
CmdAdd.Enabled = False
CmdEdit.Enabled = False
CmdDelete.Enabled = False
CmdFind.Enabled = False
CmdSave.Enabled = True
CmdCancel.Enabled = True
End Sub
Private Sub CommandUnlock()
CmdAdd.Enabled = True
CmdEdit.Enabled = True
CmdDelete.Enabled = True
CmdFind.Enabled = True
CmdSave.Enabled = False
CmdCancel.Enabled = False
End Sub

Private Sub CboCategory_Click()
If CboCategory = "Th" Then
    MsgBox "Please Enter Detail Category for Theology Book !", vbInformation, "Information"
    CboDetailCategory.SetFocus
End If
End Sub

Private Sub CmdAdd_Click()
TxtItemNo.SetFocus
TextUnlock
CommandLock

Adodc1.Recordset.AddNew
ComboPrint
End Sub

Private Sub CmdCancel_Click()
Adodc1.Recordset.Cancel
Adodc1.Refresh
TextLock
CommandUnlock
edit = False
End Sub

Private Sub CmdDelete_Click()
Dim iresponse As Integer
Dim saskuser As String
saskuser = "Are you sure want to delete this record ?"
iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Borrowers Table")
If (iresponse = vbYes) Then
   Adodc1.Recordset.Delete
End If
Adodc1.Refresh
End Sub

Private Sub CmdEdit_Click()
TextUnlock
CommandLock
edit = True
End Sub

Private Sub CmdFind_Click()
FrmViewBooks.Hide
FrmViewBooks.Show
FrmViewBooks.Tag = 1
End Sub

Private Sub CmdHelp_Click(Index As Integer)

Select Case Index
Case 0
    itemitem = 0
    FrmDetail.MenuExecute (0)
Case 1
    itemitem = 1
    FrmDetail.MenuExecute (1)
Case 2
    itemitem = 1
    FrmDetail.MenuExecute (2)
Case 3
    itemitem = 0
    FrmDetail.MenuExecute (3)
Case 4
    itemitem = 0
    FrmDetail.MenuExecute (4)
Case 5
    itemitem = 1
    FrmDetail.MenuExecute (5)
End Select

End Sub

Private Sub CmdSave_Click()
If TxtItemNo.Text = "" Then
    MsgBox "Please enter the ItemNo", vbInformation, "Error"
    Exit Sub
Else
Adodc2.RecordSource = "SELECT * From Books WHERE ItemNo = '" & TxtItemNo.Text & "'"
Adodc2.Refresh
If ((Not Adodc2.Recordset.EOF) And edit = False) Then
    MsgBox "Please enter another ID", vbInformation, "Duplicate ID"
    Exit Sub
End If
Adodc1.Recordset.Update
TextLock
CommandUnlock
edit = False
End If
End Sub

Private Sub ComboPrint()
    CboItemStatus.Text = "B"
    CboCategory.Text = "CL"
    CboBestCategory.Text = "N"
    CboAvailable.Text = "A"
End Sub
Private Sub Form_Load()
TextLock
edit = False
End Sub
