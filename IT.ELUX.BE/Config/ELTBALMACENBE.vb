Public Class ELTBALMACENBE

    'Campos de la entidad
    Private malm_codigo As String
    Private malm_descri As String
    Private malm_direccion As String
    Private malm_codest As String

    'Propiedades de la entidad
    Public Property alm_codigo() As String
        Get
            Return malm_codigo
        End Get
        Set(ByVal value As String)
            malm_codigo = value
        End Set
    End Property

    Public Property alm_descri() As String
        Get
            Return malm_descri
        End Get
        Set(ByVal value As String)
            malm_descri = value
        End Set
    End Property

    Public Property alm_direccion() As String
        Get
            Return malm_direccion
        End Get
        Set(ByVal value As String)
            malm_direccion = value
        End Set
    End Property

    Public Property alm_codest() As String
        Get
            Return malm_codest
        End Get
        Set(ByVal value As String)
            malm_codest = value
        End Set
    End Property
End Class
