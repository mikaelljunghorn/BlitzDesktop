
Imports System.Text

Public Class Servers

    Private connString As String = String.Empty
    Private serverList As List(Of ServerInfo) = Nothing

    Private Sub Servers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadServers()

        ddlAuthentication.SelectedIndex = 0

    End Sub

    Private Sub LoadServers()

        ' Populate dropdown with servers.
        serverList = Data.Servers_List()
        serverList = serverList.OrderBy(Function(n) n.serverName).ToList

        Dim counter As Integer = 0
        Dim selected As Integer = 0
        ddlServers.Items.Clear()
        For Each serverInfo As ServerInfo In serverList
            counter += 1
            ddlServers.Items.Add(serverInfo.serverName)
        Next
        If serverList.Count > 0 Then
            ddlServers.SelectedIndex = 0
        End If

    End Sub

    Private Sub cmdRemoveServer_Click(sender As Object, e As EventArgs) Handles cmdRemoveServer.Click

        Dim selectedServer As String = ddlServers.SelectedItem

        Dim serverInfo As ServerInfo = serverList.Find(Function(s) s.serverName = selectedServer)

        serverList.Remove(serverInfo)

        Data.Server_Save(serverList)

        ' Reload data
        LoadServers()

    End Sub

    Private Sub ddlAuthentication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlAuthentication.SelectedIndexChanged

        Select Case ddlAuthentication.SelectedIndex
            Case 0 ' Windows authentication
                txtUserName.Enabled = False
                txtPassword.Enabled = False
            Case Else
                txtUserName.Enabled = True
                txtPassword.Enabled = True
        End Select

    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click

        ConnectToServer("master")

    End Sub

    Private Sub ddlDatabases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDatabases.SelectedIndexChanged

        ListFoundSprocs(ddlDatabases.SelectedItem)

    End Sub

    Private Sub ConnectToServer(databaseName As String)

        Select Case ddlAuthentication.SelectedIndex
            Case 0 ' Windows authentication
                connString = String.Format("Server={0};Database={1};Trusted_Connection=True;", txtServer.Text, databaseName)
            Case Else
                connString = String.Format("Server={0};Database={1};Uid={2};Pwd={3}", txtServer.Text, databaseName, txtUserName.Text, txtPassword.Text)
        End Select

        ' List databases
        Dim databasesList As DataTable =
            Data.AsDataTable(txtServer.Text, "sp_databases", CommandType.StoredProcedure, connString)

        ddlDatabases.Items.Clear()
        Dim counter As Short = -1

        For item As Integer = 0 To (databasesList.Rows.Count - 1)
            Dim dataRow As DataRow = databasesList.Rows(item)
            If Not "model|msdb|tempdb".Contains(dataRow.Item(0)) Then
                counter += 1
                ddlDatabases.Items.Add(dataRow.ItemArray(0))
                If (databaseName = "master") AndAlso (dataRow.ItemArray(0) = "master") Then
                    ddlDatabases.SelectedIndex = counter
                End If
            End If
        Next

        ddlDatabases.Enabled = True

    End Sub

    Private Sub ListFoundSprocs(databaseName As String)

        cmdSave.Enabled = False

        ' List sp_Blitz..... sprocs.
        Dim sql As New StringBuilder()
        sql.AppendLine(String.Format("USE [{0}] ", databaseName))
        sql.AppendLine("SELECT [Name] FROM sys.procedures ")
        sql.AppendLine("WHERE [Name] LIKE 'sp_Blitz%' ")
        sql.AppendLine("ORDER BY [Name] ")

        Dim sprocsList As DataTable =
            Data.AsDataTable(txtServer.Text, sql.ToString(), CommandType.Text, connString)

        lbFoundSprocs.Items.Clear()

        If sprocsList.Rows.Count > 0 Then

            Dim selected As Integer = 0

            For item As Integer = 0 To (sprocsList.Rows.Count - 1)
                Dim dataRow As DataRow = sprocsList.Rows(item)
                ' Only list sp_Blitz sprocs.
                If "sp_Blitz|sp_BlitzAnalysis|sp_BlitzBackups|sp_BlitzCache|sp_BlitzFirst|sp_BlitzIndex|sp_BlitzLock|sp_BlitzQueryStore|sp_BlitzWho".Contains(dataRow.Item(0)) Then
                    lbFoundSprocs.Items.Add(dataRow.ItemArray(0))
                    cmdSave.Enabled = True
                End If
            Next

        Else

            With lbFoundSprocs
                .Items.Add("No sp_Blitz sprocs")
                .Items.Add("found in database")
                .Items.Add(databaseName)
            End With

        End If

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Dim serverInfo As New ServerInfo
        With serverInfo
            .serverName = txtServer.Text
            .userName = txtUserName.Text
            .password = txtPassword.Text
            .portNumber = String.Empty
            .database = ddlDatabases.SelectedItem
            .storedProcedure = String.Empty
        End With

        serverList.Add(serverInfo)

        Data.Server_Save(serverList)

        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.DialogResult = DialogResult.Cancel

    End Sub

End Class