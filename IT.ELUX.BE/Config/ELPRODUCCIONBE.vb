Public Class ELPRODUCCIONBE
    Private mt_doc_ref As String
    Private mser_doc_ref As String
    Private mnro_doc_ref As String
    Private mt_doc_ref1 As String
    Private mser_doc_ref1 As String
    Private mnro_doc_ref1 As String
    Private mcod_art As String
    Private musuario As String
    Private mot_pedido As Double
    Private mot_pendiente As String
    Private mot_atendido As String
    Private mStoc_actual As String
    Private mcod_art_expl As String
    Private mopc_stock As String
    Private mdescripcion As String
    Private munidad_med As String
    Private mopc_temporal As Double
    Private mdemasia As String
    Private mcant_generar As Double
    Private mcant_consumo As Double
    Private mfec_gene As Date
    Private mfec_ent As Date
    Private mfact As String
    Private msdoc As String
    Private mndoc As String
    Private mestado As String

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

    Public Property cod_art As String
        Get
            Return mcod_art
        End Get
        Set(value As String)
            mcod_art = value
        End Set
    End Property

    Public Property usuario As String
        Get
            Return musuario
        End Get
        Set(value As String)
            musuario = value
        End Set
    End Property

    Public Property ot_pedido As Double
        Get
            Return mot_pedido
        End Get
        Set(value As Double)
            mot_pedido = value
        End Set
    End Property

    Public Property ot_pendiente As String
        Get
            Return mot_pendiente
        End Get
        Set(value As String)
            mot_pendiente = value
        End Set
    End Property

    Public Property ot_atendido As String
        Get
            Return mot_atendido
        End Get
        Set(value As String)
            mot_atendido = value
        End Set
    End Property

    Public Property Stoc_actual As String
        Get
            Return mStoc_actual
        End Get
        Set(value As String)
            mStoc_actual = value
        End Set
    End Property

    Public Property cod_art_expl As String
        Get
            Return mcod_art_expl
        End Get
        Set(value As String)
            mcod_art_expl = value
        End Set
    End Property

    Public Property opc_stock As String
        Get
            Return mopc_stock
        End Get
        Set(value As String)
            mopc_stock = value
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

    Public Property unidad_med As String
        Get
            Return munidad_med
        End Get
        Set(value As String)
            munidad_med = value
        End Set
    End Property

    Public Property opc_temporal As Double
        Get
            Return mopc_temporal
        End Get
        Set(value As Double)
            mopc_temporal = value
        End Set
    End Property

    Public Property demasia As String
        Get
            Return mdemasia
        End Get
        Set(value As String)
            mdemasia = value
        End Set
    End Property

    Public Property cant_generar As Double
        Get
            Return mcant_generar
        End Get
        Set(value As Double)
            mcant_generar = value
        End Set
    End Property

    Public Property cant_consumo As Double
        Get
            Return mcant_consumo
        End Get
        Set(value As Double)
            mcant_consumo = value
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

    Public Property fec_ent As Date
        Get
            Return mfec_ent
        End Get
        Set(value As Date)
            mfec_ent = value
        End Set
    End Property

    Public Property fact As String
        Get
            Return mfact
        End Get
        Set(value As String)
            mfact = value
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

    Public Property estado As String
        Get
            Return mestado
        End Get
        Set(value As String)
            mestado = value
        End Set
    End Property
End Class
