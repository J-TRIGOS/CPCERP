Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormReingreso_Produccion
    Private ARTICULOBL As New ARTICULOBL
    Private ELREINGRESOBL As New ELREINGRESOBL
    Private DETALLE_DOCUMENTOBL As New DETALLE_DOCUMENTOBL
    Private ELTBSTIEMBL As New ELTBSTIEMBL
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELPRODUCCIONBL As New ELPRODUCCIONBL
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private gpCaption As String
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As Boolean = True
    Private bCuarto As String = "0"
    'Private bquinto As String = "0"
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region

    Private Function OkData() As Boolean

        Dim dtCierre As New DataTable
        Dim modulo As String = "REINGRESOS"
        Dim mesCierre As String = dtpfec_gene.Value.ToString("MM")
        Dim anhoCierre As String = dtpfec_gene.Value.Year
        dtCierre = GUIAALMACENBL.VerificarCierre(modulo, mesCierre, anhoCierre)
        If dtCierre.Rows.Count = 0 Then
            MsgBox("MES CERRADO PARA REGISTRO DE DOCUMENTOS")
            dtpfec_gene.Select()
            Return False
        Else
            If dtCierre.Rows(0).Item(0) = "1" Then
                MsgBox("MES CERRADO PARA REGISTRO DE DOCUMENTOS")
                dtpfec_gene.Select()
                Return False

            End If
        End If

        If gsUser = "JVALVERDE" Or gsUser = "SISTEMAS" Then
            '  If MessageBox.Show("Su usuario ",
            ' gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            ' MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            '      Return False
            '  End If
        Else
            If rdbnew.Checked Then
                If txtnroprod.Text = "" Or txtnroprod.Text = "000000000" Then
                    MsgBox("Ingrese Numero de Produccion del área", MsgBoxStyle.Exclamation)
                    txtc_costo.Focus()
                    Return False
                End If
                'Else
                '    txtserdoc.Text = ""
            End If
            If txtc_costo.Text = "" Then
                MsgBox("Ingrese el Area", MsgBoxStyle.Exclamation)
                txtc_costo.Focus()
                Return False
            ElseIf txtcodart.Text = "" Then
                MsgBox("Ingrese el articulo de produccion", MsgBoxStyle.Exclamation)
                txtc_costo.Focus()
                Return False
            ElseIf txtlote.Text = "" Then
                MsgBox("Ingrese el lote de produccion", MsgBoxStyle.Exclamation)
                txtc_costo.Focus()
                Return False
            ElseIf txtfardo.Text = "" Then
                MsgBox("Ingrese el fardo de produccion", MsgBoxStyle.Exclamation)
                txtc_costo.Focus()
                Return False
            ElseIf rdbfinal.Checked = False And rdbparcial.Checked = False Then
                MsgBox("Marque algun tipo de Entrega", MsgBoxStyle.Exclamation)
                txtc_costo.Focus()
                Return False
            ElseIf npdcantidad.Value = 0 Then
                MsgBox("Ingrese la cantidad de la produccion", MsgBoxStyle.Exclamation)
                txtc_costo.Focus()
                Return False
            ElseIf cmbturno.SelectedIndex = -1 Then
                MsgBox("Seleccione el turno", MsgBoxStyle.Exclamation)
                txtc_costo.Focus()
                Return False
            ElseIf npdcantidad.Value = 0 Then
                MsgBox("La cantidad debe ser mayor a 0", MsgBoxStyle.Exclamation)
                txtc_costo.Focus()
                Return False
            ElseIf cmbcosto.SelectedIndex = -1 Then
                MsgBox("El Centro de Costo no es valido", MsgBoxStyle.Exclamation)
                txtcosto.Focus()
                Return False
            Else
                Dim date1, date2 As DateTime

                date1 = dtpfec_gene.Value.ToShortDateString
                date2 = dtpfecent.Value.ToShortDateString

                date1 = date1.AddHours(dtphoragene.Value.Hour)
                date1 = date1.AddMinutes(dtphoragene.Value.Minute)
                date1 = date1.AddSeconds(dtphoragene.Value.Second)

                date2 = date2.AddHours(dtphoratermino.Value.Hour)
                date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
                date2 = date2.AddSeconds(dtphoratermino.Value.Second)
                If DateTime.Compare(date1, date2) >= 0 Then
                    MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
                    dtphoragene.Focus()
                    Return False
                Else
                End If
            End If
        End If

        Return True
    End Function
    Private Sub habilitarnuevo(ByVal estado As Boolean)
        txtc_costo.Enabled = estado
        cmbc_costo.Enabled = estado
        txtnroprod.Enabled = estado
        dtpfec_gene.Enabled = estado
        dtpfecent.Enabled = estado
        cmblinea.Enabled = estado
        cmbsublinea.Enabled = estado
        txtcodart.Enabled = estado
        cmbart.Enabled = estado
        cmbuni.Enabled = estado
        npdcantidad.Enabled = estado
        txtlote.Enabled = estado
        txtlote1.Enabled = estado
        txtlote2.Enabled = estado
        txtlote3.Enabled = estado
        txtlote4.Enabled = estado
        txtfardo.Enabled = estado
        txtart_venta1.Enabled = estado
        txtart_venta2.Enabled = estado
        txtfardo4.Enabled = estado
        cmbturno.Enabled = estado
        txtobserva2.Enabled = estado
        btnbuscar.Enabled = estado
        GroupBox5.Enabled = estado
        btnbuscar.Enabled = estado
        dtphoragene.Enabled = estado
        dtphoratermino.Enabled = estado
    End Sub
    Private Sub habilitaraprob(ByVal estado1 As Boolean)
        GroupBox2.Enabled = estado1

    End Sub
    Private Sub CleanVar()
        cmbart.SelectedIndex = -1
        cmblinea.SelectedIndex = -1
        cmbsublinea.SelectedIndex = -1
        npdcantidad.Value = "0.000"
        txtlote.Text = ""
        txtobserva1.Text = ""
        cmbuni.SelectedIndex = -1
        txtobserva2.Text = ""
    End Sub
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        Dim mes As String
        'If sAño - dtpfec_gene.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfec_gene.Value.Month = "12" Then
        '    'If DateTime.Now.ToString("dd") > 12 Then
        '    '    MsgBox("Mes Cerrado")
        '    '    'cierre(False)
        '    '    Exit Sub
        '    'End If

        '    'End If
        'Else

        '    If gsAño - sAño > 1 And gsMes = "12" And sMes2 = "01" And DateTime.Now.ToString("dd") > 11 Then
        '    Else
        '        If sAño > gsAño Then
        '            MsgBox("El año es mayor al permitido")
        '        End If
        '    End If
        '    If sAño < gsAño Then
        '        'dtpfecha.Select()
        '        MsgBox("El año es menor al año actual")
        '        Exit Sub
        '    End If
        '    'modificado para que ingresen fechas libres
        '    If sMes2 < gsMes Then
        '        mes = gsMes - sMes2
        '        If mes = 1 Then
        '            'If DateTime.Now.ToString("dd") > 8 Then
        '            If DateTime.Now.ToString("dd") > 15 Then
        '                Exit Sub
        '            End If
        '        ElseIf mes > 1 Then
        '            MsgBox("El mes es mayor al permitido")
        '            Exit Sub
        '        End If
        '    End If
        'End If
        If OkData() = False Then
            Exit Sub
        End If
        Dim nro As String
        If flagAccion = "N" Then
            nro = ELREINGRESOBL.SelectNro(txtt_doc.Text, Format(dtpfec_gene.Value, "yyyy"))
            Select Case nro.Length
                Case 1
                    txtnro.Text = "000000" & nro
                Case 2
                    txtnro.Text = "00000" & nro
                Case 3
                    txtnro.Text = "0000" & nro
                Case 4
                    txtnro.Text = "000" & nro
                Case 5
                    txtnro.Text = "00" & nro
                Case 6
                    txtnro.Text = "0" & nro
                Case 7
                    txtnro.Text = nro
            End Select
        End If

        Try
            Dim ELREINGRESOBE As New ELREINGRESOBE
            Dim DETALLE_DOCUMENTOBE As New DETALLE_DOCUMENTOBE
            Dim ELMVLOGSBE As New ELMVLOGSBE

            If sOp = "0" Then
                'Dim TIME As TimeSpan
                Dim difhora As Double
                ELREINGRESOBE.T_DOC_REF = RTrim(txtt_doc.Text)
                If rdbnew.Checked Then
                    ' cmbaño.Text
                    If lblserorden1.Text = "" Then
                        ELREINGRESOBE.SER_DOC_REF = sSDoc
                        ELREINGRESOBE.SER_ORDEN = ""
                    Else
                        ELREINGRESOBE.SER_DOC_REF = txtserdoc.Text
                        ELREINGRESOBE.SER_ORDEN = cmbaño.Text
                    End If

                Else
                    ELREINGRESOBE.SER_DOC_REF = RTrim(txtserdoc.Text)
                    ELREINGRESOBE.SER_ORDEN = ""
                End If 'ELREINGRESOBE.SER_DOC_REF = RTrim(txtserdoc.Text)
                ELREINGRESOBE.NRO_DOC_REF = RTrim(txtnro.Text)
                ELREINGRESOBE.ART_COD = txtcodart.Text
                ELREINGRESOBE.FEC_GENE = dtpfec_gene.Value
                ELREINGRESOBE.FEC_TERMINO = RTrim(dtpfecent.Value)
                ELREINGRESOBE.ART_VENTA = RTrim(txtfardo.Text)
                ELREINGRESOBE.ART_VENTA1 = RTrim(txtart_venta1.Text)
                ELREINGRESOBE.ART_VENTA2 = RTrim(txtart_venta2.Text)
                ELREINGRESOBE.ART_VENTA3 = RTrim(txtfardo4.Text)
                ELREINGRESOBE.LOTE = RTrim(txtlote.Text)
                ELREINGRESOBE.LOTE1 = RTrim(txtlote1.Text)
                ELREINGRESOBE.LOTE2 = RTrim(txtlote2.Text)
                ELREINGRESOBE.LOTE3 = RTrim(txtlote3.Text)
                ELREINGRESOBE.LOTE4 = RTrim(txtlote4.Text)
                ELREINGRESOBE.LOTE = RTrim(txtlote.Text)
                ELREINGRESOBE.UNIDAD = cmbuni.SelectedValue
                ELREINGRESOBE.LINEA = cmbc_costo.SelectedValue
                ELREINGRESOBE.NRO_ORDEN = RTrim(txtnroprod.Text)
                ELREINGRESOBE.CCO_COD = txtcosto.Text
                If rdbfinal.Checked Then
                    ELREINGRESOBE.X_ENTREGA = "F"
                ElseIf rdbparcial.Checked Then
                    ELREINGRESOBE.X_ENTREGA = "P"
                End If
                ELREINGRESOBE.CANTIDAD = npdcantidad.Value
                ELREINGRESOBE.EST = "H"

                ELREINGRESOBE.EST2 = "0"

                ELREINGRESOBE.OBSERVA2 = RTrim(txtobserva2.Text)
                ELREINGRESOBE.LINEA = RTrim(txtc_costo.Text)
                ELREINGRESOBE.FEC_DIA1 = txtfec_dia.Text

                If cmbturno.SelectedIndex = 0 Then
                    ELREINGRESOBE.TURNO = "A"
                Else
                    ELREINGRESOBE.TURNO = "B"
                End If
                ELREINGRESOBE.HORA_GENE = dtphoragene.Value
                ELREINGRESOBE.HORA_TERMINO = dtphoratermino.Value
                ELREINGRESOBE.DIF_HORA = txtdifhora.Text

                Dim date1, date2 As DateTime

                date1 = dtpfec_gene.Value.ToShortDateString
                date2 = dtpfecent.Value.ToShortDateString

                date1 = date1.AddHours(dtphoragene.Value.Hour)
                date1 = date1.AddMinutes(dtphoragene.Value.Minute)
                date1 = date1.AddSeconds(dtphoragene.Value.Second)

                date2 = date2.AddHours(dtphoratermino.Value.Hour)
                date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
                date2 = date2.AddSeconds(dtphoratermino.Value.Second)
                Dim HO As Integer = 0
                Dim MI As Integer = 0
                Dim MI1 As Integer = 0
                Dim SE As Integer = 0

                HO = DateDiff(DateInterval.Hour, date1, date2)
                MI = DateDiff(DateInterval.Minute, date1, date2)
                SE = DateDiff(DateInterval.Second, date1, date2)

                MI1 = MI Mod 60
                difhora = HO + Math.Round(MI1 / 60, 2)
                ELREINGRESOBE.UND_H = Math.Round(npdcantidad.Value / difhora, 2)
                ELREINGRESOBE.NUM_DIF = difhora
                ELMVLOGSBE.log_codusu = gsCodUsr
                If sOp = "0" Then
                    ELREINGRESOBE.USUARIO_RP = RTrim(gsUser)
                    ELREINGRESOBE.EST1 = "0"
                ElseIf sOp = "1" Then
                    ELREINGRESOBE.USUARIO_OB = RTrim(gsUser)
                    'Observado
                    ELREINGRESOBE.EST1 = "1"
                End If
                If ELREINGRESOBE.EST1 = "1" Then
                    ELREINGRESOBE.EST1 = "0"
                End If
                ELREINGRESOBE.nrodia = lblnrodia.Text
                ELREINGRESOBE.anho = lblanho.Text
                If rdbnew.Checked Then
                    ELREINGRESOBE.op = "0"
                End If
                gsError = ELREINGRESOBL.SaveRow(ELREINGRESOBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, flagAccion, txtserdoc.Text)
            ElseIf sOp = "1" Then
                ELREINGRESOBE.T_DOC_REF = RTrim(txtt_doc.Text)
                ELREINGRESOBE.SER_DOC_REF = RTrim(txtserdoc.Text)
                ELREINGRESOBE.NRO_DOC_REF = RTrim(txtnro.Text)
                ELREINGRESOBE.OBSERVA1 = RTrim(txtobserva1.Text)
                ELMVLOGSBE.log_codusu = gsCodUsr
                ELREINGRESOBE.USUARIO_OB = RTrim(gsUser)
                ELREINGRESOBE.EST1 = "1"
                gsError = ELREINGRESOBL.SaveRow(ELREINGRESOBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, "M1", txtserdoc.Text)
            End If

            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                Dispose()
                'habilitarnuevo(False)
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
            Case "exit"
                Dispose()
                contcant = 0
                Exit Sub
            Case "Print"
                'gsRptArgs = {}
                'ReDim gsRptArgs(2)
                'gsRptArgs(0) = cmbt_doc.SelectedValue
                'gsRptArgs(1) = cmb_serdoc.SelectedItem
                'gsRptArgs(2) = txtnumero.Text
                'gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VALE.rpt"
                'gsRptPath = gsPathRpt
                'FormReportes.ShowDialog()
            Case "anular"

                If MessageBox.Show("Desea anular el documento",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim ELREINGRESOBE As New ELREINGRESOBE
                Dim DETALLE_DOCUMENTOBE As New DETALLE_DOCUMENTOBE
                Dim ELMVALMABE As New ELMVALMABE
                ELREINGRESOBE.T_DOC_REF = txtt_doc.Text
                ELREINGRESOBE.SER_DOC_REF = txtserdoc.Text
                ELREINGRESOBE.NRO_DOC_REF = txtnro.Text
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ELREINGRESOBL.SaveRow(ELREINGRESOBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, "A", txtserdoc.Text)


                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    habilitarnuevo(False)
                    'Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
                Exit Sub
        End Select
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dt As DataTable
        Dim Registro As DataRow
        If sTDoc <> "RPD" Then
            dt = ELREINGRESOBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)
            For Each Registro In dt.Rows
                txtt_doc.Text = sTDoc
                txtfec_dia.Text = IIf(IsDBNull(Registro("fec_dia1")), "", Registro("fec_dia1"))
                txtusuario.Text = IIf(IsDBNull(Registro("usuario")), "", Registro("usuario"))
                txtnro.Text = sNDoc
                dtpfec_gene.Value = IIf(IsDBNull(Registro("fec_gene")), "", Registro("fec_gene"))
            Next
        Else

        End If

    End Sub

    Private Sub FormReporte_Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtc_costo.Select()
        Dim nro As String
        bPrimero = True
        gsError = ""
        Me.Text = "Reporte de Producción"
        'Cargar los combos
        Dim dt As DataTable = ARTICULOBL.SelectDescripcion2()
        'Dim dt As DataTable = ARTICULOBL.getListcmblin1()
        GetCmb("lin_codigo", "lin_descri", dt, cmblinea)
        dt = ARTICULOBL.SelectUndMed()
        GetCmb("cod", "nom", dt, cmbuni)
        dt = ARTICULOBL.getListcmblin1()
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = ELPAGO_DOCUMENTOBL.SelectCentroCosto1()
        GetCmb("cod", "nom", dt, cmbcosto)
        tsbGrabar.Enabled = True
        ToolStripButton1.Enabled = True
        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                'habilitarnuevo(False)
                gArt = Nothing
                Me.txtt_doc.Text = "REIN"
                nro = ELREINGRESOBL.SelectNro(txtt_doc.Text, Format(dtpfec_gene.Value, "yyyy"))
                txtnro.Text = nro.PadLeft(7, "0")
                habilitarnuevo(True)
                txtusuario.Text = gsUser
                txtfec_dia.Text = Date.Now.ToString
                lblcabecera.Text = "PENDIENTE"
                txtserdoc.Text = gsAño
                cmbc_costo.Enabled = False
                txtc_costo.Enabled = False
                cmbcosto.Enabled = False
                txtcosto.Enabled = False
                txtnroprod.MaxLength = 7
                cmbaño.Visible = True
                cmbaño.Text = sAño
                txtcodart.ReadOnly = True
                cmbuni.Enabled = False
                Button5.Enabled = False
                cmbaño.Text = sAño
            Case 1
                If txtfec_dia.Text <= "03/12/2020" Then
                    flagAccion = "M"
                    GetData(sTDoc, sSDoc, sNDoc)
                    txtt_doc.Text = sTDoc
                    txtcodart.Text = gArt
                    cmblinea.SelectedValue = Mid(gArt, 1, 2) & "00"
                    dt = ARTICULOBL.SelectDescripcion1(cmblinea.SelectedValue)
                    GetCmb("lin_codigo", "lin_descri", dt, cmbsublinea)
                    cmbsublinea.SelectedValue = Mid(gArt, 1, 4)
                    dt = ARTICULOBL.SelectArt1(cmbsublinea.SelectedValue)
                    GetCmb("ART_CODIGO", "ART_COD", dt, cmbart)
                    cmbart.SelectedValue = Trim(gArt)
                    If Me.txtt_doc.Text <> "REIN" Then
                        dt = DETALLE_DOCUMENTOBL.SelectRow(Trim(sTDoc), Trim(sSDoc), Trim(sNDoc), Trim(gArt))
                        For Each Registro In dt.Rows
                            lblcabecera.Text = IIf(IsDBNull(Registro("X_CONT")), "", Registro("X_CONT"))
                            txtobserva1.Text = IIf(IsDBNull(Registro("OBS1")), "", Registro("OBS1"))
                            txtobserva2.Text = IIf(IsDBNull(Registro("OBS2")), "", Registro("OBS2"))
                            txtserdoc.Text = IIf(IsDBNull(Registro("VAR1")), "", Registro("VAR1"))
                            txtc_costo.Text = IIf(IsDBNull(Registro("act_cod")), "", Registro("act_cod"))
                            txtnroprod.Text = IIf(IsDBNull(Registro("CERTIFICADO1")), "", Registro("CERTIFICADO1"))
                            txtfardo.Text = IIf(IsDBNull(Registro("ART_VENTA")), "", Registro("ART_VENTA"))
                            txtlote.Text = IIf(IsDBNull(Registro("LOTE")), "", Registro("LOTE"))
                            If sTDoc = "PDE" Then
                                npdcantidad.Value = IIf(IsDBNull(Registro("cantidad")), 0, Registro("cantidad"))
                            ElseIf sTDoc = "PDC" Then
                                npdcantidad.Value = IIf(IsDBNull(Registro("cantidad2")), 0, Registro("cantidad2"))
                            ElseIf sTDoc = "PDL" Then
                                npdcantidad.Value = IIf(IsDBNull(Registro("cantidad1")), 0, Registro("cantidad1"))
                            ElseIf sTDoc = "PD5G" Then
                                npdcantidad.Value = IIf(IsDBNull(Registro("cantidad")), 0, Registro("cantidad"))
                            ElseIf sTDoc = "PDT" Then
                                npdcantidad.Value = IIf(IsDBNull(Registro("cantidad39")), 0, Registro("cantidad39")) + IIf(IsDBNull(Registro("cantidad40")), 0, Registro("cantidad40")) + IIf(IsDBNull(Registro("cantidad41")), 0, Registro("cantidad41"))
                            ElseIf sTDoc = "PDF" Then
                                npdcantidad.Value = IIf(IsDBNull(Registro("cantidad")), 0, Registro("cantidad"))
                            ElseIf sTDoc = "PPP" Then
                                npdcantidad.Value = IIf(IsDBNull(Registro("cantidad5")), 0, Registro("cantidad5"))
                            End If
                        Next
                    Else
                        dt = ELREINGRESOBL.SelectRow1(Trim(sTDoc), Trim(sSDoc), Trim(sNDoc))
                        For Each Registro In dt.Rows
                            txtobserva1.Text = IIf(IsDBNull(Registro("OBSERVA1")), "", Registro("OBSERVA1"))
                            txtobserva2.Text = IIf(IsDBNull(Registro("OBSERVA2")), "", Registro("OBSERVA2"))
                            txtserdoc.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
                            txtc_costo.Text = IIf(IsDBNull(Registro("LINEA")), "", Registro("LINEA"))
                            txtnroprod.Text = IIf(IsDBNull(Registro("NRO_ORDEN")), "", Registro("NRO_ORDEN"))
                            txtfardo.Text = IIf(IsDBNull(Registro("ART_VENTA")), "", Registro("ART_VENTA"))
                            txtart_venta1.Text = IIf(IsDBNull(Registro("ART_VENTA1")), "", Registro("ART_VENTA1"))
                            txtart_venta2.Text = IIf(IsDBNull(Registro("ART_VENTA2")), "", Registro("ART_VENTA2"))
                            txtfardo4.Text = IIf(IsDBNull(Registro("ART_VENTA3")), "", Registro("ART_VENTA3"))
                            txtlote.Text = IIf(IsDBNull(Registro("LOTE")), "", Registro("LOTE"))
                            txtlote1.Text = IIf(IsDBNull(Registro("LOTE1")), "", Registro("LOTE1"))
                            txtlote2.Text = IIf(IsDBNull(Registro("LOTE2")), "", Registro("LOTE2"))
                            txtlote3.Text = IIf(IsDBNull(Registro("LOTE3")), "", Registro("LOTE3"))
                            txtlote4.Text = IIf(IsDBNull(Registro("LOTE4")), "", Registro("LOTE4"))
                            npdcantidad.Value = IIf(IsDBNull(Registro("cantidad")), 0, Registro("cantidad"))
                            If IIf(IsDBNull(Registro("X_ENTREGA")), "", Registro("X_ENTREGA")) = "F" Then
                                rdbfinal.Checked = True
                            ElseIf IIf(IsDBNull(Registro("X_ENTREGA")), "", Registro("X_ENTREGA")) = "P" Then
                                rdbparcial.Checked = True
                            End If
                            'Me.txtt_doc.Text = "RPD"
                            Me.txtnro.Text = sNDoc
                            txtfec_dia.Text = IIf(IsDBNull(Registro("FEC_DIA1")), "", Registro("FEC_DIA1"))
                            dtpfec_gene.Value = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
                            dtpfecent.Value = IIf(IsDBNull(Registro("FEC_TERMINO")), "", Registro("FEC_TERMINO"))
                            txtusuario.Text = IIf(IsDBNull(Registro("USUARIO_RP")), "", Registro("USUARIO_RP"))
                            If IIf(IsDBNull(Registro("TURNO")), "", Registro("TURNO")) = "A" Then
                                cmbturno.SelectedIndex = 0
                            ElseIf IIf(IsDBNull(Registro("TURNO")), "", Registro("TURNO")) = "B" Then
                                cmbturno.SelectedIndex = 1
                            End If
                            cmbuni.SelectedValue = IIf(IsDBNull(Registro("UNIDAD")), "", Registro("UNIDAD"))
                            cmbc_costo.SelectedValue = txtc_costo.Text
                            lblserorden1.Text = IIf(IsDBNull(Registro("SER_ORDEN")), "", Registro("SER_ORDEN"))
                            If IIf(IsDBNull(Registro("EST")), "", Registro("EST")) = "H" Then
                                If sOp = "0" Then
                                    habilitarnuevo(True)
                                ElseIf sOp = "1" Then
                                    habilitaraprob(True)
                                    lblest.Text = "SIN CONFIRMAR"
                                End If
                                If IIf(IsDBNull(Registro("EST1")), "", Registro("EST1")) = "0" Then
                                    lblcabecera.Text = "PENDIENTE"
                                ElseIf IIf(IsDBNull(Registro("EST1")), "", Registro("EST1")) = "1" Then
                                    lblcabecera.Text = "OBSERVADO"
                                    'txtobserva1.Text =
                                ElseIf IIf(IsDBNull(Registro("EST1")), "", Registro("EST1")) = "2" Then
                                    lblcabecera.Text = "APROBADO"
                                    habilitarnuevo(False)
                                    tsbGrabar.Enabled = False
                                    ToolStripButton1.Enabled = False
                                End If
                            End If
                            txtcosto.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                            cmbcosto.SelectedValue = txtcosto.Text
                            'Dim TIME As TimeSpan = IIf(IsDBNull(Registro("HORA_GENE")), "", Registro("HORA_GENE"))
                            lblnrodia.Text = IIf(IsDBNull(Registro("NRO_DIA")), "", Registro("NRO_DIA"))
                            lblanho.Text = IIf(IsDBNull(Registro("ANHO")), "", Registro("ANHO"))
                            If Registro("TURNO") = "A" Then
                                lblturno.Text = 1
                            Else
                                lblturno.Text = 2
                            End If
                            dtphoragene.Value = IIf(IsDBNull(Registro("HORA_GENE")), "", Registro("HORA_GENE"))
                            dtphoratermino.Value = IIf(IsDBNull(Registro("HORA_TERMINO")), "", Registro("HORA_TERMINO"))
                            txtdifhora.Text = IIf(IsDBNull(Registro("DIF_HORA")), "", Registro("DIF_HORA"))
                            lblserorden.Text = IIf(IsDBNull(Registro("SER_ORDEN")), "", Registro("SER_ORDEN"))
                            cmbaño.SelectedItem = IIf(IsDBNull(Registro("SER_ORDEN")), "", Registro("SER_ORDEN"))
                        Next
                        dt = ELPRODUCCIONBL.LineaProd(txtserdoc.Text, txtnroprod.Text)
                        For Each Registro In dt.Rows
                            txtArt.Text = IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD"))
                            txtnomart.Text = ARTICULOBL.SelectArt2(txtArt.Text)
                        Next

                    End If
                    If lblserorden1.Text <> "" Then
                        cmbc_costo.Enabled = False
                        txtc_costo.Enabled = False
                        cmbcosto.Enabled = False
                        txtcosto.Enabled = False
                        txtnroprod.MaxLength = 7
                        cmbaño.Visible = True
                        txtcodart.ReadOnly = True
                        cmbuni.Enabled = False
                        Button5.Enabled = False
                    Else
                        rdbant.Checked = True
                        rdbnew.Checked = False
                    End If
                Else

                End If

                If txtnroprod.Text <> "" Then
                    ComboBox1_SelectedIndexChanged(sender, e)
                    bPrimero = True
                    dt = ELPRODUCCIONBL.SelectArtOP(txtnroprod.Text)
                    GetCmb("ART_DESCRI", "ART_COD", dt, ComboBox1)
                    ComboBox1.Enabled = True
                    ComboBox1.Visible = True
                    '    bPrimero = False
                    ComboBox1.SelectedValue = txtcodart.Text
                End If


        End Select

        bPrimero = False
    End Sub
    Private Sub cmblinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblinea.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        Dim sCode As String = Mid(cmblinea.SelectedValue, 1, 2)
        'bSegundo = True
        If cmblinea.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.getcmbsub1(sCode)
            GetCmb("lin_codigo", "lin_descri", dt, cmbsublinea)
        End If
        bSegundo = False
    End Sub
    Private Sub cmbsublinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsublinea.SelectedIndexChanged
        If bSegundo Then
            Exit Sub
        End If

        If cmbsublinea.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            If dt.Rows.Count > 0 Then
                GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
                bTercero = False

            Else
                'chequear
                'MsgBox("La Sublinea no tiene articulos")
                'For i = 0 To cmbart.Items.Count - 1
                cmbart.DataSource = Nothing
                'Next
                'cmbart.Refresh()
            End If

        End If
        cmbuni.SelectedIndex = -1

    End Sub

    Private Sub FormReporte_Produccion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "6"
        If cmbart.Items.Count > 0 Then
            cmbart.DataSource = Nothing
        End If
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            cmblinea.SelectedValue = gLinea
            cmbsublinea.SelectedValue = gSubLinea
            txtcodart.Text = gArt
            Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
            cmbart.SelectedValue = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        Dim dt As DataTable
        cmbart.DataSource = Nothing
        cmbsublinea.DataSource = Nothing
        cmblinea.SelectedIndex = -1
        bSegundo = True
        If txtcodart.TextLength < 8 Then
            MsgBox("El articulo no existe", MsgBoxStyle.Exclamation)
            txtcodart.Text = ""
            cmbart.DataSource = Nothing
            'txtcodart.Select()
            cmbsublinea.DataSource = Nothing
            cmblinea.SelectedIndex = -1
            Exit Sub
        End If
        cmblinea.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"
        Dim art As String = txtcodart.Text
        If flagAccion = "N" Then
            cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
            txtcodart.Text = art
        Else
            cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
        End If

        'cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
        'txtcodart.Text = art
        If cmbsublinea.SelectedIndex = -1 Then
            Exit Sub
        End If
        If flagAccion = "M" Then
            cmbart.DataSource = Nothing
            dt = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
        Else
        End If
        cmbart.SelectedValue = txtcodart.Text
        If cmbart.SelectedValue <> txtcodart.Text Then
            MsgBox("El articulo no existe", MsgBoxStyle.Exclamation)
            txtcodart.Text = ""
            cmbart.DataSource = Nothing
            'txtcodart.Select()
            cmbsublinea.DataSource = Nothing
            cmblinea.SelectedIndex = -1
        End If

        bSegundo = False
    End Sub

    'Private Sub txtcodart_Validated(sender As Object, e As EventArgs) Handles txtcodart.Validated
    '    If bPrimero Then Exit Sub
    '    'buscar articulo
    '    Dim dt As DataTable
    '    cmblinea.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

    '    If cmblinea.SelectedValue = "" Then
    '        Exit Sub
    '    End If
    '    Dim art As String = txtcodart.Text
    '    If flagAccion = "N" Then
    '        cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
    '        txtcodart.Text = art
    '    Else
    '        cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
    '    End If

    '    'cmbsublinea.SelectedValue = Mid(txtcodart.Text, 1, 4)
    '    'txtcodart.Text = art
    '    If cmbsublinea.SelectedValue = "" Then
    '        Exit Sub
    '    End If
    '    If flagAccion = "M" Then
    '        cmbart.DataSource = Nothing
    '        dt = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
    '        GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
    '    Else
    '    End If
    '    cmbart.SelectedValue = txtcodart.Text

    '    If cmbart.SelectedValue <> txtcodart.Text Then
    '        MsgBox("El articulo no existe", MsgBoxStyle.Exclamation)
    '        txtcodart.Text = ""
    '        txtcodart.Select()
    '    End If


    'End Sub

    Private Sub cmbart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbart.SelectedIndexChanged
        If bTercero Then Exit Sub
        'OJO VER
        If cmbart.SelectedIndex <> -1 Then
            If gArt <> Nothing Then
                cmbuni.SelectedValue = ARTICULOBL.SelectUniMed(Mid(gArt, 1, 8))
            Else
                Try
                    txtcodart.Text = cmbart.SelectedValue
                    cmbuni.SelectedValue = ARTICULOBL.SelectUniMed(Mid(txtcodart.Text, 1, 8))
                Catch ex As Exception

                End Try

            End If

        End If
        bTercero = False
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


    Private Sub txtc_costo_LostFocus(sender As Object, e As EventArgs) Handles txtc_costo.LostFocus
        If txtc_costo.Text = "" Then
            cmbc_costo.SelectedValue = ""
            Exit Sub
        End If
        cmbc_costo.SelectedValue = txtc_costo.Text
        If cmbc_costo.SelectedValue Is Nothing Then
            MsgBox("La linea no existe", MsgBoxStyle.Exclamation)
            txtc_costo.Text = ""
            txtc_costo.Select()
        End If
    End Sub

    Private Sub dtphoratermino_LostFocus(sender As Object, e As EventArgs) Handles dtphoratermino.LostFocus
        Dim date1, date2 As DateTime

        date1 = dtpfec_gene.Value.ToShortDateString
        date2 = dtpfecent.Value.ToShortDateString

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

            HO = DateDiff(DateInterval.Hour, date1, date2)
            MI = DateDiff(DateInterval.Minute, date1, date2)
            SE = DateDiff(DateInterval.Second, date1, date2)
            MI = MI Mod 60
            SE = SE Mod 60

            txtdifhora.Text = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
        End If

    End Sub
    Private Sub dtphoragene_LostFocus(sender As Object, e As EventArgs) Handles dtphoragene.LostFocus
        dtphoratermino.Focus()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveData()
    End Sub

    Private Sub txtnroprod_LostFocus(sender As Object, e As EventArgs) Handles txtnroprod.LostFocus

        Dim dt As DataTable
        If rdbnew.Checked Then

            If txtc_costo.Enabled = True Then
                txtnroprod.Text = txtnroprod.Text.PadLeft(9, "0")
            Else
                txtnroprod.Text = txtnroprod.Text.PadLeft(9, "0")
            End If
            If txtc_costo.Enabled = False Then

                dt = ELPRODUCCIONBL.ProdDatos(cmbaño.Text, txtnroprod.Text)
                For Each Registro In dt.Rows
                    txtArt.Text = Trim(IIf(IsDBNull(Registro("cod_art")), "", Registro("cod_art"))) ' cmbart.SelectedValue
                    txtnomart.Text = ARTICULOBL.SelectArt2(txtArt.Text)
                    txtcantord.Text = Trim(IIf(IsDBNull(Registro("cant_generar")), 0, Registro("cant_generar")))
                    txtcantate.Text = Trim(IIf(IsDBNull(Registro("ot_atendido")), 0, Registro("ot_atendido")))
                    rdbparcial.Checked = True

                Next

                If txtc_costo.Enabled = False Then
                    dt = ELPRODUCCIONBL.LineaProd(txtserdoc.Text, txtnroprod.Text)
                    For Each Registro In dt.Rows
                        cmbturno.SelectedIndex = IIf(IsDBNull(Registro("TURNO")), "1", Registro("TURNO"))
                        txtcosto.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                        cmbcosto.SelectedValue = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                    Next
                    If txtArt.Text = "" Then
                        MsgBox("El numero no tiene referncia")
                    End If
                    dt = ELPRODUCCIONBL.ProdHor(txtserdoc.Text, txtnroprod.Text)
                    For Each Registro In dt.Rows
                        dtphoragene.Value = Trim(IIf(IsDBNull(Registro("FEC_INI")), "", Registro("FEC_INI")))
                        dtphoratermino.Value = Trim(IIf(IsDBNull(Registro("FEC_FIN")), "", Registro("FEC_FIN")))
                        dtpfec_gene.Value = Trim(IIf(IsDBNull(Registro("FEC_INI")), "", Registro("FEC_INI")))
                        dtpfecent.Value = Trim(IIf(IsDBNull(Registro("FEC_FIN")), "", Registro("FEC_FIN")))
                    Next

                    Dim date1, date2 As DateTime

                    date1 = dtpfec_gene.Value.ToShortDateString
                    date2 = dtpfecent.Value.ToShortDateString

                    date1 = date1.AddHours(dtphoragene.Value.Hour)
                    date1 = date1.AddMinutes(dtphoragene.Value.Minute)
                    date1 = date1.AddSeconds(dtphoragene.Value.Second)

                    date2 = date2.AddHours(dtphoratermino.Value.Hour)
                    date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
                    date2 = date2.AddSeconds(dtphoratermino.Value.Second)

                    txtdifhora.Text = Nothing
                    Dim HO As Integer = 0
                    Dim MI As Integer = 0
                    Dim SE As Integer = 0

                    HO = DateDiff(DateInterval.Hour, date1, date2)
                    MI = DateDiff(DateInterval.Minute, date1, date2)
                    SE = DateDiff(DateInterval.Second, date1, date2)
                    MI = MI Mod 60
                    SE = SE Mod 60

                    txtdifhora.Text = HO.ToString.PadLeft(2, "0") & ":" & MI.ToString.PadLeft(2, "0") & ":" & SE.ToString.PadLeft(2, "0")
                End If
                dt = ELPRODUCCIONBL.OrdProg(cmbaño.Text, txtnroprod.Text, txtArt.Text)
                For Each Registro In dt.Rows
                    txtcosto.Text = Trim(IIf(IsDBNull(Registro("CCO_COD")), 0, Registro("CCO_COD")))
                    cmbcosto.SelectedValue = txtcosto.Text
                    txtc_costo.Text = Trim(IIf(IsDBNull(Registro("COD_AREA")), 0, Registro("COD_AREA")))
                    cmbc_costo.SelectedValue = txtc_costo.Text
                Next
            End If


            If txtnroprod.Text <> "" And Len(txtnroprod.Text) = "9" Then
                bPrimero = True
                dt = ELPRODUCCIONBL.SelectArtOP(txtnroprod.Text)
                If dt.Rows.Count = 0 Then
                    ComboBox1.Enabled = False
                Else
                    GetCmb("ART_DESCRI", "ART_COD", dt, ComboBox1)
                    ComboBox1.Enabled = True
                End If

                cmblinea.SelectedValue = -1
                cmbsublinea.SelectedValue = -1
                txtcodart.Text = ""
                cmbart.SelectedIndex = -1
                cmblinea.Enabled = False
                cmbart.Enabled = False
                cmbsublinea.Enabled = False
                ComboBox1.Visible = True
                txtcodart.Text = ""
                bPrimero = False
            End If
        End If

    End Sub

    Private Sub dtpfecent_LostFocus(sender As Object, e As EventArgs) Handles dtpfecent.LostFocus
        If dtpfec_gene.Value.Date <= dtpfecent.Value.Date Then
            dtphoratermino.Value = dtpfecent.Value
            If DateTime.Now.ToString("mm") = "01" Then
                txtserdoc.Text = DateTime.Now.ToString("yyyy")
            End If
        Else
            MsgBox("La fecha de termino debe ser mayor a la fecha inicial")
            dtpfecent.Focus()
        End If
    End Sub

    Private Sub dtpfec_gene_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_gene.LostFocus
        Dim dtCierre As New DataTable
        Dim modulo As String = "REINGRESOS"
        Dim mesCierre As String = dtpfec_gene.Value.ToString("MM")
        Dim anhoCierre As String = dtpfec_gene.Value.Year
        dtCierre = GUIAALMACENBL.VerificarCierre(modulo, mesCierre, anhoCierre)
        If dtCierre.Rows.Count = 0 Then
            MsgBox("MES CERRADO PARA REGISTRO DE DOCUMENTOS")
            dtpfec_gene.Select()
            Exit Sub
        Else
            If dtCierre.Rows(0).Item(0) = "1" Then
                MsgBox("MES CERRADO PARA REGISTRO DE DOCUMENTOS")
                dtpfec_gene.Select()
                Exit Sub

            End If
        End If

        If dtpfec_gene.Value.Month > DateTime.Now.ToString("MM").PadLeft(2, "0") Then
            If DateTime.Now.ToString("MM").PadLeft(2, "0") = "01" And dtpfec_gene.Value.Month = 12 And
                 DateTime.Now.ToString("yyyy") - dtpfec_gene.Value.Year <= 1 And DateTime.Now.ToString("yyyy") - dtpfec_gene.Value.Year >= 1 Then
                If ELTBSTIEMBL.SelPermiso(gsUser) = "1" Then
                    dtphoragene.Value = dtpfec_gene.Value
                Else
                    If dtpfec_gene.Value.Month = DateTime.Now.ToString("MM").PadLeft(2, "0") Then
                        If dtpfec_gene.Value.Day > DateTime.Now.ToString("dd").PadLeft(2, "0") Then
                            MsgBox("Error al ingresar la fecha")
                            dtpfec_gene.Focus()
                            Exit Sub
                        End If
                    End If
                    Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+6).ToShortDateString
                    'Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+13).ToShortDateString
                    Dim Today As DateTime = DateTime.Now.ToShortDateString
                    If DateTime.Compare(dtpini, Today) <= 0 Then
                        MsgBox("La fecha de inicio no debe ser más de 5 dias antes a la fecha actual, Si desea Generar el Ingreso favor comuniquese con los jefes de Producción", MsgBoxStyle.Exclamation)
                        dtpfec_gene.Focus()
                    Else
                        dtphoragene.Value = dtpfec_gene.Value
                    End If
                End If
            Else
                MsgBox("Error al ingresar la fecha")
                dtpfec_gene.Focus()
                Exit Sub
            End If
        Else
            If ELTBSTIEMBL.SelPermiso(gsUser) = "1" Or gsUser = "JVALVERDE" Or gsUser = "SISTEMAS" Then
                dtphoragene.Value = dtpfec_gene.Value
            Else
                If dtpfec_gene.Value.Month = DateTime.Now.ToString("MM").PadLeft(2, "0") Then
                    If dtpfec_gene.Value.Day > DateTime.Now.ToString("dd").PadLeft(2, "0") Then
                        MsgBox("Error al ingresar la fecha")
                        dtpfec_gene.Focus()
                        Exit Sub
                    End If
                End If
                Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+6).ToShortDateString
                'Dim dtpini As DateTime = dtpfec_gene.Value.AddDays(+15).ToShortDateString
                Dim Today As DateTime = DateTime.Now.ToShortDateString
                If DateTime.Compare(dtpini, Today) <= 0 Then
                    MsgBox("La fecha de inicio no debe ser más de 5 dias antes a la fecha actual, Si desea Generar el Ingreso favor comuniquese con los jefes de Producción", MsgBoxStyle.Exclamation)
                    dtpfec_gene.Focus()
                Else
                    dtphoragene.Value = dtpfec_gene.Value
                End If
            End If
        End If
    End Sub
    Private Sub cmbturno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbturno.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        Dim anho As Integer
        Dim mes As String
        Dim dia As String
        anho = dtpfec_gene.Value.Date.Year
        mes = dtpfec_gene.Value.Date.Month.ToString.PadLeft(2, "0")
        dia = dtpfec_gene.Value.Date.Day.ToString.PadLeft(2, "0")

        If (anho Mod 4 = 0 And anho Mod 100 <> 0 Or anho Mod 400 = 0) Then
            lblnrodia.Text = ELREINGRESOBL.SelectNrodia("1", mes, dia) '.PadLeft(4, "0")
        Else
            lblnrodia.Text = ELREINGRESOBL.SelectNrodia("0", mes, dia) '.PadLeft(4, "0")            
        End If
        lblanho.Text = anho.ToString.Substring(2, 2)
        lblturno.Text = cmbturno.SelectedIndex + 1

    End Sub

    Private Sub txtnroprod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnroprod.KeyDown
        If e.KeyValue = Keys.F9 Then
            If txtc_costo.Enabled = True Then
                sBusAlm = "243"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If (gLinea <> Nothing) Then
                    txtserdoc.Text = gLinea
                    txtnroprod.Text = gSubLinea
                    gLinea = ""
                    gSubLinea = ""
                End If
            End If
            e.Handled = True
            gLinea = ""
            gSubLinea = ""
            'gsCode11 = ""
            Dim dt As DataTable
            If rdbnew.Checked Then
                If txtc_costo.Enabled = True Then
                    txtnroprod.Text = txtnroprod.Text.PadLeft(9, "0")
                Else
                    txtnroprod.Text = txtnroprod.Text.PadLeft(9, "0")
                End If
                If txtc_costo.Enabled = False Then
                    dt = ELPRODUCCIONBL.ProdDatos(cmbaño.Text, txtnroprod.Text)
                    For Each Registro In dt.Rows
                        txtArt.Text = Trim(IIf(IsDBNull(Registro("cod_art")), "", Registro("cod_art"))) ' cmbart.SelectedValue
                        txtnomart.Text = ARTICULOBL.SelectArt2(txtArt.Text)
                        txtcantord.Text = Trim(IIf(IsDBNull(Registro("cant_generar")), 0, Registro("cant_generar")))
                        txtcantate.Text = Trim(IIf(IsDBNull(Registro("ot_atendido")), 0, Registro("ot_atendido")))
                        rdbparcial.Checked = True
                    Next
                    If txtc_costo.Enabled = False Then
                        dt = ELPRODUCCIONBL.LineaProd(txtserdoc.Text, txtnroprod.Text)
                        For Each Registro In dt.Rows
                            cmbturno.SelectedIndex = IIf(IsDBNull(Registro("TURNO")), "1", Registro("TURNO"))
                            txtcosto.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                            cmbcosto.SelectedValue = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                        Next
                    End If
                    dt = ELPRODUCCIONBL.OrdProg(cmbaño.Text, txtnroprod.Text, txtArt.Text)
                    For Each Registro In dt.Rows
                        txtcosto.Text = Trim(IIf(IsDBNull(Registro("CCO_COD")), 0, Registro("CCO_COD")))
                        cmbcosto.SelectedValue = txtcosto.Text
                        txtc_costo.Text = Trim(IIf(IsDBNull(Registro("COD_AREA")), 0, Registro("COD_AREA")))
                        cmbc_costo.SelectedValue = txtc_costo.Text
                    Next
                End If

            End If
        End If
    End Sub

    Private Sub cmbaño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbaño.SelectedIndexChanged
        Dim dt As DataTable
        dt = ELPRODUCCIONBL.ProdDatos(cmbaño.Text, txtnroprod.Text)

        For Each Registro In dt.Rows
            cmblinea.SelectedValue = Mid(IIf(IsDBNull(Registro("cod_art")), "", Registro("cod_art")), 1, 2) & "00"
            dt = ARTICULOBL.SelectDescripcion1(cmblinea.SelectedValue)
            GetCmb("lin_codigo", "lin_descri", dt, cmbsublinea)
            cmbsublinea.SelectedValue = Mid(IIf(IsDBNull(Registro("cod_art")), "", Registro("cod_art")), 1, 4)
            dt = ARTICULOBL.SelectArt1(cmbsublinea.SelectedValue)
            GetCmb("ART_CODIGO", "ART_COD", dt, cmbart)
            cmbart.SelectedValue = Trim(IIf(IsDBNull(Registro("cod_art")), "", Registro("cod_art")))
            txtcantord.Text = Trim(IIf(IsDBNull(Registro("cant_generar")), 0, Registro("cant_generar")))
            txtcantate.Text = Trim(IIf(IsDBNull(Registro("ot_atendido")), 0, Registro("ot_atendido")))
            rdbparcial.Checked = True
            txtc_costo.Text = Trim(IIf(IsDBNull(Registro("ot_atendido")), 0, Registro("ot_atendido")))
        Next
        dt = ELPRODUCCIONBL.OrdProg(cmbaño.Text, txtnroprod.Text, txtcodart.Text)
        For Each Registro In dt.Rows
            txtcosto.Text = Trim(IIf(IsDBNull(Registro("CCO_COD")), 0, Registro("CCO_COD")))
            cmbcosto.SelectedValue = txtcosto.Text
            txtc_costo.Text = Trim(IIf(IsDBNull(Registro("COD_AREA")), 0, Registro("COD_AREA")))
            cmbc_costo.SelectedValue = txtc_costo.Text
        Next
        If txtc_costo.Text = "0" Then
            MsgBox("Esta Orden de Produccion aun no esta programada")
            txtcosto.Text = ""
            cmbcosto.SelectedIndex = -1
            txtc_costo.Text = ""
            cmbc_costo.SelectedIndex = -1
        End If
    End Sub

    Private Sub rdbant_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdbant.CheckedChanged
        If rdbant.Checked Then
            cmbc_costo.Enabled = True
            txtc_costo.Enabled = True
            txtc_costo.Text = ""
            txtcosto.Text = ""
            cmbc_costo.SelectedIndex = -1
            cmbcosto.SelectedIndex = -1
            txtArt.Text = ""
            txtnomart.Text = ""
            txtnroprod.Text = ""
        Else
            cmbc_costo.Enabled = False
            txtc_costo.Enabled = False
        End If
    End Sub

    Private Sub rdbnew_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdbnew.CheckedChanged

        If rdbnew.Checked Then
            cmbc_costo.Enabled = False
            txtc_costo.Enabled = False
            cmbcosto.Enabled = False
            txtcosto.Enabled = False
            txtnroprod.MaxLength = 7
            cmbaño.Visible = True
            cmbaño.Text = sAño
            txtcodart.ReadOnly = True
            cmbuni.Enabled = False
            Button5.Enabled = False
            lblserorden1.Text = "numero"
        Else
            cmbc_costo.Enabled = True
            txtc_costo.Enabled = True
            cmbcosto.Enabled = True
            txtcosto.Enabled = True
            txtnroprod.MaxLength = 9
            cmbaño.Visible = False
            cmbaño.SelectedIndex = -1
            txtcodart.ReadOnly = False
            cmbuni.Enabled = True
            Button5.Enabled = True
            lblserorden1.Text = ""
        End If
    End Sub

    Private Sub cmbcosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcosto.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbcosto.SelectedIndex > -1 Then
            txtcosto.Text = cmbcosto.SelectedValue
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "245"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            txtcosto.Text = gLinea
            cmbcosto.SelectedValue = txtcosto.Text
            gLinea = ""
            gSubLinea = ""
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub rdbant_CheckedChanged(sender As Object, e As EventArgs) Handles rdbant.CheckedChanged
        If rdbant.Checked Then
            cmbc_costo.Enabled = True
            txtc_costo.Enabled = True
        Else
            cmbc_costo.Enabled = False
            txtc_costo.Enabled = False
        End If
    End Sub

    Private Sub txtnroprod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnroprod.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If rdbnew.Checked Then
            If txtc_costo.Enabled = False Then
                gsCode7 = cmbaño.Text
                sBusAlm = "243"
                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                If (gLinea <> Nothing) Then
                    lblserorden.Text = gLinea
                    txtnroprod.Text = gSubLinea
                    gLinea = ""
                    gSubLinea = ""
                End If
            End If
            gLinea = ""
            gSubLinea = ""
            Dim dt As DataTable
            dt = ELPRODUCCIONBL.ProdDatos(cmbaño.Text, txtnroprod.Text)
            For Each Registro In dt.Rows
                txtArt.Text = Trim(IIf(IsDBNull(Registro("cod_art")), "", Registro("cod_art"))) ' cmbart.SelectedValue
                txtnomart.Text = ARTICULOBL.SelectArt2(txtArt.Text)
                txtcantord.Text = Trim(IIf(IsDBNull(Registro("cant_generar")), 0, Registro("cant_generar")))
                txtcantate.Text = Trim(IIf(IsDBNull(Registro("ot_atendido")), 0, Registro("ot_atendido")))
                rdbparcial.Checked = True
            Next

            If txtc_costo.Enabled = False Then
                dt = ELPRODUCCIONBL.LineaProd(txtserdoc.Text, txtnroprod.Text)
                For Each Registro In dt.Rows
                    cmbturno.SelectedIndex = IIf(IsDBNull(Registro("TURNO")), "1", Registro("TURNO"))
                    txtcosto.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                    cmbcosto.SelectedValue = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
                Next
            End If

            dt = ELPRODUCCIONBL.OrdProg(cmbaño.Text, txtnroprod.Text, txtArt.Text)
            For Each Registro In dt.Rows
                txtcosto.Text = Trim(IIf(IsDBNull(Registro("CCO_COD")), 0, Registro("CCO_COD")))
                cmbcosto.SelectedValue = txtcosto.Text
                txtc_costo.Text = Trim(IIf(IsDBNull(Registro("COD_AREA")), 0, Registro("COD_AREA")))
                cmbc_costo.SelectedValue = txtc_costo.Text
            Next

            If txtnroprod.Text <> "" Then
                bPrimero = True
                dt = ELPRODUCCIONBL.SelectArtOP(txtnroprod.Text)
                GetCmb("ART_DESCRI", "ART_COD", dt, ComboBox1)
                ComboBox1.Enabled = True
                txtcodart.Text = ""
                cmblinea.SelectedValue = -1
                cmbsublinea.SelectedValue = -1
                txtcodart.Text = ""
                cmbart.SelectedIndex = -1
                cmblinea.Enabled = False
                cmbart.Enabled = False
                cmbsublinea.Enabled = False
                'txtnomart.Text = ""
                ComboBox1.Visible = True
                bPrimero = False
            End If


        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If bPrimero = False Then
            cmblinea.SelectedValue = Mid(ComboBox1.Text, 1, 2) + "00"
            cmbsublinea.SelectedValue = Mid(ComboBox1.Text, 1, 4)
            txtcodart.Text = ""
            Dim dt As DataTable = ARTICULOBL.SelectArt(cmbsublinea.SelectedValue)
            GetCmb("ART_COD", "ART_DESCRI", dt, cmbart)
            cmbart.SelectedValue = ComboBox1.Text

            txtcodart.Text = ComboBox1.Text
        End If
    End Sub

End Class