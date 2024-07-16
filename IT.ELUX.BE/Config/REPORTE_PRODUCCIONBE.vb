Public Class REPORTE_PRODUCCIONBE
    'Campos de la entidad
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mART_COD As String
    Private mLOTE As String
    Private mLOTE1 As String
    Private mLOTE2 As String
    Private mLOTE3 As String
    Private mLOTE4 As String
    Private mUNIDAD As String
    Private mLINEA As String
    Private mNRO_ORDEN As String
    Private mART_VENTA As String
    Private mART_VENTA1 As String
    Private mART_VENTA2 As String
    Private mART_VENTA3 As String
    Private mOBSERVA1 As String
    Private mOBSERVA2 As String
    Private mX_ENTREGA As String
    Private mCANTIDAD As Double
    Private mEST As String
    Private mEST1 As String
    Private mEST2 As String
    Private mUSUARIO_RP As String
    Private mUSUARIO_VB As String
    Private mUSUARIO_OB As String
    Private mVB As String
    Private mOB As String
    Private mFEC_GENE As Date
    Private mFEC_DIA1 As Date
    Private mFEC_TERMINO As Date
    Private mFEC_ANU As Date
    Private mTURNO As String
    Private mHORA_GENE As String
    Private mHORA_TERMINO As String
    Private mDIF_HORA As String
    Private mUND_H As Double
    Private mNUM_DIF As Double
    Private mnrodia As String
    Private manho As String
    Private mop As String
    Private mCCO_COD As String
    Private mSER_ORDEN As String

    Public Property SER_DOC_REF() As String
        Get
            Return mSER_DOC_REF
        End Get
        Set(ByVal value As String)
            mSER_DOC_REF = value
        End Set
    End Property
    Public Property T_DOC_REF() As String
        Get
            Return mT_DOC_REF
        End Get
        Set(ByVal value As String)
            mT_DOC_REF = value
        End Set
    End Property
    Public Property NRO_DOC_REF() As String
        Get
            Return mNRO_DOC_REF
        End Get
        Set(ByVal value As String)
            mNRO_DOC_REF = value
        End Set
    End Property
    Public Property ART_COD() As String
        Get
            Return mART_COD
        End Get
        Set(ByVal value As String)
            mART_COD = value
        End Set
    End Property
    Public Property LOTE() As String
        Get
            Return mLOTE
        End Get
        Set(ByVal value As String)
            mLOTE = value
        End Set
    End Property
    Public Property LOTE1() As String
        Get
            Return mLOTE1
        End Get
        Set(ByVal value As String)
            mLOTE1 = value
        End Set
    End Property
    Public Property LOTE2() As String
        Get
            Return mLOTE2
        End Get
        Set(ByVal value As String)
            mLOTE2 = value
        End Set
    End Property
    Public Property LOTE3() As String
        Get
            Return mLOTE3
        End Get
        Set(ByVal value As String)
            mLOTE3 = value
        End Set
    End Property
    Public Property LOTE4() As String
        Get
            Return mLOTE4
        End Get
        Set(ByVal value As String)
            mLOTE4 = value
        End Set
    End Property
    Public Property UNIDAD() As String
        Get
            Return mUNIDAD
        End Get
        Set(ByVal value As String)
            mUNIDAD = value
        End Set
    End Property
    Public Property NRO_ORDEN() As String
        Get
            Return mNRO_ORDEN
        End Get
        Set(ByVal value As String)
            mNRO_ORDEN = value
        End Set
    End Property
    Public Property LINEA() As String
        Get
            Return mLINEA
        End Get
        Set(ByVal value As String)
            mLINEA = value
        End Set
    End Property
    Public Property ART_VENTA() As String
        Get
            Return mART_VENTA
        End Get
        Set(ByVal value As String)
            mART_VENTA = value
        End Set
    End Property
    Public Property ART_VENTA1() As String
        Get
            Return mART_VENTA1
        End Get
        Set(ByVal value As String)
            mART_VENTA1 = value
        End Set
    End Property
    Public Property ART_VENTA2() As String
        Get
            Return mART_VENTA2
        End Get
        Set(ByVal value As String)
            mART_VENTA2 = value
        End Set
    End Property
    Public Property ART_VENTA3() As String
        Get
            Return mART_VENTA3
        End Get
        Set(ByVal value As String)
            mART_VENTA3 = value
        End Set
    End Property
    Public Property OBSERVA1() As String
        Get
            Return mOBSERVA1
        End Get
        Set(ByVal value As String)
            mOBSERVA1 = value
        End Set
    End Property
    Public Property OBSERVA2() As String
        Get
            Return mOBSERVA2
        End Get
        Set(ByVal value As String)
            mOBSERVA2 = value
        End Set
    End Property
    Public Property X_ENTREGA() As String
        Get
            Return mX_ENTREGA
        End Get
        Set(ByVal value As String)
            mX_ENTREGA = value
        End Set
    End Property

    Public Property CANTIDAD() As Double
        Get
            Return mCANTIDAD
        End Get
        Set(ByVal value As Double)
            mCANTIDAD = value
        End Set
    End Property
    Public Property EST1() As String
        Get
            Return mEST1
        End Get
        Set(ByVal value As String)
            mEST1 = value
        End Set
    End Property
    Public Property EST2() As String
        Get
            Return mEST2
        End Get
        Set(ByVal value As String)
            mEST2 = value
        End Set
    End Property
    Public Property EST() As String
        Get
            Return mEST
        End Get
        Set(ByVal value As String)
            mEST = value
        End Set
    End Property
    Public Property USUARIO_RP() As String
        Get
            Return mUSUARIO_RP
        End Get
        Set(ByVal value As String)
            mUSUARIO_RP = value
        End Set
    End Property
    Public Property USUARIO_VB() As String
        Get
            Return mUSUARIO_VB
        End Get
        Set(ByVal value As String)
            mUSUARIO_VB = value
        End Set
    End Property
    Public Property USUARIO_OB() As String
        Get
            Return mUSUARIO_OB
        End Get
        Set(ByVal value As String)
            mUSUARIO_OB = value
        End Set
    End Property
    Public Property VB() As String
        Get
            Return mVB
        End Get
        Set(ByVal value As String)
            mVB = value
        End Set
    End Property
    Public Property OB() As String
        Get
            Return mOB
        End Get
        Set(ByVal value As String)
            mOB = value
        End Set
    End Property

    Public Property TURNO() As String
        Get
            Return mTURNO
        End Get
        Set(ByVal value As String)
            mTURNO = value
        End Set
    End Property
    Public Property FEC_GENE() As Date
        Get
            Return mFEC_GENE
        End Get
        Set(ByVal value As Date)
            mFEC_GENE = value
        End Set
    End Property
    Public Property FEC_DIA1() As Date
        Get
            Return mFEC_DIA1
        End Get
        Set(ByVal value As Date)
            mFEC_DIA1 = value
        End Set
    End Property
    Public Property FEC_TERMINO() As Date
        Get
            Return mFEC_TERMINO
        End Get
        Set(ByVal value As Date)
            mFEC_TERMINO = value
        End Set
    End Property
    Public Property FEC_ANU() As Date
        Get
            Return mFEC_ANU
        End Get
        Set(ByVal value As Date)
            mFEC_ANU = value
        End Set
    End Property
    Public Property HORA_GENE() As String
        Get
            Return mHORA_GENE
        End Get
        Set(ByVal value As String)
            mHORA_GENE = value
        End Set
    End Property
    Public Property HORA_TERMINO() As String
        Get
            Return mHORA_TERMINO
        End Get
        Set(ByVal value As String)
            mHORA_TERMINO = value
        End Set
    End Property
    Public Property DIF_HORA() As String
        Get
            Return mDIF_HORA
        End Get
        Set(ByVal value As String)
            mDIF_HORA = value
        End Set
    End Property
    Public Property UND_H() As Double
        Get
            Return mUND_H
        End Get
        Set(ByVal value As Double)
            mUND_H = value
        End Set
    End Property

    Public Property NUM_DIF As Double
        Get
            Return mNUM_DIF
        End Get
        Set(value As Double)
            mNUM_DIF = value
        End Set
    End Property

    Public Property nrodia As String
        Get
            Return mnrodia
        End Get
        Set(value As String)
            mnrodia = value
        End Set
    End Property

    Public Property anho As String
        Get
            Return manho
        End Get
        Set(value As String)
            manho = value
        End Set
    End Property

    Public Property op As String
        Get
            Return mop
        End Get
        Set(value As String)
            mop = value
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

    Public Property SER_ORDEN As String
        Get
            Return mSER_ORDEN
        End Get
        Set(value As String)
            mSER_ORDEN = value
        End Set
    End Property
End Class
