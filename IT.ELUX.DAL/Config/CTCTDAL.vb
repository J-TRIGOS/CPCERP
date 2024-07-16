Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class CTCTDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sNumero1 As String
    Public Function SelectEmail(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_CTCT_SEL_EMAIL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function SelectVendedor(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_CTCT_SEL_VEN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception

        End Try

    End Function

    Public Function SelectObsPago(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_CTCT_SEL_OBSPAGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception

        End Try

    End Function

    Public Function SelectCTCT(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_CTCT_SEL_NOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            Return dt.Rows(0).Item(0)
        Catch ex As Exception

        End Try

    End Function

    Function SelectDepart() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SELECT_DEPART", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function SelectProv(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SELECT_PROVINCIAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODDEPT", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function SelectDist(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SELECT_DISTRITOS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODPROV", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
