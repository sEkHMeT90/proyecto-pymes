Public Class Principal

    Public Shared _BaseDatos As BBDD
    ''' <summary>
    ''' Formularios y diseño
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        _BaseDatos = New BBDD()
    End Sub

    ''' <summary>
    ''' Acceso a los demás formularios desde el principal
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NuevoCliente.Show()
    End Sub

    Private Sub PBUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBUsuario.Click
        NuevoCliente.Show()
    End Sub

    Private Sub PBCalendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBConsulta.Click
        Consulta.Show()
    End Sub

    Private Sub PBBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBuscar.Click
        Buscar.Show()
    End Sub

    Private Sub PBCita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCita.Click
        NuevaCita.Show()
    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivoToolStripMenuItem.Click
        ArchivoToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub GestiónUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónUsuariosToolStripMenuItem.Click
        GestiónUsuariosToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub PBFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBFactura.Click
        Facturacion.Show()
    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaciónToolStripMenuItem.Click
        Facturacion.Show()
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaToolStripMenuItem.Click
        NuevaEspecialidad.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem1.Click
        NuevoServicio.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem2.Click
        NuevoCliente.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem3.Click
        NuevoEmple.Show()
    End Sub

    Private Sub NuevaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaToolStripMenuItem1.Click
        NuevaCita.Show()
    End Sub

    ''' <summary>
    ''' Reloj
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub timer_tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblHora.Text = Now.Hour.ToString("00")
        LblMin.Text = Now.Minute.ToString("00")
        LblDia.Text = Now.Day.ToString("00")
        LblMes.Text = Now.Month.ToString("00")
        LblAnio.Text = Now.Year.ToString("0000")
    End Sub

   
End Class
