VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form FrmAddUser 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00DC7F59&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Add / Delete User"
   ClientHeight    =   6525
   ClientLeft      =   -135
   ClientTop       =   330
   ClientWidth     =   7725
   FillColor       =   &H00808080&
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   6525
   ScaleWidth      =   7725
   Tag             =   "100"
   Begin VB.ComboBox CboAuthority 
      Height          =   315
      ItemData        =   "FrmAddUser.frx":0000
      Left            =   3120
      List            =   "FrmAddUser.frx":000A
      Sorted          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   4
      Top             =   2280
      Width           =   3255
   End
   Begin VB.TextBox TxtNewPassword 
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   3120
      PasswordChar    =   "*"
      TabIndex        =   2
      Top             =   1320
      Width           =   3195
   End
   Begin MSDataGridLib.DataGrid DataGridAddUser 
      Height          =   3015
      Left            =   1200
      TabIndex        =   8
      Top             =   3360
      Width           =   6255
      _ExtentX        =   11033
      _ExtentY        =   5318
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
   Begin VB.TextBox TxtUserName 
      Height          =   285
      Left            =   3120
      TabIndex        =   1
      Top             =   840
      Width           =   3195
   End
   Begin VB.TextBox TxtConfirmPassword 
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   3120
      PasswordChar    =   "*"
      TabIndex        =   3
      Top             =   1800
      Width           =   3195
   End
   Begin VB.Label LblDelete 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Delete"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   360
      Left            =   3480
      TabIndex        =   6
      Top             =   2880
      Width           =   1965
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Authority"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1320
      TabIndex        =   10
      Top             =   2280
      Width           =   1935
   End
   Begin VB.Label LblAlamat 
      BackStyle       =   0  'Transparent
      Caption         =   "Password"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1320
      TabIndex        =   9
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Label lblAdd 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Add"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   360
      Left            =   1320
      TabIndex        =   5
      Top             =   2880
      Width           =   1965
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "User Name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1320
      TabIndex        =   0
      Top             =   840
      Width           =   1935
   End
   Begin VB.Label lblTelepon 
      BackStyle       =   0  'Transparent
      Caption         =   "Confirm Password"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1320
      TabIndex        =   7
      Top             =   1800
      Width           =   1935
   End
   Begin VB.Image Image1 
      Height          =   6540
      Left            =   120
      Picture         =   "FrmAddUser.frx":0023
      Stretch         =   -1  'True
      Top             =   0
      Width           =   840
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   6720
      Picture         =   "FrmAddUser.frx":6122D
      Top             =   1560
      Width           =   645
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   6720
      Picture         =   "FrmAddUser.frx":61C6E
      Top             =   840
      Width           =   645
   End
   Begin VB.Image ImgEdit 
      Height          =   495
      Left            =   1320
      Picture         =   "FrmAddUser.frx":625CC
      Top             =   2760
      Width           =   1980
   End
   Begin VB.Image Image2 
      Height          =   495
      Left            =   3480
      Picture         =   "FrmAddUser.frx":630C0
      Top             =   2760
      Width           =   1980
   End
   Begin VB.Image Img1 
      Height          =   6540
      Left            =   960
      Picture         =   "FrmAddUser.frx":63BB4
      Stretch         =   -1  'True
      Top             =   0
      Width           =   6720
   End
End
Attribute VB_Name = "FrmAddUser"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim mylogin As ClsLogin
Dim myitem As ClsItemServer
Dim rs As ADODB.Recordset
Dim MyUser As User
Dim MyUserBuffer As User_Buffer


Private Sub CboAuthority_Click()
If CboAuthority.Text = "User" Then
    MyUser.UserAuthority = "2"
ElseIf CboAuthority.Text = "Administrator" Then
    MyUser.UserAuthority = "1"
End If

End Sub

Private Sub Form_Load()
CenterChildForm2 Me
Set myitem = New ClsItemServer
Set rs = myitem.GetUser
Set DataGridAddUser.DataSource = rs
If rs.RecordCount > 0 Then
    lblDelete.Enabled = True
Else
    lblDelete.Enabled = False
End If
MyUser.UserName = ""
MyUser.UserPassword = ""
MyUser.UserAuthority = "2"
CboAuthority.Text = "User"
End Sub


Private Sub imgQuit_Click()
Unload Me
End Sub

Private Sub lblAdd_Click()
If TxtNewPassword.Text <> TxtConfirmPassword.Text Then
    MsgBox "The Password is not match with Confirm Password !", vbInformation, "Information"
Else
    If rs.RecordCount > 0 Then
        rs.MoveFirst
        While Not rs.EOF
            If Trim(DataGridAddUser.Columns(1).Value) = Trim(MyUser.UserName) Then
                MsgBox "The UserName is already registered. Please try another UserName !", vbInformation, "Information"
                Exit Sub
                       
            End If
            
            rs.MoveNext
        Wend
        Set myitem = New ClsItemServer
        LSet MyUserBuffer = MyUser
        Dim saveok As Boolean
        saveok = myitem.saveUser(MyUserBuffer.Buffer)
        If saveok = True Then
            MsgBox "New user added !", vbInformation, "Information"
            TxtUserName.Text = ""
            TxtNewPassword.Text = ""
            TxtConfirmPassword.Text = ""
            MyUser.UserName = ""
            MyUser.UserPassword = ""
            MyUser.UserAuthority = "2"
            CboAuthority.Text = "User"
            Set myitem = New ClsItemServer
            Set rs = myitem.GetUser
            Set DataGridAddUser.DataSource = rs
            If rs.RecordCount > 0 Then
                lblDelete.Enabled = True
            Else
                lblDelete.Enabled = False
            End If
        End If
    End If
End If
End Sub

Private Sub LblDelete_Click()
     Dim iresponse As Long
        Dim saskUSER As String
        saskUSER = "Are you sure want to delete User with UserName  = " & Trim(DataGridAddUser.Columns(1).Value) & " ?"
        iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Delete Biaya Data")
        Dim deleteok As Boolean
        deleteok = False
        If (iresponse = vbYes) Then
            deleteok = myitem.DeleteUser(Trim(DataGridAddUser.Columns(0).Value))
        End If
        If deleteok = True Then
            MsgBox "User Data deleted !", vbInformation, "Data Deleted !"
            Set myitem = New ClsItemServer
            Set rs = myitem.GetUser
            Set DataGridAddUser.DataSource = rs
            If rs.RecordCount > 0 Then
                lblDelete.Enabled = True
            Else
                lblDelete.Enabled = False
            End If
        End If
End Sub

Private Sub TxtNewPassword_Change()
MyUser.UserPassword = TxtNewPassword.Text
End Sub

Private Sub TxtUserName_Change()
MyUser.UserName = TxtUserName.Text
End Sub
