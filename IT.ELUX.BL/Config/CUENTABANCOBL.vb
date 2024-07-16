
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class CUENTABANCOBL
    Private CUENTABANCODAL As New CUENTABANCODAL

    Public Function SelectAll() As DataTable
        Return CUENTABANCODAL.SelectAll()
    End Function

    Public Function SaveRow(ByVal CUENTABANCOBE As CUENTABANCOBE, ByVal flagAccion As String) As String
        Return CUENTABANCODAL.SaveRow(CUENTABANCOBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sTDoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Return CUENTABANCODAL.SelectRow(sTDoc, sSDoc, sNDoc)
    End Function

    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String, ByVal Code3 As String) As Boolean
        Return CUENTABANCODAL.VerificarRepetido(Code, Code2, Code3)
    End Function
    Public Function SelectbancoCOD(ByVal codigo As String) As DataTable
        Return CUENTABANCODAL.SelectbancoCOD(codigo)
    End Function
    Public Function SelectedBanco() As DataTable
        Return CUENTABANCODAL.SelectedBanco()
    End Function
End Class

