Public Class FORMA_PAGOBE

    'Campos de la entidad
    Private mcod As String
    Private mnom As String
    Private mcantp As Double
    Private mx_int As String
    Private mx_mora As String
    Private mpint As Double
    Private mprdo_rc As Double
    Private mx_cont As String
    Private mestado As String
    Private mt_doc_cod As String

    Public Property cod As String
        Get
            Return mcod
        End Get
        Set(value As String)
            mcod = value
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

    Public Property cantp As Double
        Get
            Return mcantp
        End Get
        Set(value As Double)
            mcantp = value
        End Set
    End Property

    Public Property x_int As String
        Get
            Return mx_int
        End Get
        Set(value As String)
            mx_int = value
        End Set
    End Property

    Public Property x_mora As String
        Get
            Return mx_mora
        End Get
        Set(value As String)
            mx_mora = value
        End Set
    End Property

    Public Property pint As Double
        Get
            Return mpint
        End Get
        Set(value As Double)
            mpint = value
        End Set
    End Property

    Public Property prdo_rc As Double
        Get
            Return mprdo_rc
        End Get
        Set(value As Double)
            mprdo_rc = value
        End Set
    End Property

    Public Property x_cont As String
        Get
            Return mx_cont
        End Get
        Set(value As String)
            mx_cont = value
        End Set
    End Property

    Public Property estado As String
        Get
            Return mestado
        End Get
        Set(value As String)
            mestado = value
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


    'Propiedades de la entidad

End Class
