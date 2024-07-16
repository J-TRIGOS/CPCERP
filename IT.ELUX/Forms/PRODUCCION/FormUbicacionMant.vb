Imports IT.ELUX.BL
Public Class FormUbicacionMant
    Dim dtVerificarPiso As New DataTable
    Dim dtDatosPisos As New DataTable
    Private primero As Boolean

    Private primero2 As Boolean
    Private UBICACIONBL As New UBICACIONBL
    Private Sub FormUbicacionMant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        primero = True
        primero2 = True

        Me.Text = "Mantenimiento Ubicacion Activos"
        cmbAlmacen.SelectedIndex = 0
        flagAccion = "N"
        Dim dtPiso As New DataTable
        dtPiso = UBICACIONBL.SelectDataPisos("0001")
        If dtPiso.Rows.Count > 0 Then
            GetCmb("cod", "nom", dtPiso, cmbUbiPiso)
            cmbUbiPiso.SelectedIndex = -1
        End If
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

    Private Sub tsbGrabar_Click(sender As Object, e As EventArgs) Handles tsbGrabar.Click
        Select Case tabUbicacion.SelectedIndex
            Case 1
                grabarUbicacion()
            Case 0
                grabarPiso()
        End Select
    End Sub

    Private Sub grabarPiso()
        Dim codAlm = cmbAlmacen.Text.Substring(0, 4)
        Dim codPiso = txt_codPiso.Text
        Dim nomPiso = txt_obser.Text
        Dim result As String = UBICACIONBL.SaveRow("", codAlm, codPiso, nomPiso, flagAccion)
        If result = "OK" Then
            MsgBox("Piso Registrado Correctamente")
            flagAccion = "NP"
            dtDatosPisos = UBICACIONBL.ObtenerDataPisos(codAlm)
            dgvPisos.DataSource = dtDatosPisos
            dtVerificarPiso = UBICACIONBL.VerificarCodPiso(codAlm)
            For i = 0 To dgvPisos.Columns.Count - 1
                dgvPisos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            Dim cont = dtVerificarPiso.Rows(0).Item(0).ToString
            txt_codPiso.Text = ""
            txt_codPiso.Text = txt_codPiso.Text.PadLeft(1, "0") & cont + 1
            txt_obser.Text = ""
        Else
            MsgBox("Verificar Datos")
        End If
    End Sub

    Private Sub grabarUbicacion()
        Dim codAlm = cmbAlmacen.Text.Substring(0, 4)
        Dim codPiso = txt_codPiso.Text
        Dim nomPiso = txt_obser.Text
        Dim result As String = UBICACIONBL.SaveRow("", codAlm, codPiso, nomPiso, flagAccion)
        If result = "OK" Then
            MsgBox("Piso Registrado Correctamente")
            flagAccion = "NU"
            dtDatosPisos = UBICACIONBL.ObtenerDataPisos(codAlm)
            dgvPisos.DataSource = dtDatosPisos
            dtVerificarPiso = UBICACIONBL.VerificarCodPiso(codAlm)
            For i = 0 To dgvPisos.Columns.Count - 1
                dgvPisos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            Dim cont = dtVerificarPiso.Rows(0).Item(0).ToString
            txt_codPiso.Text = ""
            txt_codPiso.Text = txt_codPiso.Text.PadLeft(1, "0") & cont + 1
            txt_obser.Text = ""
        Else
            MsgBox("Verificar Datos")
        End If
    End Sub

    Private Sub cmbAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        txt_codPiso.Text = ""
        Dim cod = cmbAlmacen.Text.Substring(0, 4)

        dtVerificarPiso = UBICACIONBL.VerificarCodPiso(cod)
        dtDatosPisos = UBICACIONBL.ObtenerDataPisos(cod)

        Dim cont = dtVerificarPiso.Rows(0).Item(0).ToString
        txt_codPiso.Text = txt_codPiso.Text.PadLeft(1, "0") & cont + 1
        dgvPisos.DataSource = dtDatosPisos
        For i = 0 To dgvPisos.Columns.Count - 1
            dgvPisos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Private Sub FormUbicacionMant_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub dgvPisos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPisos.CellContentClick

        If dgvPisos.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim resp = MsgBox("Desea Modificar datos?", MsgBoxStyle.YesNoCancel)
        If resp = 7 Or resp = 2 Then
            flagAccion = "N"
            dtVerificarPiso = UBICACIONBL.VerificarCodPiso(cmbAlmacen.Text.Substring(0, 4))
            For i = 0 To dgvPisos.Columns.Count - 1
                dgvPisos.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            Dim cont = dtVerificarPiso.Rows(0).Item(0).ToString
            txt_codPiso.Text = ""
            txt_codPiso.Text = txt_codPiso.Text.PadLeft(1, "0") & cont + 1
            txt_obser.Text = ""
            Exit Sub
        End If
        flagAccion = "EP"
        Dim fila
        fila = dgvPisos.CurrentRow.Index
        cmbAlmacen.Text = dgvPisos.Rows(fila).Cells("ALM_COD").Value & " - " & dgvPisos.Rows(fila).Cells("ALMACEN").Value
        txt_codPiso.Text = dgvPisos.Rows(fila).Cells("COD").Value
        txt_obser.Text = dgvPisos.Rows(fila).Cells("DESCRIPCION").Value
    End Sub

    Private Sub cmbUbiAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUbiAlmacen.SelectedIndexChanged
        If primero Then Exit Sub
        Dim codAlm As String = cmbUbiAlmacen.Text.Substring(0, 4)
        Dim dtPiso As New DataTable
        dtPiso = UBICACIONBL.SelectDataPisos(codAlm)
        If dtPiso.Rows.Count > 0 Then
            GetCmb("cod", "nom", dtPiso, cmbUbiPiso)
            cmbUbiPiso.SelectedIndex = -1
        Else
            GetCmb("cod", "nom", dtPiso, cmbUbiPiso)
            txt_codUbica.Text = ""
        End If
        primero = False
        dgvUbicacion.DataSource = ""
    End Sub

    Private Sub cmbUbiPiso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUbiPiso.SelectedIndexChanged
        If primero Then Exit Sub
        Dim codAlm = cmbUbiAlmacen.Text.Substring(0, 4)
        If cmbUbiPiso.Text <> "" Then
            Dim codPiso = cmbUbiPiso.Text.Substring(0, 2)
            Dim dtALmPiso As New DataTable
            dtALmPiso = UBICACIONBL.VerificarAlmPiso(codAlm, codPiso)
            Dim cont = dtALmPiso.Rows(0).Item(0).ToString
            txt_codUbica.Text = ""
            txt_codUbica.Text = txt_codUbica.Text.PadLeft(1, "0") & cont + 1
            Dim dtDatpsUbicacion As New DataTable
            dtDatpsUbicacion = UBICACIONBL.ObtenerDatosUbicacion(codAlm, codPiso)
            dgvUbicacion.DataSource = dtDatpsUbicacion
        End If
        primero = False
    End Sub
End Class