Public Class ELTBSTIEMBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mCCO_COD As String
    Private mFEC_GENE As Date
    Private mFEC_TERMINO As Date
    Private mHORA_GENE As String
    Private mHORA_TERMINO As String
    Private mOBSERVA As String
    Private mACT_REALIZAR As String
    Private mDIF_HORA As String
    Private mPER_COD As String
    Private mUSUARIO_OB As String
    Private mUSUARIO_VB As String
    Private mUSUARIO_RP As String
    Private mFEC_DIA As Date
    Private mFEC_INICIO As Date
    Private mNUM_DIF As Double
    Private mEST As String
    Private mD_PROGRAMADO As String
    Private mMINUTOS As Double
    Private mUSUARIO As String
    Private mOP As String
    Private mOBSERVACIONRH As String
    Private mUSUARIO_VBPLANTA As String
    Private mUSUARIO_VB_RH As String
    Private mOBSERVACION_JEFE_PLANTA As String
    Private mLINEA As String
    Private mPRDO As String
    Private mOBSERVACION_JEFE As String
    'Propiedades de la entidad
    Public Property T_DOC_REF() As String
        Get
            Return mT_DOC_REF
        End Get
        Set(ByVal value As String)
            mT_DOC_REF = value
        End Set
    End Property
    Public Property SER_DOC_REF() As String
        Get
            Return mSER_DOC_REF
        End Get
        Set(ByVal value As String)
            mSER_DOC_REF = value
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
    Public Property CCO_COD() As String
        Get
            Return mCCO_COD
        End Get
        Set(ByVal value As String)
            mCCO_COD = value
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
    Public Property FEC_TERMINO() As Date
        Get
            Return mFEC_TERMINO
        End Get
        Set(ByVal value As Date)
            mFEC_TERMINO = value
        End Set
    End Property
    Public Property HORA_GENE() As String
        Get
            Return mHORA_GENE
        End Get
        Set(ByVal value As String)
            mHORA_GENE = value
        End Set
    End Property
    Public Property HORA_TERMINO() As String
        Get
            Return mHORA_TERMINO
        End Get
        Set(ByVal value As String)
            mHORA_TERMINO = value
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
    Public Property ACT_REALIZAR() As String
        Get
            Return mACT_REALIZAR
        End Get
        Set(ByVal value As String)
            mACT_REALIZAR = value
        End Set
    End Property
    Public Property DIF_HORA() As String
        Get
            Return mDIF_HORA
        End Get
        Set(ByVal value As String)
            mDIF_HORA = value
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
    Public Property USUARIO_OB() As String
        Get
            Return mUSUARIO_OB
        End Get
        Set(ByVal value As String)
            mUSUARIO_OB = value
        End Set
    End Property
    Public Property USUARIO_VB() As String
        Get
            Return mUSUARIO_VB
        End Get
        Set(ByVal value As String)
            mUSUARIO_VB = value
        End Set
    End Property
    Public Property USUARIO_RP() As String
        Get
            Return mUSUARIO_RP
        End Get
        Set(ByVal value As String)
            mUSUARIO_RP = value
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
    Public Property FEC_INICIO() As Date
        Get
            Return mFEC_INICIO
        End Get
        Set(ByVal value As Date)
            mFEC_INICIO = value
        End Set
    End Property
    Public Property NUM_DIF() As Double
        Get
            Return mNUM_DIF
        End Get
        Set(ByVal value As Double)
            mNUM_DIF = value
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

    Public Property D_PROGRAMADO As String
        Get
            Return mD_PROGRAMADO
        End Get
        Set(value As String)
            mD_PROGRAMADO = value
        End Set
    End Property

    Public Property MINUTOS As Double
        Get
            Return mMINUTOS
        End Get
        Set(value As Double)
            mMINUTOS = value
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

    Public Property OP As String
        Get
            Return mOP
        End Get
        Set(value As String)
            mOP = value
        End Set
    End Property

    Public Property OBSERVACIONRH As String
        Get
            Return mOBSERVACIONRH
        End Get
        Set(value As String)
            mOBSERVACIONRH = value
        End Set
    End Property

    Public Property USUARIO_VBPLANTA As String
        Get
            Return mUSUARIO_VBPLANTA
        End Get
        Set(value As String)
            mUSUARIO_VBPLANTA = value
        End Set
    End Property

    Public Property OBSERVACION_JEFE_PLANTA As String
        Get
            Return mOBSERVACION_JEFE_PLANTA
        End Get
        Set(value As String)
            mOBSERVACION_JEFE_PLANTA = value
        End Set
    End Property

    Public Property USUARIO_VB_RH As String
        Get
            Return mUSUARIO_VB_RH
        End Get
        Set(value As String)
            mUSUARIO_VB_RH = value
        End Set
    End Property

    Public Property LINEA As String
        Get
            Return mLINEA
        End Get
        Set(value As String)
            mLINEA = value
        End Set
    End Property

    Public Property PRDO As String
        Get
            Return mPRDO
        End Get
        Set(value As String)
            mPRDO = value
        End Set
    End Property

    Public Property OBSERVACION_JEFE As String
        Get
            Return mOBSERVACION_JEFE
        End Get
        Set(value As String)
            mOBSERVACION_JEFE = value
        End Set
    End Property
End Class
