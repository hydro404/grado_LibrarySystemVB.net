<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim login_btn As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.username_textbox = New System.Windows.Forms.TextBox()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.password_textbox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        login_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'login_btn
        '
        login_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        login_btn.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        login_btn.Cursor = System.Windows.Forms.Cursors.Hand
        login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        login_btn.FlatAppearance.BorderSize = 0
        login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        login_btn.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        login_btn.ForeColor = System.Drawing.Color.White
        login_btn.Location = New System.Drawing.Point(251, 408)
        login_btn.Name = "login_btn"
        login_btn.Size = New System.Drawing.Size(105, 43)
        login_btn.TabIndex = 0
        login_btn.Text = "Login"
        login_btn.UseVisualStyleBackColor = False
        AddHandler login_btn.Click, AddressOf Me.Button1_Click
        '
        'username_textbox
        '
        Me.username_textbox.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.username_textbox.Location = New System.Drawing.Point(173, 272)
        Me.username_textbox.Name = "username_textbox"
        Me.username_textbox.Size = New System.Drawing.Size(263, 39)
        Me.username_textbox.TabIndex = 2
        '
        'usernameLabel
        '
        Me.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.usernameLabel.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.usernameLabel.Location = New System.Drawing.Point(166, 242)
        Me.usernameLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(97, 27)
        Me.usernameLabel.TabIndex = 5
        Me.usernameLabel.Text = " Username"
        '
        'passwordLabel
        '
        Me.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.BackColor = System.Drawing.Color.Transparent
        Me.passwordLabel.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.passwordLabel.Location = New System.Drawing.Point(166, 319)
        Me.passwordLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(94, 27)
        Me.passwordLabel.TabIndex = 6
        Me.passwordLabel.Text = " Password"
        '
        'password_textbox
        '
        Me.password_textbox.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.password_textbox.Location = New System.Drawing.Point(173, 349)
        Me.password_textbox.Name = "password_textbox"
        Me.password_textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.password_textbox.Size = New System.Drawing.Size(263, 39)
        Me.password_textbox.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(606, 189)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(604, 477)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.password_textbox)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.usernameLabel)
        Me.Controls.Add(Me.username_textbox)
        Me.Controls.Add(login_btn)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library System Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login_btn As Button
    Friend WithEvents username_textbox As TextBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents password_textbox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
