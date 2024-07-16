Public Class ELTBLINESBE

    'Campos de la entidad
    Private mlin_codigo As String
    Private mlin_descri As String
    Private mlin_codest As String

    'Propiedades de la entidad
    Public Property lin_codigo() As String
        Get
            Return mlin_codigo
        End Get
        Set(ByVal value As String)
            mlin_codigo = value
        End Set
    End Property

    Public Property lin_descri() As String
        Get
            Return mlin_descri
        End Get
        Set(ByVal value As String)
            mlin_descri = value
        End Set
    End Property

    Public Property lin_codest() As String
        Get
            Return mlin_codest
        End Get
        Set(ByVal value As String)
            mlin_codest = value
        End Set
    End Property
End Class
