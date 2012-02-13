Option Strict On
Option Explicit On

''' <summary>
''' Formulario NuevoUsuario
''' </summary>
''' <author>María Navarro</author>
Public Class NuevoEmple

    Dim _ListadoProvincias As List(Of Provincia)
    Dim _ListadoMunicipios As List(Of Municipio)
    Dim _ListadoEspecialidades As List(Of Especialidad)

    ''' <summary>
    ''' Carga el listado de Provincias y  especialidades y muestra las mismas en el ComboBox
    ''' </summary>
    ''' <author>Maria Navarro</author>
    Private Sub NuevoEmple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _ListadoProvincias = Provincia.Cargar()
        _ListadoEspecialidades = Especialidad.Cargar()
        CBEspecialidadE.Items.Clear()
        CBProvinciaE.Items.Clear()

        If _ListadoProvincias IsNot Nothing Then
            For Each Prov In _ListadoProvincias
                CBProvinciaE.Items.Add(Prov.Nombre)
            Next
        End If

        If _ListadoEspecialidades IsNot Nothing Then
            For Each Espec In _ListadoEspecialidades
                CBEspecialidadE.Items.Add(Espec.Nombre)
            Next
        End If

        TSLabEstado.Text = ""
    End Sub

    ''' <summary>
    ''' Carga el listado de Municipios al cambiar de Provincia y muestra los mismos en el ComboBox
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub CBProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProvinciaE.SelectedIndexChanged
        Dim ProvinciaActual As Integer = CBProvinciaE.SelectedIndex + 1
        _ListadoMunicipios = Municipio.Cargar(ProvinciaActual)

        CBPoblacionE.Items.Clear()

        If _ListadoMunicipios IsNot Nothing Then
            For Each Munic In _ListadoMunicipios
                CBPoblacionE.Items.Add(Munic.Nombre)
            Next
        End If

    End Sub

    ''' <summary>
    ''' Inserta el Empleado en la BBDD
    ''' </summary>
    ''' <author>Pedro Zalacain, María Navarro</author>
    Private Sub InsertarEmpleado()
        Dim Mun As Municipio = _ListadoMunicipios.Item(CBPoblacionE.SelectedIndex)
        Dim Dir As Direccion = New Direccion(TBCalleE.Text, CInt(TBNumeroE.Text), TBPisoE.Text, Mun)
        Dim Trabaj As Trabajador = New Trabajador(0, TBDniE.Text, TBNombreE.Text, TBApellido1E.Text, TBApellido2E.Text, Dir, TBFijoE.Text, TBMovilE.Text, TBEmailE.Text, CInt(TBNumSSE.Text), CDbl(TBSueldoE.Text), CStr(CBEspecialidadE.SelectedIndex))

        If Trabaj.Insertar = True Then
            TSLabEstado.Text = "Empleado agregado correctamente"
            Me.BorrarCampos()
        Else
            TSLabEstado.Text = "Ocurrio un error mientras se insertaba el empleado"
        End If
    End Sub

    ''' <summary>
    ''' Vacía el contenido de los campos
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub BorrarCampos()
        TBNombreE.Text = ""
        TBApellido1E.Text = ""
        TBApellido2E.Text = ""
        TBDniE.Text = ""
        TBFijoE.Text = ""
        TBMovilE.Text = ""
        TBEmailE.Text = ""
        TBCalleE.Text = ""
        TBNumeroE.Text = ""
        TBPisoE.Text = ""
        TBNumSSE.Text = ""
        TBSueldoE.Text = ""
        CBEspecialidadE.SelectedIndex = -1
        CBProvinciaE.SelectedIndex = -1
        CBPoblacionE.SelectedIndex = -1
    End Sub

    ''' <summary>
    ''' Valida los campos e inserta en la Base de Datos
    ''' </summary>
    ''' <author> Maria Navarro</author>

    Private Sub PBAceptarE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptarE.Click
        Me.InsertarEmpleado()
    End Sub

    Private Sub PBBorrarE_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrarE.Click
        Me.BorrarCampos()
    End Sub

    Private Sub PBCancelarE_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCancelarE.Click
        Me.Close()
    End Sub
End Class


