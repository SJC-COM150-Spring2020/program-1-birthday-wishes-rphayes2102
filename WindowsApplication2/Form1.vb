Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        MessageBox.Show(" Thank You! " & txtName.Text)
        'Display in txtBox
        lstBox.Items.Add("Happy Birthday to you! ")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear lstbox value
        txtName.Clear()
        lstBox.Items.Clear()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'when the user exits the program
        Beep()
        Application.Exit()
    End Sub
End Class
