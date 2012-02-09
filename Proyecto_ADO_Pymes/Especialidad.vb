Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' Clase Especialidad.
''' </summary>
''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
Public Class Especialidad

    Private _Cod As Integer
    Private _Nombre As String
    Private _Descripcion As String

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New()
        _Cod = 0
        _Nombre = ""
        _Descripcion = ""
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New(ByVal c As Integer, ByVal n As String, ByVal d As String)
        _Cod = c
        _Nombre = n
        _Descripcion = d
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Cod() As Integer
        Get
            Return _Cod
        End Get
        Set(ByVal value As Integer)
            _Cod = value
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

    ''' <summary>
    ''' Eliminar una especialidad existente
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Function Eliminar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("DELETE FROM Especialidades WHERE codigo = " & Me._Cod & ";")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Modificar una especialidad
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Function Modificar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("UPDATE Especialidades SET nombre = " & _
                                        "'" & Me._Nombre & "', descripcion = " & _
                                        "'" & Me._Descripcion & "' WHERE codigo = " & Me._Cod & ";")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Inserta la especialidad en la base de datos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Function Insertar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("INSERT INTO Especialidades (nombre, descripcion)" & _
                                        " VALUES(" & _
                                        "'" & Me._Nombre & "'," & _
                                        "'" & Me._Descripcion & "'" & _
                                        ");")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Carga todas las especialidades almacenadas en la base de datos
    ''' </summary>
    ''' <returns>Una lista de especialidades</returns>
    ''' <author>Pedro Zalacain</author>
    Public Shared Function Cargar() As List(Of Especialidad)
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim especialidades As New List(Of Especialidad)

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT * FROM Especialidades;")

            While lector.Read
                Dim nuevo As New Especialidad()
                nuevo.Cod = lector.GetInt32(0)
                nuevo.Nombre = lector.GetString(1)
                nuevo.Descripcion = lector.GetString(2)
                especialidades.Add(nuevo)
            End While

            lector.Close()
            conexion.Desconectar()
            conexion.Dispose()
        End If

        Return especialidades
    End Function

    ''' <summary>
    ''' Carga las especialidades dado un trabajador
    ''' </summary>
    ''' <returns>Una lista de especialidades</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function EspecialidadTrabajador(ByVal trabajador As Integer) As List(Of Especialidad)
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim especialidades As New List(Of Especialidad)

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT Especialidades.* FROM TenerEspecialidad, Especialidades WHERE trabajador = " & trabajador & ";")

            While lector.Read
                Dim nuevo As New Especialidad()
                nuevo.Cod = lector.GetInt32(0)
                nuevo.Nombre = lector.GetString(1)
                nuevo.Descripcion = lector.GetString(2)
                especialidades.Add(nuevo)
            End While

            lector.Close()
            conexion.Desconectar()
            conexion.Dispose()
        End If

        Return especialidades
    End Function

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub Dispose()
        _Cod = 0
        _Nombre = ""
        _Descripcion = ""
    End Sub

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Protected Overrides Sub Finalize()
        _Cod = 0
        _Nombre = ""
        _Descripcion = ""
    End Sub

End Class