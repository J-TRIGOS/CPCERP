Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBCONCEPTOSBL
    Private ELTBCONCEPTOSDAL As New ELTBCONCEPTOSDAL

    Public Function SelectAll() As DataTable
        Return ELTBCONCEPTOSDAL.SelectAll()
    End Function

    Public Function SelectMaxTransp() As String
        Return ELTBCONCEPTOSDAL.SelectMaxTransp()
    End Function

    Public Function SaveRow(ByVal ELTBCONCEPTOSBE As ELTBCONCEPTOSBE, ByVal flagAccion As String) As String
        Return ELTBCONCEPTOSDAL.SaveRow(ELTBCONCEPTOSBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBCONCEPTOSDAL.SelectRow(sCode)
    End Function
    Public Function VerificarRegistro() As DataTable
        Return ELTBCONCEPTOSDAL.VerificarRegistro()
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Return ELTBCONCEPTOSDAL.SelectRowGrid(sCode, sOpcion)
    End Function
    Public Function SelectTipoConceCOD(ByVal Anio As String) As DataTable
        Return ELTBCONCEPTOSDAL.SelectTipoConceCOD(Anio)
    End Function
    Public Function Select_TipoConcepto() As DataTable
        Return ELTBCONCEPTOSDAL.Select_TipoConcepto()
    End Function

    Public Function SelectConceptoCOD(ByVal Anio As String) As DataTable
        Return ELTBCONCEPTOSDAL.SelectConceptoCOD(Anio)
    End Function
    Public Function Select_Concepto() As DataTable
        Return ELTBCONCEPTOSDAL.Select_Concepto()
    End Function
    Public Function VerificarRepetido(ByVal tipo As String, ByVal doc As String, ByVal afecto As String, ByVal importe As String) As Boolean
        Return ELTBCONCEPTOSDAL.VerificarRepetido(tipo, doc, afecto, importe)
    End Function
    Public Function SelectCta(ByVal codigo As String) As DataTable
        Return ELTBCONCEPTOSDAL.SelectCta(codigo)
    End Function
    Public Function SelectTipImpto() As DataTable
        Return ELTBCONCEPTOSDAL.SelectTipImpto()
    End Function
    Public Function SelectCtaCodigo(ByVal anho As String, ByVal cod As String) As DataTable
        Return ELTBCONCEPTOSDAL.SelectCtaCodigo(anho, cod)
    End Function
    Public Function SelectTipImptoCOD(ByVal codigo As String) As DataTable
        Return ELTBCONCEPTOSDAL.SelectTipImptoCOD(codigo)
    End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String) As Boolean
        Return ELTBCONCEPTOSDAL.VerificarRepetido(Code, Code2)
    End Function
End Class

