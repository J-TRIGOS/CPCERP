Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.Net.Mail
Public Class FormMantFCRecepComp
    Private ELTBRECEPCOMPBL As New ELTBRECEPCOMPBL
    Private ARTICULOBL As New ARTICULOBL
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private ELTBGRUPCORVALBL As New ELTBGRUPCORVALBL
    Private contador As Integer = "0"
    Private gcodcor As String = ""
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Private nrodocures As String
    'Private sArt_Cod As String = "0"

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
    Function cargar_orden()
        Dim creacion As String = ""
        Dim DAcumula As Double = 0
        Dim DAcumula1 As Double = 0
        Dim DAcumula2 As Double = 0
        Dim DAcumula3 As Double = 0
        Dim DAcumula4 As Double = 0
        Dim DAcumula5 As Double = 0
        For i = 0 To dgvt_doc.Rows.Count - 1
            'creacion = creacion & "<tr> 
            '            <td> Numero Orden: " & dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value & " Cliente " & dgvt_doc.Rows(i).Cells("CTCT_COD").Value & ":</td>
            '            <td> Articulo Orden " & dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value & " Cliente " & dgvt_doc.Rows(i).Cells("CTCT_COD").Value & ":</td>
            '            <td>" & dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value & " <br>
            '            CANTIDAD:" & Val(dgvt_doc.Rows(i).Cells("CANTIDAD").Value) & " </td>
            '            </tr>"
            creacion = creacion & "<tr> 
                        <td> Nro. O.C.: </td>
                        <td> " & dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value & " </td>
                        </tr>
                        <tr> 
                        <td> Nro. Req.: </td>
                        <td> " & ELTBRECEPCOMPBL.NumReq(dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value, "001", dgvt_doc.Rows(i).Cells("ART_COD").Value) & "</td>
                        </tr>
                        <tr> 
                        <td> Observa: </td>
                        <td> " & ELTBRECEPCOMPBL.SelDetObsReq(dgvt_doc.Rows(i).Cells("SER_DOC_REF1").Value, dgvt_doc.Rows(i).Cells("NRO_DOC_REF1").Value, dgvt_doc.Rows(i).Cells("ART_COD").Value) & "  </td>
                        </tr>
                        <tr> 
                        <td> Articulo: </td>
                        <td> " & dgvt_doc.Rows(i).Cells("ART_COD").Value & "-" & dgvt_doc.Rows(i).Cells("NOM_ART").Value & " <br>
                        CANTIDAD:" & Val(dgvt_doc.Rows(i).Cells("CANTIDAD").Value) & "-" & ARTICULOBL.SelectUniMed(Mid(dgvt_doc.Rows(i).Cells("ART_COD").Value, 1, 8)) & " </td>
                        </tr>"
        Next
        Return creacion
    End Function

    Sub enviarCorreo()
        Dim ss As Integer = 0
        For i = 0 To dgvt_doc.Rows.Count - 1
            If (dgvt_doc.Rows(0).Cells("NRO_DOCU2").Value).ToString.Length > 0 Then
                ss = ss + 1
            End If
        Next

        contador = contador + 1
        Dim tipo As String
        Dim creacion As String
        Dim creacion1 As String = ""
        Dim creacion2 As String = ""
        Dim precio1 As String
        'tipo = " ah creado la siguiente Recepcion de Documento: " + txtnro_doc_ref.Text
        creacion2 = cargar_orden()
        creacion = "Recepcion de Suministros "
        'precio1 = precio()
        Try
            Dim borde As String = "2"
            Dim size As String = "12"
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.To.Clear()
            correos.SubjectEncoding = System.Text.Encoding.UTF8
            creacion2 = cargar_orden()
            correos.Body = " Estimados Señores:<br/>
              El usuario " + gsUser + tipo + " a Registrado un documento<br/>
            <table border= '" + borde + "' style=font-size:" + size + "px>
            <tr>       
                    <td> Cliente: </td>
                    <td> " & dgvt_doc.Rows(0).Cells("CTCT_COD").Value & "-" & dgvt_doc.Rows(0).Cells("NOM_CTCT").Value & " </td>
            </tr>"
            If ss > 0 Then
                correos.Body = correos.Body + "<tr>
                    <td>Guia Creada: </td>
                    <td>ALM-" & dgvt_doc.Rows(0).Cells("NRO_DOCU2").Value & "-" & dtpfec_gene.Value.Date & "</td>
                </tr>
                <tr>
                    <td>Fecha Creacion: </td>
                    <td>" & ELTBRECEPCOMPBL.FecCreacion(dgvt_doc.Rows(0).Cells("NRO_DOCU2").Value) & "</td>
                </tr>
                <tr>
                    <td>Observa: </td>
                    <td>" & ELTBRECEPCOMPBL.SelObsReq(dgvt_doc.Rows(0).Cells("SER_DOC_REF1").Value, dgvt_doc.Rows(0).Cells("NRO_DOC_REF1").Value) & "</td>
                </tr>
                <tr>
                    <td>Almacen: </td>
                    <td> " & cmbalmacen.Text & "</td>
                </tr>"
            End If
            correos.Body = correos.Body + creacion2 +
               "</table> <br/>" & "Codigo Grupo:" & gcodcor & " Nombre :" & ARTICULOBL.SelectNomGrupCor(gcodcor)
            correos.Subject = creacion
            correos.IsBodyHtml = True
            correos.BodyEncoding = System.Text.Encoding.UTF8
            For i = 0 To lstValor.Items.Count - 1
                correos.To.Add(lstValor.Items(i).ToString)
            Next
            correos.To.Add("jalama@envaseslux.com")
            correos.From = New MailAddress("sistemas@envaseslux.com")
            envios.Credentials = New NetworkCredential("sistemas@envaseslux.com", "elsistemas")

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "mail.envaseslux.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            'MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dt As DataTable
        Dim Registro As DataRow
        'MODIFICAR
        dt = ELTBRECEPCOMPBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)
        For Each Registro In dt.Rows
            dtpfec_gene.Value = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            txtobservacion.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            txtnro_doc_ref.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            cmb_serdoc.Text = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
        Next
    End Sub
    Private Sub FormMantFCRecepComp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Me.Text = "Recepcion Comprobantes"
        Me.cmb_serdoc.Text = sAño
        dt = REQUERIMIENTOBL.SelectAlmac("N")
        GetCmb("ALM_CODIGO", "ALM_DESCRI", dt, cmbalmacen)
        dgvt_doc.Columns.Add("T_DOC_REF", "Documento") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero") '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie") '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero") '5
        dgvt_doc.Columns.Add("T_DOCU", "T. Doc.") '6
        dgvt_doc.Columns.Add("SER_DOCU", "Ser.Fact.") '7
        dgvt_doc.Columns.Add("NRO_DOCU", "Nro.Fact") '8
        dgvt_doc.Columns.Add("SER_DOCU1", "Ser.Guia") '9
        dgvt_doc.Columns.Add("Nro_DOCU1", "Nro.Guia") '10
        dgvt_doc.Columns.Add("CTCT_COD", "RUC/RAZ. SOCIAL") '11
        dgvt_doc.Columns.Add("NOM_CTCT", "Proveedor") '12
        dgvt_doc.Columns.Add("CANTIDAD", "Cantidad") '13
        dgvt_doc.Columns.Add("ART_COD", "Cod. Art.") '14
        dgvt_doc.Columns.Add("NOM_ART", "Nom. Art.") '15
        dgvt_doc.Columns.Add("FEC_GENE", "Fecha Llegada.") '16
        'dgvt_doc.Columns.Add("LOTE", "Lote") '17
        dgvt_doc.Columns.Add("CCO_COD", "CCO_COD") '17
        dgvt_doc.Columns.Add("ACT_COD", "ACT_COD") '18
        dgvt_doc.Columns.Add("PER_COD", "PER_COD") '19
        dgvt_doc.Columns.Add("SREQ", "SREQ") '20
        dgvt_doc.Columns.Add("NREQ", "NREQ") '21
        dgvt_doc.Columns.Add("UNIDAD", "UNIDAD") '22
        dgvt_doc.Columns.Add("ART_VENTA", "ART_VENTA") '23  'New
        dgvt_doc.Columns.Add("EST", "UNIDAD") '24
        dgvt_doc.Columns.Add("CT", "CT") '25
        dgvt_doc.Columns.Add("NRO_DOCU2", "NRO_DOCU2") '26
        dgvt_doc.Columns.Add("NRO_DOCU3", "NRO_DOCU3") '27
        dgvt_doc.Columns.Add("SER_DOCU3", "SER_DOCU3") '28

        Dim nro As String
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                'chksalida.Enabled = True
                cmbalmacen.SelectedIndex = 0
                nro = ELTBRECEPCOMPBL.SelectNro1(cmb_serdoc.Text)

                Select Case cmb_serdoc.SelectedIndex
                    Case 0 '001
                        If nro.Length = 1 Then
                            txtnro_doc_ref.Text = "000000" & nro
                        ElseIf nro.Length = 2 Then
                            txtnro_doc_ref.Text = "00000" & nro
                        ElseIf nro.Length = 3 Then
                            txtnro_doc_ref.Text = "0000" & nro
                        ElseIf nro.Length = 4 Then
                            txtnro_doc_ref.Text = "000" & nro
                        ElseIf nro.Length = 5 Then
                            txtnro_doc_ref.Text = "00" & nro
                        ElseIf nro.Length = 6 Then
                            txtnro_doc_ref.Text = "0" & nro
                        ElseIf nro.Length = 7 Then
                            txtnro_doc_ref.Text = nro
                        End If
                End Select
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                dgvt_doc.Columns(3).Visible = False
                dgvt_doc.Columns(16).Visible = False
                'dgvt_doc.Columns(27).Visible = False
                dgvt_doc.Columns(18).Visible = False
                dgvt_doc.Columns(19).Visible = False
                dgvt_doc.Columns(20).Visible = False
                dgvt_doc.Columns(21).Visible = False
                dgvt_doc.Columns(22).Visible = False
                dgvt_doc.Columns(23).Visible = False
                dgvt_doc.Columns(24).Visible = False
                'dgvt_doc.Columns(25).Visible = False
                dgvt_doc.Columns(26).Visible = False
                dgvt_doc.Columns(27).Visible = False
                dgvt_doc.Columns(28).Visible = False
                'dgvt_doc.Columns(29).Visible = False
            Case 1
                flagAccion = "M"
                Dim s As String
                GetData(sTDoc, sSDoc, sNDoc)

                Dim dtArticulo As DataTable
                dtArticulo = ELTBRECEPCOMPBL.getListdgv(sTDoc, sSDoc, sNDoc)
                For Each row As DataRow In dtArticulo.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                      IIf(IsDBNull(row("T_DOCU")), "", row("T_DOCU")),'6
                                      IIf(IsDBNull(row("SER_DOCU")), "", row("SER_DOCU")),'7
                                      IIf(IsDBNull(row("NRO_DOCU")), "", row("NRO_DOCU")),'8
                                      IIf(IsDBNull(row("SER_DOCU1")), "", row("SER_DOCU1")),'9
                                      IIf(IsDBNull(row("NRO_DOCU1")), "", row("NRO_DOCU1")),'10
                                      IIf(IsDBNull(row("PROVEEDOR")), "", row("PROVEEDOR")),'11
                                      IIf(IsDBNull(row("NOM_PROVEEDOR")), "", row("NOM_PROVEEDOR")),'12
                                      IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),'13
                                      IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'14
                                      IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")), '15
                                      IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")), '16'IIf(IsDBNull(row("LOTE")), "", row("LOTE")), '17
                                      IIf(IsDBNull(row("CCO_COD")), "", row("CCO_COD")),'17,
                                      IIf(IsDBNull(row("ACT_COD")), "", row("ACT_COD")),'18,
                                      IIf(IsDBNull(row("PER_COD")), "", row("PER_COD")),'19,
                                      IIf(IsDBNull(row("SREQ")), "", row("SREQ")),'20,
                                      IIf(IsDBNull(row("NREQ")), "", row("NREQ")),'21
                                      IIf(IsDBNull(row("UNIDAD")), "", row("UNIDAD")),  '22
                                      IIf(IsDBNull(row("ART_VENTA")), "", row("ART_VENTA")),'23
                                      IIf(IsDBNull(row("EST")), "", row("EST")),'24
                                      IIf(IsDBNull(row("CT")), "", row("CT")),'25
                                      IIf(IsDBNull(row("NRO_DOCU2")), "", row("NRO_DOCU2")),'26
                                      IIf(IsDBNull(row("NRO_DOCU3")), "", row("NRO_DOCU3")),'27
                                      IIf(IsDBNull(row("SER_DOCU3")), "", row("SER_DOCU3"))) '28

                    s = IIf(IsDBNull(row("NRO_DOCU2")), "", row("NRO_DOCU2"))
                Next
                If dgvt_doc.Rows(0).Cells("NRO_DOCU3").Value <> "" Then
                    chksalida.Checked = True
                End If
                Try
                    cmbalmacen.SelectedValue = GUIAALMACENBL.SelectAlm("SALM", "ALM", s)
                Catch ex As Exception

                End Try

                Dim i As Integer
                For i = 0 To 15
                    dgvt_doc.Columns(i).ReadOnly = True
                Next
                dgvt_doc.Columns(0).Visible = False
                dgvt_doc.Columns(1).Visible = False
                dgvt_doc.Columns(2).Visible = False
                dgvt_doc.Columns(3).Visible = False
                dgvt_doc.Columns(16).Visible = False
                'dgvt_doc.Columns(27).Visible = False
                'dgvt_doc.Columns(18).Visible = False
                dgvt_doc.Columns(19).Visible = False
                dgvt_doc.Columns(20).Visible = False
                dgvt_doc.Columns(21).Visible = False
                dgvt_doc.Columns(22).Visible = False
                dgvt_doc.Columns(23).Visible = False
                dgvt_doc.Columns(24).Visible = False
                'dgvt_doc.Columns(25).Visible = False
                dgvt_doc.Columns(26).Visible = False
                dgvt_doc.Columns(27).Visible = False
                dgvt_doc.Columns(28).Visible = False
                dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(4)
        End Select
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            End If
            If nrodocures = "" Then
                nrodocures = dgvt_doc.Rows(0).Cells("NRO_DOCU2").Value
            End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()
        Else
            MsgBox("No hay datos")
        End If

    End Sub

    Private Sub FormMantFCRecepComp_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim frm As New FormMantDetFCRecepComp
        gnOpcion2 = 1
        frm.ShowDialog()
        gnOpcion2 = ""
    End Sub

    Private Sub btndocu_Click(sender As Object, e As EventArgs) Handles btndocu.Click
        Dim frm As New FormDocuRefRecep
        frm.ShowDialog()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        'Dim dt As DataTable
        If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("EST").Value = "3" Then
            MsgBox("Este Articulo ya ah sido Recepcionado")
            Exit Sub
        End If
        If dgvt_doc.Rows.Count > 0 Then
            Dim frm As New FormMantDetFCRecepComp
            frm.txtcodart.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("ART_COD").Value
            frm.txtnom_art.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM_ART").Value
            frm.txtproveedor.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTCT_COD").Value
            frm.txtnom_proveedor.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM_CTCT").Value
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOCU").Value = "01" Then
                frm.cmbt_doc.SelectedIndex = 0
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOCU").Value = "03" Then
                frm.cmbt_doc.SelectedIndex = 1
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOCU").Value = "07" Then
                frm.cmbt_doc.SelectedIndex = 2
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOCU").Value = "08" Then
                frm.cmbt_doc.SelectedIndex = 3
            End If
            frm.txtnro_docu.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU").Value
            frm.txtser_docu.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOCU").Value
            frm.txtnro_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
            frm.txtser_docu1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOCU1").Value
            frm.txtnro_doc_ref1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
            frm.cmbser_doc_ref1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF1").Value
            frm.txtproveedor.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CTCT_COD").Value
            frm.txtnom_proveedor.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM_CTCT").Value
            frm.npdcantidad.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("CANTIDAD").Value
            frm.dtpfec_gene.Value = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("FEC_GENE").Value
            gnOpcion2 = 0
            frm.ShowDialog()
            gnOpcion2 = ""
        Else
            MsgBox("No Hay datos para modificar")
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
                    gsRptArgs = {}
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = "SALM"
                    gsRptArgs(1) = "ALM"
                    For i = 0 To dgvt_doc.Rows.Count - 1
                        If dgvt_doc.Rows(0).Cells("NRO_DOCU2").Value <> "" Then
                            gsRptArgs(2) = dgvt_doc.Rows(i).Cells("NRO_DOCU2").Value
                        End If
                    Next
                    'gsRptArgs(2)
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_VALE.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Case "Prins"
                    gsRptArgs = {}
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = "SALM"
                    gsRptArgs(1) = "002"
                    For i = 0 To dgvt_doc.Rows.Count - 1
                        If dgvt_doc.Rows(0).Cells("NRO_DOCU3").Value <> "" Then
                            gsRptArgs(2) = dgvt_doc.Rows(i).Cells("NRO_DOCU3").Value
                        End If
                    Next
                    'gsRptArgs(2) = dgvt_doc.Rows(0).Cells("NRO_DOCU3").Value
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_VALE.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Case "anular"

                    If MessageBox.Show("Desea anular el documento",
                       Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If
                    Dim ELTBRECEPCOMPBE As New ELTBRECEPCOMPBE
                    Dim ELTBDETRECEPCOMPBE As New ELTBDETRECEPCOMPBE
                    ELTBRECEPCOMPBE.T_DOC_REF = txtt_doc_ref.Text
                    ELTBRECEPCOMPBE.NRO_DOC_REF = txtnro_doc_ref.Text
                    ELTBRECEPCOMPBE.SER_DOC_REF = cmb_serdoc.Text
                    ELTBDETRECEPCOMPBE.NRO_DOCU2 = dgvt_doc.Rows(0).Cells("NRO_DOCU2").Value

                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = ELTBRECEPCOMPBL.SaveRow(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, "AN", dgvt_doc)

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
    Private Sub SaveData()
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("El Documento no tiene items")
            Exit Sub
        End If
        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        Dim nro As String
        Dim mesaño As String
        Dim m As String
        Dim m1 As Integer = 0
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBRECEPCOMPBE As New ELTBRECEPCOMPBE
        Dim ELTBDETRECEPCOMPBE As New ELTBDETRECEPCOMPBE
        Dim GUIAALMACENBE As New GUIAALMACENBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        Dim ELMVALMABE As New ELMVALMABE
        For i = 0 To dgvt_doc.Rows.Count - 1
            'dtart = ELTBRECEPCOMPBL.SelectTipArt(dgvt_doc.Rows(i).Cells("ART_COD").Value)
            If dgvt_doc.Rows(i).Cells("CT").Value = "" Then
                m1 = m1 + 1
            End If
        Next
        If flagAccion = "N" Then
            nro = ELTBRECEPCOMPBL.SelectNro1(cmb_serdoc.Text)
            If nro.Length = 1 Then
                txtnro_doc_ref.Text = "000000" & nro
            ElseIf nro.Length = 2 Then
                txtnro_doc_ref.Text = "00000" & nro
            ElseIf nro.Length = 3 Then
                txtnro_doc_ref.Text = "0000" & nro
            ElseIf nro.Length = 4 Then
                txtnro_doc_ref.Text = "000" & nro
            ElseIf nro.Length = 5 Then
                txtnro_doc_ref.Text = "00" & nro
            ElseIf nro.Length = 6 Then
                txtnro_doc_ref.Text = "0" & nro
            ElseIf nro.Length = 7 Then
                txtnro_doc_ref.Text = nro
            End If
            If m1 <> dgvt_doc.Rows.Count Then
                nro = ARTICULOBL.SelectNro("SALM", "ALM")
                If nro.Length >= 6 Then
                    GUIAALMACENBE.NRO_DOC_REF = "0" & nro
                    ELTBDETRECEPCOMPBE.NRO_DOCU2 = "0" & nro
                    dgvt_doc.Rows(0).Cells("NRO_DOCU2").Value = ELTBDETRECEPCOMPBE.NRO_DOCU2
                Else
                    GUIAALMACENBE.NRO_DOC_REF = nro
                    ELTBDETRECEPCOMPBE.NRO_DOCU2 = nro
                    dgvt_doc.Rows(0).Cells("NRO_DOCU2").Value = ELTBDETRECEPCOMPBE.NRO_DOCU2
                End If
            End If
        Else
            ELTBDETRECEPCOMPBE.NRO_DOCU2 = dgvt_doc.Rows(0).Cells("NRO_DOCU2").Value
            ELTBDETRECEPCOMPBE.NRO_DOCU3 = dgvt_doc.Rows(0).Cells("NRO_DOCU3").Value
            ELTBDETRECEPCOMPBE.SER_DOCU3 = dgvt_doc.Rows(0).Cells("SER_DOCU3").Value
            If ELTBDETRECEPCOMPBE.NRO_DOCU2 = "" Then
                ELTBDETRECEPCOMPBE.NRO_DOCU2 = nrodocures
            End If
        End If

        ELTBRECEPCOMPBE.T_DOC_REF = txtt_doc_ref.Text
        ELTBRECEPCOMPBE.NRO_DOC_REF = txtnro_doc_ref.Text
        ELTBRECEPCOMPBE.SER_DOC_REF = cmb_serdoc.Text
        ELTBRECEPCOMPBE.FEC_GENE = dtpfec_gene.Value
        ELTBRECEPCOMPBE.USUARIO = gsCodUsr
        ELTBRECEPCOMPBE.OBSERVA = txtobservacion.Text
        ELMVLOGSBE.log_codusu = gsCodUsr

        'CREACION DE GUIA DE ALMACEN
        GUIAALMACENBE.T_DOC_REF = "SALM"
        GUIAALMACENBE.SER_DOC_REF = "ALM"
        GUIAALMACENBE.ART_COD = "02170001"
        GUIAALMACENBE.FEC_GENE = RTrim(dtpfec_gene.Value)
        GUIAALMACENBE.T_MOVINV = "E19"
        GUIAALMACENBE.F_PAGO_ENT = ""
        GUIAALMACENBE.FOR_ENT_COD = ""
        GUIAALMACENBE.EST = "H"
        GUIAALMACENBE.ALMAC = "E"
        GUIAALMACENBE.OBSERVA = RTrim(txtobservacion.Text)
        GUIAALMACENBE.MONEDA = ""
        GUIAALMACENBE.SIGNO = "+"
        GUIAALMACENBE.OBSERVA1 = ""
        GUIAALMACENBE.DIR_COD = ""
        'GUIAALMACENBE.CTCT_COD = RTrim(.Text)
        'GUIAALMACENBE.PER_COD = 
        'GUIAALMACENBE.CCO_COD = 
        GUIAALMACENBE.USUARIO = RTrim(gsUser)
        GUIAALMACENBE.FEC_DIA = RTrim(DateTime.Now)
        DET_DOCUMENTOBE.ALM_COD = gsCodAlm
        DET_DOCUMENTOBE.T_DOC_REF = "SALM"
        DET_DOCUMENTOBE.SER_DOC_REF = "ALM"
        DET_DOCUMENTOBE.NRO_DOC_REF = ELTBDETRECEPCOMPBE.NRO_DOCU2
        GUIAALMACENBE.PROVEEDOR = "20100279348"
        GUIAALMACENBE.CTCT_COD = dgvt_doc.Rows(0).Cells("CTCT_COD").Value
        GUIAALMACENBE.PER_COD = dgvt_doc.Rows(0).Cells("PER_COD").Value
        GUIAALMACENBE.CCO_COD = dgvt_doc.Rows(0).Cells("CCO_COD").Value
        GUIAALMACENBE.NOM_CTCT = dgvt_doc.Rows(0).Cells("NOM_CTCT").Value
        GUIAALMACENBE.ALM_COD = cmbalmacen.SelectedValue

        gsError = ELTBRECEPCOMPBL.SaveRow(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, flagAccion, dgvt_doc)
        'gsError2 = GUIAALMACENBL.SaveRow(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "CN", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'tsbGrabar.Enabled = False
            'Dim dtart As DataTable
            If flagAccion = "N" Then
                Dim ca As Integer = 0
                If gsUser <> "SISTEMA" Then
                    For i = 0 To dgvt_doc.Rows.Count - 1
                        'dtart = ELTBRECEPCOMPBL.SelectTipArt(dgvt_doc.Rows(i).Cells("ART_COD").Value)
                        If dgvt_doc.Rows(i).Cells("CT").Value = "" Then
                            ca = ca + 1
                        End If
                    Next
                Else
                    ca = 0
                End If
                If ca <> dgvt_doc.Rows.Count Then
                    gsError2 = ELTBRECEPCOMPBL.SaveRowGuia(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "CN", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
                    If gsError2 = "OK" Then
                        MsgBox("Datos del vale Grabados Correctamente", MsgBoxStyle.Information)
                        If chksalida.Checked Then
                            Dim fecaño As String = dtpfec_gene.Value.Year
                            Dim fecmes As String = dtpfec_gene.Value.Month
                            If fecmes.Length = 1 Then
                                fecmes = "0" & fecmes
                            End If
                            nro = ARTICULOBL.SelectNro1("SALM", "002", fecaño & fecmes)
                            GUIAALMACENBE.NRO_DOC_REF = nro
                            ELTBDETRECEPCOMPBE.NRO_DOCU3 = nro
                            dgvt_doc.Rows(0).Cells("NRO_DOCU3").Value = ELTBDETRECEPCOMPBE.NRO_DOCU3
                            GUIAALMACENBE.NRO_DOCU3 = txtnro_doc_ref.Text
                            GUIAALMACENBE.SER_DOCU3 = cmb_serdoc.Text
                            gsError3 = ELTBRECEPCOMPBL.SaveRowGuia(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "CS", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
                            If gsError3 = "OK" Then
                                MsgBox("Datos del vale de Salida Grabados Correctamente", MsgBoxStyle.Information)
                            Else
                                FormMain.LblError.Text = gsError3
                                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                            End If
                        End If

                    Else
                        FormMain.LblError.Text = gsError2
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                    lstValor.Items.Clear()
                    ELTBGRUPCORVALBL.SelectRow1("0006", lstValor)
                    gcodcor = "0006"
                    enviarCorreo()
                End If
                If flagAccion = "N" Then
                    flagAccion = "M"
                End If
            Else
                Dim ca As Integer = ca
                For i = 0 To dgvt_doc.Rows.Count - 1
                    If dgvt_doc.Rows(i).Cells("CT").Value = "" Then
                        ca = ca + 1
                    End If
                Next
                If ca <> dgvt_doc.Rows.Count Then
                    GUIAALMACENBE.NRO_DOC_REF = ELTBDETRECEPCOMPBE.NRO_DOCU2
                    GUIAALMACENBE.T_DOC_REF = "SALM"
                    GUIAALMACENBE.SER_DOC_REF = "ALM"
                    gsError2 = ELTBRECEPCOMPBL.SaveRowGuia(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "CM", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
                    If gsError2 = "OK" Then
                        'MsgBox("Datos del vale Grabados Correctamente", MsgBoxStyle.Information)
                        If chksalida.Checked Then
                            GUIAALMACENBE.NRO_DOC_REF = dgvt_doc.Rows(0).Cells("NRO_DOCU3").Value
                            GUIAALMACENBE.T_DOC_REF = "SALM"
                            GUIAALMACENBE.SER_DOC_REF = "002"
                            'If dgvt_doc.Rows(0).Cells("NRO_DOCU3").Value Then
                            gsError3 = ELTBRECEPCOMPBL.SaveRowGuia(GUIAALMACENBE, DET_DOCUMENTOBE, ELMVALMABE, ELMVLOGSBE, "CMS", dgvt_doc, cmb_serdoc.Text, sEstAlmac)
                            If gsError3 = "OK" Then
                                MsgBox("Datos del vale de Salida Grabados Correctamente", MsgBoxStyle.Information)
                            Else
                                FormMain.LblError.Text = gsError3
                                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                            End If
                            'End If
                        End If
                    Else
                        FormMain.LblError.Text = gsError2
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Function OkData() As Boolean
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("Ingrese al menos un campo de detalle", MsgBoxStyle.Exclamation)
            btndocu.Select()
            Return False
        End If
        If dtpfec_gene.Value.Year <> cmb_serdoc.Text Then
            MsgBox("El año es distinto al que se intenta declarar", MsgBoxStyle.Exclamation)
            btndocu.Select()
            Return False
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvt_doc.Rows.Count = 0 Then
            MsgBox("El documento no tiene ningun articulo favor de ingresar al menos un item")
            Exit Sub
        Else
            Dim frm As New FormDetRecepComp
            If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOCU").Value = "01" Then
                frm.cmbt_doc.SelectedIndex = 0
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOCU").Value = "03" Then
                frm.cmbt_doc.SelectedIndex = 1
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOCU").Value = "07" Then
                frm.cmbt_doc.SelectedIndex = 2
            ElseIf dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOCU").Value = "08" Then
                frm.cmbt_doc.SelectedIndex = 3
            End If
            frm.txtnumero.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU").Value
            frm.txtserie.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOCU").Value
            frm.txtserie1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOCU1").Value
            frm.txtnumero1.Text = dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOCU1").Value
            frm.ShowDialog()
        End If

    End Sub

    Private Sub dtpfec_gene_Validated(sender As Object, e As EventArgs) Handles dtpfec_gene.Validated
        Dim mes As String
        If gsUser <> "SISTEMA" Then
            If sAño - dtpfec_gene.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfec_gene.Value.Month = "12" Then
                If DateTime.Now.ToString("dd") > 11 Then
                    MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Else
                If sAño > dtpfec_gene.Value.Year Or sAño < dtpfec_gene.Value.Year Then
                    dtpfec_gene.Select()
                    MsgBox("El año es mayor o menor al año actual", MsgBoxStyle.Information)
                    Exit Sub
                End If

                If DateTime.Now.ToString("MM") <> dtpfec_gene.Value.Month Then

                    If dtpfec_gene.Value.Month > DateTime.Now.ToString("MM") Then
                        dtpfec_gene.Select()
                        MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                        Exit Sub
                    ElseIf dtpfec_gene.Value.Month < DateTime.Now.ToString("MM") Then
                        'If CInt(sMes1) > dtpfecha.Value.Month Then
                        mes = DateTime.Now.ToString("MM") - dtpfec_gene.Value.Month
                        If mes = 1 Then
                            'Modificacion de de fechas 
                            'If DateTime.Now.ToString("dd") > 14 Then
                            If DateTime.Now.ToString("dd") > 11 Then
                                MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                                Exit Sub
                            End If
                        ElseIf mes > 1 Then
                            dtpfec_gene.Select()
                            MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        'End If
                    End If

                End If
                If CInt(sMes2) < dtpfec_gene.Value.Month Then
                    dtpfec_gene.Select()
                    MsgBox("El mes es menor al permitido", MsgBoxStyle.Information)
                    Exit Sub
                ElseIf CInt(sMes2) > dtpfec_gene.Value.Month Then
                    mes = sMes2 - dtpfec_gene.Value.Month
                    If mes = 1 Then
                        'Modificacion de de fechas 
                        'If DateTime.Now.ToString("dd") > 14 Then
                        If DateTime.Now.ToString("dd") > 11 Then
                            MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                    ElseIf mes > 1 Then
                        dtpfec_gene.Select()
                        MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        Dim nro As String
        nro = ELTBRECEPCOMPBL.SelectNro1(cmb_serdoc.Text)
        If nro.Length = 1 Then
            txtnro_doc_ref.Text = "000000" & nro
        ElseIf nro.Length = 2 Then
            txtnro_doc_ref.Text = "00000" & nro
        ElseIf nro.Length = 3 Then
            txtnro_doc_ref.Text = "0000" & nro
        ElseIf nro.Length = 4 Then
            txtnro_doc_ref.Text = "000" & nro
        ElseIf nro.Length = 5 Then
            txtnro_doc_ref.Text = "00" & nro
        ElseIf nro.Length = 6 Then
            txtnro_doc_ref.Text = "0" & nro
        ElseIf nro.Length = 7 Then
            txtnro_doc_ref.Text = nro
                End If

    End Sub

    Private Sub dtpfec_gene_LostFocus(sender As Object, e As EventArgs) Handles dtpfec_gene.LostFocus
        Dim mes As String
        If sAño - dtpfec_gene.Value.Year = 1 And DateTime.Now.ToString("MM") = "01" And dtpfec_gene.Value.Month = "12" Then
            If DateTime.Now.ToString("dd") > 11 Then
                MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                If gsUser <> "SISTEMA" Then
                    tsbGrabar.Enabled = False
                    btnagregar.Enabled = False
                    btnmodificar.Enabled = False
                End If
                'cierre(False)
                'fechapasada = "Si"
                Exit Sub
            End If
        Else
            'If dtpfecha.Value.Month = "06" Then ' abre mes

            'Else
            If sAño > dtpfec_gene.Value.Year Or sAño < dtpfec_gene.Value.Year Then
                dtpfec_gene.Select()
                MsgBox("El año es mayor o menor al año actual", MsgBoxStyle.Information)
                'cierre(False)
                'fechapasada = "Si"
                Exit Sub
            End If

            If DateTime.Now.ToString("MM") <> dtpfec_gene.Value.Month Then

                If dtpfec_gene.Value.Month > DateTime.Now.ToString("MM") Then
                    dtpfec_gene.Select()
                    MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                    'cierre(False)
                    'fechapasada = "Si"
                    Exit Sub
                ElseIf dtpfec_gene.Value.Month < DateTime.Now.ToString("MM") Then
                    'If CInt(sMes1) > dtpfecha.Value.Month Then
                    mes = DateTime.Now.ToString("MM") - dtpfec_gene.Value.Month
                    If mes = 1 Then
                        'Modificacion de de fechas 
                        'If DateTime.Now.ToString("dd") > 14 Then
                        If DateTime.Now.ToString("dd") > 11 Then
                            MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                            'cierre(False)
                            'fechapasada = "Si"
                            Exit Sub
                        End If
                    ElseIf mes > 1 Then
                        dtpfec_gene.Select()
                        MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                        'cierre(False)
                        'fechapasada = "Si"
                        Exit Sub
                    End If
                    'End If
                End If

            End If
            If CInt(sMes2) < dtpfec_gene.Value.Month Then
                dtpfec_gene.Select()
                MsgBox("El mes es menor al permitido", MsgBoxStyle.Information)
                'cierre(False)
                'fechapasada = "Si"
                Exit Sub
            ElseIf CInt(sMes2) > dtpfec_gene.Value.Month Then
                mes = sMes2 - dtpfec_gene.Value.Month
                If mes = 1 Then
                    'Modificacion de de fechas 
                    'If DateTime.Now.ToString("dd") > 14 Then
                    If DateTime.Now.ToString("dd") > 11 Then
                        MsgBox("Mes Cerrado", MsgBoxStyle.Information)
                        'cierre(False)
                        'fechapasada = "Si"
                        Exit Sub
                    End If
                ElseIf mes > 1 Then
                    dtpfec_gene.Select()
                    MsgBox("El mes es mayor al permitido", MsgBoxStyle.Information)
                    'cierre(False)
                    'fechapasada = "Si"
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub btncorreo_Click(sender As Object, e As EventArgs) Handles btncorreo.Click
        Dim S As String
        S = flagAccion
        gsCode13 = "RC"
        Dim frm As New FormMantEltbgrupcorval
        frm.ShowDialog()
        gsCode13 = ""
        flagAccion = S
    End Sub
End Class

