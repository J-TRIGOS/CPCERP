Public Class ELTBLETRAS_MONTOBE
    Private mt_doc_ref As String
    Private mser_doc_ref As String
    Private mnro_doc_ref As String
    Private mt_doc_ref1 As String
    Private mser_doc_ref1 As String
    Private mnro_doc_ref1 As String
    Private mproveedor As String
    Private mmontos As Double
    Private mmontod As Double
    Private mmoneda As String
    Private mmontos_fact As Double
    Private mmontod_fact As Double
    Private mt_cmb As Double
    Private mf_pago_ent As String
    Private mfec_vigencia As Date

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

    Public Property proveedor As String
        Get
            Return mproveedor
        End Get
        Set(value As String)
            mproveedor = value
        End Set
    End Property

    Public Property montos As Double
        Get
            Return mmontos
        End Get
        Set(value As Double)
            mmontos = value
        End Set
    End Property

    Public Property montod As Double
        Get
            Return mmontod
        End Get
        Set(value As Double)
            mmontod = value
        End Set
    End Property

    Public Property moneda As String
        Get
            Return mmoneda
        End Get
        Set(value As String)
            mmoneda = value
        End Set
    End Property
    Public Property montos_fact As Double
        Get
            Return mmontos_fact
        End Get
        Set(value As Double)
            mmontos_fact = value
        End Set
    End Property
    Public Property montod_fact As Double
        Get
            Return mmontod_fact
        End Get
        Set(value As Double)
            mmontod_fact = value
        End Set
    End Property

    Public Property t_cmb As Double
        Get
            Return mt_cmb
        End Get
        Set(value As Double)
            mt_cmb = value
        End Set
    End Property

    Public Property f_pago_ent As String
        Get
            Return mf_pago_ent
        End Get
        Set(value As String)
            mf_pago_ent = value
        End Set
    End Property

    Public Property fec_vigencia As Date
        Get
            Return mfec_vigencia
        End Get
        Set(value As Date)
            mfec_vigencia = value
        End Set
    End Property
End Class
