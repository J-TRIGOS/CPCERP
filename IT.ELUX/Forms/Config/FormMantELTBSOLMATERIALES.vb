Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBSOLMATERIALES
    Private gpCaption As String
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private BINDCARDBL As New BINDCARDBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private SOLMATERIALESBL As New SOLMATERIALESBL
    Private ELTBUSERBL As New ELTBUSERBL
    Private ELPRODUCCIONBL As New ELPRODUCCIONBL
    Private BINDCARDBE As New BINDCARDBE
    Private bPrimero As Boolean = True
    Private sEstado As String
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    Private EST1 As String = 0

#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region

    Private Sub FormSolMmateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Solicitud de Materiales"
        Dim dt As DataTable
        Dim dt1 As DataTable
        'txtt_doc.Text = "SOLM"
        'dt = GUIAALMACENBL.SelectPer
        'GetCmb("cod", "nombre", dt, cmbdni)
        bPrimero = True
        dt = REQUERIMIENTOBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = REQUERIMIENTOBL.SelectPer()
        GetCmb("cod", "nombre", dt, cmbdni)

        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero") '5
        dgvt_doc.Columns.Add("CANTIDAD", "Cantidad") '6
        dgvt_doc.Columns.Add("ART_COD", "Cod. Art.") '7
        dgvt_doc.Columns.Add("NOM_ART", "Nom. Art.") '8
        dgvt_doc.Columns.Add("OBSERVA", "Observa") '9
        dgvt_doc.Columns.Add("USUARIO", "Usuario") '10
        dgvt_doc.Columns.Add("UNIDAD", "Und") '11
        dgvt_doc.Columns.Add("EST", "EST") '12
        dgvt_doc.Columns.Add("ACT_COD", "ACT_COD") '13
        dgvt_doc.Columns.Add("ART_ACT", "ART_ACT") '14
        dgvt_doc.Columns.Add("CCO_COD", "CCO_COD") '15
        dgvt_doc.Columns.Add("LINEA", "LINEA") '16
        dgvt_doc.Columns.Add("EST1", "EST1") '17
        dgvt_doc.Columns.Add("X_EST", "X_EST") '18
        dgvt_doc.Columns.Add("CANTIDAD2", "CANTIDAD2") '19

        'bPrimero = False
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                'CleanVar()
                habilitar(False)
                txtt_doc.Text = "SOLM"
                txtdni.Text = gsUser
                cmbt_doc.SelectedIndex = 0
                cmb_serdoc.SelectedIndex = 0
                cmbestado.SelectedIndex = 0
                txtsol.Text = SOLMATERIALESBL.SelectUsuario(txtdni.Text)
                cmbdni.SelectedValue = txtsol.Text
                cmbaño.Text = DateTime.Now.ToString("yyyy")
                cmb_linea.Enabled = False
                If dtpfecha.Value.ToString("yyyy/MM/dd") > "2021/02/12" Then
                    rdbant.Enabled = False
                    rdbnew.Enabled = False
                    cmbaño.Enabled = False
                    txtnumorden.Enabled = False
                    txtc_costo.Enabled = False
                    cmbc_costo.Enabled = False
                    txt_linea.Enabled = False
                    cmb_linea.Enabled = False
                    btnagregar.Enabled = True
                    btnborrar.Enabled = True
                    btnmodificar.Enabled = True
                End If
            Case 1
                flagAccion = "M"
                GetData("SOLM", sSDoc, sNDoc)
                bCuarto = "1"
                btndocu.Enabled = False
                cmb_serdoc.Enabled = False
                Dim dtArticulo As DataTable
                dtArticulo = SOLMATERIALESBL.getListdgv("SOLM", sSDoc, sNDoc)
                For Each row As DataRow In dtArticulo.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                      IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),'6
                                      IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'7
                                      IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),'8
                                      IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),'9
                                      IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),'10
                                      IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),'11
                                      IIf(IsDBNull(row("EST")), "", row("EST")),'12
                                      IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")),'13
                                      IIf(IsDBNull(row("ART_ACT")), "", row("ART_ACT")),'14
                                      IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),'15
                                      IIf(IsDBNull(row("LINEA")), "", row("LINEA")),'16
                                      IIf(IsDBNull(row("ESTADO_DET")), "", row("ESTADO_DET")),'17
                                      IIf(IsDBNull(row("X_EST")), "", row("X_EST")),'18
                                      IIf(IsDBNull(row("CANTIDAD2")), "", row("CANTIDAD2"))) '19
                Next
                Dim i As Integer
                For i = 0 To 14
                    If i <> 13 Then
                        dgvt_doc.Columns(i).ReadOnly = True
                    End If
                Next
                Try
                    dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(3)
                Catch ex As Exception
                    MsgBox("No hay datos en el detalle")
                End Try
                Me.btnborrar.Enabled = False
                Me.btnagregar.Enabled = False
                txtc_costo.Select()
                'If sOp = "0" Then
                'End If
                If dtpfecha.Value <= "12/02/2021" Then
                    dt = ELPRODUCCIONBL.LineaProd(cmbaño.Text, txtnumorden.Text)
                    For Each Registro In dt.Rows
                        txt_linea.Text = IIf(IsDBNull(Registro("COD_AREA")), "", Registro("COD_AREA"))
                        txtcodart.Text = IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD"))
                        txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                        txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                        cmbc_costo.SelectedValue = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                        dt1 = SOLMATERIALESBL.gArea1(cmbc_costo.SelectedValue)
                        GetCmb("cod", "nom", dt1, cmb_linea)
                        cmb_linea.SelectedValue = IIf(IsDBNull(Registro("COD_AREA")), "", Registro("COD_AREA"))
                    Next
                Else
                    rdbant.Enabled = False
                    rdbnew.Enabled = False
                    cmbaño.Enabled = False
                    txtnumorden.Enabled = False
                    txtc_costo.Enabled = False
                    cmbc_costo.Enabled = False
                    txt_linea.Enabled = False
                    cmb_linea.Enabled = False
                End If


        End Select
        dgvt_doc.Columns(0).Visible = False
        dgvt_doc.Columns(1).Visible = False
        dgvt_doc.Columns(2).Visible = False
        dgvt_doc.Columns(9).Visible = False
        dgvt_doc.Columns(10).Visible = False
        dgvt_doc.Columns(11).Visible = False
        dgvt_doc.Columns(12).Visible = False
        dgvt_doc.Columns(13).Visible = False
        dgvt_doc.Columns(14).Visible = False
        dgvt_doc.Columns(15).Visible = False
        dgvt_doc.Columns(16).Visible = False
        dgvt_doc.Columns(17).Visible = False
        dgvt_doc.Columns(18).Visible = False
        dgvt_doc.Columns(19).Visible = False
        bPrimero = False
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
            'Case "delete"
            '    DeleteData()

            Case "exit"
                Dispose()
                Exit Sub
            Case "Print"
                gsRptArgs = {}
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmb_serdoc.SelectedItem
                gsRptArgs(1) = txtnumero.Text
                If txtcodart.Text = "" Then
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SOLM.rpt"
                Else
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SOLM1.rpt"
                End If

                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "anular"
                Dim CA As Integer = 0
                For i = 0 To dgvt_doc.Rows.Count - 1
                    If dgvt_doc.Rows(i).Cells("EST1").Value = "3" Then
                        CA = CA + 1
                    End If
                Next
                If CA > 0 Then
                    MsgBox("No se puede Anular el documento debido a que esta en proceso de aprobacion")
                    Exit Sub
                End If
                If MessageBox.Show("Desea anular el documento",
                   "Anular documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim SOLMATERIALESBE As New SOLMATERIALESBE
                Dim ELTBDETSOLMATERIALESBE As New ELTBDETSOLMATERIALESBE
                Dim ELMVALMABE As New ELMVALMABE
                SOLMATERIALESBE.T_DOC_REF = txtt_doc.Text
                SOLMATERIALESBE.SER_DOC_REF = cmb_serdoc.Text
                SOLMATERIALESBE.NRO_DOC_REF = txtnumero.Text


                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = SOLMATERIALESBL.SaveRow(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, "A", dgvt_doc)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    cmb_serdoc.Enabled = False
                    Me.btnborrar.Enabled = False
                    Me.btnagregar.Enabled = False
                    Dim i As Integer
                    For i = 0 To 13
                        dgvt_doc.Columns(i).ReadOnly = True
                    Next
                    'Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If



                Exit Sub
        End Select
    End Sub

    Public Sub habilitar(ByVal est As Boolean)
        btnagregar.Enabled = est
        btnmodificar.Enabled = est
        btnborrar.Enabled = est
    End Sub
    Private Function OkData() As Boolean
        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If txtsol.Text = "" Then
            MsgBox("Por favor ingrese el dni de la persona que solicita", MsgBoxStyle.Exclamation)
            txtsol.Select()
            Return False
        End If
        If txtt_doc.Text = "" Then
            MsgBox("Por favor ingrese el tipo de documento", MsgBoxStyle.Exclamation)
            txtsol.Select()
            Return False
        End If
        If dtpfecha.Value.ToString("yyyy/MM/dd") <= "2021/02/12" Then
            If txt_linea.Text = "" Then
                MsgBox("Por favor ingrese el area", MsgBoxStyle.Exclamation)
                txt_linea.Focus()
                Return False
            End If
            If cmb_linea.SelectedIndex = -1 Then
                txt_linea.Text = ""
                MsgBox("Por favor ingrese el area", MsgBoxStyle.Exclamation)
                txt_linea.Select()
                Return False
            End If
            If rdbnew.Checked Then
                If txtnumorden.TextLength = 0 Or txtnumorden.Text = "000000000" Then
                    MsgBox("No ah ingresado un numero de OP.")
                    txtnumorden.Select()
                    Return False
                End If
            End If
        End If

        Dim ELTBSTIEMBL As New ELTBSTIEMBL
        If gsUser <> "SISTEMA" Then
            If EST1 = "3" Then
                If ELTBSTIEMBL.SelPermiso(gsUser) <> "1" Then
                    MsgBox("No se puede modificar el documento por que ya se encuentra atendido")
                    Return False
                End If
            End If
        End If

        Return True
    End Function
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If OkData() = False Then
            Exit Sub
        End If

        'If Math.Abs(DateTime.Now.ToString("dd") - dtpfecha.Value.Day) > 2 Then
        '    MsgBox("La fecha de ingreso no debe ser mayor a la fecha actual")
        '    Exit Sub
        'End If
        For i = 0 To dgvt_doc.Rows.Count - 1
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value = "" Then
                MsgBox("No se puede guardar por que faltan datos del detalle que completar")
                Exit Sub
            End If
        Next
        Dim ELTBSTIEMBL As New ELTBSTIEMBL
        Dim dtpini As DateTime = dtpfecha.Value.AddDays(+6).ToShortDateString
        Dim Today As DateTime = DateTime.Now.ToShortDateString
        Dim vMes As Integer = dtpfecha.Value.Month
        Dim vAño As Integer = dtpfecha.Value.Year
        If gsUser <> "SISTEMA" Then
            If ELTBSTIEMBL.SelPermiso(gsUser) = "1" Then
                If vMes >= (Month(DateTime.Now.ToString("dd/MM/yyyy")) - 1) And vAño = Year(DateTime.Now.ToString("dd/MM/yyyy")) Then
                Else
                    If vMes = "12" And vAño = (Year(DateTime.Now.ToString("dd/MM/yyyy")) - 1) Then
                    Else
                        MsgBox("La fecha de ingreso no debe ser mayor a la fecha actual")
                        Exit Sub
                    End If
                End If
            Else
                ' If Math.Abs(DateTime.Now.ToString("dd") - dtpfecha.Value.Day) > 2 Then
                '
                '     MsgBox("La fecha de ingreso no debe ser mayor a la fecha actual")
                '     Exit Sub
                ' End If
                'If (DateTime.Compare(DateTime.Now.AddDays(-3), dtpfecha.Value) > 0) Then
                '    Exit Sub
                'End If
            End If
        End If

        '
        '

        Dim dgv As DataGridView
        For i = 0 To dgvt_doc.Rows.Count - 1
            dgvt_doc.Rows(i).Cells("UNIDAD").Value = ARTICULOBL.SelectUniMed(Trim(dgvt_doc.Rows(i).Cells("ART_COD").Value))
            If dtpfecha.Value.ToString("yyyy/MM/dd") <= "2021/02/12" Then
                If txtnumorden.TextLength > 0 And txtnumorden.Text <> "000000000" Then
                    dgvt_doc.Rows(i).Cells("T_DOC_REF1").Value = "OPRD"
                    dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value = cmbaño.Text
                    dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value = txtnumorden.Text
                End If
            End If
        Next
        Try
            If flagAccion = "N" Then
                Dim nro As String
                txtnumero.Text = ""
                nro = SOLMATERIALESBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
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
            Dim SOLMATERIALESBE As New SOLMATERIALESBE
            Dim ELTBDETSOLMATERIALESBE As New ELTBDETSOLMATERIALESBE
            SOLMATERIALESBE.T_DOC_REF = RTrim(txtt_doc.Text)
            SOLMATERIALESBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
            SOLMATERIALESBE.NRO_DOC_REF = RTrim(txtnumero.Text)
            SOLMATERIALESBE.FEC_GENE = RTrim(dtpfecha.Value)
            SOLMATERIALESBE.NRO_ORDEN = txtnumorden.Text
            If txtnumorden.TextLength > 0 Then
                SOLMATERIALESBE.SER_ORDEN = cmbaño.Text
            End If
            If cmbestado.SelectedIndex = 0 Then
                SOLMATERIALESBE.EST = "H"
            ElseIf cmbestado.SelectedIndex = 1 Then
                SOLMATERIALESBE.EST = "A"
            ElseIf cmbestado.SelectedIndex = -1 Then
                SOLMATERIALESBE.EST = ""
            End If
            If dtpfanul.Checked Then
                SOLMATERIALESBE.FEC_ANU = dtpfanul.Value
            Else
                SOLMATERIALESBE.FEC_ANU = Nothing
            End If
            SOLMATERIALESBE.OBSERVA = RTrim(txtobservacion.Text)
            SOLMATERIALESBE.CCO_COD = RTrim(txtc_costo.Text)
            SOLMATERIALESBE.USUARIO = Trim(gsCodUsr)
            SOLMATERIALESBE.FEC_DIA = RTrim(DateTime.Now)
            SOLMATERIALESBE.LINEA = RTrim(txt_linea.Text)
            ELTBDETSOLMATERIALESBE.T_DOC_REF = txtt_doc.Text
            ELTBDETSOLMATERIALESBE.SER_DOC_REF = cmb_serdoc.Text
            ELTBDETSOLMATERIALESBE.NRO_DOC_REF = txtnumero.Text
            SOLMATERIALESBE.USUARIO_SOL = txtsol.Text
            Dim ELMVLOGSBE As New ELMVLOGSBE
            ELMVLOGSBE.log_codusu = gsCodUsr
            Dim nvl As String = ELTBUSERBL.SelectUsuNvl(gsCodUsr)
            'If Then
            'End If
            '

            'If flagAccion = "N" Then
            gsError = SOLMATERIALESBL.SaveRow(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, flagAccion, dgvt_doc)
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                cmb_serdoc.Enabled = False
                'sEstAlmac = cmbalmac.SelectedValue
                Me.btnborrar.Enabled = False
                'Me.btndocu.Enabled = False
                Me.btnagregar.Enabled = False
                Dim i As Integer
                For i = 0 To 12
                    dgvt_doc.Columns(i).ReadOnly = True
                Next
                'Dispose()
                If flagAccion = "N" Then
                    If nvl = "1" Then
                        SOLMATERIALESBE.USUARIO_OB = gsUser
                        SOLMATERIALESBE.USUARIO_VB = gsUser
                        ELMVLOGSBE.log_codusu = gsCodUsr
                        SOLMATERIALESBE.USUARIO_VB = gsUser
                        gsError2 = SOLMATERIALESBL.SaveRow(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, "AS1", dgv)
                        If gsError2 = "OK" Then
                            MsgBox("Solicitud Auto Aprobada por Nivel de Usuario", MsgBoxStyle.Information)
                        Else
                            FormMain.LblError.Text = gsError2
                            MsgBox("Error al Generar la Aprobacion", MsgBoxStyle.Critical)
                        End If
                    End If
                End If
                tsbGrabar.Enabled = False
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
            flagAccion = "M"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = SOLMATERIALESBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmbt_doc.SelectedIndex = 0
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            txtnumorden.Text = IIf(IsDBNull(Registro("NRO_ORDEN")), "", Registro("NRO_ORDEN"))
            If txtnumorden.TextLength = 0 Then
                rdbant.Checked = True
            End If
            cmbaño.Text = IIf(IsDBNull(Registro("SER_ORDEN")), "", Registro("SER_ORDEN"))
            Select Case Registro("EST").ToString
                Case ""
                    cmbestado.SelectedIndex = -1
                Case "H"
                    cmbestado.SelectedIndex = 0
                Case "A"
                    cmbestado.SelectedIndex = 1
            End Select
            If cmbestado.SelectedIndex = 1 Then
                dtpfanul.Checked = True
                dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            End If
            'cmbestado.Text = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))

            txtdni.Text = IIf(IsDBNull(Registro("NOMUSR")), "", Registro("NOMUSR"))
            txtsol.Text = IIf(IsDBNull(Registro("USUARIO_SOL")), "", Registro("USUARIO_SOL"))
            cmbdni.SelectedValue = txtsol.Text
            txtobservacion.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            If dtpfecha.Value.ToString("yyyy/MM/dd") <= "2021/02/12" Then
                txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                cmbc_costo.SelectedValue = txtc_costo.Text
                Dim dt As DataTable
                txt_linea.Text = IIf(IsDBNull(Registro("LINEA")), "", Registro("LINEA"))
                If SOLMATERIALESBL.SelLinea(txt_linea.Text) = 0 Then
                    dt = SOLMATERIALESBL.gArea1(cmbc_costo.SelectedValue)
                Else
                    dt = SOLMATERIALESBL.gArea(cmbc_costo.SelectedValue)
                End If
                GetCmb("cod", "nom", dt, cmb_linea)
                cmb_linea.SelectedValue = txt_linea.Text
            End If

            'If Mid(txt_linea.Text, 1, 1) = "0" Then
            '    dt = SOLMATERIALESBL.gArea1(cmbc_costo.SelectedValue)
            'Else
            '    dt = SOLMATERIALESBL.gArea(cmbc_costo.SelectedValue)
            'End If


            EST1 = IIf(IsDBNull(Registro("EST1")), "", Registro("EST1"))
        Next

    End Sub


    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim frm As New FormELTBDETSOLMATERIALES
        frm.cmbaño.Text = DateTime.Now.ToString("yyyy")
        Dim dt As DataTable
        dt = REQUERIMIENTOBL.SelectCCosto
        GetCmb("cod", "nom", dt, frm.cmbc_costo)
        gContador = 1
        frm.bfecha = dtpfecha.Value
        frm.ShowDialog()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        If dgvt_doc.Rows.Count > 0 Then
            If dgvt_doc.SelectedRows.Count > 0 Then
                Dim frm As New FormELTBDETSOLMATERIALES
                If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("EST1").Value = "3" Then
                    MsgBox("Esta solicitud ya esta atendida o cerrada")
                    If gsUser <> "DCONDOR" Or gsUser <> "SISTEMA" Then
                        frm.btnagregar.Enabled = False
                    End If
                End If
                If dtpfecha.Value.ToString("yyyy/MM/dd") > "2021/02/12" Then
                    If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(3).Value = "OPRD" Then
                        frm.cmbaño.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(4).Value
                        frm.txtnumorden.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(5).Value
                        If txtnumero.TextLength = 0 Then
                            rdbant.Checked = True
                            rdbnew.Checked = False
                        Else
                            frm.a = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(4).Value
                            frm.b = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(5).Value
                            frm.c = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(15).Value
                            frm.d = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value
                        End If
                        Dim dt As DataTable
                        frm.txtc_costo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(15).Value
                        dt = REQUERIMIENTOBL.SelectCCosto
                        GetCmb("cod", "nom", dt, frm.cmbc_costo)
                        frm.cmbc_costo.SelectedValue = frm.txtc_costo.Text
                        frm.txt_linea.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value
                        If SOLMATERIALESBL.SelLinea(frm.txt_linea.Text) = 0 Then
                            dt = SOLMATERIALESBL.gArea1(frm.cmbc_costo.SelectedValue)
                        Else
                            dt = SOLMATERIALESBL.gArea(frm.cmbc_costo.SelectedValue)
                        End If
                        GetCmb("cod", "nom", dt, frm.cmb_linea)
                        frm.cmb_linea.SelectedValue = frm.txt_linea.Text
                        rdbnew.Checked = True
                    ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(3).Value = "TMANT" Then
                        frm.cmbaño.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(4).Value
                        frm.txtnumorden.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(5).Value
                        If txtnumero.TextLength = 0 Then
                            rdbant.Checked = True
                            rdbnew.Checked = False
                        Else
                            frm.a = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(4).Value
                            frm.b = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(5).Value
                            frm.c = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(15).Value
                            frm.d = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value
                            frm.et = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(3).Value
                        End If
                        Dim dt As DataTable
                        frm.txtc_costo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(15).Value
                        dt = REQUERIMIENTOBL.SelectCCosto
                        GetCmb("cod", "nom", dt, frm.cmbc_costo)
                        frm.cmbc_costo.SelectedValue = frm.txtc_costo.Text
                        frm.txt_linea.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value
                        If SOLMATERIALESBL.SelLinea(frm.txt_linea.Text) = 0 Then
                            dt = SOLMATERIALESBL.gArea1(frm.cmbc_costo.SelectedValue)
                        Else
                            dt = SOLMATERIALESBL.gArea(frm.cmbc_costo.SelectedValue)
                        End If
                        GetCmb("cod", "nom", dt, frm.cmb_linea)
                        frm.cmb_linea.SelectedValue = frm.txt_linea.Text
                        rdbnew.Checked = True
                    Else
                        gsCode13 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(3).Value
                        rdbnew.Checked = False
                        rdbant.Checked = True
                        Dim dt As DataTable
                        frm.txtc_costo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(15).Value
                        dt = REQUERIMIENTOBL.SelectCCosto
                        GetCmb("cod", "nom", dt, frm.cmbc_costo)
                        frm.cmbc_costo.SelectedValue = frm.txtc_costo.Text
                        frm.txt_linea.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value
                        If SOLMATERIALESBL.SelLinea(frm.txt_linea.Text) = 0 Then
                            dt = SOLMATERIALESBL.gArea1(frm.cmbc_costo.SelectedValue)
                        Else
                            dt = SOLMATERIALESBL.gArea(frm.cmbc_costo.SelectedValue)
                        End If
                        GetCmb("cod", "nom", dt, frm.cmb_linea)
                        frm.cmb_linea.SelectedValue = frm.txt_linea.Text
                        frm.a = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(4).Value
                        frm.b = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(5).Value
                        frm.c = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(15).Value
                        frm.d = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value
                    End If
                End If
                frm.bfecha = dtpfecha.Value
                gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(7).Value
                sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(11).Value
                frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(6).Value
                frm.txtcodart.Text = gsCode3
                frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
                If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(13).Value = Nothing Then
                    frm.txtactivo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(14).Value
                Else
                    frm.txtactivo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(13).Value
                End If
                'frm.cmbactivo.SelectedValue = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(13).Value
                'frm.btnagregar.Enabled = False
                'End If
                gsCode10 = "1"
                gContador = 0
                frm.ShowDialog()
                gsCode10 = ""
            Else
                MsgBox("No ah seleccionado ningun articulo item para modificar")
            End If

        Else
            MsgBox("No hay items en la lista para modificar")
        End If
        If dtpfecha.Value.ToString("yyyy/MM/dd") > "2021/02/12" Then
            rdbant.Enabled = False
            rdbnew.Enabled = False
            cmbaño.Enabled = False
            txtnumorden.Enabled = False
            txtc_costo.Enabled = False
            cmbc_costo.Enabled = False
            txt_linea.Enabled = False
            cmb_linea.Enabled = False
        End If
        gsCode13 = ""
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("EST1").Value = "3" Then
                MsgBox("Esta solicitud ya esta atendida o cerrada")
                If gsUser <> "DCONDOR" Or gsUser <> "SISTEMA" Then
                    Exit Sub
                End If
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub cmb_linea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_linea.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Try
            txt_linea.Text = cmb_linea.SelectedValue
            habilitar(True)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FormELTBSOLMATERIALES_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        Dim nro As String
        txtnumero.Text = ""
        nro = SOLMATERIALESBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
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
    End Sub

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
        'MsgBox(dtpfecha.Value.ToString("dd/MM/yyyy"))
        Dim sFecha As String = "02/10/2020"
        Dim dt As DataTable
        'MsgBox(dtpfecha.Value.ToString("dd/MM/yyyy"))
        If sFecha <= dtpfecha.Value.ToString("dd/MM/yyyy") Then
            Try
                dt = SOLMATERIALESBL.gArea1(cmbc_costo.SelectedValue)
                GetCmb("cod", "nom", dt, cmb_linea)
            Catch ex As Exception
                MsgBox("El centro de costo no cuenta con Area")
            End Try
        Else
            Try
                dt = SOLMATERIALESBL.gArea(cmbc_costo.SelectedValue)
                GetCmb("cod", "nom", dt, cmb_linea)
            Catch ex As Exception
                MsgBox("El centro de costo no cuenta con Area")
            End Try
        End If
        txtobservacion.Select()
    End Sub

    Private Sub txt_linea_LostFocus(sender As Object, e As EventArgs) Handles txt_linea.LostFocus
        If cmb_linea.Items.Count > 0 Then
            If txt_linea.Text = "" Then
                cmb_linea.SelectedValue = ""
                Exit Sub
            End If
            cmb_linea.SelectedValue = txt_linea.Text
            'Dim dt As DataTable
            'dt = ARTICULOBL.getListcmb13()
            'GetCmb("cod", "nom", dt, cmb_linea)
            'If cmb_linea.SelectedValue Is Nothing Then
            '    MsgBox("La linea no existe no existe", MsgBoxStyle.Exclamation)
            '    txt_linea.Text = ""
            '    txt_linea.Select()
            'Else
            If flagAccion = "N" Then
                habilitar(True)
            End If
            'End If
        End If
    End Sub

    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        Dim sFecha As String = "02/10/2020"
        cmbc_costo.SelectedValue = txtc_costo.Text
        If flagAccion = "N" Then
            If cmbc_costo.SelectedValue Is Nothing Then
                MsgBox("El centro de costo no existe", MsgBoxStyle.Exclamation)
                txtc_costo.Text = ""
                txtc_costo.Select()
            Else

                If cmbc_costo.SelectedIndex > -1 Then
                    Dim dt As DataTable
                    If sFecha <= dtpfecha.Value.ToString("dd/MM/yyyy") Then
                        Try
                            dt = SOLMATERIALESBL.gArea1(cmbc_costo.SelectedValue)
                            GetCmb("cod", "nom", dt, cmb_linea)
                        Catch ex As Exception
                            MsgBox("El centro de costo no cuenta con Area")
                        End Try
                    Else
                        Try
                            dt = SOLMATERIALESBL.gArea(cmbc_costo.SelectedValue)
                            GetCmb("cod", "nom", dt, cmb_linea)
                        Catch ex As Exception
                            MsgBox("El centro de costo no cuenta con Area")
                        End Try
                    End If
                    'Try
                    '    dt = SOLMATERIALESBL.gArea(cmbc_costo.SelectedValue)
                    '    GetCmb("cod", "nom", dt, cmb_linea)
                    'Catch ex As Exception
                    '    MsgBox("El centro de costo no cuenta con Area")
                    'End Try
                End If
            End If

        End If
    End Sub



    Private Sub txtnumorden_LostFocus(sender As Object, e As EventArgs) Handles txtnumorden.LostFocus
        Dim dt As DataTable
        Dim dt1 As DataTable
        If rdbnew.Checked Then
            txtnumorden.Text = txtnumorden.Text.PadLeft(9, "0")
            dt = ELPRODUCCIONBL.LineaProd(cmbaño.Text, txtnumorden.Text)
            For Each Registro In dt.Rows
                txt_linea.Text = IIf(IsDBNull(Registro("COD_AREA")), "", Registro("COD_AREA"))
                txtcodart.Text = IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD"))
                txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                cmbc_costo.SelectedValue = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                dt1 = SOLMATERIALESBL.gArea1(cmbc_costo.SelectedValue)
                GetCmb("cod", "nom", dt1, cmb_linea)
                cmb_linea.SelectedValue = IIf(IsDBNull(Registro("COD_AREA")), "", Registro("COD_AREA"))
            Next
            If txtcodart.Text = "" Then
                MsgBox("La Orden de Produccion No existe o ya esta completa")
            End If
            If txtnumorden.Text = "000000000" Then
                MsgBox("Si no cuenta con numero de Orden Por favor marque Sin OP")
            End If


        End If
        SinConOP()

    End Sub
    Private Sub SinConOP()
        If dtpfecha.Value.ToString("yyyy/MM/dd") <= "2021/02/12" Then
            If dgvt_doc.Rows.Count > 0 And txtnumorden.Text <> Nothing And rdbnew.Checked = True Then
                For i As Integer = 0 To dgvt_doc.Rows.Count - 1
                    dgvt_doc.Rows(i).Cells(3).Value = "OPRD"
                    dgvt_doc.Rows(i).Cells(4).Value = cmbaño.Text
                    dgvt_doc.Rows(i).Cells(5).Value = txtnumorden.Text
                Next
            ElseIf dgvt_doc.Rows.Count > 0 And txtnumorden.Text = Nothing Then
                For i As Integer = 0 To dgvt_doc.Rows.Count - 1
                    dgvt_doc.Rows(i).Cells(3).Value = txtt_doc.Text
                    dgvt_doc.Rows(i).Cells(4).Value = cmb_serdoc.Text
                    dgvt_doc.Rows(i).Cells(5).Value = txtnumero.Text
                Next
            End If
        End If

    End Sub

    Private Sub dtpfecha_Validated(sender As Object, e As EventArgs) Handles dtpfecha.Validated
        Dim mes As String
        Dim ELTBSTIEMBL As New ELTBSTIEMBL
        Dim dtpini As DateTime = dtpfecha.Value.AddDays(+6).ToShortDateString
        Dim Today As DateTime = DateTime.Now.ToShortDateString
        Dim vMes As Integer = dtpfecha.Value.Month
        Dim vAño As Integer = dtpfecha.Value.Year
        'MsgBox(Math.Abs(DateTime.Now.ToString("dd") - dtpfecha.Value.Day))
        'If Math.Abs(DateTime.Now.ToString("dd") - dtpfecha.Value.Day) > 2 Then
        If gsUser <> "SISTEMA" Then
            If ELTBSTIEMBL.SelPermiso(gsUser) = "1" Then
                If vMes >= (Month(DateTime.Now.ToString("dd/MM/yyyy")) - 1) And vAño = Year(DateTime.Now.ToString("dd/MM/yyyy")) Then
                Else
                    If vMes = "12" And vAño = (Year(DateTime.Now.ToString("dd/MM/yyyy")) - 1) Then
                    Else
                        MsgBox("La fecha de ingreso no debe ser mayor a la fecha actual")
                        Exit Sub
                    End If
                End If
            Else
                If DateTime.Compare(dtpini, Today) <= 0 Then
                    MsgBox("La fecha de ingreso no debe ser mayor a la fecha actual")
                    Exit Sub
                End If
            End If
        Else
            Exit Sub
        End If
        If sAño - dtpfecha.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfecha.Value.Month = "12" Then
            If DateTime.Now.ToString("dd") > 11 Then
                MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                'cierre(False)
                'fechapasada = "Si"
                Exit Sub
            End If
        Else
            If sAño > dtpfecha.Value.Year Or sAño < dtpfecha.Value.Year Then
                dtpfecha.Select()
                MsgBox("El año es mayor o menor al año actual", MsgBoxStyle.Information)
                'cierre(False)
                'fechapasada = "Si"
                Exit Sub
            End If

            If DateTime.Now.ToString("MM") <> dtpfecha.Value.Month Then

                If dtpfecha.Value.Month > DateTime.Now.ToString("MM") Then
                    dtpfecha.Select()
                    MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                    'cierre(False)
                    'fechapasada = "Si"
                    Exit Sub
                ElseIf dtpfecha.Value.Month < DateTime.Now.ToString("MM") Then
                    'If CInt(sMes1) > dtpfecha.Value.Month Then
                    mes = DateTime.Now.ToString("MM") - dtpfecha.Value.Month
                    If mes = 1 Then
                        'Modificacion de de fechas 
                        'If DateTime.Now.ToString("dd") > 14 Then
                        If DateTime.Now.ToString("dd") > 11 Then
                            MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                            'cierre(False)
                            'fechapasada = "Si"
                            Exit Sub
                        End If
                    ElseIf mes > 1 Then
                        dtpfecha.Select()
                        MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                        'cierre(False)
                        'fechapasada = "Si"
                        Exit Sub
                    End If
                    'End If
                End If

            End If
            If CInt(sMes2) < dtpfecha.Value.Month Then
                dtpfecha.Select()
                MsgBox("El mes es menor al permitido", MsgBoxStyle.Information)
                'cierre(False)
                'fechapasada = "Si"
                Exit Sub
            ElseIf CInt(sMes2) > dtpfecha.Value.Month Then
                mes = sMes2 - dtpfecha.Value.Month
                If mes = 1 Then
                    'Modificacion de de fechas 
                    'If DateTime.Now.ToString("dd") > 14 Then
                    If DateTime.Now.ToString("dd") > 11 Then
                        MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                        'cierre(False)
                        'fechapasada = "Si"
                        Exit Sub
                    End If
                ElseIf mes > 1 Then
                    dtpfecha.Select()
                    MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                    'cierre(False)
                    'fechapasada = "Si"
                    Exit Sub
                End If
            End If

        End If

        'cierre(True)
        'fechapasada = "No"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "228"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtsol.Text = gLinea
            cmbdni.SelectedValue = txtsol.Text

            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtsol_LostFocus(sender As Object, e As EventArgs) Handles txtsol.LostFocus
        If txtsol.Text = "" Then
            cmbdni.SelectedValue = ""
            Exit Sub
        End If
        cmbdni.SelectedValue = txtsol.Text
        If cmbdni.SelectedValue Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtsol.Text = ""

        End If
    End Sub

    Private Sub cmbdni_LostFocus(sender As Object, e As EventArgs) Handles cmbdni.LostFocus
        If cmbdni.SelectedIndex = -1 Then
            MsgBox("Seleccione un dni de Personal")
            cmbdni.Select()
        End If
    End Sub

    Private Sub cmbdni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdni.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbdni.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtsol.Text = cmbdni.SelectedValue
    End Sub

    Private Sub txt_linea_TextChanged(sender As Object, e As EventArgs) Handles txt_linea.TextChanged

    End Sub

    Private Sub rdbnew_CheckedChanged(sender As Object, e As EventArgs) Handles rdbnew.CheckedChanged
        If rdbnew.Checked Then
            cmbc_costo.Enabled = False
            txtc_costo.Enabled = False
            cmb_linea.Enabled = False
            txt_linea.Enabled = False
            txtnumorden.MaxLength = 9
            'cmbaño.Visible = True
            cmbaño.Text = sAño
            txt_linea.Text = ""
            txtc_costo.Text = ""
            txtnumorden.Text = ""
            cmbc_costo.SelectedIndex = -1
            cmb_linea.SelectedIndex = -1
            'End If
            SinConOP()
        Else
            cmbc_costo.Enabled = True
            txtc_costo.Enabled = True
            cmb_linea.Enabled = True
            txt_linea.Enabled = True
            txtnumorden.MaxLength = 9
            'cmbaño.Visible = False
            cmbaño.Text = sAño
            txt_linea.Text = ""
            txtc_costo.Text = ""
            txtnumorden.Text = ""
            cmbc_costo.SelectedIndex = -1
            cmb_linea.SelectedIndex = -1
            SinConOP()
        End If
    End Sub

    Private Sub rdbant_CheckedChanged(sender As Object, e As EventArgs) Handles rdbant.CheckedChanged
        If rdbnew.Checked Then
            cmbc_costo.Enabled = False
            txtc_costo.Enabled = False
            cmb_linea.Enabled = False
            txt_linea.Enabled = False
            txtnumorden.MaxLength = 9
            'cmbaño.Visible = True
            cmbaño.Text = sAño
            txt_linea.Text = ""
            txtc_costo.Text = ""
            txtnumorden.Text = ""
            cmbc_costo.SelectedIndex = -1
            cmb_linea.SelectedIndex = -1
            txtcodart.Text = ""
            txtnomart.Text = ""
        Else
            cmbc_costo.Enabled = True
            txtc_costo.Enabled = True
            cmb_linea.Enabled = True
            txt_linea.Enabled = True
            txtnumorden.MaxLength = 9
            'cmbaño.Visible = False
            cmbaño.Text = sAño
            txt_linea.Text = ""
            txtc_costo.Text = ""
            txtnumorden.Text = ""
            cmbc_costo.SelectedIndex = -1
            cmb_linea.SelectedIndex = -1
            txtcodart.Text = ""
            txtnomart.Text = ""
        End If
    End Sub

    Private Sub dtpfecha_LostFocus(sender As Object, e As EventArgs) Handles dtpfecha.LostFocus
        If dtpfecha.Value.ToString("yyyy/MM/dd") > "2021/02/12" Then
            rdbant.Enabled = False
            rdbnew.Enabled = False
            cmbaño.Enabled = False
            txtnumorden.Enabled = False
            txtc_costo.Enabled = False
            cmbc_costo.Enabled = False
            txt_linea.Enabled = False
            cmb_linea.Enabled = False
            btnagregar.Enabled = True
            btnborrar.Enabled = True
            btnmodificar.Enabled = True
        Else
            rdbant.Enabled = True
            rdbnew.Enabled = True
            cmbaño.Enabled = True
            txtnumorden.Enabled = True
            txtc_costo.Enabled = False
            cmbc_costo.Enabled = False
            txt_linea.Enabled = False
            cmb_linea.Enabled = False
            btnagregar.Enabled = False
            btnborrar.Enabled = False
            btnmodificar.Enabled = False
        End If
    End Sub

    Private Sub btn_bindcard_Click(sender As Object, e As EventArgs) Handles btn_bindcard.Click
        Dim fila As Integer
        Dim resp = 0

        If dgvt_doc.SelectedRows.Count > 0 Then
            fila = dgvt_doc.CurrentRow.Index
            resp = MsgBox("Desea Generar BINDCARD para el articulo seleccionado?", MsgBoxStyle.YesNo)
            If resp = 6 Then
                generarBindCard(fila)
            End If
        Else
            MessageBox.Show("Selecciona una fila")
        End If
    End Sub

    Private Sub generarBindCard(ByVal fila As Integer)
        Dim dtVerificar As New DataTable
        Dim estado As Integer = 0
        flagAccion = "N"
        BINDCARDBE.SER_DOC_REF = cmb_serdoc.SelectedItem.ToString
        BINDCARDBE.NRO_DOC_REF = txtnumero.Text
        BINDCARDBE.ART_COD = dgvt_doc.Rows(fila).Cells("ART_COD").Value
        BINDCARDBE.DESC_ART = dgvt_doc.Rows(fila).Cells("NOM_ART").Value
        BINDCARDBE.CANTIDAD = dgvt_doc.Rows(fila).Cells("CANTIDAD").Value
        BINDCARDBE.FEC_GENE = dtpfecha.Value.ToString("dd/MM/yyyy")
        BINDCARDBE.MEDIDA = ARTICULOBL.getUniMed(BINDCARDBE.ART_COD)
        BINDCARDBE.USUARIO = gsUser

        dtVerificar = BINDCARDBL.VerificarRegistro(BINDCARDBE)
        estado = dtVerificar.Rows(0).Item(0)
        If estado > 0 Then
            MsgBox("Articulo Ya tiene Generado un BINDCARD")
            Exit Sub
        End If

        Dim dtGuia As New DataTable
        dtGuia = BINDCARDBL.VerificarGuia(BINDCARDBE)
        If dtGuia.Rows.Count = 0 Then
            MsgBox("Solicitud Pendiente de Atencion")
            Exit Sub
        Else
            BINDCARDBE.TIPOGUIA = dtGuia.Rows(0).ItemArray(0)
            BINDCARDBE.SERIEGUIA = dtGuia.Rows(0).ItemArray(1)
            BINDCARDBE.NUMGUIA = dtGuia.Rows(0).ItemArray(2)
        End If


        gsError = BINDCARDBL.SaveRow(BINDCARDBE, flagAccion)

        If gsError = "OK" Then
            MsgBox("Registro Grabado Correctamente")
            ReDim gsRptArgs(2)
            gsRptArgs(0) = BINDCARDBE.SER_DOC_REF
            gsRptArgs(1) = BINDCARDBE.NRO_DOC_REF
            gsRptArgs(2) = BINDCARDBE.ART_COD
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BINCARD.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs)
        ReDim gsRptArgs(2)
        gsRptArgs(0) = txtsol.Text
        gsRptArgs(1) = dtpfecha.Value.ToString("MM")
        gsRptArgs(2) = dtpfecha.Value.ToString("yyyy")
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SOLMAT_X_USUARIO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
        Dispose()
    End Sub

    Private Sub txtsol_TextChanged(sender As Object, e As EventArgs) Handles txtsol.TextChanged
        If (Len(txtsol.Text) = 8) Then
            Dim dtCentro As New DataTable
            dtCentro = BINDCARDBL.BuscarCentroCosto(txtsol.Text)
            If dtCentro.Rows.Count > 0 Then
                'txtc_costo.Text = dtCentro.Rows(0).ItemArray(0)
                'cmbc_costo.SelectedValue = dtCentro.Rows(0).ItemArray(0)
                cco = dtCentro.Rows(0).ItemArray(0)
            End If
        End If
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim frm As New FormDocuRef
        gsCode = "5"
        frm.ShowDialog()

    End Sub
End Class


