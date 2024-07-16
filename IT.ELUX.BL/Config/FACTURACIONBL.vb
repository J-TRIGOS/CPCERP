Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class FACTURACIONBL
    Private FACTURACIONDAL As New FACTURACIONDAL
    Public Function SelectAll(ByVal sCode As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return FACTURACIONDAL.SelectAll(sCode, sAño, sMes)
    End Function

    Public Function SelectRegVen(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return FACTURACIONDAL.SelectRegVen(sAño, sMes)
    End Function

    Public Function SelectRegVenAll(ByVal sAño As String) As DataTable
        Return FACTURACIONDAL.SelectRegVenAll(sAño)
    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Return FACTURACIONDAL.SelectNro1(sCode, sSer)
    End Function

    Public Function SelNroLet(ByVal sCode As String, ByVal sSer As String, ByVal sNro As String) As Int32
        Return FACTURACIONDAL.SelNroLet(sCode, sSer, sNro)
    End Function

    Public Function SelectNro4(ByVal sCode As String, ByVal sSer As String) As Int32
        Return FACTURACIONDAL.SelectNro4(sCode, sSer)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return FACTURACIONDAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function

    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Return FACTURACIONDAL.SelectT_DOC(sCod)
    End Function

    Public Function SelectT_MOVINV() As DataTable
        Return FACTURACIONDAL.SelectT_MOVINV()
    End Function

    Public Function SelectF_PAGO() As DataTable
        Return FACTURACIONDAL.SelectF_PAGO()
    End Function

    Public Function SelectF_ENT() As DataTable
        Return FACTURACIONDAL.SelectF_ENT()
    End Function
    Public Function SelectMoneda() As DataTable
        Return FACTURACIONDAL.SelectMoneda()
    End Function

    Public Function SelectVendedor() As DataTable
        Return FACTURACIONDAL.SelectVendedor()
    End Function

    Public Function SelectCliente() As DataTable
        Return FACTURACIONDAL.SelectCliente()
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Return FACTURACIONDAL.SelectDir(sCod)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return FACTURACIONDAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getTxtFc(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String, ByVal sCliente As String) As String
        Return FACTURACIONDAL.getTxtFc(sT_doc, sS_doc, sN_doc, sEst, sCliente)
    End Function

    Public Function getFecha(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String, ByVal sCliente As String) As String
        Return FACTURACIONDAL.getTxtFc(sT_doc, sS_doc, sN_doc, sEst, sCliente)
    End Function

    Public Function getTxtFc1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String, ByVal sCliente As String) As String
        Return FACTURACIONDAL.getTxtFc1(sT_doc, sS_doc, sN_doc, sEst, sCliente)
    End Function

    Public Function getTxtFcGra(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As String
        Return FACTURACIONDAL.getTxtFcGra(sT_doc, sS_doc, sN_doc, sEst)
    End Function

    Public Function getTxtFcExp(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As String
        Return FACTURACIONDAL.getTxtFcExp(sT_doc, sS_doc, sN_doc, sEst)
    End Function
    Public Function getTxtFcExp1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As String
        Return FACTURACIONDAL.getTxtFCExp1(sT_doc, sS_doc, sN_doc, sEst)
    End Function

    Public Function SelectEstRecogido(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return FACTURACIONDAL.SelectEstRecogido(sAño, sMes)
    End Function

    Public Function SelNomMon(ByVal sCOD As String) As String
        Return FACTURACIONDAL.SelNomMon(sCOD)
    End Function
#Region "Grabar Datos"
    Public Function SaveRow(ByVal FACTURACIONBE As FACTURACIONBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return FACTURACIONDAL.SaveRow(FACTURACIONBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg)
    End Function

    Public Function AsientoFC(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String, ByVal sEst As String, ByVal dg As DataGridView) As String
        Return FACTURACIONDAL.AsientoFC(flagAccion, sAño, sMes, sNro, sSer, sTipo, sEst, dg)
    End Function

    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal dg As DataGridView, ByVal usuario As String) As String
        Return FACTURACIONDAL.SaveRowAllMes(flagAccion, sAño, sMes, dg, usuario)
    End Function

    Public Function SaveRowEst(ByVal FACTURACIONBE As FACTURACIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                               ByVal flagAccion As String) As String
        Return FACTURACIONDAL.SaveRowEst(FACTURACIONBE, ELMVLOGSBE, flagAccion)
    End Function

#End Region
End Class
