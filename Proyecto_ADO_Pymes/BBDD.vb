Option Explicit On
Option Strict On

Imports System.Data.OleDb

''' <summary>
''' Clase BBDD: Para encapsular la interacción con la base de datos
''' </summary>
''' <author>Andrés Marotta</author>
Public Class BBDD
    Private Const _STR_CONEXION As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BDCitas.accdb"
    Private _Conexion As OleDbConnection
    Private _Comando As OleDbCommand
    Private _Lector As OleDbDataReader

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Public Sub New()
        Me._Conexion = New OleDbConnection(_STR_CONEXION)
    End Sub

    ''' <summary>
    ''' Abre la conexión con la base de datos
    ''' </summary>
    ''' <returns>'True' o 'False' dependiendo de si la operación fue bien o mal</returns>
    ''' <author>Andrés Marotta</author>
    Public Function Conectar() As Boolean
        Dim ok As Boolean

        Try
            Me._Conexion.Open()
            ok = True
        Catch ex As Exception
            ok = False
        End Try

        Return ok
    End Function

    ''' <summary>
    ''' Ejecuta una sentencia SELECT y devuelve las filas resultantes 
    ''' </summary>
    ''' <param name="comando">Sentencia SELECT a ejecutar</param>
    ''' <returns>Una variable OleDbDataReader con el resultado de la ejecución</returns>
    ''' <author>Andrés Marotta</author>
    Public Function Consultar(ByVal comando As String) As OleDbDataReader
        Try
            Me._Comando = New OleDbCommand(comando, Me._Conexion)
            Me._Lector = Me._Comando.ExecuteReader

        Catch ex As Exception
            Me._Lector = Nothing
        End Try

        Return Me._Lector
    End Function

    ''' <summary>
    ''' Ejecuta el comando recibido y devuelve el resultado 
    ''' </summary>
    ''' <param name="comando">Sentencia SQL a ejecutar</param>
    ''' <returns>Un entero con el número de columnas afectadas</returns>
    ''' <author>Andrés Marotta</author>
    Public Function Modificar(ByVal comando As String) As Integer
        Dim ColumnasAfectadas As Integer

        Try
            Me.Conectar()
            Me._Comando = New OleDbCommand(comando, Me._Conexion)
            ColumnasAfectadas = Me._Comando.ExecuteNonQuery

        Catch ex As Exception
            ColumnasAfectadas = 0
        Finally
            Me.Desconectar()
        End Try

        Return ColumnasAfectadas
    End Function

    ''' <summary>
    ''' Cierra la conexión con la base de datos
    ''' </summary>
    ''' <returns>'True' o 'False' dependiendo de si la operación fue bien o mal</returns>
    ''' <author>Andrés Marotta</author>
    Public Function Desconectar() As Boolean
        Dim ok As Boolean

        Try
            If (Me._Lector IsNot Nothing) Then
                Me._Lector.Close()
            End If

            If (Me._Conexion IsNot Nothing) Then
                Me._Conexion.Close()
            End If

            ok = True
        Catch ex As Exception
            ok = False
        End Try

        Return ok
    End Function

    ''' <summary>
    ''' Destructor manual
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Public Sub Dispose()
        Me._Conexion.Dispose()
    End Sub

    ''' <summary>
    ''' Destructor automático
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Protected Overrides Sub Finalize()
        Me._Conexion.Dispose()
    End Sub
End Class