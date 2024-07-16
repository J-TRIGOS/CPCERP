Public Class ELTBREAPBE
    'Campos de la entidad
    Private mCOD_AREA As String
    Private mCOD_PROC As String
    Private mRAP_ITEM As String

    'Propiedades de la entidad
    Public Property COD_AREA() As String
        Get
            Return mCOD_AREA
        End Get
        Set(ByVal value As String)
            mCOD_AREA = value
        End Set
    End Property

    Public Property COD_PROC() As String
        Get
            Return mCOD_PROC
        End Get
        Set(ByVal value As String)
            mCOD_PROC = value
        End Set
    End Property
    Public Property RAP_ITEM() As String
        Get
            Return mRAP_ITEM
        End Get
        Set(ByVal value As String)
            mRAP_ITEM = value
        End Set
    End Property
End Class
