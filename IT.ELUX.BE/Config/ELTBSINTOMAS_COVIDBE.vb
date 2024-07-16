Public Class ELTBSINTOMAS_COVIDBE
    Dim mt_doc_ref As String
    Dim mser_doc_ref As String
    Dim mnro_doc_ref As String
    Dim mdni As String
    Dim mfec_gene As Date
    Dim ms1 As String
    Dim ms2 As String
    Dim ms3 As String
    Dim ms4 As String
    Dim ms5 As String
    Dim mdescri As String
    Dim mest As String

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

    Public Property dni As String
        Get
            Return mdni
        End Get
        Set(value As String)
            mdni = value
        End Set
    End Property

    Public Property fec_gene As Date
        Get
            Return mfec_gene
        End Get
        Set(value As Date)
            mfec_gene = value
        End Set
    End Property

    Public Property s1 As String
        Get
            Return ms1
        End Get
        Set(value As String)
            ms1 = value
        End Set
    End Property

    Public Property s2 As String
        Get
            Return ms2
        End Get
        Set(value As String)
            ms2 = value
        End Set
    End Property

    Public Property s3 As String
        Get
            Return ms3
        End Get
        Set(value As String)
            ms3 = value
        End Set
    End Property

    Public Property s4 As String
        Get
            Return ms4
        End Get
        Set(value As String)
            ms4 = value
        End Set
    End Property

    Public Property s5 As String
        Get
            Return ms5
        End Get
        Set(value As String)
            ms5 = value
        End Set
    End Property

    Public Property descri As String
        Get
            Return mdescri
        End Get
        Set(value As String)
            mdescri = value
        End Set
    End Property

    Public Property est As String
        Get
            Return mest
        End Get
        Set(value As String)
            mest = value
        End Set
    End Property
End Class
