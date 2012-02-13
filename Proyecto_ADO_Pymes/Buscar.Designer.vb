<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Buscar))
        Me.DataGridBuscar = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PBBuscarB = New System.Windows.Forms.PictureBox()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.TSLabEstado = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DataGridBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PBBuscarB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridBuscar
        '
        Me.DataGridBuscar.AllowUserToAddRows = False
        Me.DataGridBuscar.AllowUserToDeleteRows = False
        Me.DataGridBuscar.AllowUserToResizeColumns = False
        Me.DataGridBuscar.AllowUserToResizeRows = False
        Me.DataGridBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridBuscar.BackgroundColor = System.Drawing.Color.White
        Me.DataGridBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBuscar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridBuscar.Location = New System.Drawing.Point(70, 196)
        Me.DataGridBuscar.Name = "DataGridBuscar"
        Me.DataGridBuscar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridBuscar.RowHeadersVisible = False
        Me.DataGridBuscar.RowTemplate.ReadOnly = True
        Me.DataGridBuscar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridBuscar.Size = New System.Drawing.Size(648, 325)
        Me.DataGridBuscar.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PBBuscarB)
        Me.Panel2.Controls.Add(Me.TBBuscar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(70, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 113)
        Me.Panel2.TabIndex = 7
        '
        'PBBuscarB
        '
        Me.PBBuscarB.BackColor = System.Drawing.Color.Transparent
        Me.PBBuscarB.BackgroundImage = CType(resources.GetObject("PBBuscarB.BackgroundImage"), System.Drawing.Image)
        Me.PBBuscarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBBuscarB.Location = New System.Drawing.Point(529, 20)
        Me.PBBuscarB.Name = "PBBuscarB"
        Me.PBBuscarB.Size = New System.Drawing.Size(70, 70)
        Me.PBBuscarB.TabIndex = 19
        Me.PBBuscarB.TabStop = False
        '
        'TBBuscar
        '
        Me.TBBuscar.BackColor = System.Drawing.Color.White
        Me.TBBuscar.ForeColor = System.Drawing.Color.Black
        Me.TBBuscar.Location = New System.Drawing.Point(51, 47)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(435, 20)
        Me.TBBuscar.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 10
        '
        'BarraEstado
        '
        Me.BarraEstado.BackColor = System.Drawing.Color.Transparent
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLabEstado})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 540)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(784, 22)
        Me.BarraEstado.TabIndex = 103
        Me.BarraEstado.Text = "StatusStrip1"
        '
        'TSLabEstado
        '
        Me.TSLabEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLabEstado.ForeColor = System.Drawing.Color.White
        Me.TSLabEstado.Name = "TSLabEstado"
        Me.TSLabEstado.Size = New System.Drawing.Size(0, 17)
        '
        'Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridBuscar)
        Me.MaximizeBox = False
        Me.Name = "Buscar"
        Me.Text = "Buscar"
        CType(Me.DataGridBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PBBuscarB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridBuscar As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TBBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PBBuscarB As System.Windows.Forms.PictureBox
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents TSLabEstado As System.Windows.Forms.ToolStripStatusLabel
End Class
