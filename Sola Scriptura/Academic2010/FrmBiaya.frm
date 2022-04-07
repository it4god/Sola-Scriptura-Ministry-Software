VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmBiaya 
   Appearance      =   0  'Flat
   AutoRedraw      =   -1  'True
   BackColor       =   &H00DC7F59&
   BorderStyle     =   0  'None
   ClientHeight    =   9375
   ClientLeft      =   1140
   ClientTop       =   195
   ClientWidth     =   15360
   ClipControls    =   0   'False
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   6470.791
   ScaleMode       =   0  'User
   ScaleWidth      =   14423.84
   ShowInTaskbar   =   0   'False
   Tag             =   "100"
   Begin VB.ComboBox CboProgram 
      Height          =   315
      ItemData        =   "FrmBiaya.frx":0000
      Left            =   5280
      List            =   "FrmBiaya.frx":000D
      TabIndex        =   1
      Top             =   6600
      Width           =   3195
   End
   Begin VB.TextBox TxtBiaya 
      Height          =   285
      Left            =   5280
      TabIndex        =   2
      Top             =   7080
      Width           =   3195
   End
   Begin VB.TextBox TxtIndentity 
      Alignment       =   2  'Center
      BackColor       =   &H80000006&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000005&
      Height          =   495
      Left            =   2880
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   8
      Top             =   360
      Width           =   7987
   End
   Begin MSDataGridLib.DataGrid DataGridBiaya 
      Height          =   5055
      Left            =   3360
      TabIndex        =   9
      Top             =   1320
      Width           =   10335
      _ExtentX        =   18230
      _ExtentY        =   8916
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
   Begin VB.Image Image6 
      Height          =   1575
      Left            =   600
      Picture         =   "FrmBiaya.frx":002C
      Stretch         =   -1  'True
      Top             =   6360
      Width           =   1755
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmBiaya.frx":1211
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Label LblBiaya 
      BackStyle       =   0  'Transparent
      Caption         =   "Biaya Per SKS"
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
      Left            =   3480
      TabIndex        =   11
      Top             =   7080
      Width           =   1935
   End
   Begin VB.Label LblProgram 
      BackStyle       =   0  'Transparent
      Caption         =   "Program"
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
      Left            =   3480
      TabIndex        =   10
      Top             =   6600
      Width           =   1935
   End
   Begin VB.Label lblDelete 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Delete"
      Enabled         =   0   'False
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
      Left            =   7920
      TabIndex        =   5
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Label lblEdit 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Edit"
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
      Left            =   5640
      TabIndex        =   4
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Label lblTitleBiaya 
      BackStyle       =   0  'Transparent
      Caption         =   "Biaya"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   465
      Left            =   11880
      TabIndex        =   0
      Top             =   600
      Width           =   2685
   End
   Begin VB.Label lblCancel 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Cancel"
      Enabled         =   0   'False
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
      Left            =   13080
      TabIndex        =   7
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Label lblSave 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Save"
      Enabled         =   0   'False
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
      Left            =   10920
      TabIndex        =   6
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Label lblAddNew 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Add New"
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
      Left            =   3360
      TabIndex        =   3
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Image Image5 
      Height          =   495
      Left            =   10920
      Picture         =   "FrmBiaya.frx":6241B
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   13080
      Picture         =   "FrmBiaya.frx":62F0F
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image ImgAddNew 
      Height          =   495
      Left            =   3360
      Picture         =   "FrmBiaya.frx":63A03
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmBiaya.frx":644F7
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11760
      Picture         =   "FrmBiaya.frx":65013
      Top             =   480
      Width           =   2805
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmBiaya.frx":65AFD
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmBiaya.frx":6645B
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image Image3 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmBiaya.frx":66E9C
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image2 
      Height          =   495
      Left            =   7920
      Picture         =   "FrmBiaya.frx":67990
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmBiaya.frx":68484
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmBiaya"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim MyBiaya As Biaya
Dim MyBiayaBuffer As Biaya_Buffer
Dim myitem As ClsItemServer
Dim BiayaRS As ADODB.Recordset
Dim isnew As Boolean






Private Sub CboProgram_Change()
MyBiaya.Program = CboProgram.Text
End Sub

Private Sub TxtBiaya_Change()
MyBiaya.Biaya = TxtBiaya.Text
End Sub
Private Sub CboProgram_Click()
MyBiaya.Program = CboProgram.Text
End Sub

Private Sub Form_Load()
CenterChildForm Me
DoLock
Set myitem = New ClsItemServer
Set BiayaRS = myitem.GetBiaya()
Set DataGridBiaya.DataSource = BiayaRS
DataGridBiaya.Columns(0).Width = 2000
DataGridBiaya.Columns(1).Width = 2000


If BiayaRS.RecordCount > 0 Then
    lblEdit.Enabled = True
    LblDelete.Enabled = True
    BiayaRS.MoveFirst
Else
    lblEdit.Enabled = False
    LblDelete.Enabled = False
End If

isnew = False

End Sub

Private Sub imgQuit_Click()
Unload Me
End Sub

Private Sub lblAddNew_Click()
    MyBiaya.Program = ""
    MyBiaya.Biaya = ""
    CboProgram.Text = ""
    TxtBiaya.Text = ""

    DoUnlock
    lblAddNew.Enabled = False
    lblEdit.Enabled = False
    LblDelete.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    isnew = True
End Sub

Private Sub DoLock()
    TxtBiaya.Locked = True
    TxtBiaya.BackColor = vbWhite
    CboProgram.Locked = True
    CboProgram.BackColor = vbWhite
End Sub
Private Sub DoUnlock()
    TxtBiaya.Locked = False
    TxtBiaya.BackColor = vbYellow
    CboProgram.Locked = False
    CboProgram.BackColor = vbYellow

    
End Sub

Private Sub lblCancel_Click()
    lblAddNew.Enabled = True

    
    lblSave.Enabled = False
    lblCancel.Enabled = False
    Set myitem = New ClsItemServer
    Set BiayaRS = myitem.GetBiaya()
    Set DataGridBiaya.DataSource = BiayaRS
    DataGridBiaya.Columns(0).Width = 2000
    DataGridBiaya.Columns(1).Width = 2000
    If BiayaRS.RecordCount > 0 Then
        lblEdit.Enabled = True
        LblDelete.Enabled = True
        BiayaRS.MoveFirst
    Else
        lblEdit.Enabled = False
        LblDelete.Enabled = False
    End If
    DoLock
    CboProgram.Text = ""
    TxtBiaya.Text = ""
    isnew = False
End Sub

Private Sub LblDelete_Click()
On Error GoTo deleteerror:
        Set myitem = New ClsItemServer
        
     Dim iresponse As Long
        Dim saskUSER As String
        saskUSER = "Are you sure want to delete Biaya Data with Program  = " & Trim(DataGridBiaya.Columns(0).Value) & " ?"
        iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Delete Biaya Data")
        Dim deleteok As Boolean
        deleteok = False
        If (iresponse = vbYes) Then
            deleteok = myitem.DeleteBiaya(Trim(DataGridBiaya.Columns(0).Value))
        End If
        If deleteok = True Then
            
            MsgBox "Biaya Data deleted !", vbInformation, "Data Deleted !"
            Set myitem = New ClsItemServer
            Set BiayaRS = myitem.GetBiaya()
            Set DataGridBiaya.DataSource = BiayaRS
            DataGridBiaya.Columns(0).Width = 2000
            DataGridBiaya.Columns(1).Width = 2000
            If BiayaRS.RecordCount > 0 Then
                lblEdit.Enabled = True
                LblDelete.Enabled = True
                BiayaRS.MoveFirst
            Else
                lblEdit.Enabled = False
                LblDelete.Enabled = False
            End If
            isnew = False
        End If
        Exit Sub
deleteerror:
    MsgBox "Please Delete All Data linked to this person before you delete", vbInformation, "Error !"
End Sub

Private Sub lblEdit_Click()
    lblAddNew.Enabled = False
    lblEdit.Enabled = False
    LblDelete.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    
    CboProgram.Text = Trim(DataGridBiaya.Columns(0).Value)
    TxtBiaya.Text = Trim(DataGridBiaya.Columns(1).Value)
    MyBiaya.Program = Trim(DataGridBiaya.Columns(0).Value)
    MyBiaya.Biaya = Trim(DataGridBiaya.Columns(1).Value)
    
    DoUnlock
End Sub

Private Sub lblSave_Click()

Dim saveok As Boolean
LSet MyBiayaBuffer = MyBiaya
If Trim(MyBiaya.Program) = "" Then
    MsgBox "Please fill the Program !", vbInformation, "Information"
ElseIf IsNumeric(Trim(MyBiaya.Biaya)) = False Then
    MsgBox "Please fill the Biaya with numeric value !", vbInformation, "Information"
Else
        Set myitem = New ClsItemServer
        saveok = myitem.saveBiaya(MyBiayaBuffer.Buffer)
        
        If saveok = True Then
            lblAddNew.Enabled = True
        
            lblSave.Enabled = False
            lblCancel.Enabled = False
            Set myitem = New ClsItemServer
            Set BiayaRS = myitem.GetBiaya()
            Set DataGridBiaya.DataSource = BiayaRS
            DataGridBiaya.Columns(0).Width = 2000
            DataGridBiaya.Columns(1).Width = 2000
            If BiayaRS.RecordCount > 0 Then
                lblEdit.Enabled = True
                LblDelete.Enabled = True
            Else
                lblEdit.Enabled = False
                LblDelete.Enabled = False
                
            End If
            MsgBox "Save Biaya Data Successfully !", vbInformation, "Data is recorded !"
            DoLock
            isnew = False
            CboProgram.Text = ""
            TxtBiaya.Text = ""
        Else
            MsgBox "Save Biaya Data unSuccessfully !", vbInformation, "Data is not recorded !"
                    
        End If

End If
End Sub


