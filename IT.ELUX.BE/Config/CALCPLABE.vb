Public Class CALCPLABE
    Private mPER_COD As String
    Private mMONTO As Double
    Private mCPTO As String
    Private mFEC As Date
    Private mPRDO As String
    Private mT_PAGO As String

    Public Property PER_COD As String
        Get
            Return mPER_COD
        End Get
        Set(value As String)
            mPER_COD = value
        End Set
    End Property

    Public Property MONTO As Double
        Get
            Return mMONTO
        End Get
        Set(value As Double)
            mMONTO = value
        End Set
    End Property

    Public Property CPTO As String
        Get
            Return mCPTO
        End Get
        Set(value As String)
            mCPTO = value
        End Set
    End Property

    Public Property FEC As Date
        Get
            Return mFEC
        End Get
        Set(value As Date)
            mFEC = value
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

    Public Property T_PAGO As String
        Get
            Return mT_PAGO
        End Get
        Set(value As String)
            mT_PAGO = value
        End Set
    End Property
End Class
