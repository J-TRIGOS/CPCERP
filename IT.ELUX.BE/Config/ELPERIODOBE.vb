Public Class ELPERIODOBE
    'Campos de la entidad
    Private mcod As Integer
    Private mnum As String
    Private manho As String
    Private mfec_ini As Date
    Private mfec_fin As Date
    Private mfec_pag As Date
    Private mnromes As String
    Private mnroant As Integer
    Private mt_per_cod As String
    Private mx_cont As String

    Public Property cod As Integer
        Get
            Return mcod
        End Get
        Set(value As Integer)
            mcod = value
        End Set
    End Property

    Public Property num As String
        Get
            Return mnum
        End Get
        Set(value As String)
            mnum = value
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

    Public Property fec_pag As Date
        Get
            Return mfec_pag
        End Get
        Set(value As Date)
            mfec_pag = value
        End Set
    End Property

    Public Property nromes As String
        Get
            Return mnromes
        End Get
        Set(value As String)
            mnromes = value
        End Set
    End Property

    Public Property nroant As Integer
        Get
            Return mnroant
        End Get
        Set(value As Integer)
            mnroant = value
        End Set
    End Property

    Public Property t_per_cod As String
        Get
            Return mt_per_cod
        End Get
        Set(value As String)
            mt_per_cod = value
        End Set
    End Property

    Public Property x_cont As String
        Get
            Return mx_cont
        End Get
        Set(value As String)
            mx_cont = value
        End Set
    End Property
End Class
