Option Strict On
Option Explicit On

Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' Clase Cita.
''' </summary>
''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>

Public Class Cita
    Private _Codigo As Integer
    Private _Fecha As Date
    Private _Hora As Integer
    Private _Minutos As Integer
    Private _Servicios As List(Of Servicio)
    Private _Trabajador As Integer
    Private _Cliente As Integer

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>
    Public Sub New()
        Me._Codigo = 0
        Me._Fecha = Now
        Me._Hora = 0
        Me._Minutos = 0
        Me._Servicios = New List(Of Servicio)
        Me._Trabajador = 0
        Me._Cliente = 0
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>
    Public Sub New(ByVal c As Integer, ByVal f As Date, ByVal h As Integer, ByVal m As Integer, ByVal s As List(Of Servicio), ByVal t As Integer, ByVal cl As Integer)
        Me._Codigo = c
        Me._Fecha = f
        Me._Hora = h
        Me._Minutos = m
        Me._Servicios = s
        Me._Trabajador = t
        Me._Cliente = cl
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

    Public Property Hora() As Integer
        Get
            Return Me._Hora
        End Get
        Set(ByVal value As Integer)
            Me._Hora = value
        End Set
    End Property

    Public Property Minutos() As Integer
        Get
            Return Me._Minutos
        End Get
        Set(ByVal value As Integer)
            Me._Minutos = value
        End Set
    End Property

    Public Property Servicios As List(Of Servicio)
        Get
            Return Me._Servicios
        End Get
        Set(ByVal value As List(Of Servicio))
            Me._Servicios = value
        End Set
    End Property

    Public Property Trabajador() As Integer
        Get
            Return Me._Trabajador
        End Get
        Set(ByVal value As Integer)
            Me._Trabajador = value
        End Set
    End Property

    Public Property Cliente() As Integer
        Get
            Return Me._Cliente
        End Get
        Set(ByVal value As Integer)
            Me._Cliente = value
        End Set
    End Property

    ''' <summary>
    ''' Carga todas las citas almacenadas en la base de datos
    ''' </summary>
    ''' <returns>Una lista de citas</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function Cargar() As List(Of Cita)
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim citas As New List(Of Cita)

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT codigo, cliente, trabajador, fecha, hora, minutos FROM Citas;")

            While lector.Read
                Dim nueva As New Cita()
                nueva._Codigo = lector.GetInt32(0)
                nueva._Cliente = lector.GetInt32(1)
                nueva._Trabajador = lector.GetInt32(2)
                nueva._Fecha = lector.GetDateTime(3)
                nueva._Hora = lector.GetInt32(4)
                nueva._Minutos = lector.GetInt32(5)
                citas.Add(nueva)
            End While

            lector.Close()

            For Each cita In citas
                cita._Servicios = Servicio.ServiciosPorCita(cita._Codigo, conexion)
            Next

            conexion.Desconectar()
            conexion.Dispose()
        End If

        Return citas
    End Function

    ''' <summary>
    ''' Inserta una cita en la base de datos
    ''' </summary>
    ''' <returns>True o False, dependiendo de si todo fue bien o no</returns>
    ''' <author>Andrés Marotta</author>
    Public Function Insertar() As Boolean
        Dim conexion As New BBDD
        Dim insercion As String
        Dim ok As Boolean

        Try
            For Each servicio In Me._Servicios
                insercion = "INSERT INTO Citas(servicios, cliente, trabajador, fecha, hora, minutos) " & _
                            "VALUES(" & _
                            servicio.Codigo & ", " & _
                            Me._Cliente & ", " & _
                            Me._Trabajador & ", " & _
                            "#" & Me._Fecha.Day & "/" & Me._Fecha.Month & "/" & Me._Fecha.Year & "#, " & _
                            Me._Hora & ", " & _
                            Me._Minutos & _
                            ");"

                conexion.Modificar(insercion)
            Next

            ok = True
        Catch ex As Exception
            ok = False
        End Try

        Return ok
    End Function

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>
    Public Sub Dispose()
        Me._Fecha = #1/1/1900#
        Me._Codigo = -1
        Me._Hora = -1
        Me._Minutos = -1
        Me._Servicios.Clear()
        Me._Trabajador = -1
        Me._Cliente = -1
    End Sub

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>
    Protected Overrides Sub Finalize()
        Me._Fecha = #1/1/1900#
        Me._Codigo = -1
        Me._Hora = -1
        Me._Minutos = -1
        Me._Servicios.Clear()
        Me._Trabajador = -1
        Me._Cliente = -1
    End Sub

End Class