Public Class ELTBPERCEPBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mFEC_PERC As Date
    Private mMONPERC As Double
    Private mCTCT_COD As String
    Private mNOMCTCT As String
    Private mNDOCU As String
    Private mMES As String
    Private mANHO As String
    Private mTAZA As Double

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

    Public Property FEC_PERC As Date
        Get
            Return mFEC_PERC
        End Get
        Set(value As Date)
            mFEC_PERC = value
        End Set
    End Property

    Public Property MONPERC As Double
        Get
            Return mMONPERC
        End Get
        Set(value As Double)
            mMONPERC = value
        End Set
    End Property

    Public Property CTCT_COD As String
        Get
            Return mCTCT_COD
        End Get
        Set(value As String)
            mCTCT_COD = value
        End Set
    End Property

    Public Property NOMCTCT As String
        Get
            Return mNOMCTCT
        End Get
        Set(value As String)
            mNOMCTCT = value
        End Set
    End Property

    Public Property NDOCU As String
        Get
            Return mNDOCU
        End Get
        Set(value As String)
            mNDOCU = value
        End Set
    End Property

    Public Property MES As String
        Get
            Return mMES
        End Get
        Set(value As String)
            mMES = value
        End Set
    End Property

    Public Property ANHO As String
        Get
            Return mANHO
        End Get
        Set(value As String)
            mANHO = value
        End Set
    End Property

    Public Property TAZA As Double
        Get
            Return mTAZA
        End Get
        Set(value As Double)
            mTAZA = value
        End Set
    End Property
End Class
