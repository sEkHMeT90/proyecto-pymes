Option Explicit On
Option Strict On

''' <summary>
''' Clase Especialidad.
''' </summary>
''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
Public Class Especialidad

    Private _Cod As Integer
    Private _Nombre As String
    Private _Descripcion As String

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New()
        _Cod = 0
        _Nombre = ""
        _Descripcion = ""
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New(ByVal c As Integer, ByVal n As String, ByVal d As String)
        _Cod = c
        _Nombre = n
        _Descripcion = d
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Cod() As Integer
        Get
            Return _Cod
        End Get
        Set(ByVal value As Integer)
            _Cod = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    ''' <summary>
    ''' Inserta el servicio en la base de datos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Public Function Insertar() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("INSERT INTO Especialidades (nombre, descripcion)" & _
                                        " VALUES(" & _
                                        "'" & Me._Nombre & "'," & _
                                        "'" & Me._Descripcion & "'" & _
                                        ");")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub Dispose()
        _Cod = 0
        _Nombre = ""
        _Descripcion = ""
    End Sub

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Protected Overrides Sub Finalize()
        _Cod = 0
        _Nombre = ""
        _Descripcion = ""
    End Sub

End Class


