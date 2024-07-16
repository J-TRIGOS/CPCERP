
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBPROVEEDORESBL
    Private ELTBPROVEEDORESDAL As New ELTBPROVEEDORESDAL

    Public Function SelectAll() As DataTable
        Return ELTBPROVEEDORESDAL.SelectAll()
    End Function


    Public Function SaveRow(ByVal ELTBPROVEEDORESBE As ELTBPROVEEDORESBE, ByVal flagAccion As String, ByVal dgdir As DataGridView, ByVal dgcor As DataGridView, ByVal dgtel As DataGridView) As String
        Return ELTBPROVEEDORESDAL.SaveRow(ELTBPROVEEDORESBE, flagAccion, dgdir, dgcor, dgtel)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBPROVEEDORESDAL.SelectRow(sCode)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Return ELTBPROVEEDORESDAL.SelectRowGrid(sCode, sOpcion)
    End Function
    Public Function SelectUbigeo() As DataTable
        Return ELTBPROVEEDORESDAL.SelectUbigeo()
    End Function
    Public Function SelectVendedor() As DataTable
        Return ELTBPROVEEDORESDAL.SelectVendedor()
    End Function
    Public Function SelectActi_Serv() As DataTable
        Return ELTBPROVEEDORESDAL.SelectActi_Serv()
    End Function
End Class

