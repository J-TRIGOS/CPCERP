Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class T_MOVINVDAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE

    'Funcion que me ve permitir generar el codigo 


    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal T_MOVINVBE As T_MOVINVBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_T_MOVINV_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = T_MOVINVBE.cod
        cmd.Parameters.Add("@costo", OracleDbType.Varchar2).Value = T_MOVINVBE.costo
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = T_MOVINVBE.nom
        cmd.Parameters.Add("@x_tran", OracleDbType.Varchar2).Value = T_MOVINVBE.x_tran
        cmd.Parameters.Add("@docmov", OracleDbType.Varchar2).Value = T_MOVINVBE.docmov
        cmd.Parameters.Add("@ser_mov", OracleDbType.Varchar2).Value = T_MOVINVBE.ser_mov
        cmd.Parameters.Add("@drefmov", OracleDbType.Varchar2).Value = T_MOVINVBE.drefmov
        cmd.Parameters.Add("@flag", OracleDbType.Varchar2).Value = T_MOVINVBE.flag
        cmd.Parameters.Add("@cod_ope", OracleDbType.Varchar2).Value = T_MOVINVBE.cod_ope
        cmd.ExecuteNonQuery()

        cmd.Dispose()


    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal T_MOVINVBE As T_MOVINVBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_T_MOVINV_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pcod", OracleDbType.Varchar2).Value = T_MOVINVBE.cod
        cmd.Parameters.Add("pcosto", OracleDbType.Varchar2).Value = T_MOVINVBE.costo
        cmd.Parameters.Add("pnom", OracleDbType.Varchar2).Value = T_MOVINVBE.nom
        cmd.Parameters.Add("psigno", OracleDbType.Varchar2).Value = T_MOVINVBE.signo
        cmd.Parameters.Add("px_tran", OracleDbType.Varchar2).Value = T_MOVINVBE.x_tran
        cmd.Parameters.Add("pdocmov", OracleDbType.Varchar2).Value = T_MOVINVBE.docmov
        cmd.Parameters.Add("pser_mov", OracleDbType.Varchar2).Value = T_MOVINVBE.ser_mov
        cmd.Parameters.Add("pdrefmov", OracleDbType.Varchar2).Value = T_MOVINVBE.drefmov
        cmd.Parameters.Add("pflag", OracleDbType.Varchar2).Value = T_MOVINVBE.flag
        cmd.Parameters.Add("pcod_ope", OracleDbType.Varchar2).Value = T_MOVINVBE.cod_ope

        cmd.ExecuteNonQuery()

        cmd.Dispose()


    End Sub


    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal T_MOVINVBE As T_MOVINVBE, ByVal flagAccion As String) As String
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

                InsertRow(T_MOVINVBE, cn, sqlTrans)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(T_MOVINVBE, cn, sqlTrans)
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
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function ReporteKardex(ByVal flagAccion As String, ByVal sAño As String, ByVal sSubLinea As String, ByVal sCodAlm As String, ByVal estInv As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            If flagAccion = "kardex" Then
                MOVIM_DIFKARSTK(cn, sqlTrans, sAño, sSubLinea, sCodAlm)
            End If
            If flagAccion = "negativo" Then
                MOVIM_NEGATIVO(cn, sqlTrans, sAño, sSubLinea, sCodAlm)
            End If
            If flagAccion = "fisico" Then
                MOVIM_DIFKFISICO(cn, sqlTrans, sAño, sSubLinea, sCodAlm)
            End If
            If flagAccion = "fisico1" Then
                MOVIM_DIFKFISICO1(cn, sqlTrans, sAño, sSubLinea, sCodAlm)
            End If
            If flagAccion = "valorizado" Then
                MOVIM_DIFKVAL(cn, sqlTrans, sAño, sSubLinea, sCodAlm)
            End If
            If flagAccion = "TODOS" Then
                MOVIM_DIFKFISICO1_TODOS(cn, sqlTrans, sAño, sSubLinea, sCodAlm, estInv)
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
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    Public Function ReporteKardex1(ByVal flagAccion As String, ByVal sAño As String, ByVal sAño1 As String,
                                    ByVal sFEC As String, ByVal sFEC1 As String, ByVal sCodAlm As String,
                                   ByVal sSUBLINEA As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            If flagAccion = "kardex-todos" Then
                MOVIM_STKALL(cn, sqlTrans, sAño, sAño1, sFEC, sFEC1, sCodAlm, sSUBLINEA)
            ElseIf flagAccion = "kardex-conta" Then
                MOVIM_STKCON(cn, sqlTrans, sAño, sAño1, sFEC, sFEC1, sCodAlm, sSUBLINEA)
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
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function ReporteConsumos(ByVal flagAccion As String, ByVal sAño As String, ByVal AnchoMin As String, ByVal AnchoMax As String,
                            ByVal LargoMin As String, ByVal LargoMax As String, ByVal TmpMin As String,
                            ByVal TmpMax As String, ByVal EspMin As String, ByVal EspMax As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try

            If flagAccion = "consumos" Then
                MOVIM_CONSALL(cn, sqlTrans, sAño, AnchoMin, AnchoMax, LargoMin, LargoMax, TmpMin, TmpMax, EspMin, EspMax)
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
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_T_MOVINV_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_T_MOVINV_SelectAll", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Sub MOVIM_DIFKARSTK(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String, ByVal sSubLinea As String, ByVal sCodALm As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM EL_RPTDIFKARSTK"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_MOVIM_DIFKARSTK"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@ANNO", OracleDbType.Varchar2).Value = sAño
        cmd.Parameters.Add("@SUBLIN", OracleDbType.Varchar2).Value = sSubLinea
        cmd.Parameters.Add("@CODALM", OracleDbType.Varchar2).Value = sCodALm
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub MOVIM_CONSALL(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                            ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                            ByVal sAño As String, ByVal AnchoMin As String, ByVal AnchoMax As String,
                            ByVal LargoMin As String, ByVal LargoMax As String, ByVal TmpMin As String,
                            ByVal TmpMax As String, ByVal EspMin As String, ByVal EspMax As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM TMP_RPT_HOJA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_STOCK_HOJALATA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@ANNO", OracleDbType.Varchar2).Value = sAño
        cmd.Parameters.Add("@AnchoMin", OracleDbType.Varchar2).Value = AnchoMin
        cmd.Parameters.Add("@AnchoMax", OracleDbType.Varchar2).Value = AnchoMax
        cmd.Parameters.Add("@LargoMin", OracleDbType.Varchar2).Value = LargoMin
        cmd.Parameters.Add("@LargoMax", OracleDbType.Varchar2).Value = LargoMax
        cmd.Parameters.Add("@TmpMin", OracleDbType.Double).Value = TmpMin
        cmd.Parameters.Add("@TmpMax", OracleDbType.Double).Value = TmpMax
        cmd.Parameters.Add("@EspMin", OracleDbType.Varchar2).Value = EspMin
        cmd.Parameters.Add("@EspMax", OracleDbType.Varchar2).Value = EspMax
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub MOVIM_STKCON(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                            ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                            ByVal sAño As String, ByVal sAño1 As String,
                            ByVal sFEC As String, ByVal sFEC1 As String,
                             ByVal sCodALm As String, ByVal sSUBLINEA As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM ELRPTSTKFEC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBARTSTK_STKFEC1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@ANNO", OracleDbType.Varchar2).Value = sAño
        cmd.Parameters.Add("@ANNO1", OracleDbType.Varchar2).Value = sAño
        cmd.Parameters.Add("@FEC", OracleDbType.Varchar2).Value = sFEC
        cmd.Parameters.Add("@FEC1", OracleDbType.Varchar2).Value = sFEC1
        'cmd.Parameters.Add("@CODALM", OracleDbType.Varchar2).Value = sCodALm
        cmd.Parameters.Add("@sSUBLINEA", OracleDbType.Varchar2).Value = sSUBLINEA

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub MOVIM_STKALL(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                            ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                            ByVal sAño As String, ByVal sAño1 As String,
                            ByVal sFEC As String, ByVal sFEC1 As String,
                             ByVal sCodALm As String, ByVal sSUBLINEA As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM ELRPTSTKFEC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBARTSTK_STKFEC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@ANNO", OracleDbType.Varchar2).Value = sAño
        cmd.Parameters.Add("@ANNO1", OracleDbType.Varchar2).Value = sAño
        cmd.Parameters.Add("@FEC", OracleDbType.Varchar2).Value = sFEC
        cmd.Parameters.Add("@FEC1", OracleDbType.Varchar2).Value = sFEC1
        cmd.Parameters.Add("@CODALM", OracleDbType.Varchar2).Value = sCodALm
        cmd.Parameters.Add("@sSUBLINEA", OracleDbType.Varchar2).Value = sSUBLINEA

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub MOVIM_DIFKFISICO(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String, ByVal sSubLinea As String, ByVal sCodALm As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM EL_RPTDIFKARSTK"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBARTSTK_DIFKARSTK"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@ANNO", OracleDbType.Varchar2).Value = sAño
        cmd.Parameters.Add("@SUBLIN", OracleDbType.Varchar2).Value = sSubLinea
        cmd.Parameters.Add("@CODALM", OracleDbType.Varchar2).Value = sCodALm
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub MOVIM_DIFKFISICO1(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String, ByVal sSubLinea As String, ByVal sCodALm As String)
        Dim f As Date = sAño
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM EL_RPTDIFKARSTK"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBARTSTK_DIFKARSTK2"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@ANNO", OracleDbType.Date).Value = f
        cmd.Parameters.Add("@SUBLIN", OracleDbType.Varchar2).Value = Mid(sSubLinea, 1, 4)
        cmd.Parameters.Add("@CODALM", OracleDbType.Varchar2).Value = sCodALm
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Public Sub MOVIM_DIFKFISICO1_TODOS(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String, ByVal sSubLinea As String, ByVal sCodALm As String, ByVal estInv As String)
        'Dim f As Date = sAño
        If estInv = 1 Then
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBARTSTK_PRUEBA_INV"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pFEC", OracleDbType.NVarchar2).Value = sSubLinea
            cmd.Parameters.Add("@pSUBLIN", OracleDbType.NVarchar2).Value = sAño
            cmd.Parameters.Add("@pCODALM", OracleDbType.NVarchar2).Value = sCodALm
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBARTSTK_PRUEBA"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pFEC", OracleDbType.NVarchar2).Value = sSubLinea
            cmd.Parameters.Add("@pSUBLIN", OracleDbType.NVarchar2).Value = sAño
            cmd.Parameters.Add("@pCODALM", OracleDbType.NVarchar2).Value = sCodALm
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If




    End Sub
    Public Sub MOVIM_DIFKVAL(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String, ByVal sSubLinea As String, ByVal sCodALm As String)
        Dim f As Date = sAño
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM EL_RPTDIFKARSTK"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBARTSTK_DIFKARSTKVAL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("@ANNO", OracleDbType.Varchar2).Value = sAño
        'cmd.Parameters.Add("@SUBLIN", OracleDbType.Varchar2).Value = sSubLinea
        'cmd.Parameters.Add("@CODALM", OracleDbType.Varchar2).Value = sCodALm
        cmd.Parameters.Add("@ANNO", OracleDbType.Date).Value = f
        cmd.Parameters.Add("@SUBLIN", OracleDbType.Varchar2).Value = Mid(sSubLinea, 1, 4)
        cmd.Parameters.Add("@CODALM", OracleDbType.Varchar2).Value = sCodALm
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub MOVIM_NEGATIVO(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal sAño As String, ByVal sSubLinea As String,
                          ByVal sCodAlm As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM EL_RPTKARNEGATIVO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_MOVIM_NEGATIVO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@ANNO", OracleDbType.Varchar2).Value = sAño
        cmd.Parameters.Add("@SUBLIN", OracleDbType.Varchar2).Value = sSubLinea
        cmd.Parameters.Add("@CodAlm", OracleDbType.Varchar2).Value = sCodAlm
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function Select_TMOVINV() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_T_MOVINV_DESCRI", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarFechaCorte(ByVal mes As String, ByVal anho As String, ByVal sublinea As String, ByVal almacen As String, ByVal linea As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_FECHA_CORTE", {New Oracle.ManagedDataAccess.Client.OracleParameter("MMES", mes),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("MSUBLINEA", sublinea),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("MALMACEN", almacen),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("MLINEA", linea)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class

