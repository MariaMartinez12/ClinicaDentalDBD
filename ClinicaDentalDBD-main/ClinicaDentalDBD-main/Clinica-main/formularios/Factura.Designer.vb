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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Gbox_Datos_precio = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Servicio = New System.Windows.Forms.Label()
        Me.Gbox_datos_paciente = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Numero = New System.Windows.Forms.Label()
        Me.Cedula = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.Label()
        Me.Apellidos = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Listratamiento = New System.Windows.Forms.ListBox()
        Me.ListbPrecio = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBoxDatos_PAC = New System.Windows.Forms.ListBox()
        Me.Item = New System.Windows.Forms.Label()
        Me.Datos_Pac = New System.Windows.Forms.Label()
        Me.Tratamiento = New System.Windows.Forms.Label()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Gbox_Datos_precio.SuspendLayout()
        Me.Gbox_datos_paciente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 67)
        Me.Panel1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sans Serif Collection", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(290, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(193, 67)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Factura "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(767, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(767, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Gbox_Datos_precio)
        Me.Panel2.Controls.Add(Me.Gbox_datos_paciente)
        Me.Panel2.Location = New System.Drawing.Point(-4, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 637)
        Me.Panel2.TabIndex = 1
        '
        'Gbox_Datos_precio
        '
        Me.Gbox_Datos_precio.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace
        Me.Gbox_Datos_precio.Controls.Add(Me.TextBox6)
        Me.Gbox_Datos_precio.Controls.Add(Me.Label1)
        Me.Gbox_Datos_precio.Controls.Add(Me.ComboBox1)
        Me.Gbox_Datos_precio.Controls.Add(Me.Servicio)
        Me.Gbox_Datos_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbox_Datos_precio.Location = New System.Drawing.Point(19, 222)
        Me.Gbox_Datos_precio.Name = "Gbox_Datos_precio"
        Me.Gbox_Datos_precio.Size = New System.Drawing.Size(772, 114)
        Me.Gbox_Datos_precio.TabIndex = 1
        Me.Gbox_Datos_precio.TabStop = False
        Me.Gbox_Datos_precio.Text = "Datos de servicio"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Extracciones Dentales C$600", "Obturaciones con Amalgama: C$700", "Obturaciones con Resima: C$800", "Tratamientos Endodontic: C$2500", "Profilaxis: C$600", "Cirugías de cordales: C$3600", "Prótesis Removibles Valplast:C$7000", "Prótesis metal-acrilico remocibles:C$5500", "Prótesis fijas procelana:C$500", "Prótesis fijas Acrilicas:C$1500"})
        Me.ComboBox1.Location = New System.Drawing.Point(127, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Servicio
        '
        Me.Servicio.AutoSize = True
        Me.Servicio.Location = New System.Drawing.Point(16, 39)
        Me.Servicio.Name = "Servicio"
        Me.Servicio.Size = New System.Drawing.Size(105, 20)
        Me.Servicio.TabIndex = 0
        Me.Servicio.Text = "Tratamiento"
        '
        'Gbox_datos_paciente
        '
        Me.Gbox_datos_paciente.Controls.Add(Me.TextBox5)
        Me.Gbox_datos_paciente.Controls.Add(Me.TextBox4)
        Me.Gbox_datos_paciente.Controls.Add(Me.TextBox3)
        Me.Gbox_datos_paciente.Controls.Add(Me.TextBox2)
        Me.Gbox_datos_paciente.Controls.Add(Me.TextBox1)
        Me.Gbox_datos_paciente.Controls.Add(Me.Numero)
        Me.Gbox_datos_paciente.Controls.Add(Me.Cedula)
        Me.Gbox_datos_paciente.Controls.Add(Me.Id)
        Me.Gbox_datos_paciente.Controls.Add(Me.Apellidos)
        Me.Gbox_datos_paciente.Controls.Add(Me.Nombre)
        Me.Gbox_datos_paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbox_datos_paciente.Location = New System.Drawing.Point(16, 40)
        Me.Gbox_datos_paciente.Name = "Gbox_datos_paciente"
        Me.Gbox_datos_paciente.Size = New System.Drawing.Size(784, 150)
        Me.Gbox_datos_paciente.TabIndex = 0
        Me.Gbox_datos_paciente.TabStop = False
        Me.Gbox_datos_paciente.Text = "Datos de paciente"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(627, 32)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(149, 26)
        Me.TextBox5.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(407, 104)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(214, 26)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(407, 35)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(113, 26)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(118, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 26)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Numero
        '
        Me.Numero.AutoSize = True
        Me.Numero.Location = New System.Drawing.Point(545, 38)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(76, 20)
        Me.Numero.TabIndex = 4
        Me.Numero.Text = "Número:"
        '
        'Cedula
        '
        Me.Cedula.AutoSize = True
        Me.Cedula.Location = New System.Drawing.Point(335, 107)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(75, 20)
        Me.Cedula.TabIndex = 3
        Me.Cedula.Text = "Cédula: "
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Id.Location = New System.Drawing.Point(362, 41)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(30, 20)
        Me.Id.TabIndex = 2
        Me.Id.Text = "Id:"
        '
        'Apellidos
        '
        Me.Apellidos.AutoSize = True
        Me.Apellidos.Location = New System.Drawing.Point(28, 107)
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.Size = New System.Drawing.Size(87, 20)
        Me.Apellidos.TabIndex = 1
        Me.Apellidos.Text = "Apellidos:"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(30, 41)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(85, 20)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Nombres:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(398, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Precio"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(463, 33)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(177, 26)
        Me.TextBox6.TabIndex = 7
        '
        'Listratamiento
        '
        Me.Listratamiento.FormattingEnabled = True
        Me.Listratamiento.Location = New System.Drawing.Point(358, 45)
        Me.Listratamiento.Name = "Listratamiento"
        Me.Listratamiento.Size = New System.Drawing.Size(224, 147)
        Me.Listratamiento.TabIndex = 9
        '
        'ListbPrecio
        '
        Me.ListbPrecio.FormattingEnabled = True
        Me.ListbPrecio.Location = New System.Drawing.Point(591, 45)
        Me.ListbPrecio.Name = "ListbPrecio"
        Me.ListbPrecio.Size = New System.Drawing.Size(96, 147)
        Me.ListbPrecio.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelPrecio)
        Me.GroupBox1.Controls.Add(Me.Tratamiento)
        Me.GroupBox1.Controls.Add(Me.Datos_Pac)
        Me.GroupBox1.Controls.Add(Me.Item)
        Me.GroupBox1.Controls.Add(Me.ListBoxDatos_PAC)
        Me.GroupBox1.Controls.Add(Me.ListbPrecio)
        Me.GroupBox1.Controls.Add(Me.Listratamiento)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 354)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 251)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ListBoxDatos_PAC
        '
        Me.ListBoxDatos_PAC.FormattingEnabled = True
        Me.ListBoxDatos_PAC.Location = New System.Drawing.Point(15, 43)
        Me.ListBoxDatos_PAC.Name = "ListBoxDatos_PAC"
        Me.ListBoxDatos_PAC.Size = New System.Drawing.Size(331, 147)
        Me.ListBoxDatos_PAC.TabIndex = 8
        '
        'Item
        '
        Me.Item.AutoSize = True
        Me.Item.Location = New System.Drawing.Point(19, 27)
        Me.Item.Name = "Item"
        Me.Item.Size = New System.Drawing.Size(0, 13)
        Me.Item.TabIndex = 6
        '
        'Datos_Pac
        '
        Me.Datos_Pac.AutoSize = True
        Me.Datos_Pac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datos_Pac.Location = New System.Drawing.Point(35, 27)
        Me.Datos_Pac.Name = "Datos_Pac"
        Me.Datos_Pac.Size = New System.Drawing.Size(111, 13)
        Me.Datos_Pac.TabIndex = 7
        Me.Datos_Pac.Text = "Datos de paciente"
        '
        'Tratamiento
        '
        Me.Tratamiento.AutoSize = True
        Me.Tratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tratamiento.Location = New System.Drawing.Point(365, 25)
        Me.Tratamiento.Name = "Tratamiento"
        Me.Tratamiento.Size = New System.Drawing.Size(78, 13)
        Me.Tratamiento.TabIndex = 8
        Me.Tratamiento.Text = "Tratamiento "
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecio.Location = New System.Drawing.Point(580, 24)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(47, 13)
        Me.LabelPrecio.TabIndex = 9
        Me.LabelPrecio.Text = "Precio "
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 704)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Gbox_Datos_precio.ResumeLayout(False)
        Me.Gbox_Datos_precio.PerformLayout()
        Me.Gbox_datos_paciente.ResumeLayout(False)
        Me.Gbox_datos_paciente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Gbox_Datos_precio As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Servicio As Label
    Friend WithEvents Gbox_datos_paciente As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Numero As Label
    Friend WithEvents Cedula As Label
    Friend WithEvents Id As Label
    Friend WithEvents Apellidos As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListbPrecio As ListBox
    Friend WithEvents Listratamiento As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents Tratamiento As Label
    Friend WithEvents Datos_Pac As Label
    Friend WithEvents Item As Label
    Friend WithEvents ListBoxDatos_PAC As ListBox
End Class
