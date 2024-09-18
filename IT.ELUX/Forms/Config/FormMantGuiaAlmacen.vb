Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.Net.Mail
Public Class FormMantGuiaAlmacen

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private SOLMATERIALESBL As New SOLMATERIALESBL
    Private DET_DOCUMENTOBL As New DET_DOCUMENTOBL
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBGRUPCORVALBL As New ELTBGRUPCORVALBL
    Private ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Private ELTBCLIENTEBL As New ELTBCLIENTEBL
    Private GUIADESPACHOBL As New GUIADESPACHOBL
    Private flagAccion As String = ""
    Public dtusuario As DataTable
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    Private codalmc As String
    Private sEstado As String
    Private catalogo As String = ""
    Private fechapasada = "Si"
    Private MenuBL As New MenuBL
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Private contador As Integer = "0"
#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region
    Function Art_Guia()
        Dim creacion As String = ""
        For i = 0 To dgvt_doc.Rows.Count - 1
            creacion = creacion & "<tr> <td> Articulo Despachado " & i + 1 & "::<br>
                       " & dgvt_doc.Rows(i).Cells("ART_COD").Value & "</td>
                       <td>" & dgvt_doc.Rows(i).Cells("NOM_ART").Value & " <br>
                       CANTIDAD:" & Val(dgvt_doc.Rows(i).Cells("CANTIDAD").Value) & "<br>
                        UNIDAD:" & Val(dgvt_doc.Rows(i).Cells("UNIDAD").Value) & "<br></td>
                       </tr>"

        Next
        Return creacion

    End Function

    Sub enviarCorreo1()
        contador = contador + 1
        Dim tipo As String
        Dim creacion As String
        Dim creacion1 As String = ""
        Dim creacion2 As String = ""
        'If flagAccion = "N" Then
        creacion1 = Art_Guia()
        If flagAccion = "N" Then
            tipo = " ah creado un NUEVO documento de Despacho"
        Else
            tipo = " ah modificado un documento de Despacho"
        End If

        creacion = "Creacion de Guia de devolución para : " & txtproveedor.Text & "-" & cmbproveedor.Text
        Try
            Dim borde As String = "2"
            Dim size As String = "12"
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.SubjectEncoding = System.Text.Encoding.UTF8
            correos.Body = " Estimados Señores:<br/>
               El usuario " + gsUser + tipo + "<br/>
              <table border= " + borde + "' style='font-size:" + size + "px'>
                <tr>
                    <td>Razon Social</td>
                    <td>" + txtproveedor.Text & "-" & cmbproveedor.Text + "</td>
                </tr>
                <tr>
                    <td>Numero de Guia</td>
                    <td>" + cmb_serdoc.Text & "-" & txtnumero.Text + "</td>
                </tr>
                <tr>
                    <td>Fecha:</td>
                    <td>" + dtpfecha.Value + "</td>
                </tr>
                <tr>
                    <td>Tipo de Movimiento:</td>
                    <td>" + cmbt_movinv.Text + "</td>
                </tr>" + creacion1 + "
                </table>"
            correos.Subject = creacion
            correos.IsBodyHtml = True
            correos.BodyEncoding = System.Text.Encoding.UTF8
            For i = 0 To lstValor.Items.Count - 1
                correos.To.Add(lstValor.Items(i).ToString)
            Next
            ' correos.To.Add("jalama@envaseslux.com")
            correos.To.Add(ELTBCLIENTEBL.SelCliEmailCor(txtproveedor.Text))
            'correos.To.Add(PERBL.SelPerEmailCor(txtvendedor.Text))
            correos.From = New MailAddress("sistemas@envaseslux.com")
            envios.Credentials = New NetworkCredential("sistemas@envaseslux.com", "elsistemas")

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "mail.envaseslux.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cierre(ByVal est As Boolean)
        tsbGrabar.Enabled = est
        ToolStripButton1.Enabled = est
        tsbimprimir.Enabled = est
        If flagAccion = "N" And cmb_serdoc.Text = "002" Then
            txtnumero.Text = ARTICULOBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem, dtpfecha.Value.Year & dtpfecha.Value.Month.ToString.PadLeft(2, "0"))
        End If
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
        Dim date0, date1, date2 As String 'DateTime

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
            MsgBox("Ingrese descripcion el Centro de Costo", MsgBoxStyle.Exclamation)
            txtc_costo.Focus()
            Return False
        End If
        If txtdni.Text = "" Then
            MsgBox("Ingrese la persona encargada de solicitar", MsgBoxStyle.Exclamation)
            txtc_costo.Focus()
            Return False
        End If
        If txtproveedor.Text = "" Then
            MsgBox("Ingrese el proveedor", MsgBoxStyle.Exclamation)
            txtc_costo.Focus()
            Return False
        End If
        If gsUser <> "SISTEMA" Then
            dtpfecha_Validated(Nothing, Nothing)
            If fechapasada = "Si" Then
                Return False
            End If
        End If
        If cmb_serdoc.Text = "T001" Or cmb_serdoc.Text = "001" Then
            MsgBox("No se puede Generar documento ni actualizar con esta serie T001 O 001 ya que es solo para traslados", MsgBoxStyle.Exclamation)
            txtc_costo.Focus()
            Return False
        End If
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("La guia de almacen debe tener al menos un item", MsgBoxStyle.Exclamation)
            Return False
        End If

        If gsUser <> "SISTEMA" Then
            'If dtpfecha.Value.Year > "2022" Then
            If txtt_movinv.Text = "S30" Or txtt_movinv.Text = "E18" Then
                MsgBox("Elija otro movimiento no puede realizar este movimiento")
                Return False
            End If
        End If
        'HABILITAR MES PASADO
        'If DateTime.Now.ToString("MM") <= "04" And gsUser = "HBAZAN" Then
        '    If txtt_movinv.Text <> "E17" Then
        '        MsgBox("No se permite otra transaccion que no sea Reingreso", MsgBoxStyle.Exclamation)
        '        txtt_movinv.Focus()
        '    End If
        'End If

        For i As Integer = 0 To dgvt_doc.Rows.Count - 1
            If "SOLM" = dgvt_doc.Rows(i).Cells("T_DOC_REF1").Value Then
                date1 = dtpfecha.Text
                date0 = dgvt_doc.Rows(i).Cells("FEC_GENE").Value
                date2 = date0.Substring(0, 10)
                If DateTime.Compare(date1, date2) > 0 Then 'dtpfecha.Value < dgvt_doc.Rows(i).Cells("FEC_GENE").Value
                    MsgBox("La fecha de SOLM no puede ser mayor a la guia de almacen", MsgBoxStyle.Exclamation)
                    dgvt_doc.Focus()
                    Return False
                End If
            End If
        Next

        ' Dim ELTBDETGUIABL As New ELTBDETGUIABL
        ' Dim DataFardo As String = 0
        ' Dim CodArt As String = ""
        ' Dim CantArt As String = ""
        ' For l = 0 To dgvt_doc.Rows.Count - 1
        '     CodArt = dgvt_doc.Rows(l).Cells("ART_COD").Value
        '     CantArt = dgvt_doc.Rows(l).Cells("CANTIDAD").Value
        '     If txtt_movinv.Text = "E19" Then
        '         DataFardo = ELTBDETGUIABL.SelectDataFARDO(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, dgvt_doc.Rows(l).Cells("ART_COD").Value)
        '         If DataFardo = 0 Then
        '             MsgBox("Ingrese Fardo al documento", MsgBoxStyle.Exclamation)
        '             Return False
        '         End If
        '     End If
        ' Next
        Return True
    End Function

    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If flagAccion = "M" Then
            'If codalmc <> (cmbalmacen.SelectedIndex + 1).ToString.PadLeft(4, "0") Then
            If codalmc <> cmbalmacen.SelectedValue Then
                If MessageBox.Show("Los Stock se actualizarán al nuevo Almacén desea continuar",
                       gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If
            End If
        End If


        If OkData() = False Then
            Exit Sub
        End If
        Dim nro As String
        If flagAccion = "N" Then
            If cmb_serdoc.SelectedIndex <> 16 Then
                nro = ARTICULOBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
                txtnumero.Text = nro.PadLeft(7, "0")
            End If
        End If
        Dim a As String
        For i = 0 To dgvt_doc.Rows.Count - 1
            dgvt_doc.Rows(i).Cells("UNIDAD").Value = ARTICULOBL.SelectUniMed(Trim(dgvt_doc.Rows(i).Cells("ART_COD").Value))
            If flagAccion = "N" Then
                dgvt_doc.Rows(i).Cells("CANTIDAD4").Value = ARTICULOBL.SelPrecioArt(Trim(dgvt_doc.Rows(i).Cells("ART_COD").Value))
                dgvt_doc.Rows(i).Cells("CANTIDAD5").Value = dgvt_doc.Rows(i).Cells("CANTIDAD4").Value
                dgvt_doc.Rows(i).Cells("CANTIDAD2").Value = dgvt_doc.Rows(i).Cells("CANTIDAD4").Value
            End If
        Next
        Try
            If flagAccion = "N" Then
                Select Case cmb_serdoc.SelectedIndex

                    Case 16 '002
                        'verificar De acuerdo al mes generado.
                        txtnumero.Text = ARTICULOBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem, dtpfecha.Value.Year & dtpfecha.Value.Month.ToString.PadLeft(2, "0"))
                End Select
            End If
            Dim GUIAALMACENBE As New GUIAALMACENBE
            Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
            Dim ELMVALMABE As New ELMVALMABE
            GUIAALMACENBE.T_DOC_REF = RTrim(txtt_doc.Text)
            GUIAALMACENBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
            GUIAALMACENBE.NRO_DOC_REF = RTrim(txtnumero.Text)
            GUIAALMACENBE.ART_COD = "02170001"
            GUIAALMACENBE.FEC_GENE = RTrim(dtpfecha.Value)
            GUIAALMACENBE.T_MOVINV = RTrim(txtt_movinv.Text)
            GUIAALMACENBE.F_PAGO_ENT = RTrim(txtt_pago.Text)
            GUIAALMACENBE.FOR_ENT_COD = RTrim(txtfor_ent.Text)
            If cmbestado.SelectedIndex = 0 Then
                GUIAALMACENBE.EST = "H"
            ElseIf cmbestado.SelectedIndex = 1 Then
                GUIAALMACENBE.EST = "A"
            ElseIf cmbestado.SelectedIndex = 2 Then
                GUIAALMACENBE.EST = "P"
            ElseIf cmbestado.SelectedIndex = 3 Then
                GUIAALMACENBE.EST = "T"
            ElseIf cmbestado.SelectedIndex = 4 Then
                GUIAALMACENBE.EST = "S"
            ElseIf cmbestado.SelectedIndex = 5 Then
                GUIAALMACENBE.EST = "V"
            ElseIf cmbestado.SelectedIndex = -1 Then
                GUIAALMACENBE.EST = ""
            End If

            If cmbestado.SelectedIndex = 1 Then
                GUIAALMACENBE.FEC_ANU = dtpfanul.Value
            Else
                GUIAALMACENBE.FEC_ANU = Nothing
            End If
            If cmbalmac.SelectedIndex = -1 Then
                GUIAALMACENBE.ALMAC = ""
            ElseIf cmbalmac.SelectedIndex = 0 Then
                GUIAALMACENBE.ALMAC = "E"
            ElseIf cmbalmac.SelectedIndex = 1 Then
                GUIAALMACENBE.ALMAC = "S"
            ElseIf cmbalmac.SelectedIndex = 2 Then
                GUIAALMACENBE.ALMAC = "D"
            ElseIf cmbalmac.SelectedIndex = 3 Then
                GUIAALMACENBE.ALMAC = "P"
            ElseIf cmbalmac.SelectedIndex = 4 Then
                GUIAALMACENBE.ALMAC = "T"
            End If
            GUIAALMACENBE.OBSERVA1 = txtobserva1.Text
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
            GUIAALMACENBE.NOM_CTCT = cmbproveedor.Text
            GUIAALMACENBE.USUARIO = RTrim(gsUser)
            DET_DOCUMENTOBE.ALM_COD = (cmbalmacen.SelectedIndex + 1).ToString.PadLeft(4, "0")
            GUIAALMACENBE.ALM_COD = cmbalmacen.SelectedValue
            DET_DOCUMENTOBE.T_DOC_REF = txtt_doc.Text
            DET_DOCUMENTOBE.SER_DOC_REF = cmb_serdoc.Text
            DET_DOCUMENTOBE.NRO_DOC_REF = txtnumero.Text
            DET_DOCUMENTOBE.TRATAMIENTO = codalmc
            If chk_m.Checked Then
                GUIAALMACENBE.X_M = "1"
            End If

            Dim ELMVLOGSBE As New ELMVLOGSBE
            Dim ELPRODUCCIONBE As New ELPRODUCCIONBE
            Dim ELORDEN_PROGRAMBE As New ELORDEN_PROGRAMBE
            Dim SOLMATERIALESBE As New SOLMATERIALESBE
            ELMVLOGSBE.log_codusu = gsCodUsr
            Dim c As Integer = 0
            Dim d As String = dtpfecha.Value.Year
            For i = 0 To dgvt_doc.Rows.Count - 1
                'c = 0
                If dgvsum.Rows.Count = 0 Then
                    dgvsum.Rows.Add(dgvt_doc.Rows(i).Cells("T_DOC_REF").Value,
                                dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value,
                                dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value,
                                dgvt_doc.Rows(i).Cells("ART_COD").Value,
                                0,
                                txtt_movinv.Text,
                                Mid(txtt_movinv.Text, 1, 1),
                                d,
                                dtpfecha.Value,
                                DET_DOCUMENTOBE.ALM_COD)
                Else
                    For j = 0 To dgvsum.Rows.Count - 1
                        c = 0
                        If dgvt_doc.Rows(i).Cells("ART_COD").Value = dgvsum.Rows(j).Cells("ART_COD").Value Then
                            c = c + 1
                        End If
                    Next
                    If c = 0 Then
                        dgvsum.Rows.Add(dgvt_doc.Rows(i).Cells("T_DOC_REF").Value,
                               dgvt_doc.Rows(i).Cells("SER_DOC_REF").Value,
                               dgvt_doc.Rows(i).Cells("NRO_DOC_REF").Value,
                               dgvt_doc.Rows(i).Cells("ART_COD").Value,
                               0,
                               txtt_movinv.Text,
                               Mid(txtt_movinv.Text, 1, 1),
                               d, dtpfecha.Value,
                                DET_DOCUMENTOBE.ALM_COD)
                    End If
                End If
            Next
            'c = 0
            For i = 0 To dgvsum.Rows.Count - 1
                c = 0
                For j = 0 To dgvt_doc.Rows.Count - 1
                    If dgvt_doc.Rows(j).Cells("ART_COD").Value = dgvsum.Rows(i).Cells("ART_COD").Value Then
                        c = c + dgvt_doc.Rows(j).Cells("CANTIDAD").Value
                    End If
                Next
                dgvsum.Rows(i).Cells("CANTIDAD").Value = c
            Next
            Dim nro1 As String
            If flagAccion = "N" Then
                If txtt_movinv.Text = "E18" Or txtt_movinv.Text = "S30" Then
                    If cmb_serdoc.SelectedIndex <> 16 Then
                        nro1 = ARTICULOBL.SelectNro(txtt_doc.Text, "T001")
                        For i = 0 To dgvt_doc.Rows.Count - 1
                            dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value = nro1.PadLeft(7, "0")
                            dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value = "T001"
                        Next
                    Else
                        MsgBox("Cambie la serie del documento")
                        Exit Sub
                    End If
                    gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "TRANS", dgvt_doc, "T001", nro1.PadLeft(7, "0"))
                    If gsError = "OK" Then

                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Grabar Transferencia", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            Else
                If txtt_movinv.Text = "E18" Or txtt_movinv.Text = "S30" Then
                    gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "TRANS", dgvt_doc, "T001", dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value)
                    If gsError = "OK" Then

                    Else
                        FormMain.LblError.Text = gsError
                        MsgBox("Error al Grabar Transferencia", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If
            If chk_m.Visible = True Then
                If flagAccion = "N" Then
                    gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "CN", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
                Else
                    gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "CM", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
                End If
            Else
                gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, flagAccion, dgvt_doc, cmb_serdoc.Text, sEstAlmac)
            End If
            If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                Dim GUIADESPACHOBE As New GUIADESPACHOBE
                gsError = GUIADESPACHOBL.SaveRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, "TOT", dgvsum, cmb_serdoc.Text, sEstAlmac, dtusuario)
                Dim cnts As Double = 0
                For z = 0 To dgvt_doc.Rows.Count - 1
                    If dgvt_doc.Rows(z).Cells("T_DOC_REF1").Value = "SOLM" Then
                        SOLMATERIALESBE.SER_DOC_REF = dgvt_doc.Rows(z).Cells("SER_DOC_REF1").Value
                        SOLMATERIALESBE.NRO_DOC_REF = dgvt_doc.Rows(z).Cells("NRO_DOC_REF1").Value
                        gsError = SOLMATERIALESBL.UpdRow(SOLMATERIALESBE, flagAccion)
                    End If
                Next
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
                lstValor.Items.Clear()
                'sArt_Cod = IIf(IsDBNull(RTrim(row.Cells("ART_COD").Value)), "", RTrim(row.Cells("ART_COD").Value))
                If txtt_movinv.Text = "S28" Then
                    ELTBGRUPCORVALBL.SelectRow("0007", lstValor)
                    enviarCorreo1()
                End If
                flagAccion = "M"

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
        Dim mes As String
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
                If txtt_movinv.Text = "S30" Or txtt_movinv.Text = "E18" Then
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VALE_TRASLADO.rpt"
                Else
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VALE.rpt"
                End If

                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "anular"
                If sEstado = "A" Then
                    MsgBox("Este documento ya se encuentra anulado")
                    Exit Sub
                End If

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
                If cmbalmac.SelectedIndex = -1 Then
                    GUIAALMACENBE.ALMAC = ""
                ElseIf cmbalmac.SelectedIndex = 0 Then
                    GUIAALMACENBE.ALMAC = "E"
                ElseIf cmbalmac.SelectedIndex = 1 Then
                    GUIAALMACENBE.ALMAC = "S"
                ElseIf cmbalmac.SelectedIndex = 2 Then
                    GUIAALMACENBE.ALMAC = "D"
                ElseIf cmbalmac.SelectedIndex = 3 Then
                    GUIAALMACENBE.ALMAC = "P"
                ElseIf cmbalmac.SelectedIndex = 4 Then
                    GUIAALMACENBE.ALMAC = "T"
                End If
                GUIAALMACENBE.ALM_COD = cmbalmacen.SelectedValue
                GUIAALMACENBE.T_MOVINV = txtt_movinv.Text
                GUIAALMACENBE.OBSERVA2 = dtpfecha.Value.Year
                GUIAALMACENBE.FEC_GENE = dtpfecha.Text
                Dim ELMVLOGSBE As New ELMVLOGSBE
                Dim GUIADESPACHOBE As New GUIADESPACHOBE
                ELMVLOGSBE.log_codusu = gsCodUsr

                'verificar mes para anulacion
                'If sAño - dtpfecha.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfecha.Value.Month = "12" Then
                gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "A", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dim c As Integer = 0
                    Dim d As String = dtpfecha.Value.Year
                    For j = 0 To dgvt_doc.Rows.Count - 1
                        dgvsum.Rows.Add(dgvt_doc.Rows(j).Cells("T_DOC_REF").Value,
                                dgvt_doc.Rows(j).Cells("SER_DOC_REF").Value,
                                dgvt_doc.Rows(j).Cells("NRO_DOC_REF").Value,
                                dgvt_doc.Rows(j).Cells("ART_COD").Value)
                    Next
                    'c = 0

                    gsError = GUIADESPACHOBL.SaveRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, "ET", dgvsum, cmb_serdoc.Text, sEstAlmac, dtusuario)
                    cmb_serdoc.Enabled = False
                    sEstAlmac = cmbalmac.SelectedValue
                    Me.btnborrar.Enabled = False
                    Me.btndocu.Enabled = False
                    Me.btnagregar.Enabled = False
                    Dim i As Integer
                    For i = 0 To 44
                        dgvt_doc.Columns(i).ReadOnly = True
                    Next
                    sEstado = "A"
                    'Dispose()
                    Exit Sub
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
                'End If
                'If DateTime.Now.ToString("MM") <> dtpfecha.Value.Month Then
                '    If dtpfecha.Value.Month > DateTime.Now.ToString("MM") Then
                '        dtpfecha.Select()
                '        MsgBox("El mes es mayor al permitido")
                '        cierre(False)
                '        Exit Sub
                '    ElseIf dtpfecha.Value.Month < DateTime.Now.ToString("MM") Then
                '        'If CInt(sMes1) > dtpfecha.Value.Month Then
                '        mes = DateTime.Now.ToString("MM") - dtpfecha.Value.Month
                '        If mes = 1 Then
                '            'Modificacion de de fechas 
                '            If DateTime.Now.ToString("dd") > 11 Then
                '                MsgBox("Mes Cerrado")
                '                cierre(False)
                '                Exit Sub
                '            Else
                'gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "A", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
                '            End If
                '        ElseIf mes > 1 Then
                '            dtpfecha.Select()
                '            MsgBox("El mes es mayor al permitido")
                '            cierre(False)
                '            Exit Sub
                '        End If
                '        'End If
                '    End If
                'Else
                'gsError = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "A", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
                'End If
                'If gsError = "OK" Then
                '    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                '    cmb_serdoc.Enabled = False
                '    sEstAlmac = cmbalmac.SelectedValue
                '    Me.btnborrar.Enabled = False
                '    Me.btndocu.Enabled = False
                '    Me.btnagregar.Enabled = False
                '    Dim i As Integer
                '    For i = 0 To 44
                '        dgvt_doc.Columns(i).ReadOnly = True
                '    Next
                '    sEstado = "A"
                '    'Dispose()
                'Else
                '    FormMain.LblError.Text = gsError
                '    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                'End If
                'Exit Sub
        End Select
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim dt As DataTable
        Dim Registro As DataRow
        Dim anulfech As Boolean
        If txtnumero.Text = "0002996" And txtt_doc.Text = "SALM" And cmb_serdoc.SelectedItem = "001" Then
            MsgBox("Favor de elejir otro numero para este documento")
            Exit Sub
        End If
        dtUsuario = GUIAALMACENBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmbt_doc.SelectedValue = txtt_doc.Text
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            anulfech = IIf(IsDBNull(Registro("FEC_ANU")), False, True)
            'If IIf(IsDBNull(Registro("X_M")), "", Registro("X_M")) = "1" Then
            '    chk_m.Visible = True
            '    chk_m.Checked = True
            'End If
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
            Select Case Registro("ALMAC").ToString
                Case ""
                    cmbalmac.SelectedIndex = -1
                Case "E"
                    cmbalmac.SelectedIndex = 0
                Case "S"
                    cmbalmac.SelectedIndex = 1
                Case "D"
                    cmbalmac.SelectedIndex = 2
                Case "P"
                    cmbalmac.SelectedIndex = 3
                Case "T"
                    cmbalmac.SelectedIndex = 4
            End Select

            'dtpfanul.Checked = IIf(IsDBNull(Registro("EST")), "", IsDBNull(Registro("EST")))
            If cmbestado.SelectedIndex = 1 Then
                dtpfanul.Checked = True
                dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            End If
            'cmbestado.Text = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))
            txtt_movinv.Text = IIf(IsDBNull(Registro("T_MOVINV")), "", Registro("T_MOVINV"))
            cmbt_movinv.SelectedValue = txtt_movinv.Text
            If txtt_movinv.Text = "E19" Then
                Me.chk_m.Visible = True
            End If
            If IIf(IsDBNull(Registro("X_M")), "", Registro("X_M")) = "1" Then
                Me.chk_m.Checked = True
            End If
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
            Dim alms As String = IIf(IsDBNull(Registro("ALM_COD")), "", Registro("ALM_COD"))
            cmbalmacen.SelectedValue = alms
            If cmbestado.SelectedIndex = 1 Then
                sEstado = "A"
            ElseIf cmbestado.SelectedIndex = 0 Then
                sEstado = "H"
            End If
        Next
    End Sub

    Private Sub FormMantGuiaAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtt_doc.Select()
        bPrimero = True
        gsError = ""
        Dim contador1 As Integer = 0
        Dim sValor As String = ""
        gpCaption = "Guia de Almacen"
        Me.Text = gpCaption
        'Cargar los combos

        Dim dt As DataTable = GUIAALMACENBL.SelectT_DOC("SALM")
        GetCmb("cod", "nom", dt, cmbt_doc)
        dt = GUIAALMACENBL.SelectT_MOVINV("SALM")
        GetCmb("cod", "nom", dt, cmbt_movinv)
        dt = GUIAALMACENBL.SelectF_PAGO
        GetCmb("cod", "nom", dt, cmbt_pago)
        dt = GUIAALMACENBL.SelectF_ENT
        GetCmb("cod", "nom", dt, cmbfor_ent)
        dt = GUIAALMACENBL.SelectMoneda
        GetCmb("cod", "nom", dt, cmbmon)
        cmbmon.SelectedIndex = 1
        txtmon.Text = "01"
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)
        dt = GUIAALMACENBL.SelectPer
        GetCmb("cod", "nombre", dt, cmbdni)
        dt = GUIAALMACENBL.SelectProv
        GetCmb("cod", "nom", dt, cmbproveedor)
        dt = GUIAALMACENBL.SelectAlmac("N")
        GetCmb("ALM_CODIGO", "ALM_DESCRI", dt, cmbalmacen)
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

        dgvt_doc.Columns.Add("ART_COD2", "Cod. Art.2") '45 - 10

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
        dgvt_doc.Columns.Add("TDOC", "TDOC") '45
        dgvt_doc.Columns.Add("SDOC", "SDOC") '46
        dgvt_doc.Columns.Add("NDOC", "NDOC") '47

        dgvt_doc.Columns.Add("FEC_ENT", "Fec. Vcto") '10 - 48

        dgvt_doc.Columns.Add("ART_VENTA", "Activos 2") '49
        dgvt_doc.Columns.Add("cantidad3", "cantidad3") '50
        dgvt_doc.Columns.Add("CANTIDAD2", "CANTIDAD2") '51
        dgvt_doc.Columns.Add("CANTIDAD4", "CANTIDAD4") '52
        dgvt_doc.Columns.Add("CANTIDAD5", "CANTIDAD5") '53
        dgvt_doc.Columns.Add("SUGERENCIA", "SUGERENCIA") '54

        '------------------------------------------
        dgvsum.Columns.Add("T_DOC_REF", "Documento")
        dgvsum.Columns.Add("SER_DOC_REF", "Serie")
        dgvsum.Columns.Add("NRO_DOC_REF", "Numero")
        dgvsum.Columns.Add("ART_COD", "Articulo")
        dgvsum.Columns.Add("CANTIDAD", "Cantidad")
        dgvsum.Columns.Add("T_MOVINV", "T_MOVINV")
        dgvsum.Columns.Add("TRANS", "TRANS")
        dgvsum.Columns.Add("ANHO", "ANHO")
        dgvsum.Columns.Add("FEC_GENE", "FEC_GENE")
        dgvsum.Columns.Add("ALM_COD", "ALM_COD")

        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                habilitar(False)
                bTercero = "1"
                bCuarto = "1"
                Me.txtt_doc.Text = "SALM"
                cmbalmacen.SelectedIndex = 0
                If gsUser <> "ZSEBASTIAN" Then
                    txtt_movinv.Text = "E12"
                    cmbt_movinv.SelectedValue = "E12"
                    cmbalmac.SelectedIndex = 0
                End If

                txtproveedor.Text = "155729857-2-2022"
                cmbproveedor.SelectedValue = "155729857-2-2022"
            Case 1
                flagAccion = "M"
                GetData("SALM", sSDoc, sNDoc)
                bCuarto = "1"
                cmb_serdoc.Enabled = False
                'codalmc = (cmbalmacen.SelectedIndex + 1).ToString.PadLeft(4, "0")
                codalmc = cmbalmacen.SelectedValue
                Dim dtArticulo As DataTable

                dtArticulo = GUIAALMACENBL.getListdgv("SALM", sSDoc, sNDoc)
                For Each row As DataRow In dtArticulo.Rows
                    contador1 = contador1 + 1
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
                                      IIf(IsDBNull(row("ART_COD1")), "", row("ART_COD1")),
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
                                      IIf(IsDBNull(row("COD_NUEVO")), "", row("COD_NUEVO")),'43
                                      IIf(IsDBNull(row("EST")), "", row("EST")),'44
                                      IIf(IsDBNull(row("TIPO_UNIDAD")), "", row("TIPO_UNIDAD")),'45
                                      IIf(IsDBNull(row("CONFIGURACION")), "", row("CONFIGURACION")),'46
                                      IIf(IsDBNull(row("COMENTARIO")), "", row("COMENTARIO")),'47
                                      IIf(IsDBNull(row("FEC_ENT")), "", row("FEC_ENT")),'48
                                      IIf(IsDBNull(row("ART_VENTA")), "", row("ART_VENTA")), '49
                                      IIf(IsDBNull(row("CANTIDAD3")), "", row("CANTIDAD3")), '50
                                      IIf(IsDBNull(row("CANTIDAD2")), "", row("CANTIDAD2")), '51
                                      IIf(IsDBNull(row("CANTIDAD4")), "", row("CANTIDAD4")), '52
                                      IIf(IsDBNull(row("CANTIDAD5")), "", row("CANTIDAD5")), '53
                                      IIf(IsDBNull(row("SUGERENCIA")), "", row("SUGERENCIA"))) '54
                Next
                Dim i As Integer
                For i = 0 To 44
                    If i <> 34 Then
                        dgvt_doc.Columns(i).ReadOnly = True
                    End If
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
                'agregado ultimo 23/05/2019
                Me.cmbestado.Enabled = False

                Fardo()
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
        dgvt_doc.Columns(46).Visible = False
        dgvt_doc.Columns(47).Visible = False
        dgvt_doc.Columns(48).Visible = False
        dgvt_doc.Columns(49).Visible = False
        dgvt_doc.Columns(50).Visible = False
        dgvt_doc.Columns(51).Visible = False
        dgvt_doc.Columns(52).Visible = False
        dgvt_doc.Columns(53).Visible = False
        dgvt_doc.Columns(54).Visible = False
        'dgvt_doc.Columns(45).Visible = False
        'dgvt_doc.Columns(47).Visible = False
        bPrimero = False
        If flagAccion = "M" Then
            If dgvt_doc.Rows.Count > 0 Then
                For i = 0 To dgvt_doc.Rows.Count - 1
                    If dgvt_doc.Rows(i).Cells("T_DOC_REF1").Value = "SOLM" Then
                        cmbc_costo.Enabled = False
                        txtc_costo.ReadOnly = True
                        Exit Sub
                    End If
                Next
            End If
        End If

        'PROVISIONAL

        'txtt_doc.Text = "SALM"
        'cmbt_doc.SelectedIndex = 0
        'dtpfecha.Value = "20/10/2023"
        'txtt_movinv.Text = "S24"

        'cmbt_movinv.SelectedIndex = 20
        'cmb_serdoc.SelectedIndex = 0
        'txtc_costo.Text = "101"
        'txtdni.Text = "72765782"
        'txtobservacion.Text = "AJUSTE DE INVENTARIO AL 20-10"
    End Sub



    Private Sub Fardo()
        If txtt_movinv.Text = "E19" Then
            btnFardo.Enabled = True
        Else
            btnFardo.Enabled = False
        End If
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
                txtt_pago.Text = "08"
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
        If (txtt_movinv.Text = "E18" Or txtt_movinv.Text = "S30") Then
            btndocu.Visible = False
        Else
            btndocu.Visible = True
        End If
        Fardo()
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
#End Region


    Private Sub FormMantRequerimiento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        sEstAlmac = cmbestado.SelectedItem
        contcant = 0
        Dispose()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'if dgvt_doc.CurrentCell.
        'Dim frm As New FormMantDetGuiaAlmacen
        'gContador = 1
        'frm.ShowDialog()
        If txtt_movinv.Text = "E12" Then
            MsgBox("No se puede ingresar articulos con este tipo de documento solo se puede documentar")
            Exit Sub
        End If

        If txtt_movinv.Text = "E18" Or txtt_movinv.Text = "S30" Then
            Dim frm As New FormMantDetGuiaAlmacenTrans
            gContador = 1
            frm.ShowDialog()
        Else

            Dim frm As New FormMantDetGuiaAlmacen
            frm.Label9.Text = txtt_movinv.Text
            gContador = 1
            frm.lbltmov.Text = txtt_movinv.Text
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If dgvt_doc.Rows.Count > 0 Then

            If txtt_movinv.Text = "E18" Or txtt_movinv.Text = "S30" Then
                Dim frm As New FormMantDetGuiaAlmacenTrans
                gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(8).Value
                sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(7).Value
                frm.txtlote.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(36).Value
                frm.txtcodart.Text = gsCode3
                frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value
                frm.txtcodartdos.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD2").Value
                frm.lblundtrans.Text = ARTICULOBL.SelectUniMed(Mid(frm.txtcodartdos.Text, 1, 8))
                If frm.npdcantidad2.Value > 0 Then
                    frm.npdcantidad2.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("cantidad3").Value
                    frm.npdcantidad2.Visible = False
                    frm.Label10.Visible = False
                Else
                    frm.npdcantidad2.Value = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("cantidad3").Value)
                    If frm.lblundtrans.Text <> dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value Then
                        frm.npdcantidad2.Visible = True
                        frm.npdcantidad2.Enabled = True
                        frm.Label10.Visible = True
                    End If
                End If

                If flagAccion = "M" Then
                    frm.btnagregar.Enabled = False
                End If
                gContador = 0

                frm.ShowDialog()
            Else
                Dim frm As New FormMantDetGuiaAlmacen
                Dim Tip1 As String
                gsCode3 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(8).Value
                sUni = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(29).Value
                frm.npdcantidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(7).Value
                frm.txtlote.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(36).Value
                frm.txtcodart.Text = gsCode3
                frm.lbltmov.Text = txtt_movinv.Text
                frm.txttdoc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TDOC").Value
                frm.txtsdoc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SDOC").Value
                frm.txtndoc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NDOC").Value
                frm.txtobservacion.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(16).Value
                If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(3).Value = "RPD" Then
                    frm.txtcodart.Enabled = False
                    frm.npdcantidad.Enabled = False
                    frm.cmbart.Enabled = False
                    frm.btnbuscar.Enabled = False
                End If
                If flagAccion = "M" Then
                    frm.btnagregar.Enabled = False
                End If
                gContador = 0
                Tip1 = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value
                If Tip1 = "SOLM" Or Tip1 = "RPD" Or Tip1 = "RFAL" Or Tip1 = "REIN" Or Tip1 = "RPD" Then
                Else
                    frm.cmblinea.Enabled = False
                    frm.cmbsublinea.Enabled = False
                    frm.txtcodart.Enabled = False
                    frm.cmbart.Enabled = False
                    frm.btnbuscar.Enabled = False
                End If
                frm.ShowDialog()
            End If
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        sest1 = cmbalmac.SelectedItem
        Dim frm As New FormDocuRef
        If Mid(txtt_movinv.Text, 1, 1) = "S" Then
            sMov = "0"
            sCos = txtc_costo.Text
        End If
        gsCode = "0"


        If txtt_movinv.Text = "E12" Or txtt_movinv.Text = "E26" Or txtt_movinv.Text = "E17" Then  'E17 agregado 22/05/2021
            gsCode = "4"
            'sMov = "0"
            'sCos = txtc_costo.Text
            If txtc_costo.Text = "" Then
                MsgBox("Debe Seleccionar un Centro de Costo para buscar")
                Exit Sub
            End If
        End If


        frm.ShowDialog()
        sMov = ""
        If dgvt_doc.Rows.Count > 0 Then
            For i = 0 To dgvt_doc.Rows.Count - 1
                If dgvt_doc.Rows(i).Cells("T_DOC_REF1").Value = "SOLM" Then
                    cmbc_costo.Enabled = False
                    txtc_costo.ReadOnly = True
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Dim c As Integer = 0
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
            If dgvt_doc.Rows.Count > 0 Then
                For i = 0 To dgvt_doc.Rows.Count - 1
                    If dgvt_doc.Rows(i).Cells("T_DOC_REF1").Value = "SOLM" Then
                        c = c + 1
                    End If
                Next
            End If
            If c = 0 Then
                txtc_costo.Text = ""
                txtc_costo.ReadOnly = False
                cmbc_costo.SelectedIndex = -1
                cmbc_costo.Enabled = True
            End If
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub txtnumero_CursorChanged(sender As Object, e As EventArgs) Handles txtnumero.CursorChanged
        habilitar(True)
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
        If Mid(txtt_movinv.Text, 1, 1) = "E" Then
            cmbalmac.SelectedIndex = 0
        ElseIf Mid(txtt_movinv.Text, 1, 1) = "S" Then
            cmbalmac.SelectedIndex = 1
        End If

        Fardo()
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
            If cmb_serdoc.SelectedIndex <> 16 Then
                nro = ARTICULOBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
                txtnumero.Text = nro.PadLeft(7, "0")
            End If

            Select Case cmb_serdoc.SelectedIndex
                Case 16 '002
                    'verificar De acuerdo al mes generado.
                    txtnumero.Text = ARTICULOBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem, gsMes)
            End Select
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "1"
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


    Private Sub dtpfecha_Validated(sender As Object, e As EventArgs) Handles dtpfecha.Validated

        Dim dtCierre As New DataTable
        Dim modulo As String = "ALMACEN"
        Dim mesCierre As String = dtpfecha.Value.ToString("MM")
        Dim anhoCierre As String = dtpfecha.Value.Year
        dtCierre = GUIAALMACENBL.VerificarCierre(modulo, mesCierre, anhoCierre)
        If dtCierre.Rows.Count = 0 Then
            MsgBox("MES CERRADO PARA REGISTRO DE DOCUMENTOS")
            dtpfecha.Select()
            Exit Sub
        Else
            If dtCierre.Rows(0).Item(0) = "1" Then
                MsgBox("MES CERRADO PARA REGISTRO DE DOCUMENTOS")
                dtpfecha.Select()
                Exit Sub

            End If
        End If
        'Dim mes As String
        'If sAño - dtpfecha.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfecha.Value.Month = "12" Then
        '    If DateTime.Now.ToString("dd") > 12 Then
        '        MsgBox("Mes Cerrado")
        '        cierre(False)
        '        Exit Sub
        '    End If

        '    'End If
        'Else
        '    If sAño > dtpfecha.Value.Year Or sAño < dtpfecha.Value.Year Then
        '        dtpfecha.Select()
        '        MsgBox("El año es mayor o menor al año actual")
        '        cierre(False)
        '        Exit Sub
        '    End If
        '    'abrir mes de julio
        '    'If dtpfecha.Value.Month = "07" Then
        '    'Else

        '    If DateTime.Now.ToString("MM") <> dtpfecha.Value.Month Then
        '        'MsgBox(DateTime.Now.ToString("MM"))
        '        If dtpfecha.Value.Month > DateTime.Now.ToString("MM") Then
        '            dtpfecha.Select()
        '            MsgBox("El mes es mayor al permitido")
        '            cierre(False)
        '            Exit Sub
        '        ElseIf dtpfecha.Value.Month < DateTime.Now.ToString("MM") Then
        '            'If CInt(sMes1) > dtpfecha.Value.Month Then
        '            mes = DateTime.Now.ToString("MM") - dtpfecha.Value.Month
        '            If mes = 1 Then
        '                'Modificacion de de fechas 
        '                'If DateTime.Now.ToString("dd") > 14 Then
        '                If DateTime.Now.ToString("dd") > 12 Then
        '                    MsgBox("Mes Cerrado")
        '                    cierre(False)
        '                    Exit Sub
        '                End If
        '            ElseIf mes > 1 Then
        '                dtpfecha.Select()
        '                MsgBox("El mes es mayor al permitido")
        '                cierre(False)
        '                Exit Sub
        '            End If
        '            'End If
        '        End If

        '    End If
        '    If CInt(sMes1) < dtpfecha.Value.Month Then
        '        dtpfecha.Select()
        '        MsgBox("El mes es menor al permitido")
        '        cierre(False)
        '        Exit Sub
        '    ElseIf CInt(sMes1) > dtpfecha.Value.Month Then
        '        mes = sMes1 - dtpfecha.Value.Month
        '        If mes = 1 Then
        '            'Modificacion de de fechas 
        '            'If DateTime.Now.ToString("dd") > 14 Then
        '            If DateTime.Now.ToString("dd") > 12 Then
        '                MsgBox("Mes Cerrado")
        '                cierre(False)
        '                Exit Sub
        '            End If
        '        ElseIf mes > 1 Then
        '            dtpfecha.Select()
        '            MsgBox("El mes es mayor al permitido")
        '            cierre(False)
        '            Exit Sub
        '        End If
        '    End If
        '    'End If
        'End If

        'cierre(True)
        Dim mes As String
        'If gsUser <> "DSANDOVAL" And gsUser <> "SISTEMA" Then
        '    If sAño - dtpfecha.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfecha.Value.Month = "12" Then
        '        If gsUser = "LVERGARA" Then
        '            If DateTime.Now.ToString("dd") > "09" Then
        '                MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '                cierre(False)
        '                fechapasada = "Si"
        '                Exit Sub
        '            End If
        '        Else
        '            If DateTime.Now.ToString("dd") > "09" Then
        '                MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '                cierre(False)
        '                fechapasada = "Si"
        '                Exit Sub
        '            End If
        '        End If
        '    Else
        '        'If dtpfecha.Value.Month = "06" Then ' abre mes


        '        'Else
        '        If sAño > dtpfecha.Value.Year Or sAño < dtpfecha.Value.Year Then
        '            dtpfecha.Select()
        '            MsgBox("El año es mayor o menor al año actual", MsgBoxStyle.Information)
        '            cierre(False)
        '            fechapasada = "Si"
        '            Exit Sub
        '        End If


        '        'Else
        '        If sAño > dtpfecha.Value.Year Or sAño < dtpfecha.Value.Year Then
        '            dtpfecha.Select()
        '            MsgBox("El año es mayor o menor al año actual", MsgBoxStyle.Information)
        '            cierre(False)
        '            fechapasada = "Si"
        '            Exit Sub
        '        End If


        '        If DateTime.Now.ToString("MM") <> dtpfecha.Value.Month Then
        '            If dtpfecha.Value.Month > DateTime.Now.ToString("MM") Then
        '                dtpfecha.Select()
        '                MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
        '                cierre(False)
        '                fechapasada = "Si"
        '                Exit Sub
        '            ElseIf dtpfecha.Value.Month < DateTime.Now.ToString("MM") Then
        '                'If CInt(sMes1) > dtpfecha.Value.Month Then
        '                mes = DateTime.Now.ToString("MM") - dtpfecha.Value.Month
        '                If mes = 1 Then
        '                    'Modificacion de de fechas 
        '                    'If DateTime.Now.ToString("dd") > 14 Then
        '                    If gsUser = "LVERGARA" Then
        '                        If DateTime.Now.ToString("dd") > "09" Then
        '                            MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '                            cierre(False)
        '                            fechapasada = "Si"
        '                            Exit Sub
        '                        End If
        '                    Else
        '                        If DateTime.Now.ToString("dd") > "09" Then
        '                            MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '                            cierre(False)
        '                            fechapasada = "Si"
        '                            Exit Sub
        '                        End If
        '                    End If

        '                ElseIf mes > 1 Then
        '                    dtpfecha.Select()
        '                    MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
        '                    cierre(False)
        '                    fechapasada = "Si"
        '                    Exit Sub
        '                End If
        '                'End If
        '            End If

        '        End If
        '        If CInt(sMes2) < dtpfecha.Value.Month Then
        '            dtpfecha.Select()
        '            MsgBox("El mes es menor al permitido", MsgBoxStyle.Information)
        '            cierre(False)
        '            fechapasada = "Si"
        '            Exit Sub
        '        ElseIf CInt(sMes2) > dtpfecha.Value.Month Then
        '            mes = sMes2 - dtpfecha.Value.Month
        '            If mes = 1 Then
        '                'Modificacion de de fechas 
        '                'If DateTime.Now.ToString("dd") > 14 Then
        '                If gsUser = "LVERGARA" Then
        '                    If DateTime.Now.ToString("dd") > "09" Then
        '                        MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '                        cierre(False)
        '                        fechapasada = "Si"
        '                        Exit Sub
        '                    End If
        '                Else
        '                    If DateTime.Now.ToString("dd") > "09" Then
        '                        MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '                        cierre(False)
        '                        fechapasada = "Si"
        '                        Exit Sub
        '                    End If
        '                End If

        '            ElseIf mes > 1 Then
        '                dtpfecha.Select()
        '                MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
        '                cierre(False)
        '                fechapasada = "Si"
        '                Exit Sub
        '            End If
        '        End If
        '    End If
        'End If
        ''If gsUser = "HBAZAN" Then
        ''    If sAño < dtpfecha.Value.Year Then
        ''        dtpfecha.Select()
        ''        MsgBox("El año es mayor o menor al año actual", MsgBoxStyle.Information)
        ''        cierre(False)
        ''        fechapasada = "Si"
        ''        Exit Sub
        ''    End If
        ''    txtt_movinv.Text = "E17"
        ''    cmbt_movinv.SelectedValue = "E17"
        ''End If
        ''termina el if del mes que se abrio
        ''End If
        'cierre(True)
        fechapasada = "No"
    End Sub

    Private Sub btnFardo_Click(sender As Object, e As EventArgs) Handles btnFardo.Click
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormELTBDETGUIA
            frm.lblTipo.Text = txtt_doc.Text
            frm.lblSer.Text = cmb_serdoc.Text
            frm.lblnro.Text = txtnumero.Text
            frm.lblArt.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
            frm.lblCant.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
            frm.npdcantidad.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
            frm.dtpfecha.Value = dtpfecha.Value
            frm.lblFecGen.Text = dtpfecha.Value
            frm.ShowDialog()
        Else
            MsgBox("No hay items en la lista")
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnRotulo_Click(sender As Object, e As EventArgs) Handles btnRotulo.Click
        Dim frm As New FormEtiquetas

        If dgvt_doc.Rows.Count > 0 Then
            gsCode5 = dgvt_doc.CurrentRow.Index
            flagAccion1 = "M"
            frm.TabPage1.Enabled = False
            frm.TabPage2.Enabled = False
            frm.TabPage3.Enabled = False
            frm.TabPage4.Enabled = False
            frm.TabPage5.Enabled = False
            frm.TabPage6.Enabled = False
            frm.TabPage7.Enabled = False
            frm.TabPage8.Enabled = False
            frm.TabControl1.SelectedIndex = 8
            frm.dtpFecIngreso.Value = dtpfecha.Value
            frm.txtCantGuia.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(7).Value
            numReq = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(5).Value
            artCodReq = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(8).Value
            tipGuia = txtt_doc.Text
            serGuia = cmb_serdoc.Text
            numGUia = txtnumero.Text
        End If

        frm.ShowDialog()
    End Sub

    Private Sub FormMantGuiaAlmacen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

#End Region
End Class