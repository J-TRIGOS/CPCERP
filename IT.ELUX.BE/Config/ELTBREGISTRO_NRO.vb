Public Class ELTBREGISTRO_NROBE
    'Campos de la entidad
    Private manho As String
    Private mmes As String
    Private mt_ope_cod As String
    Private mpref_bco As String
    Private mreg_nro As String

    Public Property anho As String
        Get
            Return manho
        End Get
        Set(value As String)
            manho = value
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

    Public Property t_ope_cod As String
        Get
            Return mt_ope_cod
        End Get
        Set(value As String)
            mt_ope_cod = value
        End Set
    End Property

    Public Property pref_bco As String
        Get
            Return mpref_bco
        End Get
        Set(value As String)
            mpref_bco = value
        End Set
    End Property

    Public Property reg_nro As String
        Get
            Return mreg_nro
        End Get
        Set(value As String)
            mreg_nro = value
        End Set
    End Property
End Class
