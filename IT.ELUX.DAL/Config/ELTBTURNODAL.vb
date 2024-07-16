﻿Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class ELTBTURNODAL
    Inherits BaseDatosORACLE
    Public sNomArt As String
    Public Function SelectRow(ByVal sCode As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTURNO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@sMes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sMes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTURNO_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode),
                                                                                                                   New Oracle.ManagedDataAccess.Client.OracleParameter("@sMes", sMes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SaveRow(ByVal ELTBTURNOBE As ELTBTURNOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal dgtareo As DataGridView) As String
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
                InsertRow(ELTBTURNOBE, ELMVLOGSBE, cn, sqlTrans, dgtareo)
            End If
            If flagAccion = "NG" Then
                InsertRowGrupo(ELTBTURNOBE, ELMVLOGSBE, cn, sqlTrans, dgtareo)
            End If
            If flagAccion = "M" Then
                UpdateRow(ELTBTURNOBE, ELMVLOGSBE, cn, sqlTrans, dgtareo)
            End If
            If flagAccion = "E" Then
                DeleteRow(ELTBTURNOBE, ELMVLOGSBE, cn, sqlTrans)
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
    Private Sub InsertRow(ByVal ELTBTURNOBE As ELTBTURNOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)
        Dim count As Integer
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBTURNO_INSROW"
            count = count + 1
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBTURNOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            ELTBTURNOBE.FEC_INICIO = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
            ELTBTURNOBE.FEC_FIN = IIf(IsDBNull(RTrim(row.Cells("FEC_FIN").Value)), "", RTrim(row.Cells("FEC_FIN").Value))
            'ELTBTURNOBE.INDICE = IIf(IsDBNull(RTrim(row.Cells("INDICE").Value)), "", RTrim(row.Cells("INDICE").Value))
            If IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "Habilitado" Then
                ELTBTURNOBE.EST = "H"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "Anulado" Then
                ELTBTURNOBE.EST = "A"
            Else
                ELTBTURNOBE.EST = ""
            End If

            cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBTURNOBE.PER_COD
            cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = ELTBTURNOBE.FEC_INICIO
            cmd.Parameters.Add("@fecha_ing", OracleDbType.Date).Value = ELTBTURNOBE.FEC_FIN
            cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELTBTURNOBE.MES
            cmd.Parameters.Add("@indice", OracleDbType.Varchar2).Value = ELTBTURNOBE.INDICE + count - 1
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBTURNOBE.USUARIO
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBTURNOBE.EST
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        ''cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = .id  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro la asistencia : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Private Sub InsertRowGrupo(ByVal ELTBTURNOBE As ELTBTURNOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                         ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)
        Dim count As Integer
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        For Each row As DataGridViewRow In dgtareo.Rows
            cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBTURNO_INSROW"
            count = count + 1
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
            ELTBTURNOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
            ELTBTURNOBE.FEC_INICIO = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
            ELTBTURNOBE.FEC_FIN = IIf(IsDBNull(RTrim(row.Cells("FEC_FIN").Value)), "", RTrim(row.Cells("FEC_FIN").Value))
            'ELTBTURNOBE.INDICE = IIf(IsDBNull(RTrim(row.Cells("INDICE").Value)), "", RTrim(row.Cells("INDICE").Value))
            If IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "Habilitado" Then
                ELTBTURNOBE.EST = "H"
            ElseIf IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "Anulado" Then
                ELTBTURNOBE.EST = "A"
            Else
                ELTBTURNOBE.EST = ""
            End If

            cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBTURNOBE.PER_COD
            cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = ELTBTURNOBE.FEC_INICIO
            cmd.Parameters.Add("@fecha_ing", OracleDbType.Date).Value = ELTBTURNOBE.FEC_FIN
            cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELTBTURNOBE.MES
            cmd.Parameters.Add("@indice", OracleDbType.Varchar2).Value = ELTBTURNOBE.INDICE + count - 1
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBTURNOBE.USUARIO
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBTURNOBE.EST
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        ''cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = .id  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro la asistencia : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELTBTURNOBE As ELTBTURNOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction, ByVal dgtareo As DataGridView)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim cont As Integer = 0
        'For Each row As DataGridViewRow In dgtareo.Rows
        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
            cmd.CommandText = "SP_ELTBTURNO_UPDROW"
            cmd.Connection = sqlCon
            cmd.Transaction = sqlTrans
            cmd.CommandType = CommandType.StoredProcedure
        'ELTBTURNOBE.PER_COD = IIf(IsDBNull(RTrim(row.Cells("COD").Value)), "", RTrim(row.Cells("COD").Value))
        'ELTBTURNOBE.FEC_INICIO = IIf(IsDBNull(RTrim(row.Cells("FEC_INICIO").Value)), "", RTrim(row.Cells("FEC_INICIO").Value))
        'ELTBTURNOBE.FEC_FIN = IIf(IsDBNull(RTrim(row.Cells("FEC_FIN").Value)), "", RTrim(row.Cells("FEC_FIN").Value))
        ''ELTBTURNOBE.INDICE = IIf(IsDBNull(RTrim(row.Cells("INDICE").Value)), "", RTrim(row.Cells("INDICE").Value))
        'If IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "Habilitado" Then
        '    ELTBTURNOBE.EST = "H"
        'ElseIf IIf(IsDBNull(RTrim(row.Cells("ESTADO").Value)), "", RTrim(row.Cells("ESTADO").Value)) = "Anulado" Then
        '    ELTBTURNOBE.EST = "A"
        'Else
        '    ELTBTURNOBE.EST = ""
        'End If

        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBTURNOBE.PER_COD
            cmd.Parameters.Add("@fecha", OracleDbType.Date).Value = ELTBTURNOBE.FEC_INICIO
            cmd.Parameters.Add("@fecha_ing", OracleDbType.Date).Value = ELTBTURNOBE.FEC_FIN
        cmd.Parameters.Add("@mes", OracleDbType.Varchar2).Value = ELTBTURNOBE.MES
        cmd.Parameters.Add("@indice", OracleDbType.Varchar2).Value = ELTBTURNOBE.INDICE
            cmd.Parameters.Add("@usuario", OracleDbType.Varchar2).Value = ELTBTURNOBE.USUARIO
            cmd.Parameters.Add("@est", OracleDbType.Varchar2).Value = ELTBTURNOBE.EST
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        'Next


        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "3"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELMVLOGSBE.log_codusu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se elimino el registro: " + ELTBTURNOBE.PER_COD + " fecha " + ELTBTURNOBE.FEC_INICIO + " a " + ELTBTURNOBE.FEC_FIN
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub
    Private Sub DeleteRow(ByVal ELTBTURNOBE As ELTBTURNOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_ELTBTURNO_DELROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@INDICE", OracleDbType.Char).Value = ELTBTURNOBE.INDICE
        cmd.Parameters.Add("@MES", OracleDbType.Char).Value = ELTBTURNOBE.MES
        cmd.Parameters.Add("@PER_COD", OracleDbType.Char).Value = ELTBTURNOBE.PER_COD
        cmd.ExecuteNonQuery()

    End Sub
    Public Function SelectIndice(ByVal Mes As String) As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        'Dim dt As New DataTable
        sNomArt = ""
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTURNO_SELINDICE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Mes", Mes)})
            While dr.Read

                If IsDBNull(dr.GetInt32(0)) Then
                    sNomArt = ""
                Else
                    sNomArt = dr.GetInt32(0)
                End If
            End While
        End Using
        Return sNomArt

    End Function
    Public Function SelectAllS(ByVal Anho As String, ByVal Mes As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_ELTBTURNO_SELECTALL", {New Oracle.ManagedDataAccess.Client.OracleParameter("@anho", Anho),
                                                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@mes", Mes)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
End Class
