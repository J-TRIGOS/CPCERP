Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBCARGADETASIENTODAL
    Inherits BaseDatosORACLE
    Public Function SaveRow(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal flagAccion As String, ByVal Cco_cod As String, ByVal dgtareo As DataGridView) As String
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
                If Cco_cod = "1" Then
                    InsertRow1(ELTBCARGADETASIENTOBE, cn, sqlTrans, dgtareo)
                ElseIf Cco_cod = "2" Then
                    InsertRow2(ELTBCARGADETASIENTOBE, cn, sqlTrans, dgtareo)
                Else
                    InsertRow(ELTBCARGADETASIENTOBE, cn, sqlTrans, dgtareo)
                End If
            End If

            If flagAccion = "N1" Then
                If Cco_cod = "4" Then
                    InsertRow4(ELTBCARGADETASIENTOBE, cn, sqlTrans, dgtareo)
                ElseIf Cco_cod = "3" Then
                    InsertRow3(ELTBCARGADETASIENTOBE, cn, sqlTrans, dgtareo)
                Else
                    InsertRow5(ELTBCARGADETASIENTOBE, cn, sqlTrans, dgtareo)
                End If
            End If
            If flagAccion = "N2" Then
                InsertRow6(ELTBCARGADETASIENTOBE, cn, sqlTrans, dgtareo)
            End If
            If flagAccion = "N3" Then
                InsertRow7(ELTBCARGADETASIENTOBE, cn, sqlTrans, dgtareo)
            End If
            If flagAccion = "E" Then
                DeleteRow(ELTBCARGADETASIENTOBE, cn, sqlTrans)
            End If
            '
            'If flagAccion = "M" Then
            '    UpdateRow(ELTBCARGADETASIENTOBE, cn, sqlTrans, dgtareo)
            'End If
            '
            'If flagAccion = "E" Then
            '    DeleteRow(ELTBCARGADETASIENTOBE, cn, sqlTrans)
            'End If

            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            If resultado = "OK" And flagAccion <> "E" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Private Sub InsertRow(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'AGREGAR DIRECCIONES
        '   Dim i As Integer = 0
        '   Dim fecha, fecha_ing As Date
        'Dim cont As Integer = ELTBTAREOBE.id

        '   fecha_ing = DateTime.Now.ToString("dd/MM/yyyy")

        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCARGAASIENTO_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELTBCARGADETASIENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("TIPO").Value)), "", RTrim(row.Cells("TIPO").Value))               '0
            ELTBCARGADETASIENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SERIE").Value)), "", RTrim(row.Cells("SERIE").Value))           '1
            ELTBCARGADETASIENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NUMERO").Value)), "", RTrim(row.Cells("NUMERO").Value))         '2
            ELTBCARGADETASIENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("TIPO1").Value)), "", RTrim(row.Cells("TIPO1").Value))            '3
            ELTBCARGADETASIENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SERIE1").Value)), "", RTrim(row.Cells("SERIE1").Value))        '4
            ELTBCARGADETASIENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NUMERO1").Value)), "", RTrim(row.Cells("NUMERO1").Value))      '5
            ELTBCARGADETASIENTOBE.FEC_GEN = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))               '6
            ELTBCARGADETASIENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA").Value)), "", RTrim(row.Cells("CUENTA").Value))              '7
            ELTBCARGADETASIENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("DESTINO").Value)), "", RTrim(row.Cells("DESTINO").Value))       '8
            ELTBCARGADETASIENTOBE.TPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("IMPORTE").Value)), "", RTrim(row.Cells("IMPORTE").Value))    '9
            ELTBCARGADETASIENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells("MONEDA").Value)), "", RTrim(row.Cells("MONEDA").Value))              '10
            ELTBCARGADETASIENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO").Value)), "", RTrim(row.Cells("SIGNO").Value))                 '11
            ELTBCARGADETASIENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), "", RTrim(row.Cells("T_CAMB").Value))              '12
            ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("DOLARES").Value)), "", RTrim(row.Cells("DOLARES").Value))   '13
            ELTBCARGADETASIENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value))     '14
            ELTBCARGADETASIENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value))     '15
            ELTBCARGADETASIENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))         '16
            ELTBCARGADETASIENTOBE.X_RET = IIf(IsDBNull(RTrim(row.Cells("X_RET").Value)), "", RTrim(row.Cells("X_RET").Value))               '17
            ELTBCARGADETASIENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUS").Value)), "", RTrim(row.Cells("STATUS").Value))            '18
            ELTBCARGADETASIENTOBE.TIPO7 = IIf(IsDBNull(RTrim(row.Cells("COD_FLUJO").Value)), "", RTrim(row.Cells("COD_FLUJO").Value))            '19
            ELTBCARGADETASIENTOBE.EST_MERCADERIA = IIf(IsDBNull(RTrim(row.Cells("COD_CAJA").Value)), "", RTrim(row.Cells("COD_CAJA").Value))            '20

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF                  '0
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF              '1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF              '2
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF1                '3
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF1            '4
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF1            '5
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_GEN                         '6
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA                        '7
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA_DEST              '8
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TPRECIO_COMPRA          '9
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.MONEDA                        '10
            cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SIGNO                          '11
            cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.T_CAMB                          '12
            cmd.Parameters.Add("@TDPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA        '13
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.PROVEEDOR                  '14
            cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CTCT_COD                    '15
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.ART_COD                      '16
            cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.X_RET                          '17
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.STATUS                        '18
            cmd.Parameters.Add("@TIPO7", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.TIPO7                        '19
            cmd.Parameters.Add("@EST_MERCADERIA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.EST_MERCADERIA.PadLeft(2, "0")      '20                  '18
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        '    'AUDITORIA
        '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '    cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        '    cmd.Connection = sqlCon
        '    cmd.Transaction = sqlTrans
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        '    cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.id  'cod usu
        '    cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro la asistencia : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
    End Sub
    Private Sub InsertRow7(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'AGREGAR DIRECCIONES
        '   Dim i As Integer = 0
        '   Dim fecha, fecha_ing As Date
        'Dim cont As Integer = ELTBTAREOBE.id

        '   fecha_ing = DateTime.Now.ToString("dd/MM/yyyy")

        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCARGAASIENTO_INSERTROW7"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELTBCARGADETASIENTOBE.FEC_GEN = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))           '19

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))                 '0
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))              '1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))              '2
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))                '3
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))            '4
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))            '5
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_GEN                      '6
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))                      '7
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))              '8
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells(9).Value)), "", RTrim(row.Cells(9).Value))         '9
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))                        '10
            cmd.Parameters.Add("@UNIDAD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))                          '11
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(13).Value)), "", RTrim(row.Cells(13).Value))                          '12
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(14).Value)), "", RTrim(row.Cells(14).Value))        '13
            cmd.Parameters.Add("@UPRECIO_AFECTOS", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))                '14
            cmd.Parameters.Add("@UPRECIO_AFECTOD", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells(16).Value)), "", RTrim(row.Cells(16).Value))                   '15
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))                         '16
            cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells(10).Value)), "", RTrim(row.Cells(10).Value))         '9
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        '    'AUDITORIA
        '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '    cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        '    cmd.Connection = sqlCon
        '    cmd.Transaction = sqlTrans
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        '    cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.id  'cod usu
        '    cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro la asistencia : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
    End Sub
    Private Sub InsertRow6(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'AGREGAR DIRECCIONES
        '   Dim i As Integer = 0
        '   Dim fecha, fecha_ing As Date
        'Dim cont As Integer = ELTBTAREOBE.id

        '   fecha_ing = DateTime.Now.ToString("dd/MM/yyyy")

        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCARGAASIENTO_INSERTROW6"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            'ELTBCARGADETASIENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("TIPON").Value)), "", RTrim(row.Cells("TIPON").Value))               '0
            'ELTBCARGADETASIENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD2").Value)), "", RTrim(row.Cells("ART_COD2").Value))           '16
            ELTBCARGADETASIENTOBE.FEC_GEN = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))           '19
            ELTBCARGADETASIENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))              '0
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))            '1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))              '2
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_GEN                '3
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))           '4
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))            '5
            cmd.Parameters.Add("@OBSERVA", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))                      '7
            cmd.Parameters.Add("@FEC_PROV", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_ENT                        '6
            cmd.Parameters.Add("@USER", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.USUARIO                      '7
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        '    'AUDITORIA
        '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '    cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        '    cmd.Connection = sqlCon
        '    cmd.Transaction = sqlTrans
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        '    cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.id  'cod usu
        '    cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro la asistencia : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
    End Sub
    Private Sub InsertRow5(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'AGREGAR DIRECCIONES
        '   Dim i As Integer = 0
        '   Dim fecha, fecha_ing As Date
        'Dim cont As Integer = ELTBTAREOBE.id

        '   fecha_ing = DateTime.Now.ToString("dd/MM/yyyy")

        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCARGAASIENTO_INSERTROW5"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            'ELTBCARGADETASIENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("TIPON03").Value)), "", RTrim(row.Cells("TIPON03").Value))               '0
            'ELTBCARGADETASIENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SERIEN03").Value)), "", RTrim(row.Cells("SERIEN03").Value))           '1
            'ELTBCARGADETASIENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NUMERON03").Value)), "", RTrim(row.Cells("NUMERON03").Value))         '2
            'ELTBCARGADETASIENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("TIPON13").Value)), "", RTrim(row.Cells("TIPON13").Value))            '3
            'ELTBCARGADETASIENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SERIEN13").Value)), "", RTrim(row.Cells("SERIEN13").Value))        '4
            'ELTBCARGADETASIENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NUMERON13").Value)), "", RTrim(row.Cells("NUMERON13").Value))      '5
            ''ELTBCARGADETASIENTOBE.FEC_GEN = IIf(IsDBNull(RTrim(row.Cells("FECHA").Value)), "", RTrim(row.Cells("FECHA").Value))               '6
            'ELTBCARGADETASIENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTAN03").Value)), "", RTrim(row.Cells("CUENTAN03").Value))              '7
            'ELTBCARGADETASIENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("DESTINON03").Value)), "", RTrim(row.Cells("DESTINON03").Value))       '8
            'ELTBCARGADETASIENTOBE.TPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("IMPORTEN03").Value)), "", RTrim(row.Cells("IMPORTEN03").Value))    '9
            'ELTBCARGADETASIENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells("MONEDAN03").Value)), "", RTrim(row.Cells("MONEDAN03").Value))              '10
            'ELTBCARGADETASIENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNON03").Value)), "", RTrim(row.Cells("SIGNON03").Value))                 '11
            'ELTBCARGADETASIENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMBN03").Value)), "", RTrim(row.Cells("T_CAMBN03").Value))              '12
            'ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("DOLARESN03").Value)), "", RTrim(row.Cells("DOLARESN03").Value))   '13
            'ELTBCARGADETASIENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDORN03").Value)), "", RTrim(row.Cells("PROVEEDORN03").Value))     '14
            'ELTBCARGADETASIENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_CODN03").Value)), "", RTrim(row.Cells("CTCT_CODN03").Value))     '15
            'ELTBCARGADETASIENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_CODN03").Value)), "", RTrim(row.Cells("ART_CODN03").Value))         '16
            'ELTBCARGADETASIENTOBE.X_RET = IIf(IsDBNull(RTrim(row.Cells("X_RETN03").Value)), "", RTrim(row.Cells("X_RETN03").Value))               '17
            'ELTBCARGADETASIENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUSN03").Value)), "", RTrim(row.Cells("STATUSN03").Value))            '18

            ELTBCARGADETASIENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("TIPON").Value)), "", RTrim(row.Cells("TIPON").Value))               '0
            ELTBCARGADETASIENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SERIEN").Value)), "", RTrim(row.Cells("SERIEN").Value))           '1
            ELTBCARGADETASIENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NUMERON").Value)), "", RTrim(row.Cells("NUMERON").Value))         '2
            ELTBCARGADETASIENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("TIPON1").Value)), "", RTrim(row.Cells("TIPON1").Value))            '3
            ELTBCARGADETASIENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SERIEN1").Value)), "", RTrim(row.Cells("SERIEN1").Value))        '4
            ELTBCARGADETASIENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NUMERON1").Value)), "", RTrim(row.Cells("NUMERON1").Value))      '5
            ELTBCARGADETASIENTOBE.FEC_GEN = IIf(IsDBNull(RTrim(row.Cells("FECHAN").Value)), "", RTrim(row.Cells("FECHAN").Value))               '6
            ELTBCARGADETASIENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTAN").Value)), "", RTrim(row.Cells("CUENTAN").Value))              '7
            ELTBCARGADETASIENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("DESTINON").Value)), "", RTrim(row.Cells("DESTINON").Value))       '8
            ELTBCARGADETASIENTOBE.TPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("IMPORTEN").Value)), "", RTrim(row.Cells("IMPORTEN").Value))    '9
            ELTBCARGADETASIENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells("MONEDAN").Value)), "", RTrim(row.Cells("MONEDAN").Value))              '10
            ELTBCARGADETASIENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNON").Value)), "", RTrim(row.Cells("SIGNON").Value))                 '11
            ELTBCARGADETASIENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMBN").Value)), "", RTrim(row.Cells("T_CAMBN").Value))              '12
            ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("DOLARESN").Value)), "", RTrim(row.Cells("DOLARESN").Value))   '13
            ELTBCARGADETASIENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDORN").Value)), "", RTrim(row.Cells("PROVEEDORN").Value))     '14
            ELTBCARGADETASIENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_CODN").Value)), "", RTrim(row.Cells("CTCT_CODN").Value))       '15
            'ELTBCARGADETASIENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD2").Value)), "", RTrim(row.Cells("ART_COD2").Value))           '16
            ELTBCARGADETASIENTOBE.X_RET = IIf(IsDBNull(RTrim(row.Cells("X_RETN").Value)), "", RTrim(row.Cells("X_RETN").Value))                 '17
            ELTBCARGADETASIENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUSN").Value)), "", RTrim(row.Cells("STATUSN").Value))              '18
            'ELTBCARGADETASIENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells("FEC_ENTN").Value)), "", RTrim(row.Cells("FEC_ENTN").Value))           '19

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF                  '0
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF              '1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF              '2
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF1                '3
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF1            '4
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF1            '5
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_GEN                         '6
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA                        '7
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA_DEST              '8
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TPRECIO_COMPRA          '9
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.MONEDA                        '10
            cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SIGNO                          '11
            cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.T_CAMB                          '12
            cmd.Parameters.Add("@TDPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA        '13
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.PROVEEDOR                  '14
            cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CTCT_COD                    '15
            'cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.ART_COD                     
            cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.X_RET                          '16
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.STATUS                        '17
            cmd.Parameters.Add("@T_OPE_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_OPE_COD                  '18
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        '    'AUDITORIA
        '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '    cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        '    cmd.Connection = sqlCon
        '    cmd.Transaction = sqlTrans
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        '    cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.id  'cod usu
        '    cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro la asistencia : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
    End Sub
    Private Sub InsertRow1(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCARGAASIENTO_INSERTROW1"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELTBCARGADETASIENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("TIPO0").Value)), "", RTrim(row.Cells("TIPO0").Value))               '0
            ELTBCARGADETASIENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SERIE0").Value)), "", RTrim(row.Cells("SERIE0").Value))           '1
            ELTBCARGADETASIENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NUMERO0").Value)), "", RTrim(row.Cells("NUMERO0").Value))         '2
            ELTBCARGADETASIENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("TIPO10").Value)), "", RTrim(row.Cells("TIPO10").Value))            '3
            ELTBCARGADETASIENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SERIE10").Value)), "", RTrim(row.Cells("SERIE10").Value))        '4
            ELTBCARGADETASIENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NUMERO10").Value)), "", RTrim(row.Cells("NUMERO10").Value))      '5
            ELTBCARGADETASIENTOBE.FEC_GEN = IIf(IsDBNull(RTrim(row.Cells("FECHA0").Value)), "", RTrim(row.Cells("FECHA0").Value))               '6
            ELTBCARGADETASIENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA0").Value)), "", RTrim(row.Cells("CUENTA0").Value))              '7
            ELTBCARGADETASIENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("DESTINO0").Value)), "", RTrim(row.Cells("DESTINO0").Value))       '8
            ELTBCARGADETASIENTOBE.TPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("IMPORTE0").Value)), "", RTrim(row.Cells("IMPORTE0").Value))    '9
            ELTBCARGADETASIENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells("MONEDA0").Value)), "", RTrim(row.Cells("MONEDA0").Value))              '10
            ELTBCARGADETASIENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO0").Value)), "", RTrim(row.Cells("SIGNO0").Value))                 '11
            ELTBCARGADETASIENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB0").Value)), "", RTrim(row.Cells("T_CAMB0").Value))              '12
            ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("DOLARES0").Value)), "", RTrim(row.Cells("DOLARES0").Value))   '13
            ELTBCARGADETASIENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR0").Value)), "", RTrim(row.Cells("PROVEEDOR0").Value))     '14
            ELTBCARGADETASIENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD0").Value)), "", RTrim(row.Cells("CTCT_COD0").Value))       '15
            ELTBCARGADETASIENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD0").Value)), "", RTrim(row.Cells("ART_COD0").Value))           '16
            ELTBCARGADETASIENTOBE.X_RET = IIf(IsDBNull(RTrim(row.Cells("X_RET0").Value)), "", RTrim(row.Cells("X_RET0").Value))                 '17
            ELTBCARGADETASIENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUS0").Value)), "", RTrim(row.Cells("STATUS0").Value))              '18
            ELTBCARGADETASIENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_COD0").Value)), "", RTrim(row.Cells("CCO_COD0").Value))           '19

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF                  '0
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF              '1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF              '2
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF1                '3
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF1            '4
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF1            '5
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_GEN                         '6
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA                        '7
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA_DEST              '8
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TPRECIO_COMPRA          '9
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.MONEDA                        '10
            cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SIGNO                          '11
            cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.T_CAMB                          '12
            cmd.Parameters.Add("@TDPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA        '13
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.PROVEEDOR                  '14
            cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CTCT_COD                    '15
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.ART_COD                      '16
            cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.X_RET                          '17
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.STATUS                        '18
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CCO_COD                      '19
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Private Sub InsertRow4(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCARGAASIENTO_INSERTROW4"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELTBCARGADETASIENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("TIPON01").Value)), "", RTrim(row.Cells("TIPON01").Value))               '0
            ELTBCARGADETASIENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SERIEN01").Value)), "", RTrim(row.Cells("SERIEN01").Value))           '1
            ELTBCARGADETASIENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NUMERON01").Value)), "", RTrim(row.Cells("NUMERON01").Value))         '2
            ELTBCARGADETASIENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("TIPON12").Value)), "", RTrim(row.Cells("TIPON12").Value))            '3
            ELTBCARGADETASIENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SERIEN12").Value)), "", RTrim(row.Cells("SERIEN12").Value))        '4
            ELTBCARGADETASIENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NUMERON12").Value)), "", RTrim(row.Cells("NUMERON12").Value))      '5
            ELTBCARGADETASIENTOBE.FEC_GEN = IIf(IsDBNull(RTrim(row.Cells("FECHAN01").Value)), "", RTrim(row.Cells("FECHAN01").Value))               '6
            ELTBCARGADETASIENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTAN01").Value)), "", RTrim(row.Cells("CUENTAN01").Value))              '7
            ELTBCARGADETASIENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("DESTINON01").Value)), "", RTrim(row.Cells("DESTINON01").Value))       '8
            ELTBCARGADETASIENTOBE.TPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("IMPORTEN01").Value)), "", RTrim(row.Cells("IMPORTEN01").Value))    '9
            ELTBCARGADETASIENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells("MONEDAN01").Value)), "", RTrim(row.Cells("MONEDAN01").Value))              '10
            ELTBCARGADETASIENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNON01").Value)), "", RTrim(row.Cells("SIGNON01").Value))                 '11
            ELTBCARGADETASIENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMBN01").Value)), "", RTrim(row.Cells("T_CAMBN01").Value))              '12
            ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("DOLARESN01").Value)), "", RTrim(row.Cells("DOLARESN01").Value))   '13
            ELTBCARGADETASIENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDORN01").Value)), "", RTrim(row.Cells("PROVEEDORN01").Value))     '14
            ELTBCARGADETASIENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_CODN01").Value)), "", RTrim(row.Cells("CTCT_CODN01").Value))       '15
            'ELTBCARGADETASIENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD0").Value)), "", RTrim(row.Cells("ART_COD0").Value))           '16
            ELTBCARGADETASIENTOBE.X_RET = IIf(IsDBNull(RTrim(row.Cells("X_RETN01").Value)), "", RTrim(row.Cells("X_RETN01").Value))                 '17
            ELTBCARGADETASIENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUSN01").Value)), "", RTrim(row.Cells("STATUSN01").Value))              '18
            ELTBCARGADETASIENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells("CCO_CODN01").Value)), "", RTrim(row.Cells("CCO_CODN01").Value))           '19

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF                  '0
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF              '1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF              '2
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF1                '3
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF1            '4
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF1            '5
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_GEN                         '6
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA                        '7
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA_DEST              '8
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TPRECIO_COMPRA          '9
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.MONEDA                        '10
            cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SIGNO                          '11
            cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.T_CAMB                          '12
            cmd.Parameters.Add("@TDPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA        '13
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.PROVEEDOR                  '14
            cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CTCT_COD                    '15
            'cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.ART_COD                      '16
            cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.X_RET                          '17
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.STATUS                        '18
            cmd.Parameters.Add("@CCO_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CCO_COD                      '19
            cmd.Parameters.Add("@T_OPE_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_OPE_COD                      '19
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Private Sub InsertRow2(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCARGAASIENTO_INSERTROW2"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELTBCARGADETASIENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("TIPO2").Value)), "", RTrim(row.Cells("TIPO2").Value))               '0
            ELTBCARGADETASIENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SERIE2").Value)), "", RTrim(row.Cells("SERIE2").Value))           '1
            ELTBCARGADETASIENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NUMERO2").Value)), "", RTrim(row.Cells("NUMERO2").Value))         '2
            ELTBCARGADETASIENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("TIPO12").Value)), "", RTrim(row.Cells("TIPO12").Value))            '3
            ELTBCARGADETASIENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SERIE12").Value)), "", RTrim(row.Cells("SERIE12").Value))        '4
            ELTBCARGADETASIENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NUMERO12").Value)), "", RTrim(row.Cells("NUMERO12").Value))      '5
            ELTBCARGADETASIENTOBE.FEC_GEN = IIf(IsDBNull(RTrim(row.Cells("FECHA2").Value)), "", RTrim(row.Cells("FECHA2").Value))               '6
            ELTBCARGADETASIENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTA2").Value)), "", RTrim(row.Cells("CUENTA2").Value))              '7
            ELTBCARGADETASIENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("DESTINO2").Value)), "", RTrim(row.Cells("DESTINO2").Value))       '8
            ELTBCARGADETASIENTOBE.TPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("IMPORTE2").Value)), "", RTrim(row.Cells("IMPORTE2").Value))    '9
            ELTBCARGADETASIENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells("MONEDA2").Value)), "", RTrim(row.Cells("MONEDA2").Value))              '10
            ELTBCARGADETASIENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNO2").Value)), "", RTrim(row.Cells("SIGNO2").Value))                 '11
            ELTBCARGADETASIENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMB2").Value)), "", RTrim(row.Cells("T_CAMB2").Value))              '12
            ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("DOLARES2").Value)), "", RTrim(row.Cells("DOLARES2").Value))   '13
            ELTBCARGADETASIENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR2").Value)), "", RTrim(row.Cells("PROVEEDOR2").Value))     '14
            ELTBCARGADETASIENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_COD2").Value)), "", RTrim(row.Cells("CTCT_COD2").Value))       '15
            ELTBCARGADETASIENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD2").Value)), "", RTrim(row.Cells("ART_COD2").Value))           '16
            ELTBCARGADETASIENTOBE.X_RET = IIf(IsDBNull(RTrim(row.Cells("X_RET2").Value)), "", RTrim(row.Cells("X_RET2").Value))                 '17
            ELTBCARGADETASIENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUS2").Value)), "", RTrim(row.Cells("STATUS2").Value))              '18
            ELTBCARGADETASIENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells("FEC_ENT2").Value)), "", RTrim(row.Cells("FEC_ENT2").Value))           '19

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF                  '0
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF              '1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF              '2
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF1                '3
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF1            '4
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF1            '5
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_GEN                         '6
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA                        '7
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA_DEST              '8
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TPRECIO_COMPRA          '9
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.MONEDA                        '10
            cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SIGNO                          '11
            cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.T_CAMB                          '12
            cmd.Parameters.Add("@TDPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA        '13
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.PROVEEDOR                  '14
            cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CTCT_COD                    '15
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.ART_COD                      '16
            cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.X_RET                          '17
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.STATUS                        '18
            cmd.Parameters.Add("@FEC_ENT", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_ENT                     '19
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Private Sub InsertRow3(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBCARGAASIENTO_INSERTROW3"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELTBCARGADETASIENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("TIPON03").Value)), "", RTrim(row.Cells("TIPON03").Value))               '0
            ELTBCARGADETASIENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SERIEN03").Value)), "", RTrim(row.Cells("SERIEN03").Value))           '1
            ELTBCARGADETASIENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NUMERON03").Value)), "", RTrim(row.Cells("NUMERON03").Value))         '2
            ELTBCARGADETASIENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("TIPON13").Value)), "", RTrim(row.Cells("TIPON13").Value))            '3
            ELTBCARGADETASIENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SERIEN13").Value)), "", RTrim(row.Cells("SERIEN13").Value))        '4
            ELTBCARGADETASIENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NUMERON13").Value)), "", RTrim(row.Cells("NUMERON13").Value))      '5
            ELTBCARGADETASIENTOBE.FEC_GEN = IIf(IsDBNull(RTrim(row.Cells("FECHAN03").Value)), "", RTrim(row.Cells("FECHAN03").Value))               '6
            ELTBCARGADETASIENTOBE.CUENTA = IIf(IsDBNull(RTrim(row.Cells("CUENTAN03").Value)), "", RTrim(row.Cells("CUENTAN03").Value))              '7
            ELTBCARGADETASIENTOBE.CUENTA_DEST = IIf(IsDBNull(RTrim(row.Cells("DESTINON03").Value)), "", RTrim(row.Cells("DESTINON03").Value))       '8
            ELTBCARGADETASIENTOBE.TPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("IMPORTEN03").Value)), "", RTrim(row.Cells("IMPORTEN03").Value))    '9
            ELTBCARGADETASIENTOBE.MONEDA = IIf(IsDBNull(RTrim(row.Cells("MONEDAN03").Value)), "", RTrim(row.Cells("MONEDAN03").Value))              '10
            ELTBCARGADETASIENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells("SIGNON03").Value)), "", RTrim(row.Cells("SIGNON03").Value))                 '11
            ELTBCARGADETASIENTOBE.T_CAMB = IIf(IsDBNull(RTrim(row.Cells("T_CAMBN03").Value)), "", RTrim(row.Cells("T_CAMBN03").Value))              '12
            ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA = IIf(IsDBNull(RTrim(row.Cells("DOLARESN03").Value)), "", RTrim(row.Cells("DOLARESN03").Value))   '13
            ELTBCARGADETASIENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells("PROVEEDORN03").Value)), "", RTrim(row.Cells("PROVEEDORN03").Value))     '14
            ELTBCARGADETASIENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells("CTCT_CODN03").Value)), "", RTrim(row.Cells("CTCT_CODN03").Value))     '15
            ELTBCARGADETASIENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_CODN03").Value)), "", RTrim(row.Cells("ART_CODN03").Value))         '16
            ELTBCARGADETASIENTOBE.X_RET = IIf(IsDBNull(RTrim(row.Cells("X_RETN03").Value)), "", RTrim(row.Cells("X_RETN03").Value))               '17
            ELTBCARGADETASIENTOBE.STATUS = IIf(IsDBNull(RTrim(row.Cells("STATUSN03").Value)), "", RTrim(row.Cells("STATUSN03").Value))            '18
            ELTBCARGADETASIENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells("FEC_ENTN03").Value)), "", RTrim(row.Cells("FEC_ENTN03").Value))               '0


            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF                  '0
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF              '1
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF              '2
            cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF1                '3
            cmd.Parameters.Add("@SER_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF1            '4
            cmd.Parameters.Add("@NRO_DOC_REF1", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF1            '5
            cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_GEN                         '6
            cmd.Parameters.Add("@CUENTA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA                        '7
            cmd.Parameters.Add("@CUENTA_DEST", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CUENTA_DEST              '8
            cmd.Parameters.Add("@TPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TPRECIO_COMPRA          '9
            cmd.Parameters.Add("@MONEDA", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.MONEDA                        '10
            cmd.Parameters.Add("@SIGNO", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SIGNO                          '11
            cmd.Parameters.Add("@T_CAMB", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.T_CAMB                          '12
            cmd.Parameters.Add("@TDPRECIO_COMPRA", OracleDbType.Double).Value = ELTBCARGADETASIENTOBE.TDPRECIO_COMPRA        '13
            cmd.Parameters.Add("@PROVEEDOR", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.PROVEEDOR                  '14
            cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.CTCT_COD                    '15
            'cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.ART_COD                      '16
            cmd.Parameters.Add("@X_RET", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.X_RET                          '17
            cmd.Parameters.Add("@STATUS", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.STATUS                        '18
            cmd.Parameters.Add("@FEC_ENT", OracleDbType.Date).Value = ELTBCARGADETASIENTOBE.FEC_ENT                     '19
            cmd.Parameters.Add("@T_OPE_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_OPE_COD                     '19
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Public Sub DeleteRow(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBCARGAASIENTO_DELROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_DOC_REF                  '0
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.SER_DOC_REF              '1
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.NRO_DOC_REF              '2
        cmd.Parameters.Add("@T_OPE_COD", OracleDbType.Varchar2).Value = ELTBCARGADETASIENTOBE.T_OPE_COD                     '19
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
End Class
