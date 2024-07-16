Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBPROGPAGOBL
    Private ELTBPROGPAGODAL As New ELTBPROGPAGODAL
    Public Function SelectAll(ByVal sCode As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return ELTBPROGPAGODAL.SelectAll(sCode, sAño, sMes)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBPROGPAGODAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String, ByVal sfec As String) As String
        Return ELTBPROGPAGODAL.SelectNro1(sCode, sSer, sfec)

    End Function

    Public Function SelectF_PAGO() As DataTable
        Return ELTBPROGPAGODAL.SelectF_PAGO()
    End Function

    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Return ELTBPROGPAGODAL.SelectT_DOC(sCod)
    End Function

    Public Function SelectMoneda() As DataTable
        Return ELTBPROGPAGODAL.SelectMoneda()
    End Function

    Public Function SelectCliente() As DataTable
        Return ELTBPROGPAGODAL.SelectCliente()
    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Return ELTBPROGPAGODAL.SelectNro1(sCode, sSer)
    End Function

    Public Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal pcli As String,
                     ByVal fec As Date, ByVal nmon As String)
        Return ELTBPROGPAGODAL.list1(tdoc, sdoc, ndoc, pcli, fec, nmon)
    End Function

    Public Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal pcli As String,
                          ByVal nmon As String)
        Return ELTBPROGPAGODAL.list2(tdoc, sdoc, ndoc, pcli, nmon)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sPcli As String) As DataTable
        Return ELTBPROGPAGODAL.getListdgv(sT_doc, sS_doc, sN_doc, sPcli)
    End Function

    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBPROGPAGODAL.getListdgv1(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getT_CAMB(ByVal fec As String) As DataTable
        Return ELTBPROGPAGODAL.getT_CAMB(fec)
    End Function

    Public Function SelectCantDias(ByVal sCod As String) As Integer
        Return ELTBPROGPAGODAL.SelectCantDias(sCod)
    End Function

    Public Function SaveRow(ByVal ELTBPROGPAGOBE As ELTBPROGPAGOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                        ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELTBPROGPAGODAL.SaveRow(ELTBPROGPAGOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg)
    End Function

    Public Function SelectT_OPE(ByVal sFec As String) As DataTable
        Return ELTBPROGPAGODAL.SelectT_OPE(sFec)
    End Function

    Public Function SelectBanco() As DataTable
        Return ELTBPROGPAGODAL.SelectBanco()
    End Function
    Public Function SelectAct_flujo() As DataTable
        Return ELTBPROGPAGODAL.SelectAct_flujo()
    End Function

    Public Function SelectFlujo_caja(ByVal sTope As String, ByVal sAflu As String) As DataTable
        Return ELTBPROGPAGODAL.SelectFlujo_caja(sTope, sAflu)
    End Function

    Public Function SelectCuenta(ByVal sFec As String, ByVal sCuenta As String) As String
        Return ELTBPROGPAGODAL.SelectCuenta(sFec, sCuenta)
    End Function

    Public Function AsientoFC(ByVal flagAccion As String, ByVal sNro As String, ByVal sSer As String,
                              ByVal sTipo As String, ByVal sProv As String, ByVal dg As DataGridView, ByVal anhomes As String) As String
        Return ELTBPROGPAGODAL.AsientoFC(flagAccion, sNro, sSer, sTipo, sProv, dg, anhomes)
    End Function
End Class
