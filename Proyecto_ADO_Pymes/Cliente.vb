Option Explicit On
Option Strict On

''' <summary>
''' Clase cliente: Almacena los datos de los clientes.
''' </summary>
''' <author>Raquel Lloréns Gambín, Andrés Marotta, Pedro Zalacain</author>
Public Class Cliente : Inherits Usuario

    ''' <summary>
    ''' Constructor por parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    ''' Constructor por parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Sub New(ByVal c As Integer, ByVal dni As String, ByVal n As String, ByVal a1 As String, ByVal a2 As String, ByVal d As Direccion, ByVal p As String, ByVal m As String, ByVal e As String)
        MyBase.New(c, dni, n, a1, a2, d, p, m, e)
    End Sub

    ''' <summary>
    ''' Carga todos los clientes almacenados
    ''' </summary>
    ''' <param name="conexion">Conexión con la Base de Datos</param>
    ''' <returns>Un List(Of Cliente) con los clientes</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function CargarClientes(ByVal conexion As BBDD) As List(Of Cliente)
        Dim clientes As New List(Of Cliente)
        Dim lector As OleDb.OleDbDataReader

        lector = conexion.Consultar("SELECT * FROM Clientes;")

        While lector.Read
            Dim cliente As New Cliente

            cliente._Nombre = CStr(lector(0))
            cliente._Apellido1 = CStr(lector(1))
            cliente._Apellido2 = CStr(lector(2))
            cliente._Direccion = New Direccion
            cliente._Particular = CStr(lector(4))
            cliente._Movil = CStr(lector(5))
            cliente._Email = CStr(lector(6))

            clientes.Add(cliente)
        End While

        Return clientes
    End Function

    ''' <summary>
    ''' Inserta el cliente en la base de datos
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Function InsertarCliente() As Boolean
        Dim ok As Boolean = False
        Dim columnas As Integer
        Dim conexion As New BBDD

        columnas = conexion.Modificar("INSERT INTO Clientes (dni,nombre,apellido1,apellido2,email,telefonoparticular," & _
                                        "telefonomovil, calle, numero, piso, poblacion) VALUES(" & _
                                        "'" & Me._DNI & "'," & _
                                        "'" & Me._Nombre & "'," & _
                                        "'" & Me._Apellido1 & "'," & _
                                        "'" & Me._Apellido2 & "'," & _
                                        "'" & Me._Email & "'," & _
                                        "'" & Me._Particular & "'," & _
                                        "'" & Me._Movil & "'," & _
                                        "'" & Me._Direccion.Calle & "'," & _
                                        Me._Direccion.Numero & "," & _
                                        "'" & Me._Direccion.Piso & "'," & _
                                        Me._Direccion.Municipio.Codigo & _
                                        ");")
        If columnas > 0 Then
            ok = True
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Public Overrides Sub Dispose()
        MyBase.Dispose()
    End Sub

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Pedro Zalacain</author>
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
