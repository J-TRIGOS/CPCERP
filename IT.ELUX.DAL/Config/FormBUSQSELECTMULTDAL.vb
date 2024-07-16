Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class FormBUSQSELECTMULTDAL
    Inherits BaseDatosORACLE
    Function list1Fardo(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal nfardo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETGUIA_SEARCH1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@FARDO", Trim(nfardo))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function
    Function list2Fardo(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal nart As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETGUIA_SEARCH2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@COD_ART", Trim(nart))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function
End Class
