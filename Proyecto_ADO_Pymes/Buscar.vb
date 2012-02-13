Option Explicit On
Option Strict On

''' <summary>
''' Formulario que busca en la base de datos los distintos resultados relacionados
''' con el texto que introduzca el usuario.
''' </summary>
''' <autor>Raquel Lloréns Gambín</autor>
Public Class Buscar

    ''' <summary>
    ''' Texto por defecto antes del click
    ''' </summary>
    ''' <autor>María Navarro Sánchez</autor>
    Private Sub Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TBBuscar.Text = "" Then
            TBBuscar.Text = "    Antonio Picazo Escudero (ó) 12/12/2012   "
        End If

        With DataGridBuscar
            .ColumnCount = 5
            .Columns.Item(0).HeaderText = "Hora"
            .Columns.Item(1).HeaderText = "Cliente"
            .Columns.Item(2).HeaderText = "Servicio"
            .Columns.Item(3).HeaderText = "Duración"
            .Columns.Item(4).HeaderText = "Trabajador"
        End With

    End Sub
    Private Sub TBBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBBuscar.Click
        TBBuscar.Text = ""
    End Sub


    Private Sub PBBuscarB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBuscarB.Click
        DataGridBuscar.Rows.Clear()

        If Validaciones.EsFecha(TBBuscar.Text) Then
            BuscarFecha()
        Else
            BuscarTexto()
        End If
    End Sub
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    ''' <summary>
    ''' Busca resultados de la fecha introducida por el usuario.
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub BuscarFecha()
        Dim fecha As Date = CDate(TBBuscar.Text.Trim)
        Dim citas As List(Of Cita)
        citas = Cita.Cargar(fecha)

        If citas Is Nothing Then
            MessageBox.Show("No se han encontrado resultados a su busqueda")
        Else
            For Each Cita As Cita In citas
                For Each Servicio As Servicio In Cita.Servicios()
                    DataGridBuscar.Rows.Add(Cita.Hora().TimeOfDay, Cita.Cliente.Nombre() & " " & Cita.Cliente.Apellido1(), Servicio.Nombre(), Servicio.Duracion(), Cita.Trabajador.Nombre() & " " & Cita.Trabajador.Apellido1())
                Next
            Next
        End If
    End Sub

    ''' <summary>
    ''' Busca resultados del texto introducido por el usuario.
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub BuscarTexto()
        Dim nombres As String()
        Dim citas As List(Of Cita)

        nombres = TBBuscar.Text.Split(CChar(" "))

        If nombres.Count = 1 Then
            citas = Cita.Cargar(nombres(0))
        ElseIf nombres.Count = 2 Then
            citas = Cita.Cargar(nombres(0), nombres(1))
        ElseIf nombres.Count = 3 Then
            citas = Cita.Cargar(nombres(0), nombres(1), nombres(2))
        End If


        If citas Is Nothing Then
            MessageBox.Show("No se han encontrado resultados a su busqueda")
        Else
            For Each Cita As Cita In citas
                For Each Servicio As Servicio In Cita.Servicios()
                    DataGridBuscar.Rows.Add(Cita.Hora().TimeOfDay, Cita.Cliente.Nombre() & " " & Cita.Cliente.Apellido1(), Servicio.Nombre(), Servicio.Duracion(), Cita.Trabajador.Nombre() & " " & Cita.Trabajador.Apellido1())
                Next
            Next
        End If


    End Sub
End Class