Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class DETALLE_DOCUMENTODAL
    Inherits BaseDatosORACLE
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sA_cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETALLE_DOCUMENTO_SEL_PD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ART_COD", sA_cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
End Class
