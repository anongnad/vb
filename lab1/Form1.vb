Public Class Form

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lbl5.Text = Val(tb1.Text) * 12
        lbl6.Text = Val(tb1.Text) * 12 * 0.05
        lbl7.Text = (Val(tb1.Text) * 12) - (Val(tb1.Text) * 12 * 0.05)

    End Sub
<<<<<<< HEAD

    Private Sub tb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb1.TextChanged

    End Sub
=======
>>>>>>> master
End Class
