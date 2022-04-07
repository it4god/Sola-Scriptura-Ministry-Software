VERSION 5.00
Object = "{AD224A25-CA55-11D2-8C26-444553540001}#2.1#0"; "SWBGRADIENT.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form FrmFunction 
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   8310
   ClientLeft      =   -135
   ClientTop       =   330
   ClientWidth     =   11355
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   8310
   ScaleWidth      =   11355
   Tag             =   "0"
   Begin TabDlg.SSTab SSTab1 
      Height          =   6975
      Left            =   240
      TabIndex        =   5
      Top             =   1080
      Width           =   10935
      _ExtentX        =   19288
      _ExtentY        =   12303
      _Version        =   393216
      TabHeight       =   520
      TabCaption(0)   =   "Current Borrowings"
      TabPicture(0)   =   "FrmFunction.frx":0000
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "LblLendingDetails"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "LblAdodc2"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).Control(2)=   "LblAdodc3"
      Tab(0).Control(2).Enabled=   0   'False
      Tab(0).Control(3)=   "DataGrid2"
      Tab(0).Control(3).Enabled=   0   'False
      Tab(0).Control(4)=   "Adodc4"
      Tab(0).Control(4).Enabled=   0   'False
      Tab(0).Control(5)=   "Adodc1"
      Tab(0).Control(5).Enabled=   0   'False
      Tab(0).Control(6)=   "Adodc2"
      Tab(0).Control(6).Enabled=   0   'False
      Tab(0).Control(7)=   "Adodc3"
      Tab(0).Control(7).Enabled=   0   'False
      Tab(0).Control(8)=   "DataGrid1"
      Tab(0).Control(8).Enabled=   0   'False
      Tab(0).Control(9)=   "CmdReturn"
      Tab(0).Control(9).Enabled=   0   'False
      Tab(0).Control(10)=   "CmdExtend"
      Tab(0).Control(10).Enabled=   0   'False
      Tab(0).Control(11)=   "CmdAdd"
      Tab(0).Control(11).Enabled=   0   'False
      Tab(0).Control(12)=   "CmdRenew"
      Tab(0).Control(12).Enabled=   0   'False
      Tab(0).Control(13)=   "Frame1"
      Tab(0).Control(13).Enabled=   0   'False
      Tab(0).Control(14)=   "Frame2"
      Tab(0).Control(14).Enabled=   0   'False
      Tab(0).ControlCount=   15
      TabCaption(1)   =   "History"
      TabPicture(1)   =   "FrmFunction.frx":001C
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "Frame3"
      Tab(1).Control(1)=   "DataGrid3"
      Tab(1).Control(2)=   "Adodc5"
      Tab(1).Control(3)=   "Label1"
      Tab(1).ControlCount=   4
      TabCaption(2)   =   "Credits"
      TabPicture(2)   =   "FrmFunction.frx":0038
      Tab(2).ControlEnabled=   0   'False
      Tab(2).Control(0)=   "Label11"
      Tab(2).Control(1)=   "DataGrid5"
      Tab(2).Control(2)=   "Adodc7"
      Tab(2).Control(3)=   "Adodc6"
      Tab(2).Control(4)=   "DataGrid4"
      Tab(2).Control(5)=   "CmdPay"
      Tab(2).Control(6)=   "Frame4"
      Tab(2).ControlCount=   7
      Begin VB.Frame Frame4 
         Caption         =   "Unpaid Borrowings"
         Height          =   1935
         Left            =   -66600
         TabIndex        =   35
         Top             =   720
         Width           =   2415
         Begin VB.Label Label3 
            Caption         =   "$"
            Height          =   255
            Left            =   1200
            TabIndex        =   46
            Top             =   1200
            Width           =   255
         End
         Begin VB.Label LblTotalC 
            Caption         =   "Total Credits  :"
            Height          =   255
            Index           =   1
            Left            =   120
            TabIndex        =   39
            Top             =   1200
            Width           =   1215
         End
         Begin VB.Label LblUnpaidI 
            Caption         =   "Unpaid Items :"
            Height          =   255
            Index           =   1
            Left            =   120
            TabIndex        =   38
            Top             =   480
            Width           =   1215
         End
         Begin VB.Label LblUnpaidItems 
            BorderStyle     =   1  'Fixed Single
            Height          =   495
            Index           =   1
            Left            =   1440
            TabIndex        =   37
            Top             =   360
            Width           =   735
         End
         Begin VB.Label LblTotalCredits 
            BorderStyle     =   1  'Fixed Single
            Height          =   495
            Index           =   1
            Left            =   1440
            TabIndex        =   36
            Top             =   1080
            Width           =   735
         End
      End
      Begin VB.CommandButton CmdPay 
         Caption         =   "&Pay"
         Height          =   375
         Left            =   -74520
         TabIndex        =   28
         Top             =   6240
         Width           =   735
      End
      Begin VB.Frame Frame3 
         Caption         =   "History of Borrow"
         Height          =   3255
         Left            =   -66600
         TabIndex        =   22
         Top             =   720
         Width           =   2415
         Begin VB.Line Line1 
            X1              =   120
            X2              =   2280
            Y1              =   960
            Y2              =   960
         End
         Begin VB.Label LblTVideos 
            BorderStyle     =   1  'Fixed Single
            Height          =   375
            Left            =   1320
            TabIndex        =   44
            Top             =   2520
            Width           =   975
         End
         Begin VB.Label LblTCDs 
            BorderStyle     =   1  'Fixed Single
            Height          =   375
            Left            =   1320
            TabIndex        =   43
            Top             =   2040
            Width           =   975
         End
         Begin VB.Label LblTCassettes 
            BorderStyle     =   1  'Fixed Single
            Height          =   375
            Left            =   1320
            TabIndex        =   42
            Top             =   1560
            Width           =   975
         End
         Begin VB.Label LblTBooks 
            BorderStyle     =   1  'Fixed Single
            Height          =   375
            Left            =   1320
            TabIndex        =   41
            Top             =   1080
            Width           =   975
         End
         Begin VB.Label lblTotalItems 
            BorderStyle     =   1  'Fixed Single
            Height          =   375
            Left            =   1320
            TabIndex        =   40
            Top             =   360
            Width           =   975
         End
         Begin VB.Label LblVideos 
            Caption         =   "Videos :"
            Height          =   375
            Left            =   120
            TabIndex        =   27
            Top             =   2640
            Width           =   855
         End
         Begin VB.Label LblCDs 
            Caption         =   "CDs :"
            Height          =   375
            Left            =   120
            TabIndex        =   26
            Top             =   2160
            Width           =   855
         End
         Begin VB.Label LblCassettes 
            Caption         =   "Cassettes :"
            Height          =   375
            Left            =   120
            TabIndex        =   25
            Top             =   1680
            Width           =   975
         End
         Begin VB.Label LblBooks 
            Caption         =   "Books:"
            Height          =   375
            Left            =   120
            TabIndex        =   24
            Top             =   1200
            Width           =   855
         End
         Begin VB.Label LblTotalI 
            Caption         =   "Total Items :"
            Height          =   375
            Left            =   120
            TabIndex        =   23
            Top             =   480
            Width           =   975
         End
      End
      Begin VB.Frame Frame2 
         Caption         =   "Unpaid Borrowings"
         Height          =   1935
         Left            =   8400
         TabIndex        =   19
         Top             =   2760
         Width           =   2415
         Begin VB.Label Label2 
            Caption         =   "$"
            Height          =   255
            Left            =   1200
            TabIndex        =   47
            Top             =   1200
            Width           =   255
         End
         Begin VB.Label LblTotalCredits 
            BorderStyle     =   1  'Fixed Single
            Height          =   495
            Index           =   0
            Left            =   1440
            TabIndex        =   34
            Top             =   1080
            Width           =   735
         End
         Begin VB.Label LblUnpaidItems 
            BorderStyle     =   1  'Fixed Single
            Height          =   495
            Index           =   0
            Left            =   1440
            TabIndex        =   33
            Top             =   360
            Width           =   735
         End
         Begin VB.Label LblUnpaidI 
            Caption         =   "Unpaid Items :"
            Height          =   255
            Index           =   0
            Left            =   120
            TabIndex        =   21
            Top             =   480
            Width           =   1215
         End
         Begin VB.Label LblTotalC 
            Caption         =   "Total Credits  :"
            Height          =   255
            Index           =   0
            Left            =   120
            TabIndex        =   20
            Top             =   1200
            Width           =   1215
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "Current Borrowings"
         Height          =   1935
         Left            =   8400
         TabIndex        =   16
         Top             =   720
         Width           =   2415
         Begin VB.Label Label4 
            Caption         =   "$"
            Height          =   255
            Left            =   1200
            TabIndex        =   48
            Top             =   1200
            Width           =   255
         End
         Begin VB.Label LblTotalFine 
            BorderStyle     =   1  'Fixed Single
            Height          =   495
            Left            =   1440
            TabIndex        =   32
            Top             =   1080
            Width           =   735
         End
         Begin VB.Label LblUnreturnItems 
            BorderStyle     =   1  'Fixed Single
            Height          =   495
            Left            =   1440
            TabIndex        =   31
            Top             =   360
            Width           =   735
         End
         Begin VB.Label LblTF 
            Caption         =   "Total Fine       :"
            Height          =   495
            Left            =   120
            TabIndex        =   18
            Top             =   1200
            Width           =   1215
         End
         Begin VB.Label LblUnreturnI 
            Caption         =   "Unreturn Items :"
            Height          =   375
            Left            =   120
            TabIndex        =   17
            Top             =   480
            Width           =   1335
         End
      End
      Begin VB.CommandButton CmdRenew 
         Caption         =   "&Renew"
         Height          =   375
         Left            =   3360
         TabIndex        =   15
         Top             =   6240
         Width           =   735
      End
      Begin VB.CommandButton CmdAdd 
         Caption         =   "&Add"
         Height          =   375
         Left            =   480
         TabIndex        =   9
         Top             =   6240
         Width           =   735
      End
      Begin VB.CommandButton CmdExtend 
         Caption         =   "&Extend"
         Height          =   375
         Left            =   1440
         TabIndex        =   8
         Top             =   6240
         Width           =   735
      End
      Begin VB.CommandButton CmdReturn 
         Caption         =   "&Return"
         Height          =   375
         Left            =   2400
         TabIndex        =   7
         Top             =   6240
         Width           =   735
      End
      Begin MSDataGridLib.DataGrid DataGrid1 
         Bindings        =   "FrmFunction.frx":0054
         Height          =   5175
         Left            =   360
         TabIndex        =   6
         Top             =   840
         Width           =   7695
         _ExtentX        =   13573
         _ExtentY        =   9128
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
      Begin MSAdodcLib.Adodc Adodc3 
         Height          =   495
         Left            =   840
         Top             =   1800
         Visible         =   0   'False
         Width           =   2400
         _ExtentX        =   4233
         _ExtentY        =   873
         ConnectMode     =   0
         CursorLocation  =   3
         IsolationLevel  =   -1
         ConnectionTimeout=   15
         CommandTimeout  =   30
         CursorType      =   3
         LockType        =   3
         CommandType     =   1
         CursorOptions   =   0
         CacheSize       =   50
         MaxRecords      =   0
         BOFAction       =   0
         EOFAction       =   0
         ConnectStringType=   1
         Appearance      =   1
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         Orientation     =   0
         Enabled         =   -1
         Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBFile       =   ""
         DataSourceName  =   ""
         OtherAttributes =   ""
         UserName        =   ""
         Password        =   ""
         RecordSource    =   "Select * From Books"
         Caption         =   "Borrowing"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _Version        =   393216
      End
      Begin MSAdodcLib.Adodc Adodc2 
         Height          =   495
         Left            =   840
         Top             =   1200
         Visible         =   0   'False
         Width           =   3600
         _ExtentX        =   6350
         _ExtentY        =   873
         ConnectMode     =   0
         CursorLocation  =   3
         IsolationLevel  =   -1
         ConnectionTimeout=   15
         CommandTimeout  =   30
         CursorType      =   3
         LockType        =   3
         CommandType     =   1
         CursorOptions   =   0
         CacheSize       =   50
         MaxRecords      =   0
         BOFAction       =   0
         EOFAction       =   0
         ConnectStringType=   1
         Appearance      =   1
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         Orientation     =   0
         Enabled         =   -1
         Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBFile       =   ""
         DataSourceName  =   ""
         OtherAttributes =   ""
         UserName        =   ""
         Password        =   ""
         RecordSource    =   "Select * From Books"
         Caption         =   "For Checking Books Availibility"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _Version        =   393216
      End
      Begin MSAdodcLib.Adodc Adodc1 
         Height          =   495
         Left            =   5520
         Top             =   1200
         Visible         =   0   'False
         Width           =   2040
         _ExtentX        =   3598
         _ExtentY        =   873
         ConnectMode     =   0
         CursorLocation  =   3
         IsolationLevel  =   -1
         ConnectionTimeout=   15
         CommandTimeout  =   30
         CursorType      =   3
         LockType        =   3
         CommandType     =   1
         CursorOptions   =   0
         CacheSize       =   50
         MaxRecords      =   0
         BOFAction       =   0
         EOFAction       =   0
         ConnectStringType=   1
         Appearance      =   1
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         Orientation     =   0
         Enabled         =   -1
         Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBFile       =   ""
         DataSourceName  =   ""
         OtherAttributes =   ""
         UserName        =   ""
         Password        =   ""
         RecordSource    =   "Select * From Books"
         Caption         =   "Adodc1"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _Version        =   393216
      End
      Begin MSAdodcLib.Adodc Adodc4 
         Height          =   495
         Left            =   3960
         Top             =   1800
         Visible         =   0   'False
         Width           =   2280
         _ExtentX        =   4022
         _ExtentY        =   873
         ConnectMode     =   0
         CursorLocation  =   3
         IsolationLevel  =   -1
         ConnectionTimeout=   15
         CommandTimeout  =   30
         CursorType      =   3
         LockType        =   3
         CommandType     =   1
         CursorOptions   =   0
         CacheSize       =   50
         MaxRecords      =   0
         BOFAction       =   0
         EOFAction       =   0
         ConnectStringType=   1
         Appearance      =   1
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         Orientation     =   0
         Enabled         =   -1
         Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBFile       =   ""
         DataSourceName  =   ""
         OtherAttributes =   ""
         UserName        =   ""
         Password        =   ""
         RecordSource    =   "Select * From Books"
         Caption         =   "For Datagrid"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _Version        =   393216
      End
      Begin MSDataGridLib.DataGrid DataGrid2 
         Bindings        =   "FrmFunction.frx":0069
         Height          =   495
         Left            =   6480
         TabIndex        =   12
         Top             =   1800
         Width           =   1215
         _ExtentX        =   2143
         _ExtentY        =   873
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
      Begin MSDataGridLib.DataGrid DataGrid3 
         Bindings        =   "FrmFunction.frx":007E
         Height          =   5655
         Left            =   -74640
         TabIndex        =   13
         Top             =   840
         Width           =   7935
         _ExtentX        =   13996
         _ExtentY        =   9975
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
      Begin MSAdodcLib.Adodc Adodc5 
         Height          =   495
         Left            =   -74640
         Top             =   3840
         Visible         =   0   'False
         Width           =   2880
         _ExtentX        =   5080
         _ExtentY        =   873
         ConnectMode     =   0
         CursorLocation  =   3
         IsolationLevel  =   -1
         ConnectionTimeout=   15
         CommandTimeout  =   30
         CursorType      =   3
         LockType        =   3
         CommandType     =   1
         CursorOptions   =   0
         CacheSize       =   50
         MaxRecords      =   0
         BOFAction       =   0
         EOFAction       =   0
         ConnectStringType=   1
         Appearance      =   1
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         Orientation     =   0
         Enabled         =   -1
         Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBFile       =   ""
         DataSourceName  =   ""
         OtherAttributes =   ""
         UserName        =   ""
         Password        =   ""
         RecordSource    =   "Select * From Books"
         Caption         =   "For History List"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _Version        =   393216
      End
      Begin MSDataGridLib.DataGrid DataGrid4 
         Bindings        =   "FrmFunction.frx":0093
         Height          =   5175
         Left            =   -74640
         TabIndex        =   29
         Top             =   840
         Width           =   7935
         _ExtentX        =   13996
         _ExtentY        =   9128
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
      Begin MSAdodcLib.Adodc Adodc6 
         Height          =   495
         Left            =   -74640
         Top             =   1200
         Width           =   2415
         _ExtentX        =   4260
         _ExtentY        =   873
         ConnectMode     =   0
         CursorLocation  =   3
         IsolationLevel  =   -1
         ConnectionTimeout=   15
         CommandTimeout  =   30
         CursorType      =   3
         LockType        =   3
         CommandType     =   1
         CursorOptions   =   0
         CacheSize       =   50
         MaxRecords      =   0
         BOFAction       =   0
         EOFAction       =   0
         ConnectStringType=   1
         Appearance      =   1
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         Orientation     =   0
         Enabled         =   -1
         Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBFile       =   ""
         DataSourceName  =   ""
         OtherAttributes =   ""
         UserName        =   ""
         Password        =   ""
         RecordSource    =   "SELECT * From Books"
         Caption         =   "For the Frame"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _Version        =   393216
      End
      Begin MSAdodcLib.Adodc Adodc7 
         Height          =   495
         Left            =   -74640
         Top             =   2040
         Width           =   2415
         _ExtentX        =   4260
         _ExtentY        =   873
         ConnectMode     =   0
         CursorLocation  =   3
         IsolationLevel  =   -1
         ConnectionTimeout=   15
         CommandTimeout  =   30
         CursorType      =   3
         LockType        =   3
         CommandType     =   1
         CursorOptions   =   0
         CacheSize       =   50
         MaxRecords      =   0
         BOFAction       =   0
         EOFAction       =   0
         ConnectStringType=   1
         Appearance      =   1
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         Orientation     =   0
         Enabled         =   -1
         Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Sola_Scriptura_Library_Lite\webcatalogue.mdb;Persist Security Info=False"
         OLEDBFile       =   ""
         DataSourceName  =   ""
         OtherAttributes =   ""
         UserName        =   ""
         Password        =   ""
         RecordSource    =   "SELECT * From Books"
         Caption         =   "For the Frame"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _Version        =   393216
      End
      Begin MSDataGridLib.DataGrid DataGrid5 
         Bindings        =   "FrmFunction.frx":00A8
         Height          =   735
         Left            =   -71160
         TabIndex        =   49
         Top             =   2040
         Width           =   3615
         _ExtentX        =   6376
         _ExtentY        =   1296
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
      Begin VB.Label LblAdodc3 
         Caption         =   "Adodc3"
         DataField       =   "Title"
         DataSource      =   "Adodc3"
         Height          =   375
         Left            =   3360
         TabIndex        =   45
         Top             =   1920
         Width           =   615
      End
      Begin VB.Label Label11 
         BackColor       =   &H80000009&
         BackStyle       =   0  'Transparent
         Caption         =   "List of Unpaid Borrowings :"
         BeginProperty Font 
            Name            =   "Trebuchet MS"
            Size            =   9
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   -72120
         TabIndex        =   30
         Top             =   480
         Width           =   2295
      End
      Begin VB.Label Label1 
         BackColor       =   &H80000009&
         BackStyle       =   0  'Transparent
         Caption         =   "History of borrowing :"
         BeginProperty Font 
            Name            =   "Trebuchet MS"
            Size            =   9
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   -72120
         TabIndex        =   14
         Top             =   480
         Width           =   2295
      End
      Begin VB.Label LblAdodc2 
         BackColor       =   &H80000009&
         BackStyle       =   0  'Transparent
         Caption         =   "Adodc2"
         DataField       =   "Title"
         DataSource      =   "Adodc2"
         Height          =   375
         Left            =   4680
         TabIndex        =   11
         Top             =   1320
         Visible         =   0   'False
         Width           =   1455
      End
      Begin VB.Label LblLendingDetails 
         BackColor       =   &H80000009&
         BackStyle       =   0  'Transparent
         Caption         =   "List of borrowing :"
         BeginProperty Font 
            Name            =   "Trebuchet MS"
            Size            =   9
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   2880
         TabIndex        =   10
         Top             =   480
         Width           =   2295
      End
   End
   Begin SWBGradientCtl.SWBGradient SWBGradient1 
      Left            =   0
      Top             =   0
      _ExtentX        =   423
      _ExtentY        =   423
      StartColor      =   12632256
      EndColor        =   16777215
      Orientation     =   2
   End
   Begin VB.Label LblLastName 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   5640
      TabIndex        =   4
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label LblFirstName 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   3840
      TabIndex        =   3
      Top             =   120
      Width           =   1695
   End
   Begin VB.Label LblBorrowerID 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "BorrowerID :"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   360
      TabIndex        =   2
      Top             =   120
      Width           =   1215
   End
   Begin VB.Label LblFName 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      Caption         =   "Name  :"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   2760
      TabIndex        =   1
      Top             =   120
      Width           =   975
   End
   Begin VB.Label LblID 
      BackColor       =   &H80000009&
      BackStyle       =   0  'Transparent
      DataField       =   "BorrowerID"
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   1440
      TabIndex        =   0
      Top             =   120
      Width           =   1215
   End
   Begin VB.Image Image1 
      Height          =   8250
      Left            =   0
      Picture         =   "FrmFunction.frx":00BD
      Stretch         =   -1  'True
      Top             =   0
      Width           =   11415
   End
End
Attribute VB_Name = "FrmFunction"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim strSQL As String
Dim saskuser As String
Dim iresponse As Integer
Dim BorrowingID As String
Dim bookmarks As Variant
Dim strSQL2 As String
Dim strSQL3 As String
Dim TotalItem As Integer
Dim TotalFine As Currency
Dim unreturnItem As Integer
Dim TotalCredits As Currency
Dim totalUnpaid As Integer
Dim books As Integer
Dim cassettes As Integer
Dim cds As Integer
Dim videos As Integer
    



Private Sub CmdAdd_Click()
iresponse = vbYes
While iresponse = vbYes
BorrowingID = InputBox$("Please Enter the borrowing ID")
If Mid(BorrowingID, 1, 1) = "B" Then
    Adodc2.RecordSource = "SELECT * From Books WHERE ItemNo = '" & BorrowingID & "'"
    Adodc2.Refresh
    If Adodc2.Recordset.EOF Then
        MsgBox "Borrow not successful", vbInformation, "ItemNo not found"
        Exit Sub
    Else
        Call CheckData(BorrowingID, 1, Adodc2.Recordset.Fields(9))
    End If
ElseIf Mid(BorrowingID, 1, 1) = "K" Then
       
    Adodc2.RecordSource = "SELECT * From Cassettes WHERE ItemNo = '" & BorrowingID & "'"
    Adodc2.Refresh
    If Adodc2.Recordset.EOF Then
        MsgBox "Borrow not successful", vbInformation, "ItemNo not found"
        Exit Sub
    Else
        Call CheckData(BorrowingID, 2, Adodc2.Recordset.Fields(9))
    End If
   
ElseIf Mid(BorrowingID, 1, 1) = "C" Then
    Adodc2.RecordSource = "SELECT * From CDs WHERE ItemNo = '" & BorrowingID & "'"
    Adodc2.Refresh
    If Adodc2.Recordset.EOF Then
        MsgBox "Borrow not successful", vbInformation, "ItemNo not found"
        Exit Sub
    Else
        Call CheckData(BorrowingID, 3, Adodc2.Recordset.Fields(9))
    End If
    
ElseIf Mid(BorrowingID, 1, 1) = "V" Then
    Adodc2.RecordSource = "SELECT * From Videos WHERE ItemNo = '" & BorrowingID & "'"
    Adodc2.Refresh
    If Adodc2.Recordset.EOF Then
        MsgBox "Borrow not successful", vbInformation, "ItemNo not found"
        Exit Sub
    Else
        Call CheckData(BorrowingID, 4, Adodc2.Recordset.Fields(9))
    End If
Else
    MsgBox "The BorrowingID is not valid ID", vbInformation, "Error"
    Exit Sub
End If
saskuser = "Do " & CurrentBorrower.FName & " want to borrow again ?"
iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Add again")
Wend

DoingRefresh

End Sub

Private Sub CheckData(BorrowingID As String, BorrowingName As Integer, AvailID As String)
If AvailID = "0" Then
    saskuser = "Status Item is under Borrowing" & Chr(13) & "Do you want to force ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Confirm")
    If iresponse = vbYes Then
         Call SaveData(BorrowingID, BorrowingName)
    Else
        MsgBox "Borrow not successful", vbInformation, "Information"
    End If
ElseIf AvailID = "B" Or AvailID = "E" Then
    saskuser = "Status Item is not available" & Chr(13) & "Do you want to force ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Confirm")
    If iresponse = vbYes Then
         
         
        If Mid(BorrowingID, 1, 1) = "B" Then
            Adodc3.RecordSource = "SELECT * From Lending_Books WHERE ItemNo = '" & BorrowingID & "' and (AvailID = 'B' or AvailID = 'E')"
            Adodc2.RecordSource = "SELECT * From Books Where ItemNo = '" & BorrowingID & "'"
        ElseIf Mid(BorrowingID, 1, 1) = "K" Then
            Adodc3.RecordSource = "SELECT * From Lending_Cassettes WHERE ItemNo = '" & BorrowingID & "' and (AvailID = 'B' or AvailID = 'E')"
            Adodc2.RecordSource = "SELECT * From Cassettes Where ItemNo = '" & BorrowingID & "'"
        ElseIf Mid(BorrowingID, 1, 1) = "C" Then
            Adodc3.RecordSource = "SELECT * From Lending_CDs WHERE ItemNo = '" & BorrowingID & "' and (AvailID = 'B' or AvailID = 'E')"
            Adodc2.RecordSource = "SELECT * From CDs Where ItemNo = '" & BorrowingID & "'"
        ElseIf Mid(BorrowingID, 1, 1) = "V" Then
            Adodc3.RecordSource = "SELECT * From Lending_Videos WHERE ItemNo = '" & BorrowingID & "' and (AvailID = 'B' or AvailID = 'E')"
            Adodc2.RecordSource = "SELECT * From Videos Where ItemNo = '" & BorrowingID & "'"
        Else
            MsgBox "The ID is not valid ID", vbInformation, "Error"
            Exit Sub
        End If
            Adodc3.Refresh
            Adodc2.Refresh
            
            Adodc3.Recordset.Fields(3) = "R"
            Adodc3.Recordset.Update
        
            Adodc2.Recordset.Fields(9) = "A"
            Adodc2.Recordset.Update
            
            Adodc3.Refresh
            Adodc2.Refresh
                    
            Call SaveData(BorrowingID, BorrowingName)
    Else
        MsgBox "Borrow not successful", vbInformation, "Information"
    End If
ElseIf AvailID = "A" Then
    Call SaveData(BorrowingID, BorrowingName)
Else
    MsgBox "Status Borrowing Unknown", vbCritical, "Error"
End If
End Sub

Private Sub SaveData(BorrowingID As String, BorrowingName As Integer)
Select Case BorrowingName
Case 1
Adodc3.RecordSource = "SELECT * From Lending_Books"
Case 2
Adodc3.RecordSource = "SELECT * From Lending_Cassettes"
Case 3
Adodc3.RecordSource = "SELECT * From Lending_CDs"
Case 4
Adodc3.RecordSource = "SELECT * From Lending_Videos"
End Select
Adodc3.Refresh
            
            If Mid(BorrowingID, 1, 1) = "B" Then
                Adodc2.RecordSource = "SELECT * From Books Where ItemNo = '" & BorrowingID & "'"
            ElseIf Mid(BorrowingID, 1, 1) = "K" Then
                Adodc2.RecordSource = "SELECT * From Cassettes Where ItemNo = '" & BorrowingID & "'"
            ElseIf Mid(BorrowingID, 1, 1) = "C" Then
                Adodc2.RecordSource = "SELECT * From CDs Where ItemNo = '" & BorrowingID & "'"
            ElseIf Mid(BorrowingID, 1, 1) = "V" Then
                Adodc2.RecordSource = "SELECT * From Videos Where ItemNo = '" & BorrowingID & "'"
            End If

Adodc2.Refresh

Adodc3.Recordset.AddNew
Adodc3.Recordset.Fields(1) = BorrowingID
Adodc3.Recordset.Fields(2) = CurrentBorrower.ID
Adodc3.Recordset.Fields(3) = "B"
Adodc3.Recordset.Fields(4) = Date
Adodc3.Recordset.Fields(5) = Date + 14
Adodc3.Recordset.Fields(7) = 0
Adodc3.Recordset.Update

Adodc2.Recordset.Fields(9) = "B"
Adodc2.Recordset.Update

MsgBox "Borrow Successful ", vbInformation, "Information"
DoingRefresh

End Sub

Private Sub CmdExtend_Click()


If DataGrid1.SelBookmarks.Count = 0 Then Exit Sub
For x = 0 To DataGrid1.SelBookmarks.Count - 1
    DataGrid2.Bookmark = DataGrid1.SelBookmarks(x)
If DataGrid2.Columns(5).Value = "B" Or DataGrid2.Columns(5).Value = "E" Then

    If DataGrid2.Columns(5).Value = "E" Then
        MsgBox CurrentBorrower.FName & " have already extended the borrowing, so can not extend anymore !", vbInformation, "Information"
        Exit Sub
    ElseIf Val(DataGrid2.Columns(4).Value) > 0 Then
        MsgBox CurrentBorrower.FName & " must pay " & DataGrid2.Columns(4).Value & " and return the borrowing", vbInformation, "Information"
        Exit Sub

    Else
        saskuser = "Do " & CurrentBorrower.FName & " want to extend " & DataGrid2.Columns(1).Value & " ?"
        iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Extend")
        If iresponse = vbYes Then
        
        Else
            MsgBox "Extend Canceled", vbInformation, "Information"
            Exit Sub
        End If
        
        If Mid(DataGrid2.Columns(0).Value, 1, 1) = "B" Then
             Adodc3.RecordSource = "SELECT * From Lending_Books WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Duedate = #" & DataGrid2.Columns(3).Value & "#"
             Adodc2.RecordSource = "SELECT * From Books Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
        ElseIf Mid(DataGrid2.Columns(0).Value, 1, 1) = "K" Then
            Adodc3.RecordSource = "SELECT * From Lending_Cassettes WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Duedate = #" & DataGrid2.Columns(3).Value & "#"
            Adodc2.RecordSource = "SELECT * From Cassettes Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
        ElseIf Mid(DataGrid2.Columns(0).Value, 1, 1) = "C" Then
            Adodc3.RecordSource = "SELECT * From Lending_CDs WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Duedate = #" & DataGrid2.Columns(3).Value & "#"
            Adodc2.RecordSource = "SELECT * From CDs Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
        ElseIf Mid(DataGrid2.Columns(0).Value, 1, 1) = "V" Then
            Adodc3.RecordSource = "SELECT * From Lending_Videos WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E') and Duedate = #" & DataGrid2.Columns(3).Value & "#"
            Adodc2.RecordSource = "SELECT * From Videos Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
        Else
            MsgBox "The ID is not valid ID", vbInformation, "Error"
            Exit Sub
        End If
        Adodc2.Refresh
        Adodc3.Refresh
        Adodc3.Recordset.Fields(3) = "E"
        Adodc3.Recordset.Fields(5) = Adodc3.Recordset.Fields(5) + 14
        Adodc3.Recordset.Update
        Adodc3.Refresh
        
        Adodc2.Recordset.Fields(9) = "E"
        Adodc2.Recordset.Update
        Adodc2.Refresh
    
    
        MsgBox "Extend Successful", vbInformation, "Information"
    End If
Else
    MsgBox "Please click the borrowing with status 'B' and click Extend", vbInformation, "Information"
End If
Next
DoingRefresh
End Sub





Private Sub CmdReturn_Click()

If DataGrid1.SelBookmarks.Count = 0 Then Exit Sub
For x = 0 To DataGrid1.SelBookmarks.Count - 1
    DataGrid2.Bookmark = DataGrid1.SelBookmarks(x)


If DataGrid2.Columns(5).Value = "B" Or DataGrid2.Columns(5) = "E" Then
    
    saskuser = "Do " & CurrentBorrower.FName & " want to return " & DataGrid2.Columns(1).Value & " ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Return")
    If iresponse = vbYes Then
    
    Else
        MsgBox "Return Canceled", vbInformation, "Information"
        Exit Sub
    End If

    If Mid(DataGrid2.Columns(0).Value, 1, 1) = "B" Then
        Adodc3.RecordSource = "SELECT * From Lending_Books WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E')"
        Adodc2.RecordSource = "SELECT * From Books Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
    ElseIf Mid(DataGrid2.Columns(0).Value, 1, 1) = "K" Then
        Adodc3.RecordSource = "SELECT * From Lending_Cassettes WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E')"
        Adodc2.RecordSource = "SELECT * From Cassettes Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
    ElseIf Mid(DataGrid2.Columns(0).Value, 1, 1) = "C" Then
        Adodc3.RecordSource = "SELECT * From Lending_CDs WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E')"
        Adodc2.RecordSource = "SELECT * From CDs Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
    ElseIf Mid(DataGrid2.Columns(0).Value, 1, 1) = "V" Then
        Adodc3.RecordSource = "SELECT * From Lending_Videos WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E')"
        Adodc2.RecordSource = "SELECT * From Videos Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
    Else
        MsgBox "The ID is not valid ID", vbInformation, "Error"
        Exit Sub
    End If
    Adodc2.Refresh
    Adodc3.Refresh
    
    If Val(DataGrid2.Columns(4).Value) > 0 Then
        saskuser = CurrentBorrower.FName & " need to pay " & DataGrid2.Columns(4).Value & " because of overdue"
        iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Fine")
            If iresponse = vbYes Then
                Adodc3.Recordset.Fields(8) = True
            Else
                
            End If
    End If
    
    Adodc3.Recordset.Fields(3) = "R"
    Adodc3.Recordset.Update
    
    Adodc2.Recordset.Fields(9) = "A"
    Adodc2.Recordset.Update
    
    Adodc3.Refresh
    Adodc2.Refresh

    MsgBox "Return Successful", vbInformation, "Information"
Else
    MsgBox "Please click the borrowing with status 'B' or 'E' and click Return", vbInformation, "Information"
End If
Next

DoingRefresh

End Sub
Private Sub CmdRenew_Click()

If DataGrid1.SelBookmarks.Count = 0 Then Exit Sub

For x = 0 To DataGrid1.SelBookmarks.Count - 1
    DataGrid2.Bookmark = DataGrid1.SelBookmarks(x)

    If DataGrid2.Columns(5).Value = "B" Or DataGrid2.Columns(5) = "E" Then
    
    saskuser = "Do " & CurrentBorrower.FName & " want to renew " & DataGrid2.Columns(1).Value & " ?"
    iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Return")
    If iresponse = vbYes Then
    
    Else
        MsgBox "Renew Canceled", vbInformation, "Information"
        Exit Sub
    End If

    If Mid(DataGrid2.Columns(0).Value, 1, 1) = "B" Then
        Adodc3.RecordSource = "SELECT * From Lending_Books WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E')"
        Adodc2.RecordSource = "SELECT * From Books Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
    ElseIf Mid(DataGrid2.Columns(0).Value, 1, 1) = "K" Then
        Adodc3.RecordSource = "SELECT * From Lending_Cassettes WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E')"
        Adodc2.RecordSource = "SELECT * From Cassettes Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
    ElseIf Mid(DataGrid2.Columns(0).Value, 1, 1) = "C" Then
        Adodc3.RecordSource = "SELECT * From Lending_CDs WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E')"
        Adodc2.RecordSource = "SELECT * From CDs Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
    ElseIf Mid(DataGrid2.Columns(0).Value, 1, 1) = "V" Then
        Adodc3.RecordSource = "SELECT * From Lending_Videos WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid2.Columns(0).Value & "' and (AvailID = 'B' or AvailID = 'E')"
        Adodc2.RecordSource = "SELECT * From Videos Where ItemNo = '" & DataGrid2.Columns(0).Value & "'"
    Else
        MsgBox "The ID is not valid ID", vbInformation, "Error"
        Exit Sub
    End If
    Adodc2.Refresh
    Adodc3.Refresh
    
    If Val(DataGrid2.Columns(4).Value) > 0 Then
        saskuser = CurrentBorrower.FName & " need to pay " & DataGrid2.Columns(4).Value & " because of overdue"
        iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Fine")
            If iresponse = vbYes Then
                Adodc3.Recordset.Fields(8) = True
            Else
                
            End If
    End If
    
    Adodc3.Recordset.Fields(3) = "R"
    Adodc3.Recordset.Update
    
    Adodc2.Recordset.Fields(9) = "A"
    Adodc2.Recordset.Update
    
    Adodc3.Refresh
    Adodc2.Refresh

    BorrowingID = DataGrid2.Columns(0).Value
    If Mid(BorrowingID, 1, 1) = "B" Then
        Call SaveData(BorrowingID, 1)
    ElseIf Mid(BorrowingID, 1, 1) = "K" Then
        Call SaveData(BorrowingID, 2)
    ElseIf Mid(BorrowingID, 1, 1) = "C" Then
        Call SaveData(BorrowingID, 3)
    ElseIf Mid(BorrowingID, 1, 1) = "V" Then
        Call SaveData(BorrowingID, 4)
    End If
       
    MsgBox "Renew Successful", vbInformation, "Information"


Else
    MsgBox "Please click the borrowing with status 'B' or 'E' and click Return", vbInformation, "Information"
End If
Next

DoingRefresh


End Sub

Private Sub CmdPay_Click()

If DataGrid4.SelBookmarks.Count > 0 Then
For x = 0 To DataGrid4.SelBookmarks.Count - 1
    DataGrid5.Bookmark = DataGrid4.SelBookmarks(x)
        saskuser = "Do " & CurrentBorrower.FName & " want to paid " & DataGrid5.Columns(1).Value & " ?"
        iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Return")
        If iresponse = vbYes Then
    
        Else
            MsgBox "Paid Canceled", vbInformation, "Information"
            Exit Sub
        End If
    If Mid(DataGrid5.Columns(0).Value, 1, 1) = "B" Then
        Adodc3.RecordSource = "SELECT * From Lending_Books WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid5.Columns(0).Value & "' and paid = false"
       
    ElseIf Mid(DataGrid5.Columns(0).Value, 1, 1) = "K" Then
        Adodc3.RecordSource = "SELECT * From Lending_Cassettes WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid5.Columns(0).Value & "' and paid = false"
       
    ElseIf Mid(DataGrid5.Columns(0).Value, 1, 1) = "C" Then
        Adodc3.RecordSource = "SELECT * From Lending_CDs WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid5.Columns(0).Value & "' and paid = false"
       
    ElseIf Mid(DataGrid5.Columns(0).Value, 1, 1) = "V" Then
        Adodc3.RecordSource = "SELECT * From Lending_Videos WHERE BorrowerID = " & Val(CurrentBorrower.ID) & " and ItemNo = '" & DataGrid5.Columns(0).Value & "' and paid = false"
        
    Else
        MsgBox "The ID is not valid ID", vbInformation, "Error"
        Exit Sub
    End If
    Adodc2.Refresh
    Adodc3.Refresh
    
    If Val(DataGrid5.Columns(5).Value) > 0 Then
        saskuser = CurrentBorrower.FName & " need to pay " & DataGrid5.Columns(5).Value & " because of overdue"
        iresponse = MsgBox(saskuser, vbQuestion + vbYesNo + vbDefaultButton2, "Fine")
            If iresponse = vbYes Then
                Adodc3.Recordset.Fields(8) = True
            Else
                
            End If
    End If
    
    Adodc3.Recordset.Update
    
    Adodc3.Refresh
    Adodc2.Refresh

    MsgBox "Paid Successful", vbInformation, "Information"
Next
Else
    MsgBox "Please click the unpaid Items and click Pay !", vbInformation, "Information"
End If


DoingRefresh
End Sub
Private Sub Form_Load()

    LblID.Caption = CurrentBorrower.ID
    LblFirstName.Caption = CurrentBorrower.FName
    LblLastName.Caption = CurrentBorrower.LName
    
    strSQL = "SELECT Lending_Books.ItemNo as ID, Title, LendingDate,DueDate,Fine,Lending_Books.AvailID,AvailName From Lending_Books,Books,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Books.BorrowerID and Lending_Books.ItemNo = Books.ItemNo and (Lending_Books.AvailID = 'B' or lending_books.AvailID = 'E' or lending_books.AvailID = 'O') and Lending_Books.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Books.AvailID = Availability.AvailID"
    strSQL = strSQL & " UNION " & "SELECT Lending_Cassettes.ItemNo as ID, Title,LendingDate, DueDate,Fine,Lending_Cassettes.AvailID,AvailName From Lending_Cassettes,Cassettes,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Cassettes.BorrowerID and Lending_Cassettes.ItemNo = Cassettes.ItemNo and (Lending_Cassettes.AvailID = 'B' or lending_cassettes.AvailID = 'E' or lending_cassettes.AvailID = 'O') and Lending_Cassettes.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Cassettes.AvailID = Availability.AvailID"
    strSQL = strSQL & " UNION " & "SELECT Lending_CDs.ItemNo as ID, Title, LendingDate,DueDate,Fine,Lending_CDs.AvailID,AvailName From Lending_CDs,CDs,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_CDs.BorrowerID and Lending_CDs.ItemNo = CDs.ItemNo and (Lending_CDs.AvailID = 'B' or Lending_CDs.AvailID = 'E' or Lending_CDs.AvailID = 'O') and Lending_CDs.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_CDs.AvailID = Availability.AvailID "
    strSQL = strSQL & " UNION " & "SELECT Lending_Videos.ItemNo as ID, Title, LendingDate,DueDate,Fine,Lending_Videos.AvailID,AvailName From Lending_Videos,Videos,Borrowers, Availability WHERE Borrowers.BorrowerID = Lending_Videos.BorrowerID and Lending_Videos.ItemNo = Videos.ItemNo and (Lending_Videos.AvailID = 'B' or Lending_Videos.AvailID = 'E' or Lending_Videos.AvailID = 'O') and Lending_Videos.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Videos.AvailID = Availability.AvailID"
    
    'adodc1 = current borrowing
    Adodc1.RecordSource = strSQL
    Adodc1.Refresh
    
    'adodc4 = for update database
    Adodc4.RecordSource = strSQL
    Adodc4.Refresh

    strSQL2 = "SELECT Lending_Books.ItemNo as ID, Title, LendingDate,DueDate,Fine,Lending_Books.AvailID,AvailName From Lending_Books,Books,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Books.BorrowerID and Lending_Books.ItemNo = Books.ItemNo and  Lending_Books.AvailID = 'R'  and Lending_Books.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Books.AvailID = Availability.AvailID"
    strSQL2 = strSQL2 & " UNION " & "SELECT Lending_Cassettes.ItemNo as ID, Title,LendingDate, DueDate,Fine,Lending_Cassettes.AvailID,AvailName From Lending_Cassettes,Cassettes,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Cassettes.BorrowerID and Lending_Cassettes.ItemNo = Cassettes.ItemNo and Lending_Cassettes.AvailID = 'R' and Lending_Cassettes.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Cassettes.AvailID = Availability.AvailID"
    strSQL2 = strSQL2 & " UNION " & "SELECT Lending_CDs.ItemNo as ID, Title, LendingDate,DueDate,Fine,Lending_CDs.AvailID,AvailName From Lending_CDs,CDs,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_CDs.BorrowerID and Lending_CDs.ItemNo = CDs.ItemNo and Lending_CDs.AvailID = 'R' and Lending_CDs.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_CDs.AvailID = Availability.AvailID "
    strSQL2 = strSQL2 & " UNION " & "SELECT Lending_Videos.ItemNo as ID, Title, LendingDate,DueDate,Fine,Lending_Videos.AvailID,AvailName From Lending_Videos,Videos,Borrowers, Availability WHERE Borrowers.BorrowerID = Lending_Videos.BorrowerID and Lending_Videos.ItemNo = Videos.ItemNo and Lending_Videos.AvailID = 'R' and Lending_Videos.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Videos.AvailID = Availability.AvailID"
    
    'adodc5 = history list
    Adodc5.RecordSource = strSQL2
    Adodc5.Refresh

    
    strSQL3 = "SELECT Lending_Books.ItemNo as ID, Title, LendingDate,DueDate, ReturnDate, Fine, AvailName From Lending_Books,Books,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Books.BorrowerID and Lending_Books.ItemNo = Books.ItemNo and  Lending_Books.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Books.AvailID = Availability.AvailID and Lending_Books.paid = false and Lending_Books.fine >0 and Lending_Books.availID = 'R'"
    strSQL3 = strSQL3 & " UNION " & "SELECT Lending_Cassettes.ItemNo as ID, Title,LendingDate, DueDate, ReturnDate, Fine, AvailName From Lending_Cassettes,Cassettes,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_Cassettes.BorrowerID and Lending_Cassettes.ItemNo = Cassettes.ItemNo and Lending_Cassettes.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Cassettes.AvailID = Availability.AvailID and Lending_Cassettes.paid = false and Lending_Cassettes.fine >0 and Lending_Cassettes.availID = 'R'"
    strSQL3 = strSQL3 & " UNION " & "SELECT Lending_CDs.ItemNo as ID, Title, LendingDate,DueDate,ReturnDate, Fine, AvailName From Lending_CDs,CDs,Borrowers,Availability WHERE Borrowers.BorrowerID = Lending_CDs.BorrowerID and Lending_CDs.ItemNo = CDs.ItemNo and Lending_CDs.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_CDs.AvailID = Availability.AvailID and Lending_CDs.paid = false and Lending_CDs.fine > 0 and Lending_CDs.availID = 'R'"
    strSQL3 = strSQL3 & " UNION " & "SELECT Lending_Videos.ItemNo as ID, Title, LendingDate,DueDate,ReturnDate, Fine, AvailName From Lending_Videos,Videos,Borrowers, Availability WHERE Borrowers.BorrowerID = Lending_Videos.BorrowerID and Lending_Videos.ItemNo = Videos.ItemNo and Lending_Videos.BorrowerID = " & Val(CurrentBorrower.ID) & " and Lending_Videos.AvailID = Availability.AvailID and Lending_Videos.paid = false and Lending_Videos.fine > 0 and Lending_Videos.availID = 'R'"
    
    'adodc6 = unpaid list
    Adodc6.RecordSource = strSQL3
    Adodc6.Refresh
    
    'adodc7 = unpaid list
    Adodc7.RecordSource = strSQL3
    Adodc7.Refresh
    SSTab1.Tab = 0
    DoingRefresh
    
End Sub


Private Sub IsDataAvailable()
    If Adodc1.Recordset.EOF Then

        CmdExtend.Enabled = False

        CmdReturn.Enabled = False
    Else

        CmdExtend.Enabled = True

        CmdReturn.Enabled = True
    
    End If
End Sub
Private Sub ArrangeGrid()

DataGrid1.Columns(0).Width = 900
DataGrid1.Columns(1).Width = 3000
DataGrid1.Columns(2).Width = 1000
DataGrid1.Columns(3).Width = 1000
DataGrid1.Columns(4).Width = 500
DataGrid1.Columns(5).Width = 500
DataGrid1.Columns(6).Width = 1000

DataGrid3.Columns(0).Width = 900
DataGrid3.Columns(1).Width = 2500
DataGrid3.Columns(2).Width = 1000
DataGrid3.Columns(3).Width = 1000
DataGrid3.Columns(4).Width = 500
DataGrid3.Columns(5).Width = 500

DataGrid4.Columns(0).Width = 900
DataGrid4.Columns(1).Width = 2500
DataGrid4.Columns(2).Width = 1000
DataGrid4.Columns(3).Width = 1000
DataGrid4.Columns(4).Width = 1000
DataGrid4.Columns(5).Width = 500

End Sub

Private Sub DoingRefresh()
Adodc1.Refresh
Adodc4.Refresh
Adodc2.Refresh
Adodc3.Refresh
Adodc5.Refresh
Adodc6.Refresh
Adodc7.Refresh


 
    unreturnItems = 0
    TotalFine = 0
    TotalItem = 0
    totalUnpaid = 0
    books = 0
    cassettes = 0
    cds = 0
    videos = 0
    TotalCredits = 0
    
    While Not Adodc1.Recordset.EOF
        unreturnItems = unreturnItems + 1
        TotalFine = TotalFine + Adodc1.Recordset.Fields(4)
        Adodc1.Recordset.MoveNext
    Wend
    
    LblUnreturnItems.Caption = unreturnItems
    LblTotalFine.Caption = TotalFine
    
    While Not Adodc5.Recordset.EOF
        TotalItem = TotalItem + 1
        If Mid(Adodc5.Recordset.Fields(0), 1, 1) = "B" Then books = books + 1
        If Mid(Adodc5.Recordset.Fields(0), 1, 1) = "K" Then books = cassettes + 1
        If Mid(Adodc5.Recordset.Fields(0), 1, 1) = "C" Then books = cds + 1
        If Mid(Adodc5.Recordset.Fields(0), 1, 1) = "V" Then books = videos + 1
        Adodc5.Recordset.MoveNext
    Wend
    
    lblTotalItems.Caption = TotalItem
    LblTBooks.Caption = books
    LblTCassettes.Caption = cassettes
    LblTCDs.Caption = cds
    LblTVideos.Caption = videos
    
    While Not Adodc6.Recordset.EOF
        totalUnpaid = totalUnpaid + 1
        TotalCredits = TotalCredits + Adodc6.Recordset.Fields(5)
        Adodc6.Recordset.MoveNext
    Wend
    LblUnpaidItems.Item(0) = totalUnpaid
    LblUnpaidItems.Item(1) = totalUnpaid
    LblTotalCredits.Item(0) = TotalCredits
    LblTotalCredits.Item(1) = TotalCredits
Adodc1.Refresh
Adodc4.Refresh
Adodc2.Refresh
Adodc3.Refresh
Adodc5.Refresh
Adodc6.Refresh
Adodc7.Refresh
ArrangeGrid
IsDataAvailable
End Sub

