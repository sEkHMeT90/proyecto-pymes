<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarEmpleado))
        Me.LBoxME = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CBEspecialidadE = New System.Windows.Forms.ComboBox()
        Me.TBSueldoE = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBNumSSE = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBEmailE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBMovilE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBFijoE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBDniE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBApellido2E = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBApellido1E = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNombreE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBBorrarMC = New System.Windows.Forms.PictureBox()
        Me.PBModificarMC = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBProvinciaU = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBPoblacionU = New System.Windows.Forms.ComboBox()
        Me.TBPisoMU = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBNumeroMU = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBCalleMU = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBBorrarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBModificarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBoxME
        '
        Me.LBoxME.FormattingEnabled = True
        Me.LBoxME.Location = New System.Drawing.Point(37, 110)
        Me.LBoxME.Name = "LBoxME"
        Me.LBoxME.Size = New System.Drawing.Size(221, 394)
        Me.LBoxME.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.CBEspecialidadE)
        Me.GroupBox1.Controls.Add(Me.TBSueldoE)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TBNumSSE)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TBEmailE)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TBMovilE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBFijoE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBDniE)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBApellido2E)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBApellido1E)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNombreE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PBBorrarMC)
        Me.GroupBox1.Controls.Add(Me.PBModificarMC)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CBProvinciaU)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.CBPoblacionU)
        Me.GroupBox1.Controls.Add(Me.TBPisoMU)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TBNumeroMU)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TBCalleMU)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(287, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 494)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Empleado"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(343, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 20)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Ocupación"
        '
        'CBEspecialidadE
        '
        Me.CBEspecialidadE.BackColor = System.Drawing.Color.Thistle
        Me.CBEspecialidadE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEspecialidadE.FormattingEnabled = True
        Me.CBEspecialidadE.Items.AddRange(New Object() {"Peluquero", "Esteticien", "Color"})
        Me.CBEspecialidadE.Location = New System.Drawing.Point(439, 44)
        Me.CBEspecialidadE.Name = "CBEspecialidadE"
        Me.CBEspecialidadE.Size = New System.Drawing.Size(189, 24)
        Me.CBEspecialidadE.TabIndex = 77
        '
        'TBSueldoE
        '
        Me.TBSueldoE.BackColor = System.Drawing.Color.Thistle
        Me.TBSueldoE.ForeColor = System.Drawing.Color.Black
        Me.TBSueldoE.Location = New System.Drawing.Point(126, 453)
        Me.TBSueldoE.Name = "TBSueldoE"
        Me.TBSueldoE.Size = New System.Drawing.Size(190, 22)
        Me.TBSueldoE.TabIndex = 72
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(9, 453)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 20)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Sueldo"
        '
        'TBNumSSE
        '
        Me.TBNumSSE.BackColor = System.Drawing.Color.Thistle
        Me.TBNumSSE.ForeColor = System.Drawing.Color.Black
        Me.TBNumSSE.Location = New System.Drawing.Point(126, 402)
        Me.TBNumSSE.Name = "TBNumSSE"
        Me.TBNumSSE.Size = New System.Drawing.Size(190, 22)
        Me.TBNumSSE.TabIndex = 70
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(9, 402)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 20)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Nº SS"
        '
        'TBEmailE
        '
        Me.TBEmailE.BackColor = System.Drawing.Color.Thistle
        Me.TBEmailE.ForeColor = System.Drawing.Color.Black
        Me.TBEmailE.Location = New System.Drawing.Point(126, 354)
        Me.TBEmailE.Name = "TBEmailE"
        Me.TBEmailE.Size = New System.Drawing.Size(190, 22)
        Me.TBEmailE.TabIndex = 69
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(9, 354)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Email"
        '
        'TBMovilE
        '
        Me.TBMovilE.BackColor = System.Drawing.Color.Thistle
        Me.TBMovilE.ForeColor = System.Drawing.Color.Black
        Me.TBMovilE.Location = New System.Drawing.Point(126, 302)
        Me.TBMovilE.Name = "TBMovilE"
        Me.TBMovilE.Size = New System.Drawing.Size(190, 22)
        Me.TBMovilE.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Movil"
        '
        'TBFijoE
        '
        Me.TBFijoE.BackColor = System.Drawing.Color.Thistle
        Me.TBFijoE.ForeColor = System.Drawing.Color.Black
        Me.TBFijoE.Location = New System.Drawing.Point(126, 250)
        Me.TBFijoE.Name = "TBFijoE"
        Me.TBFijoE.Size = New System.Drawing.Size(190, 22)
        Me.TBFijoE.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Fijo"
        '
        'TBDniE
        '
        Me.TBDniE.BackColor = System.Drawing.Color.Thistle
        Me.TBDniE.ForeColor = System.Drawing.Color.Black
        Me.TBDniE.Location = New System.Drawing.Point(126, 199)
        Me.TBDniE.Name = "TBDniE"
        Me.TBDniE.Size = New System.Drawing.Size(190, 22)
        Me.TBDniE.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 20)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Dni"
        '
        'TBApellido2E
        '
        Me.TBApellido2E.BackColor = System.Drawing.Color.Thistle
        Me.TBApellido2E.ForeColor = System.Drawing.Color.Black
        Me.TBApellido2E.Location = New System.Drawing.Point(126, 147)
        Me.TBApellido2E.Name = "TBApellido2E"
        Me.TBApellido2E.Size = New System.Drawing.Size(190, 22)
        Me.TBApellido2E.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Apellido 2"
        '
        'TBApellido1E
        '
        Me.TBApellido1E.BackColor = System.Drawing.Color.Thistle
        Me.TBApellido1E.ForeColor = System.Drawing.Color.Black
        Me.TBApellido1E.Location = New System.Drawing.Point(126, 95)
        Me.TBApellido1E.Name = "TBApellido1E"
        Me.TBApellido1E.Size = New System.Drawing.Size(190, 22)
        Me.TBApellido1E.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Apellido 1"
        '
        'TBNombreE
        '
        Me.TBNombreE.BackColor = System.Drawing.Color.Thistle
        Me.TBNombreE.ForeColor = System.Drawing.Color.Black
        Me.TBNombreE.Location = New System.Drawing.Point(126, 44)
        Me.TBNombreE.Name = "TBNombreE"
        Me.TBNombreE.Size = New System.Drawing.Size(190, 22)
        Me.TBNombreE.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Nombre"
        '
        'PBBorrarMC
        '
        Me.PBBorrarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBBorrarMC.Location = New System.Drawing.Point(558, 402)
        Me.PBBorrarMC.Name = "PBBorrarMC"
        Me.PBBorrarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBBorrarMC.TabIndex = 58
        Me.PBBorrarMC.TabStop = False
        '
        'PBModificarMC
        '
        Me.PBModificarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBModificarMC.Location = New System.Drawing.Point(401, 402)
        Me.PBModificarMC.Name = "PBModificarMC"
        Me.PBModificarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBModificarMC.TabIndex = 57
        Me.PBModificarMC.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(341, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 20)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Provincia"
        '
        'CBProvinciaU
        '
        Me.CBProvinciaU.BackColor = System.Drawing.Color.Thistle
        Me.CBProvinciaU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProvinciaU.FormattingEnabled = True
        Me.CBProvinciaU.Location = New System.Drawing.Point(439, 188)
        Me.CBProvinciaU.Name = "CBProvinciaU"
        Me.CBProvinciaU.Size = New System.Drawing.Size(191, 24)
        Me.CBProvinciaU.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(341, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Población"
        '
        'CBPoblacionU
        '
        Me.CBPoblacionU.BackColor = System.Drawing.Color.Thistle
        Me.CBPoblacionU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPoblacionU.FormattingEnabled = True
        Me.CBPoblacionU.Location = New System.Drawing.Point(439, 239)
        Me.CBPoblacionU.Name = "CBPoblacionU"
        Me.CBPoblacionU.Size = New System.Drawing.Size(189, 24)
        Me.CBPoblacionU.TabIndex = 51
        '
        'TBPisoMU
        '
        Me.TBPisoMU.BackColor = System.Drawing.Color.Thistle
        Me.TBPisoMU.ForeColor = System.Drawing.Color.Black
        Me.TBPisoMU.Location = New System.Drawing.Point(570, 139)
        Me.TBPisoMU.Name = "TBPisoMU"
        Me.TBPisoMU.Size = New System.Drawing.Size(60, 22)
        Me.TBPisoMU.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(512, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Piso"
        '
        'TBNumeroMU
        '
        Me.TBNumeroMU.BackColor = System.Drawing.Color.Thistle
        Me.TBNumeroMU.ForeColor = System.Drawing.Color.Black
        Me.TBNumeroMU.Location = New System.Drawing.Point(439, 139)
        Me.TBNumeroMU.Name = "TBNumeroMU"
        Me.TBNumeroMU.Size = New System.Drawing.Size(55, 22)
        Me.TBNumeroMU.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(343, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 20)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Nº"
        '
        'TBCalleMU
        '
        Me.TBCalleMU.BackColor = System.Drawing.Color.Thistle
        Me.TBCalleMU.ForeColor = System.Drawing.Color.Black
        Me.TBCalleMU.Location = New System.Drawing.Point(439, 89)
        Me.TBCalleMU.Name = "TBCalleMU"
        Me.TBCalleMU.Size = New System.Drawing.Size(191, 22)
        Me.TBCalleMU.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(343, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Calle"
        '
        'ModificarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 622)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBoxME)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ModificarEmpleado"
        Me.Text = "ModificarEmpleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBBorrarMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBModificarMC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LBoxME As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PBBorrarMC As System.Windows.Forms.PictureBox
    Friend WithEvents PBModificarMC As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CBProvinciaU As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CBPoblacionU As System.Windows.Forms.ComboBox
    Friend WithEvents TBPisoMU As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBNumeroMU As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBCalleMU As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TBSueldoE As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TBNumSSE As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TBEmailE As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TBMovilE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBFijoE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBDniE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBApellido2E As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBApellido1E As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNombreE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CBEspecialidadE As System.Windows.Forms.ComboBox
End Class
