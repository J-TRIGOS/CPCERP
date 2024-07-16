Imports IT.ELUX.Connect
Imports Oracle.ManagedDataAccess.Client

Public Class ELTBFACTURAELDAL
    Inherits BaseDatosORACLE
    Public sDatosFE As String

    Public Function SelectCliente(ByVal sT_DOC_REF As String, ByVal sNRO_DOC_REF As String, ByVal sSER_DOC_REF As String, ByVal sEST As String, ByVal sCTCT_COD As String) As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_FE_CLIENTE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", sT_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", sNRO_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", sSER_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pEST", sEST),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pCTCT_COD", sCTCT_COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectFactura(ByVal sT_DOC_REF As String, ByVal sNRO_DOC_REF As String, ByVal sSER_DOC_REF As String, ByVal sEST As String, ByVal sCTCT_COD As String) As DataTable

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_FE_FACTURA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", sT_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", sNRO_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", sSER_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pEST", sEST),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pCTCT_COD", sCTCT_COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function


    Public Function SelectItems(ByVal sT_DOC_REF As String, ByVal sNRO_DOC_REF As String, ByVal sSER_DOC_REF As String, ByVal sEST As String, ByVal sCTCT_COD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_FE_ITEMS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", sT_DOC_REF),
                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", sNRO_DOC_REF),
                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", sSER_DOC_REF),
                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@pEST", sEST),
                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@pCTCT_COD", sCTCT_COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function

    Public Function SelectSubtotales(ByVal sT_DOC_REF As String, ByVal sNRO_DOC_REF As String, ByVal sSER_DOC_REF As String, ByVal sEST As String, ByVal sCTCT_COD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_FE_SUBTOTALES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", sT_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", sNRO_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", sSER_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pEST", sEST),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pCTCT_COD", sCTCT_COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCufeUpdate(ByVal sT_DOC_REF As String, ByVal sNRO_DOC_REF As String, ByVal sSER_DOC_REF As String, ByVal sEST As String, ByVal sCTCT_COD As String, sCUFE As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_FE_CUFE_UPDATE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", sT_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", sNRO_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", sSER_DOC_REF),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pEST", sEST),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pCTCT_COD", sCTCT_COD),
                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@pCUFE", sCUFE)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

End Class


