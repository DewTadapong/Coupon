<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Enterlogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Miniscr = New System.Windows.Forms.Button()
        Me.Maxscr = New System.Windows.Forms.Button()
        Me.Exitt = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(934, 275)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Enterlogin)
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.Controls.Add(Me.txtUser)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(270, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(384, 445)
        Me.Panel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "USER"
        '
        'Enterlogin
        '
        Me.Enterlogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Enterlogin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Enterlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enterlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Enterlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Enterlogin.Location = New System.Drawing.Point(146, 375)
        Me.Enterlogin.Name = "Enterlogin"
        Me.Enterlogin.Size = New System.Drawing.Size(96, 40)
        Me.Enterlogin.TabIndex = 3
        Me.Enterlogin.Text = "LOGIN"
        Me.Enterlogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(92, 311)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(198, 34)
        Me.txtPassword.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(92, 226)
        Me.txtUser.MaxLength = 35
        Me.txtUser.Multiline = True
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(198, 34)
        Me.txtUser.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(138, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(113, 104)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        '
        'Miniscr
        '
        Me.Miniscr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Miniscr.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Miniscr.BackgroundImage = CType(resources.GetObject("Miniscr.BackgroundImage"), System.Drawing.Image)
        Me.Miniscr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Miniscr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Miniscr.FlatAppearance.BorderSize = 0
        Me.Miniscr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Miniscr.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Miniscr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Miniscr.Location = New System.Drawing.Point(833, 0)
        Me.Miniscr.Name = "Miniscr"
        Me.Miniscr.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Miniscr.Size = New System.Drawing.Size(28, 30)
        Me.Miniscr.TabIndex = 28
        Me.Miniscr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Miniscr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Miniscr.UseVisualStyleBackColor = False
        '
        'Maxscr
        '
        Me.Maxscr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maxscr.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Maxscr.BackgroundImage = CType(resources.GetObject("Maxscr.BackgroundImage"), System.Drawing.Image)
        Me.Maxscr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Maxscr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Maxscr.FlatAppearance.BorderSize = 0
        Me.Maxscr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maxscr.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maxscr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Maxscr.Location = New System.Drawing.Point(868, 0)
        Me.Maxscr.Name = "Maxscr"
        Me.Maxscr.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Maxscr.Size = New System.Drawing.Size(28, 30)
        Me.Maxscr.TabIndex = 27
        Me.Maxscr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Maxscr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Maxscr.UseVisualStyleBackColor = False
        '
        'Exitt
        '
        Me.Exitt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Exitt.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Exitt.BackgroundImage = CType(resources.GetObject("Exitt.BackgroundImage"), System.Drawing.Image)
        Me.Exitt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Exitt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exitt.FlatAppearance.BorderSize = 0
        Me.Exitt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Exitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exitt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Exitt.Location = New System.Drawing.Point(903, 0)
        Me.Exitt.Name = "Exitt"
        Me.Exitt.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Exitt.Size = New System.Drawing.Size(28, 30)
        Me.Exitt.TabIndex = 26
        Me.Exitt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Exitt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Exitt.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.Miniscr)
        Me.Controls.Add(Me.Maxscr)
        Me.Controls.Add(Me.Exitt)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Miniscr As Button
    Friend WithEvents Maxscr As Button
    Friend WithEvents Exitt As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Enterlogin As Button
End Class
