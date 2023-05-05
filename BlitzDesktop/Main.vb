
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Imports OfficeOpenXml
Imports OfficeOpenXml.Style

Public Class BlitzDesktop

    Private database As String = String.Empty

    Private dataSet As DataSet = Nothing
    Private dataTable As DataTable = Nothing

    Private databasesList As DataTable = Nothing
    Private parameters As String = String.Empty

    Private selectedServer As String = String.Empty
    Private selectedDatabase As String = String.Empty
    Private selectedSproc As String = String.Empty

    Private warningMessage As String = String.Empty
    Private excelFolder As String

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.Text = "BlitzDesktop - Ver. " & My.Application.Info.Version.ToString

            LoadRadioButtonsTimeout(New List(Of String)({"30", "120", "600"}))

            SetToolTips()

            LoadInfo()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

    End Sub

    Private Sub LoadInfo()

        Try

            ' Get settings object.
            Dim mainSettingsInfo As MainSettingsInfo = Settings.GetMain()

            With tcFilters.TabPages
                .Remove(sp_Blitz)
                .Remove(sp_BlitzAnalysis)
                .Remove(sp_BlitzBackups)
                .Remove(sp_BlitzCache)
                .Remove(sp_BlitzFirst)
                .Remove(sp_BlitzIndex)
                .Remove(sp_BlitzLock)
                .Remove(sp_BlitzQueryStore)
                .Remove(sp_BlitzWho)
            End With

            tcFilters.Visible = True

            ' Populate dropdown with servers.
            Dim serverList As List(Of ServerInfo) = Data.Servers_List()
            serverList = serverList.OrderBy(Function(n) n.serverName).ToList

            Dim counter As Integer = 0
            Dim selected As Integer = 0
            Dim database As String = String.Empty
            ddlServers.Items.Clear()
            ddlServers.Items.Add("< Select existing SQL server >")
            For Each serverInfo As ServerInfo In serverList
                counter += 1
                ddlServers.Items.Add(serverInfo.serverName)
                If serverInfo.serverName = selectedServer Then
                    selected = counter
                    database = serverInfo.database
                End If
            Next
            ddlServers.SelectedIndex = selected
            ddlServers.Enabled = True

            ' List existing sp_Blitz procedures from the selected database.


            ' Set defaults

            ' Blitz
            ddlCheckProcedureCacheFilter_Blitz.SelectedIndex = 0
            ddlOutputType_Blitz.SelectedIndex = 0

            ' BlitzAnalysis
            ddlBlitzCacheSortOrder_BlitzAnalysis.SelectedIndex = 0
            dtpStartDate_BlitzAnalysis.Value = DateAdd(DateInterval.Hour, -1, Date.Now())
            dtpStartTime_BlitzAnalysis.Value = DateAdd(DateInterval.Hour, -1, Date.Now())
            dtpEndDate_BlitzAnalysis.Value = Date.Now()
            dtpEndTime_BlitzAnalysis.Value = Date.Now()

            ' BlitzBackups

            ' BlitzCache
            ddlQueryFilter_BlitzCache.SelectedIndex = 0

            ' BlitzFirst
            ddlOutputType_BlitzFirst.SelectedIndex = 0

            ' BlitzIndex
            ddlSortDirection_BlitzIndex.SelectedIndex = 0
            ddlMode_BlitzIndex.SelectedIndex = 0

            ' BlitzQueryStore
            dtpStartDate_BlitzQueryStore.Value = DateAdd(DateInterval.Day, -7, New Date(Date.Today.Year, Date.Today.Month, Date.Today.Day, 0, 0, 0))
            dtpStartTime_BlitzQueryStore.Value = DateAdd(DateInterval.Day, 1, New Date(Date.Today.Year, Date.Today.Month, Date.Today.Day, 0, 0, 0))
            dtpEndDate_BlitzQueryStore.Value = DateAdd(DateInterval.Day, 1, Date.Now())
            dtpEndTime_BlitzQueryStore.Value = DateAdd(DateInterval.Day, 1, New Date(Date.Today.Year, Date.Today.Month, Date.Today.Day, 0, 0, 0))

            ' BlitzWho
            ddlSortOrder_BlitzWho.SelectedIndex = 0

            ddlDatabases.Enabled = False
            lblDatabasesNotSelectable.Visible = False

        Catch ex As Exception
            MessageBox.Show("Server: " & ddlServers.SelectedItem & Environment.NewLine & ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Application.Exit()
            ddlServers.SelectedIndex = 0
            ddlServers.Enabled = True
        End Try

    End Sub

    Private Sub cmdNewServer_Click(sender As Object, e As EventArgs) Handles cmdManageServers.Click

        Dim result As DialogResult = Nothing
        Dim frm = New Servers
        With frm
            result = .ShowDialog()
            'If result = DialogResult.OK Then
            LoadInfo()
            'End If
            .Dispose()
        End With

    End Sub

    Private Sub ddlServers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlServers.SelectedIndexChanged

        If ddlServers.SelectedIndex = 0 Then
            Exit Sub
        End If

        database = Data.GetDatabaseName(ddlServers.SelectedItem)

        List_Databases()

        List_Procedures()

    End Sub

    Private Sub List_Databases()

        databasesList =
            Data.AsDataTable(ddlServers.SelectedItem, "sp_databases", CommandType.StoredProcedure)

        ' If sprocs are NOT stored in the master database we must be able to select which database to work within.
        If database.ToLower = "master" Then

            With ddlDatabases
                .Items.Clear()
                '.Items.Add("< Select current database (optional) >")

                For item As Integer = 0 To (databasesList.Rows.Count - 1)
                    Dim dataRow As DataRow = databasesList.Rows(item)
                    If Not "master|model|msdb|tempdb".Contains(dataRow.Item(0)) Then
                        .Items.Add(dataRow.ItemArray(0))
                    End If
                Next
                .SelectedIndex = 0
            End With

            ddlDatabases.Enabled = True

        Else

            ddlDatabases.Visible = False
            lblDatabasesNotSelectable.Visible = True

        End If

    End Sub

    Private Sub List_Procedures()

        Dim sprocsList As DataTable =
            Data.Sprocs(ddlServers.SelectedItem, Data.GetDatabaseName(ddlServers.SelectedItem), "sp_Blitz")

        If sprocsList.Rows.Count > 0 Then

            Dim counter As Integer = 0
            Dim selected As Integer = 0

            ' Check if we have a saved procedure in the servers json-file.
            ' If so, we will select that as it was the last selected procedure for the selected server.
            selectedSproc = Data.GetSprocName(ddlServers.SelectedItem)

            With ddlSprocs

                .Items.Clear()
                .Items.Add("< Select Sproc >")

                For item As Integer = 0 To (sprocsList.Rows.Count - 1)
                    Dim dataRow As DataRow = sprocsList.Rows(item)
                    ' Only list sp_Blitz sprocs.
                    If "sp_Blitz|sp_BlitzAnalysis|sp_BlitzBackups|sp_BlitzCache|sp_BlitzFirst|sp_BlitzIndex|sp_BlitzLock|sp_BlitzQueryStore|sp_BlitzWho".Contains(dataRow.Item(0)) Then
                        counter += 1
                        .Items.Add(dataRow.ItemArray(0))
                        If dataRow.Item(0) = selectedSproc Then
                            selected = counter
                        End If
                    End If
                Next

                .SelectedIndex = selected
                .Enabled = True

            End With
        Else
            MessageBox.Show(String.Format("No sp_Blitz sprocs found in database {0}!", database), "Stored procedures", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        cmdExportToExcel.Visible = False

    End Sub

    Private Sub ddlSprocs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSprocs.SelectedIndexChanged

        With tcFilters.TabPages
            .Remove(sp_Blitz)
            .Remove(sp_BlitzAnalysis)
            .Remove(sp_BlitzBackups)
            .Remove(sp_BlitzCache)
            .Remove(sp_BlitzFirst)
            .Remove(sp_BlitzIndex)
            .Remove(sp_BlitzLock)
            .Remove(sp_BlitzQueryStore)
            .Remove(sp_BlitzWho)
        End With

        If ddlSprocs.SelectedIndex = 0 Then
            cmdExecute.Visible = False
            lblLatestExecutedScript.Visible = False
            txtSQL.Visible = False
            Exit Sub
        End If

        ' Display selected tab för parameters.
        ' Also add any tab page specific filters.
        Select Case ddlSprocs.SelectedItem
            Case "sp_Blitz"
                tcFilters.TabPages.Insert(0, sp_Blitz)
            Case "sp_BlitzAnalysis"
                tcFilters.TabPages.Insert(0, sp_BlitzAnalysis)
            Case "sp_BlitzBackups"
                tcFilters.TabPages.Insert(0, sp_BlitzBackups)
            Case "sp_BlitzCache"
                tcFilters.TabPages.Insert(0, sp_BlitzCache)
            Case "sp_BlitzFirst"
                tcFilters.TabPages.Insert(0, sp_BlitzFirst)
            Case "sp_BlitzIndex"
                tcFilters.TabPages.Insert(0, sp_BlitzIndex)
            Case "sp_BlitzLock"
                tcFilters.TabPages.Insert(0, sp_BlitzLock)
            Case "sp_BlitzQueryStore"
                tcFilters.TabPages.Insert(0, sp_BlitzQueryStore)
            Case "sp_BlitzWho"
                tcFilters.TabPages.Insert(0, sp_BlitzWho)
        End Select

        cmdExecute.Visible = True
        lblLatestExecutedScript.Visible = True
        txtSQL.Visible = True

        ' ==================================================================================================================
        ' Get a list of parameters for the selected stored procedure
        Dim sprocParametersList As DataTable =
            Data.SprocParameters(ddlServers.SelectedItem, database, ddlSprocs.SelectedItem)

        ' Iterate all controls on the selected tab and check that the control has a match to a parameter in the stored procedure.
        For Each ctrl In tcFilters.TabPages.Item(0).Controls

            If ctrl.tag IsNot Nothing Then

                Dim tagValue As String = ctrl.Tag.ToString().Split(";").First() '.ToLower()

                Dim match() As DataRow = sprocParametersList.Select("ParameterName = '@" & tagValue & "'")

                If (match.Length = 0) And (Not ctrl.name.ToString().Contains("Internal")) Then

                    SetToolTip(ctrl, String.Format("Parameter not found in Store Procedure {0}. Perhaps the Stored Procedure is not up to date?", ddlSprocs.SelectedItem))

                    If TypeOf (ctrl) Is CheckBox Then
                        Dim chk As CheckBox = ctrl
                        Dim lbl As New Label
                        With lbl
                            .Location = New Point(chk.Location.X + 15, chk.Location.Y)
                            .Size = New Size(chk.Size.Width, 20)
                            .Text = "*** " & chk.Text
                            .BringToFront()
                        End With
                        With chk
                            .Text = String.Empty
                            .Enabled = False
                        End With
                        SetToolTip(lbl, String.Format("Parameter {0} not found in Store Procedure {1}.{2}Perhaps the Stored Procedure is not up to date?",
                                                      tagValue, ddlSprocs.SelectedItem, Environment.NewLine))
                        tcFilters.TabPages.Item(0).Controls.Add(lbl)
                    End If

                    If TypeOf (ctrl) Is ComboBox Then
                        Dim ddl As ComboBox = ctrl
                        Dim lbl As New Label
                        With lbl
                            .Location = New Point(ddl.Location.X, ddl.Location.Y)
                            .Size = New Size(80, 20)
                            .Text = "*** Hover me!"
                            .BringToFront()
                        End With
                        With ddl
                            .Visible = False
                            .Enabled = False
                        End With
                        SetToolTip(lbl, String.Format("Parameter {0} not found in Store Procedure {1}.{2}Perhaps the Stored Procedure is not up to date?",
                                                      tagValue, ddlSprocs.SelectedItem, Environment.NewLine))
                        tcFilters.TabPages.Item(0).Controls.Add(lbl)
                    End If

                    If TypeOf (ctrl) Is TextBox Then
                        Dim txt As TextBox = ctrl
                        txt.Enabled = False
                        Dim lbl As New Label
                        With lbl
                            .Location = New Point(txt.Location.X, txt.Location.Y)
                            .Size = New Size(80, 20)
                            .Text = "*** Hover me!"
                            .BringToFront()
                        End With
                        With txt
                            .Visible = False
                            .Enabled = False
                        End With
                        SetToolTip(lbl, String.Format("Parameter {0} not found in Store Procedure {1}.{2}Perhaps the Stored Procedure is not up to date?",
                                                      tagValue, ddlSprocs.SelectedItem, Environment.NewLine))
                        tcFilters.TabPages.Item(0).Controls.Add(lbl)
                    End If

                End If

            End If

        Next


        If ddlServers.SelectedIndex > 0 Then

            For Each tab As TabPage In tcFilters.TabPages

                ' Iterate all controls in the tab control and look for controls where we should populate with databases.
                For Each ctrl In tab.Controls

                    If TypeOf (ctrl) Is ComboBox Then
                        Dim ddl As ComboBox = ctrl
                        If ddl.Name.Contains("Database") Then

                            With ddl
                                .Items.Clear()

                                For item As Integer = 0 To (databasesList.Rows.Count - 1)
                                    Dim dataRow As DataRow = databasesList.Rows(item)
                                    If Not "master|model|msdb|tempdb".Contains(dataRow.Item(0)) Then
                                        .Items.Add(dataRow.ItemArray(0))
                                    End If
                                Next

                                Select Case ddl.Name
                                    Case "ddlOutputDatabaseName_BlitzAnalysis"
                                        If .Items.Count = 1 Then
                                        Else
                                            .Items.Insert(0, "< Select >")
                                        End If
                                    Case Else
                                        .Items.Insert(0, "< All >")
                                End Select

                                .SelectedIndex = 0
                            End With

                        End If

                        If ddl.Name = "ddlDatabaseName_BlitzAnalysis" Then
                            ddl.Items.Clear()
                        End If

                    End If

                Next

            Next

        End If


        ' ==================================================================================================================
        ' Load any saved settings (parameters).
        Dim fileName As String = String.Empty

        If My.Computer.FileSystem.FileExists(fileName) Then

            Dim paramString As String = My.Computer.FileSystem.ReadAllText(fileName)
            ' I.e. @IgnorePrioritiesAbove = '100', @CheckServerInfo = 1, @CheckUserDatabaseObjects = 1

            Dim paramsList As New List(Of String)(paramString.Split(New String() {","}, StringSplitOptions.RemoveEmptyEntries))

            For Each param As String In paramsList

                param = param.Replace("@", "").Replace("'", "").Replace(" = ", "=").Replace("= ", "=").Replace(" =", "=").Trim().ToLower()

                ' Iterate all controls in the selected tab control.
                For Each ctrl In tcFilters.TabPages.Item(0).Controls

                    Dim tagValue As String = String.Empty

                    If TypeOf (ctrl) Is CheckBox Then
                        Dim chk As CheckBox = ctrl
                        tagValue = chk.Tag.ToString().Split(";").First().ToLower()
                        If chk.Visible = True Then ' We have a few hidden check boxes that should not be affected.
                            If tagValue = param.Split("=").First.Trim() Then
                                If param.Split("=").Last.Trim() = "1" Then
                                    chk.Checked = True
                                Else
                                    chk.Checked = False
                                End If
                            End If
                        End If
                    End If

                    If TypeOf (ctrl) Is ComboBox Then
                        Dim ddl As ComboBox = ctrl
                        If ddl.Tag.tolower() = param.Split("=").First.Trim() Then
                            ddl.SelectedItem = param.Split("=").Last.Trim().Replace("'", "")
                        End If
                    End If

                    If TypeOf (ctrl) Is TextBox Then
                        Dim txt As TextBox = ctrl
                        If txt.Tag.tolower() = param.Split("=").First.Trim() Then
                            txt.Text = param.Split("=").Last.Trim().Replace("'", "")
                        End If
                    End If

                Next

            Next

        End If

        ' Save the selected stored procedure op we can load it as default the next time this server is selected.
        Dim selectedServer As String = ddlServers.SelectedItem
        Dim serverList As List(Of ServerInfo) = Data.Servers_List()
        Dim serverInfo As ServerInfo = serverList.Find(Function(s) s.serverName = selectedServer)
        serverList.Remove(serverInfo)
        serverInfo.storedProcedure = ddlSprocs.SelectedItem
        serverList.Add(serverInfo)
        Data.Server_Save(serverList)

    End Sub

    Private Sub cmdExecute_Click(sender As Object, e As EventArgs) Handles cmdExecute.Click

        txtSQL.Text = String.Empty
        pnlButtons.Controls.Clear()
        dgvResults.Visible = False
        cmdExportToExcel.Visible = False
        cmdOpenExcelFolder.Visible = False

        ' Check selections
        Dim sbErrors As New StringBuilder

        If ddlServers.SelectedIndex = 0 Then
            sbErrors.AppendLine("No SQL server selected!")
        End If

        ' Common
        If ddlSprocs.SelectedIndex = 0 Then
            sbErrors.AppendLine("No sproc selected!")
        End If

        ' sp_BlitzAnalysis
        If ddlSprocs.SelectedItem = "sp_BlitzAnalysis" Then
            If ddlOutputDatabaseName_BlitzAnalysis.SelectedIndex = 0 Then
                sbErrors.AppendLine("OutputDatabaseName is not selected!")
            End If
        End If

        If Not String.IsNullOrEmpty(sbErrors.ToString()) Then
            MessageBox.Show(sbErrors.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        parameters = ScanForParameters()

        If Not String.IsNullOrEmpty(warningMessage) Then
            Cursor = Cursors.Default
            MessageBox.Show(warningMessage)
            warningMessage = String.Empty
            Exit Sub
        End If

        Dim sql As New StringBuilder()
        If database = "master" Then
            sql.AppendLine(String.Format("USE [{0}]", ddlDatabases.SelectedItem))
        End If
        sql.AppendLine(String.Format("EXEC {0} {1}", ddlSprocs.SelectedItem, parameters))

        dataSet =
            Data.AsDataSet(ddlServers.SelectedItem, sql.ToString(), CommandType.Text)

        Dim resultIndexs As Integer = dataSet.Tables.Count - 1
        Dim btnArray(resultIndexs) As System.Windows.Forms.Button
        Dim xPos As Integer = 0
        Dim yPos As Integer = 0

        For index As Integer = 0 To resultIndexs
            btnArray(index) = New System.Windows.Forms.Button
            With btnArray(index)
                .Tag = index
                .Width = 60
                .Height = 25
                .Left = xPos
                .Top = yPos
                .Text = "Result " & (index + 1).ToString()
                If index = 0 Then
                    .BackColor = System.Drawing.SystemColors.Highlight
                    .ForeColor = System.Drawing.SystemColors.ButtonHighlight
                End If
                pnlButtons.Controls.Add(btnArray(index))
                xPos += .Width + 10
                AddHandler .Click, AddressOf ClickButton
            End With
        Next

        DisplayResult(0)

        dgvResults.Visible = True
        cmdExportToExcel.Visible = True
        cmdOpenExcelFolder.Visible = True

        txtSQL.Text = sql.ToString()

        Cursor = Cursors.Default

    End Sub

    Public Sub ClickButton(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click

        For Each cntrl In pnlButtons.Controls
            If TypeOf (cntrl) Is Button Then
                Dim btn As Button = cntrl
                With btn
                    .BackColor = System.Drawing.SystemColors.Control
                    .ForeColor = System.Drawing.SystemColors.ControlText
                End With
            End If
        Next

        If TypeOf (sender) Is Button Then
            Dim btn As Button = sender
            If IsNumeric(btn.Tag) Then
                With btn
                    .BackColor = System.Drawing.SystemColors.Highlight
                    .ForeColor = System.Drawing.SystemColors.ButtonHighlight
                    DisplayResult(.Tag)
                End With
            End If
        End If

    End Sub

    Private Sub DisplayResult(index As Integer)

        If dataSet.Tables.Count = 0 Then

            dataTable = New DataTable
            pnlButtons.Controls.Clear()

        Else

            dataTable = dataSet.Tables(index)

            Dim removeColumnList As New List(Of Integer)
            Dim columnCounter As Integer = 0

            For Each c In dataTable.Columns

                Select Case c.DataType.ToString()
                    Case "System.Byte[]"
                        removeColumnList.Add(columnCounter)
                End Select

                Select Case c.ColumnName
                    Case "Query Plan"
                        removeColumnList.Add(columnCounter)
                End Select

                columnCounter += 1

            Next

            For Each col As Integer In removeColumnList
                dataTable.Columns(col).ColumnMapping = MappingType.Hidden
            Next

        End If

        ' Populate grid
        With dgvResults
            .DataSource = dataTable
            .AutoResizeColumns()
        End With

        ' Restore down column width for thoose column holding wide data.
        Dim maxWidth As Integer = 200
        If dgvResults.Columns.Count > 1 Then
            For Each column As DataGridViewColumn In dgvResults.Columns
                If column.Width > maxWidth Then
                    column.Width = maxWidth
                End If
            Next
        End If

    End Sub

    Private Function ScanForParameters() As String

        Dim returnString As String = String.Empty
        Dim returnStringAddition As String = String.Empty
        Dim paramName As String = String.Empty
        Dim paramValue As String = String.Empty
        Dim defaultValue As String = String.Empty

        If tcFilters.TabPages.Item(0).Controls.Count = 0 Then
            Return String.Empty
        End If

        Select Case ddlSprocs.SelectedItem
            Case "sp_BlitzFirst"
                If ddlOutputType_BlitzFirst.SelectedItem = "TOP10" Then
                    chkSinceStartup_BlitzFirst.Checked = True
                End If
        End Select

        For Each ctrl In tcFilters.TabPages.Item(0).Controls

            Dim chk As CheckBox = Nothing
            Dim ddl As ComboBox = Nothing
            Dim txt As TextBox = Nothing

            If TypeOf (ctrl) Is CheckBox Then
                chk = ctrl
                If chk.Enabled = False Then Continue For
            End If

            If TypeOf (ctrl) Is ComboBox Then
                ddl = ctrl
                If ddl.Enabled = False Then Continue For
            End If

            If TypeOf (ctrl) Is TextBox Then
                txt = ctrl
                If txt.Enabled = False Then Continue For
            End If

            If TypeOf (ctrl) Is CheckBox Then

                paramName = chk.Tag.ToString().Split(";").First()

                Select Case ddlSprocs.SelectedItem

                    Case "sp_BlitzLock"
                        If chk.Name = "chkUseBelowDate_Internal_BlitzLock" Then
                            If chk.Checked Then
                                returnString &= String.Format("@StartDate = '{0} {1}', @EndDate = '{2} {3}', ",
                                                               dtpStartDate_BlitzLock.Value.ToString("yyyy-MM-dd"),
                                                               dtpStartTime_BlitzLock.Value.ToString("HH:mm:ss"),
                                                               dtpEndDate_BlitzLock.Value.ToString("yyyy-MM-dd"),
                                                               dtpEndTime_BlitzLock.Value.ToString("HH:mm:ss"))
                            End If
                        End If

                    Case Else
                        ' If checked but default value is False (0)
                        If (chk.Checked = True) AndAlso (chk.Tag.ToString().Split(";").Last() = 0) Then
                            returnString &= "@" & paramName & " = 1, "
                        End If
                        ' If not checked but default value is True (1)
                        If (chk.Checked = False) AndAlso (chk.Tag.ToString().Split(";").Last() = 1) Then
                            returnString &= "@" & paramName & " = 0, "
                        End If

                End Select

            End If

            If TypeOf (ctrl) Is ComboBox Then

                If ddl.SelectedItem Is Nothing Then
                    Continue For
                End If

                paramName = ddl.Tag.ToString().Split(";").First()
                defaultValue = ddl.Tag.ToString().Split(";").Last()

                If ddl.SelectedItem = "< All >" Then
                    Continue For
                End If

                If ddl.SelectedItem.ToString.Contains("Default") Then
                    Continue For
                End If

                Dim selectedItem As String = ddl.SelectedItem.ToString
                If selectedItem.Contains("(") Then
                    selectedItem = selectedItem.Substring(0, selectedItem.IndexOf("(")).Trim()
                End If

                Select Case ddlSprocs.SelectedItem

                    Case "sp_Blitz"
                        ' Check if CheckUserDatabaseObjects is checked.
                        ' If so, check that there aren't more than 50 databases present.
                        ' If so, BringThePain must be checked.
                        If (chkCheckUserDatabaseObjects_Blitz.Checked = True) And (ddlDatabaseName_BlitzCache.Items.Count > 50) And (chkBringThePain_Blitz.Checked = False) Then
                            warningMessage = "Running sp_Blitz with CheckUserDatabaseObjects Checked on a server with 50+ databases (as you have) may cause temporary insanity for the server and/or user." & Environment.NewLine & "If you're sure you want to do this, run again with the parameter BringThePain Checked."
                            Exit Function
                        End If
                        If selectedItem <> defaultValue Then
                            returnString &= "@" & paramName & " = '" & selectedItem & "', "
                        End If

                    Case "sp_BlitzAnalysis"

                        If (ddl.Name.StartsWith("ddlOutputTableName")) Then
                            If (ddl.SelectedItem <> "< Select >") Then
                                returnString &= "@" & paramName & " = '" & selectedItem & "', "
                            End If
                        Else
                            returnString &= "@" & paramName & " = '" & selectedItem & "', "
                        End If

                    Case "sp_BlitzCache"

                        If ddlSortOrder_BlitzCache.SelectedItem.ToString().Contains("All") Then
                            returnStringAddition = "/* When selecting 'All' or 'All Avg', the only parameters you can use are @Top and @DatabaseName. All others will be ignored. */"
                        End If

                        Select Case ddl.Name
                            Case "ddlStoredProcName_BlitzCache"
                                If ddlStoredProcName_BlitzCache.SelectedItem <> "< Select >" Then
                                    returnString &= "@" & paramName & " = '" & selectedItem & "', "
                                End If
                            Case Else
                                returnString &= "@" & paramName & " = '" & selectedItem & "', "
                        End Select

                    'Case "sp_BlitzFirst"

                    '    Dim chkList As New List(Of String)
                    '    If chkBlitzWhoStart_BlitzFirst.Checked = True Then chkList.Add("BlitzWho_Start")
                    '    If chkFindings_BlitzFirst.Checked = True Then chkList.Add("Findings")
                    '    If chkFileStats_BlitzFirst.Checked = True Then chkList.Add("FileStats")
                    '    If chkPerfmonStats_BlitzFirst.Checked = True Then chkList.Add("PerfmonStats")
                    '    If chkWaitStats_BlitzFirst.Checked = True Then chkList.Add("WaitStats")
                    '    If chkBlitzCache_BlitzFirst.Checked = True Then chkList.Add("BlitzCache")
                    '    If chkBlitzWhoEnd_BlitzFirst.Checked = True Then chkList.Add("BlitzWho_End")

                    '    returnString &= String.Join("|", chkList.ToList)

                    Case "sp_BlitzIndex"

                        Select Case ddl.Name

                            Case "ddlTableName_BlitzIndex"
                                If chkGetAllDatabases_BlitzIndex.Checked = False Then
                                    If Not selectedItem = "< Select >" Then
                                        returnString &= "@DatabaseName = '" & ddlDatabaseName_BlitzIndex.SelectedItem & "', "
                                        returnString &= "@SchemaName = '" & ddlSchemaName_BlitzIndex.SelectedItem & "', "
                                        returnString &= "@" & paramName & " = '" & selectedItem & "', "
                                    Else
                                        returnString &= "@DatabaseName = '" & ddlDatabaseName_BlitzIndex.SelectedItem & "', "
                                    End If
                                End If

                            Case "ddlMode_BlitzIndex"
                                ' 0=Diagnose, 1=Summarize, 2=Index Usage Detail, 3=Missing Index Detail, 4=Diagnose Details
                                ' Note: @Mode doesn't matter if you're specifying schema_name and @TableName.
                                Select Case selectedItem 'ddl.SelectedItem
                                    'Case "Diagnose"
                                    '    paramValue = "0"
                                    Case "Summarize"
                                        paramValue = "1"
                                    Case "Index Usage Detail"
                                        paramValue = "2"
                                    Case "Missing Index Detail"
                                        paramValue = "3"
                                    Case "Diagnose Details"
                                        paramValue = "4"
                                End Select

                                If Not String.IsNullOrEmpty(paramValue) Then
                                    returnString &= "@" & paramName & " = '" & paramValue & "', "

                                    If paramValue = "2" Then

                                        If ddlSortOrder_BlitzIndex.SelectedIndex > 0 Then

                                            If Not String.IsNullOrEmpty(ddlSortOrder_BlitzIndex.SelectedItem) Then

                                                paramValue = ddlSortOrder_BlitzIndex.SelectedItem
                                                returnString &= "@SortOrder = '" & paramValue & "', "

                                                If Not String.IsNullOrEmpty(ddlSortDirection_BlitzIndex.SelectedItem) Then
                                                    If Not ddlSortDirection_BlitzIndex.SelectedItem.ToString().Contains("Default") Then
                                                        paramValue = ddlSortDirection_BlitzIndex.SelectedItem.replace(" (Default)", String.Empty)
                                                        returnString &= "@SortDirection = '" & paramValue & "', "
                                                    End If
                                                End If

                                            End If

                                        End If

                                    End If

                                End If

                        End Select

                    Case "sp_BlitzLock"

                        If ddl.Name = "ddlTableName_Internal_BlitzLock" Then
                            If Not selectedItem = "< Select >" Then
                                returnString &= String.Format("@ObjectName = '{0}.{1}.{2}', ",
                                                              ddlDatabaseName_BlitzLock.SelectedItem,
                                                              ddlSchemaName_Internal_BlitzLock.SelectedItem,
                                                              ddlTableName_Internal_BlitzLock.SelectedItem)
                            End If
                        End If

                        If ddl.Name = "ddlStoredProcName_BlitzLock" Then
                            If Not selectedItem = "< Select >" Then
                                returnString &= String.Format("@StoredProcName = '{0}.{1}.{2}', ",
                                                              ddlDatabaseName_BlitzLock.SelectedItem,
                                                              ddlSchemaName_Internal_BlitzLock.SelectedItem,
                                                              ddlStoredProcName_BlitzLock.SelectedItem)
                            End If
                        End If

                    Case Else

                        If Not String.IsNullOrEmpty(selectedItem) Then
                            If selectedItem <> defaultValue Then
                                paramValue = selectedItem
                            End If
                        End If

                        If Not String.IsNullOrEmpty(paramValue) Then
                            returnString &= "@" & paramName & " = '" & paramValue & "', "
                        End If

                End Select

            End If

            If TypeOf (ctrl) Is TextBox Then
                paramName = txt.Tag.ToString().Split(";").First()
                Dim tags As String() = txt.Tag.ToString().Split(";")
                defaultValue = txt.Tag.ToString().Split(";").Last()
                If tags.Length < 2 Then
                    defaultValue = String.Empty
                End If
                paramValue = txt.Text
                If Not String.IsNullOrEmpty(paramValue) Then
                    If Not String.IsNullOrEmpty(defaultValue) Then
                        If paramValue <> defaultValue Then
                            If txt.Name.StartsWith("str") Then
                                paramValue = "'" & paramValue & "'"
                            End If
                            returnString &= "@" & paramName & " = " & paramValue & ", "
                        End If
                    Else
                        If txt.Name.StartsWith("str") Then
                            paramValue = "'" & paramValue & "'"
                        End If
                        returnString &= "@" & paramName & " = " & paramValue & ", "
                    End If
                End If
            End If

            paramName = String.Empty
            paramValue = String.Empty

        Next

        Select Case ddlSprocs.SelectedItem

            Case "sp_BlitzAnalysis"
                returnString &= String.Format("@StartDate = '{0} {1}', @EndDate = '{2} {3}', ",
                                              dtpStartDate_BlitzAnalysis.Value.ToString("yyyy-MM-dd"),
                                              dtpStartTime_BlitzAnalysis.Value.ToString("HH:mm:ss"),
                                              dtpEndDate_BlitzAnalysis.Value.ToString("yyyy-MM-dd"),
                                              dtpEndTime_BlitzAnalysis.Value.ToString("HH:mm:ss"))

            Case "sp_BlitzQueryStore"
                returnString &= String.Format("@StartDate = '{0} {1}', @EndDate = '{2} {3}', ",
                                              dtpStartDate_BlitzQueryStore.Value.ToString("yyyy-MM-dd"),
                                              dtpStartTime_BlitzQueryStore.Value.ToString("HH:mm:ss"),
                                              dtpEndDate_BlitzQueryStore.Value.ToString("yyyy-MM-dd"),
                                              dtpEndTime_BlitzQueryStore.Value.ToString("HH:mm:ss"))

            Case "sp_BlitzFirst"
                Dim chkList As New List(Of String)
                If chkBlitzWhoStart_BlitzFirst.Checked = True Then chkList.Add("BlitzWho_Start")
                If chkFindings_BlitzFirst.Checked = True Then chkList.Add("Findings")
                If chkFileStats_BlitzFirst.Checked = True Then chkList.Add("FileStats")
                If chkPerfmonStats_BlitzFirst.Checked = True Then chkList.Add("PerfmonStats")
                If chkWaitStats_BlitzFirst.Checked = True Then chkList.Add("WaitStats")
                If chkBlitzCache_BlitzFirst.Checked = True Then chkList.Add("BlitzCache")
                If chkBlitzWhoEnd_BlitzFirst.Checked = True Then chkList.Add("BlitzWho_End")

                Dim list As String = String.Join("|", chkList.ToList)
                If list <> "BlitzWho_Start|Findings|FileStats|PerfmonStats|WaitStats|BlitzCache|BlitzWho_End" Then
                    returnString &= "@OutputResultSets = '" & list & "'"
                End If

        End Select

        If Not String.IsNullOrEmpty(returnString) Then
            If returnString.EndsWith(", ") Then
                returnString = returnString.Remove(returnString.Length - 2, 2)
            End If
        End If

        Return returnString.Trim() & " " & returnStringAddition.Trim()

    End Function

    Private Function GetFolders() As List(Of String)

        Dim rootPath As String = "Data"
        Dim returnList As New List(Of String)

        If Not My.Computer.FileSystem.DirectoryExists(rootPath) Then
            My.Computer.FileSystem.CreateDirectory(rootPath)
        End If

        Dim defaultPath As String = "Default"
        If Not My.Computer.FileSystem.DirectoryExists(Path.Combine(rootPath, defaultPath)) Then
            My.Computer.FileSystem.CreateDirectory(Path.Combine(rootPath, defaultPath))
        End If

        Dim dir As New DirectoryInfo(rootPath)
        Dim directories As DirectoryInfo() =
            dir.GetDirectories().OrderBy(Function(p) p.Name).ToArray()

        For Each directory As DirectoryInfo In directories
            returnList.Add(directory.Name)
        Next

        Return returnList

    End Function

#Region "Excel"

    Private Sub cdmExportToExcel_Click(sender As Object, e As EventArgs) Handles cmdExportToExcel.Click

        Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory())

        Dim selectedItem As String = ddlServers.SelectedItem.Replace("\", "_").Replace(".", "Localhost")

        Dim fileName As String = String.Format("{0}_{1}",
                                                selectedItem,
                                                ddlSprocs.SelectedItem.replace("sp_", ""))

        Select Case ddlSprocs.SelectedItem

            Case "sp_BlitzAnalysis"

            Case "sp_BlitzCache"
                If ddlDatabaseName_BlitzCache.SelectedItem <> "< All >" Then
                    fileName &= String.Format("_{0}", ddlDatabaseName_BlitzCache.SelectedItem)
                    If ddlStoredProcName_BlitzCache.SelectedItem <> "< Select >" Then
                        fileName &= String.Format("_{0}", ddlStoredProcName_BlitzCache.SelectedItem)
                    End If
                End If

            Case "sp_BlitzIndex"
                If ddlDatabaseName_BlitzIndex.SelectedItem <> "< All >" Then
                    fileName &= String.Format("_{0}", ddlDatabaseName_BlitzIndex.SelectedItem)
                    If ddlSchemaName_BlitzIndex.SelectedItem <> "< Select >" Then
                        If ddlTableName_BlitzIndex.SelectedItem <> "< Select >" Then
                            fileName &= String.Format("_{0}", ddlSchemaName_BlitzIndex.SelectedItem)
                        End If
                    End If
                    If ddlTableName_BlitzIndex.SelectedItem <> "< Select >" Then
                        fileName &= String.Format("_{0}", ddlTableName_BlitzIndex.SelectedItem)
                    End If
                End If

            Case "sp_BlitzLock"
                If ddlDatabaseName_BlitzLock.SelectedItem <> "< All >" Then
                    fileName &= String.Format("_{0}", ddlDatabaseName_BlitzLock.SelectedItem)
                    If ddlSchemaName_Internal_BlitzLock.SelectedItem <> "< Select >" Then
                        If ddlTableName_Internal_BlitzLock.SelectedItem <> "< Select >" Then
                            fileName &= String.Format("_{0}", ddlSchemaName_Internal_BlitzLock.SelectedItem)
                        End If
                    End If
                    If ddlTableName_Internal_BlitzLock.SelectedItem <> "< Select >" Then
                        fileName &= String.Format("_{0}", ddlTableName_Internal_BlitzLock.SelectedItem)
                    End If
                    If ddlStoredProcName_BlitzLock.SelectedItem <> "< Select >" Then
                        fileName &= String.Format("_{0}", ddlStoredProcName_BlitzLock.SelectedItem)
                    End If
                End If

            Case "sp_BlitzQueryStore"
                If ddlDatabaseName_BlitzQueryStore.SelectedItem <> "< All >" Then
                    fileName &= String.Format("_{0}", ddlDatabaseName_BlitzCache.SelectedItem)
                    If ddlStoredProcName_BlitzQueryStore.SelectedItem <> "< Select >" Then
                        fileName &= String.Format("_{0}", ddlStoredProcName_BlitzQueryStore.SelectedItem)
                    End If
                End If

            Case Else

        End Select

        fileName &= String.Format("__{0}.xlsx", Common.GetDateTimeStringForFilename)

        Dim folder As String = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory(), Constants.ExcelExportRootFolder, selectedItem)
        If Not My.Computer.FileSystem.DirectoryExists(folder) Then
            My.Computer.FileSystem.CreateDirectory(Path.Combine(folder))
        End If

        Dim fileInfo As FileInfo = New FileInfo(Path.Combine(folder, fileName))

        If fileInfo.Exists Then
            fileInfo.Delete()
            fileInfo = New FileInfo(Path.Combine(folder, fileName))
        End If

        Dim cmd As String = String.Format("{0} {1}", ddlSprocs.SelectedItem, parameters)
        Dim topRangeRow As Integer = 4

        Try

            Using pck As New ExcelPackage(fileInfo)

                For index As Integer = 0 To (dataSet.Tables.Count - 1)

                    dataTable = dataSet.Tables(index)

                    ' Create the worksheet
                    Dim ws As ExcelWorksheet = pck.Workbook.Worksheets.Add("Result_" & (index + 1).ToString())

                    ' Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                    ws.Cells("A4").LoadFromDataTable(dataTable, True)

                    ' Format the header
                    Using rng As ExcelRange = ws.Cells(topRangeRow, 1, topRangeRow, dataTable.Columns.Count)
                        rng.Style.Font.Bold = True
                        rng.Style.Fill.PatternType = ExcelFillStyle.Solid
                        ' Set Pattern for the background to Solid
                        rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189))
                        ' Set color to dark blue
                        rng.Style.Font.Color.SetColor(Color.White)
                    End Using

                    ' Autofit all columns
                    ws.Cells.AutoFitColumns()

                    ' But check that we don't have to wide columns
                    For col As Integer = 1 To dataTable.Columns.Count
                        If ws.Column(col).Width > 40 Then
                            ws.Column(col).Width = 40
                        End If
                    Next

                    ' Enter command
                    ws.Cells("A2").Value = cmd
                    ws.Cells("A2").Style.Font.Bold = True

                Next

                pck.Save()

            End Using

            excelFolder = folder

            MessageBox.Show(Path.Combine(folder, fileName), "Excel file created", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmdOpenExcelFolder_Click(sender As Object, e As EventArgs) Handles cmdOpenExcelFolder.Click

        If String.IsNullOrEmpty(excelFolder) Then
            excelFolder = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory(), Constants.ExcelExportRootFolder)
            If Not My.Computer.FileSystem.DirectoryExists(excelFolder) Then
                My.Computer.FileSystem.CreateDirectory(excelFolder)
            End If
        End If

        Process.Start("explorer.exe", excelFolder)

    End Sub

#End Region

#Region "Tooltips"

    Private Sub SetToolTips()

        ' Common
        'SetToolTip(lblDatabase, "Select the database where the sp_Blitz sprocs are located.")

        ' sp_Blitz
        SetToolTip(chkCheckUserDatabaseObjects_Blitz, "Checked = review user databases for triggers, heaps, etc. Takes more time for more databases and objects.")
        SetToolTip(chkCheckServerInfo_Blitz, "Checked = Show server info like CPUs, memory, virtualization.")
        SetToolTip(chkCheckProcedureCache_Blitz, "Checked = Top 20-50 resource-intensive cache plans and analyze them for common performance issues.")
        SetToolTip(chkOutputProcedureCache_Blitz, "Checked = Output the top 20-50 resource-intensive plans even if they did not trigger an alarm.")
        'SetToolTip(chkCheckUserDatabaseObjects_Blitz, "")
        'SetToolTip(chkCheckUserDatabaseObjects_Blitz, "")
        'SetToolTip(chkCheckUserDatabaseObjects_Blitz, "")
        'SetToolTip(chkCheckUserDatabaseObjects_Blitz, "")
        'SetToolTip(chkCheckUserDatabaseObjects_Blitz, "")

        ' sp_BlitzAnalysis

        ' sp_BlitzBackups

        ' sp_BlitzCache

        ' sp_BlitzFirst

        ' sp_BlitzIndex

        ' sp_BlitzLock

        ' sp_BlitzWho

    End Sub

    Private Sub SetToolTip(ctrl As Control, caption As String, Optional title As String = "")

        Dim toolTip As New ToolTip
        With toolTip
            '.ShowAlways = True
            If Not String.IsNullOrEmpty(title) Then
                .ToolTipTitle = title
            End If
            .SetToolTip(ctrl, caption)
        End With

    End Sub

#End Region

#Region "Blitz"

    ' ==================================
    ' Blitz
    ' ==================================

#End Region

#Region "BlitzAnalysis"

    ' ==================================
    ' BlitzAnalysis
    ' ==================================

    Private Sub ddlOutputDatabaseName_BlitzAnalysis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlOutputDatabaseName_BlitzAnalysis.SelectedIndexChanged

        With ddlOutputSchemaName_BlitzAnalysis

            .Items.Clear()

            Dim schemasList As New DataTable

            If ddlOutputDatabaseName_BlitzAnalysis.SelectedItem <> "< Select >" Then

                ' List schemas for selected database
                schemasList =
                    Data.Schemas(ddlServers.SelectedItem, ddlOutputDatabaseName_BlitzAnalysis.SelectedItem)

                If schemasList.Rows.Count > 1 Then
                    .Items.Add("< Select >")
                End If

                For item As Integer = 0 To (schemasList.Rows.Count - 1)
                    Dim dataRow As DataRow = schemasList.Rows(item)
                    .Items.Add(dataRow.ItemArray(0))
                Next

                If schemasList.Rows.Count = 1 Then
                    .SelectedIndex = 0
                    ' Populate tables dropdown
                    Populate_TableNames_BlitzAnalysis()
                End If

            Else

                ' Clear the schemas dropdown
                With ddlOutputSchemaName_BlitzAnalysis
                    .Items.Clear()
                    .Text = String.Empty
                    .Enabled = False
                End With

                ' Clear the tables dropdown
                For Each ctrl In tcFilters.TabPages.Item(0).Controls
                    If TypeOf (ctrl) Is ComboBox Then
                        Dim ddl As ComboBox = ctrl
                        If (ddl.Name.StartsWith("ddlOutputTableName")) Then
                            ddl.Items.Clear()
                            ddl.Text = String.Empty
                            ddl.Enabled = False
                        End If
                    End If
                Next

            End If

            If schemasList.Rows.Count = 0 Then
                .Enabled = False
            Else
                .Enabled = True
            End If

        End With

    End Sub

    Private Sub ddlOutputSchemaName_BlitzAnalysis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlOutputSchemaName_BlitzAnalysis.SelectedIndexChanged

        Populate_TableNames_BlitzAnalysis()

    End Sub

    Private Sub Populate_TableNames_BlitzAnalysis()

        Dim tablesList As DataTable =
            Data.Tables(ddlServers.SelectedItem, ddlOutputDatabaseName_BlitzAnalysis.SelectedItem, ddlOutputSchemaName_BlitzAnalysis.SelectedItem)

        For Each ctrl In tcFilters.TabPages.Item(0).Controls
            If TypeOf (ctrl) Is ComboBox Then
                Dim ddl As ComboBox = ctrl
                If (ddl.Name.StartsWith("ddlOutputTableName")) Then
                    ddl.Items.Clear()
                    ddl.Items.Add("< Select or leave to not include >")
                    ddl.SelectedIndex = 0
                    ddl.Enabled = True

                    For item As Integer = 0 To (tablesList.Rows.Count - 1)
                        Dim dataRow As DataRow = tablesList.Rows(item)
                        ddl.Items.Add(dataRow.ItemArray(0))
                        If dataRow.ItemArray(0).ToString() = "BlitzFirst" And ddl.Name = "ddlOutputTableNameBlitzFirst_BlitzAnalysis" Then ddl.SelectedIndex = item + 1
                        If dataRow.ItemArray(0).ToString() = "BlitzFirst_FileStats" And ddl.Name = "ddlOutputTableNameFileStats_BlitzAnalysis" Then ddl.SelectedIndex = item + 1
                        If dataRow.ItemArray(0).ToString() = "BlitzFirst_PerfmonStats" And ddl.Name = "ddlOutputTableNamePerfmonStats_BlitzAnalysis" Then ddl.SelectedIndex = item + 1
                        If dataRow.ItemArray(0).ToString() = "BlitzFirst_WaitStats" And ddl.Name = "ddlOutputTableNameWaitStats_BlitzAnalysis" Then ddl.SelectedIndex = item + 1
                        If dataRow.ItemArray(0).ToString() = "BlitzCache" And ddl.Name = "ddlOutputTableNameBlitzCache_BlitzAnalysis" Then ddl.SelectedIndex = item + 1
                        If dataRow.ItemArray(0).ToString() = "BlitzWho" And ddl.Name = "ddlOutputTableNameBlitzWho_BlitzAnalysis" Then ddl.SelectedIndex = item + 1
                    Next

                    If ddl.Items.Count = 1 Then
                        ddl.Items.Clear()
                        ddl.Text = String.Empty
                        ddl.Enabled = False
                    End If

                End If

            End If
        Next

    End Sub

#End Region

#Region "BlitzBackups"

    ' ==================================
    ' BlitzBackups
    ' ==================================

#End Region

#Region "BlitzCache"

    ' ==================================
    ' BlitzCache
    ' ==================================

    Private Sub ddlDatabaseName_BlitzCache_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDatabaseName_BlitzCache.SelectedIndexChanged

        If ddlDatabaseName_BlitzCache.SelectedItem <> "< All >" Then

            Dim sprocsList As DataTable =
                Data.Sprocs(ddlServers.SelectedItem, ddlDatabaseName_BlitzCache.SelectedItem, String.Empty)

            With ddlStoredProcName_BlitzCache

                .Items.Clear()

                .Items.Add("< Select >")

                For item As Integer = 0 To (sprocsList.Rows.Count - 1)
                    Dim dataRow As DataRow = sprocsList.Rows(item)
                    .Items.Add(dataRow.ItemArray(0))
                Next

                If sprocsList.Rows.Count > 0 Then
                    .SelectedIndex = 0
                End If
                .Enabled = True

            End With

        Else

            With ddlStoredProcName_BlitzCache
                .Items.Clear()
                .Enabled = False
            End With

        End If

    End Sub
#End Region

#Region "BlitzFirst"

    ' ==================================
    ' BlitzFirst
    ' ==================================

    Private Sub ddlOutputType_BlitzFirst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlOutputType_BlitzFirst.SelectedIndexChanged
        If ddlOutputType_BlitzFirst.SelectedItem = "TOP10" Then
            chkSinceStartup_BlitzFirst.Checked = True
        Else
            chkSinceStartup_BlitzFirst.Checked = False
        End If
    End Sub

#End Region

#Region "BlitzIndex"

    ' ==================================
    ' BlitzIndex
    ' ==================================

    Private Sub ddlDatabaseName_BlitzIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDatabaseName_BlitzIndex.SelectedIndexChanged

        With ddlSchemaName_BlitzIndex

            .Items.Clear()

            Dim schemasList As New DataTable

            If ddlDatabaseName_BlitzIndex.SelectedItem <> "< All >" Then

                ' List schemas for selected database
                schemasList =
                    Data.Schemas(ddlServers.SelectedItem, ddlDatabaseName_BlitzIndex.SelectedItem)

                If schemasList.Rows.Count > 1 Then
                    .Items.Add("< Select >")
                End If

                For item As Integer = 0 To (schemasList.Rows.Count - 1)
                    Dim dataRow As DataRow = schemasList.Rows(item)
                    .Items.Add(dataRow.ItemArray(0))
                Next

                If schemasList.Rows.Count = 1 Then
                    .SelectedIndex = 0
                    ' Populate tables dropdown
                    Populate_ddlTableName_BlitzIndex(ddlSchemaName_BlitzIndex.SelectedItem)
                End If

            Else

                ' Clear the schemas dropdown
                With ddlSchemaName_BlitzIndex
                    .Items.Clear()
                    .Enabled = False
                End With

                ' Clear the tables dropdown
                With ddlTableName_BlitzIndex
                    .Items.Clear()
                    .Enabled = False
                End With

            End If

            If schemasList.Rows.Count = 0 Then
                .Enabled = False
            Else
                .Enabled = True
            End If

        End With

    End Sub

    Private Sub ddlSchemaName_BlitzIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSchemaName_BlitzIndex.SelectedIndexChanged

        ' Populate tables dropdown
        Populate_ddlTableName_BlitzIndex(ddlSchemaName_BlitzIndex.SelectedItem)

    End Sub

    Private Sub Populate_ddlTableName_BlitzIndex(schemaName As String)

        Dim tablesList As New DataTable

        With ddlTableName_BlitzIndex

            .Items.Clear()

            tablesList =
                Data.Tables(ddlServers.SelectedItem, ddlDatabaseName_BlitzIndex.SelectedItem, ddlSchemaName_BlitzIndex.SelectedItem)

            If tablesList.Rows.Count > 1 Then
                .Items.Add("< Select >")
            End If

            For item As Integer = 0 To (tablesList.Rows.Count - 1)
                Dim dataRow As DataRow = tablesList.Rows(item)
                .Items.Add(dataRow.ItemArray(0))
            Next

            If tablesList.Rows.Count = 0 Then
                .Enabled = False
            Else
                .Enabled = True
                .SelectedIndex = 0
            End If

        End With

    End Sub

#End Region

#Region "BlitzLock"

    ' ==================================
    ' BlitzLock
    ' ==================================

    Private Sub ddlDatabaseName_BlitzLock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDatabaseName_BlitzLock.SelectedIndexChanged

        With ddlSchemaName_Internal_BlitzLock

            .Items.Clear()

            Dim schemasList As New DataTable

            If ddlDatabaseName_BlitzLock.SelectedItem <> "< All >" Then

                ' List schemas for selected database
                schemasList =
                    Data.Schemas(ddlServers.SelectedItem, ddlDatabaseName_BlitzLock.SelectedItem)

                If schemasList.Rows.Count > 1 Then
                    .Items.Add("< Select >")
                End If

                For item As Integer = 0 To (schemasList.Rows.Count - 1)
                    Dim dataRow As DataRow = schemasList.Rows(item)
                    .Items.Add(dataRow.ItemArray(0))
                Next

                If schemasList.Rows.Count = 1 Then
                    .SelectedIndex = 0
                    ' Populate tables dropdown
                    Populate_ddlTableName_BlitzLock(ddlSchemaName_BlitzIndex.SelectedItem)
                    Populate_ddlSprocName_BlitzLock(ddlSchemaName_BlitzIndex.SelectedItem)
                End If

            Else

                ' Clear the schemas dropdown
                With ddlSchemaName_Internal_BlitzLock
                    .Items.Clear()
                    .Enabled = False
                End With

                ' Clear the tables dropdown
                With ddlTableName_Internal_BlitzLock
                    .Items.Clear()
                    .Enabled = False
                End With

                ' Clear the stored procedures dropdown
                With ddlStoredProcName_BlitzLock
                    .Items.Clear()
                    .Enabled = False
                End With

            End If

            If schemasList.Rows.Count = 0 Then
                .Enabled = False
            Else
                .Enabled = True
            End If

        End With

    End Sub

    Private Sub Populate_ddlTableName_BlitzLock(schemaName As String)

        Dim tablesList As New DataTable

        With ddlTableName_Internal_BlitzLock

            .Items.Clear()

            tablesList =
                Data.Tables(ddlServers.SelectedItem, ddlDatabaseName_BlitzLock.SelectedItem, ddlSchemaName_Internal_BlitzLock.SelectedItem)

            If tablesList.Rows.Count > 1 Then
                .Items.Add("< Select >")
            End If

            For item As Integer = 0 To (tablesList.Rows.Count - 1)
                Dim dataRow As DataRow = tablesList.Rows(item)
                .Items.Add(dataRow.ItemArray(0))
            Next

            If tablesList.Rows.Count = 0 Then
                .Enabled = False
            Else
                .Enabled = True
                .SelectedIndex = 0
            End If

        End With

    End Sub

    Private Sub Populate_ddlSprocName_BlitzLock(schemaName As String)

        Dim tablesList As New DataTable

        With ddlStoredProcName_BlitzLock

            .Items.Clear()

            tablesList =
                Data.SprocsBySchemaName(ddlServers.SelectedItem, ddlDatabaseName_BlitzLock.SelectedItem, ddlSchemaName_Internal_BlitzLock.SelectedItem)

            If tablesList.Rows.Count > 1 Then
                .Items.Add("< Select >")
            End If

            For item As Integer = 0 To (tablesList.Rows.Count - 1)
                Dim dataRow As DataRow = tablesList.Rows(item)
                .Items.Add(dataRow.ItemArray(0))
            Next

            If tablesList.Rows.Count = 0 Then
                .Enabled = False
            Else
                .Enabled = True
                .SelectedIndex = 0
            End If

        End With

    End Sub
#End Region

#Region "BlitzQueryStore"

    ' ==================================
    ' BlitzQueryStore
    ' ==================================

    Private Sub ddlDatabaseName_BlitzQueryStore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDatabaseName_BlitzQueryStore.SelectedIndexChanged

        ' Load Stored Procedures

        If ddlDatabaseName_BlitzQueryStore.SelectedItem <> "< All >" Then

            Dim sprocsList As DataTable =
                Data.Sprocs(ddlServers.SelectedItem, ddlDatabaseName_BlitzQueryStore.SelectedItem, String.Empty)

            With ddlStoredProcName_BlitzQueryStore

                .Items.Clear()

                .Items.Add("< Select >")

                For item As Integer = 0 To (sprocsList.Rows.Count - 1)
                    Dim dataRow As DataRow = sprocsList.Rows(item)
                    .Items.Add(dataRow.ItemArray(0))
                Next

                If sprocsList.Rows.Count > 0 Then
                    .SelectedIndex = 0
                End If
                .Enabled = True

            End With

        Else

            With ddlStoredProcName_BlitzQueryStore
                .Items.Clear()
                .Enabled = False
            End With

        End If

    End Sub

#End Region

#Region "BlitzWho"

    ' ==================================
    ' BlitzWho
    ' ==================================

    Private Sub LoadRadioButtonsTimeout(rbList As List(Of String))

        Dim xPos As Integer = 10
        Dim yPos As Integer = 12
        Dim width As Integer = 35
        Dim checkedState As Boolean = True

        For Each s As String In rbList
            Dim rb As New System.Windows.Forms.RadioButton
            With rb
                .Width = width + (s.Length * 3)
                .Height = 25
                .Left = xPos
                .Top = yPos
                .Text = s
                .Tag = s
                .Checked = checkedState
                gbTimeOut.Controls.Add(rb)
                xPos += .Width
                AddHandler .Click, AddressOf ClickRadioButton
            End With
            If checkedState = True Then
                checkedState = False
                Common.TimeOut = s
            End If
        Next

        gbTimeOut.Width = (width * rbList.Count) + 35

    End Sub

#End Region

    Public Sub ClickRadioButton(sender As Object, e As System.EventArgs) Handles MyBase.Click

        If TypeOf (sender) Is RadioButton Then
            Dim rb As RadioButton = sender
            If rb.Checked Then
                Common.TimeOut = rb.Tag
            End If
        End If

    End Sub

    Private Sub sp_BlitzFirst_Click(sender As Object, e As EventArgs) Handles sp_BlitzFirst.Click

    End Sub
End Class
