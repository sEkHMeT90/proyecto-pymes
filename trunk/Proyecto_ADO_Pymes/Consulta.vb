Option Explicit On
Option Strict On

''' <summary>
''' Formulario Principal
''' </summary>
''' <author>María Navarro, Pedro Zalacain</author>
Public Class Consulta
    Const Semanal As String = "Semanal"
    Const Mensual As String = "Mensual"
    Const Anual As String = "Anual"
    Private Estado As String
    Private ListaCitas As List(Of Cita)

    Private Sub Consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TSLabEstado.Text = ""
        Estado = Semanal
        CargarDataGrid()
    End Sub

    Private Sub MCalendar_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MCalendar.DateChanged
        CargarDataGrid()
    End Sub

    Private Sub CargarDataGrid()
        ' Limpio el contenido del DataGrid
        DatosConsulta.Rows.Clear()
        DatosConsulta.Columns.Clear()

        ' Compruebo el siguiente estado
        If Estado = Semanal Then
            DatosConsulta.ScrollBars = ScrollBars.Vertical
            Dim DiasSemana(7) As Integer
            DatosConsulta.ColumnCount = 7
            DatosConsulta.RowTemplate.Height = 22

            ' Memorizo los dias de la semana en un Array
            Select Case CInt(MCalendar.SelectionRange.Start.DayOfWeek)
                Case 0
                    DiasSemana(0) = MCalendar.SelectionRange.Start.Day - 6
                    DiasSemana(1) = MCalendar.SelectionRange.Start.Day - 5
                    DiasSemana(2) = MCalendar.SelectionRange.Start.Day - 4
                    DiasSemana(3) = MCalendar.SelectionRange.Start.Day - 3
                    DiasSemana(4) = MCalendar.SelectionRange.Start.Day - 2
                    DiasSemana(5) = MCalendar.SelectionRange.Start.Day - 1
                    DiasSemana(6) = MCalendar.SelectionRange.Start.Day
                Case 1
                    DiasSemana(0) = MCalendar.SelectionRange.Start.Day
                    DiasSemana(1) = MCalendar.SelectionRange.Start.Day + 1
                    DiasSemana(2) = MCalendar.SelectionRange.Start.Day + 2
                    DiasSemana(3) = MCalendar.SelectionRange.Start.Day + 3
                    DiasSemana(4) = MCalendar.SelectionRange.Start.Day + 4
                    DiasSemana(5) = MCalendar.SelectionRange.Start.Day + 5
                    DiasSemana(6) = MCalendar.SelectionRange.Start.Day + 6
                Case 2
                    DiasSemana(0) = MCalendar.SelectionRange.Start.Day - 1
                    DiasSemana(1) = MCalendar.SelectionRange.Start.Day
                    DiasSemana(2) = MCalendar.SelectionRange.Start.Day + 1
                    DiasSemana(3) = MCalendar.SelectionRange.Start.Day + 2
                    DiasSemana(4) = MCalendar.SelectionRange.Start.Day + 3
                    DiasSemana(5) = MCalendar.SelectionRange.Start.Day + 4
                    DiasSemana(6) = MCalendar.SelectionRange.Start.Day + 5
                Case 3
                    DiasSemana(0) = MCalendar.SelectionRange.Start.Day - 2
                    DiasSemana(1) = MCalendar.SelectionRange.Start.Day - 1
                    DiasSemana(2) = MCalendar.SelectionRange.Start.Day
                    DiasSemana(3) = MCalendar.SelectionRange.Start.Day + 1
                    DiasSemana(4) = MCalendar.SelectionRange.Start.Day + 2
                    DiasSemana(5) = MCalendar.SelectionRange.Start.Day + 3
                    DiasSemana(6) = MCalendar.SelectionRange.Start.Day + 4
                Case 4
                    DiasSemana(0) = MCalendar.SelectionRange.Start.Day - 3
                    DiasSemana(1) = MCalendar.SelectionRange.Start.Day - 2
                    DiasSemana(2) = MCalendar.SelectionRange.Start.Day - 1
                    DiasSemana(3) = MCalendar.SelectionRange.Start.Day
                    DiasSemana(4) = MCalendar.SelectionRange.Start.Day + 1
                    DiasSemana(5) = MCalendar.SelectionRange.Start.Day + 2
                    DiasSemana(6) = MCalendar.SelectionRange.Start.Day + 3
                Case 5
                    DiasSemana(0) = MCalendar.SelectionRange.Start.Day - 4
                    DiasSemana(1) = MCalendar.SelectionRange.Start.Day - 3
                    DiasSemana(2) = MCalendar.SelectionRange.Start.Day - 2
                    DiasSemana(3) = MCalendar.SelectionRange.Start.Day - 1
                    DiasSemana(4) = MCalendar.SelectionRange.Start.Day
                    DiasSemana(5) = MCalendar.SelectionRange.Start.Day + 1
                    DiasSemana(6) = MCalendar.SelectionRange.Start.Day + 2
                Case 6
                    DiasSemana(0) = MCalendar.SelectionRange.Start.Day - 5
                    DiasSemana(1) = MCalendar.SelectionRange.Start.Day - 4
                    DiasSemana(2) = MCalendar.SelectionRange.Start.Day - 3
                    DiasSemana(3) = MCalendar.SelectionRange.Start.Day - 2
                    DiasSemana(4) = MCalendar.SelectionRange.Start.Day - 1
                    DiasSemana(5) = MCalendar.SelectionRange.Start.Day
                    DiasSemana(6) = MCalendar.SelectionRange.Start.Day + 1
            End Select

            DatosConsulta.Columns(0).HeaderText = "Lunes " & DiasSemana(0)
            DatosConsulta.Columns(1).HeaderText = "Martes " & DiasSemana(1)
            DatosConsulta.Columns(2).HeaderText = "Miércoles " & DiasSemana(2)
            DatosConsulta.Columns(3).HeaderText = "Jueves " & DiasSemana(3)
            DatosConsulta.Columns(4).HeaderText = "Viernes " & DiasSemana(4)
            DatosConsulta.Columns(5).HeaderText = "Sábado " & DiasSemana(5)
            DatosConsulta.Columns(6).HeaderText = "Domingo " & DiasSemana(6)

            For N = 0 To 6
                Dim Fecha As String = (DiasSemana(N) & "/" & MCalendar.SelectionRange.Start.Month & "/" & MCalendar.SelectionRange.Start.Year)
                If Validaciones.EsFecha(Fecha) Then
                    ListaCitas = Cita.Cargar(CDate(Fecha))
                    For Y = 0 To ListaCitas.Count - 1
                        DatosConsulta.Rows.Add()
                        DatosConsulta.Rows(Y).Cells(N).Value = ListaCitas(Y).Servicios(0).Descripcion
                        DatosConsulta.Rows(Y).Cells(N).ToolTipText = CStr(ListaCitas(Y).Fecha) & " - " & ListaCitas(Y).Hora
                    Next
                Else
                    DatosConsulta.Columns(N).Visible = False
                End If
            Next


        ElseIf Estado = Mensual Then
            DatosConsulta.ScrollBars = ScrollBars.Vertical
            DatosConsulta.RowTemplate.Height = 22
            Dim MesConsulta As Integer = MCalendar.SelectionRange.Start.Month
            ListaCitas = Cita.ObtenerPorMes(MesConsulta)

            DatosConsulta.ColumnCount = 7

            DatosConsulta.Columns(0).HeaderText = "Código"
            DatosConsulta.Columns(1).HeaderText = "Cliente"
            DatosConsulta.Columns(2).HeaderText = "Trabajador"
            DatosConsulta.Columns(3).HeaderText = "Fecha"
            DatosConsulta.Columns(4).HeaderText = "Hora"
            DatosConsulta.Columns(5).HeaderText = "Duración"
            DatosConsulta.Columns(6).HeaderText = "Servicios"

            For Each Cit As Cita In ListaCitas
                DatosConsulta.Rows.Add(Cit.Codigo, Cit.Cliente.Apellido1, Cit.Trabajador.Apellido1, Cit.Fecha, Cit.Hora.Hour.ToString("00") & ":" & Cit.Hora.Minute.ToString("00"), Cit.Duracion, Cit.Servicios(0).Descripcion)
            Next
        Else
            DatosConsulta.ScrollBars = ScrollBars.None
            Dim Meses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
            DatosConsulta.RowTemplate.Height = 175
            DatosConsulta.ColumnCount = 6
            DatosConsulta.Columns(0).HeaderText = "Año " & MCalendar.SelectionRange.Start.Year
            DatosConsulta.Rows.Add(Meses(0), Meses(1), Meses(2), Meses(3), Meses(4), Meses(5))
            DatosConsulta.Rows.Add(Meses(6), Meses(7), Meses(8), Meses(9), Meses(10), Meses(11))

            For N = 0 To 1
                For Y = 0 To 5
                    Dim Mes, Anio As Integer
                    If N = 0 Then
                        Mes = Y + 1
                        Anio = MCalendar.SelectionRange.Start.Year
                    Else
                        Mes = Y + 7
                        Anio = MCalendar.SelectionRange.Start.Year
                    End If
                    If Cita.HayCitas(Mes, Anio) Then
                        DatosConsulta.Rows(N).Cells(Y).Style.BackColor = Color.Green
                    Else
                        DatosConsulta.Rows(N).Cells(Y).Style.BackColor = Color.Red
                    End If
                Next
            Next
            DatosConsulta.ClearSelection()
        End If

        LblVista.Text = Estado
    End Sub

    Private Sub PBSemanaCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBSemanaCon.Click
        Estado = Semanal
        CargarDataGrid()
    End Sub

    Private Sub PBMesCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBMesCon.Click
        Estado = Mensual
        CargarDataGrid()
    End Sub

    Private Sub PBAnioCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAnioCon.Click
        Estado = Anual
        CargarDataGrid()
    End Sub


End Class