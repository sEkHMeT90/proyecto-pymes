Option Strict On
Option Explicit On

''' <summary>
''' Clase para la modificación y borrado de citas
''' </summary>
''' <author>Andrés Marotta</author>
Public Class ModificarCita
    Private _Citas As List(Of Cita)
    Private _Servicios As List(Of Servicio)
    Private _Trabajadores As List(Of Trabajador)
    Private _Actual As Integer

    ''' <summary>
    ''' Actualiza los elementos del formulario
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Public Sub Actualizar()
        Me.LBoxMCita.Items.Clear()

        For Each cita In Me._Citas
            Me.LBoxMCita.Items.Add(cita.Fecha.Day & "/" & cita.Fecha.Month & "/" & cita.Fecha.Year & " - " & _
                                   cita.Cliente.Apellido1 & " " & cita.Cliente.Apellido2 & ", " & cita.Cliente.Nombre)
        Next
    End Sub

    ''' <summary>
    ''' Carga las listas necesarias para el formulario
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub ModificarCita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CBoxServiciosMC.Items.Clear()
        Me._Servicios = Servicio.Cargar
        For Each servicio In Me._Servicios
            Me.CBoxServiciosMC.Items.Add(servicio.Nombre)
        Next

        Me.CBoxEmpleadoMC.Items.Clear()
        Me._Trabajadores = Trabajador.Cargar
        For Each empleado In Me._Trabajadores
            Me.CBoxEmpleadoMC.Items.Add(empleado.Nombre & " " & empleado.Apellido1)
        Next

        Me.TSLabEstado.Text = ""

        Me._Citas = Cita.Cargar
        Me.Actualizar()
    End Sub

    ''' <summary>
    ''' Rellena los campos del formulario con los valores de la cita seleccionada
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub LBoxMCita_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBoxMCita.SelectedIndexChanged
        If LBoxMCita.SelectedIndex >= 0 Then
            Me._Actual = LBoxMCita.SelectedIndex
            ListBServiciosMC.Items.Clear()

            Me.TBClienteMC.Text = Me._Citas(Me._Actual).Cliente.Nombre & " " & Me._Citas(Me._Actual).Cliente.Apellido1 & " " & Me._Citas(Me._Actual).Cliente.Apellido2
            Me.DPCitaMC.Value = Me._Citas(Me._Actual).Fecha
            Me.CBoxHoraMC.SelectedIndex = Me._Citas(Me._Actual).Hora.Hour - 8
            Me.CBoxMinMC.SelectedIndex = CInt(Me._Citas(Me._Actual).Hora.Minute / 15)
            Me.CBoxEmpleadoMC.Text = Me._Citas(Me._Actual).Trabajador.Nombre & " " & Me._Citas(Me._Actual).Trabajador.Apellido1

            For Each servicio In Me._Citas(Me._Actual).Servicios
                ListBServiciosMC.Items.Add(servicio.Nombre)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Agrega el servicio seleccionado a la lista de servicios de la cita
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub CBoxServiciosMC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoxServiciosMC.SelectedIndexChanged
        If CBoxServiciosMC.SelectedIndex >= 0 Then
            ListBServiciosMC.Items.Add(CBoxServiciosMC.Text)
        End If
    End Sub

    ''' <summary>
    ''' Elimina el servicio seleccionado de la lista de servicios de la cita
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PBMenosMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBMenosMC.Click
        If ListBServiciosMC.SelectedIndex >= 0 Then
            ListBServiciosMC.Items.RemoveAt(ListBServiciosMC.SelectedIndex)
        End If
    End Sub

    ''' <summary>
    ''' Guarda las modificaciones de la cita actual, previa confirmación
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PBModificarMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBModificarMC.Click
        Dim confirmacion As DialogResult

        If Me._Actual >= 0 Then
            confirmacion = MessageBox.Show("¿Está seguro de que desea modificar la cita actual?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If confirmacion = DialogResult.Yes Then
                TSLabEstado.Text = "Modificando cita..."
                Me._Citas(Me._Actual).Fecha = CDate(DPCitaMC.Value.Day & "/" & DPCitaMC.Value.Month & "/" & DPCitaMC.Value.Year)
                Me._Citas(Me._Actual).Hora = CDate(CBoxHoraMC.Text & ":" & CBoxMinMC.Text)
                Me._Citas(Me._Actual).Trabajador = Me._Trabajadores(CBoxEmpleadoMC.SelectedIndex)
                Me._Citas(Me._Actual).Servicios.Clear()

                For Each nombre As String In ListBServiciosMC.Items
                    Me._Citas(Me._Actual).Servicios.Add(Servicio.ServicioPorNombre(nombre))
                Next

                If Me._Citas(Me._Actual).Modifcar() Then
                    TSLabEstado.Text = "Cita modificada"
                    Me.Actualizar()
                Else
                    TSLabEstado.Text = "La cita no ha sido modificada"
                End If
            Else
                TSLabEstado.Text = "La cita no ha sido modificada"
            End If
        End If
    End Sub

    ''' <summary>
    ''' Borra la cita actual, previa confirmación
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PBBorrarMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrarMC.Click
        Dim confirmacion As DialogResult

        If Me._Actual >= 0 Then
            confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar la cita actual?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If confirmacion = DialogResult.Yes Then
                TSLabEstado.Text = "Eliminando cita..."

                If Me._Citas(Me._Actual).Borrar() Then
                    Me._Citas.RemoveAt(Me._Actual)
                    TSLabEstado.Text = "Cita eliminada"
                    Me.Actualizar()
                Else
                    TSLabEstado.Text = "La cita no ha sido eliminada"
                End If
            Else
                TSLabEstado.Text = "La cita no ha sido eliminada"
            End If
        End If
    End Sub

    ''' <summary>
    ''' Cierra el formulario
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PBCancelarMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCancelarMC.Click
        Me.Close()
    End Sub
End Class