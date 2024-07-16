Public Class ELTBPRESTAMOPERBE
    Private mPER_COD As String
    Private mT_PRESTAMO As String
    Private mMONTO As Double
    Private mCUOTAS As Integer
    Private mFEC_GENE As Date
    Private mEST As String
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String

    Public Property PER_COD As String
        Get
            Return mPER_COD
        End Get
        Set(value As String)
            mPER_COD = value
        End Set
    End Property

    Public Property T_PRESTAMO As String
        Get
            Return mT_PRESTAMO
        End Get
        Set(value As String)
            mT_PRESTAMO = value
        End Set
    End Property

    Public Property MONTO As Double
        Get
            Return mMONTO
        End Get
        Set(value As Double)
            mMONTO = value
        End Set
    End Property

    Public Property CUOTAS As Integer
        Get
            Return mCUOTAS
        End Get
        Set(value As Integer)
            mCUOTAS = value
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

    Public Property EST As String
        Get
            Return mEST
        End Get
        Set(value As String)
            mEST = value
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
End Class
