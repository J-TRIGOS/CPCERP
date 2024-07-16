Public Class REPORTE_TRABAJOBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mEST As String
    Private mFEC_GENE As Date
    Private mFEC_DIA As Date
    Private mPER_COD As String
    Private mCCO_COD As String
    Private mlINEA As String
    Private mTURNO As String
    Private mUSUARIO_RP As String
    Private mUSUARIO_VB As String


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

    Public Property FEC_GENE As Date
        Get
            Return mFEC_GENE
        End Get
        Set(value As Date)
            mFEC_GENE = value
        End Set
    End Property

    Public Property PER_COD As String
        Get
            Return mPER_COD
        End Get
        Set(value As String)
            mPER_COD = value
        End Set
    End Property

    Public Property CCO_COD As String
        Get
            Return mCCO_COD
        End Get
        Set(value As String)
            mCCO_COD = value
        End Set
    End Property

    Public Property lINEA As String
        Get
            Return mlINEA
        End Get
        Set(value As String)
            mlINEA = value
        End Set
    End Property

    Public Property TURNO As String
        Get
            Return mTURNO
        End Get
        Set(value As String)
            mTURNO = value
        End Set
    End Property

    Public Property FEC_DIA As Date
        Get
            Return mFEC_DIA
        End Get
        Set(value As Date)
            mFEC_DIA = value
        End Set
    End Property

    Public Property USUARIO_RP As String
        Get
            Return mUSUARIO_RP
        End Get
        Set(value As String)
            mUSUARIO_RP = value
        End Set
    End Property

    Public Property USUARIO_VB As String
        Get
            Return mUSUARIO_VB
        End Get
        Set(value As String)
            mUSUARIO_VB = value
        End Set
    End Property
End Class
