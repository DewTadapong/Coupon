<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inputdatacoupon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inputdatacoupon))
        Me.txtnamecoupon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dateexp = New System.Windows.Forms.DateTimePicker()
        Me.btndataadd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtabout1 = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnopenpic = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.InputdataTableAdapter = New Coupon.CouponinputdataTableAdapters.inputdataTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Exitt = New System.Windows.Forms.Button()
        Me.datempg = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btnupdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnamecoupon
        '
        Me.txtnamecoupon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnamecoupon.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtnamecoupon.Location = New System.Drawing.Point(136, 76)
        Me.txtnamecoupon.Name = "txtnamecoupon"
        Me.txtnamecoupon.Size = New System.Drawing.Size(199, 29)
        Me.txtnamecoupon.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(44, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ชื่อคูปอง"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(44, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 29)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "วันหมดอายุ"
        '
        'dateexp
        '
        Me.dateexp.Location = New System.Drawing.Point(136, 136)
        Me.dateexp.Name = "dateexp"
        Me.dateexp.Size = New System.Drawing.Size(148, 20)
        Me.dateexp.TabIndex = 23
        '
        'btndataadd
        '
        Me.btndataadd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndataadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.btndataadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndataadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btndataadd.Location = New System.Drawing.Point(624, 240)
        Me.btndataadd.Name = "btndataadd"
        Me.btndataadd.Size = New System.Drawing.Size(73, 36)
        Me.btndataadd.TabIndex = 27
        Me.btndataadd.Text = "Add"
        Me.btndataadd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(46, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 29)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "จำนวน"
        '
        'txtnum
        '
        Me.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnum.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtnum.Location = New System.Drawing.Point(136, 184)
        Me.txtnum.MaxLength = 1000
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(68, 29)
        Me.txtnum.TabIndex = 28
        Me.txtnum.Text = "1"
        Me.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(522, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 29)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "คำอธิบายคูปองที่ 1"
        '
        'txtabout1
        '
        Me.txtabout1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtabout1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtabout1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtabout1.Location = New System.Drawing.Point(426, 91)
        Me.txtabout1.Multiline = True
        Me.txtabout1.Name = "txtabout1"
        Me.txtabout1.Size = New System.Drawing.Size(269, 122)
        Me.txtabout1.TabIndex = 31
        '
        'btncancel
        '
        Me.btncancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btncancel.Location = New System.Drawing.Point(464, 240)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 36)
        Me.btncancel.TabIndex = 35
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label7.Location = New System.Drawing.Point(48, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Open file picture backgroung coupon"
        '
        'btnopenpic
        '
        Me.btnopenpic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnopenpic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnopenpic.Location = New System.Drawing.Point(49, 247)
        Me.btnopenpic.Name = "btnopenpic"
        Me.btnopenpic.Size = New System.Drawing.Size(72, 24)
        Me.btnopenpic.TabIndex = 37
        Me.btnopenpic.Text = "Open file"
        Me.btnopenpic.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnopenpic.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(127, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "*.jpg /.png"
        '
        'InputdataTableAdapter
        '
        Me.InputdataTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 37)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "สร้างคูปองกรุณากรอกข้อมูลให้ครบถ้วน"
        '
        'Exitt
        '
        Me.Exitt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Exitt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Exitt.BackgroundImage = CType(resources.GetObject("Exitt.BackgroundImage"), System.Drawing.Image)
        Me.Exitt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Exitt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exitt.FlatAppearance.BorderSize = 0
        Me.Exitt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Exitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exitt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Exitt.Location = New System.Drawing.Point(675, 17)
        Me.Exitt.Name = "Exitt"
        Me.Exitt.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Exitt.Size = New System.Drawing.Size(20, 25)
        Me.Exitt.TabIndex = 40
        Me.Exitt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Exitt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Exitt.UseVisualStyleBackColor = False
        '
        'datempg
        '
        Me.datempg.Location = New System.Drawing.Point(490, 17)
        Me.datempg.Name = "datempg"
        Me.datempg.Size = New System.Drawing.Size(148, 20)
        Me.datempg.TabIndex = 42
        Me.datempg.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(49, 288)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(646, 167)
        Me.DataGridView1.TabIndex = 43
        '
        'Btnupdate
        '
        Me.Btnupdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.Btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btnupdate.Location = New System.Drawing.Point(543, 240)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(73, 36)
        Me.Btnupdate.TabIndex = 44
        Me.Btnupdate.Text = "Update"
        Me.Btnupdate.UseVisualStyleBackColor = True
        '
        'Inputdatacoupon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 480)
        Me.Controls.Add(Me.Btnupdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.datempg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Exitt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnopenpic)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtabout1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.btndataadd)
        Me.Controls.Add(Me.dateexp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnamecoupon)
        Me.Name = "Inputdatacoupon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inputdatacoupon"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnamecoupon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dateexp As DateTimePicker
    Friend WithEvents btndataadd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents txtabout1 As TextBox
    Friend WithEvents btncancel As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label7 As Label
    Friend WithEvents btnopenpic As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents InputdataTableAdapter As CouponinputdataTableAdapters.inputdataTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Exitt As Button
    Friend WithEvents datempg As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btnupdate As Button
End Class
