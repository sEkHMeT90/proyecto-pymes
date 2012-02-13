''' <summary>
''' Módulo en el que se recogen todas las validaciones de los distintos apartados.
''' </summary>
''' <author>Raquel Lloréns Gambín</author> 

Module Validaciones
    ''' <summary>
    ''' Función que comprueba que una cadena de texto esté compuesta únicamente
    ''' por letras.
    ''' </summary>
    ''' <param name="texto">Cadena de texto a comprobar</param>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Function EsTexto(ByVal texto As String) As Boolean
        Dim correcto As Boolean = False

        texto = texto.Trim

        For Each caracter As Char In texto
            'Si el carácter no es una letra
            If (((Asc(caracter) < 65) And (Asc(caracter) > 90)) Or
                ((Asc(caracter) < 97) And (Asc(caracter) > 122))) Then
                correcto = False
            End If
        Next

        Return correcto
    End Function

    ''' <summary>
    ''' Función que comprueba si la longitud de una cadena está dentro de las permitidas.
    ''' </summary>
    ''' <param name="texto">Cadena de carácteres a comprobar</param>
    ''' <param name="longitudMin">Longitud mínima requerida</param>
    ''' <param name="longitudMax">Longitud máxima requerida</param>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Function LongitudString(ByVal texto As String, ByVal longitudMin As Integer, ByVal longitudMax As Integer) As Boolean
        Dim correcto As Boolean = False

        If texto.Length >= longitudMin Then
            correcto = True
        Else
            correcto = False
        End If

        If texto.Length <= longitudMax Then
            correcto = True
        Else
            correcto = False
        End If

        Return correcto
    End Function

    ''' <summary>
    ''' Función que comprueba de una cadena es un número y si la 
    ''' longitud de dicha cadena está dentro de las permitidas.
    ''' </summary>
    ''' <param name="texto">Cadena de carácteres a comprobar</param>
    ''' <param name="longitudMin">Longitud mínima requerida</param>
    ''' <param name="longitudMax">Longitud máxima requerida</param>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Function LongitudNumero(ByVal texto As String, ByVal longitudMin As Integer, ByVal longitudMax As Integer) As Boolean
        Dim correcto As Boolean = False

        Try
            'Intentamos convertir a integer
            If EsNumero(texto) = False Then
                correcto = False
            Else
                'Comprobamos que esté entre la longitud mínima y máxima requeridas
                If (texto.Length >= longitudMin) And (texto.Length <= longitudMax) Then
                    correcto = True
                Else
                    correcto = False
                End If
            End If

        Catch ex As Exception
            correcto = False
        End Try

        Return correcto
    End Function



    ''' <summary>
    ''' Función que comprueba de una cadena es un número.
    ''' </summary>
    ''' <param name="texto">Cadena de carácteres a comprobar</param>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Function EsNumero(ByVal texto As String) As Boolean
        Dim correcto As Boolean = False
        Dim numero As Integer

        Try
            numero = CInt(texto)
            correcto = True
        Catch ex As Exception
            correcto = False
        End Try

        Return correcto
    End Function

    ''' <summary>
    ''' Función que comprueba de una cadena es un número y si dicho número
    ''' se encuentra entre los dos números requeridos.
    ''' </summary>
    ''' <param name="texto">Cadena de carácteres a comprobar</param>
    ''' <param name="tamanyoMin">Número mínimo requerido</param>
    ''' <param name="tamanyoMax">Número máximo requerido</param>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Function TamanyoNumero(ByVal texto As String, ByVal tamanyoMin As Integer, ByVal tamanyoMax As Integer) As Boolean
        Dim correcto As Boolean = False
        Dim numero As Integer

        Try
            numero = CInt(texto)

            If (numero >= tamanyoMin) And (numero <= tamanyoMax) Then
                correcto = True
            Else
                correcto = False
            End If

        Catch ex As Exception
            correcto = False
        End Try

        Return correcto
    End Function

    ''' <summary>
    ''' Función que comprueba si el e-mail introducido por el usuario es válido
    ''' </summary>
    ''' <param name="email">E-mail a comprobar</param>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Function comprobarEmail(ByVal email As String) As Boolean
        Dim correcto As Boolean = False

        'Quitamos los espacios en blanco
        email = email.Trim()

        'Si no hay nada escrito, no es correcto
        If email = "" Then
            correcto = False

            'Si no contiene mínimo un arroba (@) y un punto (.), no es correcto
        ElseIf (Not email.Contains("@")) And (Not email.Contains(".")) Then
            correcto = False

            'Si el primer carácter es un arroba o un punto, no es correcto
        ElseIf email(0) = "@" Or email(0) = "." Then
            correcto = False

            'Si el primer arroba está detrás de el último punto, no es correcto
        ElseIf email.IndexOf("@") > email.LastIndexOf(".") Then
            correcto = False

            'Si no se cumple ninguna de las anteriores, es correcto
        Else
            correcto = True
        End If

        Return correcto
    End Function

    ''' <summary>
    ''' Función que comprueba si una cadena de carácteres es una fecha.
    ''' </summary>
    ''' <param name="texto">Cadena de carácteres a comprobar</param>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Function EsFecha(ByVal texto As String) As Boolean
        Dim correcto As Boolean = False
        Dim fecha As Date

        texto = texto.Trim

        Try
            fecha = CDate(texto)

            correcto = True
        Catch ex As Exception
            correcto = False
        End Try

        Return correcto
    End Function

    ''' <summary>
    ''' Indica si una cadena es un DNI.
    ''' </summary>
    ''' <param name="texto">Cadena a comprobar</param>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Function EsDNI(ByVal texto As String) As Boolean
        Dim correcto As Boolean = False

        If texto.Length() = 9 And (texto(0) = CChar("X") Or texto(0) = CChar("x") Or EsNumero(texto(0))) And _
            EsTexto(texto(8)) And EsNumero(texto.Substring(1, 7)) Then
            correcto = True
        Else
            correcto = False
        End If

        Return correcto
    End Function

End Module