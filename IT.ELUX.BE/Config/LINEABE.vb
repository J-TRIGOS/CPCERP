Public Class LINEABE
    'AREA
    Private mcod As String
    Private mnom As String
    Private msituacion As String
    Private mccosto_cod As String
    Private mlinea_ccosto_codigo As String
    Public Property cod() As String
        Get
            Return mcod
        End Get
        Set(ByVal value As String)
            mcod = value
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
    Public Property ccosto_cod() As String
        Get
            Return mccosto_cod
        End Get
        Set(ByVal value As String)
            mccosto_cod = value
        End Set
    End Property
    Public Property linea_ccosto_codigo() As String
        Get
            Return mlinea_ccosto_codigo
        End Get
        Set(ByVal value As String)
            mlinea_ccosto_codigo = value
        End Set
    End Property
End Class
