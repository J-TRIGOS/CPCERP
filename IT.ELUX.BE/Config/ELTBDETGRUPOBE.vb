Public Class ELTBDETGRUPOBE
    Private mcod_grupo As String
    Private mper_cod As String
    'Propiedades de la entidad
    Public Property cod_grupo() As String
        Get
            Return mcod_grupo
        End Get
        Set(ByVal value As String)
            mcod_grupo = value
        End Set
    End Property

    Public Property per_cod() As String
        Get
            Return mper_cod
        End Get
        Set(ByVal value As String)
            mper_cod = value
        End Set
    End Property
End Class
