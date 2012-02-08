Option Strict On
Option Explicit On

Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' Clase Municipio
''' </summary>
''' <author>Andrés Marotta, Pedro Zalacain</author>
Public Class Municipio
    Private _CodigoProvincia As Integer
    Private _Codigo As Integer
    Private _Nombre As String

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Sub New()
        Me._CodigoProvincia = 0
        Me._Codigo = 0
        Me._Nombre = "Desconocido"
    End Sub

    ''' <summary>
    ''' Constructor por parámetros
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Sub New(ByVal codigo As Integer, ByVal codprovincia As Integer, ByVal nombre As String)
        Me._CodigoProvincia = codprovincia
        Me._Codigo = codigo
        Me._Nombre = nombre
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>

    Public ReadOnly Property CodigoProvincia() As Integer
        Get
            Return Me._CodigoProvincia
        End Get
    End Property

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
    ''' Carga todos los municipios
    ''' </summary>
    ''' <returns>Una lista con todos los municipios cargadas</returns>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Shared Function Cargar(ByVal provincia As Integer) As List(Of Municipio)
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim municipios As New List(Of Municipio)

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT * FROM Municipios WHERE provincia = " & provincia & ";")

            While lector.Read
                Dim nueva As New Municipio(CInt(lector(0)), CInt(lector(1)), CStr(lector(2)))
                municipios.Add(nueva)
            End While

            lector.Close()
            conexion.Desconectar()
        End If

        conexion.Dispose()

        Return municipios
    End Function

    ''' <summary>
    ''' Destructor manual
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Sub Dispose()
        Me._CodigoProvincia = -1
        Me._Codigo = -1
        Me._Nombre = ""
    End Sub

    ''' <summary>
    ''' Destructor automático
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Protected Overrides Sub Finalize()
        Me._Codigo = -1
        Me._CodigoProvincia = -1
        Me._Nombre = ""
    End Sub
End Class