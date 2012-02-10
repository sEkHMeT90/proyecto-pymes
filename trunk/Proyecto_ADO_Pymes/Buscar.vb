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
    End Sub
    Private Sub TBBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBBuscar.Click
        TBBuscar.Text = ""
    End Sub


    Private Sub PBBuscarB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBuscarB.Click
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
        citas = Cita.Cargar()

        With DataGridBuscar
            .ColumnCount = 4
            .Columns.Item(0).HeaderText = "Hora"
            .Columns.Item(1).HeaderText = "Cliente"
            .Columns.Item(2).HeaderText = "Servicios"
            .Columns.Item(3).HeaderText = "Trabajador"
        End With

        For Each Cita As Cita In citas
            If Cita.Fecha() = fecha Then
                DataGridBuscar.Rows.Add(Cita.Hora(), Cita.Cliente(), Cita.Servicios.ToString(), Cita.Trabajador())
            End If
        Next

    End Sub

    ''' <summary>
    ''' Busca resultados del texto introducido por el usuario.
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub BuscarTexto()
        'TODO
    End Sub
End Class