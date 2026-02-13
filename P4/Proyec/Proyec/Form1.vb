Public Class Form1
    Private Sub Sumar_Click(sender As Object, e As EventArgs) Handles Sumar.Click

        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Resultado As Integer = Numero1 + Numero2

        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Restar_Click(sender As Object, e As EventArgs) Handles Restar.Click

        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Resultado As Integer = Numero1 - Numero2

        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Multiplicar_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click

        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Resultado As Integer = Numero1 * Numero2

        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Dividir_Click(sender As Object, e As EventArgs) Handles Dividir.Click

        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Resultado As Integer = Numero1 / Numero2

        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Cero_Click(sender As Object, e As EventArgs) Handles Cero.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Uno_Click(sender As Object, e As EventArgs) Handles Uno.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Dos_Click(sender As Object, e As EventArgs) Handles Dos.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Tres_Click(sender As Object, e As EventArgs) Handles Tres.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Cuatro_Click(sender As Object, e As EventArgs) Handles Cuatro.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Cinco_Click(sender As Object, e As EventArgs) Handles Cinco.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Seis_Click(sender As Object, e As EventArgs) Handles Seis.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Siete_Click(sender As Object, e As EventArgs) Handles Siete.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Ocho_Click(sender As Object, e As EventArgs) Handles Ocho.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Nueve_Click(sender As Object, e As EventArgs) Handles Nueve.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        TextBox1.Text = ""
    End Sub
End Class
