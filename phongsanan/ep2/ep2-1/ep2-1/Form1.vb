Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String
        FirstName = "Phongsanan"
        Label1.Text = FirstName
        FirstName = "Thunyachalern"
        Label2.Text = FirstName
        FirstName = "Folk"
        Label3.Text = FirstName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(Prompt)
        Label1.Text = FullName
        Prompt = "กรุณาป้อนชื่อเล่น"
        FullName = InputBox(Prompt)
        Label3.Text = FullName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(Prompt)
        MsgBox(FullName, , "ชื่อและนามสกุลของคุณ")
    End Sub
End Class
