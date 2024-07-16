Public Class BINDCARDBE
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mART_COD As String
    Private mDESC_ART As String
    Private mCANTIDAD As String
    Private mBULTOS As String
    Private mFEC_GENE As String
    Private mEST As String
    Private mUSUARIO As String
    Private mMEDIDA As String
    Private mTIPOGUIA As String
    Private mSERIEGUIA As String
    Private mNUMGUIA As String

    Public Property TIPOGUIA As String
        Get
            Return mTIPOGUIA
        End Get
        Set(value As String)
            mTIPOGUIA = value
        End Set
    End Property
    Public Property SERIEGUIA As String
        Get
            Return mSERIEGUIA
        End Get
        Set(value As String)
            mSERIEGUIA = value
        End Set
    End Property
    Public Property NUMGUIA As String
        Get
            Return mNUMGUIA
        End Get
        Set(value As String)
            mNUMGUIA = value
        End Set
    End Property

    Public Property MEDIDA As String
        Get
            Return mMEDIDA
        End Get
        Set(value As String)
            mMEDIDA = value
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

    Public Property ART_COD As String
        Get
            Return mART_COD
        End Get
        Set(value As String)
            mART_COD = value
        End Set
    End Property

    Public Property DESC_ART As String
        Get
            Return mDESC_ART
        End Get
        Set(value As String)
            mDESC_ART = value
        End Set
    End Property

    Public Property CANTIDAD As String
        Get
            Return mCANTIDAD
        End Get
        Set(value As String)
            mCANTIDAD = value
        End Set
    End Property

    Public Property BULTOS As String
        Get
            Return mBULTOS
        End Get
        Set(value As String)
            mBULTOS = value
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

    Public Property USUARIO As String
        Get
            Return mUSUARIO
        End Get
        Set(value As String)
            mUSUARIO = value
        End Set
    End Property
End Class
