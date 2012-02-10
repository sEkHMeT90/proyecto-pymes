Public Class NuevaCita
    Private _Clientes As List(Of Cliente)
    Private _Empleados As List(Of Trabajador)

    Private Sub NuevaCita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RellenarClientes()
        RellenarEmpleados()
        RellenarServicios()
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub CBoxServicios_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoxServiciosC.SelectedValueChanged
        ListBServiciosC.Items.Add(CBoxServiciosC.SelectedItem.ToString)
    End Sub

    Private Sub PBAceptarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nueva As New Cita()

        nueva.Cliente.Codigo = Me._Clientes(CBoxClienteC.SelectedIndex).Codigo
        nueva.Trabajador.Codigo = Me._Empleados(CBoxEmpleadoC.SelectedIndex).Codigo
        nueva.Fecha = CDate(DPCitaC.Value.Day & "/" & DPCitaC.Value.Month & "/" & DPCitaC.Value.Month)
        nueva.Hora = CInt(CBoxHoraC.Text)
        nueva.Minutos = CInt(CBoxMinC.Text)

        For Each elemento As String In ListBServiciosC.Items
            Dim servicio As Servicio
            servicio = servicio.ServicioPorNombre(elemento)
            nueva.Servicios.Add(servicio)
        Next

        If nueva.Insertar() Then
            MsgBox("Cita insertada")
        Else
            MsgBox("No se ha insertado la cita")
        End If
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
End Class