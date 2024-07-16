Public Class ELTBCUENTA_OPBE
    'Campos de la entidad
    Private mt_ope_cod As String
    Private mt_doc_cod As String
    Private mstatus As String
    Private mimpto_cod As String
    Private mcta_inis As String
    Private mcta_inid As String
    Private msigno As String
    Private mcta_inidl As String
    Private mcta_inisl As String
    Private manho As String

    Public Property t_ope_cod As String
        Get
            Return mt_ope_cod
        End Get
        Set(value As String)
            mt_ope_cod = value
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

    Public Property status As String
        Get
            Return mstatus
        End Get
        Set(value As String)
            mstatus = value
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

    Public Property cta_inis As String
        Get
            Return mcta_inis
        End Get
        Set(value As String)
            mcta_inis = value
        End Set
    End Property

    Public Property cta_inid As String
        Get
            Return mcta_inid
        End Get
        Set(value As String)
            mcta_inid = value
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

    Public Property cta_inidl As String
        Get
            Return mcta_inidl
        End Get
        Set(value As String)
            mcta_inidl = value
        End Set
    End Property

    Public Property cta_inisl As String
        Get
            Return mcta_inisl
        End Get
        Set(value As String)
            mcta_inisl = value
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
End Class
