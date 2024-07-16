Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBSTURNBL
    Private ELTBSTURNDAL As New ELTBSTURNDAL

    Public Function SelectSer(ByVal sAño As String, ByVal sMes As String) As String
        Return ELTBSTURNDAL.SelectSer(sAño, sMes)
    End Function

    Public Function SelectCCosto() As DataTable
        Return ELTBSTURNDAL.SelectCCosto()
    End Function

    Public Function listcco_cod(ByVal sCod As String) As DataTable
        Return ELTBSTURNDAL.listcco_cod(sCod)
    End Function

    Public Function listgrupo() As DataTable
        Return ELTBSTURNDAL.listgrupo()
    End Function

    Public Function SaveRow(ByVal ELTBSTURNBE As ELTBSTURNBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELTBSTURNDAL.SaveRow(ELTBSTURNBE, flagAccion, dg)
    End Function

    Public Function SelectRow(ByVal sNum As String, ByVal sFini As String, ByVal sTurn As String, ByVal sCcos As String) As DataTable
        Return ELTBSTURNDAL.SelectRow(sNum, sFini, sTurn, sCcos)
    End Function

    Public Function SelectNroSem(ByVal sFec As String) As String
        Return ELTBSTURNDAL.SelectNroSem(sFec)
    End Function
    Public Function SelectVeri(ByVal sVer As String, ByVal sNum As String, ByVal sSer As String) As String
        Return ELTBSTURNDAL.SelectVeri(sVer, sNum, sSer)
    End Function
    'Public Function SearhDocuTurn(ByVal sCCO As String) As DataTable
    '    Return ELTBSTURNDAL.SearhDocuTurn(sCCO)
    'End Function
    Public Function SearhDetTurn(ByVal sNro As String) As DataTable
        Return ELTBSTURNDAL.SearhDetTurn(sNro)
    End Function
    Public Function SearhDocuTurn(ByVal sTipo As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Return ELTBSTURNDAL.SearhDocuTurn(sTipo, sSer, sNro)
    End Function

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBSTURNDAL.SelectAll(sFecAño, sFecMes)
    End Function

    Public Function SelectRow(ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Return ELTBSTURNDAL.SelectRow(sSDoc, sNDoc)
    End Function
End Class
