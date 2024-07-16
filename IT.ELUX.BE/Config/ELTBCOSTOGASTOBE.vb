Public Class ELTBCOSTOGASTOBE
    Private mcod As String
    Private mdescripcion As String
    Private mtipo As String
    Private mest As String
    Public Property cod() As String
        Get
            Return mcod
        End Get
        Set(ByVal value As String)
            mcod = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return mdescripcion
        End Get
        Set(ByVal value As String)
            mdescripcion = value
        End Set
    End Property
    Public Property tipo() As String
        Get
            Return mtipo
        End Get
        Set(ByVal value As String)
            mtipo = value
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
