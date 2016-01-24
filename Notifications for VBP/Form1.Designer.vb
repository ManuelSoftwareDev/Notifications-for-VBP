<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuButton1 = New Notifications_for_VBP.MenuButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AktualisierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NfvbpBtn5 = New Notifications_for_VBP.NFVBPBtn()
        Me.NfvbpBtn4 = New Notifications_for_VBP.NFVBPBtn()
        Me.NfvbpBtn2 = New Notifications_for_VBP.NFVBPBtn()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NfvbpBtn3 = New Notifications_for_VBP.NFVBPBtn()
        Me.NfvbpBtn1 = New Notifications_for_VBP.NFVBPBtn()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MenuButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 50)
        Me.Panel1.TabIndex = 0
        '
        'MenuButton1
        '
        Me.MenuButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuButton1.Location = New System.Drawing.Point(250, 0)
        Me.MenuButton1.Name = "MenuButton1"
        Me.MenuButton1.Size = New System.Drawing.Size(50, 50)
        Me.MenuButton1.TabIndex = 2
        Me.MenuButton1.Text = "MenuButton1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Notifications for VBP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Benachrichtigungen im Überblick:"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(14, 179)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(272, 266)
        Me.Panel2.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AktualisierenToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.ÜberToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(149, 108)
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
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Notifications for VBP"
        Me.NotifyIcon1.Visible = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txt_pwd)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txt_username)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.NfvbpBtn5)
        Me.Panel3.Controls.Add(Me.NfvbpBtn4)
        Me.Panel3.Controls.Add(Me.NfvbpBtn2)
        Me.Panel3.Controls.Add(Me.LinkLabel3)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.LinkLabel2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.NumericUpDown1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 450)
        Me.Panel3.TabIndex = 8
        Me.Panel3.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 21)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Anmeldung"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(118, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 19)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Passwort"
        '
        'txt_pwd
        '
        Me.txt_pwd.Location = New System.Drawing.Point(122, 136)
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.Size = New System.Drawing.Size(80, 22)
        Me.txt_pwd.TabIndex = 21
        Me.txt_pwd.UseSystemPasswordChar = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 19)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Benutzer"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(16, 136)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(100, 22)
        Me.txt_username.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NfvbpBtn5
        '
        Me.NfvbpBtn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.NfvbpBtn5.Image = CType(resources.GetObject("NfvbpBtn5.Image"), System.Drawing.Image)
        Me.NfvbpBtn5.Location = New System.Drawing.Point(200, 8)
        Me.NfvbpBtn5.Margin = New System.Windows.Forms.Padding(5)
        Me.NfvbpBtn5.Name = "NfvbpBtn5"
        Me.NfvbpBtn5.Quantity = 0
        Me.NfvbpBtn5.Size = New System.Drawing.Size(80, 80)
        Me.NfvbpBtn5.TabIndex = 13
        Me.NfvbpBtn5.Text = "Beenden"
        '
        'NfvbpBtn4
        '
        Me.NfvbpBtn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.NfvbpBtn4.Image = CType(resources.GetObject("NfvbpBtn4.Image"), System.Drawing.Image)
        Me.NfvbpBtn4.Location = New System.Drawing.Point(110, 8)
        Me.NfvbpBtn4.Margin = New System.Windows.Forms.Padding(5)
        Me.NfvbpBtn4.Name = "NfvbpBtn4"
        Me.NfvbpBtn4.Quantity = 0
        Me.NfvbpBtn4.Size = New System.Drawing.Size(80, 80)
        Me.NfvbpBtn4.TabIndex = 12
        Me.NfvbpBtn4.Text = "Minimieren"
        '
        'NfvbpBtn2
        '
        Me.NfvbpBtn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.NfvbpBtn2.Image = CType(resources.GetObject("NfvbpBtn2.Image"), System.Drawing.Image)
        Me.NfvbpBtn2.Location = New System.Drawing.Point(20, 8)
        Me.NfvbpBtn2.Margin = New System.Windows.Forms.Padding(5)
        Me.NfvbpBtn2.Name = "NfvbpBtn2"
        Me.NfvbpBtn2.Quantity = 0
        Me.NfvbpBtn2.Size = New System.Drawing.Size(80, 80)
        Me.NfvbpBtn2.TabIndex = 11
        Me.NfvbpBtn2.Text = "Aktualisieren"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(12, 400)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(182, 19)
        Me.LinkLabel3.TabIndex = 10
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "https://www.vb-paradise.de/"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(227, 38)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Es handelt sich über eine inoffizielle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hilfsanwendung für die Website"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(131, 343)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(110, 19)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Manuelsoftware."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(92, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "und"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 343)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(74, 19)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "KingTimon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(251, 19)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Dieses Programm wurde entwickelt von"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Über"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(237, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "min"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(171, 229)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(60, 22)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Aktualisierungsintervall:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Einstellungen"
        '
        'NfvbpBtn3
        '
        Me.NfvbpBtn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.NfvbpBtn3.Image = Nothing
        Me.NfvbpBtn3.Location = New System.Drawing.Point(156, 58)
        Me.NfvbpBtn3.Margin = New System.Windows.Forms.Padding(5)
        Me.NfvbpBtn3.Name = "NfvbpBtn3"
        Me.NfvbpBtn3.Quantity = 0
        Me.NfvbpBtn3.Size = New System.Drawing.Size(130, 80)
        Me.NfvbpBtn3.TabIndex = 3
        Me.NfvbpBtn3.Text = "neue Konversationen"
        '
        'NfvbpBtn1
        '
        Me.NfvbpBtn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.NfvbpBtn1.Image = Nothing
        Me.NfvbpBtn1.Location = New System.Drawing.Point(14, 58)
        Me.NfvbpBtn1.Margin = New System.Windows.Forms.Padding(5)
        Me.NfvbpBtn1.Name = "NfvbpBtn1"
        Me.NfvbpBtn1.Quantity = 0
        Me.NfvbpBtn1.Size = New System.Drawing.Size(130, 80)
        Me.NfvbpBtn1.TabIndex = 1
        Me.NfvbpBtn1.Text = "Benachrichtigungen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 500)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NfvbpBtn3)
        Me.Controls.Add(Me.NfvbpBtn1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Notifications for VBP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NfvbpBtn1 As NFVBPBtn
    Friend WithEvents NfvbpBtn3 As NFVBPBtn
    Friend WithEvents MenuButton1 As MenuButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents AktualisierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NfvbpBtn5 As NFVBPBtn
    Friend WithEvents NfvbpBtn4 As NFVBPBtn
    Friend WithEvents NfvbpBtn2 As NFVBPBtn
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
End Class
