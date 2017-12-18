Public Class EditSalesData
    Public Property saledata As String()
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

    Private Sub EditSalesData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saleidl.Text = saledata(0)
        status.Text = saledata(4)
        amount.Text = saledata(1)
        chequeno.Text = saledata(2)
        chequetype.Text = saledata(3)
        saleplan.Text = saledata(5)
        Saleagentl.Text = saledata(6)
        paymentby.Text = saledata(7)
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim q As String = ""
        If status.Text <> saledata(4) Then
            Dim temp As String = ""
            Select Case status.Text
                Case "Pending"
                    temp = "p"
                Case "Rejected"
                    temp = "r"
                Case "Success"
                    temp = "s"
            End Select
            If q = "" Then
                q = "Status," & temp
            Else
                q = q & ";Status," & temp
            End If
        End If
        If amount.Text <> saledata(1) Then
            If q = "" Then
                q = "Amount," & amount.Text
            Else
                q = q & ";Amount," & amount.Text
            End If
        End If
        If chequeno.Text <> saledata(2) Then
            If q = "" Then
                q = "ChequeDetails," & chequeno.Text
            Else
                q = q & ";ChequeDetails," & chequeno.Text
            End If
        End If
        If chequetype.Text <> saledata(3) Then
            If q = "" Then
                q = "ChequeType," & chequetype.Text
            Else
                q = q & ";ChequeType," & chequetype.Text
            End If
        End If
        If saleplan.Text <> saledata(5) Then
            If q = "" Then
                q = "Plan," & saleplan.Text
            Else
                q = q & ";Plan," & saleplan.Text
            End If
        End If
        If paymentby.Text <> saledata(7) Then
            If q = "" Then
                q = "PaymentTakenBy," & paymentby.Text
            Else
                q = q & ";PaymentTakenBy," & paymentby.Text
            End If
        End If
        Dim ip As String
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ServerIP_Address.txt")
        ip = fileReader.ReadLine()
        fileReader.Close()
        Try
            Dim clientOBJ As New client(ip)
            If clientOBJ.client1.Connected Then
                clientOBJ.send("EditSale|" & employeeID & "|" & sessionID & "|" & saledata(0) & "|" & q)
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