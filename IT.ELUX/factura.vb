Imports System.ComponentModel
Imports IT.ELUX.BE
Imports IT.ELUX.BL
Imports System
Imports System.Windows.Forms
Imports IT.ELUX.EBIPaWebServices

Namespace EjemploIntegraciondirectaCSharp
    Public Class CufeDocs

    End Class
    Public Class DatosDocs
        Public Property CSE As String
        Public Property NDF As String
        Public Property PFF As String
        Public Property SDS As String
        Public Property TDC As String
        Public Property TEM As String

    End Class
    Public Class VariosItems
        Public Property Descripcion As String
        Public Property Codigo As String
        Public Property UnidadMedida As String
        Public Property Cantidad As String
        Public Property FechaFabricacion As String
        Public Property FechaCaducidad As String
        Public Property CodigoCPBSAbrev As String
        Public Property CodigoCPBS As String
        Public Property UnidadMedidaCPBS As String
        Public Property InfoItem As String
        Public Property PrecioUnitario As String
        Public Property PrecioUnitarioDescuento As String
        Public Property PrecioItem As String
        Public Property PrecioAcarreo As String
        Public Property PrecioSeguro As String
        Public Property ValorTotal As String
        Public Property CodigoGTIN As String
        Public Property CantGTINCom As String
        Public Property CodigoGTINInv As String
        Public Property CantGTINComInv As String
        Public Property TasaITBMS As String
        Public Property ValorITBMS As String
    End Class
    Public Class DemoIntCSharpEBI
        ' Prueba
        'Public Const tokenEmpresax As String = "dqrprfsmtdyi_ebi"
        'Public Const tokenPasswordx As String = "q9,;F+89;cye"
        ' Produccion
        Public Const tokenEmpresax As String = "isgeghhxsmkh_ebi"
        Public Const tokenPasswordx As String = "*9!;M!!hhj/h"
        Public Shared ELTBFACTURAELBL As New ELTBFACTURAELBL
        Public Shared xDoc As String
        Public Shared xNum As String
        Public Shared xSer As String
        Public Shared xStf As String
        Public Shared xCtc As String

        Public Shared Sub Main()

            Try
                Dim DatosDocs As DatosDocs = DatosDocumentox.ArmarDocs()
                '---------------------------------------------------------------------

                Dim webService As ServiceClient = New ServiceClient()
                Dim numero = xNum  'Aqui hay que capturar el numero de la factura...!!!!!!!

                Dim documento As DocumentoElectronico = Factura.armarFactura(numero)

                Dim respuestaWebService As EnviarResponse = New EnviarResponse()
                respuestaWebService = webService.Enviar(tokenEmpresax, tokenPasswordx, documento)

                Dim dd, dd1 As String
                dd = respuestaWebService.resultado
                dd1 = respuestaWebService.mensaje

                FormFactElect.txttexto.Text = dd + " Codigo " + respuestaWebService.codigo + "  " + dd1
                MessageBox.Show(dd + " Codigo " + respuestaWebService.codigo + Chr(13) + respuestaWebService.cufe + dd1)

                DatosCUFE.Cufe(respuestaWebService.cufe)

                FormFactElect.txttexto.Text = respuestaWebService.cufe
                FormFactElect.txttexto.Text = respuestaWebService.qr

                If respuestaWebService.codigo Is "200" Then

                    Process.Start(respuestaWebService.qr)
                End If

            Catch ex As Exception
                Dim dd As String
                dd = ex.Message
                FormFactElect.txttexto.Text = dd
                MessageBox.Show(dd, dd, MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
            End Try
        End Sub

    End Class

    Public Class Factura
        Public Shared factura As DocumentoElectronico = New DocumentoElectronico()
        Public Shared Function armarFactura(ByVal numero As String) As DocumentoElectronico
            Dim dTItems As DataTable

            factura.codigoSucursalEmisor = "0000"
            factura.tipoSucursal = "2"
            Dim datos As DatosFactura = New DatosFactura()
            Dim datosFactura As datosTransaccion = datos.crearDatosFactura(numero)
            factura.datosTransaccion = datosFactura
            factura.listaItems = New listaItems()

            dTItems = DemoIntCSharpEBI.ELTBFACTURAELBL.SelectItems(DemoIntCSharpEBI.xDoc, DemoIntCSharpEBI.xNum, DemoIntCSharpEBI.xSer, DemoIntCSharpEBI.xStf, DemoIntCSharpEBI.xCtc)

            Dim i As Integer = 0

            Do While i < dTItems.Rows.Count
                Dim nItems As New VariosItems()
                nItems.Descripcion = dTItems.Rows(i)("Descripcion").ToString()
                nItems.Codigo = dTItems.Rows(i)("Codigo").ToString()
                nItems.UnidadMedida = dTItems.Rows(i)("UnidadMedida").ToString()
                nItems.Cantidad = dTItems.Rows(i)("Cantidad").ToString()
                nItems.FechaFabricacion = dTItems.Rows(i)("FechaFabricacion").ToString()
                nItems.FechaCaducidad = dTItems.Rows(i)("FechaCaducidad").ToString()
                nItems.CodigoCPBSAbrev = dTItems.Rows(i)("CodigoCPBSAbrev").ToString()
                nItems.CodigoCPBS = dTItems.Rows(i)("CodigoCPBS").ToString()
                nItems.UnidadMedidaCPBS = dTItems.Rows(i)("UnidadMedidaCPBS").ToString()
                nItems.InfoItem = dTItems.Rows(i)("InfoItem").ToString()
                nItems.PrecioUnitario = dTItems.Rows(i)("PrecioUnitario").ToString()
                nItems.PrecioUnitarioDescuento = dTItems.Rows(i)("PrecioUnitarioDescuento").ToString()
                nItems.PrecioItem = dTItems.Rows(i)("PrecioItem").ToString()
                nItems.PrecioAcarreo = dTItems.Rows(i)("PrecioAcarreo").ToString()
                nItems.PrecioSeguro = dTItems.Rows(i)("PrecioSeguro").ToString()
                nItems.ValorTotal = dTItems.Rows(i)("ValorTotal").ToString()
                nItems.CodigoGTIN = dTItems.Rows(i)("CodigoGTIN").ToString()
                nItems.CantGTINCom = dTItems.Rows(i)("CantGTINCom").ToString()
                nItems.CodigoGTINInv = dTItems.Rows(i)("CodigoGTINInv").ToString()
                nItems.CantGTINComInv = dTItems.Rows(i)("CantGTINComInv").ToString()
                nItems.TasaITBMS = dTItems.Rows(i)("TasaITBMS").ToString()
                nItems.ValorITBMS = dTItems.Rows(i)("ValorITBMS").ToString()

                factura.listaItems.Add(Producto.crearItem(nItems))
                i += 1
            Loop

            factura.totalesSubTotales = Totales.generarTotales()
            factura.pedidoComercialGlobal = Pedido.nroPedidoCompraGlobal()
            Return factura
        End Function

    End Class

    Public Class cliente
        Public Shared Cliente As New EBIPaWebServices.cliente()
        Public Shared Function crearCliente() As EBIPaWebServices.cliente
            Dim dTCliente As DataTable
            dTCliente = DemoIntCSharpEBI.ELTBFACTURAELBL.SelectCliente(DemoIntCSharpEBI.xDoc, DemoIntCSharpEBI.xNum, DemoIntCSharpEBI.xSer, DemoIntCSharpEBI.xStf, DemoIntCSharpEBI.xCtc)

            For Each filas In dTCliente.Rows
                Cliente.tipoClienteFE = filas("TipoClienteFE")
                Cliente.tipoContribuyente = filas("TipoContribuyente")
                Cliente.numeroRUC = filas("NumeroRuc")
                Cliente.digitoVerificadorRUC = filas("DigitoVerificadorRuc")
                Cliente.razonSocial = filas("RazonSocial")
                Cliente.direccion = filas("Direccion")
                Cliente.codigoUbicacion = filas("CodigoUbicacion")
                Cliente.provincia = filas("Provincia")
                Cliente.distrito = filas("Distrito")
                Cliente.corregimiento = filas("Corregimiento")
                Cliente.tipoIdentificacion = filas("TipoIdentificacion")
                Cliente.nroIdentificacionExtranjero = filas("NroIdentificacionExtranjero")
                Cliente.paisExtranjero = filas("PaisExtranjero")
                Cliente.telefono1 = filas("Telefono1")
                Cliente.telefono2 = filas("Telefono2")
                Cliente.telefono3 = filas("Telefono3")
                Cliente.correoElectronico1 = filas("CorreoElectronico1")
                Cliente.correoElectronico2 = filas("CorreoElectronico2")
                Cliente.pais = filas("Pais")
                Cliente.paisOtro = filas("PaisOtro")
            Next
            Return Cliente

        End Function
    End Class

    ' Para la OC...
    Public Class Pedido
        Public Shared datocomercial As pedidoComercialGlobal = New pedidoComercialGlobal()
        Public Shared Function nroPedidoCompraGlobal() As pedidoComercialGlobal

            datocomercial.nroPedidoCompraGlobal = FormMantFacturacion.txtoc.Text

            Return datocomercial
        End Function
    End Class
    Public Class DatosFactura
        Public Shared datosFactura As datosTransaccion = New datosTransaccion()

        Public Function crearDatosFactura(ByVal num As String) As datosTransaccion
            Dim dTFactura As DataTable
            dTFactura = DemoIntCSharpEBI.ELTBFACTURAELBL.SelectFactura(DemoIntCSharpEBI.xDoc, DemoIntCSharpEBI.xNum, DemoIntCSharpEBI.xSer, DemoIntCSharpEBI.xStf, DemoIntCSharpEBI.xCtc)

            For Each filas In dTFactura.Rows
                datosFactura.tipoEmision = filas("TipoEmision")
                datosFactura.tipoDocumento = filas("TipoDocumento")
                datosFactura.numeroDocumentoFiscal = filas("NumeroDocumentoFiscal")
                datosFactura.puntoFacturacionFiscal = filas("PuntoFacturacionFiscal")
                'Dim fechaEmision = Convert.ToDateTime(DateTime.Today.ToString("dd-MM-yyyy")).ToString("yyyy-MM-ddTHH:mm:ss-05:00")
                datosFactura.fechaEmision = filas("FechaEmision")
                datosFactura.fechaSalida = filas("FechaSalida")
                datosFactura.naturalezaOperacion = filas("NaturalezaOperacion")
                datosFactura.tipoOperacion = filas("TipoOperacion")
                datosFactura.destinoOperacion = filas("DestinoOperacion")
                datosFactura.formatoCAFE = filas("FormatoCAFE")
                datosFactura.entregaCAFE = filas("EntregaCAFE")
                datosFactura.envioContenedor = filas("EnvioContenedor")
                datosFactura.procesoGeneracion = filas("ProcesoGeneracion")
                datosFactura.tipoVenta = filas("TipoVenta")
                datosFactura.informacionInteres = filas("Observa")
                datosFactura.cliente = cliente.crearCliente()

                If String.IsNullOrEmpty(filas("DigitoVerificadorRuc")) Or filas("DigitoVerificadorRuc") = 0 Then ' Si no tiene DV no es Nacional es de Exportación
                    datosFactura.datosFacturaExportacion = DatosFE.datos()
                End If

                If DemoIntCSharpEBI.xDoc = "07" Then 'Nota de Credito

                    If filas("CUFE") Is Nothing Then
                        MessageBox.Show("Falta Cufe")
                    End If

                    datosFactura.listaDocsFiscalReferenciados = New listaDocsFiscalReferenciados()
                    Dim listaDocs As docFiscalReferenciado = New docFiscalReferenciado()
                    listaDocs.fechaEmisionDocFiscalReferenciado = filas("FechaCufe")
                    listaDocs.cufeFEReferenciada = filas("CUFE")
                    listaDocs.nroFacturaPapel = ""
                    listaDocs.nroFacturaImpFiscal = ""
                    datosFactura.listaDocsFiscalReferenciados.Add(listaDocs)
                End If

                If DemoIntCSharpEBI.xDoc = "08" Then 'Nota de Debito

                    If filas("CUFE") Is Nothing Then
                        MessageBox.Show("Falta Cufe")
                    End If

                    datosFactura.listaDocsFiscalReferenciados = New listaDocsFiscalReferenciados()
                    Dim listaDocs As docFiscalReferenciado = New docFiscalReferenciado()
                    listaDocs.fechaEmisionDocFiscalReferenciado = filas("FechaCufe")
                    listaDocs.cufeFEReferenciada = filas("CUFE")
                    listaDocs.nroFacturaPapel = ""
                    listaDocs.nroFacturaImpFiscal = ""
                    datosFactura.listaDocsFiscalReferenciados.Add(listaDocs)
                End If
            Next

            Return datosFactura
        End Function
    End Class

    Public Class Producto
        Public Shared item As Item = New Item()
        Public Shared Function crearItem(cItems As VariosItems) As Item
            Dim item As Item = New Item()
            item.descripcion = cItems.Descripcion
            item.codigo = cItems.Codigo
            item.unidadMedida = cItems.UnidadMedida
            item.cantidad = cItems.Cantidad
            item.fechaFabricacion = cItems.FechaFabricacion
            item.fechaCaducidad = cItems.FechaCaducidad
            item.codigoCPBSAbrev = cItems.CodigoCPBSAbrev
            item.codigoCPBS = "" 'cItems.CodigoCPBS
            item.unidadMedidaCPBS = cItems.UnidadMedidaCPBS
            item.infoItem = cItems.InfoItem
            item.precioUnitario = cItems.PrecioUnitario
            item.precioUnitarioDescuento = cItems.PrecioUnitarioDescuento
            item.precioAcarreo = cItems.PrecioAcarreo
            item.precioSeguro = cItems.PrecioSeguro
            item.precioItem = cItems.PrecioItem
            item.valorTotal = cItems.ValorTotal
            item.codigoGTIN = cItems.CodigoGTIN
            item.cantGTINCom = cItems.CantGTINCom
            item.codigoGTINInv = cItems.CodigoGTINInv
            item.cantGTINComInv = cItems.CantGTINComInv
            item.tasaITBMS = cItems.TasaITBMS
            item.valorITBMS = cItems.ValorITBMS

            Return item
        End Function
    End Class

    Public Class Totales
        Public Shared TotalesSubTotales As totalesSubTotales = New totalesSubTotales()
        Public Shared Function generarTotales() As totalesSubTotales
            Dim dTSubtotales As DataTable
            dTSubtotales = DemoIntCSharpEBI.ELTBFACTURAELBL.SelectSubtotales(DemoIntCSharpEBI.xDoc, DemoIntCSharpEBI.xNum, DemoIntCSharpEBI.xSer, DemoIntCSharpEBI.xStf, DemoIntCSharpEBI.xCtc)

            For Each filas In dTSubtotales.Rows
                TotalesSubTotales.totalPrecioNeto = filas("TotalPrecioNeto")
                TotalesSubTotales.totalITBMS = filas("TotalITBMS")
                '   TotalesSubTotales.totalISC = filas("TotalISC")
                TotalesSubTotales.totalMontoGravado = filas("TotalMontoGravado")
                TotalesSubTotales.totalDescuento = filas("TotalDescuento")
                TotalesSubTotales.totalAcarreoCobrado = filas("TotalAcarreoCobrado")
                TotalesSubTotales.valorSeguroCobrado = filas("ValorSeguroCobrado")
                TotalesSubTotales.totalFactura = filas("TotalFactura")
                TotalesSubTotales.totalValorRecibido = filas("TotalValorRecibido")
                TotalesSubTotales.vuelto = "0.00"
                TotalesSubTotales.tiempoPago = filas("TiempoPago")
                TotalesSubTotales.nroItems = filas("NroItems")
                TotalesSubTotales.totalTodosItems = filas("TotalTodosItems")
                TotalesSubTotales.listaFormaPago = New listaFormaPago()
                Dim formaPago1 As FormaPago = New FormaPago()
                formaPago1.formaPagoFact = filas("FormaPagoFact")
                formaPago1.descFormaPago = filas("DescFormaPago")
                formaPago1.valorCuotaPagada = filas("ValorCuotaPagada")
                TotalesSubTotales.listaFormaPago.Add(formaPago1)

            Next

            Return TotalesSubTotales
        End Function

    End Class
    Public Class DatosFE
        Public Shared DatosFacturaexp As New EBIPaWebServices.datosFacturaExportacion()
        Public Shared Function datos() As EBIPaWebServices.datosFacturaExportacion

            Dim dFeX As New datosFacturaExportacion

            dFeX.condicionesEntrega = "EXW"
            dFeX.monedaOperExportacion = "USD"
            dFeX.monedaOperExportacionNonDef = ""
            dFeX.tipoDeCambio = ""
            dFeX.montoMonedaExtranjera = ""
            dFeX.puertoEmbarque = ""
            Return dFeX
        End Function
    End Class

    Public Class DatosCUFE
        Public Shared Function Cufe(sCufeString As String) As CufeDocs
            Dim nCufe As DataTable
            nCufe = DemoIntCSharpEBI.ELTBFACTURAELBL.SelectCufeUpdate(DemoIntCSharpEBI.xDoc, DemoIntCSharpEBI.xNum, DemoIntCSharpEBI.xSer, DemoIntCSharpEBI.xStf, DemoIntCSharpEBI.xCtc, sCufeString)

        End Function
    End Class
    Public Class DatosDocumentox
        Public Shared Function ArmarDocs() As DatosDocs
            Dim dTFactura As DataTable
            dTFactura = DemoIntCSharpEBI.ELTBFACTURAELBL.SelectFactura(DemoIntCSharpEBI.xDoc, DemoIntCSharpEBI.xNum, DemoIntCSharpEBI.xSer, DemoIntCSharpEBI.xStf, DemoIntCSharpEBI.xCtc)

            Dim vDocs As New DatosDocs()

            For Each filas In dTFactura.Rows
                vDocs.CSE = filas("CodigoSucursalEmisor")
                vDocs.NDF = filas("NumeroDocumentoFiscal")
                vDocs.PFF = filas("PuntoFacturacionFiscal")
                vDocs.SDS = ""
                vDocs.TDC = filas("TipoDocumento")
                vDocs.TEM = filas("TipoEmision")
            Next

            Return vDocs
        End Function
    End Class


End Namespace
