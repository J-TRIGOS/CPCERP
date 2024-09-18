Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Imports Scripting

Public Class FormMantCierreMes
    Dim ELTBALMACENBL As New ELTBALMACENBL
    Private Sub FormMantCierreMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbAnho.Text = Today.Year
        Dim mes = Today.Month
        cmbMes.SelectedIndex = mes - 1
        Dim smes = "00"
        Select Case mes
            Case 1
                smes = "01"
            Case 2
                smes = "02"
            Case 3
                smes = "03"
            Case 4
                smes = "04"
            Case 5
                smes = "05"
            Case 6
                smes = "06"
            Case 7
                smes = "07"
            Case 8
                smes = "08"
            Case 9
                smes = "09"
            Case 10
                smes = "10"
            Case 11
                smes = "11"
            Case 12
                smes = "12"
        End Select


        Dim dtCierre As DataTable
        dtCierre = ELTBALMACENBL.SelectCierreMes(cmbAnho.Text, smes)
        If dtCierre.Rows.Count > 0 Then
            For i = 0 To dtCierre.Rows.Count - 1
                If dtCierre.Rows(i).Item(0) = "ALMACEN" Then
                    If dtCierre.Rows(i).Item(1) = "0" Then
                        AlmAbi.Checked = True
                    Else
                        AlmCer.Checked = True
                    End If
                End If

                If dtCierre.Rows(i).Item(0) = "FALLADOS" Then
                    If dtCierre.Rows(i).Item(1) = "0" Then
                        FalAbi.Checked = True
                    Else
                        FalCer.Checked = True
                    End If
                End If

                If dtCierre.Rows(i).Item(0) = "PRODUCCION" Then
                    If dtCierre.Rows(i).Item(1) = "0" Then
                        ProAbi.Checked = True
                    Else
                        ProCer.Checked = True
                    End If
                End If

                If dtCierre.Rows(i).Item(0) = "REINGRESOS" Then
                    If dtCierre.Rows(i).Item(1) = "0" Then
                        ReiAbi.Checked = True
                    Else
                        ReiCer.Checked = True
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub FormMantCierreMes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        Dim mes = cmbMes.SelectedIndex
        Dim smes = "00"
        Select Case mes
            Case 0
                smes = "01"
            Case 1
                smes = "02"
            Case 2
                smes = "03"
            Case 3
                smes = "04"
            Case 4
                smes = "05"
            Case 5
                smes = "06"
            Case 6
                smes = "07"
            Case 7
                smes = "08"
            Case 9
                smes = "09"
            Case 9
                smes = "10"
            Case 10
                smes = "11"
            Case 11
                smes = "12"
        End Select
        Dim dtCierre As DataTable
        dtCierre = ELTBALMACENBL.SelectCierreMes(cmbAnho.Text, smes)
        If dtCierre.Rows.Count > 0 Then
            For i = 0 To dtCierre.Rows.Count - 1
                If dtCierre.Rows(i).Item(0) = "ALMACEN" Then
                    If dtCierre.Rows(i).Item(1) = "0" Then
                        AlmAbi.Checked = True
                    Else
                        AlmCer.Checked = True
                    End If
                End If

                If dtCierre.Rows(i).Item(0) = "FALLADOS" Then
                    If dtCierre.Rows(i).Item(1) = "0" Then
                        FalAbi.Checked = True
                    Else
                        FalCer.Checked = True
                    End If
                End If

                If dtCierre.Rows(i).Item(0) = "PRODUCCION" Then
                    If dtCierre.Rows(i).Item(1) = "0" Then
                        ProAbi.Checked = True
                    Else
                        ProCer.Checked = True
                    End If
                End If

                If dtCierre.Rows(i).Item(0) = "REINGRESOS" Then
                    If dtCierre.Rows(i).Item(1) = "0" Then
                        ReiAbi.Checked = True
                    Else
                        ReiCer.Checked = True
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim modulo = ""
        Dim estado = "0"
        Dim resp = ""
        Dim anho = cmbAnho.Text
        Dim mes = "00"
        Select Case cmbMes.SelectedIndex
            Case 0
                mes = "01"
            Case 1
                mes = "02"
            Case 2
                mes = "03"
            Case 3
                mes = "04"
            Case 4
                mes = "05"
            Case 5
                mes = "06"
            Case 6
                mes = "07"
            Case 7
                mes = "08"
            Case 8
                mes = "09"
            Case 9
                mes = "10"
            Case 10
                mes = "11"
            Case 11
                mes = "12"
        End Select

        If AlmAbi.Checked = True Then
            estado = "0"
            modulo = "ALMACEN"
        Else
            estado = "1"
            modulo = "ALMACEN"
        End If
        resp = savedata(modulo, estado, anho, mes)


        If ProAbi.Checked = True Then
            estado = "0"
            modulo = "PRODUCCION"
        Else
            estado = "1"
            modulo = "PRODUCCION"
        End If
        resp = savedata(modulo, estado, anho, mes)


        If FalAbi.Checked = True Then
            estado = "0"
            modulo = "FALLADOS"
        Else
            estado = "1"
            modulo = "FALLADOS"
        End If
        resp = savedata(modulo, estado, anho, mes)


        If ReiAbi.Checked = True Then
            estado = "0"
            modulo = "REINGRESOS"
        Else
            estado = "1"
            modulo = "REINGRESOS"
        End If
        resp = savedata(modulo, estado, anho, mes)

        If resp = "OK" Then
            MsgBox("PROCESO COMPLETADO", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Function savedata(ByVal modulo As String, ByVal estado As String, ByVal anho As String, ByVal mes As String) As String
        ELTBALMACENBL.Savedata(modulo, estado, anho, mes)
        Return "OK"
    End Function
End Class