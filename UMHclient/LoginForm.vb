Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
            IPaddressTB.Text = fileReader.ReadLine()
            fileReader.Close()
        Catch ex As Exception
            Dim serverIPaddress As System.IO.StreamWriter
            serverIPaddress = My.Computer.FileSystem.OpenTextFileWriter("ServerIP_Address.txt", False)
            serverIPaddress.WriteLine(IPaddressTB.Text)
            serverIPaddress.Close()
        End Try
    End Sub
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        loginprocess()
    End Sub

    Private Sub loginprocess()
        login.Enabled = False
        Dim serverIPaddress As System.IO.StreamWriter
        serverIPaddress = My.Computer.FileSystem.OpenTextFileWriter("ServerIP_Address.txt", False)
        serverIPaddress.WriteLine(IPaddressTB.Text)
        serverIPaddress.Close()
        Try
            Dim clientOBJ As New client(IPaddressTB.Text)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("login|" & UseridTB.Text & "|" & PasswordTB.Text)
                Dim sid As String = clientOBJ.getdata()
                If sid = "invalid" Or sid = "DatabaseError" Or sid = "Err" Then
                    Loginerror.Text = "Invalid UserID or Password."
                    login.Enabled = True
                Else
                    Dim str As String() = sid.Split("|")
                    Dim cpanel As New ControlPanel
                    cpanel.SessionID = str(0)
                    cpanel.employeeID = str(1)
                    cpanel.handler = str(2)
                    cpanel.openpanel(Me)
                    cpanel.Show()
                End If
            End If
        Catch ex As Exception
            Loginerror.Text = "Check Server IP Address."
            login.Enabled = True
        End Try
    End Sub
    Private Sub PasswordTB_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTB.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginprocess()
        End If
    End Sub
End Class