Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class FLUJOPROYECTADOMENSUALDAL

    Inherits BaseDatosORACLE
    Public Function FlujoProyectadoMensual(ByVal anho As String, ByVal mes As String, ByVal i As Integer, ByVal diaACT As String, ByVal diaANT As String, ByVal prdo As String,
                                           ByVal dias As Integer) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            ActualizarProcedureFlujo(anho, mes, i, diaACT, diaANT, prdo, dias, cn, sqlTrans)
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

    Public Sub ActualizarProcedureFlujo(ByVal anho As String, ByVal mes As String, ByVal i As Integer, ByVal diaACT As String, ByVal diaANT As String,
                                        ByVal prdo As String, ByVal dias As String,
                                         ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        ' SALDO INICIAL
        If diaACT = "DIA01" And mes = 1 Then
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET " & diaACT & " = ( SELECT TOTAL " &
                              "FROM ELTBFLUJOMENSUAL " &
                              "WHERE MES = 12 AND ANHO = " & anho - 1 & " AND T_MOVI = 'T' AND OPE_COD = '0001') " &
                              "WHERE T_MOVI = '-' AND OPE_COD = '0001' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf diaACT = "DIA01" And mes <> 1 Then
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET " & diaACT & " = (SELECT TOTAL " &
                                           "FROM ELTBFLUJOMENSUAL " &
                                           "WHERE T_MOVI = 'T' AND OPE_COD = '0001' AND ANHO = " & anho & " AND MES = " & mes - 1 & ")  " &
                              "WHERE T_MOVI = '-' AND OPE_COD = '0001' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET " & diaACT & " = (SELECT " & diaANT & " " &
                                           "FROM ELTBFLUJOMENSUAL " &
                                           "WHERE T_MOVI = 'T' AND OPE_COD = '0001' AND ANHO = " & anho & " AND MES = " & mes & ")  " &
                              "WHERE T_MOVI = '-' AND OPE_COD = '0001' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'VENTA CONTADO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET " & diaACT & " = (SELECT NVL(SUM(TPRECIO_VENTA+T_IGV),0) FROM DOCUMENTO " &
                          "WHERE T_DOC_REF IN ('01', '03') AND SER_DOC_REF IN ('F001', 'B001') AND PROVEEDOR = '20100279348' " &
                          "AND FEC_GENE = TO_DATE('" & i & "/" & mes & "/" & anho & "', 'DD/MM/YYYY' ) AND F_PAGO_ENT IN ('01-A', '23', '01-B', '01-C', '01') AND EST = 'H' ) " &
                          "WHERE T_MOVI = 'E' AND OPE_COD = '0101' AND MES = " & mes & " AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'VENTA CREDITO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET " & diaACT & " = (SELECT NVL(SUM(TPRECIO_VENTA+T_IGV),0) FROM DOCUMENTO " &
                          "WHERE T_DOC_REF IN ('01', '03') AND SER_DOC_REF IN ('F001', 'B001') AND PROVEEDOR = '20100279348' " &
                          "AND FEC_GENE + F_DIAS_PAGO(F_PAGO_ENT) = TO_DATE('" & i & "/" & mes & "/" & anho & "', 'DD/MM/YYYY' ) AND F_PAGO_ENT NOT IN ('01-A', '23', '01-B', '01-C', '01') AND EST = 'H' ) " &
                          "WHERE T_MOVI = 'E' AND OPE_COD = '0102' AND MES = " & mes & " AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'SUELDOS
        If i = 1 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            If mes < Today.Month Then
                Select Case dias
                    Case 31
                        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = (SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo & " AND T_PAGO = 'MEN'), " &
                                  "DIA31 = (SELECT SUM(NVL(MONTO,0))/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo & " AND T_PAGO = 'MEN') " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0101' AND ANHO = " & anho & " AND MES = " & mes & ""
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Case 30
                        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15= (SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo & " AND T_PAGO = 'MEN'), " &
                                  "DIA30= (SELECT SUM(NVL(MONTO,0))/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo & " AND T_PAGO = 'MEN') " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0101' AND ANHO = " & anho & " AND MES = " & mes & ""
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Case 28
                        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15= (SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo & " AND T_PAGO = 'MEN'), " &
                                  "DIA28= (SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo & " AND T_PAGO = 'MEN') " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0101' AND ANHO = " & anho & " AND MES = " & mes & ""
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Case 29
                        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15= (SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo & " AND T_PAGO = 'MEN'), " &
                                  "DIA29= (SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo & " AND T_PAGO = 'MEN') " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0101' AND ANHO = " & anho & " AND MES = " & mes & ""
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                End Select
            Else
                Select Case dias
                    Case 31
                        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = ROUND((SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND T_PAGO = 'MEN')/3,2), " &
                                  "DIA31 = ROUND((SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND T_PAGO = 'MEN')/3,2) " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0101' AND ANHO = " & anho & " AND MES = " & mes & ""
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Case 30
                        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = ROUND((SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND T_PAGO = 'MEN')/3,2), " &
                                  "DIA30 = ROUND((SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND T_PAGO = 'MEN')/3,2) " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0101' AND ANHO = " & anho & " AND MES = " & mes & ""
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Case 28
                        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = ROUND((SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND T_PAGO = 'MEN')/3,2), " &
                                  "DIA28 = ROUND((SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND T_PAGO = 'MEN')/3,2) " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0101' AND ANHO = " & anho & " AND MES = " & mes & ""
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Case 29
                        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = ROUND((SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND T_PAGO = 'MEN')/3,2), " &
                                  "DIA29 = ROUND((SELECT NVL(SUM(MONTO),0)/2 FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND T_PAGO = 'MEN')/3,2) " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0101' AND ANHO = " & anho & " AND MES = " & mes & ""
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                End Select


            End If

        End If

        'CTS
        If i = "15" And mes = 5 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT " &
                              "(( SELECT NVL(SUM(MONTO),0) FROM CALCPLA WHERE PRDO_COD = " & prdo - 1 & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                              "+ " &
                              "( SELECT ROUND(NVL(SUM(MONTO),0)/6,2) FROM CALCPLA WHERE PRDO_COD = " & prdo - 5 & " AND CPTO_COD = '020' AND T_PAGO = 'GRA') )/2 " &
                              "FROM DUAL ) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0102' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf i = "15" And mes = 11 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT " &
                              "(( SELECT NVL(SUM(NVL(MONTO,0)),0) FROM CALCPLA WHERE PRDO_COD = " & prdo - 1 & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                              "+ " &
                              "( SELECT ROUND(NVL(SUM(NVL(MONTO,0)),0)/6,2) FROM CALCPLA WHERE PRDO_COD = " & prdo - 5 & " AND CPTO_COD = '020' AND T_PAGO = 'GRA') )/2 " &
                              "FROM DUAL ) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0102' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'GRATIFICACION
        If mes = 7 And i = 15 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "Set DIA15 = ROUND((Select SUM(NVL(MONTO,0)) FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo - 7 & " AND T_PAGO = 'GRA')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0103' AND MES = " & mes & " AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes = 12 And i = 15 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "Set DIA15 = ROUND((Select SUM(NVL(MONTO,0)) FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo - 5 & " AND T_PAGO = 'GRA')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0103' AND MES = " & mes & " AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'UTILIDADES
        If mes = 3 And i = 15 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT SUM(NVL(TOTAL,0)) FROM ELTBUTILIDADES WHERE ANHO = " & anho - 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0104' AND MES = " & mes & " AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes = 4 And i = 1 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT SUM(NVL(TOTAL,0)) FROM ELTBUTILIDADES WHERE ANHO = " & anho & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0104' AND MES = " & mes - 1 & " AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'ENERGIA ELECTRICA STATKRAFT
        If mes < Today.Month And i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0)),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20269180731' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '01') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0301' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 1 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT NVL(SUM(TPRECIO_COMPRA + T_IGV)/3,0) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20269180731' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '01') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0301' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'ENERGIA ELECTRICA LUZ DEL SUR
        If mes < Today.Month And i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                             "SET DIA15 = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0)),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20331898008' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0302' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 1 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT NVL(SUM(TPRECIO_COMPRA + T_IGV)/3,0) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20331898008' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0302' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'ENERGIA ELECTRICA ELECTROINDUSTRIA
        If mes < Today.Month And i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0)),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20515886576' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '01') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0303' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 1 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT NVL(SUM(TPRECIO_COMPRA + T_IGV)/3,0) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20515886576' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '01') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0303' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'AGUA POTABLE SEDAPAL
        If mes < Today.Month And i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0)),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20100152356' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0304' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 1 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT NVL(SUM(TPRECIO_COMPRA + T_IGV)/3,0) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20100152356' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0304' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        'GAS NATURAL DE LIMA Y CALLAO
        If mes < Today.Month And i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0)),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20503758114' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '36') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0305' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 1 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT NVL(SUM(TPRECIO_COMPRA + T_IGV)/3,0) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20503758114' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '36') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0305' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'TELEFONICA
        If mes < Today.Month And i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0)),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20100017491' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0306' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 1 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT NVL(SUM(TPRECIO_COMPRA + T_IGV)/3,0) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20100017491' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0306' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'INTERNET
        If mes < Today.Month And i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0)),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20552504641' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF  IN ('14', '01')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0307' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 1 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT NVL(SUM(TPRECIO_COMPRA + T_IGV)/3,0) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20552504641' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF IN ('14', '01')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0307' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'ENTEL
        If mes < Today.Month And i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0)),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20106897914' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF  IN ('14')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0308' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 1 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET DIA15 = (SELECT NVL(SUM(TPRECIO_COMPRA + T_IGV)/3,0) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20106897914' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF IN ('14')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0308' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'FLUJO DE ALQUILER LOCAL
        If i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = (SELECT DECODE(NVL(SUM(TPRECIO_COMPRA + T_IGV),0), 0 ,F_ALQUILER_ANUAL(" & anho - 1 & "), SUM(TPRECIO_COMPRA + T_IGV))  FROM DOCUMENTO " &
                                  "WHERE TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF IN ('10')) " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0401' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'FLUJO DE PROVEEDORES INVENTARIOS
        If i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                                  "WHERE COD_OPE = '0501' AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0501' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        'FLUJO DE PROVEEDORES POR SERVICIOS
        If i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                                  "WHERE COD_OPE = '0601' AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0601' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        'FLUJO DE HONORARIOS
        If mes < Today.Month Then
            If i = 15 Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                      "SET DIA15 = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                                      "WHERE COD_OPE = '0701' AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                      "WHERE T_MOVI = 'S' AND OPE_COD = '0701' AND ANHO = " & anho & "  AND MES = " & mes & ""
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Else
            If i = 15 Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                      "SET DIA15 = 0 " &
                                      "WHERE T_MOVI = 'S' AND OPE_COD = '0701' AND ANHO = " & anho & " AND MES = " & mes & ""
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        End If

        'IMP. RENT. MENSUAL
        If mes < Today.Month Then
            If i = 15 Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                                  "WHERE COD_OPE = '0801' AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0801' AND ANHO = " & anho & " AND MES = " & mes & ""
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Else
            If i = 15 Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                      "SET DIA15 = 0 " &
                                      "WHERE T_MOVI = 'S' AND OPE_COD = '0801' AND ANHO = " & anho & " AND MES = " & mes & ""
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        End If

        'ESSALUD
        If mes < Today.Month And i = 15 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET DIA15 = (SELECT SUM(NVL(MONTO,0)) FROM CALCPLA WHERE PRDO_COD = " & prdo & " AND CPTO_COD = '019' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0802' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 15 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET DIA15 = (SELECT ROUND(SUM(NVL(MONTO,0))/3,2) FROM CALCPLA WHERE PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND CPTO_COD = '019' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0802' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'SCTR
        If mes < Today.Month And i = 15 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET DIA15 = (SELECT ROUND(SUM(NVL(MONTO,0))*0.0214,2) FROM CALCPLA WHERE PRDO_COD = " & prdo & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0803' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 15 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET DIA15 = (SELECT ROUND(SUM(NVL(MONTO,0)*0.0214)/3,2) FROM CALCPLA WHERE PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0803' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'SENATI
        If mes < Today.Month And i = 15 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET DIA15 = (SELECT ROUND(SUM(NVL(MONTO,0))*0.0075,2) FROM CALCPLA WHERE PRDO_COD = " & prdo & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0804' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mes >= Today.Month And i = 15 And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET DIA15 = (SELECT ROUND(SUM(NVL(MONTO,0)*0.0075)/3,2) FROM CALCPLA WHERE PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0804' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'FLUJO DE COMPRA DE ACTIVO
        If i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                                  "WHERE COD_OPE = '0901' AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '0901' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'PRESTAMO DE CAPITAL

        'FLUJO DE INTERES
        If i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                                  "WHERE COD_OPE = '1002' AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '1002' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'LEASING VEHICULAR
        If i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                                  "WHERE COD_OPE = '1003' AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '1003' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        '10-4 LEASING VEHICULAR - INTERESE

        '10-5 FEC-CAPITAL

        '10-6 FEC -INTERESE

        'FLUJO DIVIDENDOS PAGADOS

        If i = 15 Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                                  "WHERE COD_OPE = '1101' AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '1101' AND ANHO = " & anho & " AND MES = " & mes & ""
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


        'GASTOS BANCARIOS
        If i = 15 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                                  "SET DIA15 = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                                  "WHERE COD_OPE = '1201' AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                  "WHERE T_MOVI = 'S' AND OPE_COD = '1201' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        '13-01 FLUJO POR OTROS GASTOS FINANCIEROS
        '14-01 OTROS PAGOS DE FECTIVO RELATIVOS A LA ACTIVIDAD DE FINANCIAMIENTO


        'ACTUALIZAR TOTAL VERTICAL
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET " & diaACT & " = ( SELECT ( " &
                                              "(SELECT NVL(SUM(" & diaACT & "),0) FROM ELTBFLUJOMENSUAL  WHERE T_MOVI IN ('-', 'E') AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                              "- " &
                                              "(SELECT NVL(SUM(" & diaACT & "),0) FROM ELTBFLUJOMENSUAL  WHERE T_MOVI IN ('S') AND ANHO = " & anho & " AND MES = " & mes & " ) " &
                                              ") " &
                                      "FROM DUAL ) " &
                          "WHERE T_MOVI = 'T' AND OPE_COD = '0001' AND ANHO = " & anho & " AND MES = " & mes & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        If i = dias Then
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET TOTAL_QUIN = ( SELECT ( " &
                                              "(SELECT NVL(SUM(TOTAL_QUIN),0) FROM ELTBFLUJOMENSUAL  WHERE T_MOVI IN ('-', 'E') AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                              "- " &
                                              "(SELECT NVL(SUM(TOTAL_QUIN),0) FROM ELTBFLUJOMENSUAL  WHERE T_MOVI IN ('S') AND ANHO = " & anho & " AND MES = " & mes & " ) " &
                                              ") " &
                                      "FROM DUAL ) " &
                          "WHERE T_MOVI = 'T' AND OPE_COD = '0001' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                              "SET TOTAL = ( SELECT ( " &
                                                  "(SELECT NVL(SUM(TOTAL),0) FROM ELTBFLUJOMENSUAL  WHERE T_MOVI IN ('-', 'E') AND ANHO = " & anho & " AND MES = " & mes & ") " &
                                                  "- " &
                                                  "(SELECT NVL(SUM(TOTAL),0) FROM ELTBFLUJOMENSUAL  WHERE T_MOVI IN ('S') AND ANHO = " & anho & " AND MES = " & mes & " ) " &
                                                  ") " &
                                          "FROM DUAL ) " &
                              "WHERE T_MOVI = 'T' AND OPE_COD = '0001' AND ANHO = " & anho & " AND MES = " & mes & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        'ACTUALIZAR TOTAL HORIZONTAL
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET TOTAL_QUIN = NVL(DIA01,0) + NVL(DIA02,0) + NVL(DIA03,0) + NVL(DIA04,0) + NVL(DIA05,0) + NVL(DIA06,0) + NVL(DIA07,0) + NVL(DIA08,0) " &
                          "+ NVL(DIA09,0) + NVL(DIA10,0) + NVL(DIA11,0) + NVL(DIA12,0) + NVL(DIA13,0) + NVL(DIA14,0) + NVL(DIA15,0), " &
                          "TOTAL = NVL(DIA01,0) + NVL(DIA02,0) + NVL(DIA03,0) + NVL(DIA04,0) + NVL(DIA05,0) + NVL(DIA06,0) + NVL(DIA07,0) + NVL(DIA08,0) " &
                          "+ NVL(DIA09,0) + NVL(DIA10,0) + NVL(DIA11,0) + NVL(DIA12,0) + NVL(DIA13,0) + NVL(DIA14,0) + NVL(DIA15,0) + " &
                          "NVL(DIA16,0) + NVL(DIA17,0) + NVL(DIA18,0) + NVL(DIA19,0) + NVL(DIA20,0) + NVL(DIA21,0) + NVL(DIA22,0) + NVL(DIA23,0) + NVL(DIA24,0) " &
                          "+ NVL(DIA25,0) + NVL(DIA26,0) + NVL(DIA27,0) + NVL(DIA28,0) + NVL(DIA29,0) + NVL(DIA30,0) + NVL(DIA31,0) " &
                          "WHERE ANHO = " & anho & " And MES = " & mes & " And T_MOVI Not IN ('-', 'T')"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOMENSUAL " &
                          "SET TOTAL_QUIN = (SELECT NVL(DIA01,0) FROM ELTBFLUJOMENSUAL  " &
                          "WHERE T_MOVI= '-' AND ANHO = " & anho & " AND OPE_COD = '0001' AND MES = " & mes & " )," &
                          "TOTAL =  (SELECT NVL(DIA01,0) FROM ELTBFLUJOMENSUAL  " &
                          "WHERE T_MOVI= '-' AND ANHO = " & anho & " AND OPE_COD = '0001' AND MES = " & mes & " )" &
                          "WHERE ANHO = " & anho & " AND MES = " & mes & " AND T_MOVI IN ('-')"
        cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                cmd.Dispose()


    End Sub

End Class
