<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Management
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMovie = New System.Windows.Forms.Button()
        Me.btnSeat = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CIS_db = New WindowsApp1.CIS_dbDataSet()
        Me.CISdbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.CIS_db, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CISdbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(472, 571)
        Me.SplitContainer1.SplitterDistance = 135
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("LEMON MILK", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(78, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 86)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CINEMA"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnMovie)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnSeat)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnCustomer)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer2.Size = New System.Drawing.Size(472, 432)
        Me.SplitContainer2.SplitterDistance = 366
        Me.SplitContainer2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("LEMON MILK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(428, 43)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "CUSTOMER MANAGEMENT"
        '
        'btnMovie
        '
        Me.btnMovie.BackColor = System.Drawing.Color.White
        Me.btnMovie.Font = New System.Drawing.Font("LEMON MILK", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovie.Location = New System.Drawing.Point(46, 179)
        Me.btnMovie.Name = "btnMovie"
        Me.btnMovie.Size = New System.Drawing.Size(380, 44)
        Me.btnMovie.TabIndex = 11
        Me.btnMovie.Text = "edit"
        Me.btnMovie.UseVisualStyleBackColor = False
        '
        'btnSeat
        '
        Me.btnSeat.BackColor = System.Drawing.Color.White
        Me.btnSeat.Font = New System.Drawing.Font("LEMON MILK", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeat.Location = New System.Drawing.Point(46, 265)
        Me.btnSeat.Name = "btnSeat"
        Me.btnSeat.Size = New System.Drawing.Size(380, 44)
        Me.btnSeat.TabIndex = 13
        Me.btnSeat.Text = "delete"
        Me.btnSeat.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCustomer.Font = New System.Drawing.Font("LEMON MILK", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.Location = New System.Drawing.Point(46, 98)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(380, 44)
        Me.btnCustomer.TabIndex = 12
        Me.btnCustomer.Text = "add"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Maroon
        Me.Label10.Font = New System.Drawing.Font("LEMON MILK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(85, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(282, 43)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Only at cinema"
        '
        'CIS_db
        '
        Me.CIS_db.DataSetName = "CIS_db"
        Me.CIS_db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CISdbBindingSource
        '
        Me.CISdbBindingSource.DataSource = Me.CIS_db
        Me.CISdbBindingSource.Position = 0
        '
        'Customer_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 571)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Customer_Management"
        Me.Text = "Form4"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.CIS_db, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CISdbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMovie As Button
    Friend WithEvents btnSeat As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents CIS_db As CIS_dbDataSet
    Friend WithEvents CISdbBindingSource As BindingSource
End Class
