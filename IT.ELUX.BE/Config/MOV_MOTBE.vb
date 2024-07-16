Public Class MOV_MOTBE
    Private mCOD As String
    Private mNOM As String
    Private mTIP_DOC As String
    Private mCOD1 As String

    Public Property COD As String
        Get
            Return mCOD
        End Get
        Set(value As String)
            mCOD = value
        End Set
    End Property

    Public Property NOM As String
        Get
            Return mNOM
        End Get
        Set(value As String)
            mNOM = value
        End Set
    End Property

    Public Property TIP_DOC As String
        Get
            Return mTIP_DOC
        End Get
        Set(value As String)
            mTIP_DOC = value
        End Set
    End Property

    Public Property COD1 As String
        Get
            Return mCOD1
        End Get
        Set(value As String)
            mCOD1 = value
        End Set
    End Property
End Class
