Imports System.ComponentModel
Imports IT.ELUX.BL
Public Class FormIndiceCostos

    Private primero As Boolean
    Private primero2 As Boolean
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBLINESBL As New ELTBLINESBL
    Private INDICECOSTOSBL As New INDICECOSTOSBL
    Dim mes
    Dim anho
    Dim codigo
    Dim articulo
    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Sub FormIndiceCostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        primero = True
        primero2 = True

        Me.Text = "Indice de Costos por Artículo"
        Dim dt As New DataTable
        dt = ARTICULOBL.SelectDescripcion()
        GetCmb("lin_codigo", "lin_descri", dt, cmbLineas)

        primero = False
        primero2 = False

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

    Private Sub cmbSublineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSublineas.SelectedIndexChanged
        'change subline
        If primero Then Exit Sub
        Dim sCode As String = cmbSublineas.SelectedValue
        Dim dt As New DataTable
        primero = True
        dt = ARTICULOBL.SelectAll(sCode)
        If dt.Rows.Count > 0 Then
            GetCmb("COD", "art_descri", dt, cmbArticulo)
        Else
            MsgBox("La Sublinea no tiene articulos")
            'For i = 0 To cmbart.Items.Count - 1
            cmbArticulo.DataSource = Nothing
            'Next
            'cmbart.Refresh()
        End If
        primero = False
    End Sub

    Private Sub cmbArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArticulo.SelectedIndexChanged
        If primero Then Exit Sub
        txtcodart.Text = cmbArticulo.SelectedValue
    End Sub


    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        codigo = txtcodart.Text
        articulo = cmbArticulo.Text
        If codigo = "" And articulo = "" Then
            MsgBox("Seleccion Articulo")
            Exit Sub
        End If

        anho = Today.ToString("yyyy")
        mes = Today.ToString("MM")

        'Registrar Articulo y Año
        Dim resultado = INDICECOSTOSBL.registrarArticulo(codigo, articulo, anho)
        If resultado = "OK" Then
            registrarIndiceCostos()
        End If

    End Sub

    Private Sub registrarIndiceCostos()
        Dim mesAct
        Dim mesAnt
        Dim resultado = ""

        For i = 1 To Convert.ToInt32(Today.ToString("MM"))
            mesAct = obtenerMesAct(i)
            mesAnt = obtenerMesAnt(i)
            resultado = INDICECOSTOSBL.RegistrarIndiceCostos(i, mesAct, mesAnt, codigo, anho)
        Next
        Dim dtIndice As New DataTable
        dtIndice = INDICECOSTOSBL.ObtenerIndiceCostos(codigo, anho)
        dgvIndiceCostos.DataSource = dtIndice
        For i = 0 To dgvIndiceCostos.Columns.Count - 1
            dgvIndiceCostos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        If resultado = "OK" Then
            Dim rpt As New FormReportes
            ReDim gsRptArgs(2)
            gsRptArgs(0) = codigo
            gsRptArgs(1) = anho
            gsRptArgs(2) = "101"
            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\SP_REPORTE_INDCOSTOS.rpt"
            'gsPathRpt = "C:\Users\sistemapc\Desktop\SP_REPORTE_INDCOSTOS.rpt"
            gsRptPath = gsPathRpt
            rpt.Show()
        Else
            MsgBox("ERROR")
        End If
    End Sub

    Private Function obtenerMesAct(ByVal i As Int16) As String
        Dim mes = ""
        Select Case i
            Case 1
                mes = "MES01"
            Case 2
                mes = "MES02"
            Case 3
                mes = "MES03"
            Case 4
                mes = "MES04"
            Case 5
                mes = "MES05"
            Case 6
                mes = "MES06"
            Case 7
                mes = "MES07"
            Case 8
                mes = "MES08"
            Case 9
                mes = "MES09"
            Case 10
                mes = "MES10"
            Case 11
                mes = "MES11"
            Case 12
                mes = "MES12"
        End Select

        Return mes
    End Function

    Private Function obtenerMesAnt(ByVal i As Int16) As String
        Dim mes = ""
        Select Case i
            Case 1
                mes = ""
            Case 2
                mes = "MES01"
            Case 3
                mes = "MES02"
            Case 4
                mes = "MES03"
            Case 5
                mes = "MES04"
            Case 6
                mes = "MES05"
            Case 7
                mes = "MES06"
            Case 8
                mes = "MES07"
            Case 9
                mes = "MES08"
            Case 10
                mes = "MES09"
            Case 11
                mes = "MES10"
            Case 12
                mes = "MES11"
        End Select

        Return mes
    End Function



    Private Sub FormIndiceCostos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        sBusAlm = "3"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        If gLinea <> Nothing And gSubLinea <> Nothing And gArt <> Nothing Then
            cmbLineas.SelectedValue = gLinea
            cmbSublineas.SelectedValue = gSubLinea
            cmbArticulo.SelectedValue = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub txtcodart_Validated(sender As Object, e As EventArgs) Handles txtcodart.Validated
        If primero2 Then Exit Sub
        'buscar articulo

        cmbLineas.SelectedValue = Mid(txtcodart.Text, 1, 2) + "00"

        If cmbLineas.SelectedValue = "" Then
            Exit Sub
        End If

        cmbSublineas.SelectedValue = Mid(txtcodart.Text, 1, 4)

        If cmbSublineas.SelectedValue = "" Then
            Exit Sub
        End If

        cmbArticulo.SelectedValue = txtcodart.Text
        ' cmbLineas_SelectedIndexChanged(Nothing, Nothing)
        gsCode = gsCode
        '
        'cmbSublineas_SelectedIndexChanged(Nothing, Nothing)

    End Sub
End Class