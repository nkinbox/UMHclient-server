Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Net.Sockets
Public Class client
    Public client1 As TcpClient
    Private content As StreamWriter
    Private result As StreamReader
    Public Sub New(ByVal ipadd As String)
        client1 = New TcpClient(ipadd, 50707)
        client1.ReceiveTimeout = 2000
        client1.SendTimeout = 2000
        content = New StreamWriter(client1.GetStream)
    End Sub
    Public Function getdata() As String
        Try
            result = New StreamReader(client1.GetStream)
            Return result.ReadLine
        Catch ex As Exception
            Return "Err"
        End Try
    End Function
    Public Sub send(ByVal str As String)
        Try
            content.Write(str & vbCrLf)
            content.Flush()
        Catch ex As Exception
        End Try
    End Sub
End Class
