Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBDETPERCEPBL
    Private ELTBDETPERCEPDAL As New ELTBDETPERCEPDAL
    Public Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal sProv As String)
        Return ELTBDETPERCEPDAL.list1(tdoc, sdoc, ndoc, sProv)
    End Function
    Public Function list2(ByVal sanho As String, ByVal smes As String, ByVal sProv As String)
        Return ELTBDETPERCEPDAL.list2(sanho, smes, sProv)
    End Function
End Class
