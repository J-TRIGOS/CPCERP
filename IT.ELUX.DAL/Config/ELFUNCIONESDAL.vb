Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELFUNCIONESDAL
    Inherits BaseDatosORACLE
    Public Function SelectNomColumn(ByVal sNom As String) As DataTable
        'sDim resultado As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBHEADERS_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pHDR_CAMPO", sNom)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
