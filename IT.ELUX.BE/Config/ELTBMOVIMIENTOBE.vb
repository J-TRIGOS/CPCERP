Public Class ELTBMOVIMIENTOBE
    'Campos de la entidad
    Private manho As String
    Private mmes As String
    Private mt_ope_cod As String
    Private mreg_nro As String
    Private mseq As String
    Private mcta_cod As String
    Private mctct_cod As String
    Private mserie_nro As String
    Private mfec As String
    Private mt_doc_cod As String
    Private mmon_cod As String
    Private mcco_cod As String
    Private mfuente_cod As String
    Private mimpto_cod As String
    Private mcheq_nro As String
    Private mcomp_cpto As String
    Private mcomp_fec As String
    Private mcomp_nro As String
    Private mctct_reg_nro As String
    Private mdocrf_fec As String
    Private mdocrf_nro As Double
    Private mimpor As Double
    Private mimpor_me As Double
    Private mnro_serie_rf As String
    Private mprog_fec As String
    Private mruc As String
    Private msigno As String
    Private mt_cmb As Double
    Private mt_docrf As String
    Private mx_prov As String
    Private mcta_cod_dest As String
    Private mlabor_cod As String
    Private mvolumen As Double
    Private mt_est_tes_cod As String
    Private mx_ret As String
    Private mseq_rf As String
    Private musuario As String

    Public Property anho As String
        Get
            Return manho
        End Get
        Set(value As String)
            manho = value
        End Set
    End Property

    Public Property mes As String
        Get
            Return mmes
        End Get
        Set(value As String)
            mmes = value
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

    Public Property reg_nro As String
        Get
            Return mreg_nro
        End Get
        Set(value As String)
            mreg_nro = value
        End Set
    End Property

    Public Property seq As String
        Get
            Return mseq
        End Get
        Set(value As String)
            mseq = value
        End Set
    End Property

    Public Property cta_cod As String
        Get
            Return mcta_cod
        End Get
        Set(value As String)
            mcta_cod = value
        End Set
    End Property

    Public Property ctct_cod As String
        Get
            Return mctct_cod
        End Get
        Set(value As String)
            mctct_cod = value
        End Set
    End Property

    Public Property serie_nro As String
        Get
            Return mserie_nro
        End Get
        Set(value As String)
            mserie_nro = value
        End Set
    End Property

    Public Property t_doc_cod As String
        Get
            Return mt_doc_cod
        End Get
        Set(value As String)
            mt_doc_cod = value
        End Set
    End Property

    Public Property mon_cod As String
        Get
            Return mmon_cod
        End Get
        Set(value As String)
            mmon_cod = value
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

    Public Property fuente_cod As String
        Get
            Return mfuente_cod
        End Get
        Set(value As String)
            mfuente_cod = value
        End Set
    End Property

    Public Property impto_cod As String
        Get
            Return mimpto_cod
        End Get
        Set(value As String)
            mimpto_cod = value
        End Set
    End Property

    Public Property cheq_nro As String
        Get
            Return mcheq_nro
        End Get
        Set(value As String)
            mcheq_nro = value
        End Set
    End Property

    Public Property comp_cpto As String
        Get
            Return mcomp_cpto
        End Get
        Set(value As String)
            mcomp_cpto = value
        End Set
    End Property

    Public Property comp_fec As String
        Get
            Return mcomp_fec
        End Get
        Set(value As String)
            mcomp_fec = value
        End Set
    End Property

    Public Property comp_nro As String
        Get
            Return mcomp_nro
        End Get
        Set(value As String)
            mcomp_nro = value
        End Set
    End Property

    Public Property ctct_reg_nro As String
        Get
            Return mctct_reg_nro
        End Get
        Set(value As String)
            mctct_reg_nro = value
        End Set
    End Property

    Public Property docrf_fec As String
        Get
            Return mdocrf_fec
        End Get
        Set(value As String)
            mdocrf_fec = value
        End Set
    End Property

    Public Property docrf_nro As Double
        Get
            Return mdocrf_nro
        End Get
        Set(value As Double)
            mdocrf_nro = value
        End Set
    End Property

    Public Property impor As Double
        Get
            Return mimpor
        End Get
        Set(value As Double)
            mimpor = value
        End Set
    End Property

    Public Property impor_me As Double
        Get
            Return mimpor_me
        End Get
        Set(value As Double)
            mimpor_me = value
        End Set
    End Property

    Public Property nro_serie_rf As String
        Get
            Return mnro_serie_rf
        End Get
        Set(value As String)
            mnro_serie_rf = value
        End Set
    End Property

    Public Property prog_fec As String
        Get
            Return mprog_fec
        End Get
        Set(value As String)
            mprog_fec = value
        End Set
    End Property

    Public Property ruc As String
        Get
            Return mruc
        End Get
        Set(value As String)
            mruc = value
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

    Public Property t_cmb As Double
        Get
            Return mt_cmb
        End Get
        Set(value As Double)
            mt_cmb = value
        End Set
    End Property

    Public Property t_docrf As String
        Get
            Return mt_docrf
        End Get
        Set(value As String)
            mt_docrf = value
        End Set
    End Property

    Public Property x_prov As String
        Get
            Return mx_prov
        End Get
        Set(value As String)
            mx_prov = value
        End Set
    End Property

    Public Property cta_cod_dest As String
        Get
            Return mcta_cod_dest
        End Get
        Set(value As String)
            mcta_cod_dest = value
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

    Public Property volumen As Double
        Get
            Return mvolumen
        End Get
        Set(value As Double)
            mvolumen = value
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

    Public Property x_ret As String
        Get
            Return mx_ret
        End Get
        Set(value As String)
            mx_ret = value
        End Set
    End Property

    Public Property seq_rf As String
        Get
            Return mseq_rf
        End Get
        Set(value As String)
            mseq_rf = value
        End Set
    End Property

    Public Property usuario As String
        Get
            Return musuario
        End Get
        Set(value As String)
            musuario = value
        End Set
    End Property

    Public Property fec As String
        Get
            Return mfec
        End Get
        Set(value As String)
            mfec = value
        End Set
    End Property
End Class
