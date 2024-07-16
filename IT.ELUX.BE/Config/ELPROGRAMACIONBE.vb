Public Class ELPROGRAMACIONBE
    Private mper_cod As String
    Private md_programado As Date
    Private mobservacion As String
    Private mminutos As Integer
    Private mprdo_cod As Integer
    Private musuario As String
    Private mlinea_cod As String
    Private mtiempo_dscto As Integer
    Private mdscto As Integer
    Private mmin1 As Integer
    Private mmin2 As Integer
    Private mt_dscto1 As Integer
    Private mt_dscto2 As Integer

    Public Property per_cod As String
        Get
            Return mper_cod
        End Get
        Set(value As String)
            mper_cod = value
        End Set
    End Property

    Public Property d_programado As Date
        Get
            Return md_programado
        End Get
        Set(value As Date)
            md_programado = value
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

    Public Property minutos As Integer
        Get
            Return mminutos
        End Get
        Set(value As Integer)
            mminutos = value
        End Set
    End Property

    Public Property prdo_cod As Integer
        Get
            Return mprdo_cod
        End Get
        Set(value As Integer)
            mprdo_cod = value
        End Set
    End Property

    Public Property usuario As String
        Get
            Return musuario
        End Get
        Set(value As String)
            musuario = value
        End Set
    End Property

    Public Property linea_cod As String
        Get
            Return mlinea_cod
        End Get
        Set(value As String)
            mlinea_cod = value
        End Set
    End Property

    Public Property tiempo_dscto As Integer
        Get
            Return mtiempo_dscto
        End Get
        Set(value As Integer)
            mtiempo_dscto = value
        End Set
    End Property

    Public Property dscto As Integer
        Get
            Return mdscto
        End Get
        Set(value As Integer)
            mdscto = value
        End Set
    End Property

    Public Property min1 As Integer
        Get
            Return mmin1
        End Get
        Set(value As Integer)
            mmin1 = value
        End Set
    End Property

    Public Property min2 As Integer
        Get
            Return mmin2
        End Get
        Set(value As Integer)
            mmin2 = value
        End Set
    End Property

    Public Property t_dscto1 As Integer
        Get
            Return mt_dscto1
        End Get
        Set(value As Integer)
            mt_dscto1 = value
        End Set
    End Property

    Public Property t_dscto2 As Integer
        Get
            Return mt_dscto2
        End Get
        Set(value As Integer)
            mt_dscto2 = value
        End Set
    End Property

    'Campos de la entidad

End Class

