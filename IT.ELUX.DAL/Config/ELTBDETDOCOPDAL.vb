Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBDETDOCOPDAL
    Inherits BaseDatosORACLE
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sART As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETDOCOP_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sART", sART)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function BuscarOP(ByVal anho As String, ByVal articulo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBPRODUCCION_BUSCOP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                    New Oracle.ManagedDataAccess.Client.OracleParameter("@ARTICULO", articulo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarTCSBS(ByVal fecha As String, ByVal operacion As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        If operacion = "010" Or operacion = "099" Then
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_TC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FECHA", fecha)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
        ElseIf operacion = "013" Or operacion = "099" Then
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_TC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@FECHA", fecha)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
        End If

        Return dt
    End Function
    Public Function SaveRow(ByVal ELTBDETDOCOPBE As ELTBDETDOCOPBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(ELTBDETDOCOPBE, cn, sqlTrans, dg)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBDETDOCOPBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "A" Then
                DeleteUpdateRow(ELTBDETDOCOPBE, cn, sqlTrans, dg)
            End If
            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            'If resultado = "OK" Then
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Private Sub InsertRow(ByVal ELTBDETDOCOPBE As ELTBDETDOCOPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETDOCOP_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETDOCOPBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("t_doc_ref").Value)), "", RTrim(row.Cells("t_doc_ref").Value))
            ELTBDETDOCOPBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBDETDOCOPBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBDETDOCOPBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETDOCOPBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETDOCOPBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETDOCOPBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBDETDOCOPBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.T_DOC_REF
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.SER_DOC_REF
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.NRO_DOC_REF
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.T_DOC_REF1
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.SER_DOC_REF1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.ART_COD
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELTBDETDOCOPBE.CANTIDAD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub
    Private Sub UpdateRow(ByVal ELTBDETDOCOPBE As ELTBDETDOCOPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETDOCOP_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETDOCOP_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBDETDOCOPBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            ELTBDETDOCOPBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            ELTBDETDOCOPBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            ELTBDETDOCOPBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETDOCOPBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETDOCOPBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETDOCOPBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            ELTBDETDOCOPBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.T_DOC_REF
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.SER_DOC_REF
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.NRO_DOC_REF
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.T_DOC_REF1
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.SER_DOC_REF1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.ART_COD
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELTBDETDOCOPBE.CANTIDAD
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Private Sub DeleteUpdateRow(ByVal ELTBDETDOCOPBE As ELTBDETDOCOPBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                     ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETDOCOP_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETDOCOPBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function BuscarActFLujo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_ACTFLUJO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarActFLujoCaja(ByVal cod As String, ByVal ope As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_ACTFLUJOCAJA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@mCOD", cod),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mOPE", ope)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
