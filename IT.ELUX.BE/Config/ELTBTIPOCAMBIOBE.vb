Public Class ELTBTIPOCAMBIOBE
    'Campos de la entidad
    Private mfec As String
    Private mfec1 As String
    Private mmon_cod As String
    Private mmon_cod_ref As String
    Private mcompra As Double
    Private mventa As Double
    Private mtipo As String

    Public Property fec As String
        Get
            Return mfec
        End Get
        Set(value As String)
            mfec = value
        End Set
    End Property

    Public Property fec1 As String
        Get
            Return mfec1
        End Get
        Set(value As String)
            mfec1 = value
        End Set
    End Property

    Public Property mon_cod As String
        Get
            Return mmon_cod
        End Get
        Set(value As String)
            mmon_cod = value
        End Set
    End Property

    Public Property mon_cod_ref As String
        Get
            Return mmon_cod_ref
        End Get
        Set(value As String)
            mmon_cod_ref = value
        End Set
    End Property

    Public Property compra As Double
        Get
            Return mcompra
        End Get
        Set(value As Double)
            mcompra = value
        End Set
    End Property

    Public Property venta As Double
        Get
            Return mventa
        End Get
        Set(value As Double)
            mventa = value
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
End Class
