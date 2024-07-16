Public Class ELTBKARDEXIMPBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mFEC_GENE As Date
    Private mEST As String
    Private mTPRECIO_COMPRA As Double
    Private mTPRECIO_DCOMPRA As Double
    Private mT_IGV As Double
    Private mT_DIGV As Double
    Private mPROVEEDOR As String
    Private mT_CAMB As Double
    Private mFEC_DIA As String
    Private mPERSONAL As String
    Private mOBSERVA As String
    Private mNRO_DUA As String
    Private mFEC_DUA As Date
    Private mNRO_DOCU As String
    Private mFEC_DOCU As Date
    Private mMONEDA As String
    Private mN_AJUSTE As Double
    Private mNRO_OREQ As String
    Private mSER_OREQ As String
    Private mSER_DOCU As String
    Private mNRO_GUIA As String


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

    Public Property TPRECIO_COMPRA As Double
        Get
            Return mTPRECIO_COMPRA
        End Get
        Set(value As Double)
            mTPRECIO_COMPRA = value
        End Set
    End Property

    Public Property TPRECIO_DCOMPRA As Double
        Get
            Return mTPRECIO_DCOMPRA
        End Get
        Set(value As Double)
            mTPRECIO_DCOMPRA = value
        End Set
    End Property

    Public Property T_IGV As Double
        Get
            Return mT_IGV
        End Get
        Set(value As Double)
            mT_IGV = value
        End Set
    End Property

    Public Property T_DIGV As Double
        Get
            Return mT_DIGV
        End Get
        Set(value As Double)
            mT_DIGV = value
        End Set
    End Property

    Public Property PROVEEDOR As String
        Get
            Return mPROVEEDOR
        End Get
        Set(value As String)
            mPROVEEDOR = value
        End Set
    End Property

    Public Property T_CAMB As Double
        Get
            Return mT_CAMB
        End Get
        Set(value As Double)
            mT_CAMB = value
        End Set
    End Property

    Public Property FEC_DIA As String
        Get
            Return mFEC_DIA
        End Get
        Set(value As String)
            mFEC_DIA = value
        End Set
    End Property

    Public Property PERSONAL As String
        Get
            Return mPERSONAL
        End Get
        Set(value As String)
            mPERSONAL = value
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

    Public Property NRO_DUA As String
        Get
            Return mNRO_DUA
        End Get
        Set(value As String)
            mNRO_DUA = value
        End Set
    End Property

    Public Property FEC_DUA As Date
        Get
            Return mFEC_DUA
        End Get
        Set(value As Date)
            mFEC_DUA = value
        End Set
    End Property

    Public Property NRO_DOCU As String
        Get
            Return mNRO_DOCU
        End Get
        Set(value As String)
            mNRO_DOCU = value
        End Set
    End Property

    Public Property FEC_DOCU As Date
        Get
            Return mFEC_DOCU
        End Get
        Set(value As Date)
            mFEC_DOCU = value
        End Set
    End Property

    Public Property MONEDA As String
        Get
            Return mMONEDA
        End Get
        Set(value As String)
            mMONEDA = value
        End Set
    End Property

    Public Property N_AJUSTE As Double
        Get
            Return mN_AJUSTE
        End Get
        Set(value As Double)
            mN_AJUSTE = value
        End Set
    End Property

    Public Property NRO_OREQ As String
        Get
            Return mNRO_OREQ
        End Get
        Set(value As String)
            mNRO_OREQ = value
        End Set
    End Property

    Public Property SER_OREQ As String
        Get
            Return mSER_OREQ
        End Get
        Set(value As String)
            mSER_OREQ = value
        End Set
    End Property

    Public Property SER_DOCU As String
        Get
            Return mSER_DOCU
        End Get
        Set(value As String)
            mSER_DOCU = value
        End Set
    End Property

    Public Property NRO_GUIA As String
        Get
            Return mNRO_GUIA
        End Get
        Set(value As String)
            mNRO_GUIA = value
        End Set
    End Property
End Class
