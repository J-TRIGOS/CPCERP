Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormDetMantArea
    Private gpCaption As String
    Private ELTBAREABL As New ELTBAREABL
    Private ELTBREAPBL As New ELTBREAPBL
    Private ARTICULOBL As New ARTICULOBL

    Private Function OkData() As Boolean
        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If
        'Manda los parameteros a los campos correspondientes del catalogo
        Dim ELTBAREABE As New ELTBAREABE
        ELTBAREABE.cod = RTrim(txtcod.Text)
        ELTBAREABE.nom = RTrim(txtdescripcion.Text)
        ELTBAREABE.situacion = IIf(cmbestado.SelectedIndex = 0, "H", "A")
        ELTBAREABE.cco_cod = gsCode6

        'Recibe los parametros de la caracteristica y arma el catalogo
        'Dim ELTBREAPBE As New ELTBREAPBE
        'ELTBREAPBE.COD_AREA = RTrim(txtcod.Text)

        'gsError2 = ELTBREAPBL.SaveRow(ELTBREAPBE, flagAccion, dgvCaracteristica, txtcod.Text)
        'Next
        Dim dgv As New DataGridView
        gsError = ELTBAREABL.SaveRow(ELTBAREABE, gsCode7, dgv)
        If gsError = "OK" Then

            'MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError + " " + gsError2
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub FormDetMantArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gsCode7 = "N" Then
            cmbestado.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ELTBAREABL.CodExiste(txtcod.Text, gsCode6) > 0 Then
            MsgBox("Esta Linea ya esta realacionada al Centro de Costo" + " " + gsCode6)
            Exit Sub
        End If
        SaveData()
    End Sub

    Private Sub txtcod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "242"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing Then
                txtcod.Text = gLinea
                txtdescripcion.Text = gSubLinea
                gLinea = Nothing
                gSubLinea = Nothing
            Else
                gLinea = Nothing
                gSubLinea = Nothing
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sBusAlm = "242"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcod.Text = gLinea
            txtdescripcion.Text = gSubLinea
            gLinea = Nothing
            gSubLinea = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
        End If
    End Sub

    Private Sub txtcod_LostFocus(sender As Object, e As EventArgs) Handles txtcod.LostFocus
        If txtcod.TextLength = 4 Then
            txtdescripcion.Text = ELTBAREABL.SelNomLin(txtcod.Text)
        Else
            txtdescripcion.Text = ""
        End If
    End Sub
End Class