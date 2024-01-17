<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        GroupBox4 = New GroupBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        ErrorMessage = New Label()
        GroupBox3 = New GroupBox()
        GroupBox2 = New GroupBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        PictureBox4 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(GroupBox4)
        GroupBox1.Controls.Add(ErrorMessage)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Location = New Point(285, 89)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(812, 758)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.Control
        GroupBox4.Controls.Add(PictureBox4)
        GroupBox4.Controls.Add(PictureBox3)
        GroupBox4.Controls.Add(PictureBox2)
        GroupBox4.Controls.Add(PictureBox1)
        GroupBox4.Controls.Add(Button5)
        GroupBox4.Controls.Add(Button4)
        GroupBox4.Controls.Add(Button3)
        GroupBox4.Controls.Add(Button2)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Location = New Point(38, 152)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(728, 448)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Visible = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(512, 270)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(39, 33)
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(292, 270)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 33)
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(84, 270)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 33)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(276, 381)
        Button5.Name = "Button5"
        Button5.Size = New Size(177, 46)
        Button5.TabIndex = 6
        Button5.Text = "Log Out"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(493, 259)
        Button4.Name = "Button4"
        Button4.Size = New Size(172, 61)
        Button4.TabIndex = 4
        Button4.Text = "          Virus Status"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(281, 259)
        Button3.Name = "Button3"
        Button3.Size = New Size(155, 61)
        Button3.TabIndex = 3
        Button3.Text = "Alerts"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(74, 259)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 61)
        Button2.TabIndex = 2
        Button2.Text = "   Logs"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.Font = New Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(234, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(296, 35)
        Label4.TabIndex = 1
        Label4.Text = """Employee Name Here"""
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(138, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(493, 40)
        Label3.TabIndex = 0
        Label3.Text = "Welcome to Umbrella Corporation"
        ' 
        ' ErrorMessage
        ' 
        ErrorMessage.AutoSize = True
        ErrorMessage.ForeColor = Color.Brown
        ErrorMessage.Location = New Point(272, 377)
        ErrorMessage.Name = "ErrorMessage"
        ErrorMessage.Size = New Size(267, 25)
        ErrorMessage.TabIndex = 2
        ErrorMessage.Text = "Incorrect username or password"
        ErrorMessage.Visible = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), Image)
        GroupBox3.BackgroundImageLayout = ImageLayout.Center
        GroupBox3.ForeColor = SystemColors.ActiveCaptionText
        GroupBox3.Location = New Point(207, 30)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(399, 316)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(RichTextBox1)
        GroupBox2.Location = New Point(83, 402)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(638, 257)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Login"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(189, 109)
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "*"c
        TextBox1.Size = New Size(402, 31)
        TextBox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(236, 204)
        Button1.Name = "Button1"
        Button1.Size = New Size(177, 47)
        Button1.TabIndex = 4
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(29, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 26)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(29, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 26)
        Label1.TabIndex = 2
        Label1.Text = "Employee Code"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(189, 56)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(402, 32)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(276, 18)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(177, 123)
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1448, 891)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorMessage As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
