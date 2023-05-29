<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consulta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.TxtIdConsulta = New System.Windows.Forms.TextBox()
        Me.Txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.Btn_factura = New System.Windows.Forms.Button()
        Me.TxtServicio = New System.Windows.Forms.TextBox()
        Me.bt_nuevo = New System.Windows.Forms.Button()
        Me.bt_editar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Txb_buscar = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 82)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(427, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 25)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Gestión de Consultas"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 82)
        Me.Button1.TabIndex = 46
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(560, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "IdPaciente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(582, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Servicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(99, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(93, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(60, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "IdConsulta:"
        '
        'TxtEstado
        '
        Me.TxtEstado.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstado.Location = New System.Drawing.Point(178, 279)
        Me.TxtEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtEstado.Multiline = True
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtEstado.Size = New System.Drawing.Size(746, 72)
        Me.TxtEstado.TabIndex = 48
        '
        'TxtPaciente
        '
        Me.TxtPaciente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaciente.Location = New System.Drawing.Point(676, 211)
        Me.TxtPaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPaciente.Multiline = True
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(248, 32)
        Me.TxtPaciente.TabIndex = 49
        '
        'TxtIdConsulta
        '
        Me.TxtIdConsulta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtIdConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdConsulta.Location = New System.Drawing.Point(180, 139)
        Me.TxtIdConsulta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtIdConsulta.Multiline = True
        Me.TxtIdConsulta.Name = "TxtIdConsulta"
        Me.TxtIdConsulta.Size = New System.Drawing.Size(248, 32)
        Me.TxtIdConsulta.TabIndex = 50
        '
        'Txt_fecha
        '
        Me.Txt_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_fecha.Location = New System.Drawing.Point(180, 218)
        Me.Txt_fecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_fecha.Name = "Txt_fecha"
        Me.Txt_fecha.Size = New System.Drawing.Size(289, 22)
        Me.Txt_fecha.TabIndex = 51
        '
        'DataGridView2
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(104, 542)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(849, 257)
        Me.DataGridView2.TabIndex = 53
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_eliminar.ForeColor = System.Drawing.Color.Black
        Me.bt_eliminar.Location = New System.Drawing.Point(340, 414)
        Me.bt_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(113, 34)
        Me.bt_eliminar.TabIndex = 55
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = False
        '
        'bt_guardar
        '
        Me.bt_guardar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_guardar.ForeColor = System.Drawing.Color.Black
        Me.bt_guardar.Location = New System.Drawing.Point(180, 414)
        Me.bt_guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(113, 34)
        Me.bt_guardar.TabIndex = 54
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = False
        '
        'Btn_factura
        '
        Me.Btn_factura.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_factura.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_factura.Location = New System.Drawing.Point(788, 826)
        Me.Btn_factura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_factura.Name = "Btn_factura"
        Me.Btn_factura.Size = New System.Drawing.Size(165, 48)
        Me.Btn_factura.TabIndex = 58
        Me.Btn_factura.Text = "Facturar"
        Me.Btn_factura.UseVisualStyleBackColor = False
        '
        'TxtServicio
        '
        Me.TxtServicio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtServicio.Location = New System.Drawing.Point(676, 139)
        Me.TxtServicio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtServicio.Multiline = True
        Me.TxtServicio.Name = "TxtServicio"
        Me.TxtServicio.Size = New System.Drawing.Size(248, 32)
        Me.TxtServicio.TabIndex = 60
        '
        'bt_nuevo
        '
        Me.bt_nuevo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_nuevo.ForeColor = System.Drawing.Color.Black
        Me.bt_nuevo.Location = New System.Drawing.Point(688, 414)
        Me.bt_nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Size = New System.Drawing.Size(113, 34)
        Me.bt_nuevo.TabIndex = 61
        Me.bt_nuevo.Text = "Nuevo"
        Me.bt_nuevo.UseVisualStyleBackColor = False
        '
        'bt_editar
        '
        Me.bt_editar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bt_editar.ForeColor = System.Drawing.Color.Black
        Me.bt_editar.Location = New System.Drawing.Point(524, 414)
        Me.bt_editar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_editar.Name = "bt_editar"
        Me.bt_editar.Size = New System.Drawing.Size(113, 34)
        Me.bt_editar.TabIndex = 62
        Me.bt_editar.Text = "Editar"
        Me.bt_editar.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Location = New System.Drawing.Point(740, 482)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(113, 34)
        Me.btn_buscar.TabIndex = 70
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'Txb_buscar
        '
        Me.Txb_buscar.Location = New System.Drawing.Point(178, 482)
        Me.Txb_buscar.Multiline = True
        Me.Txb_buscar.Name = "Txb_buscar"
        Me.Txb_buscar.Size = New System.Drawing.Size(537, 34)
        Me.Txb_buscar.TabIndex = 69
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 897)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Txb_buscar)
        Me.Controls.Add(Me.bt_editar)
        Me.Controls.Add(Me.bt_nuevo)
        Me.Controls.Add(Me.TxtServicio)
        Me.Controls.Add(Me.Btn_factura)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_guardar)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Txt_fecha)
        Me.Controls.Add(Me.TxtIdConsulta)
        Me.Controls.Add(Me.TxtPaciente)
        Me.Controls.Add(Me.TxtEstado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents TxtIdConsulta As TextBox
    Friend WithEvents Txt_fecha As DateTimePicker
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents Btn_factura As Button
    Friend WithEvents TxtServicio As TextBox
    Friend WithEvents bt_nuevo As Button
    Friend WithEvents bt_editar As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents Txb_buscar As TextBox
End Class
