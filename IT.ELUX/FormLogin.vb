Imports IT.ELUX.BL
Imports Scripting

Public Class FormLogin

    Private nIntentos As Integer
    Private sPathSourcetEXE As String = "\\192.168.1.7\sistema\E.ELUX\IT.CPC.exe"

    Private Sub chkNewVersion()
        Dim nCurrentVersion As String
        Dim nNewVersion As String

        Dim fso As FileSystemObject

        fso = New FileSystemObject
        nNewVersion = fso.GetFileVersion(sPathSourcetEXE)
        nCurrentVersion = System.Windows.Forms.Application.ProductVersion
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

    Private Sub UcLogin1_LoginClick(sender As Object, e As EventArgs) Handles UcLogin1.LoginClick

        Dim ELTBUSERBL As New ELTBUSERBL
        Dim sUser = UcLogin1.User.ToUpper
        Dim sPass = UcLogin1.Password


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

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Dim fso As FileSystemObject

        '    fso = New FileSystemObject
        lblVersion.Text = "v." + System.Windows.Forms.Application.ProductVersion
        lblVersion.BringToFront()

        'chequear nueva version
        chkNewVersion()

    End Sub


End Class