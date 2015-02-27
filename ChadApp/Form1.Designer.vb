<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CurrentBalance = New System.Windows.Forms.TextBox()
        Me.InputValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputText = New System.Windows.Forms.Label()
        Me.NewBalance = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.bIsWithdrawl = New System.Windows.Forms.RadioButton()
        Me.bIsDeposit = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'CurrentBalance
        '
        Me.CurrentBalance.Location = New System.Drawing.Point(43, 155)
        Me.CurrentBalance.Name = "CurrentBalance"
        Me.CurrentBalance.Size = New System.Drawing.Size(100, 20)
        Me.CurrentBalance.TabIndex = 0
        '
        'InputValue
        '
        Me.InputValue.Location = New System.Drawing.Point(43, 209)
        Me.InputValue.Name = "InputValue"
        Me.InputValue.Size = New System.Drawing.Size(100, 20)
        Me.InputValue.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current Balance"
        '
        'InputText
        '
        Me.InputText.AutoSize = True
        Me.InputText.Location = New System.Drawing.Point(43, 190)
        Me.InputText.Name = "InputText"
        Me.InputText.Size = New System.Drawing.Size(43, 13)
        Me.InputText.TabIndex = 3
        Me.InputText.Text = "Deposit"
        '
        'NewBalance
        '
        Me.NewBalance.Location = New System.Drawing.Point(332, 209)
        Me.NewBalance.Name = "NewBalance"
        Me.NewBalance.ReadOnly = True
        Me.NewBalance.Size = New System.Drawing.Size(100, 20)
        Me.NewBalance.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "New Balance"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(51, 314)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 8
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'bIsWithdrawl
        '
        Me.bIsWithdrawl.AutoSize = True
        Me.bIsWithdrawl.Location = New System.Drawing.Point(43, 41)
        Me.bIsWithdrawl.Name = "bIsWithdrawl"
        Me.bIsWithdrawl.Size = New System.Drawing.Size(72, 17)
        Me.bIsWithdrawl.TabIndex = 9
        Me.bIsWithdrawl.TabStop = True
        Me.bIsWithdrawl.Text = "Withdrawl"
        Me.bIsWithdrawl.UseVisualStyleBackColor = True
        '
        'bIsDeposit
        '
        Me.bIsDeposit.AutoSize = True
        Me.bIsDeposit.Location = New System.Drawing.Point(332, 41)
        Me.bIsDeposit.Name = "bIsDeposit"
        Me.bIsDeposit.Size = New System.Drawing.Size(61, 17)
        Me.bIsDeposit.TabIndex = 10
        Me.bIsDeposit.TabStop = True
        Me.bIsDeposit.Text = "Deposit"
        Me.bIsDeposit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 436)
        Me.Controls.Add(Me.bIsDeposit)
        Me.Controls.Add(Me.bIsWithdrawl)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NewBalance)
        Me.Controls.Add(Me.InputText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputValue)
        Me.Controls.Add(Me.CurrentBalance)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CurrentBalance As System.Windows.Forms.TextBox
    Friend WithEvents InputValue As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InputText As System.Windows.Forms.Label
    Friend WithEvents NewBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents bIsWithdrawl As System.Windows.Forms.RadioButton
    Friend WithEvents bIsDeposit As System.Windows.Forms.RadioButton

End Class
