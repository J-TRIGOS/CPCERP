Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELRRHH_FUNCIONES

    Private ELRRHH_FUNCIONESDAL As New ELRRHH_FUNCIONESDAL

    Public Function SelTurnosOperario(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELRRHH_FUNCIONESDAL.SelTurnosOperario(anho, mes)
    End Function

    Public Function SelHorasExtras(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELRRHH_FUNCIONESDAL.SelHorasExtras(anho, mes)
    End Function

    Public Function SelHorasExtrasGeneral(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELRRHH_FUNCIONESDAL.SelHorasExtrasGeneral(anho, mes)
    End Function

    Public Function SelTardanzas(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELRRHH_FUNCIONESDAL.SelTardanzas(anho, mes)
    End Function
End Class

