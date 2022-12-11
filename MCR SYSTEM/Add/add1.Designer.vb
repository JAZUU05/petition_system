<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gbInsert = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbolabel = New System.Windows.Forms.ComboBox()
        Me.txtTypeDoc = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ra = New System.Windows.Forms.TextBox()
        Me.txtNamePet = New System.Windows.Forms.TextBox()
        Me.txtDocOw = New System.Windows.Forms.TextBox()
        Me.txtPet = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtto = New System.Windows.Forms.TextBox()
        Me.txtfrom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.auth = New System.Windows.Forms.CheckBox()
        Me.cert_post = New System.Windows.Forms.CheckBox()
        Me.fin = New System.Windows.Forms.CheckBox()
        Me.txtprov = New System.Windows.Forms.TextBox()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.txtMun = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInsert.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.gbInsert)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1120, 647)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column11})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 349)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1112, 288)
        Me.DataGridView1.TabIndex = 4
        '
        'gbInsert
        '
        Me.gbInsert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbInsert.Controls.Add(Me.GroupBox2)
        Me.gbInsert.Controls.Add(Me.GroupBox1)
        Me.gbInsert.Controls.Add(Me.txtprov)
        Me.gbInsert.Controls.Add(Me.rbFemale)
        Me.gbInsert.Controls.Add(Me.rbMale)
        Me.gbInsert.Controls.Add(Me.txtMun)
        Me.gbInsert.Controls.Add(Me.Label6)
        Me.gbInsert.Controls.Add(Me.Label5)
        Me.gbInsert.Controls.Add(Me.Label3)
        Me.gbInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbInsert.Location = New System.Drawing.Point(3, 0)
        Me.gbInsert.Name = "gbInsert"
        Me.gbInsert.Size = New System.Drawing.Size(1112, 291)
        Me.gbInsert.TabIndex = 3
        Me.gbInsert.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbolabel)
        Me.GroupBox2.Controls.Add(Me.txtTypeDoc)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.year)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ra)
        Me.GroupBox2.Controls.Add(Me.txtNamePet)
        Me.GroupBox2.Controls.Add(Me.txtDocOw)
        Me.GroupBox2.Controls.Add(Me.txtPet)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 220)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'cbolabel
        '
        Me.cbolabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbolabel.FormattingEnabled = True
        Me.cbolabel.Items.AddRange(New Object() {"CCE", "CFN"})
        Me.cbolabel.Location = New System.Drawing.Point(179, 18)
        Me.cbolabel.Name = "cbolabel"
        Me.cbolabel.Size = New System.Drawing.Size(88, 23)
        Me.cbolabel.TabIndex = 70
        Me.cbolabel.Text = "--SELECT--"
        '
        'txtTypeDoc
        '
        Me.txtTypeDoc.FormattingEnabled = True
        Me.txtTypeDoc.Items.AddRange(New Object() {"LIVE BIRTH", "MARRIAGE", "DEATH"})
        Me.txtTypeDoc.Location = New System.Drawing.Point(180, 182)
        Me.txtTypeDoc.Name = "txtTypeDoc"
        Me.txtTypeDoc.Size = New System.Drawing.Size(263, 21)
        Me.txtTypeDoc.TabIndex = 69
        Me.txtTypeDoc.Text = "--SELECT--"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(182, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "*Required"
        Me.Label15.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(183, 162)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "*Required"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(341, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "*Required"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(182, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "*Required"
        Me.Label12.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(140, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 16)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Year"
        '
        'year
        '
        Me.year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.year.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.Location = New System.Drawing.Point(180, 60)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(99, 22)
        Me.year.TabIndex = 63
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(305, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "RA."
        '
        'ra
        '
        Me.ra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ra.Location = New System.Drawing.Point(344, 60)
        Me.ra.Name = "ra"
        Me.ra.Size = New System.Drawing.Size(99, 22)
        Me.ra.TabIndex = 61
        '
        'txtNamePet
        '
        Me.txtNamePet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamePet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamePet.Location = New System.Drawing.Point(179, 140)
        Me.txtNamePet.Name = "txtNamePet"
        Me.txtNamePet.Size = New System.Drawing.Size(264, 22)
        Me.txtNamePet.TabIndex = 60
        '
        'txtDocOw
        '
        Me.txtDocOw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocOw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocOw.Location = New System.Drawing.Point(179, 100)
        Me.txtDocOw.Name = "txtDocOw"
        Me.txtDocOw.Size = New System.Drawing.Size(264, 22)
        Me.txtDocOw.TabIndex = 58
        '
        'txtPet
        '
        Me.txtPet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPet.Location = New System.Drawing.Point(273, 17)
        Me.txtPet.Name = "txtPet"
        Me.txtPet.Size = New System.Drawing.Size(170, 22)
        Me.txtPet.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 16)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "TYPE OF DOCUMENT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 16)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "NAME OF PETITIONER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "DOCUMENT OWNER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "PETITION NO."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtto)
        Me.GroupBox1.Controls.Add(Me.txtfrom)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtyear)
        Me.GroupBox1.Controls.Add(Me.auth)
        Me.GroupBox1.Controls.Add(Me.cert_post)
        Me.GroupBox1.Controls.Add(Me.fin)
        Me.GroupBox1.Location = New System.Drawing.Point(597, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 138)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CERTIFICATES"
        '
        'txtto
        '
        Me.txtto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtto.Enabled = False
        Me.txtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtto.Location = New System.Drawing.Point(341, 38)
        Me.txtto.Name = "txtto"
        Me.txtto.Size = New System.Drawing.Size(157, 22)
        Me.txtto.TabIndex = 71
        '
        'txtfrom
        '
        Me.txtfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfrom.Enabled = False
        Me.txtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfrom.Location = New System.Drawing.Point(178, 39)
        Me.txtfrom.Name = "txtfrom"
        Me.txtfrom.Size = New System.Drawing.Size(157, 22)
        Me.txtfrom.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(174, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "*Required"
        Me.Label10.Visible = False
        '
        'txtyear
        '
        Me.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtyear.Enabled = False
        Me.txtyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear.Location = New System.Drawing.Point(178, 95)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(189, 22)
        Me.txtyear.TabIndex = 41
        '
        'auth
        '
        Me.auth.AutoSize = True
        Me.auth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.auth.Location = New System.Drawing.Point(25, 68)
        Me.auth.Name = "auth"
        Me.auth.Size = New System.Drawing.Size(87, 19)
        Me.auth.TabIndex = 39
        Me.auth.Text = "Authenticity"
        Me.auth.UseVisualStyleBackColor = True
        '
        'cert_post
        '
        Me.cert_post.AutoSize = True
        Me.cert_post.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cert_post.Location = New System.Drawing.Point(25, 37)
        Me.cert_post.Name = "cert_post"
        Me.cert_post.Size = New System.Drawing.Size(139, 19)
        Me.cert_post.TabIndex = 38
        Me.cert_post.Text = "Certificate Of Posting"
        Me.cert_post.UseVisualStyleBackColor = True
        '
        'fin
        '
        Me.fin.AutoSize = True
        Me.fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fin.Location = New System.Drawing.Point(25, 98)
        Me.fin.Name = "fin"
        Me.fin.Size = New System.Drawing.Size(64, 19)
        Me.fin.TabIndex = 40
        Me.fin.Text = "Finality"
        Me.fin.UseVisualStyleBackColor = True
        '
        'txtprov
        '
        Me.txtprov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprov.Location = New System.Drawing.Point(775, 73)
        Me.txtprov.Name = "txtprov"
        Me.txtprov.Size = New System.Drawing.Size(326, 22)
        Me.txtprov.TabIndex = 29
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFemale.Location = New System.Drawing.Point(264, 233)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(69, 20)
        Me.rbFemale.TabIndex = 32
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMale.Location = New System.Drawing.Point(188, 233)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(54, 20)
        Me.rbMale.TabIndex = 31
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'txtMun
        '
        Me.txtMun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMun.Location = New System.Drawing.Point(775, 25)
        Me.txtMun.Name = "txtMun"
        Me.txtMun.Size = New System.Drawing.Size(326, 22)
        Me.txtMun.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(603, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "MUNICIPALITY/CITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(603, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "PROVINCE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "GENDER"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.BackColor = System.Drawing.Color.Gray
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(927, 297)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(181, 46)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(0, 349)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1015, 288)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "petition_id"
        Me.Column10.HeaderText = "PETITION ID"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 126
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "petition"
        Me.Column1.HeaderText = "PETITION NUMBER"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 178
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ra"
        Me.Column2.HeaderText = "RA"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 59
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "doc_owner"
        Me.Column3.HeaderText = "DOC OWNER"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 131
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "gender"
        Me.Column4.HeaderText = "GENDER"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 110
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "name_of_petitioner"
        Me.Column5.HeaderText = "NAME OF PETITIONER"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 203
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "type_doc"
        Me.Column6.HeaderText = "TYPE OF DOCUMENT"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 193
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "municipality"
        Me.Column7.HeaderText = "MUNICIPALITY"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 158
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "province"
        Me.Column8.HeaderText = "PROVINCE"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "certificate"
        Me.Column9.HeaderText = "CERTIFICATES"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 162
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "year_final"
        Me.Column11.HeaderText = "Finality Year"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 123
        '
        'add1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1120, 647)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "add1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ADD RECORDS"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInsert.ResumeLayout(False)
        Me.gbInsert.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbInsert As GroupBox
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents txtMun As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents fin As CheckBox
    Friend WithEvents auth As CheckBox
    Friend WithEvents cert_post As CheckBox
    Friend WithEvents txtprov As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtyear As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents year As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ra As TextBox
    Friend WithEvents txtNamePet As TextBox
    Friend WithEvents txtDocOw As TextBox
    Friend WithEvents txtPet As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTypeDoc As ComboBox
    Friend WithEvents cbolabel As ComboBox
    Friend WithEvents txtto As TextBox
    Friend WithEvents txtfrom As TextBox
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
