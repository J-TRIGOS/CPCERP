Public Class ELTBTRANSPBE
    'Campos de la entidad
    Private mbrevete As String
    Private mcertificado As String
    Private mcod As String
    Private mctct_cod As String
    Private mdir As String
    Private mestado As String
    Private mid As Integer
    Private mmarca As String
    Private mnom As String
    Private mplaca As String
    Private mruc As String
    Private mtelf As String
    Private mvehi As String

    Public Property brevete() As String
        Get
            Return mbrevete
        End Get
        Set(value As String)
            mbrevete = value
        End Set
    End Property

    Public Property certificado() As String
        Get
            Return mcertificado
        End Get
        Set(value As String)
            mcertificado = value
        End Set
    End Property

    Public Property cod() As String
        Get
            Return mcod
        End Get
        Set(value As String)
            mcod = value
        End Set
    End Property

    Public Property ctct_cod() As String
        Get
            Return mctct_cod
        End Get
        Set(value As String)
            mctct_cod = value
        End Set
    End Property

    Public Property dir() As String
        Get
            Return mdir
        End Get
        Set(value As String)
            mdir = value
        End Set
    End Property

    Public Property estado() As String
        Get
            Return mestado
        End Get
        Set(value As String)
            mestado = value
        End Set
    End Property

    Public Property id() As Integer
        Get
            Return mid
        End Get
        Set(value As Integer)
            mid = value
        End Set
    End Property

    Public Property marca() As String
        Get
            Return mmarca
        End Get
        Set(value As String)
            mmarca = value
        End Set
    End Property

    Public Property nom() As String
        Get
            Return mnom
        End Get
        Set(value As String)
            mnom = value
        End Set
    End Property

    Public Property placa() As String
        Get
            Return mplaca
        End Get
        Set(value As String)
            mplaca = value
        End Set
    End Property

    Public Property ruc() As String
        Get
            Return mruc
        End Get
        Set(value As String)
            mruc = value
        End Set
    End Property

    Public Property telf() As String
        Get
            Return mtelf
        End Get
        Set(value As String)
            mtelf = value
        End Set
    End Property

    Public Property vehi() As String
        Get
            Return mvehi
        End Get
        Set(value As String)
            mvehi = value
        End Set
    End Property
End Class
