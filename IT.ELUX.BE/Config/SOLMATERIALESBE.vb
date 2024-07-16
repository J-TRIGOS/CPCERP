Public Class SOLMATERIALESBE
    'Campos de la entidad
    Private mSER_DOC_REF As String
    Private mT_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mFEC_GENE As Date
    Private mUNIDAD As String
    Private mEST As String
    Private mEST1 As String
    Private mFEC_ANU As Date
    Private mUSUARIO As String
    Private mUSUARIO_VB As String
    Private mUSUARIO_OB As String
    Private mUSUARIO_ATENCION As String
    Private mOBSERVA As String
    Private mFEC_DIA As Date
    Private mCCO_COD As String
    Private mNRO_DOCU As String
    Private mVB As String
    Private mVB_ATENDIDO As String
    Private mLINEA As String
    Private mNRO_ORDEN As String
    Private mSER_ORDEN As String
    Private mUSUARIO_SOL As String
    Private mART_COD As String
    Private mSER_DOC_REF1 As String
    Private mT_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String
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
    Public Property FEC_ANU() As Date
        Get
            Return mFEC_ANU
        End Get
        Set(ByVal value As Date)
            mFEC_ANU = value
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
    Public Property USUARIO_VB() As String
        Get
            Return mUSUARIO_VB
        End Get
        Set(ByVal value As String)
            mUSUARIO_VB = value
        End Set
    End Property
    Public Property USUARIO_ATENCION() As String
        Get
            Return mUSUARIO_ATENCION
        End Get
        Set(ByVal value As String)
            mUSUARIO_ATENCION = value
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
    Public Property OBSERVA() As String
        Get
            Return mOBSERVA
        End Get
        Set(ByVal value As String)
            mOBSERVA = value
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
    Public Property EST1() As String
        Get
            Return mEST1
        End Get
        Set(ByVal value As String)
            mEST1 = value
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

    Public Property NRO_DOCU() As String
        Get
            Return mNRO_DOCU
        End Get
        Set(ByVal value As String)
            mNRO_DOCU = value
        End Set
    End Property
    Public Property VB() As String
        Get
            Return mVB
        End Get
        Set(ByVal value As String)
            mVB = value
        End Set
    End Property
    Public Property VB_ATENDIDO() As String
        Get
            Return mVB_ATENDIDO
        End Get
        Set(ByVal value As String)
            mVB_ATENDIDO = value
        End Set
    End Property
    Public Property LINEA() As String
        Get
            Return mLINEA
        End Get
        Set(ByVal value As String)
            mLINEA = value
        End Set
    End Property

    Public Property NRO_ORDEN As String
        Get
            Return mNRO_ORDEN
        End Get
        Set(value As String)
            mNRO_ORDEN = value
        End Set
    End Property

    Public Property SER_ORDEN As String
        Get
            Return mSER_ORDEN
        End Get
        Set(value As String)
            mSER_ORDEN = value
        End Set
    End Property

    Public Property USUARIO_SOL As String
        Get
            Return mUSUARIO_SOL
        End Get
        Set(value As String)
            mUSUARIO_SOL = value
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
    Public Property SER_DOC_REF1() As String
        Get
            Return mSER_DOC_REF1
        End Get
        Set(ByVal value As String)
            mSER_DOC_REF1 = value
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
    Public Property NRO_DOC_REF1() As String
        Get
            Return mNRO_DOC_REF1
        End Get
        Set(ByVal value As String)
            mNRO_DOC_REF1 = value
        End Set
    End Property
End Class
