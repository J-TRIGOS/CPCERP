Public Class ELTBRECEPCOMPBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mFEC_GENE As Date
    Private mUSUARIO As String
    Private mOBSERVA As String
    Private mNRO_DOCU As String


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

    Public Property USUARIO As String
        Get
            Return mUSUARIO
        End Get
        Set(value As String)
            mUSUARIO = value
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

    Public Property NRO_DOCU As String
        Get
            Return mNRO_DOCU
        End Get
        Set(value As String)
            mNRO_DOCU = value
        End Set
    End Property

End Class
