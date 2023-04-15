<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reserve_dialog
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
        Dim OK_Button As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reserve_dialog))
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.readerID_label = New System.Windows.Forms.Label()
        Me.reader_textbox = New System.Windows.Forms.TextBox()
        Me.book_textbox = New System.Windows.Forms.TextBox()
        Me.bookID_label = New System.Windows.Forms.Label()
        Me.reserve_label = New System.Windows.Forms.Label()
        Me.reserve_datepicker = New System.Windows.Forms.DateTimePicker()
        Me.return_datepicker = New System.Windows.Forms.DateTimePicker()
        Me.return_label = New System.Windows.Forms.Label()
        OK_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        OK_Button.AutoSize = True
        OK_Button.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        OK_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        OK_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        OK_Button.FlatAppearance.BorderSize = 0
        OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        OK_Button.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        OK_Button.ForeColor = System.Drawing.Color.White
        OK_Button.Location = New System.Drawing.Point(125, 355)
        OK_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New System.Drawing.Size(108, 42)
        OK_Button.TabIndex = 5
        OK_Button.Text = "RESERVE"
        AddHandler OK_Button.Click, AddressOf Me.OK_Button_Click
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.AutoSize = True
        Me.Cancel_Button.BackgroundImage = Global.grado_LibrarySystem.My.Resources.Resources.login_btn
        Me.Cancel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cancel_Button.ForeColor = System.Drawing.Color.White
        Me.Cancel_Button.Location = New System.Drawing.Point(241, 355)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(112, 42)
        Me.Cancel_Button.TabIndex = 6
        Me.Cancel_Button.TabStop = False
        Me.Cancel_Button.Text = "CANCEL"
        '
        'readerID_label
        '
        Me.readerID_label.AutoSize = True
        Me.readerID_label.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.readerID_label.Location = New System.Drawing.Point(70, 30)
        Me.readerID_label.Name = "readerID_label"
        Me.readerID_label.Size = New System.Drawing.Size(94, 27)
        Me.readerID_label.TabIndex = 2
        Me.readerID_label.Text = " Reader ID"
        '
        'reader_textbox
        '
        Me.reader_textbox.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.reader_textbox.Location = New System.Drawing.Point(79, 60)
        Me.reader_textbox.Name = "reader_textbox"
        Me.reader_textbox.Size = New System.Drawing.Size(208, 39)
        Me.reader_textbox.TabIndex = 1
        '
        'book_textbox
        '
        Me.book_textbox.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.book_textbox.Location = New System.Drawing.Point(79, 141)
        Me.book_textbox.Name = "book_textbox"
        Me.book_textbox.Size = New System.Drawing.Size(208, 39)
        Me.book_textbox.TabIndex = 2
        '
        'bookID_label
        '
        Me.bookID_label.AutoSize = True
        Me.bookID_label.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bookID_label.Location = New System.Drawing.Point(70, 111)
        Me.bookID_label.Name = "bookID_label"
        Me.bookID_label.Size = New System.Drawing.Size(76, 27)
        Me.bookID_label.TabIndex = 4
        Me.bookID_label.Text = " Book ID"
        '
        'reserve_label
        '
        Me.reserve_label.AutoSize = True
        Me.reserve_label.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.reserve_label.Location = New System.Drawing.Point(70, 195)
        Me.reserve_label.Name = "reserve_label"
        Me.reserve_label.Size = New System.Drawing.Size(152, 27)
        Me.reserve_label.TabIndex = 6
        Me.reserve_label.Text = " Reservation Date"
        '
        'reserve_datepicker
        '
        Me.reserve_datepicker.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.reserve_datepicker.Location = New System.Drawing.Point(79, 225)
        Me.reserve_datepicker.MinDate = New Date(2023, 3, 10, 0, 0, 0, 0)
        Me.reserve_datepicker.Name = "reserve_datepicker"
        Me.reserve_datepicker.Size = New System.Drawing.Size(208, 23)
        Me.reserve_datepicker.TabIndex = 3
        Me.reserve_datepicker.Value = New Date(2023, 3, 10, 0, 0, 0, 0)
        '
        'return_datepicker
        '
        Me.return_datepicker.Location = New System.Drawing.Point(79, 297)
        Me.return_datepicker.Name = "return_datepicker"
        Me.return_datepicker.Size = New System.Drawing.Size(208, 23)
        Me.return_datepicker.TabIndex = 4
        '
        'return_label
        '
        Me.return_label.AutoSize = True
        Me.return_label.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.return_label.Location = New System.Drawing.Point(70, 267)
        Me.return_label.Name = "return_label"
        Me.return_label.Size = New System.Drawing.Size(110, 27)
        Me.return_label.TabIndex = 8
        Me.return_label.Text = " Return Date"
        '
        'reserve_dialog
        '
        Me.AcceptButton = OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(366, 426)
        Me.Controls.Add(Me.return_datepicker)
        Me.Controls.Add(Me.return_label)
        Me.Controls.Add(Me.reserve_datepicker)
        Me.Controls.Add(Me.reserve_label)
        Me.Controls.Add(Me.book_textbox)
        Me.Controls.Add(Me.bookID_label)
        Me.Controls.Add(Me.reader_textbox)
        Me.Controls.Add(Me.readerID_label)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "reserve_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserve a Book"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents readerID_label As Label
    Friend WithEvents reader_textbox As TextBox
    Friend WithEvents book_textbox As TextBox
    Friend WithEvents bookID_label As Label
    Friend WithEvents reserve_label As Label
    Friend WithEvents reserve_datepicker As DateTimePicker
    Friend WithEvents return_datepicker As DateTimePicker
    Friend WithEvents return_label As Label
End Class
