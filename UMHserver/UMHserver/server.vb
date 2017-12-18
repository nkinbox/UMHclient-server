Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Net.Sockets
Public Class server
    Public Event newrequest(ByVal sender As server)
    Private server1 As TcpListener = Nothing
    Private serverthread As Thread = Nothing
    Public Sub begin(ByVal ip As String)
        server1 = New TcpListener(IPAddress.Parse(ip), 50707)
        serverthread = New Thread(AddressOf ConnectionListener)
        serverthread.IsBackground = True
        serverthread.Start()
    End Sub
    Private Sub ConnectionListener()
        server1.Start()
        While True
            Try
                RaiseEvent newrequest(Me)         'raise event to count requests
            Catch ex As Exception
            End Try
            Dim client As TcpClient = server1.AcceptTcpClient()
            Dim T As New Thread(AddressOf connected)
            T.Start(client)
        End While
    End Sub
    Private Sub connected(ByVal client As TcpClient)
        client.SendTimeout = 2000
        client.ReceiveTimeout = 2000
        Dim received As StreamReader
        Dim senddata As StreamWriter
        Dim db As database
        Try
            received = New StreamReader(client.GetStream)
            db = New database("undermyhat")
            If db.r Then
                senddata = New StreamWriter(client.GetStream)
                senddata.Write(db.query(received.ReadLine()) & vbCrLf)
                senddata.Flush()
            End If
        Catch ex As Exception
        Finally
            client.Close()
        End Try
    End Sub
End Class
