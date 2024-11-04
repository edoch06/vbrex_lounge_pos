<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PoSOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PoSOrders))
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgv_details = New System.Windows.Forms.DataGridView
        Me.edit_cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditQuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbtn_edit = New System.Windows.Forms.ToolStripButton
        Me.tsb_delete = New System.Windows.Forms.ToolStripButton
        Me.tsbtn_refresh = New System.Windows.Forms.ToolStripButton
        Me.tsb_cancel = New System.Windows.Forms.ToolStripButton
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_lookup = New System.Windows.Forms.Button
        Me.btn_enter = New System.Windows.Forms.Button
        Me.btn_order = New System.Windows.Forms.Button
        Me.CustomGroupBox3 = New PharmRetail.CustomGroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_refno = New System.Windows.Forms.TextBox
        Me.CustomGroupBox1 = New PharmRetail.CustomGroupBox
        Me.CustomGroupBox2 = New PharmRetail.CustomGroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_qnty = New System.Windows.Forms.TextBox
        Me.txt_sku = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.edit_cms.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.CustomGroupBox3.SuspendLayout()
        Me.CustomGroupBox1.SuspendLayout()
        Me.CustomGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(5, 172)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(896, 210)
        Me.TabControl2.TabIndex = 10
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.dgv_details)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(888, 184)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Order List"
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
        Me.dgv_details.ContextMenuStrip = Me.edit_cms
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_details.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_details.EnableHeadersVisualStyles = False
        Me.dgv_details.GridColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgv_details.Location = New System.Drawing.Point(3, 29)
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
        Me.dgv_details.Size = New System.Drawing.Size(882, 152)
        Me.dgv_details.TabIndex = 11
        '
        'edit_cms
        '
        Me.edit_cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditQuantityToolStripMenuItem, Me.DeleteItemToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.edit_cms.Name = "edit_cms"
        Me.edit_cms.Size = New System.Drawing.Size(144, 70)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 1)
        Me.Panel1.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtn_edit, Me.tsb_delete, Me.tsbtn_refresh, Me.tsb_cancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(882, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtn_edit
        '
        Me.tsbtn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtn_edit.Image = Global.PharmRetail.My.Resources.Resources.edit_24
        Me.tsbtn_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtn_edit.Name = "tsbtn_edit"
        Me.tsbtn_edit.Size = New System.Drawing.Size(23, 22)
        Me.tsbtn_edit.Text = "Edit Class"
        Me.tsbtn_edit.ToolTipText = "Edit Quantity"
        '
        'tsb_delete
        '
        Me.tsb_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_delete.Image = Global.PharmRetail.My.Resources.Resources.delete_24
        Me.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_delete.Name = "tsb_delete"
        Me.tsb_delete.Size = New System.Drawing.Size(23, 22)
        Me.tsb_delete.Text = "Delete Class"
        Me.tsb_delete.ToolTipText = "Delete Item"
        '
        'tsbtn_refresh
        '
        Me.tsbtn_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtn_refresh.Image = Global.PharmRetail.My.Resources.Resources.refresh_24
        Me.tsbtn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtn_refresh.Name = "tsbtn_refresh"
        Me.tsbtn_refresh.Size = New System.Drawing.Size(23, 22)
        Me.tsbtn_refresh.Text = "Refresh"
        '
        'tsb_cancel
        '
        Me.tsb_cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_cancel.Image = Global.PharmRetail.My.Resources.Resources.unavailable_24
        Me.tsb_cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_cancel.Name = "tsb_cancel"
        Me.tsb_cancel.Size = New System.Drawing.Size(23, 22)
        Me.tsb_cancel.Text = "Cancel Order"
        '
        'btn_lookup
        '
        Me.btn_lookup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_lookup.Image = Global.PharmRetail.My.Resources.Resources.search_16
        Me.btn_lookup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_lookup.Location = New System.Drawing.Point(399, 6)
        Me.btn_lookup.Name = "btn_lookup"
        Me.btn_lookup.Size = New System.Drawing.Size(134, 27)
        Me.btn_lookup.TabIndex = 53
        Me.btn_lookup.Text = "LookUp - F1"
        Me.TTHelp.SetToolTip(Me.btn_lookup, "Click to lookup or use F1 button")
        Me.btn_lookup.UseVisualStyleBackColor = True
        '
        'btn_enter
        '
        Me.btn_enter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_enter.Image = Global.PharmRetail.My.Resources.Resources.save_16
        Me.btn_enter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enter.Location = New System.Drawing.Point(539, 6)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(134, 27)
        Me.btn_enter.TabIndex = 52
        Me.btn_enter.Text = "Save - Enter"
        Me.TTHelp.SetToolTip(Me.btn_enter, "Click to save or use enter button")
        Me.btn_enter.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_order.Image = Global.PharmRetail.My.Resources.Resources.spa_16
        Me.btn_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_order.Location = New System.Drawing.Point(679, 6)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(208, 27)
        Me.btn_order.TabIndex = 51
        Me.btn_order.Text = "Print Kitchen Order  Slip - F12"
        Me.TTHelp.SetToolTip(Me.btn_order, "Click to print kitchen order or use F12 button")
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'CustomGroupBox3
        '
        Me.CustomGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomGroupBox3.BorderColor = System.Drawing.Color.Gray
        Me.CustomGroupBox3.Controls.Add(Me.Label2)
        Me.CustomGroupBox3.Controls.Add(Me.txt_refno)
        Me.CustomGroupBox3.Location = New System.Drawing.Point(5, 7)
        Me.CustomGroupBox3.Name = "CustomGroupBox3"
        Me.CustomGroupBox3.Size = New System.Drawing.Size(896, 39)
        Me.CustomGroupBox3.TabIndex = 12
        Me.CustomGroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(541, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Order No#"
        '
        'txt_refno
        '
        Me.txt_refno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_refno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_refno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_refno.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_refno.Location = New System.Drawing.Point(614, 10)
        Me.txt_refno.Name = "txt_refno"
        Me.txt_refno.ReadOnly = True
        Me.txt_refno.Size = New System.Drawing.Size(273, 23)
        Me.txt_refno.TabIndex = 93
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomGroupBox1.BorderColor = System.Drawing.Color.Gray
        Me.CustomGroupBox1.Controls.Add(Me.btn_lookup)
        Me.CustomGroupBox1.Controls.Add(Me.btn_enter)
        Me.CustomGroupBox1.Controls.Add(Me.btn_order)
        Me.CustomGroupBox1.Location = New System.Drawing.Point(5, 52)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(896, 39)
        Me.CustomGroupBox1.TabIndex = 11
        Me.CustomGroupBox1.TabStop = False
        '
        'CustomGroupBox2
        '
        Me.CustomGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomGroupBox2.BorderColor = System.Drawing.Color.Gray
        Me.CustomGroupBox2.Controls.Add(Me.Label5)
        Me.CustomGroupBox2.Controls.Add(Me.txt_qnty)
        Me.CustomGroupBox2.Controls.Add(Me.txt_sku)
        Me.CustomGroupBox2.Controls.Add(Me.Label1)
        Me.CustomGroupBox2.Location = New System.Drawing.Point(5, 97)
        Me.CustomGroupBox2.Name = "CustomGroupBox2"
        Me.CustomGroupBox2.Size = New System.Drawing.Size(896, 69)
        Me.CustomGroupBox2.TabIndex = 1
        Me.CustomGroupBox2.TabStop = False
        Me.CustomGroupBox2.Text = "Order Details  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(383, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Quantity"
        '
        'txt_qnty
        '
        Me.txt_qnty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qnty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_qnty.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qnty.Location = New System.Drawing.Point(386, 38)
        Me.txt_qnty.Name = "txt_qnty"
        Me.txt_qnty.Size = New System.Drawing.Size(103, 23)
        Me.txt_qnty.TabIndex = 93
        '
        'txt_sku
        '
        Me.txt_sku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sku.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sku.Location = New System.Drawing.Point(7, 38)
        Me.txt_sku.Name = "txt_sku"
        Me.txt_sku.Size = New System.Drawing.Size(373, 23)
        Me.txt_sku.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 18)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "SKU"
        '
        'PoSOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 397)
        Me.Controls.Add(Me.CustomGroupBox3)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.CustomGroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "PoSOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS - Edit Customers Order"
        Me.TopMost = True
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.edit_cms.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.CustomGroupBox3.ResumeLayout(False)
        Me.CustomGroupBox3.PerformLayout()
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.CustomGroupBox2.ResumeLayout(False)
        Me.CustomGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomGroupBox2 As PharmRetail.CustomGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_qnty As System.Windows.Forms.TextBox
    Friend WithEvents txt_sku As System.Windows.Forms.TextBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_details As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtn_edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsb_delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtn_refresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomGroupBox1 As PharmRetail.CustomGroupBox
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_lookup As System.Windows.Forms.Button
    Friend WithEvents CustomGroupBox3 As PharmRetail.CustomGroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_refno As System.Windows.Forms.TextBox
    Friend WithEvents edit_cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditQuantityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
    Friend WithEvents tsb_cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_order As System.Windows.Forms.Button
End Class
