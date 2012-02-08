<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaCita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaCita))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBoxHoraC = New System.Windows.Forms.ComboBox()
        Me.CBoxMinC = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DPCitaC = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBoxServiciosC = New System.Windows.Forms.ComboBox()
        Me.CBoxEmpleadoC = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBoxClienteC = New System.Windows.Forms.ComboBox()
        Me.ListBServiciosC = New System.Windows.Forms.ListBox()
        Me.PBMenosC = New System.Windows.Forms.PictureBox()
        Me.LblCancelarC = New System.Windows.Forms.Label()
        Me.LblBorrarC = New System.Windows.Forms.Label()
        Me.PBBorrarC = New System.Windows.Forms.PictureBox()
        Me.PBCancelarC = New System.Windows.Forms.PictureBox()
        Me.LblAceptarC = New System.Windows.Forms.Label()
        Me.PBAceptarC = New System.Windows.Forms.PictureBox()
        CType(Me.PBMenosC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBorrarC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCancelarC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAceptarC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(89, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Hora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(89, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(89, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cliente"
        '
        'CBoxHoraC
        '
        Me.CBoxHoraC.BackColor = System.Drawing.Color.Thistle
        Me.CBoxHoraC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxHoraC.FormattingEnabled = True
        Me.CBoxHoraC.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.CBoxHoraC.Location = New System.Drawing.Point(206, 240)
        Me.CBoxHoraC.Name = "CBoxHoraC"
        Me.CBoxHoraC.Size = New System.Drawing.Size(64, 21)
        Me.CBoxHoraC.TabIndex = 3
        '
        'CBoxMinC
        '
        Me.CBoxMinC.BackColor = System.Drawing.Color.Thistle
        Me.CBoxMinC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxMinC.FormattingEnabled = True
        Me.CBoxMinC.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.CBoxMinC.Location = New System.Drawing.Point(344, 240)
        Me.CBoxMinC.Name = "CBoxMinC"
        Me.CBoxMinC.Size = New System.Drawing.Size(64, 21)
        Me.CBoxMinC.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(288, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Min"
        '
        'DPCitaC
        '
        Me.DPCitaC.Location = New System.Drawing.Point(206, 184)
        Me.DPCitaC.Name = "DPCitaC"
        Me.DPCitaC.Size = New System.Drawing.Size(202, 20)
        Me.DPCitaC.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(89, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Servicios"
        '
        'CBoxServiciosC
        '
        Me.CBoxServiciosC.BackColor = System.Drawing.Color.Thistle
        Me.CBoxServiciosC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxServiciosC.FormattingEnabled = True
        Me.CBoxServiciosC.Items.AddRange(New Object() {"Lavar", "Cortar", "Secar", "Tinte", "Permanente"})
        Me.CBoxServiciosC.Location = New System.Drawing.Point(206, 291)
        Me.CBoxServiciosC.Name = "CBoxServiciosC"
        Me.CBoxServiciosC.Size = New System.Drawing.Size(201, 21)
        Me.CBoxServiciosC.TabIndex = 5
        '
        'CBoxEmpleadoC
        '
        Me.CBoxEmpleadoC.BackColor = System.Drawing.Color.Thistle
        Me.CBoxEmpleadoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxEmpleadoC.FormattingEnabled = True
        Me.CBoxEmpleadoC.Items.AddRange(New Object() {"Andres Marotta", "Pedro Zalacain", "Raquel Llorens", "María Navarro"})
        Me.CBoxEmpleadoC.Location = New System.Drawing.Point(206, 347)
        Me.CBoxEmpleadoC.Name = "CBoxEmpleadoC"
        Me.CBoxEmpleadoC.Size = New System.Drawing.Size(201, 21)
        Me.CBoxEmpleadoC.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(89, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Empleado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(559, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Servicios"
        '
        'CBoxClienteC
        '
        Me.CBoxClienteC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxClienteC.FormattingEnabled = True
        Me.CBoxClienteC.Location = New System.Drawing.Point(206, 129)
        Me.CBoxClienteC.Name = "CBoxClienteC"
        Me.CBoxClienteC.Size = New System.Drawing.Size(202, 21)
        Me.CBoxClienteC.TabIndex = 1
        '
        'ListBServiciosC
        '
        Me.ListBServiciosC.FormattingEnabled = True
        Me.ListBServiciosC.Location = New System.Drawing.Point(500, 169)
        Me.ListBServiciosC.Name = "ListBServiciosC"
        Me.ListBServiciosC.Size = New System.Drawing.Size(197, 199)
        Me.ListBServiciosC.TabIndex = 8
        '
        'PBMenosC
        '
        Me.PBMenosC.BackColor = System.Drawing.Color.Transparent
        Me.PBMenosC.BackgroundImage = CType(resources.GetObject("PBMenosC.BackgroundImage"), System.Drawing.Image)
        Me.PBMenosC.Location = New System.Drawing.Point(441, 313)
        Me.PBMenosC.Name = "PBMenosC"
        Me.PBMenosC.Size = New System.Drawing.Size(35, 35)
        Me.PBMenosC.TabIndex = 47
        Me.PBMenosC.TabStop = False
        Me.PBMenosC.Tag = "7"
        '
        'LblCancelarC
        '
        Me.LblCancelarC.AutoSize = True
        Me.LblCancelarC.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelarC.ForeColor = System.Drawing.Color.White
        Me.LblCancelarC.Location = New System.Drawing.Point(548, 468)
        Me.LblCancelarC.Name = "LblCancelarC"
        Me.LblCancelarC.Size = New System.Drawing.Size(70, 16)
        Me.LblCancelarC.TabIndex = 63
        Me.LblCancelarC.Text = "Cancelar"
        '
        'LblBorrarC
        '
        Me.LblBorrarC.AutoSize = True
        Me.LblBorrarC.BackColor = System.Drawing.Color.Transparent
        Me.LblBorrarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBorrarC.ForeColor = System.Drawing.Color.White
        Me.LblBorrarC.Location = New System.Drawing.Point(361, 468)
        Me.LblBorrarC.Name = "LblBorrarC"
        Me.LblBorrarC.Size = New System.Drawing.Size(51, 16)
        Me.LblBorrarC.TabIndex = 62
        Me.LblBorrarC.Text = "Borrar"
        '
        'PBBorrarC
        '
        Me.PBBorrarC.BackColor = System.Drawing.Color.Transparent
        Me.PBBorrarC.BackgroundImage = CType(resources.GetObject("PBBorrarC.BackgroundImage"), System.Drawing.Image)
        Me.PBBorrarC.Location = New System.Drawing.Point(344, 458)
        Me.PBBorrarC.Name = "PBBorrarC"
        Me.PBBorrarC.Size = New System.Drawing.Size(92, 37)
        Me.PBBorrarC.TabIndex = 61
        Me.PBBorrarC.TabStop = False
        '
        'PBCancelarC
        '
        Me.PBCancelarC.BackColor = System.Drawing.Color.Transparent
        Me.PBCancelarC.BackgroundImage = CType(resources.GetObject("PBCancelarC.BackgroundImage"), System.Drawing.Image)
        Me.PBCancelarC.Location = New System.Drawing.Point(537, 458)
        Me.PBCancelarC.Name = "PBCancelarC"
        Me.PBCancelarC.Size = New System.Drawing.Size(92, 37)
        Me.PBCancelarC.TabIndex = 60
        Me.PBCancelarC.TabStop = False
        '
        'LblAceptarC
        '
        Me.LblAceptarC.AutoSize = True
        Me.LblAceptarC.BackColor = System.Drawing.Color.Transparent
        Me.LblAceptarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAceptarC.ForeColor = System.Drawing.Color.White
        Me.LblAceptarC.Location = New System.Drawing.Point(175, 468)
        Me.LblAceptarC.Name = "LblAceptarC"
        Me.LblAceptarC.Size = New System.Drawing.Size(62, 16)
        Me.LblAceptarC.TabIndex = 8
        Me.LblAceptarC.Text = "Aceptar"
        '
        'PBAceptarC
        '
        Me.PBAceptarC.BackColor = System.Drawing.Color.Transparent
        Me.PBAceptarC.BackgroundImage = CType(resources.GetObject("PBAceptarC.BackgroundImage"), System.Drawing.Image)
        Me.PBAceptarC.Location = New System.Drawing.Point(162, 458)
        Me.PBAceptarC.Name = "PBAceptarC"
        Me.PBAceptarC.Size = New System.Drawing.Size(92, 37)
        Me.PBAceptarC.TabIndex = 58
        Me.PBAceptarC.TabStop = False
        '
        'NuevaCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.LblCancelarC)
        Me.Controls.Add(Me.LblBorrarC)
        Me.Controls.Add(Me.PBBorrarC)
        Me.Controls.Add(Me.PBCancelarC)
        Me.Controls.Add(Me.LblAceptarC)
        Me.Controls.Add(Me.PBAceptarC)
        Me.Controls.Add(Me.PBMenosC)
        Me.Controls.Add(Me.ListBServiciosC)
        Me.Controls.Add(Me.CBoxClienteC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBoxEmpleadoC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBoxServiciosC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DPCitaC)
        Me.Controls.Add(Me.CBoxMinC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBoxHoraC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "NuevaCita"
        Me.Text = "Nueva Cita"
        CType(Me.PBMenosC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBorrarC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCancelarC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAceptarC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBoxHoraC As System.Windows.Forms.ComboBox
    Friend WithEvents CBoxMinC As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DPCitaC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBoxServiciosC As System.Windows.Forms.ComboBox
    Friend WithEvents CBoxEmpleadoC As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBoxClienteC As System.Windows.Forms.ComboBox
    Friend WithEvents ListBServiciosC As System.Windows.Forms.ListBox
    Friend WithEvents PBMenosC As System.Windows.Forms.PictureBox
    Friend WithEvents LblCancelarC As System.Windows.Forms.Label
    Friend WithEvents LblBorrarC As System.Windows.Forms.Label
    Friend WithEvents PBBorrarC As System.Windows.Forms.PictureBox
    Friend WithEvents PBCancelarC As System.Windows.Forms.PictureBox
    Friend WithEvents LblAceptarC As System.Windows.Forms.Label
    Friend WithEvents PBAceptarC As System.Windows.Forms.PictureBox
End Class
