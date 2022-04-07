Attribute VB_Name = "Module1"
Public cn As Connection

Public Sub ConnectNow()

    Set cn = New Connection
    cn.ConnectionString = "driver={SQL Server};server=STTBLibrary;database=SolaTest"
    cn.Mode = adModeReadWrite
    cn.Open

End Sub

