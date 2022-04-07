VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmDosen 
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
   Begin MSDataGridLib.DataGrid DataGridDosen 
      Height          =   2175
      Left            =   3360
      TabIndex        =   25
      Top             =   5160
      Width           =   10335
      _ExtentX        =   18230
      _ExtentY        =   3836
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
   Begin VB.ComboBox CboTanggalLahir_Year 
      Height          =   315
      Left            =   12360
      Style           =   2  'Dropdown List
      TabIndex        =   11
      Top             =   4560
      Width           =   1275
   End
   Begin VB.ComboBox CboTanggalLahir_Month 
      Height          =   315
      Left            =   11400
      Style           =   2  'Dropdown List
      TabIndex        =   10
      Top             =   4560
      Width           =   855
   End
   Begin VB.ComboBox CboTanggalLahir_Day 
      Height          =   315
      Left            =   10440
      Style           =   2  'Dropdown List
      TabIndex        =   9
      Top             =   4560
      Width           =   855
   End
   Begin VB.TextBox TxtTempatLahir 
      Height          =   285
      Left            =   5160
      TabIndex        =   8
      Top             =   4560
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
      TabIndex        =   22
      Top             =   360
      Width           =   7987
   End
   Begin VB.TextBox TxtTelepon 
      Height          =   285
      Left            =   5160
      TabIndex        =   5
      Top             =   3600
      Width           =   3195
   End
   Begin VB.TextBox TxtDosenID 
      Height          =   285
      Left            =   5160
      TabIndex        =   1
      Top             =   1800
      Width           =   3195
   End
   Begin VB.TextBox TxtNamaAwal 
      Height          =   285
      Left            =   5160
      TabIndex        =   2
      Top             =   2640
      Width           =   3195
   End
   Begin VB.TextBox TxtNamaAkhir 
      Height          =   285
      Left            =   10440
      TabIndex        =   3
      Top             =   2640
      Width           =   3195
   End
   Begin VB.TextBox TxtAlamat 
      Height          =   285
      Left            =   5160
      TabIndex        =   4
      Top             =   3120
      Width           =   8475
   End
   Begin VB.TextBox TxtEmail 
      BackColor       =   &H00FFFFFF&
      Height          =   285
      Left            =   5160
      TabIndex        =   7
      Top             =   4080
      Width           =   8475
   End
   Begin VB.TextBox TxtHP 
      Height          =   285
      Left            =   10440
      TabIndex        =   6
      Top             =   3600
      Width           =   3195
   End
   Begin VB.Image Image6 
      Height          =   1575
      Left            =   600
      Picture         =   "FrmDosen.frx":0000
      Stretch         =   -1  'True
      Top             =   6360
      Width           =   1755
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
      TabIndex        =   27
      Top             =   7680
      Width           =   1965
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
      TabIndex        =   26
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Line Line1 
      BorderColor     =   &H8000000E&
      X1              =   3042.529
      X2              =   12846.23
      Y1              =   1656.523
      Y2              =   1656.523
   End
   Begin VB.Label LblTanggalLahir 
      BackStyle       =   0  'Transparent
      Caption         =   "Tanggal Lahir"
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
      Left            =   8640
      TabIndex        =   24
      Top             =   4560
      Width           =   1935
   End
   Begin VB.Label LblTempatLahir 
      BackStyle       =   0  'Transparent
      Caption         =   "Tempat Lahir"
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
      Left            =   3360
      TabIndex        =   23
      Top             =   4560
      Width           =   1935
   End
   Begin VB.Label lblTelepon 
      BackStyle       =   0  'Transparent
      Caption         =   "Telepon"
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
      Left            =   3360
      TabIndex        =   21
      Top             =   3600
      Width           =   1935
   End
   Begin VB.Label lblTitleAddDoen 
      BackStyle       =   0  'Transparent
      Caption         =   "Add Dosen"
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
      TabIndex        =   20
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
      TabIndex        =   13
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
      TabIndex        =   12
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
      TabIndex        =   0
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Image Image5 
      Height          =   495
      Left            =   10920
      Picture         =   "FrmDosen.frx":11E5
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   13080
      Picture         =   "FrmDosen.frx":1CD9
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image ImgAddNew 
      Height          =   495
      Left            =   3360
      Picture         =   "FrmDosen.frx":27CD
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmDosen.frx":32C1
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11760
      Picture         =   "FrmDosen.frx":3DDD
      Top             =   480
      Width           =   2805
   End
   Begin VB.Label lblDosenID 
      BackStyle       =   0  'Transparent
      Caption         =   "DosenID"
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
      Left            =   3360
      TabIndex        =   19
      Top             =   1800
      Width           =   1935
   End
   Begin VB.Label LblNamaAwal 
      BackStyle       =   0  'Transparent
      Caption         =   "Nama Awal"
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
      Left            =   3360
      TabIndex        =   18
      Top             =   2640
      Width           =   1935
   End
   Begin VB.Label LblNamaAkhir 
      BackStyle       =   0  'Transparent
      Caption         =   "Nama Akhir"
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
      Left            =   8640
      TabIndex        =   17
      Top             =   2640
      Width           =   1935
   End
   Begin VB.Label LblAlamat 
      BackStyle       =   0  'Transparent
      Caption         =   "Alamat"
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
      Left            =   3360
      TabIndex        =   16
      Top             =   3120
      Width           =   1935
   End
   Begin VB.Label LblEmail 
      BackStyle       =   0  'Transparent
      Caption         =   "Email"
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
      Left            =   3360
      TabIndex        =   15
      Top             =   4080
      Width           =   1935
   End
   Begin VB.Label LblHP 
      BackStyle       =   0  'Transparent
      Caption         =   "HP"
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
      Left            =   8640
      TabIndex        =   14
      Top             =   3600
      Width           =   1935
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmDosen.frx":48C7
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmDosen.frx":5225
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmDosen.frx":5C66
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image Image2 
      Height          =   495
      Left            =   7920
      Picture         =   "FrmDosen.frx":66E70
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image3 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmDosen.frx":67964
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmDosen.frx":68458
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmDosen"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim AddDosen As Dosen
Dim AddDosenBuffer As Dosen_Buffer
Dim myitem As ClsItemServer
Dim dosenrecordset As ADODB.Recordset
Dim isedit As Boolean





Private Sub Form_Load()
    Dim counter As Long
    For counter = 1 To 31
        CboTanggalLahir_Day.AddItem (counter)
    Next counter
    For counter = 1 To 12
        CboTanggalLahir_Month.AddItem (counter)
    Next counter
    For counter = 1940 To 2200
        CboTanggalLahir_Year.AddItem (counter)
    Next counter
    DoLock
        Set myitem = New ClsItemServer
    
    Set dosenrecordset = myitem.GetDosen
    Set DataGridDosen.DataSource = dosenrecordset
    DataGridDosen.Columns(0).Width = 600
    DataGridDosen.Columns(1).Width = 1500
    DataGridDosen.Columns(2).Width = 1500
    DataGridDosen.Columns(3).Width = 2500
    DataGridDosen.Columns(4).Width = 1100
    DataGridDosen.Columns(5).Width = 1000
    
    If dosenrecordset.RecordCount > 0 Then
        lblDelete.Enabled = True
        lblEdit.Enabled = True
        dosenrecordset.MoveFirst
    End If

    isedit = False
    CenterChildForm Me
    TxtIndentity.Text = "Periode : " & Trim(strperiode)
End Sub



Private Sub imgQuit_Click()
Unload Me
End Sub

Private Sub lblAddNew_Click()
    AddDosen.Alamat = ""
    AddDosen.Email = ""
    AddDosen.HP = ""
    AddDosen.Nama_Akhir = ""
    AddDosen.Nama_Awal = ""
    AddDosen.DosenID = ""


    AddDosen.TanggalLahir = ""
    AddDosen.Telepon = ""
    AddDosen.TempatLahir = ""
    TxtDosenID.Text = ""
    TxtAlamat.Text = ""
    TxtEmail.Text = ""
    TxtHP.Text = ""
    TxtNamaAwal.Text = ""
    TxtNamaAkhir.Text = ""

    CboTanggalLahir_Day.Clear
    CboTanggalLahir_Month.Clear
    CboTanggalLahir_Year.Clear
    
    Dim counter As Long
    For counter = 1 To 31
        CboTanggalLahir_Day.AddItem (counter)
    Next counter
    For counter = 1 To 12
        CboTanggalLahir_Month.AddItem (counter)
    Next counter
    For counter = 1900 To 2200
        CboTanggalLahir_Year.AddItem (counter)
    Next counter
    TxtTelepon.Text = ""
    TxtTempatLahir.Text = ""
    
    DoUnlock
    lblSave.Enabled = True
    lblCancel.Enabled = True
    lblAddNew.Enabled = False

    isedit = False
End Sub

Private Sub DoLock()
    TxtDosenID.Locked = True
    TxtDosenID.BackColor = vbWhite
    TxtNamaAwal.Locked = True
    TxtNamaAwal.BackColor = vbWhite
    TxtNamaAkhir.Locked = True
    TxtNamaAkhir.BackColor = vbWhite
    TxtAlamat.Locked = True
    TxtAlamat.BackColor = vbWhite
    TxtTelepon.Locked = True
    TxtTelepon.BackColor = vbWhite
    TxtHP.Locked = True
    TxtHP.BackColor = vbWhite
    TxtEmail.Locked = True
    TxtEmail.BackColor = vbWhite
    TxtTempatLahir.Locked = True
    TxtTempatLahir.BackColor = vbWhite
    CboTanggalLahir_Day.Locked = True
    CboTanggalLahir_Day.BackColor = vbWhite
    CboTanggalLahir_Month.Locked = True
    CboTanggalLahir_Month.BackColor = vbWhite
    CboTanggalLahir_Year.Locked = True
    CboTanggalLahir_Year.BackColor = vbWhite


End Sub

Private Sub DoUnlock()
    TxtDosenID.Locked = False
    TxtDosenID.BackColor = vbYellow
    TxtNamaAwal.Locked = False
    TxtNamaAwal.BackColor = vbYellow
    TxtNamaAkhir.Locked = False
    TxtNamaAkhir.BackColor = vbYellow
    TxtAlamat.Locked = False
    TxtAlamat.BackColor = vbYellow
    TxtTelepon.Locked = False
    TxtTelepon.BackColor = vbYellow
    TxtHP.Locked = False
    TxtHP.BackColor = vbYellow
    TxtEmail.Locked = False
    TxtEmail.BackColor = vbYellow
    TxtTempatLahir.Locked = False
    TxtTempatLahir.BackColor = vbYellow
    CboTanggalLahir_Day.Locked = False
    CboTanggalLahir_Day.BackColor = vbYellow
    CboTanggalLahir_Month.Locked = False
    CboTanggalLahir_Month.BackColor = vbYellow
    CboTanggalLahir_Year.Locked = False
    CboTanggalLahir_Year.BackColor = vbYellow


End Sub

Private Sub lblCancel_Click()
    DoLock
    lblSave.Enabled = False
    lblCancel.Enabled = False
    lblAddNew.Enabled = True
                
                Set dosenrecordset = myitem.GetDosen
                Set DataGridDosen.DataSource = dosenrecordset
                    DataGridDosen.Columns(0).Width = 600
                    DataGridDosen.Columns(1).Width = 1500
                    DataGridDosen.Columns(2).Width = 1500
                    DataGridDosen.Columns(3).Width = 2500
                    DataGridDosen.Columns(4).Width = 1100
                    DataGridDosen.Columns(5).Width = 1000
                If dosenrecordset.RecordCount > 0 Then
                    lblDelete.Enabled = True
                    lblEdit.Enabled = True
                    dosenrecordset.MoveFirst
                End If
                isedit = False
                
                    TxtDosenID.Text = ""
                    TxtAlamat.Text = ""
                    TxtEmail.Text = ""
                    TxtHP.Text = ""
                    TxtNamaAwal.Text = ""
                    TxtNamaAkhir.Text = ""
                
                    CboTanggalLahir_Day.Clear
                    CboTanggalLahir_Month.Clear
                    CboTanggalLahir_Year.Clear
                    
                    
                    For counter = 1 To 31
                        CboTanggalLahir_Day.AddItem (counter)
                    Next counter
                    For counter = 1 To 12
                        CboTanggalLahir_Month.AddItem (counter)
                    Next counter
                    For counter = 1900 To 2200
                        CboTanggalLahir_Year.AddItem (counter)
                    Next counter
                    TxtTelepon.Text = ""
                    TxtTempatLahir.Text = ""
End Sub

Private Sub LblDelete_Click()
On Error GoTo deleteerror:
        Set myitem = New ClsItemServer
        
     Dim iresponse As Long
        Dim saskUSER As String
        saskUSER = "Are you sure want to delete Dosen Data with DosenID = " & Trim(DataGridDosen.Columns(0).Value) & " and Name : " & Trim(DataGridDosen.Columns(1).Value) & " " & Trim(DataGridDosen.Columns(2).Value) & " ?"
        iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Delete Dosen Data")
        Dim deleteok As Boolean
        deleteok = False
        If (iresponse = vbYes) Then
            deleteok = myitem.DeleteDosen(Trim(DataGridDosen.Columns(0).Value))
        End If
        If deleteok = True Then
            
            MsgBox "Dosen Data deleted !", vbInformation, "Data Deleted !"
        End If
            Set dosenrecordset = myitem.GetDosen
            Set DataGridDosen.DataSource = dosenrecordset
            
            If dosenrecordset.RecordCount > 0 Then
                lblDelete.Enabled = True
                lblEdit.Enabled = True
                dosenrecordset.MoveFirst
            End If
        
        Exit Sub
        
deleteerror:
    MsgBox "Please Delete All Data linked to this person before you delete", vbInformation, "Error !"
    


    isedit = False
End Sub

Private Sub lblEdit_Click()
    isedit = True
    TxtDosenID.Text = Trim(DataGridDosen.Columns(0).Value)
    TxtNamaAwal.Text = Trim(DataGridDosen.Columns(1).Value)
    TxtNamaAkhir.Text = Trim(DataGridDosen.Columns(2).Value)
    TxtAlamat.Text = Trim(DataGridDosen.Columns(3).Value)
    TxtTelepon.Text = Trim(DataGridDosen.Columns(4).Value)
    TxtHP.Text = Trim(DataGridDosen.Columns(5).Value)
    TxtEmail.Text = Trim(DataGridDosen.Columns(6).Value)
    TxtTempatLahir.Text = Trim(DataGridDosen.Columns(7).Value)

        Dim tgllahir_day As String
        Dim tgllahir_month As String
        Dim tgllahir_year As String
        Dim tgllahir As String
        tgllahir = Trim(DataGridDosen.Columns(8).Value)
        If IsDate((Trim(Trim(DataGridDosen.Columns(8).Value)))) = True Then
            If Left(Mid(Trim(tgllahir), 1, 2), 1) = "0" Then
                tgllahir_day = Mid(Trim(tgllahir), 2, 1)
                
            Else
                tgllahir_day = Mid(Trim(tgllahir), 1, 2)
            End If
            tgllahir = Trim(DataGridDosen.Columns(8).Value)
            If Left(Mid(Trim(tgllahir), 4, 2), 1) = "0" Then
                 tgllahir_month = Mid(Trim(tgllahir), 5, 1)
            Else
                 tgllahir_month = Mid(Trim(tgllahir), 4, 2)
            End If
            tgllahir = Trim(DataGridDosen.Columns(8).Value)
            tgllahir_year = Mid(Trim(Trim(DataGridDosen.Columns(8).Value)), 7, 4)
            CboTanggalLahir_Day.Text = tgllahir_day
            CboTanggalLahir_Month.Text = tgllahir_month
            CboTanggalLahir_Year.Text = tgllahir_year
            
        End If
    DoUnlock
    TxtDosenID.Locked = True
    TxtDosenID.BackColor = vbWhite
    TxtNamaAwal.SetFocus
    lblSave.Enabled = True
    lblCancel.Enabled = True
    lblEdit.Enabled = False
    lblDelete.Enabled = False
    lblAddNew.Enabled = False
    
End Sub

Private Sub lblSave_Click()
Dim counter As Long
Dim saveok As Boolean
Dim DoubleDosenID As Boolean

DoubleDosenID = False
saveok = False
Set myitem = New ClsItemServer
LSet AddDosenBuffer = AddDosen
DoubleDosenID = myitem.DoubleDosenID(Trim(AddDosen.DosenID))
If isedit = False Then

        If DoubleDosenID = True Then
            MsgBox "The DosenID is already existed ! Try another DosenID !", vbInformation, "Warning !"
        Else
            Set myitem = New ClsItemServer
            saveok = myitem.AddDosen(AddDosenBuffer.Buffer, UpdateUser)
            
            
            
            If saveok = True Then
            
                DoLock
                lblSave.Enabled = False
                lblCancel.Enabled = False
                lblAddNew.Enabled = True
                MsgBox "Save Dosen Data Successfully !", vbInformation, "Data is recorded !"
            
                Set dosenrecordset = myitem.GetDosen
                Set DataGridDosen.DataSource = dosenrecordset
                DataGridDosen.Columns(0).Width = 600
                DataGridDosen.Columns(1).Width = 1500
                DataGridDosen.Columns(2).Width = 1500
                DataGridDosen.Columns(3).Width = 2500
                DataGridDosen.Columns(4).Width = 1100
                DataGridDosen.Columns(5).Width = 1000
                If dosenrecordset.RecordCount > 0 Then
                    lblDelete.Enabled = True
                    lblEdit.Enabled = True
                    dosenrecordset.MoveFirst
                End If
                isedit = False
                
                    TxtDosenID.Text = ""
                    TxtAlamat.Text = ""
                    TxtEmail.Text = ""
                    TxtHP.Text = ""
                    TxtNamaAwal.Text = ""
                    TxtNamaAkhir.Text = ""
                
                    CboTanggalLahir_Day.Clear
                    CboTanggalLahir_Month.Clear
                    CboTanggalLahir_Year.Clear
                    
                    
                    For counter = 1 To 31
                        CboTanggalLahir_Day.AddItem (counter)
                    Next counter
                    For counter = 1 To 12
                        CboTanggalLahir_Month.AddItem (counter)
                    Next counter
                    For counter = 1900 To 2200
                        CboTanggalLahir_Year.AddItem (counter)
                    Next counter
                    TxtTelepon.Text = ""
                    TxtTempatLahir.Text = ""
                
            Else
                MsgBox "Save Dosen Data unSuccessfully !", vbInformation, "Data is not recorded !"
                
            End If
        End If
Else
    Set myitem = New ClsItemServer
    saveok = myitem.UpdateDosen(AddDosenBuffer.Buffer, UpdateUser)
    If saveok = True Then
            
                DoLock
                lblSave.Enabled = False
                lblCancel.Enabled = False
                lblAddNew.Enabled = True
                MsgBox "Save Dosen Data Successfully !", vbInformation, "Data is recorded !"
            
                Set dosenrecordset = myitem.GetDosen
                Set DataGridDosen.DataSource = dosenrecordset
                DataGridDosen.Columns(0).Width = 600
                DataGridDosen.Columns(1).Width = 1500
                DataGridDosen.Columns(2).Width = 1500
                DataGridDosen.Columns(3).Width = 2500
                DataGridDosen.Columns(4).Width = 1100
                DataGridDosen.Columns(5).Width = 1000
                If dosenrecordset.RecordCount > 0 Then
                    lblDelete.Enabled = True
                    lblEdit.Enabled = True
                    dosenrecordset.MoveFirst
                End If
                isedit = False
                    TxtDosenID.Text = ""
                    TxtAlamat.Text = ""
                    TxtEmail.Text = ""
                    TxtHP.Text = ""
                    TxtNamaAwal.Text = ""
                    TxtNamaAkhir.Text = ""
                
                    CboTanggalLahir_Day.Clear
                    CboTanggalLahir_Month.Clear
                    CboTanggalLahir_Year.Clear
                    
                   
                    For counter = 1 To 31
                        CboTanggalLahir_Day.AddItem (counter)
                    Next counter
                    For counter = 1 To 12
                        CboTanggalLahir_Month.AddItem (counter)
                    Next counter
                    For counter = 1900 To 2200
                        CboTanggalLahir_Year.AddItem (counter)
                    Next counter
                    TxtTelepon.Text = ""
                    TxtTempatLahir.Text = ""
    Else
                MsgBox "Save Dosen Data unSuccessfully !", vbInformation, "Data is not recorded !"
                
    End If

End If

End Sub

Private Sub TxtAlamat_Change()
    AddDosen.Alamat = TxtAlamat.Text
End Sub

Private Sub TxtEmail_Change()
    AddDosen.Email = TxtEmail.Text
End Sub

Private Sub TxtHP_Change()
    AddDosen.HP = TxtHP.Text
End Sub

Private Sub TxtNamaAkhir_Change()
    AddDosen.Nama_Akhir = TxtNamaAkhir.Text
End Sub

Private Sub TxtNamaAwal_Change()
    AddDosen.Nama_Awal = TxtNamaAwal.Text
End Sub

Private Sub TxtDosenID_Change()
    AddDosen.DosenID = TxtDosenID.Text
End Sub



Private Sub TxtTelepon_Change()
    AddDosen.Telepon = TxtTelepon.Text
End Sub

Private Sub TxtTempatLahir_Change()
    AddDosen.TempatLahir = TxtTempatLahir.Text
End Sub
Private Sub CboTanggalLahir_Day_Click()
       Dim tanggallahir_day As String
    Dim tanggallahir_month As String
    If Len(CboTanggalLahir_Day.Text) = 1 Then
        tanggallahir_day = "0" + CboTanggalLahir_Day.Text
    Else
        tanggallahir_day = CboTanggalLahir_Day.Text
    End If
    If Len(CboTanggalLahir_Month.Text) = 1 Then
        tanggallahir_month = "0" + CboTanggalLahir_Month.Text
    Else
        tanggallahir_month = CboTanggalLahir_Month.Text
        
    End If
    If CboTanggalLahir_Day.Text <> "" And CboTanggalLahir_Month.Text <> "" And CboTanggalLahir_Year.Text <> "" Then
       AddDosen.TanggalLahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        AddDosen.TanggalLahir = ""
    End If
    
    
End Sub

Private Sub CboTanggalLahir_Month_Click()
        Dim tanggallahir_day As String
    Dim tanggallahir_month As String
    If Len(CboTanggalLahir_Day.Text) = 1 Then
        tanggallahir_day = "0" + CboTanggalLahir_Day.Text
    Else
        tanggallahir_day = CboTanggalLahir_Day.Text
    End If
    If Len(CboTanggalLahir_Month.Text) = 1 Then
        tanggallahir_month = "0" + CboTanggalLahir_Month.Text
    Else
        tanggallahir_month = CboTanggalLahir_Month.Text
        
    End If
        If CboTanggalLahir_Day.Text <> "" And CboTanggalLahir_Month.Text <> "" And CboTanggalLahir_Year.Text <> "" Then
       AddDosen.TanggalLahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        AddDosen.TanggalLahir = ""
    End If
End Sub

Private Sub CboTanggalLahir_Year_Click()
       Dim tanggallahir_day As String
    Dim tanggallahir_month As String
    If Len(CboTanggalLahir_Day.Text) = 1 Then
        tanggallahir_day = "0" + CboTanggalLahir_Day.Text
    Else
        tanggallahir_day = CboTanggalLahir_Day.Text
    End If
    If Len(CboTanggalLahir_Month.Text) = 1 Then
        tanggallahir_month = "0" + CboTanggalLahir_Month.Text
    Else
        tanggallahir_month = CboTanggalLahir_Month.Text
        
    End If
        If CboTanggalLahir_Day.Text <> "" And CboTanggalLahir_Month.Text <> "" And CboTanggalLahir_Year.Text <> "" Then
       AddDosen.TanggalLahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        AddDosen.TanggalLahir = ""
    End If
End Sub

