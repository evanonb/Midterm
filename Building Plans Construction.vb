Public Class frmBuildingPlansConversion
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' The btnConvert event handler calculates the converted inputted number
        ' and then displays the result

        Dim decConversionFactor As Decimal = 39.37D
        Dim decUsrInput As Decimal
        Dim decOutput As Decimal
        Dim strFirstWord As String = ""
        Dim strSecondWord As String = ""

        ' User Input Validation
        If IsNumeric(txtUsrInput.Text) Then
            decUsrInput = Convert.ToDecimal(txtUsrInput.Text)
            If decUsrInput > 0 Then
                If radInToM.Checked Then
                    decOutput = decUsrInput / decConversionFactor
                    strFirstWord = "inches"
                    strSecondWord = "meters"
                ElseIf RadMToIn.Checked Then
                    decOutput = decUsrInput * decConversionFactor
                    strFirstWord = "meters"
                    strSecondWord = "inches"
                End If
                lblOutput.Text = Convert.ToString(decUsrInput) + " " + strFirstWord + " is " + Convert.ToString(Math.Round(decOutput, 3)) + " " + strSecondWord + "."
            Else
                MsgBox("You entered " + decUsrInput.ToString() + ". Please enter a positive number", , "Input Error")
                txtUsrInput.Text = ""
                txtUsrInput.Focus()
            End If
        Else
            MsgBox("The text you entered is not a number. Please enter a number", , "Input Error")
            txtUsrInput.Text = ""
            txtUsrInput.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsrInput.Text = ""
        lblOutput.Text = ""
        radInToM.Checked = False
        RadMToIn.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
