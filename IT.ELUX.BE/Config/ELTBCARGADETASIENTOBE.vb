Public Class ELTBCARGADETASIENTOBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mT_DOC_REF1 As String
    Private mSER_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String
    Private mFEC_GEN As Date
    Private mCUENTA As String
    Private mCUENTA_DEST As String
    Private mTPRECIO_COMPRA As Double
    Private mMONEDA As String
    Private mSIGNO As String
    Private mT_CAMB As Double
    Private mTDPRECIO_COMPRA As Double
    Private mPROVEEDOR As String
    Private mCTCT_COD As String
    Private mART_COD As String
    Private mX_RET As String
    Private mSTATUS As String
    Private mCCO_COD As String
    Private mUSUARIO As String
    Private mID As String
    Private mUSUACTU As String
    'MOV_CT
    Private mANHO As String
    Private mMES As String
    Private mT_OPE_COD As String
    Private mREG_NRO As String
    Private mSEQ As String
    Private mCTA_COD As String
    Private mFEC As Date
    Private mSERIE_NRO As String
    Private mT_DOC_COD As String
    Private mMON_COD As String
    Private mCOMP_CPTO As String
    Private mPROG_FEC As Date
    Private mCOMP_NRO As String
    Private mIMPOR As Double
    Private mIMPOR_ME As Double
    Private mCOMP_FEC As Date
    Private mRUC As String
    Private mT_CMB As Double
    Private mFEC_ENT As Date
    Private mTIPO7 As String
    Private mEST_MERCADERIA As String

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

    Public Property FEC_GEN As Date
        Get
            Return mFEC_GEN
        End Get
        Set(value As Date)
            mFEC_GEN = value
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

    Public Property CUENTA_DEST As String
        Get
            Return mCUENTA_DEST
        End Get
        Set(value As String)
            mCUENTA_DEST = value
        End Set
    End Property

    Public Property TPRECIO_COMPRA As Double
        Get
            Return mTPRECIO_COMPRA
        End Get
        Set(value As Double)
            mTPRECIO_COMPRA = value
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

    Public Property SIGNO As String
        Get
            Return mSIGNO
        End Get
        Set(value As String)
            mSIGNO = value
        End Set
    End Property

    Public Property T_CAMB As Double
        Get
            Return mT_CAMB
        End Get
        Set(value As Double)
            mT_CAMB = value
        End Set
    End Property

    Public Property TDPRECIO_COMPRA As Double
        Get
            Return mTDPRECIO_COMPRA
        End Get
        Set(value As Double)
            mTDPRECIO_COMPRA = value
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

    Public Property ART_COD As String
        Get
            Return mART_COD
        End Get
        Set(value As String)
            mART_COD = value
        End Set
    End Property

    Public Property X_RET As String
        Get
            Return mX_RET
        End Get
        Set(value As String)
            mX_RET = value
        End Set
    End Property

    Public Property STATUS As String
        Get
            Return mSTATUS
        End Get
        Set(value As String)
            mSTATUS = value
        End Set
    End Property

    Public Property USUARIO As String
        Get
            Return mUSUARIO
        End Get
        Set(value As String)
            mUSUARIO = value
        End Set
    End Property

    Public Property ID As String
        Get
            Return mID
        End Get
        Set(value As String)
            [mID] = value
        End Set
    End Property

    Public Property USUACTU As String
        Get
            Return mUSUACTU
        End Get
        Set(value As String)
            mUSUACTU = value
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

    Public Property CTCT_COD As String
        Get
            Return mCTCT_COD
        End Get
        Set(value As String)
            mCTCT_COD = value
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

    Public Property MES As String
        Get
            Return mMES
        End Get
        Set(value As String)
            mMES = value
        End Set
    End Property

    Public Property T_OPE_COD As String
        Get
            Return mT_OPE_COD
        End Get
        Set(value As String)
            mT_OPE_COD = value
        End Set
    End Property

    Public Property REG_NRO As String
        Get
            Return mREG_NRO
        End Get
        Set(value As String)
            mREG_NRO = value
        End Set
    End Property

    Public Property SEQ As String
        Get
            Return mSEQ
        End Get
        Set(value As String)
            mSEQ = value
        End Set
    End Property

    Public Property CTA_COD As String
        Get
            Return mCTA_COD
        End Get
        Set(value As String)
            mCTA_COD = value
        End Set
    End Property

    Public Property FEC As Date
        Get
            Return mFEC
        End Get
        Set(value As Date)
            mFEC = value
        End Set
    End Property

    Public Property SERIE_NRO As String
        Get
            Return mSERIE_NRO
        End Get
        Set(value As String)
            mSERIE_NRO = value
        End Set
    End Property

    Public Property T_DOC_COD As String
        Get
            Return mT_DOC_COD
        End Get
        Set(value As String)
            mT_DOC_COD = value
        End Set
    End Property

    Public Property MON_COD As String
        Get
            Return mMON_COD
        End Get
        Set(value As String)
            mMON_COD = value
        End Set
    End Property

    Public Property COMP_CPTO As String
        Get
            Return mCOMP_CPTO
        End Get
        Set(value As String)
            mCOMP_CPTO = value
        End Set
    End Property

    Public Property PROG_FEC As Date
        Get
            Return mPROG_FEC
        End Get
        Set(value As Date)
            mPROG_FEC = value
        End Set
    End Property

    Public Property COMP_NRO As String
        Get
            Return mCOMP_NRO
        End Get
        Set(value As String)
            mCOMP_NRO = value
        End Set
    End Property

    Public Property IMPOR As Double
        Get
            Return mIMPOR
        End Get
        Set(value As Double)
            mIMPOR = value
        End Set
    End Property

    Public Property IMPOR_ME As Double
        Get
            Return mIMPOR_ME
        End Get
        Set(value As Double)
            mIMPOR_ME = value
        End Set
    End Property

    Public Property COMP_FEC As Date
        Get
            Return mCOMP_FEC
        End Get
        Set(value As Date)
            mCOMP_FEC = value
        End Set
    End Property

    Public Property RUC As String
        Get
            Return mRUC
        End Get
        Set(value As String)
            mRUC = value
        End Set
    End Property

    Public Property T_CMB As Double
        Get
            Return mT_CMB
        End Get
        Set(value As Double)
            mT_CMB = value
        End Set
    End Property

    Public Property FEC_ENT As Date
        Get
            Return mFEC_ENT
        End Get
        Set(value As Date)
            mFEC_ENT = value
        End Set
    End Property

    Public Property TIPO7 As String
        Get
            Return mTIPO7
        End Get
        Set(value As String)
            mTIPO7 = value
        End Set
    End Property

    Public Property EST_MERCADERIA As String
        Get
            Return mEST_MERCADERIA
        End Get
        Set(value As String)
            mEST_MERCADERIA = value
        End Set
    End Property
End Class
