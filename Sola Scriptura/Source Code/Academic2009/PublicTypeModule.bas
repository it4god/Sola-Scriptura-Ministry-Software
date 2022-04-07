Attribute VB_Name = "PublicTypeModule"
Public Type Mahasiswa
    NIM As String * 10
    Nama_Awal As String * 60
    Nama_Akhir As String * 60
    Alamat As String * 100
    Telepon As String * 12
    HP As String * 12
    Email As String * 30
    TempatLahir As String * 40
    TanggalLahir As String * 10
    Program As String * 30
    PeriodeMasuk As String * 12
    Status As String * 10
    Password As String * 15
End Type
Public Type Mahasiswa_Buffer
    Buffer As String * 401
End Type

Public Type Dosen
    DosenID As String * 5
    Nama_Awal As String * 60
    Nama_Akhir As String * 60
    Alamat As String * 100
    Telepon As String * 12
    HP As String * 12
    Email As String * 30
    TempatLahir As String * 40
    TanggalLahir As String * 10
End Type
Public Type Dosen_Buffer
    Buffer As String * 329
End Type

Public Type MataKuliah
    MK_No As String * 8
    Nama_MK As String * 80
    Tipe_MK As String * 30
    MK_ID As String * 4
End Type

Public Type MataKuliah_Buffer
    Buffer As String * 122
End Type

Public Type MataKuliahPerSem
    MKP_No As String * 9
    MK_No As String * 8
    Periode As String * 10
    DosenID As String * 5
    SKS As String * 2
    TipeKuliah As String * 10
    Keterangan As String * 50

End Type

Public Type MataKuliahPerSem_Buffer
    Buffer As String * 94
    
End Type

Public Type MataKuliahMahasiswa
    MKM_No As String * 13
    MKP_No As String * 9
    NIM As String * 10
    Grade As String * 2
    Nilai As String * 8
End Type

Public Type MataKuliahMahasiswa_Buffer
    Buffer As String * 42
End Type

Public Type FileMahasiswa
    FileID As String * 9
    Deskripsi As String * 70
    NamaFile As String * 100
    NIM As String * 10
End Type

Public Type FileMahasiswa_Buffer
    Buffer As String * 189
End Type

Public Type Pembayaran
    PembayaranNo As String * 13
    NIM As String * 10
    Periode As String * 10
    Deskripsi As String * 70
    Tanggal As String * 10
    Jumlah As String * 8
    Keterangan As String * 30
End Type

Public Type Pembayaran_Buffer
    Buffer As String * 151
End Type

Public Type Pelayanan
    PelayananNo As String * 9
    NIM As String * 10
    Periode As String * 40
    Pelayanan As String * 80
End Type

Public Type Pelayanan_Buffer
    Buffer As String * 139
End Type

Public Type Biaya
    Program As String * 30
    Biaya As String * 10
End Type

Public Type Biaya_Buffer
    Buffer As String * 40
End Type

Public Type User
    UserName As String * 15
    UserPassword As String * 15
    UserAuthority As String * 1
End Type

Public Type User_Buffer
    Buffer As String * 31
End Type
