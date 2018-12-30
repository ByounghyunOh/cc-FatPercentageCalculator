Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblNumCal As Double     ' Number of calories in the food
        Dim dblNumFat As Double     ' Number of Fat gram in the food
        Dim dblFatCal As Double     ' Calories from fat
        Dim dblFatPct As Double     ' Percentage of calories that come from fat

        lblLowFat.Text = String.Empty   ' Low fat message clear

        Try
            'No input checking
            If txtNumCal.Text = String.Empty Then
                MessageBox.Show("Please enter a value")
                txtNumCal.Focus()

            Else
                ' Get number of calories in the food
                dblNumCal = CDbl(txtNumCal.Text)

                ' Check the number is not less than 0
                If dblNumCal < 0 Then
                    MessageBox.Show("Number cannot be less than 0")
                    txtNumCal.Clear()
                    txtNumFat.Clear()
                    txtNumCal.Focus()


                    'No input checking
                ElseIf txtNumFat.Text = String.Empty Then
                    MessageBox.Show("Please enter a value")
                    txtNumFat.Clear()
                    txtNumFat.Focus()

                Else
                    ' Get number of fat gram in the food
                    dblNumFat = CDbl(txtNumFat.Text)

                    ' Check the number is not less than 0
                    If dblNumFat < 0 Then
                        MessageBox.Show("Number cannot be less than 0")
                        txtNumFat.Clear()
                        txtNumFat.Focus()
                    End If

                    ' Calories from fat = fat grams * 9
                    dblFatCal = dblNumFat * 9D

                    ' Check the number of calories from fat greater than the total number 
                    If dblFatCal > dblNumCal Then
                        MessageBox.Show("Fat cannot greater than total number of calories")
                        txtNumFat.Clear()
                        txtNumFat.Focus()
                    Else
                        ' Call PctOfCal function from Calculator Module
                        dblFatPct = PctOfCal(dblNumCal, dblFatCal)

                        ' Display result
                        If dblFatPct < 0.3 Then
                            lblLowFat.Text = "(a low-fat food)"
                        End If
                        lblPctCal.Text = dblFatPct.ToString("P")
                    End If
                End If
            End If

        Catch ex As InvalidCastException
            ' Display error message
            MessageBox.Show("Input must be numeric")
            txtNumCal.Clear()
            txtNumFat.Clear()
            txtNumCal.Focus()
        End Try

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtNumCal.Clear()
        txtNumFat.Clear()
        lblPctCal.Text = String.Empty
        lblLowFat.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
