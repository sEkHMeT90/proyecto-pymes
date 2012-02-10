Option Explicit On
Option Strict On

''' <summary>
''' Formulario ModificarServicios
''' </summary>
''' <author>María Navarro, Pedro Zalacain</author>
Public Class ModificarServicios

    Private ListaServicios As List(Of Servicio)

    Private Sub CargarListBox()
        LBoxServiciosM.Items.Clear()
        ListaServicios = Servicio.Cargar()

        For Each Serv In ListaServicios
            LBoxServiciosM.Items.Add(Serv.Nombre)
        Next
    End Sub

    Private Sub PBModificarMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ListaServicios.Item(LBoxServiciosM.SelectedIndex).Nombre = TBNombreSM.Text
        ListaServicios.Item(LBoxServiciosM.SelectedIndex).Descripcion = TBDescripcionSM.Text
        ListaServicios.Item(LBoxServiciosM.SelectedIndex).Duracion = CInt(TBDuracionSM.Text)
        ListaServicios.Item(LBoxServiciosM.SelectedIndex).Precio = CDbl(TBPrecioSM.Text)

        If ListaServicios.Item(LBoxServiciosM.SelectedIndex).Modificar() = True Then
            TSLabEstado.Text = "Servicio modificado satisfactoriamente"
            CargarListBox()
        Else
            TSLabEstado.Text = "Ocurrió un error mientras se intentaba modificar"
        End If
    End Sub

    Private Sub PBBorrarMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ListaServicios.Item(LBoxServiciosM.SelectedIndex).Eliminar() = True Then
            TSLabEstado.Text = "Servicio eliminado satisfactoriamente"
            CargarListBox()
            TBNombreSM.Text = ""
            TBDescripcionSM.Text = ""
            TBDuracionSM.Text = ""
            TBPrecioSM.Text = ""
        Else
            TSLabEstado.Text = "Ocurrió un error mientras se intentaba eliminar"
        End If
    End Sub

    Private Sub PBCancelarMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LBoxServiciosM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBoxServiciosM.SelectedIndexChanged
        If LBoxServiciosM.Items.Count > 0 Then
            TBNombreSM.Text = ListaServicios.Item(LBoxServiciosM.SelectedIndex).Nombre
            TBDescripcionSM.Text = ListaServicios.Item(LBoxServiciosM.SelectedIndex).Descripcion
            TBDuracionSM.Text = CStr(ListaServicios.Item(LBoxServiciosM.SelectedIndex).Duracion)
            TBPrecioSM.Text = CStr(ListaServicios.Item(LBoxServiciosM.SelectedIndex).Precio)
        End If
    End Sub

    Private Sub ModificarServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TSLabEstado.Text = ""
        CargarListBox()
    End Sub
End Class