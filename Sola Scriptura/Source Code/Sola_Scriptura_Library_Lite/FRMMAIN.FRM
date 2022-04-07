VERSION 5.00
Begin VB.Form FrmMain 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   ClientHeight    =   11115
   ClientLeft      =   165
   ClientTop       =   450
   ClientWidth     =   15240
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   ScaleHeight     =   11115
   ScaleWidth      =   15240
   StartUpPosition =   3  'Windows Default
   Tag             =   "0"
   WindowState     =   2  'Maximized
   Begin VB.Image Image1 
      Height          =   11175
      Left            =   0
      Top             =   0
      Width           =   15255
   End
   Begin VB.Menu Function 
      Caption         =   "&Function"
   End
   Begin VB.Menu Borrowers 
      Caption         =   "&Borrowers"
      Begin VB.Menu AddOrModifyBorrowers 
         Caption         =   "&Add / Modify"
      End
      Begin VB.Menu List 
         Caption         =   "&List"
      End
      Begin VB.Menu The_Line1 
         Caption         =   "-"
      End
      Begin VB.Menu History 
         Caption         =   "&History"
      End
   End
   Begin VB.Menu AddOrModifyDatabase 
      Caption         =   "Add / Modify Database"
      Begin VB.Menu AddOrModifyBooks 
         Caption         =   "&Books"
      End
      Begin VB.Menu AddOrModifyCassettes 
         Caption         =   "&Cassettes"
      End
      Begin VB.Menu AddOrModifyCDs 
         Caption         =   "&CDs"
      End
      Begin VB.Menu AddOrModifyVideos 
         Caption         =   "&Videos"
      End
   End
   Begin VB.Menu View 
      Caption         =   "&View"
      Begin VB.Menu ViewBooks 
         Caption         =   "&Books"
      End
      Begin VB.Menu ViewCassettes 
         Caption         =   "&Cassettes"
      End
      Begin VB.Menu ViewCDs 
         Caption         =   "&CDs"
      End
      Begin VB.Menu ViewVideos 
         Caption         =   "&Videos"
      End
      Begin VB.Menu The_Line2 
         Caption         =   "-"
      End
      Begin VB.Menu Booked 
         Caption         =   "&Booked"
         Begin VB.Menu BookedAll 
            Caption         =   "&All"
         End
         Begin VB.Menu The_Line3 
            Caption         =   "-"
         End
         Begin VB.Menu BookedBooks 
            Caption         =   "&Books"
         End
         Begin VB.Menu BookedCassettes 
            Caption         =   "&Cassettes"
         End
         Begin VB.Menu BookedCDs 
            Caption         =   "&CDs"
         End
         Begin VB.Menu BookedVideos 
            Caption         =   "&Videos"
         End
      End
      Begin VB.Menu Unreturned 
         Caption         =   "&Unreturned"
         Begin VB.Menu UnreturnedAll 
            Caption         =   "&All"
         End
         Begin VB.Menu The_Line4 
            Caption         =   "-"
         End
         Begin VB.Menu UnreturnBooks 
            Caption         =   "&Books"
         End
         Begin VB.Menu UnreturnCassettes 
            Caption         =   "&Cassettes"
         End
         Begin VB.Menu UnreturnedCDs 
            Caption         =   "&CDs"
         End
         Begin VB.Menu UnreturnedVideos 
            Caption         =   "&Videos"
         End
      End
   End
   Begin VB.Menu LogOff 
      Caption         =   "&Log Off"
   End
End
Attribute VB_Name = "FrmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub AddOrModifyBooks_Click()
FrmAddOrModifyBooks.Show
FrmAddOrModifyBooks.Tag = 1
skin
End Sub

Private Sub AddOrModifyBorrowers_Click()
FrmAddOrModifyBorrowers.Show
FrmAddOrModifyBorrowers.Tag = 1
skin
End Sub

Private Sub AddOrModifyCassettes_Click()
FrmAddOrModifyCassettes.Show
FrmAddOrModifyCassettes.Tag = 1
skin
End Sub

Private Sub AddOrModifyCDs_Click()
FrmAddOrModifyCDs.Show
FrmAddOrModifyCDs.Tag = 1
skin
End Sub

Private Sub AddOrModifyVideos_Click()
FrmAddOrModifyVideos.Show
FrmAddOrModifyVideos.Tag = 1
skin
End Sub

Private Sub BookedAll_Click()
FrmViewBookedAll.Show
FrmViewBookedAll.Tag = 1
skin
End Sub

Private Sub Function_Click()
FrmFunction.Show
FrmFunction.Tag = 1
skin
End Sub
Private Sub ViewBooks_Click()
FrmViewBooks.Show
FrmViewBooks.Tag = 1
skin
End Sub
