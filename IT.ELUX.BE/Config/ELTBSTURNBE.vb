Public Class ELTBSTURNBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mTIPO As String
    Private mEST As String
    Private mPER_COD As String
    Private mCCO_COD As String
    Private mF_INI As Date
    Private mF_FIN As Date
    Private mF_GENE As Date
    Private mSEM_ANHO As String
    Private mUSUARIO_RP As String
    Private mTITULO As String
    Private mOBSERVA As String

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

    Public Property TIPO As String
        Get
            Return mTIPO
        End Get
        Set(value As String)
            mTIPO = value
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

    Public Property PER_COD As String
        Get
            Return mPER_COD
        End Get
        Set(value As String)
            mPER_COD = value
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

    Public Property F_INI As Date
        Get
            Return mF_INI
        End Get
        Set(value As Date)
            mF_INI = value
        End Set
    End Property

    Public Property F_FIN As Date
        Get
            Return mF_FIN
        End Get
        Set(value As Date)
            mF_FIN = value
        End Set
    End Property
    Public Property F_GENE As Date
        Get
            Return mF_GENE
        End Get
        Set(value As Date)
            mF_GENE = value
        End Set
    End Property

    Public Property SEM_ANHO As String
        Get
            Return mSEM_ANHO
        End Get
        Set(value As String)
            mSEM_ANHO = value
        End Set
    End Property

    Public Property USUARIO_RP As String
        Get
            Return mUSUARIO_RP
        End Get
        Set(value As String)
            mUSUARIO_RP = value
        End Set
    End Property

    Public Property TITULO As String
        Get
            Return mTITULO
        End Get
        Set(value As String)
            mTITULO = value
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
End Class
