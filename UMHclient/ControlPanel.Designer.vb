<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPanel))
        Me.SalesDataHolder = New System.Windows.Forms.DataGridView()
        Me.SaleID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalePlan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleAgent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentTakenBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentContainer = New System.Windows.Forms.WebBrowser()
        Me.OpenEditSaleData = New System.Windows.Forms.Button()
        Me.openAddNotes = New System.Windows.Forms.Button()
        Me.CustomerData = New System.Windows.Forms.WebBrowser()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.EditCustomer = New System.Windows.Forms.Button()
        Me.openNewSale = New System.Windows.Forms.Button()
        Me.monthDropList = New System.Windows.Forms.ComboBox()
        Me.EmployeeDataGrab = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AddCustomer = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Logoutbt = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeData = New System.Windows.Forms.WebBrowser()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.APSaleDetails = New System.Windows.Forms.WebBrowser()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.APEmployeeHistoryHolder = New System.Windows.Forms.DataGridView()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.AddEmployee = New System.Windows.Forms.Button()
        Me.DeleteEmployee = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.APEmpData = New System.Windows.Forms.Button()
        Me.YearTB = New System.Windows.Forms.TextBox()
        Me.monthlist2 = New System.Windows.Forms.ComboBox()
        Me.empID = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.APemployeeDataHolder = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SalesDataHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.APEmployeeHistoryHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.APemployeeDataHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesDataHolder
        '
        Me.SalesDataHolder.AllowUserToAddRows = False
        Me.SalesDataHolder.AllowUserToDeleteRows = False
        Me.SalesDataHolder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SalesDataHolder.BackgroundColor = System.Drawing.SystemColors.Control
        Me.SalesDataHolder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesDataHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDataHolder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaleID, Me.Status, Me.Amount, Me.ChequeNo, Me.ChequeType, Me.SalePlan, Me.SaleDate, Me.SaleAgent, Me.PaymentTakenBy})
        Me.SalesDataHolder.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SalesDataHolder.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.SalesDataHolder.Location = New System.Drawing.Point(3, 320)
        Me.SalesDataHolder.MultiSelect = False
        Me.SalesDataHolder.Name = "SalesDataHolder"
        Me.SalesDataHolder.ReadOnly = True
        Me.SalesDataHolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SalesDataHolder.Size = New System.Drawing.Size(884, 213)
        Me.SalesDataHolder.TabIndex = 15
        '
        'SaleID
        '
        Me.SaleID.HeaderText = "SaleID"
        Me.SaleID.Name = "SaleID"
        Me.SaleID.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'ChequeNo
        '
        Me.ChequeNo.HeaderText = "ChequeNo"
        Me.ChequeNo.Name = "ChequeNo"
        Me.ChequeNo.ReadOnly = True
        '
        'ChequeType
        '
        Me.ChequeType.HeaderText = "ChequeType"
        Me.ChequeType.Name = "ChequeType"
        Me.ChequeType.ReadOnly = True
        '
        'SalePlan
        '
        Me.SalePlan.HeaderText = "SalePlan"
        Me.SalePlan.Name = "SalePlan"
        Me.SalePlan.ReadOnly = True
        '
        'SaleDate
        '
        Me.SaleDate.HeaderText = "SaleDate"
        Me.SaleDate.Name = "SaleDate"
        Me.SaleDate.ReadOnly = True
        '
        'SaleAgent
        '
        Me.SaleAgent.HeaderText = "SaleAgent"
        Me.SaleAgent.Name = "SaleAgent"
        Me.SaleAgent.ReadOnly = True
        '
        'PaymentTakenBy
        '
        Me.PaymentTakenBy.HeaderText = "PaymentTakenBy"
        Me.PaymentTakenBy.Name = "PaymentTakenBy"
        Me.PaymentTakenBy.ReadOnly = True
        '
        'CommentContainer
        '
        Me.CommentContainer.IsWebBrowserContextMenuEnabled = False
        Me.CommentContainer.Location = New System.Drawing.Point(548, 33)
        Me.CommentContainer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CommentContainer.Name = "CommentContainer"
        Me.CommentContainer.Size = New System.Drawing.Size(328, 267)
        Me.CommentContainer.TabIndex = 17
        '
        'OpenEditSaleData
        '
        Me.OpenEditSaleData.Location = New System.Drawing.Point(394, 273)
        Me.OpenEditSaleData.Name = "OpenEditSaleData"
        Me.OpenEditSaleData.Size = New System.Drawing.Size(108, 29)
        Me.OpenEditSaleData.TabIndex = 7
        Me.OpenEditSaleData.Text = "Edit SaleData"
        Me.OpenEditSaleData.UseVisualStyleBackColor = True
        '
        'openAddNotes
        '
        Me.openAddNotes.Location = New System.Drawing.Point(394, 238)
        Me.openAddNotes.Name = "openAddNotes"
        Me.openAddNotes.Size = New System.Drawing.Size(108, 29)
        Me.openAddNotes.TabIndex = 8
        Me.openAddNotes.Text = "Add Notes"
        Me.openAddNotes.UseVisualStyleBackColor = True
        '
        'CustomerData
        '
        Me.CustomerData.IsWebBrowserContextMenuEnabled = False
        Me.CustomerData.Location = New System.Drawing.Point(8, 19)
        Me.CustomerData.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CustomerData.Name = "CustomerData"
        Me.CustomerData.ScrollBarsEnabled = False
        Me.CustomerData.Size = New System.Drawing.Size(327, 179)
        Me.CustomerData.TabIndex = 14
        '
        'SearchBox
        '
        Me.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(6, 15)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(251, 26)
        Me.SearchBox.TabIndex = 1
        Me.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SearchBtn
        '
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SearchBtn.Location = New System.Drawing.Point(265, 13)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(72, 30)
        Me.SearchBtn.TabIndex = 2
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'EditCustomer
        '
        Me.EditCustomer.ForeColor = System.Drawing.SystemColors.InfoText
        Me.EditCustomer.Location = New System.Drawing.Point(6, 205)
        Me.EditCustomer.Name = "EditCustomer"
        Me.EditCustomer.Size = New System.Drawing.Size(129, 26)
        Me.EditCustomer.TabIndex = 3
        Me.EditCustomer.Text = "Edit Customer Details"
        Me.EditCustomer.UseVisualStyleBackColor = True
        '
        'openNewSale
        '
        Me.openNewSale.ForeColor = System.Drawing.SystemColors.InfoText
        Me.openNewSale.Location = New System.Drawing.Point(208, 205)
        Me.openNewSale.Name = "openNewSale"
        Me.openNewSale.Size = New System.Drawing.Size(129, 26)
        Me.openNewSale.TabIndex = 4
        Me.openNewSale.Text = "Add New Sale"
        Me.openNewSale.UseVisualStyleBackColor = True
        '
        'monthDropList
        '
        Me.monthDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.monthDropList.FormattingEnabled = True
        Me.monthDropList.Items.AddRange(New Object() {"January", "Feburary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.monthDropList.Location = New System.Drawing.Point(286, 9)
        Me.monthDropList.Name = "monthDropList"
        Me.monthDropList.Size = New System.Drawing.Size(97, 21)
        Me.monthDropList.TabIndex = 9
        '
        'EmployeeDataGrab
        '
        Me.EmployeeDataGrab.Location = New System.Drawing.Point(389, 8)
        Me.EmployeeDataGrab.Name = "EmployeeDataGrab"
        Me.EmployeeDataGrab.Size = New System.Drawing.Size(30, 23)
        Me.EmployeeDataGrab.TabIndex = 10
        Me.EmployeeDataGrab.Text = "Go"
        Me.EmployeeDataGrab.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchBox)
        Me.GroupBox1.Controls.Add(Me.SearchBtn)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Location = New System.Drawing.Point(8, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 50)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Customer"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CustomerData)
        Me.GroupBox2.Controls.Add(Me.EditCustomer)
        Me.GroupBox2.Controls.Add(Me.openNewSale)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Location = New System.Drawing.Point(8, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 237)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Details"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(898, 562)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.openAddNotes)
        Me.TabPage1.Controls.Add(Me.AddCustomer)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.OpenEditSaleData)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.CommentContainer)
        Me.TabPage1.Controls.Add(Me.SalesDataHolder)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(890, 536)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customers"
        '
        'AddCustomer
        '
        Me.AddCustomer.Location = New System.Drawing.Point(394, 34)
        Me.AddCustomer.Name = "AddCustomer"
        Me.AddCustomer.Size = New System.Drawing.Size(108, 30)
        Me.AddCustomer.TabIndex = 5
        Me.AddCustomer.Text = "Add New Customer"
        Me.AddCustomer.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox3.Location = New System.Drawing.Point(542, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 300)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sales Notes"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.monthDropList)
        Me.TabPage2.Controls.Add(Me.EmployeeDataGrab)
        Me.TabPage2.Controls.Add(Me.Logoutbt)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.EmployeeData)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(890, 536)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "My Account"
        '
        'Logoutbt
        '
        Me.Logoutbt.Location = New System.Drawing.Point(807, 8)
        Me.Logoutbt.Name = "Logoutbt"
        Me.Logoutbt.Size = New System.Drawing.Size(75, 23)
        Me.Logoutbt.TabIndex = 19
        Me.Logoutbt.Text = "Logout"
        Me.Logoutbt.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 35)
        Me.Panel1.TabIndex = 20
        '
        'EmployeeData
        '
        Me.EmployeeData.IsWebBrowserContextMenuEnabled = False
        Me.EmployeeData.Location = New System.Drawing.Point(23, 52)
        Me.EmployeeData.MinimumSize = New System.Drawing.Size(20, 20)
        Me.EmployeeData.Name = "EmployeeData"
        Me.EmployeeData.ScrollBarsEnabled = False
        Me.EmployeeData.Size = New System.Drawing.Size(526, 337)
        Me.EmployeeData.TabIndex = 18
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.GroupBox7)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(890, 536)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Admin Panel"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.APSaleDetails)
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox7.Location = New System.Drawing.Point(532, 9)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(350, 287)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Details"
        '
        'APSaleDetails
        '
        Me.APSaleDetails.IsWebBrowserContextMenuEnabled = False
        Me.APSaleDetails.Location = New System.Drawing.Point(7, 16)
        Me.APSaleDetails.MinimumSize = New System.Drawing.Size(20, 20)
        Me.APSaleDetails.Name = "APSaleDetails"
        Me.APSaleDetails.Size = New System.Drawing.Size(337, 265)
        Me.APSaleDetails.TabIndex = 8
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.APEmployeeHistoryHolder)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox6.Location = New System.Drawing.Point(8, 302)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(874, 231)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Overview"
        '
        'APEmployeeHistoryHolder
        '
        Me.APEmployeeHistoryHolder.AllowUserToAddRows = False
        Me.APEmployeeHistoryHolder.AllowUserToDeleteRows = False
        Me.APEmployeeHistoryHolder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.APEmployeeHistoryHolder.BackgroundColor = System.Drawing.SystemColors.Control
        Me.APEmployeeHistoryHolder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.APEmployeeHistoryHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APEmployeeHistoryHolder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column15, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13})
        Me.APEmployeeHistoryHolder.Location = New System.Drawing.Point(9, 19)
        Me.APEmployeeHistoryHolder.MultiSelect = False
        Me.APEmployeeHistoryHolder.Name = "APEmployeeHistoryHolder"
        Me.APEmployeeHistoryHolder.ReadOnly = True
        Me.APEmployeeHistoryHolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.APEmployeeHistoryHolder.Size = New System.Drawing.Size(859, 206)
        Me.APEmployeeHistoryHolder.TabIndex = 9
        '
        'Column15
        '
        Me.Column15.HeaderText = "Sno"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Login"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Logout"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Hours"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Total Sales"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Successful"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Rejected"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Pending"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "Customers"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.AddEmployee)
        Me.GroupBox5.Controls.Add(Me.DeleteEmployee)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.APEmpData)
        Me.GroupBox5.Controls.Add(Me.YearTB)
        Me.GroupBox5.Controls.Add(Me.monthlist2)
        Me.GroupBox5.Controls.Add(Me.empID)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox5.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(517, 44)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data Parameters"
        '
        'AddEmployee
        '
        Me.AddEmployee.Location = New System.Drawing.Point(459, 12)
        Me.AddEmployee.Name = "AddEmployee"
        Me.AddEmployee.Size = New System.Drawing.Size(52, 23)
        Me.AddEmployee.TabIndex = 6
        Me.AddEmployee.Text = "Add"
        Me.AddEmployee.UseVisualStyleBackColor = True
        '
        'DeleteEmployee
        '
        Me.DeleteEmployee.Location = New System.Drawing.Point(401, 12)
        Me.DeleteEmployee.Name = "DeleteEmployee"
        Me.DeleteEmployee.Size = New System.Drawing.Size(52, 23)
        Me.DeleteEmployee.TabIndex = 5
        Me.DeleteEmployee.Text = "Delete"
        Me.DeleteEmployee.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "#"
        '
        'APEmpData
        '
        Me.APEmpData.Location = New System.Drawing.Point(266, 13)
        Me.APEmpData.Name = "APEmpData"
        Me.APEmpData.Size = New System.Drawing.Size(37, 23)
        Me.APEmpData.TabIndex = 4
        Me.APEmpData.Text = "Go"
        Me.APEmpData.UseVisualStyleBackColor = True
        '
        'YearTB
        '
        Me.YearTB.Location = New System.Drawing.Point(193, 15)
        Me.YearTB.Name = "YearTB"
        Me.YearTB.Size = New System.Drawing.Size(54, 20)
        Me.YearTB.TabIndex = 3
        Me.YearTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'monthlist2
        '
        Me.monthlist2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.monthlist2.FormattingEnabled = True
        Me.monthlist2.Items.AddRange(New Object() {"January", "Feburary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.monthlist2.Location = New System.Drawing.Point(112, 14)
        Me.monthlist2.Name = "monthlist2"
        Me.monthlist2.Size = New System.Drawing.Size(75, 21)
        Me.monthlist2.TabIndex = 2
        '
        'empID
        '
        Me.empID.Location = New System.Drawing.Point(21, 17)
        Me.empID.Name = "empID"
        Me.empID.Size = New System.Drawing.Size(49, 20)
        Me.empID.TabIndex = 1
        Me.empID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.APemployeeDataHolder)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox4.Location = New System.Drawing.Point(8, 65)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(517, 231)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Employees List"
        '
        'APemployeeDataHolder
        '
        Me.APemployeeDataHolder.AllowUserToAddRows = False
        Me.APemployeeDataHolder.AllowUserToDeleteRows = False
        Me.APemployeeDataHolder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.APemployeeDataHolder.BackgroundColor = System.Drawing.SystemColors.Control
        Me.APemployeeDataHolder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.APemployeeDataHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APemployeeDataHolder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column14, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.APemployeeDataHolder.Location = New System.Drawing.Point(6, 19)
        Me.APemployeeDataHolder.MultiSelect = False
        Me.APemployeeDataHolder.Name = "APemployeeDataHolder"
        Me.APemployeeDataHolder.ReadOnly = True
        Me.APemployeeDataHolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.APemployeeDataHolder.Size = New System.Drawing.Size(505, 201)
        Me.APemployeeDataHolder.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Sno"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "#ID"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Email"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Phone"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Handler"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(898, 562)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(914, 600)
        Me.Name = "ControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UMH - Client | Panel"
        CType(Me.SalesDataHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.APEmployeeHistoryHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.APemployeeDataHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SalesDataHolder As System.Windows.Forms.DataGridView
    Friend WithEvents SaleID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalePlan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaleDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaleAgent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentTakenBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentContainer As System.Windows.Forms.WebBrowser
    Friend WithEvents OpenEditSaleData As System.Windows.Forms.Button
    Friend WithEvents openAddNotes As System.Windows.Forms.Button
    Friend WithEvents CustomerData As System.Windows.Forms.WebBrowser
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents EditCustomer As System.Windows.Forms.Button
    Friend WithEvents openNewSale As System.Windows.Forms.Button
    Friend WithEvents monthDropList As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeDataGrab As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents AddCustomer As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents EmployeeData As System.Windows.Forms.WebBrowser
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Logoutbt As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents APEmpData As System.Windows.Forms.Button
    Friend WithEvents YearTB As System.Windows.Forms.TextBox
    Friend WithEvents monthlist2 As System.Windows.Forms.ComboBox
    Friend WithEvents empID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents APemployeeDataHolder As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents APEmployeeHistoryHolder As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents APSaleDetails As System.Windows.Forms.WebBrowser
    Friend WithEvents AddEmployee As System.Windows.Forms.Button
    Friend WithEvents DeleteEmployee As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
