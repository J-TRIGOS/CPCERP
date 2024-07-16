Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class T_MOVINVBL
    Private T_MOVINVDAL As New T_MOVINVDAL
#Region "Lectura de Datos"

#Region "SQL"

    Public Function SelectAll() As DataTable

        Return T_MOVINVDAL.SelectAll()

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return T_MOVINVDAL.SelectRow(sCode)
    End Function



    Public Function Select_TMOVINV() As DataTable
        Return T_MOVINVDAL.Select_TMOVINV()
    End Function
#End Region

#End Region

#Region "Grabar Datos"


    Public Function SaveRow(ByVal ELTBTRANBE As T_MOVINVBE, ByVal flagAccion As String) As String

        Return T_MOVINVDAL.SaveRow(ELTBTRANBE, flagAccion)

    End Function

    Public Function ReporteKardex(ByVal flagAccion As String, ByVal sAño As String, ByVal sSubLinea As String, ByVal sCodAlm As String, ByVal estInv As String) As String
        'Verifica el kardex
        Return T_MOVINVDAL.ReporteKardex(flagAccion, sAño, sSubLinea, sCodAlm, estInv)
    End Function

    Public Function ReporteKardex1(ByVal flagAccion As String, ByVal sAño As String, ByVal sAño1 As String,
                                    ByVal sFEC As String, ByVal sFEC1 As String, ByVal sCodAlm As String,
                                   ByVal sSUBLINEA As String) As String
        'Verifica el kardex
        Return T_MOVINVDAL.ReporteKardex1(flagAccion, sAño, sAño1, sFEC, sFEC1, sCodAlm, sSUBLINEA)
    End Function

    Public Function ReporteConsumos(ByVal flagAccion As String, ByVal sAño As String, ByVal AnchoMin As String, ByVal AnchoMax As String,
                            ByVal LargoMin As String, ByVal LargoMax As String, ByVal TmpMin As String,
                            ByVal TmpMax As String, ByVal EspMin As String, ByVal EspMax As String) As String
        'Verifica el kardex
        Return T_MOVINVDAL.ReporteConsumos(flagAccion, sAño, AnchoMin, AnchoMax, LargoMin, LargoMax, TmpMin, TmpMax, EspMin, EspMax)
    End Function

    Public Function BuscarFechaCorte(ByVal mes As String, ByVal manho As String, ByVal sublinea As String, ByVal ALMACEN As String, ByVal linea As String) As DataTable

        Return T_MOVINVDAL.BuscarFechaCorte(mes, manho, sublinea, ALMACEN, linea)

    End Function
#End Region
End Class
