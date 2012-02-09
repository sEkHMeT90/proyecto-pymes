Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.OleDb

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
    ''' <returns>Un List(Of Cliente) con los clientes</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function Cargar() As List(Of Cliente)
        Dim conexion As New BBDD
        Dim clientes As New List(Of Cliente)
        Dim lector As OleDbDataReader

        Try
            conexion.Conectar()

            lector = conexion.Consultar("SELECT * FROM Clientes;")

            While lector.Read
                Dim cliente As New Cliente
                cliente._Cod = CInt(lector(0))
                cliente._DNI = CStr(lector(1))
                cliente._Nombre = CStr(lector(2))
                cliente._Apellido1 = CStr(lector(3))
                cliente._Apellido2 = CStr(lector(4))
                cliente._Email = CStr(lector(5))
                cliente._Particular = CStr(lector(6))
                cliente._Movil = CStr(lector(7))
                cliente._Direccion.Calle = CStr(lector(8))
                cliente._Direccion.Numero = CInt(lector(9))
                cliente._Direccion.Piso = CStr(lector(10))
                cliente._Direccion.Municipio = Municipio.MunicipioPorCodigo(CInt(lector(11)))

                clientes.Add(cliente)
            End While

            lector.Close()

        Catch ex As Exception
            clientes = Nothing

        Finally
            conexion.Desconectar()
            conexion.Dispose()
        End Try

        Return clientes
    End Function

    ''' <summary>
    ''' Inserta el cliente en la base de datos
    ''' </summary>
    ''' <author>Andrés Marotta, Pedro Zalacain</author>
    Public Function Insertar() As Boolean
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
