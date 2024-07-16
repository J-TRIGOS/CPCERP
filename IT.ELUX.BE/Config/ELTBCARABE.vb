Public Class ELTBCARABE
    'Campos de la entidad
    Private mcar_codigo As String
    Private mcar_descri As String
    Private mcar_oblig As String
    Private mcar_codest As String

    'Propiedades de la entidad
    Public Property car_codigo() As String
        Get
            Return mcar_codigo
        End Get
        Set(ByVal value As String)
            mcar_codigo = value
        End Set
    End Property

    Public Property car_descri() As String
        Get
            Return mcar_descri
        End Get
        Set(ByVal value As String)
            mcar_descri = value
        End Set
    End Property

    Public Property car_oblig() As String
        Get
            Return mcar_oblig
        End Get
        Set(ByVal value As String)
            mcar_oblig = value
        End Set
    End Property

    Public Property car_codest() As String
        Get
            Return mcar_codest
        End Get
        Set(ByVal value As String)
            mcar_codest = value
        End Set
    End Property
End Class
