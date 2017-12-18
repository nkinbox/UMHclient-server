<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSalesData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSalesData))
        Me.closebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.chequeno = New System.Windows.Forms.TextBox()
        Me.saleplan = New System.Windows.Forms.TextBox()
        Me.paymentby = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.edit = New System.Windows.Forms.Button()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.saleidl = New System.Windows.Forms.Label()
        Me.chequetype = New System.Windows.Forms.ComboBox()
        Me.errorl = New System.Windows.Forms.Label()
        Me.Saleagentl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'closebtn
        '
        Me.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closebtn.Location = New System.Drawing.Point(454, 3)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(21, 23)
        Me.closebtn.TabIndex = 10
        Me.closebtn.Text = "X"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "SaleID -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(276, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Status -"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Amount -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ChequeNo -"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ChequeType -"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(257, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "SalePlan -"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(247, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "SaleAgent -"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(260, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Payment -"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(262, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "TakenBy"
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(119, 144)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(100, 20)
        Me.amount.TabIndex = 1
        '
        'chequeno
        '
        Me.chequeno.Location = New System.Drawing.Point(119, 184)
        Me.chequeno.Name = "chequeno"
        Me.chequeno.Size = New System.Drawing.Size(100, 20)
        Me.chequeno.TabIndex = 2
        '
        'saleplan
        '
        Me.saleplan.Location = New System.Drawing.Point(342, 144)
        Me.saleplan.Name = "saleplan"
        Me.saleplan.Size = New System.Drawing.Size(100, 20)
        Me.saleplan.TabIndex = 5
        '
        'paymentby
        '
        Me.paymentby.Location = New System.Drawing.Point(343, 227)
        Me.paymentby.Name = "paymentby"
        Me.paymentby.Size = New System.Drawing.Size(100, 20)
        Me.paymentby.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(5)
        Me.Label11.Size = New System.Drawing.Size(124, 34)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Sales Data"
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(368, 310)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 36)
        Me.edit.TabIndex = 9
        Me.edit.Text = "Edit Data"
        Me.edit.UseVisualStyleBackColor = True
        '
        'status
        '
        Me.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"Pending", "Rejected", "Success"})
        Me.status.Location = New System.Drawing.Point(342, 69)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(101, 21)
        Me.status.TabIndex = 4
        '
        'saleidl
        '
        Me.saleidl.AutoSize = True
        Me.saleidl.Location = New System.Drawing.Point(116, 73)
        Me.saleidl.Name = "saleidl"
        Me.saleidl.Size = New System.Drawing.Size(13, 13)
        Me.saleidl.TabIndex = 35
        Me.saleidl.Text = "0"
        '
        'chequetype
        '
        Me.chequetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.chequetype.FormattingEnabled = True
        Me.chequetype.Items.AddRange(New Object() {"Phy. Chk", "V Chk", "Gateway"})
        Me.chequetype.Location = New System.Drawing.Point(119, 226)
        Me.chequetype.Name = "chequetype"
        Me.chequetype.Size = New System.Drawing.Size(101, 21)
        Me.chequetype.TabIndex = 3
        '
        'errorl
        '
        Me.errorl.AutoSize = True
        Me.errorl.ForeColor = System.Drawing.Color.Red
        Me.errorl.Location = New System.Drawing.Point(205, 322)
        Me.errorl.Name = "errorl"
        Me.errorl.Size = New System.Drawing.Size(0, 13)
        Me.errorl.TabIndex = 37
        '
        'Saleagentl
        '
        Me.Saleagentl.AutoSize = True
        Me.Saleagentl.Location = New System.Drawing.Point(342, 190)
        Me.Saleagentl.Name = "Saleagentl"
        Me.Saleagentl.Size = New System.Drawing.Size(39, 13)
        Me.Saleagentl.TabIndex = 38
        Me.Saleagentl.Text = "Label7"
        '
        'EditSalesData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(478, 358)
        Me.Controls.Add(Me.Saleagentl)
        Me.Controls.Add(Me.errorl)
        Me.Controls.Add(Me.chequetype)
        Me.Controls.Add(Me.saleidl)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.paymentby)
        Me.Controls.Add(Me.saleplan)
        Me.Controls.Add(Me.chequeno)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closebtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditSalesData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Sales Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents amount As System.Windows.Forms.TextBox
    Friend WithEvents chequeno As System.Windows.Forms.TextBox
    Friend WithEvents saleplan As System.Windows.Forms.TextBox
    Friend WithEvents paymentby As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents status As System.Windows.Forms.ComboBox
    Friend WithEvents saleidl As System.Windows.Forms.Label
    Friend WithEvents chequetype As System.Windows.Forms.ComboBox
    Friend WithEvents errorl As System.Windows.Forms.Label
    Friend WithEvents Saleagentl As System.Windows.Forms.Label
End Class
