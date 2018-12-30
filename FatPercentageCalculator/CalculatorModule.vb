Module CalculatorModule

    ' Percent of calories
    Public Function PctOfCal(ByVal dblInTotalCal, ByVal dblInFatCal)
        ' Percentage of calories from fat = Calories from fat / total calories

        Return (dblInFatCal / dblInTotalCal)
    End Function

End Module
