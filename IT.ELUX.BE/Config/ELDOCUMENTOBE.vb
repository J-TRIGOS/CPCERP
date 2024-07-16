Public Class ELDOCUMENTOBE
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
End Class
