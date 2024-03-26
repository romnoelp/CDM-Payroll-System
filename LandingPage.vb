Imports System.Drawing.Drawing2D

Public Class LandingPage

    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeRoundedControl(CDMPic, 25)
        MakeRoundedControl(TopPanel, 25)
        MakeRoundedControl(PanelA, 25)
        MakeRoundedControl(PanelB, 25)
        MakeRoundedControl(PanelC, 25)
        MakeRoundedControl(NamePanel, 10)
        MakeRoundedControl(StartPanel, 10)
        MakeRoundedControl(EndPanel, 10)
        MakeRoundedControl(Me, 25)

        UpdateDateLabel()
    End Sub

    Private Sub MakeRoundedControl(control As Control, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        Dim rectangle As Rectangle = New Rectangle(0, 0, control.Width, control.Height)
        Dim radius As Integer = cornerRadius

        path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90)
        path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90)
        path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0, 90)
        path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90, 90)

        path.CloseFigure()

        control.Region = New Region(path)
    End Sub

    Private Sub UpdateDateLabel()
        Dim todayDate As String = Date.Today.ToString("dddd, MMMM dd, yyyy")
        DateLabel.Text = "Today is " & todayDate
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
End Class
