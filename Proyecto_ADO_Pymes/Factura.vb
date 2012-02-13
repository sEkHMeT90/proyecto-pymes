Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' Clase Factura.
''' </summary>
''' <author>Raquel Lloréns Gambín</author>
Public Class Factura

    Private _numFactura As Integer
    Private _codCita As Integer
    Private _lineasFactura As List(Of LineaFactura)
    Private _total As Double
    Private _tipoPago As TipoPago
    Private _fecha As Date

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New()
        _numFactura = 0
        _codCita = 0
        _lineasFactura = New List(Of LineaFactura)
        _total = 0
        _tipoPago = New TipoPago
        _fecha = CDate(Now.Day & "/" & Now.Month & "/" & Now.Year)
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New(ByVal nuevoNumFactura As Integer, ByVal nuevoCodCita As Integer, ByVal nuevasLineasFactura As List(Of LineaFactura), ByVal t As Double, ByVal p As TipoPago, ByVal f As Date)
        _numFactura = nuevoNumFactura
        _codCita = nuevoCodCita
        _lineasFactura = nuevasLineasFactura
        _total = t
        _tipoPago = p
        _fecha = f
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>

    Public Property numFactura() As Integer
        Get
            Return _numFactura
        End Get
        Set(ByVal value As Integer)
            _numFactura = value
        End Set
    End Property

    Public Property codCita() As Integer
        Get
            Return _codCita
        End Get
        Set(ByVal value As Integer)
            _codCita = value
        End Set
    End Property

    Public Property lineasFactura() As List(Of LineaFactura)
        Get
            Return _lineasFactura
        End Get
        Set(ByVal value As List(Of LineaFactura))
            _lineasFactura = value
        End Set
    End Property

    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

    Public Property TipoPago() As TipoPago
        Get
            Return Me._tipoPago
        End Get
        Set(ByVal value As TipoPago)
            Me._tipoPago = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return Me._fecha
        End Get
        Set(ByVal value As Date)
            Me._fecha = value
        End Set
    End Property

    ''' <summary>
    ''' Inserta la factura cobrada en la base de datos
    ''' </summary>
    ''' <returns>True o False, dependiendo de si todo va bien o no</returns>
    ''' <author>Andrés Marotta</author>
    Public Function Cobrar() As Boolean
        Dim ok As Boolean
        Dim conexion As New BBDD
        Dim modificacion As String

        If conexion.Conectar Then
            modificacion = "INSERT INTO Facturas(fecha, tipopago, cita) " & _
                           "Values(" & _
                           "#" & Me._fecha.Month & "/" & Me._fecha.Day & "/" & Me._fecha.Year & "#, " & _
                           Me._tipoPago.Cod & ", " & _
                           Me._codCita & _
                           ");"

            If conexion.Modificar(modificacion) > 0 Then
                For Each linea In Me._lineasFactura
                    modificacion = "INSERT INTO LineasFactura(factura, linea) " & _
                               "Values(" & _
                               Me._codCita & ", " & _
                               "'" & linea.Descripcion & "'" & _
                               ");"
                Next
            Else
                ok = False
            End If

        Else
            ok = False
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub Dispose()
        _numFactura = 0
        _codCita = 0
        _lineasFactura = New List(Of LineaFactura)
        _total = 0
        _tipoPago.Dispose()
        _fecha = #1/1/1900#
    End Sub

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Protected Overrides Sub Finalize()
        _numFactura = 0
        _codCita = 0
        _lineasFactura = New List(Of LineaFactura)
        _total = 0
        _tipoPago.Dispose()
        _fecha = #1/1/1900#
    End Sub

End Class
