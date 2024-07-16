Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormDuplicarDetDocumento
    Private DET_DOCUMENTOBL As New DET_DOCUMENTOBL
    Private PROVISIONESBL As New PROVISIONESBL
    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Select Case sFunc
                Case "exit"
                    Cerrardup = 0
                    Dispose()
                    Exit Sub
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormDuplicarDetDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gpCaption = "Personal"
        Me.Text = "Duplica Documento"
    End Sub

    Private Sub FormDuplicarDetDocumento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dispose()
    End Sub

    Private Sub btnduplicar_Click(sender As Object, e As EventArgs) Handles btnduplicar.Click
        If txtruc.Text = "" Then
            MsgBox("Elija el ruc que desea duplicar")
            Exit Sub
        End If
        If cmbtipo.SelectedIndex = -1 Then
            MsgBox("Elija el servicio que desea duplicar")
            Exit Sub
        End If
        If txtserie.Text = "" Then
            MsgBox("Debe Ingresar la Serie del Documento")
            Exit Sub
        End If
        If txtnro.Text = "" Then
            MsgBox("Debe Ingresar el Numero del Documento")
            Exit Sub
        End If
        If txtnro.Text = Label10.Text And txtserie.Text = Label11.Text Then
            MsgBox("Debe Ingresar otro numero de documento o serie")
            Exit Sub
        End If
        If MessageBox.Show("Esta Seguro de Duplicar los documentos",
                   "Duplica Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE

        DET_DOCUMENTOBE.NRO_DOC_REF = txtnro.Text
        DET_DOCUMENTOBE.SER_DOC_REF = txtserie.Text
        DET_DOCUMENTOBE.FEC_GENE = txt_fec_emi.Text
        DET_DOCUMENTOBE.FEC_ENT = txtfecprov.Text
        'If rdbagua.Checked Then
        '    DET_DOCUMENTOBE.OTROS = "2"
        'Else
        '    DET_DOCUMENTOBE.OTROS = "1"
        'End If
        Dim dt As DataTable
        Dim mesfecha As String
        Dim mesdia As String
        If Mid(txtfecprov.Text, 4, 2) = "1" Then
            mesfecha = "0" & Mid(txtfecprov.Text, 4, 2)
        Else
            mesfecha = Mid(txtfecprov.Text, 4, 2)
        End If
        If Mid(txtfecprov.Text, 1, 2) = "1" Then
            mesdia = "0" & Mid(txtfecprov.Text, 1, 2)
        Else
            mesdia = Mid(txtfecprov.Text, 1, 2)
        End If
        dt = PROVISIONESBL.getT_CAMB(Mid(txtfecprov.Text, 7, 4) & "/" & mesfecha & "/" & mesdia)
        For Each Registro In dt.Rows
            DET_DOCUMENTOBE.T_CAMB = IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA"))
            If IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA")) = 0 Or IIf(IsDBNull(Registro("VENTA")), 0, Registro("VENTA")) = Nothing Then
                MsgBox("La fecha no tiene tipo de cambio")
                Exit Sub
            End If
        Next

        'If rdbluz.Checked Then
        '    DET_DOCUMENTOBE.TIPO_UNIDAD = "1"
        '    DET_DOCUMENTOBE.PROCESO = "20331898008"
        'Else
        '    DET_DOCUMENTOBE.TIPO_UNIDAD = "2"
        '    DET_DOCUMENTOBE.PROCESO = "20100152356"
        'End If
        If cmbtipo.Text = "AGUA" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "2"
            DET_DOCUMENTOBE.T_DOC_REF = "14"
        ElseIf cmbtipo.Text = "LUZ" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "1"
            DET_DOCUMENTOBE.T_DOC_REF = "14"
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "3"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 5" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "7"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "GAS" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "4"
            DET_DOCUMENTOBE.T_DOC_REF = "36"
        ElseIf cmbtipo.Text = "TELEFONO" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "5"
            DET_DOCUMENTOBE.T_DOC_REF = "14"
        ElseIf cmbtipo.Text = "INTERNET TORRES" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "6"
            DET_DOCUMENTOBE.T_DOC_REF = "14"
        ElseIf cmbtipo.Text = "PACIFICO SEGUROS EMPLEADOS" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "9"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "PACIFICO SEGUROS OBREROS" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "8"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 50" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "10"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 100" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "11"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "CELULARES SIN IGV" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "12"
            DET_DOCUMENTOBE.T_DOC_REF = "14"
        ElseIf cmbtipo.Text = "LUZ STATKRAFT SOLES" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "13"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "LUZ STATKRAFT DOLARES" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "14"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "RIMAC OBREROS" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "15"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "RIMAC EMPLEADOS" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "16"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "GASTOS REPRESENTACION" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "17"
            DET_DOCUMENTOBE.T_DOC_REF = "03"
        ElseIf cmbtipo.Text = "CELULARES IGV" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "18"
            DET_DOCUMENTOBE.T_DOC_REF = "14"
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40 - 2" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "19"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 10.40" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "20"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "CREATECH INGENIERIA Y PROYECTO S.A.C." Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "21"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "INTERNET ELOY" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "22"
            DET_DOCUMENTOBE.T_DOC_REF = "14"
        ElseIf cmbtipo.Text = "ENTEL" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "23"
            DET_DOCUMENTOBE.T_DOC_REF = "14"
        ElseIf cmbtipo.Text = "MEDICO" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "24"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.80" Then
            DET_DOCUMENTOBE.TIPO_UNIDAD = "25"
            DET_DOCUMENTOBE.T_DOC_REF = "01"
        End If
        DET_DOCUMENTOBE.PROCESO = txtruc.Text
        DET_DOCUMENTOBE.PROVEEDOR = txtruc.Text
        gsError = DET_DOCUMENTOBL.SaveRow(DET_DOCUMENTOBE, ELMVLOGSBE, "MD", gsAño)
        If gsError = "OK" Then
            gsError2 = DET_DOCUMENTOBL.SaveRow1(DET_DOCUMENTOBE, dgvt_doc, "UL")
            If gsError2 = "OK" Then
                '    gsError3 = DET_DOCUMENTOBL.SaveRow1(DET_DOCUMENTOBE, dgvt_doc, "UT")
                '    If gsError3 = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                'If cmbtipo.Text <> "PEAJE LINEA AMARILLA 11.40" And cmbtipo.Text <> "PEAJE LINEA AMARILLA 5" And
                '    cmbtipo.Text <> "PACIFICO SEGUROS OBREROS" And cmbtipo.Text <> "PACIFICO SEGUROS EMPLEADOS" And
                '    cmbtipo.Text <> "GRIFO JIARA S.A.C 50" And cmbtipo.Text <> "GRIFO JIARA S.A.C 100" And
                '    cmbtipo.Text <> "TELEFONO" And cmbtipo.Text <> "CELULARES" Then
                '    btnduplicar.Enabled = False
                'Else
                Label10.Text = txtnro.Text
                    Label11.Text = txtserie.Text
                    txtnro.Text = ""
                    'txtserie.Text = "F"
                    txtserie.Select()
                If cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40" Then
                    Cerrardup = 1
                ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 5" Then
                    Cerrardup = 2
                ElseIf cmbtipo.Text = "PACIFICO SEGUROS EMPLEADOS" Then
                    Cerrardup = 3
                ElseIf cmbtipo.Text = "PACIFICO SEGUROS OBREROS" Then
                    Cerrardup = 4
                ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 50" Then
                    Cerrardup = 5
                ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 100" Then
                    Cerrardup = 6
                ElseIf cmbtipo.Text = "TELEFONO" Then
                    Cerrardup = 7
                ElseIf cmbtipo.Text = "CELULARES SIN IGV" Then
                    Cerrardup = 8
                    '--
                ElseIf cmbtipo.Text = "AGUA" Then
                    Cerrardup = 9
                ElseIf cmbtipo.Text = "LUZ" Then
                    Cerrardup = 10
                ElseIf cmbtipo.Text = "GAS" Then
                    Cerrardup = 11
                ElseIf cmbtipo.Text = "INTERNET TORRES" Then
                    Cerrardup = 12
                ElseIf cmbtipo.Text = "LUZ STATKRAFT SOLES" Then
                    Cerrardup = 13
                ElseIf cmbtipo.Text = "LUZ STATKRAFT DOLARES" Then
                    Cerrardup = 14
                ElseIf cmbtipo.Text = "RIMAC OBREROS" Then
                    Cerrardup = 15
                ElseIf cmbtipo.Text = "RIMAC EMPLEADOS" Then
                    Cerrardup = 16
                ElseIf cmbtipo.Text = "GASTOS REPRESENTACION" Then
                    Cerrardup = 17
                ElseIf cmbtipo.Text = "CELULARES IGV" Then
                    Cerrardup = 18
                ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40 - 2" Then
                    Cerrardup = 19
                ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 10.40" Then
                    Cerrardup = 20
                ElseIf cmbtipo.Text = "CREATECH INGENIERIA Y PROYECTO S.A.C." Then
                    Cerrardup = 21
                ElseIf cmbtipo.Text = "INTERNET ELOY" Then
                    Cerrardup = 22
                ElseIf cmbtipo.Text = "ENTEL" Then
                    Cerrardup = 23
                ElseIf cmbtipo.Text = "MEDICO" Then
                    Cerrardup = 24
                ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.80" Then
                    Cerrardup = 25
                End If

                Dispose()
                'End If
                '    Else
                '        FormMain.LblError.Text = gsError3
                '    End If
            Else
                FormMain.LblError.Text = gsError2
            End If
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub


    'Private Sub dtp_fec_emi_LostFocus(sender As Object, e As EventArgs) Handles dtp_fec_emi.LostFocus
    '    dtpfecprov.Value = dtp_fec_emi.Value
    'End Sub

    Private Sub npdestrrural_LostFocus(sender As Object, e As EventArgs) Handles npdestrrural.LostFocus
        If cmbtipo.Text = "LUZ STATKRAFT SOLES" Then 'LUZ STATKRAFT
            npdigv.Value = npdmonto_total.Value - ((npdmonto_total.Value - npdestrrural.Value) / 1.18) - npdestrrural.Value
            dgvt_doc.Rows.Clear()
        End If
        If cmbtipo.Text = "LUZ STATKRAFT SOLES" Then 'LUZ STATKRAFT
            dgvt_doc.Rows.Add("0737399", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round((0.0289855072463768 * npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737400", 13, 0.0628019323671498,
                              Math.Round(0.0628019323671498 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0628019323671498 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737401", 31, 0.14975845410628019,
                              Math.Round(0.14975845410628019 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.14975845410628019 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737402", 20, 0.0966183574879227,
                              Math.Round(0.0966183574879227 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0966183574879227 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737406", 14, 0.0676328502415459,
                              Math.Round(0.0676328502415459 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0676328502415459 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737403", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0096618357487923 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737404", 12, 0.0579710144927536,
                              Math.Round(0.0579710144927536 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0579710144927536 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737405", 15, 0.072463768115942,
                              Math.Round(0.072463768115942 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.072463768115942 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 12, 0.0579710144927536,
                              Math.Round(0.0579710144927536 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0579710144927536 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737408", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0289855072463768 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737409", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0289855072463768 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 14, 0.0676328502415459,
                              Math.Round(0.0676328502415459 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0676328502415459 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0193236714975845 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0747399", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0193236714975845 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0747400", 1, 0.0048309178743961,
                              Math.Round(0.0048309178743961 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0048309178743961 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0747401", 15, 0.072463768115942,
                              Math.Round(0.072463768115942 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.072463768115942 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0747405", 1, 0.0048309178743961,
                              Math.Round(0.0048309178743961 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0048309178743961 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 5, 0.0241545893719807,
                              Math.Round(0.0241545893719807 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0241545893719807 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0096618357487923 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737414", 7, 0.0338164251207729,
                              Math.Round(0.0338164251207729 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0338164251207729 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737415", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0144927536231884 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0096618357487923 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0096618357487923 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0193236714975845 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0144927536231884 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0144927536231884 * (npdestrrural.Value), 2)) 'INAFECTO
            'ElseIf cmbtipo.Text = "LUZ STATKRAFT DOLARES" Then 'LUZ STATKRAFT
            '    dgvt_doc.Rows.Add("0737399", 3, 1.53061224489796,
            '                      Math.Round(1.53061224489796 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737400", 3, 14.7959183673469,
            '                      Math.Round(14.7959183673469 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                     0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737401", 3, 7.14285714285714,
            '                      Math.Round(7.14285714285714 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737402", 3, 9.18367346938776,
            '                      Math.Round(9.18367346938776 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737406", 3, 11.2244897959184,
            '                      Math.Round(11.2244897959184 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737403", 3, 1.02040816326531,
            '                      Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737404", 3, 13.265306122449,
            '                      Math.Round(13.265306122449 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737405", 3, 2.55102040816327,
            '                      Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737407", 3, 5.61224489795918,
            '                      Math.Round(5.61224489795918 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737408", 3, 2.55102040816327,
            '                      Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737409", 3, 3.57142857142857,
            '                      Math.Round(3.57142857142857 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737410", 3, 9.69387755102041,
            '                      Math.Round(9.69387755102041 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737412", 3, 4.08163265306122,
            '                      Math.Round(4.08163265306122 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737413", 3, 1.53061224489796,
            '                      Math.Round(1.53061224489796 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737424", 3, 0.510204081632653,
            '                      Math.Round(0.510204081632653 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737414", 3, 2.55102040816327,
            '                      Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737415", 3, 1.02040816326531,
            '                      Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737416", 3, 1.02040816326531,
            '                      Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737417", 3, 1.53061224489796,
            '                      Math.Round(1.53061224489796 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737418", 3, 2.55102040816327,
            '                      Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737419", 3, 2.04081632653061,
            '                      Math.Round(2.04081632653061 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737420", 3, 1.02040816326531,
            '                      Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            'ElseIf txtruc.Text = "20100152356" Then 'AGUA
            '    dgvt_doc.Rows.Add("0737399", 6, 0.0289855072463768,
            '                      Math.Round(0.0289855072463768 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737400", 13, 0.0628019323671498,
            '                      Math.Round(0.0628019323671498 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737401", 31, 0.14975845410628019,
            '                      Math.Round(0.14975845410628019 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737402", 20, 0.0966183574879227,
            '                      Math.Round(0.0966183574879227 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737406", 14, 0.0676328502415459,
            '                      Math.Round(0.0676328502415459 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737403", 2, 0.0096618357487923,
            '                      Math.Round(0.0096618357487923 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737404", 12, 0.0579710144927536,
            '                      Math.Round(0.0579710144927536 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737405", 15, 0.072463768115942,
            '                      Math.Round(0.072463768115942 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737407", 12, 0.0579710144927536,
            '                      Math.Round(0.0579710144927536 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737408", 6, 0.0289855072463768,
            '                      Math.Round(0.0289855072463768 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737409", 6, 0.0289855072463768,
            '                      Math.Round(0.0289855072463768 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737410", 14, 0.0676328502415459,
            '                      Math.Round(0.0676328502415459 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737412", 4, 0.0193236714975845,
            '                      Math.Round(0.0193236714975845 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0747399", 4, 0.0193236714975845,
            '                      Math.Round(0.0193236714975845 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0747400", 1, 0.0048309178743961,
            '                      Math.Round(0.0048309178743961 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0747401", 15, 0.072463768115942,
            '                      Math.Round(0.072463768115942 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) '
            '    dgvt_doc.Rows.Add("0747405", 1, 0.0048309178743961,
            '                      Math.Round(0.0048309178743961 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737413", 5, 0.0241545893719807,
            '                      Math.Round(0.0241545893719807 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737424", 2, 0.0096618357487923,
            '                      Math.Round(0.0096618357487923 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737414", 7, 0.0338164251207729,
            '                      Math.Round(0.0338164251207729 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737415", 3, 0.0144927536231884,
            '                      Math.Round(0.0144927536231884 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737416", 2, 0.0096618357487923,
            '                      Math.Round(0.0096618357487923 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737417", 2, 0.0096618357487923,
            '                      Math.Round(0.0096618357487923 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737418", 4, 0.0193236714975845,
            '                      Math.Round(0.0193236714975845 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737419", 3, 0.0144927536231884,
            '                      Math.Round(0.0144927536231884 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      Math.Round((npdestrrural.Value / 100), 2)) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737420", 3, 0.0144927536231884,
            '                      Math.Round(0.0144927536231884 * ((npdmonto_total.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
        End If
    End Sub

    Private Sub npdigv_LostFocus(sender As Object, e As EventArgs) Handles npdigv.LostFocus
        dgvt_doc.Rows.Clear()
        If txtruc.Text = "20331898008" Then 'LUZ
            dgvt_doc.Rows.Add("0742665", 3, 1.53061224489796,
                             Math.Round((npdmonto_total.Value - npdigv.Value - npdestrrural.Value), 2), 'AFECTO
                             Math.Round(npdestrrural.Value, 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0742665", 3, 1.53061224489796,
            '                  Math.Round(1.53061224489796 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round((1.53061224489796 * npdestrrural.Value) / 100, 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737400", 3, 14.7959183673469,
            '                  Math.Round(14.7959183673469 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(14.7959183673469 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737401", 3, 7.14285714285714,
            '                  Math.Round(7.14285714285714 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(7.14285714285714 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737402", 3, 9.18367346938776,
            '                  Math.Round(9.18367346938776 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(9.18367346938776 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737406", 3, 11.2244897959184,
            '                  Math.Round(11.2244897959184 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(11.2244897959184 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737403", 3, 1.02040816326531,
            '                  Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(1.02040816326531 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737404", 3, 13.265306122449,
            '                  Math.Round(13.265306122449 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(13.265306122449 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737405", 3, 2.55102040816327,
            '                  Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(2.55102040816327 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737407", 3, 5.61224489795918,
            '                  Math.Round(5.61224489795918 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(5.61224489795918 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737408", 3, 2.55102040816327,
            '                  Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(2.55102040816327 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737409", 3, 3.57142857142857,
            '                  Math.Round(3.57142857142857 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(3.57142857142857 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737410", 3, 9.69387755102041,
            '                  Math.Round(9.69387755102041 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(9.69387755102041 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737412", 3, 4.08163265306122,
            '                  Math.Round(4.08163265306122 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(4.08163265306122 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737413", 3, 1.53061224489796,
            '                  Math.Round(1.53061224489796 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(1.53061224489796 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737424", 3, 0.510204081632653,
            '                  Math.Round(0.510204081632653 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(0.510204081632653 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737414", 3, 2.55102040816327,
            '                  Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(2.55102040816327 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737415", 3, 1.02040816326531,
            '                  Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(1.02040816326531 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737416", 3, 1.02040816326531,
            '                  Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(1.02040816326531 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737417", 3, 1.53061224489796,
            '                  Math.Round(1.53061224489796 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(1.53061224489796 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737418", 3, 2.55102040816327,
            '                  Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(2.55102040816327 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737419", 3, 2.04081632653061,
            '                  Math.Round(2.04081632653061 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(2.04081632653061 * (npdestrrural.Value / 100), 2)) 'INAFECTO
            'dgvt_doc.Rows.Add("0737420", 3, 1.02040816326531,
            '                  Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                  Math.Round(1.02040816326531 * (npdestrrural.Value / 100), 2)) 'INAFECTO
        ElseIf cmbtipo.Text = "LUZ STATKRAFT SOLES" Then 'LUZ STATKRAFT
            dgvt_doc.Rows.Add("0737399", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round((0.0289855072463768 * npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737400", 13, 0.0628019323671498,
                              Math.Round(0.0628019323671498 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0628019323671498 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737401", 31, 0.14975845410628019,
                              Math.Round(0.14975845410628019 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.14975845410628019 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737402", 20, 0.0966183574879227,
                              Math.Round(0.0966183574879227 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0966183574879227 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737406", 14, 0.0676328502415459,
                              Math.Round(0.0676328502415459 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0676328502415459 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737403", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0096618357487923 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737404", 12, 0.0579710144927536,
                              Math.Round(0.0579710144927536 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0579710144927536 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737405", 15, 0.072463768115942,
                              Math.Round(0.072463768115942 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.072463768115942 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 12, 0.0579710144927536,
                              Math.Round(0.0579710144927536 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0579710144927536 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737408", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0289855072463768 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737409", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0289855072463768 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 14, 0.0676328502415459,
                              Math.Round(0.0676328502415459 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0676328502415459 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0193236714975845 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0747399", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0193236714975845 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0747400", 1, 0.0048309178743961,
                              Math.Round(0.0048309178743961 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0048309178743961 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0747401", 15, 0.072463768115942,
                              Math.Round(0.072463768115942 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.072463768115942 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0747405", 1, 0.0048309178743961,
                              Math.Round(0.0048309178743961 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0048309178743961 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 5, 0.0241545893719807,
                              Math.Round(0.0241545893719807 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0241545893719807 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0096618357487923 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737414", 7, 0.0338164251207729,
                              Math.Round(0.0338164251207729 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0338164251207729 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737415", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0144927536231884 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0096618357487923 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0096618357487923 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0193236714975845 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0144927536231884 * (npdestrrural.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                              Math.Round(0.0144927536231884 * (npdestrrural.Value), 2)) 'INAFECTO
            'ElseIf cmbtipo.Text = "LUZ STATKRAFT DOLARES" Then 'LUZ STATKRAFT
            '    dgvt_doc.Rows.Add("0737399", 3, 1.53061224489796,
            '                      Math.Round(1.53061224489796 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737400", 3, 14.7959183673469,
            '                      Math.Round(14.7959183673469 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                     0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737401", 3, 7.14285714285714,
            '                      Math.Round(7.14285714285714 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737402", 3, 9.18367346938776,
            '                      Math.Round(9.18367346938776 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737406", 3, 11.2244897959184,
            '                      Math.Round(11.2244897959184 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737403", 3, 1.02040816326531,
            '                      Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737404", 3, 13.265306122449,
            '                      Math.Round(13.265306122449 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737405", 3, 2.55102040816327,
            '                      Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737407", 3, 5.61224489795918,
            '                      Math.Round(5.61224489795918 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737408", 3, 2.55102040816327,
            '                      Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737409", 3, 3.57142857142857,
            '                      Math.Round(3.57142857142857 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737410", 3, 9.69387755102041,
            '                      Math.Round(9.69387755102041 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737412", 3, 4.08163265306122,
            '                      Math.Round(4.08163265306122 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737413", 3, 1.53061224489796,
            '                      Math.Round(1.53061224489796 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737424", 3, 0.510204081632653,
            '                      Math.Round(0.510204081632653 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737414", 3, 2.55102040816327,
            '                      Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737415", 3, 1.02040816326531,
            '                      Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737416", 3, 1.02040816326531,
            '                      Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737417", 3, 1.53061224489796,
            '                      Math.Round(1.53061224489796 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737418", 3, 2.55102040816327,
            '                      Math.Round(2.55102040816327 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737419", 3, 2.04081632653061,
            '                      Math.Round(2.04081632653061 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
            '    dgvt_doc.Rows.Add("0737420", 3, 1.02040816326531,
            '                      Math.Round(1.02040816326531 * ((npdmonto_total.Value - npdigv.Value - npdestrrural.Value) / 100), 2), 'AFECTO
            '                      0) 'INAFECTO
        ElseIf txtruc.Text = "20100152356" Then 'AGUA
            dgvt_doc.Rows.Add("0737399", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737400", 13, 0.0628019323671498,
                              Math.Round(0.0628019323671498 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737401", 31, 0.14975845410628019,
                              Math.Round(0.14975845410628019 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737402", 20, 0.0966183574879227,
                              Math.Round(0.0966183574879227 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737406", 14, 0.0676328502415459,
                              Math.Round(0.0676328502415459 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737403", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737404", 12, 0.0579710144927536,
                              Math.Round(0.0579710144927536 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737405", 15, 0.072463768115942,
                              Math.Round(0.072463768115942 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 12, 0.0579710144927536,
                              Math.Round(0.0579710144927536 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737408", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737409", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 14, 0.0676328502415459,
                              Math.Round(0.0676328502415459 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747399", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747400", 1, 0.0048309178743961,
                              Math.Round(0.0048309178743961 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747401", 15, 0.072463768115942,
                              Math.Round(0.072463768115942 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) '
            dgvt_doc.Rows.Add("0747405", 1, 0.0048309178743961,
                              Math.Round(0.0048309178743961 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 5, 0.0241545893719807,
                              Math.Round(0.0241545893719807 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737414", 7, 0.0338164251207729,
                              Math.Round(0.0338164251207729 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737415", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40" Then 'txtruc.Text = "20523621212" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(9.66 * 1.18, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 5" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(4.83 * 1.18, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 50" Then
            dgvt_doc.Rows.Add("0742574", 3, 110 / 876,
                             Math.Round(42.37, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 100" Then
            dgvt_doc.Rows.Add("0742575", 3, 110 / 876,
                             Math.Round(84.749, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PACIFICO SEGUROS EMPLEADOS" Then
            dgvt_doc.Rows.Add("0742590", 5, 0.2,
                              Math.Round(0.25 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742591", 2, 0.08,
                              Math.Round(0.08 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742593", 3, 0.12,
                              Math.Round(0.12 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742594", 2, 0.08,
                              Math.Round(0.08 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742595", 2, 0.08,
                              Math.Round(0.08 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742596", 4, 0.16,
                              Math.Round(0.16 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742597", 3, 0.12,
                              Math.Round(0.12 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742598", 3, 0.12,
                              Math.Round(0.12 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747405", 1, 0.04,
                              Math.Round(0.04 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf cmbtipo.Text = "PACIFICO SEGUROS OBREROS" Then
            dgvt_doc.Rows.Add("0742577", 6, 0.032967032967033,
                              Math.Round(0.032967032967033 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742578", 13, 0.0714285714285714,
                              Math.Round(0.0714285714285714 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742579", 31, 0.17032967032967031,
                              Math.Round(0.17032967032967031 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742580", 20, 0.1098901098901099,
                              Math.Round(0.1098901098901099 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742582", 14, 0.0769230769230769,
                              Math.Round(0.0769230769230769 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742581", 2, 0.010989010989011,
                              Math.Round(0.010989010989011 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742583", 12, 0.0659340659340659,
                              Math.Round(0.0659340659340659 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742584", 15, 0.0824175824175824,
                              Math.Round(0.0824175824175824 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742585", 12, 0.0659340659340659,
                              Math.Round(0.0659340659340659 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742586", 6, 0.032967032967033,
                              Math.Round(0.032967032967033 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742587", 6, 0.032967032967033,
                              Math.Round(0.032967032967033 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742588", 14, 0.0769230769230769,
                              Math.Round(0.0769230769230769 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742589", 4, 0.021978021978022,
                              Math.Round(0.021978021978022 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747399", 4, 0.021978021978022,
                              Math.Round(0.021978021978022 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747401", 15, 0.0824175824175824,
                              Math.Round(0.0824175824175824 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747400", 4, 0.0054945054945055,
                              Math.Round(0.0054945054945055 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742592", 7, 0.0384615384615385,
                              Math.Round(0.0384615384615385 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf txtruc.Text = "20503758114" Then 'GAS
            dgvt_doc.Rows.Add("0737406", 3, 110 / 876,
                              Math.Round((110 / 876) * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 3, 716 / 876,
                              Math.Round((716 / 876) * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737404", 3, 50 / 876,
                              Math.Round((50 / 876) * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf cmbtipo.Text = "TELEFONO" Then 'txtruc.Text = "20100017491" Then 'TELEFONO
            dgvt_doc.Rows.Add("0737413", 3, 20,
                              Math.Round((20 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 3, 18,
                              Math.Round((18 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737415", 3, 5,
                              Math.Round((5 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 3, 27,
                              Math.Round((27 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 3, 15,
                              Math.Round((15 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 3, 5,
                              Math.Round((5 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 3, 8,
                              Math.Round((8 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 3, 2,
                              Math.Round((2 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf cmbtipo.Text = "INTERNET TORRES" Then 'INTERNET
            dgvt_doc.Rows.Add("0737422", 3, 1,
                              Math.Round((1 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 3, 1,
                              Math.Round((1 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 3, 1,
                              Math.Round((1 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 3, 20,
                              Math.Round((20 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 3, 18,
                              Math.Round((18 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 3, 27,
                              Math.Round((27 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 3, 3,
                              Math.Round((3 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 3, 2,
                              Math.Round((2 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 3, 26,
                              Math.Round((26 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 3, 1,
                              Math.Round((1 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf cmbtipo.Text = "RIMAC OBREROS" Then
            'dgvt_doc.Rows.Add("0743199", 3, 0.017241379,
            '                  Math.Round((0.017241379 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743200", 29, 0.166666667,
            '                  Math.Round((0.166666667 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743201", 14, 0.08045977,
            '                  Math.Round((0.08045977 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743204", 18, 0.103448276,
            '                  Math.Round((0.103448276 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743203", 22, 0.126436782,
            '                  Math.Round((0.126436782 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743202", 2, 0.011494253,
            '                  Math.Round((0.011494253 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743205", 26, 0.149425287,
            '                  Math.Round((0.149425287 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743206", 5, 0.028735632,
            '                  Math.Round((0.028735632 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743207", 11, 0.063218391,
            '                  Math.Round((0.063218391 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743208", 5, 0.028735632,
            '                  Math.Round((0.028735632 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743209", 7, 0.040229885,
            '                  Math.Round((0.040229885 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743210", 19, 0.109195402,
            '                  Math.Round((0.109195402 * npdmonto_total.Value), 2), 'AFECTO
            '                   0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743211", 8, 0.045977011,
            '                  Math.Round((0.045977011 * npdmonto_total.Value), 2), 'AFECTO
            '                   0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743215", 5, 0.028735632,
            '                  Math.Round((0.028735632 * npdmonto_total.Value), 2), 'AFECTO
            '                   0) 'INAFECTO
            '03-03-2020
            'dgvt_doc.Rows.Add("0743199", 3, 0.017241379,
            '                  Math.Round((0.017241379 * npdmonto_total.Value), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743200", 29, 0.166666667,
            '                  Math.Round((0.166666667 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743201", 14, 0.08045977,
            '                  Math.Round((0.08045977 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743204", 18, 0.103448276,
            '                  Math.Round((0.103448276 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743203", 22, 0.126436782,
            '                  Math.Round((0.126436782 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743202", 2, 0.011494253,
            '                  Math.Round((0.011494253 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743205", 26, 0.149425287,
            '                  Math.Round((0.149425287 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743206", 5, 0.028735632,
            '                  Math.Round((0.028735632 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743207", 11, 0.063218391,
            '                  Math.Round((0.063218391 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743208", 5, 0.028735632,
            '                  Math.Round((0.028735632 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743209", 7, 0.040229885,
            '                  Math.Round((0.040229885 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743210", 19, 0.109195402,
            '                  Math.Round((0.109195402 * npdmonto_total.Value), 2), 'AFECTO
            '                   0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743211", 8, 0.045977011,
            '                  Math.Round((0.045977011 * npdmonto_total.Value), 2), 'AFECTO
            '                   0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743215", 5, 0.028735632,
            '                  Math.Round((0.028735632 * npdmonto_total.Value), 2), 'AFECTO
            '                   0) 'INAFECTO
            'CAMBIADO POR ANDREA
            dgvt_doc.Rows.Add("0742577", 3, 0.0172413793103448,
                              Math.Round(0.0172413793103448 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742578", 3, 0.166666666666667,
                              Math.Round(0.166666666666667 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742579", 3, 0.0804597701149425,
                              Math.Round(0.0804597701149425 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742580", 3, 0.103448275862069,
                              Math.Round(0.103448275862069 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742582", 3, 0.126436781609195,
                              Math.Round(0.126436781609195 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742581", 3, 0.0114942528735632,
                              Math.Round(0.0114942528735632 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742583", 3, 0.149425287356322,
                              Math.Round(0.149425287356322 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742584", 3, 0.028735632183908,
                              Math.Round(0.028735632183908 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742585", 3, 0.0632183908045977,
                              Math.Round(0.0632183908045977 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742586", 3, 0.028735632183908,
                              Math.Round(0.028735632183908 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742587", 3, 0.0402298850574713,
                              Math.Round(0.0402298850574713 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742588", 14, 0.0769230769230769,
                              Math.Round(0.0769230769230769 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742589", 3, 0.0459770114942529,
                              Math.Round(0.0459770114942529 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742592", 3, 0.028735632183908,
                              Math.Round(0.028735632183908 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO  
        ElseIf cmbtipo.Text = "RIMAC EMPLEADOS" Then
            'dgvt_doc.Rows.Add("0743212", 3, 0.136363636,
            '                  Math.Round((0.136363636 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743214", 1, 0.045454545,
            '                  Math.Round((0.045454545 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743216", 2, 0.090909091,
            '                  Math.Round((0.090909091 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743217", 2, 0.090909091,
            '                  Math.Round((0.090909091 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743218", 3, 0.136363636,
            '                  Math.Round((0.136363636 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743219", 5, 0.227272727,
            '                  Math.Round((0.227272727 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743220", 4, 0.181818182,
            '                  Math.Round((0.181818182 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743221", 2, 0.090909091,
            '                  Math.Round((0.090909091 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0743212", 5, 0.2,
                              Math.Round((0.2 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743214", 2, 0.08,
                              Math.Round((0.08 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743216", 3, 0.12,
                              Math.Round((0.12 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743217", 2, 0.08,
                              Math.Round((0.08 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743218", 2, 0.08,
                              Math.Round((0.08 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743219", 4, 0.16,
                              Math.Round((0.16 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743220", 3, 0.12,
                              Math.Round((0.12 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743221", 3, 0.12,
                              Math.Round((0.12 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747405", 1, 0.04,
                             Math.Round((0.04 * npdmonto_total.Value), 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40 - 2" Then 'txtruc.Text = "20523621212" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(9.6610169491525415, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.80" Then 'txtruc.Text = "20523621212" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(10, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 10.40" Then 'txtruc.Text = "20523621212" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(8.8135593220338979, 2), 'AFECTO
                             0) 'INAFECTO
            'ElseIf cmbtipo.Text = "CREATECH INGENIERIA Y PROYECTO S.A.C." Then 'txtruc.Text = "20523621212" Then
            '    npdigv.Value = (npdmonto_total.Value * 18) / 100
            '    dgvt_doc.Rows.Add("0743288", 3, 110 / 876,
            '                     Math.Round(npdmonto_total.Value, 2), 'AFECTO
            '                         0) 'INAFECTO
        Else
            MsgBox("Seleccione alguna opcion para duplicar")
        End If

    End Sub

    Private Sub cmbtipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipo.SelectedIndexChanged
        dgvt_doc.Rows.Clear()
        txtruc.ReadOnly = True
        Label5.Text = "Monto Base"
        If cmbtipo.Text = "AGUA" Then
            txtruc.Text = "20100152356"
        ElseIf cmbtipo.Text = "LUZ" Then
            txtruc.Text = "20331898008"
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40" Or cmbtipo.Text = "PEAJE LINEA AMARILLA 5" Or
            cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40 - 2" Or cmbtipo.Text = "PEAJE LINEA AMARILLA 10.40" Or
            cmbtipo.Text = "PEAJE LINEA AMARILLA 11.80" Then
            txtruc.Text = "20523621212"
        ElseIf cmbtipo.Text = "GAS" Then
            txtruc.Text = "20503758114"
        ElseIf cmbtipo.Text = "TELEFONO" Then
            txtruc.Text = "20100017491"
        ElseIf cmbtipo.Text = "INTERNET TORRES" Then
            txtruc.Text = "20552504641"
        ElseIf cmbtipo.Text = "PACIFICO SEGUROS EMPLEADOS" Or cmbtipo.Text = "PACIFICO SEGUROS OBREROS" Then
            txtruc.Text = "20332970411"
        ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 50" Or cmbtipo.Text = "GRIFO JIARA S.A.C 100" Then
            txtruc.Text = "20551615856"
        ElseIf cmbtipo.Text = "CELULARES SIN IGV" Then
            txtruc.Text = "20100017491"
        ElseIf cmbtipo.Text = "LUZ STATKRAFT SOLES" Then
            txtruc.Text = "20269180731"
            Label5.Text = "Monto Total"
        ElseIf cmbtipo.Text = "LUZ STATKRAFT DOLARES" Then
            txtruc.Text = "20269180731"
        ElseIf cmbtipo.Text = "RIMAC OBREROS" Then
            txtruc.Text = "20100041953"
        ElseIf cmbtipo.Text = "RIMAC EMPLEADOS" Then
            txtruc.Text = "20100041953"
        ElseIf cmbtipo.Text = "TELEFONO IGV" Then
            txtruc.Text = "20100017491"
        ElseIf cmbtipo.Text = "CREATECH INGENIERIA Y PROYECTO S.A.C." Then
            txtruc.Text = "20553430632"
        ElseIf cmbtipo.Text = "INTERNET ELOY" Then
            txtruc.Text = "20552504641"
        ElseIf cmbtipo.Text = "MEDICO" Then
            txtruc.Text = "20606386398"
        Else
            txtruc.Text = ""
            txtruc.ReadOnly = False
        End If
    End Sub


    Private Sub txtnro_LostFocus(sender As Object, e As EventArgs) Handles txtnro.LostFocus
        dgvt_doc.Rows.Clear()
        If cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                                         Math.Round(9.66, 2), 'AFECTO
                                         0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 5" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                                       Math.Round(4.83, 2), 'AFECTO
                                       0) 'INAFECTO
        ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 50" Then
            dgvt_doc.Rows.Add("0742574", 3, 110 / 876,
                             Math.Round(42.37, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 100" Then
            dgvt_doc.Rows.Add("0742575", 3, 110 / 876,
                             Math.Round(84.749, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40 - 2" Then 'txtruc.Text = "20523621212" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(9.6610169491525415, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.80" Then 'txtruc.Text = "20523621212" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(10, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 10.40" Then 'txtruc.Text = "20523621212" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(8.8135593220338979, 2), 'AFECTO
                             0) 'INAFECTO
        End If

    End Sub

    Private Sub txtnro_Enter(sender As Object, e As EventArgs) Handles txtnro.Enter
        txtnro.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtnro_Leave(sender As Object, e As EventArgs) Handles txtnro.Leave
        txtnro.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtnro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnro.KeyDown
        If cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40" Or cmbtipo.Text = "PEAJE LINEA AMARILLA 5" Or
           cmbtipo.Text = "GRIFO JIARA S.A.C 100" Or cmbtipo.Text = "GRIFO JIARA S.A.C 50" Or
           cmbtipo.Text = "PEAJE LINEA AMARILLA 10.40" Or cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40 - 2" Or
           cmbtipo.Text = "PEAJE LINEA AMARILLA 11.80" Then
            If e.KeyValue = Keys.Enter Then
                txt_fec_emi.Focus()
            End If
        ElseIf cmbtipo.Text = "PACIFICO SEGUROS EMPLEADOS" Or cmbtipo.Text = "PACIFICO SEGUROS OBREROS" Or cmbtipo.Text = "LUZ" Or
            cmbtipo.Text = "CREATECH INGENIERIA Y PROYECTO S.A.C." Then
            If e.KeyValue = Keys.Enter Then
                npdmonto_total.Focus()
            End If
        Else
            If e.KeyValue = Keys.Enter Then
                npdmonto_total.Focus()
            End If
        End If

    End Sub

    Private Sub txtserie_Enter(sender As Object, e As EventArgs) Handles txtserie.Enter
        txtserie.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtserie_Leave(sender As Object, e As EventArgs) Handles txtserie.Leave
        txtserie.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtserie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserie.KeyDown
        'If cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40" Or cmbtipo.Text = "PEAJE LINEA AMARILLA 5" Then
        If e.KeyValue = Keys.Enter Then
                txtnro.Focus()
            End If
        'End If
    End Sub

    Private Sub txt_fec_emi_Enter(sender As Object, e As EventArgs) Handles txt_fec_emi.Enter
        txt_fec_emi.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txt_fec_emi_Leave(sender As Object, e As EventArgs) Handles txt_fec_emi.Leave
        txt_fec_emi.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txt_fec_emi_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fec_emi.KeyDown
        'If cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40" Or cmbtipo.Text = "PEAJE LINEA AMARILLA 5" Then
        If e.KeyValue = Keys.Enter Then
                txtfecprov.Focus()
            End If
        'End If
    End Sub

    Private Sub txtfecprov_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfecprov.KeyDown
        'If cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40" Or cmbtipo.Text = "PEAJE LINEA AMARILLA 5" Then
        If e.KeyValue = Keys.Enter Then
                btnduplicar.Focus()
            End If
        'End If
    End Sub

    Private Sub txtfecprov_Leave(sender As Object, e As EventArgs) Handles txtfecprov.Leave
        txtfecprov.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtfecprov_Enter(sender As Object, e As EventArgs) Handles txtfecprov.Enter
        txtfecprov.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txt_fec_emi_LostFocus(sender As Object, e As EventArgs) Handles txt_fec_emi.LostFocus
        txtfecprov.Text = txt_fec_emi.Text
    End Sub

    Private Sub npdmonto_total_KeyDown(sender As Object, e As KeyEventArgs) Handles npdmonto_total.KeyDown
        If cmbtipo.Text = "LUZ" Or cmbtipo.Text = "LUZ STATKRAFT DOLARES" Or cmbtipo.Text = "LUZ STATKRAFT SOLES" Then
            If e.KeyValue = Keys.Enter Then
                npdestrrural.Focus()
            End If
        Else
            If e.KeyValue = Keys.Enter Then
                txt_fec_emi.Focus()
            End If
        End If
    End Sub

    Private Sub npdestrrural_KeyDown(sender As Object, e As KeyEventArgs) Handles npdestrrural.KeyDown
        If cmbtipo.Text = "LUZ" Then
            If e.KeyValue = Keys.Enter Then
                npdigv.Focus()
            End If
        Else
            If e.KeyValue = Keys.Enter Then
                txt_fec_emi.Focus()
            End If
        End If
    End Sub

    Private Sub npdigv_KeyDown(sender As Object, e As KeyEventArgs) Handles npdigv.KeyDown
        If e.KeyValue = Keys.Enter Then
            txt_fec_emi.Focus()
        End If
    End Sub

    Private Sub npdmonto_total_LostFocus(sender As Object, e As EventArgs) Handles npdmonto_total.LostFocus
        dgvt_doc.Rows.Clear()
        If cmbtipo.Text = "PACIFICO SEGUROS EMPLEADOS" Then
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0742590", 5, 0.2,
                              Math.Round(0.2 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742591", 2, 0.08,
                              Math.Round(0.08 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742593", 3, 0.12,
                              Math.Round(0.12 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742594", 2, 0.08,
                              Math.Round(0.08 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742595", 2, 0.08,
                              Math.Round(0.08 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742596", 4, 0.16,
                              Math.Round(0.16 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742597", 3, 0.12,
                              Math.Round(0.12 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742598", 3, 0.12,
                              Math.Round(0.12 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747405", 1, 0.04,
                              Math.Round(0.04 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf cmbtipo.Text = "PACIFICO SEGUROS OBREROS" Then
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0742577", 6, 0.032967032967033,
                              Math.Round(0.032967032967033 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742578", 13, 0.0714285714285714,
                              Math.Round(0.0714285714285714 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742579", 31, 0.17032967032967031,
                              Math.Round(0.17032967032967031 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742580", 20, 0.1098901098901099,
                              Math.Round(0.1098901098901099 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742582", 14, 0.0769230769230769,
                              Math.Round(0.0769230769230769 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742581", 2, 0.010989010989011,
                              Math.Round(0.010989010989011 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742583", 12, 0.0659340659340659,
                              Math.Round(0.0659340659340659 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742584", 15, 0.0824175824175824,
                              Math.Round(0.0824175824175824 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742585", 12, 0.0659340659340659,
                              Math.Round(0.0659340659340659 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742586", 6, 0.032967032967033,
                              Math.Round(0.032967032967033 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742587", 6, 0.032967032967033,
                              Math.Round(0.032967032967033 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742588", 14, 0.0769230769230769,
                              Math.Round(0.0769230769230769 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742589", 4, 0.021978021978022,
                              Math.Round(0.021978021978022 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747399", 4, 0.021978021978022,
                              Math.Round(0.021978021978022 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747401", 15, 0.0824175824175824,
                              Math.Round(0.0824175824175824 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747400", 4, 0.0054945054945055,
                              Math.Round(0.0054945054945055 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742592", 7, 0.0384615384615385,
                              Math.Round(0.0384615384615385 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf cmbtipo.Text = "TELEFONO" Then
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0737413", 3, 20,
                              Math.Round((20 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 3, 18,
                              Math.Round((18 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737415", 3, 5,
                              Math.Round((5 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 3, 27,
                              Math.Round((27 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 3, 15,
                              Math.Round((15 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 3, 5,
                              Math.Round((5 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 3, 8,
                              Math.Round((8 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 3, 2,
                              Math.Round((2 * npdmonto_total.Value) / 100, 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf txtruc.Text = "20100152356" Then 'AGUA
            npdigv.Value = (npdmonto_total.Value * 18)
            dgvt_doc.Rows.Add("0737399", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737400", 13, 0.0628019323671498,
                              Math.Round(0.0628019323671498 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737401", 31, 0.14975845410628019,
                              Math.Round(0.14975845410628019 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737402", 20, 0.0966183574879227,
                              Math.Round(0.0966183574879227 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737406", 14, 0.0676328502415459,
                              Math.Round(0.0676328502415459 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737403", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737404", 12, 0.0579710144927536,
                              Math.Round(0.0579710144927536 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737405", 15, 0.072463768115942,
                              Math.Round(0.072463768115942 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 12, 0.0579710144927536,
                              Math.Round(0.0579710144927536 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737408", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737409", 6, 0.0289855072463768,
                              Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 14, 0.0676328502415459,
                              Math.Round(0.0676328502415459 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747399", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747400", 1, 0.0048309178743961,
                              Math.Round(0.0048309178743961 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747401", 15, 0.072463768115942,
                              Math.Round(0.072463768115942 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) '
            dgvt_doc.Rows.Add("0747405", 1, 0.0048309178743961,
                              Math.Round(0.0048309178743961 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 5, 0.0241545893719807,
                              Math.Round(0.0241545893719807 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737414", 7, 0.0338164251207729,
                              Math.Round(0.0338164251207729 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737415", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 2, 0.0096618357487923,
                              Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 4, 0.0193236714975845,
                              Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 3, 0.0144927536231884,
                              Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 6), 'AFECTO
                              0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40" Then 'txtruc.Text = "20523621212" Then
            'ACA
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(9.66 * 1.18, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 5" Then
            'ACA
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(4.83 * 1.18, 6), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 50" Then
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0742574", 3, 110 / 876,
                             Math.Round(42.37, 6), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "GRIFO JIARA S.A.C 100" Then
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0742575", 3, 110 / 876,
                             Math.Round(84.749, 6), 'AFECTO
                             0) 'INAFECTO
        ElseIf txtruc.Text = "20503758114" Then 'GAS
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0737406", 3, 110 / 876,
                              Math.Round((110 / 876) * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 3, 716 / 876,
                              Math.Round((716 / 876) * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737404", 3, 50 / 876,
                              Math.Round((50 / 876) * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf cmbtipo.Text = "INTERNET TORRES" Then 'INTERNET
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0737422", 3, 1,
                              Math.Round((1 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 3, 1,
                              Math.Round((1 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 3, 1,
                              Math.Round((1 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 3, 20,
                              Math.Round((20 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 3, 18,
                              Math.Round((18 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 3, 27,
                              Math.Round((27 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 3, 3,
                              Math.Round((3 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 3, 2,
                              Math.Round((2 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 3, 26,
                              Math.Round((26 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 3, 1,
                              Math.Round((1 * npdmonto_total.Value / 100), 2), 'AFECTO
                              0) 'INAFECTO
        ElseIf cmbtipo.Text = "CELULARES SIN IGV" Then 'CELULARES
            npdigv.Value = 0
            dgvt_doc.Rows.Add("0737409", 0.02, 0,
                              0, 'AFECTO
                              Math.Round(npdmonto_total.Value * 0.02, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 0.06, 0,
                              0, 'AFECTO
                              Math.Round(npdmonto_total.Value * 0.06, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 0.06, 0,
                              0, 'AFECTO
                              Math.Round(npdmonto_total.Value * 0.06, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 0.14, 0,
                              0, 'AFECTO
                              Math.Round(npdmonto_total.Value * 0.14, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 0.51, 0,
                              0, 'AFECTO
                              Math.Round(npdmonto_total.Value * 0.51, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 0.03, 0,
                              0, 'AFECTO
                              Math.Round(npdmonto_total.Value * 0.03, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 0.04, 0,
                              0, 'AFECTO
                              Math.Round(npdmonto_total.Value * 0.04, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 0.02, 0,
                              0, 'AFECTO
                              Math.Round(npdmonto_total.Value * 0.02, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 0.01, 0,
                              0, 'AFECTO
                              Math.Round(npdmonto_total.Value * 0.01, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 0.02, 0,
                              0, 'AFECTO
                              Math.Round(npdmonto_total.Value * 0.02, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0742669", 0.06, 0,
                             0, 'AFECTO
                             Math.Round(npdmonto_total.Value * 0.06, 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0737400", 0.03, 0,
                             0, 'AFECTO
                             Math.Round(npdmonto_total.Value * 0.03, 2)) 'INAFECTO
        ElseIf cmbtipo.Text = "CELULARES IGV" Then 'CELULARES
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0737409", 0.01, 0,
                              Math.Round((npdmonto_total.Value * 0.01), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 0.11, 0,
                              Math.Round((npdmonto_total.Value * 0.11), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 0.32, 0,
                              Math.Round((npdmonto_total.Value * 0.32), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 0.05, 0,
                              Math.Round((npdmonto_total.Value * 0.05), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 0.05, 0,
                              Math.Round((npdmonto_total.Value * 0.05), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737399", 0.01, 0,
                              Math.Round((npdmonto_total.Value * 0.01), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737401", 0.01, 0,
                              Math.Round((npdmonto_total.Value * 0.01), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737403", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747401", 0.01, 0,
                              Math.Round((npdmonto_total.Value * 0.01), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737414", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 0.05, 0,
                              Math.Round((npdmonto_total.Value * 0.05), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742665", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737420", 0.02, 0,
            '                  Math.Round((npdmonto_total.Value * 0.02), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0742669", 0.06, 0,
            '                  Math.Round((npdmonto_total.Value * 0.06), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737400", 0.03, 0,
            '                  Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
            '                  0) 'INAFECTO
        ElseIf cmbtipo.Text = "ENTEL" Then 'CELULARES
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0737409", 0.01, 0,
                              Math.Round((npdmonto_total.Value * 0.01), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 0.11, 0,
                              Math.Round((npdmonto_total.Value * 0.11), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 0.32, 0,
                              Math.Round((npdmonto_total.Value * 0.32), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 0.05, 0,
                              Math.Round((npdmonto_total.Value * 0.05), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 0.05, 0,
                              Math.Round((npdmonto_total.Value * 0.05), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737399", 0.01, 0,
                              Math.Round((npdmonto_total.Value * 0.01), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737401", 0.01, 0,
                              Math.Round((npdmonto_total.Value * 0.01), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737403", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747401", 0.01, 0,
                              Math.Round((npdmonto_total.Value * 0.01), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737414", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 0.05, 0,
                              Math.Round((npdmonto_total.Value * 0.05), 2),'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742665", 0.03, 0,
                              Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
                              0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737409", 0.02, 0,
            '                  Math.Round((npdmonto_total.Value * 0.02), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737410", 0.06, 0,
            '                  Math.Round((npdmonto_total.Value * 0.06), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737412", 0.06, 0,
            '                  Math.Round((npdmonto_total.Value * 0.06), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737413", 0.14, 0,
            '                  Math.Round((npdmonto_total.Value * 0.14), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737419", 0.51, 0,
            '                  Math.Round((npdmonto_total.Value * 0.51), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737407", 0.03, 0,
            '                  Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737424", 0.04, 0,
            '                  Math.Round((npdmonto_total.Value * 0.04), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737416", 0.02, 0,
            '                  Math.Round((npdmonto_total.Value * 0.02), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737418", 0.01, 0,
            '                  Math.Round((npdmonto_total.Value * 0.01), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737420", 0.02, 0,
            '                  Math.Round((npdmonto_total.Value * 0.02), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0742669", 0.06, 0,
            '                  Math.Round((npdmonto_total.Value * 0.06), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0737400", 0.03, 0,
            '                  Math.Round((npdmonto_total.Value * 0.03), 2),'AFECTO
            '                  0) 'INAFECTO
            'dtp_fec_emi.Focus()
        ElseIf cmbtipo.Text = "RIMAC OBREROS" Then
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            'dgvt_doc.Rows.Add("0743199", 3, 0.017241379,
            '                  Math.Round((0.017241379 * npdmonto_total.Value), 2),'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743200", 29, 0.166666667,
            '                  Math.Round((0.166666667 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743201", 14, 0.08045977,
            '                  Math.Round((0.08045977 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743204", 18, 0.103448276,
            '                  Math.Round((0.103448276 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743203", 22, 0.126436782,
            '                  Math.Round((0.126436782 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743202", 2, 0.011494253,
            '                  Math.Round((0.011494253 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743205", 26, 0.149425287,
            '                  Math.Round((0.149425287 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743206", 5, 0.028735632,
            '                  Math.Round((0.028735632 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743207", 11, 0.063218391,
            '                  Math.Round((0.063218391 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743208", 5, 0.028735632,
            '                  Math.Round((0.028735632 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743209", 7, 0.040229885,
            '                  Math.Round((0.040229885 * npdmonto_total.Value), 2), 'AFECTO
            '                  0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743210", 19, 0.109195402,
            '                  Math.Round((0.109195402 * npdmonto_total.Value), 2), 'AFECTO
            '                   0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743211", 8, 0.045977011,
            '                  Math.Round((0.045977011 * npdmonto_total.Value), 2), 'AFECTO
            '                   0) 'INAFECTO
            'dgvt_doc.Rows.Add("0743215", 5, 0.028735632,
            '                  Math.Round((0.028735632 * npdmonto_total.Value), 2), 'AFECTO
            '                   0) 'INAFECTO
            'CAMBIADO POR ANDREA
            dgvt_doc.Rows.Add("0742577", 6, 0.032967032967033,
                              Math.Round(0.032967032967033 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742578", 13, 0.0714285714285714,
                              Math.Round(0.0714285714285714 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742579", 31, 0.17032967032967031,
                              Math.Round(0.17032967032967031 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742580", 20, 0.1098901098901099,
                              Math.Round(0.1098901098901099 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742582", 14, 0.0769230769230769,
                              Math.Round(0.0769230769230769 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742581", 2, 0.010989010989011,
                              Math.Round(0.010989010989011 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742583", 12, 0.0659340659340659,
                              Math.Round(0.0659340659340659 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742584", 15, 0.0824175824175824,
                              Math.Round(0.0824175824175824 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742585", 12, 0.0659340659340659,
                              Math.Round(0.0659340659340659 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742586", 6, 0.032967032967033,
                              Math.Round(0.032967032967033 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742587", 6, 0.032967032967033,
                              Math.Round(0.032967032967033 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742588", 14, 0.0769230769230769,
                              Math.Round(0.0769230769230769 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742589", 4, 0.021978021978022,
                              Math.Round(0.021978021978022 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747399", 4, 0.021978021978022,
                              Math.Round(0.021978021978022 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747401", 15, 0.0824175824175824,
                              Math.Round(0.0824175824175824 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747400", 1, 0.0054945054945055,
                              Math.Round(0.0054945054945055 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0742592", 7, 0.0384615384615385,
                              Math.Round(0.0384615384615385 * (npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO  
        ElseIf cmbtipo.Text = "RIMAC EMPLEADOS" Then
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0743212", 5, 0.2,
                              Math.Round((0.2 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743214", 2, 0.08,
                              Math.Round((0.08 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743216", 3, 0.12,
                              Math.Round((0.12 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743217", 2, 0.08,
                              Math.Round((0.08 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743218", 2, 0.08,
                              Math.Round((0.08 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743219", 4, 0.16,
                              Math.Round((0.16 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743220", 3, 0.12,
                              Math.Round((0.12 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0743221", 3, 0.12,
                              Math.Round((0.12 * npdmonto_total.Value), 2), 'AFECTO
                              0) 'INAFECTO
            dgvt_doc.Rows.Add("0747405", 1, 0.04,
                             Math.Round((0.04 * npdmonto_total.Value), 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "LUZ STATKRAFT SOLES" Then
            npdestrrural.Focus()
        ElseIf cmbtipo.Text = "MEDICO" Then
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0737399", 6, 0.015306122,
                             Math.Round(0.015306122 * ((npdmonto_total.Value)), 2), 'AFECTO
                             0) 'INAFECTO
            dgvt_doc.Rows.Add("0737400", 6, 0.147959184,
                 Math.Round(0.147959184 * ((npdmonto_total.Value)), 2), 'AFECTO
                 0) 'INAFECTO
            dgvt_doc.Rows.Add("0737401", 6, 0.071428571,
                 Math.Round(0.071428571 * ((npdmonto_total.Value)), 2), 'AFECTO
                 0) 'INAFECTO
            dgvt_doc.Rows.Add("0737402", 6, 0.091836735,
                 Math.Round(0.091836735 * ((npdmonto_total.Value)), 2), 'AFECTO
                 0) 'INAFECTO
            dgvt_doc.Rows.Add("0737406", 6, 0.112244898,
                 Math.Round(0.112244898 * ((npdmonto_total.Value)), 2), 'AFECTO
                 0) 'INAFECTO
            dgvt_doc.Rows.Add("0737403", 6, 0.010204082,
                 Math.Round(0.010204082 * ((npdmonto_total.Value)), 2), 'AFECTO
                 0) 'INAFECTO
            dgvt_doc.Rows.Add("0737404", 6, 0.132653061,
                 Math.Round(0.132653061 * ((npdmonto_total.Value)), 2), 'AFECTO
                 0) 'INAFECTO
            dgvt_doc.Rows.Add("0737405", 6, 0.025510204,
                 Math.Round(0.025510204 * ((npdmonto_total.Value)), 2), 'AFECTO
                 0) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 6, 0.056122449,
               Math.Round(0.056122449 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737408", 6, 0.025510204,
               Math.Round(0.025510204 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737409", 6, 0.035714286,
               Math.Round(0.035714286 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 6, 0.096938776,
               Math.Round(0.096938776 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 6, 0.040816327,
               Math.Round(0.040816327 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 6, 0.015306122,
               Math.Round(0.015306122 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 6, 0.005102041,
               Math.Round(0.005102041 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737414", 6, 0.025510204,
               Math.Round(0.025510204 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737415", 6, 0.010204082,
               Math.Round(0.010204082 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 6, 0.010204082,
               Math.Round(0.010204082 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 6, 0.015306122,
               Math.Round(0.015306122 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 6, 0.025510204,
               Math.Round(0.025510204 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 6, 0.020408163,
               Math.Round(0.020408163 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 6, 0.010204082,
               Math.Round(0.010204082 * ((npdmonto_total.Value)), 2), 'AFECTO
               0) 'INAFECTO
        ElseIf cmbtipo.Text = "LUZ STATKRAFT DOLARES" Then
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0737399", 6, 0.0289855072463768,
                             Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                             0) 'INAFECTO
            dgvt_doc.Rows.Add("0737400", 13, 0.0628019323671498,
                                  Math.Round(0.0628019323671498 * ((npdmonto_total.Value)), 2), 'AFECTO
                                 0) 'INAFECTO
            dgvt_doc.Rows.Add("0737401", 31, 0.14975845410628019,
                                  Math.Round(0.14975845410628019 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737402", 20, 0.0966183574879227,
                                  Math.Round(0.0966183574879227 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737406", 14, 0.0676328502415459,
                                  Math.Round(0.0676328502415459 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737403", 2, 0.0096618357487923,
                                  Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737404", 12, 0.0579710144927536,
                                  Math.Round(0.0579710144927536 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737405", 15, 0.072463768115942,
                                  Math.Round(0.072463768115942 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737407", 12, 0.0579710144927536,
                                  Math.Round(0.0579710144927536 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737408", 6, 0.0289855072463768,
                                  Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737409", 6, 0.0289855072463768,
                                  Math.Round(0.0289855072463768 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737410", 14, 0.0676328502415459,
                                  Math.Round(0.0676328502415459 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737412", 4, 0.0193236714975845,
                                  Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0747399", 4, 0.0193236714975845,
                                  Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0747400", 1, 0.0048309178743961,
                              Math.Round(0.0048309178743961 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0747401", 15, 0.072463768115942,
                              Math.Round(0.072463768115942 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0747405", 1, 0.0048309178743961,
                             Math.Round(0.0048309178743961 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737413", 5, 0.0241545893719807,
                                  Math.Round(0.0241545893719807 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737424", 2, 0.0096618357487923,
                                  Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737414", 7, 0.0338164251207729,
                                  Math.Round(0.0338164251207729 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737415", 3, 0.0144927536231884,
                                  Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737416", 2, 0.0096618357487923,
                                  Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737417", 2, 0.0096618357487923,
                                  Math.Round(0.0096618357487923 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737418", 4, 0.0193236714975845,
                                  Math.Round(0.0193236714975845 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737419", 3, 0.0144927536231884,
                                  Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            dgvt_doc.Rows.Add("0737420", 3, 0.0144927536231884,
                                  Math.Round(0.0144927536231884 * ((npdmonto_total.Value)), 2), 'AFECTO
                                  0) 'INAFECTO
            txt_fec_emi.Focus()
        ElseIf cmbtipo.Text = "GASTOS REPRESENTACION" Then
            dgvt_doc.Rows.Add("0743199", 3, 0.015306122,'AFECTO
                              0,
                              Math.Round((0.015306122 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743200", 29, 0.147959184, 'AFECTO
                              0,
                              Math.Round((0.147959184 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743201", 14, 0.071428571, 'AFECTO
                              0,
                              Math.Round((0.071428571 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743204", 18, 0.091836735, 'AFECTO
                              0,
                              Math.Round((0.091836735 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743203", 22, 0.112244898, 'AFECTO
                              0,
                              Math.Round((0.112244898 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743202", 2, 0.010204082, 'AFECTO
                              0,
                              Math.Round((0.010204082 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743205", 26, 0.132653061, 'AFECTO
                              0,
                              Math.Round((0.132653061 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743206", 5, 0.025510204, 'AFECTO
                              0,
                              Math.Round((0.025510204 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743207", 11, 0.056122449, 'AFECTO
                              0,
                              Math.Round((0.056122449 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743208", 5, 0.025510204, 'AFECTO
                              0,
                              Math.Round((0.025510204 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743209", 7, 0.035714286, 'AFECTO
                              0,
                              Math.Round((0.035714286 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743210", 19, 0.096938776, 'AFECTO
                              0,
                              Math.Round((0.096938776 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743211", 8, 0.040816327, 'AFECTO
                              0,
                              Math.Round((0.040816327 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743215", 5, 0.025510204, 'AFECTO
                              0,
                              Math.Round((0.025510204 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743212", 3, 0.015306122, 'AFECTO
                              0,
                              Math.Round((0.015306122 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743214", 1, 0.005102041, 'AFECTO
                              0,
                              Math.Round((0.005102401 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743216", 2, 0.010204082, 'AFECTO
                              0,
                              Math.Round((0.010204082 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743217", 2, 0.010204082, 'AFECTO
                              0,
                              Math.Round((0.010204082 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743218", 3, 0.015306122, 'AFECTO
                              0,
                              Math.Round((0.015306122 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743219", 5, 0.025510204, 'AFECTO
                              0,
                              Math.Round((0.025510204 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743220", 4, 0.020408163, 'AFECTO
                              0,
                              Math.Round((0.020408163 * npdmonto_total.Value), 2)) 'INAFECTO
            dgvt_doc.Rows.Add("0743221", 2, 0.010204082, 'AFECTO
                              0,
                              Math.Round((0.010204082 * npdmonto_total.Value), 2)) 'INAFECTO
            txt_fec_emi.Focus()
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40 - 2" Then 'txtruc.Text = "20523621212" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(1.74 * 1.18, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 11.80" Then 'txtruc.Text = "20523621212" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(10, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "PEAJE LINEA AMARILLA 10.40" Then 'txtruc.Text = "20523621212" Then
            dgvt_doc.Rows.Add("0742547", 3, 110 / 876,
                             Math.Round(1.59 * 1.18, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf cmbtipo.Text = "CREATECH INGENIERIA Y PROYECTO S.A.C." Then 'txtruc.Text = "20523621212" Then
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0743288", 3, 110 / 876,
                             Math.Round(npdmonto_total.Value, 2), 'AFECTO
                                 0) 'INAFECTO
        ElseIf cmbtipo.Text = "INTERNET ELOY" Then 'INTERNET
            npdigv.Value = (npdmonto_total.Value * 18) / 100
            dgvt_doc.Rows.Add("0742665", 3, 110 / 876,
                             Math.Round(npdmonto_total.Value, 2), 'AFECTO
                             0) 'INAFECTO
        ElseIf txtruc.Text = "20331898008" Then

        Else
            MsgBox("Seleccione alguna opcion para duplicar")
        End If

        'End If
    End Sub
End Class