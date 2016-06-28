Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmTimKiem
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=(Local);Initial Catalog=PS02902_DATABASE;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Databaseaccess As New DataBaseAccess
    'Load Dữ Liệu Tìm Kiếm
    Private Sub frmTimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataTimKiem()
    End Sub
    Private Sub LoadDataTimKiem()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,HOTEN as 'Tên Khách Hàng', DIACHI as 'Địa Chỉ', DIENTHOAI as 'Số Điện Thoại' from KhachHang", conn)
        db.Clear()
        refesh.Fill(db)
        dgv1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    'Định Nghĩa hàm Tìm Kiếm
    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKIem.TextChanged
        SearchKhachHang(txtTimKIem.Text)
    End Sub
    Private Sub SearchKhachHang(value As String)
        Dim sqlQuery As String = String.Format("select MAKH as 'Mã KH' ,HOTEN as 'Tên Khách Hàng', DIACHI as 'Địa Chỉ', DIENTHOAI as 'Số Điện Thoại' from KhachHang")
        If cmbTimKiem.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MAKH like '{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where HOTEN LIKE N'{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 2 Then
            sqlQuery += String.Format(" where DIACHI LIKE N'{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 3 Then
            sqlQuery += String.Format(" where DIENTHOAI LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        dgv1.DataSource = data
        With dgv1
            .Columns(0).HeaderText = "Mã Khách Hàng"
            .Columns(1).HeaderText = "Tên Khách Hàng"
            .Columns(2).HeaderText = "Địa Chỉ"
            .Columns(3).HeaderText = "Số Điện Thoại"
            .Columns(3).Width = 250
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class