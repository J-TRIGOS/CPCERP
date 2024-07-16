Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormSistIntCalidad
    Dim ELTBSISTINTCALIDADBL As New ELTBSISTINTCALIDADBL
    Private GUIAALMACENBL As New GUIAALMACENBL
    Private bPrimero As Boolean = True
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub GetData(ByVal sT_Ref As String, ByVal sS_Ref As String, ByVal sN_Ref As String)
        Dim dtUsuario As DataTable

        dtUsuario = ELTBSISTINTCALIDADBL.SelectRow(sT_Ref, sS_Ref, sN_Ref)

        For Each Registro In dtUsuario.Rows
            txtt_doc.Text = IIf(IsDBNull(Registro("T_DOC_REF")), "", Registro("T_DOC_REF"))
            cmb_serdoc.SelectedItem = IIf(IsDBNull(Registro("SER_DOC_REF")), "", Registro("SER_DOC_REF"))
            txtnumero.Text = IIf(IsDBNull(Registro("NRO_DOC_REF")), "", Registro("NRO_DOC_REF"))

            dtpfecha.Text = IIf(IsDBNull(Registro("FEC_GENE")), "", Registro("FEC_GENE"))
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
            txtcodif.Text = IIf(IsDBNull(Registro("CODIFICACION")), "", Registro("CODIFICACION"))
            txProceso.Text = IIf(IsDBNull(Registro("TEMA")), "", Registro("TEMA"))
            txtc_costo.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
            lblNomPDF.Text = IIf(IsDBNull(Registro("NOM_PDF")), "", Registro("NOM_PDF"))


            'dtpfec.Text = IIf(IsDBNull(Registro("FEC_DIA")), "", Registro("FEC_DIA"))
            '
            'Select Case Registro("EST").ToString
            '    'Case ""
            '    '    cmbestado.SelectedIndex = -1
            '    Case 0
            '        cmbestado.SelectedIndex = 0
            '    Case 1
            '        cmbestado.SelectedIndex = 1
            '        tsbGrabar.Enabled = False
            '        tsbimprimir.Enabled = False
            '    Case 2
            '        cmbestado.SelectedIndex = 2
            '        cmbestado.Enabled = False
            'End Select
            'If cmbestado.SelectedIndex = 1 Then
            '    dtpfanul.Text = IIf(IsDBNull(Registro("FEC_ANU")), "", Registro("FEC_ANU"))
            'End If
            '
            'txtdni.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            'txtTema.Text = IIf(IsDBNull(Registro("TEMA")), "", Registro("TEMA"))
            'cmbdni.SelectedValue = txtdni.Text
            'txtactivo.Text = IIf(IsDBNull(Registro("ACT_COD")), "", Registro("ACT_COD"))
            '
            'dtphoragene.Text = IIf(IsDBNull(Registro("HOR_INICIO")), "", Registro("HOR_INICIO"))
            'dtphoratermino.Text = IIf(IsDBNull(Registro("HOR_FIN")), "", Registro("HOR_FIN"))
            'txtobserva.Text = IIf(IsDBNull(Registro("OBSERVA")), "", Registro("OBSERVA"))
            'cmbTipo.SelectedIndex = IIf(IsDBNull(Registro("TIPO")), "", Registro("TIPO"))
            '
        Next

    End Sub
    Private Sub FormSistIntCalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "SISTEMA DE CALIDAD"
        Dim dt As DataTable

        dt = ELTBSISTINTCALIDADBL.SelectCodif()
        GetCmb("cod", "nombre", dt, cmbcodif)

        dt = GUIAALMACENBL.SelectCCosto
        GetCmb("cod", "nom", dt, cmbc_costo)

        cmbt_doc.SelectedIndex = 0
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                txtt_doc.Text = "CSEG"
                cmb_serdoc.SelectedIndex = 0
                cmbestado.SelectedIndex = 2
            Case 1

                flagAccion = "M"
                GetData("CSEG", sSDoc, sNDoc)
                '
                '    CheckBox1.Checked = True
                '
                '    Dim dtCapacitados As DataTable
                '    dtCapacitados = ELTBCAPACITACIONBL.getListdgv(sTDoc, sSDoc, sNDoc)
                '    For Each row As DataRow In dtCapacitados.Rows
                '        dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                '                          IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                '                          IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                '                          IIf(IsDBNull(row("T_DOC_REF1")), "", row("T_DOC_REF1")),'3
                '                          IIf(IsDBNull(row("SER_DOC_REF1")), "", row("SER_DOC_REF1")),'4
                '                          IIf(IsDBNull(row("NRO_DOC_REF1")), "", row("NRO_DOC_REF1")),'5
                '                          IIf(IsDBNull(row("PER_COD1")), "", row("PER_COD1")),'6
                '                          IIf(IsDBNull(row("NOM")), "", row("NOM")),'7
                '                          IIf(IsDBNull(row("LINEA_COD")), "", row("LINEA_COD"))) '8
                '    Next
                '
                '    Try
                '        dgvt_doc.CurrentCell = dgvt_doc.Rows(0).Cells(3)
                '    Catch ex As Exception
                '        '     MsgBox("No hay datos en el detalle")
                '    End Try
        End Select
        bPrimero = False
        txtcodif_LostFocus(sender, e)
        txProceso_LostFocus(sender, e)
        txtc_costo_LostFocus(sender, e)
    End Sub
    Private Sub cmb_serdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_serdoc.SelectedIndexChanged
        Dim nro As String
        txtnumero.Text = ""
        nro = ELTBSISTINTCALIDADBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
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
    Private Sub cmbcodif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodif.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbcodif.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtcodif.Text = cmbcodif.SelectedValue
    End Sub
    Private Sub txtcodif_LostFocus(sender As Object, e As EventArgs) Handles txtcodif.LostFocus
        If txtcodif.Text = "" Then
            cmbcodif.SelectedValue = ""
            Exit Sub
        End If
        cmbcodif.SelectedValue = txtcodif.Text
        If cmbcodif.SelectedValue Is Nothing Then
            MsgBox("Personal no existe", MsgBoxStyle.Exclamation)
            txtcodif.Text = ""
        End If
    End Sub
    Private Sub txProceso_LostFocus(sender As Object, e As EventArgs) Handles txProceso.LostFocus


        If txProceso.Text = "" Then
            cmbProceso.SelectedValue = ""
            Exit Sub
        End If

        'cmbProceso.SelectedValue = txtcodif.Text
        If txProceso.Text = "SIG" Then
            cmbProceso.Text = "GESTION DE LA MEJORA"
        ElseIf txProceso.Text = "PP" Then
            cmbProceso.Text = "PLANIFICACION Y PRESUPUESTO"
        ElseIf txProceso.Text = "GAF" Then
            cmbProceso.Text = "GERENCIA ADMINISTRATIVA"
        ElseIf txProceso.Text = "RH" Then
            cmbProceso.Text = "GESTION HUMANA"
        ElseIf txProceso.Text = "RH-BS" Then
            cmbProceso.Text = "BIENESTAR SOCIAL"
        ElseIf txProceso.Text = "GVN" Then
            cmbProceso.Text = "GERENCIA COMERCIAL NACIONAL"
        ElseIf txProceso.Text = "GVEX" Then
            cmbProceso.Text = "GERENCIA COMERCIAL EXPORTACION"
        ElseIf txProceso.Text = "SIS" Then
            cmbProceso.Text = "GESTION INFORMATICA"
        ElseIf txProceso.Text = "LOG" Then
            cmbProceso.Text = "GESTION LOGISTICA COMPRAS"
        ElseIf txProceso.Text = "ALD" Then
            cmbProceso.Text = "ALMACEN Y DESPACHO"
        ElseIf txProceso.Text = "AC" Then
            cmbProceso.Text = "ASEGURAMIENTO Y CONTROL DE LA CALIDAD"
        ElseIf txProceso.Text = "PRO" Then
            cmbProceso.Text = "PRODUCCION"
        ElseIf txProceso.Text = "DD" Then
            cmbProceso.Text = "DISEÑO Y DESARROLLO"
        ElseIf txProceso.Text = "DDMM" Then
            cmbProceso.Text = "DISEÑO Y DESARROLLO DE ENVASE"
        ElseIf txProceso.Text = "MM" Then
            cmbProceso.Text = "MANTENIMIENTO Y MAESTRANZA"
        ElseIf txProceso.Text = "SSO" Then
            cmbProceso.Text = "SEGURIDAD Y SALUD OCUPACIONAL"
        End If


        If cmbProceso.Text Is Nothing Then
            MsgBox("Proceso no existe", MsgBoxStyle.Exclamation)
            cmbProceso.Text = ""
        End If


    End Sub

    Private Sub cmbProceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProceso.SelectedIndexChanged

        If cmbProceso.Text = "GESTION DE LA MEJORA" Then
            txProceso.Text = "SIG"
        ElseIf cmbProceso.Text = "PLANIFICACION Y PRESUPUESTO" Then
            txProceso.Text = "PP"
        ElseIf cmbProceso.Text = "GERENCIA ADMINISTRATIVA" Then
            txProceso.Text = "GAF"
        ElseIf cmbProceso.Text = "GESTION HUMANA" Then
            txProceso.Text = "RH"
        ElseIf cmbProceso.Text = "BIENESTAR SOCIAL" Then
            txProceso.Text = "RH-BS"
        ElseIf cmbProceso.Text = "GERENCIA COMERCIAL NACIONAL" Then
            txProceso.Text = "GVN"
        ElseIf cmbProceso.Text = "GERENCIA COMERCIAL EXPORTACION" Then
            txProceso.Text = "GVEX"
        ElseIf cmbProceso.Text = "GESTION INFORMATICA" Then
            txProceso.Text = "SIS"
        ElseIf cmbProceso.Text = "GESTION LOGISTICA COMPRAS" Then
            txProceso.Text = "LOG"
        ElseIf cmbProceso.Text = "ALMACEN Y DESPACHO" Then
            txProceso.Text = "ALD"
        ElseIf cmbProceso.Text = "ASEGURAMIENTO Y CONTROL DE LA CALIDAD" Then
            txProceso.Text = "AC"
        ElseIf cmbProceso.Text = "PRODUCCION" Then
            txProceso.Text = "PRO"
        ElseIf cmbProceso.Text = "DISEÑO Y DESARROLLO" Then
            txProceso.Text = "DD"
        ElseIf cmbProceso.Text = "DISEÑO Y DESARROLLO DE ENVASE" Then
            txProceso.Text = "DDMM"
        ElseIf cmbProceso.Text = "MANTENIMIENTO Y MAESTRANZA" Then
            txProceso.Text = "MM"
        ElseIf cmbProceso.Text = "SEGURIDAD Y SALUD OCUPACIONAL" Then
            txProceso.Text = "SSO"
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
    Private Sub cmbc_costo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbc_costo.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        If cmbc_costo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        txtc_costo.Text = cmbc_costo.SelectedValue
    End Sub

    Private Sub btncargararch_Click(sender As Object, e As EventArgs) Handles btncargararch.Click
        Dim frm As New FormELTBDETCAPACITACION
        sBusAlm = "FARDODETALMACEN"
        If flagAccion = "M" Then
            Try
                'Dim NumPal As Integer = "ArchivoPDF"
                ' Dim NomArc1 As String
                ' Dim NonArc2 As String = txtt_doc.Text + cmb_serdoc.Text + txtnumero.Text
                'Dim Formato As String = 0
                'If NumPal <> lblNomPDF.Text Then
                '  For Each archivos As String In My.Computer.FileSystem.GetFiles(gsIpserver & "\GestionHumanaPDF\", FileIO.SearchOption.SearchAllSubDirectories, "*.pdf")
                'NumPal = Len(archivos) - 31
                'NomArc1 = Mid(archivos, 28, NumPal)
                'If NomArc1 = NonArc2 Then

                frm.lblPdf.Text = gsIpserver & "GestionHumanaPDF\" + lblNomPDF.Text
                '    Formato = 1
                '    Exit For
                'End If
                '  Next
                'End If
            Catch ex As Exception
                MsgBox("No se realizó la operación por: " & ex.Message)
            End Try
        End If
        frm.ShowDialog()
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
            Case "anular"
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
            Dim ELTBSISTINTCALIDADBE As New ELTBSISTINTCALIDADBE
            '    If flagAccion = "N" Then
            '        Dim nro As String
            '        txtnumero.Text = ""
            '        nro = ELTBCAPACITACIONBL.SelectNro(txtt_doc.Text, cmb_serdoc.SelectedItem)
            '        If nro.Length = 1 Then
            '            txtnumero.Text = "000000" & nro
            '        ElseIf nro.Length = 2 Then
            '            txtnumero.Text = "00000" & nro
            '        ElseIf nro.Length = 3 Then
            '            txtnumero.Text = "0000" & nro
            '        ElseIf nro.Length = 4 Then
            '            txtnumero.Text = "000" & nro
            '        ElseIf nro.Length = 5 Then
            '            txtnumero.Text = "00" & nro
            '        ElseIf nro.Length = 6 Then
            '            txtnumero.Text = "0" & nro
            '        ElseIf nro.Length = 7 Then
            '            txtnumero.Text = nro
            '        End If
            '    End If
            ELTBSISTINTCALIDADBE.T_DOC_REF = RTrim(txtt_doc.Text)
            ELTBSISTINTCALIDADBE.SER_DOC_REF = RTrim(cmb_serdoc.Text)
            ELTBSISTINTCALIDADBE.NRO_DOC_REF = RTrim(txtnumero.Text)
            ELTBSISTINTCALIDADBE.FEC_GENE = RTrim(dtpfecha.Value)
            ELTBSISTINTCALIDADBE.ESTADO = cmbestado.SelectedIndex

            ELTBSISTINTCALIDADBE.CODIFICACION = txtcodif.Text
            ELTBSISTINTCALIDADBE.TEMA = txProceso.Text
            ELTBSISTINTCALIDADBE.CCO = txtc_costo.Text
            ELTBSISTINTCALIDADBE.NOMPDF = lblNomPDF.Text

            gsError = ELTBSISTINTCALIDADBL.SaveRow(ELTBSISTINTCALIDADBE, flagAccion)
            If gsError = "OK" Then
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
        If txtcodif.Text = "" Then
            MsgBox("Por favor ingrese el dni de la persona que capacita", MsgBoxStyle.Exclamation)
            txtcodif.Select()
            Return False
        End If
        If txProceso.Text = "" Then
            MsgBox("Por favor ingrese el tema de la capacitación", MsgBoxStyle.Exclamation)
            txProceso.Select()
            Return False
        End If
        If txtc_costo.Text = "" Then
            MsgBox("Por favor ingrese un activo", MsgBoxStyle.Exclamation)
            txtc_costo.Select()
            Return False
        End If
        If lblNomPDF.Text = "ArchivoPDF" Then
            MsgBox("Por favor ingrese un activo", MsgBoxStyle.Exclamation)
            txtc_costo.Select()
            Return False
        End If


        If txtcodif.Text = "" Then
            MsgBox("El documento esta finalizado", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txProceso.Text = "" Then
            MsgBox("El documento esta finalizado", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtc_costo.Text = "" Then
            MsgBox("Por favor ingrese el dni de la persona que capacita", MsgBoxStyle.Exclamation)
            txtcodif.Select()
            Return False
        End If
        If lblNomPDF.Text = "lblNomPDF" Then
            MsgBox("Por favor ingrese el dni de la persona que capacita", MsgBoxStyle.Exclamation)
            txtcodif.Select()
            Return False
        End If

        Return True
    End Function

    Private Sub FormSistIntCalidad_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

End Class