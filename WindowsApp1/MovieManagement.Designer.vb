<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovieManagement))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.btnEdit = New System.Windows.Forms.PictureBox()
        Me.btnDel = New System.Windows.Forms.PictureBox()
        Me.DGVData = New System.Windows.Forms.DataGridView()
        Me.CIS_dbDataSet = New WindowsApp1.CIS_dbDataSet()
        Me.MovieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovieTableAdapter = New WindowsApp1.CIS_dbDataSetTableAdapters.MovieTableAdapter()
        Me.MovieIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieGenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIS_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkRed
        Me.btnCancel.Font = New System.Drawing.Font("LEMON MILK", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(612, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(30, 30)
        Me.btnCancel.TabIndex = 59
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Location = New System.Drawing.Point(131, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(380, 5)
        Me.Panel4.TabIndex = 6
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("LEMON MILK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Title.Location = New System.Drawing.Point(126, 25)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(390, 53)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Movie Management"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 229)
        Me.Panel1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnDel)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 101)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(422, 102)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Location = New System.Drawing.Point(313, 20)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 70)
        Me.Panel2.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(331, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "REFRESH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "EDIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DELETE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ADD"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(344, 23)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(40, 39)
        Me.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(31, 23)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(40, 39)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(136, 23)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(40, 39)
        Me.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.TabStop = False
        '
        'btnDel
        '
        Me.btnDel.Image = CType(resources.GetObject("btnDel.Image"), System.Drawing.Image)
        Me.btnDel.Location = New System.Drawing.Point(244, 23)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(40, 39)
        Me.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDel.TabIndex = 0
        Me.btnDel.TabStop = False
        '
        'DGVData
        '
        Me.DGVData.AutoGenerateColumns = False
        Me.DGVData.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovieIDDataGridViewTextBoxColumn, Me.MovieTitleDataGridViewTextBoxColumn, Me.MovieGenreDataGridViewTextBoxColumn})
        Me.DGVData.DataSource = Me.MovieBindingSource
        Me.DGVData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVData.GridColor = System.Drawing.SystemColors.Control
        Me.DGVData.Location = New System.Drawing.Point(0, 229)
        Me.DGVData.Name = "DGVData"
        Me.DGVData.RowHeadersWidth = 51
        Me.DGVData.RowTemplate.Height = 24
        Me.DGVData.Size = New System.Drawing.Size(647, 224)
        Me.DGVData.TabIndex = 9
        '
        'CIS_dbDataSet
        '
        Me.CIS_dbDataSet.DataSetName = "CIS_dbDataSet"
        Me.CIS_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MovieBindingSource
        '
        Me.MovieBindingSource.DataMember = "Movie"
        Me.MovieBindingSource.DataSource = Me.CIS_dbDataSet
        '
        'MovieTableAdapter
        '
        Me.MovieTableAdapter.ClearBeforeFill = True
        '
        'MovieIDDataGridViewTextBoxColumn
        '
        Me.MovieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID"
        Me.MovieIDDataGridViewTextBoxColumn.HeaderText = "MovieID"
        Me.MovieIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MovieIDDataGridViewTextBoxColumn.Name = "MovieIDDataGridViewTextBoxColumn"
        Me.MovieIDDataGridViewTextBoxColumn.Width = 125
        '
        'MovieTitleDataGridViewTextBoxColumn
        '
        Me.MovieTitleDataGridViewTextBoxColumn.DataPropertyName = "MovieTitle"
        Me.MovieTitleDataGridViewTextBoxColumn.HeaderText = "MovieTitle"
        Me.MovieTitleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MovieTitleDataGridViewTextBoxColumn.Name = "MovieTitleDataGridViewTextBoxColumn"
        Me.MovieTitleDataGridViewTextBoxColumn.Width = 125
        '
        'MovieGenreDataGridViewTextBoxColumn
        '
        Me.MovieGenreDataGridViewTextBoxColumn.DataPropertyName = "MovieGenre"
        Me.MovieGenreDataGridViewTextBoxColumn.HeaderText = "MovieGenre"
        Me.MovieGenreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MovieGenreDataGridViewTextBoxColumn.Name = "MovieGenreDataGridViewTextBoxColumn"
        Me.MovieGenreDataGridViewTextBoxColumn.Width = 125
        '
        'MovieManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 453)
        Me.Controls.Add(Me.DGVData)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MovieManagement"
        Me.Text = "MovieManagement"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIS_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRefresh As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents btnEdit As PictureBox
    Friend WithEvents btnDel As PictureBox
    Friend WithEvents DGVData As DataGridView
    Friend WithEvents CIS_dbDataSet As CIS_dbDataSet
    Friend WithEvents MovieBindingSource As BindingSource
    Friend WithEvents MovieTableAdapter As CIS_dbDataSetTableAdapters.MovieTableAdapter
    Friend WithEvents MovieIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieGenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
