Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELPRODUCCIONBL
    Private ELPRODUCCIONDAL As New ELPRODUCCIONDAL
#Region "Lectura de Datos"

    Public Function SelPerAll(ByVal var As String) As DataTable
        Return ELPRODUCCIONDAL.SelPerAll(var)
    End Function
#End Region
    Public Function SelectArtOP(ByVal sCode As String) As DataTable
        Return ELPRODUCCIONDAL.SelectArtOP(sCode)
    End Function
    Public Function SaveRow(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagaccion As String) As String
        Return ELPRODUCCIONDAL.SaveRow(ELPRODUCCIONBE, ELMVLOGSBE, flagaccion)
    End Function
    Public Function SaveRow1(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal flagaccion As String) As String
        Return ELPRODUCCIONDAL.SaveRow1(ELPRODUCCIONBE, flagaccion)
    End Function
    Public Function SaveRow2(ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal flagaccion As String) As String
        Return ELPRODUCCIONDAL.SaveRow2(DET_DOCUMENTOBE, flagaccion)
    End Function
    Public Function SaveRow3(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE,
                             ByVal dgv As DataGridView, ByVal flagaccion As String) As String
        Return ELPRODUCCIONDAL.SaveRow3(ELPRODUCCIONBE, DET_DOCUMENTOBE, dgv, flagaccion)
    End Function
    Public Function SelectMaxLibro() As String
        Return ELPRODUCCIONDAL.SelectMaxLibro()
    End Function
    Public Function SelFact(ByVal art_cod As String) As Double
        Return ELPRODUCCIONDAL.SelFact(art_cod)
    End Function
    Public Function SelFact1(ByVal art_cod As String, ByVal art_cod1 As String) As Double
        Return ELPRODUCCIONDAL.SelFact1(art_cod, art_cod1)
    End Function
    Public Function SelectRow(ByVal sTdoc As String, ByVal sSdoc As String, ByVal sNdoc As String, ByVal sArt As String) As DataTable
        Return ELPRODUCCIONDAL.SelectRow(sTdoc, sSdoc, sNdoc, sArt)
    End Function
    Public Function SelProd(ByVal sAnho As String) As DataTable
        Return ELPRODUCCIONDAL.SelProd(sAnho)
    End Function
    Public Function SelProdNro(ByVal NRO As String) As String
        Return ELPRODUCCIONDAL.SelProdNro(NRO)
    End Function
    Public Function ProdDatos(ByVal sSer As String, ByVal sNro As String) As DataTable
        Return ELPRODUCCIONDAL.ProdDatos(sSer, sNro)
    End Function
    Public Function OrdProg(ByVal sSer As String, ByVal sNro As String, ByVal sART As String) As DataTable
        Return ELPRODUCCIONDAL.OrdProg(sSer, sNro, sART)
    End Function
    Public Function LineaProd(ByVal sSer As String, ByVal sNro As String) As DataTable
        Return ELPRODUCCIONDAL.LineaProd(sSer, sNro)
    End Function
    Public Function LineaMant(ByVal sSer As String, ByVal sNro As String) As DataTable
        Return ELPRODUCCIONDAL.LineaMant(sSer, sNro)
    End Function
    Public Function ProdHor(ByVal sSer As String, ByVal sNro As String) As DataTable
        Return ELPRODUCCIONDAL.ProdHor(sSer, sNro)
    End Function
    Public Function SelectStockArt(ByVal cod_art As String) As String
        Return ELPRODUCCIONDAL.SelectStockArt(cod_art)
    End Function
    Public Function SelNRO(ByVal sCod As String) As String
        Return ELPRODUCCIONDAL.SelNRO(sCod)
    End Function
    Public Function SelNumVal(ByVal sCod As String) As String
        Return ELPRODUCCIONDAL.SelNumVal(sCod)
    End Function
    Public Function SelectMaxTransp() As String
        Return ELPRODUCCIONDAL.SelectMaxTransp()
    End Function
    Public Function SelFec(ByVal cod As String, ByVal nro As String) As DataTable
        Return ELPRODUCCIONDAL.SelFec(cod, nro)
    End Function
    Public Function VerificarRepetido(ByVal cod As String, ByVal nro As String) As DataTable
        Return ELPRODUCCIONDAL.VerificarRepetido(cod, nro)
    End Function
    Public Function VerificarCerrado(ByVal cod As String, ByVal nro As String, ByVal ser As String) As DataTable
        Return ELPRODUCCIONDAL.VerificarCerrado(cod, nro, ser)
    End Function
    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELPRODUCCIONDAL.SelectAll(anho, mes)
    End Function
    Public Function SelectArticuOrden(ByVal cod_art As String) As DataTable
        Return ELPRODUCCIONDAL.SelectArticuOrden(cod_art)
    End Function
    Public Function SelectValidarRepetido(ByVal serie As String, ByVal articulo As String) As DataTable
        Return ELPRODUCCIONDAL.SelectValidarRepetido(serie, articulo)
    End Function
    Public Function SelectComponente(ByVal serie As String, ByVal nro As String, ByVal cod_art As String) As DataTable
        Return ELPRODUCCIONDAL.SelectComponente(serie, nro, cod_art)
    End Function


    Public Function SelectComponenteNiv2(ByVal cod_art As String) As DataTable
        Return ELPRODUCCIONDAL.SelectComponenteNiv2(cod_art)
    End Function

    Public Function list1(ByVal provee As String, ByVal ser_doc As String, ByVal nro_doc As String, ByVal tipomon As String,
                          ByVal cliente As String, ByVal var1 As String, ByVal gen_desde As Date, ByVal gen_hasta As Date)

        Return ELPRODUCCIONDAL.list1(provee, ser_doc, nro_doc, tipomon, cliente, var1, gen_desde, gen_hasta)

    End Function
    Public Function SelectNroAnu(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String) As Int32
        Return ELPRODUCCIONDAL.SelectNroAnu(sTip, sSer, sNro)
    End Function
End Class
