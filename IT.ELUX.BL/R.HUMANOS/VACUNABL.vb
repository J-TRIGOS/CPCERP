Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.DAL

Public Class VACUNABL
    Dim VACUNADAL As New VACUNADAL
    Public Function ListadoVacunados() As DataTable
        Dim dtListadoVacuna As New DataTable
        dtListadoVacuna = VACUNADAL.ListadoVacunados()
        Return dtListadoVacuna
    End Function

    Public Function ListadoNoVacunados() As DataTable
        Dim dtListadoVacuna As New DataTable
        dtListadoVacuna = VACUNADAL.ListadoNoVacunados()
        Return dtListadoVacuna
    End Function

    Public Function BuscarPersonalActivo() As DataTable
        Dim dtListadoVacuna As New DataTable
        dtListadoVacuna = VACUNADAL.BuscarPersonalActivo()
        Return dtListadoVacuna
    End Function

    Public Function ListadoVacuna(ByVal codigo As String) As DataTable
        Dim dtListadoVacuna As New DataTable
        dtListadoVacuna = VACUNADAL.ListadoVacuna(codigo)
        Return dtListadoVacuna
    End Function

    Public Function grabarDatos(ByVal vacunabe As VACUNABE, ByVal flagAccion As String) As String
        Return VACUNADAL.grabarDatos(vacunabe, flagAccion)
    End Function
End Class
