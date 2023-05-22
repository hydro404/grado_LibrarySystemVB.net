Imports System.Reflection.Metadata
Imports MySql.Data.MySqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_book
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

    Friend WithEvents Cancel_Button As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents title_input As TextBox
    Friend WithEvents title_label As Label
    Friend WithEvents author_label As Label
    Friend WithEvents author_input As TextBox
    Friend WithEvents genre_label As Label
    Friend WithEvents genre_input As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pubyear_input As DateTimePicker

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_book))
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.title_input = New System.Windows.Forms.TextBox()
        Me.title_label = New System.Windows.Forms.Label()
        Me.author_label = New System.Windows.Forms.Label()
        Me.author_input = New System.Windows.Forms.TextBox()
        Me.genre_label = New System.Windows.Forms.Label()
        Me.genre_input = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pubyear_input = New System.Windows.Forms.DateTimePicker()
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
        Me.Cancel_Button.Location = New System.Drawing.Point(297, 340)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Me.Cancel_Button.Size = New System.Drawing.Size(113, 54)
        Me.Cancel_Button.TabIndex = 1
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
        Me.OK_Button.Location = New System.Drawing.Point(190, 344)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Padding = New System.Windows.Forms.Padding(5, 6, 5, 0)
        Me.OK_Button.Size = New System.Drawing.Size(107, 47)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'title_input
        '
        Me.title_input.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title_input.Location = New System.Drawing.Point(74, 52)
        Me.title_input.Name = "title_input"
        Me.title_input.Size = New System.Drawing.Size(275, 39)
        Me.title_input.TabIndex = 5
        '
        'title_label
        '
        Me.title_label.AutoSize = True
        Me.title_label.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title_label.Location = New System.Drawing.Point(65, 22)
        Me.title_label.Name = "title_label"
        Me.title_label.Size = New System.Drawing.Size(50, 27)
        Me.title_label.TabIndex = 6
        Me.title_label.Text = " Title"
        '
        'author_label
        '
        Me.author_label.AutoSize = True
        Me.author_label.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.author_label.Location = New System.Drawing.Point(65, 99)
        Me.author_label.Name = "author_label"
        Me.author_label.Size = New System.Drawing.Size(68, 27)
        Me.author_label.TabIndex = 7
        Me.author_label.Text = " Author"
        '
        'author_input
        '
        Me.author_input.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.author_input.Location = New System.Drawing.Point(74, 129)
        Me.author_input.Name = "author_input"
        Me.author_input.Size = New System.Drawing.Size(275, 39)
        Me.author_input.TabIndex = 8
        '
        'genre_label
        '
        Me.genre_label.AutoSize = True
        Me.genre_label.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.genre_label.Location = New System.Drawing.Point(65, 177)
        Me.genre_label.Name = "genre_label"
        Me.genre_label.Size = New System.Drawing.Size(65, 27)
        Me.genre_label.TabIndex = 9
        Me.genre_label.Text = " Genre"
        '
        'genre_input
        '
        Me.genre_input.Font = New System.Drawing.Font("Sans Serif Collection", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.genre_input.Location = New System.Drawing.Point(74, 207)
        Me.genre_input.Name = "genre_input"
        Me.genre_input.Size = New System.Drawing.Size(275, 39)
        Me.genre_input.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(68, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 27)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = " Published Year"
        '
        'pubyear_input
        '
        Me.pubyear_input.CustomFormat = "yyyy"
        Me.pubyear_input.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.pubyear_input.Location = New System.Drawing.Point(74, 289)
        Me.pubyear_input.Name = "pubyear_input"
        Me.pubyear_input.Size = New System.Drawing.Size(275, 23)
        Me.pubyear_input.TabIndex = 13
        '
        'add_book
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(419, 406)
        Me.Controls.Add(Me.pubyear_input)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.genre_input)
        Me.Controls.Add(Me.genre_label)
        Me.Controls.Add(Me.author_input)
        Me.Controls.Add(Me.author_label)
        Me.Controls.Add(Me.title_label)
        Me.Controls.Add(Me.title_input)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "add_book"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add a Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private conn As MySqlConnection
    Private Sub add_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=localhost;user=root;database=book_reservation;port=3306;password=@Hydrogn10;"
        conn = New MySqlConnection(connStr)
        conn.Open()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click

        Dim title As String = title_input.Text
        Dim author As String = author_input.Text
        Dim genre As String = genre_input.Text
        Dim selectedYear As Integer = pubyear_input.Value.Year

        If String.IsNullOrEmpty(title) Or String.IsNullOrEmpty(author) Or String.IsNullOrEmpty(genre) Then
            MsgBox("Sorry, all fields are required!")
        Else
            Dim query As String = "SELECT title, author FROM books WHERE title = '" + title + "' AND author ='" + author + "'"
            Dim booksAdapter As New MySqlDataAdapter(query, conn)
            Dim booksTable As New DataTable()
            booksAdapter.Fill(booksTable)

            If booksTable.Rows.Count > 0 Then
                MsgBox(title)
                MsgBox(author)
                MsgBox("Title already exists in the database!")

            Else
                Dim addCmd As New MySqlCommand("INSERT INTO books (title, author, genre, pub_year, book_status) VALUES (@title, @author, @genre, @pub_year, 'OPEN')", conn)
                addCmd.Parameters.AddWithValue("@title", title)
                addCmd.Parameters.AddWithValue("@author", author)
                addCmd.Parameters.AddWithValue("@genre", genre)
                addCmd.Parameters.AddWithValue("@pub_year", selectedYear)
                addCmd.ExecuteNonQuery()

                MessageBox.Show("Book has been successfully added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                conn.Close()
            End If


        End If


    End Sub


    Private Sub title_label_Click(sender As Object, e As EventArgs) Handles title_label.Click

    End Sub

    Private _rBtn As Button
    Private _homeForm As Home

    Public Sub New(rBtn As Button, homeForm As Home)
        InitializeComponent()
        _rBtn = rBtn
        _homeForm = homeForm
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        _rBtn.Enabled = True
        _homeForm.RefreshData()
    End Sub

    Private Sub add_book_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _rBtn.Enabled = True
        _homeForm.RefreshData()
    End Sub
End Class
