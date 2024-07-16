Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBSTIEMOM
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ELTBMTIEMBL As New ELTBMTIEMBL
    Private ELTBDETSTIEMBL As New ELTBDETSTIEMBL
    Private gpCaption As String
    Private p As Integer = 0
    Private vb As String
    Private bprimero As Boolean
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Private Sub CleanVar()
        cmbestado.SelectedIndex = -1
    End Sub
    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        dtUsuario = ELTBMTIEMBL.SelectRow(txtt_doc.Text, sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            txtnumero.Text = sNDoc
            cmbserie.Text = sSDoc
            txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
            cmbc_costo.SelectedValue = txtc_costo.Text
            txtdni.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            txtobs.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txtnro_om.Text = IIf(IsDBNull(Registro("NRO_OM")), "", Registro("NRO_OM"))
            cmbdni.SelectedValue = txtdni.Text
            If IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "H" Then
                cmbestado.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "A" Then
                cmbestado.SelectedIndex = 1
            End If
            dtpfec_gene.Value = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            'dtpfec_inicio.Value = dtpfec_gene.Value
            'dtphoragene.Value = dtpfec_inicio.Value
            'dtpfec_termino.Value = dtpfec_gene.Value
            'dtphoratermino.Value = dtpfec_termino.Value
            Label12.Text = IIf(IsDBNull(Registro("USUARIO_RP")), "", Registro("USUARIO_RP"))
            'txtobservacion_rh.Text = IIf(IsDBNull(Registro("OBSERVACIONRH")), "", Registro("OBSERVACIONRH"))
            Dim dt As DataTable
            dt = ELTBDETSTIEMBL.gArea(cmbc_costo.SelectedValue)
            GetCmb("cod", "nom", dt, cmb_linea)
            txt_linea.Text = IIf(IsDBNull(Registro("LINEA")), "", Registro("LINEA"))
            cmb_linea.SelectedValue = txt_linea.Text
            txtobsj.Text = IIf(IsDBNull(Registro("OBSERVACION_TEC")), "", Registro("OBSERVACION_TEC"))
            vb = IIf(IsDBNull(Registro("USUARIO_VB")), "", Registro("USUARIO_VB"))
        Next
    End Sub
    Private Sub FormELTBSTIEMOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Dim nro As String
        bprimero = True
        Me.Text = "HORAS DE OM"
        '-- ------------------------- --
        dt = GUIAALMACENBL.SelectPer
        GetCmb("cod", "nombre", dt, cmbdni)
        '-- ------------------------- --
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        '-- ------------------------- --
        dt = ELTBMTIEMBL.SelectActi
        GetCmb("cod", "nom", dt, cmbactividad)
        '-- ------------------------- --
        'dgvtiemper.Columns.Add("NRO_OM", "Nro.Om")
        dgvtiemper.Columns.Add("Codigo", "Codigo")
        dgvtiemper.Columns.Add("Nombre", "Apellidos y Nombre")
        dgvtiemper.Columns.Add("COD_LINEA", "Area")
        dgvtiemper.Columns.Add("Cod_Realizar", "Cod Actividad")
        dgvtiemper.Columns.Add("Act_Realizar", "Actividad Realizar")
        dgvtiemper.Columns.Add("Hora_Inicio", "Hora Inicio")
        dgvtiemper.Columns.Add("Hora_Final", "Hora Final")
        dgvtiemper.Columns.Add("USUARIO_RP", "USUARIO_RP")
        dgvtiemper.Columns.Add("Dif_Hora", "Dif. Hora")
        dgvtiemper.Columns.Add("Num_Hora", "Num. Hora")
        dgvtiemper.Columns.Add("FEC_INICIO", "Fec. Inicio")
        dgvtiemper.Columns.Add("FEC_TERMINO", "Fec. Termino")

        dtphoragene.Format = DateTimePickerFormat.Custom
        dtphoragene.CustomFormat = "HH:mm:ss tt"
        dtphoragene.Text = "12:00:00 a.m."
        dtphoratermino.Format = DateTimePickerFormat.Custom
        dtphoratermino.CustomFormat = "HH:mm:ss tt"
        dtphoratermino.Text = "12:00:00 a.m."

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                txtt_doc.Text = "MTIEM"
                cmbt_doc.SelectedIndex = 0
                cmbserie.SelectedItem = FormMain.cmbaño.Text
                nro = ELTBMTIEMBL.LastCodigo(txtt_doc.Text, cmbserie.SelectedItem)
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
                '  Dispose()
                '  Exit Sub
                flagAccion = "M"
                txtt_doc.Text = "MTIEM"
                cmbt_doc.SelectedIndex = 0
                GetData(gsCode)
                dt = ELTBMTIEMBL.SelectRowDet(txtt_doc.Text, sSDoc, sNDoc)
                For Each row As DataRow In dt.Rows
                    dgvtiemper.Rows.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")),
                                            IIf(IsDBNull(row("Nombre")), "", row("Nombre")),
                                            IIf(IsDBNull(row("COD_LINEA")), "", row("COD_LINEA")),
                                            IIf(IsDBNull(row("COD_REALIZAR")), "", row("COD_REALIZAR")),
                                            IIf(IsDBNull(row("ACT_REALIZAR")), "", row("ACT_REALIZAR")),
                                            IIf(IsDBNull(row("Hora_Inicio")), "", row("Hora_Inicio")),
                                            IIf(IsDBNull(row("HORA_TERMINO")), "", row("HORA_TERMINO")),
                                            IIf(IsDBNull(row("USUARIO_RP")), "", row("USUARIO_RP")),
                                            IIf(IsDBNull(row("NUM")), "", row("NUM")),
                                            IIf(IsDBNull(row("NUM_DIF")), "", row("NUM_DIF")),
                                            IIf(IsDBNull(row("FEC_INICIO")), "", row("FEC_INICIO")),
                                            IIf(IsDBNull(row("FEC_TERMINO")), "", row("FEC_TERMINO")))
                Next
                dgvtiemper.Refresh()
                txtnro_om.ReadOnly = True
        End Select
        dgvtiemper.Columns("Cod_Realizar").Visible = False
        dgvtiemper.Columns("COD_LINEA").Visible = False
        dgvtiemper.Columns("USUARIO_RP").Visible = False
        dgvtiemper.Columns("FEC_INICIO").Visible = False
        dgvtiemper.Columns("FEC_TERMINO").Visible = False
        dgvtiemper.Columns("Dif_Hora").Visible = False
        dgvtiemper.Columns("COD_LINEA").Visible = False
        bprimero = False
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



    Private Sub txtdni_LostFocus(sender As Object, e As EventArgs) Handles txtdni.LostFocus
        If txtdni.Text = "" Then
            cmbdni.SelectedIndex = -1
        Else
            cmbdni.SelectedValue = txtdni.Text
        End If
    End Sub
    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo.SelectedValue = txtc_costo.Text

        If cmbc_costo.SelectedIndex > -1 Then
            Dim dt As DataTable
            Try
                dt = ELTBDETSTIEMBL.gArea(cmbc_costo.SelectedValue)
                GetCmb("cod", "nom", dt, cmb_linea)
            Catch ex As Exception
                MsgBox("El centro de costo no cuenta con Area")
            End Try
        End If
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
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "29"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtc_costo.Text = gLinea
            cmbc_costo.SelectedValue = gLinea
            txtc_costo.Select()
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub



    Private Sub dtpfec_inicio_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_inicio.LostFocus
        dtphoragene.Value = dtpfec_inicio.Value
    End Sub
    Private Sub dtpfec_termino_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_termino.LostFocus
        'dtphoratermino.Value = dtpfec_termino.Value
        If dtpfec_gene.Value.Date <= dtpfec_termino.Value.Date Then
            'dtphoratermino.Text = dtpfec_termino.Value.ToLongTimeString
            dtphoratermino.Text = dtpfec_termino.Value
            If DateTime.Now.ToString("mm") = "01" Then
                cmbserie.Text = DateTime.Now.ToString("yyyy")
            End If
        Else
            MsgBox("La fecha de termino debe ser mayor a la fecha inicial")
            dtpfec_termino.Focus()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim date1, date2 As DateTime
        date1 = dtpfec_gene.Value.ToShortDateString
        date2 = dtpfec_termino.Value.ToShortDateString
        date1 = date1.AddHours(dtphoragene.Value.Hour)
        date1 = date1.AddMinutes(dtphoragene.Value.Minute)
        date1 = date1.AddSeconds(dtphoragene.Value.Second)

        date2 = date2.AddHours(dtphoratermino.Value.Hour)
        date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
        date2 = date2.AddSeconds(dtphoratermino.Value.Second)

        If DateTime.Compare(date1, date2) >= 0 Then
            MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
            dtphoragene.Focus()
        Else
            Dim a As String = ""
            Dim HO As Integer = 0
            Dim MI As Integer = 0
            Dim SE As Integer = 0
            If dgvtiemper.Rows.Count > 0 Then
                For i = dgvtiemper.CurrentRow.Index To dgvtiemper.Rows.Count - 1
                    a = IIf(IsDBNull(dgvtiemper.Rows(i).Cells("Hora_Inicio").Value), "", dgvtiemper.Rows(i).Cells("Hora_Inicio").Value)
                    If a = "" Then
                        HO = Math.Abs(DateDiff(DateInterval.Hour, dtphoragene.Value, dtphoratermino.Value))
                        MI = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
                        SE = DateDiff(DateInterval.Second, dtphoragene.Value, dtphoratermino.Value)
                        MI = MI Mod 60
                        SE = SE Mod 60
                        If HO > "18" Then
                            'MsgBox("La hora mayor a las horas permitidas cambiar fechas")
                            'dtpfec_termino.Focus()
                            'Exit Sub
                        End If
                        dgvtiemper.Rows(i).Cells("Hora_Inicio").Value = dtphoragene.Text
                        dgvtiemper.Rows(i).Cells("Hora_Final").Value = dtphoratermino.Text
                        dgvtiemper.Rows(i).Cells("FEC_INICIO").Value = Mid(dtphoragene.Value, 1, 10)
                        dgvtiemper.Rows(i).Cells("FEC_TERMINO").Value = Mid(dtphoratermino.Value, 1, 10)
                        dgvtiemper.Rows(i).Cells("Num_Hora").Value = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
                        dgvtiemper.Rows(i).Cells("Dif_Hora").Value = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
                        dgvtiemper.Refresh()
                    End If
                Next
            Else
                MsgBox("No hay campos en el grid para agregar")
            End If
        End If
    End Sub
    Private Sub btnact_Click(sender As Object, e As EventArgs) Handles btnact.Click
        '    If dgvtiemper.Rows.Count > 0 Then
        '        For i = dgvtiemper.CurrentRow.Index To dgvtiemper.Rows.Count - 1
        '            If dgvtiemper.Rows(i).Cells("Act_Realizar").Value = "" Then
        '                dgvtiemper.Rows(i).Cells("Act_Realizar").Value = txtact.Text
        '                dgvtiemper.Refresh()
        '            End If
        '        Next
        '    Else
        '        MsgBox("No hay campos en el grid para agregar")
        '    End If
        If dgvtiemper.Rows.Count > 0 Then
            For i = dgvtiemper.CurrentRow.Index To dgvtiemper.Rows.Count - 1
                If dgvtiemper.Rows(i).Cells("Act_Realizar").Value = "" And dgvtiemper.Rows(i).Cells("Cod_Realizar").Value = "" Then
                    dgvtiemper.Rows(i).Cells("Cod_Realizar").Value = cmbactividad.SelectedValue
                    dgvtiemper.Rows(i).Cells("Act_Realizar").Value = cmbactividad.Text
                    dgvtiemper.Refresh()
                End If
            Next
        Else
            MsgBox("No hay campos en el grid para agregar")
        End If


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        sBusAlm = "123"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gSubLinea <> Nothing Then
            txtnro_om.Text = gSubLinea
            lblser_om.Text = gArt
            txtnro_om_LostFocus(sender, e)
            ' cmbdni.SelectedValue = gArt
            '  txtdni.Select()
            gArt = Nothing
        Else
            gArt = Nothing
        End If
    End Sub

    Private Sub txtnro_om_LostFocus(sender As Object, e As EventArgs) Handles txtnro_om.LostFocus
        Dim dt As DataTable
        Dim nro1 As String = txtnro_om.Text
        If txtnro_om.TextLength > 0 Then
            If nro1.Length = 1 Then
                txtnro_om.Text = "000000" & nro1
            ElseIf nro1.Length = 2 Then
                txtnro_om.Text = "00000" & nro1
            ElseIf nro1.Length = 3 Then
                txtnro_om.Text = "0000" & nro1
            ElseIf nro1.Length = 4 Then
                txtnro_om.Text = "000" & nro1
            ElseIf nro1.Length = 5 Then
                txtnro_om.Text = "00" & nro1
            ElseIf nro1.Length = 6 Then
                txtnro_om.Text = "0" & nro1
            ElseIf nro1.Length = 7 Then
                txtnro_om.Text = nro1
            End If
            txtnro_om.Text = ELTBMTIEMBL.SelectNom(txtnro_om.Text, cmbserie.Text)

            dt = ELTBMTIEMBL.SelectRows(txtnro_om.Text)
            For Each Registro In dt.Rows
                txtc_costo.Text = IIf(IsDBNull(Registro("CCO_CODDES")), "", Registro("CCO_CODDES"))
                lblser_om.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
                txtc_costo_LostFocus(sender, e)
                'txt_linea.Text = IIf(IsDBNull(Registro("AREAORI")), "", Registro("AREAORI"))
                'cmb_linea_SelectedIndexChanged(sender, e)
                cmb_linea.SelectedValue = IIf(IsDBNull(Registro("AREADES")), "", Registro("AREADES"))
            Next
        End If
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If dgvtiemper.Rows.Count > 0 Then
            For i = dgvtiemper.CurrentRow.Index To dgvtiemper.Rows.Count - 1
                If dgvtiemper.Rows(i).Cells("NRO_OM").Value = "" Then
                    dgvtiemper.Rows(i).Cells("NRO_OM").Value = txtnro_om.Text
                    dgvtiemper.Refresh()
                End If
            Next
        Else
            MsgBox("No hay campos en el grid para agregar")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "2"
        If txtc_costo.TextLength <> 0 Then
            gsCode10 = txtc_costo.Text
            'Dim frm As New FormPerGrupo
            Dim frm As New FormPerHoraOM
            frm.ShowDialog()
            gsCode10 = ""
        Else
            MsgBox("Debe Seleccionar un centro de Costo")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvtiemper.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvtiemper.Rows.RemoveAt(dgvtiemper.CurrentRow.Index)
            dgvtiemper.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    ' Dim frm As New FormBusquedaPerGrupo
    ' sBusAlm = "1"
    ' frm.ShowDialog()
    'End ' Sub
    Private Sub btnmod_Click(sender As Object, e As EventArgs) Handles btnmod.Click
        Dim frm As New FormELTBDETMTIEM
        If dgvtiemper.Rows.Count > 0 Then
            If dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Inicio").Value = "" Then
                MsgBox("Agregue hora o actividad con el boton incluir")
                Exit Sub
            Else
                frm.txtdni.Text = dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("CODIGO").Value
                frm.txtnomdni.Text = dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Nombre").Value
                frm.dtpfec_inicio.Value = dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("FEC_INICIO").Value
                frm.dtpfec_termino.Value = dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("FEC_TERMINO").Value
                frm.dtphoragene.Value = frm.dtpfec_inicio.Value
                frm.dtphoratermino.Value = frm.dtpfec_termino.Value
                frm.dtphoragene.Text = dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("FEC_INICIO").Value & " " & dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Inicio").Value
                frm.dtphoratermino.Text = dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("FEC_INICIO").Value & " " & dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Final").Value
                frm.txtdifhora.Text = dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Num_Hora").Value
                frm.txtact.Text = dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("COD_REALIZAR").Value
            End If
        Else
            MsgBox("Nop hay personal para modificar")
            Exit Sub
        End If
        frm.ShowDialog()
    End Sub

    Private Sub FormELTBSTIEMOM_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If dgvtiemper.CurrentRow.Index <> -1 Then
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Inicio").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Final").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Dif_Hora").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Num_Hora").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("FEC_INICIO").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("FEC_TERMINO").Value = ""
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If dgvtiemper.CurrentRow.Index <> -1 Then
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Cod_Realizar").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Act_Realizar").Value = ""
        End If
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
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
            Case "Print"
                ''   ReDim gsRptArgs(2)
                ''   gsRptArgs(0) = RTrim(txtt_doc.Text)
                ''   gsRptArgs(1) = RTrim(cmbserie.Text)
                ''   gsRptArgs(2) = RTrim(txtnumero.Text)
                ''   gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTELTBSTIEM_SELROW.rpt"
                ''   gsRptPath = gsPathRpt
                ''   FormReportes.ShowDialog()
                Exit Sub
            Case "anular"

                If MessageBox.Show("Desea anular el documento",
                      gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If

                ''        Dim TIME As TimeSpan
                Dim ELTBMTIEMBE As New ELTBMTIEMBE
                ''       Dim ELMVLOGSBE As New ELMVLOGSBE
                ''       ELMVLOGSBE.log_codusu = gsCodUsr
                ELTBMTIEMBE.T_DOC_REF = RTrim(txtt_doc.Text)
                ELTBMTIEMBE.SER_DOC_REF = RTrim(cmbserie.Text)
                ELTBMTIEMBE.NRO_DOC_REF = RTrim(txtnumero.Text)
                ''        Dim ELTBDETSTIEMBE As New ELTBDETSTIEMBE
                gsError = ELTBMTIEMBL.SaveRow(ELTBMTIEMBE, "A", dgvtiemper)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If

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
        'Dim difhora As Double
        Dim nro As String
        'Dim TIME As TimeSpan
        Dim ELTBMTIEMBE As New ELTBMTIEMBE
        If flagAccion = "N" Then
            nro = ELTBMTIEMBL.LastCodigo(txtt_doc.Text, cmbserie.SelectedItem)
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

        ELTBMTIEMBE.T_DOC_REF = RTrim(txtt_doc.Text)
        ELTBMTIEMBE.SER_DOC_REF = RTrim(cmbserie.Text)
        ELTBMTIEMBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        If cmbestado.SelectedIndex = 0 Then
            ELTBMTIEMBE.EST = "H"
        Else
            ELTBMTIEMBE.EST = "A"
        End If
        ELTBMTIEMBE.FEC_GENE = dtpfec_gene.Value

        ELTBMTIEMBE.SER_OM = RTrim(lblser_om.Text)
        ELTBMTIEMBE.NRO_OM = RTrim(txtnro_om.Text)
        ELTBMTIEMBE.PER_COD = RTrim(txtdni.Text)
        ELTBMTIEMBE.CCO_COD = RTrim(txtc_costo.Text)
        ELTBMTIEMBE.LINEA = RTrim(txt_linea.Text)

        ELTBMTIEMBE.FEC_INICIO = dtpfec_inicio.Value
        ELTBMTIEMBE.FEC_TERMINO = dtpfec_termino.Value
        ELTBMTIEMBE.HORA_GENE = dtphoragene.Text
        ELTBMTIEMBE.HORA_TERMINO = dtphoratermino.Text
        ELTBMTIEMBE.DIF_HORA = RTrim(txtdifhora.Text)
        ELTBMTIEMBE.COD_REALIZAR = RTrim(txtact.Text)
        ELTBMTIEMBE.OBSERVACION = RTrim(txtobs.Text)
        ELTBMTIEMBE.OBSERVACION_TECNICO = RTrim(txtobsj.Text)

        '    ELTBMTIEMBE.FEC_DIA = RTrim(DateTime.Now)
        '    TIME = dtphoratermino.Value - dtphoragene.Value
        '    difhora = Math.Abs(Math.Round(Convert.ToDouble(Mid(TIME.ToString, 1, 2)), 2) + Math.Round((Convert.ToDouble(Mid(TIME.ToString, 4, 2) + 0.1) / 60), 2))
        '    ELTBMTIEMBE.DIF_HORA = txtdifhora.Text
        '    ELTBMTIEMBE.OBSERVA = txtobs.Text
        ELTBMTIEMBE.USUARIO_RP = gsCodUsr
        'If FormMain.rdbapr4.Checked Then
        '    ELTBSTIEMBE.USUARIO_VB = "0"
        'Else
        '    ELTBSTIEMBE.USUARIO_VB = vb
        'End If
        'Dim ELTBDETSTIEMBE As New ELTBDETSTIEMBE

        'Recibe los parametros de la caracteristica y arma el catalogo
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELMVLOGSBE.log_codusu = gsCodUsr
        gsError = ELTBMTIEMBL.SaveRow(ELTBMTIEMBE, flagAccion, dgvtiemper)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError + " " + gsError2
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub
    Private Function OkData() As Boolean
        Dim q As String = ""
        p = 0
        q = 0

        If txtnro_om.Text = "" Then
            MsgBox("Ingrese una Orden de Mantenimiento", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If txtdni.Text = "" Then
            MsgBox("Ingrese Dni del Supervisor", MsgBoxStyle.Exclamation)
            txtdni.Focus()
            Return False
        End If
        If cmb_linea.SelectedIndex = -1 Then
            MsgBox("Ingrese la linea", MsgBoxStyle.Exclamation)
            txtdni.Focus()
            Return False
        End If
        'If txtdifhora.TextLength = 0 Then
        '    MsgBox("Ingrese Horas distintas para el calculo", MsgBoxStyle.Exclamation)
        '    dtphoragene.Focus()
        '    Return False
        'End If
        For i = 0 To dgvtiemper.Rows.Count - 1
            If dgvtiemper.Rows(i).Cells("Hora_Inicio").Value = "" Then
                p = p + 1
            End If
            If p <> 0 Then
                MsgBox("Por favor ponga las horas laboradas")
                Return False
            End If
            If dgvtiemper.Rows(i).Cells("Act_Realizar").Value = "" Then
                q = q + 1
            End If
            If q <> 0 Then
                MsgBox("Por favor ingrese una actividad")
                Return False
            End If
        Next
        If dgvtiemper.Rows.Count = 0 Then
            MsgBox("Se debe tener registros en el formulario")
            Return False
        End If
        Return True
    End Function

    Private Sub dtphoratermino_ValueChanged(sender As Object, e As EventArgs) Handles dtphoratermino.ValueChanged
        Dim date1, date2 As DateTime
        date1 = dtpfec_gene.Value.ToShortDateString
        date2 = dtpfec_termino.Value.ToShortDateString
        date1 = date1.AddHours(dtphoragene.Value.Hour)
        date1 = date1.AddMinutes(dtphoragene.Value.Minute)
        date1 = date1.AddSeconds(dtphoragene.Value.Second)

        date2 = date2.AddHours(dtphoratermino.Value.Hour)
        date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
        date2 = date2.AddSeconds(dtphoratermino.Value.Second + 1)

        If DateTime.Compare(date1, date2) >= 0 Then
            MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
            dtphoragene.Focus()
        Else
            txtdifhora.Text = Nothing
            Dim HO As Integer = 0
            Dim MI As Integer = 0
            Dim SE As Integer = 0

            HO = Math.Abs(DateDiff(DateInterval.Hour, dtphoragene.Value, dtphoratermino.Value))
            MI = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
            SE = DateDiff(DateInterval.Second, dtphoragene.Value, dtphoratermino.Value)
            MI = MI Mod 60
            SE = SE Mod 60
            'If HO > "18" Then
            '    MsgBox("La hora mayor a las horas permitidas cambiar fechas")
            '    dtpfec_termino.Focus()
            '    Exit Sub
            'End If
            txtdifhora.Text = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
        End If
    End Sub
    Private Sub dtphoragene_ValueChanged(sender As Object, e As EventArgs) Handles dtphoragene.ValueChanged
        dtphoratermino_ValueChanged(sender, e)
    End Sub
End Class