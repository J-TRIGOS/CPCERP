Public Class ELORDEN_DET_PROGRAMBE

    Private mt_doc_ref As String
    Private mser_doc_ref As String
    Private mnro_doc_ref As String
    Private mt_doc_ref1 As String
    Private mser_doc_ref1 As String
    Private mnro_doc_ref1 As String
    Private mseq As String
    Private mcod_cliente As String
    Private mo_produccion As String
    Private mcod_articulo As String
    Private mcantidad As Double
    Private mpendiente As Double
    Private matentido As Double
    Private mduracion As String
    Private mfec_gen As Date
    Private mfec_ini As Date
    Private mfec_fin As Date
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

    Public Property seq As String
        Get
            Return mseq
        End Get
        Set(value As String)
            mseq = value
        End Set
    End Property

    Public Property cod_cliente As String
        Get
            Return mcod_cliente
        End Get
        Set(value As String)
            mcod_cliente = value
        End Set
    End Property

    Public Property o_produccion As String
        Get
            Return mo_produccion
        End Get
        Set(value As String)
            mo_produccion = value
        End Set
    End Property

    Public Property cod_articulo As String
        Get
            Return mcod_articulo
        End Get
        Set(value As String)
            mcod_articulo = value
        End Set
    End Property

    Public Property cantidad As Double
        Get
            Return mcantidad
        End Get
        Set(value As Double)
            mcantidad = value
        End Set
    End Property

    Public Property pendiente As Double
        Get
            Return mpendiente
        End Get
        Set(value As Double)
            mpendiente = value
        End Set
    End Property

    Public Property atentido As Double
        Get
            Return matentido
        End Get
        Set(value As Double)
            matentido = value
        End Set
    End Property

    Public Property duracion As String
        Get
            Return mduracion
        End Get
        Set(value As String)
            mduracion = value
        End Set
    End Property

    Public Property fec_gen As Date
        Get
            Return mfec_gen
        End Get
        Set(value As Date)
            mfec_gen = value
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

    Public Property fec_fin As Date
        Get
            Return mfec_fin
        End Get
        Set(value As Date)
            mfec_fin = value
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
    Public Property num_dif As Double
        Get
            Return mnum_dif
        End Get
        Set(value As Double)
            mnum_dif = value
        End Set
    End Property

    Public Property dif_hora As String
        Get
            Return mdif_hora
        End Get
        Set(value As String)
            mdif_hora = value
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
