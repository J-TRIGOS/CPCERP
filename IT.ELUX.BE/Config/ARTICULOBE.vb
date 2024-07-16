Public Class ARTICULOBE
    'Campos de la entidad
    Private mart_cod As String
    Private mart_descri As String
    Private mart_slinea As String
    Private mccosto_cod As String
    Private malm_cod As String
    Private muni_cod As String
    Private mubi_artcod As String
    Private mest As String
    Private mx_kardex As String
    Private mcod As String
    Private mnom As String
    Private mart_codcat As String
    Private mfam1 As String
    Private mfam2 As String
    Private mfam3 As String
    Private mfam4 As String
    Private mfam5 As String
    Private mart_aproreq As String
    Private mtemp_art As String
    Private mstkmin As Double
    Private mmedida As String
    Private mart_descritemp As String
    Private mcod_proc As String
    Private mmedida_nuevo As String
    Private mprecio As Double
    Private mart_solm As String
    Private mfecini As Date
    Private mcodsunat As String
    Private manho As String
    Private mest_trabajo As String
    Private mfec_initra As String
    Private mfec_fintra As String
    Private mest_baja As String
    Private mmot_baja As String
    Private mfec_baja As String

    'Propiedades de la entidad
    Public Property fec_baja() As String
        Get
            Return mfec_baja
        End Get
        Set(ByVal value As String)
            mfec_baja = value
        End Set
    End Property
    Public Property mot_baja() As String
        Get
            Return mmot_baja
        End Get
        Set(ByVal value As String)
            mmot_baja = value
        End Set
    End Property
    Public Property est_baja() As String
        Get
            Return mest_baja
        End Get
        Set(ByVal value As String)
            mest_baja = value
        End Set
    End Property
    Public Property fec_fintra() As String
        Get
            Return mfec_fintra
        End Get
        Set(ByVal value As String)
            mfec_fintra = value
        End Set
    End Property
    Public Property fec_initra() As String
        Get
            Return mfec_initra
        End Get
        Set(ByVal value As String)
            mfec_initra = value
        End Set
    End Property
    Public Property est_trabajo() As String
        Get
            Return mest_trabajo
        End Get
        Set(ByVal value As String)
            mest_trabajo = value
        End Set
    End Property
    Public Property art_cod() As String
        Get
            Return mart_cod
        End Get
        Set(ByVal value As String)
            mart_cod = value
        End Set
    End Property

    Public Property art_descritemp() As String
        Get
            Return mart_descritemp
        End Get
        Set(ByVal value As String)
            mart_descritemp = value
        End Set
    End Property

    Public Property art_descri() As String
        Get
            Return mart_descri
        End Get
        Set(ByVal value As String)
            mart_descri = value
        End Set
    End Property
    Public Property art_slinea() As String
        Get
            Return mart_slinea
        End Get
        Set(ByVal value As String)
            mart_slinea = value
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

    Public Property alm_cod() As String
        Get
            Return malm_cod
        End Get
        Set(ByVal value As String)
            malm_cod = value
        End Set
    End Property

    Public Property uni_cod() As String
        Get
            Return muni_cod
        End Get
        Set(ByVal value As String)
            muni_cod = value
        End Set
    End Property

    Public Property ubi_artcod() As String
        Get
            Return mubi_artcod
        End Get
        Set(ByVal value As String)
            mubi_artcod = value
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


    Public Property x_kardex() As String
        Get
            Return mx_kardex
        End Get
        Set(ByVal value As String)
            mx_kardex = value
        End Set
    End Property


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
    Public Property art_codcat() As String
        Get
            Return mart_codcat
        End Get
        Set(ByVal value As String)
            mart_codcat = value
        End Set
    End Property
    Public Property fam1() As String
        Get
            Return mfam1
        End Get
        Set(ByVal value As String)
            mfam1 = value
        End Set
    End Property
    Public Property fam2() As String
        Get
            Return mfam2
        End Get
        Set(ByVal value As String)
            mfam2 = value
        End Set
    End Property
    Public Property fam3() As String
        Get
            Return mfam3
        End Get
        Set(ByVal value As String)
            mfam3 = value
        End Set
    End Property
    Public Property fam4() As String
        Get
            Return mfam4
        End Get
        Set(ByVal value As String)
            mfam4 = value
        End Set
    End Property
    Public Property fam5() As String
        Get
            Return mfam5
        End Get
        Set(ByVal value As String)
            mfam5 = value
        End Set
    End Property
    Public Property art_aproreq() As String
        Get
            Return mart_aproreq
        End Get
        Set(ByVal value As String)
            mart_aproreq = value
        End Set
    End Property
    Public Property temp_art() As String
        Get
            Return mtemp_art
        End Get
        Set(ByVal value As String)
            mtemp_art = value
        End Set
    End Property
    Public Property stkmin() As Double
        Get
            Return mstkmin
        End Get
        Set(ByVal value As Double)
            mstkmin = value
        End Set
    End Property
    Public Property medida() As String
        Get
            Return mmedida
        End Get
        Set(ByVal value As String)
            mmedida = value
        End Set
    End Property
    Public Property cod_proc() As String
        Get
            Return mcod_proc
        End Get
        Set(ByVal value As String)
            mcod_proc = value
        End Set
    End Property
    Public Property medida_nuevo() As String
        Get
            Return mmedida_nuevo
        End Get
        Set(ByVal value As String)
            mmedida_nuevo = value
        End Set
    End Property
    Public Property precio() As Double
        Get
            Return mprecio
        End Get
        Set(ByVal value As Double)
            mprecio = value
        End Set
    End Property

    Public Property art_solm As String
        Get
            Return mart_solm
        End Get
        Set(value As String)
            mart_solm = value
        End Set
    End Property

    Public Property fecini As Date
        Get
            Return mfecini
        End Get
        Set(value As Date)
            mfecini = value
        End Set
    End Property

    Public Property codsunat As String
        Get
            Return mcodsunat
        End Get
        Set(value As String)
            mcodsunat = value
        End Set
    End Property
    Public Property anho As String
        Get
            Return manho
        End Get
        Set(value As String)
            manho = value
        End Set
    End Property
End Class
