Public Class T_MOVINVBE

    'Campos de la entidad
    Private mcod As String
    Private mcosto As String
    Private mnom As String
    Private msigno As String
    Private mx_tran As String
    Private mx_modcost As String
    Private mdocmov As String
    Private mser_mov As String
    Private mdrefmov As String
    Private mdguiamov As String
    Private mdcontmov As String
    Private mdortmov As String
    Private mdcontmov_adic As String
    Private mflag As String
    Private mcod_ope As String

    'Propiedades de la entidad
    Public Property cod() As String
        Get
            Return mcod
        End Get
        Set(ByVal value As String)
            mcod = value
        End Set
    End Property

    Public Property costo() As String
        Get
            Return mcosto
        End Get
        Set(ByVal value As String)
            mcosto = value
        End Set
    End Property

    Public Property nom() As String
        Get
            Return mnom
        End Get
        Set(ByVal value As String)
            mnom = value
        End Set
    End Property

    Public Property signo() As String
        Get
            Return msigno
        End Get
        Set(ByVal value As String)
            msigno = value
        End Set
    End Property
    Public Property x_tran() As String
        Get
            Return mx_tran
        End Get
        Set(ByVal value As String)
            mx_tran = value
        End Set
    End Property
    Public Property x_modcost() As String
        Get
            Return mx_modcost
        End Get
        Set(ByVal value As String)
            mx_modcost = value
        End Set
    End Property
    Public Property docmov() As String
        Get
            Return mdocmov
        End Get
        Set(ByVal value As String)
            mdocmov = value
        End Set
    End Property
    Public Property ser_mov() As String
        Get
            Return mser_mov
        End Get
        Set(ByVal value As String)
            mser_mov = value
        End Set
    End Property
    Public Property drefmov() As String
        Get
            Return mdrefmov
        End Get
        Set(ByVal value As String)
            mdrefmov = value
        End Set
    End Property
    Public Property dguiamov() As String
        Get
            Return mdguiamov
        End Get
        Set(ByVal value As String)
            mdguiamov = value
        End Set
    End Property
    Public Property dcontmov() As String
        Get
            Return mdcontmov
        End Get
        Set(ByVal value As String)
            mdcontmov = value
        End Set
    End Property
    Public Property dortmov() As String
        Get
            Return mdortmov
        End Get
        Set(ByVal value As String)
            mdortmov = value
        End Set
    End Property
    Public Property dcontmov_adic() As String
        Get
            Return mdcontmov_adic
        End Get
        Set(ByVal value As String)
            mdcontmov_adic = value
        End Set
    End Property
    Public Property flag() As String
        Get
            Return mflag
        End Get
        Set(ByVal value As String)
            mflag = value
        End Set
    End Property
    Public Property cod_ope() As String
        Get
            Return mcod_ope
        End Get
        Set(ByVal value As String)
            mcod_ope = value
        End Set
    End Property
End Class
