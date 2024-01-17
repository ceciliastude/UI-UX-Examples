Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim employeeCode As String
        Dim password As String
        Dim correctEmployeeCode As String
        Dim correctPassword As String
        Dim numberText As String = RichTextBox1.Text
        Dim number1 As Integer
        Dim number2 As Integer

        employeeCode = numberText
        password = TextBox1.Text

        If numberText.StartsWith("IT22-") AndAlso numberText.Length = 7 AndAlso Integer.TryParse(numberText.Substring(5, 1), number1) AndAlso Integer.TryParse(numberText.Substring(6, 1), number2) Then
            correctEmployeeCode = "IT22-" & number1.ToString() & number2.ToString()
            correctPassword = "umbrella"

            ' Validate employee code and hashed password
            If employeeCode = correctEmployeeCode AndAlso password = correctPassword Then
                GroupBox2.Hide()
                GroupBox3.Hide()
                GroupBox4.Show()

            Else
                ' Incorrect password
                ErrorMessage.Show()
            End If
        Else
            ' Incorrect employee code
            ErrorMessage.Show()
        End If

        Select Case employeeCode
            Case "IT22-00"
                Label4.Text = "Hulk"
            Case "IT22-01"
                Label4.Text = "Batman"
            Case "IT22-02"
                Label4.Text = "Red Hood"
            Case "IT22-03"
                Label4.Text = "Scarlet Witch"
            Case "IT22-04"
                Label4.Text = "The Punisher"
            Case "IT22-08"
                Label4.Text = "Valkyrie"
            Case "IT22-09"
                Label4.Text = "Doctor Strange"
            Case "IT22-11"
                Label4.Text = "Loki"
            Case "IT22-12"
                Label4.Text = "Spawn"
            Case "IT22-13"
                Label4.Text = "Joker"
            Case "IT22-14"
                Label4.Text = "Domino"
            Case "IT22-16"
                Label4.Text = "Starlord"
            Case "IT22-18"
                Label4.Text = "He-Man"
            Case "IT22-21"
                Label4.Text = "Aquaman"
            Case Else
                Label4.Text = "Unknown Employee"
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Hide()
        TextBox1.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()
    End Sub


End Class
