Option Explicit On
Option Strict On

''' <summary>
''' Formulario de nuevo servicio
''' </summary>
''' <author>María Navarro, Pedro Zalacain</author>
Public Class NuevoServicio


    ''' <summary>
    ''' Método que inserta el servicio en la Base de Datos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub InsertarServicio()
        Dim Serv As New Servicio
        Serv.Nombre = TBNombreS.Text
        Serv.Descripcion = TBDescripcionS.Text
        Serv.Duracion = CInt(TBDuracionS.Text)
        Serv.Precio = CDbl(TBPrecioS.Text)

        If Serv.Insertar() = True Then
            SLblEstado.Text = "Servicio añadido correctamente"
        Else
            SLblEstado.Text = "Error en la insercción del servicio"
        End If

        Me.BorrarCampos()
    End Sub

    Private Sub BorrarCampos()
        TBNombreS.Text = ""
        TBDescripcionS.Text = ""
        TBDuracionS.Text = ""
        TBPrecioS.Text = ""
    End Sub

    Private Sub NuevoServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SLblEstado.Text = ""
    End Sub

    Private Sub PBBorrarS_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrarS.Click
        Me.BorrarCampos()
    End Sub

    Private Sub PBCancelarS_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCancelarS.Click
        Me.Close()
    End Sub

    Private Sub PBAceptarS_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptarS.Click
        Me.InsertarServicio()
    End Sub
End Class