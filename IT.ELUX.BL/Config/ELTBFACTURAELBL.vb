Imports IT.ELUX.DAL
Public Class ELTBFACTURAELBL
    Private ELTBFACTURAELDAL As New ELTBFACTURAELDAL

    Public Function SelectCliente(ByVal sT_DOC_REF As String, ByVal sNRO_DOC_REF As String, ByVal sSER_DOC_REF As String, ByVal sEST As String, ByVal sCTCT_COD As String) As DataTable
        Return ELTBFACTURAELDAL.SelectCliente(sT_DOC_REF, sNRO_DOC_REF, sSER_DOC_REF, sEST, sCTCT_COD)
    End Function

    Public Function SelectFactura(ByVal sT_DOC_REF As String, ByVal sNRO_DOC_REF As String, ByVal sSER_DOC_REF As String, ByVal sEST As String, ByVal sCTCT_COD As String) As DataTable
        Return ELTBFACTURAELDAL.SelectFactura(sT_DOC_REF, sNRO_DOC_REF, sSER_DOC_REF, sEST, sCTCT_COD)
    End Function


    Public Function SelectItems(ByVal sT_DOC_REF As String, ByVal sNRO_DOC_REF As String, ByVal sSER_DOC_REF As String, ByVal sEST As String, ByVal sCTCT_COD As String) As DataTable
        Return ELTBFACTURAELDAL.SelectItems(sT_DOC_REF, sNRO_DOC_REF, sSER_DOC_REF, sEST, sCTCT_COD)
    End Function

    Public Function SelectSubtotales(ByVal sT_DOC_REF As String, ByVal sNRO_DOC_REF As String, ByVal sSER_DOC_REF As String, ByVal sEST As String, ByVal sCTCT_COD As String) As DataTable
        Return ELTBFACTURAELDAL.SelectSubtotales(sT_DOC_REF, sNRO_DOC_REF, sSER_DOC_REF, sEST, sCTCT_COD)
    End Function
    Public Function SelectCufeUpdate(ByVal sT_DOC_REF As String, ByVal sNRO_DOC_REF As String, ByVal sSER_DOC_REF As String, ByVal sEST As String, ByVal sCTCT_COD As String, ByVal sCUFE As String) As DataTable
        Return ELTBFACTURAELDAL.SelectCufeUpdate(sT_DOC_REF, sNRO_DOC_REF, sSER_DOC_REF, sEST, sCTCT_COD, sCUFE)
    End Function


End Class
