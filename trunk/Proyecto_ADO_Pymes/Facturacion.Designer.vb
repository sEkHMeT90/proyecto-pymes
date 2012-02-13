<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturacion))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSLabEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PBCancelarMC = New System.Windows.Forms.PictureBox()
        Me.PBBorrarMC = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBServiciosF = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBoxEmpleadoF = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CBoxServiciosF = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DPCitaF = New System.Windows.Forms.DateTimePicker()
        Me.CBoxMinF = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CBoxHoraF = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TBClienteF = New System.Windows.Forms.TextBox()
        Me.TBDniF = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PBCancelarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBorrarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLabEstado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 510)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(744, 22)
        Me.StatusStrip1.TabIndex = 105
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSLabEstado
        '
        Me.TSLabEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLabEstado.ForeColor = System.Drawing.Color.White
        Me.TSLabEstado.Name = "TSLabEstado"
        Me.TSLabEstado.Size = New System.Drawing.Size(143, 17)
        Me.TSLabEstado.Text = "ToolStripStatusLabel1"
        '
        'PBCancelarMC
        '
        Me.PBCancelarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBCancelarMC.BackgroundImage = CType(resources.GetObject("PBCancelarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBCancelarMC.Location = New System.Drawing.Point(297, 425)
        Me.PBCancelarMC.Name = "PBCancelarMC"
        Me.PBCancelarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBCancelarMC.TabIndex = 103
        Me.PBCancelarMC.TabStop = False
        '
        'PBBorrarMC
        '
        Me.PBBorrarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBBorrarMC.BackgroundImage = CType(resources.GetObject("PBBorrarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBBorrarMC.Location = New System.Drawing.Point(166, 425)
        Me.PBBorrarMC.Name = "PBBorrarMC"
        Me.PBBorrarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBBorrarMC.TabIndex = 101
        Me.PBBorrarMC.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TBDniF)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TBClienteF)
        Me.GroupBox2.Controls.Add(Me.ListBServiciosF)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.CBoxEmpleadoF)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.CBoxServiciosF)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.DPCitaF)
        Me.GroupBox2.Controls.Add(Me.CBoxMinF)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.CBoxHoraF)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(39, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 356)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Cita"
        '
        'ListBServiciosF
        '
        Me.ListBServiciosF.FormattingEnabled = True
        Me.ListBServiciosF.ItemHeight = 16
        Me.ListBServiciosF.Location = New System.Drawing.Point(404, 133)
        Me.ListBServiciosF.Name = "ListBServiciosF"
        Me.ListBServiciosF.Size = New System.Drawing.Size(197, 196)
        Me.ListBServiciosF.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(450, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 20)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Servicios"
        '
        'CBoxEmpleadoF
        '
        Me.CBoxEmpleadoF.BackColor = System.Drawing.Color.Thistle
        Me.CBoxEmpleadoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxEmpleadoF.FormattingEnabled = True
        Me.CBoxEmpleadoF.Items.AddRange(New Object() {"Andres Marotta", "Pedro Zalacain", "Raquel Llorens", "María Navarro"})
        Me.CBoxEmpleadoF.Location = New System.Drawing.Point(127, 311)
        Me.CBoxEmpleadoF.Name = "CBoxEmpleadoF"
        Me.CBoxEmpleadoF.Size = New System.Drawing.Size(201, 24)
        Me.CBoxEmpleadoF.TabIndex = 54
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(10, 309)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 20)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Empleado"
        '
        'CBoxServiciosF
        '
        Me.CBoxServiciosF.BackColor = System.Drawing.Color.Thistle
        Me.CBoxServiciosF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxServiciosF.FormattingEnabled = True
        Me.CBoxServiciosF.Items.AddRange(New Object() {"Lavar", "Cortar", "Secar", "Tinte", "Permanente"})
        Me.CBoxServiciosF.Location = New System.Drawing.Point(127, 255)
        Me.CBoxServiciosF.Name = "CBoxServiciosF"
        Me.CBoxServiciosF.Size = New System.Drawing.Size(201, 24)
        Me.CBoxServiciosF.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(10, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 20)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Servicios"
        '
        'DPCitaF
        '
        Me.DPCitaF.Location = New System.Drawing.Point(127, 148)
        Me.DPCitaF.Name = "DPCitaF"
        Me.DPCitaF.Size = New System.Drawing.Size(202, 22)
        Me.DPCitaF.TabIndex = 49
        '
        'CBoxMinF
        '
        Me.CBoxMinF.BackColor = System.Drawing.Color.Thistle
        Me.CBoxMinF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxMinF.FormattingEnabled = True
        Me.CBoxMinF.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.CBoxMinF.Location = New System.Drawing.Point(265, 204)
        Me.CBoxMinF.Name = "CBoxMinF"
        Me.CBoxMinF.Size = New System.Drawing.Size(64, 24)
        Me.CBoxMinF.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(209, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 20)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Min"
        '
        'CBoxHoraF
        '
        Me.CBoxHoraF.BackColor = System.Drawing.Color.Thistle
        Me.CBoxHoraF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxHoraF.FormattingEnabled = True
        Me.CBoxHoraF.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.CBoxHoraF.Location = New System.Drawing.Point(127, 204)
        Me.CBoxHoraF.Name = "CBoxHoraF"
        Me.CBoxHoraF.Size = New System.Drawing.Size(64, 24)
        Me.CBoxHoraF.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(10, 202)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 20)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Hora"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(10, 147)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 20)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Fecha"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(10, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 20)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Cliente"
        '
        'TBClienteF
        '
        Me.TBClienteF.Location = New System.Drawing.Point(127, 44)
        Me.TBClienteF.Name = "TBClienteF"
        Me.TBClienteF.ReadOnly = True
        Me.TBClienteF.Size = New System.Drawing.Size(199, 22)
        Me.TBClienteF.TabIndex = 63
        '
        'TBDniF
        '
        Me.TBDniF.BackColor = System.Drawing.Color.White
        Me.TBDniF.ForeColor = System.Drawing.Color.Black
        Me.TBDniF.Location = New System.Drawing.Point(127, 95)
        Me.TBDniF.Name = "TBDniF"
        Me.TBDniF.Size = New System.Drawing.Size(202, 22)
        Me.TBDniF.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 20)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Dni"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(540, 425)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 58)
        Me.TextBox1.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(439, 463)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Total"
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 532)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PBCancelarMC)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PBBorrarMC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Facturacion"
        Me.Text = "Facturación"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PBCancelarMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBorrarMC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSLabEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PBCancelarMC As System.Windows.Forms.PictureBox
    Friend WithEvents PBBorrarMC As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBServiciosF As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CBoxEmpleadoF As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CBoxServiciosF As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DPCitaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBoxMinF As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CBoxHoraF As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TBDniF As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBClienteF As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
