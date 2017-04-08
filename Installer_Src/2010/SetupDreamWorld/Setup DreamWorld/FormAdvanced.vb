﻿

Public Class AdvancedForm
#Region "Declarations"

    Dim Sleepy As Integer = 1500
    Dim Awake As Integer = 1000
    Dim Coffee As Integer = 500
    Dim Toomuch As Integer = 0
    Private Class Region_data
        Public RegionName As String
        Public UUID As String
        Public CoordX As Integer
        Public CoordY As String
        Public RegionPort As Integer
        Public SizeX As Integer
        Public SizeY As Integer
    End Class

#End Region

#Region "Functions"

    Private Sub Loaded(sender As Object, e As EventArgs) Handles Me.Load
        AutoBackupKeepFilesForDays.Text = My.Settings.KeepForDays
        If My.Settings.AutobackupInterval = 60 Then
            AutoBackupInterval.SelectedIndex = 0
        ElseIf My.Settings.AutobackupInterval = 12 * 60 Then
            AutoBackupInterval.SelectedIndex = 1
        ElseIf My.Settings.AutobackupInterval = 24 * 60 Then
            AutoBackupInterval.SelectedIndex = 2
        Else
            AutoBackupInterval.SelectedIndex = 3
        End If

        BackupFolder.Text = My.Settings.BackupFolder

        Dim Chattime = My.Settings.ChatTime

        If Chattime = Sleepy Then
            ChatSpeed.SelectedIndex = 0
        ElseIf Chattime = Awake Then
            ChatSpeed.SelectedIndex = 1
        ElseIf Chattime = Coffee Then
            ChatSpeed.SelectedIndex = 2
        Else
            ChatSpeed.SelectedIndex = 3
        End If

        AutoBackup.Checked = My.Settings.AutoBackup
        TimerInterval.Text = Str(My.Settings.TimerInterval)

        If My.Settings.MapType = "None" Then
            MapNone.Checked = True
            MapPicture.Image = Nothing
        ElseIf My.Settings.MapType = "Simple" Then
            MapSimple.Checked = True
            MapPicture.Image = My.Resources.Simple
        ElseIf My.Settings.MapType = "Good" Then
            MapGood.Checked = True
            MapPicture.Image = My.Resources.Good
        ElseIf My.Settings.MapType = "Better" Then
            MapBetter.Checked = True
            MapPicture.Image = My.Resources.Better
        ElseIf My.Settings.MapType = "Best" Then
            MapBest.Checked = True
            MapPicture.Image = My.Resources.Best
        End If
        LoadWelcomeBox()




    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Form1.Running Then
            Form1.ConsoleCommand("reset user password Wifi Admin " + My.Settings.Password + "{Enter}")
        End If
        MsgBox("Any changes will take effect the next time Opensimulator is started.")
    End Sub

    Private Sub ABEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles AutoBackup.CheckedChanged
        My.Settings.AutoBackup = AutoBackup.Checked
        My.Settings.Save()
    End Sub

    Private Sub AutoBackupInterval_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AutoBackupInterval.SelectedIndexChanged
        Dim text = AutoBackupInterval.SelectedItem.ToString()
        Dim Interval As Integer
        If text = "Hourly" Then Interval = 60
        If text = "12 Hour" Then Interval = 60 * 12
        If text = "Daily" Then Interval = 60 * 24
        If text = "Weekly" Then Interval = 60 * 24 * 7
        My.Settings.AutobackupInterval = Interval
        My.Settings.Save()
    End Sub

    Private Sub AutoBackupKeepFilesForDays_TextChanged(sender As Object, e As EventArgs) Handles AutoBackupKeepFilesForDays.TextChanged
        If Convert.ToInt32(AutoBackupKeepFilesForDays.Text) > 0 Then
            My.Settings.KeepForDays = Convert.ToInt32(AutoBackupKeepFilesForDays.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub ChatSpeed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChatSpeed.SelectedIndexChanged
        Dim text = ChatSpeed.SelectedItem.ToString()
        Dim ChatTime As Integer = 1500

        If text = "Sleepy" Then ChatTime = 1500
        If text = "Awake" Then ChatTime = 1000
        If text = "After Coffee" Then ChatTime = 500
        If text = "Too much Coffee" Then ChatTime = 0

        My.Settings.ChatTime = ChatTime
        My.Settings.Save()
        Form1.gChatTime = ChatTime
    End Sub

    Private Sub TimerInterval_TextChanged(sender As Object, e As EventArgs) Handles TimerInterval.TextChanged
        If Len(TimerInterval.Text) > 0 Then
            My.Settings.TimerInterval = CInt(TimerInterval.Text)
            If (My.Settings.TimerInterval > 0) Then
                Form1.PaintImage()
            Else
                Form1.PictureBox1.Visible = False
            End If
        Else
            Form1.PictureBox1.Visible = False
            My.Settings.TimerInterval = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub RegionButton1_Click(sender As Object, e As EventArgs) Handles RegionButton.Click

        Form1.GetAllRegions()
        Dim X As Integer = 300
        Dim Y As Integer = 200
        Dim fname As String

        Dim counter As Integer = 1
        Dim l = Form1.aRegion.Length ' 5 for 4 items as we skip 0
        While counter <= l - 1      ' so we subtract 1
            Try
                fname = Form1.aRegion(counter).RegionName

                Dim ActualForm As New FormRegion
                ActualForm.SetDesktopLocation(X, Y)
                ActualForm.Init(counter)
                ActualForm.Activate()
                ActualForm.Visible = True
                Application.DoEvents()
            Catch ex As Exception
                Form1.Log("Info:" + ex.Message)
            End Try

            counter = counter + 1
            Y += 100
            X += 100
        End While
    End Sub

    Private Sub AddRegion_Click(sender As Object, e As EventArgs) Handles AddRegion.Click

        Dim X As Integer = 300
        Dim Y As Integer = 200

        Array.Resize(Form1.aRegion, Form1.aRegion.Length + 1)
        Dim index = Form1.aRegion.Length - 1
        Form1.aRegion(index) = New Region_data
        Form1.aRegion(index).RegionPort = 0
        Form1.aRegion(index).CoordX = 0
        Form1.aRegion(index).CoordY = 0
        Form1.aRegion(index).SizeX = 256
        Form1.aRegion(index).SizeY = 256
        Form1.aRegion(index).UUID = ""
        Form1.aRegion(index).RegionName = ""

        Try
            Dim ActualForm As New FormRegion
            ActualForm.SetDesktopLocation(X, Y)
            ActualForm.Init(index)
            ActualForm.Activate()
            ActualForm.Visible = True

        Catch ex As Exception
            Form1.Log("Info:" + ex.Message)
        End Try
    End Sub


    Private Sub VoiceButton1_Click(sender As Object, e As EventArgs) Handles VoiceButton1.Click
        Dim Voice As New Form2
        ' Set the new form's desktop location so it appears below and
        ' to the right of the current form.
        Voice.SetDesktopLocation(300, 200)
        Voice.Activate()
        Voice.Visible = True
    End Sub

    Private Sub MapNone_CheckedChanged(sender As Object, e As EventArgs) Handles MapNone.CheckedChanged
        My.Settings.MapType = "None"
        My.Settings.Save()
        MapPicture.Image = Nothing

    End Sub

    Private Sub MapSimple_CheckedChanged(sender As Object, e As EventArgs) Handles MapSimple.CheckedChanged
        My.Settings.MapType = "Simple"
        My.Settings.Save()
        MapPicture.Image = My.Resources.Simple
    End Sub

    Private Sub MapGood_CheckedChanged(sender As Object, e As EventArgs) Handles MapGood.CheckedChanged
        My.Settings.MapType = "Good"
        My.Settings.Save()
        MapPicture.Image = My.Resources.Good
    End Sub

    Private Sub MapBetter_CheckedChanged(sender As Object, e As EventArgs) Handles MapBetter.CheckedChanged
        My.Settings.MapType = "Better"
        My.Settings.Save()
        MapPicture.Image = My.Resources.Better
    End Sub

    Private Sub MapBest_CheckedChanged(sender As Object, e As EventArgs) Handles MapBest.CheckedChanged
        My.Settings.MapType = "Best"
        My.Settings.Save()
        MapPicture.Image = My.Resources.Best
    End Sub

    Private Sub BackupFolder_clicked(sender As Object, e As EventArgs) Handles BackupFolder.Click
        'Create an instance of the open file dialog box.
        Dim openFileDialog1 As FolderBrowserDialog = New FolderBrowserDialog

        openFileDialog1.ShowNewFolderButton = True
        openFileDialog1.Description = "Pick folder for backups"
        Dim UserClickedOK As Boolean = openFileDialog1.ShowDialog

        ' Process input if the user clicked OK.
        If UserClickedOK = True Then
            Dim thing = openFileDialog1.SelectedPath
            If thing.Length Then
                My.Settings.BackupFolder = thing
                My.Settings.Save()
                BackupFolder.Text = thing
            End If
        End If
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles WelcomeBox1.Click
        LoadWelcomeBox()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WelcomeBox1.SelectedIndexChanged
        My.Settings.WelcomeRegion = WelcomeBox1.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub LoadWelcomeBox()
        ' Default welcome region load
        WelcomeBox1.Items.Clear()
        Dim counter As Integer = 1
        Dim L = Form1.aRegion.GetUpperBound(0)
        While counter <= L
            WelcomeBox1.Items.Add(Form1.aRegion(counter).RegionName)
            counter += 1
        End While

        Try
            WelcomeBox1.SelectedIndex = My.Settings.WelcomeRegion
        Catch ex As Exception
            WelcomeBox1.SelectedIndex = -1
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GloebitsButton.Click
        Dim Gloebits As New Gloebits
        ' Set the new form's desktop location so it appears below and
        ' to the right of the current form.
        Gloebits.SetDesktopLocation(300, 200)
        Gloebits.Activate()
        Gloebits.Visible = True
    End Sub

#End Region

#Region "Help"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim webAddress As String = Form1.Domain + "/Outworldz_installer/technical.htm#GridGod"
        Process.Start(webAddress)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim webAddress As String = Form1.Domain + "/Outworldz_installer/technical.htm#Backup"
        Process.Start(webAddress)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim webAddress As String = Form1.Domain + "/Outworldz_installer/technical.htm#Maps"
        Process.Start(webAddress)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim webAddress As String = Form1.Domain + "/Outworldz_installer/technical.htm#Personality"
        Process.Start(webAddress)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Dim webAddress As String = Form1.Domain + "/Outworldz_installer/technical.htm#Grid"
        Process.Start(webAddress)
    End Sub

    Private Sub ExpertButton1_Click(sender As Object, e As EventArgs) Handles ExpertButton1.Click
        Dim ActualForm As New Expert
        Dim X As Integer = 300
        Dim Y As Integer = 200
        ActualForm.SetDesktopLocation(X, Y)
        ActualForm.Activate()
        ActualForm.Visible = True
        Application.DoEvents()
    End Sub



#End Region


End Class
