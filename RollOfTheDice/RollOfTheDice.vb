'Elliot Heiner
'RCET 0265
'Fall 2021
'Roll of the Dice
'https://github.com/heinelli/RollOfTheDice.git

Module RollOfTheDice

    Sub Main()
        For i = 0 To 50
            Console.WriteLine(RandomNumber())
        Next
        Console.Read()

    End Sub

    Function RandomNumber()
        Dim rndNumber As Integer
        Randomize()
        rndNumber = Int((11 * Rnd()) + 1)
        Return rndNumber
    End Function

End Module
