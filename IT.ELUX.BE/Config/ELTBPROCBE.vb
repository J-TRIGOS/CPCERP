Public Class ELTBPROCBE
    'Campos de la entidad
    Private mcod As String
    Private mdescripcion As String
    Private mest As String
    Private munidhora As Double
    Private mtipo As String
    Private mnpases_proc As Int32

    'Propiedades de la entidad
    Public Property cod() As String
        Get
            Return mcod
        End Get
        Set(ByVal value As String)
            mcod = value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return mdescripcion
        End Get
        Set(ByVal value As String)
            mdescripcion = value
        End Set
    End Property

    Public Property est() As String
        Get
            Return mest
        End Get
        Set(ByVal value As String)
            mest = value
        End Set
    End Property
    Public Property unidhora() As Double
        Get
            Return munidhora
        End Get
        Set(ByVal value As Double)
            munidhora = value
        End Set
    End Property
    Public Property tipo() As String
        Get
            Return mtipo
        End Get
        Set(ByVal value As String)
            mtipo = value
        End Set
    End Property

    Public Property npases_proc As Int32
        Get
            Return mnpases_proc
        End Get
        Set(value As Int32)
            mnpases_proc = value
        End Set
    End Property
End Class

