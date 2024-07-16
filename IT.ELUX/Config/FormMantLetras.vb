Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormMantLetras
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private LETRASBL As New LETRASBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private COSTOS_EXPBL As New COSTOS_EXPBL
    Private PERBL As New PERBL
    Private ARTICULOBL As New ARTICULOBL
    Private CTCTBL As New CTCTBL
    Private flagAccion As String = ""
    Private contador As Integer = 0
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private sEstado As String
    Public btmiv As String
    Public btcmb As Integer = 0
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    Private catalogo As String = ""
    Private sArticulo As String
    Private sArt_Cod As String = "0"
    Private CantD As Integer
    Private tipo As String = ""
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
#Disable Warning BC42105 ' La función 'GetCmb' no devuelve un valor en todas las rutas de acceso de código. Puede producirse una excepción de referencia NULL en tiempo de ejecución cuando se use el resultado.
    End Function
#Enable Warning BC42105 ' La función 'GetCmb' no devuelve un valor en todas las rutas de acceso de código. Puede producirse una excepción de referencia NULL en tiempo de ejecución cuando se use el resultado.
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
        Dim dt As DataTable
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
        Dim LETRASBE As New LETRASBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        Dim ELTBLETRAS_MONTOBE As New ELTBLETRAS_MONTOBE
        If flagAccion = "N" Then
            nro = LETRASBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)
            txtnumero.Text = nro.ToString.PadLeft(7, "0")
        End If

        LETRASBE.T_DOC_REF = RTrim(txtt_doc.Text)
        LETRASBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
        LETRASBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        LETRASBE.ART_COD = "07010003"
        LETRASBE.FEC_GENE = RTrim(dtpfecha.Value)
        If cmbestado.SelectedIndex = 0 Then
            LETRASBE.EST = "H"
        ElseIf cmbestado.SelectedIndex = 1 Then
            LETRASBE.EST = "A"

        End If
        If dtpfanul.Checked Then
            LETRASBE.FEC_ANU = dtpfanul.Value
        Else
            LETRASBE.FEC_ANU = Nothing
        End If
        'chequear
        If dtpfec_letra.Checked Then
            LETRASBE.FEC_LETRA = dtpfec_letra.Text
        Else
            LETRASBE.FEC_LETRA = Nothing
        End If
        If chkz_letra.Checked Then
            LETRASBE.Z_LETRA = "X"
        Else
            LETRASBE.Z_LETRA = ""
        End If
        If chkbinteres.Checked Then
            LETRASBE.BINTERES = "1"
        Else
            LETRASBE.BINTERES = ""
        End If
        If cmbest1.SelectedIndex = 1 Then
            LETRASBE.EST1 = "T"
        ElseIf cmbest1.SelectedIndex = 2 Then
            LETRASBE.EST1 = "N"
        ElseIf cmbest1.SelectedIndex = 0 Then
            LETRASBE.EST1 = ""
        ElseIf cmbest1.SelectedIndex = -1 Then
            LETRASBE.EST1 = ""
        End If
        If txtmontopagado.Text.Length = 0 Then
            LETRASBE.MONTO_PAGADO = 0
        Else
            LETRASBE.MONTO_PAGADO = CDbl(txtmontopagado.Text)
        End If
        If txtmontopagadod.Text.Length = 0 Then
            LETRASBE.MONTO_PAGADOD = 0
        Else
            LETRASBE.MONTO_PAGADOD = CDbl(txtmontopagadod.Text)
        End If
        If chkalm_cod.Checked Then
            LETRASBE.ALM_COD = "1"
        Else
            LETRASBE.ALM_COD = ""
        End If

        LETRASBE.SIGNO = "-"
        LETRASBE.OBSERVA = RTrim(txtobservacion.Text)
        LETRASBE.MONEDA = txtmon.Text
        LETRASBE.DIR_COD = RTrim(txtdir.Text)
        For i = 0 To dgvt_doc.Rows.Count - 1
            DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value) + DAcumula
            DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value) + DAcumula1
            DAcumula2 = Val(dgvt_doc.Rows(i).Cells("DSCTO_IMPOR").Value) + DAcumula2
            DAcumula3 = Val(dgvt_doc.Rows(i).Cells("DSCTO_DIMPOR").Value) + DAcumula3
            DAcumula4 = Val(dgvt_doc.Rows(i).Cells("IGV_IMPOR").Value) + DAcumula4
            DAcumula5 = Val(dgvt_doc.Rows(i).Cells("IGV_DIMPOR").Value) + DAcumula5
        Next
        LETRASBE.TPRECIO_VENTA = DAcumula
        LETRASBE.TPRECIO_DVENTA = DAcumula1
        LETRASBE.T_DCTO = DAcumula2
        LETRASBE.T_DCTO_DOLAR = DAcumula3
        LETRASBE.T_IGV = DAcumula4
        LETRASBE.T_IGV_DOLAR = DAcumula5
        LETRASBE.PROVEEDOR = "20100279348"
        LETRASBE.CTCT_COD = RTrim(txtctct_cod.Text)
        LETRASBE.FEC_DIA = RTrim(DateTime.Now)
        LETRASBE.NUMPEDIDO = txtoc.Text
        LETRASBE.USUARIO = RTrim(gsUser)
        LETRASBE.F_PAGO_ENT = RTrim(txtt_pago.Text)
        LETRASBE.NOM_CTCT = cmbctct_cod.Text
        LETRASBE.VENDEDOR = txtvendedor.Text
        If chkx_d.Checked Then
            LETRASBE.X_D = "1"
        Else
            LETRASBE.X_D = ""
        End If
        LETRASBE.FEC_VIGENCIA = dtpfec_vigencia.Value
        ELMVLOGSBE.log_codusu = gsCodUsr
        'LETRASBE.REG_NRO = Replace(Mid(dtpfecha.Value, 4, 7), "/", "")
        mesaño = Replace(Mid(dtpfecha.Value, 4, 7), "/", "")
        m = Mid(dtpfecha.Value, 4, 2)
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
        LETRASBE.PAG_PARCIAL = npdpag_parcial.Value
        dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year & "/" & mesfecha & "/" & mesdia)
        For Each Registro In dt.Rows
            LETRASBE.T_CAMB = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next
        'If chkz_letra.Checked Then
        '    LETRASBE.FEC_LETRA = dtpfec_letra.Text
        'End If
        'Dim dtpini As DateTime = dtpfecha.Value.AddDays(+6).ToShortDateString
        'Dim Today As DateTime = DateTime.Now.ToShortDateString
        gsError = LETRASBL.SaveRow(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvt_doc, dtgv_montos, ELTBLETRAS_MONTOBE)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'If DateTime.Compare(dtpini, Today) <= 0 Then
            'Else

            If gsUser <> "SISTEMA" Then
                Dim mes As String
                If sAño - dtpfecha.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfecha.Value.Month = "12" Then
                    If DateTime.Now.ToString("dd") > 6 Then
                        'MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Else
                    If sAño > dtpfecha.Value.Year Or sAño < dtpfecha.Value.Year Then
                        dtpfecha.Select()
                        'MsgBox("El año es mayor o menor al año actual", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    If DateTime.Now.ToString("MM") <> dtpfecha.Value.Month Then

                        If dtpfecha.Value.Month > DateTime.Now.ToString("MM") Then
                            dtpfecha.Select()
                            'MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                            Exit Sub
                        ElseIf dtpfecha.Value.Month < DateTime.Now.ToString("MM") Then
                            'If CInt(sMes1) > dtpfecha.Value.Month Then
                            mes = DateTime.Now.ToString("MM") - dtpfecha.Value.Month
                            If mes = 1 Then
                                'Modificacion de de fechas 
                                'If DateTime.Now.ToString("dd") > 14 Then
                                If DateTime.Now.ToString("dd") > 6 Then
                                    'MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                                    Exit Sub
                                End If
                            ElseIf mes > 1 Then
                                dtpfecha.Select()
                                'MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                                Exit Sub
                            End If
                            'End If
                        End If
                    End If
                    If CInt(sMes2) < dtpfecha.Value.Month Then
                        dtpfecha.Select()
                        ' MsgBox("El mes es menor al permitido", MsgBoxStyle.Information)
                        Exit Sub
                    ElseIf CInt(sMes2) > dtpfecha.Value.Month Then
                        mes = sMes2 - dtpfecha.Value.Month
                        If mes = 1 Then
                            'Modificacion de de fechas 
                            'If DateTime.Now.ToString("dd") > 14 Then
                            If DateTime.Now.ToString("dd") > 6 Then
                                'MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                                Exit Sub
                            End If
                        ElseIf mes > 1 Then
                            dtpfecha.Select()
                            'MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)

                            Exit Sub
                        End If
                    End If
                End If
            End If
            If chkz_letra.Checked = False Then
                gsError2 = LETRASBL.AsientoFC("Asiento", mesaño, m, txtnumero.Text, cmb_serdoc.Text, txtt_doc.Text, LETRASBE.EST, dgvt_doc)
                If gsError2 = "OK" Then
                    MsgBox("Asiento Creado", MsgBoxStyle.Information)
                Else
                    FormMain.LblError.Text = gsError2
                    MsgBox("Error al Grabar Asiento", MsgBoxStyle.Critical)
                End If
            End If
            'End If
            'End If
        Else
                FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


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
                Case "Print"
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = txtt_doc.Text
                    gsRptArgs(1) = cmb_serdoc.SelectedItem
                    gsRptArgs(2) = txtnumero.Text
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_DOCUMENTO_LETRA.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Case "anular"
                    If MessageBox.Show("Desea anular el documento",
                       gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If
                    Dim ELTBLETRAS_MONTOBE As New ELTBLETRAS_MONTOBE
                    Dim LETRASBE As New LETRASBE
                    Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    LETRASBE.T_DOC_REF = txtt_doc.Text
                    LETRASBE.SER_DOC_REF = cmb_serdoc.Text
                    LETRASBE.NRO_DOC_REF = txtnumero.Text


                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = LETRASBL.SaveRow(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, "AR", dgvt_doc, dtgv_montos, ELTBLETRAS_MONTOBE)


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
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = LETRASBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

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
            txtt_pago.Text = IIf(IsDBNull(Registro("F_PAGO_ENT")), "", Registro("F_PAGO_ENT"))
            cmbt_pago.SelectedValue = txtt_pago.Text
            txtmon.Text = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            cmbmon.SelectedValue = txtmon.Text
            txtvendedor.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            cmbvendedor.SelectedValue = txtvendedor.Text
            txtctct_cod.Text = IIf(IsDBNull(Registro("CTCT_COD")), "", Registro("CTCT_COD"))
            'txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            'cmbvendedor.SelectedValue = txtvendedor.Text
            txtvendedor.Text = IIf(IsDBNull(Registro("VENDEDOR")), "", Registro("VENDEDOR"))
            cmbvendedor.SelectedValue = txtvendedor.Text
            If txtmon.Text = "00" Then
                txtmontopagado.Text = IIf(IsDBNull(Registro("MONTO_PAGADO")), 0, Registro("MONTO_PAGADO"))
            ElseIf txtmon.Text = "01" Then
                txtmontopagadod.Text = IIf(IsDBNull(Registro("MONTO_PAGADOD")), 0, Registro("MONTO_PAGADOD"))
            End If
            If IIf(IsDBNull(Registro("Z_LETRA")), "", Registro("Z_LETRA")) <> "" Then
                Me.chkz_letra.Checked = True
            Else
                Me.chkz_letra.Checked = False
            End If
            If IIf(IsDBNull(Registro("ALM_COD")), "", Registro("ALM_COD")) <> "" Then
                Me.chkalm_cod.Checked = True
            Else
                Me.chkalm_cod.Checked = False
            End If
            If chkz_letra.Checked = True Then
                dtpfec_letra.Checked = True
                dtpfec_letra.Enabled = True
                dtpfec_letra.Text = IIf(IsDBNull(Registro("fec_letra")), "", Registro("fec_letra"))
            End If
            dtpfec_vigencia.Text = IIf(IsDBNull(Registro("fec_vigencia")), "", Registro("fec_vigencia"))
            npdpag_parcial.Value = IIf(IsDBNull(Registro("PAG_PARCIAL")), 0, Registro("PAG_PARCIAL"))
            If IIf(IsDBNull(Registro("est1")), "", Registro("est1")) = "T" Then
                cmbest1.SelectedIndex = 1
            ElseIf IIf(IsDBNull(Registro("est1")), "", Registro("est1")) = "N" Then
                cmbest1.SelectedIndex = 2
            End If
            If IIf(IsDBNull(Registro("x_d")), "", Registro("x_d")) <> "" Then
                chkx_d.Checked = True
            End If
            If IIf(IsDBNull(Registro("binteres")), "", Registro("binteres")) <> "" Then
                chkbinteres.Checked = True
            End If
            'Carga la direccion de acuerdo al cliente
            Dim dt As DataTable
            dt = LETRASBL.SelectDir(txtctct_cod.Text)
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
            If IIf(IsDBNull(Registro("ALM_COD")), "", Registro("ALM_COD")).ToString.Length = 0 Then

            End If
        Next
    End Sub

    Private Sub FormMantLetras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtt_doc.Select()
        bPrimero = True
        gsError = ""
        gpCaption = "Letras"
        Me.Text = gpCaption
        chkz_letra.Checked = False
        chkx_d.Checked = False
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
        'Cargar los combos
        Dim dt As DataTable = LETRASBL.SelectT_DOC("80")
        GetCmb("cod", "nom", dt, cmbt_doc)
        dt = LETRASBL.SelectF_PAGO
        GetCmb("cod", "nom", dt, cmbt_pago)
        dt = LETRASBL.SelectMoneda
        GetCmb("cod", "nom", dt, cmbmon)
        dt = LETRASBL.SelectVendedor
        GetCmb("cod", "nom", dt, cmbvendedor)
        dt = LETRASBL.SelectCliente
        GetCmb("cod", "nom", dt, cmbctct_cod)
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento")
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie")
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero")
        dgvt_doc.Columns.Add("CTCT_COD", "Cliente")
        dgvt_doc.Columns.Add("CANTIDAD", "Cantidad")
        dgvt_doc.Columns.Add("ART_COD", "Cod. Art.") '
        dgvt_doc.Columns.Add("NOM_ART", "Nom. Art.") '
        dgvt_doc.Columns.Add("MEDIDA", "Medida")
        dgvt_doc.Columns.Add("UNIDAD", "Und.")
        dgvt_doc.Columns.Add("FEC_ENT", "Hora") '
        dgvt_doc.Columns.Add("ACT_COD", "Activos") '
        dgvt_doc.Columns.Add("FEC_LLEG", "Fec.Vcto") '
        dgvt_doc.Columns.Add("PART_ACT", "P. Act.") '
        dgvt_doc.Columns.Add("ALM_COD", "Alm") '
        dgvt_doc.Columns.Add("SIGNO", "Signo")
        dgvt_doc.Columns.Add("OBSERVA", "Observa")
        dgvt_doc.Columns.Add("T_MOVINV", "T. Mov.")
        dgvt_doc.Columns.Add("TPRECIO_VENTA", "P. Venta")
        dgvt_doc.Columns.Add("TPRECIO_DVENTA", "P. Venta. D.")
        dgvt_doc.Columns.Add("IGV", "Igv")
        dgvt_doc.Columns.Add("IGV_IMPOR", "Cant. IGV")
        dgvt_doc.Columns.Add("T_CAMB", "Camb.") '22
        dgvt_doc.Columns.Add("UPRECIO_VENTA", "Pre. Venta")
        dgvt_doc.Columns.Add("UPRECIO_DVENTA", "Pre. D. Venta")
        dgvt_doc.Columns.Add("IGV_DIMPOR", "Cant. IGV D.")
        dgvt_doc.Columns.Add("MONEDA", "Moneda")
        dgvt_doc.Columns.Add("FEC_GENE", "F. Gene")
        dgvt_doc.Columns.Add("USUARIO", "Usuario")
        dgvt_doc.Columns.Add("UNIDAD", "Und") '29
        dgvt_doc.Columns.Add("F_PAGO_ENT", "F. Pago")
        dgvt_doc.Columns.Add("FOR_ENT_COD", "F. Cod. Ent")
        dgvt_doc.Columns.Add("FEC_DIA", "F. Dia")
        dgvt_doc.Columns.Add("PROVEEDOR", "Prov.")
        dgvt_doc.Columns.Add("CCO_COD", "C. Costo")
        dgvt_doc.Columns.Add("CANTIDAD", "Cant.") '35
        dgvt_doc.Columns.Add("LOTE", "Lote")
        dgvt_doc.Columns.Add("PER_COD", "Cod. Per")
        dgvt_doc.Columns.Add("NRO_DOCU1", "Nro. Docu")
        dgvt_doc.Columns.Add("MARCA", "Marca")
        dgvt_doc.Columns.Add("DSCTO", "Dscto. %")
        dgvt_doc.Columns.Add("DSCTO_IMPOR", "Dscto. S.")
        dgvt_doc.Columns.Add("DSCTO_DIMPOR", "Dscto D.")
        dgvt_doc.Columns.Add("EST", "Est.")


        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                habilitar(False)
                bTercero = "1"
                bCuarto = "1"
                btndocu.Enabled = True
                Me.txtt_doc.Text = "80"
                cmbt_doc.SelectedValue = txtt_doc.Text
                cmb_serdoc.SelectedItem = sAño
                cmbestado.SelectedIndex = 0
                txtt_pago.Text = "08"
                cmbt_pago.SelectedValue = txtt_pago.Text
                'Button1.Select()
                txtmon.Text = "00"
                cmbmon.SelectedValue = txtmon.Text
                Me.txtmon.Select()
                'Me.txtnumero.Text = "0750000"
                'cmblinea.Enabled = True
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                dgvt_doc.Columns(3).Visible = False
                'dgvt_doc.Columns(4).Visible = False
                'dgvt_doc.Columns(5).Visible = False
                dgvt_doc.Columns(6).Visible = False
                'dgvt_doc.Columns(7).Visible = False
                'dgvt_doc.Columns(12).Visible = False
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
                dgvt_doc.Columns(25).Visible = False ' T DE CAMBIO
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
            Case 1
                flagAccion = "M"
                GetData("80", sSDoc, sNDoc)
                bCuarto = "1"

                'habilitar(True)
                'cmb_serdoc.Enabled = False
                Dim dtArticulo, dtmonto As DataTable
                dtArticulo = LETRASBL.getListLT("80", sSDoc, sNDoc)
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
                dtmonto = LETRASBL.getListdgvmonto("80", sSDoc, sNDoc)
                For Each row As DataRow In dtmonto.Rows
                    dtgv_montos.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                         IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                         IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                         IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                         IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                         IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                         IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'6
                                         IIf(IsDBNull(row("NOM_PROVEE")), "", row("NOM_PROVEE")),'7
                                         IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")), '8
                                         IIf(IsDBNull(row("NOM_MONED")), "", row("NOM_MONED")),'9
                                         IIf(IsDBNull(row("MONTOS")), "", row("MONTOS")),'10
                                         IIf(IsDBNull(row("MONTOD")), "", row("MONTOD")),'11
                                         IIf(IsDBNull(row("T_CMB")), "", row("T_CMB")),'12
                                         IIf(IsDBNull(row("MONTOS_FACT")), "", row("MONTOS_FACT")),'13
                                         IIf(IsDBNull(row("MONTOD_FACT")), "", row("MONTOD_FACT"))) '14
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
                dgvt_doc.Columns(3).Visible = False
                'dgvt_doc.Columns(4).Visible = False
                'dgvt_doc.Columns(5).Visible = False
                dgvt_doc.Columns(6).Visible = False
                'dgvt_doc.Columns(7).Visible = False
                'dgvt_doc.Columns(12).Visible = False
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

        End Select
        bPrimero = False
        If chkz_letra.Checked Then
            npdpag_parcial.Enabled = True
            dtpfec_letra.Checked = True
        Else
            npdpag_parcial.Enabled = False
            dtpfec_letra.Checked = False
        End If

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


    Private Sub cmbt_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_pago.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbt_pago.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Me.dtpfec_vigencia.Value = dtpfecha.Value
        txtt_pago.Text = cmbt_pago.SelectedValue
        CantD = LETRASBL.SelectCantDias(txtt_pago.Text)
        Me.dtpfec_vigencia.Value = Me.dtpfec_vigencia.Value.Date.AddDays(CantD)
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
        dt = LETRASBL.SelectDir(txtctct_cod.Text)
        Try
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            cmbdir.SelectedValue = txtdir.Text
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
        If (txtt_doc.TextLength > 0 And cmb_serdoc.SelectedIndex <> -1 And bTercero = "1") Then
            nro = LETRASBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)
            txtnumero.Text = nro.ToString.PadLeft(7, "0")
        End If
    End Sub

#End Region

    Private Sub btnagregar_Click(sender As Object, e As EventArgs)
        If txtmon.Text = "" Then
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
        'dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
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
        dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year & "/" & mesfecha & "/" & mesdia)
        Dim frm As New FormMantDetLetras
        For Each Registro In dt.Rows
            frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next
        frm.txtigv.Text = 18

        frm.ShowDialog()
        gCliente = Nothing
    End Sub
#Region "Txt"


    Private Sub txtt_pago_LostFocus(sender As Object, e As EventArgs) Handles txtt_pago.LostFocus
        If txtt_pago.Text = "" Then
            cmbt_pago.SelectedValue = ""
            Exit Sub
        End If
        Me.dtpfec_vigencia.Value = Now.Date
        CantD = 0
        cmbt_pago.SelectedValue = txtt_pago.Text
        CantD = LETRASBL.SelectCantDias(txtt_pago.Text)
        Me.dtpfec_vigencia.Value = Me.dtpfec_vigencia.Value.Date.AddDays(CantD)
        'dtpfec_vigencia.Value = dtpfec_vigencia.Value + CantD
        If cmbt_pago.SelectedValue Is Nothing Then
            MsgBox("Tipo de pago no existe", MsgBoxStyle.Exclamation)
            txtt_pago.Text = ""
            CantD = 0
            Me.dtpfec_vigencia.Value = Now.Date
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
            cmbdir.SelectedValue = txtdir.Text
            If txtctct_cod.Text = "20100279348" Then
                cmbdir.SelectedValue = "0"
            End If

            txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            cmbvendedor.SelectedValue = txtvendedor.Text
        End If

    End Sub

    Private Sub txtctct_codr_TextChanged(sender As Object, e As EventArgs) Handles txtctct_cod.TextChanged
        Dim dt As DataTable
        If cmbctct_cod.SelectedIndex <> -1 Then
            dt = REQUERIMIENTOBL.SelectDir(txtctct_cod.Text)
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "38"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        txtctct_cod.Select()
        Dim dt As DataTable
        dt = REQUERIMIENTOBL.SelectDir(txtctct_cod.Text)
        GetCmb("dir_cod", "nom_dir", dt, cmbdir)
        cmbdir.SelectedValue = txtdir.Text

        txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
        cmbvendedor.SelectedValue = txtvendedor.Text
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        'Dim dt As DataTable
        'If dgvt_doc.Rows.Count > 0 Then
        '    Dim frm As New FormMantDetLetras
        '    gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
        '    frm.txtcodart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
        '    'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
        '    sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UNIDAD").Value
        '    'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
        '    frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
        '    frm.npdtcamb.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_CAMB").Value)
        '    frm.npduprecio_venta.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_VENTA").Value)
        '    frm.npduprecio_dventa.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("UPRECIO_DVENTA").Value)
        '    frm.txttprecio_venta.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_VENTA").Value)
        '    frm.txttprecio_dventa.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_DVENTA").Value)
        '    frm.txtdscto.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_IMPOR").Value)
        '    frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
        '    frm.txtigvimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV_IMPOR").Value)
        '    frm.txtigv_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV_DIMPOR").Value)
        '    frm.txtdscto_impor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_IMPOR").Value)
        '    frm.txtdscto_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("DSCTO_DIMPOR").Value)
        '    frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA").Value
        '    If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FEC_ENT").Value = "" Then
        '    Else
        '        frm.dtpfec_ent.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FEC_ENT").Value
        '    End If

        '    'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value) = 0 Then
        '    '    frm.txtigv.Text = 18
        '    'End If
        '    frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
        '    If frm.npduprecio_venta.Text.Length > 0 And frm.npdcantidad.Text.Length And frm.txtigv.Text > 0 Then
        '        frm.txttcompras.Text = Math.Round((frm.npduprecio_venta.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_venta.Text * frm.npdcantidad.Text, 2)
        '        frm.txttcomprad.Text = Math.Round(((frm.npduprecio_venta.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_venta.Text * frm.npdcantidad.Text) / frm.npdtcamb.Text, 2)
        '    End If
        '    If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
        '        dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
        '        For Each Registro In dt.Rows
        '            frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        '        Next
        '    End If
        '    frm.txtserie.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
        '    frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
        '    gCliente = txtctct_cod.Text
        '    'If flagAccion = "M" Then
        '    '    'frm.btnagregar.Enabled = False
        '    'ElseIf flagAccion = "N" Then
        '    '    dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
        '    '    For Each Registro In dt.Rows
        '    '        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        '    '    Next
        '    '    frm.txtigv.Text = 18
        '    'End If
        '    If flagAccion = "M" Then
        '        frm.btnagregar.Enabled = False
        '    ElseIf flagAccion = "N" Then
        '        Dim mesfecha As String
        '        Dim mesdia As String
        '        If dtpfecha.Value.Month.ToString.Length = "1" Then
        '            mesfecha = "0" & dtpfecha.Value.Month.ToString
        '        Else
        '            mesfecha = dtpfecha.Value.Month.ToString
        '        End If
        '        If dtpfecha.Value.Month.ToString.Length = "1" Then
        '            mesdia = "0" & dtpfecha.Value.Day.ToString
        '        Else
        '            mesdia = dtpfecha.Value.Day.ToString
        '        End If
        '        dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year & "/" & mesfecha & "/" & mesdia)
        '        For Each Registro In dt.Rows
        '            frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        '        Next
        '        frm.txtigv.Text = 18
        '    End If
        '    gContador = 0
        '    frm.ShowDialog()
        'Else
        '    MsgBox("No hay items en la lista para modificar")
        'End If
        Dim frm As New FormMantLetras_Monto
        frm.btnaceptar.Text = "Actualizar"
        frm.lbl01.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("T_DOC_REF1").Value
        frm.lbl02.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("SER_DOC_REF1").Value
        frm.lbl03.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
        frm.lblproveedor.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("proveedor").Value
        frm.lbl_cliente.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("Nombre_Cliente").Value
        frm.txtmon.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("MONEDA").Value
        frm.lblmon.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("NOMBRE_MONEDA").Value
        frm.txtmontos.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("MONTOS").Value
        frm.txtmontod.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("MONTOD").Value
        frm.lblmontos.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("Monto_Factura").Value
        frm.lblmontod.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("Monto_Facturad").Value
        frm.lblt_cambio.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("T_CMB").Value
        If frm.txtmon.Text = "00" Then
            frm.txtmontod.Enabled = False
        Else
            frm.txtmontos.Enabled = False
        End If
        frm.ShowDialog()
        Actualizar()
    End Sub

    Private Sub FormMantFacturacion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim frm As New FormDocuRef
        gsCode = "3"
        sOp = "5"
        Dim mesfecha As String
        Dim mesdia As String
        If dtpfecha.Value.Month.ToString.Length = "1" Then
            mesfecha = "0" & dtpfecha.Value.Month.ToString
        Else
            mesfecha = dtpfecha.Value.Month.ToString
        End If
        If dtpfecha.Value.Day.ToString.Length = "1" Then
            mesdia = dtpfecha.Value.Day.ToString.PadLeft(2, "0")
        Else
            mesdia = dtpfecha.Value.Day.ToString
        End If
        gsCode7 = dtpfecha.Value.Year & "/" & mesfecha & "/" & mesdia
        frm.ShowDialog()
        sMov = ""
        'gsCode7 = ""
        Actualizar()
        If dtgv_montos.Rows.Count > 0 Then
            chkalm_cod.Enabled = True
        End If
    End Sub

    Sub Actualizar()
        Dim totalsoles As Double = 0
        Dim totaldolar As Double = 0
        For Each row As DataGridViewRow In dtgv_montos.Rows
            If row.Cells("t_doc_ref1").Value = "07" Then
                totalsoles = totalsoles - CDbl(row.Cells("montos").Value)
                totaldolar = totaldolar - CDbl(row.Cells("montod").Value)
            Else
                totalsoles = totalsoles + CDbl(row.Cells("montos").Value)
                totaldolar = totaldolar + CDbl(row.Cells("montod").Value)
            End If
        Next
        'If txtmontopagado.Text = "" Then
        '    txtmontopagado.Text = Val(CDec(totalsoles))
        'Else
        '    txtmontopagadod.Text = Val(CDec(totaldolar))
        'End If
        If txtmon.Text = "01" Then
            txtmontopagado.Text = ""
            txtmontopagadod.Text = Val(CDec(totaldolar))
        Else
            txtmontopagadod.Text = ""
            txtmontopagado.Text = Val(CDec(totalsoles))
        End If
    End Sub

    Private Sub chkz_letra_CheckedChanged(sender As Object, e As EventArgs) Handles chkz_letra.CheckedChanged
        If chkz_letra.Checked Then
            npdpag_parcial.Enabled = True
            dtpfec_letra.Checked = True
            dtpfec_letra.Enabled = True
        Else
            npdpag_parcial.Enabled = False
            dtpfec_letra.Checked = False
            dtpfec_letra.Enabled = False
        End If
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs)
        Dim contador As Integer = 0
        Dim contador1 As Integer = 0
        Dim indice As Integer
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            For j = 0 To dgvt_doc.Rows.Count - 1
                If Mid(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(5).Value, 1, 7) = Mid(dgvt_doc.Rows(j).Cells(5).Value, 1, 7) Then
                    contador1 = contador1 + 1
                End If
            Next
            If contador1 = 1 Then
                For i = 0 To dtgv_montos.Rows.Count - 1
                    If Mid(dtgv_montos.Rows(i).Cells(5).Value, 1, 7) = Mid(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(5).Value, 1, 7) Then
                        contador = contador + 1
                        indice = i
                    End If
                Next
                dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
                dgvt_doc.Refresh()
                If contador = 1 Then
                    dtgv_montos.Rows.RemoveAt(indice)
                    dtgv_montos.Refresh()
                End If
            Else
                dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
                dgvt_doc.Refresh()
            End If

        Else
            MsgBox("No hay datos")
        End If
        If dtgv_montos.RowCount = 0 Then
            For i = 0 To dtgv_montos.Rows.Count - 1
                dtgv_montos.Rows.RemoveAt(dtgv_montos.CurrentRow.Index)
            Next
            dtgv_montos.Refresh()
        End If
    End Sub

    Private Sub dtgv_montos_DoubleClick(sender As Object, e As EventArgs) Handles dtgv_montos.DoubleClick
        Dim frm As New FormMantLetras_Monto
        frm.btnaceptar.Text = "Actualizar"
        frm.lbl01.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("T_DOC_REF1").Value
        frm.lbl02.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("SER_DOC_REF1").Value
        frm.lbl03.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
        frm.lblproveedor.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("proveedor").Value
        frm.lbl_cliente.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("Nombre_Cliente").Value
        frm.txtmon.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("MONEDA").Value
        frm.lblmon.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("NOMBRE_MONEDA").Value
        frm.txtmontos.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("MONTOS").Value
        frm.txtmontod.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("MONTOD").Value
        frm.lblmontos.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("Monto_Factura").Value
        frm.lblmontod.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("Monto_Facturad").Value
        frm.lblt_cambio.Text = dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells("T_CMB").Value
        'If frm.txtmon.Text = "00" Then
        '    frm.txtmontod.Enabled = False
        'Else
        '    frm.txtmontos.Enabled = False
        'End If
        frm.ShowDialog()
        Actualizar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnborrar1.Click
        Dim contador As Integer = 1
        Dim contador1 As Integer = 1
        If dtgv_montos.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            While contador <> 0
                contador = 0
                contador1 = 0
                For j = 0 To dgvt_doc.Rows.Count - 1
                    If Mid(dtgv_montos.Rows(dtgv_montos.CurrentRow.Index).Cells(5).Value, 1, 7) = Mid(dgvt_doc.Rows(j).Cells(5).Value, 1, 7) Then
                        'dgvt_doc.Rows.RemoveAt(j)
                        contador = contador + 1
                        contador1 = j
                    End If
                Next
                If contador <> 0 Then
                    dgvt_doc.Rows.RemoveAt(contador1)
                End If
                'contador = contador + 1
            End While
            dtgv_montos.Rows.RemoveAt(dtgv_montos.CurrentRow.Index)
            dtgv_montos.Refresh()
            If dtgv_montos.Rows.Count = 0 Then
                chkalm_cod.Enabled = False
            End If
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub txtmontopagado_LostFocus(sender As Object, e As EventArgs) Handles txtmontopagado.LostFocus
        tipo = ""
        If dtgv_montos.Rows.Count = 1 Then
            If txtmon.Text = "00" Then
                If txtmontopagado.TextLength = 0 Then
                    MsgBox("Por favor colocar un monto")
                    txtmontopagado.Select()
                Else
                    dtgv_montos.Rows(0).Cells("MONTOS").Value = txtmontopagado.Text
                    dtgv_montos.Rows(0).Cells("MONTOD").Value = "0"
                End If
            ElseIf txtmon.Text = "01" Then
                If txtmontopagadod.TextLength = 0 Then
                    MsgBox("Por favor colocar un monto")
                    txtmontopagadod.Select()
                Else
                    dtgv_montos.Rows(0).Cells("MONTOS").Value = Math.Round(txtmontopagadod.Text * dtgv_montos.Rows(0).Cells("T_CMB").Value, 2)
                    dtgv_montos.Rows(0).Cells("MONTOD").Value = txtmontopagadod.Text
                End If
            End If
        ElseIf dtgv_montos.Rows.Count > 1 Then
            If txtmon.Text = "00" Then
                For i = 1 To dtgv_montos.Rows.Count - 1
                    If dtgv_montos.Rows(i).Cells("t_doc_ref1").Value <> "07" Then
                        dtgv_montos.Rows(i).Cells("MONTOS").Value = txtmontopagado.Text - dtgv_montos.Rows(i - 1).Cells("MONTOS").Value
                        dtgv_montos.Rows(i).Cells("MONTOD").Value = "0"
                    End If
                Next
            ElseIf txtmon.Text = "01" Then
                For i = 1 To dtgv_montos.Rows.Count - 1
                    If dtgv_montos.Rows(i).Cells("t_doc_ref1").Value <> "07" Then
                        dtgv_montos.Rows(i).Cells("MONTOS").Value = Math.Round(dtgv_montos.Rows(i).Cells("MONTOD").Value * dtgv_montos.Rows(0).Cells("T_CMB").Value, 2)
                        dtgv_montos.Rows(i).Cells("MONTOD").Value = txtmontopagadod.Text - dtgv_montos.Rows(i - 1).Cells("MONTOD").Value
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub dtpfecha_Validated(sender As Object, e As EventArgs) Handles dtpfecha.Validated
        Dim mes As String
        If sAño - dtpfecha.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfecha.Value.Month = "12" Then
            If DateTime.Now.ToString("dd") > 6 Then
                MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                Exit Sub
            End If
        Else
            'If dtpfecha.Value.Month = "06" Then ' abre mes

            'Else
            If sAño > dtpfecha.Value.Year Or sAño < dtpfecha.Value.Year Then
                dtpfecha.Select()
                MsgBox("El año es mayor o menor al año actual", MsgBoxStyle.Information)
                Exit Sub
            End If

            If DateTime.Now.ToString("MM") <> dtpfecha.Value.Month Then

                If dtpfecha.Value.Month > DateTime.Now.ToString("MM") Then
                    dtpfecha.Select()
                    MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                    Exit Sub
                ElseIf dtpfecha.Value.Month < DateTime.Now.ToString("MM") Then
                    'If CInt(sMes1) > dtpfecha.Value.Month Then
                    mes = DateTime.Now.ToString("MM") - dtpfecha.Value.Month
                    If mes = 1 Then
                        'Modificacion de de fechas 
                        'If DateTime.Now.ToString("dd") > 14 Then
                        If DateTime.Now.ToString("dd") > 6 Then
                            MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                    ElseIf mes > 1 Then
                        dtpfecha.Select()
                        MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    'End If
                End If

            End If
            If CInt(sMes2) < dtpfecha.Value.Month Then
                dtpfecha.Select()
                MsgBox("El mes es menor al permitido", MsgBoxStyle.Information)
                Exit Sub
            ElseIf CInt(sMes2) > dtpfecha.Value.Month Then
                mes = sMes2 - dtpfecha.Value.Month
                If mes = 1 Then
                    'Modificacion de de fechas 
                    'If DateTime.Now.ToString("dd") > 14 Then
                    If DateTime.Now.ToString("dd") > 6 Then
                        MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                ElseIf mes > 1 Then
                    dtpfecha.Select()
                    MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If


        End If 'termina el if del mes que se abrio
        'End If

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

    Private Sub txtmontopagadod_LostFocus(sender As Object, e As EventArgs) Handles txtmontopagadod.LostFocus
        tipo = ""
        If dtgv_montos.Rows.Count = 1 Then
            If txtmon.Text = "01" Then
                If txtmontopagadod.TextLength = 0 Then
                    MsgBox("Por favor colocar un monto")
                    txtmontopagadod.Select()
                Else
                    dtgv_montos.Rows(0).Cells("MONTOS").Value = Math.Round(txtmontopagadod.Text * dtgv_montos.Rows(0).Cells("T_CMB").Value, 2)
                    dtgv_montos.Rows(0).Cells("MONTOD").Value = txtmontopagadod.Text
                End If
            ElseIf txtmon.Text = "00" Then
                If txtmontopagado.TextLength = 0 Then
                    MsgBox("Por favor colocar un monto")
                    txtmontopagado.Select()
                Else
                    dtgv_montos.Rows(0).Cells("MONTOS").Value = txtmontopagado.Text
                    dtgv_montos.Rows(0).Cells("MONTOD").Value = "0"

                End If
            End If
        ElseIf dtgv_montos.Rows.Count > 1 Then

            If txtmon.Text = "00" Then
                dtgv_montos.Rows(0).Cells("MONTOS").Value = Math.Round(dgvt_doc.Rows(0).Cells("TPRECIO_VENTA").Value * 1.18, 2)
                dtgv_montos.Rows(0).Cells("MONTOD").Value = "0"
                For i = 1 To dtgv_montos.Rows.Count - 1
                    If dtgv_montos.Rows(i).Cells("t_doc_ref1").Value <> "07" Then
                        dtgv_montos.Rows(i).Cells("MONTOS").Value = txtmontopagado.Text - dtgv_montos.Rows(i - 1).Cells("MONTOS").Value
                        dtgv_montos.Rows(i).Cells("MONTOD").Value = "0"
                    End If

                Next
            ElseIf txtmon.Text = "01" Then
                dtgv_montos.Rows(0).Cells("MONTOD").Value = Math.Round(dgvt_doc.Rows(0).Cells("TPRECIO_DVENTA").Value * 1.18, 2)
                dtgv_montos.Rows(0).Cells("MONTOS").Value = Math.Round(dtgv_montos.Rows(0).Cells("MONTOD").Value * dtgv_montos.Rows(0).Cells("T_CMB").Value, 2)
                For i = 1 To dtgv_montos.Rows.Count - 1
                    If dtgv_montos.Rows(i).Cells("t_doc_ref1").Value <> "07" Then
                        dtgv_montos.Rows(i).Cells("MONTOS").Value = Math.Round(dtgv_montos.Rows(i).Cells("MONTOD").Value * dtgv_montos.Rows(0).Cells("T_CMB").Value, 2)
                        dtgv_montos.Rows(i).Cells("MONTOD").Value = txtmontopagadod.Text - dtgv_montos.Rows(i - 1).Cells("MONTOD").Value
                    End If
                Next
            End If

        End If

    End Sub

    Private Sub chkalm_cod_CheckedChanged(sender As Object, e As EventArgs) Handles chkalm_cod.CheckedChanged
        If chkalm_cod.Checked = True Then
            txtalm_cod.Enabled = True
        Else
            txtalm_cod.Enabled = False
        End If

    End Sub

    Private Sub txtalm_cod_LostFocus(sender As Object, e As EventArgs) Handles txtalm_cod.LostFocus
        If txtalm_cod.TextLength <> 0 Then
            If txtmon.Text = "00" Then
                Actualizar()
                If txtmontopagado.TextLength <> 0 Then
                    txtmontopagado.Text = txtmontopagado.Text * txtalm_cod.Text / 100
                End If
            ElseIf txtmon.Text = "01" Then
                If txtmontopagadod.TextLength <> 0 Then
                    txtmontopagadod.Text = txtmontopagadod.Text * txtalm_cod.Text / 100
                End If
            End If
        End If
    End Sub

#End Region
End Class