<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg_factura = New System.Windows.Forms.DataGridView()
        Me.btn_fac = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fac = New System.Windows.Forms.Label()
        Me.txt_fec = New System.Windows.Forms.DateTimePicker()
        Me.txt_servicio = New System.Windows.Forms.TextBox()
        Me.txt_idPac = New System.Windows.Forms.TextBox()
        Me.Apellidos = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Servicio = New System.Windows.Forms.Label()
        Me.txt_factura = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_tratamiento = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_factura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(4, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sans Serif Collection", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(345, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(202, 68)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Factura "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.bt_eliminar)
        Me.Panel2.Controls.Add(Me.txt_nombre)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btn_fac)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.fac)
        Me.Panel2.Controls.Add(Me.txt_fec)
        Me.Panel2.Controls.Add(Me.txt_servicio)
        Me.Panel2.Controls.Add(Me.txt_idPac)
        Me.Panel2.Controls.Add(Me.Apellidos)
        Me.Panel2.Controls.Add(Me.txt_fecha)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Servicio)
        Me.Panel2.Controls.Add(Me.txt_factura)
        Me.Panel2.Controls.Add(Me.txt_precio)
        Me.Panel2.Location = New System.Drawing.Point(38, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(969, 1083)
        Me.Panel2.TabIndex = 1
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.Red
        Me.bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminar.Location = New System.Drawing.Point(515, 780)
        Me.bt_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(144, 44)
        Me.bt_eliminar.TabIndex = 58
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = False
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(640, 189)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nombre.Multiline = True
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(281, 32)
        Me.txt_nombre.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(536, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.dg_factura)
        Me.Panel3.Location = New System.Drawing.Point(14, 313)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(927, 410)
        Me.Panel3.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(709, 379)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Gracias vuelva pronto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(797, 64)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Clínica del doctor Egnio Arauz"
        '
        'dg_factura
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_factura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_factura.EnableHeadersVisualStyles = False
        Me.dg_factura.Location = New System.Drawing.Point(33, 133)
        Me.dg_factura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg_factura.Name = "dg_factura"
        Me.dg_factura.RowHeadersWidth = 51
        Me.dg_factura.Size = New System.Drawing.Size(880, 218)
        Me.dg_factura.TabIndex = 7
        '
        'btn_fac
        '
        Me.btn_fac.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_fac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fac.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fac.Location = New System.Drawing.Point(726, 780)
        Me.btn_fac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_fac.Name = "btn_fac"
        Me.btn_fac.Size = New System.Drawing.Size(215, 66)
        Me.btn_fac.TabIndex = 4
        Me.btn_fac.Text = "Imprimir Factura"
        Me.btn_fac.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(41, 769)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(193, 66)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Menu"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'fac
        '
        Me.fac.AutoSize = True
        Me.fac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fac.Location = New System.Drawing.Point(72, 64)
        Me.fac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.fac.Name = "fac"
        Me.fac.Size = New System.Drawing.Size(109, 25)
        Me.fac.TabIndex = 0
        Me.fac.Text = "idFactura:"
        '
        'txt_fec
        '
        Me.txt_fec.Location = New System.Drawing.Point(638, 118)
        Me.txt_fec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_fec.Name = "txt_fec"
        Me.txt_fec.Size = New System.Drawing.Size(283, 22)
        Me.txt_fec.TabIndex = 5
        '
        'txt_servicio
        '
        Me.txt_servicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_servicio.Location = New System.Drawing.Point(199, 186)
        Me.txt_servicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_servicio.Multiline = True
        Me.txt_servicio.Name = "txt_servicio"
        Me.txt_servicio.Size = New System.Drawing.Size(283, 35)
        Me.txt_servicio.TabIndex = 5
        '
        'txt_idPac
        '
        Me.txt_idPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idPac.Location = New System.Drawing.Point(640, 56)
        Me.txt_idPac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_idPac.Multiline = True
        Me.txt_idPac.Name = "txt_idPac"
        Me.txt_idPac.Size = New System.Drawing.Size(283, 34)
        Me.txt_idPac.TabIndex = 3
        '
        'Apellidos
        '
        Me.Apellidos.AutoSize = True
        Me.Apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apellidos.Location = New System.Drawing.Point(510, 55)
        Me.Apellidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.Size = New System.Drawing.Size(120, 25)
        Me.Apellidos.TabIndex = 1
        Me.Apellidos.Text = "idPaciente:"
        '
        'txt_fecha
        '
        Me.txt_fecha.AutoSize = True
        Me.txt_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.Location = New System.Drawing.Point(551, 118)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(79, 25)
        Me.txt_fecha.TabIndex = 6
        Me.txt_fecha.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Precio:"
        '
        'Servicio
        '
        Me.Servicio.AutoSize = True
        Me.Servicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servicio.Location = New System.Drawing.Point(80, 185)
        Me.Servicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Servicio.Name = "Servicio"
        Me.Servicio.Size = New System.Drawing.Size(97, 25)
        Me.Servicio.TabIndex = 0
        Me.Servicio.Text = "Servicio:"
        '
        'txt_factura
        '
        Me.txt_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_factura.Location = New System.Drawing.Point(199, 65)
        Me.txt_factura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_factura.Multiline = True
        Me.txt_factura.Name = "txt_factura"
        Me.txt_factura.Size = New System.Drawing.Size(283, 32)
        Me.txt_factura.TabIndex = 1
        '
        'txt_precio
        '
        Me.txt_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(199, 118)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_precio.Multiline = True
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(281, 35)
        Me.txt_precio.TabIndex = 4
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(283, 780)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 44)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1031, 897)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_factura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Servicio As Label
    Friend WithEvents txt_idPac As TextBox
    Friend WithEvents txt_factura As TextBox
    Friend WithEvents Apellidos As Label
    Friend WithEvents fac As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents dg_factura As DataGridView
    Friend WithEvents btn_fac As Button
    Friend WithEvents txt_tratamiento As System.ComponentModel.BackgroundWorker
    Friend WithEvents txt_fecha As Label
    Friend WithEvents txt_fec As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txt_servicio As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents Button1 As Button
End Class
