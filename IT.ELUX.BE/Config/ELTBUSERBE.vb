Public Class ELTBUSERBE

    'Campos de la entidad
    Private musu_codigo As String
    Private musu_descri As String
    Private musu_passwd As String
    Private musu_codest As String

    'Propiedades de la entidad
    Public Property usu_codigo() As String
        Get
            Return musu_codigo
        End Get
        Set(ByVal value As String)
            musu_codigo = value
        End Set
    End Property

    Public Property usu_descri() As String
        Get
            Return musu_descri
        End Get
        Set(ByVal value As String)
            musu_descri = value
        End Set
    End Property

    Public Property usu_passwd() As String
        Get
            Return musu_passwd
        End Get
        Set(ByVal value As String)
            musu_passwd = value
        End Set
    End Property

    Public Property usu_codest() As String
        Get
            Return musu_codest
        End Get
        Set(ByVal value As String)
            musu_codest = value
        End Set
    End Property

End Class
