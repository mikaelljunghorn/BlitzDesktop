<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ddlDatabases = New System.Windows.Forms.ComboBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.lblServers = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddlAuthentication = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.ddlServers = New System.Windows.Forms.ComboBox()
        Me.cmdRemoveServer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbFoundSprocs = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ddlDatabases
        '
        Me.ddlDatabases.Enabled = False
        Me.ddlDatabases.FormattingEnabled = True
        Me.ddlDatabases.Location = New System.Drawing.Point(447, 80)
        Me.ddlDatabases.Name = "ddlDatabases"
        Me.ddlDatabases.Size = New System.Drawing.Size(170, 21)
        Me.ddlDatabases.TabIndex = 29
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(346, 82)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(93, 13)
        Me.lblDatabase.TabIndex = 28
        Me.lblDatabase.Text = "sp_Blitz database:"
        '
        'lblServers
        '
        Me.lblServers.AutoSize = True
        Me.lblServers.Location = New System.Drawing.Point(24, 82)
        Me.lblServers.Name = "lblServers"
        Me.lblServers.Size = New System.Drawing.Size(93, 13)
        Me.lblServers.TabIndex = 26
        Me.lblServers.Text = "New server name:"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(125, 80)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(170, 20)
        Me.txtServer.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Authentication:"
        '
        'ddlAuthentication
        '
        Me.ddlAuthentication.FormattingEnabled = True
        Me.ddlAuthentication.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
        Me.ddlAuthentication.Location = New System.Drawing.Point(125, 106)
        Me.ddlAuthentication.Name = "ddlAuthentication"
        Me.ddlAuthentication.Size = New System.Drawing.Size(170, 21)
        Me.ddlAuthentication.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "User name:"
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(125, 133)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(170, 20)
        Me.txtUserName.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(125, 159)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(170, 20)
        Me.txtPassword.TabIndex = 37
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(125, 195)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(170, 23)
        Me.cmdConnect.TabIndex = 38
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'ddlServers
        '
        Me.ddlServers.FormattingEnabled = True
        Me.ddlServers.Location = New System.Drawing.Point(125, 23)
        Me.ddlServers.Name = "ddlServers"
        Me.ddlServers.Size = New System.Drawing.Size(170, 21)
        Me.ddlServers.TabIndex = 39
        '
        'cmdRemoveServer
        '
        Me.cmdRemoveServer.Location = New System.Drawing.Point(301, 23)
        Me.cmdRemoveServer.Name = "cmdRemoveServer"
        Me.cmdRemoveServer.Size = New System.Drawing.Size(140, 21)
        Me.cmdRemoveServer.TabIndex = 40
        Me.cmdRemoveServer.Text = "Remove selected server"
        Me.cmdRemoveServer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Saved servers:"
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(349, 288)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 42
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(171, 288)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 43
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(346, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Found sp_Blitz Stored Procedures in above database:"
        '
        'lbFoundSprocs
        '
        Me.lbFoundSprocs.FormattingEnabled = True
        Me.lbFoundSprocs.Location = New System.Drawing.Point(349, 133)
        Me.lbFoundSprocs.Name = "lbFoundSprocs"
        Me.lbFoundSprocs.Size = New System.Drawing.Size(164, 147)
        Me.lbFoundSprocs.TabIndex = 45
        '
        'Servers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 336)
        Me.Controls.Add(Me.lbFoundSprocs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdRemoveServer)
        Me.Controls.Add(Me.ddlServers)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ddlAuthentication)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.ddlDatabases)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.lblServers)
        Me.Name = "Servers"
        Me.Text = "Manage servers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ddlDatabases As ComboBox
    Friend WithEvents lblDatabase As Label
    Friend WithEvents lblServers As Label
    Friend WithEvents txtServer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ddlAuthentication As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmdConnect As Button
    Friend WithEvents ddlServers As ComboBox
    Friend WithEvents cmdRemoveServer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lbFoundSprocs As ListBox
End Class
