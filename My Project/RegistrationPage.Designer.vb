<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationPage))
        Panel1 = New Panel()
        Panel2 = New Panel()
        HeaderTitle = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(82), CByte(8))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(300, 5, 300, 5)
        Panel1.Size = New Size(1264, 96)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(HeaderTitle)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(503, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(280, 86)
        Panel2.TabIndex = 2
        ' 
        ' HeaderTitle
        ' 
        HeaderTitle.AutoSize = True
        HeaderTitle.Dock = DockStyle.Fill
        HeaderTitle.Font = New Font("Verdana", 39.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HeaderTitle.ForeColor = Color.Transparent
        HeaderTitle.Location = New Point(0, 0)
        HeaderTitle.Name = "HeaderTitle"
        HeaderTitle.Size = New Size(266, 65)
        HeaderTitle.TabIndex = 0
        HeaderTitle.Text = "CDMIPS"
        HeaderTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(783, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(181, 86)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(300, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(203, 86)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' RegistrationPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(Panel1)
        Name = "RegistrationPage"
        Text = "RegistrationPage"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HeaderTitle As Label
End Class
