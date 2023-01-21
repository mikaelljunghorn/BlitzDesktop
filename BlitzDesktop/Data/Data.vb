
Imports Newtonsoft.Json
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class Data

    Public Shared Function AsDataSet(serverName As String, commandText As String, commandType As CommandType, Optional connString As String = "") As DataSet

        Dim ds As New DataSet()

        Try

            If String.IsNullOrEmpty(connString) Then
                connString = GetConnString(serverName)
            End If

            Using conn As SqlConnection = New System.Data.SqlClient.SqlConnection(connString)

                Using cmd As New SqlCommand()

                    cmd.CommandText = commandText
                    cmd.Connection = conn
                    cmd.CommandType = commandType
                    cmd.CommandTimeout = Common.TimeOut

                    conn.Open()

                    Dim adapter As New SqlDataAdapter(cmd)

                    adapter.Fill(ds)

                    conn.Close()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return ds

    End Function

    Public Shared Function AsDataTable(serverName As String, commandText As String, commandType As CommandType, Optional connString As String = "") As DataTable

        Return AsDataSet(serverName, commandText, commandType, connString).Tables(0)

    End Function

    Public Shared Function Sprocs(serverName As String, whereClause As String) As DataTable

        Dim databaseName As String = GetDatabaseName(serverName)

        ' List sp_Blitz..... sprocs.
        Dim sql As New StringBuilder()
        sql.AppendLine(String.Format("USE [{0}]", databaseName))
        sql.AppendLine("SELECT [Name] FROM sys.procedures")
        If Not String.IsNullOrEmpty(whereClause) Then
            sql.AppendLine("WHERE [Name] LIKE '%" & whereClause & "%'")
        End If
        sql.AppendLine("ORDER BY [Name]")

        Dim sprocsList As DataTable =
            Data.AsDataTable(serverName, sql.ToString(), CommandType.Text)

        Return sprocsList

    End Function

    Public Shared Function Sprocs(serverName As String, databaseName As String, whereClause As String) As DataTable

        ' List sp_Blitz..... sprocs.
        Dim sql As New StringBuilder()
        sql.AppendLine(String.Format("USE [{0}]", databaseName))
        sql.AppendLine("SELECT [Name] FROM sys.procedures")
        If Not String.IsNullOrEmpty(whereClause) Then
            sql.AppendLine("WHERE [Name] LIKE '%" & whereClause & "%'")
        End If
        sql.AppendLine("ORDER BY [Name]")

        Dim sprocsList As DataTable =
            Data.AsDataTable(serverName, sql.ToString(), CommandType.Text)

        Return sprocsList

    End Function

    Public Shared Function SprocsBySchemaName(serverName As String, databaseName As String, schemaName As String, Optional whereClause As String = "") As DataTable

        ' List sp_Blitz..... sprocs.
        Dim sql As New StringBuilder()
        sql.AppendLine(String.Format("USE [{0}]", databaseName))
        sql.AppendLine("SELECT [Name] FROM sys.procedures ")
        sql.AppendLine("WHERE 1 = 1")
        sql.AppendLine("AND (SCHEMA_NAME(schema_id) = '" & schemaName & "')")
        If Not String.IsNullOrEmpty(whereClause) Then
            sql.AppendLine("AND ([Name] LIKE '%" & whereClause & "%') ")
        End If
        sql.AppendLine("ORDER BY [Name] ")

        Dim sprocsList As DataTable =
        Data.AsDataTable(serverName, sql.ToString(), CommandType.Text)

        Return sprocsList

    End Function

    Public Shared Function SprocParameters(serverName As String, databaseName As String, sprocName As String) As DataTable

        ' List sp_Blitz..... sprocs.
        Dim sql As New StringBuilder()
        sql.AppendLine(String.Format("USE [{0}]", databaseName))
        sql.AppendLine("SELECT")
        sql.AppendLine("	P.name AS [ParameterName]")
        sql.AppendLine("FROM")
        sql.AppendLine("	sys.objects AS SO")
        sql.AppendLine("	INNER JOIN sys.parameters AS P ON SO.OBJECT_ID = P.OBJECT_ID")
        sql.AppendLine("WHERE")
        sql.AppendLine(String.Format("	SO.name = '{0}'", sprocName))
        'sql.AppendLine("ORDER BY")
        'sql.AppendLine("	P.name")

        Dim sprocsList As DataTable =
        Data.AsDataTable(serverName, sql.ToString(), CommandType.Text)

        Return sprocsList

    End Function

    Public Shared Function Schemas(serverName As String, databaseName As String) As DataTable

        ' List schemas for selected database
        Dim sql As New StringBuilder()
        sql.AppendLine(String.Format("USE [{0}]", databaseName))
        sql.AppendLine("SELECT DISTINCT schema_name(t.schema_id) AS schema_name FROM sys.tables t ORDER BY schema_name")

        Dim sprocsList As DataTable =
            Data.AsDataTable(serverName, sql.ToString(), CommandType.Text)

        Return sprocsList

    End Function

    Public Shared Function Tables(serverName As String, databaseName As String, schemaName As String) As DataTable

        ' List schemas for selected database
        Dim sql As New StringBuilder()
        sql.AppendLine(String.Format("USE [{0}]", databaseName))
        sql.AppendLine(String.Format("SELECT t.name as table_name FROM sys.tables t WHERE schema_name(t.schema_id) = '{0}' ORDER BY table_name", schemaName))

        Dim sprocsList As DataTable =
            Data.AsDataTable(serverName, sql.ToString(), CommandType.Text)

        Return sprocsList

    End Function

    Public Shared Function GetConnString(serverName As String, Optional databaseName As String = "master") As String

        Dim serverInfo As ServerInfo = GetServerInfoByName(serverName)

        If (Not String.IsNullOrEmpty(serverInfo.userName)) And (Not String.IsNullOrEmpty(serverInfo.password)) Then
            ' Username and Password
            Return String.Format("Server={0};Database={1};Uid={2};Pwd={3}", serverName, databaseName, serverInfo.userName, serverInfo.password)
        Else
            ' Trusted connection
            Return String.Format("Server={0};Database={1};Trusted_Connection=True", serverName, databaseName)
        End If

    End Function

    Private Shared Function GetServerInfoByName(serverName As String) As ServerInfo

        Dim returnInfo As ServerInfo = Nothing
        Dim serverList As List(Of ServerInfo) = Servers_List()

        For Each serverInfo As ServerInfo In serverList
            If serverInfo.serverName = serverName Then
                returnInfo = serverInfo
            End If
        Next

        Return returnInfo

    End Function

    Public Shared Function Servers_List() As List(Of ServerInfo) 'ServerList

        If Not My.Computer.FileSystem.FileExists(Constants.ServersFile) Then
            Return New List(Of ServerInfo)
        End If

        Dim serverListFile As String =
            My.Computer.FileSystem.ReadAllText(Constants.ServersFile)

        Dim serializerSettings As New JsonSerializerSettings
        With serializerSettings
            .NullValueHandling = NullValueHandling.Ignore
            .MissingMemberHandling = MissingMemberHandling.Error
        End With

        Dim serverList As List(Of ServerInfo) =
            JsonConvert.DeserializeObject(Of List(Of ServerInfo))(serverListFile, serializerSettings)

        If serverList Is Nothing Then
            serverList = New List(Of ServerInfo)
        End If

        Return serverList

    End Function

    Public Shared Sub Server_Save(serverList As List(Of ServerInfo))

        ' Serialize to JSON-object
        Dim serializerSettings As New JsonSerializerSettings
        With serializerSettings
            .NullValueHandling = NullValueHandling.Ignore
            .MissingMemberHandling = MissingMemberHandling.Error
        End With

        Dim jsonData = JsonConvert.SerializeObject(serverList, serializerSettings)

        If serverList.Count > 0 Then
            My.Computer.FileSystem.WriteAllText(Constants.ServersFile, jsonData, False)
        Else
            My.Computer.FileSystem.WriteAllText(Constants.ServersFile, String.Empty, False)
        End If

    End Sub

    Public Shared Function GetDatabaseName(serverName As String) As String

        Dim serverList As List(Of ServerInfo) = Data.Servers_List()

        Return serverList.Find(Function(n) n.serverName = serverName).database

    End Function

    Public Shared Function GetSprocName(serverName As String) As String

        Dim serverList As List(Of ServerInfo) = Data.Servers_List()

        Return serverList.Find(Function(n) n.serverName = serverName).storedProcedure

    End Function

End Class

Public Class ServerInfo

    Public Property [serverName] As String
    Public Property [userName] As String
    Public Property [password] As String
    Public Property [portNumber] As String
    Public Property [database] As String
    Public Property [storedProcedure] As String

End Class
