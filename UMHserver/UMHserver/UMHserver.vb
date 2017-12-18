Public Class UMHserver
    Private ServerObj As server
    Private closebol As Boolean = True
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each ipadd As System.Net.IPAddress In System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList()
            If ipadd.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                ipaddress.Text = ipadd.ToString()
            End If
        Next
    End Sub

    Private Sub connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connect.Click
        connect.Enabled = False
        ServerObj = New server
        ServerObj.begin(ipaddress.Text)
        AddHandler ServerObj.newrequest, AddressOf counting
    End Sub

    'changing count starts here

    Private Delegate Sub updatecount1(ByVal lb As Label)
    Private Sub updatecount(ByVal lb As Label)
        If lb.InvokeRequired Then
            lb.Invoke(New updatecount1(AddressOf updatecount), New Object() {lb})
        Else
            Dim c As Integer = lb.Text
            c = c + 1
            lb.Text = c.ToString
        End If
    End Sub
    Private Sub counting()
        updatecount(count)
    End Sub

    'changing count ends here

    Private Sub ShowHideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowHideToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If closebol Then
            Me.Hide()
            e.Cancel = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        closebol = False
        Me.Close()
    End Sub
End Class
