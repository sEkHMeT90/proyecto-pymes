Public Class NuevaCita

    Private Sub NuevaCita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RellenarClientes()
        ' RellenarEmpleados()
        RellenarServicios()
    End Sub

    ''' <summary>
    ''' Rellena el ComboBox de Clientes
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub RellenarClientes()
        Dim clientes As List(Of Cliente)

        clientes = Cliente.Cargar()

        For Each cliente In clientes
            CBoxClienteC.Items.Add(cliente.Apellido1 & " " & cliente.Apellido2 & ", " & cliente.Nombre)
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' If ListBServicios.SelectedItem = 0 Then
        'MsgBox(ListBServicios.SelectedItem)
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub CBoxServicios_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoxServiciosC.SelectedValueChanged
        ListBServiciosC.Items.Add(CBoxServiciosC.SelectedItem.ToString)
    End Sub

    Private Sub PBAceptarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptarC.Click, LblAceptarC.Click
        Dim nueva As New Cita()

        nueva.Cliente.Codigo = CInt(CBoxClienteC.Text)
        nueva.Trabajador.Codigo = CInt(CBoxEmpleadoC.Text)
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
End Class