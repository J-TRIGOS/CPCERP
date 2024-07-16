Imports IT.ELUX.BL
Imports IT.ELUX.BE

Public Class FrmMantTipoFalla
#Region "Variables"
    Private oTipoFallaBL As New TipoFallaBL
    Private oTipoFallaBE As New TipoFallaBE

#End Region
#Region "Funciones"
    Private Sub CleanVar()
        'txtcodigo.Text = oTipoFallaBL.LastCodigo()
        txtdescri.Text = ""
        cmbestado.SelectedIndex = 1

        txtdescri.Focus()
    End Sub

    Private Function OkData() As Boolean
        OkData = True
        If Len(Trim$(txtdescri.Text)) = 0 Then
            MsgBox("Debe ingresar descripción", vbInformation, "Datos incompletos")
            OkData = False
            txtdescri.Focus()
            Exit Function
        End If
    End Function

#End Region

#Region "Formulario"
    Private Sub FrmMantTipoFalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//FUNCION LOAD
        Dim dt As DataTable
        Me.Cursor = Cursors.WaitCursor
        txtcodigo.Enabled = False
        Try
            If gnOpcion = 1 Then '//VISUALIZAR O MODIFICAR
                Dim oBrowseBL = New TipoFallaBL
                Dim sAcccion = String.Empty
                txtcodigo.Text = gsCode

                dt = oBrowseBL.SelectByCodigoDt(gsCode)
                If dt.Rows.Count <= 0 Then Exit Sub

                With dt.Rows(0)
                    txtdescri.Text = IIf(IsDBNull(.Item("tfa_descri")), "", .Item("tfa_descri").ToString)
                    cmbestado.SelectedIndex = .Item("tfa_estcod").ToString
                End With
            End If

            Select Case gnOpcion
                Case 0 '//NUEVO
                    TSBtnEdit.Enabled = False
                    TSBtnDelete.Enabled = False
                    CleanVar()
                Case 1 '//MODIFICAR
                    GroupBox1.Enabled = False
                    TSBtnSave.Enabled = False
            End Select

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            'ModWatWind.show(ex.Message, 60)
        End Try

        Exit Sub
    End Sub

    Private Sub FrmMantTipoFalla_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub FrmMantTipoFalla_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

#Region "Botones"
    Private Sub TSBtnNew_Click(sender As Object, e As EventArgs) Handles TSBtnNew.Click
        '//BOTON NUEVO
        GroupBox1.Enabled = True
        TSBtnEdit.Enabled = False
        TSBtnSave.Enabled = True
        TSBtnDelete.Enabled = False
        'gsbrowseOpcion = 0
        CleanVar()
    End Sub

    Private Sub TSBtnEdit_Click(sender As Object, e As EventArgs) Handles TSBtnEdit.Click
        '//BOTON EDITAR
        GroupBox1.Enabled = True
        TSBtnNew.Enabled = False
        TSBtnDelete.Enabled = False
        TSBtnSave.Enabled = True
    End Sub

    Private Sub TSBtnDelete_Click(sender As Object, e As EventArgs) Handles TSBtnDelete.Click
        '//BOTON ELIMINAR
        Dim iDelete As Integer = oTipoFallaBL.Delete(gsCode)
        If iDelete = 1 Then
            'ModWatWind.show(".:  Registro Eliminado Exitosamente.", 20)
            Me.Close()
        End If
    End Sub

    Private Sub txtdescri_TextChanged(sender As Object, e As EventArgs) Handles txtdescri.TextChanged
        txtdescri.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked
        '//BARRA  DE BOTONES
        Select Case ToolStrip.Items.IndexOf(e.ClickedItem)
            Case 1 '//BOTON GUARDAR
                If Not OkData() Then Exit Sub

                oTipoFallaBE.tfa_codigo = txtcodigo.Text.Trim
                oTipoFallaBE.tfa_descri = txtdescri.Text.Trim
                oTipoFallaBE.tfa_estcod = cmbestado.SelectedIndex

                Dim iUpdate As Integer
                Dim oUpdate As Object
                Select Case gnOpcion
                    Case 0 '//INGRESO                        
                        oUpdate = oTipoFallaBL.Insert(oTipoFallaBE)

                        '//EVALUANDO EL RETURN 
                        If oUpdate = "@ERROR" Then
                            iUpdate = 0
                        Else
                            iUpdate = 1
                            oTipoFallaBE.tfa_codigo = oUpdate

                        End If

                    Case 1 '//MODIFICACION
                        iUpdate = oTipoFallaBL.Update(oTipoFallaBE)
                End Select
                If iUpdate = 0 Then
                    'ModWatWind.show("--- Error no se completo la operaci�n.", 20)
                End If
                If iUpdate = 1 Then
                    gsCode = oTipoFallaBE.tfa_codigo
                    '//GUARDAR ESPECIFICACIONES

                    'ModWatWind.show("--- Guardado Exitosamente.", 20)
                    Me.Close()
                End If
        End Select
    End Sub


#End Region

#End Region
End Class