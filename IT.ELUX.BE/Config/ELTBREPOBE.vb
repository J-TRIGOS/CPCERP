Public Class ELTBREPOBE
    'Campos de la entidad
    Private mRPO_CODOPER As String
    Private mRPO_CODPROC As String
    Private mRPO_ITEM As String
    Private mCANTIDAD As Double

    'Propiedades de la entidad
    Public Property RPO_CODOPER() As String
        Get
            Return mRPO_CODOPER
        End Get
        Set(ByVal value As String)
            mRPO_CODOPER = value
        End Set
    End Property

    Public Property RPO_CODPROC() As String
        Get
            Return mRPO_CODPROC
        End Get
        Set(ByVal value As String)
            mRPO_CODPROC = value
        End Set
    End Property

    Public Property CANTIDAD() As Double
        Get
            Return mCANTIDAD
        End Get
        Set(ByVal value As Double)
            mCANTIDAD = value
        End Set
    End Property
End Class
