Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim estudiante As New alumno()

        estudiante.Nombre = TextBox1.Text
        estudiante.Edad = Integer.Parse(TextBox2.Text)
        estudiante.Genero = TextBox3.Text
        estudiante.Curso = TextBox4.Text
        estudiante.Promedio = Double.Parse(TextBox5.Text)

        Label6.Text = estudiante.Presentarse()

    End Sub
End Class
