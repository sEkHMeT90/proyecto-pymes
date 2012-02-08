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
        Me.LblAnio = New System.Windows.Forms.Label()
        Me.LblMes = New System.Windows.Forms.Label()
        Me.PBMesCon = New System.Windows.Forms.PictureBox()
        Me.PBAnioCon = New System.Windows.Forms.PictureBox()
        Me.LblSemana = New System.Windows.Forms.Label()
        Me.PBSemanaCon = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMesCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAnioCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSemanaCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Thistle
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lunes, Me.Martes, Me.Miercoles, Me.Jueves, Me.Viernes, Me.Sabado, Me.Domingo})
        Me.DataGridView1.Location = New System.Drawing.Point(52, 114)
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
        'LblAnio
        '
        Me.LblAnio.AutoSize = True
        Me.LblAnio.BackColor = System.Drawing.Color.Transparent
        Me.LblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnio.ForeColor = System.Drawing.Color.White
        Me.LblAnio.Location = New System.Drawing.Point(566, 52)
        Me.LblAnio.Name = "LblAnio"
        Me.LblAnio.Size = New System.Drawing.Size(35, 16)
        Me.LblAnio.TabIndex = 63
        Me.LblAnio.Text = "Año"
        '
        'LblMes
        '
        Me.LblMes.AutoSize = True
        Me.LblMes.BackColor = System.Drawing.Color.Transparent
        Me.LblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMes.ForeColor = System.Drawing.Color.White
        Me.LblMes.Location = New System.Drawing.Point(373, 52)
        Me.LblMes.Name = "LblMes"
        Me.LblMes.Size = New System.Drawing.Size(37, 16)
        Me.LblMes.TabIndex = 62
        Me.LblMes.Text = "Mes"
        '
        'PBMesCon
        '
        Me.PBMesCon.BackColor = System.Drawing.Color.Transparent
        Me.PBMesCon.BackgroundImage = CType(resources.GetObject("PBMesCon.BackgroundImage"), System.Drawing.Image)
        Me.PBMesCon.Location = New System.Drawing.Point(345, 42)
        Me.PBMesCon.Name = "PBMesCon"
        Me.PBMesCon.Size = New System.Drawing.Size(92, 37)
        Me.PBMesCon.TabIndex = 61
        Me.PBMesCon.TabStop = False
        '
        'PBAnioCon
        '
        Me.PBAnioCon.BackColor = System.Drawing.Color.Transparent
        Me.PBAnioCon.BackgroundImage = CType(resources.GetObject("PBAnioCon.BackgroundImage"), System.Drawing.Image)
        Me.PBAnioCon.Location = New System.Drawing.Point(538, 42)
        Me.PBAnioCon.Name = "PBAnioCon"
        Me.PBAnioCon.Size = New System.Drawing.Size(92, 37)
        Me.PBAnioCon.TabIndex = 60
        Me.PBAnioCon.TabStop = False
        '
        'LblSemana
        '
        Me.LblSemana.AutoSize = True
        Me.LblSemana.BackColor = System.Drawing.Color.Transparent
        Me.LblSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSemana.ForeColor = System.Drawing.Color.White
        Me.LblSemana.Location = New System.Drawing.Point(176, 52)
        Me.LblSemana.Name = "LblSemana"
        Me.LblSemana.Size = New System.Drawing.Size(65, 16)
        Me.LblSemana.TabIndex = 59
        Me.LblSemana.Text = "Semana"
        '
        'PBSemanaCon
        '
        Me.PBSemanaCon.BackColor = System.Drawing.Color.Transparent
        Me.PBSemanaCon.BackgroundImage = CType(resources.GetObject("PBSemanaCon.BackgroundImage"), System.Drawing.Image)
        Me.PBSemanaCon.Location = New System.Drawing.Point(163, 42)
        Me.PBSemanaCon.Name = "PBSemanaCon"
        Me.PBSemanaCon.Size = New System.Drawing.Size(92, 37)
        Me.PBSemanaCon.TabIndex = 58
        Me.PBSemanaCon.TabStop = False
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.LblAnio)
        Me.Controls.Add(Me.LblMes)
        Me.Controls.Add(Me.PBMesCon)
        Me.Controls.Add(Me.PBAnioCon)
        Me.Controls.Add(Me.LblSemana)
        Me.Controls.Add(Me.PBSemanaCon)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMesCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAnioCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSemanaCon, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LblAnio As System.Windows.Forms.Label
    Friend WithEvents LblMes As System.Windows.Forms.Label
    Friend WithEvents PBMesCon As System.Windows.Forms.PictureBox
    Friend WithEvents PBAnioCon As System.Windows.Forms.PictureBox
    Friend WithEvents LblSemana As System.Windows.Forms.Label
    Friend WithEvents PBSemanaCon As System.Windows.Forms.PictureBox
End Class
