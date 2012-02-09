Option Explicit On
Option Strict On

''' <summary>
''' Formulario Principal
''' </summary>
''' <author>María Navarro, Pedro Zalacain</author>
Public Class Principal

    Private _HoraInicial As Integer
    Private _HoraFinal As Integer
    Private _Trabajadores As List(Of Trabajador)
    Private _Citas As List(Of Cita)

    ''' <summary>
    ''' Actualiza los datos del DataGrid
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub Actualizar()
        Dim minutos As Integer = 0
        Dim hora As Integer = Me._HoraInicial - 1

        Me._Citas = Cita.Cargar

        ' Agrego tantas filas como horas, divididas en cuartos, haya
        For i = 0 To (Me._HoraFinal - Me._HoraInicial) * 4
            Me.DGVCitas.Rows.Add()
        Next

        ' Recorro cada fila del DataGridView
        For fila = 0 To Me.DGVCitas.RowCount - 1

            For columna = 0 To Me.DGVCitas.ColumnCount - 1
                For Each cita In Me._Citas
                    If cita.Hora = hora And cita.Minutos = minutos Then
                        If CStr(cita.Trabajador.Codigo) = Me.DGVCitas.Columns(columna).HeaderText Then
                            Me.DGVCitas.Rows(fila).Cells(columna).Value = cita.Cliente.Apellido1
                        End If
                    End If
                Next
            Next

            If minutos < 45 Then
                minutos += 15
            Else
                minutos = 0
            End If

            If fila Mod 4 = 0 Then
                hora += 1
            End If
        Next

        'If Me._Citas.Count > 0 Then
        '    For i = 0 To Me.DGVCitas.RowCount - 1

        '    Next
        'End If

        'If Me._Citas.Count > 0 Then
        '    For i = 0 To Me._Citas.Count - 1
        '        For j = 0 To Me._Trabajadores.Count - 1
        '            If Me._Citas(i).Trabajador.Codigo = j Then
        '                Me.DGVCitas.Rows(i).Cells(j).Value = Me._Citas(i).Cliente.Apellido1
        '            End If
        '        Next
        '    Next
        'Else
        '    MsgBox("No hay citas")
        'End If
    End Sub

    ''' <summary>
    '''  Prepara el DataGrid para mostrar datos
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PrepararDataGrid()
        Me._Trabajadores = Trabajador.Cargar()

        Me.DGVCitas.ColumnCount = Me._Trabajadores.Count

        For i = 0 To Me._Trabajadores.Count - 1
            Me.DGVCitas.Columns(i).HeaderText = CStr(Me._Trabajadores(i).Codigo)
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _HoraInicial = 8
        _HoraFinal = 20
        Timer1.Start()
        PrepararDataGrid()
        Actualizar()
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
            LblHora1.Text = (CInt(LblHora1.Text) - 1).ToString("00")
            LblHora2.Text = (CInt(LblHora2.Text) - 1).ToString("00")
            LblHora3.Text = (CInt(LblHora3.Text) - 1).ToString("00")
            LblHora4.Text = (CInt(LblHora4.Text) - 1).ToString("00")
        End If
    End Sub

    Private Sub PBAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAbajo.Click
        If CInt(LblHora4.Text) < 20 Then
            LblHora1.Text = (CInt(LblHora1.Text) + 1).ToString("00")
            LblHora2.Text = (CInt(LblHora2.Text) + 1).ToString("00")
            LblHora3.Text = (CInt(LblHora3.Text) + 1).ToString("00")
            LblHora4.Text = (CInt(LblHora4.Text) + 1).ToString("00")
        End If
    End Sub

    ''' <summary>
    ''' Acceso a los demás formularios desde el principal
    ''' </summary>
    ''' <author>María Navarro, Pedro Zalacain</author>
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NuevoCliente.ShowDialog()
    End Sub

    Private Sub PBUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBUsuario.Click
        NuevoCliente.ShowDialog()
    End Sub

    Private Sub PBCalendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBConsulta.Click
        Consulta.ShowDialog()
    End Sub

    Private Sub PBBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBuscar.Click
        Buscar.ShowDialog()
    End Sub

    Private Sub PBCita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCita.Click
        NuevaCita.ShowDialog()
    End Sub

    Private Sub PBFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBFactura.Click
        Facturacion.ShowDialog()
    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaciónToolStripMenuItem.Click
        Facturacion.ShowDialog()
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaToolStripMenuItem.Click
        NuevaEspecialidad.ShowDialog()
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem1.Click
        NuevoServicio.ShowDialog()
    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem2.Click
        NuevoCliente.ShowDialog()
    End Sub

    Private Sub NuevoToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem3.Click
        NuevoEmple.ShowDialog()
    End Sub

    Private Sub NuevaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaToolStripMenuItem1.Click
        NuevaCita.ShowDialog()
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

    Private Sub ModificarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem2.Click
        ModificarCliente.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem3.Click
        ModificarEmpleado.ShowDialog()
    End Sub
End Class
