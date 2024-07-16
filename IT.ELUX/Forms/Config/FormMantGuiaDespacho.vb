Imports System.ComponentModel
Imports vb = Microsoft.VisualBasic
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.Net.Mail
Public Class FormMantGuiaDespacho
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private gcodcor As String = ""
    Public dtusuario As DataTable
    Private GUIADESPACHOBL As New GUIADESPACHOBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ELTBGRUPCORVALBL As New ELTBGRUPCORVALBL
    Private ELTBDETDOCOPBL As New ELTBDETDOCOPBL
    Private PERBL As New PERBL
    Private ARTICULOBL As New ARTICULOBL
    Private CTCTBL As New CTCTBL
    'Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    Private catalogo As String = ""
    Private correos As New MailMessage
    Private sEstado As String
    Private envios As New SmtpClient
    Private sArticulo As String
    Private sArt_Cod As String = "0"
    Private MenuBL As New MenuBL
    'Formulario para la creacion de ordenes de compra
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
    Function Art_Guia()
        Dim creacion As String = ""
        For i = 0 To dgvt_doc.Rows.Count - 1
            creacion = creacion & "<tr> <td> Articulo Despachado " & i + 1 & ":<br>
                        " & dgvt_doc.Rows(i).Cells("ART_COD").Value & "</td>
                       <td>" & dgvt_doc.Rows(i).Cells("NOM_ART").Value & " <br>
                       CANTIDAD:" & Val(dgvt_doc.Rows(i).Cells("CANTIDAD").Value) & "<br>
                       UNIDAD:" & dgvt_doc.Rows(i).Cells("UNIDAD").Value & "<br></td>
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
        'tipo = " ah creado un NUEVO documento de Despacho"
        If flagAccion = "N" Then
            tipo = " ah creado un NUEVO documento de Despacho"
        Else
            tipo = " ah modificado un documento de Despacho"
        End If
        creacion = "Creacion de Guia de devolución para: " & txtctct_cod.Text & "-" & cmbctct_cod.Text
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
                    <td>" + txtctct_cod.Text & "-" & cmbctct_cod.Text + "</td>
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
                </table> <br/>" & "Codigo Grupo:" & gcodcor & " Nombre :" & ARTICULOBL.SelectNomGrupCor(gcodcor)
            correos.Subject = creacion
            correos.IsBodyHtml = True
            correos.BodyEncoding = System.Text.Encoding.UTF8
            For i = 0 To lstValor.Items.Count - 1
                correos.To.Add(lstValor.Items(i).ToString)
            Next
            ' correos.To.Add("jalama@envaseslux.com")
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
        btn_acta.Enabled = est
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

        Dim DataOP As String = 0
        Dim NomArt As String = ""
        For l = 0 To dgvt_doc.Rows.Count - 1
            NomArt = dgvt_doc.Rows(l).Cells("ART_COD").Value
            If txtt_movinv.Text <> "S31" And txtt_movinv.Text <> "S28" Then
                If vb.Left(NomArt, 2) = "01" Or vb.Left(NomArt, 2) = "02" Or vb.Left(NomArt, 2) = "03" Or vb.Left(NomArt, 2) = "10" Then
                    If vb.Left(NomArt, 4) = "0201" Or NomArt = "03040328" Or NomArt = "03040344" Or NomArt = "03110001" Or NomArt = "03110002" Or NomArt = "03040025" Or NomArt = "02260027" Or NomArt = "10030029" Or
                        NomArt = "02180101" Or NomArt = "03040651" Or NomArt = "02230615" Or NomArt = "02230853" Or NomArt = "03100007" Or NomArt = "01010150" Then
                    Else
                        DataOP = GUIADESPACHOBL.SelectDataOP(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, dgvt_doc.Rows(l).Cells("ART_COD").Value)
                        If DataOP = 0 Then
                            MsgBox("Ingrese Nro de OP al documento con articulo " + NomArt, MsgBoxStyle.Exclamation)
                            Return False
                        End If
                    End If
                End If
            End If
        Next
        Return True
    End Function

    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        dtusuario = GUIADESPACHOBL.getListdgv(txtt_doc.Text, cmb_serdoc.SelectedItem, txtnumero.Text)
        If OkData() = False Then
            Exit Sub
        End If
        dgvsum.Rows.Clear()
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        Dim marca As String = ""
        Dim placa As String = ""
        Dim brevete As String = ""
        Dim certificado As String = ""
        Dim nrodocu2 As String = ""
        Dim nro As String
        Dim mes As String
        'If gsUser <> "SISTEMA" Then
        '    If sAño - dtpfecha.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfecha.Value.Month = "12" Then
        '        If DateTime.Now.ToString("dd") > 11 Then
        '            MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '            'cierre(False)
        '            'fechapasada = "Si"
        '            Exit Sub
        '        End If
        '    Else
        '        'If dtpfecha.Value.Month = "06" Then ' abre mes

        '        'Else
        '        If sAño > dtpfecha.Value.Year Or sAño < dtpfecha.Value.Year Then
        '            dtpfecha.Select()
        '            MsgBox("El año es mayor o menor al año actual", MsgBoxStyle.Information)
        '            'cierre(False)
        '            'fechapasada = "Si"
        '            Exit Sub
        '        End If

        '        If DateTime.Now.ToString("MM") <> dtpfecha.Value.Month Then

        '            If dtpfecha.Value.Month > DateTime.Now.ToString("MM") Then
        '                dtpfecha.Select()
        '                MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
        '                'cierre(False)
        '                'fechapasada = "Si"
        '                Exit Sub
        '            ElseIf dtpfecha.Value.Month < DateTime.Now.ToString("MM") Then
        '                'If CInt(sMes1) > dtpfecha.Value.Month Then
        '                mes = DateTime.Now.ToString("MM") - dtpfecha.Value.Month
        '                If mes = 1 Then
        '                    'Modificacion de de fechas 
        '                    'If DateTime.Now.ToString("dd") > 14 Then
        '                    If DateTime.Now.ToString("dd") > 11 Then
        '                        MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '                        'cierre(False)
        '                        'fechapasada = "Si"
        '                        Exit Sub
        '                    End If
        '                ElseIf mes > 1 Then
        '                    dtpfecha.Select()
        '                    MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
        '                    'cierre(False)
        '                    'fechapasada = "Si"
        '                    Exit Sub
        '                End If
        '                'End If
        '            End If

        '        End If
        '        If CInt(sMes2) < dtpfecha.Value.Month Then
        '            dtpfecha.Select()
        '            MsgBox("El mes es menor al permitido", MsgBoxStyle.Information)
        '            'cierre(False)
        '            'fechapasada = "Si"
        '            Exit Sub
        '        ElseIf CInt(sMes2) > dtpfecha.Value.Month Then
        '            mes = sMes2 - dtpfecha.Value.Month
        '            If mes = 1 Then
        '                'Modificacion de de fechas 
        '                'If DateTime.Now.ToString("dd") > 14 Then
        '                If DateTime.Now.ToString("dd") > 11 Then
        '                    MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '                    'cierre(False)
        '                    'fechapasada = "Si"
        '                    Exit Sub
        '                End If
        '            ElseIf mes > 1 Then
        '                dtpfecha.Select()
        '                MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
        '                'cierre(False)
        '                'fechapasada = "Si"
        '                Exit Sub
        '            End If
        '        End If
        '    End If
        'End If

        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim GUIADESPACHOBE As New GUIADESPACHOBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE

        GUIADESPACHOBE.T_DOC_REF = RTrim(txtt_doc.Text)
        GUIADESPACHOBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
        GUIADESPACHOBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        GUIADESPACHOBE.ART_COD = "07010003"
        GUIADESPACHOBE.FEC_GENE = RTrim(dtpfecha.Value)
        GUIADESPACHOBE.NOM_CTCT = cmbctct_cod.Text
        If cmbestado.SelectedIndex = 0 Then
            GUIADESPACHOBE.EST = "H"
        ElseIf cmbestado.SelectedIndex = 1 Then
            GUIADESPACHOBE.EST = "A"
        ElseIf cmbestado.SelectedIndex = 2 Then
            GUIADESPACHOBE.EST = "P"
        ElseIf cmbestado.SelectedIndex = 3 Then
            GUIADESPACHOBE.EST = "T"
        ElseIf cmbestado.SelectedIndex = 4 Then
            GUIADESPACHOBE.EST = "S"
        ElseIf cmbestado.SelectedIndex = 5 Then
            GUIADESPACHOBE.EST = "V"
        End If
        If dtpfanul.Checked Then
            GUIADESPACHOBE.FEC_ANU = dtpfanul.Value
        Else
            GUIADESPACHOBE.FEC_ANU = Nothing
        End If
        GUIADESPACHOBE.SIGNO = "-"
        GUIADESPACHOBE.OBSERVA = RTrim(txtobservacion.Text)
        GUIADESPACHOBE.MONEDA = txtmon.Text
        GUIADESPACHOBE.DIR_COD = RTrim(txtdir.Text)


        For i = 0 To dgvt_doc.Rows.Count - 1
            DAcumula = Val(dgvt_doc.Rows(i).Cells("TPRECIO_VENTA").Value) + DAcumula
            DAcumula1 = Val(dgvt_doc.Rows(i).Cells("TPRECIO_DVENTA").Value) + DAcumula1
            DAcumula2 = Val(dgvt_doc.Rows(i).Cells("DSCTO_IMPOR").Value) + DAcumula2
            DAcumula3 = Val(dgvt_doc.Rows(i).Cells("DSCTO_DIMPOR").Value) + DAcumula3
            DAcumula4 = Val(dgvt_doc.Rows(i).Cells("IGV_IMPOR").Value) + DAcumula4
            DAcumula5 = Val(dgvt_doc.Rows(i).Cells("IGV_DIMPOR").Value) + DAcumula5
            If dgvt_doc.Rows(i).Cells("MARCA").Value <> "" Then
                marca = dgvt_doc.Rows(i).Cells("MARCA").Value
            End If
            If dgvt_doc.Rows(i).Cells("PLACA").Value <> "" Then
                placa = RTrim(dgvt_doc.Rows(i).Cells("PLACA").Value)
            End If
            If dgvt_doc.Rows(i).Cells("BREVETE").Value <> "" Then
                brevete = dgvt_doc.Rows(i).Cells("BREVETE").Value
            End If
            If dgvt_doc.Rows(i).Cells("CERTIFICADO").Value <> "" Then
                certificado = dgvt_doc.Rows(i).Cells("CERTIFICADO").Value
            End If
            If dgvt_doc.Rows(i).Cells("NRO_DOCU2").Value <> "" Then
                nrodocu2 = dgvt_doc.Rows(i).Cells("NRO_DOCU2").Value
            End If
        Next
        Dim a As String = dtpfecha.Value.Year
        Dim c As Integer = 0
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
                                a,
                                dgvt_doc.Rows(i).Cells("FEC_ENT").Value)
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
                               a,
                               dtpfecha.Value)
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
        DET_DOCUMENTOBE.BREVETE = brevete
        DET_DOCUMENTOBE.PLACA = placa
        DET_DOCUMENTOBE.MARCA = marca
        DET_DOCUMENTOBE.CERTIFICADO = certificado
        DET_DOCUMENTOBE.NRO_DOCU2 = nrodocu2
        GUIADESPACHOBE.TPRECIO_VENTA = DAcumula
        GUIADESPACHOBE.TPRECIO_DVENTA = DAcumula1
        GUIADESPACHOBE.T_DCTO = DAcumula2
        GUIADESPACHOBE.T_DCTO_DOLAR = DAcumula3
        GUIADESPACHOBE.T_IGV = DAcumula4
        GUIADESPACHOBE.T_IGV_DOLAR = DAcumula5
        GUIADESPACHOBE.PROVEEDOR = "20100279348"
        GUIADESPACHOBE.CTCT_COD = RTrim(txtctct_cod.Text)
        GUIADESPACHOBE.FEC_DIA = RTrim(DateTime.Now)
        GUIADESPACHOBE.NUMPEDIDO = ""
        GUIADESPACHOBE.USUARIO = RTrim(gsUser)
        GUIADESPACHOBE.F_PAGO_ENT = RTrim(txtt_pago.Text)
        GUIADESPACHOBE.FOR_ENT_COD = RTrim(txtfor_ent.Text)
        GUIADESPACHOBE.T_MOVINV = txtt_movinv.Text
        GUIADESPACHOBE.VENDEDOR = txtvendedor.Text
        ELMVLOGSBE.log_codusu = gsCodUsr
        GUIADESPACHOBE.NUMPEDIDO = txtoc.Text
        If txtt_movinv.Text = "S31" Then
            If cmbalmacen.SelectedIndex > -1 Then
                GUIADESPACHOBE.CANAL = cmbalmacen.SelectedValue
                If cmb_serdoc.Text = "001" Then
                    GUIADESPACHOBE.ALM_COD = "0001"
                ElseIf cmb_serdoc.Text = "003" Then
                    GUIADESPACHOBE.ALM_COD = "0002"
                ElseIf cmb_serdoc.Text = "004" Then
                    GUIADESPACHOBE.ALM_COD = "0003"
                End If
            Else
                MsgBox("Ingrese el almacen al que se va a trasladar.")
                Exit Sub
            End If
            If flagAccion = "M" Then
                GUIADESPACHOBE.ALM_COD1 = lblcod_alm.Text
            End If

        Else
            GUIADESPACHOBE.ALM_COD = cmbalmacen.SelectedValue
            If flagAccion = "M" Then
                GUIADESPACHOBE.ALM_COD1 = lblcod_alm.Text
            End If
        End If
        gsError = GUIADESPACHOBL.SaveRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvt_doc, cmb_serdoc.Text, sEstAlmac, dtusuario)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            gsError = GUIADESPACHOBL.SaveRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, "TOT", dgvsum, cmb_serdoc.Text, sEstAlmac, dtusuario)
            tsbGrabar.Enabled = "false"
            Dispose()
            If txtt_movinv.Text = "S28" Then
                ELTBGRUPCORVALBL.SelectRow("0007", lstValor)
                gcodcor = "0007"
                enviarCorreo1()
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

            Case "certi_calidad"
                ReDim gsRptArgs(2)
                gsRptArgs(0) = RTrim(txtt_doc.Text)
                gsRptArgs(1) = RTrim(cmb_serdoc.Text)
                gsRptArgs(2) = RTrim(txtnumero.Text)
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_DOCUMENTO_CERTIFICADO_CALIDAD.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
                Exit Sub
            Case "acta"
                ReDim gsRptArgs(2)
                gsRptArgs(0) = RTrim(txtt_doc.Text)
                gsRptArgs(1) = RTrim(cmb_serdoc.Text)
                gsRptArgs(2) = RTrim(txtnumero.Text)
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ACTA_ENTREGA_GD.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
                Exit Sub
            Case "guia_transpor"
                ReDim gsRptArgs(3)
                gsRptArgs(0) = RTrim(txtt_doc.Text)
                gsRptArgs(1) = txtctct_cod.Text.Trim
                gsRptArgs(2) = dgvt_doc.Rows(0).Cells("NRO_DOCU2").Value
                gsRptArgs(3) = dgvt_doc.Rows(0).Cells("TRANSP_COD").Value
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_DOCUMENTO_GUIA_TRASNPORTISTA.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
                Exit Sub
            Case "save"
                SaveData()
                Exit Sub
            Case "exit"
                SelDataOP()
                Dispose()
                Exit Sub
            Case "Print"
                If txtt_movinv.Text <> "S06" Then
                    ReDim gsRptArgs(3)
                    gsRptArgs(0) = RTrim(txtt_doc.Text)
                    gsRptArgs(1) = RTrim(cmb_serdoc.Text)
                    gsRptArgs(2) = RTrim(txtnumero.Text)
                    gsRptArgs(3) = RTrim(txtt_movinv.Text)
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_GUIADESPACHO.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                    Exit Sub
                Else
                    ReDim gsRptArgs(3)
                    gsRptArgs(0) = RTrim(txtt_doc.Text)
                    gsRptArgs(1) = RTrim(cmb_serdoc.Text)
                    gsRptArgs(2) = RTrim(txtnumero.Text)
                    gsRptArgs(3) = RTrim(txtt_movinv.Text)
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_GUIADESPACHO_EXP.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                    Exit Sub
                End If
                Exit Sub
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

                Dim GUIADESPACHOBE As New GUIADESPACHOBE
                Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                GUIADESPACHOBE.T_DOC_REF = txtt_doc.Text
                GUIADESPACHOBE.SER_DOC_REF = cmb_serdoc.Text
                GUIADESPACHOBE.NRO_DOC_REF = txtnumero.Text
                GUIADESPACHOBE.OBSERVA = dtpfecha.Value.Year
                'GUIADESPACHOBE.ALM_COD = gsCodAlm
                GUIADESPACHOBE.ALM_COD = cmbalmacen.SelectedValue
                GUIADESPACHOBE.T_MOVINV = txtt_movinv.Text
                GUIADESPACHOBE.FEC_GENE = dtpfecha.Value
                GUIADESPACHOBE.ALMAC = "S"
                If txtt_movinv.Text = "S31" Then
                    GUIADESPACHOBE.CANAL = cmbalmacen.SelectedValue
                End If
                GUIADESPACHOBE.EST = "A"

                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = GUIADESPACHOBL.SaveRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, "AR", dgvt_doc, cmb_serdoc.Text, sEstAlmac, dtusuario)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    For j = 0 To dgvt_doc.Rows.Count - 1
                        dgvsum.Rows.Add(dgvt_doc.Rows(j).Cells("T_DOC_REF").Value,
                                dgvt_doc.Rows(j).Cells("SER_DOC_REF").Value,
                                dgvt_doc.Rows(j).Cells("NRO_DOC_REF").Value,
                                dgvt_doc.Rows(j).Cells("ART_COD").Value)
                    Next
                    gsError = GUIADESPACHOBL.SaveRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, "ET", dgvsum, cmb_serdoc.Text, sEstAlmac, dtusuario)
                    cmb_serdoc.Enabled = False
                    'sEstAlmac = cmbalmac.SelectedValue
                    Me.btnborrar.Enabled = False
                    Me.btndocu.Enabled = False
                    Me.btnagregar.Enabled = False
                    Dim i As Integer
                    For i = 0 To 45
                        dgvt_doc.Columns(i).ReadOnly = True
                    Next
                    sEstado = "A"
                    'Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
                Exit Sub

            Case "etique"

                Dim frm As New FormMultiploArtViru
                frm.ShowDialog()
                'Dim Lugar, cantidad, articulo, codigo As String
                'Dim dt, dt2, dt3 As DataTable
                'articulo = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(8).Value

                'If articulo.Substring(0, 4) = "0223" Then

                '    'OBTENER CODIGO VIRU
                '    dt3 = GUIADESPACHOBL.SelectGetCodviru(txtctct_cod.Text, articulo)
                '    If dt3.Rows.Count Then
                '        codigo = dt3.Rows(0).Item(0).ToString
                '    Else
                '        MsgBox("Este Articulo no tiene un codigo de cliente asignado", MsgBoxStyle.Information)
                '    End If

                '    'OBTENER DISTRITO O PROVINCIA
                '    dt = GUIADESPACHOBL.SelectGetUbigeo(txtctct_cod.Text, txtdir.Text)
                '    If dt.Rows.Count Then
                '        Lugar = dt.Rows(0).Item(0).ToString
                '    End If

                '    'OBTENER CANTIDAD DE PALLTES
                '    dt2 = GUIADESPACHOBL.SelectGetCantidadPallets(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(7).Value, dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(8).Value)
                '    If dt2.Rows.Count Then
                '        cantidad = dt2.Rows(0).Item(0).ToString
                '    End If

                '    ReDim gsRptArgs(4)
                '    gsRptArgs(0) = Lugar
                '    gsRptArgs(1) = cmb_serdoc.SelectedItem
                '    gsRptArgs(2) = txtnumero.Text
                '    gsRptArgs(3) = cantidad
                '    gsRptArgs(4) = codigo
                '    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTETIQUETA_PALLETS.rpt"
                '    gsRptPath = gsPathRpt
                '    FormReportes.ShowDialog()
                '    Exit Sub
                'Else
                '    MsgBox("No se pueden imprimir etiquetas para este articulo", MsgBoxStyle.Information)
                'End If
        End Select
    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dtUsuario = GUIADESPACHOBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

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
            sEstAlmac = Registro("EST").ToString
            lblcod_alm.Text = IIf(IsDBNull(Registro("CANAL")), "", Registro("CANAL"))
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
            txtvendedor.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            cmbvendedor.SelectedValue = txtvendedor.Text
            txtctct_cod.Text = IIf(IsDBNull(Registro("CTCT_COD")), "", Registro("CTCT_COD"))
            'txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
            'cmbvendedor.SelectedValue = txtvendedor.Text
            txtvendedor.Text = IIf(IsDBNull(Registro("VENDEDOR")), "", Registro("VENDEDOR"))
            cmbvendedor.SelectedValue = txtvendedor.Text
            txtoc.Text = IIf(IsDBNull(Registro("NUMPEDIDO")), "", Registro("NUMPEDIDO"))
            'Carga la direccion de acuerdo al cliente
            Dim dt As DataTable
            dt = GUIADESPACHOBL.SelectDir(txtctct_cod.Text)
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
            'ver

            If txtt_movinv.Text = "S31" Then
                Dim dtalm As DataTable
                dtalm = REQUERIMIENTOBL.SelectAlmac(cmb_serdoc.Text)
                GetCmb("ALM_CODIGO", "ALM_DESCRI", dtalm, cmbalmacen)
                cmbalmacen.Enabled = True
                cmbalmacen.SelectedValue = IIf(IsDBNull(Registro("CANAL")), "", Registro("CANAL"))
            Else
                cmbalmacen.SelectedValue = IIf(IsDBNull(Registro("alm_cod")), "", Registro("alm_cod"))
                lblcod_alm.Text = IIf(IsDBNull(Registro("alm_cod")), "", Registro("alm_cod"))
                'cmbalmacen.Enabled = False
            End If
            If cmbestado.SelectedIndex = 0 Then
                sEstado = "H"
            ElseIf cmbestado.SelectedIndex = 1 Then
                sEstado = "A"
            End If
        Next
    End Sub
    Private Sub FormMantGuiaDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtt_doc.Select()
        bPrimero = True
        gsError = ""
        gpCaption = "Guia de Despacho"
        Me.Text = gpCaption

        Me.txtvendedor.ReadOnly = True
        'Cargar los combos
        Dim dt As DataTable = GUIADESPACHOBL.SelectT_DOC("09")
        GetCmb("cod", "nom", dt, cmbt_doc)
        dt = GUIADESPACHOBL.SelectT_MOVINV()
        GetCmb("cod", "nom", dt, cmbt_movinv)
        dt = GUIADESPACHOBL.SelectF_PAGO
        GetCmb("cod", "nom", dt, cmbt_pago)
        dt = GUIADESPACHOBL.SelectF_ENT
        GetCmb("cod", "nom", dt, cmbfor_ent)
        dt = GUIADESPACHOBL.SelectMoneda
        GetCmb("cod", "nom", dt, cmbmon)
        cmbmon.SelectedIndex = 1
        txtmon.Text = "01"
        dt = GUIADESPACHOBL.SelectVendedor
        GetCmb("cod", "nom", dt, cmbvendedor)
        dt = GUIADESPACHOBL.SelectCliente
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
        dgvt_doc.Columns.Add("UNIDAD", "Und.")  '11
        dgvt_doc.Columns.Add("SERIE_SOLI", "Ser.Ref.") '12
        dgvt_doc.Columns.Add("ACT_COD", "Activos") '13
        dgvt_doc.Columns.Add("FEC_LLEG", "Fec.Vcto") '14
        dgvt_doc.Columns.Add("PART_ACT", "P. Act.") '15
        dgvt_doc.Columns.Add("ALM_COD", "Alm") '16
        dgvt_doc.Columns.Add("SIGNO", "Signo") '17
        dgvt_doc.Columns.Add("T_MOVINV", "T. Mov.") '18
        dgvt_doc.Columns.Add("TPRECIO_VENTA", "P. Venta") '19
        dgvt_doc.Columns.Add("TPRECIO_DVENTA", "P. Venta. D.") '20
        dgvt_doc.Columns.Add("IGV", "Igv")  '21
        dgvt_doc.Columns.Add("IGV_IMPOR", "Cant. IGV") '22
        dgvt_doc.Columns.Add("T_CAMB", "Camb.") '23
        dgvt_doc.Columns.Add("UPRECIO_VENTA", "Pre. Venta") '24
        dgvt_doc.Columns.Add("UPRECIO_DVENTA", "Pre. D. Venta") '25
        dgvt_doc.Columns.Add("IGV_DIMPOR", "Cant. IGV D.") '26
        dgvt_doc.Columns.Add("MONEDA", "Moneda") '27
        dgvt_doc.Columns.Add("FEC_GENE", "F. Gene") '28
        dgvt_doc.Columns.Add("USUARIO", "Usuario") '29
        dgvt_doc.Columns.Add("F_PAGO_ENT", "F. Pago") '30
        dgvt_doc.Columns.Add("FOR_ENT_COD", "F. Cod. Ent") '31
        dgvt_doc.Columns.Add("FEC_DIA", "F. Dia") '32
        dgvt_doc.Columns.Add("PROVEEDOR", "Prov.") '33
        dgvt_doc.Columns.Add("CCO_COD", "C. Costo") '34
        dgvt_doc.Columns.Add("LOTE", "Lote") '35
        dgvt_doc.Columns.Add("PER_COD", "Cod. Per") '36
        dgvt_doc.Columns.Add("NRO_DOCU1", "Nro. Docu") '37
        dgvt_doc.Columns.Add("MARCA", "Marca") '38
        dgvt_doc.Columns.Add("DSCTO", "Dscto. %") '39
        dgvt_doc.Columns.Add("DSCTO_IMPOR", "Dscto. S.") '40
        dgvt_doc.Columns.Add("DSCTO_DIMPOR", "Dscto D.") '41
        dgvt_doc.Columns.Add("EST", "Est.") '42
        dgvt_doc.Columns.Add("REPROVEEDOR", "REPROVEEDOR") '43 TIPO DOCUMENTO FACTURA
        dgvt_doc.Columns.Add("RETRANSPORTISTA", "RETRANSPORTISTA") '44 SERIE DOCUMENTO FACTURA
        dgvt_doc.Columns.Add("MARCA1", "MARCA1") '45 NRO DOCUMENTO FACTURA
        dgvt_doc.Columns.Add("TRANSP_COD", "Codigo") '46
        dgvt_doc.Columns.Add("CHOFER", "Nombre del Chofer") '47
        dgvt_doc.Columns.Add("BREVETE", "Brevete") '48
        dgvt_doc.Columns.Add("PLACA", "Placa") '49
        dgvt_doc.Columns.Add("CONFIGURACION", "Configuracion") '50
        dgvt_doc.Columns.Add("CERTIFICADO", "Certificado") '51
        dgvt_doc.Columns.Add("TIPO_UNIDAD", "tipo Unidad") '52
        dgvt_doc.Columns.Add("COLOR", "Serie Transportista") '53
        dgvt_doc.Columns.Add("NRO_DOCU2", "Nro transportista") '54
        dgvt_doc.Columns.Add("FEC_ENT", "FEC.ENT") '55
        dgvt_doc.Columns.Add("OBSERVA", "Observa") '56
        dgvt_doc.Columns.Add("PESO", "PESO") '57

        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        '---------------------------------------------------------------------
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
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()
                habilitar(False)
                bTercero = "1"
                bCuarto = "1"
                'Dim dt As DataTable
                Me.txtt_doc.Text = "09"
                Me.txtt_movinv.Text = "S02"
                cmbt_doc.SelectedValue = txtt_doc.Text
                cmbt_movinv.SelectedValue = Me.txtt_movinv.Text
                If gsCodUsr = "0031" Then
                    cmb_serdoc.SelectedIndex = 2
                Else
                    cmb_serdoc.SelectedIndex = 0
                End If

                dt = REQUERIMIENTOBL.SelectAlmac("N")
                GetCmb("ALM_CODIGO", "ALM_DESCRI", dt, cmbalmacen)
                cmbalmacen.SelectedIndex = 0
                cmbalmacen.Enabled = True
                cmbestado.SelectedIndex = 0
                txtt_pago.Text = "08"
                cmbt_pago.SelectedValue = txtt_pago.Text
                txtfor_ent.Text = "09"
                cmbfor_ent.SelectedValue = txtfor_ent.Text
                Button1.Select()
                txtmon.Text = "01"
                cmbmon.SelectedValue = txtmon.Text
                Me.txtmon.Select()
                'cmblinea.Enabled = True
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                'dgvt_doc.Columns(3).Visible = False
                'dgvt_doc.Columns(4).Visible = False
                'dgvt_doc.Columns(5).Visible = False
                dgvt_doc.Columns(6).Visible = False
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
                'dgvt_doc.Columns(37).Visible = False
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
                'dgvt_doc.Columns(55).Visible = False
                'dgvt_doc.Columns(56).Visible = False
                dgvt_doc.Columns(57).Visible = False

            Case 1
                flagAccion = "M"
                dt = REQUERIMIENTOBL.SelectAlmac("N")
                GetCmb("ALM_CODIGO", "ALM_DESCRI", dt, cmbalmacen)
                GetData("09", sSDoc, sNDoc)
                bCuarto = "1"
                'habilitar(True)
                cmb_serdoc.Enabled = False
                Dim dtArticulo As DataTable
                dtArticulo = GUIADESPACHOBL.getListdgv("09", sSDoc, sNDoc)
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
                                      IIf(IsDBNull(row("SERIE_SOLI")), "", row("SERIE_SOLI")),'12
                                      IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")),'13
                                      IIf(IsDBNull(row("FEC_LLEG")), "", row("FEC_LLEG")),'14
                                      IIf(IsDBNull(row("PART_ACT")), "", row("PART_ACT")),'15
                                      IIf(IsDBNull(row("ALM_COD")), "", row("ALM_COD")),'16
                                      IIf(IsDBNull(row("SIGNO")), "", row("SIGNO")),'17
                                      IIf(IsDBNull(row("T_MOVINV")), "", row("T_MOVINV")),'18
                                      IIf(IsDBNull(row("TPRECIO_VENTA")), "", row("TPRECIO_VENTA")),'19
                                      IIf(IsDBNull(row("TPRECIO_DVENTA")), "", row("TPRECIO_DVENTA")),'20
                                      IIf(IsDBNull(row("IGV")), "", row("IGV")),'21
                                      IIf(IsDBNull(row("IGV_IMPOR")), "", row("IGV_IMPOR")),'22
                                      IIf(IsDBNull(row("T_CAMB")), "", row("T_CAMB")),'23
                                      IIf(IsDBNull(row("UPRECIO_VENTA")), "", row("UPRECIO_VENTA")),'24
                                      IIf(IsDBNull(row("UPRECIO_DVENTA")), "", row("UPRECIO_DVENTA")),'25
                                      IIf(IsDBNull(row("IGV_DIMPOR")), "", row("IGV_DIMPOR")),'26
                                      IIf(IsDBNull(row("MONEDA")), "", row("MONEDA")),'27
                                      IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")),'28
                                      IIf(IsDBNull(row("USUARIO")), "", row("USUARIO")),'29                                
                                      IIf(IsDBNull(row("F_PAGO_ENT")), "", row("F_PAGO_ENT")),'30
                                      IIf(IsDBNull(row("FOR_ENT_COD")), "", row("FOR_ENT_COD")),'31
                                      IIf(IsDBNull(row("FEC_DIA")), "", row("FEC_DIA")),'32
                                      IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'33
                                      IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),'34
                                      IIf(IsDBNull(row("LOTE")), "", row("LOTE")),'35
                                      IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),'36
                                      IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")),'37
                                      IIf(IsDBNull(row("MARCA")), "", row("MARCA")),'38
                                      IIf(IsDBNull(row("DSCTO")), "", row("DSCTO")),'39
                                      IIf(IsDBNull(row("DSCTO_IMPOR")), "", row("DSCTO_IMPOR")),'40
                                      IIf(IsDBNull(row("DSCTO_DIMPOR")), "", row("DSCTO_DIMPOR")),'41
                                      IIf(IsDBNull(row("EST")), "", row("EST")), '42
                                      IIf(IsDBNull(row("REPROVEEDOR")), "", row("REPROVEEDOR")),'43
                                      IIf(IsDBNull(row("RETRANSPORTISTA")), "", row("RETRANSPORTISTA")),'44
                                      IIf(IsDBNull(row("MARCA1")), "", row("MARCA1")),'45
                                      IIf(IsDBNull(row("TRANSP_COD")), "", row("TRANSP_COD")),'46
                                      IIf(IsDBNull(row("CHOFER")), "", row("CHOFER")),'47
                                      IIf(IsDBNull(row("BREVETE")), "", row("BREVETE")),'48
                                      IIf(IsDBNull(row("PLACA")), "", row("PLACA")),'49
                                      IIf(IsDBNull(row("CONFIGURACION")), "", row("CONFIGURACION")),'50
                                      IIf(IsDBNull(row("CERTIFICADO")), "", row("CERTIFICADO")), '51
                                      IIf(IsDBNull(row("TIPO_UNIDAD")), "", row("TIPO_UNIDAD")), '52
                                      IIf(IsDBNull(row("COLOR")), "", row("COLOR")),'53
                                      IIf(IsDBNull(row("NRO_DOCU2")), "", row("NRO_DOCU2")),'54
                                      IIf(IsDBNull(row("FEC_ENT")), "", row("FEC_ENT")),'55
                                      IIf(IsDBNull(row("OBSERVA")), "", row("OBSERVA")),'56
                                      IIf(IsDBNull(row("PESO")), "", row("PESO"))) '57

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
                Me.btnborrar.Enabled = True
                Me.btndocu.Enabled = True
                Me.btnagregar.Enabled = True
                Me.cmbestado.Enabled = False
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                'dgvt_doc.Columns(3).Visible = False
                'dgvt_doc.Columns(4).Visible = False
                'dgvt_doc.Columns(5).Visible = False
                dgvt_doc.Columns(6).Visible = False
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
                'dgvt_doc.Columns(37).Visible = False
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
                'dgvt_doc.Columns(52).Visible = False
                'dgvt_doc.Columns(53).Visible = False
                dgvt_doc.Columns(54).Visible = False
                dgvt_doc.Columns(55).Visible = False
                dgvt_doc.Columns(56).Visible = False
                dgvt_doc.Columns(57).Visible = False
        End Select
        bPrimero = False
    End Sub

    Private Sub FormMantGuiaDespacho_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SelDataOP()
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "39"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtctct_cod.Text = gLinea
            cmbctct_cod.SelectedValue = gLinea
        Else
            gLinea = Nothing
        End If

        txtctct_cod.Select()
        Dim dt As DataTable
        dt = REQUERIMIENTOBL.SelectDir(txtctct_cod.Text)
        GetCmb("dir_cod", "nom_dir", dt, cmbdir)
        cmbdir.SelectedValue = txtdir.Text
        txtvendedor.Text = CTCTBL.SelectVendedor(txtctct_cod.Text)
        cmbvendedor.SelectedValue = txtvendedor.Text
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
        Dim dt As DataTable
        If txtt_movinv.Text = "S31" And (cmb_serdoc.SelectedIndex = 0 Or cmb_serdoc.SelectedIndex = 2 Or cmb_serdoc.SelectedIndex = 3) Then
            ' Dim dt As DataTable
            dt = REQUERIMIENTOBL.SelectAlmac(cmb_serdoc.Text)
            GetCmb("ALM_CODIGO", "ALM_DESCRI", dt, cmbalmacen)
            cmbalmacen.Enabled = True
        ElseIf txtt_movinv.Text = "S31" Then
            MsgBox("Esta Serie no tiene Designado un almacen para hacer la transferencia")
            txtt_movinv.Text = "S02"
            cmbt_movinv.SelectedValue = txtt_movinv.Text
            'cmbalmacen.Enabled = False
        ElseIf txtt_movinv.Text <> "S31" Then
            'cmbalmacen.Enabled = False
            dt = REQUERIMIENTOBL.SelectAlmac("N")
            GetCmb("ALM_CODIGO", "ALM_DESCRI", dt, cmbalmacen)
            cmbalmacen.SelectedIndex = 0
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
        dt = GUIADESPACHOBL.SelectDir(txtctct_cod.Text)
        Try
            GetCmb("dir_cod", "nom_dir", dt, cmbdir)
            'cmbdir.SelectedValue = txtdir.Text
            Try
                cmbdir.SelectedValue = "01"
                If cmbdir.SelectedIndex = -1 Then
                    cmbdir.SelectedValue = "1"
                End If
                If gsCodUsr = "0031" Then
                    cmbdir.SelectedValue = "02"
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
            nro = GUIADESPACHOBL.SelectNro1(txtt_doc.Text, cmb_serdoc.SelectedItem)
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
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        gContador = 0
        If txtmon.Text = "" Or txtt_movinv.Text = "" Then
            MsgBox("Ingrese la moneda")
            Exit Sub
        End If
        If txtt_movinv.Text = "" Then
            MsgBox("Debe seleccionar el tipo de movimiento")
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
        Dim frm As New FormMantDetGuiaDespacho
        frm.lbltmov.Text = txtt_movinv.Text
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
#End Region

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
        If txtt_movinv.Text = "S31" Then
            Dim dt As DataTable
            dt = REQUERIMIENTOBL.SelectAlmac(cmb_serdoc.Text)
            GetCmb("ALM_CODIGO", "ALM_DESCRI", dt, cmbalmacen)
            cmbalmacen.Enabled = True
        Else
            'cmbalmacen.Enabled = False
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
            'cmbdir.SelectedValue = txtdir.Text
            Try
                cmbdir.SelectedValue = "01"
                If cmbdir.SelectedIndex = -1 Then
                    cmbdir.SelectedValue = "1"
                End If
            Catch ex As Exception

            End Try
            If txtctct_cod.Text = "20100279348" Then
                cmbdir.SelectedValue = "1"
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


    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim dt As DataTable
        If txtt_movinv.Text = "" Then
            MsgBox("Debe seleccionar el tipo de movimiento")
            Exit Sub
        End If
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormMantDetGuiaDespacho
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
            frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
            frm.txtserie_soli.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SERIE_SOLI").Value
            frm.lbltmov.Text = txtt_movinv.Text
            frm.txttdocfac.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("REPROVEEDOR").Value
            frm.txtsdocfac.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("RETRANSPORTISTA").Value
            frm.txtndocfac.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MARCA1").Value
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FEC_ENT").Value <> Nothing Then
                frm.dtpfec_ent.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FEC_ENT").Value
            End If
            frm.npdpeso.Value = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PESO").Value)
            'If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value) = 0 Then
            '    frm.txtigv.Text = 18
            'End If
            frm.txtigv.Text = Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("IGV").Value)
            If frm.npduprecio_venta.Text.Length > 0 And frm.npdcantidad.Text.Length And frm.txtigv.Text > 0 Then
                frm.txttcompras.Text = (frm.npduprecio_venta.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_venta.Text * frm.npdcantidad.Text
                frm.txttcomprad.Text = ((frm.npduprecio_venta.Text * frm.npdcantidad.Text) * (frm.txtigv.Text / 100) + frm.npduprecio_venta.Text * frm.npdcantidad.Text) / frm.npdtcamb.Text
            End If
            If Val(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells(22).Value) = 0 Then
                dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
                For Each Registro In dt.Rows
                    frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                Next
            End If
            gCliente = txtctct_cod.Text

            'If flagAccion = "M" Then
            '    'frm.btnagregar.Enabled = False
            'ElseIf flagAccion = "N" Then
            '    dt = REQUERIMIENTOBL.getT_CAMB(sFecha)
            '    For Each Registro In dt.Rows
            '        frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
            '    Next
            '    If txtt_movinv.Text = "S06" Then
            '        frm.txtigv.Text = 0
            '    Else
            '        frm.txtigv.Text = 18
            '    End If
            'End If

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
                If dtpfecha.Value.Month.ToString.Length = "1" Then
                    mesdia = "0" & dtpfecha.Value.Day.ToString
                Else
                    mesdia = dtpfecha.Value.Day.ToString
                End If
                dt = REQUERIMIENTOBL.getT_CAMB(dtpfecha.Value.Year & "/" & mesfecha & "/" & mesdia)
                For Each Registro In dt.Rows
                    frm.npdtcamb.Value = IIf(IsDBNull(Registro("VENTA")), "", Registro("VENTA"))
                Next
                frm.txtigv.Text = 18
            End If
            gContador = 0
            frm.ShowDialog()
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay items en la lista para modificar")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormTransportista
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TRANSP_COD").Value <> "" Then
                frm.txtcod.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TRANSP_COD").Value
                frm.txtbrevete.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("BREVETE").Value
                frm.txtconfi.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CONFIGURACION").Value
                frm.txtcertifi.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CERTIFICADO").Value
                frm.txtmarca.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("MARCA").Value
                frm.txttipounidad.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("TIPO_UNIDAD").Value
                frm.txtplaca.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PLACA").Value
                frm.lblchofer.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CHOFER").Value
                frm.txtchofer.Text = GUIADESPACHOBL.SelectRowcodChofer(frm.txtcod.Text, frm.txtbrevete.Text.Trim)
                If txtctct_cod.Text <> "" Then
                    'frm.cmb_transdoc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("COLOR").Value
                    'frm.txtNrodoc2.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU2").Value
                    frm.cmb_transdoc.SelectedItem = "001"
                    frm.txtNrodoc2.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU2").Value.ToString.PadLeft(7, "0")
                End If

                'gsCode = "0"
                frm.ShowDialog()
                'gsCode = ""
            Else
                frm.ShowDialog()
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New FormMantExpor
        frm.txtt_doc_ref.Text = txtt_doc.Text
        frm.txtser_doc_ref.Text = cmb_serdoc.Text
        frm.txtnro_doc_ref.Text = txtnumero.Text
        frm.ShowDialog()
        flagAccion1 = Nothing
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim frm As New FormDocuRef
        If txtt_movinv.Text = "S02" Or txtt_movinv.Text = "S06" Or txtt_movinv.Text = "S05" Then
            sMov = "0"
        End If
        gsCode = "3"
        sOp = "0"
        frm.ShowDialog()
        sMov = ""
    End Sub

    Private Sub btn_acta_Click(sender As Object, e As EventArgs) Handles btn_acta.Click
        'Dim dt As DataTable

        Dim frm As New FormMantActaEntrega

        frm.sT_ref = txtt_doc.Text
        frm.sS_ref = cmb_serdoc.Text
        frm.sN_Ref = txtnumero.Text

        frm.dgvt_doc.Columns.Add("ART_COD", "codigo") '0    
        frm.dgvt_doc.Columns.Add("CANTIDAD", "cantidad") '1    
        frm.dgvt_doc.Columns.Add("NOM_ART", "nombre") '2
        frm.dgvt_doc.Columns.Add("T_DOC_REF", "doc") '3   
        frm.dgvt_doc.Columns.Add("SER_DOC_REF", "ser") '4
        frm.dgvt_doc.Columns.Add("NRO_DOC_REF", "nro") '5
        For Each row As DataGridViewRow In dgvt_doc.Rows

            If RTrim(row.Cells("ART_COD").Value).Substring(0, 4) <> "0304" Then
                frm.dgvt_doc.Rows.Add(IIf(IsDBNull(row.Cells("ART_COD").Value), "", row.Cells("ART_COD").Value),
                                      IIf(IsDBNull(row.Cells("CANTIDAD").Value), "", row.Cells("CANTIDAD").Value),
                                      IIf(IsDBNull(row.Cells("NOM_ART").Value), "", row.Cells("NOM_ART").Value),
                                      IIf(IsDBNull(row.Cells("T_DOC_REF").Value), "", row.Cells("T_DOC_REF").Value),
                                      IIf(IsDBNull(row.Cells("SER_DOC_REF").Value), "", row.Cells("SER_DOC_REF").Value),
                                      IIf(IsDBNull(row.Cells("NRO_DOC_REF").Value), "", row.Cells("NRO_DOC_REF").Value))

                frm.cmbarticulo.Items.Add(IIf(IsDBNull(row.Cells("ART_COD").Value), "", row.Cells("ART_COD").Value))
            End If


        Next
        frm.ShowDialog()
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

    Private Sub btnduplicar_Click(sender As Object, e As EventArgs) Handles btnduplicar.Click
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("El documento no tiene ningun articulo favor de ingresar al menos un item")
            Exit Sub
        Else
            Dim frm As New FormDetGuiaDespDuplicar
            frm.txtnumero.Text = dgvt_doc.Rows(0).Cells("NRO_DOCU1").Value
            frm.txtserie.Text = dgvt_doc.Rows(0).Cells("SERIE_SOLI").Value
            'SE CAE
            If dgvt_doc.Rows(0).Cells("FEC_ENT").Value <> "" Then
                frm.dtpfecha.Value = dgvt_doc.Rows(0).Cells("FEC_ENT").Value
            End If
        End If
    End Sub

    Private Sub dtpfecha_Validated(sender As Object, e As EventArgs) Handles dtpfecha.Validated
        Dim mes As String
        'If gsUser <> "SISTEMA" Then
        '    If sAño - dtpfecha.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfecha.Value.Month = "12" Then
        '        If DateTime.Now.ToString("dd") > 11 Then
        '            MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '            'cierre(False)
        '            'fechapasada = "Si"
        '            Exit Sub
        '        End If
        '    Else
        '        'If dtpfecha.Value.Month = "06" Then ' abre mes

        '        'Else
        '        If sAño > dtpfecha.Value.Year Or sAño < dtpfecha.Value.Year Then
        '            dtpfecha.Select()
        '            MsgBox("El año es mayor o menor al año actual", MsgBoxStyle.Information)
        '            'cierre(False)
        '            'fechapasada = "Si"
        '            Exit Sub
        '        End If

        '        If DateTime.Now.ToString("MM") <> dtpfecha.Value.Month Then

        '            If dtpfecha.Value.Month > DateTime.Now.ToString("MM") Then
        '                dtpfecha.Select()
        '                MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
        '                'cierre(False)
        '                'fechapasada = "Si"
        '                Exit Sub
        '            ElseIf dtpfecha.Value.Month < DateTime.Now.ToString("MM") Then
        '                'If CInt(sMes1) > dtpfecha.Value.Month Then
        '                mes = DateTime.Now.ToString("MM") - dtpfecha.Value.Month
        '                If mes = 1 Then
        '                    'Modificacion de de fechas 
        '                    'If DateTime.Now.ToString("dd") > 14 Then
        '                    If DateTime.Now.ToString("dd") > 11 Then
        '                        MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '                        'cierre(False)
        '                        'fechapasada = "Si"
        '                        Exit Sub
        '                    End If
        '                ElseIf mes > 1 Then
        '                    dtpfecha.Select()
        '                    MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
        '                    'cierre(False)
        '                    'fechapasada = "Si"
        '                    Exit Sub
        '                End If
        '                'End If
        '            End If

        '        End If
        '        If CInt(sMes2) < dtpfecha.Value.Month Then
        '            dtpfecha.Select()
        '            MsgBox("El mes es menor al permitido", MsgBoxStyle.Information)
        '            'cierre(False)
        '            'fechapasada = "Si"
        '            Exit Sub
        '        ElseIf CInt(sMes2) > dtpfecha.Value.Month Then
        '            mes = sMes2 - dtpfecha.Value.Month
        '            If mes = 1 Then
        '                'Modificacion de de fechas 
        '                'If DateTime.Now.ToString("dd") > 14 Then
        '                If DateTime.Now.ToString("dd") > 11 Then
        '                    MsgBox("Mes Cerrado", MsgBoxStyle.Information)
        '                    'cierre(False)
        '                    'fechapasada = "Si"
        '                    Exit Sub
        '                End If
        '            ElseIf mes > 1 Then
        '                dtpfecha.Select()
        '                MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
        '                'cierre(False)
        '                'fechapasada = "Si"
        '                Exit Sub
        '            End If
        '        End If


        '    End If
        'End If

        'termina el if del mes que se abrio
        'End If
        'cierre(True)
        'fechapasada = "No"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New FormAlbaran
        frm.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If dgvt_doc.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim frm As New FormDetDocumentoOP

        frm.lbltdoc.Text = txtt_doc.Text  '"09" 
        frm.lblsdoc.Text = cmb_serdoc.Text
        frm.lblndoc.Text = txtnumero.Text
        frm.lblart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
        frm.npdcantidad.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
        For l = 0 To dgvt_doc.Rows.Count - 1
            frm.cmbarticulo.Items.Add(dgvt_doc.Rows(l).Cells("ART_COD").Value)
        Next
        frm.Show()
    End Sub
    Private Sub SelDataOP()


        Dim DataOP As String = 0
        For l = 0 To dgvt_doc.Rows.Count - 1
            DataOP = GUIADESPACHOBL.SelectDataOP(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, dgvt_doc.Rows(l).Cells("ART_COD").Value)
        Next
        If flagAccion = "N" Then
            If DataOP = 0 Then
            Else
                'MessageBox.Show("Si")
                Dim ELTBDETDOCOPBE As New ELTBDETDOCOPBE
                ELTBDETDOCOPBE.T_DOC_REF = txtt_doc.Text
                ELTBDETDOCOPBE.SER_DOC_REF = cmb_serdoc.Text
                ELTBDETDOCOPBE.NRO_DOC_REF = txtnumero.Text

                gsError = ELTBDETDOCOPBL.SaveRow(ELTBDETDOCOPBE, "A", dgvt_doc)

            End If
        ElseIf flagAccion = "M" Then
        End If


    End Sub

    Private Sub btnFardo_Click(sender As Object, e As EventArgs) Handles btnFardo.Click
        sBusAlm = "FARDODETALMACEN"
        If dgvt_doc.Rows.Count > 0 Then
            If Mid(dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value, 1, 4) = "0201" Then
                Dim frm As New FormBUSQSELECTMULT
                frm.lblTdoc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF1").Value
                frm.lblSdoc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
                frm.lblNdoc.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                frm.lblGen.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
                frm.ShowDialog()
            Else
                MessageBox.Show("El Fardo no aplica a este articulo")
            End If
        Else
                MessageBox.Show("No hay items en la lista")
        End If
    End Sub

    Private Sub tsbGrabar_Click(sender As Object, e As EventArgs) Handles tsbGrabar.Click

    End Sub
#End Region
End Class