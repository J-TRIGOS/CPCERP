
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBSINTOMAS_COVIDBL
    Private ELTBSINTOMAS_COVIDDAL As New ELTBSINTOMAS_COVIDDAL

    Public Function SelectBuscar(ByVal sDni As String) As DataTable
        Return ELTBSINTOMAS_COVIDDAL.SelectBuscar(sDni)
    End Function
    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELTBSINTOMAS_COVIDDAL.SelectAll(Anho, Mes)
    End Function
    Public Function SelectRow(ByVal sTipo As String, ByVal sSer As String, ByVal sNum As String) As DataTable
        Return ELTBSINTOMAS_COVIDDAL.SelectRow(sTipo, sSer, sNum)
    End Function
    Public Function SaveRow(ByVal ELTBSINTOMAS_COVIDBE As ELTBSINTOMAS_COVIDBE, ByVal flagAccion As String) As String
        Return ELTBSINTOMAS_COVIDDAL.SaveRowTwo(ELTBSINTOMAS_COVIDBE, flagAccion)
    End Function
    Public Function Ncont() As String
        Return ELTBSINTOMAS_COVIDDAL.Ncont()
    End Function
End Class
