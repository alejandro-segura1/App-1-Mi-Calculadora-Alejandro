Public Class Form1
    Dim activo
    Private Sub Sumar_Click(sender As Object, e As EventArgs) Handles Sumar.Click

        Dim Numero1 As Double = Double.Parse(activo.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)

        Dim Resultado As Double = Numero1 + Numero2

        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Restar_Click(sender As Object, e As EventArgs) Handles Restar.Click

        Dim Numero1 As Double = Double.Parse(activo.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)

        Dim Resultado As Double = Numero1 - Numero2

        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Multiplicar_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click

        Dim Numero1 As Double = Double.Parse(activo.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)

        Dim Resultado As Double = Numero1 * Numero2

        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Dividir_Click(sender As Object, e As EventArgs) Handles Dividir.Click

        Dim Numero1 As Double = Double.Parse(activo.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)

        Dim Resultado As Double = Numero1 / Numero2

        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Cero_Click(sender As Object, e As EventArgs) Handles Cero.Click
        activo.Text = activo.Text & "0"
    End Sub

    Private Sub Uno_Click(sender As Object, e As EventArgs) Handles Uno.Click
        activo.Text = activo.Text & "1"
    End Sub

    Private Sub Dos_Click(sender As Object, e As EventArgs) Handles Dos.Click
        activo.Text = activo.Text & "2"
    End Sub

    Private Sub Tres_Click(sender As Object, e As EventArgs) Handles Tres.Click
        activo.Text = activo.Text & "3"
    End Sub

    Private Sub Cuatro_Click(sender As Object, e As EventArgs) Handles Cuatro.Click
        activo.Text = activo.Text & "4"
    End Sub

    Private Sub Cinco_Click(sender As Object, e As EventArgs) Handles Cinco.Click
        activo.Text = activo.Text & "5"
    End Sub

    Private Sub Seis_Click(sender As Object, e As EventArgs) Handles Seis.Click
        activo.Text = activo.Text & "6"
    End Sub

    Private Sub Siete_Click(sender As Object, e As EventArgs) Handles Siete.Click
        activo.Text = activo.Text & "7"
    End Sub

    Private Sub Ocho_Click(sender As Object, e As EventArgs) Handles Ocho.Click
        activo.Text = activo.Text & "8"
    End Sub

    Private Sub Nueve_Click(sender As Object, e As EventArgs) Handles Nueve.Click
        activo.Text = activo.Text & "9"
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        activo.Text = ""
    End Sub

    Private Sub Punto_Click(sender As Object, e As EventArgs) Handles Punto.Click
        activo.Text = activo.Text & "."
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        activo = TextBox1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        activo = TextBox2
    End Sub
End Class
