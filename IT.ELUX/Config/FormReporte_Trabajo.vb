Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormReporte_Trabajo
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private REPORTE_TRABAJOBL As New REPORTE_TRABAJOBL
    Private SOLMATERIALESBL As New SOLMATERIALESBL
    Private ELTBDETSTIEMBL As New ELTBDETSTIEMBL
    Private gpCaption As String
    Private bprimero As Boolean
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        Dim rEst As String
        dtUsuario = REPORTE_TRABAJOBL.SelectRow(txtt_doc.Text, sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmbserie.Text = sSDoc
            txtnumero.Text = sNDoc
            rEst = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))
            If rEst = "H" Then
                cmbestado.SelectedIndex = 0
            Else
                cmbestado.SelectedIndex = 1
            End If
            dtpfec_gene.Value = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            txtdni.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            cmbdni.SelectedValue = txtdni.Text
            txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
            cmbc_costo.SelectedValue = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
            cmb_linea.SelectedValue = IIf(IsDBNull(Registro("LINEA")), "", Registro("LINEA"))
            cmbTurno.SelectedIndex = IIf(IsDBNull(Registro("TURNO")), "", Registro("TURNO"))
            lbluser.Text = IIf(IsDBNull(Registro("USUARIO_RP")), "", Registro("USUARIO_RP"))
        Next
    End Sub
    Private Sub FormReporte_Trabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Dim dtUsuario As DataTable
        Dim nro As String
        Me.Text = "HORAS DE MANTENIMIENTO"
        bprimero = True

        dgvdiaper.Columns.Add("Nro", "N°")                                 '0
        dgvdiaper.Columns.Add("T_DOC_REF", "TIPO")                         '1
        dgvdiaper.Columns.Add("SER_DOC_REF", "SERIE")                      '2
        dgvdiaper.Columns.Add("NRO_DOC_REF", "NRO.OM")                     '3
        dgvdiaper.Columns.Add("CCO_COD", "CENTRO DE COSTO")                '4
        dgvdiaper.Columns.Add("LINEA", "AREA DE TRABAJO")                  '5
        dgvdiaper.Columns.Add("ART_COD", "CODIGO DE ACTIVO")               '6
        dgvdiaper.Columns.Add("DES_ACT", "DESCRIPCION DE ACTIVO")          '7
        dgvdiaper.Columns.Add("DESC_TRA", "DESCRIPCION DE TRABAJO")        '8
        dgvdiaper.Columns.Add("HORA_INICIO", "INICIO")                     '9
        dgvdiaper.Columns.Add("HORA_FINAL", "FINAL")                       '10
        dgvdiaper.Columns.Add("NUM_HORA", "Num. Hora")                     '11
        dgvdiaper.Columns.Add("FEC_INICIO", "Fec. Inicio")                 '12
        dgvdiaper.Columns.Add("FEC_TERMINO", "Fec. Termino")               '13
        dgvdiaper.Columns.Add("TIP_COD", "CODIGO DE TIPO")                 '14
        dgvdiaper.Columns.Add("TIPO", "TIPO")                              '15
        dgvdiaper.Columns.Add("FINALIZAR", "FINALIZAR")                    '16
        dgvdiaper.Columns.Add("INTERVENCION", "INTERVENCION")              '17

        dt = GUIAALMACENBL.SelectPer
        GetCmb("cod", "nombre", dt, cmbdni)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                txtt_doc.Text = "HMANT"
                dtUsuario = REPORTE_TRABAJOBL.SelectUsuario(gsUser)
                For Each Registro As DataRow In dtUsuario.Rows
                    txtdni.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
                    cmbdni.SelectedValue = txtdni.Text
                    cmbc_costo.SelectedValue = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                    txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                    'cmb_linea.SelectedValue = IIf(IsDBNull(Registro("LINEA")), "", Registro("LINEA"))
                Next
                dt = ELTBDETSTIEMBL.gArea(cmbc_costo.SelectedValue)
                GetCmb("cod", "nom", dt, cmb_linea)
                cmbt_doc.SelectedIndex = 0
                cmbserie.SelectedItem = FormMain.cmbaño.Text
                cmbTurno.SelectedIndex = 0
                nro = REPORTE_TRABAJOBL.SelectNro(txtt_doc.Text, cmbserie.Text)
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
                cmbestado.SelectedIndex = 0
            Case 1
                flagAccion = "M"
                txtt_doc.Text = "HMANT"
                cmbt_doc.SelectedIndex = 0
                bprimero = False
                GetData(gsCode)
                dt = REPORTE_TRABAJOBL.SelectRowDet(txtt_doc.Text, sSDoc, sNDoc)
                For Each row As DataRow In dt.Rows
                    dgvdiaper.Rows.Add(IIf(IsDBNull(row("SEQ")), "", row("SEQ")),                                   '0
                                          IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),                  '1
                                          IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),              '2
                                          IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),              '3
                                          IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),                        '4
                                          IIf(IsDBNull(row("LINEA")), "", row("LINEA")),                            '5
                                          IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),                        '6
                                          IIf(IsDBNull(row("DES_ACT")), "", row("DES_ACT")),                        '7
                                          IIf(IsDBNull(row("DESC_TRA")), "", row("DESC_TRA")),                      '8
                                          IIf(IsDBNull(row("HORA_INICIO")), "", row("HORA_INICIO")),                '9
                                          IIf(IsDBNull(row("HORA_FINAL")), "", row("HORA_FINAL")),                  '10
                                          IIf(IsDBNull(row("NUM_HORA")), "", row("NUM_HORA")),                      '11
                                          IIf(IsDBNull(row("FEC_INICIO")), "", row("FEC_INICIO")),                  '12
                                          IIf(IsDBNull(row("FEC_TERMINO")), "", row("FEC_TERMINO")),                '13
                                          IIf(IsDBNull(row("TIP_COD")), "", row("TIP_COD")),                        '14
                                          IIf(IsDBNull(row("TIPO")), "", row("TIPO")),                              '15
                                          IIf(IsDBNull(row("COD_EST")), "", row("COD_EST")),                        '16
                                          IIf(IsDBNull(row("INTERVENCION")), "", row("INTERVENCION")))              '17
                Next
                dgvdiaper.Refresh()
        End Select
        Dim ELTBSTIEMBL As New ELTBSTIEMBL
        If flagAccion = "M" Then
            If gsUser = "SISTEMA" Or gsUser = "RCONISLLA" Then
            Else
                'nro = ELTBSTIEMBL.OK_CCO_COD(gsUser)
                If lbluser.Text = gsCodUsr Then
                Else
                    If lbluser.Text <> gsCodUsr Then
                        MsgBox("Usted no ah ingresado este Documento")
                        Dispose()
                        Exit Sub
                    End If
                End If
            End If
        End If
        dgvdiaper.Columns("Nro").Visible = False
        dgvdiaper.Columns("T_DOC_REF").Visible = False
        dgvdiaper.Columns("SER_DOC_REF").Visible = False
        dgvdiaper.Columns("CCO_COD").Visible = False
        dgvdiaper.Columns("ART_COD").Visible = False
        dgvdiaper.Columns("NUM_HORA").Visible = False
        dgvdiaper.Columns("FEC_INICIO").Visible = False
        dgvdiaper.Columns("FEC_TERMINO").Visible = False
        dgvdiaper.Columns("TIP_COD").Visible = False
        dgvdiaper.Columns("FINALIZAR").Visible = False
        dgvdiaper.Columns("INTERVENCION").Visible = False
        bprimero = False
    End Sub
    Private Sub txtdni_LostFocus(sender As Object, e As EventArgs) Handles txtdni.LostFocus
        If txtdni.Text = "" Then
            cmbdni.SelectedIndex = -1
        Else
            cmbdni.SelectedValue = txtdni.Text
        End If
    End Sub
    Private Sub cmbdni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdni.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbdni.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtdni.Text = cmbdni.SelectedValue
    End Sub

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        '  If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
        '      e.Handled = True
        '  End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sBusAlm = "36"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gArt <> Nothing Then
            txtdni.Text = gArt
            cmbdni.SelectedValue = gArt
            txtdni.Select()
            gArt = Nothing
        Else
            gArt = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        '   Dim dt As DataTable
        '   Dim rg As DataRow
        '   dgvdiaper.Rows.Clear()
        '
        '   Dim a As New Integer
        '   dt = REPORTE_TRABAJOBL.SelectDia(txtdni.Text, cmbc_costo.SelectedValue, dtpfecha.Text, cmb_linea.SelectedValue, flagAccion)
        '   For Each rg In dt.Rows
        '       a = a + 1
        '       dgvdiaper.Rows.Add((a),                                                            '0
        '                          IIf(IsDBNull(rg("LINEA")), "", rg("LINEA")),                    '1
        '                          IIf(IsDBNull(rg("AREA")), "", rg("AREA")),                      '2
        '                          IIf(IsDBNull(rg("ACTIVO")), "", rg("ACTIVO")),                  '3
        '                          IIf(IsDBNull(rg("DES_ACT")), "", rg("DES_ACT")),                '4
        '                          IIf(IsDBNull(rg("COD_ACT")), "", rg("COD_ACT")),                '5
        '                          IIf(IsDBNull(rg("ACT_REALIZAR")), "", rg("ACT_REALIZAR")),      '6
        '                          IIf(IsDBNull(rg("HORA_INICIO")), "", rg("HORA_INICIO")),        '7
        '                          IIf(IsDBNull(rg("HORA_TERMINO")), "", rg("HORA_TERMINO")),      '8
        '                          IIf(IsDBNull(rg("COD_TIP")), "", rg("COD_TIP")),                '9
        '                          IIf(IsDBNull(rg("TIP_TRA")), "", rg("TIP_TRA")))                '10
        '   Next
    End Sub

    Private Sub FormReporte_Trabajo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
    End Sub
    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()
        If Mid(sFunc, 5, 4) = "func" Then
            sFunc = Mid(sFunc, 10)
        End If
        Select Case sFunc
            Case "save"
                SaveData()
                Exit Sub
            Case "exit"
                Dispose()
                Exit Sub
            Case "Print"
                ReDim gsRptArgs(2)
                gsRptArgs(0) = txtt_doc.Text
                gsRptArgs(1) = cmbserie.Text
                gsRptArgs(2) = txtnumero.Text
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTELTBMTIEM_SELROW.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
                Exit Sub
            Case "anular"
                If flagAccion = "N" Then
                    MessageBox.Show("No se puede anular")
                    Exit Sub
                End If
                If MessageBox.Show("Desea anular el documento",
                     "Anular documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim REPORTE_TRABAJOBE As New REPORTE_TRABAJOBE
                Dim REPORTE_DETTRABAJOBE As New REPORTE_DETTRABAJOBE

                REPORTE_TRABAJOBE.T_DOC_REF = txtt_doc.Text
                REPORTE_TRABAJOBE.SER_DOC_REF = cmbserie.Text
                REPORTE_TRABAJOBE.NRO_DOC_REF = txtnumero.Text

                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = REPORTE_TRABAJOBL.SaveRow(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, "A", dgvdiaper)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)

                    tsbGrabar.Enabled = False
                    tsbimprimir.Enabled = False
                    'Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
                Dispose()
                Exit Sub
        End Select
    End Sub
    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                       gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If OkData() = False Then
            Exit Sub
        End If

        Dim nro As String
        Dim REPORTE_TRABAJOBE As New REPORTE_TRABAJOBE
        If flagAccion = "N" Then
            nro = REPORTE_TRABAJOBL.SelectNro(txtt_doc.Text, cmbserie.SelectedItem)
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

        REPORTE_TRABAJOBE.T_DOC_REF = RTrim(txtt_doc.Text)
        REPORTE_TRABAJOBE.SER_DOC_REF = RTrim(cmbserie.Text)
        REPORTE_TRABAJOBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        If cmbestado.SelectedIndex = 0 Then
            REPORTE_TRABAJOBE.EST = "H"
        Else
            REPORTE_TRABAJOBE.EST = "A"
        End If
        REPORTE_TRABAJOBE.FEC_GENE = Date.Now
        REPORTE_TRABAJOBE.PER_COD = txtdni.Text
        REPORTE_TRABAJOBE.FEC_DIA = dtpfec_gene.Value
        REPORTE_TRABAJOBE.CCO_COD = cmbc_costo.SelectedValue
        REPORTE_TRABAJOBE.lINEA = cmb_linea.SelectedValue
        REPORTE_TRABAJOBE.TURNO = cmbTurno.SelectedIndex
        REPORTE_TRABAJOBE.USUARIO_RP = gsCodUsr
        REPORTE_TRABAJOBE.USUARIO_VB = cmbestado.SelectedIndex

        Dim REPORTE_DETTRABAJOBE As New REPORTE_DETTRABAJOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE

        ELMVLOGSBE.log_codusu = gsCodUsr
        gsError = REPORTE_TRABAJOBL.SaveRow(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, flagAccion, dgvdiaper)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError + " " + gsError2
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Function OkData() As Boolean
        Dim q As String = 0
        Dim p As String = 0
        If txtdni.Text = "" Then
            MsgBox("Ingrese un Tecnico", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If cmbTurno.SelectedIndex = -1 Then
            MsgBox("Se debe Seleccionar un Turno")
            cmbTurno.Focus()
            Return False
        End If
        If txtc_costo.Text = Nothing Or cmbc_costo.SelectedIndex = -1 Then
            MsgBox("Se debe Seleccionar un Centro de Costo")
            cmbc_costo.Focus()
            Return False
        End If
        If txt_linea.Text = Nothing Or cmb_linea.SelectedIndex = -1 Then
            MsgBox("Se debe Seleccionar un Centro de Costo")
            cmbc_costo.Focus()
            Return False
        End If
        For i = 0 To dgvdiaper.Rows.Count - 1
            If dgvdiaper.Rows(i).Cells("Hora_Inicio").Value = Nothing Then
                p = p + 1
            End If
            If p <> 0 Then
                MsgBox("Por favor ponga las horas laboradas")
                Return False
            End If
            If dgvdiaper.Rows(i).Cells("TIPO").Value = Nothing Then
                q = q + 1
            End If
            If dgvdiaper.Rows(i).Cells("DESC_TRA").Value = Nothing Then
                q = q + 1
            End If
        Next
        If dgvdiaper.Rows.Count = 0 Then
            MsgBox("Se debe tener registros")
            Return False
        End If
        Return True
    End Function

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
        Dim dt As DataTable
        Try
            dt = ELTBDETSTIEMBL.gArea(cmbc_costo.SelectedValue)
            GetCmb("cod", "nom", dt, cmb_linea)
        Catch ex As Exception
            MsgBox("El centro de costo no cuenta con Area")
        End Try
    End Sub


    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo.SelectedValue = txtc_costo.Text
        If cmbc_costo.SelectedValue = Nothing Then
            txtc_costo.Text = ""
        End If

        Dim dt As DataTable
        Try
            dt = ELTBDETSTIEMBL.gArea(cmbc_costo.SelectedValue)
            GetCmb("cod", "nom", dt, cmb_linea)
        Catch ex As Exception
            MsgBox("El centro de costo no cuenta con Area")
        End Try
        'If cmbc_costo.SelectedIndex > -1 Then
        '    Dim dt As DataTable
        '    Try
        '        dt = ELTBDETSTIEMBL.gArea(cmbc_costo.SelectedValue)
        '        GetCmb("cod", "nom", dt, cmb_linea)
        '    Catch ex As Exception
        '        MsgBox("El centro de costo no cuenta con Area")
        '    End Try
        'End If

    End Sub
    Private Sub cmb_linea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_linea.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Try
            txt_linea.Text = cmb_linea.SelectedValue
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_linea_LostFocus(sender As Object, e As EventArgs) Handles txt_linea.LostFocus
        If txt_linea.Text = "" Then
            cmb_linea.SelectedValue = ""
            Exit Sub
        End If
        cmb_linea.SelectedValue = txt_linea.Text
        If cmb_linea.SelectedValue = Nothing Then
            txt_linea.Text = ""
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        sBusAlm = "3"
        If txtc_costo.TextLength <> 0 Then
            gsCode10 = txtc_costo.Text
            Dim frm As New FormPerHoraOM
            frm.ShowDialog()
            gsCode10 = ""
        Else
            MsgBox("Debe Seleccionar un centro de Costo")
        End If
        Button10.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If dgvdiaper.RowCount > 0 Then
            If dgvdiaper.CurrentRow.Index <> -1 Then
                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("Hora_Inicio").Value = ""
                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("Hora_Final").Value = ""
                'dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("Dif_Hora").Value = ""
                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("Num_Hora").Value = ""
                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("FEC_INICIO").Value = ""
                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("FEC_TERMINO").Value = ""
            End If
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        If dgvdiaper.RowCount > 0 Then
            If dgvdiaper.CurrentRow.Index <> -1 Then
                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("DESC_TRA").Value = ""
                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("DESC_TRA").Value = ""
            End If
        Else
            MsgBox("No hay datos")
        End If

    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If dgvdiaper.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvdiaper.Rows.RemoveAt(dgvdiaper.CurrentRow.Index)
            dgvdiaper.Refresh()
        Else
            MsgBox("No hay datos")
        End If
        Button10.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        If dgvdiaper.RowCount > 0 Then
            If dgvdiaper.CurrentRow.Index <> -1 Then
                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("TIP_COD").Value = ""
                dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("TIPO").Value = ""
            End If
        Else
            MsgBox("No hay datos")
        End If

    End Sub
    Private Sub dtpfec_gene_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_gene.LostFocus

        If dtpfec_gene.Value.Month <> 12 Then
            Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+3).ToShortDateString
            Dim Today As DateTime = DateTime.Now.ToShortDateString
            If DateTime.Compare(dtpini, Today) <= 0 Then
                MsgBox("La fecha de inicio no debe ser más de 2 dias antes a la fecha actual, Si desea Generar el Ingreso favor comuniquese con los jefes de Mantenimiento", MsgBoxStyle.Exclamation)
                dtpfec_gene.Select()
                Exit Sub
            Else
                txtdni.Select()
            End If
        Else
            Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+3).ToShortDateString
            Dim Today As DateTime = DateTime.Now.ToShortDateString
            If DateTime.Compare(dtpini, Today) <= 0 Then
                MsgBox("La fecha de inicio no debe ser más de 2 dias antes a la fecha actual, Si desea Generar el Ingreso favor comuniquese con los jefes de Mantenimiento", MsgBoxStyle.Exclamation)
                dtpfec_gene.Select()
                Exit Sub
            Else
                txtdni.Select()
            End If
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If dgvdiaper.Rows.Count > 0 Then
            If MessageBox.Show("Desea Finalizar el Registro",
                       gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("FINALIZAR").Value = 1

            If dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("FINALIZAR").Value = 1 Then
                Button10.Enabled = False
            Else
                Button10.Enabled = True
            End If
        Else
            MsgBox("No hay datos")
        End If
        Button10.Enabled = False
    End Sub

    Private Sub dgvdiaper_Click(sender As Object, e As EventArgs) Handles dgvdiaper.Click
        If dgvdiaper.Rows.Count > 0 Then
            If dgvdiaper.Rows(dgvdiaper.CurrentRow.Index).Cells("FINALIZAR").Value = Nothing Then
                Button10.Enabled = True
            Else
                Button10.Enabled = False
            End If
        End If
    End Sub
End Class