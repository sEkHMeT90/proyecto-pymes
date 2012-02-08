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
        Me.CBoxHora = New System.Windows.Forms.ComboBox()
        Me.CBoxMin = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DPCita = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBoxServicios = New System.Windows.Forms.ComboBox()
        Me.CBoxEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBoxCliente = New System.Windows.Forms.ComboBox()
        Me.ListBServicios = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PBBorrarC = New System.Windows.Forms.PictureBox()
        Me.PBCancelarC = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PBAceptarC = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CBoxHora
        '
        Me.CBoxHora.BackColor = System.Drawing.Color.Thistle
        Me.CBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxHora.FormattingEnabled = True
        Me.CBoxHora.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.CBoxHora.Location = New System.Drawing.Point(206, 240)
        Me.CBoxHora.Name = "CBoxHora"
        Me.CBoxHora.Size = New System.Drawing.Size(64, 21)
        Me.CBoxHora.TabIndex = 3
        '
        'CBoxMin
        '
        Me.CBoxMin.BackColor = System.Drawing.Color.Thistle
        Me.CBoxMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxMin.FormattingEnabled = True
        Me.CBoxMin.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.CBoxMin.Location = New System.Drawing.Point(344, 240)
        Me.CBoxMin.Name = "CBoxMin"
        Me.CBoxMin.Size = New System.Drawing.Size(64, 21)
        Me.CBoxMin.TabIndex = 4
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
        'DPCita
        '
        Me.DPCita.Location = New System.Drawing.Point(206, 184)
        Me.DPCita.Name = "DPCita"
        Me.DPCita.Size = New System.Drawing.Size(202, 20)
        Me.DPCita.TabIndex = 2
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
        'CBoxServicios
        '
        Me.CBoxServicios.BackColor = System.Drawing.Color.Thistle
        Me.CBoxServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxServicios.FormattingEnabled = True
        Me.CBoxServicios.Items.AddRange(New Object() {"Lavar", "Cortar", "Secar", "Tinte", "Permanente"})
        Me.CBoxServicios.Location = New System.Drawing.Point(206, 291)
        Me.CBoxServicios.Name = "CBoxServicios"
        Me.CBoxServicios.Size = New System.Drawing.Size(201, 21)
        Me.CBoxServicios.TabIndex = 5
        '
        'CBoxEmpleado
        '
        Me.CBoxEmpleado.BackColor = System.Drawing.Color.Thistle
        Me.CBoxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxEmpleado.FormattingEnabled = True
        Me.CBoxEmpleado.Items.AddRange(New Object() {"Andres Marotta", "Pedro Zalacain", "Raquel Llorens", "María Navarro"})
        Me.CBoxEmpleado.Location = New System.Drawing.Point(206, 347)
        Me.CBoxEmpleado.Name = "CBoxEmpleado"
        Me.CBoxEmpleado.Size = New System.Drawing.Size(201, 21)
        Me.CBoxEmpleado.TabIndex = 6
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
        'CBoxCliente
        '
        Me.CBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxCliente.FormattingEnabled = True
        Me.CBoxCliente.Location = New System.Drawing.Point(206, 129)
        Me.CBoxCliente.Name = "CBoxCliente"
        Me.CBoxCliente.Size = New System.Drawing.Size(202, 21)
        Me.CBoxCliente.TabIndex = 1
        '
        'ListBServicios
        '
        Me.ListBServicios.FormattingEnabled = True
        Me.ListBServicios.Location = New System.Drawing.Point(500, 169)
        Me.ListBServicios.Name = "ListBServicios"
        Me.ListBServicios.Size = New System.Drawing.Size(197, 199)
        Me.ListBServicios.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(441, 313)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "7"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(548, 468)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 16)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Cancelar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(361, 468)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 16)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Borrar"
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(175, 468)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 16)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Aceptar"
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
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PBBorrarC)
        Me.Controls.Add(Me.PBCancelarC)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PBAceptarC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBServicios)
        Me.Controls.Add(Me.CBoxCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBoxEmpleado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBoxServicios)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DPCita)
        Me.Controls.Add(Me.CBoxMin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBoxHora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "NuevaCita"
        Me.Text = "Nueva Cita"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBorrarC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCancelarC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAceptarC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBoxHora As System.Windows.Forms.ComboBox
    Friend WithEvents CBoxMin As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DPCita As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBoxServicios As System.Windows.Forms.ComboBox
    Friend WithEvents CBoxEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBoxCliente As System.Windows.Forms.ComboBox
    Friend WithEvents ListBServicios As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PBBorrarC As System.Windows.Forms.PictureBox
    Friend WithEvents PBCancelarC As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PBAceptarC As System.Windows.Forms.PictureBox
End Class
