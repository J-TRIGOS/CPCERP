
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBCLIENTEBL
    Private ELTBCLIENTEDAL As New ELTBCLIENTEDAL

    Public Function SelectAll() As DataTable
        Return ELTBCLIENTEDAL.SelectAll()
    End Function

    Public Function SelectMaxTransp() As String
        Return ELTBCLIENTEDAL.SelectMaxTransp()
    End Function

    Public Function SaveRow(ByVal ELTBCLIENTEBE As ELTBCLIENTEBE, ByVal flagAccion As String, ByVal dgdir As DataGridView, ByVal dgcor As DataGridView, ByVal dgtel As DataGridView, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
        Return ELTBCLIENTEDAL.SaveRow(ELTBCLIENTEBE, flagAccion, dgdir, dgcor, dgtel, ELMVLOGSBE)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBCLIENTEDAL.SelectRow(sCode)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Return ELTBCLIENTEDAL.SelectRowGrid(sCode, sOpcion)
    End Function
    Public Function SelectUbigeo() As DataTable
        Return ELTBCLIENTEDAL.SelectUbigeo()
    End Function
    Public Function SelectUbiDpto(ByVal sCode As String) As String
        Return ELTBCLIENTEDAL.SelectUbiDpto(sCode)
    End Function
    Public Function SelectUbiNom(ByVal sCode As String) As String
        Return ELTBCLIENTEDAL.SelectUbiNom(sCode)
    End Function
    Public Function SelectUbigeonacdpt(ByVal sCode As String) As String
        Return ELTBCLIENTEDAL.SelectUbigeonacdpt(sCode)
    End Function
    Public Function SelectUbigeonacprov(ByVal sCode As String) As String
        Return ELTBCLIENTEDAL.SelectUbigeonacprov(sCode)
    End Function
    Public Function SelectUbigeonacNom(ByVal sCode As String) As String
        Return ELTBCLIENTEDAL.SelectUbigeonacNom(sCode)
    End Function
    Public Function SelectUbigeoNaci() As DataTable
        Return ELTBCLIENTEDAL.SelectUbigeonaci()
    End Function
    Public Function SelectVendedor() As DataTable
        Return ELTBCLIENTEDAL.SelectVendedor()
    End Function
    Public Function VerificarLinea(ByVal sCode As String) As String
        Return ELTBCLIENTEDAL.VerificarLinea(sCode)
    End Function
    Public Function SelectCondiPago() As DataTable
        Return ELTBCLIENTEDAL.SelectCondiPago()
    End Function
    Public Function SelectPais() As DataTable
        Return ELTBCLIENTEDAL.SelectPais()
    End Function
    Public Function SelectPaisCod(ByVal sCode As String) As DataTable
        Return ELTBCLIENTEDAL.SelectPaisCod(sCode)
    End Function
    Public Function SelectUbigeoCod(ByVal sCode As String) As DataTable
        Return ELTBCLIENTEDAL.SelectUbigeoCod(sCode)
    End Function
    Public Function SelectCiuuCod(ByVal sCode As String) As DataTable
        Return ELTBCLIENTEDAL.SelectCiuuCod(sCode)
    End Function
    Public Function SelectBloq() As DataTable
        Return ELTBCLIENTEDAL.SelectBloq()
    End Function
    Public Function SelectActi_Serv() As DataTable
        Return ELTBCLIENTEDAL.SelectActi_Serv()
    End Function
    Public Function SelectCIIU() As DataTable
        Return ELTBCLIENTEDAL.SelectCIIU()
    End Function
    Public Function VerificarRepetido(ByVal Anio As String) As Boolean
        Return ELTBCLIENTEDAL.VerificarRepetido(Anio)
    End Function
    Public Function VerificarCliente(ByVal sBloq As String) As String
        Return ELTBCLIENTEDAL.VerificarCliente(sBloq)
    End Function
    Public Function SelectCondicionCod(ByVal sCode As String) As DataTable
        Return ELTBCLIENTEDAL.SelectCondicionCod(sCode)
    End Function
    Public Function SelCliEmailCor(ByVal sCode As String) As String
        Return ELTBCLIENTEDAL.SelCliEmailCor(sCode)
    End Function
    Public Function SelectVendeCod(ByVal sCode As String) As DataTable
        Return ELTBCLIENTEDAL.SelectVendeCod(sCode)
    End Function
End Class

