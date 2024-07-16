Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELDOCUMENTODAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String

    Public Function SelectTipodocCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_TDOC_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMonCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_MON_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectProveedorCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_PROVEEDOR_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCuentaCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_CUENTA_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelPerAll(ByVal var As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_PER_ROT_All", {New Oracle.ManagedDataAccess.Client.OracleParameter("@var", var)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMaxLibro() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LIB_CONT_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTRL_DOCUMENTO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarDatosActFlujo(ByVal codFlujo As String, ByVal codCaja As String, ByVal ope As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_OBTENER_DATOSCAJA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODFLUJO", codFlujo),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@CODCAJA", codCaja),
                                                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@OPE", ope)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectTipodoc() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_T_DOCUMENTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectTMOV() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_T_MOVINV", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectChofer() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_T_CHOFER", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMoneda() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_MONEDA", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectProveedor() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_PROVEEDOR", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCliente() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_CLIENTE", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRow(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTRL_DOCUMENTO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", sTDoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", sSDoc),
                                                                                                                  New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", sNDoc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarBanco(ByVal bcoCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_BANCO_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@bcoCOD", bcoCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarMoneda(ByVal monCod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_MON_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@monCOD", monCod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarActFlujo(ByVal actFlujo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_ACTFLUJO_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ACTFLUJO", actFlujo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarActFlujoCaja(ByVal actFlujo As String, ByVal actCaja As String, ByVal ope As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_BUSCAR_ACTFLUJOCAJA_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ACTFLUJO", actFlujo),
                                                                                                                       New Oracle.ManagedDataAccess.Client.OracleParameter("@ACTCAJA", actCaja),
                                                                                                                       New Oracle.ManagedDataAccess.Client.OracleParameter("@OPE", ope)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal ELDOCUMENTOBE As ELDOCUMENTOBE, ByVal flagAccion As String) As String
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
                InsertRow(ELDOCUMENTOBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELDOCUMENTOBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELDOCUMENTOBE, cn, sqlTrans)
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

    Private Sub DeleteRow(ByVal ELDOCUMENTOBE As ELDOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_LIB_CONT_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELDOCUMENTOBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub InsertRow(ByVal ELDOCUMENTOBE As ELDOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CTRL_DOCUMENTO_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_ope", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.t_ope
        cmd.Parameters.Add("@cbco_cod", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.cbco_cod
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.nro_doc_ref
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELDOCUMENTOBE.fec_gene
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.proveedor
        cmd.Parameters.Add("@concepto", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.concepto
        cmd.Parameters.Add("@fec_pago", OracleDbType.Date).Value = ELDOCUMENTOBE.fec_pago
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.moneda
        cmd.Parameters.Add("@tprecio_compra", OracleDbType.Double).Value = ELDOCUMENTOBE.tprecio_compra
        cmd.Parameters.Add("@tprecio_dcompra", OracleDbType.Double).Value = ELDOCUMENTOBE.tprecio_dcompra
        cmd.Parameters.Add("@t_cambio", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.t_cambio
        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.nro_doc_ref1
        cmd.Parameters.Add("@tipo1", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.tipo1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = PERBE.COD  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo turno"
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub UpdateRow(ByVal ELDOCUMENTOBE As ELDOCUMENTOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CTRL_DOCUMENTO_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@t_ope", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.t_ope
        cmd.Parameters.Add("@cbco_cod", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.cbco_cod
        cmd.Parameters.Add("@t_doc_ref", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.t_doc_ref
        cmd.Parameters.Add("@ser_doc_ref", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.ser_doc_ref
        cmd.Parameters.Add("@nro_doc_ref", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.nro_doc_ref
        cmd.Parameters.Add("@fec_gene", OracleDbType.Date).Value = ELDOCUMENTOBE.fec_gene
        cmd.Parameters.Add("@proveedor", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.proveedor
        cmd.Parameters.Add("@concepto", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.concepto
        cmd.Parameters.Add("@fec_pago", OracleDbType.Date).Value = ELDOCUMENTOBE.fec_pago
        cmd.Parameters.Add("@moneda", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.moneda
        cmd.Parameters.Add("@tprecio_compra", OracleDbType.Double).Value = ELDOCUMENTOBE.tprecio_compra
        cmd.Parameters.Add("@tprecio_dcompra", OracleDbType.Double).Value = ELDOCUMENTOBE.tprecio_dcompra
        cmd.Parameters.Add("@t_cambio", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.t_cambio
        cmd.Parameters.Add("@nro_doc_ref1", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.nro_doc_ref1
        cmd.Parameters.Add("@tipo1", OracleDbType.Varchar2).Value = ELDOCUMENTOBE.tipo1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELCONTRATOBE.codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el contrato de: " + ELCONTRATOBE.dni
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LIB_CONT_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
    Public Function SelectTipoCuenta(ByVal tipo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_CUENTA_DOCUMENTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", tipo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class

