Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantActaEntrega
    Private GUIADESPACHOBL As New GUIADESPACHOBL
    Private GUIADESPACHOBE As New GUIADESPACHOBE
    Private DET_DOCUMENTOBE As New DET_DOCUMENTOBE
    Private ELMVLOGSBE As New ELMVLOGSBE
    Public sT_ref, sS_ref, sN_Ref As String

    Private Sub FormMantActaEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvtacta.Columns.Add("T_DOC_REF", "doc") '0   
        dgvtacta.Columns.Add("SER_DOC_REF", "ser") '1
        dgvtacta.Columns.Add("NRO_DOC_REF", "nro") '2
        dgvtacta.Columns.Add("ART_COD", "Codigo") '3    
        dgvtacta.Columns.Add("NOM_ART", "Articulo") '4        
        dgvtacta.Columns.Add("N_BOLSAS", "Numero") '7
        dgvtacta.Columns.Add("CANTIDAD", "Cantidad") '8
        dgvtacta.Columns.Add("PAQUETE", "Tipo_paquete")
        dgvtacta.Columns(0).Visible = False
        dgvtacta.Columns(1).Visible = False
        dgvtacta.Columns(2).Visible = False

        If flagAccion = "M" Then
            'LLENAR GRID DIRECCIONES
            Dim dtGrid As DataTable
            dtGrid = GUIADESPACHOBL.SelectRowActa(sT_ref, sS_ref, sN_Ref)
            For Each row As DataRow In dtGrid.Rows
                dgvtacta.Rows.Add(sT_ref, sS_ref, sN_Ref,
                                  IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'3
                                  IIf(IsDBNull(row("NOM_ART")), "", row("NOM_ART")),'4
                                  IIf(IsDBNull(row("N_BOLSAS")), "", row("N_BOLSAS")),
                                  IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),  '6
                                  IIf(IsDBNull(row("T_PAQUETE")), "", row("T_PAQUETE"))) '6
            Next
        End If

    End Sub
    Private Sub cmbarticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbarticulo.SelectedIndexChanged

        Dim i As Integer = cmbarticulo.SelectedIndex
        If cmbarticulo.SelectedIndex <> -1 Then
            For Each row As DataGridViewRow In dgvt_doc.Rows
                lblnom.Text = dgvt_doc.Rows(i).Cells("NOM_ART").Value
                txtcantidad.Text = dgvt_doc.Rows(i).Cells("CANTIDAD").Value
            Next
        End If

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If OkData() = False Then
            Exit Sub
        Else
            dgvtacta.Rows.Add(dgvt_doc.Rows(0).Cells("T_DOC_REF").Value, dgvt_doc.Rows(0).Cells("SER_DOC_REF").Value, dgvt_doc.Rows(0).Cells("NRO_DOC_REF").Value, cmbarticulo.Text, lblnom.Text,
                              txtn_bolsas.Text, txtcantidad.Text, cmbTpaquete.SelectedItem)
            lblnom.Text = ""
            txtn_bolsas.Text = ""
            txtcantidad.Text = ""
            'cmbarticulo.SelectedIndex = -1
            'cmbTpaquete.SelectedIndex = -1
        End If
    End Sub
    Private Function OkData() As Boolean
        If lblnom.Text = "" Then
            MsgBox("Seleccione Un Codigo de Articulo", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtcantidad.Text = "" Then
            MsgBox("Ingrese la Cantidad", MsgBoxStyle.Exclamation)
            txtcantidad.Focus()
            Return False
        End If
        If txtn_bolsas.Text = "" Then
            MsgBox("Ingrese el Numero", MsgBoxStyle.Exclamation)
            txtn_bolsas.Focus()
            Return False
        End If
        If cmbTpaquete.SelectedIndex = -1 Then
            MsgBox("Seleccione un Paquete", MsgBoxStyle.Exclamation)
            txtn_bolsas.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        dgvtacta.Rows.Remove(dgvtacta.CurrentRow)
    End Sub

    Private Sub txtn_bolsas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress, txtn_bolsas.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        'If (cmbTpaquete.SelectedIndex = -1) Then
        '    MsgBox("Seleccione un tipo de paquete para los articulos", MsgBoxStyle.Exclamation)
        'Else
        If flagAccion = "N" Then
                flagAccion1 = "NA"
            Else
                flagAccion1 = "MA"
            End If

            Dim Valores(10) As String
            Dim Valores2(10) As String
            Dim cont As Integer = 0

            For Each row As DataGridViewRow In dgvt_doc.Rows
                Valores(cont) = RTrim(row.Cells("ART_COD").Value)
                cont = cont + 1
            Next
            cont = 0
            For Each rowa As DataGridViewRow In dgvtacta.Rows
                Valores2(cont) = RTrim(rowa.Cells("ART_COD").Value)
                cont = cont + 1
            Next

            Dim contador As Integer = 0

            For i = 0 To dgvt_doc.Rows.Count - 1
                contador = 0
                For j = 0 To dgvtacta.Rows.Count - 1
                    If Valores(i) = Valores2(j) Then
                        contador = contador + 1
                    End If
                Next
                If contador = 0 Then
                    MsgBox("Complete los articulos de la lista", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Next
        Dim dtusuario As DataTable
        gsError = GUIADESPACHOBL.SaveRowActa(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion1, dgvtacta, cmbTpaquete.SelectedIndex + 1, sEstAlmac, dtusuario)
        If gsError = "OK" Then
                MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                Dispose()
                Exit Sub
            Else
                FormMain.LblError.Text = gsError
                MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                Exit Sub
            End If
        'End If
    End Sub

End Class