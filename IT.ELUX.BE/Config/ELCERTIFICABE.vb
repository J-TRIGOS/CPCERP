Public Class ELCERTIFICABE
    'Campos de la entidad
    Dim mt_doc_ref As String
    Dim mser_doc_ref As String
    Dim mnro_ser_doc As String
    Dim mart_cod As String
    Dim mlote As String
    Dim mfec_prov As String
    Dim mn_bolsas As Integer
    Dim mcantidad As Integer
    Dim mt_paquete As String
    Dim malt_cuerpo As String
    Dim malt_envase As String
    Dim mdia_interno As String
    Dim mdia_externo As String
    Dim manc_envase As String
    Dim mlarg_envase As String
    Dim malt_tapa As String
    Dim mpes_envase As String
    Dim mColor As String
    Dim mtip_envase As String

    Dim malt_asa As String
    Dim mobs1 As String
    Dim mobs2 As String
    Dim mobs3 As String
    Dim mobs4 As String
    Dim mobs5 As String

    Dim mtipo_acta As String

    Dim mo1 As String
    Dim mo2 As String
    Dim mo3 As String
    Dim mo4 As String
    Dim mo5 As String
    Dim mo6 As String
    Dim mo7 As String
    Dim mo8 As String
    Dim mo9 As String
    Dim mm1 As String
    Dim mm2 As String
    Dim mm3 As String
    Dim mm4 As String
    Dim mm5 As String
    Dim mm6 As String
    Dim mm7 As String
    Dim mm8 As String
    Dim mm9 As String
    Dim mp1 As String
    Dim mp2 As String
    Dim mp3 As String
    Dim mp4 As String
    Dim mp5 As String
    Dim mp6 As String
    Dim mp7 As String
    Dim mp8 As String
    Dim mp9 As String

    Dim mes1 As String
    Dim mes2 As String
    Dim mes3 As String
    Dim mes4 As String
    Dim mes5 As String
    Dim mes6 As String
    Dim mes7 As String
    Dim mes8 As String
    Dim mes9 As String
    Dim mes10 As String
    Dim mes11 As String
    Dim musuario As String

    Dim mes12 As String
    Dim mes13 As String
    Dim mes14 As String

    Dim mespesor As Double '
    Dim mtemple As String
    Dim mdiametro As String
    Dim mtratamiento_termico As String
    Dim mrecubrimiento_termico As String
    Dim mmodelo As String
    Dim mcantidad_tapas_bulto As Double
    Dim mdiametro_exterior As Double
    Dim mdiametro_interior As Double
    Dim mdiametro_entre_unias As Double
    Dim maltura_de_exterior As Double
    Dim mnivel_de_vacio As String
    Dim mseguridad_de_cierre As Integer
    Dim mctct_cod As String
    Dim mnro_doc_ref As String
    Dim mcantidad1 As String
    Dim mdiametro_exterior_res As Double
    Dim mdiametro_interior_res As Double
    Dim mdiametro_entre_unias_res As Double
    Dim maltura_de_exterior_res As Double

    Dim mtipo As String
    Dim mnumero As String
    Dim mserie As String
    Dim mcantidad2 As String
    Dim mfecha As Date
    Dim mturno As String
    Dim mlote1 As String

    Dim mcantidad3 As Double
    Dim mfechac As Date
    Dim mfechadia As Date
    Dim mmedida As String
    Dim mdescri As String
    Dim mcant1 As Double
    Dim minc As String
    Dim mest As String

    Dim mtxto1 As Double
    Dim mtxtm1 As Double
    Dim mtxto2 As Double
    Dim mtxtm2 As Double
    Dim mtxto3 As Double
    Dim mtxtm3 As Double
    Dim mtxto4 As Double
    Dim mtxtm4 As Double

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

    Public Property nro_ser_doc As String
        Get
            Return mnro_ser_doc
        End Get
        Set(value As String)
            mnro_ser_doc = value
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

    Public Property lote As String
        Get
            Return mlote
        End Get
        Set(value As String)
            mlote = value
        End Set
    End Property

    Public Property fec_prov As String
        Get
            Return mfec_prov
        End Get
        Set(value As String)
            mfec_prov = value
        End Set
    End Property

    Public Property n_bolsas As Integer
        Get
            Return mn_bolsas
        End Get
        Set(value As Integer)
            mn_bolsas = value
        End Set
    End Property

    Public Property cantidad As Integer
        Get
            Return mcantidad
        End Get
        Set(value As Integer)
            mcantidad = value
        End Set
    End Property

    Public Property t_paquete As String
        Get
            Return mt_paquete
        End Get
        Set(value As String)
            mt_paquete = value
        End Set
    End Property

    Public Property alt_cuerpo As String
        Get
            Return malt_cuerpo
        End Get
        Set(value As String)
            malt_cuerpo = value
        End Set
    End Property

    Public Property alt_envase As String
        Get
            Return malt_envase
        End Get
        Set(value As String)
            malt_envase = value
        End Set
    End Property

    Public Property dia_interno As String
        Get
            Return mdia_interno
        End Get
        Set(value As String)
            mdia_interno = value
        End Set
    End Property

    Public Property dia_externo As String
        Get
            Return mdia_externo
        End Get
        Set(value As String)
            mdia_externo = value
        End Set
    End Property

    Public Property anc_envase As String
        Get
            Return manc_envase
        End Get
        Set(value As String)
            manc_envase = value
        End Set
    End Property

    Public Property larg_envase As String
        Get
            Return mlarg_envase
        End Get
        Set(value As String)
            mlarg_envase = value
        End Set
    End Property

    Public Property alt_tapa As String
        Get
            Return malt_tapa
        End Get
        Set(value As String)
            malt_tapa = value
        End Set
    End Property

    Public Property pes_envase As String
        Get
            Return mpes_envase
        End Get
        Set(value As String)
            mpes_envase = value
        End Set
    End Property

    Public Property tipo_acta As String
        Get
            Return mtipo_acta
        End Get
        Set(value As String)
            mtipo_acta = value
        End Set
    End Property

    Public Property alt_asa As String
        Get
            Return malt_asa
        End Get
        Set(value As String)
            malt_asa = value
        End Set
    End Property

    Public Property obs1 As String
        Get
            Return mobs1
        End Get
        Set(value As String)
            mobs1 = value
        End Set
    End Property

    Public Property obs2 As String
        Get
            Return mobs2
        End Get
        Set(value As String)
            mobs2 = value
        End Set
    End Property

    Public Property obs3 As String
        Get
            Return mobs3
        End Get
        Set(value As String)
            mobs3 = value
        End Set
    End Property

    Public Property obs4 As String
        Get
            Return mobs4
        End Get
        Set(value As String)
            mobs4 = value
        End Set
    End Property

    Public Property obs5 As String
        Get
            Return mobs5
        End Get
        Set(value As String)
            mobs5 = value
        End Set
    End Property

    Public Property o1 As String
        Get
            Return mo1
        End Get
        Set(value As String)
            mo1 = value
        End Set
    End Property

    Public Property o2 As String
        Get
            Return mo2
        End Get
        Set(value As String)
            mo2 = value
        End Set
    End Property

    Public Property o3 As String
        Get
            Return mo3
        End Get
        Set(value As String)
            mo3 = value
        End Set
    End Property

    Public Property o4 As String
        Get
            Return mo4
        End Get
        Set(value As String)
            mo4 = value
        End Set
    End Property

    Public Property o5 As String
        Get
            Return mo5
        End Get
        Set(value As String)
            mo5 = value
        End Set
    End Property

    Public Property o6 As String
        Get
            Return mo6
        End Get
        Set(value As String)
            mo6 = value
        End Set
    End Property

    Public Property o7 As String
        Get
            Return mo7
        End Get
        Set(value As String)
            mo7 = value
        End Set
    End Property

    Public Property o8 As String
        Get
            Return mo8
        End Get
        Set(value As String)
            mo8 = value
        End Set
    End Property

    Public Property o9 As String
        Get
            Return mo9
        End Get
        Set(value As String)
            mo9 = value
        End Set
    End Property

    Public Property m1 As String
        Get
            Return mm1
        End Get
        Set(value As String)
            mm1 = value
        End Set
    End Property

    Public Property m2 As String
        Get
            Return mm2
        End Get
        Set(value As String)
            mm2 = value
        End Set
    End Property

    Public Property m3 As String
        Get
            Return mm3
        End Get
        Set(value As String)
            mm3 = value
        End Set
    End Property

    Public Property m4 As String
        Get
            Return mm4
        End Get
        Set(value As String)
            mm4 = value
        End Set
    End Property

    Public Property m5 As String
        Get
            Return mm5
        End Get
        Set(value As String)
            mm5 = value
        End Set
    End Property

    Public Property m6 As String
        Get
            Return mm6
        End Get
        Set(value As String)
            mm6 = value
        End Set
    End Property

    Public Property m7 As String
        Get
            Return mm7
        End Get
        Set(value As String)
            mm7 = value
        End Set
    End Property

    Public Property m8 As String
        Get
            Return mm8
        End Get
        Set(value As String)
            mm8 = value
        End Set
    End Property

    Public Property m9 As String
        Get
            Return mm9
        End Get
        Set(value As String)
            mm9 = value
        End Set
    End Property

    Public Property p1 As String
        Get
            Return mp1
        End Get
        Set(value As String)
            mp1 = value
        End Set
    End Property

    Public Property p2 As String
        Get
            Return mp2
        End Get
        Set(value As String)
            mp2 = value
        End Set
    End Property

    Public Property p3 As String
        Get
            Return mp3
        End Get
        Set(value As String)
            mp3 = value
        End Set
    End Property

    Public Property p4 As String
        Get
            Return mp4
        End Get
        Set(value As String)
            mp4 = value
        End Set
    End Property

    Public Property p5 As String
        Get
            Return mp5
        End Get
        Set(value As String)
            mp5 = value
        End Set
    End Property

    Public Property p6 As String
        Get
            Return mp6
        End Get
        Set(value As String)
            mp6 = value
        End Set
    End Property

    Public Property p7 As String
        Get
            Return mp7
        End Get
        Set(value As String)
            mp7 = value
        End Set
    End Property

    Public Property p8 As String
        Get
            Return mp8
        End Get
        Set(value As String)
            mp8 = value
        End Set
    End Property

    Public Property p9 As String
        Get
            Return mp9
        End Get
        Set(value As String)
            mp9 = value
        End Set
    End Property

    Public Property es1 As String
        Get
            Return mes1
        End Get
        Set(value As String)
            mes1 = value
        End Set
    End Property

    Public Property es2 As String
        Get
            Return mes2
        End Get
        Set(value As String)
            mes2 = value
        End Set
    End Property

    Public Property es3 As String
        Get
            Return mes3
        End Get
        Set(value As String)
            mes3 = value
        End Set
    End Property

    Public Property es4 As String
        Get
            Return mes4
        End Get
        Set(value As String)
            mes4 = value
        End Set
    End Property

    Public Property es5 As String
        Get
            Return mes5
        End Get
        Set(value As String)
            mes5 = value
        End Set
    End Property

    Public Property es6 As String
        Get
            Return mes6
        End Get
        Set(value As String)
            mes6 = value
        End Set
    End Property

    Public Property es7 As String
        Get
            Return Mes71
        End Get
        Set(value As String)
            Mes71 = value
        End Set
    End Property

    Public Property Mes71 As String
        Get
            Return mes7
        End Get
        Set(value As String)
            mes7 = value
        End Set
    End Property

    Public Property es8 As String
        Get
            Return mes8
        End Get
        Set(value As String)
            mes8 = value
        End Set
    End Property

    Public Property es9 As String
        Get
            Return mes9
        End Get
        Set(value As String)
            mes9 = value
        End Set
    End Property

    Public Property es10 As String
        Get
            Return mes10
        End Get
        Set(value As String)
            mes10 = value
        End Set
    End Property

    Public Property es11 As String
        Get
            Return mes11
        End Get
        Set(value As String)
            mes11 = value
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

    Public Property es12 As String
        Get
            Return mes12
        End Get
        Set(value As String)
            mes12 = value
        End Set
    End Property

    Public Property es13 As String
        Get
            Return mes13
        End Get
        Set(value As String)
            mes13 = value
        End Set
    End Property

    Public Property es14 As String
        Get
            Return mes14
        End Get
        Set(value As String)
            mes14 = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return mColor
        End Get
        Set(value As String)
            mColor = value
        End Set
    End Property

    Public Property tip_envase As String
        Get
            Return mtip_envase
        End Get
        Set(value As String)
            mtip_envase = value
        End Set
    End Property
    Public Property Espesor As Double
        Get
            Return mespesor
        End Get
        Set(value As Double)
            mespesor = value
        End Set
    End Property
    Public Property temple As String
        Get
            Return mtemple
        End Get
        Set(value As String)
            mtemple = value
        End Set
    End Property
    Public Property diametro As String
        Get
            Return mdiametro
        End Get
        Set(value As String)
            mdiametro = value
        End Set
    End Property
    Public Property tratamiento_termico As String
        Get
            Return mtratamiento_termico
        End Get
        Set(value As String)
            mtratamiento_termico = value
        End Set
    End Property
    Public Property recubrimiento_termico As String
        Get
            Return mrecubrimiento_termico
        End Get
        Set(value As String)
            mrecubrimiento_termico = value
        End Set
    End Property
    Public Property modelo As String
        Get
            Return mmodelo
        End Get
        Set(value As String)
            mmodelo = value
        End Set
    End Property
    Public Property cantidad_tapas_bulto As Double
        Get
            Return mcantidad_tapas_bulto
        End Get
        Set(value As Double)
            mcantidad_tapas_bulto = value
        End Set
    End Property
    Public Property diametro_exterior As Double
        Get
            Return mdiametro_exterior
        End Get
        Set(value As Double)
            mdiametro_exterior = value
        End Set
    End Property
    Public Property diametro_interior As Double
        Get
            Return mdiametro_interior
        End Get
        Set(value As Double)
            mdiametro_interior = value
        End Set
    End Property
    Public Property diametro_entre_unias As Double
        Get
            Return mdiametro_entre_unias
        End Get
        Set(value As Double)
            mdiametro_entre_unias = value
        End Set
    End Property
    Public Property altura_de_exterior As Double
        Get
            Return maltura_de_exterior
        End Get
        Set(value As Double)
            maltura_de_exterior = value
        End Set
    End Property
    Public Property nivel_de_vacio As String
        Get
            Return mnivel_de_vacio
        End Get
        Set(value As String)
            mnivel_de_vacio = value
        End Set
    End Property
    Public Property seguridad_de_cierre As Integer
        Get
            Return mseguridad_de_cierre
        End Get
        Set(value As Integer)
            mseguridad_de_cierre = value
        End Set
    End Property
    Public Property ctct_cod As String
        Get
            Return mctct_cod
        End Get
        Set(value As String)
            mctct_cod = value
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

    Public Property cantidad1 As String
        Get
            Return mcantidad1
        End Get
        Set(value As String)
            mcantidad1 = value
        End Set
    End Property

    Public Property tipo As String
        Get
            Return mtipo
        End Get
        Set(value As String)
            mtipo = value
        End Set
    End Property

    Public Property numero As String
        Get
            Return mnumero
        End Get
        Set(value As String)
            mnumero = value
        End Set
    End Property

    Public Property serie As String
        Get
            Return mserie
        End Get
        Set(value As String)
            mserie = value
        End Set
    End Property

    Public Property cantidad2 As String
        Get
            Return mcantidad2
        End Get
        Set(value As String)
            mcantidad2 = value
        End Set
    End Property

    Public Property fecha As Date
        Get
            Return mfecha
        End Get
        Set(value As Date)
            mfecha = value
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
    Public Property lote1 As String
        Get
            Return mlote1
        End Get
        Set(value As String)
            mlote1 = value
        End Set
    End Property
    Public Property cantidad3 As Double
        Get
            Return mcantidad3
        End Get
        Set(value As Double)
            mcantidad3 = value
        End Set
    End Property
    Public Property fechac As Date
        Get
            Return mfechac
        End Get
        Set(value As Date)
            mfechac = value
        End Set
    End Property
    Public Property medida As String
        Get
            Return mmedida
        End Get
        Set(value As String)
            mmedida = value
        End Set
    End Property
    Public Property diametro_exterior_res As Double
        Get
            Return mdiametro_exterior_res
        End Get
        Set(value As Double)
            mdiametro_exterior_res = value
        End Set
    End Property
    Public Property diametro_interior_res As Double
        Get
            Return mdiametro_interior_res
        End Get
        Set(value As Double)
            mdiametro_interior_res = value
        End Set
    End Property
    Public Property diametro_entre_unias_res As Double
        Get
            Return mdiametro_entre_unias_res
        End Get
        Set(value As Double)
            mdiametro_entre_unias_res = value
        End Set
    End Property
    Public Property altura_de_exterior_res As Double
        Get
            Return maltura_de_exterior_res
        End Get
        Set(value As Double)
            maltura_de_exterior_res = value
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
    Public Property cant1 As Double
        Get
            Return mcant1
        End Get
        Set(value As Double)
            mcant1 = value
        End Set
    End Property

    Public Property fechadia As Date
        Get
            Return mfechadia
        End Get
        Set(value As Date)
            mfechadia = value
        End Set
    End Property

    Public Property inc As String
        Get
            Return minc
        End Get
        Set(value As String)
            minc = value
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

    Public Property txto1 As Double
        Get
            Return mtxto1
        End Get
        Set(value As Double)
            mtxto1 = value
        End Set
    End Property

    Public Property txtm1 As Double
        Get
            Return mtxtm1
        End Get
        Set(value As Double)
            mtxtm1 = value
        End Set
    End Property

    Public Property txto2 As Double
        Get
            Return mtxto2
        End Get
        Set(value As Double)
            mtxto2 = value
        End Set
    End Property

    Public Property txtm2 As Double
        Get
            Return mtxtm2
        End Get
        Set(value As Double)
            mtxtm2 = value
        End Set
    End Property

    Public Property txto3 As Double
        Get
            Return mtxto3
        End Get
        Set(value As Double)
            mtxto3 = value
        End Set
    End Property

    Public Property txtm3 As Double
        Get
            Return mtxtm3
        End Get
        Set(value As Double)
            mtxtm3 = value
        End Set
    End Property

    Public Property txto4 As Double
        Get
            Return mtxto4
        End Get
        Set(value As Double)
            mtxto4 = value
        End Set
    End Property

    Public Property txtm4 As Double
        Get
            Return mtxtm4
        End Get
        Set(value As Double)
            mtxtm4 = value
        End Set
    End Property
End Class
