VERSION 5.00
Object = "{AD224A25-CA55-11D2-8C26-444553540001}#2.1#0"; "SWBGRADIENT.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form FrmAddOrModifyBorrowers 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Add/Modify Borrowers"
   ClientHeight    =   4665
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7455
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   4665
   ScaleWidth      =   7455
   Tag             =   "0"
   Begin VB.CommandButton CmdFunction 
      Caption         =   "&Function"
      Height          =   255
      Left            =   3720
      TabIndex        =   25
      Top             =   840
      Width           =   975
   End
   Begin VB.CommandButton Command1 
      Caption         =   "X"
      Height          =   255
      Left            =   6960
      TabIndex        =   24
      Top             =   840
      Width           =   255
   End
   Begin VB.CommandButton CmdCancel 
      Caption         =   "&Cancel"
      Enabled         =   0   'False
      Height          =   495
      Left            =   6360
      TabIndex        =   14
      Top             =   3960
      Width           =   735
   End
   Begin VB.CommandButton CmdSave 
      Caption         =   "&Save"
      Enabled         =   0   'False
      Height          =   495
      Left            =   5520
      TabIndex        =   13
      Top             =   3960
      Width           =   735
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   495
      Left            =   6000
      Top             =   3240
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
      RecordSource    =   "SELECT * From Borrowers Order BY BorrowerID"
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
   Begin VB.CommandButton CmdFind 
      Caption         =   "&Find"
      Height          =   495
      Left            =   3120
      TabIndex        =   12
      Top             =   3960
      Width           =   735
   End
   Begin VB.CommandButton CmdEdit 
      Caption         =   "&Edit"
      Height          =   495
      Left            =   2160
      TabIndex        =   11
      Top             =   3960
      Width           =   735
   End
   Begin VB.CommandButton CmdDelete 
      Caption         =   "&Delete"
      Height          =   495
      Left            =   1200
      TabIndex        =   10
      Top             =   3960
      Width           =   735
   End
   Begin VB.CommandButton CmdAdd 
      Caption         =   "&Add"
      Height          =   495
      Left            =   240
      TabIndex        =   9
      Top             =   3960
      Width           =   735
   End
   Begin VB.TextBox TxtEmail 
      DataField       =   "Email"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   1560
      TabIndex        =   8
      Top             =   3240
      Width           =   3495
   End
   Begin VB.TextBox TxtPhone 
      DataField       =   "Phone"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   1560
      TabIndex        =   6
      Top             =   2760
      Width           =   1935
   End
   Begin VB.TextBox TxtSuburb 
      DataField       =   "Suburb"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   1560
      TabIndex        =   4
      Top             =   2280
      Width           =   1935
   End
   Begin VB.TextBox TxtMobilePhone 
      DataField       =   "MobilePhone"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   5280
      TabIndex        =   7
      Top             =   2760
      Width           =   1935
   End
   Begin VB.TextBox TxtPostcode 
      DataField       =   "Postcode"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   5280
      TabIndex        =   5
      Top             =   2280
      Width           =   1935
   End
   Begin VB.TextBox TxtLastName 
      DataField       =   "LastName"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   5280
      TabIndex        =   2
      Top             =   1320
      Width           =   1935
   End
   Begin VB.TextBox TxtAddress 
      DataField       =   "Address"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   1560
      TabIndex        =   3
      Top             =   1800
      Width           =   5655
   End
   Begin VB.TextBox TxtFirstName 
      DataField       =   "FirstName"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   1560
      TabIndex        =   1
      Top             =   1320
      Width           =   1935
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
   Begin VB.Label LblID 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      DataField       =   "BorrowerID"
      DataSource      =   "Adodc1"
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
      Height          =   375
      Left            =   1560
      TabIndex        =   23
      Top             =   840
      Width           =   1215
   End
   Begin VB.Label Label8 
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Email"
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
      Height          =   375
      Left            =   240
      TabIndex        =   22
      Top             =   3240
      Width           =   1215
   End
   Begin VB.Label Label7 
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Mobile Phone"
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
      Height          =   375
      Left            =   3720
      TabIndex        =   21
      Top             =   2760
      Width           =   1215
   End
   Begin VB.Label Label6 
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Phone"
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
      Height          =   375
      Left            =   240
      TabIndex        =   20
      Top             =   2760
      Width           =   1215
   End
   Begin VB.Label Label5 
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Postcode"
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
      Height          =   375
      Left            =   3720
      TabIndex        =   19
      Top             =   2280
      Width           =   1215
   End
   Begin VB.Label Label4 
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Suburb"
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
      Height          =   375
      Left            =   240
      TabIndex        =   18
      Top             =   2280
      Width           =   1215
   End
   Begin VB.Label Label3 
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Address"
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
      Height          =   375
      Left            =   240
      TabIndex        =   17
      Top             =   1800
      Width           =   1215
   End
   Begin VB.Label Label2 
      BackColor       =   &H80000005&
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
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   3720
      TabIndex        =   16
      Top             =   1320
      Width           =   1215
   End
   Begin VB.Label Label1 
      BackColor       =   &H80000005&
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
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   15
      Top             =   1320
      Width           =   1215
   End
   Begin VB.Label LblBorrowerID 
      BackColor       =   &H80000005&
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
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   840
      Width           =   1215
   End
   Begin VB.Image Image1 
      Height          =   4650
      Left            =   0
      Picture         =   "FrmAddOrModifyBorrowers.frx":0000
      Stretch         =   -1  'True
      Top             =   0
      Width           =   7455
   End
End
Attribute VB_Name = "FrmAddOrModifyBorrowers"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim withFrameFlag As Boolean
Dim mFormRegion As Long


Private Sub CmdFunction_Click()
BorrowerID = Val(LblID.Caption)
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

Private Sub Command1_Click()
Unload Me
End Sub

Private Sub Form_Load()
    Adodc1.Refresh
If Adodc1.Recordset.RecordCount > 0 Then Adodc1.Recordset.MoveFirst

End Sub

    
Private Sub TextLock()

TxtFirstName.Locked = True
TxtLastName.Locked = True
TxtAddress.Locked = True
TxtSuburb.Locked = True
TxtPostcode.Locked = True
TxtPhone.Locked = True
TxtMobilePhone.Locked = True
TxtEmail.Locked = True

TxtFirstName.BackColor = vbWhite
TxtLastName.BackColor = vbWhite
TxtAddress.BackColor = vbWhite
TxtSuburb.BackColor = vbWhite
TxtPostcode.BackColor = vbWhite
TxtPhone.BackColor = vbWhite
TxtMobilePhone.BackColor = vbWhite
TxtEmail.BackColor = vbWhite
End Sub
Private Sub TextUnlock()

TxtFirstName.Locked = False
TxtLastName.Locked = False
TxtAddress.Locked = False
TxtSuburb.Locked = False
TxtPostcode.Locked = False
TxtPhone.Locked = False
TxtMobilePhone.Locked = False
TxtEmail.Locked = False

TxtFirstName.BackColor = vbYellow
TxtLastName.BackColor = vbYellow
TxtAddress.BackColor = vbYellow
TxtSuburb.BackColor = vbYellow
TxtPostcode.BackColor = vbYellow
TxtPhone.BackColor = vbYellow
TxtMobilePhone.BackColor = vbYellow
TxtEmail.BackColor = vbYellow
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
Private Sub CmdAdd_Click()
TxtFirstName.SetFocus
TextUnlock
CommandLock
Adodc1.Recordset.AddNew
End Sub


Private Sub CmdCancel_Click()
Adodc1.Recordset.Cancel
Adodc1.Refresh
TextLock
CommandUnlock
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
End Sub

Private Sub CmdFind_Click()
FrmViewBorrowers.Hide
FrmViewBorrowers.Show
FrmViewBorrowers.Tag = 1
End Sub

Private Sub CmdSave_Click()
If TxtFirstName.Text <> "" Or TxtLastName <> "" Then
    If TxtPhone.Text = "" Then TxtPhone.Text = "0"
    If TxtPostcode.Text = "" Then TxtPostcode.Text = "0"
    If TxtMobilePhone.Text = "" Then TxtMobilePhone.Text = "0"
    If TxtEmail.Text = "" Then TxtEmail.Text = "No"
    Adodc1.Recordset.Update
        If Not Adodc1.Recordset.BOF Then
            Adodc1.Recordset.MovePrevious
    Adodc1.Recordset.MoveNext
End If
TextLock
CommandUnlock
Else
    MsgBox "Please Enter FirstName and LastName", vbCritical, "Requirement"
End If
End Sub


