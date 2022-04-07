VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmMataKuliah 
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
   Begin VB.ComboBox cboMataKuliahID 
      Height          =   315
      ItemData        =   "FrmMatakuliah.frx":0000
      Left            =   10440
      List            =   "FrmMatakuliah.frx":000D
      Style           =   2  'Dropdown List
      TabIndex        =   4
      Top             =   6960
      Width           =   3255
   End
   Begin VB.ComboBox CboTipeMK 
      Height          =   315
      ItemData        =   "FrmMatakuliah.frx":002A
      Left            =   5280
      List            =   "FrmMatakuliah.frx":0064
      TabIndex        =   3
      Top             =   6960
      Width           =   3255
   End
   Begin VB.TextBox TxtNamaMK 
      Height          =   285
      Left            =   5280
      TabIndex        =   2
      Top             =   6480
      Width           =   8475
   End
   Begin VB.TextBox TxtMKNo 
      Height          =   285
      Left            =   5280
      TabIndex        =   1
      Top             =   6000
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
      TabIndex        =   10
      Top             =   360
      Width           =   7987
   End
   Begin MSDataGridLib.DataGrid DataGridMatakuliah 
      Height          =   4575
      Left            =   3360
      TabIndex        =   11
      Top             =   1320
      Width           =   10335
      _ExtentX        =   18230
      _ExtentY        =   8070
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
      Picture         =   "FrmMatakuliah.frx":019F
      Stretch         =   -1  'True
      Top             =   6360
      Width           =   1755
   End
   Begin VB.Label LblHP 
      BackStyle       =   0  'Transparent
      Caption         =   "Mata Kuliah ID"
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
      Left            =   8760
      TabIndex        =   15
      Top             =   6960
      Width           =   1935
   End
   Begin VB.Label LblAlamat 
      BackStyle       =   0  'Transparent
      Caption         =   "Nama Mata Kuliah"
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
      TabIndex        =   14
      Top             =   6480
      Width           =   1935
   End
   Begin VB.Label LblMKNo 
      BackStyle       =   0  'Transparent
      Caption         =   "Mata Kuliah No"
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
      TabIndex        =   13
      Top             =   6000
      Width           =   1935
   End
   Begin VB.Label lblTelepon 
      BackStyle       =   0  'Transparent
      Caption         =   "Tipe Mata Kuliah"
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
      TabIndex        =   12
      Top             =   6960
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
      TabIndex        =   7
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
      TabIndex        =   6
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Label lblTitleMataKulliah 
      BackStyle       =   0  'Transparent
      Caption         =   "Mata Kuliah"
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
      TabIndex        =   9
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
      TabIndex        =   8
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
      TabIndex        =   5
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Image Image5 
      Height          =   495
      Left            =   10920
      Picture         =   "FrmMatakuliah.frx":1384
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   13080
      Picture         =   "FrmMatakuliah.frx":1E78
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image ImgAddNew 
      Height          =   495
      Left            =   3360
      Picture         =   "FrmMatakuliah.frx":296C
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmMatakuliah.frx":3460
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11760
      Picture         =   "FrmMatakuliah.frx":3F7C
      Top             =   480
      Width           =   2805
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmMatakuliah.frx":4A66
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmMatakuliah.frx":53C4
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmMatakuliah.frx":5E05
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image Image3 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmMatakuliah.frx":6700F
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image2 
      Height          =   495
      Left            =   7920
      Picture         =   "FrmMatakuliah.frx":67B03
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmMatakuliah.frx":685F7
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmMataKuliah"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim MyMatakuliah As MataKuliah
Dim MyMatakuliahBuffer As MataKuliah_Buffer
Dim myitem As ClsItemServer
Dim MKRs As ADODB.Recordset
Dim isnew As Boolean

Private Sub cboMataKuliahID_Change()
    If cboMataKuliahID.Text = "Utama" Then
        MyMatakuliah.MK_ID = "1"
    ElseIf cboMataKuliahID.Text = "Kategori" Then
        MyMatakuliah.MK_ID = "2"
    ElseIf cboMataKuliahID.Text = "Khusus" Then
        MyMatakuliah.MK_ID = "3"
    End If
    
End Sub

Private Sub cboMataKuliahID_click()
    If cboMataKuliahID.Text = "Utama" Then
        MyMatakuliah.MK_ID = "1"
    ElseIf cboMataKuliahID.Text = "Kategori" Then
        MyMatakuliah.MK_ID = "2"
    ElseIf cboMataKuliahID.Text = "Khusus" Then
        MyMatakuliah.MK_ID = "3"
    End If
    
End Sub



Private Sub CboTipeMK_Change()
    MyMatakuliah.Tipe_MK = CboTipeMK.Text
    
End Sub

Private Sub CboTipeMK_Click()
    MyMatakuliah.Tipe_MK = CboTipeMK.Text
End Sub

Private Sub Form_Load()
CenterChildForm Me
DoLock
Set myitem = New ClsItemServer
Set MKRs = myitem.GetMK()
Set DataGridMatakuliah.DataSource = MKRs
DataGridMatakuliah.Columns(0).Width = 800
DataGridMatakuliah.Columns(1).Width = 5000
DataGridMatakuliah.Columns(2).Width = 2300
DataGridMatakuliah.Columns(3).Width = 800

If MKRs.RecordCount > 0 Then
    lblEdit.Enabled = True
    lblDelete.Enabled = True
    MKRs.MoveFirst
Else
    lblEdit.Enabled = False
    lblDelete.Enabled = False
End If

isnew = False

End Sub

Private Sub imgQuit_Click()
Unload Me
End Sub

Private Sub lblAddNew_Click()
    MyMatakuliah.MK_ID = "1"
    MyMatakuliah.MK_No = ""
    MyMatakuliah.Nama_MK = ""
    MyMatakuliah.Tipe_MK = ""

    TxtMKNo.Text = ""
    TxtNamaMK.Text = ""
    CboTipeMK.Text = ""
    cboMataKuliahID.Text = "Utama"
    DoUnlock
    lblAddNew.Enabled = False
    lblEdit.Enabled = False
    lblDelete.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    isnew = True
End Sub

Private Sub DoLock()
    TxtMKNo.Locked = True
    TxtMKNo.BackColor = vbWhite
    TxtNamaMK.Locked = True
    TxtNamaMK.BackColor = vbWhite
    CboTipeMK.Locked = True
    CboTipeMK.BackColor = vbWhite
    cboMataKuliahID.Locked = True
    cboMataKuliahID.BackColor = vbWhite
    

End Sub
Private Sub DoUnlock()
    TxtMKNo.Locked = False
    TxtMKNo.BackColor = vbYellow
    TxtNamaMK.Locked = False
    TxtNamaMK.BackColor = vbYellow
    CboTipeMK.Locked = False
    CboTipeMK.BackColor = vbYellow
    cboMataKuliahID.Locked = False
    cboMataKuliahID.BackColor = vbYellow
    
End Sub

Private Sub lblCancel_Click()
    lblAddNew.Enabled = True

    
    lblSave.Enabled = False
    lblCancel.Enabled = False
    Set myitem = New ClsItemServer
    Set MKRs = myitem.GetMK()
    Set DataGridMatakuliah.DataSource = MKRs
    DataGridMatakuliah.Columns(0).Width = 800
    DataGridMatakuliah.Columns(1).Width = 5000
    DataGridMatakuliah.Columns(2).Width = 2300
    DataGridMatakuliah.Columns(3).Width = 800
    If MKRs.RecordCount > 0 Then
        lblEdit.Enabled = True
        lblDelete.Enabled = True
        MKRs.MoveFirst
    Else
        lblEdit.Enabled = False
        lblDelete.Enabled = False
    End If
    DoLock
    isnew = False
End Sub

Private Sub LblDelete_Click()
On Error GoTo deleteerror:
        Set myitem = New ClsItemServer
        
     Dim iresponse As Long
        Dim saskUSER As String
        saskUSER = "Are you sure want to delete Mata Kuliah Data with MK_No  = " & Trim(DataGridMatakuliah.Columns(0).Value) & " ?"
        iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Delete Mata Kuliah Data")
        Dim deleteok As Boolean
        deleteok = False
        If (iresponse = vbYes) Then
            deleteok = myitem.DeleteMataKuliah(Trim(DataGridMatakuliah.Columns(0).Value))
        End If
        If deleteok = True Then
            
            MsgBox "Mata Kuliah Data deleted !", vbInformation, "Data Deleted !"
            Set myitem = New ClsItemServer
            Set MKRs = myitem.GetMK()
            Set DataGridMatakuliah.DataSource = MKRs
            DataGridMatakuliah.Columns(0).Width = 800
            DataGridMatakuliah.Columns(1).Width = 5000
            DataGridMatakuliah.Columns(2).Width = 2300
            DataGridMatakuliah.Columns(3).Width = 800
            If MKRs.RecordCount > 0 Then
                lblEdit.Enabled = True
                lblDelete.Enabled = True
                MKRs.MoveFirst
            Else
                lblEdit.Enabled = False
                lblDelete.Enabled = False
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
    lblDelete.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    
    TxtMKNo.Text = Trim(DataGridMatakuliah.Columns(0).Value)
    TxtNamaMK.Text = Trim(DataGridMatakuliah.Columns(1).Value)
    CboTipeMK.Text = Trim(DataGridMatakuliah.Columns(2).Value)

    cboMataKuliahID.Text = Trim(DataGridMatakuliah.Columns(3).Value)
    DoUnlock
End Sub

Private Sub lblSave_Click()

Dim saveok As Boolean
LSet MyMatakuliahBuffer = MyMatakuliah

If isnew = True Then
    Dim DoubleMK As Boolean
    Set myitem = New ClsItemServer
    DoubleMK = myitem.DoubleMKNo(MyMatakuliah.MK_No)
    If DoubleMK = True Then
        MsgBox "The MataKuliahNo is already existed ! Try another MK_No !", vbInformation, "Warning !"
    Else
        Set myitem = New ClsItemServer
        saveok = myitem.saveMK(MyMatakuliahBuffer.Buffer, UpdateUser)
        
        If saveok = True Then
            lblAddNew.Enabled = True
        
            lblSave.Enabled = False
            lblCancel.Enabled = False
            Set myitem = New ClsItemServer
            Set MKRs = myitem.GetMK()
            Set DataGridMatakuliah.DataSource = MKRs
            DataGridMatakuliah.Columns(0).Width = 800
            DataGridMatakuliah.Columns(1).Width = 5000
            DataGridMatakuliah.Columns(2).Width = 2300
            DataGridMatakuliah.Columns(3).Width = 800
            If MKRs.RecordCount > 0 Then
                lblEdit.Enabled = True
                lblDelete.Enabled = True
                MKRs.MoveFirst
            Else
                lblEdit.Enabled = False
                lblDelete.Enabled = False
                
            End If
            MsgBox "Save Mata Kuliah Data Successfully !", vbInformation, "Data is recorded !"
            DoLock
            isnew = False
        Else
            MsgBox "Save Mata Kuliah Data unSuccessfully !", vbInformation, "Data is not recorded !"
                    
        End If
    
    End If
    
Else

        Set myitem = New ClsItemServer
        saveok = myitem.saveMK(MyMatakuliahBuffer.Buffer, UpdateUser)
        
        If saveok = True Then
            lblAddNew.Enabled = True
        
            lblSave.Enabled = False
            lblCancel.Enabled = False
            Set myitem = New ClsItemServer
            Set MKRs = myitem.GetMK()
            Set DataGridMatakuliah.DataSource = MKRs
            DataGridMatakuliah.Columns(0).Width = 800
            DataGridMatakuliah.Columns(1).Width = 5000
            DataGridMatakuliah.Columns(2).Width = 2300
            DataGridMatakuliah.Columns(3).Width = 800
            If MKRs.RecordCount > 0 Then
                lblEdit.Enabled = True
                lblDelete.Enabled = True
                MKRs.MoveFirst
            Else
                lblEdit.Enabled = False
                lblDelete.Enabled = False
                
            End If
            MsgBox "Save Mata Kuliah Data Successfully !", vbInformation, "Data is recorded !"
            DoLock
            isnew = False
        Else
            MsgBox "Save Mata Kuliah Data unSuccessfully !", vbInformation, "Data is not recorded !"
                    
        End If
End If
End Sub

Private Sub TxtMKNo_Change()
    MyMatakuliah.MK_No = TxtMKNo.Text
    
End Sub

Private Sub TxtNamaMK_Change()
    MyMatakuliah.Nama_MK = TxtNamaMK.Text
    
End Sub
