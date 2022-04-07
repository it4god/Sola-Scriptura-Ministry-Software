VERSION 5.00
Begin VB.Form frmMahasiswa 
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
   Begin VB.ComboBox CboStatus 
      Height          =   315
      ItemData        =   "FrmMahasiswa.frx":0000
      Left            =   10440
      List            =   "FrmMahasiswa.frx":0010
      Locked          =   -1  'True
      TabIndex        =   14
      Top             =   5520
      Width           =   3195
   End
   Begin VB.ComboBox CboTanggalLahir_Year 
      Height          =   315
      Left            =   12360
      Locked          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   11
      Top             =   4560
      Width           =   1275
   End
   Begin VB.ComboBox CboTanggalLahir_Month 
      Height          =   315
      Left            =   11400
      Locked          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   10
      Top             =   4560
      Width           =   855
   End
   Begin VB.ComboBox CboTanggalLahir_Day 
      Height          =   315
      Left            =   10440
      Locked          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   9
      Top             =   4560
      Width           =   855
   End
   Begin VB.TextBox TxtTempatLahir 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
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
      TabIndex        =   27
      Top             =   360
      Width           =   7987
   End
   Begin VB.TextBox TxtTelepon 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   5
      Top             =   3600
      Width           =   3195
   End
   Begin VB.TextBox TxtNIM 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   1800
      Width           =   3195
   End
   Begin VB.TextBox TxtNamaAwal 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   2
      Top             =   2640
      Width           =   3195
   End
   Begin VB.TextBox TxtNamaAkhir 
      Height          =   285
      Left            =   10440
      Locked          =   -1  'True
      TabIndex        =   3
      Top             =   2640
      Width           =   3195
   End
   Begin VB.TextBox TxtAlamat 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   4
      Top             =   3120
      Width           =   8475
   End
   Begin VB.TextBox TxtEmail 
      BackColor       =   &H00FFFFFF&
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   7
      Top             =   4080
      Width           =   8475
   End
   Begin VB.TextBox TxtHP 
      Height          =   285
      Left            =   10440
      Locked          =   -1  'True
      TabIndex        =   6
      Top             =   3600
      Width           =   3195
   End
   Begin VB.TextBox TxtPeriode 
      Height          =   285
      Left            =   5160
      Locked          =   -1  'True
      TabIndex        =   13
      Top             =   5520
      Width           =   3195
   End
   Begin VB.ComboBox CboProgram 
      Height          =   315
      ItemData        =   "FrmMahasiswa.frx":0030
      Left            =   5160
      List            =   "FrmMahasiswa.frx":0043
      Locked          =   -1  'True
      TabIndex        =   12
      Top             =   5040
      Width           =   3195
   End
   Begin VB.Image Image2 
      Height          =   1575
      Left            =   600
      Picture         =   "FrmMahasiswa.frx":007A
      Stretch         =   -1  'True
      Top             =   6360
      Width           =   1755
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Status"
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
      TabIndex        =   30
      Top             =   5520
      Width           =   1935
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
      TabIndex        =   29
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
      TabIndex        =   28
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
      TabIndex        =   26
      Top             =   3600
      Width           =   1935
   End
   Begin VB.Label lblTitleAddMahasiswa 
      BackStyle       =   0  'Transparent
      Caption         =   "Add Mahasiswa"
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
      TabIndex        =   25
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
      TabIndex        =   16
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
      TabIndex        =   15
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
      Picture         =   "FrmMahasiswa.frx":125F
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   13080
      Picture         =   "FrmMahasiswa.frx":1D53
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image ImgAddNew 
      Height          =   495
      Left            =   3360
      Picture         =   "FrmMahasiswa.frx":2847
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmMahasiswa.frx":333B
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11760
      Picture         =   "FrmMahasiswa.frx":3E57
      Top             =   480
      Width           =   2805
   End
   Begin VB.Label lblNIM 
      BackStyle       =   0  'Transparent
      Caption         =   "NIM"
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
      TabIndex        =   24
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
      TabIndex        =   23
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
      TabIndex        =   22
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
      TabIndex        =   21
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
      TabIndex        =   20
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
      TabIndex        =   19
      Top             =   3600
      Width           =   1935
   End
   Begin VB.Label LblPeriode 
      BackStyle       =   0  'Transparent
      Caption         =   "Periode Masuk"
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
      Top             =   5520
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
      Left            =   3360
      TabIndex        =   17
      Top             =   5040
      Width           =   1935
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmMahasiswa.frx":4941
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmMahasiswa.frx":529F
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmMahasiswa.frx":5CE0
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmMahasiswa.frx":66EEA
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmMahasiswa"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim AddMahasiswa As Mahasiswa
Dim AddMahasiswaBuffer As Mahasiswa_Buffer
Dim myitem  As ClsItemServer









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
    CenterChildForm Me
    TxtIndentity.Text = "Periode : " & Trim(strperiode)
End Sub

Private Sub imgQuit_Click()
Unload Me
End Sub

Private Sub lblAddNew_Click()
    AddMahasiswa.Alamat = ""
    AddMahasiswa.Email = ""
    AddMahasiswa.HP = ""
    AddMahasiswa.Nama_Akhir = ""
    AddMahasiswa.Nama_Awal = ""
    AddMahasiswa.NIM = ""
    AddMahasiswa.PeriodeMasuk = ""
    AddMahasiswa.Program = "S.Th."
    AddMahasiswa.TanggalLahir = ""
    AddMahasiswa.Telepon = ""
    AddMahasiswa.TempatLahir = ""
    AddMahasiswa.Status = ""
    TxtNIM.Text = ""
    TxtAlamat.Text = ""
    TxtEmail.Text = ""
    TxtHP.Text = ""
    TxtNamaAwal.Text = ""
    TxtNamaAkhir.Text = ""
    TxtPeriode.Text = ""
    CboStatus.Text = ""
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
    CboProgram.Text = "Sarjana"
End Sub

Private Sub DoLock()
    TxtNIM.Locked = True
    TxtNIM.BackColor = vbWhite
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
    CboProgram.Locked = True
    CboProgram.BackColor = vbWhite
    TxtPeriode.Locked = True
    TxtPeriode.BackColor = vbWhite
    CboStatus.Locked = True
    CboStatus.BackColor = vbWhite
End Sub

Private Sub DoUnlock()
    TxtNIM.Locked = False
    TxtNIM.BackColor = vbYellow
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
    CboProgram.Locked = False
    CboProgram.BackColor = vbYellow
    TxtPeriode.Locked = False
    TxtPeriode.BackColor = vbYellow
    CboStatus.Locked = False
    CboStatus.BackColor = vbYellow
End Sub

Private Sub lblCancel_Click()
    DoLock
    lblSave.Enabled = False
    lblCancel.Enabled = False
    lblAddNew.Enabled = True
End Sub

Private Sub lblSave_Click()
Dim saveok As Boolean
Dim DoubleNIM As Boolean

DoubleNIM = False
saveok = False
Set myitem = New ClsItemServer
LSet AddMahasiswaBuffer = AddMahasiswa
DoubleNIM = myitem.DoubleNIM(Trim(AddMahasiswa.NIM))

If DoubleNIM = True Then
    MsgBox "The NIM is already existed ! Try another NIM !", vbInformation, "Warning !"
Else
    Set myitem = New ClsItemServer
    saveok = myitem.AddMahasiswa(AddMahasiswaBuffer.Buffer, UpdateUser)
    
    
    
    If saveok = True Then
    
        DoLock
        lblSave.Enabled = False
        lblCancel.Enabled = False
        lblAddNew.Enabled = True
        MsgBox "Save Mahasiswa Data Successfully !", vbInformation, "Data is recorded !"
    Else
        MsgBox "Save Mahasiswa Data unSuccessfully !", vbInformation, "Data is not recorded !"
        
    End If
End If
End Sub
Private Sub CboProgram_Change()
    AddMahasiswa.Program = CboProgram.Text
End Sub
Private Sub CboProgram_Click()
    AddMahasiswa.Program = CboProgram.Text
End Sub

Private Sub TxtAlamat_Change()
    AddMahasiswa.Alamat = TxtAlamat.Text
End Sub

Private Sub TxtEmail_Change()
    AddMahasiswa.Email = TxtEmail.Text
End Sub

Private Sub TxtHP_Change()
    AddMahasiswa.HP = TxtHP.Text
End Sub

Private Sub TxtNamaAkhir_Change()
    AddMahasiswa.Nama_Akhir = TxtNamaAkhir.Text
End Sub

Private Sub TxtNamaAwal_Change()
    AddMahasiswa.Nama_Awal = TxtNamaAwal.Text
End Sub

Private Sub TxtNIM_Change()
    AddMahasiswa.NIM = TxtNIM.Text
End Sub

Private Sub txtperiode_Change()
    AddMahasiswa.PeriodeMasuk = TxtPeriode.Text
End Sub

Private Sub TxtTelepon_Change()
    AddMahasiswa.Telepon = TxtTelepon.Text
End Sub

Private Sub TxtTempatLahir_Change()
    AddMahasiswa.TempatLahir = TxtTempatLahir.Text
End Sub

Private Sub CboStatus_Change()
    AddMahasiswa.Status = CboStatus.Text
End Sub

Private Sub CboStatus_Click()
    AddMahasiswa.Status = CboStatus.Text
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
       AddMahasiswa.TanggalLahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        AddMahasiswa.TanggalLahir = ""
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
       AddMahasiswa.TanggalLahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        AddMahasiswa.TanggalLahir = ""
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
       AddMahasiswa.TanggalLahir = tanggallahir_day + "/" + tanggallahir_month + "/" + CboTanggalLahir_Year.Text
    Else
        AddMahasiswa.TanggalLahir = ""
    End If
End Sub
