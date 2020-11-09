Public Class MPFRM04MARKLOUIERIVADENIERA

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim base, power, total As Double

        base = TextBox1.Text
        power = TextBox2.Text


        total = base ^ power

        TextBox3.Text = total
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Const π As Double = 3.1416
        Dim r, Area As Double

        r = TextBox4.Text

        Area = π * r ^ 2

        TextBox5.Text = Format(Area, "####.00")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim r, Diameter As Double

        r = TextBox4.Text

        Diameter = 2 * r

        TextBox7.Text = Format(Diameter, "####.00")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim π As Double = 3.1416
        Dim r, Circumference As Double

        r = TextBox4.Text

        Circumference = 2 * π * r

        TextBox6.Text = Format(Circumference, "####.00")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
