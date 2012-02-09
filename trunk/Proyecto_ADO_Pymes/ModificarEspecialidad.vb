Option Explicit On
Option Strict On

''' <summary>
''' Clase Servicio.
''' </summary>
''' <author>María Navarro, Pedro Zalacain</author>
Public Class ModificarEspecialidad

    Private ListaEspecialidades As List(Of Especialidad)

    Private Sub ModificarEspecialidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TSLblEstado.Text = ""
        CargarListBox()
    End Sub

    Private Sub CargarListBox()
        LBoxEspecialidadesM.Items.Clear()
        ListaEspecialidades = Especialidad.Cargar()

        For Each Esp In ListaEspecialidades
            LBoxEspecialidadesM.Items.Add(Esp.Nombre)
        Next
    End Sub

    Private Sub LBoxEspecialidadesM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBoxEspecialidadesM.SelectedIndexChanged
        If LBoxEspecialidadesM.Items.Count > 0 Then
            TBNombreMEs.Text = ListaEspecialidades.Item(LBoxEspecialidadesM.SelectedIndex).Nombre
            TBDescricionMEs.Text = ListaEspecialidades.Item(LBoxEspecialidadesM.SelectedIndex).Descripcion
        End If
    End Sub

    Private Sub PBModificarMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBModificarMC.Click

        ListaEspecialidades.Item(LBoxEspecialidadesM.SelectedIndex).Nombre = TBNombreMEs.Text
        ListaEspecialidades.Item(LBoxEspecialidadesM.SelectedIndex).Descripcion = TBDescricionMEs.Text

        If ListaEspecialidades.Item(LBoxEspecialidadesM.SelectedIndex).Modificar() = True Then
            TSLblEstado.Text = "Especialidad modificada satisfactoriamente"
            CargarListBox()
        Else
            TSLblEstado.Text = "Ocurrió un error mientras se intentaba modificar"
        End If
    End Sub

    Private Sub PBBorrarMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrarMC.Click
        If ListaEspecialidades.Item(LBoxEspecialidadesM.SelectedIndex).Eliminar() = True Then
            TSLblEstado.Text = "Especialidad eliminada satisfactoriamente"
            CargarListBox()
            TBNombreMEs.Text = ""
            TBDescricionMEs.Text = ""
        Else
            TSLblEstado.Text = "Ocurrió un error mientras se intentaba eliminar"
        End If
    End Sub

    Private Sub PBCancelarMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCancelarMC.Click
        Me.Close()
    End Sub
End Class