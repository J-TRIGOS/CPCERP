Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantNotaCredito
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private NOTACREDITOBL As New NOTACREDITOBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private COSTOS_EXPBL As New COSTOS_EXPBL
    Private MOV_MOTBL As New MOV_MOTBL
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
    Private sArticulo As String
    Private sArt_Cod As String = "0"
    Private MenuBL As New MenuBL
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        'If bPrimero = False Then
        cmb.DataSource = dtSelect
        'If (cmbdir.Items.Count > 0) Then
        cmb.DisplayMember = sDescri

        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
        '    End If
        'End If
    End Function
#End Region

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
        'btndocu.Enabled = est
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
        If txtmotcod.Text = "" Then
            MsgBox("Ingrese Mot. Devolución", MsgBoxStyle.Exclamation)
            txtmotcod.Focus()
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
        Dim NOTACREDITOBE As New NOTACREDITOBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        If flagAccion = "N" Then
            nro = NOTACREDITOBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)
            Select Case cmb_serdoc.SelectedIndex
                Case 0 '001
                    If nro.Length = 4 Then
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

        NOTACREDITOBE.T_DOC_REF = RTrim(txtt_doc.Text)
        NOTACREDITOBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
        NOTACREDITOBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        NOTACREDITOBE.ART_COD = "07010003"
        NOTACREDITOBE.FEC_GENE = RTrim(dtpfecha.Value)
        If cmbestado.SelectedIndex = 0 Then
            NOTACREDITOBE.EST = "H"
        ElseIf cmbestado.SelectedIndex = 1 Then
            NOTACREDITOBE.EST = "A"

        End If
        If dtpfanul.Checked Then
            NOTACREDITOBE.FEC_ANU = dtpfanul.Value
        Else
            NOTACREDITOBE.FEC_ANU = Nothing
        End If
        NOTACREDITOBE.SIGNO = "-"
        NOTACREDITOBE.OBSERVA = RTrim(txtobservacion.Text)
        NOTACREDITOBE.MONEDA = txtmon.Text
        NOTACREDITOBE.DIR_COD = RTrim(txtdir.Text)
        For i = 0 To dgvt_doc.Rows.Count - 1
            DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value) + DAcumula
            DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value) + DAcumula1
            DAcumula2 = Val(dgvt_doc.Rows(i).Cells("DSCTO_IMPOR").Value) + DAcumula2
            DAcumula3 = Val(dgvt_doc.Rows(i).Cells("DSCTO_DIMPOR").Value) + DAcumula3
            DAcumula4 = Val(dgvt_doc.Rows(i).Cells("IGV_IMPOR").Value) + DAcumula4
            DAcumula5 = Val(dgvt_doc.Rows(i).Cells("IGV_DIMPOR").Value) + DAcumula5
        Next
        NOTACREDITOBE.TPRECIO_VENTA = DAcumula
        NOTACREDITOBE.TPRECIO_DVENTA = DAcumula1
        NOTACREDITOBE.T_DCTO = DAcumula2
        NOTACREDITOBE.T_DCTO_DOLAR = DAcumula3
        NOTACREDITOBE.T_IGV = DAcumula4
        NOTACREDITOBE.T_IGV_DOLAR = DAcumula5
        NOTACREDITOBE.PROVEEDOR = "20100279348"
        NOTACREDITOBE.CTCT_COD = RTrim(txtctct_cod.Text)
        NOTACREDITOBE.FEC_DIA = RTrim(DateTime.Now)
        NOTACREDITOBE.NUMPEDIDO = txtoc.Text
        NOTACREDITOBE.USUARIO = RTrim(gsUser)
        NOTACREDITOBE.NOM_CTCT = cmbctct_cod.Text
        NOTACREDITOBE.F_PAGO_ENT = RTrim(txtt_pago.Text)
        NOTACREDITOBE.FOR_ENT_COD = RTrim(txtfor_ent.Text)
        NOTACREDITOBE.T_MOVINV = txtt_movinv.Text
        NOTACREDITOBE.VENDEDOR = txtvendedor.Text
        NOTACREDITOBE.MOT_COD = txtmotcod.Text
        ELMVLOGSBE.log_codusu = gsCodUsr
        'NOTACREDITOBE.REG_NRO = Replace(Mid(dtpfecha.Value, 4, 7), "/", "")
        NOTACREDITOBE.MOT_COD = txtmotcod.Text
        mesaño = Replace(Mid(dtpfecha.Value, 4, 7), "/", "")
        m = Mid(dtpfecha.Value, 4, 2)
        gsError = NOTACREDITOBL.SaveRow(NOTACREDITOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvt_doc)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            gsError2 = NOTACREDITOBL.AsientoFC("Asiento", mesaño, m, txtnumero.Text, cmb_serdoc.Text, txtt_doc.Text, NOTACREDITOBE.EST, dgvt_doc)
            If gsError2 = "OK" Then
                MsgBox("Asiento Creado", MsgBoxStyle.Information)
            Else
                FormMain.LblError.Text = gsError2
                MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
            End If
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = NOTACREDITOBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

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
            'cmbestado.Text = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))
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
            'txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            'cmbvendedor.SelectedValue = txtvendedor.Text
            txtvendedor.Text = IIf(IsDBNull(Registro("VENDEDOR")), "", Registro("VENDEDOR"))
            cmbvendedor.SelectedValue = txtvendedor.Text
            'Carga la direccion de acuerdo al cliente
            Dim dt As DataTable
            dt = NOTACREDITOBL.SelectDir(txtctct_cod.Text)
            Try
                GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            Catch ex As Exception

            End Try
            cmbctct_cod.SelectedValue = txtctct_cod.Text
            txtdir.Text = IIf(IsDBNull(Registro("DIR_COD")), "", Registro("DIR_COD"))
            cmbdir.SelectedValue = txtdir.Text
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
            txtmotcod.Text = IIf(IsDBNull(Registro("MOT_COD")), "", Registro("MOT_COD"))
            txtdescdevolucion.Text = MOV_MOTBL.SelectMot(txtt_doc.Text, txtmotcod.Text)

        Next
    End Sub
    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Try
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
                Case "exportar"
                    Dim frm As New FormFactElect
                    frm.fac = "07"
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
                    'frm.fecfact = dtpfecha.Value.Year.ToString & dtpfecha.Value.Month.ToString & dtpfecha.Value.Day.ToString
                    frm.ShowDialog()
                Case "Print"
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = RTrim(txtt_doc.Text)
                    gsRptArgs(1) = RTrim(cmb_serdoc.Text)
                    gsRptArgs(2) = RTrim(txtnumero.Text)
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_IMPRESION_NC.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Case "anular"

                    If MessageBox.Show("Desea anular el documento",
                       gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If

                    Dim NOTACREDITOBE As New NOTACREDITOBE
                    Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    NOTACREDITOBE.T_DOC_REF = txtt_doc.Text
                    NOTACREDITOBE.SER_DOC_REF = cmb_serdoc.Text
                    NOTACREDITOBE.NRO_DOC_REF = txtnumero.Text


                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = NOTACREDITOBL.SaveRow(NOTACREDITOBE, DET_DOCUMENTOBE, ELMVLOGSBE, "AR", dgvt_doc)


                    If gsError = "OK" Then
                        MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                        cmb_serdoc.Enabled = False
                        'sEstAlmac = cmbalmac.SelectedValue
                        Me.btnborrar.Enabled = False
                        Me.btndocu.Enabled = False
                        Me.btnagregar.Enabled = False
                        Dim i As Integer
                        For i = 0 To 45
                            dgvt_doc.Columns(i).ReadOnly = True
                        Next
                        'Dispose()
                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If



                    Exit Sub
            End Select
        Catch ex As Exception

        End Try

    End Sub
    Private Sub FormMantNotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtt_doc.Select()
        bPrimero = True
        gsError = ""
        gpCaption = "Nota Credito"
        Me.Text = gpCaption
        txtnro_reg.ReadOnly = True
        txttprecio_compra.ReadOnly = True
        txtdescdevolucion.ReadOnly = True
        txtt_dcto.ReadOnly = True
        txtt_igv.ReadOnly = True
        txttcompras.ReadOnly = True
        txttprecio_dcompra.ReadOnly = True
        txtt_dcto_dolar.ReadOnly = True
        txtt_igv_dolar.ReadOnly = True
        txttcomprad.ReadOnly = True
        Me.txtvendedor.ReadOnly = True
        'Cargar los combos
        Dim dt As DataTable = NOTACREDITOBL.SelectT_DOC("07")
        GetCmb("cod", "nom", dt, cmbt_doc)
        dt = NOTACREDITOBL.SelectT_MOVINV()
        GetCmb("cod", "nom", dt, cmbt_movinv)
        dt = NOTACREDITOBL.SelectF_PAGO
        GetCmb("cod", "nom", dt, cmbt_pago)
        dt = NOTACREDITOBL.SelectF_ENT
        GetCmb("cod", "nom", dt, cmbfor_ent)
        dt = NOTACREDITOBL.SelectMoneda
        GetCmb("cod", "nom", dt, cmbmon)
        dt = NOTACREDITOBL.SelectVendedor
        GetCmb("cod", "nom", dt, cmbvendedor)
        dt = NOTACREDITOBL.SelectCliente
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
        dgvt_doc.Columns.Add("FECHA", "FECHA") '46
        dgvt_doc.Columns.Add("NRO_DOCU2", "NRO_DOCU2") '47
        dgvt_doc.Columns.Add("CONFIGURACION", "SER_DOCU2") '48


        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                habilitar(False)
                bTercero = "1"
                bCuarto = "1"
                Me.txtt_doc.Text = "07"
                Me.txtt_movinv.Text = "S02"
                cmbt_doc.SelectedValue = txtt_doc.Text
                cmbt_movinv.SelectedValue = Me.txtt_movinv.Text
                cmb_serdoc.SelectedIndex = 0
                cmbestado.SelectedIndex = 0
                txtt_pago.Text = "08"
                cmbt_pago.SelectedValue = txtt_pago.Text
                txtfor_ent.Text = "09"
                cmbfor_ent.SelectedValue = txtfor_ent.Text
                btncliente.Select()
                txtmon.Text = "00"
                cmbmon.SelectedValue = txtmon.Text
                Me.txtmon.Select()
                'Me.txtnumero.Text = "0750000"
                'cmblinea.Enabled = True
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                'dgvt_doc.Columns(3).Visible = False
                'gvt_doc.Columns(4).Visible = False
                'dgvt_doc.Columns(5).Visible = False
                dgvt_doc.Columns(6).Visible = False
                'dgvt_doc.Columns(7).Visible = False
                dgvt_doc.Columns(12).Visible = False
                dgvt_doc.Columns(13).Visible = False
                dgvt_doc.Columns(14).Visible = False
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
                dgvt_doc.Columns(34).Visible = False
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
                dgvt_doc.Columns(46).Visible = False
                dgvt_doc.Columns(47).Visible = False
                dgvt_doc.Columns(48).Visible = False
            Case 1
                flagAccion = "M"
                GetData("07", sSDoc, sNDoc)
                bCuarto = "1"

                'habilitar(True)
                'cmb_serdoc.Enabled = False
                Dim dtArticulo As DataTable
                dtArticulo = NOTACREDITOBL.getListdgv("07", sSDoc, sNDoc)
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
                                      IIf(IsDBNull(row("EST")), "", row("EST")), '45
                                      IIf(IsDBNull(row("FECHA")), "", row("FECHA")), '46
                                      IIf(IsDBNull(row("NRO_DOCU2")), "", row("NRO_DOCU2")), '47
                                      IIf(IsDBNull(row("CONFIGURACION")), "", row("CONFIGURACION"))) '48 

                Next
                Dim i As Integer
                For i = 0 To 48
                    dgvt_doc.Columns(i).ReadOnly = True
                Next
                Try
                    dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(7)
                Catch ex As Exception
                    MsgBox("No hay datos en el detalle")
                End Try
                Me.btnborrar.Enabled = False
                Me.btndocu.Enabled = False
                Me.btnagregar.Enabled = False
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
                dgvt_doc.Columns(34).Visible = False
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
                dgvt_doc.Columns(47).Visible = False
                dgvt_doc.Columns(48).Visible = False
        End Select
        bPrimero = False
    End Sub

    Private Sub FormMantNotaCredito_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim frm As New FormDocuRef
        gsCode = "3"
        sOp = "2"
        frm.ShowDialog()
        sMov = ""
    End Sub

    Private Sub txtmotcod_LostFocus(sender As Object, e As EventArgs) Handles txtmotcod.LostFocus
        If txtmotcod.Text = "" Then
            txtdescdevolucion.Text = ""
            Exit Sub
        End If
        txtdescdevolucion.Text = MOV_MOTBL.SelectMot(txtt_doc.Text, txtmotcod.Text)
        If txtdescdevolucion.Text = "" Then
            txtmotcod.Text = ""
            MsgBox("Tipo de Motivo de Devolucion no existe", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        If bTercero = "0" Then
            Exit Sub
        End If
        Dim nro As String
        'txtnumero.Enabled = False
        If (txtt_doc.TextLength > 0 And cmb_serdoc.SelectedIndex <> -1 And bTercero = "1") Then
            nro = NOTACREDITOBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)
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
    End Sub

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
        dt = NOTACREDITOBL.SelectDir(txtctct_cod.Text)
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
        Dim frm As New FormMantDetNotaCredito
        For Each Registro In dt.Rows
            frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next
        If txtt_movinv.Text = "S06" Then
            frm.txtigv.Text = 0
        Else
            frm.txtigv.Text = 18
        End If


        frm.ShowDialog()
        gCliente = Nothing
    End Sub
    Private Sub txtmotcod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmotcod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "64"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtmotcod.Text = gLinea
                txtdescdevolucion.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncliente.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        Dim dt As DataTable
        If (gLinea <> Nothing) Then
            txtctct_cod.Text = gLinea
            cmbctct_cod.SelectedValue = gLinea
            dt = REQUERIMIENTOBL.SelectDir(gLinea)
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            cmbdir.SelectedValue = txtdir.Text
            txtvendedor.Text = CTCTBL.SelectVendedor(gLinea)
            cmbvendedor.SelectedValue = txtvendedor.Text
        Else
            gLinea = Nothing
        End If
    End Sub
    Private Sub txtctct_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtctct_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "53"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            Dim dt As DataTable
            If (gLinea <> Nothing) Then
                txtctct_cod.Text = gLinea
                cmbctct_cod.SelectedValue = gLinea
                dt = REQUERIMIENTOBL.SelectDir(gLinea)
                GetCmb("dir_cod", "nom_dir", dt, cmbdir)
                cmbdir.SelectedValue = txtdir.Text
                txtvendedor.Text = CTCTBL.SelectVendedor(gLinea)
                cmbvendedor.SelectedValue = txtvendedor.Text
                e.Handled = True
            Else
                e.Handled = True
                gLinea = ""
            End If

        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim dt As DataTable
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormMantDetNotaCredito
            gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
            frm.txtcodart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
            'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
            sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value
            'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
            frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
            frm.npdtcamb.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_CAMB").Value)
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
            frm.txtser_doc_ref1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
            frm.txtnro_doc_ref1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
            frm.txtnguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU2").Value
            frm.cmbsguia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CONFIGURACION").Value
            frm.txtdtpfec.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FECHA").Value
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value = "01" Then
                frm.cmbt_doc_ref1.SelectedIndex = 0
            Else
                frm.cmbt_doc_ref1.SelectedIndex = 1
            End If
            'If txtt_movinv.Text = "S06" Then
            '    frm.txtigv.Text = 0
            'Else
            '    If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value) = 0 Then
            '        frm.txtigv.Text = 18
            '    End If
            'End If
            frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
                If frm.npduprecio_venta.Text.Length > 0 And frm.npdcantidad.Text.Length And frm.txtigv.Text > 0 Then
                frm.txttcompras.Text = Math.Round((frm.npduprecio_venta.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_venta.Text * frm.npdcantidad.Text, 2)
                frm.txttcomprad.Text = Math.Round(((frm.npduprecio_venta.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_venta.Text * frm.npdcantidad.Text) / frm.npdtcamb.Text, 2)
            End If
                'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
                '    dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                '    For Each Registro In dt.Rows
                '        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                '    Next
                'End If
                gCliente = txtctct_cod.Text
                'If flagAccion = "M" Then
                '    'frm.btnagregar.Enabled = False
                'ElseIf flagAccion = "N" Then
                '    dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                '    For Each Registro In dt.Rows
                '        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                '    Next
                '    frm.txtigv.Text = 18
                'End If
                If flagAccion = "M" Then
                    ' frm.btnagregar.Enabled = False
                ElseIf flagAccion = "N" Then
                    Dim mesfecha As String
                    Dim mesdia As String
                    If dtpfecha.Value.Month.ToString.Length = "1" Then
                        mesfecha = "0" & dtpfecha.Value.Month.ToString
                    Else
                        mesfecha = dtpfecha.Value.Month.ToString
                    End If
                    If dtpfecha.Value.Month.ToString.Length = "1" Then
                        mesdia = "0" & dtpfecha.Value.Day.ToString
                    Else
                        mesdia = dtpfecha.Value.Day.ToString
                    End If
                dt = REQUERIMIENTOBL.getT_CAMB(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FECHA").Value)
                For Each Registro In dt.Rows
                        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                    Next
                    frm.txtigv.Text = 18
                End If
                gContador = 0
                frm.ShowDialog()
            Else
                MsgBox("No hay items en la lista para modificar")
        End If
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
        End If
    End Sub
End Class