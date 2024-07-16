Public Class ELTBORDENPROGRAMABE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mART_COD As String
    Private mDESCRI As String
    Private mFORMATO As String
    Private mESP_CUE As Double
    Private mESP_FON As Double
    Private mALT_CIE_F_MN As Double
    Private mALT_CIE_F_MX As Double
    Private mLON_CUE_F_MN As Double
    Private mLON_CUE_F_MX As Double
    Private mLON_FON_MIN As Double
    Private mLON_FON_MAX As Double
    Private mESP_ANI As Double
    Private mALT_CIE_A_MIN As Double
    Private mALT_CIE_A_MAX As Double
    Private mLON_CUE_A_MIN As Double
    Private mLON_CUE_A_MAX As Double
    Private mLON_ANI_MIN As Double
    Private mLON_ANI_MAX As Double
    Private mALT_TER_MIN As Double
    Private mALT_TER_MAX As Double
    Private mALT_ORE_MIN As Double
    Private mALT_ORE_MAX As Double
    Private mENV_TER_MIN As Double
    Private mENV_TER_MAX As Double
    Private mCUE_TAP_MIN As Double
    Private mCUE_TAP_MAX As Double
    Private mFEC_GENE As Date
    Private mEST As String
    Private mART_COD1 As String

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

    Public Property DESCRI As String
        Get
            Return mDESCRI
        End Get
        Set(value As String)
            mDESCRI = value
        End Set
    End Property

    Public Property FORMATO As String
        Get
            Return mFORMATO
        End Get
        Set(value As String)
            mFORMATO = value
        End Set
    End Property

    Public Property ESP_CUE As Double
        Get
            Return mESP_CUE
        End Get
        Set(value As Double)
            mESP_CUE = value
        End Set
    End Property

    Public Property ESP_FON As Double
        Get
            Return mESP_FON
        End Get
        Set(value As Double)
            mESP_FON = value
        End Set
    End Property

    Public Property ALT_CIE_F_MN As Double
        Get
            Return mALT_CIE_F_MN
        End Get
        Set(value As Double)
            mALT_CIE_F_MN = value
        End Set
    End Property

    Public Property ALT_CIE_F_MX As Double
        Get
            Return mALT_CIE_F_MX
        End Get
        Set(value As Double)
            mALT_CIE_F_MX = value
        End Set
    End Property

    Public Property LON_CUE_F_MN As Double
        Get
            Return mLON_CUE_F_MN
        End Get
        Set(value As Double)
            mLON_CUE_F_MN = value
        End Set
    End Property

    Public Property LON_CUE_F_MX As Double
        Get
            Return mLON_CUE_F_MX
        End Get
        Set(value As Double)
            mLON_CUE_F_MX = value
        End Set
    End Property

    Public Property LON_FON_MIN As Double
        Get
            Return mLON_FON_MIN
        End Get
        Set(value As Double)
            mLON_FON_MIN = value
        End Set
    End Property

    Public Property LON_FON_MAX As Double
        Get
            Return mLON_FON_MAX
        End Get
        Set(value As Double)
            mLON_FON_MAX = value
        End Set
    End Property

    Public Property ESP_ANI As Double
        Get
            Return mESP_ANI
        End Get
        Set(value As Double)
            mESP_ANI = value
        End Set
    End Property

    Public Property ALT_CIE_A_MIN As Double
        Get
            Return mALT_CIE_A_MIN
        End Get
        Set(value As Double)
            mALT_CIE_A_MIN = value
        End Set
    End Property

    Public Property ALT_CIE_A_MAX As Double
        Get
            Return mALT_CIE_A_MAX
        End Get
        Set(value As Double)
            mALT_CIE_A_MAX = value
        End Set
    End Property

    Public Property LON_CUE_A_MIN As Double
        Get
            Return mLON_CUE_A_MIN
        End Get
        Set(value As Double)
            mLON_CUE_A_MIN = value
        End Set
    End Property

    Public Property LON_CUE_A_MAX As Double
        Get
            Return mLON_CUE_A_MAX
        End Get
        Set(value As Double)
            mLON_CUE_A_MAX = value
        End Set
    End Property

    Public Property LON_ANI_MIN As Double
        Get
            Return mLON_ANI_MIN
        End Get
        Set(value As Double)
            mLON_ANI_MIN = value
        End Set
    End Property

    Public Property LON_ANI_MAX As Double
        Get
            Return mLON_ANI_MAX
        End Get
        Set(value As Double)
            mLON_ANI_MAX = value
        End Set
    End Property

    Public Property ALT_TER_MIN As Double
        Get
            Return mALT_TER_MIN
        End Get
        Set(value As Double)
            mALT_TER_MIN = value
        End Set
    End Property

    Public Property ALT_TER_MAX As Double
        Get
            Return mALT_TER_MAX
        End Get
        Set(value As Double)
            mALT_TER_MAX = value
        End Set
    End Property

    Public Property ALT_ORE_MIN As Double
        Get
            Return mALT_ORE_MIN
        End Get
        Set(value As Double)
            mALT_ORE_MIN = value
        End Set
    End Property

    Public Property ALT_ORE_MAX As Double
        Get
            Return mALT_ORE_MAX
        End Get
        Set(value As Double)
            mALT_ORE_MAX = value
        End Set
    End Property

    Public Property ENV_TER_MIN As Double
        Get
            Return mENV_TER_MIN
        End Get
        Set(value As Double)
            mENV_TER_MIN = value
        End Set
    End Property

    Public Property ENV_TER_MAX As Double
        Get
            Return mENV_TER_MAX
        End Get
        Set(value As Double)
            mENV_TER_MAX = value
        End Set
    End Property

    Public Property CUE_TAP_MIN As Double
        Get
            Return mCUE_TAP_MIN
        End Get
        Set(value As Double)
            mCUE_TAP_MIN = value
        End Set
    End Property

    Public Property CUE_TAP_MAX As Double
        Get
            Return mCUE_TAP_MAX
        End Get
        Set(value As Double)
            mCUE_TAP_MAX = value
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

    Public Property EST As String
        Get
            Return mEST
        End Get
        Set(value As String)
            mEST = value
        End Set
    End Property

    Public Property ART_COD1 As String
        Get
            Return mART_COD1
        End Get
        Set(value As String)
            mART_COD1 = value
        End Set
    End Property
End Class
