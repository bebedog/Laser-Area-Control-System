Public Class TimeVariables
    Public Sub resumeOperation()
        My.Forms.Form1.Timer1.Enabled = True
        My.Forms.Form1.Enabled = True
        My.Forms.Form1.Show()
    End Sub
    Private Sub TimeVariables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.TopMost = True
        tbTimeOut.Text = My.Settings.timeOut
        tbRefreshRate.Text = My.Settings.refreshRate
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        resumeOperation()
        Me.Close()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        My.Settings.timeOut = tbTimeOut.Text
        My.Settings.refreshRate = tbRefreshRate.Text
        My.Forms.Form1.Timer1.Interval = My.Settings.refreshRate
        My.Forms.DOOR_INPUTS_AND_ALIGNMENT_MODES.Timer2.Interval = My.Settings.refreshRate
        My.Forms.Search_ECS_and_Beam_Dumps_Input.timerUpdateUI.Interval = My.Settings.refreshRate
        My.Settings.Save()
        MessageBox.Show("Changes Applied!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        My.Forms.Form1.cbSheets_SelectedIndexChanged(sender, e)
        resumeOperation()
        Me.Close()
    End Sub
End Class