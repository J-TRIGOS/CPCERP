Public Class NOTADEBITOBE
    'Campos de la entidad
    Private mSER_DOC_REF As String
    Private mT_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mART_COD As String
    Private mALM_COD As String
    Private mFEC_GENE As Date
    Private mUNIDAD As String
    Private mEST As String
    Private mSALDO As Double
    Private mBAR_COD As String
    Private mMONEDA As String
    Private mTPRECIO_COMPRA As Double
    Private mTPRECIO_VENTA As Double
    Private mFEC_ANU As Date
    Private mSIGNO As String
    Private mTPRECIO_DCOMPRA As Double
    Private mTPRECIO_DVENTA As Double
    Private mUSUARIO As String
    Private mOBSERVA As String
    Private mT_MOVINV As String
    Private mT_IGV As Double
    Private mT_IGV_DOLAR As Double
    Private mT_DCTO As Double
    Private mT_DCTO_DOLAR As Double
    Private mFLA_KARDEX As String
    Private mMOT_COD As String
    Private mF_PAGO_ENT As String
    Private mFOR_ENT_COD As String
    Private mT_OPE As String
    Private mX_RET As String
    Private mREG_NRO As String
    Private mCCO_COD As String
    Private mPROVEEDOR As String
    Private mTIPO As String
    Private mFEC_PROV As Date
    Private mCTA_CBCO As String
    Private mCBCO_COD As Double
    Private mMONTO_PAGADOD As Double
    Private mMONTO_PAGADO As Double
    Private mCOBRANZA As String
    Private mCTCT_COD As String
    Private mT_IES As Double
    Private mT_DIES As Double
    Private mT_CTA As Double
    Private mT_DCTA As Double
    Private mDETRACCION As String
    Private mFEC_DET As Date
    Private mTAFECTO As Double
    Private mTAFECTOD As Double
    Private mT_CAMB As Double
    Private mRETEN As String
    Private mPORCENTAJE As Double
    Private mEST1 As String
    Private mFEC_PAGO As Date
    Private mPAG_PARCIAL As Double
    Private mT_CAMB_BCO As Double
    Private mNRO_REGCOBRA As String
    Private mX_LETRA As String
    Private mBINTERES As String
    Private mT_CAMBIO As Double
    Private mFEC_VIGENCIA As Date
    Private mCARTAVIO As Double
    Private mVENDEDOR As String
    Private mDIR_PROV As String
    Private mCANAL As String
    Private mDIR_COD As String
    Private mTER_COD As String
    Private mT_DOC_REF2 As String
    Private mSER_DOC_REF2 As String
    Private mNRO_DOC_REF2 As String
    Private mPROVEEDOR2 As String
    Private mCOD_DEVOLUCION As String
    Private mEST_MERCADERIA As String
    Private mNUMPEDIDO As String
    Private mFEC_RANGO As Date
    Private mIFEC_RANGO As Date
    Private mPER_COD As String
    Private mALMAC As String
    Private mSERIE_CLIENTE As String
    Private mEST_VENTAS As String
    Private mPROGRAMA As String
    Private mTURNO As String
    Private mACT_COD As String
    Private mLOTE As String
    Private mLOTE1 As String
    Private mART_COD1 As String
    Private mOBSERVA1 As String
    Private mCANTIDAD As Double
    Private mCANTIDAD1 As Double
    Private mCANTIDAD2 As Double
    Private mCANTIDAD3 As Double
    Private mOBSERVA2 As String
    Private mART_COD2 As String
    Private mX_M As String
    Private mX_D As String
    Private mX_N As String
    Private mFARDO As String
    Private mART_COD3 As String
    Private mART_COD4 As String
    Private mART_COD5 As String
    Private mART_COD6 As String
    Private mART_COD7 As String
    Private mART_COD8 As String
    Private mART_COD9 As String
    Private mTIPO1 As String
    Private mTIPO2 As String
    Private mTIPO3 As String
    Private mTIPO4 As String
    Private mTIPO5 As String
    Private mTIPO6 As String
    Private mTIPO7 As String
    Private mTIPO9 As String
    Private mFEC_DIA As Date
    Private mFEC_DIA1 As String
    Private mSERIE_SOLI As String
    Private mNRO_DOCU1 As String
    Private mPART_ACT As String
    Private mFARDO1 As String
    Private mFARDO2 As String
    Private mFARDO3 As String
    Private mFARDO4 As String
    Private mLETRA As String
    Private mFEC_LETRA As Date
    Private mZ_LETRA As String
    Private mNRO_PERCEPCION As String
    Private mX_PERC As String
    Private mSER_PERC As String
    Private mPORC_PERC As Double
    Private mMONTO_PERC As Double
    Private mNRO_DOCU As String
    Private mNOM_CTCT As String

    'Propiedades de la entidad
    Public Property SER_DOC_REF() As String
        Get
            Return mSER_DOC_REF
        End Get
        Set(ByVal value As String)
            mSER_DOC_REF = value
        End Set
    End Property
    Public Property T_DOC_REF() As String
        Get
            Return mT_DOC_REF
        End Get
        Set(ByVal value As String)
            mT_DOC_REF = value
        End Set
    End Property
    Public Property NRO_DOC_REF() As String
        Get
            Return mNRO_DOC_REF
        End Get
        Set(ByVal value As String)
            mNRO_DOC_REF = value
        End Set
    End Property
    Public Property ART_COD() As String
        Get
            Return mART_COD
        End Get
        Set(ByVal value As String)
            mART_COD = value
        End Set
    End Property
    Public Property ALM_COD() As String
        Get
            Return mALM_COD
        End Get
        Set(ByVal value As String)
            mALM_COD = value
        End Set
    End Property
    Public Property FEC_GENE() As Date
        Get
            Return mFEC_GENE
        End Get
        Set(ByVal value As Date)
            mFEC_GENE = value
        End Set
    End Property
    Public Property UNIDAD() As String
        Get
            Return mUNIDAD
        End Get
        Set(ByVal value As String)
            mUNIDAD = value
        End Set
    End Property
    Public Property EST() As String
        Get
            Return mEST
        End Get
        Set(ByVal value As String)
            mEST = value
        End Set
    End Property
    Public Property SALDO() As Double
        Get
            Return mSALDO
        End Get
        Set(ByVal value As Double)
            mSALDO = value
        End Set
    End Property
    Public Property BAR_COD() As String
        Get
            Return mBAR_COD
        End Get
        Set(ByVal value As String)
            mBAR_COD = value
        End Set
    End Property
    Public Property MONEDA() As String
        Get
            Return mMONEDA
        End Get
        Set(ByVal value As String)
            mMONEDA = value
        End Set
    End Property
    Public Property TPRECIO_COMPRA() As Double
        Get
            Return mTPRECIO_COMPRA
        End Get
        Set(ByVal value As Double)
            mTPRECIO_COMPRA = value
        End Set
    End Property
    Public Property TPRECIO_VENTA() As Double
        Get
            Return mTPRECIO_VENTA
        End Get
        Set(ByVal value As Double)
            mTPRECIO_VENTA = value
        End Set
    End Property
    Public Property FEC_ANU() As Date
        Get
            Return mFEC_ANU
        End Get
        Set(ByVal value As Date)
            mFEC_ANU = value
        End Set
    End Property
    Public Property SIGNO() As String
        Get
            Return mSIGNO
        End Get
        Set(ByVal value As String)
            mSIGNO = value
        End Set
    End Property
    Public Property TPRECIO_DCOMPRA() As Double
        Get
            Return mTPRECIO_DCOMPRA
        End Get
        Set(ByVal value As Double)
            mTPRECIO_DCOMPRA = value
        End Set
    End Property
    Public Property TPRECIO_DVENTA() As Double
        Get
            Return mTPRECIO_DVENTA
        End Get
        Set(ByVal value As Double)
            mTPRECIO_DVENTA = value
        End Set
    End Property
    Public Property USUARIO() As String
        Get
            Return mUSUARIO
        End Get
        Set(ByVal value As String)
            mUSUARIO = value
        End Set
    End Property
    Public Property OBSERVA() As String
        Get
            Return mOBSERVA
        End Get
        Set(ByVal value As String)
            mOBSERVA = value
        End Set
    End Property
    Public Property T_MOVINV() As String
        Get
            Return mT_MOVINV
        End Get
        Set(ByVal value As String)
            mT_MOVINV = value
        End Set
    End Property
    Public Property T_IGV() As Double
        Get
            Return mT_IGV
        End Get
        Set(ByVal value As Double)
            mT_IGV = value
        End Set
    End Property

    Public Property T_IGV_DOLAR() As Double
        Get
            Return mT_IGV_DOLAR
        End Get
        Set(ByVal value As Double)
            mT_IGV_DOLAR = value
        End Set
    End Property
    Public Property T_DCTO() As Double
        Get
            Return mT_DCTO
        End Get
        Set(ByVal value As Double)
            mT_DCTO = value
        End Set
    End Property
    Public Property T_DCTO_DOLAR() As Double
        Get
            Return mT_DCTO_DOLAR
        End Get
        Set(ByVal value As Double)
            mT_DCTO_DOLAR = value
        End Set
    End Property
    Public Property FLA_KARDEX() As String
        Get
            Return mFLA_KARDEX
        End Get
        Set(ByVal value As String)
            mFLA_KARDEX = value
        End Set
    End Property
    Public Property MOT_COD() As String
        Get
            Return mMOT_COD
        End Get
        Set(ByVal value As String)
            mMOT_COD = value
        End Set
    End Property
    Public Property F_PAGO_ENT() As String
        Get
            Return mF_PAGO_ENT
        End Get
        Set(ByVal value As String)
            mF_PAGO_ENT = value
        End Set
    End Property
    Public Property FOR_ENT_COD() As String
        Get
            Return mFOR_ENT_COD
        End Get
        Set(ByVal value As String)
            mFOR_ENT_COD = value
        End Set
    End Property
    Public Property T_OPE() As String
        Get
            Return mT_OPE
        End Get
        Set(ByVal value As String)
            mT_OPE = value
        End Set
    End Property
    Public Property X_RET() As String
        Get
            Return mX_RET
        End Get
        Set(ByVal value As String)
            mX_RET = value
        End Set
    End Property
    Public Property REG_NRO() As String
        Get
            Return mREG_NRO
        End Get
        Set(ByVal value As String)
            mREG_NRO = value
        End Set
    End Property
    Public Property CCO_COD() As String
        Get
            Return mCCO_COD
        End Get
        Set(ByVal value As String)
            mCCO_COD = value
        End Set
    End Property
    Public Property PROVEEDOR() As String
        Get
            Return mPROVEEDOR
        End Get
        Set(ByVal value As String)
            mPROVEEDOR = value
        End Set
    End Property
    Public Property TIPO() As String
        Get
            Return mTIPO
        End Get
        Set(ByVal value As String)
            mTIPO = value
        End Set
    End Property
    Public Property FEC_PROV() As Date
        Get
            Return mFEC_PROV
        End Get
        Set(ByVal value As Date)
            mFEC_PROV = value
        End Set
    End Property
    Public Property CTA_CBCO() As String
        Get
            Return mCTA_CBCO
        End Get
        Set(ByVal value As String)
            mCTA_CBCO = value
        End Set
    End Property
    Public Property CBCO_COD() As Double
        Get
            Return mCBCO_COD
        End Get
        Set(ByVal value As Double)
            mCBCO_COD = value
        End Set
    End Property
    Public Property MONTO_PAGADOD() As Double
        Get
            Return mMONTO_PAGADOD
        End Get
        Set(ByVal value As Double)
            mMONTO_PAGADOD = value
        End Set
    End Property
    Public Property MONTO_PAGADO() As Double
        Get
            Return mMONTO_PAGADO
        End Get
        Set(ByVal value As Double)
            mMONTO_PAGADO = value
        End Set
    End Property
    Public Property COBRANZA() As String
        Get
            Return mCOBRANZA
        End Get
        Set(ByVal value As String)
            mCOBRANZA = value
        End Set
    End Property
    Public Property CTCT_COD() As String
        Get
            Return mCTCT_COD
        End Get
        Set(ByVal value As String)
            mCTCT_COD = value
        End Set
    End Property
    Public Property T_IES() As Double
        Get
            Return mT_IES
        End Get
        Set(ByVal value As Double)
            mT_IES = value
        End Set
    End Property
    Public Property T_DIES() As Double
        Get
            Return mT_DIES
        End Get
        Set(ByVal value As Double)
            mT_DIES = value
        End Set
    End Property
    Public Property T_CTA() As Double
        Get
            Return mT_CTA
        End Get
        Set(ByVal value As Double)
            mT_CTA = value
        End Set
    End Property
    Public Property T_DCTA() As Double
        Get
            Return mT_DCTA
        End Get
        Set(ByVal value As Double)
            mT_DCTA = value
        End Set
    End Property
    Public Property DETRACCION() As String
        Get
            Return mDETRACCION
        End Get
        Set(ByVal value As String)
            mDETRACCION = value
        End Set
    End Property

    Public Property FEC_DET() As Date
        Get
            Return mFEC_DET
        End Get
        Set(ByVal value As Date)
            mFEC_DET = value
        End Set
    End Property
    Public Property TAFECTO() As Double
        Get
            Return mTAFECTO
        End Get
        Set(ByVal value As Double)
            mTAFECTO = value
        End Set
    End Property
    Public Property TAFECTOD() As Double
        Get
            Return mTAFECTOD
        End Get
        Set(ByVal value As Double)
            mTAFECTOD = value
        End Set
    End Property
    Public Property T_CAMB() As Double
        Get
            Return mT_CAMB
        End Get
        Set(ByVal value As Double)
            mT_CAMB = value
        End Set
    End Property
    Public Property RETEN() As String
        Get
            Return mRETEN
        End Get
        Set(ByVal value As String)
            mRETEN = value
        End Set
    End Property
    Public Property PORCENTAJE() As Double
        Get
            Return mPORCENTAJE
        End Get
        Set(ByVal value As Double)
            mPORCENTAJE = value
        End Set
    End Property
    Public Property EST1() As String
        Get
            Return mEST1
        End Get
        Set(ByVal value As String)
            mEST1 = value
        End Set
    End Property
    Public Property FEC_PAGO() As Date
        Get
            Return mFEC_PAGO
        End Get
        Set(ByVal value As Date)
            mFEC_PAGO = value
        End Set
    End Property
    Public Property PAG_PARCIAL() As Double
        Get
            Return mPAG_PARCIAL
        End Get
        Set(ByVal value As Double)
            mPAG_PARCIAL = value
        End Set
    End Property
    Public Property T_CAMB_BCO() As Double
        Get
            Return mT_CAMB_BCO
        End Get
        Set(ByVal value As Double)
            mT_CAMB_BCO = value
        End Set
    End Property
    Public Property NRO_REGCOBRA() As String
        Get
            Return mEST1
        End Get
        Set(ByVal value As String)
            mNRO_REGCOBRA = value
        End Set
    End Property
    Public Property X_LETRA() As String
        Get
            Return mX_LETRA
        End Get
        Set(ByVal value As String)
            mX_LETRA = value
        End Set
    End Property
    Public Property BINTERES() As String
        Get
            Return mBINTERES
        End Get
        Set(ByVal value As String)
            mBINTERES = value
        End Set
    End Property
    Public Property T_CAMBIO() As Double
        Get
            Return mT_CAMBIO
        End Get
        Set(ByVal value As Double)
            mT_CAMBIO = value
        End Set
    End Property
    Public Property FEC_VIGENCIA() As Date
        Get
            Return mFEC_VIGENCIA
        End Get
        Set(ByVal value As Date)
            mFEC_VIGENCIA = value
        End Set
    End Property
    Public Property CARTAVIO() As Double
        Get
            Return mCARTAVIO
        End Get
        Set(ByVal value As Double)
            mCARTAVIO = value
        End Set
    End Property
    Public Property VENDEDOR() As String
        Get
            Return mVENDEDOR
        End Get
        Set(ByVal value As String)
            mVENDEDOR = value
        End Set
    End Property
    Public Property DIR_PROV() As String
        Get
            Return mDIR_PROV
        End Get
        Set(ByVal value As String)
            mDIR_PROV = value
        End Set
    End Property
    Public Property CANAL() As String
        Get
            Return mCANAL
        End Get
        Set(ByVal value As String)
            mCANAL = value
        End Set
    End Property
    Public Property DIR_COD() As String
        Get
            Return mDIR_COD
        End Get
        Set(ByVal value As String)
            mDIR_COD = value
        End Set
    End Property
    Public Property TER_COD() As String
        Get
            Return mTER_COD
        End Get
        Set(ByVal value As String)
            mTER_COD = value
        End Set
    End Property
    Public Property T_DOC_REF2() As String
        Get
            Return mT_DOC_REF2
        End Get
        Set(ByVal value As String)
            mT_DOC_REF2 = value
        End Set
    End Property
    Public Property SER_DOC_REF2() As String
        Get
            Return mSER_DOC_REF2
        End Get
        Set(ByVal value As String)
            mSER_DOC_REF2 = value
        End Set
    End Property
    Public Property NRO_DOC_REF2() As String
        Get
            Return mNRO_DOC_REF2
        End Get
        Set(ByVal value As String)
            mNRO_DOC_REF2 = value
        End Set
    End Property
    Public Property PROVEEDOR2() As String
        Get
            Return mPROVEEDOR2
        End Get
        Set(ByVal value As String)
            mPROVEEDOR2 = value
        End Set
    End Property
    Public Property COD_DEVOLUCION() As String
        Get
            Return mCOD_DEVOLUCION
        End Get
        Set(ByVal value As String)
            mCOD_DEVOLUCION = value
        End Set
    End Property
    Public Property EST_MERCADERIA() As String
        Get
            Return mEST_MERCADERIA
        End Get
        Set(ByVal value As String)
            mEST_MERCADERIA = value
        End Set
    End Property
    Public Property NUMPEDIDO() As String
        Get
            Return mNUMPEDIDO
        End Get
        Set(ByVal value As String)
            mNUMPEDIDO = value
        End Set
    End Property
    Public Property FEC_RANGO() As Date
        Get
            Return mFEC_RANGO
        End Get
        Set(ByVal value As Date)
            mFEC_RANGO = value
        End Set
    End Property
    Public Property IFEC_RANGO() As Date
        Get
            Return mIFEC_RANGO
        End Get
        Set(ByVal value As Date)
            mIFEC_RANGO = value
        End Set
    End Property
    Public Property PER_COD() As String
        Get
            Return mPER_COD
        End Get
        Set(ByVal value As String)
            mPER_COD = value
        End Set
    End Property
    Public Property ALMAC() As String
        Get
            Return mALMAC
        End Get
        Set(ByVal value As String)
            mALMAC = value
        End Set
    End Property
    Public Property SERIE_CLIENTE() As String
        Get
            Return mSERIE_CLIENTE
        End Get
        Set(ByVal value As String)
            mSERIE_CLIENTE = value
        End Set
    End Property
    Public Property EST_VENTAS() As String
        Get
            Return mEST_VENTAS
        End Get
        Set(ByVal value As String)
            mEST_VENTAS = value
        End Set
    End Property
    Public Property PROGRAMA() As String
        Get
            Return mPROGRAMA
        End Get
        Set(ByVal value As String)
            mPROGRAMA = value
        End Set
    End Property
    Public Property TURNO() As String
        Get
            Return mTURNO
        End Get
        Set(ByVal value As String)
            mTURNO = value
        End Set
    End Property
    Public Property ACT_COD() As String
        Get
            Return mACT_COD
        End Get
        Set(ByVal value As String)
            mACT_COD = value
        End Set
    End Property
    Public Property LOTE() As String
        Get
            Return mLOTE
        End Get
        Set(ByVal value As String)
            mLOTE = value
        End Set
    End Property
    Public Property LOTE1() As String
        Get
            Return mLOTE1
        End Get
        Set(ByVal value As String)
            mLOTE1 = value
        End Set
    End Property
    Public Property ART_COD1() As String
        Get
            Return mART_COD1
        End Get
        Set(ByVal value As String)
            mART_COD1 = value
        End Set
    End Property
    Public Property OBSERVA1() As String
        Get
            Return mOBSERVA1
        End Get
        Set(ByVal value As String)
            mOBSERVA1 = value
        End Set
    End Property
    Public Property CANTIDAD() As Double
        Get
            Return mCANTIDAD
        End Get
        Set(ByVal value As Double)
            mCANTIDAD = value
        End Set
    End Property
    Public Property CANTIDAD1() As Double
        Get
            Return mCANTIDAD1
        End Get
        Set(ByVal value As Double)
            mCANTIDAD1 = value
        End Set
    End Property
    Public Property CANTIDAD2() As Double
        Get
            Return mCANTIDAD2
        End Get
        Set(ByVal value As Double)
            mCANTIDAD2 = value
        End Set
    End Property
    Public Property CANTIDAD3() As Double
        Get
            Return mCANTIDAD3
        End Get
        Set(ByVal value As Double)
            mCANTIDAD3 = value
        End Set
    End Property
    Public Property OBSERVA2() As String
        Get
            Return mOBSERVA2
        End Get
        Set(ByVal value As String)
            mOBSERVA2 = value
        End Set
    End Property
    Public Property ART_COD2() As String
        Get
            Return mART_COD2
        End Get
        Set(ByVal value As String)
            mART_COD2 = value
        End Set
    End Property
    Public Property X_M() As String
        Get
            Return mX_M
        End Get
        Set(ByVal value As String)
            mX_M = value
        End Set
    End Property
    Public Property X_D() As String
        Get
            Return mX_D
        End Get
        Set(ByVal value As String)
            mX_D = value
        End Set
    End Property
    Public Property X_N() As String
        Get
            Return mX_N
        End Get
        Set(ByVal value As String)
            mX_N = value
        End Set
    End Property
    Public Property FARDO() As String
        Get
            Return mFARDO
        End Get
        Set(ByVal value As String)
            mFARDO = value
        End Set
    End Property
    Public Property ART_COD3() As String
        Get
            Return mART_COD3
        End Get
        Set(ByVal value As String)
            mART_COD3 = value
        End Set
    End Property
    Public Property ART_COD4() As String
        Get
            Return mART_COD4
        End Get
        Set(ByVal value As String)
            mART_COD4 = value
        End Set
    End Property
    Public Property ART_COD5() As String
        Get
            Return mART_COD5
        End Get
        Set(ByVal value As String)
            mART_COD5 = value
        End Set
    End Property
    Public Property ART_COD6() As String
        Get
            Return mART_COD6
        End Get
        Set(ByVal value As String)
            mART_COD6 = value
        End Set
    End Property
    Public Property ART_COD7() As String
        Get
            Return mART_COD7
        End Get
        Set(ByVal value As String)
            mART_COD7 = value
        End Set
    End Property
    Public Property ART_COD8() As String
        Get
            Return mART_COD8
        End Get
        Set(ByVal value As String)
            mART_COD8 = value
        End Set
    End Property
    Public Property ART_COD9() As String
        Get
            Return mART_COD9
        End Get
        Set(ByVal value As String)
            mART_COD9 = value
        End Set
    End Property
    Public Property TIPO1() As String
        Get
            Return mTIPO1
        End Get
        Set(ByVal value As String)
            mTIPO1 = value
        End Set
    End Property
    Public Property TIPO2() As String
        Get
            Return mTIPO2
        End Get
        Set(ByVal value As String)
            mTIPO2 = value
        End Set
    End Property
    Public Property TIPO3() As String
        Get
            Return mTIPO3
        End Get
        Set(ByVal value As String)
            mTIPO3 = value
        End Set
    End Property
    Public Property TIPO4() As String
        Get
            Return mTIPO4
        End Get
        Set(ByVal value As String)
            mTIPO4 = value
        End Set
    End Property
    Public Property TIPO5() As String
        Get
            Return mTIPO5
        End Get
        Set(ByVal value As String)
            mTIPO5 = value
        End Set
    End Property
    Public Property TIPO6() As String
        Get
            Return mTIPO6
        End Get
        Set(ByVal value As String)
            mTIPO6 = value
        End Set
    End Property
    Public Property TIPO7() As String
        Get
            Return mTIPO7
        End Get
        Set(ByVal value As String)
            mTIPO7 = value
        End Set
    End Property
    Public Property TIPO9() As String
        Get
            Return mTIPO9
        End Get
        Set(ByVal value As String)
            mTIPO9 = value
        End Set
    End Property
    Public Property FEC_DIA() As Date
        Get
            Return mFEC_DIA
        End Get
        Set(ByVal value As Date)
            mFEC_DIA = value
        End Set
    End Property
    Public Property FEC_DIA1() As String
        Get
            Return mFEC_DIA1
        End Get
        Set(ByVal value As String)
            mFEC_DIA1 = value
        End Set
    End Property
    Public Property SERIE_SOLI() As String
        Get
            Return mSERIE_SOLI
        End Get
        Set(ByVal value As String)
            mSERIE_SOLI = value
        End Set
    End Property
    Public Property NRO_DOCU1() As String
        Get
            Return mNRO_DOCU1
        End Get
        Set(ByVal value As String)
            mNRO_DOCU1 = value
        End Set
    End Property
    Public Property PART_ACT() As String
        Get
            Return mPART_ACT
        End Get
        Set(ByVal value As String)
            mPART_ACT = value
        End Set
    End Property
    Public Property FARDO1() As String
        Get
            Return mFARDO1
        End Get
        Set(ByVal value As String)
            mFARDO1 = value
        End Set
    End Property
    Public Property FARDO2() As String
        Get
            Return mFARDO2
        End Get
        Set(ByVal value As String)
            mFARDO2 = value
        End Set
    End Property
    Public Property FARDO3() As String
        Get
            Return mFARDO3
        End Get
        Set(ByVal value As String)
            mFARDO3 = value
        End Set
    End Property
    Public Property FARDO4() As String
        Get
            Return mFARDO4
        End Get
        Set(ByVal value As String)
            mFARDO4 = value
        End Set
    End Property
    Public Property LETRA() As String
        Get
            Return mLETRA
        End Get
        Set(ByVal value As String)
            mLETRA = value
        End Set
    End Property
    Public Property FEC_LETRA() As Date
        Get
            Return mFEC_LETRA
        End Get
        Set(ByVal value As Date)
            mFEC_LETRA = value
        End Set
    End Property
    Public Property Z_LETRA() As String
        Get
            Return mZ_LETRA
        End Get
        Set(ByVal value As String)
            mZ_LETRA = value
        End Set
    End Property
    Public Property NRO_PERCEPCION() As String
        Get
            Return mNRO_PERCEPCION
        End Get
        Set(ByVal value As String)
            mNRO_PERCEPCION = value
        End Set
    End Property
    Public Property X_PERC() As String
        Get
            Return mX_PERC
        End Get
        Set(ByVal value As String)
            mX_PERC = value
        End Set
    End Property
    Public Property SER_PERC() As String
        Get
            Return mSER_PERC
        End Get
        Set(ByVal value As String)
            mSER_PERC = value
        End Set
    End Property
    Public Property PORC_PERC() As Double
        Get
            Return mPORC_PERC
        End Get
        Set(ByVal value As Double)
            mPORC_PERC = value
        End Set
    End Property
    Public Property MONTO_PERC() As Double
        Get
            Return mMONTO_PERC
        End Get
        Set(ByVal value As Double)
            mMONTO_PERC = value
        End Set
    End Property

    Public Property NRO_DOCU() As String
        Get
            Return mNRO_DOCU
        End Get
        Set(ByVal value As String)
            mNRO_DOCU = value
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
End Class
