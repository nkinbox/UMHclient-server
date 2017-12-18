Public Class NewSale
    Public Property CustomerID As String
    Public Property sessionID As String
    Public Property employeeID As String
    Public Property added As Boolean = False
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

    Private Sub NewSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customerIDl.Text = "#" & CustomerID
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If amount.Text = "" Then
            errorl.Text = "Enter Amount"
            Return
        End If
        If chequeno.Text = "" Then
            errorl.Text = "Enter Cheque Details."
            Return
        End If
        If chequetype.SelectedIndex < 0 Then
            errorl.Text = "Select Cheque Type."
            Return
        End If
        If plan.Text = "" Then
            errorl.Text = "Enter Sale Plan."
            Return
        End If
        If paymentby.Text = "" Then
            errorl.Text = "payment Taken by?"
            Return
        End If
        If comment.Text = "" Then
            errorl.Text = "Sales Notes Cannot Be empty."
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
                clientOBJ.send("NewSale|" & employeeID & "|" & sessionID & "|" & CustomerID & "|" & amount.Text & "|" & chequeno.Text & "|" & chequetype.Text & "|" & plan.Text & "|" & paymentby.Text & "|" & comment.Text.Replace(vbNewLine, "<br>"))
                Dim d As String = clientOBJ.getdata()
                If d = "invalid" Or d = "Err" Then
                    MsgBox("An Error Occured.")
                Else
                    added = True
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Is Not Responding. Please Try Again")
        End Try
    End Sub
End Class