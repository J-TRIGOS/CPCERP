Public Class ELETIQUETABE
    Private mcliente As String
    Private marticulo As String
    Private mcantidad As Double
    Private mmedida As String
    Private mtipo As String
    Private mlote As String
    Private mfecha_produ As Date
    Private mlote_envase As String
    Private mcod As String
    Private mtotal As Double
    Private mestado As String
    Private membalador As String

    Public Property cliente As String
        Get
            Return mcliente
        End Get
        Set(value As String)
            mcliente = value
        End Set
    End Property

    Public Property articulo As String
        Get
            Return marticulo
        End Get
        Set(value As String)
            marticulo = value
        End Set
    End Property

    Public Property cantidad As Double
        Get
            Return mcantidad
        End Get
        Set(value As Double)
            mcantidad = value
        End Set
    End Property

    Public Property medida As String
        Get
            Return mmedida
        End Get
        Set(value As String)
            mmedida = value
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

    Public Property lote As String
        Get
            Return mlote
        End Get
        Set(value As String)
            mlote = value
        End Set
    End Property

    Public Property fecha_produ As Date
        Get
            Return mfecha_produ
        End Get
        Set(value As Date)
            mfecha_produ = value
        End Set
    End Property

    Public Property lote_envase As String
        Get
            Return mlote_envase
        End Get
        Set(value As String)
            mlote_envase = value
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

    Public Property total As Double
        Get
            Return mtotal
        End Get
        Set(value As Double)
            mtotal = value
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

    Public Property embalador As String
        Get
            Return membalador
        End Get
        Set(value As String)
            membalador = value
        End Set
    End Property

End Class
