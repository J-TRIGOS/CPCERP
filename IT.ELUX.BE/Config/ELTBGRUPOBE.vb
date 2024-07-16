Public Class ELTBGRUPOBE
    Private mcod As String
    Private mnom As String
    Private mest As String
    Private mcco_cod As String

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

    Public Property cco_cod As String
        Get
            Return mcco_cod
        End Get
        Set(value As String)
            mcco_cod = value
        End Set
    End Property
End Class
