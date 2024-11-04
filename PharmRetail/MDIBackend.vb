Imports System.Windows.Forms

Public Class MDIBackend
    Private heightint As Integer = 0
    Private widthint As Integer = 0
    Private clsRetail As New ClassRetail


    Private Sub initform_vals()


        heightint = Screen.PrimaryScreen.WorkingArea.Height - 255
        widthint = Screen.PrimaryScreen.WorkingArea.Width - 200


        Me.MinimumSize = New System.Drawing.Size(widthint, heightint) 'MINIMIZE


        Me.Text = msgbox_header


        'Check Connection
        Call clsRetail.readDBFile()


        If (clsRetail.checkConn()) Then


            Me.lbl_connect.Text = "Connected"
            'Call clsRetail.generate_AdminPassword()


            With PoSSplashScreen

                If Application.OpenForms().OfType(Of PoSSplashScreen).Any Then

                    .SendToBack()
                Else
                    .MdiParent = Me
                    .Show()
                    .SendToBack()
                End If

            End With


            PoSLogin.Show()



        Else



            ConnectionDatabase.ShowDialog()

        End If
       

    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        End
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub DatabaseConnectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseConnectionsToolStripMenuItem.Click


        If (clsRetail.check_ModuleAccess("8", user_groupII)) Then

            '##
            ConnectionDatabase.ShowDialog()
            '##
            user_groupII = user_group
        Else

            ModuleAccess.ShowDialog()

        End If
    End Sub

    Private Sub CompanyDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyDeToolStripMenuItem.Click


        If (clsRetail.check_ModuleAccess("9", user_groupII)) Then

            '##
            SetUpStoreDetails.ShowDialog()
            '##
            user_groupII = user_group
        Else

            ModuleAccess.ShowDialog()

        End If
    End Sub

    Private Sub POSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POSToolStripMenuItem.Click

        If (clsRetail.check_SalesDate()) Then

            If (clsRetail.check_ModuleAccess("2", user_groupII)) Then

                '##
                With PoSSale


                    If Application.OpenForms().OfType(Of PoSSale).Any Then

                        .BringToFront()
                    Else

                        .Show()

                    End If

                End With
                '##
                user_groupII = user_group
            Else

                ModuleAccess.ShowDialog()

            End If

        Else

            MsgBox("The sales date is not valid set a sales date to current date to proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, msgbox_header)


        End If


       


    End Sub



    Private Sub MDIBackend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initform_vals()
    End Sub

    Private Sub StockMasterFileUploadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockMasterFileUploadToolStripMenuItem.Click

        If (clsRetail.check_ModuleAccess("1", user_groupII)) Then

            '##
            UploadStockMaster.ShowDialog()
            '##
            user_groupII = user_group
        Else

            ModuleAccess.ShowDialog()

        End If

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        StockMasterFileUploadToolStripMenuItem.PerformClick()
    End Sub

    Private Sub MobileMasterDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        With MasterMobileMoney

            If Application.OpenForms().OfType(Of MasterMobileMoney).Any Then

                .BringToFront()
            Else
                .MdiParent = Me
                .BringToFront()
                .Show()

            End If

        End With

    End Sub

    Private Sub GeneralSalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Application.OpenForms().OfType(Of FilterRSaleSummary).Any Then

        '    FilterRSaleSummary.Show()
        'Else
        '    FilterRSaleSummary.Show()

        'End If


    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportToolStripMenuItem.Click
      


        If (clsRetail.check_ModuleAccess("4", user_groupII)) Then

            '##
            If Application.OpenForms().OfType(Of FilterRSaleSummary).Any Then

                FilterRSaleSummary.Show()
                FilterRSaleSummary.BringToFront()
            Else
                FilterRSaleSummary.Show()

            End If
            '##
            user_groupII = user_group
        Else

            ModuleAccess.ShowDialog()

        End If
    End Sub

    Private Sub GeneralDailySalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralDailySalesReportToolStripMenuItem.Click
       

        If (clsRetail.check_ModuleAccess("5", user_groupII)) Then

            '##
            If Application.OpenForms().OfType(Of FilterRSaleItem).Any Then

                FilterRSaleItem.Show()
                FilterRSaleItem.BringToFront()
            Else
                FilterRSaleItem.Show()

            End If
            '##
            user_groupII = user_group
        Else

            ModuleAccess.ShowDialog()

        End If
    End Sub

    Private Sub DailySalesByPaymentReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailySalesByPaymentReportToolStripMenuItem.Click
     

        If (clsRetail.check_ModuleAccess("6", user_groupII)) Then

            '##
            If Application.OpenForms().OfType(Of FilterRSalePayment).Any Then

                FilterRSalePayment.Show()
                FilterRSalePayment.BringToFront()
            Else
                FilterRSalePayment.Show()

            End If
            '##
            user_groupII = user_group
        Else

            ModuleAccess.ShowDialog()

        End If
    End Sub

    Private Sub StocksReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StocksReportToolStripMenuItem.Click
     

        If (clsRetail.check_ModuleAccess("7", user_groupII)) Then

            '##
            If Application.OpenForms().OfType(Of FilterRStock).Any Then

                FilterRStock.Show()
                FilterRStock.BringToFront()
            Else
                FilterRStock.Show()

            End If
            '##
            user_groupII = user_group
        Else

            ModuleAccess.ShowDialog()

        End If
    End Sub

    Private Sub SystemUserPropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemUserPropertiesToolStripMenuItem.Click

        'MsgBox(user_groupName)

        If (user_groupName.ToLower = "su") Then

            With MasterSysUsers


                If Application.OpenForms().OfType(Of MasterSysUsers).Any Then

                    .BringToFront()
                Else
                    .MdiParent = Me
                    .BringToFront()
                    .Show()

                End If

            End With

        Else


            If (clsRetail.check_ModuleAccess("10", user_groupII)) Then

                '##
                With MasterSysUsers


                    If Application.OpenForms().OfType(Of MasterSysUsers).Any Then

                        .BringToFront()
                    Else
                        .MdiParent = Me
                        .BringToFront()
                        .Show()

                    End If

                End With
                '##
                user_groupII = user_group
            Else

                ModuleAccess.ShowDialog()

            End If
        End If
        
    End Sub

    Private Sub AboutUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUserToolStripMenuItem.Click
        If (loggedIn = "") Then

            'MsgBox("Logged in first", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, msgbox_header)

        Else



            'Call clsRetail.get_AboutUserDetails(user_name)

            With AboutSysUser
                If Application.OpenForms().OfType(Of AboutSysUser).Any Then

                    .BringToFront()
                Else
                    Me.Cursor = Cursors.AppStarting
                    .MdiParent = Me
                    .BringToFront()
                    'StockMaster.Dock = DockStyle.Fill
                    .Show()
                    Me.Cursor = Cursors.Default
                End If
            End With
            

        End If
    End Sub

    Private Sub EODToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EODToolStripMenuItem.Click

        If (clsRetail.check_ModuleAccess("3", user_groupII)) Then

            '##
            EndOfDay.ShowDialog()
            '##
            user_groupII = user_group
        Else

            ModuleAccess.ShowDialog()

        End If


    End Sub

    Private Sub UserGroupPropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserGroupPropertiesToolStripMenuItem.Click

        If (user_groupName.ToLower = "su") Then

            MasterUserGroup.ShowDialog()

        Else

            If (clsRetail.check_ModuleAccess("11", user_groupII)) Then

                '##
                MasterUserGroup.ShowDialog()
                '##
                user_groupII = user_group
            Else

                ModuleAccess.ShowDialog()

            End If


        End If


    End Sub

    Private Sub SystemLogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemLogoutToolStripMenuItem.Click
        PoSSplashScreen.btn_login.PerformClick()
    End Sub

    Private Sub SystemExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemExitToolStripMenuItem.Click
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        POSToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        EODToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        DatabaseConnectionsToolStripMenuItem.PerformClick()
    End Sub
End Class
