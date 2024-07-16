Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.IO

Public Class FormAlbaran

    Private gpCaption As String
    Public rEst As String
    Private p As Integer = 0
    Dim ELALBARANBL As New ELALBARANBL
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
#Disable Warning BC42105 ' La función 'GetCmb' no devuelve un valor en todas las rutas de acceso de código. Puede producirse una excepción de referencia NULL en tiempo de ejecución cuando se use el resultado.
    End Function

    Private Sub FormAlbaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Dim nro As String
        Dim anu As String

        DataGridView1.Columns.Add("LOTE1", "LOTE")              '0
        DataGridView1.Columns.Add("CANTIDAD", "CANT")       '1
        DataGridView1.Columns.Add("TURNO", "TUR")             '2
        DataGridView1.Columns.Add("FEC_PRO", "F.PRO")         '3
        DataGridView1.Columns.Add("FEC_VEN", "F.VEN")         '4

        DataGridView1.Columns.Add("PAQBAS", "P.B")          '5
        DataGridView1.Columns.Add("PAQALT", "P.A")          '6
        DataGridView1.Columns.Add("PAQPAL", "P.P")          '7
        DataGridView1.Columns.Add("UNIPAQ", "U.PQ")          '8
        DataGridView1.Columns.Add("UNIPAL", "U.PL")          '9

        DataGridView1.Columns.Add("NUMPAL", "N.PAL")          '10
        gpCaption = "Aldebaran"
        Select Case gnOpcion
            Case 0

                cmbEst.SelectedIndex = 0
                TextBox14.Text = FormMain.cmbaño.Text

                nro = ELALBARANBL.LastCodigo(TextBox14.Text)
                If nro.Length = 1 Then
                    txtnumero.Text = "000000" & nro
                ElseIf nro.Length = 2 Then
                    txtnumero.Text = "00000" & nro
                ElseIf nro.Length = 3 Then
                    txtnumero.Text = "0000" & nro
                ElseIf nro.Length = 4 Then
                    txtnumero.Text = "000" & nro
                ElseIf nro.Length = 5 Then
                    txtnumero.Text = "00" & nro
                ElseIf nro.Length = 6 Then
                    txtnumero.Text = "0" & nro
                ElseIf nro.Length = 7 Then
                    txtnumero.Text = nro
                End If


                rEst = "N"
            Case 1

                If FormMantGuiaDespacho.txtctct_cod.Text <> "20373860736" Then
                    Dispose()
                End If
                txtNro_two.ReadOnly = True
                txtNro_two.Text = FormMantGuiaDespacho.txtnumero.Text
                btnBusTwo_Click(sender, e)
                rEst = "M"
        End Select

    End Sub

    Private Sub FormAlbaran_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtNro_two_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNro_two.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "253"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gSubLinea <> Nothing) Then
                ' cmbarticulo.Items().Clear()
                ' dgvt_doc.Rows.Clear()
                ' dgvt_doc.DataSource = Nothing

                txtNro_two.Text = gSubLinea
                ' btnBusTwo_Click(sender, e)
            End If
            e.Handled = True
        End If
        btnBusTwo_Click(sender, e)
    End Sub

    Private Sub btnBusTwo_Click(sender As Object, e As EventArgs) Handles btnBusTwo.Click
        txtctct_two.Text = Nothing
        Dim dt As DataTable
        Dim ELALBARANBL As New ELALBARANBL
        dt = ELALBARANBL.SelectAl2(txtNro_two.Text, txtSer_two.Text)

        For Each row As DataRow In dt.Rows
            txtctct_two.Text = IIf(IsDBNull(row("CLIENTE")), "", row("CLIENTE"))
            'ctct = IIf(IsDBNull(row("RUC")), "", row("RUC"))
            'tipo = IIf(IsDBNull(row("t_doc_Ref")), "", row("t_doc_ref"))
        Next


        DataGridView1.Rows.Clear()
        If txtNro_two.Text <> "" And txtSer_two.Text <> "" And txtctct_two.Text <> Nothing Then
            GetCmb("NOM_ART", "ART_COD", dt, ComboBox2)


            'ElseIf txtctct_two.Text = Nothing Then
            '    ComboBox2.DataSource = Nothing
            '    ComboBox2.Items.Clear()
            '    Button3.Enabled = False
            '    Button4.Enabled = False
            '    TextBox2.Text = ""
            '    txtNro_EnvTwo.Text = ""
            '    txtMedida.Text = ""
            '    txtFecEmi.Text = ""
            'Else
            '    Button3.Enabled = False
            '    Button4.Enabled = False
        End If
        ' twoEst = "N"
        ' cmbEst.SelectedIndex = 0
        ' Button1.Enabled = True
        ' txt_nro_doc_ref.Text = txtNro_two.Text
        tsbimprimir.Enabled = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim ok As String
        Dim int As String = 0
        Dim int1 As String = 0
        TextBox2.Text = ""
        txtNro_EnvTwo.Text = ""
        txtMedida.Text = ""
        txtFecEmi.Text = ""
        DataGridView1.Rows.Clear()
        If ComboBox2.ValueMember <> "" And ComboBox2.Text <> Nothing And ComboBox2.SelectedIndex >= 0 Then

            Dim dt As DataTable
            Dim ELALBARANBL As New ELALBARANBL

            If rEst = "N" Then



                ok = ELALBARANBL.SelectOk(txtNro_two.Text, txtSer_two.Text, ComboBox2.Text)
                If ok = Nothing Or ok = "A" Or rEst = "M" Then
                    dt = ELALBARANBL.SelectArt(txtNro_two.Text, txtSer_two.Text, ComboBox2.Text)
                    For Each ro As DataRow In dt.Rows
                        txtctct_two.Text = IIf(IsDBNull(ro("CLIENTE")), "", ro("CLIENTE"))
                        txtNro_EnvTwo.Text = IIf(IsDBNull(ro("CANTIDAD")), "", ro("CANTIDAD"))
                        txtMedida.Text = IIf(IsDBNull(ro("MEDIDA")), "", ro("MEDIDA"))
                        txtFecEmi.Text = IIf(IsDBNull(ro("FEC_GENE")), "", ro("FEC_GENE"))
                        TextBox2.Text = IIf(IsDBNull(ro("NOM_ART")), "", ro("NOM_ART"))
                        TextBox1.Text = IIf(IsDBNull(ro("orden_compra")), "", ro("orden_compra"))
                        TextBox3.Text = IIf(IsDBNull(ro("CANT_CAJA")), "", ro("CANT_CAJA"))
                        'TextBox4.Text = 6


                    Next
                    dt = ELALBARANBL.SelectDet(txtNro_two.Text, txtSer_two.Text, ComboBox2.Text)

                    For Each row As DataRow In dt.Rows
                        DataGridView1.Rows.Add(
                                     IIf(IsDBNull(row("LOTE")), "", row("LOTE")),
                                     IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                     IIf(IsDBNull(row("TURNO")), "", row("TURNO")),
                                     IIf(IsDBNull(row("FEC_PRO")), "", row("FEC_PRO")))

                        DataGridView1.Rows(int).Cells("FEC_VEN").Value = DateAdd("yyyy", 3, DataGridView1.Rows(int).Cells("FEC_PRO").Value)
                        DataGridView1.Rows(int).Cells("CANTIDAD").Value = Val(Val(DataGridView1.Rows(int).Cells("CANTIDAD").Value) * Val(1000))
                        If DataGridView1.Rows(int).Cells("TURNO").Value = "A" Then
                            DataGridView1.Rows(int).Cells("TURNO").Value = "DIA"
                        ElseIf DataGridView1.Rows(int).Cells("TURNO").Value = "B" Then
                            DataGridView1.Rows(int).Cells("TURNO").Value = "NOCHE"
                        End If
                        If Val(Val(DataGridView1.Rows(int).Cells("CANTIDAD").Value) / Val(TextBox3.Text)) <= 6 Then
                            DataGridView1.Rows(int).Cells("PAQBAS").Value = Val(Val(DataGridView1.Rows(int).Cells("CANTIDAD").Value) / Val(TextBox3.Text))
                            DataGridView1.Rows(int).Cells("PAQALT").Value = 1
                            DataGridView1.Rows(int).Cells("PAQPAL").Value = Val(Val(DataGridView1.Rows(int).Cells("CANTIDAD").Value) / Val(TextBox3.Text))
                            DataGridView1.Rows(int).Cells("UNIPAQ").Value = Val(TextBox3.Text)
                            DataGridView1.Rows(int).Cells("UNIPAL").Value = DataGridView1.Rows(int).Cells("CANTIDAD").Value 'Val(Val(DataGridView1.Rows(int).Cells("PAQPAL").Value) * Val(TextBox3.Text))
                        Else
                            DataGridView1.Rows(int).Cells("PAQBAS").Value = 6
                            DataGridView1.Rows(int).Cells("PAQALT").Value = CInt(Math.Ceiling(Val(DataGridView1.Rows(int).Cells("CANTIDAD").Value / Val(TextBox3.Text)) / 6))
                            DataGridView1.Rows(int).Cells("PAQPAL").Value = CInt(Math.Ceiling(Val(DataGridView1.Rows(int).Cells("CANTIDAD").Value / Val(TextBox3.Text))))

                            DataGridView1.Rows(int).Cells("UNIPAQ").Value = Val(TextBox3.Text)
                            DataGridView1.Rows(int).Cells("UNIPAL").Value = DataGridView1.Rows(int).Cells("CANTIDAD").Value 'Val(Val(DataGridView1.Rows(int).Cells("PAQPAL").Value) * Val(TextBox3.Text))
                        End If
                        int = int + 1
                    Next
                    Button1.Enabled = True
                    tsbimprimir.Enabled = True
                ElseIf ok = "H" Then
                    MsgBox("Articulo Existente", MsgBoxStyle.Information)
                    ComboBox2.SelectedIndex = -1

                    Button1.Enabled = False
                    tsbimprimir.Enabled = False
                End If
            ElseIf rEst = "M" Then

                dt = ELALBARANBL.SelectArt(txtNro_two.Text, txtSer_two.Text, ComboBox2.Text)
                For Each ro As DataRow In dt.Rows
                    txtctct_two.Text = IIf(IsDBNull(ro("CLIENTE")), "", ro("CLIENTE"))
                    txtNro_EnvTwo.Text = IIf(IsDBNull(ro("CANTIDAD")), "", ro("CANTIDAD"))
                    txtMedida.Text = IIf(IsDBNull(ro("MEDIDA")), "", ro("MEDIDA"))
                    txtFecEmi.Text = IIf(IsDBNull(ro("FEC_GENE")), "", ro("FEC_GENE"))
                    TextBox2.Text = IIf(IsDBNull(ro("NOM_ART")), "", ro("NOM_ART"))
                    TextBox1.Text = IIf(IsDBNull(ro("orden_compra")), "", ro("orden_compra"))
                    TextBox3.Text = IIf(IsDBNull(ro("CANT_CAJA")), "", ro("CANT_CAJA"))
                    'TextBox4.Text = 6


                Next


                dt = ELALBARANBL.SelectAl4(txtNro_two.Text, txtSer_two.Text, ComboBox2.Text)

                For Each row As DataRow In dt.Rows
                    DataGridView1.Rows.Add(
                                         IIf(IsDBNull(row("LOTE")), "", row("LOTE")),
                                         IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),
                                         IIf(IsDBNull(row("TURNO")), "", row("TURNO")),
                                         IIf(IsDBNull(row("FEC_PRO")), "", row("FEC_PRO")),
                                         IIf(IsDBNull(row("FEC_VEN")), "", row("FEC_VEN")),
                                         IIf(IsDBNull(row("PAQBAS")), "", row("PAQBAS")),
                                         IIf(IsDBNull(row("PAQALT")), "", row("PAQALT")),
                                         IIf(IsDBNull(row("PAQPAL")), "", row("PAQPAL")),
                                         IIf(IsDBNull(row("UNIPAQ")), "", row("UNIPAQ")),
                                         IIf(IsDBNull(row("UNIPAL")), "", row("UNIPAL")),
                                         IIf(IsDBNull(row("NUMPAL")), "", row("NUMPAL")))

                    If DataGridView1.Rows(int).Cells("TURNO").Value = "A" Then
                        DataGridView1.Rows(int).Cells("TURNO").Value = "DIA"
                    ElseIf DataGridView1.Rows(int).Cells("TURNO").Value = "B" Then
                        DataGridView1.Rows(int).Cells("TURNO").Value = "NOCHE"
                    End If

                    TextBox14.Text = IIf(IsDBNull(row("SER_DOC")), "", row("SER_DOC"))
                    txtnumero.Text = IIf(IsDBNull(row("NRO_DOC")), "", row("NRO_DOC"))
                    If IIf(IsDBNull(row("EST")), "", row("EST")) = "H" Then
                        cmbEst.SelectedIndex = 0
                        Button1.Enabled = True
                        tsbimprimir.Enabled = True
                    ElseIf IIf(IsDBNull(row("EST")), "", row("EST")) = "A" Then
                        cmbEst.SelectedIndex = 1
                        Button1.Enabled = False
                        tsbimprimir.Enabled = False
                    End If

                    int = int + 1
                Next
                If int = 0 Then
                    MsgBox("Articulo no Existente", MsgBoxStyle.Information)
                    Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MessageBox.Show("Desea Imprimir",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim est As String

        If OkData() = False Then
            Exit Sub
        End If

        Dim nro As String
        Dim ELALBARANBE As New ELALBARANBE

        ELALBARANBE.T_DOC_REF = "09"
        ELALBARANBE.SER_DOC_REF = txtSer_two.Text
        ELALBARANBE.NRO_DOC_REF = txtNro_two.Text

        If flagAccion = "N" Then
            nro = ELALBARANBL.LastCodigo(txtnumero.Text)
            If nro.Length = 1 Then
                txtnumero.Text = "000000" & nro
            ElseIf nro.Length = 2 Then
                txtnumero.Text = "00000" & nro
            ElseIf nro.Length = 3 Then
                txtnumero.Text = "0000" & nro
            ElseIf nro.Length = 4 Then
                txtnumero.Text = "000" & nro
            ElseIf nro.Length = 5 Then
                txtnumero.Text = "00" & nro
            ElseIf nro.Length = 6 Then
                txtnumero.Text = "0" & nro
            ElseIf nro.Length = 7 Then
                txtnumero.Text = nro
            End If
        End If

        ELALBARANBE.SER_DOC = TextBox14.Text
        ELALBARANBE.NRO_DOC = txtnumero.Text

        ELALBARANBE.NUMPEDIDO = TextBox1.Text
        ELALBARANBE.ART_COD = ComboBox2.Text
        'ELALBARANBE.CANTIDAD = txtNro_EnvTwo.Text
        'ELALBARANBE.FEC_PRO = txtFecEmi.Text
        'ELALBARANBE.FEC_VEN =
        'ELALBARANBE.TURNO =
        'ELALBARANBE.LOTE =
        ELALBARANBE.CANT_CAJA = TextBox3.Text
        If cmbEst.SelectedIndex = 0 Then
            ELALBARANBE.EST = "H"
        ElseIf cmbEst.SelectedIndex = 1 Then
            ELALBARANBE.EST = "A"
            rEst = "A"
        End If

        gsError = ELALBARANBL.SaveRow(ELALBARANBE, rEst, DataGridView1)

        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

        If cmbEst.SelectedIndex = 1 Then
            Button1.Enabled = False
            tsbimprimir.Enabled = False

            rEst = "M"
            Dispose()
        ElseIf gsError = "OK" Then
            gsRptArgs = {}
            ReDim gsRptArgs(2)
            gsRptArgs(0) = txtSer_two.Text
            gsRptArgs(1) = txtNro_two.Text
            gsRptArgs(2) = ComboBox2.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTALBARAN_PALLETS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

            gsRptArgs = {}
            ReDim gsRptArgs(2)
            gsRptArgs(0) = txtSer_two.Text
            gsRptArgs(1) = txtNro_two.Text
            gsRptArgs(2) = ComboBox2.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTALBARAN_PALLETS_PK.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()

            Dispose()
        End If
    End Sub
    Private Function OkData() As Boolean

        p = 0
        If ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Seleccionar Articulo")
            Return False
        End If
        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells("NUMPAL").Value = "" Then
                p = p + 1
            End If
            If p <> 0 Then
                MsgBox("Ingrese los numeros de Paleta")
                Return False
            End If
        Next
        Return True
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim M As String

        If DateTimePicker1.Value = dtpfecha.Value Then
            MsgBox("La Fecha de Produccion no Debe ser igual a la de Vencimiento")
            Exit Sub
        End If

        M = DataGridView1.CurrentRow.Index
        DataGridView1.Rows(M).Cells("FEC_VEN").Value = dtpfecha.Value

        DataGridView1.Rows(M).Cells("PAQBAS").Value = TextBox4.Text
        DataGridView1.Rows(M).Cells("PAQALT").Value = TextBox5.Text
        DataGridView1.Rows(M).Cells("PAQPAL").Value = TextBox6.Text

        DataGridView1.Rows(M).Cells("UNIPAQ").Value = TextBox7.Text
        DataGridView1.Rows(M).Cells("UNIPAL").Value = TextBox8.Text
        DataGridView1.Rows(M).Cells("NUMPAL").Value = TextBox9.Text


        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
    End Sub

    '   Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
    '       Dim M As String
    '       M = DataGridView1.CurrentRow.Index
    '       If Button3.Text = "Separar" Then
    '           TextBox10.Text = DataGridView1.Rows(M).Cells("LOTE1").Value
    '           DateTimePicker1.Value = DataGridView1.Rows(M).Cells("FEC_PRO").Value
    '           dtpfecha.Value = DataGridView1.Rows(M).Cells("FEC_VEN").Value
    '
    '           TextBox4.Text = DataGridView1.Rows(M).Cells("PAQBAS").Value
    '           TextBox5.Text = DataGridView1.Rows(M).Cells("PAQALT").Value
    '           TextBox6.Text = DataGridView1.Rows(M).Cells("PAQPAL").Value
    '
    '           TextBox7.Text = DataGridView1.Rows(M).Cells("UNIPAQ").Value
    '           TextBox8.Text = DataGridView1.Rows(M).Cells("UNIPAL").Value
    '           TextBox9.Text = DataGridView1.Rows(M).Cells("NUMPAL").Value
    '           TextBox12.Text = ""
    '       ElseIf Button3.Text = "Cancelar" Then
    '
    '           TextBox4.Text = ""
    '           TextBox5.Text = ""
    '           TextBox6.Text = ""
    '
    '           TextBox7.Text = ""
    '           TextBox8.Text = ""
    '           TextBox9.Text = ""
    '           TextBox12.Text = DataGridView1.Rows(M).Cells("UNIPAQ").Value
    '       End If
    '   End Sub

    '   Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '       Dim M As String
    '       M = DataGridView1.CurrentRow.Index
    '       If Button3.Text = "Separar" Then
    '           TextBox10.Text = DataGridView1.Rows(M).Cells("LOTE1").Value
    '           DateTimePicker1.Value = DataGridView1.Rows(M).Cells("FEC_PRO").Value
    '           dtpfecha.Value = DataGridView1.Rows(M).Cells("FEC_VEN").Value
    '
    '           TextBox4.Text = DataGridView1.Rows(M).Cells("PAQBAS").Value
    '           TextBox5.Text = DataGridView1.Rows(M).Cells("PAQALT").Value
    '           TextBox6.Text = DataGridView1.Rows(M).Cells("PAQPAL").Value
    '
    '           TextBox7.Text = DataGridView1.Rows(M).Cells("UNIPAQ").Value
    '           TextBox8.Text = DataGridView1.Rows(M).Cells("UNIPAL").Value
    '           TextBox9.Text = DataGridView1.Rows(M).Cells("NUMPAL").Value
    '           TextBox12.Text = ""
    '       ElseIf Button3.Text = "Cancelar" Then
    '
    '           TextBox4.Text = ""
    '           TextBox5.Text = ""
    '           TextBox6.Text = ""
    '
    '           TextBox7.Text = ""
    '           TextBox8.Text = ""
    '           TextBox9.Text = ""
    '           TextBox12.Text = DataGridView1.Rows(M).Cells("UNIPAQ").Value
    '       End If
    '
    '   End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim M As String

        If Button3.Text = "Separar" Then
            If DateTimePicker1.Value = dtpfecha.Value Then
                MsgBox("La Fecha de Produccion no Debe ser igual a la de Vencimiento")
                Exit Sub
            End If

            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""

            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""

            Modificar.Enabled = False

            Button3.Text = "Cancelar"
            M = DataGridView1.CurrentRow.Index
            TextBox13.Text = DataGridView1.Rows(M).Cells("LOTE1").Value
            TextBox12.Text = DataGridView1.Rows(M).Cells("PAQPAL").Value
            'DataGridView1.Rows(M).Cells("FEC_VEN").Value = dtpfecha.Value
            '
            'DataGridView1.Rows(M).Cells("PAQBAS").Value = TextBox4.Text
            'DataGridView1.Rows(M).Cells("PAQALT").Value = TextBox5.Text
            'DataGridView1.Rows(M).Cells("PAQPAL").Value = TextBox6.Text

            'TextBox7.Text = DataGridView1.Rows(M).Cells("UNIPAQ").Value
            '    DataGridView1.Rows(M).Cells("UNIPAL").Value = TextBox8.Text
            'DataGridView1.Rows(M).Cells("NUMPAL").Value = TextBox9.Text

            TextBox11.Enabled = True
            Button4.Enabled = True


        ElseIf Button3.Text = "Cancelar" Then
            Button3.Text = "Separar"
            Modificar.Enabled = True
            TextBox13.Text = ""
            TextBox12.Text = ""
            TextBox11.Text = ""
            TextBox11.Enabled = False
            Button4.Enabled = False

        End If

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        '    Dim M As String
        '    M = DataGridView1.CurrentRow.Index
        '    If Button3.Text = "Separar" Then
        '        TextBox10.Text = DataGridView1.Rows(M).Cells("LOTE1").Value
        '        DateTimePicker1.Value = DataGridView1.Rows(M).Cells("FEC_PRO").Value
        '        dtpfecha.Value = DataGridView1.Rows(M).Cells("FEC_VEN").Value
        '
        '        TextBox4.Text = DataGridView1.Rows(M).Cells("PAQBAS").Value
        '        TextBox5.Text = DataGridView1.Rows(M).Cells("PAQALT").Value
        '        TextBox6.Text = DataGridView1.Rows(M).Cells("PAQPAL").Value
        '
        '        TextBox7.Text = DataGridView1.Rows(M).Cells("UNIPAQ").Value
        '        TextBox8.Text = DataGridView1.Rows(M).Cells("UNIPAL").Value
        '        TextBox9.Text = DataGridView1.Rows(M).Cells("NUMPAL").Value
        '        TextBox12.Text = ""
        '        TextBox13.Text = ""
        '    ElseIf Button3.Text = "Cancelar" Then
        '
        '        TextBox4.Text = ""
        '        TextBox5.Text = ""
        '        TextBox6.Text = ""
        '
        '        TextBox7.Text = ""
        '        TextBox8.Text = ""
        '        TextBox9.Text = ""
        '        TextBox12.Text = DataGridView1.Rows(M).Cells("PAQPAL").Value
        '        TextBox13.Text = DataGridView1.Rows(M).Cells("LOTE1").Value
        '    End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If TextBox11.Text = "" Then
            Exit Sub
        End If


        Dim M As String
        Dim cant As String = ""
        Dim PAQBAS As String = ""
        Dim PAQALT As String = ""
        M = DataGridView1.CurrentRow.Index
        cant = Val(Val(TextBox11.Text) * Val(TextBox3.Text))

        If Val(Val(cant) / Val(TextBox3.Text)) <= 6 Then
            PAQBAS = Val(cant) / Val(TextBox3.Text)
            PAQALT = 1
            DataGridView1.Rows(M).Cells("UNIPAL").Value = Val(Val(DataGridView1.Rows(M).Cells("PAQPAL").Value) * Val(TextBox3.Text))
        Else
            PAQBAS = 6
            PAQALT = CInt(Math.Ceiling(Val(cant / Val(TextBox3.Text)) / 6))
            'DataGridView1.Rows(M).Cells("PAQPAL").Value = Val(DataGridView1.Rows(M).Cells("CANTIDAD").Value / Val(TextBox3.Text))
            DataGridView1.Rows(M).Cells("UNIPAL").Value = Val(Val(DataGridView1.Rows(M).Cells("PAQPAL").Value) * Val(TextBox3.Text))
        End If

        ' If  / Val(TextBox3.Text)) <= 6 Then
        '     DataGridView1.Rows(Int).Cells("PAQBAS").Value = Val(Val(DataGridView1.Rows(Int).Cells("CANTIDAD").Value) / Val(TextBox3.Text))
        '     DataGridView1.Rows(Int).Cells("PAQALT").Value = 1
        '     DataGridView1.Rows(Int).Cells("PAQPAL").Value = Val(Val(DataGridView1.Rows(Int).Cells("CANTIDAD").Value) / Val(TextBox3.Text))
        '     DataGridView1.Rows(Int).Cells("UNIPAQ").Value = Val(TextBox3.Text)
        '     DataGridView1.Rows(Int).Cells("UNIPAL").Value = Val(Val(DataGridView1.Rows(Int).Cells("PAQPAL").Value) * Val(TextBox3.Text))
        ' Else
        '     DataGridView1.Rows(Int).Cells("PAQBAS").Value = 6
        '     DataGridView1.Rows(Int).Cells("PAQALT").Value = CInt(Math.Ceiling(Val(DataGridView1.Rows(Int).Cells("CANTIDAD").Value / Val(TextBox3.Text)) / 6))
        '     DataGridView1.Rows(Int).Cells("PAQPAL").Value = Val(DataGridView1.Rows(Int).Cells("CANTIDAD").Value / Val(TextBox3.Text))
        '
        '     DataGridView1.Rows(Int).Cells("UNIPAQ").Value = Val(TextBox3.Text)
        '     DataGridView1.Rows(Int).Cells("UNIPAL").Value = Val(Val(DataGridView1.Rows(Int).Cells("PAQPAL").Value) * Val(TextBox3.Text))
        ' End If


        DataGridView1.Rows.Add(DataGridView1.Rows(M).Cells("LOTE1").Value,        '0
                               cant,                                              '1
                               DataGridView1.Rows(M).Cells("TURNO").Value,        '2
                               DataGridView1.Rows(M).Cells("FEC_PRO").Value,      '3
                               DataGridView1.Rows(M).Cells("FEC_VEN").Value,      '4
                               PAQBAS,                                            '5
                               PAQALT,                                            '6
                               TextBox11.Text,                                    '7
                               Val(TextBox3.Text),                                '8
                               (Val(TextBox11.Text) * Val(TextBox3.Text)),        '9
                               "")                                                '10


        DataGridView1.Rows(M).Cells("CANTIDAD").Value = Val(DataGridView1.Rows(M).Cells("CANTIDAD").Value) - cant
        DataGridView1.Rows(M).Cells("PAQPAL").Value = Val(DataGridView1.Rows(M).Cells("PAQPAL").Value) - Val(TextBox11.Text)


        If Val(Val(DataGridView1.Rows(M).Cells("CANTIDAD").Value) / Val(TextBox3.Text)) <= 6 Then
            DataGridView1.Rows(M).Cells("PAQBAS").Value = Val(Val(DataGridView1.Rows(M).Cells("CANTIDAD").Value) / Val(TextBox3.Text))
            DataGridView1.Rows(M).Cells("PAQALT").Value = 1
            DataGridView1.Rows(M).Cells("UNIPAL").Value = Val(Val(DataGridView1.Rows(M).Cells("PAQPAL").Value) * Val(TextBox3.Text))
        Else
            DataGridView1.Rows(M).Cells("PAQBAS").Value = 6
            DataGridView1.Rows(M).Cells("PAQALT").Value = CInt(Math.Ceiling(Val(DataGridView1.Rows(M).Cells("CANTIDAD").Value / Val(TextBox3.Text)) / 6))
            DataGridView1.Rows(M).Cells("UNIPAL").Value = DataGridView1.Rows(M).Cells("CANTIDAD").Value 'Val(Val(DataGridView1.Rows(M).Cells("PAQPAL").Value) * Val(TextBox3.Text))
        End If
        ' -- - -- -- - - - -- - - 
        Modificar.Enabled = True
        TextBox11.Enabled = False
        Button4.Enabled = False
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        Button3.Text = "Separar"
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()
        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)

        End If
        Select Case sFunc
            Case "Print"
                Button1_Click(sender, e)
            Case "anular"
                MsgBox("Este documento no puede anulado")
            Case "exit"
                Dispose()
                Exit Sub
        End Select
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim M As String
        M = DataGridView1.CurrentRow.Index
        If Button3.Text = "Separar" Then
            TextBox10.Text = DataGridView1.Rows(M).Cells("LOTE1").Value
            DateTimePicker1.Value = DataGridView1.Rows(M).Cells("FEC_PRO").Value
            dtpfecha.Value = DataGridView1.Rows(M).Cells("FEC_VEN").Value

            TextBox4.Text = DataGridView1.Rows(M).Cells("PAQBAS").Value
            TextBox5.Text = DataGridView1.Rows(M).Cells("PAQALT").Value
            TextBox6.Text = DataGridView1.Rows(M).Cells("PAQPAL").Value

            TextBox7.Text = DataGridView1.Rows(M).Cells("UNIPAQ").Value
            TextBox8.Text = DataGridView1.Rows(M).Cells("UNIPAL").Value
            TextBox9.Text = DataGridView1.Rows(M).Cells("NUMPAL").Value
            TextBox12.Text = ""
            TextBox13.Text = ""
        ElseIf Button3.Text = "Cancelar" Then

            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""

            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox12.Text = DataGridView1.Rows(M).Cells("PAQPAL").Value
            TextBox13.Text = DataGridView1.Rows(M).Cells("LOTE1").Value
        End If
    End Sub
End Class