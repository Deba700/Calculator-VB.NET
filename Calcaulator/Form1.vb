Public Class Form1
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click


        Dim BtnValue As Button = CType(sender, Button)
        TextBox1.Text &= BtnValue.Text


    End Sub

    Private Sub Btn10_Zero(sender As Object, e As EventArgs) Handles Btn10.Click

        If TextBox1.Text = String.Empty Then

        Else
            TextBox1.Text &= "0"
        End If
    End Sub

    Private Sub Btn11_Decimal(sender As Object, e As EventArgs) Handles Btn11.Click
        If TextBox1.Text = String.Empty Then
            TextBox1.Text &= "0."
        ElseIf Not TextBox1.Text.Contains(".") Then
            TextBox1.Text &= "."
        End If
    End Sub

    Private Sub Btn12_Clear(sender As Object, e As EventArgs) Handles Btn12.Click
        TextBox1.Text = String.Empty

    End Sub

    Private Sub Operators(sender As Object, e As EventArgs) Handles BtnPlus.Click, BtnMinus.Click, BtnMultiplication.Click, BtnDevide.Click
        TextBox1.Text &= CType(sender, Button).Text

    End Sub

    Private Sub EqualsToClick(sender As Object, e As EventArgs) Handles Btn17.Click
        Try
            Dim exprassion As String = TextBox1.Text
            Dim result As Object
            Dim table As New DataTable
            result = table.Compute(exprassion, String.Empty)
            TextBox1.Text = result.ToString
        Catch ex As Exception
            TextBox1.Text = "Eroor"
        End Try


    End Sub
End Class
