Public Class PARCIALBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mART_COD As String
    Private mCANTIDAD As Double
    Private mFEC_ENT As Date
    Private mEST As String

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

    Public Property ART_COD As String
        Get
            Return mART_COD
        End Get
        Set(value As String)
            mART_COD = value
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

    Public Property FEC_ENT As Date
        Get
            Return mFEC_ENT
        End Get
        Set(value As Date)
            mFEC_ENT = value
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
