Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBALMACENBL

    Private ELTBALMACENDAL As New ELTBALMACENDAL

#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    Public Function LastCodigo() As String

        Return ELTBALMACENDAL.LastCodigo()

    End Function

    Public Function SelectAll() As DataTable

        Return ELTBALMACENDAL.SelectAll()

    End Function

    Public Function SelectAll1() As DataTable

        Return ELTBALMACENDAL.SelectAll1()

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBALMACENDAL.SelectRow(sCode)

    End Function


    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region

#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBALMACENBE As ELTBALMACENBE, ByVal flagAccion As String) As String

        Return ELTBALMACENDAL.SaveRow(ELTBALMACENBE, flagAccion)

    End Function

#End Region

    Public Function SelectCierreMes(ByVal manho As String, ByVal mmes As String) As DataTable

        Return ELTBALMACENDAL.SelectCierreMes(manho, mmes)

    End Function

    Public Function Savedata(ByVal modulo As String, ByVal estado As String, ByVal anho As String, ByVal mes As String) As String

        Select Case modulo
            Case "ALMACEN"
                Return ELTBALMACENDAL.SavedataAlmacen(modulo, estado, anho, mes)
            Case "PRODUCCION"
                Return ELTBALMACENDAL.SavedataAProduccion(modulo, estado, anho, mes)
            Case "REINGRESOS"
                Return ELTBALMACENDAL.SavedataReingresos(modulo, estado, anho, mes)
            Case "FALLADOS"
                Return ELTBALMACENDAL.SavedataFallados(modulo, estado, anho, mes)
        End Select

    End Function

End Class
