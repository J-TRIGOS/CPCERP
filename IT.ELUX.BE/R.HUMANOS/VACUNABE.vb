Public Class VACUNABE
    Private mPER_COD As String
    Private mEMPLEADO As String
    Private mDOSIS As String
    Private mFEC_VACUNA As String
    Private mLABORATORIO As String
    Private mLUGAR As String

    Public Property PER_COD As String
        Get
            Return mPER_COD
        End Get
        Set(value As String)
            mPER_COD = value
        End Set
    End Property

    Public Property EMPLEADO As String
        Get
            Return mEMPLEADO
        End Get
        Set(value As String)
            mEMPLEADO = value
        End Set
    End Property

    Public Property DOSIS As String
        Get
            Return mDOSIS
        End Get
        Set(value As String)
            mDOSIS = value
        End Set
    End Property

    Public Property FEC_VACUNA As String
        Get
            Return mFEC_VACUNA
        End Get
        Set(value As String)
            mFEC_VACUNA = value
        End Set
    End Property

    Public Property LABORATORIO As String
        Get
            Return mLABORATORIO
        End Get
        Set(value As String)
            mLABORATORIO = value
        End Set
    End Property

    Public Property LUGAR As String
        Get
            Return mLUGAR
        End Get
        Set(value As String)
            mLUGAR = value
        End Set
    End Property
End Class
