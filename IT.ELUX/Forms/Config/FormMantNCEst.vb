Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantNCEst
    Private NOTACREDITOBL As New NOTACREDITOBL
    Private PROVISIONESBL As New PROVISIONESBL
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   "Estado Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If


        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim NOTACREDITOBE As New NOTACREDITOBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE


        NOTACREDITOBE.T_DOC_REF = RTrim(txtt_doc.Text)
        NOTACREDITOBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
        NOTACREDITOBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        If chkx_d.Checked Then
            NOTACREDITOBE.X_D = "1"
        Else
            NOTACREDITOBE.X_D = ""
        End If
        gsError = NOTACREDITOBL.SaveRowEst(NOTACREDITOBE, ELMVLOGSBE, "ACTEST")
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = NOTACREDITOBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc.Text)
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            txtctct_cod.Text = IIf(IsDBNull(Registro("CTCT_COD")), "", Registro("CTCT_COD"))
            txtnom_ctct.Text = PROVISIONESBL.SelectT_Prov(txtctct_cod.Text)
            'dtpfanul.Checked = IIf(IsDBNull(Registro("FEC_ANU")), False, True)
            txttprecio_compra.Text = IIf(IsDBNull(Registro("tprecio_venta")), "", Registro("tprecio_venta"))
            txttprecio_dcompra.Text = IIf(IsDBNull(Registro("tprecio_dventa")), "", Registro("tprecio_dventa"))
            txtt_dcto.Text = IIf(IsDBNull(Registro("T_DCTO")), 0, Registro("T_DCTO"))
            txtt_dcto_dolar.Text = IIf(IsDBNull(Registro("T_DCTO_DOLAR")), 0, Registro("T_DCTO_DOLAR"))
            txtt_igv.Text = IIf(IsDBNull(Registro("T_IGV")), "", Registro("T_IGV"))
            txtt_igv_dolar.Text = IIf(IsDBNull(Registro("T_IGV_DOLAR")), "", Registro("T_IGV_DOLAR"))
            If txttprecio_compra.TextLength > 0 And txtt_igv.TextLength > 0 And txtt_dcto.TextLength > 0 Then
                txttcompras.Text = Math.Round(CDbl(txttprecio_compra.Text) + CDbl(txtt_igv.Text) - CDbl(txtt_dcto.Text), 2)
                txttcomprad.Text = Math.Round(CDbl(txttprecio_dcompra.Text) + CDbl(txtt_igv_dolar.Text) - CDbl(txtt_dcto_dolar.Text), 2)
            Else
                txttcompras.Text = 0
                txttcomprad.Text = 0
            End If
            If IIf(IsDBNull(Registro("X_D")), "", Registro("X_D")) = "1" Then
                chkx_d.Checked = True
            Else
                chkx_d.Checked = False
            End If

        Next
    End Sub
    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If

            Select Case sFunc

                Case "save"
                    SaveData()
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormMantNCEst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero") '2
        Select Case gnOpcion

            Case 1
                Me.Text = "Estado Facturas"
                flagAccion = "M"
                GetData("07", sSDoc, sNDoc)
                dt = NOTACREDITOBL.getListdgv2("07", sSDoc, sNDoc)
                For Each row As DataRow In dt.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")))
                Next
        End Select
    End Sub

    Private Sub FormMantNCEst_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class