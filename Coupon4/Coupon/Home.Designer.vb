<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Taball = New System.Windows.Forms.Panel()
        Me.colordasborad = New System.Windows.Forms.Panel()
        Me.Logoutbig = New System.Windows.Forms.Button()
        Me.Tabsmall = New System.Windows.Forms.Panel()
        Me.piccouponup = New System.Windows.Forms.Button()
        Me.piccoupondowm = New System.Windows.Forms.Button()
        Me.Setting = New System.Windows.Forms.Button()
        Me.Export = New System.Windows.Forms.Button()
        Me.Historybtn = New System.Windows.Forms.Button()
        Me.dropdowngenarate = New System.Windows.Forms.Panel()
        Me.piccontrol = New System.Windows.Forms.Button()
        Me.picgenarate = New System.Windows.Forms.Button()
        Me.genarate = New System.Windows.Forms.Button()
        Me.alldata = New System.Windows.Forms.Button()
        Me.Coupon = New System.Windows.Forms.Button()
        Me.Dashboard = New System.Windows.Forms.Button()
        Me.Tablogo = New System.Windows.Forms.Panel()
        Me.Tablistclose = New System.Windows.Forms.Button()
        Me.Tablist = New System.Windows.Forms.Button()
        Me.itcarelogo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbldepartment = New System.Windows.Forms.Label()
        Me.lblnamelogin = New System.Windows.Forms.Label()
        Me.lblpicuser = New System.Windows.Forms.PictureBox()
        Me.Miniscr = New System.Windows.Forms.Button()
        Me.Maxscr = New System.Windows.Forms.Button()
        Me.Exitt = New System.Windows.Forms.Button()
        Me.Formbase = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Taball.SuspendLayout()
        Me.Tabsmall.SuspendLayout()
        Me.dropdowngenarate.SuspendLayout()
        Me.Tablogo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.lblpicuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Taball
        '
        Me.Taball.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Taball.Controls.Add(Me.colordasborad)
        Me.Taball.Controls.Add(Me.Logoutbig)
        Me.Taball.Controls.Add(Me.Tabsmall)
        Me.Taball.Controls.Add(Me.Tablogo)
        Me.Taball.Dock = System.Windows.Forms.DockStyle.Left
        Me.Taball.Location = New System.Drawing.Point(0, 0)
        Me.Taball.Name = "Taball"
        Me.Taball.Size = New System.Drawing.Size(177, 561)
        Me.Taball.TabIndex = 3
        '
        'colordasborad
        '
        Me.colordasborad.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.colordasborad.Location = New System.Drawing.Point(1, 76)
        Me.colordasborad.Name = "colordasborad"
        Me.colordasborad.Size = New System.Drawing.Size(6, 42)
        Me.colordasborad.TabIndex = 0
        Me.colordasborad.Visible = False
        '
        'Logoutbig
        '
        Me.Logoutbig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Logoutbig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logoutbig.FlatAppearance.BorderSize = 0
        Me.Logoutbig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Logoutbig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logoutbig.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logoutbig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Logoutbig.Image = CType(resources.GetObject("Logoutbig.Image"), System.Drawing.Image)
        Me.Logoutbig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logoutbig.Location = New System.Drawing.Point(4, 527)
        Me.Logoutbig.Name = "Logoutbig"
        Me.Logoutbig.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Logoutbig.Size = New System.Drawing.Size(173, 34)
        Me.Logoutbig.TabIndex = 14
        Me.Logoutbig.Text = "     Logout"
        Me.Logoutbig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logoutbig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Logoutbig.UseVisualStyleBackColor = True
        '
        'Tabsmall
        '
        Me.Tabsmall.AutoScroll = True
        Me.Tabsmall.Controls.Add(Me.piccouponup)
        Me.Tabsmall.Controls.Add(Me.piccoupondowm)
        Me.Tabsmall.Controls.Add(Me.Setting)
        Me.Tabsmall.Controls.Add(Me.Export)
        Me.Tabsmall.Controls.Add(Me.Historybtn)
        Me.Tabsmall.Controls.Add(Me.dropdowngenarate)
        Me.Tabsmall.Controls.Add(Me.Coupon)
        Me.Tabsmall.Controls.Add(Me.Dashboard)
        Me.Tabsmall.Location = New System.Drawing.Point(4, 76)
        Me.Tabsmall.Name = "Tabsmall"
        Me.Tabsmall.Size = New System.Drawing.Size(173, 369)
        Me.Tabsmall.TabIndex = 0
        '
        'piccouponup
        '
        Me.piccouponup.BackgroundImage = CType(resources.GetObject("piccouponup.BackgroundImage"), System.Drawing.Image)
        Me.piccouponup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.piccouponup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.piccouponup.FlatAppearance.BorderSize = 0
        Me.piccouponup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.piccouponup.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piccouponup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.piccouponup.Location = New System.Drawing.Point(141, 53)
        Me.piccouponup.Name = "piccouponup"
        Me.piccouponup.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.piccouponup.Size = New System.Drawing.Size(25, 20)
        Me.piccouponup.TabIndex = 25
        Me.piccouponup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.piccouponup.UseVisualStyleBackColor = True
        Me.piccouponup.Visible = False
        '
        'piccoupondowm
        '
        Me.piccoupondowm.BackgroundImage = CType(resources.GetObject("piccoupondowm.BackgroundImage"), System.Drawing.Image)
        Me.piccoupondowm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.piccoupondowm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.piccoupondowm.FlatAppearance.BorderSize = 0
        Me.piccoupondowm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.piccoupondowm.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piccoupondowm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.piccoupondowm.Location = New System.Drawing.Point(141, 53)
        Me.piccoupondowm.Name = "piccoupondowm"
        Me.piccoupondowm.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.piccoupondowm.Size = New System.Drawing.Size(25, 20)
        Me.piccoupondowm.TabIndex = 24
        Me.piccoupondowm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.piccoupondowm.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.Setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Setting.Dock = System.Windows.Forms.DockStyle.Top
        Me.Setting.FlatAppearance.BorderSize = 0
        Me.Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Setting.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Setting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Setting.Image = CType(resources.GetObject("Setting.Image"), System.Drawing.Image)
        Me.Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Setting.Location = New System.Drawing.Point(0, 252)
        Me.Setting.Name = "Setting"
        Me.Setting.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Setting.Size = New System.Drawing.Size(173, 42)
        Me.Setting.TabIndex = 21
        Me.Setting.Text = "      Setting"
        Me.Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Setting.UseVisualStyleBackColor = True
        '
        'Export
        '
        Me.Export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Export.Dock = System.Windows.Forms.DockStyle.Top
        Me.Export.FlatAppearance.BorderSize = 0
        Me.Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Export.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Export.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Export.Image = CType(resources.GetObject("Export.Image"), System.Drawing.Image)
        Me.Export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Export.Location = New System.Drawing.Point(0, 210)
        Me.Export.Name = "Export"
        Me.Export.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Export.Size = New System.Drawing.Size(173, 42)
        Me.Export.TabIndex = 20
        Me.Export.Text = "      ExportCoupon"
        Me.Export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Export.UseVisualStyleBackColor = True
        '
        'Historybtn
        '
        Me.Historybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Historybtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Historybtn.FlatAppearance.BorderSize = 0
        Me.Historybtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Historybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Historybtn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Historybtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Historybtn.Image = CType(resources.GetObject("Historybtn.Image"), System.Drawing.Image)
        Me.Historybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Historybtn.Location = New System.Drawing.Point(0, 168)
        Me.Historybtn.Name = "Historybtn"
        Me.Historybtn.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Historybtn.Size = New System.Drawing.Size(173, 42)
        Me.Historybtn.TabIndex = 19
        Me.Historybtn.Text = "      History"
        Me.Historybtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Historybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Historybtn.UseVisualStyleBackColor = True
        '
        'dropdowngenarate
        '
        Me.dropdowngenarate.AutoScroll = True
        Me.dropdowngenarate.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.dropdowngenarate.Controls.Add(Me.piccontrol)
        Me.dropdowngenarate.Controls.Add(Me.picgenarate)
        Me.dropdowngenarate.Controls.Add(Me.genarate)
        Me.dropdowngenarate.Controls.Add(Me.alldata)
        Me.dropdowngenarate.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropdowngenarate.Location = New System.Drawing.Point(0, 84)
        Me.dropdowngenarate.Name = "dropdowngenarate"
        Me.dropdowngenarate.Size = New System.Drawing.Size(173, 84)
        Me.dropdowngenarate.TabIndex = 18
        Me.dropdowngenarate.Visible = False
        '
        'piccontrol
        '
        Me.piccontrol.BackgroundImage = CType(resources.GetObject("piccontrol.BackgroundImage"), System.Drawing.Image)
        Me.piccontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.piccontrol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.piccontrol.FlatAppearance.BorderSize = 0
        Me.piccontrol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.piccontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.piccontrol.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piccontrol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.piccontrol.Location = New System.Drawing.Point(51, 54)
        Me.piccontrol.Name = "piccontrol"
        Me.piccontrol.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.piccontrol.Size = New System.Drawing.Size(20, 18)
        Me.piccontrol.TabIndex = 23
        Me.piccontrol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.piccontrol.UseVisualStyleBackColor = True
        '
        'picgenarate
        '
        Me.picgenarate.BackgroundImage = CType(resources.GetObject("picgenarate.BackgroundImage"), System.Drawing.Image)
        Me.picgenarate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picgenarate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picgenarate.FlatAppearance.BorderSize = 0
        Me.picgenarate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.picgenarate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.picgenarate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picgenarate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picgenarate.Location = New System.Drawing.Point(51, 11)
        Me.picgenarate.Name = "picgenarate"
        Me.picgenarate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.picgenarate.Size = New System.Drawing.Size(20, 18)
        Me.picgenarate.TabIndex = 22
        Me.picgenarate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.picgenarate.UseVisualStyleBackColor = True
        '
        'genarate
        '
        Me.genarate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.genarate.Dock = System.Windows.Forms.DockStyle.Top
        Me.genarate.FlatAppearance.BorderSize = 0
        Me.genarate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.genarate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.genarate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genarate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.genarate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.genarate.Location = New System.Drawing.Point(0, 42)
        Me.genarate.Name = "genarate"
        Me.genarate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.genarate.Size = New System.Drawing.Size(173, 42)
        Me.genarate.TabIndex = 17
        Me.genarate.Text = "                Genarate"
        Me.genarate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.genarate.UseVisualStyleBackColor = True
        '
        'alldata
        '
        Me.alldata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.alldata.Dock = System.Windows.Forms.DockStyle.Top
        Me.alldata.FlatAppearance.BorderSize = 0
        Me.alldata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.alldata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.alldata.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alldata.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.alldata.Location = New System.Drawing.Point(0, 0)
        Me.alldata.Name = "alldata"
        Me.alldata.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.alldata.Size = New System.Drawing.Size(173, 42)
        Me.alldata.TabIndex = 16
        Me.alldata.Text = "                 AllData    "
        Me.alldata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.alldata.UseVisualStyleBackColor = True
        '
        'Coupon
        '
        Me.Coupon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Coupon.Dock = System.Windows.Forms.DockStyle.Top
        Me.Coupon.FlatAppearance.BorderSize = 0
        Me.Coupon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Coupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Coupon.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coupon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Coupon.Image = CType(resources.GetObject("Coupon.Image"), System.Drawing.Image)
        Me.Coupon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Coupon.Location = New System.Drawing.Point(0, 42)
        Me.Coupon.Name = "Coupon"
        Me.Coupon.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Coupon.Size = New System.Drawing.Size(173, 42)
        Me.Coupon.TabIndex = 9
        Me.Coupon.Text = "      Coupon"
        Me.Coupon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Coupon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Coupon.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dashboard.FlatAppearance.BorderSize = 0
        Me.Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dashboard.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dashboard.Image = CType(resources.GetObject("Dashboard.Image"), System.Drawing.Image)
        Me.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dashboard.Location = New System.Drawing.Point(0, 0)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Dashboard.Size = New System.Drawing.Size(173, 42)
        Me.Dashboard.TabIndex = 8
        Me.Dashboard.Text = "      Dashboard"
        Me.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Dashboard.UseVisualStyleBackColor = True
        '
        'Tablogo
        '
        Me.Tablogo.Controls.Add(Me.Tablistclose)
        Me.Tablogo.Controls.Add(Me.Tablist)
        Me.Tablogo.Controls.Add(Me.itcarelogo)
        Me.Tablogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Tablogo.Location = New System.Drawing.Point(0, 0)
        Me.Tablogo.Name = "Tablogo"
        Me.Tablogo.Size = New System.Drawing.Size(177, 42)
        Me.Tablogo.TabIndex = 19
        '
        'Tablistclose
        '
        Me.Tablistclose.BackgroundImage = CType(resources.GetObject("Tablistclose.BackgroundImage"), System.Drawing.Image)
        Me.Tablistclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tablistclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tablistclose.FlatAppearance.BorderSize = 0
        Me.Tablistclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tablistclose.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tablistclose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tablistclose.Location = New System.Drawing.Point(1, 5)
        Me.Tablistclose.Name = "Tablistclose"
        Me.Tablistclose.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Tablistclose.Size = New System.Drawing.Size(40, 36)
        Me.Tablistclose.TabIndex = 16
        Me.Tablistclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tablistclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Tablistclose.UseVisualStyleBackColor = True
        '
        'Tablist
        '
        Me.Tablist.BackgroundImage = CType(resources.GetObject("Tablist.BackgroundImage"), System.Drawing.Image)
        Me.Tablist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tablist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tablist.FlatAppearance.BorderSize = 0
        Me.Tablist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tablist.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tablist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tablist.Location = New System.Drawing.Point(1, 5)
        Me.Tablist.Name = "Tablist"
        Me.Tablist.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Tablist.Size = New System.Drawing.Size(40, 36)
        Me.Tablist.TabIndex = 15
        Me.Tablist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tablist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Tablist.UseVisualStyleBackColor = True
        Me.Tablist.Visible = False
        '
        'itcarelogo
        '
        Me.itcarelogo.AutoSize = True
        Me.itcarelogo.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itcarelogo.ForeColor = System.Drawing.Color.White
        Me.itcarelogo.Location = New System.Drawing.Point(86, 4)
        Me.itcarelogo.Name = "itcarelogo"
        Me.itcarelogo.Size = New System.Drawing.Size(85, 33)
        Me.itcarelogo.TabIndex = 0
        Me.itcarelogo.Text = "ITCare"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbldepartment)
        Me.Panel1.Controls.Add(Me.lblnamelogin)
        Me.Panel1.Controls.Add(Me.lblpicuser)
        Me.Panel1.Controls.Add(Me.Miniscr)
        Me.Panel1.Controls.Add(Me.Maxscr)
        Me.Panel1.Controls.Add(Me.Exitt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(177, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 42)
        Me.Panel1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 29)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(80, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 29)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(427, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(427, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'lbldepartment
        '
        Me.lbldepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldepartment.AutoSize = True
        Me.lbldepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbldepartment.ForeColor = System.Drawing.Color.White
        Me.lbldepartment.Location = New System.Drawing.Point(535, 20)
        Me.lbldepartment.Name = "lbldepartment"
        Me.lbldepartment.Size = New System.Drawing.Size(54, 15)
        Me.lbldepartment.TabIndex = 22
        Me.lbldepartment.Text = "Itsupport"
        '
        'lblnamelogin
        '
        Me.lblnamelogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnamelogin.AutoSize = True
        Me.lblnamelogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblnamelogin.ForeColor = System.Drawing.Color.White
        Me.lblnamelogin.Location = New System.Drawing.Point(535, 3)
        Me.lblnamelogin.Name = "lblnamelogin"
        Me.lblnamelogin.Size = New System.Drawing.Size(113, 15)
        Me.lblnamelogin.TabIndex = 21
        Me.lblnamelogin.Text = "tadapong@laf.co.th"
        '
        'lblpicuser
        '
        Me.lblpicuser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpicuser.Image = CType(resources.GetObject("lblpicuser.Image"), System.Drawing.Image)
        Me.lblpicuser.Location = New System.Drawing.Point(491, 3)
        Me.lblpicuser.Name = "lblpicuser"
        Me.lblpicuser.Size = New System.Drawing.Size(38, 36)
        Me.lblpicuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblpicuser.TabIndex = 20
        Me.lblpicuser.TabStop = False
        '
        'Miniscr
        '
        Me.Miniscr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Miniscr.BackgroundImage = CType(resources.GetObject("Miniscr.BackgroundImage"), System.Drawing.Image)
        Me.Miniscr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Miniscr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Miniscr.FlatAppearance.BorderSize = 0
        Me.Miniscr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Miniscr.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Miniscr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Miniscr.Location = New System.Drawing.Point(669, 4)
        Me.Miniscr.Name = "Miniscr"
        Me.Miniscr.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Miniscr.Size = New System.Drawing.Size(20, 25)
        Me.Miniscr.TabIndex = 19
        Me.Miniscr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Miniscr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Miniscr.UseVisualStyleBackColor = True
        '
        'Maxscr
        '
        Me.Maxscr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maxscr.BackgroundImage = CType(resources.GetObject("Maxscr.BackgroundImage"), System.Drawing.Image)
        Me.Maxscr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Maxscr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Maxscr.FlatAppearance.BorderSize = 0
        Me.Maxscr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maxscr.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maxscr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Maxscr.Location = New System.Drawing.Point(703, 4)
        Me.Maxscr.Name = "Maxscr"
        Me.Maxscr.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Maxscr.Size = New System.Drawing.Size(20, 25)
        Me.Maxscr.TabIndex = 18
        Me.Maxscr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Maxscr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Maxscr.UseVisualStyleBackColor = True
        '
        'Exitt
        '
        Me.Exitt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Exitt.BackgroundImage = CType(resources.GetObject("Exitt.BackgroundImage"), System.Drawing.Image)
        Me.Exitt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Exitt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exitt.FlatAppearance.BorderSize = 0
        Me.Exitt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Exitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exitt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Exitt.Location = New System.Drawing.Point(734, 4)
        Me.Exitt.Name = "Exitt"
        Me.Exitt.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Exitt.Size = New System.Drawing.Size(20, 25)
        Me.Exitt.TabIndex = 17
        Me.Exitt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Exitt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Exitt.UseVisualStyleBackColor = True
        '
        'Formbase
        '
        Me.Formbase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Formbase.Location = New System.Drawing.Point(177, 42)
        Me.Formbase.Name = "Formbase"
        Me.Formbase.Size = New System.Drawing.Size(757, 519)
        Me.Formbase.TabIndex = 6
        '
        'Timer1
        '
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.Formbase)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Taball)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Taball.ResumeLayout(False)
        Me.Tabsmall.ResumeLayout(False)
        Me.dropdowngenarate.ResumeLayout(False)
        Me.Tablogo.ResumeLayout(False)
        Me.Tablogo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.lblpicuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Taball As Panel
    Friend WithEvents Logoutbig As Button
    Friend WithEvents Tablogo As Panel
    Friend WithEvents itcarelogo As Label
    Friend WithEvents Tabsmall As Panel
    Friend WithEvents Dashboard As Button
    Friend WithEvents Tablist As Button
    Friend WithEvents Coupon As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Setting As Button
    Friend WithEvents Export As Button
    Friend WithEvents Historybtn As Button
    Friend WithEvents piccoupondowm As Button
    Friend WithEvents piccouponup As Button
    Friend WithEvents Tablistclose As Button
    Friend WithEvents Formbase As Panel
    Friend WithEvents Exitt As Button
    Friend WithEvents Miniscr As Button
    Friend WithEvents Maxscr As Button
    Friend WithEvents colordasborad As Panel
    Friend WithEvents dropdowngenarate As Panel
    Friend WithEvents piccontrol As Button
    Friend WithEvents picgenarate As Button
    Friend WithEvents genarate As Button
    Friend WithEvents alldata As Button
    Friend WithEvents lbldepartment As Label
    Friend WithEvents lblnamelogin As Label
    Friend WithEvents lblpicuser As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
