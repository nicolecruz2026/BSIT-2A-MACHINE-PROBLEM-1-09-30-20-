Public Class MPFRM01MARKLOUIERIVADENIERA

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim n1, n2, sum As Double


        n1 = TextBox1.Text
        n2 = TextBox2.Text

        sum = n1 + n2

        TextBox3.Text = sum
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim n1, n2, sum As Double

        n1 = TextBox1.Text
        n2 = TextBox2.Text

        sum = n1 - n2

        TextBox3.Text = sum
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim n1, n2, sum As Double


        n1 = TextBox1.Text
        n2 = TextBox2.Text

        sum = n1 * n2

        TextBox3.Text = sum
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim n1, n2, sum As Double


        n1 = TextBox1.Text
        n2 = TextBox2.Text

        sum = n1 / n2

        TextBox3.Text = sum
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim n1, n2, sum As Double


        n1 = TextBox1.Text
        n2 = TextBox2.Text

        sum = n1 Mod n2

        TextBox3.Text = sum
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim n1, n2, sum As Double


        n1 = TextBox1.Text
        n2 = TextBox2.Text

        sum = n1 \ n2

        TextBox3.Text = sum
    End Sub
End Class