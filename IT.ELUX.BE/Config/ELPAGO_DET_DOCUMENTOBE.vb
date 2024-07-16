Public Class ELPAGO_DET_DOCUMENTOBE
    Private mt_doc_ref As String
    Private mser_doc_ref As String
    Private mnro_doc_ref As String
    Private mafecto As String
    Private mcuenta As String
    Private mcuenta_Dest As String
    Private mproveedor As String
    Private msigno As String
    Private mfec_gene As Date
    Private mt_cambio As String
    Private mmon As String
    Private mtprecio_compra As Double
    Private mtprecio_dcompra As Double
    Private mo_compra As String
    Private mt_ope_cod As String
    Private mreparar As String
    Private mtipo7 As String
    Private mest_mercaderia As String
    Private mTEMPLE As String
    Private mlabor_cod As String
    Private mt_est_tes_cod As String
    Private mCCO_COD As String

    Public Property CCO_COD As String
        Get
            Return mCCO_COD
        End Get
        Set(value As String)
            mCCO_COD = value
        End Set
    End Property


    Public Property labor_cod As String
        Get
            Return mlabor_cod
        End Get
        Set(value As String)
            mlabor_cod = value
        End Set
    End Property

    Public Property t_est_tes_cod As String
        Get
            Return mt_est_tes_cod
        End Get
        Set(value As String)
            mt_est_tes_cod = value
        End Set
    End Property

    Public Property tipo7 As String
        Get
            Return mtipo7
        End Get
        Set(value As String)
            mtipo7 = value
        End Set
    End Property
    Public Property est_mercaderia As String
        Get
            Return mest_mercaderia
        End Get
        Set(value As String)
            mest_mercaderia = value
        End Set
    End Property

    Public Property reparar As String
        Get
            Return mreparar
        End Get
        Set(value As String)
            mreparar = value
        End Set
    End Property

    Public Property t_ope_cod As String
        Get
            Return mt_ope_cod
        End Get
        Set(value As String)
            mt_ope_cod = value
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

    Public Property afecto As String
        Get
            Return mafecto
        End Get
        Set(value As String)
            mafecto = value
        End Set
    End Property

    Public Property cuenta As String
        Get
            Return mcuenta
        End Get
        Set(value As String)
            mcuenta = value
        End Set
    End Property

    Public Property cuenta_Dest As String
        Get
            Return mcuenta_Dest
        End Get
        Set(value As String)
            mcuenta_Dest = value
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

    Public Property signo As String
        Get
            Return msigno
        End Get
        Set(value As String)
            msigno = value
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

    Public Property t_cambio As Double
        Get
            Return mt_cambio
        End Get
        Set(value As Double)
            mt_cambio = value
        End Set
    End Property

    Public Property mon As String
        Get
            Return mmon
        End Get
        Set(value As String)
            mmon = value
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

    Public Property o_compra As String
        Get
            Return mo_compra
        End Get
        Set(value As String)
            mo_compra = value
        End Set
    End Property

    Public Property TEMPLE As String
        Get
            Return mTEMPLE
        End Get
        Set(value As String)
            mTEMPLE = value
        End Set
    End Property
End Class
