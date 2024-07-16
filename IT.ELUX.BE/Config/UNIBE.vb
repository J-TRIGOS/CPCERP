Public Class UNIBE

    'Campos de la entidad
    Private mcod As String
    Private mnom As String
    Private msigla As String
    Private mnompl As String
    Private mestado As String

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

    Public Property sigla() As String
        Get
            Return msigla
        End Get
        Set(ByVal value As String)
            msigla = value
        End Set
    End Property

    Public Property nompl() As String
        Get
            Return mnompl
        End Get
        Set(ByVal value As String)
            mnompl = value
        End Set
    End Property
    Public Property estado() As String
        Get
            Return mestado
        End Get
        Set(ByVal value As String)
            mestado = value
        End Set
    End Property
End Class
