Imports System.Drawing

Public Class RegistrationPage
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.ResizeRedraw, True)


    End Sub
    Private Sub RegistrationPage_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim radius As Integer = 25
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        gp.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        gp.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        gp.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        gp.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        Me.Region = New Region(gp)
    End Sub
End Class