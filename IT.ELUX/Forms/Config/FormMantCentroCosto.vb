'Importando la Capa de Entidades y la Capa Logica
Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Public Class FormMantCentroCosto
    Private gpCaption As String
    Private gpCodUsu As String
    Private nNode As Integer = 0
    Private CCOSTOBL As New CCOSTOBL

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
        cmbclasificacion.SelectedIndex = -1
        cmbuninego.SelectedIndex = -1
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
            MsgBox("Ingrese nombre del centro de costo", MsgBoxStyle.Exclamation)
            txtnom.Focus()
            Return False
        End If
        If cmbclasificacion.SelectedIndex = -1 Then
            MsgBox("Seleccione la clasificacion", MsgBoxStyle.Exclamation)
            cmbclasificacion.Focus()
            Return False
        End If
        If cmbuninego.SelectedIndex = -1 Then
            MsgBox("Seleccione la unidad de negocio", MsgBoxStyle.Exclamation)
            cmbuninego.Focus()
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

        Dim CCOSTOBE As New CCOSTOBE
        Dim ELMVLOGSBE As New ELMVLOGSBE
        CCOSTOBE.cod = RTrim(txtcod.Text)
        CCOSTOBE.nom = RTrim(txtnom.Text)

        If cmbest.SelectedIndex = 0 Then
            CCOSTOBE.est = "H"
        ElseIf cmbest.SelectedIndex = 1 Then
            CCOSTOBE.est = "A"
        End If
        If cmbuninego.SelectedIndex = 0 Then
            CCOSTOBE.ccosto_uninego = "HOJALATA"
        ElseIf cmbuninego.SelectedIndex = 1 Then
            CCOSTOBE.ccosto_uninego = "COMUN A TODOS"
        End If
        CCOSTOBE.ccosto_codigo = cmbclasificacion.SelectedValue
        gsError = CCOSTOBL.SaveRow(CCOSTOBE, flagAccion, ELMVLOGSBE)
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

        dtUsuario = CCOSTOBL.SelectRow(gsCode)

        For Each Registro In dtUsuario.Rows
            txtcod.Text = IIf(IsDBNull(Registro("COD")), "", Registro("COD"))
            txtnom.Text = IIf(IsDBNull(Registro("NOM")), "", Registro("NOM"))

            cmbclasificacion.SelectedValue = IIf(IsDBNull(Registro("CCOSTO_CODIGO")), "", Registro("CCOSTO_CODIGO"))
            'cmbuninego.SelectedText =
            If Trim(IIf(IsDBNull(Registro("CCOSTO_UNINEGO")), "", Registro("CCOSTO_UNINEGO"))) = "HOJALATA" Then
                cmbuninego.SelectedIndex = 0
            ElseIf RTrim(IIf(IsDBNull(Registro("CCOSTO_UNINEGO")), "", Registro("CCOSTO_UNINEGO"))) = "COMUN A TODOS" Then
                cmbuninego.SelectedIndex = 1
            End If


            If IIf(IsDBNull(Registro("EST")), -1, Registro("EST")) = "H" Then
                cmbest.SelectedIndex = 0
            ElseIf IIf(IsDBNull(Registro("EST")), -1, Registro("EST")) = "A" Then
                cmbest.SelectedIndex = 1
            End If

        Next

    End Sub
    Private Sub FormCentroCosto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bPrimero = True
        gsError = ""
        gpCaption = "Centro de Costo"
        Me.Text = gpCaption
        Dim dt As DataTable = CCOSTOBL.Selectclasi()
        GetCmb("cod", "nom", dt, cmbclasificacion)
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

    Private Sub FormCentroCosto_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub cmbclasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbclasificacion.SelectedIndexChanged
        If bPrimero = True Then Exit Sub

        If cmbclasificacion.SelectedValue = "1" Or cmbclasificacion.SelectedValue = "2" Then
            txtcod.Text = CCOSTOBL.LastCodigo()
        Else
            txtcod.Text = CCOSTOBL.LastCodigo1(cmbclasificacion.SelectedValue)
        End If
    End Sub
End Class