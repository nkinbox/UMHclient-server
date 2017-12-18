<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newEmployee))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errorl = New System.Windows.Forms.Label()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.handlerdl = New System.Windows.Forms.ComboBox()
        Me.addBT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.phoneTB = New System.Windows.Forms.TextBox()
        Me.passwordTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name -"
        '
        'errorl
        '
        Me.errorl.AutoSize = True
        Me.errorl.ForeColor = System.Drawing.Color.Red
        Me.errorl.Location = New System.Drawing.Point(54, 216)
        Me.errorl.Name = "errorl"
        Me.errorl.Size = New System.Drawing.Size(0, 13)
        Me.errorl.TabIndex = 1
        '
        'NameTB
        '
        Me.NameTB.Location = New System.Drawing.Point(82, 23)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(100, 20)
        Me.NameTB.TabIndex = 1
        '
        'handlerdl
        '
        Me.handlerdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.handlerdl.FormattingEnabled = True
        Me.handlerdl.Items.AddRange(New Object() {"Sales Agent", "Tech Agent", "Administrator"})
        Me.handlerdl.Location = New System.Drawing.Point(82, 161)
        Me.handlerdl.Name = "handlerdl"
        Me.handlerdl.Size = New System.Drawing.Size(100, 21)
        Me.handlerdl.TabIndex = 5
        '
        'addBT
        '
        Me.addBT.Location = New System.Drawing.Point(147, 255)
        Me.addBT.Name = "addBT"
        Me.addBT.Size = New System.Drawing.Size(75, 23)
        Me.addBT.TabIndex = 6
        Me.addBT.Text = "Add"
        Me.addBT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email -"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Phone -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password -"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "handler -"
        '
        'emailTB
        '
        Me.emailTB.Location = New System.Drawing.Point(82, 61)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(100, 20)
        Me.emailTB.TabIndex = 2
        '
        'phoneTB
        '
        Me.phoneTB.Location = New System.Drawing.Point(82, 94)
        Me.phoneTB.Name = "phoneTB"
        Me.phoneTB.Size = New System.Drawing.Size(100, 20)
        Me.phoneTB.TabIndex = 3
        '
        'passwordTB
        '
        Me.passwordTB.Location = New System.Drawing.Point(82, 123)
        Me.passwordTB.Name = "passwordTB"
        Me.passwordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTB.Size = New System.Drawing.Size(100, 20)
        Me.passwordTB.TabIndex = 4
        '
        'newEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 290)
        Me.Controls.Add(Me.passwordTB)
        Me.Controls.Add(Me.phoneTB)
        Me.Controls.Add(Me.emailTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.addBT)
        Me.Controls.Add(Me.handlerdl)
        Me.Controls.Add(Me.NameTB)
        Me.Controls.Add(Me.errorl)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "newEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents errorl As System.Windows.Forms.Label
    Friend WithEvents NameTB As System.Windows.Forms.TextBox
    Friend WithEvents handlerdl As System.Windows.Forms.ComboBox
    Friend WithEvents addBT As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents emailTB As System.Windows.Forms.TextBox
    Friend WithEvents phoneTB As System.Windows.Forms.TextBox
    Friend WithEvents passwordTB As System.Windows.Forms.TextBox
End Class
