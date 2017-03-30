Public Class Gloebits

    Dim Initted As Boolean = False

    Private Sub Loaded(sender As Object, e As EventArgs) Handles Me.Load
        SandboxButton.Checked = Not My.Settings.GloebitsMode
        ProductionButton.Checked = My.Settings.GloebitsMode
        OAuthKeyTextBox.Text = My.Settings.OAuthKey
        OAuthSecretTextBox.UseSystemPasswordChar = True
        OAuthSecretTextBox.Text = My.Settings.OAuthSecret
        GloebitsEnabled.Checked = My.Settings.GloebitsEnable
        Initted = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GloebitsWebsiteButton.Click
        Dim webAddress As String = "http://dev.gloebit.com/opensim/"
        Process.Start(webAddress)
    End Sub

    Private Sub SandboxButton_CheckedChanged(sender As Object, e As EventArgs) Handles SandboxButton.CheckedChanged
        If SandboxButton.Checked = True Then
            ProductionButton.Checked = False
            My.Settings.GloebitsMode = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub ProductionButton_CheckedChanged(sender As Object, e As EventArgs) Handles ProductionButton.CheckedChanged
        If ProductionButton.Checked = True Then
            SandboxButton.Checked = False
            My.Settings.GloebitsMode = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles OAuthKeyTextBox.TextChanged
        My.Settings.OAuthKey = OAuthKeyTextBox.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles OAuthSecretTextBox.TextChanged
        My.Settings.OAuthSecret = OAuthSecretTextBox.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox2_click(sender As Object, e As EventArgs) Handles OAuthSecretTextBox.Click
        OAuthSecretTextBox.UseSystemPasswordChar = False
    End Sub

    Private Sub GloebitsEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles GloebitsEnabled.CheckedChanged
        If My.Settings.GLBOwnerEmail.Length And My.Settings.GLBOwnerName.Length Then
            My.Settings.GloebitsEnable = GloebitsEnabled.Checked
            My.Settings.Save()
        Else
            If Initted And GloebitsEnabled.Checked Then
                MsgBox("You must have a OAuth Key and OAuth Secret to enable Gloebits")
            End If
        End If
    End Sub

    Private Sub OwnerNameTextbox_TextChanged(sender As Object, e As EventArgs) Handles OwnerNameTextbox.TextChanged
        My.Settings.GLBOwnerName = OwnerNameTextbox.Text
        My.Settings.Save()
    End Sub

    Private Sub ContactEmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactEmailTextBox.TextChanged
        My.Settings.GLBOwnerEmail = ContactEmailTextBox.Text
        My.Settings.Save()
    End Sub
End Class