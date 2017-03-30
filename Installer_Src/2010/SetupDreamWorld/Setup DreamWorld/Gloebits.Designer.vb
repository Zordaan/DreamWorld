<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gloebits
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gloebits))
        Me.SandboxButton = New System.Windows.Forms.RadioButton()
        Me.GloebitsEnabled = New System.Windows.Forms.CheckBox()
        Me.SandKeyTextBox = New System.Windows.Forms.TextBox()
        Me.SandSecretTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SandBoxCreateAppButton = New System.Windows.Forms.Button()
        Me.SandBoxReqAppButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SandBoxSignUpButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContactEmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OwnerNameTextbox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProductionCreateAppButton = New System.Windows.Forms.Button()
        Me.ProductionReqAppButton = New System.Windows.Forms.Button()
        Me.ProductionCreateButton = New System.Windows.Forms.Button()
        Me.ProductionButton = New System.Windows.Forms.RadioButton()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ProdKeyTextBox = New System.Windows.Forms.TextBox()
        Me.ProdSecretTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SandboxButton
        '
        Me.SandboxButton.AutoSize = True
        Me.SandboxButton.Location = New System.Drawing.Point(60, 25)
        Me.SandboxButton.Name = "SandboxButton"
        Me.SandboxButton.Size = New System.Drawing.Size(67, 17)
        Me.SandboxButton.TabIndex = 1
        Me.SandboxButton.TabStop = True
        Me.SandboxButton.Text = "Sandbox"
        Me.ToolTip1.SetToolTip(Me.SandboxButton, "sandbox - connects to sandbox.gloebit.com;  fake/sandboxed payments and gloebits")
        Me.SandboxButton.UseVisualStyleBackColor = True
        '
        'GloebitsEnabled
        '
        Me.GloebitsEnabled.AutoSize = True
        Me.GloebitsEnabled.Location = New System.Drawing.Point(103, 84)
        Me.GloebitsEnabled.Name = "GloebitsEnabled"
        Me.GloebitsEnabled.Size = New System.Drawing.Size(100, 17)
        Me.GloebitsEnabled.TabIndex = 2
        Me.GloebitsEnabled.Text = "Enable Gloebits"
        Me.GloebitsEnabled.UseVisualStyleBackColor = True
        '
        'SandKeyTextBox
        '
        Me.SandKeyTextBox.Location = New System.Drawing.Point(60, 147)
        Me.SandKeyTextBox.Name = "SandKeyTextBox"
        Me.SandKeyTextBox.Size = New System.Drawing.Size(157, 20)
        Me.SandKeyTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.SandKeyTextBox, "Fill in GLBKey and GLBSecret with values from app created at https://sandbox.gloe" &
        "bit.com/merchant-tools/")
        '
        'SandSecretTextBox
        '
        Me.SandSecretTextBox.Location = New System.Drawing.Point(60, 178)
        Me.SandSecretTextBox.Name = "SandSecretTextBox"
        Me.SandSecretTextBox.Size = New System.Drawing.Size(157, 20)
        Me.SandSecretTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.SandSecretTextBox, "Fill in GLBKey and GLBSecret with values from app created at https://sandbox.gloe" &
        "bit.com/merchant-tools/")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "OAuth Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Secret"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.SandBoxCreateAppButton)
        Me.GroupBox1.Controls.Add(Me.SandKeyTextBox)
        Me.GroupBox1.Controls.Add(Me.SandBoxReqAppButton)
        Me.GroupBox1.Controls.Add(Me.SandSecretTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SandBoxSignUpButton)
        Me.GroupBox1.Controls.Add(Me.SandboxButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 225)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sandbox Mode"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Step 3:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Step 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Step 1:"
        '
        'SandBoxCreateAppButton
        '
        Me.SandBoxCreateAppButton.Location = New System.Drawing.Point(58, 115)
        Me.SandBoxCreateAppButton.Name = "SandBoxCreateAppButton"
        Me.SandBoxCreateAppButton.Size = New System.Drawing.Size(151, 27)
        Me.SandBoxCreateAppButton.TabIndex = 14
        Me.SandBoxCreateAppButton.Text = "Create App and Get Keys"
        Me.ToolTip1.SetToolTip(Me.SandBoxCreateAppButton, "Create app and retrieve Key and Secret")
        Me.SandBoxCreateAppButton.UseVisualStyleBackColor = True
        '
        'SandBoxReqAppButton
        '
        Me.SandBoxReqAppButton.Location = New System.Drawing.Point(56, 84)
        Me.SandBoxReqAppButton.Name = "SandBoxReqAppButton"
        Me.SandBoxReqAppButton.Size = New System.Drawing.Size(151, 25)
        Me.SandBoxReqAppButton.TabIndex = 13
        Me.SandBoxReqAppButton.Text = "Request App Creation"
        Me.ToolTip1.SetToolTip(Me.SandBoxReqAppButton, "Request ability to create apps")
        Me.SandBoxReqAppButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mode:"
        '
        'SandBoxSignUpButton
        '
        Me.SandBoxSignUpButton.Location = New System.Drawing.Point(56, 51)
        Me.SandBoxSignUpButton.Name = "SandBoxSignUpButton"
        Me.SandBoxSignUpButton.Size = New System.Drawing.Size(151, 27)
        Me.SandBoxSignUpButton.TabIndex = 7
        Me.SandBoxSignUpButton.Text = "Create Sandbox Account"
        Me.ToolTip1.SetToolTip(Me.SandBoxSignUpButton, "Create sandbox account")
        Me.SandBoxSignUpButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contact Email"
        '
        'ContactEmailTextBox
        '
        Me.ContactEmailTextBox.Location = New System.Drawing.Point(103, 45)
        Me.ContactEmailTextBox.Name = "ContactEmailTextBox"
        Me.ContactEmailTextBox.Size = New System.Drawing.Size(213, 20)
        Me.ContactEmailTextBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.ContactEmailTextBox, "The email address (or other contact mechanism) for the person who manages this Op" &
        "enSim process.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contact Name"
        '
        'OwnerNameTextbox
        '
        Me.OwnerNameTextbox.Location = New System.Drawing.Point(103, 19)
        Me.OwnerNameTextbox.Name = "OwnerNameTextbox"
        Me.OwnerNameTextbox.Size = New System.Drawing.Size(213, 20)
        Me.OwnerNameTextbox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.OwnerNameTextbox, "The name of the person or avatar which manages this OpenSim process")
        '
        'ProductionCreateAppButton
        '
        Me.ProductionCreateAppButton.Location = New System.Drawing.Point(59, 113)
        Me.ProductionCreateAppButton.Name = "ProductionCreateAppButton"
        Me.ProductionCreateAppButton.Size = New System.Drawing.Size(151, 27)
        Me.ProductionCreateAppButton.TabIndex = 14
        Me.ProductionCreateAppButton.Text = "Create App and Get Keys"
        Me.ToolTip1.SetToolTip(Me.ProductionCreateAppButton, "Create app and retrieve Key and Secret")
        Me.ProductionCreateAppButton.UseVisualStyleBackColor = True
        '
        'ProductionReqAppButton
        '
        Me.ProductionReqAppButton.Location = New System.Drawing.Point(57, 82)
        Me.ProductionReqAppButton.Name = "ProductionReqAppButton"
        Me.ProductionReqAppButton.Size = New System.Drawing.Size(151, 25)
        Me.ProductionReqAppButton.TabIndex = 13
        Me.ProductionReqAppButton.Text = "Request App Creation"
        Me.ToolTip1.SetToolTip(Me.ProductionReqAppButton, "request ability to create apps")
        Me.ProductionReqAppButton.UseVisualStyleBackColor = True
        '
        'ProductionCreateButton
        '
        Me.ProductionCreateButton.Location = New System.Drawing.Point(57, 49)
        Me.ProductionCreateButton.Name = "ProductionCreateButton"
        Me.ProductionCreateButton.Size = New System.Drawing.Size(151, 27)
        Me.ProductionCreateButton.TabIndex = 7
        Me.ProductionCreateButton.Text = "Create Production Account"
        Me.ToolTip1.SetToolTip(Me.ProductionCreateButton, "Create production account")
        Me.ProductionCreateButton.UseVisualStyleBackColor = True
        '
        'ProductionButton
        '
        Me.ProductionButton.AutoSize = True
        Me.ProductionButton.Location = New System.Drawing.Point(59, 25)
        Me.ProductionButton.Name = "ProductionButton"
        Me.ProductionButton.Size = New System.Drawing.Size(76, 17)
        Me.ProductionButton.TabIndex = 0
        Me.ProductionButton.TabStop = True
        Me.ProductionButton.Text = "Production"
        Me.ToolTip1.SetToolTip(Me.ProductionButton, "production - connects to www.gloebit.com; real payments and gloebits")
        Me.ProductionButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(39, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(374, 27)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Click To Get a Free Gloebits Account So You Can Buy and Sell "
        Me.ToolTip1.SetToolTip(Me.Button4, "Create sandbox account")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ProdKeyTextBox
        '
        Me.ProdKeyTextBox.Location = New System.Drawing.Point(62, 150)
        Me.ProdKeyTextBox.Name = "ProdKeyTextBox"
        Me.ProdKeyTextBox.Size = New System.Drawing.Size(157, 20)
        Me.ProdKeyTextBox.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.ProdKeyTextBox, "Fill in GLBKey and GLBSecret with values from app created at https://sandbox.gloe" &
        "bit.com/merchant-tools/")
        '
        'ProdSecretTextBox
        '
        Me.ProdSecretTextBox.Location = New System.Drawing.Point(62, 181)
        Me.ProdSecretTextBox.Name = "ProdSecretTextBox"
        Me.ProdSecretTextBox.Size = New System.Drawing.Size(157, 20)
        Me.ProdSecretTextBox.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.ProdSecretTextBox, "Fill in GLBKey and GLBSecret with values from app created at https://sandbox.gloe" &
        "bit.com/merchant-tools/")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(354, 290)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1859
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Click for Help on Grid Gods")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Outworldz.My.Resources.Resources.about
        Me.PictureBox3.Location = New System.Drawing.Point(444, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 27)
        Me.PictureBox3.TabIndex = 1858
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Click for Help on Grid Gods")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.ProdKeyTextBox)
        Me.GroupBox2.Controls.Add(Me.ProdSecretTextBox)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ProductionCreateAppButton)
        Me.GroupBox2.Controls.Add(Me.ProductionReqAppButton)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.ProductionCreateButton)
        Me.GroupBox2.Controls.Add(Me.ProductionButton)
        Me.GroupBox2.Location = New System.Drawing.Point(253, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 225)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Production Mode"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Secret"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(2, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "OAuth Key"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Step 3:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Step 2:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Step 1:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Mode:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OwnerNameTextbox)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ContactEmailTextBox)
        Me.GroupBox3.Controls.Add(Me.GloebitsEnabled)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 289)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 109)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact Info"
        '
        'Gloebits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(493, 441)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Gloebits"
        Me.Text = "Gloebits"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SandboxButton As RadioButton
    Friend WithEvents GloebitsEnabled As CheckBox
    Friend WithEvents SandKeyTextBox As TextBox
    Friend WithEvents SandSecretTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SandBoxSignUpButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents OwnerNameTextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ContactEmailTextBox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SandBoxCreateAppButton As Button
    Friend WithEvents SandBoxReqAppButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ProductionCreateAppButton As Button
    Friend WithEvents ProductionReqAppButton As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents ProductionCreateButton As Button
    Friend WithEvents ProductionButton As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ProdKeyTextBox As TextBox
    Friend WithEvents ProdSecretTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
