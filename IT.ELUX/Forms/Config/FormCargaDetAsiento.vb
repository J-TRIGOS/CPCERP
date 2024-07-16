'Imports Microsoft.Office.Interop
'Imports System.Data
Imports System.Data.OleDb
'Imports System
'Imports Microsoft.VisualBasic
'Imports System.IO
'Imports System.Net
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormCargaDetAsiento
    Private ELTBCARGADETASIENTOBL As New ELTBCARGADETASIENTOBL
    Public ARCHIVO As String
    Dim xSheet As String = ""
    Private Sub FormCargaDetAsiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion3
            Case 0
                flagAccion = "N"
                ' Deshabilitar(True)
                btnborrar.Visible = True
                Button1.Visible = True
                Button3.Visible = True
                Button2.Visible = True
                cmbt_ope.SelectedIndex = 0
                'Case 1
                '    flagAccion = "M"
                '    GetData(sTDoc, sSDoc, sNDoc, gArt)
                '    Deshabilitar(False)
                '    btnAgregar.Text = "Actualizar"
        End Select
    End Sub
    Private Function Deshabilitar(ByVal A As Boolean)
        btncargararch.Enabled = A
    End Function

    Private Sub btncargararch_Click(sender As Object, e As EventArgs) Handles btncargararch.Click

        Try
            OpenFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx|Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
            OpenFileDialog1.ShowDialog()

            If Me.OpenFileDialog1.FileName <> "" Then
                ARCHIVO = OpenFileDialog1.FileName

                Dim ds As New DataSet
                Dim da As OleDbDataAdapter
                Dim dt As DataTable
                Dim conn As OleDbConnection

                xSheet = "Hoja1"
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" & ARCHIVO & ";Extended Properties='Excel 12.0 Xml;HDR=Yes'")

                Try
                    If CheckBox1.Checked = True Then
                        da = New OleDbDataAdapter("SELECT Tipo as Tipo, Serie as Serie, Numero as Numero, Tipo1 as Tipo1, Serie1 as Serie1, Numero1 as Numero1, Fecha as Fecha, Cuenta as Cuenta,Destino as Destino, Importe as Importe, Moneda as Moneda, Signo as Signo, T_camb as T_camb, Dolares as Dolares, Proveedor as Proveedor, Ctct_cod as Ctct_cod, Art_cod as Art_cod,X_ret as X_ret, Status as Status,Cco_cod as Cco_cod FROM  [" & xSheet & "$]", conn)
                    ElseIf CheckBox2.Checked = True Then
                        da = New OleDbDataAdapter("SELECT Tipo as Tipo, Serie as Serie, Numero as Numero, Tipo1 as Tipo1, Serie1 as Serie1, Numero1 as Numero1, Fecha as Fecha, Cuenta as Cuenta,Destino as Destino, Importe as Importe, Moneda as Moneda, Signo as Signo, T_camb as T_camb, Dolares as Dolares, Proveedor as Proveedor, Ctct_cod as Ctct_cod, Art_cod as Art_cod,X_ret as X_ret, Status as Status,FEC_ENT as FEC_ENT FROM  [" & xSheet & "$]", conn)
                    Else
                        da = New OleDbDataAdapter("SELECT Tipo as Tipo, Serie as Serie, Numero as Numero, Tipo1 as Tipo1, Serie1 as Serie1, Numero1 as Numero1, Fecha as Fecha, Cuenta as Cuenta,Destino as Destino, Importe as Importe, Moneda as Moneda, Signo as Signo, T_camb as T_camb, Dolares as Dolares, Proveedor as Proveedor, Ctct_cod as Ctct_cod, Art_cod as Art_cod,X_ret as X_ret, Status as Status, COD_FLUJO as COD_FLUJO, COD_CAJA as COD_CAJA FROM  [" & xSheet & "$]", conn)
                    End If


                    conn.Open()
                    da.Fill(ds, "MyData")
                    dt = ds.Tables("MyData")
                    importarExcel(dt)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Information, "Informacion")
                Finally
                    conn.Close()
                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try
        If CheckBox1.Checked = True Then
            Label3.Text = "Nro de Registros : " & dgvdatos1.Rows.Count
        ElseIf CheckBox2.Checked = True Then
            Label3.Text = "Nro de Registros : " & dgvdatos3.Rows.Count
        Else
            Label3.Text = "Nro de Registros : " & dgvdatos.Rows.Count
        End If


    End Sub
    Sub importarExcel(ByVal DT As DataTable)
        Dim PROVISIONESBL As New PROVISIONESBL
        Dim CTA_DEST As String
        If CheckBox1.Checked = True Then
            For Each row As DataRow In DT.Rows
                CTA_DEST = PROVISIONESBL.SelectCTA_OPE(IIf(IsDBNull(row("SERIE")), "", row("SERIE")), IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")))
                dgvdatos1.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("SERIE")), "", row("SERIE")),
                                  IIf(IsDBNull(row("NUMERO")), "", row("NUMERO")),
                                  IIf(IsDBNull(row("TIPO1")), "", row("TIPO1")),
                                  IIf(IsDBNull(row("SERIE1")), "", row("SERIE1")),
                                  IIf(IsDBNull(row("NUMERO1")), "", row("NUMERO1")),
                                  IIf(IsDBNull(row("FECHA")), "", row("FECHA")),
                                  IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                  IIf(IsDBNull(row("DESTINO")), CTA_DEST, row("DESTINO")),
                                  IIf(IsDBNull(row("IMPORTE")), "", row("IMPORTE")),
                                  IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                  IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),
                                  IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),
                                  IIf(IsDBNull(row("DOLARES")), "", row("DOLARES")),
                                  IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                  IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),
                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                  IIf(IsDBNull(row("X_RET")), "", row("X_RET")),
                                  IIf(IsDBNull(row("STATUS")), "", row("STATUS")),
                                  IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")))

                CTA_DEST = Nothing
            Next
        ElseIf CheckBox2.Checked = True Then
            For Each row As DataRow In DT.Rows
                CTA_DEST = PROVISIONESBL.SelectCTA_OPE(IIf(IsDBNull(row("SERIE")), "", row("SERIE")), IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")))
                dgvdatos3.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("SERIE")), "", row("SERIE")),
                                  IIf(IsDBNull(row("NUMERO")), "", row("NUMERO")),
                                  IIf(IsDBNull(row("TIPO1")), "", row("TIPO1")),
                                  IIf(IsDBNull(row("SERIE1")), "", row("SERIE1")),
                                  IIf(IsDBNull(row("NUMERO1")), "", row("NUMERO1")),
                                  IIf(IsDBNull(row("FECHA")), "", row("FECHA")),
                                  IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                  IIf(IsDBNull(row("DESTINO")), CTA_DEST, row("DESTINO")),
                                  IIf(IsDBNull(row("IMPORTE")), "", row("IMPORTE")),
                                  IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                  IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),
                                  IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),
                                  IIf(IsDBNull(row("DOLARES")), "", row("DOLARES")),
                                  IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                  IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),
                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                  IIf(IsDBNull(row("X_RET")), "", row("X_RET")),
                                  IIf(IsDBNull(row("STATUS")), "", row("STATUS")),
                                  IIf(IsDBNull(row("FEC_ENT")), "", row("FEC_ENT")))
                CTA_DEST = Nothing
            Next
        Else
            For Each row As DataRow In DT.Rows
                CTA_DEST = PROVISIONESBL.SelectCTA_OPE(IIf(IsDBNull(row("SERIE")), "", row("SERIE")), IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")))
                dgvdatos.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("SERIE")), "", row("SERIE")),
                                  IIf(IsDBNull(row("NUMERO")), "", row("NUMERO")),
                                  IIf(IsDBNull(row("TIPO1")), "", row("TIPO1")),
                                  IIf(IsDBNull(row("SERIE1")), "", row("SERIE1")),
                                  IIf(IsDBNull(row("NUMERO1")), "", row("NUMERO1")),
                                  IIf(IsDBNull(row("FECHA")), "", row("FECHA")),
                                  IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                  IIf(IsDBNull(row("DESTINO")), CTA_DEST, row("DESTINO")),
                                  IIf(IsDBNull(row("IMPORTE")), "", row("IMPORTE")),
                                  IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                  IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),
                                  IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),
                                  IIf(IsDBNull(row("DOLARES")), "", row("DOLARES")),
                                  IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                  IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),
                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                  IIf(IsDBNull(row("X_RET")), "", row("X_RET")),
                                  IIf(IsDBNull(row("STATUS")), "", row("STATUS")),
                                  IIf(IsDBNull(row("COD_FLUJO")), "", row("COD_FLUJO")),
                                  IIf(IsDBNull(row("COD_CAJA")), "", row("COD_CAJA")))
                CTA_DEST = Nothing
            Next
        End If

    End Sub
    Sub importarExcel2(ByVal DT As DataTable)
        Dim PROVISIONESBL As New PROVISIONESBL
        Dim CTA_DEST As String
        If CheckBox4.Checked = True Then
            For Each row As DataRow In DT.Rows
                CTA_DEST = PROVISIONESBL.SelectCTA_OPE(IIf(IsDBNull(row("SERIE")), "", row("SERIE")), IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")))
                dgvnew1.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("SERIE")), "", row("SERIE")),
                                  IIf(IsDBNull(row("NUMERO")), "", row("NUMERO")),
                                  IIf(IsDBNull(row("TIPO1")), "", row("TIPO1")),
                                  IIf(IsDBNull(row("SERIE1")), "", row("SERIE1")),
                                  IIf(IsDBNull(row("NUMERO1")), "", row("NUMERO1")),
                                  IIf(IsDBNull(row("FECHA")), "", row("FECHA")),
                                  IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                  IIf(IsDBNull(row("DESTINO")), CTA_DEST, row("DESTINO")),
                                  IIf(IsDBNull(row("IMPORTE")), "", row("IMPORTE")),
                                  IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                  IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),
                                  IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),
                                  IIf(IsDBNull(row("DOLARES")), "", row("DOLARES")),
                                  IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                  IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),
                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                  IIf(IsDBNull(row("X_RET")), "", row("X_RET")),
                                  IIf(IsDBNull(row("STATUS")), "", row("STATUS")),
                                  IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")))

                CTA_DEST = Nothing
            Next
        ElseIf CheckBox3.Checked = True Then
            For Each row As DataRow In DT.Rows
                CTA_DEST = PROVISIONESBL.SelectCTA_OPE(IIf(IsDBNull(row("SERIE")), "", row("SERIE")), IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")))
                dgvnew3.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("SERIE")), "", row("SERIE")),
                                  IIf(IsDBNull(row("NUMERO")), "", row("NUMERO")),
                                  IIf(IsDBNull(row("TIPO1")), "", row("TIPO1")),
                                  IIf(IsDBNull(row("SERIE1")), "", row("SERIE1")),
                                  IIf(IsDBNull(row("NUMERO1")), "", row("NUMERO1")),
                                  IIf(IsDBNull(row("FECHA")), "", row("FECHA")),
                                  IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                  IIf(IsDBNull(row("DESTINO")), CTA_DEST, row("DESTINO")),
                                  IIf(IsDBNull(row("IMPORTE")), "", row("IMPORTE")),
                                  IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                  IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),
                                  IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),
                                  IIf(IsDBNull(row("DOLARES")), "", row("DOLARES")),
                                  IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                  IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),
                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                  IIf(IsDBNull(row("X_RET")), "", row("X_RET")),
                                  IIf(IsDBNull(row("STATUS")), "", row("STATUS")),
                                  IIf(IsDBNull(row("FEC_ENT")), "", row("FEC_ENT")))
                CTA_DEST = Nothing
            Next
        Else
            For Each row As DataRow In DT.Rows
                CTA_DEST = PROVISIONESBL.SelectCTA_OPE(IIf(IsDBNull(row("SERIE")), "", row("SERIE")), IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")))
                dgvnew.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("SERIE")), "", row("SERIE")),
                                  IIf(IsDBNull(row("NUMERO")), "", row("NUMERO")),
                                  IIf(IsDBNull(row("TIPO1")), "", row("TIPO1")),
                                  IIf(IsDBNull(row("SERIE1")), "", row("SERIE1")),
                                  IIf(IsDBNull(row("NUMERO1")), "", row("NUMERO1")),
                                  IIf(IsDBNull(row("FECHA")), "", row("FECHA")),
                                  IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                  IIf(IsDBNull(row("DESTINO")), CTA_DEST, row("DESTINO")),
                                  IIf(IsDBNull(row("IMPORTE")), "", row("IMPORTE")),
                                  IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                  IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),
                                  IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),
                                  IIf(IsDBNull(row("DOLARES")), "", row("DOLARES")),
                                  IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                  IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),
                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                  IIf(IsDBNull(row("X_RET")), "", row("X_RET")),
                                  IIf(IsDBNull(row("STATUS")), "", row("STATUS")))
                CTA_DEST = Nothing
            Next
        End If

    End Sub
    Sub importarExcel3(ByVal DT As DataTable)
        Dim PROVISIONESBL As New PROVISIONESBL


        For Each row As DataRow In DT.Rows
            'CTA_DEST = PROVISIONESBL.SelectCTA_OPE(IIf(IsDBNull(row("SERIE")), "", row("SERIE")), IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")))
            dgvcabecera.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("SERIE")), "", row("SERIE")),
                                  IIf(IsDBNull(row("NUMERO")), "", row("NUMERO")),
                                  IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),
                                  IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                  IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                  IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),
                                  IIf(IsDBNull(row("FEC_PROV")), "", row("FEC_PROV")))
            'CTA_DEST = Nothing
        Next
    End Sub

    Sub importarExcel4(ByVal DT As DataTable)
        Dim PROVISIONESBL As New PROVISIONESBL


        For Each row As DataRow In DT.Rows
            'CTA_DEST = PROVISIONESBL.SelectCTA_OPE(IIf(IsDBNull(row("SERIE")), "", row("SERIE")), IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")))
            dgvmasiva.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("SERIE")), "", row("SERIE")),
                                  IIf(IsDBNull(row("NUMERO")), "", row("NUMERO")),
                                  IIf(IsDBNull(row("TIPO1")), "", row("TIPO1")),
                                  IIf(IsDBNull(row("SERIE1")), "", row("SERIE1")),
                                  IIf(IsDBNull(row("NUMERO1")), "", row("NUMERO1")),
                                  IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),
                                  IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                                  IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                  IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),
                                  IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                  IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                  IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                  IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")),
                                  IIf(IsDBNull(row("UPRECIO_AFECTOS")), "", row("UPRECIO_AFECTOS")),
                                  IIf(IsDBNull(row("UPRECIO_AFECTOD")), "", row("UPRECIO_AFECTOD")),
                                  IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")))
            'CTA_DEST = Nothing
        Next


    End Sub
    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If CheckBox1.Checked = True Then
            If dgvdatos1.RowCount > 0 Then
                If MessageBox.Show("Esta seguro de Eliminar el Registro",
                               Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                    Exit Sub
                End If
                dgvdatos1.Rows.RemoveAt(dgvdatos1.CurrentRow.Index)
                dgvdatos1.Refresh()
                Label3.Text = "Nro de Registros : " & dgvdatos1.Rows.Count
            Else
                MsgBox("No hay datos")
            End If
        ElseIf CheckBox2.Checked = True Then
            If dgvdatos3.RowCount > 0 Then
                If MessageBox.Show("Esta seguro de Eliminar el Registro",
                               Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                    Exit Sub
                End If
                dgvdatos3.Rows.RemoveAt(dgvdatos1.CurrentRow.Index)
                dgvdatos3.Refresh()
                Label3.Text = "Nro de Registros : " & dgvdatos3.Rows.Count
            Else
                MsgBox("No hay datos")
            End If
        Else
            If dgvdatos.RowCount > 0 Then
                If MessageBox.Show("Esta seguro de Eliminar el Registro",
                               Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                    Exit Sub
                End If
                dgvdatos.Rows.RemoveAt(dgvdatos.CurrentRow.Index)
                dgvdatos.Refresh()
                Label3.Text = "Nro de Registros : " & dgvdatos.Rows.Count
            Else
                MsgBox("No hay datos")
            End If
        End If

    End Sub

    Private Sub btninsertar_Click(sender As Object, e As EventArgs) Handles btninsertar.Click
        If CheckBox1.Checked = True Then
            insertar1()
        ElseIf CheckBox2.Checked = True Then
            insertar2()
        Else
            insertar()
        End If

    End Sub
    Sub insertar()
        If OkData() = False Then
            Exit Sub
        Else

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Cursor.Current = Cursors.WaitCursor
                Dim ELTBCARGADETASIENTOBE As New ELTBCARGADETASIENTOBE
                'ELTBCARGADETASIENTOBE.USUARIO = gsUser
                'ELTBCARGADETASIENTOBE.ID = gsCodUsr
                'ELTBCARGADETASIENTOBE.USUACTU = gsCodUsr


                gsError = ELTBCARGADETASIENTOBL.SaveRow(ELTBCARGADETASIENTOBE, flagAccion, "", dgvdatos)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    If dgvdatos.Rows.Count > 50 Then
                        'SubirArchivo()
                    End If
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub
    Sub insertar5()
        If OkData1() = False Then
            Exit Sub
        Else

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Cursor.Current = Cursors.WaitCursor
                Dim ELTBCARGADETASIENTOBE As New ELTBCARGADETASIENTOBE
                'ELTBCARGADETASIENTOBE.USUARIO = gsUser
                'ELTBCARGADETASIENTOBE.ID = gsCodUsr
                'ELTBCARGADETASIENTOBE.USUACTU = gsCodUsr
                ELTBCARGADETASIENTOBE.T_OPE_COD = cmbt_ope.Text

                gsError = ELTBCARGADETASIENTOBL.SaveRow(ELTBCARGADETASIENTOBE, "N1", "", dgvnew)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    If dgvnew3.Rows.Count > 50 Then
                        'SubirArchivo()
                    End If
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub
    Sub insertar2()
        If OkData() = False Then
            Exit Sub
        Else

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Cursor.Current = Cursors.WaitCursor
                Dim ELTBCARGADETASIENTOBE As New ELTBCARGADETASIENTOBE
                'ELTBCARGADETASIENTOBE.USUARIO = gsUser
                'ELTBCARGADETASIENTOBE.ID = gsCodUsr
                'ELTBCARGADETASIENTOBE.USUACTU = gsCodUsr


                gsError = ELTBCARGADETASIENTOBL.SaveRow(ELTBCARGADETASIENTOBE, flagAccion, "2", dgvdatos3)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    If dgvdatos.Rows.Count > 50 Then
                        'SubirArchivo()
                    End If
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub
    Sub insertar1()
        If OkData() = False Then
            Exit Sub
        Else

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Cursor.Current = Cursors.WaitCursor
                Dim ELTBCARGADETASIENTOBE As New ELTBCARGADETASIENTOBE
                'ELTBCARGADETASIENTOBE.USUARIO = gsUser
                'ELTBCARGADETASIENTOBE.ID = gsCodUsr
                'ELTBCARGADETASIENTOBE.USUACTU = gsCodUsr
                gsError = ELTBCARGADETASIENTOBL.SaveRow(ELTBCARGADETASIENTOBE, flagAccion, "1", dgvdatos1)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    If dgvdatos.Rows.Count > 50 Then
                        'SubirArchivo()
                    End If
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub
    Sub insertar7()
        'If OkData() = False Then
        '    Exit Sub
        'Else

        If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        Else
            Cursor.Current = Cursors.WaitCursor
            Dim ELTBCARGADETASIENTOBE As New ELTBCARGADETASIENTOBE
            'ELTBCARGADETASIENTOBE.USUARIO = gsUser
            'ELTBCARGADETASIENTOBE.ID = gsCodUsr
            'ELTBCARGADETASIENTOBE.USUACTU = gsCodUsr
            gsError = ELTBCARGADETASIENTOBL.SaveRow(ELTBCARGADETASIENTOBE, "N3", "1", dgvmasiva)
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                If dgvmasiva.Rows.Count > 50 Then
                    'SubirArchivo()
                End If
                ' Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
        End If
        'End If
    End Sub
    Sub insertar6()
        'If OkData() = False Then
        '    Exit Sub
        'Else

        If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        Else
            Cursor.Current = Cursors.WaitCursor
            Dim ELTBCARGADETASIENTOBE As New ELTBCARGADETASIENTOBE
            ELTBCARGADETASIENTOBE.USUARIO = gsUser
            'ELTBCARGADETASIENTOBE.ID = gsCodUsr
            'ELTBCARGADETASIENTOBE.USUACTU = gsCodUsr
            gsError = ELTBCARGADETASIENTOBL.SaveRow(ELTBCARGADETASIENTOBE, "N2", "1", dgvcabecera)
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                If dgvdatos.Rows.Count > 50 Then
                    'SubirArchivo()
                End If
                'Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
        End If
        'End If
    End Sub
    Sub insertar4()
        If OkData1() = False Then
            Exit Sub
        Else

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Cursor.Current = Cursors.WaitCursor
                Dim ELTBCARGADETASIENTOBE As New ELTBCARGADETASIENTOBE
                'ELTBCARGADETASIENTOBE.USUARIO = gsUser
                'ELTBCARGADETASIENTOBE.ID = gsCodUsr
                'ELTBCARGADETASIENTOBE.USUACTU = gsCodUsr
                ELTBCARGADETASIENTOBE.T_OPE_COD = cmbt_ope.Text
                gsError = ELTBCARGADETASIENTOBL.SaveRow(ELTBCARGADETASIENTOBE, "N1", "4", dgvnew1)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    If dgvdatos.Rows.Count > 50 Then
                        'SubirArchivo()
                    End If
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub
    Sub insertar3()
        If OkData1() = False Then
            Exit Sub
        Else

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Cursor.Current = Cursors.WaitCursor
                Dim ELTBCARGADETASIENTOBE As New ELTBCARGADETASIENTOBE
                'ELTBCARGADETASIENTOBE.USUARIO = gsUser
                'ELTBCARGADETASIENTOBE.ID = gsCodUsr
                'ELTBCARGADETASIENTOBE.USUACTU = gsCodUsr
                ELTBCARGADETASIENTOBE.T_OPE_COD = cmbt_ope.Text
                gsError = ELTBCARGADETASIENTOBL.SaveRow(ELTBCARGADETASIENTOBE, "N1", "3", dgvnew3)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    If dgvnew.Rows.Count > 50 Then
                        'SubirArchivo()
                    End If
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub
    Private Function OkData() As Boolean
        If CheckBox1.Checked = True Then
            If dgvdatos1.Rows.Count < 1 Then
                MsgBox("No se a cargado Datos al Grid", MsgBoxStyle.Exclamation)
                btncargararch.Focus()
                Return False
            End If
            Return True
        ElseIf CheckBox2.Checked = True Then
            If dgvdatos3.Rows.Count < 1 Then
                MsgBox("No se a cargado Datos al Grid", MsgBoxStyle.Exclamation)
                btncargararch.Focus()
                Return False
            End If
            Return True
        Else
            If dgvdatos.Rows.Count < 1 Then
                MsgBox("No se a cargado Datos al Grid", MsgBoxStyle.Exclamation)
                btncargararch.Focus()
                Return False
            End If
            Return True
        End If

    End Function

    Private Function OkData1() As Boolean
        If CheckBox4.Checked = True Then
            If dgvnew1.Rows.Count < 1 Then
                MsgBox("No se a cargado Datos al Grid", MsgBoxStyle.Exclamation)
                btncargararch.Focus()
                Return False
            End If
            Return True
        ElseIf CheckBox3.Checked = True Then
            If dgvnew3.Rows.Count < 1 Then
                MsgBox("No se a cargado Datos al Grid", MsgBoxStyle.Exclamation)
                btncargararch.Focus()
                Return False
            End If
            Return True
        Else
            If dgvnew.Rows.Count < 1 Then
                MsgBox("No se a cargado Datos al Grid", MsgBoxStyle.Exclamation)
                btncargararch.Focus()
                Return False
            End If
            Return True
        End If

    End Function

    Private Sub FormCargaDetAsiento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            dgvdatos1.Visible = True
            dgvdatos.Visible = False
            dgvdatos3.Visible = False
            dgvdatos3.Rows.Clear()
            dgvdatos.Rows.Clear()
            dgvdatos1.Rows.Clear()
            CheckBox2.Checked = False
        ElseIf CheckBox2.Checked = True Then
            dgvdatos3.Visible = True
            dgvdatos.Visible = False
            dgvdatos1.Visible = False
            dgvdatos.Rows.Clear()
            dgvdatos1.Rows.Clear()
            dgvdatos3.Rows.Clear()
            CheckBox1.Checked = False
        Else

            dgvdatos1.Visible = False
            dgvdatos3.Visible = False
            dgvdatos.Visible = True
            dgvdatos.Rows.Clear()
            dgvdatos3.Rows.Clear()
            dgvdatos1.Rows.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgvdatos1.Rows.Clear()
        dgvdatos.Rows.Clear()
        dgvdatos3.Rows.Clear()
        Label3.Text = ""
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            dgvdatos3.Visible = True
            dgvdatos.Visible = False
            dgvdatos1.Visible = False
            dgvdatos1.Rows.Clear()
            dgvdatos.Rows.Clear()
            dgvdatos3.Rows.Clear()
            CheckBox1.Checked = False
        ElseIf CheckBox1.Checked = True Then
            dgvdatos1.Visible = True
            dgvdatos.Visible = False
            dgvdatos3.Visible = False
            dgvdatos3.Rows.Clear()
            dgvdatos.Rows.Clear()
            dgvdatos1.Rows.Clear()
            CheckBox2.Checked = False
        Else
            dgvdatos3.Visible = False
            dgvdatos1.Visible = False
            dgvdatos.Visible = True
            dgvdatos.Rows.Clear()
            dgvdatos1.Rows.Clear()
            dgvdatos3.Rows.Clear()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            OpenFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx|Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
            OpenFileDialog1.ShowDialog()

            If Me.OpenFileDialog1.FileName <> "" Then
                ARCHIVO = OpenFileDialog1.FileName

                Dim ds As New DataSet
                Dim da As OleDbDataAdapter
                Dim dt As DataTable
                Dim conn As OleDbConnection

                xSheet = "Hoja1"
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" & ARCHIVO & ";Extended Properties='Excel 12.0 Xml;HDR=Yes'")

                Try
                    If CheckBox4.Checked = True Then
                        da = New OleDbDataAdapter("SELECT Tipo as Tipo, Serie as Serie, Numero as Numero, Tipo1 as Tipo1, Serie1 as Serie1, Numero1 as Numero1, Fecha as Fecha, Cuenta as Cuenta,Destino as Destino, Importe as Importe, Moneda as Moneda, Signo as Signo, T_camb as T_camb, Dolares as Dolares, Proveedor as Proveedor, Ctct_cod as Ctct_cod, Art_cod as Art_cod,X_ret as X_ret, Status as Status,Cco_cod as Cco_cod FROM  [" & xSheet & "$]", conn)
                    ElseIf CheckBox3.Checked = True Then
                        da = New OleDbDataAdapter("SELECT Tipo as Tipo, Serie as Serie, Numero as Numero, Tipo1 as Tipo1, Serie1 as Serie1, Numero1 as Numero1, Fecha as Fecha, Cuenta as Cuenta,Destino as Destino, Importe as Importe, Moneda as Moneda, Signo as Signo, T_camb as T_camb, Dolares as Dolares, Proveedor as Proveedor, Ctct_cod as Ctct_cod, Art_cod as Art_cod,X_ret as X_ret, Status as Status,FEC_ENT as FEC_ENT FROM  [" & xSheet & "$]", conn)
                    Else
                        da = New OleDbDataAdapter("SELECT Tipo as Tipo, Serie as Serie, Numero as Numero, Tipo1 as Tipo1, Serie1 as Serie1, Numero1 as Numero1, Fecha as Fecha, Cuenta as Cuenta,Destino as Destino, Importe as Importe, Moneda as Moneda, Signo as Signo, T_camb as T_camb, Dolares as Dolares, Proveedor as Proveedor, Ctct_cod as Ctct_cod, Art_cod as Art_cod,X_ret as X_ret, Status as Status FROM  [" & xSheet & "$]", conn)
                    End If


                    conn.Open()
                    da.Fill(ds, "MyData")
                    dt = ds.Tables("MyData")
                    importarExcel2(dt)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Information, "Informacion")
                Finally
                    conn.Close()
                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try
        If CheckBox4.Checked = True Then
            Label2.Text = "Nro de Registros : " & dgvnew1.Rows.Count
        ElseIf CheckBox3.Checked = True Then
            Label2.Text = "Nro de Registros : " & dgvnew.Rows.Count
        Else
            Label2.Text = "Nro de Registros : " & dgvnew3.Rows.Count
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dgvnew1.Rows.Clear()
        dgvnew3.Rows.Clear()
        dgvnew.Rows.Clear()
        Label2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckBox4.Checked = True Then
            If dgvnew1.RowCount > 0 Then
                If MessageBox.Show("Esta seguro de Eliminar el Registro",
                               Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                    Exit Sub
                End If
                dgvnew1.Rows.RemoveAt(dgvnew1.CurrentRow.Index)
                dgvnew1.Refresh()
                Label2.Text = "Nro de Registros : " & dgvnew1.Rows.Count
            Else
                MsgBox("No hay datos")
            End If
        ElseIf CheckBox3.Checked = True Then
            If dgvnew.RowCount > 0 Then
                If MessageBox.Show("Esta seguro de Eliminar el Registro",
                               Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                    Exit Sub
                End If
                dgvnew.Rows.RemoveAt(dgvnew.CurrentRow.Index)
                dgvnew.Refresh()
                Label2.Text = "Nro de Registros : " & dgvnew.Rows.Count
            Else
                MsgBox("No hay datos")
            End If
        Else
            If dgvnew3.RowCount > 0 Then
                If MessageBox.Show("Esta seguro de Eliminar el Registro",
                               Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                    Exit Sub
                End If
                dgvnew3.Rows.RemoveAt(dgvnew3.CurrentRow.Index)
                dgvnew3.Refresh()
                Label2.Text = "Nro de Registros : " & dgvnew3.Rows.Count
            Else
                MsgBox("No hay datos")
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If CheckBox4.Checked = True Then
            insertar4()
        ElseIf CheckBox3.Checked = True Then
            insertar3()
        Else
            insertar5()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            dgvnew1.Visible = True
            dgvnew.Visible = False
            dgvnew3.Visible = False
            dgvnew.Rows.Clear()
            dgvnew3.Rows.Clear()
            dgvnew1.Rows.Clear()
            CheckBox3.Checked = False
        ElseIf CheckBox3.Checked = True Then
            dgvnew3.Visible = True
            dgvnew.Visible = False
            dgvnew1.Visible = False
            dgvnew3.Rows.Clear()
            dgvnew1.Rows.Clear()
            dgvnew.Rows.Clear()
            CheckBox4.Checked = False
        Else
            dgvnew1.Visible = False
            dgvnew3.Visible = False
            dgvnew.Visible = True
            dgvnew3.Rows.Clear()
            dgvnew.Rows.Clear()
            dgvnew1.Rows.Clear()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox4.Checked = True Then
            dgvnew1.Visible = True
            dgvnew3.Visible = False
            dgvnew.Visible = False
            dgvnew1.Rows.Clear()
            dgvnew3.Rows.Clear()
            dgvnew.Rows.Clear()
            CheckBox3.Checked = False
        ElseIf CheckBox3.Checked = True Then
            dgvnew3.Visible = True
            dgvnew1.Visible = False
            dgvnew.Visible = False
            dgvnew.Rows.Clear()
            dgvnew3.Rows.Clear()
            dgvnew1.Rows.Clear()
            CheckBox4.Checked = False
        Else
            dgvnew3.Visible = False
            dgvnew1.Visible = False
            dgvnew.Visible = True
            dgvnew3.Rows.Clear()
            dgvnew1.Rows.Clear()
            dgvnew.Rows.Clear()
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txttdoc.TextLength > 0 And txtsdoc.TextLength > 0 And txtndoc.TextLength > 0 And cmb_tope1.SelectedIndex > -1 Then
            Dim ELTBCARGADETASIENTOBE As New ELTBCARGADETASIENTOBE
            ELTBCARGADETASIENTOBE.T_DOC_REF = txttdoc.Text
            ELTBCARGADETASIENTOBE.SER_DOC_REF = txtsdoc.Text
            ELTBCARGADETASIENTOBE.NRO_DOC_REF = txtndoc.Text
            ELTBCARGADETASIENTOBE.T_OPE_COD = cmb_tope1.Text
            gsError = ELTBCARGADETASIENTOBL.SaveRow(ELTBCARGADETASIENTOBE, "E", "", dgvnew3)
            'If gsError = "OK" Then
            MsgBox("Datos Eliminados Correctamente", MsgBoxStyle.Information)
            Dispose()
            'Else
            '    FormMain.LblError.Text = gsError
            '    MsgBox("Error al eliminar", MsgBoxStyle.Critical)
            'End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Try
            OpenFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx|Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
            OpenFileDialog1.ShowDialog()

            If Me.OpenFileDialog1.FileName <> "" Then
                ARCHIVO = OpenFileDialog1.FileName

                Dim ds As New DataSet
                Dim da As OleDbDataAdapter
                Dim dt As DataTable
                Dim conn As OleDbConnection

                xSheet = "Hoja1"
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" & ARCHIVO & ";Extended Properties='Excel 12.0 Xml;HDR=Yes'")

                Try
                    da = New OleDbDataAdapter("SELECT Tipo as Tipo, Serie as Serie, Numero as Numero, FEC_GENE as FEC_GENE, PROVEEDOR as PROVEEDOR, MONEDA as MONEDA, OBSERVA as OBSERVA, FEC_PROV as FEC_PROV FROM  [" & xSheet & "$]", conn)
                    conn.Open()
                    da.Fill(ds, "MyData")
                    dt = ds.Tables("MyData")
                    importarExcel3(dt)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Information, "Informacion")
                Finally
                    conn.Close()
                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try

        Label3.Text = "Nro de Registros : " & dgvcabecera.Rows.Count

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        insertar6()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            OpenFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx|Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
            OpenFileDialog1.ShowDialog()

            If Me.OpenFileDialog1.FileName <> "" Then
                ARCHIVO = OpenFileDialog1.FileName

                Dim ds As New DataSet
                Dim da As OleDbDataAdapter
                Dim dt As DataTable
                Dim conn As OleDbConnection

                xSheet = "Hoja1"
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" & ARCHIVO & ";Extended Properties='Excel 12.0 Xml;HDR=Yes'")

                Try
                    da = New OleDbDataAdapter("SELECT Tipo as Tipo, Serie as Serie, Numero as Numero,Tipo1 as Tipo1, Serie1 as Serie1, Numero1 as Numero1, FEC_GENE as FEC_GENE, PROVEEDOR as PROVEEDOR, ART_COD AS ART_COD, CANTIDAD AS CANTIDAD, T_CAMB AS T_CAMB, MONEDA as MONEDA, UNIDAD AS UNIDAD, CUENTA AS CUENTA, CUENTA_DEST AS CUENTA_DEST, UPRECIO_AFECTOS AS UPRECIO_AFECTOS,UPRECIO_AFECTOD AS UPRECIO_AFECTOD, CCO_COD AS CCO_COD FROM  [" & xSheet & "$]", conn)
                    conn.Open()
                    da.Fill(ds, "MyData")
                    dt = ds.Tables("MyData")
                    importarExcel4(dt)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Information, "Informacion")
                Finally
                    conn.Close()
                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try

        Label3.Text = "Nro de Registros : " & dgvmasiva.Rows.Count

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If dgvcabecera.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvcabecera.Rows.RemoveAt(dgvcabecera.CurrentRow.Index)
            dgvcabecera.Refresh()
            Label9.Text = "Nro de Registros : " & dgvcabecera.Rows.Count
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If dgvmasiva.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvmasiva.Rows.RemoveAt(dgvmasiva.CurrentRow.Index)
            dgvmasiva.Refresh()
            Label10.Text = "Nro de Registros : " & dgvmasiva.Rows.Count
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        dgvcabecera.Rows.Clear()
        dgvcabecera.Rows.Clear()
        dgvcabecera.Rows.Clear()
        Label9.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        dgvmasiva.Rows.Clear()
        dgvmasiva.Rows.Clear()
        dgvmasiva.Rows.Clear()
        Label10.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        insertar7()
    End Sub
End Class