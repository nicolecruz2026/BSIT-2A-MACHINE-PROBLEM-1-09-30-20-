Public Class MPFRM02MARKLOUIERIVADENIERA

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim prelim, finals, midterm, result As Double

        prelim = TextBox1.Text
        midterm = TextBox2.Text
        finals = TextBox3.Text
        result = (((prelim + midterm) / 2) + finals) / 2

        TextBox4.Text = result

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class