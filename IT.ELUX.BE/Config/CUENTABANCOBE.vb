Public Class CUENTABANCOBE

    'Campos de la entidad
    Private manho As String
    Private mcbco_cod As Double
    Private mcta_cod As String

    Public Property anho As String
        Get
            Return manho
        End Get
        Set(value As String)
            manho = value
        End Set
    End Property

    Public Property cbco_cod As Double
        Get
            Return mcbco_cod
        End Get
        Set(value As Double)
            mcbco_cod = value
        End Set
    End Property

    Public Property cta_cod As String
        Get
            Return mcta_cod
        End Get
        Set(value As String)
            mcta_cod = value
        End Set
    End Property

End Class
