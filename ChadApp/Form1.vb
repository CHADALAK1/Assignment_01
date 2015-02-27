Public Class Form1

    Dim Withdrawling As Boolean
    Dim Depositing As Boolean

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim CB As Double
        CB = CurrentBalance.Text
        Dim DepWith As Double
        DepWith = InputValue.Text
        If Not CB = 0 Then
            If Withdrawling Then
                NewBalance.Text = CB - DepWith
            ElseIf Depositing Then
                NewBalance.Text = CB + DepWith
            End If
        End If
    End Sub

    Private Sub bIsWithdrawl_CheckedChanged(sender As Object, e As EventArgs) Handles bIsWithdrawl.CheckedChanged
        If bIsWithdrawl.Checked Then
            Withdrawling = True
            InputText.Text = "Withdrawl"
        Else
            Withdrawling = False
            InputText.Text = "Deposit"
        End If
    End Sub

    Private Sub bIsDeposit_CheckedChanged(sender As Object, e As EventArgs) Handles bIsDeposit.CheckedChanged
        If bIsDeposit.Checked Then
            Depositing = True
            InputText.Text = "Deposit"
        Else
            Depositing = False
            InputText.Text = "Withdrawl"
        End If
    End Sub
End Class
