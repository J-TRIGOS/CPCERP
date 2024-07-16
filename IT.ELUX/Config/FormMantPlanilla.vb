Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantPlanilla
    Private ELPERIODOBL As New ELPERIODOBL
    Private Sub FormMantPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Generacion de Planilla"
        Me.dtpfec_ini.Enabled = False
        If gsUser <> "JFLORES" Or gsUser <> "JMONTES" Then
            btnctsessalud.Visible = True
        End If
    End Sub

    Private Sub FormMantPlanilla_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btngrati_Click(sender As Object, e As EventArgs) Handles btngrati.Click
        Cursor.Current = Cursors.WaitCursor
        If txt_periodo.Text = "" Then
            MsgBox("No ah Seleccionado el periodo de generacion")
        Else
            If txt_periodo.Text > "155" Then
                Dim CALCPLABE As New CALCPLABE
                CALCPLABE.PRDO = txt_periodo.Text
                CALCPLABE.T_PAGO = Mid(cmbt_pago.Text, 1, 3)
                gsError2 = ELPERIODOBL.SaveRowQuinta(CALCPLABE, "DELQuinta")

            End If
            Dim S As String = ELPERIODOBL.SelEstPrdo(txt_periodo.Text)
            If S <> "C" Then
                If cmbt_pago.Text = "MENSUAL" Then
                    gsError = ELPERIODOBL.SaveRowAllMes("UPDMES", txt_periodo.Text)
                    If gsError = "OK" Then
                        MsgBox("Planilla Mensual Generada", MsgBoxStyle.Information)
                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Generar Planilla", MsgBoxStyle.Critical)
                    End If
                ElseIf cmbt_pago.Text = "GRATIFICACION" Then
                    gsError = ELPERIODOBL.SaveRowAllMes("UPDGRA", txt_periodo.Text)
                    If gsError = "OK" Then
                        MsgBox("Planilla Generada de Gratificacion", MsgBoxStyle.Information)
                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Generar Planilla", MsgBoxStyle.Critical)
                    End If
                ElseIf cmbt_pago.Text = "GRATIFICACION 2" Then
                    gsError = ELPERIODOBL.SaveRowAllMes("UPDGRA2", txt_periodo.Text)
                    If gsError = "OK" Then
                        MsgBox("Planilla Generada de Gratificacion", MsgBoxStyle.Information)
                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Generar Planilla", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("No ah Seleccionado ningun tipo de Pago")
                End If
            Else
                MsgBox("Periodo Cerrado")
            End If
        End If

    End Sub

    Private Sub txt_periodo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_periodo.KeyDown
        If chkperiodo.Checked = True Then
            If e.KeyValue = Keys.F9 Then
                sBusAlm = "86"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gLinea <> Nothing And gSubLinea <> Nothing Then
                    txt_periodo.Text = gLinea
                    dtpfec_ini.Value = gArt
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
        Else
            If e.KeyValue = Keys.F9 Then
                sBusAlm = "85"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If gLinea <> Nothing And gSubLinea <> Nothing Then
                    txt_periodo.Text = gLinea
                    dtpfec_ini.Value = gArt
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
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnquinta_Click(sender As Object, e As EventArgs) Handles btnquinta.Click
        If txt_periodo.Text > "155" Then
            Cursor.Current = Cursors.WaitCursor
            Dim dt As New DataTable
            Dim UIT_QUinta As Double = 0
            Dim monto_acumulado As Double = 0
            Dim monto_calculado As Double = 0
            Dim monto_pago As Double = 0
            Dim monto_5_20 As Double = 0
            Dim monto_35_45 As Double = 0
            Dim monto_45 As Double = 0
            Dim monto_20_35 As Double = 0
            Dim monto_5 As Double = 0
            Dim monto5 As Double = 0
            Dim monto520 As Double = 0
            Dim monto2035 As Double = 0
            Dim monto3545 As Double = 0
            Dim monto45 As Double = 0
            Dim montocalcquinta As Double = 0
            'Dim monto_quinta As Double = 0
            Dim CALCPLABE As New CALCPLABE
            If cmbt_pago.SelectedIndex > -1 Then
                dt = ELPERIODOBL.SelectQuinta(txt_periodo.Text, "020", Mid(cmbt_pago.Text, 1, 3))
                dgvt_doc.DataSource = dt
            End If
            CALCPLABE.PRDO = txt_periodo.Text
            CALCPLABE.T_PAGO = Mid(cmbt_pago.Text, 1, 3)
            gsError2 = ELPERIODOBL.SaveRowQuinta(CALCPLABE, "DELQuinta")
            If dgvt_doc.Rows.Count > 0 Then
                For i = 0 To dgvt_doc.Rows.Count - 1
                    If dgvt_doc.Rows(i).Cells("PER_COD").Value = "45835684" Then
                        UIT_QUinta = 0
                        monto_acumulado = 0
                        monto_calculado = 0
                        monto_5 = 0
                        monto_5_20 = 0
                        monto_20_35 = 0
                        monto_35_45 = 0
                        monto_45 = 0
                        monto5 = 0
                        monto520 = 0
                        monto2035 = 0
                        monto3545 = 0
                        monto45 = 0
                        monto_pago = 0
                        montocalcquinta = 0
                        CALCPLABE.PER_COD = dgvt_doc.Rows(i).Cells("PER_COD").Value
                        UIT_QUinta = ELPERIODOBL.SelUIT() * 7
                        'If dgvt_doc.Rows(i).Cells("MES_PAGA").Value = "13" Then
                        '    monto_acumulado = (dgvt_doc.Rows(i).Cells("MONTOCALCULADO").Value) + dgvt_doc.Rows(i).Cells("INGRESOTOTAL").Value
                        'ElseIf dgvt_doc.Rows(i).Cells("MES_PAGA").Value = "14" Then
                        '    monto_acumulado = 0 + dgvt_doc.Rows(i).Cells("INGRESOTOTAL").Value
                        'Else
                        '    If cmbt_pago.Text = "GRATIFICACION" Then
                        '        monto_acumulado = (((dgvt_doc.Rows(i).Cells("PROMMONTO").Value) / 3) * dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value) + dgvt_doc.Rows(i).Cells("INGRESOTOTAL").Value
                        '    Else
                        '        If dgvt_doc.Rows(i).Cells("MES_PAGO").Value = "01" Or dgvt_doc.Rows(i).Cells("MES_PAGO").Value = "02" Or
                        '            dgvt_doc.Rows(i).Cells("MES_PAGO").Value = "03" Then
                        '            monto_acumulado = (dgvt_doc.Rows(i).Cells("MONTOCALCULADO").Value * dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value) + dgvt_doc.Rows(i).Cells("INGRESOTOTAL").Value
                        '        Else
                        '            monto_acumulado = ((dgvt_doc.Rows(i).Cells("PROMMONTO").Value / 3) * dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value) + dgvt_doc.Rows(i).Cells("INGRESOTOTAL").Value
                        '        End If
                        '    End If
                        'End If
                        'aca
                        If dgvt_doc.Rows(i).Cells("MES_PAGA").Value = "13" Then
                            monto_acumulado = 17000 + 226440
                        ElseIf dgvt_doc.Rows(i).Cells("MES_PAGA").Value = "14" Then
                            monto_acumulado = 0 + dgvt_doc.Rows(i).Cells("INGRESOTOTAL").Value
                        Else
                            If cmbt_pago.Text = "GRATIFICACION" Then
                                monto_acumulado = (((dgvt_doc.Rows(i).Cells("PROMMONTO").Value) / 3) * dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value) + dgvt_doc.Rows(i).Cells("INGRESOTOTAL").Value
                            Else
                                If dgvt_doc.Rows(i).Cells("MES_PAGO").Value = "01" Or dgvt_doc.Rows(i).Cells("MES_PAGO").Value = "02" Or
                                    dgvt_doc.Rows(i).Cells("MES_PAGO").Value = "03" Then
                                    monto_acumulado = (dgvt_doc.Rows(i).Cells("MONTOCALCULADO").Value * dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value) + dgvt_doc.Rows(i).Cells("INGRESOTOTAL").Value
                                Else
                                    monto_acumulado = ((dgvt_doc.Rows(i).Cells("PROMMONTO").Value / 3) * dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value) + dgvt_doc.Rows(i).Cells("INGRESOTOTAL").Value
                                End If
                            End If
                        End If
                        '---
                        ' montocalcquinta = monto_calculado - UIT_QUinta
                        If monto_acumulado > UIT_QUinta Then
                            monto_calculado = monto_acumulado - UIT_QUinta '- dgvt_doc.Rows(i).Cells("SUMCPTO").Value
                            If monto_calculado <= 5 * ELPERIODOBL.SelUIT() Then
                                monto_5 = (((monto_calculado * 8) / 100) - dgvt_doc.Rows(i).Cells("SUMCPTO").Value) / dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value
                                monto_pago = monto_5
                            ElseIf monto_calculado <= 20 * ELPERIODOBL.SelUIT() Then
                                monto_5 = 21500 '1720 '(21500*8)/100
                                'monto_5_20 = 86000
                                monto5 = (monto_5 * 8) / 100
                                monto_5_20 = ((monto_calculado - monto_5 * 14) / 100) - dgvt_doc.Rows(i).Cells("SUMCPTO").Value '/ dgvt_doc.Rows(i).Cells("MES").Value
                                'monto_pago = (monto_5_20 + monto5) / dgvt_doc.Rows(i).Cells("MES").Value
                                monto_pago = (monto_5_20 + monto5) / dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value
                            ElseIf monto_calculado <= 35 * ELPERIODOBL.SelUIT() Then
                                monto_5 = 21500 '1720 '(21500*8)/100
                                monto_5_20 = 86000
                                monto5 = (monto_5 * 8) / 100
                                monto520 = ((monto_5_20 - monto_5) * 14) / 100
                                monto_20_35 = (((monto_calculado - monto5 - monto520 * 17) / 100) - dgvt_doc.Rows(i).Cells("SUMCPTO").Value) '/ dgvt_doc.Rows(i).Cells("MES").Value
                                'monto_pago = (monto_20_35 + monto5 + monto520) / dgvt_doc.Rows(i).Cells("MES").Value
                                monto_pago = (monto_20_35 + monto5 + monto520) / dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value
                            ElseIf monto_calculado <= 45 * ELPERIODOBL.SelUIT() Then
                                monto_5 = 21500 '1720 '(21500*8)/100
                                monto_5_20 = 86000
                                monto_20_35 = 150500
                                monto5 = (monto_5 * 8) / 100
                                monto520 = ((monto_5_20 - monto_5) * 14) / 100
                                monto2035 = ((monto_20_35 - monto_5_20 - monto_5) * 17) / 100
                                'monto_20_35 = (((monto5 - monto520 - monto2035) * 20) / 100) 
                                monto_35_45 = (((monto_calculado - monto5 - monto520 - monto2035 * 20) / 100) - dgvt_doc.Rows(i).Cells("SUMCPTO").Value) '/ dgvt_doc.Rows(i).Cells("MES").Value
                                'monto_pago = (monto_20_35 + monto5 + monto520) / dgvt_doc.Rows(i).Cells("MES").Value
                                monto_pago = (monto_35_45) / dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value
                            ElseIf monto_calculado > 45 * ELPERIODOBL.SelUIT() Then
                                monto_5 = 21500 '1720 '(21500*8)/100
                                monto_5_20 = 86000
                                monto_20_35 = 150500
                                monto_35_45 = 193500
                                monto5 = (monto_5 * 8) / 100
                                monto520 = ((monto_5_20 - monto_5) * 14) / 100
                                monto2035 = ((monto_20_35 - (monto_5_20 + monto_5 - monto_5)) * 17) / 100
                                monto3545 = (((monto_35_45 - (monto_20_35 + monto_5_20 - monto_5_20 + monto_5 - monto_5)) * 20) / 100) '/ dgvt_doc.Rows(i).Cells("MES").Value
                                'monto45 = monto_calculado - monto5 - monto520 - monto2035 - monto3545
                                monto45 = monto_calculado - (monto_35_45)
                                monto_45 = ((monto45) * 30) / 100
                                'monto_pago = (monto_20_35 + monto5 + monto520) / dgvt_doc.Rows(i).Cells("MES").Value
                                'aca
                                'monto_pago = ((monto_45 + monto5 + monto520 + monto2035 + monto3545) - dgvt_doc.Rows(i).Cells("SUMCPTO").Value) / dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value
                                monto_pago = ((monto_45 + monto5 + monto520 + monto2035 + monto3545) - 27797) / dgvt_doc.Rows(i).Cells("FALTA_PAGAR").Value
                            End If
                            If monto_pago > 0 Then
                                CALCPLABE.MONTO = Math.Round(monto_pago, 0)
                                CALCPLABE.CPTO = "016"
                                CALCPLABE.PER_COD = dgvt_doc.Rows(i).Cells("PER_COD").Value
                                gsError = ELPERIODOBL.SaveRowQuinta(CALCPLABE, "UPDQuinta")
                                If gsError = "OK" Then
                                    'MsgBox("Planilla Mensual Generada", MsgBoxStyle.Information)
                                Else
                                    FormMain.LblError.Text = gsError
                                    MsgBox("Error al Generar Planilla", MsgBoxStyle.Critical)
                                End If
                            End If
                        End If
                    End If
                Next
                If gsError = "OK" Then
                    MsgBox("Quinta Generada", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("No hay datos para Generar Quinta")
            End If
        End If
    End Sub

    Private Sub btnctsessalud_Click(sender As Object, e As EventArgs) Handles btnctsessalud.Click

    End Sub
End Class