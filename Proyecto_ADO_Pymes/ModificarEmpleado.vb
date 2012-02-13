Option Explicit On
Option Strict On

''' <summary>
''' Formulario ModificarCliente
''' </summary>
''' <author>María Navarro</author>
Public Class ModificarEmpleado
    Private ListaEmpleados As List(Of Trabajador)
    Dim _ListadoProvincias As List(Of Provincia)
    Dim _ListadoMunicipios As List(Of Municipio)
    Private _ListadoEspecialidades As List(Of Especialidad)

    ''' <summary>
    ''' load
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub ModificarEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TSLabEstado.Text = ""
        CargarListBoxEmple()
    End Sub

    ''' <summary>
    ''' Cargar lista
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub CargarListBoxEmple()
        LBoxME.Items.Clear()
        ListaEmpleados = Trabajador.Cargar()
        For Each Emple In ListaEmpleados
            LBoxME.Items.Add(Emple.Nombre)
        Next
    End Sub

    ''' <summary>
    ''' rellenar campos form
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub LBoxMC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBoxME.SelectedIndexChanged
        CBPoblacionU.Items.Clear()
        CBProvinciaU.Items.Clear()
        CBEspecialidadE.Items.Clear()

        CBEspecialidadE_Click(sender, e)
        CBEspecialidadE.SelectedIndex = Trabajador.NombreEspecialidad(ListaEmpleados.Item(LBoxME.SelectedIndex).Codigo) - 1

        If LBoxME.SelectedIndex >= 0 Then
            TBNombreE.Text = ListaEmpleados.Item(LBoxME.SelectedIndex).Nombre
            TBApellido1E.Text = ListaEmpleados.Item(LBoxME.SelectedIndex).Apellido1
            TBApellido2E.Text = ListaEmpleados.Item(LBoxME.SelectedIndex).Apellido2
            TBDniE.Text = ListaEmpleados.Item(LBoxME.SelectedIndex).Dni
            TBFijoE.Text = ListaEmpleados.Item(LBoxME.SelectedIndex).Particular
            TBMovilE.Text = ListaEmpleados.Item(LBoxME.SelectedIndex).Movil
            TBEmailE.Text = ListaEmpleados.Item(LBoxME.SelectedIndex).Email
            TBNumSSE.Text = ListaEmpleados.Item(LBoxME.SelectedIndex).Movil
            TBSueldoE.Text = ListaEmpleados.Item(LBoxME.SelectedIndex).Email
            CBEspecialidadE.Items.Add(ListaEmpleados.Item(LBoxME.SelectedIndex))
            TBCalleMU.Text = ListaEmpleados.Item(LBoxME.SelectedIndex).Direccion.Calle
            TBNumeroMU.Text = CStr(ListaEmpleados.Item(LBoxME.SelectedIndex).Direccion.Numero)
            TBPisoMU.Text = CStr(ListaEmpleados.Item(LBoxME.SelectedIndex).Direccion.Piso)
            CBProvinciaU.Items.Add(ListaEmpleados.Item(LBoxME.SelectedIndex).Direccion.Municipio.Provincia.Nombre)
            CBPoblacionU.Items.Add(ListaEmpleados.Item(LBoxME.SelectedIndex).Direccion.Municipio.Nombre)
            CBPoblacionU.SelectedIndex = 0
            CBProvinciaU.SelectedIndex = 0

        End If
    End Sub

    ''' <summary>
    ''' Modificar empleados
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub PBModificarMC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBModificarMC.Click
        Try
            Dim pasarCodigo As Integer
            pasarCodigo = ListaEmpleados.Item(LBoxME.SelectedIndex).Codigo
            TSLabEstado.Text = ""
            ListaEmpleados.Item(LBoxME.SelectedIndex).Nombre = TBNombreE.Text
            ListaEmpleados.Item(LBoxME.SelectedIndex).Apellido1 = TBApellido1E.Text
            ListaEmpleados.Item(LBoxME.SelectedIndex).Apellido2 = TBApellido2E.Text
            ListaEmpleados.Item(LBoxME.SelectedIndex).Dni = TBDniE.Text
            ListaEmpleados.Item(LBoxME.SelectedIndex).Particular = TBFijoE.Text
            ListaEmpleados.Item(LBoxME.SelectedIndex).Movil = TBMovilE.Text
            ListaEmpleados.Item(LBoxME.SelectedIndex).Email = TBEmailE.Text
            ListaEmpleados.Item(LBoxME.SelectedIndex).Direccion.Calle = TBCalleMU.Text
            ListaEmpleados.Item(LBoxME.SelectedIndex).Direccion.Numero = CInt(TBNumeroMU.Text)
            ListaEmpleados.Item(LBoxME.SelectedIndex).Direccion.Piso = TBPisoMU.Text
            ListaEmpleados.Item(LBoxME.SelectedIndex).Direccion.Municipio.Provincia.Nombre = CBProvinciaU.SelectedItem.ToString
            ListaEmpleados.Item(LBoxME.SelectedIndex).Direccion.Municipio.Nombre = CBPoblacionU.SelectedItem.ToString
            ModificarEspecialidad(CInt(CBEspecialidadE.SelectedIndex + 1), pasarCodigo)

            If ListaEmpleados.Item(LBoxME.SelectedIndex).Modificar() = True Then
                TSLabEstado.Text = "Empleado modificado satisfactoriamente"
                CargarListBoxEmple()
            Else
                TSLabEstado.Text = "Ocurrió un error mientras se intentaba modificar"
            End If
        Catch ex As Exception
            TSLabEstado.Text = "Debe seleccionar un cliente de la lista."
        End Try


    End Sub

    ''' <summary>
    ''' Borrar campos
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub PBBorrarMC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrarMC.Click
        If ListaEmpleados.Item(LBoxME.SelectedIndex).Eliminar() = True Then
            TSLabEstado.Text = "Empleado eliminado satisfactoriamente"
            CargarListBoxEmple()
            TBNombreE.Text = ""
            TBApellido1E.Text = ""
            TBApellido2E.Text = ""
            TBDniE.Text = ""
            TBFijoE.Text = ""
            TBMovilE.Text = ""
            TBEmailE.Text = ""
            TBNumSSE.Text = ""
            TBSueldoE.Text = ""
            CBEspecialidadE.Items.Clear()
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
    ''' Sale form
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub PBCancelarMC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCancelarMC.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Inserta lista provincias
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
    ''' Inserta lista poblaciones
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

    ''' <summary>
    ''' Inserta lista especialidades
    ''' </summary>
    ''' <author>María Navarro</author>
    Private Sub CBEspecialidadE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEspecialidadE.Click
        _ListadoEspecialidades = Especialidad.Cargar()
        CBEspecialidadE.Items.Clear()

        If _ListadoEspecialidades IsNot Nothing Then
            For Each Espec In _ListadoEspecialidades
                CBEspecialidadE.Items.Add(Espec.Nombre)
            Next
        End If

        TSLabEstado.Text = ""
    End Sub
    ''' <summary>
    '''  Modificar especialiadad
    ''' </summary>
    ''' <author>María Navarro</author>
    Public Sub ModificarEspecialidad(ByVal especialidad As Integer, ByVal trabajador As Integer)
        Dim conexion As New BBDD

        conexion.Modificar("UPDATE TenerEspecialidad SET especialidad = " & especialidad & " WHERE trabajador = " & trabajador & ";")
    End Sub
End Class



