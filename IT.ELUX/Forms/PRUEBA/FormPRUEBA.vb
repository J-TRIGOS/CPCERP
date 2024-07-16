Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormPRUEBA
    Private ELTBKARDEXBL As New ELTBKARDEXBL
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub FormPRUEBA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvt_doc.Columns.Add("TIPO", "T_DOC_REF") '0
        dgvt_doc.Columns.Add("SERIE", "SER_DOC_REF") '1
        dgvt_doc.Columns.Add("NUMERO", "NRO_DOC_REF") '2
        dgvt_doc.Columns.Add("ART", "ART_COD") '2
        dgvt_doc.Columns.Add("UPRECIO", "UPRECIO") '2
    End Sub

    Private Sub FormPRUEBA_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dtArticulo As DataTable
        dtArticulo = ELTBKARDEXBL.SelRowPRECIO()
        For Each row As DataRow In dtArticulo.Rows
            dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),
                              IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),
                              IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),
                              IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),
                              IIf(IsDBNull(row("UPRECIO_COMPRA")), "", row("UPRECIO_COMPRA")))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ELTBKARDEXBE As New ELTBKARDEXBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        gsError = ELTBKARDEXBL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, "MOVPRECIO", dgvt_doc, "", "", "")
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub
End Class