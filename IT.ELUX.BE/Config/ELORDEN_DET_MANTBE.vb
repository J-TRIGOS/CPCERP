Public Class ELORDEN_DET_MANTBE
    Private mT_DOC_REF As String
    Private mSER_DOC_REF As String
    Private mNRO_DOC_REF As String
    Private mt_doc_ref1 As String
    Private mser_doc_ref1 As String
    Private mnro_doc_ref1 As String
    Private mSEQ As String
    Private mO_MANTENIMIENTO As String
    Private mEST As String
    Private mART_COD As String
    Private mFEC_GENE As Date
    Private mFEC_DIA As Date


    Private mprioridad As String
    Private masunto As String
    Private mnom_art As String
    Private mdescripcion As String

    Public Property T_DOC_REF As String
        Get
            Return mT_DOC_REF
        End Get
        Set(value As String)
            mT_DOC_REF = value
        End Set
    End Property

    Public Property SER_DOC_REF As String
        Get
            Return mSER_DOC_REF
        End Get
        Set(value As String)
            mSER_DOC_REF = value
        End Set
    End Property

    Public Property NRO_DOC_REF As String
        Get
            Return mNRO_DOC_REF
        End Get
        Set(value As String)
            mNRO_DOC_REF = value
        End Set
    End Property

    Public Property SEQ As String
        Get
            Return mSEQ
        End Get
        Set(value As String)
            mSEQ = value
        End Set
    End Property

    Public Property O_MANTENIMIENTO As String
        Get
            Return mO_MANTENIMIENTO
        End Get
        Set(value As String)
            mO_MANTENIMIENTO = value
        End Set
    End Property

    Public Property EST As String
        Get
            Return mEST
        End Get
        Set(value As String)
            mEST = value
        End Set
    End Property

    Public Property ART_COD As String
        Get
            Return mART_COD
        End Get
        Set(value As String)
            mART_COD = value
        End Set
    End Property

    Public Property FEC_GENE As Date
        Get
            Return mFEC_GENE
        End Get
        Set(value As Date)
            mFEC_GENE = value
        End Set
    End Property

    Public Property FEC_DIA As Date
        Get
            Return mFEC_DIA
        End Get
        Set(value As Date)
            mFEC_DIA = value
        End Set
    End Property



    Public Property prioridad As String
        Get
            Return mprioridad
        End Get
        Set(value As String)
            mprioridad = value
        End Set
    End Property

    Public Property asunto As String
        Get
            Return masunto
        End Get
        Set(value As String)
            masunto = value
        End Set
    End Property

    Public Property nom_art As String
        Get
            Return mnom_art
        End Get
        Set(value As String)
            mnom_art = value
        End Set
    End Property

    Public Property descripcion As String
        Get
            Return mdescripcion
        End Get
        Set(value As String)
            mdescripcion = value
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
End Class
