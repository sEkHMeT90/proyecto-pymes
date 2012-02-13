Option Explicit On
Option Strict On

''' <summary>
''' Formulario ModificarCliente
''' </summary>
''' <author>María Navarro</author>
Public Class ModificarCliente
    Private ListaClientes As List(Of Cliente)
    Dim _ListadoProvincias As List(Of Provincia)
    Dim _ListadoMunicipios As List(Of Municipio)
    Private Sub ModificarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TSLabEstado.Text = ""
        CargarListBox()
    End Sub
    ''' <summary>
    ''' Cargar lista de clientes
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub CargarListBox()
        LBoxMC.Items.Clear()
        ListaClientes = Cliente.Cargar()
        For Each Client In ListaClientes
            LBoxMC.Items.Add(Client.Nombre)
        Next
    End Sub

    ''' <summary>
    '''cargamos en el form la lista
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub LBoxMC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBoxMC.SelectedIndexChanged
        CBPoblacionU.Items.Clear()
        CBProvinciaU.Items.Clear()

        If LBoxMC.Items.Count > 0 Then
            TBNombreMU.Text = ListaClientes.Item(LBoxMC.SelectedIndex).Nombre
            TBApellido1MU.Text = ListaClientes.Item(LBoxMC.SelectedIndex).Apellido1
            TBApellidoMU.Text = ListaClientes.Item(LBoxMC.SelectedIndex).Apellido2
            TBDniMU.Text = ListaClientes.Item(LBoxMC.SelectedIndex).DNI
            TBFijoMU.Text = CStr(ListaClientes.Item(LBoxMC.SelectedIndex).Particular)
            TBMovilMU.Text = CStr(ListaClientes.Item(LBoxMC.SelectedIndex).Movil)
            TBEmailMU.Text = ListaClientes.Item(LBoxMC.SelectedIndex).Email
            TBCalleMU.Text = ListaClientes.Item(LBoxMC.SelectedIndex).Direccion.Calle
            TBNumeroMU.Text = CStr(ListaClientes.Item(LBoxMC.SelectedIndex).Direccion.Numero)
            TBPisoMU.Text = CStr(ListaClientes.Item(LBoxMC.SelectedIndex).Direccion.Piso)
            CBProvinciaU.Items.Add(ListaClientes.Item(LBoxMC.SelectedIndex).Direccion.Municipio.Provincia.Nombre)
            CBPoblacionU.Items.Add(ListaClientes.Item(LBoxMC.SelectedIndex).Direccion.Municipio.Nombre)
            CBPoblacionU.SelectedIndex = 0
            CBProvinciaU.SelectedIndex = 0
        End If
    End Sub

    ''' <summary>
    ''' Modificar cliente
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub PBModificarMC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBModificarMC.Click
        Try
            TSLabEstado.Text = ""
            ListaClientes.Item(LBoxMC.SelectedIndex).Nombre = TBNombreMU.Text
            ListaClientes.Item(LBoxMC.SelectedIndex).Apellido1 = TBApellido1MU.Text
            ListaClientes.Item(LBoxMC.SelectedIndex).Apellido2 = TBApellidoMU.Text
            ListaClientes.Item(LBoxMC.SelectedIndex).Dni = TBDniMU.Text
            ListaClientes.Item(LBoxMC.SelectedIndex).Particular = TBFijoMU.Text
            ListaClientes.Item(LBoxMC.SelectedIndex).Movil = TBMovilMU.Text
            ListaClientes.Item(LBoxMC.SelectedIndex).Email = TBEmailMU.Text
            ListaClientes.Item(LBoxMC.SelectedIndex).Direccion.Calle = TBCalleMU.Text
            ListaClientes.Item(LBoxMC.SelectedIndex).Direccion.Numero = CInt(TBNumeroMU.Text)
            ListaClientes.Item(LBoxMC.SelectedIndex).Direccion.Piso = TBPisoMU.Text
            ListaClientes.Item(LBoxMC.SelectedIndex).Direccion.Municipio.Provincia.Nombre = CBProvinciaU.SelectedItem.ToString
            ListaClientes.Item(LBoxMC.SelectedIndex).Direccion.Municipio.Nombre = CBPoblacionU.SelectedItem.ToString

            If ListaClientes.Item(LBoxMC.SelectedIndex).Modificar() = True Then
                TSLabEstado.Text = "Cliente modificado satisfactoriamente"
                CargarListBox()
            Else
                TSLabEstado.Text = "Ocurrió un error mientras se intentaba modificar"
            End If
        Catch ex As Exception
            TSLabEstado.Text = "Debe seleccionar un cliente de la lista."
        End Try


    End Sub

    ''' <summary>
    ''' Borrar cliente
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub PBBorrarMC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrarMC.Click
        If ListaClientes.Item(LBoxMC.SelectedIndex).Eliminar() = True Then
            TSLabEstado.Text = "Cliente eliminado satisfactoriamente"
            CargarListBox()
            TBNombreMU.Text = ""
            TBApellido1MU.Text = ""
            TBApellidoMU.Text = ""
            TBDniMU.Text = ""
            TBFijoMU.Text = ""
            TBMovilMU.Text = ""
            TBEmailMU.Text = ""
            TBCalleMU.Text = ""
            TBNumeroMU.Text = ""
            TBPisoMU.Text = ""
            CBProvinciaU.Items.Clear()
            CBPoblacionU.Items.Clear()

        Else
            TSLabEstado.Text = "Ocurrió un error mientras se intentaba eliminar"
        End If
    End Sub

    ''' <summary>
    ''' cerrar form actual
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub PBCancelarMC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCancelarMC.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' cargar lista provincia
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub CBProvinciaU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProvinciaU.Click
        _ListadoProvincias = Provincia.Cargar()

        CBProvinciaU.Items.Clear()

        If _ListadoProvincias IsNot Nothing Then
            For Each Prov In _ListadoProvincias
                CBProvinciaU.Items.Add(Prov.Nombre)
            Next
        End If

        TSLabEstado.Text = ""
        CBPoblacionU.Items.Clear()
    End Sub

    ''' <summary>
    '''cargar lista poblacion
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub CBPoblacionU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPoblacionU.Click
        Dim ProvinciaActual As Integer = CBProvinciaU.SelectedIndex + 1
        _ListadoMunicipios = Municipio.Cargar(ProvinciaActual)

        CBPoblacionU.Items.Clear()

        If _ListadoMunicipios IsNot Nothing Then
            For Each Munic In _ListadoMunicipios
                CBPoblacionU.Items.Add(Munic.Nombre)

            Next
        End If
    End Sub
End Class

