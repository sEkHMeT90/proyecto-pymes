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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBTipoPago = New System.Windows.Forms.ComboBox()
        Me.LBTipoPago = New System.Windows.Forms.Label()
        Me.TBEmpleado = New System.Windows.Forms.TextBox()
        Me.TBHora = New System.Windows.Forms.TextBox()
        Me.TBFecha = New System.Windows.Forms.TextBox()
        Me.TBDniF = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBClienteF = New System.Windows.Forms.TextBox()
        Me.ListBServiciosF = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PBCancelarMC = New System.Windows.Forms.PictureBox()
        Me.PBCobrarMC = New System.Windows.Forms.PictureBox()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.TSLabEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PBCancelarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCobrarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(494, 444)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Total"
        '
        'TBTotal
        '
        Me.TBTotal.BackColor = System.Drawing.Color.White
        Me.TBTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTotal.ForeColor = System.Drawing.Color.Red
        Me.TBTotal.Location = New System.Drawing.Point(565, 424)
        Me.TBTotal.Multiline = True
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.ReadOnly = True
        Me.TBTotal.Size = New System.Drawing.Size(100, 58)
        Me.TBTotal.TabIndex = 114
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CBTipoPago)
        Me.GroupBox2.Controls.Add(Me.LBTipoPago)
        Me.GroupBox2.Controls.Add(Me.TBEmpleado)
        Me.GroupBox2.Controls.Add(Me.TBHora)
        Me.GroupBox2.Controls.Add(Me.TBFecha)
        Me.GroupBox2.Controls.Add(Me.TBDniF)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TBClienteF)
        Me.GroupBox2.Controls.Add(Me.ListBServiciosF)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(41, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 356)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Cita"
        '
        'CBTipoPago
        '
        Me.CBTipoPago.FormattingEnabled = True
        Me.CBTipoPago.Location = New System.Drawing.Point(150, 305)
        Me.CBTipoPago.Name = "CBTipoPago"
        Me.CBTipoPago.Size = New System.Drawing.Size(202, 24)
        Me.CBTipoPago.TabIndex = 70
        '
        'LBTipoPago
        '
        Me.LBTipoPago.AutoSize = True
        Me.LBTipoPago.BackColor = System.Drawing.Color.Transparent
        Me.LBTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTipoPago.ForeColor = System.Drawing.Color.White
        Me.LBTipoPago.Location = New System.Drawing.Point(33, 305)
        Me.LBTipoPago.Name = "LBTipoPago"
        Me.LBTipoPago.Size = New System.Drawing.Size(89, 20)
        Me.LBTipoPago.TabIndex = 69
        Me.LBTipoPago.Text = "Tipo Pago"
        '
        'TBEmpleado
        '
        Me.TBEmpleado.BackColor = System.Drawing.Color.White
        Me.TBEmpleado.Location = New System.Drawing.Point(149, 261)
        Me.TBEmpleado.Name = "TBEmpleado"
        Me.TBEmpleado.ReadOnly = True
        Me.TBEmpleado.Size = New System.Drawing.Size(202, 22)
        Me.TBEmpleado.TabIndex = 68
        '
        'TBHora
        '
        Me.TBHora.BackColor = System.Drawing.Color.White
        Me.TBHora.Location = New System.Drawing.Point(149, 213)
        Me.TBHora.Name = "TBHora"
        Me.TBHora.ReadOnly = True
        Me.TBHora.Size = New System.Drawing.Size(202, 22)
        Me.TBHora.TabIndex = 67
        '
        'TBFecha
        '
        Me.TBFecha.BackColor = System.Drawing.Color.White
        Me.TBFecha.Location = New System.Drawing.Point(150, 160)
        Me.TBFecha.Name = "TBFecha"
        Me.TBFecha.ReadOnly = True
        Me.TBFecha.Size = New System.Drawing.Size(202, 22)
        Me.TBFecha.TabIndex = 66
        '
        'TBDniF
        '
        Me.TBDniF.BackColor = System.Drawing.Color.White
        Me.TBDniF.ForeColor = System.Drawing.Color.Black
        Me.TBDniF.Location = New System.Drawing.Point(150, 108)
        Me.TBDniF.Name = "TBDniF"
        Me.TBDniF.ReadOnly = True
        Me.TBDniF.Size = New System.Drawing.Size(202, 22)
        Me.TBDniF.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(33, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 20)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Dni"
        '
        'TBClienteF
        '
        Me.TBClienteF.BackColor = System.Drawing.Color.White
        Me.TBClienteF.Location = New System.Drawing.Point(150, 57)
        Me.TBClienteF.Name = "TBClienteF"
        Me.TBClienteF.ReadOnly = True
        Me.TBClienteF.Size = New System.Drawing.Size(199, 22)
        Me.TBClienteF.TabIndex = 63
        '
        'ListBServiciosF
        '
        Me.ListBServiciosF.FormattingEnabled = True
        Me.ListBServiciosF.ItemHeight = 16
        Me.ListBServiciosF.Location = New System.Drawing.Point(427, 87)
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
        Me.Label13.Location = New System.Drawing.Point(478, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 20)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Servicios"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(33, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 20)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Empleado"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(33, 213)
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
        Me.Label18.Location = New System.Drawing.Point(33, 160)
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
        Me.Label19.Location = New System.Drawing.Point(33, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 20)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Cliente"
        '
        'PBCancelarMC
        '
        Me.PBCancelarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBCancelarMC.BackgroundImage = CType(resources.GetObject("PBCancelarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBCancelarMC.Location = New System.Drawing.Point(299, 424)
        Me.PBCancelarMC.Name = "PBCancelarMC"
        Me.PBCancelarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBCancelarMC.TabIndex = 112
        Me.PBCancelarMC.TabStop = False
        '
        'PBCobrarMC
        '
        Me.PBCobrarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBCobrarMC.BackgroundImage = CType(resources.GetObject("PBCobrarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBCobrarMC.Location = New System.Drawing.Point(168, 424)
        Me.PBCobrarMC.Name = "PBCobrarMC"
        Me.PBCobrarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBCobrarMC.TabIndex = 111
        Me.PBCobrarMC.TabStop = False
        '
        'BarraEstado
        '
        Me.BarraEstado.BackColor = System.Drawing.Color.Transparent
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLabEstado})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 510)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(744, 22)
        Me.BarraEstado.TabIndex = 116
        Me.BarraEstado.Text = "StatusStrip1"
        '
        'TSLabEstado
        '
        Me.TSLabEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLabEstado.ForeColor = System.Drawing.Color.White
        Me.TSLabEstado.Name = "TSLabEstado"
        Me.TSLabEstado.Size = New System.Drawing.Size(0, 17)
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 532)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBTotal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PBCancelarMC)
        Me.Controls.Add(Me.PBCobrarMC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Facturacion"
        Me.Text = "Facturación"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PBCancelarMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCobrarMC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBTotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TBEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents TBHora As System.Windows.Forms.TextBox
    Friend WithEvents TBFecha As System.Windows.Forms.TextBox
    Friend WithEvents TBDniF As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBClienteF As System.Windows.Forms.TextBox
    Friend WithEvents ListBServiciosF As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PBCancelarMC As System.Windows.Forms.PictureBox
    Friend WithEvents PBCobrarMC As System.Windows.Forms.PictureBox
    Friend WithEvents CBTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents LBTipoPago As System.Windows.Forms.Label
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents TSLabEstado As System.Windows.Forms.ToolStripStatusLabel
End Class
