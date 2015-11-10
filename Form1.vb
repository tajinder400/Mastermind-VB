Public Class Form1
    Dim difficulty As Integer
    Public Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If rdEasy.Checked Then
            difficulty = 1
        ElseIf rdMedium.Checked Then
            difficulty = 2
        ElseIf rdHard.Checked Then
            difficulty = 3

        End If
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
