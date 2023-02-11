Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Text
Imports FontAwesome.Sharp

Public Class Home
    Dim strUser As String
    Public Property _strUser() As String
        Get
            Return strUser
        End Get
        Set(ByVal value As String)
            strUser = value
        End Set
    End Property

    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        'ขอบบน ชนเต็มจอ'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub



    'เปิด - ปิด แทบข้าง '
    Private Sub Taball_SizeChanged(sender As Object, e As EventArgs) Handles Taball.SizeChanged
        If Taball.Width = 177 Then
            Tablistclose.Visible = True
            Tablist.Visible = False
        Else
            Tablistclose.Visible = False
            Tablist.Visible = True

        End If
    End Sub
    Private Sub Tablistclose_Click(sender As Object, e As EventArgs) Handles Tablistclose.Click
        If Taball.Width = 177 Then
            Taball.Width = 47
            dropdowngenarate.Visible = False
            piccoupondowm.Visible = True
            piccouponup.Visible = False
            If colordasborad.Location = New Point(1, 160) Or colordasborad.Location = New Point(1, 202) Then
                colordasborad.Location = New Point(1, 118)
            End If
        Else
            Taball.Width = 177
         End If
    End Sub
    Private Sub Tablist_Click(sender As Object, e As EventArgs) Handles Tablist.Click
        If Taball.Width = 177 Then
            Taball.Width = 47
            dropdowngenarate.Visible = False
            piccoupondowm.Visible = True
            piccouponup.Visible = False

        Else
            Taball.Width = 177
        End If
    End Sub
    'เปิด - ปิด แทบข้าง '

    'ขอบบน ชนเต็มจอปรับ BorderStyle'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Home_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub
    'ขอบบน ชนเต็มจอปรับ BorderStyle'

    'dropdown menucoupon'
    Private Sub Coupon_Click(sender As Object, e As EventArgs) Handles Coupon.Click
        If dropdowngenarate.Visible = False Then
            dropdowngenarate.Visible = True
            piccoupondowm.Visible = False
            piccouponup.Visible = True
        Else
            dropdowngenarate.Visible = False
            piccoupondowm.Visible = True
            piccouponup.Visible = False
        End If
        colordasborad.Location = New Point(1, 118)
        colordasborad.Visible = True
    End Sub
    'dropdown menucoupon'


    'เปลี่ยนสีหลังปุ่มให้เหมือนกับสีข้างหลังเวลาเลื่อนเมาส์เข้าออก'
    Private Sub Genarate_MouseMove(sender As Object, e As MouseEventArgs) Handles alldata.MouseMove
        picgenarate.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub Genarate_MouseLeave(sender As Object, e As EventArgs) Handles alldata.MouseLeave
        picgenarate.BackColor = Color.FromArgb(87, 101, 116)
    End Sub
    Private Sub Controlcoupon_MouseMove(sender As Object, e As MouseEventArgs) Handles genarate.MouseMove
        piccontrol.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub Controlcoupon_MouseLeave(sender As Object, e As EventArgs) Handles genarate.MouseLeave
        piccontrol.BackColor = Color.FromArgb(87, 101, 116)
    End Sub
    Private Sub Coupon_MouseMove(sender As Object, e As MouseEventArgs) Handles Coupon.MouseMove
        piccoupondowm.BackColor = Color.FromArgb(41, 128, 185)
        piccouponup.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub Coupon_MouseLeave(sender As Object, e As EventArgs) Handles Coupon.MouseLeave
        piccoupondowm.BackColor = Color.FromArgb(44, 58, 71)
        piccouponup.BackColor = Color.FromArgb(44, 58, 71)
    End Sub
    'เปลี่ยนสีหลังปุ่มให้เหมือนกับสีข้างหลังเวลาเลื่อนเมาส์เข้าออก'


    'show form another in panel center screen'
    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Formbase.Controls.Add(childForm)
        Formbase.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    'show form another in panel center screen'

    Private Sub Exitt_Click(sender As Object, e As EventArgs) Handles Exitt.Click
        Application.Exit()
    End Sub

    Private Sub Miniscr_Click(sender As Object, e As EventArgs) Handles Miniscr.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Maxscr_Click(sender As Object, e As EventArgs) Handles Maxscr.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
            Me.Width = (950)
            Me.Height = (600)
            Me.CenterToScreen()
        End If
    End Sub


    'ปุ่มใน tab ต่างๆ 
    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        openChildForm(New Dashboardform())
        colordasborad.Visible = True
        colordasborad.Location = New Point(1, 76)
    End Sub
    Private Sub alldata_Click(sender As Object, e As EventArgs) Handles alldata.Click
        openChildForm(New Genaratecoupon())
        colordasborad.Location = New Point(1, 160)
        colordasborad.Visible = True
    End Sub
    Private Sub genarate_Click(sender As Object, e As EventArgs) Handles genarate.Click
        openChildForm(New Inputdatacoupon())
        colordasborad.Location = New Point(1, 202)
        colordasborad.Visible = True
    End Sub
    Private Sub Historybtn_Click(sender As Object, e As EventArgs) Handles Historybtn.Click
        colordasborad.Visible = True
        If dropdowngenarate.Visible = True Then
            colordasborad.Location = New Point(1, 244)
        Else
            colordasborad.Location = New Point(1, 160)
        End If
    End Sub
    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        colordasborad.Visible = True
        If dropdowngenarate.Visible = True Then
            colordasborad.Location = New Point(1, 286)
        Else
            colordasborad.Location = New Point(1, 202)
        End If
    End Sub
    Private Sub Setting_Click(sender As Object, e As EventArgs) Handles Setting.Click
        colordasborad.Visible = True
        If dropdowngenarate.Visible = True Then
            colordasborad.Location = New Point(1, 328)
        Else
            colordasborad.Location = New Point(1, 244)
        End If
    End Sub
    Private Sub Logoutbig_Click(sender As Object, e As EventArgs) Handles Logoutbig.Click
        Login.Show()
        Me.Close()
    End Sub
    'ปุ่มใน tab ต่างๆ 

    Public Sub LoadInfor()

        Dim objConn As New SqlConnection
        Dim objCmd As New SqlCommand
        Dim dtAdapter As SqlDataAdapter
        Dim dt As New DataTable
        Dim strConnString, strSQL As String

        strConnString = "Server=LAF-ITCENTER02\SQLEXPRESS;Database=Coupondb;User Id=sa;Password=1234;"
        objConn.ConnectionString = strConnString
        objConn.Open()

        strSQL = "SELECT * FROM login WHERE email = '" & strUser & "' "

        dtAdapter = New SqlDataAdapter(strSQL, objConn)
        dtAdapter.Fill(dt)

        If dt.Rows.Count > 0 Then
            Me.lblnamelogin.Text = dt.Rows(0)("email")
            Me.lbldepartment.Text = dt.Rows(0)("deprtment")
        End If

        objConn.Close()
        objConn = Nothing

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.text = Now.ToShortDateString
        Label3.Text = TimeOfDay
        Label2.Text = satus2
        Timer1.Start()
        If satus2 = 1 Then
            openChildForm(New Genaratecoupon())
            satus2 = 0
        End If
        openChildForm(New Dashboardform())
        colordasborad.Visible = True
        colordasborad.Location = New Point(1, 76)
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        If satus = 1 Then
            openChildForm(New Inputdatacoupon())
            satus = 0
            colordasborad.Location = New Point(1, 202)
        End If
        If satus2 = 1 Then
            openChildForm(New Genaratecoupon())
            colordasborad.Location = New Point(1, 160)
            satus2 = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Label1.Text = TimeOfDay
        Label3.Text = TimeOfDay
        Label4.Text = Now.ToShortDateString
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub






    'function random code
    'Function RandomString(minCharacters As Integer, maxCharacters As Integer)
    'Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
    'Static r As New Random
    'im chactersInString As Integer = r.Next(minCharacters, maxCharacters)
    'Dim sb As New StringBuilder
    'For i As Integer = 1 To chactersInString
    'Dim idx As Integer = r.Next(0, s.Length)
    '       sb.Append(s.Substring(idx, 1))
    'Next
    ''Return sb.ToString()
    ' End Function

    '  Private Sub Button2_Click(sender As Object, e As EventArgs)
    ' Dim reslu As String
    '    reslu = RandomString(7, 8)
    '   Label1.Text = reslu
    '
    ' End Sub
End Class
