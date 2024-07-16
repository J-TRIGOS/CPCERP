Public Class ELTBPLANILLAVWBE
    Private mCARGO As String
    Private mCCO_COD As String
    Private mCOD_UBI As String
    Private mCPTO_COD As String
    Private mDIAS_DSCTO As Double
    Private mHORAS_EXTRAS As Double
    Private mHORAS_NORMALES As Double
    Private mLINEA_COD As String
    Private mMONTO As Double
    Private mNN As String
    Private mNOM_TPAGO As String
    Private mPER_COD As String
    Private mPRDO_COD As Integer
    Private mSBASICO As Double
    Private mT_CPTO As String
    Private mT_IMPRES As Double
    Private mT_PAGO As String

    Public Property CARGO As String
        Get
            Return mCARGO
        End Get
        Set(value As String)
            mCARGO = value
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

    Public Property COD_UBI As String
        Get
            Return mCOD_UBI
        End Get
        Set(value As String)
            mCOD_UBI = value
        End Set
    End Property

    Public Property CPTO_COD As String
        Get
            Return mCPTO_COD
        End Get
        Set(value As String)
            mCPTO_COD = value
        End Set
    End Property

    Public Property DIAS_DSCTO As Double
        Get
            Return mDIAS_DSCTO
        End Get
        Set(value As Double)
            mDIAS_DSCTO = value
        End Set
    End Property

    Public Property HORAS_EXTRAS As Double
        Get
            Return mHORAS_EXTRAS
        End Get
        Set(value As Double)
            mHORAS_EXTRAS = value
        End Set
    End Property

    Public Property HORAS_NORMALES As Double
        Get
            Return mHORAS_NORMALES
        End Get
        Set(value As Double)
            mHORAS_NORMALES = value
        End Set
    End Property

    Public Property LINEA_COD As String
        Get
            Return mLINEA_COD
        End Get
        Set(value As String)
            mLINEA_COD = value
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

    Public Property NN As String
        Get
            Return mNN
        End Get
        Set(value As String)
            mNN = value
        End Set
    End Property

    Public Property NOM_TPAGO As String
        Get
            Return mNOM_TPAGO
        End Get
        Set(value As String)
            mNOM_TPAGO = value
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

    Public Property PRDO_COD As Integer
        Get
            Return mPRDO_COD
        End Get
        Set(value As Integer)
            mPRDO_COD = value
        End Set
    End Property

    Public Property SBASICO As Double
        Get
            Return mSBASICO
        End Get
        Set(value As Double)
            mSBASICO = value
        End Set
    End Property

    Public Property T_CPTO As String
        Get
            Return mT_CPTO
        End Get
        Set(value As String)
            mT_CPTO = value
        End Set
    End Property

    Public Property T_IMPRES As Double
        Get
            Return mT_IMPRES
        End Get
        Set(value As Double)
            mT_IMPRES = value
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
