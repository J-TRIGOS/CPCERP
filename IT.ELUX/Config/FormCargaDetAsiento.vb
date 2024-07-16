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
                    Else
                        da = New OleDbDataAdapter("SELECT Tipo as Tipo, Serie as Serie, Numero as Numero, Tipo1 as Tipo1, Serie1 as Serie1, Numero1 as Numero1, Fecha as Fecha, Cuenta as Cuenta,Destino as Destino, Importe as Importe, Moneda as Moneda, Signo as Signo, T_camb as T_camb, Dolares as Dolares, Proveedor as Proveedor, Ctct_cod as Ctct_cod, Art_cod as Art_cod,X_ret as X_ret, Status as Status FROM  [" & xSheet & "$]", conn)
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
        Else
            Label3.Text = "Nro de Registros : " & dgvdatos.Rows.Count
        End If


    End Sub
    Sub importarExcel(ByVal DT As DataTable)
        If CheckBox1.Checked = True Then
            For Each row As DataRow In DT.Rows
                dgvdatos1.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("SERIE")), "", row("SERIE")),
                                  IIf(IsDBNull(row("NUMERO")), "", row("NUMERO")),
                                  IIf(IsDBNull(row("TIPO1")), "", row("TIPO1")),
                                  IIf(IsDBNull(row("SERIE1")), "", row("SERIE1")),
                                  IIf(IsDBNull(row("NUMERO1")), "", row("NUMERO1")),
                                  IIf(IsDBNull(row("FECHA")), "", row("FECHA")),
                                  IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                  IIf(IsDBNull(row("DESTINO")), "", row("DESTINO")),
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
            Next
        Else
            For Each row As DataRow In DT.Rows
                dgvdatos.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")),
                                  IIf(IsDBNull(row("SERIE")), "", row("SERIE")),
                                  IIf(IsDBNull(row("NUMERO")), "", row("NUMERO")),
                                  IIf(IsDBNull(row("TIPO1")), "", row("TIPO1")),
                                  IIf(IsDBNull(row("SERIE1")), "", row("SERIE1")),
                                  IIf(IsDBNull(row("NUMERO1")), "", row("NUMERO1")),
                                  IIf(IsDBNull(row("FECHA")), "", row("FECHA")),
                                  IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),
                                  IIf(IsDBNull(row("DESTINO")), "", row("DESTINO")),
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
            Next
        End If

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
    Sub insertar1()
        If OkData() = False Then
            Exit Sub
        Else

            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            ElseIf MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
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
    Private Function OkData() As Boolean
        If CheckBox1.Checked = True Then
            If dgvdatos1.Rows.Count < 1 Then
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

    Private Sub FormCargaDetAsiento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            dgvdatos1.Visible = True
            dgvdatos.Visible = False
            dgvdatos.Rows.Clear()
            dgvdatos1.Rows.Clear()
        Else
            dgvdatos1.Visible = False
            dgvdatos.Visible = True
            dgvdatos.Rows.Clear()
            dgvdatos1.Rows.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgvdatos1.Rows.Clear()
        dgvdatos.Rows.Clear()
        Label3.Text = ""
    End Sub
End Class