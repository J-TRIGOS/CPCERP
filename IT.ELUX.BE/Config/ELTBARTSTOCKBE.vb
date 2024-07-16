Public Class ELTBARTSTOCKBE
    Private mART_CODALM As String
    Private mART_CODIGO As String
    Private mART_STOACT As Double
    Private mART_STKFISICO1 As Double

    Public Property ART_CODALM As String
        Get
            Return mART_CODALM
        End Get
        Set(value As String)
            mART_CODALM = value
        End Set
    End Property

    Public Property ART_CODIGO As String
        Get
            Return mART_CODIGO
        End Get
        Set(value As String)
            mART_CODIGO = value
        End Set
    End Property

    Public Property ART_STOACT As Double
        Get
            Return mART_STOACT
        End Get
        Set(value As Double)
            mART_STOACT = value
        End Set
    End Property

    Public Property ART_STKFISICO1 As Double
        Get
            Return mART_STKFISICO1
        End Get
        Set(value As Double)
            mART_STKFISICO1 = value
        End Set
    End Property
End Class
