<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Lunes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Martes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Miercoles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jueves = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Viernes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sabado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domingo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PBMes = New System.Windows.Forms.PictureBox()
        Me.PBAnio = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PBSemana = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSemana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Thistle
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lunes, Me.Martes, Me.Miercoles, Me.Jueves, Me.Viernes, Me.Sabado, Me.Domingo})
        Me.DataGridView1.Location = New System.Drawing.Point(48, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(689, 402)
        Me.DataGridView1.TabIndex = 47
        '
        'Lunes
        '
        Me.Lunes.FillWeight = 80.0!
        Me.Lunes.HeaderText = "Lunes"
        Me.Lunes.Name = "Lunes"
        '
        'Martes
        '
        Me.Martes.FillWeight = 80.0!
        Me.Martes.HeaderText = "Martes"
        Me.Martes.Name = "Martes"
        '
        'Miercoles
        '
        Me.Miercoles.FillWeight = 80.0!
        Me.Miercoles.HeaderText = "Miercoles"
        Me.Miercoles.Name = "Miercoles"
        '
        'Jueves
        '
        Me.Jueves.FillWeight = 80.0!
        Me.Jueves.HeaderText = "Jueves"
        Me.Jueves.Name = "Jueves"
        '
        'Viernes
        '
        Me.Viernes.FillWeight = 80.0!
        Me.Viernes.HeaderText = "Viernes"
        Me.Viernes.Name = "Viernes"
        '
        'Sabado
        '
        Me.Sabado.FillWeight = 80.0!
        Me.Sabado.HeaderText = "Sabado"
        Me.Sabado.Name = "Sabado"
        '
        'Domingo
        '
        Me.Domingo.FillWeight = 80.0!
        Me.Domingo.HeaderText = "Domingo"
        Me.Domingo.Name = "Domingo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(560, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 16)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Año"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(367, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 16)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Mes"
        '
        'PBMes
        '
        Me.PBMes.BackColor = System.Drawing.Color.Transparent
        Me.PBMes.BackgroundImage = CType(resources.GetObject("PBMes.BackgroundImage"), System.Drawing.Image)
        Me.PBMes.Location = New System.Drawing.Point(339, 42)
        Me.PBMes.Name = "PBMes"
        Me.PBMes.Size = New System.Drawing.Size(92, 37)
        Me.PBMes.TabIndex = 61
        Me.PBMes.TabStop = False
        '
        'PBAnio
        '
        Me.PBAnio.BackColor = System.Drawing.Color.Transparent
        Me.PBAnio.BackgroundImage = CType(resources.GetObject("PBAnio.BackgroundImage"), System.Drawing.Image)
        Me.PBAnio.Location = New System.Drawing.Point(532, 42)
        Me.PBAnio.Name = "PBAnio"
        Me.PBAnio.Size = New System.Drawing.Size(92, 37)
        Me.PBAnio.TabIndex = 60
        Me.PBAnio.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(170, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 16)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Semana"
        '
        'PBSemana
        '
        Me.PBSemana.BackColor = System.Drawing.Color.Transparent
        Me.PBSemana.BackgroundImage = CType(resources.GetObject("PBSemana.BackgroundImage"), System.Drawing.Image)
        Me.PBSemana.Location = New System.Drawing.Point(157, 42)
        Me.PBSemana.Name = "PBSemana"
        Me.PBSemana.Size = New System.Drawing.Size(92, 37)
        Me.PBSemana.TabIndex = 58
        Me.PBSemana.TabStop = False
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PBMes)
        Me.Controls.Add(Me.PBAnio)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PBSemana)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSemana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Lunes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Martes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Miercoles As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jueves As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Viernes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sabado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domingo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PBMes As System.Windows.Forms.PictureBox
    Friend WithEvents PBAnio As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PBSemana As System.Windows.Forms.PictureBox
End Class
