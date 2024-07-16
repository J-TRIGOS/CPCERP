Public Class DET_DOCUMENTOBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mT_DOC_REF1 As String
    Private mSER_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String
    Private mCTCT_COD As String
    Private mALM_COD As String
    Private mFEC_ENT As Date
    Private mFEC_LLEG As Date
    Private mFEC_DOC As Date
    Private mCANTIDAD As Double
    Private mEST As String
    Private mTRANSP_COD As String
    Private mREPROVEEDOR As String
    Private mRETRANSPORTISTA As String
    Private mCHOFER As String
    Private mCERTIFICADO As String
    Private mCERTIFICADO1 As String
    Private mBREVETE As String
    Private mMARCA As String
    Private mMARCA1 As String
    Private mPLACA1 As String
    Private mPLACA As String
    Private mCOLOR As String
    Private mTIPO_UNIDAD As String
    Private mCONFIGURACION As String
    Private mCOMENTARIO As String
    Private mCTCT_DIR As String
    Private mINTERES As Double
    Private mCOSTO_MINIMO As Double
    Private mPESO As Double
    Private mSIGNO As String
    Private mDSCTO_IMPOR As Double
    Private mOBSERVA As String
    Private mT_MOVINV As String
    Private mTPRECIO_COMPRA As Double
    Private mTPRECIO_VENTA As Double
    Private mTPRECIO_DCOMPRA As Double
    Private mTPRECIO_DVENTA As Double
    Private mIGV As Double
    Private mIGV_IMPOR As Double
    Private mDSCTO As Double
    Private mART_COD As String
    Private mFLETE As Double
    Private mT_CAMB As Double
    Private mUPRECIO_COMPRA As Double
    Private mUPRECIO_VENTA As Double
    Private mUPRECIO_DCOMPRA As Double
    Private mUPRECIO_DVENTA As Double
    Private mIGV_DIMPOR As Double
    Private mDSCTO_DIMPOR As Double
    Private mBAR_COD As String
    Private mDIR_COD As String
    Private mALM_COD_LLEG As String
    Private mMONEDA As String
    Private mUNIDAD As String
    Private mFEC_GENE As Date
    Private mT_IGV As Double
    Private mT_IGV_DOLAR As Double
    Private mUSUARIO As String
    Private mFLA_KARDEX As String
    Private mMOT_COD As String
    Private mF_PAGO_ENT As String
    Private mFOR_ENT_COD As String
    Private mFEC_DIA As Date
    Private mT_DCTO As Double
    Private mT_DCTO_DOLAR As Double
    Private mSALDO As Double
    Private mFEC_ANU As Date
    Private mX_CONT As String
    Private mREG_NRO As String
    Private mPROVEEDOR As String
    Private mDIR_PROV As String
    Private mPROV_DIR As String
    Private mCUENTA As String
    Private mCUENTA_DEST As String
    Private mSUGERENCIA As String
    Private mSTATUS As String
    Private mUPRECIO_AFECTOS As Double
    Private mUPRECIO_AFECTOD As Double
    Private mCCO_COD As String
    Private mIES_IMPOR As Double
    Private mIES_DIMPOR As Double
    Private mCTA_IMPOR As Double
    Private mCTA_DIMPOR As Double
    Private mIES As Double
    Private mCTA As Double
    Private mOTROS As String
    Private mX_RET As String
    Private mT_OPE_COD As String
    Private mCLA As String
    Private mRETEN As String
    Private mNUEVO As String
    Private mCUENTITA As String
    Private mCANTIDAD1 As Double
    Private mART_COD1 As String
    Private mUNIDAD1 As String
    Private mCARTAVIO As Double
    Private mX_BONIF As Double
    Private mLOTE As String
    Private mLICENCIA As String
    Private mACT_COD As String
    Private mART_VENTA As String
    Private mCOD_COLOR As String
    Private mCOD_MEDIDA As String
    Private mCOD_MARCA As String
    Private mPART_ACT As String
    Private mFEC_ENT1 As Date
    Private mFEC_ENT2 As Date
    Private mFEC_ENT3 As Date
    Private mFEC_ENT4 As Date
    Private mFEC_ENT5 As Date
    Private mCANTIDAD2 As Double
    Private mCANTIDAD3 As Double
    Private mCANTIDAD4 As Double
    Private mCANTIDAD5 As Double
    Private mTOTAL As Double
    Private mPER_COD As String
    Private mNRO_DOCU1 As String
    Private mNRO_DOCU2 As String
    Private mHORA_INI As Date
    Private mHORA_FIN As Date
    Private mFEC_VENCIMIENTO As Date
    Private mPER_COD1 As String
    Private mPER_COD2 As String
    Private mOBSERVA1 As String
    Private mPROCESO As String
    Private mMEDIDA As String
    Private mEST_VENTAS As String
    Private mALMAC As String
    Private mACT_COD1 As String
    Private mACT_COD2 As String
    Private mX_M As String
    Private mX_N As String
    Private mX_D As String
    Private mSERIE_SOLI As String
    Private mTEMPLE As String
    Private mTRATAMIENTO As String
    Private mREQ As String
    Private mT_ENVASE As Double
    Private mT_ENVASEP As Double
    Private mFEC_ENT6 As Date
    Private mREQ_APROB As String
    Private mNOM_CTCT As String
    Private mPERCEPCION As String
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

    Public Property ALM_COD As String
        Get
            Return mALM_COD
        End Get
        Set(value As String)
            mALM_COD = value
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

    Public Property FEC_LLEG As Date
        Get
            Return mFEC_LLEG
        End Get
        Set(value As Date)
            mFEC_LLEG = value
        End Set
    End Property

    Public Property FEC_DOC As Date
        Get
            Return mFEC_DOC
        End Get
        Set(value As Date)
            mFEC_DOC = value
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

    Public Property EST As String
        Get
            Return mEST
        End Get
        Set(value As String)
            mEST = value
        End Set
    End Property

    Public Property TRANSP_COD As String
        Get
            Return mTRANSP_COD
        End Get
        Set(value As String)
            mTRANSP_COD = value
        End Set
    End Property

    Public Property REPROVEEDOR As String
        Get
            Return mREPROVEEDOR
        End Get
        Set(value As String)
            mREPROVEEDOR = value
        End Set
    End Property

    Public Property RETRANSPORTISTA As String
        Get
            Return mRETRANSPORTISTA
        End Get
        Set(value As String)
            mRETRANSPORTISTA = value
        End Set
    End Property

    Public Property CHOFER As String
        Get
            Return mCHOFER
        End Get
        Set(value As String)
            mCHOFER = value
        End Set
    End Property

    Public Property CERTIFICADO As String
        Get
            Return mCERTIFICADO
        End Get
        Set(value As String)
            mCERTIFICADO = value
        End Set
    End Property

    Public Property CERTIFICADO1 As String
        Get
            Return mCERTIFICADO1
        End Get
        Set(value As String)
            mCERTIFICADO1 = value
        End Set
    End Property

    Public Property BREVETE As String
        Get
            Return mBREVETE
        End Get
        Set(value As String)
            mBREVETE = value
        End Set
    End Property

    Public Property MARCA As String
        Get
            Return mMARCA
        End Get
        Set(value As String)
            mMARCA = value
        End Set
    End Property

    Public Property MARCA1 As String
        Get
            Return mMARCA1
        End Get
        Set(value As String)
            mMARCA1 = value
        End Set
    End Property

    Public Property PLACA1 As String
        Get
            Return mPLACA1
        End Get
        Set(value As String)
            mPLACA1 = value
        End Set
    End Property

    Public Property PLACA As String
        Get
            Return mPLACA
        End Get
        Set(value As String)
            mPLACA = value
        End Set
    End Property

    Public Property COLOR As String
        Get
            Return mCOLOR
        End Get
        Set(value As String)
            mCOLOR = value
        End Set
    End Property

    Public Property TIPO_UNIDAD As String
        Get
            Return mTIPO_UNIDAD
        End Get
        Set(value As String)
            mTIPO_UNIDAD = value
        End Set
    End Property

    Public Property CONFIGURACION As String
        Get
            Return mCONFIGURACION
        End Get
        Set(value As String)
            mCONFIGURACION = value
        End Set
    End Property

    Public Property COMENTARIO As String
        Get
            Return mCOMENTARIO
        End Get
        Set(value As String)
            mCOMENTARIO = value
        End Set
    End Property

    Public Property CTCT_DIR As String
        Get
            Return mCTCT_DIR
        End Get
        Set(value As String)
            mCTCT_DIR = value
        End Set
    End Property

    Public Property INTERES As Double
        Get
            Return mINTERES
        End Get
        Set(value As Double)
            mINTERES = value
        End Set
    End Property

    Public Property COSTO_MINIMO As Double
        Get
            Return mCOSTO_MINIMO
        End Get
        Set(value As Double)
            mCOSTO_MINIMO = value
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

    Public Property SIGNO As String
        Get
            Return mSIGNO
        End Get
        Set(value As String)
            mSIGNO = value
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

    Public Property OBSERVA As String
        Get
            Return mOBSERVA
        End Get
        Set(value As String)
            mOBSERVA = value
        End Set
    End Property

    Public Property T_MOVINV As String
        Get
            Return mT_MOVINV
        End Get
        Set(value As String)
            mT_MOVINV = value
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

    Public Property TPRECIO_VENTA As Double
        Get
            Return mTPRECIO_VENTA
        End Get
        Set(value As Double)
            mTPRECIO_VENTA = value
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

    Public Property TPRECIO_DVENTA As Double
        Get
            Return mTPRECIO_DVENTA
        End Get
        Set(value As Double)
            mTPRECIO_DVENTA = value
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

    Public Property DSCTO As Double
        Get
            Return mDSCTO
        End Get
        Set(value As Double)
            mDSCTO = value
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

    Public Property FLETE As Double
        Get
            Return mFLETE
        End Get
        Set(value As Double)
            mFLETE = value
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

    Public Property UPRECIO_COMPRA As Double
        Get
            Return mUPRECIO_COMPRA
        End Get
        Set(value As Double)
            mUPRECIO_COMPRA = value
        End Set
    End Property

    Public Property UPRECIO_VENTA As Double
        Get
            Return mUPRECIO_VENTA
        End Get
        Set(value As Double)
            mUPRECIO_VENTA = value
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

    Public Property UPRECIO_DVENTA As Double
        Get
            Return mUPRECIO_DVENTA
        End Get
        Set(value As Double)
            mUPRECIO_DVENTA = value
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

    Public Property DSCTO_DIMPOR As Double
        Get
            Return mDSCTO_DIMPOR
        End Get
        Set(value As Double)
            mDSCTO_DIMPOR = value
        End Set
    End Property

    Public Property BAR_COD As String
        Get
            Return mBAR_COD
        End Get
        Set(value As String)
            mBAR_COD = value
        End Set
    End Property

    Public Property DIR_COD As String
        Get
            Return mDIR_COD
        End Get
        Set(value As String)
            mDIR_COD = value
        End Set
    End Property

    Public Property ALM_COD_LLEG As String
        Get
            Return mALM_COD_LLEG
        End Get
        Set(value As String)
            mALM_COD_LLEG = value
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

    Public Property UNIDAD As String
        Get
            Return mUNIDAD
        End Get
        Set(value As String)
            mUNIDAD = value
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

    Public Property USUARIO As String
        Get
            Return mUSUARIO
        End Get
        Set(value As String)
            mUSUARIO = value
        End Set
    End Property

    Public Property FLA_KARDEX As String
        Get
            Return mFLA_KARDEX
        End Get
        Set(value As String)
            mFLA_KARDEX = value
        End Set
    End Property

    Public Property MOT_COD As String
        Get
            Return mMOT_COD
        End Get
        Set(value As String)
            mMOT_COD = value
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

    Public Property FOR_ENT_COD As String
        Get
            Return mFOR_ENT_COD
        End Get
        Set(value As String)
            mFOR_ENT_COD = value
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

    Public Property SALDO As Double
        Get
            Return mSALDO
        End Get
        Set(value As Double)
            mSALDO = value
        End Set
    End Property

    Public Property FEC_ANU As Date
        Get
            Return mFEC_ANU
        End Get
        Set(value As Date)
            mFEC_ANU = value
        End Set
    End Property

    Public Property X_CONT As String
        Get
            Return mX_CONT
        End Get
        Set(value As String)
            mX_CONT = value
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

    Public Property PROVEEDOR As String
        Get
            Return mPROVEEDOR
        End Get
        Set(value As String)
            mPROVEEDOR = value
        End Set
    End Property

    Public Property DIR_PROV As String
        Get
            Return mDIR_PROV
        End Get
        Set(value As String)
            mDIR_PROV = value
        End Set
    End Property

    Public Property PROV_DIR As String
        Get
            Return mPROV_DIR
        End Get
        Set(value As String)
            mPROV_DIR = value
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

    Public Property SUGERENCIA As String
        Get
            Return mSUGERENCIA
        End Get
        Set(value As String)
            mSUGERENCIA = value
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

    Public Property CCO_COD As String
        Get
            Return mCCO_COD
        End Get
        Set(value As String)
            mCCO_COD = value
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

    Public Property OTROS As String
        Get
            Return mOTROS
        End Get
        Set(value As String)
            mOTROS = value
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

    Public Property T_OPE_COD As String
        Get
            Return mT_OPE_COD
        End Get
        Set(value As String)
            mT_OPE_COD = value
        End Set
    End Property

    Public Property CLA As String
        Get
            Return mCLA
        End Get
        Set(value As String)
            mCLA = value
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

    Public Property CANTIDAD1 As Double
        Get
            Return mCANTIDAD1
        End Get
        Set(value As Double)
            mCANTIDAD1 = value
        End Set
    End Property

    Public Property ART_COD1 As String
        Get
            Return mART_COD1
        End Get
        Set(value As String)
            mART_COD1 = value
        End Set
    End Property

    Public Property UNIDAD1 As String
        Get
            Return mUNIDAD1
        End Get
        Set(value As String)
            mUNIDAD1 = value
        End Set
    End Property

    Public Property CARTAVIO As Double
        Get
            Return mCARTAVIO
        End Get
        Set(value As Double)
            mCARTAVIO = value
        End Set
    End Property

    Public Property X_BONIF As Double
        Get
            Return mX_BONIF
        End Get
        Set(value As Double)
            mX_BONIF = value
        End Set
    End Property

    Public Property LOTE As String
        Get
            Return mLOTE
        End Get
        Set(value As String)
            mLOTE = value
        End Set
    End Property

    Public Property LICENCIA As String
        Get
            Return mLICENCIA
        End Get
        Set(value As String)
            mLICENCIA = value
        End Set
    End Property

    Public Property ACT_COD As String
        Get
            Return mACT_COD
        End Get
        Set(value As String)
            mACT_COD = value
        End Set
    End Property

    Public Property ART_VENTA As String
        Get
            Return mART_VENTA
        End Get
        Set(value As String)
            mART_VENTA = value
        End Set
    End Property

    Public Property COD_COLOR As String
        Get
            Return mCOD_COLOR
        End Get
        Set(value As String)
            mCOD_COLOR = value
        End Set
    End Property

    Public Property COD_MEDIDA As String
        Get
            Return mCOD_MEDIDA
        End Get
        Set(value As String)
            mCOD_MEDIDA = value
        End Set
    End Property

    Public Property COD_MARCA As String
        Get
            Return mCOD_MARCA
        End Get
        Set(value As String)
            mCOD_MARCA = value
        End Set
    End Property

    Public Property PART_ACT As String
        Get
            Return mPART_ACT
        End Get
        Set(value As String)
            mPART_ACT = value
        End Set
    End Property

    Public Property FEC_ENT1 As Date
        Get
            Return mFEC_ENT1
        End Get
        Set(value As Date)
            mFEC_ENT1 = value
        End Set
    End Property

    Public Property FEC_ENT2 As Date
        Get
            Return mFEC_ENT2
        End Get
        Set(value As Date)
            mFEC_ENT2 = value
        End Set
    End Property

    Public Property FEC_ENT3 As Date
        Get
            Return mFEC_ENT3
        End Get
        Set(value As Date)
            mFEC_ENT3 = value
        End Set
    End Property

    Public Property FEC_ENT4 As Date
        Get
            Return mFEC_ENT4
        End Get
        Set(value As Date)
            mFEC_ENT4 = value
        End Set
    End Property

    Public Property FEC_ENT5 As Date
        Get
            Return mFEC_ENT5
        End Get
        Set(value As Date)
            mFEC_ENT5 = value
        End Set
    End Property

    Public Property CANTIDAD2 As Double
        Get
            Return mCANTIDAD2
        End Get
        Set(value As Double)
            mCANTIDAD2 = value
        End Set
    End Property

    Public Property CANTIDAD3 As Double
        Get
            Return mCANTIDAD3
        End Get
        Set(value As Double)
            mCANTIDAD3 = value
        End Set
    End Property

    Public Property CANTIDAD4 As Double
        Get
            Return mCANTIDAD4
        End Get
        Set(value As Double)
            mCANTIDAD4 = value
        End Set
    End Property

    Public Property CANTIDAD5 As Double
        Get
            Return mCANTIDAD5
        End Get
        Set(value As Double)
            mCANTIDAD5 = value
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

    Public Property PER_COD As String
        Get
            Return mPER_COD
        End Get
        Set(value As String)
            mPER_COD = value
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

    Public Property NRO_DOCU2 As String
        Get
            Return mNRO_DOCU2
        End Get
        Set(value As String)
            mNRO_DOCU2 = value
        End Set
    End Property

    Public Property HORA_INI As Date
        Get
            Return mHORA_INI
        End Get
        Set(value As Date)
            mHORA_INI = value
        End Set
    End Property

    Public Property HORA_FIN As Date
        Get
            Return mHORA_FIN
        End Get
        Set(value As Date)
            mHORA_FIN = value
        End Set
    End Property

    Public Property FEC_VENCIMIENTO As Date
        Get
            Return mFEC_VENCIMIENTO
        End Get
        Set(value As Date)
            mFEC_VENCIMIENTO = value
        End Set
    End Property

    Public Property PER_COD1 As String
        Get
            Return mPER_COD1
        End Get
        Set(value As String)
            mPER_COD1 = value
        End Set
    End Property

    Public Property PER_COD2 As String
        Get
            Return mPER_COD2
        End Get
        Set(value As String)
            mPER_COD2 = value
        End Set
    End Property

    Public Property OBSERVA1 As String
        Get
            Return mOBSERVA1
        End Get
        Set(value As String)
            mOBSERVA1 = value
        End Set
    End Property

    Public Property PROCESO As String
        Get
            Return mPROCESO
        End Get
        Set(value As String)
            mPROCESO = value
        End Set
    End Property

    Public Property MEDIDA As String
        Get
            Return mMEDIDA
        End Get
        Set(value As String)
            mMEDIDA = value
        End Set
    End Property

    Public Property EST_VENTAS As String
        Get
            Return mEST_VENTAS
        End Get
        Set(value As String)
            mEST_VENTAS = value
        End Set
    End Property

    Public Property ALMAC As String
        Get
            Return mALMAC
        End Get
        Set(value As String)
            mALMAC = value
        End Set
    End Property

    Public Property ACT_COD1 As String
        Get
            Return mACT_COD1
        End Get
        Set(value As String)
            mACT_COD1 = value
        End Set
    End Property

    Public Property ACT_COD2 As String
        Get
            Return mACT_COD2
        End Get
        Set(value As String)
            mACT_COD2 = value
        End Set
    End Property

    Public Property X_M As String
        Get
            Return mX_M
        End Get
        Set(value As String)
            mX_M = value
        End Set
    End Property

    Public Property X_N As String
        Get
            Return mX_N
        End Get
        Set(value As String)
            mX_N = value
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

    Public Property SERIE_SOLI As String
        Get
            Return mSERIE_SOLI
        End Get
        Set(value As String)
            mSERIE_SOLI = value
        End Set
    End Property

    Public Property TEMPLE As String
        Get
            Return mTEMPLE
        End Get
        Set(value As String)
            mTEMPLE = value
        End Set
    End Property

    Public Property TRATAMIENTO As String
        Get
            Return mTRATAMIENTO
        End Get
        Set(value As String)
            mTRATAMIENTO = value
        End Set
    End Property

    Public Property REQ As String
        Get
            Return mREQ
        End Get
        Set(value As String)
            mREQ = value
        End Set
    End Property

    Public Property T_ENVASE As Double
        Get
            Return mT_ENVASE
        End Get
        Set(value As Double)
            mT_ENVASE = value
        End Set
    End Property

    Public Property T_ENVASEP As Double
        Get
            Return mT_ENVASEP
        End Get
        Set(value As Double)
            mT_ENVASEP = value
        End Set
    End Property

    Public Property FEC_ENT6 As Date
        Get
            Return mFEC_ENT6
        End Get
        Set(value As Date)
            mFEC_ENT6 = value
        End Set
    End Property

    Public Property REQ_APROB As String
        Get
            Return mREQ_APROB
        End Get
        Set(value As String)
            mREQ_APROB = value
        End Set
    End Property

    Public Property NOM_CTCT As String
        Get
            Return mNOM_CTCT
        End Get
        Set(value As String)
            mNOM_CTCT = value
        End Set
    End Property

    Public Property PERCEPCION As String
        Get
            Return mPERCEPCION
        End Get
        Set(value As String)
            mPERCEPCION = value
        End Set
    End Property
End Class