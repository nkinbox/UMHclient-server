Public Class CustomerDetails
    Public Property Mode As String
    Public Property CustomerID As String
    Public Property employeeID As String
    Public Property sessionID As String
    Dim temp As String = ""
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Mouse_Down(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Mouse_Move(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Mouse_Up(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub

    Private Sub CustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Mode
            Case "Add"
                aebtn.Text = "Add Customer"
                CustomerIDl.Text = CustomerID
            Case "Edit"
                aebtn.Text = "Edit Details"
                CustomerIDl.Text = CustomerID
        End Select
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                If Mode = "Add" Then
                    clientOBJ.send("employeeName|" & employeeID & "|" & sessionID)
                    Dim d As String = clientOBJ.getdata()
                    If d = "invalid" Or d = "Err" Then
                        MsgBox("An Error Occured.")
                    Else
                        employeeIDl.Text = d
                    End If
                Else
                    clientOBJ.send("Search|" & employeeID & "|" & sessionID & "|array|" & CustomerID)
                    Dim d As String = clientOBJ.getdata()
                    If d = "invalid" Or d = "Err" Or d = "NoResult" Then
                        MsgBox("An Error Occured.")
                    Else
                        temp = d
                        Dim str As String() = d.Split("|")
                        salutation.Text = str(1)
                        fname.Text = str(2)
                        lname.Text = str(3)
                        email.Text = str(4)
                        phone.Text = str(5)
                        altphone.Text = str(6)
                        address.Text = str(7).Replace("<br>", vbNewLine)
                        country.Text = str(8)
                        employeeIDl.Text = str(10)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
        
    End Sub

    Private Sub aebtn_Click(sender As Object, e As EventArgs) Handles aebtn.Click
        If salutation.SelectedIndex < 0 Then
            errorl.Text = "Select Salutation."
            Return
        End If
        If fname.Text = "" Then
            errorl.Text = "Enter First Name."
            Return
        End If
        If lname.Text = "" Then
            errorl.Text = "Enter Last Name."
            Return
        End If
        If email.Text = "" Then
            errorl.Text = "Enter Email address."
            Return
        End If
        If phone.Text = "" Then
            errorl.Text = "Enter Phone Number."
            Return
        End If
        If altphone.Text = "" Then
            errorl.Text = "Enter Alt. Phone Name or 0 for Null."
            Return
        End If
        If address.Text = "" Then
            errorl.Text = "Enter Address of customer."
            Return
        End If
        If country.SelectedIndex < 0 Then
            errorl.Text = "Select Country."
            Return
        End If
        Dim addressSTR As String = address.Text.Replace(vbNewLine, "<br>")
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        
        If Mode = "Add" Then
            Try
                Dim clientOBJ As New client(ip)
                If clientOBJ.client1.Connected Then
                    clientOBJ.send("addcustomer|" & employeeID & "|" & sessionID & "|" & salutation.Text & "|" & fname.Text & "|" & lname.Text & "|" & email.Text & "|" & phone.Text & "|" & altphone.Text & "|" & addressSTR & "|" & country.Text)
                    Dim d As String = clientOBJ.getdata()
                    If d = "invalid" Or d = "Err" Then
                        MsgBox("Customer was not Added.")
                    Else
                        CustomerID = d
                        Me.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox("An Error Occured.")
            End Try
        Else
            Dim q As String = ""
            Dim d As String() = temp.Split("|")
            If salutation.Text <> d(1) Then
                If q = "" Then
                    q = "Salutation," & salutation.Text
                Else
                    q = q & ";Salutation," & salutation.Text
                End If
            End If
            If fname.Text <> d(2) Then
                If q = "" Then
                    q = "fName," & fname.Text
                Else
                    q = q & ";fName," & fname.Text
                End If
            End If
            If lname.Text <> d(3) Then
                If q = "" Then
                    q = "lName," & lname.Text
                Else
                    q = q & ";lName," & lname.Text
                End If
            End If
            If email.Text <> d(4) Then
                If q = "" Then
                    q = "Email," & email.Text
                Else
                    q = q & ";Email," & email.Text
                End If
            End If
            If phone.Text <> d(5) Then
                If q = "" Then
                    q = "Phone," & phone.Text
                Else
                    q = q & ";Phone," & phone.Text
                End If
            End If
            If altphone.Text <> d(6) Then
                If q = "" Then
                    q = "AltPhone," & altphone.Text
                Else
                    q = q & ";AltPhone," & altphone.Text
                End If
            End If
            If address.Text.Replace(vbNewLine, "<br>") <> d(7) Then
                If q = "" Then
                    q = "Address," & address.Text.Replace(vbNewLine, "<br>")
                Else
                    q = q & ";Address," & address.Text.Replace(vbNewLine, "<br>")
                End If
            End If
            If country.Text <> d(8) Then
                If q = "" Then
                    q = "Country," & country.Text
                Else
                    q = q & ";Country," & country.Text
                End If
            End If
            If q = "" Then
                Me.Close()
            Else
                Try
                    Dim clientOBJ As New client(ip)
                    If clientOBJ.client1.Connected Then
                        clientOBJ.send("editcustomer|" & employeeID & "|" & sessionID & "|" & CustomerID & "|" & q)
                        Dim a As String = clientOBJ.getdata()
                        If a = "invalid" Or a = "Err" Then
                            MsgBox("Customer Data was not Edited.")
                        Else
                            Me.Close()
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("An Error Occured.")
                End Try
            End If
        End If
    End Sub
End Class