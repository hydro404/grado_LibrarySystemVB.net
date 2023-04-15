<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class return_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(return_dialog))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.return_readerID = New System.Windows.Forms.TextBox()
        Me.return_bookID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        Me.OK_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OK_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OK_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.OK_Button.Location = New System.Drawing.Point(129, 347)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(113, 48)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.TabStop = False
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        Me.Cancel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cancel_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cancel_Button.Location = New System.Drawing.Point(240, 347)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(113, 48)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.TabStop = False
        Me.Cancel_Button.Text = "CANCEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(68, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = " Reader ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(68, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " Book ID"
        '
        'return_readerID
        '
        Me.return_readerID.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.return_readerID.Location = New System.Drawing.Point(77, 133)
        Me.return_readerID.Name = "return_readerID"
        Me.return_readerID.Size = New System.Drawing.Size(208, 39)
        Me.return_readerID.TabIndex = 4
        '
        'return_bookID
        '
        Me.return_bookID.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.return_bookID.Location = New System.Drawing.Point(77, 214)
        Me.return_bookID.Name = "return_bookID"
        Me.return_bookID.Size = New System.Drawing.Size(208, 39)
        Me.return_bookID.TabIndex = 5
        '
        'return_dialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(366, 426)
        Me.Controls.Add(Me.return_bookID)
        Me.Controls.Add(Me.return_readerID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "return_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return a Book"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents return_readerID As TextBox
    Friend WithEvents return_bookID As TextBox
End Class
