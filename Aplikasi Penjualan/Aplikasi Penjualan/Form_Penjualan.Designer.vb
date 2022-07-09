<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Penjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.v0grandtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.v0kasir = New System.Windows.Forms.TextBox()
        Me.v0tanggal = New System.Windows.Forms.TextBox()
        Me.v0jam = New System.Windows.Forms.TextBox()
        Me.v0nofaktur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.v0dibayar = New System.Windows.Forms.TextBox()
        Me.v0kembalian = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v0kdbarang = New System.Windows.Forms.TextBox()
        Me.v0namabarang = New System.Windows.Forms.TextBox()
        Me.v0jenisbarang = New System.Windows.Forms.TextBox()
        Me.v0satuan = New System.Windows.Forms.TextBox()
        Me.v0harga = New System.Windows.Forms.TextBox()
        Me.v0qty = New System.Windows.Forms.TextBox()
        Me.v0totalharga = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Aplikasi_Penjualan.My.Resources.Resources.Warna
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1386, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.Aplikasi_Penjualan.My.Resources.Resources.Warna
        Me.GroupBox3.Controls.Add(Me.v0grandtotal)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(404, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(979, 153)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grand Total"
        '
        'v0grandtotal
        '
        Me.v0grandtotal.BackColor = System.Drawing.Color.Black
        Me.v0grandtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0grandtotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.v0grandtotal.Font = New System.Drawing.Font("DS-Digital", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0grandtotal.ForeColor = System.Drawing.Color.Lime
        Me.v0grandtotal.Location = New System.Drawing.Point(3, 25)
        Me.v0grandtotal.Multiline = True
        Me.v0grandtotal.Name = "v0grandtotal"
        Me.v0grandtotal.ReadOnly = True
        Me.v0grandtotal.Size = New System.Drawing.Size(973, 125)
        Me.v0grandtotal.TabIndex = 8
        Me.v0grandtotal.Text = "2.000.000"
        Me.v0grandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.Aplikasi_Penjualan.My.Resources.Resources.Warna
        Me.GroupBox2.Controls.Add(Me.v0kasir)
        Me.GroupBox2.Controls.Add(Me.v0tanggal)
        Me.GroupBox2.Controls.Add(Me.v0jam)
        Me.GroupBox2.Controls.Add(Me.v0nofaktur)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(3, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 153)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'v0kasir
        '
        Me.v0kasir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0kasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0kasir.Location = New System.Drawing.Point(209, 100)
        Me.v0kasir.Name = "v0kasir"
        Me.v0kasir.ReadOnly = True
        Me.v0kasir.Size = New System.Drawing.Size(186, 26)
        Me.v0kasir.TabIndex = 4
        Me.v0kasir.Text = "Andri Syahputra"
        '
        'v0tanggal
        '
        Me.v0tanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0tanggal.Location = New System.Drawing.Point(209, 48)
        Me.v0tanggal.Name = "v0tanggal"
        Me.v0tanggal.ReadOnly = True
        Me.v0tanggal.Size = New System.Drawing.Size(186, 26)
        Me.v0tanggal.TabIndex = 8
        '
        'v0jam
        '
        Me.v0jam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0jam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0jam.Location = New System.Drawing.Point(13, 100)
        Me.v0jam.Name = "v0jam"
        Me.v0jam.ReadOnly = True
        Me.v0jam.Size = New System.Drawing.Size(186, 26)
        Me.v0jam.TabIndex = 8
        '
        'v0nofaktur
        '
        Me.v0nofaktur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0nofaktur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0nofaktur.Location = New System.Drawing.Point(13, 48)
        Me.v0nofaktur.Name = "v0nofaktur"
        Me.v0nofaktur.ReadOnly = True
        Me.v0nofaktur.Size = New System.Drawing.Size(186, 26)
        Me.v0nofaktur.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kasir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No Faktur"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.Aplikasi_Penjualan.My.Resources.Resources.Warna
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.v0dibayar)
        Me.GroupBox4.Controls.Add(Me.v0kembalian)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(0, 629)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1386, 153)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pembayaran"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Aplikasi_Penjualan.My.Resources.Resources.Warna
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1013, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 61)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Tutup"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Aplikasi_Penjualan.My.Resources.Resources.Warna
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(913, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 61)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Aplikasi_Penjualan.My.Resources.Resources.Warna
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(813, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 61)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 37)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Dibayar"
        '
        'v0dibayar
        '
        Me.v0dibayar.BackColor = System.Drawing.Color.Black
        Me.v0dibayar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.v0dibayar.Font = New System.Drawing.Font("DS-Digital", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0dibayar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.v0dibayar.Location = New System.Drawing.Point(12, 68)
        Me.v0dibayar.Name = "v0dibayar"
        Me.v0dibayar.Size = New System.Drawing.Size(403, 64)
        Me.v0dibayar.TabIndex = 8
        Me.v0dibayar.Text = "20000"
        Me.v0dibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'v0kembalian
        '
        Me.v0kembalian.BackColor = System.Drawing.Color.Black
        Me.v0kembalian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.v0kembalian.Font = New System.Drawing.Font("DS-Digital", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0kembalian.ForeColor = System.Drawing.Color.Yellow
        Me.v0kembalian.Location = New System.Drawing.Point(421, 67)
        Me.v0kembalian.Name = "v0kembalian"
        Me.v0kembalian.ReadOnly = True
        Me.v0kembalian.Size = New System.Drawing.Size(363, 64)
        Me.v0kembalian.TabIndex = 8
        Me.v0kembalian.Text = "10000"
        Me.v0kembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(417, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 39)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Kembalian"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 282)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1359, 341)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 426
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jenis Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Satuan"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 130
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 170
        '
        'Column6
        '
        Me.Column6.HeaderText = "QTY"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total Harga"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 190
        '
        'v0kdbarang
        '
        Me.v0kdbarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0kdbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0kdbarang.Location = New System.Drawing.Point(56, 235)
        Me.v0kdbarang.Name = "v0kdbarang"
        Me.v0kdbarang.Size = New System.Drawing.Size(153, 26)
        Me.v0kdbarang.TabIndex = 1
        '
        'v0namabarang
        '
        Me.v0namabarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0namabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0namabarang.Location = New System.Drawing.Point(208, 235)
        Me.v0namabarang.Name = "v0namabarang"
        Me.v0namabarang.ReadOnly = True
        Me.v0namabarang.Size = New System.Drawing.Size(422, 26)
        Me.v0namabarang.TabIndex = 2
        '
        'v0jenisbarang
        '
        Me.v0jenisbarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0jenisbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0jenisbarang.Location = New System.Drawing.Point(630, 235)
        Me.v0jenisbarang.Name = "v0jenisbarang"
        Me.v0jenisbarang.ReadOnly = True
        Me.v0jenisbarang.Size = New System.Drawing.Size(154, 26)
        Me.v0jenisbarang.TabIndex = 3
        '
        'v0satuan
        '
        Me.v0satuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0satuan.Location = New System.Drawing.Point(784, 235)
        Me.v0satuan.Name = "v0satuan"
        Me.v0satuan.ReadOnly = True
        Me.v0satuan.Size = New System.Drawing.Size(131, 26)
        Me.v0satuan.TabIndex = 4
        '
        'v0harga
        '
        Me.v0harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0harga.Location = New System.Drawing.Point(915, 235)
        Me.v0harga.Name = "v0harga"
        Me.v0harga.ReadOnly = True
        Me.v0harga.Size = New System.Drawing.Size(165, 26)
        Me.v0harga.TabIndex = 5
        Me.v0harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'v0qty
        '
        Me.v0qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0qty.Location = New System.Drawing.Point(1080, 235)
        Me.v0qty.Name = "v0qty"
        Me.v0qty.Size = New System.Drawing.Size(81, 26)
        Me.v0qty.TabIndex = 6
        Me.v0qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'v0totalharga
        '
        Me.v0totalharga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0totalharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0totalharga.Location = New System.Drawing.Point(1161, 235)
        Me.v0totalharga.Name = "v0totalharga"
        Me.v0totalharga.ReadOnly = True
        Me.v0totalharga.Size = New System.Drawing.Size(188, 26)
        Me.v0totalharga.TabIndex = 7
        Me.v0totalharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplikasi_Penjualan.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1386, 782)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.v0totalharga)
        Me.Controls.Add(Me.v0qty)
        Me.Controls.Add(Me.v0harga)
        Me.Controls.Add(Me.v0satuan)
        Me.Controls.Add(Me.v0jenisbarang)
        Me.Controls.Add(Me.v0namabarang)
        Me.Controls.Add(Me.v0kdbarang)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Penjualan"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents v0kasir As TextBox
    Friend WithEvents v0tanggal As TextBox
    Friend WithEvents v0jam As TextBox
    Friend WithEvents v0nofaktur As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents v0dibayar As TextBox
    Friend WithEvents v0kembalian As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents v0grandtotal As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents v0kdbarang As TextBox
    Friend WithEvents v0namabarang As TextBox
    Friend WithEvents v0jenisbarang As TextBox
    Friend WithEvents v0satuan As TextBox
    Friend WithEvents v0harga As TextBox
    Friend WithEvents v0qty As TextBox
    Friend WithEvents v0totalharga As TextBox
    Friend WithEvents Timer1 As Timer
End Class
