Public Class ELTBCARGOBE
    Private mCARGO_COD As String
    Private mCARGO_DESCRI As String

    Public Property CARGO_COD As String
        Get
            Return mCARGO_COD
        End Get
        Set(value As String)
            mCARGO_COD = value
        End Set
    End Property

    Public Property CARGO_DESCRI As String
        Get
            Return mCARGO_DESCRI
        End Get
        Set(value As String)
            mCARGO_DESCRI = value
        End Set
    End Property
End Class
