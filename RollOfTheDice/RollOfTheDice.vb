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
        Dim rndNumber1 As Integer
        Dim rndNumber2 As Integer
        Randomize()
        rndNumber1 = Int((6 * Rnd()) + 1)
        rndNumber2 = Int((6 * Rnd()) + 1)
        Return rndNumber1 + rndNumber2
    End Function

End Module
