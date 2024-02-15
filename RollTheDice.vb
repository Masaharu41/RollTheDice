'OwenFujii
'RCET 2265
'Spring 2024
'


Option Explicit On
Option Strict On


Module RollTheDice

    Sub Main()
        Console.WriteLine(StrDup(15, "*"))
        Dim rollTracker() As Integer
        Dim diceRolled As Integer
        Dim twoRolled%, threeRolled%, fourRolled%, fiveRolled%
        Dim sixRolled%, sevenRolled%, eightRolled%, nineRolled%
        Dim tenRolled%, elevenRolled%, twelveRolled%
        For i = 1 To 1000
            diceRolled = RollDice()
            If diceRolled = 2 Then
                twoRolled = twoRolled + 1

            ElseIf diceRolled = 3 Then
                threeRolled = threeRolled + 1

            ElseIf diceRolled = 4 Then
                fourRolled = fourRolled + 1

            ElseIf diceRolled = 5 Then
                fiveRolled = fiveRolled + 1

            ElseIf diceRolled = 6 Then
                sixRolled = sixRolled + 1

            ElseIf diceRolled = 7 Then
                sevenRolled = sevenRolled + 1

            ElseIf diceRolled = 8 Then
                eightRolled = eightRolled + 1

            ElseIf diceRolled = 9 Then
                nineRolled = nineRolled + 1

            ElseIf diceRolled = 10 Then
                tenRolled = tenRolled + 1

            ElseIf diceRolled = 11 Then
                elevenRolled = elevenRolled + 1

            ElseIf diceRolled = 12 Then
                twelveRolled = twelveRolled + 1

            End If

        Next

        rollTracker = {twoRolled, threeRolled, fourRolled, fiveRolled, sixRolled, sevenRolled, eightRolled, nineRolled,
            tenRolled, elevenRolled, twelveRolled}
        For i = 0 To 10
            Console.Write(CStr(rollTracker(i)).PadLeft(3).PadRight(5))
        Next
        Console.Read()
    End Sub


    Function RollDice() As Integer
        Dim diceRolled As Integer
        Dim diceRoll1 As Integer
        Dim diceRoll2 As Integer
        Randomize()
        diceRoll1 = CInt(Int((6 * Rnd()) + 1)) 'CInt(Math.Floor((12 - 2 + 1) * Rnd())) + 2
        diceRoll2 = CInt(Int((6 * Rnd()) + 1))
        diceRolled = diceRoll1 + diceRoll2
        Return diceRolled
    End Function

    'Function RollTrackerTotal() As Integer()
    '    Dim rollTracker() As Integer
    '    Dim diceRolled As Integer
    '    Dim twoRolled%, threeRolled%, fourRolled%, fiveRolled%
    '    Dim sixRolled%, sevenRolled%, eightRolled%, nineRolled%
    '    Dim tenRolled%, elevenRolled%, twelveRolled%
    '    For i = 1 To 1000
    '        diceRolled = RollDice()
    '        If diceRolled = 2 Then
    '            twoRolled = twoRolled + 1
    '            '  rollTracker(0) = twoRolled
    '        ElseIf diceRolled = 3 Then
    '            threeRolled = threeRolled + 1
    '            '  rollTracker(1) = threeRolled
    '        ElseIf diceRolled = 4 Then
    '            fourRolled = fourRolled + 1
    '            ' rollTracker(2) = fourRolled
    '        ElseIf diceRolled = 5 Then
    '            fiveRolled = fiveRolled + 1
    '            ' rollTracker(3) = fiveRolled
    '        ElseIf diceRolled = 6 Then
    '            sixRolled = sixRolled + 1
    '            ' rollTracker(4) = sixRolled
    '        ElseIf diceRolled = 7 Then
    '            sevenRolled = sevenRolled + 1
    '            ' rollTracker(5) = sevenRolled
    '        ElseIf diceRolled = 8 Then
    '            eightRolled = eightRolled + 1
    '            ' rollTracker(6) = eightRolled
    '        ElseIf diceRolled = 9 Then
    '            nineRolled = nineRolled + 1
    '            ' rollTracker(7) = nineRolled
    '        ElseIf diceRolled = 10 Then
    '            tenRolled = tenRolled + 1
    '            ' rollTracker(8) = tenRolled
    '        ElseIf diceRolled = 11 Then
    '            elevenRolled = elevenRolled + 1
    '            'rollTracker(9) = elevenRolled
    '        ElseIf diceRolled = 12 Then
    '            twelveRolled = twelveRolled + 1
    '            ' rollTracker(10) = twelveRolled
    '        End If

    '    Next

    '    rollTracker = {twoRolled, threeRolled, fourRolled, fiveRolled, sixRolled, sevenRolled, eightRolled, nineRolled,
    '        tenRolled, elevenRolled, twelveRolled}

    '    Return rollTracker()

    'End Function



End Module
