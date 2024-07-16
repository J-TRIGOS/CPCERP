Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantExpor
    Private COSTOS_EXPBL As New COSTOS_EXPBL
    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim COSTOS_EXPBE As New COSTOS_EXPBE

        'flagAccion1 = "M"
        COSTOS_EXPBE.T_DOC_REF = RTrim(txtt_doc_ref.Text)
        COSTOS_EXPBE.SER_DOC_REF = RTrim(txtser_doc_ref.Text)
        COSTOS_EXPBE.NRO_DOC_REF = RTrim(txtnro_doc_ref.Text)
        COSTOS_EXPBE.COD = "1"
        COSTOS_EXPBE.SUB_TOTAL_EXWORKS = npdsub_total_exworks.Value
        COSTOS_EXPBE.GASTOS_AL_FCA = npdgastos_al_fca.Value
        COSTOS_EXPBE.SUB_TOTAL_FCA = npdsub_total_fca.Value
        COSTOS_EXPBE.TOTAL_FOB_CALLAO = npdtotal_fob_callao.Value
        COSTOS_EXPBE.FLETE_INTERNACIONAL = npdflete_internacional.Value
        COSTOS_EXPBE.SEGURO = npdseguro.Value
        COSTOS_EXPBE.TOTAL_CPT = npdtotal_cpt.Value
        COSTOS_EXPBE.TOTAL_CFR = npdtotal_cfr.Value
        COSTOS_EXPBE.TOTAL_CIF = npdtotal_cif.Value
        COSTOS_EXPBE.TOTAL_CIP = npdtotal_cip.Value
        COSTOS_EXPBE.TOTAL_FCA = npdtotal_fca.Value
        COSTOS_EXPBE.PESO_NETO = npdPESO_NETO.Value
        COSTOS_EXPBE.PESO_TOTAL = npdpeso_total.Value
        COSTOS_EXPBE.OBSERVA = txtobserva.Text
        COSTOS_EXPBE.CONTENEDOR = txtcontenedor.Text
        COSTOS_EXPBE.PRECINTO = txtprecinto.Text
        COSTOS_EXPBE.TOTAL_PAQUETES = txttotal_paquetes.Text


        ELMVLOGSBE.log_codusu = gsCodUsr
        gsError = COSTOS_EXPBL.SaveRow(COSTOS_EXPBE, ELMVLOGSBE, flagAccion1)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            'Dispose()

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

            Case "save"
                SaveData()
                Exit Sub
            Case "exit"
                Dispose()
                Exit Sub
        End Select
    End Sub
    Private Sub FormMantExpor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If txtt_doc_ref.Text = "01" Then
        Dim dt As DataTable = COSTOS_EXPBL.SelectRow(txtt_doc_ref.Text, txtser_doc_ref.Text, txtnro_doc_ref.Text)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    npdsub_total_exworks.Value = IIf(IsDBNull(row("sub_total_exworks")), 0, row("sub_total_exworks"))
                    npdgastos_al_fca.Value = IIf(IsDBNull(row("gastos_al_fca")), 0, row("gastos_al_fca"))
                    npdsub_total_fca.Value = IIf(IsDBNull(row("sub_total_fca")), 0, row("sub_total_fca"))
                    npdtotal_fob_callao.Value = IIf(IsDBNull(row("total_fob_callao")), 0, row("total_fob_callao"))
                    npdflete_internacional.Value = IIf(IsDBNull(row("flete_internacional")), 0, row("flete_internacional"))
                    npdseguro.Value = IIf(IsDBNull(row("seguro")), 0, row("seguro"))
                    npdtotal_cpt.Value = IIf(IsDBNull(row("total_cpt")), 0, row("total_cpt"))
                    npdtotal_cfr.Value = IIf(IsDBNull(row("total_cfr")), 0, row("total_cfr"))
                    npdtotal_cif.Value = IIf(IsDBNull(row("total_cif")), 0, row("total_cif"))
                    npdtotal_fca.Value = IIf(IsDBNull(row("total_fca")), 0, row("total_fca"))
                    npdtotal_cip.Value = IIf(IsDBNull(row("total_cip")), 0, row("total_cip"))
                    txttotal_paquetes.Text = IIf(IsDBNull(row("total_paquetes")), "", row("total_paquetes"))
                txtobserva.Text = IIf(IsDBNull(row("observa")), "", row("observa"))
                txtcontenedor.Text = IIf(IsDBNull(row("contenedor")), "", row("contenedor"))
                txtprecinto.Text = IIf(IsDBNull(row("precinto")), "", row("precinto"))
                npdpeso_neto.Value = IIf(IsDBNull(row("peso_neto")), 0, row("peso_neto"))
                npdpeso_total.Value = IIf(IsDBNull(row("peso_total")), 0, row("peso_total"))

            Next
                flagAccion1 = "M"
            Else
                flagAccion1 = "N"
            End If

    End Sub

    Private Sub FormMantExpor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub


    Private Sub npdflete_internacional_LostFocus(sender As Object, e As EventArgs) Handles npdflete_internacional.LostFocus
        If npdgastos_al_fca.Value > 0 And npdflete_internacional.Value > 0 Then
            npdtotal_cpt.Value = npdsub_total_exworks.Value + npdgastos_al_fca.Value + npdflete_internacional.Value
            If npdflete_internacional.Value = 0 Then
                npdflete_internacional.Value = 0
            End If
            npdtotal_cfr.Value = 0
            npdtotal_cif.Value = 0
            npdtotal_cip.Value = 0
        End If

        If npdtotal_fob_callao.Value > 0 And npdflete_internacional.Value > 0 Then
            npdtotal_cfr.Value = npdtotal_fob_callao.Value + npdflete_internacional.Value
            npdtotal_cpt.Value = 0
            npdtotal_cif.Value = 0
            npdtotal_fca.Value = 0
            npdtotal_cip.Value = 0
        End If
        If npdtotal_fob_callao.Value > 0 And npdseguro.Value > 0 Then
            npdtotal_cif.Value = npdtotal_fob_callao.Value + npdflete_internacional.Value + npdseguro.Value
            npdtotal_cpt.Value = 0
            npdtotal_cfr.Value = 0
            npdtotal_fca.Value = 0
            npdtotal_cip.Value = 0
        End If
        If npdsub_total_exworks.Value > 0 And npdgastos_al_fca.Value > 0 And npdseguro.Value > 0 Then
            npdtotal_cip.Value = npdflete_internacional.Value + npdgastos_al_fca.Value + npdseguro.Value + npdsub_total_exworks.Value
            npdtotal_cpt.Value = 0
            npdtotal_cfr.Value = 0
            npdtotal_fca.Value = 0
            npdtotal_cif.Value = 0
        End If
    End Sub

    Private Sub npdsub_total_fca_LostFocus(sender As Object, e As EventArgs) Handles npdsub_total_fca.LostFocus
        If npdgastos_al_fca.Value > 0 Then
            npdtotal_fca.Value = npdsub_total_exworks.Value + npdgastos_al_fca.Value

        End If
    End Sub

    Private Sub npdgastos_al_fca_LostFocus(sender As Object, e As EventArgs) Handles npdgastos_al_fca.LostFocus
        If npdgastos_al_fca.Value > 0 Then
            npdsub_total_fca.Value = npdgastos_al_fca.Value + npdsub_total_exworks.Value
        End If
    End Sub
End Class