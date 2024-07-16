Imports IT.ELUX.DAL

Public Class MARCACIONBL

    Private MARCACIONDAL As New MARCACIONDAL
    Public Function registrarAsistencia(ByVal dni As String, ByVal fecha As String, ByVal pc As String, ByVal usuario As String, ByVal tipo As String) As String
        Return MARCACIONDAL.registrarAsistencia(dni, fecha, pc, usuario, tipo)
    End Function

    Public Function VerificarDNI(ByVal dni As String) As DataTable
        Return MARCACIONDAL.VerificarDNI(dni)
    End Function

    Public Function BuscarDNI(ByVal gsuser As String) As DataTable
        Return MARCACIONDAL.BuscarDNI(gsuser)
    End Function
End Class
