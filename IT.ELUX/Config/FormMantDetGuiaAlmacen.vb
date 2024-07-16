Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantDetGuiaAlmacen
    Private ARTICULOBL As New ARTICULOBL
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As Boolean = True
    Private Sub CleanVar()
        cmbart.SelectedIndex = -1
        cmblinea.SelectedIndex = -1
        cmbsublinea.SelectedIndex = -1
        npdcantidad.Value = "0.000"
        txtlote.Text = ""
        txtobservacion.Text = ""
        cmbuni.SelectedIndex = -1
    End Sub
    Private Sub habilitar(ByVal bl As Boolean)
        txtobservacion.Enabled = bl
        'txt
    End Sub
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Dispose()
    End Sub

    Private Sub FormMantDetRequerimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        Me.Text = "Detalle de Guia"
        Dim dt As DataTable = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmblinea)
        dt = ARTICULOBL.SelectUndMed()
        GetCmb("cod", "nom", dt, cmbuni)
        If gContador = 0 Then
            'bPrimero = True
            cmblinea.SelectedValue = Mid(gsCode3, 1, 2) & "00"
            dt = ARTICULOBL.SelectDescripcion1(cmblinea.SelectedValue)
            GetCmb("lin_codigo", "lin_descri", dt, cmbsublinea)
            cmbsublinea.SelectedValue = Mid(gsCode3, 1, 4)
            dt = ARTICULOBL.SelectArt1(cmbsublinea.SelectedValue)
            GetCmb("ART_CODIGO", "ART_COD", dt, cmbart)
            cmbart.SelectedValue = Trim(gsCode3)
            cmbuni.SelectedValue = sUni
            txtcodart.Text = Trim(gsCode3)
        Else
            CleanVar()
            cmbart.DataSource = Nothing
            cmbsublinea.DataSource = Nothing
            habilitar(True)
        End If
        bPrimero = False
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If cmbuni.SelectedIndex = -1 Then
            MsgBox("Ingrese la unidad de medida")
            Exit Sub
        End If
        If npdcantidad.Value > 0 Then
            Dim sValor As String
            Dim i As Integer
            Dim icontador As Integer
            If gContador = 1 Then
                gContador = 0
                For i = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                    If FormMantGuiaAlmacen.dgvt_doc.Rows(i).Cells("ART_COD").Value = txtcodart.Text Then
                        MsgBox("Este articulo ya se encuentra listado")
                        Exit Sub
                    End If
                Next
                sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                If FormMantGuiaAlmacen.dgvt_doc.Rows.Count > 0 Then
                    For i = 0 To FormMantGuiaAlmacen.dgvt_doc.Rows.Count - 1
                        If FormMantGuiaAlmacen.dgvt_doc.Rows(i).Cells(8).Value = cmbart.SelectedValue Then
                            icontador = icontador + 1
                        End If
                    Next
                End If
                If icontador > 0 Then
                    FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, '0Z
                                                      FormMantGuiaAlmacen.cmb_serdoc.Text,'1
                                                      FormMantGuiaAlmacen.txtnumero.Text, '2
                                                      FormMantGuiaAlmacen.txtt_doc.Text, '3
                                                      FormMantGuiaAlmacen.cmb_serdoc.Text,'4
                                                      FormMantGuiaAlmacen.txtnumero.Text & "-" & icontador, '5
                                                      FormMantGuiaAlmacen.txtproveedor.Text,'6 
                                                      npdcantidad.Value, '7
                                                      cmbart.SelectedValue,'8
                                                      sValor, '9
                                                      Nothing, '10
                                                      "",'11
                                                      "", "", "", "+", txtobservacion.Text, FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                      "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),
                                                      FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                      RTrim(DateTime.Now), "20100279348", FormMantGuiaAlmacen.txtc_costo.Text, "", txtlote.Text, FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                      FormMantGuiaAlmacen.cmbestado.Text)
                    Dispose()
                Else
                    FormMantGuiaAlmacen.dgvt_doc.Rows.Add(FormMantGuiaAlmacen.txtt_doc.Text, '0
                                                          FormMantGuiaAlmacen.cmb_serdoc.Text,'1
                                                          FormMantGuiaAlmacen.txtnumero.Text, '2
                                                          FormMantGuiaAlmacen.txtt_doc.Text, '3
                                                          FormMantGuiaAlmacen.cmb_serdoc.Text,'4
                                                          FormMantGuiaAlmacen.txtnumero.Text, '5
                                                          FormMantGuiaAlmacen.txtproveedor.Text,'6 
                                                          npdcantidad.Value, '7
                                                          cmbart.SelectedValue,'8
                                                          sValor, '9
                                                          Nothing, '10
                                                          "",'11
                                                          "", "", "", "+", txtobservacion.Text, FormMantGuiaAlmacen.txtt_movinv.Text, "", "", "", "", "", "",
                                                          "", "", "", FormMantGuiaAlmacen.dtpfecha.Text, gsUser, ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)),
                                                          FormMantGuiaAlmacen.txtt_pago.Text, FormMantGuiaAlmacen.txtfor_ent.Text,
                                                          RTrim(DateTime.Now), "20100279348", FormMantGuiaAlmacen.txtc_costo.Text, "", txtlote.Text, FormMantGuiaAlmacen.txtdni.Text, "", "", "", "", "", "",
                                                          FormMantGuiaAlmacen.cmbestado.Text)
                    Dispose()



                End If
            Else
                sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                FormMantGuiaAlmacen.dgvt_doc.Rows(FormMantGuiaAlmacen.dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value = npdcantidad.Value '7
                FormMantGuiaAlmacen.dgvt_doc.Rows(FormMantGuiaAlmacen.dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value = cmbart.SelectedValue
                FormMantGuiaAlmacen.dgvt_doc.Rows(FormMantGuiaAlmacen.dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value = sValor
                FormMantGuiaAlmacen.dgvt_doc.Rows(FormMantGuiaAlmacen.dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value = txtobservacion.Text '16
                FormMantGuiaAlmacen.dgvt_doc.Rows(FormMantGuiaAlmacen.dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value = npdcantidad.Value
                FormMantGuiaAlmacen.dgvt_doc.Rows(FormMantGuiaAlmacen.dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value = ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8)) '29                
                Dispose()
            End If
        Else
            MsgBox("Favor Ingrese la cantidad a declarar")
        End If

    End Sub

    Private Sub cmblinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblinea.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        'bSegundo = True
        If cmblinea.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.SelectDescripcion1(cmblinea.SelectedValue)
            GetCmb("lin_codigo", "lin_descri", dt, cmbsublinea)
        End If
        bSegundo = False
    End Sub

    Private Sub cmbsublinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsublinea.SelectedIndexChanged
        If bSegundo Then
            Exit Sub
        End If

        If cmbsublinea.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            If dt.Rows.Count > 0 Then
                GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
                bTercero = False
                'If sBusAlm = "2" Then
                '    cmbart.SelectedValue = gArt
                '    gArt = Nothing
                'End If

            Else
                MsgBox("La Sublinea no tiene articulos")
                'For i = 0 To cmbart.Items.Count - 1
                cmbart.DataSource = Nothing
                'Next
                'cmbart.Refresh()
            End If

        End If
        cmbuni.SelectedIndex = -1

    End Sub

    Private Sub FormMantDetGuiaAlmacen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CleanVar()
        Dispose()
    End Sub

    Private Sub cmbart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbart.SelectedIndexChanged
        If bTercero Then
            Exit Sub
        End If
        'OJO VER
        If cmbart.SelectedIndex <> -1 Then
            cmbuni.SelectedValue = ARTICULOBL.SelectUniMed(Mid(cmbart.Text, 1, 8))
            txtcodart.Text = cmbart.SelectedValue
        End If
        bTercero = False
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "2"
        gsCode13 = Label9.Text
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            cmblinea.SelectedValue = gLinea
            cmbsublinea.SelectedValue = gSubLinea
            cmbart.SelectedValue = gArt
            txtcodart.Text = gArt
            txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If

    End Sub



    Private Sub txtcodart_Validated(sender As Object, e As EventArgs) Handles txtcodart.Validated
        If bPrimero Then Exit Sub
        'buscar articulo
        If txtcodart.TextLength = "8" Then
            txtcodart.Text = txtcodart.Text
        ElseIf txtcodart.TextLength = "7" Then
            txtcodart.Text = "0" + txtcodart.Text
        End If
        cmblinea.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"
        If cmblinea.SelectedValue = "" Then
            Exit Sub
        End If
        cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
        If cmbsublinea.SelectedValue = "" Then
            Exit Sub
        End If
        cmbart.SelectedValue = txtcodart.Text
        txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
    End Sub

    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                cmblinea.SelectedValue = gLinea
                cmbsublinea.SelectedValue = gSubLinea
                cmbart.SelectedValue = gArt
                txtcodart.Text = gArt
                txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If

        If e.KeyValue = Keys.F10 Then
            sBusAlm = "5"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                cmblinea.SelectedValue = gLinea
                cmbsublinea.SelectedValue = gSubLinea
                cmbart.SelectedValue = gArt
                txtcodart.Text = gArt
                txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
    End Sub


End Class