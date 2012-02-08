Option Explicit On
Option Strict On

''' <summary>
''' Clase Factura.
''' </summary>
''' <author>Raquel Lloréns Gambín</author>

Public Class Factura

    Private _numFactura As Integer
    Private _codCita As Integer
    Private _lineasFactura As List(Of LineaFactura)
    Private _total As Integer

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New()
        _numFactura = 0
        _codCita = 0
        _lineasFactura = New List(Of LineaFactura)
        _total = 0
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New(ByVal nuevoNumFactura As Integer, ByVal nuevoCodCita As Integer, ByVal nuevasLineasFactura As List(Of LineaFactura), ByVal t As Integer)
        _numFactura = nuevoNumFactura
        _codCita = nuevoCodCita
        _lineasFactura = nuevasLineasFactura
        _total = t
    End Sub

    ''' <summary>
    ''' Constructor de copia
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New(ByVal nuevaFactura As Factura)
        _numFactura = nuevaFactura.numFactura()
        _codCita = nuevaFactura.codCita()
        _lineasFactura = nuevaFactura.lineasFactura()
        _total = nuevaFactura.Total()
    End Sub

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub Dispose()
        _numFactura = 0
        _codCita = 0
        _lineasFactura = New List(Of LineaFactura)
        _total = 0
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

    Public Property Total() As Integer
        Get
            Return _total
        End Get
        Set(ByVal value As Integer)
            _total = value
        End Set
    End Property

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Protected Overrides Sub Finalize()
        _numFactura = 0
        _codCita = 0
        _lineasFactura = New List(Of LineaFactura)
        _total = 0
    End Sub

End Class
