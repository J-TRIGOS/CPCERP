Public Class IMPUESTOBE
    'Campos de la entidad
    Private mcod As String
    Private mnom As String
    Private mtipo As String
    Private mporc As Double
    Private mafecto As String
    Private mimporte As String

    Public Property cod As String
        Get
            Return mcod
        End Get
        Set(value As String)
            mcod = value
        End Set
    End Property

    Public Property nom As String
        Get
            Return mnom
        End Get
        Set(value As String)
            mnom = value
        End Set
    End Property

    Public Property tipo As String
        Get
            Return mtipo
        End Get
        Set(value As String)
            mtipo = value
        End Set
    End Property

    Public Property porc As Double
        Get
            Return mporc
        End Get
        Set(value As Double)
            mporc = value
        End Set
    End Property

    Public Property afecto As String
        Get
            Return mafecto
        End Get
        Set(value As String)
            mafecto = value
        End Set
    End Property

    Public Property importe As String
        Get
            Return mimporte
        End Get
        Set(value As String)
            mimporte = value
        End Set
    End Property
End Class
