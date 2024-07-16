Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class PRODUCCIONDAL

    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String

    Public Function SelectCC() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_PROCESOS", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarSanciones() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_SANCIONES", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarDatosPersonalLinea(ByVal cc As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_PER_LINEA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CC", cc)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarOrdenProduccion() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_OP_BONO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarListadoOP() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAROP", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarProcXArticulo(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_PROC_X_ART", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CDIGO", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAllBPJefe(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BONO_APRO_JEFE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectAllBPPlanta(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BONO_APRO_PLANTA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAllBPRRHH(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BONO_APRO_RRHH", {New Oracle.ManagedDataAccess.Client.OracleParameter("@MANHO", anho),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MMES", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarOperacionxProceso(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBREPO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@pRPO_CODPROC", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal BONOPRODUCCION As BONOPRODBE, ByVal flagaccion As String) As String
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
                InsertRow(BONOPRODUCCION, cn, sqlTrans)
                'grabar acceso a los menues
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

    Private Sub InsertRow(ByVal BONOPRODUCCION As BONOPRODBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_BONOPRODUCCION_REGISTRO"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@pPER_COD", OracleDbType.Varchar2).Value = BONOPRODUCCION.PER_COD
        cmd.Parameters.Add("@pEMPLEADO", OracleDbType.Varchar2).Value = BONOPRODUCCION.EMPLEADO
        cmd.Parameters.Add("@pORD_PROD", OracleDbType.Varchar2).Value = BONOPRODUCCION.ORD_PROD
        cmd.Parameters.Add("@pCOD_ART", OracleDbType.Varchar2).Value = BONOPRODUCCION.COD_ART
        cmd.Parameters.Add("@pARTICULO", OracleDbType.Varchar2).Value = BONOPRODUCCION.ARTICULO
        cmd.Parameters.Add("@pCANTIDAD", OracleDbType.Double).Value = BONOPRODUCCION.CANTIDAD
        cmd.Parameters.Add("@pCOD_LINEA", OracleDbType.Varchar2).Value = BONOPRODUCCION.COD_LINEA
        cmd.Parameters.Add("@pNOM_LINEA", OracleDbType.Varchar2).Value = BONOPRODUCCION.NOM_LINEA
        cmd.Parameters.Add("@pFEC_PROD", OracleDbType.Varchar2).Value = BONOPRODUCCION.FEC_PROD
        cmd.Parameters.Add("@pNOM_PROCESO", OracleDbType.Varchar2).Value = BONOPRODUCCION.NOM_PROCESO
        cmd.Parameters.Add("@pUNIDHORA", OracleDbType.Double).Value = BONOPRODUCCION.UNIDHORA
        cmd.Parameters.Add("@pPROD_OPER", OracleDbType.Double).Value = BONOPRODUCCION.PROD_OPER
        cmd.Parameters.Add("@pHORA_INI", OracleDbType.Varchar2).Value = BONOPRODUCCION.HORA_INI
        cmd.Parameters.Add("@pHORA_FIN", OracleDbType.Varchar2).Value = BONOPRODUCCION.HORA_FIN
        cmd.Parameters.Add("@pPROD_DIA", OracleDbType.Double).Value = BONOPRODUCCION.PROD_DIA
        cmd.Parameters.Add("@pIND_PROD", OracleDbType.Double).Value = BONOPRODUCCION.IND_PROD
        cmd.Parameters.Add("@pUSUARIO", OracleDbType.Varchar2).Value = BONOPRODUCCION.USUARIO
        cmd.Parameters.Add("@pFEC_REGISTRO", OracleDbType.Varchar2).Value = BONOPRODUCCION.FEC_REGISTRO

        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function BuscarOperacionxProceso(ByVal anho As String, ByVal mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_BONO_PROD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", anho),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@MES", mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarLineaPersona(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LINEA_X_EMPLEADO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@CODIGO", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Sub ActualizadProcesos(ByVal codOperacion As String, ByVal codProceso As String, ByVal cantidad As String)
        Dim cn1 As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans1 As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn1 = ConnectionBegin()
        'cn1.Open()
        sqlTrans1 = cn1.BeginTransaction
        Try
            'N:Nuevo   M:Modificar   E:Eliminar 
            UpdateRowFracc(codOperacion, codProceso, cantidad, cn1, sqlTrans1)
            sqlTrans1.Commit()
        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans1.Rollback()
        Catch ex As Exception
            sqlTrans1.Rollback()
        Finally
            sqlTrans1 = Nothing
        End Try
    End Sub

    Public Sub UpdateRowFracc(ByVal codOperacion As String, ByVal codProceso As String, ByVal cantidad As String, ByVal sqlCon1 As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans1 As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ACTUALIZAR_UNID_FRACC"
        cmd.Connection = sqlCon1
        cmd.Transaction = sqlTrans1
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@CODOPERACION", OracleDbType.Varchar2).Value = codOperacion
        cmd.Parameters.Add("@CODPROCESO", OracleDbType.Varchar2).Value = codProceso
        cmd.Parameters.Add("@CANTIDAD", OracleDbType.Varchar2).Value = cantidad
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Sub ActualizarBonosProduccion(ByVal dt As DataTable)
        Dim cn1 As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans1 As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn1 = ConnectionBegin()
        'cn1.Open()
        sqlTrans1 = cn1.BeginTransaction
        Try
            'N:Nuevo   M:Modificar   E:Eliminar 
            UpdateProcesos(dt, cn1, sqlTrans1)
            sqlTrans1.Commit()
        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans1.Rollback()
        Catch ex As Exception
            sqlTrans1.Rollback()
        Finally
            sqlTrans1 = Nothing
        End Try
    End Sub

    Public Sub UpdateProcesos(ByVal dt As DataTable, ByVal sqlCon1 As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans1 As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String
        For i = 0 To dt.Rows.Count - 1
            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ACT_BONOSPRODU"
            cmd.Connection = sqlCon1
            cmd.Transaction = sqlTrans1
            cmd.CommandType = CommandType.StoredProcedure
            'Los parametros que va recibir son las propiedades de la clase 
            cmd.Parameters.Add("@FECHA", OracleDbType.Varchar2).Value = dt.Rows(i).Item(7)
            cmd.Parameters.Add("@CODART", OracleDbType.Varchar2).Value = dt.Rows(i).Item(3)
            cmd.Parameters.Add("@DESCR", OracleDbType.Varchar2).Value = dt.Rows(i).Item(8)
            cmd.Parameters.Add("@CODIGO", OracleDbType.Varchar2).Value = dt.Rows(i).Item(0)
            cmd.Parameters.Add("@COD_PROD", OracleDbType.Varchar2).Value = dt.Rows(i).Item(2)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub
    Public Function ActualizarEstBP(ByVal tipo As String, ByVal perCod As String, ByVal ordProd As String, ByVal fecha As String, ByVal proceso As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()

        sqlTrans = cn.BeginTransaction

        Try
            UpdateBonoProd(tipo, perCod, ordProd, fecha, proceso, cn, sqlTrans)
            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally

            sqlTrans = Nothing
        End Try

        Return resultado
    End Function

    Public Sub UpdateBonoProd(ByVal tipo As String, ByVal perCod As String, ByVal ordProd As String, ByVal fecha As String, ByVal proceso As String, ByVal sqlCon1 As Oracle.ManagedDataAccess.Client.OracleConnection,
                        ByVal sqlTrans1 As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim contenedor As String

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand

        cmd.CommandText = "SP_ACT_EST_BONPROD"
        cmd.Connection = sqlCon1
            cmd.Transaction = sqlTrans1
            cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@MTIPO", OracleDbType.Varchar2).Value = tipo
        cmd.Parameters.Add("@MPERCOD", OracleDbType.Varchar2).Value = perCod
        cmd.Parameters.Add("@MORDPROD", OracleDbType.Varchar2).Value = ordProd
        cmd.Parameters.Add("@MFECHA", OracleDbType.Varchar2).Value = fecha
        cmd.Parameters.Add("@MPROCESO", OracleDbType.Varchar2).Value = proceso
        cmd.ExecuteNonQuery()
            cmd.Dispose()

    End Sub
End Class
