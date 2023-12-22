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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblID = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TextBoxDesc = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(69, 95)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(26, 16)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID :"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(98, 92)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(135, 22)
        Me.TextBoxID.TabIndex = 1
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(98, 142)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(135, 22)
        Me.TextBoxName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(45, 145)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(50, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name :"
        '
        'TextBoxDesc
        '
        Me.TextBoxDesc.Location = New System.Drawing.Point(98, 195)
        Me.TextBoxDesc.Name = "TextBoxDesc"
        Me.TextBoxDesc.Size = New System.Drawing.Size(135, 22)
        Me.TextBoxDesc.TabIndex = 5
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(14, 198)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(81, 16)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(314, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(435, 179)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(92, 33)
        Me.btnAddImage.TabIndex = 7
        Me.btnAddImage.Text = "Add Image"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 270)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(614, 280)
        Me.DataGridView1.TabIndex = 8
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(544, 42)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(92, 33)
        Me.btnInsert.TabIndex = 9
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(544, 92)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 33)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(544, 140)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 33)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(98, 43)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(135, 22)
        Me.TextBoxSearch.TabIndex = 13
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(40, 46)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(56, 16)
        Me.lblSearch.TabIndex = 12
        Me.lblSearch.Text = "Search :"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(314, 179)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(92, 33)
        Me.btnFind.TabIndex = 14
        Me.btnFind.Text = "Find Image"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(109, 231)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 33)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(544, 181)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(92, 33)
        Me.btnAll.TabIndex = 16
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 562)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAddImage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxDesc)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.lblID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Store Management"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents TextBoxDesc As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAddImage As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAll As Button
End Class
