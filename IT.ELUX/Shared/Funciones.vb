Public Class Funciones

    Public Shared Function Right(value As String, length As Integer) As String
        ' Get rightmost characters of specified length.
        Return value.Substring(value.Length - length)
    End Function

End Class
