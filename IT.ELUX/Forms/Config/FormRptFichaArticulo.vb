Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRptFichaArticulo
    Private T_MOVINVBL As New T_MOVINVBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private ARTICULOBL As New ARTICULOBL
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub
    Private Sub txtlinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinea.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "222"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtlinea.Text = Trim(gLinea) & "00"
                txtnomlinea.Text = gSubLinea
                txtsublinea.Enabled = True
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                txtsublinea.Enabled = False
            End If
        End If
    End Sub
    Private Sub txtsublinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsublinea.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "221"
            Dim frm As New FormBUSQUEDA
            gsCode7 = Mid(txtlinea.Text, 1, 2)
            frm.ShowDialog()
            If gLinea <> Nothing Then
                txtsublinea.Text = Trim(gLinea)
                txtnomsublinea.Text = gSubLinea
                txtcodart.Enabled = True
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                txtcodart.Enabled = False
            End If
        End If
    End Sub
    Private Sub txtsublinea_LostFocus(sender As Object, e As EventArgs) Handles txtsublinea.LostFocus
        If txtsublinea.TextLength = 4 Then
            txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
            'If txtnomsublinea.TextLength > 0 Then
            '    txtcodart.Enabled = True
            'Else
            '    txtcodart.Enabled = False
            'End If
        Else
            txtnomsublinea.Text = ""
            'txtcodart.Enabled = False
        End If
    End Sub

    Private Sub txtlinea_LostFocus(sender As Object, e As EventArgs) Handles txtlinea.LostFocus
        If txtlinea.TextLength = 4 Then
            txtnomlinea.Text = ELTBLINESBL.SelectDescri(txtlinea.Text)
            If txtnomlinea.TextLength > 0 Then
                txtsublinea.Enabled = True
            Else
                txtsublinea.Enabled = False
            End If
        Else
            txtnomlinea.Text = ""
            txtsublinea.Text = ""
            txtnomsublinea.Text = ""
            'txtsublinea.Enabled = False
        End If
    End Sub

    Private Sub btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        If txtcodart.Text = "" Or txtcodart.TextLength <> 8 Then
            MsgBox("Se debe colocar el articulo")
        Else
            Try
                'Dim articulo As String = "02230197"
                Dim rutaarchivo As String = ""
                'If Mid(txtcodart.Text, 1, 4) = "0223" Then
                '    For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.7\Fichas Tecnicas\PDF FICHAS\PDF FICHAS\TWO", FileIO.SearchOption.SearchAllSubDirectories, "" & txtcodart.Text & " *.pdf")
                '        rutaarchivo = archivos
                '    Next
                'ElseIf Mid(txtcodart.Text, 1, 4) = "0101" Then
                '    For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.5\Fichas Tecnicas\CENTRALPACK\PDF\FIBRA", FileIO.SearchOption.SearchAllSubDirectories, "" & txtcodart.Text & " *.pdf")
                '        rutaarchivo = archivos
                '    Next
                'ElseIf Mid(txtcodart.Text, 1, 4) = "0217" Or Mid(txtcodart.Text, 1, 4) = "0216" Or Mid(txtcodart.Text, 1, 4) = "0218" Or
                '    Mid(txtcodart.Text, 1, 4) = "0220" Or Mid(txtcodart.Text, 1, 4) = "0219" Then
                '    For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.7\Fichas Tecnicas\PDF FICHAS\PDF FICHAS\ENSAMBLE", FileIO.SearchOption.SearchAllSubDirectories, "" & txtcodart.Text & " *.pdf")
                '        rutaarchivo = archivos
                '    Next
                'End If
                If Mid(txtcodart.Text, 1, 4) = "0101" Then
                    For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.5\Fichas Tecnicas\CENTRALPACK\PDF\FIBRA", FileIO.SearchOption.SearchAllSubDirectories, "" & txtcodart.Text & " *.pdf")
                        rutaarchivo = archivos
                    Next
                    System.Diagnostics.Process.Start(rutaarchivo)
                End If
            Catch ex As Exception
                MsgBox("No se realizó la operación por: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyValue = Keys.F9 Then
            If txtnomsublinea.TextLength > 0 Then
                sBusAlm = "223"
                Dim frm As New FormBUSQUEDA
                gsCode7 = txtsublinea.Text
                frm.ShowDialog()
                If gLinea <> Nothing Then
                    txtcodart.Text = Trim(gLinea)
                    txtnomart.Text = gSubLinea
                    gLinea = Nothing
                    gSubLinea = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                End If
            Else
                sBusAlm = "6"

                Dim frm As New FormBUSQUEDA
                frm.ShowDialog()
                'MsgBox(IsDBNull(gLinea.Length))
                If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
                    txtlinea.Text = gLinea
                    txtsublinea.Text = gSubLinea
                    txtcodart.Text = gArt
                    'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
                    txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
                    'cmbart.SelectedValue = gArt
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                Else
                    gLinea = Nothing
                    gSubLinea = Nothing
                    gArt = Nothing
                End If
            End If

        End If
    End Sub

    Private Sub FormRptFichaArticulo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtcodart_LostFocus(sender As Object, e As EventArgs) Handles txtcodart.LostFocus
        If txtcodart.TextLength = 8 Then
            'txtnomlinea.Text = ARTICULOBL.SelectDescripcion(txtlinea.Text)
            txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
            'If txtnomlinea.TextLength > 0 Then
            '    txtsublinea.Enabled = True
            'Else
            '    txtsublinea.Enabled = False
            'End If
            txtsublinea.Text = Mid(txtcodart.Text, 1, 4)
            txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
            txtlinea.Text = Mid(txtcodart.Text, 1, 2) & "00"
            txtnomlinea.Text = ELTBLINESBL.SelectDescri(txtlinea.Text)
        Else
            txtnomart.Text = ""
        End If
    End Sub

    Private Sub txtlinea_TextChanged(sender As Object, e As EventArgs) Handles txtlinea.TextChanged
        If txtlinea.TextLength = "4" Then
            txtsublinea.Enabled = True
        Else
            'txtsublinea.Enabled = False
            'txtcodart.Enabled = False
            txtcodart.Text = ""
            txtnomart.Text = ""
            txtnomlinea.Text = ""
            txtsublinea.Text = ""
            txtnomsublinea.Text = ""
        End If
    End Sub

    Private Sub txtsublinea_TextChanged(sender As Object, e As EventArgs) Handles txtsublinea.TextChanged
        If txtsublinea.TextLength = "4" Then
            txtcodart.Enabled = True
        Else
            txtcodart.Enabled = False
            txtnomsublinea.Text = ""
            txtcodart.Text = ""
            txtnomart.Text = ""
        End If
    End Sub

    Private Sub txtcodart_TextChanged(sender As Object, e As EventArgs) Handles txtcodart.TextChanged
        If txtcodart.TextLength = "8" Then
            txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
            txtsublinea.Text = Mid(txtcodart.Text, 1, 4)
            txtnomsublinea.Text = ELTBLINESBL.SelectDescri(txtsublinea.Text)
            txtlinea.Text = Mid(txtcodart.Text, 1, 2) & "00"
            txtnomlinea.Text = ELTBLINESBL.SelectDescri(txtlinea.Text)
        Else
            txtnomart.Text = ""
        End If
    End Sub

    Private Sub txtcodart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodart.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtlinea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlinea.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtsublinea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsublinea.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "6"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            txtlinea.Text = gLinea
            txtsublinea.Text = gSubLinea
            txtcodart.Text = gArt
            'Dim dt As DataTable = ARTICULOBL.SelectArt(txtsublinea.Text)
            txtnomart.Text = ARTICULOBL.SelectArt2(txtcodart.Text)
            'cmbart.SelectedValue = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "221"
        Dim frm As New FormBUSQUEDA
        gsCode7 = Mid(txtlinea.Text, 1, 2)
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtsublinea.Text = Trim(gLinea)
            txtnomsublinea.Text = gSubLinea
            txtcodart.Enabled = True
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            'txtcodart.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "222"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing Then
            txtlinea.Text = Trim(gLinea) & "00"
            txtnomlinea.Text = gSubLinea
            txtsublinea.Enabled = True
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            txtsublinea.Enabled = False
        End If
    End Sub
End Class