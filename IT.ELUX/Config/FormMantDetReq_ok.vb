Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantDetReq_ok
    Private ARTICULOBL As New ARTICULOBL
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As Boolean = True
    Public flag As String
    Public bFecha As Date
    Private Sub CleanVar()
        cmbart.SelectedIndex = -1
        cmblinea.SelectedIndex = -1
        cmbsublinea.SelectedIndex = -1
        npdcantidad.Value = "0.000"
        txtlote.Text = ""
        txtobservacion.Text = ""
        cmbuni.SelectedIndex = -1
        txtactivo.Text = ""
        cmbactivo.SelectedIndex = -1
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

    Private Sub FormMantDetReq_ok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        Me.Text = "Detalle Requerimiento"
        Dim dt As DataTable = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmblinea)
        dt = ARTICULOBL.SelectUndMed()
        GetCmb("cod", "nom", dt, cmbuni)
        If bFecha >= Format(CDate("21/12/2020"), "dd/MM/yyyy") Then
            txtarticulo.Visible = True
            cmbactivo.Visible = False
        Else
            cmbactivo.Visible = True
            dt = ARTICULOBL.SelectAct()
            GetCmb("COD", "NOM_ACT", dt, cmbactivo)
        End If
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
            If bFecha.ToString("dd-MM-yyyy") >= "21-12-2020" Then
                txtarticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
            Else
                cmbactivo.SelectedValue = txtactivo.Text
            End If
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
        If bFecha >= Format(CDate("21/12/2020"), "dd/MM/yyyy") And txtarticulo.Visible = True Then
            If txtarticulo.Text = Nothing Then
                If MessageBox.Show("Activo no ingresado Desea continuar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                    Exit Sub
                End If
            End If
            If npdcantidad.Value > 0 Then
                Dim sValor As String
                Dim i As Integer
                Dim icontador As Integer
                'AGREGAR UN REQUERIMIENTO SIN DOCUMENTAR
                If gContador = 1 Then
                    gContador = 0
                    sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                    If FormReque_Ok.dgvt_doc.Rows.Count > 0 Then
                        For i = 0 To FormReque_Ok.dgvt_doc.Rows.Count - 1
                            If FormReque_Ok.dgvt_doc.Rows(i).Cells(8).Value = cmbart.SelectedValue Then
                                icontador = icontador + 1
                                MsgBox("El Articulo ya se encuentra listado")
                                Exit Sub
                            End If
                        Next
                    End If
                    If icontador > 0 Then
                        FormReque_Ok.dgvt_doc.Rows.Add(FormReque_Ok.txtt_doc.Text, '0
                                                          FormReque_Ok.cmb_serdoc.Text,'1
                                                          FormReque_Ok.txtnumero.Text, '2
                                                          FormReque_Ok.txtt_doc.Text, '3
                                                          FormReque_Ok.cmb_serdoc.Text,'4
                                                          FormReque_Ok.txtnumero.Text & "-" & icontador, '5
                                                          FormReque_Ok.txtproveedor.Text,'6 
                                                          npdcantidad.Value, '7
                                                          cmbart.SelectedValue,'8
                                                          sValor, '9
                                                          Nothing, '10
                                                           "",'11
                                                          "", "", "", "+", txtobservacion.Text, FormReque_Ok.txtt_movinv.Text, "", "", "", "", "", "",
                                                          "", "", "", FormReque_Ok.dtpfecha.Text, gsUser, cmbuni.SelectedValue, FormReque_Ok.txtt_pago.Text, FormReque_Ok.txtfor_ent.Text,
                                                          RTrim(DateTime.Now), "20100279348", FormReque_Ok.txtc_costo.Text, "", txtlote.Text, FormReque_Ok.txtdni.Text, "", "", "", "", "", "",
                                                          FormReque_Ok.cmbestado.Text, "", npdpeso.Value, txtactivo.Text)
                        Dispose()
                    Else
                        FormReque_Ok.dgvt_doc.Rows.Add(FormReque_Ok.txtt_doc.Text, '0
                                                              FormReque_Ok.cmb_serdoc.Text,'1
                                                              FormReque_Ok.txtnumero.Text, '2
                                                              FormReque_Ok.txtt_doc.Text, '3
                                                              FormReque_Ok.cmb_serdoc.Text,'4
                                                              FormReque_Ok.txtnumero.Text, '5
                                                              FormReque_Ok.txtproveedor.Text,'6 
                                                              npdcantidad.Value, '7
                                                              cmbart.SelectedValue,'8
                                                              sValor, '9
                                                              Nothing, '10
                                                              "",'11
                                                              "", "", "", "+", txtobservacion.Text, FormReque_Ok.txtt_movinv.Text, "", "", "", "", "", "",
                                                              "", "", "", FormReque_Ok.dtpfecha.Text, gsUser, cmbuni.SelectedValue, FormReque_Ok.txtt_pago.Text, FormReque_Ok.txtfor_ent.Text,
                                                              RTrim(DateTime.Now), "20100279348", FormReque_Ok.txtc_costo.Text, "", txtlote.Text, FormReque_Ok.txtdni.Text, "", "", "", "", "", "",
                                                              FormReque_Ok.cmbestado.Text, "", npdpeso.Value, txtactivo.Text)
                        Dispose()



                    End If
                ElseIf gContador = 0 Then
                    sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                    FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value = sValor
                    FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells(7).Value = npdcantidad.Value '7
                    FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells(8).Value = cmbart.SelectedValue
                    FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells(16).Value = txtobservacion.Text '16
                    FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells(29).Value = cmbuni.SelectedValue '29
                    FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells(36).Value = txtlote.Text
                    FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells("ART_VENTA").Value = txtactivo.Text
                    FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells("PESO").Value = npdpeso.Value

                    Dispose()
                End If
            Else
                MsgBox("Falta la cantidad a declarar")
            End If
        Else

            If cmbactivo.SelectedIndex > -1 Then
                If npdcantidad.Value > 0 Then
                    Dim sValor As String
                    Dim i As Integer
                    Dim icontador As Integer
                    'AGREGAR UN REQUERIMIENTO SIN DOCUMENTAR
                    If gContador = 1 Then
                        gContador = 0
                        sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                        If FormReque_Ok.dgvt_doc.Rows.Count > 0 Then
                            For i = 0 To FormReque_Ok.dgvt_doc.Rows.Count - 1
                                If FormReque_Ok.dgvt_doc.Rows(i).Cells(8).Value = cmbart.SelectedValue Then
                                    icontador = icontador + 1
                                    MsgBox("El Articulo ya se encuentra listado")
                                    Exit Sub
                                End If
                            Next
                        End If
                        If icontador > 0 Then
                            FormReque_Ok.dgvt_doc.Rows.Add(FormReque_Ok.txtt_doc.Text, '0
                                                          FormReque_Ok.cmb_serdoc.Text,'1
                                                          FormReque_Ok.txtnumero.Text, '2
                                                          FormReque_Ok.txtt_doc.Text, '3
                                                          FormReque_Ok.cmb_serdoc.Text,'4
                                                          FormReque_Ok.txtnumero.Text & "-" & icontador, '5
                                                          FormReque_Ok.txtproveedor.Text,'6 
                                                          npdcantidad.Value, '7
                                                          cmbart.SelectedValue,'8
                                                          sValor, '9
                                                          Nothing, '10
                                                          txtactivo.Text,'11
                                                          "", "", "", "+", txtobservacion.Text, FormReque_Ok.txtt_movinv.Text, "", "", "", "", "", "",
                                                          "", "", "", FormReque_Ok.dtpfecha.Text, gsUser, cmbuni.SelectedValue, FormReque_Ok.txtt_pago.Text, FormReque_Ok.txtfor_ent.Text,
                                                          RTrim(DateTime.Now), "20100279348", FormReque_Ok.txtc_costo.Text, "", txtlote.Text, FormReque_Ok.txtdni.Text, "", "", "", "", "", "",
                                                          FormReque_Ok.cmbestado.Text, "", npdpeso.Value, "")
                            Dispose()
                        Else
                            FormReque_Ok.dgvt_doc.Rows.Add(FormReque_Ok.txtt_doc.Text, '0
                                                              FormReque_Ok.cmb_serdoc.Text,'1
                                                              FormReque_Ok.txtnumero.Text, '2
                                                              FormReque_Ok.txtt_doc.Text, '3
                                                              FormReque_Ok.cmb_serdoc.Text,'4
                                                              FormReque_Ok.txtnumero.Text, '5
                                                              FormReque_Ok.txtproveedor.Text,'6 
                                                              npdcantidad.Value, '7
                                                              cmbart.SelectedValue,'8
                                                              sValor, '9
                                                              Nothing, '10
                                                              txtactivo.Text,'11
                                                              "", "", "", "+", txtobservacion.Text, FormReque_Ok.txtt_movinv.Text, "", "", "", "", "", "",
                                                              "", "", "", FormReque_Ok.dtpfecha.Text, gsUser, cmbuni.SelectedValue, FormReque_Ok.txtt_pago.Text, FormReque_Ok.txtfor_ent.Text,
                                                              RTrim(DateTime.Now), "20100279348", FormReque_Ok.txtc_costo.Text, "", txtlote.Text, FormReque_Ok.txtdni.Text, "", "", "", "", "", "",
                                                              FormReque_Ok.cmbestado.Text, "", npdpeso.Value, "")
                            Dispose()



                        End If
                    ElseIf gContador = 0 Then
                        sValor = ARTICULOBL.SelectArt2(cmbart.SelectedValue)
                        FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value = sValor
                        FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells(7).Value = npdcantidad.Value '7
                        FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells(8).Value = cmbart.SelectedValue
                        FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells(16).Value = txtobservacion.Text '16
                        FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells(29).Value = cmbuni.SelectedValue '29
                        FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells(36).Value = txtlote.Text
                        FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells("ACT_COD").Value = txtactivo.Text
                        FormReque_Ok.dgvt_doc.Rows(FormReque_Ok.dgvt_doc.CurrentRow.Index).Cells("PESO").Value = npdpeso.Value

                        Dispose()
                    End If
                Else
                    MsgBox("Falta la cantidad a declarar")
                End If
            Else
                MsgBox("Falta codigo de activo")
            End If
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
        End If
        bTercero = False
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "6"
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
        Dim dt As DataTable
        'cmblinea.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

        'If cmblinea.SelectedValue = "" Then
        '    Exit Sub
        'End If

        'cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)

        'If cmbsublinea.SelectedValue = "" Then
        '    Exit Sub
        'End If

        'cmbart.SelectedValue = txtcodart.Text
        'gsCode = gsCode

        cmblinea.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

        If cmblinea.SelectedValue = "" Then
            Exit Sub
        End If
        Dim art As String = txtcodart.Text
        If flag = "N" Then
            cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
            txtcodart.Text = art
        Else
            cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
        End If

        'cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
        'txtcodart.Text = art
        If cmbsublinea.SelectedValue = "" Then
            Exit Sub
        End If
        If flag = "M" Then
            cmbart.DataSource = Nothing
            dt = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
        Else
        End If
        cmbart.SelectedValue = txtcodart.Text
        'If cmbart.SelectedIndex <> -1 Then
        Try
            cmbuni.SelectedValue = ARTICULOBL.SelectUniMed(Mid(cmbart.Text, 1, 8))
        Catch ex As Exception
            MsgBox("El articulo no cuenta con unidad")
        End Try

        'End If
        If cmbart.SelectedValue <> txtcodart.Text Then
            MsgBox("El articulo no existe", MsgBoxStyle.Exclamation)
            txtcodart.Text = ""
            txtcodart.Select()
            cmbuni.SelectedIndex = -1
            'txtstock.Text = ARTICULOBL.SetStock(txtcodart.Text)
        End If
    End Sub

    Private Sub btnbusact_Click(sender As Object, e As EventArgs) Handles btnbusact.Click
        If bFecha >= Format(CDate("21/12/2020"), "dd/MM/yyyy") Then
            If txtarticulo.Visible = True Then
                sBusAlm = "122"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gArt <> Nothing And gSubLinea <> Nothing Then
                    txtactivo.Text = gArt
                    txtarticulo.Text = gSubLinea
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
            End If
        Else
            sBusAlm = "9"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            'MsgBox(IsDBNull(gLinea.Length))
            If gCodAct <> Nothing Then
                cmbactivo.SelectedValue = gCodAct
                txtactivo.Text = gCodAct
                gCodAct = Nothing
            Else
                gCodAct = Nothing
            End If
        End If
    End Sub


    Private Sub cmbactivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbactivo.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbactivo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtactivo.Text = cmbactivo.SelectedValue
    End Sub

    Private Sub txtactivo_LostFocus(sender As Object, e As EventArgs) Handles txtactivo.LostFocus
        If txtactivo.Text = "" Then
            txtarticulo.Text = ""
            Exit Sub
        End If
        If bFecha.ToString("dd-MM-yyyy") >= "21-12-2020" Then
            txtarticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
            If txtarticulo.Text = Nothing Then
                MsgBox("Activo no existe", MsgBoxStyle.Exclamation)
                txtactivo.Text = ""
            End If
        Else
            If txtactivo.Text = "" Then
                cmbactivo.SelectedValue = ""
                Exit Sub
            End If
            cmbactivo.SelectedValue = txtactivo.Text
            If cmbactivo.SelectedValue Is Nothing Then
                MsgBox("Activo no existe", MsgBoxStyle.Exclamation)
                txtactivo.Text = ""
                txtactivo.Select()
            End If
        End If
    End Sub
    Private Sub txtactivo_TextChanged(sender As Object, e As EventArgs) Handles txtactivo.TextChanged
        If txtactivo.Text = "" Then
            txtarticulo.Text = ""
        End If
    End Sub


End Class