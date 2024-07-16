Public Class FORMA_ENTBE

    'Campos de la entidad
    Private mcod As String
    Private mnom As String
    Private mestado As String

    Public Property cod As String
        Get
            Return mcod
        End Get
        Set(value As String)
            mcod = value
        End Set
    End Property

    Public Property nom As String
        Get
            Return mnom
        End Get
        Set(value As String)
            mnom = value
        End Set
    End Property

    Public Property estado As String
        Get
            Return mestado
        End Get
        Set(value As String)
            mestado = value
        End Set
    End Property

    'Propiedades de la entidad

End Class
