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
    Private _Cliente As Cliente
    Private _Trabajador As Trabajador
    Private _Fecha As Date
    Private _Hora As DateTime
    Private _Duracion As Integer
    Private _Servicios As List(Of Servicio)

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>
    Public Sub New()
        Me._Codigo = 0
        Me._Cliente = New Cliente
        Me._Trabajador = New Trabajador
        Me._Fecha = Now
        Me._Hora = #12:00:00 AM#
        Me._Duracion = 0
        Me._Servicios = New List(Of Servicio)
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>
    Public Sub New(ByVal c As Integer, ByVal cl As Cliente, ByVal t As Trabajador, ByVal f As Date, ByVal h As DateTime, ByVal s As List(Of Servicio))
        Me._Codigo = c
        Me._Cliente = cl
        Me._Trabajador = t
        Me._Fecha = f
        Me._Hora = CDate(h.Hour & h.Minute)
        Me._Servicios = s

        For Each servicio In Me._Servicios
            Me._Duracion += servicio.Duracion
        Next
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

    Public Property Hora() As DateTime
        Get
            Return Me._Hora
        End Get
        Set(ByVal value As DateTime)
            Me._Hora = value
        End Set
    End Property

    Public Property Duracion() As Integer
        Get
            Return Me._Duracion
        End Get
        Set(ByVal value As Integer)
            Me._Duracion = value
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

    Public Property Trabajador() As Trabajador
        Get
            Return Me._Trabajador
        End Get
        Set(ByVal value As Trabajador)
            Me._Trabajador = value
        End Set
    End Property

    Public Property Cliente() As Cliente
        Get
            Return Me._Cliente
        End Get
        Set(ByVal value As Cliente)
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
            lector = conexion.Consultar("SELECT * FROM Citas;")

            While lector.Read
                Dim nueva As New Cita()
                nueva._Codigo = CInt(lector(0))
                nueva._Cliente = Cliente.Obtener(CInt(lector(1)), conexion)
                nueva._Trabajador = Trabajador.Obtener(CInt(lector(2)), conexion)
                nueva._Fecha = CDate(lector(3))
                nueva._Hora = CDate(lector(4))
                nueva._Duracion = CInt(lector(5))
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
    ''' Devuelve todas las citas de una fecha dada
    ''' </summary>
    ''' <param name="fecha">Fecha a buscar</param>
    ''' <returns>Las citas encontradas</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function Cargar(ByVal fecha As Date) As List(Of Cita)
        Dim citas As New List(Of Cita)
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT * FROM Citas " & _
                                        "WHERE fecha = #" & fecha.Month & "/" & fecha.Day & "/" & fecha.Year & "#;")

            If lector IsNot Nothing Then
                While lector.Read
                    Dim nueva As New Cita()
                    nueva._Codigo = CInt(lector(0))
                    nueva._Cliente = Cliente.Obtener(CInt(lector(1)), conexion)
                    nueva._Trabajador = Trabajador.Obtener(CInt(lector(2)), conexion)
                    nueva._Fecha = CDate(lector(3))
                    nueva._Hora = CDate(lector(4))
                    nueva._Duracion = CInt(lector(5))
                    citas.Add(nueva)
                End While

                lector.Close()

                For Each cita In citas
                    cita._Servicios = Servicio.ServiciosPorCita(cita._Codigo, conexion)
                Next

            Else
                citas = Nothing
            End If

            conexion.Desconectar()
            conexion.Dispose()
        Else
            citas = Nothing
            conexion.Dispose()
        End If

        Return citas
    End Function

    ''' <summary>
    ''' Devuelve todas las citas de un mes
    ''' </summary>
    ''' <param name="mes">Mes a buscar</param>
    ''' <returns>Las citas encontradas</returns>
    ''' <author>Pedro Zalacain</author>
    Public Shared Function ObtenerPorMes(ByVal mes As Integer) As List(Of Cita)
        Dim citas As New List(Of Cita)
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT * FROM Citas " & _
                                         "WHERE fecha LIKE '%/%" & mes & "/%';")

            If lector IsNot Nothing Then
                While lector.Read
                    Dim nueva As New Cita()
                    nueva._Codigo = CInt(lector(0))
                    nueva._Cliente = Cliente.Obtener(CInt(lector(1)), conexion)
                    nueva._Trabajador = Trabajador.Obtener(CInt(lector(2)), conexion)
                    nueva._Fecha = CDate(lector(3))
                    nueva._Hora = CDate(lector(4))
                    nueva._Duracion = CInt(lector(5))
                    citas.Add(nueva)
                End While

                lector.Close()

                For Each cita In citas
                    cita._Servicios = Servicio.ServiciosPorCita(cita._Codigo, conexion)
                Next

            Else
                citas = Nothing
            End If

            conexion.Desconectar()
            conexion.Dispose()
        Else
            citas = Nothing
            conexion.Dispose()
        End If

        Return citas
    End Function

    ''' <summary>
    ''' Devuelve la cita de un trabajador en una fecha a una determinada hora
    ''' </summary>
    ''' <param name="t">Código del trabajador</param>
    ''' <param name="f">Fecha de la cita</param>
    ''' <param name="h">Hora de la cita</param>
    ''' <returns>La cita encontrada</returns>
    ''' <author>Andrés Marotta</author>
    Public Shared Function Obtener(ByVal t As Integer, ByVal f As Date, ByVal h As DateTime) As Cita
        Dim nueva As Cita
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT * FROM Citas " & _
                                        "WHERE trabajador = " & t & " AND " & _
                                        "fecha = #" & f.Month & "/" & f.Day & "/" & f.Year & "# AND " & _
                                        "hora = #" & h & "#" & _
                                        ";")


            If lector.Read() Then
                nueva = New Cita
                nueva._Codigo = CInt(lector(0))
                nueva._Cliente = Cliente.Obtener(CInt(lector(1)), conexion)
                nueva._Trabajador = Trabajador.Obtener(CInt(lector(2)), conexion)
                nueva._Fecha = CDate(lector(3))
                nueva._Hora = CDate(lector(4))
                nueva._Duracion = CInt(lector(5))
                lector.Close()

                nueva._Servicios = Servicio.ServiciosPorCita(nueva._Codigo, conexion)
            Else
                nueva = Nothing
            End If

            conexion.Desconectar()
            conexion.Dispose()
        Else
            nueva = Nothing
            conexion.Dispose()
        End If

        Return nueva
    End Function

    ''' <summary>
    ''' Devuelve el código de una cita dados sus parámetros
    ''' </summary>
    ''' <param name="c">Cliente</param>
    ''' <param name="t">Trabajador</param>
    ''' <param name="f">Fecha</param>
    ''' <param name="h">Hora</param>
    ''' <returns>El código de la cita encontrada</returns>
    ''' <author>Andrés Marotta</author>
    Public Function ObtenerCodigo(ByVal c As Integer, ByVal t As Integer, ByVal f As Date, ByVal h As DateTime) As Integer
        Dim conexion As New BBDD
        Dim lector As OleDbDataReader
        Dim codigo As Integer

        If conexion.Conectar Then
            lector = conexion.Consultar("SELECT codigo FROM Citas " & _
                                        "WHERE cliente = " & c & " AND " & _
                                        "trabajador = " & t & " AND " & _
                                        "fecha = #" & Fecha & "# AND " & _
                                        "hora = #" & h & "#" & _
                                        ";")

            lector.Read()

            codigo = CInt(lector(0))

            lector.Close()

            conexion.Desconectar()
            conexion.Dispose()
        End If

        Return codigo
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

        If conexion.Conectar Then
            insercion = "INSERT INTO Citas(cliente, trabajador, fecha, hora, duracion) " & _
                    "VALUES(" & _
                    Me._Cliente.Codigo & ", " & _
                    Me._Trabajador.Codigo & ", " & _
                    "#" & Me._Fecha.Month & "/" & Me._Fecha.Day & "/" & Me._Fecha.Year & "#, " & _
                    "#" & Me._Hora & "#, " & _
                    Me._Duracion & _
                    ");"

            If conexion.Modificar(insercion) > 0 Then
                For Each servicio In Me._Servicios
                    insercion = "INSERT INTO PrestarServicio (cita, servicio) " & _
                                "Values(" & _
                                ObtenerCodigo(Me._Cliente.Codigo, Me._Trabajador.Codigo, Me._Fecha, Me._Hora) & ", " & _
                                servicio.Codigo & _
                                ");"

                    conexion.Modificar(insercion)
                Next

                ok = True
            Else
                ok = False
            End If
        Else
            ok = False
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Modifica los datos de la cita en la base de datos
    ''' </summary>
    ''' <returns>True o False, dependiendo de si todo fue bien o no</returns>
    ''' <author>Andrés Marotta</author>
    Public Function Modifcar() As Boolean
        Dim conexion As New BBDD
        Dim modificacion As String
        Dim ok As Boolean

        If conexion.Conectar Then
            modificacion = "UPDATE Citas SET " & _
                           "cliente = " & Me._Cliente.Codigo & ", " & _
                           "trabajador = " & Me._Trabajador.Codigo & ", " & _
                           "fecha = " & "#" & Me._Fecha.Month & "/" & Me._Fecha.Day & "/" & Me._Fecha.Year & "#, " & _
                           "hora = " & "#" & Me._Hora & "#, " & _
                           "duracion = " & Me._Duracion & " " & _
                           "WHERE codigo = " & Me._Codigo & _
                           ";"

            If conexion.Modificar(modificacion) > 0 Then
                For Each servicio In Me._Servicios
                    modificacion = "UPDATE PrestarServicio SET " & _
                                    "servicio = " & servicio.Codigo & " " & _
                                    "WHERE cita = " & Me._Codigo & _
                                    ";"

                    conexion.Modificar(modificacion)
                Next

                ok = True
            Else
                ok = False
            End If
        Else
            ok = False
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Borra la cita de la base de datos
    ''' </summary>
    ''' <returns>True o False, dependiendo de si todo fue bien o no</returns>
    ''' <author>Andrés Marotta</author>
    Public Function Borrar() As Boolean
        Dim conexion As New BBDD
        Dim borrado As String
        Dim ok As Boolean

        If conexion.Conectar Then
            borrado = "DELETE FROM Citas WHERE codigo = " & Me._Codigo & ";"

            Try
                conexion.Modificar(borrado)
                borrado = "DELETE FROM PrestarServicio WHERE cita = " & Me._Codigo & ";"

                Try
                    conexion.Modificar(borrado)
                    ok = True
                Catch ex As Exception
                    ok = False
                End Try

            Catch ex As Exception
                ok = False
            End Try
        Else
            ok = False
        End If

        Return ok
    End Function

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>
    Public Sub Dispose()
        Me._Fecha = #1/1/1900#
        Me._Codigo = -1
        Me._Hora = #11:00:00 PM#
        Me._Duracion = -1
        Me._Servicios.Clear()
        Me._Trabajador.Dispose()
        Me._Cliente.Dispose()
    End Sub

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín, Andrés Marotta</author>
    Protected Overrides Sub Finalize()
        Me._Fecha = #1/1/1900#
        Me._Codigo = -1
        Me._Hora = #11:00:00 PM#
        Me._Duracion = -1
        Me._Servicios.Clear()
        Me._Trabajador.Dispose()
        Me._Cliente.Dispose()
    End Sub

End Class