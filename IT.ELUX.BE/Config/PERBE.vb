Public Class PERBE
    Private mCOD As String
    Private mFEC_ING As Date
    Private mSIT_COD As String
    Private mT_PER_COD As String
    Private mAPE1 As String
    Private mNOM1 As String
    Private mSUCU_COD As String
    Private mPART_PRES_COD As String
    Private mPROY_COD As String
    Private mCAT_OCU_COD As String
    Private mCCO_COD As String
    Private mFUENTE_COD As String
    Private mAFP_COD As String
    Private mAPE2 As String
    Private mNOM2 As String
    Private mDIREC As String
    Private mFEC_NAC As Date
    Private mIPSS As String
    Private mLE As String
    Private mFECEMIDNI As Date
    Private mLM As String
    Private mLT As String
    Private mX_SEXO As String
    Private mCARGO As String
    Private mESTCIV As String
    Private mFEC_ICESE As Date
    Private mFEC_LAB As Date
    Private mNAC As String
    Private mNRO_HIJO As Integer
    Private mREGLAB As String
    Private mTELF As String
    Private mEMAIL As String
    Private mPASPT As String
    Private mX_SALUD As String
    Private mX_PENS As String
    Private mX_ACC_TR As String
    Private mCRN_EXT As String
    Private mX_COBRA As String
    Private mX_VENDE As String
    Private mOBS As String
    Private mPCOMV As Double
    Private mPCOMC As Double
    Private mLINEA_COD As String
    Private mZONA_COD As String
    Private mAGE As String
    Private mAUTO As String
    Private mFEC_PCESE As Date
    Private mFEC_T_MOV_AFP As Date
    Private mFEC_T__MOV_AFP As Date
    Private mNRO_AFP As String
    Private mT_MOV_AFP_COD As String
    Private mX_TDOC As String
    Private mPRDO As Integer
    Private mX_PLA As String
    Private mTOT_HOR As Integer
    Private mTOT_MIN As Integer
    Private mTOT_DIA As Double
    Private mNN As String
    Private mX_SET As String
    Private mT_TRAB As String
    Private mFEC_AFP As Date
    Private mMOTI_BAJA_COD As String
    Private mNIP As String
    Private mID_NRO As String
    Private mPUNTUALIDAD As String
    Private mCONTRATO_PRDO As String
    Private mX_ESTCIV As String
    Private mT_PAGO As String
    Private mGRA_MES As Integer
    Private mT_GRA As String
    Private mCOD_EDUCATIVO As String
    Private mX_SUPERV As String
    Private mCARGO_COD As Integer
    Private mTURNO As String
    Private mTALLA As String
    Private mTALLA1 As String
    Private mTALLA2 As String
    Private mART_COD As String
    Private mART_COD1 As String
    Private mART_COD3 As String
    Private mART_COD2 As String
    Private mOBS1 As String
    Private mCTA_DOLAR As String
    Private mMES_TIEMPO_SERV As Integer
    Private mT_REM As String
    Private mUBIGEO As String
    Private mUBIGEO_NAC As String
    Private mX_COMISION As String
    Private mX_CHE As String
    Private mNRO_CTA_BANCO As String
    Private mNRO_CTA_CTS As String
    Private mBCO_CTS_COD As String
    Private mTARDE As Integer
    Private mTURNO1 As String
    Private mCARGO_CODIGO As String
    Private mCOD_GRUPO As String
    Private mPER_QUINTA As Double
    Private mPER_ANHO As String
    Private mFECC_ICESE As String
    Private mCCO_COD_NUEVO As String

    Public Property CCO_COD_NUEVO() As String
        Get
            Return mCCO_COD_NUEVO
        End Get
        Set(value As String)
            mCCO_COD_NUEVO = value
        End Set
    End Property


    Public Property COD() As String
        Get
            Return mCOD
        End Get
        Set(ByVal value As String)
            mCOD = value
        End Set
    End Property
    Public Property FEC_ING() As Date
        Get
            Return mFEC_ING
        End Get
        Set(ByVal value As Date)
            mFEC_ING = value
        End Set
    End Property
    Public Property SIT_COD() As String
        Get
            Return mSIT_COD
        End Get
        Set(ByVal value As String)
            mSIT_COD = value
        End Set
    End Property
    Public Property T_PER_COD() As String
        Get
            Return mT_PER_COD
        End Get
        Set(ByVal value As String)
            mT_PER_COD = value
        End Set
    End Property
    Public Property APE1() As String
        Get
            Return mAPE1
        End Get
        Set(ByVal value As String)
            mAPE1 = value
        End Set
    End Property
    Public Property NOM1() As String
        Get
            Return mNOM1
        End Get
        Set(ByVal value As String)
            mNOM1 = value
        End Set
    End Property
    Public Property SUCU_COD() As String
        Get
            Return mSUCU_COD
        End Get
        Set(ByVal value As String)
            mSUCU_COD = value
        End Set
    End Property
    Public Property PART_PRES_COD() As String
        Get
            Return mPART_PRES_COD
        End Get
        Set(ByVal value As String)
            mPART_PRES_COD = value
        End Set
    End Property
    Public Property PROY_COD() As String
        Get
            Return mPROY_COD
        End Get
        Set(ByVal value As String)
            mPROY_COD = value
        End Set
    End Property
    Public Property CAT_OCU_COD() As String
        Get
            Return mCAT_OCU_COD
        End Get
        Set(ByVal value As String)
            mCAT_OCU_COD = value
        End Set
    End Property
    Public Property CCO_COD() As String
        Get
            Return mCCO_COD
        End Get
        Set(ByVal value As String)
            mCCO_COD = value
        End Set
    End Property
    Public Property FUENTE_COD() As String
        Get
            Return mFUENTE_COD
        End Get
        Set(ByVal value As String)
            mFUENTE_COD = value
        End Set
    End Property
    Public Property AFP_COD() As String
        Get
            Return mAFP_COD
        End Get
        Set(ByVal value As String)
            mAFP_COD = value
        End Set
    End Property
    Public Property APE2() As String
        Get
            Return mAPE2
        End Get
        Set(ByVal value As String)
            mAPE2 = value
        End Set
    End Property
    Public Property NOM2() As String
        Get
            Return mNOM2
        End Get
        Set(ByVal value As String)
            mNOM2 = value
        End Set
    End Property
    Public Property DIREC() As String
        Get
            Return mDIREC
        End Get
        Set(ByVal value As String)
            mDIREC = value
        End Set
    End Property
    Public Property FEC_NAC() As Date
        Get
            Return mFEC_NAC
        End Get
        Set(ByVal value As Date)
            mFEC_NAC = value
        End Set
    End Property
    Public Property IPSS() As String
        Get
            Return mIPSS
        End Get
        Set(ByVal value As String)
            mIPSS = value
        End Set
    End Property
    Public Property LE() As String
        Get
            Return mLE
        End Get
        Set(ByVal value As String)
            mLE = value
        End Set
    End Property
    Public Property LM() As String
        Get
            Return mLM
        End Get
        Set(ByVal value As String)
            mLM = value
        End Set
    End Property
    Public Property LT() As String
        Get
            Return mLT
        End Get
        Set(ByVal value As String)
            mLT = value
        End Set
    End Property
    Public Property X_SEXO() As String
        Get
            Return mX_SEXO
        End Get
        Set(ByVal value As String)
            mX_SEXO = value
        End Set
    End Property
    Public Property CARGO() As String
        Get
            Return mCARGO
        End Get
        Set(ByVal value As String)
            mCARGO = value
        End Set
    End Property
    Public Property ESTCIV() As String
        Get
            Return mESTCIV
        End Get
        Set(ByVal value As String)
            mESTCIV = value
        End Set
    End Property
    Public Property FEC_ICESE() As Date
        Get
            Return mFEC_ICESE
        End Get
        Set(ByVal value As Date)
            mFEC_ICESE = value
        End Set
    End Property
    Public Property FEC_LAB() As Date
        Get
            Return mFEC_LAB
        End Get
        Set(ByVal value As Date)
            mFEC_LAB = value
        End Set
    End Property
    Public Property NAC() As String
        Get
            Return mNAC
        End Get
        Set(ByVal value As String)
            mNAC = value
        End Set
    End Property
    Public Property NRO_HIJO() As Integer
        Get
            Return mNRO_HIJO
        End Get
        Set(ByVal value As Integer)
            mNRO_HIJO = value
        End Set
    End Property
    Public Property REGLAB() As String
        Get
            Return mREGLAB
        End Get
        Set(ByVal value As String)
            mREGLAB = value
        End Set
    End Property
    Public Property TELF() As String
        Get
            Return mTELF
        End Get
        Set(ByVal value As String)
            mTELF = value
        End Set
    End Property
    Public Property EMAIL() As String
        Get
            Return mEMAIL
        End Get
        Set(ByVal value As String)
            mEMAIL = value
        End Set
    End Property
    Public Property PASPT() As String
        Get
            Return mPASPT
        End Get
        Set(ByVal value As String)
            mPASPT = value
        End Set
    End Property
    Public Property X_SALUD() As String
        Get
            Return mX_SALUD
        End Get
        Set(ByVal value As String)
            mX_SALUD = value
        End Set
    End Property
    Public Property X_PENS() As String
        Get
            Return mX_PENS
        End Get
        Set(ByVal value As String)
            mX_PENS = value
        End Set
    End Property
    Public Property X_ACC_TR() As String
        Get
            Return mX_ACC_TR
        End Get
        Set(ByVal value As String)
            mX_ACC_TR = value
        End Set
    End Property
    Public Property CRN_EXT() As String
        Get
            Return mCRN_EXT
        End Get
        Set(ByVal value As String)
            mCRN_EXT = value
        End Set
    End Property
    Public Property X_COBRA() As String
        Get
            Return mX_COBRA
        End Get
        Set(ByVal value As String)
            mX_COBRA = value
        End Set
    End Property
    Public Property X_VENDE() As String
        Get
            Return mX_VENDE
        End Get
        Set(ByVal value As String)
            mX_VENDE = value
        End Set
    End Property
    Public Property OBS() As String
        Get
            Return mOBS
        End Get
        Set(ByVal value As String)
            mOBS = value
        End Set
    End Property
    Public Property PCOMV() As Double
        Get
            Return mPCOMV
        End Get
        Set(ByVal value As Double)
            mPCOMV = value
        End Set
    End Property
    Public Property PCOMC() As Double
        Get
            Return mPCOMC
        End Get
        Set(ByVal value As Double)
            mPCOMC = value
        End Set
    End Property
    Public Property LINEA_COD() As String
        Get
            Return mLINEA_COD
        End Get
        Set(ByVal value As String)
            mLINEA_COD = value
        End Set
    End Property
    Public Property ZONA_COD() As String
        Get
            Return mZONA_COD
        End Get
        Set(ByVal value As String)
            mZONA_COD = value
        End Set
    End Property
    Public Property AGE() As String
        Get
            Return mAGE
        End Get
        Set(ByVal value As String)
            mAGE = value
        End Set
    End Property
    Public Property AUTO() As String
        Get
            Return mAUTO
        End Get
        Set(ByVal value As String)
            mAUTO = value
        End Set
    End Property
    Public Property FEC_PCESE() As Date
        Get
            Return mFEC_PCESE
        End Get
        Set(ByVal value As Date)
            mFEC_PCESE = value
        End Set
    End Property
    Public Property FEC_T_MOV_AFP() As Date
        Get
            Return mFEC_T_MOV_AFP
        End Get
        Set(ByVal value As Date)
            mFEC_T_MOV_AFP = value
        End Set
    End Property
    Public Property FEC_T__MOV_AFP() As Date
        Get
            Return mFEC_T__MOV_AFP
        End Get
        Set(ByVal value As Date)
            mFEC_T__MOV_AFP = value
        End Set
    End Property
    Public Property NRO_AFP() As String
        Get
            Return mNRO_AFP
        End Get
        Set(ByVal value As String)
            mNRO_AFP = value
        End Set
    End Property
    Public Property T_MOV_AFP_COD() As String
        Get
            Return mT_MOV_AFP_COD
        End Get
        Set(ByVal value As String)
            mT_MOV_AFP_COD = value
        End Set
    End Property
    Public Property X_TDOC() As String
        Get
            Return mX_TDOC
        End Get
        Set(ByVal value As String)
            mX_TDOC = value
        End Set
    End Property
    Public Property PRDO() As Integer
        Get
            Return mPRDO
        End Get
        Set(ByVal value As Integer)
            mPRDO = value
        End Set
    End Property
    Public Property X_PLA() As String
        Get
            Return mX_PLA
        End Get
        Set(ByVal value As String)
            mX_PLA = value
        End Set
    End Property
    Public Property TOT_HOR() As Integer
        Get
            Return mTOT_HOR
        End Get
        Set(ByVal value As Integer)
            mTOT_HOR = value
        End Set
    End Property
    Public Property TOT_MIN() As Integer
        Get
            Return mTOT_MIN
        End Get
        Set(ByVal value As Integer)
            mTOT_MIN = value
        End Set
    End Property
    Public Property TOT_DIA() As Double
        Get
            Return mTOT_DIA
        End Get
        Set(ByVal value As Double)
            mTOT_DIA = value
        End Set
    End Property
    Public Property NN() As String
        Get
            Return mNN
        End Get
        Set(ByVal value As String)
            mNN = value
        End Set
    End Property
    Public Property X_SET() As String
        Get
            Return mX_SET
        End Get
        Set(ByVal value As String)
            mX_SET = value
        End Set
    End Property
    Public Property T_TRAB() As String
        Get
            Return mT_TRAB
        End Get
        Set(ByVal value As String)
            mT_TRAB = value
        End Set
    End Property
    Public Property FEC_AFP() As Date
        Get
            Return mFEC_AFP
        End Get
        Set(ByVal value As Date)
            mFEC_AFP = value
        End Set
    End Property
    Public Property MOTI_BAJA_COD() As String
        Get
            Return mMOTI_BAJA_COD
        End Get
        Set(ByVal value As String)
            mMOTI_BAJA_COD = value
        End Set
    End Property
    Public Property NIP() As String
        Get
            Return mNIP
        End Get
        Set(ByVal value As String)
            mNIP = value
        End Set
    End Property
    Public Property ID_NRO() As String
        Get
            Return mID_NRO
        End Get
        Set(ByVal value As String)
            mID_NRO = value
        End Set
    End Property
    Public Property PUNTUALIDAD() As String
        Get
            Return mPUNTUALIDAD
        End Get
        Set(ByVal value As String)
            mPUNTUALIDAD = value
        End Set
    End Property
    Public Property CONTRATO_PRDO() As String
        Get
            Return mCONTRATO_PRDO
        End Get
        Set(ByVal value As String)
            mCONTRATO_PRDO = value
        End Set
    End Property
    Public Property X_ESTCIV() As String
        Get
            Return mX_ESTCIV
        End Get
        Set(ByVal value As String)
            mX_ESTCIV = value
        End Set
    End Property
    Public Property GRA_MES() As Integer
        Get
            Return mGRA_MES
        End Get
        Set(ByVal value As Integer)
            mGRA_MES = value
        End Set
    End Property
    Public Property T_GRA() As String
        Get
            Return mT_GRA
        End Get
        Set(ByVal value As String)
            mT_GRA = value
        End Set
    End Property
    Public Property COD_EDUCATIVO() As String
        Get
            Return mCOD_EDUCATIVO
        End Get
        Set(ByVal value As String)
            mCOD_EDUCATIVO = value
        End Set
    End Property
    Public Property X_SUPERV() As String
        Get
            Return mX_SUPERV
        End Get
        Set(ByVal value As String)
            mX_SUPERV = value
        End Set
    End Property
    Public Property CARGO_COD() As Integer
        Get
            Return mCARGO_COD
        End Get
        Set(ByVal value As Integer)
            mCARGO_COD = value
        End Set
    End Property
    Public Property TURNO() As String
        Get
            Return mTURNO
        End Get
        Set(ByVal value As String)
            mTURNO = value
        End Set
    End Property
    Public Property TALLA() As String
        Get
            Return mTALLA
        End Get
        Set(ByVal value As String)
            mTALLA = value
        End Set
    End Property
    Public Property TALLA1() As String
        Get
            Return mTALLA1
        End Get
        Set(ByVal value As String)
            mTALLA1 = value
        End Set
    End Property
    Public Property TALLA2() As String
        Get
            Return mTALLA2
        End Get
        Set(ByVal value As String)
            mTALLA2 = value
        End Set
    End Property
    Public Property ART_COD() As String
        Get
            Return mART_COD
        End Get
        Set(ByVal value As String)
            mART_COD = value
        End Set
    End Property
    Public Property ART_COD1() As String
        Get
            Return mART_COD1
        End Get
        Set(ByVal value As String)
            mART_COD1 = value
        End Set
    End Property
    Public Property ART_COD2() As String
        Get
            Return mART_COD2
        End Get
        Set(ByVal value As String)
            mART_COD2 = value
        End Set
    End Property
    Public Property ART_COD3() As String
        Get
            Return mART_COD3
        End Get
        Set(ByVal value As String)
            mART_COD3 = value
        End Set
    End Property
    Public Property OBS1() As String
        Get
            Return mOBS1
        End Get
        Set(ByVal value As String)
            mOBS1 = value
        End Set
    End Property
    Public Property CTA_DOLAR() As String
        Get
            Return mCTA_DOLAR
        End Get
        Set(ByVal value As String)
            mCTA_DOLAR = value
        End Set
    End Property
    Public Property MES_TIEMPO_SERV() As Integer
        Get
            Return mMES_TIEMPO_SERV
        End Get
        Set(ByVal value As Integer)
            mMES_TIEMPO_SERV = value
        End Set
    End Property
    Public Property T_REM() As String
        Get
            Return mT_REM
        End Get
        Set(ByVal value As String)
            mT_REM = value
        End Set
    End Property
    Public Property UBIGEO() As String
        Get
            Return mUBIGEO
        End Get
        Set(ByVal value As String)
            mUBIGEO = value
        End Set
    End Property
    Public Property UBIGEO_NAC() As String
        Get
            Return mUBIGEO_NAC
        End Get
        Set(ByVal value As String)
            mUBIGEO_NAC = value
        End Set
    End Property
    Public Property X_COMISION() As String
        Get
            Return mX_COMISION
        End Get
        Set(ByVal value As String)
            mX_COMISION = value
        End Set
    End Property
    Public Property X_CHE() As String
        Get
            Return mX_CHE
        End Get
        Set(ByVal value As String)
            mX_CHE = value
        End Set
    End Property
    Public Property NRO_CTA_BANCO() As String
        Get
            Return mNRO_CTA_BANCO
        End Get
        Set(ByVal value As String)
            mNRO_CTA_BANCO = value
        End Set
    End Property
    Public Property NRO_CTA_CTS() As String
        Get
            Return mNRO_CTA_CTS
        End Get
        Set(ByVal value As String)
            mNRO_CTA_CTS = value
        End Set
    End Property
    Public Property BCO_CTS_COD() As String
        Get
            Return mBCO_CTS_COD
        End Get
        Set(ByVal value As String)
            mBCO_CTS_COD = value
        End Set
    End Property
    Public Property TARDE() As Integer
        Get
            Return mTARDE
        End Get
        Set(ByVal value As Integer)
            mTARDE = value
        End Set
    End Property
    Public Property TURNO1() As String
        Get
            Return mTURNO1
        End Get
        Set(ByVal value As String)
            mTURNO1 = value
        End Set
    End Property
    Public Property CARGO_CODIGO() As String
        Get
            Return mCARGO_CODIGO
        End Get
        Set(ByVal value As String)
            mCARGO_CODIGO = value
        End Set
    End Property
    Public Property COD_GRUPO() As String
        Get
            Return mCOD_GRUPO
        End Get
        Set(ByVal value As String)
            mCOD_GRUPO = value
        End Set
    End Property

    Public Property PER_QUINTA As Double
        Get
            Return mPER_QUINTA
        End Get
        Set(value As Double)
            mPER_QUINTA = value
        End Set
    End Property

    Public Property PER_ANHO As String
        Get
            Return mPER_ANHO
        End Get
        Set(value As String)
            mPER_ANHO = value
        End Set
    End Property

    Public Property FECC_ICESE As String
        Get
            Return mFECC_ICESE
        End Get
        Set(value As String)
            mFECC_ICESE = value
        End Set
    End Property

    Public Property FECEMIDNI() As Date
        Get
            Return mFECEMIDNI
        End Get
        Set(value As Date)
            mFECEMIDNI = value
        End Set
    End Property
End Class
