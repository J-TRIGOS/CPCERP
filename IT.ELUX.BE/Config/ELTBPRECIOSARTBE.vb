Public Class ELTBPRECIOSARTBE
    Private mART_COD As String
    Private mPRECIO_SOLES As String
    Private mFEC_GENE As Date
    Private mCTCTCOD As String
    Private mMONEDA As String
    Private mPRECIO_DOLARES As Double
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mEST As String
    Private mPROVEEDOR As String

    Public Property ART_COD As String
        Get
            Return mART_COD
        End Get
        Set(value As String)
            mART_COD = value
        End Set
    End Property

    Public Property PRECIO_SOLES As String
        Get
            Return mPRECIO_SOLES
        End Get
        Set(value As String)
            mPRECIO_SOLES = value
        End Set
    End Property

    Public Property FEC_GENE As Date
        Get
            Return mFEC_GENE
        End Get
        Set(value As Date)
            mFEC_GENE = value
        End Set
    End Property

    Public Property CTCTCOD As String
        Get
            Return mCTCTCOD
        End Get
        Set(value As String)
            mCTCTCOD = value
        End Set
    End Property

    Public Property MONEDA As String
        Get
            Return mMONEDA
        End Get
        Set(value As String)
            mMONEDA = value
        End Set
    End Property

    Public Property PRECIO_DOLARES As Double
        Get
            Return mPRECIO_DOLARES
        End Get
        Set(value As Double)
            mPRECIO_DOLARES = value
        End Set
    End Property

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

    Public Property EST As String
        Get
            Return mEST
        End Get
        Set(value As String)
            mEST = value
        End Set
    End Property

    Public Property PROVEEDOR As String
        Get
            Return mPROVEEDOR
        End Get
        Set(value As String)
            mPROVEEDOR = value
        End Set
    End Property
End Class
