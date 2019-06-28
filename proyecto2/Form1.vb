Public Class Form1

    Dim value1, value2, result, memory As Double
    Dim last_operation As Single
    Dim equal, clear_all As Boolean

    Private Sub buttonNum1_Click(sender As Object, e As EventArgs) Handles buttonNum1.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.AppendText("1")
        Else
            TextBox1.AppendText("1")
        End If
    End Sub

    Private Sub buttonNum2_Click(sender As Object, e As EventArgs) Handles buttonNum2.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.AppendText("2")
        Else
            TextBox1.AppendText("2")
        End If
    End Sub

    Private Sub buttonNum3_Click(sender As Object, e As EventArgs) Handles buttonNum3.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.AppendText("3")
        Else
            TextBox1.AppendText("3")
        End If
    End Sub

    Private Sub buttonNum4_Click(sender As Object, e As EventArgs) Handles buttonNum4.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.AppendText("4")
        Else
            TextBox1.AppendText("4")
        End If
    End Sub

    Private Sub buttonNum5_Click(sender As Object, e As EventArgs) Handles buttonNum5.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.AppendText("5")
        Else
            TextBox1.AppendText("5")
        End If
    End Sub

    Private Sub buttonNum6_Click(sender As Object, e As EventArgs) Handles buttonNum6.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.AppendText("6")
        Else
            TextBox1.AppendText("6")
        End If
    End Sub

    Private Sub buttonNum7_Click(sender As Object, e As EventArgs) Handles buttonNum7.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.AppendText("7")
        Else
            TextBox1.AppendText("7")
        End If
    End Sub

    Private Sub buttonNum8_Click(sender As Object, e As EventArgs) Handles buttonNum8.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.AppendText("8")
        Else
            TextBox1.AppendText("8")
        End If
    End Sub

    Private Sub buttonNum9_Click(sender As Object, e As EventArgs) Handles buttonNum9.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.AppendText("9")
        Else
            TextBox1.AppendText("9")
        End If
    End Sub

    Private Sub buttonNum0_Click(sender As Object, e As EventArgs) Handles buttonNum0.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.AppendText("0")
        Else
            TextBox1.AppendText("0")
        End If
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        If (clear_all = True) Then
            value1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            clear_all = False
            last_operation = 0
        ElseIf (equal = True) Then
            value1 = result
            TextBox1.Text = ""
            equal = False
            last_operation = 0
        Else
            value1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            last_operation = 0
        End If
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        If (clear_all = True) Then
            value1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            clear_all = False
            last_operation = 1
        ElseIf (equal = True) Then
            value1 = result
            TextBox1.Text = ""
            equal = False
            last_operation = 1
        Else
            value1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            last_operation = 1
        End If
    End Sub

    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click
        If (clear_all = True) Then
            value1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            clear_all = False
            last_operation = 2
        ElseIf (equal = True) Then
            value1 = result
            TextBox1.Text = ""
            equal = False
            last_operation = 2
        Else
            value1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            last_operation = 2
        End If
    End Sub

    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click
        If (clear_all = True) Then
            value1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            clear_all = False
            last_operation = 3
        ElseIf (equal = True) Then
            value1 = result
            TextBox1.Text = ""
            equal = False
            last_operation = 3
        Else
            value1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            last_operation = 3
        End If
    End Sub

    Private Sub equalsButton_Click(sender As Object, e As EventArgs) Handles equalsButton.Click
        Select Case last_operation
            Case Is = 0
                value2 = Val(TextBox1.Text)
                result = value1 + value2
                TextBox1.Text = result
            Case Is = 1
                value2 = Val(TextBox1.Text)
                result = value1 - value2
                TextBox1.Text = result
            Case Is = 2
                value2 = Val(TextBox1.Text)
                result = value1 * value2
                TextBox1.Text = result
            Case Is = 3
                value2 = Val(TextBox1.Text)
                result = value1 / value2
                TextBox1.Text = result
        End Select

        equal = True
    End Sub

    Private Sub dotButton_Click(sender As Object, e As EventArgs) Handles dotButton.Click
        TextBox1.AppendText(".")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "0"
    End Sub

    Private Sub memory_minusButton_Click(sender As Object, e As EventArgs) Handles memory_minusButton.Click
        memory -= Val(TextBox1.Text)
    End Sub

    Private Sub memory_plusButton_Click(sender As Object, e As EventArgs) Handles memory_plusButton.Click
        memory += Val(TextBox1.Text)
    End Sub

    Private Sub memory_recallButton_Click(sender As Object, e As EventArgs) Handles memory_recallButton.Click
        TextBox1.Text = memory
    End Sub

    Private Sub memory_clearButton_Click(sender As Object, e As EventArgs) Handles memory_clearButton.Click
        memory = 0
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clear_all = True
        TextBox1.Text = "0"
    End Sub

    Private Sub clear_entryButton_Click(sender As Object, e As EventArgs) Handles clear_entryButton.Click
        TextBox1.Text = 0
    End Sub

    Private Sub exit_offButton_Click(sender As Object, e As EventArgs) Handles exit_offButton.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.show()
        Me.Hide()
    End Sub
End Class
