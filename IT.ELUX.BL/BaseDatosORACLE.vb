﻿
'Imports Oracle.DataAccess.Client
Imports Oracle.ManagedDataAccess.Client

'Imports System.Data.OracleClient

Imports System.Data
Imports System.Data.Common
Imports System.Configuration
Imports System.Configuration.ConfigurationSettings
'Imports System.Data.ora
'Imports System.Data.OracleClient
'Imports Oracle.ManagedDataAccess.Client
Imports System.Reflection
Imports System.Xml


Public MustInherit Class BaseDatosORACLE


#Region "Variables Constantes"
    Protected cnConexion As Oracle.ManagedDataAccess.Client.OracleConnection = Nothing          'Almacena el objeto Conexión.
    Private fechaExpiracion As String = "31/12/2013"  'Fecha en que deja de funcionar la conexion
    Private strCadenaDeConexion As String 'Cadena de conexion a la base de datos
    Private Servidor As String = String.Empty
    Shared mColComandos As New System.Collections.Hashtable() 'Coleccion de procedimientos almacenados
#End Region

#Region "Configuracion"


    Public Shared gsSQLsource As String
    Public Shared gsSHAREDDBEmpresa As String

    Private mCgrConnString As String                            'Almacena la cadena de Conexión
    Private Property CgrConnString() As String
        Get
            Return Me.ObtenerConnString()
        End Get
        Set(ByVal value As String)
            mCgrConnString = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la cadena de conexión desde el archivo de configuración.
    ''' </summary>
    Private Function ObtenerConnString() As String

        Dim cgrConnString As String = "cgrConnStrings"
        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings(cgrConnString)
        'Dim clock As String = System.Configuration.ConfigurationSettings.AppSettings("clock")

        gsSQLsource = "(Remote)"
        If InStr(settings.ToString, "(local)", CompareMethod.Text) <> 0 Then
            gsSQLsource = "(local)"
        End If



        If Not settings Is Nothing Then
            Return settings.ConnectionString
        Else
            Return "connectionString: (" & cgrConnString & ") Configuracion Fallida"
        End If

    End Function

#End Region

#Region "Metodos de Conexion a la BD"

    ''' <summary>
    ''' Se concecta con la base de datos.
    ''' </summary>
    ''' <exception  cref="BaseDatosException">Si existe un error al conectarse.</exception> 
    Protected Function ConnectionBegin() As Oracle.ManagedDataAccess.Client.OracleConnection

        If Not Me.cnConexion Is Nothing Then
            If Me.cnConexion.State.Equals(ConnectionState.Closed) Then
                Me.cnConexion.Open()
            End If
        End If

        Try
            If Me.cnConexion Is Nothing Then
                Me.cnConexion = New Oracle.ManagedDataAccess.Client.OracleConnection
                Me.cnConexion.ConnectionString = Me.CgrConnString
                Me.cnConexion.Open()
            End If
        Catch ex As DataException
            Throw New BaseDatosException("Error al conectarse.")
        End Try

        Return cnConexion

    End Function

    ''' <summary>
    ''' Permite desconectarse de la base de datos.
    ''' </summary>
    Protected Sub ConnectionDispose()
        If Me.cnConexion.State.Equals(ConnectionState.Open) Then
            Me.cnConexion.Dispose()
            Me.cnConexion = Nothing
        End If
    End Sub

#End Region

#Region "Metodos para leer Datos"

    ''' <summary>
    ''' Metodo utilizado para la lectura de datos. Devuelve un objeto DataReader.
    ''' </summary>
    ''' <param name="storeProcedure">Nombre del StoreProcedure a procesar.</param>
    ''' <param name="parameters">Objeto el cual posee los parámetros definidos del storeprocedure a ejecutar.</param>
    Protected Function GetDataReader(ByVal storeProcedure As String,
                                     ByVal parameters As IDataParameter()) As OracleDataReader

        Dim cn As New OracleConnection
        Dim dr As OracleDataReader = Nothing

        Try
            cn = ConnectionBegin()
            Dim cmd As OracleCommand = BuildQueryCommand(storeProcedure, parameters)
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = storeProcedure


            'cm.Parameters.Add(New OracleParameter("code", OracleType.VarChar)).Value = "00xx"
            'cm.Parameters.Add(New OracleParameter("descri", OracleType.VarChar)).Value = "prueba"


            '   Dim oparam0 As New OracleParameter

            'oparam0 = cmd.Parameters.Add("descriXXXXXX", OracleDbType.Varchar2)
            'oparam0.Value = "ALMACEN1"
            'oparam0.Direction = ParameterDirection.Input

            'oparam0 = cmd.Parameters.Add("passwdXXXXXX", OracleDbType.Varchar2)
            'oparam0.Value = "1234"
            'oparam0.Direction = ParameterDirection.Input

            Dim oparam1 As OracleParameter = cmd.Parameters.Add("gridOUT", OracleDbType.RefCursor)
            oparam1.Direction = ParameterDirection.Output



            'Dim oparam0 As OracleParameter = cmd.Parameters.Add("descri", OracleDbType.Varchar2)
            'oparam0.Value = "ALMACEN1"
            'oparam0.Direction = ParameterDirection.Input

            'Dim oparam01 As OracleParameter = cmd.Parameters.Add("passwd", OracleDbType.Varchar2)
            'oparam01.Value = "1234"
            'oparam01.Direction = ParameterDirection.Input

            'Dim oparam1 As OracleParameter = cmd.Parameters.Add("gridOUT", OracleDbType.RefCursor)
            'oparam1.Direction = ParameterDirection.Output


            '   cmd.Parameters.Add(New OracleParameter("gridOUT", OracleDbType.RefCursor)).Direction = ParameterDirection.Output
            cmd.CommandType = CommandType.StoredProcedure
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return dr
        Catch ex As Exception
            MsgBox(ex.ToString)
            'Throw ex

        End Try

    End Function

    ''' <summary>
    ''' Metodo utilizado para la lectura de datos. Devuelve un objeto DataReader.
    ''' </summary>
    ''' <param name="sql">Cadena SQL para ejecutar el objeto reader</param>
    Protected Function GetDataReader(ByVal sql As String) As Oracle.ManagedDataAccess.Client.OracleDataReader

        Dim dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Nothing
        Try
            ConnectionBegin()
            Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(sql)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return dr
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo utilizado para obtener una tabla de datos. Devuelve un objeto DataSet.
    ''' </summary>
    ''' <param name="storeProcedure">Nombre del StoreProcedure a procesar.</param>
    ''' <param name="parameters">Objeto el cual posee los parámetros definidos del storeprocedure a ejecutar.</param>
    Protected Function GetDataSet(ByVal storeProcedure As String,
                                  ByVal parameters As IDataParameter()) As DataSet

        Dim da As Oracle.ManagedDataAccess.Client.OracleDataAdapter = New Oracle.ManagedDataAccess.Client.OracleDataAdapter
        Dim ds As New DataSet
        Try
            Using ConnectionBegin()
                Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(storeProcedure, parameters)
                da.SelectCommand = cmd
                da.Fill(ds)
            End Using
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    ''' <summary>
    ''' Metodo utilizado para obtener una tabla de datos. Devuelve un objeto DataSet.
    ''' </summary>
    ''' <param name="sql">Cadena SQL para ejecutar el objeto DataAdapter.</param>
    Protected Function GetDataSet(ByVal sql As String) As DataSet

        Dim da As Oracle.ManagedDataAccess.Client.OracleDataAdapter = New Oracle.ManagedDataAccess.Client.OracleDataAdapter
        Dim ds As New DataSet

        Try
            Using ConnectionBegin()
                Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(sql)
                da.SelectCommand = cmd
                da.Fill(ds)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return ds

    End Function

    Protected Function ListDt(ByVal sSp As String, ByVal ParamArray Argumentos() As System.Object) As DataTable
        Dim dt As DataTable
        Try
            'Declaracion de Parametros 

            'Using ds As DataSet = Me.GetDataSet("[dbwebxe].[dbo].[usp_UsuarioLogin]", arrParam)
            Using ds As DataSet = Me.GetDataSet(sSp, Argumentos)
                dt = ds.Tables(0)
            End Using
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ListDt3(ByVal sSp As String, ByVal ParamArray Argumentos() As System.Object) As DataTable
        Dim dt As DataTable
        Try
            'Declaracion de Parametros 

            'Using ds As DataSet = Me.GetDataSet("[dbwebxe].[dbo].[usp_UsuarioLogin]", arrParam)
            Using ds As DataSet = Me.GetDataSet(sSp, Argumentos)
                dt = ds.Tables(0)
            End Using
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "Metodos para Grabar Datos"

    ''' <summary>
    ''' Método utilizado para ejecutar las acciones de inserción, edición, eliminación.
    ''' </summary>
    ''' <param name="sql">Cadena SQL para ejecutar la acción.</param>
    Protected Function executeSql(ByVal sql As String) As Boolean

        Dim conExito As Boolean
        Try
            Using ConnectionBegin()
                Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(sql)
                conExito = (cmd.ExecuteNonQuery() > 0)
            End Using
        Catch ex As Exception
            Throw ex
        End Try

        Return conExito
    End Function

    ''' <summary>
    ''' Método utilizado para ejecutar las acciones de inserción, edición, eliminación.
    ''' </summary>
    ''' <param name="storeProcedure">Nombre del StoreProcedure a procesar.</param>
    ''' <param name="parameters">Objeto el cual posee los parámetros definidos del storeprocedure a ejecutar.</param>
    Protected Function executeSP(ByVal storeProcedure As String,
                                 ByVal parameters As IDataParameter(), sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction) As Boolean

        Dim conExito As Boolean = False
        Try
            Using ConnectionBegin()

                Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(storeProcedure, parameters)
                cmd.Transaction = sqlTrans
                conExito = (cmd.ExecuteNonQuery() > 0)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return conExito

    End Function

    Protected Function executeSPX(ByVal storeProcedure As String,
                             ByVal parameters As IDataParameter()) As Boolean

        Dim conExito As Boolean = False
        Try
            Using ConnectionBegin()

                Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(storeProcedure, parameters)
                conExito = (cmd.ExecuteNonQuery() > 0)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return conExito

    End Function

#End Region


#Region "Metodos para Manejo de Comandos"

    ''' <summary>
    ''' Método utilizado para la creación del objeto SqlCommand.
    ''' </summary>
    ''' <param name="storeProcedure">Nombre del StoreProcedure a procesar.</param>
    ''' <param name="parameters">Objeto el cual posee los parámetros definidos del storeprocedure a ejecutar.</param>
    Protected Function BuildQueryCommand(ByVal storeProcedure As String,
                                       ByVal parameters As IDataParameter()) As Oracle.ManagedDataAccess.Client.OracleCommand

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand(storeProcedure, cnConexion)
        cmd.CommandType = CommandType.StoredProcedure

        Dim parameter As Oracle.ManagedDataAccess.Client.OracleParameter
        For Each parameter In parameters
            ' parameter.TypeName = "dbo.CTT_comvcComprobante"
            cmd.Parameters.Add(parameter)
            parameter.Direction = ParameterDirection.Input
        Next
        '  cmd.Parameters.Add(New Oracle.ManagedDataAccess.Client.OracleParameter("gridOUT", OracleType.Cursor)).Direction = ParameterDirection.Output
        Return cmd

    End Function

    ''' <summary>
    ''' Método utilizado para la creación del objeto SqlCommand.
    ''' </summary>
    ''' <param name="sql">Cadena SQL.</param>
    Protected Function BuildQueryCommand(ByVal sql As String) As Oracle.ManagedDataAccess.Client.OracleCommand

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand(sql, cnConexion)
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        Return cmd

    End Function

#End Region

#Region "Useful Functions"

    ''' <summary>
    ''' Método útil para definir si el campo del objeto reader está nulo.
    ''' De ser así, devuelve un mínimo valor.
    ''' </summary>
    ''' <param name="dr">Objeto DataReader.</param>
    ''' <param name="campo">Número del campo del objeto DataReader.</param>
    Protected Function GetDateValue(ByRef dr As IDataReader, ByVal campo As Integer) As Date
        If (dr.IsDBNull(campo)) Then
            Return Date.MinValue
        Else
            Return dr.GetDateTime(campo)
        End If
    End Function

    ''' <summary>
    ''' Método útil para definir si el campo del objeto reader está nulo.
    ''' De ser así, devuelve un mínimo valor, en este caso cero (0).
    ''' </summary>
    ''' <param name="dr">Objeto DataReader.</param>
    ''' <param name="campo">Número del campo del objeto DataReader.</param>
    Protected Function GetNumericValue(ByRef dr As IDataReader, ByVal campo As Integer) As System.Object
        If (dr.IsDBNull(campo)) Then
            Return 0
        Else
            Return dr.GetValue(campo)
        End If
    End Function

    ''' <summary>
    ''' Método útil para definir si el campo del objeto reader está nulo.
    ''' De ser así, devuelve un mínimo valor, en este caso valor vacío ("").
    ''' </summary>
    ''' <param name="dr">Objeto DataReader.</param>
    ''' <param name="campo">Número del campo del objeto DataReader.</param>
    Protected Function GetStringValue(ByRef dr As IDataReader, ByVal campo As Integer) As String
        If (dr.IsDBNull(campo)) Then
            Return ""
        Else
            Return dr.GetString(campo)
        End If
    End Function

#End Region





































    ''''#Region "Variables Constantes"
    ''''    Protected cnConexion As OracleConnection = Nothing          'Almacena el objeto Conexión.
    ''''    Private fechaExpiracion As String = "31/12/2013"  'Fecha en que deja de funcionar la conexion
    ''''    Private strCadenaDeConexion As String 'Cadena de conexion a la base de datos
    ''''    Private Servidor As String = String.Empty
    ''''    Shared mColComandos As New System.Collections.Hashtable() 'Coleccion de procedimientos almacenados
    ''''#End Region

    ''''#Region "Configuracion"


    ''''    Public Shared gsOraclesource As String
    ''''    Public Shared gsSHAREDDBEmpresa As String

    ''''    Private mCgrConnString As String                            'Almacena la cadena de Conexión
    ''''    Private Property CgrConnString() As String
    ''''        Get
    ''''            Return Me.ObtenerConnString()
    ''''        End Get
    ''''        Set(ByVal value As String)
    ''''            mCgrConnString = value
    ''''        End Set
    ''''    End Property

    ''''    ''' <summary>
    ''''    ''' Obtiene la cadena de conexión desde el archivo de configuración.
    ''''    ''' </summary>
    ''''    Private Function ObtenerConnString() As String

    ''''        Dim cgrConnString As String = "cgrConnStrings"
    ''''        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings(cgrConnString)
    ''''        'Dim clock As String = System.Configuration.ConfigurationSettings.AppSettings("clock")

    ''''        gsOraclesource = "(Remote)"
    ''''        If InStr(settings.ToString, "(local)", CompareMethod.Text) <> 0 Then
    ''''            gsOraclesource = "(local)"
    ''''        End If



    ''''        If Not settings Is Nothing Then
    ''''            Return settings.ConnectionString
    ''''        Else
    ''''            Return "connectionString: (" & cgrConnString & ") Configuracion Fallida"
    ''''        End If

    ''''    End Function

    ''''#End Region

    ''''#Region "Metodos de Conexion a la BD"

    ''''    ''' <summary>
    ''''    ''' Se concecta con la base de datos.
    ''''    ''' </summary>
    ''''    ''' <exception  cref="BaseDatosException">Si existe un error al conectarse.</exception> 
    ''''    Protected Function ConnectionBegin() As OracleConnection
    ''''        Dim oradb As String = "Data Source=(DESCRIPTION=" _
    ''''+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.5)(PORT=1521)))" _
    ''''+ "(CONNECT_DATA=(SID = LUX)));" _
    ''''+ "User Id=logi;Password=sistema;"

    ''''        'Dim connection As New OracleConnection(oradb)
    ''''        'Dim command As New Oracle.ManagedDataAccess.Client.OracleCommand()
    ''''        'Dim reader As OracleDataReader

    ''''        'connection.Open()
    ''''        'command.Connection = connection




    ''''        If Not Me.cnConexion Is Nothing Then
    ''''            If Me.cnConexion.State.Equals(ConnectionState.Closed) Then
    ''''                Me.cnConexion.Open()
    ''''            End If
    ''''        End If

    ''''        Try
    ''''            If Me.cnConexion Is Nothing Then
    ''''                Me.cnConexion = New OracleConnection

    ''''                Me.cnConexion.ConnectionString = oradb 'Me.CgrConnString
    ''''                Me.cnConexion.Open()
    ''''            End If
    ''''        Catch ex As DataException
    ''''            Throw New BaseDatosException("Error al conectarse.")
    ''''        End Try

    ''''        Return cnConexion

    ''''    End Function

    ''''    ''' <summary>
    ''''    ''' Permite desconectarse de la base de datos.
    ''''    ''' </summary>
    ''''    Protected Sub ConnectionDispose()
    ''''        If Me.cnConexion.State.Equals(ConnectionState.Open) Then
    ''''            Me.cnConexion.Dispose()
    ''''            Me.cnConexion = Nothing
    ''''        End If
    ''''    End Sub

    ''''#End Region

    ''''#Region "Metodos para leer Datos"

    ''''    '' <summary>
    ''''    '' Metodo utilizado para la lectura de datos. Devuelve un objeto DataReader.
    ''''    '' </summary>
    ''''    '' <param name="storeProcedure">Nombre del StoreProcedure a procesar.</param>
    ''''    '' <param name="parameters">Objeto el cual posee los parámetros definidos del storeprocedure a ejecutar.</param>
    ''''    'Protected Function GetDataReader(ByVal storeProcedure As String,
    ''''    '                                 ByVal parameters As IDataParameter()) As OracleDataReader

    ''''    '    Dim dr As OracleDataReader = Nothing
    ''''    '    Try
    ''''    '        ConnectionBegin()
    ''''    '        Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(storeProcedure, parameters)
    ''''    '        cmd.CommandType = CommandType.StoredProcedure
    ''''    '        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    ''''    '        Return dr
    ''''    '    Catch ex As Exception
    ''''    '        MsgBox(ex.ToString)
    ''''    '        'Throw ex

    ''''    '    End Try

    ''''    'End Function

    ''''    ''' <summary>
    ''''    ''' Metodo utilizado para la lectura de datos. Devuelve un objeto DataReader.
    ''''    ''' </summary>
    ''''    ''' <param name="Oracle">Cadena Oracle para ejecutar el objeto reader</param>
    ''''    Protected Function GetDataReader(ByVal Oracle As String) As OracleDataReader









    ''''        Dim dr As OracleDataReader = Nothing
    ''''        Try
    ''''            ConnectionBegin()
    ''''            'Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(Oracle)            'noooooooooooooooooooooooooo
    ''''            'cmd.CommandType = CommandType.StoredProcedure
    ''''            'cmd.CommandText = Oracle
    ''''            'Dim result As String
    ''''            'result = CType(cmd.Parameters("P_code").Value.ToString, String)
    ''''            'dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    ''''            ''  dr = cmd.ExecuteReader()
    ''''            'Return dr

    ''''            '       Dim cn As New OracleConnection("server = 192.168.1.5; User Id = logi; Pwd = sistema")
    ''''            Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand '= BuildQueryCommand(Oracle)            'noooooooooooooooooooooooooo
    ''''            ' cmd.CommandType = CommandType.StoredProcedure
    ''''            cmd.CommandText = "select * from eltbuser"
    ''''            '  cmd.Parameters.Add(New OracleParameter("p_code", OracleDbType.RefCursor)).Value = ParameterDirection.Output
    ''''            Dim result As String
    ''''            'result = CType(cmd.Parameters("P_code").Value.ToString, String)
    ''''            'dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    ''''            Dim da As New Oracle.ManagedDataAccess.Client.OracleDataAdapter

    ''''            da.SelectCommand = cmd
    ''''            Dim ds As New DataSet
    ''''            da.Fill(ds)
    ''''            '  dr = cmd.ExecuteReader()
    ''''            Return dr




    ''''        Catch ex As Exception
    ''''            Throw ex
    ''''        End Try

    ''''    End Function

    ''''    ''' <summary>
    ''''    ''' Metodo utilizado para obtener una tabla de datos. Devuelve un objeto DataSet.
    ''''    ''' </summary>
    ''''    ''' <param name="storeProcedure">Nombre del StoreProcedure a procesar.</param>
    ''''    ''' <param name="parameters">Objeto el cual posee los parámetros definidos del storeprocedure a ejecutar.</param>
    ''''    Protected Function GetDataSet(ByVal storeProcedure As String,
    ''''                                  ByVal parameters As IDataParameter()) As DataSet

    ''''        Dim da As Oracle.ManagedDataAccess.Client.OracleDataAdapter = New Oracle.ManagedDataAccess.Client.OracleDataAdapter
    ''''        Dim ds As New DataSet
    ''''        Try
    ''''            Using ConnectionBegin()
    ''''                Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(storeProcedure, parameters)
    ''''                da.SelectCommand = cmd
    ''''                da.Fill(ds)
    ''''            End Using
    ''''        Catch ex As Exception
    ''''            Throw ex
    ''''        End Try

    ''''        Return ds

    ''''    End Function

    ''''    ''' <summary>
    ''''    ''' Metodo utilizado para obtener una tabla de datos. Devuelve un objeto DataSet.
    ''''    ''' </summary>
    ''''    ''' <param name="Oracle">Cadena Oracle para ejecutar el objeto DataAdapter.</param>
    ''''    Protected Function GetDataSet(ByVal Oracle As String) As DataSet

    ''''        Dim da As Oracle.ManagedDataAccess.Client.OracleDataAdapter = New Oracle.ManagedDataAccess.Client.OracleDataAdapter
    ''''        Dim ds As New DataSet

    ''''        Try
    ''''            Using ConnectionBegin()
    ''''                Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(Oracle)
    ''''                da.SelectCommand = cmd
    ''''                da.Fill(ds)
    ''''            End Using
    ''''        Catch ex As Exception
    ''''            Throw ex
    ''''        End Try
    ''''        Return ds

    ''''    End Function

    ''''    Protected Function ListDt(ByVal sSp As String, ByVal ParamArray Argumentos() As System.Object) As DataTable
    ''''        Dim dt As DataTable
    ''''        Try
    ''''            'Declaracion de Parametros 

    ''''            'Using ds As DataSet = Me.GetDataSet("[dbwebxe].[dbo].[usp_UsuarioLogin]", arrParam)
    ''''            Using ds As DataSet = Me.GetDataSet(sSp, Argumentos)
    ''''                dt = ds.Tables(0)
    ''''            End Using
    ''''            Return dt
    ''''        Catch ex As Exception
    ''''            Throw ex
    ''''        End Try

    ''''    End Function

    ''''    Public Function ListDt3(ByVal sSp As String, ByVal ParamArray Argumentos() As System.Object) As DataTable
    ''''        Dim dt As DataTable
    ''''        Try
    ''''            'Declaracion de Parametros 

    ''''            'Using ds As DataSet = Me.GetDataSet("[dbwebxe].[dbo].[usp_UsuarioLogin]", arrParam)
    ''''            Using ds As DataSet = Me.GetDataSet(sSp, Argumentos)
    ''''                dt = ds.Tables(0)
    ''''            End Using
    ''''            Return dt
    ''''        Catch ex As Exception
    ''''            Throw ex
    ''''        End Try

    ''''    End Function

    ''''#End Region

    ''''#Region "Metodos para Grabar Datos"

    ''''    ''' <summary>
    ''''    ''' Método utilizado para ejecutar las acciones de inserción, edición, eliminación.
    ''''    ''' </summary>
    ''''    ''' <param name="Oracle">Cadena Oracle para ejecutar la acción.</param>
    ''''    Protected Function executeOracle(ByVal Oracle As String) As Boolean

    ''''        Dim conExito As Boolean
    ''''        Try
    ''''            Using ConnectionBegin()
    ''''                Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(Oracle)
    ''''                conExito = (cmd.ExecuteNonQuery() > 0)
    ''''            End Using
    ''''        Catch ex As Exception
    ''''            Throw ex
    ''''        End Try

    ''''        Return conExito
    ''''    End Function

    ''''    ''' <summary>
    ''''    ''' Método utilizado para ejecutar las acciones de inserción, edición, eliminación.
    ''''    ''' </summary>
    ''''    ''' <param name="storeProcedure">Nombre del StoreProcedure a procesar.</param>
    ''''    ''' <param name="parameters">Objeto el cual posee los parámetros definidos del storeprocedure a ejecutar.</param>
    ''''    Protected Function executeSP(ByVal storeProcedure As String,
    ''''                                 ByVal parameters As IDataParameter(), OracleTrans As Oracle.ManagedDataAccess.Client.OracleTransaction) As Boolean

    ''''        Dim conExito As Boolean = False
    ''''        Try
    ''''            Using ConnectionBegin()

    ''''                Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(storeProcedure, parameters)
    ''''                cmd.Transaction = OracleTrans
    ''''                conExito = (cmd.ExecuteNonQuery() > 0)
    ''''            End Using
    ''''        Catch ex As Exception
    ''''            Throw ex
    ''''        End Try
    ''''        Return conExito

    ''''    End Function

    ''''    Protected Function executeSPX(ByVal storeProcedure As String,
    ''''                             ByVal parameters As IDataParameter()) As Boolean

    ''''        Dim conExito As Boolean = False
    ''''        Try
    ''''            Using ConnectionBegin()

    ''''                Dim cmd As Oracle.ManagedDataAccess.Client.OracleCommand = BuildQueryCommand(storeProcedure, parameters)
    ''''                conExito = (cmd.ExecuteNonQuery() > 0)
    ''''            End Using
    ''''        Catch ex As Exception
    ''''            Throw ex
    ''''        End Try
    ''''        Return conExito

    ''''    End Function

    ''''#End Region


    ''''#Region "Metodos para Manejo de Comandos"

    ''''    ''' <summary>
    ''''    ''' Método utilizado para la creación del objeto Oracle.ManagedDataAccess.Client.OracleCommand.
    ''''    ''' </summary>
    ''''    ''' <param name="storeProcedure">Nombre del StoreProcedure a procesar.</param>
    ''''    ''' <param name="parameters">Objeto el cual posee los parámetros definidos del storeprocedure a ejecutar.</param>
    ''''    Protected Function BuildQueryCommand(ByVal storeProcedure As String,
    ''''                                       ByVal parameters As IDataParameter()) As Oracle.ManagedDataAccess.Client.OracleCommand

    ''''        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand(storeProcedure, cnConexion)
    ''''        cmd.CommandType = CommandType.StoredProcedure

    ''''        Dim parameter As OracleParameter
    ''''        For Each parameter In parameters
    ''''            ' parameter.TypeName = "dbo.CTT_comvcComprobante"
    ''''            cmd.Parameters.Add(parameter)
    ''''        Next
    ''''        Return cmd

    ''''    End Function

    ''''    ''' <summary>
    ''''    ''' Método utilizado para la creación del objeto Oracle.ManagedDataAccess.Client.OracleCommand.
    ''''    ''' </summary>
    ''''    ''' <param name="Oracle">Cadena Oracle.</param>
    ''''    Protected Function BuildQueryCommand(ByVal Oracle As String) As Oracle.ManagedDataAccess.Client.OracleCommand

    ''''        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand(Oracle, cnConexion)
    ''''        cmd.CommandType = CommandType.Text
    ''''        cmd.CommandText = Oracle
    ''''        Return cmd

    ''''        End Function

    ''''#End Region

    ''''#Region "Useful Functions"

    ''''        ''' <summary>
    ''''        ''' Método útil para definir si el campo del objeto reader está nulo.
    ''''        ''' De ser así, devuelve un mínimo valor.
    ''''        ''' </summary>
    ''''        ''' <param name="dr">Objeto DataReader.</param>
    ''''        ''' <param name="campo">Número del campo del objeto DataReader.</param>
    ''''        Protected Function GetDateValue(ByRef dr As IDataReader, ByVal campo As Integer) As Date
    ''''            If (dr.IsDBNull(campo)) Then
    ''''                Return Date.MinValue
    ''''            Else
    ''''                Return dr.GetDateTime(campo)
    ''''            End If
    ''''        End Function

    ''''        ''' <summary>
    ''''        ''' Método útil para definir si el campo del objeto reader está nulo.
    ''''        ''' De ser así, devuelve un mínimo valor, en este caso cero (0).
    ''''        ''' </summary>
    ''''        ''' <param name="dr">Objeto DataReader.</param>
    ''''        ''' <param name="campo">Número del campo del objeto DataReader.</param>
    ''''        Protected Function GetNumericValue(ByRef dr As IDataReader, ByVal campo As Integer) As System.Object
    ''''            If (dr.IsDBNull(campo)) Then
    ''''                Return 0
    ''''            Else
    ''''                Return dr.GetValue(campo)
    ''''            End If
    ''''        End Function

    ''''        ''' <summary>
    ''''        ''' Método útil para definir si el campo del objeto reader está nulo.
    ''''        ''' De ser así, devuelve un mínimo valor, en este caso valor vacío ("").
    ''''        ''' </summary>
    ''''        ''' <param name="dr">Objeto DataReader.</param>
    ''''        ''' <param name="campo">Número del campo del objeto DataReader.</param>
    ''''        Protected Function GetStringValue(ByRef dr As IDataReader, ByVal campo As Integer) As String
    ''''            If (dr.IsDBNull(campo)) Then
    ''''                Return ""
    ''''            Else
    ''''                Return dr.GetString(campo)
    ''''            End If
    ''''        End Function

    ''''#End Region

End Class


