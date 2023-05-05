<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BlitzDesktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlitzDesktop))
        Me.lblServers = New System.Windows.Forms.Label()
        Me.ddlServers = New System.Windows.Forms.ComboBox()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.lblSelectSproc = New System.Windows.Forms.Label()
        Me.ddlSprocs = New System.Windows.Forms.ComboBox()
        Me.cmdExecute = New System.Windows.Forms.Button()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.tcFilters = New System.Windows.Forms.TabControl()
        Me.sp_Blitz = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ddlCheckProcedureCacheFilter_Blitz = New System.Windows.Forms.ComboBox()
        Me.lblCheckProcedureCacheFilter_Blitz = New System.Windows.Forms.Label()
        Me.lblOutputType_Blitz = New System.Windows.Forms.Label()
        Me.ddlOutputType_Blitz = New System.Windows.Forms.ComboBox()
        Me.chkOutputProcedureCache_Blitz = New System.Windows.Forms.CheckBox()
        Me.chkCheckProcedureCache_Blitz = New System.Windows.Forms.CheckBox()
        Me.intIgnorePrioritiesAbove_Blitz = New System.Windows.Forms.TextBox()
        Me.intIgnorePrioritiesBelow_Blitz = New System.Windows.Forms.TextBox()
        Me.lblIgnorePrioritiesAbove_Blitz = New System.Windows.Forms.Label()
        Me.lblIgnorePrioritiesBelow_Blitz = New System.Windows.Forms.Label()
        Me.chkSkipBlockingChecks_Blitz = New System.Windows.Forms.CheckBox()
        Me.chkBringThePain_Blitz = New System.Windows.Forms.CheckBox()
        Me.chkSummaryMode_Blitz = New System.Windows.Forms.CheckBox()
        Me.chkCheckServerInfo_Blitz = New System.Windows.Forms.CheckBox()
        Me.chkCheckUserDatabaseObjects_Blitz = New System.Windows.Forms.CheckBox()
        Me.sp_BlitzAnalysis = New System.Windows.Forms.TabPage()
        Me.strDatabaseName_BlitzAnalysis = New System.Windows.Forms.TextBox()
        Me.strServerName_BlitzAnalysis = New System.Windows.Forms.TextBox()
        Me.intMaxDop_BlitzAnalysis = New System.Windows.Forms.TextBox()
        Me.lblMaxDop_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.chkBringThePain_BlitzAnalysis = New System.Windows.Forms.CheckBox()
        Me.intWriteLatencyThreshold = New System.Windows.Forms.TextBox()
        Me.lblWriteLatencyThreshold_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.intReadLatencyThreshold = New System.Windows.Forms.TextBox()
        Me.lblReadLatencyThreshold_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.intWaitStatsTop_BlitzAnalysis = New System.Windows.Forms.TextBox()
        Me.lblWaitStatsTop_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.ddlBlitzCacheSortOrder_BlitzAnalysis = New System.Windows.Forms.ComboBox()
        Me.lblBlitzCacheSortOrder_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.intMaxBlitzFirstPriority_BlitzAnalysis = New System.Windows.Forms.TextBox()
        Me.lblMaxBlitzFirstPriority_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.lblDatabaseName_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.lblServerName_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.ddlOutputTableNameFileStats_BlitzAnalysis = New System.Windows.Forms.ComboBox()
        Me.lblOutputTableNameFileStats_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.ddlOutputTableNamePerfmonStats_BlitzAnalysis = New System.Windows.Forms.ComboBox()
        Me.lblOutputTableNamePerfmonStats_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.ddlOutputTableNameBlitzCache_BlitzAnalysis = New System.Windows.Forms.ComboBox()
        Me.lblOutputTableNameBlitzCache_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.ddlOutputTableNameBlitzWho_BlitzAnalysis = New System.Windows.Forms.ComboBox()
        Me.lblOutputTableNameBlitzWho_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.ddlOutputTableNameWaitStats_BlitzAnalysis = New System.Windows.Forms.ComboBox()
        Me.lblOutputTableNameWaitStats_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.ddlOutputTableNameBlitzFirst_BlitzAnalysis = New System.Windows.Forms.ComboBox()
        Me.lblOutputTableNameBlitzFirst_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.ddlOutputSchemaName_BlitzAnalysis = New System.Windows.Forms.ComboBox()
        Me.lblOutputSchemaName_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.ddlOutputDatabaseName_BlitzAnalysis = New System.Windows.Forms.ComboBox()
        Me.lblOutputDatabaseName_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.dtpEndTime_BlitzAnalysis = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTime_BlitzAnalysis = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate_BlitzAnalysis = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.dtpStartDate_BlitzAnalysis = New System.Windows.Forms.DateTimePicker()
        Me.lblStartDate_BlitzAnalysis = New System.Windows.Forms.Label()
        Me.sp_BlitzBackups = New System.Windows.Forms.TabPage()
        Me.intHoursBack_BlitzBackups = New System.Windows.Forms.TextBox()
        Me.lblHoursBack_BlitzBackups = New System.Windows.Forms.Label()
        Me.sp_BlitzCache = New System.Windows.Forms.TabPage()
        Me.chkBringThePain_BlitzCache = New System.Windows.Forms.CheckBox()
        Me.chkSkipAanlysis_BlitzCache = New System.Windows.Forms.CheckBox()
        Me.strSlowlySearchPlansFor_BlitzCache = New System.Windows.Forms.TextBox()
        Me.intMinutesBack_BlitzCache = New System.Windows.Forms.TextBox()
        Me.lblMinutesBack_BlitzCache = New System.Windows.Forms.Label()
        Me.MinimumExecutionCount_BlitzCache = New System.Windows.Forms.TextBox()
        Me.lblMinimumExecutionCount_BlitzCache = New System.Windows.Forms.Label()
        Me.lblSlowlySearchPlansFor_BlitzCache = New System.Windows.Forms.Label()
        Me.ddlStoredProcName_BlitzCache = New System.Windows.Forms.ComboBox()
        Me.lblStoredProcName_BlitzCache = New System.Windows.Forms.Label()
        Me.ddlDatabaseName_BlitzCache = New System.Windows.Forms.ComboBox()
        Me.lblDatabaseName_BlitzCache = New System.Windows.Forms.Label()
        Me.ddlQueryFilter_BlitzCache = New System.Windows.Forms.ComboBox()
        Me.lblQueryFilter_BlitzCache = New System.Windows.Forms.Label()
        Me.chkIgnoreSystemDVs_BlitzCache = New System.Windows.Forms.CheckBox()
        Me.chkHideSummary_BlitzCache = New System.Windows.Forms.CheckBox()
        Me.intDurationFilter_BlitzCache = New System.Windows.Forms.TextBox()
        Me.lblDurationFilter_BlitzCache = New System.Windows.Forms.Label()
        Me.ddlSortOrder_BlitzCache = New System.Windows.Forms.ComboBox()
        Me.lblSortOrder_BlitzCache = New System.Windows.Forms.Label()
        Me.chkExpertMode_BlitzCache = New System.Windows.Forms.CheckBox()
        Me.chkExportToExcel_BlitzCache = New System.Windows.Forms.CheckBox()
        Me.intTop_BlitzCache = New System.Windows.Forms.TextBox()
        Me.lblTop_BlitzCache = New System.Windows.Forms.Label()
        Me.sp_BlitzFirst = New System.Windows.Forms.TabPage()
        Me.ddlOutputType_BlitzFirst = New System.Windows.Forms.ComboBox()
        Me.lblOutputType_BlitzFirst = New System.Windows.Forms.Label()
        Me.chkSinceStartup_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.intFileLatencyThresholdMS_BlitzFirst = New System.Windows.Forms.TextBox()
        Me.lblFileLatencyThresholdMS_BlitzFirst = New System.Windows.Forms.Label()
        Me.chkCheckServerInfo_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.intMemoryGrantThresholdPct_BlitzFirst = New System.Windows.Forms.TextBox()
        Me.lblMemoryGrantThresholdPct_BlitzFirst = New System.Windows.Forms.Label()
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.chkShowSleepingSPIDs_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.chkCheckProcedureCache_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.ddlFilterPlansByDatabase_BlitzFirst = New System.Windows.Forms.ComboBox()
        Me.lblFilterPlansByDatabase_BlitzFirst = New System.Windows.Forms.Label()
        Me.intSeconds_BlitzFirst = New System.Windows.Forms.TextBox()
        Me.lblSeconds_BlitzFirst = New System.Windows.Forms.Label()
        Me.chkExpertMode_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.sp_BlitzIndex = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddlMode_BlitzIndex = New System.Windows.Forms.ComboBox()
        Me.lblMode_BlitzIndex = New System.Windows.Forms.Label()
        Me.chkShowColumnstoreOnly_BlitzIndex = New System.Windows.Forms.CheckBox()
        Me.ddlSortDirection_BlitzIndex = New System.Windows.Forms.ComboBox()
        Me.lblSortDirection_BlitzIndex = New System.Windows.Forms.Label()
        Me.ddlSortOrder_BlitzIndex = New System.Windows.Forms.ComboBox()
        Me.lblSortOrder_BlitzIndex = New System.Windows.Forms.Label()
        Me.chkShowAllMissingIndexRequests_BlitzIndex = New System.Windows.Forms.CheckBox()
        Me.chkIncludeInactiveIndexes_BlitzIndex = New System.Windows.Forms.CheckBox()
        Me.strIgnoreDatabases_BlitzIndex = New System.Windows.Forms.TextBox()
        Me.lblIgnoreDatabases_BlitzIndex = New System.Windows.Forms.Label()
        Me.chkBringThePain_BlitzIndex = New System.Windows.Forms.CheckBox()
        Me.chkGetAllDatabases_BlitzIndex = New System.Windows.Forms.CheckBox()
        Me.ddlTableName_BlitzIndex = New System.Windows.Forms.ComboBox()
        Me.lblTableName_BlitzIndex = New System.Windows.Forms.Label()
        Me.ddlSchemaName_BlitzIndex = New System.Windows.Forms.ComboBox()
        Me.lblSchemaName_BlitzIndex = New System.Windows.Forms.Label()
        Me.ddlDatabaseName_BlitzIndex = New System.Windows.Forms.ComboBox()
        Me.lblDatabaseName_BlitzIndex = New System.Windows.Forms.Label()
        Me.sp_BlitzLock = New System.Windows.Forms.TabPage()
        Me.dtpEndTime_BlitzLock = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTime_BlitzLock = New System.Windows.Forms.DateTimePicker()
        Me.chkUseBelowDate_Internal_BlitzLock = New System.Windows.Forms.CheckBox()
        Me.chkExportToExcel_BlitzLock = New System.Windows.Forms.CheckBox()
        Me.chkVictimsOnly_BlitzLock = New System.Windows.Forms.CheckBox()
        Me.strLoginName_BlitzLock = New System.Windows.Forms.TextBox()
        Me.lblLoginName_BlitzLock = New System.Windows.Forms.Label()
        Me.strHostName_BlitzLock = New System.Windows.Forms.TextBox()
        Me.lblHostName_BlitzLock = New System.Windows.Forms.Label()
        Me.strAppName_BlitzLock = New System.Windows.Forms.TextBox()
        Me.lblAppName_BlitzLock = New System.Windows.Forms.Label()
        Me.ddlTableName_Internal_BlitzLock = New System.Windows.Forms.ComboBox()
        Me.lblTableName_BlitzLock = New System.Windows.Forms.Label()
        Me.ddlSchemaName_Internal_BlitzLock = New System.Windows.Forms.ComboBox()
        Me.lblSchemaName_BlitzLock = New System.Windows.Forms.Label()
        Me.dtpEndDate_BlitzLock = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate_BlitzLock = New System.Windows.Forms.Label()
        Me.dtpStartDate_BlitzLock = New System.Windows.Forms.DateTimePicker()
        Me.lblStartDate_BlitzLock = New System.Windows.Forms.Label()
        Me.ddlStoredProcName_BlitzLock = New System.Windows.Forms.ComboBox()
        Me.lblStoredProcName_BlitzLock = New System.Windows.Forms.Label()
        Me.ddlDatabaseName_BlitzLock = New System.Windows.Forms.ComboBox()
        Me.lblDatabaseName_BlitzLock = New System.Windows.Forms.Label()
        Me.sp_BlitzQueryStore = New System.Windows.Forms.TabPage()
        Me.dtpEndTime_BlitzQueryStore = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTime_BlitzQueryStore = New System.Windows.Forms.DateTimePicker()
        Me.chkExpertMode_BlitzQueryStore = New System.Windows.Forms.CheckBox()
        Me.chkSkipXML_BlitzQueryStore = New System.Windows.Forms.CheckBox()
        Me.chkFailed_BlitzQueryStore = New System.Windows.Forms.CheckBox()
        Me.intDurationFilter_BlitzQueryStore = New System.Windows.Forms.TextBox()
        Me.lblDurationFilter_BlitzQueryStore = New System.Windows.Forms.Label()
        Me.intMinimumExecutionCount_BlitzQueryStore = New System.Windows.Forms.TextBox()
        Me.lblMinimumExecutionCount_BlitzQueryStore = New System.Windows.Forms.Label()
        Me.chkExportToExcel_BlitzQueryStore = New System.Windows.Forms.CheckBox()
        Me.dtpEndDate_BlitzQueryStore = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate_BlitzQueryStore = New System.Windows.Forms.Label()
        Me.dtpStartDate_BlitzQueryStore = New System.Windows.Forms.DateTimePicker()
        Me.lblStartDate_BlitzQueryStore = New System.Windows.Forms.Label()
        Me.ddlStoredProcName_BlitzQueryStore = New System.Windows.Forms.ComboBox()
        Me.lblStoredProcName_BlitzQueryStore = New System.Windows.Forms.Label()
        Me.ddlDatabaseName_BlitzQueryStore = New System.Windows.Forms.ComboBox()
        Me.lblDatabaseName_BlitzQueryStore = New System.Windows.Forms.Label()
        Me.lblTop_BlitzQueryStore = New System.Windows.Forms.Label()
        Me.intTop_BlitzQueryStore = New System.Windows.Forms.TextBox()
        Me.sp_BlitzWho = New System.Windows.Forms.TabPage()
        Me.chkGetLiveQueryPlan_BlitzWho = New System.Windows.Forms.CheckBox()
        Me.chkGetOuterCommand_BlitzWho = New System.Windows.Forms.CheckBox()
        Me.ddlSortOrder_BlitzWho = New System.Windows.Forms.ComboBox()
        Me.lblSortOrder_BlitzWho = New System.Windows.Forms.Label()
        Me.intMinBlockingSeconds_BlitzWho = New System.Windows.Forms.TextBox()
        Me.lblMinBlockingSeconds_BlitzWho = New System.Windows.Forms.Label()
        Me.intMinRequestedMemoryKB_BlitzWho = New System.Windows.Forms.TextBox()
        Me.lblMinRequestedMemoryKB_BlitzWho = New System.Windows.Forms.Label()
        Me.intMinTempdbMB_BlitzWho = New System.Windows.Forms.TextBox()
        Me.lblMinTempdbMB_BlitzWho = New System.Windows.Forms.Label()
        Me.intMinWrites_BlitzWho = New System.Windows.Forms.TextBox()
        Me.lblMinWrites_BlitzWho = New System.Windows.Forms.Label()
        Me.intMinPhysicalReads_BlitzWho = New System.Windows.Forms.TextBox()
        Me.lblMinPhysicalReads_BlitzWho = New System.Windows.Forms.Label()
        Me.intMinLogicalReads_BlitzWho = New System.Windows.Forms.TextBox()
        Me.lblMinLogicalReads_BlitzWho = New System.Windows.Forms.Label()
        Me.intMinCPUTime_BlitzWho = New System.Windows.Forms.TextBox()
        Me.lblMinCPUTime_BlitzWho = New System.Windows.Forms.Label()
        Me.intMinElapsedSeconds_BlitzWho = New System.Windows.Forms.TextBox()
        Me.lblMinElapsedSeconds_BlitzWho = New System.Windows.Forms.Label()
        Me.chkExpertMode_BlitzWho = New System.Windows.Forms.CheckBox()
        Me.chkShowSleepingSPIDs_BlitzWho = New System.Windows.Forms.CheckBox()
        Me.cmdExportToExcel = New System.Windows.Forms.Button()
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.cmdManageServers = New System.Windows.Forms.Button()
        Me.gbTimeOut = New System.Windows.Forms.GroupBox()
        Me.cmdOpenExcelFolder = New System.Windows.Forms.Button()
        Me.lblLatestExecutedScript = New System.Windows.Forms.Label()
        Me.lblSelectDatabase = New System.Windows.Forms.Label()
        Me.ddlDatabases = New System.Windows.Forms.ComboBox()
        Me.lblDatabasesNotSelectable = New System.Windows.Forms.Label()
        Me.lblOutputResultSets_BlitzFirst = New System.Windows.Forms.Label()
        Me.chkBlitzWhoStart_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.chkFindings_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.chkFileStats_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.chkPerfmonStats_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.chkWaitStats_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.chkBlitzCache_BlitzFirst = New System.Windows.Forms.CheckBox()
        Me.chkBlitzWhoEnd_BlitzFirst = New System.Windows.Forms.CheckBox()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcFilters.SuspendLayout()
        Me.sp_Blitz.SuspendLayout()
        Me.sp_BlitzAnalysis.SuspendLayout()
        Me.sp_BlitzBackups.SuspendLayout()
        Me.sp_BlitzCache.SuspendLayout()
        Me.sp_BlitzFirst.SuspendLayout()
        Me.sp_BlitzIndex.SuspendLayout()
        Me.sp_BlitzLock.SuspendLayout()
        Me.sp_BlitzQueryStore.SuspendLayout()
        Me.sp_BlitzWho.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblServers
        '
        Me.lblServers.AutoSize = True
        Me.lblServers.Location = New System.Drawing.Point(5, 11)
        Me.lblServers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServers.Name = "lblServers"
        Me.lblServers.Size = New System.Drawing.Size(166, 16)
        Me.lblServers.TabIndex = 0
        Me.lblServers.Text = "Select existing SQL server:"
        '
        'ddlServers
        '
        Me.ddlServers.Enabled = False
        Me.ddlServers.FormattingEnabled = True
        Me.ddlServers.Location = New System.Drawing.Point(9, 31)
        Me.ddlServers.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlServers.Name = "ddlServers"
        Me.ddlServers.Size = New System.Drawing.Size(229, 24)
        Me.ddlServers.TabIndex = 1
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AllowUserToOrderColumns = True
        Me.dgvResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(9, 487)
        Me.dgvResults.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.RowHeadersWidth = 51
        Me.dgvResults.Size = New System.Drawing.Size(1577, 223)
        Me.dgvResults.TabIndex = 2
        Me.dgvResults.Visible = False
        '
        'lblSelectSproc
        '
        Me.lblSelectSproc.AutoSize = True
        Me.lblSelectSproc.Location = New System.Drawing.Point(824, 11)
        Me.lblSelectSproc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectSproc.Name = "lblSelectSproc"
        Me.lblSelectSproc.Size = New System.Drawing.Size(218, 16)
        Me.lblSelectSproc.TabIndex = 3
        Me.lblSelectSproc.Text = "Select stored procedure to execute:"
        '
        'ddlSprocs
        '
        Me.ddlSprocs.Enabled = False
        Me.ddlSprocs.FormattingEnabled = True
        Me.ddlSprocs.Location = New System.Drawing.Point(828, 31)
        Me.ddlSprocs.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSprocs.Name = "ddlSprocs"
        Me.ddlSprocs.Size = New System.Drawing.Size(229, 24)
        Me.ddlSprocs.TabIndex = 4
        '
        'cmdExecute
        '
        Me.cmdExecute.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmdExecute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdExecute.Location = New System.Drawing.Point(339, 321)
        Me.cmdExecute.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExecute.Name = "cmdExecute"
        Me.cmdExecute.Size = New System.Drawing.Size(229, 33)
        Me.cmdExecute.TabIndex = 5
        Me.cmdExecute.Text = "Execute"
        Me.cmdExecute.UseVisualStyleBackColor = False
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlButtons.Location = New System.Drawing.Point(9, 441)
        Me.pnlButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlButtons.Size = New System.Drawing.Size(1577, 39)
        Me.pnlButtons.TabIndex = 8
        '
        'tcFilters
        '
        Me.tcFilters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcFilters.Controls.Add(Me.sp_Blitz)
        Me.tcFilters.Controls.Add(Me.sp_BlitzAnalysis)
        Me.tcFilters.Controls.Add(Me.sp_BlitzBackups)
        Me.tcFilters.Controls.Add(Me.sp_BlitzCache)
        Me.tcFilters.Controls.Add(Me.sp_BlitzFirst)
        Me.tcFilters.Controls.Add(Me.sp_BlitzIndex)
        Me.tcFilters.Controls.Add(Me.sp_BlitzLock)
        Me.tcFilters.Controls.Add(Me.sp_BlitzQueryStore)
        Me.tcFilters.Controls.Add(Me.sp_BlitzWho)
        Me.tcFilters.Location = New System.Drawing.Point(9, 70)
        Me.tcFilters.Margin = New System.Windows.Forms.Padding(4)
        Me.tcFilters.Name = "tcFilters"
        Me.tcFilters.SelectedIndex = 0
        Me.tcFilters.Size = New System.Drawing.Size(1577, 244)
        Me.tcFilters.TabIndex = 12
        Me.tcFilters.Visible = False
        '
        'sp_Blitz
        '
        Me.sp_Blitz.Controls.Add(Me.Label4)
        Me.sp_Blitz.Controls.Add(Me.ddlCheckProcedureCacheFilter_Blitz)
        Me.sp_Blitz.Controls.Add(Me.lblCheckProcedureCacheFilter_Blitz)
        Me.sp_Blitz.Controls.Add(Me.lblOutputType_Blitz)
        Me.sp_Blitz.Controls.Add(Me.ddlOutputType_Blitz)
        Me.sp_Blitz.Controls.Add(Me.chkOutputProcedureCache_Blitz)
        Me.sp_Blitz.Controls.Add(Me.chkCheckProcedureCache_Blitz)
        Me.sp_Blitz.Controls.Add(Me.intIgnorePrioritiesAbove_Blitz)
        Me.sp_Blitz.Controls.Add(Me.intIgnorePrioritiesBelow_Blitz)
        Me.sp_Blitz.Controls.Add(Me.lblIgnorePrioritiesAbove_Blitz)
        Me.sp_Blitz.Controls.Add(Me.lblIgnorePrioritiesBelow_Blitz)
        Me.sp_Blitz.Controls.Add(Me.chkSkipBlockingChecks_Blitz)
        Me.sp_Blitz.Controls.Add(Me.chkBringThePain_Blitz)
        Me.sp_Blitz.Controls.Add(Me.chkSummaryMode_Blitz)
        Me.sp_Blitz.Controls.Add(Me.chkCheckServerInfo_Blitz)
        Me.sp_Blitz.Controls.Add(Me.chkCheckUserDatabaseObjects_Blitz)
        Me.sp_Blitz.Location = New System.Drawing.Point(4, 25)
        Me.sp_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.sp_Blitz.Name = "sp_Blitz"
        Me.sp_Blitz.Padding = New System.Windows.Forms.Padding(4)
        Me.sp_Blitz.Size = New System.Drawing.Size(1569, 215)
        Me.sp_Blitz.TabIndex = 0
        Me.sp_Blitz.Text = "Parameters Blitz"
        Me.sp_Blitz.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1059, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Below is only using TABLE hence we hide it."
        Me.Label4.Visible = False
        '
        'ddlCheckProcedureCacheFilter_Blitz
        '
        Me.ddlCheckProcedureCacheFilter_Blitz.FormattingEnabled = True
        Me.ddlCheckProcedureCacheFilter_Blitz.Items.AddRange(New Object() {"Skip (Null)", "CPU", "Reads", "Duration", "ExecCount"})
        Me.ddlCheckProcedureCacheFilter_Blitz.Location = New System.Drawing.Point(661, 20)
        Me.ddlCheckProcedureCacheFilter_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlCheckProcedureCacheFilter_Blitz.Name = "ddlCheckProcedureCacheFilter_Blitz"
        Me.ddlCheckProcedureCacheFilter_Blitz.Size = New System.Drawing.Size(160, 24)
        Me.ddlCheckProcedureCacheFilter_Blitz.TabIndex = 25
        Me.ddlCheckProcedureCacheFilter_Blitz.Tag = "CheckProcedureCacheFilter;Skip (Null)"
        '
        'lblCheckProcedureCacheFilter_Blitz
        '
        Me.lblCheckProcedureCacheFilter_Blitz.AutoSize = True
        Me.lblCheckProcedureCacheFilter_Blitz.Location = New System.Drawing.Point(473, 23)
        Me.lblCheckProcedureCacheFilter_Blitz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheckProcedureCacheFilter_Blitz.Name = "lblCheckProcedureCacheFilter_Blitz"
        Me.lblCheckProcedureCacheFilter_Blitz.Size = New System.Drawing.Size(179, 16)
        Me.lblCheckProcedureCacheFilter_Blitz.TabIndex = 24
        Me.lblCheckProcedureCacheFilter_Blitz.Tag = "CheckProcedureCacheFilter"
        Me.lblCheckProcedureCacheFilter_Blitz.Text = "CheckProcedureCacheFilter:"
        '
        'lblOutputType_Blitz
        '
        Me.lblOutputType_Blitz.AutoSize = True
        Me.lblOutputType_Blitz.Location = New System.Drawing.Point(1059, 43)
        Me.lblOutputType_Blitz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputType_Blitz.Name = "lblOutputType_Blitz"
        Me.lblOutputType_Blitz.Size = New System.Drawing.Size(80, 16)
        Me.lblOutputType_Blitz.TabIndex = 23
        Me.lblOutputType_Blitz.Tag = "OutputType"
        Me.lblOutputType_Blitz.Text = "OutputType:"
        Me.lblOutputType_Blitz.Visible = False
        '
        'ddlOutputType_Blitz
        '
        Me.ddlOutputType_Blitz.FormattingEnabled = True
        Me.ddlOutputType_Blitz.Items.AddRange(New Object() {"TABLE", "COUNT", "MARKDOWN", "SCHEMA", "XML", "NONE"})
        Me.ddlOutputType_Blitz.Location = New System.Drawing.Point(1155, 39)
        Me.ddlOutputType_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlOutputType_Blitz.Name = "ddlOutputType_Blitz"
        Me.ddlOutputType_Blitz.Size = New System.Drawing.Size(160, 24)
        Me.ddlOutputType_Blitz.TabIndex = 22
        Me.ddlOutputType_Blitz.Tag = "OutputType;TABLE"
        Me.ddlOutputType_Blitz.Visible = False
        '
        'chkOutputProcedureCache_Blitz
        '
        Me.chkOutputProcedureCache_Blitz.AutoSize = True
        Me.chkOutputProcedureCache_Blitz.Location = New System.Drawing.Point(27, 107)
        Me.chkOutputProcedureCache_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOutputProcedureCache_Blitz.Name = "chkOutputProcedureCache_Blitz"
        Me.chkOutputProcedureCache_Blitz.Size = New System.Drawing.Size(169, 20)
        Me.chkOutputProcedureCache_Blitz.TabIndex = 21
        Me.chkOutputProcedureCache_Blitz.Tag = "OutputProcedureCache;0"
        Me.chkOutputProcedureCache_Blitz.Text = "OutputProcedureCache"
        Me.chkOutputProcedureCache_Blitz.UseVisualStyleBackColor = True
        '
        'chkCheckProcedureCache_Blitz
        '
        Me.chkCheckProcedureCache_Blitz.AutoSize = True
        Me.chkCheckProcedureCache_Blitz.Location = New System.Drawing.Point(27, 79)
        Me.chkCheckProcedureCache_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCheckProcedureCache_Blitz.Name = "chkCheckProcedureCache_Blitz"
        Me.chkCheckProcedureCache_Blitz.Size = New System.Drawing.Size(169, 20)
        Me.chkCheckProcedureCache_Blitz.TabIndex = 20
        Me.chkCheckProcedureCache_Blitz.Tag = "CheckProcedureCache;0"
        Me.chkCheckProcedureCache_Blitz.Text = "CheckProcedureCache"
        Me.chkCheckProcedureCache_Blitz.UseVisualStyleBackColor = True
        '
        'intIgnorePrioritiesAbove_Blitz
        '
        Me.intIgnorePrioritiesAbove_Blitz.Location = New System.Drawing.Point(885, 48)
        Me.intIgnorePrioritiesAbove_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.intIgnorePrioritiesAbove_Blitz.Name = "intIgnorePrioritiesAbove_Blitz"
        Me.intIgnorePrioritiesAbove_Blitz.Size = New System.Drawing.Size(51, 22)
        Me.intIgnorePrioritiesAbove_Blitz.TabIndex = 19
        Me.intIgnorePrioritiesAbove_Blitz.Tag = "IgnorePrioritiesAbove;"
        '
        'intIgnorePrioritiesBelow_Blitz
        '
        Me.intIgnorePrioritiesBelow_Blitz.Location = New System.Drawing.Point(663, 48)
        Me.intIgnorePrioritiesBelow_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.intIgnorePrioritiesBelow_Blitz.Name = "intIgnorePrioritiesBelow_Blitz"
        Me.intIgnorePrioritiesBelow_Blitz.Size = New System.Drawing.Size(51, 22)
        Me.intIgnorePrioritiesBelow_Blitz.TabIndex = 18
        Me.intIgnorePrioritiesBelow_Blitz.Tag = "IgnorePrioritiesBelow;"
        '
        'lblIgnorePrioritiesAbove_Blitz
        '
        Me.lblIgnorePrioritiesAbove_Blitz.AutoSize = True
        Me.lblIgnorePrioritiesAbove_Blitz.Location = New System.Drawing.Point(743, 52)
        Me.lblIgnorePrioritiesAbove_Blitz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIgnorePrioritiesAbove_Blitz.Name = "lblIgnorePrioritiesAbove_Blitz"
        Me.lblIgnorePrioritiesAbove_Blitz.Size = New System.Drawing.Size(140, 16)
        Me.lblIgnorePrioritiesAbove_Blitz.TabIndex = 15
        Me.lblIgnorePrioritiesAbove_Blitz.Tag = "IgnorePrioritiesAbove"
        Me.lblIgnorePrioritiesAbove_Blitz.Text = "IgnorePrioritiesAbove:"
        '
        'lblIgnorePrioritiesBelow_Blitz
        '
        Me.lblIgnorePrioritiesBelow_Blitz.AutoSize = True
        Me.lblIgnorePrioritiesBelow_Blitz.Location = New System.Drawing.Point(520, 52)
        Me.lblIgnorePrioritiesBelow_Blitz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIgnorePrioritiesBelow_Blitz.Name = "lblIgnorePrioritiesBelow_Blitz"
        Me.lblIgnorePrioritiesBelow_Blitz.Size = New System.Drawing.Size(137, 16)
        Me.lblIgnorePrioritiesBelow_Blitz.TabIndex = 13
        Me.lblIgnorePrioritiesBelow_Blitz.Tag = "IgnorePrioritiesBelow"
        Me.lblIgnorePrioritiesBelow_Blitz.Text = "IgnorePrioritiesBelow:"
        '
        'chkSkipBlockingChecks_Blitz
        '
        Me.chkSkipBlockingChecks_Blitz.AutoSize = True
        Me.chkSkipBlockingChecks_Blitz.Checked = True
        Me.chkSkipBlockingChecks_Blitz.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSkipBlockingChecks_Blitz.Location = New System.Drawing.Point(279, 50)
        Me.chkSkipBlockingChecks_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSkipBlockingChecks_Blitz.Name = "chkSkipBlockingChecks_Blitz"
        Me.chkSkipBlockingChecks_Blitz.Size = New System.Drawing.Size(153, 20)
        Me.chkSkipBlockingChecks_Blitz.TabIndex = 7
        Me.chkSkipBlockingChecks_Blitz.Tag = "SkipBlockingChecks;1"
        Me.chkSkipBlockingChecks_Blitz.Text = "SkipBlockingChecks"
        Me.chkSkipBlockingChecks_Blitz.UseVisualStyleBackColor = True
        '
        'chkBringThePain_Blitz
        '
        Me.chkBringThePain_Blitz.AutoSize = True
        Me.chkBringThePain_Blitz.Location = New System.Drawing.Point(279, 79)
        Me.chkBringThePain_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBringThePain_Blitz.Name = "chkBringThePain_Blitz"
        Me.chkBringThePain_Blitz.Size = New System.Drawing.Size(111, 20)
        Me.chkBringThePain_Blitz.TabIndex = 6
        Me.chkBringThePain_Blitz.Tag = "BringThePain;0"
        Me.chkBringThePain_Blitz.Text = "BringThePain"
        Me.chkBringThePain_Blitz.UseVisualStyleBackColor = True
        '
        'chkSummaryMode_Blitz
        '
        Me.chkSummaryMode_Blitz.AutoSize = True
        Me.chkSummaryMode_Blitz.Location = New System.Drawing.Point(279, 22)
        Me.chkSummaryMode_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSummaryMode_Blitz.Name = "chkSummaryMode_Blitz"
        Me.chkSummaryMode_Blitz.Size = New System.Drawing.Size(121, 20)
        Me.chkSummaryMode_Blitz.TabIndex = 5
        Me.chkSummaryMode_Blitz.Tag = "SummaryMode;0"
        Me.chkSummaryMode_Blitz.Text = "SummaryMode"
        Me.chkSummaryMode_Blitz.UseVisualStyleBackColor = True
        '
        'chkCheckServerInfo_Blitz
        '
        Me.chkCheckServerInfo_Blitz.AutoSize = True
        Me.chkCheckServerInfo_Blitz.Location = New System.Drawing.Point(27, 50)
        Me.chkCheckServerInfo_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCheckServerInfo_Blitz.Name = "chkCheckServerInfo_Blitz"
        Me.chkCheckServerInfo_Blitz.Size = New System.Drawing.Size(128, 20)
        Me.chkCheckServerInfo_Blitz.TabIndex = 4
        Me.chkCheckServerInfo_Blitz.Tag = "CheckServerInfo;0"
        Me.chkCheckServerInfo_Blitz.Text = "CheckServerInfo"
        Me.chkCheckServerInfo_Blitz.UseVisualStyleBackColor = True
        '
        'chkCheckUserDatabaseObjects_Blitz
        '
        Me.chkCheckUserDatabaseObjects_Blitz.AutoSize = True
        Me.chkCheckUserDatabaseObjects_Blitz.Checked = True
        Me.chkCheckUserDatabaseObjects_Blitz.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCheckUserDatabaseObjects_Blitz.Location = New System.Drawing.Point(27, 22)
        Me.chkCheckUserDatabaseObjects_Blitz.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCheckUserDatabaseObjects_Blitz.Name = "chkCheckUserDatabaseObjects_Blitz"
        Me.chkCheckUserDatabaseObjects_Blitz.Size = New System.Drawing.Size(202, 20)
        Me.chkCheckUserDatabaseObjects_Blitz.TabIndex = 3
        Me.chkCheckUserDatabaseObjects_Blitz.Tag = "CheckUserDatabaseObjects;1"
        Me.chkCheckUserDatabaseObjects_Blitz.Text = "CheckUserDatabaseObjects"
        Me.chkCheckUserDatabaseObjects_Blitz.UseVisualStyleBackColor = True
        '
        'sp_BlitzAnalysis
        '
        Me.sp_BlitzAnalysis.Controls.Add(Me.strDatabaseName_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.strServerName_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.intMaxDop_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblMaxDop_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.chkBringThePain_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.intWriteLatencyThreshold)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblWriteLatencyThreshold_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.intReadLatencyThreshold)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblReadLatencyThreshold_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.intWaitStatsTop_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblWaitStatsTop_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.ddlBlitzCacheSortOrder_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblBlitzCacheSortOrder_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.intMaxBlitzFirstPriority_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblMaxBlitzFirstPriority_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblDatabaseName_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblServerName_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.ddlOutputTableNameFileStats_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblOutputTableNameFileStats_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.ddlOutputTableNamePerfmonStats_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblOutputTableNamePerfmonStats_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.ddlOutputTableNameBlitzCache_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblOutputTableNameBlitzCache_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.ddlOutputTableNameBlitzWho_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblOutputTableNameBlitzWho_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.ddlOutputTableNameWaitStats_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblOutputTableNameWaitStats_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.ddlOutputTableNameBlitzFirst_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblOutputTableNameBlitzFirst_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.ddlOutputSchemaName_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblOutputSchemaName_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.ddlOutputDatabaseName_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblOutputDatabaseName_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.dtpEndTime_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.dtpStartTime_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.dtpEndDate_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblEndDate_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.dtpStartDate_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Controls.Add(Me.lblStartDate_BlitzAnalysis)
        Me.sp_BlitzAnalysis.Location = New System.Drawing.Point(4, 25)
        Me.sp_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzAnalysis.Name = "sp_BlitzAnalysis"
        Me.sp_BlitzAnalysis.Padding = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzAnalysis.Size = New System.Drawing.Size(1569, 215)
        Me.sp_BlitzAnalysis.TabIndex = 8
        Me.sp_BlitzAnalysis.Text = "Parameters BlitzAnalysis"
        Me.sp_BlitzAnalysis.UseVisualStyleBackColor = True
        '
        'strDatabaseName_BlitzAnalysis
        '
        Me.strDatabaseName_BlitzAnalysis.Location = New System.Drawing.Point(779, 111)
        Me.strDatabaseName_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.strDatabaseName_BlitzAnalysis.Name = "strDatabaseName_BlitzAnalysis"
        Me.strDatabaseName_BlitzAnalysis.Size = New System.Drawing.Size(236, 22)
        Me.strDatabaseName_BlitzAnalysis.TabIndex = 117
        Me.strDatabaseName_BlitzAnalysis.Tag = "DatabaseName;"
        '
        'strServerName_BlitzAnalysis
        '
        Me.strServerName_BlitzAnalysis.Location = New System.Drawing.Point(779, 75)
        Me.strServerName_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.strServerName_BlitzAnalysis.Name = "strServerName_BlitzAnalysis"
        Me.strServerName_BlitzAnalysis.Size = New System.Drawing.Size(236, 22)
        Me.strServerName_BlitzAnalysis.TabIndex = 116
        Me.strServerName_BlitzAnalysis.Tag = "ServerName;"
        '
        'intMaxDop_BlitzAnalysis
        '
        Me.intMaxDop_BlitzAnalysis.Location = New System.Drawing.Point(512, 140)
        Me.intMaxDop_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.intMaxDop_BlitzAnalysis.Name = "intMaxDop_BlitzAnalysis"
        Me.intMaxDop_BlitzAnalysis.Size = New System.Drawing.Size(57, 22)
        Me.intMaxDop_BlitzAnalysis.TabIndex = 115
        Me.intMaxDop_BlitzAnalysis.Tag = "MaxDop;1"
        Me.intMaxDop_BlitzAnalysis.Text = "1"
        '
        'lblMaxDop_BlitzAnalysis
        '
        Me.lblMaxDop_BlitzAnalysis.AutoSize = True
        Me.lblMaxDop_BlitzAnalysis.Location = New System.Drawing.Point(345, 145)
        Me.lblMaxDop_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxDop_BlitzAnalysis.Name = "lblMaxDop_BlitzAnalysis"
        Me.lblMaxDop_BlitzAnalysis.Size = New System.Drawing.Size(61, 16)
        Me.lblMaxDop_BlitzAnalysis.TabIndex = 114
        Me.lblMaxDop_BlitzAnalysis.Text = "MaxDop:"
        '
        'chkBringThePain_BlitzAnalysis
        '
        Me.chkBringThePain_BlitzAnalysis.AutoSize = True
        Me.chkBringThePain_BlitzAnalysis.Location = New System.Drawing.Point(687, 175)
        Me.chkBringThePain_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBringThePain_BlitzAnalysis.Name = "chkBringThePain_BlitzAnalysis"
        Me.chkBringThePain_BlitzAnalysis.Size = New System.Drawing.Size(111, 20)
        Me.chkBringThePain_BlitzAnalysis.TabIndex = 113
        Me.chkBringThePain_BlitzAnalysis.Tag = "BringThePain;0"
        Me.chkBringThePain_BlitzAnalysis.Text = "BringThePain"
        Me.chkBringThePain_BlitzAnalysis.UseVisualStyleBackColor = True
        '
        'intWriteLatencyThreshold
        '
        Me.intWriteLatencyThreshold.Location = New System.Drawing.Point(512, 42)
        Me.intWriteLatencyThreshold.Margin = New System.Windows.Forms.Padding(4)
        Me.intWriteLatencyThreshold.Name = "intWriteLatencyThreshold"
        Me.intWriteLatencyThreshold.Size = New System.Drawing.Size(60, 22)
        Me.intWriteLatencyThreshold.TabIndex = 112
        Me.intWriteLatencyThreshold.Tag = "WriteLatencyThreshold;100"
        Me.intWriteLatencyThreshold.Text = "100"
        '
        'lblWriteLatencyThreshold_BlitzAnalysis
        '
        Me.lblWriteLatencyThreshold_BlitzAnalysis.AutoSize = True
        Me.lblWriteLatencyThreshold_BlitzAnalysis.Location = New System.Drawing.Point(345, 46)
        Me.lblWriteLatencyThreshold_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWriteLatencyThreshold_BlitzAnalysis.Name = "lblWriteLatencyThreshold_BlitzAnalysis"
        Me.lblWriteLatencyThreshold_BlitzAnalysis.Size = New System.Drawing.Size(149, 16)
        Me.lblWriteLatencyThreshold_BlitzAnalysis.TabIndex = 111
        Me.lblWriteLatencyThreshold_BlitzAnalysis.Text = "WriteLatencyThreshold:"
        '
        'intReadLatencyThreshold
        '
        Me.intReadLatencyThreshold.Location = New System.Drawing.Point(512, 7)
        Me.intReadLatencyThreshold.Margin = New System.Windows.Forms.Padding(4)
        Me.intReadLatencyThreshold.Name = "intReadLatencyThreshold"
        Me.intReadLatencyThreshold.Size = New System.Drawing.Size(60, 22)
        Me.intReadLatencyThreshold.TabIndex = 110
        Me.intReadLatencyThreshold.Tag = "ReadLatencyThreshold;100"
        Me.intReadLatencyThreshold.Text = "100"
        '
        'lblReadLatencyThreshold_BlitzAnalysis
        '
        Me.lblReadLatencyThreshold_BlitzAnalysis.AutoSize = True
        Me.lblReadLatencyThreshold_BlitzAnalysis.Location = New System.Drawing.Point(345, 11)
        Me.lblReadLatencyThreshold_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReadLatencyThreshold_BlitzAnalysis.Name = "lblReadLatencyThreshold_BlitzAnalysis"
        Me.lblReadLatencyThreshold_BlitzAnalysis.Size = New System.Drawing.Size(152, 16)
        Me.lblReadLatencyThreshold_BlitzAnalysis.TabIndex = 109
        Me.lblReadLatencyThreshold_BlitzAnalysis.Text = "ReadLatencyThreshold:"
        '
        'intWaitStatsTop_BlitzAnalysis
        '
        Me.intWaitStatsTop_BlitzAnalysis.Location = New System.Drawing.Point(512, 106)
        Me.intWaitStatsTop_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.intWaitStatsTop_BlitzAnalysis.Name = "intWaitStatsTop_BlitzAnalysis"
        Me.intWaitStatsTop_BlitzAnalysis.Size = New System.Drawing.Size(59, 22)
        Me.intWaitStatsTop_BlitzAnalysis.TabIndex = 108
        Me.intWaitStatsTop_BlitzAnalysis.Tag = "WaitStatsTop;10"
        Me.intWaitStatsTop_BlitzAnalysis.Text = "10"
        '
        'lblWaitStatsTop_BlitzAnalysis
        '
        Me.lblWaitStatsTop_BlitzAnalysis.AutoSize = True
        Me.lblWaitStatsTop_BlitzAnalysis.Location = New System.Drawing.Point(345, 114)
        Me.lblWaitStatsTop_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaitStatsTop_BlitzAnalysis.Name = "lblWaitStatsTop_BlitzAnalysis"
        Me.lblWaitStatsTop_BlitzAnalysis.Size = New System.Drawing.Size(92, 16)
        Me.lblWaitStatsTop_BlitzAnalysis.TabIndex = 107
        Me.lblWaitStatsTop_BlitzAnalysis.Text = "WaitStatsTop:"
        '
        'ddlBlitzCacheSortOrder_BlitzAnalysis
        '
        Me.ddlBlitzCacheSortOrder_BlitzAnalysis.FormattingEnabled = True
        Me.ddlBlitzCacheSortOrder_BlitzAnalysis.Items.AddRange(New Object() {"Cpu (Default)", "All", "Reads", "Writes", "Duration", "Executions", "Menory grant", "Spills"})
        Me.ddlBlitzCacheSortOrder_BlitzAnalysis.Location = New System.Drawing.Point(512, 172)
        Me.ddlBlitzCacheSortOrder_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlBlitzCacheSortOrder_BlitzAnalysis.Name = "ddlBlitzCacheSortOrder_BlitzAnalysis"
        Me.ddlBlitzCacheSortOrder_BlitzAnalysis.Size = New System.Drawing.Size(159, 24)
        Me.ddlBlitzCacheSortOrder_BlitzAnalysis.TabIndex = 106
        Me.ddlBlitzCacheSortOrder_BlitzAnalysis.Tag = "BlitzCacheSortOrder;Cpu"
        '
        'lblBlitzCacheSortOrder_BlitzAnalysis
        '
        Me.lblBlitzCacheSortOrder_BlitzAnalysis.AutoSize = True
        Me.lblBlitzCacheSortOrder_BlitzAnalysis.Location = New System.Drawing.Point(345, 176)
        Me.lblBlitzCacheSortOrder_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBlitzCacheSortOrder_BlitzAnalysis.Name = "lblBlitzCacheSortOrder_BlitzAnalysis"
        Me.lblBlitzCacheSortOrder_BlitzAnalysis.Size = New System.Drawing.Size(131, 16)
        Me.lblBlitzCacheSortOrder_BlitzAnalysis.TabIndex = 105
        Me.lblBlitzCacheSortOrder_BlitzAnalysis.Text = "BlitzCacheSortOrder:"
        '
        'intMaxBlitzFirstPriority_BlitzAnalysis
        '
        Me.intMaxBlitzFirstPriority_BlitzAnalysis.Location = New System.Drawing.Point(512, 74)
        Me.intMaxBlitzFirstPriority_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.intMaxBlitzFirstPriority_BlitzAnalysis.Name = "intMaxBlitzFirstPriority_BlitzAnalysis"
        Me.intMaxBlitzFirstPriority_BlitzAnalysis.Size = New System.Drawing.Size(57, 22)
        Me.intMaxBlitzFirstPriority_BlitzAnalysis.TabIndex = 104
        Me.intMaxBlitzFirstPriority_BlitzAnalysis.Tag = "MaxBlitzFirstPriority;249"
        Me.intMaxBlitzFirstPriority_BlitzAnalysis.Text = "249"
        '
        'lblMaxBlitzFirstPriority_BlitzAnalysis
        '
        Me.lblMaxBlitzFirstPriority_BlitzAnalysis.AutoSize = True
        Me.lblMaxBlitzFirstPriority_BlitzAnalysis.Location = New System.Drawing.Point(345, 79)
        Me.lblMaxBlitzFirstPriority_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxBlitzFirstPriority_BlitzAnalysis.Name = "lblMaxBlitzFirstPriority_BlitzAnalysis"
        Me.lblMaxBlitzFirstPriority_BlitzAnalysis.Size = New System.Drawing.Size(125, 16)
        Me.lblMaxBlitzFirstPriority_BlitzAnalysis.TabIndex = 103
        Me.lblMaxBlitzFirstPriority_BlitzAnalysis.Text = "MaxBlitzFirstPriority:"
        '
        'lblDatabaseName_BlitzAnalysis
        '
        Me.lblDatabaseName_BlitzAnalysis.AutoSize = True
        Me.lblDatabaseName_BlitzAnalysis.Location = New System.Drawing.Point(621, 111)
        Me.lblDatabaseName_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabaseName_BlitzAnalysis.Name = "lblDatabaseName_BlitzAnalysis"
        Me.lblDatabaseName_BlitzAnalysis.Size = New System.Drawing.Size(142, 16)
        Me.lblDatabaseName_BlitzAnalysis.TabIndex = 101
        Me.lblDatabaseName_BlitzAnalysis.Tag = ""
        Me.lblDatabaseName_BlitzAnalysis.Text = "DatabaseName (filter):"
        '
        'lblServerName_BlitzAnalysis
        '
        Me.lblServerName_BlitzAnalysis.AutoSize = True
        Me.lblServerName_BlitzAnalysis.Location = New System.Drawing.Point(621, 78)
        Me.lblServerName_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServerName_BlitzAnalysis.Name = "lblServerName_BlitzAnalysis"
        Me.lblServerName_BlitzAnalysis.Size = New System.Drawing.Size(122, 16)
        Me.lblServerName_BlitzAnalysis.TabIndex = 99
        Me.lblServerName_BlitzAnalysis.Text = "ServerName (filter):"
        '
        'ddlOutputTableNameFileStats_BlitzAnalysis
        '
        Me.ddlOutputTableNameFileStats_BlitzAnalysis.FormattingEnabled = True
        Me.ddlOutputTableNameFileStats_BlitzAnalysis.Location = New System.Drawing.Point(1261, 41)
        Me.ddlOutputTableNameFileStats_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlOutputTableNameFileStats_BlitzAnalysis.Name = "ddlOutputTableNameFileStats_BlitzAnalysis"
        Me.ddlOutputTableNameFileStats_BlitzAnalysis.Size = New System.Drawing.Size(236, 24)
        Me.ddlOutputTableNameFileStats_BlitzAnalysis.TabIndex = 98
        Me.ddlOutputTableNameFileStats_BlitzAnalysis.Tag = "OutputTableNameFileStats;"
        '
        'lblOutputTableNameFileStats_BlitzAnalysis
        '
        Me.lblOutputTableNameFileStats_BlitzAnalysis.AutoSize = True
        Me.lblOutputTableNameFileStats_BlitzAnalysis.Location = New System.Drawing.Point(1048, 44)
        Me.lblOutputTableNameFileStats_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputTableNameFileStats_BlitzAnalysis.Name = "lblOutputTableNameFileStats_BlitzAnalysis"
        Me.lblOutputTableNameFileStats_BlitzAnalysis.Size = New System.Drawing.Size(173, 16)
        Me.lblOutputTableNameFileStats_BlitzAnalysis.TabIndex = 97
        Me.lblOutputTableNameFileStats_BlitzAnalysis.Text = "OutputTableNameFileStats:"
        '
        'ddlOutputTableNamePerfmonStats_BlitzAnalysis
        '
        Me.ddlOutputTableNamePerfmonStats_BlitzAnalysis.FormattingEnabled = True
        Me.ddlOutputTableNamePerfmonStats_BlitzAnalysis.Location = New System.Drawing.Point(1261, 74)
        Me.ddlOutputTableNamePerfmonStats_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlOutputTableNamePerfmonStats_BlitzAnalysis.Name = "ddlOutputTableNamePerfmonStats_BlitzAnalysis"
        Me.ddlOutputTableNamePerfmonStats_BlitzAnalysis.Size = New System.Drawing.Size(236, 24)
        Me.ddlOutputTableNamePerfmonStats_BlitzAnalysis.TabIndex = 96
        Me.ddlOutputTableNamePerfmonStats_BlitzAnalysis.Tag = "OutputTableNamePerfmonStats;"
        '
        'lblOutputTableNamePerfmonStats_BlitzAnalysis
        '
        Me.lblOutputTableNamePerfmonStats_BlitzAnalysis.AutoSize = True
        Me.lblOutputTableNamePerfmonStats_BlitzAnalysis.Location = New System.Drawing.Point(1048, 78)
        Me.lblOutputTableNamePerfmonStats_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputTableNamePerfmonStats_BlitzAnalysis.Name = "lblOutputTableNamePerfmonStats_BlitzAnalysis"
        Me.lblOutputTableNamePerfmonStats_BlitzAnalysis.Size = New System.Drawing.Size(201, 16)
        Me.lblOutputTableNamePerfmonStats_BlitzAnalysis.TabIndex = 95
        Me.lblOutputTableNamePerfmonStats_BlitzAnalysis.Text = "OutputTableNamePerfmonStats:"
        '
        'ddlOutputTableNameBlitzCache_BlitzAnalysis
        '
        Me.ddlOutputTableNameBlitzCache_BlitzAnalysis.FormattingEnabled = True
        Me.ddlOutputTableNameBlitzCache_BlitzAnalysis.Location = New System.Drawing.Point(1261, 140)
        Me.ddlOutputTableNameBlitzCache_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlOutputTableNameBlitzCache_BlitzAnalysis.Name = "ddlOutputTableNameBlitzCache_BlitzAnalysis"
        Me.ddlOutputTableNameBlitzCache_BlitzAnalysis.Size = New System.Drawing.Size(236, 24)
        Me.ddlOutputTableNameBlitzCache_BlitzAnalysis.TabIndex = 94
        Me.ddlOutputTableNameBlitzCache_BlitzAnalysis.Tag = "OutputTableNameBlitzCache;"
        '
        'lblOutputTableNameBlitzCache_BlitzAnalysis
        '
        Me.lblOutputTableNameBlitzCache_BlitzAnalysis.AutoSize = True
        Me.lblOutputTableNameBlitzCache_BlitzAnalysis.Location = New System.Drawing.Point(1048, 144)
        Me.lblOutputTableNameBlitzCache_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputTableNameBlitzCache_BlitzAnalysis.Name = "lblOutputTableNameBlitzCache_BlitzAnalysis"
        Me.lblOutputTableNameBlitzCache_BlitzAnalysis.Size = New System.Drawing.Size(184, 16)
        Me.lblOutputTableNameBlitzCache_BlitzAnalysis.TabIndex = 93
        Me.lblOutputTableNameBlitzCache_BlitzAnalysis.Text = "OutputTableNameBlitzCache:"
        '
        'ddlOutputTableNameBlitzWho_BlitzAnalysis
        '
        Me.ddlOutputTableNameBlitzWho_BlitzAnalysis.FormattingEnabled = True
        Me.ddlOutputTableNameBlitzWho_BlitzAnalysis.Location = New System.Drawing.Point(1261, 174)
        Me.ddlOutputTableNameBlitzWho_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlOutputTableNameBlitzWho_BlitzAnalysis.Name = "ddlOutputTableNameBlitzWho_BlitzAnalysis"
        Me.ddlOutputTableNameBlitzWho_BlitzAnalysis.Size = New System.Drawing.Size(236, 24)
        Me.ddlOutputTableNameBlitzWho_BlitzAnalysis.TabIndex = 92
        Me.ddlOutputTableNameBlitzWho_BlitzAnalysis.Tag = "OutputTableNameBlitzWho"
        '
        'lblOutputTableNameBlitzWho_BlitzAnalysis
        '
        Me.lblOutputTableNameBlitzWho_BlitzAnalysis.AutoSize = True
        Me.lblOutputTableNameBlitzWho_BlitzAnalysis.Location = New System.Drawing.Point(1048, 177)
        Me.lblOutputTableNameBlitzWho_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputTableNameBlitzWho_BlitzAnalysis.Name = "lblOutputTableNameBlitzWho_BlitzAnalysis"
        Me.lblOutputTableNameBlitzWho_BlitzAnalysis.Size = New System.Drawing.Size(173, 16)
        Me.lblOutputTableNameBlitzWho_BlitzAnalysis.TabIndex = 91
        Me.lblOutputTableNameBlitzWho_BlitzAnalysis.Text = "OutputTableNameBlitzWho:"
        '
        'ddlOutputTableNameWaitStats_BlitzAnalysis
        '
        Me.ddlOutputTableNameWaitStats_BlitzAnalysis.FormattingEnabled = True
        Me.ddlOutputTableNameWaitStats_BlitzAnalysis.Location = New System.Drawing.Point(1261, 107)
        Me.ddlOutputTableNameWaitStats_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlOutputTableNameWaitStats_BlitzAnalysis.Name = "ddlOutputTableNameWaitStats_BlitzAnalysis"
        Me.ddlOutputTableNameWaitStats_BlitzAnalysis.Size = New System.Drawing.Size(236, 24)
        Me.ddlOutputTableNameWaitStats_BlitzAnalysis.TabIndex = 90
        Me.ddlOutputTableNameWaitStats_BlitzAnalysis.Tag = "OutputTableNameWaitStats;"
        '
        'lblOutputTableNameWaitStats_BlitzAnalysis
        '
        Me.lblOutputTableNameWaitStats_BlitzAnalysis.AutoSize = True
        Me.lblOutputTableNameWaitStats_BlitzAnalysis.Location = New System.Drawing.Point(1048, 111)
        Me.lblOutputTableNameWaitStats_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputTableNameWaitStats_BlitzAnalysis.Name = "lblOutputTableNameWaitStats_BlitzAnalysis"
        Me.lblOutputTableNameWaitStats_BlitzAnalysis.Size = New System.Drawing.Size(178, 16)
        Me.lblOutputTableNameWaitStats_BlitzAnalysis.TabIndex = 89
        Me.lblOutputTableNameWaitStats_BlitzAnalysis.Text = "OutputTableNameWaitStats:"
        '
        'ddlOutputTableNameBlitzFirst_BlitzAnalysis
        '
        Me.ddlOutputTableNameBlitzFirst_BlitzAnalysis.FormattingEnabled = True
        Me.ddlOutputTableNameBlitzFirst_BlitzAnalysis.Location = New System.Drawing.Point(1261, 7)
        Me.ddlOutputTableNameBlitzFirst_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlOutputTableNameBlitzFirst_BlitzAnalysis.Name = "ddlOutputTableNameBlitzFirst_BlitzAnalysis"
        Me.ddlOutputTableNameBlitzFirst_BlitzAnalysis.Size = New System.Drawing.Size(236, 24)
        Me.ddlOutputTableNameBlitzFirst_BlitzAnalysis.TabIndex = 88
        Me.ddlOutputTableNameBlitzFirst_BlitzAnalysis.Tag = "OutputTableNameBlitzFirst;"
        '
        'lblOutputTableNameBlitzFirst_BlitzAnalysis
        '
        Me.lblOutputTableNameBlitzFirst_BlitzAnalysis.AutoSize = True
        Me.lblOutputTableNameBlitzFirst_BlitzAnalysis.Location = New System.Drawing.Point(1048, 11)
        Me.lblOutputTableNameBlitzFirst_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputTableNameBlitzFirst_BlitzAnalysis.Name = "lblOutputTableNameBlitzFirst_BlitzAnalysis"
        Me.lblOutputTableNameBlitzFirst_BlitzAnalysis.Size = New System.Drawing.Size(170, 16)
        Me.lblOutputTableNameBlitzFirst_BlitzAnalysis.TabIndex = 87
        Me.lblOutputTableNameBlitzFirst_BlitzAnalysis.Text = "OutputTableNameBlitzFirst:"
        '
        'ddlOutputSchemaName_BlitzAnalysis
        '
        Me.ddlOutputSchemaName_BlitzAnalysis.FormattingEnabled = True
        Me.ddlOutputSchemaName_BlitzAnalysis.Location = New System.Drawing.Point(779, 41)
        Me.ddlOutputSchemaName_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlOutputSchemaName_BlitzAnalysis.Name = "ddlOutputSchemaName_BlitzAnalysis"
        Me.ddlOutputSchemaName_BlitzAnalysis.Size = New System.Drawing.Size(236, 24)
        Me.ddlOutputSchemaName_BlitzAnalysis.TabIndex = 86
        Me.ddlOutputSchemaName_BlitzAnalysis.Tag = "OutputSchemaName;"
        '
        'lblOutputSchemaName_BlitzAnalysis
        '
        Me.lblOutputSchemaName_BlitzAnalysis.AutoSize = True
        Me.lblOutputSchemaName_BlitzAnalysis.Location = New System.Drawing.Point(621, 44)
        Me.lblOutputSchemaName_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputSchemaName_BlitzAnalysis.Name = "lblOutputSchemaName_BlitzAnalysis"
        Me.lblOutputSchemaName_BlitzAnalysis.Size = New System.Drawing.Size(135, 16)
        Me.lblOutputSchemaName_BlitzAnalysis.TabIndex = 85
        Me.lblOutputSchemaName_BlitzAnalysis.Tag = ""
        Me.lblOutputSchemaName_BlitzAnalysis.Text = "OutputSchemaName:"
        '
        'ddlOutputDatabaseName_BlitzAnalysis
        '
        Me.ddlOutputDatabaseName_BlitzAnalysis.FormattingEnabled = True
        Me.ddlOutputDatabaseName_BlitzAnalysis.Location = New System.Drawing.Point(779, 7)
        Me.ddlOutputDatabaseName_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlOutputDatabaseName_BlitzAnalysis.Name = "ddlOutputDatabaseName_BlitzAnalysis"
        Me.ddlOutputDatabaseName_BlitzAnalysis.Size = New System.Drawing.Size(236, 24)
        Me.ddlOutputDatabaseName_BlitzAnalysis.TabIndex = 84
        Me.ddlOutputDatabaseName_BlitzAnalysis.Tag = "OutputDatabaseName;"
        '
        'lblOutputDatabaseName_BlitzAnalysis
        '
        Me.lblOutputDatabaseName_BlitzAnalysis.AutoSize = True
        Me.lblOutputDatabaseName_BlitzAnalysis.Location = New System.Drawing.Point(621, 11)
        Me.lblOutputDatabaseName_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputDatabaseName_BlitzAnalysis.Name = "lblOutputDatabaseName_BlitzAnalysis"
        Me.lblOutputDatabaseName_BlitzAnalysis.Size = New System.Drawing.Size(145, 16)
        Me.lblOutputDatabaseName_BlitzAnalysis.TabIndex = 83
        Me.lblOutputDatabaseName_BlitzAnalysis.Text = "OutputDatabaseName:"
        '
        'dtpEndTime_BlitzAnalysis
        '
        Me.dtpEndTime_BlitzAnalysis.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime_BlitzAnalysis.Location = New System.Drawing.Point(221, 39)
        Me.dtpEndTime_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEndTime_BlitzAnalysis.Name = "dtpEndTime_BlitzAnalysis"
        Me.dtpEndTime_BlitzAnalysis.ShowUpDown = True
        Me.dtpEndTime_BlitzAnalysis.Size = New System.Drawing.Size(115, 22)
        Me.dtpEndTime_BlitzAnalysis.TabIndex = 82
        '
        'dtpStartTime_BlitzAnalysis
        '
        Me.dtpStartTime_BlitzAnalysis.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime_BlitzAnalysis.Location = New System.Drawing.Point(221, 7)
        Me.dtpStartTime_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStartTime_BlitzAnalysis.Name = "dtpStartTime_BlitzAnalysis"
        Me.dtpStartTime_BlitzAnalysis.ShowUpDown = True
        Me.dtpStartTime_BlitzAnalysis.Size = New System.Drawing.Size(115, 22)
        Me.dtpStartTime_BlitzAnalysis.TabIndex = 81
        '
        'dtpEndDate_BlitzAnalysis
        '
        Me.dtpEndDate_BlitzAnalysis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate_BlitzAnalysis.Location = New System.Drawing.Point(87, 39)
        Me.dtpEndDate_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEndDate_BlitzAnalysis.Name = "dtpEndDate_BlitzAnalysis"
        Me.dtpEndDate_BlitzAnalysis.Size = New System.Drawing.Size(125, 22)
        Me.dtpEndDate_BlitzAnalysis.TabIndex = 80
        Me.dtpEndDate_BlitzAnalysis.Tag = "EndDate"
        '
        'lblEndDate_BlitzAnalysis
        '
        Me.lblEndDate_BlitzAnalysis.AutoSize = True
        Me.lblEndDate_BlitzAnalysis.Location = New System.Drawing.Point(9, 43)
        Me.lblEndDate_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndDate_BlitzAnalysis.Name = "lblEndDate_BlitzAnalysis"
        Me.lblEndDate_BlitzAnalysis.Size = New System.Drawing.Size(63, 16)
        Me.lblEndDate_BlitzAnalysis.TabIndex = 79
        Me.lblEndDate_BlitzAnalysis.Text = "EndDate:"
        '
        'dtpStartDate_BlitzAnalysis
        '
        Me.dtpStartDate_BlitzAnalysis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate_BlitzAnalysis.Location = New System.Drawing.Point(87, 7)
        Me.dtpStartDate_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStartDate_BlitzAnalysis.Name = "dtpStartDate_BlitzAnalysis"
        Me.dtpStartDate_BlitzAnalysis.Size = New System.Drawing.Size(125, 22)
        Me.dtpStartDate_BlitzAnalysis.TabIndex = 78
        Me.dtpStartDate_BlitzAnalysis.Tag = "StartDate"
        '
        'lblStartDate_BlitzAnalysis
        '
        Me.lblStartDate_BlitzAnalysis.AutoSize = True
        Me.lblStartDate_BlitzAnalysis.Location = New System.Drawing.Point(5, 11)
        Me.lblStartDate_BlitzAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartDate_BlitzAnalysis.Name = "lblStartDate_BlitzAnalysis"
        Me.lblStartDate_BlitzAnalysis.Size = New System.Drawing.Size(66, 16)
        Me.lblStartDate_BlitzAnalysis.TabIndex = 77
        Me.lblStartDate_BlitzAnalysis.Text = "StartDate:"
        '
        'sp_BlitzBackups
        '
        Me.sp_BlitzBackups.Controls.Add(Me.intHoursBack_BlitzBackups)
        Me.sp_BlitzBackups.Controls.Add(Me.lblHoursBack_BlitzBackups)
        Me.sp_BlitzBackups.Location = New System.Drawing.Point(4, 25)
        Me.sp_BlitzBackups.Margin = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzBackups.Name = "sp_BlitzBackups"
        Me.sp_BlitzBackups.Size = New System.Drawing.Size(1569, 215)
        Me.sp_BlitzBackups.TabIndex = 9
        Me.sp_BlitzBackups.Text = "Parameters BlitzBackups"
        Me.sp_BlitzBackups.UseVisualStyleBackColor = True
        '
        'intHoursBack_BlitzBackups
        '
        Me.intHoursBack_BlitzBackups.Location = New System.Drawing.Point(104, 17)
        Me.intHoursBack_BlitzBackups.Margin = New System.Windows.Forms.Padding(4)
        Me.intHoursBack_BlitzBackups.Name = "intHoursBack_BlitzBackups"
        Me.intHoursBack_BlitzBackups.Size = New System.Drawing.Size(88, 22)
        Me.intHoursBack_BlitzBackups.TabIndex = 106
        Me.intHoursBack_BlitzBackups.Tag = "HoursBack;168"
        Me.intHoursBack_BlitzBackups.Text = "168"
        '
        'lblHoursBack_BlitzBackups
        '
        Me.lblHoursBack_BlitzBackups.AutoSize = True
        Me.lblHoursBack_BlitzBackups.Location = New System.Drawing.Point(12, 21)
        Me.lblHoursBack_BlitzBackups.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoursBack_BlitzBackups.Name = "lblHoursBack_BlitzBackups"
        Me.lblHoursBack_BlitzBackups.Size = New System.Drawing.Size(77, 16)
        Me.lblHoursBack_BlitzBackups.TabIndex = 105
        Me.lblHoursBack_BlitzBackups.Text = "HoursBack:"
        '
        'sp_BlitzCache
        '
        Me.sp_BlitzCache.Controls.Add(Me.chkBringThePain_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.chkSkipAanlysis_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.strSlowlySearchPlansFor_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.intMinutesBack_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.lblMinutesBack_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.MinimumExecutionCount_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.lblMinimumExecutionCount_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.lblSlowlySearchPlansFor_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.ddlStoredProcName_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.lblStoredProcName_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.ddlDatabaseName_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.lblDatabaseName_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.ddlQueryFilter_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.lblQueryFilter_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.chkIgnoreSystemDVs_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.chkHideSummary_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.intDurationFilter_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.lblDurationFilter_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.ddlSortOrder_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.lblSortOrder_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.chkExpertMode_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.chkExportToExcel_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.intTop_BlitzCache)
        Me.sp_BlitzCache.Controls.Add(Me.lblTop_BlitzCache)
        Me.sp_BlitzCache.Location = New System.Drawing.Point(4, 25)
        Me.sp_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzCache.Name = "sp_BlitzCache"
        Me.sp_BlitzCache.Padding = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzCache.Size = New System.Drawing.Size(1569, 215)
        Me.sp_BlitzCache.TabIndex = 1
        Me.sp_BlitzCache.Text = "Parameters BlitzCache"
        Me.sp_BlitzCache.UseVisualStyleBackColor = True
        '
        'chkBringThePain_BlitzCache
        '
        Me.chkBringThePain_BlitzCache.AutoSize = True
        Me.chkBringThePain_BlitzCache.Location = New System.Drawing.Point(23, 104)
        Me.chkBringThePain_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBringThePain_BlitzCache.Name = "chkBringThePain_BlitzCache"
        Me.chkBringThePain_BlitzCache.Size = New System.Drawing.Size(111, 20)
        Me.chkBringThePain_BlitzCache.TabIndex = 55
        Me.chkBringThePain_BlitzCache.Tag = "BringThePain;0"
        Me.chkBringThePain_BlitzCache.Text = "BringThePain"
        Me.chkBringThePain_BlitzCache.UseVisualStyleBackColor = True
        '
        'chkSkipAanlysis_BlitzCache
        '
        Me.chkSkipAanlysis_BlitzCache.AutoSize = True
        Me.chkSkipAanlysis_BlitzCache.Location = New System.Drawing.Point(23, 132)
        Me.chkSkipAanlysis_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSkipAanlysis_BlitzCache.Name = "chkSkipAanlysis_BlitzCache"
        Me.chkSkipAanlysis_BlitzCache.Size = New System.Drawing.Size(110, 20)
        Me.chkSkipAanlysis_BlitzCache.TabIndex = 54
        Me.chkSkipAanlysis_BlitzCache.Tag = "SkipAnalysis;0"
        Me.chkSkipAanlysis_BlitzCache.Text = "Skip Analysis"
        Me.chkSkipAanlysis_BlitzCache.UseVisualStyleBackColor = True
        '
        'strSlowlySearchPlansFor_BlitzCache
        '
        Me.strSlowlySearchPlansFor_BlitzCache.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.strSlowlySearchPlansFor_BlitzCache.Location = New System.Drawing.Point(931, 145)
        Me.strSlowlySearchPlansFor_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.strSlowlySearchPlansFor_BlitzCache.Name = "strSlowlySearchPlansFor_BlitzCache"
        Me.strSlowlySearchPlansFor_BlitzCache.Size = New System.Drawing.Size(627, 22)
        Me.strSlowlySearchPlansFor_BlitzCache.TabIndex = 51
        Me.strSlowlySearchPlansFor_BlitzCache.Tag = "SlowlySearchPlansFor"
        '
        'intMinutesBack_BlitzCache
        '
        Me.intMinutesBack_BlitzCache.Location = New System.Drawing.Point(931, 113)
        Me.intMinutesBack_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.intMinutesBack_BlitzCache.Name = "intMinutesBack_BlitzCache"
        Me.intMinutesBack_BlitzCache.Size = New System.Drawing.Size(51, 22)
        Me.intMinutesBack_BlitzCache.TabIndex = 50
        Me.intMinutesBack_BlitzCache.Tag = "MinutesBack"
        '
        'lblMinutesBack_BlitzCache
        '
        Me.lblMinutesBack_BlitzCache.AutoSize = True
        Me.lblMinutesBack_BlitzCache.Location = New System.Drawing.Point(755, 116)
        Me.lblMinutesBack_BlitzCache.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinutesBack_BlitzCache.Name = "lblMinutesBack_BlitzCache"
        Me.lblMinutesBack_BlitzCache.Size = New System.Drawing.Size(87, 16)
        Me.lblMinutesBack_BlitzCache.TabIndex = 49
        Me.lblMinutesBack_BlitzCache.Text = "MinutesBack:"
        '
        'MinimumExecutionCount_BlitzCache
        '
        Me.MinimumExecutionCount_BlitzCache.Location = New System.Drawing.Point(931, 79)
        Me.MinimumExecutionCount_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumExecutionCount_BlitzCache.Name = "MinimumExecutionCount_BlitzCache"
        Me.MinimumExecutionCount_BlitzCache.Size = New System.Drawing.Size(51, 22)
        Me.MinimumExecutionCount_BlitzCache.TabIndex = 48
        Me.MinimumExecutionCount_BlitzCache.Tag = "MinimumExecutionCount"
        '
        'lblMinimumExecutionCount_BlitzCache
        '
        Me.lblMinimumExecutionCount_BlitzCache.AutoSize = True
        Me.lblMinimumExecutionCount_BlitzCache.Location = New System.Drawing.Point(755, 82)
        Me.lblMinimumExecutionCount_BlitzCache.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinimumExecutionCount_BlitzCache.Name = "lblMinimumExecutionCount_BlitzCache"
        Me.lblMinimumExecutionCount_BlitzCache.Size = New System.Drawing.Size(155, 16)
        Me.lblMinimumExecutionCount_BlitzCache.TabIndex = 47
        Me.lblMinimumExecutionCount_BlitzCache.Text = "MinimumExecutionCount:"
        '
        'lblSlowlySearchPlansFor_BlitzCache
        '
        Me.lblSlowlySearchPlansFor_BlitzCache.AutoSize = True
        Me.lblSlowlySearchPlansFor_BlitzCache.Location = New System.Drawing.Point(755, 149)
        Me.lblSlowlySearchPlansFor_BlitzCache.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSlowlySearchPlansFor_BlitzCache.Name = "lblSlowlySearchPlansFor_BlitzCache"
        Me.lblSlowlySearchPlansFor_BlitzCache.Size = New System.Drawing.Size(146, 16)
        Me.lblSlowlySearchPlansFor_BlitzCache.TabIndex = 45
        Me.lblSlowlySearchPlansFor_BlitzCache.Text = "SlowlySearchPlansFor:"
        '
        'ddlStoredProcName_BlitzCache
        '
        Me.ddlStoredProcName_BlitzCache.Enabled = False
        Me.ddlStoredProcName_BlitzCache.FormattingEnabled = True
        Me.ddlStoredProcName_BlitzCache.Location = New System.Drawing.Point(325, 48)
        Me.ddlStoredProcName_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlStoredProcName_BlitzCache.Name = "ddlStoredProcName_BlitzCache"
        Me.ddlStoredProcName_BlitzCache.Size = New System.Drawing.Size(396, 24)
        Me.ddlStoredProcName_BlitzCache.TabIndex = 44
        Me.ddlStoredProcName_BlitzCache.Tag = "StoredProcName"
        '
        'lblStoredProcName_BlitzCache
        '
        Me.lblStoredProcName_BlitzCache.AutoSize = True
        Me.lblStoredProcName_BlitzCache.Location = New System.Drawing.Point(196, 53)
        Me.lblStoredProcName_BlitzCache.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoredProcName_BlitzCache.Name = "lblStoredProcName_BlitzCache"
        Me.lblStoredProcName_BlitzCache.Size = New System.Drawing.Size(115, 16)
        Me.lblStoredProcName_BlitzCache.TabIndex = 43
        Me.lblStoredProcName_BlitzCache.Text = "StoredProcName:"
        '
        'ddlDatabaseName_BlitzCache
        '
        Me.ddlDatabaseName_BlitzCache.FormattingEnabled = True
        Me.ddlDatabaseName_BlitzCache.Location = New System.Drawing.Point(324, 16)
        Me.ddlDatabaseName_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlDatabaseName_BlitzCache.Name = "ddlDatabaseName_BlitzCache"
        Me.ddlDatabaseName_BlitzCache.Size = New System.Drawing.Size(397, 24)
        Me.ddlDatabaseName_BlitzCache.TabIndex = 42
        Me.ddlDatabaseName_BlitzCache.Tag = "DatabaseName"
        '
        'lblDatabaseName_BlitzCache
        '
        Me.lblDatabaseName_BlitzCache.AutoSize = True
        Me.lblDatabaseName_BlitzCache.Location = New System.Drawing.Point(196, 20)
        Me.lblDatabaseName_BlitzCache.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabaseName_BlitzCache.Name = "lblDatabaseName_BlitzCache"
        Me.lblDatabaseName_BlitzCache.Size = New System.Drawing.Size(107, 16)
        Me.lblDatabaseName_BlitzCache.TabIndex = 41
        Me.lblDatabaseName_BlitzCache.Text = "DatabaseName:"
        '
        'ddlQueryFilter_BlitzCache
        '
        Me.ddlQueryFilter_BlitzCache.FormattingEnabled = True
        Me.ddlQueryFilter_BlitzCache.Items.AddRange(New Object() {"< All >", "Procedures", "Statements", "Functions"})
        Me.ddlQueryFilter_BlitzCache.Location = New System.Drawing.Point(324, 81)
        Me.ddlQueryFilter_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlQueryFilter_BlitzCache.Name = "ddlQueryFilter_BlitzCache"
        Me.ddlQueryFilter_BlitzCache.Size = New System.Drawing.Size(397, 24)
        Me.ddlQueryFilter_BlitzCache.TabIndex = 40
        Me.ddlQueryFilter_BlitzCache.Tag = "QueryFilter;All"
        Me.ddlQueryFilter_BlitzCache.Text = "< All >"
        '
        'lblQueryFilter_BlitzCache
        '
        Me.lblQueryFilter_BlitzCache.AutoSize = True
        Me.lblQueryFilter_BlitzCache.Location = New System.Drawing.Point(196, 85)
        Me.lblQueryFilter_BlitzCache.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQueryFilter_BlitzCache.Name = "lblQueryFilter_BlitzCache"
        Me.lblQueryFilter_BlitzCache.Size = New System.Drawing.Size(75, 16)
        Me.lblQueryFilter_BlitzCache.TabIndex = 39
        Me.lblQueryFilter_BlitzCache.Text = "QueryFilter:"
        '
        'chkIgnoreSystemDVs_BlitzCache
        '
        Me.chkIgnoreSystemDVs_BlitzCache.AutoSize = True
        Me.chkIgnoreSystemDVs_BlitzCache.Location = New System.Drawing.Point(23, 75)
        Me.chkIgnoreSystemDVs_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIgnoreSystemDVs_BlitzCache.Name = "chkIgnoreSystemDVs_BlitzCache"
        Me.chkIgnoreSystemDVs_BlitzCache.Size = New System.Drawing.Size(138, 20)
        Me.chkIgnoreSystemDVs_BlitzCache.TabIndex = 38
        Me.chkIgnoreSystemDVs_BlitzCache.Tag = "IgnoreSystemDBs;0"
        Me.chkIgnoreSystemDVs_BlitzCache.Text = "IgnoreSystemDBs"
        Me.chkIgnoreSystemDVs_BlitzCache.UseVisualStyleBackColor = True
        '
        'chkHideSummary_BlitzCache
        '
        Me.chkHideSummary_BlitzCache.AutoSize = True
        Me.chkHideSummary_BlitzCache.Location = New System.Drawing.Point(23, 47)
        Me.chkHideSummary_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.chkHideSummary_BlitzCache.Name = "chkHideSummary_BlitzCache"
        Me.chkHideSummary_BlitzCache.Size = New System.Drawing.Size(115, 20)
        Me.chkHideSummary_BlitzCache.TabIndex = 37
        Me.chkHideSummary_BlitzCache.Tag = "HideSummary;0"
        Me.chkHideSummary_BlitzCache.Text = "HideSummary"
        Me.chkHideSummary_BlitzCache.UseVisualStyleBackColor = True
        '
        'intDurationFilter_BlitzCache
        '
        Me.intDurationFilter_BlitzCache.Location = New System.Drawing.Point(931, 46)
        Me.intDurationFilter_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.intDurationFilter_BlitzCache.Name = "intDurationFilter_BlitzCache"
        Me.intDurationFilter_BlitzCache.Size = New System.Drawing.Size(51, 22)
        Me.intDurationFilter_BlitzCache.TabIndex = 36
        Me.intDurationFilter_BlitzCache.Tag = "DurationFilter"
        '
        'lblDurationFilter_BlitzCache
        '
        Me.lblDurationFilter_BlitzCache.AutoSize = True
        Me.lblDurationFilter_BlitzCache.Location = New System.Drawing.Point(755, 50)
        Me.lblDurationFilter_BlitzCache.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDurationFilter_BlitzCache.Name = "lblDurationFilter_BlitzCache"
        Me.lblDurationFilter_BlitzCache.Size = New System.Drawing.Size(152, 16)
        Me.lblDurationFilter_BlitzCache.TabIndex = 35
        Me.lblDurationFilter_BlitzCache.Text = "DurationFilter (seconds):"
        '
        'ddlSortOrder_BlitzCache
        '
        Me.ddlSortOrder_BlitzCache.FormattingEnabled = True
        Me.ddlSortOrder_BlitzCache.Items.AddRange(New Object() {"CPU (Default)", "Avg Cpu", "Reads", "Avg Reads", "Writes", "Avg Writes", "Duration", "Avg Duration", "Executions", "Executions per minute", "Recent Compilations", "Memory Grant", "Unused Grant", "Spills", "Query Hash", "All", "All Avg"})
        Me.ddlSortOrder_BlitzCache.Location = New System.Drawing.Point(324, 116)
        Me.ddlSortOrder_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSortOrder_BlitzCache.Name = "ddlSortOrder_BlitzCache"
        Me.ddlSortOrder_BlitzCache.Size = New System.Drawing.Size(397, 24)
        Me.ddlSortOrder_BlitzCache.TabIndex = 34
        Me.ddlSortOrder_BlitzCache.Tag = "SortOrder;CPU"
        Me.ddlSortOrder_BlitzCache.Text = "CPU (Default)"
        '
        'lblSortOrder_BlitzCache
        '
        Me.lblSortOrder_BlitzCache.AutoSize = True
        Me.lblSortOrder_BlitzCache.Location = New System.Drawing.Point(196, 118)
        Me.lblSortOrder_BlitzCache.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSortOrder_BlitzCache.Name = "lblSortOrder_BlitzCache"
        Me.lblSortOrder_BlitzCache.Size = New System.Drawing.Size(68, 16)
        Me.lblSortOrder_BlitzCache.TabIndex = 33
        Me.lblSortOrder_BlitzCache.Text = "SortOrder:"
        '
        'chkExpertMode_BlitzCache
        '
        Me.chkExpertMode_BlitzCache.AutoSize = True
        Me.chkExpertMode_BlitzCache.Location = New System.Drawing.Point(23, 18)
        Me.chkExpertMode_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.chkExpertMode_BlitzCache.Name = "chkExpertMode_BlitzCache"
        Me.chkExpertMode_BlitzCache.Size = New System.Drawing.Size(102, 20)
        Me.chkExpertMode_BlitzCache.TabIndex = 32
        Me.chkExpertMode_BlitzCache.Tag = "ExpertMode;0"
        Me.chkExpertMode_BlitzCache.Text = "ExpertMode"
        Me.chkExpertMode_BlitzCache.UseVisualStyleBackColor = True
        '
        'chkExportToExcel_BlitzCache
        '
        Me.chkExportToExcel_BlitzCache.AutoSize = True
        Me.chkExportToExcel_BlitzCache.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkExportToExcel_BlitzCache.Location = New System.Drawing.Point(23, 160)
        Me.chkExportToExcel_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.chkExportToExcel_BlitzCache.Name = "chkExportToExcel_BlitzCache"
        Me.chkExportToExcel_BlitzCache.Size = New System.Drawing.Size(117, 20)
        Me.chkExportToExcel_BlitzCache.TabIndex = 31
        Me.chkExportToExcel_BlitzCache.Tag = "ExportToExcel;0"
        Me.chkExportToExcel_BlitzCache.Text = "ExportToExcel"
        Me.chkExportToExcel_BlitzCache.UseVisualStyleBackColor = True
        '
        'intTop_BlitzCache
        '
        Me.intTop_BlitzCache.Location = New System.Drawing.Point(931, 15)
        Me.intTop_BlitzCache.Margin = New System.Windows.Forms.Padding(4)
        Me.intTop_BlitzCache.Name = "intTop_BlitzCache"
        Me.intTop_BlitzCache.Size = New System.Drawing.Size(51, 22)
        Me.intTop_BlitzCache.TabIndex = 30
        Me.intTop_BlitzCache.Tag = "Top;10"
        Me.intTop_BlitzCache.Text = "10"
        '
        'lblTop_BlitzCache
        '
        Me.lblTop_BlitzCache.AutoSize = True
        Me.lblTop_BlitzCache.Location = New System.Drawing.Point(755, 18)
        Me.lblTop_BlitzCache.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTop_BlitzCache.Name = "lblTop_BlitzCache"
        Me.lblTop_BlitzCache.Size = New System.Drawing.Size(35, 16)
        Me.lblTop_BlitzCache.TabIndex = 29
        Me.lblTop_BlitzCache.Text = "Top:"
        '
        'sp_BlitzFirst
        '
        Me.sp_BlitzFirst.Controls.Add(Me.chkBlitzWhoEnd_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkBlitzCache_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkWaitStats_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkPerfmonStats_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkFileStats_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkFindings_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkBlitzWhoStart_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.lblOutputResultSets_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.ddlOutputType_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.lblOutputType_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkSinceStartup_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.intFileLatencyThresholdMS_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.lblFileLatencyThresholdMS_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkCheckServerInfo_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.intMemoryGrantThresholdPct_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.lblMemoryGrantThresholdPct_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkBlitzCacheSkipAnalysis_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkShowSleepingSPIDs_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkCheckProcedureCache_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.ddlFilterPlansByDatabase_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.lblFilterPlansByDatabase_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.intSeconds_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.lblSeconds_BlitzFirst)
        Me.sp_BlitzFirst.Controls.Add(Me.chkExpertMode_BlitzFirst)
        Me.sp_BlitzFirst.Location = New System.Drawing.Point(4, 25)
        Me.sp_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzFirst.Name = "sp_BlitzFirst"
        Me.sp_BlitzFirst.Size = New System.Drawing.Size(1569, 215)
        Me.sp_BlitzFirst.TabIndex = 7
        Me.sp_BlitzFirst.Text = "Parameters BlitzFirst"
        Me.sp_BlitzFirst.UseVisualStyleBackColor = True
        '
        'ddlOutputType_BlitzFirst
        '
        Me.ddlOutputType_BlitzFirst.FormattingEnabled = True
        Me.ddlOutputType_BlitzFirst.Items.AddRange(New Object() {"TABLE (Default)", "Opserver1", "TOP10"})
        Me.ddlOutputType_BlitzFirst.Location = New System.Drawing.Point(472, 12)
        Me.ddlOutputType_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlOutputType_BlitzFirst.Name = "ddlOutputType_BlitzFirst"
        Me.ddlOutputType_BlitzFirst.Size = New System.Drawing.Size(212, 24)
        Me.ddlOutputType_BlitzFirst.TabIndex = 56
        Me.ddlOutputType_BlitzFirst.Tag = "OutputType;TABLE"
        '
        'lblOutputType_BlitzFirst
        '
        Me.lblOutputType_BlitzFirst.AutoSize = True
        Me.lblOutputType_BlitzFirst.Location = New System.Drawing.Point(284, 15)
        Me.lblOutputType_BlitzFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputType_BlitzFirst.Name = "lblOutputType_BlitzFirst"
        Me.lblOutputType_BlitzFirst.Size = New System.Drawing.Size(80, 16)
        Me.lblOutputType_BlitzFirst.TabIndex = 55
        Me.lblOutputType_BlitzFirst.Text = "OutputType:"
        '
        'chkSinceStartup_BlitzFirst
        '
        Me.chkSinceStartup_BlitzFirst.AutoSize = True
        Me.chkSinceStartup_BlitzFirst.Location = New System.Drawing.Point(27, 156)
        Me.chkSinceStartup_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSinceStartup_BlitzFirst.Name = "chkSinceStartup_BlitzFirst"
        Me.chkSinceStartup_BlitzFirst.Size = New System.Drawing.Size(105, 20)
        Me.chkSinceStartup_BlitzFirst.TabIndex = 53
        Me.chkSinceStartup_BlitzFirst.Tag = "SinceStartup;0"
        Me.chkSinceStartup_BlitzFirst.Text = "SinceStartup"
        Me.chkSinceStartup_BlitzFirst.UseVisualStyleBackColor = True
        '
        'intFileLatencyThresholdMS_BlitzFirst
        '
        Me.intFileLatencyThresholdMS_BlitzFirst.Location = New System.Drawing.Point(472, 41)
        Me.intFileLatencyThresholdMS_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.intFileLatencyThresholdMS_BlitzFirst.Name = "intFileLatencyThresholdMS_BlitzFirst"
        Me.intFileLatencyThresholdMS_BlitzFirst.Size = New System.Drawing.Size(212, 22)
        Me.intFileLatencyThresholdMS_BlitzFirst.TabIndex = 52
        Me.intFileLatencyThresholdMS_BlitzFirst.Tag = "FileLatencyThresholdMS;100"
        Me.intFileLatencyThresholdMS_BlitzFirst.Text = "100"
        '
        'lblFileLatencyThresholdMS_BlitzFirst
        '
        Me.lblFileLatencyThresholdMS_BlitzFirst.AutoSize = True
        Me.lblFileLatencyThresholdMS_BlitzFirst.Location = New System.Drawing.Point(284, 44)
        Me.lblFileLatencyThresholdMS_BlitzFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFileLatencyThresholdMS_BlitzFirst.Name = "lblFileLatencyThresholdMS_BlitzFirst"
        Me.lblFileLatencyThresholdMS_BlitzFirst.Size = New System.Drawing.Size(160, 16)
        Me.lblFileLatencyThresholdMS_BlitzFirst.TabIndex = 51
        Me.lblFileLatencyThresholdMS_BlitzFirst.Tag = "FileLatencyThresholdMS"
        Me.lblFileLatencyThresholdMS_BlitzFirst.Text = "FileLatencyThresholdMS:"
        '
        'chkCheckServerInfo_BlitzFirst
        '
        Me.chkCheckServerInfo_BlitzFirst.AutoSize = True
        Me.chkCheckServerInfo_BlitzFirst.Checked = True
        Me.chkCheckServerInfo_BlitzFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCheckServerInfo_BlitzFirst.Location = New System.Drawing.Point(27, 71)
        Me.chkCheckServerInfo_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCheckServerInfo_BlitzFirst.Name = "chkCheckServerInfo_BlitzFirst"
        Me.chkCheckServerInfo_BlitzFirst.Size = New System.Drawing.Size(128, 20)
        Me.chkCheckServerInfo_BlitzFirst.TabIndex = 50
        Me.chkCheckServerInfo_BlitzFirst.Tag = "CheckServerInfo;1"
        Me.chkCheckServerInfo_BlitzFirst.Text = "CheckServerInfo"
        Me.chkCheckServerInfo_BlitzFirst.UseVisualStyleBackColor = True
        '
        'intMemoryGrantThresholdPct_BlitzFirst
        '
        Me.intMemoryGrantThresholdPct_BlitzFirst.Location = New System.Drawing.Point(472, 108)
        Me.intMemoryGrantThresholdPct_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.intMemoryGrantThresholdPct_BlitzFirst.Name = "intMemoryGrantThresholdPct_BlitzFirst"
        Me.intMemoryGrantThresholdPct_BlitzFirst.Size = New System.Drawing.Size(212, 22)
        Me.intMemoryGrantThresholdPct_BlitzFirst.TabIndex = 49
        Me.intMemoryGrantThresholdPct_BlitzFirst.Tag = "MemoryGrantThresholdPct;15"
        Me.intMemoryGrantThresholdPct_BlitzFirst.Text = "15"
        '
        'lblMemoryGrantThresholdPct_BlitzFirst
        '
        Me.lblMemoryGrantThresholdPct_BlitzFirst.AutoSize = True
        Me.lblMemoryGrantThresholdPct_BlitzFirst.Location = New System.Drawing.Point(284, 112)
        Me.lblMemoryGrantThresholdPct_BlitzFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMemoryGrantThresholdPct_BlitzFirst.Name = "lblMemoryGrantThresholdPct_BlitzFirst"
        Me.lblMemoryGrantThresholdPct_BlitzFirst.Size = New System.Drawing.Size(171, 16)
        Me.lblMemoryGrantThresholdPct_BlitzFirst.TabIndex = 48
        Me.lblMemoryGrantThresholdPct_BlitzFirst.Tag = "MemoryGrantThresholdPct"
        Me.lblMemoryGrantThresholdPct_BlitzFirst.Text = "MemoryGrantThresholdPct:"
        '
        'chkBlitzCacheSkipAnalysis_BlitzFirst
        '
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.AutoSize = True
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.Checked = True
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.Location = New System.Drawing.Point(27, 15)
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.Name = "chkBlitzCacheSkipAnalysis_BlitzFirst"
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.Size = New System.Drawing.Size(170, 20)
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.TabIndex = 47
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.Tag = "BlitzCacheSkipAnalysis;1"
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.Text = "BlitzCacheSkipAnalysis"
        Me.chkBlitzCacheSkipAnalysis_BlitzFirst.UseVisualStyleBackColor = True
        '
        'chkShowSleepingSPIDs_BlitzFirst
        '
        Me.chkShowSleepingSPIDs_BlitzFirst.AutoSize = True
        Me.chkShowSleepingSPIDs_BlitzFirst.Location = New System.Drawing.Point(27, 128)
        Me.chkShowSleepingSPIDs_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowSleepingSPIDs_BlitzFirst.Name = "chkShowSleepingSPIDs_BlitzFirst"
        Me.chkShowSleepingSPIDs_BlitzFirst.Size = New System.Drawing.Size(154, 20)
        Me.chkShowSleepingSPIDs_BlitzFirst.TabIndex = 46
        Me.chkShowSleepingSPIDs_BlitzFirst.Tag = "ShowSleepingSPIDs;0"
        Me.chkShowSleepingSPIDs_BlitzFirst.Text = "ShowSleepingSPIDs"
        Me.chkShowSleepingSPIDs_BlitzFirst.UseVisualStyleBackColor = True
        '
        'chkCheckProcedureCache_BlitzFirst
        '
        Me.chkCheckProcedureCache_BlitzFirst.AutoSize = True
        Me.chkCheckProcedureCache_BlitzFirst.Location = New System.Drawing.Point(27, 43)
        Me.chkCheckProcedureCache_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCheckProcedureCache_BlitzFirst.Name = "chkCheckProcedureCache_BlitzFirst"
        Me.chkCheckProcedureCache_BlitzFirst.Size = New System.Drawing.Size(169, 20)
        Me.chkCheckProcedureCache_BlitzFirst.TabIndex = 45
        Me.chkCheckProcedureCache_BlitzFirst.Tag = "CheckProcedureCache;0"
        Me.chkCheckProcedureCache_BlitzFirst.Text = "CheckProcedureCache"
        Me.chkCheckProcedureCache_BlitzFirst.UseVisualStyleBackColor = True
        '
        'ddlFilterPlansByDatabase_BlitzFirst
        '
        Me.ddlFilterPlansByDatabase_BlitzFirst.FormattingEnabled = True
        Me.ddlFilterPlansByDatabase_BlitzFirst.Location = New System.Drawing.Point(472, 73)
        Me.ddlFilterPlansByDatabase_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlFilterPlansByDatabase_BlitzFirst.Name = "ddlFilterPlansByDatabase_BlitzFirst"
        Me.ddlFilterPlansByDatabase_BlitzFirst.Size = New System.Drawing.Size(212, 24)
        Me.ddlFilterPlansByDatabase_BlitzFirst.TabIndex = 44
        Me.ddlFilterPlansByDatabase_BlitzFirst.Tag = "FilterPlansByDatabase"
        '
        'lblFilterPlansByDatabase_BlitzFirst
        '
        Me.lblFilterPlansByDatabase_BlitzFirst.AutoSize = True
        Me.lblFilterPlansByDatabase_BlitzFirst.Location = New System.Drawing.Point(284, 76)
        Me.lblFilterPlansByDatabase_BlitzFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilterPlansByDatabase_BlitzFirst.Name = "lblFilterPlansByDatabase_BlitzFirst"
        Me.lblFilterPlansByDatabase_BlitzFirst.Size = New System.Drawing.Size(149, 16)
        Me.lblFilterPlansByDatabase_BlitzFirst.TabIndex = 43
        Me.lblFilterPlansByDatabase_BlitzFirst.Text = "FilterPlansByDatabase:"
        '
        'intSeconds_BlitzFirst
        '
        Me.intSeconds_BlitzFirst.Location = New System.Drawing.Point(472, 140)
        Me.intSeconds_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.intSeconds_BlitzFirst.Name = "intSeconds_BlitzFirst"
        Me.intSeconds_BlitzFirst.Size = New System.Drawing.Size(212, 22)
        Me.intSeconds_BlitzFirst.TabIndex = 35
        Me.intSeconds_BlitzFirst.Tag = "Seconds;5"
        Me.intSeconds_BlitzFirst.Text = "5"
        '
        'lblSeconds_BlitzFirst
        '
        Me.lblSeconds_BlitzFirst.AutoSize = True
        Me.lblSeconds_BlitzFirst.Location = New System.Drawing.Point(284, 144)
        Me.lblSeconds_BlitzFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeconds_BlitzFirst.Name = "lblSeconds_BlitzFirst"
        Me.lblSeconds_BlitzFirst.Size = New System.Drawing.Size(64, 16)
        Me.lblSeconds_BlitzFirst.TabIndex = 34
        Me.lblSeconds_BlitzFirst.Text = "Seconds:"
        '
        'chkExpertMode_BlitzFirst
        '
        Me.chkExpertMode_BlitzFirst.AutoSize = True
        Me.chkExpertMode_BlitzFirst.Location = New System.Drawing.Point(27, 100)
        Me.chkExpertMode_BlitzFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.chkExpertMode_BlitzFirst.Name = "chkExpertMode_BlitzFirst"
        Me.chkExpertMode_BlitzFirst.Size = New System.Drawing.Size(102, 20)
        Me.chkExpertMode_BlitzFirst.TabIndex = 33
        Me.chkExpertMode_BlitzFirst.Tag = "ExpertMode;0"
        Me.chkExpertMode_BlitzFirst.Text = "ExpertMode"
        Me.chkExpertMode_BlitzFirst.UseVisualStyleBackColor = True
        '
        'sp_BlitzIndex
        '
        Me.sp_BlitzIndex.Controls.Add(Me.Label3)
        Me.sp_BlitzIndex.Controls.Add(Me.Label1)
        Me.sp_BlitzIndex.Controls.Add(Me.ddlMode_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.lblMode_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.chkShowColumnstoreOnly_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.ddlSortDirection_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.lblSortDirection_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.ddlSortOrder_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.lblSortOrder_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.chkShowAllMissingIndexRequests_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.chkIncludeInactiveIndexes_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.strIgnoreDatabases_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.lblIgnoreDatabases_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.chkBringThePain_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.chkGetAllDatabases_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.ddlTableName_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.lblTableName_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.ddlSchemaName_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.lblSchemaName_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.ddlDatabaseName_BlitzIndex)
        Me.sp_BlitzIndex.Controls.Add(Me.lblDatabaseName_BlitzIndex)
        Me.sp_BlitzIndex.Location = New System.Drawing.Point(4, 25)
        Me.sp_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzIndex.Name = "sp_BlitzIndex"
        Me.sp_BlitzIndex.Padding = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzIndex.Size = New System.Drawing.Size(1569, 215)
        Me.sp_BlitzIndex.TabIndex = 2
        Me.sp_BlitzIndex.Text = "Parameters BlitzIndex"
        Me.sp_BlitzIndex.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(805, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 16)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Only affects @Mode = Index Usage Detail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(805, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 16)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Only affects @Mode = Index Usage Detail"
        '
        'ddlMode_BlitzIndex
        '
        Me.ddlMode_BlitzIndex.FormattingEnabled = True
        Me.ddlMode_BlitzIndex.Items.AddRange(New Object() {"Diagnose (0 = Default)", "Summarize (1)", "Index Usage Detail (2)", "Missing Index Detail (3)", "Diagnose Details (4)"})
        Me.ddlMode_BlitzIndex.Location = New System.Drawing.Point(592, 10)
        Me.ddlMode_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlMode_BlitzIndex.Name = "ddlMode_BlitzIndex"
        Me.ddlMode_BlitzIndex.Size = New System.Drawing.Size(204, 24)
        Me.ddlMode_BlitzIndex.TabIndex = 63
        Me.ddlMode_BlitzIndex.Tag = "Mode;0"
        Me.ddlMode_BlitzIndex.Text = "Diagnose (0 = Default)"
        '
        'lblMode_BlitzIndex
        '
        Me.lblMode_BlitzIndex.AutoSize = True
        Me.lblMode_BlitzIndex.Location = New System.Drawing.Point(495, 14)
        Me.lblMode_BlitzIndex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMode_BlitzIndex.Name = "lblMode_BlitzIndex"
        Me.lblMode_BlitzIndex.Size = New System.Drawing.Size(45, 16)
        Me.lblMode_BlitzIndex.TabIndex = 62
        Me.lblMode_BlitzIndex.Text = "Mode:"
        '
        'chkShowColumnstoreOnly_BlitzIndex
        '
        Me.chkShowColumnstoreOnly_BlitzIndex.AutoSize = True
        Me.chkShowColumnstoreOnly_BlitzIndex.Location = New System.Drawing.Point(592, 166)
        Me.chkShowColumnstoreOnly_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowColumnstoreOnly_BlitzIndex.Name = "chkShowColumnstoreOnly_BlitzIndex"
        Me.chkShowColumnstoreOnly_BlitzIndex.Size = New System.Drawing.Size(164, 20)
        Me.chkShowColumnstoreOnly_BlitzIndex.TabIndex = 61
        Me.chkShowColumnstoreOnly_BlitzIndex.Tag = "ShowColumnstoreOnly;0"
        Me.chkShowColumnstoreOnly_BlitzIndex.Text = "ShowColumnstoreOnly"
        Me.chkShowColumnstoreOnly_BlitzIndex.UseVisualStyleBackColor = True
        '
        'ddlSortDirection_BlitzIndex
        '
        Me.ddlSortDirection_BlitzIndex.FormattingEnabled = True
        Me.ddlSortDirection_BlitzIndex.Items.AddRange(New Object() {"DESC (Default)", "ASC"})
        Me.ddlSortDirection_BlitzIndex.Location = New System.Drawing.Point(592, 76)
        Me.ddlSortDirection_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSortDirection_BlitzIndex.Name = "ddlSortDirection_BlitzIndex"
        Me.ddlSortDirection_BlitzIndex.Size = New System.Drawing.Size(204, 24)
        Me.ddlSortDirection_BlitzIndex.TabIndex = 60
        Me.ddlSortDirection_BlitzIndex.Tag = "SortDirection;DESC"
        Me.ddlSortDirection_BlitzIndex.Text = "DESC (Default)"
        '
        'lblSortDirection_BlitzIndex
        '
        Me.lblSortDirection_BlitzIndex.AutoSize = True
        Me.lblSortDirection_BlitzIndex.Location = New System.Drawing.Point(495, 80)
        Me.lblSortDirection_BlitzIndex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSortDirection_BlitzIndex.Name = "lblSortDirection_BlitzIndex"
        Me.lblSortDirection_BlitzIndex.Size = New System.Drawing.Size(87, 16)
        Me.lblSortDirection_BlitzIndex.TabIndex = 59
        Me.lblSortDirection_BlitzIndex.Text = "SortDirection:"
        '
        'ddlSortOrder_BlitzIndex
        '
        Me.ddlSortOrder_BlitzIndex.FormattingEnabled = True
        Me.ddlSortOrder_BlitzIndex.Items.AddRange(New Object() {"Create_Date", "Fetches", "Forward_Fetches", "Lob", "Lock_Time", "Modify_Date", "Ratio", "Reads", "Reads_Per_Write", "Reserved_MB", "Reserved_Lob_MB", "Rows", "Size", "Total_Page_Lock_Wait_In_ms", "Total_Reads", "Total_Row_Lock_Wait_In_ms", "User_Updates", "Writes"})
        Me.ddlSortOrder_BlitzIndex.Location = New System.Drawing.Point(592, 43)
        Me.ddlSortOrder_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSortOrder_BlitzIndex.Name = "ddlSortOrder_BlitzIndex"
        Me.ddlSortOrder_BlitzIndex.Size = New System.Drawing.Size(204, 24)
        Me.ddlSortOrder_BlitzIndex.TabIndex = 58
        Me.ddlSortOrder_BlitzIndex.Tag = "SortOrder"
        '
        'lblSortOrder_BlitzIndex
        '
        Me.lblSortOrder_BlitzIndex.AutoSize = True
        Me.lblSortOrder_BlitzIndex.Location = New System.Drawing.Point(495, 47)
        Me.lblSortOrder_BlitzIndex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSortOrder_BlitzIndex.Name = "lblSortOrder_BlitzIndex"
        Me.lblSortOrder_BlitzIndex.Size = New System.Drawing.Size(68, 16)
        Me.lblSortOrder_BlitzIndex.TabIndex = 57
        Me.lblSortOrder_BlitzIndex.Text = "SortOrder:"
        '
        'chkShowAllMissingIndexRequests_BlitzIndex
        '
        Me.chkShowAllMissingIndexRequests_BlitzIndex.AutoSize = True
        Me.chkShowAllMissingIndexRequests_BlitzIndex.Location = New System.Drawing.Point(592, 138)
        Me.chkShowAllMissingIndexRequests_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowAllMissingIndexRequests_BlitzIndex.Name = "chkShowAllMissingIndexRequests_BlitzIndex"
        Me.chkShowAllMissingIndexRequests_BlitzIndex.Size = New System.Drawing.Size(213, 20)
        Me.chkShowAllMissingIndexRequests_BlitzIndex.TabIndex = 56
        Me.chkShowAllMissingIndexRequests_BlitzIndex.Tag = "ShowAllMissingIndexRequests;0"
        Me.chkShowAllMissingIndexRequests_BlitzIndex.Text = "ShowAllMissingIndexRequests"
        Me.chkShowAllMissingIndexRequests_BlitzIndex.UseVisualStyleBackColor = True
        '
        'chkIncludeInactiveIndexes_BlitzIndex
        '
        Me.chkIncludeInactiveIndexes_BlitzIndex.AutoSize = True
        Me.chkIncludeInactiveIndexes_BlitzIndex.Location = New System.Drawing.Point(141, 166)
        Me.chkIncludeInactiveIndexes_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIncludeInactiveIndexes_BlitzIndex.Name = "chkIncludeInactiveIndexes_BlitzIndex"
        Me.chkIncludeInactiveIndexes_BlitzIndex.Size = New System.Drawing.Size(165, 20)
        Me.chkIncludeInactiveIndexes_BlitzIndex.TabIndex = 55
        Me.chkIncludeInactiveIndexes_BlitzIndex.Tag = "IncludeInactiveIndexes;0"
        Me.chkIncludeInactiveIndexes_BlitzIndex.Text = "IncludeInactiveIndexes"
        Me.chkIncludeInactiveIndexes_BlitzIndex.UseVisualStyleBackColor = True
        '
        'strIgnoreDatabases_BlitzIndex
        '
        Me.strIgnoreDatabases_BlitzIndex.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.strIgnoreDatabases_BlitzIndex.Location = New System.Drawing.Point(592, 106)
        Me.strIgnoreDatabases_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.strIgnoreDatabases_BlitzIndex.Name = "strIgnoreDatabases_BlitzIndex"
        Me.strIgnoreDatabases_BlitzIndex.Size = New System.Drawing.Size(965, 22)
        Me.strIgnoreDatabases_BlitzIndex.TabIndex = 54
        Me.strIgnoreDatabases_BlitzIndex.Tag = "IgnoreDatabases"
        '
        'lblIgnoreDatabases_BlitzIndex
        '
        Me.lblIgnoreDatabases_BlitzIndex.AutoSize = True
        Me.lblIgnoreDatabases_BlitzIndex.Location = New System.Drawing.Point(463, 110)
        Me.lblIgnoreDatabases_BlitzIndex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIgnoreDatabases_BlitzIndex.Name = "lblIgnoreDatabases_BlitzIndex"
        Me.lblIgnoreDatabases_BlitzIndex.Size = New System.Drawing.Size(115, 16)
        Me.lblIgnoreDatabases_BlitzIndex.TabIndex = 53
        Me.lblIgnoreDatabases_BlitzIndex.Text = "IgnoreDatabases:"
        '
        'chkBringThePain_BlitzIndex
        '
        Me.chkBringThePain_BlitzIndex.AutoSize = True
        Me.chkBringThePain_BlitzIndex.Location = New System.Drawing.Point(141, 110)
        Me.chkBringThePain_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBringThePain_BlitzIndex.Name = "chkBringThePain_BlitzIndex"
        Me.chkBringThePain_BlitzIndex.Size = New System.Drawing.Size(111, 20)
        Me.chkBringThePain_BlitzIndex.TabIndex = 52
        Me.chkBringThePain_BlitzIndex.Tag = "BringThePain;0"
        Me.chkBringThePain_BlitzIndex.Text = "BringThePain"
        Me.chkBringThePain_BlitzIndex.UseVisualStyleBackColor = True
        '
        'chkGetAllDatabases_BlitzIndex
        '
        Me.chkGetAllDatabases_BlitzIndex.AutoSize = True
        Me.chkGetAllDatabases_BlitzIndex.Location = New System.Drawing.Point(141, 138)
        Me.chkGetAllDatabases_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.chkGetAllDatabases_BlitzIndex.Name = "chkGetAllDatabases_BlitzIndex"
        Me.chkGetAllDatabases_BlitzIndex.Size = New System.Drawing.Size(132, 20)
        Me.chkGetAllDatabases_BlitzIndex.TabIndex = 51
        Me.chkGetAllDatabases_BlitzIndex.Tag = "GetAllDatabases;0"
        Me.chkGetAllDatabases_BlitzIndex.Text = "GetAllDatabases"
        Me.chkGetAllDatabases_BlitzIndex.UseVisualStyleBackColor = True
        '
        'ddlTableName_BlitzIndex
        '
        Me.ddlTableName_BlitzIndex.FormattingEnabled = True
        Me.ddlTableName_BlitzIndex.Location = New System.Drawing.Point(141, 76)
        Me.ddlTableName_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlTableName_BlitzIndex.Name = "ddlTableName_BlitzIndex"
        Me.ddlTableName_BlitzIndex.Size = New System.Drawing.Size(267, 24)
        Me.ddlTableName_BlitzIndex.TabIndex = 50
        Me.ddlTableName_BlitzIndex.Tag = "TableName"
        '
        'lblTableName_BlitzIndex
        '
        Me.lblTableName_BlitzIndex.AutoSize = True
        Me.lblTableName_BlitzIndex.Location = New System.Drawing.Point(23, 81)
        Me.lblTableName_BlitzIndex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTableName_BlitzIndex.Name = "lblTableName_BlitzIndex"
        Me.lblTableName_BlitzIndex.Size = New System.Drawing.Size(83, 16)
        Me.lblTableName_BlitzIndex.TabIndex = 49
        Me.lblTableName_BlitzIndex.Text = "TableName:"
        '
        'ddlSchemaName_BlitzIndex
        '
        Me.ddlSchemaName_BlitzIndex.FormattingEnabled = True
        Me.ddlSchemaName_BlitzIndex.Location = New System.Drawing.Point(141, 43)
        Me.ddlSchemaName_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSchemaName_BlitzIndex.Name = "ddlSchemaName_BlitzIndex"
        Me.ddlSchemaName_BlitzIndex.Size = New System.Drawing.Size(267, 24)
        Me.ddlSchemaName_BlitzIndex.TabIndex = 48
        Me.ddlSchemaName_BlitzIndex.Tag = "SchemaName"
        '
        'lblSchemaName_BlitzIndex
        '
        Me.lblSchemaName_BlitzIndex.AutoSize = True
        Me.lblSchemaName_BlitzIndex.Location = New System.Drawing.Point(23, 47)
        Me.lblSchemaName_BlitzIndex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSchemaName_BlitzIndex.Name = "lblSchemaName_BlitzIndex"
        Me.lblSchemaName_BlitzIndex.Size = New System.Drawing.Size(97, 16)
        Me.lblSchemaName_BlitzIndex.TabIndex = 47
        Me.lblSchemaName_BlitzIndex.Text = "SchemaName:"
        '
        'ddlDatabaseName_BlitzIndex
        '
        Me.ddlDatabaseName_BlitzIndex.FormattingEnabled = True
        Me.ddlDatabaseName_BlitzIndex.Location = New System.Drawing.Point(141, 10)
        Me.ddlDatabaseName_BlitzIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlDatabaseName_BlitzIndex.Name = "ddlDatabaseName_BlitzIndex"
        Me.ddlDatabaseName_BlitzIndex.Size = New System.Drawing.Size(267, 24)
        Me.ddlDatabaseName_BlitzIndex.TabIndex = 46
        Me.ddlDatabaseName_BlitzIndex.Tag = "DatabaseName"
        '
        'lblDatabaseName_BlitzIndex
        '
        Me.lblDatabaseName_BlitzIndex.AutoSize = True
        Me.lblDatabaseName_BlitzIndex.Location = New System.Drawing.Point(23, 14)
        Me.lblDatabaseName_BlitzIndex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabaseName_BlitzIndex.Name = "lblDatabaseName_BlitzIndex"
        Me.lblDatabaseName_BlitzIndex.Size = New System.Drawing.Size(107, 16)
        Me.lblDatabaseName_BlitzIndex.TabIndex = 45
        Me.lblDatabaseName_BlitzIndex.Text = "DatabaseName:"
        '
        'sp_BlitzLock
        '
        Me.sp_BlitzLock.Controls.Add(Me.dtpEndTime_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.dtpStartTime_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.chkUseBelowDate_Internal_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.chkExportToExcel_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.chkVictimsOnly_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.strLoginName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.lblLoginName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.strHostName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.lblHostName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.strAppName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.lblAppName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.ddlTableName_Internal_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.lblTableName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.ddlSchemaName_Internal_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.lblSchemaName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.dtpEndDate_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.lblEndDate_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.dtpStartDate_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.lblStartDate_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.ddlStoredProcName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.lblStoredProcName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.ddlDatabaseName_BlitzLock)
        Me.sp_BlitzLock.Controls.Add(Me.lblDatabaseName_BlitzLock)
        Me.sp_BlitzLock.Location = New System.Drawing.Point(4, 25)
        Me.sp_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzLock.Name = "sp_BlitzLock"
        Me.sp_BlitzLock.Padding = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzLock.Size = New System.Drawing.Size(1569, 215)
        Me.sp_BlitzLock.TabIndex = 3
        Me.sp_BlitzLock.Text = "Parameters BlitzLock"
        Me.sp_BlitzLock.UseVisualStyleBackColor = True
        '
        'dtpEndTime_BlitzLock
        '
        Me.dtpEndTime_BlitzLock.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime_BlitzLock.Location = New System.Drawing.Point(891, 69)
        Me.dtpEndTime_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEndTime_BlitzLock.Name = "dtpEndTime_BlitzLock"
        Me.dtpEndTime_BlitzLock.ShowUpDown = True
        Me.dtpEndTime_BlitzLock.Size = New System.Drawing.Size(105, 22)
        Me.dtpEndTime_BlitzLock.TabIndex = 67
        '
        'dtpStartTime_BlitzLock
        '
        Me.dtpStartTime_BlitzLock.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime_BlitzLock.Location = New System.Drawing.Point(891, 36)
        Me.dtpStartTime_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStartTime_BlitzLock.Name = "dtpStartTime_BlitzLock"
        Me.dtpStartTime_BlitzLock.ShowUpDown = True
        Me.dtpStartTime_BlitzLock.Size = New System.Drawing.Size(105, 22)
        Me.dtpStartTime_BlitzLock.TabIndex = 66
        '
        'chkUseBelowDate_Internal_BlitzLock
        '
        Me.chkUseBelowDate_Internal_BlitzLock.AutoSize = True
        Me.chkUseBelowDate_Internal_BlitzLock.Location = New System.Drawing.Point(749, 10)
        Me.chkUseBelowDate_Internal_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.chkUseBelowDate_Internal_BlitzLock.Name = "chkUseBelowDate_Internal_BlitzLock"
        Me.chkUseBelowDate_Internal_BlitzLock.Size = New System.Drawing.Size(212, 20)
        Me.chkUseBelowDate_Internal_BlitzLock.TabIndex = 65
        Me.chkUseBelowDate_Internal_BlitzLock.Tag = "UseBelowDate;0"
        Me.chkUseBelowDate_Internal_BlitzLock.Text = "Use the below dates and times"
        Me.chkUseBelowDate_Internal_BlitzLock.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.chkUseBelowDate_Internal_BlitzLock.UseVisualStyleBackColor = True
        '
        'chkExportToExcel_BlitzLock
        '
        Me.chkExportToExcel_BlitzLock.AutoSize = True
        Me.chkExportToExcel_BlitzLock.Location = New System.Drawing.Point(496, 134)
        Me.chkExportToExcel_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.chkExportToExcel_BlitzLock.Name = "chkExportToExcel_BlitzLock"
        Me.chkExportToExcel_BlitzLock.Size = New System.Drawing.Size(117, 20)
        Me.chkExportToExcel_BlitzLock.TabIndex = 64
        Me.chkExportToExcel_BlitzLock.Tag = "ExportToExcel;0"
        Me.chkExportToExcel_BlitzLock.Text = "ExportToExcel"
        Me.chkExportToExcel_BlitzLock.UseVisualStyleBackColor = True
        Me.chkExportToExcel_BlitzLock.Visible = False
        '
        'chkVictimsOnly_BlitzLock
        '
        Me.chkVictimsOnly_BlitzLock.AutoSize = True
        Me.chkVictimsOnly_BlitzLock.Location = New System.Drawing.Point(496, 111)
        Me.chkVictimsOnly_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVictimsOnly_BlitzLock.Name = "chkVictimsOnly_BlitzLock"
        Me.chkVictimsOnly_BlitzLock.Size = New System.Drawing.Size(99, 20)
        Me.chkVictimsOnly_BlitzLock.TabIndex = 63
        Me.chkVictimsOnly_BlitzLock.Tag = "VictimsOnly;0"
        Me.chkVictimsOnly_BlitzLock.Text = "VictimsOnly"
        Me.chkVictimsOnly_BlitzLock.UseVisualStyleBackColor = True
        '
        'strLoginName_BlitzLock
        '
        Me.strLoginName_BlitzLock.Location = New System.Drawing.Point(496, 73)
        Me.strLoginName_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.strLoginName_BlitzLock.Name = "strLoginName_BlitzLock"
        Me.strLoginName_BlitzLock.Size = New System.Drawing.Size(132, 22)
        Me.strLoginName_BlitzLock.TabIndex = 62
        Me.strLoginName_BlitzLock.Tag = "LoginName"
        '
        'lblLoginName_BlitzLock
        '
        Me.lblLoginName_BlitzLock.AutoSize = True
        Me.lblLoginName_BlitzLock.Location = New System.Drawing.Point(411, 76)
        Me.lblLoginName_BlitzLock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoginName_BlitzLock.Name = "lblLoginName_BlitzLock"
        Me.lblLoginName_BlitzLock.Size = New System.Drawing.Size(80, 16)
        Me.lblLoginName_BlitzLock.TabIndex = 61
        Me.lblLoginName_BlitzLock.Text = "LoginName:"
        '
        'strHostName_BlitzLock
        '
        Me.strHostName_BlitzLock.Location = New System.Drawing.Point(496, 38)
        Me.strHostName_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.strHostName_BlitzLock.Name = "strHostName_BlitzLock"
        Me.strHostName_BlitzLock.Size = New System.Drawing.Size(132, 22)
        Me.strHostName_BlitzLock.TabIndex = 60
        Me.strHostName_BlitzLock.Tag = "HostName"
        '
        'lblHostName_BlitzLock
        '
        Me.lblHostName_BlitzLock.AutoSize = True
        Me.lblHostName_BlitzLock.Location = New System.Drawing.Point(411, 43)
        Me.lblHostName_BlitzLock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHostName_BlitzLock.Name = "lblHostName_BlitzLock"
        Me.lblHostName_BlitzLock.Size = New System.Drawing.Size(75, 16)
        Me.lblHostName_BlitzLock.TabIndex = 59
        Me.lblHostName_BlitzLock.Text = "HostName:"
        '
        'strAppName_BlitzLock
        '
        Me.strAppName_BlitzLock.Location = New System.Drawing.Point(496, 7)
        Me.strAppName_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.strAppName_BlitzLock.Name = "strAppName_BlitzLock"
        Me.strAppName_BlitzLock.Size = New System.Drawing.Size(132, 22)
        Me.strAppName_BlitzLock.TabIndex = 58
        Me.strAppName_BlitzLock.Tag = "AppName"
        '
        'lblAppName_BlitzLock
        '
        Me.lblAppName_BlitzLock.AutoSize = True
        Me.lblAppName_BlitzLock.Location = New System.Drawing.Point(411, 11)
        Me.lblAppName_BlitzLock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAppName_BlitzLock.Name = "lblAppName_BlitzLock"
        Me.lblAppName_BlitzLock.Size = New System.Drawing.Size(72, 16)
        Me.lblAppName_BlitzLock.TabIndex = 57
        Me.lblAppName_BlitzLock.Text = "AppName:"
        '
        'ddlTableName_Internal_BlitzLock
        '
        Me.ddlTableName_Internal_BlitzLock.FormattingEnabled = True
        Me.ddlTableName_Internal_BlitzLock.Location = New System.Drawing.Point(142, 75)
        Me.ddlTableName_Internal_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlTableName_Internal_BlitzLock.Name = "ddlTableName_Internal_BlitzLock"
        Me.ddlTableName_Internal_BlitzLock.Size = New System.Drawing.Size(236, 24)
        Me.ddlTableName_Internal_BlitzLock.TabIndex = 56
        Me.ddlTableName_Internal_BlitzLock.Tag = "TableName;"
        '
        'lblTableName_BlitzLock
        '
        Me.lblTableName_BlitzLock.AutoSize = True
        Me.lblTableName_BlitzLock.Location = New System.Drawing.Point(14, 79)
        Me.lblTableName_BlitzLock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTableName_BlitzLock.Name = "lblTableName_BlitzLock"
        Me.lblTableName_BlitzLock.Size = New System.Drawing.Size(83, 16)
        Me.lblTableName_BlitzLock.TabIndex = 55
        Me.lblTableName_BlitzLock.Text = "TableName:"
        '
        'ddlSchemaName_Internal_BlitzLock
        '
        Me.ddlSchemaName_Internal_BlitzLock.FormattingEnabled = True
        Me.ddlSchemaName_Internal_BlitzLock.Location = New System.Drawing.Point(142, 42)
        Me.ddlSchemaName_Internal_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSchemaName_Internal_BlitzLock.Name = "ddlSchemaName_Internal_BlitzLock"
        Me.ddlSchemaName_Internal_BlitzLock.Size = New System.Drawing.Size(236, 24)
        Me.ddlSchemaName_Internal_BlitzLock.TabIndex = 54
        Me.ddlSchemaName_Internal_BlitzLock.Tag = "SchemaName;"
        '
        'lblSchemaName_BlitzLock
        '
        Me.lblSchemaName_BlitzLock.AutoSize = True
        Me.lblSchemaName_BlitzLock.Location = New System.Drawing.Point(14, 48)
        Me.lblSchemaName_BlitzLock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSchemaName_BlitzLock.Name = "lblSchemaName_BlitzLock"
        Me.lblSchemaName_BlitzLock.Size = New System.Drawing.Size(97, 16)
        Me.lblSchemaName_BlitzLock.TabIndex = 53
        Me.lblSchemaName_BlitzLock.Tag = "SchemaName"
        Me.lblSchemaName_BlitzLock.Text = "SchemaName:"
        '
        'dtpEndDate_BlitzLock
        '
        Me.dtpEndDate_BlitzLock.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate_BlitzLock.Location = New System.Drawing.Point(749, 69)
        Me.dtpEndDate_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEndDate_BlitzLock.Name = "dtpEndDate_BlitzLock"
        Me.dtpEndDate_BlitzLock.Size = New System.Drawing.Size(132, 22)
        Me.dtpEndDate_BlitzLock.TabIndex = 52
        Me.dtpEndDate_BlitzLock.Tag = "EndDate;99991231"
        '
        'lblEndDate_BlitzLock
        '
        Me.lblEndDate_BlitzLock.AutoSize = True
        Me.lblEndDate_BlitzLock.Location = New System.Drawing.Point(672, 74)
        Me.lblEndDate_BlitzLock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndDate_BlitzLock.Name = "lblEndDate_BlitzLock"
        Me.lblEndDate_BlitzLock.Size = New System.Drawing.Size(63, 16)
        Me.lblEndDate_BlitzLock.TabIndex = 51
        Me.lblEndDate_BlitzLock.Text = "EndDate:"
        '
        'dtpStartDate_BlitzLock
        '
        Me.dtpStartDate_BlitzLock.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate_BlitzLock.Location = New System.Drawing.Point(749, 37)
        Me.dtpStartDate_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStartDate_BlitzLock.Name = "dtpStartDate_BlitzLock"
        Me.dtpStartDate_BlitzLock.Size = New System.Drawing.Size(132, 22)
        Me.dtpStartDate_BlitzLock.TabIndex = 50
        Me.dtpStartDate_BlitzLock.Tag = "StartDate;19000101"
        '
        'lblStartDate_BlitzLock
        '
        Me.lblStartDate_BlitzLock.AutoSize = True
        Me.lblStartDate_BlitzLock.Location = New System.Drawing.Point(672, 44)
        Me.lblStartDate_BlitzLock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartDate_BlitzLock.Name = "lblStartDate_BlitzLock"
        Me.lblStartDate_BlitzLock.Size = New System.Drawing.Size(66, 16)
        Me.lblStartDate_BlitzLock.TabIndex = 49
        Me.lblStartDate_BlitzLock.Text = "StartDate:"
        '
        'ddlStoredProcName_BlitzLock
        '
        Me.ddlStoredProcName_BlitzLock.Enabled = False
        Me.ddlStoredProcName_BlitzLock.FormattingEnabled = True
        Me.ddlStoredProcName_BlitzLock.Location = New System.Drawing.Point(142, 108)
        Me.ddlStoredProcName_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlStoredProcName_BlitzLock.Name = "ddlStoredProcName_BlitzLock"
        Me.ddlStoredProcName_BlitzLock.Size = New System.Drawing.Size(236, 24)
        Me.ddlStoredProcName_BlitzLock.TabIndex = 48
        Me.ddlStoredProcName_BlitzLock.Tag = "StoredProcName;"
        '
        'lblStoredProcName_BlitzLock
        '
        Me.lblStoredProcName_BlitzLock.AutoSize = True
        Me.lblStoredProcName_BlitzLock.Location = New System.Drawing.Point(14, 112)
        Me.lblStoredProcName_BlitzLock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoredProcName_BlitzLock.Name = "lblStoredProcName_BlitzLock"
        Me.lblStoredProcName_BlitzLock.Size = New System.Drawing.Size(115, 16)
        Me.lblStoredProcName_BlitzLock.TabIndex = 47
        Me.lblStoredProcName_BlitzLock.Text = "StoredProcName:"
        '
        'ddlDatabaseName_BlitzLock
        '
        Me.ddlDatabaseName_BlitzLock.FormattingEnabled = True
        Me.ddlDatabaseName_BlitzLock.Location = New System.Drawing.Point(142, 8)
        Me.ddlDatabaseName_BlitzLock.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlDatabaseName_BlitzLock.Name = "ddlDatabaseName_BlitzLock"
        Me.ddlDatabaseName_BlitzLock.Size = New System.Drawing.Size(236, 24)
        Me.ddlDatabaseName_BlitzLock.TabIndex = 46
        Me.ddlDatabaseName_BlitzLock.Tag = "DatabaseName;"
        '
        'lblDatabaseName_BlitzLock
        '
        Me.lblDatabaseName_BlitzLock.AutoSize = True
        Me.lblDatabaseName_BlitzLock.Location = New System.Drawing.Point(14, 12)
        Me.lblDatabaseName_BlitzLock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabaseName_BlitzLock.Name = "lblDatabaseName_BlitzLock"
        Me.lblDatabaseName_BlitzLock.Size = New System.Drawing.Size(107, 16)
        Me.lblDatabaseName_BlitzLock.TabIndex = 45
        Me.lblDatabaseName_BlitzLock.Text = "DatabaseName:"
        '
        'sp_BlitzQueryStore
        '
        Me.sp_BlitzQueryStore.Controls.Add(Me.dtpEndTime_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.dtpStartTime_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.chkExpertMode_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.chkSkipXML_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.chkFailed_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.intDurationFilter_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.lblDurationFilter_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.intMinimumExecutionCount_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.lblMinimumExecutionCount_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.chkExportToExcel_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.dtpEndDate_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.lblEndDate_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.dtpStartDate_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.lblStartDate_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.ddlStoredProcName_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.lblStoredProcName_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.ddlDatabaseName_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.lblDatabaseName_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.lblTop_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Controls.Add(Me.intTop_BlitzQueryStore)
        Me.sp_BlitzQueryStore.Location = New System.Drawing.Point(4, 25)
        Me.sp_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzQueryStore.Name = "sp_BlitzQueryStore"
        Me.sp_BlitzQueryStore.Size = New System.Drawing.Size(1569, 215)
        Me.sp_BlitzQueryStore.TabIndex = 5
        Me.sp_BlitzQueryStore.Text = "Parameters BlitzQueryStore"
        Me.sp_BlitzQueryStore.UseVisualStyleBackColor = True
        '
        'dtpEndTime_BlitzQueryStore
        '
        Me.dtpEndTime_BlitzQueryStore.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime_BlitzQueryStore.Location = New System.Drawing.Point(984, 116)
        Me.dtpEndTime_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEndTime_BlitzQueryStore.Name = "dtpEndTime_BlitzQueryStore"
        Me.dtpEndTime_BlitzQueryStore.ShowUpDown = True
        Me.dtpEndTime_BlitzQueryStore.Size = New System.Drawing.Size(115, 22)
        Me.dtpEndTime_BlitzQueryStore.TabIndex = 76
        '
        'dtpStartTime_BlitzQueryStore
        '
        Me.dtpStartTime_BlitzQueryStore.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime_BlitzQueryStore.Location = New System.Drawing.Point(984, 84)
        Me.dtpStartTime_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStartTime_BlitzQueryStore.Name = "dtpStartTime_BlitzQueryStore"
        Me.dtpStartTime_BlitzQueryStore.ShowUpDown = True
        Me.dtpStartTime_BlitzQueryStore.Size = New System.Drawing.Size(115, 22)
        Me.dtpStartTime_BlitzQueryStore.TabIndex = 75
        '
        'chkExpertMode_BlitzQueryStore
        '
        Me.chkExpertMode_BlitzQueryStore.AutoSize = True
        Me.chkExpertMode_BlitzQueryStore.Location = New System.Drawing.Point(543, 17)
        Me.chkExpertMode_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.chkExpertMode_BlitzQueryStore.Name = "chkExpertMode_BlitzQueryStore"
        Me.chkExpertMode_BlitzQueryStore.Size = New System.Drawing.Size(102, 20)
        Me.chkExpertMode_BlitzQueryStore.TabIndex = 71
        Me.chkExpertMode_BlitzQueryStore.Tag = "ExpertMode;0"
        Me.chkExpertMode_BlitzQueryStore.Text = "ExpertMode"
        Me.chkExpertMode_BlitzQueryStore.UseVisualStyleBackColor = True
        '
        'chkSkipXML_BlitzQueryStore
        '
        Me.chkSkipXML_BlitzQueryStore.AutoSize = True
        Me.chkSkipXML_BlitzQueryStore.Location = New System.Drawing.Point(543, 87)
        Me.chkSkipXML_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSkipXML_BlitzQueryStore.Name = "chkSkipXML_BlitzQueryStore"
        Me.chkSkipXML_BlitzQueryStore.Size = New System.Drawing.Size(78, 20)
        Me.chkSkipXML_BlitzQueryStore.TabIndex = 70
        Me.chkSkipXML_BlitzQueryStore.Tag = "SkipXml;0"
        Me.chkSkipXML_BlitzQueryStore.Text = "SkipXml"
        Me.chkSkipXML_BlitzQueryStore.UseVisualStyleBackColor = True
        '
        'chkFailed_BlitzQueryStore
        '
        Me.chkFailed_BlitzQueryStore.AutoSize = True
        Me.chkFailed_BlitzQueryStore.Location = New System.Drawing.Point(543, 52)
        Me.chkFailed_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.chkFailed_BlitzQueryStore.Name = "chkFailed_BlitzQueryStore"
        Me.chkFailed_BlitzQueryStore.Size = New System.Drawing.Size(67, 20)
        Me.chkFailed_BlitzQueryStore.TabIndex = 69
        Me.chkFailed_BlitzQueryStore.Tag = "Failed;0"
        Me.chkFailed_BlitzQueryStore.Text = "Failed"
        Me.chkFailed_BlitzQueryStore.UseVisualStyleBackColor = True
        '
        'intDurationFilter_BlitzQueryStore
        '
        Me.intDurationFilter_BlitzQueryStore.Location = New System.Drawing.Point(849, 47)
        Me.intDurationFilter_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.intDurationFilter_BlitzQueryStore.Name = "intDurationFilter_BlitzQueryStore"
        Me.intDurationFilter_BlitzQueryStore.Size = New System.Drawing.Size(132, 22)
        Me.intDurationFilter_BlitzQueryStore.TabIndex = 68
        Me.intDurationFilter_BlitzQueryStore.Tag = "DurationFilter"
        '
        'lblDurationFilter_BlitzQueryStore
        '
        Me.lblDurationFilter_BlitzQueryStore.AutoSize = True
        Me.lblDurationFilter_BlitzQueryStore.Location = New System.Drawing.Point(745, 49)
        Me.lblDurationFilter_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDurationFilter_BlitzQueryStore.Name = "lblDurationFilter_BlitzQueryStore"
        Me.lblDurationFilter_BlitzQueryStore.Size = New System.Drawing.Size(89, 16)
        Me.lblDurationFilter_BlitzQueryStore.TabIndex = 67
        Me.lblDurationFilter_BlitzQueryStore.Text = "DurationFilter:"
        '
        'intMinimumExecutionCount_BlitzQueryStore
        '
        Me.intMinimumExecutionCount_BlitzQueryStore.Location = New System.Drawing.Point(849, 15)
        Me.intMinimumExecutionCount_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.intMinimumExecutionCount_BlitzQueryStore.Name = "intMinimumExecutionCount_BlitzQueryStore"
        Me.intMinimumExecutionCount_BlitzQueryStore.Size = New System.Drawing.Size(131, 22)
        Me.intMinimumExecutionCount_BlitzQueryStore.TabIndex = 66
        Me.intMinimumExecutionCount_BlitzQueryStore.Tag = "MinimumExecutionCount"
        '
        'lblMinimumExecutionCount_BlitzQueryStore
        '
        Me.lblMinimumExecutionCount_BlitzQueryStore.AutoSize = True
        Me.lblMinimumExecutionCount_BlitzQueryStore.Location = New System.Drawing.Point(673, 18)
        Me.lblMinimumExecutionCount_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinimumExecutionCount_BlitzQueryStore.Name = "lblMinimumExecutionCount_BlitzQueryStore"
        Me.lblMinimumExecutionCount_BlitzQueryStore.Size = New System.Drawing.Size(155, 16)
        Me.lblMinimumExecutionCount_BlitzQueryStore.TabIndex = 65
        Me.lblMinimumExecutionCount_BlitzQueryStore.Text = "MinimumExecutionCount:"
        '
        'chkExportToExcel_BlitzQueryStore
        '
        Me.chkExportToExcel_BlitzQueryStore.AutoSize = True
        Me.chkExportToExcel_BlitzQueryStore.Location = New System.Drawing.Point(543, 122)
        Me.chkExportToExcel_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.chkExportToExcel_BlitzQueryStore.Name = "chkExportToExcel_BlitzQueryStore"
        Me.chkExportToExcel_BlitzQueryStore.Size = New System.Drawing.Size(117, 20)
        Me.chkExportToExcel_BlitzQueryStore.TabIndex = 64
        Me.chkExportToExcel_BlitzQueryStore.Tag = "ExportToExcel;0"
        Me.chkExportToExcel_BlitzQueryStore.Text = "ExportToExcel"
        Me.chkExportToExcel_BlitzQueryStore.UseVisualStyleBackColor = True
        '
        'dtpEndDate_BlitzQueryStore
        '
        Me.dtpEndDate_BlitzQueryStore.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate_BlitzQueryStore.Location = New System.Drawing.Point(849, 116)
        Me.dtpEndDate_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEndDate_BlitzQueryStore.Name = "dtpEndDate_BlitzQueryStore"
        Me.dtpEndDate_BlitzQueryStore.Size = New System.Drawing.Size(125, 22)
        Me.dtpEndDate_BlitzQueryStore.TabIndex = 52
        Me.dtpEndDate_BlitzQueryStore.Tag = "EndDate"
        '
        'lblEndDate_BlitzQueryStore
        '
        Me.lblEndDate_BlitzQueryStore.AutoSize = True
        Me.lblEndDate_BlitzQueryStore.Location = New System.Drawing.Point(772, 119)
        Me.lblEndDate_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndDate_BlitzQueryStore.Name = "lblEndDate_BlitzQueryStore"
        Me.lblEndDate_BlitzQueryStore.Size = New System.Drawing.Size(63, 16)
        Me.lblEndDate_BlitzQueryStore.TabIndex = 51
        Me.lblEndDate_BlitzQueryStore.Text = "EndDate:"
        '
        'dtpStartDate_BlitzQueryStore
        '
        Me.dtpStartDate_BlitzQueryStore.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate_BlitzQueryStore.Location = New System.Drawing.Point(849, 84)
        Me.dtpStartDate_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStartDate_BlitzQueryStore.Name = "dtpStartDate_BlitzQueryStore"
        Me.dtpStartDate_BlitzQueryStore.Size = New System.Drawing.Size(125, 22)
        Me.dtpStartDate_BlitzQueryStore.TabIndex = 50
        Me.dtpStartDate_BlitzQueryStore.Tag = "StartDate"
        '
        'lblStartDate_BlitzQueryStore
        '
        Me.lblStartDate_BlitzQueryStore.AutoSize = True
        Me.lblStartDate_BlitzQueryStore.Location = New System.Drawing.Point(768, 87)
        Me.lblStartDate_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartDate_BlitzQueryStore.Name = "lblStartDate_BlitzQueryStore"
        Me.lblStartDate_BlitzQueryStore.Size = New System.Drawing.Size(66, 16)
        Me.lblStartDate_BlitzQueryStore.TabIndex = 49
        Me.lblStartDate_BlitzQueryStore.Text = "StartDate:"
        '
        'ddlStoredProcName_BlitzQueryStore
        '
        Me.ddlStoredProcName_BlitzQueryStore.FormattingEnabled = True
        Me.ddlStoredProcName_BlitzQueryStore.Location = New System.Drawing.Point(143, 80)
        Me.ddlStoredProcName_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlStoredProcName_BlitzQueryStore.Name = "ddlStoredProcName_BlitzQueryStore"
        Me.ddlStoredProcName_BlitzQueryStore.Size = New System.Drawing.Size(360, 24)
        Me.ddlStoredProcName_BlitzQueryStore.TabIndex = 48
        Me.ddlStoredProcName_BlitzQueryStore.Tag = "StoredProcName"
        '
        'lblStoredProcName_BlitzQueryStore
        '
        Me.lblStoredProcName_BlitzQueryStore.AutoSize = True
        Me.lblStoredProcName_BlitzQueryStore.Location = New System.Drawing.Point(15, 84)
        Me.lblStoredProcName_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoredProcName_BlitzQueryStore.Name = "lblStoredProcName_BlitzQueryStore"
        Me.lblStoredProcName_BlitzQueryStore.Size = New System.Drawing.Size(115, 16)
        Me.lblStoredProcName_BlitzQueryStore.TabIndex = 47
        Me.lblStoredProcName_BlitzQueryStore.Text = "StoredProcName:"
        '
        'ddlDatabaseName_BlitzQueryStore
        '
        Me.ddlDatabaseName_BlitzQueryStore.FormattingEnabled = True
        Me.ddlDatabaseName_BlitzQueryStore.Location = New System.Drawing.Point(143, 47)
        Me.ddlDatabaseName_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlDatabaseName_BlitzQueryStore.Name = "ddlDatabaseName_BlitzQueryStore"
        Me.ddlDatabaseName_BlitzQueryStore.Size = New System.Drawing.Size(360, 24)
        Me.ddlDatabaseName_BlitzQueryStore.TabIndex = 46
        Me.ddlDatabaseName_BlitzQueryStore.Tag = "DatabaseName"
        '
        'lblDatabaseName_BlitzQueryStore
        '
        Me.lblDatabaseName_BlitzQueryStore.AutoSize = True
        Me.lblDatabaseName_BlitzQueryStore.Location = New System.Drawing.Point(15, 50)
        Me.lblDatabaseName_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabaseName_BlitzQueryStore.Name = "lblDatabaseName_BlitzQueryStore"
        Me.lblDatabaseName_BlitzQueryStore.Size = New System.Drawing.Size(107, 16)
        Me.lblDatabaseName_BlitzQueryStore.TabIndex = 45
        Me.lblDatabaseName_BlitzQueryStore.Text = "DatabaseName:"
        '
        'lblTop_BlitzQueryStore
        '
        Me.lblTop_BlitzQueryStore.AutoSize = True
        Me.lblTop_BlitzQueryStore.Location = New System.Drawing.Point(15, 18)
        Me.lblTop_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTop_BlitzQueryStore.Name = "lblTop_BlitzQueryStore"
        Me.lblTop_BlitzQueryStore.Size = New System.Drawing.Size(35, 16)
        Me.lblTop_BlitzQueryStore.TabIndex = 1
        Me.lblTop_BlitzQueryStore.Text = "Top:"
        '
        'intTop_BlitzQueryStore
        '
        Me.intTop_BlitzQueryStore.Location = New System.Drawing.Point(143, 15)
        Me.intTop_BlitzQueryStore.Margin = New System.Windows.Forms.Padding(4)
        Me.intTop_BlitzQueryStore.Name = "intTop_BlitzQueryStore"
        Me.intTop_BlitzQueryStore.Size = New System.Drawing.Size(65, 22)
        Me.intTop_BlitzQueryStore.TabIndex = 2
        Me.intTop_BlitzQueryStore.Tag = "Top;3"
        Me.intTop_BlitzQueryStore.Text = "3"
        '
        'sp_BlitzWho
        '
        Me.sp_BlitzWho.Controls.Add(Me.chkGetLiveQueryPlan_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.chkGetOuterCommand_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.ddlSortOrder_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.lblSortOrder_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.intMinBlockingSeconds_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.lblMinBlockingSeconds_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.intMinRequestedMemoryKB_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.lblMinRequestedMemoryKB_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.intMinTempdbMB_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.lblMinTempdbMB_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.intMinWrites_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.lblMinWrites_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.intMinPhysicalReads_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.lblMinPhysicalReads_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.intMinLogicalReads_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.lblMinLogicalReads_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.intMinCPUTime_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.lblMinCPUTime_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.intMinElapsedSeconds_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.lblMinElapsedSeconds_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.chkExpertMode_BlitzWho)
        Me.sp_BlitzWho.Controls.Add(Me.chkShowSleepingSPIDs_BlitzWho)
        Me.sp_BlitzWho.Location = New System.Drawing.Point(4, 25)
        Me.sp_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.sp_BlitzWho.Name = "sp_BlitzWho"
        Me.sp_BlitzWho.Size = New System.Drawing.Size(1569, 215)
        Me.sp_BlitzWho.TabIndex = 6
        Me.sp_BlitzWho.Text = "Parameters BlitzWho"
        Me.sp_BlitzWho.UseVisualStyleBackColor = True
        '
        'chkGetLiveQueryPlan_BlitzWho
        '
        Me.chkGetLiveQueryPlan_BlitzWho.AutoSize = True
        Me.chkGetLiveQueryPlan_BlitzWho.Location = New System.Drawing.Point(23, 134)
        Me.chkGetLiveQueryPlan_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.chkGetLiveQueryPlan_BlitzWho.Name = "chkGetLiveQueryPlan_BlitzWho"
        Me.chkGetLiveQueryPlan_BlitzWho.Size = New System.Drawing.Size(138, 20)
        Me.chkGetLiveQueryPlan_BlitzWho.TabIndex = 22
        Me.chkGetLiveQueryPlan_BlitzWho.Tag = "GetLiveQueryPlan;0"
        Me.chkGetLiveQueryPlan_BlitzWho.Text = "GetLiveQueryPlan"
        Me.chkGetLiveQueryPlan_BlitzWho.UseVisualStyleBackColor = True
        '
        'chkGetOuterCommand_BlitzWho
        '
        Me.chkGetOuterCommand_BlitzWho.AutoSize = True
        Me.chkGetOuterCommand_BlitzWho.Location = New System.Drawing.Point(23, 106)
        Me.chkGetOuterCommand_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.chkGetOuterCommand_BlitzWho.Name = "chkGetOuterCommand_BlitzWho"
        Me.chkGetOuterCommand_BlitzWho.Size = New System.Drawing.Size(144, 20)
        Me.chkGetOuterCommand_BlitzWho.TabIndex = 21
        Me.chkGetOuterCommand_BlitzWho.Tag = "GetOuterCommand;0"
        Me.chkGetOuterCommand_BlitzWho.Text = "GetOuterCommand"
        Me.chkGetOuterCommand_BlitzWho.UseVisualStyleBackColor = True
        '
        'ddlSortOrder_BlitzWho
        '
        Me.ddlSortOrder_BlitzWho.FormattingEnabled = True
        Me.ddlSortOrder_BlitzWho.Items.AddRange(New Object() {"elapsed_time (Default)", "session_id", "query_cost", "database_name", "open_transaction_count", "is_implicit_transaction", "login_name", "program_name", "client_interface_name", "request_cpu_time", "request_logical_reads", "request_writes", "request_physical_reads", "session_cpu", "session_logical_reads", "session_physical_reads", "session_writes", "tempdb_allocations_mb", "memory_usage", "deadlock_priority", "transaction_isolation_level" & Global.Microsoft.VisualBasic.ChrW(9), "requested_memory_kb", "grant_memory_kb", "grant", "query_memory_grant_used_memory_kb", "ideal_memory_kb", "workload_group_name", "resource_pool_name"})
        Me.ddlSortOrder_BlitzWho.Location = New System.Drawing.Point(100, 16)
        Me.ddlSortOrder_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSortOrder_BlitzWho.Name = "ddlSortOrder_BlitzWho"
        Me.ddlSortOrder_BlitzWho.Size = New System.Drawing.Size(215, 24)
        Me.ddlSortOrder_BlitzWho.TabIndex = 19
        Me.ddlSortOrder_BlitzWho.Tag = "SortOrder;elapsed_time"
        '
        'lblSortOrder_BlitzWho
        '
        Me.lblSortOrder_BlitzWho.AutoSize = True
        Me.lblSortOrder_BlitzWho.Location = New System.Drawing.Point(19, 22)
        Me.lblSortOrder_BlitzWho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSortOrder_BlitzWho.Name = "lblSortOrder_BlitzWho"
        Me.lblSortOrder_BlitzWho.Size = New System.Drawing.Size(68, 16)
        Me.lblSortOrder_BlitzWho.TabIndex = 18
        Me.lblSortOrder_BlitzWho.Text = "SortOrder:"
        '
        'intMinBlockingSeconds_BlitzWho
        '
        Me.intMinBlockingSeconds_BlitzWho.Location = New System.Drawing.Point(519, 16)
        Me.intMinBlockingSeconds_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.intMinBlockingSeconds_BlitzWho.Name = "intMinBlockingSeconds_BlitzWho"
        Me.intMinBlockingSeconds_BlitzWho.Size = New System.Drawing.Size(132, 22)
        Me.intMinBlockingSeconds_BlitzWho.TabIndex = 17
        Me.intMinBlockingSeconds_BlitzWho.Tag = "MinBlockingSeconds;0"
        Me.intMinBlockingSeconds_BlitzWho.Text = "0"
        '
        'lblMinBlockingSeconds_BlitzWho
        '
        Me.lblMinBlockingSeconds_BlitzWho.AutoSize = True
        Me.lblMinBlockingSeconds_BlitzWho.Location = New System.Drawing.Point(364, 20)
        Me.lblMinBlockingSeconds_BlitzWho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinBlockingSeconds_BlitzWho.Name = "lblMinBlockingSeconds_BlitzWho"
        Me.lblMinBlockingSeconds_BlitzWho.Size = New System.Drawing.Size(137, 16)
        Me.lblMinBlockingSeconds_BlitzWho.TabIndex = 16
        Me.lblMinBlockingSeconds_BlitzWho.Text = "MinBlockingSeconds:"
        '
        'intMinRequestedMemoryKB_BlitzWho
        '
        Me.intMinRequestedMemoryKB_BlitzWho.Location = New System.Drawing.Point(869, 48)
        Me.intMinRequestedMemoryKB_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.intMinRequestedMemoryKB_BlitzWho.Name = "intMinRequestedMemoryKB_BlitzWho"
        Me.intMinRequestedMemoryKB_BlitzWho.Size = New System.Drawing.Size(132, 22)
        Me.intMinRequestedMemoryKB_BlitzWho.TabIndex = 15
        Me.intMinRequestedMemoryKB_BlitzWho.Tag = "MinRequestedMemoryKB;0"
        Me.intMinRequestedMemoryKB_BlitzWho.Text = "0"
        '
        'lblMinRequestedMemoryKB_BlitzWho
        '
        Me.lblMinRequestedMemoryKB_BlitzWho.AutoSize = True
        Me.lblMinRequestedMemoryKB_BlitzWho.Location = New System.Drawing.Point(688, 52)
        Me.lblMinRequestedMemoryKB_BlitzWho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinRequestedMemoryKB_BlitzWho.Name = "lblMinRequestedMemoryKB_BlitzWho"
        Me.lblMinRequestedMemoryKB_BlitzWho.Size = New System.Drawing.Size(164, 16)
        Me.lblMinRequestedMemoryKB_BlitzWho.TabIndex = 14
        Me.lblMinRequestedMemoryKB_BlitzWho.Text = "MinRequestedMemoryKB:"
        '
        'intMinTempdbMB_BlitzWho
        '
        Me.intMinTempdbMB_BlitzWho.Location = New System.Drawing.Point(869, 80)
        Me.intMinTempdbMB_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.intMinTempdbMB_BlitzWho.Name = "intMinTempdbMB_BlitzWho"
        Me.intMinTempdbMB_BlitzWho.Size = New System.Drawing.Size(132, 22)
        Me.intMinTempdbMB_BlitzWho.TabIndex = 13
        Me.intMinTempdbMB_BlitzWho.Tag = "MinTempdbMB;0"
        Me.intMinTempdbMB_BlitzWho.Text = "0"
        '
        'lblMinTempdbMB_BlitzWho
        '
        Me.lblMinTempdbMB_BlitzWho.AutoSize = True
        Me.lblMinTempdbMB_BlitzWho.Location = New System.Drawing.Point(688, 84)
        Me.lblMinTempdbMB_BlitzWho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinTempdbMB_BlitzWho.Name = "lblMinTempdbMB_BlitzWho"
        Me.lblMinTempdbMB_BlitzWho.Size = New System.Drawing.Size(103, 16)
        Me.lblMinTempdbMB_BlitzWho.TabIndex = 12
        Me.lblMinTempdbMB_BlitzWho.Text = "MinTempdbMB:"
        '
        'intMinWrites_BlitzWho
        '
        Me.intMinWrites_BlitzWho.Location = New System.Drawing.Point(869, 112)
        Me.intMinWrites_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.intMinWrites_BlitzWho.Name = "intMinWrites_BlitzWho"
        Me.intMinWrites_BlitzWho.Size = New System.Drawing.Size(132, 22)
        Me.intMinWrites_BlitzWho.TabIndex = 11
        Me.intMinWrites_BlitzWho.Tag = "MinWrites;0"
        Me.intMinWrites_BlitzWho.Text = "0"
        '
        'lblMinWrites_BlitzWho
        '
        Me.lblMinWrites_BlitzWho.AutoSize = True
        Me.lblMinWrites_BlitzWho.Location = New System.Drawing.Point(688, 116)
        Me.lblMinWrites_BlitzWho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinWrites_BlitzWho.Name = "lblMinWrites_BlitzWho"
        Me.lblMinWrites_BlitzWho.Size = New System.Drawing.Size(69, 16)
        Me.lblMinWrites_BlitzWho.TabIndex = 10
        Me.lblMinWrites_BlitzWho.Text = "MinWrites:"
        '
        'intMinPhysicalReads_BlitzWho
        '
        Me.intMinPhysicalReads_BlitzWho.Location = New System.Drawing.Point(869, 15)
        Me.intMinPhysicalReads_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.intMinPhysicalReads_BlitzWho.Name = "intMinPhysicalReads_BlitzWho"
        Me.intMinPhysicalReads_BlitzWho.Size = New System.Drawing.Size(132, 22)
        Me.intMinPhysicalReads_BlitzWho.TabIndex = 9
        Me.intMinPhysicalReads_BlitzWho.Tag = "MinPhysicalReads;0"
        Me.intMinPhysicalReads_BlitzWho.Text = "0"
        '
        'lblMinPhysicalReads_BlitzWho
        '
        Me.lblMinPhysicalReads_BlitzWho.AutoSize = True
        Me.lblMinPhysicalReads_BlitzWho.Location = New System.Drawing.Point(688, 20)
        Me.lblMinPhysicalReads_BlitzWho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinPhysicalReads_BlitzWho.Name = "lblMinPhysicalReads_BlitzWho"
        Me.lblMinPhysicalReads_BlitzWho.Size = New System.Drawing.Size(123, 16)
        Me.lblMinPhysicalReads_BlitzWho.TabIndex = 8
        Me.lblMinPhysicalReads_BlitzWho.Text = "MinPhysicalReads:"
        '
        'intMinLogicalReads_BlitzWho
        '
        Me.intMinLogicalReads_BlitzWho.Location = New System.Drawing.Point(519, 112)
        Me.intMinLogicalReads_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.intMinLogicalReads_BlitzWho.Name = "intMinLogicalReads_BlitzWho"
        Me.intMinLogicalReads_BlitzWho.Size = New System.Drawing.Size(132, 22)
        Me.intMinLogicalReads_BlitzWho.TabIndex = 7
        Me.intMinLogicalReads_BlitzWho.Tag = "MinLogicalReads;0"
        Me.intMinLogicalReads_BlitzWho.Text = "0"
        '
        'lblMinLogicalReads_BlitzWho
        '
        Me.lblMinLogicalReads_BlitzWho.AutoSize = True
        Me.lblMinLogicalReads_BlitzWho.Location = New System.Drawing.Point(364, 116)
        Me.lblMinLogicalReads_BlitzWho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinLogicalReads_BlitzWho.Name = "lblMinLogicalReads_BlitzWho"
        Me.lblMinLogicalReads_BlitzWho.Size = New System.Drawing.Size(116, 16)
        Me.lblMinLogicalReads_BlitzWho.TabIndex = 6
        Me.lblMinLogicalReads_BlitzWho.Text = "MinLogicalReads:"
        '
        'intMinCPUTime_BlitzWho
        '
        Me.intMinCPUTime_BlitzWho.Location = New System.Drawing.Point(519, 48)
        Me.intMinCPUTime_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.intMinCPUTime_BlitzWho.Name = "intMinCPUTime_BlitzWho"
        Me.intMinCPUTime_BlitzWho.Size = New System.Drawing.Size(132, 22)
        Me.intMinCPUTime_BlitzWho.TabIndex = 5
        Me.intMinCPUTime_BlitzWho.Tag = "MinCPUTime;0"
        Me.intMinCPUTime_BlitzWho.Text = "0"
        '
        'lblMinCPUTime_BlitzWho
        '
        Me.lblMinCPUTime_BlitzWho.AutoSize = True
        Me.lblMinCPUTime_BlitzWho.Location = New System.Drawing.Point(364, 52)
        Me.lblMinCPUTime_BlitzWho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinCPUTime_BlitzWho.Name = "lblMinCPUTime_BlitzWho"
        Me.lblMinCPUTime_BlitzWho.Size = New System.Drawing.Size(90, 16)
        Me.lblMinCPUTime_BlitzWho.TabIndex = 4
        Me.lblMinCPUTime_BlitzWho.Text = "MinCPUTime:"
        '
        'intMinElapsedSeconds_BlitzWho
        '
        Me.intMinElapsedSeconds_BlitzWho.Location = New System.Drawing.Point(519, 80)
        Me.intMinElapsedSeconds_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.intMinElapsedSeconds_BlitzWho.Name = "intMinElapsedSeconds_BlitzWho"
        Me.intMinElapsedSeconds_BlitzWho.Size = New System.Drawing.Size(132, 22)
        Me.intMinElapsedSeconds_BlitzWho.TabIndex = 3
        Me.intMinElapsedSeconds_BlitzWho.Tag = "MinElapsedSeconds;0"
        Me.intMinElapsedSeconds_BlitzWho.Text = "0"
        '
        'lblMinElapsedSeconds_BlitzWho
        '
        Me.lblMinElapsedSeconds_BlitzWho.AutoSize = True
        Me.lblMinElapsedSeconds_BlitzWho.Location = New System.Drawing.Point(364, 84)
        Me.lblMinElapsedSeconds_BlitzWho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinElapsedSeconds_BlitzWho.Name = "lblMinElapsedSeconds_BlitzWho"
        Me.lblMinElapsedSeconds_BlitzWho.Size = New System.Drawing.Size(136, 16)
        Me.lblMinElapsedSeconds_BlitzWho.TabIndex = 2
        Me.lblMinElapsedSeconds_BlitzWho.Text = "MinElapsedSeconds:"
        '
        'chkExpertMode_BlitzWho
        '
        Me.chkExpertMode_BlitzWho.AutoSize = True
        Me.chkExpertMode_BlitzWho.Location = New System.Drawing.Point(23, 78)
        Me.chkExpertMode_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.chkExpertMode_BlitzWho.Name = "chkExpertMode_BlitzWho"
        Me.chkExpertMode_BlitzWho.Size = New System.Drawing.Size(102, 20)
        Me.chkExpertMode_BlitzWho.TabIndex = 1
        Me.chkExpertMode_BlitzWho.Tag = "ExpertMode;0"
        Me.chkExpertMode_BlitzWho.Text = "ExpertMode"
        Me.chkExpertMode_BlitzWho.UseVisualStyleBackColor = True
        '
        'chkShowSleepingSPIDs_BlitzWho
        '
        Me.chkShowSleepingSPIDs_BlitzWho.AutoSize = True
        Me.chkShowSleepingSPIDs_BlitzWho.Location = New System.Drawing.Point(23, 52)
        Me.chkShowSleepingSPIDs_BlitzWho.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowSleepingSPIDs_BlitzWho.Name = "chkShowSleepingSPIDs_BlitzWho"
        Me.chkShowSleepingSPIDs_BlitzWho.Size = New System.Drawing.Size(154, 20)
        Me.chkShowSleepingSPIDs_BlitzWho.TabIndex = 0
        Me.chkShowSleepingSPIDs_BlitzWho.Tag = "ShowSleepingSPIDs;0"
        Me.chkShowSleepingSPIDs_BlitzWho.Text = "ShowSleepingSPIDs"
        Me.chkShowSleepingSPIDs_BlitzWho.UseVisualStyleBackColor = True
        '
        'cmdExportToExcel
        '
        Me.cmdExportToExcel.Location = New System.Drawing.Point(595, 321)
        Me.cmdExportToExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExportToExcel.Name = "cmdExportToExcel"
        Me.cmdExportToExcel.Size = New System.Drawing.Size(208, 33)
        Me.cmdExportToExcel.TabIndex = 18
        Me.cmdExportToExcel.Text = "Export below result(s) to Excel"
        Me.cmdExportToExcel.UseVisualStyleBackColor = True
        Me.cmdExportToExcel.Visible = False
        '
        'txtSQL
        '
        Me.txtSQL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSQL.Location = New System.Drawing.Point(9, 362)
        Me.txtSQL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(1576, 70)
        Me.txtSQL.TabIndex = 20
        '
        'cmdManageServers
        '
        Me.cmdManageServers.Location = New System.Drawing.Point(248, 28)
        Me.cmdManageServers.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdManageServers.Name = "cmdManageServers"
        Me.cmdManageServers.Size = New System.Drawing.Size(173, 28)
        Me.cmdManageServers.TabIndex = 25
        Me.cmdManageServers.Text = "Manage SQL servers"
        Me.cmdManageServers.UseVisualStyleBackColor = True
        '
        'gbTimeOut
        '
        Me.gbTimeOut.Location = New System.Drawing.Point(1073, 11)
        Me.gbTimeOut.Margin = New System.Windows.Forms.Padding(4)
        Me.gbTimeOut.Name = "gbTimeOut"
        Me.gbTimeOut.Padding = New System.Windows.Forms.Padding(4)
        Me.gbTimeOut.Size = New System.Drawing.Size(129, 52)
        Me.gbTimeOut.TabIndex = 27
        Me.gbTimeOut.TabStop = False
        Me.gbTimeOut.Text = "Timeout (seconds)"
        '
        'cmdOpenExcelFolder
        '
        Me.cmdOpenExcelFolder.Location = New System.Drawing.Point(828, 321)
        Me.cmdOpenExcelFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOpenExcelFolder.Name = "cmdOpenExcelFolder"
        Me.cmdOpenExcelFolder.Size = New System.Drawing.Size(285, 33)
        Me.cmdOpenExcelFolder.TabIndex = 28
        Me.cmdOpenExcelFolder.Text = "Open folder where Excel files are saved"
        Me.cmdOpenExcelFolder.UseVisualStyleBackColor = True
        Me.cmdOpenExcelFolder.Visible = False
        '
        'lblLatestExecutedScript
        '
        Me.lblLatestExecutedScript.AutoSize = True
        Me.lblLatestExecutedScript.Location = New System.Drawing.Point(5, 342)
        Me.lblLatestExecutedScript.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLatestExecutedScript.Name = "lblLatestExecutedScript"
        Me.lblLatestExecutedScript.Size = New System.Drawing.Size(204, 16)
        Me.lblLatestExecutedScript.TabIndex = 21
        Me.lblLatestExecutedScript.Text = "SQL script that was last executed:"
        '
        'lblSelectDatabase
        '
        Me.lblSelectDatabase.AutoSize = True
        Me.lblSelectDatabase.Location = New System.Drawing.Point(435, 11)
        Me.lblSelectDatabase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectDatabase.Name = "lblSelectDatabase"
        Me.lblSelectDatabase.Size = New System.Drawing.Size(200, 16)
        Me.lblSelectDatabase.TabIndex = 29
        Me.lblSelectDatabase.Text = "Select main database (optional):"
        '
        'ddlDatabases
        '
        Me.ddlDatabases.FormattingEnabled = True
        Me.ddlDatabases.Location = New System.Drawing.Point(439, 31)
        Me.ddlDatabases.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlDatabases.Name = "ddlDatabases"
        Me.ddlDatabases.Size = New System.Drawing.Size(335, 24)
        Me.ddlDatabases.TabIndex = 30
        '
        'lblDatabasesNotSelectable
        '
        Me.lblDatabasesNotSelectable.AutoSize = True
        Me.lblDatabasesNotSelectable.Location = New System.Drawing.Point(435, 34)
        Me.lblDatabasesNotSelectable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabasesNotSelectable.Name = "lblDatabasesNotSelectable"
        Me.lblDatabasesNotSelectable.Size = New System.Drawing.Size(352, 16)
        Me.lblDatabasesNotSelectable.TabIndex = 31
        Me.lblDatabasesNotSelectable.Text = "Not available since sprocs are not in the master database."
        '
        'lblOutputResultSets_BlitzFirst
        '
        Me.lblOutputResultSets_BlitzFirst.AutoSize = True
        Me.lblOutputResultSets_BlitzFirst.Location = New System.Drawing.Point(768, 16)
        Me.lblOutputResultSets_BlitzFirst.Name = "lblOutputResultSets_BlitzFirst"
        Me.lblOutputResultSets_BlitzFirst.Size = New System.Drawing.Size(113, 16)
        Me.lblOutputResultSets_BlitzFirst.TabIndex = 57
        Me.lblOutputResultSets_BlitzFirst.Text = "OutputResultSets:"
        '
        'chkBlitzWhoStart_BlitzFirst
        '
        Me.chkBlitzWhoStart_BlitzFirst.AutoSize = True
        Me.chkBlitzWhoStart_BlitzFirst.Checked = True
        Me.chkBlitzWhoStart_BlitzFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBlitzWhoStart_BlitzFirst.Location = New System.Drawing.Point(771, 38)
        Me.chkBlitzWhoStart_BlitzFirst.Name = "chkBlitzWhoStart_BlitzFirst"
        Me.chkBlitzWhoStart_BlitzFirst.Size = New System.Drawing.Size(115, 20)
        Me.chkBlitzWhoStart_BlitzFirst.TabIndex = 58
        Me.chkBlitzWhoStart_BlitzFirst.Tag = "OutputResultSets;-1"
        Me.chkBlitzWhoStart_BlitzFirst.Text = "BlitzWho_Start"
        Me.chkBlitzWhoStart_BlitzFirst.UseVisualStyleBackColor = True
        '
        'chkFindings_BlitzFirst
        '
        Me.chkFindings_BlitzFirst.AutoSize = True
        Me.chkFindings_BlitzFirst.Checked = True
        Me.chkFindings_BlitzFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFindings_BlitzFirst.Location = New System.Drawing.Point(784, 58)
        Me.chkFindings_BlitzFirst.Name = "chkFindings_BlitzFirst"
        Me.chkFindings_BlitzFirst.Size = New System.Drawing.Size(80, 20)
        Me.chkFindings_BlitzFirst.TabIndex = 59
        Me.chkFindings_BlitzFirst.Tag = "OutputResultSets;-1"
        Me.chkFindings_BlitzFirst.Text = "Findings"
        Me.chkFindings_BlitzFirst.UseVisualStyleBackColor = True
        '
        'chkFileStats_BlitzFirst
        '
        Me.chkFileStats_BlitzFirst.AutoSize = True
        Me.chkFileStats_BlitzFirst.Checked = True
        Me.chkFileStats_BlitzFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFileStats_BlitzFirst.Location = New System.Drawing.Point(784, 76)
        Me.chkFileStats_BlitzFirst.Name = "chkFileStats_BlitzFirst"
        Me.chkFileStats_BlitzFirst.Size = New System.Drawing.Size(81, 20)
        Me.chkFileStats_BlitzFirst.TabIndex = 60
        Me.chkFileStats_BlitzFirst.Tag = "OutputResultSets;-1"
        Me.chkFileStats_BlitzFirst.Text = "FileStats"
        Me.chkFileStats_BlitzFirst.UseVisualStyleBackColor = True
        '
        'chkPerfmonStats_BlitzFirst
        '
        Me.chkPerfmonStats_BlitzFirst.AutoSize = True
        Me.chkPerfmonStats_BlitzFirst.Checked = True
        Me.chkPerfmonStats_BlitzFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPerfmonStats_BlitzFirst.Location = New System.Drawing.Point(784, 94)
        Me.chkPerfmonStats_BlitzFirst.Name = "chkPerfmonStats_BlitzFirst"
        Me.chkPerfmonStats_BlitzFirst.Size = New System.Drawing.Size(109, 20)
        Me.chkPerfmonStats_BlitzFirst.TabIndex = 61
        Me.chkPerfmonStats_BlitzFirst.Tag = "OutputResultSets;-1"
        Me.chkPerfmonStats_BlitzFirst.Text = "PerfmonStats"
        Me.chkPerfmonStats_BlitzFirst.UseVisualStyleBackColor = True
        '
        'chkWaitStats_BlitzFirst
        '
        Me.chkWaitStats_BlitzFirst.AutoSize = True
        Me.chkWaitStats_BlitzFirst.Checked = True
        Me.chkWaitStats_BlitzFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWaitStats_BlitzFirst.Location = New System.Drawing.Point(784, 112)
        Me.chkWaitStats_BlitzFirst.Name = "chkWaitStats_BlitzFirst"
        Me.chkWaitStats_BlitzFirst.Size = New System.Drawing.Size(86, 20)
        Me.chkWaitStats_BlitzFirst.TabIndex = 62
        Me.chkWaitStats_BlitzFirst.Tag = "OutputResultSets;-1"
        Me.chkWaitStats_BlitzFirst.Text = "WaitStats"
        Me.chkWaitStats_BlitzFirst.UseVisualStyleBackColor = True
        '
        'chkBlitzCache_BlitzFirst
        '
        Me.chkBlitzCache_BlitzFirst.AutoSize = True
        Me.chkBlitzCache_BlitzFirst.Checked = True
        Me.chkBlitzCache_BlitzFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBlitzCache_BlitzFirst.Location = New System.Drawing.Point(784, 130)
        Me.chkBlitzCache_BlitzFirst.Name = "chkBlitzCache_BlitzFirst"
        Me.chkBlitzCache_BlitzFirst.Size = New System.Drawing.Size(92, 20)
        Me.chkBlitzCache_BlitzFirst.TabIndex = 63
        Me.chkBlitzCache_BlitzFirst.Tag = "OutputResultSets;-1"
        Me.chkBlitzCache_BlitzFirst.Text = "BlitzCache"
        Me.chkBlitzCache_BlitzFirst.UseVisualStyleBackColor = True
        '
        'chkBlitzWhoEnd_BlitzFirst
        '
        Me.chkBlitzWhoEnd_BlitzFirst.AutoSize = True
        Me.chkBlitzWhoEnd_BlitzFirst.Checked = True
        Me.chkBlitzWhoEnd_BlitzFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBlitzWhoEnd_BlitzFirst.Location = New System.Drawing.Point(771, 150)
        Me.chkBlitzWhoEnd_BlitzFirst.Name = "chkBlitzWhoEnd_BlitzFirst"
        Me.chkBlitzWhoEnd_BlitzFirst.Size = New System.Drawing.Size(112, 20)
        Me.chkBlitzWhoEnd_BlitzFirst.TabIndex = 64
        Me.chkBlitzWhoEnd_BlitzFirst.Tag = "OutputResultSets;-1"
        Me.chkBlitzWhoEnd_BlitzFirst.Text = "BlitzWho_End"
        Me.chkBlitzWhoEnd_BlitzFirst.UseVisualStyleBackColor = True
        '
        'BlitzDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1592, 715)
        Me.Controls.Add(Me.lblDatabasesNotSelectable)
        Me.Controls.Add(Me.lblSelectDatabase)
        Me.Controls.Add(Me.ddlDatabases)
        Me.Controls.Add(Me.cmdOpenExcelFolder)
        Me.Controls.Add(Me.gbTimeOut)
        Me.Controls.Add(Me.cmdManageServers)
        Me.Controls.Add(Me.lblLatestExecutedScript)
        Me.Controls.Add(Me.txtSQL)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.cmdExportToExcel)
        Me.Controls.Add(Me.tcFilters)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.cmdExecute)
        Me.Controls.Add(Me.lblSelectSproc)
        Me.Controls.Add(Me.ddlServers)
        Me.Controls.Add(Me.ddlSprocs)
        Me.Controls.Add(Me.lblServers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BlitzDesktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcFilters.ResumeLayout(False)
        Me.sp_Blitz.ResumeLayout(False)
        Me.sp_Blitz.PerformLayout()
        Me.sp_BlitzAnalysis.ResumeLayout(False)
        Me.sp_BlitzAnalysis.PerformLayout()
        Me.sp_BlitzBackups.ResumeLayout(False)
        Me.sp_BlitzBackups.PerformLayout()
        Me.sp_BlitzCache.ResumeLayout(False)
        Me.sp_BlitzCache.PerformLayout()
        Me.sp_BlitzFirst.ResumeLayout(False)
        Me.sp_BlitzFirst.PerformLayout()
        Me.sp_BlitzIndex.ResumeLayout(False)
        Me.sp_BlitzIndex.PerformLayout()
        Me.sp_BlitzLock.ResumeLayout(False)
        Me.sp_BlitzLock.PerformLayout()
        Me.sp_BlitzQueryStore.ResumeLayout(False)
        Me.sp_BlitzQueryStore.PerformLayout()
        Me.sp_BlitzWho.ResumeLayout(False)
        Me.sp_BlitzWho.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblServers As Label
    Friend WithEvents ddlServers As ComboBox
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents lblSelectSproc As Label
    Friend WithEvents ddlSprocs As ComboBox
    Friend WithEvents cmdExecute As Button
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents tcFilters As TabControl
    Friend WithEvents sp_Blitz As TabPage
    Friend WithEvents chkSummaryMode_Blitz As CheckBox
    Friend WithEvents chkCheckServerInfo_Blitz As CheckBox
    Friend WithEvents chkCheckUserDatabaseObjects_Blitz As CheckBox
    Friend WithEvents sp_BlitzCache As TabPage
    Friend WithEvents sp_BlitzIndex As TabPage
    Friend WithEvents lblIgnorePrioritiesAbove_Blitz As Label
    Friend WithEvents lblIgnorePrioritiesBelow_Blitz As Label
    Friend WithEvents chkSkipBlockingChecks_Blitz As CheckBox
    Friend WithEvents chkBringThePain_Blitz As CheckBox
    Friend WithEvents intIgnorePrioritiesAbove_Blitz As TextBox
    Friend WithEvents intIgnorePrioritiesBelow_Blitz As TextBox
    Friend WithEvents cmdExportToExcel As Button
    Friend WithEvents sp_BlitzLock As TabPage
    Friend WithEvents sp_BlitzQueryStore As TabPage
    Friend WithEvents sp_BlitzWho As TabPage
    Friend WithEvents chkExportToExcel_BlitzCache As CheckBox
    Friend WithEvents intTop_BlitzCache As TextBox
    Friend WithEvents lblTop_BlitzCache As Label
    Friend WithEvents chkExpertMode_BlitzCache As CheckBox
    Friend WithEvents ddlSortOrder_BlitzCache As ComboBox
    Friend WithEvents lblSortOrder_BlitzCache As Label
    Friend WithEvents intDurationFilter_BlitzCache As TextBox
    Friend WithEvents lblDurationFilter_BlitzCache As Label
    Friend WithEvents ddlDatabaseName_BlitzCache As ComboBox
    Friend WithEvents lblDatabaseName_BlitzCache As Label
    Friend WithEvents ddlQueryFilter_BlitzCache As ComboBox
    Friend WithEvents lblQueryFilter_BlitzCache As Label
    Friend WithEvents chkIgnoreSystemDVs_BlitzCache As CheckBox
    Friend WithEvents chkHideSummary_BlitzCache As CheckBox
    Friend WithEvents lblSlowlySearchPlansFor_BlitzCache As Label
    Friend WithEvents ddlStoredProcName_BlitzCache As ComboBox
    Friend WithEvents lblStoredProcName_BlitzCache As Label
    Friend WithEvents intMinutesBack_BlitzCache As TextBox
    Friend WithEvents lblMinutesBack_BlitzCache As Label
    Friend WithEvents MinimumExecutionCount_BlitzCache As TextBox
    Friend WithEvents lblMinimumExecutionCount_BlitzCache As Label
    Friend WithEvents strSlowlySearchPlansFor_BlitzCache As TextBox
    Friend WithEvents ddlTableName_BlitzIndex As ComboBox
    Friend WithEvents lblTableName_BlitzIndex As Label
    Friend WithEvents ddlSchemaName_BlitzIndex As ComboBox
    Friend WithEvents lblSchemaName_BlitzIndex As Label
    Friend WithEvents ddlDatabaseName_BlitzIndex As ComboBox
    Friend WithEvents lblDatabaseName_BlitzIndex As Label
    Friend WithEvents chkShowAllMissingIndexRequests_BlitzIndex As CheckBox
    Friend WithEvents chkIncludeInactiveIndexes_BlitzIndex As CheckBox
    Friend WithEvents strIgnoreDatabases_BlitzIndex As TextBox
    Friend WithEvents lblIgnoreDatabases_BlitzIndex As Label
    Friend WithEvents chkBringThePain_BlitzIndex As CheckBox
    Friend WithEvents chkGetAllDatabases_BlitzIndex As CheckBox
    Friend WithEvents txtSQL As TextBox
    Friend WithEvents chkShowColumnstoreOnly_BlitzIndex As CheckBox
    Friend WithEvents ddlSortDirection_BlitzIndex As ComboBox
    Friend WithEvents lblSortDirection_BlitzIndex As Label
    Friend WithEvents ddlSortOrder_BlitzIndex As ComboBox
    Friend WithEvents lblSortOrder_BlitzIndex As Label
    Friend WithEvents ddlMode_BlitzIndex As ComboBox
    Friend WithEvents lblMode_BlitzIndex As Label
    Friend WithEvents ddlTableName_Internal_BlitzLock As ComboBox
    Friend WithEvents lblTableName_BlitzLock As Label
    Friend WithEvents ddlSchemaName_Internal_BlitzLock As ComboBox
    Friend WithEvents lblSchemaName_BlitzLock As Label
    Friend WithEvents dtpEndDate_BlitzLock As DateTimePicker
    Friend WithEvents lblEndDate_BlitzLock As Label
    Friend WithEvents dtpStartDate_BlitzLock As DateTimePicker
    Friend WithEvents lblStartDate_BlitzLock As Label
    Friend WithEvents ddlStoredProcName_BlitzLock As ComboBox
    Friend WithEvents lblStoredProcName_BlitzLock As Label
    Friend WithEvents ddlDatabaseName_BlitzLock As ComboBox
    Friend WithEvents lblDatabaseName_BlitzLock As Label
    Friend WithEvents chkExportToExcel_BlitzLock As CheckBox
    Friend WithEvents chkVictimsOnly_BlitzLock As CheckBox
    Friend WithEvents strLoginName_BlitzLock As TextBox
    Friend WithEvents lblLoginName_BlitzLock As Label
    Friend WithEvents strHostName_BlitzLock As TextBox
    Friend WithEvents lblHostName_BlitzLock As Label
    Friend WithEvents strAppName_BlitzLock As TextBox
    Friend WithEvents lblAppName_BlitzLock As Label
    Friend WithEvents dtpEndDate_BlitzQueryStore As DateTimePicker
    Friend WithEvents lblEndDate_BlitzQueryStore As Label
    Friend WithEvents dtpStartDate_BlitzQueryStore As DateTimePicker
    Friend WithEvents lblStartDate_BlitzQueryStore As Label
    Friend WithEvents ddlStoredProcName_BlitzQueryStore As ComboBox
    Friend WithEvents lblStoredProcName_BlitzQueryStore As Label
    Friend WithEvents ddlDatabaseName_BlitzQueryStore As ComboBox
    Friend WithEvents lblDatabaseName_BlitzQueryStore As Label
    Friend WithEvents intTop_BlitzQueryStore As TextBox
    Friend WithEvents lblTop_BlitzQueryStore As Label
    Friend WithEvents chkExportToExcel_BlitzQueryStore As CheckBox
    Friend WithEvents chkExpertMode_BlitzQueryStore As CheckBox
    Friend WithEvents chkSkipXML_BlitzQueryStore As CheckBox
    Friend WithEvents chkFailed_BlitzQueryStore As CheckBox
    Friend WithEvents intDurationFilter_BlitzQueryStore As TextBox
    Friend WithEvents lblDurationFilter_BlitzQueryStore As Label
    Friend WithEvents intMinimumExecutionCount_BlitzQueryStore As TextBox
    Friend WithEvents lblMinimumExecutionCount_BlitzQueryStore As Label
    Friend WithEvents ddlSortOrder_BlitzWho As ComboBox
    Friend WithEvents lblSortOrder_BlitzWho As Label
    Friend WithEvents intMinBlockingSeconds_BlitzWho As TextBox
    Friend WithEvents lblMinBlockingSeconds_BlitzWho As Label
    Friend WithEvents intMinRequestedMemoryKB_BlitzWho As TextBox
    Friend WithEvents lblMinRequestedMemoryKB_BlitzWho As Label
    Friend WithEvents intMinTempdbMB_BlitzWho As TextBox
    Friend WithEvents lblMinTempdbMB_BlitzWho As Label
    Friend WithEvents intMinWrites_BlitzWho As TextBox
    Friend WithEvents lblMinWrites_BlitzWho As Label
    Friend WithEvents intMinPhysicalReads_BlitzWho As TextBox
    Friend WithEvents lblMinPhysicalReads_BlitzWho As Label
    Friend WithEvents intMinLogicalReads_BlitzWho As TextBox
    Friend WithEvents lblMinLogicalReads_BlitzWho As Label
    Friend WithEvents intMinCPUTime_BlitzWho As TextBox
    Friend WithEvents lblMinCPUTime_BlitzWho As Label
    Friend WithEvents intMinElapsedSeconds_BlitzWho As TextBox
    Friend WithEvents lblMinElapsedSeconds_BlitzWho As Label
    Friend WithEvents chkExpertMode_BlitzWho As CheckBox
    Friend WithEvents chkShowSleepingSPIDs_BlitzWho As CheckBox
    Friend WithEvents sp_BlitzFirst As TabPage
    Friend WithEvents chkSinceStartup_BlitzFirst As CheckBox
    Friend WithEvents intFileLatencyThresholdMS_BlitzFirst As TextBox
    Friend WithEvents lblFileLatencyThresholdMS_BlitzFirst As Label
    Friend WithEvents chkCheckServerInfo_BlitzFirst As CheckBox
    Friend WithEvents intMemoryGrantThresholdPct_BlitzFirst As TextBox
    Friend WithEvents lblMemoryGrantThresholdPct_BlitzFirst As Label
    Friend WithEvents chkBlitzCacheSkipAnalysis_BlitzFirst As CheckBox
    Friend WithEvents chkShowSleepingSPIDs_BlitzFirst As CheckBox
    Friend WithEvents chkCheckProcedureCache_BlitzFirst As CheckBox
    Friend WithEvents ddlFilterPlansByDatabase_BlitzFirst As ComboBox
    Friend WithEvents lblFilterPlansByDatabase_BlitzFirst As Label
    Friend WithEvents intSeconds_BlitzFirst As TextBox
    Friend WithEvents lblSeconds_BlitzFirst As Label
    Friend WithEvents chkExpertMode_BlitzFirst As CheckBox
    Friend WithEvents dtpEndTime_BlitzQueryStore As DateTimePicker
    Friend WithEvents dtpStartTime_BlitzQueryStore As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents chkCheckProcedureCache_Blitz As CheckBox
    Friend WithEvents chkOutputProcedureCache_Blitz As CheckBox
    Friend WithEvents lblCheckProcedureCacheFilter_Blitz As Label
    Friend WithEvents lblOutputType_Blitz As Label
    Friend WithEvents ddlOutputType_Blitz As ComboBox
    Friend WithEvents ddlCheckProcedureCacheFilter_Blitz As ComboBox
    Friend WithEvents chkGetOuterCommand_BlitzWho As CheckBox
    Friend WithEvents cmdManageServers As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents gbTimeOut As GroupBox
    Friend WithEvents chkUseBelowDate_Internal_BlitzLock As CheckBox
    Friend WithEvents dtpEndTime_BlitzLock As DateTimePicker
    Friend WithEvents dtpStartTime_BlitzLock As DateTimePicker
    Friend WithEvents chkSkipAanlysis_BlitzCache As CheckBox
    Friend WithEvents ddlOutputType_BlitzFirst As ComboBox
    Friend WithEvents lblOutputType_BlitzFirst As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdOpenExcelFolder As Button
    Friend WithEvents sp_BlitzAnalysis As TabPage
    Friend WithEvents sp_BlitzBackups As TabPage
    Friend WithEvents intMaxDop_BlitzAnalysis As TextBox
    Friend WithEvents lblMaxDop_BlitzAnalysis As Label
    Friend WithEvents chkBringThePain_BlitzAnalysis As CheckBox
    Friend WithEvents intWriteLatencyThreshold As TextBox
    Friend WithEvents lblWriteLatencyThreshold_BlitzAnalysis As Label
    Friend WithEvents intReadLatencyThreshold As TextBox
    Friend WithEvents lblReadLatencyThreshold_BlitzAnalysis As Label
    Friend WithEvents intWaitStatsTop_BlitzAnalysis As TextBox
    Friend WithEvents lblWaitStatsTop_BlitzAnalysis As Label
    Friend WithEvents ddlBlitzCacheSortOrder_BlitzAnalysis As ComboBox
    Friend WithEvents lblBlitzCacheSortOrder_BlitzAnalysis As Label
    Friend WithEvents intMaxBlitzFirstPriority_BlitzAnalysis As TextBox
    Friend WithEvents lblMaxBlitzFirstPriority_BlitzAnalysis As Label
    Friend WithEvents lblDatabaseName_BlitzAnalysis As Label
    Friend WithEvents lblServerName_BlitzAnalysis As Label
    Friend WithEvents ddlOutputTableNameFileStats_BlitzAnalysis As ComboBox
    Friend WithEvents lblOutputTableNameFileStats_BlitzAnalysis As Label
    Friend WithEvents ddlOutputTableNamePerfmonStats_BlitzAnalysis As ComboBox
    Friend WithEvents lblOutputTableNamePerfmonStats_BlitzAnalysis As Label
    Friend WithEvents ddlOutputTableNameBlitzCache_BlitzAnalysis As ComboBox
    Friend WithEvents lblOutputTableNameBlitzCache_BlitzAnalysis As Label
    Friend WithEvents ddlOutputTableNameBlitzWho_BlitzAnalysis As ComboBox
    Friend WithEvents lblOutputTableNameBlitzWho_BlitzAnalysis As Label
    Friend WithEvents ddlOutputTableNameWaitStats_BlitzAnalysis As ComboBox
    Friend WithEvents lblOutputTableNameWaitStats_BlitzAnalysis As Label
    Friend WithEvents ddlOutputTableNameBlitzFirst_BlitzAnalysis As ComboBox
    Friend WithEvents lblOutputTableNameBlitzFirst_BlitzAnalysis As Label
    Friend WithEvents ddlOutputSchemaName_BlitzAnalysis As ComboBox
    Friend WithEvents lblOutputSchemaName_BlitzAnalysis As Label
    Friend WithEvents ddlOutputDatabaseName_BlitzAnalysis As ComboBox
    Friend WithEvents lblOutputDatabaseName_BlitzAnalysis As Label
    Friend WithEvents dtpEndTime_BlitzAnalysis As DateTimePicker
    Friend WithEvents dtpStartTime_BlitzAnalysis As DateTimePicker
    Friend WithEvents dtpEndDate_BlitzAnalysis As DateTimePicker
    Friend WithEvents lblEndDate_BlitzAnalysis As Label
    Friend WithEvents dtpStartDate_BlitzAnalysis As DateTimePicker
    Friend WithEvents lblStartDate_BlitzAnalysis As Label
    Friend WithEvents intHoursBack_BlitzBackups As TextBox
    Friend WithEvents lblHoursBack_BlitzBackups As Label
    Friend WithEvents strDatabaseName_BlitzAnalysis As TextBox
    Friend WithEvents strServerName_BlitzAnalysis As TextBox
    Friend WithEvents lblLatestExecutedScript As Label
    Friend WithEvents chkGetLiveQueryPlan_BlitzWho As CheckBox
    Friend WithEvents lblSelectDatabase As Label
    Friend WithEvents ddlDatabases As ComboBox
    Friend WithEvents lblDatabasesNotSelectable As Label
    Friend WithEvents chkBringThePain_BlitzCache As CheckBox
    Friend WithEvents chkBlitzWhoEnd_BlitzFirst As CheckBox
    Friend WithEvents chkBlitzCache_BlitzFirst As CheckBox
    Friend WithEvents chkWaitStats_BlitzFirst As CheckBox
    Friend WithEvents chkPerfmonStats_BlitzFirst As CheckBox
    Friend WithEvents chkFileStats_BlitzFirst As CheckBox
    Friend WithEvents chkFindings_BlitzFirst As CheckBox
    Friend WithEvents chkBlitzWhoStart_BlitzFirst As CheckBox
    Friend WithEvents lblOutputResultSets_BlitzFirst As Label
End Class
