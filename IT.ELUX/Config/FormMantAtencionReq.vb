Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantAtencionReq
    Private REQUERIMIENTOBL As New REQUERIMIENTOBL
    Private DET_DOCUMENTOBL As New DET_DOCUMENTOBL
    Private PERBL As New PERBL
    Private ARTICULOBL As New ARTICULOBL

    Private Sub FormMantAtencionReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Informacion Atencion"
        Me.txttipo.Text = sTDoc
        Me.txtserie.Text = sSDoc
        Me.txtnumero.Text = sNDoc
        If gsCode8.Length > 13 Then
            dtpfecent.Checked = True
            dtpfecent.Value = gsCode8
        Else
            dtpfecent.Checked = False
        End If
        Me.txtsoli.Text = gsCode7
        Me.txtnomsol.Text = PERBL.SelectApeNom(gsCode7)
        Me.txtent.Text = gsCode9
        Me.txtnoment.Text = PERBL.SelectApeNom(gsCode9)
        Me.txtarticulo.Text = sCos
        Me.txtnomart.Text = ARTICULOBL.SelectArt2(txtarticulo.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtsoli.Text = gLinea
            txtnomsol.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "37"
        Dim frm As New BusquedaPersonal
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtent.Text = gLinea
            txtnoment.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If

    End Sub

    Private Sub SaveData()
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
        DET_DOCUMENTOBE.T_DOC_REF = RTrim(txttipo.Text)
        DET_DOCUMENTOBE.SER_DOC_REF = RTrim(txtserie.Text)
        DET_DOCUMENTOBE.NRO_DOC_REF = RTrim(txtnumero.Text)
        DET_DOCUMENTOBE.ART_COD = RTrim(txtarticulo.Text)
        If dtpfecent.Checked Then
            DET_DOCUMENTOBE.FEC_ENT = dtpfecent.Value
        End If
        ELMVLOGSBE.log_codigo = gsCodUsr
        DET_DOCUMENTOBE.LICENCIA = txtent.Text
        DET_DOCUMENTOBE.LOTE = txtsoli.Text
        Dim dt As DataGridView
        gsError = REQUERIMIENTOBL.SaveRow(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, "RM", dt, "")
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            FormMain.LblError.Text = gsError
            tsbGrabar.Enabled = False
        Else
        FormMain.LblError.Text = gsError
        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
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
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormMantAtencionReq_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtsoli_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsoli.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtsoli.Text = gLinea
                txtnomsol.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub

    Private Sub txtent_KeyDown(sender As Object, e As KeyEventArgs) Handles txtent.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "37"
            Dim frm As New BusquedaPersonal
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtent.Text = gLinea
                txtnoment.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
        End If
    End Sub
End Class