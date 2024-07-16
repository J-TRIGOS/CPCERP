Public Class ELTBCARA_VALBE
    Private mval_codcar As String
    Private mval_codval As String

    'Propiedades de la entidad
    Public Property val_codcar() As String
        Get
            Return mval_codcar
        End Get
        Set(ByVal value As String)
            mval_codcar = value
        End Set
    End Property

    Public Property val_codval() As String
        Get
            Return mval_codval
        End Get
        Set(ByVal value As String)
            mval_codval = value
        End Set
    End Property
End Class
