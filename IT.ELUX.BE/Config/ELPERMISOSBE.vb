Public Class ELPERMISOSBE
    Private mdias As Integer
    Private mfec_fin As Date
    Private mfec_ini As Date
    Private mhoras As Integer
    Private mminutos As Integer
    Private mminutos1 As Integer
    Private mmotivo As String
    Private mmotivo1 As String
    Private mobservacion As String
    Private mper_cod As String
    Private msubs As String
    Private msdoc As String
    Private mndoc As String

    Public Property dias As Integer
        Get
            Return mdias
        End Get
        Set(value As Integer)
            mdias = value
        End Set
    End Property

    Public Property fec_fin As Date
        Get
            Return mfec_fin
        End Get
        Set(value As Date)
            mfec_fin = value
        End Set
    End Property

    Public Property fec_ini As Date
        Get
            Return mfec_ini
        End Get
        Set(value As Date)
            mfec_ini = value
        End Set
    End Property

    Public Property horas As Integer
        Get
            Return mhoras
        End Get
        Set(value As Integer)
            mhoras = value
        End Set
    End Property

    Public Property minutos As Integer
        Get
            Return mminutos
        End Get
        Set(value As Integer)
            mminutos = value
        End Set
    End Property

    Public Property minutos1 As Integer
        Get
            Return mminutos1
        End Get
        Set(value As Integer)
            mminutos1 = value
        End Set
    End Property

    Public Property motivo As String
        Get
            Return mmotivo
        End Get
        Set(value As String)
            mmotivo = value
        End Set
    End Property

    Public Property motivo1 As String
        Get
            Return mmotivo1
        End Get
        Set(value As String)
            mmotivo1 = value
        End Set
    End Property

    Public Property observacion As String
        Get
            Return mobservacion
        End Get
        Set(value As String)
            mobservacion = value
        End Set
    End Property

    Public Property per_cod As String
        Get
            Return mper_cod
        End Get
        Set(value As String)
            mper_cod = value
        End Set
    End Property

    Public Property subs As String
        Get
            Return msubs
        End Get
        Set(value As String)
            msubs = value
        End Set
    End Property

    Public Property sdoc As String
        Get
            Return msdoc
        End Get
        Set(value As String)
            msdoc = value
        End Set
    End Property

    Public Property ndoc As String
        Get
            Return mndoc
        End Get
        Set(value As String)
            mndoc = value
        End Set
    End Property


    'Campos de la entidad

End Class

