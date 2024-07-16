Imports System.ComponentModel
Imports IT.ELUX.BL
Imports IT.ELUX.BE
Imports Scripting

Public Class FormMain

#Region "Declaraciones"
    Public gdtMainData As DataTable
    Private gpCaption As String
    Private bFirst As Boolean
    Private sMes1 As String
    Private dtSource As New DataTable
    Private uca As New ArrayList
    Private PageCount As Integer
    Private maxRec As Integer
    Private pageSize As Integer
    Private currentPage As Integer
    Private recNo As Integer
    Private primero As Boolean = True
    Private bChange As Boolean = False
    Public cAlm As String
    Dim oSistemaBL As New SistemaBL

    Dim QUINCENABL As New QUINCENABL
    Dim CTS_BL As New CTS_BL
    Dim ELTBPERCEPBL As New ELTBPERCEPBL
    Dim VACUNABL As New VACUNABL
    Dim PRODUCCIONBL As New PRODUCCIONBL
    Dim contador As Integer = 0
    Dim menubl As New MenuBL
    Dim ELTBUSERBL As New ELTBUSERBL
    Dim CIIUBL As New CIIUBL
    Dim ELTBDOCEXPBL As New ELTBDOCEXPBL
    Dim PERROTBL As New PERROTBL
    Dim ELTBALMACENBL As New ELTBALMACENBL
    Dim ELTBLINESBL As New ELTBLINESBL
    Dim ELTBMANTENIMIENTOBL As New ELTBMANTENIMIENTOBL
    Dim ELVACACIONESBL As New ELVACACIONESBL
    Dim ELTBLINEABL As New ELTBLINEABL
    Dim ELTBDETSTIEMBL As New ELTBDETSTIEMBL
    Dim ELPAGO_DOCUMENTOBL As New ELPAGO_DOCUMENTOBL
    Dim ELDOCUMENTOBL As New ELDOCUMENTOBL
    Dim ELTBCARGOBL As New ELTBCARGOBL
    Dim ELTBMESSAGEBL As New ELTBMESSAGEBL
    Dim ELTBDETRACCIONBL As New ELTBDETRACCIONBL
    Dim ELLIB_CONTBL As New ELLIB_CONTBL
    Dim ELTBTURNOBL As New ELTBTURNOBL
    Dim ELTBPROGPAGOBL As New ELTBPROGPAGOBL
    Dim ELLIQUIDACIONBL As New ELLIQUIDACIONBL
    Dim ELORDEN_PROGRAMBL As New ELORDEN_PROGRAMBL
    Dim ELTBKARDEXIMPBL As New ELTBKARDEXIMPBL
    Dim ELT_OPEBL As New ELT_OPEBL
    Dim ELTBCARABL As New ELTBCARABL
    Dim ELTBTIPOCAMBIOBE As New ELTBTIPOCAMBIOBE
    Dim ART_UPDATEBL As New ART_UPDATEBL
    Dim ELCONTRATOBL As New ELCONTRATOBL
    Dim ELTBCONCEPTOSBL As New ELTBCONCEPTOSBL
    Dim ELTBAREABL As New ELTBAREABL
    Dim ELTBCUENTA_OPEBL As New ELTBCUENTA_OPEBL
    Dim ELTBCATABL As New ELTBCATABL
    Dim ELESPECI_TBL As New ELESPECI_TBL
    Dim ELETIQUETABL As New ELETIQUETABL
    Dim ELTBOPERBL As New ELTBOPERBL
    Dim FORMA_PAGOBL As New FORMA_PAGOBL
    Dim ELUTILIDADESBL As New ELUTILIDADESBL
    Dim ELTBPROCBL As New ELTBPROCBL
    Dim ELTBTAREOBL As New ELTBTAREOBL
    Dim ELTBPROVEEDORESBL As New ELTBPROVEEDORESBL
    Dim ELTBCLIENTEBL As New ELTBCLIENTEBL
    Dim CUENTABANCOBL As New CUENTABANCOBL
    Dim FORMA_ENTBL As New FORMA_ENTBL
    Dim PROVISIONESBL As New PROVISIONESBL
    Dim IMPUESTOBL As New IMPUESTOBL
    Dim ELCERTIFICABL As New ELCERTIFICABL
    Dim ELPERMISOSBL As New ELPERMISOSBL
    Dim UNIBL As New UNIBL
    Dim NOTADEBITOBL As New NOTADEBITOBL
    Dim ARTICULOBL As New ARTICULOBL
    Dim T_MEDIDABL As New T_MEDIDABL
    Dim T_MOVINVBL As New T_MOVINVBL
    Dim ELTBREGISTRO_NROBL As New ELTBREGISTRO_NROBL
    Dim ELTBMOVIMIENTOBL As New ELTBMOVIMIENTOBL
    Dim REQUERIMIENTOBL As New REQUERIMIENTOBL
    Dim ELDESPACHOBL As New ELDESPACHOBL
    Dim ELTBINICIALCBBL As New ELTBINICIALCBBL
    Dim GUIAALMACENBL As New GUIAALMACENBL
    Dim NOTACREDITOBL As New NOTACREDITOBL
    Dim ELPRODUCCIONBL As New ELPRODUCCIONBL
    Dim ORDENCOMPRABL As New ORDENCOMPRABL
    Dim ORDEN_COMPRABL As New ORDEN_COMPRABL
    Dim CTCTBL As New CTCTBL
    Dim PERBL As New PERBL
    Dim REPORTE_PRODUCCIONBL As New REPORTE_PRODUCCIONBL
    Dim SOLMATERIALESBL As New SOLMATERIALESBL
    Dim ELTBDETSOLMATERIALESBL As New ELTBDETSOLMATERIALESBL
    Dim ELTBCOSTOGASTOBL As New ELTBCOSTOGASTOBL
    Dim CCOSTOBL As New CCOSTOBL
    Dim ELTBGRUPOBL As New ELTBGRUPOBL
    Dim ELTBGRUPCORBL As New ELTBGRUPCORBL
    Dim ELTBSTIEMBL As New ELTBSTIEMBL
    Dim GUIADESPACHOBL As New GUIADESPACHOBL
    Dim FACTURACIONBL As New FACTURACIONBL
    Dim BOLETABL As New BOLETABL
    Dim LETRASBL As New LETRASBL
    Dim ELTBTRANSPBL As New ELTBTRANSPBL
    Dim ELTBTIPOCAMBIOBL As New ELTBTIPOCAMBIOBL
    Dim ELTBTRANSPCHOFERBL As New ELTBTRANSPCHOFERBL
    Dim ELTBTRANSPTRACTORBL As New ELTBTRANSPTRACTORBL
    Dim ELTBCUENTABL As New ELTBCUENTABL
    Dim ELTBCTA_FACTURACIONBL As New ELTBCTA_FACTURACIONBL
    Dim ELPROGRAMACIONBL As New ELPROGRAMACIONBL
    Dim ELTBRECEPCOMPBL As New ELTBRECEPCOMPBL
    Dim ELCUENTA_ARTBL As New ELCUENTA_ARTBL
    Dim ELPERIODOBL As New ELPERIODOBL
    Dim ELTBSINTOMAS_COVIDBL As New ELTBSINTOMAS_COVIDBL
    Dim ELDECLARACIONDUABL As New ELDECLARACIONDUABL
    Dim ELTBSTURNBL As New ELTBSTURNBL
    Dim ELREINGRESOBL As New ELREINGRESOBL
    Dim ELFALLADOSBL As New ELFALLADOSBL
    Dim ELTBCAPACITACIONBL As New ELTBCAPACITACIONBL
    Dim ELTBEVALUACIONBL As New ELTBEVALUACIONBL
    Dim ELORDEN_MANTBL As New ELORDEN_MANTBL
    Dim ELTBMTIEMBL As New ELTBMTIEMBL
    Dim oTipoFalla As New TipoFallaBL
    Dim REPORTE_TRABAJOBL As New REPORTE_TRABAJOBL
    Dim ELRRHH_FUNCIONESBL As New ELRRHH_FUNCIONES
    Dim CONTABILIDADBL As New CONTABILIDADBL
    Dim BINDCARDBL As New BINDCARDBL
    Dim MEMOBL As New MEMOBL
    Dim ELARTLINEASTOKBL As New ELARTLINEASTOKBL
    Dim PRESTAMOBL As New PRESTAMOBL
    Dim ELTBSISTINTCALIDADBL As New ELTBSISTINTCALIDADBL

    Private sPathSourcetEXE As String = "\\192.168.1.7\sistema\E.ELUX\IT.CPC.exe"

#End Region

#Region "Mostrar/Esconder"
    Private Sub est(ByVal estado As Boolean)
        cmblinea.DataSource = Nothing
        cmbsublinea.DataSource = Nothing
        cmblinea.Visible = estado
        cmbsublinea.Visible = estado
        Label2.Text = "Linea"
        Label3.Text = "Sub Linea"
        Label2.Visible = estado
        Label3.Visible = estado
        primero = estado

    End Sub

    Private Sub est1(ByVal estado As Boolean)
        cmbaño.SelectedIndex = -1
        cmbmes.SelectedIndex = -1
        cmbaño.Visible = estado
        cmbmes.Visible = estado
        Label2.Text = "Año"
        Label3.Text = "Mes"
        Label2.Visible = estado
        Label3.Visible = estado
        cmbTipoCred.Visible = False
        primero = estado
    End Sub
    Private Sub est2(ByVal estado As Boolean)
        btnkardex.Visible = estado
        btnmov.Visible = estado
        btnmovart.Visible = estado
        btnstocktodos.Text = "Stock Todos"
        btnstocktodos.Visible = estado
        btnsublinea.Visible = estado
        btnseg.Visible = estado
    End Sub
    Private Sub est3(ByVal estado As Boolean)
        Panel1.Visible = estado
    End Sub
    Private Sub est4(ByVal estado As Boolean)
        cmbaño.SelectedIndex = -1
        cmbaño.Visible = estado
        Label2.Text = "Año"
        Label2.Visible = estado
        primero = estado
    End Sub
    Private Sub est5(ByVal estado As Boolean)
        chkimp.Visible = estado
        chkpart.Visible = estado
        chkotro.Visible = estado
        chkbte.Visible = estado
        chktod.Visible = estado
        chkimp.Checked = True
        chkpart.Checked = False
        chkbte.Checked = False
        chkotro.Checked = False
        chktod.Checked = False
    End Sub
    Private Function mes(ByVal cmb As String) As String
        If cmbmes.SelectedItem = "Enero" Then
            Return "01"
        ElseIf cmbmes.SelectedItem = "Febrero" Then
            Return "02"
        ElseIf cmbmes.SelectedItem = "Marzo" Then
            Return "03"
        ElseIf cmbmes.SelectedItem = "Abril" Then
            Return "04"
        ElseIf cmbmes.SelectedItem = "Mayo" Then
            Return "05"
        ElseIf cmbmes.SelectedItem = "Junio" Then
            Return "06"
        ElseIf cmbmes.SelectedItem = "Julio" Then
            Return "07"
        ElseIf cmbmes.SelectedItem = "Agosto" Then
            Return "08"
        ElseIf cmbmes.SelectedItem = "Septiembre" Then
            Return "09"
        ElseIf cmbmes.SelectedItem = "Octubre" Then
            Return "10"
        ElseIf cmbmes.SelectedItem = "Noviembre" Then
            Return "11"
        ElseIf cmbmes.SelectedItem = "Diciembre" Then
            Return "12"
        End If
    End Function
#End Region

#Region "Cargar Combos"

    Private Function GetCmb(ByVal sCodigo As String, ByVal sDescri As String, ByVal dtSelect As DataTable, ByVal cmb As ComboBox) As DataTable
        'llenado del combo con los items
        cmb.DataSource = dtSelect
        cmb.DisplayMember = sDescri
        cmb.ValueMember = sCodigo
        cmb.SelectedIndex = -1
    End Function

    Private Function getCmbAño(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("2008")
        cmb.Items.Add("2009")
        cmb.Items.Add("2010")
        cmb.Items.Add("2011")
        cmb.Items.Add("2012")
        cmb.Items.Add("2013")
        cmb.Items.Add("2014")
        cmb.Items.Add("2015")
        cmb.Items.Add("2016")
        cmb.Items.Add("2017")
        cmb.Items.Add("2018")
        cmb.Items.Add("2019")
        cmb.Items.Add("2020")
        cmb.Items.Add("2021")
        cmb.Items.Add("2022")
        cmb.Items.Add("2023")
        cmb.Items.Add("2024")
        cmb.Items.Add("2025")
        cmb.Items.Add("2026")
        cmb.Items.Add("2027")
        cmb.Items.Add("2028")
        cmb.Items.Add("2029")
        cmb.Items.Add("2030")
    End Function

    Private Function getCmbMes(ByVal cmb As ComboBox)
        cmb.Items.Add("Enero")
        cmb.Items.Add("Febrero")
        cmb.Items.Add("Marzo")
        cmb.Items.Add("Abril")
        cmb.Items.Add("Mayo")
        cmb.Items.Add("Junio")
        cmb.Items.Add("Julio")
        cmb.Items.Add("Agosto")
        cmb.Items.Add("Septiembre")
        cmb.Items.Add("Octubre")
        cmb.Items.Add("Noviembre")
        cmb.Items.Add("Diciembre")
    End Function
#End Region

#Region "idle"
    'The actual API call to use.
    Private Declare Function GetLastInputInfo Lib "user32.dll" (ByRef inputStructure As inputInfo) As Boolean
    '
    Private Structure inputInfo

        Dim structSize As Int32

        Dim tickCount As Int32

    End Structure


    '
    'The variable that will be passed to the API call and receive the activity report.
    Private info As inputInfo
    '
    'Visual Basic.NET…
    '
    Dim firstTick As Int32
    '
    Dim lastTick As Int32
    Dim dLast As DateTime
    Dim dNow As DateTime

    'Private Sub tmrIdle_Tick(sender As Object, e As EventArgs) Handles tmrIdle.Tick
    '    '
    '    'This timer will fire every 1000ms(One Second) or so displaying the last time the user was active.
    '    '
    '    'The size of the structure for the API call.
    '    info.structSize = Len(info)
    '    '
    '    'Call the API.
    '    GetLastInputInfo(info)
    '    '
    '    'Compare the tickcount values to determine if activity has occurred or not.
    '    If firstTick <> info.tickCount Then
    '        '
    '        'Display the current time of the users last activity.
    '        '
    '        'Get the new tick value.
    '        firstTick = info.tickCount
    '        dLast = Now()
    '    End If

    '    dNow = Now()
    '    ' lblTime.Text = DateDiff("s", dLast, dNow)
    '    'revisar el idle
    '    If DateDiff("s", dLast, dNow) > (60 * 3) Then
    '        tmrIdle.Enabled = False
    '        FormIdle.ShowDialog()
    '        tmrIdle.Enabled = True
    '    End If
    'End Sub
#End Region

    Private nNewVersion As String

    Private Sub chkNewVersion()
        Dim nCurrentVersion As String
        Dim nNewVersion As String
        Dim fso As FileSystemObject
        fso = New FileSystemObject
        nNewVersion = fso.GetFileVersion(sPathSourcetEXE)
        nCurrentVersion = System.Windows.Forms.Application.ProductVersion
#If DEBUG Then



#Else
        
            If nNewVersion <> nCurrentVersion Then
                btnActualizar.Visible = True
                btnActualizar.Text = "Existe una nueva versión del sistema (" + nNewVersion + "), se procederá con la actualización ..."
                'launch app
                'Dim proc As New System.Diagnostics.Process()
                'proc = Process.Start("C:\CPC\UPDATE\IT.UPDATE.exe", "")
                'End
                'Exit Sub
            End If
        
#End If


    End Sub

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            'For i As Integer = 1 To NCol
            exHoja.Cells.Item(1, 1) = "Razon Social" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 2) = "Apellido Paterno" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 3) = "Apellido Materno" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 4) = "Tipo Documento" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 5) = "RUC/DNI" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 6) = "Nº Letra o Factura" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 7) = "Vencimiento" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 8) = "Importe" 'ElGrid.Columns(i - 1).Name.ToString
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            'Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
    Function GridAExcel_Compras(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            'For i As Integer = 1 To NCol
            exHoja.Cells.Item(1, 1) = "TIPO_EXP" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 2) = "PERIODO" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 3) = "CORRELATIVO" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 4) = "REG_NRO" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 5) = "FEC" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 6) = "FEC_PAGO" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 7) = "T_DOC_COD" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 8) = "SERIE_NRO" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 9) = "ANHO_DUA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 10) = "COMP_NRO" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 11) = "NRO_FINAL" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 12) = "TIPO_DOC_CLIENTE" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 13) = "PROVEEDOR" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 14) = "RAZON_SOCIAL" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 15) = "BASE_IMP_OPE_GRAV" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 16) = "IGV_IMPOR" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 17) = "COLUMNA16" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 18) = "COLUMNA17" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 19) = "COLUMNA18" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 20) = "COLUMNA19" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 21) = "TPRECIOS_EXO" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 22) = "COLUMNA21" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 23) = "OTROS_TRIBUTOS" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 24) = "TOTAL" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 25) = "MONEDA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 26) = "T_CMB" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 27) = "FEC_EMISION_MODIFICA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 28) = "TIPO_DOC_MODIFICA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 29) = "SERIE_DOC_MODIFICA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 30) = "COD_DEPEND_ADUANERA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 31) = "NRO_DOC_MODIFICA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 32) = "FEC_DETRA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 33) = "NRO_DETRA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 34) = "MARCA_PAGO_RETENCION" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 35) = "COD_BS_SS_11" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 36) = "IDENTIF_CONTRATO" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 37) = "ERROR_TIPO1" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 38) = "ERROR_TIPO2" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 39) = "ERROR_TIPO3" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 40) = "ERROR_TIPO4" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 41) = "MEDIO_DE_PAGO" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 42) = "ESTADO" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 43) = "CUENTA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 46) = "COD_CAJA" 'ElGrid.Columns(i - 1).Name.ToString
            exHoja.Cells.Item(1, 47) = "COD_FLUJO" 'ElGrid.Columns(i - 1).Name.ToString
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            'Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    If Col + 1 = 7 Or Col + 1 = 8 Or Col + 1 = 10 Or Col + 1 = 33 Or Col + 1 = 31 Or
                     Col + 1 = 28 Or Col + 1 = 27 Or Col + 1 = 5 Or Col + 1 = 32 Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "@"
                        exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                    Else
                        exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                    End If
                Next
            Next
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
    Private Sub SaveData()

        'If MessageBox.Show("Desea actualizar el Registro",
        '           gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        '           MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
        '    Exit Sub
        'End If
        Select Case gsMenuNodeId
            Case "1001020000"
                Try
                    Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
                    Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE

                    REQUERIMIENTOBE.T_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("TIPO_DOCUMENTO").Value
                    REQUERIMIENTOBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SERIE_DOCUMENTO").Value
                    REQUERIMIENTOBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOCUMENTO").Value
                    REQUERIMIENTOBE.ART_COD = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                    ELMVLOGSBE.log_codigo = gsCodUsr

                    gsError = REQUERIMIENTOBL.SaveRow(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvMain, sEstAlmac)


                    If gsError = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "1001010000"
                Try
                    Dim REQUERIMIENTOBE As New REQUERIMIENTOBE
                    Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE

                    REQUERIMIENTOBE.T_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("TIPO_DOCUMENTO").Value
                    REQUERIMIENTOBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SERIE_DOCUMENTO").Value
                    REQUERIMIENTOBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOCUMENTO").Value
                    REQUERIMIENTOBE.ART_COD = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value

                    gsError = REQUERIMIENTOBL.SaveRow(REQUERIMIENTOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvMain, sEstAlmac)


                    If gsError = "OK" Then
                        'MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0402010000"
                Try
                    Dim REPORTE_PRODUCCIONBE As New REPORTE_PRODUCCIONBE
                    Dim DETALLE_DOCUMENTOBE As New DETALLE_DOCUMENTOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    REPORTE_PRODUCCIONBE.T_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                    REPORTE_PRODUCCIONBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X1").Value
                    REPORTE_PRODUCCIONBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    'REPORTE_PRODUCCIONBE.ART_COD = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                    REPORTE_PRODUCCIONBE.USUARIO_OB = gsUser
                    REPORTE_PRODUCCIONBE.USUARIO_VB = gsUser
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = REPORTE_PRODUCCIONBL.SaveRow(REPORTE_PRODUCCIONBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, flagAccion, sEstAlmac)
                    If gsError = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)
                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case "0402020000"
                Try
                    Dim REPORTE_PRODUCCIONBE As New REPORTE_PRODUCCIONBE
                    Dim DETALLE_DOCUMENTOBE As New DETALLE_DOCUMENTOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    REPORTE_PRODUCCIONBE.T_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                    REPORTE_PRODUCCIONBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X1").Value
                    REPORTE_PRODUCCIONBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    'REPORTE_PRODUCCIONBE.ART_COD = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                    REPORTE_PRODUCCIONBE.USUARIO_OB = gsUser
                    REPORTE_PRODUCCIONBE.USUARIO_VB = gsUser
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = REPORTE_PRODUCCIONBL.SaveRow(REPORTE_PRODUCCIONBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, flagAccion, sEstAlmac)


                    If gsError = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0402030000"
                Try
                    Dim ELREINGRESOBE As New ELREINGRESOBE
                    Dim DETALLE_DOCUMENTOBE As New DETALLE_DOCUMENTOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELREINGRESOBE.T_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                    ELREINGRESOBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X1").Value
                    ELREINGRESOBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    'REPORTE_PRODUCCIONBE.ART_COD = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                    ELREINGRESOBE.USUARIO_OB = gsUser
                    ELREINGRESOBE.USUARIO_VB = gsUser
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = ELREINGRESOBL.SaveRow(ELREINGRESOBE, DETALLE_DOCUMENTOBE, ELMVLOGSBE, flagAccion, sEstAlmac)


                    If gsError = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0401040000"
                'horas extras ver
                Try
                    Dim ELTBSTIEMBE As New ELTBSTIEMBE
                    Dim ELTBDETSTIEMBE As New ELTBDETSTIEMBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    Dim NRO As String
                    ELTBSTIEMBE.T_DOC_REF = "STIEM"
                    ELTBSTIEMBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    ELTBSTIEMBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    ELTBSTIEMBE.EST = sest1
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    If gsUser <> "SISTEMA" Then
                        NRO = ELTBSTIEMBL.OK_CCO_COD(gsUser)
                    End If

                    gsCode11 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("cco_cod").Value
                    If gsUser = "SISTEMA" Or gsUser = "LMORAN" Or gsUser = "VHERMOZA" Or gsUser = "RCONISLLA" Or gsUser = "DCONDOR" Then
                    Else
                        If Trim(gsCode11) = "203" Or Trim(gsCode11) = "120" Or Trim(gsCode11) = "119" Then
                            gsCode11 = "111"
                        End If
                        If Trim(gsCode11) = NRO Or gsUser = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value Then
                        Else
                            If gsUser = "LVERGARA" Or gsUser = "DSANDOVAL" Then
                                If gsCode11 <> "111" And dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value = "DSANDOVAL" Then

                                    MsgBox("Usted no ah ingresado este Documento")
                                End If
                            ElseIf gsUser = "MPEÑA" Then
                                If gsCode11 <> "117" And dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value <> "DSANDOVAL" Then
                                    MsgBox("Usted no ah ingresado este Documento")
                                    Exit Sub
                                End If
                            Else
                                If gsUser <> "JMONTES" And flagAccion <> "HERH" And gsUser <> "JFLORES" Then
                                    If dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value <> gsCodUsr Then
                                        MsgBox("Usted no ah ingresado este Documento")
                                        Exit Sub
                                    End If
                                End If
                            End If

                        End If
                    End If

                    gsError = ELTBSTIEMBL.SaveRow(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, flagAccion, dgvMain)

                    If gsError = "OK" Then
                        'MsgBox("Hora Guardada", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                    sest1 = ""
                    sOp = ""
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case "0302070000"
                Try
                    Dim LETRASBE As New LETRASBE
                    Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    Dim ELTBLETRAS_MONTOBE As New ELTBLETRAS_MONTOBE
                    If flagAccion = "UL" Then
                    Else
                        LETRASBE.T_DOC_REF = "80"
                        LETRASBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                        LETRASBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    End If

                    'REPORTE_PRODUCCIONBE.ART_COD = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value

                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = LETRASBL.SaveRow(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvMain, dgvMain, ELTBLETRAS_MONTOBE)


                    If gsError = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0503010000"
                Try
                    Dim mm As String
                    Dim dd As String

                    Dim ELTBTIPOCAMBIOBE As New ELTBTIPOCAMBIOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    dd = mes(cmbmes.Text)
                    mm = cmbaño.Text & dd
                    ELTBTIPOCAMBIOBE.fec1 = mm

                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError2 = ELTBTIPOCAMBIOBL.SaveRowCmb(ELTBTIPOCAMBIOBE, "UCT")


                    If gsError2 = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0504030000"
                Try
                    Dim LETRASBE As New LETRASBE
                    Dim DET_DOCUMENTOBE As New DET_DOCUMENTOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    Dim ELTBLETRAS_MONTOBE As New ELTBLETRAS_MONTOBE
                    LETRASBE.T_DOC_REF = "80"
                    LETRASBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    LETRASBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    'REPORTE_PRODUCCIONBE.ART_COD = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value

                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = LETRASBL.SaveRow(LETRASBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dgvMain, dgvMain, ELTBLETRAS_MONTOBE)


                    If gsError = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0305020000"
                Try
                    'ELTBCLIENTEBL.VerificarCliente(lblcodigo.Text)
                    Dim ELTBCLIENTEBE As New ELTBCLIENTEBE
                    ELTBCLIENTEBE.cod = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CODIGO").Value
                    ELTBCLIENTEBE.Dia1 = ""
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = ELTBCLIENTEBL.SaveRow(ELTBCLIENTEBE, "UC", dgvMain, dgvMain, dgvMain, ELMVLOGSBE)

                    If gsError = "OK" Then
                        MsgBox("Se ah desbloqueado Correctamente al Cliente", MsgBoxStyle.Information)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0206010000"
                Try
                    Dim SOLMATERIALESBE As New SOLMATERIALESBE
                    Dim ELTBDETSOLMATERIALESBE As New ELTBDETSOLMATERIALESBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    SOLMATERIALESBE.T_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    SOLMATERIALESBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    SOLMATERIALESBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    ELTBDETSOLMATERIALESBE.ART_COD = IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value)
                    SOLMATERIALESBE.FEC_GENE = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("FEC_GENE").Value
                    SOLMATERIALESBE.USUARIO_OB = gsUser
                    SOLMATERIALESBE.USUARIO_VB = gsUser
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = SOLMATERIALESBL.SaveRow(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, flagAccion, dgvMain)


                    If gsError = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0206020000"
                Try
                    Dim ELTBRECEPCOMPBE As New ELTBRECEPCOMPBE
                    Dim ELTBDETRECEPCOMPBE As New ELTBDETRECEPCOMPBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELTBDETRECEPCOMPBE.T_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    ELTBDETRECEPCOMPBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    ELTBDETRECEPCOMPBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    ELTBDETRECEPCOMPBE.USUARIO_OB = gsUser
                    ELTBDETRECEPCOMPBE.USUARIO_VB = gsUser
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = ELTBRECEPCOMPBL.SaveRow(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, flagAccion, dgvMain)


                    If gsError = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0505010000"
                Try
                    Dim ELTBRECEPCOMPBE As New ELTBRECEPCOMPBE
                    Dim ELTBDETRECEPCOMPBE As New ELTBDETRECEPCOMPBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    ELTBDETRECEPCOMPBE.T_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    ELTBDETRECEPCOMPBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    ELTBDETRECEPCOMPBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    ELTBDETRECEPCOMPBE.ART_COD = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                    ELTBDETRECEPCOMPBE.USUARIO_OB = gsCodUsr
                    ELTBDETRECEPCOMPBE.USUARIO_VB = gsCodUsr
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    gsError = ELTBRECEPCOMPBL.SaveRow(ELTBRECEPCOMPBE, ELTBDETRECEPCOMPBE, ELMVLOGSBE, flagAccion, dgvMain)


                    If gsError = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0205030000"
                Try
                    Dim SOLMATERIALESBE As New SOLMATERIALESBE
                    Dim ELTBDETSOLMATERIALESBE As New ELTBDETSOLMATERIALESBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE

                    SOLMATERIALESBE.T_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                    SOLMATERIALESBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X1").Value
                    SOLMATERIALESBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    ELTBDETSOLMATERIALESBE.ART_COD = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                    ELMVLOGSBE.log_codusu = gsCodUsr

                    gsError = SOLMATERIALESBL.SaveRow(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, flagAccion, dgvMain)


                    If gsError = "OK" Then
                        MsgBox("Requerimiento guardado", MsgBoxStyle.Information)

                        'Dispose()
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0703040000"
                'horas extras ver
                Try
                    Dim REPORTE_TRABAJOBE As New REPORTE_TRABAJOBE
                    Dim REPORTE_DETTRABAJOBE As New REPORTE_DETTRABAJOBE
                    Dim ELMVLOGSBE As New ELMVLOGSBE
                    Dim NRO As String
                    REPORTE_TRABAJOBE.T_DOC_REF = "HMANT"
                    REPORTE_TRABAJOBE.SER_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    REPORTE_TRABAJOBE.NRO_DOC_REF = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    REPORTE_TRABAJOBE.EST = sest1
                    ELMVLOGSBE.log_codusu = gsCodUsr
                    If gsUser <> "SISTEMA" Then
                        NRO = ELTBSTIEMBL.OK_CCO_COD(gsUser)
                    End If
                    gsCode11 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("cco_cod").Value
                    If gsUser = "SISTEMA" Or gsUser = "JTUCNO" Or gsUser = "RCONISLLA" Or gsUser = "BROJAS" Then

                    Else
                        ''      If Trim(gsCode11) = "203" Or Trim(gsCode11) = "120" Or Trim(gsCode11) = "119" Then
                        ''          gsCode11 = "111"
                        ''      End If
                        ''      If Trim(gsCode11) = NRO Or gsUser = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value Then
                        ''      Else
                        ''          If gsUser = "LVERGARA" Then
                        ''              If gsCode11 <> "111" And dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value <> "DSANDOVAL" Then
                        ''                  MsgBox("Usted no ah ingresado este Documento")
                        ''              End If
                        ''          ElseIf gsUser = "MPEÑA" Then
                        ''              If gsCode11 <> "117" And dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value <> "DSANDOVAL" Then
                        ''                  MsgBox("Usted no ah ingresado este Documento")
                        ''                  Exit Sub
                        ''              End If
                        ''          Else
                        ''              If gsUser <> "JMONTES" And flagAccion <> "HERH" And gsUser <> "JFLORES" Then
                        ''                  If dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("USUARIO_RP").Value <> gsCodUsr Then
                        ''                      MsgBox("Usted no ah ingresado este Documento")
                        ''                      Exit Sub
                        ''                  End If
                        ''              End If
                        ''          End If
                        ''
                        ''      End If
                    End If

                    gsError = REPORTE_TRABAJOBL.SaveRow(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, flagAccion, dgvMain)

                    If gsError = "OK" Then
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Grabar", MsgBoxStyle.Critical)
                    End If
                    sest1 = ""
                    sOp = ""
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

        End Select
    End Sub

    Public Function gHeader(ByVal dt As DataGridView) As DataTable
        Dim iI As Integer = 0
        Dim dt2 As DataTable
        Dim row As DataRow
        'Cambia la cabecera de los gridss'Carga el Grid del Main
        Try
            For iI = 0 To dt.Columns.Count - 1
                '//BUSCAR HEADER TEXT
                dt2 = REQUERIMIENTOBL.SelectNomColumn(RTrim(dt.Columns.Item(iI).Name.ToString))

                If Not IsNothing(dt2) And dt2.Rows.Count > 0 Then
                    Debug.Print(dt2.Rows(0)(0).ToString)
                    dgvMain.Columns.Item(iI).HeaderText = dt2.Rows(0)(0).ToString
                Else
                    dgvMain.Columns.Item(iI).Visible = False
                End If
                'ocultar campos
                If dt2.Rows.Count > 0 Then
                    row = dt2.Rows(0)
                    If row(0).ToString = "X" Then
                        dgvMain.Columns.Item(iI).Visible = False 'dt2.Rows(0)(iI)
                    Else
                        If row(0).ToString <> "" Then
                            dgvMain.Columns.Item(iI).HeaderText = row(0).ToString
                        End If
                    End If
                Else
                    dgvMain.Columns.Item(iI).HeaderText = dgvMain.Columns.Item(iI).HeaderText
                    dgvMain.Columns.Item(iI).Visible = True
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipoCred.Visible = False

        'Carga el Grid del Main
        Dim dt As New DataTable
        'Nombre de la pantalla
        gpCaption = "CentralPack Corp."
        If sAño = "2018" Then
            cmbano.SelectedIndex = 0
        ElseIf sAño = "2019" Then
            cmbano.SelectedIndex = 1
        ElseIf sAño = "2020" Then
            cmbano.SelectedIndex = 2
        ElseIf sAño = "2021" Then
            cmbano.SelectedIndex = 3
        ElseIf sAño = "2022" Then
            cmbano.SelectedIndex = 4
        ElseIf sAño = "2023" Then
            cmbano.SelectedIndex = 5
        End If

        'dt = ELTBALMACENBL.SelectAll1
        'GetCmb("ALM_CODIGO", "COD", dt, cmbalmacen)
        Me.Text = gpCaption
        'Carga usuario logueado
        dt = menubl.ListMenu(gsCodUsr)
        'Carga menu
        If gsCodUsr = "0031" Then
            cmbalmacen.SelectedIndex = 1
            gsCodAlm = Mid(cmbalmacen.Text, 1, 4)
        Else
            cmbalmacen.SelectedIndex = 0
            gsCodAlm = Mid(cmbalmacen.Text, 1, 4)
        End If

        ''''UcAcMnu1.ImageList = imlMenu
        '''''Carga Imagen del icono del menu
        ''''bFirst = True
        ''''Dim s As String = dt.Rows(0).Item("mnu_parent").ToString
        ''''For i = 0 To dt.Rows.Count - 1
        ''''    If (dt.Rows(i).Item("mnu_parent").ToString.Trim = "SIS") Then
        ''''        UcAcMnu1.mnuAdd(dt.Rows(i).Item("id").ToString, "root", dt.Rows(i).Item("sis_descri").ToString, dt.Rows(i).Item("mnu_icon0").ToString, dt.Rows(i).Item("mnu_icon1").ToString)
        ''''    End If
        ''''Next
        ''''For i = 0 To dt.Rows.Count - 1
        ''''    If (dt.Rows(i).Item("mnu_parent").ToString.Trim <> "SIS") Then
        ''''        UcAcMnu1.mnuAdd(dt.Rows(i).Item("id").ToString, dt.Rows(i).Item("mnu_codsis").ToString + dt.Rows(i).Item("mnu_parent").ToString, dt.Rows(i).Item("mnu_descri").ToString, dt.Rows(i).Item("mnu_icon0").ToString, dt.Rows(i).Item("mnu_icon1").ToString)
        ''''    End If
        ''''Next
        '''''tstcmbPageSize.Text = "30"
        '''''pageSize = tstcmbPageSize.ComboBox.SelectedItem
        ''''bFirst = False
        Me.WindowState = FormWindowState.Maximized

        'desactivar busqueda
        tsTextSearch.Enabled = False
        tssUsuario.Text = gsUser

        lblVersion.Text = "v." + System.Windows.Forms.Application.ProductVersion
        '--------------------------------
        'TODO - MENU TREEVIEW
        TreeView1.Nodes.Clear()
        TreeView1.ImageList = imlMenu
        fnRecursivaSistema(gsCodUsr, gsUser, Nothing)
        '--------------------------------
        'dgv color
        dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
        dgvMain.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray
        dgvMain.EnableHeadersVisualStyles = False

    End Sub

    Private Sub fnRecursivaSistema(ByVal Key As String, ByVal Txt As String, ByVal N As TreeNode)
        Dim NN As TreeNode
        Dim dtDataTable As DataTable
        contador = contador + 1
        If contador > 1 Then
            If N Is Nothing Then
                NN = TreeView1.Nodes.Add(Key, Txt, 5)
            Else
                NN = N.Nodes.Add(Key, Txt, 5)
            End If
        End If
        dtDataTable = oSistemaBL.getSistemaByUsuCod(gsCodUsr)
        For Each row As DataRow In dtDataTable.Rows
            fnRecursivaMenu(row("SIS_CODIGO"), row("SIS_CODIGO") + " - " + row("SIS_DESCRI"), NN, row("SIS_CODIGO"))
        Next row
        'NN.Expand()
    End Sub

    Private Sub fnRecursivaMenu(ByVal Key As String, ByVal Txt As String, ByVal N As TreeNode, ByVal sSisCod As String)
        Dim NN As TreeNode
        Dim dtDataTable As DataTable
        Try
            If N Is Nothing Then
                NN = TreeView1.Nodes.Add(Key, Txt, 20)
            Else
                NN = N.Nodes.Add(Key, Txt, 20)
            End If
            dtDataTable = oSistemaBL.getMenuByUsuCod(gsCodUsr, sSisCod)
            For Each row As DataRow In dtDataTable.Rows
                fnRecursivaSubMenu(row("MNU_CODMNU"), row("MNU_DESCRI"), NN, sSisCod, row("MNU_CODMNU"))
            Next row
            'NN.Expand()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub fnRecursivaSubMenu(ByVal Key As String, ByVal Txt As String, ByVal N As TreeNode, ByVal sSisCod As String, ByVal sPrnCod As String)
        Dim NN As TreeNode
        Dim dtDataTable As DataTable
        Try
            dtDataTable = oSistemaBL.getSubMenuByUsuCod(gsCodUsr, sSisCod, sPrnCod)

            If N Is Nothing Then
                NN = TreeView1.Nodes.Add(Key, Txt, 20)
            Else
                NN = N.Nodes.Add(Key, Txt, IIf(dtDataTable.Rows.Count = 0, 1, 20))
            End If

            For Each row As DataRow In dtDataTable.Rows
                fnRecursivaSubMenu(sSisCod + row("MNU_CODMNU"), row("MNU_DESCRI"), NN, sSisCod, row("MNU_CODMNU"))
            Next row
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        grpOpe.Visible = False
        grpMon.Visible = False
        btnFiltro.Visible = False
        If Not (e.Node.Name.Length) = 10 And Not e.Node.Name = "02000000" Then
            Return
        End If
        gsMenuNodeId = e.Node.Name

        Dim dt As New DataTable
        'LIMPIAR button columns
        Do While dgvMain.Columns.Count > 0
            dgvMain.Columns.RemoveAt(dgvMain.Columns.Count - 1)
        Loop
        If gsUser = "OBEIZAGA" Then
            cmbaño.Enabled = True
        End If
        cmbalmacen.Enabled = False
        tsTextSearch.Text = ""
        LblTitle.Text = e.Node.Text
        Label1.Text = e.Node.Name
        Label7.Visible = False
        Label8.Visible = False
        btnVentas.Visible = False
        'BtnActProcesos.Visible = False
        est(False)
        est1(False)
        est2(False)
        est3(False)
        btnlet.Visible = False
        est5(False)
        rdbapr1.Enabled = False
        rdbapr2.Checked = False
        rdbapr3.Checked = False
        rdbapr4.Checked = False
        dgvMain.Visible = True
        dgvt2.Visible = False
        dgvt3.Visible = False
        dgvt4.Visible = False
        btnsinot.Visible = False
        lblcantidad.Visible = False
        btngenerar.Visible = False
        chkmarcar.Visible = False
        btnseg.Visible = False
        btnseg.Text = "Stock Seguridad"
        chkest.Visible = False
        chkest.Checked = False
        cmb_tipo.Visible = False
        chkdocexp.Visible = False
        chkdocexp.Checked = False
        grphoras.Visible = False
        GroupBox1.Visible = False
        'Panel2.Visible = False
        'lblarticulo.Visible = False
        cmbtipsunat.Visible = False
        cmbtipsunat.SelectedIndex = -1
        cmb_tipo.SelectedIndex = -1
        btnlimpiar.Visible = False
        cmbano.Text = sAño
        btnsublinea.Text = "Stock SubLinea"
        cmbalmacen.Text = "0001"
        dt = Nothing
        dgvMain.DataSource = dt
        Select Case gsMenuNodeId
            Case "0101020000"
                dt = ELTBUSERBL.SelectAll
                dgvMain.DataSource = dt
            Case "0102010000"
                dt = ELTBALMACENBL.SelectAll
                dgvMain.DataSource = dt
            Case "0201020000"
                dt = ELTBLINESBL.SelectAll
                dgvMain.DataSource = dt
            Case "0103010000"
                dt = ELTBMESSAGEBL.SelectAll
                dgvMain.DataSource = dt
            Case "0102020000"
                dt = ELTBCOSTOGASTOBL.SelectAll
                dgvMain.DataSource = dt
            Case "0102040000"
                dt = CCOSTOBL.SelectAll
                dgvMain.DataSource = dt
            Case "0102050000"
                dt = ELTBGRUPCORBL.SelectAll
                dgvMain.DataSource = dt
            Case "0102070000"
                FormPRUEBA.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0104010000"
                FormRPTConIng.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0201040200"
                dt = ELTBCARABL.SelectAll
                dgvMain.DataSource = dt
            Case "0201040100"
                dt = ELTBCATABL.SelectAll
                dgvMain.DataSource = dt
            Case "0201010000"
                dt = UNIBL.SelectAll
                dgvMain.DataSource = dt
            Case "0201050000"
                dt = T_MEDIDABL.SelectAll
                dgvMain.DataSource = dt
            Case "02000000"
                If gsUser = "JANCALLE" Or gsUser = "ASESOR" Or gsUser = "SISTEMA" Or gsUser = "CHOYOS" Or gsUser = "COSTOS" Then
                    btnVentas.Text = "Explosion Art."
                    btnVentas.Visible = True
                End If
                dgvMain.DataSource = Nothing
                est(True)
                chkest.Visible = True

                dt = ARTICULOBL.SelectDescripcion()
                GetCmb("LIN_CODIGO", "LIN_DESCRI", dt, cmblinea)
                primero = False
            Case "0201060000"
                dt = T_MOVINVBL.SelectAll
                dgvMain.DataSource = dt
            Case "0203010000"
                est1(True)
                getCmbAño(cmbaño)
                chkest.Visible = True
                btnVentas.Text = "Filtro"
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0203030000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0203040000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0203050000"
                dgvMain.DataSource = Nothing
                est(True)
                btnkardex.Visible = True
                btnlet.Visible = True
                btnlet.Text = "Dif. Valorizado"
                btnstocktodos.Visible = True
                btnstocktodos.Text = "Stock Todos"
                cmbano.Enabled = True
                cmbalmacen.Enabled = True
                dt = ARTICULOBL.SelectDescripcion()
                GetCmb("LIN_CODIGO", "LIN_DESCRI", dt, cmblinea)
                primero = False

            Case "0203060000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0203070000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0203080000"
                FormActCntSolm.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0205040000"
                FormAsignarFamilia.Show()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0206020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False

            Case "0203020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False

            Case "0302010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0302020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0302030000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                btnFiltro.Visible = True
            Case "1001020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                btnFiltro.Visible = False
            Case "0401070000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                btnFiltro.Visible = False
            Case "0302040000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0302050000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0302060000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False

            Case "0302070000"
                est1(True)
                getCmbAño(cmbaño)
                btnlet.Visible = True
                btnlet.Text = "Estado Letras"
                btnVentas.Visible = True
                btnVentas.Text = "Excel"
                btnstocktodos.Text = "Limpiar Excel"
                btnstocktodos.Visible = True
                btnseg.Visible = True
                btnseg.Text = "Generar Letras"
                cmbaño.SelectedItem = sAño
                primero = False

            Case "0303200000"
                'REPORTE ARTICULO PRECIO MAXIMO Y MINIMO
                Form_Stock_Precio.ShowDialog()
            Case "0303210000"
                'REPORTE ARTICULO PRECIO MAXIMO Y MINIMO
                FormRptStockVen.ShowDialog()
            Case "0304010100"
                dt = ELTBTRANSPBL.SelectAll
                dgvMain.DataSource = dt

            Case "0304010200"
                dt = ELTBTRANSPCHOFERBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Columns("COD_CHOFER").Visible = False

            Case "0304010300"
                dt = ELTBTRANSPTRACTORBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Columns("COD_TRACTOR").Visible = False

            Case "0304020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Label7.Visible = True
                Label8.Visible = True
                cmbtipsunat.Visible = True
                cmbtipsunat.SelectedIndex = 0
            Case "0304040000"
                dt = ART_UPDATEBL.SelectAll()
                dgvMain.DataSource = dt
            Case "0305010000"
                FormFiltroFecha.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0304030000"
                dt = ELTBCLIENTEBL.SelectAll
                dgvMain.DataSource = dt
            Case "0303100000"
                FormRptRegVentas.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303110000"
                FormRptFacturasAdelantadas.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303120000"
                FormRPTResuProdMed.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303130000"
                FormRptVentas_Fact_Art.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303140000"
                gsRptArgs = {}
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PROM_VEN_CLIENTE2018.rpt"
                gsRptPath = gsPathRpt
                FormReportes.Show()
            Case "0303150000"
                FormRPTVentasTotalesCliente.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303170000"
                FormRPTPrecioArtVenta.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303180000"
                FormRptAnalisisAtencion.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303190000"
                FormRPTClienteVendedor.ShowDialog()
                'TSButtonRefresh_Click(Nothing, Nothing)
            Case "0405010000"
                dt = ELTBOPERBL.SelectAll
                dgvMain.DataSource = dt
            Case "0405020000"
                dt = ELTBAREABL.SelectAll
                dgvMain.DataSource = dt
            Case "0405030000"
                dt = ELTBPROCBL.SelectAll
                dgvMain.DataSource = dt
            Case "0405040000"
                dt = ELTBGRUPOBL.SelectAll
                dgvMain.DataSource = dt
            Case "0405050000"
                dt = ELTBLINEABL.SelectAll
                dgvMain.DataSource = dt
            Case "0401040000"
                rdbapr4.Checked = True
                est1(True)
                getCmbAño(cmbaño)
                Dim nvl As String = ELTBUSERBL.SelectUsuNvl(gsCodUsr)
                If nvl = "1" Or gsUser = "SISTEMA" Or gsUser = "MPEÑA" Or gsUser = "JTRIGOS" Then
                    rdbapr1.Enabled = True
                Else
                    rdbapr1.Enabled = False
                End If
                If gsUser = "RCONISLLA" Or gsUser = "SISTEMA" Or gsUser = "JMONTES" Or gsUser = "JFLORES" Or gsUser = "JTRIGOS" Then
                    rdbapr2.Enabled = True
                Else
                    rdbapr2.Enabled = False
                End If
                If gsUser = "JMONTES" Or gsUser = "SISTEMA" Or gsUser = "JFLORES" Or gsUser = "JTRIGOS" Then
                    rdbapr3.Enabled = True
                Else
                    rdbapr3.Enabled = False
                End If
                rdbapr4.Enabled = True
                rdbapr4.Checked = True
                grphoras.Visible = True
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0401060000"
                rdbapr4.Checked = True
                est1(True)
                getCmbAño(cmbaño)
                Dim nvl As String = ELTBUSERBL.SelectUsuNvl(gsCodUsr)
                If nvl = "1" Or gsUser = "SISTEMA" Or gsUser = "MPEÑA" Or gsUser = "JTRIGOS" Then
                    rdbapr1.Enabled = True
                Else
                    rdbapr1.Enabled = False
                End If
                If gsUser = "RCONISLLA" Or gsUser = "SISTEMA" Or gsUser = "JMONTES" Or gsUser = "JFLORES" Or gsUser = "JTRIGOS" Then
                    rdbapr2.Enabled = True
                Else
                    rdbapr2.Enabled = False
                End If
                If gsUser = "JMONTES" Or gsUser = "SISTEMA" Or gsUser = "JFLORES" Or gsUser = "JTRIGOS" Then
                    rdbapr3.Enabled = True
                Else
                    rdbapr3.Enabled = False
                End If
                rdbapr4.Enabled = True
                rdbapr4.Checked = True
                grphoras.Visible = True
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0405060000"
                dt = ELESPECI_TBL.SelectAll()
                dgvMain.DataSource = dt
            Case "0401050000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False

            Case "0204010000"
                FormMovim.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "1203010000"
                FormCapacitacion.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0204020000"
                dgvMain.DataSource = Nothing
                est(True)
                est2(True)
                cmbalmacen.Enabled = True
                btnstocktodos.Text = "Stock Todos"
                btnseg.Text = "Stock Seguridad"
                dt = ARTICULOBL.SelectDescripcion()
                GetCmb("LIN_CODIGO", "LIN_DESCRI", dt, cmblinea)
                cmbano.Enabled = True
                primero = False
            Case "0401030000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Dim sMes As String = mes(cmbmes.SelectedItem)
                dt = ELORDEN_PROGRAMBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
            Case "0204090000"
                FormRptStockFecha.ShowDialog()
                'TSButtonRefresh_Click(Nothing, Nothing)
            Case "0205010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0205020000"
                dt = REQUERIMIENTOBL.SelectAllReqA
                dgvMain.DataSource = dt
            Case "0401010100"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                'Label7.Visible = True
                'Label8.Visible = True
                est3(True)
            Case "0401010200"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                est3(True)
            Case "0401020100"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Dim sMes As String = mes(cmbmes.SelectedItem)
                dt = ELORDEN_PROGRAMBL.SelectAllOP(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
            Case "0401010300"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                est3(True)
            Case "0402010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                'Solicitud de materiales
            Case "0402020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0402030000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0206010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0205030000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Label7.Visible = True
                Label8.Visible = True
            Case "0403010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Label7.Visible = True
                Label8.Visible = True
            Case "0403020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Label7.Visible = True
                Label8.Visible = True
            Case "0403030000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Label7.Visible = True
                Label8.Visible = True
            Case "1002010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Label7.Visible = True
                Label8.Visible = True
            Case "1002020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Label7.Visible = True
                Label8.Visible = True
            Case "0303010000"
                gnOpcion3 = "0"
                FormReporteVenta.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                gnOpcion3 = Nothing
            Case "0303020000"
                FormReporteDespacho.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0404010000"
                'gnOpcion3 = "0"
                FormEtiquetas.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                gnOpcion3 = Nothing
            Case "0404050000"
                'gnOpcion3 = "0"
                FormHorasHombre.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                gnOpcion3 = Nothing
            Case "0404060000"
                'gnOpcion3 = "0"
                FormRptFichaArticulo.ShowDialog()
            Case "0404070000"
                FormRptProdCCO_COD.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0404080000"
                FormRptSegOrdProd.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)

            Case "1102020300"
                FormOPAnuladas.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0404090000"
                FormRptOrdenProgam.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0401020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                dgvMain.Visible = False
                dgvt2.Visible = True
                chkest.Visible = True
                btnVentas.Text = "Filtro"
                chkest.Text = "Activo"
                btnlet.Visible = True
                btnseg.Visible = True
                btnseg.Text = "Impr. Catalogo"
                btnlet.Text = "Explosionar Articulos"
                btnsinot.Visible = True
                dgvt3.Visible = True
                dgvt3.Rows.Clear()
                dgvt4.Visible = True
                GroupBox1.Visible = True
                If dgvt4.Rows.Count > 0 Then
                    dgvt4.DataSource = Nothing
                End If
                lvbusqueda.Items.Clear()
                btnsublinea.Text = "Ficha Tecnica"
                btnsublinea.Visible = True
                lblcantidad.Visible = True
                btngenerar.Visible = True
                chkmarcar.Visible = True
                est5(True)
                'Panel2.Visible = True
                'lblarticulo.Visible = True
                primero = False
            Case "0501010000"
                'If gsUser = "OBEIZAGA" Then
                '    FormStatusCuentasCobrar.lblcargoso.Visible = True
                '    FormStatusCuentasCobrar.cmbcargoso.Visible = True
                'End If
                FormStatusCuentasCobrar.Show()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0501020000"
                FormRPTLetrasCambio.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0501030000"
                If gsUser <> "RCONISLLA" Then
                    FormRPTKardex_Consumo_Costo.Show()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0501040000"
                If gsUser <> "RCONISLLA" Then
                    FormRPTResuKardex.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0501050000"
                FormRptPlaResuCons.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0501060000"
                If gsUser <> "RCONISLLA" Then
                    FormRPTAnaliticoLT.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0501070000"
                FormRPTFCCompras.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0501080000"
                FormRPTFCVentas_Sunat.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0501090000"
                FormRptDetRecep.ShowDialog()
            Case "0501100000"
                dt = ELDECLARACIONDUABL.SelectAll()
                dgvMain.DataSource = dt
            Case "0501110000"
                FormRptContaControlCobra.ShowDialog()
            Case "0501120000"
                FormRptMayor.ShowDialog()
            Case "0501130000"
                FormRptAsientoPla.ShowDialog()
            Case "0501140000"
                FormTextoPlame.ShowDialog()
            Case "0501150000"
                FormRptResumenAFP.ShowDialog()
            Case "0501160000"
                FormRptCon_bancaria.ShowDialog()
            Case "0501170000"
                FormRPTCuentasCCO.ShowDialog()
            Case "0501180000"
                FormRPTFLUJOEFECTIVO.ShowDialog()
            Case "0501190000"
                FormELTBPROVVACA.ShowDialog()
            Case "0501200000"
                FormRptBalanceComp.ShowDialog()
            Case "0501210000"
                FormRptMasVendidos.ShowDialog()
            Case "0501220000"
                FormRPTCalculoCTS.ShowDialog()
            Case "0501230000"
                FormRptDetDocumento.ShowDialog()
            Case "0501240000"
                FormRptLibroMayor.ShowDialog()
            Case "0501250000"
                FormRptGuiaPlaca.ShowDialog()
            Case "0501260000"
                FormRptDiario.ShowDialog()
            Case "0501270000"
                FormResumenRentaQuinta.ShowDialog()
            Case "0501280000"
                FormRptInsumosVenta.ShowDialog()
            Case "0501290000"
                FormIndiceCostos.ShowDialog()
            Case "0501300000"
                est1(True)
                cmbmes.Visible = True
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0501310000"
                FormRptRegistroCobranza.ShowDialog()
            Case "0501320000"
                FormRPTCristina.ShowDialog()
            Case "0501340000"
                FormRPTLIB_DIA_ANA.ShowDialog()
            Case "0503090000"
                FormResumenLD2D.ShowDialog()
            Case "1003010000"
                FormRPTCristina.ShowDialog()
            Case "1003020000"
                FormRptEstOC.ShowDialog()
            Case "1102020100"
                est1(True)
                cmbmes.Visible = True
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "1102020200"
                est1(True)
                cmbmes.Visible = True
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "1102020400"
                est1(True)
                cmbmes.Visible = True
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "1102010100"
                est1(True)
                cmbmes.Visible = True
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0502040000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                btnVentas.Visible = True
                btnVentas.Text = "Eliminar"
                primero = False
                Label7.Visible = True
                Label8.Visible = True
            Case "0502050000"
                dt = ELTBCUENTA_OPEBL.SelectAll(DateTime.Now.ToString("yyyy"))
                dgvMain.DataSource = dt

            Case "0502010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Label7.Visible = True
                Label8.Visible = True
            Case "0502060000"
                dt = IMPUESTOBL.SelectAll()
                dgvMain.DataSource = dt
            Case "0502070000"
                dt = FORMA_ENTBL.SelectAll()
                dgvMain.DataSource = dt
            Case "0502080000"
                dt = CUENTABANCOBL.SelectAll()
                dgvMain.DataSource = dt
            Case "0502090000"
                dt = FORMA_PAGOBL.SelectAll()
                dgvMain.DataSource = dt
            Case "0502100000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0502110000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False

            Case "0502120000"
                dt = ELLIB_CONTBL.SelectAll()
                dgvMain.DataSource = dt
            Case "0502130000"
                est1(True)
                cmbmes.Visible = False
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0502140000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0501300000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "1102020100"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "1102020200"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "1102020400"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "1102010100"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0502150000"
                est1(True)
                chkest.Visible = True
                chkest.Text = "Activo"
                chkdocexp.Visible = True
                getCmbAño(cmbaño)
                'btnVentas.Visible = True
                btnVentas.Text = "Filtro"
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0502160000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                If gsUser = "OBEIZAGA" Then
                    cmbaño.Enabled = False
                End If
                primero = False
                estadoTC = 0
                grpOpe.Visible = True
                grpMon.Visible = True
                btnFiltro.Visible = True
            Case "0502170000"
                est4(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0502200000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0502220000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0102080000"
                FormUbicacionMant.ShowDialog()
            Case "0504010000"
                FormDuplicarDetDocumento.ShowDialog()
                While Cerrardup = 1
                    FormDuplicarDetDocumento.cmbtipo.Text = "PEAJE LINEA AMARILLA 11.4"
                    FormDuplicarDetDocumento.ShowDialog()
                End While

                While Cerrardup = 2
                    FormDuplicarDetDocumento.cmbtipo.Text = "PEAJE LINEA AMARILLA 5"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 3
                    FormDuplicarDetDocumento.cmbtipo.Text = "PACIFICO SEGUROS EMPLEADOS"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 4
                    FormDuplicarDetDocumento.cmbtipo.Text = "PACIFICO SEGUROS OBREROS"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 5
                    FormDuplicarDetDocumento.cmbtipo.Text = "GRIFO JIARA S.A.C 50"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 6
                    FormDuplicarDetDocumento.cmbtipo.Text = "GRIFO JIARA S.A.C 100"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 7
                    FormDuplicarDetDocumento.cmbtipo.Text = "TELEFONO"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 8
                    FormDuplicarDetDocumento.cmbtipo.Text = "CELULARES SIN IGV"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 9
                    FormDuplicarDetDocumento.cmbtipo.Text = "AGUA"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 10
                    FormDuplicarDetDocumento.cmbtipo.Text = "LUZ"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 11
                    FormDuplicarDetDocumento.cmbtipo.Text = "GAS"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 12
                    FormDuplicarDetDocumento.cmbtipo.Text = "INTERNET TORRES"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 13
                    FormDuplicarDetDocumento.cmbtipo.Text = "LUZ STATKRAFT SOLES"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 14
                    FormDuplicarDetDocumento.cmbtipo.Text = "LUZ STATKRAFT DOLARES"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 15
                    FormDuplicarDetDocumento.cmbtipo.Text = "RIMAC OBREROS"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 16
                    FormDuplicarDetDocumento.cmbtipo.Text = "RIMAC EMPLEADOS"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 17
                    FormDuplicarDetDocumento.cmbtipo.Text = "GASTOS REPRESENTACION"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 18
                    FormDuplicarDetDocumento.cmbtipo.Text = "CELULARES IGV"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 19
                    FormDuplicarDetDocumento.cmbtipo.Text = "PEAJE LINEA AMARILLA 11.40 - 2"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 20
                    FormDuplicarDetDocumento.cmbtipo.Text = "PEAJE LINEA AMARILLA 10.40"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 21
                    FormDuplicarDetDocumento.cmbtipo.Text = "CREATECH INGENIERIA Y PROYECTO S.A.C."
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 22
                    FormDuplicarDetDocumento.cmbtipo.Text = "INTERNET ELOY"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 23
                    FormDuplicarDetDocumento.cmbtipo.Text = "ENTEL"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 24
                    FormDuplicarDetDocumento.cmbtipo.Text = "MEDICO"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 25
                    FormDuplicarDetDocumento.cmbtipo.Text = "PEAJE LINEA AMARILLA 11.80"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 26
                    FormDuplicarDetDocumento.cmbtipo.Text = "PEAJE RUTAS DE LIMA S.A.C."
                    FormDuplicarDetDocumento.ShowDialog()
                End While
                While Cerrardup = 27
                    FormDuplicarDetDocumento.cmbtipo.Text = "MAPFRE"
                    FormDuplicarDetDocumento.ShowDialog()
                End While
            Case "0504020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0504030000"
                est1(True)
                getCmbAño(cmbaño)
                btnVentas.Visible = True
                btnVentas.Text = "Excel"
                btnstocktodos.Text = "Limpiar Excel"
                btnstocktodos.Visible = True
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0504040"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0504050000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0504060000"
                FormKardexConta.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0504070000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0504080000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0504090000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0504110000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0504140000"
                est1(True)
                getCmbAño(cmbaño)
                Label3.Text = "Tipo Credito"
                cmbTipoCred.Visible = True
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0803020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0803030000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0803040000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0504100000"
                'FormCargaDetAsiento.ShowDialog()
                'TSButtonRefresh_Click(Nothing, Nothing)
                ''End If
                gnOpcion3 = "0"
                FormCargaDetAsiento.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0504120000"
                FormSeguimientoClientes.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0504130000"
                FormFlujoProyectado.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0505010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0506010000"
                gsCode10 = "1"
                FormRptDetEncuestaINEI.ShowDialog()
                gsCode10 = ""
            Case "0506020000"
                gsCode10 = "2"
                FormRptDetEncuestaINEI.ShowDialog()
                gsCode10 = ""
            Case "0506030000"
                FormRptDetEssalud.ShowDialog()
            Case "0602010000"
                gnOpcion3 = "1"
                FormClasificacionProveedor.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                gnOpcion3 = Nothing
            Case "0602020000"
                FormRPTConsumo.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0404140000"
                FormRPTConsumo.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303160000"
                FormRPTDespClienteMed.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0204030000"
                FormReporte_T_Env.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0204050000"
                FormRptLineaSubliena.ShowDialog()
            Case "0204070000"
                FormEtiquetasCaja.ShowDialog()
            Case "0204060000"
                FormReporteStock.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0204080000"
                FormRptDetRecep.ShowDialog()
            Case "0204100000"
                FormRepMovimHojalata.ShowDialog()
            Case "0204110000"
                FormRptDocTrans.ShowDialog()
            'Case "0204120000"
            '    FormRPTBINDCARD.ShowDialog()
            Case "0204130000"
                FormRPTGUIASDESPACHO.ShowDialog()
            Case "0204140000"
                FormRPTDESPACHO.ShowDialog()
            Case "0204150000"
                FormConsumoPersonal.ShowDialog()
            Case "0801330000"
                FormDetalleIngresos.ShowDialog()
            Case "0204160000"
                FormReporteBindCard.ShowDialog()
            Case "0204170000"
                FormReporteInventario.ShowDialog()
            Case "0204180000"
                FormReporteReqxEstado.ShowDialog()
            Case "0204040000"
                FormRptSolMat.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303030000"
                FormRptDespachoCli.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303040000"
                FormRptVentasVendedor.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303050000"
                FormRptVenMedida.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303060000"
                FormRptResuCliente.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303070000"
                'sOp = "1"
                FormRPTDespResuCli.ShowDialog()
                sOp = Nothing
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303080000"
                FormRPTVentasAnualCli.ShowDialog()
                sOp = Nothing
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0303090000"
                FormRPTVentasProdMed.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0404020000"
                sOp = "0"
                FormRepProdAll.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                sOp = ""
            Case "0404030000"
                sOp = "1"
                FormRepProdAll.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                sOp = ""
            Case "0404040000"
                FormRPTAnalisProd.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0404100000"
                FormRepFallAll.ShowDialog()
                'FormRepFallProd.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0404110000"
                FormRPTMerma.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0404120000"
                FormRepReinAll.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502020000"
                est4(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0502030000"
                est4(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0503010000"
                est1(True)
                getCmbAño(cmbaño)
                btnVentas.Visible = True
                btnVentas.Text = "Generar Ventas"
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0503020000"
                est1(True)
                getCmbAño(cmbaño)
                btnVentas.Visible = True
                btnVentas.Text = "Generar Compras"
                btnlet.Visible = True
                btnlet.Text = "Excel"
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0503040000"
                est1(True)
                getCmbAño(cmbaño)
                btnVentas.Visible = True
                btnVentas.Text = "Generar No Dom."
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0503050000"
                Dim dtPagos As New DataTable
                'sMes = mes(sMes)
                est1(True)
                getCmbAño(cmbaño)
                btnVentas.Visible = True
                btnVentas.Text = "Ordenar Pagos"
                cmbaño.SelectedItem = sAño
                primero = False
                dtPagos = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, "010", "")
                dgvMain.DataSource = dtPagos
                gdtMainData = dtPagos
                dgvMain.Refresh()
            Case "0503060000"
                Dim dtPagos As New DataTable
                'sMes = mes(sMes)
                est1(True)
                getCmbAño(cmbaño)
                btnVentas.Visible = True
                btnVentas.Text = "Ordenar Cobranzas"
                cmbaño.SelectedItem = sAño
                primero = False
                dtPagos = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, "013", "")
                dgvMain.DataSource = dtPagos
                gdtMainData = dtPagos
                dgvMain.Refresh()
            Case "0503070000"
                Dim dtPagos As New DataTable
                'sMes = mes(sMes)
                est1(True)
                getCmbAño(cmbaño)
                btnVentas.Visible = True
                btnVentas.Text = "Ordenar Diario"
                cmbaño.SelectedItem = sAño
                primero = False
                dtPagos = CONTABILIDADBL.selectall(cmbaño.SelectedItem, sMes, "007")
                dgvMain.DataSource = dtPagos
                gdtMainData = dtPagos
                dgvMain.Refresh()
            Case "0503080000"
                Dim dtPagos As New DataTable
                'sMes = mes(sMes)
                est1(True)
                getCmbAño(cmbaño)
                btnVentas.Visible = True
                btnVentas.Text = "Ordenar Liquidaciones"
                cmbaño.SelectedItem = sAño
                primero = False
                dtPagos = CONTABILIDADBL.selectall(cmbaño.SelectedItem, sMes, "009")
                dgvMain.DataSource = dtPagos
                gdtMainData = dtPagos
                dgvMain.Refresh()
            Case "0602030000"
                FormRptConsVal.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0602040000"
                FormRptComprasArt.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0602050000"
                FormRPTResuComprasServ.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0602060000"
                FormRptDetRecep.ShowDialog()
            Case "0602080000"
                FormRPTConDevolucion.ShowDialog()
            Case "0602090000"
                FormRptRegistroCobranza.ShowDialog()
            Case "0603010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0603020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0603030000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0604010000"
                dt = ELTBPROVEEDORESBL.SelectAll
                dgvMain.DataSource = dt
            Case "0604020000"
                est(True)
                dt = ARTICULOBL.getListLinearticulo()
                GetCmb("LIN_CODIGO", "LIN_DESCRI", dt, cmblinea)
                primero = False
            Case "0604030000"
                dt = CIIUBL.SelectAll
                dgvMain.DataSource = dt
            Case "0701010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                cmb_tipo.Items.Clear()
                cmb_tipo.Items.Add("NADA")
                cmb_tipo.Items.Add("PENDIENTE")
                cmb_tipo.Items.Add("APROBADO")
                cmb_tipo.Items.Add("RECHAZADO")
                cmb_tipo.Items.Add("PROCESADO")
                cmb_tipo.Items.Add("TODOS")
                cmb_tipo.SelectedIndex = 1
                cmb_tipo.Visible = True
            Case "0702050000" 'TODO - TIPO DE FALLA
                TSButtonRefresh_Click(TSButtonRefresh, Nothing)
            Case "0703010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                If gsUser = "JTUCNO" Or gsUser = "BROJAS" Or gsUser = "RCONISLLA" Or gsUser = "JVALVERDE" Then
                    chkest.Visible = True
                    chkest.Text = "Todos"
                End If
                primero = False
            Case "0703020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0703030000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0703040000"
                est1(True)
                getCmbAño(cmbaño)

                Dim nvl As String = ELTBUSERBL.SelectUsuNvl(gsCodUsr)
                If nvl = "1" Or gsUser = "SISTEMA" Or gsUser = "JTUCNO" Or gsUser = "BROJAS" Or gsUser = "JTRIGOS" Or gsUser = "JVALVERDE" Then
                    rdbapr1.Enabled = True
                Else
                    rdbapr1.Enabled = False
                End If
                If gsUser = "RCONISLLA" Or gsUser = "SISTEMA" Or gsUser = "JTRIGOS" Or gsUser = "JVALVERDE" Then
                    rdbapr2.Enabled = True
                Else
                    rdbapr2.Enabled = False
                End If
                rdbapr3.Visible = False
                rdbapr4.Enabled = True
                rdbapr4.Checked = True
                grphoras.Visible = True

                cmbaño.SelectedItem = sAño
                primero = False
            Case "0801010000"
                FormHoraAsistencia.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0801020000"
                FormRptContrato.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0801030000"
                FormRptAfiliaAFP.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0801040000"
                If gsUser <> "RCONISLLA" Then
                    FormRptRemuAfp.ShowDialog()
                End If
            Case "0801050000"
                If gsUser <> "RCONISLLA" Then
                    FormRptNetoAPagar.ShowDialog()
                End If
            Case "0801060000"
                If gsUser <> "RCONISLLA" Then
                    FormRptPerEstado.ShowDialog()
                End If
            'Case "0801070000"
            '    If gsUser <> "RCONISLLA" Then
            '        FormRptBoletaPago.ShowDialog()
            '    End If
            Case "0801070000"
                If gsUser <> "RCONISLLA" Then
                    FormRptBoletaPagoNuevo.ShowDialog()
                End If
            Case "0803010000"
                FormRegistroBonoNocturno.ShowDialog()
            Case "0801200000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0801210000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0801220000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False

            Case "0401060000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                grphoras.Visible = True

            Case "0801230000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False

            Case "0801080000"
                FormRptVacaciones.ShowDialog()
            Case "0801090000"
                gsRptArgs = {}
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTPERACTPUERTA.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0801100000"
                FormRptSCTR.ShowDialog()
            Case "0801110000"
                FormRptVidaLey.ShowDialog()
            Case "0801120000"
                gsRptArgs = {}
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_PERSONAL_SIN_CTS.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0801130000"
                FormRptAFPPer.ShowDialog()
            Case "0801140000"
                FormTextoPago.ShowDialog()
            Case "0801150000"
                FormRptHorExtPer.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0801160000"
                FormRptVacaPend.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0801170000"
                If gsUser <> "RCONISLLA" Then
                    FormRptBoletaCTS.ShowDialog()
                End If
            Case "0801180000"
                FormRptPerCesado.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0801190000"
                FormRptVencContrato.ShowDialog()
            Case "0802020000"
                If gsUser <> "JMONTES" And gsUser <> "LPIÑA" And gsUser <> "MPEÑA" And 'gsUser <> "RCONISLLA" And 
                    gsUser <> "JFLORES" And gsUser <> "JTRIGOS" Then
                    dt = PERBL.SelPerAll()
                    dgvMain.DataSource = dt
                    btnVentas.Visible = True
                    btnVentas.Text = "Ingreso Días"
                    chkest.Visible = True
                    chkest.Text = "Todos"
                    btnlimpiar.Visible = True
                    cmb_tipo.Visible = True
                    'MPEÑA
                ElseIf gsUser = "JMONTES" Or gsUser = "LPIÑA" Or gsUser = "MPEÑA" Or gsUser = "RCONISLLA" Or gsUser = "JFLORES" Or gsUser = "JTRIGOS" Then
                    dt = PERBL.SelPerAll()
                    dgvMain.DataSource = dt
                    'If gsUser <> "RCONISLLA" Then
                    '    btnlimpiar.Visible = True
                    '    btnVentas.Text = "Ingreso Días"
                    '    btnVentas.Visible = True
                    'End If
                    chkest.Visible = True
                    chkest.Text = "Todos"
                    btnVentas.Text = "Ingreso Días"
                    btnVentas.Visible = True
                    cmb_tipo.Items.Clear()
                    cmb_tipo.Items.Add("")
                    cmb_tipo.Items.Add("EMPLEADO")
                    cmb_tipo.Items.Add("OBRERO")
                    cmb_tipo.Visible = True
                    cmb_tipo.Enabled = True
                    chkest.Text = "Todos"
                    cmb_tipo.SelectedIndex = 2

                End If

            Case "0802010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False


            Case "0802040000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0802030000"
                dt = ELTBCONCEPTOSBL.SelectAll
                dgvMain.DataSource = dt
            Case "0802050000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0802060000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0802070000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0802080000"
                FormMantPlanilla.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802090000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0802100000"
                cmb_tipo.Items.Clear()
                cmb_tipo.Items.Add("")
                cmb_tipo.Items.Add("DIURNO")
                cmb_tipo.Items.Add("NOCTURNO")
                cmb_tipo.Visible = True
                dt = PERROTBL.SelPerAll(cmb_tipo.Text)
                dgvMain.DataSource = dt
                'Case "0901010000"
                '    est1(True)
                '    getCmbAño(cmbaño)
                '    cmbaño.SelectedItem = sAño
                '    primero = False
            Case "0802110000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0204120000"
                chkest.Visible = True
                chkest.Text = "Est. BC"
                cmb_tipo.Visible = True
                cmb_tipo.Items.Clear()
                cmb_tipo.Items.Add("TODOS")
                cmb_tipo.Items.Add("ATENDIDO")
                cmb_tipo.Items.Add("PENDIENTE")
                cmb_tipo.Items.Add("GENERADO")
                cmb_tipo.Items.Add("ANULADO")
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0802120000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0802130000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0802140000"
                'est1(True)
                'getCmbAño(cmbaño)
                'cmbaño.SelectedItem = sAño
                primero = False
            Case "0802160000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0801170000"
                If gsUser <> "RCONISLLA" Then
                    FormRptBoletaCTS.ShowDialog()
                End If
            Case "0801240000"
                FormRPTREMGLOBAL.ShowDialog()
            Case "0801250000"
                FormRPTPRESTAMOPER.ShowDialog()
            Case "0801260000"
                FormRptQuinta.ShowDialog()
            Case "0801270000"
                FormRptHorExt.ShowDialog()
            Case "0801280000"
                FormRptResumenSenati.ShowDialog()
            Case "0801290000"
                FormRptRemuPla.ShowDialog()
            Case "0801300000"
                gsRptArgs = {}
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PER_ACTADELANTO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0801310000"
                gsCode11 = "1"
                FormRptResumenSenati.ShowDialog()
                gsCode11 = ""
            Case "0801320000"
                FormRptListAFP.ShowDialog()
            Case "1202010000"
                est1(True)
                getCmbAño(cmbaño)
                chkest.Visible = True
                chkest.Text = "Todos"
                cmbaño.SelectedItem = sAño
                primero = False
            Case "1202020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False

            Case "0901010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "0901020000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
            Case "1101010000"
                FormMantCosteoArt.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "1101020000"
                FormProcesoCostos.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0401060000"
                FormBonoProduccion.ShowDialog()
            Case "1301010000"
                FormRegistroAsistencia.ShowDialog()
            Case "1502020000"
                FormAnalPtoMantenimiento.ShowDialog()
            Case "1502010000"
                FormRPTAnalisis_Presupuesto.ShowDialog()
            Case "1502030000"
                FormRPT_Cliente_Ventas_totales.ShowDialog()
            Case "1401010000"
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
        End Select
        'Renombrar y mostrar Columnas
        dgvMain.CurrentCell = Nothing

        If gsMenuNodeId <> "0505010000" Then
            If gsMenuNodeId <> "0402010000" Then

                If gsMenuNodeId <> "0402020000" Then
                    If gsMenuNodeId <> "0402020000" Then
                        'If gsMenuNodeId <> "0401050000" Then
                        If gsMenuNodeId <> "0206010000" Then
                            If gsMenuNodeId <> "0206020000" Then
                                If gsMenuNodeId <> "0205030000" Then
                                    If gsMenuNodeId <> "0503020000" Then
                                        If gsMenuNodeId <> "0503020000" Then
                                            gHeader(dgvMain)
                                        End If

                                    End If
                                End If
                                'gHeader(dgvMain)
                            End If
                        End If
                        'End If
                    End If
                End If

            End If
        End If

        On Error Resume Next
        dgvMain.CurrentCell = dgvMain.Item(0, 0)
        TSButtonRefresh_Click(Nothing, Nothing)
        If gsMenuNodeId = "0205020000" Then
            gdtMainData = dt
            recNo = 0
            tsbCamposSeek.Items.Clear()
            tsbCamposSeek.Items.Add("NRO_DOC_REF")
            tsbCamposSeek.Items.Add("CCO_COD")
            tsbCamposSeek.Items.Add("ART_COD")
            tsbCamposSeek.Items.Add("NOM_ART")
            tsbCamposSeek.Items.Add("REQ_APROB")
            lblRecNo.Text = dgvMain.Rows.Count
        End If


    End Sub

    Private Sub UcAcMnu1_EventClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormLoginCPC.Dispose()
    End Sub

    Private Sub TSButtonNuevo_Click(sender As Object, e As EventArgs) Handles TSButtonNuevo.Click
        gnOpcion = 0
        showForm(gsMenuNodeId)
    End Sub

    Private Sub tsButtonEdicion_Click(sender As Object, e As EventArgs) Handles tsButtonEdicion.Click
        gnOpcion = 1
        showForm(gsMenuNodeId)
    End Sub

    Private Sub showForm(ByVal mnuId As String)
        Dim sSearch = tsbCamposSeek.Text
        Dim sMes As String = mes(cmbmes.SelectedItem)
        'TSButtonNuevo.Enabled = True
        'si opcion = 1 (edicion y esta vacio)
        If dgvMain.Rows.Count >= 1 Then
            ' If DGFields.Rows >= 1 Theni
            sTDoc = Nothing
            sSDoc = Nothing
            sNDoc = Nothing
            gArt = Nothing
            If IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(0).Value) Then
                Exit Sub
            End If
            gsCode = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(0).Value
            sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(0).Value
            If mnuId <> "0502050000" And mnuId <> "0304020000" And mnuId <> "0201050000" Then
                sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value
            End If
        End If

        'nuevos registros
        'Case de actualizacion del dg del main
        Select Case mnuId
            Case "0101020000"
                FormMntELTBUSER.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0102010000"
                FormMantELTBALMACEN.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0102020000"
                sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                FormMantELTBCOSTOGASTO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0102040000"
                sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                FormMantCentroCosto.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0102050000"
                'sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                FormMantELTBGRUPCOR.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0405010000"
                'sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                FormMantELTBOPER.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0405020000"
                'sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                If gnOpcion = "1" Then
                    gsCode = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(0).Value
                End If
                FormMantELTBArea.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0405030000"
                'sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                FormMantELTBPROC.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0405040000"
                'sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                FormMantELTBGRUPO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0405050000"
                gsCode = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                FormMantELTBLINEA.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0405060000"
                FormELESPECIFICACIONES_t.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0401050000"
                If dgvMain.Rows.Count > 0 Then
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NUMERO").Value
                    gsCode11 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("C_COS").Value
                End If
                FormELTBSTURN.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                gsCode11 = ""
                sSDoc = ""
                sNDoc = ""
            Case "0401030000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                End If
                FormOrdenProgramas.ShowDialog()
                gsCode7 = ""
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0201020000"
                If gsUser = "JTUCNO" Or gsUser = "BROJAS" Then
                    If dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("LIN_CODIGO").Value = "0800" Then
                        FormMantELTBLINES.ShowDialog()
                        TSButtonRefresh_Click(Nothing, Nothing)
                    Else
                        MsgBox("Usted No Tiene Permisos para modificar")
                    End If
                Else
                    FormMantELTBLINES.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0103010000"
                FormMantELTBMESSAGE.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0201040200"
                FormMantELTBCARA.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0201040100"
                FormMantELTBCATA.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0201010000"
                FormMantUNI.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0201050000"
                FormMantT_Medida.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                'Articulo Modificado por usuario
            Case "02000000"
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    If gsUser = "JTUCNO" Or gsUser = "JCACERES" Or gsUser = "MPEÑA" Or gsUser = "BROJAS" Then
                        If Mid(cmbsublinea.SelectedValue, 1, 2) = "08" Or Mid(cmbsublinea.SelectedValue, 1, 2) = "07" Or Mid(cmbsublinea.SelectedValue, 1, 2) = "05" Or Mid(cmbsublinea.SelectedValue, 1, 2) = "04" Then
                            gsCode3 = RTrim(cmbsublinea.SelectedValue)
                            FormMantArticulo.ShowDialog()
                            TSButtonRefresh_Click(Nothing, Nothing)
                        Else
                            MsgBox("No tiene accesos a estas lineas")
                        End If
                    ElseIf gsUser = "ACRUZ" Or gsUser = "DMOREANO" Or gsUser = "MVELOZ" Then
                        If Mid(cmbsublinea.SelectedValue, 1, 2) = "07" Then
                            gsCode3 = RTrim(cmbsublinea.SelectedValue)
                            FormMantArticulo.ShowDialog()
                            TSButtonRefresh_Click(Nothing, Nothing)
                        Else
                            MsgBox("No tiene accesos a estas lineas")
                        End If
                    Else
                        gsCode3 = RTrim(cmbsublinea.SelectedValue)
                        FormMantArticulo.ShowDialog()
                        TSButtonRefresh_Click(Nothing, Nothing)
                    End If

                Else
                    MsgBox("Seleccione Linea y Sublinea")
                End If

            Case "0201060000"
                FormMantT_MOVINV.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)

            Case "0203010000"
                FormMantRequerimiento.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0603010000"
                Dim frm As New FormMantRequerimiento
                frm.vista = 1
                frm.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0603020000"
                Dim frm As New FormMantRequerimiento
                frm.vista = 1
                frm.ShowDialog()
                'FormMantRequerimiento.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0604010000"
                FormMantELTBPROVEEDORES.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0604020000"
                gsCode = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                FormPrecioCompra.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0604030000"
                'gsCode = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                sOp = "1"
                FormCIIU.ShowDialog()
                sOp = ""
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0203040000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = "SOLM"
                    'gsCode10 = Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("LINEA").Value, 1, 2)
                End If
                FormMantELTBSOLMATERIALES.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                gsCode10 = ""

            Case "0203060000"
                'If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                End If
                FormMantFCRecepComp.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                'End If
            Case "0203070000"
                'If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                End If
                FormELTBSOLMMAS.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                'End If

            Case "0203050000"
                If gsUser = "LVERGARA" Or gsUser = "DSANDOVAL" Or gsUser = "DIGITACION1" Or gsUser = "MTANTAS" Then
                    MsgBox("No tiene permisos para realizar esta accion")
                    Exit Sub
                End If
                If gnOpcion = "0" Then
                    If cmbsublinea.SelectedIndex <> -1 Then
                        If dgvMain.Rows.Count > 0 Then
                            Dim dt As DataTable
                            dt = ARTICULOBL.SelectArticuloStock(cmbsublinea.SelectedValue, gsCodAlm)
                            If dt.Rows.Count > 0 Then
                                If MessageBox.Show("Hay " & dt.Rows.Count & " Articulos sin stock desea ingresarlos? ",
                                               gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                                    Exit Sub
                                Else
                                    gnOpcion = 0
                                    'Dim Datos() As String
                                    For Each filas In dt.Rows
                                        If Cerrar = "Cerrar" Then
                                            Cerrar = ""
                                            Exit Sub
                                        Else
                                            Dim frm As New FormMantStockFisico
                                            frm.txtcodart.Text = filas("ART_CODIGO")
                                            frm.txtnomart.Text = filas("NOM_ART")
                                            frm.txtunidad.Text = ARTICULOBL.SelectUniMed(filas("ART_CODIGO"))
                                            frm.npdstock.Select()
                                            frm.ShowDialog()
                                            TSButtonRefresh_Click(Nothing, Nothing)
                                        End If
                                    Next
                                End If
                            Else
                                MsgBox("No hay articulos de Sublinea para ingresar Stock")
                            End If
                        Else
                            MsgBox("Todos los articulos listados cuentan con stock")
                        End If
                    Else
                        MsgBox("No hay articulos de Sublinea para ingresar Stock")
                    End If
                Else
                    If dgvMain.Rows.Count > 0 Then
                        FormMantStockFisico.txtcodart.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(0).Value
                        FormMantStockFisico.txtnomart.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value
                        FormMantStockFisico.txtunidad.Text = ARTICULOBL.SelectUniMed(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(0).Value)
                        'FormMantStockFisico.npdstock.Value = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value
                        'FormMantStockFisico.npdstock.Value = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(3).Value
                        'MOVER PARA CUANDO SE PONGA UN NUEVO STOCK
                        FormMantStockFisico.npdstock.Value = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(3).Value
                        FormMantStockFisico.npdstock.Select()
                        FormMantStockFisico.ShowDialog()
                        TSButtonRefresh_Click(Nothing, Nothing)
                    End If
                End If

            Case "0203020000"
                'Dim sMes As String = mes(cmbmes.SelectedItem)
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                FormMantGuiaAlmacen.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0206020000"
                If gnOpcion = "1" Then
                    sOp = "0"
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    sCos = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                    FormObsRecepDoc.txtobserva.ReadOnly = True
                    FormObsRecepDoc.cmbobserva.Enabled = True
                    FormObsRecepDoc.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0204120000"
                bcSERIE = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SERIE").Value
                bcNUMERO = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NUMERO").Value
                bcCODART = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ARTCOD").Value
                bcCANTIDAD = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CANTIDAD").Value
                bcARTICULO = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ARTICULO").Value
                bcESTADO = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ESTADO").Value
                bcMEDIDA = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("MEDIDA").Value
                bcUSUARIO = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("USUARIO").Value
                bcFECGENE = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("FECHA").Value
                bcKARDEX = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("FECHA").Value
                bcLOTE = IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("LOTE").Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("LOTE").Value)
                bcKARDEX = IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("KARDEX").Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("KARDEX").Value)
                bcGUIA = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("GUIA").Value
                FormRegistroDetBindCard.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0401040000"
                'Dim sMes As String = mes(cmbmes.SelectedItem)
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                If dgvMain.Rows.Count > 0 Then
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    gsCode11 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CCO_COD").Value
                End If
                If rdbapr3.Checked = True Then
                    FormELTBSTIEMRH.ShowDialog()
                ElseIf rdbapr2.Checked = True Then
                    FormELTBSTIEMJF.ShowDialog()
                Else
                    FormELTBSTiem.ShowDialog()
                End If
                TSButtonRefresh_Click(Nothing, Nothing)
                gsCode11 = ""
                sSDoc = ""
                sNDoc = ""
            Case "0302010000"
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                FormMantOrdenCompra.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0302020000"
                Dim mm As String
                Dim dd As String
                Dim dt As DataTable
                If gsUser <> "WJAIME" Then
                    If gnOpcion = "0" Then
                        If DateTime.Now.ToString("mm").Length = "1" Then
                            mm = "0" & DateTime.Now.ToString("MM")
                        Else
                            mm = DateTime.Now.ToString("MM")
                        End If
                        If DateTime.Now.ToString("dd").Length = "1" Then
                            dd = "0" & DateTime.Now.ToString("dd")
                        Else
                            dd = DateTime.Now.ToString("dd")
                        End If
                        dt = REQUERIMIENTOBL.getT_CAMB(DateTime.Now.ToString("yyyy") & "/" & mm & "/" & dd)
                        If dt.Rows.Count = 0 Then
                            MsgBox("Ingrese el Tipo de Cambio del dia")
                            Exit Sub
                        End If
                    End If
                End If
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                FormMantGuiaDespacho.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0304030000"
                If gsUser = "OBEIZAGA" Then
                    sOp = "1"
                End If
                If gsUser = "CHOYOS" Or gsUser = "SGARCIA" Or gsUser = "SISTEMA" Then
                    FormMantELTBCLIENTE.tsbCierre.Enabled = True
                End If
                FormMantELTBCLIENTE.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                sOp = ""
            Case "0302030000"
                Dim mm As String
                Dim dd As String
                Dim dt As DataTable
                If gnOpcion = "0" Then
                    If DateTime.Now.ToString("mm").Length = "1" Then
                        mm = "0" & DateTime.Now.ToString("MM")
                    Else
                        mm = DateTime.Now.ToString("MM")
                    End If
                    If DateTime.Now.ToString("dd").Length = "1" Then
                        dd = "0" & DateTime.Now.ToString("dd")
                    Else
                        dd = DateTime.Now.ToString("dd")
                    End If
                    dt = REQUERIMIENTOBL.getT_CAMB(DateTime.Now.ToString("yyyy") & "/" & mm & "/" & dd)
                    If dt.Rows.Count = 0 Then
                        MsgBox("Ingrese el Tipo de Cambio del dia")
                        Exit Sub
                    End If
                End If
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                FormMantFacturacion.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0302040000"
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                FormMantBoleta.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0302050000"
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                FormMantNotaCredito.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0302060000"
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                FormMantNotaDebito.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0302070000"
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                FormMantLetras.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0304020000"
                If cmbtipsunat.Text = "SUNAT" Then
                    sTDoc = ""
                Else
                    sTDoc = "1"
                End If

                FormMantELTBTIPOCAMBIO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                sTDoc = ""
            Case "0304010300"
                Cerrar = "Man"
                sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD_TRACTOR").Value
                FormMantELTBTRANSPTRACTOR.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0304010200"
                Cerrar = "Man"
                sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD_CHOFER").Value
                FormMantELTBTRANSPCHOFER.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)

            Case "0304010100"
                FormMantELTBTRANSP.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0304040000"
                FormELARTCARACTERISTI.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0205010000"
                'gsCode2 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                'gsCode3 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CANTIDAD").Value
                'FormModifGuia.Label5.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                'FormModifGuia.Label6.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                'FormModifGuia.Label7.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                'FormModifGuia.Label8.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF1").Value
                'FormModifGuia.Label9.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF1").Value
                'FormModifGuia.Label10.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                'FormModifGuia.Label13.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ALMAC").Value
                'gsAño = cmbaño.SelectedItem.ToString
                'gsMes = DateTime.Now.ToString("MM")
                'FormModifGuia.ShowDialog()
                'TSButtonRefresh_Click(Nothing, Nothing)
                Dim tip As String = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                Dim ser As String = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                Dim nro As String = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value

                Dim dt As DataTable
                dt = GUIAALMACENBL.SelectDatosCOD(tip, ser, nro)
                gsCode4 = dt.Rows(0).Item(0).ToString  'MOVIMI
                gsCode5 = dt.Rows(0).Item(1).ToString  'ART2 ANTIGUO
                gsCode6 = dt.Rows(0).Item(2).ToString  'ALMACEN

                If gsCode4 = "E19" Or gsCode4 = "E12" Or gsCode4 = "E20" Or gsCode4 = "E17" Or gsCode4 = "E14" Or dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF1").Value = "SOLM" Then
                    Exit Sub
                ElseIf gsCode4 = "E18" Or gsCode4 = "S30" Then
                    gsCode2 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value 'ART1 ANTIGUO
                    gsCode3 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CANTIDAD").Value
                    FormModifGuiaTrans.Label5.Text = tip
                    FormModifGuiaTrans.Label6.Text = ser
                    FormModifGuiaTrans.Label7.Text = nro
                    FormModifGuiaTrans.Label8.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF1").Value
                    FormModifGuiaTrans.Label9.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF1").Value
                    FormModifGuiaTrans.Label10.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                    FormModifGuiaTrans.Label13.Text = gsCode4

                    gsAño = cmbaño.SelectedItem.ToString
                    'gsMes = DateTime.Now.ToString("MM")
                    gsMes = Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("FEC_GENE").Value, 4, 2)
                    FormModifGuiaTrans.ShowDialog()
                Else
                    gsCode2 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                    gsCode3 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CANTIDAD").Value
                    FormModifGuia.Label5.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    FormModifGuia.Label6.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    FormModifGuia.Label7.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    FormModifGuia.Label8.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF1").Value
                    FormModifGuia.Label9.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF1").Value
                    FormModifGuia.Label10.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF1").Value
                    FormModifGuia.Label13.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ALMAC").Value
                    FormModifGuia.Label16.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_MOVINV").Value
                    FormModifGuia.Label17.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("FEC_GENE").Value
                    gsAño = cmbaño.SelectedItem.ToString
                    If dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF1").Value = "RPD" Then
                        FormModifGuia.txtcodart.Enabled = False
                        FormModifGuia.cmbArticulo.Enabled = False
                        FormModifGuia.npdcantidad.Enabled = False
                        FormModifGuia.btnbuscar.Enabled = False
                    End If
                    'gsMes = DateTime.Now.ToString("MM")
                    gsMes = Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("FEC_GENE").Value, 4, 2)

                    FormModifGuia.ShowDialog()
                End If
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0203030000"
                sTDoc = "REQ"
                FormReque_Ok.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                'Case "0204010000"
                '    FormMovim.ShowDialog()
                '    TSButtonRefresh_Click(Nothing, Nothing)
            Case "0401010100"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(0).Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(9).Value
                    sOp = "0"
                    gsAño = cmbaño.SelectedItem.ToString
                    gsMes = DateTime.Now.ToString("MM")
                    FormReporte_Produccion.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                Else
                    gsAño = cmbaño.SelectedItem.ToString
                    sSDoc = sAño
                    sOp = "0"
                    FormReporte_Produccion.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
                sOp = ""
            Case "0401010200"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(0).Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(8).Value
                    sOp = "0"
                    gsAño = cmbaño.SelectedItem.ToString
                    gsMes = DateTime.Now.ToString("MM")
                    FormReingreso_Produccion.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                Else
                    gsAño = cmbaño.SelectedItem.ToString
                    sSDoc = sAño
                    sOp = "0"
                    FormReingreso_Produccion.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
                sOp = ""
            Case "0401010300"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(0).Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(8).Value
                    sOp = "0"
                    gsAño = cmbaño.SelectedItem.ToString
                    gsMes = DateTime.Now.ToString("MM")
                    FormFallados_Produccion.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                Else
                    gsAño = cmbaño.SelectedItem.ToString
                    sSDoc = sAño
                    sOp = "0"
                    FormFallados_Produccion.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
                sOp = ""
            Case "0402010000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(3).Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(4).Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(10).Value
                    sOp = "1"
                    gsAño = cmbaño.SelectedItem.ToString
                    gsMes = DateTime.Now.ToString("MM")
                    FormReporte_Produccion.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                    sOp = ""
                Else
                    'sSDoc = sAño
                    sOp = "1"
                    FormReporte_Produccion.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                    sOp = ""
                End If
            Case "0402020000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(3).Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(4).Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(10).Value
                    sOp = "1"
                    gsAño = cmbaño.SelectedItem.ToString
                    gsMes = DateTime.Now.ToString("MM")
                    If sTDoc = "RPD" Then
                        FormReporte_Produccion.ShowDialog()
                    Else
                        FormFallados_Produccion.ShowDialog()
                    End If
                    TSButtonRefresh_Click(Nothing, Nothing)
                    sOp = ""
                Else
                    'sSDoc = sAño
                    sOp = "1"
                    FormReporte_Produccion.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                    sOp = ""
                End If
                'Aprobacion solicitud de materiales
            Case "0402030000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(2).Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(3).Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(4).Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(10).Value
                    sOp = "1"
                    gsAño = cmbaño.SelectedItem.ToString
                    gsMes = DateTime.Now.ToString("MM")
                    If sTDoc = "RPD" Then
                        FormReingreso_Produccion.ShowDialog()
                    Else
                        FormReingreso_Produccion.ShowDialog()
                    End If
                    TSButtonRefresh_Click(Nothing, Nothing)
                    sOp = ""
                Else
                    'sSDoc = sAño
                    sOp = "1"
                    FormReingreso_Produccion.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                    sOp = ""
                End If
            Case "0206010000"
                'If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                sOp = "0"
                sTDoc = "SOLM"
                sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(3).Value
                sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(4).Value
                FormMantELTBSOLMATERIALES.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                sOp = ""

           'Case "0501100000"
                'FormDuaCompra.ShowDialog()
                'TSButtonRefresh_Click(Nothing, Nothing)
            Case "0501100000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                End If
                FormDuaCompra.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502030000"
                If gnOpcion = 1 Then
                    FormELTBCUENTA.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                Else
                    Dim dt As DataTable
                    dt = ELTBCUENTABL.VerificarRegistro(cmbaño.SelectedItem)
                    If dt.Rows.Count > 0 Then
                        FormELTBCUENTA.ShowDialog()
                        TSButtonRefresh_Click(Nothing, Nothing)
                    Else
                        Dim result As Integer = MessageBox.Show("No Cuenta con ningun registro para este Año. Desea Ingresarlos ?", "Informacion", MessageBoxButtons.YesNo)
                        If result = DialogResult.Yes Then
                            ELTBCUENTABL.InsertRegistro(cmbaño.SelectedItem)
                            MessageBox.Show("Se ingresó los registros de la cuenta")
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    End If
                End If
            Case "0502020000"
                If gnOpcion = 1 Then
                    gsCode = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("TIP_MOV").Value
                    gsCode2 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("TIPO_DCTO").Value
                    gsCode3 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("OPE").Value
                    gsCode4 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("AÑO").Value
                    gsCode5 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("MON").Value
                    gsCode6 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("TIPO_ITEM").Value
                    gsCode7 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD_INICIAL").Value
                    gCodAct = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD_FINAL").Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SEC").Value
                    FormMantELTBCTA_FACTURAC.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                Else
                    Dim dt As DataTable
                    dt = ELTBCTA_FACTURACIONBL.VerificarRegistro(cmbaño.SelectedItem)
                    If dt.Rows.Count > 0 Then
                        FormMantELTBCTA_FACTURAC.cmb_año.SelectedItem = cmbaño.Text
                        sOp = "0"
                        FormMantELTBCTA_FACTURAC.ShowDialog()
                        TSButtonRefresh_Click(Nothing, Nothing)
                    Else
                        Dim result As Integer = MessageBox.Show("No Cuenta con ningun registro para este Año. Desea Ingresarlos ?", "Informacion", MessageBoxButtons.YesNo)
                        If result = DialogResult.Yes Then
                            ELTBCTA_FACTURACIONBL.InsertRegistro(cmbaño.SelectedItem)
                            MessageBox.Show("Se ingresó los registros para todos los meses")
                        Else result = DialogResult.No
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    End If
                End If
            Case "0502040000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("AÑO").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("MES").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("TIPO_OPE").Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("N_REGISTRO").Value
                    sOp = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SEQ").Value
                End If
                FormTBMOVIMIENTO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502050000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_OPERACION").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_COD").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("STATUS").Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD_IMPUESTO").Value
                    If IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ANHO").Value) Then sOp = DateTime.Now.ToString("yyyy") Else sOp = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ANHO").Value
                End If
                FormELTBCUENTA_OPE.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502170000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("AÑO").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CODIGO").Value
                    'sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CUENTA").Value
                End If
                FormCtaArticulo_Compra.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502200000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ANHO").Value
                    sNDoc = Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD_BCO").Value, 1, 1)
                End If
                FormEltbInicialCB.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502220000"
                If dgvMain.Rows.Count > 0 Then
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NDOCU").Value
                End If
                FormELTBPERCEP.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)

            Case "0502010000"
                If gnOpcion = 1 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ANHO").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("MES").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_OPERACION").Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("P_BANCO").Value
                    FormELTBREGISTRO_NRO.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                Else
                    Dim dt As DataTable
                    dt = ELTBREGISTRO_NROBL.VerificarRegistro(cmbaño.Text)
                    If dt.Rows.Count > 0 Then
                        FormELTBREGISTRO_NRO.ShowDialog()
                        TSButtonRefresh_Click(Nothing, Nothing)
                    Else
                        Dim result As Integer = MessageBox.Show("No Cuenta con ningun registro para este Año. Desea Ingresarlos ?", "Informacion", MessageBoxButtons.YesNo)
                        If result = DialogResult.Yes Then
                            ELTBREGISTRO_NROBL.InsertRegistro(cmbaño.Text)
                            MessageBox.Show("Se ingresó los registros para todos los meses")
                        Else result = DialogResult.No
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    End If
                End If
            Case "0502060000"
                FormIMPUESTO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502070000"
                FormFormaEntrega.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502080000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("AÑO").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD_BANCO").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD_CUENTA").Value
                End If
                FormMantCUENTABANCO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502090000"
                FormFormaPago.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502100000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = cmbaño.SelectedItem
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("PER_COD").Value
                End If
                FormELUTILIDADES.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502110000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = cmbaño.SelectedItem
                    sSDoc = sMes
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("PER_COD").Value
                End If
                FormELLIQUIDACION.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502120000"
                FormELLIB_CONT.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502130000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = cmbaño.SelectedItem
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                End If
                FormELT_OPE.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502140000"
                If cmbaño.SelectedIndex <> -1 Then
                    Dim dt As DataTable
                    dt = ELDOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If

            Case "0502150000"
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                If chkdocexp.Checked = False Then
                    If dgvMain.Rows.Count > 0 Then
                        sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("TIPO").Value
                        sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SERIE").Value
                        sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NUMERO").Value
                        Dim mesaño As String = mes(cmbmes.Text)
                        ' VERIFICAR
                        sFecCom = Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value, 7, 4) & Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value, 4, 2)
                        'cmbaño.Text & mesaño
                        gsCode7 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("RUC").Value
                        'dgvMain.Columns(5).Visible = False
                    End If
                    Dim mea As String = mes(cmbmes.Text)
                    FormMantProvisiones.bMes = mea
                    FormMantProvisiones.ShowDialog()
                    If chkest.Checked = False Then
                        TSButtonRefresh_Click(Nothing, Nothing)
                    End If
                Else
                    If dgvMain.Rows.Count > 0 Then
                        sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("TIPO").Value
                        sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SERIE").Value
                        sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NUMERO").Value
                        Dim mesaño As String = mes(cmbmes.Text)
                        ' VERIFICAR
                        sFecCom = Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value, 7, 4) & Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value, 4, 2)
                        'cmbaño.Text & mesaño
                        gsCode7 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("RUC").Value
                        'dgvMain.Columns(5).Visible = False
                    End If
                    Dim mea As String = mes(cmbmes.Text)
                    FormMantDocExp.bMes = mea
                    FormMantDocExp.ShowDialog()
                    If chkest.Checked = False Then
                        TSButtonRefresh_Click(Nothing, Nothing)
                    End If
                End If

            Case "0502160000"
                estadoTC = 0
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("TIPO_DOC").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SERIE_DOC").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC").Value
                    sCos = Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_OPERACION").Value, 1, 3)
                End If
                FormELPAGO_DOCUMENTO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0503010000"
                Dim mm As String
                Dim dd As String
                Dim dt As DataTable
                If gnOpcion = "0" Then
                    If DateTime.Now.ToString("mm").Length = "1" Then
                        mm = "0" & DateTime.Now.ToString("MM")
                    Else
                        mm = DateTime.Now.ToString("MM")
                    End If
                    If DateTime.Now.ToString("dd").Length = "1" Then
                        dd = "0" & DateTime.Now.ToString("dd")
                    Else
                        dd = DateTime.Now.ToString("dd")
                    End If
                    dt = REQUERIMIENTOBL.getT_CAMB(DateTime.Now.ToString("yyyy") & "/" & mm & "/" & dd)
                    If dt.Rows.Count = 0 Then
                        MsgBox("Ingrese el Tipo de Cambio del dia")
                        Exit Sub
                    End If
                End If
                sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(6).Value
                sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(7).Value
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                FormMantFacturacion.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0504020000"
                If gnOpcion = 1 Then
                    If dgvMain.Rows.Count > 0 Then
                        sTDoc = "01"
                        sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                        sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    End If
                    FormMantFacEst.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0504030000"
                If gnOpcion = 1 Then
                    If dgvMain.Rows.Count > 0 Then
                        sTDoc = "80"
                        sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                        sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    End If
                    FormMantLtEst.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0504040000"
                If gnOpcion = 1 Then
                    If dgvMain.Rows.Count > 0 Then
                        sTDoc = "07"
                        sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                        sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    End If
                    FormMantNCEst.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0504050000"
                If gnOpcion = 1 Then
                    If dgvMain.Rows.Count > 0 Then
                        sTDoc = "08"
                        sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                        sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    End If
                    FormMantNDEst.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0504070000"
                If gnOpcion = 1 Then
                    If dgvMain.Rows.Count > 0 Then
                        sTDoc = "PPAG"
                        sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                        sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                        'FormMantELTBPROGPAGO.mespago = sMes1 && cmbaño.Text
                    End If
                Else
                    Dim mea As String = mes(cmbmes.Text)
                    FormMantELTBPROGPAGO.mespago = cmbaño.Text & mea
                End If
                FormMantELTBPROGPAGO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0504080000"
                'If gnOpcion = 1 Then
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = "DET"
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                End If
                FormELTBDETRACCION.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                'End If
            Case "0504090000"
                'If gnOpcion = 1 Then
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = "DIMP"
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                End If
                FormELTBKardexImp.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                'End If

            Case "0505010000"
                If gnOpcion = "1" Then
                    sOp = "0"
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    sCos = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                    FormObsRecepDoc.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0702050000"
                gsCode = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("tfa_codigo").Value
                FrmMantTipoFalla.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0701010000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = "REQ"
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X1").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO").Value
                    sCos = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CODIGO").Value
                    gsCode7 = IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("U_SOLI").Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("U_SOLI").Value)
                    gsCode8 = IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("FECHA_ENTREGA").Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("FECHA_ENTREGA").Value)
                    gsCode9 = IIf(IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("U_ENT").Value), "", dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("U_ENT").Value)
                End If
                If gsUser = "JTUCNO" Or gsUser = "SISTEMA" Or gsUser = "RCONISLLA" Or gsUser = "DCONDOR" Or gsUser = "BROJAS" Then
                    FormMantAtencionReq.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0703010000"
                'If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                sOp = "0"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    If gsUser = "JTUCNO" Or gsUser = "RCONISLLA" Or gsUser = "JVALVERDE" Or gsUser = "BROJAS" Then
                        sOp = "1"
                    End If
                End If
                FormELTBMANTENIMIENTO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                'End If
            Case "0703020000"
                ' Segunda Pantalla 
                If dgvMain.Rows.Count > 0 And gnOpcion = 1 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    sOp = "1"
                End If
                FormOrdenMantenimiento.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)

              ''  If dgvMain.Rows.Count > 0 Then 
              ''      sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
              ''      sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
              ''      sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
              ''  End If 
              ''  sOp = "1" 
              ''  FormELTBMANTENIMIENTO.ShowDialog() 
              ''  TSButtonRefresh_Click(Nothing, Nothing) 

            Case "0703030000"
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                If dgvMain.Rows.Count > 0 Then
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    gsCode11 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("AREA").Value
                End If
                ' If dgvMain.Rows.Count > 0 And gnOpcion = 1 Then
                '     sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                '     sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                '     sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                '     sOp = "1"
                ' End If
                FormELTBSTIEMOM.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0703040000"
                gsMes = cmbaño.SelectedItem & mes(cmbmes.SelectedItem)
                If dgvMain.Rows.Count > 0 Then
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                End If
                If gnOpcion = "0" And rdbapr2.Checked = True Or rdbapr1.Checked = True Then
                    'FormELTBSTIEMJF.ShowDialog()
                    MessageBox.Show("Sin Vista")
                Else
                    FormReporte_Trabajo.ShowDialog()
                End If
                TSButtonRefresh_Click(Nothing, Nothing)
                gsCode11 = ""
                sSDoc = ""
                sNDoc = ""
            Case "0802020000"
                FormMantPersonal.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0803020000"
                FormRegistroMemos.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0803030000"
                sAño = cmbaño.SelectedItem
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T.DOC.").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER.DOC").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO.DOC").Value
                    SPerDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CODIGO").Value
                End If
                FormPrestamoPer.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0504110000"
                If dgvMain.Rows.Count > 0 Then
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC").Value
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC").Value
                    sTOpe = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_OPE").Value
                End If
                sAñoLD = cmbaño.SelectedItem
                sMesLD = cmbmes.SelectedItem
                Select Case sMes
                    Case "Enero"
                        sMesLD = "01"
                    Case "Febrero"
                        sMesLD = "02"
                    Case "Marzo"
                        sMesLD = "03"
                    Case "Abril"
                        sMesLD = "04"
                    Case "Mayo"
                        sMesLD = "05"
                    Case "Junio"
                        sMesLD = "06"
                    Case "Julio"
                        sMesLD = "07"
                    Case "Agosto"
                        sMesLD = "08"
                    Case "Septiembre"
                        sMesLD = "09"
                    Case "Octubre"
                        sMesLD = "10"
                    Case "Noviembre"
                        sMesLD = "11"
                    Case "Diciembre"
                        sMesLD = "12"
                End Select
                FormLibroDiario.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0401060000"
                FormBonoProduccion.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802010000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("DNI").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("FECHA").Value
                    If IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("INDICE").Value) Then
                        sNDoc = ""
                    Else
                        sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("INDICE").Value
                    End If

                    If IsDBNull(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOMBRES").Value) Then
                        gArt = ""
                    Else
                        gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOMBRES").Value
                    End If

                End If
                If gsUser <> "YMESTAS" Then
                    FormMantELTBTAREO.ShowDialog()
                    TSButtonRefresh_Click(Nothing, Nothing)
                End If
            Case "0802040000"
                FormMantContratos.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802030000"
                FormELTBCONCEPTOS.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802050000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("PER_COD").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("PRDO_COD").Value
                End If
                FormELVACACIONES.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802070000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("PER_COD").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("D_PROGRAMADO").Value
                End If
                FormELPROGRAMACION.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802060000"
                FormELPERIODO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802090000"
                If dgvMain.Rows.Count > 0 Then
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X1").Value
                End If
                FormELPERMISOS.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802100000"
                'If gnOpcion = 0 Then
                FormROTACION.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
                'End If
                sOp = "0802100000"
            Case "0802110000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X1").Value

                End If
                FormELSUBSIDIOS.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802120000"
                If dgvMain.Rows.Count > 0 Then
                    'sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                    'sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("F_INICIO").Value
                    If gnOpcion <> "0" Then
                        FormMantTurnoNoche.mes = mes(cmbmes.Text)
                        FormMantTurnoNoche.lblindice.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                        FormMantTurnoNoche.dptfecha.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("F_INICIO").Value
                        FormMantTurnoNoche.dtpfecfin.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("F_FINAL").Value
                        FormMantTurnoNoche.txtper.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                        FormMantTurnoNoche.txtnomper.Text = PERBL.SelectApeNom(FormMantTurnoNoche.txtper.Text)
                        If dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X1").Value = "H" Then
                            FormMantTurnoNoche.cmbestado.SelectedIndex = 1
                        ElseIf dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X1").Value = "A" Then
                            FormMantTurnoNoche.cmbestado.SelectedIndex = 2
                        Else
                            FormMantTurnoNoche.cmbestado.SelectedIndex = -1
                        End If
                        FormMantTurnoNoche.btnagregar.Enabled = False
                        FormMantTurnoNoche.btnnuevo.Enabled = False
                    Else
                        FormMantTurnoNoche.mes = mes(cmbmes.Text)
                    End If
                Else
                    FormMantTurnoNoche.mes = mes(cmbmes.Text)
                End If

                FormMantTurnoNoche.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)

            Case "0802130000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("t_doc_ref").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ser_doc_ref").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_doc_ref").Value
                End If
                FormELTBSINTOMASCOVID.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802140000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                End If
                FormELTBCARGO.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802160000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("PER_COD").Value
                    sSDoc = cmbaño.Text
                    sNDoc = sMes
                End If
                FormSUBSIDIOMONTOS.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802170000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CODIGO").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("EMPLEADO").Value
                End If
                FormRegistroVacunas.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "1202010000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("t_doc_ref").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ser_doc_ref").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_doc_ref").Value
                End If

                FormELTBCAPACITACION.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "1202020000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("t_doc_ref").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ser_doc_ref").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_doc_ref").Value
                End If

                FormELTBEVALUACION.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "1201010000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("COD").Value
                End If
                FormMantTema.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "1203010000"
                'gnOpcion3 = "0"

                'TSButtonRefresh_Click(Nothing, Nothing)
                'gnOpcion3 = Nothing
            Case "0901010000"
                If dgvMain.Rows.Count > 0 Then
                    sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CERTIFICADO").Value
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    gArt = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CLIENTE").Value
                End If
                FormELCERTIFICA.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0901020000"
                If dgvMain.Rows.Count > 0 Then

                    ReDim gsRptArgs(6)
                    gsRptArgs(0) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ARTICULO").Value
                    gsRptArgs(1) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("DESCRIPCION").Value
                    gsRptArgs(2) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CANTIDAD").Value
                    gsRptArgs(3) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("MEDIDA").Value
                    gsRptArgs(4) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("LOTE").Value
                    gsRptArgs(5) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("F_PRODUC").Value
                    gsRptArgs(6) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("LOTE_ENVASE").Value

                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTETIQUETA_TWO3.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()

                End If
            Case "110101000"
                FormMantCosteoArt.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "1401010000"
                If dgvMain.Rows.Count > 0 Then
                    sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                    sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NUMERO").Value
                End If
                FormSistIntCalidad.ShowDialog()
                TSButtonRefresh_Click(Nothing, Nothing)


        End Select

        ' gdtMainData = dgvMain.DataSource
        '   gdtMainData = dt.DataSource

        tsbCamposSeek.Text = sSearch
    End Sub

    Private Sub TSButtonRefresh_Click(sender As Object, e As EventArgs) Handles TSButtonRefresh.Click
        Dim dt As New DataTable
        Dim sMes As String = mes(cmbmes.SelectedItem)
        Dim mesaño As String = ""
        Dim ab As String = ""
        'dgvMain.Visible = True
        'dgvt2.Visible = False
        'dgvt3.Visible = False
        Select Case gsMenuNodeId
            Case "0502160000"
                If Not tipOpe = "" And Not tipMon = "" Then
                    dt = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, tipOpe, tipMon)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                    If dgvMain.Rows.Count > 0 Then
                        For i = 0 To dgvMain.Rows.Count - 1
                            If dgvMain.Rows(i).Cells("ESTADO").Value = "PEND" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.MediumVioletRed
                            End If
                        Next
                    End If
                Else
                    ab = "1"
                End If
            Case "0101020000"
                dt = ELTBUSERBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0102010000"
                dt = ELTBALMACENBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0102020000"
                dt = ELTBCOSTOGASTOBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0102040000"
                dt = CCOSTOBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0102050000"
                dt = ELTBGRUPCORBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0405010000"
                dt = ELTBOPERBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0405020000"
                dt = ELTBAREABL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0405030000"
                dt = ELTBPROCBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0405040000"
                dt = ELTBGRUPOBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0405050000"
                dt = ELTBLINEABL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0401020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELPRODUCCIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvt2.DataSource = dt
                    dgvt2.Refresh()
                    'Dim btn As New DataGridViewButtonColumn
                    'If dgvt2.Columns(0).Name = "btnAprobar" Then
                    'Else
                    '    btn.HeaderText = "Opcion"
                    '    btn.Text = "Generar OP"
                    '    btn.Name = "btnAprobar"
                    '    btn.Frozen = True
                    '    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(211, 211, 211) 'GREEN
                    '    btn.FlatStyle = FlatStyle.Flat
                    '    btn.UseColumnTextForButtonValue = True
                    '    btn.CellTemplate.Style.BackColor = Color.FromArgb(211, 211, 211)
                    '    dgvt2.Columns.Insert(0, btn)
                    '    'btn = New DataGridViewButtonColumn
                    '    'btn.HeaderText = "Desaprobar" 
                    '    'btn.Text = "Desaprobar"
                    '    'btn.Name = "btnDesaprobar"
                    '    'btn.Frozen = True
                    '    'btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                    '    'btn.FlatStyle = FlatStyle.Flat
                    '    'btn.UseColumnTextForButtonValue = True
                    '    'btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                    '    'dgvMain.Columns.Insert(1, btn)
                    'End If
                End If

            Case "0405060000"
                dt = ELESPECI_TBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0401030000"
                dt = ELORDEN_PROGRAMBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0103010000"
                dt = ELTBMESSAGEBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0201040200"
                dt = ELTBCARABL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0201040100"
                dt = ELTBCATABL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0201010000"
                dt = UNIBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0201050000"
                dt = T_MEDIDABL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0201060000"
                dt = T_MOVINVBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "02000000"
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    'recNo = 0
                    'tsbCamposSeek.Items.Clear()
                    'get columns of DGV
                    'For Each col As DataGridViewColumn In dgvMain.Columns
                    '    ' MessageBox.Show(col.Name)
                    '    tsbCamposSeek.Items.Add(col.Name)
                    'Next
                    'limpiar busqueda
                    If chkest.Checked = True Then
                        dt = ARTICULOBL.SelectAll1(cmbsublinea.SelectedValue.ToString)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        lblRecNo.Text = dgvMain.Rows.Count
                    Else
                        dt = ARTICULOBL.SelectAll(cmbsublinea.SelectedValue.ToString)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        lblRecNo.Text = dgvMain.Rows.Count
                    End If


                    'tsTextSearch.Text = ""
                    'Exit Sub
                End If
            Case "0203040000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If gsUser = "EESPINO" Then
                        dt = SOLMATERIALESBL.SelectAllUsuario("SOLM", cmbaño.SelectedItem, sMes)
                    Else
                        dt = SOLMATERIALESBL.SelectAll("SOLM", cmbaño.SelectedItem, sMes)
                    End If

                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        For i = 0 To dgvMain.Rows.Count - 1 ' count++
                            If IIf(IsDBNull(dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value), "", dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value) = "ANULADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            ElseIf IIf(IsDBNull(dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value), "", dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value) = "APROBADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                            ElseIf IIf(IsDBNull(dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value), "", dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value) = "PENDIENTE" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.DarkOrange
                            End If
                        Next
                    End If
                End If
            Case "0203060000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBRECEPCOMPBL.SelectAll(cmbaño.SelectedItem & sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        For i = 0 To dgvMain.Rows.Count - 1 ' count++
                            If IIf(IsDBNull(dgvMain.Rows(i).Cells("EST").Value), "", dgvMain.Rows(i).Cells("EST").Value) = "PENDIENTE DOCUM." Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                    End If
                End If
            Case "0304040000"
                dt = ART_UPDATEBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0203050000"
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    recNo = 0
                    tsbCamposSeek.Items.Clear()
                    'get columns of DGV
                    For Each col As DataGridViewColumn In dgvMain.Columns
                        ' MessageBox.Show(col.Name)
                        tsbCamposSeek.Items.Add(col.Name)
                    Next
                    'limpiar busqueda
                    dt = ARTICULOBL.SelectELTBARTSTOCKALL(cmbsublinea.SelectedValue.ToString, gsCodAlm)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    lblRecNo.Text = dgvMain.Rows.Count
                    tsTextSearch.Text = ""
                    'Exit Sub
                End If
            Case "0301000000"
                'dt = ELDESPACHOBL.SelectAll
                'dgvMain.DataSource = dt
                'dgvMain.Refresh()
                FormELDESPACHO.ShowDialog()
            Case "0401020100"
                dt = ELORDEN_PROGRAMBL.SelectAllOP(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0304030000"
                dt = ELTBCLIENTEBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0304020000"
                'If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                '    dt = ELTBTIPOCAMBIOBL.SelectAll(cmbaño.SelectedItem, sMes)
                '    dgvMain.DataSource = dt
                '    dgvMain.Refresh()
                'End If
                If cmbtipsunat.Text = "SUNAT" Then
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBTIPOCAMBIOBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If
                Else
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBTIPOCAMBIOBL.SelectAll1(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If
                End If
            Case "0302060000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = NOTADEBITOBL.SelectAll("08", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0203010000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REQUERIMIENTOBL.SelectAll("OREQ", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0603010000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REQUERIMIENTOBL.SelectOreqReq("OREQ", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0603020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REQUERIMIENTOBL.SelectOreqReq1("OREQ", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0604020000"
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    recNo = 0
                    tsbCamposSeek.Items.Clear()
                    'get columns of DGV
                    For Each col As DataGridViewColumn In dgvMain.Columns
                        ' MessageBox.Show(col.Name)
                        tsbCamposSeek.Items.Add(col.Name)
                    Next
                    'limpiar busqueda
                    dt = ARTICULOBL.SelectAllprecio(cmbsublinea.SelectedValue.ToString)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    lblRecNo.Text = dgvMain.Rows.Count
                    tsTextSearch.Text = ""
                    'Exit Sub
                End If
            Case "0604030000"
                dt = CIIUBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0604010000"
                dt = ELTBPROVEEDORESBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                'REVISAR
            Case "0701010000"
                'If gsUser = "JTUCNO" Or gsUser = "SISTEMA" Or gsUser = "RCONISLLA" Then
                dt = ELCUENTA_ARTBL.SelectAllOrden(cmbaño.SelectedItem, sMes, cmb_tipo.SelectedIndex)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    'alinear numericos
                    For i = 0 To dgvMain.Rows.Count - 1 ' count++
                        If IIf(IsDBNull(dgvMain.Rows(i).Cells("U_ENT").Value), "", dgvMain.Rows(i).Cells("U_ENT").Value) <> "" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                        End If
                    Next
                End If
                'End If
            Case "0203030000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = GUIAALMACENBL.SelectAllReq(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0401040000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If rdbapr1.Checked = True Then
                        dt = ELTBSTIEMBL.SelectAllHEJ(cmbaño.SelectedItem, sMes)
                        sOp = "1"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        For i = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                    ElseIf rdbapr4.Checked = True Then
                        dt = ELTBSTIEMBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        For i = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                    ElseIf rdbapr2.Checked = True Then
                        dt = ELTBSTIEMBL.SelectAllHEJP(cmbaño.SelectedItem, sMes)
                        sOp = "2"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        For i = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                    ElseIf rdbapr3.Checked = True Then
                        dt = ELTBSTIEMBL.SelectAllHERH(cmbaño.SelectedItem, sMes)
                        sOp = "3"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        '    If dgvMain.Rows(i).Cells("X").Value = "DESAPROBADO" Then
                        '        dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        '    End If
                        'Next
                    End If

                    'gHeader(dgvMain)
                End If

            Case "0401060000"
                rdbapr1.Checked = False
                rdbapr4.Enabled = True
                rdbapr2.Checked = False
                rdbapr3.Checked = False
                rdbapr4.Checked = True
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If rdbapr1.Checked = True Then
                        dt = ELTBSTIEMBL.SelectAllHEJ(cmbaño.SelectedItem, sMes)
                        sOp = "1"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                    ElseIf rdbapr4.Checked = True Then
                        dt = PRODUCCIONBL.ListadoBonoProduccion(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                    ElseIf rdbapr2.Checked = True Then
                        dt = ELTBSTIEMBL.SelectAllHEJP(cmbaño.SelectedItem, sMes)
                        sOp = "2"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                    ElseIf rdbapr3.Checked = True Then
                        dt = ELTBSTIEMBL.SelectAllHERH(cmbaño.SelectedItem, sMes)
                        sOp = "3"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        '    If dgvMain.Rows(i).Cells("X").Value = "DESAPROBADO" Then
                        '        dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        '    End If
                        'Next
                    End If

                    'gHeader(dgvMain)
                End If

            Case "0401050000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBSTURNBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                End If
            Case "0205020000"
                dt = REQUERIMIENTOBL.SelectAllReqA
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("REQ_APROB").Value = "RECHAZADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "0205010000"
                'dt = ORDENCOMPRABL.SelectAll("82", cmbaño.SelectedText, mes)
                'dgvMain.DataSource = dt
                'dgvMain.Refresh()
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = GUIAALMACENBL.SelectAñoMes("SALM", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If
                End If
            Case "1001010000"
                est1(True)
                dt = REQUERIMIENTOBL.SelectAllPendiente
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                'poner botones
                Dim btn As New DataGridViewButtonColumn
                If dgvMain.Columns(0).Name = "btnAprobar" Then
                Else
                    btn.HeaderText = "Aprobar"
                    btn.Text = "Aprobar"
                    btn.Name = "btnAprobar"
                    btn.Frozen = True
                    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                    btn.FlatStyle = FlatStyle.Flat
                    btn.UseColumnTextForButtonValue = True
                    btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                    dgvMain.Columns.Insert(0, btn)
                    btn = New DataGridViewButtonColumn
                    btn.HeaderText = "Desaprobar"
                    btn.Text = "Desaprobar"
                    btn.Name = "btnDesaprobar"
                    btn.Frozen = True
                    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                    btn.FlatStyle = FlatStyle.Flat
                    btn.UseColumnTextForButtonValue = True
                    btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                    dgvMain.Columns.Insert(1, btn)
                End If

                ''alinear numericos
                If dgvMain.Rows.Count > 0 Then
                    dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N2"
                End If
            Case "1001020000"
                dt = REQUERIMIENTOBL.SelectAllPendiente1(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                'poner botones
                Dim btn As New DataGridViewButtonColumn
                If dgvMain.Columns(0).Name = "btnAprobar" Then
                Else
                    btn.HeaderText = "Aprobar"
                    btn.Text = "Aprobar"
                    btn.Name = "btnAprobar"
                    btn.Frozen = True
                    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                    btn.FlatStyle = FlatStyle.Flat
                    btn.UseColumnTextForButtonValue = True
                    btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                    dgvMain.Columns.Insert(0, btn)

                    btn = New DataGridViewButtonColumn
                    btn.HeaderText = "Desaprobar"
                    btn.Text = "Desaprobar"
                    btn.Name = "btnDesaprobar"
                    btn.Frozen = True
                    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                    btn.FlatStyle = FlatStyle.Flat
                    btn.UseColumnTextForButtonValue = True
                    btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                    dgvMain.Columns.Insert(1, btn)
                End If

                'Try
                '    'alinear numericos
                '    If dgvMain.Rows.Count > 0 Then
                '        'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N2"

                '        dgvMain.Columns("PRECIO_UNITARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '        dgvMain.Columns("PRECIO_UNITARIO").DefaultCellStyle.Format = "N2"

                '        dgvMain.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '        dgvMain.Columns("TOTAL").DefaultCellStyle.Format = "N2"
                '    End If
                'Catch ex As Exception

                'End Try
            Case "0401070000"
                dt = REQUERIMIENTOBL.SelectAllOP(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                'poner botones
                Dim btn As New DataGridViewButtonColumn
                If dgvMain.Columns(0).Name = "btnAprobar" Then
                Else
                    btn.HeaderText = "VERIFICAR OP"
                    btn.Text = "VERIFICAR OP"
                    btn.Name = "btnAprobar"
                    btn.Frozen = True
                    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                    btn.FlatStyle = FlatStyle.Flat
                    btn.UseColumnTextForButtonValue = True
                    btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                    dgvMain.Columns.Insert(0, btn)

                    btn = New DataGridViewButtonColumn
                    btn.HeaderText = "NO VERIFICAR"
                    btn.Text = "NO VERIFICAR"
                    btn.Name = "btnDesaprobar"
                    btn.Frozen = True
                    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                    btn.FlatStyle = FlatStyle.Flat
                    btn.UseColumnTextForButtonValue = True
                    btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                    dgvMain.Columns.Insert(1, btn)
                End If



            Case "0204020000"

                dt = ARTICULOBL.getArtstk(gsCodAlm, cmbsublinea.SelectedValue.ToString)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    'alinear numericos
                    dgvMain.Columns("CentralPack").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvMain.Columns("CentralPack").DefaultCellStyle.Format = "N0"
                    ''dgvMain.Columns("ELOY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    ''dgvMain.Columns("ELOY").DefaultCellStyle.Format = "N0"
                    ''dgvMain.Columns("LURIN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    ''dgvMain.Columns("LURIN").DefaultCellStyle.Format = "N0"
                    'TSButtonRefresh_Click(Nothing, Nothing)
                End If
                gdtMainData = dt
            'Case "0203010000"
            '    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
            '        dt = GUIAALMACENBL.SelectAll("OREQ", cmbaño.SelectedItem, sMes)
            '        dgvMain.DataSource = dt
            '        dgvMain.Refresh()
            '        'Renombrar y mostrar Columnas
            '        dgvMain.CurrentCell = Nothing
            '        gHeader(dgvMain)
            '    End If
            Case "0203020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = GUIAALMACENBL.SelectAll("SALM", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        For i = 0 To dgvMain.Rows.Count - 1
                            If dgvMain.Rows(i).Cells("EST").Value = "A" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                    End If
                    'Renombrar y mostrar Columnas
                    dgvMain.CurrentCell = Nothing
                    gHeader(dgvMain)
                End If
            Case "0302010000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ORDENCOMPRABL.SelectAll("82", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'Renombrar y mostrar Columnas
                    'dgvMain.CurrentCell = Nothing
                    ''dgvMain.Columns.Item("T_DOC_REF").HeaderText = "TIPO"
                    'gHeader(dgvMain)
                    'dgvMain.Columns("T_DOC_REF").Visible = False
                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("importe").DefaultCellStyle.Format = "N3"
                    End If
                End If
            Case "0302020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = GUIADESPACHOBL.SelectAll("09", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'Renombrar y mostrar Columnas
                    'dgvMain.CurrentCell = Nothing
                    ''dgvMain.Columns.Item("T_DOC_REF").HeaderText = "TIPO"
                    'gHeader(dgvMain)
                    'dgvMain.Columns("T_DOC_REF").Visible = False
                End If
            Case "0302030000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = FACTURACIONBL.SelectAll("01", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'Renombrar y mostrar Columnas
                    'dgvMain.CurrentCell = Nothing
                    ''dgvMain.Columns.Item("T_DOC_REF").HeaderText = "TIPO"
                    'gHeader(dgvMain)
                    'dgvMain.Columns("T_DOC_REF").Visible = False
                End If
            Case "0302040000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = BOLETABL.SelectAll("03", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'Renombrar y mostrar Columnas
                    'dgvMain.CurrentCell = Nothing
                    ''dgvMain.Columns.Item("T_DOC_REF").HeaderText = "TIPO"
                    'gHeader(dgvMain)
                    'dgvMain.Columns("T_DOC_REF").Visible = False
                End If
            Case "0302050000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = NOTACREDITOBL.SelectAll("07", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'Renombrar y mostrar Columnas
                    'dgvMain.CurrentCell = Nothing
                    ''dgvMain.Columns.Item("T_DOC_REF").HeaderText = "TIPO"
                    'gHeader(dgvMain)
                    'dgvMain.Columns("T_DOC_REF").Visible = False
                End If
            Case "0302050000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = NOTACREDITOBL.SelectAll("07", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'Renombrar y mostrar Columnas
                    'dgvMain.CurrentCell = Nothing
                    ''dgvMain.Columns.Item("T_DOC_REF").HeaderText = "TIPO"
                    'gHeader(dgvMain)
                    'dgvMain.Columns("T_DOC_REF").Visible = False
                End If
            Case "0302070000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = LETRASBL.SelectAll("80", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0305020000"
                'gsMes = sMes
                'If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                dt = ELTBCLIENTEBL.SelectBloq()
                dgvMain.DataSource = dt
                dgvMain.Refresh()

                If dgvMain.Rows.Count > 0 Then
                    'alinear numericos
                    'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    'dgvMain.Columns("CANT_ATENDIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    'dgvMain.Columns("CANT_ATENDIDA").DefaultCellStyle.Format = "N3"
                    'dgvMain.Columns("CANT_PENDIENTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    'dgvMain.Columns("CANT_PENDIENTE").DefaultCellStyle.Format = "N3"
                    Dim btn As New DataGridViewButtonColumn
                    If dgvMain.Columns(0).Name = "btnCerrar" Then
                    Else
                        btn.HeaderText = "Habilitar"
                        btn.Text = "Habilitar"
                        btn.Name = "btnCerrar"
                        btn.Frozen = True
                        btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  ' RED
                        btn.FlatStyle = FlatStyle.Flat
                        btn.UseColumnTextForButtonValue = True
                        btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                        dgvMain.Columns.Insert(0, btn)
                    End If
                End If
                    'If dgvMain.Rows.Count > 0 Then
                    'End If
                    'dgvMain.Columns.Item(1).Visible = False
                    'dgvMain.Columns.Item(2).Visible = False
                    'dgvMain.Columns.Item(4).Visible = False
                    'dgvMain.Columns.Item(5).Visible = False
                    'dgvMain.Columns.Item(6).Visible = False
                'End If
            Case "1002010000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ORDEN_COMPRABL.SelectAllProd(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'Renombrar y mostrar Columnas
                    dgvMain.CurrentCell = Nothing
                    gHeader(dgvMain)
                End If
            Case "1002020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ORDEN_COMPRABL.SelectAllServ(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'Renombrar y mostrar Columnas
                    dgvMain.CurrentCell = Nothing
                    gHeader(dgvMain)
                End If
            Case "0401010100"
                'gsMes = sMes
                Dim i As Integer
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If chkestado.Checked Then
                        dt = REPORTE_PRODUCCIONBL.SelectActivos(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If

                    ElseIf chkestado.Checked = False Then
                        dt = REPORTE_PRODUCCIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'OBSERVACION
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            'alinear numericos
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    End If
                End If
            Case "0401010200"
                Dim i As Integer
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If chkestado.Checked Then
                        dt = ELREINGRESOBL.SelectActivos(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If

                    ElseIf chkestado.Checked = False Then
                        dt = ELREINGRESOBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'OBSERVACION
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            'alinear numericos
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    End If
                End If
            Case "0401010300"
                Dim i As Integer
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If chkestado.Checked Then
                        dt = ELFALLADOSBL.SelectActivos(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If

                    ElseIf chkestado.Checked = False Then
                        dt = ELFALLADOSBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'OBSERVACION
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            'alinear numericos
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    End If
                End If
            Case "0206010000"
                'gsMes = sMes
                Dim i As Integer
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If gsUser = "JMONTES" Or gsUser = "JFLORES" Then
                        If chkestado.Checked Then
                            dt = SOLMATERIALESBL.SelectRecursos(cmbaño.SelectedItem, sMes)
                            dgvMain.DataSource = dt
                            dgvMain.Refresh()

                            If dgvMain.Rows.Count > 0 Then
                                'alinear numericos
                                For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                    If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                        dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                    End If
                                Next
                                'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                                'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                            End If

                        ElseIf chkestado.Checked = False Then
                            dt = SOLMATERIALESBL.SelectRecursos(cmbaño.SelectedItem, sMes)
                            dgvMain.DataSource = dt
                            dgvMain.Refresh()

                            If dgvMain.Rows.Count > 0 Then
                                For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                    If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                        dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                    End If
                                Next

                            End If
                        End If
                    ElseIf gsUser = "ACORDOVA" Or gsUser = "ACRUZ" Or gsUser = "MVELOZ" Then
                        dt = SOLMATERIALESBL.SelectASQ(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "JPINTADO" Then
                        dt = SOLMATERIALESBL.SelectVentas(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "LVERGARA" Then
                        dt = SOLMATERIALESBL.SelectALM(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "GGONZALES" Then
                        dt = SOLMATERIALESBL.SelectLOG(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "CHOYOS" Then
                        dt = SOLMATERIALESBL.SelectCONT(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "JTUCNO" Or gsUser = "BROJAS" Then
                        dt = SOLMATERIALESBL.SelectMant(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    Else
                        If chkestado.Checked Then
                            dt = SOLMATERIALESBL.SelectActivos1(cmbaño.SelectedItem, sMes)
                            dgvMain.DataSource = dt
                            dgvMain.Refresh()

                            If dgvMain.Rows.Count > 0 Then
                                'alinear numericos
                                For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                    If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                        dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                    End If
                                Next
                                'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                                'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                            End If

                        ElseIf chkestado.Checked = False Then
                            dt = SOLMATERIALESBL.SelectActivos1(cmbaño.SelectedItem, sMes)
                            dgvMain.DataSource = dt
                            dgvMain.Refresh()

                            If dgvMain.Rows.Count > 0 Then
                                For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                    If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                        dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                    End If
                                Next

                            End If
                        End If
                    End If

                End If
            Case "0205030000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = SOLMATERIALESBL.SelectAllAp(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        dgvMain.Columns("CANT_ATENDIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANT_ATENDIDA").DefaultCellStyle.Format = "N3"
                        dgvMain.Columns("CANT_PENDIENTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANT_PENDIENTE").DefaultCellStyle.Format = "N3"
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnCerrar" Then
                        Else
                            btn.HeaderText = "Cerrar"
                            btn.Text = "Cerrar"
                            btn.Name = "btnCerrar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(0, btn)
                        End If
                    End If
                    'If dgvMain.Rows.Count > 0 Then

                    'End If
                    dgvMain.Columns.Item(1).Visible = False
                    dgvMain.Columns.Item(2).Visible = False
                    dgvMain.Columns.Item(4).Visible = False
                    dgvMain.Columns.Item(5).Visible = False
                    dgvMain.Columns.Item(6).Visible = False
                End If
            Case "0206020000"
                Dim I As Integer
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBRECEPCOMPBL.SelectActivos2(cmbaño.Text & mes(cmbmes.SelectedIndex))
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Enviar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                        End If
                        dgvMain.Columns(1).Visible = False
                        dgvMain.Columns(2).Visible = False
                        dgvMain.Columns(4).Visible = False
                        For I = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(I).Cells("EST").Value = "OBSERVADO" Then
                                dgvMain.Rows(I).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                    End If

                End If
            Case "0403010000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectAllAp(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If
                End If
            Case "0403020000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectAllFal(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If
                    For I = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(I).Cells("est").Value = "DESAPROBADO" Then
                            dgvMain.Rows(I).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "0403030000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectAllRein(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If
                    For I = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(I).Cells("est").Value = "DESAPROBADO" Then
                            dgvMain.Rows(I).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "0402010000"
                Dim I As Integer
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectActivos1(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                    End If

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        For I = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(I).Cells("est").Value = "DESAPROBADO" Then
                                dgvMain.Rows(I).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                        dgvMain.Columns.Item(2).Visible = False
                        dgvMain.Columns.Item(3).Visible = False
                        dgvMain.Columns.Item(5).Visible = False
                        dgvMain.Columns.Item(6).Visible = False
                        dgvMain.Columns.Item(7).Visible = False
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If

                End If
            Case "0402020000"
                Dim I As Integer
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectActivos1F(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                    End If

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        For I = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(I).Cells("est").Value = "DESAPROBADO" Then
                                dgvMain.Rows(I).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                        dgvMain.Columns.Item(2).Visible = False
                        dgvMain.Columns.Item(3).Visible = False
                        dgvMain.Columns.Item(5).Visible = False
                        dgvMain.Columns.Item(6).Visible = False
                        dgvMain.Columns.Item(7).Visible = False
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If

                End If
            Case "0402030000"
                Dim I As Integer
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectActivos1R(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                    End If

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        For I = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(I).Cells("EST").Value = "DESAPROBADO" Then
                                dgvMain.Rows(I).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                        dgvMain.Columns.Item(2).Visible = False
                        dgvMain.Columns.Item(3).Visible = False
                        dgvMain.Columns.Item(5).Visible = False
                        dgvMain.Columns.Item(6).Visible = False
                        dgvMain.Columns.Item(7).Visible = False
                        'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If

                End If

            Case "0501100000"
                dt = ELDECLARACIONDUABL.SelectAll()
                dgvMain.DataSource = dt
            Case "0503010000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    'mesaño = cmbaño.SelectedItem & sMes
                    Cerrar = ""
                    dt = FACTURACIONBL.SelectRegVen(cmbaño.Text, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'dt = FACTURACIONBL.SelectRegVenAll(mesaño)
                    'dgvsegundo.DataSource = dt
                    'dgvsegundo.Refresh()
                End If
            Case "0503020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    'mesaño = cmbaño.SelectedItem & sMes
                    Cerrar = ""
                    dt = PROVISIONESBL.Select_RegistroComp(cmbaño.Text, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'dt = FACTURACIONBL.SelectRegVenAll(mesaño)
                    'dgvsegundo.DataSource = dt
                    'dgvsegundo.Refresh()
                End If
            Case "0503040000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    'mesaño = cmbaño.SelectedItem & sMes
                    Cerrar = ""
                    dt = PROVISIONESBL.Select_RegistroNoDom(cmbaño.Text, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'dt = FACTURACIONBL.SelectRegVenAll(mesaño)
                    'dgvsegundo.DataSource = dt
                    'dgvsegundo.Refresh()
                End If
            Case "0503050000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    'mesaño = cmbaño.SelectedItem & sMes
                    Cerrar = ""
                    dt = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, "010", "")
                    dgvMain.DataSource = dt
                    gdtMainData = dt
                    dgvMain.Refresh()
                    'dt = FACTURACIONBL.SelectRegVenAll(mesaño)
                    'dgvsegundo.DataSource = dt
                    'dgvsegundo.Refresh()
                End If
            Case "0503060000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    'mesaño = cmbaño.SelectedItem & sMes
                    Cerrar = ""
                    dt = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, "013", "")
                    dgvMain.DataSource = dt
                    gdtMainData = dt
                    dgvMain.Refresh()
                    'dt = FACTURACIONBL.SelectRegVenAll(mesaño)
                    'dgvsegundo.DataSource = dt
                    'dgvsegundo.Refresh()
                End If
            Case "0503070000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = CONTABILIDADBL.selectall(cmbaño.SelectedItem, sMes, "007")
                    dgvMain.DataSource = dt
                    gdtMainData = dt
                    dgvMain.Refresh()
                    'dt = FACTURACIONBL.SelectRegVenAll(mesaño)
                    'dgvsegundo.DataSource = dt
                    'dgvsegundo.Refresh()
                End If
            Case "0503080000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = CONTABILIDADBL.selectall(cmbaño.SelectedItem, sMes, "009")
                    dgvMain.DataSource = dt
                    gdtMainData = dt
                    dgvMain.Refresh()
                    'dt = FACTURACIONBL.SelectRegVenAll(mesaño)
                    'dgvsegundo.DataSource = dt
                    'dgvsegundo.Refresh()
                End If
            Case "0502050000"
                dt = ELTBCUENTA_OPEBL.SelectAll(DateTime.Now.ToString("yyyy"))
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502030000"
                dt = ELTBCUENTABL.SelectAll(cmbaño.SelectedItem)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502020000"
                dt = ELTBCTA_FACTURACIONBL.SelectAll(cmbaño.SelectedItem)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502010000"
                dt = ELTBREGISTRO_NROBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502040000"
                dt = ELTBMOVIMIENTOBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502060000"
                dt = IMPUESTOBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502070000"
                dt = FORMA_ENTBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502080000"
                dt = CUENTABANCOBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502090000"
                dt = FORMA_PAGOBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502100000"
                dt = ELUTILIDADESBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502110000"
                dt = ELLIQUIDACIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "0502120000"
                dt = ELLIB_CONTBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502130000"
                dt = ELT_OPEBL.SelectAll(cmbaño.SelectedItem)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502140000"
                dt = ELDOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502150000"
                If chkdocexp.Checked Then
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = PROVISIONESBL.SelectExpAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        If dgvMain.Rows.Count > 0 Then
                            dgvMain.Columns(5).Visible = False
                        End If
                        dgvMain.Refresh()
                    End If
                Else
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = PROVISIONESBL.SelectProvAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        If dgvMain.Rows.Count > 0 Then
                            dgvMain.Columns(5).Visible = False
                        End If

                        dgvMain.Refresh()
                    End If
                End If

            Case "0502160000"
                grpOpe.Visible = True
                grpMon.Visible = True
                btnFiltro.Visible = True
                'Dim ope = "010"
                'Dim mon = "00"
                'Dim ope
                'Dim mon
                'If radSol.Checked = True Then
                '    mon = "00"
                'Else
                '    mon = "01"
                'End If
                'If radCob.Checked = True Then
                '    ope = "013"
                'Else
                '    ope = "010"
                'End If
                estadoTC = 0
                dt = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, "", "")
                radPag.Checked = True
                radSol.Checked = True
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "PEND" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.MediumVioletRed
                        End If
                    Next
                End If
            Case "0502170000"
                dt = ELCUENTA_ARTBL.SelectAll(cmbaño.SelectedItem)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502200000"
                dt = ELTBINICIALCBBL.SelectAll(cmbaño.SelectedItem)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0502210000"
                FormAsientoPlanilla.ShowDialog()
            Case "0502220000"
                dt = ELTBPERCEPBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0504020000"
                dt = FACTURACIONBL.SelectEstRecogido(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0504030000"
                dt = LETRASBL.SelectEstRecogido(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0504040000"
                dt = NOTACREDITOBL.SelectEstRecogido(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0504050000"
                dt = NOTADEBITOBL.SelectEstRecogido(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "0504070000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBPROGPAGOBL.SelectAll("PPAG", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'Renombrar y mostrar Columnas
                    'dgvMain.CurrentCell = Nothing
                    ''dgvMain.Columns.Item("T_DOC_REF").HeaderText = "TIPO"
                    'gHeader(dgvMain)
                    'dgvMain.Columns("T_DOC_REF").Visible = False
                End If
            Case "0504080000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBDETRACCIONBL.SelectAll("DET", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0504090000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBKARDEXIMPBL.SelectAll("DIMP", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0505010000"
                Dim I As Integer
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then

                    dt = ELTBRECEPCOMPBL.SelectActivos1(cmbaño.Text & sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                        dgvMain.Columns(2).Visible = False
                        dgvMain.Columns(3).Visible = False
                        dgvMain.Columns(4).Visible = False
                        dgvMain.Columns(5).Visible = False
                    End If
                End If
            Case "0702050000"
                dt = oTipoFalla.SelectAllDt("1")
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0703010000"
                If chkest.Checked = True Then
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBMANTENIMIENTOBL.SelectAllTo(cmbaño.SelectedItem & sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If
                Else
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBMANTENIMIENTOBL.SelectAll(cmbaño.SelectedItem & sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If
                End If
            Case "0703020000"
                ' Segunda pantalla
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELORDEN_MANTBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If

                ''If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                ''    dt = ELTBMANTENIMIENTOBL.SelectAll(cmbaño.SelectedItem & sMes)
                ''    dgvMain.DataSource = dt
                ''    dgvMain.Refresh()
                ''End If

            Case "0703030000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBMTIEMBL.SelectAll(cmbaño.SelectedItem & sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0703040000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If rdbapr1.Checked = True Then
                        dt = REPORTE_TRABAJOBL.SelectAllHEJ(cmbaño.SelectedItem, sMes, gsCodUsr)
                        sOp = "1"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        For i = 0 To dgvMain.Rows.Count - 1
                            If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                    ElseIf rdbapr4.Checked = True Then
                        dt = REPORTE_TRABAJOBL.SelectAll(cmbaño.SelectedItem, sMes, gsCodUsr)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        For i = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                    ElseIf rdbapr2.Checked = True Then
                        dt = REPORTE_TRABAJOBL.SelectAllHEJP(cmbaño.SelectedItem, sMes)
                        sOp = "2"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        For i = 0 To dgvMain.Rows.Count - 1
                            If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                    End If
                End If
            Case "0802020000"
                If cmb_tipo.SelectedIndex = 1 Then
                    If chkest.Checked Then
                        dt = PERBL.SelPerActivosTemp("21")
                        dgvMain.DataSource = dt
                    Else
                        dt = PERBL.SelPerAllActivosTemp("21")
                        dgvMain.DataSource = dt
                    End If
                ElseIf cmb_tipo.SelectedIndex = 2 Then
                    If chkest.Checked Then
                        dt = PERBL.SelPerActivosTemp("20")
                        dgvMain.DataSource = dt
                    Else
                        dt = PERBL.SelPerAllActivosTemp("20")
                        dgvMain.DataSource = dt

                    End If
                Else
                    If chkest.Checked Then
                        dt = PERBL.SelPerAllActivos
                        dgvMain.DataSource = dt
                    Else
                        dt = PERBL.SelPerAll
                        dgvMain.DataSource = dt
                    End If
                End If
                'dt = PERBL.SelPerAll()
                'dgvMain.DataSource = dt
            Case "0802010000"
                dt = ELTBTAREOBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0802030000"
                dt = ELTBCONCEPTOSBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0802040000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELCONTRATOBL.SelectAll(cmbaño.SelectedItem)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0802050000"
                dt = ELVACACIONESBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0802070000"
                dt = ELPROGRAMACIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0802090000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELPERMISOSBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0802060000"
                dt = ELPERIODOBL.SelectAll(cmbaño.SelectedItem)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0802100000"
                'dt = PERROTBL.SelPerAll("")
                'dgvMain.DataSource = dt
                'dgvMain.Refresh()
                If cmb_tipo.SelectedIndex = 1 Then
                    dt = PERROTBL.SelPerAll("D")
                    dgvMain.DataSource = dt

                ElseIf cmb_tipo.SelectedIndex = 2 Then

                    dt = PERROTBL.SelPerAll("N")
                    dgvMain.DataSource = dt
                Else

                    dt = PERROTBL.SelPerAll("0")
                    dgvMain.DataSource = dt
                End If
                dgvMain.Refresh()
            Case "0802110000"
                'dt = CTS_BL.SelectRowAll(cmbaño.SelectedItem, sMes)
                'dgvMain.DataSource = dt
                'dgvMain.Refresh()
                dt = ELPERMISOSBL.SelectAllS(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0802120000"
                dt = ELTBTURNOBL.SelectAllS(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0802130000"
                dt = ELTBSINTOMAS_COVIDBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0802140000"
                dt = ELTBCARGOBL.SelectAll()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0802160000"
                dt = CTS_BL.SelectRowAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0802170000"
                dt = VACUNABL.ListadoVacunados()
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                dgvMain.DataSource = dt
                'If gsUser <> "RCONISLLA" Then
                '    btnlimpiar.Visible = True
                '    btnVentas.Text = "Ingreso Días"
                '    btnVentas.Visible = True
                'End If
                chkest.Visible = True
                chkest.Text = "No Vacunados"

            Case "1202010000"
                dt = ELTBCAPACITACIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "1202020000"
                dt = ELTBEVALUACIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "1203010000"

            Case "1201010000"
                dt = ELTBCAPACITACIONBL.getCapacitacion1()
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "0304010300"
                dt = ELTBTRANSPTRACTORBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0304010200"
                dt = ELTBTRANSPCHOFERBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0304010100"
                dt = ELTBTRANSPBL.SelectAll
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "0801200000"
                dt = ELRRHH_FUNCIONESBL.SelTurnosOperario(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "0801210000"
                dt = ELRRHH_FUNCIONESBL.SelHorasExtras(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "0801220000"
                dt = ELRRHH_FUNCIONESBL.SelHorasExtrasGeneral(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0501300000"
                dt = BINDCARDBL.ListadoOPAtendido(cmbano.Text, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "1102020100"
                dt = BINDCARDBL.ListadoOPAtendido(cmbano.Text, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "1102020200"
                dt = BINDCARDBL.ListadoConsDifFecha(cmbano.Text, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "1102020400"
                dt = BINDCARDBL.ListadoReingresos(cmbano.Text, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "1102010100"
                dt = BINDCARDBL.ListadoFecMaxima(cmbano.Text, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0204120000"
                dt = BINDCARDBL.SelBindCard(cmbaño.SelectedItem, sMes, "")
                dgvMain.DataSource = dt
                dgvMain.Refresh()

                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "ATENDIDO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "GENERADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "PENDIENTE" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "ANULADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "0504110000"
                dt = CONTABILIDADBL.ListadoLibroDiario(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1
                        If dgvMain.Rows(i).Cells("EST. MC").Value = "PEND" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.MediumVioletRed
                        End If
                    Next
                End If
            Case "0504140000"
                Dim tipo As String = ""
                Select Case cmbTipoCred.SelectedIndex
                    Case 0
                        tipo = "LE"
                    Case 1
                        tipo = "RE"
                    Case 2
                        tipo = "FE"
                    Case 3
                        tipo = "CF"
                End Select
                dt = CONTABILIDADBL.ListadoCreditos(cmbaño.SelectedItem, tipo)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0803020000"   ' Cargar Grid con MEMO
                dt = MEMOBL.BuscarListadoMEmo(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0803030000"
                chkest.Visible = True
                chkest.Text = "Resumen"
                cmb_tipo.Visible = True
                cmb_tipo.Items.Clear()
                cmb_tipo.Items.Add("TODOS")
                cmb_tipo.Items.Add("PENDIENTES")
                cmb_tipo.Items.Add("PAGADOS")
                est1(True)
                getCmbAño(cmbaño)
                cmbaño.SelectedItem = sAño
                primero = False
                Dim TIPO = ""
                If gsUser = "CHOYOS" Or gsUser = "SGARCIA" Then
                    TIPO = "21"
                End If
                If gsUser = "JFLORES" Then
                    TIPO = "20"
                End If
                dt = PRESTAMOBL.BuscarListadoPrestamos(cmbaño.SelectedItem, "", TIPO)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "PAGADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "PENDIENTE" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                        End If

                    Next
                End If

            Case "0803040000"
                sAño = cmbaño.SelectedItem
                sAñoLD = cmbmes.SelectedIndex
                FormProcesarQuincena.ShowDialog()

            Case "0801230000"
                dt = ELRRHH_FUNCIONESBL.SelTardanzas(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "0401060000"
                'BtnActProcesos.Visible = True
                dt = PRODUCCIONBL.ListadoBonoProduccion(cmbaño.SelectedItem, sMes)
                If dt.Rows.Count > 0 Then
                    PRODUCCIONBL.ActualizarBonosProduccion(dt)
                End If
                Dim dt1 = PRODUCCIONBL.ListadoBonoProduccion(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt1
                dgvMain.Refresh()

            Case "0901010000"
                dt = ELCERTIFICABL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    dgvMain.Columns.Item(1).Visible = False
                    dgvMain.Columns.Item(2).Visible = False
                    dgvMain.Columns.Item(3).Visible = False
                    dgvMain.Columns.Item(6).Visible = False
                End If
            Case "0901020000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = ELETIQUETABL.SelectAllPacking(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
                'dgvMain.Refresh()
            Case "0401050000"
                dt = ELTBSTURNBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
            Case "1401010000"
                dt = ELTBSISTINTCALIDADBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
        End Select

        'If dt.Rows.Count <> 0 Then
        If ab = "" Then
            gdtMainData = dt
        End If
        ' End If
        ''''  gdtMainData = dt


        'PAGINACION 
        'pageSize = tstcmbPageSize.ComboBox.SelectedItem
        'maxRec = dtSource.Rows.Count
        'PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        'If (maxRec Mod pageSize) > 0 Then
        '    PageCount = PageCount + 1
        'End If

        'Initial seeings
        'currentPage = 1
        recNo = 0
        tsbCamposSeek.Items.Clear()
        'MsgBox(tsbCamposSeek.Items.Count)
        'get columns of DGV
        If gsMenuNodeId = "0401020000" Then
            tsbCamposSeek.Items.Add("NRO")
            tsbCamposSeek.Items.Add("CODIGO")
            tsbCamposSeek.Items.Add("ARTICULO")
            tsbCamposSeek.Items.Add("RUC")
            tsbCamposSeek.Items.Add("RAZ_SOCIAL")
            tsbCamposSeek.Items.Add("ARTICULO")
            tsbCamposSeek.Items.Add("FEC_GENE")
            tsbCamposSeek.Items.Add("ESTADO")
        ElseIf gsMenuNodeId = "0701010000" Then
            tsbCamposSeek.Items.Add("ACTIVO")
            tsbCamposSeek.Items.Add("C_COSTO")
            tsbCamposSeek.Items.Add("ARTICULO")
            tsbCamposSeek.Items.Add("F_GENERACION")
            tsbCamposSeek.Items.Add("TIPO_REQ")
            tsbCamposSeek.Items.Add("USUARIO")
            lblRecNo.Text = dgvMain.Rows.Count


        Else
            For Each col As DataGridViewColumn In dgvMain.Columns
                ' MessageBox.Show(col.Name)
                tsbCamposSeek.Items.Add(col.Name)

            Next
        End If
        'limpiar busqueda

        Try
            dgvMain.CurrentCell = dgvMain.Rows(0).Cells(3)
        Catch ex As Exception
            'MsgBox("No hay datos en el detalle")
        End Try
        If tsbCamposSeek.SelectedIndex > -1 Then
            Me.ActiveControl = tsTextSearch.Control

        End If
        lblRecNo.Text = dgvMain.Rows.Count
        'tsbCamposSeek.SelectedIndex = 1

        '  LoadPage()
    End Sub


    Private Sub tsTextSearch_TextChanged(sender As Object, e As EventArgs) Handles tsTextSearch.TextChanged
        If gsMenuNodeId = "0401020000" Then
            If tsbCamposSeek.Text = "" Then
                MsgBox("Debe ingresar campo de busqueda")
                Exit Sub
            End If
            Dim sCode As String = tsTextSearch.Text

            If sCode.Trim = "" Then
                dgvt2.DataSource = gdtMainData
                lblRecNo.Text = dgvMain.Rows.Count
                Exit Sub
            End If

            Dim dtNew As DataTable

            ' copy table structure
            dtNew = gdtMainData.Clone()

            'obtener nombre de campo
            Dim sCampo As String = tsbCamposSeek.Text

            'buscar valor del txt en dt
            Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " Like '%" & sCode & "%'")

            For Each ldrRow As DataRow In dataRows
                dtNew.ImportRow(ldrRow)
            Next
            dgvt2.DataSource = dtNew
            lblRecNo.Text = dgvt2.Rows.Count

        Else
            If tsbCamposSeek.Text = "" Then
                MsgBox("Debe ingresar campo de busqueda")
                Exit Sub
            End If

            Dim sCode As String = tsTextSearch.Text

            If sCode.Trim = "" Then
                dgvMain.DataSource = gdtMainData
                lblRecNo.Text = dgvMain.Rows.Count
                Exit Sub
            End If

            Dim dtNew As DataTable

            ' copy table structure
            dtNew = gdtMainData.Clone()



            'obtener nombre de campo
            Dim sCampo As String = tsbCamposSeek.Text

            'buscar valor del txt en dt
            Dim dataRows() As DataRow = gdtMainData.Select(sCampo & " LIKE '%" & sCode & "%'")

            For Each ldrRow As DataRow In dataRows
                dtNew.ImportRow(ldrRow)
            Next
            dgvMain.DataSource = dtNew

            lblRecNo.Text = dgvMain.Rows.Count
        End If
    End Sub


    Private Sub dgvMain_DoubleClick(sender As Object, e As EventArgs) Handles dgvMain.DoubleClick
        gnOpcion = 1
        showForm(gsMenuNodeId)
    End Sub

    Private Sub cmblinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblinea.SelectedIndexChanged
        bChange = False
        cmbsublinea.SelectedIndex = -1
        bChange = True
        dgvMain.DataSource = Nothing
        dgvMain.Refresh()
        If Not bFirst Then
            On Error Resume Next
            If cmblinea.SelectedIndex <> -1 Then
                Dim dt2 As DataTable
                dt2 = ARTICULOBL.SelectDescripcion1(cmblinea.SelectedValue.ToString)
                bChange = False
                GetCmb("LIN_CODIGO", "LIN_DESCRI", dt2, cmbsublinea)
                bChange = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmbsublinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsublinea.SelectedIndexChanged
        If Not bChange Then Exit Sub

        Dim dt As New DataTable
        dt = Nothing
        Select Case gsMenuNodeId

            Case "0204020000"
                dt = ARTICULOBL.getArtstk(gsCodAlm, cmbsublinea.SelectedValue)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

                TSButtonRefresh_Click(Nothing, Nothing)

                gdtMainData = dt
            Case "02000000"
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    If chkest.Checked = True Then
                        dt = ARTICULOBL.SelectAll1(cmbsublinea.SelectedValue.ToString)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        TSButtonRefresh_Click(Nothing, Nothing)
                        gdtMainData = dt
                    Else
                        dt = ARTICULOBL.SelectAll(cmbsublinea.SelectedValue.ToString)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        TSButtonRefresh_Click(Nothing, Nothing)
                        gdtMainData = dt
                    End If

                End If
            Case "0604020000"
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    recNo = 0
                    tsbCamposSeek.Items.Clear()
                    dt = ARTICULOBL.SelectAllprecio(cmbsublinea.SelectedValue.ToString)
                    dgvMain.DataSource = dt
                    TSButtonRefresh_Click(Nothing, Nothing)
                    If dgvMain.Rows.Count > 0 Then
                        dgvMain.Columns(0).Visible = False
                        dgvMain.Refresh()
                        gdtMainData = dt
                    End If

                End If
            Case "0203050000"
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    recNo = 0
                    tsbCamposSeek.Items.Clear()
                    dt = ARTICULOBL.SelectELTBARTSTOCKALL(cmbsublinea.SelectedValue.ToString, gsCodAlm)
                    dgvMain.DataSource = dt
                    TSButtonRefresh_Click(Nothing, Nothing)
                    dgvMain.Refresh()
                    gdtMainData = dt
                End If
        End Select

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        gsRptArgs = {}
        Dim sMes As String = mes(cmbmes.SelectedItem)
        Select Case gsMenuNodeId
            Case "0101020000"
                'USUARIOS
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBUSER.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0102010000"
                'ALMACENES
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBALMACEN.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0103010000"
                'MENSAJES
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBMESSAGE.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0201010000"
                'UNIDAD DE MEDIDA    'falta KIKE
                'gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT02_ELTBUNIDAD.rpt"
                'gsRptPath = gsPathRpt
                'FormReportes.ShowDialog()
            Case "0201020000"
                'LINEAS
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBLINES_SUBLINEA.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0201040100"
                'CATALOGO
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBCATA.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0201040200"
                'CARACTERISTICAS
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBCARA.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0201050000"
                'FORMATOS       
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_FORMATO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0201060000"
                'TRANSACCION      
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_TRANSAC.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0203010000"
                'ORDEN DE COMPRA
                If dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("APROBACION").Value = "PENDIENTE" Or
                    dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("APROBACION").Value = "DESAPROBADA" Then
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = "OREQ"
                    gsRptArgs(1) = "001"
                    gsRptArgs(2) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CENTRALPACK_OREQ_VERTICAL.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Else
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = "OREQ"
                    gsRptArgs(1) = "001"
                    gsRptArgs(2) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(1).Value
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_CENTRALPACK_OREQ_VERTICAL.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If
            Case "0203020000"
                'VALE DE ALMACEN
                ReDim gsRptArgs(2)
                gsRptArgs(0) = "SALM"
                gsRptArgs(1) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                gsRptArgs(2) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_VALE.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0203030000"
                'REQUERIMIENTO
                ReDim gsRptArgs(2)
                gsRptArgs(0) = "REQ"
                gsRptArgs(1) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                gsRptArgs(2) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REQ.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0203040000"
                'SOLICITUD DE MATERIALES
                ReDim gsRptArgs(2)
                gsRptArgs(0) = "SOLM"
                gsRptArgs(1) = cmbaño.SelectedItem
                gsRptArgs(2) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_SOLMSELECTALL.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0204020000"
                'ARTICULO_
                ReDim gsRptArgs(3)
                gsRptArgs(0) = cmblinea.SelectedValue.ToString.Substring(0, 2)
                gsRptArgs(1) = cmbsublinea.SelectedValue.ToString.Substring(0, 4)
                gsRptArgs(2) = tsbCamposSeek.SelectedIndex
                gsRptArgs(3) = "%" + tsTextSearch.Text + "%"
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_STOCK_ALMACEN.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0205030000"
                'SOLICITUD MATERIALES POR CERRAR
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SOLM_PENDIENTES.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0206020000"
                'REPORTE DOCUMENTOS ENVIADOS
                ReDim gsRptArgs(0)
                gsRptArgs(0) = cmbaño.SelectedItem & sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBDETRECEPCOMP_IMP.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0302010000"
                'ORDENES DE COMPRA CLIENTE
                ReDim gsRptArgs(1)
                gsRptArgs(0) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("X").Value
                gsRptArgs(1) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ORDEN82.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0302030000"
                'FACTURAS
                ReDim gsRptArgs(2)
                gsRptArgs(0) = "01"
                gsRptArgs(1) = cmbaño.SelectedItem
                gsRptArgs(2) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBFACTURACION.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0302040000"
                'NOTA DEBITO
                ReDim gsRptArgs(2)
                gsRptArgs(0) = "03"
                gsRptArgs(1) = cmbaño.SelectedItem
                gsRptArgs(2) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBBOLETA.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0302050000"
                'NOTA CREDITO
                ReDim gsRptArgs(2)
                gsRptArgs(0) = "07"
                gsRptArgs(1) = cmbaño.SelectedItem
                gsRptArgs(2) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBNOTACREDITO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0302060000"
                'NOTA DEBITO
                ReDim gsRptArgs(2)
                gsRptArgs(0) = "08"
                gsRptArgs(1) = cmbaño.SelectedItem
                gsRptArgs(2) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBNOTADEBITO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0302070000"
                'LETRAS
                ReDim gsRptArgs(0)
                gsRptArgs(0) = cmbaño.SelectedItem & sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_DOCUMENTO_LETRAS.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0304020000"
                'TIPO CAMBIO
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBTIPOCAMBIO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0304030000"
                'CLIENTE
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBCLIENTE.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0401040000"
                FormRptHorasExtras.ShowDialog()
            Case "0401030000"
                'ORDEN DE PRODUCCION
                'ReDim gsRptArgs(1)
                'gsRptArgs(0) = cmbaño.SelectedItem
                'gsRptArgs(1) = sMes
                'gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTORDEN_PROGRAM_SELROW.rpt"
                'gsRptPath = gsPathRpt
                'FormReportes.ShowDialog()
                FormRptOrdenProgam.ShowDialog()
            Case "0503050000"
                'PAGOS
                ReDim gsRptArgs(3)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsRptArgs(2) = "010"
                gsRptArgs(3) = ""
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_PAGO_COB_SELALL.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0503060000"
                'PAGOS
                ReDim gsRptArgs(3)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsRptArgs(2) = "013"
                gsRptArgs(3) = ""
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_PAGO_COB_SELALL.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0402010000"
                'REPORTE DE PRODUCCION
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PRODUCCION_RP.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0803030000"
                ReDim gsRptArgs(7)
                gsRptArgs(0) = ""
                gsRptArgs(1) = ""
                gsRptArgs(2) = ""
                gsRptArgs(3) = ""
                gsRptArgs(5) = ""
                Select Case cmb_tipo.SelectedIndex
                    Case -1
                        gsRptArgs(4) = ""
                    Case 0
                        gsRptArgs(4) = ""
                        gsRptArgs(6) = cmbaño.SelectedItem
                    Case 1
                        gsRptArgs(4) = "P"
                        gsRptArgs(6) = cmbaño.SelectedItem

                    Case 2
                        gsRptArgs(4) = "C"
                        gsRptArgs(6) = cmbaño.SelectedItem
                End Select
                If gsUser = "CHOYOS" Or gsUser = "SGARCIA" Then
                    gsRptArgs(7) = "21"
                End If

                If gsUser = "JFLORES" Then
                    gsRptArgs(7) = "20"
                End If
                If gsUser = "JTRIGOS" Then
                    gsRptArgs(7) = ""
                End If

                If chkest.Checked = True Then
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REPORTE_PRESTAMOS_RESU.rpt"
                Else
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REPORTE_PRESTAMOS.rpt"
                End If
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0501300000"
                ReDim gsRptArgs(1)
                gsRptArgs(0) = sMes
                gsRptArgs(1) = cmbano.SelectedItem

                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPT_FACT_GUIADES.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "1102020100"
                ReDim gsRptArgs(7)
                gsRptArgs(0) = ""
                gsRptArgs(1) = sMes
                gsRptArgs(2) = cmbano.Text
                gsRptArgs(3) = ""
                gsRptArgs(4) = ""
                gsRptArgs(5) = ""
                gsRptArgs(6) = "S"
                gsRptArgs(7) = ""
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTSEGPROD_NUEVO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "1102020200"
                Dim mes = sMes
                Dim anho = cmbano.Text
                ReDim gsRptArgs(1)
                gsRptArgs(0) = mes
                gsRptArgs(1) = anho
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_PRODUCCION_ES.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()

            Case "1102020400"
                Dim mes = sMes
                Dim anho = cmbano.Text
                ReDim gsRptArgs(1)
                gsRptArgs(0) = mes
                gsRptArgs(1) = anho
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REINGRESOS_SALIDA.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()

            Case "1102010100"
                ReDim gsRptArgs(6)
                gsRptArgs(0) = ""
                gsRptArgs(1) = sMes
                gsRptArgs(2) = cmbano.Text
                gsRptArgs(3) = ""
                gsRptArgs(4) = ""
                gsRptArgs(5) = ""
                gsRptArgs(6) = ""
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTSEGPROD_FECMAX.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0204120000"
                ReDim gsRptArgs(2)
                gsRptArgs(0) = sMes
                gsRptArgs(1) = cmbaño.SelectedItem
                Select Case cmb_tipo.SelectedIndex
                    Case 0
                        gsRptArgs(2) = ""
                    Case 1
                        gsRptArgs(2) = "A"
                    Case 2
                        gsRptArgs(2) = "P"
                    Case 3
                        gsRptArgs(2) = "G"
                    Case 4
                        gsRptArgs(2) = "X"
                End Select

                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ESTADOS_BINDCARD.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()

            Case "0803020000"
                'MEMOS 
                ReDim gsRptArgs(2)
                gsRptArgs(0) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO MEMO").Value
                gsRptArgs(1) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("MES").Value
                gsRptArgs(2) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ANHO").Value
                Dim cod_Sancion = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SANCION").Value

                Select Case cod_Sancion
                    Case "8807"
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_REPORTE_MEMO_SUSPENSION.rpt"
                    Case "8803"
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_REPORTE_MEMO_SUSPENSION_8803.rpt"
                    Case "8602", "6602"
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_REPORTE_MEMO_LLAMADAATENCION.rpt"
                End Select
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0803030000"
                'REPORTE PRESTAMOS

            Case "0401060000"
                'BONO DE PRODUCCION 
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_BONO_PRODUCCION.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "02000000"
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    cmbsublinea.SelectedValue.ToString()
                    ReDim gsRptArgs(0)
                    gsRptArgs(0) = cmbsublinea.SelectedValue.ToString()
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT_LISTADO_ART_KARDEX.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If
            Case "0405040000"
                'REPORTE DE GRUPOS
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBGRUPO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            'Case "0405050000"
            '    'REPORTE DE GRUPOS
            '    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBGRUPO.rpt"
            '    gsRptPath = gsPathRpt
            '    FormReportes.ShowDialog()
            Case "0405060000"
                'CONTROL DOCUMENTO EXTRACTO BANCARIO
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ESPECIFI_T.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502050000"
                'REPORTE DE CUENTA OPERACIONES PREFIJADAS
                ReDim gsRptArgs(0)
                gsRptArgs(0) = DateTime.Now.ToString("yyyy")
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_CUENTA_OPERACION.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0503010000"
                'REGISTRO DE VENTAS
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REGISTRO_VENTAS.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0503020000"
                'REGISTRO DE COMPRAS
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REG_COMPRAS_ANALISIS.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0503040000"
                'REGISTRO DE COMPRAS
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_COMPRA_NODOMICILADO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502030000"
                'CUENTA
                ReDim gsRptArgs(0)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBCUENTA.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502020000"
                'CTA_FACTURACION
                ReDim gsRptArgs(0)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELCTA_FACTURACION.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502080000"
                'CUENTA DE BANCO                
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBCTABANCO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502070000"
                'FORMA DE ENTREGA                
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBFORMA_ENT.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502060000"
                'IMPUESTO                
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBIMPUESTO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502090000"
                'FORMA PAGO                
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBFORMAPAGO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502010000"
                'UTILIDADES
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_UTILIDADES.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502110000"
                'LIQUIDACION
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_LIQUIDACION.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502120000"
                'LIBROS_CONTABLE                
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_LIBRO_CONTABLE.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502140000"
                'CONTROL DOCUMENTO EXTRACTO BANCARIO
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_CONTROL_DOCUMENTO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0502220000"
                'CONTROL DOCUMENTO EXTRACTO BANCARIO
                txttexto.Text = Replace(ELTBPERCEPBL.getTxtFc(cmbaño.Text, (cmbmes.SelectedIndex + 1).ToString.PadLeft(2, "0")), ",", ".")
                Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                Dim RutaTxt As String = "\\192.168.1.7\sistema\Percepcion\062120100279348" & cmbaño.Text & (cmbmes.SelectedIndex + 1).ToString.PadLeft(2, "0") & "P.txt"
                IO.File.WriteAllText(RutaTxt, txttexto.Text, utf8WithoutBom)
                MsgBox("Se genero El texto")
            Case "0604010000"
                'PROVEEDORES
                'ReDim gsRptArgs(1)
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBPROVEEDORES.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0604020000"
                'PRECIO
                If cmbsublinea.SelectedIndex <> -1 Then
                    ReDim gsRptArgs(0)
                    gsRptArgs(0) = cmbsublinea.SelectedValue
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ART_SEL_PRECIO.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If

            Case "0701010000"
                'rpt mantenimiento
                FormReporteOrdenC.ShowDialog()
                'ReDim gsRptArgs(4)
                'gsRptArgs(0) = cmbaño.SelectedItem
                'gsRptArgs(1) = sMes
                'gsRptArgs(2) = tsbCamposSeek.SelectedIndex
                'gsRptArgs(3) = "%" + tsTextSearch.Text + "%"
                'gsRptArgs(4) = cmb_tipo.SelectedIndex
                'gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ORDEN_COMPRA.rpt"
                'gsRptPath = gsPathRpt
                'FormReportes.ShowDialog()
            Case "0102040000"
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_LISTADO_CC.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0802010000"
                'ASISTENCIA   
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELTBTAREO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0802020000"
                'ASISTENCIA   
                FormRptPerEstado.ShowDialog()
            Case "0802040000"
                'CONTRATOS
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELCONTRATOS.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0802030000"
                'RELACION CONCEPTOS                
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELRELCONCEPTO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0802050000"
                'VACACIONES
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELVACACIONES.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0802070000"
                'PROGRAMACION 
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELPROGRAMACION.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0802060000"
                'PERIODO 
                ReDim gsRptArgs(0)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_ELPERIODO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0802090000"
                'PERMISOS
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\01\RPT01_PERMISOS.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0802110000"
                ReDim gsRptArgs(0)
                gsRptArgs(0) = cmbaño.SelectedItem & sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_RPTPER_SUBSIDIO.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "0802130000"
                'Sintmas Covid
                FormRptSintomaCovidRH.ShowDialog()
            Case "0802170000"
                If chkest.Checked = False Then
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_LISTADO_VACUNADOS.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Else
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_LISTADO_NO_VACUNADOS.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If
            Case "0901010000"
                'Certificado Calidad.
                ReDim gsRptArgs(4)
                gsRptArgs(0) = "ASQ"
                gsRptArgs(1) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                gsRptArgs(2) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("CERTIFICADO").Value
                gsRptArgs(3) = ""
                gsRptArgs(4) = ""
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_DOCUMENTO_CALIDAD.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "1001020000"
                If dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("EST_APROBACION").Value = "PENDIENTE" Or
                    dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("EST_APROBACION").Value = "DESAPROBADA" Then
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = "OREQ"
                    gsRptArgs(1) = "001"
                    gsRptArgs(2) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_OREQ.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Else
                    ReDim gsRptArgs(2)
                    gsRptArgs(0) = "OREQ"
                    gsRptArgs(1) = "001"
                    gsRptArgs(2) = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_OREQ_APROBADO.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If


            Case "1202010000"
                'Capacitacion
                '----------
            Case "1202020000"
                'Evaluacion
                '----------
            Case "1203010000"
                'Aprob.Capacitacion
                '----------
            Case "1201010000"
                'Temas
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ELTBTEMAS.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "1002010000"
                'REGISTRO DE COMPRAS
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REG_COMPRAS.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
            Case "1002020000"
                'REGISTRO DE SERVICIOS
                ReDim gsRptArgs(1)
                gsRptArgs(0) = cmbaño.SelectedItem
                gsRptArgs(1) = sMes
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_REG_SERVICIOS.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
        End Select
    End Sub

    Private Sub cmbmes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmes.SelectedIndexChanged
        If Not bChange Then Exit Sub

        Dim dt As New DataTable
        dt = Nothing
        Dim acumulado As Double = 0
        Dim sMes As String = mes(cmbmes.SelectedItem)
        sMes1 = mes(sMes)
        Dim mesaño As String
        Select Case gsMenuNodeId
            Case "0401070000"
                dt = REQUERIMIENTOBL.SelectAllOP(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                'poner botones
                Dim btn As New DataGridViewButtonColumn
                If dgvMain.Columns(0).Name = "btnAprobar" Then
                Else
                    btn.HeaderText = "VERIFICAR OP"
                    btn.Text = "VERIFICAR OP"
                    btn.Name = "btnAprobar"
                    btn.Frozen = True
                    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                    btn.FlatStyle = FlatStyle.Flat
                    btn.UseColumnTextForButtonValue = True
                    btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                    dgvMain.Columns.Insert(0, btn)

                    btn = New DataGridViewButtonColumn
                    btn.HeaderText = "NO VERIFICAR"
                    btn.Text = "NO VERIFICAR"
                    btn.Name = "btnDesaprobar"
                    btn.Frozen = True
                    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                    btn.FlatStyle = FlatStyle.Flat
                    btn.UseColumnTextForButtonValue = True
                    btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                    dgvMain.Columns.Insert(1, btn)
                End If

            Case "0203010000"
                'If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                '    dt = GUIAALMACENBL.SelectAll("OREQ", cmbaño.SelectedItem, sMes)
                '    dgvMain.DataSource = dt
                '    dgvMain.Refresh()
                '    'Renombrar y mostrar Columnas
                '    'dgvMain.CurrentCell = Nothing
                '    ''dgvMain.Columns.Item("T_DOC_REF").HeaderText = "TIPO"
                '    'gHeader(dgvMain)
                '    'dgvMain.Columns("T_DOC_REF").Visible = False
                'End If
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REQUERIMIENTOBL.SelectAll("OREQ", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0204120000"
                dt = BINDCARDBL.SelBindCard(cmbaño.SelectedItem, sMes, "")
                dgvMain.DataSource = dt
                dgvMain.Refresh()

                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "ATENDIDO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "GENERADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "PENDIENTE" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "ANULADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "0501300000"
                dt = ELPAGO_DOCUMENTOBL.ListadoGuiasFact(cmbaño.Text, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "1102020100"
                dt = BINDCARDBL.ListadoOPAtendido(cmbano.Text, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "1102020200"
                dt = BINDCARDBL.ListadoConsDifFecha(cmbano.Text, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "1102020400"
                dt = BINDCARDBL.ListadoReingresos(cmbano.Text, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "1102010100"
                dt = BINDCARDBL.ListadoFecMaxima(cmbano.Text, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "1001020000"
                dt = REQUERIMIENTOBL.SelectAllPendiente1(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0603010000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REQUERIMIENTOBL.SelectOreqReq("OREQ", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0603020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REQUERIMIENTOBL.SelectOreqReq1("OREQ", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0603030000"
                dt = ELCUENTA_ARTBL.SelectAllOREQ(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0203020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = GUIAALMACENBL.SelectAll("SALM", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        For i = 0 To dgvMain.Rows.Count - 1
                            If dgvMain.Rows(i).Cells("EST").Value = "A" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If

                        Next
                    End If
                    'Renombrar y mostrar Columnas
                    'dgvMain.CurrentCell = Nothing
                    'gHeader(dgvMain)
                End If
            Case "0203030000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = GUIAALMACENBL.SelectAllReq(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'Renombrar y mostrar Columnas
                    'dgvMain.CurrentCell = Nothing
                    'gHeader(dgvMain)
                End If
            Case "0302010000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ORDENCOMPRABL.SelectAll("82", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("importe").DefaultCellStyle.Format = "N3"
                    End If
                End If
            Case "0302020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = GUIADESPACHOBL.SelectAll("09", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                End If
            Case "0302030000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = FACTURACIONBL.SelectAll("01", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                End If
            Case "0302040000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = BOLETABL.SelectAll("03", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0302050000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = NOTACREDITOBL.SelectAll("07", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0302060000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = NOTADEBITOBL.SelectAll("08", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0302070000"
                Dim dt1 As DataTable
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    mesaño = cmbaño.SelectedItem & sMes
                    dt = LETRASBL.SelectAll("80", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    dt1 = LETRASBL.SelectRegVenAll(mesaño)
                    dgvsegundo.DataSource = dt1
                    dgvsegundo.Refresh()
                End If
            Case "0304020000"
                'If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                '    dt = ELTBTIPOCAMBIOBL.SelectAll(cmbaño.SelectedItem, sMes)
                '    dgvMain.DataSource = dt
                '    dgvMain.Refresh()
                'End If
                If cmbtipsunat.Text = "SUNAT" Then
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBTIPOCAMBIOBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If
                Else
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBTIPOCAMBIOBL.SelectAll1(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If
                End If
            Case "0203040000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If gsUser = "EESPINO" Then
                        dt = SOLMATERIALESBL.SelectAllUsuario("SOLM", cmbaño.SelectedItem, sMes)
                    Else
                        dt = SOLMATERIALESBL.SelectAll("SOLM", cmbaño.SelectedItem, sMes)
                    End If
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0203060000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBRECEPCOMPBL.SelectAll(cmbaño.SelectedItem & sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0205010000"
                'gsMes = sMesFormELTBMANTENIMIENTO
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = GUIAALMACENBL.SelectAñoMes("SALM", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If
                End If
            Case "0401030000"
                dt = ELORDEN_PROGRAMBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0401040000"
                ''gsMes = sMes
                'If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                '    dt = GUIAALMACENBL.SelectAñoMes("SALM", cmbaño.SelectedItem, sMes)
                '    dgvMain.DataSource = dt
                '    dgvMain.Refresh()

                '    If dgvMain.Rows.Count > 0 Then
                '        'alinear numericos
                '        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                '    End If
                'End If
                'If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                '    'dt = ELTBSTIEMBL.SelectAll(cmbaño.SelectedItem, sMes)
                '    'dgvMain.DataSource = dt
                '    'dgvMain.Refresh()
                '    'gHeader(dgvMain)
                '    If rdbapr1.Checked = True Then
                '        dt = ELTBSTIEMBL.SelectAllHEJ(cmbaño.SelectedItem, sMes)
                '        sOp = "1"
                '        dgvMain.DataSource = dt
                '        dgvMain.Refresh()
                '    ElseIf rdbapr2.Checked = True Then
                '        dt = ELTBSTIEMBL.SelectAllHEJP(cmbaño.SelectedItem, sMes)
                '        sOp = "2"
                '        dgvMain.DataSource = dt
                '        dgvMain.Refresh()
                '        For i = 0 To dgvMain.Rows.Count - 1  ' count++
                '            If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                '                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                '            End If
                '        Next
                '    ElseIf rdbapr3.Checked = True Then
                '        dt = ELTBSTIEMBL.SelectAllHERH(cmbaño.SelectedItem, sMes)
                '        sOp = "3"
                '        dgvMain.DataSource = dt
                '        dgvMain.Refresh()
                '    ElseIf rdbapr4.Checked = True Then
                '        dt = ELTBSTIEMBL.SelectAll(cmbaño.SelectedItem, sMes)
                '        sOp = "4"
                '        dgvMain.DataSource = dt
                '        dgvMain.Refresh()
                '    End If
                'End If
                If rdbapr1.Checked = True Then
                    dt = ELTBSTIEMBL.SelectAllHEJ(cmbaño.SelectedItem, sMes)
                    sOp = "1"
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                ElseIf rdbapr4.Checked = True Then
                    dt = ELTBSTIEMBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                ElseIf rdbapr2.Checked = True Then
                    dt = ELTBSTIEMBL.SelectAllHEJP(cmbaño.SelectedItem, sMes)
                    sOp = "2"
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                ElseIf rdbapr3.Checked = True Then
                    dt = ELTBSTIEMBL.SelectAllHERH(cmbaño.SelectedItem, sMes)
                    sOp = "3"
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    'For i = 0 To dgvMain.Rows.Count - 1  ' count++
                    '    If dgvMain.Rows(i).Cells("X").Value = "DESAPROBADO" Then
                    '        dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    '    End If
                    'Next
                End If
            Case "0401010100"
                'gsMes = sMes
                Dim i As Integer
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If chkestado.Checked Then
                        dt = REPORTE_PRODUCCIONBL.SelectActivos(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then

                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1 ' count++

                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next

                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If

                    ElseIf chkestado.Checked = False Then
                        dt = REPORTE_PRODUCCIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1 ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    End If
                End If
            Case "0401010200"
                Dim i As Integer
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If chkestado.Checked Then
                        dt = ELREINGRESOBL.SelectActivos(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then

                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1 ' count++

                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next

                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If

                    ElseIf chkestado.Checked = False Then
                        dt = ELREINGRESOBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1 ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    End If
                End If
            Case "0401010300"
                Dim i As Integer
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If chkestado.Checked Then
                        dt = ELFALLADOSBL.SelectActivos(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then

                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1 ' count++

                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next

                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If

                    ElseIf chkestado.Checked = False Then
                        dt = ELFALLADOSBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()

                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1 ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    End If
                End If
            Case "0401050000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBSTURNBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                End If
            Case "0402010000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectActivos1(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                    End If
                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        For i = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                        dgvMain.Columns.Item(2).Visible = False
                        dgvMain.Columns.Item(3).Visible = False
                        dgvMain.Columns.Item(5).Visible = False
                        dgvMain.Columns.Item(6).Visible = False
                        dgvMain.Columns.Item(7).Visible = False
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If

                End If
                'Carga Default
            Case "0402020000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectActivos1F(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    Dim btn As New DataGridViewButtonColumn
                    If dgvMain.Columns(0).Name = "btnAprobar" Then
                    Else
                        btn.HeaderText = "Aprobar"
                        btn.Text = "Aprobar"
                        btn.Name = "btnAprobar"
                        btn.Frozen = True
                        btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                        btn.FlatStyle = FlatStyle.Flat
                        btn.UseColumnTextForButtonValue = True
                        btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                        dgvMain.Columns.Insert(0, btn)
                        btn = New DataGridViewButtonColumn
                        btn.HeaderText = "Desaprobar"
                        btn.Text = "Desaprobar"
                        btn.Name = "btnDesaprobar"
                        btn.Frozen = True
                        btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                        btn.FlatStyle = FlatStyle.Flat
                        btn.UseColumnTextForButtonValue = True
                        btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                        dgvMain.Columns.Insert(1, btn)
                    End If
                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        For i = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                        dgvMain.Columns.Item(2).Visible = False
                        dgvMain.Columns.Item(3).Visible = False
                        dgvMain.Columns.Item(5).Visible = False
                        dgvMain.Columns.Item(6).Visible = False
                        dgvMain.Columns.Item(7).Visible = False
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If
                End If
            Case "0402030000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectActivos1R(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                    End If
                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        For i = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                                dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next
                        dgvMain.Columns.Item(2).Visible = False
                        dgvMain.Columns.Item(3).Visible = False
                        dgvMain.Columns.Item(5).Visible = False
                        dgvMain.Columns.Item(6).Visible = False
                        dgvMain.Columns.Item(7).Visible = False
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If

                End If
            Case "0401020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELPRODUCCIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvt2.DataSource = dt
                    dgvt2.Refresh()
                    'Dim btn As New DataGridViewButtonColumn
                    'If dgvt2.Columns(0).Name = "btnAprobar" Then
                    'Else
                    '    btn.HeaderText = "Opcion"
                    '    btn.Text = "Generar OP"
                    '    btn.Name = "btnAprobar"
                    '    btn.Frozen = True
                    '    btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(211, 211, 211) 'GREEN
                    '    btn.FlatStyle = FlatStyle.Flat
                    '    btn.UseColumnTextForButtonValue = True
                    '    btn.CellTemplate.Style.BackColor = Color.FromArgb(211, 211, 211)
                    '    dgvt2.Columns.Insert(0, btn)
                    '    'btn = New DataGridViewButtonColumn
                    '    'btn.HeaderText = "Desaprobar"
                    '    'btn.Text = "Desaprobar"
                    '    'btn.Name = "btnDesaprobar"
                    '    'btn.Frozen = True
                    '    'btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                    '    'btn.FlatStyle = FlatStyle.Flat
                    '    'btn.UseColumnTextForButtonValue = True
                    '    'btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                    '    'dgvMain.Columns.Insert(1, btn)
                    'End If
                End If

            Case "0206010000"
                'gsMes = sMes

                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    If gsUser = "JMONTES" Or gsUser = "JFLORES" Then
                        dt = SOLMATERIALESBL.SelectRecursos(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns.Item(2).Visible = False
                            dgvMain.Columns.Item(3).Visible = False
                            'dgvMain.Columns.Item(5).Visible = False
                            'dgvMain.Columns.Item(6).Visible = False
                            'dgvMain.Columns.Item(7).Visible = False
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "ACORDOVA" Or gsUser = "ACRUZ" Or gsUser = "MVELOZ" Then
                        dt = SOLMATERIALESBL.SelectASQ(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns.Item(2).Visible = False
                            dgvMain.Columns.Item(3).Visible = False
                            'dgvMain.Columns.Item(5).Visible = False
                            'dgvMain.Columns.Item(6).Visible = False
                            'dgvMain.Columns.Item(7).Visible = False
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "JPINTADO" Then
                        dt = SOLMATERIALESBL.SelectVentas(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns.Item(2).Visible = False
                            dgvMain.Columns.Item(3).Visible = False
                            'dgvMain.Columns.Item(5).Visible = False
                            'dgvMain.Columns.Item(6).Visible = False
                            'dgvMain.Columns.Item(7).Visible = False
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "LVERGARA" Then
                        dt = SOLMATERIALESBL.SelectALM(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns.Item(2).Visible = False
                            dgvMain.Columns.Item(3).Visible = False
                            'dgvMain.Columns.Item(5).Visible = False
                            'dgvMain.Columns.Item(6).Visible = False
                            'dgvMain.Columns.Item(7).Visible = False
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "GGONZALES" Then
                        dt = SOLMATERIALESBL.SelectLOG(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns.Item(2).Visible = False
                            dgvMain.Columns.Item(3).Visible = False
                            'dgvMain.Columns.Item(5).Visible = False
                            'dgvMain.Columns.Item(6).Visible = False
                            'dgvMain.Columns.Item(7).Visible = False
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "CHOYOS" Then
                        dt = SOLMATERIALESBL.SelectCONT(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns.Item(2).Visible = False
                            dgvMain.Columns.Item(3).Visible = False
                            'dgvMain.Columns.Item(5).Visible = False
                            'dgvMain.Columns.Item(6).Visible = False
                            'dgvMain.Columns.Item(7).Visible = False
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    ElseIf gsUser = "JTUCNO" Or gsUser = "BROJAS" Then
                        dt = SOLMATERIALESBL.SelectMant(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        If dgvMain.Rows.Count = 0 Then
                            Exit Sub
                        End If
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns.Item(2).Visible = False
                            dgvMain.Columns.Item(3).Visible = False
                            'dgvMain.Columns.Item(5).Visible = False
                            'dgvMain.Columns.Item(6).Visible = False
                            'dgvMain.Columns.Item(7).Visible = False
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    Else
                        dt = SOLMATERIALESBL.SelectActivos1(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If
                        If dgvMain.Rows.Count > 0 Then
                            'alinear numericos
                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("est").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            dgvMain.Columns.Item(2).Visible = False
                            dgvMain.Columns.Item(3).Visible = False
                            'dgvMain.Columns.Item(5).Visible = False
                            'dgvMain.Columns.Item(6).Visible = False
                            'dgvMain.Columns.Item(7).Visible = False
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            'dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        End If
                    End If
                End If
                Try
                    For iI = 0 To dt.Columns.Count - 1

                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "0205030000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = SOLMATERIALESBL.SelectAllAp(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                        dgvMain.Columns("CANT_ATENDIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANT_ATENDIDA").DefaultCellStyle.Format = "N3"
                        dgvMain.Columns("CANT_PENDIENTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANT_PENDIENTE").DefaultCellStyle.Format = "N3"
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnCerrar" Then
                        Else
                            btn.HeaderText = "Cerrar"
                            btn.Text = "Cerrar"
                            btn.Name = "btnCerrar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(0, btn)
                        End If
                    End If
                    'If dgvMain.Rows.Count > 0 Then

                    'End If
                End If
            Case "0206020000"
                ' Dim I As Integer
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then

                    dt = ELTBRECEPCOMPBL.SelectActivos2(cmbaño.Text & mes(cmbmes.SelectedIndex))
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                        End If
                    End If
                End If
            Case "0403010000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectAllAp(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If
                End If
            Case "0403030000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectAllRein(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If
                End If
            Case "0403020000"
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = REPORTE_PRODUCCIONBL.SelectAllFal(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()

                    If dgvMain.Rows.Count > 0 Then
                        'alinear numericos
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                    End If
                    For I = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(I).Cells("est").Value = "DESAPROBADO" Then
                            dgvMain.Rows(I).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "1002010000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ORDEN_COMPRABL.SelectAllProd(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        dgvMain.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("IGV_IMPOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("TPRECIOS_EXO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("TPRECIOUNIT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End If

                    For Each row As DataGridViewRow In dgvMain.Rows
                        acumulado = acumulado + IIf(IsDBNull(RTrim(row.Cells("TOTAL").Value)), "", RTrim(row.Cells("TOTAL").Value))
                    Next
                    Label8.Text = acumulado
                End If
                'gHeader(dgvMain)
            Case "1002020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ORDEN_COMPRABL.SelectAllServ(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        dgvMain.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("IGV_IMPOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("TPRECIOS_EXO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvMain.Columns("TPRECIOUNIT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End If

                    For Each row As DataGridViewRow In dgvMain.Rows
                        acumulado = acumulado + IIf(IsDBNull(RTrim(row.Cells("TOTAL").Value)), "", RTrim(row.Cells("TOTAL").Value))
                    Next
                    Label8.Text = acumulado
                    'gHeader(dgvMain)
                End If
            Case "0503010000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    mesaño = cmbaño.Text & sMes
                    Cerrar = ""
                    dt = FACTURACIONBL.SelectRegVen(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    dt = FACTURACIONBL.SelectRegVenAll(mesaño)
                    dgvsegundo.DataSource = dt
                    dgvsegundo.Refresh()
                    'Renombrar y mostrar Columnas
                    'dgvMain.CurrentCell = Nothing
                    ''dgvMain.Columns.Item("T_DOC_REF").HeaderText = "TIPO"
                    'gHeader(dgvMain)
                    'dgvMain.Columns("T_DOC_REF").Visible = False
                End If
            Case "0503050000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, "010", "")
                    dgvMain.DataSource = dt
                    gdtMainData = dt
                    dgvMain.Refresh()
                End If
            Case "0503060000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, "013", "")
                    dgvMain.DataSource = dt
                    gdtMainData = dt
                    dgvMain.Refresh()
                End If
            Case "0503070000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = CONTABILIDADBL.selectall(cmbaño.SelectedItem, sMes, "007")
                    dgvMain.DataSource = dt
                    gdtMainData = dt
                    dgvMain.Refresh()

                End If
            Case "0503080000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = CONTABILIDADBL.selectall(cmbaño.SelectedItem, sMes, "009")
                    dgvMain.DataSource = dt
                    gdtMainData = dt
                    dgvMain.Refresh()

                End If
            Case "0503020000"
                Dim dt1 As DataTable
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    mesaño = cmbaño.Text & sMes
                    Cerrar = ""

                    dt = PROVISIONESBL.Select_RegistroComp(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    dt1 = PROVISIONESBL.SelectRegComAll(mesaño)
                    dgvsegundo.DataSource = dt1
                    dgvsegundo.Refresh()
                End If
            Case "0502010000"
                dt = ELTBREGISTRO_NROBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0502110000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = ELLIQUIDACIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0502130000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = ELT_OPEBL.SelectAll(cmbaño.SelectedItem)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0503040000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    mesaño = cmbaño.SelectedItem & sMes
                    Cerrar = ""
                    dt = PROVISIONESBL.Select_RegistroNoDom(cmbaño.Text, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    dt = PROVISIONESBL.SelectRegNomDomAll(mesaño)
                    dgvsegundo.DataSource = dt
                    dgvsegundo.Refresh()
                End If
            Case "0504070000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBPROGPAGOBL.SelectAll("PPAG", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0504080000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBDETRACCIONBL.SelectAll("DET", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0504090000"

                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBKARDEXIMPBL.SelectAll("DIMP", cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0505010000"
                Dim I As Integer
                'gsMes = sMes
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBRECEPCOMPBL.SelectActivos1(cmbaño.Text & sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        Dim btn As New DataGridViewButtonColumn
                        If dgvMain.Columns(0).Name = "btnAprobar" Then
                        Else
                            btn.HeaderText = "Aprobar"
                            btn.Text = "Aprobar"
                            btn.Name = "btnAprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                            dgvMain.Columns.Insert(0, btn)
                            btn = New DataGridViewButtonColumn
                            btn.HeaderText = "Desaprobar"
                            btn.Text = "Desaprobar"
                            btn.Name = "btnDesaprobar"
                            btn.Frozen = True
                            btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                            btn.FlatStyle = FlatStyle.Flat
                            btn.UseColumnTextForButtonValue = True
                            btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                            dgvMain.Columns.Insert(1, btn)
                        End If

                    End If
                End If
            Case "0701010000"
                dt = ELCUENTA_ARTBL.SelectAllOrden(cmbaño.SelectedItem, sMes, cmb_tipo.SelectedIndex)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    'alinear numericos
                    For i = 0 To dgvMain.Rows.Count - 1 ' count++
                        If IIf(IsDBNull(dgvMain.Rows(i).Cells("U_ENT").Value), "", dgvMain.Rows(i).Cells("U_ENT").Value) <> "" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                        End If
                    Next
                End If
            Case "0703010000"
                If chkest.Checked = True Then
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBMANTENIMIENTOBL.SelectAllTo(cmbaño.SelectedItem & sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If
                Else
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBMANTENIMIENTOBL.SelectAll(cmbaño.SelectedItem & sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If
                End If
            Case "0703020000"
                ' Segunda Pantalla
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELORDEN_MANTBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
                ''If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                ''    dt = ELTBMANTENIMIENTOBL.SelectAll(cmbaño.SelectedItem & sMes)
                ''    dgvMain.DataSource = dt
                ''    dgvMain.Refresh()
                ''End If
            Case "0703030000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBMTIEMBL.SelectAll(cmbaño.SelectedItem & sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0703040000"
                ' If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                '     dt = REPORTE_TRABAJOBL.SelectAll(cmbaño.SelectedItem & sMes)
                '     dgvMain.DataSource = dt
                '     dgvMain.Refresh()
                ' End If

                If rdbapr1.Checked = True Then
                    dt = REPORTE_TRABAJOBL.SelectAllHEJ(cmbaño.SelectedItem, sMes, gsCodUsr)
                    sOp = "1"
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                ElseIf rdbapr4.Checked = True Then
                    dt = REPORTE_TRABAJOBL.SelectAll(cmbaño.SelectedItem, sMes, gsCodUsr)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                ElseIf rdbapr2.Checked = True Then
                    dt = REPORTE_TRABAJOBL.SelectAllHEJP(cmbaño.SelectedItem, sMes)
                    sOp = "2"
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "0802010000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBTAREOBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0802110000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELPERMISOSBL.SelectAllS(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0802120000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBTURNOBL.SelectAllS(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0801210000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELRRHH_FUNCIONESBL.SelHorasExtras(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If

            Case "0802130000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBSINTOMAS_COVIDBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0802160000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = CTS_BL.SelectRowAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "1202010000"
                If chkest.Checked = False Then
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBCAPACITACIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If
                Else
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBCAPACITACIONBL.SelectAllTo(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If
                End If

            Case "1202020000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELTBEVALUACIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "1203010000"

            Case "0502140000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = ELDOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0502150000"
                If chkdocexp.Checked = False Then
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = PROVISIONESBL.SelectProvAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        If dgvMain.Rows.Count > 0 Then
                            dgvMain.Columns(5).Visible = False
                        End If
                        dgvMain.Refresh()
                    End If
                Else
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = PROVISIONESBL.SelectExpAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        If dgvMain.Rows.Count > 0 Then
                            dgvMain.Columns(5).Visible = False
                        End If
                        dgvMain.Refresh()
                    End If
                End If


            Case "0502160000"
                btnFiltro.Visible = True
                grpOpe.Visible = True
                grpMon.Visible = True
                Dim ope = "010"
                Dim mon = "00"
                estadoTC = 0
                dt = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, "", "")
                radPag.Checked = False
                radCob.Checked = False
                radSol.Checked = False
                radDol.Checked = False
                dgvMain.DataSource = dt

                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "PEND" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.MediumVioletRed
                        End If
                    Next
                End If
            Case "0502170000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = ELCUENTA_ARTBL.SelectAll(cmbaño.SelectedItem)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0502200000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = ELTBINICIALCBBL.SelectAll(cmbaño.SelectedItem)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If

            Case "0502220000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = ELTBPERCEPBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0504020000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = FACTURACIONBL.SelectEstRecogido(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0504030000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = LETRASBL.SelectEstRecogido(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0504040000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = NOTACREDITOBL.SelectEstRecogido(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0504050000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = NOTADEBITOBL.SelectEstRecogido(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0502040000"
                dt = ELTBMOVIMIENTOBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802040000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELCONTRATOBL.SelectAll(cmbaño.SelectedItem)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0802030000"
                dt = ELTBCONCEPTOSBL.SelectAll()
                dgvMain.DataSource = dt
                TSButtonRefresh_Click(Nothing, Nothing)
            Case "0802070000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELPROGRAMACIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0502100000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = ELUTILIDADESBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0802050000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELVACACIONESBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0802060000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELPERIODOBL.SelectAll(cmbaño.SelectedItem)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
            Case "0802090000"
                If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                    dt = ELPERMISOSBL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If

            Case "0801200000"
                dt = ELRRHH_FUNCIONESBL.SelTurnosOperario(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0801210000"
                dt = ELRRHH_FUNCIONESBL.SelHorasExtras(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "0801220000"
                dt = ELRRHH_FUNCIONESBL.SelHorasExtrasGeneral(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "0504110000"
                dt = CONTABILIDADBL.ListadoLibroDiario(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1
                        If dgvMain.Rows(i).Cells("EST. MC").Value = "PEND" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.MediumVioletRed
                        End If
                    Next
                End If

            Case "0504140000"
                Dim tipo As String = ""
                Select Case cmbTipoCred.SelectedIndex
                    Case 0
                        tipo = "LE"
                    Case 1
                        tipo = "RE"
                    Case 2
                        tipo = "FE"
                    Case 3
                        tipo = "CF"
                End Select
                dt = CONTABILIDADBL.ListadoCreditos(cmbaño.SelectedItem, tipo)

                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0803020000"
                dt = MEMOBL.BuscarListadoMEmo(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()


            Case " 0803030000"
                Dim TIPO = ""
                If gsUser = "CHOYOS" Or gsUser = "SGARCIA" Then
                    TIPO = "21"
                End If
                If gsUser = "JFLORES" Then
                    TIPO = "20"
                End If
                dt = PRESTAMOBL.BuscarListadoPrestamos(cmbaño.SelectedItem, "", TIPO)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            Case "0401060000"
                rdbapr4.Checked = True
                dt = PRODUCCIONBL.ListadoBonoProduccion(cmbaño.SelectedItem, sMes)
                If dt.Rows.Count > 0 Then
                    PRODUCCIONBL.ActualizarBonosProduccion(dt)
                End If
                Dim dt1 = PRODUCCIONBL.ListadoBonoProduccion(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt1
                dgvMain.Refresh()

            Case "0801230000"
                dt = ELRRHH_FUNCIONESBL.SelTardanzas(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

            Case "0901010000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = ELCERTIFICABL.SelectAll(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    If dgvMain.Rows.Count > 0 Then
                        dgvMain.Columns.Item(1).Visible = False
                        dgvMain.Columns.Item(2).Visible = False
                        dgvMain.Columns.Item(3).Visible = False
                        dgvMain.Columns.Item(6).Visible = False
                    End If
                End If
            Case "0901020000"
                If cmbaño.SelectedIndex <> -1 Then
                    dt = ELETIQUETABL.SelectAllPacking(cmbaño.SelectedItem, sMes)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If
        End Select
        gdtMainData = dt
        ' End If
        ''''  gdtMainData = dt


        'PAGINACION 
        'pageSize = tstcmbPageSize.ComboBox.SelectedItem
        'maxRec = dtSource.Rows.Count
        'PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        'If (maxRec Mod pageSize) > 0 Then
        '    PageCount = PageCount + 1
        'End If

        'Initial seeings
        'currentPage = 1
        recNo = 0
        tsbCamposSeek.Items.Clear()
        'MsgBox(tsbCamposSeek.Items.Count)
        'get columns of DGV
        If gsMenuNodeId = "0401020000" Then
            tsbCamposSeek.Items.Add("NRO")
            tsbCamposSeek.Items.Add("CODIGO")
            tsbCamposSeek.Items.Add("ARTICULO")
            tsbCamposSeek.Items.Add("RUC")
            tsbCamposSeek.Items.Add("RAZ_SOCIAL")
            tsbCamposSeek.Items.Add("FEC_GENE")
            tsbCamposSeek.Items.Add("ESTADO")
            lblRecNo.Text = dgvt2.Rows.Count
        ElseIf gsMenuNodeId = "0701010000" Then
            tsbCamposSeek.Items.Add("ACTIVO")
            tsbCamposSeek.Items.Add("C_COSTO")
            tsbCamposSeek.Items.Add("ARTICULO")
            tsbCamposSeek.Items.Add("F_GENERACION")
            tsbCamposSeek.Items.Add("TIPO_REQ")
            tsbCamposSeek.Items.Add("USUARIO")
            lblRecNo.Text = dgvMain.Rows.Count
        Else
            For Each col As DataGridViewColumn In dgvMain.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            lblRecNo.Text = dgvMain.Rows.Count
        End If
        'limpiar busqueda
        lblRecNo.Text = dgvMain.Rows.Count
    End Sub

    Private Sub cmbaño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbaño.SelectedIndexChanged

        bChange = False
        cmbmes.SelectedIndex = -1
        'cmbmes.SelectedItem = sMes
        bChange = True

        If gsMenuNodeId = "0803030000" Then
            Dim TIPO = ""
            If gsUser = "CHOYOS" Or gsUser = "SGARCIA" Then
                TIPO = "21"
            End If
            If gsUser = "JFLORES" Then
                TIPO = "20"
            End If
            Dim dt As New DataTable
            Select Case cmb_tipo.SelectedIndex
                Case -1, 0
                    dt = PRESTAMOBL.BuscarListadoPrestamos(cmbaño.SelectedItem, "", TIPO)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                Case 1
                    dt = PRESTAMOBL.BuscarListadoPrestamos(cmbaño.SelectedItem, "P", TIPO)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                Case 2
                    dt = PRESTAMOBL.BuscarListadoPrestamos(cmbaño.SelectedItem, "C", TIPO)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
            End Select
            If dgvMain.Rows.Count > 0 Then
                For i = 0 To dgvMain.Rows.Count - 1
                    If dgvMain.Rows(i).Cells("ESTADO").Value = "PAGADO" Then
                        dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                    End If
                    If dgvMain.Rows(i).Cells("ESTADO").Value = "PENDIENTE" Then
                        dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    End If
                Next
            End If
        Else
            dgvMain.DataSource = Nothing
        End If
        dgvMain.Refresh()
        If Not bFirst Then
            On Error Resume Next
            If cmbaño.SelectedIndex <> -1 Then
                cmbmes.Items.Clear()
                getCmbMes(cmbmes)
                cmbmes.SelectedItem = UCase(Mid(sMes, 1, 1)) + Mid(sMes, 2)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub tsbCamposSeek_Click(sender As Object, e As EventArgs) Handles tsbCamposSeek.Click

        ' If tsbCamposSeek.Text.Trim <> "" Then
        tsTextSearch.Enabled = True
        ' Else
        ' tsTextSearch.Enabled = False
        ' End If

    End Sub

    Private Sub btnkardex_Click(sender As Object, e As EventArgs) Handles btnkardex.Click
        Select Case gsMenuNodeId
            Case "0204020000"
                Cursor.Current = Cursors.WaitCursor
                If cmbsublinea.SelectedIndex <> -1 Then
                    gsRptArgs = {}
                    Dim sOK As String = T_MOVINVBL.ReporteKardex("kardex", sAño, cmbsublinea.SelectedValue, Mid(cmbalmacen.Text, 1, 4), "")
                    Cursor.Current = Cursors.Default

                    If sOK = "OK" Then
                        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTDIFKARSTK.rpt"
                        gsRptPath = gsPathRpt
                        FormReportes.ShowDialog()
                    Else
                        MsgBox(sOK)
                    End If
                Else
                    MsgBox("No ah seleccionado ningun parametro de Linea o Sublinea", MsgBoxStyle.Exclamation)
                End If
                Cursor.Current = Cursors.Default
            Case "0203050000"
                gsCode = "0"
                gsCode2 = cmbsublinea.Text
                gsCode3 = gsCodAlm
                Dim frm As New FormRptFecKardex
                frm.ShowDialog()
                gsCode = ""
                gsCode2 = ""
                gsCode3 = ""
                'Cursor.Current = Cursors.WaitCursor
                ''If cmbsublinea.SelectedIndex <> -1 Then
                'gsRptArgs = {}
                'Dim sOK As String = T_MOVINVBL.ReporteKardex("fisico", cmbano.Text, gsCode2, gsCodAlm)
                'Cursor.Current = Cursors.Default

                'If sOK = "OK" Then
                '    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTDIFKARSTKFISICO.rpt"
                '    gsRptPath = gsPathRpt
                '    FormReportes.ShowDialog()
                'Else
                '    MsgBox(sOK)
                'End IfRPT02_SP_ARTICULO_STK
        End Select

    End Sub

    Private Sub btnmov_Click(sender As Object, e As EventArgs) Handles btnmov.Click
        Select Case gsMenuNodeId
            Case "0204020000"
                If MessageBox.Show("Desea Generar todos los movimientos negativos?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If
                Cursor.Current = Cursors.WaitCursor
                'If cmbsublinea.SelectedIndex <> -1 Then
                gsRptArgs = {}
                Dim T_MOVINVBE As New T_MOVINVBE

                Dim sOK As String = T_MOVINVBL.ReporteKardex("negativo", cmbano.Text, cmbsublinea.SelectedValue, gsCodAlm, "")
                If sOK = "OK" Then
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_RPTMOVNEGATIVO.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Else
                    MsgBox(sOK)
                End If
            Case "0401020000"
                Try
                    'Dim articulo As String = "02230197"
                    Dim rutaarchivo As String = ""
                    If Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value, 1, 4) = "0223" Then
                        For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.7\Fichas Tecnicas\PDF FICHAS\PDF FICHAS\TWO", FileIO.SearchOption.SearchAllSubDirectories, "" & dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value & " *.pdf")
                            rutaarchivo = archivos
                        Next
                    ElseIf Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value, 1, 4) = "0101" Then
                        For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.5\Fichas Tecnicas\CENTRALPACK\PDF\FIBRA", FileIO.SearchOption.SearchAllSubDirectories, "" & dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value & " *.pdf")
                            rutaarchivo = archivos
                        Next
                    ElseIf Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value, 1, 4) = "0217" Or Mid(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value, 1, 4) = "0216" Then
                        For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.7\Fichas Tecnicas\PDF FICHAS\PDF FICHAS\ENSAMBLE", FileIO.SearchOption.SearchAllSubDirectories, "" & dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value & " *.pdf")
                            rutaarchivo = archivos
                        Next
                    End If

                    System.Diagnostics.Process.Start(rutaarchivo)
                Catch ex As Exception
                    MsgBox("No se realizó la operación por: " & ex.Message)
                End Try
        End Select

        'Else
        'MsgBox("No ah seleccionado ningun parametro de Linea o Sublinea")
        'End If
    End Sub

    Private Sub dgvMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellContentClick, dgvt2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            Dim sArticulo As String = ""
            Select Case gsMenuNodeId
                Case "1001020000"
                    sArticulo = "La Orden N° " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                Case "1001010000"
                    sArticulo = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value + " " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOM_ART").Value
                Case "0402010000"
                    sArticulo = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value + " " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOM_ART").Value
                Case "0402020000"
                    sArticulo = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value + " " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOM_ART").Value
                Case "0402030000"
                    sArticulo = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value + " " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOM_ART").Value
                Case "0505010000"
                    sArticulo = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value + " " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOM_ART").Value
                Case "0206020000"
                    sArticulo = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value + " " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOM_ART").Value
                Case "0305020000"
                    sArticulo = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOMBRES").Value + " " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOMBRES").Value
            End Select
            'TODO - Button Clicked - Execute Code Here
            If e.ColumnIndex = 0 Then
                'aprobar

                Select Case gsMenuNodeId
                    Case "1001020000"
                        Dim tipo = "OREQ"
                        Dim serie = "001"
                        Dim nro = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                        Dim estado = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("EST_APROBACION").Value
                        If estado = "APROBADO" Then
                            MsgBox("Orden de Compra " & nro & " esta aprobada")
                            Exit Sub
                        End If
                        Dim resp = MsgBox("Desea Aprobar la Orden de Compra " & nro, MsgBoxStyle.YesNo)
                        If resp = 7 Then
                            Exit Sub
                        End If
                        flagAccion = "A"
                        Dim ok = REQUERIMIENTOBL.aprobarOrdComp(flagAccion, tipo, serie, nro)
                        If ok = "OK" Then
                            MsgBox("Orden de Compra " & nro & " ha sido aprobada")
                            If dgvMain.Rows.Count > 0 Then
                                TSButtonRefresh_Click(Nothing, Nothing)
                            End If
                        Else
                            MsgBox(ok)
                            Exit Sub
                        End If
                    Case "0401070000"
                        Dim tipo = "OPRD"
                        Dim serie = cmbano.Text
                        Dim nro = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NUMERO").Value
                        Dim estado = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("EST VERIFICADO").Value
                        If estado = "VERIFICADO" Then
                            MsgBox("Orden de Produccion " & nro & " esta VERIFICADA")
                            Exit Sub
                        End If
                        Dim resp = MsgBox("Desea VERIFICAR la Orden de Produccion " & nro, MsgBoxStyle.YesNo)
                        If resp = 7 Then
                            Exit Sub
                        End If
                        flagAccion = "A"
                        Dim ok = REQUERIMIENTOBL.aprobarOrdProd(flagAccion, tipo, serie, nro)
                        If ok = "OK" Then
                            MsgBox("Orden de Produccion " & nro & " ha sido VERIFICADA")
                            If dgvMain.Rows.Count > 0 Then
                                TSButtonRefresh_Click(Nothing, Nothing)
                            End If
                        Else
                            MsgBox(ok)
                            Exit Sub
                        End If

                    Case "1001010000"
                        flagAccion = "A"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0402010000"
                        If MessageBox.Show("Esta seguro de aprobar " + sArticulo + " ?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "AC"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0402020000"
                        If MessageBox.Show("Esta seguro de aprobar " + sArticulo + " ?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "AC"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0402030000"
                        If MessageBox.Show("Esta seguro de aprobar " + sArticulo + " ?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "AC"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If

                    Case "0206010000"
                        If MessageBox.Show("Esta seguro de aprobar la solicitud " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value + " ?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "AS"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0505010000"
                        If MessageBox.Show("Esta seguro de aprobar la recepcion " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value + " ?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "AD"
                        SaveData()
                        Dim valor As String
                        'If tsbCamposSeek.SelectedIndex <> -1 Then
                        valor = tsbCamposSeek.SelectedIndex
                        'Else
                        '    valor = -1
                        'End If
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                            tsbCamposSeek.SelectedIndex = valor
                        End If
                    Case "0206020000"
                        If MessageBox.Show("Esta seguro de Cambiar el estado del documento para Enviar " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value + " ?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "ED"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0205030000"
                        If MessageBox.Show("Esta seguro de cerrar la solicitud de materiales" + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value + " ?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "CSM"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0305020000"
                        If MessageBox.Show("Esta seguro de habilitar al cliente " + sArticulo + " ?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "HC"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If

                    Case "0401060000"
                        Dim percod = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("PER_COD").Value
                        Dim ordProd = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ORD_PROD").Value
                        Dim fecha = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("FEC_PROD").Value
                        Dim proceso = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOM_PROCESO").Value
                        Dim resp = MsgBox("Desea Aprobar Bono de Producion?", vbYesNo)
                        Dim tipo As String = ""
                        If resp = 7 Then
                            Exit Sub
                        End If
                        If rdbapr1.Checked = True Then
                            tipo = "J"
                        End If
                        If rdbapr2.Checked = True Then
                            tipo = "P"
                        End If
                        If rdbapr3.Checked = True Then
                            tipo = "R"
                        End If
                        Dim est As String
                        est = PRODUCCIONBL.ActualizarEstBP(tipo, percod, ordProd, fecha, proceso)
                        If est = "OK" Then
                            MsgBox("Bono Aprobado")
                        Else
                            MsgBox("Bono No Aprobado")
                        End If
                        Dim dt As New DataTable
                        Select Case tipo
                            Case "J"
                                If dgvMain.Rows.Count > 0 Then
                                    dt = PRODUCCIONBL.SelectAllBPJefe(cmbaño.SelectedItem, sMes1)
                                    sOp = "3"
                                    dgvMain.DataSource = dt
                                    dgvMain.Refresh()
                                End If
                            Case "P"
                                If dgvMain.Rows.Count > 0 Then
                                    dt = PRODUCCIONBL.SelectAllBPPlanta(cmbaño.SelectedItem, sMes1)
                                    sOp = "3"
                                    dgvMain.DataSource = dt
                                    dgvMain.Refresh()
                                End If
                            Case "R"
                                If dgvMain.Rows.Count > 0 Then
                                    dt = PRODUCCIONBL.SelectAllBPrrhh(cmbaño.SelectedItem, sMes1)
                                    sOp = "3"
                                    dgvMain.DataSource = dt
                                    dgvMain.Refresh()
                                End If
                        End Select

                    Case "0401040000"
                        If sOp <> "3" Then
                            If MessageBox.Show("Esta seguro de aprobar la Hora Extra " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value + " ?",
                                gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                                Exit Sub
                            End If
                        End If
                        sMes1 = mes(cmbmes.SelectedItem)
                        sest1 = "2"
                        If sOp = "1" Then
                            flagAccion = "HE"
                            SaveData()
                            Dim dt As New DataTable
                            dt = ELTBSTIEMBL.SelectAllHEJ(cmbaño.SelectedItem, sMes1)
                            sOp = "1"
                            dgvMain.DataSource = dt
                            dgvMain.Refresh()
                        ElseIf sOp = "2" Then
                            flagAccion = "HEJP"
                            Dim dt As New DataTable
                            'If dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("OBSERVA").Value.ToString.Length > 0 Then
                            '    sest1 = "1"
                            'End If
                            SaveData()
                            sOp = "2"
                            dt = ELTBSTIEMBL.SelectAllHEJP(cmbaño.SelectedItem, sMes1)
                            dgvMain.DataSource = dt
                            dgvMain.Refresh()

                            For i = 0 To dgvMain.Rows.Count - 1  ' count++
                                If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                        ElseIf sOp = "3" Then
                            flagAccion = "HERH"
                            Dim dt As New DataTable
                            'Dim sMes As String = mes(cmbmes.SelectedItem)
                            Dim frm As New FormProcesarHora
                            frm.sTIPO = "STIEM"
                            frm.sSERIE = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                            frm.sNumero = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                            frm.txtlinea.Text = ELTBSTIEMBL.lineastiem(dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value, dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value)
                            frm.ShowDialog()
                            If dgvMain.Rows.Count > 0 Then
                                dt = ELTBSTIEMBL.SelectAllHERH(cmbaño.SelectedItem, sMes1)
                                sOp = "3"
                                dgvMain.DataSource = dt
                                dgvMain.Refresh()
                            End If
                        End If
                        'If sOp = "1" Then
                        '    flagAccion = "HE"
                        'ElseIf sOp = "2" Then
                        '    flagAccion = "HEJP"
                        'ElseIf sOp = "3" Then
                        '    flagAccion = "HERH"
                        'End If
                        'SaveData()
                    Case "0703040000"
                        If sOp <> "3" Then
                            If MessageBox.Show("Esta seguro de aprobar el seguimiento de trabajo| " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value + " ?",
                                gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                                Exit Sub
                            End If
                        End If
                        sMes1 = mes(cmbmes.SelectedItem)
                        sest1 = "2"
                        If sOp = "1" Then
                            flagAccion = "HM"
                            SaveData()
                            Dim dt As New DataTable
                            dt = REPORTE_TRABAJOBL.SelectAllHEJ(cmbaño.SelectedItem, sMes1, gsCodUsr)
                            sOp = "1"
                            dgvMain.DataSource = dt
                            dgvMain.Refresh()
                        ElseIf sOp = "2" Then
                            flagAccion = "HMJP"
                            Dim dt As New DataTable
                            SaveData()
                            sOp = "2"
                            dt = REPORTE_TRABAJOBL.SelectAllHEJP(cmbaño.SelectedItem, sMes1)
                            dgvMain.DataSource = dt
                            dgvMain.Refresh()

                            For i = 0 To dgvMain.Rows.Count - 1
                                If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                        End If
                End Select
            End If

            'TODO - Button Clicked - Execute Code Here
            If e.ColumnIndex = 1 Then
                'des aprobar
                If gsMenuNodeId <> "0206010000" And gsMenuNodeId <> "0401040000" And gsMenuNodeId <> "0402010000" And gsMenuNodeId <> "0402030000" And gsMenuNodeId <> "0703040000" And
                   gsMenuNodeId <> "1001010000" And gsMenuNodeId <> "1001020000" And gsMenuNodeId <> "0401070000" Then
                    sArticulo = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("PER_COD").Value + " " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOM_PER").Value
                ElseIf gsMenuNodeId = "0402010000" Then
                    sArticulo = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value + " " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NOM_ART").Value
                End If

                Select Case gsMenuNodeId
                    Case "1001020000"
                        Dim tipo = "OREQ"
                        Dim serie = "001"
                        Dim nro = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                        Dim estado = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("EST_APROBACION").Value
                        If estado = "DESAPROBADA" Then
                            MsgBox("Orden de Compra " & nro & " esta desaprobada")
                            Exit Sub
                        End If
                        Dim resp = MsgBox("Desea desaprobar la Orden de Compra " & nro, MsgBoxStyle.YesNo)
                        If resp = 7 Then
                            Exit Sub
                        End If
                        flagAccion = "D"
                        Dim ok = REQUERIMIENTOBL.aprobarOrdComp(flagAccion, tipo, serie, nro)
                        If ok = "OK" Then
                            MsgBox("Orden de Compra " & nro & " ha sido desaprobada")
                            If dgvMain.Rows.Count > 0 Then
                                TSButtonRefresh_Click(Nothing, Nothing)
                            End If
                        Else
                            MsgBox(ok)
                            Exit Sub
                        End If
                    Case "0401070000"
                        Dim tipo = "OPRD"
                        Dim serie = cmbano.Text
                        Dim nro = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NUMERO").Value
                        Dim estado = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("EST VERIFICADO").Value
                        If estado = "NO VERIFICADO" Then
                            MsgBox("Orden de Produccion " & nro & " esta NO VERIFICADA")
                            Exit Sub
                        End If
                        Dim resp = MsgBox("Desea NO VERIFICAR la Orden de Produccion " & nro, MsgBoxStyle.YesNo)
                        If resp = 7 Then
                            Exit Sub
                        End If
                        flagAccion = "D"
                        Dim ok = REQUERIMIENTOBL.aprobarOrdProd(flagAccion, tipo, serie, nro)
                        If ok = "OK" Then
                            MsgBox("Orden de Produccion " & nro & " ha sido NO VERIFICADA")
                            If dgvMain.Rows.Count > 0 Then
                                TSButtonRefresh_Click(Nothing, Nothing)
                            End If
                        Else
                            MsgBox(ok)
                            Exit Sub
                        End If
                    Case "1001010000"
                        flagAccion = "D"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If

                    Case "0402010000"
                        If MessageBox.Show("Esta seguro de desaprobar " + sArticulo + " ?",
                         gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Stop,
                         MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "DE"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0402020000"
                        If MessageBox.Show("Esta seguro de desaprobar " + sArticulo + " ?",
                         gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Stop,
                         MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "DE"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0402030000"
                        If MessageBox.Show("Esta seguro de desaprobar " + sArticulo + " ?",
                         gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Stop,
                         MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "DE"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0401040000"
                        If MessageBox.Show("Esta seguro de Desaprobar la Hora Extra " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value + " ?",
                          gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        'sMes1 =
                        sest1 = "1"
                        If sOp = "1" Then
                            flagAccion = "HE"
                        ElseIf sOp = "2" Then
                            flagAccion = "HEJP"
                        ElseIf sOp = "3" Then
                            flagAccion = "HERH"
                        End If
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If

                    Case "0505010000"
                        'If MessageBox.Show("Esta seguro de desaprobar " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value + " ?",
                        ' gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Stop,
                        ' MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        '    Exit Sub
                        'End If
                        'flagAccion = "DD"
                        'SaveData()
                        'If dgvMain.Rows.Count > 0 Then
                        '    TSButtonRefresh_Click(Nothing, Nothing)
                        'End If
                        If gnOpcion = "1" Then
                            sOp = "0"
                            sTDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("T_DOC_REF").Value
                            sSDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("SER_DOC_REF").Value
                            sNDoc = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value
                            sCos = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("ART_COD").Value
                            FormObsRecepDoc.ShowDialog()
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0206010000"
                        If MessageBox.Show("Esta seguro de desaprobar la solicitud " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value + " ?",
                             gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Stop,
                             MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        flagAccion = "DS"
                        SaveData()
                        If dgvMain.Rows.Count > 0 Then
                            TSButtonRefresh_Click(Nothing, Nothing)
                        End If
                    Case "0703040000"
                        If MessageBox.Show("Esta seguro de desaprobar la solicitud " + dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("NRO_DOC_REF").Value + " ?",
                             gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Stop,
                             MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                        sMes1 = mes(cmbmes.SelectedItem)
                        'sest1 = "2"
                        If sOp = "1" Then
                            flagAccion = "DS"
                            SaveData()
                            Dim dt As New DataTable
                            dt = REPORTE_TRABAJOBL.SelectAllHEJ(cmbaño.SelectedItem, sMes1, gsCodUsr)
                            sOp = "1"
                            dgvMain.DataSource = dt
                            dgvMain.Refresh()
                        ElseIf sOp = "2" Then
                            flagAccion = "DSJP"
                            Dim dt As New DataTable
                            SaveData()
                            sOp = "2"
                            dt = REPORTE_TRABAJOBL.SelectAllHEJP(cmbaño.SelectedItem, sMes1)
                            dgvMain.DataSource = dt
                            dgvMain.Refresh()

                            For i = 0 To dgvMain.Rows.Count - 1
                                If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                                    dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next

                        End If
                End Select
            End If
        End If
    End Sub

    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
        chkNewVersion()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        MsgBox("Existe una nueva versión del sistema (" + nNewVersion + "), se procederá con la actualización ...", MsgBoxStyle.Information)
        'launch app
        Dim proc As New System.Diagnostics.Process()
        proc = Process.Start("C:\CPC\UPDATE\IT.UPDATE.exe", "")
        'dispose()
        End
        Exit Sub
    End Sub

    Private Sub btnmovart_Click(sender As Object, e As EventArgs) Handles btnmovart.Click
        If dgvMain.Rows.Count > 0 Then
            FormMovim.txtcodart.Text = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells(0).Value
            FormMovim.ShowDialog()
            'TSButtonRefresh_Click(Nothing, Nothing)
        Else
            MsgBox("No ah seleccionado ningun parametro de Linea o Sublinea")
        End If

    End Sub

    Private Sub btnstocktodos_Click(sender As Object, e As EventArgs) Handles btnstocktodos.Click
        Select Case gsMenuNodeId
            Case "0204020000"
                Dim FRM As New FormOpcionStock
                FRM.ShowDialog()
                If gnOpcion3 <> Nothing Then
                    Cursor.Current = Cursors.WaitCursor
                    gsRptArgs = {}
                    ReDim gsRptArgs(1)
                    gsRptArgs(0) = gsCodAlm
                    gsRptArgs(1) = Trim(gnOpcion3)
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_ALL.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If
            Case "0302070000"
                If MessageBox.Show("Esta seguro que desea limpiar el excel", gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                Else
                    flagAccion = "UL"
                    SaveData()
                End If
            Case "0504030000"
                If MessageBox.Show("Esta seguro que desea limpiar el excel", gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                Else
                    flagAccion = "UL"
                    SaveData()
                End If
            Case "0203050000"
                'Dim FRM As New FormOpcionStock
                'FRM.ShowDialog()
                'If gnOpcion3 <> Nothing Then
                Cursor.Current = Cursors.WaitCursor
                gsRptArgs = {}
                If Mid(cmbalmacen.Text, 1, 4) = "0003" Then
                    ReDim gsRptArgs(0)
                    gsRptArgs(0) = gsCodAlm
                    'gsRptArgs(1) = Trim(gnOpcion3)
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_FISICO.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                Else
                    ReDim gsRptArgs(0)
                    gsRptArgs(0) = gsCodAlm
                    'gsRptArgs(1) = Trim(gnOpcion3)
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_FISICO1.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If

                'End If

        End Select
        'If btnstocktodos.Text = "Stock Todos" Then
        'ElseIf btnstocktodos.Text = "Limpiar Excel" Then
        'End If
    End Sub

    Private Sub btnsublinea_Click(sender As Object, e As EventArgs) Handles btnsublinea.Click
        'Dim FRM As New FormOpcionStock
        'FRM.ShowDialog()
        'If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
        '    If gnOpcion3 <> Nothing Then
        '        ReDim gsRptArgs(2)
        '        gsRptArgs(0) = cmbsublinea.SelectedValue
        '        gsRptArgs(1) = gsCodAlm
        '        gsRptArgs(2) = gnOpcion3
        '        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK.rpt"
        '        gsRptPath = gsPathRpt
        '        FormReportes.ShowDialog()
        '    End If
        'Else
        '    MsgBox("Seleccion Linea y Sub Linea")
        'End If
        Select Case gsMenuNodeId
            Case "0204020000"
                'Dim calm As String
                Dim FRM As New FormOpcionStock
                FRM.sublinea = 1
                FRM.ShowDialog()
                If gnOpcion3 = "T" Then
                    cmblinea.SelectedIndex = 0
                    cmbsublinea.SelectedIndex = 0
                End If
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    If gnOpcion3 <> Nothing Then
                        If cmbsublinea.SelectedIndex = "1" Then
                            If cmblinea.SelectedIndex = 1 Then
                                If cAlm = 0 Then
                                    ReDim gsRptArgs(1)
                                    gsRptArgs(0) = gnOpcion3
                                    gsRptArgs(1) = cmbano.Text
                                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_0201_2.rpt"
                                    gsRptPath = gsPathRpt
                                    FormReportes.ShowDialog()
                                Else
                                    ReDim gsRptArgs(3)
                                    gsRptArgs(0) = cmbsublinea.SelectedValue
                                    gsRptArgs(1) = gsCodAlm
                                    gsRptArgs(2) = gnOpcion3
                                    gsRptArgs(3) = cmbano.Text
                                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_0201.rpt"
                                    gsRptPath = gsPathRpt
                                    FormReportes.ShowDialog()
                                End If

                            Else
                                If cAlm = 0 Then


                                    ReDim gsRptArgs(2)
                                    gsRptArgs(0) = cmbsublinea.SelectedValue
                                    gsRptArgs(1) = gsCodAlm
                                    If gnOpcion = "S" Then
                                        gsRptArgs(2) = 0.0001
                                    Else
                                        gsRptArgs(2) = 0
                                    End If
                                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_0216_1.rpt"
                                    gsRptPath = gsPathRpt
                                    FormReportes.ShowDialog()





                                Else
                                    ReDim gsRptArgs(3)
                                    gsRptArgs(0) = cmbsublinea.SelectedValue
                                    gsRptArgs(1) = "000" + cAlm 'gsCodAlm
                                    gsRptArgs(2) = gnOpcion3
                                    gsRptArgs(3) = cmbano.Text

                                    ELARTLINEASTOKBL.Reporteartlineastok("ESOP", cmbsublinea.SelectedValue, "000" + cAlm, gnOpcion3, cmbano.Text)

                                    ELARTLINEASTOKBL.Reporteartlineastok("SOP1", cmbsublinea.SelectedValue, "000" + cAlm, gnOpcion3, cmbano.Text)

                                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK1.rpt"
                                    gsRptPath = gsPathRpt
                                    FormReportes.ShowDialog()
                                End If

                            End If

                        Else 'If cmbsublinea.SelectedValue = "0216" Then
                            If cAlm = 0 Then

                                If gnOpcion3 = "T" Then
                                    ReDim gsRptArgs(2)
                                    gsRptArgs(0) = ""
                                    gsRptArgs(1) = ""
                                    gsRptArgs(2) = 0.1
                                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_0216_1.rpt"
                                    gsRptPath = gsPathRpt
                                    FormReportes.ShowDialog()

                                Else
                                    ReDim gsRptArgs(2)
                                    gsRptArgs(0) = cmbsublinea.SelectedValue
                                    gsRptArgs(1) = gsCodAlm
                                    If gnOpcion3 = "S" Then
                                        gsRptArgs(2) = 0.1
                                    Else
                                        gsRptArgs(2) = 0
                                    End If
                                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_0216_1.rpt"
                                    gsRptPath = gsPathRpt
                                    FormReportes.ShowDialog()
                                End If



                                'Else
                                '    ReDim gsRptArgs(1)

                                '    gsRptArgs(0) = cmbsublinea.SelectedValue
                                '    gsRptArgs(1) = "000" + cAlm
                                '    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_0216.rpt"
                                '    gsRptPath = gsPathRpt
                                '    FormReportes.ShowDialog()
                            Else
                                ReDim gsRptArgs(3)

                                gsRptArgs(0) = cmbsublinea.SelectedValue
                                gsRptArgs(1) = "000" + cAlm 'gsCodAlm
                                gsRptArgs(2) = gnOpcion3
                                gsRptArgs(3) = cmbano.Text

                                ELARTLINEASTOKBL.Reporteartlineastok("ESOP", cmbsublinea.SelectedValue, "000" + cAlm, gnOpcion3, cmbano.Text)

                                ELARTLINEASTOKBL.Reporteartlineastok("SOP1", cmbsublinea.SelectedValue, "000" + cAlm, gnOpcion3, cmbano.Text)

                                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK1.rpt"
                                gsRptPath = gsPathRpt
                                FormReportes.ShowDialog()
                            End If
                            cAlm = Nothing
                            'Else
                            '    ReDim gsRptArgs(3)

                            '    gsRptArgs(0) = cmbsublinea.SelectedValue
                            '    gsRptArgs(1) = gsCodAlm
                            '    gsRptArgs(2) = gnOpcion3
                            '    gsRptArgs(3) = cmbano.Text
                            '    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK.rpt"
                            '    gsRptPath = gsPathRpt
                            '    FormReportes.ShowDialog()
                        End If
                    End If
                Else
                    MsgBox("Seleccion Linea y Sub Linea")
                End If

            Case "0401020000"
                Try
                    'Dim articulo As String = "02230197"
                    Dim rutaarchivo As String = ""
                    If Mid(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, 1, 4) = "0213" Or Mid(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, 1, 4) = "0223" Then
                        For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.7\Fichas Tecnicas\PDF FICHAS\PDF FICHAS\TWO", FileIO.SearchOption.SearchAllSubDirectories, "" & dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value & " *.pdf")
                            rutaarchivo = archivos
                        Next
                    ElseIf Mid(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, 1, 4) = "0101" Then
                        For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.5\Fichas Tecnicas\CENTRALPACK\PDF\FIBRA", FileIO.SearchOption.SearchAllSubDirectories, "" & dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value & " *.pdf")
                            rutaarchivo = archivos
                        Next
                    ElseIf Mid(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, 1, 4) = "0217" Or Mid(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, 1, 4) = "0216" Or
                        Mid(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, 1, 4) = "0219" Or Mid(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, 1, 4) = "0218" Or
                        Mid(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, 1, 4) = "0220" Then
                        For Each archivos As String In My.Computer.FileSystem.GetFiles("\\192.168.1.7\Fichas Tecnicas\PDF FICHAS\PDF FICHAS\ENSAMBLE", FileIO.SearchOption.SearchAllSubDirectories, "" & dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value & " *.pdf")
                            rutaarchivo = archivos
                        Next
                    End If

                    System.Diagnostics.Process.Start(rutaarchivo)
                Catch ex As Exception
                    MsgBox("No se realizó la operación por: " & ex.Message)
                End Try
            Case "0204020000"
                'Dim calm As String
                Dim FRM As New FormOpcionStock
                FRM.sublinea = 1
                FRM.ShowDialog()
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    If gnOpcion3 <> Nothing Then
                        If cmbsublinea.SelectedIndex = "1" Then
                            ReDim gsRptArgs(3)
                            gsRptArgs(0) = cmbsublinea.SelectedValue
                            gsRptArgs(1) = gsCodAlm
                            gsRptArgs(2) = gnOpcion3
                            gsRptArgs(3) = cmbano.Text
                            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_0201.rpt"
                            gsRptPath = gsPathRpt
                            FormReportes.ShowDialog()
                        ElseIf cmbsublinea.SelectedValue = "0216" Then
                            If cAlm = 0 Then
                                ReDim gsRptArgs(1)

                                gsRptArgs(0) = cmbsublinea.SelectedValue
                                gsRptArgs(1) = gsCodAlm
                                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_0216_1.rpt"
                                gsRptPath = gsPathRpt
                                FormReportes.ShowDialog()
                            Else
                                ReDim gsRptArgs(1)

                                gsRptArgs(0) = cmbsublinea.SelectedValue
                                gsRptArgs(1) = "000" + cAlm
                                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_0216.rpt"
                                gsRptPath = gsPathRpt
                                FormReportes.ShowDialog()
                            End If
                            cAlm = Nothing
                        Else
                            ReDim gsRptArgs(3)

                            gsRptArgs(0) = cmbsublinea.SelectedValue
                            gsRptArgs(1) = gsCodAlm
                            gsRptArgs(2) = gnOpcion3
                            gsRptArgs(3) = cmbano.Text
                            gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK.rpt"
                            gsRptPath = gsPathRpt
                            FormReportes.ShowDialog()
                        End If
                    End If
                Else
                    MsgBox("Seleccion Linea y Sub Linea")
                End If

        End Select


    End Sub

    Private Sub btnseg_Click(sender As Object, e As EventArgs) Handles btnseg.Click
        Dim mesresul As String
        Select Case gsMenuNodeId
            Case "0302070000"
                mesresul = mes(cmbmes.Text)
                If mesresul = DateTime.Now.ToString("MM").PadLeft(2, "0") Then

                End If
                Dim sMes As String = mes(cmbmes.SelectedItem)
                If sMes <= "11" And cmbaño.Text = "2019" Then
                    MsgBox("Mes Cerrado")
                    Exit Sub
                End If
                If MessageBox.Show("Desea generar el Registro de Letras",
               gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                    Exit Sub
                End If
                ELTBTIPOCAMBIOBE.fec1 = cmbaño.Text & sMes
                ELTBTIPOCAMBIOBL.SaveRowCmb(ELTBTIPOCAMBIOBE, "UCT")
                gsError = LETRASBL.SaveRowAllMes("UPD", cmbaño.Text, sMes, dgvsegundo)
                If gsError = "OK" Then
                    Dim mesaño As String = sMes & cmbaño.Text
                    gsError2 = LETRASBL.SaveRowAllMes("AsAll", mesaño, sMes, dgvsegundo)
                    If gsError2 = "OK" Then
                        MsgBox("Asientos Creados", MsgBoxStyle.Information)
                    Else
                        LblError.Text = gsError2
                        MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                    End If
                Else
                    LblError.Text = gsError
                    MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                End If
            'Case "0204020000"
            '    Dim FRM As New FormOpcionStock
            '    FRM.ShowDialog()
            '    'If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
            '    If gnOpcion3 <> Nothing Then
            '        ReDim gsRptArgs(1)
            '        gsRptArgs(0) = gsCodAlm
            '        gsRptArgs(1) = Trim(gnOpcion3)
            '        gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\   _SEG.rpt"
            '        gsRptPath = gsPathRpt
            '        FormReportes.ShowDialog()
            '    End If
            Case "0204020000"
                Dim FRM As New FormOpcionStock
                FRM.ShowDialog()
                'If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                If gnOpcion3 <> Nothing Then
                    ReDim gsRptArgs(1)
                    gsRptArgs(0) = gsCodAlm
                    gsRptArgs(1) = Trim(gnOpcion3)
                    gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_SP_ARTICULO_STK_SEG.rpt"
                    gsRptPath = gsPathRpt
                    FormReportes.ShowDialog()
                End If
            Case "0401020000"
                ReDim gsRptArgs(0)
                'gsRptArgs(0) = cmbcatalogo.SelectedValue
                gsRptArgs(0) = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value
                gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ART_CAR_DATO2.rpt"
                gsRptPath = gsPathRpt
                FormReportes.ShowDialog()
        End Select
        'Else
        '    MsgBox("Seleccion Linea y Sub Linea")
        'End If
    End Sub

    Private Sub chkestado_CheckedChanged(sender As Object, e As EventArgs) Handles chkestado.CheckedChanged
        Dim dt As New DataTable
        dt = Nothing
        Dim acumulado As Double = 0
        Dim sMes As String = mes(cmbmes.SelectedItem)
        If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
            If chkestado.Checked Then
                dt = REPORTE_PRODUCCIONBL.SelectActivos(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                If dgvMain.Rows.Count > 0 Then
                    'alinear numericos
                    dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                End If

            ElseIf chkestado.Checked = False Then
                dt = REPORTE_PRODUCCIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()

                If dgvMain.Rows.Count > 0 Then
                    'alinear numericos
                    dgvMain.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvMain.Columns("CANTIDAD").DefaultCellStyle.Format = "N3"
                End If
            End If
        End If
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click

        Dim sMes As String = mes(cmbmes.SelectedItem)
        Cursor.Current = Cursors.WaitCursor
        'BOTON GENERAR VENTAS
        If btnVentas.Text = "Generar Ventas" Then
            Dim filas As DataRow
            Dim dt As DataTable
            If gsUser = "SISTEMA" Or gsUser = "CHOYOS" Or gsUser = "WFARFAN" Or gsUser = "JHUAYLLACAYAN" Then
                dt = ELTBCTA_FACTURACIONBL.SelectArtncnd(cmbaño.SelectedItem, sMes & cmbaño.SelectedItem)
                If dt.Rows.Count > 0 Then
                    If MessageBox.Show("Hay " & dt.Rows.Count & " Articulos sin asiento desea ingresarlos? ",
                                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                        Exit Sub
                    Else
                        gnOpcion = 1
                        For Each filas In dt.Rows
                            If Cerrar = "Cerrar" Then
                                Cerrar = ""
                                Exit Sub
                            Else
                                Dim frm As New FormCtaNDNC
                                gsCode = filas("t_doc_ref")
                                gsCode2 = filas("ser_doc_ref")
                                gsCode3 = filas("nro_doc_ref")
                                'gsCode4 = filas("art_cod")
                                gsCode4 = filas("moneda")
                                sFecCom = filas("FEC")
                                gsCode7 = filas("NRO_DOC_CLIENTE")
                                gsCode6 = PROVISIONESBL.SelectT_Prov(gsCode7)
                                'cmbaño.Text & mesaño
                                'gsCode7 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("RUC").Value
                                frm.ShowDialog()
                                gsCode = ""
                                gsCode2 = ""
                                gsCode3 = ""
                                gsCode4 = ""
                                sFecCom = ""
                                gsCode7 = ""
                                gsCode6 = ""
                            End If
                        Next
                    End If
                Else

                    ELTBTIPOCAMBIOBE.fec1 = cmbaño.Text & sMes
                    ELTBTIPOCAMBIOBL.SaveRowCmb(ELTBTIPOCAMBIOBE, "UCT")
                    gsError = FACTURACIONBL.SaveRowAllMes("UPD", cmbaño.Text, sMes, dgvsegundo, "")
                    If gsError = "OK" Then
                        Dim mesaño As String = sMes & cmbaño.Text
                        gsError2 = FACTURACIONBL.SaveRowAllMes("AsAll1", mesaño, sMes, dgvsegundo, gsCodUsr)
                        If gsError2 = "OK" Then
                            MsgBox("Asientos Creados", MsgBoxStyle.Information)
                        Else
                            LblError.Text = gsError2
                            MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                        End If
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                    End If
                End If
            Else
                If sMes <= "11" And cmbaño.Text <= "2021" Then
                    MsgBox("Mes Cerrado")
                    Exit Sub
                End If
                'If System.DateTime.Now.Month - sMes >= 1 And cmbaño.Text = System.DateTime.Now.Year And System.DateTime.Now.Day >= "17" Then
                '    MsgBox("Mes Cerrado")
                '    Exit Sub
                'End If
                SaveData()
                'If sMes = "01" And cmbaño.Text = "2020" Then
                'If System.DateTime.Now.Month - sMes = 1 Then

                'End If
                If System.DateTime.Now.Month - sMes <= 1 And cmbaño.Text = System.DateTime.Now.Year Then
                    If System.DateTime.Now.Month = sMes Then
                    End If
                    'Aca va nuevo codigo acerca de los asientos
                    'dt = ELTBCTA_FACTURACIONBL.SelectArtncnd(cmbaño.SelectedItem, sMes & cmbaño.SelectedItem)
                    dt = ELTBCTA_FACTURACIONBL.SelectArtncnd(cmbaño.SelectedItem, sMes & cmbaño.SelectedItem)
                    If dt.Rows.Count > 0 Then
                        If MessageBox.Show("Hay " & dt.Rows.Count & " Articulos sin asiento desea ingresarlos? ",
                                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        Else
                            gnOpcion = 1
                            'ELTBTIPOCAMBIOBE.fec1 = cmbaño.Text & sMes
                            'ELTBTIPOCAMBIOBL.SaveRowCmb(ELTBTIPOCAMBIOBE, "UCT")
                            'gsError = FACTURACIONBL.SaveRowAllMes("UPD", cmbaño.Text, sMes, dgvsegundo)
                            'If gsError = "OK" Then
                            '    Dim mesaño As String = sMes & cmbaño.Text
                            '    gsError2 = FACTURACIONBL.SaveRowAllMes("AsAll1", mesaño, sMes, dgvsegundo)
                            '    If gsError2 = "OK" Then
                            '        MsgBox("Asientos Creados", MsgBoxStyle.Information)
                            '    Else
                            '        LblError.Text = gsError2
                            '        MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                            '    End If
                            'Else
                            '    LblError.Text = gsError
                            '    MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                            'End If
                            'gnOpcion = 0
                            'Dim Datos() As String
                            For Each filas In dt.Rows
                                If Cerrar = "Cerrar" Then
                                    Cerrar = ""
                                    Exit Sub
                                Else
                                    Dim frm As New FormCtaNDNC
                                    gsCode = filas("t_doc_ref")
                                    gsCode2 = filas("ser_doc_ref")
                                    gsCode3 = filas("nro_doc_ref")
                                    'gsCode4 = filas("art_cod")
                                    gsCode4 = filas("moneda")
                                    sFecCom = filas("FEC")
                                    gsCode7 = filas("NRO_DOC_CLIENTE")
                                    gsCode6 = PROVISIONESBL.SelectT_Prov(gsCode7)
                                    'cmbaño.Text & mesaño
                                    'gsCode7 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("RUC").Value
                                    frm.ShowDialog()
                                    gsCode = ""
                                    gsCode2 = ""
                                    gsCode3 = ""
                                    gsCode4 = ""
                                    sFecCom = ""
                                    gsCode7 = ""
                                    gsCode6 = ""
                                End If
                            Next
                        End If
                    Else

                        ELTBTIPOCAMBIOBE.fec1 = cmbaño.Text & sMes
                        ELTBTIPOCAMBIOBL.SaveRowCmb(ELTBTIPOCAMBIOBE, "UCT")
                        gsError = FACTURACIONBL.SaveRowAllMes("UPD", cmbaño.Text, sMes, dgvsegundo, "")
                        If gsError = "OK" Then
                            Dim mesaño As String = sMes & cmbaño.Text
                            gsError2 = FACTURACIONBL.SaveRowAllMes("AsAll1", mesaño, sMes, dgvsegundo, gsCodUsr)
                            If gsError2 = "OK" Then
                                MsgBox("Asientos Creados", MsgBoxStyle.Information)
                            Else
                                LblError.Text = gsError2
                                MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                            End If
                        Else
                            LblError.Text = gsError
                            MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                        End If
                    End If
                ElseIf sMes = "12" And System.DateTime.Now.Year - cmbaño.Text = 1 Then
                    dt = ELTBCTA_FACTURACIONBL.SelectArtncnd(cmbaño.SelectedItem, sMes & cmbaño.SelectedItem)
                    If dt.Rows.Count > 0 Then
                        If MessageBox.Show("Hay " & dt.Rows.Count & " Articulos sin asiento desea ingresarlos? ",
                                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        Else
                            gnOpcion = 1
                            'ELTBTIPOCAMBIOBE.fec1 = cmbaño.Text & sMes
                            'ELTBTIPOCAMBIOBL.SaveRowCmb(ELTBTIPOCAMBIOBE, "UCT")
                            'gsError = FACTURACIONBL.SaveRowAllMes("UPD", cmbaño.Text, sMes, dgvsegundo)
                            'If gsError = "OK" Then
                            '    Dim mesaño As String = sMes & cmbaño.Text
                            '    gsError2 = FACTURACIONBL.SaveRowAllMes("AsAll1", mesaño, sMes, dgvsegundo)
                            '    If gsError2 = "OK" Then
                            '        MsgBox("Asientos Creados", MsgBoxStyle.Information)
                            '    Else
                            '        LblError.Text = gsError2
                            '        MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                            '    End If
                            'Else
                            '    LblError.Text = gsError
                            '    MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                            'End If
                            'gnOpcion = 0
                            'Dim Datos() As String
                            For Each filas In dt.Rows
                                If Cerrar = "Cerrar" Then
                                    Cerrar = ""
                                    Exit Sub
                                Else
                                    Dim frm As New FormCtaNDNC
                                    gsCode = filas("t_doc_ref")
                                    gsCode2 = filas("ser_doc_ref")
                                    gsCode3 = filas("nro_doc_ref")
                                    'gsCode4 = filas("art_cod")
                                    gsCode4 = filas("moneda")
                                    sFecCom = filas("FEC")
                                    gsCode7 = filas("NRO_DOC_CLIENTE")
                                    gsCode6 = PROVISIONESBL.SelectT_Prov(gsCode7)
                                    'cmbaño.Text & mesaño
                                    'gsCode7 = dgvMain.Rows(dgvMain.CurrentRow.Index).Cells("RUC").Value
                                    frm.ShowDialog()
                                    gsCode = ""
                                    gsCode2 = ""
                                    gsCode3 = ""
                                    gsCode4 = ""
                                    sFecCom = ""
                                    gsCode7 = ""
                                    gsCode6 = ""
                                End If
                            Next
                        End If
                    Else

                        ELTBTIPOCAMBIOBE.fec1 = cmbaño.Text & sMes
                        ELTBTIPOCAMBIOBL.SaveRowCmb(ELTBTIPOCAMBIOBE, "UCT")
                        gsError = FACTURACIONBL.SaveRowAllMes("UPD", cmbaño.Text, sMes, dgvsegundo, "")
                        If gsError = "OK" Then
                            Dim mesaño As String = sMes & cmbaño.Text
                            gsError2 = FACTURACIONBL.SaveRowAllMes("AsAll1", mesaño, sMes, dgvsegundo, gsCodUsr)
                            If gsError2 = "OK" Then
                                MsgBox("Asientos Creados", MsgBoxStyle.Information)
                            Else
                                LblError.Text = gsError2
                                MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                            End If
                        Else
                            LblError.Text = gsError
                            MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                        End If
                    End If
                ElseIf sMes = "12" And cmbaño.Text = "2019" Then
                    dt = ELTBCTA_FACTURACIONBL.SelectArticulosAsiento(cmbaño.SelectedItem, sMes & cmbaño.SelectedItem)
                    If dt.Rows.Count > 0 Then
                        If MessageBox.Show("Hay " & dt.Rows.Count & " Articulos sin asiento desea ingresarlos? ",
                                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Exit Sub
                        Else
                            gnOpcion = 0
                            Dim Datos() As String
                            For Each filas In dt.Rows
                                If Cerrar = "Cerrar" Then
                                    Cerrar = ""
                                    Exit Sub
                                Else
                                    Dim frm As New FormMantELTBCTA_FACTURAC
                                    frm.txtcod_inicial.Text = filas("ART_COD")
                                    frm.TextBox3.Text = ARTICULOBL.SelectArt2(filas("ART_COD"))
                                    frm.txtcod_final.Text = filas("ART_COD")
                                    frm.TextBox4.Text = ARTICULOBL.SelectArt2(filas("ART_COD"))
                                    frm.txt_t_movinv.Text = filas("T_MOVINV")
                                    frm.txtmon.Text = filas("MONEDA")

                                    Datos = ELTBCTA_FACTURACIONBL.DatosFactura(filas("ART_COD"), cmbaño.SelectedItem, sMes).Split("|")
                                    frm.txtnro_ref.Text = Datos(0)
                                    frm.txtnomref.Text = Datos(1)
                                    frm.txttip_ref.Text = Datos(2)
                                    frm.txt_t_movinv.Text = Datos(3)
                                    frm.TextBox1.Text = ARTICULOBL.getMedida(frm.txtcod_inicial.Text)
                                    frm.TextBox11.Text = ARTICULOBL.getMedida_old(frm.txtcod_inicial.Text)
                                    frm.TextBox2.Text = ARTICULOBL.getMedida(frm.txtcod_final.Text)
                                    frm.TextBox10.Text = ARTICULOBL.getMedida_old(frm.txtcod_final.Text)
                                    sOp = "1"
                                    frm.txt_bruta.Select()
                                    frm.cmb_año.SelectedItem = cmbaño.Text
                                    frm.ShowDialog()
                                End If
                            Next

                        End If
                    Else
                        ELTBTIPOCAMBIOBE.fec1 = cmbaño.Text & sMes
                        ELTBTIPOCAMBIOBL.SaveRowCmb(ELTBTIPOCAMBIOBE, "UCT")
                        gsError = FACTURACIONBL.SaveRowAllMes("UPD", cmbaño.Text, sMes, dgvsegundo, "")
                        If gsError = "OK" Then
                            Dim mesaño As String = sMes & cmbaño.Text
                            gsError2 = FACTURACIONBL.SaveRowAllMes("AsAll", mesaño, sMes, dgvsegundo, gsUser)
                            If gsError2 = "OK" Then
                                MsgBox("Asientos Creados", MsgBoxStyle.Information)
                            Else
                                LblError.Text = gsError2
                                MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                            End If
                        Else
                            LblError.Text = gsError
                            MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                        End If
                    End If
                Else
                    MsgBox("Mes Cerrado")
                End If
            End If


            'BOTON ELIMINAR
        ElseIf btnVentas.Text = "Ordenar Pagos" Then
            If cmbaño.Text & sMes >= 202211 Then
                gsError = ELPAGO_DOCUMENTOBL.SaveRowAllMes("AsAll", cmbaño.Text, sMes, "010", gsUser)
                If gsError = "OK" Then
                    MsgBox("Asientos Ordenados", MsgBoxStyle.Information)
                Else
                    LblError.Text = gsError
                    MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Solo se puede Ordenar pagos de noviembre en adelante")
                Exit Sub
            End If

        ElseIf btnVentas.Text = "Ordenar Cobranzas" Then
            If cmbaño.Text & sMes >= 202211 Then
                gsError = ELPAGO_DOCUMENTOBL.SaveRowAllMes("AsAll", cmbaño.Text, sMes, "013", gsUser)
                If gsError = "OK" Then
                    MsgBox("Asientos Ordenados", MsgBoxStyle.Information)
                Else
                    LblError.Text = gsError
                    MsgBox("Error al Ordenar Asientos", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Solo se puede Ordenar Cobranzas de noviembre en adelante")
                Exit Sub
            End If
        ElseIf btnVentas.Text = "Ordenar Diario" Then
            If cmbaño.Text & sMes >= 202210 Then
                gsError = CONTABILIDADBL.SaveRowAllMes("AsAll", cmbaño.Text, sMes, gsUser)
                If gsError = "OK" Then
                    MsgBox("Asientos Ordenados", MsgBoxStyle.Information)
                Else
                    LblError.Text = gsError
                    MsgBox("Error al Ordenar Asientos", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Solo se puede Ordenar Diario de noviembre en adelante")
                Exit Sub
            End If
        ElseIf btnVentas.Text = "Ordenar Liquidaciones" Then
            If cmbaño.Text & sMes >= 202210 Then
                gsError = CONTABILIDADBL.SaveRowAllMes("AsAll1", cmbaño.Text, sMes, gsUser)
                If gsError = "OK" Then
                    MsgBox("Asientos Ordenados", MsgBoxStyle.Information)
                Else
                    LblError.Text = gsError
                    MsgBox("Error al Ordenar Asientos", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Solo se puede Ordenar Liquidaciones de noviembre en adelante")
                Exit Sub
            End If

        ElseIf btnVentas.Text = "Eliminar" Then
            Dim i As Integer = 0
            Dim row As DataGridViewRow

            If MessageBox.Show("Esta seguro de Eliminar el Registro",
                                   gpCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                Exit Sub
            Else
                flagAccion = "E"
                Select Case gsMenuNodeId
                    Case "0502040000"
                        For Each row In dgvMain.SelectedRows
                            Dim TBMOVIMIENTOBE As New ELTBMOVIMIENTOBE
                            TBMOVIMIENTOBE.anho = row.Cells("AÑO").Value.ToString
                            TBMOVIMIENTOBE.mes = row.Cells("MES").Value.ToString
                            TBMOVIMIENTOBE.t_ope_cod = row.Cells("TIPO_OPE").Value.ToString
                            TBMOVIMIENTOBE.reg_nro = row.Cells("N_REGISTRO").Value.ToString
                            TBMOVIMIENTOBE.seq = row.Cells("SEQ").Value.ToString
                            gsError = ELTBMOVIMIENTOBL.SaveRow(TBMOVIMIENTOBE, flagAccion)
                        Next
                    Case "0802010000"
                        For Each row In dgvMain.SelectedRows
                            Dim ELTBTAREOBE As New ELTBTAREOBE
                            ELTBTAREOBE.cod = row.Cells("DNI").Value.ToString
                            ELTBTAREOBE.fecha = row.Cells("FECHA").Value.ToString
                            ELTBTAREOBE.id = row.Cells("INDICE").Value.ToString
                            ELTBTAREOBE.usuactu = gsCodUsr
                            gsError = ELTBTAREOBL.SaveRow(ELTBTAREOBE, flagAccion, dgvsegundo)
                        Next
                End Select
                If gsError = "OK" Then
                    MsgBox("Se Eliminó El Registro Correctamente", MsgBoxStyle.Information)
                    TSButtonRefresh_Click(Nothing, Nothing)
                Else
                    MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
                End If
            End If
        ElseIf btnVentas.Text = "Excel" And gsMenuNodeId = "0302070000" Then
            Dim dtArticulo As DataTable
            dtArticulo = LETRASBL.getListdgvletras()
            dgvsegundo.DataSource = dtArticulo
            dgvsegundo.Refresh()
            Call GridAExcel(dgvsegundo)

        ElseIf btnVentas.Text = "Ingreso Días" Then
            If cmb_tipo.SelectedIndex = 1 Then
                sOp = "2"
            ElseIf cmb_tipo.SelectedIndex = 2 Then
                sOp = "3"
            Else
                sOp = "1"
            End If

            FormCargarDias.ShowDialog()
        ElseIf btnVentas.Text = "Explosion Art." Then
            'If cmbsublinea.SelectedIndex <> -1 Then
            Dim frm As New FormRptExpArtCos
            frm.ShowDialog()
            'ReDim gsRptArgs(0)
            'gsRptArgs(0) = Mid(cmbsublinea.Text, 1, 4)
            'gsPathRpt = gsIpserver & "sistema\E.ELUX\REPORTES\02\RPT02_ART_COMPO2.rpt"
            'gsRptPath = gsPathRpt
            'FormReportes.ShowDialog()
            'Else
            '    MsgBox("Seleccione Sublinea")
            'End If

        ElseIf btnVentas.Text = "Generar Compras" Then
            Dim filas As DataRow
            Dim dt As DataTable
            'SaveData()
            Dim mesaño As String = cmbaño.Text & sMes
            Dim mesaño1 As String = sMes & cmbaño.Text
            If gsUser = "SISTEMA" Or gsUser = "CHOYOS" Or gsUser = "JHUAYLLACAYAN" Or gsUser = "WFARFAN" Then
                gsError3 = PROVISIONESBL.SaveRowAllMes("TC", cmbaño.Text, mesaño, gsUser, dgvsegundo)
                If gsError3 = "OK" Then
                    gsError = PROVISIONESBL.SaveRowAllMes("UPD", cmbaño.Text, sMes, "", dgvsegundo)
                    If gsError = "OK" Then
                        gsError2 = PROVISIONESBL.SaveRowAllMes("AsAll", mesaño1, sMes, "", dgvsegundo)
                        If gsError2 = "OK" Then
                            MsgBox("Asientos Creados", MsgBoxStyle.Information)
                        Else
                            LblError.Text = gsError2
                            MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                        End If
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Limpiar Asientos", MsgBoxStyle.Critical)
                    End If
                Else
                    LblError.Text = gsError3
                    MsgBox("Error al correr el tipo de cambio", MsgBoxStyle.Critical)
                End If
            Else


                If sMes < "12" And cmbaño.Text <= System.DateTime.Now.Year - 1 Then
                    MsgBox("Mes Cerrado")
                    Exit Sub
                End If
                'If sMes = "01" Then
                If System.DateTime.Now.Month - sMes > 11 And cmbaño.Text = System.DateTime.Now.Year And System.DateTime.Now.Day >= "21" Then
                    MsgBox("Mes Cerrado")
                    Exit Sub
                End If
                If sMes <= "11" And cmbaño.Text <= "2021" Then
                    MsgBox("Mes Cerrado")
                    Exit Sub
                End If
                'End If
                'If sMes = "01" And System.DateTime.Now.Year = cmbaño.Text Then
                '    'Verifica las cuentas en el mes de enero
                '    dt = PROVISIONESBL.SelectCtaDif(cmbaño.Text, sMes)
                '    dgvtercero.DataSource = Nothing
                '    dgvtercero.DataSource = dt
                '    dgvtercero.Refresh()
                '    For i = 0 To dgvtercero.Rows.Count - 1
                '        dt = Nothing
                '        dt = PROVISIONESBL.SelectCtaRepetida(dgvtercero.Rows(i).Cells("CUENTA").Value, cmbaño.Text)
                '        dgvcuarto.Rows.Add(dgvtercero.Rows(i).Cells("CUENTA").Value, dgvtercero.Rows(i).Cells("CUENTA_DEST").Value)
                '    Next
                'ElseIf (sMes = System.DateTime.Now.Month Or sMes = System.DateTime.Now.Month - 1) And
                '    System.DateTime.Now.Year = cmbaño.Text Then
                'End If
                '
                gsError3 = PROVISIONESBL.SaveRowAllMes("TC", cmbaño.Text, mesaño, "", dgvsegundo)
                If gsError3 = "OK" Then
                    gsError = PROVISIONESBL.SaveRowAllMes("UPD", cmbaño.Text, sMes, "", dgvsegundo)
                    If gsError = "OK" Then
                        gsError2 = PROVISIONESBL.SaveRowAllMes("AsAll", mesaño1, sMes, "", dgvsegundo)
                        If gsError2 = "OK" Then
                            MsgBox("Asientos Creados", MsgBoxStyle.Information)
                        Else
                            LblError.Text = gsError2
                            MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                        End If
                    Else
                        LblError.Text = gsError
                        MsgBox("Error al Limpiar Asientos", MsgBoxStyle.Critical)
                    End If
                Else
                    LblError.Text = gsError3
                    MsgBox("Error al correr el tipo de cambio", MsgBoxStyle.Critical)
                End If
            End If
        ElseIf btnVentas.Text = "Generar No Dom." Then
            Dim filas As DataRow
            Dim dt As DataTable
            Dim mesaño As String = cmbaño.Text & sMes
            Dim mesaño1 As String = sMes & cmbaño.Text
            If cmbaño.Text & sMes > "202109" Then
                If dgvsegundo.Rows.Count > 0 Then
                    gsError3 = ELTBDOCEXPBL.SaveRowAllMes("TC", cmbaño.Text, mesaño, gsUser, dgvsegundo)
                    If gsError3 = "OK" Then
                        gsError = ELTBDOCEXPBL.SaveRowAllMes("UPD", cmbaño.Text, sMes, "", dgvsegundo)
                        If gsError = "OK" Then
                            gsError2 = ELTBDOCEXPBL.SaveRowAllMes("AsAll", mesaño1, sMes, "", dgvsegundo)
                            If gsError2 = "OK" Then
                                MsgBox("Asientos Creados", MsgBoxStyle.Information)
                            Else
                                LblError.Text = gsError2
                                MsgBox("Error al Generar Asientos", MsgBoxStyle.Critical)
                            End If
                        Else
                            LblError.Text = gsError
                            MsgBox("Error al Limpiar Asientos", MsgBoxStyle.Critical)
                        End If
                    Else
                        LblError.Text = gsError3
                        MsgBox("Error al correr el tipo de cambio", MsgBoxStyle.Critical)
                    End If
                End If
            End If

        ElseIf btnVentas.Text = "Filtro" Then
            Select Case gsMenuNodeId
                Case "0502150000"
                    FormGenerarFiltro.Show()
                Case "0401020000"
                    FormFiltroOrdenesCompra.Show()
                Case "0203010000"
                    FormFiltroOreq.Show()
            End Select

        End If
    End Sub

    Private Sub chkest_CheckedChanged(sender As Object, e As EventArgs) Handles chkest.CheckedChanged
        Dim dt As New DataTable
        dt = Nothing
        Dim sMes As String = mes(cmbmes.SelectedItem)
        Select Case gsMenuNodeId
            Case "02000000"
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    If chkest.Checked = True Then
                        dt = ARTICULOBL.SelectAll1(cmbsublinea.SelectedValue.ToString)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        TSButtonRefresh_Click(Nothing, Nothing)
                        gdtMainData = dt
                    Else
                        dt = ARTICULOBL.SelectAll(cmbsublinea.SelectedValue.ToString)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        TSButtonRefresh_Click(Nothing, Nothing)
                        gdtMainData = dt
                    End If

                End If
            Case "0802020000"
                If cmb_tipo.SelectedIndex = 1 Then
                    If chkest.Checked Then
                        dt = PERBL.SelPerActivosTemp("21")
                        dgvMain.DataSource = dt
                    Else
                        dt = PERBL.SelPerAllActivosTemp("21")
                        dgvMain.DataSource = dt
                    End If
                ElseIf cmb_tipo.SelectedIndex = 2 Then
                    If chkest.Checked Then
                        dt = PERBL.SelPerActivosTemp("20")
                        dgvMain.DataSource = dt
                    Else
                        dt = PERBL.SelPerAllActivosTemp("20")
                        dgvMain.DataSource = dt

                    End If
                Else
                    If chkest.Checked Then
                        dt = PERBL.SelPerAllActivos
                        dgvMain.DataSource = dt
                    Else
                        dt = PERBL.SelPerAll
                        dgvMain.DataSource = dt
                    End If
                End If
                'If chkest.Checked Then
                '    dt = PERBL.SelPerAllActivos
                '    dgvMain.DataSource = dt
                'Else
                '    dt = PERBL.SelPerAll
                '    dgvMain.DataSource = dt
                'End If
            Case "0502150000"
                ' Dim dt As New DataTable
                If chkest.Checked = True Then
                    btnVentas.Visible = True
                Else
                    btnVentas.Visible = False
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = PROVISIONESBL.SelectProvAll(cmbaño.SelectedItem, (cmbmes.SelectedIndex + 1).ToString.PadLeft(2, "0"))
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    End If

                End If
            Case "0401020000"
                ' Dim dt As New DataTable
                If chkest.Checked = True Then
                    btnVentas.Visible = True
                Else
                    btnVentas.Visible = False
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        'dt = PROVISIONESBL.SelectProvAll(cmbaño.SelectedItem, (cmbmes.SelectedIndex + 1).ToString.PadLeft(2, "0"))
                        dt = ELPRODUCCIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvt2.DataSource = dt
                        dgvt2.Refresh()
                    End If
                End If
            Case "0203010000"
                ' Dim dt As New DataTable
                If chkest.Checked = True Then
                    btnVentas.Visible = True
                Else
                    btnVentas.Visible = False
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        'dt = PROVISIONESBL.SelectProvAll(cmbaño.SelectedItem, (cmbmes.SelectedIndex + 1).ToString.PadLeft(2, "0"))
                        dt = REQUERIMIENTOBL.SelectAll("OREQ", cmbaño.SelectedItem, sMes)
                        dgvt2.DataSource = dt
                        dgvt2.Refresh()
                    End If

                End If
            Case "0703010000"
                If chkest.Checked = True Then
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBMANTENIMIENTOBL.SelectAllTo(cmbaño.SelectedItem & sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'TSButtonRefresh_Click(Nothing, Nothing)
                        'gdtMainData = dt
                    End If
                Else
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBMANTENIMIENTOBL.SelectAll(cmbaño.SelectedItem & sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'TSButtonRefresh_Click(Nothing, Nothing)
                        'gdtMainData = dt
                    End If
                End If
            Case "1202010000"

                If chkest.Checked = True Then
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBCAPACITACIONBL.SelectAllTo(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'TSButtonRefresh_Click(Nothing, Nothing)
                        'gdtMainData = dt
                    End If
                Else
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBCAPACITACIONBL.SelectAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'TSButtonRefresh_Click(Nothing, Nothing)
                        'gdtMainData = dt
                    End If
                End If

            Case "0802170000"
                If chkest.Checked = False Then
                    dt = VACUNABL.ListadoVacunados()
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                Else
                    dt = VACUNABL.ListadoNoVacunados()
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                End If


        End Select
        gdtMainData = dt

        recNo = 0
        tsbCamposSeek.Items.Clear()

        For Each col As DataGridViewColumn In dgvMain.Columns

            tsbCamposSeek.Items.Add(col.Name)
        Next
        'limpiar busqueda
        lblRecNo.Text = dgvMain.Rows.Count
    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged
        Dim dt As New DataTable
        dt = Nothing
        Dim sMes As String = mes(cmbmes.SelectedItem)
        Select Case gsMenuNodeId
            Case "0701010000"
                Cursor.Current = Cursors.WaitCursor
                dt = ELCUENTA_ARTBL.SelectAllOrden(cmbaño.SelectedItem, sMes, cmb_tipo.SelectedIndex)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
                'TSButtonRefresh_Click(Nothing, Nothing)
                If dgvMain.Rows.Count > 0 Then
                    'alinear numericos
                    For i = 0 To dgvMain.Rows.Count - 1 ' count++
                        If IIf(IsDBNull(dgvMain.Rows(i).Cells("U_ENT").Value), "", dgvMain.Rows(i).Cells("U_ENT").Value) <> "" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                        End If
                    Next
                End If
            Case "0803030000"
                Dim TIPO = ""
                If gsUser = "CHOYOS" Or gsUser = "SGARCIA" Then
                    TIPO = "21"
                End If
                If gsUser = "JFLORES" Then
                    TIPO = "20"
                End If
                Select Case cmb_tipo.SelectedIndex
                    Case 0
                        dt = PRESTAMOBL.BuscarListadoPrestamos(cmbaño.SelectedItem, "", TIPO)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    Case 1
                        dt = PRESTAMOBL.BuscarListadoPrestamos(cmbaño.SelectedItem, "P", TIPO)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    Case 2
                        dt = PRESTAMOBL.BuscarListadoPrestamos(cmbaño.SelectedItem, "C", TIPO)
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                End Select
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "PAGADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "PENDIENTE" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                        End If

                    Next
                End If
            Case "0204120000"
                Select Case cmb_tipo.SelectedIndex
                    Case 0
                        dt = BINDCARDBL.SelBindCard(cmbaño.SelectedItem, sMes, "")
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    Case 1
                        dt = BINDCARDBL.SelBindCard(cmbaño.SelectedItem, sMes, "A")
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    Case 2
                        dt = BINDCARDBL.SelBindCard(cmbaño.SelectedItem, sMes, "P")
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    Case 3
                        dt = BINDCARDBL.SelBindCard(cmbaño.SelectedItem, sMes, "G")
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                    Case 4
                        dt = BINDCARDBL.SelBindCard(cmbaño.SelectedItem, sMes, "X")
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                End Select
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "ATENDIDO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "GENERADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "PENDIENTE" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                        End If
                        If dgvMain.Rows(i).Cells("ESTADO").Value = "ANULADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If

            Case "0802020000"
                If cmb_tipo.SelectedIndex = 1 Then
                    If chkest.Checked Then
                        dt = PERBL.SelPerActivosTemp("21")
                        dgvMain.DataSource = dt
                    Else
                        dt = PERBL.SelPerAllActivosTemp("21")
                        dgvMain.DataSource = dt
                    End If
                ElseIf cmb_tipo.SelectedIndex = 2 Then
                    If chkest.Checked Then
                        dt = PERBL.SelPerActivosTemp("20")
                        dgvMain.DataSource = dt
                    Else
                        dt = PERBL.SelPerAllActivosTemp("20")
                        dgvMain.DataSource = dt

                    End If
                Else
                    If chkest.Checked Then
                        dt = PERBL.SelPerAllActivos
                        dgvMain.DataSource = dt
                    Else
                        dt = PERBL.SelPerAll
                        dgvMain.DataSource = dt
                    End If
                End If
            Case "0802100000"
                If cmb_tipo.SelectedIndex = 1 Then
                    dt = PERROTBL.SelPerAll("D")
                    dgvMain.DataSource = dt

                ElseIf cmb_tipo.SelectedIndex = 2 Then

                    dt = PERROTBL.SelPerAll("N")
                    dgvMain.DataSource = dt
                Else

                    dt = PERROTBL.SelPerAll("0")
                    dgvMain.DataSource = dt
                End If
        End Select
        gdtMainData = dt
        recNo = 0
        tsbCamposSeek.Items.Clear()
        If gsMenuNodeId = "0401020000" Then
            tsbCamposSeek.Items.Add("NRO")
            tsbCamposSeek.Items.Add("ARTICULO")
            tsbCamposSeek.Items.Add("CODIGO")
            'tsbCamposSeek.Items.Add("FEC_GENE")
            'tsbCamposSeek.Items.Add("ESTADO")
            lblRecNo.Text = dgvt2.Rows.Count
        ElseIf gsMenuNodeId = "0701010000" Then
            tsbCamposSeek.Items.Add("ACTIVO")
            tsbCamposSeek.Items.Add("C_COSTO")
            tsbCamposSeek.Items.Add("ARTICULO")
            tsbCamposSeek.Items.Add("F_GENERACION")
            tsbCamposSeek.Items.Add("TIPO_REQ")
            tsbCamposSeek.Items.Add("USUARIO")
            lblRecNo.Text = dgvMain.Rows.Count
        Else
            For Each col As DataGridViewColumn In dgvMain.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            lblRecNo.Text = dgvMain.Rows.Count

        End If

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        If cmb_tipo.SelectedIndex = 1 Then
            FormLimpiarDias.rdbempleados.Checked = True
            FormLimpiarDias.ShowDialog()
        ElseIf cmb_tipo.SelectedIndex = 2 Then
            FormLimpiarDias.rdbobreros.Checked = True
            FormLimpiarDias.ShowDialog()
        Else
            FormLimpiarDias.rdbtodo.Checked = True
            FormLimpiarDias.ShowDialog()
        End If


    End Sub

    'Private Sub dgvt2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvt2.CellContentClick
    '    Dim dt1 As DataTable
    '    Dim cod, des, serie, nro As String

    '    Dim i As Integer = 0
    '    Dim ii As Integer = 0

    '    Select Case UcAcMnu1.mnuId
    '        Case "0401020000"
    '            cod = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value
    '            des = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("ARTICULO").Value
    '            serie = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("SERIE").Value
    '            nro = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("NRO").Value

    '            lblarticulo.Text = cod + " - " + des

    '            'MOSTRARLO EN CERRAR EL PANTALLA
    '            dt1 = ELPRODUCCIONBL.SelectComponente(serie, nro, cod)
    '            dgvt3.DataSource = dt1
    '    End Select
    'End Sub
    Private Sub fnRecursiva(ByVal Key As String)
        Dim NN As Integer = 0
        Dim sTipo As String
        Dim dtDataTable As DataTable
        Dim dt5 As DataTable
        dt5 = ARTICULOBL.getListdgv5(Key)
        For Each row As DataRow In dt5.Rows
            dgvt3.Rows.Add(row("CODIGO"), row("NOM"), row("STOCK"), row("STOCK_MIN"))
        Next
        dtDataTable = ARTICULOBL.getListdgv1(Key)
        For Each row As DataRow In dtDataTable.Rows
            'sComponente = CStr(row("Componente"))
            If dgvt3.Rows.Count > 0 Then
                NN = 0
                For i = 0 To dgvt3.Rows.Count - 1
                    If Mid(row("CODIGO"), 1, 8) = dgvt3.Rows(i).Cells("CODIGO").Value Then
                        NN = NN + 1
                    End If
                Next
                If NN = 0 Then
                    fnRecursiva(Mid(row("CODIGO"), 1, 8))
                End If
            End If
        Next row

    End Sub

    Private Sub fnRecursivaIMP(ByVal Key As String, ByVal opcion As String)
        Dim NN As Integer = 0
        Dim sTipo As String
        Dim dtDataTable As DataTable
        Dim dt5 As DataTable
        dt5 = ARTICULOBL.getListdgv5(Key)
        If opcion = "1" Then
            If Mid(Key, 1, 4) = "0212" Or Mid(Key, 1, 4) = "0208" Then
                For Each row As DataRow In dt5.Rows
                    Try
                        dgvt3.Rows.Add(row("CODIGO"), row("NOM"), row("STOCK"), row("STOCK_MIN"))
                    Catch ex As Exception

                    End Try

                Next
            End If
            dtDataTable = ARTICULOBL.getListdgv1(Key)
            For Each row As DataRow In dtDataTable.Rows
                'sComponente = CStr(row("Componente"))
                If dgvt3.Rows.Count > 0 Then
                    NN = 0
                    For i = 0 To dgvt3.Rows.Count - 1
                        If Mid(row("CODIGO"), 1, 8) = dgvt3.Rows(i).Cells("CODIGO").Value Then
                            NN = NN + 1
                        End If
                    Next
                    If NN = 0 Then
                        fnRecursivaIMP(Mid(row("CODIGO"), 1, 8), opcion)
                    End If
                Else
                    'If Mid(row("CODIGO"), 1, 4) = "0212" Or Mid(row("CODIGO"), 1, 4) = "0208" Then
                    fnRecursivaIMP(Mid(row("CODIGO"), 1, 8), opcion)
                    'End If
                End If
            Next row
        ElseIf opcion = "2" Then
            If Mid(Key, 1, 2) = "03" Then
                For Each row As DataRow In dt5.Rows
                    dgvt3.Rows.Add(row("CODIGO"), row("NOM"), row("STOCK"), row("STOCK_MIN"))
                Next
            End If
            dtDataTable = ARTICULOBL.getListdgv1(Key)
            For Each row As DataRow In dtDataTable.Rows
                'sComponente = CStr(row("Componente"))
                If dgvt3.Rows.Count > 0 Then
                    NN = 0
                    For i = 0 To dgvt3.Rows.Count - 1
                        If Mid(row("CODIGO"), 1, 8) = dgvt3.Rows(i).Cells("CODIGO").Value Then
                            NN = NN + 1
                        End If
                    Next
                    If NN = 0 Then
                        fnRecursivaIMP(Mid(row("CODIGO"), 1, 8), opcion)
                    End If
                Else
                    'If Mid(row("CODIGO"), 1, 2) = "03" Then
                    fnRecursivaIMP(Mid(row("CODIGO"), 1, 8), opcion)
                    'End If
                End If
            Next row
        ElseIf opcion = "3" Then
            If Mid(Key, 1, 4) = "0211" Or Mid(Key, 1, 4) = "0204" Then
                For Each row As DataRow In dt5.Rows
                    dgvt3.Rows.Add(row("CODIGO"), row("NOM"), row("STOCK"), row("STOCK_MIN"))
                Next
            End If
            dtDataTable = ARTICULOBL.getListdgv1(Key)
            For Each row As DataRow In dtDataTable.Rows
                'sComponente = CStr(row("Componente"))
                If dgvt3.Rows.Count > 0 Then
                    NN = 0
                    For i = 0 To dgvt3.Rows.Count - 1
                        If Mid(row("CODIGO"), 1, 8) = dgvt3.Rows(i).Cells("CODIGO").Value Then
                            NN = NN + 1
                        End If
                    Next
                    If NN = 0 Then
                        fnRecursivaIMP(Mid(row("CODIGO"), 1, 8), opcion)
                    End If
                Else
                    'If Mid(row("CODIGO"), 1, 4) = "0211" Or Mid(row("CODIGO"), 1, 4) = "0204" Then
                    fnRecursivaIMP(Mid(row("CODIGO"), 1, 8), opcion)
                    'End If
                End If
            Next
        ElseIf opcion = "4" Then
            If Mid(Key, 1, 4) <> "0211" And Mid(Key, 1, 4) <> "0204" And
                Mid(Key, 1, 4) <> "0212" And Mid(Key, 1, 4) <> "0208" And Mid(Key, 1, 2) <> "03" Then
                For Each row As DataRow In dt5.Rows
                    dgvt3.Rows.Add(row("CODIGO"), row("NOM"), row("STOCK"), row("STOCK_MIN"))
                Next
            End If
            dtDataTable = ARTICULOBL.getListdgv1(Key)
            For Each row As DataRow In dtDataTable.Rows
                'sComponente = CStr(row("Componente"))
                If dgvt3.Rows.Count > 0 Then
                    NN = 0
                    For i = 0 To dgvt3.Rows.Count - 1
                        If Mid(row("CODIGO"), 1, 8) = dgvt3.Rows(i).Cells("CODIGO").Value Then
                            NN = NN + 1
                        End If
                    Next
                    If NN = 0 Then
                        fnRecursivaIMP(Mid(row("CODIGO"), 1, 8), opcion)
                    End If
                Else
                    'If Mid(row("CODIGO"), 1, 4) = "0211" Or Mid(row("CODIGO"), 1, 4) = "0204" Then
                    fnRecursivaIMP(Mid(row("CODIGO"), 1, 8), opcion)
                    'End If
                End If
            Next row
        ElseIf opcion = "5" Then
            'If Mid(Key, 1, 4) <> "0211" And Mid(Key, 1, 4) <> "0204" And
            '    Mid(Key, 1, 4) <> "0212" And Mid(Key, 1, 4) <> "0208" And Mid(Key, 1, 2) <> "03" Then
            For Each row As DataRow In dt5.Rows
                dgvt3.Rows.Add(row("CODIGO"), row("NOM"), row("STOCK"), row("STOCK_MIN"))
            Next
            'End If
            dtDataTable = ARTICULOBL.getListdgv1(Key)
            For Each row As DataRow In dtDataTable.Rows
                'sComponente = CStr(row("Componente"))
                If dgvt3.Rows.Count > 0 Then
                    NN = 0
                    For i = 0 To dgvt3.Rows.Count - 1
                        If Mid(row("CODIGO"), 1, 8) = dgvt3.Rows(i).Cells("CODIGO").Value Then
                            NN = NN + 1
                        End If
                    Next
                    If NN = 0 Then
                        fnRecursivaIMP(Mid(row("CODIGO"), 1, 8), opcion)
                    End If
                Else
                    'If Mid(row("CODIGO"), 1, 4) = "0211" Or Mid(row("CODIGO"), 1, 4) = "0204" Then
                    fnRecursivaIMP(Mid(row("CODIGO"), 1, 8), opcion)
                    'End If
                End If
            Next row
        End If

    End Sub
    Private Sub dgvt2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvt2.CellClick
        Dim dt1, dt2 As DataTable
        Dim cod, des, serie, nro As String

        Dim i As Integer = 0
        Dim ii As Integer = 0

        Select Case gsMenuNodeId
            Case "0401020000"
                cod = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value
                des = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("ARTICULO").Value
                serie = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("SERIE").Value
                nro = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("NRO").Value

                'lblarticulo.Text = cod + " - " + des
                lblcantidad.Text = 0
                'MOSTRARLO EN CERRAR EL PANTALLA
                'dt1 = ELPRODUCCIONBL.SelectComponente(serie, nro, cod)
                'dgvt3.DataSource = dt1
                Try
                    dgvt3.Rows.Clear()
                Catch ex As Exception

                End Try
                'fnRecursiva(cod)
                If chkimp.Checked Then
                    chkdgv(cod, "1")
                End If
                If chkpart.Checked Then
                    chkdgv(cod, "2")
                End If
                If chkbte.Checked Then
                    chkdgv(cod, "3")
                End If
                If chkotro.Checked Then
                    chkdgv(cod, "4")
                End If
                If chktod.Checked Then
                    chkdgv(cod, "5")
                End If
                'MOSTRAR ORDENES POR ARTICULO
                lvbusqueda.Items.Clear()
                Dim item As ListViewItem
                dt2 = ELPRODUCCIONBL.SelectArticuOrden(cod)
                For Each row As DataRow In dt2.Rows
                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("NRO")), "", row("NRO")))
                    item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE")))
                    item.SubItems.Add(IIf(IsDBNull(row("NOM_CTCT")), "", row("NOM_CTCT")))
                    item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                    item.SubItems.Add(IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")))
                    item.SubItems.Add(IIf(IsDBNull(row("T_DESPACHADO")), "", row("T_DESPACHADO")))
                    item.SubItems.Add(IIf(IsDBNull(row("SALDO_DESPACHAR")), "", row("SALDO_DESPACHAR")))
                    item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK")))
                    item.SubItems.Add(IIf(IsDBNull(row("ESTADO")), "", row("ESTADO")))
                Next
                Dim dt5 As DataTable
                dt5 = ELPRODUCCIONBL.SelectComponente(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("SERIE").Value,
                                                      dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("NRO").Value,
                                                      dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value)
                dgvt4.DataSource = dt5
        End Select
    End Sub

    Private Sub cmbalmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbalmacen.SelectedIndexChanged
        gsCodAlm = Mid(cmbalmacen.Text, 1, 4)
        Dim dt As New DataTable
        Select Case gsMenuNodeId
            Case "0203050000"
                If cmblinea.SelectedIndex <> -1 And cmbsublinea.SelectedIndex <> -1 Then
                    recNo = 0
                    tsbCamposSeek.Items.Clear()
                    'get columns of DGV
                    For Each col As DataGridViewColumn In dgvMain.Columns
                        ' MessageBox.Show(col.Name)
                        tsbCamposSeek.Items.Add(col.Name)
                    Next
                    'limpiar busqueda
                    dt = ARTICULOBL.SelectELTBARTSTOCKALL(cmbsublinea.SelectedValue.ToString, gsCodAlm)
                    dgvMain.DataSource = dt
                    dgvMain.Refresh()
                    lblRecNo.Text = dgvMain.Rows.Count
                    tsTextSearch.Text = ""
                    'Exit Sub
                End If
        End Select

    End Sub

    Private Sub btnlet_Click(sender As Object, e As EventArgs) Handles btnlet.Click
        Select Case gsMenuNodeId
            Case "0302070000"
                FormLetrasBanco.ShowDialog()
            Case "0503020000"
                Cursor.Current = Cursors.WaitCursor
                Dim dtArticulo As DataTable
                dtArticulo = PROVISIONESBL.getListProvDet(cmbaño.Text, mes(cmbmes.Text))
                dgvsegundo.DataSource = dtArticulo
                dgvsegundo.Refresh()
                Call GridAExcel_Compras(dgvsegundo)
            Case "0203050000"
                gsCode = "1"
                gsCode2 = cmbsublinea.Text
                gsCode3 = gsCodAlm
                Dim frm As New FormRptFecKardex
                frm.ShowDialog()
                gsCode = ""
                gsCode2 = ""
                gsCode3 = ""

                'Else
                '    MsgBox("No ah seleccionado ningun parametro de Linea o Sublinea", MsgBoxStyle.Exclamation)
                'End If
            Case "0401020000"
                If dgvt2.Rows.Count > 0 Then
                    gsCode = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value
                End If

                'dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value 'lblarticulo.Text.Substring(0, 8)
                Dim frm As New FormExplosionadoAll
                frm.ShowDialog()
                gsCode = ""
        End Select

    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Dim dt1, dt2 As DataTable
        Dim cont As Integer = 0
        Dim sum As Integer = 0
        Dim sum1 As Integer = 0
        Dim sum2 As Integer = 0
        Dim variable As String = ""
        gnOpcion = 0

        If lvbusqueda.Items.Count < 1 Then
            MsgBox("No a seleccionado ningun articulo", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        gsCode3 = "" : gsCode4 = "" : gsCode5 = "" : gsCode6 = "" : gsCode7 = "" : gsCode8 = "" : gsCode9 = "" : gsCode10 = "" : gsCode11 = ""

        For i = 0 To lvbusqueda.Items.Count - 1
            If lvbusqueda.Items(i).Checked = True Then
                gsCode = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value 'lblarticulo.Text.Substring(0, 8)                              'codigo
                gsCode2 = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("ARTICULO").Value 'gsCode2 = lblarticulo.Text.Substring(11, lblarticulo.Text.Length - 11) 'articulo
                gsCode3 = lvbusqueda.Items(i).SubItems(4).Text + "|" + gsCode3         'cantidad
                sum = sum + lvbusqueda.Items(i).SubItems(4).Text                       'cantidad
                gsCode5 = lvbusqueda.Items(i).SubItems(3).Text                         'fec_gene
                gsCode6 = lvbusqueda.Items(i).SubItems(1).Text + "|" + gsCode6         'serie
                gsCode7 = lvbusqueda.Items(i).SubItems(0).Text + "|" + gsCode7         'nro          
                gsCode8 = lvbusqueda.Items(i).SubItems(6).Text + "|" + gsCode8
                sum1 = sum1 + lvbusqueda.Items(i).SubItems(5).Text
                sum2 = sum2 + lvbusqueda.Items(i).SubItems(6).Text
                gsCode11 = lvbusqueda.Items(i).SubItems(5).Text + "|" + gsCode11
                cont = cont + 1

                dt1 = ELPRODUCCIONBL.SelectValidarRepetido(lvbusqueda.Items(i).SubItems(0).Text, dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value)
                If dt1.Rows.Count > 0 Then variable = lvbusqueda.Items(i).SubItems(0).Text

            End If
        Next
        gsCode9 = sum2
        gsCode10 = sum1
        'lblcantidad.Text = cont "Registros Seleccionados : " & 
        gsCode4 = sum

        If gsCode5 = "" And gsCode6 = "" And gsCode7 = "" Then
            MsgBox("No ha marcado nigun documento", MsgBoxStyle.Exclamation)
            Exit Sub
        Else

            If variable = "" Then
                chkmarcar.Checked = False
                ELPRODUCCION_VARIOS.ShowDialog()

                'Dim dt5 As DataTable
                ''dt5 = ELPRODUCCIONBL.SelectComponente(gsCode6, gsCode7, gsCode)
                'dt5 = ARTICULOBL.getListdgv5(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("ARTICULO").Value)
                'dgvt3.DataSource = dt5

                lvbusqueda.Items.Clear()
                Dim item As ListViewItem
                dt2 = ELPRODUCCIONBL.SelectArticuOrden(gsCode)

                For Each row As DataRow In dt2.Rows
                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("NRO")), "", row("NRO")))
                    item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE")))
                    item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                    item.SubItems.Add(IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")))
                    item.SubItems.Add(IIf(IsDBNull(row("T_DESPACHADO")), "", row("T_DESPACHADO")))
                    item.SubItems.Add(IIf(IsDBNull(row("SALDO_DESPACHAR")), "", row("SALDO_DESPACHAR")))
                    item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK")))
                Next
                Dim ins As String = dgvt2.CurrentRow.Index
                sNDoc = tsbCamposSeek.Text
                sCos = tsTextSearch.Text
                tsTextSearch.Text = ""
                TSButtonRefresh_Click(Nothing, Nothing)
                If tsbCamposSeek.Text.Length > 0 Then
                    tsbCamposSeek.Text = sNDoc
                    tsTextSearch.Text = sCos
                Else
                    Try
                        dgvt3.Rows.Clear()
                    Catch ex As Exception

                    End Try
                    lvbusqueda.Items.Clear()
                End If

                gsCode = ""
                gsCode2 = ""
                gsCode3 = ""
                gsCode5 = ""
                gsCode6 = ""
                gsCode7 = ""
                gsCode8 = ""
                gsCode11 = ""
                gsCode9 = ""
                gsCode10 = ""
                sCos = ""
                sNDoc = ""
            Else
                MsgBox("Ya existe la orden creada del numero " & variable, MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        End If
    End Sub

    Private Sub chkmarcar_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarcar.CheckedChanged
        Dim cont As Integer = 0
        If chkmarcar.Checked = True Then
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = False Then
                    lvbusqueda.Items(i).Checked = True
                    cont = i + 1
                End If
            Next
            'lblcantidad.Text = "Registros Seleccionados : " & cont
            lblcantidad.Text = cont
        Else
            For i = 0 To lvbusqueda.Items.Count - 1
                If lvbusqueda.Items(i).Checked = True Then
                    lvbusqueda.Items(i).Checked = False
                End If
            Next
            'lblcantidad.Text = "Registros Seleccionados : " & 0
            lblcantidad.Text = 0
        End If
    End Sub

    Private Sub lvbusqueda_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvbusqueda.ItemCheck
        If e.CurrentValue = False Then
            lblcantidad.Text += 1
        Else
            lblcantidad.Text -= 1
        End If
    End Sub

    Private Sub dgvt2_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvt2.KeyDown

        Dim dt1, dt2 As DataTable
        Dim cod, des, serie, nro As String
        Dim i As Integer = 0
        Dim ii As Integer = 0
        Select Case gsMenuNodeId
            Case "0401020000"
                If e.KeyCode = Keys.Up Then
                    If (dgvt2.CurrentRow.Index - 1 = -1) Then
                        cod = dgvt2.Rows(0).Cells("CODIGO").Value
                        des = dgvt2.Rows(0).Cells("ARTICULO").Value
                        serie = dgvt2.Rows(0).Cells("SERIE").Value
                        nro = dgvt2.Rows(0).Cells("NRO").Value
                    Else
                        cod = dgvt2.Rows(dgvt2.CurrentRow.Index - 1).Cells("CODIGO").Value
                        des = dgvt2.Rows(dgvt2.CurrentRow.Index - 1).Cells("ARTICULO").Value
                        serie = dgvt2.Rows(dgvt2.CurrentRow.Index - 1).Cells("SERIE").Value
                        nro = dgvt2.Rows(dgvt2.CurrentRow.Index - 1).Cells("NRO").Value
                    End If
                End If

                If e.KeyCode = Keys.Down Then
                    Dim leng As Integer = dgvt2.Rows.Count
                    If (dgvt2.CurrentRow.Index + 1 = leng) Then
                        cod = dgvt2.Rows(leng - 1).Cells("CODIGO").Value
                        des = dgvt2.Rows(leng - 1).Cells("ARTICULO").Value
                        serie = dgvt2.Rows(leng - 1).Cells("SERIE").Value
                        nro = dgvt2.Rows(leng - 1).Cells("NRO").Value
                    Else
                        cod = dgvt2.Rows(dgvt2.CurrentRow.Index + 1).Cells("CODIGO").Value
                        des = dgvt2.Rows(dgvt2.CurrentRow.Index + 1).Cells("ARTICULO").Value
                        serie = dgvt2.Rows(dgvt2.CurrentRow.Index + 1).Cells("SERIE").Value
                        nro = dgvt2.Rows(dgvt2.CurrentRow.Index + 1).Cells("NRO").Value
                    End If
                End If

                'lblarticulo.Text = cod + " - " + des

                'MOSTRARLO EN CERRAR EL PANTALLA
                'dt1 = ELPRODUCCIONBL.SelectComponente(serie, nro, cod)
                dt1 = ARTICULOBL.getListdgv5(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("ARTICULO").Value)
                dgvt3.DataSource = dt1

                'MOSTRAR ORDENES POR ARTICULO
                lvbusqueda.Items.Clear()
                Dim item As ListViewItem
                dt2 = ELPRODUCCIONBL.SelectArticuOrden(cod)

                For Each row As DataRow In dt2.Rows
                    item = lvbusqueda.Items.Add(IIf(IsDBNull(row("NRO")), "", row("NRO")))
                    item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE")))
                    item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
                    item.SubItems.Add(IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")))
                    item.SubItems.Add(IIf(IsDBNull(row("T_DESPACHADO")), "", row("T_DESPACHADO")))
                    item.SubItems.Add(IIf(IsDBNull(row("SALDO_DESPACHAR")), "", row("SALDO_DESPACHAR")))
                    item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK")))
                    item.SubItems.Add(IIf(IsDBNull(row("ESTADO")), "", row("ESTADO")))
                Next
        End Select
        'If e.KeyValue = Keys.Down Or e.KeyValue = Keys.Up Then
        '    Dim dt1, dt2 As DataTable
        '    Dim cod, des, serie, nro As String

        '    Dim i As Integer = 0
        '    Dim ii As Integer = 0

        '    Select Case UcAcMnu1.mnuId
        '        Case "0401020000"
        '            cod = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value
        '            des = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("ARTICULO").Value
        '            serie = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("SERIE").Value
        '            nro = dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("NRO").Value

        '            'lblarticulo.Text = cod + " - " + des
        '            lblcantidad.Text = 0
        '            'MOSTRARLO EN CERRAR EL PANTALLA
        '            dt1 = ELPRODUCCIONBL.SelectComponente(serie, nro, cod)
        '            dgvt3.DataSource = dt1

        '            'MOSTRAR ORDENES POR ARTICULO
        '            lvbusqueda.Items.Clear()
        '            Dim item As ListViewItem
        '            dt2 = ELPRODUCCIONBL.SelectArticuOrden(cod)

        '            For Each row As DataRow In dt2.Rows
        '                item = lvbusqueda.Items.Add(IIf(IsDBNull(row("NRO")), "", row("NRO")))
        '                item.SubItems.Add(IIf(IsDBNull(row("SERIE")), "", row("SERIE")))
        '                item.SubItems.Add(IIf(IsDBNull(row("FEC_GENE")), "", row("FEC_GENE")))
        '                item.SubItems.Add(IIf(IsDBNull(row("CANTIDAD")), "", row("CANTIDAD")))
        '                item.SubItems.Add(IIf(IsDBNull(row("T_DESPACHADO")), "", row("T_DESPACHADO")))
        '                item.SubItems.Add(IIf(IsDBNull(row("SALDO_DESPACHAR")), "", row("SALDO_DESPACHAR")))
        '                item.SubItems.Add(IIf(IsDBNull(row("STOCK")), "", row("STOCK")))
        '                item.SubItems.Add(IIf(IsDBNull(row("ESTADO")), "", row("ESTADO")))
        '            Next
        '            'lblcantidad.Text = lvbusqueda.Items.Count
        '    End Select
        'End If

    End Sub

    'Private Sub dgvt3_DoubleClick(sender As Object, e As EventArgs) Handles dgvt3.DoubleClick
    '    gnOpcion = 1
    '    sTDoc = dgvt3.Rows(dgvt3.CurrentRow.Index).Cells("NRO_REF").Value
    '    sSDoc = dgvt3.Rows(dgvt3.CurrentRow.Index).Cells("COD_ART").Value
    '    sNDoc = dgvt3.Rows(dgvt3.CurrentRow.Index).Cells("NRO").Value
    '    ELPRODUCCION_VARIOS.ShowDialog()
    'End Sub

    Private Sub rdbapr4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbapr4.CheckedChanged
        If rdbapr4.Checked = True Then
            Dim dt As New DataTable
            Do While dgvMain.Columns.Count > 0
                dgvMain.Columns.RemoveAt(dgvMain.Columns.Count - 1)
            Loop
            Dim sMes As String = mes(cmbmes.SelectedItem)
            dgvMain.Refresh()
            Select Case gsMenuNodeId
                Case "0401040000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBSTIEMBL.SelectAll(cmbaño.SelectedItem, sMes)
                        sOp = "4"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                    End If

                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                Case "0401060000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = PRODUCCIONBL.ListadoBonoProduccion(cmbaño.SelectedItem, sMes)
                        sOp = "4"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                    End If

                    'For i = 0 To dgvMain.Rows.Count - 1  ' count++
                    '    If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                    '        dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    '    End If
                    'Next
                Case "0703040000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = REPORTE_TRABAJOBL.SelectAll(cmbaño.SelectedItem, sMes, gsCodUsr)
                        sOp = "4"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                    End If

                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
            End Select
        End If
    End Sub

    Private Sub rdbapr1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbapr1.CheckedChanged
        If rdbapr1.Checked = True Then
            Dim dt As New DataTable
            Dim sMes As String = mes(cmbmes.SelectedItem)
            Do While dgvMain.Columns.Count > 0
                dgvMain.Columns.RemoveAt(dgvMain.Columns.Count - 1)
            Loop

            Select Case gsMenuNodeId
                Case "0401040000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then

                        dt = ELTBSTIEMBL.SelectAllHEJ(cmbaño.SelectedItem, sMes)
                        sOp = "1"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                        If dgvMain.Rows.Count > 0 Then
                            Dim btn As New DataGridViewButtonColumn
                            If dgvMain.Columns(0).Name = "btnAprobar" Then
                            Else
                                btn.HeaderText = "Aprobar"
                                btn.Text = "Aprobar"
                                btn.Name = "btnAprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                                dgvMain.Columns.Insert(0, btn)
                                btn = New DataGridViewButtonColumn
                                btn.HeaderText = "Desaprobar"
                                btn.Text = "Desaprobar"
                                btn.Name = "btnDesaprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                                dgvMain.Columns.Insert(1, btn)
                            End If
                        End If

                    End If
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                Case "0401060000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then

                        dt = PRODUCCIONBL.SelectAllBPJefe(cmbaño.SelectedItem, sMes)
                        sOp = "1"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                        If dgvMain.Rows.Count > 0 Then
                            Dim btn As New DataGridViewButtonColumn
                            If dgvMain.Columns(0).Name = "btnAprobar" Then
                            Else
                                btn.HeaderText = "Aprobar"
                                btn.Text = "Aprobar"
                                btn.Name = "btnAprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                                dgvMain.Columns.Insert(0, btn)
                                btn = New DataGridViewButtonColumn
                                btn.HeaderText = "Desaprobar"
                                btn.Text = "Desaprobar"
                                btn.Name = "btnDesaprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                                dgvMain.Columns.Insert(1, btn)
                            End If
                        End If
                    End If

                Case "0703040000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = REPORTE_TRABAJOBL.SelectAllHEJ(cmbaño.SelectedItem, sMes, gsCodUsr)
                        sOp = "1"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                        If dgvMain.Rows.Count > 0 Then
                            Dim btn As New DataGridViewButtonColumn
                            If dgvMain.Columns(0).Name = "btnAprobar" Then
                            Else
                                btn.HeaderText = "Aprobar"
                                btn.Text = "Aprobar"
                                btn.Name = "btnAprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                                dgvMain.Columns.Insert(0, btn)
                                btn = New DataGridViewButtonColumn
                                btn.HeaderText = "Desaprobar"
                                btn.Text = "Desaprobar"
                                btn.Name = "btnDesaprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                                dgvMain.Columns.Insert(1, btn)
                            End If
                        End If

                    End If
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
            End Select
        End If
    End Sub

    Private Sub rdbapr2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbapr2.CheckedChanged
        If rdbapr2.Checked = True Then
            Dim dt As New DataTable
            Dim sMes As String = mes(cmbmes.SelectedItem)
            Do While dgvMain.Columns.Count > 0
                dgvMain.Columns.RemoveAt(dgvMain.Columns.Count - 1)
            Loop
            Select Case gsMenuNodeId
                Case "0401040000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBSTIEMBL.SelectAllHEJP(cmbaño.SelectedItem, sMes)
                        sOp = "2"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                        If dgvMain.Rows.Count > 0 Then
                            Dim btn As New DataGridViewButtonColumn
                            If dgvMain.Columns(0).Name = "btnAprobar" Then
                            Else
                                btn.HeaderText = "Aprobar"
                                btn.Text = "Aprobar"
                                btn.Name = "btnAprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                                dgvMain.Columns.Insert(0, btn)
                                btn = New DataGridViewButtonColumn
                                btn.HeaderText = "Desaprobar"
                                btn.Text = "Desaprobar"
                                btn.Name = "btnDesaprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                                dgvMain.Columns.Insert(1, btn)
                            End If
                        End If
                    End If
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                Case "0401060000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = PRODUCCIONBL.SelectAllBPPlanta(cmbaño.SelectedItem, sMes)
                        sOp = "2"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                        If dgvMain.Rows.Count > 0 Then
                            Dim btn As New DataGridViewButtonColumn
                            If dgvMain.Columns(0).Name = "btnAprobar" Then
                            Else
                                btn.HeaderText = "Aprobar"
                                btn.Text = "Aprobar"
                                btn.Name = "btnAprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                                dgvMain.Columns.Insert(0, btn)
                                btn = New DataGridViewButtonColumn
                                btn.HeaderText = "Desaprobar"
                                btn.Text = "Desaprobar"
                                btn.Name = "btnDesaprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                                dgvMain.Columns.Insert(1, btn)
                            End If
                        End If
                    End If

                Case "0703040000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = REPORTE_TRABAJOBL.SelectAllHEJP(cmbaño.SelectedItem, sMes)
                        sOp = "2"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                        If dgvMain.Rows.Count > 0 Then
                            Dim btn As New DataGridViewButtonColumn
                            If dgvMain.Columns(0).Name = "btnAprobar" Then
                            Else
                                btn.HeaderText = "Aprobar"
                                btn.Text = "Aprobar"
                                btn.Name = "btnAprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                                dgvMain.Columns.Insert(0, btn)
                                btn = New DataGridViewButtonColumn
                                btn.HeaderText = "Desaprobar"
                                btn.Text = "Desaprobar"
                                btn.Name = "btnDesaprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                                dgvMain.Columns.Insert(1, btn)
                            End If
                        End If
                    End If
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
            End Select
        End If
    End Sub

    Private Sub rdbapr3_CheckedChanged(sender As Object, e As EventArgs) Handles rdbapr3.CheckedChanged
        If rdbapr3.Checked = True Then
            Dim dt As New DataTable
            Dim sMes As String = mes(cmbmes.SelectedItem)
            Do While dgvMain.Columns.Count > 0
                dgvMain.Columns.RemoveAt(dgvMain.Columns.Count - 1)
            Loop
            Select Case gsMenuNodeId
                Case "0401040000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = ELTBSTIEMBL.SelectAllHERH(cmbaño.SelectedItem, sMes)
                        sOp = "3"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                        If dgvMain.Rows.Count > 0 Then
                            Dim btn As New DataGridViewButtonColumn
                            If dgvMain.Columns(0).Name = "btnProcesar" Then
                            Else
                                btn.HeaderText = "Procesar"
                                btn.Text = "Procesar"
                                btn.Name = "btnProcesar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                                dgvMain.Columns.Insert(0, btn)
                                btn = New DataGridViewButtonColumn
                                btn.HeaderText = "Desaprobar"
                                btn.Text = "Desaprobar"
                                btn.Name = "btnDesaprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                                dgvMain.Columns.Insert(1, btn)
                            End If
                        End If
                        For i = 0 To dgvMain.Rows.Count - 1  ' count++
                            If dgvMain.Rows(i).Cells("X").Value.ToString.Length > 0 Then
                                dgvMain.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                            End If
                        Next
                    End If
                Case "0401060000"
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = PRODUCCIONBL.SelectAllBPrrhh(cmbaño.SelectedItem, sMes)
                        sOp = "3"
                        dgvMain.DataSource = dt
                        dgvMain.Refresh()
                        'gHeader(dgvMain)
                        If dgvMain.Rows.Count > 0 Then
                            Dim btn As New DataGridViewButtonColumn
                            If dgvMain.Columns(0).Name = "btnProcesar" Then
                            Else
                                btn.HeaderText = "Procesar"
                                btn.Text = "Procesar"
                                btn.Name = "btnProcesar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(126, 197, 84)  'GREEN
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(126, 197, 84)
                                dgvMain.Columns.Insert(0, btn)
                                btn = New DataGridViewButtonColumn
                                btn.HeaderText = "Desaprobar"
                                btn.Text = "Desaprobar"
                                btn.Name = "btnDesaprobar"
                                btn.Frozen = True
                                btn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(246, 64, 54)  ' RED
                                btn.FlatStyle = FlatStyle.Flat
                                btn.UseColumnTextForButtonValue = True
                                btn.CellTemplate.Style.BackColor = Color.FromArgb(246, 64, 54)
                                dgvMain.Columns.Insert(1, btn)
                            End If
                        End If
                    End If
            End Select
        End If
    End Sub

    Private Sub chkdocexp_CheckedChanged(sender As Object, e As EventArgs) Handles chkdocexp.CheckedChanged
        Dim dt As New DataTable
        Dim sMes As String = mes(cmbmes.SelectedItem)
        dt = Nothing
        Select Case gsMenuNodeId
            Case "0502150000"
                ' Dim dt As New DataTable
                If chkdocexp.Checked Then
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = PROVISIONESBL.SelectExpAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        If dgvMain.Rows.Count > 0 Then
                            dgvMain.Columns(5).Visible = False
                        End If
                        dgvMain.Refresh()
                    End If
                Else
                    If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                        dt = PROVISIONESBL.SelectProvAll(cmbaño.SelectedItem, sMes)
                        dgvMain.DataSource = dt
                        If dgvMain.Rows.Count > 0 Then
                            dgvMain.Columns(5).Visible = False
                        End If
                        dgvMain.Refresh()
                    End If
                End If
        End Select
        gdtMainData = dt
        recNo = 0
        tsbCamposSeek.Items.Clear()
        For Each col As DataGridViewColumn In dgvMain.Columns
            tsbCamposSeek.Items.Add(col.Name)
        Next
        'limpiar busqueda
        lblRecNo.Text = dgvMain.Rows.Count
    End Sub

    Private Sub cmbtipsunat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipsunat.SelectedIndexChanged
        Dim dt As New DataTable
        Dim sMes As String = mes(cmbmes.SelectedItem)
        If cmbtipsunat.Text = "SUNAT" Then
            If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                dt = ELTBTIPOCAMBIOBL.SelectAll(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            End If
        Else
            If cmbaño.SelectedIndex <> -1 And cmbmes.SelectedIndex <> -1 Then
                dt = ELTBTIPOCAMBIOBL.SelectAll1(cmbaño.SelectedItem, sMes)
                dgvMain.DataSource = dt
                dgvMain.Refresh()
            End If
        End If
    End Sub

    Private Sub chkimp_CheckedChanged(sender As Object, e As EventArgs) Handles chkimp.CheckedChanged
        Dim c As Integer = 0
        If dgvt3.Rows.Count > 0 Then
            If chkimp.Checked Then
                chktod.Checked = False
            End If
            If chkimp.Checked = True Then
                Select Case gsMenuNodeId
                    Case "0401020000"
                        chkdgv(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, "1")
                End Select
            Else
                For i = 0 To dgvt3.Rows.Count - 1
                    If Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) = "0212" Or
                        Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) = "0208" Then
                        dgvt3.Rows.RemoveAt(i - c)
                        c = c + 1
                    End If
                Next
            End If
        Else
            If chkimp.Checked = True Then
                Select Case gsMenuNodeId
                    Case "0401020000"
                        chkdgv(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, "1")
                End Select
            End If
        End If

    End Sub
    Private Sub chkpart_CheckedChanged(sender As Object, e As EventArgs) Handles chkpart.CheckedChanged
        Dim c As Integer = 0
        If dgvt3.Rows.Count > 0 Then
            If chkpart.Checked Then
                chktod.Checked = False
            End If
            If chkpart.Checked = True Then
                Select Case gsMenuNodeId
                    Case "0401020000"
                        chkdgv(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, "2")
                End Select
            Else
                For i = 0 To dgvt3.Rows.Count - 1
                    If Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 2) = "03" Then
                        dgvt3.Rows.RemoveAt(i - c)
                        c = c + 1
                    End If
                Next
            End If
        Else
            If chkpart.Checked = True Then
                Select Case gsMenuNodeId
                    Case "0401020000"
                        chkdgv(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, "2")
                End Select
            End If
        End If

    End Sub

    Private Sub chkbte_CheckedChanged(sender As Object, e As EventArgs) Handles chkbte.CheckedChanged
        Dim c As Integer = 0
        If dgvt3.Rows.Count > 0 Then
            If chkbte.Checked Then
                chktod.Checked = False
            End If
            If chkbte.Checked = True Then
                Select Case gsMenuNodeId
                    Case "0401020000"
                        chkdgv(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, "3")
                End Select
            Else
                For i = 0 To dgvt3.Rows.Count - 1
                    If Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) = "0211" Or
                        Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) = "0204" Then
                        dgvt3.Rows.RemoveAt(i - c)
                        c = c + 1
                    End If
                Next
            End If
        Else
            If chkbte.Checked = True Then
                Select Case gsMenuNodeId
                    Case "0401020000"
                        chkdgv(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, "3")
                End Select
            End If
        End If
    End Sub

    Private Sub chkotro_CheckedChanged(sender As Object, e As EventArgs) Handles chkotro.CheckedChanged
        Dim c As Integer = 0
        If dgvt3.Rows.Count > 0 Then
            If chkotro.Checked Then
                chktod.Checked = False
            End If
            If chkotro.Checked = True Then
                Select Case gsMenuNodeId
                    Case "0401020000"
                        chkdgv(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, "4")
                End Select
            Else
                For i = 0 To dgvt3.Rows.Count - 1
                    If Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) <> "0211" And
                        Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) <> "0204" And
                        Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) <> "0212" And
                        Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) <> "0208" Then
                        dgvt3.Rows.RemoveAt(i - c)
                        c = c + 1
                    End If
                Next
            End If
        Else
            If chkotro.Checked = True Then
                Select Case gsMenuNodeId
                    Case "0401020000"
                        chkdgv(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, "4")
                End Select
            End If
        End If

    End Sub
    Private Sub chktod_CheckedChanged(sender As Object, e As EventArgs) Handles chktod.CheckedChanged
        Dim c As Integer = 0
        If chktod.Checked Then
            chkimp.Checked = False
            chkpart.Checked = False
            chkotro.Checked = False
            chkbte.Checked = False

        End If
        If dgvt3.Rows.Count > 0 Then
            If chktod.Checked = True Then
                Select Case gsMenuNodeId
                    Case "0401020000"
                        chkdgv(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, "5")
                End Select
            Else
                For i = 0 To dgvt3.Rows.Count - 1
                    'If Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) <> "0211" And
                    '    Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) <> "0204" And
                    '    Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) <> "0212" And
                    '    Mid(dgvt3.Rows(i - c).Cells("CODIGO").Value, 1, 4) <> "0208" Then
                    dgvt3.Rows.RemoveAt(i - c)
                    c = c + 1
                    'End If
                Next
            End If
        Else
            If chktod.Checked = True Then
                Select Case gsMenuNodeId
                    Case "0401020000"
                        chkdgv(dgvt2.Rows(dgvt2.CurrentRow.Index).Cells("CODIGO").Value, "5")
                End Select
            End If
        End If
    End Sub
    Private Sub chkdgv(ByVal cod As String, ByVal opcion As String)
        Dim BindingSource As New BindingSource
        Select Case gsMenuNodeId
            Case "0401020000"
                fnRecursivaIMP(cod, opcion)
        End Select
    End Sub

    Private Sub btnsinot_Click(sender As Object, e As EventArgs) Handles btnsinot.Click
        Dim frm As New ELPRODUCCION_VARIOS
        gsCode7 = ""
        sOp = "1"
        frm.ShowDialog()
        sOp = ""
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub dgvMain_Sorted(sender As Object, e As EventArgs) Handles dgvMain.Sorted
        Select Case gsMenuNodeId
            Case "0203040000"
                If dgvMain.Rows.Count > 0 Then
                    'alinear numericos
                    For i = 0 To dgvMain.Rows.Count - 1 ' count++
                        If IIf(IsDBNull(dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value), "", dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value) = "ANULADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        ElseIf IIf(IsDBNull(dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value), "", dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value) = "APROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                        ElseIf IIf(IsDBNull(dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value), "", dgvMain.Rows(i).Cells("ESTADO_ATENCION").Value) = "PENDIENTE" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.DarkOrange
                        End If
                    Next
                End If
            Case "0401010100"
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "0401010200"
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "0401010300"
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "0401040000"
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
            Case "0703040000"
                If dgvMain.Rows.Count > 0 Then
                    For i = 0 To dgvMain.Rows.Count - 1  ' count++
                        If dgvMain.Rows(i).Cells("EST").Value = "DESAPROBADO" Then
                            dgvMain.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                        End If
                    Next
                End If
        End Select
    End Sub

    Private Sub radPag_CheckedChanged(sender As Object, e As EventArgs) Handles radPag.CheckedChanged
        If radSol.Checked = True Or radDol.Checked = True Then
            Dim dtPagos As New DataTable
            sMes = mes(sMes)
            Dim ope
            Dim mon
            If radPag.Checked = True Then
                ope = "010"
            Else
                ope = "013"
            End If

            If radSol.Checked = True Then
                mon = "00"
            Else
                mon = "01"
            End If
            tipOpe = ope
            tipMon = mon
            estadoTC = 0
            dtPagos = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, ope, mon)
            dgvMain.DataSource = dtPagos
            gdtMainData = dtPagos
            dgvMain.Refresh()
        End If
    End Sub

    Private Sub radCob_CheckedChanged(sender As Object, e As EventArgs) Handles radCob.CheckedChanged
        If radSol.Checked = True Or radDol.Checked = True Then


            Dim dtPagos As New DataTable
            sMes = mes(sMes)
            Dim ope
            Dim mon
            If radCob.Checked = True Then
                ope = "013"
            Else
                ope = "010"
            End If

            If radSol.Checked = True Then
                mon = "00"
            Else
                mon = "01"
            End If
            estadoTC = 0
            tipOpe = ope
            tipMon = mon
            dtPagos = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, ope, mon)
            dgvMain.DataSource = dtPagos
            gdtMainData = dtPagos
            dgvMain.Refresh()
        End If
    End Sub

    Private Sub radSol_CheckedChanged(sender As Object, e As EventArgs) Handles radSol.CheckedChanged
        Dim dtPagos As New DataTable
        sMes = mes(sMes)
        Dim ope
        Dim mon

        If radSol.Checked = True Then
            mon = "00"
        Else
            mon = "01"
        End If

        If radPag.Checked = True Then
            ope = "010"
        Else
            ope = "013"
        End If

        estadoTC = 0
        tipOpe = ope
        tipMon = mon
        dtPagos = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, ope, mon)
        dgvMain.DataSource = dtPagos
        gdtMainData = dtPagos
        dgvMain.Refresh()
    End Sub

    Private Sub radDol_CheckedChanged(sender As Object, e As EventArgs) Handles radDol.CheckedChanged
        Dim dtPagos As New DataTable
        sMes = mes(sMes)
        Dim ope
        Dim mon

        If radDol.Checked = True Then
            mon = "01"
        Else
            mon = "00"
        End If

        If radPag.Checked = True Then
            ope = "010"
        Else
            ope = "013"
        End If

        estadoTC = 0
        tipOpe = ope
        tipMon = mon
        dtPagos = ELPAGO_DOCUMENTOBL.SelectAll(cmbaño.SelectedItem, sMes, ope, mon)
        dgvMain.DataSource = dtPagos
        gdtMainData = dtPagos
        dgvMain.Refresh()
    End Sub

    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click
        FormGenerarFiltro.Show()
    End Sub

    Private Sub cmbTipoCred_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoCred.SelectedIndexChanged
        If Not bChange Then Exit Sub

        Dim tipo As String = ""
        Select Case cmbTipoCred.SelectedIndex
            Case 0
                tipo = "LE"
            Case 1
                tipo = "RE"
            Case 2
                tipo = "FE"
            Case 3
                tipo = "CF"
        End Select
        Dim DT As New DataTable
        DT = CONTABILIDADBL.ListadoCreditos(cmbaño.SelectedItem, tipo)
        dgvMain.DataSource = DT
        dgvMain.Refresh()

        gdtMainData = DT
        ' End If
        ''''  gdtMainData = dt


        'PAGINACION 
        'pageSize = tstcmbPageSize.ComboBox.SelectedItem
        'maxRec = dtSource.Rows.Count
        'PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        'If (maxRec Mod pageSize) > 0 Then
        '    PageCount = PageCount + 1
        'End If

        'Initial seeings
        'currentPage = 1
        recNo = 0
        tsbCamposSeek.Items.Clear()
        'MsgBox(tsbCamposSeek.Items.Count)
        'get columns of DGV
        If gsMenuNodeId = "0401020000" Then
            tsbCamposSeek.Items.Add("NRO")
            tsbCamposSeek.Items.Add("CODIGO")
            tsbCamposSeek.Items.Add("ARTICULO")
            tsbCamposSeek.Items.Add("RUC")
            tsbCamposSeek.Items.Add("RAZ_SOCIAL")
            tsbCamposSeek.Items.Add("FEC_GENE")
            tsbCamposSeek.Items.Add("ESTADO")
            lblRecNo.Text = dgvt2.Rows.Count
        ElseIf gsMenuNodeId = "0701010000" Then
            tsbCamposSeek.Items.Add("ACTIVO")
            tsbCamposSeek.Items.Add("C_COSTO")
            tsbCamposSeek.Items.Add("ARTICULO")
            tsbCamposSeek.Items.Add("F_GENERACION")
            tsbCamposSeek.Items.Add("TIPO_REQ")
            tsbCamposSeek.Items.Add("USUARIO")
            lblRecNo.Text = dgvMain.Rows.Count
        Else
            For Each col As DataGridViewColumn In dgvMain.Columns
                tsbCamposSeek.Items.Add(col.Name)
            Next
            lblRecNo.Text = dgvMain.Rows.Count
        End If
        'limpiar busqueda
        lblRecNo.Text = dgvMain.Rows.Count


    End Sub


    'Private Sub BtnActProcesos_Click(sender As Object, e As EventArgs) Handles BtnActProcesos.Click

    'End Sub
End Class