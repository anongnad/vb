Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim product1 As Integer
        Dim product2 As Integer
        Dim Sales As Integer
        Dim com1 As Integer
        Dim com2 As Integer
        Dim comsum As Integer
        product1 = txtVistra.Text
        product2 = txtFrista.Text
        Sales = product1 + product2
        com1 = product1 * 0.05
        com2 = product2 * 0.1
        comsum = com1 + com2
        lblSales1.Text = product1
        lblSales2.Text = product2
        lblsum.Text = Sales
        lblCommissions1.Text = com1
        lblCommissions2.Text = com2
        Commissionssum.Text = comsum

    End Sub
End Class