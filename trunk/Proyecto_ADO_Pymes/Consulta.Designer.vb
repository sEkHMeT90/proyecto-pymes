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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta))
        Me.DatosConsulta = New System.Windows.Forms.DataGridView()
        Me.PBMesCon = New System.Windows.Forms.PictureBox()
        Me.PBAnioCon = New System.Windows.Forms.PictureBox()
        Me.PBSemanaCon = New System.Windows.Forms.PictureBox()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.TSLabEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MCalendar = New System.Windows.Forms.MonthCalendar()
        Me.LblState = New System.Windows.Forms.Label()
        Me.LblVista = New System.Windows.Forms.Label()
        CType(Me.DatosConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMesCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAnioCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSemanaCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatosConsulta
        '
        Me.DatosConsulta.AllowUserToAddRows = False
        Me.DatosConsulta.AllowUserToDeleteRows = False
        Me.DatosConsulta.AllowUserToResizeColumns = False
        Me.DatosConsulta.AllowUserToResizeRows = False
        Me.DatosConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatosConsulta.BackgroundColor = System.Drawing.Color.White
        Me.DatosConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DatosConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosConsulta.Location = New System.Drawing.Point(52, 173)
        Me.DatosConsulta.Name = "DatosConsulta"
        Me.DatosConsulta.ReadOnly = True
        Me.DatosConsulta.RowHeadersVisible = False
        Me.DatosConsulta.Size = New System.Drawing.Size(689, 368)
        Me.DatosConsulta.TabIndex = 47
        '
        'PBMesCon
        '
        Me.PBMesCon.BackColor = System.Drawing.Color.Transparent
        Me.PBMesCon.BackgroundImage = CType(resources.GetObject("PBMesCon.BackgroundImage"), System.Drawing.Image)
        Me.PBMesCon.Location = New System.Drawing.Point(416, 107)
        Me.PBMesCon.Name = "PBMesCon"
        Me.PBMesCon.Size = New System.Drawing.Size(92, 37)
        Me.PBMesCon.TabIndex = 61
        Me.PBMesCon.TabStop = False
        '
        'PBAnioCon
        '
        Me.PBAnioCon.BackColor = System.Drawing.Color.Transparent
        Me.PBAnioCon.BackgroundImage = CType(resources.GetObject("PBAnioCon.BackgroundImage"), System.Drawing.Image)
        Me.PBAnioCon.Location = New System.Drawing.Point(605, 107)
        Me.PBAnioCon.Name = "PBAnioCon"
        Me.PBAnioCon.Size = New System.Drawing.Size(92, 37)
        Me.PBAnioCon.TabIndex = 60
        Me.PBAnioCon.TabStop = False
        '
        'PBSemanaCon
        '
        Me.PBSemanaCon.BackColor = System.Drawing.Color.Transparent
        Me.PBSemanaCon.BackgroundImage = CType(resources.GetObject("PBSemanaCon.BackgroundImage"), System.Drawing.Image)
        Me.PBSemanaCon.Location = New System.Drawing.Point(230, 107)
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
        Me.TSLabEstado.Size = New System.Drawing.Size(49, 17)
        Me.TSLabEstado.Text = "Estado"
        '
        'MCalendar
        '
        Me.MCalendar.Location = New System.Drawing.Point(9, 9)
        Me.MCalendar.MaxSelectionCount = 1
        Me.MCalendar.Name = "MCalendar"
        Me.MCalendar.ShowToday = False
        Me.MCalendar.TabIndex = 104
        '
        'LblState
        '
        Me.LblState.AutoSize = True
        Me.LblState.BackColor = System.Drawing.Color.Transparent
        Me.LblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblState.ForeColor = System.Drawing.Color.White
        Me.LblState.Location = New System.Drawing.Point(267, 42)
        Me.LblState.Name = "LblState"
        Me.LblState.Size = New System.Drawing.Size(55, 20)
        Me.LblState.TabIndex = 105
        Me.LblState.Text = "Vista:"
        '
        'LblVista
        '
        Me.LblVista.AutoSize = True
        Me.LblVista.BackColor = System.Drawing.Color.Transparent
        Me.LblVista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVista.ForeColor = System.Drawing.Color.White
        Me.LblVista.Location = New System.Drawing.Point(328, 42)
        Me.LblVista.Name = "LblVista"
        Me.LblVista.Size = New System.Drawing.Size(84, 20)
        Me.LblVista.TabIndex = 106
        Me.LblVista.Text = "TipoVista"
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.LblVista)
        Me.Controls.Add(Me.LblState)
        Me.Controls.Add(Me.MCalendar)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.PBMesCon)
        Me.Controls.Add(Me.PBAnioCon)
        Me.Controls.Add(Me.PBSemanaCon)
        Me.Controls.Add(Me.DatosConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        CType(Me.DatosConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMesCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAnioCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSemanaCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatosConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents PBMesCon As System.Windows.Forms.PictureBox
    Friend WithEvents PBAnioCon As System.Windows.Forms.PictureBox
    Friend WithEvents PBSemanaCon As System.Windows.Forms.PictureBox
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents TSLabEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents LblState As System.Windows.Forms.Label
    Friend WithEvents LblVista As System.Windows.Forms.Label
End Class
