Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class GUIAALMACENDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    'Public ELMVLOGSBE As New ELMVLOGSBE
    Public sNomArt As String
    'Metodo para registrar un nuevo 


    Public Function SelectT_MEDIDA() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_MEDIDA_VENTAS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Private Sub InsertRow(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        'Dim nro As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_ALM1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = GUIAALMACENBE.T_MOVINV
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = GUIAALMACENBE.OBSERVA1
        cmd.Parameters.Add("@alm_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = GUIAALMACENBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALM003"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells(16).Value)), "", RTrim(row.Cells(16).Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(29).Value)), "", RTrim(row.Cells(29).Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells(30).Value)), "", RTrim(row.Cells(30).Value))
            DET_DOCUMENTOBE.FOR_ENT_COD = IIf(IsDBNull(RTrim(row.Cells(31).Value)), "", RTrim(row.Cells(31).Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells(34).Value)), "", RTrim(row.Cells(34).Value))
            DET_DOCUMENTOBE.LOTE = IIf(IsDBNull(RTrim(row.Cells(36).Value)), "", RTrim(row.Cells(36).Value))
            DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            DET_DOCUMENTOBE.TIPO_UNIDAD = IIf(IsDBNull(RTrim(row.Cells(45).Value)), "", RTrim(row.Cells(45).Value))
            DET_DOCUMENTOBE.CONFIGURACION = IIf(IsDBNull(RTrim(row.Cells(46).Value)), "", RTrim(row.Cells(46).Value))
            DET_DOCUMENTOBE.COMENTARIO = IIf(IsDBNull(RTrim(row.Cells(47).Value)), "", RTrim(row.Cells(47).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            contenedor = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            'If contenedor.Length > 5 Then
            '    DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            'End If
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells(44).Value)), "", RTrim(row.Cells(44).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            'If GUIAALMACENBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And GUIAALMACENBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = GUIAALMACENBE.NRO_DOC_REF & "-" & cont
            'End If
            If DET_DOCUMENTOBE.T_DOC_REF1 <> "SOLM" And DET_DOCUMENTOBE.T_DOC_REF1 <> "RPD" And DET_DOCUMENTOBE.T_DOC_REF1 <> "REIN" And
                DET_DOCUMENTOBE.T_DOC_REF1 <> "RFAL" And DET_DOCUMENTOBE.T_DOC_REF1 <> "82" And DET_DOCUMENTOBE.T_DOC_REF1 <> "REQ" Then
                If DET_DOCUMENTOBE.SER_DOC_REF1 <> "T001" Then
                    DET_DOCUMENTOBE.NRO_DOC_REF1 = GUIAALMACENBE.NRO_DOC_REF & "-" & cont
                End If
            End If
            DET_DOCUMENTOBE.ART_COD1 = IIf(IsDBNull(RTrim(row.Cells(45).Value)), "", RTrim(row.Cells(45).Value))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells(49).Value)), "", RTrim(row.Cells(49).Value))
            DET_DOCUMENTOBE.CANTIDAD3 = Val(IIf(IsDBNull(RTrim(row.Cells(50).Value)), 0, RTrim(row.Cells(50).Value)))
            DET_DOCUMENTOBE.CANTIDAD2 = Val(IIf(IsDBNull(RTrim(row.Cells(51).Value)), 0, RTrim(row.Cells(51).Value)))
            DET_DOCUMENTOBE.CANTIDAD4 = Val(IIf(IsDBNull(RTrim(row.Cells(52).Value)), 0, RTrim(row.Cells(52).Value)))
            DET_DOCUMENTOBE.CANTIDAD5 = Val(IIf(IsDBNull(RTrim(row.Cells(53).Value)), 0, RTrim(row.Cells(53).Value)))
            DET_DOCUMENTOBE.SUGERENCIA = Val(IIf(IsDBNull(RTrim(row.Cells(54).Value)), "", RTrim(row.Cells(54).Value)))

            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF           '01
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF       '02
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)      '03
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1       '04
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1   '05
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1   '06
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD           '07
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD             '08
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD             '09
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO                 '10
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA             '11
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)       '12
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE                 '13
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO             '14
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)         '15
            cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT       '16
            cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD     '17
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA                 '18
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR             '19
            cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD               '20
            cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE                   '21
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD             '22
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT                 '23
            'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG              
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST                       '24
            cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC                   '25
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD             '26
            cmd.Parameters.Add("@art_cod1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1           '27
            cmd.Parameters.Add("@art_venta", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA         '28
            cmd.Parameters.Add("@cantidad3", OracleDbType.Double).Value = Val(DET_DOCUMENTOBE.CANTIDAD3)      '29
            cmd.Parameters.Add("@TIPO_UNIDAD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.TIPO_UNIDAD           '30
            cmd.Parameters.Add("@CONFIGURACION", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CONFIGURACION         '31
            cmd.Parameters.Add("@COMENTARIO", OracleDbType.Varchar2).Value = Val(DET_DOCUMENTOBE.COMENTARIO)      '32
            cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = Val(DET_DOCUMENTOBE.CANTIDAD2)      '51
            cmd.Parameters.Add("@CANTIDAD4", OracleDbType.Double).Value = Val(DET_DOCUMENTOBE.CANTIDAD4)      '52
            cmd.Parameters.Add("@CANTIDAD5", OracleDbType.Double).Value = Val(DET_DOCUMENTOBE.CANTIDAD5)      '53
            cmd.Parameters.Add("@SUGERENCIA", OracleDbType.Varchar2).Value = Val(DET_DOCUMENTOBE.SUGERENCIA)      '54
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            If GUIAALMACENBE.EST <> "A" Then
                'If GUIAALMACENBE.ALMAC = "E" Then
                '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                '    cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                '    cmd.Connection = sqlCon
                '    cmd.Transaction = sqlTrans
                '    cmd.CommandType = CommandType.StoredProcedure
                '    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                '    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                '    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                '    cmd.ExecuteNonQuery()
                '    cmd.Dispose()

                'Else
                '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                '    cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                '    cmd.Connection = sqlCon
                '    cmd.Transaction = sqlTrans
                '    cmd.CommandType = CommandType.StoredProcedure
                '    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                '    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                '    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                '    cmd.ExecuteNonQuery()
                '    cmd.Dispose()
                'End If
                If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then
                    If GUIAALMACENBE.ALMAC = "E" Then
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        'cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                        'cmd.Connection = sqlCon
                        'cmd.Transaction = sqlTrans
                        'cmd.CommandType = CommandType.StoredProcedure
                        'cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                        'cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        'cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD3)
                        'cmd.ExecuteNonQuery()
                        'cmd.Dispose()

                        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        'cmd.CommandText = "SP_ARTICULO_UPDATSUMARESTA"
                        'cmd.Connection = sqlCon
                        'cmd.Transaction = sqlTrans
                        'cmd.CommandType = CommandType.StoredProcedure
                        'cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                        'cmd.Parameters.Add("@ART_COD1", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        'cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        'cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        'cmd.ExecuteNonQuery()
                        'cmd.Dispose()
                        'Else
                        '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        '    cmd.CommandText = "SP_ARTICULO_UPDATRESTASUMA"
                        '    cmd.Connection = sqlCon
                        '    cmd.Transaction = sqlTrans
                        '    cmd.CommandType = CommandType.StoredProcedure
                        '    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                        '    cmd.Parameters.Add("@ART_COD1", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        '    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        '    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        '    cmd.ExecuteNonQuery()
                        '    cmd.Dispose()
                    ElseIf GUIAALMACENBE.ALMAC = "S" Then
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        'cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                        'cmd.Connection = sqlCon
                        'cmd.Transaction = sqlTrans
                        'cmd.CommandType = CommandType.StoredProcedure
                        'cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                        'cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        'cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD3)
                        'cmd.ExecuteNonQuery()
                        'cmd.Dispose()
                    End If
                Else
                    If GUIAALMACENBE.ALMAC = "E" Then
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Else
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If
                End If
                'MOVIDO
                'If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then
                '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                '    cmd.CommandText = "SP_ELMVALMAANHO_INS002"
                '    cmd.Connection = sqlCon
                '    cmd.Transaction = sqlTrans
                '    cmd.CommandType = CommandType.StoredProcedure
                '    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                '    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                '    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                '    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                '    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                '    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                '    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                '    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                '    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                '    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                '    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
                '    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
                '    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                '    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                '    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                '    cmd.Parameters.Add("@MOV_ART_COD1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                '    cmd.ExecuteNonQuery()
                '    cmd.Dispose()
                'Else
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)              '0
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)          '1
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)          '2
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)                 '3
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALM_COD) 'Trim("0001")     '4
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)                 '5
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE                            '6
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                   '7
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD                        '8
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST                             '9
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO                       '10
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV                        '11
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)          '12
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)      '13
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)      '14
                cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD                         '15
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'End If

                'Probar
                If DET_DOCUMENTOBE.T_DOC_REF1 = "SOLM" Then
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_SOLMAT_UPDATE_EST"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7))
                    cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@USUARIOAT", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
                    cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = "3"
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                ElseIf DET_DOCUMENTOBE.T_DOC_REF1 = "RPD" Or DET_DOCUMENTOBE.T_DOC_REF1 = "RFAL" Or DET_DOCUMENTOBE.T_DOC_REF1 = "REIN" Then
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_PRODUCCION_UPDATE_EST"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7))
                    cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = "3"
                    cmd.Parameters.Add("@CANTIDAD", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                ElseIf DET_DOCUMENTOBE.T_DOC_REF1 = "82" Then
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_DOCU_UPDCANT82_ALM"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7)
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            End If

        Next
        If ELMVLOGSBE.log_codusu <> "0001" Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
            cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


    End Sub
    Private Sub InserTrans(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        'Dim nro As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_ALM1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = scodcat
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = sEst
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        If Mid(GUIAALMACENBE.T_MOVINV, 1, 1) = "S" Then
            cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = "E18"
        Else
            cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = "S30"
        End If
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        If Mid(GUIAALMACENBE.T_MOVINV, 1, 1) = "S" Then
            cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "E"
        Else
            cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "S"
        End If
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = GUIAALMACENBE.OBSERVA1
        cmd.Parameters.Add("@alm_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = GUIAALMACENBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows

            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALM003"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells(16).Value)), "", RTrim(row.Cells(16).Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(29).Value)), "", RTrim(row.Cells(29).Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells(30).Value)), "", RTrim(row.Cells(30).Value))
            DET_DOCUMENTOBE.FOR_ENT_COD = IIf(IsDBNull(RTrim(row.Cells(31).Value)), "", RTrim(row.Cells(31).Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells(34).Value)), "", RTrim(row.Cells(34).Value))
            DET_DOCUMENTOBE.LOTE = IIf(IsDBNull(RTrim(row.Cells(36).Value)), "", RTrim(row.Cells(36).Value))
            DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            DET_DOCUMENTOBE.TIPO_UNIDAD = IIf(IsDBNull(RTrim(row.Cells(45).Value)), "", RTrim(row.Cells(45).Value))
            DET_DOCUMENTOBE.CONFIGURACION = IIf(IsDBNull(RTrim(row.Cells(46).Value)), "", RTrim(row.Cells(46).Value))
            DET_DOCUMENTOBE.COMENTARIO = IIf(IsDBNull(RTrim(row.Cells(47).Value)), "", RTrim(row.Cells(47).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            contenedor = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            'If contenedor.Length > 5 Then
            '    DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(27).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            'End If
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells(44).Value)), "", RTrim(row.Cells(44).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            If GUIAALMACENBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And GUIAALMACENBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
                DET_DOCUMENTOBE.NRO_DOC_REF1 = GUIAALMACENBE.NRO_DOC_REF & "-" & cont
            End If
            DET_DOCUMENTOBE.ART_COD1 = IIf(IsDBNull(RTrim(row.Cells(45).Value)), "", RTrim(row.Cells(45).Value)) '45
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells(46).Value)), "", RTrim(row.Cells(46).Value)) '46
            DET_DOCUMENTOBE.CANTIDAD3 = Val(IIf(IsDBNull(RTrim(row.Cells(47).Value)), 0, RTrim(row.Cells(47).Value))) '47
            DET_DOCUMENTOBE.CANTIDAD2 = Val(IIf(IsDBNull(RTrim(row.Cells(51).Value)), 0, RTrim(row.Cells(51).Value)))
            DET_DOCUMENTOBE.CANTIDAD4 = Val(IIf(IsDBNull(RTrim(row.Cells(52).Value)), 0, RTrim(row.Cells(52).Value)))
            DET_DOCUMENTOBE.CANTIDAD5 = Val(IIf(IsDBNull(RTrim(row.Cells(53).Value)), 0, RTrim(row.Cells(53).Value)))
            DET_DOCUMENTOBE.SUGERENCIA = Val(IIf(IsDBNull(RTrim(row.Cells(54).Value)), "", RTrim(row.Cells(54).Value)))
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF           '0
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = scodcat       '1
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = sEst      '2
            'OBSERVAR
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF        '3
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF  '4
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF  '5
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD           '6
            If DET_DOCUMENTOBE.CANTIDAD <> DET_DOCUMENTOBE.CANTIDAD3 Then
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD3            '7
            Else
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD           '7
            End If
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1             '8
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO                 '9
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA             '10
            If Mid(Trim(GUIAALMACENBE.T_MOVINV), 1, 1) = "E" Then
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = "S30"       '11
            Else
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = "E18"       '11
            End If

            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE                 '12
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO             '13
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)         '14
            cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT       '15
            cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD     '16
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA                 '17
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR             '18
            cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD             '19
            cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE                   '20
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD             '21
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT                 '22
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST                       '23
            If Mid(Trim(GUIAALMACENBE.T_MOVINV), 1, 1) = "E" Then
                cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "S"                '24
            Else
                cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "E"                '24
            End If
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD             '25
            cmd.Parameters.Add("@art_cod1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD           '26
            cmd.Parameters.Add("@art_venta", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA         '27
            cmd.Parameters.Add("@cantidad3", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD3         '28
            cmd.Parameters.Add("@TIPO_UNIDAD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.TIPO_UNIDAD         '29
            cmd.Parameters.Add("@CONFIGURACION", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CONFIGURACION         '30
            cmd.Parameters.Add("@COMENTARIO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.COMENTARIO         '31
            cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD2 '32
            cmd.Parameters.Add("@CANTIDAD4", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD4 '33
            cmd.Parameters.Add("@CANTIDAD5", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD5 '34
            cmd.Parameters.Add("@SUGERENCIA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SUGERENCIA '35
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            If GUIAALMACENBE.EST <> "A" Then
                If GUIAALMACENBE.T_MOVINV = "E18" Then
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                ElseIf GUIAALMACENBE.T_MOVINV = "S30" Then
                    If GUIAALMACENBE.ALMAC = "S" Then
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If
                End If
                'MOVIDO
                'If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then

                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)                '0
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = scodcat                                    '1
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = sEst                                       '2
                If Mid(Trim(GUIAALMACENBE.T_MOVINV), 1, 1) = "E" Then
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"                                     '3
                Else
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "E"                                     '3
                End If

                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALM_COD) 'Trim("0001")        4
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD1)                  '5
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE                              '6
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                     '7
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD3                         '8
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST                               '9
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO                         '10
                If Mid(Trim(GUIAALMACENBE.T_MOVINV), 1, 1) = "E" Then
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "S30"                                       '11
                Else
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "E18"                                       '11
                End If

                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)             '12
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)         '13
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)         '14
                cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD                           '15
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'End If
            End If
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UPDTrans(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        'Dim nro As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_ALM1"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = scodcat
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = sEst
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        If Mid(GUIAALMACENBE.T_MOVINV, 1, 1) = "S" Then
            cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = "E18"
        Else
            cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = "S30"
        End If
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        If Mid(GUIAALMACENBE.T_MOVINV, 1, 1) = "S" Then
            cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "E"
        Else
            cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "S"
        End If
        'cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = GUIAALMACENBE.OBSERVA1
        cmd.Parameters.Add("@alm_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = GUIAALMACENBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_ALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = scodcat
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = sEst
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows

            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALM003"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells(16).Value)), "", RTrim(row.Cells(16).Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(29).Value)), "", RTrim(row.Cells(29).Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells(30).Value)), "", RTrim(row.Cells(30).Value))
            DET_DOCUMENTOBE.FOR_ENT_COD = IIf(IsDBNull(RTrim(row.Cells(31).Value)), "", RTrim(row.Cells(31).Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells(34).Value)), "", RTrim(row.Cells(34).Value))
            DET_DOCUMENTOBE.LOTE = IIf(IsDBNull(RTrim(row.Cells(36).Value)), "", RTrim(row.Cells(36).Value))
            DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            contenedor = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            If contenedor.Length > 5 Then
                DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            End If
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells(44).Value)), "", RTrim(row.Cells(44).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            If GUIAALMACENBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And GUIAALMACENBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
                DET_DOCUMENTOBE.NRO_DOC_REF1 = GUIAALMACENBE.NRO_DOC_REF & "-" & cont
            End If
            DET_DOCUMENTOBE.ART_COD1 = IIf(IsDBNull(RTrim(row.Cells(48).Value)), "", RTrim(row.Cells(48).Value)) '45
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells(49).Value)), "", RTrim(row.Cells(49).Value)) '46
            DET_DOCUMENTOBE.TIPO_UNIDAD = IIf(IsDBNull(RTrim(row.Cells(45).Value)), "", RTrim(row.Cells(45).Value))
            DET_DOCUMENTOBE.CONFIGURACION = IIf(IsDBNull(RTrim(row.Cells(46).Value)), "", RTrim(row.Cells(46).Value))
            DET_DOCUMENTOBE.COMENTARIO = IIf(IsDBNull(RTrim(row.Cells(47).Value)), "", RTrim(row.Cells(47).Value))
            DET_DOCUMENTOBE.CANTIDAD3 = Val(IIf(IsDBNull(RTrim(row.Cells(50).Value)), 0, RTrim(row.Cells(50).Value))) '47
            DET_DOCUMENTOBE.CANTIDAD2 = Val(IIf(IsDBNull(RTrim(row.Cells(51).Value)), 0, RTrim(row.Cells(51).Value)))
            DET_DOCUMENTOBE.CANTIDAD4 = Val(IIf(IsDBNull(RTrim(row.Cells(52).Value)), 0, RTrim(row.Cells(52).Value)))
            DET_DOCUMENTOBE.CANTIDAD5 = Val(IIf(IsDBNull(RTrim(row.Cells(53).Value)), 0, RTrim(row.Cells(53).Value)))
            DET_DOCUMENTOBE.SUGERENCIA = Val(IIf(IsDBNull(RTrim(row.Cells(54).Value)), "", RTrim(row.Cells(54).Value)))
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF           '1
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = scodcat       '2
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = sEst      '3
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1       '4
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF  '5
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF  '6
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD           '7
            If DET_DOCUMENTOBE.CANTIDAD <> DET_DOCUMENTOBE.CANTIDAD3 Then
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD3            '8
            Else
                cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD           '8
            End If
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1             '9
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO                 '10
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA             '11
            If Mid(Trim(GUIAALMACENBE.T_MOVINV), 1, 1) = "E" Then
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = "S30"       '12
            Else
                cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = "E18"       '12
            End If

            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE                 '13
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO             '14
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)         '15
            cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT       '16
            cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD     '17
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA                 '18
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR             '19
            cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD             '21
            cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE                   '22
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD             '23
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT                 '24
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST                       '25
            If Mid(Trim(GUIAALMACENBE.T_MOVINV), 1, 1) = "E" Then
                cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "S"                '26
            Else
                cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = "E"                '26
            End If
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD             '27
            cmd.Parameters.Add("@art_cod1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD           '28
            cmd.Parameters.Add("@art_venta", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA         '29
            cmd.Parameters.Add("@cantidad3", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD3         '30
            cmd.Parameters.Add("@TIPO_UNIDAD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.TIPO_UNIDAD
            cmd.Parameters.Add("@CONFIGURACION", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CONFIGURACION
            cmd.Parameters.Add("@COMENTARIO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.COMENTARIO
            cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD2
            cmd.Parameters.Add("@CANTIDAD4", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD4
            cmd.Parameters.Add("@CANTIDAD5", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD5
            cmd.Parameters.Add("@SUGERENCIA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SUGERENCIA
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            If GUIAALMACENBE.EST <> "A" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)               '0
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = scodcat                                   '1
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = sEst                                      '2
                If Mid(Trim(GUIAALMACENBE.T_MOVINV), 1, 1) = "E" Then                                                           '
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"                                    '3
                Else                                                                                                            '
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "E"                                    '3
                End If                                                                                                          '

                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALM_COD) 'Trim("0001")      '4
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD1)                 '5
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE                             '6
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                    '7
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD3                        '8
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST                              '9
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO                        '10
                If Mid(Trim(GUIAALMACENBE.T_MOVINV), 1, 1) = "E" Then
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "S30"                                      '11
                Else
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "E18"                                      '11
                End If

                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)            '12
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)        '13
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)        '14
                cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD                          '15
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'End If
            End If
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Modifico el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub InsertRowReq(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_ALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'If PLmvPre1BE.Pr1_FecAct = #12:00:00 AM# Then
        '    cmd.Parameters.Add("@Pr1_FecAct", SqlDbType.DateTime).Value = DBNull.Value
        'Else
        '    cmd.Parameters.Add("@Pr1_FecAct", SqlDbType.DateTime).Value = PLmvPre1BE.Pr1_FecAct
        'End If
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = GUIAALMACENBE.T_MOVINV
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = GUIAALMACENBE.OBSERVA1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_DET_DOCUMENTO_DEL_ALM"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("@t_doc_ref", OracleDbType.Char).Value = DET_DOCUMENTOBE.T_DOC_REF
        'cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Char).Value = DET_DOCUMENTOBE.SER_DOC_REF
        'cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Char).Value = DET_DOCUMENTOBE.NRO_DOC_REF

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows

            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INS_REQ"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells(49).Value)), "", RTrim(row.Cells(49).Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(29).Value)), "", RTrim(row.Cells(29).Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells(30).Value)), "", RTrim(row.Cells(30).Value))
            DET_DOCUMENTOBE.FOR_ENT_COD = IIf(IsDBNull(RTrim(row.Cells(31).Value)), "", RTrim(row.Cells(31).Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells(34).Value)), "", RTrim(row.Cells(34).Value))
            DET_DOCUMENTOBE.LOTE = IIf(IsDBNull(RTrim(row.Cells(36).Value)), "", RTrim(row.Cells(36).Value))
            DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            contenedor = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            If contenedor.Length > 5 Then
                DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            End If
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells(44).Value)), "", RTrim(row.Cells(44).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.PESO = Val(IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value)))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells(47).Value)), "", RTrim(row.Cells(47).Value))
            DET_DOCUMENTOBE.LICENCIA = IIf(IsDBNull(RTrim(row.Cells(48).Value)), "", RTrim(row.Cells(48).Value))
            'If GUIAALMACENBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 Then
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = GUIAALMACENBE.NRO_DOC_REF & "-" & cont
            'End If
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF & "-" & cont
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_MOVINV)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
            cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
            cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
            'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
            cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
            cmd.Parameters.Add("@REQ", OracleDbType.Varchar2).Value = ""
            cmd.Parameters.Add("@PESO", OracleDbType.Double).Value = DET_DOCUMENTOBE.PESO
            cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
            cmd.Parameters.Add("@LICEN", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LICENCIA
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Creo el Requemiento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF + "-" + DET_DOCUMENTOBE.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub InsertRowNac(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                          ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                          ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        'Dim nro As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_INSERTROW_ALMNC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("@fec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("@observa", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("@t_movinv", OracleDbType.Char).Value = GUIAALMACENBE.T_MOVINV
        cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("@dir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
        cmd.Parameters.Add("@observa1", OracleDbType.Varchar2).Value = GUIAALMACENBE.OBSERVA1
        cmd.Parameters.Add("@x_m", OracleDbType.Varchar2).Value = GUIAALMACENBE.X_M
        cmd.Parameters.Add("@alm_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = GUIAALMACENBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows

            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALM002"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells(16).Value)), "", RTrim(row.Cells(16).Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(29).Value)), "", RTrim(row.Cells(29).Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells(30).Value)), "", RTrim(row.Cells(30).Value))
            DET_DOCUMENTOBE.FOR_ENT_COD = IIf(IsDBNull(RTrim(row.Cells(31).Value)), "", RTrim(row.Cells(31).Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells(34).Value)), "", RTrim(row.Cells(34).Value))
            DET_DOCUMENTOBE.LOTE = IIf(IsDBNull(RTrim(row.Cells(36).Value)), "", RTrim(row.Cells(36).Value))
            DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            DET_DOCUMENTOBE.TIPO_UNIDAD = IIf(IsDBNull(RTrim(row.Cells(45).Value)), "", RTrim(row.Cells(45).Value))
            DET_DOCUMENTOBE.CONFIGURACION = IIf(IsDBNull(RTrim(row.Cells(46).Value)), "", RTrim(row.Cells(46).Value))
            DET_DOCUMENTOBE.COMENTARIO = IIf(IsDBNull(RTrim(row.Cells(47).Value)), "", RTrim(row.Cells(47).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            contenedor = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            If contenedor.Length > 5 Then
                DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            End If
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells(44).Value)), "", RTrim(row.Cells(44).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            If GUIAALMACENBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And GUIAALMACENBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
                DET_DOCUMENTOBE.NRO_DOC_REF1 = GUIAALMACENBE.NRO_DOC_REF & "-" & cont
            End If
            DET_DOCUMENTOBE.ART_COD1 = IIf(IsDBNull(RTrim(row.Cells(48).Value)), "", RTrim(row.Cells(48).Value))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells(49).Value)), "", RTrim(row.Cells(49).Value))
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
            cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD
            cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
            'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
            cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
            cmd.Parameters.Add("@art_cod1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1
            cmd.Parameters.Add("@art_venta", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
            cmd.Parameters.Add("@TIPO_UNIDAD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.TIPO_UNIDAD
            cmd.Parameters.Add("@CONFIGURACION", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CONFIGURACION
            cmd.Parameters.Add("@COMENTARIO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.COMENTARIO

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'If GUIAALMACENBE.EST <> "A" Then
            '    If GUIAALMACENBE.ALMAC = "E" Then
            '        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            '        cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
            '        cmd.Connection = sqlCon
            '        cmd.Transaction = sqlTrans
            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
            '        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
            '        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
            '        cmd.ExecuteNonQuery()
            '        cmd.Dispose()

            '    Else
            '        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            '        cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
            '        cmd.Connection = sqlCon
            '        cmd.Transaction = sqlTrans
            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
            '        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
            '        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
            '        cmd.ExecuteNonQuery()
            '        cmd.Dispose()
            '    End If
            'End If
            If GUIAALMACENBE.EST <> "A" Then
                'If GUIAALMACENBE.ALMAC = "E" Then
                '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                '    cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                '    cmd.Connection = sqlCon
                '    cmd.Transaction = sqlTrans
                '    cmd.CommandType = CommandType.StoredProcedure
                '    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                '    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                '    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                '    cmd.ExecuteNonQuery()
                '    cmd.Dispose()

                'Else
                '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                '    cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                '    cmd.Connection = sqlCon
                '    cmd.Transaction = sqlTrans
                '    cmd.CommandType = CommandType.StoredProcedure
                '    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                '    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(GUIAALMACENBE.ALM_COD)
                '    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                '    cmd.ExecuteNonQuery()
                '    cmd.Dispose()
                'End If
                If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then
                    If GUIAALMACENBE.ALMAC = "E" Then
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ARTICULO_UPDATSUMARESTA"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        cmd.Parameters.Add("@ART_COD1", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Else
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ARTICULO_UPDATRESTASUMA"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        cmd.Parameters.Add("@ART_COD1", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If
                Else
                    If GUIAALMACENBE.ALMAC = "E" Then
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Else
                        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                        cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                        cmd.Connection = sqlCon
                        cmd.Transaction = sqlTrans
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                        cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                        cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If
                End If

            End If
            'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            'cmd.CommandText = "SP_ELMVALMA2019_INS"
            'cmd.Connection = sqlCon
            'cmd.Transaction = sqlTrans
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
            'cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
            'cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
            'cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
            'cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim("0001")
            'cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
            'cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
            'cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            'cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            'cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
            'cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            'cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
            'cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
            'cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
            'cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
            If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)             '0
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)         '1
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)         '2
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)                '3
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ALM_COD)                '4
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)                '5
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE                           '6
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                  '7
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD                       '8
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST                            '9
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO                      '10
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV                       '11
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)         '12
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)     '13
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)     '14
                'cmd.Parameters.Add("@MOV_ART_COD1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD1)             
                cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD                        '15
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)                 '0
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)             '1
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)             '2
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)                    '3
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALM_COD) 'Trim("0001")        '4
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)                    '5
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE                               '6
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                      '7
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD                           '8
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST                                '9
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO                          '10
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV                           '11
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)             '12
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)         '13
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)         '14
                cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD                            '15
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            'Probar
            If DET_DOCUMENTOBE.T_DOC_REF1 = "SOLM" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_SOLMAT_UPDATE_EST"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7))
                cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@USUARIOAT", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
                cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = "3"
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            ElseIf DET_DOCUMENTOBE.T_DOC_REF1 = "RPD" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_PRODUCCION_UPDATE_EST"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7))
                cmd.Parameters.Add("@EST1", OracleDbType.Varchar2).Value = "3"
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se ingreso el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    'Metodo para Modificar 
    Private Sub UpdateRow(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                            ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ALM002"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("pfec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("pmoneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("pfec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("psigno", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("pusuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("pobserva", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("pt_movinv", OracleDbType.Char).Value = GUIAALMACENBE.T_MOVINV
        cmd.Parameters.Add("pf_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("pfor_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("pcco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("pproveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("pctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("pdir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("pfec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("palmac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
        cmd.Parameters.Add("codalm", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ALM_COD
        cmd.Parameters.Add("@NOM_CTCT", OracleDbType.Varchar2).Value = GUIAALMACENBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_ALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INSALM003"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells(16).Value)), "", RTrim(row.Cells(16).Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(29).Value)), "", RTrim(row.Cells(29).Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells(30).Value)), "", RTrim(row.Cells(30).Value))
            DET_DOCUMENTOBE.FOR_ENT_COD = IIf(IsDBNull(RTrim(row.Cells(31).Value)), "", RTrim(row.Cells(31).Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells(34).Value)), "", RTrim(row.Cells(34).Value))
            DET_DOCUMENTOBE.LOTE = IIf(IsDBNull(RTrim(row.Cells(36).Value)), "", RTrim(row.Cells(36).Value))
            DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            DET_DOCUMENTOBE.TIPO_UNIDAD = IIf(IsDBNull(RTrim(row.Cells(45).Value)), "", RTrim(row.Cells(45).Value))
            DET_DOCUMENTOBE.CONFIGURACION = IIf(IsDBNull(RTrim(row.Cells(46).Value)), "", RTrim(row.Cells(46).Value))
            DET_DOCUMENTOBE.COMENTARIO = IIf(IsDBNull(RTrim(row.Cells(47).Value)), "", RTrim(row.Cells(47).Value))
            'DET_DOCUMENTOBE.LICENCIA = IIf(IsDBNull(RTrim(row.Cells(48).Value)), "", RTrim(row.Cells(48).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            contenedor = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            If contenedor.Length > 5 Then
                DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            End If
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells(44).Value)), "", RTrim(row.Cells(44).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            'If GUIAALMACENBE.SER_DOC_REF = DET_DOCUMENTOBE.SER_DOC_REF1 And GUIAALMACENBE.T_DOC_REF = DET_DOCUMENTOBE.T_DOC_REF1 Then
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = GUIAALMACENBE.NRO_DOC_REF & "-" & cont
            'End If
            If DET_DOCUMENTOBE.T_DOC_REF1 <> "SOLM" And DET_DOCUMENTOBE.T_DOC_REF1 <> "RPD" And DET_DOCUMENTOBE.T_DOC_REF1 <> "REIN" And
                DET_DOCUMENTOBE.T_DOC_REF1 <> "RFAL" And DET_DOCUMENTOBE.T_DOC_REF1 <> "82" And DET_DOCUMENTOBE.T_DOC_REF1 <> "REQ" Then
                If DET_DOCUMENTOBE.SER_DOC_REF <> "T001" Then
                    DET_DOCUMENTOBE.NRO_DOC_REF1 = GUIAALMACENBE.NRO_DOC_REF & "-" & cont
                End If
            End If
            DET_DOCUMENTOBE.ART_COD1 = IIf(IsDBNull(RTrim(row.Cells(48).Value)), "", RTrim(row.Cells(48).Value))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells(49).Value)), "", RTrim(row.Cells(49).Value))
            DET_DOCUMENTOBE.CANTIDAD3 = Val(IIf(IsDBNull(RTrim(row.Cells(50).Value)), 0, RTrim(row.Cells(50).Value)))
            DET_DOCUMENTOBE.CANTIDAD2 = Val(IIf(IsDBNull(RTrim(row.Cells(51).Value)), 0, RTrim(row.Cells(51).Value)))
            DET_DOCUMENTOBE.CANTIDAD4 = Val(IIf(IsDBNull(RTrim(row.Cells(52).Value)), 0, RTrim(row.Cells(52).Value)))
            DET_DOCUMENTOBE.CANTIDAD5 = Val(IIf(IsDBNull(RTrim(row.Cells(53).Value)), 0, RTrim(row.Cells(53).Value)))
            DET_DOCUMENTOBE.SUGERENCIA = Val(IIf(IsDBNull(RTrim(row.Cells(54).Value)), "", RTrim(row.Cells(54).Value)))
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF '0
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF '1
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF '2
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1 '3
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1 '4
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1 '5
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CTCT_COD '6
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD '7
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD '8
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO '9
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA '10
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV) '11
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE '12
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO '13
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD) '14
            cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT '15
            cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD '16
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_DIA '17
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR '18
            cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CCO_COD '19
            cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE '20
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD '21
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT '22
            'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG 
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST '23
            cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC '24
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD '25
            cmd.Parameters.Add("@art_cod1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1 '26
            cmd.Parameters.Add("@art_venta", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA '27
            cmd.Parameters.Add("@cantidad3", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD3 '28
            cmd.Parameters.Add("@TIPO_UNIDAD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.TIPO_UNIDAD '29
            cmd.Parameters.Add("@CONFIGURACION", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.CONFIGURACION '30
            cmd.Parameters.Add("@COMENTARIO", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.COMENTARIO '31
            cmd.Parameters.Add("@CANTIDAD2", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD2 '32
            cmd.Parameters.Add("@CANTIDAD4", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD4 '33
            cmd.Parameters.Add("@CANTIDAD5", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD5 '34
            cmd.Parameters.Add("@SUGERENCIA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SUGERENCIA '35

            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_BC_ACT_KARDEX"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@NRO_DOC", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ART", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@CANT", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then
                '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                '    cmd.CommandText = "SP_ELMVALMAANHO_UPDDATOS1"
                '    cmd.Connection = sqlCon
                '    cmd.Transaction = sqlTrans
                '    cmd.CommandType = CommandType.StoredProcedure
                '    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                '    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                '    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                '    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                '    cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                '    cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                '    cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                '    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                '    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                '    cmd.Parameters.Add("@ART_COD1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1
                '    cmd.ExecuteNonQuery()
                '    cmd.Dispose()
                'Else
                '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                '    cmd.CommandText = "SP_ELMVALMAANHO_UPDDATOS"
                '    cmd.Connection = sqlCon
                '    cmd.Transaction = sqlTrans
                '    cmd.CommandType = CommandType.StoredProcedure
                '    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                '    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                '    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                '    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                '    cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                '    cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                '    cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                '    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                '    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                '    cmd.ExecuteNonQuery()
                '    cmd.Dispose()
                If GUIAALMACENBE.T_MOVINV = "E18" Then
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_UPDDATOS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                    cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                    cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    '--------------

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_UPDDATOS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF
                    cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD1
                    cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "S30"
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "S"
                    cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Else
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_UPDDATOS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                    cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                    cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    '--------------

                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ELMVALMAANHO_UPDDATOS"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
                    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
                    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF
                    cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                    cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = "E18"
                    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = "E"
                    cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_UPDDATOS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_DOC_REF
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.SER_DOC_REF
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = GUIAALMACENBE.NRO_DOC_REF
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
                cmd.Parameters.Add("@ALM_COD", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALM_COD
                cmd.Parameters.Add("@ART_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
                cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_MOVINV)
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

        Next
        ' If ELMVLOGSBE.log_codusu <> "0001" Then
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
            cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
            cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Actualizo el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        'End If

    End Sub
    Private Sub UpdateRowNac(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                            ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ALMNC"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("pfec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("pmoneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("pfec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("psigno", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("pusuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("pobserva", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("pt_movinv", OracleDbType.Char).Value = GUIAALMACENBE.T_MOVINV
        cmd.Parameters.Add("pf_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("pfor_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("pcco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("pproveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("pctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("pdir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("pfec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("palmac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
        cmd.Parameters.Add("px_m", OracleDbType.Varchar2).Value = GUIAALMACENBE.X_M
        cmd.Parameters.Add("codalm", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ALM_COD
        cmd.Parameters.Add("NOM_CTCT", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NOM_CTCT
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'DEVOLUCION DE STOCK SIN IMPORTAR QUE MOVIMIENTO HAGA O ELIMINE
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ARTICULO_DVSTOCKALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@pT_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@pSER_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@pNRO_DOC_REF", OracleDbType.Char).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("pfec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells(16).Value)), "", RTrim(row.Cells(16).Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(29).Value)), "", RTrim(row.Cells(29).Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells(30).Value)), "", RTrim(row.Cells(30).Value))
            DET_DOCUMENTOBE.FOR_ENT_COD = IIf(IsDBNull(RTrim(row.Cells(31).Value)), "", RTrim(row.Cells(31).Value))
            DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells(34).Value)), "", RTrim(row.Cells(34).Value))
            DET_DOCUMENTOBE.LOTE = IIf(IsDBNull(RTrim(row.Cells(36).Value)), "", RTrim(row.Cells(36).Value))
            DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            contenedor = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            If contenedor.Length > 5 Then
                DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            End If
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells(44).Value)), "", RTrim(row.Cells(44).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))

            If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then
                If GUIAALMACENBE.ALMAC = "E" Then
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATSUMARESTA"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_COD1", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Else
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATRESTASUMA"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_COD1", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                If GUIAALMACENBE.ALMAC = "E" Then
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKSUM"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Else
                    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                    cmd.CommandText = "SP_ARTICULO_UPDATESTKRES"
                    cmd.Connection = sqlCon
                    cmd.Transaction = sqlTrans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ART_COD", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                    cmd.Parameters.Add("@ART_CODALM", OracleDbType.Char).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                    cmd.Parameters.Add("@ART_STOCKACT", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            End If
            If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS002"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ALM_COD)
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@MOV_ART_COD1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
                cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_ELMVALMAANHO_INS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)                   '0
                cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)               '1
                cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)               '2
                cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)                      '3
                cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALM_COD) 'Trim("0001")          '4
                cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)                      '5
                cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE                                 '6
                cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)                        '7
                cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD                             '8
                cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST                                  '9
                cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO                            '10
                cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV                             '11
                cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)               '12
                cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)           '13
                cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)           '14
                cmd.Parameters.Add("@MOV_CCOCOD", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD                              '15
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

            'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            '    cmd.CommandText = "SP_ELMVALMA2019_UPD"
            '    cmd.Connection = sqlCon
            '    cmd.Transaction = sqlTrans
            '    cmd.CommandType = CommandType.StoredProcedure
            '    cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
            '    cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
            '    cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
            '    cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
            '    cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim("0001")
            '    cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
            '    cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
            '    cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            '    cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            '    cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
            '    cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            '    cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
            '    cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
            '    cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
            '    cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
            '    cmd.ExecuteNonQuery()
            '    cmd.Dispose()
        Next
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Actualizo el Documento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub UpdateRowReq(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                            ByVal scodcat As String, ByVal sEst As String)
        Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("part_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.ART_COD
        cmd.Parameters.Add("pfec_gene", OracleDbType.Date).Value = GUIAALMACENBE.FEC_GENE
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
        cmd.Parameters.Add("pmoneda", OracleDbType.Varchar2).Value = GUIAALMACENBE.MONEDA
        cmd.Parameters.Add("pfec_anu", OracleDbType.Date).Value = GUIAALMACENBE.FEC_ANU
        cmd.Parameters.Add("psigno", OracleDbType.Varchar2).Value = GUIAALMACENBE.SIGNO
        cmd.Parameters.Add("pusuario", OracleDbType.Varchar2).Value = GUIAALMACENBE.USUARIO
        cmd.Parameters.Add("pobserva", OracleDbType.Char).Value = GUIAALMACENBE.OBSERVA
        cmd.Parameters.Add("pt_movinv", OracleDbType.Char).Value = GUIAALMACENBE.T_MOVINV
        cmd.Parameters.Add("pf_pago_ent", OracleDbType.Varchar2).Value = GUIAALMACENBE.F_PAGO_ENT
        cmd.Parameters.Add("pfor_ent_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.FOR_ENT_COD
        cmd.Parameters.Add("pcco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
        cmd.Parameters.Add("pproveedor", OracleDbType.Char).Value = Trim(GUIAALMACENBE.PROVEEDOR)
        cmd.Parameters.Add("pctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
        cmd.Parameters.Add("pdir_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.DIR_COD
        cmd.Parameters.Add("per_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.PER_COD
        cmd.Parameters.Add("pfec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
        cmd.Parameters.Add("palmac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC

        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCUMENTO_DEL_ALM"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows

            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCUMENTO_INS_REQ"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CTCT_COD = IIf(IsDBNull(RTrim(row.Cells(6).Value)), "", RTrim(row.Cells(6).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            DET_DOCUMENTOBE.SIGNO = IIf(IsDBNull(RTrim(row.Cells(15).Value)), "", RTrim(row.Cells(15).Value))
            DET_DOCUMENTOBE.OBSERVA = IIf(IsDBNull(RTrim(row.Cells(16).Value)), "", RTrim(row.Cells(16).Value))
            DET_DOCUMENTOBE.T_MOVINV = IIf(IsDBNull(RTrim(row.Cells(17).Value)), "", RTrim(row.Cells(17).Value))
            DET_DOCUMENTOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells(27).Value)), "", RTrim(row.Cells(27).Value))
            DET_DOCUMENTOBE.USUARIO = IIf(IsDBNull(RTrim(row.Cells(28).Value)), "", RTrim(row.Cells(28).Value))
            DET_DOCUMENTOBE.UNIDAD = IIf(IsDBNull(RTrim(row.Cells(29).Value)), "", RTrim(row.Cells(29).Value))
            DET_DOCUMENTOBE.F_PAGO_ENT = IIf(IsDBNull(RTrim(row.Cells(30).Value)), "", RTrim(row.Cells(30).Value))
            DET_DOCUMENTOBE.FOR_ENT_COD = IIf(IsDBNull(RTrim(row.Cells(31).Value)), "", RTrim(row.Cells(31).Value))
            'DET_DOCUMENTOBE.FEC_DIA = IIf(IsDBNull(RTrim(row.Cells(32).Value)), "", RTrim(row.Cells(32).Value))
            DET_DOCUMENTOBE.PROVEEDOR = IIf(IsDBNull(RTrim(row.Cells(33).Value)), "", RTrim(row.Cells(33).Value))
            DET_DOCUMENTOBE.CCO_COD = IIf(IsDBNull(RTrim(row.Cells(34).Value)), "", RTrim(row.Cells(34).Value))
            DET_DOCUMENTOBE.LOTE = IIf(IsDBNull(RTrim(row.Cells(36).Value)), "", RTrim(row.Cells(36).Value))
            DET_DOCUMENTOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells(37).Value)), "", RTrim(row.Cells(37).Value))
            ' DET_DOCUMENTOBE.FEC_LLEG = IIf(IsDBNull(RTrim(row.Cells(12).Value)), "", RTrim(row.Cells(12).Value))
            contenedor = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            If contenedor.Length > 5 Then
                DET_DOCUMENTOBE.FEC_ENT = IIf(IsDBNull(RTrim(row.Cells(10).Value)), GUIAALMACENBE.FEC_ANU, RTrim(row.Cells(10).Value))
            End If
            DET_DOCUMENTOBE.EST = IIf(IsDBNull(RTrim(row.Cells(44).Value)), "", RTrim(row.Cells(44).Value))
            DET_DOCUMENTOBE.ACT_COD = IIf(IsDBNull(RTrim(row.Cells(11).Value)), "", RTrim(row.Cells(11).Value))
            If IIf(IsDBNull(RTrim(row.Cells(45).Value)), "", RTrim(row.Cells(45).Value)) = "4" Then
                DET_DOCUMENTOBE.REQ_APROB = "4"
            Else
                DET_DOCUMENTOBE.REQ_APROB = IIf(IsDBNull(RTrim(row.Cells(45).Value)), "", RTrim(row.Cells(45).Value))
            End If
            DET_DOCUMENTOBE.PESO = Val(IIf(IsDBNull(RTrim(row.Cells("PESO").Value)), 0, RTrim(row.Cells("PESO").Value)))
            DET_DOCUMENTOBE.ART_VENTA = IIf(IsDBNull(RTrim(row.Cells(47).Value)), "", RTrim(row.Cells(47).Value))
            DET_DOCUMENTOBE.LICENCIA = IIf(IsDBNull(RTrim(row.Cells(48).Value)), "", RTrim(row.Cells(48).Value))
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF
            cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_DOC_REF1
            cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SER_DOC_REF1
            cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.NRO_DOC_REF1
            cmd.Parameters.Add("@ctct_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CTCT_COD
            cmd.Parameters.Add("@cantidad", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            cmd.Parameters.Add("@art_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_COD
            cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.SIGNO
            cmd.Parameters.Add("@observa", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.OBSERVA
            cmd.Parameters.Add("@t_movinv", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.T_MOVINV
            cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_GENE
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            cmd.Parameters.Add("@unidad", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.UNIDAD
            cmd.Parameters.Add("@f_pago_ent", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.F_PAGO_ENT
            cmd.Parameters.Add("@for_ent_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.FOR_ENT_COD
            cmd.Parameters.Add("@fec_dia", OracleDbType.Date).Value = GUIAALMACENBE.FEC_DIA
            cmd.Parameters.Add("@proveedor", OracleDbType.Char).Value = DET_DOCUMENTOBE.PROVEEDOR
            cmd.Parameters.Add("@cco_cod", OracleDbType.Varchar2).Value = GUIAALMACENBE.CCO_COD
            cmd.Parameters.Add("@lote", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LOTE
            cmd.Parameters.Add("@per_cod", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.PER_COD
            cmd.Parameters.Add("@fec_ent", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_ENT
            'cmd.Parameters.Add("@fec_lleg", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_LLEG
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
            cmd.Parameters.Add("@almac", OracleDbType.Varchar2).Value = GUIAALMACENBE.ALMAC
            cmd.Parameters.Add("@ACT_COD", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ACT_COD
            cmd.Parameters.Add("@REQ_APROB", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.REQ_APROB)
            cmd.Parameters.Add("@PESO", OracleDbType.Double).Value = DET_DOCUMENTOBE.PESO
            cmd.Parameters.Add("@ART_VENTA", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.ART_VENTA
            cmd.Parameters.Add("@LICEN", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.LICENCIA
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            'cmd.CommandText = "SP_ELMVALMA2019_UPD"
            'cmd.Connection = sqlCon
            'cmd.Transaction = sqlTrans
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@MOV_T_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
            'cmd.Parameters.Add("@MOV_SER_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
            'cmd.Parameters.Add("@MOV_NRO_DOC_REF", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
            'cmd.Parameters.Add("@MOV_TIPO_TRANS", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
            'cmd.Parameters.Add("@MOV_CODALM", OracleDbType.Varchar2).Value = Trim("0001")
            'cmd.Parameters.Add("@MOV_CODART", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
            'cmd.Parameters.Add("@MOV_FECEMI", OracleDbType.Date).Value = DET_DOCUMENTOBE.FEC_GENE
            'cmd.Parameters.Add("@MOV_CODUM", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.UNIDAD)
            'cmd.Parameters.Add("@MOV_CANTID", OracleDbType.Double).Value = DET_DOCUMENTOBE.CANTIDAD
            'cmd.Parameters.Add("@MOV_ESTADO", OracleDbType.Varchar2).Value = GUIAALMACENBE.EST
            'cmd.Parameters.Add("@MOV_CODUSR", OracleDbType.Varchar2).Value = DET_DOCUMENTOBE.USUARIO
            'cmd.Parameters.Add("@MOV_CODTRA", OracleDbType.Varchar2).Value = GUIAALMACENBE.T_MOVINV
            'cmd.Parameters.Add("@MOV_T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
            'cmd.Parameters.Add("@MOV_SER_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
            'cmd.Parameters.Add("@MOV_NRO_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
        Next
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "4"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Actualizo el Requerimiento: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF + "-" + DET_DOCUMENTOBE.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Metodo para anular 
    Private Sub UpdateRowAnularGuia(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                            ByVal scodcat As String, ByVal sEst As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ANUDOCU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        For Each row As DataGridViewRow In dg.Rows
            'If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then
            '    DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
            '    DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value))
            '    DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value))
            '    DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF1").Value)), "", RTrim(row.Cells("T_DOC_REF1").Value))
            '    DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF1").Value)), "", RTrim(row.Cells("SER_DOC_REF1").Value))
            '    DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF1").Value)), "", RTrim(row.Cells("NRO_DOC_REF1").Value))
            '    DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), "", RTrim(row.Cells("CANTIDAD").Value))
            '    DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
            '    DET_DOCUMENTOBE.ART_COD1 = IIf(IsDBNull(RTrim(row.Cells("ART_COD2").Value)), "", RTrim(row.Cells("ART_COD2").Value))
            '    cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            '    cmd.CommandText = "SP_DET_DOCU_UPD_ANULAR2"
            '    cmd.Connection = sqlCon
            '    cmd.Transaction = sqlTrans
            '    cmd.CommandType = CommandType.StoredProcedure
            '    cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
            '    cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
            '    cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
            '    cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
            '    cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
            '    cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
            '    cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "A"
            '    cmd.Parameters.Add("@pART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
            '    cmd.Parameters.Add("@pART_COD1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD1)
            '    cmd.Parameters.Add("@pT_MOVINV", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
            '    cmd.Parameters.Add("@pCANTIDAD", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
            '    cmd.Parameters.Add("@pALM_COD", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALM_COD)
            '    cmd.ExecuteNonQuery()
            '    cmd.Dispose()
            DET_DOCUMENTOBE.T_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(0).Value)), "", RTrim(row.Cells(0).Value))
            DET_DOCUMENTOBE.SER_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(1).Value)), "", RTrim(row.Cells(1).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF = IIf(IsDBNull(RTrim(row.Cells(2).Value)), "", RTrim(row.Cells(2).Value))
            DET_DOCUMENTOBE.T_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(3).Value)), "", RTrim(row.Cells(3).Value))
            DET_DOCUMENTOBE.SER_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(4).Value)), "", RTrim(row.Cells(4).Value))
            DET_DOCUMENTOBE.NRO_DOC_REF1 = IIf(IsDBNull(RTrim(row.Cells(5).Value)), "", RTrim(row.Cells(5).Value))
            DET_DOCUMENTOBE.CANTIDAD = IIf(IsDBNull(RTrim(row.Cells(7).Value)), "", RTrim(row.Cells(7).Value))
            DET_DOCUMENTOBE.ART_COD = IIf(IsDBNull(RTrim(row.Cells(8).Value)), "", RTrim(row.Cells(8).Value))
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DET_DOCU_UPD_ANUTRANS"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
                cmd.Parameters.Add("@fecha", OracleDbType.Varchar2).Value = GUIAALMACENBE.OBSERVA2
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DET_DOCU_UPDANHO_ANULAR"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF)
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
                cmd.Parameters.Add("@t_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
                cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = "A"
                cmd.Parameters.Add("@pART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@pT_MOVINV", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALMAC)
                cmd.Parameters.Add("@pCANTIDAD", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                cmd.Parameters.Add("@pALM_COD", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.ALM_COD)
                cmd.Parameters.Add("@FEC_GENE", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.FEC_GENE)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            If DET_DOCUMENTOBE.T_DOC_REF1 = "SOLM" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DET_DOCU_UPDSOLM_ANULAR"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF)
                cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF)
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7))
                cmd.Parameters.Add("@pART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.Parameters.Add("@pCANTIDAD", OracleDbType.Double).Value = Trim(DET_DOCUMENTOBE.CANTIDAD)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            If DET_DOCUMENTOBE.T_DOC_REF1 = "RFAL" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DET_DOCU_UPDFALL_ANULAR"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            If DET_DOCUMENTOBE.T_DOC_REF1 = "REIN" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DET_DOCU_UPDREIN_ANULAR"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            If DET_DOCUMENTOBE.T_DOC_REF1 = "RPD" Then
                cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
                cmd.CommandText = "SP_DET_DOCU_UPDRPD_ANULAR"
                cmd.Connection = sqlCon
                cmd.Transaction = sqlTrans
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@T_DOC_REF1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
                cmd.Parameters.Add("@ser_doc_ref1", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
                cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = Trim(Mid(DET_DOCUMENTOBE.NRO_DOC_REF1, 1, 7))
                cmd.Parameters.Add("@pART_COD", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.ART_COD)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Next
        If GUIAALMACENBE.T_MOVINV = "E18" Or GUIAALMACENBE.T_MOVINV = "S30" Then
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ANUDOCU"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
            cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
            cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
            cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_DET_DOCU_UPD_ANUTRANS"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.T_DOC_REF1)
            cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.SER_DOC_REF1)
            cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(DET_DOCUMENTOBE.NRO_DOC_REF1)
            cmd.Parameters.Add("@fecha", OracleDbType.Varchar2).Value = GUIAALMACENBE.OBSERVA2
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo la Guia: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF + "-" + DET_DOCUMENTOBE.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub UpdateRowAnularReq(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView,
                            ByVal scodcat As String, ByVal sEst As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DOCUMENTO_UPDATEROW_ANUDOCU"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("pt_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("pser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("pnro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DET_DOCU_UPD_ANULAR_REQ"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.T_DOC_REF)
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.SER_DOC_REF)
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = Trim(GUIAALMACENBE.NRO_DOC_REF)
        cmd.Parameters.Add("pest", OracleDbType.Varchar2).Value = "A"
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "5"
        cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se Anulo la Guia: " + GUIAALMACENBE.T_DOC_REF + "-" + GUIAALMACENBE.SER_DOC_REF + "-" + GUIAALMACENBE.NRO_DOC_REF + "-" + DET_DOCUMENTOBE.FEC_GENE
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Funcion Principal que hara toda la logica para grabar la data
    Public Function SaveRow(ByVal GUIAALMACENBE As GUIAALMACENBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVALMABE As ELMVALMABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                            ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String) As String
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
                InsertRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If

            If flagAccion = "CN" Then
                InsertRowNac(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If
            If flagAccion = "CM" Then
                UpdateRowNac(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If

            If flagAccion = "NR" Then
                InsertRowReq(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If
            If flagAccion = "MR" Then
                UpdateRowReq(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If

            If flagAccion = "M" Then
                UpdateRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If

            If flagAccion = "A" Then
                UpdateRowAnularGuia(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If

            If flagAccion = "AR" Then
                UpdateRowAnularReq(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If
            If flagAccion = "TRANS" Then
                InserTrans(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
            End If
            If flagAccion = "TRANSUPD" Then
                UPDTrans(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, cn, sqlTrans, dg, scodcat, sEst)
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

    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SelectRow", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sT_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function
    Public Function SelectRow2(ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SelectRow1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sS_doc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectObs(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectObs", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
            While dr.Read
                sNomArt = dr.GetString(0)
                If (sNomArt = "0") Then
                    sNomArt = Nothing
                End If
            End While
        End Using
        Return sNomArt

    End Function
    Public Function SelectMOVINV(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELT_MOVIN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
            While dr.Read
                sNomArt = dr.GetString(0)
                If (sNomArt = "0") Then
                    sNomArt = Nothing
                End If
            End While
        End Using
        Return sNomArt

    End Function
    Public Function SelectAlm(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DETDOCU_SELALM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
            While dr.Read
                sNomArt = dr.GetString(0)
                If (sNomArt = "0") Then
                    sNomArt = Nothing
                End If
            End While
        End Using
        Return sNomArt

    End Function

    Public Function SelectDni(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELECTDNI", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
            While dr.Read
                sNomArt = dr.GetString(0)
                If (sNomArt = "0") Then
                    sNomArt = Nothing
                End If
            End While
        End Using
        Return sNomArt

    End Function

    Public Function SelectProv(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SelectProv", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt

    End Function
    Public Function SelectFor_ent(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELFOR_ENT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt

    End Function
    Public Function SelectNUMPEDIDO(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELNUMPEDIDO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
                While dr.Read
                    sNomArt = dr.GetString(0)
                End While
            End Using
            Return sNomArt
        Catch ex As Exception

        End Try


    End Function
    Public Function SelectTotal(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As Double
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Try
            Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOC_LT_TOTAL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                               New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
                While dr.Read
                    sNomArt = dr.GetDouble(0)
                End While
            End Using
            Return sNomArt
        Catch ex As Exception

        End Try


    End Function
    Public Function SelectF_PAGO(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELF_PAGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt

    End Function
    Public Function SelectMONEDA(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELMON", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt

    End Function
    Public Function SelectT_MOVINV(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_SELT_MOVIN", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", sTdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", sSdoc),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", sNdoc)})
            While dr.Read
                sNomArt = dr.GetString(0)
            End While
        End Using
        Return sNomArt

    End Function
    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_DOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectT_DOC1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_DOC1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectT_MOVINV(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_T_MOVINV", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pDOCMOV", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectF_PAGO() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_F_PAGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectF_ENT() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_F_ENT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMoneda() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_MON", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCCosto() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CAPACITACION_CCOSTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
        End
    End Function
    Public Function SelectCCosto1() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ARTICULO_CCOSTO1", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectPer() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PER", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectProv() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_PROV", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectNomColumn(ByVal sNom As String) As DataTable
        'sDim resultado As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBHEADERS_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pHDR_CAMPO", sNom)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_DIR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CTCT_COD", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_REQ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv3(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sLinea As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PRODUCCION_SELECTROW_DET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@linea", sLinea)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv4(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PRODUCCION_SELECTROW_DET1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sT_doc", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sS_doc", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sN_doc", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv5(ByVal sS_doc As String, ByVal sN_doc As String, ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTOREQ", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sS_doc", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sN_doc", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sCod", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv2(ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_RE1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sEst As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECT_ALM1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@est1", sEst)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function getListdgv6(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_SELECTROW_ORD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getListdatos(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTOS_DATOS_LET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ser_doc_ref", sS_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@nro_doc_ref", sN_doc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function getCodArt(ByVal texto_a_buscar As String, ByVal op As Int16) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Select Case op
            Case 1
                Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", texto_a_buscar)})
                    If dr.HasRows Then
                        dt.Load(dr)
                    End If
                End Using
            Case 2
                Using dr As OracleDataReader = Me.GetDataReader("SP_ARTICULO_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", texto_a_buscar)})

                    If dr.HasRows Then
                        dt.Load(dr)
                    End If
                End Using

        End Select


        Return dt
    End Function

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELECTALL_ALM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@t_doc_ref", sT_doc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Public Function SelectAlmac(ByVal sCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_TMOVALM", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CTCT_COD", sCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAllReq(ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SELECTALL_Req", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    Function list(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function

    Public Function SelectDatosCOD(ByVal tipo As String, ByVal serie As String, ByVal nro As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DATOS_DOCU", {New Oracle.ManagedDataAccess.Client.OracleParameter("@TIPO", tipo),
                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@SERIE", serie),
                                                                                                          New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO", nro)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function

    Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH2", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list4(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH4", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list8(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date, ByVal scco As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH10", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@CCO_COD", Trim(scco))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list9(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date, ByVal scco As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH11", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@CCO_COD", Trim(scco))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list10(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date, ByVal scco As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH12", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@CCO_COD", Trim(scco))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function listReq(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal ART As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_REQSEARCH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@ART", Trim(ART))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt
    End Function
    Function list3(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH3", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function

    Function list5(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH5", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function
    Function list7(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
               ByVal fec As Date) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH7", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@FEC_GENE", fec)})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function
    Function list6(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_DOCUMENTO_SEARCH6", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", Trim(tdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@SER_DOC_REF", Trim(sdoc)),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@NRO_DOC_REF", Trim(ndoc))})
            If dr.HasRows Then
                dt.Load(dr)
            End If

        End Using
        Return dt

    End Function
    Public Function SelectAñoMes(ByVal tdoc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_DET_DOCUMENTO_ANO_MES", {New Oracle.ManagedDataAccess.Client.OracleParameter("@T_DOC_REF", tdoc),
                                                                                                                       New Oracle.ManagedDataAccess.Client.OracleParameter("@fec_gene", sAño),
                                                                                                                       New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function


End Class
