Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL

Public Class FormMantELTBTRANSP

    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBTRANSPBL As New ELTBTRANSPBL
    Private flagAccion As String = ""
    Private MenuBL As New MenuBL

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
                DeleteData()
            Case "exit"
                Dispose()
                Exit Sub

        End Select
    End Sub
    Private Sub SaveData()
        If OkData() = False Then
            Exit Sub
        Else
            If MessageBox.Show("Desea grabar el Registro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                Dim ELTBTRANSPBE As New ELTBTRANSPBE
                ELTBTRANSPBE.cod = txtcod.Text
                ELTBTRANSPBE.nom = txtnom.Text
                ELTBTRANSPBE.dir = txtdir.Text
                ELTBTRANSPBE.placa = txtplaca.Text
                ELTBTRANSPBE.ruc = txtruc.Text
                ELTBTRANSPBE.telf = txttelf.Text
                ELTBTRANSPBE.vehi = txtvehi.Text
                ELTBTRANSPBE.brevete = txtbrevete.Text
                ELTBTRANSPBE.certificado = txtcertificado.Text
                ELTBTRANSPBE.marca = txtmarca.Text
                ELTBTRANSPBE.ctct_cod = txtctct.Text
                If cmbcodest.SelectedIndex = 0 Then
                    ELTBTRANSPBE.estado = "H"
                Else
                    ELTBTRANSPBE.estado = "A"
                End If
                ELTBTRANSPBE.id = cmbtipo.SelectedIndex + 1

                gsError = ELTBTRANSPBL.SaveRow(ELTBTRANSPBE, flagAccion)
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
            MsgBox("Ingrese los Nombres del Transportista", MsgBoxStyle.Exclamation)
            txtnom.Focus()
            Return False
        End If
        'If txtdir.Text = "" Then
        '    MsgBox("Ingrese la Dirección del Transportista", MsgBoxStyle.Exclamation)
        '    txtdir.Focus()
        '    Return False
        'End If
        If txtruc.Text = "" Then
            MsgBox("Ingrese el Ruc del Transportista", MsgBoxStyle.Exclamation)
            txtruc.Focus()
            Return False
        End If
        If cmbtipo.SelectedIndex = -1 Then
            MsgBox("Seleccione Tipo de Unidad", MsgBoxStyle.Exclamation)
            cmbtipo.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub DeleteData()
        'If MessageBox.Show("Esta seguro de Eliminar el Registro",
        '                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        '                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
        '    Exit Sub
        'Else
        '    flagAccion = "E"
        '    Dim ELTBTRANSPBE As New ELTBTRANSPBE
        '    ELTBTRANSPBE.cod = Trim(txtcod.Text)
        '    gsError = ELTBTRANSPBL.SaveRow(ELTBTRANSPBE, flagAccion)
        '    If gsError = "OK" Then
        '        MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
        '        Dispose()
        '    Else
        '        FormMain.LblError.Text = gsError
        '        MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        '    End If
        'End If
    End Sub

    Private Sub FormMantELTBTRANSPORTISTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                txtcod.Text = ELTBTRANSPBL.SelectMaxTransp().PadLeft(3, "0")
                cmbcodest.SelectedIndex = 0
                'CleanVar()
            Case 1
                flagAccion = "M"
                GetData(gsCode)
        End Select
    End Sub
    Private Sub CleanVar()

        'txtcodigo.Clear()
        'txtnombre.Clear()
        'txtsigla.Clear()
        'txtnompl.Clear()
        'cmbcodest.SelectedIndex = -1
    End Sub
    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBTRANSPBL.SelectRow(gsCode)
        For Each Registro In dtUsuario.Rows
            txtcod.Text = gsCode
            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))
            txtdir.Text = IIf(IsDBNull(Registro("DIR")), "", Registro("DIR"))
            txtplaca.Text = IIf(IsDBNull(Registro("PLACA")), "", Registro("PLACA"))
            txtruc.Text = IIf(IsDBNull(Registro("RUC")), "", Registro("RUC"))
            txttelf.Text = IIf(IsDBNull(Registro("TELF")), "", Registro("TELF"))
            txtvehi.Text = IIf(IsDBNull(Registro("VEHI")), "", Registro("VEHI"))
            txtbrevete.Text = IIf(IsDBNull(Registro("BREVETE")), "", Registro("BREVETE"))
            txtcertificado.Text = IIf(IsDBNull(Registro("CERTIFICADO")), "", Registro("CERTIFICADO"))
            txtmarca.Text = IIf(IsDBNull(Registro("MARCA")), "", Registro("MARCA"))
            txtctct.Text = IIf(IsDBNull(Registro("CTCT_COD")), "", Registro("CTCT_COD"))
            If IIf(IsDBNull(Registro("ESTADO")), "A", Registro("ESTADO")) = "H" Then
                cmbcodest.SelectedIndex = 0
            Else
                cmbcodest.SelectedIndex = 1
            End If
            cmbtipo.SelectedIndex = IIf(IsDBNull(Registro("ID")), "", Registro("ID")) - 1
        Next
    End Sub
End Class