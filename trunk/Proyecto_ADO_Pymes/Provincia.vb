Option Strict On
Option Explicit On

Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' Clase Provincia
''' </summary>
''' <author>Andrés Marotta</author>
Public Class Provincia
    Private _Codigo As Integer
    Private _Nombre As String

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Public Sub New()
        Me._Codigo = 0
        Me._Nombre = "Desconocido"
    End Sub

    ''' <summary>
    ''' Constructor por parámetros
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Public Sub New(ByVal codigo As Integer, ByVal nombre As String)
        Me._Codigo = codigo
        Me._Nombre = nombre
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Me._Codigo
        End Get
    End Property

    Public ReadOnly Property Nombre() As String
        Get
            Return Me._Nombre
        End Get
    End Property

    ''' <summary>
    ''' Carga todas las provincias
    ''' </summary>
    ''' <returns>Una lista con todas las provincias cargadas</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function Cargar() As List(Of Provincia)
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim provincias As New List(Of Provincia)

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT * FROM Provincias;")

            While lector.Read
                Dim nueva As New Provincia(lector.GetInt32(0), lector.GetString(1))
                provincias.Add(nueva)
            End While

            lector.Close()
            conexion.Desconectar()
        End If

        conexion.Dispose()

        Return provincias
    End Function

    ''' <summary>
    ''' Destructor manual
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Public Sub Dispose()
        Me._Codigo = -1
        Me._Nombre = ""
    End Sub

    ''' <summary>
    ''' Destructor automático
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Protected Overrides Sub Finalize()
        Me._Codigo = -1
        Me._Nombre = ""
    End Sub
End Class
