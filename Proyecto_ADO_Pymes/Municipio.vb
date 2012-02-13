Option Strict On
Option Explicit On

Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' Clase Municipio
''' </summary>
''' <author>Andrés Marotta, Pedro Zalacain</author>
Public Class Municipio
    Private _Codigo As Integer
    Private _Provincia As Provincia
    Private _Nombre As String

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Sub New()
        Me._Codigo = 0
        Me._Provincia = New Provincia
        Me._Nombre = "Desconocido"
    End Sub

    ''' <summary>
    ''' Constructor por parámetros
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Sub New(ByVal provincia As Provincia, ByVal codprovincia As Integer, ByVal nombre As String)
        Me._Codigo = Codigo
        Me._Provincia = provincia
        Me._Nombre = nombre
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>

    Public ReadOnly Property Provincia() As Provincia
        Get
            Return Me._Provincia
        End Get
    End Property
    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            Me._Codigo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            Me._Nombre = value
        End Set
    End Property

    ''' <summary>
    ''' Carga todos los municipios
    ''' </summary>
    ''' <returns>Una lista con todos los municipios cargados</returns>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Shared Function Cargar(ByVal codProvincia As Integer) As List(Of Municipio)
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim municipios As New List(Of Municipio)

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT * FROM Municipios WHERE provincia = " & codProvincia & ";")

            While lector.Read
                Dim nueva As New Municipio()
                nueva._Codigo = CInt(lector(0))
                nueva._Provincia = Provincia.ProvinciaPorCodigo(CInt(lector(1)))
                nueva._Nombre = CStr(lector(2))
                municipios.Add(nueva)
            End While

            lector.Close()
            conexion.Desconectar()
        End If

        conexion.Dispose()

        Return municipios
    End Function

    ''' <summary>
    ''' Devuelve los datos de un municipio dado un código
    ''' </summary>
    ''' <param name="codigo">Código del municipio a buscar</param>
    ''' <returns>El municipio encontrado</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function MunicipioPorCodigo(ByVal codigo As Integer) As Municipio
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim municipio As New Municipio

        Try
            conexion.Conectar()
            lector = conexion.Consultar("SELECT * FROM Municipios WHERE codigo = " & codigo & ";")
            lector.Read()

            municipio._Codigo = CInt(lector(0))
            municipio._Provincia = Provincia.ProvinciaPorCodigo(CInt(lector(1)))
            municipio._Nombre = CStr(lector(2))

            lector.Close()
        Catch ex As Exception
            municipio = Nothing

        Finally
            conexion.Desconectar()
            conexion.Dispose()
        End Try

        Return municipio
    End Function

    ''' <summary>
    ''' Destructor manual
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Sub Dispose()
        Me._Codigo = -1
        Me._Provincia.Dispose()
        Me._Nombre = ""
    End Sub

    ''' <summary>
    ''' Destructor automático
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Protected Overrides Sub Finalize()
        Me._Codigo = -1
        Me._Provincia.Dispose()
        Me._Nombre = ""
    End Sub
End Class