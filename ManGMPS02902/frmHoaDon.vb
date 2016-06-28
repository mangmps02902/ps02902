Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmHOADON
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=(Local);Initial Catalog=PS02902_DATABASE;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SOHD as 'Số HD' ,MAKH as 'Mã KH',  NGAYHD as 'Ngày HD' from HOADON", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtSOHD.Text = ""
        txtMAKH.Text = ""
        txtNGAYHD.Text = ""
        txtSOHD.Focus()
    End Sub
    Private Sub frmHOADON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtSOHD.Text = "" Then
            MessageBox.Show("Nhập số HD")
            txtSOHD.Focus()
        ElseIf txtMAKH.Text = "" Then
            MessageBox.Show("Nhập mã KH")
            txtMAKH.Focus()
        ElseIf txtNGAYHD.Text = "" Then
            MessageBox.Show("Nhập ngày HD")
            txtNGAYHD.Focus()

        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into HOADON values(@SOHD,@MAKH,@NGAYHD)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@SOHD", txtSOHD.Text)
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@NGAYHD", txtNGAYHD.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtSOHD.Text = "" Then
            MessageBox.Show("Nhập Số HD cần xóa")
            txtSOHD.Focus()
        Else
            Dim delquery As String = "delete from HOADON where SOHD=@SOHD"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = System.Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@SOHD", txtSOHD.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtSOHD.ReadOnly = True
            btnSua.Text = "Update"
            txtSOHD.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update HOADON set SOHD=@TSOHD, MAKH=@MAKH, NGAYHD=@NGAYHD where SOHD=@SOHD"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@SOHD", txtSOHD.Text)
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@NGAYHD", txtNGAYHD.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtSOHD.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtSOHD.Text = DataGridView1.Item(0, click).Value
        txtSOHD.Text = DataGridView1.Item(1, click).Value
        txtNGAYHD.Text = DataGridView1.Item(2, click).Value

    End Sub
End Class