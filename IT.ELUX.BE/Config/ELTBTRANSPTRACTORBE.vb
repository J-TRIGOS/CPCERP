Public Class ELTBTRANSPTRACTORBE
    'Campos de la entidad
    Private mctct_cod As String
    Private mplaca As String
    Private mnro As String
    Private mmarca As String
    Private mtipo As String
    Private mobservacion As String
    Private mcertificado As String
    Private mconfig_vehi As String
    Private mcor As Integer

    Public Property ctct_cod As String
        Get
            Return mctct_cod
        End Get
        Set(value As String)
            mctct_cod = value
        End Set
    End Property

    Public Property placa As String
        Get
            Return mplaca
        End Get
        Set(value As String)
            mplaca = value
        End Set
    End Property

    Public Property nro As String
        Get
            Return mnro
        End Get
        Set(value As String)
            mnro = value
        End Set
    End Property

    Public Property marca As String
        Get
            Return mmarca
        End Get
        Set(value As String)
            mmarca = value
        End Set
    End Property

    Public Property tipo As String
        Get
            Return mtipo
        End Get
        Set(value As String)
            mtipo = value
        End Set
    End Property

    Public Property observacion As String
        Get
            Return mobservacion
        End Get
        Set(value As String)
            mobservacion = value
        End Set
    End Property

    Public Property certificado As String
        Get
            Return mcertificado
        End Get
        Set(value As String)
            mcertificado = value
        End Set
    End Property

    Public Property config_vehi As String
        Get
            Return mconfig_vehi
        End Get
        Set(value As String)
            mconfig_vehi = value
        End Set
    End Property
    Public Property cor As Integer
        Get
            Return mcor
        End Get
        Set(value As Integer)
            mcor = value
        End Set
    End Property
End Class
