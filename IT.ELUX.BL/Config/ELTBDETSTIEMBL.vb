Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBDETSTIEMBL
    Private ELTBDETSTIEMDAL As New ELTBDETSTIEMDAL
    Public Function SelectRow(ByVal sCOD As String, ByVal sSER As String, ByVal sNRO As String) As DataTable
        Return ELTBDETSTIEMDAL.SelectRow(sCOD, sSER, sNRO)
    End Function
    Public Function SelPrdo(ByVal sCode As String) As String
        Return ELTBDETSTIEMDAL.SelPrdo(sCode)
    End Function
    Public Function gArea(ByVal tlinea As String)
        Return ELTBDETSTIEMDAL.gArea(tlinea)
    End Function
End Class