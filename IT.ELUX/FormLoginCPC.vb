Imports IT.ELUX.BL
Imports Scripting
Public Class FormLoginCPC


    Private nIntentos As Integer
    Private sPathSourcetEXE As String = "\\192.168.1.7\sistema\E.ELUX\IT.CPC.exe"
    Dim version = ""

    Private Sub chkNewVersion()
        Dim nCurrentVersion As String
        Dim nNewVersion As String

        Dim fso As FileSystemObject

        fso = New FileSystemObject
        nNewVersion = fso.GetFileVersion(sPathSourcetEXE)
        nCurrentVersion = System.Windows.Forms.Application.ProductVersion
        version = nNewVersion

#If DEBUG Then

#Else
        If nNewVersion <> nCurrentVersion Then
            MsgBox("Existe una nueva versión del sistema (" + nNewVersion + "), se procederá con la actualización ...", MsgBoxStyle.Information)

            'launch app
            Dim proc As New System.Diagnostics.Process()

            proc = Process.Start("C:\CPC\UPDATE\IT.UPDATE.exe", "")

            End
            Exit Sub
        End If
#End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim ELTBUSERBL As New ELTBUSERBL
        Dim sUser = txtUser.Text.ToUpper
        Dim sPass = txtPass.Text

        nIntentos = nIntentos + 1

        gsCodUsr = ELTBUSERBL.Login(sUser, sPass)
        If gsCodUsr <> "" Then
            gsUser = sUser

            Me.Hide()
            FormMain.Show()
        Else
            If nIntentos >= 3 Then
                MsgBox("Demasiados intentos. Se notificara al area de sistemas", MsgBoxStyle.Critical, "Error de ingreso")
                Dispose()
            End If
            MsgBox("Usuario o password incorrectos. Reintente", MsgBoxStyle.Critical, "Error de ingreso")
        End If
    End Sub

    Private Sub FormLoginCPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = "USERNAME"
        txtUser.ForeColor = Color.Gray

        txtPass.Text = "PASSWORD"
        txtPass.ForeColor = Color.Gray
        Dim nCurrentVersion As String
        Dim nNewVersion As String

        Dim fso As FileSystemObject

        fso = New FileSystemObject
        nNewVersion = fso.GetFileVersion(sPathSourcetEXE)
        nCurrentVersion = System.Windows.Forms.Application.ProductVersion
        lblVersion.Text = "Versión: " & nCurrentVersion

        lblVersion.Text = "v." + System.Windows.Forms.Application.ProductVersion
        lblVersion.BringToFront()

        'chequear nueva version
        chkNewVersion()
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dispose()
    End Sub
End Class