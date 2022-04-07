VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmMataKuliahPerSem 
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
   Begin VB.TextBox TxtKeterangan 
      Height          =   285
      Left            =   5280
      Locked          =   -1  'True
      TabIndex        =   5
      Top             =   7080
      Width           =   8475
   End
   Begin VB.ComboBox cboTipeKuliah 
      Height          =   315
      ItemData        =   "FrmMatakuliahPerSem.frx":0000
      Left            =   10440
      List            =   "FrmMatakuliahPerSem.frx":000A
      TabIndex        =   4
      Text            =   "Regular"
      Top             =   6600
      Width           =   3255
   End
   Begin VB.ComboBox CboSKS 
      Height          =   315
      ItemData        =   "FrmMatakuliahPerSem.frx":0021
      Left            =   5280
      List            =   "FrmMatakuliahPerSem.frx":003A
      TabIndex        =   3
      Text            =   "0"
      Top             =   6600
      Width           =   3255
   End
   Begin VB.TextBox TxtDosenID 
      Height          =   285
      Left            =   10440
      Locked          =   -1  'True
      TabIndex        =   2
      Top             =   6120
      Width           =   3195
   End
   Begin VB.TextBox TxtMKNo 
      Height          =   285
      Left            =   5280
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   6120
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
      TabIndex        =   11
      Top             =   360
      Width           =   7987
   End
   Begin MSDataGridLib.DataGrid DataGridMatakuliahPerSem 
      Height          =   4575
      Left            =   3360
      TabIndex        =   12
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
      Picture         =   "FrmMatakuliahPerSem.frx":0053
      Stretch         =   -1  'True
      Top             =   6360
      Width           =   1755
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Keterangan"
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
      TabIndex        =   17
      Top             =   7080
      Width           =   1935
   End
   Begin VB.Label LblTypeKuliah 
      BackStyle       =   0  'Transparent
      Caption         =   "Tipe Kuliah"
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
      TabIndex        =   16
      Top             =   6600
      Width           =   1935
   End
   Begin VB.Label LblDosenID 
      BackStyle       =   0  'Transparent
      Caption         =   "Dosen ID"
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
      Top             =   6120
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
      TabIndex        =   14
      Top             =   6120
      Width           =   1935
   End
   Begin VB.Label lblSKS 
      BackStyle       =   0  'Transparent
      Caption         =   "SKS"
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
      TabIndex        =   8
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
      TabIndex        =   7
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Label lblTitleMataKulliah 
      BackStyle       =   0  'Transparent
      Caption         =   "Mata Kuliah Per Semester"
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
      TabIndex        =   10
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
      TabIndex        =   9
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
      TabIndex        =   6
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Image Image5 
      Height          =   495
      Left            =   10920
      Picture         =   "FrmMatakuliahPerSem.frx":1238
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   13080
      Picture         =   "FrmMatakuliahPerSem.frx":1D2C
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image ImgAddNew 
      Height          =   495
      Left            =   3360
      Picture         =   "FrmMatakuliahPerSem.frx":2820
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmMatakuliahPerSem.frx":3314
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11760
      Picture         =   "FrmMatakuliahPerSem.frx":3E30
      Top             =   480
      Width           =   2805
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmMatakuliahPerSem.frx":491A
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmMatakuliahPerSem.frx":5278
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmMatakuliahPerSem.frx":5CB9
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image Image3 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmMatakuliahPerSem.frx":66EC3
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image2 
      Height          =   495
      Left            =   7920
      Picture         =   "FrmMatakuliahPerSem.frx":679B7
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmMatakuliahPerSem.frx":684AB
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmMataKuliahPerSem"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim MyMataKuliahPerSem As MataKuliahPerSem
Dim MyMataKuliahPerSemBuffer As MataKuliahPerSem_Buffer
Dim myitem As ClsItemServer
Dim MKPerSemRS As ADODB.Recordset
Dim isnew As Boolean

Private Sub CboSKS_Change()
    MyMataKuliahPerSem.SKS = Trim(CboSKS.Text)
End Sub

Private Sub CboSKS_Click()
    MyMataKuliahPerSem.SKS = Trim(CboSKS.Text)
End Sub

Private Sub cboTipeKuliah_Change()
    MyMataKuliahPerSem.TipeKuliah = Trim(cboTipeKuliah.Text)
    
End Sub

Private Sub cboTipeKuliah_Click()
    MyMataKuliahPerSem.TipeKuliah = Trim(cboTipeKuliah.Text)
End Sub

Private Sub Form_Load()
CenterChildForm Me
DoLock
Set myitem = New ClsItemServer
Set MKPerSemRS = myitem.GetMKPerSem(Periode)
Set DataGridMatakuliahPerSem.DataSource = MKPerSemRS
DataGridMatakuliahPerSem.Columns(0).Width = 800
DataGridMatakuliahPerSem.Columns(1).Width = 3500
DataGridMatakuliahPerSem.Columns(2).Width = 1500
DataGridMatakuliahPerSem.Columns(3).Width = 1000
DataGridMatakuliahPerSem.Columns(4).Width = 800
DataGridMatakuliahPerSem.Columns(5).Width = 800
DataGridMatakuliahPerSem.Columns(6).Width = 1000


If MKPerSemRS.RecordCount > 0 Then
    lblEdit.Enabled = True
    lblDelete.Enabled = True
Else
    lblEdit.Enabled = False
    lblDelete.Enabled = False
End If
isnew = False
TxtIndentity.Text = "Periode : " & Trim(strperiode)
End Sub

Private Sub imgQuit_Click()
Unload Me
End Sub

Private Sub lblAddNew_Click()
    MyMataKuliahPerSem.MKP_No = ""
    MyMataKuliahPerSem.MK_No = ""
    MyMataKuliahPerSem.Periode = Periode
    MyMataKuliahPerSem.DosenID = ""
    MyMataKuliahPerSem.SKS = "0"
    MyMataKuliahPerSem.TipeKuliah = "Regular"
    MyMataKuliahPerSem.Keterangan = ""
    TxtMKNo.Text = ""
    TxtDosenID.Text = ""
    CboSKS.Text = "0"
    cboTipeKuliah.Text = "Regular"
    TxtKeterangan.Text = ""
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
    TxtDosenID.Locked = True
    TxtDosenID.BackColor = vbWhite
    CboSKS.Locked = True
    CboSKS.BackColor = vbWhite
    cboTipeKuliah.Locked = True
    cboTipeKuliah.BackColor = vbWhite
    TxtKeterangan.Locked = True
    TxtKeterangan.BackColor = vbWhite
    

End Sub
Private Sub DoUnlock()

    TxtMKNo.BackColor = vbYellow

    TxtDosenID.BackColor = vbYellow
    CboSKS.Locked = False
    CboSKS.BackColor = vbYellow
    cboTipeKuliah.Locked = False
    cboTipeKuliah.BackColor = vbYellow
    TxtKeterangan.Locked = False
    TxtKeterangan.BackColor = vbYellow
    
End Sub

Private Sub lblCancel_Click()
    lblAddNew.Enabled = True

    
    lblSave.Enabled = False
    lblCancel.Enabled = False
    Set myitem = New ClsItemServer
    Set MKPerSemRS = myitem.GetMKPerSem(Periode)
    Set DataGridMatakuliahPerSem.DataSource = MKPerSemRS
    DataGridMatakuliahPerSem.Columns(0).Width = 800
    DataGridMatakuliahPerSem.Columns(1).Width = 3500
    DataGridMatakuliahPerSem.Columns(2).Width = 1500
    DataGridMatakuliahPerSem.Columns(3).Width = 1000
    DataGridMatakuliahPerSem.Columns(4).Width = 800
    DataGridMatakuliahPerSem.Columns(5).Width = 800
    DataGridMatakuliahPerSem.Columns(6).Width = 1000
    If MKPerSemRS.RecordCount > 0 Then
        lblEdit.Enabled = True
        lblDelete.Enabled = True
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
        saskUSER = "Are you sure want to delete Mata Kuliah PerSem Data with MK_No = " & Trim(DataGridMatakuliahPerSem.Columns(0).Value) & "?"
        iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Delete Mata Kuliah PerSem Data")
        Dim deleteok As Boolean
        deleteok = False
        If (iresponse = vbYes) Then
            deleteok = myitem.DeleteMataKuliahPerSem(Trim(DataGridMatakuliahPerSem.Columns(9).Value))
        End If
        If deleteok = True Then
            
            MsgBox "Mata Kuliah Per Sem Data deleted !", vbInformation, "Data Deleted !"
            Set myitem = New ClsItemServer
            Set MKPerSemRS = myitem.GetMKPerSem(Periode)
            Set DataGridMatakuliahPerSem.DataSource = MKPerSemRS
            DataGridMatakuliahPerSem.Columns(0).Width = 800
            DataGridMatakuliahPerSem.Columns(1).Width = 3500
            DataGridMatakuliahPerSem.Columns(2).Width = 1500
            DataGridMatakuliahPerSem.Columns(3).Width = 1000
            DataGridMatakuliahPerSem.Columns(4).Width = 800
            DataGridMatakuliahPerSem.Columns(5).Width = 800
            DataGridMatakuliahPerSem.Columns(6).Width = 1000
            If MKPerSemRS.RecordCount > 0 Then
                lblEdit.Enabled = True
                lblDelete.Enabled = True
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
    
    TxtMKNo.Text = Trim(DataGridMatakuliahPerSem.Columns(0).Value)
    TxtDosenID.Text = Trim(DataGridMatakuliahPerSem.Columns(4).Value)
    CboSKS.Text = Trim(DataGridMatakuliahPerSem.Columns(5).Value)

    cboTipeKuliah.Text = Trim(DataGridMatakuliahPerSem.Columns(6).Value)
    TxtKeterangan.Text = Trim(DataGridMatakuliahPerSem.Columns(7).Value)
    MyMataKuliahPerSem.SKS = Trim(DataGridMatakuliahPerSem.Columns(5).Value)
    MyMataKuliahPerSem.TipeKuliah = Trim(DataGridMatakuliahPerSem.Columns(6).Value)
    MyMataKuliahPerSem.MKP_No = Trim(DataGridMatakuliahPerSem.Columns(9).Value)
    MyMataKuliahPerSem.Periode = Periode
    DoUnlock
End Sub

Private Sub lblSave_Click()

Dim saveok As Boolean
If Trim(MyMataKuliahPerSem.MKP_No) = "" Then MyMataKuliahPerSem.MKP_No = "0"
LSet MyMataKuliahPerSemBuffer = MyMataKuliahPerSem

If isnew = True Then


        Set myitem = New ClsItemServer
        saveok = myitem.saveMKPerSem(MyMataKuliahPerSemBuffer.Buffer, UpdateUser)
        
        If saveok = True Then
            lblAddNew.Enabled = True
        
            lblSave.Enabled = False
            lblCancel.Enabled = False
            Set myitem = New ClsItemServer
            Set MKPerSemRS = myitem.GetMKPerSem(Periode)
            Set DataGridMatakuliahPerSem.DataSource = MKPerSemRS
            DataGridMatakuliahPerSem.Columns(0).Width = 800
            DataGridMatakuliahPerSem.Columns(1).Width = 3500
            DataGridMatakuliahPerSem.Columns(2).Width = 1500
            DataGridMatakuliahPerSem.Columns(3).Width = 1000
            DataGridMatakuliahPerSem.Columns(4).Width = 800
            DataGridMatakuliahPerSem.Columns(5).Width = 800
            DataGridMatakuliahPerSem.Columns(6).Width = 1000
            If MKPerSemRS.RecordCount > 0 Then
                lblEdit.Enabled = True
                lblDelete.Enabled = True
            Else
                lblEdit.Enabled = False
                lblDelete.Enabled = False
                
            End If
            MsgBox "Save Mata Kuliah PerSem Data Successfully !", vbInformation, "Data is recorded !"
            DoLock
            isnew = False
        Else
            MsgBox "Save Mata Kuliah PerSem Data unSuccessfully !", vbInformation, "Data is not recorded !"
                    
        End If
    

    
Else

        Set myitem = New ClsItemServer
        saveok = myitem.saveMKPerSem(MyMataKuliahPerSemBuffer.Buffer, UpdateUser)
        
        If saveok = True Then
            lblAddNew.Enabled = True
        
            lblSave.Enabled = False
            lblCancel.Enabled = False
            Set myitem = New ClsItemServer
            Set MKPerSemRS = myitem.GetMKPerSem(Periode)
            Set DataGridMatakuliahPerSem.DataSource = MKPerSemRS
            DataGridMatakuliahPerSem.Columns(0).Width = 800
            DataGridMatakuliahPerSem.Columns(1).Width = 3500
            DataGridMatakuliahPerSem.Columns(2).Width = 1500
            DataGridMatakuliahPerSem.Columns(3).Width = 1000
            DataGridMatakuliahPerSem.Columns(4).Width = 800
            DataGridMatakuliahPerSem.Columns(5).Width = 800
            DataGridMatakuliahPerSem.Columns(6).Width = 1000
            If MKPerSemRS.RecordCount > 0 Then
                lblEdit.Enabled = True
                lblDelete.Enabled = True
            Else
                lblEdit.Enabled = False
                lblDelete.Enabled = False
                
            End If
            MsgBox "Save Mata Kuliah PerSem Data Successfully !", vbInformation, "Data is recorded !"
            DoLock
            isnew = False
        Else
            MsgBox "Save Mata Kuliah PerSem Data unSuccessfully !", vbInformation, "Data is not recorded !"
                    
        End If
End If
End Sub

Private Sub TxtDosenID_Change()
    MyMataKuliahPerSem.DosenID = Trim(TxtDosenID.Text)
End Sub

Private Sub TxtDosenID_Click()
    Lite = "MKPerSem"
    FrmAddDosen.Show
End Sub

Private Sub TxtKeterangan_Change()
    MyMataKuliahPerSem.Keterangan = TxtKeterangan.Text
End Sub

Private Sub TxtMKNo_Change()
    MyMataKuliahPerSem.MK_No = Trim(TxtMKNo.Text)
    
End Sub

Private Sub TxtMKNo_Click()
If isnew = True Then
    Lite = "MKPerSem"
    FrmAddMatakuliah.Show
Else

End If
End Sub
