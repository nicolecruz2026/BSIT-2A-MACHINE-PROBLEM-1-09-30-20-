Public Class MPFRM03MARKLOUIERIVADENIERA

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim productamount, quantity, subtotal, discountamount, netamount As Double
        productamount = TextBox1.Text
        quantity = TextBox2.Text

        subtotal = productamount * quantity
        discountamount = subtotal * 0.2
        netamount = subtotal - discountamount
        TextBox3.Text = subtotal
        TextBox4.Text = discountamount
        TextBox5.Text = netamount
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class