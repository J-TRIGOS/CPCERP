Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class NOTADEBITOBL
    Private NOTADEBITODAL As New NOTADEBITODAL
    Public Function SelectAll(ByVal sCode As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return NOTADEBITODAL.SelectAll(sCode, sAño, sMes)
    End Function
    Public Function SelectRegVen(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return NOTADEBITODAL.SelectRegVen(sAño, sMes)
    End Function
    Public Function SelectEstRecogido(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return NOTADEBITODAL.SelectEstRecogido(sAño, sMes)
    End Function
    Public Function SelectRegVenAll(ByVal sAño As String) As DataTable
        Return NOTADEBITODAL.SelectRegVenAll(sAño)
    End Function
    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Return NOTADEBITODAL.SelectNro1(sCode, sSer)
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return NOTADEBITODAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function
    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Return NOTADEBITODAL.SelectT_DOC(sCod)
    End Function

    Public Function SelectT_MOVINV() As DataTable
        Return NOTADEBITODAL.SelectT_MOVINV()
    End Function
    Public Function SelectMov_Mot(ByVal sCod As String) As DataTable
        Return NOTADEBITODAL.SelectMov_Mot(sCod)
    End Function

    Public Function SelectF_PAGO() As DataTable
        Return NOTADEBITODAL.SelectF_PAGO()
    End Function

    Public Function SelectF_ENT() As DataTable
        Return NOTADEBITODAL.SelectF_ENT()
    End Function
    Public Function SelectMoneda() As DataTable
        Return NOTADEBITODAL.SelectMoneda()
    End Function

    Public Function SelectVendedor() As DataTable
        Return NOTADEBITODAL.SelectVendedor()
    End Function

    Public Function SelectCliente() As DataTable
        Return NOTADEBITODAL.SelectCliente()
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Return NOTADEBITODAL.SelectDir(sCod)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return NOTADEBITODAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getTxtFc(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As String
        Return NOTADEBITODAL.getTxtFc(sT_doc, sS_doc, sN_doc, sEst)
    End Function

    Public Function getTxtFc1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As String
        Return NOTADEBITODAL.getTxtFc1(sT_doc, sS_doc, sN_doc, sEst)
    End Function

    'Public Function getAsiento(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As String
    '    Return NOTADEBITODAL.getTxtFc(sT_doc, sS_doc, sN_doc)
    'End Function

#Region "Grabar Datos"
    Public Function SaveRow(ByVal NOTADEBITOBE As NOTADEBITOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return NOTADEBITODAL.SaveRow(NOTADEBITOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg)
    End Function

    Public Function AsientoFC(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String, ByVal sEst As String, ByVal dg As DataGridView) As String
        Return NOTADEBITODAL.AsientoFC(flagAccion, sAño, sMes, sNro, sSer, sTipo, sEst, dg)
    End Function

    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal dg As DataGridView) As String
        Return NOTADEBITODAL.SaveRowAllMes(flagAccion, sAño, sMes, dg)
    End Function
    Public Function SaveRowEst(ByVal NOTADEBITOBE As NOTADEBITOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                              ByVal flagAccion As String) As String
        Return NOTADEBITODAL.SaveRowEst(NOTADEBITOBE, ELMVLOGSBE, flagAccion)
    End Function
#End Region
End Class
