Imports System.IO
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports MySql.Data.MySqlClient

Public Class Home
    Private conn As MySqlConnection

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=localhost;user=root;database=book_reservation;port=3306;password=@Hydrogn10;"
        conn = New MySqlConnection(connStr)
        Dim da As New MySqlDataAdapter("SELECT * FROM books", conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        bookView.DataSource = dt
        bookView.RowHeadersVisible = False

        Dim da2 As New MySqlDataAdapter("SELECT * FROM users_info", conn)
        Dim dt2 As New DataTable()
        da2.Fill(dt2)
        users_view.DataSource = dt2
        users_view.RowHeadersVisible = False

    End Sub


    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conn.Close()
        Application.Exit()
    End Sub

    Private Sub Reserve_btn_Click(sender As Object, e As EventArgs)
        Dim r_btn As Windows.Forms.Button = DirectCast(sender, Windows.Forms.Button)
        r_btn.Enabled = False
        Dim popup As New reserve_dialog(r_btn, Me)
        popup.Show()
    End Sub

    Public Sub RefreshData()
        Dim da As New MySqlDataAdapter("SELECT * FROM books", conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        bookView.DataSource = dt

        Dim da2 As New MySqlDataAdapter("SELECT * FROM users_info", conn)
        Dim dt2 As New DataTable()
        da2.Fill(dt2)
        users_view.DataSource = dt2
    End Sub

    Private Sub Return_btn_Click(sender As Object, e As EventArgs)
        Dim r_btn As Windows.Forms.Button = DirectCast(sender, Windows.Forms.Button)
        r_btn.Enabled = False
        Dim popup As New return_dialog(r_btn, Me)
        popup.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim r_btn As Windows.Forms.Button = DirectCast(sender, Windows.Forms.Button)
        r_btn.Enabled = False
        Dim popup As New view_logs(r_btn, Me)
        popup.Show()
    End Sub

    Private Sub Reservations_logs_Click(sender As Object, e As EventArgs)
        Dim r_btn As Windows.Forms.Button = DirectCast(sender, Windows.Forms.Button)
        r_btn.Enabled = False
        Dim popup As New view_reservations(r_btn, Me)
        popup.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Returned_logs_Click(sender As Object, e As EventArgs)
        Dim r_btn As Windows.Forms.Button = DirectCast(sender, Windows.Forms.Button)
        r_btn.Enabled = False
        Dim popup As New view_returned(r_btn, Me)
        popup.Show()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Dim r_btn As Windows.Forms.Button = DirectCast(sender, Windows.Forms.Button)
        r_btn.Enabled = False
        Dim popup As New upload_backup(r_btn, Me)
        popup.Show()
    End Sub
End Class