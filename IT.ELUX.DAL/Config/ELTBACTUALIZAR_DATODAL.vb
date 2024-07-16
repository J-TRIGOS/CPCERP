Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBACTUALIZAR_DATODAL
    Inherits BaseDatosORACLE
    Public Function SelectArt(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PRODUCCION_RP_SELART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", sTdoc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser", sSer),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectArtRein(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBREINPRO2020_SELART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", sTdoc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser", sSer),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectArtFall(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBFALLPRO2020_SELART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", sTdoc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser", sSer),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowPro(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String, ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PRODUCCION_RP_DOCU", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", sTdoc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser", sSer),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", sNro),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@art", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowRein(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String, ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBREINPRO2020_DOCU", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", sTdoc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser", sSer),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", sNro),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@art", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowFall(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String, ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBFALLPRO2020_DOCU", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", sTdoc),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser", sSer),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", sNro),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@art", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function UpdRowDoc(ByVal ELTBACTUALIZAR_DATOSBE As ELTBACTUALIZAR_DATOSBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction
        Try
            If flagAccion = "MPRO" Then
                UpdDoc(ELTBACTUALIZAR_DATOSBE, cn, sqlTrans)
            End If
            If flagAccion = "MREIN" Then
                UpdDocRein(ELTBACTUALIZAR_DATOSBE, cn, sqlTrans)
            End If
            If flagAccion = "MFAL" Then
                UpdDocFal(ELTBACTUALIZAR_DATOSBE, cn, sqlTrans)
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
            sqlTrans = Nothing
        End Try
        Return resultado
    End Function

    Private Sub UpdDoc(ByVal ELTBACTUALIZAR_DATOSBE As ELTBACTUALIZAR_DATOSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                        ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PRODUCCION_RP_UPDATE_DOC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("t_doc_ref", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.T_DOC_REF '1
        cmd.Parameters.Add("ser_doc_ref", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.SER_DOC_REF '2
        cmd.Parameters.Add("nro_doc_ref", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.NRO_DOC_REF '3 
        cmd.Parameters.Add("art_cod", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.ART_COD ' 4
        cmd.Parameters.Add("ser_orden", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.SER_ORDEN '5
        cmd.Parameters.Add("nro_orden", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.NRO_ORDEN '6
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub UpdDocRein(ByVal ELTBACTUALIZAR_DATOSBE As ELTBACTUALIZAR_DATOSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                    ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBREINPRO2020_UPDATE_DOC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("t_doc_ref", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.T_DOC_REF '1
        cmd.Parameters.Add("ser_doc_ref", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.SER_DOC_REF '2
        cmd.Parameters.Add("nro_doc_ref", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.NRO_DOC_REF '3 
        cmd.Parameters.Add("art_cod", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.ART_COD ' 4
        cmd.Parameters.Add("ser_orden", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.SER_ORDEN '5
        cmd.Parameters.Add("nro_orden", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.NRO_ORDEN '6
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UpdDocFal(ByVal ELTBACTUALIZAR_DATOSBE As ELTBACTUALIZAR_DATOSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                   ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBFALLPRO2020_UPDATE_DOC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("t_doc_ref", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.T_DOC_REF '1
        cmd.Parameters.Add("ser_doc_ref", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.SER_DOC_REF '2
        cmd.Parameters.Add("nro_doc_ref", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.NRO_DOC_REF '3 
        cmd.Parameters.Add("art_cod", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.ART_COD ' 4
        cmd.Parameters.Add("ser_orden", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.SER_ORDEN '5
        cmd.Parameters.Add("nro_orden", OracleDbType.Varchar2).Value = ELTBACTUALIZAR_DATOSBE.NRO_ORDEN '6
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
End Class
