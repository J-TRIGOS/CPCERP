Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class REGCONTDAL
    Inherits BaseDatosORACLE

    Public Function BuscarRegistroContable(ByVal anho As String, ByVal mes As String, ByVal ope As String, ByVal pref As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_OBTENER_NRO_REGCON", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MOPE", ope),
                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@MPREF", pref)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
