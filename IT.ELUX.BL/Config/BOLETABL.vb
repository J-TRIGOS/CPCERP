Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class BOLETABL
    Private BOLETADAL As New BOLETADAL
    Public Function SelectAll(ByVal sCode As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return BOLETADAL.SelectAll(sCode, sAño, sMes)
    End Function
    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Return BOLETADAL.SelectNro1(sCode, sSer)
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return BOLETADAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function
    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Return BOLETADAL.SelectT_DOC(sCod)
    End Function

    Public Function SelectT_MOVINV() As DataTable
        Return BOLETADAL.SelectT_MOVINV()
    End Function

    Public Function SelectF_PAGO() As DataTable
        Return BOLETADAL.SelectF_PAGO()
    End Function

    Public Function SelectF_ENT() As DataTable
        Return BOLETADAL.SelectF_ENT()
    End Function
    Public Function SelectMoneda() As DataTable
        Return BOLETADAL.SelectMoneda()
    End Function

    Public Function SelectVendedor() As DataTable
        Return BOLETADAL.SelectVendedor()
    End Function

    Public Function SelectCliente() As DataTable
        Return BOLETADAL.SelectCliente()
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Return BOLETADAL.SelectDir(sCod)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return BOLETADAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getTxtFc(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEST As String) As String
        Return BOLETADAL.getTxtFc(sT_doc, sS_doc, sN_doc, sEST)
    End Function

    Public Function getTxtFc1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEST As String) As String
        Return BOLETADAL.getTxtFc1(sT_doc, sS_doc, sN_doc, sEST)
    End Function

    'Public Function getAsiento(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As String
    '    'Return BOLETADAL.getTxtFc(sT_doc, sS_doc, sN_doc)
    'End Function

#Region "Grabar Datos"
    Public Function SaveRow(ByVal BOLETABE As BOLETABE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return BOLETADAL.SaveRow(BOLETABE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg)
    End Function

    Public Function AsientoFC(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal sNro As String, ByVal sSer As String, ByVal sTipo As String) As String
        Return BOLETADAL.AsientoFC(flagAccion, sAño, sMes, sNro, sSer, sTipo)
    End Function

#End Region
End Class
