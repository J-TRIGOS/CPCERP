Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.Net.Mail
Public Class FormMantELTBPROGPAGO
    Dim ELTBPROGPAGOBL As New ELTBPROGPAGOBL
    Dim FORMA_PAGOBL As New FORMA_PAGOBL
    ' Dim ELTBPROGPAGOBE As New ELTBPROGPAGOBE
    Dim PROVISIONESBL As New PROVISIONESBL
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    'Private FACTURACIONBL As New FACTURACIONBL
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
    Private Anulacion As String
    Public mespago As String
    Private Sub CleanVar()
        txtt_doc.Clear()
        cmb_serdoc.SelectedIndex = -1
        txtnumero.Clear()
        cmbestado.SelectedIndex = -1
        dtpfanul.Checked = False
        txtnumero.Clear()
    End Sub
    Public Sub habilitar(ByVal est As Boolean)
        btnagregar.Enabled = est
        btnmodificar.Enabled = est
        btndocu.Enabled = est
        btnborrar.Enabled = est
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = ELTBPROGPAGOBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)
        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            txtt_ope.Text = IIf(IsDBNull(Registro("T_OPE")), "", Registro("T_OPE"))
            cmb_serdoc.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            Select Case Registro("EST").ToString
                Case ""
                    cmbestado.SelectedIndex = -1
                Case "H"
                    cmbestado.SelectedIndex = 0
                Case "A"
                    cmbestado.SelectedIndex = 1
            End Select
            'cmb_serdoc.SelectedIndex = 0
            txtcbco.Text = IIf(IsDBNull(Registro("COD_CBCO")), "", Registro("COD_CBCO"))
            cmb_ccbco.SelectedValue = IIf(IsDBNull(Registro("COD_CBCO")), "", Registro("COD_CBCO"))
            txtmon.Text = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            cmb_mon.SelectedValue = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            If Trim(If(IsDBNull(Registro("EST_COBRA")), "", Registro("EST_COBRA"))) = "C" Then
                cmb_cobra.SelectedIndex = 0
            ElseIf Trim(If(IsDBNull(Registro("EST_COBRA")), "", Registro("EST_COBRA"))) = "NC" Then
                cmb_cobra.SelectedIndex = 1
            ElseIf Trim(If(IsDBNull(Registro("EST_COBRA")), "", Registro("EST_COBRA"))) = "LA" Then
                cmb_cobra.SelectedIndex = 2
            ElseIf Trim(If(IsDBNull(Registro("EST_COBRA")), "", Registro("EST_COBRA"))) = "LL" Then
                cmb_cobra.SelectedIndex = 3
            ElseIf Trim(If(IsDBNull(Registro("EST_COBRA")), "", Registro("EST_COBRA"))) = "LG" Then
                cmb_cobra.SelectedIndex = 4
            ElseIf Trim(If(IsDBNull(Registro("EST_COBRA")), "", Registro("EST_COBRA"))) = "LP" Then
                cmb_cobra.SelectedIndex = 5
            ElseIf Trim(If(IsDBNull(Registro("EST_COBRA")), "", Registro("EST_COBRA"))) = "LR" Then
                cmb_cobra.SelectedIndex = 6
            ElseIf Trim(If(IsDBNull(Registro("EST_COBRA")), "", Registro("EST_COBRA"))) = "AE" Then
                cmb_cobra.SelectedIndex = 7
            ElseIf Trim(If(IsDBNull(Registro("EST_COBRA")), "", Registro("EST_COBRA"))) = "PP" Then
                cmb_cobra.SelectedIndex = 8
            End If
            If Trim(If(IsDBNull(Registro("EXT_BANC")), "", Registro("EXT_BANC"))) = "C" Then
                cmb_ext_bank.SelectedIndex = 0
            ElseIf Trim(If(IsDBNull(Registro("EXT_BANC")), "", Registro("EXT_BANC"))) = "P" Then
                cmb_ext_bank.SelectedIndex = 1
            End If
            If cmbestado.SelectedIndex = 1 Then
                dtpfanul.Checked = True
                dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            End If
            txtnro_ope.Text = IIf(IsDBNull(Registro("NRO_DOCU1")), "", Registro("NRO_DOCU1"))
            'cmb_cobra.SelectedValue = IIf(IsDBNull(Registro("MONEDA")), "", Registro("MONEDA"))
            txtctct_cod.Text = If(IsDBNull(Registro("PROVEEDOR")), "", Registro("PROVEEDOR"))
            cmb_ctct_cod.SelectedValue = If(IsDBNull(Registro("PROVEEDOR")), "", Registro("PROVEEDOR"))
            txtobservacion.Text = If(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txtact_flujo.Text = If(IsDBNull(Registro("ACT_FLUJO")), "", Registro("ACT_FLUJO"))
            cmb_activ_flujo.SelectedValue = If(IsDBNull(Registro("ACT_FLUJO")), "", Registro("ACT_FLUJO"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_PROG")), "", Registro("FEC_PROG"))
            txtflujo_caja.Text = IIf(IsDBNull(Registro("FLUJO_CAJA")), "", Registro("FLUJO_CAJA"))
            cmb_flujo_caja.SelectedValue = IIf(IsDBNull(Registro("FLUJO_CAJA")), "", Registro("FLUJO_CAJA"))
            dtpfec_prov.Text = IIf(IsDBNull(Registro("FEC_PROG")), "", Registro("FEC_PROG"))
            txtnro_cheque.Text = IIf(IsDBNull(Registro("NRO_DOCU")), "", Registro("NRO_DOCU"))
            txttprecio_compra.Text = IIf(IsDBNull(Registro("TPRECIO_COMPRA")), "", Registro("TPRECIO_COMPRA"))
            txttprecio_dcompra.Text = IIf(IsDBNull(Registro("TPRECIO_DCOMPRA")), "", Registro("TPRECIO_DCOMPRA"))
            txtt_igv.Text = IIf(IsDBNull(Registro("T_IGV")), "", Registro("T_IGV"))
            txtt_igv_dolar.Text = IIf(IsDBNull(Registro("T_IGV_DOLAR")), "", Registro("T_IGV_DOLAR"))
        Next
    End Sub
    Private Sub FormMantELTBPROGPAGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpCaption = "Cheques Pago"
        Me.Text = gpCaption
        bPrimero = True
        dgvt_doc.Columns.Add("T_DOC_REF", "DOCUMENTO")              ' 0      
        dgvt_doc.Columns.Add("STATUS", "AFECTO")                    ' 1      
        dgvt_doc.Columns.Add("SER_DOC_REF", "SERIE")                ' 2      
        dgvt_doc.Columns.Add("NRO_DOC_REF", "NRO.DOC")              ' 3
        dgvt_doc.Columns.Add("T_DOC_REF1", "DOCUMENTO")             ' 4      
        dgvt_doc.Columns.Add("SER_DOC_REF1", "SERIE")               ' 5      
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "NRO.DOC")             ' 6    
        dgvt_doc.Columns.Add("CTA_CBCO", "CUENTA")                  ' 7      
        dgvt_doc.Columns.Add("CTA_COD_DEST", "CUENTA.DEST")         ' 8      
        dgvt_doc.Columns.Add("PROVEEDOR", "PROVEEDOR")              ' 9      
        dgvt_doc.Columns.Add("SIGNO", "SIG")                        ' 10      
        dgvt_doc.Columns.Add("FEC_GENE", "FECHA")                   ' 11     
        dgvt_doc.Columns.Add("T_CMB", "T.CAMB")                     ' 12     
        dgvt_doc.Columns.Add("MONEDA", "MON")                       ' 13     
        dgvt_doc.Columns.Add("T_IGV", "IGV")                        ' 14     
        dgvt_doc.Columns.Add("T_IGV_DOLAR", "IGV.DOLAR")            ' 15     
        dgvt_doc.Columns.Add("TPRECIO_COMPRA", "P.COMPRA")          ' 16     
        dgvt_doc.Columns.Add("TPRECIO_DCOMPRA", "P.D.COMPRA")       ' 17     
        dgvt_doc.Columns.Add("OBSERVA", "OBSERVACION")              ' 18     
        dgvt_doc.Columns.Add("X_RET", "RETENCION")                  ' 19     
        dgvt_doc.Columns.Add("F_PAGO_ENT", "FORMA PAGO")            ' 20     
        dgvt_doc.Columns.Add("T_OPE", "T.OPE")                      ' 21     
        dgvt_doc.Columns.Add("USUARIO", "USUARIO")                  ' 22     
        dgvt_doc.Columns.Add("CCO_COD", "CENTRO DE COSTO")          ' 23
        dgvt_doc.Columns.Add("RETEN", "RETENCIONES")                ' 24
        dgvt_doc.Columns.Add("REG_NRO", "REG_NRO")                  ' 25
        dgvt_doc.Columns.Add("FEC_VEN", "FEC.VEN")                  ' 26 
        dgvt_doc.Columns.Add("OBSERVA2", "OBSERVACION MODIFICADO")  ' 27     
        dgvt_doc.Columns.Add("MONTO_PAGADO", "MONTO PAGAR")         ' 28
        dgvt_doc.Columns.Add("MONTO_DPAGADO", "MONTO PAGAR DOLAR")  ' 29
        dgvt_doc.Columns.Add("CUENTITA", "CUENTITA")                ' 30
        dgvt_doc.Columns.Add("NUEVO", "NUEVO")                      ' 31

        Dim dt As DataTable = ELTBPROGPAGOBL.SelectT_DOC("01")
        dt = ELTBPROGPAGOBL.SelectMoneda
        GetCmb("cod", "nom", dt, cmb_mon)
        dt = ELTBPROGPAGOBL.SelectCliente
        GetCmb("cod", "nom", dt, cmb_ctct_cod)
        dt = ELTBPROGPAGOBL.SelectBanco
        GetCmb("cod", "nom", dt, cmb_ccbco)
        dt = ELTBPROGPAGOBL.SelectAct_flujo
        GetCmb("cod", "nom", dt, cmb_activ_flujo)

        Select Case gnOpcion
            Case 0 'Nuevo
                'txtt_doc.Select()
                flagAccion = "N"
                gsError = ""
                CleanVar()
                'habilitar(False)
                txtt_doc.Text = "PPAG"
                'Me.cmb_serdoc.Items.Add(DateTime.Now.ToString("yyyy"))
                cmb_serdoc.Text = DateTime.Now.ToString("yyyy")
                dt = ELTBPROGPAGOBL.SelectT_OPE(cmb_serdoc.SelectedItem)
                GetCmb("cod", "nom", dt, cmbt_ope)
                cmbt_doc.SelectedIndex = 0 'txtt_doc.Text
                cmbestado.SelectedIndex = 0
                cmb_ccbco.SelectedIndex = -1
                cmbt_ope.SelectedIndex = 0
                txtt_ope.Text = cmbt_ope.SelectedValue.ToString()
                cmb_cobra.SelectedIndex = 1
                btncliente.Select()
                txtmon.Text = "01"
                cmb_ext_bank.SelectedIndex = 1
                txtflujo_caja.ReadOnly = True
                cmb_flujo_caja.Enabled = False
                cmb_mon.SelectedIndex = 1
                txtctct_cod.Text = ""
                txtcbco.ReadOnly = True
                txtmon.ReadOnly = True
                txtnumero.Text = ELTBPROGPAGOBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem, mespago)

                Me.txtmon.Select()

                dgvt_doc.Columns(25).Visible = False
                dgvt_doc.Columns(26).Visible = False
                dgvt_doc.Columns(27).Visible = False
                dgvt_doc.Columns(28).Visible = False
                dgvt_doc.Columns(29).Visible = False
                'dgvt_doc.Columns(30).Visible = False
                ''dgvt_doc.Columns(22).Visible = False
                Anulacion = "0"



            Case 1 'modificar
                GetData(sTDoc, sSDoc, sNDoc)
                dt = ELTBPROGPAGOBL.SelectT_OPE(cmb_serdoc.SelectedItem)
                flagAccion = "M"
                GetCmb("cod", "nom", dt, cmbt_ope)
                Dim dtArticulo As DataTable
                Dim status As String
                cmbt_ope.SelectedIndex = 0
                cmbt_doc.SelectedIndex = 0
                dtArticulo = ELTBPROGPAGOBL.getListdgv1("PPAG", sSDoc, sNDoc)
                For Each row As DataRow In dtArticulo.Rows
                    If IIf(IsDBNull(row("STATUS")), "", row("STATUS")) = "S" Then
                        status = "AFECTO"
                    Else
                        status = "INAFECTO"
                    End If

                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      status,'1
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'2
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'3
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'4
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'5
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'6
                                      IIf(IsDBNull(row("CUENTA")), "", row("CUENTA")),'7
                                      IIf(IsDBNull(row("CUENTA_DEST")), "", row("CUENTA_DEST")),'8
                                      IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'9
                                      IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),'10
                                      IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")), '11
                                      IIf(IsDBNull(row("T_CMB")), "", row("T_CMB")), '12
                                      IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),'13
                                      IIf(IsDBNull(row("T_IGV")), "", row("T_IGV")),'14
                                      IIf(IsDBNull(row("T_IGV_DOLAR")), "", row("T_IGV_DOLAR")),'15
                                      IIf(IsDBNull(row("TPRECIO_COMPRA")), "", row("TPRECIO_COMPRA")),'16
                                      IIf(IsDBNull(row("TPRECIO_DCOMPRA")), "", row("TPRECIO_DCOMPRA")),'17
                                      IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),'18
                                      IIf(IsDBNull(row("X_RET")), "", row("X_RET")),'19
                                      IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")),'20
                                      IIf(IsDBNull(row("T_OPE_COD")), "", row("T_OPE_COD")),'21
                                      IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),'22
                                      IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),'23
                                      IIf(IsDBNull(row("RETEN")), "", row("RETEN")),'24
                                      IIf(IsDBNull(row("REG_NRO")), "", row("REG_NRO")),'25
                                      IIf(IsDBNull(row("FEC_VEN")), "", row("FEC_VEN")),'26
                                      IIf(IsDBNull(row("OBSERVA2")), "", row("OBSERVA2")),'27
                                      IIf(IsDBNull(row("MONTO_PAGO")), "", row("MONTO_PAGO")),'28
                                      IIf(IsDBNull(row("MONTO_DPAGO")), "", row("MONTO_DPAGO")),'29
                                      IIf(IsDBNull(row("CUENTITA")), "", row("CUENTITA")),'30
                                      IIf(IsDBNull(row("NUEVO")), "", row("NUEVO"))) '31

                Next
        End Select
        bPrimero = False
    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
#Disable Warning BC42105 ' La función 'GetCmb' no devuelve un valor en todas las rutas de acceso de código. Puede producirse una excepción de referencia NULL en tiempo de ejecución cuando se use el resultado.
    End Function
#Region "Valor Combo"
    Private Sub cmbmon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mon.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmb_mon.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtmon.Text = cmb_mon.SelectedValue.ToString()
    End Sub

    Private Sub cmbctct_cod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ctct_cod.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmb_ctct_cod.SelectedIndex <> -1 Then
            txtctct_cod.Text = cmb_ctct_cod.SelectedValue.ToString
        End If
        'If flagAccion = "N" Then
        '    habilitar(True)
        'End If
    End Sub

    Private Sub cmbt_ope_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbt_ope.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbt_ope.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtt_ope.Text = cmbt_ope.SelectedValue.ToString()
    End Sub

    Private Sub cmccbco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ccbco.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmb_ccbco.SelectedIndex <> -1 Then
            txtcbco.Text = cmb_ccbco.SelectedValue.ToString
            If cmb_ccbco.SelectedIndex = 0 Then
                cmb_mon.SelectedIndex = 0
            ElseIf cmb_ccbco.SelectedIndex = 1 Then
                cmb_mon.SelectedIndex = 1
            ElseIf cmb_ccbco.SelectedIndex = 2 Then
                cmb_mon.SelectedIndex = 0
            End If
        Else
            txtcbco.Text = ""
        End If
    End Sub

    Private Sub cmbactiv_flujo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_activ_flujo.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmb_activ_flujo.SelectedIndex <> -1 Then
            txtact_flujo.Text = cmb_activ_flujo.SelectedValue.ToString
        Else
            txtact_flujo.Text = ""
        End If
    End Sub

    Private Sub cmbflujo_caja_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_flujo_caja.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmb_flujo_caja.SelectedIndex <> -1 Then
            txtflujo_caja.Text = cmb_flujo_caja.SelectedValue.ToString
        Else
            txtflujo_caja.Text = ""
        End If
    End Sub
#End Region

    Private Sub btncliente_Click(sender As Object, e As EventArgs) Handles btncliente.Click
        sBusAlm = "53"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        Dim dt As DataTable
        If (gLinea <> Nothing) Then
            txtctct_cod.Text = gLinea
            cmb_ctct_cod.SelectedValue = gLinea
            dt = REQUERIMIENTOBL.SelectDir(gLinea)
        End If
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim dt As New DataTable
        If dgvt_doc.RowCount > 0 Then
            Dim frm As New FormMantDetEltbprogpago
            frm.npdtprecio_compra.Value = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_COMPRA").Value)
            frm.npdpreciod_compra.Value = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TPRECIO_DCOMPRA").Value)
            frm.dtMoneda = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONEDA").Value
            frm.dtT_cmb = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_CMB").Value
            frm.nro = dgvt_doc.CurrentRow.Index
            frm.dtAfecto = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("STATUS").Value
            frm.dtCuenta = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTA_CBCO").Value
            frm.dtCDest = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTA_COD_DEST").Value
            frm.dtReparacion = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("X_RET").Value
            frm.dtObserva2 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("OBSERVA2").Value
            frm.txttdoc.text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value
            frm.txtSdoc.text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
            frm.txtndoc.text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
            frm.dtpfecha.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FEC_GENE").Value
            frm.npdmonto_pagar.Value = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONTO_PAGADO").Value)
            frm.npdmontod_pagar.Value = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONTO_DPAGADO").Value)
            frm.txtnom_t_doc.Text = PROVISIONESBL.SelectT_DOC_SEL(frm.txttdoc.Text)
            frm.cmbsigno.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SIGNO").Value
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista para modificar")
            Exit Sub
        End If
        contar()
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
                Case "print"
                    Exit Sub
                Case "anular"
                    If MessageBox.Show("Desea anular el documento",
                       gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If

                    Dim ELTBPROGPAGOBE As New ELTBPROGPAGOBE
                    Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    ELTBPROGPAGOBE.T_DOC_REF = txtt_doc.Text
                    ELTBPROGPAGOBE.SER_DOC_REF = cmb_serdoc.Text
                    ELTBPROGPAGOBE.NRO_DOC_REF = txtnumero.Text

                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELMVLOGSBE.log_codusu = gsCodUsr


                    gsError = ELTBPROGPAGOBL.SaveRow(ELTBPROGPAGOBE, DET_DOCUMENTOBE, ELMVLOGSBE, "AR", dgvt_doc)
                    If gsError = "OK" Then
                        MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                    tsbGrabar.Enabled = True
                    Anulacion = "1"
                    Exit Sub
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SaveData()
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("El pago de cheque no tiene items")
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
        Dim mesaño As String
        Dim m As String
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBPROGPAGOBE As New ELTBPROGPAGOBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE

        If cmbestado.SelectedIndex = 0 Then
            ELTBPROGPAGOBE.EST = "H"
        ElseIf cmbestado.SelectedIndex = 1 Then
            ELTBPROGPAGOBE.EST = "A"
        End If
        If cmb_ext_bank.SelectedIndex = 0 Then
            ELTBPROGPAGOBE.EXT_BANC = "C"
        ElseIf cmb_ext_bank.SelectedIndex = 1 Then
            ELTBPROGPAGOBE.EXT_BANC = "P"
        End If
        If dtpfanul.Checked Then
            ELTBPROGPAGOBE.FEC_ANU = dtpfanul.Value
        Else
            ELTBPROGPAGOBE.FEC_ANU = Nothing
        End If
        If cmb_cobra.SelectedIndex = 0 Then
            ELTBPROGPAGOBE.EST_COBRA = "C"
        ElseIf cmb_cobra.SelectedIndex = 1 Then
            ELTBPROGPAGOBE.EST_COBRA = "NC"
        ElseIf cmb_cobra.SelectedIndex = 2 Then
            ELTBPROGPAGOBE.EST_COBRA = "LA"
        ElseIf cmb_cobra.SelectedIndex = 3 Then
            ELTBPROGPAGOBE.EST_COBRA = "LL"
        ElseIf cmb_cobra.SelectedIndex = 4 Then
            ELTBPROGPAGOBE.EST_COBRA = "LG"
        ElseIf cmb_cobra.SelectedIndex = 5 Then
            ELTBPROGPAGOBE.EST_COBRA = "LP"
        ElseIf cmb_cobra.SelectedIndex = 6 Then
            ELTBPROGPAGOBE.EST_COBRA = "LR"
        ElseIf cmb_cobra.SelectedIndex = 7 Then
            ELTBPROGPAGOBE.EST_COBRA = "AE"
        ElseIf cmb_cobra.SelectedIndex = 8 Then
            ELTBPROGPAGOBE.EST_COBRA = "PP"
        End If
        ELTBPROGPAGOBE.T_DOC_REF = RTrim(txtt_doc.Text)
        ELTBPROGPAGOBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
        ELTBPROGPAGOBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        ELTBPROGPAGOBE.MONEDA = txtmon.Text
        ELTBPROGPAGOBE.OBSERVA = RTrim(txtobservacion.Text)
        ELTBPROGPAGOBE.PROVEEDOR = txtctct_cod.Text
        ELTBPROGPAGOBE.USUARIO = RTrim(gsUser)
        ELTBPROGPAGOBE.FEC_GENE = RTrim(dtpfecha.Text)
        ELTBPROGPAGOBE.FEC_PROG = RTrim(dtpfec_prov.Text)
        ELTBPROGPAGOBE.NRO_DOCU = RTrim(txtnro_cheque.Text)
        ELTBPROGPAGOBE.TPRECIO_COMPRA = txttprecio_compra.Text
        ELTBPROGPAGOBE.TPRECIO_DCOMPRA = txttprecio_dcompra.Text
        ELTBPROGPAGOBE.T_IGV = txtt_igv.Text
        ELTBPROGPAGOBE.T_IGV_DOLAR = txtt_igv_dolar.Text
        ELTBPROGPAGOBE.T_OPE = txtt_ope.Text
        ELTBPROGPAGOBE.COD_CBCO = txtcbco.Text
        ELTBPROGPAGOBE.ACT_FLUJO = txtact_flujo.Text
        ELTBPROGPAGOBE.FLUJO_CAJA = txtflujo_caja.Text
        ELTBPROGPAGOBE.ANULAR = Anulacion
        ELTBPROGPAGOBE.NRO_PERCEPCION = npd_perc.Value

        ELTBPROGPAGOBE.NRO_DOCU1 = txtnro_ope.Text
        If dtpfec_vigencia.Checked Then
            ELTBPROGPAGOBE.FEC_VIGENCIA = dtpfec_vigencia.Text
        Else
            ELTBPROGPAGOBE.FEC_VIGENCIA = Nothing
        End If

        ELMVLOGSBE.log_codusu = gsCodUsr
        mesaño = Replace(Mid(dtpfecha.Value, 4, 7), "/", "")
        m = Mid(dtpfecha.Value, 4, 2)
        gsError = ELTBPROGPAGOBL.SaveRow(ELTBPROGPAGOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvt_doc)
        'If gsError = "OK" Then
        '    gsError2 = ELTBPROGPAGOBL.AsientoFC("Asiento", RTrim(txtnumero.Text), cmb_serdoc.Text, txtt_doc.Text, ELTBPROGPAGOBE.PROVEEDOR, dgvt_doc, dtpfecha.Value.Year + dtpfecha.Value.Month)
        '    If gsError2 = "OK" Then
        'tsbGrabar.Enabled = False
        MsgBox("Se Guardo Correctamente", MsgBoxStyle.Information)
        '    End If
        'Else
        'MsgBox("Error al Guardar", MsgBoxStyle.Critical)
        'End If

        Exit Sub
    End Sub
    Private Function OkData() As Boolean
        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If txtt_doc.Text = "" Then
            MsgBox("Ingrese Tipo de Documento", MsgBoxStyle.Exclamation)
            txtt_doc.Focus()
            Return False
        End If
        If txtctct_cod.Text = "" Or txtctct_cod.Text <> dgvt_doc.Rows(0).Cells("PROVEEDOR").Value Then
            MsgBox("Ingrese el Proveedor de Referencia", MsgBoxStyle.Exclamation)
            txtctct_cod.Focus()
            Return False
        End If
        If txtmon.Text <> dgvt_doc.Rows(0).Cells("Moneda").Value Then
            MsgBox("Ingrese la Moneda de Referencia", MsgBoxStyle.Exclamation)
            txtmon.Focus()
            Return False
        End If
        If Len(txtnro_cheque.Text) < 8 Or Len(txtnro_cheque.Text) > 10 Then
            MsgBox("Ingrese Nro.Cheque de 8 a 10 Digitos ", MsgBoxStyle.Exclamation)
            txtnro_cheque.Focus()
            Return False
        End If
        If Len(txtnro_ope.Text) < 10 Then
            MsgBox("Ingrese Nro.Operac de 10 Digitos ", MsgBoxStyle.Exclamation)
            txtnro_cheque.Focus()
            Return False
        End If
        If txtcbco.Text = "" Then
            MsgBox("Ingrese Banco ", MsgBoxStyle.Exclamation)
            cmb_ccbco.Focus()
            Return False
        End If
        If txtact_flujo.Text = "" Then
            MsgBox("Ingrese Act.Flujo ", MsgBoxStyle.Exclamation)
            cmb_activ_flujo.Focus()
            Return False
        End If
        If txtflujo_caja.Text = "" Then
            MsgBox("Ingrese Flujo.Caja ", MsgBoxStyle.Exclamation)
            cmb_flujo_caja.Focus()
            Return False
        End If

        Return True
    End Function
    Private Sub FormMantELTBPROGPAGO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        'If Len(txtctct_cod.Text) < 11 Or txtctct_cod.Text = "" Then
        '    MsgBox("Ingresar Proveedor (Nro.Ruc) Valido.")
        '    Exit Sub
        'End If
        Dim frm As New FormDocuRefProgPago
        frm.dtMoneda = txtmon.Text
        gsCode11 = "1"
        'frm.txtCliente.Text = txtctct_cod.Text
        'If dgvt_doc.Rows.Count > 0 Then
        '    If dgvt_doc.Rows(0).Cells("PROVEEDOR").Value <> txtctct_cod.Text Then
        '        MsgBox("Este proveedor es distinto al proveedor en lista")
        '        Exit Sub
        '    End If
        '    If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONEDA").Value <> txtmon.Text Then
        '        MsgBox("La moneda es distinta a la moneda en lista")
        '        Exit Sub
        '    End If
        'End If
        frm.ShowDialog()
        gsCode11 = ""
        Dim dtFven As Date
        Dim CantD As Integer
        If dgvt_doc.Rows.Count > 0 Then
            For i = 0 To dgvt_doc.Rows.Count - 1
                CantD = ELTBPROGPAGOBL.SelectCantDias(dgvt_doc.Rows(i).Cells("F_PAGO_ENT").Value)
                'revisar
                'dtFven = DateAdd(DateInterval.Day, CantD, dgvt_doc.Rows(i).Cells("FEC_GENE").Value)
                'dgvt_doc.Rows(i).Cells("FEC_VEN").Value = dtFven
                ' - - - - -
                dgvt_doc.Rows(i).Cells("T_DOC_REF").Value = txtt_doc.Text
                dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value = cmb_serdoc.Text
                dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value = txtnumero.Text
            Next
        End If
        contar()
    End Sub
    Private Sub contar()
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim DAcumula6 As String = "Pago.Fact"
        For i = 0 To dgvt_doc.Rows.Count - 1
            If dgvt_doc.Rows(i).Cells("SIGNO").Value = "+" Then
                DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_COMPRA").Value) + DAcumula
                DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DCOMPRA").Value) + DAcumula1
                DAcumula4 = Val(dgvt_doc.Rows(i).Cells("T_IGV").Value) + DAcumula4
                DAcumula5 = Val(dgvt_doc.Rows(i).Cells("T_IGV_DOLAR").Value) + DAcumula5
                DAcumula6 = DAcumula6.ToString() + (" , ").ToString() + (dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value).ToString()
            Else
                DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_COMPRA").Value) - DAcumula
                DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DCOMPRA").Value) - DAcumula1
                DAcumula4 = Val(dgvt_doc.Rows(i).Cells("T_IGV").Value) - DAcumula4
                DAcumula5 = Val(dgvt_doc.Rows(i).Cells("T_IGV_DOLAR").Value) - DAcumula5
                DAcumula6 = DAcumula6.ToString() + (" , ").ToString() + (dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value).ToString()
            End If
        Next
        If dgvt_doc.Rows.Count = 0 Then
            txttprecio_compra.Text = ""
            txttprecio_dcompra.Text = ""
            txtt_igv.Text = ""
            txtt_igv_dolar.Text = ""
            txttcompras.Text = ""
            txttcomprad.Text = ""
            txtobservacion.Text = ""
        Else
            txttprecio_compra.Text = DAcumula
            txttprecio_dcompra.Text = DAcumula1
            txtt_igv.Text = DAcumula4
            txtt_igv_dolar.Text = DAcumula5
            txttcompras.Text = DAcumula + DAcumula4
            txttcomprad.Text = DAcumula1 + DAcumula5
            txtobservacion.Text = DAcumula6
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
        contar()
    End Sub
    Private Sub txtnro_cheque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnro_cheque.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtt_doc_TextChanged(sender As Object, e As EventArgs) Handles txtt_doc.TextChanged
        txtt_doc.ReadOnly = True
    End Sub
    Private Sub txtctct_cod_LostFocus(sender As Object, e As EventArgs) Handles txtctct_cod.LostFocus
        If txtctct_cod.Text <> "" Then
            cmb_ctct_cod.SelectedValue = txtctct_cod.Text
        End If
    End Sub


    Private Sub flujo_caja()
        If txtact_flujo.Text <> "" And txtt_ope.Text <> "" And Len(txtt_ope.Text) = 3 Then
            cmb_flujo_caja.Enabled = True
            Dim dt As DataTable = ELTBPROGPAGOBL.SelectT_DOC("01")
            dt = ELTBPROGPAGOBL.SelectFlujo_caja(txtt_ope.Text, txtact_flujo.Text)
            GetCmb("cod", "nom", dt, cmb_flujo_caja)
        Else
            cmb_flujo_caja.Enabled = False
            txtflujo_caja.Text = ""
            cmb_flujo_caja.SelectedValue = ""
        End If

    End Sub
    Private Sub txtt_ope_TextChanged(sender As Object, e As EventArgs) Handles txtt_ope.TextChanged
        txtt_ope.ReadOnly = True
        flujo_caja()
    End Sub

    Private Sub txtact_flujo_TextChanged(sender As Object, e As EventArgs) Handles txtact_flujo.TextChanged
        txtact_flujo.ReadOnly = True
        flujo_caja()
    End Sub

    Private Sub txtnro_ope_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnro_ope.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub chkperc_CheckedChanged(sender As Object, e As EventArgs) Handles chkperc.CheckedChanged
        If chkperc.Checked = True Then
            npd_perc.Enabled = True
        Else
            npd_perc.Value = 0
            npd_perc.Enabled = False
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtmon.Text = "" Then
            MsgBox("Por favor ingrese la moneda")
            Exit Sub
        End If
        Dim frm As New FormMantDetEltbprogpago
        gsCode11 = "1"
        frm.ShowDialog()
        gsCode11 = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New FormDocuRefProgPago
        frm.dtMoneda = txtmon.Text
        gsCode11 = "2"
        'frm.txtCliente.Text = txtctct_cod.Text
        'If dgvt_doc.Rows.Count > 0 Then
        '    If dgvt_doc.Rows(0).Cells("PROVEEDOR").Value <> txtctct_cod.Text Then
        '        MsgBox("Este proveedor es distinto al proveedor en lista")
        '        Exit Sub
        '    End If
        '    If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONEDA").Value <> txtmon.Text Then
        '        MsgBox("La moneda es distinta a la moneda en lista")
        '        Exit Sub
        '    End If
        'End If
        frm.ShowDialog()
        gsCode11 = ""
        Dim dtFven As Date
        Dim CantD As Integer
        If dgvt_doc.Rows.Count > 0 Then
            For i = 0 To dgvt_doc.Rows.Count - 1
                CantD = ELTBPROGPAGOBL.SelectCantDias(dgvt_doc.Rows(i).Cells("F_PAGO_ENT").Value)
                'revisar
                'dtFven = DateAdd(DateInterval.Day, CantD, dgvt_doc.Rows(i).Cells("FEC_GENE").Value)
                'dgvt_doc.Rows(i).Cells("FEC_VEN").Value = dtFven
                ' - - - - -
                dgvt_doc.Rows(i).Cells("T_DOC_REF").Value = txtt_doc.Text
                dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value = cmb_serdoc.Text
                dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value = txtnumero.Text
            Next
        End If
        contar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New FormDocuRefProgPago
        frm.dtMoneda = txtmon.Text
        gsCode11 = "3"
        'frm.txtCliente.Text = txtctct_cod.Text
        'If dgvt_doc.Rows.Count > 0 Then
        '    If dgvt_doc.Rows(0).Cells("PROVEEDOR").Value <> txtctct_cod.Text Then
        '        MsgBox("Este proveedor es distinto al proveedor en lista")
        '        Exit Sub
        '    End If
        '    If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MONEDA").Value <> txtmon.Text Then
        '        MsgBox("La moneda es distinta a la moneda en lista")
        '        Exit Sub
        '    End If
        'End If
        frm.ShowDialog()
        gsCode11 = ""
        Dim dtFven As Date
        Dim CantD As Integer
        If dgvt_doc.Rows.Count > 0 Then
            For i = 0 To dgvt_doc.Rows.Count - 1
                CantD = ELTBPROGPAGOBL.SelectCantDias(dgvt_doc.Rows(i).Cells("F_PAGO_ENT").Value)
                'revisar
                'dtFven = DateAdd(DateInterval.Day, CantD, dgvt_doc.Rows(i).Cells("FEC_GENE").Value)
                'dgvt_doc.Rows(i).Cells("FEC_VEN").Value = dtFven
                ' - - - - -
                dgvt_doc.Rows(i).Cells("T_DOC_REF").Value = txtt_doc.Text
                dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value = cmb_serdoc.Text
                dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value = txtnumero.Text
            Next
        End If
        contar()
    End Sub

    Private Sub dtpfec_prov_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_prov.LostFocus
        Dim dt As DataTable
        Dim mesfecha As String
        Dim mesdia As String
        mesfecha = dtpfec_prov.Value.Month.ToString.PadLeft(2, "0")
        mesdia = dtpfec_prov.Value.Day.ToString.PadLeft(2, "0")
        dt = PROVISIONESBL.getT_CAMB(dtpfec_prov.Value.Year.ToString & "/" & mesfecha & "/" & mesdia)
        For Each Registro In dt.Rows
            'frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
            npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
        Next
    End Sub
End Class