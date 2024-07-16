Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class LETRASBL
    Private LETRASDAL As New LETRASDAL
    Public Function SelectAll(ByVal sCode As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return LETRASDAL.SelectAll(sCode, sAño, sMes)
    End Function
    Public Function SelectRegVen(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return LETRASDAL.SelectRegVen(sAño, sMes)
    End Function
    Public Function SelectEstRecogido(ByVal sAño As String, ByVal sMes As String) As DataTable
        Return LETRASDAL.SelectEstRecogido(sAño, sMes)
    End Function
    Public Function SelectRegVenAll(ByVal sAño As String) As DataTable
        Return LETRASDAL.SelectRegVenAll(sAño)
    End Function
    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Return LETRASDAL.SelectNro1(sCode, sSer)
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return LETRASDAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function
    Public Function SelectRowLetra(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return LETRASDAL.SelectRowLetra(sCode, sS_doc, sN_doc)
    End Function
    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Return LETRASDAL.SelectT_DOC(sCod)
    End Function
    Public Function SelectF_PAGO() As DataTable
        Return LETRASDAL.SelectF_PAGO()
    End Function
    Public Function SelectMoneda() As DataTable
        Return LETRASDAL.SelectMoneda()
    End Function

    Public Function SelectVendedor() As DataTable
        Return LETRASDAL.SelectVendedor()
    End Function

    Public Function SelectCliente() As DataTable
        Return LETRASDAL.SelectCliente()
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Return LETRASDAL.SelectDir(sCod)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return LETRASDAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getListLT(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return LETRASDAL.getListLT(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getListdgvmonto(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return LETRASDAL.getListdgvmonto(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getListdgv2(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return LETRASDAL.getListdgv2(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getListdgvletras() As DataTable
        Return LETRASDAL.getListdgvletras()
    End Function

    Public Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return LETRASDAL.list1(tdoc, sdoc, ndoc, fec)
    End Function
    Public Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String)
        Return LETRASDAL.list2(tdoc, sdoc, ndoc)
    End Function
    Public Function list3(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date)
        Return LETRASDAL.list3(tdoc, sdoc, ndoc, fec)
    End Function

    Public Function SelectCantDias(ByVal sCod As String) As Integer
        Return LETRASDAL.SelectCantDias(sCod)
    End Function

#Region "Grabar Datos"
    Public Function SaveRow(ByVal LETRASBE As LETRASBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView, ByVal dgmontos As DataGridView, ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE) As String
        Return LETRASDAL.SaveRow(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg, dgmontos, ELTBLETRAS_MONTOBE)
    End Function
    Public Function SaveRow1(ByVal LETRASBE As LETRASBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView, ByVal dgmontos As DataGridView, ByVal dgdet As DataGridView, ByVal ELTBLETRAS_MONTOBE As ELTBLETRAS_MONTOBE) As String
        Return LETRASDAL.SaveRow1(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg, dgmontos, dgdet, ELTBLETRAS_MONTOBE)
    End Function
    Public Function SaveRowEST1(ByVal LETRASBE As LETRASBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                           ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return LETRASDAL.SaveRowEst1(LETRASBE, ELMVLOGSBE, flagAccion, dg)
    End Function
    Public Function AsientoFC(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String, ByVal sEst As String, ByVal dg As DataGridView) As String
        Return LETRASDAL.AsientoFC(flagAccion, sAño, sMes, sNro, sSer, sTipo, sEst, dg)
    End Function

    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal dg As DataGridView) As String
        Return LETRASDAL.SaveRowAllMes(flagAccion, sAño, sMes, dg)
    End Function

    Public Function SaveRowEst(ByVal LETRASBE As LETRASBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                           ByVal flagAccion As String) As String
        Return LETRASDAL.SaveRowEst(LETRASBE, ELMVLOGSBE, flagAccion)
    End Function

#End Region
End Class
