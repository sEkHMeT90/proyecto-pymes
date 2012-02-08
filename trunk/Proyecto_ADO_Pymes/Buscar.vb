Public Class Buscar

    Private Sub TBBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBBuscar.Text = ""
    End Sub

    Private Sub Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TBBuscar.Text = "" Then
            TBBuscar.Text = "    Antonio Picazo Escudero (ó) 12/12/2012   "
        End If
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class