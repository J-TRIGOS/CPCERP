Public Class REPORTE_DETTRABAJOBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mT_DOC_REF1 As String
    Private mSER_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String

    Private mSEQ As String
    Private mCCO_COD As String
    Private mART_COD As String
    Private mLINEA As String
    Private mDESC_TRA As String

    Private mHORA_INICIO As String
    Private mHORA_FINAL As String
    Private mNUM_HORA As String
    Private mNUM_HORA_1 As String
    Private mFEC_INICIO As Date
    Private mFEC_TERMINO As Date
    Private mTIP_COD As String
    Private mFINALIZAR As String
    Private mINTERVENCION As String

    Private mHORA_INI As Date
    Private mHORA_FIN As Date

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

    Public Property SEQ As String
        Get
            Return mSEQ
        End Get
        Set(value As String)
            mSEQ = value
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
    Public Property ART_COD As String
        Get
            Return mART_COD
        End Get
        Set(value As String)
            mART_COD = value
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
    Public Property DESC_TRA As String
        Get
            Return mDESC_TRA
        End Get
        Set(value As String)
            mDESC_TRA = value
        End Set
    End Property
    Public Property HORA_INICIO As String
        Get
            Return mHORA_INICIO
        End Get
        Set(value As String)
            mHORA_INICIO = value
        End Set
    End Property
    Public Property HORA_FINAL As String
        Get
            Return mHORA_FINAL
        End Get
        Set(value As String)
            mHORA_FINAL = value
        End Set
    End Property
    Public Property NUM_HORA As String
        Get
            Return mNUM_HORA
        End Get
        Set(value As String)
            mNUM_HORA = value
        End Set
    End Property
    Public Property NUM_HORA_1 As Date
        Get
            Return mNUM_HORA_1
        End Get
        Set(value As Date)
            mNUM_HORA_1 = value
        End Set
    End Property
    Public Property FEC_INICIO As Date
        Get
            Return mFEC_INICIO
        End Get
        Set(value As Date)
            mFEC_INICIO = value
        End Set
    End Property
    Public Property FEC_TERMINO As Date
        Get
            Return mFEC_TERMINO
        End Get
        Set(value As Date)
            mFEC_TERMINO = value
        End Set
    End Property
    Public Property TIP_COD As String
        Get
            Return mTIP_COD
        End Get
        Set(value As String)
            mTIP_COD = value
        End Set
    End Property

    Public Property FINALIZAR As String
        Get
            Return mFINALIZAR
        End Get
        Set(value As String)
            mFINALIZAR = value
        End Set
    End Property

    Public Property INTERVENCION As String
        Get
            Return mINTERVENCION
        End Get
        Set(value As String)
            mINTERVENCION = value
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
End Class
