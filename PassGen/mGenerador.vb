Module mGenerador

    Const numeros As String = "1234567890" 'Numeros
    Const letras As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" 'Letras
    Const simbolos As String = "|-_}[{]+*¿¡\?=)(/&%$#@!" 'Algunos caracteres especiales
    Const longMinima As Integer = 6 'Longitud minima que generalmente se pida para las contraseñas

    Function juegoCaracteres(nivel As Integer) As Char()
        'Funcion para determinar el arreglo con el juego de caracteres a utilizar
        'nivel: el nivel de seguridad deseado para la contraseña

        Dim caracteres As String = Nothing 'Almacena el juego total de caracteres a utilizar

        Select Case nivel
            Case 0, 1, 2
                caracteres = letras & LCase(letras) & numeros
            Case 3, 4
                caracteres = letras & LCase(letras) & numeros & simbolos
        End Select

        Return caracteres.ToCharArray
    End Function

    Function generarContrasenia(nivel As Integer) As String
        'Funcion para generar la contraseña aleatoria
        'nivel: es el nivel de seguridad deseado para la contraseña

        Dim longitud As Integer = longMinima + nivel 'Almacena la longitud que tendrá la contaseña.
        Dim caracteres As Char() = juegoCaracteres(nivel) 'Almacena el Arreglo con los caracteres
        Dim aleatorio As Integer = 0 'Almacena un número aleatorio que servirá como indice para formar la contraseña

        generarContrasenia = ""

        For a = 1 To longitud
            Randomize()
            aleatorio = CInt(Int((caracteres.Length - 1) * Rnd()))
            generarContrasenia = generarContrasenia & caracteres(aleatorio)
        Next

        Return generarContrasenia
    End Function

    Function nivelSeguridad(ByRef control As TrackBar, ByRef etiqueta As Label)
        'Funcion para colocar la Descripción de la seguridad y el color de la misma
        'control: es la barra de posiciones del niver de seguridad
        'etiqueta: es el control donde se colocaran los resultados de acuerdo al valor de CONTROL

        Dim nivel As Integer = control.Value 'Almacena la posición (valor) del control de posiciones

        Dim texto As String = "" 'Almacena la descripción del nivel de seguridad
        Dim colorNivel As Color = Nothing 'Almacena el color que tendrá la descricpción


        Select Case nivel
            Case 0
                texto = "Muy Débil"
                colorNivel = Color.Red

            Case 1
                texto = "Débil"
                colorNivel = Color.Orange

            Case 2
                texto = "Media"
                colorNivel = Color.Gold

            Case 3
                texto = "Fuerte"
                colorNivel = Color.YellowGreen

            Case 4
                texto = "Muy Fuerte"
                colorNivel = Color.Green

        End Select

        etiqueta.Text = texto
        etiqueta.ForeColor = colorNivel

        Return Nothing
    End Function


End Module
