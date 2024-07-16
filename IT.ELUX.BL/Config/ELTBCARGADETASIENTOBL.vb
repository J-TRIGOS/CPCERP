Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBCARGADETASIENTOBL
    Private ELTBCARGADETASIENTODAL As New ELTBCARGADETASIENTODAL

    Public Function SaveRow(ByVal ELTBCARGADETASIENTOBE As ELTBCARGADETASIENTOBE, ByVal flagAccion As String, ByVal Cco_cod As String, ByVal dgtareo As DataGridView) As String
        Return ELTBCARGADETASIENTODAL.SaveRow(ELTBCARGADETASIENTOBE, flagAccion, Cco_cod, dgtareo)
    End Function
End Class
