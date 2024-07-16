Public Class ELTBRECCBE
    'Campos de la entidad
    Private mrcc_codcat As String
    Private mrcc_codcar As String


    'Propiedades de la entidad
    Public Property rcc_codcat() As String
        Get
            Return mrcc_codcat
        End Get
        Set(ByVal value As String)
            mrcc_codcat = value
        End Set
    End Property

    Public Property rcc_codcar() As String
        Get
            Return mrcc_codcar
        End Get
        Set(ByVal value As String)
            mrcc_codcar = value
        End Set
    End Property

End Class
