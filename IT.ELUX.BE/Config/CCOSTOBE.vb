Public Class CCOSTOBE
    Private mcod As String
    Private mnom As String
    Private mccosto_codigo As String
    Private mccosto_descri As String
    Private mccosto_uninego As String
    Private mest As String
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
    Public Property ccosto_codigo() As String
        Get
            Return mccosto_codigo
        End Get
        Set(ByVal value As String)
            mccosto_codigo = value
        End Set
    End Property
    Public Property ccosto_descri() As String
        Get
            Return mccosto_descri
        End Get
        Set(ByVal value As String)
            mccosto_descri = value
        End Set
    End Property
    Public Property ccosto_uninego() As String
        Get
            Return mccosto_uninego
        End Get
        Set(ByVal value As String)
            mccosto_uninego = value
        End Set
    End Property
    Public Property est() As String
        Get
            Return mest
        End Get
        Set(ByVal value As String)
            mest = value
        End Set
    End Property
End Class
