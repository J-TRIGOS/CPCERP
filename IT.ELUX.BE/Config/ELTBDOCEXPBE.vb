Public Class ELTBDOCEXPBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mTPRECIO_COMPRA As Double
    Private mTPRECIO_DCOMPRA As Double
    Private mT_OPE As String
    Private mART_COD As String
    Private mFEC_PROV As Date
    Private mFEC_GENE As Date
    Private mEST As String
    Private mPROVEEDOR As String
    Private mOBSERVA As String
    Private mF_PAGO_ENT As String
    Private mTIPO1 As String
    Private mNRO_PERCEPCION As String
    Private mTIPO2 As String
    Private mT_CAMB As Double
    Private mMONEDA As String
    Private mEST1 As String
    Private mX_RET As String
    Private mDETRACCION As String
    Private mFEC_DET As Date
    Private mLETRA As String
    Private mFEC_LETRA As Date
    Private mT_IGV As Double
    Private mT_IGV_DOLAR As Double
    Private mTIPO As String
    Private mSIGNO As String
    Private mT_DCTO As Double
    Private mT_DCTO_DOLAR As Double
    Private mUSUARIO As String
    Private mREG_NRO As String
    Private mMONTO_PAGADO As Double
    Private mPROGRAMA As String
    Private mPORCENTAJE As Double
    Private mFARDO As String
    Private mCTA_CBCO As String
    Private mT_IES As Double
    Private mT_DIES As Double
    Private mT_CTA As Double
    Private mT_DCTA As Double
    Private mTAFECTO As Double
    Private mTAFECTOD As Double
    Private mTDOC As String
    Private mSDOC As String
    Private mNDOC As String
    Private mP As String
    Private mT_CMP As String
    Private mS_CMP As String
    Private mN_CMP As String
    Private mANO_CMP As Integer
    Private mPAIS As String
    Private mT_CONV As String
    Private mT_RENTA As String
    Private mEST_OPORT As String
    Private mFEC_VENSBS As Date
    Private mADVALORE As Double
    Private mTIPO7 As String
    Private mEST_MERCADERIA As String

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

    Public Property T_OPE As String
        Get
            Return mT_OPE
        End Get
        Set(value As String)
            mT_OPE = value
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

    Public Property FEC_PROV As Date
        Get
            Return mFEC_PROV
        End Get
        Set(value As Date)
            mFEC_PROV = value
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

    Public Property PROVEEDOR As String
        Get
            Return mPROVEEDOR
        End Get
        Set(value As String)
            mPROVEEDOR = value
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

    Public Property F_PAGO_ENT As String
        Get
            Return mF_PAGO_ENT
        End Get
        Set(value As String)
            mF_PAGO_ENT = value
        End Set
    End Property

    Public Property TIPO1 As String
        Get
            Return mTIPO1
        End Get
        Set(value As String)
            mTIPO1 = value
        End Set
    End Property

    Public Property NRO_PERCEPCION As String
        Get
            Return mNRO_PERCEPCION
        End Get
        Set(value As String)
            mNRO_PERCEPCION = value
        End Set
    End Property

    Public Property TIPO2 As String
        Get
            Return mTIPO2
        End Get
        Set(value As String)
            mTIPO2 = value
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

    Public Property MONEDA As String
        Get
            Return mMONEDA
        End Get
        Set(value As String)
            mMONEDA = value
        End Set
    End Property

    Public Property EST1 As String
        Get
            Return mEST1
        End Get
        Set(value As String)
            mEST1 = value
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

    Public Property DETRACCION As String
        Get
            Return mDETRACCION
        End Get
        Set(value As String)
            mDETRACCION = value
        End Set
    End Property

    Public Property FEC_DET As Date
        Get
            Return mFEC_DET
        End Get
        Set(value As Date)
            mFEC_DET = value
        End Set
    End Property

    Public Property LETRA As String
        Get
            Return mLETRA
        End Get
        Set(value As String)
            mLETRA = value
        End Set
    End Property

    Public Property FEC_LETRA As Date
        Get
            Return mFEC_LETRA
        End Get
        Set(value As Date)
            mFEC_LETRA = value
        End Set
    End Property

    Public Property T_IGV As Double
        Get
            Return mT_IGV
        End Get
        Set(value As Double)
            mT_IGV = value
        End Set
    End Property

    Public Property T_IGV_DOLAR As Double
        Get
            Return mT_IGV_DOLAR
        End Get
        Set(value As Double)
            mT_IGV_DOLAR = value
        End Set
    End Property

    Public Property TIPO As String
        Get
            Return mTIPO
        End Get
        Set(value As String)
            mTIPO = value
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

    Public Property T_DCTO As Double
        Get
            Return mT_DCTO
        End Get
        Set(value As Double)
            mT_DCTO = value
        End Set
    End Property

    Public Property T_DCTO_DOLAR As Double
        Get
            Return mT_DCTO_DOLAR
        End Get
        Set(value As Double)
            mT_DCTO_DOLAR = value
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

    Public Property REG_NRO As String
        Get
            Return mREG_NRO
        End Get
        Set(value As String)
            mREG_NRO = value
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

    Public Property PROGRAMA As String
        Get
            Return mPROGRAMA
        End Get
        Set(value As String)
            mPROGRAMA = value
        End Set
    End Property

    Public Property PORCENTAJE As Double
        Get
            Return mPORCENTAJE
        End Get
        Set(value As Double)
            mPORCENTAJE = value
        End Set
    End Property

    Public Property FARDO As String
        Get
            Return mFARDO
        End Get
        Set(value As String)
            mFARDO = value
        End Set
    End Property

    Public Property CTA_CBCO As String
        Get
            Return mCTA_CBCO
        End Get
        Set(value As String)
            mCTA_CBCO = value
        End Set
    End Property

    Public Property T_IES As Double
        Get
            Return mT_IES
        End Get
        Set(value As Double)
            mT_IES = value
        End Set
    End Property

    Public Property T_DIES As Double
        Get
            Return mT_DIES
        End Get
        Set(value As Double)
            mT_DIES = value
        End Set
    End Property

    Public Property T_CTA As Double
        Get
            Return mT_CTA
        End Get
        Set(value As Double)
            mT_CTA = value
        End Set
    End Property

    Public Property T_DCTA As Double
        Get
            Return mT_DCTA
        End Get
        Set(value As Double)
            mT_DCTA = value
        End Set
    End Property

    Public Property TAFECTO As Double
        Get
            Return mTAFECTO
        End Get
        Set(value As Double)
            mTAFECTO = value
        End Set
    End Property

    Public Property TAFECTOD As Double
        Get
            Return mTAFECTOD
        End Get
        Set(value As Double)
            mTAFECTOD = value
        End Set
    End Property

    Public Property TDOC As String
        Get
            Return mTDOC
        End Get
        Set(value As String)
            mTDOC = value
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

    Public Property NDOC As String
        Get
            Return mNDOC
        End Get
        Set(value As String)
            mNDOC = value
        End Set
    End Property

    Public Property P As String
        Get
            Return mP
        End Get
        Set(value As String)
            mP = value
        End Set
    End Property

    Public Property T_CMP As String
        Get
            Return mT_CMP
        End Get
        Set(value As String)
            mT_CMP = value
        End Set
    End Property

    Public Property S_CMP As String
        Get
            Return mS_CMP
        End Get
        Set(value As String)
            mS_CMP = value
        End Set
    End Property

    Public Property N_CMP As String
        Get
            Return mN_CMP
        End Get
        Set(value As String)
            mN_CMP = value
        End Set
    End Property

    Public Property ANO_CMP As Integer
        Get
            Return mANO_CMP
        End Get
        Set(value As Integer)
            mANO_CMP = value
        End Set
    End Property

    Public Property PAIS As String
        Get
            Return mPAIS
        End Get
        Set(value As String)
            mPAIS = value
        End Set
    End Property

    Public Property T_CONV As String
        Get
            Return mT_CONV
        End Get
        Set(value As String)
            mT_CONV = value
        End Set
    End Property

    Public Property T_RENTA As String
        Get
            Return mT_RENTA
        End Get
        Set(value As String)
            mT_RENTA = value
        End Set
    End Property

    Public Property EST_OPORT As String
        Get
            Return mEST_OPORT
        End Get
        Set(value As String)
            mEST_OPORT = value
        End Set
    End Property

    Public Property FEC_VENSBS As Date
        Get
            Return mFEC_VENSBS
        End Get
        Set(value As Date)
            mFEC_VENSBS = value
        End Set
    End Property

    Public Property ADVALORE As Double
        Get
            Return mADVALORE
        End Get
        Set(value As Double)
            mADVALORE = value
        End Set
    End Property
End Class
