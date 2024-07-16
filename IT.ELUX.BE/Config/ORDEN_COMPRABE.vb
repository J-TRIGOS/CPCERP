Public Class ORDEN_COMPRABE
    Private mt_doc_ref As String
    Private mser_doc_ref As String
    Private mnro_doc_ref As String
    Private mfec_gene As Date
    Private mt_preciounit As String
    Private mt_preciosexo As String
    Private migv_impor As String
    Private mtotal As String
    Private mcomp_cpto As String
    Private mcantidad As String
    Private mt_cmb As String
    Private mt_ope As String
    Private mmon_cod As String
    Private mproveedor As String
    Public Property t_doc_ref() As String
        Get
            Return mt_doc_ref
        End Get
        Set(ByVal value As String)
            mt_doc_ref = value
        End Set
    End Property

    Public Property ser_doc_ref() As String
        Get
            Return mser_doc_ref
        End Get
        Set(ByVal value As String)
            mser_doc_ref = value
        End Set
    End Property

    Public Property nro_doc_ref() As String
        Get
            Return mnro_doc_ref
        End Get
        Set(ByVal value As String)
            mnro_doc_ref = value
        End Set
    End Property

    Public Property fec_gene() As Date
        Get
            Return mfec_gene
        End Get
        Set(ByVal value As Date)
            mfec_gene = value
        End Set
    End Property

    Public Property t_preciounit() As String
        Get
            Return mt_preciounit
        End Get
        Set(ByVal value As String)
            mt_preciounit = value
        End Set
    End Property

    Public Property t_preciosexo() As String
        Get
            Return mt_preciosexo
        End Get
        Set(ByVal value As String)
            mt_preciosexo = value
        End Set
    End Property

    Public Property igv_impor() As String
        Get
            Return migv_impor
        End Get
        Set(ByVal value As String)
            migv_impor = value
        End Set
    End Property


    Public Property total() As String
        Get
            Return mtotal
        End Get
        Set(ByVal value As String)
            mtotal = value
        End Set
    End Property


    Public Property comp_cpto() As String
        Get
            Return mcomp_cpto
        End Get
        Set(ByVal value As String)
            mcomp_cpto = value
        End Set
    End Property


    Public Property t_cmb() As String
        Get
            Return mt_cmb
        End Get
        Set(ByVal value As String)
            mt_cmb = value
        End Set
    End Property
    Public Property t_ope() As String
        Get
            Return mt_ope
        End Get
        Set(ByVal value As String)
            mt_ope = value
        End Set
    End Property
    Public Property mon_cod() As String
        Get
            Return mmon_cod
        End Get
        Set(ByVal value As String)
            mmon_cod = value
        End Set
    End Property
    Public Property proveedor() As String
        Get
            Return mproveedor
        End Get
        Set(ByVal value As String)
            mproveedor = value
        End Set
    End Property

End Class
