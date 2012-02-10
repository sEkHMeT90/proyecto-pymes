<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarCliente))
        Me.LBoxMC = New System.Windows.Forms.ListBox()
        Me.TBEmailMU = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBMovilMU = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBFijoMU = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBDniMU = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBApellidoMU = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBApellido1MU = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNombreMU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PBCancelarMC = New System.Windows.Forms.PictureBox()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.TSLabEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PBBorrarMC = New System.Windows.Forms.PictureBox()
        Me.PBModificarMC = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBCancelarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraEstado.SuspendLayout()
        CType(Me.PBBorrarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBModificarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBoxMC
        '
        Me.LBoxMC.FormattingEnabled = True
        Me.LBoxMC.Location = New System.Drawing.Point(43, 58)
        Me.LBoxMC.Name = "LBoxMC"
        Me.LBoxMC.Size = New System.Drawing.Size(221, 394)
        Me.LBoxMC.TabIndex = 0
        '
        'TBEmailMU
        '
        Me.TBEmailMU.BackColor = System.Drawing.Color.Thistle
        Me.TBEmailMU.ForeColor = System.Drawing.Color.Black
        Me.TBEmailMU.Location = New System.Drawing.Point(126, 347)
        Me.TBEmailMU.Name = "TBEmailMU"
        Me.TBEmailMU.Size = New System.Drawing.Size(190, 22)
        Me.TBEmailMU.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(7, 345)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Email"
        '
        'TBMovilMU
        '
        Me.TBMovilMU.BackColor = System.Drawing.Color.Thistle
        Me.TBMovilMU.ForeColor = System.Drawing.Color.Black
        Me.TBMovilMU.Location = New System.Drawing.Point(124, 301)
        Me.TBMovilMU.Name = "TBMovilMU"
        Me.TBMovilMU.Size = New System.Drawing.Size(190, 22)
        Me.TBMovilMU.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Movil"
        '
        'TBFijoMU
        '
        Me.TBFijoMU.BackColor = System.Drawing.Color.Thistle
        Me.TBFijoMU.ForeColor = System.Drawing.Color.Black
        Me.TBFijoMU.Location = New System.Drawing.Point(124, 249)
        Me.TBFijoMU.Name = "TBFijoMU"
        Me.TBFijoMU.Size = New System.Drawing.Size(190, 22)
        Me.TBFijoMU.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Fijo"
        '
        'TBDniMU
        '
        Me.TBDniMU.BackColor = System.Drawing.Color.Thistle
        Me.TBDniMU.ForeColor = System.Drawing.Color.Black
        Me.TBDniMU.Location = New System.Drawing.Point(124, 198)
        Me.TBDniMU.Name = "TBDniMU"
        Me.TBDniMU.Size = New System.Drawing.Size(190, 22)
        Me.TBDniMU.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Dni"
        '
        'TBApellidoMU
        '
        Me.TBApellidoMU.BackColor = System.Drawing.Color.Thistle
        Me.TBApellidoMU.ForeColor = System.Drawing.Color.Black
        Me.TBApellidoMU.Location = New System.Drawing.Point(124, 146)
        Me.TBApellidoMU.Name = "TBApellidoMU"
        Me.TBApellidoMU.Size = New System.Drawing.Size(190, 22)
        Me.TBApellidoMU.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Apellido 2"
        '
        'TBApellido1MU
        '
        Me.TBApellido1MU.BackColor = System.Drawing.Color.Thistle
        Me.TBApellido1MU.ForeColor = System.Drawing.Color.Black
        Me.TBApellido1MU.Location = New System.Drawing.Point(124, 94)
        Me.TBApellido1MU.Name = "TBApellido1MU"
        Me.TBApellido1MU.Size = New System.Drawing.Size(190, 22)
        Me.TBApellido1MU.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Apellido 1"
        '
        'TBNombreMU
        '
        Me.TBNombreMU.BackColor = System.Drawing.Color.Thistle
        Me.TBNombreMU.ForeColor = System.Drawing.Color.Black
        Me.TBNombreMU.Location = New System.Drawing.Point(124, 43)
        Me.TBNombreMU.Name = "TBNombreMU"
        Me.TBNombreMU.Size = New System.Drawing.Size(190, 22)
        Me.TBNombreMU.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(341, 146)
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
        Me.CBProvinciaU.Location = New System.Drawing.Point(439, 145)
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
        Me.Label10.Location = New System.Drawing.Point(341, 197)
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
        Me.CBPoblacionU.Location = New System.Drawing.Point(439, 196)
        Me.CBPoblacionU.Name = "CBPoblacionU"
        Me.CBPoblacionU.Size = New System.Drawing.Size(189, 24)
        Me.CBPoblacionU.TabIndex = 51
        '
        'TBPisoMU
        '
        Me.TBPisoMU.BackColor = System.Drawing.Color.Thistle
        Me.TBPisoMU.ForeColor = System.Drawing.Color.Black
        Me.TBPisoMU.Location = New System.Drawing.Point(570, 96)
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
        Me.Label9.Location = New System.Drawing.Point(512, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Piso"
        '
        'TBNumeroMU
        '
        Me.TBNumeroMU.BackColor = System.Drawing.Color.Thistle
        Me.TBNumeroMU.ForeColor = System.Drawing.Color.Black
        Me.TBNumeroMU.Location = New System.Drawing.Point(439, 96)
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
        Me.Label8.Location = New System.Drawing.Point(343, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 20)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Nº"
        '
        'TBCalleMU
        '
        Me.TBCalleMU.BackColor = System.Drawing.Color.Thistle
        Me.TBCalleMU.ForeColor = System.Drawing.Color.Black
        Me.TBCalleMU.Location = New System.Drawing.Point(439, 46)
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
        Me.Label7.Location = New System.Drawing.Point(343, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Calle"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PBCancelarMC)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CBProvinciaU)
        Me.GroupBox1.Controls.Add(Me.PBBorrarMC)
        Me.GroupBox1.Controls.Add(Me.PBModificarMC)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.CBPoblacionU)
        Me.GroupBox1.Controls.Add(Me.TBPisoMU)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TBNumeroMU)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TBCalleMU)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TBEmailMU)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TBMovilMU)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBFijoMU)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBDniMU)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBApellidoMU)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBApellido1MU)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNombreMU)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(292, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 398)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cliente"
        '
        'PBCancelarMC
        '
        Me.PBCancelarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBCancelarMC.BackgroundImage = CType(resources.GetObject("PBCancelarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBCancelarMC.Location = New System.Drawing.Point(557, 278)
        Me.PBCancelarMC.Name = "PBCancelarMC"
        Me.PBCancelarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBCancelarMC.TabIndex = 103
        Me.PBCancelarMC.TabStop = False
        '
        'BarraEstado
        '
        Me.BarraEstado.BackColor = System.Drawing.Color.Transparent
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLabEstado})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 500)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(994, 22)
        Me.BarraEstado.TabIndex = 102
        Me.BarraEstado.Text = "StatusStrip1"
        '
        'TSLabEstado
        '
        Me.TSLabEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLabEstado.ForeColor = System.Drawing.Color.White
        Me.TSLabEstado.Name = "TSLabEstado"
        Me.TSLabEstado.Size = New System.Drawing.Size(143, 17)
        Me.TSLabEstado.Text = "ToolStripStatusLabel1"
        '
        'PBBorrarMC
        '
        Me.PBBorrarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBBorrarMC.BackgroundImage = CType(resources.GetObject("PBBorrarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBBorrarMC.Location = New System.Drawing.Point(472, 278)
        Me.PBBorrarMC.Name = "PBBorrarMC"
        Me.PBBorrarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBBorrarMC.TabIndex = 101
        Me.PBBorrarMC.TabStop = False
        '
        'PBModificarMC
        '
        Me.PBModificarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBModificarMC.BackgroundImage = CType(resources.GetObject("PBModificarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBModificarMC.Location = New System.Drawing.Point(385, 278)
        Me.PBModificarMC.Name = "PBModificarMC"
        Me.PBModificarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBModificarMC.TabIndex = 100
        Me.PBModificarMC.TabStop = False
        '
        'ModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 522)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBoxMC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ModificarCliente"
        Me.Text = "Modificar Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBCancelarMC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        CType(Me.PBBorrarMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBModificarMC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBoxMC As System.Windows.Forms.ListBox
    Friend WithEvents TBEmailMU As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TBMovilMU As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBFijoMU As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBDniMU As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBApellidoMU As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBApellido1MU As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNombreMU As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PBCancelarMC As System.Windows.Forms.PictureBox
    Friend WithEvents PBBorrarMC As System.Windows.Forms.PictureBox
    Friend WithEvents PBModificarMC As System.Windows.Forms.PictureBox
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents TSLabEstado As System.Windows.Forms.ToolStripStatusLabel
End Class
