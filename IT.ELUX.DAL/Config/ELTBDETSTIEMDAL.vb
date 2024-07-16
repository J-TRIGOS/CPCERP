Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBDETSTIEMDAL
    Inherits BaseDatosORACLE
    Public Function SelectRow(ByVal sCOD As String, ByVal sSER As String, ByVal sNRO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETSTIEM_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", sCOD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER", sSER),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", sNRO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelPrdo(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBSTIEM_SELPRDO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Try
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Return "0"
        End Try

    End Function
    Function gArea(ByVal tlinea As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBSOLMAT_AREA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@TLINEA", Trim(tlinea))})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
