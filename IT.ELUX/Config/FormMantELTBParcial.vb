Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBParcial
    Private ORDENCOMPRABL As New ORDENCOMPRABL
    Private PARCIALBL As New PARCIALBL
    Private suma As Double = 0
    Private fecha As Date
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   "Parcial", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        Dim nro As String
        'Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim PARCIALBE As New PARCIALBE
        ELMVLOGSBE.log_codusu = gsCodUsr
        dgvt_doc.Refresh()
        gsError = PARCIALBL.SaveRow(PARCIALBE, ELMVLOGSBE, flagAccion, dgvt_doc)
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
            Case "Print"
                'gsRptArgs = {}
                'ReDim gsRptArgs(2)
                'gsRptArgs(0) = cmbt_doc.SelectedValue
                'gsRptArgs(1) = cmb_serdoc.SelectedItem
                'gsRptArgs(2) = txtnumero.Text
                'gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_OREQ.rpt"
                'gsRptPath = gsPathRpt
                'FormReportes.ShowDialog()
        End Select
    End Sub
    Private Sub FormMantELTBParcial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Parcial"
        Me.txtnomart.ReadOnly = True
        Me.txtt_doc.ReadOnly = True
        Me.txtart.ReadOnly = True
        dgvt_doc.Columns.Add("T_DOC_REF", "Tipo") '0
        dgvt_doc.Columns.Add("SER_DOC_REF", "Ser") '1
        dgvt_doc.Columns.Add("NRO_DOC_REF", "Nro") '2
        dgvt_doc.Columns.Add("ART_COD", "ART_COD") '3
        dgvt_doc.Columns.Add("CANTIDAD", "Cantidad") '4
        dgvt_doc.Columns.Add("FEC_ENT", "Fecha") '5
        dgvt_doc.Columns.Add("EST", "Estado") '6
        dgvt_doc.Columns(0).Visible = False
        dgvt_doc.Columns(1).Visible = False
        dgvt_doc.Columns(2).Visible = False
        dgvt_doc.Columns(3).Visible = False
        Dim dtArticulo As DataTable
        flagAccion = "M"
        dtArticulo = PARCIALBL.getListdgv("82", cmb_serdoc.Text, txtnumero.Text, txtart.Text)
        For Each row As DataRow In dtArticulo.Rows
            dgvt_doc.Rows.Add(IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF")),'0
                                      IIf(IsDBNull(row("SER_DOC_REF")), "", row("SER_DOC_REF")),'1
                                      IIf(IsDBNull(row("NRO_DOC_REF")), "", row("NRO_DOC_REF")),'2
                                      IIf(IsDBNull(row("ART_COD")), "", row("ART_COD")),'3
                                      IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")),'4
                                      IIf(IsDBNull(row("FEC_ENT")), "", row("FEC_ENT")),'5
                                      IIf(IsDBNull(row("EST")), "", row("EST"))) '6
        Next
    End Sub

    Private Sub FormMantELTBParcial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        suma = 0
        fecha = Nothing
        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Por favor elija el estado del articulo")
            Exit Sub
        End If
        If npdcantidad.Value = 0 Then
            MsgBox("Por favor ingrese una cantidad")
        Else
            If dgvt_doc.Rows.Count = 0 Then
                dgvt_doc.Rows.Add(Mid(Me.txtt_doc.Text, 1, 2), cmb_serdoc.Text, Me.txtnumero.Text, Me.txtart.Text, Me.npdcantidad.Value, Me.dtpfecha.Text, Me.cmbestado.Text)
            Else
                For i = 0 To dgvt_doc.Rows.Count - 1
                    If i = 0 Then
                        fecha = dgvt_doc.Rows(i).Cells("FEC_ENT").Value
                    Else
                        If DateDiff(DateInterval.Day, Convert.ToDateTime(fecha).Date, Convert.ToDateTime(dgvt_doc.Rows(i).Cells("FEC_ENT").Value).Date) > 0 Then
                            fecha = dgvt_doc.Rows(i).Cells("FEC_ENT").Value
                        End If
                    End If
                Next
                If DateDiff(DateInterval.Day, Convert.ToDateTime(fecha).Date, Convert.ToDateTime(dtpfecha.Value).Date) <= 0 Then
                    'If fecha < dtpfecha.Value Then
                    MsgBox("La fecha es menor o igual a una de las existentes")
                    Exit Sub
                End If
                For i = 0 To dgvt_doc.Rows.Count - 1
                    If dtpfecha.Value = dgvt_doc.Rows(i).Cells("FEC_ENT").Value Then
                        MsgBox("La fecha debe ser diferente a las que ya existen")
                        Exit Sub
                    End If
                Next
                For i = 0 To dgvt_doc.Rows.Count - 1
                    suma = dgvt_doc.Rows(i).Cells("CANTIDAD").Value + suma
                Next
                suma = suma + npdcantidad.Value
                If suma > Label8.Text Then
                    If MessageBox.Show("La suma de los parciales es mayor a lo declarado, ¿Desea Modificarlo?",
                              "Parcial", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    End If
                    dgvt_doc.Rows.Add(Mid(Me.txtt_doc.Text, 1, 2), cmb_serdoc.Text, Me.txtnumero.Text, Me.txtart.Text, Me.npdcantidad.Value, Me.dtpfecha.Value, Me.cmbestado.Text)
                    FormMantOrdenCompra.dgvt_doc.Rows(FormMantOrdenCompra.dgvt_doc.CurrentRow.Index).Cells(0).Value = suma
                    Label8.Text = suma
                Else
                    dgvt_doc.Rows.Add(Mid(Me.txtt_doc.Text, 1, 2), cmb_serdoc.Text, Me.txtnumero.Text, Me.txtart.Text, Me.npdcantidad.Value, Me.dtpfecha.Text, Me.cmbestado.Text)
                End If
            End If
        End If
        dgvt_doc.Refresh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        sBusAlm = "37"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtnomart.Text = gArt
            txtart.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs)
        sBusAlm = "5"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtnomart.Text = gArt
            txtart.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub
End Class