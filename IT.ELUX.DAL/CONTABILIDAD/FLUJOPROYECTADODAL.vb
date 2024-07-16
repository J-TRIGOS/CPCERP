Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class FLUJOPROYECTADODAL

    Inherits BaseDatosORACLE

    Public Function FlujoProyectadoAnual(ByVal anho As String, ByVal mesACT As String, ByVal mesANT As String, ByVal prdo As String, ByVal i As Integer) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            ActualizarProcedureFlujo(anho, mesACT, mesANT, prdo, i, cn, sqlTrans)
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

    Public Sub ActualizarProcedureFlujo(ByVal anho As String, ByVal mesACT As String, ByVal mesANT As String, ByVal prdo As String, ByVal i As Integer,
                                         ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'SALDO INICIAL
        If mesACT = "MES01" Then
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                               "SET " & mesACT & " = (SELECT NVL(" & mesANT & ", 0) FROM ELTBFLUJOPROY2022 WHERE T_MOVI = 'T' AND OPE_COD = '0001' AND ANHO = " & anho - 1 & ") " &
                               "WHERE T_MOVI = '-' AND OPE_COD = '0001' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                               "SET " & mesACT & " = (SELECT NVL(" & mesANT & ", 0) FROM ELTBFLUJOPROY2022 WHERE T_MOVI = 'T' AND OPE_COD = '0001' AND ANHO = " & anho & ") " &
                               "WHERE T_MOVI = '-' AND OPE_COD = '0001' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'VENTA CONTADO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                          "SET " & mesACT & " = (SELECT SUM(NVL(TPRECIO_VENTA,0) + NVL(T_IGV,0)) FROM DOCUMENTO " &
                          "WHERE T_DOC_REF IN ('01', '03') AND SER_DOC_REF IN ('F001', 'B001') AND PROVEEDOR = '20100279348' " &
                          "And TO_CHAR(FEC_GENE, 'MM/YYYY') = '" & mesACT.Substring(3, 2) & "/" & anho & "' AND F_PAGO_ENT IN ('01-A', '23', '01-B', '01-C', '01') AND EST = 'H' ) " &
                          "WHERE T_MOVI = 'E' AND OPE_COD = '0101' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'VENTA CREADITO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                          "SET " & mesACT & " = (SELECT NVL(SUM(TPRECIO_VENTA+T_IGV),0) FROM DOCUMENTO " &
                          "WHERE T_DOC_REF IN ('01', '03') AND SER_DOC_REF IN ('F001', 'B001') AND PROVEEDOR = '20100279348' " &
                          "And TO_CHAR(FEC_GENE + F_DIAS_PAGO(F_PAGO_ENT), 'MM/YYYY') = '" & mesACT.Substring(3, 2) & "/" & anho & "' AND F_PAGO_ENT NOT IN ('01-A', '23', '01-B', '01-C', '01') AND EST = 'H' ) " &
                          "WHERE T_MOVI = 'E' AND OPE_COD = '0102' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'SUELDOS
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT SUM(MONTO) FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo & " AND T_PAGO = 'MEN') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0101' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = ROUND((SELECT SUM(NVL(MONTO,0)) FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND T_PAGO = 'MEN')/3,2) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0101' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'CTS
        If mesACT = "MES05" And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT " &
                              "(( SELECT NVL(SUM(MONTO),0) FROM CALCPLA WHERE PRDO_COD = " & prdo - 1 & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                              "+ " &
                              "( SELECT ROUND(NVL(SUM(MONTO),0)/6,2) FROM CALCPLA WHERE PRDO_COD = " & prdo - 5 & " AND CPTO_COD = '020' AND T_PAGO = 'GRA') )/2 " &
                              "FROM DUAL ) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0102' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mesACT = "MES11" And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT " &
                              "(( SELECT NVL(SUM(MONTO),0) FROM CALCPLA WHERE PRDO_COD = " & prdo - 1 & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                              "+ " &
                              "( SELECT ROUND(NVL(SUM(MONTO),0)/6,2) FROM CALCPLA WHERE PRDO_COD = " & prdo - 5 & " AND CPTO_COD = '020' AND T_PAGO = 'GRA') )/2 " &
                              "FROM DUAL ) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0102' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'GRATIFICACION
        If mesACT = "MES07" And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = ROUND((SELECT SUM(MONTO) FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo - 7 & " AND T_PAGO = 'GRA')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0103'"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf mesACT = "MES12" And prdo <> 0 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "Set " & mesACT & " = ROUND((Select SUM(MONTO) FROM CALCPLA WHERE CPTO_COD = '020' AND PRDO_COD = " & prdo - 5 & " AND T_PAGO = 'GRA')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0103'"
            cmd.Connection = sqlCon
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'UTILIDADES
        If i + 1 = 3 Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT SUM(TOTAL) FROM ELTBUTILIDADES WHERE ANHO = " & anho - 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0104' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'FLUJO REPRESENTACION

        'ENERGIA ELECTRICA STATKRAFT
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(TPRECIO_COMPRA + T_IGV),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20269180731' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '01') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0301' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0))/3,2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20269180731' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '01') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0301' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'ENERGIA LUZ DEL SUR
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(TPRECIO_COMPRA + T_IGV),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20331898008' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0302' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0))/3,2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20331898008' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0302' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'ENERGIA ELECTRICA ELECTROINDUSTRIA
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(TPRECIO_COMPRA + T_IGV),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20515886576' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '01') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0303' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0))/3,2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20515886576' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '01') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0303' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'SEDAPAL
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(TPRECIO_COMPRA + T_IGV),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20100152356' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0304' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0))/3,2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20100152356' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0304' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'GAS
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(TPRECIO_COMPRA + T_IGV),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20503758114' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '36') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0305' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0))/3,2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20503758114' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '36') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0305' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'TELEFONIA
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(TPRECIO_COMPRA + T_IGV),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20100017491' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0306' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0))/3,2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20100017491' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF = '14') " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0306' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'INTERNET
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(TPRECIO_COMPRA + T_IGV),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20552504641' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF IN ('14','01')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0307' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0))/3,2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20552504641' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF IN ('14','01')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0307' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'ENTEL
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(TPRECIO_COMPRA + T_IGV),2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20106897914' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF IN ('14')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0308' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(TPRECIO_COMPRA,0) + NVL(T_IGV,0))/3,2) " &
                              "FROM DOCUMENTO " &
                              "WHERE PROVEEDOR = '20106897914' AND TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo - 1 & "), F_NOM_PRDO(" & prdo - 2 & "), F_NOM_PRDO(" & prdo - 3 & ")) AND T_DOC_REF IN ('14')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0308' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'FLUJO DE ALQUILER LOCAL

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT DECODE(NVL(SUM(TPRECIO_COMPRA + T_IGV),0), 0 ,F_ALQUILER_ANUAL(" & anho - 1 & "), SUM(TPRECIO_COMPRA + T_IGV))  FROM DOCUMENTO " &
                              "WHERE TO_CHAR(FEC_GENE,'YYYYMM') IN (F_NOM_PRDO(" & prdo & ")) AND T_DOC_REF IN ('10')) " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0401' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        'FLUJO DE PROVEEDORES INVENTARIOS
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                              "WHERE COD_OPE = '0501' AND ANHO = " & anho & " AND MES = " & i + 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0501' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'FLUJO DE PROVEEDORES POR SERVICIOS
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                              "WHERE COD_OPE = '0601' AND ANHO = " & anho & " AND MES = " & i + 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0601' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'FLUJO DE HONORARIOS
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                              "WHERE COD_OPE = '0701' AND ANHO = " & anho & " AND MES = " & i + 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0701' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'IMP. RENT. MENSUAL
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                              "WHERE COD_OPE = '0801' AND ANHO = " & anho & " AND MES = " & i + 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0801' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'ESSALUD
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                          "SET " & mesACT & " = (SELECT SUM(MONTO) FROM CALCPLA WHERE PRDO_COD = " & prdo & " AND CPTO_COD = '019' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0802' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                          "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(MONTO,0))/3,2) FROM CALCPLA WHERE PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND CPTO_COD = '019' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0802' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'SCTR
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                          "SET " & mesACT & " = (SELECT ROUND(SUM(MONTO)*0.0214,2) FROM CALCPLA WHERE PRDO_COD = " & prdo & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0803' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                          "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(MONTO,0)*0.0214)/3,2) FROM CALCPLA WHERE PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0803' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        'SENATI
        If i + 1 < Today.Month Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                          "SET " & mesACT & " = (SELECT ROUND(SUM(MONTO)*0.0075,2) FROM CALCPLA WHERE PRDO_COD = " & prdo & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0804' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                          "SET " & mesACT & " = (SELECT ROUND(SUM(NVL(MONTO,0)*0.0075)/3,2) FROM CALCPLA WHERE PRDO_COD BETWEEN " & prdo - 3 & " AND " & prdo - 1 & " AND CPTO_COD = '020' AND T_PAGO = 'MEN') " &
                          "WHERE T_MOVI = 'S' AND OPE_COD = '0804' AND ANHO = " & anho & ""
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        'FLUJO DE COMPRA DE ACTIVO
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                              "WHERE COD_OPE = '0901' AND ANHO = " & anho & " AND MES = " & i + 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '0901' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'PRESTAMO DE CAPITAL


        'FLUJO DE INTERES
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                              "WHERE COD_OPE = '1002' AND ANHO = " & anho & " AND MES = " & i + 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '1002' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'LEASING VEHICULAR
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                              "WHERE COD_OPE = '1003' AND ANHO = " & anho & " AND MES = " & i + 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '1003' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'FLUJO DIVIDENDOS PAGADOS
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                              "WHERE COD_OPE = '1101' AND ANHO = " & anho & " AND MES = " & i + 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '1101' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'GASTOS BANCARIOS
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                              "SET " & mesACT & " = (SELECT NVL(MONTO,0) FROM ELTBFLUJOCUENTAS " &
                              "WHERE COD_OPE = '1201' AND ANHO = " & anho & " AND MES = " & i + 1 & ") " &
                              "WHERE T_MOVI = 'S' AND OPE_COD = '1201' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'TOTAL VERTICAL
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                          "SET " & mesACT & " = (SELECT " &
                          "( SELECT sum(NVL(" & mesACT & ",0)) FROM  ELTBFLUJOPROY2022 WHERE T_MOVI IN ('-', 'E') AND ANHO = " & anho & ") " &
                          "- " &
                          "( SELECT sum(NVL(" & mesACT & ",0))  FROM  ELTBFLUJOPROY2022 WHERE T_MOVI IN ('S') AND ANHO = " & anho & " ) FROM DUAL) " &
                          "WHERE T_MOVI = 'T' AND OPE_COD = '0001' AND ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'TOTAL HORIZONTAL
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "UPDATE ELTBFLUJOPROY2022 " &
                          "SET TOTAL = NVL(MES01,0) + NVL(MES02,0) + NVL(MES03,0) + NVL(MES04,0) + NVL(MES05,0) + NVL(MES06,0) + NVL(MES07,0) + NVL(MES08,0) + NVL(MES09,0) + NVL(MES10,0) + NVL(MES11,0) + NVL(MES12,0) " &
                          "WHERE ANHO = " & anho & ""
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub



    Public Function buscarPeriodo(ByVal mes As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_PERIODO_FLUJO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MMES", mes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function CalcularMontos(ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ACTUALIZAR_CUENTA_FLUJO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
