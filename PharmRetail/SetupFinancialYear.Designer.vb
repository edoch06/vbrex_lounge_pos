<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupFinancialYear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupFinancialYear))
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.txt_finyear = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dt_ends = New System.Windows.Forms.DateTimePicker
        Me.dt_start = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.bkgnd_conn = New System.ComponentModel.BackgroundWorker
        Me.btn_connect = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.gbox_conn = New PharmRetail.CustomGroupBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbox_conn.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(492, 155)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_finyear)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dt_ends)
        Me.TabPage1.Controls.Add(Me.dt_start)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(484, 129)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add New Financial Year "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_finyear
        '
        Me.txt_finyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_finyear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_finyear.Location = New System.Drawing.Point(148, 21)
        Me.txt_finyear.Name = "txt_finyear"
        Me.txt_finyear.Size = New System.Drawing.Size(277, 22)
        Me.txt_finyear.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Title *"
        '
        'dt_ends
        '
        Me.dt_ends.CustomFormat = "dd MMM yyyy"
        Me.dt_ends.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_ends.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_ends.Location = New System.Drawing.Point(148, 78)
        Me.dt_ends.Name = "dt_ends"
        Me.dt_ends.Size = New System.Drawing.Size(152, 23)
        Me.dt_ends.TabIndex = 2
        '
        'dt_start
        '
        Me.dt_start.CustomFormat = "dd MMM yyyy"
        Me.dt_start.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_start.Location = New System.Drawing.Point(148, 49)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Size = New System.Drawing.Size(152, 23)
        Me.dt_start.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Year Ends At"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(24, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Year Starts At"
        '
        'bkgnd_conn
        '
        Me.bkgnd_conn.WorkerReportsProgress = True
        '
        'btn_connect
        '
        Me.btn_connect.ForeColor = System.Drawing.Color.Black
        Me.btn_connect.Image = Global.PharmRetail.My.Resources.Resources.save_16
        Me.btn_connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_connect.Location = New System.Drawing.Point(226, 11)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(124, 27)
        Me.btn_connect.TabIndex = 71
        Me.btn_connect.Text = "Save"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Image = Global.PharmRetail.My.Resources.Resources.close_16
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(356, 11)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(124, 27)
        Me.btn_close.TabIndex = 72
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'gbox_conn
        '
        Me.gbox_conn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbox_conn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gbox_conn.Controls.Add(Me.btn_close)
        Me.gbox_conn.Controls.Add(Me.btn_connect)
        Me.gbox_conn.Location = New System.Drawing.Point(0, 160)
        Me.gbox_conn.Name = "gbox_conn"
        Me.gbox_conn.Size = New System.Drawing.Size(492, 49)
        Me.gbox_conn.TabIndex = 8
        Me.gbox_conn.TabStop = False
        '
        'SetupFinancialYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(492, 212)
        Me.Controls.Add(Me.gbox_conn)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "SetupFinancialYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financial Year Setup "
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gbox_conn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bkgnd_conn As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_connect As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents gbox_conn As PharmRetail.CustomGroupBox
    Friend WithEvents dt_ends As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_start As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_finyear As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
