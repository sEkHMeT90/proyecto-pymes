Option Strict On
Option Explicit On

''' <summary>
''' Clase Facturacion para el cobro de las citas
''' </summary>
''' <author>María Navarro, Andrés Marotta</author>
Public Class Facturacion
    Private _Cita As Cita
    Private _TiposPago As List(Of TipoPago)

    ''' <summary>
    ''' Constructor por parámetros
    ''' </summary>
    ''' <param name="cita">Cita a cobrar</param>
    ''' <author>Andrés Marotta</author>
    Public Sub New(ByVal cita As Cita)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me._Cita = cita
    End Sub

    ''' <summary>
    ''' Rellena todos los controles del formulario
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Total As Double = 0
        Dim tipos As List(Of TipoPago) = TipoPago.Cargar()

        Me.TBClienteF.Text = Me._Cita.Cliente.Apellido1 & " " & Me._Cita.Cliente.Apellido2 & ", " & Me._Cita.Cliente.Nombre
        Me.TBDniF.Text = Me._Cita.Cliente.Dni
        Me.TBFecha.Text = Me._Cita.Fecha.Day & "/" & Me._Cita.Fecha.Month & "/" & Me._Cita.Fecha.Year
        Me.TBHora.Text = Me._Cita.Hora.Hour & ":" & Me._Cita.Hora.Minute
        Me.TBEmpleado.Text = Me._Cita.Trabajador.Apellido1 & " " & Me._Cita.Trabajador.Apellido2 & ", " & Me._Cita.Trabajador.Nombre

        For Each servicio In Me._Cita.Servicios
            Me.ListBServiciosF.Items.Add(servicio.Nombre)
            Total += servicio.Precio
        Next

        Me.TBTotal.Text = CStr(Total)

        For Each tipo In tipos
            Me.CBTipoPago.Items.Add(tipo.Descripcion)
        Next
    End Sub

    ''' <summary>
    ''' Cobra la cita actual
    ''' </summary>
    ''' <author>Andrés Marotta</author>
    Private Sub PBCobrarMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCobrarMC.Click
        Dim nueva As New Factura

        If Me.CBTipoPago.SelectedIndex >= 0 Then
            nueva.codCita = Me._Cita.Codigo
            nueva.Fecha = CDate(Now.Day & "/" & Now.Month & "/" & Now.Year)
            nueva.Total = CDbl(Me.TBTotal.Text)
            nueva.TipoPago = Me._TiposPago(Me.CBTipoPago.SelectedIndex)

            For Each servicio In Me._Cita.Servicios
                Dim linea As New LineaFactura
                linea.Descripcion = servicio.Nombre & "-" & servicio.Precio
                nueva.lineasFactura.Add(linea)
            Next

            If nueva.Cobrar() Then
                TSLabEstado.Text = "Factura realizada"
            Else
                TSLabEstado.Text = "Error al realizar el cobro"
            End If
        End If
    End Sub
End Class