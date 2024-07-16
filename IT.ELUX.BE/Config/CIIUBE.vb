Public Class CIIUBE
    Private mCodigo As String
    Private mNombre As String
    Private mCod_cambio As String
    Public Property Codigo As String
        Get
            Return mCodigo
        End Get
        Set(value As String)
            mCodigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return mNombre
        End Get
        Set(value As String)
            mNombre = value
        End Set
    End Property

    Public Property Cod_cambio As String
        Get
            Return mCod_cambio
        End Get
        Set(value As String)
            mCod_cambio = value
        End Set
    End Property
End Class
