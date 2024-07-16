Public Class ELTBKARDEXBE
    Private mNINICIAL As Double
    Private mPERIODO As String
    Private mRUC As String
    Private mRAZON_SOCIAL As String
    Private mESTABLECIMIENTO As String
    Private mFAM_CONT As String
    Private mART_COD As String
    Private mNOM_ART As String
    Private mUNIDAD As String
    Private mFECHA As Date
    Private mTIPO_DOC As String
    Private mSERIE_NRO As String
    Private mNRO_DOCU As String
    Private mTIPO_OPERACION As String
    Private mCOD_OPE As String
    Private mNOM_OPE As String
    Private mAÑO As String
    Private mFEC1 As Date
    Private mFEC2 As Date
    Private mALM As String
    Private mCANT_ENTRADA As Double
    Private mCANT_SALIDA As Double
    Private mACUM As Double
    Private mPRECIO As Double
    Private mPRECIO_ENTRADA As Double
    Private mPRECIO_SALIDA As Double
    Private mALM_COD As String
    Private mCOSTO_ENTRADA As Double
    Private mPRECIO_SALDO As Double
    Private mCOSTO_SALDO As Double
    Private mCANTIDAD_SALDO As Double
    Private mT_MOVIM As String
    Private mNOM_T_MOVIM As String
    Private mCOSTO_SALIDA As Double
    Private mNRO_PRD As String
    Private mCUENTA As String
    Private mCUENTA_DEST As String
    Private mDOC_REQ As String
    Private mDOC_OREQ As String

    Public Property NINICIAL As Double
        Get
            Return mNINICIAL
        End Get
        Set(value As Double)
            mNINICIAL = value
        End Set
    End Property

    Public Property PERIODO As String
        Get
            Return mPERIODO
        End Get
        Set(value As String)
            mPERIODO = value
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

    Public Property RAZON_SOCIAL As String
        Get
            Return mRAZON_SOCIAL
        End Get
        Set(value As String)
            mRAZON_SOCIAL = value
        End Set
    End Property

    Public Property ESTABLECIMIENTO As String
        Get
            Return mESTABLECIMIENTO
        End Get
        Set(value As String)
            mESTABLECIMIENTO = value
        End Set
    End Property

    Public Property FAM_CONT As String
        Get
            Return mFAM_CONT
        End Get
        Set(value As String)
            mFAM_CONT = value
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

    Public Property NOM_ART As String
        Get
            Return mNOM_ART
        End Get
        Set(value As String)
            mNOM_ART = value
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

    Public Property FECHA As Date
        Get
            Return mFECHA
        End Get
        Set(value As Date)
            mFECHA = value
        End Set
    End Property

    Public Property TIPO_DOC As String
        Get
            Return mTIPO_DOC
        End Get
        Set(value As String)
            mTIPO_DOC = value
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

    Public Property NRO_DOCU As String
        Get
            Return mNRO_DOCU
        End Get
        Set(value As String)
            mNRO_DOCU = value
        End Set
    End Property

    Public Property TIPO_OPERACION As String
        Get
            Return mTIPO_OPERACION
        End Get
        Set(value As String)
            mTIPO_OPERACION = value
        End Set
    End Property

    Public Property COD_OPE As String
        Get
            Return mCOD_OPE
        End Get
        Set(value As String)
            mCOD_OPE = value
        End Set
    End Property

    Public Property NOM_OPE As String
        Get
            Return mNOM_OPE
        End Get
        Set(value As String)
            mNOM_OPE = value
        End Set
    End Property

    Public Property CANT_ENTRADA As Double
        Get
            Return mCANT_ENTRADA
        End Get
        Set(value As Double)
            mCANT_ENTRADA = value
        End Set
    End Property

    Public Property CANT_SALIDA As Double
        Get
            Return mCANT_SALIDA
        End Get
        Set(value As Double)
            mCANT_SALIDA = value
        End Set
    End Property

    Public Property AÑO As String
        Get
            Return mAÑO
        End Get
        Set(value As String)
            mAÑO = value
        End Set
    End Property

    Public Property FEC1 As Date
        Get
            Return mFEC1
        End Get
        Set(value As Date)
            mFEC1 = value
        End Set
    End Property

    Public Property FEC2 As Date
        Get
            Return mFEC2
        End Get
        Set(value As Date)
            mFEC2 = value
        End Set
    End Property

    Public Property ALM As String
        Get
            Return mALM
        End Get
        Set(value As String)
            mALM = value
        End Set
    End Property

    Public Property ACUM As Double
        Get
            Return mACUM
        End Get
        Set(value As Double)
            mACUM = value
        End Set
    End Property

    Public Property PRECIO As Double
        Get
            Return mPRECIO
        End Get
        Set(value As Double)
            mPRECIO = value
        End Set
    End Property

    Public Property PRECIO_ENTRADA As Double
        Get
            Return mPRECIO_ENTRADA
        End Get
        Set(value As Double)
            mPRECIO_ENTRADA = value
        End Set
    End Property

    Public Property PRECIO_SALIDA As Double
        Get
            Return mPRECIO_SALIDA
        End Get
        Set(value As Double)
            mPRECIO_SALIDA = value
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

    Public Property COSTO_ENTRADA As Double
        Get
            Return mCOSTO_ENTRADA
        End Get
        Set(value As Double)
            mCOSTO_ENTRADA = value
        End Set
    End Property

    Public Property PRECIO_SALDO As Double
        Get
            Return mPRECIO_SALDO
        End Get
        Set(value As Double)
            mPRECIO_SALDO = value
        End Set
    End Property

    Public Property COSTO_SALDO As Double
        Get
            Return mCOSTO_SALDO
        End Get
        Set(value As Double)
            mCOSTO_SALDO = value
        End Set
    End Property

    Public Property CANTIDAD_SALDO As Double
        Get
            Return mCANTIDAD_SALDO
        End Get
        Set(value As Double)
            mCANTIDAD_SALDO = value
        End Set
    End Property

    Public Property T_MOVIM As String
        Get
            Return mT_MOVIM
        End Get
        Set(value As String)
            mT_MOVIM = value
        End Set
    End Property

    Public Property NOM_T_MOVIM As String
        Get
            Return mNOM_T_MOVIM
        End Get
        Set(value As String)
            mNOM_T_MOVIM = value
        End Set
    End Property

    Public Property COSTO_SALIDA As Double
        Get
            Return mCOSTO_SALIDA
        End Get
        Set(value As Double)
            mCOSTO_SALIDA = value
        End Set
    End Property

    Public Property NRO_PRD As String
        Get
            Return mNRO_PRD
        End Get
        Set(value As String)
            mNRO_PRD = value
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

    Public Property DOC_REQ As String
        Get
            Return mDOC_REQ
        End Get
        Set(value As String)
            mDOC_REQ = value
        End Set
    End Property

    Public Property DOC_OREQ As String
        Get
            Return mDOC_OREQ
        End Get
        Set(value As String)
            mDOC_OREQ = value
        End Set
    End Property
End Class
