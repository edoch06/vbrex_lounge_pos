Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports System.Media
Imports System.Windows.Forms
Public Class EditCustomer

    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const SC_MAXIMIZE As Integer = &HF030
    Private Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Private Const HTCAPTION As Integer = &H2
    Private widthint As Integer = 714
    Private heightint As Integer = 349
    Private init_widthint As Integer = 0
    Private init_heightint As Integer = 0
    '714, 349

    Private clsRetail As New ClassRetail
    Private max_Flag As Boolean = False



    Private Sub forminit_vals()



    End Sub


    Protected Overrides Sub WndProc(ByRef m As Message)


        If (m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32 = SC_MAXIMIZE) OrElse (m.Msg = WM_NCLBUTTONDBLCLK AndAlso m.WParam.ToInt32 = HTCAPTION) Then


            Me.Bounds = New Rectangle(75, 50, widthint, heightint)
            m.Result = CType(0, IntPtr)
            Return

        End If
        MyBase.WndProc(m)

    End Sub

    Private Sub EditCustomer_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        Me.Refresh()
    End Sub

    Private Sub EditCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class