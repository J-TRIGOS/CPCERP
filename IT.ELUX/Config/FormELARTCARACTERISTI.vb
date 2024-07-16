Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Imports System.ComponentModel

Public Class FormELARTCARACTERISTI

    Private ART_UPDATEBL As New ART_UPDATEBL

    Private Sub FormELARTCARACTERISTI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'dgvdatos.Rows.Clear()
        'dgvdatos.DataSource = Nothing

        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                habilitar(True)
            Case 1
                flagAccion = "M"
                habilitar(False)
                GetData(gsCode)
        End Select
    End Sub
    Private Sub habilitar(ByVal F As Boolean)
        'txtcodart.Enabled = F
        'lbl2.Visible = Not F
        'btnbuscar.Enabled = F
        'cmbturno.Enabled = F
    End Sub
    Private Sub GetData(ByVal gsCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ART_UPDATEBL.SelectRow(gsCode)
        For Each Registro In dtUsuario.Rows

            txtcodart.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            lblart.Text = IIf(IsDBNull(Registro("ART_DESCRI")), "", Registro("ART_DESCRI"))
            txtdiametro.Text = IIf(IsDBNull(Registro("DIAMETRO")), "", Registro("DIAMETRO"))
            txtcolor.Text = IIf(IsDBNull(Registro("COLOR")), "", Registro("COLOR"))
            txtcalidad.Text = IIf(IsDBNull(Registro("CALIDAD")), "", Registro("CALIDAD"))
            txtcantidad.Text = IIf(IsDBNull(Registro("CANTIDAD")), "", Registro("CANTIDAD"))
            txtcategoria.Text = IIf(IsDBNull(Registro("CATA")), "", Registro("CATA"))
            'cmbaf.SelectedItem = IIf(IsDBNull(Registro("CATA1")), "", Registro("CATA1"))
            If IIf(IsDBNull(Registro("CATA1")), "", Registro("CATA1")) = "A" Then
                cmbaf.SelectedItem = "ANILLO"
            Else
                cmbaf.SelectedItem = "FULL"
            End If
        Next
    End Sub
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ART_UPDATEBE As New ART_UPDATEBE
                ART_UPDATEBE.art_cod = txtcodart.Text
                ART_UPDATEBE.diametro = txtdiametro.Text
                ART_UPDATEBE.color = txtcolor.Text
                ART_UPDATEBE.calidad = txtcalidad.Text
                ART_UPDATEBE.cantidad = txtcantidad.Text
                ART_UPDATEBE.cata = txtcategoria.Text
                ART_UPDATEBE.cata1 = cmbaf.SelectedItem.ToString.Substring(0, 1)
                ART_UPDATEBE.detalle = txtdetalle.Text

                gsError = ART_UPDATEBL.SaveRow(ART_UPDATEBE, flagAccion)
                If gsError = "OK" Then
                    MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
                    Dispose()
                Else
                    FormMain.LblError.Text = gsError
                    MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub
    Private Function OkData() As Boolean
        If txtcodart.Text = "" Then
            MsgBox("Ingrese el Articulo", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function
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
            Case "delete"
                'DeleteData()
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub
    Private Sub txtdiametro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdiametro.KeyDown, txtcolor.KeyDown, txtcalidad.KeyDown, txtcantidad.KeyDown, txtcategoria.KeyDown
        gLinea = DirectCast(sender, TextBox).Tag.ToString()

        If e.KeyValue = Keys.F9 Then
            sBusAlm = "93"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gSubLinea <> Nothing) Then

                Select Case gLinea
                    Case "di"
                        txtdiametro.Text = gSubLinea
                    Case "co"
                        txtcolor.Text = gSubLinea
                    Case "ca"
                        txtcantidad.Text = gSubLinea
                    Case "cal"
                        txtcalidad.Text = gSubLinea
                    Case "cat"
                        txtcategoria.Text = gSubLinea
                End Select

            End If

            e.Handled = True
        End If

        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub txtcodart_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodart.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "94"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcodart.Text = gLinea
                lblart.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
    End Sub

    Private Sub FormELARTCARACTERISTI_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class