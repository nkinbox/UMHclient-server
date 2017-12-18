<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNotes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNotes))
        Me.closebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newComment = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.saleIDl = New System.Windows.Forms.Label()
        Me.AddCommentbt = New System.Windows.Forms.Button()
        Me.notesHistory = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'closebtn
        '
        Me.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closebtn.Location = New System.Drawing.Point(536, 3)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(21, 23)
        Me.closebtn.TabIndex = 11
        Me.closebtn.Text = "X"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(110, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Add Notes"
        '
        'newComment
        '
        Me.newComment.Location = New System.Drawing.Point(290, 69)
        Me.newComment.Multiline = True
        Me.newComment.Name = "newComment"
        Me.newComment.Size = New System.Drawing.Size(258, 284)
        Me.newComment.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Notes History"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "New Notes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "SaleID -"
        '
        'saleIDl
        '
        Me.saleIDl.AutoSize = True
        Me.saleIDl.Location = New System.Drawing.Point(285, 20)
        Me.saleIDl.Name = "saleIDl"
        Me.saleIDl.Size = New System.Drawing.Size(13, 13)
        Me.saleIDl.TabIndex = 18
        Me.saleIDl.Text = "0"
        '
        'AddCommentbt
        '
        Me.AddCommentbt.Location = New System.Drawing.Point(473, 369)
        Me.AddCommentbt.Name = "AddCommentbt"
        Me.AddCommentbt.Size = New System.Drawing.Size(75, 23)
        Me.AddCommentbt.TabIndex = 19
        Me.AddCommentbt.Text = "Add"
        Me.AddCommentbt.UseVisualStyleBackColor = True
        '
        'notesHistory
        '
        Me.notesHistory.IsWebBrowserContextMenuEnabled = False
        Me.notesHistory.Location = New System.Drawing.Point(12, 70)
        Me.notesHistory.MinimumSize = New System.Drawing.Size(20, 20)
        Me.notesHistory.Name = "notesHistory"
        Me.notesHistory.Size = New System.Drawing.Size(267, 283)
        Me.notesHistory.TabIndex = 20
        '
        'AddNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(560, 404)
        Me.Controls.Add(Me.notesHistory)
        Me.Controls.Add(Me.AddCommentbt)
        Me.Controls.Add(Me.saleIDl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.newComment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closebtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddNotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddNotes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newComment As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents saleIDl As System.Windows.Forms.Label
    Friend WithEvents AddCommentbt As System.Windows.Forms.Button
    Friend WithEvents notesHistory As System.Windows.Forms.WebBrowser
End Class
