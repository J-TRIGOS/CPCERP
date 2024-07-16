Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBSINTOMAS_COVIDDAL

    Inherits BaseDatosORACLE
    Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelectBuscar(ByVal sDni As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBSINTOMAS_COVID_SELECT", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Dni", sDni)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBSINTOMAS_COVID_SELALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Dni", Anho),
                                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@Dni", Mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sTipo As String, ByVal sSer As String, ByVal sNum As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBSINTOMAS_COVID_SELROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Dni", sTipo),
                                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@Dni", sSer),
                                                                                                                         New Oracle.ManagedDataAccess.Client.OracleParameter("@Dni", sNum)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function Ncont() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_ELTBSINTOMAS_COVID_NCONT", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function


    Public Function SaveRowTwo(ByVal ELTBSINTOMAS_COVIDBE As ELTBSINTOMAS_COVIDBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction

        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                InsertRowTwo(ELTBSINTOMAS_COVIDBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UPDATEROW(ELTBSINTOMAS_COVIDBE, cn, sqlTrans)
            End If

            If flagAccion = "A" Then
                UPDANULAR(ELTBSINTOMAS_COVIDBE, cn, sqlTrans)
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

    Private Sub InsertRowTwo(ByVal ELTBSINTOMAS_COVIDBE As ELTBSINTOMAS_COVIDBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSINTOMAS_COVID_INSERT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.t_doc_ref
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.ser_doc_ref
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.nro_doc_ref
        cmd.Parameters.Add("@DNI", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.dni
        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBSINTOMAS_COVIDBE.fec_gene
        cmd.Parameters.Add("@S1", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s1
        cmd.Parameters.Add("@S2", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s2
        cmd.Parameters.Add("@S3", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s3
        cmd.Parameters.Add("@S4", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s4
        cmd.Parameters.Add("@S5", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s5
        cmd.Parameters.Add("@DESCRI", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.descri
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.est

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UPDATEROW(ByVal ELTBSINTOMAS_COVIDBE As ELTBSINTOMAS_COVIDBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSINTOMAS_COVID_UPD"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.t_doc_ref
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.ser_doc_ref
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.nro_doc_ref
        cmd.Parameters.Add("@DNI", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.dni
        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBSINTOMAS_COVIDBE.fec_gene
        cmd.Parameters.Add("@S1", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s1
        cmd.Parameters.Add("@S2", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s2
        cmd.Parameters.Add("@S3", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s3
        cmd.Parameters.Add("@S4", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s4
        cmd.Parameters.Add("@S5", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s5
        cmd.Parameters.Add("@DESCRI", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.descri
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.est

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub UPDANULAR(ByVal ELTBSINTOMAS_COVIDBE As ELTBSINTOMAS_COVIDBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim i As Integer = 0

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBSINTOMAS_COVID_INSERT"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@T_DOC_REF", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.t_doc_ref
        cmd.Parameters.Add("@SER_DOC_REF", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.ser_doc_ref
        cmd.Parameters.Add("@NRO_DOC_REF", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.nro_doc_ref
        cmd.Parameters.Add("@DNI", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.dni
        cmd.Parameters.Add("@FEC_GENE", OracleDbType.Date).Value = ELTBSINTOMAS_COVIDBE.fec_gene
        cmd.Parameters.Add("@S1", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s1
        cmd.Parameters.Add("@S2", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s2
        cmd.Parameters.Add("@S3", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s3
        cmd.Parameters.Add("@S4", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s4
        cmd.Parameters.Add("@S5", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.s5
        cmd.Parameters.Add("@DESCRI", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.descri
        cmd.Parameters.Add("@EST", OracleDbType.Varchar2).Value = ELTBSINTOMAS_COVIDBE.est

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
End Class
