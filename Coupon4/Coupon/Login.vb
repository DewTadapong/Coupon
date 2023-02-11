Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Data

Public Class Login

    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        'ขอบบน ชนเต็มจอ'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub

    'ขอบบน ชนเต็มจอปรับ BorderStyle'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'ขอบบน ชนเต็มจอปรับ BorderStyle'



    Private Sub Exitt_Click(sender As Object, e As EventArgs) Handles Exitt.Click
        Application.Exit()
    End Sub
    Private Sub Maxscr_Click(sender As Object, e As EventArgs) Handles Maxscr.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Miniscr_Click(sender As Object, e As EventArgs) Handles Miniscr.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Enterlogin_Click(sender As Object, e As EventArgs) Handles Enterlogin.Click

        Dim objConn As New SqlConnection
        Dim objCmd As New SqlCommand
        Dim strConnString, strSQL As String

        strConnString = "Server=LAF-ITCENTER02\SQLEXPRESS;Database=Coupondb;User Id=sa;Password=1234;"

        objConn.ConnectionString = strConnString
        objConn.Open()

        Dim intNumRows As Integer
        strSQL = "SELECT COUNT(*) FROM login WHERE email = '" & Me.txtUser.Text & "' AND password = '" & Me.txtPassword.Text & "' "
        objCmd = New SqlCommand(strSQL, objConn)
        intNumRows = objCmd.ExecuteScalar()

        If intNumRows > 0 Then
            Dim frm As New Home
            frm._strUser = Me.txtUser.Text
            frm.LoadInfor()
            frm.Show()
            Me.txtUser.Text = ""
            Me.txtPassword.Text = ""
            Me.Hide()
        Else
            MessageBox.Show("Username or Password Incorrect")
        End If

        objConn.Close()
        objConn = Nothing

    End Sub

End Class