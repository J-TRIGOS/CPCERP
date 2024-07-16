Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBGRUPO
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Private ELTBGRUPOBL As New ELTBGRUPOBL
    Private ELTBDETGRUPOBL As New ELTBDETGRUPOBL
    Private CCOSTOBL As New CCOSTOBL
    Private flagAccion As String = ""
    Private Sub CleanVar()

        txtcod.Text = ELTBGRUPOBL.LastCodigo()
        txtdescripcion.Clear()
        cmbestado.SelectedIndex = -1
    End Sub

    Private Function OkData() As Boolean

        If cmbestado.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbestado.Focus()
            Return False
        End If
        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese descripcion de grupo", MsgBoxStyle.Exclamation)
            txtdescripcion.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBGRUPOBL.SelectRow(gsCode)
        Dim dt As DataTable
        For Each Registro In dtUsuario.Rows
            txtcod.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtdescripcion.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            If IIf(IsDBNull(Registro("EST")), -1, Registro("EST")) = "H" Then
                cmbestado.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("EST")), -1, Registro("EST")) = "H" Then
                cmbestado.SelectedIndex = 1
            End If
            txtcco_cod.Text = IIf(IsDBNull(Registro("CCO_COD")), "", Registro("CCO_COD"))
            'txtnom_cco.Text =

            dt = ELPAGO_DOCUMENTOBL.SelectCentroCostoCOD(txtcco_cod.Text)
            If dt.Rows.Count > 0 Then
                txtnom_cco.Text = dt.Rows(0).Item(1).ToString
            Else
                txtnom_cco.Text = ""
            End If
        Next

    End Sub

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
        Dim ELTBGRUPOBE As New ELTBGRUPOBE
        ELTBGRUPOBE.cod = RTrim(txtcod.Text)
        ELTBGRUPOBE.nom = RTrim(txtdescripcion.Text)
        ELTBGRUPOBE.est = IIf(cmbestado.SelectedIndex = 0, "H", "A")
        ELTBGRUPOBE.cco_cod = RTrim(txtcco_cod.Text)
        Dim ELTBDETGRUPOBE As New ELTBDETGRUPOBE
        'gsError2 = ELTBRECCBL.SaveRow(ELTBRECCBE, flagAccion, dgvCaracteristica, txtcod.Text)
        'Next
        gsError = ELTBGRUPOBL.SaveRow(ELTBGRUPOBE, ELTBDETGRUPOBE, flagAccion, dgvCaracteristica, txtcod.Text)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub
    Private Sub tsbForm_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsbForm.ItemClicked
        Dim sFunc = e.ClickedItem.Tag.ToString()

        If Mid(sFunc, 5, 4) = "func" Then
            'obtener el objeto a procesar desde el tag del boton
            sFunc = Mid(sFunc, 10)

        End If
        Select Case sFunc

            Case "save"
                SaveData()
                Exit Sub
            Case "exit"
                Dispose()
                Exit Sub
            Case "Print"
                gsRptArgs = {}
                ReDim gsRptArgs(0)
                gsRptArgs(0) = txtcod.Text
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBDETGRUPO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
        End Select
    End Sub
    Private Sub FormELTBGRUPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gsError = ""
        gsError2 = ""
        gpCaption = "GRUPOS"
        Me.Text = gpCaption
        txtcod.Enabled = False
        'Definir las columnas del grid
        dgvCaracteristica.Columns.Add("Columna_Codigo", "Codigo")
        dgvCaracteristica.Columns.Add("Nombres", "Nombres")
        dgvCaracteristica.Columns.Add("EST", "Estado")
        'Opcion de Busqueda
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()

            Case 1
                flagAccion = "M"
                GetData(gsCode)
                Dim dt As New DataTable
                dt = ELTBDETGRUPOBL.SelectRow(txtcod.Text)
                'Recorre el data row para mostrar en el grid
                For Each row As DataRow In dt.Rows
                    dgvCaracteristica.Rows.Add(IIf(IsDBNull(row("COD")), "", row("COD")), IIf(IsDBNull(row("NOM")), "", row("NOM")), IIf(IsDBNull(row("EST")), "", row("EST")))

                Next
                'Borra la caracteristica de la base de datos


                dgvCaracteristica.Refresh()
        End Select
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        sBusAlm = "1"
        Dim frm As New FormPerGrupo
        frm.ShowDialog()
    End Sub

    Private Sub FormELTBGRUPO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If dgvCaracteristica.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then

                Exit Sub
            End If
            dgvCaracteristica.Rows.RemoveAt(dgvCaracteristica.CurrentRow.Index)
            dgvCaracteristica.Refresh()
        Else
            MsgBox("No hay datos")
        End If
    End Sub

    Private Sub txtcco_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcco_cod.KeyDown
        If e.KeyValue = Keys.F9 Then
            sBusAlm = "101"
            Dim frm As New FormBUSQUEDA
            frm.ShowDialog()
            If (gLinea <> Nothing) Then
                txtcco_cod.Text = gLinea
                txtnom_cco.Text = gSubLinea
            End If
            e.Handled = True
        End If
        gLinea = ""
        gSubLinea = ""
    End Sub

    Private Sub txtcco_cod_LostFocus(sender As Object, e As EventArgs) Handles txtcco_cod.LostFocus
        If txtcco_cod.TextLength > 2 Then
            txtnom_cco.Text = CCOSTOBL.SelectNom(txtcco_cod.Text)
        Else
            txtnom_cco.Text = ""
        End If

    End Sub
End Class