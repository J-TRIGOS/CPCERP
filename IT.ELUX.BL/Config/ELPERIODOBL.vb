Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELPERIODOBL
    Private ELPERIODODAL As New ELPERIODODAL

    Public Function SelectAll(ByVal Anho As String) As DataTable
        Return ELPERIODODAL.SelectAll(Anho)
    End Function

    Public Function SelectQuinta(ByVal sPRDO As String, ByVal sCPTO As String, ByVal sTPAGO As String) As DataTable
        Return ELPERIODODAL.SelectQuinta(sPRDO, sCPTO, sTPAGO)
    End Function

    Public Function SelUIT() As Double
        Return ELPERIODODAL.SelUIT()
    End Function

    Public Function SaveRow(ByVal ELPERIODOBE As ELPERIODOBE, ByVal flagAccion As String) As String
        Return ELPERIODODAL.SaveRow(ELPERIODOBE, flagAccion)
    End Function

    Public Function SelectMaxPeriodo() As String
        Return ELPERIODODAL.SelectMaxPeriodo()
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELPERIODODAL.SelectRow(sCode)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String) As DataTable
        Return ELPERIODODAL.SelectRowGrid(sCode)
    End Function

    Public Function SelectSuspenCOD(ByVal codigo As String) As DataTable
        Return ELPERIODODAL.SelectSuspenCOD(codigo)
    End Function

    Public Function SelectSuspension() As DataTable
        Return ELPERIODODAL.SelectSuspension()
    End Function

    Public Function SelectPerCOD(ByVal codigo As String) As DataTable
        Return ELPERIODODAL.SelectPerCOD(codigo)
    End Function

    Public Function VerificarRepetido(ByVal anho As String, ByVal mes As String) As Boolean
        Return ELPERIODODAL.VerificarRepetido(anho, mes)
    End Function

    Public Function SelectPeriodoCOD(ByVal anho As String, ByVal codigo As String) As DataTable
        Return ELPERIODODAL.SelectPeriodoCOD(anho, codigo)
    End Function

    Public Function SelectPeriodo(ByVal anho As String) As DataTable
        Return ELPERIODODAL.SelectPeriodo(anho)
    End Function

    Public Function SelectPrdoAct() As DataTable
        Return ELPERIODODAL.SelectPrdoAct()
    End Function

    Public Function SelectPrdoActAll() As DataTable
        Return ELPERIODODAL.SelectPrdoActAll()
        End
    End Function

    Public Function SelectFecPRd(ByVal sCod As String) As String
        Return ELPERIODODAL.SelectFecPRd(sCod)
    End Function
    Public Function SelEstPrdo(ByVal sCod As String) As String
        Return ELPERIODODAL.SelEstPrdo(sCod)
    End Function
    Public Function SelPrdoMonto(ByVal sCod As String) As Double
        Return ELPERIODODAL.SelPrdoMonto(sCod)
    End Function
    Public Function SelPorc1Monto(ByVal sCod As String, ByVal sAnho As String) As Double
        Return ELPERIODODAL.SelPorc1Monto(sCod, sAnho)
    End Function
    Public Function SelPorc2Monto(ByVal sCod As String, ByVal sAnho As String) As Double
        Return ELPERIODODAL.SelPorc2Monto(sCod, sAnho)
    End Function
    Public Function ContarRegistros() As String
        Return ELPERIODODAL.ContarRegistros()
    End Function
    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sUSER As String, ByVal sTipo As String) As String
        Return ELPERIODODAL.SaveRowAllMes(flagAccion, sAño, sUSER, sTipo)
    End Function
    Public Function SaveRowQuinta(ByVal CALCPLABE As CALCPLABE, ByVal flagAccion As String) As String
        Return ELPERIODODAL.SaveRowQuinta(CALCPLABE, flagAccion)
    End Function
End Class

