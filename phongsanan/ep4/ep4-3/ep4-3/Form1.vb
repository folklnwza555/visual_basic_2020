Public Class Form1
    Dim Price, Num, Total As Double
    Dim Stamp As Byte

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Price = TextBox1.Text
        Num = TextBox2.Text

        Total = Price * Num
        Stamp = Total / 50

        Label5.Text = Total
        Label6.Text = Stamp
    End Sub
End Class
