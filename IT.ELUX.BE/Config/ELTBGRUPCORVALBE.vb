Public Class ELTBGRUPCORVALBE
    Private mcod As String
    Private mcor_val As String
    Private mest As String

    'Propiedades de la entidad
    Public Property cod() As String
        Get
            Return mcod
        End Get
        Set(ByVal value As String)
            mcod = value
        End Set
    End Property

    Public Property cor_val() As String
        Get
            Return mcor_val
        End Get
        Set(ByVal value As String)
            mcor_val = value
        End Set
    End Property

    Public Property est As String
        Get
            Return mest
        End Get
        Set(value As String)
            mest = value
        End Set
    End Property
End Class
