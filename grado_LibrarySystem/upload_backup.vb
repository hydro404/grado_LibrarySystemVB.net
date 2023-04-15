Imports System.IO
Imports MySql.Data.MySqlClient

Public Class upload_backup
    Private homeForm As Home
    Private r_btn As Windows.Forms.Button
    Private Sub uploadFile_btn_Click(sender As Object, e As EventArgs) Handles uploadFile_btn.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        openFileDialog.ShowDialog()

        ' If the user selected a file, read it into a DataTable and bind it to the DataGridView.
        If openFileDialog.FileName <> "" Then
            Dim dt As New DataTable()
            Dim fileReader As New StreamReader(openFileDialog.FileName)
            Dim line As String = fileReader.ReadLine()
            Dim columns As String() = line.Split(",")
            For Each column As String In columns
                dt.Columns.Add(column.Trim())
            Next
            While Not fileReader.EndOfStream
                line = fileReader.ReadLine()
                Dim fields As String() = line.Split(",")
                dt.Rows.Add(fields)
            End While
            fileReader.Close()
            dgvCsv.DataSource = dt
        End If
    End Sub

    Public Sub New(r_btn As Windows.Forms.Button, ByVal homeForm As Home)
        InitializeComponent()
        Me.homeForm = homeForm
        Me.r_btn = r_btn
    End Sub

    Private Sub upload_backup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim homeForm As Home = DirectCast(Application.OpenForms("Home"), Home)
        r_btn.Enabled = True
        homeForm.RefreshData()
    End Sub

    Private Sub backup_btn_Click(sender As Object, e As EventArgs) Handles backup_btn.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim connStr As String = "server=localhost;user=root;database=book_reservation;port=3306;password=@Hydrogn10;"
            Dim conn = New MySqlConnection(connStr)
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = conn
            conn.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            conn.Close()
            MessageBox.Show("Database Successfully Backup!", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
    End Sub
End Class