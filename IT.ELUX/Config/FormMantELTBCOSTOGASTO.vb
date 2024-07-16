'Importando la Capa de Entidades y la Capa Logica
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBCOSTOGASTO
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBCOSTOGASTOBL As New ELTBCOSTOGASTOBL

    Private flagAccion As String = ""

    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    'Private MenuBL As New MenuBL

    Private Sub CleanVar()
        txtcod.Clear()
        txtcod.Text = ELTBCOSTOGASTOBL.LastCodigo
        txtdescri.Clear()
        cmbtipo.SelectedIndex = -1
        cmbest.SelectedIndex = -1
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

        End Select
    End Sub

    Private Function OkData() As Boolean
        If cmbest.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado", MsgBoxStyle.Exclamation)
            cmbest.Focus()
            Return False
        End If
        If txtdescri.Text = "" Then
            MsgBox("Ingrese descripcion del costo o gasto", MsgBoxStyle.Exclamation)
            txtdescri.Focus()
            Return False
        End If
        If cmbtipo.SelectedIndex = -1 Then
            MsgBox("Seleccione el tipo", MsgBoxStyle.Exclamation)
            txtdescri.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub SaveData()

        If MessageBox.Show("Desea grabar el Registro",
                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
            Exit Sub
        End If

        If OkData() = False Then
            Exit Sub
        End If

        Dim ELTBCOSTOGASTOBE As New ELTBCOSTOGASTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELTBCOSTOGASTOBE.cod = RTrim(txtcod.Text)
        ELTBCOSTOGASTOBE.descripcion = RTrim(txtdescri.Text)

        If cmbest.SelectedIndex = 0 Then
            ELTBCOSTOGASTOBE.est = "H"
        ElseIf cmbest.SelectedIndex = 1 Then
            ELTBCOSTOGASTOBE.est = "A"
        End If

        If cmbtipo.SelectedIndex = 0 Then
            ELTBCOSTOGASTOBE.tipo = "1"
        ElseIf cmbest.SelectedIndex = 1 Then
            ELTBCOSTOGASTOBE.tipo = "2"
        End If
        ELMVLOGSBE.log_codusu = gsCodUsr
        gsError = ELTBCOSTOGASTOBL.SaveRow(ELTBCOSTOGASTOBE, flagAccion, ELMVLOGSBE)
        If gsError = "OK" Then
            MsgBox("Datos Grabados Correctamente", MsgBoxStyle.Information)
            Dispose()
        Else
            FormMain.LblError.Text = gsError
            MsgBox("Error al Grabar", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub GetData(ByVal sCode As String)
        Dim dtUsuario As DataTable
        Dim Registro As DataRow

        dtUsuario = ELTBCOSTOGASTOBL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcod.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtdescri.Text = IIf(IsDBNull(Registro("DESCRIPCION")), "", Registro("DESCRIPCION"))

            If IIf(IsDBNull(Registro("TIPO")), "", Registro("TIPO")) = 1 Then
                cmbtipo.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("TIPO")), "", Registro("TIPO")) = 2 Then
                cmbtipo.SelectedIndex = 1
            End If
            If IIf(IsDBNull(Registro("EST")), -1, Registro("EST")) = "H" Then
                cmbest.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("EST")), -1, Registro("EST")) = "A" Then
                cmbest.SelectedIndex = 1
            End If

        Next

    End Sub
    Private Sub FormELTBCOSTOGASTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdescri.Select()
        bPrimero = True
        gsError = ""
        gpCaption = "Costo/Gasto"
        Me.Text = gpCaption
        'Verificar que operacion sera si es nuevo o modificacion o eliminacion
        Select Case gnOpcion
            Case 0
                flagAccion = "N"
                CleanVar()

            Case 1
                flagAccion = "M"
                GetData(sNDoc)

        End Select

        bPrimero = False
    End Sub

    Private Sub FormELTBCOSTOGASTO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub
End Class