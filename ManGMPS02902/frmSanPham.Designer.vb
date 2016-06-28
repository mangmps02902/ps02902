<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGIA = New System.Windows.Forms.TextBox()
        Me.txtMALOAI = New System.Windows.Forms.TextBox()
        Me.txtTENSP = New System.Windows.Forms.TextBox()
        Me.txtMASP = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(205, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 31)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Quản Lý Sản Phẩm"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 154)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(704, 225)
        Me.DataGridView1.TabIndex = 22
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(609, 98)
        Me.btnLuu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(100, 28)
        Me.btnLuu.TabIndex = 21
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(609, 62)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 28)
        Me.btnXoa.TabIndex = 19
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(501, 98)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(100, 28)
        Me.btnSua.TabIndex = 20
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(501, 62)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 28)
        Me.btnThem.TabIndex = 18
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Đơn giá:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tên SP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Mã loại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Mã SP:"
        '
        'txtGIA
        '
        Me.txtGIA.Location = New System.Drawing.Point(337, 101)
        Me.txtGIA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGIA.Name = "txtGIA"
        Me.txtGIA.Size = New System.Drawing.Size(132, 22)
        Me.txtGIA.TabIndex = 16
        '
        'txtMALOAI
        '
        Me.txtMALOAI.Location = New System.Drawing.Point(337, 66)
        Me.txtMALOAI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMALOAI.Name = "txtMALOAI"
        Me.txtMALOAI.Size = New System.Drawing.Size(132, 22)
        Me.txtMALOAI.TabIndex = 15
        '
        'txtTENSP
        '
        Me.txtTENSP.Location = New System.Drawing.Point(82, 101)
        Me.txtTENSP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTENSP.Name = "txtTENSP"
        Me.txtTENSP.Size = New System.Drawing.Size(132, 22)
        Me.txtTENSP.TabIndex = 14
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(82, 66)
        Me.txtMASP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(132, 22)
        Me.txtMASP.TabIndex = 9
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 404)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGIA)
        Me.Controls.Add(Me.txtMALOAI)
        Me.Controls.Add(Me.txtTENSP)
        Me.Controls.Add(Me.txtMASP)
        Me.Name = "frmSanPham"
        Me.Text = "Sản Phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGIA As TextBox
    Friend WithEvents txtMALOAI As TextBox
    Friend WithEvents txtTENSP As TextBox
    Friend WithEvents txtMASP As TextBox
End Class
