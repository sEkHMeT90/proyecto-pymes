Option Strict On
Option Explicit On


''' <summary>
''' Formulario NuevoUsuario
''' </summary>
''' <author> Pedro Zalacaín María Navarro</author>
Public Class NuevoUsuario

    Dim _ListadoProvincias As List(Of Provincia)
    Dim _ListadoMunicipios As List(Of Municipio)

    ''' <summary>
    ''' Carga el listado de Provincias y muestra las mismas en el ComboBox
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub NuevoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _ListadoProvincias = Provincia.Cargar()

        CBProvincia.Items.Clear()

        If _ListadoProvincias IsNot Nothing Then
            For Each Prov In _ListadoProvincias
                CBProvincia.Items.Add(Prov.Nombre)
            Next
        End If
        
    End Sub

    ''' <summary>
    ''' Carga el listado de Municipios al cambiar de Provincia y muestra los mismos en el ComboBox
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub CBProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProvincia.SelectedIndexChanged
        Dim ProvinciaActual As Integer = CBProvincia.SelectedIndex + 1
        _ListadoMunicipios = Municipio.Cargar(ProvinciaActual)

        CBPoblacion.Items.Clear()

        If _ListadoMunicipios IsNot Nothing Then
            For Each Munic In _ListadoMunicipios
                CBPoblacion.Items.Add(Munic.Nombre)
            Next
        End If

    End Sub

    ''' <summary>
    ''' Cierra el formulario y no realiza nada
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Válida los campos e inserta en la Base de Datos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub PBAceptarU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptarU.Click
        Dim Mun As Municipio = _ListadoMunicipios.Item(CBPoblacion.SelectedIndex + 1)
        Dim Dir As Direccion = New Direccion(TBCalle.Text, CInt(TBNumero.Text), TBPiso.Text, Mun)
        Dim Cli As Cliente = New Cliente(0, TBDni.Text, TBNombre.Text, TBApellido1.Text, TBApellido2.Text, Dir, TBFijo.Text, TBMovil.Text, TBEmail.Text)

        If Cli.InsertarCliente = True Then
            MessageBox.Show("Cliente añadido a la base de datos")
            Borrar()
            'Me.Close()
        Else
            MessageBox.Show("Ocurrio un error mientras se intentaba acceder a los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    ''' <summary>
    ''' Vacía el contenido de los campos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        Borrar()
    End Sub

    Private Sub Borrar()
        TBNombre.Text = ""
        TBApellido1.Text = ""
        TBApellido2.Text = ""
        TBDni.Text = ""
        TBFijo.Text = ""
        TBMovil.Text = ""
        TBEmail.Text = ""
        TBCalle.Text = ""
        TBNumero.Text = ""
        TBPiso.Text = ""
        CBProvincia.SelectedIndex = -1
        CBPoblacion.SelectedIndex = -1
    End Sub
End Class

