Public Class ELTBDETGUIABE
    Dim mT_DOC_REF As String
    Dim mSER_DOC_REF As String
    Dim mNRO_DOC_REF As String
    Dim mT_DOC_REF1 As String
    Dim mSER_DOC_REF1 As String
    Dim mNRO_DOC_REF1 As String
    Dim mART_COD As String
    Dim mCOD_FAR As String
    Dim mCANTIDAD As Double
    Dim mFEC_GENE As Date
    Dim mPESO_NETO As Double
    Dim mPESO_BRUTO As Double
    Dim mHOJAS As String
    Dim mESTADO As String
    Dim mCFardo As String


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

    Public Property ART_COD As String
        Get
            Return mART_COD
        End Get
        Set(value As String)
            mART_COD = value
        End Set
    End Property
    Public Property COD_FAR As String
        Get
            Return mCOD_FAR
        End Get
        Set(value As String)
            mCOD_FAR = value
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
    Public Property FEC_GENE As Date
        Get
            Return mFEC_GENE
        End Get
        Set(value As Date)
            mFEC_GENE = value
        End Set
    End Property

    Public Property PESO_NETO As Double
        Get
            Return mPESO_NETO
        End Get
        Set(value As Double)
            mPESO_NETO = value
        End Set
    End Property

    Public Property PESO_BRUTO As Double
        Get
            Return mPESO_BRUTO
        End Get
        Set(value As Double)
            mPESO_BRUTO = value
        End Set
    End Property

    Public Property HOJAS As String
        Get
            Return mHOJAS
        End Get
        Set(value As String)
            mHOJAS = value
        End Set
    End Property
    Public Property ESTADO As String
        Get
            Return mESTADO
        End Get
        Set(value As String)
            mESTADO = value
        End Set
    End Property
    Public Property CFardo As String
        Get
            Return mCFardo
        End Get
        Set(value As String)
            mCFardo = value
        End Set
    End Property

End Class
