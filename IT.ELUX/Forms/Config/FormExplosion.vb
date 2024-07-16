Imports System.ComponentModel
Imports IT.ELUX.BL

Public Class FormExplosion

    Private ARTICULOBL As New ARTICULOBL
    Private ELETIQUETABL As New ELETIQUETABL
    Private dtExplComponente As DataTable

    Private Sub FormExplosion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'explosion de materiales
        Dim dtExplosion As New DataTable

        dtExplosion = ARTICULOBL.getListdgv1(gsCode)


        dtExplComponente = New DataTable("TableName")

        Dim column1 As DataColumn = New DataColumn("CodArt")
        column1.DataType = System.Type.GetType("System.String")

        Dim column2 As DataColumn = New DataColumn("CodComp")
        column2.DataType = System.Type.GetType("System.String")

        Dim column3 As DataColumn = New DataColumn("Tipo")
        column3.DataType = System.Type.GetType("System.String")

        Dim column4 As DataColumn = New DataColumn("Componente")
        column4.DataType = System.Type.GetType("System.String")
        '   Dim column3 As DataColumn = New DataColumn("Column3")
        '   column3.DataType = System.Type.GetType("System.String")

        dtExplComponente.Columns.Add(column1)
        dtExplComponente.Columns.Add(column2)
        dtExplComponente.Columns.Add(column3)
        dtExplComponente.Columns.Add(column4)

        'dtExplComponente.Rows.Add("02170001", "01010001", "01")

        'Explotar(gsCode, dtExplosion)

        'showExplosion()
        Dim dt As DataTable
        Dim s As String = ""
        dt = ELETIQUETABL.SelectArticuloCOD(gsCode)
        If dt.Rows.Count > 0 Then
            s = dt.Rows(0).Item(1).ToString
        End If
        fnRecursiva(gsCode, gsCode + " - " + s, Nothing, 0)
        tvwExplosion.ExpandAll()
    End Sub
    Private Sub fnRecursiva(ByVal Key As String, ByVal Txt As String, ByVal N As TreeNode, ByVal tipo As Integer)
        Dim NN As TreeNode
        Dim sTipo As String
        Dim dtDataTable As DataTable
        If N Is Nothing Then
            NN = tvwExplosion.Nodes.Add(Key, Txt, tipo, tipo)
        Else
            NN = N.Nodes.Add(Key, Txt, tipo, tipo)
        End If

        dtDataTable = ARTICULOBL.getListdgv1(Key)
        For Each row As DataRow In dtDataTable.Rows
            sTipo = CStr(row("tipo"))
            Dim nTipo As Integer = Val(sTipo)
            'sComponente = CStr(row("Componente"))
            fnRecursiva(Mid(row("CODIGO"), 1, 8), row("CODIGO"), NN, nTipo)
        Next row
    End Sub
    Private Sub showExplosion()
        Dim sCode As String = ""
        Dim sChild As String
        Dim sTipo As String
        Dim sComponente As String

        With tvwExplosion

            For Each datarow In dtExplComponente.Rows

                'add parent
                sCode = CStr(datarow("CodArt"))
                sChild = CStr(datarow("CodComp"))
                sTipo = CStr(datarow("tipo"))
                sComponente = CStr(datarow("Componente"))
                Dim nTipo As Integer = Val(sTipo)

                Dim tns() As TreeNode
                tns = .Nodes.Find(sCode, True)

                If tns.Length = 0 Then

                    .Nodes.Add(sCode, sCode)
                    .Nodes(sCode).Nodes.Add(sChild, sChild + " - " + sComponente, nTipo, nTipo)
                Else

                    tns(0).Nodes.Add(sChild, sChild + " - " + sComponente, nTipo, nTipo)
                End If


            Next
        End With
        tvwExplosion.ExpandAll()
    End Sub

    Private Sub Explotar(ByVal sCodArt As String, ByVal dtExp As DataTable)
        Dim sTipo As String
        Dim sCodComp As String
        Dim sComponente As String

        'barrer dt
        For i = 0 To dtExp.Rows.Count - 1
            sTipo = dtExp.Rows(i).Item(0)
            sCodComp = Mid(dtExp.Rows(i).Item(1), 1, 8)
            sComponente = Mid(dtExp.Rows(i).Item(1), 11)

            dtExplComponente.Rows.Add(sCodArt, sCodComp, sTipo, sComponente)

            'recursivo
            Dim dtComp As New DataTable
            dtComp = ARTICULOBL.getListdgv1(sCodComp)
            Explotar(sCodComp, dtComp)
        Next

    End Sub

    Private Sub FormExplosion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class