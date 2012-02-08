<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarEspecialidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarEspecialidad))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBDescricionMEs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNombreMEs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBoxEspecialidadesM = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBDescricionMEs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNombreMEs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(308, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 218)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Especialidad"
        '
        'TBDescricionMEs
        '
        Me.TBDescricionMEs.BackColor = System.Drawing.Color.Thistle
        Me.TBDescricionMEs.ForeColor = System.Drawing.Color.Black
        Me.TBDescricionMEs.Location = New System.Drawing.Point(134, 99)
        Me.TBDescricionMEs.Multiline = True
        Me.TBDescricionMEs.Name = "TBDescricionMEs"
        Me.TBDescricionMEs.Size = New System.Drawing.Size(190, 20)
        Me.TBDescricionMEs.TabIndex = 2
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
        'TBNombreMEs
        '
        Me.TBNombreMEs.BackColor = System.Drawing.Color.Thistle
        Me.TBNombreMEs.ForeColor = System.Drawing.Color.Black
        Me.TBNombreMEs.Location = New System.Drawing.Point(134, 48)
        Me.TBNombreMEs.Name = "TBNombreMEs"
        Me.TBNombreMEs.Size = New System.Drawing.Size(190, 22)
        Me.TBNombreMEs.TabIndex = 1
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
        'LBoxEspecialidadesM
        '
        Me.LBoxEspecialidadesM.FormattingEnabled = True
        Me.LBoxEspecialidadesM.Location = New System.Drawing.Point(76, 61)
        Me.LBoxEspecialidadesM.Name = "LBoxEspecialidadesM"
        Me.LBoxEspecialidadesM.Size = New System.Drawing.Size(192, 238)
        Me.LBoxEspecialidadesM.TabIndex = 95
        '
        'ModificarEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 372)
        Me.Controls.Add(Me.LBoxEspecialidadesM)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ModificarEspecialidad"
        Me.Text = "Modificar Especialidad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBDescricionMEs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNombreMEs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBoxEspecialidadesM As System.Windows.Forms.ListBox
End Class
