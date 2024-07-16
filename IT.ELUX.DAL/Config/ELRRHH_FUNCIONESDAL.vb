Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELRRHH_FUNCIONESDAL

    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String

    Public Function SelTurnosOperario(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_TURNO_OPERARIO_MES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelHorasExtras(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_HORAS_EXTRAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelHorasExtrasGeneral(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_GENERAL_HE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelTardanzas(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_TARDANZAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
