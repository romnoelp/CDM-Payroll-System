﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Label2 = New Label()
        RegistrationTab = New TabControl()
        TabPage1 = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        Panel3 = New Panel()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RegistrationTab.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel3.SuspendLayout()
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
        Panel2.Location = New Point(503, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(280, 79)
        Panel2.TabIndex = 2
        ' 
        ' HeaderTitle
        ' 
        HeaderTitle.AutoSize = True
        HeaderTitle.Dock = DockStyle.Fill
        HeaderTitle.Font = New Font("Verdana", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HeaderTitle.ForeColor = Color.Transparent
        HeaderTitle.Location = New Point(0, 0)
        HeaderTitle.Margin = New Padding(3, 10, 3, 0)
        HeaderTitle.Name = "HeaderTitle"
        HeaderTitle.Size = New Size(281, 67)
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
        PictureBox2.Padding = New Padding(0, 10, 0, 10)
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(147, 111)
        Label2.Margin = New Padding(10, 0, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(356, 59)
        Label2.TabIndex = 3
        Label2.Text = "Registration"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RegistrationTab
        ' 
        RegistrationTab.Controls.Add(TabPage1)
        RegistrationTab.Controls.Add(TabPage2)
        RegistrationTab.Controls.Add(TabPage3)
        RegistrationTab.Location = New Point(300, 173)
        RegistrationTab.Name = "RegistrationTab"
        RegistrationTab.SelectedIndex = 0
        RegistrationTab.Size = New Size(664, 454)
        RegistrationTab.TabIndex = 4
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(TextBox5)
        TabPage1.Controls.Add(TextBox4)
        TabPage1.Controls.Add(Panel3)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(TextBox3)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(656, 426)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Basic info"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(140, 362)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 14
        Label8.Text = "Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(141, 301)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 23)
        Label7.TabIndex = 13
        Label7.Text = "Username"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(166, 249)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 23)
        Label6.TabIndex = 12
        Label6.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(155, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 23)
        Label5.TabIndex = 11
        Label5.Text = "Birthday"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(137, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 23)
        Label4.TabIndex = 10
        Label4.Text = "Last name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(113, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 23)
        Label3.TabIndex = 9
        Label3.Text = "Middle name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(134, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 23)
        Label1.TabIndex = 8
        Label1.Text = "First name"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.ControlLight
        TextBox5.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        TextBox5.Location = New Point(251, 359)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(281, 31)
        TextBox5.TabIndex = 7
        TextBox5.Text = "Password"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.ControlLight
        TextBox4.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        TextBox4.Location = New Point(252, 298)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(281, 31)
        TextBox4.TabIndex = 6
        TextBox4.Text = "Username"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(RadioButton3)
        Panel3.Controls.Add(RadioButton2)
        Panel3.Controls.Add(RadioButton1)
        Panel3.Location = New Point(251, 249)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(281, 27)
        Panel3.TabIndex = 5
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Dock = DockStyle.Right
        RadioButton3.Location = New Point(160, 0)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(121, 27)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Prefer not to"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Dock = DockStyle.Fill
        RadioButton2.Location = New Point(60, 0)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(221, 27)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Dock = DockStyle.Left
        RadioButton1.Location = New Point(0, 0)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(60, 27)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(252, 197)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(281, 27)
        DateTimePicker1.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ControlLight
        TextBox3.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        TextBox3.Location = New Point(251, 136)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(281, 31)
        TextBox3.TabIndex = 2
        TextBox3.Text = "Petracorta"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ControlLight
        TextBox2.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        TextBox2.Location = New Point(251, 81)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(281, 31)
        TextBox2.TabIndex = 1
        TextBox2.Text = "Edralin"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ControlLight
        TextBox1.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        TextBox1.Location = New Point(251, 30)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(281, 31)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Romnoel"
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(656, 426)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Institution"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(656, 426)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Identification"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' RegistrationPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(RegistrationTab)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegistrationPage"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RegistrationTab.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HeaderTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RegistrationTab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
