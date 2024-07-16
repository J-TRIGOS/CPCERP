Public Class MEMOBE
    Private mNRO_DOC As String
    Private mMES As String
    Private mANHO As String
    Private mFEC_GENE As String
    Private mPER_COD As String
    Private mNOM_EMP As String
    Private mCCO_COD As String
    Private mTIPO_MEMO As String
    Private mMOT_MEMO As String
    Private mDIA_SUSP As String
    Private mFEC_INISUS As String
    Private mFEC_FINSUS As String
    Private mFEC_FALTA As String
    Private mCOD_SANCION As String

    Public Property NRO_DOC As String
        Get
            Return mNRO_DOC
        End Get
        Set(value As String)
            mNRO_DOC = value
        End Set
    End Property

    Public Property MES As String
        Get
            Return mMES
        End Get
        Set(value As String)
            mMES = value
        End Set
    End Property

    Public Property ANHO As String
        Get
            Return mANHO
        End Get
        Set(value As String)
            mANHO = value
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

    Public Property PER_COD As String
        Get
            Return mPER_COD
        End Get
        Set(value As String)
            mPER_COD = value
        End Set
    End Property

    Public Property NOM_EMP As String
        Get
            Return mNOM_EMP
        End Get
        Set(value As String)
            mNOM_EMP = value
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

    Public Property TIPO_MEMO As String
        Get
            Return mTIPO_MEMO
        End Get
        Set(value As String)
            mTIPO_MEMO = value
        End Set
    End Property

    Public Property MOT_MEMO As String
        Get
            Return mMOT_MEMO
        End Get
        Set(value As String)
            mMOT_MEMO = value
        End Set
    End Property

    Public Property DIA_SUSP As String
        Get
            Return mDIA_SUSP
        End Get
        Set(value As String)
            mDIA_SUSP = value
        End Set
    End Property

    Public Property FEC_INISUS As String
        Get
            Return mFEC_INISUS
        End Get
        Set(value As String)
            mFEC_INISUS = value
        End Set
    End Property

    Public Property FEC_FINSUS As String
        Get
            Return mFEC_FINSUS
        End Get
        Set(value As String)
            mFEC_FINSUS = value
        End Set
    End Property

    Public Property FEC_FALTA As String
        Get
            Return mFEC_FALTA
        End Get
        Set(value As String)
            mFEC_FALTA = value
        End Set
    End Property

    Public Property COD_SANCION As String
        Get
            Return mCOD_SANCION
        End Get
        Set(value As String)
            mCOD_SANCION = value
        End Set
    End Property
End Class
