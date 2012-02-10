Option Explicit On
Option Strict On

''' <summary>
''' Clase Especialidad.
''' </summary>
''' <author>María Navarro, Pedro Zalacain</author>

Public Class NuevaEspecialidad

    ''' <summary>
    ''' Inserta una nueva Especialidad
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub InsertarEspecialidad()
        Dim NuevaEspec As New Especialidad()
        NuevaEspec.Nombre = TBNombreEs.Text
        NuevaEspec.Descripcion = TBDescricionEs.Text

        If NuevaEspec.Insertar() = True Then
            TSLabEstado.Text = "Especialidad añadida"
            Me.BorrarCampos()
        Else
            TSLabEstado.Text = "Ocurrió un error en la inserción"
        End If
    End Sub

    ''' <summary>
    ''' Vacía el contenido de los campos
    ''' </summary>
    ''' <author>Pedro Zalacain</author>
    Private Sub BorrarCampos()
        TBNombreEs.Text = ""
        TBDescricionEs.Text = ""
    End Sub

    Private Sub NuevaEspecialidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TSLabEstado.Text = ""
    End Sub

    Private Sub PBBorrarEs_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBBorrarEs.Click
        Me.BorrarCampos()
    End Sub

    Private Sub PBCancelarEs_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCancelarEs.Click
        Me.Close()
    End Sub

    Private Sub PBAceptarEs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBAceptarEs.Click
        Me.InsertarEspecialidad()
    End Sub
End Class