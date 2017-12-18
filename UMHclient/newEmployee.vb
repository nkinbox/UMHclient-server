Public Class newEmployee
    Public Property done As Boolean = False
    Private Sub addBT_Click(sender As Object, e As EventArgs) Handles addBT.Click
        If NameTB.Text = "" Then
            errorl.Text = "Enter Name."
            Return
        End If
        If emailTB.Text = "" Then
            errorl.Text = "Enter Email"
            Return
        End If
        If phoneTB.Text = "" Then
            errorl.Text = "Enter Phone Number."
            Return
        End If
        If passwordTB.Text = "" Then
            errorl.Text = "Enter Password"
            Return
        End If
        If handlerdl.SelectedIndex < 0 Then
            errorl.Text = "Select handler."
            Return
        End If
        Dim han As String = "0"
        Select Case handlerdl.SelectedIndex
            Case 0
                han = "s"
            Case 1
                han = "t"
            Case 2
                han = "a"
        End Select
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("AddEmployee|" & NameTB.Text & "|" & emailTB.Text & "|" & phoneTB.Text & "|" & passwordTB.Text & "|" & han)
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                Else
                    done = True
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub
End Class