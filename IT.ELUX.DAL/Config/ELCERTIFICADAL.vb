Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELCERTIFICADAL

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
    '  ----------------------------------------------------------------------------------------------------------------- Inicio
    Public Function SelGuiaTwo() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_GUIASTWO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAl2(ByVal sNroD As String, ByVal sSerD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTAL2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAl3(ByVal sTDoc As String, ByVal sSerD As String, ByVal sNroD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTAL3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Tipo", sTDoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectInc() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTINC", {})
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
    Public Function SelectAl4(ByVal sTDoc As String, ByVal sSerD As String, ByVal sNroD As String, ByVal sArtD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTAL4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Tipo", sTDoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Art", sArtD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectArt(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Art", sArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectOk(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTOK", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Art", sArt)})
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

    Public Function SelectCon(ByVal sTipo As String, ByVal sSer As String, ByVal sNro As String, ByVal sDiam As String, ByVal sAct As String, ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTCON", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Tipo", sTipo),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSer),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNro),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Diam", sDiam),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Act", sAct),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Art", sArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function list1(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String, ByVal sTwoE As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTLOTE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Art", sArt),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Est", sTwoE)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function



    'Public Function ELCERTIFICADAL.SelectLote() As DataTable
    '    Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
    '    Dim dt As New DataTable
    '    Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTLOTE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
    '                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD),
    '                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@Art", sArt),
    '                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@Est", sTwoE)})
    '        If dr.HasRows Then
    '            dt.Load(dr)
    '        End If
    '    End Using
    '    Return dt
    '
    'End Function

    Public Function SaveRowTwo(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRowTwo(ELCERTIFICABE, cn, sqlTrans, dg)
            End If

            If flagAccion = "M" Then
                UpdateRowTwo(ELCERTIFICABE, cn, sqlTrans, dg)
            End If

            If flagAccion = "A" Then
                DeleteRowTwo(ELCERTIFICABE, cn, sqlTrans, dg)
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
            End If
        End Try

        Return resultado

    End Function
    Private Sub InsertRowTwo(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        'Los parametros que va recibir son las propiedades de la clase

        'For Each row As DataGridViewRow In dg.Rows

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CERTIFICA_INSERTROW_CONT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref

        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        cmd.Parameters.Add("@DIAMETRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.diametro
        cmd.Parameters.Add("@ESPESOR", OracleDbType.Double).Value = ELCERTIFICABE.Espesor
        cmd.Parameters.Add("@TEMPLE", OracleDbType.Varchar2).Value = ELCERTIFICABE.temple
        cmd.Parameters.Add("@CANT_BULTOS", OracleDbType.Varchar2).Value = ELCERTIFICABE.cantidad_tapas_bulto
        cmd.Parameters.Add("@TRATAMIENTO_TERMICO", OracleDbType.Varchar2).Value = ELCERTIFICABE.tratamiento_termico
        cmd.Parameters.Add("@REC_INT", OracleDbType.Varchar2).Value = ELCERTIFICABE.recubrimiento_termico
        cmd.Parameters.Add("@MODELO", OracleDbType.Varchar2).Value = ELCERTIFICABE.modelo
        cmd.Parameters.Add("@DIAM_EXTERIOR", OracleDbType.Double).Value = ELCERTIFICABE.diametro_exterior
        cmd.Parameters.Add("@DIAM_INTERIOR", OracleDbType.Double).Value = ELCERTIFICABE.diametro_interior
        cmd.Parameters.Add("@DIAM_UNIA", OracleDbType.Double).Value = ELCERTIFICABE.diametro_entre_unias
        cmd.Parameters.Add("@ALT_EXTERIOR", OracleDbType.Double).Value = ELCERTIFICABE.altura_de_exterior
        cmd.Parameters.Add("@NIVEL_VACIO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nivel_de_vacio
        cmd.Parameters.Add("@SEGURIDAD_CIERRE", OracleDbType.Double).Value = ELCERTIFICABE.seguridad_de_cierre
        cmd.Parameters.Add("@COD_PRODUCCION", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.ctct_cod

        cmd.Parameters.Add("@DIAM_EXT_RES", OracleDbType.Double).Value = ELCERTIFICABE.diametro_exterior_res
        cmd.Parameters.Add("@DIAM_INT", OracleDbType.Double).Value = ELCERTIFICABE.diametro_interior_res
        cmd.Parameters.Add("@DIAM_UNIA_RES", OracleDbType.Double).Value = ELCERTIFICABE.diametro_entre_unias_res
        cmd.Parameters.Add("@ALT_EXT_RES", OracleDbType.Double).Value = ELCERTIFICABE.altura_de_exterior_res
        cmd.Parameters.Add("@INC", OracleDbType.Varchar2).Value = ELCERTIFICABE.inc

        cmd.Parameters.Add("@txto1", OracleDbType.Double).Value = ELCERTIFICABE.txto1
        cmd.Parameters.Add("@txtm1", OracleDbType.Double).Value = ELCERTIFICABE.txtm1
        cmd.Parameters.Add("@txto2", OracleDbType.Double).Value = ELCERTIFICABE.txto2
        cmd.Parameters.Add("@txtm2", OracleDbType.Double).Value = ELCERTIFICABE.txtm2
        cmd.Parameters.Add("@txto3", OracleDbType.Double).Value = ELCERTIFICABE.txto3
        cmd.Parameters.Add("@txtm3", OracleDbType.Double).Value = ELCERTIFICABE.txtm3
        cmd.Parameters.Add("@txto4", OracleDbType.Double).Value = ELCERTIFICABE.txto4
        cmd.Parameters.Add("@txtm4", OracleDbType.Double).Value = ELCERTIFICABE.txtm4


        'cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELCERTIFICABE.usuario
        'Dim ff As DateTime = DateTime.Now.ToString("dd/MM/yyyy")
        'cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = ff
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'CABEZERA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CERTIFICA_INSERTROW_TWO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        cmd.Parameters.Add("@CANTIDAD", OracleDbType.Varchar2).Value = ELCERTIFICABE.cantidad1
        cmd.Parameters.Add("@TIPO_ACTA", OracleDbType.Varchar2).Value = "TWC"
        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELCERTIFICABE.fechac
        cmd.Parameters.Add("@FEC_DIA", OracleDbType.Date).Value = ELCERTIFICABE.fechadia
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = ELCERTIFICABE.ctct_cod
        cmd.Parameters.Add("@MEDIDA", OracleDbType.Varchar2).Value = ELCERTIFICABE.medida
        cmd.Parameters.Add("@DESCRI", OracleDbType.Varchar2).Value = ELCERTIFICABE.descri
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELCERTIFICABE.est
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'LOTES
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CERTIFICA_INSERTROW_LOTE"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELCERTIFICABE.tipo = IIf(IsDBNull(RTrim(row.Cells("tipo").Value)), "", RTrim(row.Cells("tipo").Value))
            ELCERTIFICABE.serie = IIf(IsDBNull(RTrim(row.Cells("SERIE").Value)), "", RTrim(row.Cells("SERIE").Value))
            ELCERTIFICABE.numero = IIf(IsDBNull(RTrim(row.Cells("NUMERO").Value)), "", RTrim(row.Cells("NUMERO").Value))
            ELCERTIFICABE.cantidad2 = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELCERTIFICABE.fecha = IIf(IsDBNull(RTrim(row.Cells("FECHA PRODUCCION").Value)), "", RTrim(row.Cells("FECHA PRODUCCION").Value))
            ELCERTIFICABE.turno = IIf(IsDBNull(RTrim(row.Cells("TURNO").Value)), "", RTrim(row.Cells("TURNO").Value))
            ELCERTIFICABE.lote1 = IIf(IsDBNull(RTrim(row.Cells("LOTE").Value)), "", RTrim(row.Cells("LOTE").Value))

            cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.tipo
            cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.serie
            cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.numero
            cmd.Parameters.Add("@TIPO1", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
            cmd.Parameters.Add("@SERIE1", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
            cmd.Parameters.Add("@NRO1", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.double).Value = ELCERTIFICABE.cantidad2
            cmd.Parameters.Add("@FEC_PRO", OracleDbType.Date).Value = ELCERTIFICABE.fecha
            cmd.Parameters.Add("@TURNO", OracleDbType.Varchar2).Value = ELCERTIFICABE.turno
            cmd.Parameters.Add("@LOTE", OracleDbType.Varchar2).Value = ELCERTIFICABE.lote1
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "H"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CERTIFICA_UPDATE_TWO"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.tipo
            cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.serie
            cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.numero
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
            cmd.Parameters.Add("@turno", OracleDbType.Varchar2).Value = ELCERTIFICABE.turno
            cmd.Parameters.Add("@CANTIDAD1", OracleDbType.Double).Value = ELCERTIFICABE.cantidad2
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "1"
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ""
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

    End Sub
    Private Sub UpdateRowTwo(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CERTIFICA_DELETEROW_LOTE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CERTIFICA_UPDATE_TWO"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELCERTIFICABE.tipo = IIf(IsDBNull(RTrim(row.Cells("tipo").Value)), "", RTrim(row.Cells("tipo").Value))
            ELCERTIFICABE.serie = IIf(IsDBNull(RTrim(row.Cells("SERIE").Value)), "", RTrim(row.Cells("SERIE").Value))
            ELCERTIFICABE.numero = IIf(IsDBNull(RTrim(row.Cells("NUMERO").Value)), "", RTrim(row.Cells("NUMERO").Value))
            ELCERTIFICABE.turno = IIf(IsDBNull(RTrim(row.Cells("TURNO").Value)), "", RTrim(row.Cells("TURNO").Value))
            ELCERTIFICABE.cantidad2 = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.tipo
            cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.serie
            cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.numero
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
            cmd.Parameters.Add("@TURNO", OracleDbType.Varchar2).Value = ELCERTIFICABE.turno
            cmd.Parameters.Add("@CANTIDAD1", OracleDbType.Double).Value = ELCERTIFICABE.cantidad2
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "1"
            cmd.Parameters.Add("@nNRO", OracleDbType.Varchar2).Value = ""
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CERTIFICA_DELETEROW_TWO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref
        cmd.Parameters.Add("@SAF", OracleDbType.Varchar2).Value = ELCERTIFICABE.inc
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CERTIFICA_INSERTROW_CONT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        cmd.Parameters.Add("@DIAMETRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.diametro
        cmd.Parameters.Add("@ESPESOR", OracleDbType.Double).Value = ELCERTIFICABE.Espesor
        cmd.Parameters.Add("@TEMPLE", OracleDbType.Varchar2).Value = ELCERTIFICABE.temple
        cmd.Parameters.Add("@CANT_BULTOS", OracleDbType.Varchar2).Value = ELCERTIFICABE.cantidad_tapas_bulto
        cmd.Parameters.Add("@TRATAMIENTO_TERMICO", OracleDbType.Varchar2).Value = ELCERTIFICABE.tratamiento_termico
        cmd.Parameters.Add("@REC_INT", OracleDbType.Varchar2).Value = ELCERTIFICABE.recubrimiento_termico
        cmd.Parameters.Add("@MODELO", OracleDbType.Varchar2).Value = ELCERTIFICABE.modelo
        cmd.Parameters.Add("@DIAM_EXTERIOR", OracleDbType.Double).Value = ELCERTIFICABE.diametro_exterior
        cmd.Parameters.Add("@DIAM_INTERIOR", OracleDbType.Double).Value = ELCERTIFICABE.diametro_interior
        cmd.Parameters.Add("@DIAM_UNIA", OracleDbType.Double).Value = ELCERTIFICABE.diametro_entre_unias
        cmd.Parameters.Add("@ALT_EXTERIOR", OracleDbType.Double).Value = ELCERTIFICABE.altura_de_exterior
        cmd.Parameters.Add("@NIVEL_VACIO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nivel_de_vacio
        cmd.Parameters.Add("@SEGURIDAD_CIERRE", OracleDbType.Double).Value = ELCERTIFICABE.seguridad_de_cierre
        cmd.Parameters.Add("@COD_PRODUCCION", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        cmd.Parameters.Add("@CTCT_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.ctct_cod
        cmd.Parameters.Add("@DIAM_EXT_RES", OracleDbType.Double).Value = ELCERTIFICABE.diametro_exterior_res
        cmd.Parameters.Add("@DIAM_INT", OracleDbType.Double).Value = ELCERTIFICABE.diametro_interior_res
        cmd.Parameters.Add("@DIAM_UNIA_RES", OracleDbType.Double).Value = ELCERTIFICABE.diametro_entre_unias_res
        cmd.Parameters.Add("@ALT_EXT_RES", OracleDbType.Double).Value = ELCERTIFICABE.altura_de_exterior_res
        cmd.Parameters.Add("@inc", OracleDbType.Varchar2).Value = ELCERTIFICABE.inc

        cmd.Parameters.Add("@txto1", OracleDbType.Double).Value = ELCERTIFICABE.txto1
        cmd.Parameters.Add("@txtm1", OracleDbType.Double).Value = ELCERTIFICABE.txtm1
        cmd.Parameters.Add("@txto2", OracleDbType.Double).Value = ELCERTIFICABE.txto2
        cmd.Parameters.Add("@txtm2", OracleDbType.Double).Value = ELCERTIFICABE.txtm2
        cmd.Parameters.Add("@txto3", OracleDbType.Double).Value = ELCERTIFICABE.txto3
        cmd.Parameters.Add("@txtm3", OracleDbType.Double).Value = ELCERTIFICABE.txtm3
        cmd.Parameters.Add("@txto4", OracleDbType.Double).Value = ELCERTIFICABE.txto4
        cmd.Parameters.Add("@txtm4", OracleDbType.Double).Value = ELCERTIFICABE.txtm4

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim contr As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            contr = contr + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CERTIFICA_INSERTROW_LOTE"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELCERTIFICABE.tipo = IIf(IsDBNull(RTrim(row.Cells("tipo").Value)), "", RTrim(row.Cells("tipo").Value))
            ELCERTIFICABE.numero = IIf(IsDBNull(RTrim(row.Cells("NUMERO").Value)), "", RTrim(row.Cells("NUMERO").Value))
            ELCERTIFICABE.serie = IIf(IsDBNull(RTrim(row.Cells("SERIE").Value)), "", RTrim(row.Cells("SERIE").Value))
            ELCERTIFICABE.cantidad2 = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELCERTIFICABE.fecha = IIf(IsDBNull(RTrim(row.Cells("FECHA PRODUCCION").Value)), "", RTrim(row.Cells("FECHA PRODUCCION").Value))
            ELCERTIFICABE.turno = IIf(IsDBNull(RTrim(row.Cells("TURNO").Value)), "", RTrim(row.Cells("TURNO").Value))
            ELCERTIFICABE.lote1 = IIf(IsDBNull(RTrim(row.Cells("LOTE").Value)), "", RTrim(row.Cells("LOTE").Value))
            cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.tipo
            cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.serie
            cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.numero
            cmd.Parameters.Add("@TIPO1", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
            cmd.Parameters.Add("@SERIE1", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
            cmd.Parameters.Add("@NRO1", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELCERTIFICABE.cantidad2
            cmd.Parameters.Add("@FEC_PRO", OracleDbType.Date).Value = ELCERTIFICABE.fecha
            cmd.Parameters.Add("@TURNO", OracleDbType.Varchar2).Value = ELCERTIFICABE.turno
            cmd.Parameters.Add("@LOTE", OracleDbType.Varchar2).Value = ELCERTIFICABE.lote1
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "H"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CERTIFICA_UPDATE_TWOCA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "D"
        cmd.Parameters.Add("@DESC", OracleDbType.Varchar2).Value = ELCERTIFICABE.descri
        cmd.ExecuteNonQuery()
        cmd.Dispose()


    End Sub
    Private Sub DeleteRowTwo(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_CERTIFICA_UPDATE_TWO"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELCERTIFICABE.tipo = IIf(IsDBNull(RTrim(row.Cells("tipo").Value)), "", RTrim(row.Cells("tipo").Value))
            ELCERTIFICABE.serie = IIf(IsDBNull(RTrim(row.Cells("SERIE").Value)), "", RTrim(row.Cells("SERIE").Value))
            ELCERTIFICABE.numero = IIf(IsDBNull(RTrim(row.Cells("NUMERO").Value)), "", RTrim(row.Cells("NUMERO").Value))
            ELCERTIFICABE.turno = IIf(IsDBNull(RTrim(row.Cells("TURNO").Value)), "", RTrim(row.Cells("TURNO").Value))
            ELCERTIFICABE.cantidad2 = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.tipo
            cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.serie
            cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.numero
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
            cmd.Parameters.Add("@TURNO", OracleDbType.Varchar2).Value = ELCERTIFICABE.turno
            cmd.Parameters.Add("@CANTIDAD1", OracleDbType.Double).Value = ELCERTIFICABE.cantidad2
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "0"
            cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CERTIFICA_UPDATE_TWOCA"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELCERTIFICABE.est
        cmd.Parameters.Add("@DESC", OracleDbType.Varchar2).Value = ""
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    ' ------------------------------------------------------------------------------------------------------------------ Fin


    Public Function SelectRow(ByVal sCode As String, ByVal sCode2 As String, ByVal sCode3 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sCode),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sCode2),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sCode3)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRowEasy(ByVal sCode3 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTROWEASY", {New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sCode3)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRowPlast(ByVal sCode3 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTROWPLAST", {New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sCode3)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRowTeles(ByVal sCode3 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CERTIFICA_SELECTROWTELE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sCode3)})
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


    Private Sub InsertRow(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal Tpaquete As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        'Los parametros que va recibir son las propiedades de la clase

        'For Each row As DataGridViewRow In dg.Rows

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CERTIFICA_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        cmd.Parameters.Add("@nro_ser_doc", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_ser_doc
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = ELCERTIFICABE.lote
        cmd.Parameters.Add("@fec_prov", OracleDbType.Varchar2).Value = ELCERTIFICABE.fec_prov
        cmd.Parameters.Add("@n_bolsas", OracleDbType.Double).Value = ELCERTIFICABE.n_bolsas
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELCERTIFICABE.cantidad
        cmd.Parameters.Add("@t_paquete", OracleDbType.Varchar2).Value = Tpaquete
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
        cmd.Parameters.Add("@TIP_ENVASE", OracleDbType.Varchar2).Value = ELCERTIFICABE.tip_envase
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

        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELCERTIFICABE.usuario
        Dim ff As DateTime = DateTime.Now.ToString("dd/MM/yyyy")
        cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = ff
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCERTIFICABE.usuario  'cod usu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registró el certificado de calidad y especificaciones técnicas " & ELCERTIFICABE.ser_doc_ref & " " & ELCERTIFICABE.nro_ser_doc
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal Tpaquete As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CERTIFICA_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        cmd.Parameters.Add("@nro_ser_doc", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_ser_doc
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = ELCERTIFICABE.lote
        cmd.Parameters.Add("@fec_prov", OracleDbType.Varchar2).Value = ELCERTIFICABE.fec_prov
        cmd.Parameters.Add("@n_bolsas", OracleDbType.Double).Value = ELCERTIFICABE.n_bolsas
        cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = ELCERTIFICABE.cantidad
        cmd.Parameters.Add("@t_paquete", OracleDbType.Varchar2).Value = Tpaquete
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
        cmd.Parameters.Add("@TIP_ENVASE", OracleDbType.Varchar2).Value = ELCERTIFICABE.tip_envase
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

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'Next

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBTAREOBE.id  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro la asistencia : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
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

    Public Function SaveRow(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal Tpaquete As String) As String
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
                InsertRow(ELCERTIFICABE, cn, sqlTrans, Tpaquete)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELCERTIFICABE, cn, sqlTrans, Tpaquete)
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
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registró el certificado de Tapa Plástica " & ELCERTIFICABE.ser_doc_ref & " " & ELCERTIFICABE.nro_ser_doc
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
            cmd.Parameters.Add("@color", OracleDbType.Varchar2).Value = ELCERTIFICABE.Color
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
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registró el certificado de Tapa Telescópica " & ELCERTIFICABE.ser_doc_ref & " " & ELCERTIFICABE.nro_ser_doc
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
End Class
