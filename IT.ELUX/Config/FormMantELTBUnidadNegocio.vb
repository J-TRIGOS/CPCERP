'Importando la Capa de Entidades y la Capa Logica
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantELTBUnidadNegocio
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private ELTBUNIDADNEGOCIOBL As New ELTBUNIDADNEGOCIOBL

    Private flagAccion As String = ""

    Private bPrimero As Boolean = True
    Private bSegundo As Boolean = True
    Private bTercero As String = "0"
    Private bCuarto As String = "0"
    'Private MenuBL As New MenuBL
#Region "Llenar combos"

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

#End Region

    Private Sub CleanVar()
        txtcod.Clear()
        txtnom.Clear()
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
        If txtnom.Text = "" Then
            MsgBox("Ingrese nombre de la unidad de negocio", MsgBoxStyle.Exclamation)
            txtnom.Focus()
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

        Dim ELTBUNIDADNEGOCIOBE As New ELTBUNIDADNEGOCIOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        ELTBUNIDADNEGOCIOBE.cod = RTrim(txtcod.Text)
        ELTBUNIDADNEGOCIOBE.nombre = RTrim(txtnom.Text)

        If cmbest.SelectedIndex = 0 Then
            ELTBUNIDADNEGOCIOBE.est = "H"
        ElseIf cmbest.SelectedIndex = 1 Then
            ELTBUNIDADNEGOCIOBE.est = "A"
        End If

        gsError = ELTBUNIDADNEGOCIOBL.SaveRow(ELTBUNIDADNEGOCIOBE, flagAccion, ELMVLOGSBE)
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

        dtUsuario = ELTBUNIDADNEGOCIOBL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcod.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))


            If IIf(IsDBNull(Registro("EST")), -1, Registro("EST")) = "H" Then
                cmbest.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("EST")), -1, Registro("EST")) = "A" Then
                cmbest.SelectedIndex = 1
            End If

        Next

    End Sub

    Private Sub FormELTBUnidadNegocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        gsError = ""
        gpCaption = "Unidad de Negocio"
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
End Class