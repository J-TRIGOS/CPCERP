Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Public Class FormNewArt
    Private dtExplosion As DataTable
    Private ARTICULOBL As New ARTICULOBL
    Private ELTBPROCBL As New ELTBPROCBL
    Private ELTBCOMPBL As New ELTBCOMPBL
    Private bPrimero As Boolean = True
#Region "Llenar combos"

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

#End Region

    Private Sub SaveData()

        If MessageBox.Show("Desea borrar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim ELTBCOMPBE As New ELTBCOMPBE
        Dim ARTICULOBE As New ARTICULOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        'If flagAccion = "ER" Then
        Dim dgv As DataGridView
        ELTBCOMPBE.cmp_codart = gsCode
        ELTBCOMPBE.cmp_codcom = cmbart.SelectedValue
        gsError3 = ELTBCOMPBL.SaveRowCMP(ELTBCOMPBE, "E", dgv, "")
        If gsError3 = "OK" Then
            Dispose()
            Exit Sub
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub GetData(ByVal sCode As String)
        Dim dtArticulo As DataTable
        dtArticulo = ARTICULOBL.SelectRow(cmbart.SelectedValue)
        For Each Registro In dtArticulo.Rows
            cmbunidadmedida1.SelectedValue = IIf(IsDBNull(Registro("UNI_COD")), "", Registro("UNI_COD"))
            cmbcodalmacen1.SelectedValue = IIf(IsDBNull(Registro("ALM_COD")), "", Registro("ALM_COD"))
            cmbcentrocosto1.SelectedValue = IIf(IsDBNull(Registro("CCOSTO_COD")), "", Registro("CCOSTO_COD"))
            txtcodproc1.Text = IIf(IsDBNull(Registro("COD_PROC")), "", Registro("COD_PROC"))
            txtdescripcion.Text = IIf(IsDBNull(Registro("ART_DESCRI")), "", Registro("ART_DESCRI"))
            Dim dt As DataTable = ELTBPROCBL.SelectRow(Trim(txtcodproc1.Text))
            For Each Registro1 In dt.Rows
                txtdescriproc1.Text = IIf(IsDBNull(Registro1("DESCRIPCION")), "", Registro1("DESCRIPCION"))
            Next
            cmbmedida4.SelectedValue = IIf(IsDBNull(Registro("MEDIDA_NUEVO")), "", Registro("MEDIDA_NUEVO"))
            If IIf(IsDBNull(Registro("ART_SOLM")), "", Registro("ART_SOLM")) = "1" Then
                cmbreqsolm1.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("ART_SOLM")), "", Registro("ART_SOLM")) = "0" Then
                cmbreqsolm1.SelectedIndex = 1
            End If
        Next
        dtArticulo = ARTICULOBL.getListdgv4(gsCode, cmbart.SelectedValue)
        For Each Registro In dtArticulo.Rows
            npdcantcomp.Value = IIf(IsDBNull(Registro("CMP_CANTIDAD")), "", Registro("CMP_CANTIDAD"))
            If IIf(IsDBNull(Registro("CMP_TIPO")), "", Registro("CMP_TIPO")) = "01" Then
                cmbtipocomp.SelectedIndex = 0
            Else
                cmbtipocomp.SelectedIndex = 1
            End If

        Next
    End Sub
    Private Sub FormNewArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gsCode6 = "" Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If
        dtExplosion = ARTICULOBL.SelectUndMed()
        GetCmb("cod", "nom", dtExplosion, cmbunidadmedida)
        dtExplosion = ARTICULOBL.SelectCCosto
        GetCmb("cod", "nom", dtExplosion, cmbcentrocosto)
        dtExplosion = ARTICULOBL.getListcmb12
        GetCmb("cod", "nom", dtExplosion, cmbmedida)
        dtExplosion = ARTICULOBL.getListcmb14
        GetCmb("cod", "nom", dtExplosion, cmbmedida2)
        dtExplosion = ARTICULOBL.getListcmb11
        GetCmb("cod", "nom", dtExplosion, cmbcodalmacen)
        '------
        dtExplosion = ARTICULOBL.SelectUndMed()
        GetCmb("cod", "nom", dtExplosion, cmbunidadmedida1)
        dtExplosion = ARTICULOBL.SelectCCosto
        GetCmb("cod", "nom", dtExplosion, cmbcentrocosto1)
        dtExplosion = ARTICULOBL.getListcmb12
        GetCmb("cod", "nom", dtExplosion, cmbmedida3)
        dtExplosion = ARTICULOBL.getListcmb14
        GetCmb("cod", "nom", dtExplosion, cmbmedida4)
        dtExplosion = ARTICULOBL.getListcmb11
        GetCmb("cod", "nom", dtExplosion, cmbcodalmacen1)
        If flagAccion = "M" Then
            Try
                dtExplosion = ARTICULOBL.Art_CompExp(gsCode)
                GetCmb("cod", "nom", dtExplosion, cmbart)
            Catch ex As Exception
                MsgBox("El articulo no tiene explosion")
                Dispose()
            End Try

            'If cmbcentrocosto.SelectedIndex = -1 Then
            '    flagAccion = "N"
            'End If
            If btnborrar.Enabled = False Then
                flagAccion = "N"
            End If
        End If
        bPrimero = False
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dispose()
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        'Dim frm As New FormExplosionadoAll
        If MessageBox.Show("Desea grabar el Registro",
                   Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If
        If gsCode6 = "" Then
            gsCode8 = cmbcentrocosto.SelectedValue
            gsCode9 = cmbcodalmacen.SelectedValue
            gsCode10 = cmbmedida2.SelectedValue
            gsCode11 = cmbunidadmedida.SelectedValue
            gsCode7 = txtcodproc.Text
            If cmbreqsolm.SelectedIndex = 0 Then
                gsCode13 = "1"
            Else
                gsCode13 = "0"
            End If

        Else
            gsCode8 = cmbcentrocosto1.SelectedValue
            gsCode9 = cmbcodalmacen1.SelectedValue
            gsCode10 = cmbmedida4.SelectedValue
            gsCode11 = cmbunidadmedida1.SelectedValue
            gsCode12 = cmbart.SelectedValue
            gsCode7 = txtcodproc1.Text
            gsCode5 = cmbtipocomp.Text
            gsCode4 = npdcantcomp.Value
            gsCode3 = txtdescripcion.Text
            If cmbreqsolm1.SelectedIndex = 0 Then
                gsCode13 = "1"
            Else
                gsCode13 = "0"
            End If
        End If

        Dispose()
    End Sub

    Private Sub FormNewArt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sBusAlm = "31"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcodproc.Text = gLinea
            txtdescriproc.Text = gSubLinea
            'txtcodart.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            'gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sBusAlm = "31"
        Dim frm As New FormBUSQUEDA
        frm.ShowDialog()
        'MsgBox(IsDBNull(gLinea.Length))
        If gLinea <> Nothing And gSubLinea <> Nothing Then
            txtcodproc1.Text = gLinea
            txtdescriproc1.Text = gSubLinea
            'txtcodart.Text = gArt
            gLinea = Nothing
            gSubLinea = Nothing
            'gArt = Nothing
        Else
            gLinea = Nothing
            gSubLinea = Nothing
            gArt = Nothing
        End If
    End Sub

    Private Sub cmbart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbart.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
        GetData(cmbart.SelectedValue)
    End Sub

    Private Sub cmbtipocomp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipocomp.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
    End Sub

    Private Sub cmbcentrocosto1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcentrocosto1.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
    End Sub

    Private Sub cmbcodalmacen1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodalmacen1.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
    End Sub

    Private Sub cmbmedida3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmedida3.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
    End Sub

    Private Sub cmbunidadmedida1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbunidadmedida1.SelectedIndexChanged
        If bPrimero Then
            Exit Sub
        End If
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If cmbart.SelectedIndex > -1 Then
            SaveData()
        Else
            MsgBox("Seleccion un articulo")
        End If

    End Sub

    Private Sub btnmod_Click(sender As Object, e As EventArgs) 

    End Sub
End Class