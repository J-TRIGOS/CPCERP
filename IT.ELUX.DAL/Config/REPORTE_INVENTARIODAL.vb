Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect
Public Class REPORTE_INVENTARIODAL
    Inherits BaseDatosORACLE
    Public Function registrar(ByVal linea As String, ByVal sSlin As String, ByVal sAlm As String, ByVal sAnho As String, ByVal sMes As String, ByVal sFec As String, ByVal sMov As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        cn = ConnectionBegin()
        sqlTrans = cn.BeginTransaction
        Try
            registrar(linea, sSlin, sAlm, sAnho, sMes, sFec, sMov, cn, sqlTrans)
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
    Private Sub registrar(ByVal linea As String, ByVal sSlin As String, ByVal sAlm As String, ByVal sAnho As String, ByVal sMes As String, ByVal sFec As String, ByVal sMov As String, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                      ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)
        'Dim MesPro As String = Mid(sFecF, 4, 2)
        'Dim AnhoPro As String = Mid(sFecF, 7, 4)
        Dim ColumCampo As String = "S.ART_INVENT" & sMes & sAnho
        Dim ColumCampo1 As String = "ART_INVENT" & sMes & sAnho
        Dim TextFecha As String = "ULT.MOV:"
        ''
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand


        cmd.CommandText = "SP_TEMP_ALMINV_DEL"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure
        'Los parametros que va recibir son las propiedades de la clase 
        cmd.Parameters.Add("@EST", OracleDbType.NVarchar2).Value = "1"
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New Oracle.ManagedDataAccess.Client.OracleCommand


        If sMov = 1 Then
            cmd.CommandText = "DECLARE CURSOR INVREP IS " &
                    "SELECT ART_CODIGO, F_NOM_ART1(ART_CODIGO) NOM,(SELECT TO_DATE(FECHA_CORTE, 'DD/MM/YYYY') FROM ELTBFECHACORTEINV WHERE COD_SUBLINEA = SUBSTR(ART_CODIGO,1,4) AND MES = '" & sMes & "' AND ANHO = '" & sAnho & "') FECHA_CORTE, (" & ColumCampo1 & ")ART_INVPERIODI,decode(ART_CODALM,'0001','TORRES','0002','ELOY','0003','LURIN')ALMACEN, NVL((SELECT MAX(MOV_FECEMI) FROM ELMVALMA_2022 WHERE MOV_CODART = ART_CODIGO And MOV_FECEMI <= TO_DATE( '" & sFec & "' ,'DD/MM/YYYY') AND MOV_CODALM = ART_CODALM), NVL((SELECT MAX(MOV_FECEMI) FROM ELMVALMA_2021 WHERE MOV_CODART = ART_CODIGO And MOV_FECEMI <= TO_DATE('" & sFec & "','DD/MM/YYYY') AND MOV_CODALM = ART_CODALM), (SELECT MAX(MOV_FECEMI) FROM ELMVALMA_2020 WHERE MOV_CODART = ART_CODIGO And MOV_FECEMI <= TO_DATE('" & sFec & "','DD/MM/YYYY') AND MOV_CODALM = ART_CODALM))) ULT_MOV " &
                    "From EL_TBARTSTOCK Where " & ColumCampo1 & " > 0 Order By ART_CODIGO; " &
                    "BEGIN " &
                    " FOR J IN INVREP " &
                    " LOOP " &
                             "INSERT INTO TEMP_ALMINV (ART_COD,NOM_ART,FEC_CORTE,CANTIDAD,ALMACEN,TXT_FEC,ULT_MOV)" &
                                              "VALUES (J.ART_CODIGO,J.NOM,J.FECHA_CORTE,J.ART_INVPERIODI,J.ALMACEN,'" & TextFecha & "',J.ULT_MOV);" &
                    " End Loop; " &
                    "END; "
        Else
            cmd.CommandText = "DECLARE CURSOR INVREP IS " &
                   " SELECT S.ART_CODIGO, f_nom_art1(S.ART_CODIGO)NOM, F.FECHA_CORTE, (" & ColumCampo & ")ART_INVPERIODI, DECODE(NVL('" & sAlm & "',F.COD_ALM),'0001','TORRES','0002','ELOY','0003','LURIN') ALMACEN, " &
                   " (NVL((SELECT MAX(MOV_FECEMI) FROM ELMVALMA_2022 WHERE MOV_CODART = S.ART_CODIGO AND MOV_CODALM = NVL('" & sAlm & "',F.COD_ALM)),NVL((SELECT MAX(MOV_FECEMI) FROM ELMVALMA_2021 WHERE MOV_CODART = S.ART_CODIGO AND MOV_CODALM = NVL('" & sAlm & "',F.COD_ALM)),(SELECT MAX(MOV_FECEMI) FROM ELMVALMA_2020 WHERE MOV_CODART = S.ART_CODIGO AND MOV_CODALM = NVL('" & sAlm & "',F.COD_ALM))))) ULT_MOV" &
                   " From EL_TBARTSTOCK S INNER Join ELTBFECHACORTEINV F ON F.COD_SUBLINEA = SUBSTR(S.ART_CODIGO,0,4)" &
                   " Where SUBSTR(S.ART_CODIGO, 0, 4) = NVL('" & sSlin & "',SUBSTR(S.ART_CODIGO, 0, 4)) And S.ART_CODALM = F.COD_ALM And F.MES = NVL('" & sMes & "',F.MES) And F.ANHO = NVL('" & sAnho & "',F.ANHO) And F.COD_ALM = NVL('" & sAlm & "',F.COD_ALM) And S.ART_STOACT = " & ColumCampo & " And " & ColumCampo & " IS NOT NULL And " & ColumCampo & " > '0' ; " &
                   " BEGIN " &
                   " FOR J IN INVREP " &
                   " LOOP " &
                            "INSERT INTO TEMP_ALMINV (ART_COD,NOM_ART,FEC_CORTE,CANTIDAD,ALMACEN,TXT_FEC,ULT_MOV)" &
                                              "VALUES (J.ART_CODIGO,J.NOM,J.FECHA_CORTE,J.ART_INVPERIODI,J.ALMACEN,'" & TextFecha & "',J.ULT_MOV);" &
                    " End Loop; " &
                   "END; "
        End If

        ' F.FECHA_CORTE BETWEEN '" & sFecI & "' AND '" & sFecF & "' 
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

End Class
