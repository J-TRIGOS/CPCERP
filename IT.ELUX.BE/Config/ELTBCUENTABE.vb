Public Class ELTBCUENTABE
    'Campos de la entidad
    Private manho As String
    Private mbal_cod_abono As String
    Private mbal_cod_cargo As String
    Private mcod As String
    Private mcta_alt_cod As String
    Private mcta_cod As String
    Private mcta_cod_ajuste1 As String
    Private mcta_cod_ajuste2 As String
    Private mcta_cod_dest As String
    Private mcta_cod_dest2 As String
    Private mfec_bal_ult As String
    Private mfec_ing_ult As Date
    Private mmon_cod As String
    Private mnom As String
    Private morden As Double
    Private morden_costo As Double
    Private mt_ajuste_inf_cod As String
    Private mtitulo As String
    Private mx_balance As String
    Private mx_cco As String
    Private mx_ctct As String
    Private mx_t_gasto As String
    Private mx_dif_cmb As String
    Private mx_fuente As String
    Private mx_hco As String
    Private mx_labor As String
    Private mx_linea As String
    Private mx_modulo As String
    Private mx_padre As String
    Private mx_proy As String
    Private mx_sucu As String
    Private mx_t_cmb As String
    Private mx_t_conv As String
    Private mx_t_doc As String
    Private mx_t_saldo As String

    Public Property anho As String
        Get
            Return manho
        End Get
        Set(value As String)
            manho = value
        End Set
    End Property

    Public Property bal_cod_abono As String
        Get
            Return mbal_cod_abono
        End Get
        Set(value As String)
            mbal_cod_abono = value
        End Set
    End Property

    Public Property bal_cod_cargo As String
        Get
            Return mbal_cod_cargo
        End Get
        Set(value As String)
            mbal_cod_cargo = value
        End Set
    End Property

    Public Property cod As String
        Get
            Return mcod
        End Get
        Set(value As String)
            mcod = value
        End Set
    End Property

    Public Property cta_alt_cod As String
        Get
            Return mcta_alt_cod
        End Get
        Set(value As String)
            mcta_alt_cod = value
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

    Public Property cta_cod_ajuste1 As String
        Get
            Return mcta_cod_ajuste1
        End Get
        Set(value As String)
            mcta_cod_ajuste1 = value
        End Set
    End Property

    Public Property cta_cod_ajuste2 As String
        Get
            Return mcta_cod_ajuste2
        End Get
        Set(value As String)
            mcta_cod_ajuste2 = value
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

    Public Property cta_cod_dest2 As String
        Get
            Return mcta_cod_dest2
        End Get
        Set(value As String)
            mcta_cod_dest2 = value
        End Set
    End Property

    Public Property fec_bal_ult As String
        Get
            Return mfec_bal_ult
        End Get
        Set(value As String)
            mfec_bal_ult = value
        End Set
    End Property

    Public Property fec_ing_ult As Date
        Get
            Return mfec_ing_ult
        End Get
        Set(value As Date)
            mfec_ing_ult = value
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

    Public Property nom As String
        Get
            Return mnom
        End Get
        Set(value As String)
            mnom = value
        End Set
    End Property

    Public Property orden As Double
        Get
            Return morden
        End Get
        Set(value As Double)
            morden = value
        End Set
    End Property

    Public Property orden_costo As Double
        Get
            Return morden_costo
        End Get
        Set(value As Double)
            morden_costo = value
        End Set
    End Property

    Public Property ajuste_inf_cod As String
        Get
            Return mt_ajuste_inf_cod
        End Get
        Set(value As String)
            mt_ajuste_inf_cod = value
        End Set
    End Property

    Public Property titulo As String
        Get
            Return mtitulo
        End Get
        Set(value As String)
            mtitulo = value
        End Set
    End Property

    Public Property x_balance As String
        Get
            Return mx_balance
        End Get
        Set(value As String)
            mx_balance = value
        End Set
    End Property

    Public Property x_cco As String
        Get
            Return mx_cco
        End Get
        Set(value As String)
            mx_cco = value
        End Set
    End Property

    Public Property x_ctct As String
        Get
            Return mx_ctct
        End Get
        Set(value As String)
            mx_ctct = value
        End Set
    End Property

    Public Property x_dif_cmb As String
        Get
            Return mx_dif_cmb
        End Get
        Set(value As String)
            mx_dif_cmb = value
        End Set
    End Property

    Public Property x_fuente As String
        Get
            Return mx_fuente
        End Get
        Set(value As String)
            mx_fuente = value
        End Set
    End Property

    Public Property x_hco As String
        Get
            Return mx_hco
        End Get
        Set(value As String)
            mx_hco = value
        End Set
    End Property

    Public Property x_labor As String
        Get
            Return mx_labor
        End Get
        Set(value As String)
            mx_labor = value
        End Set
    End Property

    Public Property x_linea As String
        Get
            Return mx_linea
        End Get
        Set(value As String)
            mx_linea = value
        End Set
    End Property

    Public Property x_modulo As String
        Get
            Return mx_modulo
        End Get
        Set(value As String)
            mx_modulo = value
        End Set
    End Property

    Public Property x_padre As String
        Get
            Return mx_padre
        End Get
        Set(value As String)
            mx_padre = value
        End Set
    End Property

    Public Property x_proy As String
        Get
            Return mx_proy
        End Get
        Set(value As String)
            mx_proy = value
        End Set
    End Property

    Public Property x_sucu As String
        Get
            Return mx_sucu
        End Get
        Set(value As String)
            mx_sucu = value
        End Set
    End Property

    Public Property x_t_cmb As String
        Get
            Return mx_t_cmb
        End Get
        Set(value As String)
            mx_t_cmb = value
        End Set
    End Property

    Public Property x_t_conv As String
        Get
            Return mx_t_conv
        End Get
        Set(value As String)
            mx_t_conv = value
        End Set
    End Property

    Public Property x_t_doc As String
        Get
            Return mx_t_doc
        End Get
        Set(value As String)
            mx_t_doc = value
        End Set
    End Property

    Public Property x_t_saldo As String
        Get
            Return mx_t_saldo
        End Get
        Set(value As String)
            mx_t_saldo = value
        End Set
    End Property

    Public Property x_t_gasto As String
        Get
            Return mx_t_gasto
        End Get
        Set(value As String)
            mx_t_gasto = value
        End Set
    End Property

    'Propiedades de la entidad

End Class
