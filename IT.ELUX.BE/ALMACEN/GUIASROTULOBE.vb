Public Class GUIASROTULOBE
    Private MT_DOC_REF As String
    Private MSER_DOC_REF As String
    Private MNRO_DOC_REF As String
    Private MT_DOC_REF1 As String
    Private MSER_DOC_REF1 As String
    Private MNRO_DOC_REF1 As String
    Private MCTCT_COD As String
    Private MCANT_OC As String
    Private MFEC_ING As String
    Private MART_COD As String
    Private MCANTIDAD As String
    Private MBULTO As String
    Private MTOTBULTOS As String
    Private MFACTURA As String

    Public Property FACTURA As String
        Get
            Return MFACTURA
        End Get
        Set(value As String)
            MFACTURA = value
        End Set
    End Property
    Public Property TOTBULTOS As String
        Get
            Return MTOTBULTOS
        End Get
        Set(value As String)
            MTOTBULTOS = value
        End Set
    End Property

    Public Property T_DOC_REF As String
        Get
            Return MT_DOC_REF
        End Get
        Set(value As String)
            MT_DOC_REF = value
        End Set
    End Property

    Public Property SER_DOC_REF As String
        Get
            Return MSER_DOC_REF
        End Get
        Set(value As String)
            MSER_DOC_REF = value
        End Set
    End Property

    Public Property NRO_DOC_REF As String
        Get
            Return MNRO_DOC_REF
        End Get
        Set(value As String)
            MNRO_DOC_REF = value
        End Set
    End Property

    Public Property T_DOC_REF1 As String
        Get
            Return MT_DOC_REF1
        End Get
        Set(value As String)
            MT_DOC_REF1 = value
        End Set
    End Property

    Public Property SER_DOC_REF1 As String
        Get
            Return MSER_DOC_REF1
        End Get
        Set(value As String)
            MSER_DOC_REF1 = value
        End Set
    End Property

    Public Property NRO_DOC_REF1 As String
        Get
            Return MNRO_DOC_REF1
        End Get
        Set(value As String)
            MNRO_DOC_REF1 = value
        End Set
    End Property

    Public Property CTCT_COD As String
        Get
            Return MCTCT_COD
        End Get
        Set(value As String)
            MCTCT_COD = value
        End Set
    End Property

    Public Property CANT_OC As String
        Get
            Return MCANT_OC
        End Get
        Set(value As String)
            MCANT_OC = value
        End Set
    End Property

    Public Property FEC_ING As String
        Get
            Return MFEC_ING
        End Get
        Set(value As String)
            MFEC_ING = value
        End Set
    End Property

    Public Property ART_COD As String
        Get
            Return MART_COD
        End Get
        Set(value As String)
            MART_COD = value
        End Set
    End Property

    Public Property CANTIDAD As String
        Get
            Return MCANTIDAD
        End Get
        Set(value As String)
            MCANTIDAD = value
        End Set
    End Property

    Public Property BULTO As String
        Get
            Return MBULTO
        End Get
        Set(value As String)
            MBULTO = value
        End Set
    End Property
End Class
