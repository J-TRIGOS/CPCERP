Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBACTUALIZAR_DATOSBL
    Private ELTBACTUALIZAR_DATODAL As New ELTBACTUALIZAR_DATODAL
    Public Function SelectArt(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Return ELTBACTUALIZAR_DATODAL.SelectArt(sTdoc, sSer, sNro)
    End Function
    Public Function SelectArtRein(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Return ELTBACTUALIZAR_DATODAL.SelectArtRein(sTdoc, sSer, sNro)
    End Function
    Public Function SelectArtFall(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Return ELTBACTUALIZAR_DATODAL.SelectArtFall(sTdoc, sSer, sNro)
    End Function

    Public Function SelectRowPro(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String, ByVal sCod As String) As DataTable
        Return ELTBACTUALIZAR_DATODAL.SelectRowPro(sTdoc, sSer, sNro, sCod)
    End Function
    Public Function SelectRowRein(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String, ByVal sCod As String) As DataTable
        Return ELTBACTUALIZAR_DATODAL.SelectRowRein(sTdoc, sSer, sNro, sCod)
    End Function
    Public Function SelectRowFall(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String, ByVal sCod As String) As DataTable
        Return ELTBACTUALIZAR_DATODAL.SelectRowFall(sTdoc, sSer, sNro, sCod)
    End Function

    Public Function UpdRowDoc(ByVal ELTBACTUALIZAR_DATOSBE As ELTBACTUALIZAR_DATOSBE, ByVal flagAccion As String) As String
        Return ELTBACTUALIZAR_DATODAL.UpdRowDoc(ELTBACTUALIZAR_DATOSBE, flagAccion)
    End Function
End Class
