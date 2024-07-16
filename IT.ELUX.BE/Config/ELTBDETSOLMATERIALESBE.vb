Public Class ELTBDETSOLMATERIALESBE
    Private mSER_DOC_REF As String
    Private mT_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mSER_DOC_REF1 As String
    Private mT_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String
    Private mART_COD As String
    Private mCANTIDAD As Double
    Private mOBSERVA As String
    Private mUNIDAD As String
    Private mCANTIDAD2 As Double
    Private mCANTIDAD3 As Double
    Private mFEC_GENE As Date
    Private mEST As String
    Private mFEC_ATENDIDA As Date
    Private mUSUARIO As String
    Private mUSUARIO_ATENCION As String
    Private mFEC_ANU As Date
    Private mACT_COD As String
    Private mEST1 As String
    Private mART_ACT As String
    Private mX_EST As String
    Private mCCO_COD As String
    Private mLINEA As String

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
    Public Property ART_COD() As String
        Get
            Return mART_COD
        End Get
        Set(ByVal value As String)
            mART_COD = value
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

    Public Property OBSERVA() As String
        Get
            Return mOBSERVA
        End Get
        Set(ByVal value As String)
            mOBSERVA = value
        End Set
    End Property

    Public Property CANTIDAD() As String
        Get
            Return mCANTIDAD
        End Get
        Set(ByVal value As String)
            mCANTIDAD = value
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

    Public Property EST1 As String
        Get
            Return mEST1
        End Get
        Set(value As String)
            mEST1 = value
        End Set
    End Property

    Public Property ART_ACT As String
        Get
            Return mART_ACT
        End Get
        Set(value As String)
            mART_ACT = value
        End Set
    End Property

    Public Property X_EST As String
        Get
            Return mX_EST
        End Get
        Set(value As String)
            mX_EST = value
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

    Public Property CCO_COD As String
        Get
            Return mCCO_COD
        End Get
        Set(value As String)
            mCCO_COD = value
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
End Class
