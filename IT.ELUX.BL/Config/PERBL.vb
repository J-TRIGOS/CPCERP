Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.DAL
Public Class PERBL
    Private PERDAL As New PERDAL
#Region "Lectura de Datos"
    Public Function SelPerAll() As DataTable
        Return PERDAL.SelPerAll()
    End Function
    Public Function SelDocPrestamo() As DataTable
        Return PERDAL.SelDocPrestamo()
    End Function
    Public Function SelPerAllObr() As DataTable
        Return PERDAL.SelPerAllObr()
    End Function

    Public Function SelPerAll1() As DataTable
        Return PERDAL.SelPerAll1()
    End Function
    Public Function SelPerDias(ByVal sCod As String) As DataTable
        Return PERDAL.SelPerDias(sCod)
    End Function
    Public Function SelPerDifHorAs(ByVal sFec As String, ByVal sFec1 As String) As DataTable
        Return PERDAL.SelPerDifHorAs(sFec, sFec1)
    End Function
    Public Function SelPerHorTareo(ByVal sFec As String, ByVal sFec1 As String) As DataTable
        Return PERDAL.SelPerHorTareo(sFec, sFec1)
    End Function
    Public Function SelPerHorInc(ByVal sFec As String, ByVal sFec1 As String) As DataTable
        Return PERDAL.SelPerHorInc(sFec, sFec1)
    End Function
    Public Function SelPerAllActivos() As DataTable
        Return PERDAL.SelPerAllActivos()
    End Function
    Public Function SelPerAllActivosTemp(ByVal sCode As String) As DataTable
        Return PERDAL.SelPerAllActivosTemp(sCode)
    End Function
    Public Function SelPerActivosTemp(ByVal sCode As String) As DataTable
        Return PERDAL.SelPerActivosTemp(sCode)
    End Function
    Public Function SelPerEmailCor(ByVal sCode As String) As String
        Return PERDAL.SelPerEmailCor(sCode)
    End Function

    Public Function SelPerCargo(ByVal sCode As String) As String
        Return PERDAL.SelPerCargo(sCode)
    End Function
    Public Function SelLineaCod(ByVal sCode As String) As String
        Return PERDAL.SelLineaCod(sCode)
    End Function

    Public Function SelCco_Cod(ByVal sCode As String) As String
        Return PERDAL.SelCco_Cod(sCode)
    End Function
    Public Function SelPERCpto(ByVal sCode As String) As String
        Return PERDAL.SelPERCpto(sCode)
    End Function
    Public Function SelPrdoContratoFin(ByVal sCode As String) As String
        Return PERDAL.SelPrdoContratoFin(sCode)
    End Function
    Public Function SelPrdoContratoIni(ByVal sCode As String) As String
        Return PERDAL.SelPrdoContratoIni(sCode)
    End Function
    Public Function SelCTABCOCTS(ByVal sCode As String) As String
        Return PERDAL.SelCTABCOCTS(sCode)
    End Function
    Public Function SelPerCargoNew(ByVal sCode As String) As String
        Return PERDAL.SelPerCargoNew(sCode)
    End Function
    Public Function SelectApeNom(ByVal sCode As String) As String
        Return PERDAL.SelectApeNom(sCode)
    End Function
    Public Function SelPerAllContrato() As DataTable
        Return PERDAL.SelPerAllContrato()
    End Function
    Public Function SelPerAllContratoNuevo(ByVal sbusBusAlm As String) As DataTable
        Return PERDAL.SelPerAllContratoNuevo(sbusBusAlm)
    End Function
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return PERDAL.SelectRow(sCode)
    End Function
    Public Function SelectTipEducativo(ByVal sCode As String) As String
        Return PERDAL.SelectTipEducativo(sCode)
    End Function
    Public Function SelectNomUbiProv(ByVal sCode As String) As String
        Return PERDAL.SelectNomUbiProv(sCode)
    End Function
    Public Function SelectNomUbiDpto(ByVal sCode As String) As String
        Return PERDAL.SelectNomUbiDpto(sCode)
    End Function
    Public Function SelectNomUbiNac(ByVal sCode As String) As String
        Return PERDAL.SelectNomUbiNac(sCode)
    End Function
    Public Function SelPerViaAll() As DataTable
        Return PERDAL.SelPerViaAll()
    End Function
    Public Function SelPerViaRow(ByVal sCode As String) As String
        Return PERDAL.SelPerViaRow(sCode)
    End Function
    Public Function SelPerZonaAll() As DataTable
        Return PERDAL.SelPerZonaAll()
    End Function
    Public Function SelPerZonaRow(ByVal sCode As String) As String
        Return PERDAL.SelPerZonaRow(sCode)
    End Function
    Public Function SelectContratoprd(ByVal sCode As String) As DataTable
        Return PERDAL.SelectContratoprd(sCode)
    End Function
    Public Function SelectCodEdu() As DataTable
        Return PERDAL.SelectCodEdu()
    End Function
    Public Function SelectCodEduNom(ByVal sCode As String) As String
        Return PERDAL.SelectCodEduNom(sCode)
    End Function
    Public Function SelectCargoOcupacion() As DataTable
        Return PERDAL.SelectCargoOcupacion()
    End Function
    Public Function SelectCargoOcu(ByVal sCode As String) As String
        Return PERDAL.SelectCargoOcu(sCode)
    End Function
    Public Function SelectCargo() As DataTable
        Return PERDAL.SelectCargo()
    End Function
    Public Function SelectCargoNom(ByVal sCode As String) As String
        Return PERDAL.SelectCargoNom(sCode)
    End Function
    Public Function SelectLinea(ByVal centroCod As String) As DataTable
        Return PERDAL.SelectLinea(centroCod)
    End Function
    Public Function SelectLineaNom(ByVal sCode As String) As String
        Return PERDAL.SelectLineaNom(sCode)
    End Function
    Public Function SelectContrato() As DataTable
        Return PERDAL.SelectContrato()
    End Function
    Public Function SelectContratoIni(ByVal sCode As String) As String
        Return PERDAL.SelectContratoIni(sCode)
    End Function
    Public Function SelectPrdoFecIni(ByVal sCode As String) As String
        Return PERDAL.SelectPrdoFecIni(sCode)
    End Function
    Public Function SelectContratoFin(ByVal sCode As String) As String
        Return PERDAL.SelectContratoFin(sCode)
    End Function
    Public Function SelectPerCPTO() As DataTable
        Return PERDAL.SelectPerCPTO()
    End Function
    Public Function SelectBcoCTS() As DataTable
        Return PERDAL.SelectBcoCTS()
    End Function
    Public Function SelectBcoCTSNom(ByVal sCode As String) As String
        Return PERDAL.SelectBcoCTSNom(sCode)
    End Function
#End Region
    Public Function SaveRow(ByVal PERBE As PERBE, ByVal ASI_CPTOBE As ASI_CPTOBE, ByVal DERECHOHABBE As DERECHOHABBE,
                            ByVal DHAB_DIRBE As DHAB_DIRBE, ByVal dgvcpto As DataGridView, ByVal dgvdep As DataGridView,
                          ByVal dgvdirdep As DataGridView, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagaccion As String) As String
        Return PERDAL.SaveRow(PERBE, ASI_CPTOBE, DERECHOHABBE, DHAB_DIRBE, dgvcpto, dgvdep, dgvdirdep, ELMVLOGSBE, flagaccion)
    End Function

    Public Function Save(ByVal PERBE As PERBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dgvcpto As DataGridView, ByVal flagaccion As String) As String
        Return PERDAL.Save(PERBE, ELMVLOGSBE, dgvcpto, flagaccion)
    End Function

    Public Function ActualizarSPBoleta(ByVal PRDO As String) As String
        Return PERDAL.ActualizarSPBoleta(PRDO)
    End Function

    Public Function InsAsPlan(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sCmb As Double, ByVal sFec As Date,
                              ByVal sFla As String, ByVal sPRDO As String) As String
        Return PERDAL.InsAsPlan(sTip, sSer, sNro, sCmb, sFec, sFla, sPRDO)
    End Function
    Public Function ActualizarBoletas(ByVal prdo As String) As DataTable
        Return PERDAL.ActualizarBoletas(prdo)
    End Function
    Public Function ActualizarBoletasGra(ByVal prdo As String) As DataTable
        Return PERDAL.ActualizarBoletasGra(prdo)
    End Function

    Public Function BuscarCCOCOD() As DataTable
        Return PERDAL.BuscarCCOCOD()
    End Function
End Class
