<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturación
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturación))
        Me.ListBDatosCita = New System.Windows.Forms.ListBox()
        Me.CBoxSelecCita = New System.Windows.Forms.ComboBox()
        Me.BtCobrarFact = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBTotalFact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBoxTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBoxLineaPedido = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnImprimirFact = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBDatosCita
        '
        Me.ListBDatosCita.FormattingEnabled = True
        Me.ListBDatosCita.Location = New System.Drawing.Point(462, 134)
        Me.ListBDatosCita.Name = "ListBDatosCita"
        Me.ListBDatosCita.Size = New System.Drawing.Size(273, 199)
        Me.ListBDatosCita.TabIndex = 63
        '
        'CBoxSelecCita
        '
        Me.CBoxSelecCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxSelecCita.FormattingEnabled = True
        Me.CBoxSelecCita.Location = New System.Drawing.Point(186, 133)
        Me.CBoxSelecCita.Name = "CBoxSelecCita"
        Me.CBoxSelecCita.Size = New System.Drawing.Size(202, 21)
        Me.CBoxSelecCita.TabIndex = 62
        '
        'BtCobrarFact
        '
        Me.BtCobrarFact.BackColor = System.Drawing.SystemColors.MenuBar
        Me.BtCobrarFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCobrarFact.Location = New System.Drawing.Point(462, 388)
        Me.BtCobrarFact.Name = "BtCobrarFact"
        Me.BtCobrarFact.Size = New System.Drawing.Size(92, 37)
        Me.BtCobrarFact.TabIndex = 58
        Me.BtCobrarFact.Text = "Cobrar"
        Me.BtCobrarFact.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(69, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Cita"
        '
        'TBTotalFact
        '
        Me.TBTotalFact.Location = New System.Drawing.Point(645, 377)
        Me.TBTotalFact.Multiline = True
        Me.TBTotalFact.Name = "TBTotalFact"
        Me.TBTotalFact.ReadOnly = True
        Me.TBTotalFact.Size = New System.Drawing.Size(90, 48)
        Me.TBTotalFact.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(560, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Total"
        '
        'CBoxTipoPago
        '
        Me.CBoxTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxTipoPago.FormattingEnabled = True
        Me.CBoxTipoPago.Items.AddRange(New Object() {"Al contado", "Tarjeta", "Cheque"})
        Me.CBoxTipoPago.Location = New System.Drawing.Point(186, 224)
        Me.CBoxTipoPago.Name = "CBoxTipoPago"
        Me.CBoxTipoPago.Size = New System.Drawing.Size(202, 21)
        Me.CBoxTipoPago.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(69, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Tipo Pago"
        '
        'CBoxLineaPedido
        '
        Me.CBoxLineaPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxLineaPedido.FormattingEnabled = True
        Me.CBoxLineaPedido.Location = New System.Drawing.Point(186, 311)
        Me.CBoxLineaPedido.Name = "CBoxLineaPedido"
        Me.CBoxLineaPedido.Size = New System.Drawing.Size(202, 21)
        Me.CBoxLineaPedido.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(69, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Linea Pedido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(527, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 20)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Glosario de Cita"
        '
        'BtnImprimirFact
        '
        Me.BtnImprimirFact.BackColor = System.Drawing.SystemColors.MenuBar
        Me.BtnImprimirFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimirFact.Location = New System.Drawing.Point(186, 367)
        Me.BtnImprimirFact.Name = "BtnImprimirFact"
        Me.BtnImprimirFact.Size = New System.Drawing.Size(92, 58)
        Me.BtnImprimirFact.TabIndex = 71
        Me.BtnImprimirFact.Text = "Imprimir Factura"
        Me.BtnImprimirFact.UseVisualStyleBackColor = False
        '
        'Facturación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.BtnImprimirFact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBoxLineaPedido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBoxTipoPago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBTotalFact)
        Me.Controls.Add(Me.ListBDatosCita)
        Me.Controls.Add(Me.CBoxSelecCita)
        Me.Controls.Add(Me.BtCobrarFact)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Facturación"
        Me.Text = "Facturación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBDatosCita As System.Windows.Forms.ListBox
    Friend WithEvents CBoxSelecCita As System.Windows.Forms.ComboBox
    Friend WithEvents BtCobrarFact As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBTotalFact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBoxTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBoxLineaPedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnImprimirFact As System.Windows.Forms.Button
End Class
