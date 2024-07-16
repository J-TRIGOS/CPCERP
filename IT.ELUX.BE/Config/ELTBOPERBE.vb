Public Class ELTBOPERBE
    'Campos de la entidad
    Private mcod As String
    Private mdescri As String
    Private mest As String
    Private mnpases As Int32

    'Propiedades de la entidad
    Public Property cod() As String
        Get
            Return mcod
        End Get
        Set(ByVal value As String)
            mcod = value
        End Set
    End Property

    Public Property descri() As String
        Get
            Return mdescri
        End Get
        Set(ByVal value As String)
            mdescri = value
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

    Public Property npases As Int32
        Get
            Return mnpases
        End Get
        Set(value As Int32)
            mnpases = value
        End Set
    End Property
End Class
