Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ART_UPDATEDAL

    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    'Public ELMVLOGSBE As New ELMVLOGSBE

    'Funcion que me ve permitir generar el codigo 
    Public Function LastCodigo(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LASTCODIGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function getMedida(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_MED_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function

    Public Function LastCodAntiguo() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LASTCOD_ANTIGUO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function

    Public Function SetStock(ByVal sCode As String) As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_STK_ACT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        End If
    End Function

    'Metodo para registrar un nuevo 
    Private Sub InsertRow(ByVal ART_UPDATEBE As ART_UPDATEBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        ''Los parametros que va recibir son las propiedades de la clase         
        'cmd.Parameters.Add("@est", OracleDbType.Char).Value = ARTICULOBE.est
        'cmd.Parameters.Add("@x_kardex", OracleDbType.Char).Value = ARTICULOBE.x_kardex
        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ARTICULOBE.cod
        'cmd.Parameters.Add("@nom", OracleDbType.Char).Value = ARTICULOBE.nom
        'cmd.Parameters.Add("@art_codcat", OracleDbType.Char).Value = ARTICULOBE.art_codcat
        'cmd.Parameters.Add("@fam1", OracleDbType.Char).Value = ARTICULOBE.fam1
        'cmd.Parameters.Add("@fam2", OracleDbType.Char).Value = ARTICULOBE.fam2
        'cmd.Parameters.Add("@fam3", OracleDbType.Char).Value = ARTICULOBE.fam3
        'cmd.Parameters.Add("@fam4", OracleDbType.Char).Value = ARTICULOBE.fam4
        'cmd.Parameters.Add("@fam5", OracleDbType.Char).Value = ARTICULOBE.fam5
        'cmd.Parameters.Add("@part_apreq", OracleDbType.Varchar2).Value = ARTICULOBE.art_aproreq
        'cmd.Parameters.Add("@temp_art", OracleDbType.Varchar2).Value = ARTICULOBE.temp_art
        'cmd.Parameters.Add("@stkmin", OracleDbType.Double).Value = ARTICULOBE.stkmin
        'cmd.Parameters.Add("@medida", OracleDbType.Varchar2).Value = ARTICULOBE.medida
        'cmd.Parameters.Add("@medida_nuevo", OracleDbType.Varchar2).Value = ARTICULOBE.medida_nuevo
        'cmd.Parameters.Add("@cod_proc", OracleDbType.Varchar2).Value = ARTICULOBE.cod_proc
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal ART_UPDATEBE As ART_UPDATEBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'realiza registro del catalogo
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ART_UDTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = ART_UPDATEBE.art_cod
        cmd.Parameters.Add("pdiametro", OracleDbType.Varchar2).Value = ART_UPDATEBE.diametro
        cmd.Parameters.Add("pcolor", OracleDbType.Varchar2).Value = ART_UPDATEBE.color
        cmd.Parameters.Add("pcalidad", OracleDbType.Varchar2).Value = ART_UPDATEBE.calidad
        cmd.Parameters.Add("pcantidad", OracleDbType.Varchar2).Value = ART_UPDATEBE.cantidad
        cmd.Parameters.Add("pcata", OracleDbType.Varchar2).Value = ART_UPDATEBE.cata
        cmd.Parameters.Add("pcata1", OracleDbType.Varchar2).Value = ART_UPDATEBE.cata1
        cmd.Parameters.Add("pdetalle", OracleDbType.Varchar2).Value = ART_UPDATEBE.detalle

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@art_cod", OracleDbType.Char).Value = ARTICULOBE.art_cod

        cmd.ExecuteNonQuery()


    End Sub

    Private Sub UpdateKardex(ByVal ARTICULOBE As ARTICULOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal ELMVLOGSBE As ELMVLOGSBE)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand


        'For i As Integer = 1 To 365

        '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '    cmd.CommandText = "SP_updatecorrelativo"
        '    cmd.Connection = sqlCon
        '    cmd.Transaction = sqlTrans
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(i).PadLeft(2, "0")
        '    cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(1).PadLeft(2, "0")
        '    cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
        '    cmd.ExecuteNonQuery()
        '    'cmd.Dispose()

        'Next


        For i As Integer = 1 To 31

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(i).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(1).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next

        Dim y As Integer = 0
        For i As Integer = 32 To 60
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(2).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next

        y = 0
        For i As Integer = 61 To 91
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(3).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next

        y = 0
        For i As Integer = 92 To 121
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(4).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next


        y = 0
        For i As Integer = 122 To 152
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(5).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next

        y = 0
        For i As Integer = 153 To 182
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(6).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next

        y = 0
        For i As Integer = 183 To 213
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(7).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next

        y = 0
        For i As Integer = 214 To 244
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(8).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next


        y = 0
        For i As Integer = 245 To 274
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(9).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next

        y = 0
        For i As Integer = 275 To 305
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(10).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next

        y = 0
        For i As Integer = 306 To 335
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(11).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next

        y = 0
        For i As Integer = 336 To 366
            y = y + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_updatecorrelativo"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("dia", OracleDbType.Varchar2).Value = CStr(y).PadLeft(2, "0")
            cmd.Parameters.Add("mes", OracleDbType.Varchar2).Value = CStr(12).PadLeft(2, "0")
            cmd.Parameters.Add("DN", OracleDbType.Varchar2).Value = CStr(i).PadLeft(3, "0")
            cmd.ExecuteNonQuery()
            'cmd.Dispose()

        Next



    End Sub
    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal ART_UPDATEBE As ART_UPDATEBE, ByVal flagAccion As String) As String
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
                InsertRow(ART_UPDATEBE, cn, sqlTrans)

                'grabar acceso a los menues
            End If

            If flagAccion = "M" Then
                UpdateRow(ART_UPDATEBE, cn, sqlTrans)
            End If

            'If flagAccion = "E" Then
            '    DeleteRow(ARTICULOBE, cn, sqlTrans)
            'End If

            'If flagAccion = "MK" Then
            '    UpdateKardex(ARTICULOBE, cn, sqlTrans)
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
            If resultado = "OK" And flagAccion <> "M" And flagAccion <> "MK" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ART_UPDATE_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function getListdgv(ByVal sCodecat As String, ByVal sCodeart As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CAR_DATO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodecat), New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeart)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv1(ByVal sCodeArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_COMP", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    'Public Function getListdgv1(ByVal sCodecat As String, ByVal sCodeart As String) As DataTable
    '    'vERIFICAR
    '    Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
    '    Dim dt As New DataTable
    '    Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CAR_DATO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodecat), New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCodeart)})
    '        If dr.HasRows Then
    '            dt.Load(dr)
    '        End If
    '    End Using
    '    Return dt
    'End Function

    'Public Function getListdgvArt() As DataTable
    '    Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
    '    Dim dt As New DataTable
    '    Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_ALLART", {})
    '        If dr.HasRows Then
    '            dt.Load(dr)
    '        End If
    '    End Using
    '    Return dt
    'End Function

    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ART_UPDATE_SELECTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectArt(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectArt", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectUniMed(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectUni", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sUnid = dr.GetString(0)
            End While
        End Using
        Return sUnid
    End Function

    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer))})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String, ByVal sfec As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTNRO1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pT_DOC_REF", Trim(sCode)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pSER_DOC_REF", Trim(sSer)),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@pFEC_GENE", Trim(sfec))})
            While dr.Read
                sNumero1 = dr.GetString(0)
            End While
        End Using
        Return sNumero1

    End Function

    Public Function SelectAct() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECACT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectArt1(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectArt1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectArt2(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectArt2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
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

    Public Function ActualizarKardex(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_UDPK", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", sCode)})
            While dr.Read

                If IsDBNull(dr.GetString(0)) Then
                    sNomArt = "Error"
                Else
                    sNomArt = "Ok"
                End If
            End While
        End Using
        Return sNomArt
    End Function

    Public Function SelectArt3(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectArt3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
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

    Public Function SelectContar(ByVal sCode As String, ByVal sCtct As String) As Int32
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_CONTAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                                              New Oracle.ManagedDataAccess.Client.OracleParameter("@sCtct", sCtct)})
            While dr.Read
                sNumero = dr.GetInt32(0)
            End While
        End Using
        Return sNumero

    End Function




    Function getListcmb() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LINES", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb1(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SUBLINES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb2(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SUBLINES1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb3() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_FAMILIA1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb4() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_FAMILIA2", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb5() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_FAMILIA3", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb6() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_FAMILIA4", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb7() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_FAMILIA5", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb8() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_UNI", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb9() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CCOSTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb10() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_CATALOGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb11() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_ALM", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb12() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_MEDIDA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb13() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_LINEA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getListcmb14() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_MEDIDA_NUEVO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getListcmb15(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_MEDIDA_ANT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt
    End Function
    Function getArticuloAnterior() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getMedida_old(ByVal sCode As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_MED_COD_OLD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
                If dr.HasRows Then
                    dt.Load(dr)
                End If
            End Using
            If dt.Rows.Count = 1 Then
                Return dt.Rows(0).Item(0)
            Else
                Return ""
            End If
        Catch ex As Exception
        End Try
    End Function

    Function getArticuloAnterior1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getArticulocliente(ByVal sRuc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH_CLI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sRuc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Function getOpciones(ByVal sCat As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CARAVAL_SELECTVAL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCat)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function getArtstk(ByVal sCodAlm As String, ByVal sSubLinea As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_STK", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ART_SLINEA", sSubLinea),
                                                                            New Oracle.ManagedDataAccess.Client.OracleParameter("@ART_CODALM", sCodAlm)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAllopcion(ByVal opcion As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_ALLOPCION", {New Oracle.ManagedDataAccess.Client.OracleParameter("@opcion", opcion)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectLineaAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_LINEALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


End Class
