Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class UBICACIONBL

    Dim UBICACIONDAL As New UBICACIONDAL
    Public Function VerificarCodPiso(ByVal codAlm As String) As DataTable
        Return UBICACIONDAL.VerificarCodPiso(codAlm)
    End Function
    Public Function ObtenerDataPisos(ByVal codAlm As String) As DataTable
        Return UBICACIONDAL.ObtenerDataPisos(codAlm)
    End Function
    Public Function SelectDataPisos(ByVal codAlm As String) As DataTable
        Return UBICACIONDAL.SelectDataPisos(codAlm)
    End Function
    Public Function SaveRow(ByVal codUbi As String, ByVal codAlm As String, ByVal codPiso As String, ByVal nomPiso As String, ByVal flagaccion As String) As String
        Return UBICACIONDAL.SaveRow(codUbi, codAlm, codPiso, nomPiso, flagaccion)
    End Function

    Public Function VerificarAlmPiso(ByVal codAlm As String, ByVal codPiso As String) As DataTable
        Return UBICACIONDAL.VerificarAlmPiso(codAlm, codPiso)
    End Function

    Public Function ObtenerDatosUbicacion(ByVal codAlm As String, ByVal codPiso As String) As DataTable
        Return UBICACIONDAL.ObtenerDatosUbicacion(codAlm, codPiso)
    End Function
End Class
