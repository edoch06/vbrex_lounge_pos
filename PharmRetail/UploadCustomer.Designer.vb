<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UploadCustomer))
        Me.btn_upload = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.rbtn_delete = New System.Windows.Forms.RadioButton
        Me.rbtn_append = New System.Windows.Forms.RadioButton
        Me.btn_browse = New System.Windows.Forms.Button
        Me.lbl_posting = New System.Windows.Forms.Label
        Me.txt_postings = New System.Windows.Forms.TextBox
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btn_close = New System.Windows.Forms.Button
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.rbtn_pheaders = New System.Windows.Forms.RadioButton
        Me.rbtn_pnoheaders = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.OpenFileCSV = New System.Windows.Forms.OpenFileDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_upload
        '
        Me.btn_upload.Image = Global.PharmRetail.My.Resources.Resources.uploadftp_16
        Me.btn_upload.Location = New System.Drawing.Point(415, 235)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(122, 27)
        Me.btn_upload.TabIndex = 112
        Me.btn_upload.Text = "Upload"
        Me.btn_upload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_upload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_upload.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(147, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 427)
        Me.Panel2.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.rbtn_delete)
        Me.Panel10.Controls.Add(Me.rbtn_append)
        Me.Panel10.Location = New System.Drawing.Point(174, 164)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(281, 23)
        Me.Panel10.TabIndex = 106
        '
        'rbtn_delete
        '
        Me.rbtn_delete.AutoSize = True
        Me.rbtn_delete.Location = New System.Drawing.Point(3, 3)
        Me.rbtn_delete.Name = "rbtn_delete"
        Me.rbtn_delete.Size = New System.Drawing.Size(99, 17)
        Me.rbtn_delete.TabIndex = 331
        Me.rbtn_delete.Text = "Delete Records"
        Me.rbtn_delete.UseVisualStyleBackColor = True
        '
        'rbtn_append
        '
        Me.rbtn_append.AutoSize = True
        Me.rbtn_append.Checked = True
        Me.rbtn_append.Location = New System.Drawing.Point(130, 3)
        Me.rbtn_append.Name = "rbtn_append"
        Me.rbtn_append.Size = New System.Drawing.Size(105, 17)
        Me.rbtn_append.TabIndex = 332
        Me.rbtn_append.TabStop = True
        Me.rbtn_append.Text = "Append Records"
        Me.rbtn_append.UseVisualStyleBackColor = True
        '
        'btn_browse
        '
        Me.btn_browse.Image = Global.PharmRetail.My.Resources.Resources.openedfolder_16
        Me.btn_browse.Location = New System.Drawing.Point(287, 235)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(122, 27)
        Me.btn_browse.TabIndex = 111
        Me.btn_browse.Text = "Browse...."
        Me.btn_browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_browse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'lbl_posting
        '
        Me.lbl_posting.AutoSize = True
        Me.lbl_posting.BackColor = System.Drawing.Color.Transparent
        Me.lbl_posting.ForeColor = System.Drawing.Color.Black
        Me.lbl_posting.Location = New System.Drawing.Point(183, 269)
        Me.lbl_posting.Name = "lbl_posting"
        Me.lbl_posting.Size = New System.Drawing.Size(61, 13)
        Me.lbl_posting.TabIndex = 110
        Me.lbl_posting.Text = "Browse File"
        '
        'txt_postings
        '
        Me.txt_postings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_postings.Location = New System.Drawing.Point(186, 209)
        Me.txt_postings.Name = "txt_postings"
        Me.txt_postings.Size = New System.Drawing.Size(351, 20)
        Me.txt_postings.TabIndex = 109
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Panel11.Location = New System.Drawing.Point(175, 202)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(405, 1)
        Me.Panel11.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 15)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Select Record Change"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PharmRetail.My.Resources.Resources.linkdocument_96
        Me.PictureBox1.Location = New System.Drawing.Point(38, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(148, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(478, 70)
        Me.Panel5.TabIndex = 102
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(478, 1)
        Me.Panel3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 40)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Upload stock master file with .txt tab delimited format " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with the name customers" & _
            " + current date (yyyyMMdd)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 15)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Select Transaction (Postings) File"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.btn_close)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(148, 375)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(478, 52)
        Me.Panel4.TabIndex = 103
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(478, 1)
        Me.Panel6.TabIndex = 50
        '
        'btn_close
        '
        Me.btn_close.Image = Global.PharmRetail.My.Resources.Resources.close_16
        Me.btn_close.Location = New System.Drawing.Point(313, 13)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(122, 27)
        Me.btn_close.TabIndex = 49
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.rbtn_pheaders)
        Me.Panel9.Controls.Add(Me.rbtn_pnoheaders)
        Me.Panel9.Location = New System.Drawing.Point(175, 107)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(218, 23)
        Me.Panel9.TabIndex = 104
        '
        'rbtn_pheaders
        '
        Me.rbtn_pheaders.AutoSize = True
        Me.rbtn_pheaders.Checked = True
        Me.rbtn_pheaders.Location = New System.Drawing.Point(3, 3)
        Me.rbtn_pheaders.Name = "rbtn_pheaders"
        Me.rbtn_pheaders.Size = New System.Drawing.Size(121, 17)
        Me.rbtn_pheaders.TabIndex = 331
        Me.rbtn_pheaders.TabStop = True
        Me.rbtn_pheaders.Text = "The file has headers"
        Me.rbtn_pheaders.UseVisualStyleBackColor = True
        '
        'rbtn_pnoheaders
        '
        Me.rbtn_pnoheaders.AutoSize = True
        Me.rbtn_pnoheaders.Location = New System.Drawing.Point(130, 3)
        Me.rbtn_pnoheaders.Name = "rbtn_pnoheaders"
        Me.rbtn_pnoheaders.Size = New System.Drawing.Size(80, 17)
        Me.rbtn_pnoheaders.TabIndex = 332
        Me.rbtn_pnoheaders.Text = "No headers"
        Me.rbtn_pnoheaders.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 72)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Customers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Upload"
        '
        'OpenFileCSV
        '
        Me.OpenFileCSV.FileName = "sum"
        Me.OpenFileCSV.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)"
        Me.OpenFileCSV.Title = "Select Summary"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 427)
        Me.Panel1.TabIndex = 101
        '
        'UploadCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(626, 427)
        Me.Controls.Add(Me.btn_upload)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.lbl_posting)
        Me.Controls.Add(Me.txt_postings)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UploadCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload Customers File"
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_upload As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents rbtn_delete As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_append As System.Windows.Forms.RadioButton
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents lbl_posting As System.Windows.Forms.Label
    Friend WithEvents txt_postings As System.Windows.Forms.TextBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents rbtn_pheaders As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_pnoheaders As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileCSV As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
