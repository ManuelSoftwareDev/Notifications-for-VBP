<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlCaption = New System.Windows.Forms.Panel()
        Me.btnMenu = New Notifications_for_VBP.MenuButton()
        Me.lblMainCaption = New System.Windows.Forms.Label()
        Me.lblMessages = New System.Windows.Forms.Label()
        Me.pnlAll = New System.Windows.Forms.Panel()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AktualisierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.watch = New System.Windows.Forms.Timer(Me.components)
        Me.nfiMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblCaption_LoginSection = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New Notifications_for_VBP.NFVBPBtn()
        Me.btnMinimize = New Notifications_for_VBP.NFVBPBtn()
        Me.btnRefresh = New Notifications_for_VBP.NFVBPBtn()
        Me.linkVBP = New System.Windows.Forms.LinkLabel()
        Me.lblAbout_line3u4 = New System.Windows.Forms.Label()
        Me.linkManuelSoftware = New System.Windows.Forms.LinkLabel()
        Me.lblAbout_line2 = New System.Windows.Forms.Label()
        Me.linkKingTimon = New System.Windows.Forms.LinkLabel()
        Me.lblAbout_line1 = New System.Windows.Forms.Label()
        Me.lblCaption_AboutSection = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.nUpDown = New System.Windows.Forms.NumericUpDown()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.lblCaption_SettingsSection = New System.Windows.Forms.Label()
        Me.btnConversations = New Notifications_for_VBP.NFVBPBtn()
        Me.btnNotifications = New Notifications_for_VBP.NFVBPBtn()
        Me.pnlCaption.SuspendLayout()
        Me.ctxMenu.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.nUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCaption
        '
        Me.pnlCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.pnlCaption.Controls.Add(Me.btnMenu)
        Me.pnlCaption.Controls.Add(Me.lblMainCaption)
        Me.pnlCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCaption.Location = New System.Drawing.Point(0, 0)
        Me.pnlCaption.Name = "pnlCaption"
        Me.pnlCaption.Size = New System.Drawing.Size(300, 50)
        Me.pnlCaption.TabIndex = 0
        '
        'btnMenu
        '
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMenu.Location = New System.Drawing.Point(250, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(50, 50)
        Me.btnMenu.TabIndex = 2
        '
        'lblMainCaption
        '
        Me.lblMainCaption.AutoSize = True
        Me.lblMainCaption.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblMainCaption.ForeColor = System.Drawing.Color.White
        Me.lblMainCaption.Location = New System.Drawing.Point(3, 13)
        Me.lblMainCaption.Name = "lblMainCaption"
        Me.lblMainCaption.Size = New System.Drawing.Size(187, 25)
        Me.lblMainCaption.TabIndex = 1
        Me.lblMainCaption.Text = "Notifications for VBP"
        '
        'lblMessages
        '
        Me.lblMessages.AutoSize = True
        Me.lblMessages.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblMessages.Location = New System.Drawing.Point(12, 153)
        Me.lblMessages.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblMessages.Name = "lblMessages"
        Me.lblMessages.Size = New System.Drawing.Size(243, 21)
        Me.lblMessages.TabIndex = 4
        Me.lblMessages.Text = "Benachrichtigungen im Überblick:"
        '
        'pnlAll
        '
        Me.pnlAll.Location = New System.Drawing.Point(14, 179)
        Me.pnlAll.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlAll.Name = "pnlAll"
        Me.pnlAll.Size = New System.Drawing.Size(272, 266)
        Me.pnlAll.TabIndex = 5
        '
        'ctxMenu
        '
        Me.ctxMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AktualisierenToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.ÜberToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.ctxMenu.Name = "ContextMenuStrip1"
        Me.ctxMenu.ShowImageMargin = False
        Me.ctxMenu.Size = New System.Drawing.Size(149, 108)
        '
        'AktualisierenToolStripMenuItem
        '
        Me.AktualisierenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.AktualisierenToolStripMenuItem.Name = "AktualisierenToolStripMenuItem"
        Me.AktualisierenToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.AktualisierenToolStripMenuItem.Text = "Aktualisieren"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'ÜberToolStripMenuItem
        '
        Me.ÜberToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ÜberToolStripMenuItem.Name = "ÜberToolStripMenuItem"
        Me.ÜberToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.ÜberToolStripMenuItem.Text = "Über"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(261, 146)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.TabIndex = 7
        Me.WebBrowser1.Visible = False
        '
        'watch
        '
        Me.watch.Interval = 60000
        '
        'nfiMain
        '
        Me.nfiMain.Icon = CType(resources.GetObject("nfiMain.Icon"), System.Drawing.Icon)
        Me.nfiMain.Text = "Notifications for VBP"
        Me.nfiMain.Visible = True
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.lblCaption_LoginSection)
        Me.pnlMain.Controls.Add(Me.lblPassword)
        Me.pnlMain.Controls.Add(Me.txtPassword)
        Me.pnlMain.Controls.Add(Me.lblUsername)
        Me.pnlMain.Controls.Add(Me.txtUsername)
        Me.pnlMain.Controls.Add(Me.btnLogin)
        Me.pnlMain.Controls.Add(Me.btnExit)
        Me.pnlMain.Controls.Add(Me.btnMinimize)
        Me.pnlMain.Controls.Add(Me.btnRefresh)
        Me.pnlMain.Controls.Add(Me.linkVBP)
        Me.pnlMain.Controls.Add(Me.lblAbout_line3u4)
        Me.pnlMain.Controls.Add(Me.linkManuelSoftware)
        Me.pnlMain.Controls.Add(Me.lblAbout_line2)
        Me.pnlMain.Controls.Add(Me.linkKingTimon)
        Me.pnlMain.Controls.Add(Me.lblAbout_line1)
        Me.pnlMain.Controls.Add(Me.lblCaption_AboutSection)
        Me.pnlMain.Controls.Add(Me.lbltime)
        Me.pnlMain.Controls.Add(Me.nUpDown)
        Me.pnlMain.Controls.Add(Me.lblInterval)
        Me.pnlMain.Controls.Add(Me.lblCaption_SettingsSection)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 50)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(300, 450)
        Me.pnlMain.TabIndex = 8
        Me.pnlMain.Visible = False
        '
        'lblCaption_LoginSection
        '
        Me.lblCaption_LoginSection.AutoSize = True
        Me.lblCaption_LoginSection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption_LoginSection.ForeColor = System.Drawing.Color.White
        Me.lblCaption_LoginSection.Location = New System.Drawing.Point(12, 93)
        Me.lblCaption_LoginSection.Name = "lblCaption_LoginSection"
        Me.lblCaption_LoginSection.Size = New System.Drawing.Size(100, 21)
        Me.lblCaption_LoginSection.TabIndex = 23
        Me.lblCaption_LoginSection.Text = "Anmeldung"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(118, 114)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 19)
        Me.lblPassword.TabIndex = 22
        Me.lblPassword.Text = "Passwort"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(122, 136)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(80, 22)
        Me.txtPassword.TabIndex = 21
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(12, 114)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(63, 19)
        Me.lblUsername.TabIndex = 20
        Me.lblUsername.Text = "Benutzer"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(16, 136)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 22)
        Me.txtUsername.TabIndex = 19
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(208, 136)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 18
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(200, 8)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Quantity = 0
        Me.btnExit.Size = New System.Drawing.Size(80, 80)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Beenden"
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(110, 8)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(5)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Quantity = 0
        Me.btnMinimize.Size = New System.Drawing.Size(80, 80)
        Me.btnMinimize.TabIndex = 12
        Me.btnMinimize.Text = "Minimieren"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(20, 8)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Quantity = 0
        Me.btnRefresh.Size = New System.Drawing.Size(80, 80)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Aktualisieren"
        '
        'linkVBP
        '
        Me.linkVBP.AutoSize = True
        Me.linkVBP.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.linkVBP.LinkColor = System.Drawing.Color.White
        Me.linkVBP.Location = New System.Drawing.Point(12, 400)
        Me.linkVBP.Name = "linkVBP"
        Me.linkVBP.Size = New System.Drawing.Size(182, 19)
        Me.linkVBP.TabIndex = 10
        Me.linkVBP.TabStop = True
        Me.linkVBP.Text = "https://www.vb-paradise.de/"
        '
        'lblAbout_line3u4
        '
        Me.lblAbout_line3u4.AutoSize = True
        Me.lblAbout_line3u4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAbout_line3u4.ForeColor = System.Drawing.Color.White
        Me.lblAbout_line3u4.Location = New System.Drawing.Point(12, 362)
        Me.lblAbout_line3u4.Name = "lblAbout_line3u4"
        Me.lblAbout_line3u4.Size = New System.Drawing.Size(227, 38)
        Me.lblAbout_line3u4.TabIndex = 9
        Me.lblAbout_line3u4.Text = "Es handelt sich über eine inoffizielle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hilfsanwendung für die Website"
        '
        'linkManuelSoftware
        '
        Me.linkManuelSoftware.AutoSize = True
        Me.linkManuelSoftware.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.linkManuelSoftware.LinkColor = System.Drawing.Color.White
        Me.linkManuelSoftware.Location = New System.Drawing.Point(131, 343)
        Me.linkManuelSoftware.Name = "linkManuelSoftware"
        Me.linkManuelSoftware.Size = New System.Drawing.Size(111, 19)
        Me.linkManuelSoftware.TabIndex = 8
        Me.linkManuelSoftware.TabStop = True
        Me.linkManuelSoftware.Text = "ManuelSoftware."
        '
        'lblAbout_line2
        '
        Me.lblAbout_line2.AutoSize = True
        Me.lblAbout_line2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAbout_line2.ForeColor = System.Drawing.Color.White
        Me.lblAbout_line2.Location = New System.Drawing.Point(92, 343)
        Me.lblAbout_line2.Name = "lblAbout_line2"
        Me.lblAbout_line2.Size = New System.Drawing.Size(33, 19)
        Me.lblAbout_line2.TabIndex = 7
        Me.lblAbout_line2.Text = "und"
        '
        'linkKingTimon
        '
        Me.linkKingTimon.AutoSize = True
        Me.linkKingTimon.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.linkKingTimon.LinkColor = System.Drawing.Color.White
        Me.linkKingTimon.Location = New System.Drawing.Point(12, 343)
        Me.linkKingTimon.Name = "linkKingTimon"
        Me.linkKingTimon.Size = New System.Drawing.Size(74, 19)
        Me.linkKingTimon.TabIndex = 6
        Me.linkKingTimon.TabStop = True
        Me.linkKingTimon.Text = "KingTimon"
        '
        'lblAbout_line1
        '
        Me.lblAbout_line1.AutoSize = True
        Me.lblAbout_line1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAbout_line1.ForeColor = System.Drawing.Color.White
        Me.lblAbout_line1.Location = New System.Drawing.Point(12, 324)
        Me.lblAbout_line1.Name = "lblAbout_line1"
        Me.lblAbout_line1.Size = New System.Drawing.Size(251, 19)
        Me.lblAbout_line1.TabIndex = 5
        Me.lblAbout_line1.Text = "Dieses Programm wurde entwickelt von"
        '
        'lblCaption_AboutSection
        '
        Me.lblCaption_AboutSection.AutoSize = True
        Me.lblCaption_AboutSection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption_AboutSection.ForeColor = System.Drawing.Color.White
        Me.lblCaption_AboutSection.Location = New System.Drawing.Point(12, 303)
        Me.lblCaption_AboutSection.Name = "lblCaption_AboutSection"
        Me.lblCaption_AboutSection.Size = New System.Drawing.Size(47, 21)
        Me.lblCaption_AboutSection.TabIndex = 4
        Me.lblCaption_AboutSection.Text = "Über"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(237, 228)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(32, 19)
        Me.lbltime.TabIndex = 3
        Me.lbltime.Text = "min"
        '
        'nUpDown
        '
        Me.nUpDown.Location = New System.Drawing.Point(171, 229)
        Me.nUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nUpDown.Name = "nUpDown"
        Me.nUpDown.Size = New System.Drawing.Size(60, 22)
        Me.nUpDown.TabIndex = 2
        Me.nUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblInterval.ForeColor = System.Drawing.Color.White
        Me.lblInterval.Location = New System.Drawing.Point(12, 228)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(153, 19)
        Me.lblInterval.TabIndex = 1
        Me.lblInterval.Text = "Aktualisierungsintervall:"
        '
        'lblCaption_SettingsSection
        '
        Me.lblCaption_SettingsSection.AutoSize = True
        Me.lblCaption_SettingsSection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption_SettingsSection.ForeColor = System.Drawing.Color.White
        Me.lblCaption_SettingsSection.Location = New System.Drawing.Point(12, 207)
        Me.lblCaption_SettingsSection.Name = "lblCaption_SettingsSection"
        Me.lblCaption_SettingsSection.Size = New System.Drawing.Size(115, 21)
        Me.lblCaption_SettingsSection.TabIndex = 0
        Me.lblCaption_SettingsSection.Text = "Einstellungen"
        '
        'btnConversations
        '
        Me.btnConversations.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnConversations.Image = Nothing
        Me.btnConversations.Location = New System.Drawing.Point(156, 58)
        Me.btnConversations.Margin = New System.Windows.Forms.Padding(5)
        Me.btnConversations.Name = "btnConversations"
        Me.btnConversations.Quantity = 0
        Me.btnConversations.Size = New System.Drawing.Size(130, 80)
        Me.btnConversations.TabIndex = 3
        Me.btnConversations.Text = "Neue Konversationen"
        '
        'btnNotifications
        '
        Me.btnNotifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnNotifications.Image = Nothing
        Me.btnNotifications.Location = New System.Drawing.Point(14, 58)
        Me.btnNotifications.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNotifications.Name = "btnNotifications"
        Me.btnNotifications.Quantity = 0
        Me.btnNotifications.Size = New System.Drawing.Size(130, 80)
        Me.btnNotifications.TabIndex = 1
        Me.btnNotifications.Text = "Benachrichtigungen"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 500)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.pnlAll)
        Me.Controls.Add(Me.lblMessages)
        Me.Controls.Add(Me.btnConversations)
        Me.Controls.Add(Me.btnNotifications)
        Me.Controls.Add(Me.pnlCaption)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Notifications for VBP"
        Me.pnlCaption.ResumeLayout(False)
        Me.pnlCaption.PerformLayout()
        Me.ctxMenu.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.nUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlCaption As Panel
    Friend WithEvents lblMainCaption As Label
    Friend WithEvents btnNotifications As NFVBPBtn
    Friend WithEvents btnConversations As NFVBPBtn
    Friend WithEvents btnMenu As MenuButton
    Friend WithEvents lblMessages As Label
    Friend WithEvents pnlAll As Panel
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents AktualisierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents watch As Timer
    Friend WithEvents nfiMain As NotifyIcon
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lbltime As Label
    Friend WithEvents nUpDown As NumericUpDown
    Friend WithEvents lblInterval As Label
    Friend WithEvents lblCaption_SettingsSection As Label
    Friend WithEvents linkVBP As LinkLabel
    Friend WithEvents lblAbout_line3u4 As Label
    Friend WithEvents linkManuelSoftware As LinkLabel
    Friend WithEvents lblAbout_line2 As Label
    Friend WithEvents linkKingTimon As LinkLabel
    Friend WithEvents lblAbout_line1 As Label
    Friend WithEvents lblCaption_AboutSection As Label
    Friend WithEvents btnExit As NFVBPBtn
    Friend WithEvents btnMinimize As NFVBPBtn
    Friend WithEvents btnRefresh As NFVBPBtn
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblCaption_LoginSection As Label
End Class
