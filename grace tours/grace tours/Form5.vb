Public Class Form5
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox6.Text = ((TextBox1.Text * 900) + (TextBox2.Text * 0) + (TextBox3.Text * 650)) * TextBox4.Text
        If TextBox5.Text = "night" Then
            TextBox6.Text = TextBox6.Text + 1000
        Else
            TextBox6.Text = TextBox6.Text + 0
        End If



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

        Form2.Show()

    End Sub
End Class