Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMultiploArtViru
    Private GUIADESPACHOBL As New GUIADESPACHOBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Lugar, cantidad, articulo, codigo As String
        Dim dt, dt2, dt3 As DataTable
        articulo = FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells(8).Value

        If articulo.Substring(0, 4) = "0223" Then

            'OBTENER CODIGO VIRU
            dt3 = GUIADESPACHOBL.SelectGetCodviru(FormMantGuiaDespacho.txtctct_cod.Text, articulo)
            If dt3.Rows.Count Then
                codigo = dt3.Rows(0).Item(0).ToString
            Else
                MsgBox("Este Articulo no tiene un codigo de cliente asignado", MsgBoxStyle.Information)
            End If

            'OBTENER DISTRITO O PROVINCIA
            dt = GUIADESPACHOBL.SelectGetUbigeo(FormMantGuiaDespacho.txtctct_cod.Text, FormMantGuiaDespacho.txtdir.Text)
            If dt.Rows.Count Then
                Lugar = dt.Rows(0).Item(0).ToString
            End If

            'OBTENER CANTIDAD DE PALLTES
            dt2 = GUIADESPACHOBL.SelectGetCantidadPallets(FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells(7).Value, FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells(8).Value)
            If dt2.Rows.Count Then
                cantidad = dt2.Rows(0).Item(0).ToString
            End If

            ReDim gsRptArgs(5)
            gsRptArgs(0) = Lugar
            gsRptArgs(1) = FormMantGuiaDespacho.cmb_serdoc.SelectedItem
            gsRptArgs(2) = FormMantGuiaDespacho.txtnumero.Text
            gsRptArgs(3) = cantidad
            gsRptArgs(4) = codigo
            gsRptArgs(5) = npdmultiplo.Value
            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_RPTETIQUETA_PALLETS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
            Exit Sub
        Else
            MsgBox("No se pueden imprimir etiquetas para este articulo", MsgBoxStyle.Information)
        End If
    End Sub
End Class