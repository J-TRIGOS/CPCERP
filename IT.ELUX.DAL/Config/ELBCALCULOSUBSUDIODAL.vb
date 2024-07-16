Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect


Public Class ELBCALCULOSUBSUDIODAL
    Inherits BaseDatosORACLE
    Public Function CalculoSubsidio(ByVal cod As String, ByVal periodo As Int16, ByVal fechaIni As String, ByVal fechaFin As String, ByVal ListaPeriodos As ELPERIODOS) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CALCULO_SUBSIDIO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pPRDO1", periodo),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pPER1", cod),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pFECHAINI", fechaIni),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pFECHAFIN", fechaFin),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES1", ListaPeriodos.MES1),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES2", ListaPeriodos.MES2),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES3", ListaPeriodos.MES3),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES4", ListaPeriodos.MES4),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES5", ListaPeriodos.MES5),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES6", ListaPeriodos.MES6),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES7", ListaPeriodos.MES7),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES8", ListaPeriodos.MES8),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES9", ListaPeriodos.MES9),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES10", ListaPeriodos.MES10),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES11", ListaPeriodos.MES11),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES12", ListaPeriodos.MES12)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function CalculoIngresos(ByVal cod As String, ByVal periodo As Int16, ByVal fechaIni As String, ByVal fechaFin As String, ByVal ListaPeriodos As ELPERIODOS) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_INGRESOS_MENSUALES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pPRDO1", periodo),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pPER1", cod),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pFECHAINI", fechaIni),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@pFECHAFIN", fechaFin),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES1", ListaPeriodos.MES1),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES2", ListaPeriodos.MES2),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES3", ListaPeriodos.MES3),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES4", ListaPeriodos.MES4),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES5", ListaPeriodos.MES5),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES6", ListaPeriodos.MES6),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES7", ListaPeriodos.MES7),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES8", ListaPeriodos.MES8),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES9", ListaPeriodos.MES9),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES10", ListaPeriodos.MES10),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES11", ListaPeriodos.MES11),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@MES12", ListaPeriodos.MES12)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function CalculoPeriodos(ByVal periodo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERIODOS_SUBSIDIO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pPRDO1", periodo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarPeriodo(ByVal fecha As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_PERIODO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pPRDO1", fecha)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ListaPeriodos(ByVal periodo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LISTAR_PERIODO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pPRDO1", periodo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
