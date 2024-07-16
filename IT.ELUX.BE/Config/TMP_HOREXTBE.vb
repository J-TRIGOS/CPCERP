Public Class TMP_HOREXTBE
    Private manho As String
    Private mprdo_cod As String
    Private mprdo_cod1 As String
    Private mtipo As String
    Private mmes As String
    Private mhoras As String
    Private mcco_cod As String

    Public Property anho As String
        Get
            Return manho
        End Get
        Set(value As String)
            manho = value
        End Set
    End Property

    Public Property prdo_cod As String
        Get
            Return mprdo_cod
        End Get
        Set(value As String)
            mprdo_cod = value
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

    Public Property mes As String
        Get
            Return mmes
        End Get
        Set(value As String)
            mmes = value
        End Set
    End Property

    Public Property horas As String
        Get
            Return mhoras
        End Get
        Set(value As String)
            mhoras = value
        End Set
    End Property

    Public Property cco_cod As String
        Get
            Return mcco_cod
        End Get
        Set(value As String)
            mcco_cod = value
        End Set
    End Property

    Public Property prdo_cod1 As String
        Get
            Return mprdo_cod1
        End Get
        Set(value As String)
            mprdo_cod1 = value
        End Set
    End Property
End Class
