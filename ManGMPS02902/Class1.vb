Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "Data Source=(Local);Initial Catalog=PS02902_DATABASE;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,HOTEN as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', DIENTHOAI as 'SĐT' from KHACHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "Data Source=(Local);Initial Catalog=PS02902_DATABASE;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISP.MALOAI as 'Mã Loại', LOAISP.TENLOAI as 'Tên Loại' from SANPHAM inner join LOAISP on SANPHAM.MALOAI = LOAISP.MALOAI", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class

