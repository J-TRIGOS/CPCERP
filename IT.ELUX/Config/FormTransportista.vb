Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormTransportista

    Private FormMantTransportista As New FormMantGuiaDespacho
    Private GUIADESPACHOBL As New GUIADESPACHOBL
    Private ELTBTRANSPBL As New ELTBTRANSPBL
    Private ELTBTRANSPCHOFERBL As New ELTBTRANSPCHOFERBL

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FormMantTransportista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim eventarg As New EventArgs
        If txtcod.Text = "" Then
            Dim Series As String() = GUIADESPACHOBL.SelectMaxTrans(Date.Now.Year.ToString()).Split("|")
            txtNrodoc2.Text = Series(0).ToString().PadLeft(7, "0")
            cmb_transdoc.SelectedItem = "001"

            txtcod_LostFocus(sender, eventarg)

            txtplaca.Enabled = False
            txtchofer.Enabled = False
        Else

            gsCode7 = txtcod.Text
            txtcod_LostFocus(sender, eventarg)

            txtplaca.Enabled = True
            txtchofer.Enabled = True
        End If

    End Sub
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
    End Function
    Private Function GetCmb2(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
    End Function

    Private Sub txtcod_LostFocus(sender As Object, e As EventArgs) Handles txtcod.LostFocus
        If txtcod.Text = "" Then
            lblcod.Text = ""
            txtbrevete.Text = ""
            txtchofer.Text = ""
            lblchofer.Text = ""
            txtchofer.Enabled = False
            txtplaca.Enabled = False
        Else
            Dim dt As DataTable = ELTBTRANSPBL.SelectRow(txtcod.Text)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    lblcod.Text = IIf(IsDBNull(row("nom")), "", row("nom"))
                Next
                txtchofer.Enabled = True
                txtplaca.Enabled = True
                gsCode7 = txtcod.Text
            Else
                MsgBox("No existe el codigo de Transportista", MsgBoxStyle.Exclamation)
                lblcod.Text = ""
                txtbrevete.Text = ""
                txtchofer.Text = ""
                lblchofer.Text = ""
                txtchofer.Enabled = False
                txtplaca.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtchofer_LostFocus(sender As Object, e As EventArgs) Handles txtchofer.LostFocus
        If txtchofer.Text = "" Then
            txtbrevete.Text = ""
            lblchofer.Text = ""
            txtbrevete.Text = ""
        Else
            Dim dt As DataTable = GUIADESPACHOBL.SelectT_TranspChoferrow(txtcod.Text, txtchofer.Text)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    txtchofer.Text = IIf(IsDBNull(row("cho_cod")), "", row("cho_cod"))
                    lblchofer.Text = IIf(IsDBNull(row("chofer")), "", row("chofer"))
                    txtbrevete.Text = IIf(IsDBNull(row("brevete")), "", row("brevete"))
                Next
            Else
                MsgBox("No existe el codigo del Choferes", MsgBoxStyle.Exclamation)
                txtchofer.Text = ""
                lblchofer.Text = ""
                txtbrevete.Text = ""
            End If
        End If
    End Sub

    'Private Sub txtplaca_LostFocus(sender As Object, e As EventArgs) Handles txtplaca.LostFocus
    '    If txtplaca.Text <> "" Then
    '        Dim dtTractor As DataTable
    '        dtTractor = GUIADESPACHOBL.getDatostranspTractor(txtplaca.Text, txtcod.Text)
    '        If dtTractor.Rows.Count > 0 Then
    '            For Each row As DataRow In dtTractor.Rows
    '                txtmarca.Text = IIf(IsDBNull(row("marca")), "", row("marca"))
    '                txttipounidad.Text = IIf(IsDBNull(row("observacion")), "", row("observacion"))
    '                txtconfi.Text = IIf(IsDBNull(row("config_vehi")), "", row("config_vehi"))
    '                txtcertifi.Text = IIf(IsDBNull(row("certificado")), "", row("certificado"))
    '            Next
    '        Else
    '            txtplaca.Text = ""
    '            txtmarca.Text = ""
    '            txttipounidad.Text = ""
    '            txtconfi.Text = ""
    '            txtcertifi.Text = ""
    '        End If
    '    Else
    '        txtplaca.Text = ""
    '        txtmarca.Text = ""
    '        txttipounidad.Text = ""
    '        txtconfi.Text = ""
    '        txtcertifi.Text = ""
    '    End If

    'End Sub

    Private Function OkData() As Boolean
        If txtcod.Text = "084" Then
            If txtchofer.Text = "" Then
                MsgBox("Seleccione el nombre del Chofer", MsgBoxStyle.Exclamation)
                txtchofer.Focus()
                Return False
            End If
            If txtplaca.Text = "" Then
                MsgBox("Seleccione la Placa", MsgBoxStyle.Exclamation)
                txtplaca.Focus()
                Return False
            End If
            'Return True
        End If
        Return True
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If OkData() = False Then
            Exit Sub
        Else

            For i As Integer = 0 To FormMantGuiaDespacho.dgvt_doc.Rows.Count - 1
                FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("TRANSP_COD").Value = txtcod.Text
                FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("CHOFER").Value = lblchofer.Text
                FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("BREVETE").Value = txtbrevete.Text
                FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("PLACA").Value = txtplaca.Text
                FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("MARCA").Value = txtmarca.Text
                FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("CONFIGURACION").Value = txtconfi.Text
                FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("CERTIFICADO").Value = txtcertifi.Text
                FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("TIPO_UNIDAD").Value = txttipounidad.Text

                FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("COLOR").Value = cmb_transdoc.Text
                If txtcod.Text = "084" Then
                    FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("NRO_DOCU2").Value = txtNrodoc2.Text
                Else
                    FormMantGuiaDespacho.dgvt_doc.Rows(i).Cells("NRO_DOCU2").Value = "0000000"
                End If

                'FormMantGuiaDespacho.dgvt_doc.Rows(FormMantGuiaDespacho.dgvt_doc.CurrentRow.Index).Cells("TIPO_UNIDAD").Value = txttipounidad.Text
            Next
            Me.Close()
        End If
    End Sub


    Private Sub txtplaca_KeyDown(sender As Object, e As KeyEventArgs) Handles txtplaca.KeyDown
        'Cerrar = txtcod.Text
        'sBusAlm = "59"
        'If e.KeyValue = Keys.F9 Then

        '    Dim frm As New FormBUSQUEDA
        '    frm.ShowDialog()
        '    txtplaca.Text = gLinea
        '    txtmarca.Text = gSubLinea
        '    txttipounidad.Text = gArt
        '    txtconfi.Text = ""
        '    txtcertifi.Text = ""
        '    e.Handled = True
        'End If
        Cerrar = txtcod.Text
        sBusAlm = "65"
        If e.KeyValue = Keys.F9 Then
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtplaca.Text = gLinea
                txtmarca.Text = gSubLinea
                txttipounidad.Text = gArt
                txtconfi.Text = gsCode3
                txtcertifi.Text = gsCode4
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
                gsCode3 = Nothing
                gsCode4 = Nothing
                'txtmarca.Text = Nothing
                'txttipounidad.Text = Nothing
                'txtconfi.Text = Nothing
                'txtcertifi.Text = Nothing
                e.Handled = True
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
                gsCode3 = Nothing
                gsCode4 = Nothing
            End If
        End If
    End Sub

    Private Sub txtcod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcod.KeyDown
        sBusAlm = "82"
        If e.KeyValue = Keys.F9 Then

            Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
            If gLinea <> Nothing Then
                txtcod.Text = gLinea
                lblcod.Text = gSubLinea
                txtchofer.Text = ""
                lblchofer.Text = ""
                txtbrevete.Text = ""
                gsCode7 = gLinea
                gLinea = ""
                gSubLinea = ""
                txtchofer.Enabled = True
                txtplaca.Enabled = True
                gLinea = Nothing
                gSubLinea = Nothing
                e.Handled = True
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If

        End If
    End Sub


    Private Sub txtchofer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtchofer.KeyDown
        sBusAlm = "83"
        If e.KeyValue = Keys.F9 Then

            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtchofer.Text = gLinea
                lblchofer.Text = gSubLinea
                txtbrevete.Text = gArt
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
                e.Handled = True
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If

        End If
    End Sub

    Private Sub crear_chofer_Click(sender As Object, e As EventArgs) Handles crear_chofer.Click
        Dim frm As New FormMantELTBTRANSPCHOFER
        gnOpcion = 0
        gLinea = txtcod.Text
        gSubLinea = lblcod.Text
        Cerrar = "Guia"
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtchofer.Text = gLinea
            lblchofer.Text = gSubLinea
            txtbrevete.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If


    End Sub

    Private Sub crear_vehi_Click(sender As Object, e As EventArgs) Handles crear_vehi.Click
        Dim frm As New FormMantELTBTRANSPTRACTOR
        gnOpcion = 0
        gLinea = txtcod.Text
        gSubLinea = lblcod.Text
        Cerrar = "Guia"
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtplaca.Text = gLinea
            txtconfi.Text = gSubLinea
            txtmarca.Text = gArt
            txtcertifi.Text = gsCode2
            txttipounidad.Text = gsCode3
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
            gsCode3 = Nothing
            gsCode4 = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
            gsCode3 = Nothing
            gsCode4 = Nothing
        End If

    End Sub
End Class