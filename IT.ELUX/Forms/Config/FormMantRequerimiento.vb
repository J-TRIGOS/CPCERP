Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantRequerimiento

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private flagAccion As String = ""

    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    Private contador As Integer = 0
    Private contador2 As Integer = 0
    Private sEstado As String
    Private contador3 As Integer = 11
    Public vista As Integer = 0
    Private MenuBL As New MenuBL
    'Formulario para la creacion de ordenes de compra
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        'If bPrimero = False Then
        Try
            cmb.DataSource = dtSelect
            'If (cmbdir.Items.Count > 0) Then
            cmb.DisplayMember = sDescri

            cmb.ValueMember = sCodigo
            cmb.SelectedIndex = -1
            '    End If
            'End If
        Catch ex As Exception

        End Try



    End Function
#End Region


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
        btnadd.Enabled = est
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
            MsgBox("Ingrese el centro de costo del documento", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If txtmon.Text = "" Then
            MsgBox("Ingrese la moneda del documento", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If txtmon.Text = "" Then
            MsgBox("Ingrese la moneda del documento", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If txtt_pago.Text = "" Then
            MsgBox("Ingrese el forma de pago", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If txtt_pago.Text = "08" Then
            MsgBox("El forma de pago debe ser distinta a 08", MsgBoxStyle.Exclamation)
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
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim nro As String
        Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        If flagAccion = "N" Then
            nro = REQUERIMIENTOBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)
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

        REQUERIMIENTOBE.T_DOC_REF = RTrim(txtt_doc.Text)
        REQUERIMIENTOBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
        REQUERIMIENTOBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        REQUERIMIENTOBE.ART_COD = "07010003"
        REQUERIMIENTOBE.FEC_GENE = RTrim(dtpfecha.Value)
        If cmbestado.SelectedIndex = 0 Then
            REQUERIMIENTOBE.EST = "H"
        ElseIf cmbestado.SelectedIndex = 1 Then
            REQUERIMIENTOBE.EST = "A"
        ElseIf cmbestado.SelectedIndex = 2 Then
            REQUERIMIENTOBE.EST = "P"
        ElseIf cmbestado.SelectedIndex = 3 Then
            REQUERIMIENTOBE.EST = "T"
        ElseIf cmbestado.SelectedIndex = 4 Then
            REQUERIMIENTOBE.EST = "S"
        ElseIf cmbestado.SelectedIndex = 5 Then
            REQUERIMIENTOBE.EST = "V"
        End If
        If cmbestado.SelectedIndex = 1 Then
            REQUERIMIENTOBE.FEC_ANU = dtpfanul.Value
        End If
        REQUERIMIENTOBE.SIGNO = "+"
        REQUERIMIENTOBE.OBSERVA = RTrim(txtobservacion.Text)
        REQUERIMIENTOBE.MONEDA = txtmon.Text
        REQUERIMIENTOBE.CCO_COD = RTrim(txtc_costo.Text)
        REQUERIMIENTOBE.CTCT_COD = RTrim(txtproveedor.Text)
        REQUERIMIENTOBE.PER_COD = RTrim(txtdni.Text)
        REQUERIMIENTOBE.DIR_COD = RTrim(txtdir.Text)
        For i = 0 To dgvt_doc.Rows.Count - 1
            DAcumula = Val(dgvt_doc.Rows(i).Cells(18).Value) + DAcumula
            DAcumula1 = Val(dgvt_doc.Rows(i).Cells(19).Value) + DAcumula1
            DAcumula2 = Val(dgvt_doc.Rows(i).Cells(41).Value) + DAcumula2
            DAcumula3 = Val(dgvt_doc.Rows(i).Cells(42).Value) + DAcumula3
            DAcumula4 = Val(dgvt_doc.Rows(i).Cells(21).Value) + DAcumula4
            DAcumula5 = Val(dgvt_doc.Rows(i).Cells(25).Value) + DAcumula5
        Next
        REQUERIMIENTOBE.TPRECIO_COMPRA = DAcumula
        REQUERIMIENTOBE.TPRECIO_DCOMPRA = DAcumula1
        REQUERIMIENTOBE.T_DCTO = DAcumula2
        REQUERIMIENTOBE.T_DCTO_DOLAR = DAcumula3
        REQUERIMIENTOBE.T_IGV = DAcumula4
        REQUERIMIENTOBE.T_IGV_DOLAR = DAcumula5
        REQUERIMIENTOBE.PROVEEDOR = "20100279348"
        REQUERIMIENTOBE.PER_COD = RTrim(txtdni.Text)
        REQUERIMIENTOBE.FEC_DIA = RTrim(DateTime.Now)
        REQUERIMIENTOBE.USUARIO = RTrim(gsUser)
        REQUERIMIENTOBE.F_PAGO_ENT = RTrim(txtt_pago.Text)
        REQUERIMIENTOBE.FOR_ENT_COD = RTrim(txtfor_ent.Text)
        'Dim ELTBESPEBE As New ELTBESPEBE
        'gsError2 = ELTBESPEBL.SaveRow(ELTBESPEBE, flagAccion, dgvt_doc, txtartcodigo.Text, cmbcatalogo.SelectedValue)

        'Dim ELTBCOMPBE As New ELTBCOMPBE
        'gsError3 = ELTBCOMPBL.SaveRow(ELTBCOMPBE, flagAccion, dgvt_doc, txtartcodigo.Text)
        ELMVLOGSBE.log_codigo = gsCodUsr
        gsError = REQUERIMIENTOBL.SaveRow(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvt_doc, cmb_serdoc.Text)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'Dispose()
            If flagAccion = "N" Then
                tsbGrabar.Enabled = False
                flagAccion = "M"
            End If
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
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
            'Case "delete"
            '    DeleteData()

            Case "exit"
                Dispose()
                Exit Sub
            Case "Print"
                gsRptArgs = {}
                ReDim gsRptArgs(2)
                gsRptArgs(0) = cmbt_doc.SelectedValue
                gsRptArgs(1) = cmb_serdoc.SelectedItem
                gsRptArgs(2) = txtnumero.Text
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_OREQ.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
        End Select
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = REQUERIMIENTOBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmbt_doc.SelectedValue = txtt_doc.Text
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            txtporcentaje.Text = IIf(IsDBNull(Registro("PORCENTAJE")), 0, Registro("PORCENTAJE"))
            If IIf(IsDBNull(Registro("BAR_COD")), "", Registro("BAR_COD")) <> "" Then
                chkbar_cod.Checked = False
            End If
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
            txtdir.Text = IIf(IsDBNull(Registro("DIR_COD")), "", Registro("DIR_COD"))
            cmbdir.SelectedValue = txtdir.Text
            cmbturno.Text = IIf(IsDBNull(Registro("TURNO")), "", Registro("TURNO"))
            txtobservacion.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txttprecio_compra.Text = IIf(IsDBNull(Registro("tprecio_compra")), "", Registro("tprecio_compra"))
            txttprecio_dcompra.Text = IIf(IsDBNull(Registro("tprecio_dcompra")), "", Registro("tprecio_dcompra"))
            txtt_dcto.Text = IIf(IsDBNull(Registro("T_DCTO")), "", Registro("T_DCTO"))
            txtt_dcto_dolar.Text = IIf(IsDBNull(Registro("T_DCTO_DOLAR")), "", Registro("T_DCTO_DOLAR"))
            txtt_igv.Text = IIf(IsDBNull(Registro("T_IGV")), "", Registro("T_IGV"))
            txtt_igv_dolar.Text = IIf(IsDBNull(Registro("T_IGV_DOLAR")), "", Registro("T_IGV_DOLAR"))
            If txttprecio_compra.TextLength > 0 And txtt_igv.TextLength > 0 And txtt_dcto.TextLength > 0 Then
                txttcompras.Text = CDbl(txttprecio_compra.Text) + CDbl(txtt_igv.Text) - CDbl(txtt_dcto.Text)
                txttcomprad.Text = CDbl(txttprecio_dcompra.Text) + CDbl(txtt_igv_dolar.Text) - CDbl(txtt_dcto_dolar.Text)
            Else
                txttcompras.Text = 0
                txttcomprad.Text = 0
            End If
        Next
    End Sub

    Private Sub FormMantRequerimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtt_doc.Select()
        bPrimero = True
        gsError = ""
        gpCaption = "Orden de Compra"
        Me.Text = gpCaption

        'Cargar los combos
        Dim dt As DataTable = REQUERIMIENTOBL.SelectT_DOC("OREQ")
        GetCmb("cod", "nom", dt, cmbt_doc)
        dt = REQUERIMIENTOBL.SelectT_MOVINV2("OREQ")
        GetCmb("cod", "nom", dt, cmbt_movinv)
        dt = REQUERIMIENTOBL.SelectF_PAGO
        GetCmb("cod", "nom", dt, cmbt_pago)
        dt = REQUERIMIENTOBL.SelectF_ENT
        GetCmb("cod", "nom", dt, cmbfor_ent)
        dt = REQUERIMIENTOBL.SelectMoneda
        GetCmb("cod", "nom", dt, cmbmon)
        cmbmon.SelectedIndex = 1
        txtmon.Text = "01"
        dt = REQUERIMIENTOBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = REQUERIMIENTOBL.SelectPer
        GetCmb("cod", "nombre", dt, cmbdni)
        dt = REQUERIMIENTOBL.SelectProv
        GetCmb("cod", "nom", dt, cmbproveedor)
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero") '5
        dgvt_doc.Columns.Add("CTCT_COD", "Cliente") '6
        dgvt_doc.Columns.Add("CANTIDAD", "Cantidad") '7
        'dgvt_doc.Columns(3).Visible = False
        'dgvt_doc.Columns(4).Visible = False
        'dgvt_doc.Columns(5).Visible = False
        dgvt_doc.Columns.Add("ART_COD", "Cod. Art.") '8
        dgvt_doc.Columns.Add("NOM_ART", "Nom. Art.") '9
        dgvt_doc.Columns.Add("FEC_ENT", "Hora") '10
        dgvt_doc.Columns.Add("ACT_COD", "Activos") '11
        dgvt_doc.Columns.Add("FEC_LLEG", "Fec.Vcto") '12
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
        dgvt_doc.Columns.Add("EST", "EST") '43
        dgvt_doc.Columns.Add("REQ_APROB", "cerrado") '44
        dgvt_doc.Columns.Add("ART_VENTA", "Activo 1") '45
        dgvt_doc.Columns.Add("EST_BOR", "BORRAR") '46

        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                habilitar(False)
                bTercero = "1"
                bCuarto = "1"
                Me.txtt_doc.Text = "OREQ"

                'Me.txtnumero.Text = "0750000"
                'cmblinea.Enabled = True
            Case 1
                flagAccion = "M"
                GetData("OREQ", sSDoc, sNDoc)
                bCuarto = "1"
                cmb_serdoc.Enabled = False
                Dim dtArticulo As DataTable
                dtArticulo = REQUERIMIENTOBL.getListdgv("OREQ", sSDoc, sNDoc)
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
                                          IIf(IsDBNull(row("FEC_ENT")), "", row("FEC_ENT")),'10
                                          IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")),'11
                                          IIf(IsDBNull(row("FEC_LLEG")), "", row("FEC_LLEG")),'12
                                          IIf(IsDBNull(row("PART_ACT")), "", row("PART_ACT")),'13
                                          IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),'14
                                          IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),'15
                                          IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),'16
                                          IIf(IsDBNull(row("T_MOVINV")), "", row("T_MOVINV")),'17
                                          IIf(IsDBNull(row("TPRECIO_COMPRA")), "", row("TPRECIO_COMPRA")),'18
                                          IIf(IsDBNull(row("TPRECIO_DCOMPRA")), "", row("TPRECIO_DCOMPRA")),'19
                                          IIf(IsDBNull(row("IGV")), "", row("IGV")),'20
                                          IIf(IsDBNull(row("IGV_IMPOR")), "", row("IGV_IMPOR")),'21
                                          IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),'22
                                          IIf(IsDBNull(row("UPRECIO_COMPRA")), "", row("UPRECIO_COMPRA")),'23
                                          IIf(IsDBNull(row("UPRECIO_DCOMPRA")), "", row("UPRECIO_DCOMPRA")),'24
                                          IIf(IsDBNull(row("IGV_DIMPOR")), "", row("IGV_DIMPOR")),'25
                                          IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),'26
                                          IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),'27
                                          IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),'28
                                          IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),'29
                                          IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")),'30
                                          IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),'31
                                          IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")),'32
                                          IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'33
                                          IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),'34
                                          IIf(IsDBNull(row("CANTIDAD1")), "", row("CANTIDAD1")),'35
                                          IIf(IsDBNull(row("LOTE")), "", row("LOTE")),'36
                                          IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),'37
                                          IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")),'38
                                          IIf(IsDBNull(row("MARCA")), "", row("MARCA")),'39
                                          IIf(IsDBNull(row("DSCTO")), "", row("DSCTO")),'40
                                          IIf(IsDBNull(row("DSCTO_IMPOR")), "", row("DSCTO_IMPOR")),'41
                                          IIf(IsDBNull(row("DSCTO_DIMPOR")), "", row("DSCTO_DIMPOR")),'42
                                          IIf(IsDBNull(row("EST")), "", row("EST")), '43 
                                          IIf(IsDBNull(row("REQ_APROB")), "", row("REQ_APROB")), '44
                                          IIf(IsDBNull(row("ART_VENTA")), "", row("ART_VENTA")), ',45
                                          "H") '46
                    'IIf(IsDBNull(row("REQ_APROB")), "", row("REQ_APROB")) '44
                    'contador3 = contador3 + 1
                Next
                Dim i As Integer
                For i = 0 To 43
                    dgvt_doc.Columns(i).ReadOnly = True
                Next
                Try
                    dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(3)
                Catch ex As Exception
                    MsgBox("No hay datos en el detalle")
                End Try
                Me.btnborrar.Enabled = False
                Me.btndocu.Enabled = False
                Me.btnagregar.Enabled = False
                Me.btnadd.Enabled = True

        End Select

        'T_DOC_REF, SER_DOC_REF, NRO_DOC_REF, ART_COD, F_NOM_ART(ART_COD)NOM_ART, FEC_ENT,
        '   FEC_LLEG, ACT_COD, ACT_COD1, PART_ACT, ALM_COD, CTCT_COD
        dgvt_doc.Columns(0).Visible = False
        dgvt_doc.Columns(1).Visible = False
        dgvt_doc.Columns(2).Visible = False
        'dgvt_doc.Columns(3).Visible = False
        'dgvt_doc.Columns(4).Visible = False
        'dgvt_doc.Columns(5).Visible = False
        dgvt_doc.Columns(6).Visible = False
        'dgvt_doc.Columns(7).Visible = False
        'dgvt_doc.Columns(12).Visible = False
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
        'dgvt_doc.Columns(45).Visible = False
        dgvt_doc.Columns(46).Visible = False
        bPrimero = False


        If vista = 1 And flagAccion = "N" Then
            Dispose()
        ElseIf vista = 1 Then
            tsbGrabar.Visible = False
        End If

    End Sub

    Private Sub txtproveedor_TextChanged(sender As Object, e As EventArgs) Handles txtproveedor.TextChanged
        Dim dt As DataTable
        If cmbproveedor.SelectedIndex <> -1 Then
            dt = REQUERIMIENTOBL.SelectDir(txtproveedor.Text)
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
        End If

    End Sub

    Private Sub txtproveedor_Validated(sender As Object, e As EventArgs) Handles txtproveedor.Validated
        Dim dt As DataTable
        If cmbproveedor.SelectedIndex <> -1 Then
            dt = REQUERIMIENTOBL.SelectDir(txtproveedor.Text)
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
        Else
            cmbt_movinv.SelectedValue = txtt_movinv.Text
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        sFecCom = dtpfecha.Value
        Dim frm As New FormMantDetRequerimiento
        'if dgvt_doc.CurrentCell.
        If cmbmon.SelectedIndex <> -1 Then

            If cmbmon.SelectedValue = "00" Then
                frm.npduprecio_dcompra.Enabled = False
            Else
                frm.npduprecio_compra.Enabled = False
            End If
            frm.txtigv.Text = 7
            gContador = 1
            frm.bFecha = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FEC_GENE").Value
            frm.ShowDialog()
        Else
            MsgBox("Seleccione un tipo de Cambio")
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
                cmb_serdoc.SelectedIndex = 0
                cmbestado.SelectedIndex = 0
                'cmbt_movinv.SelectedIndex = 2
                'txtt_pago.Text = "08"
                txtfor_ent.Text = "09"
                'txtnumero.Text = ARTICULOBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
            End If

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

    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo.SelectedValue = txtc_costo.Text
        If cmbc_costo.SelectedValue Is Nothing Then
            MsgBox("Centro de costo no existe", MsgBoxStyle.Exclamation)
            txtc_costo.Text = ""
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
        End If
    End Sub

    Private Sub FormMantRequerimiento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim dt As DataTable
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormMantDetRequerimiento
            gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(8).Value
            frm.txtcodart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(8).Value
            'frm.txtnomart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(9).Value
            sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
            'frm.cmbuni.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
            frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(7).Value
            frm.txtlote.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(36).Value
            frm.txtmarca.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(39).Value
            frm.npdtcamb.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value)
            frm.npduprecio_compra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(23).Value)
            frm.npduprecio_dcompra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(24).Value)
            frm.txttprecio_compra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(18).Value)
            frm.txttprecio_dcompra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(19).Value)
            frm.txtdscto.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(41).Value)
            frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(20).Value)
            frm.txtigvimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(21).Value)
            frm.txtigv_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(25).Value)
            frm.txtdscto_impor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(41).Value)
            frm.txtdscto_dimpor.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(42).Value)
            frm.txttprecio_compra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(18).Value)
            frm.txttprecio_dcompra.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(19).Value)
            frm.txtdscto.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(40).Value)
            frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(11).Value = Nothing Then
                frm.bFecha = Format(CDate(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FEC_GENE").Value), "dd/MM/yyyy")
                frm.txtactivo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("art_venta").Value
            Else
                frm.txtactivo.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(11).Value
                frm.cmbactivo.Text = frm.txtactivo.Text
            End If
            If chkbar_cod.Checked = True Then
                frm.txtigv.Text = 0
            Else
                If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(20).Value) = 0 Then
                    frm.txtigv.Text = 7
                End If
            End If

            If frm.npduprecio_compra.Text.Length > 0 And frm.npdcantidad.Text.Length And frm.txtigv.Text > 0 Then
                frm.txttcompras.Text = (frm.npduprecio_compra.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_compra.Text * frm.npdcantidad.Text
                frm.txttcomprad.Text = ((frm.npduprecio_compra.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_compra.Text * frm.npdcantidad.Text) / frm.npdtcamb.Text
            End If
            If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
                dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                For Each Registro In dt.Rows
                    frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
                Next
            End If

            If flagAccion = "M" Then
                'frm.btnagregar.Enabled = False
            ElseIf flagAccion = "N" Then
                dt = REQUERIMIENTOBL.getT_CAMB(sFecha)

                For Each Registro In dt.Rows
                    frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "0", Registro("VENTA"))
                Next
                'frm.txtigv.Text = 7
            End If
            gContador = 0
            frm.bFecha = Format(CDate(dgvt_doc.CurrentRow.Cells(27).Value.ToString()), "yyyy/MM/dd") 'dtpfecha.Value

            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If

    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim frm As New FormDocuRef
        gsCode = "1"
        frm.ShowDialog()
        gsCode = ""
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If contador2 = dgvt_doc.Rows.Count - contador3 Or flagAccion = "N" Or dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(46).Value = "P" Then
            If dgvt_doc.RowCount > 0 Then
                If MessageBox.Show("Esta seguro de Eliminar el Registro",
                               gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                    Exit Sub
                End If
                If flagAccion = "M" Then
                    If contador2 >= dgvt_doc.CurrentRow.Index + 1 Then
                        MsgBox("Por favor seleccione otro item, este item no se puede borrar")
                    Else
                        contador3 = contador3 - 1
                        dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
                        dgvt_doc.Refresh()
                    End If
                Else
                    dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
                    dgvt_doc.Refresh()
                End If


            Else
                MsgBox("No hay datos")
            End If
        Else
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

    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
    End Sub

    Private Sub cmbproveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproveedor.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbproveedor.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Dim dt As DataTable
        txtproveedor.Text = cmbproveedor.SelectedValue
        dt = REQUERIMIENTOBL.SelectDir(txtproveedor.Text)
        Try
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
        Catch ex As Exception

        End Try


        If cmbdir.Items.Count > 0 Then
            If txtproveedor.Text = "20100279348" Then
                cmbdir.SelectedIndex = 1
            Else
                cmbdir.SelectedIndex = 0
            End If

        End If

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
        If cmbdir.SelectedIndex <> -1 Then
            txtdir.Text = cmbdir.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        If bTercero = "0" Then
            Exit Sub
        End If
        Dim nro As String
        'txtnumero.Enabled = False
        If (txtt_doc.TextLength > 0 And cmb_serdoc.SelectedIndex <> -1 And bTercero = "1") Then
            nro = REQUERIMIENTOBL.SelectNro2(txtt_doc.Text, cmb_serdoc.SelectedItem)
            txtnumero.Text = nro.PadLeft(7, "0")


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "4"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim dt As DataTable
        Dim cmb As Double
        Dim ser As String
        Dim nro As String
        Dim tipo As String
        dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
        contador = contador + 1
        For Each Registro In dt.Rows
            cmb = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next
        If dgvt_doc.Rows.Count > 0 Then
            tipo = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(3).Value
            ser = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(4).Value
            nro = Mid(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(5).Value, 1, 7)
            If contador = 1 Then
                contador2 = dgvt_doc.Rows.Count
            End If
        Else
            tipo = txtt_doc.Text
            ser = cmb_serdoc.Text
            nro = txtnumero.Text
        End If

        Dim sValor As String = ARTICULOBL.SelectArt2("05990074")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "05990074", sValor, Nothing, '10
                                                                  "", "", "", "", "+", txtobservacion.Text, '16
                                                                  txtt_movinv.Text, '17
                                                                  txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                  "18", 0, cmb,
                                                                  0, 0, 0, txtmon.Text,  '26
                                                                  dtpfecha.Text, '27
                                                                  gsUser, "SERV", txtt_pago.Text, '30
                                                                  txtfor_ent.Text,'31
                                                                  RTrim(DateTime.Now), "20100279348", '33
                                                                  txtc_costo.Text, "", '35
                                                                  "", txtdni.Text, '37
                                                                  "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("05990784")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "05990784", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "SERV", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("07010078")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "07010078", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "SERV", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("07010071")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "07010071", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "SERV", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("07011502")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "07011502", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "SERV", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("07010046")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "07010046", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "SERV", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("07010047")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "07010047", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "SERV", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("07010049")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "07010049", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "SERV", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("07011947")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "07011947", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "SERV", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("07010023")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "07010023", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "HORA", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("07012437")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "07012437", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "SERV", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        sValor = ARTICULOBL.SelectArt2("07090002")
        dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, tipo, ser, nro, txtproveedor.Text, 1, "07090002", sValor, Nothing, '10
                                                                 "", "", "", "", "+", txtobservacion.Text, '16
                                                                 txtt_movinv.Text, '17
                                                                 txttprecio_compra.Text, txttprecio_dcompra.Text, '19
                                                                 "18", 0, cmb,
                                                                 0, 0, 0, txtmon.Text,  '26
                                                                 dtpfecha.Text, '27
                                                                 gsUser, "SERV", txtt_pago.Text, '30
                                                                 txtfor_ent.Text,'31
                                                                 RTrim(DateTime.Now), "20100279348", '33
                                                                 txtc_costo.Text, "", '35
                                                                 "", txtdni.Text, '37
                                                                 "0", "", 0, 0, 0, cmbestado.Text, "", "", "P") '43
        If contador = 1 Then
            btnborrar.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

#End Region
End Class