Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormProcesoCostos

    Dim anho = 0
    Dim ARTICULOBL As New ARTICULOBL
    Dim COSTEOBL As New COSTEOBL
    Dim primero As Boolean
    Dim primero2 As Boolean

    Private Sub FormProcesoCostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        primero = True
        primero2 = True
        Me.Text = "COSTEO DE OP"
        getCmbAño(cmbAnho)
        getCmbMes(cmbMes)
        getCmbMes(cmbMes2)
        Select Case Today.Year
            Case 2019
                cmbAnho.SelectedIndex = 0
            Case 2020
                cmbAnho.SelectedIndex = 1
            Case 2021
                cmbAnho.SelectedIndex = 2
            Case 2022
                cmbAnho.SelectedIndex = 3
            Case 2023
                cmbAnho.SelectedIndex = 4
            Case 2024
                cmbAnho.SelectedIndex = 5
            Case 2025
                cmbAnho.SelectedIndex = 5
        End Select
        'cmbMes.SelectedIndex = Today.Month - 1
        cmbMes.SelectedIndex = 0
        cmbMes2.SelectedIndex = 0
        anho = cmbAnho.SelectedItem
        Dim dt As New DataTable
        dt = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)

        Dim dtCC As New DataTable
        dtCC = ARTICULOBL.ListadoCC()
        GetCmb("COD", "NOM", dtCC, cmbCentroCosto)

        primero = False
        primero2 = False
    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Function getCmbAño(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("2019")
        cmb.Items.Add("2020")
        cmb.Items.Add("2021")
        cmb.Items.Add("2022")
        cmb.Items.Add("2023")
        cmb.Items.Add("2024")
        cmb.Items.Add("2025")
    End Function

    Private Function getCmbMes(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("Enero")
        cmb.Items.Add("Febrero")
        cmb.Items.Add("Marzo")
        cmb.Items.Add("Abril")
        cmb.Items.Add("Mayo")
        cmb.Items.Add("Junio")
        cmb.Items.Add("Julio")
        cmb.Items.Add("Agosto")
        cmb.Items.Add("Septiembre")
        cmb.Items.Add("Octubre")
        cmb.Items.Add("Noviembre")
        cmb.Items.Add("Diciembre")
    End Function

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ok = MsgBox("Desea Procesar el Costeo de Articulos?", MsgBoxStyle.YesNo)
        If ok = 7 Then
            Exit Sub
        End If
        Dim resp = ""
        Dim mes = ""
        Dim prdo = ""
        Dim centroCod = ""
        'Dim dtBorrado As New DataTable
        'dtBorrado = COSTEOBL.LimpiarCosteo(mes, cmbAnho.Text)
        If chkTodos.Checked = True Then

            For j = 0 To 11
                Select Case j
                    Case 0
                        centroCod = "110"
                    Case 1
                        centroCod = "109"
                    Case 2
                        centroCod = "110"
                    Case 3
                        centroCod = "105"
                    Case 4
                        centroCod = "106"
                    Case 5
                        centroCod = "107"
                    Case 6
                        centroCod = "108"
                    Case 7
                        centroCod = "122"
                    Case 8
                        centroCod = "101"
                    Case 9
                        centroCod = "102"
                    Case 10
                        centroCod = "103"
                    Case 11
                        centroCod = "104"
                End Select
                For i = 0 To cmbMes2.SelectedIndex
                    mes = obtenerMesAct(i)
                    Dim dtPeriodo As New DataTable

                    dtPeriodo = COSTEOBL.ObtenerPeriodo(mes, cmbAnho.Text)
                    If dtPeriodo.Rows.Count = 0 Then
                        Exit Sub
                    End If
                    prdo = dtPeriodo.Rows(0).ItemArray(0)
                    resp = COSTEOBL.ProcesarCosteo(centroCod, mes, cmbAnho.Text, prdo)
                    If Not resp = "OK" Then
                        MsgBox("Error al procesar Costeo")
                    End If
                Next
            Next
            If resp = "OK" Then
                MsgBox("Proceso Completado")
            End If

            ReDim gsRptArgs(4)
            gsRptArgs(0) = ""
            gsRptArgs(1) = obtenerMesAct(cmbMes.SelectedIndex)
            gsRptArgs(2) = obtenerMesAct(cmbMes2.SelectedIndex)
            gsRptArgs(3) = cmbAnho.Text
            If cmbSublineas.SelectedIndex = -1 Then
                gsRptArgs(4) = ""
            Else
                gsRptArgs(4) = cmbSublineas.Text.Substring(0, 4)
            End If

            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_COSTEO_X_OP.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()


        Else
            For i = 0 To cmbMes2.SelectedIndex
                mes = obtenerMesAct(i)
                Dim dtPeriodo As New DataTable
                dtPeriodo = COSTEOBL.ObtenerPeriodo(mes, cmbAnho.Text)
                If dtPeriodo.Rows.Count = 0 Then
                    Exit Sub
                End If
                prdo = dtPeriodo.Rows(0).ItemArray(0)
                centroCod = cmbCentroCosto.Text.Substring(0, 3)
                resp = COSTEOBL.ProcesarCosteo(centroCod, mes, cmbAnho.Text, prdo)
                If Not resp = "OK" Then
                    MsgBox("Error al procesar Costeo")
                End If
            Next
            If resp = "OK" Then
                MsgBox("Proceso Complatado")
            End If

            ReDim gsRptArgs(4)
            gsRptArgs(0) = ""
            gsRptArgs(1) = obtenerMesAct(cmbMes.SelectedIndex)
            gsRptArgs(2) = obtenerMesAct(cmbMes2.SelectedIndex)
            gsRptArgs(3) = cmbAnho.Text
            If cmbSublineas.SelectedIndex = -1 Then
                gsRptArgs(4) = ""
            Else
                gsRptArgs(4) = cmbSublineas.Text.Substring(0, 4)
            End If

            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_COSTEO_X_OP.rpt"
            gsRptPath = gsPathRpt
            FormReportes.ShowDialog()
        End If

    End Sub

    Private Sub cmbLineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLineas.SelectedIndexChanged
        'change line
        If primero Then Exit Sub
        '    primero = True
        Dim sCode As String = Mid(cmbLineas.SelectedValue, 1, 2)
        Dim dt As New DataTable
        primero = True
        dt = ARTICULOBL.SelectDescripcion1(sCode)
        GetCmb("lin_codigo", "lin_descri", dt, cmbSublineas)
        primero = False
    End Sub

    Private Function obtenerMesAct(ByVal index As Integer) As String
        Dim mes = ""
        Select Case index
            Case 0
                mes = "01"
            Case 1
                mes = "02"
            Case 2
                mes = "03"
            Case 3
                mes = "04"
            Case 4
                mes = "05"
            Case 5
                mes = "06"
            Case 6
                mes = "07"
            Case 7
                mes = "08"
            Case 8
                mes = "09"
            Case 9
                mes = "10"
            Case 10
                mes = "11"
            Case 11
                mes = "12"
        End Select
        Return mes
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ReDim gsRptArgs(4)
        gsRptArgs(0) = ""
        gsRptArgs(1) = obtenerMesAct(cmbMes.SelectedIndex)
        gsRptArgs(2) = obtenerMesAct(cmbMes2.SelectedIndex)
        gsRptArgs(3) = cmbAnho.Text
        If cmbSublineas.SelectedIndex = -1 Then
            gsRptArgs(4) = ""
        Else
            gsRptArgs(4) = cmbSublineas.Text.Substring(0, 4)
        End If

        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_COSTEO_X_OP.rpt"
        gsRptPath = gsPathRpt
        FormReportes.ShowDialog()

    End Sub

    Private Sub FormProcesoCostos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub cmbCentroCosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCentroCosto.SelectedIndexChanged
        cmbLineas.SelectedIndex = -1
        cmbSublineas.SelectedIndex = -1
    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked = True Then
            cmbCentroCosto.Enabled = False
        Else
            cmbCentroCosto.Enabled = True
        End If
    End Sub
End Class