Public Class FormMantFCRecepNew
    Private Sub FormMantFCRecepNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Recepcion Comprobantes"
        Me.cmb_serdoc.Text = sAño
        dgvt_doc.Columns.Add("SER_DOCU", "Ser.Guia") '6
        dgvt_doc.Columns.Add("Nro_DOCU", "Nro.Guia") '7
        dgvt_doc.Columns.Add("SER_DOCU1", "Ser.Fact.") '8
        dgvt_doc.Columns.Add("NRO_DOCU1", "Nro.Fact") '9
        dgvt_doc.Columns.Add("CTCT_COD", "RUC/RAZ. SOCIAL") '10
        dgvt_doc.Columns.Add("NOM_CTCT", "Proveedor") '11
        dgvt_doc.Columns.Add("CANTIDAD", "Cantidad") '12
        dgvt_doc.Columns.Add("ART_COD", "Cod. Art.") '13
        dgvt_doc.Columns.Add("NOM_ART", "Nom. Art.") '14
        dgvt_doc.Columns.Add("FEC_GENE", "Fecha Llegada.") '15
        dgvt_doc.Columns.Add("CCO_COD", "CCO_COD") '16
        dgvt_doc.Columns.Add("ACT_COD", "ACT_COD") '17
        dgvt_doc.Columns.Add("PER_COD", "PER_COD") '18
        dgvt_doc.Columns.Add("SREQ", "SREQ") '19
        dgvt_doc.Columns.Add("NREQ", "NREQ") '20
        dgvt_doc.Columns.Add("UNIDAD", "UNIDAD") '21
        dgvt_doc.Columns.Add("EST", "UNIDAD") '22
        dgvt_doc.Columns.Add("NRO_DOCU2", "NRO_DOCU2") '22
        Dim nro As String
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked

    End Sub
End Class