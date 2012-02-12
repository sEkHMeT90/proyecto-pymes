Option Strict On
Option Explicit On

''' <summary>
''' NuevaCita: Clase para la inserción de nuevas citas
''' </summary>
''' <author>María Navarro, Andrés Marotta</author>
Public Class NuevaCita
    Private _Clientes As List(Of Cliente)
    Private _Empleados As List(Of Trabajador)

    Private Sub NuevaCita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Actualizar()
        Me.RellenarClientes()
        Me.RellenarEmpleados()
        Me.RellenarServicios()
    End Sub

    ''' <summary>
    ''' Reinicia todos los elementos del formulaio
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Public Sub Actualizar()
        Me.CBoxClienteC.SelectedIndex = -1
        Me.DPCitaC.Value = Now
        Me.CBoxHoraC.SelectedIndex = -1
        Me.CBoxMinC.SelectedIndex = -1
        Me.CBoxServiciosC.SelectedIndex = -1
        Me.CBoxEmpleadoC.SelectedIndex = -1
        Me.ListBServiciosC.Items.Clear()
    End Sub

    ''' <summary>
    ''' Rellena el ComboBox de Clientes
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub RellenarClientes()
        Me._Clientes = Cliente.Cargar()

        For Each cliente In Me._Clientes
            CBoxClienteC.Items.Add(cliente.DNI & " - " & cliente.Apellido1 & " " & cliente.Apellido2)
        Next
    End Sub

    ''' <summary>
    ''' Rellena el ComboBox de Empleados
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub RellenarEmpleados()
        Me._Empleados = Trabajador.Cargar()

        For Each empleado In Me._Empleados
            CBoxEmpleadoC.Items.Add(empleado.DNI & " - " & empleado.Apellido1 & " " & empleado.Apellido2)
        Next

    End Sub

    ''' <summary>
    ''' Rellena el ComboBox de Servicios
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub RellenarServicios()
        Dim servicios As List(Of Servicio)

        servicios = Servicio.Cargar()

        For Each servicio In servicios
            CBoxServiciosC.Items.Add(servicio.Nombre)
        Next
    End Sub

    ''' <summary>
    ''' Borra el elemento seleccionado del ListBox de servicios
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PBMenosC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBMenosC.Click
        If ListBServiciosC.SelectedIndex >= 0 Then
            ListBServiciosC.Items.Remove(ListBServiciosC.SelectedItem)
        End If
    End Sub

    ''' <summary>
    ''' Inserta una nueva cita con los datos del formulario
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PBAceptarC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptarC.Click
        Dim nueva As New Cita()

        nueva.Cliente.Codigo = Me._Clientes(CBoxClienteC.SelectedIndex).Codigo
        nueva.Trabajador.Codigo = Me._Empleados(CBoxEmpleadoC.SelectedIndex).Codigo
        nueva.Fecha = CDate(DPCitaC.Value.Day & "/" & DPCitaC.Value.Month & "/" & DPCitaC.Value.Year)
        nueva.Hora = CDate("#" & CBoxHoraC.Text & ":" & CBoxMinC.Text & "#")

        For Each elemento As String In ListBServiciosC.Items
            Dim servicio As Servicio
            servicio = servicio.ServicioPorNombre(elemento)
            nueva.Servicios.Add(servicio)
        Next

        For Each servicio In nueva.Servicios
            nueva.Duracion += servicio.Duracion
        Next

        Me.TSLabEstado.Text = "Insertando cita..."

        If nueva.Insertar() Then
            Me.TSLabEstado.Text = "Cita insertada satisfactoriamente"
        Else
            Me.TSLabEstado.Text = "Error al insertar la cita"
        End If
    End Sub

    ''' <summary>
    ''' Borra todos los campos del formulario
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PBBorrarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrarC.Click
        Me.Actualizar()
        Me.TSLabEstado.Text = ""
    End Sub

    ''' <summary>
    ''' Cierra el formulario
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PBCancelarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCancelarC.Click
        Me.Close()
        'Principal.Show()
    End Sub

    ''' <summary>
    ''' Inserta el elemento seleccionado en el ListBox de Servicios
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub CBoxServicios_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoxServiciosC.SelectedValueChanged
        If CBoxServiciosC.SelectedIndex >= 0 Then
            ListBServiciosC.Items.Add(CBoxServiciosC.SelectedItem.ToString)
        End If
    End Sub
End Class