Public Class ELTBACTUALIZAR_DATOSBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mART_COD As String
    Private mSER_ORDEN As String
    Private mNRO_ORDEN As String

    Public Property T_DOC_REF As String
        Get
            Return mT_DOC_REF
        End Get
        Set(value As String)
            mT_DOC_REF = value
        End Set
    End Property

    Public Property SER_DOC_REF As String
        Get
            Return mSER_DOC_REF
        End Get
        Set(value As String)
            mSER_DOC_REF = value
        End Set
    End Property

    Public Property NRO_DOC_REF As String
        Get
            Return mNRO_DOC_REF
        End Get
        Set(value As String)
            mNRO_DOC_REF = value
        End Set
    End Property

    Public Property ART_COD As String
        Get
            Return mART_COD
        End Get
        Set(value As String)
            mART_COD = value
        End Set
    End Property

    Public Property SER_ORDEN As String
        Get
            Return mSER_ORDEN
        End Get
        Set(value As String)
            mSER_ORDEN = value
        End Set
    End Property

    Public Property NRO_ORDEN As String
        Get
            Return mNRO_ORDEN
        End Get
        Set(value As String)
            mNRO_ORDEN = value
        End Set
    End Property
End Class
