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
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBApellido2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBApellido1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PBBorrarU = New System.Windows.Forms.PictureBox()
        Me.PBCancelarU = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PBAceptarU = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBBorrarU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCancelarU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAceptarU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBDni
        '
        Me.TBDni.BackColor = System.Drawing.Color.Thistle
        Me.TBDni.ForeColor = System.Drawing.Color.Black
        Me.TBDni.Location = New System.Drawing.Point(134, 203)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(190, 22)
        Me.TBDni.TabIndex = 4
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
        'TBApellido2
        '
        Me.TBApellido2.BackColor = System.Drawing.Color.Thistle
        Me.TBApellido2.ForeColor = System.Drawing.Color.Black
        Me.TBApellido2.Location = New System.Drawing.Point(134, 151)
        Me.TBApellido2.Name = "TBApellido2"
        Me.TBApellido2.Size = New System.Drawing.Size(190, 22)
        Me.TBApellido2.TabIndex = 3
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
        'TBApellido1
        '
        Me.TBApellido1.BackColor = System.Drawing.Color.Thistle
        Me.TBApellido1.ForeColor = System.Drawing.Color.Black
        Me.TBApellido1.Location = New System.Drawing.Point(134, 99)
        Me.TBApellido1.Multiline = True
        Me.TBApellido1.Name = "TBApellido1"
        Me.TBApellido1.Size = New System.Drawing.Size(190, 20)
        Me.TBApellido1.TabIndex = 2
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
        'TBNombre
        '
        Me.TBNombre.BackColor = System.Drawing.Color.Thistle
        Me.TBNombre.ForeColor = System.Drawing.Color.Black
        Me.TBNombre.Location = New System.Drawing.Point(134, 48)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(190, 22)
        Me.TBNombre.TabIndex = 1
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
        Me.GroupBox1.Controls.Add(Me.TBDni)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBApellido2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBApellido1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(340, 328)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 16)
        Me.Label19.TabIndex = 92
        Me.Label19.Text = "Cancelar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(209, 328)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 16)
        Me.Label18.TabIndex = 91
        Me.Label18.Text = "Borrar"
        '
        'PBBorrarU
        '
        Me.PBBorrarU.BackColor = System.Drawing.Color.Transparent
        Me.PBBorrarU.BackgroundImage = CType(resources.GetObject("PBBorrarU.BackgroundImage"), System.Drawing.Image)
        Me.PBBorrarU.Location = New System.Drawing.Point(191, 318)
        Me.PBBorrarU.Name = "PBBorrarU"
        Me.PBBorrarU.Size = New System.Drawing.Size(92, 37)
        Me.PBBorrarU.TabIndex = 90
        Me.PBBorrarU.TabStop = False
        '
        'PBCancelarU
        '
        Me.PBCancelarU.BackColor = System.Drawing.Color.Transparent
        Me.PBCancelarU.BackgroundImage = CType(resources.GetObject("PBCancelarU.BackgroundImage"), System.Drawing.Image)
        Me.PBCancelarU.Location = New System.Drawing.Point(328, 318)
        Me.PBCancelarU.Name = "PBCancelarU"
        Me.PBCancelarU.Size = New System.Drawing.Size(92, 37)
        Me.PBCancelarU.TabIndex = 89
        Me.PBCancelarU.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(71, 328)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 16)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "Aceptar"
        '
        'PBAceptarU
        '
        Me.PBAceptarU.BackColor = System.Drawing.Color.Transparent
        Me.PBAceptarU.BackgroundImage = CType(resources.GetObject("PBAceptarU.BackgroundImage"), System.Drawing.Image)
        Me.PBAceptarU.Location = New System.Drawing.Point(57, 318)
        Me.PBAceptarU.Name = "PBAceptarU"
        Me.PBAceptarU.Size = New System.Drawing.Size(92, 37)
        Me.PBAceptarU.TabIndex = 87
        Me.PBAceptarU.TabStop = False
        '
        'NuevoServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(474, 372)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PBBorrarU)
        Me.Controls.Add(Me.PBCancelarU)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PBAceptarU)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "NuevoServicio"
        Me.Text = "Nuevo Servicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBBorrarU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCancelarU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAceptarU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBDni As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PBBorrarU As System.Windows.Forms.PictureBox
    Friend WithEvents PBCancelarU As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PBAceptarU As System.Windows.Forms.PictureBox
End Class
