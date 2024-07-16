Public Class DET_LIBRO_DIARIOBE

    Private mT_REGISTRO As String
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mT_DOC_REF1 As String
    Private mSER_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String
    Private mSTATUS As String
    Private mCCO_COD As String
    Private mCUENTA As String
    Private mCUENTA_DEST As String
    Private mSIGNO As String
    Private mFEC_GENE As String
    Private mT_CAMB As Decimal
    Private mTPRECIO_COMPRA As Decimal
    Private mTPRECIO_DCOMPRA As Decimal
    Private mMONEDA As String
    Private mNRO_DOCU1 As String
    Private mOBSERVA As String
    Private mCTCT_COD As String
    Private mPROVEEDOR As String
    Private mX_RET As String
    Private mREG_NRO As String
    Private mRETEN As String
    Private mT_OPE_COD As String
    Private mNUEVO As String
    Private mCUENTITA As String
    Private mI As Int16
    Private mREPARAR As String
    Private mCODART As String
    Private mPROV_PAGO As String
    Private mFEC_VENC As String

    Public Property PROV_PAGO As String
        Get
            Return mPROV_PAGO
        End Get
        Set(value As String)
            mPROV_PAGO = value
        End Set
    End Property

    Public Property FEC_VENC As String
        Get
            Return mFEC_VENC
        End Get
        Set(value As String)
            mFEC_VENC = value
        End Set
    End Property

    Public Property CODART As String
        Get
            Return mCODART
        End Get
        Set(value As String)
            mCODART = value
        End Set
    End Property

    Public Property T_REGISTRO As String
        Get
            Return mT_REGISTRO
        End Get
        Set(value As String)
            mT_REGISTRO = value
        End Set
    End Property
    Public Property REPARAR As String
        Get
            Return mREPARAR
        End Get
        Set(value As String)
            mREPARAR = value
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
            Return MSER_DOC_REF
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

    Public Property STATUS As String
        Get
            Return mSTATUS
        End Get
        Set(value As String)
            mSTATUS = value
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

    Public Property SIGNO As String
        Get
            Return mSIGNO
        End Get
        Set(value As String)
            mSIGNO = value
        End Set
    End Property

    Public Property FEC_GENE As String
        Get
            Return mFEC_GENE
        End Get
        Set(value As String)
            mFEC_GENE = value
        End Set
    End Property

    Public Property T_CAMB As Decimal
        Get
            Return mT_CAMB
        End Get
        Set(value As Decimal)
            mT_CAMB = value
        End Set
    End Property

    Public Property TPRECIO_COMPRA As Decimal
        Get
            Return mTPRECIO_COMPRA
        End Get
        Set(value As Decimal)
            mTPRECIO_COMPRA = value
        End Set
    End Property

    Public Property TPRECIO_DCOMPRA As Decimal
        Get
            Return mTPRECIO_DCOMPRA
        End Get
        Set(value As Decimal)
            mTPRECIO_DCOMPRA = value
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

    Public Property NRO_DOCU1 As String
        Get
            Return mNRO_DOCU1
        End Get
        Set(value As String)
            mNRO_DOCU1 = value
        End Set
    End Property

    Public Property OBSERVA As String
        Get
            Return mOBSERVA
        End Get
        Set(value As String)
            mOBSERVA = value
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

    Public Property PROVEEDOR As String
        Get
            Return mPROVEEDOR
        End Get
        Set(value As String)
            mPROVEEDOR = value
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

    Public Property REG_NRO As String
        Get
            Return mREG_NRO
        End Get
        Set(value As String)
            mREG_NRO = value
        End Set
    End Property

    Public Property RETEN As String
        Get
            Return mRETEN
        End Get
        Set(value As String)
            mRETEN = value
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

    Public Property NUEVO As String
        Get
            Return mNUEVO
        End Get
        Set(value As String)
            mNUEVO = value
        End Set
    End Property

    Public Property CUENTITA As String
        Get
            Return mCUENTITA
        End Get
        Set(value As String)
            mCUENTITA = value
        End Set
    End Property

    Public Property I As String
        Get
            Return mI
        End Get
        Set(value As String)
            mI = value
        End Set
    End Property
End Class
