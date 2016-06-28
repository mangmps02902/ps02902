<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiem
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
        Me.cmbTimKiem = New System.Windows.Forms.ComboBox()
        Me.txtTimKIem = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTimKiem
        '
        Me.cmbTimKiem.FormattingEnabled = True
        Me.cmbTimKiem.Items.AddRange(New Object() {"Mã Khách Hàng", "Tên Khách Hàng", "Địa Chỉ", "Số Điện Thoại"})
        Me.cmbTimKiem.Location = New System.Drawing.Point(33, 89)
        Me.cmbTimKiem.Name = "cmbTimKiem"
        Me.cmbTimKiem.Size = New System.Drawing.Size(336, 24)
        Me.cmbTimKiem.TabIndex = 0
        '
        'txtTimKIem
        '
        Me.txtTimKIem.Location = New System.Drawing.Point(424, 91)
        Me.txtTimKIem.Name = "txtTimKIem"
        Me.txtTimKIem.Size = New System.Drawing.Size(221, 22)
        Me.txtTimKIem.TabIndex = 1
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(33, 129)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(612, 215)
        Me.dgv1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tìm Kiếm Sản Phẩm"
        '
        'frmTimKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 380)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.txtTimKIem)
        Me.Controls.Add(Me.cmbTimKiem)
        Me.Name = "frmTimKiem"
        Me.Text = "Tìm Sản Phẩm"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTimKiem As ComboBox
    Friend WithEvents txtTimKIem As TextBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Label1 As Label
End Class
