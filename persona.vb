Public Class persona
    Public Property Nombre As String
    Public Property Edad As Integer
    Public Property Genero As String

    Public Overridable Function Presentarse() As String
        Return "Hola, mi nombre es " & Nombre & ", tengo " & Edad & " años y soy " & Genero & "."
    End Function
End Class
