Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module Module1
    Function Suma(num1 As Double, num2 As Double) As Double
        Return num1 + num2
    End Function
    Function Resta(num1 As Double, num2 As Double) As Double
        Return num1 - num2
    End Function
    Function Multiplicación(num1 As Double, num2 As Double) As Double
        Return num1 * num2
    End Function
    Function División(num1 As Double, num2 As Double) As Double
        Return num1 / num2
    End Function
    Function Modulo(num1 As Double, num2 As Double) As Double
        Return num1 Mod num2
    End Function
    Function Y(ope1 As Double, ope2 As Double) As Double
        Return ope1 And ope2
    End Function
    Function O(ope1 As Double, ope2 As Double) As Double
        Return ope1 Or ope2
    End Function
    Sub LIMPIAR_ENTRADAS()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.SelectedIndex = 0
    End Sub
    Sub Ejecutar(Index As Integer)
        Select Case Index
            Case 0
                Form1.TextBox3.Text = Str(Suma(Double.Parse(Form1.TextBox1.Text), Double.Parse(Form1.TextBox2.Text)))
            Case 1
                Form1.TextBox3.Text = Str(Resta(Double.Parse(Form1.TextBox1.Text), Double.Parse(Form1.TextBox2.Text)))
            Case 2
                Form1.TextBox3.Text = Str(Multiplicación(Double.Parse(Form1.TextBox1.Text), Double.Parse(Form1.TextBox2.Text)))
            Case 3
                Form1.TextBox3.Text = Str(División(Double.Parse(Form1.TextBox1.Text), Double.Parse(Form1.TextBox2.Text)))
            Case 4
                Form1.TextBox3.Text = Str(Modulo(Double.Parse(Form1.TextBox1.Text), Double.Parse(Form1.TextBox2.Text)))
            Case 5
                Form1.TextBox3.Text = Str(Y(Boolean.Parse(Form1.TextBox1.Text), Boolean.Parse(Form1.TextBox2.Text)))
            Case 6
                Form1.TextBox3.Text = Str(O(Boolean.Parse(Form1.TextBox1.Text), Boolean.Parse(Form1.TextBox2.Text)))
            Case Else
                Form1.TextBox3.Text = "ERROR, NO SELECCIONÓ TIPO DE OPERACIÓN"
        End Select
    End Sub

End Module
