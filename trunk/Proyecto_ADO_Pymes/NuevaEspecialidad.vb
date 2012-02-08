Option Explicit On
Option Strict On

''' <summary>
''' Clase Especialidad.
''' </summary>
''' <author>María Navarro, Pedro Zalacain</author>

Public Class NuevaEspecialidad

    ''' <summary>
    ''' Botón .
    ''' </summary>
    ''' <author>María Navarro, Pedro Zalacain</author>
    Private Sub PBAceptarU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptarEs.Click
        Dim NuevaEspec As New Especialidad()
        NuevaEspec.Nombre = TBNombreEs.Text
        NuevaEspec.Descripcion = TBDescricionEs.Text

        If NuevaEspec.Insertar() = True Then
            MessageBox.Show("Especialidad añadida...")
        Else
            MessageBox.Show("Orucción un error en la inserción...")
        End If
    End Sub
End Class