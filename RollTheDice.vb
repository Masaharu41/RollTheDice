'OwenFujii
'RCET 2265
'Spring 2024
'


Option Explicit On
Option Strict On


Module RollTheDice

    Sub Main()
        RollTrackerTotal()
        Console.WriteLine(RollTrackerTotal())
        Console.Read()
    End Sub


    Function RollDice() As Integer
        Dim diceRoll As Integer
        Randomize()
        diceRoll = CInt(Math.Floor((12 - 2 + 1) * Rnd())) + 2
        Return diceRoll
    End Function

    Function RollTrackerTotal() As Integer()
        Dim rollTracker(10) As Integer
        Dim diceRolled As Integer
        Dim twoRolled%, threeRolled%, fourRolled%, fiveRolled%
        Dim sixRolled%, sevenRolled%, eightRolled%, nineRolled%
        Dim tenRolled%, elevenRolled%, twelveRolled%
        For i = 1 To 1000
            diceRolled = RollDice()
            If diceRolled = 2 Then
                twoRolled = twoRolled + 1
                rollTracker(0) = twoRolled
            ElseIf diceRolled = 3 Then
                threeRolled = threeRolled + 1
                rollTracker(1) = threeRolled
            ElseIf diceRolled = 4 Then
                fourRolled = fourRolled + 1
                rollTracker(2) = fourRolled
            ElseIf diceRolled = 5 Then
                fiveRolled = fiveRolled + 1
                rollTracker(3) = fiveRolled
            ElseIf diceRolled = 6 Then
                sixRolled = sixRolled + 1
                rollTracker(4) = sixRolled
            ElseIf diceRolled = 7 Then
                sevenRolled = sevenRolled + 1
                rollTracker(5) = sevenRolled
            ElseIf diceRolled = 8 Then
                eightRolled = eightRolled + 1
                rollTracker(6) = eightRolled
            ElseIf diceRolled = 9 Then
                nineRolled = nineRolled + 1
                rollTracker(7) = nineRolled
            ElseIf diceRolled = 10 Then
                tenRolled = tenRolled + 1
                rollTracker(8) = tenRolled
            ElseIf diceRolled = 11 Then
                elevenRolled = elevenRolled + 1
                rollTracker(9) = elevenRolled
            ElseIf diceRolled = 12 Then
                twelveRolled = twelveRolled + 1
                rollTracker(10) = twelveRolled
            End If

        Next

        Return rollTracker()

    End Function



End Module
