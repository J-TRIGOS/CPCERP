Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELALBARANDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    Public ELMVLOGSBE As New ELMVLOGSBE
    Public Function SelGuia() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ALBARAN_GUIAS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectOk(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBALBARAN_SELECTOK", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
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
    Public Function SelectAl2(ByVal sNroD As String, ByVal sSerD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ALBARAN_SELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


    Public Function SelectArt(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ALBARAN_SELECTOK", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Art", sArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectAl4(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ALBARAN_SELECTDET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Art", sArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectDet(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ALBARAN_SELECTD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Nro", sNroD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Ser", sSerD),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@Art", sArt)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SaveRow(ByVal ELALBARANBE As ELALBARANBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRow(ELALBARANBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELALBARANBE, cn, sqlTrans, dg)
            End If

            If flagAccion = "A" Then
                DeleteRow(ELALBARANBE, cn, sqlTrans, dg)
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
    Private Sub InsertRow(ByVal ELALBARANBE As ELALBARANBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        'Los parametros que va recibir son las propiedades de la clase

        'For Each row As DataGridViewRow In dg.Rows

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ALBARAN_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELALBARANBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELALBARANBE.FEC_PRO = IIf(IsDBNull(RTrim(row.Cells("FEC_PRO").Value)), "", RTrim(row.Cells("FEC_PRO").Value))

            ELALBARANBE.FEC_VEN = IIf(IsDBNull(RTrim(row.Cells("FEC_VEN").Value)), "", RTrim(row.Cells("FEC_VEN").Value))
            If IIf(IsDBNull(RTrim(row.Cells("TURNO").Value)), "", RTrim(row.Cells("TURNO").Value)) = "DIA" Then
                ELALBARANBE.TURNO = "A"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("TURNO").Value)), "", RTrim(row.Cells("TURNO").Value)) = "NOCHE" Then
                ELALBARANBE.TURNO = "B"
            End If
            ELALBARANBE.LOTE = IIf(IsDBNull(RTrim(row.Cells("LOTE1").Value)), "", RTrim(row.Cells("LOTE1").Value))


            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELALBARANBE.T_DOC_REF
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELALBARANBE.SER_DOC_REF
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELALBARANBE.NRO_DOC_REF

            cmd.Parameters.Add("@SER_DOC", OracleDbType.Varchar2).Value = ELALBARANBE.SER_DOC
            cmd.Parameters.Add("@NRO_DOC", OracleDbType.Varchar2).Value = ELALBARANBE.NRO_DOC

            cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = ELALBARANBE.NUMPEDIDO
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELALBARANBE.ART_COD
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELALBARANBE.CANTIDAD
            cmd.Parameters.Add("@FEC_PRO", OracleDbType.Date).Value = ELALBARANBE.FEC_PRO
            cmd.Parameters.Add("@FEC_VEN", OracleDbType.Date).Value = ELALBARANBE.FEC_VEN
            cmd.Parameters.Add("@TURNO", OracleDbType.Varchar2).Value = ELALBARANBE.TURNO
            cmd.Parameters.Add("@LOTE", OracleDbType.Varchar2).Value = ELALBARANBE.LOTE
            cmd.Parameters.Add("@CANT_CAJA", OracleDbType.Varchar2).Value = ELALBARANBE.CANT_CAJA
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "H"
            cmd.Parameters.Add("@PAQBAS", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PAQBAS").Value)), "", RTrim(row.Cells("PAQBAS").Value))
            cmd.Parameters.Add("@PAQALT", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PAQALT").Value)), "", RTrim(row.Cells("PAQALT").Value))
            cmd.Parameters.Add("@PAQPAL", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PAQPAL").Value)), "", RTrim(row.Cells("PAQPAL").Value))
            cmd.Parameters.Add("@UNIPAQ", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("UNIPAQ").Value)), "", RTrim(row.Cells("UNIPAQ").Value))
            cmd.Parameters.Add("@UNIPAL", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("UNIPAL").Value)), "", RTrim(row.Cells("UNIPAL").Value))
            cmd.Parameters.Add("@NUMPAL", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NUMPAL").Value)), "", RTrim(row.Cells("NUMPAL").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next

    End Sub
    Public Function LastCodigo(ByVal sSer As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBALBARAN_SELECTNRO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sSer", sSer)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)

    End Function
    Private Sub UpdateRow(ByVal ELALBARANBE As ELALBARANBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBALBARAN_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELALBARANBE.T_DOC_REF
        cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELALBARANBE.SER_DOC_REF
        cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELALBARANBE.NRO_DOC_REF
        cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELALBARANBE.ART_COD
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ALBARAN_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELALBARANBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            ELALBARANBE.FEC_PRO = IIf(IsDBNull(RTrim(row.Cells("FEC_PRO").Value)), "", RTrim(row.Cells("FEC_PRO").Value))

            ELALBARANBE.FEC_VEN = IIf(IsDBNull(RTrim(row.Cells("FEC_VEN").Value)), "", RTrim(row.Cells("FEC_VEN").Value))
            If IIf(IsDBNull(RTrim(row.Cells("TURNO").Value)), "", RTrim(row.Cells("TURNO").Value)) = "DIA" Then
                ELALBARANBE.TURNO = "A"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("TURNO").Value)), "", RTrim(row.Cells("TURNO").Value)) = "NOCHE" Then
                ELALBARANBE.TURNO = "B"
            End If
            ELALBARANBE.LOTE = IIf(IsDBNull(RTrim(row.Cells("LOTE1").Value)), "", RTrim(row.Cells("LOTE1").Value))


            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELALBARANBE.T_DOC_REF
            cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELALBARANBE.SER_DOC_REF
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELALBARANBE.NRO_DOC_REF

            cmd.Parameters.Add("@SER_DOC", OracleDbType.Varchar2).Value = ELALBARANBE.SER_DOC
            cmd.Parameters.Add("@NRO_DOC", OracleDbType.Varchar2).Value = ELALBARANBE.NRO_DOC

            cmd.Parameters.Add("@NUMPEDIDO", OracleDbType.Varchar2).Value = ELALBARANBE.NUMPEDIDO
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELALBARANBE.ART_COD
            cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = ELALBARANBE.CANTIDAD
            cmd.Parameters.Add("@FEC_PRO", OracleDbType.Date).Value = ELALBARANBE.FEC_PRO
            cmd.Parameters.Add("@FEC_VEN", OracleDbType.Date).Value = ELALBARANBE.FEC_VEN
            cmd.Parameters.Add("@TURNO", OracleDbType.Varchar2).Value = ELALBARANBE.TURNO
            cmd.Parameters.Add("@LOTE", OracleDbType.Varchar2).Value = ELALBARANBE.LOTE
            cmd.Parameters.Add("@CANT_CAJA", OracleDbType.Varchar2).Value = ELALBARANBE.CANT_CAJA
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "H"
            cmd.Parameters.Add("@PAQBAS", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PAQBAS").Value)), "", RTrim(row.Cells("PAQBAS").Value))
            cmd.Parameters.Add("@PAQALT", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PAQALT").Value)), "", RTrim(row.Cells("PAQALT").Value))
            cmd.Parameters.Add("@PAQPAL", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("PAQPAL").Value)), "", RTrim(row.Cells("PAQPAL").Value))
            cmd.Parameters.Add("@UNIPAQ", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("UNIPAQ").Value)), "", RTrim(row.Cells("UNIPAQ").Value))
            cmd.Parameters.Add("@UNIPAL", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("UNIPAL").Value)), "", RTrim(row.Cells("UNIPAL").Value))
            cmd.Parameters.Add("@NUMPAL", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NUMPAL").Value)), "", RTrim(row.Cells("NUMPAL").Value))
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next


        '
        '  'Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        '
        '  cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        '  cmd.CommandText = "SP_CERTIFICA_UPDATE_TWOCA"
        '  cmd.Connection = sqlCon
        '  cmd.Transaction = sqlTrans
        '  cmd.CommandType = CommandType.StoredProcedure
        '  cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELCERTIFICABE.t_doc_ref
        '  cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELCERTIFICABE.ser_doc_ref
        '  cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELCERTIFICABE.nro_doc_ref
        '  cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELCERTIFICABE.art_cod
        '  cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "D"
        '  cmd.Parameters.Add("@DESC", OracleDbType.Varchar2).Value = ELCERTIFICABE.descri
        '  cmd.ExecuteNonQuery()
        '  cmd.Dispose()



    End Sub

    Private Sub DeleteRow(ByVal ELALBARANBE As ELALBARANBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                  ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBALBARAN_UPDATE"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            ELALBARANBE.LOTE = IIf(IsDBNull(RTrim(row.Cells("LOTE1").Value)), "", RTrim(row.Cells("LOTE1").Value))
            If IIf(IsDBNull(RTrim(row.Cells("TURNO").Value)), "", RTrim(row.Cells("TURNO").Value)) = "DIA" Then
                ELALBARANBE.TURNO = "A"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("TURNO").Value)), "", RTrim(row.Cells("TURNO").Value)) = "NOCHE" Then
                ELALBARANBE.TURNO = "B"
            End If
            cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELALBARANBE.T_DOC_REF
            cmd.Parameters.Add("@SER-DOC_REF", OracleDbType.Varchar2).Value = ELALBARANBE.SER_DOC_REF
            cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELALBARANBE.NRO_DOC_REF
            cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELALBARANBE.ART_COD
            cmd.Parameters.Add("@TURNO", OracleDbType.Varchar2).Value = ELALBARANBE.TURNO
            cmd.Parameters.Add("@LOTE", OracleDbType.Varchar2).Value = ELALBARANBE.LOTE
            cmd.Parameters.Add("@NUMPAL", OracleDbType.Varchar2).Value = IIf(IsDBNull(RTrim(row.Cells("NUMPAL").Value)), "", RTrim(row.Cells("NUMPAL").Value))
            cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = "A"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_CERTIFICA_UPDATE_TWOCA"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = ELALBARANBE.t_doc_ref
        'cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = ELALBARANBE.ser_doc_ref
        'cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = ELALBARANBE.nro_doc_ref
        'cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = ELALBARANBE.art_cod
        'cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELALBARANBE.est
        'cmd.Parameters.Add("@DESC", OracleDbType.Varchar2).Value = ""
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()

    End Sub
End Class
