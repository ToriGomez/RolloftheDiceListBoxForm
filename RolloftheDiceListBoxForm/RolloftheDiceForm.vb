Option Explicit On
Option Strict On
Public Class RolloftheDiceForm
    Private Sub RolloftheDiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HiddenDisplayTextBox.Enabled = False
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim rollsResult As Integer
        Dim diceValue As Integer = 1
        Dim numbers(12) As Integer
        Dim display(4) As String
        Dim title As String = (vbTab & vbTab & vbTab & "Roll of the Dice")
        Dim dashRow As String = (StrDup(84, " - "))
        Dim diceValueTotal As String


        RolloftheDiceListBox.Items.Clear()
        'Generates the sum of two dice rolled values. Min of 2, Max of 12.
        'Accumulates the amount of times each value is rolled from 1000 rolls.
        For i = 1 To 1000
            rollsResult = RandomNumber()
            Select Case rollsResult
                Case 2
                    numbers(2) += diceValue
                Case 3
                    numbers(3) += diceValue
                Case 4
                    numbers(4) += diceValue
                Case 5
                    numbers(5) += diceValue
                Case 6
                    numbers(6) += diceValue
                Case 7
                    numbers(7) += diceValue
                Case 8
                    numbers(8) += diceValue
                Case 9
                    numbers(9) += diceValue
                Case 10
                    numbers(10) += diceValue
                Case 11
                    numbers(11) += diceValue
                Case 12
                    numbers(12) += diceValue
                Case Else
                    MsgBox($"Error!: {rollsResult}")
            End Select
        Next

        For i = 2 To UBound(numbers)
            diceValueTotal = ($"{numbers(i)}|".PadLeft(4) & vbTab)
        Next

        display(0) = title
        display(1) = dashRow
        display(2) = DiceValueDisplay()
        display(3) = dashRow
        display(4) = diceValueTotal

        'CancatinateDisplay(title, dashRow, DiceValueDisplay())
        RolloftheDiceListBox.Items.Add(display(0) & display(1))
        RolloftheDiceListBox.EndUpdate()
    End Sub
    'Function CancatinateDisplay(title As String, spacing As String, value As String _
    '                             & valuetotal As String) As String
    '    Return title + spacing
    'End Function
    Function DiceValueDisplay() As String
        Dim countDisplay As String
        For i = 2 To 12
            countDisplay = (($"{i}|").PadLeft(4) & vbTab)
        Next
        Return countDisplay
    End Function
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RolloftheDiceListBox.Items.Clear()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Random value of roll of two dice
    Function RandomNumber() As Integer
        Dim value As Integer
        Randomize()
        value = (CInt((5 * Rnd()) + 1) + CInt((5 * Rnd()) + 1))
        Return value
    End Function

End Class
