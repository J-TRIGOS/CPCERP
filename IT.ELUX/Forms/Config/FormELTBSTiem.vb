Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBSTiem
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ELTBSTIEMBL As New ELTBSTIEMBL
    Private ELTBMTIEMBL As New ELTBMTIEMBL
    Private ELTBDETSTIEMBL As New ELTBDETSTIEMBL
    Private gpCaption As String
    Private bprimero As Boolean
    Private p As Integer = 0
    Private vb As String
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

    Private Function OkData() As Boolean
        p = 0
        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If txtdni.Text = "" Then
            MsgBox("Ingrese descripcion de moneda", MsgBoxStyle.Exclamation)
            txtdni.Focus()
            Return False
        End If
        If cmb_linea.SelectedIndex = -1 Then
            MsgBox("Ingrese la linea", MsgBoxStyle.Exclamation)
            cmb_linea.Focus()
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
                MsgBox("Por favor ponga la hora de la hora extra")
                Return False
            End If
        Next
        If dgvtiemper.Rows.Count = 0 Then
            MsgBox("Se debe tener registros en el formulario")
            Return False
        End If
        'M'    If txtdni.Text = "46618786" Then
        'M'        For i = 0 To dgvtiemper.Rows.Count - 1
        'M'            If dgvtiemper.Rows(i).Cells("nro_doc_ref").Value = "" Then
        'M'                p = p + 1
        'M'            End If
        'M'            If p <> 0 Then
        'M'                MsgBox("Por favor incluya numero de OM")
        'M'                Return False
        'M'            End If
        'M'        Next
        'M'    End If
        Return True
    End Function

    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        'Manda los parameteros a los campos correspondientes del catalogo
        Dim difhora As Double
        Dim nro As String
        Dim TIME As TimeSpan
        Dim ELTBSTIEMBE As New ELTBSTIEMBE
        If flagAccion = "N" Then
            nro = ELTBSTIEMBL.LastCodigo(txtt_doc.Text, cmbserie.SelectedItem)
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

        ELTBSTIEMBE.T_DOC_REF = RTrim(txtt_doc.Text)
        ELTBSTIEMBE.SER_DOC_REF = cmbserie.Text
        ELTBSTIEMBE.NRO_DOC_REF = txtnumero.Text
        ELTBSTIEMBE.PER_COD = RTrim(txtdni.Text)
        ELTBSTIEMBE.ACT_REALIZAR = RTrim(txtact.Text)
        ELTBSTIEMBE.CCO_COD = RTrim(txtc_costo.Text)
        ELTBSTIEMBE.DIF_HORA = RTrim(txtdifhora.Text)
        'ELTBSTIEMBE.EST = IIf(cmbestado.SelectedIndex = 0, "0", "1")
        If cmbestado.SelectedIndex = 0 Then
            ELTBSTIEMBE.EST = "H"
        Else
            ELTBSTIEMBE.EST = "A"
        End If
        ELTBSTIEMBE.FEC_DIA = RTrim(DateTime.Now)
        ELTBSTIEMBE.FEC_GENE = dtpfec_gene.Text
        ELTBSTIEMBE.FEC_INICIO = dtpfec_inicio.Text
        ELTBSTIEMBE.FEC_TERMINO = dtpfec_termino.Text
        ELTBSTIEMBE.HORA_GENE = dtphoragene.Text
        ELTBSTIEMBE.HORA_TERMINO = dtphoratermino.Text
        ELTBSTIEMBE.OBSERVACION_JEFE = txtobsj.Text
        TIME = dtphoratermino.Value - dtphoragene.Value
        ELTBSTIEMBE.LINEA = txt_linea.Text
        difhora = Math.Abs(Math.Round(Convert.ToDouble(Mid(TIME.ToString, 1, 2)), 2) + Math.Round((Convert.ToDouble(Mid(TIME.ToString, 4, 2) + 0.1) / 60), 2))
        ELTBSTIEMBE.DIF_HORA = txtdifhora.Text
        ELTBSTIEMBE.OBSERVA = txtobs.Text
        ELTBSTIEMBE.USUARIO_RP = gsCodUsr

        If FormMain.rdbapr4.Checked Then
            ELTBSTIEMBE.USUARIO_VB = "0"
        Else
            ELTBSTIEMBE.USUARIO_VB = vb
        End If

        Dim ELTBDETSTIEMBE As New ELTBDETSTIEMBE

        'Recibe los parametros de la caracteristica y arma el catalogo
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELMVLOGSBE.log_codusu = gsCodUsr
        gsError = ELTBSTIEMBL.SaveRow(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, flagAccion, dgvtiemper)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError + " " + gsError2
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        dtUsuario = ELTBSTIEMBL.SelectRow(txtt_doc.Text, sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows
            'txtt_doc.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtnumero.Text = sNDoc
            cmbserie.Text = sSDoc
            txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
            cmbc_costo.SelectedValue = txtc_costo.Text
            txtdni.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            txtobs.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txtobsjf.Text = IIf(IsDBNull(Registro("OBSERVACION_JEFE_PLANTA")), "", Registro("OBSERVACION_JEFE_PLANTA"))
            cmbdni.SelectedValue = txtdni.Text
            If IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "H" Then
                cmbestado.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "A" Then
                cmbestado.SelectedIndex = 1
            End If
            dtpfec_gene.Value = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            dtpfec_inicio.Value = dtpfec_gene.Value
            dtphoragene.Value = dtpfec_inicio.Value
            dtpfec_termino.Value = dtpfec_gene.Value
            dtphoratermino.Value = dtpfec_termino.Value
            Label12.Text = IIf(IsDBNull(Registro("USUARIO_RP")), "", Registro("USUARIO_RP"))
            txtobservacion_rh.Text = IIf(IsDBNull(Registro("OBSERVACIONRH")), "", Registro("OBSERVACIONRH"))
            Dim dt As DataTable
            dt = ELTBDETSTIEMBL.gArea(cmbc_costo.SelectedValue)
            GetCmb("cod", "nom", dt, cmb_linea)
            txt_linea.Text = IIf(IsDBNull(Registro("LINEA")), "", Registro("LINEA"))
            cmb_linea.SelectedValue = txt_linea.Text
            txtobsj.Text = IIf(IsDBNull(Registro("OBSERVACION_JEFE")), "", Registro("OBSERVACION_JEFE"))
            vb = IIf(IsDBNull(Registro("USUARIO_VB")), "", Registro("USUARIO_VB"))
        Next

    End Sub

    Private Sub FormELTBS_Tiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Dim nro As String
        bprimero = True
        Me.Text = "Autorizacion de Sobre Tiempos"
        dt = GUIAALMACENBL.SelectPer
        GetCmb("cod", "nombre", dt, cmbdni)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        'M'    ' Mantenimiento
        'M'    dt = ELTBMTIEMBL.SelectActi
        'M'    GetCmb("cod", "nom", dt, cmbactividad)
        'M'    '
        dgvtiemper.Columns.Add("Codigo", "Codigo")
        dgvtiemper.Columns.Add("Nombre", "Apellidos y Nombre")
        dgvtiemper.Columns.Add("Act_Realizar", "Actividad Realizar")
        dgvtiemper.Columns.Add("Hora_Inicio", "Hora Inicio")
        dgvtiemper.Columns.Add("Hora_Final", "Hora Final")
        dgvtiemper.Columns.Add("USUARIO_RP", "USUARIO_RP")
        dgvtiemper.Columns.Add("Dif_Hora", "Dif. Hora")
        dgvtiemper.Columns.Add("Num_Hora", "Num. Hora")
        dgvtiemper.Columns.Add("FEC_INICIO", "Fec. Inicio")
        dgvtiemper.Columns.Add("FEC_TERMINO", "Fec. Termino")
        dgvtiemper.Columns.Add("COD_LINEA", "Area")

        dtphoragene.Format = DateTimePickerFormat.Custom
        dtphoragene.CustomFormat = "HH:mm:ss tt"
        dtphoragene.Text = "12:00:00 a.m."

        dtphoratermino.Format = DateTimePickerFormat.Custom
        dtphoratermino.CustomFormat = "HH:mm:ss tt"
        dtphoratermino.Text = "12:00:00 a.m."
        'dtphoratermino.Value = DateTime.Now
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                txtt_doc.Text = "STIEM"
                cmbt_doc.SelectedIndex = 0
                cmbserie.SelectedItem = FormMain.cmbaño.Text
                nro = ELTBSTIEMBL.LastCodigo(txtt_doc.Text, cmbserie.SelectedItem)
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
                txtt_doc.Text = "STIEM"
                cmbt_doc.SelectedIndex = 0
                GetData(gsCode)
                If FormMain.rdbapr1.Checked Then
                    txtobs.ReadOnly = True
                    txtobsj.ReadOnly = False
                End If
                dt = ELTBDETSTIEMBL.SelectRow(txtt_doc.Text, sSDoc, sNDoc)
                'Recorre el data row para mostrar en el grid
                For Each row As DataRow In dt.Rows
                    dgvtiemper.Rows.Add(IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")),
                                        IIf(IsDBNull(row("Nombre")), "", row("Nombre")),
                                        IIf(IsDBNull(row("ACT_REALIZAR")), "", row("ACT_REALIZAR")),
                                        IIf(IsDBNull(row("Hora_Inicio")), "", row("Hora_Inicio")),
                                        IIf(IsDBNull(row("HORA_TERMINO")), "", row("HORA_TERMINO")),
                                        IIf(IsDBNull(row("USUARIO_RP")), "", row("USUARIO_RP")),
                                        IIf(IsDBNull(row("NUM")), "", row("NUM")),
                                        IIf(IsDBNull(row("NUM_DIF")), "", row("NUM_DIF")),
                                        IIf(IsDBNull(row("FEC_INICIO")), "", row("FEC_INICIO")),
                                        IIf(IsDBNull(row("FEC_TERMINO")), "", row("FEC_TERMINO")),
                                        IIf(IsDBNull(row("COD_LINEA")), "", row("COD_LINEA")))
                Next

                'Borra la caracteristica de la base de datos
                dgvtiemper.Refresh()
        End Select
        dgvtiemper.Columns("USUARIO_RP").Visible = False
        dgvtiemper.Columns("FEC_INICIO").Visible = False
        dgvtiemper.Columns("FEC_TERMINO").Visible = False
        dgvtiemper.Columns("Dif_Hora").Visible = False
        dgvtiemper.Columns("COD_LINEA").Visible = False
        bprimero = False
        If flagAccion = "M" Then
            If gsUser = "SISTEMA" Or gsUser = "LMORAN" Or gsUser = "VHERMOZA" Or gsUser = "RCONISLLA" Or gsUser = "DCONDOR" Then
            Else
                If gsUser = "CQUITO" Then
                    nro = ELTBSTIEMBL.OK_CCO_COD(gsUser)
                    If FormMain.dgvMain.Rows(FormMain.dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value = "ARAMIREZ" Or
                        FormMain.dgvMain.Rows(FormMain.dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value = "CQUITO" Then
                    Else
                        If Trim(gsCode11) = nro Then
                        Else
                            If Label12.Text <> gsCodUsr Then
                                MsgBox("Usted no ah ingresado este Documento")
                                Dispose()
                            End If
                        End If
                    End If
                Else
                    nro = ELTBSTIEMBL.OK_CCO_COD(gsUser)
                    If Trim(gsCode11) = "203" Or Trim(gsCode11) = "120" Or Trim(gsCode11) = "119" Then
                        gsCode11 = "111"
                    End If
                    If Trim(gsCode11) = nro Then
                    Else
                        If gsUser = "LVERGARA" Then
                            If gsCode11 <> "111" And FormMain.dgvMain.Rows(FormMain.dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value <> "DSANDOVAL" Then
                                If gsCode11 <> "118" And FormMain.dgvMain.Rows(FormMain.dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value <> "LVERGARA" Then
                                    MsgBox("Usted no ah ingresado este Documento")
                                    Dispose()
                                End If
                            End If
                            ElseIf gsUser = "MPEÑA" Then
                            If gsCode11 <> "117" And FormMain.dgvMain.Rows(FormMain.dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value <> "DSANDOVAL" Then
                                MsgBox("Usted no ah ingresado este Documento")
                                Dispose()
                            End If
                        Else
                            If Label12.Text <> gsCodUsr Then
                                MsgBox("Usted no ah ingresado este Documento")
                                Dispose()
                            End If
                        End If


                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'M'  If txtdni.Text = "46618786" Then
        'M'      sBusAlm = "4"
        'M'  Else
        sBusAlm = "2"
        'M'  End If
        If txtc_costo.TextLength <> 0 Then
            gsCode10 = txtc_costo.Text
            'Dim frm As New FormPerGrupo
            Dim frm As New FormPerGrupoHora
            frm.ShowDialog()
            gsCode10 = ""
        Else
            MsgBox("Debe Seleccionar un centro de Costo")
        End If

    End Sub
    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
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
                ReDim gsRptArgs(2)
                gsRptArgs(0) = RTrim(txtt_doc.Text)
                gsRptArgs(1) = RTrim(cmbserie.Text)
                gsRptArgs(2) = RTrim(txtnumero.Text)
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTELTBSTIEM_SELROW.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
                Exit Sub
            Case "anular"

                If MessageBox.Show("Desea anular el documento",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If
                Dim TIME As TimeSpan
                Dim ELTBSTIEMBE As New ELTBSTIEMBE
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                ELTBSTIEMBE.T_DOC_REF = RTrim(txtt_doc.Text)
                ELTBSTIEMBE.SER_DOC_REF = cmbserie.Text
                ELTBSTIEMBE.NRO_DOC_REF = txtnumero.Text
                Dim ELTBDETSTIEMBE As New ELTBDETSTIEMBE
                gsError = ELTBSTIEMBL.SaveRow(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, "A", dgvtiemper)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If



                Exit Sub
        End Select
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
            'M'       supervisor()
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
    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bPrimero Then
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
    Private Sub cmbdni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdni.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbdni.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtdni.Text = cmbdni.SelectedValue
        'M'    supervisor()
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

    Private Sub dtphoratermino_LostFocus(sender As Object, e As EventArgs) Handles dtphoratermino.LostFocus
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
            txtdifhora.Text = Nothing
            Dim HO As Integer = 0
            Dim MI As Integer = 0
            Dim SE As Integer = 0

            HO = Math.Abs(DateDiff(DateInterval.Hour, dtphoragene.Value, dtphoratermino.Value))
            MI = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
            SE = DateDiff(DateInterval.Second, dtphoragene.Value, dtphoratermino.Value)
            MI = MI Mod 60
            SE = SE Mod 60
            If HO > "18" Then
                MsgBox("La hora mayor a las horas permitidas cambiar fechas")
                dtpfec_termino.Focus()
                Exit Sub
            End If
            txtdifhora.Text = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
        End If
    End Sub

    Private Sub txtdni_LostFocus(sender As Object, e As EventArgs) Handles txtdni.LostFocus
        If txtdni.Text = "" Then
            cmbdni.SelectedIndex = -1
        Else
            cmbdni.SelectedValue = txtdni.Text
        End If
        'M'    supervisor()
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

    Private Sub dtpfec_gene_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_gene.LostFocus
        'If DateTime.Now.ToString("yyyy") - dtpfec_gene.Value.Year = 1 Then
        '    Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+13).ToShortDateString
        '    Dim Today As DateTime = DateTime.Now.ToShortDateString
        '    If DateTime.Compare(dtpini, Today) <= 0 Then
        '        MsgBox("La fecha de inicio no debe ser más de 13 dias antes a la fecha actual, Si desea Generar el Ingreso favor comuniquese con los jefes de Producción", MsgBoxStyle.Exclamation)
        '        dtpfec_gene.Focus()
        '    Else
        '        'dtphoragene.Value = dtpfec_gene.Value
        '        txtdni.Select()
        '        dtpfec_inicio.Value = dtpfec_gene.Value
        '        dtpfec_termino.Value = dtpfec_gene.Value
        '        dtphoragene.Value = dtpfec_gene.Value
        '        dtphoratermino.Value = dtpfec_gene.Value
        '    End If
        'Else
        If (dtpfec_gene.Value.Month).ToString.PadLeft(2, "0") > DateTime.Now.ToString("MM").PadLeft(2, "0") Then
            If ELTBSTIEMBL.SelPermiso(gsUser) = "" Then
                If DateTime.Now.Year - dtpfec_gene.Value.Year = 1 Then
                    If dtpfec_gene.Value.Month <> 12 Then
                        Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+4).ToShortDateString
                        'Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+9).ToShortDateString
                        Dim Today As DateTime = DateTime.Now.ToShortDateString
                        If DateTime.Compare(dtpini, Today) <= 0 Then
                            MsgBox("La fecha de inicio no debe ser más de 3 dias antes a la fecha actual, Si desea Generar el Ingreso favor comuniquese con los jefes de Producción", MsgBoxStyle.Exclamation)
                            dtpfec_gene.Select()
                            Exit Sub
                        Else
                            txtdni.Select()
                            dtpfec_inicio.Value = dtpfec_gene.Value
                            dtpfec_termino.Value = dtpfec_gene.Value
                            dtphoragene.Value = dtpfec_gene.Value
                            dtphoratermino.Value = dtpfec_gene.Value
                        End If
                    Else
                        Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+4).ToShortDateString
                        'Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+9).ToShortDateString
                        Dim Today As DateTime = DateTime.Now.ToShortDateString
                        If DateTime.Compare(dtpini, Today) <= 0 Then
                            MsgBox("La fecha de inicio no debe ser más de 3 dias antes a la fecha actual, Si desea Generar el Ingreso favor comuniquese con los jefes de Producción", MsgBoxStyle.Exclamation)
                            dtpfec_gene.Select()
                            Exit Sub
                        Else
                            txtdni.Select()
                            dtpfec_inicio.Value = dtpfec_gene.Value
                            dtpfec_termino.Value = dtpfec_gene.Value
                            dtphoragene.Value = dtpfec_gene.Value
                            dtphoratermino.Value = dtpfec_gene.Value
                        End If
                    End If
                Else
                    MsgBox("Error al ingresar la fecha")
                    Exit Sub
                    'dtpfec_gene.Focus()

                End If
            ElseIf ELTBSTIEMBL.SelPermiso(gsUser) = "1" Then
                If DateTime.Now.Year - dtpfec_gene.Value.Year = 1 Then
                    'MsgBox("La Año es mayor al Año permitido", MsgBoxStyle.Exclamation)
                    'dtpfec_gene.Focus()
                    If dtpfec_gene.Value.Month <> 12 Then
                        MsgBox("El año o el Mes es mayor al mes permitido", MsgBoxStyle.Exclamation)
                        dtpfec_gene.Select()
                        Exit Sub
                    Else
                        txtdni.Select()
                        dtpfec_inicio.Value = dtpfec_gene.Value
                        dtpfec_termino.Value = dtpfec_gene.Value
                        dtphoragene.Value = dtpfec_gene.Value
                        dtphoratermino.Value = dtpfec_gene.Value
                    End If
                Else
                    If DateTime.Now.Year = dtpfec_gene.Value.Year Then
                        If DateTime.Now.Month - dtpfec_gene.Value.Month > 1 Then
                            MsgBox("La Mes es mayor al mes permitido", MsgBoxStyle.Exclamation)
                            dtpfec_gene.Select()
                            Exit Sub
                        Else
                            txtdni.Select()
                            dtpfec_inicio.Value = dtpfec_gene.Value
                            dtpfec_termino.Value = dtpfec_gene.Value
                            dtphoragene.Value = dtpfec_gene.Value
                            dtphoratermino.Value = dtpfec_gene.Value
                        End If
                    Else
                        MsgBox("El año es Mayor al permitido")
                    End If
                End If
            ElseIf ELTBSTIEMBL.SelPermiso(gsUser) = "2" Then
                If DateTime.Now.Year - dtpfec_gene.Value.Year = 1 Then
                    'MsgBox("La Año es mayor al Año permitido", MsgBoxStyle.Exclamation)
                    'dtpfec_gene.Focus()
                    If dtpfec_gene.Value.Month <> 12 Then
                        MsgBox("El año o el Mes es mayor al mes permitido", MsgBoxStyle.Exclamation)
                        dtpfec_gene.Select()
                        Exit Sub
                    Else
                        txtdni.Select()
                        dtpfec_inicio.Value = dtpfec_gene.Value
                        dtpfec_termino.Value = dtpfec_gene.Value
                        dtphoragene.Value = dtpfec_gene.Value
                        dtphoratermino.Value = dtpfec_gene.Value
                    End If
                Else
                    If DateTime.Now.Year = dtpfec_gene.Value.Year Then
                        txtdni.Select()
                        dtpfec_inicio.Value = dtpfec_gene.Value
                        dtpfec_termino.Value = dtpfec_gene.Value
                        dtphoragene.Value = dtpfec_gene.Value
                        dtphoratermino.Value = dtpfec_gene.Value
                    Else
                        MsgBox("El año es Mayor al permitido")
                    End If
                End If
            End If

        Else
            If ELTBSTIEMBL.SelPermiso(gsUser) = "1" Then 'If gsUser = "JJUSTO" Or gsUser = "JTUCNO" Or gsUser = "LVERGARA" Then
                If DateTime.Now.Year - dtpfec_gene.Value.Year = 1 Then
                    'MsgBox("La Año es mayor al Año permitido", MsgBoxStyle.Exclamation)
                    'dtpfec_gene.Focus()
                    If dtpfec_gene.Value.Month <> 12 Then
                        MsgBox("El año o el Mes es mayor al mes permitido", MsgBoxStyle.Exclamation)
                        dtpfec_gene.Select()
                        Exit Sub
                    Else
                        txtdni.Select()
                        dtpfec_inicio.Value = dtpfec_gene.Value
                        dtpfec_termino.Value = dtpfec_gene.Value
                        dtphoragene.Value = dtpfec_gene.Value
                        dtphoratermino.Value = dtpfec_gene.Value
                    End If
                Else
                    If DateTime.Now.Year = dtpfec_gene.Value.Year Then
                        If DateTime.Now.Month - dtpfec_gene.Value.Month > 1 Then
                            MsgBox("La Mes es mayor al mes permitido", MsgBoxStyle.Exclamation)
                            dtpfec_gene.Select()
                            Exit Sub
                        Else
                            txtdni.Select()
                            dtpfec_inicio.Value = dtpfec_gene.Value
                            dtpfec_termino.Value = dtpfec_gene.Value
                            dtphoragene.Value = dtpfec_gene.Value
                            dtphoratermino.Value = dtpfec_gene.Value
                        End If
                    Else
                        MsgBox("El año es Mayor al permitido")
                    End If
                End If
                'If DateTime.Now.Month - dtpfec_gene.Value.Month > 1 Then
                '    MsgBox("La Mes es mayor al mes permitido", MsgBoxStyle.Exclamation)
                '    dtpfec_gene.Focus()
                '    Exit Sub
                'Else
                '    txtdni.Select()
                '    dtpfec_inicio.Value = dtpfec_gene.Value
                '    dtpfec_termino.Value = dtpfec_gene.Value
                '    dtphoragene.Value = dtpfec_gene.Value
                '    dtphoratermino.Value = dtpfec_gene.Value
                'End If
            ElseIf ELTBSTIEMBL.SelPermiso(gsUser) = "2" Then
                If DateTime.Now.Year - dtpfec_gene.Value.Year = 1 Then
                    'MsgBox("La Año es mayor al Año permitido", MsgBoxStyle.Exclamation)
                    'dtpfec_gene.Focus()
                    If dtpfec_gene.Value.Month <> 12 Then
                        MsgBox("El año o el Mes es mayor al mes permitido", MsgBoxStyle.Exclamation)
                        dtpfec_gene.Select()
                        Exit Sub
                    Else
                        txtdni.Select()
                        dtpfec_inicio.Value = dtpfec_gene.Value
                        dtpfec_termino.Value = dtpfec_gene.Value
                        dtphoragene.Value = dtpfec_gene.Value
                        dtphoratermino.Value = dtpfec_gene.Value
                    End If
                Else
                    If DateTime.Now.Year = dtpfec_gene.Value.Year Then
                        txtdni.Select()
                        dtpfec_inicio.Value = dtpfec_gene.Value
                        dtpfec_termino.Value = dtpfec_gene.Value
                        dtphoragene.Value = dtpfec_gene.Value
                        dtphoratermino.Value = dtpfec_gene.Value

                    Else
                        MsgBox("El año es Mayor al permitido")
                    End If
                End If
                'If DateTime.Now.Month - dtpfec_gene.Value.Month > 1 Then
                '    MsgBox("La Mes es mayor al mes permitido", MsgBoxStyle.Exclamation)
                '    dtpfec_gene.Focus()
                '    Exit Sub
                'Else
                '    txtdni.Select()
                '    dtpfec_inicio.Value = dtpfec_gene.Value
                '    dtpfec_termino.Value = dtpfec_gene.Value
                '    dtphoragene.Value = dtpfec_gene.Value
                '    dtphoratermino.Value = dtpfec_gene.Value
                'End If
            Else
                If (dtpfec_gene.Value.Month).ToString.PadLeft(2, "0") = DateTime.Now.ToString("MM").PadLeft(2, "0") Then
                    If (dtpfec_gene.Value.Day).ToString.PadLeft(2, "0") > DateTime.Now.ToString("dd").PadLeft(2, "0") Then
                        MsgBox("Error al ingresar la fecha")
                        dtpfec_gene.Focus()
                        Exit Sub
                    End If
                End If
                Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+4).ToShortDateString
                'Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+9).ToShortDateString
                Dim Today As DateTime = DateTime.Now.ToShortDateString
                If DateTime.Compare(dtpini, Today) <= 0 Then
                    MsgBox("La fecha de inicio no debe ser más de 3 dias antes a la fecha actual, Si desea Generar el Ingreso favor comuniquese con los jefes de Producción", MsgBoxStyle.Exclamation)
                    dtpfec_gene.Select()
                    Exit Sub
                Else
                    'dtphoragene.Value = dtpfec_gene.Value
                    txtdni.Select()
                    dtpfec_inicio.Value = dtpfec_gene.Value
                    dtpfec_termino.Value = dtpfec_gene.Value
                    dtphoragene.Value = dtpfec_gene.Value
                    dtphoratermino.Value = dtpfec_gene.Value
                End If
            End If
        End If
        'End If
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

        'M'    If txtdni.Text = "46618786" Then
        If DateTime.Compare(date1, date2) >= 0 Then
                MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
                dtphoragene.Focus()
            Else
                Dim a As String = ""
                Dim HO As Integer = 0
                Dim MI As Integer = 0
                Dim SE As Integer = 0
                If dgvtiemper.Rows.Count > 0 Then
                'M'                'For i = dgvtiemper.CurrentRow.Index To dgvtiemper.Rows.Count - 1
                'M'                a = IIf(IsDBNull(dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Inicio").Value), "", dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Inicio").Value)
                'M'                If a = "" Then
                'M'                    HO = Math.Abs(DateDiff(DateInterval.Hour, dtphoragene.Value, dtphoratermino.Value))
                'M'                    MI = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
                'M'                    SE = DateDiff(DateInterval.Second, dtphoragene.Value, dtphoratermino.Value)
                'M'                    MI = MI Mod 60
                'M'                    SE = SE Mod 60
                'M'                    If HO > "18" Then
                'M'                        MsgBox("La hora mayor a las horas permitidas cambiar fechas")
                'M'                        dtpfec_termino.Focus()
                'M'                        Exit Sub
                'M'                    End If
                'M'                    dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Inicio").Value = dtphoragene.Text
                'M'                    dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Final").Value = dtphoratermino.Text
                'M'                    dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("FEC_INICIO").Value = Mid(dtphoragene.Value, 1, 10)
                'M'                    dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("FEC_TERMINO").Value = Mid(dtphoratermino.Value, 1, 10)
                'M'                    dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Num_Hora").Value = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
                'M'                    dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Dif_Hora").Value = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
                'M'                    dgvtiemper.Refresh()
                'M'                End If
                'M'                'Next
                'M'            Else
                'M'                MsgBox("No hay campos en el grid para agregar")
                'M'            End If
                'M'        End If
                'M'    Else
                'M'        If DateTime.Compare(date1, date2) >= 0 Then
                'M'            MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
                'M'            dtphoragene.Focus()
                'M'        Else
                'M'            Dim a As String = ""
                'M'            Dim HO As Integer = 0
                'M'            Dim MI As Integer = 0
                'M'            Dim SE As Integer = 0
                'M'            If dgvtiemper.Rows.Count > 0 Then
                For i = dgvtiemper.CurrentRow.Index To dgvtiemper.Rows.Count - 1
                        a = IIf(IsDBNull(dgvtiemper.Rows(i).Cells("Hora_Inicio").Value), "", dgvtiemper.Rows(i).Cells("Hora_Inicio").Value)
                        If a = "" Then
                            HO = Math.Abs(DateDiff(DateInterval.Hour, dtphoragene.Value, dtphoratermino.Value))
                            MI = DateDiff(DateInterval.Minute, dtphoragene.Value, dtphoratermino.Value)
                            SE = DateDiff(DateInterval.Second, dtphoragene.Value, dtphoratermino.Value)
                            MI = MI Mod 60
                            SE = SE Mod 60
                            If HO > "18" Then
                                MsgBox("La hora mayor a las horas permitidas cambiar fechas")
                                dtpfec_termino.Focus()
                                Exit Sub
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
        'M'    End If

    End Sub

    Private Sub btnact_Click(sender As Object, e As EventArgs) Handles btnact.Click
        'M'    If cmbactividad.Visible = False Then
        If dgvtiemper.Rows.Count > 0 Then
            For i = dgvtiemper.CurrentRow.Index To dgvtiemper.Rows.Count - 1
                'M'Act_Realizar
                If dgvtiemper.Rows(i).Cells(2).Value = "" Then
                    dgvtiemper.Rows(i).Cells(2).Value = txtact.Text
                    dgvtiemper.Refresh()
                End If
            Next
        Else
                MsgBox("No hay campos en el grid para agregar")
            End If
        'M'    ElseIf cmbactividad.Visible = True Then
        'M'        If dgvtiemper.Rows.Count > 0 Then
        'M'            'For i = dgvtiemper.CurrentRow.Index To dgvtiemper.Rows.Count - 1
        'M'            If dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Act_Realizar").Value = "" Then
        'M'                dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Act_Realizar").Value = cmbactividad.Text
        'M'                dgvtiemper.Refresh()
        'M'            End If
        'M'            'Next
        'M'        Else
        'M'            MsgBox("No hay campos en el grid para agregar")
        'M'        End If
        'M'    End If
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

    Private Sub FormELTBSTiem_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'M'   If txtdni.Text = "46618786" Then
        'M'       If dgvtiemper.CurrentRow.Index <> -1 Then
        'M'           dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("t_doc_ref").Value = ""
        'M'           dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("ser_doc_Ref").Value = ""
        'M'           dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("nro_doc_ref").Value = ""
        'M'       End If
        'M'   Else
        Dim frm As New FormBusquedaPerGrupo
            sBusAlm = "1"
            frm.ShowDialog()
        'M'   End If
    End Sub

    Private Sub btnmod_Click(sender As Object, e As EventArgs) Handles btnmod.Click
        Dim frm As New FormELTBDETSTIEM
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
                frm.txtact.Text = dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("ACT_REALIZAR").Value
                'M'           If cmbactividad.Visible = True Then
                'M'               frm.cmbactividad.Visible = True
            End If
            'M'   End If
        Else
            MsgBox("Nop hay personal para modificar")
            Exit Sub
        End If
        frm.ShowDialog()
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If dgvtiemper.CurrentRow.Index <> -1 Then

            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Inicio").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Hora_Final").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Dif_Hora").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Num_Hora").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("FEC_INICIO").Value = ""
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("FEC_TERMINO").Value = ""
            'dgvtiemper.Columns.Add("Hora_Inicio", "Hora Inicio")
            'dgvtiemper.Columns.Add("Hora_Final", "Hora Final")
            'dgvtiemper.Columns.Add("USUARIO_RP", "USUARIO_RP")
            'dgvtiemper.Columns.Add("Dif_Hora", "Dif. Hora")
            'dgvtiemper.Columns.Add("Num_Hora", "Num. Hora")
            'dgvtiemper.Columns.Add("FEC_INICIO", "Fec. Inicio")
            'dgvtiemper.Columns.Add("FEC_TERMINO", "Fec. Termino")
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If dgvtiemper.CurrentRow.Index <> -1 Then
            dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("Act_Realizar").Value = ""
        End If
    End Sub
    'M'    Private Sub supervisor()
    'M'        If txtdni.Text = "46618786" Then
    'M'            dgvtiemper.Height = 219
    'M'            dgvtiemper.Location = New Point(12, 389)
    'M'            lblNroOm.Visible = True
    'M'            txtNroOm.Visible = True
    'M'            btnNroOm.Visible = True
    'M'            btnIncluir.Visible = True
    'M'            cmbactividad.Visible = True
    'M'            Button3.Text = "Limpiar Nro.OM"
    'M'
    'M'            dgvtiemper.Columns.Clear()
    'M'            dgvtiemper.Columns.Add("t_doc_Ref", "T.Documento")
    'M'            dgvtiemper.Columns.Add("ser_doc_Ref", "S.Documento")
    'M'            dgvtiemper.Columns.Add("nro_doc_ref", "Nro.OM")
    'M'            dgvtiemper.Columns.Add("Codigo", "Codigo")
    'M'            dgvtiemper.Columns.Add("Nombre", "Apellidos y Nombre")
    'M'            dgvtiemper.Columns.Add("Act_Realizar", "Actividad Realizar")
    'M'            dgvtiemper.Columns.Add("Hora_Inicio", "Hora Inicio")
    'M'            dgvtiemper.Columns.Add("Hora_Final", "Hora Final")
    'M'            dgvtiemper.Columns.Add("USUARIO_RP", "USUARIO_RP")
    'M'            dgvtiemper.Columns.Add("Dif_Hora", "Dif. Hora")
    'M'            dgvtiemper.Columns.Add("Num_Hora", "Num. Hora")
    'M'            dgvtiemper.Columns.Add("FEC_INICIO", "Fec. Inicio")
    'M'            dgvtiemper.Columns.Add("FEC_TERMINO", "Fec. Termino")
    'M'            dgvtiemper.Columns.Add("COD_LINEA", "Area")
    'M'        Else
    'M'            dgvtiemper.Height = 244
    'M'            dgvtiemper.Location = New Point(12, 364)
    'M'            lblNroOm.Visible = False
    'M'            txtNroOm.Visible = False
    'M'            btnNroOm.Visible = False
    'M'            btnIncluir.Visible = False
    'M'            cmbactividad.Visible = False
    'M'            Button3.Text = "Agregar Grupo"
    'M'
    'M'            dgvtiemper.Columns.Clear()
    'M'            dgvtiemper.Columns.Add("Codigo", "Codigo")
    'M'            dgvtiemper.Columns.Add("Nombre", "Apellidos y Nombre")
    'M'            dgvtiemper.Columns.Add("Act_Realizar", "Actividad Realizar")
    'M'            dgvtiemper.Columns.Add("Hora_Inicio", "Hora Inicio")
    'M'            dgvtiemper.Columns.Add("Hora_Final", "Hora Final")
    'M'            dgvtiemper.Columns.Add("USUARIO_RP", "USUARIO_RP")
    'M'            dgvtiemper.Columns.Add("Dif_Hora", "Dif. Hora")
    'M'            dgvtiemper.Columns.Add("Num_Hora", "Num. Hora")
    'M'            dgvtiemper.Columns.Add("FEC_INICIO", "Fec. Inicio")
    'M'            dgvtiemper.Columns.Add("FEC_TERMINO", "Fec. Termino")
    'M'            dgvtiemper.Columns.Add("COD_LINEA", "Area")
    'M'        End If
    'M'
    'M'        dgvtiemper.Columns("USUARIO_RP").Visible = False
    'M'        dgvtiemper.Columns("FEC_INICIO").Visible = False
    'M'        dgvtiemper.Columns("FEC_TERMINO").Visible = False
    'M'        dgvtiemper.Columns("Dif_Hora").Visible = False
    'M'        dgvtiemper.Columns("COD_LINEA").Visible = False
    'M'    End Sub
    'M'    Private Sub btnNroOm_Click(sender As Object, e As EventArgs) Handles btnNroOm.Click
    'M'        sBusAlm = "123"
    'M'        Dim frm As New FormBUSQUEDA
    'M'        frm.ShowDialog()
    'M'        If gSubLinea <> Nothing Then
    'M'
    'M'            lblTdoc.Text = gLinea
    'M'            lblSdoc.Text = gSubLinea
    'M'            txtNroOm.Text = gArt
    'M'
    'M'            gLinea = Nothing
    'M'            gSubLinea = Nothing
    'M'            gArt = Nothing
    'M'
    'M'            'txtNroOm.Text = gSubLinea
    'M'            '  lblser_om.Text = gArt
    'M'            'gArt = Nothing
    'M'        Else
    'M'            'gArt = Nothing
    'M'            gLinea = Nothing
    'M'            gSubLinea = Nothing
    'M'            gArt = Nothing
    'M'        End If
    'M'    End Sub
    'M'   Private Sub txtNroOm_LostFocus(sender As Object, e As EventArgs) Handles txtNroOm.LostFocus
    'M'       Dim dt As DataTable
    'M'       Dim nro1 As String = txtNroOm.Text
    'M'       Dim cont As Integer = 0
    'M'       If txtNroOm.TextLength > 0 Then
    'M'           If nro1.Length = 1 Then
    'M'               txtNroOm.Text = "000000" & nro1
    'M'           ElseIf nro1.Length = 2 Then
    'M'               txtNroOm.Text = "00000" & nro1
    'M'           ElseIf nro1.Length = 3 Then
    'M'               txtNroOm.Text = "0000" & nro1
    'M'           ElseIf nro1.Length = 4 Then
    'M'               txtNroOm.Text = "000" & nro1
    'M'           ElseIf nro1.Length = 5 Then
    'M'               txtNroOm.Text = "00" & nro1
    'M'           ElseIf nro1.Length = 6 Then
    'M'               txtNroOm.Text = "0" & nro1
    'M'           ElseIf nro1.Length = 7 Then
    'M'               txtNroOm.Text = nro1
    'M'           End If
    'M'           dt = ELTBMTIEMBL.SelectNroOm(cmbserie.Text, txtNroOm.Text)
    'M'           'If dt = Nothing
    'M'           For Each Registro In dt.Rows
    'M'               cont = cont + 1
    'M'               lblTdoc.Text = IIf(IsDBNull(Registro("t_doc_ref")), "", Registro("t_doc_ref"))
    'M'               lblSdoc.Text = IIf(IsDBNull(Registro("ser_doc_ref")), "", Registro("ser_doc_ref"))
    'M'               'txtc_costo.Text = IIf(IsDBNull(Registro("CCO_CODDES")), "", Registro("CCO_CODDES"))
    'M'               'txt_linea.Text = IIf(IsDBNull(Registro("AREAORI")), "", Registro("AREAORI"))
    'M'               'cmb_linea_SelectedIndexChanged(sender, e)
    'M'               'cmb_linea.SelectedValue = IIf(IsDBNull(Registro("AREADES")), "", Registro("AREADES"))
    'M'               'txtc_costo_LostFocus(sender, e)
    'M'           Next
    'M'           If cont = 0 Then
    'M'               lblTdoc.Text = Nothing
    'M'               lblSdoc.Text = Nothing
    'M'               txtNroOm.Text = Nothing
    'M'           End If
    'M'       Else
    'M'           lblTdoc.Text = Nothing
    'M'           lblSdoc.Text = Nothing
    'M'       End If
    'M'   End Sub
    'M'   Private Sub datagrid()
    'M'       dgvtiemper.Columns.Clear()
    'M'       dgvtiemper.Columns.Add("Codigo", "Codigo")
    'M'       dgvtiemper.Columns.Add("Nombre", "Apellidos y Nombre")
    'M'       dgvtiemper.Columns.Add("Act_Realizar", "Actividad Realizar")
    'M'       dgvtiemper.Columns.Add("Hora_Inicio", "Hora Inicio")
    'M'       dgvtiemper.Columns.Add("Hora_Final", "Hora Final")
    'M'       dgvtiemper.Columns.Add("USUARIO_RP", "USUARIO_RP")
    'M'       dgvtiemper.Columns.Add("Dif_Hora", "Dif. Hora")
    'M'       dgvtiemper.Columns.Add("Num_Hora", "Num. Hora")
    'M'       dgvtiemper.Columns.Add("FEC_INICIO", "Fec. Inicio")
    'M'       dgvtiemper.Columns.Add("FEC_TERMINO", "Fec. Termino")
    'M'       dgvtiemper.Columns.Add("COD_LINEA", "Area")
    'M'   End Sub
    'M'
    'M'   Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
    'M'       If dgvtiemper.Rows.Count > 0 Then
    'M'           'For i = dgvtiemper.CurrentRow.Index To dgvtiemper.Rows.Count - 1
    'M'           If dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("nro_doc_ref").Value = "" And txtNroOm.Text <> Nothing Then
    'M'               dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("t_doc_Ref").Value = lblTdoc.Text
    'M'               dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("ser_doc_Ref").Value = lblSdoc.Text
    'M'               dgvtiemper.Rows(dgvtiemper.CurrentRow.Index).Cells("nro_doc_ref").Value = txtNroOm.Text
    'M'               dgvtiemper.Refresh()
    'M'           End If
    'M'           ' Next
    'M'       Else
    'M'           MsgBox("No hay campos en el grid para agregar")
    'M'       End If
    'M'   End Sub
End Class