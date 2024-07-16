Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantDetLet_Monto
    Private PROVISIONESBL As New PROVISIONESBL
    Private FACTURACIONBL As New FACTURACIONBL
    Private LETRASBL As New LETRASBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private bPrimero As Boolean = True
    Private CantD As Integer
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Function OkData() As Boolean
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("Debe Ingresar Letras", MsgBoxStyle.Exclamation)
            'cmbestado.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub SaveData()
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("La factura no tiene items")
            Exit Sub
        End If
        If MessageBox.Show("Desea grabar el Registro",
                   "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        Dim dt As DataTable
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim nro As String
        Dim mesaño As String
        Dim m As String
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim LETRASBE As New LETRASBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        Dim ELTBLETRAS_MONTOBE As New ELTBLETRAS_MONTOBE
        If flagAccion = "N" Then
            For i = 0 To dgvt_doc.Rows.Count - 1
                nro = LETRASBL.SelectNro1("80", dtpfec_gene.Value.Year)
                nro = nro + i
                dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value = nro.ToString.PadLeft(7, "0")
                dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value = dtpfec_gene.Value.Year
            Next
        End If
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        LETRASBE.ART_COD = "07010003"
        LETRASBE.FEC_GENE = dgvt_doclet.Rows(0).Cells("FEC_GENE").Value
        LETRASBE.EST = "H"
        LETRASBE.FEC_ANU = Nothing
        'chequear
        LETRASBE.FEC_LETRA = Nothing
        LETRASBE.Z_LETRA = ""
        LETRASBE.BINTERES = ""
        LETRASBE.EST1 = ""
        If txtmoneda.Text = "00" Then
            'LETRASBE.MONTO_PAGADO = CDbl(txtmontopagado.Text)
        Else
            'LETRASBE.MONTO_PAGADOD = CDbl(txtmontopagadod.Text)
        End If
        LETRASBE.ALM_COD = ""
        LETRASBE.SIGNO = "-"
        LETRASBE.OBSERVA = ""
        LETRASBE.MONEDA = txtmoneda.Text
        LETRASBE.DIR_COD = dgvt_doclet.Rows(0).Cells("DIR_COD").Value
        'For i = 0 To dgvt_doc.Rows.Count - 1
        ' DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value) + DAcumula
        'DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value) + DAcumula1
        'DAcumula2 = Val(dgvt_doc.Rows(i).Cells("DSCTO_IMPOR").Value) + DAcumula2
        'DAcumula3 = Val(dgvt_doc.Rows(i).Cells("DSCTO_DIMPOR").Value) + DAcumula3
        'DAcumula4 = Val(dgvt_doc.Rows(i).Cells("IGV_IMPOR").Value) + DAcumula4
        'DAcumula5 = Val(dgvt_doc.Rows(i).Cells("IGV_DIMPOR").Value) + DAcumula5
        'Next
        LETRASBE.TPRECIO_VENTA = DAcumula
        LETRASBE.TPRECIO_DVENTA = DAcumula1
        LETRASBE.T_DCTO = DAcumula2
        LETRASBE.T_DCTO_DOLAR = DAcumula3
        LETRASBE.T_IGV = DAcumula4
        LETRASBE.T_IGV_DOLAR = DAcumula5
        LETRASBE.PROVEEDOR = "20100279348"
        LETRASBE.CTCT_COD = RTrim(txtproveedor.Text)
        LETRASBE.FEC_DIA = RTrim(DateTime.Now)
        LETRASBE.NUMPEDIDO = dgvt_doclet.Rows(0).Cells("NUMPEDIDO").Value
        LETRASBE.USUARIO = RTrim(gsUser)
        'LETRASBE.F_PAGO_ENT = dgvt_doclet.Rows(0).Cells("NUM_PEDIDO").Value
        LETRASBE.NOM_CTCT = txtnomproveedor.Text
        LETRASBE.VENDEDOR = dgvt_doclet.Rows(0).Cells("VENDEDOR").Value
        LETRASBE.X_D = ""
        'LETRASBE.FEC_VIGENCIA = dtpfec_vigencia.Value
        ELMVLOGSBE.log_codusu = gsCodUsr
        'LETRASBE.REG_NRO = Replace(Mid(dtpfecha.Value, 4, 7), "/", "")
        mesaño = Replace(Mid(dtpfec_gene.Value, 4, 7), "/", "")
        m = Mid(dtpfec_gene.Value, 4, 2)
        Dim mesfecha As String
        Dim mesdia As String
        If dtpfec_gene.Value.Month.ToString.Length = "1" Then
            mesfecha = "0" & dtpfec_gene.Value.Month.ToString
        Else
            mesfecha = dtpfec_gene.Value.Month.ToString
        End If
        If dtpfec_gene.Value.Day.ToString.Length = "1" Then
            mesdia = "0" & dtpfec_gene.Value.Day.ToString
        Else
            mesdia = dtpfec_gene.Value.Day.ToString
        End If
        LETRASBE.PAG_PARCIAL = 0
        dt = REQUERIMIENTOBL.getT_CAMB(dtpfec_gene.Value.Year & "/" & mesfecha & "/" & mesdia)
        For Each Registro In dt.Rows
            LETRASBE.T_CAMB = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next
        If flagAccion = "N" Then
            gsError = LETRASBL.SaveRow1(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, "FL", dgvt_doclet, dgvt_doc, dgvt_det, ELTBLETRAS_MONTOBE)
        Else

        End If
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            mesaño = Replace(Mid(dtpfec_gene.Value, 4, 7), "/", "")
            m = Mid(dtpfec_gene.Value, 4, 2)
            For i = 0 To dgvt_doc.Rows.Count - 1
                gsError2 = LETRASBL.AsientoFC("Asiento", mesaño, m, dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value, dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value, "80", "H", dgvt_doc)
            Next
            If gsError2 = "OK" Then
                MsgBox("Asiento Creado", MsgBoxStyle.Information)
            Else
                FormMain.LblError.Text = gsError2
                MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
            End If
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub FormMantDetLet_Monto_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        'MODIFICAR
        dtUsuario = LETRASBL.SelectRowLetra(sT_Ref, sS_Ref, sN_Ref)

        For Each row As DataRow In dtUsuario.Rows
            dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                              IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                              IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                              IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                              IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                              IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                              IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'6
                              IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),'7
                              IIf(IsDBNull(row("MONTOS")), "", row("MONTOS")),'8
                              IIf(IsDBNull(row("MONTOD")), "", row("MONTOD")),'9
                              IIf(IsDBNull(row("MONTOS_FACT")), "", row("MONTOS_FACT")),'10
                              IIf(IsDBNull(row("MONTOD_FACT")), "", row("MONTOD_FACT")),'11
                              IIf(IsDBNull(row("T_CMB")), "", row("T_CMB")),'12
                              IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),'13
                              IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")),'14
                              IIf(IsDBNull(row("FEC_VIGENCIA")), "", row("FEC_VIGENCIA")),'15
                              IIf(IsDBNull(row("EST")), "", row("EST"))) '16

        Next
    End Sub
    Private Sub FormMantDetLet_Monto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfec_vigencia.Value = dtpfec_gene.Value
        Dim dt As DataTable
        'MONTO LETRA
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero") '5
        dgvt_doc.Columns.Add("CTCT_COD", "Cliente") '6
        dgvt_doc.Columns.Add("MONEDA", "MONEDA") '7
        dgvt_doc.Columns.Add("MONTOS", "Monto_Soles") '8
        dgvt_doc.Columns.Add("MONTOD", "Monto_Dolares") '9
        dgvt_doc.Columns.Add("MONTOS_FACT", "Monto_FACTURAS") '10
        dgvt_doc.Columns.Add("MONTOD_FACT", "Monto_FACTURAD") '11
        dgvt_doc.Columns.Add("T_CMB", "Tipo_Cambio") '12
        dgvt_doc.Columns.Add("FEC_GENE", "Fec_Gene") '13
        dgvt_doc.Columns.Add("F_PAGO_ENT", "Forma_pago") '14
        dgvt_doc.Columns.Add("FEC_VIGENCIA", "Fec_vigencia") '15
        dgvt_doc.Columns.Add("EST", "EST") '16
        dgvt_doc.Columns.Add("TPRECIO_VENTA", "TPRECIO_VENTA") '17
        dgvt_doc.Columns.Add("TPRECIOD_VENTA", "TPRECIO_DVENTA") '18
        dgvt_doc.Columns.Add("TPRECIOD_VENTA", "TPRECIO_DVENTA") '19
        dgvt_doc.Columns.Add("T_IGV", "T_IGV") '20
        dgvt_doc.Columns.Add("T_IGV_DOLAR", "T_IGV_DOLAR") '21


        dt = FACTURACIONBL.SelectF_PAGO
        GetCmb("cod", "nom", dt, cmbt_pago)
        Dim prov As String = PROVISIONESBL.SelectT_Prov(txtproveedor.Text)
        txtnomproveedor.Text = prov
        GetData(txtt_doc_ref.Text, txtser_doc_ref.Text, txtnro_doc_ref.Text)
        bPrimero = False
        If dgvt_doc.Rows.Count = 0 Then
            btnanular.Text = "Borrar"
            flagAccion = "N"
        Else
            flagAccion = "M"
        End If
        'If lblnumlet.Text = "1" Then
        If dgvt_doc.Rows.Count = 0 Then
                If txtmoneda.Text = "01" Then
                    npdmontod.Value = npdmontod_fact.Value
                Else
                    npdmontos.Value = npdmontos_fact.Value
                End If
            End If
        'End If
    End Sub

    Private Sub cmbt_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_pago.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbt_pago.SelectedValue Is Nothing Then
            Exit Sub
        End If
        dtpfec_vigencia.Value = dtpfec_gene.Value
        txtt_pago.Text = cmbt_pago.SelectedValue
        CantD = LETRASBL.SelectCantDias(txtt_pago.Text)
        Me.dtpfec_vigencia.Value = Me.dtpfec_vigencia.Value.Date.AddDays(CantD)
    End Sub

    Private Sub txtt_pago_LostFocus(sender As Object, e As EventArgs) Handles txtt_pago.LostFocus
        If txtt_pago.Text = "" Then
            cmbt_pago.SelectedValue = ""
            Exit Sub
        End If
        cmbt_pago.SelectedValue = txtt_pago.Text
        dtpfec_vigencia.Value = dtpfec_gene.Value
        If cmbt_pago.SelectedValue Is Nothing Then
            MsgBox("Tipo de pago no existe", MsgBoxStyle.Exclamation)
            txtt_pago.Text = ""
        Else
            CantD = LETRASBL.SelectCantDias(txtt_pago.Text)
            Me.dtpfec_vigencia.Value = Me.dtpfec_vigencia.Value.Date.AddDays(CantD)
        End If
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnanular.Click
        If btnanular.Text = "Borrar" Then
            If dgvt_doc.RowCount > 0 Then
                If MessageBox.Show("Esta seguro de Eliminar el Registro",
                               "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                    Exit Sub
                End If
                dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
                dgvt_doc.Refresh()
            Else
                MsgBox("No hay datos")
            End If
        Else

        End If

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim acum As Double = 0
        If txtmoneda.Text = "00" Then
            If npdmontos.Value = 0 Then
                MsgBox("El monto debe ser mayor a 0")
                Exit Sub
            End If
        Else
            If npdmontod.Value = 0 Then
                MsgBox("El monto debe ser mayor a 0")
                Exit Sub
            End If
        End If
        If lblnumlet.Text < dgvt_doc.Rows.Count + 1 Then
            MsgBox("No debe superar la cantidad de Letras designadas")
            Exit Sub
        End If
        If txtt_pago.Text = "" Then
            MsgBox("Debe tener Tipo de Pago")
            Exit Sub
        End If
        If dgvt_doc.Rows.Count > 0 Then
            For i = 0 To dgvt_doc.Rows.Count - 1
                If txtmoneda.Text = "00" And dgvt_doc.Rows(i).Cells("EST").Value = "H" Then
                    acum = acum + dgvt_doc.Rows(i).Cells("MONTOS").Value
                ElseIf txtmoneda.Text = "01" And dgvt_doc.Rows(i).Cells("EST").Value = "H" Then
                    acum = acum + dgvt_doc.Rows(i).Cells("MONTOD").Value
                End If
            Next
            If txtmoneda.Text = "00" Then
                acum = acum + npdmontos.Value
                If acum > npdmontos_fact.Value Then
                    MsgBox("El monto ya supero el monto de la factura Corrija")
                    Exit Sub
                End If
            ElseIf txtmoneda.Text = "01" Then
                acum = acum + npdmontod.Value
                If acum > npdmontod_fact.Value Then
                    MsgBox("El monto ya supero el monto de la factura Corrija")
                    Exit Sub
                End If
            End If
        Else
            If txtmoneda.Text = "00" Then
                If npdmontos.Value > npdmontos_fact.Value Then
                    MsgBox("El monto ya supero el monto de la factura Corrija")
                    Exit Sub
                End If
            Else
                If npdmontod.Value > npdmontod_fact.Value Then
                    MsgBox("El monto ya supero el monto de la factura Corrija")
                    Exit Sub
                End If
            End If
        End If
        dgvt_doc.Rows.Add("", "", "",
                          txtt_doc_ref.Text,
                          txtser_doc_ref.Text,
                          txtnro_doc_ref.Text,
                          txtproveedor.Text,
                          txtmoneda.Text,
                          npdmontos.Value,
                          npdmontod.Value,
                          npdmontos_fact.Value,
                          npdmontod_fact.Value,
                          npdt_cmb.Value,
                          dtpfec_gene.Value,
                          txtt_pago.Text,
                          dtpfec_vigencia.Text,
                          "H")
        npdmontod.Value = 0
        txtt_pago.Text = ""
        cmbt_pago.SelectedIndex = -1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "226"
        'Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()

        If gLinea <> Nothing Then
            txtt_pago.Text = gLinea
            cmbt_pago.SelectedValue = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Dim mesaño As String
            Dim m As String
            Select Case sFunc

                Case "save"
                    SaveData()
                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
                    If dgvt_doc.Rows.Count > 0 Then
                        For i = 0 To dgvt_doc.Rows.Count - 1
                            ReDim gsRptArgs(2)
                            gsRptArgs(0) = "80"
                            gsRptArgs(1) = dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value
                            gsRptArgs(2) = dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value
                            gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_DOCUMENTO_LETRA.rpt"
                            gsRptPath = gsPathRpt
                            FormReportes.ShowDialog()
                        Next
                    Else
                        MsgBox("No hay letras para imprimir")
                    End If


            End Select
        Catch ex As Exception

        End Try

    End Sub
End Class