Imports System.Windows.Controls
Imports MySql.Data.MySqlClient
Public Class view_reservations
    Private conn As MySqlConnection
    Private homeForm As Home
    Private r_btn As Windows.Forms.Button

    Private Sub view_reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=localhost;user=root;database=book_reservation;port=3306;password=@Hydrogn10;"
        conn = New MySqlConnection(connStr)
        Dim da As New MySqlDataAdapter("SELECT * FROM reservation_logs", conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        rlogs_dgv.DataSource = dt
        rlogs_dgv.RowHeadersVisible = False
    End Sub

    Private Sub view_reservations_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim homeForm As Home = DirectCast(Application.OpenForms("Home"), Home)
        r_btn.Enabled = True
        homeForm.RefreshData()
        conn.Close()
    End Sub

    Public Sub New(r_btn As Windows.Forms.Button, ByVal homeForm As Home)
        InitializeComponent()
        Me.homeForm = homeForm
        Me.r_btn = r_btn
    End Sub
End Class