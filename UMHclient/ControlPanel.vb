Public Class ControlPanel
    Public Property SessionID As String
    Public Property employeeID As String
    Public Property handler As String
    Private cpCustomerID As String = "0"
    Private cpsaleID As String = "0"
    Public loginpanel As LoginForm
    Public Sub openpanel(loginf As LoginForm)
        loginpanel = loginf
        loginpanel.Hide()
    End Sub
    Private Sub ControlPanel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        loginpanel.Close()
    End Sub
    Private Sub AddCustomer_Click(sender As Object, e As EventArgs) Handles AddCustomer.Click
        OpenCustomerDetailPanel("Add")
    End Sub
    Private Sub EditCustomer_Click(sender As Object, e As EventArgs) Handles EditCustomer.Click
        OpenCustomerDetailPanel("Edit")
    End Sub

    Private Sub OpenCustomerDetailPanel(Mode As String)
        Dim OBJ As New CustomerDetails
        Select Case Mode
            Case "Add"
                OBJ.Mode = "Add"
                OBJ.CustomerID = "0"
                OBJ.employeeID = employeeID
                OBJ.sessionID = SessionID
            Case "Edit"
                If cpCustomerID = "0" Then
                    MsgBox("No Customer Selected!")
                    Return
                End If
                OBJ.Mode = "Edit"
                OBJ.CustomerID = cpCustomerID
                OBJ.employeeID = employeeID
                OBJ.sessionID = SessionID
        End Select
        OBJ.ShowDialog()
        cpCustomerID = OBJ.CustomerID
        searchCustomer(cpCustomerID)
    End Sub

    Private Sub OpenEditSaleData_Click(sender As Object, e As EventArgs) Handles OpenEditSaleData.Click
        If cpsaleID = "0" Then
            MsgBox("No SaleID selected.")
            Return
        End If
        Dim OBJ As New EditSalesData
        OBJ.saledata = {cpsaleID, SalesDataHolder.SelectedRows(0).Cells(2).Value.ToString, SalesDataHolder.SelectedRows(0).Cells(3).Value.ToString, SalesDataHolder.SelectedRows(0).Cells(4).Value.ToString, SalesDataHolder.SelectedRows(0).Cells(1).Value.ToString, SalesDataHolder.SelectedRows(0).Cells(5).Value.ToString, SalesDataHolder.SelectedRows(0).Cells(7).Value.ToString, SalesDataHolder.SelectedRows(0).Cells(8).Value.ToString}
        OBJ.employeeID = employeeID
        OBJ.sessionID = SessionID
        OBJ.ShowDialog()
        If OBJ.done Then
            searchCustomer(cpCustomerID)
        End If
    End Sub

    Private Sub openAddNotes_Click(sender As Object, e As EventArgs) Handles openAddNotes.Click
        If cpsaleID = "0" Then
            MsgBox("No SaleID selected")
            Return
        End If
        Dim OBJ As New AddNotes
        OBJ.saleID = cpsaleID
        OBJ.employeeID = employeeID
        OBJ.sessionID = SessionID
        OBJ.ShowDialog()
        If OBJ.done Then
            getComments(cpsaleID)
        End If
    End Sub

    Private Sub openNewSale_Click(sender As Object, e As EventArgs) Handles openNewSale.Click
        If cpCustomerID = "0" Then
            MsgBox("No Customer Selected!")
            Return
        End If
        Dim OBJ As New NewSale
        OBJ.CustomerID = cpCustomerID
        OBJ.sessionID = SessionID
        OBJ.employeeID = employeeID
        OBJ.ShowDialog()
        If OBJ.added Then
            searchCustomer(cpCustomerID)
        End If
    End Sub
    Private Sub privilage(h As String)
        Select Case h
            Case "s"
                EditCustomer.Enabled = False
                TabControl1.TabPages(2).Enabled = False
                OpenEditSaleData.Enabled = False
            Case "t"
                EditCustomer.Enabled = False
                AddCustomer.Enabled = False
                openNewSale.Enabled = False
                TabControl1.TabPages(2).Enabled = False
                OpenEditSaleData.Enabled = False
            Case "a"
                monthlist2.SelectedItem = monthDropList.Items(DateTime.Now.Month - 1)
                YearTB.Text = DateTime.Now.Year
                empID.Text = "0"
                APemployeeData()
        End Select
    End Sub
    Private Sub ControlPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        privilage(handler)
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        monthDropList.SelectedItem = monthDropList.Items(DateTime.Now.Month - 1)
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("employeeData|" & employeeID & "|" & SessionID & "|" & DateTime.Now.Month)
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                Else
                    EmployeeData.DocumentText = d
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub

    Private Sub EmployeeDataGrab_Click(sender As Object, e As EventArgs) Handles EmployeeDataGrab.Click
        Dim i As Integer = monthDropList.SelectedIndex + 1
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("employeeData|" & employeeID & "|" & SessionID & "|" & i)
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                Else
                    EmployeeData.DocumentText = d
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub
    Private Sub searchCustomer(q As String)
        CommentContainer.DocumentText = ""
        cpsaleID = "0"
        If q = "0" Then
            Return
        End If
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("Search|" & employeeID & "|" & SessionID & "|html|" & q)
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                Else
                    Dim str As String() = d.Split("|")
                    cpCustomerID = str(0)
                    SearchBox.Text = cpCustomerID
                    CustomerData.DocumentText = str(1)
                    If str(0) <> "0" Then
                        getSalesData()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        searchCustomer(SearchBox.Text)
    End Sub

    Private Sub SearchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchCustomer(SearchBox.Text)
        End If
    End Sub
    Private Sub getSalesData()
        SalesDataHolder.Rows.Clear()
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("SaleData|" & cpCustomerID)
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                ElseIf d = "NoResult" Then
                    Return
                Else
                    Dim str As String() = d.Split(";")
                    Dim cols As String()
                    For Each row As String In str
                        cols = row.Split("|")
                        SalesDataHolder.Rows.Add(cols(0), cols(5), cols(2), cols(3), cols(4), cols(6), cols(7), cols(8), cols(9))
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub
    Private Sub SalesDataHolder_MouseClick(sender As Object, e As MouseEventArgs) Handles SalesDataHolder.MouseClick
        If SalesDataHolder.SelectedRows.Count > 0 Then
            cpsaleID = SalesDataHolder.SelectedRows(0).Cells(0).Value.ToString
            getComments(cpsaleID)
        Else
            cpsaleID = "0"
        End If
    End Sub
    Private Sub getComments(saleID As String)
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("SaleComment|" & saleID)
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                ElseIf d = "NoResult" Then
                    CommentContainer.DocumentText = "No Comments Attached!"
                Else
                    CommentContainer.DocumentText = d
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Not Responding.")
        End Try
    End Sub

    Private Sub Logoutbt_Click(sender As Object, e As EventArgs) Handles Logoutbt.Click
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("logout|" & SessionID)
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                Else
                    MsgBox("Logout Successful!")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub
    Private Sub APemployeeData()
        APemployeeDataHolder.Rows.Clear()
        APEmployeeHistoryHolder.Rows.Clear()
        APSaleDetails.DocumentText = ""
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("APemployeeData|" & employeeID & "|" & SessionID & "|" & empID.Text)
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                ElseIf d = "NoResult" Then
                    MsgBox("No Result found!")
                Else
                    Dim rows As String() = d.Split("|")
                    Dim col As String()
                    Dim c As Integer = 0
                    For Each row As String In rows
                        c = c + 1
                        col = row.Split(",")
                        APemployeeDataHolder.Rows.Add(c, col(0), col(1), col(2), col(3), col(4))
                    Next
                    APsalesOverview("All")
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub
    Private Sub APemployeeSaleData()
        APEmployeeHistoryHolder.Rows.Clear()
        APSaleDetails.DocumentText = ""
        Dim i As Integer = monthlist2.SelectedIndex + 1
        If YearTB.Text.Length = 4 And IsNumeric(YearTB.Text) Then
        Else
            YearTB.Text = DateTime.Now.Year
        End If
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("APemployeeSaleData|" & employeeID & "|" & SessionID & "|" & APemployeeDataHolder.SelectedRows(0).Cells(1).Value.ToString & "|" & i & "|" & YearTB.Text)
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                ElseIf d = "NoResult" Then
                    MsgBox("No Result found!")
                Else
                    Dim rows As String() = d.Split(",")
                    Dim cols As String()
                    Dim a As Integer = 0
                    For Each row As String In rows
                        a = a + 1
                        cols = row.Split(";")
                        APEmployeeHistoryHolder.Rows.Add(a, cols(0), cols(1), cols(2), cols(3), cols(4), cols(5), cols(6), cols(7))
                    Next
                    APsalesOverview("monthly")
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub
    Private Sub APEmpData_Click(sender As Object, e As EventArgs) Handles APEmpData.Click
        APemployeeData()
    End Sub
    Private Sub APemployeeDataHolder_MouseClick(sender As Object, e As MouseEventArgs) Handles APemployeeDataHolder.MouseClick
        If APemployeeDataHolder.SelectedRows.Count > 0 Then
            APemployeeSaleData()
        End If
    End Sub
    Private Sub APEmployeeHistoryHolder_MouseClick(sender As Object, e As MouseEventArgs) Handles APEmployeeHistoryHolder.MouseClick
        If APEmployeeHistoryHolder.SelectedRows.Count > 0 Then
            If APemployeeDataHolder.SelectedRows.Count > 0 Then
                APsalesOverview("session")
            End If
        End If
    End Sub
    Private Sub APsalesOverview(m As String)
        Dim i As Integer = monthlist2.SelectedIndex + 1
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                If m = "monthly" Then
                    clientOBJ.send("APmOverview|" & employeeID & "|" & SessionID & "|" & APemployeeDataHolder.SelectedRows(0).Cells(1).Value.ToString & "|" & i & "|" & YearTB.Text)
                ElseIf m = "session" Then
                    clientOBJ.send("APsOverview|" & employeeID & "|" & SessionID & "|" & APemployeeDataHolder.SelectedRows(0).Cells(1).Value.ToString & "|" & APEmployeeHistoryHolder.SelectedRows(0).Cells(1).Value.ToString & "|" & APEmployeeHistoryHolder.SelectedRows(0).Cells(2).Value.ToString)
                Else
                    clientOBJ.send("APOverview|" & employeeID & "|" & SessionID & "|" & i & "|" & YearTB.Text)
                End If
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                Else
                    APSaleDetails.DocumentText = d
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub

    Private Sub AddEmployee_Click(sender As Object, e As EventArgs) Handles AddEmployee.Click
        Dim obj As New newEmployee
        obj.ShowDialog()
        If obj.done Then
            APemployeeData()
        End If
    End Sub

    Private Sub DeleteEmployee_Click(sender As Object, e As EventArgs) Handles DeleteEmployee.Click
        If APemployeeDataHolder.SelectedRows.Count > 0 Then
        Else
            MsgBox("No Employee Selected!")
            Return
        End If
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("DeleteEmployee|" & APemployeeDataHolder.SelectedRows(0).Cells(1).Value.ToString)
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                Else
                    APemployeeData()
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub
End Class