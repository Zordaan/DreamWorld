﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdvancedForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvancedForm))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackupFolder = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AutoBackupKeepFilesForDays = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AutoBackupInterval = New System.Windows.Forms.ComboBox()
        Me.AutoBackup = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TimerInterval = New System.Windows.Forms.TextBox()
        Me.ChatSpeed = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MapSimple = New System.Windows.Forms.RadioButton()
        Me.MapBetter = New System.Windows.Forms.RadioButton()
        Me.MapBest = New System.Windows.Forms.RadioButton()
        Me.MapGood = New System.Windows.Forms.RadioButton()
        Me.MapNone = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WelcomeBox1 = New System.Windows.Forms.ComboBox()
        Me.WelcomeRegion = New System.Windows.Forms.Label()
        Me.VoiceButton1 = New System.Windows.Forms.Button()
        Me.MapBox = New System.Windows.Forms.GroupBox()
        Me.MapPicture = New System.Windows.Forms.PictureBox()
        Me.ExpertButton1 = New System.Windows.Forms.Button()
        Me.RegionButton = New System.Windows.Forms.Button()
        Me.AddRegion = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GloebitsButton = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MapBox.SuspendLayout()
        CType(Me.MapPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.BackupFolder)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.AutoBackupKeepFilesForDays)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.AutoBackupInterval)
        Me.GroupBox3.Controls.Add(Me.AutoBackup)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 145)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Auto Backup"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Outworldz.My.Resources.Resources.about
        Me.PictureBox2.Location = New System.Drawing.Point(135, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 32)
        Me.PictureBox2.TabIndex = 1857
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Click for Help on Backup")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Save To Folder:"
        '
        'BackupFolder
        '
        Me.BackupFolder.Location = New System.Drawing.Point(6, 112)
        Me.BackupFolder.Name = "BackupFolder"
        Me.BackupFolder.Size = New System.Drawing.Size(163, 20)
        Me.BackupFolder.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Keep for Days"
        '
        'AutoBackupKeepFilesForDays
        '
        Me.AutoBackupKeepFilesForDays.Location = New System.Drawing.Point(86, 65)
        Me.AutoBackupKeepFilesForDays.Name = "AutoBackupKeepFilesForDays"
        Me.AutoBackupKeepFilesForDays.Size = New System.Drawing.Size(47, 20)
        Me.AutoBackupKeepFilesForDays.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.AutoBackupKeepFilesForDays, "Backaups older than this number will be deleted")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Interval:"
        '
        'AutoBackupInterval
        '
        Me.AutoBackupInterval.AutoCompleteCustomSource.AddRange(New String() {"1 Hour", "4 Hour", "12 Hour", "Daily", "Weekly"})
        Me.AutoBackupInterval.FormattingEnabled = True
        Me.AutoBackupInterval.Items.AddRange(New Object() {"Hourly", "12 Hour", "Daily", "Weekly"})
        Me.AutoBackupInterval.Location = New System.Drawing.Point(6, 39)
        Me.AutoBackupInterval.Name = "AutoBackupInterval"
        Me.AutoBackupInterval.Size = New System.Drawing.Size(121, 21)
        Me.AutoBackupInterval.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.AutoBackupInterval, "The sim nust run this long and it will back up")
        '
        'AutoBackup
        '
        Me.AutoBackup.AutoSize = True
        Me.AutoBackup.Location = New System.Drawing.Point(62, 21)
        Me.AutoBackup.Name = "AutoBackup"
        Me.AutoBackup.Size = New System.Drawing.Size(65, 17)
        Me.AutoBackup.TabIndex = 1
        Me.AutoBackup.Text = "Enabled"
        Me.ToolTip1.SetToolTip(Me.AutoBackup, "Saves OAR files periodically")
        Me.AutoBackup.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox4)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.TimerInterval)
        Me.GroupBox5.Controls.Add(Me.ChatSpeed)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 162)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(182, 81)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Personality"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Outworldz.My.Resources.Resources.about
        Me.PictureBox4.Location = New System.Drawing.Point(141, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 32)
        Me.PictureBox4.TabIndex = 1858
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Click for Help on Personality")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Wallpaper Time (0=Off)"
        '
        'TimerInterval
        '
        Me.TimerInterval.Location = New System.Drawing.Point(135, 38)
        Me.TimerInterval.Name = "TimerInterval"
        Me.TimerInterval.Size = New System.Drawing.Size(39, 20)
        Me.TimerInterval.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.TimerInterval, "The cycle time for the wall paper - in seconds. 0 = Off")
        '
        'ChatSpeed
        '
        Me.ChatSpeed.FormattingEnabled = True
        Me.ChatSpeed.Items.AddRange(New Object() {"Sleepy", "Awake", "After Coffee", "Too much Coffee"})
        Me.ChatSpeed.Location = New System.Drawing.Point(9, 14)
        Me.ChatSpeed.Name = "ChatSpeed"
        Me.ChatSpeed.Size = New System.Drawing.Size(113, 21)
        Me.ChatSpeed.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.ChatSpeed, "The speed the sleepy chat occurs at.  ")
        '
        'MapSimple
        '
        Me.MapSimple.AutoSize = True
        Me.MapSimple.Location = New System.Drawing.Point(23, 48)
        Me.MapSimple.Name = "MapSimple"
        Me.MapSimple.Size = New System.Drawing.Size(94, 17)
        Me.MapSimple.TabIndex = 33
        Me.MapSimple.TabStop = True
        Me.MapSimple.Text = "Simple but fast"
        Me.ToolTip1.SetToolTip(Me.MapSimple, "Simple - ")
        Me.MapSimple.UseVisualStyleBackColor = True
        '
        'MapBetter
        '
        Me.MapBetter.AutoSize = True
        Me.MapBetter.Location = New System.Drawing.Point(24, 87)
        Me.MapBetter.Name = "MapBetter"
        Me.MapBetter.Size = New System.Drawing.Size(116, 17)
        Me.MapBetter.TabIndex = 35
        Me.MapBetter.TabStop = True
        Me.MapBetter.Text = "Better (Prims, Slow)"
        Me.MapBetter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ToolTip1.SetToolTip(Me.MapBetter, "Warp3DImageModule with Prims and Textures")
        Me.MapBetter.UseVisualStyleBackColor = True
        '
        'MapBest
        '
        Me.MapBest.AutoSize = True
        Me.MapBest.Location = New System.Drawing.Point(23, 109)
        Me.MapBest.Name = "MapBest"
        Me.MapBest.Size = New System.Drawing.Size(144, 17)
        Me.MapBest.TabIndex = 136
        Me.MapBest.TabStop = True
        Me.MapBest.Text = "Best (Prims +Mesh, Slow)"
        Me.ToolTip1.SetToolTip(Me.MapBest, "Slow, but has Prims and Mesh")
        Me.MapBest.UseVisualStyleBackColor = True
        '
        'MapGood
        '
        Me.MapGood.AutoSize = True
        Me.MapGood.Location = New System.Drawing.Point(24, 67)
        Me.MapGood.Name = "MapGood"
        Me.MapGood.Size = New System.Drawing.Size(100, 17)
        Me.MapGood.TabIndex = 34
        Me.MapGood.TabStop = True
        Me.MapGood.Text = "Good (Warp3D)"
        Me.ToolTip1.SetToolTip(Me.MapGood, "Fast and simple map usng Warp3DImageModule")
        Me.MapGood.UseVisualStyleBackColor = True
        '
        'MapNone
        '
        Me.MapNone.AutoSize = True
        Me.MapNone.Location = New System.Drawing.Point(23, 29)
        Me.MapNone.Name = "MapNone"
        Me.MapNone.Size = New System.Drawing.Size(51, 17)
        Me.MapNone.TabIndex = 137
        Me.MapNone.TabStop = True
        Me.MapNone.Text = "None"
        Me.ToolTip1.SetToolTip(Me.MapNone, "No Maps at all")
        Me.MapNone.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Outworldz.My.Resources.Resources.about
        Me.PictureBox3.Location = New System.Drawing.Point(80, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 27)
        Me.PictureBox3.TabIndex = 1857
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Click for Help on Grid Gods")
        '
        'WelcomeBox1
        '
        Me.WelcomeBox1.AutoCompleteCustomSource.AddRange(New String() {"1 Hour", "4 Hour", "12 Hour", "Daily", "Weekly"})
        Me.WelcomeBox1.FormattingEnabled = True
        Me.WelcomeBox1.Items.AddRange(New Object() {"Hourly", "12 Hour", "Daily", "Weekly"})
        Me.WelcomeBox1.Location = New System.Drawing.Point(4, 38)
        Me.WelcomeBox1.Name = "WelcomeBox1"
        Me.WelcomeBox1.Size = New System.Drawing.Size(148, 21)
        Me.WelcomeBox1.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.WelcomeBox1, "The first sim a visitor will arrive in")
        '
        'WelcomeRegion
        '
        Me.WelcomeRegion.AutoSize = True
        Me.WelcomeRegion.Location = New System.Drawing.Point(6, 22)
        Me.WelcomeRegion.Name = "WelcomeRegion"
        Me.WelcomeRegion.Size = New System.Drawing.Size(123, 13)
        Me.WelcomeRegion.TabIndex = 32
        Me.WelcomeRegion.Text = "Default region for visitors"
        Me.ToolTip1.SetToolTip(Me.WelcomeRegion, "This region is where visitors first arrive")
        '
        'VoiceButton1
        '
        Me.VoiceButton1.Location = New System.Drawing.Point(399, 185)
        Me.VoiceButton1.Name = "VoiceButton1"
        Me.VoiceButton1.Size = New System.Drawing.Size(132, 23)
        Me.VoiceButton1.TabIndex = 30
        Me.VoiceButton1.Text = "Voice Settings"
        Me.VoiceButton1.UseVisualStyleBackColor = True
        '
        'MapBox
        '
        Me.MapBox.Controls.Add(Me.PictureBox3)
        Me.MapBox.Controls.Add(Me.MapPicture)
        Me.MapBox.Controls.Add(Me.MapNone)
        Me.MapBox.Controls.Add(Me.MapSimple)
        Me.MapBox.Controls.Add(Me.MapBetter)
        Me.MapBox.Controls.Add(Me.MapBest)
        Me.MapBox.Controls.Add(Me.MapGood)
        Me.MapBox.Location = New System.Drawing.Point(204, 12)
        Me.MapBox.Name = "MapBox"
        Me.MapBox.Size = New System.Drawing.Size(180, 231)
        Me.MapBox.TabIndex = 137
        Me.MapBox.TabStop = False
        Me.MapBox.Text = "Maps"
        '
        'MapPicture
        '
        Me.MapPicture.InitialImage = CType(resources.GetObject("MapPicture.InitialImage"), System.Drawing.Image)
        Me.MapPicture.Location = New System.Drawing.Point(49, 132)
        Me.MapPicture.Name = "MapPicture"
        Me.MapPicture.Size = New System.Drawing.Size(100, 93)
        Me.MapPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MapPicture.TabIndex = 138
        Me.MapPicture.TabStop = False
        '
        'ExpertButton1
        '
        Me.ExpertButton1.Location = New System.Drawing.Point(399, 214)
        Me.ExpertButton1.Name = "ExpertButton1"
        Me.ExpertButton1.Size = New System.Drawing.Size(132, 23)
        Me.ExpertButton1.TabIndex = 1859
        Me.ExpertButton1.Text = "Expert Settings"
        Me.ExpertButton1.UseVisualStyleBackColor = True
        '
        'RegionButton
        '
        Me.RegionButton.Location = New System.Drawing.Point(4, 94)
        Me.RegionButton.Name = "RegionButton"
        Me.RegionButton.Size = New System.Drawing.Size(148, 23)
        Me.RegionButton.TabIndex = 27
        Me.RegionButton.Text = "Configure Regions"
        Me.RegionButton.UseVisualStyleBackColor = True
        '
        'AddRegion
        '
        Me.AddRegion.Location = New System.Drawing.Point(4, 65)
        Me.AddRegion.Name = "AddRegion"
        Me.AddRegion.Size = New System.Drawing.Size(148, 23)
        Me.AddRegion.TabIndex = 26
        Me.AddRegion.Text = "Add Region"
        Me.AddRegion.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 28
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WelcomeRegion)
        Me.GroupBox2.Controls.Add(Me.WelcomeBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.AddRegion)
        Me.GroupBox2.Controls.Add(Me.RegionButton)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 131)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Regions"
        '
        'GloebitsButton
        '
        Me.GloebitsButton.Location = New System.Drawing.Point(399, 156)
        Me.GloebitsButton.Name = "GloebitsButton"
        Me.GloebitsButton.Size = New System.Drawing.Size(132, 23)
        Me.GloebitsButton.TabIndex = 1860
        Me.GloebitsButton.Text = "Gloebits Currency"
        Me.GloebitsButton.UseVisualStyleBackColor = True
        '
        'AdvancedForm
        '
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(565, 268)
        Me.Controls.Add(Me.GloebitsButton)
        Me.Controls.Add(Me.ExpertButton1)
        Me.Controls.Add(Me.MapBox)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.VoiceButton1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdvancedForm"
        Me.Text = "Advanced"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MapBox.ResumeLayout(False)
        Me.MapBox.PerformLayout()
        CType(Me.MapPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AutoBackup As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents AutoBackupInterval As ComboBox
    Friend WithEvents AutoBackupKeepFilesForDays As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TimerInterval As TextBox
    Friend WithEvents ChatSpeed As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents VoiceButton1 As Button
    Friend WithEvents MapBox As GroupBox
    Friend WithEvents MapSimple As RadioButton
    Friend WithEvents MapBetter As RadioButton
    Friend WithEvents MapBest As RadioButton
    Friend WithEvents MapGood As RadioButton
    Friend WithEvents MapNone As RadioButton
    Friend WithEvents MapPicture As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BackupFolder As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ExpertButton1 As Button
    Friend WithEvents RegionButton As Button
    Friend WithEvents AddRegion As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents WelcomeBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents WelcomeRegion As Label
    Friend WithEvents GloebitsButton As Button
End Class
