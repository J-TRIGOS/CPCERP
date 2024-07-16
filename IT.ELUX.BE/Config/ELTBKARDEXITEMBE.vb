Public Class ELTBKARDEXITEMBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mART_COD As String
    Private mFEC_GENE As Date
    Private mTIPO As String
    Private mT_MOVINV As String
    Private mUPRECIO_COMPRA As Double
    Private mPERIODO As String
    Private mCANTIDAD As Double
    Private mX_FEC As String
    Private mX_SUP As String
    Private mX_CANT As String
    Private mX_PRECIO As String
    Private mX_REGNRO As String
    Private mT_OPE As String
    Private mX_MOV As String
    Private mFORMA As String

    Public Property FORMA As String
        Get
            Return mFORMA
        End Get
        Set(value As String)
            mFORMA = value
        End Set
    End Property

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

    Public Property FEC_GENE As Date
        Get
            Return mFEC_GENE
        End Get
        Set(value As Date)
            mFEC_GENE = value
        End Set
    End Property

    Public Property TIPO As String
        Get
            Return mTIPO
        End Get
        Set(value As String)
            mTIPO = value
        End Set
    End Property

    Public Property T_MOVINV As String
        Get
            Return mT_MOVINV
        End Get
        Set(value As String)
            mT_MOVINV = value
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

    Public Property PERIODO As String
        Get
            Return mPERIODO
        End Get
        Set(value As String)
            mPERIODO = value
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

    Public Property X_FEC As String
        Get
            Return mX_FEC
        End Get
        Set(value As String)
            mX_FEC = value
        End Set
    End Property

    Public Property X_SUP As String
        Get
            Return mX_SUP
        End Get
        Set(value As String)
            mX_SUP = value
        End Set
    End Property

    Public Property X_CANT As String
        Get
            Return mX_CANT
        End Get
        Set(value As String)
            mX_CANT = value
        End Set
    End Property

    Public Property X_PRECIO As String
        Get
            Return mX_PRECIO
        End Get
        Set(value As String)
            mX_PRECIO = value
        End Set
    End Property

    Public Property X_REGNRO As String
        Get
            Return mX_REGNRO
        End Get
        Set(value As String)
            mX_REGNRO = value
        End Set
    End Property

    Public Property T_OPE As String
        Get
            Return mT_OPE
        End Get
        Set(value As String)
            mT_OPE = value
        End Set
    End Property

    Public Property X_MOV As String
        Get
            Return mX_MOV
        End Get
        Set(value As String)
            mX_MOV = value
        End Set
    End Property
End Class
