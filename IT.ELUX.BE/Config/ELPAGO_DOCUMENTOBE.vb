Public Class ELPAGO_DOCUMENTOBE
    Private mt_ope As String
    Private mcbco_cod As String
    Private mt_doc_ref As String
    Private mser_doc_ref As String
    Private mnro_doc_ref As String
    Private mfec_gene As Date
    Private mproveedor As String
    Private mconcepto As String
    Private mfec_pago As Date
    Private mmoneda As String
    Private mtprecio_compra As Double
    Private mtprecio_dcompra As Double
    Private mt_cambio As Double
    Private mnro_doc_ref1 As String
    Private mtipo1 As String
    Private mfec_vigencia As Date
    Private mcantidad As Double
    Private mfec_dia As Date
    Private mest1 As String
    Private mcco_cod As String
    Private mcobranza As String
    Private mreten As Double
    Private mporcentaje As Double
    Private mregcontable As Double
    Private mpagoparcial As Double
    Private mtotalsoles As Double
    Private mtotaldolar As Double
    Private mest_mercancia As String
    Private mtipo07 As String
    Private mtcambiosbs As Double
    Private mcta_cod As String
    Private musuario As String
    Private mreg_contable1 As Double


    Public Property usuario As String
        Get
            Return musuario
        End Get
        Set(value As String)
            musuario = value
        End Set
    End Property
    Public Property cta_cod As Double
        Get
            Return mcta_cod
        End Get
        Set(value As Double)
            mcta_cod = value
        End Set
    End Property
    Public Property tcambiosbs As Double
        Get
            Return mtcambiosbs
        End Get
        Set(value As Double)
            mtcambiosbs = value
        End Set
    End Property

    Public Property est_mercancia As String
        Get
            Return mest_mercancia
        End Get
        Set(value As String)
            mest_mercancia = value
        End Set
    End Property
    Public Property tipo07 As String
        Get
            Return mtipo07
        End Get
        Set(value As String)
            mtipo07 = value
        End Set
    End Property
    Public Property t_ope As String
        Get
            Return mt_ope
        End Get
        Set(value As String)
            mt_ope = value
        End Set
    End Property

    Public Property cbco_cod As String
        Get
            Return mcbco_cod
        End Get
        Set(value As String)
            mcbco_cod = value
        End Set
    End Property

    Public Property t_doc_ref As String
        Get
            Return mt_doc_ref
        End Get
        Set(value As String)
            mt_doc_ref = value
        End Set
    End Property

    Public Property ser_doc_ref As String
        Get
            Return mser_doc_ref
        End Get
        Set(value As String)
            mser_doc_ref = value
        End Set
    End Property

    Public Property nro_doc_ref As String
        Get
            Return mnro_doc_ref
        End Get
        Set(value As String)
            mnro_doc_ref = value
        End Set
    End Property

    Public Property proveedor As String
        Get
            Return mproveedor
        End Get
        Set(value As String)
            mproveedor = value
        End Set
    End Property

    Public Property concepto As String
        Get
            Return mconcepto
        End Get
        Set(value As String)
            mconcepto = value
        End Set
    End Property



    Public Property moneda As String
        Get
            Return mmoneda
        End Get
        Set(value As String)
            mmoneda = value
        End Set
    End Property

    Public Property tprecio_compra As Double
        Get
            Return mtprecio_compra
        End Get
        Set(value As Double)
            mtprecio_compra = value
        End Set
    End Property

    Public Property tprecio_dcompra As Double
        Get
            Return mtprecio_dcompra
        End Get
        Set(value As Double)
            mtprecio_dcompra = value
        End Set
    End Property

    Public Property t_cambio As Double
        Get
            Return mt_cambio
        End Get
        Set(value As Double)
            mt_cambio = value
        End Set
    End Property

    Public Property nro_doc_ref1 As String
        Get
            Return mnro_doc_ref1
        End Get
        Set(value As String)
            mnro_doc_ref1 = value
        End Set
    End Property

    Public Property tipo1 As String
        Get
            Return mtipo1
        End Get
        Set(value As String)
            mtipo1 = value
        End Set
    End Property

    Public Property fec_pago As Date
        Get
            Return mfec_pago
        End Get
        Set(value As Date)
            mfec_pago = value
        End Set
    End Property

    Public Property fec_gene As Date
        Get
            Return mfec_gene
        End Get
        Set(value As Date)
            mfec_gene = value
        End Set
    End Property

    Public Property fec_vigencia As Date
        Get
            Return mfec_vigencia
        End Get
        Set(value As Date)
            mfec_vigencia = value
        End Set
    End Property

    Public Property cantidad As Double
        Get
            Return mcantidad
        End Get
        Set(value As Double)
            mcantidad = value
        End Set
    End Property

    Public Property fec_dia As Date
        Get
            Return mfec_dia
        End Get
        Set(value As Date)
            mfec_dia = value
        End Set
    End Property

    Public Property est1 As String
        Get
            Return mest1
        End Get
        Set(value As String)
            mest1 = value
        End Set
    End Property

    Public Property cco_cod As String
        Get
            Return mcco_cod
        End Get
        Set(value As String)
            mcco_cod = value
        End Set
    End Property

    Public Property cobranza As String
        Get
            Return mcobranza
        End Get
        Set(value As String)
            mcobranza = value
        End Set
    End Property

    Public Property reten As Double
        Get
            Return mreten
        End Get
        Set(value As Double)
            mreten = value
        End Set
    End Property

    Public Property porcentaje As Double
        Get
            Return mporcentaje
        End Get
        Set(value As Double)
            mporcentaje = value
        End Set
    End Property

    Public Property regcontable As Double
        Get
            Return mregcontable
        End Get
        Set(value As Double)
            mregcontable = value
        End Set
    End Property

    Public Property pagoparcial As Double
        Get
            Return mpagoparcial
        End Get
        Set(value As Double)
            mpagoparcial = value
        End Set
    End Property

    Public Property totalsoles As Double
        Get
            Return mtotalsoles
        End Get
        Set(value As Double)
            mtotalsoles = value
        End Set
    End Property

    Public Property totaldolar As Double
        Get
            Return mtotaldolar
        End Get
        Set(value As Double)
            mtotaldolar = value
        End Set
    End Property

    Public Property reg_contable1 As Double
        Get
            Return mreg_contable1
        End Get
        Set(value As Double)
            mreg_contable1 = value
        End Set
    End Property
End Class
