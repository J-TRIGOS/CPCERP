Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.Net.Mail
Imports vb = Microsoft.VisualBasic
Public Class FormMantArticulo
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private gcodcor As String = ""
    Private ARTICULOBL As New ARTICULOBL
    Private ELFUNCIONESBL As New ELFUNCIONESBL
    Private ELTBESPEBL As New ELTBESPEBL
    Private ELTBCOMPBL As New ELTBCOMPBL
    Private ELTBPROCBL As New ELTBPROCBL
    Private DET_DOCUMENTOBL As New DET_DOCUMENTOBL
    Private flagAccion As String = ""
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private valor As Boolean = True
    Private code As String = ""
    Private bTercero As Boolean = True
    Private bCuarto As Boolean = True
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Private ELTBGRUPCORVALBL As New ELTBGRUPCORVALBL
    Private MenuBL As New MenuBL
    Private contador As Integer = "0"
    '   Private FunctionsBL As New FunctionsBL
#Region "Limpieza"
    Private Sub CleanVar()

        txtcodigo.Clear() 'ELTBLINESBL.LastCodigo()
        txtartcodigo.Clear()
        txtartdescripcion.Clear()
        cmbcentrocosto.SelectedIndex = -1
        cmbcodalmacen.SelectedIndex = -1
        cmbunidadmedida.SelectedIndex = -1
        'cmbubicacionalm.SelectedIndex = -1
        cmbestado.SelectedIndex = -1
        cmbkardex.SelectedIndex = -1
        txtcodfamcontable.Clear()
        cmblinea.Enabled = False
        txtstock.Clear()
        txtcodigo.Clear()
        txtnom.Clear()
        txtdato.Clear()
        cmbfamilia1.SelectedIndex = -1
        cmbfamilia2.SelectedIndex = -1
        cmbfamilia3.SelectedIndex = -1
        cmbfamilia4.SelectedIndex = -1
        cmbfamilia5.SelectedIndex = -1
    End Sub

#End Region

#Region "Llenar combos"

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

#End Region

#Region "Correo"
    Function cargar_matrix()
        Dim creacion As String
        For i = 0 To dgvcatalogo.Rows.Count - 1
            creacion = creacion & "<tr> <td>" & dgvcatalogo.Rows(i).Cells("CAR_DESCRI").Value & "</td>
                    <td>" & dgvcatalogo.Rows(i).Cells("ESP_DATO").Value & "</td>
                    </tr>"
        Next
        Return creacion
    End Function

    Sub enviarCorreo()
        contador = contador + 1
        Dim tipo As String
        Dim creacion As String
        Dim creacion1 As String = ""
        Dim size As String = "13"
        If flagAccion = "N" Then
            tipo = " ah creado un NUEVO articulo"
            creacion = "Creacion de Articulo"
        ElseIf flagAccion = "M" Then
            tipo = " ah MODIFICADO el siguiente articulo"
            creacion = "Modificacion de Articulo"
        End If

        Try
            Dim borde As String = "2"
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.SubjectEncoding = System.Text.Encoding.UTF8
            creacion1 = cargar_matrix()
            correos.Body = " Estimados Señores:<br/>
               El usuario " + gsUser + tipo + "<br/>
            <table border= '" + borde + "' style='font-size:" + size + "px'>
                <tr>
                    <td>Codigo:" + txtartcodigo.Text + "</td>
                    <td>Articulo:" + txtartdescripcion.Text + "</td>
                </tr>" + creacion1 + " </table> <br/>" & "Codigo Grupo:" & gcodcor & " Nombre :" & ARTICULOBL.SelectNomGrupCor(gcodcor)
            correos.Subject = creacion
            'creacion = creacion & "Codigo Grupo:" & gcodcor & " Nombre :" & ARTICULOBL.SelectNomGrupCor(gcodcor)
            correos.IsBodyHtml = True
            correos.BodyEncoding = System.Text.Encoding.UTF8
            For i = 0 To lstValor.Items.Count - 1
                correos.To.Add(lstValor.Items(i).ToString)
            Next
            'correos.To.Add("jalama@envaseslux.com")
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
    Sub enviarCorreo1()
        contador = contador + 1
        Dim tipo As String
        Dim creacion As String
        Dim creacion1 As String = ""
        Dim size As String = "13"
        If flagAccion = "N" Then
            tipo = " ah creado un NUEVO articulo"
            creacion = "Creacion de Articulo"
        ElseIf flagAccion = "M" Then
            tipo = " ah MODIFICADO el siguiente articulo"
            creacion = "Modificacion de Articulo"
        End If

        Try
            Dim borde As String = "2"
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.SubjectEncoding = System.Text.Encoding.UTF8
            creacion1 = cargar_matrix()
            correos.Body = " Estimados Señor(as):<br/>
               Se ah creado el articulo con Codigo " + txtartcodigo.Text + "<br/>
               y Descripcion " + txtartdescripcion.Text + "<br/>" & "Codigo Grupo:" & gcodcor & " Nombre :" & ARTICULOBL.SelectNomGrupCor(gcodcor)
            correos.Subject = creacion
            correos.IsBodyHtml = True
            correos.BodyEncoding = System.Text.Encoding.UTF8
            For i = 0 To lstValor.Items.Count - 1
                correos.To.Add(lstValor.Items(i).ToString)
            Next
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
#End Region

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
        End Select
    End Sub

    Private Function gHeader(ByVal dt As DataGridView) As DataTable
        Dim iI As Integer = 0
        Dim dt2 As DataTable
        Dim row As DataRow
        Try
            For iI = 0 To dt.Columns.Count - 1
                dt2 = ELFUNCIONESBL.SelectNomColumn(RTrim(dt.Columns.Item(iI).Name.ToString))
                row = dt2.Rows(0)
                If row(0).ToString = "X" Then
                    dgvcatalogo.Columns.Item(iI).Visible = False
                Else
                    dgvcatalogo.Columns.Item(iI).HeaderText = row(0).ToString
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function OkData() As Boolean

        If cmbestado.SelectedIndex = -1 And cmbcodalmacen.SelectedIndex = -1 Then
            MsgBox("Seleccione el Estado o codigo del Articulo", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If txtartdescripcion.Text = "" Or cmbunidadmedida.SelectedIndex = -1 Or cmbestado.SelectedIndex = -1 Then
            MsgBox("Ingrese Descripcion", MsgBoxStyle.Exclamation)
            txtartdescripcion.Focus()
            Return False
        End If
        If Mid(txtartcodigo.Text, 1, 2) = "02" Or Mid(txtartcodigo.Text, 1, 2) = "03" Or Mid(txtartcodigo.Text, 1, 2) = "01" Then
            If cmbmedida2.SelectedIndex = -1 Or cmbmedida.SelectedIndex = -1 Then
                MsgBox("Ingrese el formato del Articulo")
            End If
        End If
        'If Mid(txtartcodigo.Text, 1, 2) = "01" Or Mid(txtartcodigo.Text, 1, 2) = "02" Then
        If cmbcentrocosto.SelectedIndex = -1 Then
            MsgBox("Seleccione el Centro de Costo", MsgBoxStyle.Exclamation)
            cmbcentrocosto.Focus()
            Return False
        End If

        'If txtnomccu.Text = Nothing Or txtnomccu.Text = "" Then
        '    MsgBox("Ingrese un Codigo de Sunat Valido", MsgBoxStyle.Exclamation)
        '    txtccnu.Focus()
        '    Return False
        'End If
        ''End If

        If txtartcodigo.Text.Substring(0, 2) = "08" Then
            If dtpinicio.Checked = False Then
                If dtp_fectraini.Value.ToString("dd/MM/yyyy") = dtp_fectrafin.Value Then
                    MsgBox("ACtualice Fechas de Trabajo en Curso")
                    Return False
                End If
            End If
        End If

        If dtp_fecBaja.Value.ToString = " " And cmbMotBaja.Text <> "" Then
            MsgBox("Ingresar Fecha de Baja de Activo")
            Return False
        End If

        'If txtartcodigo.Text.Substring(0, 2) = "08" And txtartcodigo.Text.Substring(0, 4) = "0802" Then
        '    For i = 0 To dgvcatalogo.Rows.Count - 1
        '        Dim cod = dgvcatalogo.Rows(i).Cells(0).Value.ToString.Substring(0, 4)
        '        Select Case cod
        '            Case "0064", "0065", "0053", "0054", "0055", "0056", "0057", "0059", "0060", "0062", "0063"
        '                If dgvcatalogo.Rows(i).Cells(1).Value.ToString = "" Then
        '                    MsgBox(dgvcatalogo.Rows(i).Cells(0).Value & " DEBE SER INGRESADO")
        '                    Return False
        '                End If
        '        End Select
        '    Next
        'End If

        ' If txtartcodigo.Text.Substring(0, 2) = "08" And txtartcodigo.Text.Substring(0, 4) <> "0802" Then
        '     For i = 0 To dgvcatalogo.Rows.Count - 1
        '         Dim cod = dgvcatalogo.Rows(i).Cells(0).Value.ToString.Substring(0, 4)
        '         Select Case cod
        '             Case "0065", "0053", "0054", "0055", "0056", "0057", "0059", "0060", "0062", "0063"
        '                 If dgvcatalogo.Rows(i).Cells(1).Value.ToString = "" Then
        '                     MsgBox(dgvcatalogo.Rows(i).Cells(0).Value & " DEBE SER INGRESADO")
        '                     Return False
        '                 End If
        '         End Select
        '     Next
        ' End If

        Return True
    End Function

    Private Sub GetData(ByVal sCode As String)
        Dim dtArticulo As DataTable
        Dim Registro As DataRow
        Dim Registro1 As DataRow
        dtArticulo = ARTICULOBL.SelectRow(gsCode)

        For Each Registro In dtArticulo.Rows
            txtartcodigo.Text = IIf(IsDBNull(Registro("ART_CODIGO")), "", Registro("ART_CODIGO"))
            txtartdescripcion.Text = IIf(IsDBNull(Registro("ART_DESCRI")), "", Registro("ART_DESCRI"))
            txtcodigo.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            cmblinea.SelectedValue = IIf(IsDBNull(Registro("ART_SLINEA")), "", Registro("ART_SLINEA"))
            cmbcentrocosto.SelectedValue = IIf(IsDBNull(Registro("CCOSTO_COD")), "", Registro("CCOSTO_COD"))
            cmbcodalmacen.SelectedValue = IIf(IsDBNull(Registro("ALM_COD")), "", Registro("ALM_COD"))
            Dim ARTICULOBE As New ARTICULOBE
            ARTICULOBE.art_descritemp = IIf(IsDBNull(Registro("ART_DESCRI")), "", Registro("ART_DESCRI"))
            txtcodproc.Text = IIf(IsDBNull(Registro("COD_PROC")), "", Registro("COD_PROC"))
            If (IIf(IsDBNull(Registro("ART_FECINI")), "", Registro("ART_FECINI"))).ToString.Length > 0 Then
                dtpinicio.Checked = True
                dtpinicio.Value = IIf(IsDBNull(Registro("ART_FECINI")), "", Registro("ART_FECINI"))
            End If
            Dim dt As DataTable = ELTBPROCBL.SelectRow(Trim(txtcodproc.Text))
            For Each Registro1 In dt.Rows
                txtdescriproc.Text = IIf(IsDBNull(Registro1("DESCRIPCION")), "", Registro1("DESCRIPCION"))
            Next
            'IIf(IsDBNull(Registro("ALM_COD")), "", Registro("ALM_COD"))
            Select Case Registro("X_KARDEX").ToString
                Case ""
                    cmbkardex.SelectedIndex = 1
                Case "S"
                    cmbkardex.SelectedIndex = 0
                Case "1"
                    cmbkardex.SelectedIndex = 0
            End Select
            Select Case Registro("EST").ToString
                Case ""
                    cmbestado.SelectedIndex = -1
                Case "H"
                    cmbestado.SelectedIndex = 0
                Case "A"
                    cmbestado.SelectedIndex = 1
            End Select
            Select Case Registro("ART_SOLM").ToString
                Case ""
                    cmbsolm.SelectedIndex = -1
                Case "1"
                    cmbsolm.SelectedIndex = 0
                Case "0"
                    cmbsolm.SelectedIndex = 1
            End Select
            Select Case Registro("ART_APROREQ").ToString
                Case ""
                    cmbart_apreq.SelectedIndex = -1
                Case "1"
                    cmbart_apreq.SelectedIndex = 0
                Case "0"
                    cmbart_apreq.SelectedIndex = 1
            End Select
            cmbmedida.SelectedValue = IIf(IsDBNull(Registro("MEDIDA")), "", Registro("MEDIDA"))
            cmbmedida2.SelectedValue = IIf(IsDBNull(Registro("MEDIDA_NUEVO")), "", Registro("MEDIDA_NUEVO"))
            cmbunidadmedida.SelectedValue = IIf(IsDBNull(Registro("UNI_COD")), "", Registro("UNI_COD"))
            cmbcatalogo.SelectedValue = IIf(IsDBNull(Registro("ART_CODCAT")), "", Registro("ART_CODCAT"))
            cmbfamilia1.SelectedValue = IIf(IsDBNull(Registro("FAM1")), "", Registro("FAM1"))
            cmbfamilia2.SelectedValue = IIf(IsDBNull(Registro("FAM2")), "", Registro("FAM2"))
            cmbfamilia3.SelectedValue = IIf(IsDBNull(Registro("FAM3")), "", Registro("FAM3"))
            cmbfamilia4.SelectedValue = IIf(IsDBNull(Registro("FAM4")), "", Registro("FAM4"))
            cmbfamilia5.SelectedValue = IIf(IsDBNull(Registro("FAM5")), "", Registro("FAM5"))
            txtcodfamcontable.Text = IIf(IsDBNull(Registro("FAM_CONT")), "", Registro("FAM_CONT")) 'cmbfamilia1.Text + cmbfamilia2.Text + cmbfamilia3.Text + cmbfamilia4.Text + cmbfamilia5.Text
            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            npdstockminimo.Value = IIf(IsDBNull(Registro("STKMIN")), 0.000, Registro("STKMIN"))
            txtstock.Text = ARTICULOBL.SetStock(txtartcodigo.Text)

            txtccnu.Text = IIf(IsDBNull(Registro("COD_SUNAT")), "", Registro("COD_SUNAT"))
            txtnomccu.Text = ARTICULOBL.SelectNomCCNU(txtccnu.Text)
            '   Mid(file.Name, 12, n)
        Next
    End Sub

    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        Dim i As Integer
        'MsgBox(dgvcatalogo.Rows.Item(0).ToString)
        'Recorre el catalogo para verificar si los datos son obligatorios o no
        If dgvcatalogo.Rows.Count > 0 Then
            dgvcatalogo.CurrentCell = dgvcatalogo.Rows(0).Cells(1)
        End If
        For i = 0 To dgvcatalogo.Rows.Count - 1
            If cmbcatalogo.SelectedIndex <> -1 Then
                If dgvcatalogo.Rows(i).Cells(1).Value Is Nothing And dgvcatalogo.Rows(i).Cells(2).Value.ToString = "1" Then
                    MsgBox("Faltan Datos del catalogo que son obligatorios")
                    Exit Sub
                End If
                Try
                    If dgvcatalogo.Rows(i).Cells(1).Value.ToString = "" And dgvcatalogo.Rows(i).Cells(2).Value.ToString = "1" Then
                        'If dgvcatalogo.Rows(i).Cells(1).Value Is Nothing And dgvcatalogo.Rows(i).Cells(2).Value.ToString = "1" Then
                        MsgBox("Faltan Datos del catalogo que son obligatorios")
                        Exit Sub
                    End If
                Catch ex As Exception

                End Try

            End If
        Next
        Try

            Dim COD As String
            Dim ARTICULOBE As New ARTICULOBE
            If flagAccion = "N" Then
                COD = ARTICULOBL.LastCodigo(gsCode3) + 1
                If COD.ToString.Length < 8 Then
                    Me.txtartcodigo.Text = "0" & COD
                Else
                    Me.txtartcodigo.Text = COD
                End If
            End If
            ARTICULOBE.temp_art = RTrim(txtartcodigo.Text)
            'ARTICULOBE.nom = RTrim(txtartdescripcion.Text)
            ARTICULOBE.art_cod = RTrim(txtartcodigo.Text)
            ARTICULOBE.art_descri = RTrim(txtartdescripcion.Text)
            ARTICULOBE.est = IIf(cmbestado.SelectedIndex = 0, "H", "A")
            ARTICULOBE.art_solm = IIf(cmbsolm.SelectedIndex = 0, "1", "0")
            ARTICULOBE.art_slinea = RTrim(cmblinea.SelectedValue.ToString)
            ARTICULOBE.ccosto_cod = RTrim(cmbcentrocosto.SelectedValue.ToString)
            ARTICULOBE.alm_cod = RTrim(cmbcodalmacen.SelectedValue.ToString)
            ARTICULOBE.x_kardex = IIf(cmbkardex.SelectedIndex = 0, "1", "")
            ARTICULOBE.cod = RTrim(txtcodigo.Text)
            ARTICULOBE.nom = RTrim(txtnom.Text)
            ARTICULOBE.cod_proc = RTrim(txtcodproc.Text)
            ARTICULOBE.fecini = dtpinicio.Value
            ARTICULOBE.codsunat = RTrim(txtccnu.Text)
            'If cmbmedida.SelectedIndex <> -1 Then

            'End If
            If Mid(txtartcodigo.Text, 1, 4) = "0201" And cmbmedida2.SelectedValue = -1 Then
                ARTICULOBE.medida_nuevo = "0"
                ARTICULOBE.medida = "0"
            Else
                If cmbmedida2.SelectedIndex <> -1 Then
                    ARTICULOBE.medida_nuevo = RTrim(cmbmedida2.SelectedValue.ToString)
                    ARTICULOBE.medida = ARTICULOBL.getListcmb15(RTrim(cmbmedida2.SelectedValue.ToString))
                End If
            End If

            If Mid(txtartcodigo.Text, 1, 2) = "08" And dtpinicio.Checked = True Then
                ARTICULOBE.fecini = dtpinicio.Value
            End If

            ARTICULOBE.ubi_artcod = gsCodAlm
            If cmbart_apreq.SelectedIndex = 0 Then
                ARTICULOBE.art_aproreq = "1"
            ElseIf cmbart_apreq.SelectedIndex = 1 Then
                ARTICULOBE.art_aproreq = "0"
            Else
                ARTICULOBE.art_aproreq = ""
            End If
            ARTICULOBE.uni_cod = RTrim(cmbunidadmedida.SelectedValue.ToString)
            If (cmbcatalogo.SelectedValue <> Nothing) Then
                ARTICULOBE.art_codcat = RTrim(cmbcatalogo.SelectedValue.ToString)
            End If

            If (cmbfamilia1.SelectedValue <> Nothing) Then
                ARTICULOBE.fam1 = RTrim(cmbfamilia1.SelectedValue.ToString)
            End If
            If (cmbfamilia2.SelectedValue <> Nothing) Then
                ARTICULOBE.fam2 = RTrim(cmbfamilia2.SelectedValue.ToString)
            End If
            If (cmbfamilia3.SelectedValue <> Nothing) Then
                ARTICULOBE.fam3 = RTrim(cmbfamilia3.SelectedValue.ToString)
            End If
            If (cmbfamilia4.SelectedValue <> Nothing) Then
                ARTICULOBE.fam4 = RTrim(cmbfamilia4.SelectedValue.ToString)
            End If
            If (cmbfamilia5.SelectedValue <> Nothing) Then
                ARTICULOBE.fam5 = RTrim(cmbfamilia5.SelectedValue.ToString)
            End If
            ARTICULOBE.stkmin = npdstockminimo.Value
            Dim ELTBESPEBE As New ELTBESPEBE
            Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
            Dim ELMVLOGSBE As New ELMVLOGSBE
            ELMVLOGSBE.log_codusu = gsCodUsr

            If dtpinicio.Checked = False Then
                ARTICULOBE.est_trabajo = 1
                ARTICULOBE.fec_initra = dtp_fectraini.Value.ToString("dd/MM/yyyy")
                ARTICULOBE.fec_fintra = dtp_fectrafin.Value.ToString("dd/MM/yyyy")
            Else
                ARTICULOBE.est_trabajo = 0
            End If

            If cmbMotBaja.Text <> "" Then
                ARTICULOBE.est_baja = 1
                ARTICULOBE.mot_baja = cmbMotBaja.Text
                ARTICULOBE.fec_baja = dtp_fecBaja.Value.ToString("dd/MM/yyyy")
                ARTICULOBE.est = "A"

            Else
                ARTICULOBE.est_baja = 0
                ARTICULOBE.mot_baja = ""
                ARTICULOBE.fec_baja = ""
            End If

            DET_DOCUMENTOBE.ALM_COD = gsCodAlm
            dgvcatalogo.Refresh()
            dgvcomponente.Refresh()

            'dgvcatalogo
            gsError2 = ELTBESPEBL.SaveRow(ELTBESPEBE, flagAccion, dgvcatalogo, txtartcodigo.Text, cmbcatalogo.SelectedValue)

            Dim ELTBCOMPBE As New ELTBCOMPBE
            gsError3 = ELTBCOMPBL.SaveRow(ELTBCOMPBE, "NS", dgvcomponente, txtartcodigo.Text)

            gsError = ARTICULOBL.SaveRow(ARTICULOBE, flagAccion, ELMVLOGSBE)
            If gsError = "OK" And gsError2 = "OK" And gsError3 = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                If contador = "0" And (gsUser = "JPINTADO" Or gsUser = "RVASQUEZ") Then
                    If MessageBox.Show("¿Desea enviar el correo?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If
                    lstValor.Items.Clear()
                    If cmbcatalogo.SelectedIndex = -1 Then
                        MsgBox("No se ah seleccionado ningún catalogo")
                        Exit Sub
                    End If
                    For i = 0 To dgvcatalogo.Rows.Count - 1
                        If cmbcatalogo.SelectedIndex <> -1 Then
                            If dgvcatalogo.Rows(i).Cells(1).Value Is Nothing And dgvcatalogo.Rows(i).Cells(2).Value.ToString = "1" Then
                                MsgBox("Faltan Datos del catalogo que son obligatorios")
                                Exit Sub
                            End If
                            If dgvcatalogo.Rows(i).Cells(1).Value.ToString = "" And dgvcatalogo.Rows(i).Cells(2).Value.ToString = "1" Then
                                MsgBox("Faltan Datos del catalogo que son obligatorios")
                                Exit Sub
                            End If
                        End If
                    Next
                    gcodcor = "0001"
                    ELTBGRUPCORVALBL.SelectRow("0001", lstValor)
                    enviarCorreo()
                End If
                If flagAccion = "N" Then
                    lstValor.Items.Clear()
                    gcodcor = "0004"
                    ELTBGRUPCORVALBL.SelectRow("0004", lstValor)
                    enviarCorreo1()
                End If

                Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub txtccnu_TextChanged(sender As Object, e As EventArgs) Handles txtccnu.TextChanged
        If bPrimero Then
            Exit Sub
        End If
        If txtccnu.TextLength > 7 Then
            Try
                txtnomccu.Text = ARTICULOBL.SelectNomCCNU(txtccnu.Text)
            Catch
                txtnomccu.Text = Nothing
            End Try
        Else
            txtnomccu.Text = Nothing
        End If
    End Sub
    Private Sub DeleteData()

        If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        flagAccion = "E"
        Dim ARTICULOBE As New ARTICULOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ARTICULOBE.art_cod = Trim(txtcodigo.Text)

        'Dim dTable As New DataTable
        gsError = ARTICULOBL.SaveRow(ARTICULOBE, flagAccion, ELMVLOGSBE)

        If gsError = "OK" Then
            MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
            enviarCorreo()
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub FormMntArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bPrimero = True
        gsError = ""
        gpCaption = "Articulo"
        Me.Text = gpCaption
        cmbtipocomp.SelectedIndex = 0
        txtcodigo.Enabled = False
        cmbart_apreq.SelectedIndex = 0
        'Cargar los combos
        Dim dt As DataTable = ARTICULOBL.SelectDescripcion2(gsCode3)
        GetCmb("lin_codigo", "lin_descri", dt, cmblinea)
        dt = ARTICULOBL.SelectUndMed()
        GetCmb("cod", "nom", dt, cmbunidadmedida)
        dt = ARTICULOBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbcentrocosto)
        dt = ARTICULOBL.SelectFamilia1
        GetCmb("cod", "nom", dt, cmbfamilia1)
        dt = ARTICULOBL.SelectFamilia2
        GetCmb("cod", "nom", dt, cmbfamilia2)
        dt = ARTICULOBL.SelectFamilia3
        GetCmb("cod", "nom", dt, cmbfamilia3)
        dt = ARTICULOBL.SelectFamilia4
        GetCmb("cod", "nom", dt, cmbfamilia4)
        dt = ARTICULOBL.SelectFamilia5
        GetCmb("cod", "nom", dt, cmbfamilia5)
        dt = ARTICULOBL.getListcmb11
        GetCmb("cod", "nom", dt, cmbcodalmacen)
        dt = ARTICULOBL.getListcmb10
        GetCmb("cat_codigo", "cat_descri", dt, cmbcatalogo)
        dt = ARTICULOBL.getListcmb12
        GetCmb("cod", "nom", dt, cmbmedida)
        dt = ARTICULOBL.getListcmb14
        GetCmb("cod", "nom", dt, cmbmedida2)
        'Definir las columnas del catalogo
        Dim dtcombo As New DataGridViewComboBoxColumn 'prueba
        dgvcatalogo.Columns.Add("CAR_DESCRI", "CAR_DESCRI")
        dgvcatalogo.Columns(0).ReadOnly = True
        'DataGridViewComboBoxCell dgvcatalogo = dgvcatalogo.Rows(x).Cells(2) as DataGridViewComboBoxCell
        dgvcatalogo.Columns.Add("ESP_DATO", "ESP_DATO")
        dgvcatalogo.Columns.Add("CAR_OBLIG", "CAR_OBLIG")
        dgvcatalogo.Columns.Add("VALOR", "VALOR")


        'Definir las columnas de componentes
        Dim dgvColumnCheck As DataGridViewCheckBoxColumn
        Dim dgvColumnText As DataGridViewTextBoxColumn
        'dgvcomponente.Columns.Add("TIPO", "TIPO")
        'dgvcomponente.Columns.Add("CODIGO", "CODIGO")
        'dgvcomponente.Columns.Add("CANTIDAD", "CANTIDAD")
        'dgvcomponente.Columns.Add("ESTADO", "EST.FACTOR")
        Dim HeaderText(3) As String
        HeaderText(0) = "TIPO"
        HeaderText(1) = "CODIGO"
        HeaderText(2) = "CANTIDAD"
        HeaderText(3) = "EST.FAC"
        For i As Integer = 0 To 3
            If i = 3 Then
                dgvColumnCheck = New DataGridViewCheckBoxColumn()
                dgvColumnCheck.Name = HeaderText(i)
                dgvColumnCheck.HeaderText = HeaderText(i)
                'Aca se agrega la columna tipo CheckBox
                dgvcomponente.Columns.Add(dgvColumnCheck)
            Else
                dgvColumnText = New DataGridViewTextBoxColumn
                dgvColumnText.Name = HeaderText(i)
                dgvColumnText.HeaderText = HeaderText(i)
                'Aca se van agregando las columnas tipo Text 
                'a la coleccion Column del control DataGridView 
                dgvcomponente.Columns.Add(dgvColumnText)
            End If
        Next


        'dgvcomponente.Columns("ESTADO").Visible = False
        dt = ARTICULOBL.SelectDescripcion
        GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)

        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                cmbart_apreq.SelectedIndex = 0
                txtcod_raiz.Enabled = False
                txtnomraiz.Enabled = False
                If Mid(txtartcodigo.Text, 1, 2) = "01" Or Mid(txtartcodigo.Text, 1, 2) = "02" Or
                    Mid(txtartcodigo.Text, 1, 2) = "03" Or Mid(txtartcodigo.Text, 1, 2) = "07" Then
                    cmbsolm.SelectedIndex = 0
                ElseIf Mid(txtartcodigo.Text, 1, 2) = "04" Or Mid(txtartcodigo.Text, 1, 2) = "05" Or
                    Mid(txtartcodigo.Text, 1, 2) = "06" Or Mid(txtartcodigo.Text, 1, 2) = "08" Or
                    Mid(txtartcodigo.Text, 1, 2) = "09" Then
                    cmbsolm.SelectedIndex = 1
                End If
                CleanVar()
                Dim cod As Integer
                'cmblinea.Enabled = True
                cod = ARTICULOBL.LastCodigo(gsCode3) + 1
                If cod.ToString.Length < 8 Then
                    Me.txtartcodigo.Text = "0" & cod
                Else
                    Me.txtartcodigo.Text = cod
                End If
                cmblinea.SelectedIndex = 0
                'txtcodigo.Text = ARTICULOBL.LastCodAntiguo
                txtcodigo.Text = Me.txtartcodigo.Text
                'busqueda de codigos antiguos
                btnSearch.Visible = True
                cmbkardex.SelectedIndex = 0
                If Mid(txtartcodigo.Text, 1, 2) = "08" Then
                    Label31.Visible = True
                    dtpinicio.Visible = True
                Else
                    Label31.Visible = False
                    dtpinicio.Visible = False
                End If
                If txtartcodigo.Text.Substring(0, 2) = "08" And txtartcodigo.Text.Substring(0, 4) <> "0802" Then
                    cmbcatalogo.SelectedIndex = 7
                ElseIf txtartcodigo.Text.Substring(0, 2) = "08" And txtartcodigo.Text.Substring(0, 4) = "0802" Then
                    cmbcatalogo.SelectedIndex = 12
                End If
                dtp_fecBaja.CustomFormat = " "
                dtp_fecBaja.Format = DateTimePickerFormat.Custom
            Case 1
                flagAccion = "M"
                GetData(gsCode)
                If Mid(txtartcodigo.Text, 1, 2) = "08" Then
                    Label31.Visible = True
                    dtpinicio.Visible = True
                Else
                    Label31.Visible = False
                    dtpinicio.Visible = False
                End If
                btnimprimir.Enabled = True
        End Select
        Dim dtArticulo As DataTable
        If txtartcodigo.Text.Substring(0, 2) = "08" And txtartcodigo.Text.Substring(0, 4) <> "0802" Then
            dtArticulo = ARTICULOBL.getListdgvAct(cmbcatalogo.SelectedValue, txtartcodigo.Text)
        ElseIf txtartcodigo.Text.Substring(0, 4) = "0802" Then
            dtArticulo = ARTICULOBL.getListdgvVehi(cmbcatalogo.SelectedValue, txtartcodigo.Text)
        Else
            dtArticulo = ARTICULOBL.getListdgv(cmbcatalogo.SelectedValue, txtartcodigo.Text)
        End If
        For Each row As DataRow In dtArticulo.Rows
            dgvcatalogo.Rows.Add(IIf(IsDBNull(row("Codigo")), "", row("Codigo")) & " - " & IIf(IsDBNull(row("Caracteristicas")), "", row("Caracteristicas")), IIf(IsDBNull(row("ESP_DATO")), "", row("ESP_DATO")), IIf(IsDBNull(row("CAR_OBLIG")), "", row("CAR_OBLIG")), IIf(IsDBNull(row("VALOR")), "", row("VALOR")))
        Next
        'dgvcatalogo.Sort(dgvcatalogo.Columns(0), ListSortDirection.Ascending)
        'dgvcatalogo.columnt
        'pbxArticulo.Image.Size(20) 

        On Error Resume Next
        Dim sPath As String = gsIpserver & "sistema\E.ELUX\IMAGENES\"
        'Dim sPath As String = Application.StartupPath & "\IMAGENES\"
        pbxArticulo.Image = Image.FromFile(sPath & txtartcodigo.Text & ".jpg")

        'pbxArticulo.Image.SaveAdd()
        dtArticulo = ARTICULOBL.getListdgv2(txtartcodigo.Text)
        cargarComponentesDet(dtArticulo)

        '        For Each row As DataRow In dtArticulo.Rows
        '            dgvcomponente.Rows.Add(IIf(IsDBNull(row("TIPO")), "", row("TIPO")), IIf(IsDBNull(row("CODIGO")), "", row("CODIGO")), IIf(IsDBNull(row("CANTIDAD")), 0, row("CANTIDAD")), IIf(IsDBNull(row("ESTADO")), 0, row("ESTADO")))
        '        Next
        '   '    For i = 0 To dtArticulo.Columns.Count - 1
        '   '        dgvcomponente.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        '   '    Next

        gHeader(dgvcatalogo)
        If dgvcomponente.Rows.Count > 0 Then
            For i = 0 To dgvcatalogo.Rows.Count - 1
                dgvcomponente.Rows(i).Cells("TIPO").ReadOnly = True
                dgvcomponente.Rows(i).Cells("CODIGO").ReadOnly = True
                dgvcomponente.Rows(i).Cells("CANTIDAD").ReadOnly = True
                dgvcomponente.Rows(i).Cells("EST.FAC").ReadOnly = True
            Next

        End If
        'width column
        Dim column As DataGridViewColumn = dgvcatalogo.Columns(2)
        column.Width = 500

        'combo cell
        comboCellCatalogo()
        If dtpinicio.Checked = False Then
            grbTrabajo.Enabled = True
        Else
            grbTrabajo.Enabled = False
        End If
        bPrimero = False

        cmbMotBaja.SelectedIndex = 0
    End Sub
    Sub cargarComponentesDet(ByVal dtDetalleComponentes As DataTable)
        dgvcomponente.Rows.Clear()
        If dtDetalleComponentes.Rows.Count > 0 Then
            For i = 0 To dtDetalleComponentes.Rows.Count - 1
                dgvcomponente.Rows.Add()
                dgvcomponente.Rows(i).Cells.Item(0).Value = dtDetalleComponentes.Rows(i).Item(0)
            Next
        End If
        If dtDetalleComponentes.Rows.Count > 0 Then
            For i = 0 To dtDetalleComponentes.Rows.Count - 1
                dgvcomponente.Rows(i).Cells.Item(1).Value = dtDetalleComponentes.Rows(i).Item(1)
            Next
        End If
        If dtDetalleComponentes.Rows.Count > 0 Then
            For i = 0 To dtDetalleComponentes.Rows.Count - 1
                dgvcomponente.Rows(i).Cells.Item(2).Value = dtDetalleComponentes.Rows(i).Item(2)
            Next
        End If
        If dtDetalleComponentes.Rows.Count > 0 Then
            For i = 0 To dtDetalleComponentes.Rows.Count - 1
                If dtDetalleComponentes.Rows(i).Item(3) = Nothing Or dtDetalleComponentes.Rows(i).Item(3) = 0 Then
                    dgvcomponente.Rows(i).Cells(3).Value = False
                Else
                    dgvcomponente.Rows(i).Cells(3).Value = True
                End If
            Next
        End If

    End Sub

    Private Sub comboCellCatalogo()
        Dim n As String
        Dim dtCata As New DataTable
        Dim comboCell As DataGridViewComboBoxCell
        On Error Resume Next
        '   Try
        For i = 0 To dgvcatalogo.Rows.Count - 1
            If dgvcatalogo.Rows(i).Cells("VALOR").Value <> 0 Then
                'obtiene valores de la caracteristica
                Dim sDato As String = dgvcatalogo.Rows(i).Cells("ESP_DATO").Value
                Dim sCar As String = Mid(dgvcatalogo.Rows(i).Cells("CAR_DESCRI").Value, 1, 4)
                dtCata = ARTICULOBL.getOpciones(sCar)
                comboCell = New DataGridViewComboBoxCell
                For d = 0 To dtCata.Rows.Count - 1
                    comboCell.Items.Add(dtCata.Rows(d).Item("VAL_CODVAL"))
                Next
                dgvcatalogo.Rows(i).Cells(2).Dispose()
                dgvcatalogo.Rows(i).Cells(1) = comboCell
                'buscar el dato en el combocell
                'para evitar el error
                For x = 0 To comboCell.Items.Count - 1
                    If comboCell.Items(x) = sDato Then
                        dgvcatalogo.Rows(i).Cells(1).Value = sDato
                        If sCar = "0043" And txtccnu.Text = Nothing Then
                            n = Len(sDato) - 11
                            txtccnu.Text = vb.Left(sDato, 8)
                            txtnomccu.Text = Mid(sDato, 12, n)
                        End If
                    End If
                Next
            End If
        Next
        dgvcatalogo.Columns(0).Width = 180
        dgvcatalogo.Columns(1).Width = 350
    End Sub


    Private Sub cmblinecomp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblinecomp.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        'bSegundo = True
        If cmbLineas.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.SelectDescripcion1(cmbLineas.SelectedValue)
            GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas)
        End If
        bSegundo = False
    End Sub

    Private Sub cmbsublinecomp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsublinecomp.SelectedIndexChanged
        If bSegundo Then
            Exit Sub
        End If
        If cmbsublinecomp.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.SelectArt1(cmbsublinecomp.SelectedValue)
            If dt.Rows.Count > 0 Then
                GetCmb("ART_COD", "ART_COD", dt, cmbartcomp)
            Else
                MsgBox("La Sublinea no tiene articulos")
                'For i = 0 To cmbart.Items.Count - 1
                cmbartcomp.DataSource = Nothing
                'Next
                'cmbart.Refresh()
            End If
        End If
        bSegundo = False
    End Sub

    Private Sub btnagregarcomp_Click(sender As Object, e As EventArgs) Handles btnagregarcomp.Click
        Dim Dato As String = ""

        If cmbtipocomp.SelectedItem = "01 Componente" Then
            Dato = "01"
        ElseIf cmbtipocomp.SelectedItem = "02 Insumo" Then
            Dato = "02"
        End If
        dgvcomponente.Rows.Add(Dato, cmbArticulo.SelectedValue, nudcantcomp.Value)
    End Sub

    Private Sub cmbcatalogo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcatalogo.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If

        If MessageBox.Show("Esta seguro de Cambiar de Catalogo", gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        dgvcatalogo.Rows.Clear()
        Dim dtArticulo As DataTable

        If txtartcodigo.Text.Substring(0, 2) = "08" And txtartcodigo.Text.Substring(0, 4) <> "0802" Then
            dtArticulo = ARTICULOBL.getListdgvAct(cmbcatalogo.SelectedValue, txtartcodigo.Text)
        ElseIf txtartcodigo.Text.Substring(0, 4) = "0802" Then
            dtArticulo = ARTICULOBL.getListdgvVehi(cmbcatalogo.SelectedValue, txtartcodigo.Text)
        Else
            dtArticulo = ARTICULOBL.getListdgv(cmbcatalogo.SelectedValue, txtartcodigo.Text)
        End If

        For Each row As DataRow In dtArticulo.Rows
            dgvcatalogo.Rows.Add(IIf(IsDBNull(row("Codigo")), "", row("Codigo")) & " - " & IIf(IsDBNull(row("Caracteristicas")), "", row("Caracteristicas")), IIf(IsDBNull(row("ESP_DATO")), "", row("ESP_DATO")), IIf(IsDBNull(row("CAR_OBLIG")), "", row("CAR_OBLIG")), IIf(IsDBNull(row("VALOR")), "", row("VALOR")))
        Next
        dgvcatalogo.Refresh()
        gHeader(dgvcatalogo)
        comboCellCatalogo()
    End Sub

    Private Sub FormMantArticulo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnborrarcomp_Click(sender As Object, e As EventArgs) Handles btnborrarcomp.Click
        dgvcomponente.Rows.Remove(dgvcomponente.CurrentRow)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FormBusquedaAnterior.ShowDialog()
    End Sub

    Private Sub dgvcatalogo_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvcatalogo.CellPainting
        If e.RowIndex = -1 Then Exit Sub
        'Color a las columnas de acuerdo al valor
        Dim dgvTemp As DataGridView = sender
        Dim sCellOblig As DataGridViewCell = dgvcatalogo.Rows(e.RowIndex).Cells(2)
        Dim sCellCar_Descri As DataGridViewCell = dgvcatalogo.Rows(e.RowIndex).Cells(0)
        Dim sValor As DataGridViewCell = dgvcatalogo.Rows(e.RowIndex).Cells("VALOR")

        'Obligatorio IIf(IsDBNull(RTrim(row.Cells("T_DOC_REF").Value)), "", RTrim(row.Cells("T_DOC_REF").Value))
        'If sCellOblig.Value = "" Or sCellOblig.Value = Nothing Then
        'Else
        If (IIf(IsDBNull(sCellOblig.Value), 0, sCellOblig.Value) = 1) Then
                sCellCar_Descri.Style.BackColor = Color.Orange
            End If
        'End If

    End Sub


    Private Sub btnExplosion_Click_1(sender As Object, e As EventArgs) Handles btnExplosion.Click
        'Muestra la explosion
        FormExplosion.ShowDialog()
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        'Mostrar Reporte y mandar parametros
        Dim ARTICULOBE As New ARTICULOBE
        ReDim gsRptArgs(1)
        gsRptArgs(0) = cmbcatalogo.SelectedValue
        gsRptArgs(1) = txtartcodigo.Text
        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ART_CAR_DATO.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "8"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            cmbLineas.SelectedValue = gLinea
            cmbSublineas.SelectedValue = gSubLinea
            cmbArticulo.SelectedValue = gArt
            txtcodart.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub cmbLineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLineas.SelectedIndexChanged
        'If bPrimero Then
        '    Exit Sub
        'End If
        ''bSegundo = True
        'If cmbLineas.SelectedIndex <> -1 Then
        '    Dim dt As DataTable = ARTICULOBL.SelectDescripcion1(cmbLineas.SelectedValue)
        '    GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas)
        'End If
        'bSegundo = False
        If bPrimero Then
            Exit Sub
        End If
        'bSegundo = True
        If cmbLineas.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.SelectDescripcion1(cmbLineas.SelectedValue)
            GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas)
        End If
        bSegundo = False
    End Sub

    Private Sub cmbSublineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSublineas.SelectedIndexChanged
        'If bSegundo Then
        '    Exit Sub
        'End If

        'If cmbSublineas.SelectedIndex <> -1 Then
        '    Dim dt As DataTable = ARTICULOBL.SelectArt(cmbSublineas.SelectedValue)
        '    If dt.Rows.Count > 0 Then
        '        GetCmb("ART_COD", "ART_DESCRI", dt, cmbArticulo)
        '        bTercero = False
        '        'If sBusAlm = "2" Then
        '        '    cmbart.SelectedValue = gArt
        '        '    gArt = Nothing
        '        'End If

        '    Else
        '        MsgBox("La Sublinea no tiene articulos")
        '        'For i = 0 To cmbart.Items.Count - 1
        '        cmbArticulo.DataSource = Nothing
        '        'Next
        '        'cmbart.Refresh()
        '    End If

        'End If
        If bSegundo Then
            Exit Sub
        End If

        If cmbSublineas.SelectedIndex <> -1 Then
            Dim dt As DataTable = ARTICULOBL.SelectArt(cmbSublineas.SelectedValue)
            If dt.Rows.Count > 0 Then
                GetCmb("ART_COD", "ART_DESCRI", dt, cmbArticulo)
                bTercero = False
                'If sBusAlm = "2" Then
                '    cmbart.SelectedValue = gArt
                '    gArt = Nothing
                'End If

            Else
                MsgBox("La Sublinea no tiene articulos")
                'For i = 0 To cmbart.Items.Count - 1
                cmbArticulo.DataSource = Nothing
                'Next
                'cmbart.Refresh()
            End If

        End If
    End Sub

    Private Sub cmbArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArticulo.SelectedIndexChanged
        If bTercero Then
            Exit Sub
        End If
        If valor = False Then
            If code = "" Then
                txtcodart.Text = cmbArticulo.SelectedValue
            End If
            valor = True
        End If

        'txtcodart.Text = Mid(cmbArticulo.Text, 1, 8)
        'If txtcodart.TextLength > 0 Then
        'txtcodart.Text = cmbArticulo.SelectedValue
        'End If
        bTercero = False
    End Sub

    'Private Sub txtcodart_Validated(sender As Object, e As EventArgs) Handles txtcodart.Validated
    '    'If bPrimero Then Exit Sub
    '    ''buscar articulo

    '    'cmbLineas.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

    '    'If cmbLineas.SelectedValue = "" Then
    '    '    Exit Sub
    '    'End If

    '    'cmbSublineas.SelectedValue = Mid(txtcodart.Text, 1, 4)

    '    'If cmbSublineas.SelectedValue = "" Then
    '    '    Exit Sub
    '    'End If

    '    'cmbArticulo.SelectedValue = txtcodart.Text
    '    'gsCode = gsCode


    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "31"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcodproc.Text = gLinea
            txtdescriproc.Text = gSubLinea
            'txtcodart.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            'gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtcodproc_LostFocus(sender As Object, e As EventArgs) Handles txtcodproc.LostFocus
        Dim ELTBPROCBE As New ELTBPROCBE
        Dim dt As DataTable = ELTBPROCBL.SelectRow(txtcodproc.Text)
        For Each Registro In dt.Rows
            txtdescriproc.Text = IIf(IsDBNull(Registro("DESCRIPCION")), "", Registro("DESCRIPCION"))
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lstValor.Items.Clear()

        If cmbcatalogo.SelectedIndex = -1 Then
            MsgBox("No se ah seleccionado ningún catalogo")
            Exit Sub
        End If
        For i = 0 To dgvcatalogo.Rows.Count - 1
            If cmbcatalogo.SelectedIndex <> -1 Then
                If dgvcatalogo.Rows(i).Cells(1).Value Is Nothing And dgvcatalogo.Rows(i).Cells(2).Value.ToString = "1" Then
                    MsgBox("Faltan Datos del catalogo que son obligatorios")
                    Exit Sub
                End If
                If dgvcatalogo.Rows(i).Cells(1).Value.ToString = "" And dgvcatalogo.Rows(i).Cells(2).Value.ToString = "1" Then
                    MsgBox("Faltan Datos del catalogo que son obligatorios")
                    Exit Sub
                End If
            End If
        Next
        If MessageBox.Show("¿Esta seguro que desea enviar un Correo?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        gcodcor = "0001"
        ELTBGRUPCORVALBL.SelectRow("0001", lstValor)
        enviarCorreo()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Mid(txtdescriproc.Text, 1, 3) = "ENS" Then
            'If Trim(txtcodproc.Text) = "0001" Then
            Cursor.Current = Cursors.WaitCursor
            ReDim gsRptArgs(2)
            gsRptArgs(0) = Trim(txtcodproc.Text)
            gsRptArgs(1) = txtartcodigo.Text
            gsRptArgs(2) = cmbcentrocosto.Text
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CONTROL_TIEMPO_ENS.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
            'End If
        ElseIf Mid(txtdescriproc.Text, 1, 3) = "LIT" Then
            'If Trim(txtcodproc.Text) = "0025" Then
            Cursor.Current = Cursors.WaitCursor
            ReDim gsRptArgs(2)
            gsRptArgs(0) = Trim(txtcodproc.Text)
            gsRptArgs(1) = txtartcodigo.Text
            gsRptArgs(2) = cmbcentrocosto.SelectedValue
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CONTROL_TIEMPO_LIT.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
            'End If
        ElseIf Mid(txtdescriproc.Text, 1, 3) = "PRE" Then
            'If Trim(txtcodproc.Text) = "0026" Then
            Cursor.Current = Cursors.WaitCursor
            ReDim gsRptArgs(2)
            gsRptArgs(0) = Trim(txtcodproc.Text)
            gsRptArgs(1) = txtartcodigo.Text
            gsRptArgs(2) = cmbcentrocosto.SelectedValue
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CONTROL_TIEMPO_TMPPRE.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
            'End If
        ElseIf Mid(txtdescriproc.Text, 1, 3) = "COR" Then
            'If Trim(txtcodproc.Text) = "0027" Then
            Cursor.Current = Cursors.WaitCursor
            ReDim gsRptArgs(2)
            gsRptArgs(0) = Trim(txtcodproc.Text)
            gsRptArgs(1) = txtartcodigo.Text
            gsRptArgs(2) = cmbcentrocosto.SelectedValue
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CONTROL_TIEMPO_TMPCOR.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
            'End If
        End If
    End Sub

    Private Sub cmbestado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbestado.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbestado.SelectedIndex = 1 Then
            If flagAccion = "M" Then
                Dim stk As Double = ARTICULOBL.SetStock(txtartcodigo.Text)
                If stk <> 0 Then
                    MsgBox("Se debe dejar en 0 el Movimiento del articulo para anularlo")
                    cmbestado.SelectedIndex = 0
                End If
            Else
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sBusAlm = "8"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtcod_raiz.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    'Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
    '    If e.KeyValue = Keys.F9 Then
    '        sBusAlm = "37"
    '        Dim frm As New FormBUSQUEDA
    '        frm.ShowDialog()
    '        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
    '            cmbLineas.SelectedValue = gLinea
    '            cmbSublineas.SelectedValue = gSubLinea
    '            cmbArticulo.SelectedValue = gArt
    '            txtcodart.Text = gArt
    '            gLinea = Nothing
    '            gSubLinea = Nothing
    '            gArt = Nothing
    '        Else
    '            gLinea = Nothing
    '            gSubLinea = Nothing
    '            gArt = Nothing
    '        End If
    '        e.Handled = True
    '    End If

    '    If e.KeyValue = Keys.F10 Then
    '        sBusAlm = "5"
    '        Dim frm As New FormBUSQUEDA
    '        frm.ShowDialog()
    '        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
    '            cmbLineas.SelectedValue = gLinea
    '            cmbSublineas.SelectedValue = gSubLinea
    '            cmbArticulo.SelectedValue = gArt
    '            txtcodart.Text = gArt
    '            gLinea = Nothing
    '            gSubLinea = Nothing
    '            gArt = Nothing
    '        Else
    '            gLinea = Nothing
    '            gSubLinea = Nothing
    '            gArt = Nothing
    '        End If
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        If bPrimero Then Exit Sub
        'buscar articulo

        code = txtcodart.Text
        cmbLineas.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

        If cmbLineas.SelectedValue = "" Then
            Exit Sub
        End If

        cmbSublineas.SelectedValue = Mid(txtcodart.Text, 1, 4)

        If cmbSublineas.SelectedValue = "" Then
            Exit Sub
        End If

        Dim dt As DataTable = ARTICULOBL.SelectArt(cmbSublineas.SelectedValue)
        GetCmb("ART_COD", "ART_DESCRI", dt, cmbArticulo)
        cmbArticulo.SelectedValue = code
        valor = False
        code = ""
        'gsCode = gsCode
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If vb.Left(cmblinea.Text, 2) = "01" Or vb.Left(cmblinea.Text, 2) = "02" Or vb.Left(cmblinea.Text, 2) = "03" Then
            sBusAlm = "259"
        Else
            sBusAlm = "256"
        End If
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtccnu.Text = gLinea
            txtnomccu.Text = gSubLinea
            'txtcodart.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            'gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Marcar_Click(sender As Object, e As EventArgs) Handles btnMarcar.Click
        If dgvcomponente.Rows(dgvcomponente.CurrentRow.Index).Cells("EST.FAC").Value = True Then
            dgvcomponente.Rows(dgvcomponente.CurrentRow.Index).Cells("EST.FAC").Value = False
            btnMarcar.Text = "Marcar"
        Else
            dgvcomponente.Rows(dgvcomponente.CurrentRow.Index).Cells("EST.FAC").Value = True
            btnMarcar.Text = "Desmarcar"
        End If
    End Sub

    Private Sub dgvcomponente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcomponente.CellClick
        If dgvcomponente.Rows(dgvcomponente.CurrentRow.Index).Cells("EST.FAC").Value = True Then
            btnMarcar.Text = "Desmarcar"
        Else
            btnMarcar.Text = "Marcar"
        End If
    End Sub

    Private Sub dtpinicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpinicio.ValueChanged
        If dtpinicio.Checked = False Then
            grbTrabajo.Enabled = True
        Else
            grbTrabajo.Enabled = False
        End If
    End Sub

    Private Sub cmbMotBaja_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMotBaja.SelectedIndexChanged
        If cmbMotBaja.SelectedIndex <> 0 Then
            dtp_fecBaja.CustomFormat = "dd/MM/yyyy"
            dtp_fecBaja.Format = DateTimePickerFormat.Custom
            dtp_fecBaja.Value = Today
        Else
            dtp_fecBaja.CustomFormat = " "
            dtp_fecBaja.Format = DateTimePickerFormat.Custom
        End If


    End Sub


    'Private Sub dgvcatalogo_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcatalogo.CellEnter

    '    Dim comboCell As DataGridViewComboBoxCell

    '    If dgvcatalogo.CurrentCell.ColumnIndex <> 1 Then Exit Sub

    '    If dgvcatalogo.Rows(dgvcatalogo.CurrentRow.Index).Cells("VALOR").Value <> 0 Then
    '        comboCell = New DataGridViewComboBoxCell
    '        comboCell.Items.Add("One")
    '        comboCell.Items.Add("Two")
    '        comboCell.Items.Add("Three")
    '        comboCell.Items.Add("Four")

    '        dgvcatalogo.Rows(dgvcatalogo.CurrentRow.Index).Cells(2).Dispose()
    '        dgvcatalogo.Rows(dgvcatalogo.CurrentRow.Index).Cells(1) = comboCell
    '    End If

    'End Sub
End Class