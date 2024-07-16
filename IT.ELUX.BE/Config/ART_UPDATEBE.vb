Public Class ART_UPDATEBE
    'Campos de la entidad
    Private mart_cod As String
    Private mdiametro As String
    Private mcolor As String
    Private mcantidad As String
    Private mcalidad As String
    Private mcata As String
    Private mcata1 As String
    Private mdetalle As String

    Public Property art_cod As String
        Get
            Return mart_cod
        End Get
        Set(value As String)
            mart_cod = value
        End Set
    End Property

    Public Property diametro As String
        Get
            Return mdiametro
        End Get
        Set(value As String)
            mdiametro = value
        End Set
    End Property

    Public Property color As String
        Get
            Return mcolor
        End Get
        Set(value As String)
            mcolor = value
        End Set
    End Property

    Public Property cantidad As String
        Get
            Return mcantidad
        End Get
        Set(value As String)
            mcantidad = value
        End Set
    End Property

    Public Property calidad As String
        Get
            Return mcalidad
        End Get
        Set(value As String)
            mcalidad = value
        End Set
    End Property

    Public Property cata As String
        Get
            Return mcata
        End Get
        Set(value As String)
            mcata = value
        End Set
    End Property

    Public Property cata1 As String
        Get
            Return mcata1
        End Get
        Set(value As String)
            mcata1 = value
        End Set
    End Property

    Public Property detalle As String
        Get
            Return mdetalle
        End Get
        Set(value As String)
            mdetalle = value
        End Set
    End Property
End Class
