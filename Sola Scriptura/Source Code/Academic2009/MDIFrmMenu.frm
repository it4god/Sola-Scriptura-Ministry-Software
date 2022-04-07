VERSION 5.00
Object = "{22D6F304-B0F6-11D0-94AB-0080C74C7E95}#1.0#0"; "MSDXM.OCX"
Begin VB.MDIForm MDIfrmMenu 
   Appearance      =   0  'Flat
   BackColor       =   &H00DC7F59&
   Caption         =   "Sola Scriptura Academic - Charity Edition Version 1.0"
   ClientHeight    =   10950
   ClientLeft      =   10875
   ClientTop       =   3360
   ClientWidth     =   15180
   LinkTopic       =   "MDIForm1"
   Picture         =   "MDIFrmMenu.frx":0000
   ScrollBars      =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox picToolbar 
      Align           =   1  'Align Top
      Appearance      =   0  'Flat
      BackColor       =   &H00A6401B&
      BorderStyle     =   0  'None
      ForeColor       =   &H80000008&
      Height          =   2415
      Left            =   0
      ScaleHeight     =   2415
      ScaleWidth      =   15180
      TabIndex        =   1
      Top             =   0
      Width           =   15180
      Begin VB.Timer tmrTime 
         Interval        =   20000
         Left            =   0
         Top             =   2040
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Command1"
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   2040
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.Label lbPeriode 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "PERIODE"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   285
         Left            =   3120
         TabIndex        =   12
         Top             =   1755
         Width           =   1605
      End
      Begin VB.Image ImgPeriode 
         Height          =   1080
         Left            =   3360
         Picture         =   "MDIFrmMenu.frx":26A22
         Top             =   840
         Width           =   1035
      End
      Begin VB.Label LblLogOut 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "LOG OUT"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   285
         Left            =   10680
         TabIndex        =   10
         Top             =   1755
         Width           =   1605
      End
      Begin VB.Label LblAbout 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "ABOUT"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   285
         Left            =   9600
         TabIndex        =   9
         Top             =   1755
         Width           =   1605
      End
      Begin VB.Label lblAdmin 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "ADMIN"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   285
         Left            =   4200
         TabIndex        =   8
         Top             =   1755
         Width           =   1605
      End
      Begin VB.Image ImgAdmin 
         Height          =   1080
         Left            =   4440
         Picture         =   "MDIFrmMenu.frx":2768A
         Top             =   840
         Width           =   1035
      End
      Begin VB.Label LblAspek 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "ASPEK"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   285
         Left            =   2160
         TabIndex        =   6
         Top             =   1755
         Width           =   1365
      End
      Begin VB.Label LblMasukData 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "PROFIL"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   165
         Left            =   960
         TabIndex        =   5
         Top             =   1755
         Width           =   1605
      End
      Begin VB.Label LblMahasiswa 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "MAHASISWA"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   165
         Left            =   -120
         TabIndex        =   4
         Top             =   1755
         Width           =   1605
      End
      Begin VB.Image imgHelp 
         Height          =   1095
         Left            =   12000
         Picture         =   "MDIFrmMenu.frx":28472
         Top             =   840
         Width           =   3090
      End
      Begin VB.Image imgSolaTitle 
         Height          =   735
         Left            =   0
         Picture         =   "MDIFrmMenu.frx":29A23
         Stretch         =   -1  'True
         Top             =   0
         Width           =   15360
      End
      Begin VB.Image imgAbout 
         Height          =   1080
         Left            =   9840
         Picture         =   "MDIFrmMenu.frx":2B3E2
         Top             =   840
         Width           =   1035
      End
      Begin VB.Image imgMahasiswa 
         Height          =   1080
         Left            =   120
         Picture         =   "MDIFrmMenu.frx":2C0A1
         Tag             =   "1000"
         Top             =   840
         Width           =   1035
      End
      Begin VB.Image imgAspects 
         Height          =   1080
         Left            =   2280
         Picture         =   "MDIFrmMenu.frx":2CDA5
         Top             =   840
         Width           =   1035
      End
      Begin VB.Image imgOrang 
         Height          =   1080
         Left            =   1200
         Picture         =   "MDIFrmMenu.frx":2DB25
         Top             =   840
         Width           =   1035
      End
      Begin VB.Image imgLogout 
         Height          =   1080
         Left            =   10920
         Picture         =   "MDIFrmMenu.frx":2E85F
         Top             =   840
         Width           =   1035
      End
      Begin VB.Image imgSubMenu 
         Height          =   510
         Left            =   0
         Picture         =   "MDIFrmMenu.frx":2F566
         Top             =   1920
         Width           =   15360
      End
      Begin VB.Shape Shape1 
         BackColor       =   &H80000001&
         BackStyle       =   1  'Opaque
         BorderStyle     =   0  'Transparent
         Height          =   255
         Left            =   120
         Top             =   1965
         Width           =   11295
      End
   End
   Begin VB.PictureBox picBottom 
      Align           =   2  'Align Bottom
      Appearance      =   0  'Flat
      BackColor       =   &H00DC7F59&
      BorderStyle     =   0  'None
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   15180
      TabIndex        =   0
      Top             =   10530
      Width           =   15180
      Begin MediaPlayerCtl.MediaPlayer MediaPlayer1 
         Height          =   375
         Left            =   0
         TabIndex        =   13
         Top             =   120
         Width           =   2415
         AudioStream     =   -1
         AutoSize        =   0   'False
         AutoStart       =   -1  'True
         AnimationAtStart=   -1  'True
         AllowScan       =   -1  'True
         AllowChangeDisplaySize=   -1  'True
         AutoRewind      =   0   'False
         Balance         =   0
         BaseURL         =   ""
         BufferingTime   =   5
         CaptioningID    =   ""
         ClickToPlay     =   -1  'True
         CursorType      =   0
         CurrentPosition =   -1
         CurrentMarker   =   0
         DefaultFrame    =   ""
         DisplayBackColor=   0
         DisplayForeColor=   16777215
         DisplayMode     =   0
         DisplaySize     =   4
         Enabled         =   -1  'True
         EnableContextMenu=   -1  'True
         EnablePositionControls=   -1  'True
         EnableFullScreenControls=   0   'False
         EnableTracker   =   -1  'True
         Filename        =   ""
         InvokeURLs      =   -1  'True
         Language        =   -1
         Mute            =   0   'False
         PlayCount       =   1
         PreviewMode     =   0   'False
         Rate            =   1
         SAMILang        =   ""
         SAMIStyle       =   ""
         SAMIFileName    =   ""
         SelectionStart  =   -1
         SelectionEnd    =   -1
         SendOpenStateChangeEvents=   -1  'True
         SendWarningEvents=   -1  'True
         SendErrorEvents =   -1  'True
         SendKeyboardEvents=   0   'False
         SendMouseClickEvents=   0   'False
         SendMouseMoveEvents=   0   'False
         SendPlayStateChangeEvents=   -1  'True
         ShowCaptioning  =   0   'False
         ShowControls    =   -1  'True
         ShowAudioControls=   -1  'True
         ShowDisplay     =   0   'False
         ShowGotoBar     =   0   'False
         ShowPositionControls=   -1  'True
         ShowStatusBar   =   0   'False
         ShowTracker     =   -1  'True
         TransparentAtStart=   0   'False
         VideoBorderWidth=   0
         VideoBorderColor=   0
         VideoBorder3D   =   0   'False
         Volume          =   -600
         WindowlessVideo =   0   'False
      End
      Begin VB.Label lblTime 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000009&
         Height          =   375
         Left            =   6960
         TabIndex        =   3
         Top             =   120
         Width           =   8175
      End
      Begin VB.Image imgPicture 
         Height          =   465
         Left            =   0
         Picture         =   "MDIFrmMenu.frx":3043E
         Top             =   0
         Width           =   15360
      End
   End
   Begin VB.PictureBox picTop 
      Align           =   1  'Align Top
      Height          =   0
      Left            =   0
      ScaleHeight     =   0
      ScaleWidth      =   15180
      TabIndex        =   2
      Top             =   2415
      Width           =   15180
   End
   Begin VB.PictureBox Picture2 
      Align           =   1  'Align Top
      Height          =   0
      Left            =   0
      ScaleHeight     =   0
      ScaleWidth      =   15180
      TabIndex        =   11
      Top             =   2415
      Width           =   15180
   End
End
Attribute VB_Name = "MDIfrmMenu"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long) As Long
Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
Private Declare Function GetShortPathName Lib "kernel32" Alias "GetShortPathNameA" (ByVal lpszLongPath As String, ByVal lpszShortPath As String, ByVal cchBuffer As Long) As Long
'Declaration for the winmm dll

Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Long, ByVal uParam As Long, lpvParam As Any, ByVal fuWinIni As Long) As Long
Public mShape As Long
    Dim FileName As String
    Dim Paused As Boolean
Private Sub imgAbout_Click()
CloseAllForm
frmAbout.Show
 MediaPlayer1.FileName = App.Path + "\\about.mp3"
 MediaPlayer1.Play
 
End Sub

Private Sub ImgAdmin_Click()
CloseAllForm
frmAdmin.Show
 MediaPlayer1.FileName = App.Path + "\\admin.mp3"
 MediaPlayer1.Play
End Sub

Private Sub imgAspects_Click()
CloseAllForm
frmAspek.Show
 MediaPlayer1.FileName = App.Path + "\\album.mp3"
 MediaPlayer1.Play
End Sub

Private Sub imgLogout_Click()
    Dim askuser As Long
    askuser = MsgBox("Are you sure to logout?", vbYesNo + vbInformation, "Confirmation")
    'confirmation
    If askuser = vbYes Then

        Unload Me
        Unload frmLogin
        frmLogin.Show
        UserName = ""
        UserPassword = ""
    End If
End Sub
Private Sub imgMahasiswa_Click()
    CloseAllForm
    SearchMahasiswa.NIM = ""
    SearchMahasiswa.Nama_Akhir = ""
    SearchMahasiswa.Nama_Awal = ""
    FrmSearchMahasiswa.Show
     MediaPlayer1.FileName = App.Path + "\\member.mp3"
 MediaPlayer1.Play
End Sub



Private Sub imgOrang_Click()
CloseAllForm
frmProfil.Show
 MediaPlayer1.FileName = App.Path + "\\search.mp3"
 MediaPlayer1.Play
End Sub

Private Sub ImgPeriode_Click()
Unload FrmPeriode
FrmPeriode.Show
 MediaPlayer1.FileName = App.Path + "\\search.mp3"
 MediaPlayer1.Play
End Sub

Private Sub MDIForm_Load()
Dim lngResult As Long
lngResult = GetWindowLong(Me.hwnd, -16)
SetWindowLong Me.hwnd, -16, lngResult And Not &HC00000
lblTime.Caption = CStr(Time) + " | " + CStr(FormatDateTime(Date, vbLongDate))

Shape1.FillColor = RGB(27, 64, 166)
Shape1.BackColor = RGB(27, 64, 166)
    SearchMahasiswa.Alamat = ""
    SearchMahasiswa.Email = ""
    SearchMahasiswa.HP = ""
    SearchMahasiswa.Nama_Akhir = ""
    SearchMahasiswa.Nama_Awal = ""
    SearchMahasiswa.NIM = ""
    SearchMahasiswa.PeriodeMasuk = ""
    SearchMahasiswa.Program = ""
    SearchMahasiswa.TanggalLahir = ""
    SearchMahasiswa.Telepon = ""
    SearchMahasiswa.TempatLahir = ""
    
    CurrentMahasiswa.Alamat = ""
    CurrentMahasiswa.Email = ""
    CurrentMahasiswa.HP = ""
    CurrentMahasiswa.Nama_Akhir = ""
    CurrentMahasiswa.Nama_Awal = ""
    CurrentMahasiswa.NIM = ""
    CurrentMahasiswa.PeriodeMasuk = ""
    CurrentMahasiswa.Program = ""
    CurrentMahasiswa.TanggalLahir = ""
    CurrentMahasiswa.Telepon = ""
    CurrentMahasiswa.TempatLahir = ""
FrmPeriode.Show
FrmPeriode.CboTahun.Text = Year(Date)
If (Month(Date) >= 1 And Month(Date) <= 6) Then
    FrmPeriode.Option1.Value = True
    FrmPeriode.lblRange.Caption = "Periode : " & FrmPeriode.Option1.Caption & " " & FrmPeriode.CboTahun.Text & vbCrLf & "           " & "Januari " & FrmPeriode.CboTahun.Text & "- Juni " & FrmPeriode.CboTahun.Text

    
Else
    FrmPeriode.Option2.Value = True
    FrmPeriode.lblRange.Caption = "Periode : " & FrmPeriode.Option2.Caption & " " & FrmPeriode.CboTahun.Text & vbCrLf & "           " & "Juli " & FrmPeriode.CboTahun.Text & "- Desember " & FrmPeriode.CboTahun.Text


End If
 MediaPlayer1.FileName = App.Path + "\\spring.mp3"
 MediaPlayer1.Play

    
End Sub



Private Sub tmrTime_Timer()
   'show time and date
   lblTime.Caption = CStr(Time) + " | " + CStr(FormatDateTime(Date, vbLongDate))
End Sub
