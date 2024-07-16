Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.IO
Public Class FormELTBCAPACITACION
    Dim ELTBCAPACITACIONBL As New ELTBCAPACITACIONBL
    Dim REQUERIMIENTOBL As New REQUERIMIENTOBL
    Dim ARTICULOBL As New ARTICULOBL
    Private bPrimero As Boolean = True
    Private gpCaption As String
    Private nro1 As String
    Public nom As String
    Dim ELTBSTIEMBL As New ELTBSTIEMBL
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable
        dtUsuario = ELTBCAPACITACIONBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)
        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))
            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
            dtpfec.Text = IIf(IsDBNull(Registro("FEC_DIA")), "", Registro("FEC_DIA"))

            Select Case Registro("EST").ToString
                'Case ""
                '    cmbestado.SelectedIndex = -1
                Case 0
                    cmbestado.SelectedIndex = 0
                Case 1
                    cmbestado.SelectedIndex = 1
                    tsbGrabar.Enabled = False
                    tsbimprimir.Enabled = False
                Case 2
                    cmbestado.SelectedIndex = 2
                    cmbestado.Enabled = False
            End Select
            If cmbestado.SelectedIndex = 1 Then
                dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            End If

            txtdni.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            txtTema.Text = IIf(IsDBNull(Registro("TEMA")), "", Registro("TEMA"))
            cmbdni.SelectedValue = txtdni.Text
            txtactivo.Text = IIf(IsDBNull(Registro("ACT_COD")), "", Registro("ACT_COD"))

            dtphoragene.Text = IIf(IsDBNull(Registro("HOR_INICIO")), "", Registro("HOR_INICIO"))
            dtphoratermino.Text = IIf(IsDBNull(Registro("HOR_FIN")), "", Registro("HOR_FIN"))
            txtobserva.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            cmbTipo.SelectedIndex = IIf(IsDBNull(Registro("TIPO")), "", Registro("TIPO"))
        Next
    End Sub
    Private Sub FormELTBCAPACITACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "CAPACITACION"
        Dim dt As DataTable

        dt = REQUERIMIENTOBL.SelectPer()
        GetCmb("cod", "nombre", dt, cmbdni)

        'dtphoragene.Format = DateTimePickerFormat.Custom
        'dtphoragene.CustomFormat = "HH:mm:ss tt"
        'dtphoragene.Text = "12:00:00 a.m."
        '
        'dtphoratermino.Format = DateTimePickerFormat.Custom
        'dtphoratermino.CustomFormat = "HH:mm:ss tt"
        'dtphoratermino.Text = "12:00:00 a.m."

        dgvt_doc.Columns.Add("T_DOC_REF", "Documento")  '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Serie")    '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Numero")   '2
        dgvt_doc.Columns.Add("T_DOC_REF1", "Documento") '3
        dgvt_doc.Columns.Add("SER_DOC_REF1", "Serie")   '4
        dgvt_doc.Columns.Add("NRO_DOC_REF1", "Numero")  '5
        dgvt_doc.Columns.Add("PER_COD", "Nro. Dni.")    '6
        dgvt_doc.Columns.Add("NOM", "NOM")              '7
        dgvt_doc.Columns.Add("LINEA_COD", "Cod. Area.") '8

        cmbt_doc.SelectedIndex = 0

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                txtt_doc.Text = "CSEG"


                cmb_serdoc.SelectedIndex = 0
                cmbestado.SelectedIndex = 0

                'txtdni.Text = "76086536"
                'txtdni_LostFocus(sender, e)

            Case 1
                flagAccion = "M"
                GetData(sTDoc, sSDoc, sNDoc)

                CheckBox1.Checked = True

                Dim dtCapacitados As DataTable
                dtCapacitados = ELTBCAPACITACIONBL.getListdgv(sTDoc, sSDoc, sNDoc)
                For Each row As DataRow In dtCapacitados.Rows
                    dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                      IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                                      IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                                      IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                                      IIf(IsDBNull(row("PER_COD1")), "", row("PER_COD1")),'6
                                      IIf(IsDBNull(row("NOM")), "", row("NOM")),'7
                                      IIf(IsDBNull(row("LINEA_COD")), "", row("LINEA_COD"))) '8
                Next

                Try
                    dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(3)
                Catch ex As Exception
                    '     MsgBox("No hay datos en el detalle")
                End Try
        End Select

        If ELTBSTIEMBL.SelPermiso(gsUser) = "1" Then
            dtpfecha.Enabled = True
        End If

        dgvt_doc.Columns("T_DOC_REF").Visible = False
        dgvt_doc.Columns("SER_DOC_REF").Visible = False
        dgvt_doc.Columns("NRO_DOC_REF").Visible = False

        bPrimero = False
    End Sub

    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        Dim nro As String
        txtnumero.Text = ""
        nro = ELTBCAPACITACIONBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
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
    'Private Sub cmbdni_LostFocus(sender As Object, e As EventArgs) Handles cmbdni.LostFocus
    '    If cmbdni.SelectedIndex = -1 Then
    '        MsgBox("Seleccione un dni de Personal")
    '        cmbdni.Select()
    '    End If
    'End Sub
    Private Sub cmbdni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdni.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbdni.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtdni.Text = cmbdni.SelectedValue
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "228"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtdni.Text = gLinea
            cmbdni.SelectedValue = txtdni.Text
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub
    Private Sub txtactivo_LostFocus(sender As Object, e As EventArgs) Handles txtactivo.LostFocus
        'Dim ARTICULOBL As ARTICULOBL
        If txtactivo.Text = "" Then
            txtArticulo.Text = ""
            Exit Sub
        End If

        txtArticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
        If txtArticulo.Text = Nothing Then
            MsgBox("Activo no existe", MsgBoxStyle.Exclamation)
            txtactivo.Text = ""
        End If
    End Sub

    Private Sub btnbusact_Click(sender As Object, e As EventArgs) Handles btnbusact.Click
        If txtArticulo.Visible = True Then
            sBusAlm = "122"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gArt <> Nothing And gSubLinea <> Nothing Then
                txtactivo.Text = gArt
                txtArticulo.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub

    Private Sub txtactivo_TextChanged(sender As Object, e As EventArgs) Handles txtactivo.TextChanged
        txtArticulo.Text = ARTICULOBL.SelectArt7(txtactivo.Text)
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
            'Case "delete"
            '    DeleteData()

            Case "exit"
                Dispose()
                Exit Sub
            Case "Print"
                If flagAccion = "M" Then
                    gsRptArgs = {}
                    ReDim gsRptArgs(3)
                    gsRptArgs(0) = txtt_doc.Text
                    gsRptArgs(1) = cmb_serdoc.Text
                    gsRptArgs(2) = txtnumero.Text
                    gsRptArgs(3) = cmbestado.SelectedIndex
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBCONTSEG.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If

            Case "Print1"
                If flagAccion = "M" Then
                    Process.Start("chrome", gsIpserver & "\CAPACITACION\" + txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".jpg")
                    ' For z = 0 To dgvt_doc.Rows.Count - 1
                    '     Process.Start("chrome", gsIpserver & "\CAPACITACION\" + dgvt_doc.Rows(z).Cells("T_DOC_REF").Value + dgvt_doc.Rows(z).Cells("SER_DOC_REF").Value + dgvt_doc.Rows(z).Cells("NRO_DOC_REF").Value + dgvt_doc.Rows(z).Cells("PER_COD").Value + ".jpg")
                    ' Next
                End If

            Case "anular"

                If MessageBox.Show("Desea anular el documento",
                   "Anular documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim ELTBCAPACITACIONBE As New ELTBCAPACITACIONBE

                ELTBCAPACITACIONBE.T_DOC_REF = txtt_doc.Text
                ELTBCAPACITACIONBE.SER_DOC_REF = cmb_serdoc.Text
                ELTBCAPACITACIONBE.NRO_DOC_REF = txtnumero.Text

                gsError = ELTBCAPACITACIONBL.SaveRow(ELTBCAPACITACIONBE, "A", dgvt_doc)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)

                    tsbGrabar.Enabled = False
                    tsbimprimir.Enabled = False
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If

        End Select
    End Sub
    Private Sub FormELTBCAPACITACION_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
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
            Dim ELTBCAPACITACIONBE As New ELTBCAPACITACIONBE
            If flagAccion = "N" Then
                Dim nro As String
                txtnumero.Text = ""
                nro = ELTBCAPACITACIONBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
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
            End If
            ELTBCAPACITACIONBE.T_DOC_REF = RTrim(txtt_doc.Text)
            ELTBCAPACITACIONBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
            ELTBCAPACITACIONBE.NRO_DOC_REF = RTrim(txtnumero.Text)
            ELTBCAPACITACIONBE.FEC_GENE = RTrim(dtpfecha.Value)
            If cbxFin.Checked = True Then
                ELTBCAPACITACIONBE.EST = "2"
                cmbestado.SelectedIndex = 2
            Else
                ELTBCAPACITACIONBE.EST = cmbestado.SelectedIndex
            End If
            ELTBCAPACITACIONBE.PER_COD = RTrim(txtdni.Text)
            ELTBCAPACITACIONBE.TEMA = RTrim(txtTema.Text)
            ELTBCAPACITACIONBE.ACT_COD = RTrim(txtactivo.Text)
            ELTBCAPACITACIONBE.FEC_DIA = RTrim(dtpfec.Value)
            ELTBCAPACITACIONBE.HOR_INI = RTrim(dtphoragene.Text)
            ELTBCAPACITACIONBE.HOR_FIN = RTrim(dtphoratermino.Text)
            ELTBCAPACITACIONBE.USUARIO = Trim(gsCodUsr)
            ELTBCAPACITACIONBE.OBSERVA = txtobserva.Text
            ELTBCAPACITACIONBE.TIPO = cmbTipo.SelectedIndex


            gsError = ELTBCAPACITACIONBL.SaveRow(ELTBCAPACITACIONBE, flagAccion, dgvt_doc)
            If gsError = "OK" Then

                '    'Direccion del Directorio en el debug
                '    Dim folder As String = Path.Combine(Application.StartupPath, "CAPACITACION")
                '    ' Mueve todo el contenido del Directorio a Otro
                '    My.Computer.FileSystem.CopyDirectory(folder, gsIpserver & "\CAPACITACION", True)
                '
                '    ' Filtra si Existe el Directorio
                '    If Directory.Exists(folder) Then
                '        'Elimna El Directorio y Contenido
                '        My.Computer.FileSystem.DeleteDirectory(folder, FileIO.DeleteDirectoryOption.DeleteAllContents)
                '    End If

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
    Private Function OkData() As Boolean
        If cmbestado.SelectedIndex = 2 Then
            MsgBox("El documento esta finalizado", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtdni.Text = "" Then
            MsgBox("Por favor ingrese el dni de la persona que capacita", MsgBoxStyle.Exclamation)
            txtdni.Select()
            Return False
        End If
        If txtTema.Text = "" Then
            MsgBox("Por favor ingrese el tema de la capacitación", MsgBoxStyle.Exclamation)
            txtobserva.Select()
            Return False
        End If
        If txtactivo.Text <> Nothing And txtArticulo.Text = Nothing Then
            MsgBox("Por favor ingrese un activo", MsgBoxStyle.Exclamation)
            txtobserva.Select()
            Return False
        End If

        'Dim date1, date2 As DateTime
        'date1 = dtpfec.Value.ToShortDateString
        'date2 = dtpfec.Value.ToShortDateString
        'date1 = date1.AddHours(dtphoragene.Value.Hour)
        'date1 = date1.AddMinutes(dtphoragene.Value.Minute)
        'date1 = date1.AddSeconds(dtphoragene.Value.Second)
        '
        'date2 = date2.AddHours(dtphoratermino.Value.Hour)
        'date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
        'date2 = date2.AddSeconds(dtphoratermino.Value.Second)

        'If DateTime.Compare(date1, date2) >= 0 Then
        '    MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
        '    dtphoragene.Focus()
        '    Return False
        'End If

        'If CheckBox1.Checked = False Then
        '    MsgBox("Ingrese Archivo", MsgBoxStyle.Exclamation)
        '    dtphoragene.Focus()
        '    Return False
        'End If
        If cmbTipo.SelectedIndex < 0 Then
            MsgBox("Seleccionar Tipo", MsgBoxStyle.Exclamation)
            cmbTipo.Select()
            Return False
        End If

        Return True
    End Function

    Private Sub dtphoratermino_ValueChanged(sender As Object, e As EventArgs) Handles dtphoratermino.ValueChanged
        '   Dim date1, date2 As DateTime
        '   date1 = dtpfec.Value.ToShortDateString
        '   date2 = dtpfec.Value.ToShortDateString
        '   date1 = date1.AddHours(dtphoragene.Value.Hour)
        '   date1 = date1.AddMinutes(dtphoragene.Value.Minute)
        '   date1 = date1.AddSeconds(dtphoragene.Value.Second)
        '
        '   date2 = date2.AddHours(dtphoratermino.Value.Hour)
        '   date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
        '   date2 = date2.AddSeconds(dtphoratermino.Value.Second)
        '   If flagAccion <> "M" Then
        '       If DateTime.Compare(date1, date2) >= 0 Then
        '           MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
        '           dtphoragene.Focus()
        '       End If
        '   End If

    End Sub

    Private Sub dtphoragene_ValueChanged(sender As Object, e As EventArgs) Handles dtphoragene.ValueChanged
        '   Dim date1, date2 As DateTime
        '   date1 = dtpfec.Value.ToShortDateString
        '   date2 = dtpfec.Value.ToShortDateString
        '   date1 = date1.AddHours(dtphoragene.Value.Hour)
        '   date1 = date1.AddMinutes(dtphoragene.Value.Minute)
        '   date1 = date1.AddSeconds(dtphoragene.Value.Second)
        '
        '   date2 = date2.AddHours(dtphoratermino.Value.Hour)
        '   date2 = date2.AddMinutes(dtphoratermino.Value.Minute)
        '   date2 = date2.AddSeconds(dtphoratermino.Value.Second)
        '
        '   If flagAccion <> "M" Then
        '       If DateTime.Compare(date1, date2) >= 0 Then
        '           MsgBox("La fecha de inicio No debe ser mayor o igual a la fecha de Termino ", MsgBoxStyle.Exclamation)
        '           dtphoragene.Focus()
        '       End If
        '   End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Accion As String = ""
        Dim frm As New FormELTBDETCAPACITACION
        frm.tipo = txtt_doc.Text
        frm.ser = cmb_serdoc.Text
        frm.nro = txtnumero.Text
        frm.Height = 190
        If flagAccion = "M" Then
            Accion = "1"
            gnOpcion = 0
        End If
        gContador = 1
        frm.ShowDialog()
        If Accion = "1" Then
            gnOpcion = 1
            flagAccion = "M"
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If dgvt_doc.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim frm As New FormPerGrupoCapa
        gsCode10 = ""
        frm.ShowDialog()
        If (gLinea <> Nothing) Then
            For z = 0 To dgvt_doc.Rows.Count - 1
                If dgvt_doc.Rows(z).Cells("PER_COD").Value = gLinea Then
                    MsgBox("Se repite los registros")
                    gLinea = Nothing
                    gSubLinea = Nothing
                    Exit Sub
                End If
            Next

            dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PER_COD").Value = gLinea
            dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NOM").Value = nom
            dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("LINEA_COD").Value = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
            nom = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            nom = Nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dgvt_doc.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            'If dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("X_IMG").Value = 1 Then
            '    My.Computer.FileSystem.DeleteFile(gsIpserver & "\CAPACITACION\" + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("T_DOC_REF").Value + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("SER_DOC_REF").Value + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("NRO_DOC_REF").Value + dgvt_doc.Rows(dgvt_doc.CurrentRow.Index).Cells("PER_COD").Value + ".jpg")
            'End If
            dgvt_doc.Rows.RemoveAt(dgvt_doc.CurrentRow.Index)
            dgvt_doc.Refresh()

        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub btncargararch_Click(sender As Object, e As EventArgs) Handles btncargararch.Click
        Dim frm As New FormELTBDETCAPACITACION
        frm.tipo = txtt_doc.Text
        frm.ser = cmb_serdoc.Text
        frm.nro = txtnumero.Text
        If flagAccion = "M" Then
            Try
                Dim NumPal As Integer
                Dim NomArc1 As String
                Dim NonArc2 As String = txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text
                Dim Formato As String = 0
                ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
                For Each archivos As String In My.Computer.FileSystem.GetFiles(gsIpserver & "\CAPACITACION\", FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                    NumPal = Len(archivos) - 31
                    NomArc1 = Mid(archivos, 28, NumPal)
                    If NomArc1 = NonArc2 Then
                        frm.PictureBox2.ImageLocation = gsIpserver & "\CAPACITACION\" + txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".jpg" ' Abre imagen del servidor
                        Formato = 1
                        Exit For
                    End If
                Next
                If Formato = 0 Then
                    For Each archivos As String In My.Computer.FileSystem.GetFiles(gsIpserver & "\CAPACITACION\", FileIO.SearchOption.SearchAllSubDirectories, "*.pdf")
                        NumPal = Len(archivos) - 31
                        NomArc1 = Mid(archivos, 28, NumPal)
                        If NomArc1 = NonArc2 Then

                            frm.lblPdf.Text = gsIpserver & "\CAPACITACION\" + txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".pdf"
                            Formato = 1
                            Exit For
                        End If
                    Next
                End If
            Catch ex As Exception
                MsgBox("No se realizó la operación por: " & ex.Message)
            End Try
        ElseIf CheckBox1.Checked Then
            Try
                Dim NumPal As Integer
                Dim NomArc1 As String
                Dim NonArc2 As String = txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text
                Dim Formato As String = 0
                ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
                For Each archivos As String In My.Computer.FileSystem.GetFiles(gsIpserver & "\CAPACITACION\", FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                    NumPal = Len(archivos) - 31
                    NomArc1 = Mid(archivos, 28, NumPal)
                    If NomArc1 = NonArc2 Then
                        frm.PictureBox2.ImageLocation = gsIpserver & "\CAPACITACION\" + txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".jpg" ' Abre imagen del servidor
                        Formato = 1
                        Exit For
                    End If
                Next
                If Formato = 0 Then
                    For Each archivos As String In My.Computer.FileSystem.GetFiles(gsIpserver & "\CAPACITACION\", FileIO.SearchOption.SearchAllSubDirectories, "*.pdf")
                        NumPal = Len(archivos) - 31
                        NomArc1 = Mid(archivos, 28, NumPal)
                        If NomArc1 = NonArc2 Then
                            frm.lblPdf.Text = gsIpserver & "\CAPACITACION\" + txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".pdf"
                            Formato = 1
                            Exit For
                        End If
                    Next
                End If
            Catch ex As Exception
                MsgBox("No se realizó la operación por: " & ex.Message)
            End Try
            ' frm.PictureBox2.ImageLocation = gsIpserver & "\CAPACITACION\" + txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text + ".jpg" ' Abre imagen del servidor
        End If
        frm.GroupBox3.Visible = False
        frm.GroupBox1.Visible = False
        frm.GroupBox4.Visible = True
        frm.ShowDialog()
    End Sub

    Private Sub btnbustem_Click(sender As Object, e As EventArgs) Handles btnbustem.Click
        If txtArticulo.Visible = True Then
            sBusAlm = "121"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gArt <> Nothing And gSubLinea <> Nothing Then
                txtTema.Text = gArt
                txtNomTema.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gSubLinea = Nothing
                gArt = Nothing
            End If
        End If
    End Sub

    Private Sub txtTema_TextChanged(sender As Object, e As EventArgs) Handles txtTema.TextChanged
        txtNomTema.Text = ""
        Dim dtUsuario As DataTable
        dtUsuario = ELTBCAPACITACIONBL.SelectTema(txtTema.Text)
        For Each Registro In dtUsuario.Rows
            txtNomTema.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
        Next
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If flagAccion = "N" Then
            Dim Frm As New FormMantTema
            Frm.ShowDialog()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        gsCode10 = ""
        Dim frm As New FormPerGrupoCapa
        frm.ShowDialog()

        ''  sBusAlm = "6" ' 2
        ''  'gsCode10 = "101"
        ''   Dim frm As New FormPerGrupo
        ''  frm.ShowDialog()

        If (gLinea <> Nothing) Then

            nro1 = dgvt_doc.Rows.Count + 1
            If nro1.Length = 1 Then
                nro1 = "000000" & nro1
            ElseIf nro1.Length = 2 Then
                nro1 = "00000" & nro1
            ElseIf nro1.Length = 3 Then
                nro1 = "0000" & nro1
            ElseIf nro1.Length = 4 Then
                nro1 = "000" & nro1
            ElseIf nro1.Length = 5 Then
                nro1 = "00" & nro1
            ElseIf nro1.Length = 6 Then
                nro1 = "0" & nro1
            ElseIf nro1.Length = 7 Then
                nro1 = nro1
            End If

            For z = 0 To dgvt_doc.Rows.Count - 1
                If dgvt_doc.Rows(z).Cells("NRO_DOC_REF1").Value >= nro1 Then
                    nro1 = dgvt_doc.Rows(z).Cells("NRO_DOC_REF1").Value + 1
                    If nro1.Length = 1 Then
                        nro1 = "000000" & nro1
                    ElseIf nro1.Length = 2 Then
                        nro1 = "00000" & nro1
                    ElseIf nro1.Length = 3 Then
                        nro1 = "0000" & nro1
                    ElseIf nro1.Length = 4 Then
                        nro1 = "000" & nro1
                    ElseIf nro1.Length = 5 Then
                        nro1 = "00" & nro1
                    ElseIf nro1.Length = 6 Then
                        nro1 = "0" & nro1
                    ElseIf nro1.Length = 7 Then
                        nro1 = nro1
                    End If
                End If
            Next

            For z = 0 To dgvt_doc.Rows.Count - 1
                If dgvt_doc.Rows(z).Cells("PER_COD").Value = gLinea Then
                    MsgBox("Se repite los registros")
                    gLinea = Nothing
                    gSubLinea = Nothing
                    Exit Sub
                End If
            Next
            dgvt_doc.Rows.Add(txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, txtt_doc.Text, cmb_serdoc.Text, txtnumero.Text, gLinea, nom, gSubLinea)
            nro1 = Nothing
            gLinea = Nothing
            gSubLinea = Nothing
            nom = Nothing
        Else
            nro1 = Nothing
            gLinea = Nothing
            gSubLinea = Nothing
            nom = Nothing
        End If

    End Sub

    Private Sub Docu_Click(sender As Object, e As EventArgs) Handles Docu.Click
        Dim frm As New FormDocuRefEva
        frm.txtt_doc.ReadOnly = True
        'frm.txtser_doc.ReadOnly = True
        frm.txtt_doc.Text = txtt_doc.Text
        frm.txtser_doc.Text = cmb_serdoc.Text
        frm.Form = "capacitacion"
        frm.ShowDialog()
    End Sub
End Class