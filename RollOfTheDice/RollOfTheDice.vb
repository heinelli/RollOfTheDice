'Elliot Heiner
'RCET 0265
'Fall 2021
'Roll of the Dice
'https://github.com/heinelli/RollOfTheDice.git
Module RollOfTheDice
    Sub Main()
        Dim diceNumbers(10) As Integer

        'Total the number of times that each combination is rolled.
        For i = 0 To 1000
            diceNumbers(RandomNumber()) += 1
        Next

        'Create a header with the proper amount of columns
        For i = LBound(diceNumbers) To UBound(diceNumbers)
            Console.Write(CStr(i + 2).PadLeft(4) & " |")
        Next

        'Create a new line and draw line between top and bottom row.
        Console.WriteLine()
        Console.WriteLine(StrDup(66, "-"))

        'Display the previously totaled combination count
        For i = LBound(diceNumbers) To UBound(diceNumbers)
            Console.Write(CStr(diceNumbers(i)).PadLeft(4) & " |")
        Next
        Console.Read()
    End Sub
    Function RandomNumber()
        Dim rndNumber1 As Integer
        Dim rndNumber2 As Integer

        'Create two random values from 1-6 and add them together.
        Randomize()
        rndNumber1 = Int((6 * Rnd()) + 1)
        rndNumber2 = Int((6 * Rnd()) + 1)
        Return rndNumber1 + rndNumber2 - 2
    End Function
End Module
