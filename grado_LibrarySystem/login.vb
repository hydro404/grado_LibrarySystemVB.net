Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports System.Text

Public Class Login
    Private connStr As String = "server=localhost;user=root;database=book_reservation;port=3306;password=@Hydrogn10;"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If String.IsNullOrEmpty(username_textbox.Text) OrElse String.IsNullOrEmpty(password_textbox.Text) Then
            MsgBox("Please fill all the required fields.", MsgBoxStyle.Exclamation, "Empty Values")
        Else
            Try
                Using conn As New MySqlConnection(connStr)
                    conn.Open()

                    Dim query As String = "SELECT * FROM admin_credentials WHERE admin_username = @username;"

                    Using command As New MySqlCommand(query, conn)
                        command.Parameters.AddWithValue("@username", username_textbox.Text)

                        Using reader As MySqlDataReader = command.ExecuteReader()
                            If reader.HasRows Then
                                While reader.Read()
                                    Dim password As String = reader.GetString("admin_password").ToUpper

                                    ' convert the password to MD5
                                    Dim md5Hash As MD5 = MD5.Create()
                                    Dim passwordBytes As Byte() = Encoding.ASCII.GetBytes(password_textbox.Text)
                                    Dim hashedBytes As Byte() = md5Hash.ComputeHash(passwordBytes)
                                    Dim hashedPassword As String = BitConverter.ToString(hashedBytes).Replace("-", "")

                                    If hashedPassword = password Then
                                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Me.Hide()
                                        Dim homeForm As New Home
                                        homeForm.Show()
                                    Else
                                        MsgBox("Invalid username or password.")
                                    End If
                                End While
                            Else
                                MsgBox("Invalid username or password.")
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class