Option Explicit On
Option Strict On

''' <summary>
''' Clase Dirección: Almacena los datos de las direcciones de los usuarios.
''' </summary>
''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
''' 

Public Class Direccion
    Private _Calle As String
    Private _Numero As Integer
    Private _Piso As String
    Private _Letra As String
    Private _Municipio As Municipio
    
    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Sub New()
        _Calle = ""
        _Numero = 0
        _Piso = ""
        _Municipio = New Municipio
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Sub New(ByVal c As String, ByVal n As Integer, ByVal p As String, ByVal mn As Municipio)
        _Calle = c
        _Numero = n
        _Piso = p
        _Municipio = mn
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Property Calle() As String
        Get
            Return _Calle
        End Get
        Set(ByVal value As String)
            _Calle = value
        End Set
    End Property

    Public Property Numero() As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
        End Set
    End Property

    Public Property Piso() As String
        Get
            Return _Piso
        End Get
        Set(ByVal value As String)
            _Piso = value
        End Set
    End Property

    Public Property Municipio() As Municipio
        Get
            Return _Municipio
        End Get
        Set(ByVal value As Municipio)
            _Municipio = value
        End Set
    End Property

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Sub Dispose()
        _Calle = ""
        _Numero = 0
        _Piso = ""
        _Municipio = New Municipio
    End Sub

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Protected Overrides Sub Finalize()
        _Calle = ""
        _Numero = 0
        _Piso = ""
        _Municipio = New Municipio
    End Sub
End Class