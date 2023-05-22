Imports System.Security.Cryptography
Imports System.Windows.Controls.Primitives
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class reserve_dialog
    Private conn As MySqlConnection
    Private Sub reserve_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=localhost;user=root;database=book_reservation;port=3306;password=@Hydrogn10;"
        conn = New MySqlConnection(connStr)
        conn.Open()

        'SELECT book_status INTO book_status FROM books WHERE book_reserve = book_id;
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rID As String = reader_textbox.Text
        Dim bID As String = book_textbox.Text

        If String.IsNullOrEmpty(bID) Or String.IsNullOrEmpty(rID) Then
            MsgBox("Sorry, all fields are required!")
        Else
            Dim selectedDate As Date = return_datepicker.Value
            Dim SdateOnly As DateOnly = DateOnly.FromDateTime(selectedDate)
            Dim SdateOnlyString As String = SdateOnly.ToString("yyyy-MM-dd")
            Dim returndate As Date = return_datepicker.Value
            Dim RdateOnly As DateOnly = DateOnly.FromDateTime(returndate)
            Dim RdateOnlyString As String = RdateOnly.ToString("yyyy-MM-dd")
            Dim books As New MySqlDataAdapter("SELECT book_status FROM books WHERE book_id = " + bID, conn)
            Dim books_ds As New DataSet()
            books.Fill(books_ds)
            Dim status As String = books_ds.Tables(0).Rows(0)("book_status").ToString()
            'MsgBox(status)

            If status = "RESERVED" Then
                MsgBox("Sorry, this book is already reserved!")
            Else
                Dim updateCmd As New MySqlCommand("UPDATE books SET book_status = 'RESERVED' WHERE book_id = " + bID, conn)
                updateCmd.ExecuteNonQuery()

                Dim insertCmd As New MySqlCommand("INSERT INTO book_reservations (book_id, reader_id, reservation_date, return_date, event_type) VALUES (" + bID + ", " + rID + ", '" + SdateOnlyString + "', '" + RdateOnlyString + "', 'RESERVED')", conn)
                insertCmd.ExecuteNonQuery()

                'Retrieve the name of the reserver and the reserved book title for the reservation log
                Dim nameCmd As New MySqlCommand("SELECT name FROM users_info WHERE reader_id = " + rID, conn)
                Dim reserverName As String = nameCmd.ExecuteScalar().ToString()
                Dim bookCmd As New MySqlCommand("SELECT title FROM books WHERE book_id = " + bID, conn)
                Dim reservedBook As String = bookCmd.ExecuteScalar().ToString()

                'Insert the reservation log into the reservation_logs table
                Dim latestIDCmd As New MySqlCommand("SELECT reservation_id FROM book_reservations WHERE reservation_id = (SELECT max(reservation_id) FROM book_reservations)", conn)
                Dim latestID As Integer = Convert.ToInt32(latestIDCmd.ExecuteScalar())

                Dim logCmd As New MySqlCommand("INSERT INTO reservation_logs (reservation_id, log_type, log_date, log_details) VALUES (" + latestID.ToString() + ", 'RESERVATION', NOW(), '" + reserverName + " reserved the book " + reservedBook + "')", conn)
                logCmd.ExecuteNonQuery()
                MessageBox.Show("Item has been successfully reserved!", "Reserved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                conn.Close()
            End If
        End If

    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub reserve_dialog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _rBtn.Enabled = True
        _homeForm.RefreshData()
    End Sub

    Private _rBtn As Button
    Private _homeForm As Home

    Public Sub New(rBtn As Button, homeForm As Home)
        InitializeComponent()
        _rBtn = rBtn
        _homeForm = homeForm
    End Sub

End Class
