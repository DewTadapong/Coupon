Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Text
Imports FontAwesome.Sharp
Imports System.Windows

Public Class Inputdatacoupon
    Dim pathpic As String
    Dim cmd As SqlCommand
    Dim conn As New SqlConnection("Server=LAF-ITCENTER02\SQLEXPRESS;Database=Coupondb;User Id=sa;Password=1234;")
    ' Dim cmd As New SqlCommand

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
    Private Sub Inputdatacoupon_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'ขอบบน ชนเต็มจอปรับ BorderStyle'
    Private Sub Exitt_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub btnopenpic_Click(sender As Object, e As EventArgs) Handles btnopenpic.Click
        Dim dai As New OpenFileDialog
        dai.Filter = "JPG File|*.jpg|PNG File|*.png"
        If dai.ShowDialog = DialogResult.OK Then
            pathpic = dai.FileName
            'PictureBox1.ImageLocation = pathpic
        End If
    End Sub

    Private Sub Exitt_Click_1(sender As Object, e As EventArgs) Handles Exitt.Click
        Me.Close()
        satus = 0
        satus2 = 1


    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim cmd As New SqlCommand(query, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Add Data Success")
    End Sub

    Private Sub btndataadd_Click(sender As Object, e As EventArgs) Handles btndataadd.Click
        randomcode = GetRandomPass()
        Dim insert As String = "insert into inputdata values('" & txtnamecoupon.Text & "','" & datempg.Value & "','" & dateexp.Value & "','" & randomcode & "','" & txtnum.Text & "')"
        ExecuteQuery(insert)


        Dim strConnString, sql As String
        strConnString = "Server=LAF-ITCENTER02\SQLEXPRESS;Database=Coupondb;User Id=sa;Password=1234;"
        conn.ConnectionString = strConnString
        conn.Open()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = "select id as ลำดับ,namecoupon as ชื่อคูปอง,datempg as วันที่สร้าง,dateexp as วันหมดอายุ,code as รหัสโค้ด,totalnumber as จำนวนคูปอง from inputdata "
        Dim ad As New SqlDataAdapter(sql, conn)
        Dim tb As New DataTable
        ad.Fill(tb)
        DataGridView1.DataSource = tb
        conn.Close()
    End Sub
    Protected Function GetRandomPass() As String
        Dim pass As String = String.Empty
        Dim AllowedChars() As String = {"ABCDEFGHJKLMNPQRSTWXYZ", "abcdefghjklmnpqrstwxyz", "0123456789"}
        Dim rnd = New Random()
        While pass.Length < 10
            Dim rndSet As Integer = rnd.Next(0, AllowedChars.Length)
            pass &= AllowedChars(rndSet).Substring(rnd.Next(0, AllowedChars(rndSet).Length), 1)
        End While
        Return pass
    End Function

    Private Sub Inputdatacoupon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strConnString, sql As String
        strConnString = "Server=LAF-ITCENTER02\SQLEXPRESS;Database=Coupondb;User Id=sa;Password=1234;"
        conn.ConnectionString = strConnString
        conn.Open()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        sql = "select id as ลำดับ,namecoupon as ชื่อคูปอง,datempg as วันที่สร้าง,dateexp as วันหมดอายุ,code as รหัสโค้ด,totalnumber as จำนวนคูปอง from inputdata "
        Dim ad As New SqlDataAdapter(sql, conn)
        Dim tb As New DataTable
        ad.Fill(tb)
        DataGridView1.DataSource = tb
        conn.Close()

    End Sub



    '   Private Async Function Wait(ByVal ms As Integer) As Task
    '      Await Task.Delay(ms)
    '   End Function  ' delay time



End Class