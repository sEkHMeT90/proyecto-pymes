Option Explicit On
Option Strict On

''' <summary>
''' Clase LineaFactura: Datos de las diferentes lineas de factura.
''' </summary>
''' <author>Raquel Lloréns Gambín</author>

Public Class LineaFactura

    Private _Num As Integer
    Private _Descripcion As String

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New()
        Num = 0
        Descripcion = ""
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New(ByVal nuevoNum As Integer, ByVal nuevaDesc As String)
        Num = nuevoNum
        Descripcion = nuevaDesc
    End Sub

    ''' <summary>
    ''' Constructor de copia
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New(ByVal lineaCopia As LineaFactura)
        Num = lineaCopia.Num
        Descripcion = lineaCopia.Descripcion
    End Sub

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub Dispose()
        Num = 0
        Descripcion = ""
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Num() As Integer
        Get
            Return _Num
        End Get
        Set(ByVal value As Integer)
            _Num = value
        End Set
    End Property

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Protected Overrides Sub Finalize()
        Num = 0
        Descripcion = ""
    End Sub

End Class
