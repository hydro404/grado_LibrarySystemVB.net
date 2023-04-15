Imports System.Reflection.Metadata
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Windows.Controls.Primitives

Public Class return_dialog
    Private conn As MySqlConnection
    Private homeForm As Home
    Private r_btn As Windows.Forms.Button

    Private Sub return_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=localhost;user=root;database=book_reservation;port=3306;password=@Hydrogn10;"
        conn = New MySqlConnection(connStr)
        conn.Open()
    End Sub


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim rID As String = return_readerID.Text
        Dim bID As String = return_bookID.Text

        If String.IsNullOrEmpty(bID) Or String.IsNullOrEmpty(rID) Then
            MsgBox("Sorry, all fields are required!")

        Else

            Dim books As New MySqlDataAdapter("SELECT book_status FROM books WHERE book_id = " + bID, conn)
            Dim books_ds As New DataSet()
            books.Fill(books_ds)
            Dim status As String = books_ds.Tables(0).Rows(0)("book_status").ToString()


            If status = "OPEN" Then
                MsgBox("Sorry, this book is not currently borrowed!")
            Else
                Dim readerCmd As New MySqlCommand("SELECT reader_id FROM book_reservations WHERE book_id = " + bID + " ORDER BY reservation_id DESC", conn)
                Dim borrowerID As String = readerCmd.ExecuteScalar().ToString()

                If borrowerID <> rID Then
                    MsgBox("Sorry, the readerID and bookID do not match!")
                Else
                    Dim updateCmd As New MySqlCommand("UPDATE books SET book_status = 'OPEN' WHERE book_id = " + bID, conn)
                    updateCmd.ExecuteNonQuery()

                    Dim nameCmd As New MySqlCommand("SELECT name FROM users_info WHERE reader_id = " + rID, conn)
                    Dim reserverName As String = nameCmd.ExecuteScalar().ToString()
                    Dim bookCmd As New MySqlCommand("SELECT title FROM books WHERE book_id = " + bID, conn)
                    Dim returnedBook As String = bookCmd.ExecuteScalar().ToString()

                    Dim logCmd As New MySqlCommand("INSERT INTO return_logs (log_type, log_date, log_details) VALUES ('RETURNED', NOW(), '" + reserverName + " returned the book " + returnedBook + "')", conn)
                    logCmd.ExecuteNonQuery()

                    Dim auditLog As New MySqlCommand("INSERT INTO audit_log (event_type, event_date, table_name, description) VALUES ('RETURNED', NOW(), 'return_logs', '" + reserverName + " returned the book " + returnedBook + "')", conn)
                    auditLog.ExecuteNonQuery()

                    MessageBox.Show("Item has been successfully returned!", "Returned!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    conn.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub return_dialog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim homeForm As Home = DirectCast(Application.OpenForms("Home"), Home)
        r_btn.Enabled = True
        homeForm.RefreshData()
    End Sub

    Public Sub New(r_btn As Windows.Forms.Button, ByVal homeForm As Home)
        InitializeComponent()
        Me.homeForm = homeForm
        Me.r_btn = r_btn
    End Sub
End Class
