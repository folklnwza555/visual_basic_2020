Public Class Form1
    Dim Price, Buy, Total, Pay, Change As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Price = TextBox1.Text
        Buy = TextBox2.Text
        Pay = TextBox4.Text

        Total = Price * Buy
        Change = Pay - Total

        Label6.Text = Total
        Label7.Text = Change

    End Sub
End Class
