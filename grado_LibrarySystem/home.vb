Imports System.IO
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports ClosedXML.Excel
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ExportToExcel(bookView)
    End Sub

    Public Sub ExportToExcel(ByVal dataGridView As DataGridView)
        If dataGridView IsNot Nothing AndAlso dataGridView.Rows.Count > 0 Then
            ' Create a new workbook and worksheet
            Dim workbook As New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Sheet1")

            ' Write column headers to the worksheet
            For columnIndex As Integer = 0 To dataGridView.Columns.Count - 1
                worksheet.Cell(1, columnIndex + 1).Value = dataGridView.Columns(columnIndex).HeaderText
            Next

            ' Loop through the rows of the DataGridView and add them to the worksheet
            For rowIndex As Integer = 0 To dataGridView.Rows.Count - 1
                For columnIndex As Integer = 0 To dataGridView.Columns.Count - 1
                    worksheet.Cell(rowIndex + 2, columnIndex + 1).Value = If(dataGridView.Rows(rowIndex).Cells(columnIndex).Value IsNot Nothing, dataGridView.Rows(rowIndex).Cells(columnIndex).Value.ToString(), String.Empty)
                Next
            Next

            ' Save the Excel file to the root folder of the application
            Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, "ExcelTable", dataGridView.Name.ToString() & ".xlsx")
            workbook.SaveAs(filePath)
            MessageBox.Show("Data exported to " & filePath)

        Else
            MessageBox.Show("DataGridView is empty")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ExportToExcel(users_view)
    End Sub
End Class