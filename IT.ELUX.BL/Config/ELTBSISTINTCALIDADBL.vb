Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBSISTINTCALIDADBL
    Private ELTBSISTINTCALIDADDAL As New ELTBSISTINTCALIDADDAL
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBSISTINTCALIDADDAL.SelectRow(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Return ELTBSISTINTCALIDADDAL.SelectNro(sCode, sSer)
    End Function
    Public Function SelectCodif() As DataTable
        Return ELTBSISTINTCALIDADDAL.SelectCodif()
    End Function
    Public Function SaveRow(ByVal ELTBSISTINTCALIDADBE As ELTBSISTINTCALIDADBE, ByVal flagAccion As String) As String
        Return ELTBSISTINTCALIDADDAL.SaveRow(ELTBSISTINTCALIDADBE, flagAccion)
    End Function
    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBSISTINTCALIDADDAL.SelectAll(sFecAño, sFecMes)
    End Function
End Class
