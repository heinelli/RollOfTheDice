'Elliot Heiner
'RCET 0265
'Fall 2021
'Roll of the Dice
'https://github.com/heinelli/RollOfTheDice.git

Module RollOfTheDice

    Sub Main()
        Dim diceNumbers(10) As Integer


        For i = 0 To 1000
            diceNumbers(RandomNumber()) += 1
        Next

        For i = LBound(diceNumbers) To UBound(diceNumbers)
            Console.Write(CStr(i + 2).PadLeft(4) & " |")
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(66, "-"))

        For i = LBound(diceNumbers) To UBound(diceNumbers)
            Console.Write(CStr(diceNumbers(i)).PadLeft(4) & " |")
        Next
        Console.Read()

    End Sub

    Function RandomNumber()
        Dim rndNumber1 As Integer
        Dim rndNumber2 As Integer
        Randomize()
        rndNumber1 = Int((6 * Rnd()) + 1)
        rndNumber2 = Int((6 * Rnd()) + 1)
        Return rndNumber1 + rndNumber2 - 2
    End Function

End Module
