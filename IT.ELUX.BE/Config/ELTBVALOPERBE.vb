Public Class ELTBVALOPERBE
    'Campos de la entidad
    Private mval_codoper As String
    Private mval_codval As String

    'Propiedades de la entidad
    Public Property val_codoper() As String
        Get
            Return mval_codoper
        End Get
        Set(ByVal value As String)
            mval_codoper = value
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
