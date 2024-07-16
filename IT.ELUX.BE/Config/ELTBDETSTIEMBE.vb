Public Class ELTBDETSTIEMBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mT_DOC_REF1 As String
    Private mSER_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String
    Private mFEC_INICIO As Date
    Private mFEC_TERMINO As Date
    Private mHORA_GENE As String
    Private mHORA_TERMINO As String
    Private mACT_REALIZAR As String
    Private mDIF_HORA As String
    Private mPER_COD As String
    Private mUSUARIO_OB As String
    Private mUSUARIO_VB As String
    Private mUSUARIO_RP As String
    Private mFEC_GENE As Date
    Private mEST As String
    Private mEST1 As String
    Private mNUM As Double
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
    Public Property T_DOC_REF1() As String
        Get
            Return mT_DOC_REF1
        End Get
        Set(ByVal value As String)
            mT_DOC_REF1 = value
        End Set
    End Property
    Public Property SER_DOC_REF1() As String
        Get
            Return mSER_DOC_REF1
        End Get
        Set(ByVal value As String)
            mSER_DOC_REF1 = value
        End Set
    End Property
    Public Property NRO_DOC_REF1() As String
        Get
            Return mNRO_DOC_REF1
        End Get
        Set(ByVal value As String)
            mNRO_DOC_REF1 = value
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
    Public Property FEC_GENE() As Date
        Get
            Return mFEC_GENE
        End Get
        Set(ByVal value As Date)
            mFEC_GENE = value
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
    Public Property EST1() As String
        Get
            Return mEST1
        End Get
        Set(ByVal value As String)
            mEST1 = value
        End Set
    End Property

    Public Property NUM As Double
        Get
            Return mNUM
        End Get
        Set(value As Double)
            mNUM = value
        End Set
    End Property
End Class
