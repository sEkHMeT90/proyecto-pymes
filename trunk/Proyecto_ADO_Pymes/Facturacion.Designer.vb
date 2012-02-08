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
        Me.ListBFacturaF = New System.Windows.Forms.ListBox()
        Me.CBoxTipoPagoF = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBoxCitaF = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBoxLineaPedidosF = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBPagarF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblImprimirF = New System.Windows.Forms.Label()
        Me.PBImprimirF = New System.Windows.Forms.PictureBox()
        Me.LblCobrarF = New System.Windows.Forms.Label()
        Me.PBCobrarF = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PBImprimirF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCobrarF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBFacturaF
        '
        Me.ListBFacturaF.FormattingEnabled = True
        Me.ListBFacturaF.Location = New System.Drawing.Point(203, 235)
        Me.ListBFacturaF.Name = "ListBFacturaF"
        Me.ListBFacturaF.Size = New System.Drawing.Size(201, 186)
        Me.ListBFacturaF.TabIndex = 4
        '
        'CBoxTipoPagoF
        '
        Me.CBoxTipoPagoF.BackColor = System.Drawing.Color.Thistle
        Me.CBoxTipoPagoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxTipoPagoF.FormattingEnabled = True
        Me.CBoxTipoPagoF.Items.AddRange(New Object() {"Al contado", "Tarjeta"})
        Me.CBoxTipoPagoF.Location = New System.Drawing.Point(203, 122)
        Me.CBoxTipoPagoF.Name = "CBoxTipoPagoF"
        Me.CBoxTipoPagoF.Size = New System.Drawing.Size(201, 21)
        Me.CBoxTipoPagoF.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(63, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Tipo Pago"
        '
        'CBoxCitaF
        '
        Me.CBoxCitaF.BackColor = System.Drawing.Color.Thistle
        Me.CBoxCitaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxCitaF.FormattingEnabled = True
        Me.CBoxCitaF.Items.AddRange(New Object() {"María Navarro", "Alejandro Diaz"})
        Me.CBoxCitaF.Location = New System.Drawing.Point(203, 69)
        Me.CBoxCitaF.Name = "CBoxCitaF"
        Me.CBoxCitaF.Size = New System.Drawing.Size(201, 21)
        Me.CBoxCitaF.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(63, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Cita"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Datos de Cita"
        '
        'CBoxLineaPedidosF
        '
        Me.CBoxLineaPedidosF.BackColor = System.Drawing.Color.Thistle
        Me.CBoxLineaPedidosF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxLineaPedidosF.FormattingEnabled = True
        Me.CBoxLineaPedidosF.Items.AddRange(New Object() {"asda", "asdd"})
        Me.CBoxLineaPedidosF.Location = New System.Drawing.Point(203, 180)
        Me.CBoxLineaPedidosF.Name = "CBoxLineaPedidosF"
        Me.CBoxLineaPedidosF.Size = New System.Drawing.Size(201, 21)
        Me.CBoxLineaPedidosF.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Linea Pedido"
        '
        'TBPagarF
        '
        Me.TBPagarF.Location = New System.Drawing.Point(318, 464)
        Me.TBPagarF.Multiline = True
        Me.TBPagarF.Name = "TBPagarF"
        Me.TBPagarF.ReadOnly = True
        Me.TBPagarF.Size = New System.Drawing.Size(86, 52)
        Me.TBPagarF.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(355, 441)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Total"
        '
        'LblImprimirF
        '
        Me.LblImprimirF.AutoSize = True
        Me.LblImprimirF.BackColor = System.Drawing.Color.Transparent
        Me.LblImprimirF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImprimirF.ForeColor = System.Drawing.Color.White
        Me.LblImprimirF.Location = New System.Drawing.Point(80, 484)
        Me.LblImprimirF.Name = "LblImprimirF"
        Me.LblImprimirF.Size = New System.Drawing.Size(63, 16)
        Me.LblImprimirF.TabIndex = 58
        Me.LblImprimirF.Text = "Imprimir"
        '
        'PBImprimirF
        '
        Me.PBImprimirF.BackColor = System.Drawing.Color.Transparent
        Me.PBImprimirF.BackgroundImage = CType(resources.GetObject("PBImprimirF.BackgroundImage"), System.Drawing.Image)
        Me.PBImprimirF.Location = New System.Drawing.Point(67, 464)
        Me.PBImprimirF.Name = "PBImprimirF"
        Me.PBImprimirF.Size = New System.Drawing.Size(86, 52)
        Me.PBImprimirF.TabIndex = 57
        Me.PBImprimirF.TabStop = False
        '
        'LblCobrarF
        '
        Me.LblCobrarF.AutoSize = True
        Me.LblCobrarF.BackColor = System.Drawing.Color.Transparent
        Me.LblCobrarF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCobrarF.ForeColor = System.Drawing.Color.White
        Me.LblCobrarF.Location = New System.Drawing.Point(220, 484)
        Me.LblCobrarF.Name = "LblCobrarF"
        Me.LblCobrarF.Size = New System.Drawing.Size(55, 16)
        Me.LblCobrarF.TabIndex = 5
        Me.LblCobrarF.Text = "Cobrar"
        '
        'PBCobrarF
        '
        Me.PBCobrarF.BackColor = System.Drawing.Color.Transparent
        Me.PBCobrarF.BackgroundImage = CType(resources.GetObject("PBCobrarF.BackgroundImage"), System.Drawing.Image)
        Me.PBCobrarF.Location = New System.Drawing.Point(203, 464)
        Me.PBCobrarF.Name = "PBCobrarF"
        Me.PBCobrarF.Size = New System.Drawing.Size(86, 52)
        Me.PBCobrarF.TabIndex = 59
        Me.PBCobrarF.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(504, 67)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(226, 327)
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(775, 572)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblCobrarF)
        Me.Controls.Add(Me.PBCobrarF)
        Me.Controls.Add(Me.LblImprimirF)
        Me.Controls.Add(Me.PBImprimirF)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBPagarF)
        Me.Controls.Add(Me.CBoxLineaPedidosF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBFacturaF)
        Me.Controls.Add(Me.CBoxTipoPagoF)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBoxCitaF)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Facturacion"
        Me.Text = "Facturacion"
        CType(Me.PBImprimirF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCobrarF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBFacturaF As System.Windows.Forms.ListBox
    Friend WithEvents CBoxTipoPagoF As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBoxCitaF As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBoxLineaPedidosF As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBPagarF As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblImprimirF As System.Windows.Forms.Label
    Friend WithEvents PBImprimirF As System.Windows.Forms.PictureBox
    Friend WithEvents LblCobrarF As System.Windows.Forms.Label
    Friend WithEvents PBCobrarF As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
