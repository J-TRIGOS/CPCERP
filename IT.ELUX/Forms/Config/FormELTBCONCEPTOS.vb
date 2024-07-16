
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System.Net
Public Class FormELTBCONCEPTOS
    Private ELTBREGISTRO_NROBL As New ELTBREGISTRO_NROBL
    Private ELCONCEPTOSBL As New ELTBCONCEPTOSBL
    Private flagAccion As String = ""
    Private contador As Integer = "0"
    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Public boton As String

    Private Sub FormELCONCEPTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        'Cargar los combos

        bPrimero = False
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                Limpiar()

            Case 1
                flagAccion = "M"
                GetData(gsCode)

        End Select
    End Sub

    Private Sub GetData(ByVal gsCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELCONCEPTOSBL.SelectRow(gsCode)
        For Each Registro In dtUsuario.Rows

            lblcod.Text = gsCode
            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            txtcpto_cod.Text = IIf(IsDBNull(Registro("CPTO_COD")), "", Registro("CPTO_COD"))
            lbl_cod_cpto.Text = IIf(IsDBNull(Registro("NOMBRE")), "", Registro("NOMBRE"))
            Dim A As String = IIf(IsDBNull(Registro("T_PER_COD")), "", Registro("T_PER_COD"))
            If A = "" Then
                cmb_t_per_cod.SelectedIndex = -1
            Else
                cmb_t_per_cod.SelectedIndex = A - 1
            End If
            txtporc.Text = IIf(IsDBNull(Registro("PORC")), "", Registro("PORC"))
            txtmonto.Text = IIf(IsDBNull(Registro("MONTO")), "", Registro("MONTO"))
            txtcta_adm.Text = IIf(IsDBNull(Registro("CTA_ADM")), "", Registro("CTA_ADM"))
            txtcta_plan.Text = IIf(IsDBNull(Registro("CTA_PLAN")), "", Registro("CTA_PLAN"))
            txtcta_ven.Text = IIf(IsDBNull(Registro("CTA_VEN")), "", Registro("CTA_VEN"))
            txtcta_splan.Text = IIf(IsDBNull(Registro("CTA_SPLAN")), "", Registro("CTA_SPLAN"))
            txtcta_hab.Text = IIf(IsDBNull(Registro("CTA_HAB")), "", Registro("CTA_HAB"))
            lblcta_adm.Text = IIf(IsDBNull(Registro("DES1")), "", Registro("DES1"))
            lblcta_plan.Text = IIf(IsDBNull(Registro("DES2")), "", Registro("DES2"))
            lblcta_ven.Text = IIf(IsDBNull(Registro("DES3")), "", Registro("DES3"))
            lblcta_splan.Text = IIf(IsDBNull(Registro("DES4")), "", Registro("DES4"))
            lblcta_hab.Text = IIf(IsDBNull(Registro("DES5")), "", Registro("DES5"))
            txtt_cpto.Text = IIf(IsDBNull(Registro("T_CPTO")), "", Registro("T_CPTO"))
            lbltipo.Text = IIf(IsDBNull(Registro("TIPO")), "", Registro("TIPO"))
            txtt_impres.Text = IIf(IsDBNull(Registro("T_IMPRES")), "", Registro("T_IMPRES"))
            cmbsigno.SelectedItem = IIf(IsDBNull(Registro("SIGNO")), "", Registro("SIGNO"))
            cmbsigno1.SelectedItem = IIf(IsDBNull(Registro("SIGNO1")), "", Registro("SIGNO1"))
        Next
    End Sub
    Private Sub Limpiar()
        lblcod.Text = ELCONCEPTOSBL.SelectMaxTransp().PadLeft(3, "0")
        txtnom.Text = ""
        txtcpto_cod.Text = ""
        lbl_cod_cpto.Text = ""
        cmb_t_per_cod.SelectedIndex = -1
        txtporc.Text = ""
        txtmonto.Text = ""
        txtcta_adm.Text = ""
        lblcta_adm.Text = ""
        txtcta_plan.Text = ""
        lblcta_plan.Text = ""
        txtcta_ven.Text = ""
        lblcta_ven.Text = ""
        txtcta_splan.Text = ""
        lblcta_splan.Text = ""
        txtcta_hab.Text = ""
        lblcta_hab.Text = ""
        txtt_cpto.Text = ""
        lbltipo.Text = ""
        txtt_impres.Text = ""
        cmbsigno.SelectedIndex = -1
        cmbsigno1.SelectedIndex = -1
    End Sub

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
    End Function

    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELTBCONCEPTOSBE As New ELTBCONCEPTOSBE

                ELTBCONCEPTOSBE.cod = lblcod.Text
                ELTBCONCEPTOSBE.nom = txtnom.Text
                ELTBCONCEPTOSBE.cpto_cod = txtcpto_cod.Text
                ELTBCONCEPTOSBE.t_per_cod = (cmb_t_per_cod.SelectedIndex + 1).ToString.PadLeft(3, "0")
                If txtporc.Text = "" Then
                    ELTBCONCEPTOSBE.porc = "0"
                Else
                    ELTBCONCEPTOSBE.porc = txtporc.Text
                End If

                If txtmonto.Text = "" Then
                    ELTBCONCEPTOSBE.monto = "0"
                Else
                    ELTBCONCEPTOSBE.monto = txtmonto.Text
                End If

                ELTBCONCEPTOSBE.t_cpto = txtt_cpto.Text
                ELTBCONCEPTOSBE.cpto_cod = txtcpto_cod.Text
                ELTBCONCEPTOSBE.t_impres = txtt_impres.Text
                ELTBCONCEPTOSBE.cta_adm = txtcta_adm.Text
                ELTBCONCEPTOSBE.cta_plan = txtcta_plan.Text
                ELTBCONCEPTOSBE.cta_ven = txtcta_ven.Text
                ELTBCONCEPTOSBE.cta_splan = txtcta_splan.Text
                ELTBCONCEPTOSBE.cta_hab = txtcta_hab.Text
                ELTBCONCEPTOSBE.signo = cmbsigno.SelectedItem
                ELTBCONCEPTOSBE.signo1 = cmbsigno1.SelectedItem

                gsError = ELCONCEPTOSBL.SaveRow(ELTBCONCEPTOSBE, flagAccion)
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

        If txtnom.Text = "" Then
            MsgBox("Ingrese el Nombre de Concepto", MsgBoxStyle.Exclamation)
            txtnom.Focus()
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

    Private Sub txtcpto_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcpto_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "74"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcpto_cod.Text = gLinea
                lbl_cod_cpto.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtcpto_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcpto_cod.LostFocus
        If (txtcpto_cod.Text = "") Then
            lbl_cod_cpto.Text = ""
        Else
            Dim dt As DataTable
            dt = ELCONCEPTOSBL.SelectConceptoCOD(txtcpto_cod.Text)
            If dt.Rows.Count > 0 Then
                txtcpto_cod.Text = dt.Rows(0).Item(0).ToString
                lbl_cod_cpto.Text = dt.Rows(0).Item(1).ToString
            Else
                txtcpto_cod.Text = ""
                lbl_cod_cpto.Text = ""
            End If
        End If
    End Sub

    Private Sub txtt_cpto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtt_cpto.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "75"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtt_cpto.Text = gLinea
                lbltipo.Text = gSubLinea
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txtt_cpto_LostFocus(sender As Object, e As EventArgs) Handles txtt_cpto.LostFocus
        If (txtt_cpto.Text = "") Then
            lbltipo.Text = ""
        Else
            Dim dt As DataTable
            dt = ELCONCEPTOSBL.SelectTipoConceCOD(txtt_cpto.Text)
            If dt.Rows.Count > 0 Then
                txtt_cpto.Text = dt.Rows(0).Item(0).ToString
                lbltipo.Text = dt.Rows(0).Item(1).ToString
            Else
                txtt_cpto.Text = ""
                lbltipo.Text = ""
            End If
        End If
    End Sub

    Private Sub txtcta_adm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcta_adm.KeyDown, txtcta_plan.KeyDown, txtcta_ven.KeyDown, txtcta_splan.KeyDown, txtcta_hab.KeyDown

        If e.KeyValue = Keys.F9 Then
            sBusAlm = "76"
            Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()

            Select Case opcion
                Case 1
                    txtcta_adm.Text = gLinea
                    lblcta_adm.Text = gSubLinea
                Case 2
                    txtcta_plan.Text = gLinea
                    lblcta_plan.Text = gSubLinea
                Case 3
                    txtcta_ven.Text = gLinea
                    lblcta_ven.Text = gSubLinea
                Case 4
                    txtcta_splan.Text = gLinea
                    lblcta_splan.Text = gSubLinea
                Case 5
                    txtcta_hab.Text = gLinea
                    lblcta_hab.Text = gSubLinea
            End Select

            e.Handled = True
        End If
    End Sub


    Private Sub txtcta_adm_LostFocus(sender As Object, e As EventArgs) Handles txtcta_adm.LostFocus, txtcta_plan.LostFocus, txtcta_ven.LostFocus, txtcta_splan.LostFocus, txtcta_hab.LostFocus
        Dim opcion As String = DirectCast(sender, TextBox).Tag.ToString()

        Select Case opcion
            Case 1
                If (txtcta_adm.Text = "") Then
                    lblcta_adm.Text = ""
                Else
                    Dim dt As DataTable
                    dt = ELCONCEPTOSBL.SelectCtaCodigo(DateTime.Now.Year, txtcta_adm.Text)
                    If dt.Rows.Count > 0 Then
                        txtcta_adm.Text = dt.Rows(0).Item(0).ToString
                        lblcta_adm.Text = dt.Rows(0).Item(1).ToString
                    Else
                        txtcta_adm.Text = ""
                        lblcta_adm.Text = ""
                    End If
                End If

            Case 2
                If (txtcta_plan.Text = "") Then
                    lblcta_plan.Text = ""
                Else
                    Dim dt As DataTable
                    dt = ELCONCEPTOSBL.SelectCtaCodigo(DateTime.Now.Year, txtcta_plan.Text)
                    If dt.Rows.Count > 0 Then
                        txtcta_plan.Text = dt.Rows(0).Item(0).ToString
                        lblcta_plan.Text = dt.Rows(0).Item(1).ToString
                    Else
                        txtcta_plan.Text = ""
                        lblcta_plan.Text = ""
                    End If
                End If

            Case 3
                If (txtcta_ven.Text = "") Then
                    lblcta_ven.Text = ""
                Else
                    Dim dt As DataTable
                    dt = ELCONCEPTOSBL.SelectCtaCodigo(DateTime.Now.Year, txtcta_ven.Text)
                    If dt.Rows.Count > 0 Then
                        txtcta_ven.Text = dt.Rows(0).Item(0).ToString
                        lblcta_ven.Text = dt.Rows(0).Item(1).ToString
                    Else
                        txtcta_ven.Text = ""
                        lblcta_ven.Text = ""
                    End If
                End If

            Case 4
                If (txtcta_splan.Text = "") Then
                    lblcta_splan.Text = ""
                Else
                    Dim dt As DataTable
                    dt = ELCONCEPTOSBL.SelectCtaCodigo(DateTime.Now.Year, txtcta_splan.Text)
                    If dt.Rows.Count > 0 Then
                        txtcta_splan.Text = dt.Rows(0).Item(0).ToString
                        lblcta_splan.Text = dt.Rows(0).Item(1).ToString
                    Else
                        txtcta_splan.Text = ""
                        lblcta_splan.Text = ""
                    End If
                End If
            Case 5
                If (txtcta_hab.Text = "") Then
                    lblcta_hab.Text = ""
                Else
                    Dim dt As DataTable
                    dt = ELCONCEPTOSBL.SelectCtaCodigo(DateTime.Now.Year, txtcta_hab.Text)
                    If dt.Rows.Count > 0 Then
                        txtcta_hab.Text = dt.Rows(0).Item(0).ToString
                        lblcta_hab.Text = dt.Rows(0).Item(1).ToString
                    Else
                        txtcta_hab.Text = ""
                        lblcta_hab.Text = ""
                    End If
                End If

        End Select
    End Sub
End Class