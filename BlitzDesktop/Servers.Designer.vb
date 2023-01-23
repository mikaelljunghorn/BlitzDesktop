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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Servers))
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
        Me.ddlDatabases.Location = New System.Drawing.Point(596, 98)
        Me.ddlDatabases.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ddlDatabases.Name = "ddlDatabases"
        Me.ddlDatabases.Size = New System.Drawing.Size(225, 24)
        Me.ddlDatabases.TabIndex = 29
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(461, 101)
        Me.lblDatabase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(117, 16)
        Me.lblDatabase.TabIndex = 28
        Me.lblDatabase.Text = "sp_Blitz database:"
        '
        'lblServers
        '
        Me.lblServers.AutoSize = True
        Me.lblServers.Location = New System.Drawing.Point(32, 101)
        Me.lblServers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServers.Name = "lblServers"
        Me.lblServers.Size = New System.Drawing.Size(115, 16)
        Me.lblServers.TabIndex = 26
        Me.lblServers.Text = "New server name:"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(167, 98)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(225, 22)
        Me.txtServer.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Authentication:"
        '
        'ddlAuthentication
        '
        Me.ddlAuthentication.FormattingEnabled = True
        Me.ddlAuthentication.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
        Me.ddlAuthentication.Location = New System.Drawing.Point(167, 130)
        Me.ddlAuthentication.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ddlAuthentication.Name = "ddlAuthentication"
        Me.ddlAuthentication.Size = New System.Drawing.Size(225, 24)
        Me.ddlAuthentication.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "User name:"
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(167, 164)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(225, 22)
        Me.txtUserName.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 198)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(167, 196)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(225, 22)
        Me.txtPassword.TabIndex = 37
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(167, 240)
        Me.cmdConnect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(227, 28)
        Me.cmdConnect.TabIndex = 38
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'ddlServers
        '
        Me.ddlServers.FormattingEnabled = True
        Me.ddlServers.Location = New System.Drawing.Point(167, 28)
        Me.ddlServers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ddlServers.Name = "ddlServers"
        Me.ddlServers.Size = New System.Drawing.Size(225, 24)
        Me.ddlServers.TabIndex = 39
        '
        'cmdRemoveServer
        '
        Me.cmdRemoveServer.Location = New System.Drawing.Point(401, 28)
        Me.cmdRemoveServer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdRemoveServer.Name = "cmdRemoveServer"
        Me.cmdRemoveServer.Size = New System.Drawing.Size(187, 26)
        Me.cmdRemoveServer.TabIndex = 40
        Me.cmdRemoveServer.Text = "Remove selected server"
        Me.cmdRemoveServer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Saved servers:"
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(465, 354)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 28)
        Me.cmdSave.TabIndex = 42
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(228, 354)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 28)
        Me.cmdCancel.TabIndex = 43
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(329, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Found sp_Blitz Stored Procedures in above database:"
        '
        'lbFoundSprocs
        '
        Me.lbFoundSprocs.FormattingEnabled = True
        Me.lbFoundSprocs.ItemHeight = 16
        Me.lbFoundSprocs.Location = New System.Drawing.Point(465, 164)
        Me.lbFoundSprocs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbFoundSprocs.Name = "lbFoundSprocs"
        Me.lbFoundSprocs.Size = New System.Drawing.Size(217, 180)
        Me.lbFoundSprocs.TabIndex = 45
        '
        'Servers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 414)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
