Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class CTS_DAL
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    Public Function SelectRowAll(ByVal sANHO As String, ByVal sMES As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTSSELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sANHO", sANHO),
                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@sMES", sMES)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectRow(ByVal sANHO As String, ByVal sMES As String, ByVal sPER_COD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTSSELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sANHO", sANHO),
                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@sMES", sMES),
                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@sPER_COD", sPER_COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal CTSBE As CTSBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal pFVA As String) As String
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
                InsertRow(CTSBE, ELMVLOGSBE, cn, sqlTrans, pFVA)
            End If
            If flagAccion = "M" Then
                UPDRow(CTSBE, ELMVLOGSBE, cn, sqlTrans, pFVA)
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
    Private Sub InsertRow(ByVal CTSBE As CTSBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal pFVA As String)
        Dim contenedor As String
        'Dim nro As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        If pFVA = "" Then
            cmd.CommandText = "SP_CTS_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = CTSBE.PER_COD
            cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = Trim(CTSBE.USUARIO)
            cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = Trim(CTSBE.ANHO)
            cmd.Parameters.Add("@MONTO", OracleDbType.Double).Value = Trim(CTSBE.MONTO)
            cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = Trim(CTSBE.MES)
            cmd.Parameters.Add("@HEXTRAS", OracleDbType.Double).Value = Trim(CTSBE.HEXTRAS)
            cmd.Parameters.Add("@GRATI", OracleDbType.Double).Value = Trim(CTSBE.GRATI)
            cmd.Parameters.Add("@MESES", OracleDbType.Double).Value = Trim(CTSBE.MESES)
            cmd.Parameters.Add("@DIAS", OracleDbType.Double).Value = Trim(CTSBE.DIAS)
            cmd.Parameters.Add("@NOMBRE", OracleDbType.Varchar2).Value = Trim(CTSBE.NOMBRE)
            cmd.Parameters.Add("@INTERES", OracleDbType.Double).Value = Trim(CTSBE.INTERES)
            cmd.Parameters.Add("@PRDO_PAGO", OracleDbType.Double).Value = Trim(CTSBE.PRDO_PAGO)
            cmd.Parameters.Add("@VACACIONES", OracleDbType.Double).Value = Trim(CTSBE.VACACIONES)
            cmd.Parameters.Add("@MONTO_CTS", OracleDbType.Double).Value = Trim(CTSBE.MONTO_CTS)
            cmd.Parameters.Add("@COMISION", OracleDbType.Double).Value = Trim(CTSBE.COMISION)
            cmd.Parameters.Add("@SUBSIDIO", OracleDbType.Double).Value = Trim(CTSBE.SUBSIDIO)
            cmd.Parameters.Add("@OTROS", OracleDbType.Double).Value = Trim(CTSBE.OTROS)
            cmd.Parameters.Add("@FEC_INI", OracleDbType.Varchar2).Value = Trim(CTSBE.FEC_INI)
            cmd.Parameters.Add("@FEC_FIN", OracleDbType.Varchar2).Value = Trim(CTSBE.FEC_FIN)
            cmd.Parameters.Add("@DSCTO_QUINTA", OracleDbType.Double).Value = Trim(CTSBE.DSCTO_QUINTA)
            cmd.Parameters.Add("@OTROS_DSCTOS", OracleDbType.Double).Value = Trim(CTSBE.OTROS_DSCTOS)
            cmd.Parameters.Add("@PROV_ACUM_CTS", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_CTS)
            cmd.Parameters.Add("@PROV_ACUM_VACA", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_VACA)
            cmd.Parameters.Add("@PROV_ACUM_GRATI", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_GRATI)
            cmd.Parameters.Add("@DIF_AJUSTE_CTS", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_CTS)
            cmd.Parameters.Add("@DIF_AJUSTE_GRATI", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_GRATI)
            cmd.Parameters.Add("@DIF_AJUSTE_VACA", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_VACA)
            cmd.Parameters.Add("@MONTO_PREST", OracleDbType.Double).Value = Trim(CTSBE.MONTO_PREST)
            cmd.Parameters.Add("@MONTO_PREST", OracleDbType.Double).Value = pFVA

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd.CommandText = "SP_CTS_INSERT1"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = CTSBE.PER_COD
            cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = Trim(CTSBE.USUARIO)
            cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = Trim(CTSBE.ANHO)
            cmd.Parameters.Add("@MONTO", OracleDbType.Double).Value = Trim(CTSBE.MONTO)
            cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = Trim(CTSBE.MES)
            cmd.Parameters.Add("@HEXTRAS", OracleDbType.Double).Value = Trim(CTSBE.HEXTRAS)
            cmd.Parameters.Add("@GRATI", OracleDbType.Double).Value = Trim(CTSBE.GRATI)
            cmd.Parameters.Add("@MESES", OracleDbType.Double).Value = Trim(CTSBE.MESES)
            cmd.Parameters.Add("@DIAS", OracleDbType.Double).Value = Trim(CTSBE.DIAS)
            cmd.Parameters.Add("@NOMBRE", OracleDbType.Varchar2).Value = Trim(CTSBE.NOMBRE)
            cmd.Parameters.Add("@INTERES", OracleDbType.Double).Value = Trim(CTSBE.INTERES)
            cmd.Parameters.Add("@PRDO_PAGO", OracleDbType.Double).Value = Trim(CTSBE.PRDO_PAGO)
            cmd.Parameters.Add("@VACACIONES", OracleDbType.Double).Value = Trim(CTSBE.VACACIONES)
            cmd.Parameters.Add("@MONTO_CTS", OracleDbType.Double).Value = Trim(CTSBE.MONTO_CTS)
            cmd.Parameters.Add("@COMISION", OracleDbType.Double).Value = Trim(CTSBE.COMISION)
            cmd.Parameters.Add("@SUBSIDIO", OracleDbType.Double).Value = Trim(CTSBE.SUBSIDIO)
            cmd.Parameters.Add("@OTROS", OracleDbType.Double).Value = Trim(CTSBE.OTROS)
            cmd.Parameters.Add("@FEC_INI", OracleDbType.Date).Value = CTSBE.FEC_INI
            cmd.Parameters.Add("@FEC_FIN", OracleDbType.Date).Value = CTSBE.FEC_FIN
            cmd.Parameters.Add("@DSCTO_QUINTA", OracleDbType.Double).Value = Trim(CTSBE.DSCTO_QUINTA)
            cmd.Parameters.Add("@OTROS_DSCTOS", OracleDbType.Double).Value = Trim(CTSBE.OTROS_DSCTOS)
            cmd.Parameters.Add("@PROV_ACUM_CTS", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_CTS)
            cmd.Parameters.Add("@PROV_ACUM_VACA", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_VACA)
            cmd.Parameters.Add("@PROV_ACUM_GRATI", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_GRATI)
            cmd.Parameters.Add("@DIF_AJUSTE_CTS", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_CTS)
            cmd.Parameters.Add("@DIF_AJUSTE_GRATI", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_GRATI)
            cmd.Parameters.Add("@DIF_AJUSTE_VACA", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_VACA)
            cmd.Parameters.Add("@MONTO_PREST", OracleDbType.Double).Value = Trim(CTSBE.MONTO_PREST)
            cmd.Parameters.Add("@MONTO_PREST", OracleDbType.Double).Value = pFVA

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If



        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

    End Sub
    Private Sub UPDRow(ByVal CTSBE As CTSBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal pFVA As String)
        Dim contenedor As String
        'Dim nro As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        If pFVA = "" Then
            cmd.CommandText = "SP_CTS_INSERT"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = CTSBE.PER_COD
            cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = Trim(CTSBE.USUARIO)
            cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = Trim(CTSBE.ANHO)
            cmd.Parameters.Add("@MONTO", OracleDbType.Double).Value = Trim(CTSBE.MONTO)
            cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = Trim(CTSBE.MES)
            cmd.Parameters.Add("@HEXTRAS", OracleDbType.Double).Value = Trim(CTSBE.HEXTRAS)
            cmd.Parameters.Add("@GRATI", OracleDbType.Double).Value = Trim(CTSBE.GRATI)
            cmd.Parameters.Add("@MESES", OracleDbType.Double).Value = Trim(CTSBE.MESES)
            cmd.Parameters.Add("@DIAS", OracleDbType.Double).Value = Trim(CTSBE.DIAS)
            cmd.Parameters.Add("@NOMBRE", OracleDbType.Varchar2).Value = Trim(CTSBE.NOMBRE)
            cmd.Parameters.Add("@INTERES", OracleDbType.Double).Value = Trim(CTSBE.INTERES)
            cmd.Parameters.Add("@PRDO_PAGO", OracleDbType.Double).Value = Trim(CTSBE.PRDO_PAGO)
            cmd.Parameters.Add("@VACACIONES", OracleDbType.Double).Value = Trim(CTSBE.VACACIONES)
            cmd.Parameters.Add("@MONTO_CTS", OracleDbType.Double).Value = Trim(CTSBE.MONTO_CTS)
            cmd.Parameters.Add("@COMISION", OracleDbType.Double).Value = Trim(CTSBE.COMISION)
            cmd.Parameters.Add("@SUBSIDIO", OracleDbType.Double).Value = Trim(CTSBE.SUBSIDIO)
            cmd.Parameters.Add("@OTROS", OracleDbType.Double).Value = Trim(CTSBE.OTROS)
            cmd.Parameters.Add("@FEC_INI", OracleDbType.Varchar2).Value = Trim(CTSBE.FEC_INI)
            cmd.Parameters.Add("@FEC_FIN", OracleDbType.Varchar2).Value = Trim(CTSBE.FEC_FIN)
            cmd.Parameters.Add("@DSCTO_QUINTA", OracleDbType.Double).Value = Trim(CTSBE.DSCTO_QUINTA)
            cmd.Parameters.Add("@OTROS_DSCTOS", OracleDbType.Double).Value = Trim(CTSBE.OTROS_DSCTOS)
            cmd.Parameters.Add("@PROV_ACUM_CTS", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_CTS)
            cmd.Parameters.Add("@PROV_ACUM_VACA", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_VACA)
            cmd.Parameters.Add("@PROV_ACUM_GRATI", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_GRATI)
            cmd.Parameters.Add("@DIF_AJUSTE_CTS", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_CTS)
            cmd.Parameters.Add("@DIF_AJUSTE_GRATI", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_GRATI)
            cmd.Parameters.Add("@DIF_AJUSTE_VACA", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_VACA)
            cmd.Parameters.Add("@MONTO_PREST", OracleDbType.Double).Value = Trim(CTSBE.MONTO_PREST)
            cmd.Parameters.Add("@MONTO_PREST", OracleDbType.Double).Value = pFVA

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd.CommandText = "SP_CTS_INSERT1"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@PER_COD", OracleDbType.Varchar2).Value = CTSBE.PER_COD
            cmd.Parameters.Add("@USUARIO", OracleDbType.Varchar2).Value = Trim(CTSBE.USUARIO)
            cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = Trim(CTSBE.ANHO)
            cmd.Parameters.Add("@MONTO", OracleDbType.Double).Value = Trim(CTSBE.MONTO)
            cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = Trim(CTSBE.MES)
            cmd.Parameters.Add("@HEXTRAS", OracleDbType.Double).Value = Trim(CTSBE.HEXTRAS)
            cmd.Parameters.Add("@GRATI", OracleDbType.Double).Value = Trim(CTSBE.GRATI)
            cmd.Parameters.Add("@MESES", OracleDbType.Double).Value = Trim(CTSBE.MESES)
            cmd.Parameters.Add("@DIAS", OracleDbType.Double).Value = Trim(CTSBE.DIAS)
            cmd.Parameters.Add("@NOMBRE", OracleDbType.Varchar2).Value = Trim(CTSBE.NOMBRE)
            cmd.Parameters.Add("@INTERES", OracleDbType.Double).Value = Trim(CTSBE.INTERES)
            cmd.Parameters.Add("@PRDO_PAGO", OracleDbType.Double).Value = Trim(CTSBE.PRDO_PAGO)
            cmd.Parameters.Add("@VACACIONES", OracleDbType.Double).Value = Trim(CTSBE.VACACIONES)
            cmd.Parameters.Add("@MONTO_CTS", OracleDbType.Double).Value = Trim(CTSBE.MONTO_CTS)
            cmd.Parameters.Add("@COMISION", OracleDbType.Double).Value = Trim(CTSBE.COMISION)
            cmd.Parameters.Add("@SUBSIDIO", OracleDbType.Double).Value = Trim(CTSBE.SUBSIDIO)
            cmd.Parameters.Add("@OTROS", OracleDbType.Double).Value = Trim(CTSBE.OTROS)
            cmd.Parameters.Add("@FEC_INI", OracleDbType.Date).Value = CTSBE.FEC_INI
            cmd.Parameters.Add("@FEC_FIN", OracleDbType.Date).Value = CTSBE.FEC_FIN
            cmd.Parameters.Add("@DSCTO_QUINTA", OracleDbType.Double).Value = Trim(CTSBE.DSCTO_QUINTA)
            cmd.Parameters.Add("@OTROS_DSCTOS", OracleDbType.Double).Value = Trim(CTSBE.OTROS_DSCTOS)
            cmd.Parameters.Add("@PROV_ACUM_CTS", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_CTS)
            cmd.Parameters.Add("@PROV_ACUM_VACA", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_VACA)
            cmd.Parameters.Add("@PROV_ACUM_GRATI", OracleDbType.Double).Value = Trim(CTSBE.PROV_ACUM_GRATI)
            cmd.Parameters.Add("@DIF_AJUSTE_CTS", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_CTS)
            cmd.Parameters.Add("@DIF_AJUSTE_GRATI", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_GRATI)
            cmd.Parameters.Add("@DIF_AJUSTE_VACA", OracleDbType.Double).Value = Trim(CTSBE.DIF_AJUSTE_VACA)
            cmd.Parameters.Add("@MONTO_PREST", OracleDbType.Double).Value = Trim(CTSBE.MONTO_PREST)
            cmd.Parameters.Add("@MONTO_PREST", OracleDbType.Double).Value = pFVA

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If



        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

    End Sub
End Class
