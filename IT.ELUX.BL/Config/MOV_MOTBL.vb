Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class MOV_MOTBL
    Private MOV_MOTDAL As New MOV_MOTDAL
    Public Function SelectMot(ByVal sT_doc As String, ByVal sCode As String) As String
        Return MOV_MOTDAL.SelectMot(sT_doc, sCode)
    End Function
End Class
