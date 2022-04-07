VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmKRS 
   Appearance      =   0  'Flat
   AutoRedraw      =   -1  'True
   BackColor       =   &H00DC7F59&
   BorderStyle     =   0  'None
   Caption         =   "About MyApp"
   ClientHeight    =   9375
   ClientLeft      =   2295
   ClientTop       =   1605
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
   Begin VB.TextBox TxtMK 
      Height          =   285
      Left            =   4920
      Locked          =   -1  'True
      TabIndex        =   13
      Top             =   1440
      Width           =   3195
   End
   Begin VB.TextBox TxtIndentity 
      Alignment       =   2  'Center
      BackColor       =   &H80000006&
      ForeColor       =   &H80000005&
      Height          =   495
      Left            =   2880
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   12
      Top             =   360
      Width           =   7987
   End
   Begin MSDataGridLib.DataGrid DataGridKRS 
      Height          =   5295
      Left            =   3360
      TabIndex        =   15
      Top             =   2040
      Width           =   10215
      _ExtentX        =   18018
      _ExtentY        =   9340
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
   Begin VB.Image Image2 
      Height          =   1575
      Left            =   600
      Picture         =   "FrmKRS.frx":0000
      Stretch         =   -1  'True
      Top             =   5640
      Width           =   1755
   End
   Begin VB.Label lblPelayanan 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "PELAYANAN"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   16
      Top             =   3840
      Width           =   1605
   End
   Begin VB.Label lblMK 
      BackStyle       =   0  'Transparent
      Caption         =   "Add Mata Kuliah"
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
      Left            =   3120
      TabIndex        =   14
      Top             =   1440
      Width           =   1935
   End
   Begin VB.Label lblMnuFile 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "FILE"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   11
      Top             =   3120
      Width           =   1605
   End
   Begin VB.Label lblTitleKRS 
      BackStyle       =   0  'Transparent
      Caption         =   "KRS"
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
      Left            =   12000
      TabIndex        =   10
      Top             =   600
      Width           =   2685
   End
   Begin VB.Label lblMnuBIOData 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "BIO DATA"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   9
      Top             =   1320
      Width           =   1605
   End
   Begin VB.Label lblMnuKRS 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "KRS"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   8
      Top             =   1680
      Width           =   1605
   End
   Begin VB.Label lblMnuKHS 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "KHS"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   7
      Top             =   2400
      Width           =   1605
   End
   Begin VB.Label lblMnuTrankrip 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "TRANSKRIP"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   6
      Top             =   2760
      Width           =   1605
   End
   Begin VB.Label lblMnuPembayaran 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "PEMBAYARAN"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   5
      Top             =   3480
      Width           =   1605
   End
   Begin VB.Label lblMnuMasukNilai 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "MASUK NILAI"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   195
      Left            =   840
      TabIndex        =   4
      Top             =   2040
      Width           =   1605
   End
   Begin VB.Label lblPendengar 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Pendengar"
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
      Left            =   10440
      TabIndex        =   2
      Top             =   1440
      Width           =   1965
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
      Left            =   8280
      TabIndex        =   1
      Top             =   1440
      Width           =   1965
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
      Left            =   8400
      TabIndex        =   0
      Top             =   7680
      Width           =   1965
   End
   Begin VB.Image Image5 
      Height          =   495
      Left            =   8280
      Picture         =   "FrmKRS.frx":11E5
      Top             =   1320
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   10440
      Picture         =   "FrmKRS.frx":1CD9
      Top             =   1320
      Width           =   1980
   End
   Begin VB.Image ImgDelete 
      Height          =   495
      Left            =   8400
      Picture         =   "FrmKRS.frx":27CD
      Top             =   7560
      Width           =   1980
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmKRS.frx":32C1
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11880
      Picture         =   "FrmKRS.frx":3DDD
      Top             =   480
      Width           =   2805
   End
   Begin VB.Label LblMyPersonID 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   5160
      TabIndex        =   3
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmKRS.frx":48C7
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmKRS.frx":5225
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmKRS.frx":5C66
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
   Begin VB.Image ImgSuamiIstri 
      Height          =   375
      Left            =   360
      Picture         =   "FrmKRS.frx":66E70
      Stretch         =   -1  'True
      Top             =   3000
      Width           =   2250
   End
   Begin VB.Image ImgAdikKakak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmKRS.frx":67C0D
      Stretch         =   -1  'True
      Top             =   2640
      Width           =   2250
   End
   Begin VB.Image ImgPendidikan 
      Height          =   375
      Left            =   360
      Picture         =   "FrmKRS.frx":689AA
      Stretch         =   -1  'True
      Top             =   3720
      Width           =   2250
   End
   Begin VB.Image ImgPrestasi 
      Height          =   375
      Left            =   360
      Picture         =   "FrmKRS.frx":69747
      Stretch         =   -1  'True
      Top             =   3360
      Width           =   2250
   End
   Begin VB.Image ImgAnak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmKRS.frx":6A4E4
      Stretch         =   -1  'True
      Top             =   2280
      Width           =   2250
   End
   Begin VB.Image ImgOrangtua 
      Height          =   375
      Left            =   360
      Picture         =   "FrmKRS.frx":6B281
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   2250
   End
   Begin VB.Image ImgBioData 
      Height          =   375
      Left            =   360
      Picture         =   "FrmKRS.frx":6C01E
      Stretch         =   -1  'True
      Top             =   1200
      Width           =   2250
   End
   Begin VB.Image ImgAlamat 
      Height          =   375
      Left            =   360
      Picture         =   "FrmKRS.frx":6CDBB
      Stretch         =   -1  'True
      Top             =   1560
      Width           =   2250
   End
   Begin VB.Image ImgChurchData 
      Height          =   495
      Left            =   360
      Picture         =   "FrmKRS.frx":6DB58
      Stretch         =   -1  'True
      Top             =   7320
      Width           =   2250
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmKRS.frx":6E8F5
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
End
Attribute VB_Name = "frmKRS"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Dim myitem As ClsItemServer
Dim MyMataKuliahMahasiswa As MataKuliahMahasiswa
Dim MyMataKuliahMahasiswaBuffer As MataKuliahMahasiswa_Buffer
Private Sub Form_Load()
    CenterChildForm Me

    
    TxtIndentity.Text = "NIM = " & Trim(CurrentMahasiswa.NIM) & " , " & Trim(CurrentMahasiswa.Nama_Awal) & " " & Trim(CurrentMahasiswa.Nama_Akhir) & vbCrLf & "Periode : " & strperiode
    Set myitem = New ClsItemServer
    Set DataGridKRS.DataSource = myitem.GetKRS(Periode, Trim(CurrentMahasiswa.NIM))
    DataGridKRS.Columns(0).Width = 1000
    DataGridKRS.Columns(1).Width = 3000
    DataGridKRS.Columns(2).Width = 800
    DataGridKRS.Columns(3).Width = 800
    DataGridKRS.Columns(4).Width = 800
    DataGridKRS.Columns(5).Width = 800

End Sub

Private Sub imgQuit_Click()
Unload Me
End Sub


Private Sub lblCancel_Click()
    lblEdit.Enabled = True
    lblDelete.Enabled = True
    lblSave.Enabled = False
    lblCancel.Enabled = False
    
End Sub

Private Sub lblEdit_Click()
    lblEdit.Enabled = False
    lblDelete.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True

End Sub


Private Sub lblAdd_Click()
If TxtMK.Text = "" Then
    MsgBox "Please insert the Mata Kuliah No", vbInformation, "Warning"
Else
MyMataKuliahMahasiswa.Grade = "ZZ"
MyMataKuliahMahasiswa.NIM = Trim(CurrentMahasiswa.NIM)
MyMataKuliahMahasiswa.MKP_No = Trim(strMatakuliahPerSemNo)
MyMataKuliahMahasiswa.MKM_No = ""
MyMataKuliahMahasiswa.Nilai = "0"


    Set myitem = New ClsItemServer
    Dim saveok As Boolean
    Dim iresponse As Long
    Dim saskUSER As String
    saskUSER = "Are you sure want to register Matakuliah with MK_No = " & Trim(TxtMK.Text) & " ?"
    iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Borrowers Table")

    If (iresponse = vbYes) Then
        LSet MyMataKuliahMahasiswaBuffer = MyMataKuliahMahasiswa
        
        saveok = myitem.saveKRS(MyMataKuliahMahasiswaBuffer.Buffer, UpdateUser)
        

    End If


    Set myitem = New ClsItemServer
    Set DataGridKRS.DataSource = myitem.GetKRS(Periode, Trim(CurrentMahasiswa.NIM))
    DataGridKRS.Columns(0).Width = 1000
    DataGridKRS.Columns(1).Width = 3000
    DataGridKRS.Columns(2).Width = 800
    DataGridKRS.Columns(3).Width = 800
    DataGridKRS.Columns(4).Width = 800
    DataGridKRS.Columns(5).Width = 800

End If
End Sub

Private Sub LblDelete_Click()

        Set myitem = New ClsItemServer
        Dim iresponse As Long
        Dim saskUSER As String
        saskUSER = "Are you sure want to delete KRS with MK_No = " & Trim(DataGridKRS.Columns(0)) & " ?"
        iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Delete KRS")
        Dim deleteok As Boolean
        deleteok = False
        If (iresponse = vbYes) Then
            deleteok = myitem.DeleteKRS(Trim(DataGridKRS.Columns(11).Value))
        End If
        If deleteok = True Then
            MsgBox "KRS deleted !", vbInformation, "Data Deleted !"
            
        End If
        Set myitem = New ClsItemServer
        Set DataGridKRS.DataSource = myitem.GetKRS(Periode, Trim(CurrentMahasiswa.NIM))
        DataGridKRS.Columns(0).Width = 1000
        DataGridKRS.Columns(1).Width = 3000
        DataGridKRS.Columns(2).Width = 800
        DataGridKRS.Columns(3).Width = 800
        DataGridKRS.Columns(4).Width = 800
        DataGridKRS.Columns(5).Width = 800

End Sub

Private Sub lblPendengar_Click()
If TxtMK.Text = "" Then
    MsgBox "Please insert the Mata Kuliah No", vbInformation, "Warning"
Else
MyMataKuliahMahasiswa.Grade = "Pd"
MyMataKuliahMahasiswa.NIM = Trim(CurrentMahasiswa.NIM)
MyMataKuliahMahasiswa.MKP_No = Trim(strMatakuliahPerSemNo)
MyMataKuliahMahasiswa.MKM_No = ""
MyMataKuliahMahasiswa.Nilai = "0"


    Set myitem = New ClsItemServer
    Dim saveok As Boolean
    Dim iresponse As Long
    Dim saskUSER As String
    saskUSER = "Are you sure want to register Matakuliah with MK_No = " & Trim(TxtMK.Text) & " ?"
    iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Borrowers Table")

    If (iresponse = vbYes) Then
        LSet MyMataKuliahMahasiswaBuffer = MyMataKuliahMahasiswa
        
        saveok = myitem.saveKRS(MyMataKuliahMahasiswaBuffer.Buffer, UpdateUser)
        

    End If
    Set myitem = New ClsItemServer

    Set myitem = New ClsItemServer
    Set DataGridKRS.DataSource = myitem.GetKRS(Periode, Trim(CurrentMahasiswa.NIM))
    DataGridKRS.Columns(0).Width = 1000
    DataGridKRS.Columns(1).Width = 3000
    DataGridKRS.Columns(2).Width = 800
    DataGridKRS.Columns(3).Width = 800
    DataGridKRS.Columns(4).Width = 800
    DataGridKRS.Columns(5).Width = 800

End If
End Sub

Private Sub TxtMK_Click()
    Lite = "KRS"
    FrmAddMatakuliahPerSem.Show
End Sub

Private Sub lblMnuBIOData_Click()
    Unload Me
    frmBioData.Show
End Sub

Private Sub lblMnuKHS_Click()
    Unload Me
    frmKHS.Show
End Sub

Private Sub lblMnuKRS_Click()
    Unload Me
    frmKRS.Show
End Sub
Private Sub lblMnuMasukNilai_Click()
    Unload Me
    frmMasukNilai.Show
End Sub
Private Sub lblMnuTrankrip_Click()
    Unload Me
    frmTranskrip.Show
End Sub
Private Sub lblMnuFile_Click()
    Unload Me
    frmFile.Show
End Sub
Private Sub lblMnuPembayaran_Click()
    Unload Me
    frmPembayaran.Show
End Sub
Private Sub lblPelayanan_Click()
    Unload Me
    frmPelayanan.Show
End Sub
