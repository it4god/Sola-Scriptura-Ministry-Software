VERSION 5.00
Begin VB.Form FrmPeriode 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00DC7F59&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Periode"
   ClientHeight    =   3570
   ClientLeft      =   -135
   ClientTop       =   330
   ClientWidth     =   10800
   FillColor       =   &H00808080&
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   3570
   ScaleWidth      =   10800
   Tag             =   "100"
   Begin VB.ComboBox CboTahun 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   6960
      Style           =   2  'Dropdown List
      TabIndex        =   0
      Top             =   1440
      Width           =   2295
   End
   Begin VB.OptionButton Option1 
      Caption         =   "Genap"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   3480
      TabIndex        =   1
      Top             =   1440
      Width           =   1935
   End
   Begin VB.OptionButton Option2 
      Caption         =   "Ganjil"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   3480
      TabIndex        =   2
      Top             =   1920
      Width           =   1935
   End
   Begin VB.Image Image2 
      BorderStyle     =   1  'Fixed Single
      Height          =   1935
      Left            =   1440
      Picture         =   "FrmPeriode.frx":0000
      Stretch         =   -1  'True
      Top             =   1320
      Width           =   1530
   End
   Begin VB.Label lblRange 
      BackStyle       =   0  'Transparent
      Caption         =   "Periode"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   615
      Left            =   5880
      TabIndex        =   5
      Top             =   1920
      Width           =   3735
   End
   Begin VB.Label lblTahun 
      BackStyle       =   0  'Transparent
      Caption         =   "Tahun :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   5880
      TabIndex        =   4
      Top             =   1440
      Width           =   1455
   End
   Begin VB.Line Line1 
      BorderColor     =   &H8000000E&
      X1              =   1320
      X2              =   9720
      Y1              =   1080
      Y2              =   1080
   End
   Begin VB.Label lblPeriode 
      BackStyle       =   0  'Transparent
      Caption         =   "Periode"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   855
      Left            =   4920
      TabIndex        =   3
      Top             =   600
      Width           =   3735
   End
   Begin VB.Image Image1 
      Height          =   3540
      Left            =   120
      Picture         =   "FrmPeriode.frx":33E0
      Stretch         =   -1  'True
      Top             =   0
      Width           =   840
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   9960
      Picture         =   "FrmPeriode.frx":645EA
      Top             =   1320
      Width           =   645
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   9960
      Picture         =   "FrmPeriode.frx":6502B
      Top             =   480
      Width           =   645
   End
   Begin VB.Image Img1 
      Height          =   3540
      Left            =   960
      Picture         =   "FrmPeriode.frx":65989
      Stretch         =   -1  'True
      Top             =   0
      Width           =   9840
   End
End
Attribute VB_Name = "FrmPeriode"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False





Private Sub CboTahun_Click()
    If Option1.Value = True Then
        Periode = Trim(CInt(Trim(CboTahun.Text)) - 1) + Trim(CboTahun.Text) + ".2"
        strperiode = Option1.Caption & " " & CboTahun.Text
        lblRange.Caption = "Periode : " & Option1.Caption & " " & CboTahun.Text & vbCrLf & "           " & "Januari " & CboTahun.Text & "- Juni " & CboTahun.Text
    Else
        Periode = Trim(CboTahun.Text) + Trim(CInt(Trim(CboTahun.Text)) + 1) + ".1"
        strperiode = Option2.Caption & " " & CboTahun.Text
        lblRange.Caption = "Periode : " & Option2.Caption & " " & CboTahun.Text & vbCrLf & "           " & "Juli " & CboTahun.Text & "- Desember " & CboTahun.Text
    End If


    
End Sub

Private Sub Form_Load()
CenterChildForm2 Me
Option1.BackColor = RGB(27, 64, 166)
Option2.BackColor = RGB(27, 64, 166)
CboTahun.Clear
Dim x As Integer
For x = 1998 To 2200
    CboTahun.AddItem (x)
Next x

If Right(Periode, 1) = "1" Then
    CboTahun.Text = Mid(Periode, 1, 4)
    Option2.Value = True
ElseIf Right(Periode, 1) = "2" Then
    CboTahun.Text = Mid(Periode, 5, 4)
    Option1.Value = True
Else
    CboTahun.Text = Year(Date)
End If


    If Option1.Value = True Then
        Periode = Trim(CInt(Trim(CboTahun.Text)) - 1) + Trim(CboTahun.Text) + ".2"
        strperiode = Option1.Caption & " " & CboTahun.Text
        lblRange.Caption = "Periode : " & Option1.Caption & " " & CboTahun.Text & vbCrLf & "           " & "Januari " & CboTahun.Text & "- Juni " & CboTahun.Text
    Else
        Periode = Trim(CboTahun.Text) + Trim(CInt(Trim(CboTahun.Text)) + 1) + ".1"
        strperiode = Option2.Caption & " " & CboTahun.Text
        lblRange.Caption = "Periode : " & Option2.Caption & " " & CboTahun.Text & vbCrLf & "           " & "Juli " & CboTahun.Text & "- Desember " & CboTahun.Text
    End If

End Sub










Private Sub imgQuit_Click()
Unload Me
End Sub
Private Sub Form_Unload(Cancel As Integer)
  Dim xxcounter As Long
  Dim i As Long
  xxcounter = Me.Height
'Collapse Form
  Do: DoEvents
    If xxcounter > 500 Then
        xxcounter = xxcounter - 200
    Else
        xxcounter = xxcounter - 35
    End If
    Me.Height = Abs(xxcounter)
    Me.Top = (Screen.Height - Me.Height) / 2
  Loop Until xxcounter <= 10
  i = 15
  xxcounter = Me.Width
'Strech form to edges
  Do: DoEvents
    xxcounter = xxcounter + i
    Me.Width = Abs(xxcounter)
    Me.Left = (Screen.Width - Me.Width) / 2
    i = i + 5
  Loop Until xxcounter >= Screen.Width
End Sub

Private Sub Option1_Click()
    If Option1.Value = True Then
        Periode = Trim(CInt(Trim(CboTahun.Text)) - 1) + Trim(CboTahun.Text) + ".2"
        strperiode = Option1.Caption & " " & CboTahun.Text
        lblRange.Caption = "Periode : " & Option1.Caption & " " & CboTahun.Text & vbCrLf & "           " & "Januari " & CboTahun.Text & "- Juni " & CboTahun.Text
    Else
        Periode = Trim(CboTahun.Text) + Trim(CInt(Trim(CboTahun.Text)) + 1) + ".1"
        strperiode = Option2.Caption & " " & CboTahun.Text
        lblRange.Caption = "Periode : " & Option2.Caption & " " & CboTahun.Text & vbCrLf & "           " & "Juli " & CboTahun.Text & "- Desember " & CboTahun.Text
    End If


End Sub

Private Sub Option2_Click()
    If Option1.Value = True Then
        Periode = Trim(CInt(Trim(CboTahun.Text)) - 1) + Trim(CboTahun.Text) + ".2"
        strperiode = Option1.Caption & " " & CboTahun.Text
        lblRange.Caption = "Periode : " & Option1.Caption & " " & CboTahun.Text & vbCrLf & "           " & "Januari " & CboTahun.Text & "- Juni " & CboTahun.Text
    Else
        Periode = Trim(CboTahun.Text) + Trim(CInt(Trim(CboTahun.Text)) + 1) + ".1"
        strperiode = Option2.Caption & " " & CboTahun.Text
        lblRange.Caption = "Periode : " & Option2.Caption & " " & CboTahun.Text & vbCrLf & "           " & "Juli " & CboTahun.Text & "- Desember " & CboTahun.Text
    End If


    
End Sub
