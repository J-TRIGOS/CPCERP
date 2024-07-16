Public Class ELTBESPEBE
    'Campos de la entidad
    Private mesp_codart As String
    Private mesp_codcat As String
    Private mesp_codcar As String
    Private mesp_dato As String

    'Propiedades de la entidad
    Public Property esp_codart() As String
        Get
            Return mesp_codart
        End Get
        Set(ByVal value As String)
            mesp_codart = value
        End Set
    End Property

    Public Property esp_codcat() As String
        Get
            Return mesp_codcat
        End Get
        Set(ByVal value As String)
            mesp_codcat = value
        End Set
    End Property

    Public Property esp_codcar() As String
        Get
            Return mesp_codcar
        End Get
        Set(ByVal value As String)
            mesp_codcar = value
        End Set
    End Property

    Public Property esp_dato() As String
        Get
            Return mesp_dato
        End Get
        Set(ByVal value As String)
            mesp_dato = value
        End Set
    End Property
End Class
