Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBSTIEMRH
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private ELTBSTIEMBL As New ELTBSTIEMBL
    Private ELTBDETSTIEMBL As New ELTBDETSTIEMBL
    Private gpCaption As String
    Private bprimero As Boolean
    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        'Manda los parameteros a los campos correspondientes del catalogo
        Dim ELTBSTIEMBE As New ELTBSTIEMBE
        ELTBSTIEMBE.T_DOC_REF = RTrim(txtt_doc.Text)
        ELTBSTIEMBE.SER_DOC_REF = cmbserie.Text
        ELTBSTIEMBE.NRO_DOC_REF = txtnumero.Text
        ELTBSTIEMBE.OBSERVACIONRH = txtobsrh.Text
        ELTBSTIEMBE.USUARIO_VB_RH = gsCodUsr
        Dim ELTBDETSTIEMBE As New ELTBDETSTIEMBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELMVLOGSBE.log_codusu = gsCodUsr
        gsError = ELTBSTIEMBL.SaveRow(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, "MRH", dgvtiemper)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError + " " + gsError2
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
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
            txtobsrh.Text = IIf(IsDBNull(Registro("OBSERVACIONRH")), "", Registro("OBSERVACIONRH"))
            cmbdni.SelectedValue = txtdni.Text
            If IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "H" Then
                cmbestado.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "A" Then
                cmbestado.SelectedIndex = 1
            End If
            dtpfec_gene.Value = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            Dim dt As DataTable
            dt = ELTBDETSTIEMBL.gArea(cmbc_costo.SelectedValue)
            GetCmb("cod", "nom", dt, cmb_linea)
            txt_linea.Text = IIf(IsDBNull(Registro("LINEA")), "", Registro("LINEA"))
            cmb_linea.SelectedValue = txt_linea.Text
        Next
    End Sub
    Private Sub FormELTBSTIEMRH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        'Dim nro As String
        bprimero = True
        Me.Text = "Autorizacion de Sobre Tiempos"
        dt = GUIAALMACENBL.SelectPer
        GetCmb("cod", "nombre", dt, cmbdni)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
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
        Select Case gnOpcion

            Case 1
                flagAccion = "M"
                txtt_doc.Text = "STIEM"
                cmbt_doc.SelectedIndex = 0
                GetData(gsCode)
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
                                        IIf(IsDBNull(row("FEC_TERMINO")), "", row("FEC_TERMINO")))
                Next
                'Borra la caracteristica de la base de datos
                dgvtiemper.Refresh()
        End Select
        dgvtiemper.Columns("USUARIO_RP").Visible = False
        dgvtiemper.Columns("FEC_INICIO").Visible = False
        dgvtiemper.Columns("FEC_TERMINO").Visible = False
        dgvtiemper.Columns("Dif_Hora").Visible = False
        bprimero = False
    End Sub

    Private Sub FormELTBSTIEMRH_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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
                ReDim gsRptArgs(2)
                gsRptArgs(0) = RTrim(txtt_doc.Text)
                gsRptArgs(1) = RTrim(cmbserie.Text)
                gsRptArgs(2) = RTrim(txtnumero.Text)
                gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_RPTELTBSTIEM_SELROWRH.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
                Exit Sub
        End Select
    End Sub
End Class