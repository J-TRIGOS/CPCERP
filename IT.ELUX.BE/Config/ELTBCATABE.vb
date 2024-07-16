Public Class ELTBCATABE
    'Campos de la entidad
    Private mcat_codigo As String
    Private mcat_descri As String
    Private mcat_codest As String

    'Propiedades de la entidad
    Public Property cat_codigo() As String
        Get
            Return mcat_codigo
        End Get
        Set(ByVal value As String)
            mcat_codigo = value
        End Set
    End Property

    Public Property cat_descri() As String
        Get
            Return mcat_descri
        End Get
        Set(ByVal value As String)
            mcat_descri = value
        End Set
    End Property

    Public Property cat_codest() As String
        Get
            Return mcat_codest
        End Get
        Set(ByVal value As String)
            mcat_codest = value
        End Set
    End Property
End Class
