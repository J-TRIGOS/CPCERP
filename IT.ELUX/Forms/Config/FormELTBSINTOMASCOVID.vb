Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormELTBSINTOMASCOVID
    Private ELTBSINTOMAS_COVIDBL As New ELTBSINTOMAS_COVIDBL
    Private ELTBSINTOMAS_COVIDBE As New ELTBSINTOMAS_COVIDBE
    'Private ELMVLOGSBE As New ELMVLOGSBE
    Private gpCaption As String
    Dim flagAccion As String
    Dim NRO_DOC As String
    Dim fecha As Date = Date.Now()

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtdni.Text = gLinea
            'txtnomper.Text = gSubLinea
            Dim dt As DataTable
            dt = ELTBSINTOMAS_COVIDBL.SelectBuscar(txtdni.Text)

            For Each row As DataRow In dt.Rows
                txtnomper.Text = IIf(IsDBNull(row("APE_NOM")), "", row("APE_NOM"))
                txtarea.Text = IIf(IsDBNull(row("area")), "", row("area"))
                'TextBox5.Text = IIf(IsDBNull(row("dni")), "", row("dni"))
                txtdir.Text = IIf(IsDBNull(row("direc")), "", row("direc"))
                txtnum.Text = IIf(IsDBNull(row("telf")), "", row("telf"))
            Next
            gLinea = Nothing
            gSubLinea = Nothing
            'Else

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

            Case "exit"
                Dispose()
                Exit Sub
            Case "Print"
                ReDim gsRptArgs(6)
                gsRptArgs(0) = RTrim(txttdoc.Text)
                gsRptArgs(1) = RTrim(txtsdoc.Text)
                gsRptArgs(2) = RTrim(txtndoc.Text)
                gsRptArgs(3) = ""
                gsRptArgs(4) = ""
                gsRptArgs(5) = ""
                gsRptArgs(6) = ""
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBSINTOMAS_COVID.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
                Exit Sub
            Case "anular"
                If MessageBox.Show("Desea anular el documento",
                       gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If
                Dim ELTBSINTOMAS_COVIDBE As New ELTBSINTOMAS_COVIDBE
                ELTBSINTOMAS_COVIDBE.t_doc_ref = txttdoc.Text
                ELTBSINTOMAS_COVIDBE.ser_doc_ref = txtsdoc.Text
                ELTBSINTOMAS_COVIDBE.nro_doc_ref = txtndoc.Text


                Dim ELMVLOGSBE As New ELMVLOGSBE
                ELMVLOGSBE.log_codusu = gsCodUsr
                gsError = ELTBSINTOMAS_COVIDBL.SaveRow(ELTBSINTOMAS_COVIDBE, "A")


                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)

                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If

        End Select
    End Sub
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim ELTBSINTOMAS_COVIDBE As New ELTBSINTOMAS_COVIDBE


        ELTBSINTOMAS_COVIDBE.t_doc_ref = txttdoc.Text
        ELTBSINTOMAS_COVIDBE.ser_doc_ref = txtsdoc.Text
        ELTBSINTOMAS_COVIDBE.nro_doc_ref = txtndoc.Text

        ELTBSINTOMAS_COVIDBE.dni = txtdni.Text
        ELTBSINTOMAS_COVIDBE.s1 = cmbs1.Text
        ELTBSINTOMAS_COVIDBE.s2 = cmbs2.Text
        ELTBSINTOMAS_COVIDBE.s3 = cmbs3.Text
        ELTBSINTOMAS_COVIDBE.s4 = cmbs4.Text
        ELTBSINTOMAS_COVIDBE.s5 = cmbs5.Text
        ELTBSINTOMAS_COVIDBE.fec_gene = dtpfec_gene.Value
        ELTBSINTOMAS_COVIDBE.descri = txtobs.Text
        'ELTBSINTOMAS_COVIDBE.est = "H"
        If cmbestado.SelectedIndex = 0 Then
            ELTBSINTOMAS_COVIDBE.est = "H"
        ElseIf cmbestado.SelectedIndex = 1 Then
            ELTBSINTOMAS_COVIDBE.est = "A"
        End If
        gsError = ELTBSINTOMAS_COVIDBL.SaveRow(ELTBSINTOMAS_COVIDBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError + " " + gsError2
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow
        dtUsuario = ELTBSINTOMAS_COVIDBL.SelectRow(sTDoc, sSDoc, sNDoc)
        For Each Registro In dtUsuario.Rows
            'txtt_doc.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txttdoc.Text = sTDoc
            txtsdoc.Text = sSDoc
            txtndoc.Text = sNDoc
            cmbs1.Text = IIf(IsDBNull(Registro("S1")), "", Registro("S1"))
            cmbs2.Text = IIf(IsDBNull(Registro("S2")), "", Registro("S2"))
            cmbs3.Text = IIf(IsDBNull(Registro("S3")), "", Registro("S3"))
            cmbs4.Text = IIf(IsDBNull(Registro("S4")), "", Registro("S4"))
            cmbs5.Text = IIf(IsDBNull(Registro("S5")), "", Registro("S5"))
            txtdni.Text = IIf(IsDBNull(Registro("PER_COD")), "", Registro("PER_COD"))
            txtobs.Text = IIf(IsDBNull(Registro("DESCRI")), "", Registro("DESCRI"))
            Select Case Trim(Registro("EST").ToString)
                Case ""
                    cmbestado.SelectedIndex = -1
                Case "H"
                    cmbestado.SelectedIndex = 0
                Case "A"
                    cmbestado.SelectedIndex = 1
            End Select
            Dim dt As DataTable
            dt = ELTBSINTOMAS_COVIDBL.SelectBuscar(txtdni.Text)

            For Each row As DataRow In dt.Rows
                txtnomper.Text = IIf(IsDBNull(row("APE_NOM")), "", row("APE_NOM"))
                txtarea.Text = IIf(IsDBNull(row("area")), "", row("area"))
                'TextBox5.Text = IIf(IsDBNull(row("dni")), "", row("dni"))
                txtdir.Text = IIf(IsDBNull(row("direc")), "", row("direc"))
                txtnum.Text = IIf(IsDBNull(row("telf")), "", row("telf"))
            Next
        Next

    End Sub

    Private Sub FormELTBSINTOMASCOVID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'flagAccion = "N"
        txtndoc.Text = ELTBSINTOMAS_COVIDBL.Ncont()
        txtsdoc.Text = Year(fecha)
        txttdoc.Text = "SINC"
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                cmbestado.SelectedIndex = 0
            Case 1
                flagAccion = "M"
                GetData(gsCode)
        End Select

    End Sub

    Private Sub limpiar()
        txtnomper.Text = Nothing
        txtarea.Text = Nothing
        txtdir.Text = Nothing
        txtnum.Text = Nothing
        cmbs1.Text = Nothing
        cmbs2.Text = Nothing
        cmbs3.Text = Nothing
        cmbs4.Text = Nothing
        cmbs5.Text = Nothing
        txtobs.Text = Nothing
    End Sub

    Private Sub FormELTBSINTOMASCOVID_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    'Private Sub cmbs5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbs5.SelectedIndexChanged
    '    If cmbs5.SelectedIndex = 0 Then
    '        txtobs.ReadOnly = False
    '        If cmbs5.Text = "NO" Then
    '            txtobs.Text = ""
    '        End If

    '    Else
    '        txtobs.ReadOnly = True
    '    End If
    'End Sub

    Private Sub txtdni_LostFocus(sender As Object, e As EventArgs) Handles txtdni.LostFocus
        Dim dt As DataTable
        If flagAccion = "N" Then
            limpiar()
            dt = ELTBSINTOMAS_COVIDBL.SelectBuscar(txtdni.Text)

            For Each row As DataRow In dt.Rows
                txtnomper.Text = IIf(IsDBNull(row("APE_NOM")), "", row("APE_NOM"))
                txtarea.Text = IIf(IsDBNull(row("area")), "", row("area"))
                'TextBox5.Text = IIf(IsDBNull(row("dni")), "", row("dni"))
                txtdir.Text = IIf(IsDBNull(row("direc")), "", row("direc"))
                txtnum.Text = IIf(IsDBNull(row("telf")), "", row("telf"))
            Next
        End If
    End Sub

    Private Sub FormELTBSINTOMASCOVID_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtdni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtdni.Text = gLinea
                'txtnomper.Text = gSubLinea
                Dim dt As DataTable
                dt = ELTBSINTOMAS_COVIDBL.SelectBuscar(txtdni.Text)

                For Each row As DataRow In dt.Rows
                    txtnomper.Text = IIf(IsDBNull(row("APE_NOM")), "", row("APE_NOM"))
                    txtarea.Text = IIf(IsDBNull(row("area")), "", row("area"))
                    'TextBox5.Text = IIf(IsDBNull(row("dni")), "", row("dni"))
                    txtdir.Text = IIf(IsDBNull(row("direc")), "", row("direc"))
                    txtnum.Text = IIf(IsDBNull(row("telf")), "", row("telf"))
                Next
                gLinea = Nothing
                gSubLinea = Nothing
                'Else

            End If
        End If
    End Sub
End Class