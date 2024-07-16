Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBDETRACCIONDAL
    Inherits BaseDatosORACLE
    Public sNumero As String
    Public sPrueba As String
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETRACCION_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETRACCION_SEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBDETDETRACCION_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal sProv As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARHDET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@Prov", Trim(sProv))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sCOD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELDET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sCOD", sCOD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETRACCION_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero
    End Function
    Public Function getTxtDet(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETDETRACCION_TXT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sT_doc)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sN_doc)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", Trim(sS_doc))})
            While dr.Read
                sPrueba = dr.GetString(0)
            End While
        End Using
        Return sPrueba
    End Function
    Public Function getTxtDet1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBDETDETRACCION_TXTVIR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sT_doc)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sN_doc)),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@pNRO_DOC_REF", Trim(sS_doc))})
            While dr.Read
                sPrueba = dr.GetString(0)
            End While
        End Using
        Return sPrueba
    End Function
    Public Function SaveRow(ByVal ELTBDETRACCIONBE As ELTBDETRACCIONBE, ByVal ELTBDETDETRACCIONBE As ELTBDETDETRACCIONBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(ELTBDETRACCIONBE, ELTBDETDETRACCIONBE, cn, sqlTrans, ELMVLOGSBE, dg)
                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBDETRACCIONBE, ELTBDETDETRACCIONBE, cn, sqlTrans, ELMVLOGSBE, dg)
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
    Private Sub InsertRow(ByVal ELTBDETRACCIONBE As ELTBDETRACCIONBE, ByVal ELTBDETDETRACCIONBE As ELTBDETDETRACCIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETRACCION_INSROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.NRO_DOC_REF
        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBDETRACCIONBE.FEC_GENE
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.EST
        cmd.Parameters.Add("@FEC_ANU", OracleDbType.Date).Value = ELTBDETRACCIONBE.FEC_ANU

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETDETRACCION_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELTBDETDETRACCIONBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETDETRACCIONBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETDETRACCIONBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETDETRACCIONBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ELTBDETDETRACCIONBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            ELTBDETDETRACCIONBE.MONTO_PAGADO = IIf(IsDBNull(RTrim(row.Cells("MONTO_PAGADO").Value)), 0, RTrim(row.Cells("MONTO_PAGADO").Value))
            ELTBDETDETRACCIONBE.PORC = IIf(IsDBNull(RTrim(row.Cells("PORC").Value)), 0, RTrim(row.Cells("PORC").Value))
            ELTBDETDETRACCIONBE.SERV = IIf(IsDBNull(RTrim(row.Cells("SERV").Value)), 0, RTrim(row.Cells("SERV").Value))
            ELTBDETDETRACCIONBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA").Value)), 0, RTrim(row.Cells("CUENTA").Value))
            ELTBDETDETRACCIONBE.T_OPE = IIf(IsDBNull(RTrim(row.Cells("T_OPE").Value)), 0, RTrim(row.Cells("T_OPE").Value))
            ELTBDETDETRACCIONBE.TOTAL = IIf(IsDBNull(RTrim(row.Cells("TOTAL").Value)), 0, RTrim(row.Cells("TOTAL").Value))

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.NRO_DOC_REF1
            cmd.Parameters.Add("@CTCT", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.PROVEEDOR
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBDETDETRACCIONBE.FEC_GENE
            cmd.Parameters.Add("@MONTO_PAGADO", OracleDbType.Double).Value = ELTBDETDETRACCIONBE.MONTO_PAGADO
            cmd.Parameters.Add("@PORC", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.PORC
            cmd.Parameters.Add("@SERV", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.SERV
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.CUENTA
            cmd.Parameters.Add("@TOTAL", OracleDbType.Double).Value = ELTBDETDETRACCIONBE.TOTAL
            cmd.Parameters.Add("@T_OPE", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.T_OPE
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso la siguiente detraccion: " + ELTBDETRACCIONBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELTBDETRACCIONBE As ELTBDETRACCIONBE, ByVal ELTBDETDETRACCIONBE As ELTBDETDETRACCIONBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETRACCION_UPDROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.T_DOC_REF
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.NRO_DOC_REF
        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBDETRACCIONBE.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBDETDETRACCION_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.T_DOC_REF
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.SER_DOC_REF
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBDETDETRACCION_INSROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELTBDETDETRACCIONBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            ELTBDETDETRACCIONBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            ELTBDETDETRACCIONBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            ELTBDETDETRACCIONBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))
            ELTBDETDETRACCIONBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value))
            ELTBDETDETRACCIONBE.MONTO_PAGADO = IIf(IsDBNull(RTrim(row.Cells("MONTO_PAGADO").Value)), 0, RTrim(row.Cells("MONTO_PAGADO").Value))
            ELTBDETDETRACCIONBE.PORC = IIf(IsDBNull(RTrim(row.Cells("PORC").Value)), 0, RTrim(row.Cells("PORC").Value))
            ELTBDETDETRACCIONBE.SERV = IIf(IsDBNull(RTrim(row.Cells("SERV").Value)), 0, RTrim(row.Cells("SERV").Value))
            ELTBDETDETRACCIONBE.T_OPE = IIf(IsDBNull(RTrim(row.Cells("T_OPE").Value)), 0, RTrim(row.Cells("T_OPE").Value))
            ELTBDETDETRACCIONBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA").Value)), 0, RTrim(row.Cells("CUENTA").Value))
            ELTBDETDETRACCIONBE.TOTAL = IIf(IsDBNull(RTrim(row.Cells("TOTAL").Value)), 0, RTrim(row.Cells("TOTAL").Value))

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBDETRACCIONBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.NRO_DOC_REF1
            cmd.Parameters.Add("@CTCT", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.PROVEEDOR
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBDETDETRACCIONBE.FEC_GENE
            cmd.Parameters.Add("@MONTO_PAGADO", OracleDbType.Double).Value = ELTBDETDETRACCIONBE.MONTO_PAGADO
            cmd.Parameters.Add("@PORC", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.PORC
            cmd.Parameters.Add("@SERV", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.SERV
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.CUENTA
            cmd.Parameters.Add("@TOTAL", OracleDbType.Double).Value = ELTBDETDETRACCIONBE.TOTAL
            cmd.Parameters.Add("@T_OPE", OracleDbType.Varchar2).Value = ELTBDETDETRACCIONBE.T_OPE
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo detraccion: " + ELTBDETRACCIONBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
End Class
