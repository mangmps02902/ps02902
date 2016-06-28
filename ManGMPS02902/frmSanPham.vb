Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=(Local);Initial Catalog=PS02902_DATABASE;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã SP' ,TENSP as 'Tên Sản phẩm',  GIA as 'Đơn giá', MALOAI as 'Mã Loại' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtMASP.Text = ""
        txtTENSP.Text = ""
        txtGIA.Text = ""
        txtMALOAI.Text = ""
        txtMASP.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMASP.Text = "" Then
            MessageBox.Show("Chua nhap mã sản phẩm")
            txtMASP.Focus()
        ElseIf txtTENSP.Text = "" Then
            MessageBox.Show("Chua nhap Tên sản phẩm")
            txtTENSP.Focus()
        ElseIf txtGIA.Text = "" Then
            MessageBox.Show("Chua nhap Số lượng")
            txtGIA.Focus()
        ElseIf txtMALOAI.Text = "" Then
            MessageBox.Show("Chua nhap Mã loại")
            txtMALOAI.Focus()

        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into SANPHAM values(@MASP,@TENSP,@GIA,@MALOAI)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMASP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
            save.Parameters.AddWithValue("@GIA", txtGIA.Text)
            save.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMASP.Text = "" Then
            MessageBox.Show("Nhap MASP cần xóa")
            txtMASP.Focus()
        Else
            Dim delquery As String = "delete from SANPHAM where MASP=@MASP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = System.Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MASP", txtMASP.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMASP.ReadOnly = True
            btnSua.Text = "Update"
            txtTENSP.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update SANPHAM set TenSP=@TENSP, Gia=@GIA, MALOAI=@MALOAI where MaSP=@MASP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMASP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
            save.Parameters.AddWithValue("@GIA", txtGIA.Text)
            save.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMASP.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMASP.Text = DataGridView1.Item(0, click).Value
        txtTENSP.Text = DataGridView1.Item(1, click).Value
        txtGIA.Text = DataGridView1.Item(2, click).Value
        txtMALOAI.Text = DataGridView1.Item(3, click).Value

    End Sub
End Class