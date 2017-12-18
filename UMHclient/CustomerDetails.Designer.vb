<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerDetails))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CustomerIDl = New System.Windows.Forms.Label()
        Me.employeeIDl = New System.Windows.Forms.Label()
        Me.salutation = New System.Windows.Forms.ComboBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.altphone = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.country = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.aebtn = New System.Windows.Forms.Button()
        Me.errorl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CustomerID -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salutation -"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FirstName -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LastName -"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(245, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EmailID -"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(255, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone -"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(237, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "AltPhone -"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(245, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Country -"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "AddedBy -"
        '
        'CustomerIDl
        '
        Me.CustomerIDl.AutoSize = True
        Me.CustomerIDl.Location = New System.Drawing.Point(109, 62)
        Me.CustomerIDl.Name = "CustomerIDl"
        Me.CustomerIDl.Size = New System.Drawing.Size(62, 13)
        Me.CustomerIDl.TabIndex = 10
        Me.CustomerIDl.Text = "CustomerID"
        '
        'employeeIDl
        '
        Me.employeeIDl.AutoSize = True
        Me.employeeIDl.Location = New System.Drawing.Point(109, 81)
        Me.employeeIDl.Name = "employeeIDl"
        Me.employeeIDl.Size = New System.Drawing.Size(66, 13)
        Me.employeeIDl.TabIndex = 11
        Me.employeeIDl.Text = "Agent Name"
        '
        'salutation
        '
        Me.salutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.salutation.FormattingEnabled = True
        Me.salutation.Items.AddRange(New Object() {"Mr", "Mrs", "Ms"})
        Me.salutation.Location = New System.Drawing.Point(112, 114)
        Me.salutation.Name = "salutation"
        Me.salutation.Size = New System.Drawing.Size(101, 21)
        Me.salutation.TabIndex = 12
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(112, 146)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(100, 20)
        Me.fname.TabIndex = 13
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(112, 174)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(100, 20)
        Me.lname.TabIndex = 14
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(323, 114)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(100, 20)
        Me.email.TabIndex = 15
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(323, 145)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(100, 20)
        Me.phone.TabIndex = 16
        '
        'altphone
        '
        Me.altphone.Location = New System.Drawing.Point(323, 174)
        Me.altphone.Name = "altphone"
        Me.altphone.Size = New System.Drawing.Size(100, 20)
        Me.altphone.TabIndex = 17
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(39, 261)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(173, 85)
        Me.address.TabIndex = 18
        '
        'country
        '
        Me.country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.country.FormattingEnabled = True
        Me.country.Items.AddRange(New Object() {"AU", "CA", "UK", "US"})
        Me.country.Location = New System.Drawing.Point(323, 236)
        Me.country.Name = "country"
        Me.country.Size = New System.Drawing.Size(100, 21)
        Me.country.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1, 1)
        Me.Label13.Margin = New System.Windows.Forms.Padding(8, 8, 3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(5)
        Me.Label13.Size = New System.Drawing.Size(220, 36)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Customer Details"
        '
        'closebtn
        '
        Me.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closebtn.Location = New System.Drawing.Point(414, 9)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(21, 23)
        Me.closebtn.TabIndex = 23
        Me.closebtn.Text = "X"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'aebtn
        '
        Me.aebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aebtn.Location = New System.Drawing.Point(323, 292)
        Me.aebtn.Name = "aebtn"
        Me.aebtn.Size = New System.Drawing.Size(100, 54)
        Me.aebtn.TabIndex = 22
        Me.aebtn.Text = "None"
        Me.aebtn.UseVisualStyleBackColor = True
        '
        'errorl
        '
        Me.errorl.AutoSize = True
        Me.errorl.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.errorl.ForeColor = System.Drawing.Color.Red
        Me.errorl.Location = New System.Drawing.Point(245, 58)
        Me.errorl.Name = "errorl"
        Me.errorl.Size = New System.Drawing.Size(0, 13)
        Me.errorl.TabIndex = 24
        '
        'CustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(444, 370)
        Me.Controls.Add(Me.errorl)
        Me.Controls.Add(Me.aebtn)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.country)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.altphone)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.salutation)
        Me.Controls.Add(Me.employeeIDl)
        Me.Controls.Add(Me.CustomerIDl)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustomerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CustomerIDl As System.Windows.Forms.Label
    Friend WithEvents employeeIDl As System.Windows.Forms.Label
    Friend WithEvents salutation As System.Windows.Forms.ComboBox
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents lname As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents phone As System.Windows.Forms.TextBox
    Friend WithEvents altphone As System.Windows.Forms.TextBox
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents country As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents aebtn As System.Windows.Forms.Button
    Friend WithEvents errorl As System.Windows.Forms.Label
End Class
