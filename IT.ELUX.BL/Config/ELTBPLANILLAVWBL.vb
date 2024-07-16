Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBPLANILLAVWBL
    Private ELTBPLANILLAVWDAL As New ELTBPLANILLAVWDAL
    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBPLANILLAVWDAL.SelectRow(sCode)
    End Function
    Public Function SelectRow2(ByVal sCode As String) As DataTable
        Return ELTBPLANILLAVWDAL.SelectRow2(sCode)
    End Function
    Public Function SelectRow3(ByVal sCode As String) As DataTable
        Return ELTBPLANILLAVWDAL.SelectRow3(sCode)
    End Function
    Public Function SelectRow4(ByVal sCode As String) As DataTable
        Return ELTBPLANILLAVWDAL.SelectRow4(sCode)
    End Function
    Public Function SelectRow5(ByVal sCode As String) As DataTable
        Return ELTBPLANILLAVWDAL.SelectRow5(sCode)
    End Function
    Public Function SelectRow6(ByVal sCode As String) As DataTable
        Return ELTBPLANILLAVWDAL.SelectRow6(sCode)
    End Function
    Public Function SelectRow7(ByVal sCode As String) As DataTable
        Return ELTBPLANILLAVWDAL.SelectRow7(sCode)
    End Function
    Public Function SelectRow8(ByVal sCode As String) As DataTable
        Return ELTBPLANILLAVWDAL.SelectRow8(sCode)
    End Function
    Public Function SelectRow9(ByVal sCode As String) As DataTable
        Return ELTBPLANILLAVWDAL.SelectRow9(sCode)
    End Function
    Public Function SelectRow10(ByVal sCode As String) As DataTable
        Return ELTBPLANILLAVWDAL.SelectRow10(sCode)
    End Function
End Class
