Imports System.ComponentModel
Imports IT.ELUX.BL

Public Class FormBusquedaAnterior

    Private ARTICULOBL As New ARTICULOBL
    Private gdtMainData As DataTable

    Private Sub GetData(ByVal sCode As String)
        Dim dtArticulo As DataTable
        Dim Registro As DataRow
        dtArticulo = ARTICULOBL.SelectRow(sCode)

        For Each Registro In dtArticulo.Rows
            'FormMantArticulo.txtartcodigo.Text = IIf(IsDBNull(Registro("ART_CODIGO")), "", Registro("ART_CODIGO"))
            'FormMantArticulo.txtartdescripcion.Text = IIf(IsDBNull(Registro("ART_DESCRI")), "", Registro("ART_DESCRI"))
            'FormMantArticulo.txtcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            'cmbestado.SelectedText = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))
            'FormMantArticulo.cmblinea.Text = IIf(IsDBNull(Registro("ART_SLINEA")), "", Registro("ART_SLINEA"))
            FormMantArticulo.cmbcentrocosto.SelectedValue = IIf(IsDBNull(Registro("CCOSTO_COD")), "", Registro("CCOSTO_COD"))
            FormMantArticulo.cmbcodalmacen.SelectedValue = IIf(IsDBNull(Registro("ALM_COD")), "", Registro("ALM_COD"))
            'IIf(IsDBNull(Registro("ALM_COD")), "", Registro("ALM_COD"))
            Select Case Registro("X_KARDEX").ToString
                Case ""
                    FormMantArticulo.cmbkardex.SelectedIndex = 1
                Case "S"
                    FormMantArticulo.cmbkardex.SelectedIndex = 0
                Case "1"
                    FormMantArticulo.cmbkardex.SelectedIndex = 0
            End Select
            Select Case Registro("EST").ToString
                Case ""
                    FormMantArticulo.cmbestado.SelectedIndex = -1
                Case "H"
                    FormMantArticulo.cmbestado.SelectedIndex = 0
                Case "A"
                    FormMantArticulo.cmbestado.SelectedIndex = 1
            End Select
            'Select Case Registro("UBIART_COD").ToString
            '    Case ""
            '        FormMantArticulo.cmbubicacionalm.SelectedIndex = -1
            '    Case "1"
            '        FormMantArticulo.cmbubicacionalm.SelectedIndex = 0
            '    Case "2"
            '        FormMantArticulo.cmbubicacionalm.SelectedIndex = 1
            '    Case "3"
            '        FormMantArticulo.cmbubicacionalm.SelectedIndex = 2
            'End Select
            Select Case Registro("ART_APROREQ").ToString
                Case ""
                    FormMantArticulo.cmbart_apreq.SelectedIndex = -1
                Case "S"
                    FormMantArticulo.cmbart_apreq.SelectedIndex = 0
                Case "N"
                    FormMantArticulo.cmbart_apreq.SelectedIndex = 1
            End Select

            FormMantArticulo.cmbunidadmedida.SelectedValue = IIf(IsDBNull(Registro("UNI_COD")), "", Registro("UNI_COD"))
            FormMantArticulo.cmbcatalogo.SelectedValue = IIf(IsDBNull(Registro("ART_CODCAT")), "", Registro("ART_CODCAT"))
            FormMantArticulo.cmbfamilia1.SelectedValue = IIf(IsDBNull(Registro("FAM1")), "", Registro("FAM1"))
            FormMantArticulo.cmbfamilia2.SelectedValue = IIf(IsDBNull(Registro("FAM2")), "", Registro("FAM2"))
            FormMantArticulo.cmbfamilia3.SelectedValue = IIf(IsDBNull(Registro("FAM3")), "", Registro("FAM3"))
            FormMantArticulo.cmbfamilia4.SelectedValue = IIf(IsDBNull(Registro("FAM4")), "", Registro("FAM4"))
            FormMantArticulo.cmbfamilia5.SelectedValue = IIf(IsDBNull(Registro("FAM5")), "", Registro("FAM5"))
            FormMantArticulo.txtcodfamcontable.Text = FormMantArticulo.cmbfamilia1.Text + FormMantArticulo.cmbfamilia2.Text + FormMantArticulo.cmbfamilia3.Text + FormMantArticulo.cmbfamilia4.Text + FormMantArticulo.cmbfamilia5.Text
            ' FormMantArticulo.txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
        Next




    End Sub
    Private Sub FormBusquedaAnterior_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.WaitCursor

        Dim dt As New DataTable

        dt = ARTICULOBL.getArticuloAnterior()
        dgvMain.DataSource = dt
        dgvMain.Refresh()

        gdtMainData = dt

        tsbCamposSeek.Items.Clear()

        'get columns of DGV
        For Each col As DataGridViewColumn In dgvMain.Columns
            ' MessageBox.Show(col.Name)
            tsbCamposSeek.Items.Add(col.Name)

        Next

        Cursor.Current = Cursors.Default
        'limpiar busqueda

        lblRecNo.Text = dgvMain.Rows.Count

        'dgv color
        dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
        dgvMain.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
        dgvMain.EnableHeadersVisualStyles = False

    End Sub

    Private Sub tsTextSearch_TextChanged(sender As Object, e As EventArgs) Handles tsTextSearch.TextChanged

        If tsbCamposSeek.Text = "" Then
            MsgBox("Debe ingresar campo de busqueda")
            Exit Sub
        End If

        Dim sCode As String = tsTextSearch.Text

        If sCode.Trim = "" Then
            dgvMain.DataSource = gdtMainData
            lblRecNo.Text = dgvMain.Rows.Count
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor


        Dim dtNew As DataTable

        ' copy table structure
        dtNew = gdtMainData.Clone()

        'obtener nombre de campo
        Dim sCampo As String = tsbCamposSeek.Text

        'buscar valor del txt en dt
        Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " LIKE '%" & sCode & "%'")

        For Each ldrRow As DataRow In dataRows
            dtNew.ImportRow(ldrRow)
        Next
        dgvMain.DataSource = dtNew

        lblRecNo.Text = dgvMain.Rows.Count

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub dgvMain_DoubleClick(sender As Object, e As EventArgs) Handles dgvMain.DoubleClick
        If IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value) = "" Then
            FormMantArticulo.txtcodigo.Text = IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value)
            GetData(IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value))
            FormMantArticulo.txtartdescripcion.Text = IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value)
            FormMantArticulo.txtnom.Text = IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value)
            'MsgBox(IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value))
            Me.Dispose()
        Else
            MsgBox("Este Articulo ya cuenta con codigo nuevo")
        End If

    End Sub

    Private Sub FormBusquedaAnterior_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class