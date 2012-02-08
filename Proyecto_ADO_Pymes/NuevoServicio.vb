Public Class NuevoServicio

    Private Sub PBAceptarS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptarS.Click

    End Sub

    Private Sub LblAceptarS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblAceptarS.Click

    End Sub

    Private Sub InsertarServicio()
        Dim Serv As New Servicio
        Serv.Nombre = TBNombreS.Text
        Serv.Descripcion = TBDescripcionS.Text
        Serv.Duracion = TBDuracionS.Text
        Serv.Precio = TBDescripcionS.Text

        If Serv.Insertar() = True Then
            MessageBox.Show("Servicio añadido correctamente...")
        Else
            MessageBox.Show("Error en la insercción del servicio")
        End If
    End Sub

End Class