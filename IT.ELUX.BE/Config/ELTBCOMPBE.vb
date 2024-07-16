Public Class ELTBCOMPBE

    'Campos de la entidad
    Private mcmp_codart As String
    Private mcmp_codcom As String
    Private mcmp_cantidad As Double
    Private mcmp_factor As Double
    Private mcmp_tipo As String
    Private mcmp_codartraiz As String
    Private mchx_factor As String

    'Propiedades de la entidad
    Public Property cmp_codart() As String
        Get
            Return mcmp_codart
        End Get
        Set(ByVal value As String)
            mcmp_codart = value
        End Set
    End Property

    Public Property cmp_codcom() As String
        Get
            Return mcmp_codcom
        End Get
        Set(ByVal value As String)
            mcmp_codcom = value
        End Set
    End Property

    Public Property cmp_cantidad() As Double
        Get
            Return mcmp_cantidad
        End Get
        Set(ByVal value As Double)
            mcmp_cantidad = value
        End Set
    End Property

    Public Property cmp_factor() As Double
        Get
            Return mcmp_factor
        End Get
        Set(ByVal value As Double)
            mcmp_factor = value
        End Set
    End Property

    Public Property cmp_tipo() As String
        Get
            Return mcmp_tipo
        End Get
        Set(ByVal value As String)
            mcmp_tipo = value
        End Set
    End Property

    Public Property cmp_codartraiz As String
        Get
            Return mcmp_codartraiz
        End Get
        Set(value As String)
            mcmp_codartraiz = value
        End Set
    End Property

    Public Property chx_factor As String
        Get
            Return mchx_factor
        End Get
        Set(value As String)
            mchx_factor = value
        End Set
    End Property
End Class
