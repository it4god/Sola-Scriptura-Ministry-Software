VERSION 5.00
Begin VB.Form frmAbout 
   Appearance      =   0  'Flat
   BackColor       =   &H00DC7F59&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "About"
   ClientHeight    =   7755
   ClientLeft      =   2340
   ClientTop       =   1935
   ClientWidth     =   11280
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   5352.638
   ScaleMode       =   0  'User
   ScaleWidth      =   10592.51
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   $"frmAbout.frx":0000
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   1410
      Left            =   600
      TabIndex        =   6
      Top             =   5880
      Width           =   4485
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   $"frmAbout.frx":00F7
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   1425
      Left            =   6120
      TabIndex        =   5
      Top             =   5760
      Width           =   4095
   End
   Begin VB.Label lblDisclaimer 
      BackStyle       =   0  'Transparent
      Caption         =   "This software is charity software and all people can download and use it freely....  Enjoy this feature of software"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   825
      Left            =   6120
      TabIndex        =   4
      Top             =   5040
      Width           =   3975
   End
   Begin VB.Image Image3 
      Height          =   1725
      Left            =   5880
      Picture         =   "frmAbout.frx":0233
      Top             =   1080
      Width           =   3735
   End
   Begin VB.Image imgLogo 
      Height          =   1800
      Left            =   480
      Picture         =   "frmAbout.frx":22C5
      Top             =   3000
      Width           =   5310
   End
   Begin VB.Label lblSubMenu 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "About Sola Scriptura Academic v1.0"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   240
      Left            =   7320
      TabIndex        =   3
      Top             =   600
      Width           =   4125
   End
   Begin VB.Image imgTitle 
      Height          =   330
      Left            =   8880
      Picture         =   "frmAbout.frx":52E6
      Top             =   240
      Width           =   1515
   End
   Begin VB.Image imgQuit 
      Height          =   645
      Left            =   10200
      Picture         =   "frmAbout.frx":5517
      Top             =   1080
      Width           =   645
   End
   Begin VB.Image imgHelp 
      Height          =   690
      Left            =   10200
      Picture         =   "frmAbout.frx":5E75
      Top             =   1800
      Width           =   645
   End
   Begin VB.Label lblDescription 
      BackStyle       =   0  'Transparent
      Caption         =   $"frmAbout.frx":68B6
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   1170
      Left            =   6090
      TabIndex        =   0
      Top             =   3960
      Width           =   4365
   End
   Begin VB.Label lblTitle 
      BackStyle       =   0  'Transparent
      Caption         =   "Sola Scriptura Academic System"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   480
      Left            =   6120
      TabIndex        =   1
      Top             =   2880
      Width           =   3885
   End
   Begin VB.Label lblVersion 
      BackStyle       =   0  'Transparent
      Caption         =   "Charity Edition - Version 1.0"
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
      Height          =   225
      Left            =   6120
      TabIndex        =   2
      Top             =   3240
      Width           =   4005
   End
   Begin VB.Image imgBg 
      Height          =   7620
      Left            =   0
      Picture         =   "frmAbout.frx":6980
      Stretch         =   -1  'True
      Top             =   120
      Width           =   11280
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
    CenterChildForm2 Me

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
