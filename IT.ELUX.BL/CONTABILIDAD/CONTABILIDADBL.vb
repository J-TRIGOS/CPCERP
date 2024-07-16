Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class CONTABILIDADBL
    Private CONTABILIDADDAL As New CONTABILIDADDAL

    Public Function ListadoLibroDiario(ByVal anho As String, ByVal mes As String) As DataTable
        Return CONTABILIDADDAL.ListadoLibroDiario(anho, mes)
    End Function

    Public Function selectall(ByVal anho As String, ByVal mes As String, ByVal t_ope As String) As DataTable
        Return CONTABILIDADDAL.selectall(anho, mes, t_ope)
    End Function

    Public Function ListadoCreditos(ByVal anho As String, ByVal tipo As String) As DataTable
        Return CONTABILIDADDAL.ListadoCreditos(anho, tipo)
    End Function

    Public Function ObtenerLibroDiario(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal stOpe As String) As DataTable
        Return CONTABILIDADDAL.ObtenerLibroDiario(sTDoc, sSDoc, sNDoc, stOpe)
    End Function

    Public Function resumenLD(ByVal manho As String, ByVal mes1 As String, ByVal mes2 As String) As DataTable
        Return CONTABILIDADDAL.resumenLD(manho, mes1, mes2)
    End Function

    Public Function ObtenerLibroDiarioDet(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sTOpe As String) As DataTable
        Return CONTABILIDADDAL.ObtenerLibroDiarioDet(sTDoc, sSDoc, sNDoc, sTOpe)
    End Function

    Public Function SelectT_DOC() As DataTable
        Return CONTABILIDADDAL.SelectT_DOC()
    End Function

    Public Function SelectBanco() As DataTable
        Return CONTABILIDADDAL.SelectBanco()
    End Function

    Public Function SelectMoneda() As DataTable
        Return CONTABILIDADDAL.SelectMoneda()
    End Function

    Public Function BuscarFormaPago() As DataTable
        Return CONTABILIDADDAL.BuscarFormaPago()
    End Function

    Public Function BuscarCC() As DataTable
        Return CONTABILIDADDAL.BuscarCC()
    End Function

    Public Function BuscarProveedor() As DataTable
        Return CONTABILIDADDAL.BuscarProveedor()
    End Function

    Public Function ObtenerNombreFpago(ByVal cod As String) As DataTable
        Return CONTABILIDADDAL.ObtenerNombreFpago(cod)
    End Function

    Public Function ObtenerNombreCC(ByVal cod As String) As DataTable
        Return CONTABILIDADDAL.ObtenerNombreCC(cod)
    End Function

    Public Function ObtenerNombreProveedor(ByVal cod As String) As DataTable
        Return CONTABILIDADDAL.ObtenerNombreProveedor(cod)
    End Function

    Public Function ObtenerNombreDocumento(ByVal cod As String) As DataTable
        Return CONTABILIDADDAL.ObtenerNombreDocumento(cod)
    End Function

    Public Function ObtenerNombreMoneda(ByVal cod As String) As DataTable
        Return CONTABILIDADDAL.ObtenerNombreMoneda(cod)
    End Function

    Public Function SelectCC() As DataTable
        Return CONTABILIDADDAL.SelectCC()
    End Function

    Public Function SelectCuentas() As DataTable
        Return CONTABILIDADDAL.SelectCuentas()
    End Function

    Public Function BuscarTCambio(ByVal fecha As String) As DataTable
        Return CONTABILIDADDAL.BuscarTCambio(fecha)
    End Function


    Public Function BuscarRegCont(ByVal LibroDiario As LIBRO_DIARIOBE) As DataTable
        Return CONTABILIDADDAL.BuscarRegCont(LibroDiario)
    End Function

    Public Function SaveRow(ByVal LibroDiario As LIBRO_DIARIOBE, ByVal mes As String, ByVal anho As String, ByVal flagaccion As String) As String
        Return CONTABILIDADDAL.SaveRow(LibroDiario, mes, anho, flagaccion)
    End Function

    Public Function SaveRowDet(ByVal DetLibroDiario As DET_LIBRO_DIARIOBE, ByVal mes As String, ByVal anho As String, ByVal flagaccion As String) As String
        Return CONTABILIDADDAL.SaveRowDet(DetLibroDiario, mes, anho, flagaccion)
    End Function

    Public Function BuscarUsuario(ByVal codigo As String) As DataTable
        Return CONTABILIDADDAL.BuscarUsuario(codigo)
    End Function

    Public Function BuscarTDocumento(ByVal codigo As String) As DataTable
        Return CONTABILIDADDAL.BuscarTDocumento(codigo)
    End Function

    Public Function BuscarDocumentosLD(ByVal tdoc As String, ByVal nro As String, ByVal anho As String) As DataTable
        Return CONTABILIDADDAL.BuscarDocumentosLD(tdoc, nro, anho)
    End Function

    Public Function VerificarRegistroContable(ByVal libroDiario As LIBRO_DIARIOBE) As DataTable
        Return CONTABILIDADDAL.VerificarRegistroContable(libroDiario)
    End Function

    Public Function BuscarCuentaDestino(ByVal cuenta As String, ByVal anho As String) As DataTable
        Return CONTABILIDADDAL.BuscarCuentaDestino(cuenta, anho)
    End Function

    Public Function VerificarNumeroContable(ByVal tipOpe As String, ByVal mes As String, ByVal anho As String) As DataTable
        Return CONTABILIDADDAL.VerificarNumeroContable(tipOpe, mes, anho)
    End Function

    'Public Function AsientoLD(ByVal anho As String, ByVal mes As String, ByVal tipOpe As String, ByVal tipDoc As String, ByVal serie As String, ByVal numero As String,
    '                          ByVal codProveedor As String, ByVal Fecha As String, ByVal concepto As String, ByVal regcontable As String) As String
    '    Return CONTABILIDADDAL.AsientoLD(anho, mes, tipOpe, tipDoc, serie, numero, codProveedor, Fecha, concepto, regcontable)
    'End Function

    Public Function AsientoLD(ByVal librodiario As LIBRO_DIARIOBE, ByVal detlibrodiario As DET_LIBRO_DIARIOBE, ByVal mes As String, ByVal anho As String) As String
        Return CONTABILIDADDAL.AsientoLD(librodiario, detlibrodiario, mes, anho)
    End Function

    Public Function BuscarDocumentosClientes(ByVal anho As String, ByVal mes As String) As DataTable
        Return CONTABILIDADDAL.BuscarDocumentosClientes(anho, mes)
    End Function

    Public Function actualizarTablaMOVCT(ByVal librodiario As LIBRO_DIARIOBE, ByVal mmes As String, ByVal manho As String) As DataTable
        Dim dtDatos = CONTABILIDADDAL.actualizarTablaMOVCT(librodiario, mmes, manho)
    End Function
    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal usuario As String) As String
        Return CONTABILIDADDAL.SaveRowAllMes(flagAccion, sAño, sMes, usuario)
    End Function
End Class
