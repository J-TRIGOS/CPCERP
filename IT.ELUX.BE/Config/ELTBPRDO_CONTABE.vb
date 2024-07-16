Public Class ELTBPRDO_CONTABE
    Private mCOD As String
    Private mANHO As String
    Private mFEC_INI As Date
    Private mFEC_FIN As Date
    Private mNROMES As String
    Private mNROANT As Double
    Private mX_CONT As String
    Private mFEC_CIERRE As Date

    Public Property COD As String
        Get
            Return mCOD
        End Get
        Set(value As String)
            mCOD = value
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

    Public Property FEC_INI As Date
        Get
            Return mFEC_INI
        End Get
        Set(value As Date)
            mFEC_INI = value
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

    Public Property NROMES As String
        Get
            Return mNROMES
        End Get
        Set(value As String)
            mNROMES = value
        End Set
    End Property

    Public Property NROANT As Double
        Get
            Return mNROANT
        End Get
        Set(value As Double)
            mNROANT = value
        End Set
    End Property

    Public Property X_CONT As String
        Get
            Return mX_CONT
        End Get
        Set(value As String)
            mX_CONT = value
        End Set
    End Property

    Public Property FEC_CIERRE As Date
        Get
            Return mFEC_CIERRE
        End Get
        Set(value As Date)
            mFEC_CIERRE = value
        End Set
    End Property
End Class
