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
        Dim r_btn As System.Windows.Forms.Button
        Dim Reservations_logs As System.Windows.Forms.Button
        Dim Return_btn As System.Windows.Forms.Button
        Dim Button3 As System.Windows.Forms.Button
        Dim Button2 As System.Windows.Forms.Button
        Dim Returned_logs As System.Windows.Forms.Button
        Dim Button1 As System.Windows.Forms.Button
        Dim Button4 As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.bookView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.users_view = New System.Windows.Forms.DataGridView()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        r_btn = New System.Windows.Forms.Button()
        Reservations_logs = New System.Windows.Forms.Button()
        Return_btn = New System.Windows.Forms.Button()
        Button3 = New System.Windows.Forms.Button()
        Button2 = New System.Windows.Forms.Button()
        Returned_logs = New System.Windows.Forms.Button()
        Button1 = New System.Windows.Forms.Button()
        Button4 = New System.Windows.Forms.Button()
        CType(Me.bookView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.users_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'r_btn
        '
        r_btn.AutoSize = True
        r_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        r_btn.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.long_bg
        r_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        r_btn.Cursor = System.Windows.Forms.Cursors.Hand
        r_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        r_btn.FlatAppearance.BorderSize = 0
        r_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        r_btn.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        r_btn.ForeColor = System.Drawing.Color.White
        r_btn.Location = New System.Drawing.Point(61, 486)
        r_btn.Name = "r_btn"
        r_btn.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        r_btn.Size = New System.Drawing.Size(243, 52)
        r_btn.TabIndex = 9
        r_btn.Text = "RESERVE BOOKS"
        r_btn.UseVisualStyleBackColor = False
        AddHandler r_btn.Click, AddressOf Me.Reserve_btn_Click
        '
        'Reservations_logs
        '
        Reservations_logs.AutoSize = True
        Reservations_logs.BackColor = System.Drawing.SystemColors.ActiveCaption
        Reservations_logs.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.long_bg
        Reservations_logs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Reservations_logs.Cursor = System.Windows.Forms.Cursors.Hand
        Reservations_logs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        Reservations_logs.FlatAppearance.BorderSize = 0
        Reservations_logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Reservations_logs.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Reservations_logs.ForeColor = System.Drawing.Color.White
        Reservations_logs.Location = New System.Drawing.Point(328, 486)
        Reservations_logs.Name = "Reservations_logs"
        Reservations_logs.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Reservations_logs.Size = New System.Drawing.Size(253, 52)
        Reservations_logs.TabIndex = 10
        Reservations_logs.Text = "VIEW RESERVATIONS"
        Reservations_logs.UseVisualStyleBackColor = False
        AddHandler Reservations_logs.Click, AddressOf Me.Reservations_logs_Click
        '
        'Return_btn
        '
        Return_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Return_btn.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.long_bg
        Return_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Return_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Return_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        Return_btn.FlatAppearance.BorderSize = 0
        Return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Return_btn.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Return_btn.ForeColor = System.Drawing.Color.White
        Return_btn.Location = New System.Drawing.Point(689, 486)
        Return_btn.Name = "Return_btn"
        Return_btn.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Return_btn.Size = New System.Drawing.Size(243, 52)
        Return_btn.TabIndex = 11
        Return_btn.Text = "RETURN BOOKS"
        Return_btn.UseVisualStyleBackColor = False
        AddHandler Return_btn.Click, AddressOf Me.Return_btn_Click
        '
        'Button3
        '
        Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Button3.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button3.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Button3.ForeColor = System.Drawing.Color.White
        Button3.Location = New System.Drawing.Point(1130, 17)
        Button3.Name = "Button3"
        Button3.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Button3.Size = New System.Drawing.Size(122, 52)
        Button3.TabIndex = 12
        Button3.Text = "LOGOUT"
        Button3.UseVisualStyleBackColor = False
        AddHandler Button3.Click, AddressOf Me.Button3_Click
        '
        'Button2
        '
        Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Button2.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button2.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Button2.ForeColor = System.Drawing.Color.White
        Button2.Location = New System.Drawing.Point(992, 17)
        Button2.Name = "Button2"
        Button2.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Button2.Size = New System.Drawing.Size(122, 52)
        Button2.TabIndex = 16
        Button2.Text = "LOGS"
        Button2.UseVisualStyleBackColor = False
        AddHandler Button2.Click, AddressOf Me.Button2_Click
        '
        'Returned_logs
        '
        Returned_logs.BackColor = System.Drawing.SystemColors.ActiveCaption
        Returned_logs.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.long_bg
        Returned_logs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Returned_logs.Cursor = System.Windows.Forms.Cursors.Hand
        Returned_logs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        Returned_logs.FlatAppearance.BorderSize = 0
        Returned_logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Returned_logs.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Returned_logs.ForeColor = System.Drawing.Color.White
        Returned_logs.Location = New System.Drawing.Point(960, 486)
        Returned_logs.Name = "Returned_logs"
        Returned_logs.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Returned_logs.Size = New System.Drawing.Size(243, 52)
        Returned_logs.TabIndex = 17
        Returned_logs.Text = "VIEW RETURNED"
        Returned_logs.UseVisualStyleBackColor = False
        AddHandler Returned_logs.Click, AddressOf Me.Returned_logs_Click
        '
        'Button1
        '
        Button1.AutoSize = True
        Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Button1.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.long_bg
        Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button1.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Button1.ForeColor = System.Drawing.Color.White
        Button1.Location = New System.Drawing.Point(195, 419)
        Button1.Name = "Button1"
        Button1.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Button1.Size = New System.Drawing.Size(243, 52)
        Button1.TabIndex = 19
        Button1.Text = "SAVE BOOKS TABLE"
        Button1.UseVisualStyleBackColor = False
        AddHandler Button1.Click, AddressOf Me.Button1_Click
        '
        'Button4
        '
        Button4.AutoSize = True
        Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Button4.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.long_bg
        Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(37, Byte), Integer))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button4.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Button4.ForeColor = System.Drawing.Color.White
        Button4.Location = New System.Drawing.Point(835, 419)
        Button4.Name = "Button4"
        Button4.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Button4.Size = New System.Drawing.Size(243, 52)
        Button4.TabIndex = 20
        Button4.Text = "SAVE USERS TABLE"
        Button4.UseVisualStyleBackColor = False
        AddHandler Button4.Click, AddressOf Me.Button4_Click
        '
        'bookView
        '
        Me.bookView.AllowUserToAddRows = False
        Me.bookView.AllowUserToDeleteRows = False
        Me.bookView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bookView.Location = New System.Drawing.Point(27, 128)
        Me.bookView.Name = "bookView"
        Me.bookView.ReadOnly = True
        Me.bookView.RowTemplate.Height = 25
        Me.bookView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.bookView.Size = New System.Drawing.Size(604, 275)
        Me.bookView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(27, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome Admin!"
        '
        'users_view
        '
        Me.users_view.AllowUserToAddRows = False
        Me.users_view.AllowUserToDeleteRows = False
        Me.users_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.users_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.users_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.users_view.Location = New System.Drawing.Point(648, 128)
        Me.users_view.Name = "users_view"
        Me.users_view.ReadOnly = True
        Me.users_view.RowTemplate.Height = 25
        Me.users_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.users_view.Size = New System.Drawing.Size(604, 275)
        Me.users_view.TabIndex = 2
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.Location = New System.Drawing.Point(537, 88)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(44, 34)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.TabStop = False
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.PenClip
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 40
        Me.IconButton3.Location = New System.Drawing.Point(587, 88)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(44, 34)
        Me.IconButton3.TabIndex = 5
        Me.IconButton3.TabStop = False
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.PenClip
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 40
        Me.IconButton4.Location = New System.Drawing.Point(1209, 88)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(44, 34)
        Me.IconButton4.TabIndex = 8
        Me.IconButton4.TabStop = False
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'IconButton6
        '
        Me.IconButton6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.IconButton6.IconColor = System.Drawing.Color.Black
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 40
        Me.IconButton6.Location = New System.Drawing.Point(1159, 88)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Size = New System.Drawing.Size(44, 34)
        Me.IconButton6.TabIndex = 6
        Me.IconButton6.TabStop = False
        Me.IconButton6.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 40
        Me.IconButton2.Location = New System.Drawing.Point(487, 88)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(44, 34)
        Me.IconButton2.TabIndex = 13
        Me.IconButton2.TabStop = False
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(27, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 47)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Books"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(648, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 47)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Users"
        '
        'IconButton5
        '
        Me.IconButton5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.IconButton5.IconColor = System.Drawing.Color.Black
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.Location = New System.Drawing.Point(438, 81)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Size = New System.Drawing.Size(43, 44)
        Me.IconButton5.TabIndex = 18
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1282, 548)
        Me.Controls.Add(Button4)
        Me.Controls.Add(Button1)
        Me.Controls.Add(Me.IconButton5)
        Me.Controls.Add(Returned_logs)
        Me.Controls.Add(Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Button3)
        Me.Controls.Add(Return_btn)
        Me.Controls.Add(Reservations_logs)
        Me.Controls.Add(r_btn)
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.IconButton6)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.users_view)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bookView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library System Home"
        CType(Me.bookView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.users_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bookView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents users_view As DataGridView
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
End Class
