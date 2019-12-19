Public Class Form1
    Dim lista As New List(Of String)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("PROVINCIA: " & TextBox1.Text)
        ListBox1.Items.Add("CIUDAD: " & TextBox2.Text)
        ListBox1.Items.Add("POBLACION: " & TextBox3.Text)
        TextBox4.Text = TextBox1.Text
        TextBox5.Text = TextBox2.Text
        TextBox6.Text = TextBox3.Text
        TextBox7.Text = TextBox1.Text
        TextBox8.Text = TextBox2.Text
        TextBox9.Text = TextBox3.Text
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each item As String In lista
            Me.ListBox1.Items.Add(item)
        Next item
    End Sub


End Class
