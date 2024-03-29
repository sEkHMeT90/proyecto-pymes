﻿Option Explicit On
Option Strict On

''' <summary>
''' Formulario Principal
''' </summary>
''' <author>María Navarro, Pedro Zalacain</author>
Public Class Principal
    Private _Fecha As Date
    Private _HoraInicial As Integer
    Private _HoraFinal As Integer
    Private _Trabajadores As List(Of Trabajador)
    Private _Citas As List(Of Cita)
    Private _Notas As List(Of Nota)
    Private _NotaActual As Integer

    ''' <summary>
    ''' Actualiza los datos del DataGrid
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub Actualizar()
        Dim Fila As Integer = 0
        Dim Minutos As Integer
        Dim HoraCita As DateTime

        Me.DGVCitas.Rows.Clear()
        Me.PrepararDataGrid()

        ' Recorro las horas
        For Hora = Me._HoraInicial To Me._HoraFinal
            Minutos = 0
            ' Recorro los cuartos de cada hora
            For Cuarto = 0 To 3
                HoraCita = CDate("#" & Hora & ":" & Minutos & "#")

                ' Recorro la columna de cada trabajador
                For Columna = 0 To Me.DGVCitas.Columns.Count - 1
                    ' Compruebo si hay una cita con esos parámetros
                    Dim nueva As Cita = Cita.Obtener(Me._Trabajadores(Columna).Codigo, Me._Fecha, HoraCita)

                    ' Si la hay, la guardo
                    If nueva IsNot Nothing Then
                        For i = 0 To nueva.Duracion Step 15
                            If i <= nueva.Servicios.Count Then
                                Me.DGVCitas.Rows(Fila + i).Cells(Columna).Value = nueva.Servicios(i).Nombre & " - " & _
                                                                                  nueva.Cliente.Apellido1
                            Else
                                Me.DGVCitas.Rows(Fila + CInt((i / 15))).Cells(Columna).Value = nueva.Servicios(0).Nombre & " - " & _
                                                                                               nueva.Cliente.Apellido1
                            End If
                        Next
                    End If
                Next

                Minutos += 15

                If Fila <= 11 Then
                    Fila += 1
                End If
            Next
        Next
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
        Me._HoraInicial = 8
        Me._HoraFinal = 13
        Me._Fecha = CDate(Now.Day & "/" & Now.Month & "/" & Now.Year)
        Me.PanelNotas.Visible = False
        Me.Timer1.Start()
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
            Me._HoraInicial -= 1
            Me._HoraFinal -= 1
            Me.Actualizar()
        End If
    End Sub

    Private Sub PBAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAbajo.Click
        If CInt(LblHora4.Text) < 20 Then
            LblHora1.Text = (CInt(LblHora1.Text) + 1).ToString("00")
            LblHora2.Text = (CInt(LblHora2.Text) + 1).ToString("00")
            LblHora3.Text = (CInt(LblHora3.Text) + 1).ToString("00")
            LblHora4.Text = (CInt(LblHora4.Text) + 1).ToString("00")
            Me._HoraInicial += 1
            Me._HoraFinal += 1
            Me.Actualizar()
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
        If Not Me.DGVCitas.CurrentCell.Value Is Nothing Then
            Dim nueva As Cita
            Dim hora As DateTime
            hora = CDate((((Me.DGVCitas.CurrentCell.RowIndex) \ 4) + Me._HoraInicial) & ":" & (((Me.DGVCitas.CurrentCell.RowIndex) Mod 4) * 15))
            nueva = Cita.Obtener(Me._Trabajadores(Me.DGVCitas.CurrentCell.ColumnIndex).Codigo, Me._Fecha, hora)

            If nueva IsNot Nothing Then
                Dim factura As New Facturacion(nueva)
                factura.Show()
            End If
        Else
            MessageBox.Show("Debe seleccionar una cita a cobrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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
            LBLNotas.Text = ""
        End If
    End Sub

    Private Sub CargarNotas()
        _Notas = Nota.Cargar()
        If _Notas.Count > 0 Then
            _NotaActual = _Notas.Count - 1
            LblX.Text = CStr(_NotaActual + 1)
            LblY.Text = CStr(_Notas.Count)
            TBoxNotas.Text = _Notas(_NotaActual).Texto
        End If
    End Sub

    Private Sub PBAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAnterior.Click
        If _NotaActual - 1 >= 0 Then
            _NotaActual = _NotaActual - 1
            LblX.Text = CStr(_NotaActual + 1)
            TBoxNotas.Text = _Notas(_NotaActual).Texto
            LBLNotas.Text = ""
        End If
    End Sub

    Private Sub PBSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBSiguiente.Click
        If _NotaActual + 1 < _Notas.Count Then
            _NotaActual = _NotaActual + 1
            LblX.Text = CStr(_NotaActual + 1)
            TBoxNotas.Text = _Notas(_NotaActual).Texto
            LBLNotas.Text = ""
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If PanelNotas.Visible = True Then
            PanelNotas.Visible = False
        End If
    End Sub

    Private Sub PBBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrar.Click
        If _Notas.Count > 0 Then
            _Notas(_NotaActual).Eliminar()
            _Notas.RemoveAt(_NotaActual)
            LBLNotas.Text = "- Nota eliminada..."
            If _NotaActual - 1 >= 0 Then
                _NotaActual = _NotaActual - 1
                LblX.Text = CStr(_NotaActual + 1)
            End If

            LblY.Text = CStr(_Notas.Count)

            If _Notas.Count > 0 Then
                TBoxNotas.Text = _Notas(_NotaActual).Texto
            Else
                LblX.Text = "0"
                TBoxNotas.Text = ""
            End If
        End If
    End Sub

    Private Sub PBAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptar.Click
        If _Notas.Count > 0 Then
            _Notas(_NotaActual).Texto = TBoxNotas.Text
            _Notas(_NotaActual).Modificar()
            LBLNotas.Text = "- Nota modificada..."
        End If
    End Sub

    Private Sub LinkNuevo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkNuevo.LinkClicked
        Dim NewNota As New Nota
        NewNota.Insertar()
        LBLNotas.Text = "- Nota creada..."
        CargarNotas()
    End Sub

    Private Sub DPfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DPfecha.ValueChanged
        Me._Fecha = CDate(DPfecha.Value.Day & "/" & DPfecha.Value.Month & "/" & Me.DPfecha.Value.Year)
        Me.Actualizar()
    End Sub
End Class
