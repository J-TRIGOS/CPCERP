Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class CONTABILIDADDAL

    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String

    Public Function ListadoLibroDiario(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_LIBRO_DIARIO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function selectall(ByVal anho As String, ByVal mes As String, ByVal t_ope As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_LIBRO_DIARIO1", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", mes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@t_ope", t_ope)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function ListadoCreditos(ByVal anho As String, ByVal tipo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_CREDITOS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MTIPO", tipo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerLibroDiario(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal stOpe As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_LIBRO_DIARIO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", sTDoc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", sSDoc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", sNDoc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sTOpe", stOpe)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function resumenLD(ByVal manho As String, ByVal mes1 As String, ByVal mes2 As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_RESUMEN_LD_PCP_2D", {New Oracle.ManagedDataAccess.Client.OracleParameter("@PANHO1", manho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@PANHO2", manho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@PMES1", mes1),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@PMES2", mes2)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerLibroDiarioDet(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal sTOpe As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_LIBRO_DIARIO_DET", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", sTDoc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sSDoc", sSDoc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sNDoc", sNDoc),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@sTOpe", sTOpe)})
            If dr.HasRows Then
            End If
            dt.Load(dr)
        End Using
        Return dt
    End Function

    Public Function SelectT_DOC() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_TIPO_DOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", "01")})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectBanco() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_BANCOS", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", "01")})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectMoneda() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_MONEDA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@sTDoc", "01")})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarFormaPago() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_FORMA_PAGO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarCC() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_CC", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarProveedor() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_PROVEEDOR", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerNombreFpago(ByVal COD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_FORMA_PAGO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerNombreCC(ByVal COD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_NOMBRE_CC", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODCC", COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerNombreProveedor(ByVal COD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_NOMBRE_PROVEEDOR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@codProveedor", COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerNombreDocumento(ByVal COD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_NOMBRE_DOCUMENTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@codNombreDoc", COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ObtenerNombreMoneda(ByVal COD As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_NOMBRE_MONEDA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@codMoneda", COD)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarDocumentosLD(ByVal tdoc As String, ByVal nro As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_DOCUMENTO_LD", {New Oracle.ManagedDataAccess.Client.OracleParameter("TDOC", tdoc),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("NRO", nro),
                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCC() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_CC", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCuentas() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SELECT_CUENTAS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarTCambio(ByVal fecha As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_TC_FECHA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@fecha", fecha)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarRegCont(ByVal LibroDiario As LIBRO_DIARIOBE) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_REGCONT", {New Oracle.ManagedDataAccess.Client.OracleParameter("OPE", LibroDiario.T_OPE),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("SERIE", LibroDiario.SER_DOC_REF),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("TIPO", LibroDiario.T_DOC_REF),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("NUMERO", LibroDiario.NRO_DOC_REF)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarUsuario(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_USUARIO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@codigo", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarTDocumento(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_OBTENER_NOMBRE_DOCUMENTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@codigo", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal LibroDiario As LIBRO_DIARIOBE, ByVal mes As String, ByVal anho As String, ByVal flagaccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()

        sqlTrans = cn.BeginTransaction

        Try
            If flagaccion = "N" Then
                InsertRow(LibroDiario, mes, anho, cn, sqlTrans)
                'grabar acceso a los menues
                sqlTrans.Commit()
                resultado = "OK"
            End If
            If flagaccion = "M" Then
                UpdateRow(LibroDiario, mes, anho, cn, sqlTrans)
                'grabar acceso a los menues
                resultado = "OK"
            End If
            If flagaccion = "E" Then
                DeleteRow(LibroDiario, mes, anho, cn, sqlTrans)
                sqlTrans.Commit()
                'grabar acceso a los menues
                resultado = "OK"
            End If
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

    Private Sub DeleteRow(ByVal LibroDiario As LIBRO_DIARIOBE, ByVal mes As String, ByVal anho As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_DELETE_REGISTRO_LD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@NRO", OracleDbType.Varchar2).Value = LibroDiario.NRO_DOC_REF
        cmd.Parameters.Add("@TIPO", OracleDbType.Varchar2).Value = LibroDiario.T_DOC_REF
        cmd.Parameters.Add("@SERIE", OracleDbType.Varchar2).Value = LibroDiario.SER_DOC_REF
        cmd.Parameters.Add("@OPE", OracleDbType.Varchar2).Value = LibroDiario.T_OPE
        cmd.Parameters.Add("@mMES", OracleDbType.Varchar2).Value = mes
        cmd.Parameters.Add("@mANHO", OracleDbType.Varchar2).Value = anho
        cmd.Parameters.Add("@REGCONTA", OracleDbType.Varchar2).Value = LibroDiario.REG_NRO
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function SaveRowDet(ByVal DetLibroDiario As DET_LIBRO_DIARIOBE, ByVal mes As String, ByVal anho As String, ByVal flagaccion As String) As String
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

            If flagaccion = "N" Then
                InsertRowDet(DetLibroDiario, mes, anho, cn, sqlTrans)
                'grabar acceso a los menues
            End If

            If flagaccion = "M" Then

            End If

            'If flagaccion = "M" Then
            '    UpdateRow(PERBE, ASI_CPTOBE, DERECHOHABBE, DHAB_DIRBE, dgvcpto, dgvdep, dgvdirdep, ELMVLOGSBE, cn, sqlTrans)
            'End If

            'If flagaccion = "MM" Then
            '    UpdateRow1(PERBE, ASI_CPTOBE, DERECHOHABBE, DHAB_DIRBE, dgvcpto, dgvdep, dgvdirdep, ELMVLOGSBE, cn, sqlTrans)
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
            'If resultado = "OK" Then
            '    cn.Dispose()
            'End If
            sqlTrans = Nothing
        End Try

        Return resultado
    End Function

    Private Sub InsertRow(ByVal LibroDiario As LIBRO_DIARIOBE, ByVal mes As String, ByVal anho As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        If LibroDiario.REG_NRO = "" Then
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_REGISTRO_LIBRO_DIARIO"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = mes
            cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = anho
            cmd.Parameters.Add("@mT_OPE", OracleDbType.Varchar2).Value = LibroDiario.T_OPE
            cmd.Parameters.Add("@mT_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.T_DOC_REF
            cmd.Parameters.Add("@mSER_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.SER_DOC_REF
            cmd.Parameters.Add("@mNRO_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.NRO_DOC_REF
            cmd.Parameters.Add("@mFEC_GENE", OracleDbType.Varchar2).Value = LibroDiario.FEC_GENE
            cmd.Parameters.Add("@mMONEDA", OracleDbType.Varchar2).Value = LibroDiario.MONEDA
            cmd.Parameters.Add("@mT_CAMB", OracleDbType.Double).Value = LibroDiario.T_CAMB
            cmd.Parameters.Add("@mEST", OracleDbType.Varchar2).Value = LibroDiario.EST
            cmd.Parameters.Add("@mCBCO_COD", OracleDbType.Varchar2).Value = LibroDiario.CBCO_COD
            cmd.Parameters.Add("@mOBSERVA", OracleDbType.Varchar2).Value = LibroDiario.OBSERVA
            cmd.Parameters.Add("@mCOBRANZA", OracleDbType.Varchar2).Value = LibroDiario.COBRANZA
            cmd.Parameters.Add("@mPROVEEDOR", OracleDbType.Varchar2).Value = LibroDiario.PROVEEDOR
            cmd.Parameters.Add("@mT_CAMBIO", OracleDbType.Double).Value = LibroDiario.T_CAMBIO
            cmd.Parameters.Add("@mCCO_COD", OracleDbType.Varchar2).Value = LibroDiario.CCO_COD
            cmd.Parameters.Add("@mREG_NRO", OracleDbType.Varchar2).Value = LibroDiario.REG_NRO
            cmd.Parameters.Add("@mFEC_PAGO", OracleDbType.Varchar2).Value = LibroDiario.FEC_PAGO
            cmd.Parameters.Add("@mTPRECIO_COMPRA", OracleDbType.Double).Value = LibroDiario.TPRECIO_COMPRA
            cmd.Parameters.Add("@mTPRECIO_DCOMPRA", OracleDbType.Double).Value = LibroDiario.TPRECIO_DCOMPRA
            cmd.Parameters.Add("@mUSUARIO", OracleDbType.Varchar2).Value = LibroDiario.USUARIO
            cmd.Parameters.Add("@mFEC_DIA", OracleDbType.Varchar2).Value = LibroDiario.FEC_DIA
            cmd.Parameters.Add("@mF_PAGO_ENT", OracleDbType.Varchar2).Value = LibroDiario.F_PAGO_ENT
            cmd.Parameters.Add("@mT_REGISTRO", OracleDbType.Varchar2).Value = LibroDiario.T_REGISTRO
            cmd.Parameters.Add("@mPROV_PAGO", OracleDbType.Varchar2).Value = LibroDiario.PROV_PAGO
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_BORRAR_DET_LIBRO_DIARIO"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("mT_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.T_DOC_REF
            cmd.Parameters.Add("mSER_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.SER_DOC_REF
            cmd.Parameters.Add("mNRO_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.NRO_DOC_REF
            cmd.Parameters.Add("mT_OPE_COD", OracleDbType.Varchar2).Value = LibroDiario.T_OPE
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
    End Sub

    Private Sub InsertRowDet(ByVal DetLibroDiario As DET_LIBRO_DIARIOBE, ByVal mes As String, ByVal anho As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGISTRO_DET_LIBRO_DIARIO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@mMES", OracleDbType.Varchar2).Value = mes
        cmd.Parameters.Add("@mANHO", OracleDbType.Varchar2).Value = anho
        cmd.Parameters.Add("@mT_DOC_REF", OracleDbType.Varchar2).Value = DetLibroDiario.T_DOC_REF
        cmd.Parameters.Add("@mSER_DOC_REF", OracleDbType.Varchar2).Value = DetLibroDiario.SER_DOC_REF
        cmd.Parameters.Add("@mNRO_DOC_REF", OracleDbType.Varchar2).Value = DetLibroDiario.NRO_DOC_REF
        cmd.Parameters.Add("@mT_DOC_REF1", OracleDbType.Varchar2).Value = DetLibroDiario.T_DOC_REF1
        cmd.Parameters.Add("@mSER_DOC_REF1", OracleDbType.Varchar2).Value = DetLibroDiario.SER_DOC_REF1
        cmd.Parameters.Add("@mNRO_DOC_REF1", OracleDbType.Varchar2).Value = DetLibroDiario.NRO_DOC_REF1
        cmd.Parameters.Add("@mSTATUS", OracleDbType.Varchar2).Value = DetLibroDiario.STATUS
        cmd.Parameters.Add("@mCCO_COD", OracleDbType.Varchar2).Value = DetLibroDiario.CCO_COD
        cmd.Parameters.Add("@mCUENTA", OracleDbType.Varchar2).Value = DetLibroDiario.CUENTA
        cmd.Parameters.Add("@mCUENTA_DEST", OracleDbType.Varchar2).Value = DetLibroDiario.CUENTA_DEST
        cmd.Parameters.Add("@mSIGNO", OracleDbType.Varchar2).Value = DetLibroDiario.SIGNO
        cmd.Parameters.Add("@mFEC_GENE", OracleDbType.Varchar2).Value = DetLibroDiario.FEC_GENE
        cmd.Parameters.Add("@mT_CAMB", OracleDbType.Decimal).Value = DetLibroDiario.T_CAMB
        If DetLibroDiario.TPRECIO_COMPRA = 0 Then
            DetLibroDiario.TPRECIO_COMPRA = Format(DetLibroDiario.TPRECIO_DCOMPRA * DetLibroDiario.T_CAMB, "#.#0")
        End If
        If DetLibroDiario.TPRECIO_DCOMPRA = 0 Then
            DetLibroDiario.TPRECIO_DCOMPRA = Format(DetLibroDiario.TPRECIO_COMPRA / DetLibroDiario.T_CAMB, "#.#0")
        End If
        cmd.Parameters.Add("@mTPRECIO_COMPRA", OracleDbType.Decimal).Value = DetLibroDiario.TPRECIO_COMPRA
        cmd.Parameters.Add("@mTPRECIO_DCOMPRA", OracleDbType.Decimal).Value = DetLibroDiario.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@mMONEDA", OracleDbType.Varchar2).Value = DetLibroDiario.MONEDA
        cmd.Parameters.Add("@mNRO_DOCU1", OracleDbType.Varchar2).Value = DetLibroDiario.NRO_DOCU1
        cmd.Parameters.Add("@mOBSERVA", OracleDbType.Varchar2).Value = DetLibroDiario.OBSERVA
        cmd.Parameters.Add("@mCTCT_COD", OracleDbType.Varchar2).Value = DetLibroDiario.CTCT_COD
        cmd.Parameters.Add("@mPROVEEDR", OracleDbType.Varchar2).Value = DetLibroDiario.PROVEEDOR
        cmd.Parameters.Add("@mX_RET", OracleDbType.Varchar2).Value = DetLibroDiario.X_RET
        cmd.Parameters.Add("@mREG_NRO", OracleDbType.Varchar2).Value = DetLibroDiario.REG_NRO
        cmd.Parameters.Add("@mRETEN", OracleDbType.Varchar2).Value = DetLibroDiario.RETEN
        cmd.Parameters.Add("@mT_OPE_COD", OracleDbType.Varchar2).Value = DetLibroDiario.T_OPE_COD
        cmd.Parameters.Add("@mNUEVO", OracleDbType.Varchar2).Value = DetLibroDiario.NUEVO
        cmd.Parameters.Add("@mCUENTITA", OracleDbType.Varchar2).Value = DetLibroDiario.CUENTITA
        cmd.Parameters.Add("@mI", OracleDbType.Int16).Value = DetLibroDiario.I
        cmd.Parameters.Add("@mREPARAR", OracleDbType.NVarchar2).Value = DetLibroDiario.REPARAR
        cmd.Parameters.Add("@mT_REGISTRO", OracleDbType.Varchar2).Value = DetLibroDiario.T_REGISTRO
        cmd.Parameters.Add("@mCODART", OracleDbType.Varchar2).Value = DetLibroDiario.CODART
        cmd.Parameters.Add("@mPROV_PAGO", OracleDbType.Varchar2).Value = DetLibroDiario.PROV_PAGO
        cmd.Parameters.Add("@mFECVENC", OracleDbType.Varchar2).Value = DetLibroDiario.FEC_VENC
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    'Public Function AsientoLD(ByVal anho As String, ByVal mes As String, ByVal tipOpe As String, ByVal tipDoc As String, ByVal serie As String, ByVal numero As String,
    '                          ByVal codProveedor As String, ByVal Fecha As String, ByVal concepto As String, ByVal regcontable As String) As String
    Public Function AsientoLD(ByVal librodiario As LIBRO_DIARIOBE, ByVal detlibrodiario As DET_LIBRO_DIARIOBE, ByVal mes As String, ByVal anho As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Dim flagAccion = "Asiento"
        Try

            If flagAccion = "Asiento" Then
                'Asiento(cn, sqlTrans, anho, mes, tipOpe, tipDoc, serie, numero, codProveedor, Fecha, concepto, regcontable)
                Asiento(cn, sqlTrans, librodiario, detlibrodiario, mes, anho)
            End If
            'If flagAccion = "AS" Then
            '    Asiento_Todo(cn, sqlTrans, sAño, sMes, sNro, sSer, sTipo, sEst, dg)
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
            '   cn.Dispose()
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function

    'Public Sub Asiento(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
    '                   ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
    '                   ByVal anho As String, ByVal mes As String, ByVal tipOpe As String, ByVal tipDoc As String, ByVal serie As String, ByVal numero As String,
    '                          ByVal codProveedor As String, ByVal Fecha As String, ByVal concepto As String, ByVal regcontable As String)
    '    If regcontable = "" Then
    '        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
    '        cmd.CommandText = "SP_REGCONT_LIBRO_DIARIO"
    '        cmd.Connection = sqlCon
    '        cmd.Transaction = sqlTrans
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.Add("@mMES", OracleDbType.Varchar2).Value = mes
    '        cmd.Parameters.Add("@mANHO", OracleDbType.Varchar2).Value = anho
    '        cmd.Parameters.Add("@mTIPOPE", OracleDbType.Varchar2).Value = tipOpe
    '        cmd.Parameters.Add("@mTIPDOC", OracleDbType.Varchar2).Value = tipDoc
    '        cmd.Parameters.Add("@mSERIE", OracleDbType.Varchar2).Value = serie
    '        cmd.Parameters.Add("@mNUMERO", OracleDbType.Varchar2).Value = numero
    '        cmd.Parameters.Add("@mCODPROVEEDOR", OracleDbType.Varchar2).Value = codProveedor
    '        cmd.Parameters.Add("@mFECHA", OracleDbType.Varchar2).Value = Fecha
    '        cmd.Parameters.Add("@mCONCEPTO", OracleDbType.Varchar2).Value = concepto
    '        cmd.ExecuteNonQuery()
    '        cmd.Dispose()
    '    Else
    '        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
    '        cmd.CommandText = "SP_ACT_REGCONT_LIBRO_DIARIO"
    '        cmd.Connection = sqlCon
    '        cmd.Transaction = sqlTrans
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.Add("@mMES", OracleDbType.Varchar2).Value = Fecha.Substring(3, 2)
    '        cmd.Parameters.Add("@mANHO", OracleDbType.Varchar2).Value = Fecha.Substring(6, 4)
    '        cmd.Parameters.Add("@mTIPOPE", OracleDbType.Varchar2).Value = tipOpe
    '        cmd.Parameters.Add("@mTIPDOC", OracleDbType.Varchar2).Value = tipDoc
    '        cmd.Parameters.Add("@mSERIE", OracleDbType.Varchar2).Value = serie
    '        cmd.Parameters.Add("@mNUMERO", OracleDbType.Varchar2).Value = numero
    '        cmd.Parameters.Add("@mCODPROVEEDOR", OracleDbType.Varchar2).Value = codProveedor
    '        cmd.Parameters.Add("@mFECHA", OracleDbType.Varchar2).Value = Fecha
    '        cmd.Parameters.Add("@mCONCEPTO", OracleDbType.Varchar2).Value = concepto
    '        cmd.Parameters.Add("@mREGCONTABLE", OracleDbType.Varchar2).Value = regcontable
    '        cmd.ExecuteNonQuery()
    '        cmd.Dispose()
    '    End If

    'End Sub

    Public Sub Asiento(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                       ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction,
                       ByVal librodiario As LIBRO_DIARIOBE, ByVal detlibrodiario As DET_LIBRO_DIARIOBE,
                       ByVal mes As String, ByVal anho As String)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_REGCONT_LIBRO_DIARIO"
        'cmd.CommandText = "SP_REGCONT_LIBRO_DIARIO_T"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@MANHO", OracleDbType.Varchar2).Value = anho
        cmd.Parameters.Add("@MMES", OracleDbType.Varchar2).Value = mes
        cmd.Parameters.Add("@MTIPOPE", OracleDbType.Varchar2).Value = librodiario.T_OPE
        cmd.Parameters.Add("@MTIPDOC", OracleDbType.Varchar2).Value = librodiario.T_DOC_REF
        cmd.Parameters.Add("@MSERIE", OracleDbType.Varchar2).Value = librodiario.SER_DOC_REF
        cmd.Parameters.Add("@MNUMERO", OracleDbType.Varchar2).Value = librodiario.NRO_DOC_REF
        cmd.Parameters.Add("@MFECHA", OracleDbType.Varchar2).Value = librodiario.FEC_GENE
        cmd.Parameters.Add("@MCODPROVEEDOR", OracleDbType.Varchar2).Value = librodiario.PROVEEDOR
        cmd.Parameters.Add("@MSEQU", OracleDbType.Varchar2).Value = 0
        cmd.Parameters.Add("@MT_DOC_REF1", OracleDbType.Varchar2).Value = detlibrodiario.T_DOC_REF1
        cmd.Parameters.Add("@MSER_DOC_REF1", OracleDbType.Varchar2).Value = detlibrodiario.SER_DOC_REF1
        cmd.Parameters.Add("@MMREG_NRO", OracleDbType.Varchar2).Value = librodiario.REG_NRO
        cmd.Parameters.Add("@MNRO_DOC_REF1", OracleDbType.Varchar2).Value = detlibrodiario.NRO_DOC_REF1
        cmd.Parameters.Add("@MFEC_GENE_REF1", OracleDbType.Varchar2).Value = detlibrodiario.FEC_GENE
        cmd.Parameters.Add("@MCUENTA", OracleDbType.Varchar2).Value = detlibrodiario.CUENTA
        cmd.Parameters.Add("@MCUENTA_DEST", OracleDbType.Varchar2).Value = detlibrodiario.CUENTA_DEST
        cmd.Parameters.Add("@MCTCT_COD", OracleDbType.Varchar2).Value = detlibrodiario.CTCT_COD
        cmd.Parameters.Add("@MMONEDA", OracleDbType.Varchar2).Value = detlibrodiario.MONEDA
        cmd.Parameters.Add("@MCCO_COD", OracleDbType.Varchar2).Value = detlibrodiario.CCO_COD
        cmd.Parameters.Add("@MMCONCEPTO", OracleDbType.Varchar2).Value = librodiario.OBSERVA
        If detlibrodiario.TPRECIO_COMPRA = 0 Then
            detlibrodiario.TPRECIO_COMPRA = Format(detlibrodiario.TPRECIO_DCOMPRA * detlibrodiario.T_CAMB, "#.#0")
        End If
        If detlibrodiario.TPRECIO_DCOMPRA = 0 Then
            detlibrodiario.TPRECIO_DCOMPRA = Format(detlibrodiario.TPRECIO_COMPRA / detlibrodiario.T_CAMB, "#.#0")
        End If
        cmd.Parameters.Add("@MTPRECIO_COMPRA", OracleDbType.Double).Value = detlibrodiario.TPRECIO_COMPRA
        cmd.Parameters.Add("@MTPRECIO_DCOMPRA", OracleDbType.Double).Value = detlibrodiario.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@MRUC", OracleDbType.Varchar2).Value = "20100279348"
        cmd.Parameters.Add("@MSIGNO", OracleDbType.Varchar2).Value = detlibrodiario.SIGNO
        cmd.Parameters.Add("@MT_CAMB", OracleDbType.Double).Value = detlibrodiario.T_CAMB
        cmd.Parameters.Add("@MT_REGISTRO", OracleDbType.Varchar2).Value = detlibrodiario.T_REGISTRO
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Function VerificarNumeroContable(ByVal tipOpe As String, ByVal mes As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_NUMCONTABLE_LD", {New Oracle.ManagedDataAccess.Client.OracleParameter("TIPOPE", tipOpe),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MES", mes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("ANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarRegistroContable(ByVal libroDiario As LIBRO_DIARIOBE) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_REGISTRO_CONTABLE", {New Oracle.ManagedDataAccess.Client.OracleParameter("TIPOPE", libroDiario.T_OPE),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("FECHA", libroDiario.FEC_GENE),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("NRODOC", libroDiario.NRO_DOC_REF)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarCuentaDestino(ByVal cuenta As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_CUENTA_DESTINO", {New Oracle.ManagedDataAccess.Client.OracleParameter("CUENTA", cuenta),
                                                                                     New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarDocumentosClientes(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_SEGUIMIENTO_DOC_CLIENTE", {New Oracle.ManagedDataAccess.Client.OracleParameter("NMES", mes),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("NANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Private Sub UpdateRow(ByVal LibroDiario As LIBRO_DIARIOBE, ByVal mes As String, ByVal anho As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_UPDATE_LIBRO_DIARIO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@MES", OracleDbType.Varchar2).Value = mes
        cmd.Parameters.Add("@ANHO", OracleDbType.Varchar2).Value = anho
        cmd.Parameters.Add("@mT_OPE", OracleDbType.Varchar2).Value = LibroDiario.T_OPE
        cmd.Parameters.Add("@mT_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.T_DOC_REF
        cmd.Parameters.Add("@mSER_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.SER_DOC_REF
        cmd.Parameters.Add("@mNRO_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.NRO_DOC_REF
        cmd.Parameters.Add("@mFEC_GENE", OracleDbType.Varchar2).Value = LibroDiario.FEC_GENE
        cmd.Parameters.Add("@mMONEDA", OracleDbType.Varchar2).Value = LibroDiario.MONEDA
        cmd.Parameters.Add("@mT_CAMB", OracleDbType.Double).Value = LibroDiario.T_CAMB
        cmd.Parameters.Add("@mEST", OracleDbType.Varchar2).Value = LibroDiario.EST
        cmd.Parameters.Add("@mCBCO_COD", OracleDbType.Varchar2).Value = LibroDiario.CBCO_COD
        cmd.Parameters.Add("@mOBSERVA", OracleDbType.Varchar2).Value = LibroDiario.OBSERVA
        cmd.Parameters.Add("@mCOBRANZA", OracleDbType.Varchar2).Value = LibroDiario.COBRANZA
        cmd.Parameters.Add("@mPROVEEDOR", OracleDbType.Varchar2).Value = LibroDiario.PROVEEDOR
        cmd.Parameters.Add("@mT_CAMBIO", OracleDbType.Double).Value = LibroDiario.T_CAMBIO
        cmd.Parameters.Add("@mCCO_COD", OracleDbType.Varchar2).Value = LibroDiario.CCO_COD
        cmd.Parameters.Add("@mREG_NRO", OracleDbType.Varchar2).Value = LibroDiario.REG_NRO
        cmd.Parameters.Add("@mFEC_PAGO", OracleDbType.Varchar2).Value = LibroDiario.FEC_PAGO
        cmd.Parameters.Add("@mTPRECIO_COMPRA", OracleDbType.Varchar2).Value = LibroDiario.TPRECIO_COMPRA
        cmd.Parameters.Add("@mTPRECIO_DCOMPRA", OracleDbType.Varchar2).Value = LibroDiario.TPRECIO_DCOMPRA
        cmd.Parameters.Add("@mUSUARIO", OracleDbType.Varchar2).Value = LibroDiario.USUARIO
        cmd.Parameters.Add("@mFEC_DIA", OracleDbType.Varchar2).Value = LibroDiario.FEC_DIA
        cmd.Parameters.Add("@mF_PAGO_ENT", OracleDbType.Varchar2).Value = LibroDiario.F_PAGO_ENT
        cmd.Parameters.Add("@mT_REGISTRO", OracleDbType.Varchar2).Value = LibroDiario.T_REGISTRO
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cmd1 As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd1.CommandText = "SP_BORRAR_DET_LIBRO_DIARIO"
        cmd1.Connection = sqlCon
        cmd1.Transaction = sqlTrans
        cmd1.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd1.Parameters.Add("mT_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.T_DOC_REF
        cmd1.Parameters.Add("mSER_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.SER_DOC_REF
        cmd1.Parameters.Add("mNRO_DOC_REF", OracleDbType.Varchar2).Value = LibroDiario.NRO_DOC_REF
        cmd1.Parameters.Add("mT_OPE_COD", OracleDbType.Varchar2).Value = LibroDiario.T_OPE
        cmd1.ExecuteNonQuery()
        cmd1.Dispose()
    End Sub

    Public Function actualizarTablaMOVCT(ByVal librodiario As LIBRO_DIARIOBE, ByVal mmes As String, ByVal manho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ACTUALIZAR_MOVCT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@OPE", librodiario.T_OPE),
                                                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@REGCONT", librodiario.REG_NRO),
                                                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mmes),
                                                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", manho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRowAllMes(ByVal flagAccion As String, ByVal sAño As String, ByVal sMes As String, ByVal usuario As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            If flagAccion = "AsAll" Then
                AsientoAll(cn, sAño, sMes, sqlTrans, usuario)
            End If
            If flagAccion = "AsAll1" Then
                AsientoAll1(cn, sAño, sMes, sqlTrans, usuario)
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
    Public Sub AsientoAll(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String,
                        ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal usuario As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CONTLIBRO_DIARIO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Public Sub AsientoAll1(ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection, ByVal sAño As String, ByVal sMes As String,
                    ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal usuario As String)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CONTLIBRO_LIQ"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@sAño", OracleDbType.Varchar2).Value = Trim(sAño)
        cmd.Parameters.Add("@sMes", OracleDbType.Varchar2).Value = Trim(sMes)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
End Class
