﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dg_registro = New System.Windows.Forms.DataGridView()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Txt_telefono = New System.Windows.Forms.TextBox()
        Me.Txt_sexo = New System.Windows.Forms.TextBox()
        Me.Txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.txt_apellidos = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Txt_id = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ClinicaDBDataSet = New Clinica.ClinicaDBDataSet()
        Me.ClinicaDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Aquamarine
        Me.GroupBox3.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(0, -6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1103, 160)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(387, 121)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(299, 23)
        Me.DateTimePicker3.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(821, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(186, 130)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(565, 31)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Bienvenido a la clínica del Dr. Egnio Aráuz"
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox.Controls.Add(Me.PictureBox6)
        Me.GroupBox.Controls.Add(Me.Button1)
        Me.GroupBox.Controls.Add(Me.IconButton1)
        Me.GroupBox.Controls.Add(Me.PictureBox5)
        Me.GroupBox.Controls.Add(Me.PictureBox4)
        Me.GroupBox.Controls.Add(Me.GroupBox4)
        Me.GroupBox.Controls.Add(Me.dg_registro)
        Me.GroupBox.Controls.Add(Me.TextBox21)
        Me.GroupBox.Controls.Add(Me.Label26)
        Me.GroupBox.Controls.Add(Me.bt_eliminar)
        Me.GroupBox.Controls.Add(Me.bt_guardar)
        Me.GroupBox.Controls.Add(Me.TextBox20)
        Me.GroupBox.Controls.Add(Me.TextBox19)
        Me.GroupBox.Controls.Add(Me.TextBox18)
        Me.GroupBox.Controls.Add(Me.Txt_telefono)
        Me.GroupBox.Controls.Add(Me.Txt_sexo)
        Me.GroupBox.Controls.Add(Me.Txt_cedula)
        Me.GroupBox.Controls.Add(Me.txt_nombres)
        Me.GroupBox.Controls.Add(Me.txt_apellidos)
        Me.GroupBox.Controls.Add(Me.TextBox12)
        Me.GroupBox.Controls.Add(Me.Txt_id)
        Me.GroupBox.Controls.Add(Me.Label25)
        Me.GroupBox.Controls.Add(Me.Label24)
        Me.GroupBox.Controls.Add(Me.Label23)
        Me.GroupBox.Controls.Add(Me.Label22)
        Me.GroupBox.Controls.Add(Me.Label21)
        Me.GroupBox.Controls.Add(Me.Label20)
        Me.GroupBox.Controls.Add(Me.Label19)
        Me.GroupBox.Controls.Add(Me.Label18)
        Me.GroupBox.Controls.Add(Me.Label17)
        Me.GroupBox.Controls.Add(Me.Label16)
        Me.GroupBox.Controls.Add(Me.Label15)
        Me.GroupBox.Controls.Add(Me.Label14)
        Me.GroupBox.Controls.Add(Me.Label13)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(0, 154)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(1103, 800)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Datos Generales del Paciente"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(902, 417)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 42
        Me.PictureBox6.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(938, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 34)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Crear factura"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Backspace
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 25)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(45, 45)
        Me.IconButton1.TabIndex = 40
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(30, 482)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 39
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(30, 417)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 38
        Me.PictureBox4.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Aquamarine
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Location = New System.Drawing.Point(362, 417)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(366, 57)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(309, 31)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "Registro de Pacientes "
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(318, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'dg_registro
        '
        Me.dg_registro.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dg_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_registro.Location = New System.Drawing.Point(192, 503)
        Me.dg_registro.Name = "dg_registro"
        Me.dg_registro.Size = New System.Drawing.Size(691, 256)
        Me.dg_registro.TabIndex = 34
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(766, 285)
        Me.TextBox21.Multiline = True
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox21.Size = New System.Drawing.Size(169, 91)
        Me.TextBox21.TabIndex = 28
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(674, 319)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(63, 17)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "Reporte:"
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.Red
        Me.bt_eliminar.Location = New System.Drawing.Point(63, 482)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(84, 34)
        Me.bt_eliminar.TabIndex = 24
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_eliminar.UseVisualStyleBackColor = False
        '
        'bt_guardar
        '
        Me.bt_guardar.BackColor = System.Drawing.Color.RoyalBlue
        Me.bt_guardar.ForeColor = System.Drawing.Color.Transparent
        Me.bt_guardar.Location = New System.Drawing.Point(63, 417)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(84, 34)
        Me.bt_guardar.TabIndex = 23
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = False
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(766, 70)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(169, 26)
        Me.TextBox20.TabIndex = 9
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(766, 151)
        Me.TextBox19.Multiline = True
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox19.Size = New System.Drawing.Size(169, 91)
        Me.TextBox19.TabIndex = 10
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(472, 287)
        Me.TextBox18.Multiline = True
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox18.Size = New System.Drawing.Size(169, 91)
        Me.TextBox18.TabIndex = 8
        '
        'Txt_telefono
        '
        Me.Txt_telefono.Location = New System.Drawing.Point(472, 73)
        Me.Txt_telefono.Name = "Txt_telefono"
        Me.Txt_telefono.Size = New System.Drawing.Size(169, 26)
        Me.Txt_telefono.TabIndex = 5
        '
        'Txt_sexo
        '
        Me.Txt_sexo.Location = New System.Drawing.Point(472, 144)
        Me.Txt_sexo.Name = "Txt_sexo"
        Me.Txt_sexo.Size = New System.Drawing.Size(169, 26)
        Me.Txt_sexo.TabIndex = 6
        '
        'Txt_cedula
        '
        Me.Txt_cedula.Location = New System.Drawing.Point(472, 221)
        Me.Txt_cedula.Name = "Txt_cedula"
        Me.Txt_cedula.Size = New System.Drawing.Size(169, 26)
        Me.Txt_cedula.TabIndex = 7
        '
        'txt_nombres
        '
        Me.txt_nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombres.Location = New System.Drawing.Point(97, 144)
        Me.txt_nombres.Multiline = True
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(169, 26)
        Me.txt_nombres.TabIndex = 2
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellidos.Location = New System.Drawing.Point(97, 221)
        Me.txt_apellidos.Multiline = True
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(169, 26)
        Me.txt_apellidos.TabIndex = 3
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(97, 287)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox12.Size = New System.Drawing.Size(169, 91)
        Me.TextBox12.TabIndex = 4
        '
        'Txt_id
        '
        Me.Txt_id.Location = New System.Drawing.Point(97, 73)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(169, 26)
        Me.Txt_id.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(272, 319)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(161, 17)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Padecimiento Sistémico:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(514, 276)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 17)
        Me.Label24.TabIndex = 11
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(657, 179)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 17)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Diagnóstico:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(543, 264)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 17)
        Me.Label22.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(565, 253)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 17)
        Me.Label21.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(691, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 17)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Email:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 319)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 17)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Dirección:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(400, 228)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 17)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Cédula:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(388, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 17)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Teléfono:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 151)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 17)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Nombres:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(415, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Sexo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Apellidos:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(60, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 17)
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
        'FormPrincipal
        '
        Me.ClientSize = New System.Drawing.Size(1104, 952)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FormPrincipal"
        Me.Text = "FrmPricipal"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_registro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents txt_apellidos As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Txt_id As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Txt_telefono As TextBox
    Friend WithEvents Txt_sexo As TextBox
    Friend WithEvents Txt_cedula As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents dg_registro As DataGridView
    Friend WithEvents ClinicaDBDataSetBindingSource As BindingSource
    Friend WithEvents ClinicaDBDataSet As ClinicaDBDataSet
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button1 As Button
End Class