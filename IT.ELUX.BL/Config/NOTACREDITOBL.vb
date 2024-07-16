Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class NOTACREDITOBL
    Private NOTACREDITODAL As New NOTACREDITODAL
    Public Function SelectAll(ByVal sCode As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return NOTACREDITODAL.SelectAll(sCode, sAño, sMes)
    End Function
    Public Function SelectRegVen(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return NOTACREDITODAL.SelectRegVen(sAño, sMes)
    End Function
    Public Function SelectRegVenAll(ByVal sAño As String) As DataTable
        Return NOTACREDITODAL.SelectRegVenAll(sAño)
    End Function
    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Return NOTACREDITODAL.SelectNro1(sCode, sSer)
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return NOTACREDITODAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function
    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Return NOTACREDITODAL.SelectT_DOC(sCod)
    End Function

    Public Function SelectT_MOVINV() As DataTable
        Return NOTACREDITODAL.SelectT_MOVINV()
    End Function
    Public Function SelectEstRecogido(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return NOTACREDITODAL.SelectEstRecogido(sAño, sMes)
    End Function

    Public Function SelectF_PAGO() As DataTable
        Return NOTACREDITODAL.SelectF_PAGO()
    End Function

    Public Function SelectF_ENT() As DataTable
        Return NOTACREDITODAL.SelectF_ENT()
    End Function
    Public Function SelectMoneda() As DataTable
        Return NOTACREDITODAL.SelectMoneda()
    End Function

    Public Function SelectVendedor() As DataTable
        Return NOTACREDITODAL.SelectVendedor()
    End Function

    Public Function SelectCliente() As DataTable
        Return NOTACREDITODAL.SelectCliente()
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Return NOTACREDITODAL.SelectDir(sCod)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return NOTACREDITODAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getListdgv2(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return NOTACREDITODAL.getListdgv2(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getTxtFc(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As String
        Return NOTACREDITODAL.getTxtFc(sT_doc, sS_doc, sN_doc, sEst)
    End Function
    Public Function getTxtFc1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As String
        Return NOTACREDITODAL.getTxtFc1(sT_doc, sS_doc, sN_doc, sEst)
    End Function
    Public Function SelectMov_Mot(ByVal sCod As String) As DataTable
        Return NOTACREDITODAL.SelectMov_Mot(sCod)
    End Function
    'Public Function getAsiento(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As String
    '    Return NOTACREDITODAL.getTxtFc(sT_doc, sS_doc, sN_doc)
    'End Function

#Region "Grabar Datos"
    Public Function SaveRow(ByVal NOTACREDITOBE As NOTACREDITOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return NOTACREDITODAL.SaveRow(NOTACREDITOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg)
    End Function

    Public Function AsientoFC(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String, ByVal sEst As String, ByVal dg As DataGridView) As String
        Return NOTACREDITODAL.AsientoFC(flagAccion, sAño, sMes, sNro, sSer, sTipo, sEst, dg)
    End Function

    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal dg As DataGridView) As String
        Return NOTACREDITODAL.SaveRowAllMes(flagAccion, sAño, sMes, dg)
    End Function

    Public Function SaveRowEst(ByVal NOTACREDITOBE As NOTACREDITOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String) As String
        Return NOTACREDITODAL.SaveRowEst(NOTACREDITOBE, ELMVLOGSBE, flagAccion)
    End Function
#End Region
End Class
