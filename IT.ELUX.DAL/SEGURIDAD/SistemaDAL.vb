Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Namespace Seguridad

    Public Class SistemaDAL
        Inherits BaseDatosORACLE
        Public Function SelectSistemaByUsuCod(ByVal sUsuCod As String) As DataTable
            Dim cmd As New OracleCommand
            Dim dt As New DataTable

            Using dr As OracleDataReader = Me.GetDataReaderNew("PKG_SEGURIDAD.SP_ValidarUsuarioSistema", {New OracleParameter("@STR_USUCOD_", sUsuCod)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt

        End Function
        Public Function SelectMenuByUsuCod(ByVal sUsuCod As String, ByVal sSisCod As String) As DataTable
            Dim cmd As New OracleCommand
            Dim dt As New DataTable

            Using dr As OracleDataReader = Me.GetDataReaderNew("PKG_SEGURIDAD.SP_ValidarUsuarioMenu",
                                                               {
                                                               New OracleParameter("@STR_USUCOD_", sUsuCod),
                                                               New OracleParameter("@STR_SISCOD_", sSisCod)
                                                               })
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt
        End Function

        Public Function SelectSubMenuByUsuCod(ByVal sUsuCod As String, ByVal sSisCod As String, ByVal sPrnCod As String) As DataTable
            Dim cmd As New OracleCommand
            Dim dt As New DataTable

            Using dr As OracleDataReader = Me.GetDataReaderNew("PKG_SEGURIDAD.SP_ValidarUsuarioSubMenu",
                                                               {
                                                               New OracleParameter("@STR_USUCOD_", sUsuCod),
                                                               New OracleParameter("@STR_SISCOD_", sSisCod),
                                                               New OracleParameter("@STR_PRNCOD_", sPrnCod)
                                                               })
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt
        End Function

    End Class

End Namespace
