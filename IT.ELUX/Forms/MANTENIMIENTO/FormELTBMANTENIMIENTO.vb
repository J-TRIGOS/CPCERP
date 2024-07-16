Imports System.ComponentModel
Imports System.IO
Imports vb = Microsoft.VisualBasic
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormELTBMANTENIMIENTO
    Dim Tpo As String
    Dim guardar As String = Nothing
    Dim verimg As String = Nothing
    Private ELTBMANTENIMIENTOBL As New ELTBMANTENIMIENTOBL
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private bprimero As Boolean
    Private gpCaption As String

    Private Function OkData() As Boolean
        If cmbccodori.SelectedIndex < 0 Then
            cmbccodori.Focus()
            Return False
        End If
        If cmbareaori.SelectedIndex < 0 Then
            cmbareaori.Focus()
            Return False
        End If
        If cmbccoddes.SelectedIndex < 0 Then
            cmbccoddes.Focus()
            Return False
        End If
        If cmbareades.SelectedIndex < 0 Then
            cmbareades.Focus()
            Return False
        End If
        If cmbtarea.SelectedIndex < 0 Then
            cmbtarea.Focus()
            Return False
        End If
        If txtnom_art.Text = Nothing Then
            txtnom_art.Focus()
            Return False
        End If
        If cmbprioridad.Text = Nothing Then
            cmbprioridad.Focus()
            Return False
        End If
        If txtasuntosol.Text = Nothing Then
            txtasuntosol.Focus()
            Return False
        End If
        If txtdescsol.Text = Nothing Then
            txtdescsol.Focus()
            Return False
        End If
        If sOp = 0 Then
            If txtestado.Text <> "PENDIENTE" Then
                MsgBox("Ya no es posible modificar el servicio", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If
        Return True
    End Function

#Region "Llenar combos"
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
#End Region

    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        dtUsuario = ELTBMANTENIMIENTOBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)
        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            If txtt_doc.Text = "TMANT" Then
                cmbt_doc.SelectedIndex = 0
            End If
            cmb_serdoc.Items.Add(IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF")))
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            cmbccodori.SelectedValue = IIf(IsDBNull(Registro("CCO_CODORI")), "", Registro("CCO_CODORI"))
            cmbareaori.SelectedValue = IIf(IsDBNull(Registro("AREAORI")), "", Registro("AREAORI")) '
            cmbccoddes.SelectedValue = IIf(IsDBNull(Registro("CCO_CODDES")), "", Registro("CCO_CODDES"))
            cmbareades.SelectedValue = IIf(IsDBNull(Registro("AREADES")), "", Registro("AREADES")) '
            cmbtarea.SelectedIndex = IIf(IsDBNull(Registro("COD_TAREA")), "", Registro("COD_TAREA"))
            txtcod_art.Text = IIf(IsDBNull(Registro("ART_COD")), "", Registro("ART_COD"))
            cmbprioridad.SelectedIndex = IIf(IsDBNull(Registro("PRIORIDAD")), "", Registro("PRIORIDAD"))
            txtasuntosol.Text = IIf(IsDBNull(Registro("ASUNSOL")), "", Registro("ASUNSOL"))
            txtdescsol.Text = IIf(IsDBNull(Registro("DESCSOL")), "", Registro("DESCSOL"))
            cmbestado.SelectedIndex = IIf(IsDBNull(Registro("EST")), "", Registro("EST"))
            Select Case Registro("EST").ToString
                Case "0"
                    txtestado.Text = "PENDIENTE"
                Case "1"
                    txtestado.Text = "ANULADO"
                Case "2"
                    txtestado.Text = "CERRADO"
                Case "3"
                    txtestado.Text = "PROCESO"
                Case "4"
                    txtestado.Text = "FINALIZADO"
            End Select
        Next
    End Sub
    Private Sub FormELTBMANTENIMIENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "SOLUCITUD DE MANTENIMIENTO"
        bprimero = True
        Dim dt As DataTable = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbccodori)
        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbccoddes)
        'dt = ELTBMANTENIMIENTOBL.Selectarea
        'GetCmb("cod", "nom", dt, cmbtarea)
        dtgvtecnico.Columns.Add("per_cod", "Codigo")
        dtgvtecnico.Columns.Add("Nombre", "Nombre")
        dtgvtecnico.Columns.Add("est", "Estado")
        dtgvplano.Columns.Add("cod_pla", "Codigo")
        dtgvplano.Columns.Add("nom_pla", "Nombre")
        dtgvplano.Columns.Add("formato", "Formato")
        dtgvplano.Columns.Add("linea", "linea")
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                txtt_doc.Text = "TMANT"
                cmbt_doc.SelectedIndex = 0
                cmb_serdoc.Items.Add(Year(Now))
                cmb_serdoc.SelectedIndex = 0
                txtestado.Text = "PENDIENTE"
                cmbestado.SelectedIndex = 0
                bprimero = False
                cmbccodori.SelectedValue = ELTBMANTENIMIENTOBL.SelectCenCos(gsCodUsr)
                cmbccoddes.SelectedValue = 113 'ELTBMANTENIMIENTOBL.SelectCenCos(gsCodUsr)
                cmbtarea.SelectedItem = "FABRICACION"
                cmbprioridad.SelectedItem = "NORMAL"
                habilitarservicio(True)
            Case 1
                flagAccion = "M"
                bprimero = False
                Button5.Text = "Ver Plano"
                GetData(sTDoc, sSDoc, sNDoc)
                dt = ELTBMANTENIMIENTOBL.SelectTecnico(txtt_doc.Text, sSDoc, sNDoc)
                For Each row As DataRow In dt.Rows
                    dtgvtecnico.Rows.Add(IIf(IsDBNull(row("per_cod")), "", row("per_cod")),
                                            IIf(IsDBNull(row("nombre")), "", row("nombre")),
                                            IIf(IsDBNull(row("est")), "", row("est")))
                Next
                ListarDirectorio()
                If sOp = "0" Then
                    habilitarservicio(True)
                ElseIf sOp = "1" Then
                    habilitartrabajo(True)
                End If
        End Select
        dtgvplano.Columns("linea").Visible = False
        If gsUser = "JVALVERDE" Or gsUser = "SISTEMAS" Then
            btnVerPlano.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''   sBusAlm = "120"
        ''   Dim frm As New FormBUSQUEDA
        sBusAlm = "122"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gArt <> Nothing And gSubLinea <> Nothing Then
            txtcod_art.Text = gArt
            txtnom_art.Text = gSubLinea
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
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
                If flagAccion = "M" Then
                    gsRptArgs = {}
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = txtt_doc.Text
                    gsRptArgs(1) = cmb_serdoc.Text
                    gsRptArgs(2) = txtnumero.Text
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTELTBMANTENIMIENTO.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If
            Case "anular"
                If MessageBox.Show("Desea anular el documento",
                     "Anular documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If
                Dim ELTBMANTENIMIENTOBE As New ELTBMANTENIMIENTOBE
                ELTBMANTENIMIENTOBE.T_DOC_REF = txtt_doc.Text
                ELTBMANTENIMIENTOBE.SER_DOC_REF = cmb_serdoc.Text
                ELTBMANTENIMIENTOBE.NRO_DOC_REF = txtnumero.Text
                ELTBMANTENIMIENTOBE.ART_COD = txtcod_art.Text
                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ELTBMANTENIMIENTOBL.SaveRow(ELTBMANTENIMIENTOBE, ELMVLOGSBE, "A", dtgvtecnico, dtgvplano)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    tsbGrabar.Enabled = False
                    tsbimprimir.Enabled = False
                    'Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
        End Select
    End Sub
    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If OkData() = False Then
            Exit Sub
        End If
        Try
            Dim ELTBMANTENIMIENTOBE As New ELTBMANTENIMIENTOBE
            Dim ELMVLOGSBE As New ELMVLOGSBE
            If flagAccion = "N" Then
                Dim nro As String
                txtnumero.Text = ""
                nro = ELTBMANTENIMIENTOBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
                If nro.Length = 1 Then
                    txtnumero.Text = "0000000" & nro
                ElseIf nro.Length = 2 Then
                    txtnumero.Text = "000000" & nro
                ElseIf nro.Length = 3 Then
                    txtnumero.Text = "00000" & nro
                ElseIf nro.Length = 4 Then
                    txtnumero.Text = "0000" & nro
                ElseIf nro.Length = 5 Then
                    txtnumero.Text = "000" & nro
                ElseIf nro.Length = 6 Then
                    txtnumero.Text = "00" & nro
                ElseIf nro.Length = 7 Then
                    txtnumero.Text = "0" & nro
                ElseIf nro.Length = 8 Then
                    txtnumero.Text = nro
                End If
            End If
            ELTBMANTENIMIENTOBE.T_DOC_REF = RTrim(txtt_doc.Text)
            ELTBMANTENIMIENTOBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
            ELTBMANTENIMIENTOBE.NRO_DOC_REF = RTrim(txtnumero.Text)
            ELTBMANTENIMIENTOBE.FEC_GENE = dtpfecha.Value

            ELTBMANTENIMIENTOBE.EST = cmbestado.SelectedIndex
            If txtestado.Text = "PENDIENTE" Then
                ELTBMANTENIMIENTOBE.EST = 0
            ElseIf txtestado.Text = "ANULADO" Then
                ELTBMANTENIMIENTOBE.EST = 1
            ElseIf txtestado.Text = "CERRADO" Then
                ELTBMANTENIMIENTOBE.EST = 2
            ElseIf txtestado.Text = "PROCESO" Then
                ELTBMANTENIMIENTOBE.EST = 3
            ElseIf txtestado.Text = "FINALIZADO" Then
                ELTBMANTENIMIENTOBE.EST = 4
            End If
            ELTBMANTENIMIENTOBE.CCO_CODORI = cmbccodori.SelectedValue
            ELTBMANTENIMIENTOBE.AREAORI = cmbareaori.SelectedValue
            ELTBMANTENIMIENTOBE.CCO_CODDES = cmbccoddes.SelectedValue
            ELTBMANTENIMIENTOBE.AREADES = cmbareades.SelectedValue
            ELTBMANTENIMIENTOBE.COD_TAREA = cmbtarea.SelectedIndex
            ELTBMANTENIMIENTOBE.ART_COD = txtcod_art.Text
            ELTBMANTENIMIENTOBE.PRIORIDAD = cmbprioridad.SelectedIndex
            ELTBMANTENIMIENTOBE.ASUNSOL = txtasuntosol.Text
            ELTBMANTENIMIENTOBE.DESCSOL = txtdescsol.Text
            ELTBMANTENIMIENTOBE.USUARIO = Trim(gsCodUsr)
            ELTBMANTENIMIENTOBE.FEC_GENET = dtpfec_gene.Value
            gsError = ELTBMANTENIMIENTOBL.SaveRow(ELTBMANTENIMIENTOBE, ELMVLOGSBE, flagAccion, dtgvtecnico, dtgvplano)
            If gsError = "OK" Then
                If guardar <> Nothing Then
                    SaveIMGPDF()
                End If
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                flagAccion = "M"
                Dispose()
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        Dim nro As String
        txtnumero.Text = ""
        nro = ELTBMANTENIMIENTOBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
        If nro.Length = 1 Then
            txtnumero.Text = "0000000" & nro
        ElseIf nro.Length = 2 Then
            txtnumero.Text = "000000" & nro
        ElseIf nro.Length = 3 Then
            txtnumero.Text = "00000" & nro
        ElseIf nro.Length = 4 Then
            txtnumero.Text = "0000" & nro
        ElseIf nro.Length = 5 Then
            txtnumero.Text = "000" & nro
        ElseIf nro.Length = 6 Then
            txtnumero.Text = "00" & nro
        ElseIf nro.Length = 7 Then
            txtnumero.Text = "0" & nro
        ElseIf nro.Length = 8 Then
            txtnumero.Text = nro
        End If
    End Sub

    Private Sub FormELTBMANTENIMIENTO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub cmbccodori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbccodori.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbccodori.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Dim dt As DataTable
        Try
            dt = ELTBMANTENIMIENTOBL.gArea(cmbccodori.SelectedValue)
            GetCmb("cod", "nom", dt, cmbareaori)
        Catch ex As Exception
            MsgBox("El centro de costo no cuenta con Area")
        End Try
    End Sub

    Private Sub cmbccoddes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbccoddes.SelectedIndexChanged
        If bprimero Then
            Exit Sub
        End If
        If cmbccoddes.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Dim dt As DataTable
        Try
            dt = ELTBMANTENIMIENTOBL.gArea(cmbccoddes.SelectedValue)
            GetCmb("cod", "nom", dt, cmbareades)
        Catch ex As Exception
            MsgBox("El centro de costo no cuenta con Area")
        End Try
    End Sub

    Private Sub txtcod_art_TextChanged(sender As Object, e As EventArgs) Handles txtcod_art.TextChanged
        If txtcod_art.TextLength > 7 Then
            Try
                txtnom_art.Text = ELTBMANTENIMIENTOBL.SelectNom(txtcod_art.Text)
            Catch
                MsgBox("La Maquina Equipo o Articulo no existe")
            End Try
        End If
    End Sub
    Private Sub habilitarservicio(ByVal estado As Boolean)
        GroupBoxAuditoria.Enabled = False
        GroupBoxPlanos.Enabled = False
        GroupBox3.Enabled = False
        Label14.Enabled = False
        ''  txtnom_per.Enabled = False

        Me.Size = New Point(658, 494)
        CentrarFormulario()
    End Sub
    Private Sub habilitartrabajo(ByVal estado As Boolean)
        cmbccodori.Enabled = False
        cmbareaori.Enabled = False
        cmbccoddes.Enabled = False
        'cmbareades.Enabled = False
        txtcod_art.ReadOnly = True
        cmbprioridad.Enabled = False
        txtasuntosol.ReadOnly = True
        txtdescsol.ReadOnly = True
        Button1.Enabled = False
        Label20.Enabled = True
        cmbtarea.Enabled = True
        GroupBox3.Enabled = False
        Me.Size = New Point(1126, 494)
        CentrarFormulario()
    End Sub
    Private Sub CentrarFormulario()
        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle
        If Not Parent Is Nothing Then
            r = Parent.ClientRectangle
            x = r.Width - Width + Parent.Left
            y = r.Height - Height + Parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - Width
            y = r.Height - Height
        End If
        x = CInt(x / 2)
        y = CInt(y / 2)
        StartPosition = FormStartPosition.Manual
        Location = New Point(x, y)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''  sBusAlm = "7"
        ''  Dim frm As New FormPerGrupo
        ''  frm.ShowDialog()
        sBusAlm = "4"
        'If cmbccodori.TextLength <> 0 Then
        gsCode10 = cmbccoddes.SelectedValue
        Dim frm As New FormPerHoraOM
        frm.ShowDialog()
        gsCode10 = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim folder As String
        If flagAccion = "N" Then
            Dim file As New OpenFileDialog()
            file.Filter = "Archivo JPG|*.jpg|PNG|*.png|PDF|*.pdf"
            If file.ShowDialog() = DialogResult.OK Then
                If Microsoft.VisualBasic.Right(file.FileName, 3) = "pdf" Then
                    gsRptPath = file.FileName
                    FormLectorPDF.ShowDialog()
                    If MessageBox.Show("Desea subir el Plano", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        file = Nothing
                        Exit Sub
                    End If
                    Tpo = "pdf"
                Else
                    pbximagen.Image = Image.FromFile(file.FileName)
                    gsRptPath = file.FileName
                    FormLectorIMG.ShowDialog()
                    If MessageBox.Show("Desea subir el Plano", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        file = Nothing
                        Exit Sub
                    End If
                End If
                guardar = file.FileName
            End If
        ElseIf flagAccion = "M" Then
            folder = Path.Combine(gsIpserver & "Planos\")
            If System.IO.File.Exists(Path.Combine(folder, txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".pdf")) Then
                gsRptPath = Path.Combine(folder, txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".pdf")
                FormLectorPDF.ShowDialog()
            ElseIf System.IO.File.Exists(Path.Combine(folder, txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".jpg")) Then
                gsRptPath = Path.Combine(folder, txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".jpg")
                FormLectorIMG.ShowDialog()
            Else
                MsgBox("No se encontraron planos")
            End If
        End If
    End Sub
    Private Sub SaveIMGPDF()
        Dim folder As String
        folder = Path.Combine(gsIpserver & "\Planos\")
        If flagAccion = "N" Then

            If Tpo = "pdf" Then
                Try
                    Dim fileName As String = Path.Combine(folder, txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".pdf")
                    ' Guardamos en disco el pdf existente en el control PictureBox
                    My.Computer.FileSystem.CopyFile(guardar, fileName, overwrite:=True)
                Catch ex As Exception
                    ' Se ha producido un error.
                    MessageBox.Show(ex.Message)
                End Try
            Else
                Try
                    ' Nombre del archivo.
                    Dim fileName As String = Path.Combine(folder, txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".jpg")

                    ' Guardamos en disco la imagen existente en el control PictureBox,
                    ' sobrescribiendo sin previo aviso cualquier otro archivo existente
                    ' con igual nombre.
                    pbximagen.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg)

                Catch ex As Exception
                    ' Se ha producido un error.
                    MessageBox.Show(ex.Message)
                End Try
            End If
        ElseIf flagAccion = "M" Then
            If System.IO.File.Exists(Path.Combine(".pdf")) Or System.IO.File.Exists(Path.Combine(folder, txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".jpg")) Then

                If MessageBox.Show("Desea Reemplazar el Plano", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                     MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If dtgvtecnico.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Quitar al Técnico",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dtgvtecnico.Rows.RemoveAt(dtgvtecnico.CurrentRow.Index)
            dtgvtecnico.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sBusAlm = "5"
        'If cmbccodori.TextLength <> 0 Then
        gsCode10 = cmbccoddes.SelectedValue
        Dim frm As New FormPerHoraOM
        frm.ShowDialog()
        gsCode10 = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If dtgvplano.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Quitar el Plano",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dtgvplano.Rows.RemoveAt(dtgvplano.CurrentRow.Index)
            dtgvplano.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub
    Private Sub ListarDirectorio()
        Dim dt As New DataTable
        Dim n As String
        Dim nActivo As String
        Dim ruta As String
        Dim dato As String
        Dim activo As String
        Dim newCurrentDirectory As DirectoryInfo
        Dim directoryArray As DirectoryInfo()
        Dim fileArray As FileInfo()
        Dim file As FileInfo

        dt = ELTBMANTENIMIENTOBL.SelectPlano(txtt_doc.Text, sSDoc, sNDoc)
        For Each row As DataRow In dt.Rows

            dato = IIf(IsDBNull(row("linea")), "", row("linea"))
            activo = IIf(IsDBNull(row("cod_pla")), "", row("cod_pla"))
            nActivo = Len(activo)

            ruta = gsIpserver & "Planos\" & dato & "\"
            newCurrentDirectory = New DirectoryInfo(ruta)
            directoryArray = newCurrentDirectory.GetDirectories()
            fileArray = newCurrentDirectory.GetFiles()
            For Each file In fileArray

                If (activo = vb.Left(file.Name, nActivo)) Then
                    If (nActivo = "8") Then
                        n = Len(file.Name) - 15
                        dtgvplano.Rows.Add(IIf(IsDBNull(row("cod_pla")), "", row("cod_pla")),
                                            Mid(file.Name, 12, n),
                                            vb.Right(file.Name, 4),
                                            IIf(IsDBNull(row("linea")), "", row("linea")))
                        Exit For
                    ElseIf (nActivo = "10") Then
                        n = Len(file.Name) - 17
                        dtgvplano.Rows.Add(IIf(IsDBNull(row("cod_pla")), "", row("cod_pla")),
                                            Mid(file.Name, 14, n),
                                            vb.Right(file.Name, 4),
                                            IIf(IsDBNull(row("linea")), "", row("linea")))
                        Exit For
                    ElseIf (nActivo = "11") Then
                        n = Len(file.Name) - 18
                        dtgvplano.Rows.Add(IIf(IsDBNull(row("cod_pla")), "", row("cod_pla")),
                                            Mid(file.Name, 15, n),
                                            vb.Right(file.Name, 4),
                                            IIf(IsDBNull(row("linea")), "", row("linea")))
                        Exit For
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub btnVerPlano_Click(sender As Object, e As EventArgs) Handles btnVerPlano.Click
        Dim folder As String
        Dim Nom As String
        If dtgvplano.RowCount = 0 Then
            MsgBox("No se encontraron planos")
            Exit Sub
        End If
        Nom = dtgvplano.Rows(dtgvplano.CurrentRow.Index).Cells(0).Value + " - " + dtgvplano.Rows(dtgvplano.CurrentRow.Index).Cells(1).Value + dtgvplano.Rows(dtgvplano.CurrentRow.Index).Cells(2).Value
        folder = Path.Combine(gsIpserver & "Planos\" & cmbareades.SelectedValue & "\")
        If System.IO.File.Exists(Path.Combine(folder, Nom)) Then
            gsRptPath = Path.Combine(folder, Nom)
            FormLectorPDF.ShowDialog()
        ElseIf System.IO.File.Exists(Path.Combine(folder, Nom)) Then
            gsRptPath = Path.Combine(folder, Nom)
            FormLectorIMG.ShowDialog()
        Else
            MsgBox("No se encontraron planos")
        End If
    End Sub
End Class