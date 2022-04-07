VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmPelayanan 
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
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   5760
      Top             =   8760
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
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
   Begin VB.TextBox TxtPelayanan 
      BackColor       =   &H00FFFFFF&
      Height          =   285
      Left            =   5280
      Locked          =   -1  'True
      TabIndex        =   2
      Top             =   6960
      Width           =   7875
   End
   Begin VB.TextBox TxtPeriode 
      Height          =   285
      Left            =   5280
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   6480
      Width           =   7875
   End
   Begin MSDataGridLib.DataGrid DataGridPelayanan 
      Height          =   5055
      Left            =   3360
      TabIndex        =   13
      Top             =   1320
      Width           =   9855
      _ExtentX        =   17383
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
   Begin VB.Image Image2 
      Height          =   1575
      Left            =   600
      Picture         =   "FrmPelayanan.frx":0000
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
      TabIndex        =   20
      Top             =   3840
      Width           =   1605
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
      TabIndex        =   19
      Top             =   7560
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
      TabIndex        =   18
      Top             =   7560
      Width           =   1965
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
      TabIndex        =   17
      Top             =   7560
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
      TabIndex        =   16
      Top             =   7560
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
      TabIndex        =   15
      Top             =   7560
      Width           =   1965
   End
   Begin VB.Label lblTitlePelayanan 
      BackStyle       =   0  'Transparent
      Caption         =   "Pelayanan"
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
      Left            =   12120
      TabIndex        =   14
      Top             =   600
      Width           =   2685
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
   Begin VB.Label LblPelayanan2 
      BackStyle       =   0  'Transparent
      Caption         =   "Pelayanan"
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
      Top             =   6960
      Width           =   1935
   End
   Begin VB.Label LblPeriode 
      BackStyle       =   0  'Transparent
      Caption         =   "Periode"
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
      TabIndex        =   9
      Top             =   6480
      Width           =   1935
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
      TabIndex        =   8
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
      TabIndex        =   7
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
      TabIndex        =   6
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
      TabIndex        =   5
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
      TabIndex        =   4
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
      TabIndex        =   3
      Top             =   2040
      Width           =   1605
   End
   Begin VB.Image imgLeft 
      Height          =   2310
      Left            =   2880
      Picture         =   "FrmPelayanan.frx":11E5
      Top             =   5760
      Width           =   435
   End
   Begin VB.Image imgVariation 
      Height          =   420
      Left            =   11880
      Picture         =   "FrmPelayanan.frx":1D01
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
      TabIndex        =   0
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   14280
      Picture         =   "FrmPelayanan.frx":27EB
      Top             =   1200
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   14280
      Picture         =   "FrmPelayanan.frx":3149
      Top             =   2040
      Width           =   645
   End
   Begin VB.Image ImgSuamiIstri 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPelayanan.frx":3B8A
      Stretch         =   -1  'True
      Top             =   3000
      Width           =   2250
   End
   Begin VB.Image ImgAdikKakak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPelayanan.frx":4927
      Stretch         =   -1  'True
      Top             =   2640
      Width           =   2250
   End
   Begin VB.Image ImgPendidikan 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPelayanan.frx":56C4
      Stretch         =   -1  'True
      Top             =   3720
      Width           =   2250
   End
   Begin VB.Image ImgPrestasi 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPelayanan.frx":6461
      Stretch         =   -1  'True
      Top             =   3360
      Width           =   2250
   End
   Begin VB.Image ImgAnak 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPelayanan.frx":71FE
      Stretch         =   -1  'True
      Top             =   2280
      Width           =   2250
   End
   Begin VB.Image ImgOrangtua 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPelayanan.frx":7F9B
      Stretch         =   -1  'True
      Top             =   1920
      Width           =   2250
   End
   Begin VB.Image ImgBioData 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPelayanan.frx":8D38
      Stretch         =   -1  'True
      Top             =   1200
      Width           =   2250
   End
   Begin VB.Image ImgAlamat 
      Height          =   375
      Left            =   360
      Picture         =   "FrmPelayanan.frx":9AD5
      Stretch         =   -1  'True
      Top             =   1560
      Width           =   2250
   End
   Begin VB.Image ImgChurchData 
      Height          =   495
      Left            =   360
      Picture         =   "FrmPelayanan.frx":A872
      Stretch         =   -1  'True
      Top             =   7320
      Width           =   2250
   End
   Begin VB.Image Image1 
      Height          =   8055
      Left            =   240
      Picture         =   "FrmPelayanan.frx":B60F
      Stretch         =   -1  'True
      Top             =   240
      Width           =   2520
   End
   Begin VB.Image Image6 
      Height          =   495
      Left            =   5640
      Picture         =   "FrmPelayanan.frx":6C819
      Top             =   7440
      Width           =   1980
   End
   Begin VB.Image Image3 
      Height          =   495
      Left            =   7920
      Picture         =   "FrmPelayanan.frx":6D30D
      Top             =   7440
      Width           =   1980
   End
   Begin VB.Image ImgAddNew 
      Height          =   495
      Left            =   3360
      Picture         =   "FrmPelayanan.frx":6DE01
      Top             =   7440
      Width           =   1980
   End
   Begin VB.Image Image4 
      Height          =   495
      Left            =   13080
      Picture         =   "FrmPelayanan.frx":6E8F5
      Top             =   7440
      Width           =   1980
   End
   Begin VB.Image Image5 
      Height          =   495
      Left            =   10920
      Picture         =   "FrmPelayanan.frx":6F3E9
      Top             =   7440
      Width           =   1980
   End
   Begin VB.Image imgBg 
      Height          =   8055
      Left            =   2760
      Picture         =   "FrmPelayanan.frx":6FEDD
      Stretch         =   -1  'True
      Top             =   240
      Width           =   12480
   End
End
Attribute VB_Name = "frmPelayanan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim myPelayanan As Pelayanan
Dim myPelayananBuffer As Pelayanan_Buffer
Dim myitem As ClsItemServer
Dim rsPelayanan As ADODB.Recordset


Private Sub Form_Load()
    CenterChildForm Me

  
    TxtIndentity.Text = "NIM = " & Trim(CurrentMahasiswa.NIM) & " , " & Trim(CurrentMahasiswa.Nama_Awal) & " " & Trim(CurrentMahasiswa.Nama_Akhir) & vbCrLf & "Periode : " & strperiode
    Set myitem = New ClsItemServer
    Set rsPelayanan = myitem.GetPelayanan(Trim(CurrentMahasiswa.NIM))
    Set DataGridPelayanan.DataSource = rsPelayanan
    DataGridPelayanan.Columns(0).Width = 1000
    DataGridPelayanan.Columns(1).Width = 2500
    DataGridPelayanan.Columns(2).Width = 4500
    If rsPelayanan.RecordCount > 0 Then
        lblEdit.Enabled = True
        lblDelete.Enabled = True
        rsPelayanan.MoveFirst
    Else
        lblEdit.Enabled = False
        lblDelete.Enabled = False
    End If
    
End Sub



Private Sub imgQuit_Click()
Unload Me
End Sub



Private Sub lblAddNew_Click()
    lblAddNew.Enabled = False
    lblEdit.Enabled = False
    lblDelete.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    TxtPeriode.Text = ""
    TxtPeriode.Locked = False
    TxtPeriode.BackColor = vbYellow
    TxtPelayanan.Text = ""
    TxtPelayanan.Locked = False
    TxtPelayanan.BackColor = vbYellow
    myPelayanan.Periode = ""
    myPelayanan.PelayananNo = ""
    myPelayanan.Pelayanan = ""
    myPelayanan.NIM = Trim(CurrentMahasiswa.NIM)
    
End Sub

Private Sub lblCancel_Click()
    lblAddNew.Enabled = True
    lblSave.Enabled = False
    lblCancel.Enabled = False
    Set myitem = New ClsItemServer
    Set rsPelayanan = myitem.GetPelayanan(Trim(CurrentMahasiswa.NIM))
    Set DataGridPelayanan.DataSource = rsPelayanan
    DataGridPelayanan.Columns(0).Width = 1000
    DataGridPelayanan.Columns(1).Width = 2500
    DataGridPelayanan.Columns(2).Width = 4500
    If rsPelayanan.RecordCount > 0 Then
        lblEdit.Enabled = True
        lblDelete.Enabled = True
        rsPelayanan.MoveFirst
    Else
        lblEdit.Enabled = False
        lblDelete.Enabled = False
    End If
    TxtPeriode.Text = ""
    TxtPeriode.Locked = True
    TxtPeriode.BackColor = vbWhite
    TxtPelayanan.Text = ""
    TxtPelayanan.Locked = True
    TxtPelayanan.BackColor = vbWhite
End Sub

Private Sub LblDelete_Click()
On Error GoTo deleteerror:
        Set myitem = New ClsItemServer
        
     Dim iresponse As Long
        Dim saskUSER As String
        saskUSER = "Are you sure want to delete Pelayanan Data with periode  = " & Trim(DataGridPelayanan.Columns(1).Value) & " ?"
        iresponse = MsgBox(saskUSER, vbQuestion + vbYesNo + vbDefaultButton2, "Delete Pelayanan")
        Dim deleteok As Boolean
        deleteok = False
        If (iresponse = vbYes) Then
            deleteok = myitem.DeletePelayanan(Trim(DataGridPelayanan.Columns(0).Value))
        End If
        If deleteok = True Then
           
            MsgBox "Pelayanan Data deleted !", vbInformation, "Data Deleted !"
            Set myitem = New ClsItemServer
            Set rsPelayanan = myitem.GetPelayanan(Trim(CurrentMahasiswa.NIM))
            Set DataGridPelayanan.DataSource = rsPelayanan
            DataGridPelayanan.Columns(0).Width = 1000
            DataGridPelayanan.Columns(1).Width = 2500
            DataGridPelayanan.Columns(2).Width = 4500
            If rsPelayanan.RecordCount > 0 Then
                lblEdit.Enabled = True
                lblDelete.Enabled = True
                rsPelayanan.MoveFirst
            Else
                lblEdit.Enabled = False
                lblDelete.Enabled = False
            End If
        End If
        Exit Sub
deleteerror:
    MsgBox "Please Delete All Data linked to this person before you delete", vbInformation, "Error !"
End Sub

Private Sub lblEdit_Click()
    lblEdit.Enabled = False
    lblSave.Enabled = True
    lblCancel.Enabled = True
    lblDelete.Enabled = False
    lblAddNew.Enabled = False
    myPelayanan.Periode = Trim(DataGridPelayanan.Columns(1).Value)
    myPelayanan.PelayananNo = Trim(DataGridPelayanan.Columns(0).Value)
    myPelayanan.Pelayanan = Trim(DataGridPelayanan.Columns(2).Value)
    myPelayanan.NIM = Trim(CurrentMahasiswa.NIM)
    TxtPeriode.Text = Trim(DataGridPelayanan.Columns(1).Value)
    TxtPelayanan.Text = Trim(DataGridPelayanan.Columns(2).Value)
    TxtPeriode.Locked = False
    TxtPeriode.BackColor = vbYellow
    TxtPelayanan.Locked = False
    TxtPelayanan.BackColor = vbYellow
End Sub








Private Sub lblOpenPelayanan_Click()
    Dim PelayananName As String
    PelayananName = Trim(DataGridPelayanan.Columns(2).Value)
    ShellExecute 0, "Open", PelayananName, "", 0, 6
    
End Sub

Private Sub lblSave_Click()
Dim saveok As Boolean
saveok = False
LSet myPelayananBuffer = myPelayanan
Set myitem = New ClsItemServer

saveok = myitem.savePelayanan(myPelayananBuffer.Buffer, UpdateUser)
If saveok = True Then
    
    MsgBox "Save Pelayanan successfully !", vbInformation, "Information"
    lblAddNew.Enabled = True
    lblSave.Enabled = False
    lblCancel.Enabled = False

    Set myitem = New ClsItemServer
    Set rsPelayanan = myitem.GetPelayanan(Trim(CurrentMahasiswa.NIM))
    Set DataGridPelayanan.DataSource = rsPelayanan
    DataGridPelayanan.Columns(0).Width = 1000
    DataGridPelayanan.Columns(1).Width = 2500
    DataGridPelayanan.Columns(2).Width = 4500
    TxtPeriode.Locked = True
    TxtPeriode.BackColor = vbWhite
    TxtPelayanan.Locked = True
    TxtPelayanan.BackColor = vbWhite
    lblAddNew.Enabled = True
    lblSave.Enabled = False
    lblCancel.Enabled = False
    If rsPelayanan.RecordCount > 0 Then
        lblEdit.Enabled = True
        lblDelete.Enabled = True
        rsPelayanan.MoveFirst
    Else
        lblEdit.Enabled = False
        lblDelete.Enabled = False
    End If
Else
    MsgBox "Save Pelayanan unsuccessfully !", vbInformation, "Information"

End If
End Sub

Private Sub txtperiode_Change()
    myPelayanan.Periode = Trim(TxtPeriode.Text)
End Sub

Private Sub txtpelayanan_Change()
    myPelayanan.Pelayanan = Trim(TxtPelayanan.Text)
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
Private Sub lblMnuPelayanan_Click()
    Unload Me
    frmPelayanan.Show
End Sub
Private Sub lblMnuPembayaran_Click()
    Unload Me
    frmPembayaran.Show
End Sub
Private Sub lblPelayanan_Click()
    Unload Me
    frmPelayanan.Show
End Sub
