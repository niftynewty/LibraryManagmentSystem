<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtYearPublish = New System.Windows.Forms.TextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.btnUpdate2 = New System.Windows.Forms.Button()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.dvgBooks = New System.Windows.Forms.DataGridView()
        CType(Me.dvgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 161)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Year Published"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 210)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Genre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(396, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 4
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(280, 66)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(163, 26)
        Me.txtTitle.TabIndex = 5
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(280, 109)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(163, 26)
        Me.txtAuthor.TabIndex = 6
        '
        'txtYearPublish
        '
        Me.txtYearPublish.Location = New System.Drawing.Point(280, 161)
        Me.txtYearPublish.Name = "txtYearPublish"
        Me.txtYearPublish.Size = New System.Drawing.Size(163, 26)
        Me.txtYearPublish.TabIndex = 7
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(280, 210)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(163, 26)
        Me.txtGenre.TabIndex = 8
        '
        'btnAdd2
        '
        Me.btnAdd2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd2.Location = New System.Drawing.Point(141, 344)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(95, 33)
        Me.btnAdd2.TabIndex = 9
        Me.btnAdd2.Text = "ADD"
        Me.btnAdd2.UseVisualStyleBackColor = True
        '
        'btnUpdate2
        '
        Me.btnUpdate2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate2.Location = New System.Drawing.Point(280, 344)
        Me.btnUpdate2.Name = "btnUpdate2"
        Me.btnUpdate2.Size = New System.Drawing.Size(95, 33)
        Me.btnUpdate2.TabIndex = 10
        Me.btnUpdate2.Text = "UPDATE"
        Me.btnUpdate2.UseVisualStyleBackColor = True
        '
        'btnDelete2
        '
        Me.btnDelete2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete2.Location = New System.Drawing.Point(418, 344)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(95, 33)
        Me.btnDelete2.TabIndex = 11
        Me.btnDelete2.Text = "DELETE"
        Me.btnDelete2.UseVisualStyleBackColor = True
        '
        'btnClear2
        '
        Me.btnClear2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear2.Location = New System.Drawing.Point(564, 344)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(95, 33)
        Me.btnClear2.TabIndex = 12
        Me.btnClear2.Text = "CLEAR"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'dvgBooks
        '
        Me.dvgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgBooks.Location = New System.Drawing.Point(508, 66)
        Me.dvgBooks.Name = "dvgBooks"
        Me.dvgBooks.RowHeadersWidth = 62
        Me.dvgBooks.RowTemplate.Height = 28
        Me.dvgBooks.Size = New System.Drawing.Size(280, 166)
        Me.dvgBooks.TabIndex = 13
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScrollMargin = New System.Drawing.Size(1, 0)
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dvgBooks)
        Me.Controls.Add(Me.btnClear2)
        Me.Controls.Add(Me.btnDelete2)
        Me.Controls.Add(Me.btnUpdate2)
        Me.Controls.Add(Me.btnAdd2)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.txtYearPublish)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dvgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublish As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents btnUpdate2 As Button
    Friend WithEvents btnDelete2 As Button
    Friend WithEvents btnClear2 As Button
    Friend WithEvents dvgBooks As DataGridView
End Class
