Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles Button3.Paint
        Dim button As Button = DirectCast(sender, Button)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, button.Width - 1, button.Height - 1)
        button.Region = New Region(path)
    End Sub
    Private Sub Button4_Paint(sender As Object, e As PaintEventArgs) Handles Button4.Paint
        Dim button As Button = DirectCast(sender, Button)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, button.Width - 1, button.Height - 1)
        button.Region = New Region(path)
    End Sub
    Private Sub Button5_Paint(sender As Object, e As PaintEventArgs) Handles Button5.Paint
        Dim button As Button = DirectCast(sender, Button)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, button.Width - 1, button.Height - 1)
        button.Region = New Region(path)
    End Sub
    Private Sub Button6_Paint(sender As Object, e As PaintEventArgs) Handles Button6.Paint
        Dim button As Button = DirectCast(sender, Button)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, button.Width - 1, button.Height - 1)
        button.Region = New Region(path)
    End Sub
    Private Sub Button7_Paint(sender As Object, e As PaintEventArgs) Handles Button7.Paint
        Dim button As Button = DirectCast(sender, Button)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, button.Width - 1, button.Height - 1)
        button.Region = New Region(path)
    End Sub
    Private Sub Button8_Paint(sender As Object, e As PaintEventArgs) Handles Button8.Paint
        Dim button As Button = DirectCast(sender, Button)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, button.Width - 1, button.Height - 1)
        button.Region = New Region(path)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label22.BackColor = Color.Red
    End Sub
End Class