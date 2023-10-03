Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

		MsgBox(Val(TextBox1.Text) + Val(TextBox2.Text))
		Label3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
	End Sub

	Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
		MsgBox(Val(TextBox1.Text) - Val(TextBox2.Text))
	End Sub

	Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
		MsgBox("the division is =" & Val(TextBox1.Text) / Val(TextBox2.Text))
	End Sub

	Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
		MsgBox("The multiplication is = " & Val(TextBox1.Text) * Val(TextBox2.Text))
	End Sub



End Class
