Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class FormBUSQSELECTMULTBL
    Private FormBUSQSELECTMULTDAL As New FormBUSQSELECTMULTDAL
    Public Function list1Fardo(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal nfardo As String) As DataTable
        Return FormBUSQSELECTMULTDAL.list1Fardo(tdoc, sdoc, ndoc, nfardo)
    End Function
    Public Function list2Fardo(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal nart As String) As DataTable
        Return FormBUSQSELECTMULTDAL.list2Fardo(tdoc, sdoc, ndoc, nart)
    End Function
End Class
