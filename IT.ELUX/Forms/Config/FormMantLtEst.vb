Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantLtEst
    Private LETRASBL As New LETRASBL
    Private PROVISIONESBL As New PROVISIONESBL
    Private Sub FormMantLtEst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("PROVEEDOR", "RUC") '3
        dgvt_doc.Columns.Add("NOM_CTCTC", "Raz. Social") '4
        dgvt_doc.Columns.Add("FEC_GENE", "Fecha") '5
        Select Case gnOpcion

            Case 1
                Me.Text = "Estado Letras"
                flagAccion = "M"
                GetData("80", sSDoc, sNDoc)
                dt = LETRASBL.getListdgv2("80", sSDoc, sNDoc)
                For Each row As DataRow In dt.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")))
                Next
        End Select
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = LETRASBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(txtt_doc.Text)
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            dtpfechaprov.Text = IIf(IsDBNull(Registro("FEC_VIGENCIA")), "", Registro("FEC_VIGENCIA"))
            txtctct_cod.Text = IIf(IsDBNull(Registro("CTCT_COD")), "", Registro("CTCT_COD"))
            txtnom_ctct.Text = PROVISIONESBL.SelectT_Prov(txtctct_cod.Text)
            'dtpfanul.Checked = IIf(IsDBNull(Registro("FEC_ANU")), False, True)
            txttprecio_compra.Text = IIf(IsDBNull(Registro("tprecio_venta")), "", Registro("tprecio_venta"))
            txttprecio_dcompra.Text = IIf(IsDBNull(Registro("tprecio_dventa")), "", Registro("tprecio_dventa"))
            txtt_dcto.Text = IIf(IsDBNull(Registro("T_DCTO")), 0, Registro("T_DCTO"))
            txtt_dcto_dolar.Text = IIf(IsDBNull(Registro("T_DCTO_DOLAR")), 0, Registro("T_DCTO_DOLAR"))
            txtt_igv.Text = IIf(IsDBNull(Registro("T_IGV")), "", Registro("T_IGV"))
            txtt_igv_dolar.Text = IIf(IsDBNull(Registro("T_IGV_DOLAR")), "", Registro("T_IGV_DOLAR"))
            txtmontopagados.Text = IIf(IsDBNull(Registro("MONTO_PAGADO")), 0, Registro("MONTO_PAGADO"))
            txtmontopagadod.Text = IIf(IsDBNull(Registro("MONTO_PAGADOD")), 0, Registro("MONTO_PAGADOD"))
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
            If IIf(IsDBNull(Registro("BINTERES")), "", Registro("BINTERES")) = "1" Then
                chkbinteres.Checked = True
            Else
                chkbinteres.Checked = False
            End If
            If IIf(IsDBNull(Registro("est1")), "", Registro("est1")) = "T" Then
                cmbest1.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("est1")), "", Registro("est1")) = "N" Then
                cmbest1.SelectedIndex = 2
            End If

            If IIf(IsDBNull(Registro("moneda")), "", Registro("moneda")) = "00" Then
                txtmoneda.Text = "Soles"
            Else
                txtmoneda.Text = "Dolares"
            End If

        Next
    End Sub
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   "Estado Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If


        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim LETRASBE As New LETRASBE


        LETRASBE.T_DOC_REF = RTrim(txtt_doc.Text)
        LETRASBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
        LETRASBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        If chkx_d.Checked Then
            LETRASBE.X_D = "1"
        Else
            LETRASBE.X_D = ""
        End If

        If chkbinteres.Checked Then
            LETRASBE.BINTERES = "1"
        Else
            LETRASBE.BINTERES = ""
        End If
        If cmbest1.SelectedIndex = 1 Then
            LETRASBE.EST1 = "T"
        ElseIf cmbest1.SelectedIndex = 2 Then
            LETRASBE.EST1 = "N"
        ElseIf cmbest1.SelectedIndex = 0 Then
            LETRASBE.EST1 = ""
        ElseIf cmbest1.SelectedIndex = -1 Then
            LETRASBE.EST1 = ""
        End If

        gsError = LETRASBL.SaveRowEst(LETRASBE, ELMVLOGSBE, "ACTEST")
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

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

    Private Sub FormMantLtEst_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class