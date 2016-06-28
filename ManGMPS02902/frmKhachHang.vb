Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmKhachHang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=(Local);Initial Catalog=PS02902_DATABASE;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,HOTEN as 'Họ Tên',  DIACHI as 'Địa Chỉ', DIENTHOAI as 'Điện Thoại' from KhachHang", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtMAKH.Text = ""
        txtHOTEN.Text = ""
        txtDIACHI.Text = ""
        txtDIENTHOAI.Text = ""
        txtMAKH.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMAKH.Text = "" Then
            MessageBox.Show("Chua nhap mã sản phẩm")
            txtMAKH.Focus()
        ElseIf txtHOTEN.Text = "" Then
            MessageBox.Show("Chua nhap Tên sản phẩm")
            txtHOTEN.Focus()
        ElseIf txtDIACHI.Text = "" Then
            MessageBox.Show("Chua nhap Số lượng")
            txtDIACHI.Focus()
        ElseIf txtDIENTHOAI.Text = "" Then
            MessageBox.Show("Chua nhap Mã loại")
            txtDIENTHOAI.Focus()

        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into KhachHang values(@MAKH,@HOTEN,@DIACI,@DIENTHOAI)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@HOTEN", txtHOTEN.Text)
            save.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text)
            save.Parameters.AddWithValue("@DIENTHOAI", txtDIENTHOAI.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMAKH.Text = "" Then
            MessageBox.Show("Nhap MASP cần xóa")
            txtMAKH.Focus()
        Else
            Dim delquery As String = "delete from KHACHHANG where MAKH=@MAKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = System.Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMAKH.ReadOnly = True
            btnSua.Text = "Update"
            txtMAKH.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update KHACHHANG set MAKH=@MAKH, HOTEN=@HOTEN, DIACHI=@DIACHI where MAKH=@MAKH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@HOTEN", txtHOTEN.Text)
            save.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text)
            save.Parameters.AddWithValue("@DIENTHOAI", txtDIENTHOAI.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMAKH.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMAKH.Text = DataGridView1.Item(0, click).Value
        txtHOTEN.Text = DataGridView1.Item(1, click).Value
        txtDIACHI.Text = DataGridView1.Item(2, click).Value
        txtDIENTHOAI.Text = DataGridView1.Item(3, click).Value

    End Sub
End Class