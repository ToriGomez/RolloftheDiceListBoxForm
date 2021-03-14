'Tori Gomez 
'RCET0265
'Spring 2021
'Roll of the Dice Form
'https://github.com/ToriGomez/RolloftheDiceListBoxForm.git

Option Explicit On
Option Strict On
Public Class RolloftheDiceForm
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click, RollTopMenuItem.Click
        Dim rollsResult As Integer
        Dim diceValue As Integer = 1
        Dim numbers(12) As Integer
        Dim display(4) As String
        Dim title As String = (("Roll of the Dice").PadLeft(5))
        Dim dashRow As String = (StrDup(84, " - "))
        Dim countDisplay As String = ""
        Dim diceValueTotal As String = ""
        'Clears listbox for every roll button click to generate new numbers.
        RolloftheDiceListBox.Items.Clear()
        'Adds two dice rolled values, 2-12 to the display array.
        For i = 2 To 12
            countDisplay &= (($"{i}|").PadLeft(5))
        Next
        'Generates the sum of two dice rolled values. Min of 2, Max of 12.
        'Accumulates the amount of times each value is rolled from 1000 rolls.
        For i = 1 To 1000
            rollsResult = (CInt((5 * Rnd()) + 1) + CInt((5 * Rnd()) + 1))
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
        'Adds dicevalues 2-12 from 1000 rolls to the display array.
        For i = 2 To UBound(numbers)
            diceValueTotal &= (($"{numbers(i)}|").PadLeft(5))
        Next
        'Accumulates the display(4) from values accumulated.
        display = {title, dashRow, countDisplay, dashRow, diceValueTotal}
        'Adds the display array to the list box to display to user.
        For i = 0 To UBound(display)
            RolloftheDiceListBox.Items.Add(display(i))
        Next
    End Sub
    'Clears console when Clear button is clicked or when it is selected in the menu items.
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearTopMenuItem.Click
        RolloftheDiceListBox.Items.Clear()
    End Sub
    'Closes console when Exit button is clicked or when it is selected in the menu items.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitTopMenuItem.Click
        Me.Close()
    End Sub
End Class
