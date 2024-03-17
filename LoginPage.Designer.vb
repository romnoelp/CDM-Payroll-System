<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Panel1 = New Panel()
        Panel4 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Button1 = New Button()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(384, 88)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label1)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(100, 0)
        Panel4.Margin = New Padding(4, 3, 4, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(184, 88)
        Panel4.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Verdana", 27F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 88)
        Label1.TabIndex = 1
        Label1.Text = "CDMIPS"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Panel3.Controls.Add(PictureBox2)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(284, 0)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(2, 10, 0, 10)
        Panel3.Size = New Size(100, 88)
        Panel3.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(2, 10)
        PictureBox2.Margin = New Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(98, 68)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(4, 3, 0, 3)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 8, 4, 8)
        Panel2.Size = New Size(100, 88)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 8)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 72)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 88)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(384, 224)
        Panel5.TabIndex = 5
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Navy
        Panel6.Controls.Add(Panel8)
        Panel6.Controls.Add(Panel7)
        Panel6.Controls.Add(Button1)
        Panel6.Location = New Point(12, 320)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(360, 113)
        Panel6.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(116, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 39)
        Button1.TabIndex = 0
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(119, 113)
        Panel7.TabIndex = 1
        ' 
        ' Panel8
        ' 
        Panel8.Dock = DockStyle.Right
        Panel8.Location = New Point(241, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(119, 113)
        Panel8.TabIndex = 2
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(253), CByte(246))
        ClientSize = New Size(384, 445)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "LoginPage"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel8 As Panel

End Class
