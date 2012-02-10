Option Strict On
Option Explicit On


''' <summary>
''' Formulario NuevoUsuario
''' </summary>
''' <author> Pedro Zalacaín María Navarro</author>
Public Class NuevoCliente

    Dim _ListadoProvincias As List(Of Provincia)
    Dim _ListadoMunicipios As List(Of Municipio)

    ''' <summary>
    ''' Carga el listado de Provincias y muestra las mismas en el ComboBox
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub NuevoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _ListadoProvincias = Provincia.Cargar()

        CBProvinciaU.Items.Clear()

        If _ListadoProvincias IsNot Nothing Then
            For Each Prov In _ListadoProvincias
                CBProvinciaU.Items.Add(Prov.Nombre)
            Next
        End If

        TSLabEstado.Text = ""
    End Sub

    ''' <summary>
    ''' Carga el listado de Municipios al cambiar de Provincia y muestra los mismos en el ComboBox
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub CBProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProvinciaU.SelectedIndexChanged
        Dim ProvinciaActual As Integer = CBProvinciaU.SelectedIndex + 1
        _ListadoMunicipios = Municipio.Cargar(ProvinciaActual)

        CBPoblacionU.Items.Clear()

        If _ListadoMunicipios IsNot Nothing Then
            For Each Munic In _ListadoMunicipios
                CBPoblacionU.Items.Add(Munic.Nombre)
            Next
        End If

    End Sub

    ''' <summary>
    ''' Válida los campos e inserta en la Base de Datos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub InsertarCliente()
        Dim Mun As Municipio = _ListadoMunicipios.Item(CBPoblacionU.SelectedIndex + 1)
        Dim Dir As Direccion = New Direccion(TBCalleU.Text, CInt(TBNumeroU.Text), TBPisoU.Text, Mun)
        Dim Cli As Cliente = New Cliente(0, TBDniU.Text, TBNombreU.Text, TBApellido1U.Text, TBApellidoU.Text, Dir, TBFijoU.Text, TBMovilU.Text, TBEmailU.Text)

        If Cli.Insertar = True Then
            TSLabEstado.Text = "Usuario añadido corréctamente"
            BorrarCampos()
        Else
            TSLabEstado.Text = "Ocurrió un error mientras se insertaba el cliente"
        End If
    End Sub

    ''' <summary>
    ''' Borra el contenido de los campos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub BorrarCampos()
        TBNombreU.Text = ""
        TBApellido1U.Text = ""
        TBApellidoU.Text = ""
        TBDniU.Text = ""
        TBFijoU.Text = ""
        TBMovilU.Text = ""
        TBEmailU.Text = ""
        TBCalleU.Text = ""
        TBNumeroU.Text = ""
        TBPisoU.Text = ""
        CBProvinciaU.SelectedIndex = -1
        CBPoblacionU.SelectedIndex = -1
    End Sub

    Private Sub PBAceptarU_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptarU.Click
        Me.InsertarCliente()
    End Sub

    Private Sub PBBorrarU_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrarU.Click
        Me.BorrarCampos()
    End Sub

    Private Sub PBCancelarU_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCancelarU.Click
        Me.Close()
    End Sub
End Class

