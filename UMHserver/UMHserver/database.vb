Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class database
    Private con As MySqlConnection
    Public r As Boolean
    Private constr As String
    Private sql As String
    Private comm As MySqlCommand
    Private readr As MySqlDataReader
    Public Sub New(ByVal passwd As String)
        constr = "server=localhost;userid=root;password=" & passwd & ";database=umhdb"
        con = New MySqlConnection
        con.ConnectionString = constr
        Try
            con.Open()
            r = True
        Catch ex As Exception
            con.Dispose()
            r = False
        End Try
    End Sub
    Public Function query(ByVal q As String) As String
        q = Replace(q, "'", "")
        q = Replace(q, """", "")
        Dim qid As String() = Split(q, "|")
        Dim result As String = "invalid"
        Select Case qid(0)
            Case "login"
                result = login(q)
            Case "employeeData"
                result = getEmployeeData(q)
            Case "employeeName"
                result = getEmployeeName(q)
            Case "addcustomer"
                result = addNewCustomer(q)
            Case "Search"
                result = searchCustomer(q)
            Case "editcustomer"
                result = editcustomer(q)
            Case "SaleData"
                result = getSaleData(q)
            Case "SaleComment"
                result = getSaleComment(q)
            Case "AddComment"
                result = AddNewComment(q)
            Case "NewSale"
                result = AddNewSale(q)
            Case "EditSale"
                result = EditSaleData(q)
            Case "logout"
                result = logoutUser(q)
            Case "APemployeeData"
                result = APemployeeData(q)
            Case "APemployeeSaleData"
                result = APemployeeSaleData(q)
            Case "APsOverview"
                result = APsOverview(q)
            Case "APmOverview"
                result = APmOverview(q)
            Case "APOverview"
                result = APOverview(q)
            Case "AddEmployee"
                result = AddEmployee(q)
            Case "DeleteEmployee"
                result = DeleteEmployee(q)
        End Select
        con.Close()
        Return result
    End Function
    Private Function AddEmployee(q As String) As String
        Dim str As String() = q.Split("|")
        Try
            sql = "INSERT INTO `umhdb`.`employees` (`employeeID`, `Name`, `Email`, `Phone`, `Password`, `Handler`, `Deleted`) VALUES ('0', '" & str(1) & "', '" & str(2) & "', '" & str(3) & "', '" & str(4) & "', '" & str(5) & "', 'n');"
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            readr.Close()
        Catch ex As Exception
            Return "invalid"
        End Try
        Return "done"
    End Function
    Private Function DeleteEmployee(q As String) As String
        Dim str As String() = q.Split("|")
        Try
            sql = "UPDATE `umhdb`.`employees` SET `Deleted`='y' WHERE `employeeID`='" & str(1) & "';"
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            readr.Close()
        Catch ex As Exception
            Return "invalid"
        End Try
        Return "done"
    End Function
    Private Function APOverview(q As String) As String
        Dim res As String = "<html><style>body{font-family:Tahoma, Geneva, sans-serif}b{float:right}span{display:inline-block;width:90px;text-align:center}label{display:inline-block;width:100px;text-align:right;padding-right:8px;color:#777}.r{color:#E40000}.s{color:#00A500}.p{color:#0000A5}.rb{border: 1px solid #E40000}.sb{border: 1px solid #00A500}.pb{border: 1px solid #0000A5}div{padding:3px;margin:5px 2px}</style><body><h4 style='text-align:center'>Monthly Overview</h4>"
        Dim res2 As String = ""
        Dim str As String() = q.Split("|")
        Dim year As String = str(4)
        Select Case str(3)
            Case "1"
                sql = "between '" & year & "-01-01 00:00:00' and '" & year & "-01-31 23:59:59';"
            Case "2"
                sql = "between '" & year & "-02-01 00:00:00' and '" & year & "-02-29 23:59:59';"
            Case "3"
                sql = "between '" & year & "-03-01 00:00:00' and '" & year & "-03-31 23:59:59';"
            Case "4"
                sql = "between '" & year & "-04-01 00:00:00' and '" & year & "-04-30 23:59:59';"
            Case "5"
                sql = "between '" & year & "-05-01 00:00:00' and '" & year & "-05-31 23:59:59';"
            Case "6"
                sql = "between '" & year & "-06-01 00:00:00' and '" & year & "-06-30 23:59:59';"
            Case "7"
                sql = "between '" & year & "-07-01 00:00:00' and '" & year & "-07-31 23:59:59';"
            Case "8"
                sql = "between '" & year & "-08-01 00:00:00' and '" & year & "-08-31 23:59:59';"
            Case "9"
                sql = "between '" & year & "-09-01 00:00:00' and '" & year & "-09-30 23:59:59';"
            Case "10"
                sql = "between '" & year & "-10-01 00:00:00' and '" & year & "-10-31 23:59:59';"
            Case "11"
                sql = "between '" & year & "-11-01 00:00:00' and '" & year & "-11-30 23:59:59';"
            Case "12"
                sql = "between '" & year & "-12-01 00:00:00' and '" & year & "-12-31 23:59:59';"
        End Select
        Try
            Dim con1 As New MySqlConnection
            con1.ConnectionString = constr
            con1.Open()
            Dim n As String() = {"", ""}
            Dim c As Integer() = {0, 0, 0, 0, 0}
            Dim a As Decimal() = {0, 0, 0, 0, 0, 0}
            sql = "select customerID, Amount, Status from umhdb.sales where Date " & sql
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            If readr.HasRows Then
                Dim al As New ArrayList()
                Dim cid As Integer = 0
                Dim status As String = ""
                While readr.Read()
                    cid = readr.GetInt32("customerID")
                    status = readr.GetString("Status")
                    a(5) = readr.GetDecimal("Amount")
                    If Not (al.Contains(cid)) Then
                        al.Add(cid)
                        c(0) = c(0) + 1
                    End If
                    a(0) = a(0) + a(5)
                    c(1) = c(1) + 1
                    Select Case status
                        Case "r"
                            a(2) = a(2) + a(5)
                            c(3) = c(3) + 1
                        Case "p"
                            a(1) = a(1) + a(5)
                            c(2) = c(2) + 1
                        Case "s"
                            a(3) = a(3) + a(5)
                            c(4) = c(4) + 1
                    End Select
                    sql = "select fName, lName from umhdb.customers where customerID = '" & cid & "' limit 1;"
                    Dim comm1 As New MySqlCommand(sql, con1)
                    Dim readr1 As MySqlDataReader
                    readr1 = comm1.ExecuteReader()
                    readr1.Read()
                    n(0) = readr1.GetString("fName")
                    n(1) = readr1.GetString("lName")
                    readr1.Close()
                    res2 = res2 & "<div class='" & status & " " & status & "b'><b>" & a(5) & "$</b>#" & cid & " " & n(0) & " " & n(1) & "</div>"
                End While
                res = res & "<label>Customers :</label><span>" & c(0) & "</span><br><label>T Sales :</label><span>" & c(1) & "</span> | <span>" & a(0) & "$</span><br><label>Pending :</label><span>" & c(2) & "</span> | <span>" & a(1) & "$</span><br><label>Rejected :</label><span>" & c(3) & "</span> | <span>" & a(2) & "$</span><br><br><label>Success :</label><span>" & c(4) & "</span> | <span>" & a(3) & "$</span><br><br><br>"
            Else
                readr.Close()
                con1.Close()
                Return "No Data Found."
            End If
            readr.Close()
            con1.Close()
        Catch ex As Exception
            Return "invalid"
        End Try
        res = res & res2 & "</body></html>"
        Return res
    End Function
    Private Function APmOverview(q As String) As String
        Dim res As String = "<html><style>body{font-family:Tahoma, Geneva, sans-serif}b{float:right}span{display:inline-block;width:90px;text-align:center}label{display:inline-block;width:100px;text-align:right;padding-right:8px;color:#777}.r{color:#E40000}.s{color:#00A500}.p{color:#0000A5}.rb{border: 1px solid #E40000}.sb{border: 1px solid #00A500}.pb{border: 1px solid #0000A5}div{padding:3px;margin:5px 2px}</style><body><h4 style='text-align:center'>Monthly Overview</h4>"
        Dim res2 As String = ""
        Dim str As String() = q.Split("|")
        Dim year As String = str(5)
        Select Case str(4)
            Case "1"
                sql = "between '" & year & "-01-01 00:00:00' and '" & year & "-01-31 23:59:59';"
            Case "2"
                sql = "between '" & year & "-02-01 00:00:00' and '" & year & "-02-29 23:59:59';"
            Case "3"
                sql = "between '" & year & "-03-01 00:00:00' and '" & year & "-03-31 23:59:59';"
            Case "4"
                sql = "between '" & year & "-04-01 00:00:00' and '" & year & "-04-30 23:59:59';"
            Case "5"
                sql = "between '" & year & "-05-01 00:00:00' and '" & year & "-05-31 23:59:59';"
            Case "6"
                sql = "between '" & year & "-06-01 00:00:00' and '" & year & "-06-30 23:59:59';"
            Case "7"
                sql = "between '" & year & "-07-01 00:00:00' and '" & year & "-07-31 23:59:59';"
            Case "8"
                sql = "between '" & year & "-08-01 00:00:00' and '" & year & "-08-31 23:59:59';"
            Case "9"
                sql = "between '" & year & "-09-01 00:00:00' and '" & year & "-09-30 23:59:59';"
            Case "10"
                sql = "between '" & year & "-10-01 00:00:00' and '" & year & "-10-31 23:59:59';"
            Case "11"
                sql = "between '" & year & "-11-01 00:00:00' and '" & year & "-11-30 23:59:59';"
            Case "12"
                sql = "between '" & year & "-12-01 00:00:00' and '" & year & "-12-31 23:59:59';"
        End Select
        Try
            Dim con1 As New MySqlConnection
            con1.ConnectionString = constr
            con1.Open()
            Dim n As String() = {"", ""}
            Dim c As Integer() = {0, 0, 0, 0, 0}
            Dim a As Decimal() = {0, 0, 0, 0, 0, 0}
            sql = "select customerID, Amount, Status from umhdb.sales where SaleAgent = '" & str(3) & "' and Date " & sql
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            If readr.HasRows Then
                Dim al As New ArrayList()
                Dim cid As Integer = 0
                Dim status As String = ""
                While readr.Read()
                    cid = readr.GetInt32("customerID")
                    status = readr.GetString("Status")
                    a(5) = readr.GetDecimal("Amount")
                    If Not (al.Contains(cid)) Then
                        al.Add(cid)
                        c(0) = c(0) + 1
                    End If
                    a(0) = a(0) + a(5)
                    c(1) = c(1) + 1
                    Select Case status
                        Case "r"
                            a(2) = a(2) + a(5)
                            c(3) = c(3) + 1
                        Case "p"
                            a(1) = a(1) + a(5)
                            c(2) = c(2) + 1
                        Case "s"
                            a(3) = a(3) + a(5)
                            c(4) = c(4) + 1
                    End Select
                    sql = "select fName, lName from umhdb.customers where customerID = '" & cid & "' limit 1;"
                    Dim comm1 As New MySqlCommand(sql, con1)
                    Dim readr1 As MySqlDataReader
                    readr1 = comm1.ExecuteReader()
                    readr1.Read()
                    n(0) = readr1.GetString("fName")
                    n(1) = readr1.GetString("lName")
                    readr1.Close()
                    res2 = res2 & "<div class='" & status & " " & status & "b'><b>" & a(5) & "$</b>#" & cid & " " & n(0) & " " & n(1) & "</div>"
                End While
                res = res & "<label>Customers :</label><span>" & c(0) & "</span><br><label>T Sales :</label><span>" & c(1) & "</span> | <span>" & a(0) & "$</span><br><label>Pending :</label><span>" & c(2) & "</span> | <span>" & a(1) & "$</span><br><label>Rejected :</label><span>" & c(3) & "</span> | <span>" & a(2) & "$</span><br><br><label>Success :</label><span>" & c(4) & "</span> | <span>" & a(3) & "$</span><br><br><br>"
            Else
                readr.Close()
                con1.Close()
                Return "No Data Found."
            End If
            readr.Close()
            con1.Close()
        Catch ex As Exception
            Return ex.ToString
        End Try
        res = res & res2 & "</body></html>"
        Return res
    End Function
    Private Function APsOverview(q As String) As String
        Dim res As String = "<html><style>body{font-family:Tahoma, Geneva, sans-serif}b{float:right}span{display:inline-block;width:90px;text-align:center}label{display:inline-block;width:100px;text-align:right;padding-right:8px;color:#777}.r{color:#E40000}.s{color:#00A500}.p{color:#0000A5}.rb{border: 1px solid #E40000}.sb{border: 1px solid #00A500}.pb{border: 1px solid #0000A5}div{padding:3px;margin:5px 2px}</style><body><h4 style='text-align:center'>Session Overview</h4>"
        Dim res2 As String = ""
        Dim str As String() = q.Split("|")
        Dim f As DateTime = str(4)
        Dim t As DateTime = str(5)
        Try
            Dim con1 As New MySqlConnection
            con1.ConnectionString = constr
            con1.Open()
            Dim n As String() = {"", ""}
            Dim c As Integer() = {0, 0, 0, 0, 0}
            Dim a As Decimal() = {0, 0, 0, 0, 0, 0}
            sql = "select customerID, Amount, Status from umhdb.sales where SaleAgent = '" & str(3) & "' and Date between '" & f.ToString("yyyy-MM-dd HH:mm:ss") & "' and '" & t.ToString("yyyy-MM-dd HH:mm:ss") & "';"
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            If readr.HasRows Then
                Dim al As New ArrayList()
                Dim cid As Integer = 0
                Dim status As String = ""
                While readr.Read()
                    cid = readr.GetInt32("customerID")
                    status = readr.GetString("Status")
                    a(5) = readr.GetDecimal("Amount")
                    If Not (al.Contains(cid)) Then
                        al.Add(cid)
                        c(0) = c(0) + 1
                    End If
                    a(0) = a(0) + a(5)
                    c(1) = c(1) + 1
                    Select Case status
                        Case "r"
                            a(2) = a(2) + a(5)
                            c(3) = c(3) + 1
                        Case "p"
                            a(1) = a(1) + a(5)
                            c(2) = c(2) + 1
                        Case "s"
                            a(3) = a(3) + a(5)
                            c(4) = c(4) + 1
                    End Select
                    sql = "select fName, lName from umhdb.customers where customerID = '" & cid & "' limit 1;"
                    Dim comm1 As New MySqlCommand(sql, con1)
                    Dim readr1 As MySqlDataReader
                    readr1 = comm1.ExecuteReader()
                    readr1.Read()
                    n(0) = readr1.GetString("fName")
                    n(1) = readr1.GetString("lName")
                    readr1.Close()
                    res2 = res2 & "<div class='" & status & " " & status & "b'><b>" & a(5) & "$</b>#" & cid & " " & n(0) & " " & n(1) & "</div>"
                End While
                res = res & "<label>Customers :</label><span>" & c(0) & "</span><br><label>T Sales :</label><span>" & c(1) & "</span> | <span>" & a(0) & "$</span><br><label>Pending :</label><span>" & c(2) & "</span> | <span>" & a(1) & "$</span><br><label>Rejected :</label><span>" & c(3) & "</span> | <span>" & a(2) & "$</span><br><br><label>Success :</label><span>" & c(4) & "</span> | <span>" & a(3) & "$</span><br><br><br>"
            Else
                readr.Close()
                con1.Close()
                Return "No Data Found."
            End If
            readr.Close()
            con1.Close()
        Catch ex As Exception
            Return ex.ToString
        End Try
        res = res & res2 & "</body></html>"
        Return res
    End Function
    Private Function APemployeeSaleData(q As String) As String
        Dim res As String = ""
        Dim str As String() = q.Split("|")
        Dim year As String = str(5)
        Select Case str(4)
            Case "1"
                sql = "between '" & year & "-01-01 00:00:00' and '" & year & "-01-31 23:59:59';"
            Case "2"
                sql = "between '" & year & "-02-01 00:00:00' and '" & year & "-02-29 23:59:59';"
            Case "3"
                sql = "between '" & year & "-03-01 00:00:00' and '" & year & "-03-31 23:59:59';"
            Case "4"
                sql = "between '" & year & "-04-01 00:00:00' and '" & year & "-04-30 23:59:59';"
            Case "5"
                sql = "between '" & year & "-05-01 00:00:00' and '" & year & "-05-31 23:59:59';"
            Case "6"
                sql = "between '" & year & "-06-01 00:00:00' and '" & year & "-06-30 23:59:59';"
            Case "7"
                sql = "between '" & year & "-07-01 00:00:00' and '" & year & "-07-31 23:59:59';"
            Case "8"
                sql = "between '" & year & "-08-01 00:00:00' and '" & year & "-08-31 23:59:59';"
            Case "9"
                sql = "between '" & year & "-09-01 00:00:00' and '" & year & "-09-30 23:59:59';"
            Case "10"
                sql = "between '" & year & "-10-01 00:00:00' and '" & year & "-10-31 23:59:59';"
            Case "11"
                sql = "between '" & year & "-11-01 00:00:00' and '" & year & "-11-30 23:59:59';"
            Case "12"
                sql = "between '" & year & "-12-01 00:00:00' and '" & year & "-12-31 23:59:59';"
        End Select
        Try
            Dim con1 As New MySqlConnection
            con1.ConnectionString = constr
            con1.Open()
            sql = "select login, logout from umhdb.logins where employeeID = '" & str(3) & "' and login <> logout and login " & sql
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            If readr.HasRows Then
                While readr.Read()
                    Dim lin As DateTime = readr.GetString("login")
                    Dim lou As DateTime = readr.GetString("logout")
                    Dim span As TimeSpan = lou.Subtract(lin)
                    sql = "select customerID, Amount, Status from umhdb.sales where SaleAgent = '" & str(3) & "' and Date between '" & lin.ToString("yyyy-MM-dd HH:mm:ss") & "' and '" & lou.ToString("yyyy-MM-dd HH:mm:ss") & "';"
                    Dim comm1 As New MySqlCommand(sql, con1)
                    Dim readr1 As MySqlDataReader
                    readr1 = comm1.ExecuteReader()
                    If readr1.HasRows Then
                        Dim al As New ArrayList()
                        Dim a As Decimal() = {0, 0, 0, 0, 0, 0}
                        Dim c As Integer() = {0, 0, 0, 0, 0}
                        While readr1.Read()
                            If Not (al.Contains(readr1.GetInt32("customerID"))) Then
                                al.Add(readr1.GetInt32("customerID"))
                                c(4) = c(4) + 1
                            End If
                            a(5) = readr1.GetDecimal("Amount")
                            a(0) = a(0) + a(5)
                            c(0) = c(0) + 1
                            Select Case readr1.GetString("Status")
                                Case "p"
                                    a(3) = a(3) + a(5)
                                    c(3) = c(3) + 1
                                Case "r"
                                    a(2) = a(2) + a(5)
                                    c(2) = c(2) + 1
                                Case "s"
                                    a(1) = a(1) + a(5)
                                    c(1) = c(1) + 1
                            End Select
                        End While
                        If res = "" Then
                            res = lin.ToString & ";" & lou.ToString & ";" & span.Hours & "h " & span.Minutes & "m;" & c(0) & " | " & a(0) & "$;" & c(1) & " | " & a(1) & "$;" & c(2) & " | " & a(2) & "$;" & c(3) & " | " & a(3) & "$;" & c(4)
                        Else
                            res = res & "," & lin.ToString & ";" & lou.ToString & ";" & span.Hours & "h " & span.Minutes & "m;" & c(0) & " | " & a(0) & "$;" & c(1) & " | " & a(1) & "$;" & c(2) & " | " & a(2) & "$;" & c(3) & " | " & a(3) & "$;" & c(4)
                        End If
                    Else
                        If res = "" Then
                            res = lin.ToString & ";" & lou.ToString & ";" & span.Hours & "h " & span.Minutes & "m;0;0;0;0;0"
                        Else
                            res = res & "," & lin.ToString & ";" & lou.ToString & ";" & span.Hours & "h " & span.Minutes & "m;0;0;0;0;0"
                        End If
                    End If
                    readr1.Close()
                End While
                readr.Close()
                con1.Close()
            Else
                con1.Close()
                Return "NoResult"
            End If
        Catch ex As Exception
            Return "invalid"
        End Try
        Return res
    End Function
    Private Function APemployeeData(q As String) As String
        Dim res As String = ""
        Dim str As String() = q.Split("|")
        If checkSessionID(str(1), str(2)) Then
            If str(3) = "0" Then
                sql = "SELECT * FROM umhdb.employees where Deleted = 'n';"
            Else
                sql = "SELECT * FROM umhdb.employees where employeeID = '" & str(3) & "' and Deleted = 'n' limit 1;"
            End If
            Try
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                If readr.HasRows Then
                    While readr.Read()
                        Dim h As String = readr.GetString("Handler")
                        Select Case h
                            Case "a"
                                h = "Administrator"
                            Case "s"
                                h = "Sales Agent"
                            Case "t"
                                h = "Tech Agent"
                        End Select
                        If res = "" Then
                            res = readr.GetString("employeeID") & "," & readr.GetString("Name") & "," & readr.GetString("Email") & "," & readr.GetString("Phone") & "," & h
                        Else
                            res = res & "|" & readr.GetString("employeeID") & "," & readr.GetString("Name") & "," & readr.GetString("Email") & "," & readr.GetString("Phone") & "," & h
                        End If
                    End While
                    readr.Close()
                Else
                    readr.Close()
                    Return "NoResult"
                End If
            Catch ex As Exception
                Return "invalid"
            End Try
        Else
            Return "invalid"
        End If
        Return res
    End Function
    Private Function logoutUser(q As String) As String
        Dim str As String() = q.Split("|")
        Try
            sql = "UPDATE `umhdb`.`logins` SET `logout`='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' WHERE `sessionID`='" & str(1) & "';"
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            readr.Close()
        Catch ex As Exception
            Return "invalid"
        End Try
        Return "done"
    End Function
    Private Function EditSaleData(q As String) As String
        Dim str As String() = q.Split("|")
        Dim sql1 As String = ""
        Dim i As Integer = 0
        Dim e As String() = str(4).Split(";")
        For Each ed As String In e
            If i = 0 Then
                sql1 = "`" & ed.Split(",")(0) & "`='" & ed.Split(",")(1) & "'"
            Else
                sql1 = sql1 & ", `" & ed.Split(",")(0) & "`='" & ed.Split(",")(1) & "'"
            End If
            i = i + 1
        Next
        sql1 = "UPDATE `umhdb`.`sales` SET " & sql1 & " WHERE `saleID`='" & str(3) & "';"
        If checkSessionID(str(1), str(2)) Then
            Try
                comm = New MySqlCommand(sql1, con)
                readr = comm.ExecuteReader()
                readr.Close()
            Catch ex As Exception
                Return "invalid"
            End Try
        Else
            Return "invalid"
        End If
        Return "Done"
    End Function
    Private Function AddNewSale(q As String) As String
        Dim str As String() = q.split("|")
        Dim saleid As String
        If checkSessionID(str(1), str(2)) Then
            Try
                sql = "INSERT INTO `umhdb`.`sales` (`saleID`, `customerID`, `Amount`, `ChequeDetails`, `ChequeType`, `Status`, `Plan`, `SaleAgent`, `PaymentTakenBy`) VALUES ('0', '" & str(3) & "', '" & str(4) & "', '" & str(5) & "', '" & str(6) & "', 'p', '" & str(7) & "', '" & str(1) & "', '" & str(8) & "'); SELECT LAST_INSERT_ID();"
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                readr.Read()
                saleid = readr.GetString(0)
                readr.Close()
                sql = "INSERT INTO `umhdb`.`comments` (`commentID`, `SaleID`, `commentBY`, `comment`) VALUES ('0', '" & saleid & "', '" & str(1) & "', '<u class=''date''>" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "</u>" & str(9) & "');"
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                readr.Close()
            Catch ex As Exception
                Return "invalid"
            End Try
        Else
            Return "invalid"
        End If
        Return "done"
    End Function
    Private Function AddNewComment(q As String) As String
        Dim str As String() = q.split("|")
        If checkSessionID(str(1), str(2)) Then
            sql = "INSERT INTO `umhdb`.`comments` (`commentID`, `SaleID`, `commentBY`, `comment`) VALUES ('0', '" & str(3) & "', '" & str(1) & "', '<u class=''date''>" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "</u>" & str(4) & "');"
            Try
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                readr.Close()
            Catch ex As Exception
                Return ex.ToString
            End Try
        Else
            Return "invalid"
        End If
        Return "Done"
    End Function
    Private Function getSaleComment(q As String) As String
        Dim str As String() = Split(q, "|")
        Dim d As String() = {"", "", "", ""}
        Dim res As String = ""
        Dim layout As String = "<html><style>body{font-family:Tahoma, Geneva, sans-serif}.date{font-size:70%;color:#777;padding-bottom:10px;display:block}div{padding-bottom:20px; border-top: 1px solid #aaa}.f{font-size:102%}</style><body>"
        Try
            sql = "select commentBY, comment from umhdb.comments where SaleID = '" & str(1) & "';"
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            If readr.HasRows Then
                Dim con1 As New MySqlConnection
                con1.ConnectionString = constr
                con1.Open()
                While readr.Read()
                    d(0) = readr.GetString("commentBY")
                    sql = "select Name, Handler from umhdb.employees where employeeID = '" & d(0) & "' limit 1;"
                    Dim comm1 As New MySqlCommand(sql, con1)
                    Dim readr1 As MySqlDataReader
                    readr1 = comm1.ExecuteReader()
                    readr1.Read()
                    d(1) = readr1.GetString("Name")
                    d(2) = readr1.GetString("Handler")
                    readr1.Close()
                    Select Case d(2)
                        Case "a"
                            d(2) = "Administrator"
                        Case "s"
                            d(2) = "Sales Agent"
                        Case "t"
                            d(2) = "Tech Agent"
                    End Select
                    d(3) = readr.GetString("comment")
                    res = res & "<div><b>#" & d(0) & "</b> " & d(1) & "<br><b class='f'>" & d(2) & "</b>" & d(3) & "</div>"
                End While
                con1.Close()
                res = layout & res & "</body></html>"
            Else
                Return "NoResult"
            End If
            readr.Close()
        Catch ex As Exception
            Return "invalid"
        End Try
        Return res
    End Function
    Private Function getSaleData(q As String) As String
        Dim str As String() = Split(q, "|")
        Dim sd As String() = {"", "", "", "", "", "", "", "", "", ""}
        Dim res As String = ""
        Try
            Dim con1 As New MySqlConnection
            con1.ConnectionString = constr
            con1.Open()
            sql = "select * from umhdb.sales where customerID = '" & str(1) & "';"
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            If readr.HasRows Then
                Dim i As Integer = 0
                While readr.Read()
                    sd(0) = readr.GetString("saleID")
                    sd(1) = readr.GetString("customerID")
                    sd(2) = readr.GetString("Amount")
                    sd(3) = readr.GetString("ChequeDetails")
                    sd(4) = readr.GetString("ChequeType")
                    sd(5) = readr.GetString("Status")
                    sd(6) = readr.GetString("Plan")
                    sd(7) = readr.GetString("Date")
                    sd(8) = readr.GetString("SaleAgent")
                    sd(9) = readr.GetString("PaymentTakenBy")
                    Select Case sd(5)
                        Case "p"
                            sd(5) = "Pending"
                        Case "r"
                            sd(5) = "Rejected"
                        Case "s"
                            sd(5) = "Success"
                    End Select
                    sql = "select Name from umhdb.employees where employeeID = '" & sd(8) & "' limit 1;"
                    Dim comm1 As New MySqlCommand(sql, con1)
                    Dim readr1 As MySqlDataReader
                    readr1 = comm1.ExecuteReader()
                    readr1.Read()
                    sd(8) = "#" & sd(8) & " " & readr1.GetString("Name")
                    readr1.Close()
                    If i = 0 Then
                        res = sd(0) & "|" & sd(1) & "|" & sd(2) & "|" & sd(3) & "|" & sd(4) & "|" & sd(5) & "|" & sd(6) & "|" & sd(7) & "|" & sd(8) & "|" & sd(9)
                    Else
                        res = res & ";" & sd(0) & "|" & sd(1) & "|" & sd(2) & "|" & sd(3) & "|" & sd(4) & "|" & sd(5) & "|" & sd(6) & "|" & sd(7) & "|" & sd(8) & "|" & sd(9)
                    End If
                    i = i + 1
                End While
                con1.Close()
                readr.Close()
            Else
                readr.Close()
                Return "NoResult"
            End If
        Catch ex As Exception
            Return ex.ToString & "invalid"
        End Try
        Return res
    End Function
    Private Function editcustomer(q As String) As String
        Dim str As String() = Split(q, "|")
        Dim sql1 As String = ""
        Dim i As Integer = 0
        Dim e As String() = str(4).Split(";")
        For Each ed As String In e
            If i = 0 Then
                sql1 = "`" & ed.Split(",")(0) & "`='" & ed.Split(",")(1) & "'"
            Else
                sql1 = sql1 & ", `" & ed.Split(",")(0) & "`='" & ed.Split(",")(1) & "'"
            End If
            i = i + 1
        Next
        sql1 = "UPDATE `umhdb`.`customers` SET " & sql1 & " WHERE `customerID`='" & str(3) & "';"
        If checkSessionID(str(1), str(2)) Then
            Try
                comm = New MySqlCommand(sql1, con)
                readr = comm.ExecuteReader()
                readr.Close()
            Catch ex As Exception
                Return "invalid"
            End Try
        Else
            Return "invalid"
        End If
        Return "Done"
    End Function
    Private Function searchCustomer(q) As String
        Dim str As String() = Split(q, "|")
        Dim result As String = ""
        Dim re As Boolean = False
        Dim d As String() = {"", "", "", "", "", "", "", "", "", "", ""}
        If checkSessionID(str(1), str(2)) Then
            Try
                sql = "select * from umhdb.customers where customerID = '" & str(4) & "' or Email = '" & str(4) & "' or Phone = '" & str(4) & "' or AltPhone = '" & str(4) & "' limit 1;"
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                If readr.HasRows Then
                    readr.Read()
                    d(0) = readr.GetString("customerID")
                    d(1) = readr.GetString("Salutation")
                    d(2) = readr.GetString("fName")
                    d(3) = readr.GetString("lName")
                    d(4) = readr.GetString("Email")
                    d(5) = readr.GetString("Phone")
                    d(6) = readr.GetString("AltPhone")
                    d(7) = readr.GetString("Address")
                    d(8) = readr.GetString("Country")
                    d(9) = readr.GetString("AddedBy")
                    readr.Close()
                    sql = "select Name from umhdb.employees where employeeID = '" & d(9) & "' limit 1;"
                    comm = New MySqlCommand(sql, con)
                    readr = comm.ExecuteReader()
                    readr.Read()
                    d(10) = readr.GetString("Name")
                    readr.Close()
                Else
                    readr.Close()
                    re = True
                End If
            Catch ex As Exception
                Return "invalid"
            End Try
            If str(3) = "html" Then
                If re Then
                    result = "0|<html style='background:#eee;font-family:Tahoma, Geneva, sans-serif'><h3 style='text-align:center'>No Result Found!</h3></html>"
                Else
                    result = d(0) & "|" & "<html><style>body{background:#eee;font-size:70%;font-family: Tahoma, Geneva, sans-serif}div{width:50%;padding:3px 0;float:left}.f{font-size:150%}</style><body>#" & d(0) & " <b class='f'>" & d(1) & " " & d(2) & " " & d(3) & "</b><br><br>" & d(4) & "<br><div class='f'>" & d(5) & "</div><div class='f'>" & d(6) & "</div><br style='clear:both'><div>" & d(7) & "</div><div>Country : " & d(8) & "</div>By <b>" & d(10) & "</b> #" & d(9) & "</body></html>"
                End If
            Else
                If re Then
                    result = "NoResult"
                Else
                    result = d(0) & "|" & d(1) & "|" & d(2) & "|" & d(3) & "|" & d(4) & "|" & d(5) & "|" & d(6) & "|" & d(7) & "|" & d(8) & "|" & d(9) & "|" & d(10)
                End If
            End If
        Else
            Return "invalid"
        End If
        Return result
    End Function
    Private Function addNewCustomer(q As String) As String
        Dim str As String() = Split(q, "|")
        Dim customerID As String = ""
        If checkSessionID(str(1), str(2)) Then
            Try
                sql = "INSERT INTO `umhdb`.`customers` (`customerID`, `Salutation`, `fName`, `lName`, `Email`, `Phone`, `AltPhone`, `Address`, `Country`, `AddedBy`) VALUES ('0', '" & str(3) & "', '" & str(4) & "', '" & str(5) & "', '" & str(6) & "', '" & str(7) & "', '" & str(8) & "', '" & str(9) & "', '" & str(10) & "', '" & str(1) & "'); SELECT LAST_INSERT_ID();"
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                readr.Read()
                customerID = readr.GetString(0)
                readr.Close()
            Catch ex As Exception
                Return "invalid"
            End Try
        Else
            Return "invalid"
        End If
        Return customerID
    End Function
    Private Function getEmployeeName(q As String) As String
        Dim str As String() = Split(q, "|")
        Dim name As String = ""
        If checkSessionID(str(1), str(2)) Then
            Try
                sql = "select Name from umhdb.employees where employeeID = '" & str(1) & "' limit 1;"
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                readr.Read()
                name = readr.GetString("Name")
                readr.Close()
            Catch ex As Exception
                Return "invalid"
            End Try
        Else
            Return "invalid"
        End If
        Return name
    End Function
    Private Function getEmployeeData(q As String) As String
        Dim str As String() = Split(q, "|")
        Dim d As String() = {"", "", "", "", "", "0", "0", "0", "0"}
        If checkSessionID(str(1), str(2)) Then
            Try
                sql = "select login from umhdb.logins where sessionID = '" & str(2) & "' limit 1;"
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                readr.Read()
                d(0) = readr.GetString("login")
                readr.Close()

                sql = "select * from umhdb.employees where employeeID = '" & str(1) & "' limit 1;"
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                readr.Read()
                d(2) = readr.GetString("Name")
                d(3) = readr.GetString("Email")
                d(4) = readr.GetString("Phone")
                d(1) = readr.GetString("Handler")
                readr.Close()
                Select Case d(1)
                    Case "s"
                        d(1) = "Sales Agent"
                    Case "t"
                        d(1) = "Tech Agent"
                    Case "a"
                        d(1) = "Administrator"
                End Select
                Dim year As String = DateTime.Now.Year
                Select Case str(3)
                    Case "1"
                        sql = "between '" & year & "-01-01 00:00:00' and '" & year & "-01-31 23:59:59';"
                    Case "2"
                        sql = "between '" & year & "-02-01 00:00:00' and '" & year & "-02-29 23:59:59';"
                    Case "3"
                        sql = "between '" & year & "-03-01 00:00:00' and '" & year & "-03-31 23:59:59';"
                    Case "4"
                        sql = "between '" & year & "-04-01 00:00:00' and '" & year & "-04-30 23:59:59';"
                    Case "5"
                        sql = "between '" & year & "-05-01 00:00:00' and '" & year & "-05-31 23:59:59';"
                    Case "6"
                        sql = "between '" & year & "-06-01 00:00:00' and '" & year & "-06-30 23:59:59';"
                    Case "7"
                        sql = "between '" & year & "-07-01 00:00:00' and '" & year & "-07-31 23:59:59';"
                    Case "8"
                        sql = "between '" & year & "-08-01 00:00:00' and '" & year & "-08-31 23:59:59';"
                    Case "9"
                        sql = "between '" & year & "-09-01 00:00:00' and '" & year & "-09-30 23:59:59';"
                    Case "10"
                        sql = "between '" & year & "-10-01 00:00:00' and '" & year & "-10-31 23:59:59';"
                    Case "11"
                        sql = "between '" & year & "-11-01 00:00:00' and '" & year & "-11-30 23:59:59';"
                    Case "12"
                        sql = "between '" & year & "-12-01 00:00:00' and '" & year & "-12-31 23:59:59';"
                End Select
                sql = "select Amount, Status from umhdb.sales where SaleAgent = '" & str(1) & "' and Date " & sql
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                Dim a As Decimal() = {0, 0, 0, 0, 0} ' 1-total 2-pending 3-rejected 4-success
                Dim status As String = ""
                If readr.HasRows Then
                    While readr.Read()
                        a(0) = readr.GetDecimal("Amount")
                        status = readr.GetString("Status")
                        a(1) = a(1) + a(0)
                        Select Case status
                            Case "s"
                                a(4) = a(4) + a(0)
                            Case "p"
                                a(2) = a(2) + a(0)
                            Case "r"
                                a(3) = a(3) + a(0)
                        End Select
                    End While
                    d(5) = a(1)
                    d(6) = a(2)
                    d(7) = a(3)
                    d(8) = a(4)
                End If
                readr.Close()
            Catch ex As Exception
                Return "invalid"
            End Try
        Else
            Return "invalid"
        End If
        Return "<html><style>body{font-size:100%;font-family: Tahoma, Geneva, sans-serif}label{display:inline-block;color:#777;width:80px;text-align:right;padding-right:10px}div{vertical-align:top;float:left}b{display:block;font-size:110%;margin:10px 0}</style><body><label>Login @</label> " & d(0) & "<br><div style='width:60%'><b>" & d(1) & "</b>" & d(2) & "<br>" & d(3) & "<br>" & d(4) & "</div><div style='width:40%'><b>Overview</b><label>Total : </label>" & d(5) & "$<br><label>Pending : </label>" & d(6) & "$<br><label>Rejected : </label>" & d(7) & "$<br><br><label>Success : </label>" & d(8) & "$</div></body></html>"
    End Function
    Private Function login(ByVal q As String) As String
        Dim d As String() = Split(q, "|")
        Dim employeeID As String
        Dim Handler As String
        Dim sessionid As String = ""
        Try
            sql = "select employeeID, Handler from umhdb.employees where Phone = '" & d(1) & "' and Password = '" & d(2) & "' and Deleted = 'n';"
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            Dim ra As Boolean = True
            If readr.HasRows Then
                readr.Read()
                employeeID = readr.GetInt32(0)
                Handler = readr.GetString(1)
                readr.Close()
                sql = "select SessionID, login, logout from umhdb.logins where employeeID = '" & employeeID & "' order by Sno desc limit 1;"
                comm = New MySqlCommand(sql, con)
                readr = comm.ExecuteReader()
                If readr.HasRows Then
                    readr.Read()
                    If readr.GetString("login") = readr.GetString("logout") Then
                        sessionid = readr.GetString("SessionID")
                        ra = False
                    End If
                End If
                readr.Close()
                If ra Then
                    Dim tn As DateTime = DateTime.Now
                    Dim md5hash As MD5 = MD5.Create()
                    Dim data As Byte() = md5hash.ComputeHash(Encoding.UTF8.GetBytes(tn.ToString("yyyyMMddhhmmss")))
                    Dim sBuilder As New StringBuilder()
                    Dim i As Integer
                    For i = 0 To data.Length - 1
                        sBuilder.Append(data(i).ToString("x2"))
                    Next i
                    sessionid = sBuilder.ToString()
                    sql = "INSERT INTO `umhdb`.`logins` (`Sno`, `employeeID`, `sessionID`) VALUES ('0', '" & employeeID & "', '" & sessionid & "');"
                    comm = New MySqlCommand(sql, con)
                    readr = comm.ExecuteReader()
                    readr.Close()
                End If
            Else
                readr.Close()
                Return "invalid"
            End If
        Catch ex As Exception
            Return "DatabaseError"
        End Try
        sessionid = sessionid & "|" & employeeID & "|" & Handler
        Return sessionid
    End Function
    Private Function checkSessionID(eid As String, sid As String) As Boolean
        Try
            sql = "select Sno from umhdb.logins where sessionID = '" & sid & "' and employeeID = '" & eid & "' limit 1;"
            comm = New MySqlCommand(sql, con)
            readr = comm.ExecuteReader()
            If readr.HasRows Then
                readr.Close()
            Else
                readr.Close()
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Class