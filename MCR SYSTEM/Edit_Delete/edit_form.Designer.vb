<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class edit_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_form))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ra = New System.Windows.Forms.TextBox()
        Me.fin = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.txtto = New System.Windows.Forms.TextBox()
        Me.txtfrom = New System.Windows.Forms.TextBox()
        Me.auth = New System.Windows.Forms.CheckBox()
        Me.cert_post = New System.Windows.Forms.CheckBox()
        Me.txtprov = New System.Windows.Forms.TextBox()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.txtMun = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbInsert = New System.Windows.Forms.GroupBox()
        Me.cbolabel = New System.Windows.Forms.ComboBox()
        Me.txtTypeDoc = New System.Windows.Forms.ComboBox()
        Me.txtNamePet = New System.Windows.Forms.TextBox()
        Me.txtDocOw = New System.Windows.Forms.TextBox()
        Me.txtPet = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbInsert.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.BackColor = System.Drawing.Color.Gray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(881, 305)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(181, 40)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(149, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Year"
        '
        'year
        '
        Me.year.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.Location = New System.Drawing.Point(194, 75)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(99, 22)
        Me.year.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(314, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "RA."
        '
        'ra
        '
        Me.ra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ra.Location = New System.Drawing.Point(353, 75)
        Me.ra.Name = "ra"
        Me.ra.Size = New System.Drawing.Size(99, 22)
        Me.ra.TabIndex = 43
        '
        'fin
        '
        Me.fin.AutoSize = True
        Me.fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fin.Location = New System.Drawing.Point(25, 98)
        Me.fin.Name = "fin"
        Me.fin.Size = New System.Drawing.Size(69, 20)
        Me.fin.TabIndex = 40
        Me.fin.Text = "Finality"
        Me.fin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtyear)
        Me.GroupBox1.Controls.Add(Me.txtto)
        Me.GroupBox1.Controls.Add(Me.txtfrom)
        Me.GroupBox1.Controls.Add(Me.auth)
        Me.GroupBox1.Controls.Add(Me.cert_post)
        Me.GroupBox1.Controls.Add(Me.fin)
        Me.GroupBox1.Location = New System.Drawing.Point(567, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 138)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CERTIFICATES"
        '
        'txtyear
        '
        Me.txtyear.Enabled = False
        Me.txtyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear.Location = New System.Drawing.Point(169, 98)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(157, 22)
        Me.txtyear.TabIndex = 73
        '
        'txtto
        '
        Me.txtto.Enabled = False
        Me.txtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtto.Location = New System.Drawing.Point(332, 37)
        Me.txtto.Name = "txtto"
        Me.txtto.Size = New System.Drawing.Size(157, 22)
        Me.txtto.TabIndex = 72
        '
        'txtfrom
        '
        Me.txtfrom.Enabled = False
        Me.txtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfrom.Location = New System.Drawing.Point(169, 37)
        Me.txtfrom.Name = "txtfrom"
        Me.txtfrom.Size = New System.Drawing.Size(157, 22)
        Me.txtfrom.TabIndex = 71
        '
        'auth
        '
        Me.auth.AutoSize = True
        Me.auth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.auth.Location = New System.Drawing.Point(25, 68)
        Me.auth.Name = "auth"
        Me.auth.Size = New System.Drawing.Size(94, 20)
        Me.auth.TabIndex = 39
        Me.auth.Text = "Authenticity"
        Me.auth.UseVisualStyleBackColor = True
        '
        'cert_post
        '
        Me.cert_post.AutoSize = True
        Me.cert_post.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cert_post.Location = New System.Drawing.Point(25, 37)
        Me.cert_post.Name = "cert_post"
        Me.cert_post.Size = New System.Drawing.Size(150, 20)
        Me.cert_post.TabIndex = 38
        Me.cert_post.Text = "Certificate Of Posting"
        Me.cert_post.UseVisualStyleBackColor = True
        '
        'txtprov
        '
        Me.txtprov.Enabled = False
        Me.txtprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprov.Location = New System.Drawing.Point(736, 76)
        Me.txtprov.Name = "txtprov"
        Me.txtprov.Size = New System.Drawing.Size(326, 22)
        Me.txtprov.TabIndex = 41
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFemale.Location = New System.Drawing.Point(264, 233)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(72, 20)
        Me.rbFemale.TabIndex = 32
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMale.Location = New System.Drawing.Point(186, 233)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(56, 20)
        Me.rbMale.TabIndex = 31
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'txtMun
        '
        Me.txtMun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMun.Location = New System.Drawing.Point(736, 28)
        Me.txtMun.Name = "txtMun"
        Me.txtMun.Size = New System.Drawing.Size(326, 22)
        Me.txtMun.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.gbInsert)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1120, 381)
        Me.Panel1.TabIndex = 1
        '
        'gbInsert
        '
        Me.gbInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbInsert.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.gbInsert.Controls.Add(Me.cbolabel)
        Me.gbInsert.Controls.Add(Me.txtTypeDoc)
        Me.gbInsert.Controls.Add(Me.Label9)
        Me.gbInsert.Controls.Add(Me.btnSave)
        Me.gbInsert.Controls.Add(Me.year)
        Me.gbInsert.Controls.Add(Me.Label8)
        Me.gbInsert.Controls.Add(Me.ra)
        Me.gbInsert.Controls.Add(Me.GroupBox1)
        Me.gbInsert.Controls.Add(Me.txtprov)
        Me.gbInsert.Controls.Add(Me.rbFemale)
        Me.gbInsert.Controls.Add(Me.rbMale)
        Me.gbInsert.Controls.Add(Me.txtMun)
        Me.gbInsert.Controls.Add(Me.txtNamePet)
        Me.gbInsert.Controls.Add(Me.txtDocOw)
        Me.gbInsert.Controls.Add(Me.txtPet)
        Me.gbInsert.Controls.Add(Me.Label7)
        Me.gbInsert.Controls.Add(Me.Label6)
        Me.gbInsert.Controls.Add(Me.Label5)
        Me.gbInsert.Controls.Add(Me.Label4)
        Me.gbInsert.Controls.Add(Me.Label3)
        Me.gbInsert.Controls.Add(Me.Label2)
        Me.gbInsert.Controls.Add(Me.Label1)
        Me.gbInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbInsert.Location = New System.Drawing.Point(3, 0)
        Me.gbInsert.Name = "gbInsert"
        Me.gbInsert.Size = New System.Drawing.Size(1117, 388)
        Me.gbInsert.TabIndex = 3
        Me.gbInsert.TabStop = False
        '
        'cbolabel
        '
        Me.cbolabel.FormattingEnabled = True
        Me.cbolabel.Items.AddRange(New Object() {"CCE", "CFN"})
        Me.cbolabel.Location = New System.Drawing.Point(194, 33)
        Me.cbolabel.Name = "cbolabel"
        Me.cbolabel.Size = New System.Drawing.Size(86, 21)
        Me.cbolabel.TabIndex = 48
        Me.cbolabel.Text = "--SELECT--"
        '
        'txtTypeDoc
        '
        Me.txtTypeDoc.FormattingEnabled = True
        Me.txtTypeDoc.Items.AddRange(New Object() {"LIVE BIRTH", "MARRIAGE", "DEATH"})
        Me.txtTypeDoc.Location = New System.Drawing.Point(188, 193)
        Me.txtTypeDoc.Name = "txtTypeDoc"
        Me.txtTypeDoc.Size = New System.Drawing.Size(264, 21)
        Me.txtTypeDoc.TabIndex = 47
        '
        'txtNamePet
        '
        Me.txtNamePet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamePet.Location = New System.Drawing.Point(188, 155)
        Me.txtNamePet.Name = "txtNamePet"
        Me.txtNamePet.Size = New System.Drawing.Size(264, 22)
        Me.txtNamePet.TabIndex = 28
        '
        'txtDocOw
        '
        Me.txtDocOw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocOw.Location = New System.Drawing.Point(188, 115)
        Me.txtDocOw.Name = "txtDocOw"
        Me.txtDocOw.Size = New System.Drawing.Size(264, 22)
        Me.txtDocOw.TabIndex = 26
        '
        'txtPet
        '
        Me.txtPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPet.Location = New System.Drawing.Point(286, 32)
        Me.txtPet.Name = "txtPet"
        Me.txtPet.Size = New System.Drawing.Size(166, 22)
        Me.txtPet.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "TYPE OF DOCUMENT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(564, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "MUNICIPALITY/CITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(564, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "PROVINCE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "NAME OF PETITIONER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "GENDER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "DOCUMENT OWNER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "PETITION NO."
        '
        'edit_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1120, 381)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "edit_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Form"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gbInsert.ResumeLayout(False)
        Me.gbInsert.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSave As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label9 As Label
    Friend WithEvents year As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ra As TextBox
    Friend WithEvents fin As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents auth As CheckBox
    Friend WithEvents cert_post As CheckBox
    Friend WithEvents txtprov As TextBox
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents txtMun As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gbInsert As GroupBox
    Friend WithEvents txtNamePet As TextBox
    Friend WithEvents txtDocOw As TextBox
    Friend WithEvents txtPet As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTypeDoc As ComboBox
    Friend WithEvents cbolabel As ComboBox
    Friend WithEvents txtyear As TextBox
    Friend WithEvents txtto As TextBox
    Friend WithEvents txtfrom As TextBox
End Class
