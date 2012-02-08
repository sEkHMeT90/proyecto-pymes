Public Class NuevaCita

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' If ListBServicios.SelectedItem = 0 Then
        'MsgBox(ListBServicios.SelectedItem)
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub NuevaCita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ListBServicios.Text
    End Sub

   
    Private Sub CBoxServicios_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoxServiciosC.SelectedValueChanged

        ListBServiciosC.Items.Add(CBoxServiciosC.SelectedItem.ToString)

    End Sub
End Class