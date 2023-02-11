Imports System.Data.SqlClient
Public Class Genaratecoupon
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection


    Private Sub Genaratecoupon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strConnString, sql As String
        strConnString = "Server=LAF-ITCENTER02\SQLEXPRESS;Database=Coupondb;User Id=sa;Password=1234;"
        con.ConnectionString = strConnString
        con.Open()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "select id as ลำดับ,namecoupon as ชื่อคูปอง,datempg as วันที่สร้าง,dateexp as วันหมดอายุ,code as รหัสโค้ด,totalnumber as จำนวนคูปอง from inputdata "
        Dim ad As New SqlDataAdapter(sql, con)
            Dim tb As New DataTable
            ad.Fill(tb)
        datagridvalueall.DataSource = tb
        con.Close()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Close()
        satus = 1
    End Sub
End Class