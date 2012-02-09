Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' Clase Servicio.
''' </summary>
''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>
Public Class Servicio
    Private _Codigo As Integer
    Private _Nombre As String
    Private _Descripcion As String
    Private _Duracion As Integer
    Private _Precio As Double

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New()
        _Codigo = 0
        _Nombre = "Desconocido"
        _Descripcion = "Desconocido"
        _Duracion = 0
        _Precio = 0
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New(ByVal c As Integer, ByVal n As String, ByVal d As String, ByVal du As Integer, ByVal p As Double)
        Me._Codigo = c
        Me._Nombre = n
        Me._Descripcion = d
        Me._Duracion = du
        Me._Precio = p
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Duracion() As Integer
        Get
            Return _Duracion
        End Get
        Set(ByVal value As Integer)
            _Duracion = value
        End Set
    End Property

    Public Property Precio() As Double
        Get
            Return _Precio
        End Get
        Set(ByVal value As Double)
            _Precio = value
        End Set
    End Property

    ''' <summary>
    ''' Inserta el servicio en la base de datos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Function Insertar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("INSERT INTO Servicios (nombre, descripcion,duracion,precio)" & _
                                        " VALUES(" & _
                                        "'" & Me._Nombre & "'," & _
                                        "'" & Me._Descripcion & "'," & _
                                        Me._Duracion & "," & _
                                        Me._Precio & ");")

        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Eliminar un servicio existente
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Function Eliminar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("DELETE FROM Servicios WHERE codigo = " & Me._Codigo & ";")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Modificar un servicio
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Function Modificar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("UPDATE Servicios SET nombre = " & _
                                        "'" & Me._Nombre & "', descripcion = " & _
                                        "'" & Me._Descripcion & "', duracion = " & _
                                        Me._Duracion & "," & "precio = " & Me._Precio & _
                                        " WHERE codigo = " & Me._Codigo & ";")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Carga todos los servicios almacenados en la base de datos
    ''' </summary>
    ''' <returns>Una lista de servicios</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function Cargar() As List(Of Servicio)
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim servicios As New List(Of Servicio)

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT * FROM Servicios;")

            While lector.Read
                Dim nuevo As New Servicio()
                nuevo._Codigo = lector.GetInt32(0)
                nuevo._Nombre = lector.GetString(1)
                nuevo._Descripcion = lector.GetString(2)
                nuevo._Duracion = CInt(lector(3))
                nuevo._Precio = CDbl(lector(4))
                servicios.Add(nuevo)
            End While

            lector.Close()
            conexion.Desconectar()
            conexion.Dispose()
        End If

        Return servicios
    End Function

    ''' <summary>
    ''' Carga todos los servicios de una cita dada
    ''' </summary>
    ''' <returns>Una lista de servicios</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function ServiciosPorCita(ByVal cita As Integer, ByVal conexion As BBDD) As List(Of Servicio)
        Dim lector As OleDbDataReader
        Dim servicios As New List(Of Servicio)

        lector = conexion.Consultar("SELECT * FROM Servicios, Citas " & _
                                    "WHERE Citas.codigo = " & cita & " AND Citas.servicios = Servicios.codigo;")

        While lector.Read
            Dim nuevo As New Servicio()
            nuevo._Codigo = CInt(lector(0))
            nuevo._Nombre = lector.GetString(1)
            nuevo._Descripcion = lector.GetString(2)
            nuevo._Duracion = CInt(lector(3))
            nuevo._Precio = CDbl(lector(4))
            servicios.Add(nuevo)
        End While

        lector.Close()

        Return servicios
    End Function

    ''' <summary>
    ''' Busca en la base de datos un servicio con el nombre recibido
    ''' </summary>
    ''' <param name="nombre">Nombre del servicio a buscar</param>
    ''' <returns>El servicio encontrado</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function ServicioPorNombre(ByVal nombre As String) As Servicio
        Dim conexion As New BBDD
        Dim servicio As New Servicio
        Dim lector As OleDbDataReader

        Try
            conexion.Conectar()
            lector = conexion.Consultar("SELECT * FROM Servicios WHERE nombre = '" & nombre & "';")
            lector.Read()

            servicio._Codigo = CInt(lector.GetValue(0))
            servicio._Nombre = CStr(lector.GetValue(1))
            servicio._Descripcion = CStr(lector.GetValue(2))
            servicio._Duracion = CInt(lector.GetValue(3))
            servicio._Precio = CDbl(lector.GetValue(4))

            lector.Close()

        Catch ex As Exception
            servicio = Nothing
        Finally
            conexion.Desconectar()
            conexion.Dispose()
        End Try

        Return servicio
    End Function

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub Dispose()
        Me._Codigo = -1
        Me._Nombre = ""
        Me._Descripcion = ""
        Me._Duracion = -1
        Me._Precio = -1
    End Sub

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Protected Overrides Sub Finalize()
        Me._Codigo = -1
        Me._Nombre = ""
        Me._Descripcion = ""
        Me._Duracion = -1
        Me._Precio = -1
    End Sub
End Class