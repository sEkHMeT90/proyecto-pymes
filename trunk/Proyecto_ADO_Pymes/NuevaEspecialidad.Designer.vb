<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaEspecialidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaEspecialidad))
        Me.LblCancelarEs = New System.Windows.Forms.Label()
        Me.LblBorarEs = New System.Windows.Forms.Label()
        Me.PBBorrarEs = New System.Windows.Forms.PictureBox()
        Me.PBCancelarEs = New System.Windows.Forms.PictureBox()
        Me.LblAceptarEs = New System.Windows.Forms.Label()
        Me.PBAceptarEs = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBDescricionEs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNombreEs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSLabEstado = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PBBorrarEs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCancelarEs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAceptarEs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblCancelarEs
        '
        Me.LblCancelarEs.AutoSize = True
        Me.LblCancelarEs.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelarEs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelarEs.ForeColor = System.Drawing.Color.White
        Me.LblCancelarEs.Location = New System.Drawing.Point(341, 264)
        Me.LblCancelarEs.Name = "LblCancelarEs"
        Me.LblCancelarEs.Size = New System.Drawing.Size(70, 16)
        Me.LblCancelarEs.TabIndex = 99
        Me.LblCancelarEs.Text = "Cancelar"
        '
        'LblBorarEs
        '
        Me.LblBorarEs.AutoSize = True
        Me.LblBorarEs.BackColor = System.Drawing.Color.Transparent
        Me.LblBorarEs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBorarEs.ForeColor = System.Drawing.Color.White
        Me.LblBorarEs.Location = New System.Drawing.Point(210, 264)
        Me.LblBorarEs.Name = "LblBorarEs"
        Me.LblBorarEs.Size = New System.Drawing.Size(51, 16)
        Me.LblBorarEs.TabIndex = 98
        Me.LblBorarEs.Text = "Borrar"
        '
        'PBBorrarEs
        '
        Me.PBBorrarEs.BackColor = System.Drawing.Color.Transparent
        Me.PBBorrarEs.BackgroundImage = CType(resources.GetObject("PBBorrarEs.BackgroundImage"), System.Drawing.Image)
        Me.PBBorrarEs.Location = New System.Drawing.Point(192, 254)
        Me.PBBorrarEs.Name = "PBBorrarEs"
        Me.PBBorrarEs.Size = New System.Drawing.Size(92, 37)
        Me.PBBorrarEs.TabIndex = 97
        Me.PBBorrarEs.TabStop = False
        '
        'PBCancelarEs
        '
        Me.PBCancelarEs.BackColor = System.Drawing.Color.Transparent
        Me.PBCancelarEs.BackgroundImage = CType(resources.GetObject("PBCancelarEs.BackgroundImage"), System.Drawing.Image)
        Me.PBCancelarEs.Location = New System.Drawing.Point(329, 254)
        Me.PBCancelarEs.Name = "PBCancelarEs"
        Me.PBCancelarEs.Size = New System.Drawing.Size(92, 37)
        Me.PBCancelarEs.TabIndex = 96
        Me.PBCancelarEs.TabStop = False
        '
        'LblAceptarEs
        '
        Me.LblAceptarEs.AutoSize = True
        Me.LblAceptarEs.BackColor = System.Drawing.Color.Transparent
        Me.LblAceptarEs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAceptarEs.ForeColor = System.Drawing.Color.White
        Me.LblAceptarEs.Location = New System.Drawing.Point(72, 264)
        Me.LblAceptarEs.Name = "LblAceptarEs"
        Me.LblAceptarEs.Size = New System.Drawing.Size(62, 16)
        Me.LblAceptarEs.TabIndex = 95
        Me.LblAceptarEs.Text = "Aceptar"
        '
        'PBAceptarEs
        '
        Me.PBAceptarEs.BackColor = System.Drawing.Color.Transparent
        Me.PBAceptarEs.BackgroundImage = CType(resources.GetObject("PBAceptarEs.BackgroundImage"), System.Drawing.Image)
        Me.PBAceptarEs.Location = New System.Drawing.Point(58, 254)
        Me.PBAceptarEs.Name = "PBAceptarEs"
        Me.PBAceptarEs.Size = New System.Drawing.Size(92, 37)
        Me.PBAceptarEs.TabIndex = 94
        Me.PBAceptarEs.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBDescricionEs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNombreEs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(55, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 173)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Especialidad"
        '
        'TBDescricionEs
        '
        Me.TBDescricionEs.BackColor = System.Drawing.Color.Thistle
        Me.TBDescricionEs.ForeColor = System.Drawing.Color.Black
        Me.TBDescricionEs.Location = New System.Drawing.Point(134, 99)
        Me.TBDescricionEs.Multiline = True
        Me.TBDescricionEs.Name = "TBDescricionEs"
        Me.TBDescricionEs.Size = New System.Drawing.Size(190, 20)
        Me.TBDescricionEs.TabIndex = 2
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
        'TBNombreEs
        '
        Me.TBNombreEs.BackColor = System.Drawing.Color.Thistle
        Me.TBNombreEs.ForeColor = System.Drawing.Color.Black
        Me.TBNombreEs.Location = New System.Drawing.Point(134, 48)
        Me.TBNombreEs.Name = "TBNombreEs"
        Me.TBNombreEs.Size = New System.Drawing.Size(190, 22)
        Me.TBNombreEs.TabIndex = 1
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLabEstado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 300)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(474, 22)
        Me.StatusStrip1.TabIndex = 100
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSLabEstado
        '
        Me.TSLabEstado.Name = "TSLabEstado"
        Me.TSLabEstado.Size = New System.Drawing.Size(40, 17)
        Me.TSLabEstado.Text = "Estado"
        '
        'NuevaEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(474, 322)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LblCancelarEs)
        Me.Controls.Add(Me.LblBorarEs)
        Me.Controls.Add(Me.PBBorrarEs)
        Me.Controls.Add(Me.PBCancelarEs)
        Me.Controls.Add(Me.LblAceptarEs)
        Me.Controls.Add(Me.PBAceptarEs)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "NuevaEspecialidad"
        Me.Text = "NuevaEspecialidad"
        CType(Me.PBBorrarEs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCancelarEs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAceptarEs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblCancelarEs As System.Windows.Forms.Label
    Friend WithEvents LblBorarEs As System.Windows.Forms.Label
    Friend WithEvents PBBorrarEs As System.Windows.Forms.PictureBox
    Friend WithEvents PBCancelarEs As System.Windows.Forms.PictureBox
    Friend WithEvents LblAceptarEs As System.Windows.Forms.Label
    Friend WithEvents PBAceptarEs As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBDescricionEs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNombreEs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSLabEstado As System.Windows.Forms.ToolStripStatusLabel
End Class
