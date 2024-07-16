Public Class ELTBAREABE
    'Campos de la entidad
    Private mcod As String
    Private mcco_cod As String
    Private mnom As String
    Private msituacion As String

    'Propiedades de la entidad
    Public Property cod() As String
        Get
            Return mcod
        End Get
        Set(ByVal value As String)
            mcod = value
        End Set
    End Property

    Public Property cco_cod() As String
        Get
            Return mcco_cod
        End Get
        Set(ByVal value As String)
            mcco_cod = value
        End Set
    End Property

    Public Property nom() As String
        Get
            Return mnom
        End Get
        Set(ByVal value As String)
            mnom = value
        End Set
    End Property

    Public Property situacion() As String
        Get
            Return msituacion
        End Get
        Set(ByVal value As String)
            msituacion = value
        End Set
    End Property
End Class
