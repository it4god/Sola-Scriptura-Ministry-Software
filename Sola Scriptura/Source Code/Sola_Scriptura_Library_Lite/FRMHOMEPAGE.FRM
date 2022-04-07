VERSION 5.00
Object = "{EAB22AC0-30C1-11CF-A7EB-0000C05BAE0B}#1.1#0"; "SHDOCVW.DLL"
Begin VB.Form FrmHomePage 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Home Page"
   ClientHeight    =   8280
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   11505
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   8280
   ScaleWidth      =   11505
   Tag             =   "0"
   Begin VB.CommandButton Command1 
      Caption         =   "X"
      Height          =   375
      Left            =   11040
      TabIndex        =   1
      Top             =   240
      Width           =   375
   End
   Begin SHDocVwCtl.WebBrowser WebBrowser1 
      Height          =   7695
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   10695
      ExtentX         =   18865
      ExtentY         =   13573
      ViewMode        =   0
      Offline         =   0
      Silent          =   0
      RegisterAsBrowser=   0
      RegisterAsDropTarget=   1
      AutoArrange     =   0   'False
      NoClientEdge    =   0   'False
      AlignLeft       =   0   'False
      NoWebView       =   0   'False
      HideFileNames   =   0   'False
      SingleClick     =   0   'False
      SingleSelection =   0   'False
      NoFolders       =   0   'False
      Transparent     =   0   'False
      ViewID          =   "{0057D0E0-3573-11CF-AE69-08002B2E1262}"
      Location        =   "http:///"
   End
End
Attribute VB_Name = "FrmHomePage"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim withFrameFlag As Boolean
Dim mFormRegion As Long


Private Sub Command1_Click()
Unload Me
End Sub

Private Sub Form_Load()
    WebBrowser1.Navigate2 ("c:\ipcweb\default.html")
    Me.ScaleMode = vbPixels
    withFrameFlag = False
    toggleFrame withFrameFlag
End Sub

    
Private Sub toggleFrame(inFlag As Boolean)
    Dim w As Single, h As Single
    Dim edge As Single, topEdge As Single
    Dim mLeft, mTop
    Dim i As Integer
    Dim r As Long
    Dim outer As Long, inner As Long
    
    mFormRegion = CreateRectRgn(0, 0, 0, 0)
       ' Put width/height in same denomination of scalewidth/scaleheight
    w = ScaleX(Width, vbTwips, vbPixels)
    h = ScaleY(Height, vbTwips, vbPixels)
       ' Frame edges measurement
    edge = (w - ScaleWidth) / 2
    topEdge = h - edge - ScaleHeight
       ' Get frame
    If inFlag Then
        outer = CreateRectRgn(0, 0, w, h)
        inner = CreateRectRgn(edge, topEdge, w - edge, h - edge)
        CombineRgn mFormRegion, outer, inner, RGN_DIFF
    End If
       ' Combine regions of controls on form
    For i = 0 To Me.Controls.Count - 1
        mLeft = ScaleX(Me.Controls(i).Left, Me.ScaleMode, vbPixels) + edge
        mTop = ScaleX(Me.Controls(i).Top, Me.ScaleMode, vbPixels) + topEdge
        r = CreateRectRgn(mLeft, mTop, _
             ScaleX((Me.Controls(i).Width), Me.ScaleMode, vbPixels) + mLeft, _
             ScaleY((Me.Controls(i).Height), Me.ScaleMode, vbPixels) + mTop)
        CombineRgn mFormRegion, r, mFormRegion, RGN_OR
    Next
      


       ' We allow toggle
    SetWindowRgn hwnd, mFormRegion, True
End Sub




Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    SetWindowRgn hwnd, 0, False
    DeleteObject mFormRegion
End Sub


' Unlike frmShapedForm, since frmTransparent is transparent, we have to
' provide a place for user to drag if without frame, so Command0 is used.
Private Sub Command0_MouseDown(Button As Integer, Shift As Integer, x As Single, Y As Single)
    If Button <> vbLeftButton Then
         Exit Sub
    End If
    ReleaseCapture
    SendMessage Me.hwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
End Sub

