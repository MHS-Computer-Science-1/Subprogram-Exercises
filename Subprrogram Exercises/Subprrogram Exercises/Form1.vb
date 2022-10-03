Public Class Form1

    'Sub: sum
    'Parameters: 2 numbers
    'Task: Displays the sum of the numbers
    Sub sum(a As Integer, b As Integer)
        ListBox1.Items.Add("a = " & a & " b = " & b & " sum = " & (a + b))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Use the sum subprogram to display the sum of 200 and 300

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Use the sum subprogram to display the sum of the numbers entered by the user
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Countdown from 10

        'Erase the listbox
        ListBox1.Items.Clear()

        'Count down
        Dim i As Integer
        For i = 10 To 1 Step -1
            ListBox1.Items.Add(i)
        Next
        ListBox1.Items.Add("Blast Off!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Countdown from 100 by 10s

        'Erase the listbox
        ListBox1.Items.Clear()

        'Count down
        Dim i As Integer
        For i = 100 To 1 Step -10
            ListBox1.Items.Add(i)
        Next
        ListBox1.Items.Add("Blast Off!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Countdown from 500 by 50s

        'Erase the listbox
        ListBox1.Items.Clear()

        'Count down
        Dim i As Integer
        For i = 500 To 1 Step -50
            ListBox1.Items.Add(i)
        Next
        ListBox1.Items.Add("Blast Off!")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim input As Integer

        Do While input <> -1
            input = InputBox("Enter a number and I will double it. Enter -1 to stop.")
            'Call the subprogram to double 'input'
        Loop

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Midpoint of (2, 5) and (10, -7)

    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Midpoint of numbers entered by the user

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Plural

    End Sub



End Class
