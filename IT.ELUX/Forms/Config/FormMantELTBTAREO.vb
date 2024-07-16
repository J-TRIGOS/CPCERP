
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.ComponentModel

Public Class FormMantELTBTAREO
    Public ARCHIVO As String
    Private ELTBTAREOBL As New ELTBTAREOBL
    Private anho As String = DateTime.Now.Year
    Private mes As String = DateTime.Now.Month.ToString.PadLeft(2, "0")
    Private dia As String = DateTime.Now.Day.ToString.PadLeft(2, "0")
    Private mesnom As String = MonthName(mes).ToUpper
    Private direccionurl As String = "\\192.168.1.7\sistema\ASISTENCIA\" & anho & "\" & mesnom
    Dim xSheet As String = ""


    Private Sub btncargararch1_Click(sender As Object, e As EventArgs) Handles btncargararch.Click
        Try

            OpenFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx|Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
            OpenFileDialog1.ShowDialog()

            If Me.OpenFileDialog1.FileName <> "" Then
                ARCHIVO = OpenFileDialog1.FileName

                Dim ds As New DataSet
                Dim da As OleDbDataAdapter
                Dim dt As DataTable
                Dim conn As OleDbConnection

                xSheet = "report"
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" & ARCHIVO & ";Extended Properties='Excel 12.0 Xml;HDR=Yes'")

                Try
                    da = New OleDbDataAdapter("SELECT Documento as Documento, Fecha &' '& Hora as Fecha FROM  [" & xSheet & "$]", conn)

                    conn.Open()
                    da.Fill(ds, "MyData")
                    dt = ds.Tables("MyData")
                    importarExcel(dt)
                    'DataGridView1.DataSource = ds
                    'DataGridView1.DataMember = "MyData"
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Information, "Informacion")
                Finally
                    conn.Close()
                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try
        Label3.Text = "Nro de Registros : " & dgvdatos.Rows.Count
    End Sub

    Sub importarExcel(ByVal DT As DataTable)
        For Each row As DataRow In DT.Rows
            dgvdatos.Rows.Add(row("Documento").Trim.PadLeft(8, "0"), row("Fecha"))
        Next
    End Sub

    Sub SubirArchivo()
        Dim hora As String = "  " & DateTime.Now.ToString("HH-mm-ss tt")
        Dim fichero As New System.IO.FileInfo(direccionurl & "\" & dia & "-" & mes & "-" & anho & hora & ".xls")

        If Directory.Exists(direccionurl) Then
            If fichero.Exists = False Then
                System.IO.File.Copy(ARCHIVO, fichero.FullName)
            Else
                'fichero = New System.IO.FileInfo(direccionurl & "\" & dia & "-" & mes & "-" & anho & "-" & d & ".xls")
                'System.IO.File.Copy(ARCHIVO, fichero.FullName)
            End If
        Else
            My.Computer.FileSystem.CreateDirectory(direccionurl)
            System.IO.File.Copy(ARCHIVO, fichero.FullName)
        End If
    End Sub

    Private Sub btninsertar_Click(sender As Object, e As EventArgs) Handles btninsertar.Click

        insertar()
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
                Dim ELTBTAREOBE As New ELTBTAREOBE
                ELTBTAREOBE.usuario = gsUser
                ELTBTAREOBE.id = gsCodUsr
                ELTBTAREOBE.usuactu = gsCodUsr
                gsError = ELTBTAREOBL.SaveRow(ELTBTAREOBE, flagAccion, dgvdatos)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    If dgvdatos.Rows.Count > 50 Then
                        SubirArchivo()
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
        If dgvdatos.Rows.Count < 1 Then
            MsgBox("No se a cargado Datos al Grid", MsgBoxStyle.Exclamation)
            btncargararch.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim a As String = " " & dpthora.Text
        If btnAgregar.Text = "Agregar" Then
            If txtper.Text = "" Then
                MsgBox("Ingrese el documento del Usuario", MsgBoxStyle.Exclamation)
                txtper.Focus()
            Else
                dgvdatos.Rows.Add(txtper.Text, dptfecha.Text & a)
            End If
        Else
            Dim ELTBTAREOBE As New ELTBTAREOBE
            ELTBTAREOBE.usuario = gsUser
            ELTBTAREOBE.id = lblindice.Text
            ELTBTAREOBE.cod = txtper.Text
            ELTBTAREOBE.fecha = dptfecha.Value.ToShortDateString & a
            ELTBTAREOBE.fecha_ingreso = Label6.Text
            ELTBTAREOBE.usuactu = gsCodUsr
            gsError = ELTBTAREOBL.SaveRow(ELTBTAREOBE, flagAccion, dgvdatos)
            If gsError = "OK" Then
                MsgBox("Dato Actualizado Correctamente", MsgBoxStyle.Information)
                Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub txtper_LostFocus(sender As Object, e As EventArgs) Handles txtper.LostFocus
        If (txtper.Text = "") Then
            lblper.Text = ""
        Else
            Dim dt As DataTable
            dt = ELTBTAREOBL.SelectPerCOD(txtper.Text)
            If dt.Rows.Count > 0 Then
                txtper.Text = dt.Rows(0).Item(0).ToString
                lblper.Text = dt.Rows(0).Item(1).ToString
            Else
                txtper.Text = ""
                lblper.Text = ""
            End If
        End If
    End Sub

    Private Sub txtper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtper.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtper_KeyDown(sender As Object, e As KeyEventArgs) Handles txtper.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "63"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtper.Text = gLinea
                lblper.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub FormELTBTAREO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvdatos.Rows.Clear()
        dgvdatos.DataSource = Nothing
        txtper.Select()
        If gsUser = "LPIÑA" Then
            btninsertar.Enabled = False
        End If
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()
                Deshabilitar(True)
                btnborrar.Visible = True
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc, gArt)
                Deshabilitar(False)
                btnAgregar.Text = "Actualizar"
        End Select
    End Sub
    Private Function Limpiar()
        txtper.Text = ""
        lblper.Text = ""
        'cmbtransp.SelectedIndex = -1
        lblindice.Text = ""
        btnAgregar.Text = "Agregar"
    End Function
    Private Function Deshabilitar(ByVal A As Boolean)
        txtper.Enabled = A
        btncargararch.Enabled = A
    End Function

    Private Sub GetData(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String, ByVal gArt As String)
        txtper.Text = sTDoc
        lblper.Text = gArt
        dptfecha.Value = sSDoc
        dpthora.Value = sSDoc
        lblindice.Text = sNDoc
        Label6.Text = sSDoc

        Dim dtGrid As DataTable
        dtGrid = ELTBTAREOBL.SelectRowGrid(sTDoc)
        For Each row As DataRow In dtGrid.Rows
            dgvdatos.Rows.Add(IIf(IsDBNull(row("COD")), "", row("COD")),
                              IIf(IsDBNull(row("FECHA")), "", row("FECHA")))
        Next
    End Sub

    Private Sub FormMantELTBTAREO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvdatos.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvdatos.Rows.RemoveAt(dgvdatos.CurrentRow.Index)
            dgvdatos.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub
End Class