Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBCAPACITACIONBL
    Private ELTBCAPACITACIONDAL As New ELTBCAPACITACIONDAL

    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Return ELTBCAPACITACIONDAL.SelectNro(sCode, sSer)
    End Function
    Public Function SaveRow(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal flagAccion As String,
                            ByVal dg As DataGridView) As String
        Return ELTBCAPACITACIONDAL.SaveRow(ELTBCAPACITACIONBE, flagAccion, dg)
    End Function
    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELTBCAPACITACIONDAL.SelectAll(Anho, Mes)
    End Function
    Public Function SelectAllTo(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELTBCAPACITACIONDAL.SelectAllTo(Anho, Mes)
    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBCAPACITACIONDAL.SelectRow(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBCAPACITACIONDAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBCAPACITACIONDAL.getListdgv1(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function SelectTema(ByVal sCod As String) As DataTable
        Return ELTBCAPACITACIONDAL.SelectTema(sCod)
    End Function
    Public Function getCapacitacion1() As DataTable
        Return ELTBCAPACITACIONDAL.getCapacitacion1()
    End Function
    Public Function SelectNroCod() As String
        Return ELTBCAPACITACIONDAL.SelectNroCod()
    End Function
    Public Function SaveRows(ByVal ELTBCAPACITACIONBE As ELTBCAPACITACIONBE, ByVal flagAccion As String) As String
        Return ELTBCAPACITACIONDAL.SaveRows(ELTBCAPACITACIONBE, flagAccion)
    End Function
    Public Function list(ByVal sCod As String) As DataTable
        Return ELTBCAPACITACIONDAL.list(sCod)
    End Function
    Public Function SelectApro(ByVal sFec As String) As DataTable
        Return ELTBCAPACITACIONDAL.SelectApro(sFec)
    End Function
    Public Function SelectCCosto() As DataTable
        Return ELTBCAPACITACIONDAL.SelectCCosto()
    End Function
    Public Function SelectReporte() As DataTable
        Return ELTBCAPACITACIONDAL.SelectReporte()
    End Function
End Class
