Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELDECLARACIONDUADAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelGuiaAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_GUIASALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelEasyAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_EASYALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelTapaPlasAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_TPLASALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelTapaTeleAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_TTELEALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv(ByVal sT_doc1 As String, ByVal sS_doc1 As String, ByVal sN_doc1 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DECLARACION_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref1", sT_doc1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref1", sS_doc1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref1", sN_doc1)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListDua(ByVal sT_doc1 As String, ByVal sS_doc1 As String, ByVal sN_doc1 As String, ByVal articulo As String,
                               ByVal sFecha As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DECLARACION_ROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref1", sT_doc1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref1", sS_doc1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref1", sN_doc1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@articulo", articulo),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sFecha", sFecha)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectFacturasG() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DECLARACION_FACTURAS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal sARTCOD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DECLARACION_ROWSELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("@sARTCOD", sARTCOD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectGuias(ByVal Nroguia As String, ByVal Nroserie As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELEGUIAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nroguia", Nroguia),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@Nroserie", Nroserie)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectGetData(ByVal Nroguia As String, ByVal Nroserie As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CERTIFICA_GETDATA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nroguia", Nroguia), New Oracle.ManagedDataAccess.Client.OracleParameter("@Nroserie", Nroserie)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Public Function SelectGetDataEspe(ByVal Articulo As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CERTIFICA_GETDATAESPE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Articulo", Articulo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Public Function SelectGetLote(ByVal Nroguia As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CERTIFICA_GETLOTE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nroguia", Nroguia)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Public Function SelectGetDataEasy(ByVal producto As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CERTIFICA_GETDATAEASY", {New Oracle.ManagedDataAccess.Client.OracleParameter("@producto", producto)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Public Function SelectGetDataTapaPlas(ByVal producto As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CERTIFICA_GETDATAPLAS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@producto", producto)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Public Function SelectGetDataTapaTel(ByVal producto As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CERTIFICA_GETDATATELE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@producto", producto)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Public Function SelectGetFecha(ByVal fecha As String, ByVal nro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_GUIADESPACHO_GETFECHA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fecha", fecha),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", nro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectGetART_GETDATOS(ByVal fecha As String, ByVal articulo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_GUIADESPACHO_FEC_VAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fecha", fecha),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@articulo", articulo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectGetART_SUM_STK(ByVal fecha As String, ByVal fecha_fin As String, ByVal articulo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_GUIADESPACHO_SUM_STK", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fecha", fecha),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@fecha_fin", fecha_fin),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@articulo", articulo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectGetART_SALDO_FEC(ByVal fecha As String, ByVal fecha_fin As String, ByVal anho As String, ByVal articulo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_GUIADESPACHO_SALDO_FEC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fecha", fecha),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@fecha_fin", fecha_fin),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                      New Oracle.ManagedDataAccess.Client.OracleParameter("@articulo", articulo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DECLARACION_SELECTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMaxTransp() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CERTIFICA_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectRowCount() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CERTIFICA_ROWCOUNT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectRowCountP() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CERTIFICA_ROWCOUNTP", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function
    Public Function SelectRowCountT() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CERTIFICA_ROWCOUNTT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function


    Private Sub InsertRow(ByVal ELDECLARACIONDUABE As ELDECLARACIONDUABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        'Los parametros que va recibir son las propiedades de la clase

        'For Each row As DataGridViewRow In dg.Rows

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DECLARACION_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.ser_doc_ref
        cmd.Parameters.Add("@nro_ser_doc", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.nro_doc_ref
        cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.t_doc_ref1
        cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.ser_doc_ref1
        cmd.Parameters.Add("@nro_ser_doc1", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.nro_doc_ref1
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.art_cod
        cmd.Parameters.Add("@nro_dua", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.nro_dua
        cmd.Parameters.Add("@ser_dua", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.ser_dua
        cmd.Parameters.Add("@art_dua", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.art_dua
        cmd.Parameters.Add("@fecha", OracleDbType.Varchar2).Value = ELDECLARACIONDUABE.fecha
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
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registró la dua N°" & ELDECLARACIONDUABE.ser_doc_ref & ELDECLARACIONDUABE.nro_doc_ref
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELDECLARACIONDUABE As ELDECLARACIONDUABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CERTIFICA_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        'cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        'cmd.Parameters.Add("@nro_ser_doc", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_ser_doc

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'Next

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu  'cod usu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registró la dua N°" & ELDECLARACIONDUABE.ser_doc_ref & ELDECLARACIONDUABE.nro_doc_ref
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELPERMISOSBE As ELPERMISOSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_TAREO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBTAREOBE.cod
        'cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = ELTBTAREOBE.fecha
        'cmd.Parameters.Add("@id", OracleDbType.Varchar2).Value = ELTBTAREOBE.id
        'cmd.ExecuteNonQuery()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.usuactu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se eliminó la asistencia : " + ELTBTAREOBE.cod + "-" + ELTBTAREOBE.fecha
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Public Function SaveRow(ByVal ELDECLARACIONDUABE As ELDECLARACIONDUABE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
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
                InsertRow(ELDECLARACIONDUABE, cn, sqlTrans, ELMVLOGSBE)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELDECLARACIONDUABE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                'DeleteRow(ELCERTIFICABE, cn, sqlTrans)
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
                'cn.Dispose()
            End If
            'sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    'Public Function SaveRow2(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal Tpaquete As String) As String
    '    Dim resultado As String = "OK"
    '    Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
    '    Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction



    '    cn = ConnectionBegin()

    '    sqlTrans = cn.BeginTransaction

    '    Try


    '        If flagAccion = "N" Then

    '            InsertRow2(ELCERTIFICABE, cn, sqlTrans, Tpaquete)
    '        End If

    '        If flagAccion = "M" Then
    '            'UpdateRow2(ELCERTIFICABE, cn, sqlTrans, Tpaquete)
    '        End If

    '        If flagAccion = "E" Then
    '            'DeleteRow(ELCERTIFICABE, cn, sqlTrans)
    '        End If

    '        sqlTrans.Commit()
    '        resultado = "OK"

    '    Catch ex As Oracle.ManagedDataAccess.Client.OracleException
    '        sqlTrans.Rollback()
    '        resultado = ex.Message
    '    Catch ex As Exception
    '        sqlTrans.Rollback()
    '        resultado = ex.Message
    '    Finally
    '        If resultado = "OK" And flagAccion <> "E" Then
    '            'cn.Dispose()
    '        End If
    '        'sqlTrans = Nothing
    '    End Try

    '    Return resultado

    'End Function

    Public Function InsertRow2(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal Tpaquete As String) As String

        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()

        sqlTrans = cn.BeginTransaction

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        'Los parametros que va recibir son las propiedades de la clase

        'For Each row As DataGridViewRow In dg.Rows
        Try
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CERTIFICA_INSERTROW_EASY"
            cmd.Connection = cn
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
            cmd.Parameters.Add("@nro_ser_doc", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_ser_doc
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod

            cmd.Parameters.Add("@o1", OracleDbType.Varchar2).Value = ELCERTIFICABE.o1
            cmd.Parameters.Add("@o2", OracleDbType.Varchar2).Value = ELCERTIFICABE.o2
            cmd.Parameters.Add("@o3", OracleDbType.Varchar2).Value = ELCERTIFICABE.o3
            cmd.Parameters.Add("@o4", OracleDbType.Varchar2).Value = ELCERTIFICABE.o4
            cmd.Parameters.Add("@o5", OracleDbType.Varchar2).Value = ELCERTIFICABE.o5
            cmd.Parameters.Add("@o6", OracleDbType.Varchar2).Value = ELCERTIFICABE.o6
            cmd.Parameters.Add("@o7", OracleDbType.Varchar2).Value = ELCERTIFICABE.o7
            cmd.Parameters.Add("@o8", OracleDbType.Varchar2).Value = ELCERTIFICABE.o8
            cmd.Parameters.Add("@o9", OracleDbType.Varchar2).Value = ELCERTIFICABE.o9
            cmd.Parameters.Add("@m1", OracleDbType.Varchar2).Value = ELCERTIFICABE.m1
            cmd.Parameters.Add("@m2", OracleDbType.Varchar2).Value = ELCERTIFICABE.m2
            cmd.Parameters.Add("@m3", OracleDbType.Varchar2).Value = ELCERTIFICABE.m3
            cmd.Parameters.Add("@m4", OracleDbType.Varchar2).Value = ELCERTIFICABE.m4
            cmd.Parameters.Add("@m5", OracleDbType.Varchar2).Value = ELCERTIFICABE.m5

            cmd.Parameters.Add("@x1", OracleDbType.Varchar2).Value = ELCERTIFICABE.es12
            cmd.Parameters.Add("@x2", OracleDbType.Varchar2).Value = ELCERTIFICABE.es13
            cmd.Parameters.Add("@x3", OracleDbType.Varchar2).Value = ELCERTIFICABE.es14

            ELCERTIFICABE.ser_doc_ref = ""
            ELCERTIFICABE.nro_ser_doc = ""
            ELCERTIFICABE.art_cod = ""

            ELCERTIFICABE.o1 = ""
            ELCERTIFICABE.o2 = ""
            ELCERTIFICABE.o3 = ""
            ELCERTIFICABE.o4 = ""
            ELCERTIFICABE.o5 = ""
            ELCERTIFICABE.o6 = ""
            ELCERTIFICABE.o7 = ""
            ELCERTIFICABE.o8 = ""
            ELCERTIFICABE.o9 = ""
            ELCERTIFICABE.m1 = ""
            ELCERTIFICABE.m2 = ""
            ELCERTIFICABE.m3 = ""
            ELCERTIFICABE.m4 = ""
            ELCERTIFICABE.m5 = ""
            ELCERTIFICABE.es12 = ""
            ELCERTIFICABE.es13 = ""
            ELCERTIFICABE.es14 = ""
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'AUDITORIA
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
            cmd.Connection = cn
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
            cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCERTIFICABE.usuario  'cod usu
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registró el certificado de Easy Peel"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message

        End Try

        Return resultado
        'Next


    End Function

    Public Function InsertRow3(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal Tpaquete As String) As String

        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()

        sqlTrans = cn.BeginTransaction

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        'Los parametros que va recibir son las propiedades de la clase

        'For Each row As DataGridViewRow In dg.Rows
        Try
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CERTIFICA_INSERTROW_TPLAST"
            cmd.Connection = cn
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
            cmd.Parameters.Add("@nro_ser_doc", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_ser_doc
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod

            cmd.Parameters.Add("@o1", OracleDbType.Varchar2).Value = ELCERTIFICABE.o1
            cmd.Parameters.Add("@o2", OracleDbType.Varchar2).Value = ELCERTIFICABE.o2
            cmd.Parameters.Add("@o3", OracleDbType.Varchar2).Value = ELCERTIFICABE.o3
            cmd.Parameters.Add("@o4", OracleDbType.Varchar2).Value = ELCERTIFICABE.o4
            cmd.Parameters.Add("@o5", OracleDbType.Varchar2).Value = ELCERTIFICABE.o5
            cmd.Parameters.Add("@o6", OracleDbType.Varchar2).Value = ELCERTIFICABE.o6
            cmd.Parameters.Add("@o7", OracleDbType.Varchar2).Value = ELCERTIFICABE.o7
            cmd.Parameters.Add("@o8", OracleDbType.Varchar2).Value = ELCERTIFICABE.o8
            cmd.Parameters.Add("@o9", OracleDbType.Varchar2).Value = ELCERTIFICABE.o9
            cmd.Parameters.Add("@m1", OracleDbType.Varchar2).Value = ELCERTIFICABE.m1
            cmd.Parameters.Add("@m2", OracleDbType.Varchar2).Value = ELCERTIFICABE.m2
            cmd.Parameters.Add("@m3", OracleDbType.Varchar2).Value = ELCERTIFICABE.m3
            cmd.Parameters.Add("@m4", OracleDbType.Varchar2).Value = ELCERTIFICABE.m4

            cmd.Parameters.Add("@x4", OracleDbType.Varchar2).Value = ELCERTIFICABE.es12
            cmd.Parameters.Add("@x5", OracleDbType.Varchar2).Value = ELCERTIFICABE.es13
            cmd.Parameters.Add("@x6", OracleDbType.Varchar2).Value = ELCERTIFICABE.es14

            ELCERTIFICABE.ser_doc_ref = ""
            ELCERTIFICABE.nro_ser_doc = ""
            ELCERTIFICABE.art_cod = ""

            ELCERTIFICABE.o1 = ""
            ELCERTIFICABE.o2 = ""
            ELCERTIFICABE.o3 = ""
            ELCERTIFICABE.o4 = ""
            ELCERTIFICABE.o5 = ""
            ELCERTIFICABE.o6 = ""
            ELCERTIFICABE.o7 = ""
            ELCERTIFICABE.o8 = ""
            ELCERTIFICABE.o9 = ""
            ELCERTIFICABE.m1 = ""
            ELCERTIFICABE.m2 = ""
            ELCERTIFICABE.m3 = ""
            ELCERTIFICABE.m4 = ""

            ELCERTIFICABE.es12 = ""
            ELCERTIFICABE.es13 = ""
            ELCERTIFICABE.es14 = ""

            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'AUDITORIA
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
            cmd.Connection = cn
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
            cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCERTIFICABE.usuario  'cod usu
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registró el certificado de Tapa Plástica"
            cmd.ExecuteNonQuery()
            cmd.Dispose()


            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message

        End Try

        Return resultado
        'Next


    End Function
    Public Function InsertRow4(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal Tpaquete As String) As String

        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()

        sqlTrans = cn.BeginTransaction

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        'Los parametros que va recibir son las propiedades de la clase

        'For Each row As DataGridViewRow In dg.Rows
        Try
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CERTIFICA_INSERTROW_TTELES"
            cmd.Connection = cn
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
            cmd.Parameters.Add("@nro_ser_doc", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_ser_doc
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod

            cmd.Parameters.Add("@alt_cuerpo", OracleDbType.Varchar2).Value = ELCERTIFICABE.alt_cuerpo
            cmd.Parameters.Add("@alt_envase", OracleDbType.Varchar2).Value = ELCERTIFICABE.alt_envase
            cmd.Parameters.Add("@dia_interno", OracleDbType.Varchar2).Value = ELCERTIFICABE.dia_interno
            cmd.Parameters.Add("@dia_externo", OracleDbType.Varchar2).Value = ELCERTIFICABE.dia_externo
            cmd.Parameters.Add("@anc_envase", OracleDbType.Varchar2).Value = ELCERTIFICABE.anc_envase
            cmd.Parameters.Add("@larg_envase", OracleDbType.Varchar2).Value = ELCERTIFICABE.larg_envase
            cmd.Parameters.Add("@alt_tapa", OracleDbType.Varchar2).Value = ELCERTIFICABE.alt_tapa
            cmd.Parameters.Add("@pes_envase", OracleDbType.Varchar2).Value = ELCERTIFICABE.pes_envase
            cmd.Parameters.Add("@tipo_acta", OracleDbType.Varchar2).Value = ELCERTIFICABE.tipo_acta

            cmd.Parameters.Add("@alt_asa", OracleDbType.Varchar2).Value = ELCERTIFICABE.alt_asa
            cmd.Parameters.Add("@obs1", OracleDbType.Varchar2).Value = ELCERTIFICABE.obs1
            cmd.Parameters.Add("@obs2", OracleDbType.Varchar2).Value = ELCERTIFICABE.obs2
            cmd.Parameters.Add("@obs3", OracleDbType.Varchar2).Value = ELCERTIFICABE.obs3
            cmd.Parameters.Add("@obs4", OracleDbType.Varchar2).Value = ELCERTIFICABE.obs4
            cmd.Parameters.Add("@obs5", OracleDbType.Varchar2).Value = ELCERTIFICABE.obs5

            cmd.Parameters.Add("@o1", OracleDbType.Varchar2).Value = ELCERTIFICABE.o1
            cmd.Parameters.Add("@o2", OracleDbType.Varchar2).Value = ELCERTIFICABE.o2
            cmd.Parameters.Add("@o3", OracleDbType.Varchar2).Value = ELCERTIFICABE.o3
            cmd.Parameters.Add("@o4", OracleDbType.Varchar2).Value = ELCERTIFICABE.o4
            cmd.Parameters.Add("@o5", OracleDbType.Varchar2).Value = ELCERTIFICABE.o5
            cmd.Parameters.Add("@o6", OracleDbType.Varchar2).Value = ELCERTIFICABE.o6
            cmd.Parameters.Add("@o7", OracleDbType.Varchar2).Value = ELCERTIFICABE.o7
            cmd.Parameters.Add("@o8", OracleDbType.Varchar2).Value = ELCERTIFICABE.o8
            cmd.Parameters.Add("@o9", OracleDbType.Varchar2).Value = ELCERTIFICABE.o9
            cmd.Parameters.Add("@m1", OracleDbType.Varchar2).Value = ELCERTIFICABE.m1
            cmd.Parameters.Add("@m2", OracleDbType.Varchar2).Value = ELCERTIFICABE.m2
            cmd.Parameters.Add("@m3", OracleDbType.Varchar2).Value = ELCERTIFICABE.m3
            cmd.Parameters.Add("@m4", OracleDbType.Varchar2).Value = ELCERTIFICABE.m4
            cmd.Parameters.Add("@m5", OracleDbType.Varchar2).Value = ELCERTIFICABE.m5
            cmd.Parameters.Add("@m6", OracleDbType.Varchar2).Value = ELCERTIFICABE.m6
            cmd.Parameters.Add("@m7", OracleDbType.Varchar2).Value = ELCERTIFICABE.m7
            cmd.Parameters.Add("@m8", OracleDbType.Varchar2).Value = ELCERTIFICABE.m8
            cmd.Parameters.Add("@m9", OracleDbType.Varchar2).Value = ELCERTIFICABE.m9
            cmd.Parameters.Add("@p1", OracleDbType.Varchar2).Value = ELCERTIFICABE.p1
            cmd.Parameters.Add("@p2", OracleDbType.Varchar2).Value = ELCERTIFICABE.p2
            cmd.Parameters.Add("@p3", OracleDbType.Varchar2).Value = ELCERTIFICABE.p3
            cmd.Parameters.Add("@p4", OracleDbType.Varchar2).Value = ELCERTIFICABE.p4
            cmd.Parameters.Add("@p5", OracleDbType.Varchar2).Value = ELCERTIFICABE.p5
            cmd.Parameters.Add("@p6", OracleDbType.Varchar2).Value = ELCERTIFICABE.p6
            cmd.Parameters.Add("@p7", OracleDbType.Varchar2).Value = ELCERTIFICABE.p7
            cmd.Parameters.Add("@p8", OracleDbType.Varchar2).Value = ELCERTIFICABE.p8
            cmd.Parameters.Add("@p9", OracleDbType.Varchar2).Value = ELCERTIFICABE.p9

            cmd.Parameters.Add("@es1", OracleDbType.Varchar2).Value = ELCERTIFICABE.es1
            cmd.Parameters.Add("@es2", OracleDbType.Varchar2).Value = ELCERTIFICABE.es2
            cmd.Parameters.Add("@es3", OracleDbType.Varchar2).Value = ELCERTIFICABE.es3
            cmd.Parameters.Add("@es4", OracleDbType.Varchar2).Value = ELCERTIFICABE.es4
            cmd.Parameters.Add("@es5", OracleDbType.Varchar2).Value = ELCERTIFICABE.es5
            cmd.Parameters.Add("@es6", OracleDbType.Varchar2).Value = ELCERTIFICABE.es6
            cmd.Parameters.Add("@es7", OracleDbType.Varchar2).Value = ELCERTIFICABE.es7
            cmd.Parameters.Add("@fec_prov", OracleDbType.Varchar2).Value = ELCERTIFICABE.fec_prov
            cmd.Parameters.Add("@es8", OracleDbType.Varchar2).Value = ELCERTIFICABE.es8
            cmd.Parameters.Add("@es9", OracleDbType.Varchar2).Value = ELCERTIFICABE.es9
            cmd.Parameters.Add("@es10", OracleDbType.Varchar2).Value = ELCERTIFICABE.es10
            cmd.Parameters.Add("@es11", OracleDbType.Varchar2).Value = ELCERTIFICABE.es11

            cmd.Parameters.Add("@x7", OracleDbType.Varchar2).Value = ELCERTIFICABE.es12
            cmd.Parameters.Add("@x8", OracleDbType.Varchar2).Value = ELCERTIFICABE.es13
            cmd.Parameters.Add("@x9", OracleDbType.Varchar2).Value = ELCERTIFICABE.es14
            ELCERTIFICABE.es12 = ""
            ELCERTIFICABE.es13 = ""
            ELCERTIFICABE.es14 = ""
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'AUDITORIA
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
            cmd.Connection = cn
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
            cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCERTIFICABE.usuario  'cod usu
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registró el certificado de Tapa Telescópica"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message

        End Try

        Return resultado
        'Next


    End Function
    Public Function SelectArticulo(ByVal sNro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETDUA_NRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@nro", sNro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
