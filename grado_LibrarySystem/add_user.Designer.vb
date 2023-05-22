<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_user))
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.name_label = New System.Windows.Forms.Label()
        Me.name_input = New System.Windows.Forms.TextBox()
        Me.email_label = New System.Windows.Forms.Label()
        Me.email_input = New System.Windows.Forms.TextBox()
        Me.phone_label = New System.Windows.Forms.Label()
        Me.phone_input = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        Me.Cancel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cancel_Button.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancel_Button.Location = New System.Drawing.Point(232, 305)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Me.Cancel_Button.Size = New System.Drawing.Size(113, 54)
        Me.Cancel_Button.TabIndex = 3
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        Me.OK_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OK_Button.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.OK_Button.Location = New System.Drawing.Point(120, 309)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Me.OK_Button.Size = New System.Drawing.Size(107, 47)
        Me.OK_Button.TabIndex = 2
        Me.OK_Button.Text = "Add"
        '
        'name_label
        '
        Me.name_label.AutoSize = True
        Me.name_label.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.name_label.Location = New System.Drawing.Point(36, 47)
        Me.name_label.Name = "name_label"
        Me.name_label.Size = New System.Drawing.Size(62, 27)
        Me.name_label.TabIndex = 8
        Me.name_label.Text = " Name"
        '
        'name_input
        '
        Me.name_input.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.name_input.Location = New System.Drawing.Point(45, 77)
        Me.name_input.Name = "name_input"
        Me.name_input.Size = New System.Drawing.Size(275, 39)
        Me.name_input.TabIndex = 7
        '
        'email_label
        '
        Me.email_label.AutoSize = True
        Me.email_label.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.email_label.Location = New System.Drawing.Point(36, 130)
        Me.email_label.Name = "email_label"
        Me.email_label.Size = New System.Drawing.Size(59, 27)
        Me.email_label.TabIndex = 10
        Me.email_label.Text = " Email"
        '
        'email_input
        '
        Me.email_input.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.email_input.Location = New System.Drawing.Point(45, 160)
        Me.email_input.Name = "email_input"
        Me.email_input.Size = New System.Drawing.Size(275, 39)
        Me.email_input.TabIndex = 9
        '
        'phone_label
        '
        Me.phone_label.AutoSize = True
        Me.phone_label.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.phone_label.Location = New System.Drawing.Point(36, 221)
        Me.phone_label.Name = "phone_label"
        Me.phone_label.Size = New System.Drawing.Size(130, 27)
        Me.phone_label.TabIndex = 12
        Me.phone_label.Text = " Phone number"
        '
        'phone_input
        '
        Me.phone_input.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.phone_input.Location = New System.Drawing.Point(45, 251)
        Me.phone_input.Name = "phone_input"
        Me.phone_input.Size = New System.Drawing.Size(275, 39)
        Me.phone_input.TabIndex = 11
        '
        'add_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(355, 365)
        Me.Controls.Add(Me.phone_label)
        Me.Controls.Add(Me.phone_input)
        Me.Controls.Add(Me.email_label)
        Me.Controls.Add(Me.email_input)
        Me.Controls.Add(Me.name_label)
        Me.Controls.Add(Me.name_input)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "add_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_user"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancel_Button As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents name_label As Label
    Friend WithEvents name_input As TextBox
    Friend WithEvents email_label As Label
    Friend WithEvents email_input As TextBox
    Friend WithEvents phone_label As Label
    Friend WithEvents phone_input As TextBox
End Class
