Imports IT.ELUX.BE
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBORDENPROGRAMADAL
    Inherits BaseDatosORACLE

    Function SelectNro(ByVal sTipo As String, ByVal sSer As String, ByVal sNum As String, ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBCONTROL_SELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Tipo", sTipo), 'SP_ARTICULO_SUBLINES
                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSer),
                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@Num", sNum),
                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@Art", sArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function SelectSearch(ByVal sForm As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBCONTROL_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Tipo", sForm)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBCONTROL_FORMATO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal ELTBORDENPROGRAMABE As ELTBORDENPROGRAMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(ELTBORDENPROGRAMABE, ELMVLOGSBE, cn, sqlTrans)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELTBORDENPROGRAMABE, ELMVLOGSBE, cn, sqlTrans)
            End If
            If flagAccion = "A" Then
                'UpdateRowAnular(ELTBORDENPROGRAMABE, ELMVLOGSBE, cn, sqlTrans)
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
            If resultado = "OK" Then
                'If flagAccion <> "AC" And flagAccion <> "DE" Then
                'cn.Dispose()
                'End If

            End If
            sqlTrans = Nothing
        End Try

        Return resultado
    End Function

    Private Sub InsertRow(ByVal ELTBORDENPROGRAMABE As ELTBORDENPROGRAMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCONTROL_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.T_DOC_REF       '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.SER_DOC_REF   '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.NRO_DOC_REF   '3
        cmd.Parameters.Add("@formato", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.FORMATO           '4
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.ART_COD           '5
        cmd.Parameters.Add("@descri", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.DESCRI             '6

        cmd.Parameters.Add("@ESP_CUE", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ESP_CUE             '7

        cmd.Parameters.Add("@ESP_FON", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ESP_FON             '8
        cmd.Parameters.Add("@ALT_CIE_F_MN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_CIE_F_MN   '9
        cmd.Parameters.Add("@ALT_CIE_F_MX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_CIE_F_MX   '10
        cmd.Parameters.Add("@LON_CUE_F_MN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_CUE_F_MN   '11
        cmd.Parameters.Add("@LON_CUE_F_MX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_CUE_F_MX   '12
        cmd.Parameters.Add("@LON_FON_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_FON_MIN     '13
        cmd.Parameters.Add("@LON_FON_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_FON_MAX     '14

        cmd.Parameters.Add("@ESP_ANI", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ESP_ANI             '15
        cmd.Parameters.Add("@ALT_CIE_A_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_CIE_A_MIN '16
        cmd.Parameters.Add("@ALT_CIE_A_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_CIE_A_MAX '17
        cmd.Parameters.Add("@LON_CUE_A_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_CUE_A_MIN '18
        cmd.Parameters.Add("@LON_CUE_A_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_CUE_A_MAX '19
        cmd.Parameters.Add("@LON_ANI_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_ANI_MIN     '20
        cmd.Parameters.Add("@LON_ANI_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_ANI_MAX     '21

        cmd.Parameters.Add("@ALT_TER_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_TER_MIN     '22
        cmd.Parameters.Add("@ALT_TER_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_TER_MAX     '23
        cmd.Parameters.Add("@ALT_ORE_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_ORE_MIN     '24
        cmd.Parameters.Add("@ALT_ORE_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_ORE_MAX     '25
        cmd.Parameters.Add("@ENV_TER_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ENV_TER_MIN     '26
        cmd.Parameters.Add("@ENV_TER_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ENV_TER_MAX     '27
        cmd.Parameters.Add("@CUE_TAP_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.CUE_TAP_MIN     '28
        cmd.Parameters.Add("@CUE_TAP_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.CUE_TAP_MAX     '29

        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBORDENPROGRAMABE.FEC_GENE             '30
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.EST                   '31

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELTBORDENPROGRAMABE As ELTBORDENPROGRAMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCONTROL_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.T_DOC_REF       '1
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.SER_DOC_REF   '2
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.NRO_DOC_REF   '3
        cmd.Parameters.Add("@formato", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.FORMATO           '4
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.ART_COD           '5
        cmd.Parameters.Add("@descri", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.DESCRI             '6

        cmd.Parameters.Add("@ESP_CUE", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ESP_CUE             '7

        cmd.Parameters.Add("@ESP_FON", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ESP_FON             '8
        cmd.Parameters.Add("@ALT_CIE_F_MN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_CIE_F_MN   '9
        cmd.Parameters.Add("@ALT_CIE_F_MX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_CIE_F_MX   '10
        cmd.Parameters.Add("@LON_CUE_F_MN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_CUE_F_MN   '11
        cmd.Parameters.Add("@LON_CUE_F_MX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_CUE_F_MX   '12
        cmd.Parameters.Add("@LON_FON_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_FON_MIN     '13
        cmd.Parameters.Add("@LON_FON_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_FON_MAX     '14

        cmd.Parameters.Add("@ESP_ANI", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ESP_ANI             '15
        cmd.Parameters.Add("@ALT_CIE_A_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_CIE_A_MIN '16
        cmd.Parameters.Add("@ALT_CIE_A_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_CIE_A_MAX '17
        cmd.Parameters.Add("@LON_CUE_A_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_CUE_A_MIN '18
        cmd.Parameters.Add("@LON_CUE_A_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_CUE_A_MAX '19
        cmd.Parameters.Add("@LON_ANI_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_ANI_MIN     '20
        cmd.Parameters.Add("@LON_ANI_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.LON_ANI_MAX     '21

        cmd.Parameters.Add("@ALT_TER_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_TER_MIN     '22
        cmd.Parameters.Add("@ALT_TER_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_TER_MAX     '23
        cmd.Parameters.Add("@ALT_ORE_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_ORE_MIN     '24
        cmd.Parameters.Add("@ALT_ORE_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ALT_ORE_MAX     '25
        cmd.Parameters.Add("@ENV_TER_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ENV_TER_MIN     '26
        cmd.Parameters.Add("@ENV_TER_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.ENV_TER_MAX     '27
        cmd.Parameters.Add("@CUE_TAP_MIN", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.CUE_TAP_MIN     '28
        cmd.Parameters.Add("@CUE_TAP_MAX", OracleDbType.Double).Value = ELTBORDENPROGRAMABE.CUE_TAP_MAX     '29

        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBORDENPROGRAMABE.FEC_GENE             '30
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBORDENPROGRAMABE.EST                   '31

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

End Class
