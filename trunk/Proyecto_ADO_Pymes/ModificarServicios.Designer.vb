﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarServicios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBPrecioSM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBDuracionSM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBDescripcionSM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNombreSM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBoxServiciosM = New System.Windows.Forms.ListBox()
        Me.PBCancelarMC = New System.Windows.Forms.PictureBox()
        Me.PBBorrarMC = New System.Windows.Forms.PictureBox()
        Me.PBModificarMC = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSLblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBCancelarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBorrarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBModificarMC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBPrecioSM)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBDuracionSM)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBDescripcionSM)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBNombreSM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(321, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 254)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servicio"
        '
        'TBPrecioSM
        '
        Me.TBPrecioSM.BackColor = System.Drawing.Color.Thistle
        Me.TBPrecioSM.ForeColor = System.Drawing.Color.Black
        Me.TBPrecioSM.Location = New System.Drawing.Point(145, 194)
        Me.TBPrecioSM.Name = "TBPrecioSM"
        Me.TBPrecioSM.Size = New System.Drawing.Size(190, 22)
        Me.TBPrecioSM.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(28, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Precio"
        '
        'TBDuracionSM
        '
        Me.TBDuracionSM.BackColor = System.Drawing.Color.Thistle
        Me.TBDuracionSM.ForeColor = System.Drawing.Color.Black
        Me.TBDuracionSM.Location = New System.Drawing.Point(145, 142)
        Me.TBDuracionSM.Name = "TBDuracionSM"
        Me.TBDuracionSM.Size = New System.Drawing.Size(190, 22)
        Me.TBDuracionSM.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Duración"
        '
        'TBDescripcionSM
        '
        Me.TBDescripcionSM.BackColor = System.Drawing.Color.Thistle
        Me.TBDescripcionSM.ForeColor = System.Drawing.Color.Black
        Me.TBDescripcionSM.Location = New System.Drawing.Point(145, 90)
        Me.TBDescripcionSM.Multiline = True
        Me.TBDescripcionSM.Name = "TBDescripcionSM"
        Me.TBDescripcionSM.Size = New System.Drawing.Size(190, 20)
        Me.TBDescripcionSM.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripción"
        '
        'TBNombreSM
        '
        Me.TBNombreSM.BackColor = System.Drawing.Color.Thistle
        Me.TBNombreSM.ForeColor = System.Drawing.Color.Black
        Me.TBNombreSM.Location = New System.Drawing.Point(145, 39)
        Me.TBNombreSM.Name = "TBNombreSM"
        Me.TBNombreSM.Size = New System.Drawing.Size(190, 22)
        Me.TBNombreSM.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre"
        '
        'LBoxServiciosM
        '
        Me.LBoxServiciosM.FormattingEnabled = True
        Me.LBoxServiciosM.Location = New System.Drawing.Point(63, 7)
        Me.LBoxServiciosM.Name = "LBoxServiciosM"
        Me.LBoxServiciosM.Size = New System.Drawing.Size(192, 251)
        Me.LBoxServiciosM.TabIndex = 96
        '
        'PBCancelarMC
        '
        Me.PBCancelarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBCancelarMC.BackgroundImage = CType(resources.GetObject("PBCancelarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBCancelarMC.Location = New System.Drawing.Point(546, 269)
        Me.PBCancelarMC.Name = "PBCancelarMC"
        Me.PBCancelarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBCancelarMC.TabIndex = 102
        Me.PBCancelarMC.TabStop = False
        '
        'PBBorrarMC
        '
        Me.PBBorrarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBBorrarMC.BackgroundImage = CType(resources.GetObject("PBBorrarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBBorrarMC.Location = New System.Drawing.Point(470, 269)
        Me.PBBorrarMC.Name = "PBBorrarMC"
        Me.PBBorrarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBBorrarMC.TabIndex = 101
        Me.PBBorrarMC.TabStop = False
        '
        'PBModificarMC
        '
        Me.PBModificarMC.BackColor = System.Drawing.Color.Transparent
        Me.PBModificarMC.BackgroundImage = CType(resources.GetObject("PBModificarMC.BackgroundImage"), System.Drawing.Image)
        Me.PBModificarMC.Location = New System.Drawing.Point(394, 269)
        Me.PBModificarMC.Name = "PBModificarMC"
        Me.PBModificarMC.Size = New System.Drawing.Size(70, 70)
        Me.PBModificarMC.TabIndex = 100
        Me.PBModificarMC.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSLblEstado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 350)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(744, 22)
        Me.StatusStrip1.TabIndex = 103
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSLblEstado
        '
        Me.TSLblEstado.Name = "TSLblEstado"
        Me.TSLblEstado.Size = New System.Drawing.Size(40, 17)
        Me.TSLblEstado.Text = "Estado"
        '
        'ModificarServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 372)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PBCancelarMC)
        Me.Controls.Add(Me.PBBorrarMC)
        Me.Controls.Add(Me.PBModificarMC)
        Me.Controls.Add(Me.LBoxServiciosM)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ModificarServicios"
        Me.Text = "Modificar Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBCancelarMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBorrarMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBModificarMC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBPrecioSM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBDuracionSM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBDescripcionSM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNombreSM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBoxServiciosM As System.Windows.Forms.ListBox
    Friend WithEvents PBCancelarMC As System.Windows.Forms.PictureBox
    Friend WithEvents PBBorrarMC As System.Windows.Forms.PictureBox
    Friend WithEvents PBModificarMC As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSLblEstado As System.Windows.Forms.ToolStripStatusLabel
End Class