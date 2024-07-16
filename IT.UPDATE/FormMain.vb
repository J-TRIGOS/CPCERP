Imports System.ComponentModel
Imports System.IO
Imports System.Threading
Imports Scripting

Public Class FormMain

    Private bUpdate As Boolean = False
    ' Private sPathSource As String = "C:\CARLOS\PROJECTS\ENVASES LUX\IT.ELUX\IT.ELUX\bin\Debug\"
    ' Private sPathSourcetEXE As String = "C:\CARLOS\PROJECTS\ENVASES LUX\IT.ELUX\IT.ELUX\bin\Debug\IT.ELUX.exe"
    Private sPathSource As String = "\\192.168.1.7\sistema\E.ELUX\"
    Private sPathSourcetEXE As String = "\\192.168.1.7\sistema\E.ELUX\IT.CPC.exe"

    Private sPathTarget As String = "C:\CPC\SISTEMA"
    Private sPathTargetEXE As String = "C:\CPC\SISTEMA\IT.CPC.exe"

    Private nInter As Integer = 37

    Private nTimer As Integer = 11

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If bUpdate Then Exit Sub

        If Mid(btnUpdate.Text, 1, 6) = "Cerrar" Then
            tmrClose.Enabled = False
            launchApp()
            Me.Dispose()
            Exit Sub
        End If

        btnUpdate.Enabled = False
        bUpdate = True

        'close process ERP
        Dim proc = Process.GetProcessesByName("IT.CPC")
        For i As Integer = 0 To proc.Count - 1
            proc(i).CloseMainWindow()
        Next

        Thread.Sleep(1000)

        'delete files source
        delFiles(sPathTarget)

        Thread.Sleep(1000)
        'copy files
        copyFiles(sPathSource)

        btnUpdate.Image = Nothing
        tmrClose.Enabled = True
        lblUpdate.Text = "Proceso terminado"

        btnUpdate.Enabled = True

    End Sub

    Private Sub tmrClose_Tick(sender As Object, e As EventArgs) Handles tmrClose.Tick

        bUpdate = False
        nTimer = nTimer - 1
        btnUpdate.Text = "Cerrar (" + nTimer.ToString + ")"
        If nTimer < 0 Then
            launchApp()
            Me.Dispose()
        End If

    End Sub

    Private Sub copyFiles(ByVal sPath As String)

        Dim fileEntries As String() = Directory.GetFiles(sPath)
        ' Process the list of files found in the directory.

        lblUpdate.Text = "Actualizando nueva versión ..."
        prb2.Maximum = fileEntries.Count + 1
        lstFiles.Items.Clear()
        Dim fileName As String
        For Each fileName In fileEntries

            'get the file name
            Dim sName As String = Mid(fileName, fileName.LastIndexOf("\") + 1 + 1)

            lstFiles.Items.Add(fileName)
            IO.File.Copy(Path.Combine(sPathSource, sName), Path.Combine(sPathTarget, sName))

            prb2.Value = prb2.Value + 1
            Me.Refresh()
            Thread.Sleep(nInter)
        Next fileName
        prb2.Value = prb2.Maximum
        Me.Refresh()
    End Sub

    Private Sub delFiles(ByVal sPath As String)

        Dim fileEntries As String() = Directory.GetFiles(sPath)
        ' Process the list of files found in the directory.

        lblUpdate.Text = "Eliminado versión anterior ..."
        prb1.Maximum = fileEntries.Count + 1




        'delete all files in target
        Dim fileName As String
        For Each fileName In fileEntries

            System.IO.File.Delete(fileName)

            prb1.Value = prb1.Value + 1
            Me.Refresh()
            Thread.Sleep(nInter)
        Next fileName
        prb1.Value = prb1.Maximum
        Me.Refresh()
    End Sub

    Private Sub launchApp()
        'close proccess update
        Dim procu = Process.GetProcessesByName("IT.UPDATE")
        For i As Integer = 0 To procu.Count - 1
            procu(i).CloseMainWindow()
        Next

        'launch app
        Dim proc As New System.Diagnostics.Process()
        proc = Process.Start("C:\CPC\SISTEMA\IT.CPC.exe", "")
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fso As FileSystemObject

        fso = New FileSystemObject
        lblVersion.Text = "Versión Actual : " + fso.GetFileVersion(sPathTargetEXE)
        lblNew.Text = "Nueva versión : " + fso.GetFileVersion(sPathSourcetEXE)

    End Sub

End Class
