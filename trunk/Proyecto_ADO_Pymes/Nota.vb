Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' Clase Nota.
''' </summary>
''' <author>Pedro Zalacain</author>
Public Class Nota
    Private _Codigo As Integer
    Private _Texto As String

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Sub New()
        _Codigo = 0
        _Texto = "Escribe aquí..."
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Sub New(ByVal c As Integer, ByVal t As String)
        Me._Codigo = c
        Me._Texto = t
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

    Public Property Texto() As String
        Get
            Return _Texto
        End Get
        Set(ByVal value As String)
            _Texto = value
        End Set
    End Property

    ''' <summary>
    ''' Inserta la nota en la base de datos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Function Insertar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("INSERT INTO Notas (texto)" & _
                                        " VALUES('" & Me._Texto & "');")

        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Eliminar una nota existente
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Function Eliminar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("DELETE FROM Notas WHERE codigo = " & Me._Codigo & ";")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Modificar una nota
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Function Modificar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("UPDATE Notas SET texto = " & _
                                        "'" & Me._Texto & "' WHERE codigo = " & Me._Codigo & ";")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Carga todas las notas almacenadas en la base de datos
    ''' </summary>
    ''' <returns>Una lista de notas</returns>
    ''' <author>Pedro Zalacain</author>
    Public Shared Function Cargar() As List(Of Nota)
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim servicios As New List(Of Nota)

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT * FROM Notas;")

            While lector.Read
                Dim nuevo As New Nota()
                nuevo._Codigo = lector.GetInt32(0)
                nuevo._Texto = lector.GetString(1)
                servicios.Add(nuevo)
            End While

            lector.Close()
            conexion.Desconectar()
            conexion.Dispose()
        End If

        Return servicios
    End Function

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Sub Dispose()
        Me._Codigo = -1
        Me._Texto = ""
    End Sub

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Protected Overrides Sub Finalize()
        Me._Codigo = -1
        Me._Texto = ""
    End Sub
End Class