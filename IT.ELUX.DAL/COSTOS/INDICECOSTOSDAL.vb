Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class INDICECOSTOSDAL

    Inherits BaseDatosORACLE

    Public Function registrarArticulo(ByVal codigo As String, ByVal art As String, ByVal anho As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            registrarArticulo(codigo, art, anho, cn, sqlTrans)
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

    Private Sub registrarArticulo(ByVal codigo As String, ByVal art As String, ByVal anho As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REG_ARTICULO_INDCOSTOS"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@CODIGO", OracleDbType.NVarchar2).Value = codigo
        cmd.Parameters.Add("@ARTICULO", OracleDbType.NVarchar2).Value = art
        cmd.Parameters.Add("@MANHO", OracleDbType.NVarchar2).Value = anho
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub


    Public Function RegistrarIndiceCostos(ByVal i As String, ByVal mesAct As String, ByVal mesAnt As String, ByVal codigo As String, ByVal anho As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            InsertIndiceCostos(i, mesAct, mesAnt, codigo, anho, cn, sqlTrans)
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

    Public Sub InsertIndiceCostos(ByVal i As String, ByVal mesAct As String, ByVal mesAnt As String, ByVal codigo As String, ByVal anho As String,
                                         ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'SALDO INICIAL
        If mesAct = "MES01" Then
            cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                              "SET " & mesAct & " = (SELECT NVL(SUM(STK_STKINI01),0) FROM EL_TBARTSTOCK_" & anho & " WHERE STK_CODART = '" & codigo & "') " &
                              "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '001' AND T_REPORTE = 'R1' "
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                               "SET " & mesAct & " = (SELECT " & mesAnt & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '006'  AND T_REPORTE = 'R1' ) " &
                               "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '001' AND T_REPORTE = 'R1' "
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'CANTIDAD COMPRADA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                          "SET " & mesAct & " = (SELECT NVL(SUM(MOV_CANTID),0) " &
                                                "FROM ELMVALMA_" & anho & " " &
                                                "WHERE MOV_CODART = '" & codigo & "' AND MOV_TIPO_TRANS = 'E' AND MOV_ESTADO <> 'A' AND TO_CHAR(MOV_FECEMI, 'MM') = " & i & " AND TO_CHAR(MOV_FECEMI, 'YYYY') = '" & anho & "' AND MOV_CODTRA = 'E19') " &
                          "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '002'  AND T_REPORTE = 'R1' "
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'CANTIDAD COMPRADA ACUMULADA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        If mesAct = "MES01" Then
            cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                              "SET " & mesAct & " = (SELECT NVL(" & mesAct & ",0) FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '002' AND T_REPORTE = 'R1' ) " &
                              "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '003' AND T_REPORTE = 'R1' "
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                              "SET " & mesAct & " =(SELECT (SELECT NVL(" & mesAnt & ",0) FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '003' AND T_REPORTE = 'R1' ) + " &
                                                   "(SELECT NVL(" & mesAct & ",0) FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '002' AND T_REPORTE = 'R1' ) FROM DUAL)" &
                              "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '003'  AND T_REPORTE = 'R1' "
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'CANTIDAD CONSUMIDA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                          "SET " & mesAct & " = ( SELECT ( " &
                                                    "(SELECT NVL(SUM(MOV_CANTID),0) " &
                                                    "FROM ELMVALMA_" & anho & " " &
                                                    "WHERE MOV_CODART = '" & codigo & "' AND MOV_TIPO_TRANS = 'S' AND MOV_ESTADO <> 'A' AND TO_CHAR(MOV_FECEMI, 'MM') = " & i & " AND TO_CHAR(MOV_FECEMI, 'YYYY') = '" & anho & "' AND MOV_CODTRA IN ('S02', 'S05', 'S06', 'S23', 'S33', 'S35'))- " &
                                                    "(SELECT NVL(SUM(MOV_CANTID),0) " &
                                                    "FROM ELMVALMA_" & anho & " " &
                                                    "WHERE MOV_CODART = '" & codigo & "' AND MOV_TIPO_TRANS = 'E' AND MOV_ESTADO <> 'A' AND TO_CHAR(MOV_FECEMI, 'MM') = " & i & " AND TO_CHAR(MOV_FECEMI, 'YYYY') = '" & anho & "' AND MOV_CODTRA IN ('E17','E10', 'E27', 'E24')) " &
                                                    ") FROM DUAL) " &
                          "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '004'  AND T_REPORTE = 'R1' "
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'CANTIDAD CONSUMIDA ACUMULADA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        If mesAct = "MES01" Then
            cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                              "SET " & mesAct & " = (SELECT NVL(" & mesAct & ",0) FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '004' AND T_REPORTE = 'R1' ) " &
                              "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '005' AND T_REPORTE = 'R1' "
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                              "SET " & mesAct & " =(SELECT (SELECT NVL(" & mesAnt & ",0) FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '005' AND T_REPORTE = 'R1' ) + " &
                                                   "(SELECT NVL(" & mesAct & ",0) FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '004' AND T_REPORTE = 'R1' ) FROM DUAL)" &
                              "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '005'  AND T_REPORTE = 'R1' "
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'ENTRADA AJUSTE DE INVENTARIO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                          "SET " & mesAct & " = ( SELECT ( " &
                                                    "(SELECT NVL(SUM(MOV_CANTID),0) " &
                                                    "FROM ELMVALMA_" & anho & " " &
                                                    "WHERE MOV_CODART = '" & codigo & "' AND MOV_TIPO_TRANS = 'E' AND MOV_ESTADO <> 'A' AND TO_CHAR(MOV_FECEMI, 'MM') = " & i & " AND TO_CHAR(MOV_FECEMI, 'YYYY') = '" & anho & "' AND MOV_CODTRA IN ('E11')) " &
                                                    ") FROM DUAL) " &
                          "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '005-01'  AND T_REPORTE = 'R1' "
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'ENTRADA AJUSTE DE INVENTARIO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                          "SET " & mesAct & " = ( SELECT ( " &
                                                    "(SELECT NVL(SUM(MOV_CANTID),0) " &
                                                    "FROM ELMVALMA_" & anho & " " &
                                                    "WHERE MOV_CODART = '" & codigo & "' AND MOV_TIPO_TRANS = 'S' AND MOV_ESTADO <> 'A' AND TO_CHAR(MOV_FECEMI, 'MM') = " & i & " AND TO_CHAR(MOV_FECEMI, 'YYYY') = '" & anho & "' AND MOV_CODTRA IN ('S24')) " &
                                                    ") FROM DUAL) " &
                          "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '005-02'  AND T_REPORTE = 'R1' "
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'EXISTENCIAS FINALES (STOCK)
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                          "SET " & mesAct & " = (SELECT " &
                                          "(SELECT  " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '001' AND T_REPORTE = 'R1' ) + " &
                                          "(SELECT  " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '002' AND T_REPORTE = 'R1' ) - " &
                                          "(SELECT  " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '004' AND T_REPORTE = 'R1' ) + " &
                                          "(SELECT  " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '005-01' AND T_REPORTE = 'R1' ) - " &
                                          "(SELECT  " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '005-02' AND T_REPORTE = 'R1' ) " &
                                       "FROM DUAL) " &
                          "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '006'  AND T_REPORTE = 'R1' "
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'ROTACION DE STOCK
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                          "SET " & mesAct & " = (SELECT ROUND(" &
                                          "(SELECT  " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '005' AND T_REPORTE = 'R1' ) / " &
                                          "(SELECT  DECODE(" & mesAct & ",0,1, " & mesAct & ") FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '006' AND T_REPORTE = 'R1' ),2)  " &
                                       "FROM DUAL) " &
                          "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '007'  AND T_REPORTE = 'R1' "
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'DIAS
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                          "SET " & mesAct & " = " & System.DateTime.DaysInMonth(anho, i) & " " &
                          "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '008'  AND T_REPORTE = 'R1' "
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'DIAS ACUMULADO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        If mesAct = "MES01" Then
            cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                              "SET " & mesAct & " = (SELECT " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '008' AND T_REPORTE = 'R1' ) " &
                              "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '009'  AND T_REPORTE = 'R1' "
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                              "SET " & mesAct & " =(SELECT (SELECT " & mesAnt & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '009' AND T_REPORTE = 'R1' ) + " &
                                                   "(SELECT " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '008' AND T_REPORTE = 'R1' ) FROM DUAL)" &
                              "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '009'  AND T_REPORTE = 'R1' "
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'COBERTURA EN DIAS
        'EXISTENCIAS FINALES (STOCK)
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                          "SET " & mesAct & " = (SELECT ROUND(" &
                                          "(((SELECT  " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '006' AND T_REPORTE = 'R1' ) / " &
                                          "(SELECT DECODE(" & mesAct & ",0,(SELECT  " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '006' AND T_REPORTE = 'R1'), " & mesAct & ") FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '005' AND T_REPORTE = 'R1' )) * " &
                                          "(SELECT  " & mesAct & " FROM ELTBINDCOSTOS WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '009' AND T_REPORTE = 'R1' )),2) " &
                                       "FROM DUAL) " &
                          "WHERE ANHO = '" & anho & "' AND ART_COD = '" & codigo & "' AND COD_CONC = '010'  AND T_REPORTE = 'R1' "
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'REPORTE02
        'CONSUMO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DECLARE CURSOR INDCOSTOS IS " &
                          "SELECT MOV_CODART, CCO_COD FROM ELMVALMA_" & anho & " WHERE MOV_CODART = '" & codigo & "' AND MOV_CODTRA IN ('S23', 'E17', 'E10', 'E27') AND CCO_COD IS NOT NULL AND MOV_ESTADO <> 'A' GROUP BY MOV_CODART, CCO_COD ORDER BY CCO_COD; " &
                          "BEGIN " &
                          "FOR J IN INDCOSTOS " &
                          "LOOP " &
                              "UPDATE ELTBINDCOSTOS " &
                              "SET " & mesAct & " = (SELECT NVL((SELECT SUM(MOV_CANTID) FROM ELMVALMA_" & anho & " WHERE MOV_CODART = J.MOV_CODART AND MOV_ESTADO <> 'A' AND TO_CHAR(MOV_FECEMI, 'MM') = " & i & " AND TO_CHAR(MOV_FECEMI, 'YYYY') = '" & anho & "' AND MOV_CODTRA = 'S23' AND CCO_COD = J.CCO_COD) - " &
                                                  "(SELECT NVL(SUM(MOV_CANTID),0) FROM ELMVALMA_" & anho & " WHERE MOV_CODART = J.MOV_CODART AND MOV_ESTADO <> 'A' AND TO_CHAR(MOV_FECEMI, 'MM') = " & i & " AND TO_CHAR(MOV_FECEMI, 'YYYY') = '" & anho & "' AND MOV_CODTRA IN ('E17','E10', 'E27') AND CCO_COD = J.CCO_COD), 0) " &
                                           "FROM DUAL) " &
                              "WHERE ART_COD = '" & codigo & "' AND ANHO = '" & anho & "' AND T_REPORTE = 'R2' AND COD_CONC = J.CCO_COD; " &
                           "End Loop; " &
                           "END; "
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'TOTAL CONSUMO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                          "SET TOTAL = NVL(MES01,0) + NVL(MES02,0) + NVL(MES03,0) + NVL(MES04,0) + NVL(MES05,0) + NVL(MES06,0) + NVL(MES07,0) + NVL(MES08,0) + NVL(MES09,0) + NVL(MES10,0) + NVL(MES11,0) + NVL(MES12,0) " &
                          "WHERE ART_COD = '" & codigo & "' AND ANHO = '" & anho & "' AND T_REPORTE = 'R2'"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'REPORTE3
        'INGRESO PRODUCCION
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DECLARE CURSOR PRODUCCION IS " &
                          "SELECT CCO_COD, SUM(MOV_CANTID) CANTIDAD FROM ELMVALMA_" & anho & " WHERE MOV_CODTRA = 'E12' AND MOV_ESTADO <> 'A' AND CCO_COD IS NOT NULL AND TO_CHAR(MOV_FECEMI, 'MM') = " & i & " AND TO_CHAR(MOV_FECEMI, 'YYYY') = '" & anho & "' GROUP BY CCO_COD; " &
                          "BEGIN " &
                            "FOR P IN PRODUCCION " &
                            "Loop " &
                              "UPDATE ELTBINDCOSTOS " &
                              "SET " & mesAct & " = P.CANTIDAD " &
                              "WHERE ART_COD = '" & codigo & "' AND ANHO = '" & anho & "' AND T_REPORTE = 'R3' AND COD_CONC = P.CCO_COD; " &
                             "END LOOP; " &
                          "END;"

        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'TOTAL CONSUMO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBINDCOSTOS " &
                          "SET TOTAL = NVL(MES01,0) + NVL(MES02,0) + NVL(MES03,0) + NVL(MES04,0) + NVL(MES05,0) + NVL(MES06,0) + NVL(MES07,0) + NVL(MES08,0) + NVL(MES09,0) + NVL(MES10,0) + NVL(MES11,0) + NVL(MES12,0) " &
                          "WHERE ART_COD = '" & codigo & "' AND ANHO = '" & anho & "' AND T_REPORTE = 'R3'"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Function ObtenerIndiceCostos(ByVal codigo As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_INDCOSTOS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODIGO", codigo),
                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
