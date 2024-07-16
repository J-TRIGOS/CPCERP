Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBCTA_FACTURACIONDAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    'Public ELMVLOGSBE As New ELMVLOGSBE


    Private Sub InsertRow(ByVal ELTBCTA_FACTURACIONBE As ELTBCTA_FACTURACIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CTAFACTURACION_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase         
        cmd.Parameters.Add("@t_movinv_cod", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.t_movinv_cod
        cmd.Parameters.Add("@t_doc_cod", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.t_doc_cod
        cmd.Parameters.Add("@t_ope_cod", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.t_ope_cod
        cmd.Parameters.Add("@t_ope_anho", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.t_ope_anho
        cmd.Parameters.Add("@mon_cod", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.mon_cod
        cmd.Parameters.Add("@t_item", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.t_item
        cmd.Parameters.Add("@cod_ini", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cod_ini
        cmd.Parameters.Add("@cod_fin", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cod_fin
        cmd.Parameters.Add("@cta_brut_h", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cta_brut_h
        cmd.Parameters.Add("@cta_igv_h", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cta_igv_h
        cmd.Parameters.Add("@cta_net_h", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cta_net_h
        cmd.Parameters.Add("@sec", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.sec
        cmd.Parameters.Add("@cta_brut_b", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cta_brut_b
        cmd.Parameters.Add("@cta_brut_o", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cta_brut_o
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu  'cod usu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro una cuenta de facturacion : " + ELTBCTA_FACTURACIONBE.cod_ini
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELTBCTA_FACTURACIONBE As ELTBCTA_FACTURACIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal Datos As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CTAFACTURACION_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_movinv_cod", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.t_movinv_cod
        cmd.Parameters.Add("@t_doc_cod", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.t_doc_cod
        cmd.Parameters.Add("@t_ope_cod", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.t_ope_cod
        cmd.Parameters.Add("@t_ope_anho", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.t_ope_anho
        cmd.Parameters.Add("@mon_cod", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.mon_cod
        cmd.Parameters.Add("@t_item", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.t_item
        cmd.Parameters.Add("@cod_ini", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cod_ini
        cmd.Parameters.Add("@cod_fin", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cod_fin
        cmd.Parameters.Add("@cta_brut_h", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cta_brut_h
        cmd.Parameters.Add("@cta_igv_h", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cta_igv_h
        cmd.Parameters.Add("@cta_net_h", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cta_net_h
        cmd.Parameters.Add("@sec", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.sec
        cmd.Parameters.Add("@cta_brut_b", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cta_brut_b
        cmd.Parameters.Add("@cta_brut_o", OracleDbType.Varchar2).Value = ELTBCTA_FACTURACIONBE.cta_brut_o

        Dim array As String() = Datos.Split("|")
        cmd.Parameters.Add("@t_movinv_codw", OracleDbType.Varchar2).Value = array(0).ToString
        cmd.Parameters.Add("@t_doc_codw", OracleDbType.Varchar2).Value = array(1).ToString
        cmd.Parameters.Add("@t_ope_codw", OracleDbType.Varchar2).Value = array(2).ToString
        cmd.Parameters.Add("@t_ope_anhow", OracleDbType.Varchar2).Value = array(3).ToString
        cmd.Parameters.Add("@mon_codw", OracleDbType.Varchar2).Value = array(4).ToString
        cmd.Parameters.Add("@t_itemw", OracleDbType.Varchar2).Value = array(5).ToString
        cmd.Parameters.Add("@cod_iniw", OracleDbType.Varchar2).Value = array(6).ToString
        cmd.Parameters.Add("@cod_finw", OracleDbType.Varchar2).Value = array(7).ToString
        cmd.Parameters.Add("@secw", OracleDbType.Varchar2).Value = array(8).ToString
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu  'cod usu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizó una cuenta de facturacion : " + ELTBCTA_FACTURACIONBE.cod_ini
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBCTA_FACTURACIONBE As ELTBCTA_FACTURACIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CLIENTE_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBCLIENTEBE.cod
        cmd.ExecuteNonQuery()

    End Sub
    Public Sub InsertRegistro(ByVal sanho As String)
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim anho_ant As Integer
        anho_ant = sanho
        Try

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CUENTA_FC_INSERTROW"
            cmd.Connection = cn
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
            cmd.Parameters.Add("anho_ant", OracleDbType.Double).Value = anho_ant - 2
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'actualizar 00-PLAN
            'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            'cmd.CommandText = "SP_CUENTA_ACTUALIZAROW"
            'cmd.Connection = cn
            'cmd.Transaction = sqlTrans
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("anho", OracleDbType.Varchar2).Value = sanho
            'cmd.Parameters.Add("anho_ant", OracleDbType.Double).Value = anho_ant - 2
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()

            sqlTrans.Commit()
            'resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            'resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            'resultado = ex.Message
        Finally
            'If resultado = "OK" Then
            'cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

    End Sub

    Public Function SaveRow(ByVal ELTBCTA_FACTURACIONBE As ELTBCTA_FACTURACIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal Datos As String) As String
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
                InsertRow(ELTBCTA_FACTURACIONBE, ELMVLOGSBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBCTA_FACTURACIONBE, ELMVLOGSBE, cn, sqlTrans, Datos)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBCTA_FACTURACIONBE, ELMVLOGSBE, cn, sqlTrans)
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
            'cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
    Public Function SelectAll(ByVal Anio As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_FACTURACION_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anio", Anio)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
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
    Public Function SelectTipo_Mov() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_FACTURACION_MOVIV", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectArticulosAsiento(ByVal sAnho As String, ByVal sMesanho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VERIFICAR_ASIENTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sAnho", sAnho), New Oracle.ManagedDataAccess.Client.OracleParameter("@sMesanho", sMesanho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectArtncnd(ByVal sAnho As String, ByVal sMesanho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_VERIFICAR_ASIENTONCND", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sAnho", sAnho),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@sMesanho", sMesanho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function DatosFactura(ByVal sCode As String, ByVal sAnho As String, ByVal aMes As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DATOS_FACTURA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@sAnho", sAnho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@aMes", aMes)})
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

    Public Function SelectT_Moneda() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_TIPOCAMBIO_COMBO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerificarRegistro(ByVal sanho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_FAC_VERIFICAR_REG", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sanho", sanho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal gsCode As String, ByVal gsCode2 As String, ByVal gsCode3 As String, ByVal gsCode4 As String, ByVal gsCode5 As String, ByVal gLinea As String, ByVal gSubLineas As String, ByVal gCodAct As String, ByVal gArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_FACTURACION_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", gsCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode2", gsCode2),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode3", gsCode3), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode4", gsCode4),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode5", gsCode5), New Oracle.ManagedDataAccess.Client.OracleParameter("@glinea", gLinea),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@gsublineas", gSubLineas), New Oracle.ManagedDataAccess.Client.OracleParameter("@gcodact", gCodAct),
                                                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@gart", gArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow1(ByVal sCode As String, ByVal sSer As String, ByVal sNum As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_FACTURACION_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", sCode),
                                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode3", sSer),
                                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode5", sNum)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTEGRID_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@opcion", sOpcion)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectArticulo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_ART", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCtas(ByVal fecyear As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_CTAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", fecyear)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectCtasLineaEvanse() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_CTAS_ENVASES", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectTipMovCOD(ByVal Code As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_FACTURACION_MOVIVCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMonCOD(ByVal Code As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_FACTURACION_MONCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMaxCtafacturacion(ByVal Code As String, ByVal Code2 As String, ByVal Code3 As String, ByVal Code4 As String, ByVal Code5 As String, ByVal Linea As String, ByVal SubLineas As String, ByVal CodAct As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CTAFACTURACION_LASTCOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode2", Code2),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode3", Code3), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode4", Code4),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode5", Code5), New Oracle.ManagedDataAccess.Client.OracleParameter("@glinea", Linea),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@gsublineas", SubLineas), New Oracle.ManagedDataAccess.Client.OracleParameter("@gcodact", CodAct)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectCTAFC(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTAFC_SELNOM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt

    End Function
End Class
