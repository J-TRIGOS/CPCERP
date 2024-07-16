Public Class ELTBGRUPCORBE
    Private mcod As String
    Private mnom As String
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

    Public Property nom() As String
        Get
            Return mnom
        End Get
        Set(ByVal value As String)
            mnom = value
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
