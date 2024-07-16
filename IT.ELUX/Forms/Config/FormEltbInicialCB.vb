Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormEltbInicialCB
    Private gpCaption As String
    Private ELTBINICIALCBBL As New ELTBINICIALCBBL
    Private Sub GetData(ByVal sANHO As String, ByVal sCode As String)
        Dim dtArticulo As DataTable
        Dim Registro As DataRow
        dtArticulo = ELTBINICIALCBBL.SelectRow(sANHO, sCode)
        For Each Registro In dtArticulo.Rows
            txtctabco.Text = IIf(IsDBNull(Registro("COD_BCO")), "", Registro("COD_BCO"))
            npdmonto.Value = IIf(IsDBNull(Registro("MONTO")), "", Registro("MONTO"))
            cmbaño.Text = IIf(IsDBNull(Registro("ANHO")), "", Registro("ANHO"))
            If txtctabco.Text = "1" Then
                txtnomcbo.Text = "BCP Soles"
            ElseIf txtctabco.Text = "2" Then
                txtnomcbo.Text = "BCP Dolares"
            ElseIf txtctabco.Text = "3" Then
                txtnomcbo.Text = "Banco de la Nacion"
            End If
        Next
    End Sub
    Private Sub FormEltbInicialCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                cmbaño.Text = sAño
            Case 1
                flagAccion = "M"
                GetData(sTDoc, sNDoc)
        End Select
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
                Case "Print"
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SaveData()
        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If


        Dim ELMVLOGSBE As New ELMVLOGSBE
        Dim ELTBINICIALCBBE As New ELTBINICIALCBBE
        ELTBINICIALCBBE.ANHO = cmbaño.Text
        ELTBINICIALCBBE.CTABCO = txtctabco.Text
        ELTBINICIALCBBE.MONTO = npdmonto.Value
        ELMVLOGSBE.log_codusu = gsCodUsr
        gsError = ELTBINICIALCBBL.SaveRow(ELTBINICIALCBBE, flagAccion, ELMVLOGSBE)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub FormEltbInicialCB_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "257"
        gsCode11 = cmbaño.Text
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtctabco.Text = gLinea
            If gLinea = "1" Then
                txtnomcbo.Text = "BCP Soles"
            ElseIf gLinea = "2" Then
                txtnomcbo.Text = "BCP Dolares"
            ElseIf gLinea = "3" Then
                txtnomcbo.Text = "Banco de la Nacion"
            End If
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
        gsCode11 = ""
    End Sub

    Private Sub txtctabco_KeyDown(sender As Object, e As KeyEventArgs) Handles txtctabco.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "257"
            gsCode11 = cmbaño.Text
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                txtctabco.Text = gLinea
                If gLinea = "1" Then
                    txtnomcbo.Text = "BCP Soles"
                ElseIf gLinea = "2" Then
                    txtnomcbo.Text = "BCP Dolares"
                ElseIf gLinea = "3" Then
                    txtnomcbo.Text = "Banco de la Nacion"
                End If
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gArt = Nothing
            End If
            e.Handled = True
        End If
        gsCode11 = ""
    End Sub

    Private Sub txtctabco_LostFocus(sender As Object, e As EventArgs) Handles txtctabco.LostFocus
        If txtctabco.Text = "1" Then
            txtnomcbo.Text = "BCP Soles"
        ElseIf txtctabco.Text = "2" Then
            txtnomcbo.Text = "BCP Dolares"
        ElseIf txtctabco.Text = "3" Then
            txtnomcbo.Text = "Banco de la Nacion"
        End If
    End Sub
End Class