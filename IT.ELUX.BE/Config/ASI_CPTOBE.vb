Public Class ASI_CPTOBE
    Private mper_cod As String
    Private mcpto_cod As String
    Private mmonto As Double
    Private mmon_cod As String
    Private mx_hist As String

    Public Property per_cod As String
        Get
            Return mper_cod
        End Get
        Set(value As String)
            mper_cod = value
        End Set
    End Property

    Public Property cpto_cod As String
        Get
            Return mcpto_cod
        End Get
        Set(value As String)
            mcpto_cod = value
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

    Public Property mon_cod As String
        Get
            Return mmon_cod
        End Get
        Set(value As String)
            mmon_cod = value
        End Set
    End Property

    Public Property x_hist As String
        Get
            Return mx_hist
        End Get
        Set(value As String)
            mx_hist = value
        End Set
    End Property
End Class
