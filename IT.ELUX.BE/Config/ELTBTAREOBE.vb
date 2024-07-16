Public Class ELTBTAREOBE
    'Campos de la entidad
    Private mcod As String
    Private mfecha As DateTime
    Private musuario As String
    Private mfecha_ingreso As DateTime
    Private mid As String
    Private mfecha_ant As String
    Private musuactu As String

    Public Property cod As String
        Get
            Return mcod
        End Get
        Set(value As String)
            mcod = value
        End Set
    End Property

    Public Property fecha As Date
        Get
            Return mfecha
        End Get
        Set(value As Date)
            mfecha = value
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

    Public Property fecha_ingreso As Date
        Get
            Return mfecha_ingreso
        End Get
        Set(value As Date)
            mfecha_ingreso = value
        End Set
    End Property

    Public Property id As String
        Get
            Return mid
        End Get
        Set(value As String)
            [mid] = value
        End Set
    End Property

    Public Property fecha_ant As String
        Get
            Return mfecha_ant
        End Get
        Set(value As String)
            mfecha_ant = value
        End Set
    End Property

    Public Property usuactu As String
        Get
            Return musuactu
        End Get
        Set(value As String)
            musuactu = value
        End Set
    End Property




    'Propiedades de la entidad

End Class
