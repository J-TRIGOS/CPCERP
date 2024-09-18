Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.Net.Mail

Public Class FormMantFacturacion
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private PROVISIONESBL As New PROVISIONESBL
    Private FACTURACIONBL As New FACTURACIONBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private COSTOS_EXPBL As New COSTOS_EXPBL
    Private PERBL As New PERBL
    Private ARTICULOBL As New ARTICULOBL
    Private CTCTBL As New CTCTBL
    Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    Private catalogo As String = ""
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Private sArticulo As String
    Private sArt_Cod As String = "0"
    Private MenuBL As New MenuBL
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        Try
            cmb.DataSource = dtSelect
            cmb.DisplayMember = sDescri
            cmb.ValueMember = sCodigo
            cmb.SelectedIndex = -1

        Catch ex As Exception

        End Try
    End Function
    Private Function GetCmb2(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region

    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
            Dim sFunc = e.ClickedItem.Tag.ToString()

            If Mid(sFunc, 5, 4) = "func" Then
                'obtener el objeto a procesar desde el tag del boton
                sFunc = Mid(sFunc, 10)
            End If
            Dim mesaño As String
            Dim m As String
            Select Case sFunc

                Case "save"
                    If sMes <= "12" And dtpfecha.Value.Year <= "2020" Then
                        MsgBox("Mes Cerrado")
                        Exit Sub
                    End If

                    SaveData()

                    Exit Sub
                Case "exit"
                    Dispose()
                    Exit Sub
                Case "Print"
                    If txtt_movinv.Text <> "S06" Then
                        ReDim gsRptArgs(2)
                        gsRptArgs(0) = RTrim(txtt_doc.Text)
                        gsRptArgs(1) = RTrim(cmb_serdoc.Text)
                        gsRptArgs(2) = RTrim(txtnumero.Text)
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_IMPRESION_FC.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                        Exit Sub
                    Else
                        ReDim gsRptArgs(2)
                        gsRptArgs(0) = RTrim(txtt_doc.Text)
                        gsRptArgs(1) = RTrim(cmb_serdoc.Text)
                        gsRptArgs(2) = RTrim(txtnumero.Text)
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_IMPRESION_FC_EXPORT.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                        Exit Sub
                    End If
                Case "exportar"
                    Dim frm As New FormFactElect
                    frm.fac = "01"
                    frm.mov = txtt_movinv.Text
                    frm.tipo = txtt_pago.Text
                    If cmbestado.SelectedIndex = 0 Then
                        frm.estfac = "H"
                    ElseIf cmbestado.SelectedIndex = 1 Then
                        frm.estfac = "A"
                    End If
                    Dim mes As String = dtpfanul.Value.Month.ToString
                    If mes.Length = 1 Then
                        mes = 0 & mes
                    End If
                    Dim dia As String = dtpfanul.Value.Day.ToString
                    If dia.Length = 1 Then
                        dia = 0 & dia
                    End If
                    frm.fecfact = dtpfanul.Value.Year.ToString & mes & dia
                    'MsgBox(dtpfecha.Value.Year.ToString & dtpfecha.Value.Month.ToString & dtpfecha.Value.Day.ToString)
                    frm.ShowDialog()
                Case "anular"

                    If MessageBox.Show("Desea anular el documento",
                       gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If

                    Dim FACTURACIONBE As New FACTURACIONBE
                    Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    FACTURACIONBE.T_DOC_REF = txtt_doc.Text
                    FACTURACIONBE.SER_DOC_REF = cmb_serdoc.Text
                    FACTURACIONBE.NRO_DOC_REF = txtnumero.Text

                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    mesaño = Replace(Mid(dtpfecha.Value, 4, 7), "/", "")
                    m = Mid(dtpfecha.Value, 4, 2)
                    gsError = FACTURACIONBL.SaveRow(FACTURACIONBE, DET_DOCUMENTOBE, ELMVLOGSBE, "AR", dgvt_doc)
                    If gsError = "OK" Then
                        MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                        ' gsError2 = FACTURACIONBL.AsientoFC("Asiento", mesaño, m, RTrim(txtnumero.Text), cmb_serdoc.Text, txtt_doc.Text, FACTURACIONBE.EST, dgvt_doc)
                        '  If gsError2 = "OK" Then
                        '  MsgBox("Asiento Creado", MsgBoxStyle.Information)
                        '  cmb_serdoc.Enabled = False
                        ' 'sEstAlmac = cmbalmac.SelectedValue
                        ' Me.btnborrar.Enabled = False
                        ' Me.btndocu.Enabled = False
                        ' Me.btnagregar.Enabled = False
                        ' Dim i As Integer
                        ' For i = 0 To 45
                        ' dgvt_doc.Columns(i).ReadOnly = True
                        ' Next
                        ' 'Dispose()
                        'Else
                        '   FormMain.LblError.Text = gsError2
                        '  MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
                        'End If

                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If



                    Exit Sub
            End Select
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CleanVar()

        txtt_doc.Clear()
        cmb_serdoc.SelectedIndex = -1
        txtnumero.Clear()
        cmbestado.SelectedIndex = -1
        'txtc_costo.Clear()
        'cmbc_costo.SelectedIndex = -1
        dtpfanul.Checked = False
        txtnumero.Clear()

    End Sub

    Public Sub habilitar(ByVal est As Boolean)
        btnagregar.Enabled = est
        btnmodificar.Enabled = est
        btndocu.Enabled = est
        'btnborrar.Enabled = est
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
        If txtctct_cod.Text = "" Then
            MsgBox("Ingrese el Cliente de Referencia", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If txtdir.Text = "" Then
            MsgBox("Ingrese la direccion de Referencia", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub SaveData()

        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("La factura no tiene items")
            Exit Sub
        End If
        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim nro As String
        Dim mesaño As String
        Dim m As String
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim FACTURACIONBE As New FACTURACIONBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        If flagAccion = "N" Then
            nro = FACTURACIONBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)
            Select Case cmb_serdoc.SelectedIndex
                Case 0 '001
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
                    'txtnumero.Enabled = True
            End Select
        End If

        FACTURACIONBE.T_DOC_REF = RTrim(txtt_doc.Text)
        FACTURACIONBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
        FACTURACIONBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        FACTURACIONBE.ART_COD = "07010003"
        FACTURACIONBE.FEC_GENE = RTrim(dtpfecha.Value)
        FACTURACIONBE.NOM_CTCT = cmbctct_cod.Text
        If cmbestado.SelectedIndex = 0 Then
            FACTURACIONBE.EST = "H"
        ElseIf cmbestado.SelectedIndex = 1 Then
            FACTURACIONBE.EST = "A"

        End If
        If dtpfanul.Checked Then
            FACTURACIONBE.FEC_ANU = dtpfanul.Value
        Else
            FACTURACIONBE.FEC_ANU = Nothing
        End If
        FACTURACIONBE.SIGNO = "-"
        FACTURACIONBE.OBSERVA = RTrim(txtobservacion.Text)
        FACTURACIONBE.MONEDA = txtmon.Text
        FACTURACIONBE.DIR_COD = RTrim(txtdir.Text)
        For i = 0 To dgvt_doc.Rows.Count - 1
            DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value) + DAcumula
            DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value) + DAcumula1
            DAcumula2 = Val(dgvt_doc.Rows(i).Cells("DSCTO_IMPOR").Value) + DAcumula2
            DAcumula3 = Val(dgvt_doc.Rows(i).Cells("DSCTO_DIMPOR").Value) + DAcumula3
            DAcumula4 = Val(dgvt_doc.Rows(i).Cells("IGV_IMPOR").Value) + DAcumula4
            DAcumula5 = Val(dgvt_doc.Rows(i).Cells("IGV_DIMPOR").Value) + DAcumula5
        Next
        FACTURACIONBE.TPRECIO_VENTA = DAcumula
        FACTURACIONBE.TPRECIO_DVENTA = DAcumula1
        FACTURACIONBE.T_DCTO = DAcumula2
        FACTURACIONBE.T_DCTO_DOLAR = DAcumula3
        FACTURACIONBE.T_IGV = DAcumula4
        FACTURACIONBE.T_IGV_DOLAR = DAcumula5
        FACTURACIONBE.PROVEEDOR = "20100279348"
        FACTURACIONBE.CTCT_COD = RTrim(txtctct_cod.Text)
        FACTURACIONBE.FEC_DIA = RTrim(DateTime.Now)
        FACTURACIONBE.NUMPEDIDO = txtoc.Text
        FACTURACIONBE.USUARIO = RTrim(gsUser)
        FACTURACIONBE.F_PAGO_ENT = RTrim(txtt_pago.Text)
        FACTURACIONBE.FOR_ENT_COD = RTrim(txtfor_ent.Text)
        FACTURACIONBE.T_MOVINV = txtt_movinv.Text
        FACTURACIONBE.VENDEDOR = txtvendedor.Text
        FACTURACIONBE.OBSERVA1 = txtobserva1.Text
        ELMVLOGSBE.log_codusu = gsCodUsr

        If chkAdelanto.Checked Then
            FACTURACIONBE.X_LETRA = "1"
        Else
            FACTURACIONBE.X_LETRA = ""
        End If

        If chkdif.Checked Then
            FACTURACIONBE.EST1 = "1"
        End If
        'FACTURACIONBE.REG_NRO = Replace(Mid(dtpfecha.Value, 4, 7), "/", "")
        If cmbx_ret.SelectedIndex = "0" Then
            FACTURACIONBE.X_RET = "R"
        Else
            FACTURACIONBE.X_RET = "N"
        End If
        If chkest_mercaderia.Checked Then
            FACTURACIONBE.EST_MERCADERIA = "1"
        End If
        Dim conteo As Integer = 0
        For i = 0 To dgvt_doc.Rows.Count - 1
            For j = 0 To dgvt_doc.Rows.Count - 1
                If i > 0 Then
                    If i <> j Then
                        If dgvt_doc.Rows(i).Cells("ART_COD").Value = dgvt_doc.Rows(j).Cells("ART_COD").Value Then
                            conteo = conteo + 1
                            dgvt_doc.Rows(i).Cells("nro_doc_ref1").Value = Mid((dgvt_doc.Rows(i).Cells("nro_doc_ref1").Value).ToString.PadLeft(7, "0"), 1, 7) & "-" & conteo
                        End If
                    End If
                End If
            Next
        Next
        ELMVLOGSBE.log_observ = gsUser
        mesaño = Replace(Mid(dtpfecha.Value, 4, 7), "/", "")
        m = Mid(dtpfecha.Value, 4, 2)
        gsError = FACTURACIONBL.SaveRow(FACTURACIONBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            ' gsError2 = FACTURACIONBL.AsientoFC("Asiento", mesaño, m, RTrim(txtnumero.Text), cmb_serdoc.Text, txtt_doc.Text, FACTURACIONBE.EST, dgvt_doc)
            ' If gsError2 = "OK" Then
            'MsgBox("Asiento Creado", MsgBoxStyle.Information)
            'Else
            'FormMain.LblError.Text = gsError2
            ' MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
            'End If
            tsbGrabar.Enabled = False
        Else
                FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = FACTURACIONBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmbt_doc.SelectedValue = txtt_doc.Text
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            'dtpfanul.Checked = IIf(IsDBNull(Registro("FEC_ANU")), False, True)
            Select Case Registro("EST").ToString
                Case ""
                    cmbestado.SelectedIndex = -1
                Case "H"
                    cmbestado.SelectedIndex = 0
                Case "A"
                    cmbestado.SelectedIndex = 1
                Case "P"
                    cmbestado.SelectedIndex = 2
                Case "T"
                    cmbestado.SelectedIndex = 3
                Case "S"
                    cmbestado.SelectedIndex = 4
                Case "V"
                    cmbestado.SelectedIndex = 5
            End Select
            If cmbestado.SelectedIndex = 1 Then
                dtpfanul.Checked = True
                dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            End If
            If IIf(IsDBNull(Registro("EST1")), "", Registro("EST1")) = "1" Then
                chkdif.Checked = True
            End If
            'cmbestado.Text = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))
            txtobserva1.Text = IIf(IsDBNull(Registro("OBSERVA1")), "", Registro("OBSERVA1"))
            txtoc.Text = IIf(IsDBNull(Registro("NUMPEDIDO")), "", Registro("NUMPEDIDO"))
            txtt_movinv.Text = IIf(IsDBNull(Registro("T_MOVINV")), "", Registro("T_MOVINV"))
            cmbt_movinv.SelectedValue = txtt_movinv.Text
            txtt_pago.Text = IIf(IsDBNull(Registro("F_PAGO_ENT")), "", Registro("F_PAGO_ENT"))
            cmbt_pago.SelectedValue = txtt_pago.Text
            txtfor_ent.Text = IIf(IsDBNull(Registro("FOR_ENT_COD")), "", Registro("FOR_ENT_COD"))
            cmbfor_ent.SelectedValue = txtfor_ent.Text
            txtmon.Text = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            cmbmon.SelectedValue = txtmon.Text
            txtvendedor.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            cmbvendedor.SelectedValue = txtvendedor.Text
            txtctct_cod.Text = IIf(IsDBNull(Registro("CTCT_COD")), "", Registro("CTCT_COD"))
            If IIf(IsDBNull(Registro("EST_MERCADERIA")), "", Registro("EST_MERCADERIA")) = "1" Then
                chkest_mercaderia.Checked = True
            End If
            'txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            'cmbvendedor.SelectedValue = txtvendedor.Text
            txtvendedor.Text = IIf(IsDBNull(Registro("VENDEDOR")), "", Registro("VENDEDOR"))
            cmbvendedor.SelectedValue = txtvendedor.Text
            'Carga la direccion de acuerdo al cliente
            Dim dt As DataTable
            dt = FACTURACIONBL.SelectDir(txtctct_cod.Text)
            Try
                GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            Catch ex As Exception

            End Try
            cmbctct_cod.SelectedValue = txtctct_cod.Text
            txtdir.Text = IIf(IsDBNull(Registro("DIR_COD")), "", Registro("DIR_COD"))
            cmbdir.SelectedValue = txtdir.Text
            npdnumletra.Value = Val(IIf(IsDBNull(Registro("TIPO")), 0, Registro("TIPO")))
            'Carga el Vendedor
            txtobservacion.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txttprecio_compra.Text = IIf(IsDBNull(Registro("tprecio_venta")), "", Registro("tprecio_venta"))
            txttprecio_dcompra.Text = IIf(IsDBNull(Registro("tprecio_dventa")), "", Registro("tprecio_dventa"))
            txtt_dcto.Text = IIf(IsDBNull(Registro("T_DCTO")), 0, Registro("T_DCTO"))
            txtt_dcto_dolar.Text = IIf(IsDBNull(Registro("T_DCTO_DOLAR")), 0, Registro("T_DCTO_DOLAR"))
            txtt_igv.Text = IIf(IsDBNull(Registro("T_IGV")), "", Registro("T_IGV"))
            txtt_igv_dolar.Text = IIf(IsDBNull(Registro("T_IGV_DOLAR")), "", Registro("T_IGV_DOLAR"))
            If txttprecio_compra.TextLength > 0 And txtt_igv.TextLength > 0 And txtt_dcto.TextLength > 0 Then
                txttcompras.Text = Math.Round(CDbl(txttprecio_compra.Text) + CDbl(txtt_igv.Text) - CDbl(txtt_dcto.Text), 2)
                txttcomprad.Text = Math.Round(CDbl(txttprecio_dcompra.Text) + CDbl(txtt_igv_dolar.Text) - CDbl(txtt_dcto_dolar.Text), 2)
            Else
                txttcompras.Text = 0
                txttcomprad.Text = 0
            End If
            txtnro_reg.Text = IIf(IsDBNull(Registro("reg_nro")), "", Registro("reg_nro"))
            If IIf(IsDBNull(Registro("X_RET")), "", Registro("X_RET")) = "R" Then
                cmbx_ret.SelectedIndex = "0"
            Else
                cmbx_ret.SelectedIndex = "1"
            End If
        Next
        npdnumletra.Value = FACTURACIONBL.SelNroLet(sT_Ref, sS_Ref, sN_Ref)
    End Sub
    Private Sub FormMantFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_obsPago.Enabled = False
        txt_obsPago.BackColor = Color.White
        txt_obsPago.ForeColor = Color.Black

        If (FormMain.cmbaño.Text = "2021" And FormMain.cmbmes.SelectedIndex <= 3) Or
            (FormMain.cmbaño.Text <= "2020" And FormMain.cmbmes.SelectedIndex <= 11) Then
            If gsUser <> "CHOYOS" Or gsUser <> "SISTEMA" Then
                MsgBox("El mes se encuentra cerrado")
                tsbGrabar.Enabled = False
            End If
        End If
        txtt_doc.Select()
        bPrimero = True
        gsError = ""
        gpCaption = "Facturacion"
        Me.Text = gpCaption
        txtnro_reg.ReadOnly = True
        txttprecio_compra.ReadOnly = True
        txtt_dcto.ReadOnly = True
        txtt_igv.ReadOnly = True
        txttcompras.ReadOnly = True
        txttprecio_dcompra.ReadOnly = True
        txtt_dcto_dolar.ReadOnly = True
        txtt_igv_dolar.ReadOnly = True
        txttcomprad.ReadOnly = True
        Me.txtvendedor.ReadOnly = True
        txtt_pago.Enabled = False
        cmbt_pago.Enabled = False
        Button3.Enabled = False
        'Cargar los combos
        Dim dt As DataTable = FACTURACIONBL.SelectT_DOC("01")
        GetCmb("cod", "nom", dt, cmbt_doc)
        dt = FACTURACIONBL.SelectT_MOVINV()
        GetCmb("cod", "nom", dt, cmbt_movinv)
        dt = FACTURACIONBL.SelectF_PAGO
        GetCmb("cod", "nom", dt, cmbt_pago)
        dt = FACTURACIONBL.SelectF_ENT
        GetCmb("cod", "nom", dt, cmbfor_ent)
        dt = FACTURACIONBL.SelectMoneda
        GetCmb("cod", "nom", dt, cmbmon)
        cmbmon.SelectedIndex = 1
        txtmon.Text = "01"
        dt = FACTURACIONBL.SelectVendedor
        GetCmb("cod", "nom", dt, cmbvendedor)
        dt = FACTURACIONBL.SelectCliente
        GetCmb("cod", "nom", dt, cmbctct_cod)
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
        dgvt_doc.Columns.Add("MEDIDA", "Medida") '10
        dgvt_doc.Columns.Add("UNIDAD", "Und.") '11
        dgvt_doc.Columns.Add("FEC_ENT", "Hora") '12
        dgvt_doc.Columns.Add("ACT_COD", "Activos") '13
        dgvt_doc.Columns.Add("FEC_LLEG", "Fec.Vcto") '14
        dgvt_doc.Columns.Add("PART_ACT", "P. Act.") '15
        dgvt_doc.Columns.Add("ALM_COD", "Alm") '16
        dgvt_doc.Columns.Add("SIGNO", "Signo") '17
        dgvt_doc.Columns.Add("OBSERVA", "Observa") '18
        dgvt_doc.Columns.Add("T_MOVINV", "T. Mov.") '19
        dgvt_doc.Columns.Add("TPRECIO_VENTA", "P. Venta") '20
        dgvt_doc.Columns.Add("TPRECIO_DVENTA", "P. Venta. D.") '21
        dgvt_doc.Columns.Add("IGV", "Igv") '22
        dgvt_doc.Columns.Add("IGV_IMPOR", "Cant. IGV") '23
        dgvt_doc.Columns.Add("T_CAMB", "Camb.") '24
        dgvt_doc.Columns.Add("UPRECIO_VENTA", "Pre. Venta") '25
        dgvt_doc.Columns.Add("UPRECIO_DVENTA", "Pre. D. Venta") '26
        dgvt_doc.Columns.Add("IGV_DIMPOR", "Cant. IGV D.") '27
        dgvt_doc.Columns.Add("MONEDA", "Moneda") '28
        dgvt_doc.Columns.Add("FEC_GENE", "F. Gene") '29
        dgvt_doc.Columns.Add("USUARIO", "Usuario") '30
        dgvt_doc.Columns.Add("UNIDAD", "Und") '31
        dgvt_doc.Columns.Add("F_PAGO_ENT", "F. Pago") '32
        dgvt_doc.Columns.Add("FOR_ENT_COD", "F. Cod. Ent") '33
        dgvt_doc.Columns.Add("FEC_DIA", "F. Dia") '34
        dgvt_doc.Columns.Add("PROVEEDOR", "Prov.") '35
        dgvt_doc.Columns.Add("CCO_COD", "C. Costo") '36
        dgvt_doc.Columns.Add("CANTIDAD", "Cant.") '37
        dgvt_doc.Columns.Add("LOTE", "Lote") '38
        dgvt_doc.Columns.Add("PER_COD", "Cod. Per") '39
        dgvt_doc.Columns.Add("NRO_DOCU1", "Nro. Docu") '40
        dgvt_doc.Columns.Add("MARCA", "Marca") '41
        dgvt_doc.Columns.Add("DSCTO", "Dscto. %") '42
        dgvt_doc.Columns.Add("DSCTO_IMPOR", "Dscto. S.") '43
        dgvt_doc.Columns.Add("DSCTO_DIMPOR", "Dscto D.") '44
        dgvt_doc.Columns.Add("EST", "Est.") '45
        dgvt_doc.Columns.Add("PERCEPCION", "PERCEPCION") '46 <- 07/03/22
        If DateTime.Now.ToString("yyyy/MM/dd") >= "2021/05/01" Then
            chkest_mercaderia.Visible = True
        Else
            chkest_mercaderia.Visible = False
        End If

        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                habilitar(False)
                bTercero = "1"
                bCuarto = "1"
                Me.txtt_doc.Text = "01"
                Me.txtt_movinv.Text = "S02"
                cmbt_doc.SelectedValue = txtt_doc.Text
                btndocu.Enabled = True
                cmbt_movinv.SelectedValue = Me.txtt_movinv.Text
                cmb_serdoc.SelectedIndex = 0
                cmbestado.SelectedIndex = 0
                txtt_pago.Text = "08"
                cmbt_pago.SelectedValue = txtt_pago.Text
                txtfor_ent.Text = "09"
                cmbfor_ent.SelectedValue = txtfor_ent.Text
                btncliente.Select()
                txtmon.Text = "01"
                cmbmon.SelectedValue = txtmon.Text
                cmbx_ret.SelectedIndex = "1"
                Me.txtmon.Select()
                'Me.txtnumero.Text = "0750000"
                'cmblinea.Enabled = True
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                'dgvt_doc.Columns(3).Visible = False
                'dgvt_doc.Columns(4).Visible = False
                'dgvt_doc.Columns(5).Visible = False
                dgvt_doc.Columns(6).Visible = False
                'dgvt_doc.Columns(7).Visible = False
                dgvt_doc.Columns(12).Visible = False
                dgvt_doc.Columns(13).Visible = False
                dgvt_doc.Columns(14).Visible = False
                dgvt_doc.Columns(15).Visible = False
                dgvt_doc.Columns(16).Visible = False
                dgvt_doc.Columns(17).Visible = False
                'dgvt_doc.Columns(18).Visible = False
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
                dgvt_doc.Columns(34).Visible = False
                dgvt_doc.Columns(35).Visible = False
                dgvt_doc.Columns(36).Visible = False
                dgvt_doc.Columns(37).Visible = False
                dgvt_doc.Columns(38).Visible = False
                dgvt_doc.Columns(38).Visible = False
                dgvt_doc.Columns(39).Visible = False
                'dgvt_doc.Columns(40).Visible = False
                dgvt_doc.Columns(41).Visible = False
                dgvt_doc.Columns(42).Visible = False
                dgvt_doc.Columns(43).Visible = False
                dgvt_doc.Columns(44).Visible = False
                dgvt_doc.Columns(45).Visible = False
            Case 1
                flagAccion = "M"
                GetData("01", sSDoc, sNDoc)
                bCuarto = "1"
                If txtt_movinv.Text = "S06" Then
                    btnexp.Enabled = True
                End If
                'habilitar(True)
                'cmb_serdoc.Enabled = False
                Dim dtArticulo As DataTable
                dtArticulo = FACTURACIONBL.getListdgv("01", sSDoc, sNDoc)
                For Each row As DataRow In dtArticulo.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                      IIf(IsDBNull(row("CTCT_COD")), "", row("CTCT_COD")),'6
                                      IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),'7
                                      IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'8
                                      IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),'9
                                      IIf(IsDBNull(row("MEDIDA")), "", row("MEDIDA")), '10
                                      IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")), '11
                                      IIf(IsDBNull(row("FEC_ENT")), "", row("FEC_ENT")),'12
                                      IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")),'13
                                      IIf(IsDBNull(row("FEC_LLEG")), "", row("FEC_LLEG")),'14
                                      IIf(IsDBNull(row("PART_ACT")), "", row("PART_ACT")),'15
                                      IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),'16
                                      IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),'17
                                      IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),'18
                                      IIf(IsDBNull(row("T_MOVINV")), "", row("T_MOVINV")),'19
                                      IIf(IsDBNull(row("TPRECIO_VENTA")), "", row("TPRECIO_VENTA")),'20
                                      IIf(IsDBNull(row("TPRECIO_DVENTA")), "", row("TPRECIO_DVENTA")),'21
                                      IIf(IsDBNull(row("IGV")), "", row("IGV")),'22
                                      IIf(IsDBNull(row("IGV_IMPOR")), "", row("IGV_IMPOR")),'23
                                      IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),'24
                                      IIf(IsDBNull(row("UPRECIO_VENTA")), "", row("UPRECIO_VENTA")),'25
                                      IIf(IsDBNull(row("UPRECIO_DVENTA")), "", row("UPRECIO_DVENTA")),'26
                                      IIf(IsDBNull(row("IGV_DIMPOR")), "", row("IGV_DIMPOR")),'27
                                      IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),'28
                                      IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),'29
                                      IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),'30
                                      IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),'31
                                      IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")),'32
                                      IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),'33
                                      IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")),'34
                                      IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'35
                                      IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),'36
                                      IIf(IsDBNull(row("CANTIDAD1")), "", row("CANTIDAD1")),'37
                                      IIf(IsDBNull(row("LOTE")), "", row("LOTE")),'38
                                      IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),'39
                                      IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")),'40
                                      IIf(IsDBNull(row("MARCA")), "", row("MARCA")),'41
                                      IIf(IsDBNull(row("DSCTO")), "", row("DSCTO")),'42
                                      IIf(IsDBNull(row("DSCTO_IMPOR")), "", row("DSCTO_IMPOR")),'43
                                      IIf(IsDBNull(row("DSCTO_DIMPOR")), "", row("DSCTO_DIMPOR")),'44
                                      IIf(IsDBNull(row("EST")), "", row("EST"))) '45
                Next
                Dim i As Integer
                For i = 0 To 45
                    dgvt_doc.Columns(i).ReadOnly = True
                Next
                Try
                    dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(7)
                Catch ex As Exception
                    MsgBox("No hay datos en el detalle")
                End Try
                'Me.btnborrar.Enabled = False
                'Me.btndocu.Enabled = False
                'Me.btnagregar.Enabled = False
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                'dgvt_doc.Columns(3).Visible = False
                'dgvt_doc.Columns(4).Visible = False
                'dgvt_doc.Columns(5).Visible = False
                dgvt_doc.Columns(6).Visible = False
                'dgvt_doc.Columns(7).Visible = False
                dgvt_doc.Columns(12).Visible = False
                dgvt_doc.Columns(13).Visible = False
                dgvt_doc.Columns(14).Visible = False
                dgvt_doc.Columns(15).Visible = False
                dgvt_doc.Columns(16).Visible = False
                dgvt_doc.Columns(17).Visible = False
                'dgvt_doc.Columns(18).Visible = False
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
                dgvt_doc.Columns(34).Visible = False
                dgvt_doc.Columns(35).Visible = False
                dgvt_doc.Columns(36).Visible = False
                dgvt_doc.Columns(37).Visible = False
                dgvt_doc.Columns(38).Visible = False
                dgvt_doc.Columns(38).Visible = False
                dgvt_doc.Columns(39).Visible = False
                'dgvt_doc.Columns(40).Visible = False
                dgvt_doc.Columns(41).Visible = False
                dgvt_doc.Columns(42).Visible = False
                dgvt_doc.Columns(43).Visible = False
                dgvt_doc.Columns(44).Visible = False
                dgvt_doc.Columns(45).Visible = False
                dgvt_doc.Columns(46).Visible = False

        End Select
        bPrimero = False
    End Sub

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

    Private Sub cmbvendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvendedor.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbvendedor.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtvendedor.Text = cmbvendedor.SelectedValue

    End Sub

    Private Sub cmbdir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdir.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbdir.SelectedValue Is Nothing Then
            Exit Sub
        End If
        If cmbdir.SelectedIndex <> -1 Then
            txtdir.Text = cmbdir.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmbctct_cod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbctct_cod.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbctct_cod.SelectedValue Is Nothing Then
            Exit Sub
        End If
        If cmbctct_cod.SelectedIndex <> -1 Then
            txtctct_cod.Text = cmbctct_cod.SelectedValue.ToString
        End If
        Dim dt As DataTable
        dt = FACTURACIONBL.SelectDir(txtctct_cod.Text)
        Try
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            'cmbdir.SelectedValue = txtdir.Text
            Try
                cmbdir.SelectedValue = "01"
                If cmbdir.SelectedIndex = -1 Then
                    cmbdir.SelectedValue = "1"
                End If
            Catch ex As Exception

            End Try
            txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            cmbvendedor.SelectedValue = txtvendedor.Text
        Catch ex As Exception

        End Try
        If flagAccion = "N" Then
            habilitar(True)
        End If
    End Sub
    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        If bTercero = "0" Then
            Exit Sub
        End If
        Dim nro As String
        'txtnumero.Enabled = False
        If (txtt_doc.TextLength > 0 And cmb_serdoc.SelectedIndex <> -1 And bTercero = "1") Then
            nro = FACTURACIONBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)
            txtnumero.Text = nro.PadLeft(10, "0")
        End If
    End Sub

#End Region

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtmon.Text = "" Or txtt_movinv.Text = "" Then
            MsgBox("Ingrese la moneda")
            Exit Sub
        End If
        gContador = 1
        Dim dt As DataTable
        If txtctct_cod.Text = "" Then
            MsgBox("Por favor seleccione un Cliente")
            Exit Sub
        End If
        gCliente = txtctct_cod.Text
        dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
        Dim frm As New FormMantDetFacturacion
        For Each Registro In dt.Rows
            frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
        Next
        frm.txtigv.Text = 18

        frm.ShowDialog()
        gCliente = Nothing
    End Sub
#Region "Txt"

    Private Sub txtt_movinv_LostFocus(sender As Object, e As EventArgs) Handles txtt_movinv.LostFocus
        If txtt_movinv.Text = "" Then
            cmbt_movinv.SelectedValue = ""
            Exit Sub
        End If
        cmbt_movinv.SelectedValue = txtt_movinv.Text
        If cmbt_movinv.SelectedValue Is Nothing Then
            MsgBox("Tipo de Movimiento no existe", MsgBoxStyle.Exclamation)
            txtt_movinv.Text = ""
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
        End If
    End Sub

    Private Sub txtctct_cod_LostFocus(sender As Object, e As EventArgs) Handles txtctct_cod.LostFocus
        Dim dt As DataTable
        If txtctct_cod.Text <> "" Then
            cmbctct_cod.SelectedValue = txtctct_cod.Text
            dt = REQUERIMIENTOBL.SelectDir(txtctct_cod.Text)
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            Try
                cmbdir.SelectedValue = "01"
                If cmbdir.SelectedIndex = -1 Then
                    cmbdir.SelectedValue = "1"
                End If
            Catch ex As Exception
            End Try
            If txtctct_cod.Text = "20100279348" Then
                cmbdir.SelectedValue = "0"
            End If
            txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            cmbvendedor.SelectedValue = txtvendedor.Text

            txt_obsPago.Text = CTCTBL.SelectObsPago(txtctct_cod.Text)

        End If

    End Sub

    Private Sub txtctct_codr_TextChanged(sender As Object, e As EventArgs) Handles txtctct_cod.TextChanged
        Dim dt As DataTable
        If cmbctct_cod.SelectedIndex <> -1 Then
            dt = REQUERIMIENTOBL.SelectDir(txtctct_cod.Text)
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
        End If
    End Sub

    Private Sub btncliente_Click_1(sender As Object, e As EventArgs) Handles btncliente.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            Dim dt As DataTable
            txtctct_cod.Text = gLinea
            cmbctct_cod.SelectedValue = gLinea
            dt = REQUERIMIENTOBL.SelectDir(gLinea)
            GetCmb2("dir_cod", "nom_dir", dt, cmbdir)
            cmbdir.SelectedValue = txtdir.Text
            txtvendedor.Text = CTCTBL.SelectVendedor(gLinea)
            cmbvendedor.SelectedValue = txtvendedor.Text
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If

    End Sub
    Private Sub txtctct_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtctct_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "53"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtctct_cod.Text = gLinea
                cmbctct_cod.SelectedValue = gLinea
                Dim dt As DataTable = REQUERIMIENTOBL.SelectDir(gLinea)
                GetCmb2("dir_cod", "nom_dir", dt, cmbdir)
                cmbdir.SelectedValue = txtdir.Text
                txtvendedor.Text = CTCTBL.SelectVendedor(gLinea)
                cmbvendedor.SelectedValue = txtvendedor.Text
                e.Handled = True
                e.Handled = True
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If

        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim dt As DataTable
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormMantDetFacturacion
            gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
            frm.txtcodart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
            'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
            sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value
            'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
            frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
            frm.npdtcamb.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_CAMB").Value)
            frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
            frm.txtguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
            frm.npduprecio_venta.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_VENTA").Value)
            frm.npduprecio_dventa.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_DVENTA").Value)
            frm.txttprecio_venta.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_VENTA").Value)
            frm.txttprecio_dventa.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_DVENTA").Value)
            frm.txtdscto.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_IMPOR").Value)
            frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
            frm.txtigvimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV_IMPOR").Value)
            frm.txtigv_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV_DIMPOR").Value)
            frm.txtdscto_impor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_IMPOR").Value)
            frm.txtdscto_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_DIMPOR").Value)
            frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value
            frm.txtpercepcion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PERCEPCION").Value
            'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value) = 0 Then
            '    frm.txtigv.Text = 18
            'End If
            'frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
            If frm.npduprecio_venta.Text.Length > 0 And frm.npdcantidad.Text.Length And frm.txtigv.Text > 0 Then
                frm.txttcompras.Text = Math.Round((frm.npduprecio_venta.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_venta.Text * frm.npdcantidad.Text, 2)
                frm.txttcomprad.Text = Math.Round(((frm.npduprecio_venta.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_venta.Text * frm.npdcantidad.Text) / frm.npdtcamb.Text, 2)
            End If
            'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
            '    dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year.ToString("yyyy") & "/" & dtpfecha.Value.Month.ToString("MM") & "/" & dtpfecha.Value.Day.ToString("dd"))
            '    For Each Registro In dt.Rows
            '        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
            '    Next
            'End If
            gCliente = txtctct_cod.Text
            If flagAccion = "M" Then
                'frm.btnagregar.Enabled = False
            ElseIf flagAccion = "N" Then
                Dim mesfecha As String
                Dim mesdia As String
                If dtpfecha.Value.Month.ToString.Length = "1" Then
                    mesfecha = "0" & dtpfecha.Value.Month.ToString
                Else
                    mesfecha = dtpfecha.Value.Month.ToString
                End If
                If dtpfecha.Value.Day.ToString.Length = "1" Then
                    mesdia = "0" & dtpfecha.Value.Day.ToString
                Else
                    mesdia = dtpfecha.Value.Day.ToString
                End If
                If chkest_mercaderia.Checked = True Then
                    dt = REQUERIMIENTOBL.getT_CAMB1(dtpfecha.Value.Year & "/" & mesfecha & "/" & mesdia)
                Else
                    dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year & "/" & mesfecha & "/" & mesdia)
                End If

                For Each Registro In dt.Rows
                    frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
                Next
                frm.txtigv.Text = 7
            End If
            gContador = 0
                frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub btnexp_Click(sender As Object, e As EventArgs) Handles btnexp.Click
        Dim frm As New FormMantExpor
        'Dim dt As DataTable = COSTO_EXPBL.SelectRow("01")
        frm.txtt_doc_ref.Text = txtt_doc.Text
        frm.txtser_doc_ref.Text = cmb_serdoc.Text
        frm.txtnro_doc_ref.Text = txtnumero.Text
        frm.ShowDialog()
        flagAccion1 = Nothing
    End Sub

    Private Sub FormMantFacturacion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim frm As New FormDocuRef
        gsCode = "3"
        sOp = "1"
        frm.ShowDialog()
        sMov = ""

    End Sub

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "226"
        'Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()

        If gLinea <> Nothing Then
            txtt_pago.Text = gLinea
            cmbt_pago.SelectedValue = gLinea
            gLinea = Nothing
        Else
            gLinea = Nothing
        End If
    End Sub

    Private Sub BtnLetraNum_Click(sender As Object, e As EventArgs) Handles BtnLetraNum.Click
        Dim frm As New FormMantDetLet_Monto
        If Mid(cmbt_pago.Text, 1, 5) = "LETRA" Then
            If npdnumletra.Value > 0 Then
                frm.txtt_doc_ref.Text = txtt_doc.Text
                frm.txtser_doc_ref.Text = cmb_serdoc.Text
                frm.txtnro_doc_ref.Text = txtnumero.Text
                frm.txtproveedor.Text = txtctct_cod.Text
                frm.txtmoneda.Text = txtmon.Text
                frm.txtnom_moneda.Text = PROVISIONESBL.Select_MON_row(txtmon.Text)
                If dgvt_doc.Rows.Count > 0 Then
                    frm.npdt_cmb.Value = dgvt_doc.Rows(0).Cells("T_CAMB").Value
                End If
                If txtmon.Text = "01" Then
                    frm.npdmontos.Enabled = False
                    frm.npdmontod_fact.Value = txttcomprad.Text
                Else
                    frm.npdmontod.Enabled = True
                    frm.npdmontos_fact.Value = txttcompras.Text
                End If
                frm.lblnumlet.Text = npdnumletra.Value
                frm.lblcantitem.Text = dgvt_doc.Rows.Count
                gsCode13 = flagAccion

                Dim dg As DataGridView = dgvt_doc
                For Each row As DataGridViewRow In dg.Rows
                    frm.dgvt_det.Rows.Add("", "", "",
                                          IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("SER_DOC_REF").Value)), "", RTrim(row.Cells("SER_DOC_REF").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("NRO_DOC_REF").Value)), "", RTrim(row.Cells("NRO_DOC_REF").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("CTCT_COD").Value)), "", RTrim(row.Cells("CTCT_COD").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("CANTIDAD").Value)), 0, RTrim(row.Cells("CANTIDAD").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("EST").Value)), "", RTrim(row.Cells("EST").Value)),
                                          "-",
                                          IIf(IsDBNull(RTrim(row.Cells("OBSERVA").Value)), "", RTrim(row.Cells("OBSERVA").Value)),
                                          "",
                                          IIf(IsDBNull(RTrim(row.Cells("TPRECIO_VENTA").Value)), 0, RTrim(row.Cells("TPRECIO_VENTA").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("TPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("TPRECIO_DVENTA").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("IGV").Value)), 0, RTrim(row.Cells("IGV").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("IGV_IMPOR").Value)), 0, RTrim(row.Cells("IGV_IMPOR").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("T_CAMB").Value)), 0, RTrim(row.Cells("T_CAMB").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("UPRECIO_VENTA").Value)), 0, RTrim(row.Cells("UPRECIO_VENTA").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("UPRECIO_DVENTA").Value)), 0, RTrim(row.Cells("UPRECIO_DVENTA").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("IGV_DIMPOR").Value)), 0, RTrim(row.Cells("IGV_DIMPOR").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("USUARIO").Value)), "", RTrim(row.Cells("USUARIO").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("MONEDA").Value)), "", RTrim(row.Cells("MONEDA").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("UNIDAD").Value)), "", RTrim(row.Cells("UNIDAD").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("FEC_GENE").Value)), "", RTrim(row.Cells("FEC_GENE").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("FEC_DIA").Value)), "", RTrim(row.Cells("FEC_DIA").Value)),
                                          IIf(IsDBNull(RTrim(row.Cells("PROVEEDOR").Value)), "", RTrim(row.Cells("PROVEEDOR").Value)),
                                          dtpfecha.Value)
                Next
                'CABECERA LETRA
                frm.dgvt_doclet.Columns.Add("T_DOC_REF", "T_DOC_REF") '0
                frm.dgvt_doclet.Columns.Add("SER_DOC_REF", "SER_DOC_REF") '1
                frm.dgvt_doclet.Columns.Add("NRO_DOC_REF", "NRO_DOC_REF") '2
                frm.dgvt_doclet.Columns.Add("CTCT_COD", "CTCT_COD") '3
                frm.dgvt_doclet.Columns.Add("EST", "EST") '4
                frm.dgvt_doclet.Columns.Add("SIGNO", "SIGNO") '5
                frm.dgvt_doclet.Columns.Add("OBSERVA", "OBSERVA") '6
                frm.dgvt_doclet.Columns.Add("ART_COD", "ART_COD") '7
                frm.dgvt_doclet.Columns.Add("USUARIO", "USUARIO") '8
                frm.dgvt_doclet.Columns.Add("MONEDA", "MONEDA") '9
                frm.dgvt_doclet.Columns.Add("FEC_GENE", "FEC_GENE") '10
                frm.dgvt_doclet.Columns.Add("PROVEEDOR", "PROVEEDOR") '11
                frm.dgvt_doclet.Columns.Add("VENDEDOR", "VENDEDOR") '12
                frm.dgvt_doclet.Columns.Add("DIR_COD", "DIR_COD") '13
                frm.dgvt_doclet.Columns.Add("NUMPEDIDO", "NUMPEDIDO") '14
                frm.dgvt_doclet.Columns.Add("TPRECIO_VENTA", "TPRECIO_VENTA") '15
                frm.dgvt_doclet.Columns.Add("TPRECIO_DVENTA", "TPRECIO_DVENTA") '16
                frm.dgvt_doclet.Columns.Add("T_IGV", "T_IGV") '17
                frm.dgvt_doclet.Columns.Add("T_IGV_DOLAR", "T_IGV_DOLAR") '18
                frm.dgvt_doclet.Columns.Add("NOM_CTCT", "NOM_CTCT") '18
                frm.dgvt_doclet.Rows.Add("", "", "",
                                      txtctct_cod.Text,
                                      "H", "-", "", "07010003", gsUser, txtmon.Text, dtpfecha.Value, "20100279348", txtvendedor.Text,
                                      txtdir.Text, txtoc.Text, txttprecio_compra.Text, txttprecio_dcompra.Text, txtt_igv.Text, txtt_igv_dolar.Text,
                                      cmbctct_cod.Text)
                frm.dtpfec_gene.Value = dtpfecha.Value


                If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PERCEPCION").Value = Nothing Then
                    frm.GroupBox1.Enabled = False
                Else
                    frm.GroupBox1.Enabled = True
                End If


                frm.ShowDialog()
                Else
                    MsgBox("No ah especificado el Numero de Letras para la Factura")
                Exit Sub
            End If
        Else
            MsgBox("El tipo de pago no es Letra")
            Exit Sub
        End If
    End Sub

    Private Sub txtcuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuenta.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "117"
            'Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.medida = dtpfecha.Value.Year
            frm.ShowDialog()

            If gLinea <> Nothing Then
                txtcuenta.Text = gLinea
                txtnomcuenta.Text = PROVISIONESBL.SelectNomCta(txtcuenta.Text, Mid(FormMantProvisiones.txtmskfecprov.Text, 7, 4))
                gLinea = Nothing
            Else
                gLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub

#End Region
End Class