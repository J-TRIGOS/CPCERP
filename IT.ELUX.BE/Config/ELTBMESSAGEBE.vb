Public Class ELTBMESSAGEBE
    'Campos de la entidad
    Private mmsg_codigo As String
    Private mmsg_descri As String
    Private mmsg_codest As String

    'Propiedades de la entidad
    Public Property msg_codigo() As String
        Get
            Return mmsg_codigo
        End Get
        Set(ByVal value As String)
            mmsg_codigo = value
        End Set
    End Property

    Public Property msg_descri() As String
        Get
            Return mmsg_descri
        End Get
        Set(ByVal value As String)
            mmsg_descri = value
        End Set
    End Property

    Public Property msg_codest() As String
        Get
            Return mmsg_codest
        End Get
        Set(ByVal value As String)
            mmsg_codest = value
        End Set
    End Property
End Class
