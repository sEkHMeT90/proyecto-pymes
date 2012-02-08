Option Explicit On
Option Strict On

''' <summary>
''' Clase Trabajador: Almacena los datos de los trabajadores.
''' </summary>
''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>

Public Class Trabajador : Inherits Usuario

    Private _NSS As Integer
    Private _Salario As Integer
    Private _Especialidades As List(Of Especialidad)

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Sub New()
        MyBase.New()
        _NSS = 0
        _Salario = 0
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Sub New(ByVal c As Integer, ByVal dni As String, ByVal n As String, ByVal a1 As String, ByVal a2 As String, ByVal d As Direccion, ByVal p As String, ByVal m As String, ByVal e As String, ByVal ns As Integer, ByVal s As Integer, ByVal es As Especialidad)
        MyBase.New(c, dni, n, a1, a2, d, p, m, e)
        _NSS = ns
        _Salario = s
    End Sub

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Overrides Sub Dispose()
        MyBase.Dispose()
        _NSS = 0
        _Salario = 0
        _Especialidades.Clear()
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

    Public Property Salario() As Integer
        Get
            Return _Salario
        End Get
        Set(ByVal value As Integer)
            _Salario = value
        End Set
    End Property

    Public Property Especialidad() As List(Of Especialidad)
        Get
            Return _Especialidades
        End Get
        Set(ByVal value As List(Of Especialidad))
            _Especialidades = value
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
        _Especialidades.Clear()
    End Sub


    Public Shared Function CargarTrabajadores(ByVal conexion As BBDD) As List(Of Trabajador)
        Dim trabajadores As New List(Of Trabajador)
        Dim lector As OleDb.OleDbDataReader

        lector = conexion.Consultar("SELECT * FROM Trabajadores;")

        While lector.Read
            Dim trabajador As New Trabajador

            trabajador._Nombre = CStr(lector(0))
            trabajador._Apellido1 = CStr(lector(1))
            trabajador._Apellido2 = CStr(lector(2))
            trabajador._Direccion = New Direccion
            trabajador._Particular = CStr(lector(4))
            trabajador._Movil = CStr(lector(5))
            trabajador._Email = CStr(lector(6))
            trabajador._Salario = CInt(lector(7))
            trabajador._NSS = CInt(lector(8))
            'TODO trabajador._Especialidades = CInt(lector(9))

            trabajadores.Add(trabajador)
        End While

        Return trabajadores
    End Function

    ''' <summary>
    ''' Inserta el cliente en la base de datos
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Function InsertarTrabajador() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("INSERT INTO Trabajadores (dni,nombre,apellido1,apellido2,email,telefonoparticular," & _
                                        "telefonomovil, calle, numero, piso, poblacion,salario.nss) VALUES(" & _
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
                                        Me._Direccion.Municipio.Codigo & _
                                        "'" & Me._Salario & "'," & _
                                        "'" & Me._NSS & "'," & _
                                        ");")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function
End Class
