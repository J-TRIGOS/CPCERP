Public Class ELDECLARACIONDUABE
    Private mt_doc_ref As String
    Private mser_doc_ref As String
    Private mnro_doc_ref As String
    Private mt_doc_ref1 As String
    Private mser_doc_ref1 As String
    Private mnro_doc_ref1 As String
    Private mart_cod As String
    Private mnro_dua As String
    Private mser_dua As String
    Private mart_dua As String
    Private mfecha As String

    Public Property t_doc_ref As String
        Get
            Return mt_doc_ref
        End Get
        Set(value As String)
            mt_doc_ref = value
        End Set
    End Property

    Public Property ser_doc_ref As String
        Get
            Return mser_doc_ref
        End Get
        Set(value As String)
            mser_doc_ref = value
        End Set
    End Property

    Public Property nro_doc_ref As String
        Get
            Return mnro_doc_ref
        End Get
        Set(value As String)
            mnro_doc_ref = value
        End Set
    End Property

    Public Property t_doc_ref1 As String
        Get
            Return mt_doc_ref1
        End Get
        Set(value As String)
            mt_doc_ref1 = value
        End Set
    End Property

    Public Property ser_doc_ref1 As String
        Get
            Return mser_doc_ref1
        End Get
        Set(value As String)
            mser_doc_ref1 = value
        End Set
    End Property

    Public Property nro_doc_ref1 As String
        Get
            Return mnro_doc_ref1
        End Get
        Set(value As String)
            mnro_doc_ref1 = value
        End Set
    End Property

    Public Property art_cod As String
        Get
            Return mart_cod
        End Get
        Set(value As String)
            mart_cod = value
        End Set
    End Property

    Public Property nro_dua As String
        Get
            Return mnro_dua
        End Get
        Set(value As String)
            mnro_dua = value
        End Set
    End Property

    Public Property ser_dua As String
        Get
            Return mser_dua
        End Get
        Set(value As String)
            mser_dua = value
        End Set
    End Property

    Public Property art_dua As String
        Get
            Return mart_dua
        End Get
        Set(value As String)
            mart_dua = value
        End Set
    End Property

    Public Property fecha As String
        Get
            Return mfecha
        End Get
        Set(value As String)
            mfecha = value
        End Set
    End Property
End Class
