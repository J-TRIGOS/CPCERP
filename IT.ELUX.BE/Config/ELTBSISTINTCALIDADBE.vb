Public Class ELTBSISTINTCALIDADBE
    Dim mT_DOC_REF As String
    Dim mSER_DOC_REF As String
    Dim mNRO_DOC_REF As String
    Dim mFEC_GENE As Date
    Dim mESTADO As String
    Dim mCODIFICACION As String
    Dim mTEMA As String
    Dim mCCO As String
    Dim mNOMPDF As String
    Dim mFORMATO As String

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

    Public Property FEC_GENE As Date
        Get
            Return mFEC_GENE
        End Get
        Set(value As Date)
            mFEC_GENE = value
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

    Public Property CODIFICACION As String
        Get
            Return mCODIFICACION
        End Get
        Set(value As String)
            mCODIFICACION = value
        End Set
    End Property

    Public Property TEMA As String
        Get
            Return mTEMA
        End Get
        Set(value As String)
            mTEMA = value
        End Set
    End Property

    Public Property CCO As String
        Get
            Return mCCO
        End Get
        Set(value As String)
            mCCO = value
        End Set
    End Property

    Public Property NOMPDF As String
        Get
            Return mNOMPDF
        End Get
        Set(value As String)
            mNOMPDF = value
        End Set
    End Property

    Public Property FORMATO As String
        Get
            Return mFORMATO
        End Get
        Set(value As String)
            mFORMATO = value
        End Set
    End Property
End Class
