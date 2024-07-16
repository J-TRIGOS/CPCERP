Public Class ELCONTRATOBE
    'Campos de la entidad
    Private mf_ini As Date
    Private mf_fin As Date
    Private mdni As String
    Private mestado As String
    Private mindice As Integer
    Private mcodusu As String

    Public Property f_ini As Date
        Get
            Return mf_ini
        End Get
        Set(value As Date)
            mf_ini = value
        End Set
    End Property

    Public Property f_fin As Date
        Get
            Return mf_fin
        End Get
        Set(value As Date)
            mf_fin = value
        End Set
    End Property

    Public Property dni As String
        Get
            Return mdni
        End Get
        Set(value As String)
            mdni = value
        End Set
    End Property

    Public Property estado As String
        Get
            Return mestado
        End Get
        Set(value As String)
            mestado = value
        End Set
    End Property

    Public Property indice As Integer
        Get
            Return mindice
        End Get
        Set(value As Integer)
            mindice = value
        End Set
    End Property

    Public Property codusu As String
        Get
            Return mcodusu
        End Get
        Set(value As String)
            mcodusu = value
        End Set
    End Property


    'Propiedades de la entidad

End Class
