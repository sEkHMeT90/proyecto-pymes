Option Explicit On
Option Strict On

''' <summary>
''' Formulario Principal
''' </summary>
''' <author>María Navarro, Pedro Zalacain</author>
Public Class Principal

    Private HoraInicial As Integer
    Private HoraFinal As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HoraInicial = 8
        HoraFinal = 20
        Timer1.Start()
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

    ''' <summary>
    ''' Navegación por el panel de citas del menú principal
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub PBArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBArriba.Click
        If CInt(LblHora1.Text) > 8 Then
            LblHora1.Text = (CInt(LblHora1.Text) - 1).ToString("00").ToString()
            LblHora2.Text = (CInt(LblHora2.Text) - 1).ToString("00").ToString()
            LblHora3.Text = (CInt(LblHora3.Text) - 1).ToString("00").ToString()
            LblHora4.Text = (CInt(LblHora4.Text) - 1).ToString("00").ToString()
        End If
    End Sub

    Private Sub PBAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAbajo.Click
        If CInt(LblHora4.Text) < 20 Then
            LblHora1.Text = (CInt(LblHora1.Text) + 1).ToString("00").ToString()
            LblHora2.Text = (CInt(LblHora2.Text) + 1).ToString("00").ToString()
            LblHora3.Text = (CInt(LblHora3.Text) + 1).ToString("00").ToString()
            LblHora4.Text = (CInt(LblHora4.Text) + 1).ToString("00").ToString()
        End If
    End Sub

    ''' <summary>
    ''' Acceso a los demás formularios desde el principal
    ''' </summary>
    ''' <author>María Navarro, Pedro Zalacain</author>
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
        NuevoServicio.ShowDialog()
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

    Private Sub ModificarToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem4.Click
        ModificarCita.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem1.Click
        ModificarServicios.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        ModificarEspecialidad.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
