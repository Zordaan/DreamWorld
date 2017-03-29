Imports System.Diagnostics.Debug
Imports System.Net

Public Class Expert
#Region "Load/Exit"


    Private Sub Loaded(sender As Object, e As EventArgs) Handles Me.Load

        'ports
        PublicPort.Text = My.Settings.PublicPort
        PrivatePort.Text = My.Settings.PrivatePort
        httpPort.Text = My.Settings.HttpPort

        If Form1.isRunning Then
            StatsButton.Enabled = True
        Else
            StatsButton.Enabled = False
        End If

        'passwords are asterisks
        Password.UseSystemPasswordChar = True
        DbPassword.UseSystemPasswordChar = True
        SmtpPassword.UseSystemPasswordChar = True

        ' ports
        DbPort.Text = My.Settings.MySqlPort
        Password.Text = My.Settings.Password
        AdminLast.Text = My.Settings.AdminLast
        AdminFirst.Text = My.Settings.AdminFirst

        'gods
        AllowGod.Checked = My.Settings.allow_grid_gods
        RegionGod.Checked = My.Settings.region_owner_is_god
        ManagerGod.Checked = My.Settings.region_manager_is_god
        ParcelGod.Checked = My.Settings.parcel_owner_is_god

        'Wifi
        AdminEmail.Text = My.Settings.AdminEmail
        AccountConfirmationRequired.Checked = My.Settings.AccountConfirmationRequired
        SmtpPassword.Text = My.Settings.SmtpPassword
        SmtpUsername.Text = My.Settings.SmtpUsername

        'Database Names
        DbConnection.Text = My.Settings.DBSource
        StandaloneDbName.Text = My.Settings.DBName
        FullGridName.Text = My.Settings.GridDbName
        RobustDbName.Text = My.Settings.RobustDbName

        'User Names for db
        DbUsername.Text = My.Settings.DBUserID
        DbPassword.Text = My.Settings.DBPassword
        SplashPage.Text = My.Settings.SplashPage

        ' physics engines differ between 0.8.2.1 and 0.9.1
        If My.Settings.GridFolder = "Opensim" And PhysicsubODE.Checked Then
            My.Settings.Physics = 3 ' They just switched engines, set a default of Bullet, separate thread for 0.8.1
            My.Settings.Save()
            PhysicsSeparate.Checked = True
        End If

        If My.Settings.GridFolder = "Opensim" Then
            PhysicsubODE.Enabled = False
            Web.Enabled = False
        Else
            PhysicsubODE.Enabled = True
            Web.Enabled = True
        End If

        Select Case My.Settings.Physics
            Case 0 : PhysicsNone.Checked = True
            Case 1 : PhysicsODE.Checked = True
            Case 2 : PhysicsBullet.Checked = True
            Case 3 : PhysicsSeparate.Checked = True
            Case 4 : PhysicsubODE.Checked = True
            Case Else : PhysicsSeparate.Checked = True
        End Select

        ' Grid
        If My.Settings.GridFolder = "Opensim" Then
            V8Button.Checked = True
            Form1.Log("Info:0.8.2.1 enabled")
        Else
            V9Button.Checked = True
            Form1.Log("Info:0.9.1 enabled")
        End If

        GridName.Text = My.Settings.SimName
        DnsName.Text = My.Settings.DnsName

        FullgridButton.Checked = My.Settings.RobustEnabled
        StandaloneButton.Checked = Not My.Settings.RobustEnabled

    End Sub
#End Region

#Region "Ports"
    Private Sub http_Port_TextChanged(sender As Object, e As EventArgs) Handles httpPort.TextChanged
        My.Settings.HttpPort = httpPort.Text
        My.Settings.Save()
    End Sub
    Private Sub PrivatePort_TextChanged(sender As Object, e As EventArgs) Handles PrivatePort.TextChanged
        My.Settings.PrivatePort = PrivatePort.Text
        My.Settings.Save()
    End Sub

    Private Sub PublicPort_TextChanged(sender As Object, e As EventArgs) Handles PublicPort.TextChanged
        My.Settings.PublicPort = PublicPort.Text
        My.Settings.Save()
    End Sub



#End Region

#Region "Wifi"
    Private Sub AdminFirst_TextChanged_2(sender As Object, e As EventArgs) Handles AdminFirst.TextChanged
        My.Settings.AdminFirst = AdminFirst.Text
        My.Settings.Save()
    End Sub

    Private Sub AdminLast_TextChanged(sender As Object, e As EventArgs) Handles AdminLast.TextChanged
        My.Settings.AdminLast = AdminLast.Text
        My.Settings.Save()
    End Sub

    Private Sub Password_click(sender As Object, e As EventArgs) Handles Password.Click
        Password.UseSystemPasswordChar = False
    End Sub
    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        My.Settings.Password = Password.Text
        My.Settings.Save()

        If Form1.Running Then
            Form1.ConsoleCommand("reset user password Wifi Admin " + My.Settings.Password + "{Enter}")
        End If
    End Sub

    Private Sub TextBox1_TextChanged_3(sender As Object, e As EventArgs) Handles AdminEmail.TextChanged
        My.Settings.AdminEmail = AdminEmail.Text
        My.Settings.Save()
    End Sub

    Private Sub AccountConfirmationRequired_CheckedChanged(sender As Object, e As EventArgs) Handles AccountConfirmationRequired.CheckedChanged
        My.Settings.AccountConfirmationRequired = AccountConfirmationRequired.Checked
        My.Settings.Save()
    End Sub

    Private Sub SmtpUsername_TextChanged(sender As Object, e As EventArgs) Handles SmtpUsername.TextChanged
        My.Settings.SmtpUsername = SmtpUsername.Text
        My.Settings.Save()
    End Sub
    Private Sub SmtpUsername_Click(sender As Object, e As EventArgs) Handles SmtpPassword.Click
        SmtpPassword.UseSystemPasswordChar = False
    End Sub
    Private Sub SmtpPassword_TextChanged(sender As Object, e As EventArgs) Handles SmtpPassword.TextChanged
        My.Settings.SmtpPassword = SmtpPassword.Text
        My.Settings.Save()
    End Sub
#End Region

#Region "Gods"
    Private Sub AllowGod_CheckedChanged(sender As Object, e As EventArgs) Handles AllowGod.CheckedChanged
        My.Settings.allow_grid_gods = AllowGod.Checked
        My.Settings.Save()
    End Sub
    Private Sub RegionGod_CheckedChanged(sender As Object, e As EventArgs) Handles RegionGod.CheckedChanged
        My.Settings.region_owner_is_god = RegionGod.Checked
        My.Settings.Save()
    End Sub

    Private Sub ManagerGod_CheckedChanged(sender As Object, e As EventArgs) Handles ManagerGod.CheckedChanged
        My.Settings.region_manager_is_god = ManagerGod.Checked
        My.Settings.Save()
    End Sub

    Private Sub ParcelGod_CheckedChanged(sender As Object, e As EventArgs) Handles ParcelGod.CheckedChanged
        My.Settings.parcel_owner_is_god = ParcelGod.Checked
        My.Settings.Save()
    End Sub

#End Region

#Region "Stats"

    Private Sub StatsButton_Click(sender As Object, e As EventArgs) Handles StatsButton.Click
        If Form1.isRunning And WebStats.Checked Then
            Dim webAddress As String = "http://127.0.0.1:" + My.Settings.HttpPort + "/SStats/"
            Process.Start(webAddress)
        Else
            Print("Opensim is not running. Cannot open the Statistics web page.")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles WebStats.CheckedChanged
        My.Settings.WebStats = WebStats.Checked
        My.Settings.Save()
        Form1.WebStatsToolStripMenuItem.Visible = WebStats.Checked
    End Sub
#End Region

#Region "Splash"

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles SplashPage.TextChanged
        My.Settings.SplashPage = SplashPage.Text
        My.Settings.Save()
    End Sub
#End Region

#Region "Physics"

    Private Sub PhysicsNone_CheckedChanged(sender As Object, e As EventArgs) Handles PhysicsNone.CheckedChanged
        If PhysicsNone.Checked Then
            My.Settings.Physics = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles PhysicsODE.CheckedChanged
        If PhysicsODE.Checked Then
            My.Settings.Physics = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub PhysicsBullet_CheckedChanged(sender As Object, e As EventArgs) Handles PhysicsBullet.CheckedChanged
        If PhysicsBullet.Checked Then
            My.Settings.Physics = 2
            My.Settings.Save()
        End If
    End Sub

    Private Sub PhysicsSeparate_CheckedChanged(sender As Object, e As EventArgs) Handles PhysicsSeparate.CheckedChanged
        If PhysicsSeparate.Checked Then
            My.Settings.Physics = 3
            My.Settings.Save()
        End If
    End Sub

    Private Sub PhysicsubODE_CheckedChanged(sender As Object, e As EventArgs) Handles PhysicsubODE.CheckedChanged
        If PhysicsubODE.Checked Then
            My.Settings.Physics = 4
            My.Settings.Save()
        End If
    End Sub

#End Region

#Region "V8/V9 Buttons"

    Private Sub V9Button_CheckedChanged(sender As Object, e As EventArgs) Handles V9Button.CheckedChanged
        My.Settings.GridFolder = "Opensim-0.9"
        My.Settings.Save()
        Try
            My.Computer.FileSystem.RenameFile(Form1.MyFolder & "\OutworldzFiles\" & My.Settings.GridFolder & "\bin\Regions\RegionConfig.ini", "Outworldz.ini")
        Catch ex As Exception
        End Try
        Form1.ViewWebUI.Visible = False
        Web.Enabled = False
    End Sub

    Private Sub V8Button_CheckedChanged(sender As Object, e As EventArgs) Handles V8Button.CheckedChanged
        My.Settings.GridFolder = "Opensim"
        My.Settings.Save()
        Try
            My.Computer.FileSystem.RenameFile(Form1.MyFolder & "\OutworldzFiles\" & My.Settings.GridFolder & "\bin\Regions\RegionConfig.ini", "Outworldz.ini")
        Catch ex As Exception
        End Try
        Form1.ViewWebUI.Visible = True
        Web.Enabled = True
    End Sub



    Private Sub StandaloneButton_CheckedChanged(sender As Object, e As EventArgs) Handles StandaloneButton.CheckedChanged
        If StandaloneButton.Checked = True Then
            FullgridButton.Checked = False

            RobustDbName.Enabled = False
            StandaloneDbName.Enabled = True
            FullGridName.Enabled = False
        Else
            FullGridName.Enabled = True
            RobustDbName.Enabled = True
            StandaloneDbName.Enabled = False
        End If
    End Sub
    Private Sub Fullgrid_CheckedChanged(sender As Object, e As EventArgs) Handles FullgridButton.CheckedChanged
        If FullgridButton.Checked = True Then
            StandaloneButton.Checked = False

            RobustDbName.Enabled = True
            StandaloneDbName.Enabled = False
            FullGridName.Enabled = True
        Else
            RobustDbName.Enabled = False
            StandaloneDbName.Enabled = True
            FullGridName.Enabled = False
        End If
    End Sub

#End Region

#Region "DNS"

    Private Sub GridName_TextChanged_1(sender As Object, e As EventArgs) Handles GridName.TextChanged
        My.Settings.SimName = GridName.Text
        My.Settings.Save()
    End Sub

    Private Sub DnsName_TextChanged_1(sender As Object, e As EventArgs) Handles DnsName.TextChanged
        My.Settings.PublicIP = DnsName.Text
        My.Settings.Save()
    End Sub

    Private Sub DnsName_TextChanged(sender As Object, e As EventArgs) Handles DnsName.Click
        Dim F As New DNSName
        F.Show()
    End Sub

    Private Sub TestButton1_Click_1(sender As Object, e As EventArgs) Handles TestButton1.Click
        Dim IP = Form1.DoGetHostAddresses(DnsName.Text)
        Dim address As IPAddress = Nothing
        If IPAddress.TryParse(IP, address) Then
            MsgBox("IP address was sucessfully resolved to " + IP)
        Else
            MsgBox("Cannot resolve " + DnsName.Text)
        End If
    End Sub

    Private Sub HypericaButton_Click(sender As Object, e As EventArgs) Handles HypericaButton.Click
        Dim webAddress As String = "http://www.hyperica.com/directory/?GridName=" + My.Settings.DnsName
        Process.Start(webAddress)
    End Sub
#End Region


#Region "Database"

    Private Sub DbPort_TextChanged_1(sender As Object, e As EventArgs) Handles DbPort.TextChanged
        My.Settings.MySqlPort = DbPort.Text
        My.Settings.Save()
    End Sub
    Private Sub DatabaseNameUser_TextChanged(sender As Object, e As EventArgs) Handles StandaloneDbName.TextChanged
        My.Settings.DBName = StandaloneDbName.Text
        My.Settings.Save()
    End Sub

    Private Sub DbConnection_TextChanged(sender As Object, e As EventArgs) Handles DbConnection.TextChanged
        My.Settings.DBSource = DbConnection.Text
        My.Settings.Save()
    End Sub

    Private Sub DbUsername_TextChanged(sender As Object, e As EventArgs) Handles DbUsername.TextChanged
        My.Settings.DBUserID = DbUsername.Text
        My.Settings.Save()

    End Sub
    Private Sub DbPassword_click(sender As Object, e As EventArgs) Handles DbPassword.Click
        DbPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub DbPassword_TextChanged(sender As Object, e As EventArgs) Handles DbPassword.TextChanged
        My.Settings.DBPassword = DbPassword.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles RobustDbName.TextChanged
        My.Settings.RobustDbName = RobustDbName.Text
        My.Settings.Save()
    End Sub

#End Region

End Class