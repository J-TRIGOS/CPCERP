Public Class ELUTILIDADESBE
    'Campos de la entidad
    Private mper_cod As String
    Private manho As String
    Private mmonto As Double
    Private mdscto As Double
    Private mdia_pago As Date
    Private mobservacion As String

    Public Property per_cod As String
        Get
            Return mper_cod
        End Get
        Set(value As String)
            mper_cod = value
        End Set
    End Property

    Public Property anho As String
        Get
            Return manho
        End Get
        Set(value As String)
            manho = value
        End Set
    End Property

    Public Property monto As Double
        Get
            Return mmonto
        End Get
        Set(value As Double)
            mmonto = value
        End Set
    End Property

    Public Property dscto As Double
        Get
            Return mdscto
        End Get
        Set(value As Double)
            mdscto = value
        End Set
    End Property

    Public Property dia_pago As Date
        Get
            Return mdia_pago
        End Get
        Set(value As Date)
            mdia_pago = value
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
End Class
