Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELCONTRATODAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelPerAll(ByVal nro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PERCONTRATO_All", {New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", nro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAll(ByVal Anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CONTRATO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", Anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarLinea(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_LINEA_CLIENTE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read

                If IsDBNull(dr.GetString(0)) Then
                    sNomArt = ""
                Else
                    sNomArt = dr.GetString(0)
                End If
            End While
        End Using
        Return sNomArt
    End Function

    Public Function ContarRegistros() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TAREO_CONTAREG", {})
            While dr.Read

                sNomArt = dr.GetString(0)

            End While
        End Using
        Return sNomArt
    End Function

    Public Function SelectVendedor() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_VENDEDOR", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectPerCOD(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PERSONAL_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCondiPago() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_FPAGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectDgvProv(ByVal sMesAño As String, ByVal sProd As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROVISION_VACASEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sProd),
                                                                                                             New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sMesAño)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectDgvProvCTS(ByVal sMesAño As String, ByVal sProd As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROVISION_VACACTSSEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sProd),
                                                                                                             New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sMesAño)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectDgvProvGRA(ByVal sMesAño As String, ByVal sProd As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROVISION_VACAGRASEL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sProd),
                                                                                                             New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sMesAño)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectComPer(ByVal pPRDO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROVISION_COMPER", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pPRDO", pPRDO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectHorNocPer(ByVal pPRDO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROVISION_HORNOCPER", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pPRDO", pPRDO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectHorNocPer1(ByVal pPRDO As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_PROVISION_HORNOCPER1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pPRDO", pPRDO)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectPais() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_PAIS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectPaisCod(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_PAIS_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectActi_Serv() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_COMBO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CONTRATO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowGrid(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TAREO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCIIU() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_CIIU", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectUbigeo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTE_UBIGEO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMaxTransp() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CLIENTE_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function VerificarRepetido(ByVal Code As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CLIENTE_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Public Function SelectVendeCod(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_VENDE_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCondicionCod(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_CONDICION_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Private Sub InsertRow(ByVal ELCONTRATOBE As ELCONTRATOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CONTRATO_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELCONTRATOBE.f_ini = IIf(IsDBNull(RTrim(row.Cells("F_INI").Value)), "", RTrim(row.Cells("F_INI").Value))
            ELCONTRATOBE.f_fin = IIf(IsDBNull(RTrim(row.Cells("F_FIN").Value)), "", RTrim(row.Cells("F_FIN").Value))
            ELCONTRATOBE.dni = IIf(IsDBNull(RTrim(row.Cells("DNI").Value)), "", RTrim(row.Cells("DNI").Value))
            ELCONTRATOBE.estado = "H"
            ELCONTRATOBE.indice = 0

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@f_ini", OracleDbType.Date).Value = ELCONTRATOBE.f_ini
            cmd.Parameters.Add("@f_fin", OracleDbType.Date).Value = ELCONTRATOBE.f_fin
            cmd.Parameters.Add("@dni", OracleDbType.Varchar2).Value = ELCONTRATOBE.dni
            'cmd.Parameters.Add("@fecha_ing", OracleDbType.Date).Value = fecha_ing
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu  'cod usu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro el contrato de : " + ELCONTRATOBE.dni
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELCONTRATOBE As ELCONTRATOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CONTRATO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        For Each row As DataGridViewRow In dgtareo.Rows
            ELCONTRATOBE.dni = IIf(IsDBNull(RTrim(row.Cells("DNI").Value)), "", RTrim(row.Cells("DNI").Value))
            ELCONTRATOBE.estado = "M"
            ELCONTRATOBE.indice = IIf(IsDBNull(RTrim(row.Cells("INDICE").Value)), "", RTrim(row.Cells("INDICE").Value))
        Next
        cmd.Parameters.Add("@f_ini", OracleDbType.Date).Value = ELCONTRATOBE.f_ini
        cmd.Parameters.Add("@f_fin", OracleDbType.Date).Value = ELCONTRATOBE.f_fin
        cmd.Parameters.Add("@dni", OracleDbType.Varchar2).Value = ELCONTRATOBE.dni
        cmd.Parameters.Add("@estado", OracleDbType.Varchar2).Value = ELCONTRATOBE.estado
        cmd.Parameters.Add("@indice", OracleDbType.Varchar2).Value = ELCONTRATOBE.indice
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELCONTRATOBE.dni
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELCONTRATOBE As ELTBTAREOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TAREO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBTAREOBE.cod
        'cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = ELTBTAREOBE.fecha
        'cmd.Parameters.Add("@id", OracleDbType.Varchar2).Value = ELTBTAREOBE.id
        cmd.ExecuteNonQuery()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = "0000"  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se eliminó la asistencia : " + ELTBTAREOBE.cod + "-" + ELTBTAREOBE.fecha
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Public Function SaveRow(ByVal ELCONTRATOBE As ELCONTRATOBE, ByVal flagAccion As String, ByVal dgtareo As DataGridView) As String
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
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo

                InsertRow(ELCONTRATOBE, cn, sqlTrans, dgtareo)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELCONTRATOBE, cn, sqlTrans, dgtareo)
            End If

            If flagAccion = "E" Then
                'DeleteRow(ELCONTRATOBE, cn, sqlTrans)
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
            If resultado = "OK" And flagAccion <> "E" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function PROGVACA(ByVal PRDO As String, ByVal flagaccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction
        Try
            If flagaccion = "RPT" Then
                ProgramaVaca(dg, cn, sqlTrans)
            ElseIf flagaccion = "E" Then
                LimpiarProv(PRDO, cn, sqlTrans)
            ElseIf flagaccion = "RPT1" Then
                ProgramaVaca1(dg, cn, sqlTrans)
            ElseIf flagaccion = "RPT2" Then
                ProgramaVaca2(dg, cn, sqlTrans)
            End If

            If flagaccion = "COM" Then
                ActCom(dg, cn, sqlTrans, PRDO)
            End If

            If flagaccion = "HENOC" Then
                HENOC(dg, cn, sqlTrans, PRDO)
            End If

            If flagaccion = "HEX" Then
                HEX(dg, cn, sqlTrans, PRDO)
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
    Public Sub ProgramaVaca(ByVal dg As DataGridView,
                            ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim f As Date
        For Each row As DataGridViewRow In dg.Rows
            f = IIf(IsDBNull(RTrim(row.Cells("FEC_ING").Value)), "", RTrim(row.Cells("FEC_ING").Value))
            Dim s As Date
            If IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value)) <> "" Then
                s = IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value))
            End If
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            If IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value)) <> "" Then
                cmd.CommandText = "SP_PROVISION_VACAX"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("per_cod").Value)), "", RTrim(row.Cells("per_cod").Value))
                cmd.Parameters.Add("@ccosto_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ccosto_cod").Value)), "", RTrim(row.Cells("ccosto_cod").Value))
                cmd.Parameters.Add("@NVO_MONTO_PROV", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("NVO_MONTO_PROV").Value)), 0, RTrim(row.Cells("NVO_MONTO_PROV").Value))
                cmd.Parameters.Add("@CPTO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("CPTO_COD").Value)), "", RTrim(row.Cells("CPTO_COD").Value))
                cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value = f
                'cmd.Parameters.Add("@FEC_ICESE", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value))

                cmd.Parameters.Add("@M", OracleDbType.Varchar2).Value = s.Month
                cmd.Parameters.Add("@D", OracleDbType.Varchar2).Value = s.Day
                cmd.Parameters.Add("@Y", OracleDbType.Varchar2).Value = s.Year
                'cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value =
                cmd.Parameters.Add("@PRDO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PRDO_COD").Value)), "", RTrim(row.Cells("PRDO_COD").Value))
                cmd.Parameters.Add("@MONTO_MEN_FIJO", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO_MEN_FIJO").Value)), 0, RTrim(row.Cells("MONTO_MEN_FIJO").Value))
                cmd.Parameters.Add("@CALC_DIA", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("CALC_DIA").Value)), 0, RTrim(row.Cells("CALC_DIA").Value))
                cmd.Parameters.Add("@PAGO_LIQUID", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("PAGO_LIQUI").Value)), 0, RTrim(row.Cells("PAGO_LIQUI").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd.CommandText = "SP_PROVISION_VACA"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("per_cod").Value)), "", RTrim(row.Cells("per_cod").Value))
                cmd.Parameters.Add("@ccosto_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ccosto_cod").Value)), "", RTrim(row.Cells("ccosto_cod").Value))
                cmd.Parameters.Add("@NVO_MONTO_PROV", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("NVO_MONTO_PROV").Value)), 0, RTrim(row.Cells("NVO_MONTO_PROV").Value))
                cmd.Parameters.Add("@CPTO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("CPTO_COD").Value)), "", RTrim(row.Cells("CPTO_COD").Value))
                cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value = f
                'cmd.Parameters.Add("@FEC_ICESE", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value))

                cmd.Parameters.Add("@M", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@D", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@Y", OracleDbType.Varchar2).Value = ""
                'cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value =
                cmd.Parameters.Add("@PRDO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PRDO_COD").Value)), "", RTrim(row.Cells("PRDO_COD").Value))
                cmd.Parameters.Add("@MONTO_MEN_FIJO", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO_MEN_FIJO").Value)), 0, RTrim(row.Cells("MONTO_MEN_FIJO").Value))
                cmd.Parameters.Add("@CALC_DIA", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("CALC_DIA").Value)), 0, RTrim(row.Cells("CALC_DIA").Value))
                cmd.Parameters.Add("@PAGO_LIQUID", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("PAGO_LIQUI").Value)), 0, RTrim(row.Cells("PAGO_LIQUI").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

        Next
    End Sub
    Public Sub ActCom(ByVal dg As DataGridView,
                         ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal PRDO As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim f As Date
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROVISION_UPDCTSCM"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
            cmd.Parameters.Add("@PRDO", OracleDbType.Varchar2).Value = PRDO
            cmd.Parameters.Add("@monto", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), "", RTrim(row.Cells("MONTO").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


    End Sub
    Public Sub HENOC(ByVal dg As DataGridView,
                         ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal PRDO As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim f As Date
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROVISION_UPDHE"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
            cmd.Parameters.Add("@PRDO", OracleDbType.Varchar2).Value = PRDO
            cmd.Parameters.Add("@monto", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), "", RTrim(row.Cells("MONTO").Value))
            cmd.Parameters.Add("@CPTO_COD", OracleDbType.Int32).Value = IIf(IsDBNull(RTrim(row.Cells("CPTO_COD").Value)), 0, RTrim(row.Cells("CPTO_COD").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


    End Sub

    Public Sub HEX(ByVal dg As DataGridView,
                         ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal PRDO As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim f As Date
        For Each row As DataGridViewRow In dg.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PROVISION_UPDHEX"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PER_COD").Value)), "", RTrim(row.Cells("PER_COD").Value))
            cmd.Parameters.Add("@PRDO", OracleDbType.Varchar2).Value = PRDO
            cmd.Parameters.Add("@monto", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), "", RTrim(row.Cells("MONTO").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


    End Sub
    Public Sub ProgramaVaca1(ByVal dg As DataGridView,
                            ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim f As Date
        For Each row As DataGridViewRow In dg.Rows
            f = IIf(IsDBNull(RTrim(row.Cells("FEC_ING").Value)), "", RTrim(row.Cells("FEC_ING").Value))
            Dim s As Date
            If IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value)) <> "" Then
                s = IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value))
            End If
            If IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value)) <> "" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_PROVISION_VACACTSX"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("per_cod").Value)), "", RTrim(row.Cells("per_cod").Value))
                cmd.Parameters.Add("@ccosto_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ccosto_cod").Value)), "", RTrim(row.Cells("ccosto_cod").Value))
                cmd.Parameters.Add("@NVO_MONTO_PROV", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("NVO_MONTO_PROV").Value)), 0, RTrim(row.Cells("NVO_MONTO_PROV").Value))
                cmd.Parameters.Add("@CPTO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("CPTO_COD").Value)), "", RTrim(row.Cells("CPTO_COD").Value))
                cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value = f
                'cmd.Parameters.Add("@FEC_ICESE", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value))
                cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = s.Month
                cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = s.Day
                cmd.Parameters.Add("@y", OracleDbType.Varchar2).Value = s.Year
                cmd.Parameters.Add("@PRDO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PRDO_COD").Value)), "", RTrim(row.Cells("PRDO_COD").Value))
                cmd.Parameters.Add("@MONTO_MEN_FIJO", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO_MEN_FIJO").Value)), 0, RTrim(row.Cells("MONTO_MEN_FIJO").Value))
                cmd.Parameters.Add("@CALC_DIA", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("CALC_DIA").Value)), 0, RTrim(row.Cells("CALC_DIA").Value))
                cmd.Parameters.Add("@PAGO_LIQUID", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("PAGO_LIQUI").Value)), 0, RTrim(row.Cells("PAGO_LIQUI").Value))
                cmd.Parameters.Add("@PAGO_LIQUID", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO_ULT_GRATI").Value)), 0, RTrim(row.Cells("MONTO_ULT_GRATI").Value))
                cmd.Parameters.Add("@PAGO_LIQUID", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("PRDO_ULTIMA_GRATI").Value)), 0, RTrim(row.Cells("PRDO_ULTIMA_GRATI").Value))
                cmd.Parameters.Add("@COMISION", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("COMISION").Value)), 0, RTrim(row.Cells("COMISION").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_PROVISION_VACACTS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("per_cod").Value)), "", RTrim(row.Cells("per_cod").Value))
                cmd.Parameters.Add("@ccosto_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ccosto_cod").Value)), "", RTrim(row.Cells("ccosto_cod").Value))
                cmd.Parameters.Add("@NVO_MONTO_PROV", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("NVO_MONTO_PROV").Value)), 0, RTrim(row.Cells("NVO_MONTO_PROV").Value))
                cmd.Parameters.Add("@CPTO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("CPTO_COD").Value)), "", RTrim(row.Cells("CPTO_COD").Value))
                cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value = f
                'cmd.Parameters.Add("@FEC_ICESE", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value))
                cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@y", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@PRDO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PRDO_COD").Value)), "", RTrim(row.Cells("PRDO_COD").Value))
                cmd.Parameters.Add("@MONTO_MEN_FIJO", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO_MEN_FIJO").Value)), 0, RTrim(row.Cells("MONTO_MEN_FIJO").Value))
                cmd.Parameters.Add("@CALC_DIA", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("CALC_DIA").Value)), 0, RTrim(row.Cells("CALC_DIA").Value))
                cmd.Parameters.Add("@PAGO_LIQUID", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("PAGO_LIQUI").Value)), 0, RTrim(row.Cells("PAGO_LIQUI").Value))
                cmd.Parameters.Add("@PAGO_LIQUID", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO_ULT_GRATI").Value)), 0, RTrim(row.Cells("MONTO_ULT_GRATI").Value))
                cmd.Parameters.Add("@PAGO_LIQUID", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("PRDO_ULTIMA_GRATI").Value)), 0, RTrim(row.Cells("PRDO_ULTIMA_GRATI").Value))
                cmd.Parameters.Add("@COMISION", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("COMISION").Value)), 0, RTrim(row.Cells("COMISION").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

        Next
    End Sub
    Public Sub ProgramaVaca2(ByVal dg As DataGridView,
                            ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim f As Date
        For Each row As DataGridViewRow In dg.Rows
            f = IIf(IsDBNull(RTrim(row.Cells("FEC_ING").Value)), "", RTrim(row.Cells("FEC_ING").Value))
            Dim s As Date
            If IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value)) <> "" Then
                s = IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value))
            End If
            If IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value)) <> "" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_PROVISION_VACAGRAX"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("per_cod").Value)), "", RTrim(row.Cells("per_cod").Value))
                cmd.Parameters.Add("@ccosto_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ccosto_cod").Value)), "", RTrim(row.Cells("ccosto_cod").Value))
                cmd.Parameters.Add("@NVO_MONTO_PROV", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("NVO_MONTO_PROV").Value)), 0, RTrim(row.Cells("NVO_MONTO_PROV").Value))
                cmd.Parameters.Add("@CPTO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("CPTO_COD").Value)), "", RTrim(row.Cells("CPTO_COD").Value))
                cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value = f
                cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = s.Month
                cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = s.Day
                cmd.Parameters.Add("@y", OracleDbType.Varchar2).Value = s.Year
                'cmd.Parameters.Add("@FEC_ICESE", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value))
                cmd.Parameters.Add("@PRDO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PRDO_COD").Value)), "", RTrim(row.Cells("PRDO_COD").Value))
                cmd.Parameters.Add("@MONTO_MEN_FIJO", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO_MEN_FIJO").Value)), 0, RTrim(row.Cells("MONTO_MEN_FIJO").Value))
                cmd.Parameters.Add("@CALC_DIA", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("CALC_DIA").Value)), 0, RTrim(row.Cells("CALC_DIA").Value))
                cmd.Parameters.Add("@PAGO_LIQUID", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("PAGO_LIQUI").Value)), 0, RTrim(row.Cells("PAGO_LIQUI").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_PROVISION_VACAGRA"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("per_cod").Value)), "", RTrim(row.Cells("per_cod").Value))
                cmd.Parameters.Add("@ccosto_cod", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("ccosto_cod").Value)), "", RTrim(row.Cells("ccosto_cod").Value))
                cmd.Parameters.Add("@NVO_MONTO_PROV", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("NVO_MONTO_PROV").Value)), 0, RTrim(row.Cells("NVO_MONTO_PROV").Value))
                cmd.Parameters.Add("@CPTO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("CPTO_COD").Value)), "", RTrim(row.Cells("CPTO_COD").Value))
                cmd.Parameters.Add("@FEC_ING", OracleDbType.Date).Value = f
                cmd.Parameters.Add("@m", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@d", OracleDbType.Varchar2).Value = ""
                cmd.Parameters.Add("@y", OracleDbType.Varchar2).Value = ""
                'cmd.Parameters.Add("@FEC_ICESE", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("FEC_ICESE").Value)), "", RTrim(row.Cells("FEC_ICESE").Value))
                cmd.Parameters.Add("@PRDO_COD", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PRDO_COD").Value)), "", RTrim(row.Cells("PRDO_COD").Value))
                cmd.Parameters.Add("@MONTO_MEN_FIJO", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("MONTO_MEN_FIJO").Value)), 0, RTrim(row.Cells("MONTO_MEN_FIJO").Value))
                cmd.Parameters.Add("@CALC_DIA", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("CALC_DIA").Value)), 0, RTrim(row.Cells("CALC_DIA").Value))
                cmd.Parameters.Add("@PAGO_LIQUID", OracleDbType.Double).Value = IIf(IsDBNull(RTrim(row.Cells("PAGO_LIQUI").Value)), 0, RTrim(row.Cells("PAGO_LIQUI").Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()

            End If

        Next
    End Sub
    Public Sub LimpiarProv(ByVal PRDO As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM PER_PROV where cpto_cod='002-P' AND PRDO_COD=" & PRDO
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM PER_PROV where cpto_cod='001-P' AND PRDO_COD=" & PRDO
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "DELETE FROM PER_PROV where cpto_cod='003-P' AND PRDO_COD=" & PRDO
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()


    End Sub
End Class
