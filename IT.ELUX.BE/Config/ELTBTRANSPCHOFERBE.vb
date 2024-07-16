Public Class ELTBTRANSPCHOFERBE
    'Campos de la entidad
    Private mctct_cod As String
    Private mchofer As String
    Private mbrevete As String
    Private mobserva As String
    Private mcho_cod As String

    Public Property ctct_cod() As String
        Get
            Return mctct_cod
        End Get
        Set(value As String)
            mctct_cod = value
        End Set
    End Property

    Public Property chofer() As String
        Get
            Return mchofer
        End Get
        Set(value As String)
            mchofer = value
        End Set
    End Property

    Public Property brevete() As String
        Get
            Return mbrevete
        End Get
        Set(value As String)
            mbrevete = value
        End Set
    End Property

    Public Property observa() As String
        Get
            Return mobserva
        End Get
        Set(value As String)
            mobserva = value
        End Set
    End Property

    Public Property cho_cod() As String
        Get
            Return mcho_cod
        End Get
        Set(value As String)
            mcho_cod = value
        End Set
    End Property
End Class
