Public Class ELVACACIONESBE
    Private mper_cod As String
    Private mdias As Integer
    Private mfec_ini As Date
    Private mfec_fin As Date
    Private mobservacion As String
    Private mprdo_cod As Integer
    Private msusp_cod As String
    Private mfec_ini_vac As Date
    Private mfec_fin_vac As Date
    Private mindice As String

    Public Property per_cod As String
        Get
            Return mper_cod
        End Get
        Set(value As String)
            mper_cod = value
        End Set
    End Property

    Public Property dias As Integer
        Get
            Return mdias
        End Get
        Set(value As Integer)
            mdias = value
        End Set
    End Property

    Public Property fec_ini As Date
        Get
            Return mfec_ini
        End Get
        Set(value As Date)
            mfec_ini = value
        End Set
    End Property

    Public Property fec_fin As Date
        Get
            Return mfec_fin
        End Get
        Set(value As Date)
            mfec_fin = value
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

    Public Property prdo_cod As Integer
        Get
            Return mprdo_cod
        End Get
        Set(value As Integer)
            mprdo_cod = value
        End Set
    End Property

    Public Property susp_cod As String
        Get
            Return msusp_cod
        End Get
        Set(value As String)
            msusp_cod = value
        End Set
    End Property

    Public Property fec_ini_vac As Date
        Get
            Return mfec_ini_vac
        End Get
        Set(value As Date)
            mfec_ini_vac = value
        End Set
    End Property

    Public Property fec_fin_vac As Date
        Get
            Return mfec_fin_vac
        End Get
        Set(value As Date)
            mfec_fin_vac = value
        End Set
    End Property

    Public Property indice As String
        Get
            Return mindice
        End Get
        Set(value As String)
            mindice = value
        End Set
    End Property

    'Campos de la entidad

End Class

