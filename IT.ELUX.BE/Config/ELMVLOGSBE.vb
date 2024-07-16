Public Class ELMVLOGSBE
    Private mlog_codigo As String
    Private mlog_codope As String
    Private mlog_codusu As String
    Private mlog_fecing As Date
    Private mlog_observ As String
    Public Property log_codigo() As String
        Get
            Return mlog_codigo
        End Get
        Set(ByVal value As String)
            mlog_codigo = value
        End Set
    End Property

    Public Property log_codope() As String
        Get
            Return mlog_codope
        End Get
        Set(ByVal value As String)
            mlog_codope = value
        End Set
    End Property
    Public Property log_codusu() As String
        Get
            Return mlog_codusu
        End Get
        Set(ByVal value As String)
            mlog_codusu = value
        End Set
    End Property
    Public Property log_fecing() As Date
        Get
            Return mlog_fecing
        End Get
        Set(ByVal value As Date)
            mlog_fecing = value
        End Set
    End Property
    Public Property log_observ() As String
        Get
            Return mlog_observ
        End Get
        Set(ByVal value As String)
            mlog_observ = value
        End Set
    End Property

End Class
