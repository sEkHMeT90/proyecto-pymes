Option Explicit On
Option Strict On

''' <summary>
''' Formulario Principal
''' </summary>
''' <author>María Navarro, Pedro Zalacain</author>
Public Class Principal
    Private _Fecha As Date
    Private _HoraInicial As DateTime
    Private _HoraFinal As DateTime
    Private _Trabajadores As List(Of Trabajador)
    Private _Citas As List(Of Cita)
    Private _Notas As List(Of Nota)
    Private NotaActual As Integer

    ''' <summary>
    ''' Actualiza los datos del DataGrid
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub Actualizar()
        'Dim Minutos As Integer
        'Dim HoraCita As DateTime

        'Me._Citas = New List(Of Cita)
        'Me._Fecha = Now

        '' Recorro la columna de cada trabajador
        'For columna = 0 To Me.DGVCitas.Columns.Count - 1
        '    ' Recorro el intervalo de horas visible
        '    For Hora = Me._HoraInicial.Hour To Me._HoraFinal.Hour
        '        Minutos = 0
        '        ' Recorro los cuartos de cada hora
        '        For Cuarto = 0 To 3
        '            HoraCita = CDate("#" & Hora & ":" & Minutos & "#")

        '            ' Compruebo si hay una cita con esos parámetros
        '            Dim nueva As Cita = Cita.Obtener(Me._Trabajadores(columna).Codigo, Me._Fecha, HoraCita)

        '            ' Si la hay, la guardo
        '            If nueva IsNot Nothing Then
        '                Me._Citas.Add(nueva)
        '            End If

        '            Minutos += 15
        '        Next
        '    Next
        'Next

        '' Agrego las citas en las celdas correspondientes
        'If Me._Citas.Count > 0 Then
        '    HoraCita = Me._HoraInicial

        '    ' Por cada fila
        '    For fila = 0 To Me.DGVCitas.RowCount - 1
        '        ' Por cada trabajador
        '        For columna = 0 To Me.DGVCitas.Columns.Count - 1
        '            For Each cita In Me._Citas
        '                If cita.Trabajador.Codigo = Me._Trabajadores(columna).Codigo And cita.Hora = HoraCita Then
        '                    Me.DGVCitas.Rows(fila).Cells(columna).Value = cita.Servicios(0).Nombre
        '                End If
        '            Next
        '        Next

        '        HoraCita.AddMinutes(15)
        '    Next
        'End If
    End Sub

    ''' <summary>
    '''  Prepara el DataGrid para mostrar datos
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PrepararDataGrid()
        Me._Trabajadores = Trabajador.Cargar()

        Me.DGVCitas.ColumnCount = Me._Trabajadores.Count

        ' Agrego una columna por cada trabajador
        For i = 0 To Me._Trabajadores.Count - 1
            Me.DGVCitas.Columns(i).HeaderText = CStr(Me._Trabajadores(i).Nombre & " " & Me._Trabajadores(i).Apellido1)
        Next

        ' Agrego las filas para las 4 horas que se muestran
        For i = 0 To 15
            Me.DGVCitas.Rows.Add()
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._HoraInicial = #8:00:00 AM#
        Me._HoraFinal = #12:59:00 PM#
        Me._Fecha = Now()
        Me.PanelNotas.Visible = False
        Me.Timer1.Start()
        Me.PrepararDataGrid()
        Me.Actualizar()
        Me.CargarNotas()
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

    Private Sub NotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasToolStripMenuItem.Click
        If PanelNotas.Visible = True Then
            PanelNotas.Visible = False
        Else
            PanelNotas.Visible = True
        End If
    End Sub

    Private Sub CargarNotas()
        _Notas = Nota.Cargar()
        If _Notas.Count > 0 Then
            NotaActual = _Notas.Count - 1
            LblX.Text = CStr(NotaActual + 1)
            LblY.Text = CStr(_Notas.Count)
            TBoxNotas.Text = _Notas(NotaActual).Texto
        End If
    End Sub

    Private Sub PBAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAnterior.Click
        If NotaActual - 1 >= 0 Then
            NotaActual = NotaActual - 1
            LblX.Text = CStr(NotaActual + 1)
            TBoxNotas.Text = _Notas(NotaActual).Texto
        End If
    End Sub

    Private Sub PBSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBSiguiente.Click
        If NotaActual + 1 < _Notas.Count Then
            NotaActual = NotaActual + 1
            LblX.Text = CStr(NotaActual + 1)
            TBoxNotas.Text = _Notas(NotaActual).Texto
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If PanelNotas.Visible = True Then
            PanelNotas.Visible = False
        End If
    End Sub

    Private Sub PBBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrar.Click
        If _Notas.Count > 0 Then
            _Notas(NotaActual).Eliminar()
            _Notas.RemoveAt(NotaActual)
            If NotaActual - 1 >= 0 Then
                NotaActual = NotaActual - 1
                LblX.Text = CStr(NotaActual + 1)
            End If

            LblY.Text = CStr(_Notas.Count)

            If _Notas.Count > 0 Then
                TBoxNotas.Text = _Notas(NotaActual).Texto
            Else
                LblX.Text = "0"
                TBoxNotas.Text = ""
            End If
        End If
    End Sub

    Private Sub PBAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptar.Click
        If _Notas.Count > 0 Then
            _Notas(NotaActual).Texto = TBoxNotas.Text
            _Notas(NotaActual).Modificar()
        End If
    End Sub

    Private Sub LinkNuevo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkNuevo.LinkClicked
        Dim NewNota As New Nota
        _Notas.Add(NewNota)
        NotaActual = _Notas.Count - 1
        _Notas(NotaActual).Insertar()
        CargarNotas()
    End Sub
End Class
