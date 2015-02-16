Public Class Form1

    Dim Withdrawling As Boolean
    Dim Depositing As Boolean

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim CB As Double
        CB = CurrentBalance.Text
        Dim WB As Double
        WB = Withdrawl.Text
        Dim DB As Double
        DB = Deposit.Text
        Dim num As String
        If Not CB = 0 Then
            If Withdrawling Then
                NewBalance.Text = CStr(CB - WB)
            ElseIf Depositing Then
                NewBalance.Text = CB + DB
            End If
        End If
    End Sub

    Private Sub bIsWithdrawl_CheckedChanged(sender As Object, e As EventArgs) Handles bIsWithdrawl.CheckedChanged
        If bIsWithdrawl.Checked Then
            Withdrawling = True
            Withdrawl.Show()
        Else
            Withdrawling = False
            Withdrawl.Hide()
        End If
    End Sub

    Private Sub bIsDeposit_CheckedChanged(sender As Object, e As EventArgs) Handles bIsDeposit.CheckedChanged
        If bIsDeposit.Checked Then
            Depositing = True
            Deposit.Show()
        Else
            Depositing = False
            Deposit.Hide()
        End If
    End Sub
End Class
