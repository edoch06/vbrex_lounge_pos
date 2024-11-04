<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PoSSale
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PoSSale))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_companyname = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbl_usergroup = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbl_storecode = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lbl_logintime = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_ordernosel = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txt_billno = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgv_details = New System.Windows.Forms.DataGridView
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgv_orders = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_searchorder = New System.Windows.Forms.TextBox
        Me.lbl_print = New System.Windows.Forms.Label
        Me.order_cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditQuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lbl_userfname = New System.Windows.Forms.Label
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_order = New System.Windows.Forms.Button
        Me.btn_void = New System.Windows.Forms.Button
        Me.btn_selectorder = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_bill = New System.Windows.Forms.Button
        Me.btn_billsettlment = New System.Windows.Forms.Button
        Me.CustomGroupBox3 = New PharmRetail.CustomGroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.CustomGroupBox1 = New PharmRetail.CustomGroupBox
        Me.lbl_total = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.order_cms.SuspendLayout()
        Me.CustomGroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.CustomGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(8, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 1)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(363, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "User :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(322, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Designation :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(321, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Department :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(358, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Store :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(338, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Terminal :"
        Me.Label7.Visible = False
        '
        'lbl_companyname
        '
        Me.lbl_companyname.AutoSize = True
        Me.lbl_companyname.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_companyname.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_companyname.Location = New System.Drawing.Point(98, 30)
        Me.lbl_companyname.Name = "lbl_companyname"
        Me.lbl_companyname.Size = New System.Drawing.Size(162, 27)
        Me.lbl_companyname.TabIndex = 14
        Me.lbl_companyname.Text = "Company Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(100, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Login Time   :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PharmRetail.My.Resources.Resources.cutlery_96
        Me.PictureBox1.Location = New System.Drawing.Point(12, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'lbl_usergroup
        '
        Me.lbl_usergroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_usergroup.AutoSize = True
        Me.lbl_usergroup.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usergroup.ForeColor = System.Drawing.Color.Black
        Me.lbl_usergroup.Location = New System.Drawing.Point(410, 30)
        Me.lbl_usergroup.Name = "lbl_usergroup"
        Me.lbl_usergroup.Size = New System.Drawing.Size(86, 18)
        Me.lbl_usergroup.TabIndex = 18
        Me.lbl_usergroup.Text = "Administrator"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(410, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 18)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Sale"
        '
        'lbl_storecode
        '
        Me.lbl_storecode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_storecode.AutoSize = True
        Me.lbl_storecode.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_storecode.ForeColor = System.Drawing.Color.Black
        Me.lbl_storecode.Location = New System.Drawing.Point(410, 66)
        Me.lbl_storecode.Name = "lbl_storecode"
        Me.lbl_storecode.Size = New System.Drawing.Size(57, 18)
        Me.lbl_storecode.TabIndex = 20
        Me.lbl_storecode.Text = "Junction"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(410, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 18)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "A"
        Me.Label14.Visible = False
        '
        'lbl_logintime
        '
        Me.lbl_logintime.AutoSize = True
        Me.lbl_logintime.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logintime.ForeColor = System.Drawing.Color.Black
        Me.lbl_logintime.Location = New System.Drawing.Point(96, 120)
        Me.lbl_logintime.Name = "lbl_logintime"
        Me.lbl_logintime.Size = New System.Drawing.Size(203, 18)
        Me.lbl_logintime.TabIndex = 22
        Me.lbl_logintime.Text = "Monday, November 12 1996 10:33"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(100, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 18)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Help Desk IT :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(188, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 18)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "TEL - 0725018807"
        '
        'txt_ordernosel
        '
        Me.txt_ordernosel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ordernosel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ordernosel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ordernosel.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ordernosel.Location = New System.Drawing.Point(133, 146)
        Me.txt_ordernosel.Name = "txt_ordernosel"
        Me.txt_ordernosel.ReadOnly = True
        Me.txt_ordernosel.Size = New System.Drawing.Size(855, 21)
        Me.txt_ordernosel.TabIndex = 85
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(12, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 18)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "Order ID #"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(7, 173)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(983, 1)
        Me.Panel2.TabIndex = 2
        '
        'txt_billno
        '
        Me.txt_billno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_billno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_billno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_billno.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_billno.Location = New System.Drawing.Point(776, 123)
        Me.txt_billno.Name = "txt_billno"
        Me.txt_billno.ReadOnly = True
        Me.txt_billno.Size = New System.Drawing.Size(212, 21)
        Me.txt_billno.TabIndex = 88
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(704, 126)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 18)
        Me.Label19.TabIndex = 89
        Me.Label19.Text = "Bill No #"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(7, 180)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 156)
        Me.SplitContainer1.SplitterDistance = 765
        Me.SplitContainer1.TabIndex = 90
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(765, 156)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dgv_details)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(757, 130)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customers Order Items"
        '
        'dgv_details
        '
        Me.dgv_details.AllowUserToAddRows = False
        Me.dgv_details.AllowUserToDeleteRows = False
        Me.dgv_details.AllowUserToResizeRows = False
        Me.dgv_details.BackgroundColor = System.Drawing.Color.White
        Me.dgv_details.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_details.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_details.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_details.EnableHeadersVisualStyles = False
        Me.dgv_details.GridColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgv_details.Location = New System.Drawing.Point(3, 3)
        Me.dgv_details.Name = "dgv_details"
        Me.dgv_details.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_details.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_details.RowHeadersVisible = False
        Me.dgv_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_details.Size = New System.Drawing.Size(751, 124)
        Me.dgv_details.TabIndex = 12
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(3, 39)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(212, 114)
        Me.TabControl2.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.dgv_orders)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(204, 88)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Customers Orders"
        '
        'dgv_orders
        '
        Me.dgv_orders.AllowUserToAddRows = False
        Me.dgv_orders.AllowUserToDeleteRows = False
        Me.dgv_orders.AllowUserToResizeRows = False
        Me.dgv_orders.BackgroundColor = System.Drawing.Color.White
        Me.dgv_orders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_orders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_orders.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_orders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_orders.EnableHeadersVisualStyles = False
        Me.dgv_orders.GridColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgv_orders.Location = New System.Drawing.Point(3, 3)
        Me.dgv_orders.Name = "dgv_orders"
        Me.dgv_orders.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_orders.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_orders.RowHeadersVisible = False
        Me.dgv_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_orders.Size = New System.Drawing.Size(198, 82)
        Me.dgv_orders.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.txt_searchorder)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(215, 37)
        Me.Panel3.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(3, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 18)
        Me.Label20.TabIndex = 90
        Me.Label20.Text = "Search Order #"
        '
        'txt_searchorder
        '
        Me.txt_searchorder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_searchorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_searchorder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_searchorder.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_searchorder.Location = New System.Drawing.Point(103, 8)
        Me.txt_searchorder.Name = "txt_searchorder"
        Me.txt_searchorder.Size = New System.Drawing.Size(109, 21)
        Me.txt_searchorder.TabIndex = 89
        '
        'lbl_print
        '
        Me.lbl_print.AutoSize = True
        Me.lbl_print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_print.Location = New System.Drawing.Point(410, 126)
        Me.lbl_print.Name = "lbl_print"
        Me.lbl_print.Size = New System.Drawing.Size(186, 13)
        Me.lbl_print.TabIndex = 209
        Me.lbl_print.Text = "Processing Payments ..... Please Wait"
        Me.lbl_print.Visible = False
        '
        'order_cms
        '
        Me.order_cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditQuantityToolStripMenuItem, Me.DeleteItemToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.order_cms.Name = "edit_cms"
        Me.order_cms.Size = New System.Drawing.Size(144, 70)
        '
        'EditQuantityToolStripMenuItem
        '
        Me.EditQuantityToolStripMenuItem.Name = "EditQuantityToolStripMenuItem"
        Me.EditQuantityToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EditQuantityToolStripMenuItem.Text = "&Edit Quantity"
        '
        'DeleteItemToolStripMenuItem
        '
        Me.DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        Me.DeleteItemToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.DeleteItemToolStripMenuItem.Text = "&Delete Item"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'lbl_userfname
        '
        Me.lbl_userfname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_userfname.AutoSize = True
        Me.lbl_userfname.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_userfname.ForeColor = System.Drawing.Color.Black
        Me.lbl_userfname.Location = New System.Drawing.Point(429, 6)
        Me.lbl_userfname.Name = "lbl_userfname"
        Me.lbl_userfname.Size = New System.Drawing.Size(94, 18)
        Me.lbl_userfname.TabIndex = 17
        Me.lbl_userfname.Text = "Zacharia Obade"
        '
        'btn_order
        '
        Me.btn_order.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_order.ForeColor = System.Drawing.Color.Black
        Me.btn_order.Image = Global.PharmRetail.My.Resources.Resources.shoppingcart_16
        Me.btn_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_order.Location = New System.Drawing.Point(3, 3)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(164, 23)
        Me.btn_order.TabIndex = 26
        Me.btn_order.Text = "New Order - F1"
        Me.TTHelp.SetToolTip(Me.btn_order, "Click to make new order or use F1 button")
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'btn_void
        '
        Me.btn_void.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_void.ForeColor = System.Drawing.Color.Black
        Me.btn_void.Image = Global.PharmRetail.My.Resources.Resources.deleteticket_16
        Me.btn_void.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_void.Location = New System.Drawing.Point(343, 3)
        Me.btn_void.Name = "btn_void"
        Me.btn_void.Size = New System.Drawing.Size(164, 23)
        Me.btn_void.TabIndex = 25
        Me.btn_void.Text = "Void Item - F3"
        Me.TTHelp.SetToolTip(Me.btn_void, "Click to void item or use F3 button")
        Me.btn_void.UseVisualStyleBackColor = True
        '
        'btn_selectorder
        '
        Me.btn_selectorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_selectorder.ForeColor = System.Drawing.Color.Black
        Me.btn_selectorder.Image = Global.PharmRetail.My.Resources.Resources.invoice_16
        Me.btn_selectorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_selectorder.Location = New System.Drawing.Point(173, 3)
        Me.btn_selectorder.Name = "btn_selectorder"
        Me.btn_selectorder.Size = New System.Drawing.Size(164, 23)
        Me.btn_selectorder.TabIndex = 90
        Me.btn_selectorder.Text = "Select Order - F2"
        Me.TTHelp.SetToolTip(Me.btn_selectorder, "Click to select orders from right pane or use F2 button")
        Me.btn_selectorder.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Image = Global.PharmRetail.My.Resources.Resources.unavailable_16
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(513, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(164, 23)
        Me.btn_cancel.TabIndex = 23
        Me.btn_cancel.Text = "Cancel Order - F4"
        Me.TTHelp.SetToolTip(Me.btn_cancel, "Click to cancel order or use F4 button")
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_bill
        '
        Me.btn_bill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_bill.ForeColor = System.Drawing.Color.Black
        Me.btn_bill.Image = Global.PharmRetail.My.Resources.Resources.receipt_16
        Me.btn_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bill.Location = New System.Drawing.Point(3, 32)
        Me.btn_bill.Name = "btn_bill"
        Me.btn_bill.Size = New System.Drawing.Size(164, 23)
        Me.btn_bill.TabIndex = 89
        Me.btn_bill.Text = "Invoice Bill - F5"
        Me.TTHelp.SetToolTip(Me.btn_bill, "Click to invoice bill or use F5 button")
        Me.btn_bill.UseVisualStyleBackColor = True
        '
        'btn_billsettlment
        '
        Me.btn_billsettlment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_billsettlment.ForeColor = System.Drawing.Color.Black
        Me.btn_billsettlment.Image = Global.PharmRetail.My.Resources.Resources.doorhanger_16
        Me.btn_billsettlment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_billsettlment.Location = New System.Drawing.Point(173, 32)
        Me.btn_billsettlment.Name = "btn_billsettlment"
        Me.btn_billsettlment.Size = New System.Drawing.Size(164, 23)
        Me.btn_billsettlment.TabIndex = 27
        Me.btn_billsettlment.Text = "Bill Settlement - F6"
        Me.TTHelp.SetToolTip(Me.btn_billsettlment, "Click to settle bill or use F6 button")
        Me.btn_billsettlment.UseVisualStyleBackColor = True
        '
        'CustomGroupBox3
        '
        Me.CustomGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustomGroupBox3.Controls.Add(Me.TableLayoutPanel1)
        Me.CustomGroupBox3.Location = New System.Drawing.Point(8, 342)
        Me.CustomGroupBox3.Name = "CustomGroupBox3"
        Me.CustomGroupBox3.Size = New System.Drawing.Size(986, 70)
        Me.CustomGroupBox3.TabIndex = 87
        Me.CustomGroupBox3.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_order, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_void, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_selectorder, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cancel, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_bill, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_billsettlment, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(915, 58)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CustomGroupBox1.Controls.Add(Me.lbl_total)
        Me.CustomGroupBox1.Controls.Add(Me.Label1)
        Me.CustomGroupBox1.Location = New System.Drawing.Point(707, 6)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(287, 100)
        Me.CustomGroupBox1.TabIndex = 0
        Me.CustomGroupBox1.TabStop = False
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.Font = New System.Drawing.Font("Tw Cen MT Condensed", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_total.Location = New System.Drawing.Point(23, 30)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(241, 59)
        Me.lbl_total.TabIndex = 9
        Me.lbl_total.Text = "0.00"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(118, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pay"
        '
        'PoSSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 420)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lbl_print)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_billno)
        Me.Controls.Add(Me.CustomGroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_ordernosel)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbl_storecode)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_usergroup)
        Me.Controls.Add(Me.lbl_logintime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_userfname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_companyname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "PoSSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS - Sale"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.order_cms.ResumeLayout(False)
        Me.CustomGroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.CustomGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomGroupBox1 As PharmRetail.CustomGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_companyname As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_usergroup As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_storecode As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_logintime As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_ordernosel As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CustomGroupBox3 As PharmRetail.CustomGroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_billsettlment As System.Windows.Forms.Button
    Friend WithEvents btn_order As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_void As System.Windows.Forms.Button
    Friend WithEvents dgv_details As System.Windows.Forms.DataGridView
    Friend WithEvents btn_bill As System.Windows.Forms.Button
    Friend WithEvents txt_billno As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_searchorder As System.Windows.Forms.TextBox
    Friend WithEvents btn_selectorder As System.Windows.Forms.Button
    Friend WithEvents lbl_print As System.Windows.Forms.Label
    Friend WithEvents order_cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditQuantityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_orders As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_userfname As System.Windows.Forms.Label
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
End Class
