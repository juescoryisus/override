Public Class alumno
    Inherits persona

    Public Property Curso As String
    Public Property Promedio As Double

    Public Overrides Function Presentarse() As String
        Return MyBase.Presentarse() & " Soy un estudiante del curso " & Curso & " con un promedio de " & Promedio & "."
    End Function
End Class
