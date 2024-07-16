Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormReque_Ok

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private GUIAALMACENBL As New GUIAALMACENBL  
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private DET_DOCUMENTOBL As New DET_DOCUMENTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private flagAccion As String = ""
    Private sEstado As String
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"

    Private MenuBL As New MenuBL
    'Formulario para la creacion de Requerimientos para las compras
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region

    Private Sub bloquear_todo(ByVal est As Boolean)
        txtt_doc.Enabled = est
        cmbt_doc.Enabled = est
        cmb_serdoc.Enabled = est
        txtnumero.Enabled = est
        dtpfecha.Enabled = est
        cmbestado.Enabled = est
        dtpfanul.Enabled = est
        txtt_pago.Enabled = est
        cmbt_pago.Enabled = est
        txtfor_ent.Enabled = est
        cmbfor_ent.Enabled = est
        txtmon.Enabled = est
        txtc_costo.Enabled = est
        cmbc_costo.Enabled = est
        txtdni.Enabled = est
        cmbdni.Enabled = est
        txtproveedor.Enabled = est
        cmbproveedor.Enabled = est
        txtdir.Enabled = est
        cmbdir.Enabled = est
        cmbturno.Enabled = est
        txtobservacion.Enabled = est
        btnagregar.Enabled = est
        btnmodificar.Enabled = est
        btndocu.Enabled = est
        btnborrar.Enabled = est
        Button1.Enabled = est
    End Sub

    Private Sub CleanVar()

        txtt_doc.Clear()
        cmb_serdoc.SelectedIndex = -1
        txtnumero.Clear()
        cmbestado.SelectedIndex = -1
        txtc_costo.Clear()
        cmbc_costo.SelectedIndex = -1
        dtpfanul.Checked = False
        txtnumero.Clear()
    End Sub

    Public Sub habilitar(ByVal est As Boolean)
        btnagregar.Enabled = est
        btnmodificar.Enabled = est
        btndocu.Enabled = est
        btnborrar.Enabled = est
    End Sub

    Private Function OkData() As Boolean

        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If txtt_doc.Text = "" Then
            MsgBox("Ingrese descripcion el Tipo de Documento", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If txtc_costo.Text = "" Then
            MsgBox("Ingrese el Centro de Costo", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If txtdni.Text = "" Then
            MsgBox("Elija la persona que solicita", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
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
        Try
            If flagAccion = "N" Then
                Dim nro As String
                txtnumero.Text = ""

                nro = REQUERIMIENTOBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
                Select Case cmb_serdoc.SelectedIndex
                    Case 0 'ALM
                        If nro.Length >= 6 Then
                            txtnumero.Text = "0" & nro
                        Else
                            txtnumero.Text = nro
                        End If
                    Case 1 'ASQ
                        If nro.Length = 3 Then
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
                    Case 2 'AUD
                        If nro.Length = 2 Then
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
                    Case 3 'COM
                        If nro.Length = 3 Then
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
                    Case 4 ' DES
                        If nro.Length = 3 Then
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
                    Case 5 'ENS
                        If nro.Length = 3 Then
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
                    Case 6 'GER
                        If nro.Length = 2 Then
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
                    Case 7 'ING
                        If nro.Length >= 5 Then
                            txtnumero.Text = "00" & nro
                        ElseIf nro.Length = 6 Then
                            txtnumero.Text = "0" & nro
                        ElseIf nro.Length = 7 Then
                            txtnumero.Text = nro
                        End If
                    Case 8 'PRO
                        If nro.Length = 6 Then
                            txtnumero.Text = "0" & nro
                        ElseIf nro.Length = 7 Then
                            txtnumero.Text = nro
                        End If
                    Case 9 'PRE
                        If nro.Length = 4 Then
                            txtnumero.Text = "000" & nro
                        ElseIf nro.Length = 5 Then
                            txtnumero.Text = "00" & nro
                        ElseIf nro.Length = 6 Then
                            txtnumero.Text = "0" & nro
                        ElseIf nro.Length = 7 Then
                            txtnumero.Text = nro
                        End If
                    Case 10 'REH
                        If nro.Length = 3 Then
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
                    Case 11 'TWO
                        If nro.Length = 2 Then
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
                    Case 12 'VEN
                        If nro.Length = 3 Then
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
                    Case 13 '001
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
                    Case 14 'COR
                        If nro.Length = 4 Then
                            txtnumero.Text = "000" & nro
                        ElseIf nro.Length = 5 Then
                            txtnumero.Text = "00" & nro
                        ElseIf nro.Length = 6 Then
                            txtnumero.Text = "0" & nro
                        ElseIf nro.Length = 7 Then
                            txtnumero.Text = nro
                        End If
                    Case 15 'INF
                        If nro.Length = 2 Then
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
                End Select
            End If

            Dim GUIAALMACENBE As New GUIAALMACENBE
            Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
            Dim ELMVALMABE As New ELMVALMABE
            GUIAALMACENBE.T_DOC_REF = RTrim(txtt_doc.Text)
            GUIAALMACENBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
            GUIAALMACENBE.NRO_DOC_REF = RTrim(txtnumero.Text)
            GUIAALMACENBE.ART_COD = "07010001"
            GUIAALMACENBE.FEC_GENE = RTrim(dtpfecha.Value)
            GUIAALMACENBE.T_MOVINV = RTrim(txtt_movinv.Text)
            GUIAALMACENBE.F_PAGO_ENT = RTrim(txtt_pago.Text)
            GUIAALMACENBE.FOR_ENT_COD = RTrim(txtfor_ent.Text)
            If cmbestado.SelectedIndex = 0 Then
                GUIAALMACENBE.EST = "P"
            ElseIf cmbestado.SelectedIndex = 1 Then
                GUIAALMACENBE.EST = "V"
            ElseIf cmbestado.SelectedIndex = 2 Then
                GUIAALMACENBE.EST = "A"
                'ElseIf cmbestado.SelectedIndex = 3 Then
                '    GUIAALMACENBE.EST = "T"
                'ElseIf cmbestado.SelectedIndex = 4 Then
                '    GUIAALMACENBE.EST = "S"
                'ElseIf cmbestado.SelectedIndex = 5 Then
                '    GUIAALMACENBE.EST = "V"
            ElseIf cmbestado.SelectedIndex = -1 Then
                GUIAALMACENBE.EST = ""
            End If
            If dtpfanul.Checked Then
                GUIAALMACENBE.FEC_ANU = dtpfanul.Value
            Else
                GUIAALMACENBE.FEC_ANU = Nothing
            End If
            'If cmbalmac.SelectedIndex = -1 Then
            '    GUIAALMACENBE.ALMAC = ""
            'ElseIf cmbalmac.SelectedIndex = 0 Then
            '    GUIAALMACENBE.ALMAC = "P"
            'ElseIf cmbalmac.SelectedIndex = 1 Then
            '    GUIAALMACENBE.ALMAC = "V"
            'ElseIf cmbalmac.SelectedIndex = 2 Then
            '    GUIAALMACENBE.ALMAC = "A"

            'End If
            GUIAALMACENBE.SIGNO = "+"
            GUIAALMACENBE.OBSERVA = RTrim(txtobservacion.Text)
            GUIAALMACENBE.MONEDA = RTrim(cmbmon.SelectedValue)
            GUIAALMACENBE.CCO_COD = RTrim(txtc_costo.Text)
            GUIAALMACENBE.CTCT_COD = RTrim(txtproveedor.Text)
            GUIAALMACENBE.PER_COD = RTrim(txtdni.Text)
            GUIAALMACENBE.DIR_COD = RTrim(txtdir.Text)
            GUIAALMACENBE.PROVEEDOR = "20100279348"
            GUIAALMACENBE.PER_COD = RTrim(txtdni.Text)
            GUIAALMACENBE.FEC_DIA = RTrim(DateTime.Now)
            GUIAALMACENBE.USUARIO = RTrim(gsUser)
            DET_DOCUMENTOBE.ALM_COD = gsCodAlm

            DET_DOCUMENTOBE.T_DOC_REF = txtt_doc.Text
            DET_DOCUMENTOBE.SER_DOC_REF = cmb_serdoc.Text
            DET_DOCUMENTOBE.NRO_DOC_REF = txtnumero.Text



            Dim ELMVLOGSBE As New ELMVLOGSBE
            ELMVLOGSBE.log_codusu = gsCodUsr
            If flagAccion = "N" Then
                gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "NR", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
            ElseIf flagAccion = "M" Then
                gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "MR", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
            End If



            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                cmb_serdoc.Enabled = False
                sEstAlmac = cmbalmac.SelectedValue
                Me.btnborrar.Enabled = False
                Me.btndocu.Enabled = False
                Me.btnagregar.Enabled = False
                Dim i As Integer
                For i = 0 To 44
                    dgvt_doc.Columns(i).ReadOnly = True
                Next
                flagAccion = "M"
                'Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



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
                contcant = 0
                Exit Sub
            Case "Print"
                gsRptArgs = {}
                ReDim gsRptArgs(2)
                gsRptArgs(0) = cmbt_doc.SelectedValue
                gsRptArgs(1) = cmb_serdoc.SelectedItem
                gsRptArgs(2) = txtnumero.Text
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REQ.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "anular"

                If MessageBox.Show("Desea anular el documento",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim GUIAALMACENBE As New GUIAALMACENBE
                Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                Dim ELMVALMABE As New ELMVALMABE
                GUIAALMACENBE.T_DOC_REF = txtt_doc.Text
                GUIAALMACENBE.SER_DOC_REF = cmb_serdoc.Text
                GUIAALMACENBE.NRO_DOC_REF = txtnumero.Text

                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "AR", dgvt_doc, cmb_serdoc.Text, sEstAlmac)


                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    cmb_serdoc.Enabled = False
                    sEstAlmac = cmbalmac.SelectedValue
                    Me.btnborrar.Enabled = False
                    Me.btndocu.Enabled = False
                    Me.btnagregar.Enabled = False
                    Dim i As Integer
                    For i = 0 To 44
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
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim dt As DataTable
        Dim Registro As DataRow
        Dim anulfech As Boolean
        dtUsuario = GUIAALMACENBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows

            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmbt_doc.SelectedValue = txtt_doc.Text
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            anulfech = IIf(IsDBNull(Registro("FEC_ANU")), False, True)


            Select Case Registro("EST").ToString
                Case ""
                    cmbestado.SelectedIndex = -1
                Case "P"
                    cmbestado.SelectedIndex = 0
                Case "V"
                    cmbestado.SelectedIndex = 1
                Case "A"
                    cmbestado.SelectedIndex = 2

            End Select

            'dtpfanul.Checked = IIf(IsDBNull(Registro("EST")), "", IsDBNull(Registro("EST")))
            If cmbestado.SelectedIndex = 2 Then
                dtpfanul.Checked = True
                dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            End If
            'cmbestado.Text = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))
            txtt_movinv.Text = IIf(IsDBNull(Registro("T_MOVINV")), "", Registro("T_MOVINV"))
            cmbt_movinv.SelectedValue = txtt_movinv.Text
            txtt_pago.Text = IIf(IsDBNull(Registro("F_PAGO_ENT")), "", Registro("F_PAGO_ENT"))
            cmbt_pago.SelectedValue = txtt_pago.Text
            txtfor_ent.Text = IIf(IsDBNull(Registro("FOR_ENT_COD")), "", Registro("FOR_ENT_COD"))
            cmbfor_ent.SelectedValue = txtfor_ent.Text
            txtmon.Text = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            cmbmon.SelectedValue = txtmon.Text
            txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
            cmbc_costo.SelectedValue = txtc_costo.Text
            txtdni.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            cmbdni.SelectedValue = txtdni.Text
            txtproveedor.Text = IIf(IsDBNull(Registro("CTCT_COD")), "", Registro("CTCT_COD")) 'ACA VERIFICAR
            cmbproveedor.SelectedValue = txtproveedor.Text
            If cmbproveedor.SelectedIndex <> -1 Then
                dt = GUIAALMACENBL.SelectDir(txtproveedor.Text)
                If dt.Rows.Count > 0 Then
                    GetCmb("dir_cod", "nom_dir", dt, cmbdir)

                End If
            End If
            txtdir.Text = IIf(IsDBNull(Registro("DIR_COD")), "", Registro("DIR_COD"))
            cmbdir.SelectedValue = txtdir.Text
            cmbturno.Text = IIf(IsDBNull(Registro("TURNO")), "", Registro("TURNO"))
            txtobservacion.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))

        Next
    End Sub

    Private Sub FormReque_Ok_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtt_doc.Select()
        bPrimero = True
        gsError = ""
        gpCaption = "Requerimiento"
        Me.Text = gpCaption
        'Cargar los combos
        Dim dt As DataTable = GUIAALMACENBL.SelectT_DOC1()
        GetCmb("cod", "nom", dt, cmbt_doc)
        'dt = GUIAALMACENBL.SelectF_PAGO
        'GetCmb("cod", "nom", dt, cmbt_pago)
        'dt = GUIAALMACENBL.SelectF_ENT
        'GetCmb("cod", "nom", dt, cmbfor_ent)
        'dt = GUIAALMACENBL.SelectMoneda
        'GetCmb("cod", "nom", dt, cmbmon)
        'cmbmon.SelectedIndex = 1
        txtmon.Text = "01"
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = GUIAALMACENBL.SelectPer
        GetCmb("cod", "nombre", dt, cmbdni)
        dt = GUIAALMACENBL.SelectProv
        GetCmb("cod", "nom", dt, cmbproveedor)
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero") '5
        dgvt_doc.Columns.Add("CTCT_COD", "Cliente") '6
        dgvt_doc.Columns.Add("CANTIDAD", "Cantidad") '7
        dgvt_doc.Columns.Add("ART_COD", "Cod. Art.") '8
        dgvt_doc.Columns.Add("NOM_ART", "Nom. Art.") '9
        dgvt_doc.Columns.Add("FEC_ENT", "Fec. Vcto") '10
        dgvt_doc.Columns.Add("ACT_COD", "Activos") '11
        dgvt_doc.Columns.Add("FEC_LLEG", "FEC_LLEG") '12
        dgvt_doc.Columns.Add("PART_ACT", "P. Act.") '13
        dgvt_doc.Columns.Add("ALM_COD", "Alm") '14
        dgvt_doc.Columns.Add("SIGNO", "Signo") '15
        dgvt_doc.Columns.Add("OBSERVA", "Observa") '16
        dgvt_doc.Columns.Add("T_MOVINV", "T. Mov.") '17
        dgvt_doc.Columns.Add("TPRECIO_COMPRA", "P. Compra") '18
        dgvt_doc.Columns.Add("TPRECIO_DCOMPRA", "P. Comp. D.") '19
        dgvt_doc.Columns.Add("IGV", "Igv") '20
        dgvt_doc.Columns.Add("IGV_IMPOR", "Cant. IGV") '21
        dgvt_doc.Columns.Add("T_CAMB", "Camb.") '22
        dgvt_doc.Columns.Add("UPRECIO_COMPRA", "Pre. Compra") '23
        dgvt_doc.Columns.Add("UPRECIO_DCOMPRA", "Pre. D. Compra") '24
        dgvt_doc.Columns.Add("IGV_DIMPOR", "Cant. IGV D.") '25
        dgvt_doc.Columns.Add("MONEDA", "Moneda") '26
        dgvt_doc.Columns.Add("FEC_GENE", "F. Gene") '27
        dgvt_doc.Columns.Add("USUARIO", "Usuario") '28
        dgvt_doc.Columns.Add("UNIDAD", "Und") '29
        dgvt_doc.Columns.Add("F_PAGO_ENT", "F. Pago") '30
        dgvt_doc.Columns.Add("FOR_ENT_COD", "F. Cod. Ent") '31
        dgvt_doc.Columns.Add("FEC_DIA", "F. Dia") '32
        dgvt_doc.Columns.Add("PROVEEDOR", "Prov.") '33
        dgvt_doc.Columns.Add("CCO_COD", "C. Costo") '34
        dgvt_doc.Columns.Add("CANTIDAD", "Cant.") '35
        dgvt_doc.Columns.Add("LOTE", "Lote") '36
        dgvt_doc.Columns.Add("PER_COD", "Cod. Per") '37
        dgvt_doc.Columns.Add("NRO_DOCU1", "Nro. Docu") '38
        dgvt_doc.Columns.Add("MARCA", "Marca") '39
        dgvt_doc.Columns.Add("DSCTO", "Dscto. %") '40
        dgvt_doc.Columns.Add("DSCTO_IMPOR", "Dscto. S.") '41
        dgvt_doc.Columns.Add("DSCTO_DIMPOR", "Dscto D.") '42
        dgvt_doc.Columns.Add("COD_NUEVO", "COD_NUEVO") '43
        dgvt_doc.Columns.Add("EST", "EST") '44
        dgvt_doc.Columns.Add("REQ_APROB", "cerrado") '45
        dgvt_doc.Columns.Add("PESO", "Peso") '46
        dgvt_doc.Columns.Add("art_venta", "art_venta") '47
        dgvt_doc.Columns.Add("TIPOREQ", "Tip. Req.") '48
        dgvt_doc.Columns.Add("OBSERV", "Mot. Req.") '49
        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                If gsUser = "GGONZALES" Or gsUser = "KCALLE" Then
                    bloquear_todo(False)
                Else
                    flagAccion = "N"
                    CleanVar()
                    habilitar(False)
                    bTercero = "1"
                    bCuarto = "1"
                    Me.txtt_doc.Text = "REQ"
                End If
            Case 1
                If gsUser = "GGONZALES" Or gsUser = "KCALLE" Then
                    bloquear_todo(False)
                    btnmodificar.Enabled = True
                End If
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)
                bCuarto = "1"
                cmb_serdoc.Enabled = False
                Dim dtArticulo As DataTable

                dtArticulo = GUIAALMACENBL.getListdgv(sTDoc, sSDoc, sNDoc)
                For Each row As DataRow In dtArticulo.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")), '0
                                          IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")), '1
                                          IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")), '2
                                          IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")), '3
                                          IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")), '4
                                          IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")), '5
                                          IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")), '6
                                          IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),'7
                                          IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'8
                                          IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),'9
                                          IIf(IsDBNull(row("FEC_ENT")), "", row("FEC_ENT")),'10
                                          IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")),'11
                                          IIf(IsDBNull(row("FEC_LLEG")), "", row("FEC_LLEG")),
                                          IIf(IsDBNull(row("PART_ACT")), "", row("PART_ACT")),
                                          IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),
                                          IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),
                                          IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),
                                          IIf(IsDBNull(row("T_MOVINV")), "", row("T_MOVINV")),
                                          IIf(IsDBNull(row("TPRECIO_COMPRA")), "", row("TPRECIO_COMPRA")),
                                          IIf(IsDBNull(row("TPRECIO_DCOMPRA")), "", row("TPRECIO_DCOMPRA")),
                                          IIf(IsDBNull(row("IGV")), "", row("IGV")),
                                          IIf(IsDBNull(row("IGV_IMPOR")), "", row("IGV_IMPOR")),
                                          IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),
                                          IIf(IsDBNull(row("UPRECIO_COMPRA")), "", row("UPRECIO_COMPRA")),
                                          IIf(IsDBNull(row("UPRECIO_DCOMPRA")), "", row("UPRECIO_DCOMPRA")),
                                          IIf(IsDBNull(row("IGV_DIMPOR")), "", row("IGV_DIMPOR")),
                                          IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),
                                          IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),
                                          IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),
                                          IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),
                                          IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")),
                                          IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),
                                          IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")),
                                          IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),
                                          IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),
                                          IIf(IsDBNull(row("CANTIDAD1")), "", row("CANTIDAD1")),
                                          IIf(IsDBNull(row("LOTE")), "", row("LOTE")),
                                          IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),
                                          IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")),
                                          IIf(IsDBNull(row("MARCA")), "", row("MARCA")),
                                          IIf(IsDBNull(row("DSCTO")), "", row("DSCTO")),
                                          IIf(IsDBNull(row("DSCTO_IMPOR")), "", row("DSCTO_IMPOR")),
                                          IIf(IsDBNull(row("DSCTO_DIMPOR")), "", row("DSCTO_DIMPOR")),
                                          IIf(IsDBNull(row("COD_NUEVO")), "", row("COD_NUEVO")),
                                          IIf(IsDBNull(row("EST")), "", row("EST")),
                                          IIf(IsDBNull(row("REQ_APROB")), "", row("REQ_APROB")),
                                          IIf(IsDBNull(row("PESO")), "", row("PESO")),
                                          IIf(IsDBNull(row("art_venta")), "", row("art_venta")),
                                          IIf(IsDBNull(row("LICENCIA")), "", row("LICENCIA")),
IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")))
                Next
                Dim i As Integer
                For i = 0 To 45
                    dgvt_doc.Columns(i).ReadOnly = True
                Next
                Try
                    dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(3)
                Catch ex As Exception
                    MsgBox("No hay datos en el detalle")
                End Try
                sEstAlmac = cmbalmac.SelectedValue
                Me.btnborrar.Enabled = False
                Me.btndocu.Enabled = False
                Me.btnagregar.Enabled = False


        End Select
        dgvt_doc.Columns(0).Visible = False
        dgvt_doc.Columns(1).Visible = False
        dgvt_doc.Columns(2).Visible = False
        dgvt_doc.Columns(6).Visible = False
        'dgvt_doc.Columns(7).Visible = False
        dgvt_doc.Columns(12).Visible = False
        dgvt_doc.Columns(13).Visible = False
        'dgvt_doc.Columns(14).Visible = False
        dgvt_doc.Columns(15).Visible = False
        dgvt_doc.Columns(16).Visible = False
        dgvt_doc.Columns(17).Visible = False
        dgvt_doc.Columns(18).Visible = False
        dgvt_doc.Columns(19).Visible = False
        dgvt_doc.Columns(20).Visible = False
        dgvt_doc.Columns(21).Visible = False
        dgvt_doc.Columns(22).Visible = False
        dgvt_doc.Columns(23).Visible = False
        dgvt_doc.Columns(24).Visible = False
        dgvt_doc.Columns(25).Visible = False
        dgvt_doc.Columns(26).Visible = False
        dgvt_doc.Columns(27).Visible = False
        dgvt_doc.Columns(28).Visible = False
        dgvt_doc.Columns(29).Visible = False
        dgvt_doc.Columns(30).Visible = False
        dgvt_doc.Columns(31).Visible = False
        dgvt_doc.Columns(32).Visible = False
        dgvt_doc.Columns(33).Visible = False
        'dgvt_doc.Columns(34).Visible = False
        dgvt_doc.Columns(35).Visible = False
        dgvt_doc.Columns(36).Visible = False
        dgvt_doc.Columns(37).Visible = False
        dgvt_doc.Columns(38).Visible = False
        dgvt_doc.Columns(38).Visible = False
        dgvt_doc.Columns(39).Visible = False
        dgvt_doc.Columns(40).Visible = False
        dgvt_doc.Columns(41).Visible = False
        dgvt_doc.Columns(42).Visible = False
        dgvt_doc.Columns(43).Visible = False
        dgvt_doc.Columns(44).Visible = False
        dgvt_doc.Columns(45).Visible = False
        'dgvt_doc.Columns(46).Visible = False
        'dgvt_doc.Columns(46).Visible = False
        bPrimero = False

    End Sub

#Region "Texto"
    Private Sub txtproveedor_TextChanged(sender As Object, e As EventArgs) Handles txtproveedor.TextChanged
        If bCuarto = "1" Then
            Dim dt As DataTable
            If cmbproveedor.SelectedIndex <> -1 Then
                dt = GUIAALMACENBL.SelectDir(txtproveedor.Text)
                If dt.Rows.Count > 0 Then
                    GetCmb("dir_cod", "nom_dir", dt, cmbdir)

                End If
            End If
            If flagAccion = "N" Then
                habilitar(True)
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtt_doc_LostFocus(sender As Object, e As EventArgs) Handles txtt_doc.LostFocus
        If txtt_doc.Text = "" Then
            cmbt_doc.SelectedValue = ""
            Exit Sub
        End If
        cmbt_doc.SelectedValue = txtt_doc.Text
        If cmbt_doc.SelectedValue Is Nothing Then
            MsgBox("Tipo de documento no existe", MsgBoxStyle.Exclamation)
            txtt_doc.Text = ""
        Else
            If flagAccion = "N" Then
                cmb_serdoc.SelectedIndex = 13
                cmbestado.SelectedIndex = 0
                'cmbt_movinv.SelectedIndex = 2
                'txtnumero.Text = ARTICULOBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
            End If

        End If
    End Sub

    Private Sub txtdir_LostFocus(sender As Object, e As EventArgs) Handles txtdir.LostFocus
        If txtdir.Text = "" Then
            cmbdir.SelectedValue = ""
            Exit Sub
        End If
        cmbdir.SelectedValue = txtdir.Text
        If cmbdir.SelectedValue Is Nothing Then
            MsgBox("Direccion del cliente no existe", MsgBoxStyle.Exclamation)
            txtdir.Text = ""
        End If
    End Sub

    Private Sub txtt_movinv_LostFocus(sender As Object, e As EventArgs) Handles txtt_movinv.LostFocus
        If txtt_movinv.Text = "" Then
            cmbt_movinv.SelectedValue = ""
            Exit Sub
        End If
        cmbt_movinv.SelectedValue = txtt_movinv.Text
        If cmbt_movinv.SelectedValue Is Nothing Then
            MsgBox("Tipo de Movimiento no existe", MsgBoxStyle.Exclamation)
            txtt_movinv.Text = ""
            txtt_movinv.Select()
        End If
    End Sub

    Private Sub txtt_pago_LostFocus(sender As Object, e As EventArgs) Handles txtt_pago.LostFocus
        If txtt_pago.Text = "" Then
            cmbt_pago.SelectedValue = ""
            Exit Sub
        End If
        cmbt_pago.SelectedValue = txtt_pago.Text
        If cmbt_pago.SelectedValue Is Nothing Then
            MsgBox("Tipo de pago no existe", MsgBoxStyle.Exclamation)
            txtt_pago.Text = ""
        End If
    End Sub

    Private Sub txtfor_ent_LostFocus(sender As Object, e As EventArgs) Handles txtfor_ent.LostFocus
        If txtfor_ent.Text = "" Then
            cmbfor_ent.SelectedValue = ""
            Exit Sub
        End If
        cmbfor_ent.SelectedValue = txtfor_ent.Text
        If cmbfor_ent.SelectedValue Is Nothing Then
            MsgBox("Tipo de entrega no existe", MsgBoxStyle.Exclamation)
            txtfor_ent.Text = ""
        End If
    End Sub

    Private Sub txtmon_LostFocus(sender As Object, e As EventArgs) Handles txtmon.LostFocus
        If txtmon.Text = "" Then
            cmbmon.SelectedValue = ""
            Exit Sub
        End If
        cmbmon.SelectedValue = txtmon.Text
        If cmbmon.SelectedValue Is Nothing Then
            MsgBox("Tipo de Moneda no existe", MsgBoxStyle.Exclamation)
            txtmon.Text = ""
            'No permite que pase el select
            txtmon.Select()
        Else
            If flagAccion = "N" Then
                habilitar(True)
            End If
        End If
    End Sub

    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo.SelectedValue = txtc_costo.Text
        If cmbc_costo.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo.Text = ""
            txtc_costo.Select()
        End If
    End Sub

    Private Sub txtdni_LostFocus(sender As Object, e As EventArgs) Handles txtdni.LostFocus
        If txtdni.Text = "" Then
            cmbdni.SelectedValue = ""
            Exit Sub
        End If
        cmbdni.SelectedValue = txtdni.Text
        If cmbdni.SelectedValue Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtdni.Text = ""

        End If
    End Sub

    Private Sub txtproveedor_LostFocus(sender As Object, e As EventArgs) Handles txtproveedor.LostFocus
        If txtproveedor.Text = "" Then
            cmbproveedor.SelectedValue = ""
            Exit Sub
        End If
        cmbproveedor.SelectedValue = txtproveedor.Text
        If cmbproveedor.SelectedValue Is Nothing Then
            MsgBox("Proveedor no existe", MsgBoxStyle.Exclamation)
            txtproveedor.Text = ""
        Else

            habilitar(True)
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'if dgvt_doc.CurrentCell.
        Dim frm As New FormMantDetReq_ok
        gContador = 1
        'frm.flag = flagAccion
        frm.bFecha = dtpfecha.Value
        frm.ShowDialog()
    End Sub
#End Region

#Region "Valor Cmb"
    Private Sub cmbt_doc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_doc.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbt_doc.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtt_doc.Text = cmbt_doc.SelectedValue
    End Sub

    Private Sub cmbt_movinv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_movinv.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbt_movinv.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtt_movinv.Text = cmbt_movinv.SelectedValue
        If Mid(txtt_movinv.Text, 1, 1) = "E" Then
            cmbalmac.SelectedIndex = 0
        ElseIf Mid(txtt_movinv.Text, 1, 1) = "S" Then
            cmbalmac.SelectedIndex = 1
        End If
    End Sub

    Private Sub cmbt_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_pago.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbt_pago.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtt_pago.Text = cmbt_pago.SelectedValue
    End Sub

    Private Sub cmbfor_ent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfor_ent.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbfor_ent.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtfor_ent.Text = cmbfor_ent.SelectedValue
    End Sub

    Private Sub cmbmon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmon.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbmon.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtmon.Text = cmbmon.SelectedValue
    End Sub

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
    End Sub

    Private Sub cmbdni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdni.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbdni.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtdni.Text = cmbdni.SelectedValue
    End Sub

    Private Sub cmbproveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproveedor.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbproveedor.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtproveedor.Text = cmbproveedor.SelectedValue
        If flagAccion = "N" Then
            habilitar(True)
        End If

    End Sub

    Private Sub cmbdir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdir.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbdir.SelectedValue Is Nothing Then
            Exit Sub
        End If
        If cmbdir.SelectedIndex > 0 Then
            txtdir.Text = cmbdir.SelectedValue
        End If

    End Sub

    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        If bTercero = "0" Then
            Exit Sub
        End If
        Dim nro As String
        txtnumero.Enabled = False
        If (txtt_doc.TextLength > 0 And cmb_serdoc.SelectedIndex <> -1 And bTercero = "1") Then
            nro = REQUERIMIENTOBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
            Select Case cmb_serdoc.SelectedIndex
                Case 0 'ALM
                    If nro.Length >= 6 Then
                        txtnumero.Text = "0" & nro
                    Else
                        txtnumero.Text = nro
                    End If
                Case 1 'ASQ
                    If nro.Length = 3 Then
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
                Case 2 'AUD
                    If nro.Length = 2 Then
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
                Case 3 'COM
                    If nro.Length = 3 Then
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
                Case 4 ' DES
                    If nro.Length = 3 Then
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
                Case 5 'ENS
                    If nro.Length = 3 Then
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
                Case 6 'GER
                    If nro.Length = 2 Then
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
                Case 7 'ING
                    If nro.Length >= 5 Then
                        txtnumero.Text = "00" & nro
                    ElseIf nro.Length = 6 Then
                        txtnumero.Text = "0" & nro
                    ElseIf nro.Length = 7 Then
                        txtnumero.Text = nro
                    End If
                Case 8 'PRO
                    If nro.Length = 6 Then
                        txtnumero.Text = "0" & nro
                    ElseIf nro.Length = 7 Then
                        txtnumero.Text = nro
                    End If
                Case 9 'PRE
                    If nro.Length = 4 Then
                        txtnumero.Text = "000" & nro
                    ElseIf nro.Length = 5 Then
                        txtnumero.Text = "00" & nro
                    ElseIf nro.Length = 6 Then
                        txtnumero.Text = "0" & nro
                    ElseIf nro.Length = 7 Then
                        txtnumero.Text = nro
                    End If
                Case 10 'REH
                    If nro.Length = 3 Then
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
                Case 11 'TWO
                    If nro.Length = 2 Then
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
                Case 12 'VEN
                    If nro.Length = 3 Then
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
                Case 13 '001
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
                Case 14 'COR
                    If nro.Length = 4 Then
                        txtnumero.Text = "000" & nro
                    ElseIf nro.Length = 5 Then
                        txtnumero.Text = "00" & nro
                    ElseIf nro.Length = 6 Then
                        txtnumero.Text = "0" & nro
                    ElseIf nro.Length = 7 Then
                        txtnumero.Text = nro
                    End If
                Case 15 'INF
                    If nro.Length = 2 Then
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
            End Select


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "7"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()

    End Sub

    Private Sub cmbalmac_LostFocus(sender As Object, e As EventArgs) Handles cmbalmac.LostFocus
        If cmbalmac.SelectedIndex = -1 Then
            MsgBox("Seleccione un tipo de movimiento")
            cmbalmac.Select()
        End If
    End Sub


    Private Sub cmbestado_LostFocus(sender As Object, e As EventArgs) Handles cmbestado.LostFocus
        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Seleccione un Estado")
            cmbestado.Select()
        End If
        If cmbestado.SelectedIndex = 1 Then
            dtpfanul.Checked = True
        Else
            dtpfanul.Checked = False
        End If
    End Sub

    Private Sub cmbdni_LostFocus(sender As Object, e As EventArgs) Handles cmbdni.LostFocus
        If cmbdni.SelectedIndex = -1 Then
            MsgBox("Seleccione un dni de Personal")
            cmbdni.Select()
        End If
    End Sub

#End Region

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If dgvt_doc.Rows.Count > 0 Then
            If dgvt_doc.SelectedRows.Count > 0 Then
                Dim frm As New FormMantDetReq_ok
                If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(45).Value = "4" Then
                    'sEstado = "4"
                    MsgBox("Ya se realizo Orden a este articulo")
                    Exit Sub
                End If
                'MsgBox(Mid(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(43).Value, 1, 2))
                gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(8).Value
                'frm.cmblinea.SelectedValue = gsCode3
                'frm.cmbart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(8).Value
                'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
                sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(7).Value
                frm.txtlote.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(36).Value
                frm.txtcodart.Text = gsCode3
                frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value
                If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(11).Value = Nothing Then
                    frm.txtactivo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(47).Value
                Else
                    frm.txtactivo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(11).Value
                    frm.cmbactivo.SelectedValue = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(11).Value
                End If
                frm.npdpeso.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PESO").Value
                frm.bFecha = dtpfecha.Text

                If Not dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(48).Value = Nothing Then
                    frm.cmb_tipoReq.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(48).Value
                End If
                If gsUser = "GGONZALES" Then

                    'frm.btnagregar.Enabled = False
                    frm.cmblinea.Enabled = False
                    frm.cmbsublinea.Enabled = False
                    frm.cmbart.Enabled = False
                    frm.txtcodart.Enabled = False
                    frm.npdcantidad.Enabled = False
                    frm.txtlote.Enabled = False
                    frm.npdpeso.Enabled = False


                End If
                frm.flag = flagAccion
                gContador = 0
                frm.ShowDialog()
            Else
                MsgBox("No ah seleccionado ningun articulo item para modificar")
            End If

        Else
            MsgBox("No hay items en la lista para modificar")
        End If

    End Sub

    Private Sub FormReque_Ok_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnpeso_Click(sender As Object, e As EventArgs) Handles btnpeso.Click
        If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PESO").Value) <> 0 Then
            MsgBox("Este articulo ya cuenta con peso")
            Exit Sub
        End If
        If dgvt_doc.Rows.Count > 0 Then
            If dgvt_doc.SelectedRows.Count > 0 Then
                Dim frm As New FormPesoReq_ok
                frm.npdpeso.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PESO").Value)
                frm.ShowDialog()
            Else
                MsgBox("No ah seleccionado ningun articulo item para modificar")
            End If

        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub
End Class