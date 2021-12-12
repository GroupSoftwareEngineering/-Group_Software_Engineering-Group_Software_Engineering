<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.SystemColors.GrayText
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(459, 413)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(103, 35)
        Me.button2.TabIndex = 276
        Me.button2.Text = "CANCEL"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.SystemColors.GrayText
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(238, 413)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(103, 35)
        Me.button1.TabIndex = 275
        Me.button1.Text = "ADD"
        Me.button1.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.TextBox3)
        Me.groupBox1.Controls.Add(Me.textBox2)
        Me.groupBox1.Controls.Add(Me.textBox1)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.groupBox1.Location = New System.Drawing.Point(238, 111)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(324, 277)
        Me.groupBox1.TabIndex = 274
        Me.groupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Status Booked"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(36, 200)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(232, 26)
        Me.TextBox3.TabIndex = 143
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(36, 127)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(232, 26)
        Me.textBox2.TabIndex = 142
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(36, 55)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(232, 26)
        Me.textBox1.TabIndex = 141
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(32, 92)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(81, 20)
        Me.label3.TabIndex = 139
        Me.label3.Text = "Seat Row"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(32, 27)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(65, 20)
        Me.label2.TabIndex = 138
        Me.label2.Text = "Seat ID"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(269, 67)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(213, 29)
        Me.label1.TabIndex = 273
        Me.label1.Text = "ADD MOVIE SEAT"
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(800, 641)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Add"
        Me.Text = "Add"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents Label4 As Label
    Private WithEvents TextBox3 As TextBox
End Class
