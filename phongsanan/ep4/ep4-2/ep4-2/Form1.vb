Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username, Pass As String
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        Pass = InputBox("กรุณาป้อนรหัสผ่าน")
        If Username = "นุ๊กเน้ต" And Pass = "1234" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\phongsanan\All_Images\photo02.jpg")
        ElseIf Username = "พงศนันท์" And Pass = "4567" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\phongsanan\All_Images\ChaiYo.jpg")
        ElseIf Username = "สมหญิง" And Pass = "6789" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\phongsanan\All_Images\photo01.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub
End Class
