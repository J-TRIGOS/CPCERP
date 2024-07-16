Public Class ELTBTURNOBE
    Private mPER_COD As String
    Private mFEC_INICIO As Date
    Private mFEC_FIN As Date
    Private mMES As String
    Private mEST As String
    Private mUSUARIO As String
    Private mINDICE As String

    Public Property PER_COD As String
        Get
            Return mPER_COD
        End Get
        Set(value As String)
            mPER_COD = value
        End Set
    End Property

    Public Property FEC_INICIO As Date
        Get
            Return mFEC_INICIO
        End Get
        Set(value As Date)
            mFEC_INICIO = value
        End Set
    End Property

    Public Property FEC_FIN As Date
        Get
            Return mFEC_FIN
        End Get
        Set(value As Date)
            mFEC_FIN = value
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

    Public Property INDICE As String
        Get
            Return mINDICE
        End Get
        Set(value As String)
            mINDICE = value
        End Set
    End Property
End Class
