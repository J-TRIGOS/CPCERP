Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormRPTSolOrden
    Private ELTBORDENPROGRAMABL As New ELTBORDENPROGRAMABL
    Public tipo As String = Nothing
    Public ser As String = ""
    Public nro As String = ""
    Public cod_art As String = ""
    Public nom_art As String = ""
    Public nro_op As String = ""
    Private dtphoragene As Date = Date.Now

    Private Sub FormRPTSolOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable
        dt = ELTBORDENPROGRAMABL.getListcmb1
        GetCmb("cod", "nombre", dt, cmbmedida2)
        dt = ELTBORDENPROGRAMABL.SelectNro("", ser, nro, Mid(cod_art, 1, 4))
        For Each row As DataRow In dt.Rows
            tipo = IIf(IsDBNull(row("T_DOC_REF")), "", row("T_DOC_REF"))

            If tipo = "CPENSI" Then
                cmbTipo.SelectedIndex = 0
            ElseIf tipo = "5GLN" Then
                cmbTipo.SelectedIndex = 1
            ElseIf tipo = "CPENSP" Then
                cmbTipo.SelectedIndex = 2
            End If

            FORMAT.Text = IIf(IsDBNull(row("FORMATO")), "", row("FORMATO"))
            cmbmedida2.SelectedValue = IIf(IsDBNull(row("FORMATO")), "", row("FORMATO"))

            ESP_CUE.Text = IIf(IsDBNull(row("ESP_CUE")), "", row("ESP_CUE"))

            CF_1.Value = IIf(IsDBNull(row("ESP_FON")), "", row("ESP_FON"))
            CF_2.Value = IIf(IsDBNull(row("ALT_CIE_F_MN")), "", row("ALT_CIE_F_MN"))
            CF_3.Value = IIf(IsDBNull(row("ALT_CIE_F_MX")), "", row("ALT_CIE_F_MX"))
            CF_4.Value = IIf(IsDBNull(row("LON_CUE_F_MN")), "", row("LON_CUE_F_MN"))
            CF_5.Value = IIf(IsDBNull(row("LON_CUE_F_MX")), "", row("LON_CUE_F_MX"))
            CF_6.Value = IIf(IsDBNull(row("LON_FON_MIN")), "", row("LON_FON_MIN"))
            CF_7.Value = IIf(IsDBNull(row("LON_FON_MAX")), "", row("LON_FON_MAX"))

            CAC_1.Value = IIf(IsDBNull(row("ESP_ANI")), "", row("ESP_ANI"))
            CAC_2.Value = IIf(IsDBNull(row("ALT_CIE_A_MIN")), "", row("ALT_CIE_A_MIN"))
            CAC_3.Value = IIf(IsDBNull(row("ALT_CIE_A_MAX")), "", row("ALT_CIE_A_MAX"))
            CAC_4.Value = IIf(IsDBNull(row("LON_CUE_A_MIN")), "", row("LON_CUE_A_MIN"))
            CAC_5.Value = IIf(IsDBNull(row("LON_CUE_A_MAX")), "", row("LON_CUE_A_MAX"))
            CAC_6.Value = IIf(IsDBNull(row("LON_ANI_MIN")), "", row("LON_ANI_MIN"))
            CAC_7.Value = IIf(IsDBNull(row("LON_ANI_MAX")), "", row("LON_ANI_MAX"))

            PMA_1.Value = IIf(IsDBNull(row("ALT_TER_MIN")), "", row("ALT_TER_MIN"))
            PMA_2.Value = IIf(IsDBNull(row("ALT_TER_MAX")), "", row("ALT_TER_MAX"))
            PMA_3.Value = IIf(IsDBNull(row("ALT_ORE_MIN")), "", row("ALT_ORE_MIN"))
            PMA_4.Value = IIf(IsDBNull(row("ALT_ORE_MAX")), "", row("ALT_ORE_MAX"))
            PMA_5.Value = IIf(IsDBNull(row("ENV_TER_MIN")), "", row("ENV_TER_MIN"))
            PMA_6.Value = IIf(IsDBNull(row("ENV_TER_MAX")), "", row("ENV_TER_MAX"))
            PMA_7.Value = IIf(IsDBNull(row("CUE_TAP_MIN")), "", row("CUE_TAP_MIN"))
            PMA_8.Value = IIf(IsDBNull(row("CUE_TAP_MAX")), "", row("CUE_TAP_MAX"))

        Next
        flagAccion = "N"
        If tipo <> Nothing Then
            flagAccion = "M"
            cmbmedida2.Enabled = False
        ElseIf Mid(cod_art, 1, 4) = "0217" Then
            tipo = "CPENSI"
            cmbTipo.SelectedIndex = 0
            FORMAT.Enabled = True
        ElseIf Mid(cod_art, 1, 4) = "0219" Then
            tipo = "5GLN"
            cmbTipo.SelectedIndex = 1
            FORMAT.Enabled = True
        ElseIf Mid(cod_art, 1, 4) = "0216" Then
            tipo = "CPENSP"
            cmbTipo.SelectedIndex = 2
            FORMAT.Enabled = True
        Else
            cmbTipo.Enabled = True
            FORMAT.Enabled = True

        End If

        Label4.Text = nro_op

    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub

    Private Sub FormRPTSolOrden_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub tsbForm_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()

        Select Case sFunc
            Case "save"
                SaveData()
                Exit Sub
            Case "exit"
                Dispose()
                Exit Sub
            Case "salir"
                Dispose()
                Exit Sub
            Case "Print"
                If cmbTipo.SelectedIndex = 0 Then
                    ReDim gsRptArgs(3)
                    gsRptArgs(0) = tipo
                    gsRptArgs(1) = ser
                    gsRptArgs(2) = nro
                    gsRptArgs(3) = Label4.Text
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_PRODUCCION_INDUSTRIALES.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                    Exit Sub
                ElseIf cmbTipo.SelectedIndex = 1 Then
                    ReDim gsRptArgs(3)
                    gsRptArgs(0) = tipo
                    gsRptArgs(1) = ser
                    gsRptArgs(2) = nro
                    gsRptArgs(3) = Label4.Text
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_PRODUCCION_05GALONES.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                    Exit Sub
                ElseIf cmbTipo.SelectedIndex = 2 Then
                    ReDim gsRptArgs(3)
                    gsRptArgs(0) = tipo
                    gsRptArgs(1) = ser
                    gsRptArgs(2) = nro
                    gsRptArgs(3) = Label4.Text
                    gsPathRpt = gsIpserver & "sistema\E.LUX\REPORTES\02\RPT02_SP_PRODUCCION_INDUSTRIALES.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                    Exit Sub
                End If

        End Select
    End Sub

    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        End If
        If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        Dim ELTBORDENPROGRAMABE As New ELTBORDENPROGRAMABE

        If cmbTipo.SelectedIndex = 0 Then
            ELTBORDENPROGRAMABE.T_DOC_REF = "CPENSI"
            tipo = "CPENSI"
        ElseIf cmbTipo.SelectedIndex = 1 Then
            ELTBORDENPROGRAMABE.T_DOC_REF = "5GLN"
            tipo = "5GLN"
        ElseIf cmbTipo.SelectedIndex = 2 Then
            ELTBORDENPROGRAMABE.T_DOC_REF = "CPENSP"
            tipo = "CPENSP"
        End If

        ELTBORDENPROGRAMABE.SER_DOC_REF = ser
        ELTBORDENPROGRAMABE.NRO_DOC_REF = nro
        If cmbmedida2.Visible = True Then
            ELTBORDENPROGRAMABE.FORMATO = cmbmedida2.SelectedValue
        Else
            ELTBORDENPROGRAMABE.FORMATO = FORMAT.Text
        End If
        ELTBORDENPROGRAMABE.ART_COD = cod_art
        ELTBORDENPROGRAMABE.DESCRI = nom_art

        ELTBORDENPROGRAMABE.ESP_CUE = ESP_CUE.Value

        ELTBORDENPROGRAMABE.ESP_FON = CF_1.Value
        ELTBORDENPROGRAMABE.ALT_CIE_F_MN = CF_2.Value
        ELTBORDENPROGRAMABE.ALT_CIE_F_MX = CF_3.Value
        ELTBORDENPROGRAMABE.LON_CUE_F_MN = CF_4.Value
        ELTBORDENPROGRAMABE.LON_CUE_F_MX = CF_5.Value
        ELTBORDENPROGRAMABE.LON_FON_MIN = CF_6.Value
        ELTBORDENPROGRAMABE.LON_FON_MAX = CF_7.Value

        ELTBORDENPROGRAMABE.ESP_ANI = CAC_1.Value
        ELTBORDENPROGRAMABE.ALT_CIE_A_MIN = CAC_2.Value
        ELTBORDENPROGRAMABE.ALT_CIE_A_MAX = CAC_3.Value
        ELTBORDENPROGRAMABE.LON_CUE_A_MIN = CAC_4.Value
        ELTBORDENPROGRAMABE.LON_CUE_A_MAX = CAC_5.Value
        ELTBORDENPROGRAMABE.LON_ANI_MIN = CAC_6.Value
        ELTBORDENPROGRAMABE.LON_ANI_MAX = CAC_7.Value

        ELTBORDENPROGRAMABE.ALT_TER_MIN = PMA_1.Value
        ELTBORDENPROGRAMABE.ALT_TER_MAX = PMA_2.Value
        ELTBORDENPROGRAMABE.ALT_ORE_MIN = PMA_3.Value
        ELTBORDENPROGRAMABE.ALT_ORE_MAX = PMA_4.Value
        ELTBORDENPROGRAMABE.ENV_TER_MIN = PMA_5.Value
        ELTBORDENPROGRAMABE.ENV_TER_MAX = PMA_6.Value
        ELTBORDENPROGRAMABE.CUE_TAP_MIN = PMA_7.Value
        ELTBORDENPROGRAMABE.CUE_TAP_MAX = PMA_8.Value

        ELTBORDENPROGRAMABE.FEC_GENE = dtphoragene

        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELTBORDENPROGRAMABE.EST = "H"

        ELMVLOGSBE.log_codusu = gsCodUsr

        'If sOp = "0" Then


        gsError = ELTBORDENPROGRAMABL.SaveRow(ELTBORDENPROGRAMABE, ELMVLOGSBE, flagAccion)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            flagAccion = "M"
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If
        'ElseIf sOp = "1" Then

        'End If

    End Sub
    Private Function OkData() As Boolean
        If cmbTipo.Enabled = True Then
            If cmbTipo.SelectedIndex = -1 Then
                MsgBox("Ingrese Tipo de Orden", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If


        'If FORMAT.Text = Nothing Then
        '    MsgBox("Ingrese Formato", MsgBoxStyle.Exclamation)
        '    Return False
        'End If
        Return True
    End Function

    Private Sub FORMAT_TextChanged(sender As Object, e As EventArgs) Handles FORMAT.TextChanged
        If flagAccion = "N" Then
            Dim dt As DataTable
            dt = ELTBORDENPROGRAMABL.SelectSearch(FORMAT.Text)
            For Each row As DataRow In dt.Rows


                ESP_CUE.Text = IIf(IsDBNull(row("ESP_CUE")), "", row("ESP_CUE"))

                CF_1.Value = IIf(IsDBNull(row("ESP_FON")), "", row("ESP_FON"))
                CF_2.Value = IIf(IsDBNull(row("ALT_CIE_F_MN")), "", row("ALT_CIE_F_MN"))
                CF_3.Value = IIf(IsDBNull(row("ALT_CIE_F_MX")), "", row("ALT_CIE_F_MX"))
                CF_4.Value = IIf(IsDBNull(row("LON_CUE_F_MN")), "", row("LON_CUE_F_MN"))
                CF_5.Value = IIf(IsDBNull(row("LON_CUE_F_MX")), "", row("LON_CUE_F_MX"))
                CF_6.Value = IIf(IsDBNull(row("LON_FON_MIN")), "", row("LON_FON_MIN"))
                CF_7.Value = IIf(IsDBNull(row("LON_FON_MAX")), "", row("LON_FON_MAX"))

                CAC_1.Value = IIf(IsDBNull(row("ESP_ANI")), "", row("ESP_ANI"))
                CAC_2.Value = IIf(IsDBNull(row("ALT_CIE_A_MIN")), "", row("ALT_CIE_A_MIN"))
                CAC_3.Value = IIf(IsDBNull(row("ALT_CIE_A_MAX")), "", row("ALT_CIE_A_MAX"))
                CAC_4.Value = IIf(IsDBNull(row("LON_CUE_A_MIN")), "", row("LON_CUE_A_MIN"))
                CAC_5.Value = IIf(IsDBNull(row("LON_CUE_A_MAX")), "", row("LON_CUE_A_MAX"))
                CAC_6.Value = IIf(IsDBNull(row("LON_ANI_MIN")), "", row("LON_ANI_MIN"))
                CAC_7.Value = IIf(IsDBNull(row("LON_ANI_MAX")), "", row("LON_ANI_MAX"))

                PMA_1.Value = IIf(IsDBNull(row("ALT_TER_MIN")), "", row("ALT_TER_MIN"))
                PMA_2.Value = IIf(IsDBNull(row("ALT_TER_MAX")), "", row("ALT_TER_MAX"))
                PMA_3.Value = IIf(IsDBNull(row("ALT_ORE_MIN")), "", row("ALT_ORE_MIN"))
                PMA_4.Value = IIf(IsDBNull(row("ALT_ORE_MAX")), "", row("ALT_ORE_MAX"))
                PMA_5.Value = IIf(IsDBNull(row("ENV_TER_MIN")), "", row("ENV_TER_MIN"))
                PMA_6.Value = IIf(IsDBNull(row("ENV_TER_MAX")), "", row("ENV_TER_MAX"))
                PMA_7.Value = IIf(IsDBNull(row("CUE_TAP_MIN")), "", row("CUE_TAP_MIN"))
                PMA_8.Value = IIf(IsDBNull(row("CUE_TAP_MAX")), "", row("CUE_TAP_MAX"))

            Next
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            cmbmedida2.Visible = False

        Else
            cmbmedida2.Visible = True
            cmbmedida2.SelectedIndex = -1
        End If
    End Sub
End Class