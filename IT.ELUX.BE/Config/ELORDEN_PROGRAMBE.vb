Public Class ELORDEN_PROGRAMBE

    Private mt_doc_ref As String
    Private mser_doc_ref As String
    Private mnro_doc_ref As String
    Private mcco_cod As String
    Private mcod_area As String
    Private mcod_grupo As String
    Private mturno As String
    Private mfec_gene As Date
    Private mfec_ini As Date
    Private mhora_ini As String
    Private mfec_fin As Date
    Private mhora_fin As String
    Private mestado As String
    Private mnum_dif As Double
    Private mdif_hora As String

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

    Public Property cco_cod As String
        Get
            Return mcco_cod
        End Get
        Set(value As String)
            mcco_cod = value
        End Set
    End Property

    Public Property cod_area As String
        Get
            Return mcod_area
        End Get
        Set(value As String)
            mcod_area = value
        End Set
    End Property

    Public Property cod_grupo As String
        Get
            Return mcod_grupo
        End Get
        Set(value As String)
            mcod_grupo = value
        End Set
    End Property

    Public Property turno As String
        Get
            Return mturno
        End Get
        Set(value As String)
            mturno = value
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

    Public Property fec_ini As Date
        Get
            Return mfec_ini
        End Get
        Set(value As Date)
            mfec_ini = value
        End Set
    End Property

    Public Property hora_ini As String
        Get
            Return mhora_ini
        End Get
        Set(value As String)
            mhora_ini = value
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

    Public Property hora_fin As String
        Get
            Return mhora_fin
        End Get
        Set(value As String)
            mhora_fin = value
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


End Class
