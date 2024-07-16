Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormELTBKARDEXIMPCOSTO
    Private ELTBKARDEXIMPBL As New ELTBKARDEXIMPBL
    Private s As String = ""
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Dim dtUsuario As DataTable
        Dim costo_comun As Double = 0
        Dim total_peso As Double = 0
        Dim costo_total As Double = 0
        Dim cantidad_hoja As Double = 0
        Dim conteoajuste As Double = 0
        Dim indiceajuste As Double = 0
        For i = 0 To dgvt_doc2.Rows.Count - 1
            If Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 4) = "X" And txtajuste.Text <> 0 Then
                conteoajuste = conteoajuste + 1
                indiceajuste = i
            End If
        Next
        If conteoajuste = 0 Then
            If txtajuste.Text <> 0 Then
                dgvt_doc2.Rows.Add(dgvt_doc2.Rows(0).Cells("T_DOC_REF").Value,
                                   dgvt_doc2.Rows(0).Cells("SER_DOC_REF").Value,
                                   dgvt_doc2.Rows(0).Cells("NRO_DOC_REF").Value,
                                   dgvt_doc2.Rows(0).Cells("T_DOC_REF1").Value,
                                   dgvt_doc2.Rows(0).Cells("SER_DOC_REF1").Value,
                                   dgvt_doc2.Rows(0).Cells("NRO_DOC_REF1").Value,
                                   "SERV",
                                   "X",
                                   "AJUSTE",
                                   "1",
                                   txtajuste.Text)
            End If
        Else
            dgvt_doc2.Rows(indiceajuste).Cells("TPRECIO_COMPRA").Value = txtajuste.Text
        End If
        For i = 0 To dgvt_doc2.Rows.Count - 1
            If dgvt_doc2.Rows(i).Cells("UNIDAD").Value = "SERV" Or dgvt_doc2.Rows(i).Cells("UNIDAD").Value = "HORA" Then
                costo_comun = costo_comun + dgvt_doc2.Rows(i).Cells("TPRECIO_COMPRA").Value
            End If
            If dgvt_doc2.Rows(i).Cells("UNIDAD").Value <> "SERV" And dgvt_doc2.Rows(i).Cells("UNIDAD").Value <> "HORA" Then
                cantidad_hoja = cantidad_hoja + dgvt_doc2.Rows(i).Cells("CANTIDAD").Value
                If Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 4) = "0201" Or Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 2) <> "04" Then
                    'dgvt_doc2.Rows(i).Cells("ANCHO").Value = ELTBKARDEXIMPBL.SelRowDatosAncho(dgvt_doc2.Rows(i).Cells("ART_COD").Value)
                    'dgvt_doc2.Rows(i).Cells("LARGO").Value = ELTBKARDEXIMPBL.SelRowDatosLar(dgvt_doc2.Rows(i).Cells("ART_COD").Value)
                    'dgvt_doc2.Rows(i).Cells("DATO_CONV").Value = ELTBKARDEXIMPBL.SelRowDatosdATO(dgvt_doc2.Rows(i).Cells("ART_COD").Value)
                    'dgvt_doc2.Rows(i).Cells("PESO").Value = ((dgvt_doc2.Rows(i).Cells("ANCHO").Value * dgvt_doc2.Rows(i).Cells("LARGO").Value * dgvt_doc2.Rows(i).Cells("DATO_CONV").Value) / 100000) * dgvt_doc2.Rows(i).Cells("CANTIDAD").Value
                    total_peso = total_peso + dgvt_doc2.Rows(i).Cells("PESO").Value
                End If
            End If
            costo_total = costo_total + dgvt_doc2.Rows(i).Cells("TPRECIO_COMPRA").Value
        Next
        lblcosto_comun.Text = costo_comun
        lblcosto_total.Text = costo_total
        lblcantidad_hoja.Text = cantidad_hoja
        For i = 0 To dgvt_doc2.Rows.Count - 1
            If dgvt_doc2.Rows(i).Cells("UNIDAD").Value <> "SERV" And dgvt_doc2.Rows(i).Cells("UNIDAD").Value <> "HORA" Then
                If Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 4) = "0201" Or Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 2) <> "04" Then 'Or Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 8) = "07010023" Then
                    If cmbtipo.SelectedIndex <> 1 Then
                        dgvt_doc2.Rows(i).Cells("CTO_RPTO").Value = (lblcosto_comun.Text / lblcantidad_hoja.Text) * dgvt_doc2.Rows(i).Cells("CANTIDAD").Value
                    Else
                        dgvt_doc2.Rows(i).Cells("CTO_RPTO").Value = (lblcosto_comun.Text / total_peso) * dgvt_doc2.Rows(i).Cells("PESO").Value
                    End If
                    dgvt_doc2.Rows(i).Cells("CTO_TOT").Value = dgvt_doc2.Rows(i).Cells("CTO_RPTO").Value + dgvt_doc2.Rows(i).Cells("TPRECIO_COMPRA").Value
                    dgvt_doc2.Rows(i).Cells("Precio_uni").Value = dgvt_doc2.Rows(i).Cells("CTO_TOT").Value / dgvt_doc2.Rows(i).Cells("CANTIDAD").Value
                    dgvt_doc2.Rows(i).Cells("PESO_TOTAL").Value = total_peso

                ElseIf Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 2) = "05" Or Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 2) = "04" Then
                    dgvt_doc2.Rows(i).Cells("PESO").Value = dgvt_doc2.Rows(i).Cells("CANTIDAD").Value
                    dgvt_doc2.Rows(i).Cells("CTO_RPTO").Value = (lblcosto_comun.Text / lblcantidad_hoja.Text) * dgvt_doc2.Rows(i).Cells("CANTIDAD").Value
                    dgvt_doc2.Rows(i).Cells("CTO_TOT").Value = dgvt_doc2.Rows(i).Cells("CTO_RPTO").Value + dgvt_doc2.Rows(i).Cells("TPRECIO_COMPRA").Value
                    dgvt_doc2.Rows(i).Cells("Precio_uni").Value = dgvt_doc2.Rows(i).Cells("CTO_TOT").Value / dgvt_doc2.Rows(i).Cells("PESO").Value
                    If Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 4) = "0502" Or Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 4) = "0558" Or Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 8) = "05990008" Or
                        Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 2) = "04" Then
                        dgvt_doc2.Rows(i).Cells("PESO_TOTAL").Value = cantidad_hoja
                    End If
                Else
                    'dgvt_doc2.Rows(i).Cells("PESO").Value = dgvt_doc2.Rows(i).Cells("CANTIDAD").Value
                    dgvt_doc2.Rows(i).Cells("CTO_RPTO").Value = (lblcosto_comun.Text / lblcantidad_hoja.Text) * dgvt_doc2.Rows(i).Cells("CANTIDAD").Value
                    dgvt_doc2.Rows(i).Cells("CTO_TOT").Value = dgvt_doc2.Rows(i).Cells("CTO_RPTO").Value + dgvt_doc2.Rows(i).Cells("TPRECIO_COMPRA").Value
                    dgvt_doc2.Rows(i).Cells("Precio_uni").Value = dgvt_doc2.Rows(i).Cells("CTO_TOT").Value / dgvt_doc2.Rows(i).Cells("CANTIDAD").Value
                End If
            End If
            If cmbtipo.SelectedIndex = -1 Then
                dgvt_doc2.Rows(i).Cells("Tipo").Value = 0
            Else
                dgvt_doc2.Rows(i).Cells("Tipo").Value = cmbtipo.SelectedIndex
            End If
            dgvt_doc2.Rows(i).Cells("Costo_Comun").Value = lblcosto_comun.Text
            dgvt_doc2.Rows(i).Cells("CANTIDAD_TOTAL").Value = cantidad_hoja
            dgvt_doc2.Rows(i).Cells("PRECIO_TOTAL").Value = costo_total
        Next
    End Sub

    Private Sub SaveData()
        If dgvt_doc2.Rows.Count = 0 Then
            MsgBox("El Kardex no tiene Items")
            Exit Sub
        End If
        If MessageBox.Show("Desea grabar el Registro",
                   "Kardex Imp.", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim nro As String
        Dim mesaño As String
        Dim m As String
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBKARDEXIMPCOSBE As New ELTBKARDEXIMPCOSBE
        ELMVLOGSBE.log_codusu = gsUser
        If s <> "1" Then
            gsError = ELTBKARDEXIMPBL.SaveRowCos(ELTBKARDEXIMPCOSBE, ELMVLOGSBE, flagAccion, dgvt_doc2)
        Else
            gsError = ELTBKARDEXIMPBL.SaveRowCos(ELTBKARDEXIMPCOSBE, ELMVLOGSBE, "Limpiar", dgvt_doc2)
        End If
        s = ""
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub SaveData1()
        'If FormELTBKardexImp.dgvt_doc.Rows.Count = 0 Then
        '    MsgBox("La factura no tiene items")
        '    Exit Sub
        'End If
        'If MessageBox.Show("Desea grabar el Registro",
        '           "Kardex Imp.", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        '           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
        '    Exit Sub
        'End If

        'If FormELTBKardexImp.OkData() = False Then
        '    Exit Sub
        'End If
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
        Dim ELTBKARDEXIMPBE As New ELTBKARDEXIMPBE
        Dim ELTBDETKARDEXIMPBE As New ELTBDETKARDEXIMPBE
        ELMVLOGSBE.log_codusu = gsUser
        ELTBKARDEXIMPBE.T_DOC_REF = FormELTBKardexImp.txtt_doc.Text
        ELTBKARDEXIMPBE.SER_DOC_REF = FormELTBKardexImp.cmb_serdoc.Text
        ELTBKARDEXIMPBE.NRO_DOC_REF = FormELTBKardexImp.txtnumero.Text
        ELTBKARDEXIMPBE.FEC_GENE = FormELTBKardexImp.dtpfecha.Text
        ELTBKARDEXIMPBE.PROVEEDOR = FormELTBKardexImp.txtproveedor.Text
        ELTBKARDEXIMPBE.OBSERVA = FormELTBKardexImp.txtobservacion.Text
        ELTBKARDEXIMPBE.MONEDA = FormELTBKardexImp.txtmon.Text
        ELTBKARDEXIMPBE.NRO_DOCU = FormELTBKardexImp.txt_nrofactimp.Text
        ELTBKARDEXIMPBE.FEC_DOCU = FormELTBKardexImp.dtpfecnro.Text
        ELTBKARDEXIMPBE.NRO_DUA = FormELTBKardexImp.txtnumdua.Text
        ELTBKARDEXIMPBE.FEC_DUA = FormELTBKardexImp.dtpfecdua.Text
        ELTBKARDEXIMPBE.PERSONAL = gsUser
        ELTBKARDEXIMPBE.NRO_OREQ = FormELTBKardexImp.txtnro_oreq.Text
        ELTBKARDEXIMPBE.SER_OREQ = "001"

        If FormELTBKardexImp.cmbestado.SelectedIndex = 0 Then
            ELTBKARDEXIMPBE.EST = "H"
        Else
            ELTBKARDEXIMPBE.EST = "A"
        End If
        gsError = ELTBKARDEXIMPBL.SaveRow(ELTBKARDEXIMPBE, ELTBDETKARDEXIMPBE, ELMVLOGSBE, flagAccion, FormELTBKardexImp.dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        ReDim gsRptArgs(2)
        gsRptArgs(0) = dgvt_doc2.Rows(0).Cells("T_DOC_REF").Value
        gsRptArgs(1) = dgvt_doc2.Rows(0).Cells("SER_DOC_REF").Value
        gsRptArgs(2) = dgvt_doc2.Rows(0).Cells("NRO_DOC_REF").Value
        gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_ELTBKARDEXCOS_SEL.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub FormELTBKARDEXIMPCOSTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtajuste.Text = 0
        For i = 0 To dgvt_doc2.Rows.Count - 1
            If Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 4) = "0201" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 4) = "0501" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 4) = "0502" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 2) = "04" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 2) = "08" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 8) = "05580350" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 8) = "05580357" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 8) = "05581509" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 8) = "05581459" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 8) = "05581653" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 8) = "05581583" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 8) = "05990008" Or
                Mid(dgvt_doc2.Rows(i).Cells("ART_COD").Value, 1, 8) = "07012403" Then
                dgvt_doc2.Rows(i).Cells("PESO").Value = ELTBKARDEXIMPBL.SelRowPeso(dgvt_doc2.Rows(i).Cells("T_DOC_REF1").Value,
                                                                                  dgvt_doc2.Rows(i).Cells("SER_DOC_REF1").Value,
                                                                                  dgvt_doc2.Rows(i).Cells("NRO_DOC_REF1").Value,
                                                                                  dgvt_doc2.Rows(i).Cells("ART_COD").Value,
                                                                                  FormELTBKardexImp.txtnro_oreq.Text)
            End If


        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        s = "1"
        dgvt_doc2.Rows.Clear()
        For i = 0 To FormELTBKardexImp.dgvt_doc.Rows.Count - 1
            dgvt_doc2.Rows.Add(FormELTBKardexImp.dgvt_doc.Rows(i).Cells("T_DOC_REF").Value,
                                       FormELTBKardexImp.dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value,
                                       FormELTBKardexImp.dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value,
                                       FormELTBKardexImp.dgvt_doc.Rows(i).Cells("T_DOC_REF1").Value,
                                       FormELTBKardexImp.dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value,
                                       FormELTBKardexImp.dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value,
                                       FormELTBKardexImp.dgvt_doc.Rows(i).Cells("UNIDAD").Value,
                                       FormELTBKardexImp.dgvt_doc.Rows(i).Cells("ART_COD").Value,
                                       FormELTBKardexImp.dgvt_doc.Rows(i).Cells("NOM_ART").Value,
                                       FormELTBKardexImp.dgvt_doc.Rows(i).Cells("CANTIDAD").Value,
                                       FormELTBKardexImp.dgvt_doc.Rows(i).Cells("CANTIDAD").Value * FormELTBKardexImp.dgvt_doc.Rows(i).Cells("UPRECIO_COMPRA").Value)
        Next
        SaveData()
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        SaveData()
        SaveData1()
    End Sub
End Class