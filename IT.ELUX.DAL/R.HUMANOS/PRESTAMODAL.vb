Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class PRESTAMODAL

    Inherits BaseDatosORACLE

    Public Function BuscarListadoPrestamos(ByVal ANHO As String, ByVal est As String, ByVal tipo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_PRESTAMOS", {New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", ANHO),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MEST", est),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MTIPO", tipo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarNomDocumento(ByVal tipo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_NOMBRE_TDOC", {New Oracle.ManagedDataAccess.Client.OracleParameter("MTIPO", tipo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarNumPrdo(ByVal prdo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_NOMPRDO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MPRDO", prdo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function


    Public Function VerificarNumero(ByVal tipo As String, ByVal serie As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_VERIFICAR_NUMPRESTAMO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MTIPO", tipo),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("MSERIE", serie)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function BuscarPeriodo(ByVal fecha As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_PERIODO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MFECHA", fecha)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function NuevoPeriodo(ByVal prdo As String, ByVal fecha As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_BUSCAR_NUEVOPERIODO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MPRDO", prdo),
                                                                              New Oracle.ManagedDataAccess.Client.OracleParameter("MFECHA", fecha)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SaveRow(ByVal PRESTAMOBE As PRESTAMOBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Dim resultado As String = "OK"
        Dim cn1 As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn1 = ConnectionBegin()
        sqlTrans = cn1.BeginTransaction

        Try
            If flagAccion = "N" Then
                InsertRow(PRESTAMOBE, cn1, sqlTrans, dg)
            End If

            If flagAccion = "M" Then
                UpdateRow(PRESTAMOBE, cn1, sqlTrans, dg)
            End If

            'If flagAccion = "E" Then
            '    DeleteRow(PRESTAMOBE, cn, sqlTrans)
            'End If

            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            sqlTrans = Nothing

        End Try

        Return resultado

    End Function
    Private Sub InsertRow(ByVal PRESTAMOBE As PRESTAMOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0
        Dim DETPRESTAMOBE As New DETPRESTAMOBE
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PRESTAMOS_INSERT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@MTIPO_DOC", OracleDbType.Varchar2).Value = PRESTAMOBE.TIPO_DOC
        cmd.Parameters.Add("@MSER_DOC", OracleDbType.Varchar2).Value = PRESTAMOBE.SER_DOC
        cmd.Parameters.Add("@MNRO_DOC", OracleDbType.Varchar2).Value = PRESTAMOBE.NUM_DOC
        cmd.Parameters.Add("@MPER_COD", OracleDbType.Varchar2).Value = PRESTAMOBE.PER_COD
        cmd.Parameters.Add("@MMONTO", OracleDbType.Varchar2).Value = PRESTAMOBE.MONTO
        cmd.Parameters.Add("@MCUOTAS", OracleDbType.Varchar2).Value = PRESTAMOBE.CUOTA
        cmd.Parameters.Add("@MFECHA", OracleDbType.Varchar2).Value = PRESTAMOBE.FEC_GENE
        cmd.Parameters.Add("@MEST", OracleDbType.Varchar2).Value = PRESTAMOBE.EST
        cmd.Parameters.Add("@MUSUARIO", OracleDbType.Varchar2).Value = PRESTAMOBE.USUARIO
        cmd.Parameters.Add("@MFEC1RA", OracleDbType.Varchar2).Value = PRESTAMOBE.FECHA1RA
        cmd.Parameters.Add("@MOBS", OracleDbType.Varchar2).Value = PRESTAMOBE.OBS
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PRESTAMO_INSDET"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            DETPRESTAMOBE.TIPO_DOC = PRESTAMOBE.TIPO_DOC
            DETPRESTAMOBE.SER_DOC = PRESTAMOBE.SER_DOC
            DETPRESTAMOBE.NUM_DOC = PRESTAMOBE.NUM_DOC
            DETPRESTAMOBE.PER_COD = PRESTAMOBE.PER_COD
            DETPRESTAMOBE.CUOTA = IIf(IsDBNull(RTrim(row.Cells("CUOTA").Value)), "", RTrim(row.Cells("CUOTA").Value))
            DETPRESTAMOBE.MONTO = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), "", RTrim(row.Cells("MONTO").Value))
            DETPRESTAMOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FECVENC").Value)), "", RTrim(row.Cells("FECVENC").Value))
            DETPRESTAMOBE.PRDO = IIf(IsDBNull(RTrim(row.Cells("PRDO").Value)), "", RTrim(row.Cells("PRDO").Value))
            DETPRESTAMOBE.EST = IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value))
            Dim TIPO = IIf(IsDBNull(RTrim(row.Cells("TPAGO").Value)), "", RTrim(row.Cells("TPAGO").Value))

            Select Case TIPO
                Case "PLANILLA"
                    DETPRESTAMOBE.TIPO = "P"
                Case "GRATIFICACION"
                    DETPRESTAMOBE.TIPO = "G"
                Case "LIQUIDACION"
                    DETPRESTAMOBE.TIPO = "L"
                Case Else
                    DETPRESTAMOBE.TIPO = "P"
            End Select



            If DETPRESTAMOBE.EST = "PENDIENTE" Then
                DETPRESTAMOBE.EST = "P"
            End If
            If DETPRESTAMOBE.EST = "PAGADO" Then
                DETPRESTAMOBE.EST = "H"
            End If

            cmd.Parameters.Add("@MTIPO_DOC", OracleDbType.Varchar2).Value = DETPRESTAMOBE.TIPO_DOC
            cmd.Parameters.Add("@MSER_DOC", OracleDbType.Varchar2).Value = DETPRESTAMOBE.SER_DOC
            cmd.Parameters.Add("@MNRO_DOC", OracleDbType.Varchar2).Value = DETPRESTAMOBE.NUM_DOC
            cmd.Parameters.Add("@MPER_COD", OracleDbType.Varchar2).Value = DETPRESTAMOBE.PER_COD
            cmd.Parameters.Add("@MCUOTA", OracleDbType.Varchar2).Value = DETPRESTAMOBE.CUOTA
            cmd.Parameters.Add("@mMONTO_CUOTA", OracleDbType.Varchar2).Value = DETPRESTAMOBE.MONTO
            cmd.Parameters.Add("@MFEC_VENC", OracleDbType.Varchar2).Value = DETPRESTAMOBE.FEC_GENE
            cmd.Parameters.Add("@MPRDO_PAGO", OracleDbType.Varchar2).Value = DETPRESTAMOBE.PRDO
            cmd.Parameters.Add("@MEST_CUOTA", OracleDbType.Varchar2).Value = DETPRESTAMOBE.EST
            cmd.Parameters.Add("@MTPAGO", OracleDbType.Varchar2).Value = DETPRESTAMOBE.TIPO
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub

    Private Sub UpdateRow(ByVal PRESTAMOBE As PRESTAMOBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dg As DataGridView)
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0
        Dim DETPRESTAMOBE As New DETPRESTAMOBE
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_PRESTAMOS_UPDATE"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@MTIPO_DOC", OracleDbType.Varchar2).Value = PRESTAMOBE.TIPO_DOC
        cmd.Parameters.Add("@MSER_DOC", OracleDbType.Varchar2).Value = PRESTAMOBE.SER_DOC
        cmd.Parameters.Add("@MNRO_DOC", OracleDbType.Varchar2).Value = PRESTAMOBE.NUM_DOC
        cmd.Parameters.Add("@MPER_COD", OracleDbType.Varchar2).Value = PRESTAMOBE.PER_COD
        cmd.Parameters.Add("@MMONTO", OracleDbType.Varchar2).Value = PRESTAMOBE.MONTO
        cmd.Parameters.Add("@MCUOTAS", OracleDbType.Varchar2).Value = PRESTAMOBE.CUOTA
        cmd.Parameters.Add("@MFECHA", OracleDbType.Varchar2).Value = PRESTAMOBE.FEC_GENE
        cmd.Parameters.Add("@MEST", OracleDbType.Varchar2).Value = PRESTAMOBE.EST
        cmd.Parameters.Add("@MUSUARIO", OracleDbType.Varchar2).Value = PRESTAMOBE.USUARIO
        cmd.Parameters.Add("@MFEC1RA", OracleDbType.Varchar2).Value = PRESTAMOBE.FECHA1RA
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Dim cont As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            cont = cont + 1
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_PRESTAMO_INSDET"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure

            DETPRESTAMOBE.TIPO_DOC = PRESTAMOBE.TIPO_DOC
            DETPRESTAMOBE.SER_DOC = PRESTAMOBE.SER_DOC
            DETPRESTAMOBE.NUM_DOC = PRESTAMOBE.NUM_DOC
            DETPRESTAMOBE.PER_COD = PRESTAMOBE.PER_COD
            DETPRESTAMOBE.CUOTA = IIf(IsDBNull(RTrim(row.Cells("CUOTA").Value)), "", RTrim(row.Cells("CUOTA").Value))
            DETPRESTAMOBE.MONTO = IIf(IsDBNull(RTrim(row.Cells("MONTO").Value)), "", RTrim(row.Cells("MONTO").Value))
            DETPRESTAMOBE.FEC_GENE = IIf(IsDBNull(RTrim(row.Cells("FECVENC").Value)), "", RTrim(row.Cells("FECVENC").Value))
            DETPRESTAMOBE.PRDO = IIf(IsDBNull(RTrim(row.Cells("PRDO").Value)), "", RTrim(row.Cells("PRDO").Value))
            DETPRESTAMOBE.EST = IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value))
            If DETPRESTAMOBE.EST = "PENDIENTE" Then
                DETPRESTAMOBE.EST = "P"
            End If
            If DETPRESTAMOBE.EST = "PAGADO" Then
                DETPRESTAMOBE.EST = "H"
            End If

            cmd.Parameters.Add("@MTIPO_DOC", OracleDbType.Varchar2).Value = DETPRESTAMOBE.TIPO_DOC
            cmd.Parameters.Add("@MSER_DOC", OracleDbType.Varchar2).Value = DETPRESTAMOBE.SER_DOC
            cmd.Parameters.Add("@MNRO_DOC", OracleDbType.Varchar2).Value = DETPRESTAMOBE.NUM_DOC
            cmd.Parameters.Add("@MPER_COD", OracleDbType.Varchar2).Value = DETPRESTAMOBE.PER_COD
            cmd.Parameters.Add("@MCUOTA", OracleDbType.Varchar2).Value = DETPRESTAMOBE.CUOTA
            cmd.Parameters.Add("@mMONTO_CUOTA", OracleDbType.Varchar2).Value = DETPRESTAMOBE.MONTO
            cmd.Parameters.Add("@MFEC_VENC", OracleDbType.Varchar2).Value = DETPRESTAMOBE.FEC_GENE
            cmd.Parameters.Add("@MPRDO_PAGO", OracleDbType.Varchar2).Value = DETPRESTAMOBE.PRDO
            cmd.Parameters.Add("@MEST_CUOTA", OracleDbType.Varchar2).Value = DETPRESTAMOBE.EST
            Dim TIPO = IIf(IsDBNull(RTrim(row.Cells("TPAGO").Value)), "", RTrim(row.Cells("TPAGO").Value))
            Select Case TIPO
                Case "PLANILLA"
                    DETPRESTAMOBE.TIPO = "P"
                Case "GRATIFICACION"
                    DETPRESTAMOBE.TIPO = "G"
                Case "LIQUIDACION"
                    DETPRESTAMOBE.TIPO = "L"
                Case Else
                    DETPRESTAMOBE.TIPO = "P"
            End Select

            cmd.Parameters.Add("@MTPAGO", OracleDbType.Varchar2).Value = DETPRESTAMOBE.TIPO
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
    End Sub


    Public Function GetData(ByVal tipo As String, ByVal serie As String, ByVal numero As String, ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_GETDATA_PRESTAMO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MTIPO", tipo),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("MSERIE", serie),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("MNUMERO", numero),
                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("MCODIGO", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function GetDetData(ByVal tipo As String, ByVal serie As String, ByVal numero As String, ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_GETDETDATA_PRESTAMO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MTIPO", tipo),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("MSERIE", serie),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("MNUMERO", numero),
                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("MCODIGO", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function ListadoCC(ByVal mes As String, ByVal anho As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_LISTADO_CCPRESTAMO", {New Oracle.ManagedDataAccess.Client.OracleParameter("MMES", mes),
                                                                                New Oracle.ManagedDataAccess.Client.OracleParameter("MANHO", anho)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

End Class
