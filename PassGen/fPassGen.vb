Public Class fPassGen

    Private Sub TrackBarNivelSeg_Scroll(sender As Object, e As EventArgs) Handles TrackBarNivelSeg.Scroll
        'Cuando se cambia la posición de la barra de posiciones, llama a la función para poner el color y descripción del nivel de seguridad
        mGenerador.nivelSeguridad(Me.TrackBarNivelSeg, Me.lNivelSeg)
        Me.tbContrasGenerada.Text = ""
    End Sub

    Private Sub fPassGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el programa, llama a la función para poner el color y descripción del nivel de seguridad
        mGenerador.nivelSeguridad(Me.TrackBarNivelSeg, Me.lNivelSeg)
    End Sub

    Private Sub bGenerar_Click(sender As Object, e As EventArgs) Handles bGenerar.Click
        'Al presionar el botón
        'Llama a la función de generar contraseña y coloca el resultado en el Textbox
        Me.tbContrasGenerada.Text = mGenerador.generarContrasenia(Me.TrackBarNivelSeg.Value)
        'MsgBox("Contraseña Generada")
    End Sub
End Class
