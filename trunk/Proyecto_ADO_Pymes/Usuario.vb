Option Explicit On
Option Strict On

''' <summary>
''' Clase Usuario: Clase genérica para Trabajadores y Clientes
''' </summary>
''' <author>Pedro Zalacain</author>

Public Class Usuario
    Protected _Cod As Integer
    Protected _DNI As String
    Protected _Nombre As String
    Protected _Apellido1 As String
    Protected _Apellido2 As String
    Protected _Direccion As Direccion
    Protected _Particular As String
    Protected _Movil As String
    Protected _Email As String

    ''' <summary>
    ''' Constructor por parámetros
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Sub New()
        Me._Cod = 0
        Me._DNI = "Desconocido"
        Me._Nombre = "Desconocido"
        Me._Apellido1 = "Desconocido"
        Me._Apellido2 = "Desconocido"
        Me._Direccion = New Direccion
        Me._Particular = "Desconocido"
        Me._Movil = "Desconocido"
        Me._Email = "Desconocido"
    End Sub

    ''' <summary>
    ''' Constructor por parámetros
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Sub New(ByVal c As Integer, ByVal dni As String, ByVal n As String, ByVal a1 As String, ByVal a2 As String, ByVal d As Direccion, ByVal p As String, ByVal m As String, ByVal e As String)
        Me._Cod = c
        Me._DNI = dni
        Me._Nombre = n
        Me._Apellido1 = a1
        Me._Apellido2 = a2
        Me._Direccion = d
        Me._Particular = p
        Me._Movil = m
        Me._Email = e
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>

    Public ReadOnly Property Codigo() As Integer
        Get
            Return _Cod
        End Get
    End Property

    Public ReadOnly Property DNI() As String
        Get
            Return _DNI
        End Get
    End Property

    Public ReadOnly Property Nombre() As String
        Get
            Return _Nombre
        End Get
    End Property

    Public ReadOnly Property Apellido1() As String
        Get
            Return _Apellido1
        End Get
    End Property

    Public ReadOnly Property Apellido2() As String
        Get
            Return _Apellido2
        End Get
    End Property

    Public Property Direccion() As Direccion
        Get
            Return _Direccion
        End Get
        Set(ByVal value As Direccion)
            _Direccion = value
        End Set
    End Property

    Public ReadOnly Property Particular() As String
        Get
            Return Me._Particular
        End Get
    End Property

    Public ReadOnly Property Movil() As String
        Get
            Return Me._Movil
        End Get
    End Property

    Public ReadOnly Property Email() As String
        Get
            Return _Email
        End Get
    End Property

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Overridable Sub Dispose()
        Me._Cod = 0
        Me._DNI = ""
        Me._Nombre = ""
        Me._Apellido1 = ""
        Me._Apellido2 = ""
        Me._Direccion.Dispose()
        Me._Particular = ""
        Me._Movil = ""
        Me._Email = ""
    End Sub

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Protected Overrides Sub Finalize()
        Me._Cod = 0
        Me._DNI = ""
        Me._Nombre = ""
        Me._Apellido1 = ""
        Me._Apellido2 = ""
        Me._Direccion.Dispose()
        Me._Particular = ""
        Me._Movil = ""
        Me._Email = ""
    End Sub
End Class
