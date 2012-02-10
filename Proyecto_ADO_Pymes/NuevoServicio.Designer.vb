<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoServicio))
        Me.TBPrecioS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBDuracionS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBDescripcionS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNombreS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.SLblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PBCancelarS = New System.Windows.Forms.PictureBox()
        Me.PBAceptarS = New System.Windows.Forms.PictureBox()
        Me.PBBorrarS = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.BarraEstado.SuspendLayout()
        CType(Me.PBCancelarS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAceptarS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBorrarS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBPrecioS
        '
        Me.TBPrecioS.BackColor = System.Drawing.Color.Thistle
        Me.TBPrecioS.ForeColor = System.Drawing.Color.Black
        Me.TBPrecioS.Location = New System.Drawing.Point(134, 203)
        Me.TBPrecioS.Name = "TBPrecioS"
        Me.TBPrecioS.Size = New System.Drawing.Size(190, 22)
        Me.TBPrecioS.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Precio"
        '
        'TBDuracionS
        '
        Me.TBDuracionS.BackColor = System.Drawing.Color.Thistle
        Me.TBDuracionS.ForeColor = System.Drawing.Color.Black
        Me.TBDuracionS.Location = New System.Drawing.Point(134, 151)
        Me.TBDuracionS.Name = "TBDuracionS"
        Me.TBDuracionS.Size = New System.Drawing.Size(190, 22)
        Me.TBDuracionS.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Duración"
        '
        'TBDescripcionS
        '
        Me.TBDescripcionS.BackColor = System.Drawing.Color.Thistle
        Me.TBDescripcionS.ForeColor = System.Drawing.Color.Black
        Me.TBDescripcionS.Location = New System.Drawing.Point(134, 99)
        Me.TBDescripcionS.Multiline = True
        Me.TBDescripcionS.Name = "TBDescripcionS"
        Me.TBDescripcionS.Size = New System.Drawing.Size(190, 20)
        Me.TBDescripcionS.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripción"
        '
        'TBNombreS
        '
        Me.TBNombreS.BackColor = System.Drawing.Color.Thistle
        Me.TBNombreS.ForeColor = System.Drawing.Color.Black
        Me.TBNombreS.Location = New System.Drawing.Point(134, 48)
        Me.TBNombreS.Name = "TBNombreS"
        Me.TBNombreS.Size = New System.Drawing.Size(190, 22)
        Me.TBNombreS.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBPrecioS)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBDuracionS)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBDescripcionS)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNombreS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(57, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 254)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Servicio"
        '
        'BarraEstado
        '
        Me.BarraEstado.BackColor = System.Drawing.Color.Transparent
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SLblEstado})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 400)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(474, 22)
        Me.BarraEstado.TabIndex = 111
        Me.BarraEstado.Text = "StatusStrip1"
        '
        'SLblEstado
        '
        Me.SLblEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLblEstado.ForeColor = System.Drawing.Color.White
        Me.SLblEstado.Name = "SLblEstado"
        Me.SLblEstado.Size = New System.Drawing.Size(143, 17)
        Me.SLblEstado.Text = "ToolStripStatusLabel1"
        '
        'PBCancelarS
        '
        Me.PBCancelarS.BackColor = System.Drawing.Color.Transparent
        Me.PBCancelarS.BackgroundImage = CType(resources.GetObject("PBCancelarS.BackgroundImage"), System.Drawing.Image)
        Me.PBCancelarS.Location = New System.Drawing.Point(300, 309)
        Me.PBCancelarS.Name = "PBCancelarS"
        Me.PBCancelarS.Size = New System.Drawing.Size(70, 70)
        Me.PBCancelarS.TabIndex = 110
        Me.PBCancelarS.TabStop = False
        '
        'PBAceptarS
        '
        Me.PBAceptarS.BackColor = System.Drawing.Color.Transparent
        Me.PBAceptarS.BackgroundImage = CType(resources.GetObject("PBAceptarS.BackgroundImage"), System.Drawing.Image)
        Me.PBAceptarS.Location = New System.Drawing.Point(129, 309)
        Me.PBAceptarS.Name = "PBAceptarS"
        Me.PBAceptarS.Size = New System.Drawing.Size(70, 70)
        Me.PBAceptarS.TabIndex = 108
        Me.PBAceptarS.TabStop = False
        '
        'PBBorrarS
        '
        Me.PBBorrarS.BackColor = System.Drawing.Color.Transparent
        Me.PBBorrarS.BackgroundImage = CType(resources.GetObject("PBBorrarS.BackgroundImage"), System.Drawing.Image)
        Me.PBBorrarS.Location = New System.Drawing.Point(214, 309)
        Me.PBBorrarS.Name = "PBBorrarS"
        Me.PBBorrarS.Size = New System.Drawing.Size(70, 70)
        Me.PBBorrarS.TabIndex = 109
        Me.PBBorrarS.TabStop = False
        '
        'NuevoServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(474, 422)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.PBCancelarS)
        Me.Controls.Add(Me.PBAceptarS)
        Me.Controls.Add(Me.PBBorrarS)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "NuevoServicio"
        Me.Text = "Nuevo Servicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        CType(Me.PBCancelarS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAceptarS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBorrarS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBPrecioS As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBDuracionS As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBDescripcionS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNombreS As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents SLblEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PBCancelarS As System.Windows.Forms.PictureBox
    Friend WithEvents PBAceptarS As System.Windows.Forms.PictureBox
    Friend WithEvents PBBorrarS As System.Windows.Forms.PictureBox
End Class
