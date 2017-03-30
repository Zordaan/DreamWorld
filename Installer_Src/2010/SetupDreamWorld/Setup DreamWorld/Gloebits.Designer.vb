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
        Me.ProductionButton = New System.Windows.Forms.RadioButton()
        Me.SandboxButton = New System.Windows.Forms.RadioButton()
        Me.GloebitsEnabled = New System.Windows.Forms.CheckBox()
        Me.OAuthKeyTextBox = New System.Windows.Forms.TextBox()
        Me.OAuthSecretTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GloebitsWebsiteButton = New System.Windows.Forms.Button()
        Me.OwnerNameTextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContactEmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductionButton
        '
        Me.ProductionButton.AutoSize = True
        Me.ProductionButton.Location = New System.Drawing.Point(166, 122)
        Me.ProductionButton.Name = "ProductionButton"
        Me.ProductionButton.Size = New System.Drawing.Size(76, 17)
        Me.ProductionButton.TabIndex = 0
        Me.ProductionButton.TabStop = True
        Me.ProductionButton.Text = "Production"
        Me.ToolTip1.SetToolTip(Me.ProductionButton, "production - connects to www.gloebit.com; real payments and gloebits")
        Me.ProductionButton.UseVisualStyleBackColor = True
        '
        'SandboxButton
        '
        Me.SandboxButton.AutoSize = True
        Me.SandboxButton.Location = New System.Drawing.Point(93, 122)
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
        Me.GloebitsEnabled.Location = New System.Drawing.Point(9, 84)
        Me.GloebitsEnabled.Name = "GloebitsEnabled"
        Me.GloebitsEnabled.Size = New System.Drawing.Size(100, 17)
        Me.GloebitsEnabled.TabIndex = 2
        Me.GloebitsEnabled.Text = "Enable Gloebits"
        Me.GloebitsEnabled.UseVisualStyleBackColor = True
        '
        'OAuthKeyTextBox
        '
        Me.OAuthKeyTextBox.Location = New System.Drawing.Point(93, 215)
        Me.OAuthKeyTextBox.Name = "OAuthKeyTextBox"
        Me.OAuthKeyTextBox.Size = New System.Drawing.Size(149, 20)
        Me.OAuthKeyTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.OAuthKeyTextBox, "Fill in GLBKey and GLBSecret with values from app created at https://sandbox.gloe" &
        "bit.com/merchant-tools/")
        '
        'OAuthSecretTextBox
        '
        Me.OAuthSecretTextBox.Location = New System.Drawing.Point(93, 243)
        Me.OAuthSecretTextBox.Name = "OAuthSecretTextBox"
        Me.OAuthSecretTextBox.Size = New System.Drawing.Size(149, 20)
        Me.OAuthSecretTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.OAuthSecretTextBox, "Fill in GLBKey and GLBSecret with values from app created at https://sandbox.gloe" &
        "bit.com/merchant-tools/")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "OAuth Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "OAuth Secret"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ContactEmailTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.OwnerNameTextbox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GloebitsWebsiteButton)
        Me.GroupBox1.Controls.Add(Me.GloebitsEnabled)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ProductionButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SandboxButton)
        Me.GroupBox1.Controls.Add(Me.OAuthSecretTextBox)
        Me.GroupBox1.Controls.Add(Me.OAuthKeyTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 274)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gloebits Money Module Lets You Sell Stuff"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mode:"
        '
        'GloebitsWebsiteButton
        '
        Me.GloebitsWebsiteButton.Location = New System.Drawing.Point(9, 31)
        Me.GloebitsWebsiteButton.Name = "GloebitsWebsiteButton"
        Me.GloebitsWebsiteButton.Size = New System.Drawing.Size(233, 34)
        Me.GloebitsWebsiteButton.TabIndex = 7
        Me.GloebitsWebsiteButton.Text = "Free Sign Up For Gloebits"
        Me.GloebitsWebsiteButton.UseVisualStyleBackColor = True
        '
        'OwnerNameTextbox
        '
        Me.OwnerNameTextbox.Location = New System.Drawing.Point(93, 163)
        Me.OwnerNameTextbox.Name = "OwnerNameTextbox"
        Me.OwnerNameTextbox.Size = New System.Drawing.Size(149, 20)
        Me.OwnerNameTextbox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.OwnerNameTextbox, "The name of the person or avatar which manages this OpenSim process")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contact Name"
        '
        'ContactEmailTextBox
        '
        Me.ContactEmailTextBox.Location = New System.Drawing.Point(93, 189)
        Me.ContactEmailTextBox.Name = "ContactEmailTextBox"
        Me.ContactEmailTextBox.Size = New System.Drawing.Size(149, 20)
        Me.ContactEmailTextBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.ContactEmailTextBox, "The email address (or other contact mechanism) for the person who manages this Op" &
        "enSim process.")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contact Email"
        '
        'Gloebits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(284, 298)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Gloebits"
        Me.Text = "Gloebits"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProductionButton As RadioButton
    Friend WithEvents SandboxButton As RadioButton
    Friend WithEvents GloebitsEnabled As CheckBox
    Friend WithEvents OAuthKeyTextBox As TextBox
    Friend WithEvents OAuthSecretTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GloebitsWebsiteButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents OwnerNameTextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ContactEmailTextBox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
