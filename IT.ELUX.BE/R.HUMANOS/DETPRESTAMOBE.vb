Public Class DETPRESTAMOBE
    Private mTIPO_DOC As String
    Private mSER_DOC As String
    Private mNUM_DOC As String
    Private mCUOTA As String
    Private mPER_COD As String
    Private mMONTO As String
    Private mFEC_GENE As String
    Private mPRDO As String
    Private mEST As String
    Private mTIPO As String

    Public Property TIPO As String
        Get
            Return mTIPO
        End Get
        Set(value As String)
            mTIPO = value
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
    Public Property CUOTA As String
        Get
            Return mCUOTA
        End Get
        Set(value As String)
            mCUOTA = value
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
    Public Property SER_DOC As String
        Get
            Return mSER_DOC
        End Get
        Set(value As String)
            mSER_DOC = value
        End Set
    End Property
    Public Property NUM_DOC As String
        Get
            Return mNUM_DOC
        End Get
        Set(value As String)
            mNUM_DOC = value
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
    Public Property MONTO As String
        Get
            Return mMONTO
        End Get
        Set(value As String)
            mMONTO = value
        End Set
    End Property
    Public Property FEC_GENE As String
        Get
            Return mFEC_GENE
        End Get
        Set(value As String)
            mFEC_GENE = value
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

End Class
