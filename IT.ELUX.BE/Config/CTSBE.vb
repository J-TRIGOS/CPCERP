Public Class CTSBE
    Private mPER_COD As String
    Private mUSUARIO As String
    Private mANHO As String
    Private mMONTO As Double
    Private mMES As String
    Private mHEXTRAS As Double
    Private mGRATI As Double
    Private mMESES As Double
    Private mDIAS As Double
    Private mNOMBRE As String
    Private mINTERES As Double
    Private mPRDO_PAGO As Double
    Private mVACACIONES As Double
    Private mMONTO_CTS As Double
    Private mCOMISION As Double
    Private mSUBSIDIO As Double
    Private mOTROS As Double
    Private mFEC_INI As Date
    Private mFEC_FIN As Date
    Private mDSCTO_QUINTA As Double
    Private mOTROS_DSCTOS As Double
    Private mPROV_ACUM_CTS As Double
    Private mPROV_ACUM_VACA As Double
    Private mPROV_ACUM_GRATI As Double
    Private mDIF_AJUSTE_CTS As Double
    Private mDIF_AJUSTE_GRATI As Double
    Private mDIF_AJUSTE_VACA As Double
    Private mMONTO_PREST As Double

    Public Property PER_COD As String
        Get
            Return mPER_COD
        End Get
        Set(value As String)
            mPER_COD = value
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

    Public Property ANHO As String
        Get
            Return mANHO
        End Get
        Set(value As String)
            mANHO = value
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

    Public Property MES As String
        Get
            Return mMES
        End Get
        Set(value As String)
            mMES = value
        End Set
    End Property

    Public Property HEXTRAS As Double
        Get
            Return mHEXTRAS
        End Get
        Set(value As Double)
            mHEXTRAS = value
        End Set
    End Property

    Public Property GRATI As Double
        Get
            Return mGRATI
        End Get
        Set(value As Double)
            mGRATI = value
        End Set
    End Property

    Public Property MESES As Double
        Get
            Return mMESES
        End Get
        Set(value As Double)
            mMESES = value
        End Set
    End Property

    Public Property DIAS As Double
        Get
            Return mDIAS
        End Get
        Set(value As Double)
            mDIAS = value
        End Set
    End Property

    Public Property NOMBRE As String
        Get
            Return mNOMBRE
        End Get
        Set(value As String)
            mNOMBRE = value
        End Set
    End Property

    Public Property INTERES As Double
        Get
            Return mINTERES
        End Get
        Set(value As Double)
            mINTERES = value
        End Set
    End Property

    Public Property PRDO_PAGO As Double
        Get
            Return mPRDO_PAGO
        End Get
        Set(value As Double)
            mPRDO_PAGO = value
        End Set
    End Property

    Public Property VACACIONES As Double
        Get
            Return mVACACIONES
        End Get
        Set(value As Double)
            mVACACIONES = value
        End Set
    End Property

    Public Property MONTO_CTS As Double
        Get
            Return mMONTO_CTS
        End Get
        Set(value As Double)
            mMONTO_CTS = value
        End Set
    End Property

    Public Property COMISION As Double
        Get
            Return mCOMISION
        End Get
        Set(value As Double)
            mCOMISION = value
        End Set
    End Property

    Public Property SUBSIDIO As Double
        Get
            Return mSUBSIDIO
        End Get
        Set(value As Double)
            mSUBSIDIO = value
        End Set
    End Property

    Public Property OTROS As Double
        Get
            Return mOTROS
        End Get
        Set(value As Double)
            mOTROS = value
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

    Public Property DSCTO_QUINTA As Double
        Get
            Return mDSCTO_QUINTA
        End Get
        Set(value As Double)
            mDSCTO_QUINTA = value
        End Set
    End Property

    Public Property OTROS_DSCTOS As Double
        Get
            Return mOTROS_DSCTOS
        End Get
        Set(value As Double)
            mOTROS_DSCTOS = value
        End Set
    End Property

    Public Property PROV_ACUM_CTS As Double
        Get
            Return mPROV_ACUM_CTS
        End Get
        Set(value As Double)
            mPROV_ACUM_CTS = value
        End Set
    End Property

    Public Property PROV_ACUM_VACA As Double
        Get
            Return mPROV_ACUM_VACA
        End Get
        Set(value As Double)
            mPROV_ACUM_VACA = value
        End Set
    End Property

    Public Property PROV_ACUM_GRATI As Double
        Get
            Return mPROV_ACUM_GRATI
        End Get
        Set(value As Double)
            mPROV_ACUM_GRATI = value
        End Set
    End Property

    Public Property DIF_AJUSTE_CTS As Double
        Get
            Return mDIF_AJUSTE_CTS
        End Get
        Set(value As Double)
            mDIF_AJUSTE_CTS = value
        End Set
    End Property

    Public Property DIF_AJUSTE_GRATI As Double
        Get
            Return mDIF_AJUSTE_GRATI
        End Get
        Set(value As Double)
            mDIF_AJUSTE_GRATI = value
        End Set
    End Property

    Public Property DIF_AJUSTE_VACA As Double
        Get
            Return mDIF_AJUSTE_VACA
        End Get
        Set(value As Double)
            mDIF_AJUSTE_VACA = value
        End Set
    End Property

    Public Property MONTO_PREST As Double
        Get
            Return mMONTO_PREST
        End Get
        Set(value As Double)
            mMONTO_PREST = value
        End Set
    End Property
End Class
