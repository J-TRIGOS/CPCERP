Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELPAGO_DOCUMENTOBL
    Private ELPAGO_DOCUMENTODAL As New ELPAGO_DOCUMENTODAL
    Private REGCONTDAL As New REGCONTDAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.SelPerAll(var)
    End Function
#End Region
    Public Function SaveRow(ByVal ELPAGO_DOCUMENTOBE As ELPAGO_DOCUMENTOBE, ByVal flagaccion As String, ByVal dg As DataGridView, ByVal ELPAGO_DET_DOCUMENTOBE As ELPAGO_DET_DOCUMENTOBE) As String
        Return ELPAGO_DOCUMENTODAL.SaveRow(ELPAGO_DOCUMENTOBE, flagaccion, dg, ELPAGO_DET_DOCUMENTOBE)
    End Function
    Public Function SelectTipoC(ByVal var As DateTime) As String
        Return ELPAGO_DOCUMENTODAL.SelectTipoC(var)
    End Function
    Public Function SelectRow(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectRow(sTDoc, sSDoc, sNDoc)
    End Function
    Public Function SelectRowDetalle(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sCos As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectRowDetalle(sTdoc, sSDoc, sNDoc, sCos)
    End Function
    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Return ELPAGO_DOCUMENTODAL.VerificarRepetido(cod)
    End Function
    Public Function SelectAll(ByVal anho As String, ByVal mes As String, ByVal ope As String, ByVal mon As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectAll(anho, mes, ope, mon)
    End Function

    Public Function BuscarCtaBanco(ByVal bcoCod As String, ByVal anho As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.BuscarCtaBanco(bcoCod, anho)
    End Function
    Public Function SelectTipodoc() As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectTipodoc()
    End Function
    Public Function BuscarCentroCosto() As DataTable
        Return ELPAGO_DOCUMENTODAL.BuscarCentroCosto()
    End Function
    Public Function SelectMoneda() As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectMoneda()
    End Function
    Public Function SelectProveedor() As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectProveedor()
    End Function
    Public Function SelectCentroCosto() As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectCentroCosto()
    End Function
    Public Function SelectCentroCosto1() As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectCentroCosto1()
    End Function
    Public Function SelectTipodocCOD(ByVal codigo As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectTipodocCOD(codigo)
    End Function
    Public Function SelectMonCOD(ByVal codigo As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectMonCOD(codigo)
    End Function
    Public Function SelectProveedorCOD(ByVal codigo As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectProveedorCOD(codigo)
    End Function
    Public Function SelectCentroCostoCOD(ByVal codigo As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectCentroCostoCOD(codigo)
    End Function
    Public Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal registro As String,
                         ByVal moneda As String, ByVal proveedor As String, ByVal var1 As String, ByVal gendesde As Date,
                         ByVal genhasta As Date, ByVal T_OPE As String)

        Return ELPAGO_DOCUMENTODAL.list1(tdoc, sdoc, ndoc, registro, moneda, proveedor, var1, gendesde,
                                         genhasta, T_OPE)

    End Function

    Public Function BuscarRegistroContable(ByVal anho As String, ByVal mes As String, ByVal ope As String, ByVal pref As String) As DataTable
        Return REGCONTDAL.BuscarRegistroContable(anho, mes, ope, pref)
    End Function

    Public Function SaveRowRegCont(ByVal MOV_CTBE As MOV_CTBE, ByVal flagaccion As String) As String
        Return ELPAGO_DOCUMENTODAL.SaveRowRegCont(MOV_CTBE, flagaccion)
    End Function

    Public Function ObtenerImporteRegCont(ByVal anho As String, ByVal mes As String, ByVal ope As String, ByVal regCont As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.ObtenerImporteRegCont(anho, mes, ope, regCont)
    End Function

    Public Function ActualizarRegContable(ByVal MOV_CTBE As MOV_CTBE, ByVal prefBanco As String) As DataTable
        Dim dtDatos = ELPAGO_DOCUMENTODAL.ActualizarRegContable(MOV_CTBE, prefBanco)
    End Function

    Public Function VerificarNumeroDoc(ByVal opeDoc As String, ByVal tipoDoc As String, ByVal serDoc As String, ByVal numDoc As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.VerificarNumeroDoc(opeDoc, tipoDoc, serDoc, numDoc)
    End Function

    Public Function VerificarTCSBS(ByVal ope As String, ByVal fecha As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.VerificarTCSBS(ope, fecha)
    End Function

    Public Function VerificarDiferenciaTC(ByVal regCont As String, ByVal mes As String, ByVal anho As String, ByVal ope As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.VerificarDiferenciaTC(regCont, mes, anho, ope)
    End Function
    Public Function ActualizarDiferenciaTC(ByVal regCont As String, ByVal mes As String, ByVal anho As String, ByVal ope As String, ByVal dif As Double) As DataTable
        Return ELPAGO_DOCUMENTODAL.ActualizarDiferenciaTC(regCont, mes, anho, ope, dif)
    End Function

    Public Function SelectProvAllFiltro(ByVal saño As String, ByVal smes As String, ByVal tipo As String,
                                  ByVal serie As String, ByVal nro As String, ByVal reg_nro As String,
                                  ByVal ruc As String, ByVal saño1 As String, ByVal smes1 As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectProvAllFiltro(saño, smes, tipo, serie, nro, reg_nro, ruc, saño1, smes1)
    End Function

    Public Function SelectFactAllFiltro(ByVal saño As String, ByVal smes As String, ByVal tipo As String,
                                  ByVal serie As String, ByVal nro As String, ByVal reg_nro As String,
                                  ByVal ruc As String, ByVal saño1 As String, ByVal smes1 As String, ByVal obs As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.SelectFactAllFiltro(saño, smes, tipo, serie, nro, reg_nro, ruc, saño1, smes1, obs)
    End Function

    Public Function BuscarCtasDestino(ByVal cta As String, ByVal anho As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.BuscarCtasDestino(cta, anho)
    End Function


    Public Function actualizarTablaMOVCT(ByVal MOV_CTBE As MOV_CTBE, ByVal mmes As String, ByVal manho As String) As DataTable
        Dim dtDatos = ELPAGO_DOCUMENTODAL.actualizarTablaMOVCT(MOV_CTBE, mmes, manho)
    End Function

    Public Function ContarMovctTemporal(ByVal ope As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.ContarMovctTemporal(ope)
    End Function

    Public Sub ProcesarMovctTemporal(ByVal ope As String)
        ELPAGO_DOCUMENTODAL.ProcesarMovctTemporal(ope)
    End Sub

    Public Function ListadoGuiasFact(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELPAGO_DOCUMENTODAL.ListadoGuiasFact(anho, mes)
    End Function
    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal tope As String, ByVal usuario As String) As String
        Return ELPAGO_DOCUMENTODAL.SaveRowAllMes(flagAccion, sAño, sMes, tope, usuario)
    End Function
End Class
