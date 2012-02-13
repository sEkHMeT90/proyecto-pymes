Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' Clase Trabajador: Almacena los datos de los trabajadores.
''' </summary>
''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>

Public Class Trabajador : Inherits Usuario

    Private _NSS As Integer
    Private _Salario As Double
    'Private _Especialidades As List(Of Especialidad)
    Private _Especialidad As String

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Sub New()
        MyBase.New()
        Me._NSS = 0
        Me._Salario = 0
        'Me._Especialidades = New List(Of Especialidad)
        Me._Especialidad = ""
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Sub New(ByVal c As Integer, ByVal dni As String, ByVal n As String, ByVal a1 As String, ByVal a2 As String, ByVal d As Direccion, ByVal p As String, ByVal m As String, ByVal e As String, ByVal ns As Integer, ByVal s As Double, ByVal es As String)
        MyBase.New(c, dni, n, a1, a2, d, p, m, e)
        _NSS = ns
        _Salario = s
        _Especialidad = es
    End Sub

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Overrides Sub Dispose()
        MyBase.Dispose()
        _NSS = 0
        _Salario = 0
        _Especialidad = ""
        'For Each especialidad In _Especialidades
        '    especialidad.Dispose()
        'Next
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>

    Public Property NSS() As Integer
        Get
            Return _NSS
        End Get
        Set(ByVal value As Integer)
            _NSS = value
        End Set
    End Property

    Public Property Salario() As Double
        Get
            Return _Salario
        End Get
        Set(ByVal value As Double)
            _Salario = value
        End Set
    End Property

    Public Property Especialidades() As String
        Get
            Return _Especialidad
        End Get
        Set(ByVal value As String)
            _Especialidad = value
        End Set
    End Property

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        _NSS = 0
        _Salario = 0
        _Especialidad = ""
        'For Each especialidad In _Especialidades
        '    especialidad.Dispose()
        'Next
    End Sub

    ''' <summary>
    ''' Carga todos los trabajadores almacenados
    ''' </summary>
    ''' <returns>Una lista con los trabajadores</returns>
    ''' <author>Andrés Marotta, Maria Navarro</author>
    Public Shared Function Cargar() As List(Of Trabajador)
        Dim conexion As New BBDD
        Dim trabajadores As New List(Of Trabajador)
        Dim lector As OleDbDataReader

        Try
            conexion.Conectar()

            lector = conexion.Consultar("SELECT * FROM Trabajadores;")

            While lector.Read
                Dim trabajador As New Trabajador
                trabajador._Cod = CInt(lector(0))
                trabajador._DNI = CStr(lector(1))
                trabajador._Nombre = CStr(lector(2))
                trabajador._Apellido1 = CStr(lector(3))
                trabajador._Apellido2 = CStr(lector(4))
                trabajador._Email = CStr(lector(5))
                trabajador._Particular = CStr(lector(6))
                trabajador._Movil = CStr(lector(7))
                trabajador._Direccion.Calle = CStr(lector(8))
                trabajador._Direccion.Numero = CInt(lector(9))
                trabajador._Direccion.Piso = CStr(lector(10))
                trabajador._Direccion.Municipio = Municipio.MunicipioPorCodigo(CInt(lector(11)))
                trabajador._Salario = CDbl(lector(12))
                trabajador._NSS = CInt(lector(13))
                'trabajador._Especialidades = Especialidad.EspecialidadTrabajador(trabajador._Cod)

                trabajadores.Add(trabajador)
            End While

            lector.Close()

        Catch ex As Exception
            trabajadores = Nothing

        Finally
            conexion.Desconectar()
            conexion.Dispose()
        End Try

        Return trabajadores
    End Function

    ''' <summary>
    ''' Inserta el cliente en la base de datos
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Function Insertar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("INSERT INTO Trabajadores (dni,nombre,apellido1,apellido2,email,telefonoparticular," & _
                                        "telefonomovil, calle, numero, piso, poblacion,salario,nss) VALUES(" & _
                                        "'" & Me._DNI & "'," & _
                                        "'" & Me._Nombre & "'," & _
                                        "'" & Me._Apellido1 & "'," & _
                                        "'" & Me._Apellido2 & "'," & _
                                        "'" & Me._Email & "'," & _
                                        "'" & Me._Particular & "'," & _
                                        "'" & Me._Movil & "'," & _
                                        "'" & Me._Direccion.Calle & "'," & _
                                        Me._Direccion.Numero & "," & _
                                        "'" & Me._Direccion.Piso & "'," & _
                                        Me._Direccion.Municipio.Codigo & "," & _
                                        Me._Salario & "," & _
                                        "'" & Me._NSS & "'" & _
                                        ");")
        If columnas > 0 Then
            ok = True
        End If

        InsertarTenerEspecialidad(CodigoTrabajador(), CInt(Me._Especialidad) + 1)

        Return ok
    End Function

    ''' <summary>
    ''' Devuleve los datos de un trabajador dado un código
    ''' </summary>
    ''' <param name="codigo">Código del trabajador a buscar</param>
    ''' <returns>El trabajador encontrado</returns>
    ''' <author>Andrés Marotta , María Navarro</author>
    Public Shared Function Obtener(ByVal codigo As Integer, ByVal conexion As BBDD) As Trabajador
        Dim trabajador As New Trabajador
        Dim lector As OleDbDataReader

        Try

            lector = conexion.Consultar("SELECT * FROM Trabajadores WHERE codigo = " & codigo & ";")

            lector.Read()

            trabajador._Cod = CInt(lector(0))
            trabajador._DNI = CStr(lector(1))
            trabajador._Nombre = CStr(lector(2))
            trabajador._Apellido1 = CStr(lector(3))
            trabajador._Apellido2 = CStr(lector(4))
            trabajador._Email = CStr(lector(5))
            trabajador._Particular = CStr(lector(6))
            trabajador._Movil = CStr(lector(7))
            trabajador._Direccion.Calle = CStr(lector(8))
            trabajador._Direccion.Numero = CInt(lector(9))
            trabajador._Direccion.Piso = CStr(lector(10))
            trabajador._Direccion.Municipio = Municipio.MunicipioPorCodigo(CInt(lector(11)))

            lector.Close()

        Catch ex As Exception
            trabajador = Nothing

        End Try

        Return trabajador
    End Function

    ''' <summary>
    ''' Cogemos el codigo trabajador
    ''' </summary>
    ''' <author>María Navarro</author>
    Public Shared Function CodigoTrabajador() As Integer
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim idtrabajador As Integer

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT codigo FROM Trabajadores WHERE codigo = (SELECT max(codigo) from Trabajadores)")

            While lector.Read
                'Dim nuevo As New Especialidad()
                idtrabajador = lector.GetInt32(0)
            End While

            lector.Close()
            conexion.Desconectar()
            conexion.Dispose()
        End If

        Return idtrabajador

    End Function

    ''' <summary>
    ''' Inserta en tenerEspecialidad
    ''' </summary>
    ''' <author>María Navarro</author>
    Public Function InsertarTenerEspecialidad(ByVal trabajador As Integer, ByVal especialidad As Integer) As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("INSERT INTO TenerEspecialidad (trabajador,especialidad) VALUES(" & trabajador & "," & especialidad & " );")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Modificar un Trabajador
    ''' </summary>
    ''' <author>María Navarro Sánchez</author>
    Public Function Modificar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("UPDATE Trabajadores SET dni = " & _
                                        "'" & Me._DNI & "',nombre = " & _
                                        "'" & Me._Nombre & "', apellido1 = " & _
                                        "'" & Me._Apellido1 & "', apellido2 = " & _
                                        "'" & Me._Apellido2 & "', email = " & _
                                        "'" & Me._Email & "', telefonoparticular = " & _
                                        "'" & Me._Particular & "',telefonomovil = " & _
                                        "'" & Me._Movil & _
                                        "',salario = " & "" & Me.Salario & _
                                        ".0,nss = " & "'" & Me.NSS & _
                                        "',calle = " & _
                                        "'" & Me._Direccion.Calle & _
                                        "',numero = " & Me._Direccion.Numero & _
                                        ",piso = '" & Me._Direccion.Piso & "'" & _
                                        ",poblacion = " & Me._Direccion.Municipio.Codigo & _
                                        " WHERE codigo = " & Me._Cod & ";")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Eliminar un Trabajador
    ''' </summary>
    ''' <author>María Navarro Sánchez</author>
    Public Function Eliminar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("DELETE FROM Trabajadores WHERE codigo = " & Me._Cod & ";")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' coger especialidad tabla tener especialidad
    ''' </summary>
    ''' <author>María Navarro</author>
    Public Shared Function NombreEspecialidad(ByVal codigoTrabajador As Integer) As Integer
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim idEspecialidad As Integer

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT especialidad FROM TenerEspecialidad WHERE trabajador = " & codigoTrabajador & ";")

            While lector.Read
                'Dim nuevo As New Especialidad()
                idEspecialidad = lector.GetInt32(0)
            End While

            lector.Close()
            conexion.Desconectar()
            conexion.Dispose()
        End If

        Return idEspecialidad

    End Function



End Class

