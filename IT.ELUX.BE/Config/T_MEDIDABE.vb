Public Class T_MEDIDABE
    'Campos de la entidad
    Private mcod As String
    Private mcodtemp As String
    Private mnom As String
    Private msituacion As String
    Private mt_env As String
    Private mlinea_cod As String
    Private mmed_formato As String
    Private mdesc_corta As String
    Private mcod_nuevo As String

    'Propiedades de la entidad
    Public Property cod() As String
        Get
            Return mcod
        End Get
        Set(ByVal value As String)
            mcod = value
        End Set
    End Property
    Public Property cod_nuevo() As String
        Get
            Return mcod_nuevo
        End Get
        Set(ByVal value As String)
            mcod_nuevo = value
        End Set
    End Property

    Public Property codtemp() As String
        Get
            Return mcod
        End Get
        Set(ByVal value As String)
            mcod = value
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

    Public Property situacion() As String
        Get
            Return msituacion
        End Get
        Set(ByVal value As String)
            msituacion = value
        End Set
    End Property
    Public Property t_env() As String
        Get
            Return mt_env
        End Get
        Set(ByVal value As String)
            mt_env = value
        End Set
    End Property
    Public Property linea_cod() As String
        Get
            Return mlinea_cod
        End Get
        Set(ByVal value As String)
            mlinea_cod = value
        End Set
    End Property
    Public Property med_formato() As String
        Get
            Return mmed_formato
        End Get
        Set(ByVal value As String)
            mmed_formato = value
        End Set
    End Property
    Public Property desc_corta() As String
        Get
            Return mdesc_corta
        End Get
        Set(ByVal value As String)
            mdesc_corta = value
        End Set
    End Property
End Class
