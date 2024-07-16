Public Class ELTBINICIALCBBE
    Private mCTABCO As String
    Private mANHO As String
    Private mMONTO As Double

    Public Property ANHO As String
        Get
            Return mANHO
        End Get
        Set(value As String)
            mANHO = value
        End Set
    End Property

    Public Property MONTO As Double
        Get
            Return mMONTO
        End Get
        Set(value As Double)
            mMONTO = value
        End Set
    End Property

    Public Property CTABCO As String
        Get
            Return mCTABCO
        End Get
        Set(value As String)
            mCTABCO = value
        End Set
    End Property
End Class
