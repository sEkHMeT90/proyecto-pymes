<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarCita))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBoxMCita = New System.Windows.Forms.ListBox()
        Me.CBoxHoraMC = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBoxMinMC = New System.Windows.Forms.ComboBox()
        Me.DPCitaMC = New System.Windows.Forms.DateTimePicker()
        Me.CBoxServiciosMC = New System.Windows.Forms.ComboBox()
        Me.CBoxEmpleadoMC = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBServiciosMC = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PBMenosMC = New System.Windows.Forms.PictureBox()
        Me.PBCancelarMC = New System.Windows.Forms.PictureBox()
        Me.PBBorrarMC = New System.Windows.Forms.PictureBox()
        Me.PBModificarMC = New System.Windows.Forms.PictureBox()
        Me.TBClienteMC = New System.Windows.Forms.TextBox()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.TSLabEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBMenosMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCancelarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBorrarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBModificarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Empleado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Servicios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Hora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Cliente"
        '
        'LBoxMCita
        '
        Me.LBoxMCita.FormattingEnabled = True
        Me.LBoxMCita.Location = New System.Drawing.Point(29, 103)
        Me.LBoxMCita.Name = "LBoxMCita"
        Me.LBoxMCita.Size = New System.Drawing.Size(188, 316)
        Me.LBoxMCita.TabIndex = 63
        '
        'CBoxHoraMC
        '
        Me.CBoxHoraMC.BackColor = System.Drawing.Color.Thistle
        Me.CBoxHoraMC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxHoraMC.FormattingEnabled = True
        Me.CBoxHoraMC.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.CBoxHoraMC.Location = New System.Drawing.Point(127, 152)
        Me.CBoxHoraMC.Name = "CBoxHoraMC"
        Me.CBoxHoraMC.Size = New System.Drawing.Size(64, 24)
        Me.CBoxHoraMC.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(209, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Min"
        '
        'CBoxMinMC
        '
        Me.CBoxMinMC.BackColor = System.Drawing.Color.Thistle
        Me.CBoxMinMC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxMinMC.FormattingEnabled = True
        Me.CBoxMinMC.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.CBoxMinMC.Location = New System.Drawing.Point(265, 152)
        Me.CBoxMinMC.Name = "CBoxMinMC"
        Me.CBoxMinMC.Size = New System.Drawing.Size(64, 24)
        Me.CBoxMinMC.TabIndex = 51
        '
        'DPCitaMC
        '
        Me.DPCitaMC.Location = New System.Drawing.Point(127, 96)
        Me.DPCitaMC.Name = "DPCitaMC"
        Me.DPCitaMC.Size = New System.Drawing.Size(202, 22)
        Me.DPCitaMC.TabIndex = 49
        '
        'CBoxServiciosMC
        '
        Me.CBoxServiciosMC.BackColor = System.Drawing.Color.Thistle
        Me.CBoxServiciosMC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxServiciosMC.FormattingEnabled = True
        Me.CBoxServiciosMC.Items.AddRange(New Object() {"Lavar", "Cortar", "Secar", "Tinte", "Permanente"})
        Me.CBoxServiciosMC.Location = New System.Drawing.Point(127, 203)
        Me.CBoxServiciosMC.Name = "CBoxServiciosMC"
        Me.CBoxServiciosMC.Size = New System.Drawing.Size(201, 24)
        Me.CBoxServiciosMC.TabIndex = 52
        '
        'CBoxEmpleadoMC
        '
        Me.CBoxEmpleadoMC.BackColor = System.Drawing.Color.Thistle
        Me.CBoxEmpleadoMC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxEmpleadoMC.FormattingEnabled = True
        Me.CBoxEmpleadoMC.Items.AddRange(New Object() {"Andres Marotta", "Pedro Zalacain", "Raquel Llorens", "María Navarro"})
        Me.CBoxEmpleadoMC.Location = New System.Drawing.Point(127, 259)
        Me.CBoxEmpleadoMC.Name = "CBoxEmpleadoMC"
        Me.CBoxEmpleadoMC.Size = New System.Drawing.Size(201, 24)
        Me.CBoxEmpleadoMC.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(463, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Servicios"
        '
        'ListBServiciosMC
        '
        Me.ListBServiciosMC.FormattingEnabled = True
        Me.ListBServiciosMC.ItemHeight = 16
        Me.ListBServiciosMC.Location = New System.Drawing.Point(404, 81)
        Me.ListBServiciosMC.Name = "ListBServiciosMC"
        Me.ListBServiciosMC.Size = New System.Drawing.Size(197, 196)
        Me.ListBServiciosMC.TabIndex = 55
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PBMenosMC)
        Me.GroupBox1.Controls.Add(Me.PBCancelarMC)
        Me.GroupBox1.Controls.Add(Me.PBBorrarMC)
        Me.GroupBox1.Controls.Add(Me.PBModificarMC)
        Me.GroupBox1.Controls.Add(Me.TBClienteMC)
        Me.GroupBox1.Controls.Add(Me.ListBServiciosMC)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CBoxEmpleadoMC)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CBoxServiciosMC)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DPCitaMC)
        Me.GroupBox1.Controls.Add(Me.CBoxMinMC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CBoxHoraMC)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(239, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 385)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cita"
        '
        'PBMenosMC
        '
        Me.PBMenosMC.BackColor = System.Drawing.Color.Transparent
        Me.PBMenosMC.BackgroundImage = CType(resources.GetObject("PBMenosMC.BackgroundImage"), System.Drawing.Image)
        Me.PBMenosMC.Location = New System.Drawing.Point(566, 296)
        Me.PBMenosMC.Name = "PBMenosMC"
        Me.PBMenosMC.Size = New System.Drawing.Size(35, 35)
        Me.PBMenosMC.TabIndex = 103
        Me.PBMenosMC.TabStop = False
        Me.PBMenosMC.Tag = "7"
        '
        'PBCancelarMC
        '
        Me.PBCancelarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBCancelarMC.BackgroundImage = CType(resources.GetObject("PBCancelarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBCancelarMC.Location = New System.Drawing.Point(416, 296)
        Me.PBCancelarMC.Name = "PBCancelarMC"
        Me.PBCancelarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBCancelarMC.TabIndex = 102
        Me.PBCancelarMC.TabStop = False
        '
        'PBBorrarMC
        '
        Me.PBBorrarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBBorrarMC.BackgroundImage = CType(resources.GetObject("PBBorrarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBBorrarMC.Location = New System.Drawing.Point(329, 296)
        Me.PBBorrarMC.Name = "PBBorrarMC"
        Me.PBBorrarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBBorrarMC.TabIndex = 100
        Me.PBBorrarMC.TabStop = False
        '
        'PBModificarMC
        '
        Me.PBModificarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBModificarMC.BackgroundImage = CType(resources.GetObject("PBModificarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBModificarMC.Location = New System.Drawing.Point(244, 296)
        Me.PBModificarMC.Name = "PBModificarMC"
        Me.PBModificarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBModificarMC.TabIndex = 99
        Me.PBModificarMC.TabStop = False
        '
        'TBClienteMC
        '
        Me.TBClienteMC.Location = New System.Drawing.Point(127, 44)
        Me.TBClienteMC.Name = "TBClienteMC"
        Me.TBClienteMC.ReadOnly = True
        Me.TBClienteMC.Size = New System.Drawing.Size(199, 22)
        Me.TBClienteMC.TabIndex = 63
        '
        'BarraEstado
        '
        Me.BarraEstado.BackColor = System.Drawing.Color.Transparent
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLabEstado})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 490)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(894, 22)
        Me.BarraEstado.TabIndex = 102
        Me.BarraEstado.Text = "StatusStrip1"
        '
        'TSLabEstado
        '
        Me.TSLabEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLabEstado.ForeColor = System.Drawing.Color.White
        Me.TSLabEstado.Name = "TSLabEstado"
        Me.TSLabEstado.Size = New System.Drawing.Size(0, 17)
        '
        'ModificarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(894, 512)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBoxMCita)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ModificarCita"
        Me.Text = "ModificarCita"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBMenosMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCancelarMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBorrarMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBModificarMC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBoxMCita As System.Windows.Forms.ListBox
    Friend WithEvents CBoxHoraMC As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBoxMinMC As System.Windows.Forms.ComboBox
    Friend WithEvents DPCitaMC As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBoxServiciosMC As System.Windows.Forms.ComboBox
    Friend WithEvents CBoxEmpleadoMC As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ListBServiciosMC As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBClienteMC As System.Windows.Forms.TextBox
    Friend WithEvents PBBorrarMC As System.Windows.Forms.PictureBox
    Friend WithEvents PBModificarMC As System.Windows.Forms.PictureBox
    Friend WithEvents PBCancelarMC As System.Windows.Forms.PictureBox
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents TSLabEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PBMenosMC As System.Windows.Forms.PictureBox
End Class
