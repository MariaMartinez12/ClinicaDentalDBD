<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dg_registro = New System.Windows.Forms.DataGridView()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ClinicaDBDataSet = New Clinica.ClinicaDBDataSet()
        Me.ClinicaDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        CType(Me.dg_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(0, -6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1103, 90)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.Location = New System.Drawing.Point(322, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(298, 25)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Datos Generales del Paciente"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(547, 382)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(299, 27)
        Me.DateTimePicker3.TabIndex = 3
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GroupBox.Controls.Add(Me.Label25)
        Me.GroupBox.Controls.Add(Me.TextBox13)
        Me.GroupBox.Controls.Add(Me.TextBox16)
        Me.GroupBox.Controls.Add(Me.TextBox11)
        Me.GroupBox.Controls.Add(Me.TextBox15)
        Me.GroupBox.Controls.Add(Me.TextBox19)
        Me.GroupBox.Controls.Add(Me.TextBox18)
        Me.GroupBox.Controls.Add(Me.Label23)
        Me.GroupBox.Controls.Add(Me.TextBox14)
        Me.GroupBox.Controls.Add(Me.Label15)
        Me.GroupBox.Controls.Add(Me.Label12)
        Me.GroupBox.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox.Controls.Add(Me.PictureBox5)
        Me.GroupBox.Controls.Add(Me.PictureBox4)
        Me.GroupBox.Controls.Add(Me.dg_registro)
        Me.GroupBox.Controls.Add(Me.bt_eliminar)
        Me.GroupBox.Controls.Add(Me.bt_guardar)
        Me.GroupBox.Controls.Add(Me.TextBox12)
        Me.GroupBox.Controls.Add(Me.Label24)
        Me.GroupBox.Controls.Add(Me.Label22)
        Me.GroupBox.Controls.Add(Me.Label21)
        Me.GroupBox.Controls.Add(Me.Label20)
        Me.GroupBox.Controls.Add(Me.Label19)
        Me.GroupBox.Controls.Add(Me.Label17)
        Me.GroupBox.Controls.Add(Me.Label16)
        Me.GroupBox.Controls.Add(Me.Label14)
        Me.GroupBox.Controls.Add(Me.Label13)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(0, 84)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(956, 921)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Location = New System.Drawing.Point(446, 166)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 25)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Nombre:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Location = New System.Drawing.Point(449, 251)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 25)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Apellido:"
        '
        'dg_registro
        '
        Me.dg_registro.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dg_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_registro.Location = New System.Drawing.Point(70, 506)
        Me.dg_registro.Name = "dg_registro"
        Me.dg_registro.RowHeadersWidth = 51
        Me.dg_registro.Size = New System.Drawing.Size(776, 316)
        Me.dg_registro.TabIndex = 34
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.Red
        Me.bt_eliminar.Location = New System.Drawing.Point(262, 448)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(105, 34)
        Me.bt_eliminar.TabIndex = 24
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_eliminar.UseVisualStyleBackColor = False
        '
        'bt_guardar
        '
        Me.bt_guardar.BackColor = System.Drawing.Color.RoyalBlue
        Me.bt_guardar.ForeColor = System.Drawing.Color.Transparent
        Me.bt_guardar.Location = New System.Drawing.Point(70, 448)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(110, 34)
        Me.bt_guardar.TabIndex = 23
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = False
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox12.Location = New System.Drawing.Point(151, 316)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox12.Size = New System.Drawing.Size(169, 91)
        Me.TextBox12.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(514, 276)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 20)
        Me.Label24.TabIndex = 11
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(543, 264)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 20)
        Me.Label22.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(565, 253)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 20)
        Me.Label21.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Location = New System.Drawing.Point(467, 321)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 25)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Email:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label19.Location = New System.Drawing.Point(46, 358)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 25)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Dirección:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Location = New System.Drawing.Point(446, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 25)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Teléfono:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Location = New System.Drawing.Point(58, 166)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 25)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Location = New System.Drawing.Point(57, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 25)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Apellido:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Location = New System.Drawing.Point(108, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ID:"
        '
        'ClinicaDBDataSet
        '
        Me.ClinicaDBDataSet.DataSetName = "ClinicaDBDataSet"
        Me.ClinicaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClinicaDBDataSetBindingSource
        '
        Me.ClinicaDBDataSetBindingSource.DataSource = Me.ClinicaDBDataSet
        Me.ClinicaDBDataSetBindingSource.Position = 0
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(151, 159)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(169, 32)
        Me.TextBox14.TabIndex = 47
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label23.Location = New System.Drawing.Point(460, 382)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 25)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Fecha:"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(213, 448)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(43, 33)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 39
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(30, 457)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 38
        Me.PictureBox4.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 84)
        Me.Button1.TabIndex = 45
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(151, 73)
        Me.TextBox18.Multiline = True
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(169, 32)
        Me.TextBox18.TabIndex = 54
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(151, 244)
        Me.TextBox19.Multiline = True
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(169, 32)
        Me.TextBox19.TabIndex = 55
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(547, 73)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(169, 32)
        Me.TextBox15.TabIndex = 56
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(547, 159)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(169, 32)
        Me.TextBox11.TabIndex = 57
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(549, 244)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(169, 32)
        Me.TextBox16.TabIndex = 58
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(547, 316)
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(171, 32)
        Me.TextBox13.TabIndex = 59
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.Location = New System.Drawing.Point(734, 323)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 25)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Scrollbar"
        '
        'FormPrincipal
        '
        Me.ClientSize = New System.Drawing.Size(950, 952)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FormPrincipal"
        Me.Text = "FrmPricipal"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.dg_registro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents dg_registro As DataGridView
    Friend WithEvents ClinicaDBDataSetBindingSource As BindingSource
    Friend WithEvents ClinicaDBDataSet As ClinicaDBDataSet
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label25 As Label
End Class
