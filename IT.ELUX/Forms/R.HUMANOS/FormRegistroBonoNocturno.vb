Imports IT.ELUX.BL

Public Class FormRegistroBonoNocturno

    Dim BONONOCTURNOBL As New BONONOCTURNOBL

    Private Sub FormRegistroBonoNocturno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Registro Bono Nocturno"
    End Sub

    Private Sub txt_prdo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_prdo.KeyDown
        Dim dtBono As New DataTable
        Dim mes As String = "00"
        Dim anho As String = "2021"
        Dim mesA As String = "00"
        Dim anhoA As String = "2021"
        Dim sumSueldo = 0.0

        If e.KeyValue = Keys.F9 Then
            sBusAlm = "CRONOGRAMARRHH"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If gLinea <> Nothing And gSubLinea <> Nothing And gLinea2 <> Nothing And gLinea3 <> Nothing Then
                txt_prdo.Text = gLinea
                txt_nomprdo.Text = gLinea2
                datFechaIni.Value = gLinea3
                datFechaFin.Value = gSubLinea
            Else
                gLinea = Nothing
                gSubLinea = Nothing
                gLinea2 = Nothing
            End If
            e.Handled = True
        End If
        If txt_nomprdo.Text.Length >= 3 Then
            If Not txt_prdo.Text = "" Then
                dtBono = BONONOCTURNOBL.ListadoBono(txt_prdo.Text)
                If dtBono.Rows.Count > 0 Then
                    dgv_nocturno.DataSource = dtBono
                    For i = 0 To dgv_nocturno.Rows.Count - 1
                        sumSueldo = sumSueldo + dgv_nocturno.Rows(i).Cells("BONO").Value
                    Next
                    lbl_bono.Text = "S/ " & sumSueldo
                    For i = 0 To dgv_nocturno.Columns.Count - 1
                        dgv_nocturno.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btn_procesar_Click(sender As Object, e As EventArgs) Handles btn_procesar.Click
        Dim sumSueldo = 0.0
        If txt_prdo.Text = "" Then
            MsgBox("Selecciones Periodo Para Procesar")
            Exit Sub
        End If

        dgv_nocturno.DataSource = ""
        dgv_nocturno.Refresh()

        Dim DTBonoNocturno As New DataTable
        flagAccion = "N"
        Dim prdo = txt_prdo.Text
        Dim fecIni = datFechaIni.Value.ToString("dd/MM/yyyy")
        Dim fecfin = datFechaFin.Value.ToString("dd/MM/yyyy")

        DTBonoNocturno = BONONOCTURNOBL.BuscarDatosBono(prdo, fecIni, fecfin)
        dgv_nocturno.DataSource = DTBonoNocturno

        For i = 0 To dgv_nocturno.Columns.Count - 1
            dgv_nocturno.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        Try
            For i = 0 To dgv_nocturno.Rows.Count - 1
                sumSueldo = sumSueldo + dgv_nocturno.Rows(i).Cells("BONO").Value
            Next
            lbl_bono.Text = "S/ " & sumSueldo
        Catch ex As Exception
            Exit Sub
        End Try


    End Sub

    Private Sub FormRegistroBonoNocturno_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class