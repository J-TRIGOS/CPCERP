
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELCERTIFICABL
    Private ELCERTIFICADAL As New ELCERTIFICADAL

    Public Function SelGuiaAll() As DataTable
        Return ELCERTIFICADAL.SelGuiaAll()
    End Function
    Public Function SelEasyPeelAll() As DataTable
        Return ELCERTIFICADAL.SelEasyAll()
    End Function
    Public Function SeltapaplastAll() As DataTable
        Return ELCERTIFICADAL.SelTapaPlasAll()
    End Function
    Public Function SelTapaTeleAll() As DataTable
        Return ELCERTIFICADAL.SelTapaTeleAll()
    End Function

    Public Function SelectGuias(ByVal Nroguia As String, ByVal Nroserie As String) As DataTable
        Return ELCERTIFICADAL.SelectGuias(Nroguia, Nroserie)
    End Function
    Public Function SelectMaxTransp() As String
        Return ELCERTIFICADAL.SelectMaxTransp()
    End Function
    Public Function SelectRowCountP() As String
        Return ELCERTIFICADAL.SelectRowCountP()
    End Function
    Public Function SelectRowCountT() As String
        Return ELCERTIFICADAL.SelectRowCountT()
    End Function
    Public Function SelectRowCount() As String
        Return ELCERTIFICADAL.SelectRowCount()
    End Function

    Public Function SelectGetData(ByVal Nroguia As String, ByVal Nroserie As String) As String
        Return ELCERTIFICADAL.SelectGetData(Nroguia, Nroserie)
    End Function
    Public Function SelectGetLote(ByVal Nroguia As String) As String
        Return ELCERTIFICADAL.SelectGetLote(Nroguia)
    End Function
    Public Function SelectRowEasy(ByVal sNDoc As String) As DataTable
        Return ELCERTIFICADAL.SelectRowEasy(sNDoc)
    End Function

    Public Function SelectRowPlast(ByVal sNDoc As String) As DataTable
        Return ELCERTIFICADAL.SelectRowPlast(sNDoc)
    End Function

    Public Function SelectRowTeles(ByVal sNDoc As String) As DataTable
        Return ELCERTIFICADAL.SelectRowTeles(sNDoc)
    End Function
    Public Function SelectGetDataEasy(ByVal producto As String) As String
        Return ELCERTIFICADAL.SelectGetDataEasy(producto)
    End Function
    Public Function SelectGetDataTapaPlas(ByVal producto As String) As String
        Return ELCERTIFICADAL.SelectGetDataTapaPlas(producto)
    End Function
    Public Function SelectGetDataTapaTel(ByVal producto As String) As String
        Return ELCERTIFICADAL.SelectGetDataTapaTel(producto)
    End Function
    Public Function SaveRow(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal Tpaquete As String) As String
        Return ELCERTIFICADAL.SaveRow(ELCERTIFICABE, flagAccion, Tpaquete)
    End Function
    Public Function SaveRow2(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal Tpaquete As String) As String
        Return ELCERTIFICADAL.InsertRow2(ELCERTIFICABE, flagAccion, Tpaquete)
    End Function
    Public Function SaveRow3(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal Tpaquete As String) As String
        Return ELCERTIFICADAL.InsertRow3(ELCERTIFICABE, flagAccion, Tpaquete)
    End Function
    Public Function SaveRow4(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal Tpaquete As String) As String
        Return ELCERTIFICADAL.InsertRow4(ELCERTIFICABE, flagAccion, Tpaquete)
    End Function
    Public Function SelectRow(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Return ELCERTIFICADAL.SelectRow(sTDoc, sSDoc, sNDoc)
    End Function
    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELCERTIFICADAL.SelectAll(anho, mes)
    End Function
    '-----------------------------------------------------------------------------------
    Public Function SelGuiaTwo() As DataTable
        Return ELCERTIFICADAL.SelGuiaTwo()
    End Function
    Public Function SelectAl2(ByVal sNroD As String, ByVal sSerD As String) As DataTable
        Return ELCERTIFICADAL.SelectAl2(sNroD, sSerD)
    End Function
    Public Function SelectAl3(ByVal sTDoc As String, ByVal sSerD As String, ByVal sNroD As String) As DataTable
        Return ELCERTIFICADAL.SelectAl3(sTDoc, sSerD, sNroD)
    End Function
    Public Function SelectAl4(ByVal sTDoc As String, ByVal sSerD As String, ByVal sNroD As String, ByVal sArtD As String) As DataTable
        Return ELCERTIFICADAL.SelectAl4(sTDoc, sSerD, sNroD, sArtD)
    End Function
    Public Function SelectInc() As String
        Return ELCERTIFICADAL.SelectInc()
    End Function
    Public Function SelectArt(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As DataTable
        Return ELCERTIFICADAL.SelectArt(sNroD, sSerD, sArt)
    End Function
    Public Function SelectOk(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As String
        Return ELCERTIFICADAL.SelectOk(sNroD, sSerD, sArt)
    End Function
    Public Function list1(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String, ByVal sTwoE As String) As DataTable
        Return ELCERTIFICADAL.list1(sNroD, sSerD, sArt, sTwoE)
    End Function
    Public Function SaveRowTwo(ByVal ELCERTIFICABE As ELCERTIFICABE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELCERTIFICADAL.SaveRowTwo(ELCERTIFICABE, flagAccion, dg)
    End Function
    Public Function SelectCon(ByVal sTipo As String, ByVal sSer As String, ByVal sNro As String, ByVal sDiam As String, ByVal sAct As String, ByVal sArt As String) As DataTable
        Return ELCERTIFICADAL.SelectCon(sTipo, sSer, sNro, sDiam, sAct, sArt)
    End Function
    'Public Function SelectLote() As DataTable
    '    Return ELCERTIFICADAL.SelectLote()
    'End Function
End Class

