Public Class ELTBDETDOCEXPBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mT_DOC_REF1 As String
    Private mSER_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String
    Private mCTCT_COD As String
    Private mCANTIDAD As Double
    Private mSIGNO As String
    Private mTPRECIO_COMPRA As Double
    Private mTPRECIO_DCOMPRA As Double
    Private mIGV As Double
    Private mIGV_IMPOR As Double
    Private mART_COD As String
    'Private mT_CMB As Double
    Private mUPRECIO_COMPRA As Double
    Private mUPRECIO_DCOMPRA As Double
    Private mIGV_DIMPOR As Double
    Private mMONEDA As String
    Private mUSUARIO As String
    Private mPROVEEDOR As String
    Private mFEC_GENE As Date
    Private mCUENTA As String
    Private mCUENTA_DEST As String
    Private mSTATUS As String
    Private mUPRECIO_AFECTOS As Double
    Private mUPRECIO_AFECTOD As Double
    Private mIES_IMPOR As Double
    Private mIES_DIMPOR As Double
    Private mCTA_IMPOR As Double
    Private mCTA_DIMPOR As Double
    Private mIES As Double
    Private mCTA As Double
    Private mUNIDAD As String
    Private mDSCTO As Double
    Private mDSCTO_IMPOR As Double
    Private mDSCTO_DIMPOR As Double
    Private mF_PAGO_ENT As String
    Private mX_D As String
    Private mPESO As Double
    Private mT_CAMB As Double
    Private mFEC_DIA As Date
    Private mNDOC As String
    Private mSDOC As String
    Private mADVALOR As Double
    Private mCCO_COD As String

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

    Public Property CTCT_COD As String
        Get
            Return mCTCT_COD
        End Get
        Set(value As String)
            mCTCT_COD = value
        End Set
    End Property

    Public Property CANTIDAD As Double
        Get
            Return mCANTIDAD
        End Get
        Set(value As Double)
            mCANTIDAD = value
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

    Public Property TPRECIO_COMPRA As Double
        Get
            Return mTPRECIO_COMPRA
        End Get
        Set(value As Double)
            mTPRECIO_COMPRA = value
        End Set
    End Property

    Public Property TPRECIO_DCOMPRA As Double
        Get
            Return mTPRECIO_DCOMPRA
        End Get
        Set(value As Double)
            mTPRECIO_DCOMPRA = value
        End Set
    End Property

    Public Property IGV As Double
        Get
            Return mIGV
        End Get
        Set(value As Double)
            mIGV = value
        End Set
    End Property

    Public Property IGV_IMPOR As Double
        Get
            Return mIGV_IMPOR
        End Get
        Set(value As Double)
            mIGV_IMPOR = value
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

    'Public Property T_CMB As Double
    '    Get
    '        Return mT_CMB
    '    End Get
    '    Set(value As Double)
    '        mT_CMB = value
    '    End Set
    'End Property

    Public Property UPRECIO_COMPRA As Double
        Get
            Return mUPRECIO_COMPRA
        End Get
        Set(value As Double)
            mUPRECIO_COMPRA = value
        End Set
    End Property

    Public Property UPRECIO_DCOMPRA As Double
        Get
            Return mUPRECIO_DCOMPRA
        End Get
        Set(value As Double)
            mUPRECIO_DCOMPRA = value
        End Set
    End Property

    Public Property IGV_DIMPOR As Double
        Get
            Return mIGV_DIMPOR
        End Get
        Set(value As Double)
            mIGV_DIMPOR = value
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

    Public Property USUARIO As String
        Get
            Return mUSUARIO
        End Get
        Set(value As String)
            mUSUARIO = value
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

    Public Property STATUS As String
        Get
            Return mSTATUS
        End Get
        Set(value As String)
            mSTATUS = value
        End Set
    End Property

    Public Property UPRECIO_AFECTOS As Double
        Get
            Return mUPRECIO_AFECTOS
        End Get
        Set(value As Double)
            mUPRECIO_AFECTOS = value
        End Set
    End Property

    Public Property UPRECIO_AFECTOD As Double
        Get
            Return mUPRECIO_AFECTOD
        End Get
        Set(value As Double)
            mUPRECIO_AFECTOD = value
        End Set
    End Property

    Public Property IES_IMPOR As Double
        Get
            Return mIES_IMPOR
        End Get
        Set(value As Double)
            mIES_IMPOR = value
        End Set
    End Property

    Public Property IES_DIMPOR As Double
        Get
            Return mIES_DIMPOR
        End Get
        Set(value As Double)
            mIES_DIMPOR = value
        End Set
    End Property

    Public Property CTA_IMPOR As Double
        Get
            Return mCTA_IMPOR
        End Get
        Set(value As Double)
            mCTA_IMPOR = value
        End Set
    End Property

    Public Property CTA_DIMPOR As Double
        Get
            Return mCTA_DIMPOR
        End Get
        Set(value As Double)
            mCTA_DIMPOR = value
        End Set
    End Property

    Public Property IES As Double
        Get
            Return mIES
        End Get
        Set(value As Double)
            mIES = value
        End Set
    End Property

    Public Property CTA As Double
        Get
            Return mCTA
        End Get
        Set(value As Double)
            mCTA = value
        End Set
    End Property

    Public Property UNIDAD As String
        Get
            Return mUNIDAD
        End Get
        Set(value As String)
            mUNIDAD = value
        End Set
    End Property

    Public Property DSCTO As Double
        Get
            Return mDSCTO
        End Get
        Set(value As Double)
            mDSCTO = value
        End Set
    End Property

    Public Property DSCTO_IMPOR As Double
        Get
            Return mDSCTO_IMPOR
        End Get
        Set(value As Double)
            mDSCTO_IMPOR = value
        End Set
    End Property

    Public Property DSCTO_DIMPOR As Double
        Get
            Return mDSCTO_DIMPOR
        End Get
        Set(value As Double)
            mDSCTO_DIMPOR = value
        End Set
    End Property

    Public Property F_PAGO_ENT As String
        Get
            Return mF_PAGO_ENT
        End Get
        Set(value As String)
            mF_PAGO_ENT = value
        End Set
    End Property

    Public Property X_D As String
        Get
            Return mX_D
        End Get
        Set(value As String)
            mX_D = value
        End Set
    End Property

    Public Property PESO As Double
        Get
            Return mPESO
        End Get
        Set(value As Double)
            mPESO = value
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

    Public Property FEC_DIA As Date
        Get
            Return mFEC_DIA
        End Get
        Set(value As Date)
            mFEC_DIA = value
        End Set
    End Property

    Public Property NDOC As String
        Get
            Return mNDOC
        End Get
        Set(value As String)
            mNDOC = value
        End Set
    End Property

    Public Property SDOC As String
        Get
            Return mSDOC
        End Get
        Set(value As String)
            mSDOC = value
        End Set
    End Property

    Public Property ADVALOR As Double
        Get
            Return mADVALOR
        End Get
        Set(value As Double)
            mADVALOR = value
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
End Class
