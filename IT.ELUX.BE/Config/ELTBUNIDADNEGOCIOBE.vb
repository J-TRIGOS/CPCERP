Public Class ELTBUNIDADNEGOCIOBE
    Private mcod As String
    Private mnombre As String
    Private mest As String
    Public Property cod() As String
        Get
            Return mcod
        End Get
        Set(ByVal value As String)
            mcod = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return mnombre
        End Get
        Set(ByVal value As String)
            mnombre = value
        End Set
    End Property
    Public Property est() As String
        Get
            Return mest
        End Get
        Set(ByVal value As String)
            mest = value
        End Set
    End Property
End Class
