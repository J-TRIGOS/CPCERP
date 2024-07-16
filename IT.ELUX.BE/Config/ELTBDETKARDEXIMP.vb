
Public Class ELTBDETKARDEXIMPBE
    'Campos de la entidad
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mFEC_GENE As Date
    Private mART_COD As String
    Private mCANTIDAD As Double
    Private mPROVEEDOR As String
    Private mUPRECIO_COMPRA As Double
    Private mUPRECIO_DCOMPRA As Double
    Private mT_IGV As Double
    Private mT_DIGV As Double
    Private mUNIDAD As String
    Private mEST As String
    Private mT_DOC_REF1 As String
    Private mSER_DOC_REF1 As String
    Private mNRO_DOC_REF1 As String
    Private mFEC_DIA As String
    Private mT_CAMB As Double
    Private mMONEDA As String
    Private mFEC_DOCU As Date
    Private mADVALORE As String

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

    Public Property PROVEEDOR As String
        Get
            Return mPROVEEDOR
        End Get
        Set(value As String)
            mPROVEEDOR = value
        End Set
    End Property

    Public Property UPRECIO_COMPRA As Double
        Get
            Return mUPRECIO_COMPRA
        End Get
        Set(value As Double)
            mUPRECIO_COMPRA = value
        End Set
    End Property

    Public Property UPRECIO_DCOMPRA As Double
        Get
            Return mUPRECIO_DCOMPRA
        End Get
        Set(value As Double)
            mUPRECIO_DCOMPRA = value
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

    Public Property UNIDAD As String
        Get
            Return mUNIDAD
        End Get
        Set(value As String)
            mUNIDAD = value
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

    Public Property T_DOC_REF1 As String
        Get
            Return mT_DOC_REF1
        End Get
        Set(value As String)
            mT_DOC_REF1 = value
        End Set
    End Property

    Public Property SER_DOC_REF1 As String
        Get
            Return mSER_DOC_REF1
        End Get
        Set(value As String)
            mSER_DOC_REF1 = value
        End Set
    End Property

    Public Property NRO_DOC_REF1 As String
        Get
            Return mNRO_DOC_REF1
        End Get
        Set(value As String)
            mNRO_DOC_REF1 = value
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

    Public Property MONEDA As String
        Get
            Return mMONEDA
        End Get
        Set(value As String)
            mMONEDA = value
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

    Public Property T_CAMB As Double
        Get
            Return mT_CAMB
        End Get
        Set(value As Double)
            mT_CAMB = value
        End Set
    End Property

    Public Property ADVALORE As String
        Get
            Return mADVALORE
        End Get
        Set(value As String)
            mADVALORE = value
        End Set
    End Property
End Class
