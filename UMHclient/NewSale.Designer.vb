<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewSale))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.chequeno = New System.Windows.Forms.TextBox()
        Me.plan = New System.Windows.Forms.TextBox()
        Me.paymentby = New System.Windows.Forms.TextBox()
        Me.comment = New System.Windows.Forms.TextBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.customerIDl = New System.Windows.Forms.Label()
        Me.chequetype = New System.Windows.Forms.ComboBox()
        Me.errorl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(5)
        Me.Label11.Size = New System.Drawing.Size(171, 34)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "New Sales Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Amount -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "ChequeNo -"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "ChequeType -"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "SalePlan -"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 18)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Payment -"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(39, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "TakenBy"
        '
        'closebtn
        '
        Me.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closebtn.Location = New System.Drawing.Point(518, 4)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(21, 23)
        Me.closebtn.TabIndex = 8
        Me.closebtn.Text = "X"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(124, 70)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(100, 20)
        Me.amount.TabIndex = 1
        '
        'chequeno
        '
        Me.chequeno.Location = New System.Drawing.Point(124, 98)
        Me.chequeno.Name = "chequeno"
        Me.chequeno.Size = New System.Drawing.Size(100, 20)
        Me.chequeno.TabIndex = 2
        '
        'plan
        '
        Me.plan.Location = New System.Drawing.Point(124, 195)
        Me.plan.Name = "plan"
        Me.plan.Size = New System.Drawing.Size(100, 20)
        Me.plan.TabIndex = 4
        '
        'paymentby
        '
        Me.paymentby.Location = New System.Drawing.Point(124, 234)
        Me.paymentby.Name = "paymentby"
        Me.paymentby.Size = New System.Drawing.Size(100, 20)
        Me.paymentby.TabIndex = 5
        '
        'comment
        '
        Me.comment.Location = New System.Drawing.Point(252, 90)
        Me.comment.Multiline = True
        Me.comment.Name = "comment"
        Me.comment.Size = New System.Drawing.Size(275, 179)
        Me.comment.TabIndex = 6
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.Location = New System.Drawing.Point(452, 285)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 36)
        Me.Add.TabIndex = 7
        Me.Add.Text = "Add Sale"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Sales Notes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "CustomerID -"
        '
        'customerIDl
        '
        Me.customerIDl.AutoSize = True
        Me.customerIDl.Location = New System.Drawing.Point(287, 21)
        Me.customerIDl.Name = "customerIDl"
        Me.customerIDl.Size = New System.Drawing.Size(14, 13)
        Me.customerIDl.TabIndex = 52
        Me.customerIDl.Text = "#"
        '
        'chequetype
        '
        Me.chequetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.chequetype.FormattingEnabled = True
        Me.chequetype.Items.AddRange(New Object() {"Phy. Chk", "V Chk", "Gateway"})
        Me.chequetype.Location = New System.Drawing.Point(124, 123)
        Me.chequetype.Name = "chequetype"
        Me.chequetype.Size = New System.Drawing.Size(100, 21)
        Me.chequetype.TabIndex = 3
        '
        'errorl
        '
        Me.errorl.AutoSize = True
        Me.errorl.ForeColor = System.Drawing.Color.Red
        Me.errorl.Location = New System.Drawing.Point(252, 285)
        Me.errorl.Name = "errorl"
        Me.errorl.Size = New System.Drawing.Size(0, 13)
        Me.errorl.TabIndex = 54
        '
        'NewSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(542, 333)
        Me.Controls.Add(Me.errorl)
        Me.Controls.Add(Me.chequetype)
        Me.Controls.Add(Me.customerIDl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.comment)
        Me.Controls.Add(Me.paymentby)
        Me.Controls.Add(Me.plan)
        Me.Controls.Add(Me.chequeno)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Sale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents amount As System.Windows.Forms.TextBox
    Friend WithEvents chequeno As System.Windows.Forms.TextBox
    Friend WithEvents plan As System.Windows.Forms.TextBox
    Friend WithEvents paymentby As System.Windows.Forms.TextBox
    Friend WithEvents comment As System.Windows.Forms.TextBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents customerIDl As System.Windows.Forms.Label
    Friend WithEvents chequetype As System.Windows.Forms.ComboBox
    Friend WithEvents errorl As System.Windows.Forms.Label
End Class
