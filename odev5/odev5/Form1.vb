Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Visible = True
        Label7.Text = TextBox1.Text
        Label8.Text = TextBox2.Text
        If RadioButton1.Checked Then
            Label9.Text = RadioButton1.Text
        End If
        If RadioButton2.Checked Then
            Label9.Text = RadioButton2.Text
        End If
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
    End Sub
End Class
