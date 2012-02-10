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
        Me.PBMesCon = New System.Windows.Forms.PictureBox()
        Me.PBAnioCon = New System.Windows.Forms.PictureBox()
        Me.PBSemanaCon = New System.Windows.Forms.PictureBox()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.TSLabEstado = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMesCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAnioCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSemanaCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraEstado.SuspendLayout()
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
        'BarraEstado
        '
        Me.BarraEstado.BackColor = System.Drawing.Color.Transparent
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLabEstado})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 544)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(792, 22)
        Me.BarraEstado.TabIndex = 103
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
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.PBMesCon)
        Me.Controls.Add(Me.PBAnioCon)
        Me.Controls.Add(Me.PBSemanaCon)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMesCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAnioCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSemanaCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
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
    Friend WithEvents PBMesCon As System.Windows.Forms.PictureBox
    Friend WithEvents PBAnioCon As System.Windows.Forms.PictureBox
    Friend WithEvents PBSemanaCon As System.Windows.Forms.PictureBox
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents TSLabEstado As System.Windows.Forms.ToolStripStatusLabel
End Class
