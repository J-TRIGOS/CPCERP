Public Class ELTBEVALUACIONBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mT_DOC_REF1 As String
    Private mSER_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String
    Private mEVALUADOR As String
    Private mOBSERVA As String
    Private mEST As String
    Private mFECHA As Date
    Private mFEC_GENE As Date
    Private mFEC_DIA As Date
    Private mFEC_ANU As Date
    Private mPER_COD As String
    Private mRPTA1 As String
    Private mRPTA2 As String
    Private mRPTA3 As String
    Private mEVA_CAPA As String
    Private mENT_CAPA As String
    Private mCAPA_NUE As String
    Private mSURGERENCIA As String
    Private mCOMENTARIOS As String
    Private mNOT_CAPA As String
    Private mNOT_EVA As String

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

    Public Property EVALUADOR As String
        Get
            Return mEVALUADOR
        End Get
        Set(value As String)
            mEVALUADOR = value
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

    Public Property FECHA As Date
        Get
            Return mFECHA
        End Get
        Set(value As Date)
            mFECHA = value
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

    Public Property FEC_DIA As Date
        Get
            Return mFEC_DIA
        End Get
        Set(value As Date)
            mFEC_DIA = value
        End Set
    End Property

    Public Property FEC_ANU As Date
        Get
            Return mFEC_ANU
        End Get
        Set(value As Date)
            mFEC_ANU = value
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

    Public Property RPTA1 As String
        Get
            Return mRPTA1
        End Get
        Set(value As String)
            mRPTA1 = value
        End Set
    End Property

    Public Property RPTA2 As String
        Get
            Return mRPTA2
        End Get
        Set(value As String)
            mRPTA2 = value
        End Set
    End Property

    Public Property RPTA3 As String
        Get
            Return mRPTA3
        End Get
        Set(value As String)
            mRPTA3 = value
        End Set
    End Property

    Public Property EVA_CAPA As String
        Get
            Return mEVA_CAPA
        End Get
        Set(value As String)
            mEVA_CAPA = value
        End Set
    End Property

    Public Property ENT_CAPA As String
        Get
            Return mENT_CAPA
        End Get
        Set(value As String)
            mENT_CAPA = value
        End Set
    End Property

    Public Property CAPA_NUE As String
        Get
            Return mCAPA_NUE
        End Get
        Set(value As String)
            mCAPA_NUE = value
        End Set
    End Property

    Public Property SURGERENCIA As String
        Get
            Return mSURGERENCIA
        End Get
        Set(value As String)
            mSURGERENCIA = value
        End Set
    End Property

    Public Property COMENTARIOS As String
        Get
            Return mCOMENTARIOS
        End Get
        Set(value As String)
            mCOMENTARIOS = value
        End Set
    End Property

    Public Property NOT_CAPA As String
        Get
            Return mNOT_CAPA
        End Get
        Set(value As String)
            mNOT_CAPA = value
        End Set
    End Property

    Public Property NOT_EVA As String
        Get
            Return mNOT_EVA
        End Get
        Set(value As String)
            mNOT_EVA = value
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
