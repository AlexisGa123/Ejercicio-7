Public Class Form1
    Dim num, cuenta, posicionMayor As Integer
    Dim contadorPar As Integer = 0
    Dim mayor As Integer = 0
        num = TextBox1.Text
        If num Mod 2 = 0 Then
            contadorPar += 1
        End If
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If num > mayor Then
            mayor = num
            posicionMayor = cuenta
        End If
        cuenta += 1
        If cuenta > 20 Then
            Button1.Enabled = False
        End If
        TextBox5.Text &= num & "; "
        TextBox3.Text = contadorPar
        TextBox2.Text = mayor
        TextBox4.Text = posicionMayor
        TextBox1.Clear()
    End Sub
End Class
