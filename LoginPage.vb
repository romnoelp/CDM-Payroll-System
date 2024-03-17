Public Class LoginPage
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        PasswordField.UseSystemPasswordChar = False
        UsernameField.Font = New Font("Verdana", 16.0F, FontStyle.Regular)
        PasswordField.Font = New Font("Verdana", 16.0F, FontStyle.Regular) ' Test comment 
    End Sub

    Private Sub UsernameField_Enter(sender As Object, e As EventArgs) Handles UsernameField.Enter
        If UsernameField.Text = "Username" Then
            UsernameField.Text = ""
            UsernameField.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UsernameField_Leave(sender As Object, e As EventArgs) Handles UsernameField.Leave
        If UsernameField.Text = "" Then
            UsernameField.Text = "Username"
            UsernameField.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub PasswordField_Enter(sender As Object, e As EventArgs) Handles PasswordField.Enter
        If PasswordField.Text = "Password" Then
            PasswordField.Text = ""
            PasswordField.UseSystemPasswordChar = True ' Hide characters with asterisks
            PasswordField.ForeColor = Color.Black
        End If
    End Sub

    Private Sub PasswordField_Leave(sender As Object, e As EventArgs) Handles PasswordField.Leave
        If PasswordField.Text = "" Then
            PasswordField.Text = "Password"
            PasswordField.UseSystemPasswordChar = False ' Show placeholder text
            PasswordField.ForeColor = Color.Silver
        End If
    End Sub
End Class
