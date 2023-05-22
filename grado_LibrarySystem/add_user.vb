Imports MySql.Data.MySqlClient

Public Class add_user
    Private conn As MySqlConnection
    Private Sub add_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=localhost;user=root;database=book_reservation;port=3306;password=@Hydrogn10;"
        conn = New MySqlConnection(connStr)
        conn.Open()
    End Sub
    Private _rBtn As Button
    Private _homeForm As Home

    Public Sub New(rBtn As Button, homeForm As Home)
        InitializeComponent()
        _rBtn = rBtn
        _homeForm = homeForm
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Dim name As String = name_input.Text
        Dim email As String = email_input.Text
        Dim phone As String = phone_input.Text

        If String.IsNullOrEmpty(name) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(phone) Then
            MsgBox("Sorry, all fields are required!")
        Else
            Dim query As String = "SELECT name, phone FROM users_info WHERE name = '" + name + "' AND phone ='" + phone + "'"
            Dim booksAdapter As New MySqlDataAdapter(query, conn)
            Dim booksTable As New DataTable()
            booksAdapter.Fill(booksTable)

            If booksTable.Rows.Count > 0 Then
                MsgBox("User already exists in the database!")

            Else
                Dim addCmd As New MySqlCommand("INSERT INTO users_info (name, email, phone) VALUES (@name, @email, @phone)", conn)
                addCmd.Parameters.AddWithValue("@name", name)
                addCmd.Parameters.AddWithValue("@email", email)
                addCmd.Parameters.AddWithValue("@phone", phone)
                addCmd.ExecuteNonQuery()

                MessageBox.Show("User has been successfully added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                conn.Close()
            End If


        End If
    End Sub

    Private Sub add_user_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _rBtn.Enabled = True
        _homeForm.RefreshData()
    End Sub
End Class