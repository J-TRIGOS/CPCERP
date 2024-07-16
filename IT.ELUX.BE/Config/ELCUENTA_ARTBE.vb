Public Class ELCUENTA_ARTBE
    Private mart_anho As String
    Private mart_codigo As String
    Private mart_cuenta As String
    Private mart_estado As String

    Public Property art_anho As String
        Get
            Return mart_anho
        End Get
        Set(value As String)
            mart_anho = value
        End Set
    End Property

    Public Property art_codigo As String
        Get
            Return mart_codigo
        End Get
        Set(value As String)
            mart_codigo = value
        End Set
    End Property

    Public Property art_cuenta As String
        Get
            Return mart_cuenta
        End Get
        Set(value As String)
            mart_cuenta = value
        End Set
    End Property

    Public Property art_estado As String
        Get
            Return mart_estado
        End Get
        Set(value As String)
            mart_estado = value
        End Set
    End Property
End Class
