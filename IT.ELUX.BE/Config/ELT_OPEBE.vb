Public Class ELT_OPEBE
    Private mcod As String
    Private manho As String
    Private mnom As String
    Private mt_reg_aux As String
    Private mt_reg_cc As String
    Private mt_ope_cod As String
    Private mx_pref As String
    Private mx_dci As String
    Private mx_order_cont As String
    Private mx_cod_lib_cont As String

    Public Property cod As String
        Get
            Return mcod
        End Get
        Set(value As String)
            mcod = value
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

    Public Property nom As String
        Get
            Return mnom
        End Get
        Set(value As String)
            mnom = value
        End Set
    End Property

    Public Property t_reg_aux As String
        Get
            Return mt_reg_aux
        End Get
        Set(value As String)
            mt_reg_aux = value
        End Set
    End Property

    Public Property t_reg_cc As String
        Get
            Return mt_reg_cc
        End Get
        Set(value As String)
            mt_reg_cc = value
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

    Public Property x_pref As String
        Get
            Return mx_pref
        End Get
        Set(value As String)
            mx_pref = value
        End Set
    End Property

    Public Property x_dci As String
        Get
            Return mx_dci
        End Get
        Set(value As String)
            mx_dci = value
        End Set
    End Property

    Public Property x_order_cont As String
        Get
            Return mx_order_cont
        End Get
        Set(value As String)
            mx_order_cont = value
        End Set
    End Property

    Public Property x_cod_lib_cont As String
        Get
            Return mx_cod_lib_cont
        End Get
        Set(value As String)
            mx_cod_lib_cont = value
        End Set
    End Property
End Class
