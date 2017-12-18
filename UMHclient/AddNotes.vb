Public Class AddNotes
    Public Property saleID As String
    Public Property employeeID As String
    Public Property sessionID As String
    Public Property done As Boolean = False
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

    Private Sub AddNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saleIDl.Text = saleID
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
                    notesHistory.DocumentText = "No Comments Attached!"
                Else
                    notesHistory.DocumentText = d
                End If
            End If
        Catch ex As Exception
            MsgBox("Server Not Responding.")
        End Try
    End Sub

    
    Private Sub AddCommentbt_Click(sender As Object, e As EventArgs) Handles AddCommentbt.Click
        If newComment.Text = "" Then
            MsgBox("Empty Field Detected")
        Else
            Dim s As String = newComment.Text.Replace(vbNewLine, "<br>")
            Dim ip As String
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
            ip = fileReader.ReadLine()
            fileReader.Close()
            Try
                Dim clientOBJ As New client(ip)
                If clientOBJ.client1.Connected Then
                    clientOBJ.send("AddComment|" & employeeID & "|" & sessionID & "|" & saleID & "|" & s)
                    Dim d As String = clientOBJ.getdata()
                    If d = "invalid" Or d = "Err" Then
                        MsgBox("An Error Occured.")
                    Else
                        done = True
                        Me.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Server Not Responding.")
            End Try
        End If
    End Sub
End Class