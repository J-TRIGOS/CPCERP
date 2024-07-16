Public Class ELTBDETDETRACCIONBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mT_DOC_REF1 As String
    Private mSER_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String
    Private mPROVEEDOR As String
    Private mFEC_GENE As Date
    Private mMONTO_PAGADO As Double
    Private mPORC As Double
    Private mT_OPE As String
    Private mSERV As String
    Private mCUENTA As String
    Private mTOTAL As Double

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

    Public Property T_DOC_REF1 As String
        Get
            Return mT_DOC_REF1
        End Get
        Set(value As String)
            mT_DOC_REF1 = value
        End Set
    End Property

    Public Property SER_DOC_REF1 As String
        Get
            Return mSER_DOC_REF1
        End Get
        Set(value As String)
            mSER_DOC_REF1 = value
        End Set
    End Property

    Public Property NRO_DOC_REF1 As String
        Get
            Return mNRO_DOC_REF1
        End Get
        Set(value As String)
            mNRO_DOC_REF1 = value
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

    Public Property FEC_GENE As Date
        Get
            Return mFEC_GENE
        End Get
        Set(value As Date)
            mFEC_GENE = value
        End Set
    End Property

    Public Property MONTO_PAGADO As Double
        Get
            Return mMONTO_PAGADO
        End Get
        Set(value As Double)
            mMONTO_PAGADO = value
        End Set
    End Property

    Public Property PORC As Double
        Get
            Return mPORC
        End Get
        Set(value As Double)
            mPORC = value
        End Set
    End Property

    Public Property T_OPE As String
        Get
            Return mT_OPE
        End Get
        Set(value As String)
            mT_OPE = value
        End Set
    End Property

    Public Property SERV As String
        Get
            Return mSERV
        End Get
        Set(value As String)
            mSERV = value
        End Set
    End Property

    Public Property CUENTA As String
        Get
            Return mCUENTA
        End Get
        Set(value As String)
            mCUENTA = value
        End Set
    End Property

    Public Property TOTAL As Double
        Get
            Return mTOTAL
        End Get
        Set(value As Double)
            mTOTAL = value
        End Set
    End Property
End Class
