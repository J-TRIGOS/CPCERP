Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net

Public Class FormELTBSTURN
    Private ELTBSTURNBL As New ELTBSTURNBL
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ELTBDETSTIEMBL As New ELTBDETSTIEMBL

    Private bprimero As Boolean
    Dim gsMes As New Integer
    Private gpCaption As String
    Private p As Integer = 0
    Private gsAccion As String
    Dim flagAccion As String

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub FormELTBSTURN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        bprimero = True

        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        dgvtiemper.Columns.Add("Codigo", "Codigo")
        dgvtiemper.Columns.Add("Nombre", "Apellidos y Nombre")
        cmbt_doc.SelectedIndex = 0

        Select Case gnOpcion
            Case 0
                cmbt_doc.SelectedIndex = 0
                cmbserie.Text = DateTime.Now.ToString("yyyy")
                gsMes = DateTime.Now.ToString("MM")
                txtnumero.Text = ELTBSTURNBL.SelectSer(cmbserie.SelectedItem, gsMes)
                cmbestado.SelectedIndex = 0
                cmbTurn.SelectedIndex = 0

                flagAccion = "N"
                bprimero = False
            Case 1
                flagAccion = "M"
                GetData(sSDoc, sNDoc)
                bprimero = False



        End Select
    End Sub
    Private Sub GetData(ByVal sSDoc As String, ByVal sNDoc As String)
        Dim dtUsuario As DataTable
        Dim dtUsuarios As DataTable
        Dim Registro As DataRow

        Dim sEst As String
        Dim sTipo As Integer

        dtUsuario = ELTBSTURNBL.SelectRow(sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows
            cmbserie.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfec_inicio.Text = IIf(IsDBNull(Registro("FEC_INI")), "", Registro("FEC_INI"))
            dtpfec_termino.Text = IIf(IsDBNull(Registro("FEC_FIN")), "", Registro("FEC_FIN"))
            txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
            txt_titulo.Text = IIf(IsDBNull(Registro("TITULO")), "", Registro("TITULO"))
            txt_observa.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            sTipo = IIf(IsDBNull(Registro("TIPO")), "", Registro("TIPO"))
            sEst = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))
            If sEst = "H" Then
                cmbestado.SelectedIndex = 0
            Else
                cmbestado.SelectedIndex = 1
                flagAccion = "A"
            End If
            If sTipo = 0 Then
                cmbTurn.SelectedIndex = 0
            Else
                cmbTurn.SelectedIndex = 1
            End If
        Next

        dtUsuario = ELTBSTURNBL.SearhDetTurn(sNDoc)
        dgvtiemper.Rows.Clear()
        dgvtiemper.Refresh()
        For Each row As DataRow In dtUsuario.Rows
            dgvtiemper.Rows.Add(
                             IIf(IsDBNull(row("Codigo")), "", row("Codigo")),
                             IIf(IsDBNull(row("Nombre")), "", row("Nombre")))
        Next

    End Sub

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "2"
        If txtc_costo.TextLength <> 0 Then
            gsCode10 = txtc_costo.Text
            Dim frm As New FormPerTurnoHora
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

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()
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
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTELTBSTURN_SELROW.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                    Exit Sub
                Case "anular"
                    Exit Sub

                    If MessageBox.Show("Desea anular el documento",
                       gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If

                    Dim ELTBSTURNBE As New ELTBSTURNBE
                    'Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE

                    ELTBSTURNBE.T_DOC_REF = cmbt_doc.Text
                    ELTBSTURNBE.SER_DOC_REF = cmbserie.Text
                    ELTBSTURNBE.NRO_DOC_REF = txtnumero.Text


                    'Dim ELMVLOGSBE As New ELMVLOGSBE
                    'ELMVLOGSBE.log_codusu = gsCodUsr
                    'gsError = BOLETABL.SaveRow(BOLETABE, DET_DOCUMENTOBE, ELMVLOGSBE, "AR", dgvt_doc)
                    gsError = ELTBSTURNBL.SaveRow(ELTBSTURNBE, "A", dgvtiemper)

                    If gsError = "OK" Then
                        MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                        'cmb_serdoc.Enabled = False
                        ''sEstAlmac = cmbalmac.SelectedValue
                        'Me.btnborrar.Enabled = False
                        'Me.btndocu.Enabled = False
                        'Me.btnagregar.Enabled = False
                        'Dim i As Integer
                        'For i = 0 To 45
                        '    dgvt_doc.Columns(i).ReadOnly = True
                        'Next
                        ''Dispose()
                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If



                    Exit Sub
            End Select
        Catch ex As Exception

        End Try

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
        Dim ELTBSTURNBE As New ELTBSTURNBE
        If flagAccion = "N" Then
            txtnumero.Text = ELTBSTURNBL.SelectSer(cmbserie.SelectedItem, gsMes)
        End If
        ELTBSTURNBE.T_DOC_REF = RTrim(txtt_doc.Text)
        ELTBSTURNBE.SER_DOC_REF = cmbserie.Text
        ELTBSTURNBE.NRO_DOC_REF = txtnumero.Text
        ELTBSTURNBE.F_INI = dtpfec_inicio.Text
        ELTBSTURNBE.F_FIN = dtpfec_termino.Text
        ELTBSTURNBE.TIPO = cmbTurn.SelectedIndex
        ELTBSTURNBE.CCO_COD = txtc_costo.Text
        ELTBSTURNBE.F_GENE = RTrim(dtpfec_gene.Value)
        ELTBSTURNBE.USUARIO_RP = gsCodUsr
        ELTBSTURNBE.TITULO = txt_titulo.Text
        ELTBSTURNBE.OBSERVA = txt_observa.Text

        If flagAccion = "A" Then
            MsgBox("El Programa esta Anulado", MsgBoxStyle.Information)
            Exit Sub
        End If

        If cmbestado.SelectedIndex = 0 Then
            ELTBSTURNBE.EST = "H"
        Else
            ELTBSTURNBE.EST = "A"
            flagAccion = "A"
        End If

        ELTBSTURNBE.SEM_ANHO = ELTBSTURNBL.SelectNroSem(dtpfec_inicio.Text)
        gsError = ELTBSTURNBL.SaveRow(ELTBSTURNBE, flagAccion, dgvtiemper)

        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            If flagAccion = "A" Then
                flagAccion = "A"
            Else
                flagAccion = "M"
            End If
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub
    Private Function OkData() As Boolean
        Dim Comp As String
        Dim veri As String
        Dim dt As DataTable

        Dim DAcumula1 As String = "Se encuentran en otro turno"
        If cmbc_costo.SelectedIndex = -1 Then
            MsgBox("Seleccione Centro Consto", MsgBoxStyle.Exclamation)
            cmbc_costo.Focus()
            Return False
        End If
        If dgvtiemper.Rows.Count = 0 Then
            MsgBox("Se debe tener registros en el formulario")
            Return False
        End If
        If cmbTurn.SelectedIndex = -1 Then
            MsgBox("Seleccione Turno", MsgBoxStyle.Exclamation)
            cmbTurn.Focus()
            Return False
        End If
        If dtpfec_inicio.Value >= dtpfec_termino.Value Then
            MsgBox("Fecha Termino mayor a la Fecha Inicio", MsgBoxStyle.Exclamation)
            Return False
        End If



        dt = ELTBSTURNBL.SelectRow(txtnumero.Text, dtpfec_inicio.Text, cmbTurn.SelectedIndex, txtc_costo.Text)
        For Each row As DataRow In dt.Rows
            Comp = IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF"))
            If Comp <> Nothing Then
                For i = 0 To dgvtiemper.Rows.Count - 1
                    veri = ELTBSTURNBL.SelectVeri(dgvtiemper.Rows(i).Cells("Codigo").Value, Comp, cmbserie.Text)
                    If veri <> Nothing Then
                        DAcumula1 = DAcumula1 + ", " + veri
                    End If
                    veri = Nothing
                Next
            End If
        Next
        'If flagAccion = "N" Then
        If DAcumula1 <> "Se encuentran en otro turno" Then
                MsgBox(DAcumula1, MsgBoxStyle.Exclamation)
                Return False
            End If
        'End If
        Return True

    End Function

    Private Sub FormELTBSTURN_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormDocuRefTurn.Show()
    End Sub

    Private Sub txtc_costo_TextChanged(sender As Object, e As EventArgs) Handles txtc_costo.TextChanged
        cmbc_costo.SelectedValue = txtc_costo.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dgvtiemper.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar los Registros",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            'dgvtiemper.Rows.RemoveAt(dgvtiemper.CurrentRow.Index)
            dgvtiemper.Rows.Clear()
            dgvtiemper.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub
End Class