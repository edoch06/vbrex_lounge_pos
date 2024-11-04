<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIBackend
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIBackend))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.StockMasterFileUploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.POSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.EODToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeneralDailySalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DailySalesByPaymentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.StocksReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.DatabaseConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompanyDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.SystemSecurityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SystemUserPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserGroupPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.SystemLogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SystemExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WwwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_connect = New System.Windows.Forms.Label
        Me.login_status = New System.Windows.Forms.Label
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Enabled = False
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.TasToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.WindowsMenu, Me.HelpMenu, Me.WwwToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WwwToolStripMenuItem
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockMasterFileUploadToolStripMenuItem, Me.ToolStripSeparator14, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'StockMasterFileUploadToolStripMenuItem
        '
        Me.StockMasterFileUploadToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.uploadtoftpB_24
        Me.StockMasterFileUploadToolStripMenuItem.Name = "StockMasterFileUploadToolStripMenuItem"
        Me.StockMasterFileUploadToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.StockMasterFileUploadToolStripMenuItem.Text = "&Stock Master File Upload"
        Me.StockMasterFileUploadToolStripMenuItem.ToolTipText = "Upload stock files"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(201, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.jogforward_24
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'TasToolStripMenuItem
        '
        Me.TasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.POSToolStripMenuItem, Me.ToolStripSeparator6, Me.EODToolStripMenuItem})
        Me.TasToolStripMenuItem.Name = "TasToolStripMenuItem"
        Me.TasToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.TasToolStripMenuItem.Text = "&Tasks"
        '
        'POSToolStripMenuItem
        '
        Me.POSToolStripMenuItem.Image = CType(resources.GetObject("POSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.POSToolStripMenuItem.Name = "POSToolStripMenuItem"
        Me.POSToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.POSToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.POSToolStripMenuItem.Text = "&POS"
        Me.POSToolStripMenuItem.ToolTipText = "Make customer orders and close sales"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(149, 6)
        '
        'EODToolStripMenuItem
        '
        Me.EODToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.home_24
        Me.EODToolStripMenuItem.Name = "EODToolStripMenuItem"
        Me.EODToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EODToolStripMenuItem.Text = "&End Of Day"
        Me.EODToolStripMenuItem.ToolTipText = "Make end of sale"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesReportToolStripMenuItem, Me.GeneralDailySalesReportToolStripMenuItem, Me.DailySalesByPaymentReportToolStripMenuItem, Me.ToolStripSeparator1, Me.StocksReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.generalledger_24
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.SalesReportToolStripMenuItem.Text = "&General Daily Sales Report"
        '
        'GeneralDailySalesReportToolStripMenuItem
        '
        Me.GeneralDailySalesReportToolStripMenuItem.Name = "GeneralDailySalesReportToolStripMenuItem"
        Me.GeneralDailySalesReportToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.GeneralDailySalesReportToolStripMenuItem.Text = "&Daily Sales By Item Report"
        '
        'DailySalesByPaymentReportToolStripMenuItem
        '
        Me.DailySalesByPaymentReportToolStripMenuItem.Name = "DailySalesByPaymentReportToolStripMenuItem"
        Me.DailySalesByPaymentReportToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.DailySalesByPaymentReportToolStripMenuItem.Text = "&Daily Sales By Payment Report"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(230, 6)
        '
        'StocksReportToolStripMenuItem
        '
        Me.StocksReportToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.invoice_24
        Me.StocksReportToolStripMenuItem.Name = "StocksReportToolStripMenuItem"
        Me.StocksReportToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.StocksReportToolStripMenuItem.Text = "&Stocks Reports"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseConnectionsToolStripMenuItem, Me.CompanyDeToolStripMenuItem, Me.ToolStripSeparator11, Me.SystemSecurityToolStripMenuItem, Me.ToolStripSeparator10, Me.SystemLogoutToolStripMenuItem, Me.SystemExitToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(61, 20)
        Me.WindowsMenu.Text = "&Settings"
        '
        'DatabaseConnectionsToolStripMenuItem
        '
        Me.DatabaseConnectionsToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.databaseadministrator_24
        Me.DatabaseConnectionsToolStripMenuItem.Name = "DatabaseConnectionsToolStripMenuItem"
        Me.DatabaseConnectionsToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.DatabaseConnectionsToolStripMenuItem.Text = "&Database Connections Setup"
        Me.DatabaseConnectionsToolStripMenuItem.ToolTipText = "Make database connections"
        '
        'CompanyDeToolStripMenuItem
        '
        Me.CompanyDeToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.company_24
        Me.CompanyDeToolStripMenuItem.Name = "CompanyDeToolStripMenuItem"
        Me.CompanyDeToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CompanyDeToolStripMenuItem.Text = "&Company Detail Setup"
        Me.CompanyDeToolStripMenuItem.ToolTipText = "Set company details"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(222, 6)
        '
        'SystemSecurityToolStripMenuItem
        '
        Me.SystemSecurityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemUserPropertiesToolStripMenuItem, Me.UserGroupPropertiesToolStripMenuItem, Me.AboutUserToolStripMenuItem})
        Me.SystemSecurityToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.securitylock_24
        Me.SystemSecurityToolStripMenuItem.Name = "SystemSecurityToolStripMenuItem"
        Me.SystemSecurityToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SystemSecurityToolStripMenuItem.Text = "&System Security"
        '
        'SystemUserPropertiesToolStripMenuItem
        '
        Me.SystemUserPropertiesToolStripMenuItem.Name = "SystemUserPropertiesToolStripMenuItem"
        Me.SystemUserPropertiesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SystemUserPropertiesToolStripMenuItem.Text = "&System User Properties"
        Me.SystemUserPropertiesToolStripMenuItem.ToolTipText = "Set and change user details"
        '
        'UserGroupPropertiesToolStripMenuItem
        '
        Me.UserGroupPropertiesToolStripMenuItem.Name = "UserGroupPropertiesToolStripMenuItem"
        Me.UserGroupPropertiesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.UserGroupPropertiesToolStripMenuItem.Text = "&User Group Properties"
        Me.UserGroupPropertiesToolStripMenuItem.ToolTipText = "Set and change group details"
        '
        'AboutUserToolStripMenuItem
        '
        Me.AboutUserToolStripMenuItem.Name = "AboutUserToolStripMenuItem"
        Me.AboutUserToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AboutUserToolStripMenuItem.Text = "&About User"
        Me.AboutUserToolStripMenuItem.ToolTipText = "View your details "
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(222, 6)
        '
        'SystemLogoutToolStripMenuItem
        '
        Me.SystemLogoutToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.doorhanger_24
        Me.SystemLogoutToolStripMenuItem.Name = "SystemLogoutToolStripMenuItem"
        Me.SystemLogoutToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SystemLogoutToolStripMenuItem.Text = "&Application Logout"
        Me.SystemLogoutToolStripMenuItem.ToolTipText = "Logout application"
        '
        'SystemExitToolStripMenuItem
        '
        Me.SystemExitToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.opendoor_24
        Me.SystemExitToolStripMenuItem.Name = "SystemExitToolStripMenuItem"
        Me.SystemExitToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SystemExitToolStripMenuItem.Text = "&Application Exit"
        Me.SystemExitToolStripMenuItem.ToolTipText = "Exit application"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.PharmRetail.My.Resources.Resources.information_24
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'WwwToolStripMenuItem
        '
        Me.WwwToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.WwwToolStripMenuItem.Name = "WwwToolStripMenuItem"
        Me.WwwToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        Me.WwwToolStripMenuItem.Text = "www"
        Me.WwwToolStripMenuItem.Visible = False
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ToolStrip.Enabled = False
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton7, Me.ToolStripButton8})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(693, 31)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.PharmRetail.My.Resources.Resources.uploadtoftpB_24
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ToolStripButton3.Size = New System.Drawing.Size(109, 28)
        Me.ToolStripButton3.Text = "Upload File"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.ToolStripButton4.Size = New System.Drawing.Size(62, 28)
        Me.ToolStripButton4.Text = "POS"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = Global.PharmRetail.My.Resources.Resources.home_24
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.ToolStripButton7.Size = New System.Drawing.Size(63, 28)
        Me.ToolStripButton7.Text = "EOD"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.Image = Global.PharmRetail.My.Resources.Resources.databaseadministrator_24
        Me.ToolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.ToolStripButton8.Size = New System.Drawing.Size(153, 28)
        Me.ToolStripButton8.Text = "Database Connection"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(693, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'lbl_connect
        '
        Me.lbl_connect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_connect.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_connect.ForeColor = System.Drawing.Color.Black
        Me.lbl_connect.Location = New System.Drawing.Point(545, 433)
        Me.lbl_connect.Name = "lbl_connect"
        Me.lbl_connect.Size = New System.Drawing.Size(124, 17)
        Me.lbl_connect.TabIndex = 31
        Me.lbl_connect.Text = "Connected"
        Me.lbl_connect.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'login_status
        '
        Me.login_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.login_status.BackColor = System.Drawing.Color.WhiteSmoke
        Me.login_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.login_status.Location = New System.Drawing.Point(44, 436)
        Me.login_status.Name = "login_status"
        Me.login_status.Size = New System.Drawing.Size(251, 13)
        Me.login_status.TabIndex = 106
        '
        'TTHelp
        '
        Me.TTHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(146, Byte), Integer))
        '
        'MDIBackend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 453)
        Me.Controls.Add(Me.login_status)
        Me.Controls.Add(Me.lbl_connect)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIBackend"
        Me.Text = "MDIBackend"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents TasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EODToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseConnectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemSecurityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SystemLogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StocksReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StockMasterFileUploadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lbl_connect As System.Windows.Forms.Label
    Friend WithEvents GeneralDailySalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailySalesByPaymentReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WwwToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemUserPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserGroupPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents login_status As System.Windows.Forms.Label
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip

End Class
